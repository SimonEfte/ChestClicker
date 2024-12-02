using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutsideScreen : MonoBehaviour
{
    private Image objectImage;
    private Camera mainCamera;

    private void Start()
    {
        objectImage = GetComponent<Image>();
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (!IsVisibleOnScreen())
        {
            float yOffset = 0.5f; 
            transform.position += new Vector3(0, yOffset, 0);
        }
    }

    private bool IsVisibleOnScreen()
    {
        Vector3 viewportPosition = mainCamera.WorldToViewportPoint(transform.position);

        if (viewportPosition.y < 0 || viewportPosition.y > 1.2f)
        {
            return false; 
        }

        if (objectImage && objectImage.color.a <= 0)
        {
            return false; 
        }

        return true; 
    }
}
