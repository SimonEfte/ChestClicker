using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestHover : MonoBehaviour
{
    public Texture2D cursor1;
    public Texture2D cursor2;
    public Texture2D cursor3;
    public Texture2D cursor4;
    public Texture2D cursor5;
    public Texture2D cursor6;
    public Texture2D cursor7;
    public Texture2D cursor8;
    public Texture2D cursor9;
    public Texture2D cursor10;
    public Texture2D cursor11;
    public Texture2D cursor12;
    public Texture2D cursor13;
    public Texture2D cursor14;
    public Texture2D cursor15;
    public Texture2D cursor16;
    public Texture2D cursor17;
    public Texture2D cursor18;
    public Texture2D cursor19;
    public Texture2D cursor20;
    public Texture2D cursor21;

    public static bool itemCursorActive;


    public void Update()
    {
        if (PlaceMobileButtons.isMobile == false)
        {
            if (itemCursorActive == false)
            {
                CheckAllCursors();
                itemCursorActive = true;
            }
        }
    }

    void OnMouseEnter()
    {
        if(PlaceMobileButtons.isMobile == false)
        {
            if (UIelementsClick.hideCursors == true)
            {
                Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
            }
            else
            {
                if (ClickPower.cursor1Equipped == 1)
                {
                    Cursor.SetCursor(cursor1, Vector2.zero, CursorMode.Auto);
                }
                if (ClickPower.cursor2Equipped == 1)
                {
                    Cursor.SetCursor(cursor2, Vector2.zero, CursorMode.Auto);
                }
                if (ClickPower.cursor3Equipped == 1)
                {
                    Cursor.SetCursor(cursor3, Vector2.zero, CursorMode.Auto);
                }
                if (ClickPower.cursor4Equipped == 1)
                {
                    Cursor.SetCursor(cursor4, Vector2.zero, CursorMode.Auto);
                }
                if (ClickPower.cursor5Equipped == 1)
                {
                    Cursor.SetCursor(cursor5, Vector2.zero, CursorMode.Auto);
                }
                if (ClickPower.cursor6Equipped == 1)
                {
                    Cursor.SetCursor(cursor6, Vector2.zero, CursorMode.Auto);
                }
                if (ClickPower.cursor7Equipped == 1)
                {
                    Cursor.SetCursor(cursor7, Vector2.zero, CursorMode.Auto);
                }
                if (ClickPower.cursor8Equipped == 1)
                {
                    Cursor.SetCursor(cursor8, Vector2.zero, CursorMode.Auto);
                }
                if (ClickPower.cursor9Equipped == 1)
                {
                    Cursor.SetCursor(cursor9, Vector2.zero, CursorMode.Auto);
                }
                if (ClickPower.cursor10Equipped == 1)
                {
                    Cursor.SetCursor(cursor10, Vector2.zero, CursorMode.Auto);
                }
                if (ClickPower.cursor11Equipped == 1)
                {
                    Cursor.SetCursor(cursor11, Vector2.zero, CursorMode.Auto);
                }
                if (ClickPower.cursor12Equipped == 1)
                {
                    Cursor.SetCursor(cursor12, Vector2.zero, CursorMode.Auto);
                }
                if (ClickPower.cursor13Equipped == 1)
                {
                    Cursor.SetCursor(cursor13, Vector2.zero, CursorMode.Auto);
                }
                if (ClickPower.cursor14Equipped == 1)
                {
                    Cursor.SetCursor(cursor14, Vector2.zero, CursorMode.Auto);
                }
                if (ClickPower.cursor15Equipped == 1)
                {
                    Cursor.SetCursor(cursor15, Vector2.zero, CursorMode.Auto);
                }
                if (ClickPower.cursor16Equipped == 1)
                {
                    Cursor.SetCursor(cursor16, Vector2.zero, CursorMode.Auto);
                }
                if (ClickPower.cursor17Equipped == 1)
                {
                    Cursor.SetCursor(cursor17, Vector2.zero, CursorMode.Auto);
                }
                if (ClickPower.cursor18Equipped == 1)
                {
                    Cursor.SetCursor(cursor18, Vector2.zero, CursorMode.Auto);
                }
                if (ClickPower.cursor19Equipped == 1)
                {
                    Cursor.SetCursor(cursor19, Vector2.zero, CursorMode.Auto);
                }
                if (ClickPower.cursor20Equipped == 1)
                {
                    Cursor.SetCursor(cursor20, Vector2.zero, CursorMode.Auto);
                }
                if (ClickPower.cursor21Equipped == 1)
                {
                    Cursor.SetCursor(cursor21, Vector2.zero, CursorMode.Auto);
                }
            }
        }
    }

    void OnMouseExit()
    {
        if (PlaceMobileButtons.isMobile == false)
        {
            if (UIelementsClick.hideCursors == true)
            {

            }
            else
            {
                Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
            }
        }
    }

    public void CheckAllCursors()
    {
        if (ClickPower.cursor1Equipped == 1)
        {
            Cursor.SetCursor(cursor1, Vector2.zero, CursorMode.Auto);
        }
        else if (ClickPower.cursor2Equipped == 1)
        {
            Cursor.SetCursor(cursor2, Vector2.zero, CursorMode.Auto);
        }
        else if(ClickPower.cursor3Equipped == 1)
        {
            Cursor.SetCursor(cursor3, Vector2.zero, CursorMode.Auto);
        }
        else if(ClickPower.cursor4Equipped == 1)
        {
            Cursor.SetCursor(cursor4, Vector2.zero, CursorMode.Auto);
        }
        else if(ClickPower.cursor5Equipped == 1)
        {
            Cursor.SetCursor(cursor5, Vector2.zero, CursorMode.Auto);
        }
        else if(ClickPower.cursor6Equipped == 1)
        {
            Cursor.SetCursor(cursor6, Vector2.zero, CursorMode.Auto);
        }
        else if(ClickPower.cursor7Equipped == 1)
        {
            Cursor.SetCursor(cursor7, Vector2.zero, CursorMode.Auto);
        }
        else if(ClickPower.cursor8Equipped == 1)
        {
            Cursor.SetCursor(cursor8, Vector2.zero, CursorMode.Auto);
        }
        else if(ClickPower.cursor9Equipped == 1)
        {
            Cursor.SetCursor(cursor9, Vector2.zero, CursorMode.Auto);
        }
        else if(ClickPower.cursor10Equipped == 1)
        {
            Cursor.SetCursor(cursor10, Vector2.zero, CursorMode.Auto);
        }
        else if(ClickPower.cursor11Equipped == 1)
        {
            Cursor.SetCursor(cursor11, Vector2.zero, CursorMode.Auto);
        }
        else if(ClickPower.cursor12Equipped == 1)
        {
            Cursor.SetCursor(cursor12, Vector2.zero, CursorMode.Auto);
        }
        else if(ClickPower.cursor13Equipped == 1)
        {
            Cursor.SetCursor(cursor13, Vector2.zero, CursorMode.Auto);
        }
        else if(ClickPower.cursor14Equipped == 1)
        {
            Cursor.SetCursor(cursor14, Vector2.zero, CursorMode.Auto);
        }
        else if(ClickPower.cursor15Equipped == 1)
        {
            Cursor.SetCursor(cursor15, Vector2.zero, CursorMode.Auto);
        }
        else if(ClickPower.cursor16Equipped == 1)
        {
            Cursor.SetCursor(cursor16, Vector2.zero, CursorMode.Auto);
        }
        else if(ClickPower.cursor17Equipped == 1)
        {
            Cursor.SetCursor(cursor17, Vector2.zero, CursorMode.Auto);
        }
        else if(ClickPower.cursor18Equipped == 1)
        {
            Cursor.SetCursor(cursor18, Vector2.zero, CursorMode.Auto);
        }
        else if (ClickPower.cursor19Equipped == 1)
        {
            Cursor.SetCursor(cursor19, Vector2.zero, CursorMode.Auto);
        }
        else if (ClickPower.cursor20Equipped == 1)
        {
            Cursor.SetCursor(cursor20, Vector2.zero, CursorMode.Auto);
        }
        else if (ClickPower.cursor21Equipped == 1)
        {
            Cursor.SetCursor(cursor21, Vector2.zero, CursorMode.Auto);
        }
        else
        {
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        }
    }
}
