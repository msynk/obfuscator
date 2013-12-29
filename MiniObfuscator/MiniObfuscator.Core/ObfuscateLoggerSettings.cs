using System;
using System.Drawing;
using NineRays.Common;
using NineRays.ILOMD;

namespace MiniObfuscator.Core
{
  /// <summary>
  /// Settings of the obfuscator output used in Output class
  /// </summary>
  public class ObfuscateLoggerSettings
  {
    public ObfuscateLoggerSettings()
    {
      IsRtf = true;
    }

    /// <summary>
    ///   Clears the output
    /// </summary>
    public Action Clear;

    /// <summary>
    ///   Adds a message to the output
    /// </summary>
    public Action<string> Add;

    /// <summary>
    ///   Adds a formatted message by color to the output
    /// </summary>
    public Action<string, Color> AddFormatted;

    /// <summary>
    ///   Gets and sets IsRtf, indication if the output is a Rich Text Box control
    /// </summary>
    public bool IsRtf { get; set; }

    /// <summary>
    ///   Gets and sets Font of the output
    /// </summary>
    public Font Font { get; set; }

    /// <summary>
    ///   Validates current settings
    /// </summary>
    /// <returns></returns>
    public bool Validate()
    {
      return Clear != null && Add != null && AddFormatted != null && Font != null;
    }
  }
}
