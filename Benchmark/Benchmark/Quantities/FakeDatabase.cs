using System.Collections.Generic;
namespace RaySearch.QuantityExjobb4
{
  public static class FakeDatabase
  {
    public static Dictionary<string, string> Units { get { return units_; } }
    private static Dictionary<string, string> units_ = new Dictionary<string, string>()
    {
      { "QDose", "centigray" },
      { "MassPerLengthSqr", "kilogrampermetersqr" },
    };
  }
}
