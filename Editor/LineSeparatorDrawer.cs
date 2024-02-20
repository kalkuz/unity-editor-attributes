using UnityEditor;
using UnityEngine;

namespace Kalkuz.Attributes.Editor
{
  [CustomPropertyDrawer(typeof(LineSeparatorAttribute))]
  internal sealed class LineSeparatorDrawer : DecoratorDrawer
  {
    public override void OnGUI(Rect position)
    {
      var att = attribute as LineSeparatorAttribute;

      var lineRect = new Rect(position.x, position.y, position.width, att.VerticalPadding);
      var line = new Rect(lineRect.x, lineRect.y + att.VerticalPadding, lineRect.width, att.Height);
      position.y += att.VerticalPadding * 2;
      position.height -= att.VerticalPadding * 2;

      EditorGUI.DrawRect(line, new Color(att.GrayScale, att.GrayScale, att.GrayScale));
    }

    public override float GetHeight()
    {
      return ((LineSeparatorAttribute)attribute).VerticalPadding * 2;
    }
  }
}