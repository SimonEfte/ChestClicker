using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorHoverOver : MonoBehaviour
{
    public Texture2D handIcon;

    void OnMouseEnter()
    {
        if (PlaceMobileButtons.isMobile == false) { Cursor.SetCursor(handIcon, Vector2.zero, CursorMode.Auto); }
    }

    void OnMouseExit()
    {
        if (PlaceMobileButtons.isMobile == false) { Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto); }
    }
}
