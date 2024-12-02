using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseKey : MonoBehaviour
{
    public static bool isAttached = false;
    private Transform moveObject;
    private Vector3 offset;
    public static bool hoverOverChest;
    public static bool usedLockPick;

    public void Start()
    {
        hoverOverChest = false; 
    }

    private void Update()
    {
        if (isAttached && moveObject != null) // Add a null check for moveObject
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moveObject.position = mousePosition + offset;
            Cursor.visible = false;
        }

    }

    private void OnMouseEnter()
    {
        if (!isAttached)
        {
            isAttached = true;
            moveObject = transform;
            offset = moveObject.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.name == "KEY" && collision.gameObject.tag == "Chests")
        {
            hoverOverChest = true;
        }

        if (gameObject.name == "LockPick" && collision.gameObject.tag == "Chests")
        {
            usedLockPick = true;
        }
    }

    private void OnDisable()
    {
        if (isAttached)
        {
            isAttached = false;
            moveObject = null; // Reset the moveObject reference
        }
    }


}
