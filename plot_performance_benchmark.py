import matplotlib
import matplotlib.pyplot as plt
import matplotlib.lines as mlines
import numpy as np
import pprint
import re
import math

# Settings:
matplotlib.style.use('seaborn-pastel')
degrees = 30
width = 0.20  # the width of the bars
unit = 'ns'
#unit = 'μs'
unit_mem = 'B'
t_rot = 0
m_rot = 15
no_mem = True

#xlabel_str = "# of elements"
#xlabel_str = "# of iterations"
xlabel_str = "# of steps"

# DATA Initialize a list with N elements
legend = 'Initialize a list with N elements (Time comparison)'
legend = 'Calculate integral of x^2 from -50 to 50 using N steps (Time comparison)'
legend = 'Sort an array of size N (Time comparison)'
legend_mem = 'Initialize a list with N elements (Memory comparison)'
#labels   = [10, 100, 1000, 100000, 1000000]
q_means  = [1083.9, 2842.3, 21131.6, 244617.7, 110800532.0, 1]
un_means = [1322.7, 5065.6  , 41937.7, 543705.9, 52131561.4 ]
d_means  = [994.1 , 1852.2, 14668.2, 181440.8, 17698721.5 ]

labels = []
time_data = [[],[],[]]
mem_data = [[],[],[]]

# ------------------------------ helper function ----------------------------- #
superscript_map = {
    "0": "⁰", "1": "¹", "2": "²", "3": "³", "4": "⁴", "5": "⁵", "6": "⁶",
    "7": "⁷", "8": "⁸", "9": "⁹", "a": "ᵃ", "b": "ᵇ", "c": "ᶜ", "d": "ᵈ",
    "e": "ᵉ", "f": "ᶠ", "g": "ᵍ", "h": "ʰ", "i": "ᶦ", "j": "ʲ", "k": "ᵏ",
    "l": "ˡ", "m": "ᵐ", "n": "ⁿ", "o": "ᵒ", "p": "ᵖ", "q": "۹", "r": "ʳ",
    "s": "ˢ", "t": "ᵗ", "u": "ᵘ", "v": "ᵛ", "w": "ʷ", "x": "ˣ", "y": "ʸ",
    "z": "ᶻ", "A": "ᴬ", "B": "ᴮ", "C": "ᶜ", "D": "ᴰ", "E": "ᴱ", "F": "ᶠ",
    "G": "ᴳ", "H": "ᴴ", "I": "ᴵ", "J": "ᴶ", "K": "ᴷ", "L": "ᴸ", "M": "ᴹ",
    "N": "ᴺ", "O": "ᴼ", "P": "ᴾ", "Q": "Q", "R": "ᴿ", "S": "ˢ", "T": "ᵀ",
    "U": "ᵁ", "V": "ⱽ", "W": "ᵂ", "X": "ˣ", "Y": "ʸ", "Z": "ᶻ", "+": "⁺",
    "-": "⁻", "=": "⁼", "(": "⁽", ")": "⁾"}

def get_as_superscript(value: int) -> str:
    exponent = int(math.log10(value)+0.00001)
    return "10"+superscript_map[str(exponent)]

def print_table(x, data, u):
    print("N \\textbackslash Type & RayQuantities ({0}) & UnitsNet ({0}) & double ({0})".format(u), " \\\\ ")
    print("\\hline")
    for i in range(len(x)):
        print(x[i], " & ", data[0][i], " & ", data[1][i], " & ", data[2][i], " \\\\ ")

# --------------------------- PARSE STRING RESULTS --------------------------- # Remove MEDIAN if exists
# Copy paste the output from BenchmarkDotNet

