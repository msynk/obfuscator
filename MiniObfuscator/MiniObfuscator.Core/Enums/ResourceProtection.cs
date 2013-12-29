using System.ComponentModel;

namespace MiniObfuscator.Core.Enums
{
  public enum ResourceProtection
  {
    None = 0,
    [Description("Enrypts name of resource and break any references between type and associated resource")]
    Anonymize = 1,
  }
}
