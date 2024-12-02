using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoulGemClick : MonoBehaviour
{
    private Button button;
    public static bool clickedOnSoulGem;
    public static Vector2 soulGemPos;
    public bool inactive;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ClickOnSoulGem);
    }

    public void OnEnable()
    {
        inactive = true;
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(360);
        ClickOnSoulGem();
    }

    public void Update()
    {
        if(SkillTree.setSoulGemInactive == true && inactive == true)
        {
            StopAllCoroutines();
            ObjectPooling.instance.ReturnSoulGemFromPool(gameObject);
            inactive = false;
        }
    }

    public void ClickOnSoulGem()
    {
        SpawnRewards.gemOnScreenCount -= 1;
        soulGemPos = transform.localPosition;
        clickedOnSoulGem = true;

        ObjectPooling.instance.ReturnSoulGemFromPool(gameObject);

        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("SoulGem"); }
    }
}
