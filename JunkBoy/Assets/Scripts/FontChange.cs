using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class FontChange : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // This will change the font style whether the user points to the GameObject or not.

    //Variables

    [SerializeField] public TMP_FontAsset normalFont;
    [SerializeField] public TMP_FontAsset hoverFont;
    [SerializeField] public TMP_Text textFontToChange;

    public void OnPointerEnter(PointerEventData eventData)
    {
        textFontToChange.font = hoverFont;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        textFontToChange.font = normalFont;
    }
}
