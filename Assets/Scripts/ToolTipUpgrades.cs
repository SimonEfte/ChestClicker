using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ToolTipUpgrades : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject UpgradesHover;
    public Transform setBar;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(PlaceMobileButtons.isMobile == false)
        {
            UpgradesHover.transform.position = setBar.transform.position;
            UpgradesHover.SetActive(true);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (PlaceMobileButtons.isMobile == false)
        {
            UpgradesHover.SetActive(false);
        }
    }

    public bool foundClose;
    public GameObject closeBtn;
    public static bool hoveringChicken;

    public void OpenFrameMobile()
    {
        if(PlaceMobileButtons.isMobile == false) { return; }
        if(foundClose == false)
        {
            foundClose = true;
            closeBtn = GameObject.Find("CloseAch");
        }

        if(gameObject.name == "AchUseChicken") { hoveringChicken = true;  }
        else { hoveringChicken = false; }

        UpgradesHover.name = "CurrentAchOpen";

        closeBtn.transform.SetParent(UpgradesHover.transform);
        closeBtn.transform.localPosition = new Vector2(0, -85.4f);
        closeBtn.transform.localScale = new Vector2(0.68f, 0.68f);

        UpgradesHover.transform.localPosition = new Vector2(0, 0);
        UpgradesHover.transform.localScale = new Vector2(1.822f, 1.822f);

        if(PlaceMobileButtons.isFoldPhone == true)
        {
            UpgradesHover.transform.localScale = new Vector2(1.53f, 1.53f);
        }
        UpgradesHover.SetActive(true);
    }

    public GameObject dark;

    public void OpenPrestigeInfo()
    {
        if(PlaceMobileButtons.isMobile == true)
        {
            UpgradesHover.SetActive(true);
            UpgradesHover.transform.localPosition = new Vector2(0, 15);
            UpgradesHover.transform.localScale = new Vector2(0.67f, 0.67f);
            if(PlaceMobileButtons.isFoldPhone == true)
            {
                UpgradesHover.transform.localPosition = new Vector2(0, 5);
                UpgradesHover.transform.localScale = new Vector2(0.55f, 0.55f);
            }
            closeBtn.SetActive(true);
            dark.SetActive(true);
        }
    }

    public GameObject bucketToolTip, bucketClose, bucketCollect, bucketDark;
    public static bool isBucketFrameOpen;

    public void OpenBucket()
    {
        if(PlaceMobileButtons.isMobile == false) { return; }
        isBucketFrameOpen = true;
        bucketToolTip.SetActive(true);
        bucketToolTip.transform.localPosition = new Vector2(0,50);
        bucketToolTip.transform.localScale = new Vector2(4.4f, 4.4f);
        bucketClose.SetActive(true);
        bucketCollect.SetActive(true);
        bucketDark.SetActive(true);
    }

    public void CloseBucker()
    {
        isBucketFrameOpen = false;
        bucketToolTip.SetActive(false);
        bucketClose.SetActive(false);
        bucketCollect.SetActive(false);
        bucketDark.SetActive(false);
    }

    public void CloseFrame()
    {
        UpgradesHover.SetActive(false); dark.SetActive(false);
    }

}
