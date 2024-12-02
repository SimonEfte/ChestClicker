using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ToolTipChests : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject chestHoverBar;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(PlaceMobileButtons.isMobile == false) { chestHoverBar.SetActive(true); }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (PlaceMobileButtons.isMobile == false) { chestHoverBar.SetActive(false); }
    }

    public GameObject closeChestHoverBTN, dark;
    public void OpenChestTooltip()
    {
        if(PlaceMobileButtons.isMobile == true)
        {
            dark.SetActive(true);
            closeChestHoverBTN.SetActive(true);
            chestHoverBar.SetActive(true);
            chestHoverBar.transform.localPosition = new Vector2(0, 35);
            chestHoverBar.transform.localScale = new Vector2(3.65f, 3.65f);
            if (PlaceMobileButtons.isFoldPhone == true)
            {
                chestHoverBar.transform.localPosition = new Vector2(0, -7.4f);
                chestHoverBar.transform.localScale = new Vector2(2.94f, 2.94f);
            }
        }
    }

    public void CloseChestTooltip()
    {
        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("UIClick1"); }
        dark.SetActive(false);
        closeChestHoverBTN.SetActive(false);
        chestHoverBar.SetActive(false);
    }
}
