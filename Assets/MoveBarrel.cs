using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MoveBarrel : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject realBarrel, boarderBarrel;
    public Color normalColor;
    public Color highlightColor;

    private Vector3 screenPoint;
    private Vector3 offset;
    private bool isDragging;

    public Image image;

    private bool snapBack;
    public bool isHovering;
    public static bool isHoveringBucket;
    public GameObject barrelHover;

    private void Start()
    {
        //image = GetComponent<Image>();
        SetColor(normalColor);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (isHoveringBucket == false)
        {
            isHovering = true;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isHoveringBucket = false;
        isHovering = false;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0)) { isHoveringBucket = true; }
        else { isHoveringBucket = false; }

        if (gameObject.transform.position != realBarrel.transform.position)
        {
            barrelHover.SetActive(false); gameObject.GetComponent<Button>().interactable = false;
            image.gameObject.SetActive(true);

        }
        else { gameObject.GetComponent<Button>().interactable = true; image.gameObject.SetActive(false); }

        if (Input.GetMouseButton(0) && isHovering == true)
        {
            isDragging = true;

            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }

        if (!Input.GetMouseButton(0)) { isDragging = false; }

        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;

            if (snapBack == false)
            {
                // Snap realBarrel to this gameobject's X position
                if (realBarrel != null)
                {
                    Vector3 newPosition = realBarrel.transform.position;
                    newPosition.x = transform.position.x;
                    realBarrel.transform.position = newPosition;

                    boarderBarrel.transform.position = newPosition;
                }
            }

            if (snapBack == true)
            {
                // Snap realBarrel to this gameobject's X position
                if (realBarrel != null)
                {
                    SetColor(normalColor);
                    gameObject.transform.position = realBarrel.transform.position;
                }
            }
        }

        if (isDragging)
        {
            Vector3 cursorScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorScreenPoint) + offset;
            cursorPosition.y = transform.position.y; // Lock Y position
            transform.position = cursorPosition;

            // Check if hovering over object with "ChestBackground" tag
            Collider2D[] colliders = Physics2D.OverlapPointAll(cursorPosition);
            bool isOverChestBackground = false;
            foreach (var collider in colliders)
            {
                if (collider.CompareTag("ChestBackground"))
                {
                    isOverChestBackground = true;
                    break;
                }
            }

            // Change color based on hovering over "ChestBackground"
            if (isOverChestBackground)
            {
                SetColor(normalColor);
                snapBack = false;
            }
            else
            {
                SetColor(highlightColor);
                snapBack = true;
            }
        }
    }

    private void SetColor(Color color)
    {
        if (image != null)
        {
            image.color = color;
        }
    }
}
