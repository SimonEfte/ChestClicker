using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradesAlpha : MonoBehaviour
{

    public Image passiveUpgrade;
    public Image activeUpgrade;
    public float fadeDuration = 0.1f;

    private Coroutine fadeCoroutine;

    private void OnMouseEnter()
    {
        if (PlaceMobileButtons.isMobile == true) { return; }

        if (fadeCoroutine != null)
            StopCoroutine(fadeCoroutine);

        fadeCoroutine = StartCoroutine(FadeAlpha(passiveUpgrade, 1f, fadeDuration));
        fadeCoroutine = StartCoroutine(FadeAlpha(activeUpgrade, 1f, fadeDuration));
    }

   

    private IEnumerator FadeAlpha(Image image, float targetAlpha, float duration)
    {
        Color startColor = image.color;
        Color targetColor = startColor;
        targetColor.a = targetAlpha;

        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            float t = elapsedTime / duration;
            image.color = Color.Lerp(startColor, targetColor, t);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        image.color = targetColor;
    }

    private void OnMouseExit()
    {
        if (fadeCoroutine != null)
            StopCoroutine(fadeCoroutine);

        fadeCoroutine = StartCoroutine(FadeAlphahalf(passiveUpgrade, 0.35f, fadeDuration));
        fadeCoroutine = StartCoroutine(FadeAlphahalf(activeUpgrade, 0.35f, fadeDuration));
    }


    private IEnumerator FadeAlphahalf(Image image, float targetAlpha, float duration)
    {
        Color startColor = image.color;
        Color targetColor = startColor;
        targetColor.a = targetAlpha;

        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            float t = elapsedTime / duration;
            image.color = Color.Lerp(startColor, targetColor, t);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        image.color = targetColor;
    }

}
