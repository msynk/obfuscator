using System;
using System.Drawing;
using NineRays.Common;
using NineRays.ILOMD;

namespace MiniObfuscator.Core
{
  internal class ObfuscateLogger : IILOMessages
  {
    public ObfuscateLoggerSettings Settings { get; private set; }

    public ObfuscateLogger(ObfuscateLoggerSettings settings)
    {
      Settings = settings;
    }


    #region IILOMessages

    void IILOMessages.AddLine(string msg)
    {
      Settings.Add(msg + Environment.NewLine);
    }

    void IILOMessages.Add(string msg)
    {
      Settings.Add(msg);
    }

    void IILOMessages.AddFormatted(string msg, Font font, SyntaxId id)
    {
      Settings.Add(msg);
    }

    void IILOMessages.AddFormatted(string msg, Font font, Color color)
    {
      Settings.AddFormatted(msg, color);
    }

    void IILOMessages.Clear()
    {
      Settings.Clear();
    }

    bool IILOMessages.IsRtf
    {
      get { return Settings.IsRtf; }
    }

    Font IILOMessages.Font
    {
      get { return Settings.Font; }
    }



    void IILOMessages.Activate() { }
    void IILOMessages.BeginUpdate() { }
    void IILOMessages.EndUpdate() { }

    #endregion

  }
}
