using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestClickBounceEffect : MonoBehaviour
{
    public float minScale; // the minimum scale factor
    public float maxScale; // the maximum scale factor

    private Vector3 initialScale;

    void Start()
    {
      
        initialScale = transform.localScale; 
    }

    public void OnClick()
    {
        float randomScale = Random.Range(minScale, maxScale); // generate a random scale factor
        Vector3 targetScale = initialScale * randomScale; // calculate the target scale
        StartCoroutine(ScaleObject(targetScale)); // start the scaling coroutine
    }

    
    private IEnumerator ScaleObject(Vector3 targetScale)
    {
        float duration = 0.08f; // the duration of the scaling animation
        float elapsed = 0f;

        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            float t = Mathf.Clamp01(elapsed / duration);
            float scale = Mathf.Lerp(1f, targetScale.x, t); // interpolate the scale factor
            transform.localScale = initialScale * scale; // apply the scale
            yield return null;
        }

        // scale back to the initial scale
        elapsed = 0f;
        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            float t = Mathf.Clamp01(elapsed / duration);
            float scale = Mathf.Lerp(targetScale.x, 1f, t); // interpolate the scale factor
            transform.localScale = initialScale * scale; // apply the scale
            yield return null;
        }

        transform.localScale = initialScale; // make sure we end up at the initial scale
    }
}
