using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UpdateGame : MonoBehaviour, IDataPersistence
{
    public static double totalGoldHigher;
    public static double barrelOfGoldAmountDouble;

    public GameObject bucketHover;
    public TextMeshProUGUI bucketGoldAmountText;

    public Color originalColor;

    public float alphaHalf = 0.35f;

    public AudioManager audioManager;

    #region new prestige upgrades

    public float alphaValueFull = 1f;
    public GameObject[] reinforcedUnlocked = new GameObject[5];
    public GameObject[] greaterLootUnlocked = new GameObject[5];
    public GameObject[] newChestsUnlocked = new GameObject[6];

    public TextMeshProUGUI[] reinforcedTextPricesText = new TextMeshProUGUI[5];
    public TextMeshProUGUI[] greaterLootTextPricesText = new TextMeshProUGUI[5];
    public TextMeshProUGUI[] newChestsTextPricesText = new TextMeshProUGUI[6];

    public TextMeshProUGUI reinforcedChestHealthHover, reinforcedChestGoldHover, reinforcedChestXPHover;
    #endregion

    #region shopAndItemsVariables
    public float textSize;

    public static int knifeBoughtFirstTime, barrelBoughtFirstTime, treasurePotionBoughtFirstTime, mimicChestBoughtFirstTime;

    public static float knifeDropChance, knifeDropChanceIncrement, treasurePotionDropChance, treasurePotionDropChanceIncrement;

    public static double knifeBuyPriceDouble, barrelBuyPriceDouble, treasurePotionBuyPriceDouble, mimicChestBuyPriceDouble;

    public static int knifeLevel, barrelLevel, treasurePotionLevel, mimicChestLevel;
    public static int knifeGemPrice, knifeGemPrice2, barrelGemPrice, treasurePotionGemPrice, treasurePotionGemPrice2, mimicChestGemPrice;

    public GameObject knifeLocked, barrelLocked, treasurePotionLocked, mimicChestLocked;
    public TextMeshProUGUI knifeCountText, treasurePotionCounText;
    public TextMeshProUGUI knifeOwnedText, treasurePotionOwnedText;

    public GameObject knifeUpgrade, treasurePotionUpgrade;

    public static bool isMimicCountdown, spawnMimicChest, clickedMimicChest, mimicChestText, startMimicChest;
    #endregion

    #region mimicChestVariables

    public GameObject negativeGoldIcon, negativeDamageIcon, negativeXPIcon, negativeTreasureIcon, negativeGoldCoinIcon, positiveGoldIcon, positiveDamageIcon, positiveXPIcon;
    public GameObject positiveTreasureIcon, positiveCoinDropIcon, treasurePotionIcon, rareTreasureBuffIcon;

    public GameObject negativeGoldHover, negativeDamageHover, negativeXPHover, negativeTreasureHover, negativeColdCoinHover;
    public GameObject positiveGoldHover, positiveDamageHover, positiveXPHover, positiveTreasureHover, positiveColdCoinHover, treasurePotionHover, rareTreasureBuffHover;

    public TextMeshProUGUI goldBuffText, damageBuffText, XPBuffText, treasureDropBuffText, goldCoinBuffText, treasurePotionBuffHoverText, rareTreasureBuffText;
    public TextMeshProUGUI goldDebuffText, damageDebuffText, xpDebuffText, treasureDropDebuffText, goldCoinDebuffText;

    public TextMeshProUGUI goldBuffTimerText, damageBuffTimerrText, XPBuffTimerrText, treasureDropTimerrText, goldCoinTimerrText, treasurePotionTimerrText, rareTreasureTimerrText;
    public TextMeshProUGUI goldDebuffTimerText, damageDebuffTimerText, XPDebuffTimerText, treasureDebuffTimerText, goldCoinDebuffTimerText;

    public static float goldBuffTimer, damageBuffTimer, XPBuffTimer, treasureDropBuffTimer, goldCoinDropBuffTimer, rareTreasureBuffTimer;
    public static float goldDebuffTimer, damageDebuffTimer, XPDebuffTimer, treasureDropDebuffTimer, goldCoinDropDebuffTimer;

    public static float goldBuffAmount, damageBuffAmount, XPBuffAmount, treasureDropBuffAmount;
    public static float goldDebuffAmount, damageDebuffAmount, XPDebuffAmount, treasureDebuffAmount;

    public static int goldCoinBuffAmount, goldCoinDebuffAmount;

    public static bool isGoldCoinDropBuffActive, isRareTreasureDropBuffActive, isGoldCoinDropDebuffActive;

    private Coroutine goldBuffCoroutine, damageBuffCoroutine, XPBuffCoroutine, treasureDropBuffCoroutine, goldCoinDropBuffCoroutine, rareTreasureDropCoroutine;
    private Coroutine goldDebuffCoroutine, damageDebuffCoroutine, XPDebuffCoroutine, treasureDopDebuffCoroutine, goldCoinDebuffCoroutine;

    #endregion


    //Save
    #region SaveAndLoadJSON
    public void LoadData(GameDataJSON data)
    {
        totalGoldHigher = data.totalGoldAmountNew;

        reinforcedPrestigeChanceIncrease = data.reinforcedPrestigeChanceIncrease;
        reinforcedChestHealth = data.reinforcedChestHealth;
        reinforcedChestGoldIncrease = data.reinforcedChestGoldIncrease;
        reinforcedXPIncrease = data.reinforcedXPIncrease;

        enchantedGoldenChestChance = data.enchantedGoldenChestChance;
        enchantedGoldenChestHealth = data.enchantedGoldenChestHealth;
        enchantedGoldenChestTreasureDrops = data.enchantedGoldenChestTreasureDrops;
        enchantedGoldenChestXPDrops = data.enchantedGoldenChestXPDrops;

        bossChestChance = data.bossChestChance;
        bossChestHealth = data.bossChestHealth;
        bossChestGoldAmount = data.bossChestGoldAmount;
        bossChestGoldCoinsDrops = data.bossChestGoldCoinsDrops;
        bossChestGoldValue = data.bossChestGoldValue;
        bossChestXPDrops = data.bossChestXPDrops;

        //Items
        barrelBuyPriceDouble = data.barrelBuyPriceDouble;
        mimicChestBuyPriceDouble = data.mimicChestBuyPriceDouble;
        treasurePotionBuyPriceDouble = data.treasurePotionBuyPriceDouble;
        knifeBuyPriceDouble = data.knifeBuyPriceDouble;

        knifeBoughtFirstTime = data.knifeBoughtFirstTime;
        barrelBoughtFirstTime = data.barrelBoughtFirstTime;
        treasurePotionBoughtFirstTime = data.treasurePotionBoughtFirstTime;
        mimicChestBoughtFirstTime = data.mimicChestBoughtFirstTime;

        knifeDropChance = data.knifeDropChance;
        knifeDropChanceIncrement = data.knifeDropChanceIncrement;
        treasurePotionDropChance = data.treasurePotionDropChance;
        treasurePotionDropChanceIncrement = data.treasurePotionDropChanceIncrement;

        knifeLevel = data.knifeLevel;
        barrelLevel = data.barrelLevel;
        treasurePotionLevel = data.treasurePotionLevel;
        mimicChestLevel = data.mimicChestLevel;

        knifeGemPrice = data.knifeGemPrice;
        knifeGemPrice2 = data.knifeGemPrice2;
        barrelGemPrice = data.barrelGemPrice;
        treasurePotionGemPrice = data.treasurePotionGemPrice;
        treasurePotionGemPrice2 = data.treasurePotionGemPrice2;
        mimicChestGemPrice = data.mimicChestGemPrice;

        mimicPositiveBuffChance = data.mimicPositiveBuffChance;
        mimicPositiveBiffChanceIncrement = data.mimicPositiveBiffChanceIncrement;
        mimicNegativeBuffChance = data.mimicNegativeBuffChance;
        mimicNegativeBuffChanceIncrement = data.mimicNegativeBuffChanceIncrement;
        mimicChestTimer = data.mimicChestTimer;
        mimicChestTimerIncrement = data.mimicChestTimerIncrement;

        reinforced1Bought = data.reinforced1Bought;
        reinforced2Bought = data.reinforced2Bought;
        reinforced3Bought = data.reinforced3Bought;
        reinforced4Bought = data.reinforced4Bought;
        reinforced5Bought = data.reinforced5Bought;

        greaterLoot1Bought = data.greaterLoot1Bought;
        greaterLoot2Bought = data.greaterLoot2Bought;
        greaterLoot3Bought = data.greaterLoot3Bought;
        greaterLoot4Bought = data.greaterLoot4Bought;
        greaterLoot5Bought = data.greaterLoot5Bought;

        newChests1Bought = data.newChests1Bought;
        newChests2Bought = data.newChests2Bought;
        newChests3Bought = data.newChests3Bought;
        newChests4Bought = data.newChests4Bought;
        newChests5Bought = data.newChests5Bought;
        newChests6Bought = data.newChests6Bought;

        barrelOfGoldAmountDouble = data.barrelOfGoldAmountDouble;

        knifeTimer = data.knifeTimer;
        knifeTimerIncrement = data.knifeTimerIncrement;
        knifeCount = data.knifeCount;

        treasurePotionTimer = data.treasurePotionTimer;
        treasurePotionTimerIncrement = data.treasurePotionTimerIncrement;
        treasurePotionCount = data.treasurePotionCount;

        barrelGoldValue = data.barrelGoldValue;
        barrelGoldValueIncrement = data.barrelGoldValueIncrement;
    }

    public void SaveData(ref GameDataJSON data)
    {
        data.totalGoldAmountNew = totalGoldHigher;

        data.reinforcedPrestigeChanceIncrease = reinforcedPrestigeChanceIncrease;
        data.reinforcedChestHealth = reinforcedChestHealth;
        data.reinforcedChestGoldIncrease = reinforcedChestGoldIncrease;
        data.reinforcedXPIncrease = reinforcedXPIncrease;

        data.enchantedGoldenChestChance = enchantedGoldenChestChance;
        data.enchantedGoldenChestHealth = enchantedGoldenChestHealth;
        data.enchantedGoldenChestTreasureDrops = enchantedGoldenChestTreasureDrops;
        data.enchantedGoldenChestXPDrops = enchantedGoldenChestXPDrops;

        data.bossChestChance = bossChestChance;
        data.bossChestHealth = bossChestHealth;
        data.bossChestGoldAmount = bossChestGoldAmount;
        data.bossChestGoldCoinsDrops = bossChestGoldCoinsDrops;
        data.bossChestGoldValue = bossChestGoldValue;
        data.bossChestXPDrops = bossChestXPDrops;

        //Items
        data.barrelBuyPriceDouble = barrelBuyPriceDouble;
        data.mimicChestBuyPriceDouble = mimicChestBuyPriceDouble;
        data.treasurePotionBuyPriceDouble = treasurePotionBuyPriceDouble;
        data.knifeBuyPriceDouble = knifeBuyPriceDouble;

        data.knifeBoughtFirstTime = knifeBoughtFirstTime;
        data.barrelBoughtFirstTime = barrelBoughtFirstTime;
        data.treasurePotionBoughtFirstTime = treasurePotionBoughtFirstTime;
        data.mimicChestBoughtFirstTime = mimicChestBoughtFirstTime;

        data.knifeDropChance = knifeDropChance;
        data.knifeDropChanceIncrement = knifeDropChanceIncrement;
        data.treasurePotionDropChance = treasurePotionDropChance;
        data.treasurePotionDropChanceIncrement = treasurePotionDropChanceIncrement;

        data.knifeLevel = knifeLevel;
        data.barrelLevel = barrelLevel;
        data.treasurePotionLevel = treasurePotionLevel;
        data.mimicChestLevel = mimicChestLevel;

        data.knifeGemPrice = knifeGemPrice;
        data.knifeGemPrice2 = knifeGemPrice2;
        data.barrelGemPrice = barrelGemPrice;
        data.treasurePotionGemPrice = treasurePotionGemPrice;
        data.treasurePotionGemPrice2 = treasurePotionGemPrice2;
        data.mimicChestGemPrice = mimicChestGemPrice;

        data.mimicPositiveBuffChance = mimicPositiveBuffChance;
        data.mimicPositiveBiffChanceIncrement = mimicPositiveBiffChanceIncrement;
        data.mimicNegativeBuffChance = mimicNegativeBuffChance;
        data.mimicNegativeBuffChanceIncrement = mimicNegativeBuffChanceIncrement;
        data.mimicChestTimer = mimicChestTimer;
        data.mimicChestTimerIncrement = mimicChestTimerIncrement;

        data.reinforced1Bought = reinforced1Bought;
        data.reinforced2Bought = reinforced2Bought;
        data.reinforced3Bought = reinforced3Bought;
        data.reinforced4Bought = reinforced4Bought;
        data.reinforced5Bought = reinforced5Bought;

        data.greaterLoot1Bought = greaterLoot1Bought;
        data.greaterLoot2Bought = greaterLoot2Bought;
        data.greaterLoot3Bought = greaterLoot3Bought;
        data.greaterLoot4Bought = greaterLoot4Bought;
        data.greaterLoot5Bought = greaterLoot5Bought;

        data.newChests1Bought = newChests1Bought;
        data.newChests2Bought = newChests2Bought;
        data.newChests3Bought = newChests3Bought;
        data.newChests4Bought = newChests4Bought;
        data.newChests5Bought = newChests5Bought;
        data.newChests6Bought = newChests6Bought;

        data.barrelOfGoldAmountDouble = barrelOfGoldAmountDouble;

        data.knifeTimer = knifeTimer;
        data.knifeTimerIncrement = knifeTimerIncrement;
        data.knifeCount = knifeCount;

        data.treasurePotionTimer = treasurePotionTimer;
        data.treasurePotionTimerIncrement = treasurePotionTimerIncrement;
        data.treasurePotionCount = treasurePotionCount;

        data.barrelGoldValue = barrelGoldValue;
        data.barrelGoldValueIncrement = barrelGoldValueIncrement;
    }
    #endregion


    public void Start()
    {
        isBarrelEmpty = true;
        alphaHalf = 0.45f;
        originalColor = knifeCountText.color;
        goldCoinDebuffAmount = 0;
        alphaValueFull = 1;
        textSize = 1.8f;

        startMimicChest = false;
        changeItemUpdate = true;

        Invoke("wait", 0.3f);
    }

    public void wait()
    {
        if(barrelBoughtFirstTime == 1)
        {
            realBarrel.SetActive(true); fakfeBarrel.SetActive(true); barrelDrag.SetActive(true);
        }

        if (mimicChestBoughtFirstTime == 1) { mimicChestLocked.SetActive(true); StartCoroutine(mimicChestCountdown()); }

        #region new prestige upgrades PRICES and loads
        if (reinforced1Bought == 0) { reinforcedChestGoldIncrease = 12; reinforcedPrestigeChanceIncrease = 0; }
        if (reinforced2Bought == 0) { reinforcedChestHealth = 10; reinforcedXPIncrease = 3; }

        reinforced1Price = 15; reinforced2Price = 65; reinforced3Price = 175; reinforced4Price = 250; reinforced5Price = 500;

        reinforcedTextPricesText[0].text = "" + reinforced1Price;
        reinforcedTextPricesText[1].text = "" + reinforced2Price;
        reinforcedTextPricesText[2].text = "" + reinforced3Price;
        reinforcedTextPricesText[3].text = "" + reinforced4Price;
        reinforcedTextPricesText[4].text = "" + reinforced5Price;

        greaterLoot1Price = 10;
        greaterLoot2Price = 50;
        greaterLoot3Price = 185;
        greaterLoot4Price = 300;
        greaterLoot5Price = 360;

        greaterLootTextPricesText[0].text = "" + greaterLoot1Price;
        greaterLootTextPricesText[1].text = "" + greaterLoot2Price;
        greaterLootTextPricesText[2].text = "" + greaterLoot3Price;
        greaterLootTextPricesText[3].text = "" + greaterLoot4Price;
        greaterLootTextPricesText[4].text = "" + greaterLoot5Price;

        newChests1Price = 50;
        newChests2Price = 50;
        newChests3Price = 125;
        newChests4Price = 200;
        newChests5Price = 350;
        newChests6Price = 750;

        newChestsTextPricesText[0].text = "" + newChests1Price;
        newChestsTextPricesText[1].text = "" + newChests2Price;
        newChestsTextPricesText[2].text = "" + newChests3Price;
        newChestsTextPricesText[3].text = "" + newChests4Price;
        newChestsTextPricesText[4].text = "" + newChests5Price;
        newChestsTextPricesText[5].text = "" + newChests6Price;
        #endregion

        SomethingAllUpgradesDo();
        SetInfoText();

        if (mimicChestTimer < 60)
        {
            mimicChestTimer = 60;
        }

        UpdateGame.changeItemUpdate = true;
        changeBarrelTexture = true;

    }

    #region everything mimic chest
    IEnumerator mimicChestCountdown()
    {
        isMimicCountdown = false;
        yield return new WaitForSeconds(mimicChestTimer);
        startMimicChest = true;
        isMimicCountdown = true;
    }

    public TMP_FontAsset korean, english, russian, japanese, chinese;

    IEnumerator mimicChestTextPopUp()
    {
        GameObject chestText = ObjectPooling.instance.GetMiniChestTextFromPool();

        if (Localization.EnglishLanguageChosen == 1) { chestText.GetComponent<TextMeshProUGUI>().font = english; }
        if (Localization.RussianLanguageChosen == 1) { chestText.GetComponent<TextMeshProUGUI>().font = russian; }
        if (Localization.JapaneseLanguageChosen == 1) { chestText.GetComponent<TextMeshProUGUI>().font = japanese; }
        if (Localization.ChineseLanguageChosen == 1) { chestText.GetComponent<TextMeshProUGUI>().font = chinese; }
        if (Localization.KoreanLanguageChosen == 1) { chestText.GetComponent<TextMeshProUGUI>().font = korean; }

        chestText.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        chestText.transform.position = new Vector3(chestText.transform.position.x, chestText.transform.position.y, 1);
        chestText.GetComponent<Animation>().Play("miniChestTextAnim");

        #region mimic chest buff text
        int randomDoubleTimer = Random.Range(1,101);

        //Buffs
        if (mimicChest.mimicGoodGold == true)
        {
            goldBuffTimer = Random.Range(15f, 75f); 
            if(randomDoubleTimer < 16) { goldBuffTimer = goldBuffTimer * 2; }
            chestText.GetComponent<TextMeshProUGUI>().text =  "<color=green>" + Localization.friendlyMimic  +"\n+" + (((1 + UseConsumable.lootPotionGoldBuff + UseConsumable.elixirGoldBuff + ClickPower.cursorEquippedGoldIncrease + SkillTree.skillTreeGold + RareTreasures.runeGold + RareTreasures.cookieGold + RareTreasures.backPackGold + UseConsumable.scrollGoldBuff + UseConsumable.relicPermaGoldBuff) / 6) * 100).ToString("F0") + Localization.goldPercentString +" (" + goldBuffTimer.ToString("F0") + Localization.secondsMimic + ")";
        }
        if (mimicChest.mimicGoodDamage == true)
        {
            damageBuffTimer = Random.Range(15f, 75f);
            if (randomDoubleTimer < 16) { damageBuffTimer = damageBuffTimer * 2; }
            chestText.GetComponent<TextMeshProUGUI>().text = "<color=green>" + Localization.friendlyMimic + "\n+" + (((1 + UseConsumable.damagePotionBuff + UseConsumable.elixirDamageBuff + ClickPower.activeDamageMultiplier + SkillTree.skillTreeActiveDamage + RareTreasures.swordActive + RareTreasures.guitarActiveAndPassive + RareTreasures.cookieActive + UseConsumable.scrollActiveDamageBuff + UseConsumable.relicPermaActiveDamage) / 7) * 100).ToString("F0") + Localization.damagePercent + "( " + damageBuffTimer.ToString("F0") + Localization.secondsMimic + ")";
        }
        if (mimicChest.mimicPositiveXP == true)
        {
            XPBuffTimer = Random.Range(15f, 75f);
            if (randomDoubleTimer < 16) { XPBuffTimer = XPBuffTimer * 2; }
            chestText.GetComponent<TextMeshProUGUI>().text = "<color=green>" + Localization.friendlyMimic + "\n+" + (((1 + UseConsumable.XPPotionBuff + UseConsumable.elixirXPBuff + SkillTree.skillTreeXP + ClickPower.cursorEquippedXPIncrease + RareTreasures.backPackXP + RareTreasures.cookieXP + UseConsumable.scrollXPBuff + UseConsumable.relicPermaXPBuff) / 6) * 100).ToString("F0") + Localization.xp + "(" + XPBuffTimer.ToString("F0") + Localization.secondsMimic + ")";
        }
        if (mimicChest.mimicGoodTreasureDrop == true)
        {
            treasureDropBuffAmount = Random.Range(0.4f, 1f);
            treasureDropBuffTimer = Random.Range(20f, 55f);
            if (randomDoubleTimer < 16) { treasureDropBuffTimer = treasureDropBuffTimer * 2; }
            chestText.GetComponent<TextMeshProUGUI>().text = "<color=green>" + Localization.friendlyMimic + "\n+" + (treasureDropBuffAmount).ToString("F2") + Localization.treasureDropChance + "(" +   treasureDropBuffTimer.ToString("F0") + Localization.secondsMimic + ")";
        }
        if (mimicChest.mimicGoodGoldCoinDrop == true)
        {
            goldCoinBuffAmount = Random.Range(1, 3);
            goldCoinDropBuffTimer = Random.Range(30f, 70f);
            if (randomDoubleTimer < 16) { goldCoinDropBuffTimer = goldCoinDropBuffTimer * 2; }
            chestText.GetComponent<TextMeshProUGUI>().text = "<color=green>" + Localization.friendlyMimic + "\n+" + (goldCoinBuffAmount).ToString("F0") + Localization.goldCoinsDrop + "(" +    goldCoinDropBuffTimer.ToString("F0") + Localization.secondsMimic + ")";
        }
        if (mimicChest.mimicGoodRareTreasureDrop == true)
        {
            rareTreasureBuffTimer = Random.Range(50f, 85f);
            if (randomDoubleTimer < 16) { rareTreasureBuffTimer = rareTreasureBuffTimer * 2; }
            chestText.GetComponent<TextMeshProUGUI>().text = "<color=green>" + Localization.friendlyMimic + "\n " + Localization.rareTreasureDropChance + "(" +  rareTreasureBuffTimer.ToString("F0") + Localization.secondsMimic + ")";
        }
        #endregion

        #region mimic chest debuff text

        //Debuffs
        if (mimicChest.mimicEvilGold == true)
        {
            goldDebuffTimer = Random.Range(15f, 75f);
            chestText.GetComponent<TextMeshProUGUI>().text = "<color=red>" + Localization.evilMimic + "\n-" + (((1 + UseConsumable.lootPotionGoldBuff + UseConsumable.elixirGoldBuff + ClickPower.cursorEquippedGoldIncrease + SkillTree.skillTreeGold + RareTreasures.runeGold + RareTreasures.cookieGold + RareTreasures.backPackGold + UseConsumable.scrollGoldBuff + UseConsumable.relicPermaGoldBuff) / 6) * 100).ToString("F0") + Localization.goldPercentString + "(" +
                goldDebuffTimer.ToString("F0") + Localization.secondsMimic + ")";
        }
        if (mimicChest.mimicEvilDamage == true)
        {
            damageDebuffTimer = Random.Range(15f, 75f);
            chestText.GetComponent<TextMeshProUGUI>().text = "<color=red>" + Localization.evilMimic + "\n-" + (((1 + UseConsumable.damagePotionBuff + UseConsumable.elixirDamageBuff + ClickPower.activeDamageMultiplier + SkillTree.skillTreeActiveDamage + RareTreasures.swordActive + RareTreasures.guitarActiveAndPassive + RareTreasures.cookieActive + UseConsumable.scrollActiveDamageBuff + UseConsumable.relicPermaActiveDamage) / 7) * 100).ToString("F0") + Localization.damagePercent + "(" + damageDebuffTimer.ToString("F0") + Localization.secondsMimic + ")";
        }
        if (mimicChest.mimicEvilXP == true)
        {
            XPDebuffTimer = Random.Range(15f, 75f);
            chestText.GetComponent<TextMeshProUGUI>().text = "<color=red>" + Localization.evilMimic + "\n-" + (((1 + UseConsumable.XPPotionBuff + UseConsumable.elixirXPBuff + SkillTree.skillTreeXP + ClickPower.cursorEquippedXPIncrease + RareTreasures.backPackXP + RareTreasures.cookieXP + UseConsumable.scrollXPBuff + UseConsumable.relicPermaXPBuff) / 6) * 100).ToString("F0") + Localization.xp + "(" + XPDebuffTimer.ToString("F0") + Localization.secondsMimic + ")";
        }
        if (mimicChest.mimicEvilTreasureDrop == true)
        {
            treasureDebuffAmount = Random.Range(0.4f, 1f);
            treasureDropDebuffTimer = Random.Range(29f, 55f);
            chestText.GetComponent<TextMeshProUGUI>().text = "<color=red>" + Localization.evilMimic + "\n-" + (treasureDebuffAmount).ToString("F2") + Localization.treasureDropChance + "(" +  treasureDropDebuffTimer.ToString("F0") + Localization.secondsMimic + ")";
        }
        if (mimicChest.mimicEvilGoldCoinDrop == true)
        {
            goldCoinDebuffAmount = Random.Range(1, 3);
            goldCoinDropDebuffTimer = Random.Range(30f, 70f);
            chestText.GetComponent<TextMeshProUGUI>().text = "<color=red>" + Localization.evilMimic + "\n-" + (goldCoinDebuffAmount).ToString("F0") + Localization.goldCoinsDrop + "(" +
               goldCoinDropDebuffTimer.ToString("F0") + Localization.secondsMimic + ")";

        }
        #endregion

        yield return new WaitForSeconds(1.4f);
        
        ObjectPooling.instance.ReturnMiniChestTextFromPool(chestText);
    }

    #endregion

    public static bool changeItemUpdate;
    public static bool changeBarrelTexture;
    public static bool landedInBarrel, isBarrelEmpty;

    public Sprite emtpyBarrel, fullBarrel;
    public Image realBarrelImage, barrelDragImage;

    public void Update()
    {
        if(landedInBarrel == true)
        {
            if (realBarrelImage.sprite == emtpyBarrel)
            {
                realBarrelImage.sprite = fullBarrel;
                barrelDragImage.sprite = fullBarrel;
            }

            landedInBarrel = false;
        }
        
        if(changeBarrelTexture == true)
        {
            if(barrelOfGoldAmountDouble == 0)
            {
                realBarrelImage.sprite = emtpyBarrel;
                barrelDragImage.sprite = emtpyBarrel;
            }
            else
            {
                realBarrelImage.sprite = fullBarrel;
                barrelDragImage.sprite = fullBarrel;
            }

            changeBarrelTexture = false;
        }

        #region mimicChest
        if (spawnMimicChest == true)
        {
            StartCoroutine(mimicChestCountdown());
            spawnMimicChest = false;
        }

        if (startMimicChest == true && mimicChestBoughtFirstTime == 1)
        {
            clickedMimicChest = true;
            GameObject chest = ObjectPooling.instance.GetMimicChestFromPool();

            if (AudioManager.audioMuted == 1)
            {
                audioManager.Play("MiniChestSpawn");
            }
            if (AudioManager.audioMuted == 0)
            {
                if (SettingsOptions.miniChestSound == 1)
                {
                    if (UIelementsClick.turnOfMimicChest == 0) { audioManager.Play("MiniChestSpawn"); }
                }
            }

            spawnMimicChest = false;
            startMimicChest = false;
        }

        #endregion

        #region barrel

        if(bucketHover.activeInHierarchy == true)
        {
            bucketGoldAmountText.text = "<color=green>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(barrelOfGoldAmountDouble) + "" + Localization.gold;

            if (barrelOfGoldAmountDouble == 0) { bucketGoldAmountText.text = "<color=red>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(barrelOfGoldAmountDouble) + "" + Localization.gold; }

        }
        #endregion

        #region itemsChanges

        if (changeItemUpdate == true)
        {

            #region levels

            knifeLeveLText.text = Localization.lvl + knifeLevel;
            treasurePotionLeveLText.text = Localization.lvl + treasurePotionLevel;
            barrelLeveLText.text = Localization.lvl + barrelLevel;
            mimicChestLeveLText.text = Localization.lvl + mimicChestLevel;

            #endregion

            #region item count

            knifeCountText.text = "" + knifeCount;
            treasurePotionCounText.text = "" + treasurePotionCount;
            knifeOwnedText.text = Localization.owned + knifeCount;
            treasurePotionOwnedText.text = Localization.owned + treasurePotionCount;
            if (knifeCount == 0)
            {
                knifeOwnedText.color = Color.red;
            }

            if (treasurePotionCount == 0)
            {
                treasurePotionOwnedText.color = Color.red;
            }
            if (treasurePotionCount > 0)
            {
                treasurePotionOwnedText.color = Color.green;
            }

            if (knifeBoughtFirstTime == 1)
            {
                if (knifeCount == 0)
                {
                     knifeCountText.color = Color.red;
                    knifeOwnedText.color = Color.red;
                }
                if (knifeCount > 0)
                {
                     knifeCountText.color = originalColor;
                     knifeOwnedText.color = Color.green;
                }
            }
           
            if(treasurePotionBoughtFirstTime == 1)
            {
                if (treasurePotionCount == 0)
                {
                    treasurePotionCounText.color = Color.red;
                     treasurePotionOwnedText.color = Color.red;
                }
                if (treasurePotionCount > 0)
                {
                    treasurePotionCounText.color = originalColor;
                     treasurePotionOwnedText.color = Color.green;
                }
            }

            #endregion

            #region item prices

            knifePriceText.text = TotalGoldAmount.FormatCoinsDoubleOneLetter(knifeBuyPriceDouble) + "";

            treasurePotionPriceText.text = TotalGoldAmount.FormatCoinsDoubleOneLetter(treasurePotionBuyPriceDouble) + "";

          

            if (Localization.EnglishLanguageChosen == 1)
            {
                if (barrelBoughtFirstTime == 0) { barrelPriceText.text = TotalGoldAmount.FormatCoinsDoubleOneLetter(barrelBuyPriceDouble) + ""; }
                if (barrelBoughtFirstTime == 1) { barrelPriceText.text = "<color=red>One Time Purchase"; }
            }
            if (Localization.RussianLanguageChosen == 1)
            {
                if (barrelBoughtFirstTime == 0) { barrelPriceText.text = "" + TotalGoldAmount.FormatCoinsDoubleOneLetter(barrelBuyPriceDouble) ; }
                if (barrelBoughtFirstTime == 1) { barrelPriceText.text = "<color=red>Одноразовая Покупка"; }
            }
            if (Localization.JapaneseLanguageChosen == 1)
            {
                if (barrelBoughtFirstTime == 0) { barrelPriceText.text = "" + TotalGoldAmount.FormatCoinsDoubleOneLetter(barrelBuyPriceDouble); }
                if (barrelBoughtFirstTime == 1) { barrelPriceText.text = "<color=red>一度の購入"; }
            }
            if (Localization.ChineseLanguageChosen == 1)
            {
                if (barrelBoughtFirstTime == 0) { barrelPriceText.text = TotalGoldAmount.FormatCoinsDoubleOneLetter(barrelBuyPriceDouble) + ""; }
                if (barrelBoughtFirstTime == 1) { barrelPriceText.text = "<color=red>一次性购买e"; }
            }
            if (Localization.KoreanLanguageChosen == 1)
            {
                if (barrelBoughtFirstTime == 0) { barrelPriceText.text = "" + TotalGoldAmount.FormatCoinsDoubleOneLetter(barrelBuyPriceDouble); }
                if (barrelBoughtFirstTime == 1) { barrelPriceText.text = "<color=red>1회성 결제"; }
            }

            mimicChestPriceText.text = TotalGoldAmount.FormatCoinsDoubleOneLetter(mimicChestBuyPriceDouble) + "";

            #endregion

            #region item gem prices
            //Gems prices
            knifeGemPriceText.text = "" + knifeGemPrice;
            knifeGemPriceText2.text = "" + knifeGemPrice2;

            treasurePotionGemPriceText.text = "" + treasurePotionGemPrice;
            treasurePotionGemPriceText2.text = "" + treasurePotionGemPrice2;

            barrelGemPriceText.text = "" + barrelGemPrice;

            if(mimicChestTimer <= 60)
            {
                mimicChestGemPriceText.text = "<color=red>" + Localization.MAX;
            }
            else
            {
                mimicChestGemPriceText.text = "" + mimicChestGemPrice;
            }
           

            #endregion

            #region hover
            knifeDropChanceText.text = HoverSpecialString.knifeDropChance;
            knifeBuffText.text = HoverSpecialString.knifeInfo;
            knifeHoverPriceText.text = HoverSpecialString.KnifePurhcase;

            treasurePotionDropChanceText.text = HoverSpecialString.treasurePotionDropChance;
            treasurePotionBuffText.text = HoverSpecialString.treasurePotionInfo;
            treasurePotionHoverPriceText.text = HoverSpecialString.treasurePotionPurchase;

            barrelBuffText.text = HoverSpecialString.barrelInfo;

            mimicChestBuffText.text = HoverSpecialString.mimicChestInfo;
            mimicChestHoverPriceText.text = HoverSpecialString.mimicChestPurchase;
            mimicChestTimerInfo.text = HoverSpecialString.mimicChestTimer;

            if(Localization.EnglishLanguageChosen == 1)
            {
                if (barrelBoughtFirstTime == 0) { barrelHoverPriceText.text = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(barrelBuyPriceDouble) + " Gold"; }
                if (barrelBoughtFirstTime == 1) { barrelHoverPriceText.text = "<color=red>One Time Purchase"; }
            }
            if (Localization.RussianLanguageChosen == 1)
            {
                if (barrelBoughtFirstTime == 0) { barrelHoverPriceText.text = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(barrelBuyPriceDouble) + " Золота"; }
                if (barrelBoughtFirstTime == 1) { barrelHoverPriceText.text = "<color=red>Одноразовая Покупка"; }
            }
            if (Localization.JapaneseLanguageChosen == 1)
            {
                if (barrelBoughtFirstTime == 0) { barrelHoverPriceText.text = "" + TotalGoldAmount.FormatCoinsDoubleOneLetter(barrelBuyPriceDouble) + "金のための購入"; }
                if (barrelBoughtFirstTime == 1) { barrelHoverPriceText.text = "<color=red>一度の購入"; }
            }
            if (Localization.ChineseLanguageChosen == 1)
            {
                if (barrelBoughtFirstTime == 0) { barrelHoverPriceText.text = "花费" + TotalGoldAmount.FormatCoinsDoubleOneLetter(barrelBuyPriceDouble) + " 千万金币购买"; }
                if (barrelBoughtFirstTime == 1) { barrelHoverPriceText.text = "<color=red>一次性购买e"; }
            }
            if (Localization.KoreanLanguageChosen == 1)
            {
                if (barrelBoughtFirstTime == 0) { barrelHoverPriceText.text = "" + TotalGoldAmount.FormatCoinsDoubleOneLetter(barrelBuyPriceDouble) + "경 골드로 구매하기"; }
                if (barrelBoughtFirstTime == 1) { barrelHoverPriceText.text = "<color=red>1회성 결제"; }
            }
           
            #endregion

            changeItemUpdate = false;
        }

        #region item prices color
       
            if (totalGoldHigher >= knifeBuyPriceDouble) {  knifePriceText.color = Color.green; }
            if (totalGoldHigher < knifeBuyPriceDouble) { knifePriceText.color = Color.red; }

            if (totalGoldHigher >= treasurePotionBuyPriceDouble) { treasurePotionPriceText.color = Color.green; }
            if (totalGoldHigher < treasurePotionBuyPriceDouble) { treasurePotionPriceText.color = Color.red; }

            if (totalGoldHigher >= barrelBuyPriceDouble) { barrelPriceText.color = Color.green; }
            if (totalGoldHigher < barrelBuyPriceDouble) { barrelPriceText.color = Color.red; }

            if (totalGoldHigher >= mimicChestBuyPriceDouble) { mimicChestPriceText.color = Color.green; }
            if (totalGoldHigher < mimicChestBuyPriceDouble) { mimicChestPriceText.color = Color.red; }
        
        #endregion

        #region item gem price color
        if (RareDropsCollected.chronolithShardCount < knifeGemPrice) { knifeGemPriceText.color = Color.red; }
        if (RareDropsCollected.chronolithShardCount >= knifeGemPrice) { knifeGemPriceText.color = Color.green; }

        if (RareDropsCollected.sideriumEssenceCount < knifeGemPrice2) { knifeGemPriceText2.color = Color.red; }
        if (RareDropsCollected.sideriumEssenceCount >= knifeGemPrice2) { knifeGemPriceText2.color = Color.green; }

        if (RareDropsCollected.astraliumCount < treasurePotionGemPrice) { treasurePotionGemPriceText.color = Color.red; }
        if (RareDropsCollected.astraliumCount >= treasurePotionGemPrice) { treasurePotionGemPriceText.color = Color.green; }

        if (RareDropsCollected.elysiumPrismCount < treasurePotionGemPrice2) { treasurePotionGemPriceText2.color = Color.red; }
        if (RareDropsCollected.elysiumPrismCount >= treasurePotionGemPrice2) { treasurePotionGemPriceText2.color = Color.green; }

        if (RareDropsCollected.RedGemCount < barrelGemPrice) { barrelGemPriceText.color = Color.red; }
        if (RareDropsCollected.RedGemCount >= barrelGemPrice) { barrelGemPriceText.color = Color.green; }

        if (RareDropsCollected.violetCrystalCount < mimicChestGemPrice) { mimicChestGemPriceText.color = Color.red; }
        if (RareDropsCollected.violetCrystalCount >= mimicChestGemPrice) { mimicChestGemPriceText.color = Color.green; }
        #endregion

        #region treasurePotionTextPopUp
        if (ReturnRedGem.setTreasurePotion == true)
        {
            GameObject itemsText = ObjectPooling.instance.GetGoldTextFromPool();
            itemsText.transform.SetParent(treasurePotionCountText.transform, false);
            itemsText.transform.position = treasurePotionCountText.transform.position;
            itemsText.transform.localScale = new Vector3(textSize, textSize, textSize);
            itemsText.GetComponent<Animation>().Play();
            if (ReturnRedGem.isItemDouble == true) { itemsText.GetComponent<TextMeshProUGUI>().text = "+2"; }
            if (ReturnRedGem.isItemDouble == false) { itemsText.GetComponent<TextMeshProUGUI>().text = "+1"; }

            StartCoroutine(ReturnTextFromPoolDelayed(itemsText, 0.7f));

            ReturnRedGem.setTreasurePotion = false;
        }
        #endregion

        #region knifeTextPopUp
        if (ReturnRedGem.setKnife == true)
        {
            GameObject itemsText = ObjectPooling.instance.GetGoldTextFromPool();
            itemsText.transform.SetParent(knifeCountText.transform, false);
            itemsText.transform.position = knifeCountText.transform.position;
            itemsText.transform.localScale = new Vector3(textSize, textSize, textSize);
            itemsText.GetComponent<Animation>().Play();
            if (ReturnRedGem.isItemDouble == true) { itemsText.GetComponent<TextMeshProUGUI>().text = "+2"; }
            if (ReturnRedGem.isItemDouble == false) { itemsText.GetComponent<TextMeshProUGUI>().text = "+1"; }

            StartCoroutine(ReturnTextFromPoolDelayed(itemsText, 0.7f));

            ReturnRedGem.setKnife = false;
        }
        #endregion

        #endregion

        //Mimic chest
        #region mimic chest rewards/debuffs

        //Buffs
        if (mimicChest.mimicGoodGold == true)
        {
            positiveGoldIcon.SetActive(true);
            StartCoroutine(mimicChestTextPopUp());
            if (goldBuffCoroutine != null) { StopCoroutine(goldBuffCoroutine); }
            goldBuffCoroutine = StartCoroutine(StartGoldBuff());
            mimicChest.mimicGoodGold = false;
        }
        if (mimicChest.mimicGoodDamage == true)
        {
            StartCoroutine(mimicChestTextPopUp());
            if (damageBuffCoroutine != null) { StopCoroutine(damageBuffCoroutine); }
            damageBuffCoroutine = StartCoroutine(StartDamageBuff());
            positiveDamageIcon.SetActive(true);
            mimicChest.mimicGoodDamage = false;
        }
        if (mimicChest.mimicPositiveXP == true)
        {
            StartCoroutine(mimicChestTextPopUp());
            if (XPBuffCoroutine != null) { StopCoroutine(XPBuffCoroutine); }
            XPBuffCoroutine = StartCoroutine(StartXPBuff());
            positiveXPIcon.SetActive(true);
            mimicChest.mimicPositiveXP = false;
        }
        if (mimicChest.mimicGoodTreasureDrop == true)
        {
            StartCoroutine(mimicChestTextPopUp());
            if (treasureDropBuffCoroutine != null) { StopCoroutine(treasureDropBuffCoroutine); }
            treasureDropBuffCoroutine = StartCoroutine(StartTreasureDropBuff());
            positiveTreasureIcon.SetActive(true);
            mimicChest.mimicGoodTreasureDrop = false;
        }
        if (mimicChest.mimicGoodGoldCoinDrop == true)
        {
            StartCoroutine(mimicChestTextPopUp());
            if (goldCoinDropBuffCoroutine != null) { StopCoroutine(goldCoinDropBuffCoroutine); }
            goldCoinDropBuffCoroutine = StartCoroutine(StartGoldCoinBuff());
            positiveCoinDropIcon.SetActive(true);
            mimicChest.mimicGoodGoldCoinDrop = false;
        }
        if (mimicChest.mimicGoodRareTreasureDrop == true)
        {
            StartCoroutine(mimicChestTextPopUp());
            if (rareTreasureDropCoroutine != null) { StopCoroutine(rareTreasureDropCoroutine); }
            rareTreasureDropCoroutine = StartCoroutine(StartRareTreasureBuff());
            rareTreasureBuffIcon.SetActive(true);
            mimicChest.mimicGoodRareTreasureDrop = false;
        }


        //Debuffs
        if (mimicChest.mimicEvilGold == true)
        {
            StartCoroutine(mimicChestTextPopUp());
            if (goldDebuffCoroutine != null) { StopCoroutine(goldDebuffCoroutine); }
            goldDebuffCoroutine = StartCoroutine(StartGoldDebuff());
            negativeGoldIcon.SetActive(true);
            mimicChest.mimicEvilGold = false;
        }
        if (mimicChest.mimicEvilDamage == true)
        {
            StartCoroutine(mimicChestTextPopUp());
            if (damageDebuffCoroutine != null) { StopCoroutine(damageDebuffCoroutine); }
            damageDebuffCoroutine = StartCoroutine(StartDamageDebuff());
            negativeDamageIcon.SetActive(true);
            mimicChest.mimicEvilDamage = false;
        }
        if (mimicChest.mimicEvilXP == true)
        {
            StartCoroutine(mimicChestTextPopUp());
            if (XPDebuffCoroutine != null) { StopCoroutine(XPDebuffCoroutine); }
            XPDebuffCoroutine = StartCoroutine(StartXPDebuff());
            negativeXPIcon.SetActive(true);
            mimicChest.mimicEvilXP = false;
        }
        if (mimicChest.mimicEvilTreasureDrop == true)
        {
            StartCoroutine(mimicChestTextPopUp());
            if (treasureDopDebuffCoroutine != null) { StopCoroutine(treasureDopDebuffCoroutine); }
            treasureDopDebuffCoroutine = StartCoroutine(StartTreasureDropDebuff());
            negativeTreasureIcon.SetActive(true);
            mimicChest.mimicEvilTreasureDrop = false;
        }
        if (mimicChest.mimicEvilGoldCoinDrop == true)
        {
            StartCoroutine(mimicChestTextPopUp());
            if (goldCoinDebuffCoroutine != null) { StopCoroutine(goldCoinDebuffCoroutine); }
            goldCoinDebuffCoroutine =  StartCoroutine(StartGoldCoinDebuff());
            negativeGoldCoinIcon.SetActive(true);
            mimicChest.mimicEvilGoldCoinDrop = false;
        }
        #endregion

    }

    private IEnumerator ReturnTextFromPoolDelayed(GameObject itemsText, float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        ObjectPooling.instance.ReturnGoldTextFromPool(itemsText);
    }

    #region new prestige upgrades

    #region reinforcedUpgrades
    public static int reinforcedUpgradesPurchasedStats;
    public Image[] reinforcedUpgrades = new Image[5];
    public GameObject[] reinforcedLocks = new GameObject[4];
    public GameObject[] reinforcedIcons = new GameObject[4];
    public static int reinforced1Price, reinforced2Price, reinforced3Price, reinforced4Price, reinforced5Price;
    public static int reinforced1Bought, reinforced2Bought, reinforced3Bought, reinforced4Bought, reinforced5Bought;
    public static float reinforcedPrestigeChanceIncrease;
    public static int reinforcedChestHealth;
    public static int reinforcedChestGoldIncrease, reinforcedXPIncrease;

    public void BuyReinforced1Upgrade()
    {
        if (SkillTree.isInSkillTree == true && PlayerLevel.skillPoints >= reinforced1Price)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.adventurereUpgradesPurchased += 1;

            reinforcedChestGoldIncrease = 17;
            reinforcedPrestigeChanceIncrease += 0.1f;

            PlayerLevel.skillPoints -= reinforced1Price;
            reinforced1Bought = 1;
            SetAlpha(reinforcedUpgrades[0], alphaValueFull);
            reinforcedLocks[0].SetActive(false); reinforcedIcons[0].SetActive(true);
            SomethingAllUpgradesDo();
            PrestigeUpgradeSounds();
        }
        else { CantAfford(); }
    }

    public void BuyReinforced2Upgrade()
    {
        if (SkillTree.isInSkillTree == true && PlayerLevel.skillPoints >= reinforced2Price && reinforced1Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.adventurereUpgradesPurchased += 1;

            reinforcedChestGoldIncrease = 24;
            reinforcedChestHealth = 9;
            reinforcedXPIncrease = 6;

            PlayerLevel.skillPoints -= reinforced2Price;
            reinforced2Bought = 1;
            SetAlpha(reinforcedUpgrades[1], alphaValueFull);
            reinforcedLocks[1].SetActive(false); reinforcedIcons[1].SetActive(true);
            SomethingAllUpgradesDo();
            PrestigeUpgradeSounds();
        }
        else { CantAfford(); }
    }

    public void BuyReinforced3Upgrade()
    {
        if (SkillTree.isInSkillTree == true && PlayerLevel.skillPoints >= reinforced3Price && reinforced2Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.adventurereUpgradesPurchased += 1;

            reinforcedChestGoldIncrease = 33;
            reinforcedPrestigeChanceIncrease += 0.3f;

            PlayerLevel.skillPoints -= reinforced3Price;
            reinforced3Bought = 1;
            SetAlpha(reinforcedUpgrades[2], alphaValueFull);
            reinforcedLocks[2].SetActive(false); reinforcedIcons[2].SetActive(true);
            SomethingAllUpgradesDo();
            PrestigeUpgradeSounds();
        }
        else { CantAfford(); }
    }

    public void BuyReinforced4Upgrade()
    {
        if (SkillTree.isInSkillTree == true && PlayerLevel.skillPoints >= reinforced4Price && reinforced3Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.adventurereUpgradesPurchased += 1;

            reinforcedChestGoldIncrease = 47;
            reinforcedChestHealth = 8;
            reinforcedPrestigeChanceIncrease += 0.5f;
            reinforcedXPIncrease = 11;

            PlayerLevel.skillPoints -= reinforced4Price;
            reinforced4Bought = 1;
            SetAlpha(reinforcedUpgrades[3], alphaValueFull);
            reinforcedLocks[3].SetActive(false); reinforcedIcons[3].SetActive(true);
            SomethingAllUpgradesDo();
            PrestigeUpgradeSounds();
        }
        else { CantAfford(); }
    }

    public void BuyReinforced5Upgrade()
    {
        if (SkillTree.isInSkillTree == true && PlayerLevel.skillPoints >= reinforced5Price && reinforced4Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.adventurereUpgradesPurchased += 1;

            reinforcedChestGoldIncrease = 85;
            reinforcedPrestigeChanceIncrease += 1f;

            PlayerLevel.skillPoints -= reinforced5Price;
            reinforced5Bought = 1;
            SetAlpha(reinforcedUpgrades[4], alphaValueFull);
            SomethingAllUpgradesDo();
            PrestigeUpgradeSounds();
        }
        else { CantAfford(); }
    }



    #endregion

    #region greater loot upgrades
    public static int greaterLootUpgradesPurchasedStats;
    public Image[] greaterLootUpgrades = new Image[5];
    public GameObject[] greaterLootLocks = new GameObject[4];
    public GameObject[] greaterLootIcons = new GameObject[4];
    public static int greaterLoot1Price, greaterLoot2Price, greaterLoot3Price, greaterLoot4Price, greaterLoot5Price;
    public static int greaterLoot1Bought, greaterLoot2Bought, greaterLoot3Bought, greaterLoot4Bought, greaterLoot5Bought;

    public void BuyGreaterLoot1Upgrade()
    {
        if (SkillTree.isInSkillTree == true && PlayerLevel.skillPoints >= greaterLoot1Price )
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.adventurereUpgradesPurchased += 1;

            PlayerLevel.skillPoints -= greaterLoot1Price;
            greaterLoot1Bought = 1;
            SetAlpha(greaterLootUpgrades[0], alphaValueFull);
            greaterLootLocks[0].SetActive(false); greaterLootIcons[0].SetActive(true);
            SomethingAllUpgradesDo();
            PrestigeUpgradeSounds();
        }
        else { CantAfford(); }
    }

    public void BuyGreaterLoot2Upgrade()
    {
        if (SkillTree.isInSkillTree == true && PlayerLevel.skillPoints >= greaterLoot2Price && greaterLoot1Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.adventurereUpgradesPurchased += 1;

            PlayerLevel.skillPoints -= greaterLoot2Price;
            greaterLoot2Bought = 1;
            SetAlpha(greaterLootUpgrades[1], alphaValueFull);
            greaterLootLocks[1].SetActive(false); greaterLootIcons[1].SetActive(true);
            SomethingAllUpgradesDo();
            PrestigeUpgradeSounds();
        }
        else { CantAfford(); }
    }

    public void BuyGreaterLoot3Upgrade()
    {
        if (SkillTree.isInSkillTree == true && PlayerLevel.skillPoints >= greaterLoot3Price && greaterLoot2Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.adventurereUpgradesPurchased += 1;

            PlayerLevel.skillPoints -= greaterLoot3Price;
            greaterLoot3Bought = 1;
            SetAlpha(greaterLootUpgrades[2], alphaValueFull);
            greaterLootLocks[2].SetActive(false); greaterLootIcons[2].SetActive(true);
            SomethingAllUpgradesDo();
            PrestigeUpgradeSounds();
        }
        else { CantAfford(); }
    }

    public void BuyGreaterLoot4Upgrade()
    {
        if (SkillTree.isInSkillTree == true && PlayerLevel.skillPoints >= greaterLoot4Price && greaterLoot3Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.adventurereUpgradesPurchased += 1;

            PlayerLevel.skillPoints -= greaterLoot4Price;
            greaterLoot4Bought = 1;
            SetAlpha(greaterLootUpgrades[3], alphaValueFull);
            greaterLootLocks[3].SetActive(false); greaterLootIcons[3].SetActive(true);
            SomethingAllUpgradesDo();
            PrestigeUpgradeSounds();
        }
        else { CantAfford(); }
    }

    public void BuyGreaterLoot5Upgrade()
    {
        if (SkillTree.isInSkillTree == true && PlayerLevel.skillPoints >= greaterLoot5Price && greaterLoot4Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.adventurereUpgradesPurchased += 1;

            PlayerLevel.skillPoints -= greaterLoot5Price;
            greaterLoot5Bought = 1;
            SetAlpha(greaterLootUpgrades[4], alphaValueFull);
            SomethingAllUpgradesDo();
            PrestigeUpgradeSounds();
        }
        else { CantAfford(); }
    }

    #endregion

    #region new chests upgrades
    public static int newChestsUpgradesPurchasedStats;
    public Image[] newChestsUpgrades = new Image[6];
    public GameObject[] newChestsLocks = new GameObject[5];
    public GameObject[] newChestsIcons = new GameObject[5];
    public static int newChests1Price, newChests2Price, newChests3Price, newChests4Price, newChests5Price, newChests6Price;
    public static int newChests1Bought, newChests2Bought, newChests3Bought, newChests4Bought, newChests5Bought, newChests6Bought;
    public static float enchantedGoldenChestChance, bossChestChance;
    public static int enchantedGoldenChestHealth, bossChestHealth;
    public static int bossChestGoldAmount;
    public static int enchantedGoldenChestTreasureDrops, bossChestGoldCoinsDrops, bossChestGoldValue;
    public static int enchantedGoldenChestXPDrops, bossChestXPDrops;

    public void BuyNewChests1Upgrade()
    {
        if (SkillTree.isInSkillTree == true && PlayerLevel.skillPoints >= newChests1Price)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.adventurereUpgradesPurchased += 1;

            enchantedGoldenChestChance = 99.8f;
            enchantedGoldenChestHealth = 35;
            enchantedGoldenChestTreasureDrops = 20;
            enchantedGoldenChestXPDrops = 6;

            PlayerLevel.skillPoints -= newChests1Price;
            newChests1Bought = 1;
            SetAlpha(newChestsUpgrades[0], alphaValueFull);
            newChestsLocks[0].SetActive(false); newChestsIcons[0].SetActive(true);
            SomethingAllUpgradesDo();
            PrestigeUpgradeSounds();
        }
        else { CantAfford(); }
    }

    public void BuyNewChests2Upgrade()
    {
        if (SkillTree.isInSkillTree == true && PlayerLevel.skillPoints >= newChests2Price && newChests1Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.adventurereUpgradesPurchased += 1;

            bossChestChance = 0.1f;
            bossChestHealth = 100;
            bossChestGoldValue = 5;
            bossChestGoldCoinsDrops = 25;
            bossChestXPDrops = 15;

            PlayerLevel.skillPoints -= newChests2Price;
            newChests2Bought = 1;
            SetAlpha(newChestsUpgrades[1], alphaValueFull);
            newChestsLocks[1].SetActive(false); newChestsIcons[1].SetActive(true);
            SomethingAllUpgradesDo();
            PrestigeUpgradeSounds();
        }
        else { CantAfford(); }
    }

    public void BuyNewChests3Upgrade()
    {
        if (SkillTree.isInSkillTree == true && PlayerLevel.skillPoints >= newChests3Price && newChests2Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.adventurereUpgradesPurchased += 1;

            enchantedGoldenChestChance -= 0.1f;
            bossChestChance += 0.05f;

            PlayerLevel.skillPoints -= newChests3Price;
            newChests3Bought = 1;
            SetAlpha(newChestsUpgrades[2], alphaValueFull);
            newChestsLocks[2].SetActive(false); newChestsIcons[2].SetActive(true);
            SomethingAllUpgradesDo();
            PrestigeUpgradeSounds();
        }
        else { CantAfford(); }
    }

    public void BuyNewChests4Upgrade()
    {
        if (SkillTree.isInSkillTree == true && PlayerLevel.skillPoints >= newChests4Price && newChests3Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.adventurereUpgradesPurchased += 1;

            enchantedGoldenChestChance -= 0.15f;
            bossChestChance += 0.1f;

            enchantedGoldenChestTreasureDrops = 25;
            bossChestGoldCoinsDrops = 30;

            PlayerLevel.skillPoints -= newChests4Price;
            newChests4Bought = 1;
            SetAlpha(newChestsUpgrades[3], alphaValueFull);
            newChestsLocks[3].SetActive(false); newChestsIcons[3].SetActive(true);
            SomethingAllUpgradesDo();
            PrestigeUpgradeSounds();
        }
        else { CantAfford(); }
    }

    public void BuyNewChests5Upgrade()
    {
        if (SkillTree.isInSkillTree == true && PlayerLevel.skillPoints >= newChests5Price && newChests4Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.adventurereUpgradesPurchased += 1;

            enchantedGoldenChestChance -= 0.2f;
            bossChestChance += 0.15f;

            enchantedGoldenChestTreasureDrops = 30;
            bossChestGoldCoinsDrops = 35;

            bossChestXPDrops = 20;
            enchantedGoldenChestXPDrops = 12;

            PlayerLevel.skillPoints -= newChests5Price;
            newChests5Bought = 1;
            SetAlpha(newChestsUpgrades[4], alphaValueFull);
            newChestsLocks[4].SetActive(false); newChestsIcons[4].SetActive(true);
            SomethingAllUpgradesDo();
            PrestigeUpgradeSounds();
        }
        else { CantAfford(); }
    }

    public void BuyNewChests6Upgrade()
    {
        if (SkillTree.isInSkillTree == true && PlayerLevel.skillPoints >= newChests6Price && newChests5Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.adventurereUpgradesPurchased += 1;

            enchantedGoldenChestChance -= 0.75f;
            bossChestChance += 0.4f;

            enchantedGoldenChestTreasureDrops = 30;
            bossChestGoldCoinsDrops = 35;

            PlayerLevel.skillPoints -= newChests6Price;
            newChests6Bought = 1;
            SetAlpha(newChestsUpgrades[5], alphaValueFull);
            SomethingAllUpgradesDo();
            PrestigeUpgradeSounds();
        }
        else { CantAfford(); }
    }

    #endregion



    #region somethingalltreasuresdo
    public string basicHexValue = "FFFFFF";
    public string adventurerHexValue = "FFB76C";
    public Button[] reinforcedButtons = new Button[5];
    public Button[] greaterLootButtons = new Button[5];
    public Button[] newChestsButtons = new Button[6];

    public void SomethingAllUpgradesDo()
    {
        Color newColorAdventurer;
        ColorUtility.TryParseHtmlString(adventurerHexValue, out newColorAdventurer);

        #region reinforcedUpgrades
        if (reinforced1Bought == 1) { reinforcedButtons[0].interactable = false; SetAlpha(reinforcedUpgrades[0], alphaValueFull); reinforcedUpgrades[0].GetComponent<Image>().color = newColorAdventurer; reinforcedUnlocked[0].SetActive(true); reinforcedLocks[0].SetActive(false); reinforcedIcons[0].SetActive(true); }
        if (reinforced2Bought == 1) { reinforcedButtons[1].interactable = false; SetAlpha(reinforcedUpgrades[1], alphaValueFull); reinforcedUpgrades[1].GetComponent<Image>().color = newColorAdventurer; reinforcedUnlocked[1].SetActive(true); reinforcedLocks[1].SetActive(false); reinforcedIcons[1].SetActive(true); }
        if (reinforced3Bought == 1) { reinforcedButtons[2].interactable = false; SetAlpha(reinforcedUpgrades[2], alphaValueFull); reinforcedUpgrades[2].GetComponent<Image>().color = newColorAdventurer; reinforcedUnlocked[2].SetActive(true); reinforcedLocks[2].SetActive(false); reinforcedIcons[2].SetActive(true); }
        if (reinforced4Bought == 1) { reinforcedButtons[3].interactable = false; SetAlpha(reinforcedUpgrades[3], alphaValueFull); reinforcedUpgrades[3].GetComponent<Image>().color = newColorAdventurer; reinforcedUnlocked[3].SetActive(true); reinforcedLocks[3].SetActive(false); reinforcedIcons[3].SetActive(true); }
        if (reinforced5Bought == 1) { reinforcedButtons[4].interactable = false; SetAlpha(reinforcedUpgrades[4], alphaValueFull); reinforcedUpgrades[4].GetComponent<Image>().color = newColorAdventurer; reinforcedUnlocked[4].SetActive(true); }
        #endregion

        #region greaterLootUpgrades
        if (greaterLoot1Bought == 1) { greaterLootButtons[0].interactable = false; SetAlpha(greaterLootUpgrades[0], alphaValueFull); greaterLootUpgrades[0].GetComponent<Image>().color = newColorAdventurer; greaterLootUnlocked[0].SetActive(true); greaterLootLocks[0].SetActive(false); greaterLootIcons[0].SetActive(true); }
        if (greaterLoot2Bought == 1) { greaterLootButtons[1].interactable = false; SetAlpha(greaterLootUpgrades[1], alphaValueFull); greaterLootUpgrades[1].GetComponent<Image>().color = newColorAdventurer; greaterLootUnlocked[1].SetActive(true); greaterLootLocks[1].SetActive(false); greaterLootIcons[1].SetActive(true); }
        if (greaterLoot3Bought == 1) { greaterLootButtons[2].interactable = false; SetAlpha(greaterLootUpgrades[2], alphaValueFull); greaterLootUpgrades[2].GetComponent<Image>().color = newColorAdventurer; greaterLootUnlocked[2].SetActive(true); greaterLootLocks[2].SetActive(false); greaterLootIcons[2].SetActive(true); }
        if (greaterLoot4Bought == 1) { greaterLootButtons[3].interactable = false; SetAlpha(greaterLootUpgrades[3], alphaValueFull); greaterLootUpgrades[3].GetComponent<Image>().color = newColorAdventurer; greaterLootUnlocked[3].SetActive(true); greaterLootLocks[3].SetActive(false); greaterLootIcons[3].SetActive(true); }
        if (greaterLoot5Bought == 1) { greaterLootButtons[4].interactable = false; SetAlpha(greaterLootUpgrades[4], alphaValueFull); greaterLootUpgrades[4].GetComponent<Image>().color = newColorAdventurer; greaterLootUnlocked[4].SetActive(true); }
        #endregion

        #region newChestsUpgrades
        if (newChests1Bought == 1) { newChestsButtons[0].interactable = false; SetAlpha(newChestsUpgrades[0], alphaValueFull); newChestsUpgrades[0].GetComponent<Image>().color = newColorAdventurer; newChestsUnlocked[0].SetActive(true); newChestsLocks[0].SetActive(false); newChestsIcons[0].SetActive(true); }
        if (newChests2Bought == 1) { newChestsButtons[1].interactable = false; SetAlpha(newChestsUpgrades[1], alphaValueFull); newChestsUpgrades[1].GetComponent<Image>().color = newColorAdventurer; newChestsUnlocked[1].SetActive(true); newChestsLocks[1].SetActive(false); newChestsIcons[1].SetActive(true); }
        if (newChests3Bought == 1) { newChestsButtons[2].interactable = false; SetAlpha(newChestsUpgrades[2], alphaValueFull); newChestsUpgrades[2].GetComponent<Image>().color = newColorAdventurer; newChestsUnlocked[2].SetActive(true); newChestsLocks[2].SetActive(false); newChestsIcons[2].SetActive(true); }
        if (newChests4Bought == 1) { newChestsButtons[3].interactable = false; SetAlpha(newChestsUpgrades[3], alphaValueFull); newChestsUpgrades[3].GetComponent<Image>().color = newColorAdventurer; newChestsUnlocked[3].SetActive(true); newChestsLocks[3].SetActive(false); newChestsIcons[3].SetActive(true); }
        if (newChests5Bought == 1) { newChestsButtons[4].interactable = false; SetAlpha(newChestsUpgrades[4], alphaValueFull); newChestsUpgrades[4].GetComponent<Image>().color = newColorAdventurer; newChestsUnlocked[4].SetActive(true); newChestsLocks[4].SetActive(false); newChestsIcons[4].SetActive(true); }
        if (newChests6Bought == 1) { newChestsButtons[5].interactable = false; SetAlpha(newChestsUpgrades[5], alphaValueFull); newChestsUpgrades[5].GetComponent<Image>().color = newColorAdventurer; newChestsUnlocked[5].SetActive(true);  }
        #endregion


        if (Stats.prestigeUpgradesPurchased >= 89)
        {
            RareTreasureButton.interactable = true;
            treasureHoverUnlocked.SetActive(true);
            treasureHoverNotUnlocked.SetActive(false);
            treasureButtonLockIcon.SetActive(false);
            treasureButtonPriceText.SetActive(true);

            if (RareTreasures.allTreasuresFound == true)
            {
                RareTreasureButton.interactable = false;
                treasureHoverUnlocked.SetActive(false);
                treasureHoverNotUnlocked.SetActive(false);
                treasureButtonLockIcon.SetActive(false);
                treasureButtonPriceText.SetActive(false);

                hudredPercentText.SetActive(true);
                allTreasuresHover.SetActive(true);
            }
        }

        #region Mobile set buttons back to enable
        if (PlaceMobileButtons.isMobile == true)
        {
            for (int i = 0; i < reinforcedButtons.Length; i++)
            {
                reinforcedButtons[i].interactable = true;
            }

            for (int i = 0; i < greaterLootButtons.Length; i++)
            {
                greaterLootButtons[i].interactable = true;
            }

            for (int i = 0; i < newChestsButtons.Length; i++)
            {
                newChestsButtons[i].interactable = true;
            }

            mobileScript.ClosePrestigeFrame();
        }
        #endregion

        SetInfoText();
        CheckPriceTextColor();
    }

    public Button RareTreasureButton;
    public GameObject treasureHoverUnlocked, treasureHoverNotUnlocked, treasureButtonLockIcon, treasureButtonPriceText, hudredPercentText, allTreasuresHover;
    #endregion

    #region new chests info
    public TextMeshProUGUI reinforcedChestInfoText, enchantedGoldenChestInfoText, bossChestInfoText;
    public TextMeshProUGUI enchantedHoverHEALTH, enchantedHoverTREASURES, enchantedHoverXP;
    public TextMeshProUGUI bossChestHoverHEALTH, bossChestHoverGoldCoinValue, bossChestHoverGoldCoinDrop, bossChestHoverXP;

    public void SetInfoText()
    {
        #region Hover English
        if (Localization.EnglishLanguageChosen == 1)
        {
            //Reinforced hover
            reinforcedChestHealthHover.text = "-Reinforced chests have <color=red>" + UpdateGame.reinforcedChestHealth + "X health";
            reinforcedChestGoldHover.text = "-Gold coins dropped give <color=yellow>" + UpdateGame.reinforcedChestGoldIncrease + "X gold";
            reinforcedChestXPHover.text = "<color=orange>+" + UpdateGame.reinforcedXPIncrease + "X XP <color=white>Drop";

            //Hover enchanted chest
            enchantedHoverHEALTH.text = "-Enchanted golden chest have <color=red>" + UpdateGame.enchantedGoldenChestHealth + "X health";
            enchantedHoverTREASURES.text = "-" + UpdateGame.enchantedGoldenChestTreasureDrops + " Treasure drops";
            enchantedHoverXP.text = "-<color=orange>+" + UpdateGame.enchantedGoldenChestXPDrops + "X XP Drop";

            //Hover boss chest
            bossChestHoverHEALTH.text = "-Boss chests have <color=red>" + UpdateGame.bossChestHealth + "X health";
            bossChestHoverGoldCoinValue.text = "-Gold coin value = <color=yellow>" + UpdateGame.bossChestGoldValue + "X gold";
            bossChestHoverGoldCoinDrop.text = "-<color=yellow>" + UpdateGame.bossChestGoldCoinsDrops + " Gold coins<color=white> will drop, all which are <color=yellow>10X and 25X gold coins.";
            if (newChests5Bought == 1)
            {
                bossChestHoverGoldCoinDrop.text = "-<color=yellow>" + UpdateGame.bossChestGoldCoinsDrops + " Gold coins<color=white> will drop, all which are<color=yellow> 25X gold coins.";
            }
            bossChestHoverXP.text = "-<color=orange>+" + UpdateGame.bossChestXPDrops + "X XP Drop";
        }
        #endregion

        #region Hover Russian
        if (Localization.RussianLanguageChosen == 1)
        {
            //Reinforced hover
            reinforcedChestHealthHover.text = "-У укреплённых сундуков здоровье в" + UpdateGame.reinforcedChestHealth + "X";
            reinforcedChestGoldHover.text = "-Выпавшие золотые монеты дают" + UpdateGame.reinforcedChestGoldIncrease + "X Золота";
            reinforcedChestXPHover.text = "+" + UpdateGame.reinforcedXPIncrease + "X Выпадение ОП";

            //Hover enchanted chest
            enchantedHoverHEALTH.text = "-У зачарованных золотых сундуков здоровье в" + UpdateGame.enchantedGoldenChestHealth + "X";
            enchantedHoverTREASURES.text = "-Выпадение" + UpdateGame.enchantedGoldenChestTreasureDrops + " Сокровищ";
            enchantedHoverXP.text = "-+" + UpdateGame.enchantedGoldenChestXPDrops + "X Выпадение ОП";

            //Hover boss chest
            bossChestHoverHEALTH.text = "-У сундуков босса здоровье в " + UpdateGame.bossChestHealth + "X";
            bossChestHoverGoldCoinValue.text = "-Ценность золотой монеты = " + UpdateGame.bossChestGoldValue + "X Золота";
            bossChestHoverGoldCoinDrop.text = "-Выпадет" + UpdateGame.bossChestGoldCoinsDrops + " золотых монет, все из которых – 10X и 25X золотые монеты";
            if (newChests5Bought == 1)
            {
                bossChestHoverGoldCoinDrop.text = "-Выпадет" + UpdateGame.bossChestGoldCoinsDrops + " золотых монет, все из которых – 25X золотые монеты";
            }
            bossChestHoverXP.text = "-+" + UpdateGame.bossChestXPDrops + "X Выпадение ОП";
        }
        #endregion

        #region Hover Japanese 
        if (Localization.JapaneseLanguageChosen == 1)
        {
            //Reinforced hover
            reinforcedChestHealthHover.text = "強化されたチェストは" + UpdateGame.reinforcedChestHealth + "倍の健康を持っています";
            reinforcedChestGoldHover.text = "ドロップされた金貨は" + UpdateGame.reinforcedChestGoldIncrease + "倍の金を与えます";
            reinforcedChestXPHover.text  = "+" + UpdateGame.reinforcedXPIncrease + "XXPドロップ";

            //Hover enchanted chest
            enchantedHoverHEALTH.text = "エンチャントされた黄金の宝箱は" + UpdateGame.enchantedGoldenChestHealth + "倍の健康を持っています";
            enchantedHoverTREASURES.text = "-" + UpdateGame.enchantedGoldenChestTreasureDrops + "宝の雫";
            enchantedHoverXP.text = "+" + UpdateGame.enchantedGoldenChestXPDrops + "Xドロップ";

            //Hover boss chest
            bossChestHoverHEALTH.text = "ボスチェストは" + UpdateGame.bossChestHealth + "倍の健康を持っています";
            bossChestHoverGoldCoinValue.text = "ゴールドコイン値=" + UpdateGame.bossChestGoldValue + "ゴールド";
            bossChestHoverGoldCoinDrop.text = "" + UpdateGame.bossChestGoldCoinsDrops + "金貨は、10Xと25X金貨であるすべて、ドロップされます";
            if (newChests5Bought == 1)
            {
                bossChestHoverGoldCoinDrop.text = "" + UpdateGame.bossChestGoldCoinsDrops + "金貨は25X金貨であるすべて、ドロップされます";
            }
            bossChestHoverXP.text = "+" + UpdateGame.bossChestXPDrops + "XXPドロップ";
        }
        #endregion

        #region Hover Chinese
        if (Localization.ChineseLanguageChosen == 1)
        {
            //Reinforced hover
            reinforcedChestHealthHover.text = "-强化宝箱有 <color=red>" + UpdateGame.reinforcedChestHealth + "倍的生命值";
            reinforcedChestGoldHover.text = "-金币掉落可获得<color=yellow>" + UpdateGame.reinforcedChestGoldIncrease + "倍的金币";
            reinforcedChestXPHover.text = "<color=orange>+" + UpdateGame.reinforcedXPIncrease + "倍经验掉落";

            //Hover enchanted chest
            enchantedHoverHEALTH.text = "-强化黄金宝箱有 <color=red>" + UpdateGame.enchantedGoldenChestHealth + " 倍的生命值";
            enchantedHoverTREASURES.text = "-掉落" + UpdateGame.enchantedGoldenChestTreasureDrops + " 个宝物";
            enchantedHoverXP.text = "-<color=orange>+" + UpdateGame.enchantedGoldenChestXPDrops + "倍经验掉落";

            //Hover boss chest
            bossChestHoverHEALTH.text = "-首领宝箱有  <color=red>" + UpdateGame.bossChestHealth + "倍的生命值";
            bossChestHoverGoldCoinValue.text = "-金币价值 =  <color=yellow>" + UpdateGame.bossChestGoldValue + "倍金币";
            bossChestHoverGoldCoinDrop.text = "-会掉落" + UpdateGame.bossChestGoldCoinsDrops + " 枚金币，全部为 10X 和 25X 金币";
            if (newChests5Bought == 1)
            {
                bossChestHoverGoldCoinDrop.text = "-<color=yellow>会掉落" + UpdateGame.bossChestGoldCoinsDrops + " 枚金币，全部为 25X 金币.";
            }
            bossChestHoverXP.text = "-<color=orange>+" + UpdateGame.bossChestXPDrops + "倍经验掉落";
        }
        #endregion

        #region Hover Korean
        if (Localization.KoreanLanguageChosen == 1)
        {
            //Reinforced hover
            reinforcedChestHealthHover.text = "-강화 상자는 " + UpdateGame.reinforcedChestHealth + "HP를 가지고 있습니다";
            reinforcedChestGoldHover.text = "-드롭된 골드 코인은<color=yellow>" + UpdateGame.reinforcedChestGoldIncrease + "X 골드를 줍니다";
            reinforcedChestXPHover.text = "+" + UpdateGame.reinforcedXPIncrease + "X XP 드롭";

            //Hover enchanted chest
            enchantedHoverHEALTH.text = "-마법에 걸린 황금 상자는 " + UpdateGame.enchantedGoldenChestHealth + "를 가지고 있습니다";
            enchantedHoverTREASURES.text = "-" + UpdateGame.enchantedGoldenChestTreasureDrops + "개의 보물 드롭";
            enchantedHoverXP.text = "-+" + UpdateGame.enchantedGoldenChestXPDrops + "X XP 드롭";

            //Hover boss chest
            bossChestHoverHEALTH.text = "-보스 상자는" + UpdateGame.bossChestHealth + "HP를 갖고 있습니다";
            bossChestHoverGoldCoinValue.text = "-골드 코인 가치 " + UpdateGame.bossChestGoldValue + "X 골드";
            bossChestHoverGoldCoinDrop.text = "-" + UpdateGame.bossChestGoldCoinsDrops + " 25 골드 코인이 드롭될 것입니다. 코인은 모두 10X와 25X 골드 코인입니다";
            if (newChests5Bought == 1)
            {
                bossChestHoverGoldCoinDrop.text = "-" + UpdateGame.bossChestGoldCoinsDrops + " 25 골드 코인이 드롭될 것입니다. 코인은 모두 25X 골드 코인입니다";
            }
            bossChestHoverXP.text = "+" + UpdateGame.bossChestXPDrops + "X XP 드롭";
        }
        #endregion



        if (newChests1Bought != 1)
        {
            enchantedGoldenChestInfoText.text = Localization.purchaseTheEnchanted;
        }
        if (newChests2Bought != 1)
        {
            bossChestInfoText.text = Localization.purchaseTheBossChest;
        }



        #region Info English
        if (Localization.EnglishLanguageChosen == 1)
        {
            reinforcedChestInfoText.text = "Reinforced chests have " + UpdateGame.reinforcedChestHealth + "X health, give " + UpdateGame.reinforcedChestGoldIncrease + "X gold and " + UpdateGame.reinforcedXPIncrease + "X XP.";

            if (newChests1Bought == 1)
            {
                enchantedGoldenChestInfoText.text = (100 - UpdateGame.enchantedGoldenChestChance).ToString("F2") + "% Spawn chance. \nEnchanted golden chests have " + UpdateGame.enchantedGoldenChestHealth + "X health, drops " + UpdateGame.enchantedGoldenChestTreasureDrops + " treasures and " + UpdateGame.enchantedGoldenChestXPDrops + "X XP.\n Using a lockpick or key only removes 33% of the chest health. \nEnchanted golden chests also have a slightly higher chance to drop a rare treasure";
            }

            if (newChests2Bought == 1)
            {
                bossChestInfoText.text = (UpdateGame.bossChestChance).ToString("F2") + "% Spawn chance.\nBoss chests have " + UpdateGame.bossChestHealth + "X health. Gold coins are worth " + UpdateGame.bossChestGoldValue + "X gold. Boss chests drops " + UpdateGame.bossChestGoldCoinsDrops + " gold coins, all which are 10X or 25X gold coins. (Gold coin value from boss chest = (Current chest gold coin value * 5) * 10 or 25). Also gives " + UpdateGame.bossChestXPDrops + "X XP.\nUsing a lock pick or key only removes 25% of the chest health. \nBoss chest also have a slightly higher chance to drop a rare treasure.";
            }

            if (newChests5Bought == 1)
            {
                bossChestInfoText.text = (UpdateGame.bossChestChance).ToString("F2") + "% Spawn chance.\nBoss chests have " + UpdateGame.bossChestHealth + "X health. Gold coins are worth " + UpdateGame.bossChestGoldValue + "X gold. Boss chests drops " + UpdateGame.bossChestGoldCoinsDrops + " gold coins, all which are 25X gold coins. (Gold coin value from boss chest = (Current chest gold coin value * 5) * 25). Also gives " + UpdateGame.bossChestXPDrops + "X XP.\nUsing a lock pick or key only removes 25% of the chest health. \nBoss chest also have a slightly higher chance to drop a rare treasure.";
            }
        }
        #endregion

        #region Info Russian
        if (Localization.RussianLanguageChosen == 1)
        {
            reinforcedChestInfoText.text = "Усиленные сундуки имеют " + UpdateGame.reinforcedChestHealth + "X здоровья, дают " + UpdateGame.reinforcedChestGoldIncrease + "X золота и " + UpdateGame.reinforcedXPIncrease + "X опыта.";

            if (newChests1Bought == 1)
            {
                enchantedGoldenChestInfoText.text = (100 - UpdateGame.enchantedGoldenChestChance).ToString("F2") + "% Шанс появления. \nЗачарованные золотые сундуки имеют " + UpdateGame.enchantedGoldenChestHealth + "X здоровья, дают " + UpdateGame.enchantedGoldenChestTreasureDrops + " сокровищ и " + UpdateGame.enchantedGoldenChestXPDrops + "X опыта.\n Использование отмычки или ключа убирает только 33% здоровья сундука.\nУ зачарованных золотых сундуков также немного выше шанс выпадения редкого сокровища.";
            }

            if (newChests2Bought == 1)
            {
                bossChestInfoText.text = (UpdateGame.bossChestChance).ToString("F2") + "% SШанс появления.\nСундуки боссов имеют " + UpdateGame.bossChestHealth + "X здоровья. Золотые монеты стоят " + UpdateGame.bossChestGoldValue + "X. Сундук босса даёт " + UpdateGame.bossChestGoldCoinsDrops + " золотых монет, каждая из которых стоит 10X или 25X золотых монет. (Значение золотой монеты из сундука босса = (Текущее значение золотой монеты сундука * 5) * 10 или 25) Также даёт " + UpdateGame.bossChestXPDrops + "X опыта.\nИспользование отмычки или ключа убирает только 25% здоровья сундука.\nУ сундуков боссов также немного выше шанс выпадения редкого сокровища.";
            }

            if (newChests5Bought == 1)
            {
                bossChestInfoText.text = (UpdateGame.bossChestChance).ToString("F2") + "% SШанс появления.\nСундуки боссов имеют " + UpdateGame.bossChestHealth + "X здоровья. Золотые монеты стоят " + UpdateGame.bossChestGoldValue + "X. Сундук босса даёт " + UpdateGame.bossChestGoldCoinsDrops + " золотых монет, каждая из которых стоит 25X золотых монет. (Значение золотой монеты из сундука босса = (Текущее значение золотой монеты сундука * 5) * 25) Также даёт " + UpdateGame.bossChestXPDrops + "X опыта.\nИспользование отмычки или ключа убирает только 25% здоровья сундука.\nУ сундуков боссов также немного выше шанс выпадения редкого сокровища.";
            }
        }
        #endregion

        #region Info Japanese 
        if (Localization.JapaneseLanguageChosen == 1)
        {
            reinforcedChestInfoText.text = "強化されたチェストは" + UpdateGame.reinforcedChestHealth + "倍のヘルスを持ち、" + UpdateGame.reinforcedChestGoldIncrease + "倍のゴールドと" + UpdateGame.reinforcedXPIncrease + "倍のXPを与えます。";

            if (newChests1Bought == 1)
            {
                enchantedGoldenChestInfoText.text = (100 - UpdateGame.enchantedGoldenChestChance).ToString("F2") + "%スポーンのチャンス\nエンチャントされた黄金の宝箱は、 " + UpdateGame.enchantedGoldenChestHealth + "倍の健康を持っている" + UpdateGame.enchantedGoldenChestTreasureDrops + "宝物と" + UpdateGame.enchantedGoldenChestXPDrops + "倍のXPをドロップします.\nロックピックまたはキーを使用すると、胸の健康状態の33％しか削除されません\nエンチャントされた黄金の宝箱はまた、珍しい宝を落とす可能性がわずかに高くなります。";
            }

            if (newChests2Bought == 1)
            {
                bossChestInfoText.text = (UpdateGame.bossChestChance).ToString("F2") + "%スポーンのチャンス\nボスチェストは" + UpdateGame.bossChestHealth + "倍の健康を持っています。金貨は" + UpdateGame.bossChestGoldValue + "倍の価値があります。 ボスチェストは" + UpdateGame.bossChestGoldCoinsDrops + "枚の金貨を落とし、すべて10倍または25倍の金貨です.(金貨値フォームボス胸=(現在の胸金貨値*5)*10または25). また、" + UpdateGame.bossChestXPDrops + "XXPを与えます.\nUロックピックまたはキーを使用すると、胸の健康状態の25％しか削除されません。ボスの胸はまた、珍しい宝物をドロップするわずかに高いチャンスを持っています。";
            }

            if (newChests5Bought == 1)
            {
                bossChestInfoText.text = (UpdateGame.bossChestChance).ToString("F2") + "%スポーンのチャンス\nボスチェストは" + UpdateGame.bossChestHealth + "倍の健康を持っています。金貨は" + UpdateGame.bossChestGoldValue + "倍の価値があります。 ボスチェストは" + UpdateGame.bossChestGoldCoinsDrops + "ボスチェストは25枚の金貨を落とし、すべて25倍の金貨です.(金貨値フォームボス胸=(現在の胸金貨値*5)*25). また、" + UpdateGame.bossChestXPDrops + "XXPを与えます.\nUロックピックまたはキーを使用すると、胸の健康状態の25％しか削除されません。ボスの胸はまた、珍しい宝物をドロップするわずかに高いチャンスを持っています。";
            }
        }
        #endregion

        #region Info Chinese
        if (Localization.ChineseLanguageChosen == 1)
        {
            reinforcedChestInfoText.text = "强化宝箱具有" + UpdateGame.reinforcedChestHealth + "倍的生命值、" + UpdateGame.reinforcedChestGoldIncrease + "倍的金币奖励和" + UpdateGame.reinforcedXPIncrease + "倍的经验奖励。";

            if (newChests1Bought == 1)
            {
                enchantedGoldenChestInfoText.text = (100 - UpdateGame.enchantedGoldenChestChance).ToString("F2") + "%生成几率\n强化金宝箱具有" + UpdateGame.enchantedGoldenChestHealth + "倍的生命值，掉落" + UpdateGame.enchantedGoldenChestTreasureDrops + "个宝藏和" + UpdateGame.enchantedGoldenChestXPDrops + "倍的经验奖励。\n 使用挑锁器或钥匙仅会移除宝箱生命值的33%。\n此外，强化金宝箱也有略高的几率掉落稀有宝藏。";
            }

            if (newChests2Bought == 1)
            {
                bossChestInfoText.text = (UpdateGame.bossChestChance).ToString("F2") + "%生成几率\nB首领宝箱具有" + UpdateGame.bossChestHealth + "倍的生命值。金币价值增加" + UpdateGame.bossChestGoldValue + "倍。首领宝箱掉落" + UpdateGame.bossChestGoldCoinsDrops + "个金币，这些金币价值分别为10倍或25倍。(首领宝箱金币价值=（当前宝箱金币价值*5）*10或25）此外，还提供" + UpdateGame.bossChestXPDrops + "倍的经验奖励\n使用挑锁器或钥匙仅会移除宝箱生命值的25%.\n首领宝箱也有略高的几率掉落稀有宝藏。";
            }

            if (newChests5Bought == 1)
            {
                bossChestInfoText.text = (UpdateGame.bossChestChance).ToString("F2") + "%生成几率\nB首领宝箱具有" + UpdateGame.bossChestHealth + "倍的生命值。金币价值增加" + UpdateGame.bossChestGoldValue + "倍。首领宝箱掉落" + UpdateGame.bossChestGoldCoinsDrops + "个金币，这些金币价值分别为倍25倍。(首领宝箱金币价值=（当前宝箱金币价值*5）*25）此外，还提供" + UpdateGame.bossChestXPDrops + "倍的经验奖励\n使用挑锁器或钥匙仅会移除宝箱生命值的25%.\n首领宝箱也有略高的几率掉落稀有宝藏。";
            }
        }
        #endregion

        #region Info Korean
        if (Localization.KoreanLanguageChosen == 1)
        {
            reinforcedChestInfoText.text = "강화 상자들은" + UpdateGame.reinforcedChestHealth + "HP를 갖고 있고 " + UpdateGame.reinforcedChestGoldIncrease + "X 골드, 그리고 " + UpdateGame.reinforcedXPIncrease + "X XP를 줍니다.";

            if (newChests1Bought == 1)
            {
                enchantedGoldenChestInfoText.text = (100 - UpdateGame.enchantedGoldenChestChance).ToString("F2") + "% 의 스폰 확률.\n마법에 걸린 황금 상자는" + UpdateGame.enchantedGoldenChestHealth + "X HP를 갖고 있고 보물" + UpdateGame.enchantedGoldenChestTreasureDrops + "개와" + UpdateGame.enchantedGoldenChestXPDrops + "X XP를 드롭합니다\n자물쇠 따개나 열쇠를 사용한다고 해도 상자의 HP 중 33%만 제거하게 됩니다.\n마법에 걸린 황금 상자는 또한 레어 보물을 드롭할 조금 더 높은 확률을 갖고 있습니다";
            }

            if (newChests2Bought == 1)
            {
                bossChestInfoText.text = (UpdateGame.bossChestChance).ToString("F2") + "% 의 스폰 확률.\n보스 상자는" + UpdateGame.bossChestHealth + "X HP를 갖고 있습니다. 골드 코인은" + UpdateGame.bossChestGoldValue + "X의 가치를 가지고 있습니다. 보스 상자는" + UpdateGame.bossChestGoldCoinsDrops + "골드 코인을 드롭하는데, 이는 모두 10X 혹은 25X 골드 코인들로 구성되어 있습니다. (보스 상자에서 나온 골드 코인 가치 = (상자에 있는 현재 골드 코인 가치 * 5) * 10 혹은 25). 또한 " + UpdateGame.bossChestXPDrops + "X XP를 줍니다\n자물쇠 따개나 열쇠를 사용한다고 해도 상자의 HP 중 25%만 제거하게 됩니다.\n보스 상자는 또한 레어 보물을 드롭할 조금 더 높은 확률을 갖고 있습니다. ";
            }

            if (newChests5Bought == 1)
            {
                bossChestInfoText.text = (UpdateGame.bossChestChance).ToString("F2") + "% 의 스폰 확률.\n보스 상자는" + UpdateGame.bossChestHealth + "X HP를 갖고 있습니다. 골드 코인은" + UpdateGame.bossChestGoldValue + "X의 가치를 가지고 있습니다. 보스 상자는" + UpdateGame.bossChestGoldCoinsDrops + "골드 코인을 드롭하는데, 이는 모두 25X 골드 코인들로 구성되어 있습니다. (보스 상자에서 나온 골드 코인 가치 = (상자에 있는 현재 골드 코인 가치 * 5) * 25). 또한 " + UpdateGame.bossChestXPDrops + "X XP를 줍니다\n자물쇠 따개나 열쇠를 사용한다고 해도 상자의 HP 중 25%만 제거하게 됩니다.\n보스 상자는 또한 레어 보물을 드롭할 조금 더 높은 확률을 갖고 있습니다. ";
            }
        }
        #endregion
    }
    #endregion

     public void PrestigeUpgradeSounds()
    {
        int random = Random.Range(1, 4);
        if (random == 1) { if (AudioManager.audioMuted == 1) { audioManager.Play("LevelUp"); } }
        if (random == 2) { if (AudioManager.audioMuted == 1) { audioManager.Play("LevelUp2"); } }
        if (random == 3) { if (AudioManager.audioMuted == 1) { audioManager.Play("LevelUp3"); } }
    }

    public void CheckPriceTextColor()
    {
        #region reinforcedAfford
        if (PlayerLevel.skillPoints >= reinforced1Price) { reinforcedTextPricesText[0].color = Color.green; }
        if (PlayerLevel.skillPoints < reinforced1Price) { reinforcedTextPricesText[0].color = Color.red; }

        if (PlayerLevel.skillPoints >= reinforced2Price) { reinforcedTextPricesText[1].color = Color.green; }
        if (PlayerLevel.skillPoints < reinforced2Price) { reinforcedTextPricesText[1].color = Color.red; }

        if (PlayerLevel.skillPoints >= reinforced3Price) { reinforcedTextPricesText[2].color = Color.green; }
        if (PlayerLevel.skillPoints < reinforced3Price) { reinforcedTextPricesText[2].color = Color.red; }

        if (PlayerLevel.skillPoints >= reinforced4Price) { reinforcedTextPricesText[3].color = Color.green; }
        if (PlayerLevel.skillPoints < reinforced4Price) { reinforcedTextPricesText[3].color = Color.red; }

        if (PlayerLevel.skillPoints >= reinforced5Price) { reinforcedTextPricesText[4].color = Color.green; }
        if (PlayerLevel.skillPoints < reinforced5Price) { reinforcedTextPricesText[4].color = Color.red; }
        #endregion

        #region greaterLootAfford
        if (PlayerLevel.skillPoints >= greaterLoot1Price) { greaterLootTextPricesText[0].color = Color.green; }
        if (PlayerLevel.skillPoints < greaterLoot1Price) { greaterLootTextPricesText[0].color = Color.red; }

        if (PlayerLevel.skillPoints >= greaterLoot2Price) { greaterLootTextPricesText[1].color = Color.green; }
        if (PlayerLevel.skillPoints < greaterLoot2Price) { greaterLootTextPricesText[1].color = Color.red; }

        if (PlayerLevel.skillPoints >= greaterLoot3Price) { greaterLootTextPricesText[2].color = Color.green; }
        if (PlayerLevel.skillPoints < greaterLoot3Price) { greaterLootTextPricesText[2].color = Color.red; }

        if (PlayerLevel.skillPoints >= greaterLoot4Price) { greaterLootTextPricesText[3].color = Color.green; }
        if (PlayerLevel.skillPoints < greaterLoot4Price) { greaterLootTextPricesText[3].color = Color.red; }

        if (PlayerLevel.skillPoints >= greaterLoot5Price) { greaterLootTextPricesText[4].color = Color.green; }
        if (PlayerLevel.skillPoints < greaterLoot5Price) { greaterLootTextPricesText[4].color = Color.red; }
        #endregion

        #region newChestAffort
        if (PlayerLevel.skillPoints >= newChests1Price) { newChestsTextPricesText[0].color = Color.green; }
        if (PlayerLevel.skillPoints < newChests1Price) { newChestsTextPricesText[0].color = Color.red; }

        if (PlayerLevel.skillPoints >= newChests2Price) { newChestsTextPricesText[1].color = Color.green; }
        if (PlayerLevel.skillPoints < newChests2Price) { newChestsTextPricesText[1].color = Color.red; }

        if (PlayerLevel.skillPoints >= newChests3Price) { newChestsTextPricesText[2].color = Color.green; }
        if (PlayerLevel.skillPoints < newChests3Price) { newChestsTextPricesText[2].color = Color.red; }

        if (PlayerLevel.skillPoints >= newChests4Price) { newChestsTextPricesText[3].color = Color.green; }
        if (PlayerLevel.skillPoints < newChests4Price) { newChestsTextPricesText[3].color = Color.red; }

        if (PlayerLevel.skillPoints >= newChests5Price) { newChestsTextPricesText[4].color = Color.green; }
        if (PlayerLevel.skillPoints < newChests5Price) { newChestsTextPricesText[4].color = Color.red; }

        if (PlayerLevel.skillPoints >= newChests6Price) { newChestsTextPricesText[5].color = Color.green; }
        if (PlayerLevel.skillPoints < newChests6Price) { newChestsTextPricesText[5].color = Color.red; }
        #endregion
    }

    private void SetAlpha(Graphic graphic, float alpha)
    {
        Color currentColor = graphic.color;
        currentColor.a = alpha;
        graphic.color = currentColor;

        for (int i = 0; i < graphic.transform.childCount; i++)
        {
            Graphic childGraphic = graphic.transform.GetChild(i).GetComponent<Graphic>();
            if (childGraphic != null)
            {
                SetAlpha(childGraphic, alpha);
            }
        }
    }

    #endregion

    //Mimic chest
    #region mimicChestBuffCountdowns

    private System.Collections.IEnumerator StartGoldBuff()
    {
        goldBuffAmount =  (1 + UseConsumable.lootPotionGoldBuff  + ClickPower.cursorEquippedGoldIncrease + SkillTree.skillTreeGold + RareTreasures.runeGold + RareTreasures.cookieGold + RareTreasures.backPackGold + UseConsumable.scrollGoldBuff + UseConsumable.relicPermaGoldBuff) / 6;

        goldBuffText.text = "<color=yellow>+" + (goldBuffAmount * 100).ToString("F0") + "%" + Localization.gold;

        while (goldBuffTimer > 0)
        {
            goldBuffTimerText.text = Localization.forTheNext + "<color=green>" + Mathf.Round(goldBuffTimer).ToString() + "<color=white>" + Localization.seconds;
            yield return new WaitForSeconds(1f);
            goldBuffTimer -= 1f;
        }

        positiveGoldIcon.SetActive(false);
        positiveGoldHover.SetActive(false);
        goldBuffAmount = 0;
    }

    private System.Collections.IEnumerator StartDamageBuff()
    {
        if (ClickPower.activeDamageMultiplier < 1)
        {
            damageBuffAmount = (1 + UseConsumable.damagePotionBuff + ClickPower.passiveDamageMultiplier + SkillTree.skillTreeActiveDamage + RareTreasures.swordActive + RareTreasures.guitarActiveAndPassive + RareTreasures.cookieActive + UseConsumable.scrollActiveDamageBuff + UseConsumable.relicPermaActiveDamage) / 7;
        }
        else if (ClickPower.activeDamageMultiplier >= 1)
        {
            damageBuffAmount = (1 + UseConsumable.damagePotionBuff + ClickPower.activeDamageMultiplier + SkillTree.skillTreeActiveDamage + RareTreasures.swordActive + RareTreasures.guitarActiveAndPassive + RareTreasures.cookieActive + UseConsumable.scrollActiveDamageBuff + UseConsumable.relicPermaActiveDamage) / 7;
        }
        else if (ClickPower.activeDamageMultiplier < 1 && ClickPower.passiveDamageMultiplier < 1)
        {
            damageBuffAmount = (1 + UseConsumable.damagePotionBuff + SkillTree.skillTreeActiveDamage + RareTreasures.swordActive + RareTreasures.guitarActiveAndPassive + RareTreasures.cookieActive + UseConsumable.scrollActiveDamageBuff + UseConsumable.relicPermaActiveDamage) / 7;
        }


        damageBuffText.text = "<color=green>+" + (damageBuffAmount * 100).ToString("F0") + Localization.damagePercent;
        ClickPower.cursorsPriceChanged = true;

        while (damageBuffTimer > 0)
        {
            damageBuffTimerrText.text = Localization.forTheNext + "<color=green>" + Mathf.Round(damageBuffTimer).ToString() + "<color=white>" + Localization.seconds;
            yield return new WaitForSeconds(1f);
            damageBuffTimer -= 1f;
        }

       
        positiveDamageIcon.SetActive(false);
        positiveDamageHover.SetActive(false);
        damageBuffAmount = 0;
        ClickPower.cursorsPriceChanged = true;
    }

    private System.Collections.IEnumerator StartXPBuff()
    {
        XPBuffAmount =  (1 + UseConsumable.XPPotionBuff + SkillTree.skillTreeXP + ClickPower.cursorEquippedXPIncrease + RareTreasures.backPackXP + RareTreasures.cookieXP + UseConsumable.scrollXPBuff + UseConsumable.relicPermaXPBuff) / 6;
        XPBuffText.text = "<color=orange>+" + (XPBuffAmount * 100).ToString("F0") + Localization.xp;

        while (XPBuffTimer > 0)
        {
            XPBuffTimerrText.text = Localization.forTheNext + "<color=green>" + Mathf.Round(XPBuffTimer).ToString() + "<color=white>" + Localization.seconds;
            yield return new WaitForSeconds(1f);
            XPBuffTimer -= 1f;
        }

        positiveXPIcon.SetActive(false);
        positiveXPHover.SetActive(false);
        XPBuffAmount = 0;
    }

    private System.Collections.IEnumerator StartTreasureDropBuff()
    {
        treasureDropBuffText.text = "<color=green>+" + (treasureDropBuffAmount).ToString("F2") + Localization.treasureDropChance;
        SpawnRewards.changeDropChanceValues = true;

        while (treasureDropBuffTimer > 0)
        {
            treasureDropTimerrText.text = Localization.forTheNext + "<color=green>" + Mathf.Round(treasureDropBuffTimer).ToString() + "<color=white>" + Localization.seconds;
            yield return new WaitForSeconds(1f);
            treasureDropBuffTimer -= 1f;
        }

        SpawnRewards.changeDropChanceValues = true;
        positiveTreasureIcon.SetActive(false);
        positiveTreasureHover.SetActive(false);
        treasureDropBuffAmount = 0;
    }


    private System.Collections.IEnumerator StartGoldCoinBuff()
    {
        goldCoinBuffText.text = "<color=yellow>+" + (goldCoinBuffAmount).ToString("F0") + Localization.goldCoinsDrop;

        isGoldCoinDropBuffActive = true;

        while (goldCoinDropBuffTimer > 0)
        {
            goldCoinTimerrText.text = Localization.forTheNext + "<color=green>" + Mathf.Round(goldCoinDropBuffTimer).ToString() + "<color=white>" + Localization.seconds;
            yield return new WaitForSeconds(1f);
            goldCoinDropBuffTimer -= 1f;
        }

        goldCoinBuffAmount = 0;
        isGoldCoinDropBuffActive = false;
        positiveCoinDropIcon.SetActive(false);
        positiveColdCoinHover.SetActive(false);
    }

    private System.Collections.IEnumerator StartRareTreasureBuff()
    {
        isRareTreasureDropBuffActive = true;

        while (rareTreasureBuffTimer > 0)
        {
            rareTreasureTimerrText.text = Localization.forTheNext + "<color=green>" + Mathf.Round(rareTreasureBuffTimer).ToString() + "<color=white>" + Localization.seconds;
            yield return new WaitForSeconds(1f);
            rareTreasureBuffTimer -= 1f;
        }

        isRareTreasureDropBuffActive = false;
        rareTreasureBuffIcon.SetActive(false);
        rareTreasureBuffHover.SetActive(false);
    }

    #endregion

    #region mimicChestDebuffCountdowns

    private System.Collections.IEnumerator StartGoldDebuff()
    {
        goldDebuffAmount = (1 + UseConsumable.lootPotionGoldBuff + ClickPower.cursorEquippedGoldIncrease + SkillTree.skillTreeGold + RareTreasures.runeGold + RareTreasures.cookieGold + RareTreasures.backPackGold + UseConsumable.scrollGoldBuff + UseConsumable.relicPermaGoldBuff) / 6;

        goldDebuffText.text = "<color=red>-" + (goldDebuffAmount * 100).ToString("F0") + "%" + Localization.gold;


        while (goldDebuffTimer > 0)
        {
            goldDebuffTimerText.text = Localization.forTheNext + "<color=green>" + Mathf.Round(goldDebuffTimer).ToString() + "<color=white>" + Localization.seconds;
            yield return new WaitForSeconds(1f);
            goldDebuffTimer -= 1f;
        }

        negativeGoldIcon.SetActive(false);
        negativeGoldHover.SetActive(false);
        goldDebuffAmount = 0;
    }

    private System.Collections.IEnumerator StartDamageDebuff()
    {
        if(ClickPower.activeDamageMultiplier < 1)
        {
            damageDebuffAmount = (1 + UseConsumable.damagePotionBuff + ClickPower.passiveDamageMultiplier + SkillTree.skillTreeActiveDamage + RareTreasures.swordActive + RareTreasures.guitarActiveAndPassive + RareTreasures.cookieActive + UseConsumable.scrollActiveDamageBuff + UseConsumable.relicPermaActiveDamage) / 7;
        }
        else if(ClickPower.activeDamageMultiplier >= 1)
        {
            damageDebuffAmount = (1 + UseConsumable.damagePotionBuff + ClickPower.activeDamageMultiplier + SkillTree.skillTreeActiveDamage + RareTreasures.swordActive + RareTreasures.guitarActiveAndPassive + RareTreasures.cookieActive + UseConsumable.scrollActiveDamageBuff + UseConsumable.relicPermaActiveDamage) / 7;
        }
        else if (ClickPower.activeDamageMultiplier < 1 && ClickPower.passiveDamageMultiplier < 1)
        {
            damageDebuffAmount = (1 + UseConsumable.damagePotionBuff + SkillTree.skillTreeActiveDamage + RareTreasures.swordActive + RareTreasures.guitarActiveAndPassive + RareTreasures.cookieActive + UseConsumable.scrollActiveDamageBuff + UseConsumable.relicPermaActiveDamage) / 7;
        }
      
        damageDebuffText.text = "<color=red>-" + (damageDebuffAmount * 100).ToString("F0") + Localization.damagePercent;
        ClickPower.cursorsPriceChanged = true;

        while (damageDebuffTimer > 0)
        {
            damageDebuffTimerText.text = Localization.forTheNext + "<color=green>" + Mathf.Round(damageDebuffTimer).ToString() + "<color=white>" + Localization.seconds;
            yield return new WaitForSeconds(1f);
            damageDebuffTimer -= 1f;
        }
       
        negativeDamageIcon.SetActive(false);
        negativeDamageHover.SetActive(false);
        damageDebuffAmount = 0;
        ClickPower.cursorsPriceChanged = true;
    }


    private System.Collections.IEnumerator StartXPDebuff()
    {
        XPDebuffAmount = (1 + UseConsumable.XPPotionBuff  + SkillTree.skillTreeXP + ClickPower.cursorEquippedXPIncrease + RareTreasures.backPackXP + RareTreasures.cookieXP + UseConsumable.scrollXPBuff + UseConsumable.relicPermaXPBuff) / 6;
        xpDebuffText.text = "<color=red>-" + (XPDebuffAmount * 100).ToString("F0") + Localization.xp;

        while (XPDebuffTimer > 0)
        {
            XPDebuffTimerText.text = Localization.forTheNext + "<color=green>" + Mathf.Round(XPDebuffTimer).ToString() + "<color=white>" + Localization.seconds;
            yield return new WaitForSeconds(1f);
            XPDebuffTimer -= 1f;
        }

        negativeXPIcon.SetActive(false);
        negativeXPHover.SetActive(false);
        XPDebuffAmount = 0;
    }


    private System.Collections.IEnumerator StartTreasureDropDebuff()
    {
        treasureDropDebuffText.text = "<color=red>-" + (treasureDebuffAmount).ToString("F2") + Localization.treasureDropChance;
        SpawnRewards.changeDropChanceValues = true;

        while (treasureDropDebuffTimer > 0)
        {
            treasureDebuffTimerText.text = Localization.forTheNext + "<color=green>" + Mathf.Round(treasureDropDebuffTimer).ToString() + "<color=white>" + Localization.seconds;
            yield return new WaitForSeconds(1f);
            treasureDropDebuffTimer -= 1f;
        }

        SpawnRewards.changeDropChanceValues = true;
        negativeTreasureIcon.SetActive(false);
        negativeTreasureHover.SetActive(false);
        treasureDebuffAmount = 0;
    }


    private System.Collections.IEnumerator StartGoldCoinDebuff()
    {
        goldCoinDebuffText.text = "<color=red>-" + (goldCoinDebuffAmount).ToString("F0") + Localization.goldCoinsDrop;

        isGoldCoinDropDebuffActive = true;

        while (goldCoinDropDebuffTimer > 0)
        {
            goldCoinDebuffTimerText.text = Localization.forTheNext + "<color=green>" + Mathf.Round(goldCoinDropDebuffTimer).ToString() + "<color=white>" + Localization.seconds;
            yield return new WaitForSeconds(1f);
            goldCoinDropDebuffTimer -= 1f;
        }

        goldCoinDebuffAmount = 0;
        isGoldCoinDropDebuffActive = false;
        negativeGoldCoinIcon.SetActive(false);
        negativeColdCoinHover.SetActive(false);
    }

    #endregion

    //Items
    #region newItems

    #region purchaseAndUpgradeKnife
    public static int knifeTimer, knifeTimerIncrement;
    public TextMeshProUGUI knifeLeveLText;
    public TextMeshProUGUI knifeDropChanceText;
    public TextMeshProUGUI knifeBuffText;
    public TextMeshProUGUI knifeHoverPriceText;
    public TextMeshProUGUI knifePriceText;
    public TextMeshProUGUI knifeGemPriceText, knifeGemPriceText2;

    public static int knifeCount;

    public void PurchaseKnife()
    {
        if (SpecialUpgradesButtons.isHoldingMax == true)
        {
            if (UpdateGame.totalGoldHigher < knifeBuyPriceDouble)
            {
                CantAfford();
            }
            while (UpdateGame.totalGoldHigher >= knifeBuyPriceDouble)
            {
                KnifeVariables();
            }
        }
        else
        {
            KnifeVariables();
        }
    }

    public void KnifeVariables()
    {
        if (totalGoldHigher < knifeBuyPriceDouble)
        {
            CantAfford();
        }
        if (totalGoldHigher >= knifeBuyPriceDouble)
        {
            Stats.itemsPurchased += 1;
            knifeBoughtFirstTime = 1;
            knifeCount += 1;
            totalGoldHigher -= knifeBuyPriceDouble;
            knifeBuyPriceDouble *= 5f;

            PurchaseItemSound();

            changeItemUpdate = true;
            SpecialUpgradesButtons.changeText = true;
            HoverSpecialString.hoverPriceChange = true;

            CheckNextUpgrade();
        }
    }


    public void UpgradeKnife()
    {
        if (SpecialUpgradesButtons.isHoldingMax == true)
        {
            if (RareDropsCollected.chronolithShardCount < knifeGemPrice || RareDropsCollected.sideriumEssenceCount < knifeGemPrice2)
            {
                CantAfford();
            }
            if (RareDropsCollected.chronolithShardCount >= knifeGemPrice && RareDropsCollected.sideriumEssenceCount >= knifeGemPrice2)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.chronolithShardCount >= knifeGemPrice && RareDropsCollected.sideriumEssenceCount >= knifeGemPrice2)
            {
                UpgradeKnifeVariables();
            }
        }
        else
        {
            if (RareDropsCollected.chronolithShardCount < knifeGemPrice || RareDropsCollected.sideriumEssenceCount < knifeGemPrice2)
            {
                CantAfford();
            }
            if (RareDropsCollected.chronolithShardCount >= knifeGemPrice && RareDropsCollected.sideriumEssenceCount >= knifeGemPrice2)
            {
                UpgradeKnifeVariables();
                UpgradeSound();
            }
        }
    }

    public void UpgradeKnifeVariables()
    {
        Stats.itemsUpgraded += 1;
        knifeLevel += 1;
        knifeTimer += knifeTimerIncrement;
        knifeDropChance += knifeDropChanceIncrement;

        RareDropsCollected.chronolithShardCount -= knifeGemPrice;
        RareDropsCollected.sideriumEssenceCount -= knifeGemPrice2;

        knifeGemPrice += 12;
        knifeGemPrice2 += 12;

        RareDropsCollected.isGemCountUpdated = true;
        HoverSpecialString.hoverSpecialChance = true;
        changeItemUpdate = true;
    }

    #endregion

    #region purchaseAndUpgradeTreasurePotion
    public static int treasurePotionTimer, treasurePotionTimerIncrement;
    public TextMeshProUGUI treasurePotionLeveLText;
    public TextMeshProUGUI treasurePotionDropChanceText;
    public TextMeshProUGUI treasurePotionBuffText;
    public TextMeshProUGUI treasurePotionHoverPriceText;
    public TextMeshProUGUI treasurePotionPriceText;
    public TextMeshProUGUI treasurePotionGemPriceText, treasurePotionGemPriceText2;

    public static int treasurePotionCount;

    public void PurchaseTreasurePotion()
    {
        if (SpecialUpgradesButtons.isHoldingMax == true)
        {
            if (totalGoldHigher < treasurePotionBuyPriceDouble)
            {
                CantAfford();
            }
            while (totalGoldHigher >= treasurePotionBuyPriceDouble)
            {
                TreasurePotionVariables();
            }
        }
        else
        {
            TreasurePotionVariables();
        }

    }

    public void TreasurePotionVariables()
    {
        if (totalGoldHigher < treasurePotionBuyPriceDouble)
        {
            CantAfford();
        }
        if (totalGoldHigher >= treasurePotionBuyPriceDouble)
        {
            Stats.itemsPurchased += 1;
            treasurePotionBoughtFirstTime = 1;
            treasurePotionCount += 1;
            totalGoldHigher -= treasurePotionBuyPriceDouble;
            treasurePotionBuyPriceDouble *= 4f;

            PurchaseItemSound();

            changeItemUpdate = true;
            SpecialUpgradesButtons.changeText = true;
            HoverSpecialString.hoverPriceChange = true;

            CheckNextUpgrade();
        }
    }

    public void UpgradeTreasurePotion()
    {
        if (SpecialUpgradesButtons.isHoldingMax == true)
        {
            if (RareDropsCollected.astraliumCount < treasurePotionGemPrice || RareDropsCollected.elysiumPrismCount < treasurePotionGemPrice2)
            {
                CantAfford();
            }
            if (RareDropsCollected.astraliumCount >= treasurePotionGemPrice && RareDropsCollected.elysiumPrismCount >= treasurePotionGemPrice2)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.astraliumCount >= treasurePotionGemPrice && RareDropsCollected.elysiumPrismCount >= treasurePotionGemPrice2)
            {
                UpgradeTreasurePotionVariables();
            }
        }
        else
        {
            if (RareDropsCollected.astraliumCount < treasurePotionGemPrice || RareDropsCollected.elysiumPrismCount < treasurePotionGemPrice2)
            {
                CantAfford();
            }
            if (RareDropsCollected.astraliumCount >= treasurePotionGemPrice && RareDropsCollected.elysiumPrismCount >= treasurePotionGemPrice2)
            {
                UpgradeTreasurePotionVariables();
                UpgradeSound();
            }
        }
    }

    public void UpgradeTreasurePotionVariables()
    {
        Stats.itemsUpgraded += 1;
        treasurePotionLevel += 1;
        treasurePotionTimer += treasurePotionTimerIncrement;
        treasurePotionDropChance += treasurePotionDropChanceIncrement;
        RareDropsCollected.astraliumCount -= treasurePotionGemPrice;
        RareDropsCollected.elysiumPrismCount -= treasurePotionGemPrice2;

        treasurePotionGemPrice += 8;
        treasurePotionGemPrice2 += 8;

        RareDropsCollected.isGemCountUpdated = true;
        HoverSpecialString.hoverSpecialChance = true;
        changeItemUpdate = true;
    }
    #endregion

    #region purchaseAndUpgradeBarrel
    public TextMeshProUGUI barrelLeveLText;
    public TextMeshProUGUI barrelBuffText;
    public TextMeshProUGUI barrelHoverPriceText;
    public TextMeshProUGUI barrelPriceText;
    public TextMeshProUGUI barrelGemPriceText;
    public GameObject realBarrel, fakfeBarrel, barrelDrag;
    public Button barrelButton;

    public static float barrelGoldValue, barrelGoldValueIncrement;

    public void PurchaseBarrel()
    {
        if (totalGoldHigher < barrelBuyPriceDouble)
        {
            CantAfford();
        }
        if (totalGoldHigher >= barrelBuyPriceDouble)
        {
            Stats.itemsPurchased += 1;
            barrelBoughtFirstTime = 1;
            totalGoldHigher -= barrelBuyPriceDouble;
            //barrelBuyPriceDouble *= 4.2f;

            PurchaseItemSound();
            realBarrel.SetActive(true); fakfeBarrel.SetActive(true); barrelDrag.SetActive(true);

            changeItemUpdate = true;
            SpecialUpgradesButtons.changeText = true;
            HoverSpecialString.hoverPriceChange = true;

            CheckNextUpgrade();
        }
    }

    public void UpgradeBarrel()
    {
        if (SpecialUpgradesButtons.isHoldingMax == true)
        {
            if (RareDropsCollected.RedGemCount < barrelGemPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.RedGemCount >= barrelGemPrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.RedGemCount >= barrelGemPrice)
            {
                UpgradeBarrelVariables();
            }
        }
        else
        {
            if (RareDropsCollected.RedGemCount < barrelGemPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.RedGemCount >= barrelGemPrice)
            {
                UpgradeBarrelVariables();
                UpgradeSound();
            }
        }
    }


    public void UpgradeBarrelVariables()
    {
        Stats.itemsUpgraded += 1;
        barrelLevel += 1;
        RareDropsCollected.RedGemCount -= barrelGemPrice;
        barrelGemPrice += 9;

        barrelGoldValue += barrelGoldValueIncrement;

        RareDropsCollected.isGemCountUpdated = true;
        HoverSpecialString.hoverSpecialChance = true;
        changeItemUpdate = true;
    }

    #endregion

    #region purchaseAndUpgradeMimicChest
    public TextMeshProUGUI mimicChestLeveLText;
    public TextMeshProUGUI mimicChestBuffText;
    public TextMeshProUGUI mimicChestHoverPriceText;
    public TextMeshProUGUI mimicChestPriceText;
    public TextMeshProUGUI mimicChestGemPriceText;
    public TextMeshProUGUI mimicChestTimerInfo;
    public GameObject maxMimicChest;

    public static int mimicPositiveBuffChance, mimicPositiveBiffChanceIncrement, mimicNegativeBuffChance, mimicNegativeBuffChanceIncrement, mimicChestTimer, mimicChestTimerIncrement;

    public void PurchaseMimicChest()
    {
        if (SpecialUpgradesButtons.isHoldingMax == true)
        {
            if (totalGoldHigher < mimicChestBuyPriceDouble)
            {
                CantAfford();
            }
            while (totalGoldHigher >= mimicChestBuyPriceDouble)
            {
                MinmicChestVariables();
            }
        }
        else
        {
            MinmicChestVariables();
        }
    }

    public void MinmicChestVariables()
    {
        if (totalGoldHigher < mimicChestBuyPriceDouble)
        {
            CantAfford();
        }
        if (totalGoldHigher >= mimicChestBuyPriceDouble)
        {
            Stats.itemsPurchased += 1;

            totalGoldHigher -= mimicChestBuyPriceDouble;
            mimicChestBuyPriceDouble *= 3.9f;

            PurchaseItemSound();

            if (UIelementsClick.turnOfMimicChest == 0)
            {
                SpawnMimicChest();
            }
            if (UIelementsClick.turnOfMimicChest == 1)
            {
                mimicChestBoughtFirstTime = 1;
            }

            changeItemUpdate = true;
            SpecialUpgradesButtons.changeText = true;
            HoverSpecialString.hoverPriceChange = true;

            CheckNextUpgrade();
        }
    }

    public void SpawnMimicChest()
    {
        if (mimicChestBoughtFirstTime != 1) { isMimicCountdown = true; }
        mimicChestBoughtFirstTime = 1;
        if (mimicChestBoughtFirstTime == 1) { GameObject mimicChest = ObjectPooling.instance.GetMimicChestFromPool(); }
    }

    public void UpgradeMimicChest()
    {
        if (mimicChestTimer <= 60)
        {
            CantAfford();
            maxMimicChest.SetActive(true);
        }
        if (mimicChestTimer > 60)
        {
            if (SpecialUpgradesButtons.isHoldingMax == true)
            {
                if (RareDropsCollected.violetCrystalCount < mimicChestGemPrice)
                {
                    CantAfford();
                }
                if (RareDropsCollected.violetCrystalCount >= mimicChestGemPrice)
                {
                    UpgradeSound();
                }
                while (RareDropsCollected.violetCrystalCount >= mimicChestGemPrice && mimicChestTimer > 60)
                {
                    UpgradeMimicVariables();
                }
            }
            else
            {
                if (RareDropsCollected.violetCrystalCount < mimicChestGemPrice)
                {
                    CantAfford();
                }
                if (RareDropsCollected.violetCrystalCount >= mimicChestGemPrice)
                {
                    UpgradeMimicVariables();
                    UpgradeSound();
                }
            }
        }
    }


    public void UpgradeMimicVariables()
    {
        if (mimicChestTimer > 60)
        {
            Stats.itemsUpgraded += 1;
            mimicChestLevel += 1;
            RareDropsCollected.violetCrystalCount -= mimicChestGemPrice;
            mimicChestGemPrice += 4;

            mimicPositiveBuffChance += mimicPositiveBiffChanceIncrement;
            mimicNegativeBuffChance -= mimicNegativeBuffChanceIncrement;
            mimicChestTimer -= mimicChestTimerIncrement;

            RareDropsCollected.isGemCountUpdated = true;
            HoverSpecialString.hoverSpecialChance = true;
            changeItemUpdate = true;
        }
        if(mimicChestTimer < 60)
        {
            mimicChestTimer = 60;
        }
    }
    #endregion

    public GameObject scrollLocked, gauntletLocked;
    public GameObject itemBarTreasurEPotionLocked, itemBarKnifeLocked;

    public PlaceMobileButtons mobileScript;

    public void CheckNextUpgrade()
    {
        if (barrelBoughtFirstTime == 1) { scrollLocked.SetActive(true);}
        if (mimicChestBoughtFirstTime == 1) { gauntletLocked.SetActive(true); }
        if (treasurePotionBoughtFirstTime == 1) { knifeLocked.SetActive(true); itemBarTreasurEPotionLocked.SetActive(false); }
        if (knifeBoughtFirstTime == 1) { itemBarKnifeLocked.SetActive(false); }

        mobileScript.CheckShopQuestionMarks();

    }

    #endregion

    #region useItems

    #region knife
    public GameObject knifeCountdownBar;
    public TextMeshProUGUI knifeCountDownText;
    public float knifeCountDownTime;
    public static bool KnifeActive;

    public void UseKnife()
    {
        if (knifeCount > 0)
        {
            UseItemSound();
            Stats.itemsUsed += 1;
            knifeUpgrade.GetComponent<Button>().interactable = false;
            KnifeActive = true;

            knifeCount -= 1;
            knifeCountDownTime = knifeTimer;

            changeItemUpdate = true;
            SpecialUpgradesButtons.specialTextChange = true;

            if (knifeCount == 0) { knifeCountText.color = Color.red; }
            knifeCountdownBar.SetActive(true);
            StartCoroutine(SetKifeCountDown());
        }
    }

    private System.Collections.IEnumerator SetKifeCountDown()
    {
        while (knifeCountDownTime > 0)
        {
            knifeCountDownText.text = Mathf.Round(knifeCountDownTime).ToString();
            yield return new WaitForSeconds(1f);
            knifeCountDownTime -= 1f;
        }

        knifeUpgrade.GetComponent<Button>().interactable = true;
        KnifeActive = false;
        knifeCountdownBar.SetActive(false);
    }
    #endregion

    #region treasurePotion
    public GameObject treasurePotionCountdownBar;
    public TextMeshProUGUI treasurePotionCountdownText;
    public float treasurePotionCountdownTime;
    public bool treasurePotionActive;
    public TextMeshProUGUI  treasurePotionCountText;
    public static float treasurePotionChance;

    public void UseTreasurePotion()
    {
        if (treasurePotionCount > 0)
        {
            UseItemSound();

            treasurePotionIcon.SetActive(true);

            treasurePotionChance = 3f;

            Stats.itemsUsed += 1;

            treasurePotionCountdownBar.SetActive(true);
            treasurePotionCount -= 1;

            SpecialUpgradesButtons.changeText = true;
            SpecialUpgradesButtons.specialTextChange = true;

            treasurePotionUpgrade.GetComponent<Button>().interactable = false;

            if (treasurePotionCount == 0) { treasurePotionCountText.color = Color.red; }
            if (treasurePotionActive == false)
            {
                 treasurePotionCountdownTime = treasurePotionTimer; StartCoroutine(StartCountdown());
                SkillTree.skillTreeSpecial4Double += 25;
            }

            treasurePotionActive = true;
            changeItemUpdate = true;
            SpawnRewards.changeDropChanceValues = true;
        }
    }

    private System.Collections.IEnumerator StartCountdown()
    {
        while (treasurePotionCountdownTime > 0)
        {
            treasurePotionCountdownText.text = Mathf.Round(treasurePotionCountdownTime).ToString();
            treasurePotionTimerrText.text = Localization.forTheNext + "<color=green>" + Mathf.Round(treasurePotionCountdownTime).ToString() + "<color=white>" + Localization.seconds;

            treasurePotionIcon.SetActive(true);

            yield return new WaitForSeconds(1f);
            treasurePotionCountdownTime -= 1f;
        }

        treasurePotionIcon.SetActive(false);
        treasurePotionHover.SetActive(false);

        treasurePotionActive = false;
        treasurePotionCountdownBar.SetActive(false);

        treasurePotionChance = 0;
        SkillTree.skillTreeSpecial4Double -= 25;

        SpawnRewards.changeDropChanceValues = true;
        treasurePotionUpgrade.GetComponent<Button>().interactable = true;
    }

    #endregion



    #endregion

    //Sound effects
    #region clickBarrel
    public void ClickBarrel()
    {
        if(PlaceMobileButtons.isMobile == true)
        {
            if (ToolTipUpgrades.isBucketFrameOpen == false) { return; }
        }

        if (barrelOfGoldAmountDouble == 0)
        {
            bucketGoldAmountText.text = TotalGoldAmount.FormatCoinsDoubleOneLetter(barrelOfGoldAmountDouble) + "<color=red> " + Localization.gold;
            if (AudioManager.audioMuted == 1) { audioManager.Play("Error"); }
        }
        else { if (AudioManager.audioMuted == 1) { audioManager.Play("BarrelEmpty"); } }

        Stats.barrelOfGoldTotal += barrelOfGoldAmountDouble;
        totalGoldHigher += barrelOfGoldAmountDouble;

        barrelOfGoldAmountDouble = 0;

        changeBarrelTexture = true;
    }
    #endregion

    #region sound effects
    public void PurchaseItemSound()
    {
        if (AudioManager.audioMuted == 1) { audioManager.Play("PurchaseSound"); }
    }

    public void CantAfford()
    {
        if (AudioManager.audioMuted == 1) { audioManager.Play("Error"); }
    }

    public void UpgradeSound()
    {
        int random = Random.Range(1, 4);
        if (random == 1) { if (AudioManager.audioMuted == 1) { audioManager.Play("LevelUp"); } }
        if (random == 2) { if (AudioManager.audioMuted == 1) { audioManager.Play("LevelUp2"); } }
        if (random == 3) { if (AudioManager.audioMuted == 1) { audioManager.Play("LevelUp3"); } }
    }

    public void UseItemSound()
    {
        if (AudioManager.audioMuted == 1) { audioManager.Play("UseItem"); }
    }
    #endregion


    public void ResetPrestigeUpgredes()
    {
        reinforcedLocks[0].SetActive(true); reinforcedIcons[0].SetActive(false);
        reinforcedLocks[1].SetActive(true); reinforcedIcons[1].SetActive(false);
        reinforcedLocks[2].SetActive(true); reinforcedIcons[2].SetActive(false);
        reinforcedLocks[3].SetActive(true); reinforcedIcons[3].SetActive(false);

        greaterLootLocks[0].SetActive(true); greaterLootIcons[0].SetActive(false);
        greaterLootLocks[1].SetActive(true); greaterLootIcons[1].SetActive(false);
        greaterLootLocks[2].SetActive(true); greaterLootIcons[2].SetActive(false);
        greaterLootLocks[3].SetActive(true); greaterLootIcons[3].SetActive(false);

        newChestsLocks[0].SetActive(true); newChestsIcons[0].SetActive(false);
        newChestsLocks[1].SetActive(true); newChestsIcons[1].SetActive(false);
        newChestsLocks[2].SetActive(true); newChestsIcons[2].SetActive(false);
        newChestsLocks[3].SetActive(true); newChestsIcons[3].SetActive(false);
        newChestsLocks[4].SetActive(true); newChestsIcons[4].SetActive(false);

        Color newColorBasic;
        ColorUtility.TryParseHtmlString(basicHexValue, out newColorBasic);

        reinforcedUpgrades[0].GetComponent<Image>().color = newColorBasic;
        reinforcedUpgrades[1].GetComponent<Image>().color = newColorBasic;
        reinforcedUpgrades[2].GetComponent<Image>().color = newColorBasic;
        reinforcedUpgrades[3].GetComponent<Image>().color = newColorBasic;
        reinforcedUpgrades[4].GetComponent<Image>().color = newColorBasic;

        greaterLootUpgrades[0].GetComponent<Image>().color = newColorBasic;
        greaterLootUpgrades[1].GetComponent<Image>().color = newColorBasic;
        greaterLootUpgrades[2].GetComponent<Image>().color = newColorBasic;
        greaterLootUpgrades[3].GetComponent<Image>().color = newColorBasic;
        greaterLootUpgrades[4].GetComponent<Image>().color = newColorBasic;

        newChestsUpgrades[0].GetComponent<Image>().color = newColorBasic;
        newChestsUpgrades[1].GetComponent<Image>().color = newColorBasic;
        newChestsUpgrades[2].GetComponent<Image>().color = newColorBasic;
        newChestsUpgrades[3].GetComponent<Image>().color = newColorBasic;
        newChestsUpgrades[4].GetComponent<Image>().color = newColorBasic;
        newChestsUpgrades[5].GetComponent<Image>().color = newColorBasic;

        SetAlphaHalf(reinforcedUpgrades[0], alphaHalf);
        SetAlphaHalf(reinforcedUpgrades[1], alphaHalf);
        SetAlphaHalf(reinforcedUpgrades[2], alphaHalf);
        SetAlphaHalf(reinforcedUpgrades[3], alphaHalf);
        SetAlphaHalf(reinforcedUpgrades[4], alphaHalf);

        SetAlphaHalf(greaterLootUpgrades[0], alphaHalf);
        SetAlphaHalf(greaterLootUpgrades[1], alphaHalf);
        SetAlphaHalf(greaterLootUpgrades[2], alphaHalf);
        SetAlphaHalf(greaterLootUpgrades[3], alphaHalf);
        SetAlphaHalf(greaterLootUpgrades[4], alphaHalf);

        SetAlphaHalf(newChestsUpgrades[0], alphaHalf);
        SetAlphaHalf(newChestsUpgrades[1], alphaHalf);
        SetAlphaHalf(newChestsUpgrades[2], alphaHalf);
        SetAlphaHalf(newChestsUpgrades[3], alphaHalf);
        SetAlphaHalf(newChestsUpgrades[4], alphaHalf);
        SetAlphaHalf(newChestsUpgrades[5], alphaHalf);

        reinforcedButtons[0].interactable = true;
        reinforcedButtons[1].interactable = true;
        reinforcedButtons[2].interactable = true;
        reinforcedButtons[3].interactable = true;
        reinforcedButtons[4].interactable = true;

        greaterLootButtons[0].interactable = true;
        greaterLootButtons[1].interactable = true;
        greaterLootButtons[2].interactable = true;
        greaterLootButtons[3].interactable = true;
        greaterLootButtons[4].interactable = true;

        newChestsButtons[0].interactable = true;
        newChestsButtons[1].interactable = true;
        newChestsButtons[2].interactable = true;
        newChestsButtons[3].interactable = true;
        newChestsButtons[4].interactable = true;
        newChestsButtons[5].interactable = true;

        reinforcedUnlocked[0].SetActive(false);
        reinforcedUnlocked[1].SetActive(false);
        reinforcedUnlocked[2].SetActive(false);
        reinforcedUnlocked[3].SetActive(false);
        reinforcedUnlocked[4].SetActive(false);

        greaterLootUnlocked[0].SetActive(false);
        greaterLootUnlocked[1].SetActive(false);
        greaterLootUnlocked[2].SetActive(false);
        greaterLootUnlocked[3].SetActive(false);
        greaterLootUnlocked[4].SetActive(false);

        newChestsUnlocked[0].SetActive(false);
        newChestsUnlocked[1].SetActive(false);
        newChestsUnlocked[2].SetActive(false);
        newChestsUnlocked[3].SetActive(false);
        newChestsUnlocked[4].SetActive(false);
        newChestsUnlocked[5].SetActive(false);
    }

    private void SetAlphaHalf(Graphic graphic, float alpha)
    {
        Color currentColor = graphic.color;
        currentColor.a = alpha;
        graphic.color = currentColor;
    }


    public void ResetUpdateGame()
    {
        goldBuffAmount = 0;
        XPBuffAmount = 0;
        damageBuffAmount = 0;
        treasureDropBuffAmount = 0;
        goldCoinBuffAmount = 0;

        goldDebuffAmount = 0;
        XPDebuffAmount = 0;
        damageDebuffAmount = 0;
        treasureDebuffAmount = 0;
        goldCoinDebuffAmount = 0;

        realBarrel.SetActive(false); fakfeBarrel.SetActive(false); barrelDrag.SetActive(false);

        negativeGoldIcon.SetActive(false);
        negativeDamageIcon.SetActive(false);
        negativeXPIcon.SetActive(false);
        negativeTreasureIcon.SetActive(false);
        negativeGoldCoinIcon.SetActive(false);
        positiveGoldIcon.SetActive(false);
        positiveDamageIcon.SetActive(false);
        positiveXPIcon.SetActive(false);
        positiveTreasureIcon.SetActive(false);
        positiveCoinDropIcon.SetActive(false);
        treasurePotionIcon.SetActive(false);
        rareTreasureBuffIcon.SetActive(false);

        knifeLocked.SetActive(false);
        barrelLocked.SetActive(false);
        treasurePotionLocked.SetActive(false);
        mimicChestLocked.SetActive(false);
        itemBarKnifeLocked.SetActive(true);
        itemBarTreasurEPotionLocked.SetActive(true);

        treasurePotionHover.SetActive(false);

        treasurePotionUpgrade.GetComponent<Button>().interactable = true;
        knifeUpgrade.GetComponent<Button>().interactable = true;

        treasurePotionActive = false;
        treasurePotionCountdownBar.SetActive(false);

        treasurePotionChance = 0;
        if(SkillTree.skillTreeSpecial4Double > 10) { SkillTree.skillTreeSpecial4Double -= 25; }
          


        KnifeActive = false;
        knifeCountdownBar.SetActive(false);

        treasurePotionCount = 0;
        knifeCount = 0;

        treasurePotionCounText.text = "0";
        knifeCountText.text = "0";


        SpawnRewards.changeDropChanceValues = true;
        StopAllCoroutines();
    }
}
