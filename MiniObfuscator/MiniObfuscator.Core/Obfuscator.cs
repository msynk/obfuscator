using NineRays.ILOMD;
using NineRays.ILOMD.Options;

namespace MiniObfuscator.Core
{
  public class Obfuscator
  {
    public ObfuscatorSettings Settings { get; private set; }

    public Obfuscator(ObfuscatorSettings settings)
    {
      Settings = settings;
    }

    public bool Obfuscate()
    {
      if (!Settings.Validate()) return false;

      var mdl = new ILOMDProvider(new ObfuscateLogger(Settings.ObfuscateLoggerSettings));
      return mdl.Obfuscate(GenerateObfuscateProject());
    }
    
    private Project GenerateObfuscateProject()
    {
      var project = new Project
      {
        StripDebugInfo = Settings.StripDebugInfo,
        VerifyAfterObfuscation = (YesNoPrompt)Settings.VerifyAfterObfuscation,
        SaveToDirectory = Settings.OutputPath,
        CheckConsistencyBeforeObfuscation = Settings.CheckConsistencyBeforeObfuscation
      };
      var options = (Settings.ObfuscateOptions ?? ObfuscateOptions.Default).Options;
      foreach (var path in Settings.AssemblyPaths)
      {
        project.AssemblyList.Add(new AssemblyFileName(path, options));
      }
      foreach (var bookmark in Settings.Bookmarks)
      {
        project.Bookmarks.Add(bookmark);
      }

      if (Settings.HasSnKey())
      {
        project.StrongNameKeyFile = Settings.StrongNameKeyFilePath;
        if (!string.IsNullOrEmpty(Settings.StrongNameKeyFilePassword))
        {
          project.StrongNameKeyFilePassword = Settings.StrongNameKeyFilePassword;
        }
      }
      
      return project;
    }

  }
}