# init list
#res_str =\
"""
|         Method |        N |               Mean |            Error |           StdDev |      Gen 0 |      Gen 1 |      Gen 2 |   Allocated |
|--------------- |--------- |-------------------:|-----------------:|-----------------:|-----------:|-----------:|-----------:|------------:|
| testQuantities |       10 |         1,141.0 ns |          2.41 ns |          2.25 ns |     0.1564 |          - |          - |       829 B |
|   testUnitsNet |       10 |         1,275.9 ns |          3.36 ns |          3.15 ns |     0.1450 |          - |          - |       765 B |
|     testDouble |       10 |           980.8 ns |          2.52 ns |          2.36 ns |     0.1087 |          - |          - |       576 B |
| testQuantities |      100 |         3,399.8 ns |          8.42 ns |          7.03 ns |     1.0223 |     0.0153 |          - |      5368 B |
|   testUnitsNet |      100 |         5,010.6 ns |          8.48 ns |          7.93 ns |     0.8316 |     0.0076 |          - |      4391 B |
|     testDouble |      100 |         1,792.2 ns |          2.94 ns |          2.75 ns |     0.4635 |     0.0019 |          - |      2440 B |
| testQuantities |     1000 |        25,917.2 ns |         25.71 ns |         22.79 ns |     9.2468 |     0.6104 |          - |     48636 B |
|   testUnitsNet |     1000 |        41,531.7 ns |         53.27 ns |         47.22 ns |     6.2866 |     0.3662 |          - |     33152 B |
|     testDouble |     1000 |        14,690.6 ns |         17.48 ns |         16.35 ns |     2.6093 |     2.6093 |     2.6093 |     16849 B |
| testQuantities |    10000 |       295,557.4 ns |      5,860.78 ns |      6,749.28 ns |    90.8203 |    44.9219 |          - |    532144 B |
|   testUnitsNet |    10000 |       551,059.4 ns |      3,024.88 ns |      2,829.47 ns |   124.0234 |   124.0234 |   124.0234 |    525440 B |
|     testDouble |    10000 |       180,475.9 ns |        299.57 ns |        280.22 ns |    79.8340 |    79.8340 |    79.8340 |    262880 B |
| testQuantities |   100000 |     9,060,560.6 ns |     40,993.23 ns |     38,345.10 ns |   859.3750 |   687.5000 |   296.8750 |   5055667 B |
|   testUnitsNet |   100000 |     5,521,397.1 ns |     39,576.00 ns |     35,083.10 ns |   992.1875 |   992.1875 |   992.1875 |   4202608 B |
|     testDouble |   100000 |     1,912,595.8 ns |      4,758.02 ns |      4,450.66 ns |   498.0469 |   498.0469 |   498.0469 |   2101370 B |
| testQuantities |  1000000 |   118,175,572.9 ns |    534,662.92 ns |    473,964.75 ns |  9000.0000 |  6200.0000 |  3000.0000 |  48448714 B |
|   testUnitsNet |  1000000 |    54,362,977.1 ns |    737,379.37 ns |    653,667.60 ns |  1400.0000 |  1400.0000 |  1400.0000 |  33559571 B |
|     testDouble |  1000000 |    18,400,875.2 ns |     87,450.66 ns |     81,801.40 ns |  2968.7500 |  2968.7500 |  2968.7500 |  16785584 B |
| testQuantities | 10000000 | 1,672,979,480.0 ns | 30,695,100.91 ns | 28,712,216.43 ns | 76000.0000 | 62000.0000 | 14000.0000 | 534814024 B |
|   testUnitsNet | 10000000 |   575,663,793.3 ns |  2,722,324.36 ns |  2,546,463.89 ns |  7000.0000 |  7000.0000 |  7000.0000 | 536879392 B |
|     testDouble | 10000000 |   210,965,123.8 ns |    899,734.51 ns |    797,591.21 ns |  6666.6667 |  6666.6667 |  6666.6667 | 268443888 B |
"""

