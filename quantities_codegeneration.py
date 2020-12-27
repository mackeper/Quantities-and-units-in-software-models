import re
import math
from datetime import datetime
from pathlib import Path

SYMBOL_SUFFIX = [
    '',
    '',
    '²',
    '³',
]

NAME_SUFFIX = [
    '',
    '',
    'Sqr',
    'Cub',
]

NAMESPACE = 'RayQuantities'
NUMBER_OF_DECIMALS = 2

# Dict to define all the base quantities
# The restriction tuple must the of the same size as the base_q dict as the first element
# in restriction referes to the first element in base_q (I know it could be done better...)
base_q = {
    'Length': {
        'units': [
            {'name': 'Centimeter', 'symbol':'cm', 'factor': 1, 'offset': 0},
            {'name': 'Millimeter', 'symbol':'mm', 'factor': 1/10, 'offset': 0},
            {'name': 'Meter', 'symbol':'m', 'factor': 100, 'offset': 0},
            {'name': 'Inch', 'symbol':'in', 'factor': 2.56, 'offset': 0, 'plural_name': 'Inches'}, 
        ],
        'restriction': (3, 1, 3, 0, 0, 0, 0, 0),
    },
    'Mass': {
        'units': [
            {'name': 'Kilogram', 'symbol':'kg', 'factor': 1, 'offset': 0},
        ],
        'restriction': (3, 1, 3, 0, 0, 0, 0, 0),
    },
    'Time': {
        'units': [
            {'name': 'Second', 'symbol':'s', 'factor': 1, 'offset': 0},
        ],
        'restriction': (3, 1, 3, 0, 0, 0, 0, 0),
    },
    'ElectricCurrent': {
        'units': [
            {'name': 'Ampere', 'symbol':'A', 'factor': 1, 'offset': 0},
        ],
        'restriction': (0, 0, 0, 1, 0, 0, 0, 0),
    },
    'Temperature': { # Thermodynamic temperature
        'units': [
            {'name': 'Kelvin', 'symbol':'K', 'factor': 1, 'offset': 0},
            {'name': 'Celsius', 'symbol':'°C', 'factor': 1, 'offset': 273.15},
        ],
        'restriction': (0, 0, 0, 0, 1, 0, 0, 0),
    },
    'AmountOfSubstance':{
        'units': [
            {'name': 'Mole', 'symbol':'mol', 'factor': 1, 'offset': 0},
        ],
        'restriction': (0, 0, 0, 0, 0, 1, 0, 0),
    },
    'LuminousIntensity':{
        'units': [
            {'name': 'Candela', 'symbol':'cd', 'factor': 1, 'offset': 0},
        ],
        'restriction': (0, 0, 0, 0, 0, 0, 1, 0),
    },
    'Angle':{
        'units': [
            {'name': 'Radian', 'symbol':'rad', 'factor': 1, 'offset': 0},
            {'name': 'Degree', 'symbol':'°', 'factor': math.pi/180, 'offset': 0},
        ],
        'restriction': (0, 0, 0, 0, 0, 0, 0, 1),
    },
}

# Dict to define all the derived quantities
# Maps the dimension of a quantity to a derived quantity
derived_q = {
    (2, 0, -2, 0, 0, 0, 0, 0): {
        'name': 'QDose',
        'units': [
            {'name': 'Gray', 'symbol':'Gy', 'factor': 10000, 'offset': 0},
            {'name': 'Centigray', 'symbol':'cGy', 'factor': 100, 'offset': 0},
        ],
    },
    (2, 0, 0, 0, 0, 0, 0, 0): {
        'name': 'Area',
    },
    (3, 0, 0, 0, 0, 0, 0, 0): {
        'name': 'Volume',
    },
    (1, 0, -1, 0, 0, 0, 0, 0): {
        'name': 'Speed',
    },
    (1, 0, -2, 0, 0, 0, 0, 0): {
        'name': 'Acceleration',
    },
    (-3, 1, 0, 0, 0, 0, 0, 0): {
        'name': 'Density'
    },
    (1, 1, -2, 0, 0, 0, 0, 0): {
        'name': 'Force',
        'units': [
            {'name': 'Newton', 'symbol':'N', 'factor': 1, 'offset': 0},
        ],
    },
}

# Global variables
total_combinations = 0
all_combinations = []
all_types = []
operator_implemented = {}
exps = (0,)*len(base_q) 
dynprog_mem = {}

def get_unit_plural_name(unit):
    print('plural_name' not in unit, unit)
    return unit['name'] + 's' if 'plural_name' not in unit else unit['plural_name']

