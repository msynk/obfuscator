using System.ComponentModel;

namespace MiniObfuscator.Core.Enums
{
  public enum Naming
  {
    [Description("Generates numerical names(0,1,2)")]
    Numbers = 1,
    [Description("Generates alphabetical names(a,b,c)")]
    Alphabetical = 2,
    [Description("Generates alphanumeric names(a1, b0)")]
    AlphaNumeric = 3,
    [Description("Generates non-displayable names, recommended to protect from preview in ILDASM and most of known assembly browsers and linkage by AL.exe")]
    NonDisplayable = 4,
    [Description("Generates names with mix of custom dictionary and non-displayable symbols, recommended to protect from preview in ILDASM and most of known assembly browsers and linkage by AL.exe")]
    CustomAndNonDisplayable = 5,
    [Description("Generates names with mix of non-displayable symbols and numerical symbols, recommended to protect from preview in ILDASM and most of known assembly browsers and linkage by AL.exe")]
    NumbersAndNonDisplayable = 6,
    [Description("Generates names with mix of alphabetical and non-displayable symbols, recommended to protect from preview in ILDASM and most of known assembly browsers and linkage by AL.exe")]
    AlphabeticalAndNonDisplayable = 7,
    [Description("Generates names with mix of custom dictionary and alphanumeric symbols, recommended to protect from preview in ILDASM and most of known assembly browsers and linkage by AL.exe")]
    AlphaNumericAndCustom = 8,
    [Description("Generates names with mix of custom dictionary, non-displayable symbols, and alphanumeric symbols, recommended to protect from preview in ILDASM and most of known assembly browsers and linkage by AL.exe")]
    AlphaNumericAndNonDisplayableAndCustom = 9,
    [Description("Generates names with mix of non-displayable symbols and alphanumeric symbols, recommended to protect from preview in ILDASM and most of known assembly browsers and linkage by AL.exe")]
    AlphaNumericAndNonDisplayable = 10,
    [Description("Uses charaters for substitutions from the CustomDictionary")]
    CustomDictionary = 11,
  }
}