# integral
res_str =\
"""
|         Method |        N |              Mean |           Error |          StdDev |       Gen 0 |     Gen 1 | Gen 2 |   Allocated |
|--------------- |--------- |------------------:|----------------:|----------------:|------------:|----------:|------:|------------:|
| testQuantities |       10 |         895.78 ns |        72.44 ns |       193.37 ns |           - |         - |     - |           - |
|   testUnitsNet |       10 |       1,331.96 ns |        62.64 ns |       181.74 ns |           - |         - |     - |           - |
|     testDouble |       10 |          27.27 ns |        37.12 ns |        45.58 ns |           - |         - |     - |           - |
| testQuantities |      100 |       3,476.00 ns |       380.03 ns |     1,120.53 ns |           - |         - |     - |           - |
|   testUnitsNet |      100 |       6,788.52 ns |       138.71 ns |       313.10 ns |           - |         - |     - |           - |
|     testDouble |      100 |         167.00 ns |        34.10 ns |       100.56 ns |           - |         - |     - |           - |
| testQuantities |     1000 |      19,364.58 ns |       454.77 ns |     1,312.13 ns |           - |         - |     - |     81920 B |
|   testUnitsNet |     1000 |      60,530.00 ns |     1,186.99 ns |     1,366.94 ns |           - |         - |     - |           - |
|     testDouble |     1000 |       1,075.93 ns |        20.46 ns |        43.15 ns |           - |         - |     - |           - |
| testQuantities |    10000 |     191,970.59 ns |     3,805.65 ns |     3,908.13 ns |           - |         - |     - |    802816 B |
|   testUnitsNet |    10000 |     605,650.00 ns |    12,102.89 ns |    18,842.74 ns |           - |         - |     - |           - |
|     testDouble |    10000 |      10,752.00 ns |       218.71 ns |       441.81 ns |           - |         - |     - |           - |
| testQuantities |   100000 |   3,253,059.26 ns |    56,398.58 ns |    79,062.94 ns |   1000.0000 | 1000.0000 |     - |   8020020 B |
|   testUnitsNet |   100000 |   5,924,684.62 ns |    50,006.74 ns |    41,757.89 ns |           - |         - |     - |           - |
|     testDouble |   100000 |     118,952.08 ns |     2,629.73 ns |     7,587.37 ns |           - |         - |     - |           - |
| testQuantities |  1000000 |  19,783,515.00 ns |   376,819.17 ns |   433,945.51 ns |  15000.0000 | 1000.0000 |     - |  80118540 B |
|   testUnitsNet |  1000000 |  57,732,661.54 ns |   705,912.74 ns |   589,469.11 ns |           - |         - |     - |           - |
|     testDouble |  1000000 |   1,205,086.79 ns |    23,880.66 ns |    49,847.83 ns |           - |         - |     - |           - |
"""

# sort
#res_str =\
"""
|         Method |        N |                Mean |            Error |          StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------- |--------- |--------------------:|-----------------:|----------------:|------:|------:|------:|----------:|
| testQuantities |       10 |          2,609.4 ns |         82.18 ns |        237.1 ns |     - |     - |     - |         - |
|   testUnitsNet |       10 |          1,630.6 ns |         59.56 ns |        173.7 ns |     - |     - |     - |         - |
|     testDouble |       10 |            794.8 ns |         42.19 ns |        121.7 ns |     - |     - |     - |         - |
| testQuantities |      100 |         21,208.3 ns |        382.80 ns |        497.7 ns |     - |     - |     - |         - |
|   testUnitsNet |      100 |         14,287.8 ns |        276.51 ns |        498.6 ns |     - |     - |     - |         - |
|     testDouble |      100 |          4,329.0 ns |         87.00 ns |        210.1 ns |     - |     - |     - |         - |
| testQuantities |     1000 |        272,400.0 ns |      5,230.45 ns |      6,226.5 ns |     - |     - |     - |         - |
|   testUnitsNet |     1000 |        166,871.4 ns |      3,013.44 ns |      2,671.3 ns |     - |     - |     - |         - |
|     testDouble |     1000 |         49,026.7 ns |        928.01 ns |        868.1 ns |     - |     - |     - |         - |
| testQuantities |    10000 |      3,446,007.1 ns |     29,558.82 ns |     26,203.1 ns |     - |     - |     - |         - |
|   testUnitsNet |    10000 |      2,013,228.6 ns |     21,731.37 ns |     19,264.3 ns |     - |     - |     - |         - |
|     testDouble |    10000 |        641,746.7 ns |      5,753.93 ns |      5,382.2 ns |     - |     - |     - |         - |
| testQuantities |   100000 |     43,105,778.6 ns |    194,982.44 ns |    172,846.9 ns |     - |     - |     - |         - |
|   testUnitsNet |   100000 |     23,607,278.6 ns |     80,065.68 ns |     70,976.1 ns |     - |     - |     - |         - |
|     testDouble |   100000 |      7,803,526.7 ns |     32,201.82 ns |     30,121.6 ns |     - |     - |     - |         - |
| testQuantities |  1000000 |    685,274,330.0 ns | 13,430,703.56 ns | 15,466,818.2 ns |     - |     - |     - |         - |
|   testUnitsNet |  1000000 |    278,232,358.3 ns |  2,169,975.38 ns |  1,694,174.0 ns |     - |     - |     - |         - |
|     testDouble |  1000000 |     95,444,780.0 ns |    968,569.36 ns |    906,000.4 ns |     - |     - |     - |         - |
| testQuantities | 10000000 | 10,467,205,380.8 ns | 69,444,351.28 ns | 57,989,178.5 ns |     - |     - |     - |         - |
|   testUnitsNet | 10000000 |  3,216,912,646.2 ns | 10,384,294.98 ns |  8,671,356.6 ns |     - |     - |     - |         - |
|     testDouble | 10000000 |  1,129,004,400.0 ns |  7,176,507.66 ns |  5,992,708.9 ns |     - |     - |     - |         - |
"""