class Type():
    def __init__(self, comb):
        self.exps = comb[1]
        self.base_q_name = comb[0]
        if self.bad_type():
            raise ValueError("Bad type {}".format(self.exps))
        self.units = []
        self.derived = self.exps in derived_q
        self.quantities = []
        self.name = ""
        self.plural = ""
        self.is_dimensionless = self.exps == (0,)*len(self.exps)

        self.extract_quantities() # sets quantities
        self.quantities_to_type_name() #sets name
        self.init_type() # sets units

        self.lower_name = self.name.lower()
    
    def get_exps(self):
        return self.exps

    def get_name(self):
        return self.name

    def get_units(self):
        return self.units

    def get_lower_name(self):
        return self.lower_name

    def get_base_q_name(self):
        return self.base_q_name

    def extract_quantities(self):
        zipped = list(zip(base_q, self.exps))
        zipped = list(filter(lambda x: x[1] != 0, zipped))
        self.quantities = sorted(zipped, key=lambda x: -x[1]) # end result e.g.[('Length', 3), ('Mass', 1), ('Time', -2)]
    
    def quantities_to_type_name(self):
        if self.is_dimensionless:
            self.name = "Dimensionless"
            return

        if self.derived and 'name' in derived_q[self.exps]:
            self.name = derived_q[self.exps]['name']
            return

        neg = False
        for z in self.quantities:
            if z[1] < 0 and not neg:
                neg = True
                self.name = self.name + "Per"
            if z[1] != 0:
                self.name = self.name + z[0] + NAME_SUFFIX[abs(z[1])]
        

    def init_type(self):
        # Dimensionless
        if self.exps == len(self.exps)*(0,):
            self.units = [{'name': '', 'symbol':'', 'factor': 1, 'offset': 0}]
            return

        build_units = [] # (dict, bool)

        # Add base units
        first_exp = self.quantities[0][1]
        for unit in base_q[self.quantities[0][0]]['units']:    # first quantity
            if unit['offset'] != 0 and first_exp > 1:
                raise AttributeError('1, Cannot have offsets if exponent is larger than 1')
            build_units.append(({
                'name':   unit['name']+NAME_SUFFIX[abs(first_exp)] if first_exp > 0 else "Per"+unit['name']+NAME_SUFFIX[abs(first_exp)],
                'symbol': unit['symbol']+SYMBOL_SUFFIX[abs(first_exp)] if first_exp > 0 else "/"+unit['symbol']+SYMBOL_SUFFIX[abs(first_exp)],
                'factor': unit['factor']**first_exp if first_exp > 0 else 1/unit['factor']**first_exp,
                'offset': unit['offset']
            }, True if first_exp < 0 else False)) 

        for base_q_name_and_exp in self.quantities[1:]:    # the rest of quantities
            base_q_name = base_q_name_and_exp[0]
            base_q_exp = base_q_name_and_exp[1]
            next_build_units = []
            for base_unit in base_q[base_q_name]['units']:
                for build_unit_idx in range(len(build_units)):
                    new_unit = build_units[build_unit_idx][0].copy()
                    neg = build_units[build_unit_idx][1]

                    if base_q_exp < 0 and not neg:
                        new_unit['name'] = new_unit['name'] + "Per" + base_unit['name']+NAME_SUFFIX[abs(base_q_exp)]
                        new_unit['symbol'] = new_unit['symbol'] + "/" + base_unit['symbol']+SYMBOL_SUFFIX[abs(base_q_exp)]
                        neg = True
                    else:
                        new_unit['name'] = new_unit['name'] + base_unit['name']+NAME_SUFFIX[abs(base_q_exp)]
                        new_unit['symbol'] = new_unit['symbol'] + " " + base_unit['symbol']+SYMBOL_SUFFIX[abs(base_q_exp)]
                    
                    if neg:
                        new_unit['factor'] = new_unit['factor'] / (base_unit['factor']**abs(base_q_exp))
                    else:
                        new_unit['factor'] = new_unit['factor'] * (base_unit['factor']**abs(base_q_exp))

                    if base_unit['offset'] != 0:
                        if base_q_exp > 1:
                            raise AttributeError('2, Cannot have offsets if exponent is larger than 1')
                        if new_unit['offset'] == 0: # No offset set yet
                            new_unit['offset'] = base_unit['offset'] if not neg else -base_unit['offset']
                        else:
                            raise AttributeError('3, Cannot have multiple offsets')

                    next_build_units.append((new_unit, neg))
            build_units = next_build_units.copy()
        build_units = list(map(lambda x: x[0], build_units))

        # Add derived units
        if self.exps in derived_q and 'units' in derived_q[self.exps]:
            for unit in derived_q[self.exps]['units']:
                build_units.append(unit)

        self.units = build_units

    def bad_type(self):
        base_q_name = self.get_base_q_name()
        for i in range(len(self.get_exps())):
            if self.get_exps()[i] < -base_q[base_q_name]['restriction'][i] or self.get_exps()[i] > base_q[base_q_name]['restriction'][i]:
                return True
        return False

    def __str__(self):
        return "{} {} {}".format(self.exps, self.name, self.units)

    def __add__(self, other):
        res_exps = tuple([a+b for a, b in zip(self.get_exps(), other.get_exps())])
        return Type((self.get_base_q_name(), res_exps))

    def __sub__(self, other):
        res_exps = tuple([a-b for a, b in zip(self.get_exps(), other.get_exps())])
        return Type((self.get_base_q_name(), res_exps))


