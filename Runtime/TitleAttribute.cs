using UnityEngine;

namespace Kalkuz.Attributes
{
  public enum TitleAlignment
  {
    Left,
    Center,
    Right
  }

  /// <summary>
  /// Better header attribute with customization option.
  /// </summary>
  public sealed class TitleAttribute : PropertyAttribute
  {
    public readonly string Header;
    public readonly int FontSize;
    public readonly string FontColor;
    public readonly TitleAlignment TitleAlignment;

    /// <param name="header">The text of the header</param>
    /// <param name="fontSize">The size of the header's font appear in editor</param>
    /// <param name="fontColor">The color of the header's font in hex color</param>
    /// <param name="titleAlignment">Determines how the Header will be aligned</param>
    public TitleAttribute(string header, int fontSize = 16, string fontColor = "#ffffff",
      TitleAlignment titleAlignment = TitleAlignment.Center)
    {
      Header = header;
      FontSize = fontSize;
      FontColor = fontColor;
      TitleAlignment = titleAlignment;
    }
  }
}