#montecarlo
#res_str =\
"""
|              Method |         N |              Mean |           Error |          StdDev |        Gen 0 |     Gen 1 | Gen 2 |     Allocated |
|-------------------- |---------- |------------------:|----------------:|----------------:|-------------:|----------:|------:|--------------:|
| CalcPiRayQuantities |        10 |          2.670 μs |       0.0048 μs |       0.0045 μs |       1.0643 |         - |     - |        5592 B |
|      CalcPiUnitsNet |        10 |          4.930 μs |       0.0090 μs |       0.0075 μs |       0.0916 |         - |     - |         505 B |
|        CalcPiDouble |        10 |          1.041 μs |       0.0021 μs |       0.0019 μs |       0.0801 |         - |     - |         425 B |
| CalcPiRayQuantities |       100 |         17.960 μs |       0.0187 μs |       0.0166 μs |       9.3079 |         - |     - |       48856 B |
|      CalcPiUnitsNet |       100 |         38.093 μs |       0.0374 μs |       0.0313 μs |       0.0610 |         - |     - |         505 B |
|        CalcPiDouble |       100 |          2.651 μs |       0.0074 μs |       0.0070 μs |       0.0801 |         - |     - |         425 B |
| CalcPiRayQuantities |      1000 |        166.403 μs |       0.2283 μs |       0.2024 μs |      91.7969 |    0.2441 |     - |      481493 B |
|      CalcPiUnitsNet |      1000 |        369.366 μs |       0.4063 μs |       0.3801 μs |            - |         - |     - |         508 B |
|        CalcPiDouble |      1000 |         25.036 μs |       0.0326 μs |       0.0305 μs |       0.0610 |         - |     - |         425 B |
| CalcPiRayQuantities |     10000 |      1,684.773 μs |      33.1859 μs |      40.7553 μs |     916.0156 |    1.9531 |     - |     4807856 B |
|      CalcPiUnitsNet |     10000 |      3,750.928 μs |      38.2013 μs |      35.7335 μs |            - |         - |     - |         512 B |
|        CalcPiDouble |     10000 |        290.234 μs |       0.3897 μs |       0.3454 μs |            - |         - |     - |         428 B |
| CalcPiRayQuantities |    100000 |     16,997.616 μs |     329.1087 μs |     352.1426 μs |    9156.2500 |         - |     - |    48071388 B |
|      CalcPiUnitsNet |    100000 |     37,222.007 μs |     207.4750 μs |     194.0723 μs |            - |         - |     - |             - |
|        CalcPiDouble |    100000 |      2,914.038 μs |      10.7252 μs |      10.0324 μs |            - |         - |     - |         448 B |
| CalcPiRayQuantities |   1000000 |    166,620.520 μs |     667.2949 μs |     624.1881 μs |   91500.0000 |         - |     - |   480707222 B |
|      CalcPiUnitsNet |   1000000 |    373,794.600 μs |   7,332.0374 μs |   9,272.6797 μs |            - |         - |     - |             - |
|        CalcPiDouble |   1000000 |     28,963.040 μs |      30.8339 μs |      28.8421 μs |            - |         - |     - |         512 B |
| CalcPiRayQuantities |  10000000 |  1,649,385.383 μs |   9,348.8686 μs |   7,298.9817 μs |  916000.0000 |         - |     - |  4807055888 B |
|      CalcPiUnitsNet |  10000000 |  3,672,936.877 μs |   3,470.5513 μs |   2,898.0675 μs |            - |         - |     - |             - |
|        CalcPiDouble |  10000000 |    291,379.857 μs |   2,630.3431 μs |   2,331.7306 μs |            - |         - |     - |             - |
| CalcPiRayQuantities | 100000000 | 16,934,118.233 μs |  96,138.9515 μs |  89,928.4349 μs | 9168000.0000 | 5000.0000 |     - | 48070526528 B |
|      CalcPiUnitsNet | 100000000 | 37,199,108.347 μs | 256,117.4145 μs | 239,572.3885 μs |            - |         - |     - |             - |
|        CalcPiDouble | 100000000 |  2,875,802.900 μs |   2,100.4846 μs |   1,639.9202 μs |            - |         - |     - |             - |
"""

