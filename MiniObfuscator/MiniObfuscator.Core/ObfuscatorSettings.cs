using System.Collections.Generic;
using System.IO;

namespace MiniObfuscator.Core
{
  public class ObfuscatorSettings
  {
    private readonly List<string> _assemblyPaths = new List<string>();
    private readonly List<string> _bookmarks = new List<string>();

    /// <summary>
    ///   Gets all assembly file paths
    /// </summary>
    public string[] AssemblyPaths { get { return _assemblyPaths.ToArray(); } }

    /// <summary>
    ///   Gets and sets the output path for obfuscated assemblies
    /// </summary>
    public string OutputPath { get; set; }

    /// <summary>
    ///   Gets and sets Output settings for obfuscating
    /// </summary>
    public ObfuscateLoggerSettings ObfuscateLoggerSettings { get; set; }

    /// <summary>
    ///   Gets and sets obfuscating Options
    /// </summary>
    public ObfuscateOptions ObfuscateOptions { get; set; }

    /// <summary>
    ///   Gets and sets Sn key file path
    /// </summary>
    public string StrongNameKeyFilePath { get; set; }

    /// <summary>
    ///   Gets and sets Sn key pasword
    /// </summary>
    public string StrongNameKeyFilePassword { get; set; }

    /// <summary>
    ///   Gets all bookmarks set in current settings
    /// </summary>
    public string[] Bookmarks { get { return _bookmarks.ToArray(); } }

    /// <summary>
    ///   Gets and sets CheckConsistencyBeforeObfuscation setting
    /// </summary>
    public bool CheckConsistencyBeforeObfuscation { get; set; }

    /// <summary>
    ///   Gets and sets the option to remove debug info from obfuscated assmeblies
    /// </summary>
    public bool StripDebugInfo { get; set; }

    /// <summary>
    ///   Gets and sets the option for verifying the assemblies after obfuscation
    /// </summary>
    public Enums.YesNoPrompt VerifyAfterObfuscation { get; set; }



    /// <summary>
    ///   Adds a assembly path to the list of assemblies for obfuscating
    /// </summary>
    /// <param name="path"></param>
    public void AddAssembly(string path)
    {
      _assemblyPaths.Add(path);
    }

    /// <summary>
    ///   Validates current settings
    /// </summary>
    /// <returns></returns>
    internal bool Validate()
    {
      return _assemblyPaths.Count != 0 && !string.IsNullOrEmpty(OutputPath) && ObfuscateLoggerSettings != null && ObfuscateLoggerSettings.Validate();
    }

    /// <summary>
    ///   Checks if a valid Strong Name Key file has provided
    /// </summary>
    /// <returns></returns>
    internal bool HasSnKey()
    {
      return !string.IsNullOrEmpty(StrongNameKeyFilePath) && File.Exists(StrongNameKeyFilePath);
    }
  }
}