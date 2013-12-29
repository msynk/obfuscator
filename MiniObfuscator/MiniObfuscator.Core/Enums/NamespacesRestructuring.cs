using System.ComponentModel;

namespace MiniObfuscator.Core.Enums
{
  public enum NamespacesRestructuring
  {
    [Description("Namespaces not restructured")]
    AsIs,
    [Description("Each obfuscated type in one namespace")]
    EachTypeOneNamespace,
    [Description("All obfuscated types in one namespace")]
    AllTypesOneNamespace,
    [Description("Obfuscated types have no namespaces")]
    NoNamespaces,
  }
}