res_m_str = []
c = 0
for line in res_str.splitlines():
    tmp = line.split('|')
    tmp2 = []
    save_cols = [2,3,9]
    for i in range(len(tmp)):
        tmp[i] = re.sub('\s', '', tmp[i])
        tmp[i] = re.sub('ns', '', tmp[i])
        tmp[i] = re.sub('us', '', tmp[i])
        tmp[i] = re.sub('μs', '', tmp[i])
        tmp[i] = re.sub('B', '', tmp[i])
        tmp[i] = re.sub(',', '', tmp[i])
        if i in save_cols:
            tmp2.append(tmp[i])
    res_m_str.append(tmp2)
    c = c = 1
i = 0
for row in res_m_str[3:]:
    pass
    if not float(row[0]) in labels:
        labels.append(float(row[0]))
    time_data[i%3].append(float(row[1]))
    if not no_mem:
        mem_data[i%3].append(float(row[2]))
    i = i + 1
# --------------------------------- end parse -------------------------------- #

x = np.arange(len(labels))  # the label locations

print_table(list(map(int, labels)), time_data, unit)
if not no_mem:
    print_table(list(map(int, labels)), mem_data, unit_mem)

# --------------------------------- Time plot -------------------------------- #

fig, ax = plt.subplots()

#rects1 = ax.bar(x - width*1.1, time_data[0] , width, label='Quantities')
#rects2 = ax.bar(x            , time_data[1] , width, label='UnitsNet'  )
#rects3 = ax.bar(x + width*1.1, time_data[2] , width, label='double'   )

rects1 = ax.plot(x , time_data[0], 'r' , label='RayQuantities', alpha=0.2)
rects2 = ax.plot(x , time_data[1], 'b' , label='UnitsNet'  , alpha=0.2)
rects3 = ax.plot(x , time_data[2], 'y' , label='double'    , alpha=0.2)
ax.plot(x , time_data[0], 'ro' , alpha=0.7)
ax.plot(x , time_data[1], 'b^' , alpha=0.7)
ax.plot(x , time_data[2], 'ys' , alpha=0.7)

# Add some text for labels, title and custom x-axis tick labels, etc.
#ax.set_xticks([])
ax.set_yscale("log")
ax.set_ylabel("Time ({})".format(unit))
ax.set_xlabel(xlabel_str)
#ax.set_xlabel("# of iterations")
#ax.set_xlabel("# of steps")
ax.set_ylim(1, max([*time_data[0],*time_data[1],*time_data[2]])*10)
ax.set_xticks(x)
ax.set_xticklabels(list(map(get_as_superscript, labels)))

red_line = mlines.Line2D([], [], color='red', marker='o', label='RayQuantities')
blue_line = mlines.Line2D([], [], color='blue', marker='^', label='UnitsNet')
green_line = mlines.Line2D([], [], color='yellow', marker='s', label='double')

