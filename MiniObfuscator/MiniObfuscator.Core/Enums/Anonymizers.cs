using System;
using System.ComponentModel;

namespace MiniObfuscator.Core.Enums
{
  [Flags]
  public enum Anonymizers
  {
    [Description("No anonymization applied.")]
    None = 0,
    [Description("Keep the same parameter types in the anonymized method")]
    KeepParameters = 1,
    [Description("Keep the same return type in the anonymized method")]
    KeepReturns = 2,
    [Description("Anonymize referenced to this assembly methods.")]
    ReferencedMethods = 4,
    [Description("Anonymize referenced to this assembly fields.")]
    ReferencedFields = 8,
    [Description("Anonymize references to untouched(not obfuscated) fields.")]
    InternalFields = 16,
    [Description("Anonymize references to untouched(not obfuscated) methods.")]
    InternalMethods = 32,
    [Description("Anonymize string encryption services.")]
    StringEncryption = 64,
    [Description("Anonymize string encryption services.")]
    StubUntouchedMethods = 128,
    [Description("Anonymize private members.")]
    AnonymizePrivateMembers = 256,
    Minimum = AnonymizePrivateMembers | StubUntouchedMethods | StringEncryption | KeepReturns | KeepParameters,
    Default = Minimum | ReferencedFields | ReferencedMethods,
    High = Default | InternalMethods | InternalFields,
  }
}
