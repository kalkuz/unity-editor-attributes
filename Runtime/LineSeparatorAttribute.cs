using UnityEngine;

namespace Kalkuz.Attributes
{
  /// <summary>
  /// Adds Line Separator before the property in Inspector.
  /// </summary>
  public sealed class LineSeparatorAttribute : PropertyAttribute
  {
    public readonly float Height;
    public readonly float VerticalPadding;
    public readonly float GrayScale;

    /// <param name="height">The height of the line</param>
    /// <param name="verticalPadding">The vertical spacing of the line</param>
    /// <param name="grayScale">The color of the line in terms of gray scale represented between 0 and 1</param>
    public LineSeparatorAttribute(float height = 1, float verticalPadding = 16, float grayScale = 0.4f)
    {
      Height = height;
      VerticalPadding = verticalPadding;
      GrayScale = grayScale;
    }
  }
}