def hash_exps(exps):
    x = 10**len(exps)
    ehash = 0
    for i in exps:
        ehash = ehash + x*(i+10)
        x  = x / 10
    return ehash

def sort_combination_on_abs_magnitude(types: [Type]) -> [Type]:
    return sorted(types, key=lambda x: sum(map(abs, x.get_exps())))


def gen_units(type):
    units_string = []
    platform_unit = type.get_units()[0]
    for unit in type.get_units():
        units_string.append("  private static Unit_ {}_ = new Unit_(\"{}\", \"{}\", {}, {});"
                .format(unit['name'].lower(), unit['name'], unit['symbol'], unit['factor'], unit['offset']))  


    units_string.append("  private static Unit_ platformUnit_ = {}_;".format(platform_unit['name'].lower()))
    units_string.append("  private static Unit_ displayUnit_ = {}_;".format(platform_unit['name'].lower()))

    return '\n'.join(units_string)

def gen_operator(o1, o2, res, sign):
    op_key = sign+"-"+o1.get_name()+"-"+o2.get_name()
    global operator_implemented
    if op_key in operator_implemented:
        return ""
    operator_implemented[op_key] = True
    return "public static {2} operator{3}({0} o1, {1} o2) => new {2}(o1.Value_ {3} o2.Value_);".format(
        o1.get_name(), o2.get_name(), res.get_name(), sign)

def gen_add_operator(o1, o2):
    if o1.get_base_q_name == o2.get_base_q_name:
        return gen_operator(o1, o2, o1, "+")
    return ""

def gen_sub_operator(o1, o2):
    if o1.get_base_q_name == o2.get_base_q_name:
        return gen_operator(o1, o2, o1, "-")
    return ""

def gen_mul_operator(o1, o2):
    try:
        res = o1 + o2
    except ValueError:
        return ""
    return gen_operator(o1, o2, res, "*")

def gen_div_operator(o1, o2):
    try:
        res = o1 - o2
    except ValueError:
        return ""
    return gen_operator(o1, o2, res, "/")

def gen_operators(type):
    operators = [
        gen_add_operator,
        gen_sub_operator,
        gen_mul_operator,
        gen_div_operator,
    ]
    operators_string = []

    # operator with self
    for o in operators:
        res = o(type, type)
        if res:
            operators_string.append(res)
    
    # operator with others
    operators_string.append("")
    for i in all_types:
        tmp_type = i
        for o in operators:
            res = o(type, tmp_type)
            if res:
                operators_string.append(res)
            res = o(tmp_type, type)
            if res:
                operators_string.append(res)
        operators_string.append("")
    return operators_string

def gen_comparison(type):
    comparison_string = """
  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is {0} other && Equals(other);
  public bool Equals({0} other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo({0} other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {{
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is {0} other)) throw new ArgumentException("Object is not a {0}.", nameof(obj));
    return CompareTo(other);
  }}

  public static bool operator ==({0} l1, {0} l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=({0} l1, {0} l2) => !(l1 == l2);
  public static bool operator <({0} l1, {0} l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >({0} l1, {0} l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=({0} l1, {0} l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=({0} l1, {0} l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    """.format(type.get_name())
    return comparison_string

def gen_conversions(type):
    conversions_string = []
    for unit in type.get_units():
        unit_plural_name = get_unit_plural_name(unit)
        conversions_string.append("  public static {0} From{1}(double value, double minValue, double maxValue) => new {0}((value + {2}_.Offset) * {2}_.Factor, minValue * {2}_.Factor, maxValue * {2}_.Factor);".format(type.get_name(), unit_plural_name, unit['name'].lower()))
        conversions_string.append("  public static {0} From{1}(double value) => new {0}((value + {2}_.Offset) * {2}_.Factor);".format(type.get_name(), unit_plural_name, unit['name'].lower()))
        conversions_string.append("  public double GetValueIn{0}() => (Value_ - {1}_.Offset) / {1}_.Factor;".format(unit_plural_name, unit['name'].lower()))
    conversions_string.append('')
    return '\n'.join(conversions_string)
    
