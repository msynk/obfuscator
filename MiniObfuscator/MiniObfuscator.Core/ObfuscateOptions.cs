using NineRays.ILOMD.Options;

namespace MiniObfuscator.Core
{
  public class ObfuscateOptions
  {
    public static ObfuscateOptions Default = new ObfuscateOptions { Members = Enums.Members.Default, Naming = Enums.Naming.AlphaNumeric };

    public Enums.Members Members { get; set; }
    public Enums.Anonymizers Anonymizer { get; set; }
    public Enums.ResourceProtection ResourcesProtection { get; set; }

    public Enums.Naming Naming { get; set; }
    public Enums.AntiIldasm AntiIldasm { get; set; }
    public Enums.NamespacesRestructuring NamespacesRestructuring { get; set; }
    public Enums.StringEncryption StringEncryptionMode { get; set; }

    public string CustomDictionary { get; set; }
    public string SoftwareWatermark { get; set; }

    public bool IncrementalObfuscation { get; set; }
    public bool MixDictionary { get; set; }
    public bool UniqueNames { get; set; }


    internal Options Options
    {
      get
      {
        return new Options
        {
          Members = (Members) Members,
          Anonymizer = (AnonymizeOptions) Anonymizer,
          ResourcesProtection = (ResourceProtectionMode) ResourcesProtection,
          Naming = (Naming) Naming,
          AntiILDASM = (AntiILDASMOptions) AntiIldasm,
          NamespacesRestructuring = (NamespacesRestructuring) NamespacesRestructuring,
          StringEncryptionMode = (StringEncryptionMode) StringEncryptionMode,
          CustomDictionary = CustomDictionary,
          SoftwareWatermark = SoftwareWatermark,
          IncrementalObfuscation = IncrementalObfuscation,
          MixDictionary = MixDictionary,
          UniqueNames = UniqueNames
        };
      }
    }
  }
}