ax.legend(handles=[red_line, blue_line, green_line])
ax.grid(color='gray', linestyle='--', linewidth=0.2)

#plt.title(legend)
plt.setp(ax.xaxis.get_majorticklabels(), rotation=degrees)

def autolabel(rects):
    """Attach a text label above each bar in *rects*, displaying its height."""
    for rect in rects:
        height = rect.get_height()
        ax.annotate('{}'.format(height),
                    xy=(rect.get_x() + rect.get_width()/2, height),
                    xytext=(0, 3),  # 3 points vertical offset
                    textcoords="offset points",
                    ha='center', va='bottom',
                    rotation=t_rot)

def autolabel_line(line2d):
    """Attach a text label above each bar in *rects*, displaying its height."""
    print('line2d')
    print(line2d)
    data = line2d[0]
    for i in range(len(data._x)):
        x = data._x[i]
        y = data._y[i]
        ax.annotate('{}'.format(y),
                    xy=(x+0.02, y-0.05),
                    xytext=(0, 3),  # 3 points vertical offset
                    textcoords="offset points",
                    ha='left', va='center',
                    rotation=t_rot)


#autolabel_line(rects1)
#autolabel_line(rects2)
#autolabel_line(rects3)

#fig.tight_layout()
plt.show()


# --------------------------------- Mem plot --------------------------------- #
if no_mem:
    exit()
fig, ax = plt.subplots()

#rects1 = ax.bar(x - width*1.1, mem_data[0] , width, label='Quantities')
#rects2 = ax.bar(x            , mem_data[1] , width, label='UnitsNet'  )
#rects3 = ax.bar(x + width*1.1, mem_data[2] , width, label='double'   )

rects1 = ax.plot(x , mem_data[0], 'r' , label='RayQuantities', alpha=0.2)
rects2 = ax.plot(x , mem_data[1], 'b' , label='UnitsNet'  , alpha=0.2)
rects3 = ax.plot(x , mem_data[2], 'y' , label='double'    , alpha=0.2)
ax.plot(x , mem_data[0], 'ro' , alpha=0.7)
ax.plot(x , mem_data[1], 'b^' , alpha=0.7)
ax.plot(x , mem_data[2], 'ys' , alpha=0.7)

# Add some text for labels, title and custom x-axis tick labels, etc.
#ax.set_xticks([])
ax.set_yscale("log")
ax.set_ylabel("Memory used ({})".format(unit_mem))
ax.set_xlabel("# of elements")
ax.set_xticks(x)
ax.set_xticklabels(list(map(get_as_superscript, labels)))
ax.set_ylim(1, max([*mem_data[0],*mem_data[1],*mem_data[2]])*10)

red_line = mlines.Line2D([], [], color='red', marker='o', label='RayQuantities')
blue_line = mlines.Line2D([], [], color='blue', marker='^', label='UnitsNet')
green_line = mlines.Line2D([], [], color='yellow', marker='s', label='double')

ax.legend(handles=[red_line, blue_line, green_line])
ax.grid(color='gray', linestyle='--', linewidth=0.2)

#plt.title(legend_mem)
plt.setp(ax.xaxis.get_majorticklabels(), rotation=degrees)

def autolabel(rects):
    """Attach a text label above each bar in *rects*, displaying its height."""
    for rect in rects:
        height = rect.get_height()
        ax.annotate('{}'.format(height),
                    xy=(rect.get_x() + rect.get_width()/2, height),
                    xytext=(0, 3),  # 3 points vertical offset
                    textcoords="offset points",
                    ha='center', va='bottom',
                    rotation=m_rot)

def autolabel_line(line2d):
    """Attach a text label above each bar in *rects*, displaying its height."""
    print('line2d')
    print(line2d)
    data = line2d[0]
    for i in range(len(data._x)):
        x = data._x[i]
        y = data._y[i]
        ax.annotate('{}'.format(y),
                    xy=(x, y),
                    xytext=(0, 3),  # 3 points vertical offset
                    textcoords="offset points",
                    ha='left', va='top',
                    rotation=t_rot)


#autolabel_line(rects1)
#autolabel_line(rects2)
#autolabel_line(rects3)

#fig.tight_layout()
plt.show()