def gen_rules(type):
    rules_string = """
  public double MinValue {{ get; }}
  public double MaxValue {{ get; }}
  public bool HasMinValue {{ get; }}
  public bool HasMaxValue {{ get; }}
  public bool ValidateRules(bool throwOnFail=true)
  {{
    bool fail = false;
    if (this.HasMinValue && this.Value_ < this.MinValue)
    {{
      fail = true;
    }}  
    if (this.HasMaxValue && this.Value_ > this.MaxValue)
    {{
      fail = true;
    }}  
    if (fail && throwOnFail)
    {{
      throw new System.ArgumentException("{} is outside its bounds.");
    }}
    else if (fail)
    {{
      return false;
    }}  
    return true;
  }}
""".format(type.get_name())
    return rules_string

def gen_class(type):
    class_string = []
    class_string.append("""
  [Serializable]
  public sealed class {0} : Quantity, IEquatable<{0}>, IComparable
  {{  
    internal {0}(double value) : base(value, {1})
    {{
      {0}.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }}
    internal {0}(double value, double minValue, double maxValue) : base(value, {1})
    {{
      {0}.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }}
    public {0}({0} other) : base(other)
    {{
      {0}.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }}
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {{
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey(\"{0}\"))
    {{
      switch(FakeDatabase.Units[\"{0}\"])
      {{""".format(type.get_name(), NUMBER_OF_DECIMALS))
    
    for unit in type.get_units():
        class_string.append("        case \"{0}\": displayUnit_ = {0}_; break;".format(unit['name'].lower()))
    
    class_string.append("        default: displayUnit_ = platformUnit_; break;")
    class_string.append("""      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  """)

    class_string.append('#region units')
    class_string.append(gen_units(type))
    class_string.append('#endregion\n')

    class_string.append('#region comparisons')
    class_string.append(gen_comparison(type))
    class_string.append('#endregion\n')

    class_string.append('#region conversions')
    class_string.append(gen_conversions(type))
    class_string.append('#endregion\n')

    class_string.append('#region arithmetic')
    operators = gen_operators(type)
    for o in operators:
        class_string.append("  {}".format(o))
    class_string.append('#endregion\n')

    class_string.append('#region rules')
    class_string.append(gen_rules(type))
    class_string.append('#endregion\n')
    
    class_string.append("\t}")
    return '\n'.join(class_string)

def remove_multiple_consecutively_empty_lines(text):
    lines = text.splitlines()
    res = [lines[0]]
    for i in range(1, len(lines)):
        if not re.search(r'^\s+$', lines[i]) or not re.search(r'^\s+$', lines[i-1]):
            res.append(lines[i])
    return '\n'.join(res)

def name_space(type):
    namespace_string = []
    namespace_string.append("""
// GENERATED FILE! ({})
// Changes will be lost!
using System;

namespace {}
{{
    {}
}}
    """.format(datetime.now().strftime("%d/%m/%Y %H:%M:%S"), NAMESPACE, gen_class(type)))
    #namespace_string.append("\t{}".format(gen_quantity()))
    return '\n'.join(namespace_string)
    
def gen_files_with_class(all_types):
    files_with_class = []
    for e in all_types:
        files_with_class.append((e.get_name(), name_space(e)))
    return files_with_class

def gen_combinations(base_q_name, exps, curr, bq_restriction):
    global all_types
    global total_combinations
    if curr > len(exps)-1: # Stop recursion
        # Already been here
        if hash_exps(exps) in dynprog_mem:
            return

        # A new combination found
        dynprog_mem[hash_exps(exps)] = Type((base_q_name, exps))
        total_combinations = total_combinations + 1
        all_types.append(Type((base_q_name, exps)))
        return

    for i in range(-bq_restriction[curr], bq_restriction[curr]+1):
        exps = exps[:curr] + (i,) + exps[curr+1:]
        gen_combinations(base_q_name, exps, curr+1, bq_restriction)

# Generate combinations
for base_q_name, base_q_values in base_q.items():
    gen_combinations(base_q_name, (0,)*len(base_q_values['restriction']), 0, base_q_values['restriction'])
print(total_combinations)
all_types = sort_combination_on_abs_magnitude(all_types)

# Generate files
files_with_class = gen_files_with_class(all_types)
for c in files_with_class:
    name = c[0]
    text = remove_multiple_consecutively_empty_lines(c[1])
    filename  = Path("RayQuantities") / Path("RayQuantities") / Path("codegen") / f"{name}.cs"
    with open(filename, "w+") as f:
        f.write(text)