using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class Stats : MonoBehaviour, IDataPersistence
{
    public GameObject statsAndAchBar,settingBar;

    public void Start()
    {
        Invoke("wait", 0.4f);
    }

    public void wait()
    {
        string path = Application.persistentDataPath + "/player.saveStats";

        if (File.Exists(path))
        {
            //Load Auto Damage
            if (SaveAndLoad.onlyLoadNewSave == false)
            {
                GameData data = SaveSystem.LoadStats();
                goldCoinsDropped = data.totalGoldCoins;
                treasuresDropped = data.totalTreasures;
                treasuresDoubled = data.treasuresDoubled;
                totalGoldRecieved = data.totalGoldRecieved;

                chestOpened = data.chestsOpened;
                reinforedChestsOpened = data.reinforcedChestsOpened;

                chestClicks = data.chestClicks;
                autoClicks = data.autoClicks;
                criticalHits = data.criticalHits;
                cursorUpgraded = data.cursorUpgraded;
                coinsSpawnedFromClicks = data.coinsSpawnedFromClicks;
                treasuredSpawnedFromClicks = data.treasuredSpawnedFromClicks;

                itemsUsed = data.itemsUsed;
                itemsDropped = data.itemsDropped;
                itemsPurchased = data.itemsPurchased;
                itemsUpgraded = data.itemsUpgraded;

                treasureDropChanceIncrease = data.treasureDropChanceIncrease;
                goldCoin5XDropped = data.goldCoin5XDropped;
                goldCoins10XDropped = data.goldCoins10XDropped;

                rareTreasuresFound = data.rareTreasureFound;

                totalSkillPoints = data.totalSkillPoints;

                commonTreasureDrops = data.commonTreasures;
                uncommonTreasureDrops = data.uncommonTreasures;
                rareTreasureDrops = data.rareTreasures;
                veryRareTreasureDrops = data.veryRareTreasures;
                extremelyRareTreasureDrops = data.extremelyRareTreasures;
                legendaryTreasureDrops = data.legendaryTreasures;

                prestigedTimesCount = data.prestigedTimesCount;
                prestigeUpgradesPurchased = data.prestigeUpgradesPurchased;
                clickerUpgradePurchased = data.clickerUpgradePurchased;
                loungerUpgradesPurchased = data.loungerUpgradesPurchased;
                pirateUpgradesPurchased = data.pirateUpgradesPurchased;
                hoarderUpgradeesPurchased = data.hoarderUpgradeesPurchased;

                totalGoldStatsDouble = totalGoldRecieved;
            }
            else { }
        }
        else
        {
            //Do nothing
        }

    }

    #region saveAndLoad
    public void LoadData(GameDataJSON data)
    {
        goldCoinsDropped = data.totalGoldCoins;
        treasuresDropped = data.totalTreasures;
        treasuresDoubled = data.treasuresDoubled;
        totalGoldRecieved = data.totalGoldRecieved;

        chestOpened = data.chestsOpened;
        reinforedChestsOpened = data.reinforcedChestsOpened;

        chestClicks = data.chestClicks;
        autoClicks = data.autoClicks;
        criticalHits = data.criticalHits;
        cursorUpgraded = data.cursorUpgraded;
        coinsSpawnedFromClicks = data.coinsSpawnedFromClicks;
        treasuredSpawnedFromClicks = data.treasuredSpawnedFromClicks;

        itemsUsed = data.itemsUsed;
        itemsDropped = data.itemsDropped;
        itemsPurchased = data.itemsPurchased;
        itemsUpgraded = data.itemsUpgraded;

        treasureDropChanceIncrease = data.treasureDropChanceIncrease;
        goldCoin5XDropped = data.goldCoin5XDropped;
        goldCoins10XDropped = data.goldCoins10XDropped;

        rareTreasuresFound = data.rareTreasureFound;

        totalSkillPoints = data.totalSkillPoints;

        commonTreasureDrops = data.commonTreasures;
        uncommonTreasureDrops = data.uncommonTreasures;
        rareTreasureDrops = data.rareTreasures;
        veryRareTreasureDrops = data.veryRareTreasures;
        extremelyRareTreasureDrops = data.extremelyRareTreasures;
        legendaryTreasureDrops = data.legendaryTreasures;

        prestigedTimesCount = data.prestigedTimesCount;
        prestigeUpgradesPurchased = data.prestigeUpgradesPurchased;
        clickerUpgradePurchased = data.clickerUpgradePurchased;
        loungerUpgradesPurchased = data.loungerUpgradesPurchased;
        pirateUpgradesPurchased = data.pirateUpgradesPurchased;
        hoarderUpgradeesPurchased = data.hoarderUpgradeesPurchased;

        totalGoldStatsDouble = data.totalGoldAmountStatsNew;

        enchantedGoldenChestsOpened = data.enchantedGoldenChestsOpened;
        bossChestOpened = data.bossChestOpened;
        goldCoin25XDropped = data.goldCoin25XDropped;
        goldCoin100XDropped = data.goldCoin100XDropped;
        ultraTreasures = data.ultraTreasures;
        mythicTreasures = data.mythicTreasures;
        eternalTreasures = data.eternalTreasures;
        adventurereUpgradesPurchased = data.adventurereUpgradesPurchased;
        barrelOfGoldTotal = data.barrelOfGoldTotal;
    }

    public void SaveData(ref GameDataJSON data)
    {
        data.totalGoldCoins = goldCoinsDropped;
        data.totalTreasures = treasuresDropped;
        data.treasuresDoubled = treasuresDoubled;
        data.totalGoldRecieved = totalGoldRecieved;

        data.chestsOpened = chestOpened;
        data.reinforcedChestsOpened = reinforedChestsOpened;

        data.chestClicks = chestClicks;
        data.autoClicks = autoClicks;
        data.criticalHits = criticalHits;
        data.cursorUpgraded = cursorUpgraded;
        data.coinsSpawnedFromClicks = coinsSpawnedFromClicks;
        data.treasuredSpawnedFromClicks = treasuredSpawnedFromClicks;

        data.itemsUsed = itemsUsed;
        data.itemsDropped = itemsDropped;
        data.itemsPurchased = itemsPurchased;
        data.itemsUpgraded = itemsUpgraded;

        data.treasureDropChanceIncrease = treasureDropChanceIncrease;
        data.goldCoin5XDropped = goldCoin5XDropped;
        data.goldCoins10XDropped = goldCoins10XDropped;

        data.rareTreasureFound = rareTreasuresFound;

        data.totalSkillPoints = totalSkillPoints;

        data.commonTreasures = commonTreasureDrops;
        data.uncommonTreasures = uncommonTreasureDrops;
        data.rareTreasures = rareTreasureDrops;
        data.veryRareTreasures = veryRareTreasureDrops;
        data.extremelyRareTreasures = extremelyRareTreasureDrops;
        data.legendaryTreasures = legendaryTreasureDrops;

        data.prestigedTimesCount = prestigedTimesCount;
        data.prestigeUpgradesPurchased = prestigeUpgradesPurchased;
        data.clickerUpgradePurchased = clickerUpgradePurchased;
        data.loungerUpgradesPurchased = loungerUpgradesPurchased;
        data.pirateUpgradesPurchased = pirateUpgradesPurchased;
        data.hoarderUpgradeesPurchased = hoarderUpgradeesPurchased;

        data.totalGoldAmountStatsNew = totalGoldStatsDouble;

        data.enchantedGoldenChestsOpened =enchantedGoldenChestsOpened;
        data.bossChestOpened = bossChestOpened;
        data.goldCoin25XDropped = goldCoin25XDropped;
        data.goldCoin100XDropped = goldCoin100XDropped;
        data.ultraTreasures = ultraTreasures;
        data.mythicTreasures = mythicTreasures;
        data.eternalTreasures =eternalTreasures;
        data.adventurereUpgradesPurchased = adventurereUpgradesPurchased;
        data.barrelOfGoldTotal = barrelOfGoldTotal;
    }
    #endregion

    public void Update()
    {
        if(statsScreenOpen == true)
        {
            SetStats();
        }
    }


    public void OpenStatsAndAch()
    {
        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("UIClick1"); }
        if (statsAndAchBar.activeInHierarchy == true) { statsAndAchBar.SetActive(false); statsScreenOpen = false;
            UIelementsClick.hideCursors = false;
        }
        else if (statsAndAchBar.activeInHierarchy == false)
        {
            statsAndAchBar.SetActive(true); statsScreenOpen = true;
            UIelementsClick.hideCursors = true;
        }

        settingBar.SetActive(false);
    }

    public static bool statsScreenOpen;
    public TextMeshProUGUI goldCoinsDroppedText, totalGoldAmountText, treasuresDroppedText, tresuresDoubledText, barrelOfGoldTotalText ;
    public TextMeshProUGUI chestsOpenedText, reinforcedChestsOpenedText, enchantedGoldenChestsOpenedText, bossChestOpenedText;
    public TextMeshProUGUI chestClicksText, autoClicksText, criticalHitsText, activeDamageText, passiveDamageText, critChanceText, critDamageText, cursorUpgradedText, coinsFromCliksText, treasuresFromClicksText;
    public TextMeshProUGUI itemsUsedText, itemsDroppedText, itemsPurchasedText, itemsUpgradedText;
    public TextMeshProUGUI goldIncreaseText, xpIncreaseText, activeDamageIncraseText, passiveDamageIncreaseText, critChanceIncreaseText, critDamageIncreaseText, treasureChanceIncreaseText, amount5XCoinsText, amount10XCoinsText, amount25XCoinsText, amount100XCoinsText;
    public TextMeshProUGUI commonTreasuresText, uncommonTreasuresText, rareTreasuresText, veryRareTreasuresText, extremelyRareTreasuresText, legendaryTreasuresText, ultraTressuresText, mythicTreasuresText, eternalTreasuresText;
    public TextMeshProUGUI skillPointsRecievedText, timesPrestigedText, prestigeUpgradesPurchasedText;


    public static int goldCoinsDropped, treasuresDropped, treasuresDoubled;
    public static float totalGoldRecieved;
    public static int chestOpened, reinforedChestsOpened, enchantedGoldenChestsOpened, bossChestOpened;
    public static int chestClicks, autoClicks, criticalHits, cursorUpgraded, coinsSpawnedFromClicks, treasuredSpawnedFromClicks;
    public static double activeDamage, passiveDamage, critChance, critDamage;
    public static int itemsUsed, itemsDropped, itemsPurchased, itemsUpgraded;
    public static float goldIncrease, XPIncrease, activeDamageIncrease, passiveDamageIncrease, critChanceIncrease, critDamageIncrease, treasureDropChanceIncrease;
    public static int goldCoin5XDropped, goldCoins10XDropped, goldCoin25XDropped, goldCoin100XDropped;
    public static int totalSkillPoints;
    public static int commonTreasureDrops, uncommonTreasureDrops, rareTreasureDrops, veryRareTreasureDrops, extremelyRareTreasureDrops, legendaryTreasureDrops, ultraTreasures, mythicTreasures, eternalTreasures;
    public static int rareTreasuresFound;
    public static int prestigedTimesCount, prestigeUpgradesPurchased, clickerUpgradePurchased, loungerUpgradesPurchased, pirateUpgradesPurchased, hoarderUpgradeesPurchased, adventurereUpgradesPurchased;

    public static double totalGoldStatsDouble, barrelOfGoldTotal;

    public void SetStats()
    {
        activeDamage = (ClickPower.newActiveDamage) * (1 + ClickPower.activeDamageMultiplier + SkillTree.skillTreeActiveDamage + RareTreasures.swordActive + RareTreasures.guitarActiveAndPassive + RareTreasures.cookieActive + UseConsumable.scrollActiveDamageBuff + UseConsumable.relicPermaActiveDamage);

        passiveDamage = (HealthBar.newPassiveDamage) * (1 + ClickPower.passiveDamageMultiplier  + SkillTree.skillTreePassiveDamage + RareTreasures.skullPassiveDamage + RareTreasures.guitarActiveAndPassive + RareTreasures.talariaPassive + RareTreasures.cookiePassive + UseConsumable.scrollPassiveDamageBuff + UseConsumable.relicPermaPassiveDamage);

        critChance = (ClickPower.critChance + SkillTree.skillTreeCritChance + UseConsumable.scrollCritChanceBuff + RareTreasures.cookieCritChance + RareTreasures.swordCrit + UseConsumable.relicPermaCritChance);

        critDamage = (ClickPower.critDamage + SkillTree.skillTreeCritDamage + RareTreasures.cookieCritDamage + UseConsumable.scrollCritDamageBuff + UseConsumable.relicPermaCritDamage);

        goldIncrease = SkillTree.skillTreeGold + RareTreasures.runeGold + RareTreasures.cookieGold + RareTreasures.backPackGold + UseConsumable.scrollGoldBuff + UseConsumable.relicPermaGoldBuff;

        XPIncrease =  SkillTree.skillTreeXP + RareTreasures.backPackXP + RareTreasures.cookieXP + UseConsumable.scrollXPBuff + UseConsumable.relicPermaXPBuff;

        activeDamageIncrease = SkillTree.skillTreeActiveDamage + RareTreasures.swordActive + RareTreasures.guitarActiveAndPassive + RareTreasures.cookieActive + UseConsumable.scrollActiveDamageBuff + UseConsumable.relicPermaActiveDamage;

        passiveDamageIncrease =SkillTree.skillTreePassiveDamage + RareTreasures.skullPassiveDamage + RareTreasures.guitarActiveAndPassive + RareTreasures.talariaPassive + RareTreasures.cookiePassive + UseConsumable.scrollPassiveDamageBuff + UseConsumable.relicPermaPassiveDamage;

        critChanceIncrease =  SkillTree.skillTreeCritChance + UseConsumable.scrollCritChanceBuff + RareTreasures.cookieCritChance + RareTreasures.swordCrit + UseConsumable.relicPermaCritChance;

        critDamageIncrease = SkillTree.skillTreeCritDamage + RareTreasures.cookieCritDamage + UseConsumable.scrollCritDamageBuff + UseConsumable.relicPermaCritDamage;

        //Gold and treasures
        goldCoinsDroppedText.text = Localization.goldCoinsDropped + "<color=green>" + goldCoinsDropped;
        totalGoldAmountText.text = Localization.totalGoldReceived + "<color=green>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(totalGoldStatsDouble);
        barrelOfGoldTotalText.text = Localization.totalBarrelGold + "<color=green>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(barrelOfGoldTotal);
        treasuresDroppedText.text = Localization.treasuresDropped + "<color=green>" + treasuresDropped;
        commonTreasuresText.text = Localization.commonTreasures + "<color=green>" + commonTreasureDrops;
        uncommonTreasuresText.text = Localization.uncommonTreasures + "<color=green>" + uncommonTreasureDrops;
        rareTreasuresText.text = Localization.rareTreasures + "<color=green>" + rareTreasureDrops;
        veryRareTreasuresText.text = Localization.veryRareTreasures + "<color=green>" + veryRareTreasureDrops;
        extremelyRareTreasuresText.text = Localization.extremelyRareTreasures + "<color=green>" + extremelyRareTreasureDrops;
        legendaryTreasuresText.text = Localization.legendaryTreasures + "<color=green>" + legendaryTreasureDrops;
        ultraTressuresText.text = Localization.ultraTreasures + "<color=green>" + ultraTreasures;
        mythicTreasuresText.text = Localization.mythicTreasures + "<color=green>" + mythicTreasures;
        eternalTreasuresText.text = Localization.eternalTreasures + "<color=green>" + eternalTreasures;
        tresuresDoubledText.text = Localization.treasuresDoubled + "<color=green>" + treasuresDoubled;

        //Chests
        chestsOpenedText.text = Localization.chestsOpened + "<color=green>" + chestOpened;
        reinforcedChestsOpenedText.text = Localization.reinforcedChestsOpened + "<color=green>" + reinforedChestsOpened;
        enchantedGoldenChestsOpenedText.text = Localization.enchantedGoldenChestsOpened + "<color=green>" + enchantedGoldenChestsOpened;
        bossChestOpenedText.text = Localization.bossChestsOpened + "<color=green>" + bossChestOpened;

        //Damage
        chestClicksText.text = Localization.chestClicks + "<color=green>" + chestClicks;
        autoClicksText.text = Localization.autoClicks + "<color=green>" + autoClicks;
        criticalHitsText.text = Localization.criticalHits + "<color=green>" + criticalHits;
        activeDamageText.text = Localization.activeDamage + "<color=green>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(activeDamage);
        passiveDamageText.text = Localization.passiveDamage + "<color=green> " + TotalGoldAmount.FormatCoinsDoubleOneLetter(passiveDamage);
        critChanceText.text = Localization.critChance + "<color=green>" + critChance.ToString("F2") + "%";
        critDamageText.text = Localization.critDamage + "<color=green>" + (critDamage * 100).ToString("F0") + "%";
        cursorUpgradedText.text = Localization.cursorsLeveledUp + "<color=green>" + cursorUpgraded;
        coinsFromCliksText.text = Localization.coinsSpawnedFromClicks + "<color=green>" + coinsSpawnedFromClicks;
        treasuresFromClicksText.text = Localization.treasuresSpawnedFromClicks + "<color=green> " + treasuredSpawnedFromClicks;

        //Items
        itemsUsedText.text = Localization.itemsUsed + "<color=green> " + itemsUsed;
        itemsDroppedText.text = Localization.itemsDropped + "<color=green>" + itemsDropped;
        itemsPurchasedText.text = Localization.itemsPurchased + "<color=green>" + itemsPurchased;
        itemsUpgradedText.text = Localization.itemsLeveledUp + "<color=green>" + itemsUpgraded;

        //Buffs
        timesPrestigedText.text = Localization.prestigeCount + "<color=green>" + prestigedTimesCount;
        prestigeUpgradesPurchasedText.text = Localization.prestigeUpgradesPurchased + "<color=green>" + prestigeUpgradesPurchased;
        skillPointsRecievedText.text = Localization.skillPointsReceived + "<color=green>" + totalSkillPoints;
        goldIncreaseText.text = Localization.goldIncrease + "<color=green>" + (goldIncrease * 100).ToString("F0") + "%";
        xpIncreaseText.text = Localization.xpIncrease + "<color=green>" + (XPIncrease * 100 ).ToString("F0") + "%";
        activeDamageIncraseText.text = Localization.activeDamageIncrease + "<color=green>" + (activeDamageIncrease *100).ToString("F0") + "%";
        passiveDamageIncreaseText.text = Localization.passiveDamageIncrease + "<color=green>" + (passiveDamageIncrease * 100).ToString("F0") + "%";
        critChanceIncreaseText.text = Localization.critChanceIncrease + "<color=green>" + critChanceIncrease.ToString("F2") + "%";
        critDamageIncreaseText.text = Localization.critDamageIncrease + "<color=green>" + (critDamageIncrease * 100).ToString("F0") + "%";
        treasureChanceIncreaseText.text = Localization.treasureChanceIncrease + "<color=green>" + treasureDropChanceIncrease.ToString("F2") + "%";
        amount5XCoinsText.text = Localization.goldCoins5xDropped + "<color=green>" + goldCoin5XDropped;
        amount10XCoinsText.text = Localization.goldCoins10xDropped + "<color=green>" + goldCoins10XDropped;
        amount25XCoinsText.text = Localization.goldCoins25xDropped + "<color=green>" + goldCoin25XDropped;
        amount100XCoinsText.text = Localization.goldCoins100xDropped + "<color=green>" + goldCoin100XDropped;
    }

   

}
