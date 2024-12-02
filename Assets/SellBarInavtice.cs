using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SellBarInavtice : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public static bool isMouseOver = false;

    private void Update()
    {
        if(PlaceMobileButtons.isMobile == false)
        {
            if (!isMouseOver && Input.GetMouseButtonDown(0))
            {
                gameObject.SetActive(false);
            }
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseOver = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseOver = false;
    }

}
