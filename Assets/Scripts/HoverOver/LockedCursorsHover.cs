using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class LockedCursorsHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject cursorNotUnlockeBar;
    public Transform setBar;
    public TextMeshProUGUI chestNumberLocked;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(PlaceMobileButtons.isMobile == true) { return; }

        string objectName = eventData.pointerEnter.name;

        if (objectName == "Cursor4")
        { 
            chestNumberLocked.text = Localization.NOdot + "3"; cursorNotUnlockeBar.transform.position = setBar.transform.position;
            cursorNotUnlockeBar.SetActive(true);
        }
        else if (objectName == "Cursor5" || objectName == "Cursor6")
        {
            chestNumberLocked.text = Localization.NOdot + "5"; cursorNotUnlockeBar.transform.position = setBar.transform.position;
            cursorNotUnlockeBar.SetActive(true);
        }
        else if(objectName == "Cursor7")
        {
            chestNumberLocked.text = Localization.NOdot + "7"; cursorNotUnlockeBar.transform.position = setBar.transform.position;
            cursorNotUnlockeBar.SetActive(true);
        }
        else if(objectName == "Cursor8")
        {
            chestNumberLocked.text = Localization.NOdot + "8"; cursorNotUnlockeBar.transform.position = setBar.transform.position;
            cursorNotUnlockeBar.SetActive(true);
        }
        else if(objectName == "Cursor9")
        {
            chestNumberLocked.text = Localization.NOdot + "10"; cursorNotUnlockeBar.transform.position = setBar.transform.position;
            cursorNotUnlockeBar.SetActive(true);
        }
        else if(objectName == "Cursor10")
        {
            chestNumberLocked.text = Localization.NOdot + "12"; cursorNotUnlockeBar.transform.position = setBar.transform.position;
            cursorNotUnlockeBar.SetActive(true);
        }
        else if(objectName == "Cursor11" || objectName == "Cursor12")
        {
            chestNumberLocked.text = Localization.NOdot + "14"; cursorNotUnlockeBar.transform.position = setBar.transform.position;
            cursorNotUnlockeBar.SetActive(true);
        }
        else if(objectName == "Cursor13")
        {
            chestNumberLocked.text = Localization.NOdot + "16"; cursorNotUnlockeBar.transform.position = setBar.transform.position;
            cursorNotUnlockeBar.SetActive(true);
        }
        else if(objectName == "Cursor14")
        {
            chestNumberLocked.text = Localization.NOdot + "18"; cursorNotUnlockeBar.transform.position = setBar.transform.position;
            cursorNotUnlockeBar.SetActive(true);
        }
        else if(objectName == "Cursor15")
        {
            chestNumberLocked.text = Localization.NOdot + "20"; cursorNotUnlockeBar.transform.position = setBar.transform.position;
            cursorNotUnlockeBar.SetActive(true);
        }
        else if(objectName == "Cursor16")
        {
            chestNumberLocked.text = Localization.NOdot + "23"; cursorNotUnlockeBar.transform.position = setBar.transform.position;
            cursorNotUnlockeBar.SetActive(true);
        }
        else if(objectName == "Cursor17")
        {
            chestNumberLocked.text = Localization.NOdot + "24"; cursorNotUnlockeBar.transform.position = setBar.transform.position;
            cursorNotUnlockeBar.SetActive(true);
        }
        else if(objectName == "Cursor18")
        {
            chestNumberLocked.text = Localization.NOdot + "27"; cursorNotUnlockeBar.transform.position = setBar.transform.position;
            cursorNotUnlockeBar.SetActive(true);
        }
        else if (objectName == "Cursor19")
        {
            chestNumberLocked.text = Localization.NOdot + "31"; cursorNotUnlockeBar.transform.position = setBar.transform.position;
            cursorNotUnlockeBar.SetActive(true);
        }
        else if (objectName == "Cursor20")
        {
            chestNumberLocked.text = Localization.NOdot + "35"; cursorNotUnlockeBar.transform.position = setBar.transform.position;
            cursorNotUnlockeBar.SetActive(true);
        }
        else if (objectName == "Cursor21")
        {
            chestNumberLocked.text = Localization.NOdot + "38"; cursorNotUnlockeBar.transform.position = setBar.transform.position;
            cursorNotUnlockeBar.SetActive(true);
        }
        else { cursorNotUnlockeBar.SetActive(false); }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        cursorNotUnlockeBar.SetActive(false);
    }
}
