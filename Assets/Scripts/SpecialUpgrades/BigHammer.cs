using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigHammer : MonoBehaviour
{
    public bool isAttached = false;
    private Transform attachedObject;
    private Vector3 offset;
    public bool setHammerIncactive;

    public void OnEnable()
    {
        setHammerIncactive = false;
    }

    private void Update()
    {
        if (isAttached)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            attachedObject.position = mousePosition + offset;
            if (Input.GetMouseButtonDown(0)) { gameObject.GetComponent<Animation>().Play(); }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Cursor.visible = true;
            }
        }

        if (SkillTree.pressedPrestige == true)
        {
            setHammerIncactive = true;
            if(setHammerIncactive == true)
            {
                attachedObject.gameObject.SetActive(false);
                Cursor.visible = true;
                isAttached = false;
                UseConsumable.blockBarSet = true;
                StopAllCoroutines();

                Debug.Log(SkillTree.pressedPrestige);

                setHammerIncactive = false;
            }
        }
    }

    private void OnMouseEnter()
    {
        if (!isAttached)
        {
            StartCoroutine(DeactivateAfterDelay(SpecialUpgradesButtons.hammerTimer));
            isAttached = true;
            attachedObject = transform;
            offset = attachedObject.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Cursor.visible = false;
        }
    }


    private System.Collections.IEnumerator DeactivateAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        attachedObject.gameObject.SetActive(false);
        Cursor.visible = true;
        isAttached = false;
        UseConsumable.blockBarSet = true;
    }
}
