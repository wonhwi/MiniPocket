using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Extension
{
  public static class UIExtension 
  {
    #region AnchorPresets
    public static void SetAnchor(this RectTransform source, AnchorPresets allign, int width = 1920, int height = 1080, int offsetX = 0, int offsetY = 0)
    {
      (Vector2 anchorMin, Vector2 anchorMax, Vector2 pivot) = GetAnchor(allign);

      //source.sizeDelta = new Vector2(width, height);
      source.anchorMin = anchorMin;
      source.anchorMax = anchorMax;
      source.pivot = pivot;

      source.anchoredPosition = new Vector2(offsetX, offsetY);
    }

    private static (Vector2 anchorMin, Vector2 anchorMax, Vector2 pivot) GetAnchor(AnchorPresets allign) => allign switch
    {
      AnchorPresets.TopLeft => (new Vector2(0, 1), new Vector2(0, 1), new Vector2(0, 1)),
      AnchorPresets.TopCenter => (new Vector2(0.5f, 1), new Vector2(0.5f, 1), new Vector2(0.5f, 1)),
      AnchorPresets.TopRight => (new Vector2(1, 1), new Vector2(1, 1), new Vector2(1, 1)),

      AnchorPresets.MiddleLeft => (new Vector2(0, 0.5f), new Vector2(0, 0.5f), new Vector2(0, 0.5f)),
      AnchorPresets.MiddleCenter => (new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f)),
      AnchorPresets.MiddleRight => (new Vector2(1, 0.5f), new Vector2(1, 0.5f), new Vector2(1, 0.5f)),

      AnchorPresets.BottomLeft => (new Vector2(0, 0), new Vector2(0, 0), new Vector2(0, 0)),
      AnchorPresets.BottonCenter => (new Vector2(0.5f, 0), new Vector2(0.5f, 0), new Vector2(0.5f, 0)),
      AnchorPresets.BottomRight => (new Vector2(1, 0), new Vector2(1, 0), new Vector2(1, 0)),

      AnchorPresets.VertStretchLeft => (new Vector2(0, 1), new Vector2(0, 1), new Vector2(0, 0.5f)),
      AnchorPresets.VertStretchRight => (new Vector2(0, 1), new Vector2(0, 1), new Vector2(0.5f, 0.5f)),
      AnchorPresets.VertStretchCenter => (new Vector2(0, 1), new Vector2(0, 1), new Vector2(1, 0.5f)),

      AnchorPresets.HorStretchTop => (new Vector2(0, 1), new Vector2(1, 1), new Vector2(0.5f, 1)),
      AnchorPresets.HorStretchMiddle => (new Vector2(0, 0.5f), new Vector2(1, 0.5f), new Vector2(0.5f, 0.5f)),
      AnchorPresets.HorStretchBottom => (new Vector2(0, 0), new Vector2(1, 0), new Vector2(0.5f, 0f)),
      AnchorPresets.StretchAll => (new Vector2(0, 0), new Vector2(1, 1), new Vector2(0.5f, 0.5f)),

      _ => (Vector2.zero, Vector2.zero, Vector2.zero),
    };

    #endregion

  }
}

