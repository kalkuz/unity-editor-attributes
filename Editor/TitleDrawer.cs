using UnityEditor;
using UnityEngine;

namespace Kalkuz.Attributes.Editor
{
  [CustomPropertyDrawer(typeof(TitleAttribute))]
  internal sealed class TitleDrawer : DecoratorDrawer
  {
    private readonly GUIStyle _style = new()
    {
      richText = true,
      fontStyle = FontStyle.Bold,
      alignment = TextAnchor.MiddleCenter
    };

    public override void OnGUI(Rect position)
    {
      if (attribute is not TitleAttribute att) return;

      _style.alignment = att.TitleAlignment switch
      {
        TitleAlignment.Left => TextAnchor.MiddleLeft,
        TitleAlignment.Right => TextAnchor.MiddleRight,
        _ => _style.alignment
      };

      _style.fontSize = att.FontSize;

      EditorGUI.LabelField(position, $"<color={att.FontColor}>{att.Header}</color>", _style);
    }

    public override float GetHeight()
    {
      if (attribute is not TitleAttribute att) return EditorGUIUtility.singleLineHeight * 1.5f;
      var fullTextHeight = EditorStyles.boldLabel.CalcHeight(new GUIContent(att.Header), 1.0f);
      return EditorGUIUtility.singleLineHeight * 1.5f + (fullTextHeight);
    }
  }
}