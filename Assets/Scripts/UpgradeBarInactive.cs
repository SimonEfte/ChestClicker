using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UpgradeBarInactive : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public static bool isMouseOver = false;

    private void Update()
    {
        if (PlaceMobileButtons.isMobile == false) 
        {
            if (!isMouseOver && Input.GetMouseButtonDown(0))
            {
                StartCoroutine(Wait());
            }
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.12f);
        if (!isMouseOver)
        {
            gameObject.SetActive(false);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (PlaceMobileButtons.isMobile == false) { isMouseOver = true; }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if(PlaceMobileButtons.isMobile == false) { isMouseOver = false; }
    }
}
