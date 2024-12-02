using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class outlineHover : MonoBehaviour
{
    private Outline outline;
    private Collider2D collider2d;
    public string targetHexColor;

    private void Start()
    {
        targetHexColor = "FFFFFF";
        outline = GetComponent<Outline>();
    }

    private void OnMouseEnter()
    {
        Image image = GetComponent<Image>();

        if (image != null)
        {
            Color imageColor = image.color;

            string hexColor = ColorUtility.ToHtmlStringRGB(imageColor);

            if (hexColor == targetHexColor)
            {
                    outline.enabled = true;
                
            }
        }
    }

    private void OnMouseExit()
    {
        outline.enabled = false;
    }

}
