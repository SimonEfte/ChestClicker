using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HoverMax : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Vector3 originalPosition;
    private bool isHovering = false;
    private float animationSpeed = 2.5f; // Adjust the speed of the animation here
    public GameObject openArrow, backArrow;

    private void Start()
    {
        animationSpeed = 10;
        originalPosition = transform.localPosition;
    }

    private void Update()
    {
        if(PlaceMobileButtons.isMobile == false)
        {
            if (isHovering)
            {
                // Calculate the new position while hovering
                Vector3 targetPosition = originalPosition - new Vector3(205f, 0, 0); // Adjust the distance to move to the left

                // Move the object smoothly towards the target position
                transform.localPosition = Vector3.Lerp(transform.localPosition, targetPosition, Time.deltaTime * animationSpeed);
            }
            else
            {
                // Return to the original position when not hovering
                transform.localPosition = Vector3.Lerp(transform.localPosition, originalPosition, Time.deltaTime * animationSpeed);
            }
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (PlaceMobileButtons.isMobile == false)
        {
            openArrow.SetActive(false); backArrow.SetActive(true);
            isHovering = true;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (PlaceMobileButtons.isMobile == false)
        {
            openArrow.SetActive(true); backArrow.SetActive(false);
            isHovering = false;
        }
    }
}
