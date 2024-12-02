using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mimicChest : MonoBehaviour
{
    private Button button;
    public float minX = -5f;
    public float maxX = 5f;
    public float minY = -3f;
    public float maxY = 3f;
    public bool resetChest;
    public float alphaValueFull, alphavalueHalf;

    private void Start()
    {
        alphaValueFull = 1f; alphavalueHalf = 0f;
        button = GetComponent<Button>();
        button.onClick.AddListener(MimicChestReward);
    }

    public void Update()
    {
        if (SaveAndLoad.resetMimicChest == true && resetChest == true)
        {
            //Debug.Log("ResetMiniChest");
            ObjectPooling.instance.ReturnMimicChestFromPool(gameObject);

            resetChest = false;
        }

        if (UIelementsClick.turnOfMimicChest == 1)
        {
            if (UpdateGame.isMimicCountdown == true)
            {
                UpdateGame.spawnMimicChest = true;
                ObjectPooling.instance.ReturnMimicChestFromPool(gameObject);
            }
        }
    }

    private void OnEnable()
    {
        if (PlaceMobileButtons.isMobile == true)
        {
            minX = 2f;
            maxX = -2f;
            minY = 2.5f;
            maxY = -2.5f;
        }

        SetRandomPosition();
        resetChest = true;

        if (UIelementsClick.turnOfMimicChest == 1) { SetAlphaPassive(gameObject.GetComponent<Image>(), alphavalueHalf); }
        if (UIelementsClick.turnOfMimicChest == 0) { StartCoroutine(wait()); }
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.05f);
        SetAlphaPassive(gameObject.GetComponent<Image>(), alphaValueFull);
    }

    private void SetAlphaPassive(Graphic graphic, float alpha)
    {
        Color currentColor = graphic.color;
        currentColor.a = alpha;
        graphic.color = currentColor;

        for (int i = 0; i < graphic.transform.childCount; i++)
        {
            Graphic childGraphic = graphic.transform.GetChild(i).GetComponent<Graphic>();
            if (childGraphic != null)
            {
                SetAlphaPassive(childGraphic, alpha);
            }
        }
    }

    private void SetRandomPosition()
    {
        Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0f);
        gameObject.transform.position = randomPosition;
        gameObject.GetComponent<Animation>().Play();

        StartCoroutine(DeactivateAfterDelay());
    }

    private System.Collections.IEnumerator DeactivateAfterDelay()
    {
        yield return new WaitForSeconds(2f);
    }

    //bad mimic chest rewards
    public static bool mimicEvilDamage, mimicEvilGold, mimicEvilXP, mimicEvilGoldCoinDrop, mimicEvilTreasureDrop;

    //good mimic chest rewards
    public static bool mimicGoodDamage, mimicGoodGold, mimicPositiveXP, mimicGoodGoldCoinDrop, mimicGoodTreasureDrop, mimicGoodRareTreasureDrop;
    public static bool hitGoodMimicChest, hitEvilMimicChest;

    public void MimicChestReward()
    {
        if (UpdateGame.isMimicCountdown == true)
        {
            UpdateGame.spawnMimicChest = true;
        }

        UpdateGame.clickedMimicChest = true;
        UpdateGame.mimicChestText = true;
        int goodOrEvilMimicChest = Random.Range(1, 101);

        if(goodOrEvilMimicChest <= UpdateGame.mimicPositiveBuffChance)
        {
             HitGoodMimic();
            if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("MiniChestClick"); }
        }
        if (goodOrEvilMimicChest > UpdateGame.mimicPositiveBuffChance)
        {
             HitEvilMimic();
            if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("EvilMimic"); }
        }

        ObjectPooling.instance.ReturnMimicChestFromPool(gameObject);
    }

    public void HitGoodMimic()
    {
        int randomMimicChestBonus = Random.Range(1, 101);
        if (randomMimicChestBonus <= 5)
        {
            mimicGoodRareTreasureDrop = true;
        }
        else if (randomMimicChestBonus <= 15)
        {
            mimicGoodTreasureDrop = true;
        }
        else if (randomMimicChestBonus <= 30)
        {
            mimicGoodGoldCoinDrop = true;
        }
        else if (randomMimicChestBonus <= 55)
        {
            mimicPositiveXP = true;
        }
        else if (randomMimicChestBonus <= 75)
        {
            mimicGoodGold = true;
        }
        else
        {
            mimicGoodDamage = true;
        }

    }

    public void HitEvilMimic()
    {
        int randomMimicChestNegative = Random.Range(1, 101);
        if (randomMimicChestNegative <= 13)
        {
            mimicEvilTreasureDrop = true;
        }
        else if (randomMimicChestNegative <= 25)
        {
            mimicEvilGoldCoinDrop = true;
        }
        else if (randomMimicChestNegative <= 55)
        {
            mimicEvilXP = true;
        }
        else if (randomMimicChestNegative <= 75)
        {
            mimicEvilGold = true;
        }
        else
        {
            mimicEvilDamage = true;
        }

    }
}
