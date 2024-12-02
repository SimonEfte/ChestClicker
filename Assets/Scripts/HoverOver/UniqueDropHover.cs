using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UniqueDropHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    [Header("Alpha Values")]
    public float hoverAlpha = 1f;
    public float defaultAlpha = 0.6f;

    [Header("Hover Animation")]
    public float hoverAnimationHeight = 0.1f;
    public float hoverAnimationSpeed = 2f;

    private Vector3 defaultPosition;
    private bool isHovering = false;

    private RectTransform rectTransform;
    private Image image;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        image = GetComponent<Image>();
        defaultPosition = rectTransform.localPosition;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (PlaceMobileButtons.isMobile == true) { return; }
        isHovering = true;
        StopAllCoroutines();
        StartCoroutine(AnimateHover(true));
        UpdateAlpha(hoverAlpha);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (PlaceMobileButtons.isMobile == true) { return; }
        isHovering = false;
        StopAllCoroutines();
        StartCoroutine(AnimateHover(false));
        UpdateAlpha(defaultAlpha);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // Handle click event if needed
    }

    private IEnumerator AnimateHover(bool hover)
    {
        Vector3 targetPosition = hover ? defaultPosition + new Vector3(0f, hoverAnimationHeight, 0f) : defaultPosition;
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime * hoverAnimationSpeed;
            rectTransform.localPosition = Vector3.Lerp(rectTransform.localPosition, targetPosition, t);
            yield return null;
        }
    }

    private void UpdateAlpha(float alpha)
    {
        Color objectColor = image.color;
        objectColor.a = alpha;
        image.color = objectColor;
    }
}
