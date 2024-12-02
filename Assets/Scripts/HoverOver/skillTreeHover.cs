using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class skillTreeHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject bar;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (PlaceMobileButtons.isMobile == false) { bar.SetActive(true); }

        Transform child = transform.Find("PopUp");
        if (child != null)
        {
            // If the child exists, set it inactive
            child.gameObject.SetActive(false);
        }
    }

    public GameObject offBtn, onBtn, closeBtn, dark;
    //1.7,1.7
    //143,223

    public void OpenFrame()
    {
        if(PlaceMobileButtons.isMobile == true)
        {
            if(gameObject.name == "AutoPurchaseChest")
            {
                if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("UIClick1"); }
            }
            offBtn.SetActive(true);
            onBtn.SetActive(true);
            closeBtn.SetActive(true);
            dark.SetActive(true);

            bar.SetActive(true);
            bar.transform.localPosition = new Vector2(0,64);
            bar.transform.localScale = new Vector2(3.6f, 3.6f);
            if(PlaceMobileButtons.isFoldPhone == true)
            {
                bar.transform.localPosition = new Vector2(0, 34);
                bar.transform.localScale = new Vector2(3.12f, 3.12f);
            }
        }
    }

    public void CloseFrame()
    {
        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("UIClick1"); }

        dark.SetActive(false);
        bar.SetActive(false);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (PlaceMobileButtons.isMobile == true) { return; }
        bar.SetActive(false);
    }
}
