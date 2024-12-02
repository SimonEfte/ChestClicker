using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CursorUIElements : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Texture2D mainCursor;

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
       if(PlaceMobileButtons.isMobile == false) { Cursor.SetCursor(mainCursor, Vector2.zero, CursorMode.Auto); }
    }
    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        if (PlaceMobileButtons.isMobile == false) { Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto); }
    }
}
