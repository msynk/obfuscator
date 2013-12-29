using System.ComponentModel;

namespace MiniObfuscator.Core.Enums
{
  public enum StringEncryption
  {
    [Description("Don't encrypt strings.")]
    None,
    [Description("Hide loading strings into wrapper.")]
    Hide,
    [Description("Hide and encrypt strings.")]
    Encrypt,
    [Description("Hide, encrypt and compress strings.")]
    EnhancedEncrypt,
    [Description("Hide and encrypt strings by 3DES algorighm.")]
    Encrypt3Des,
  }
}
