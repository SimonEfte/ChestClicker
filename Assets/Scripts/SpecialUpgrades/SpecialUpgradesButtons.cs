using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class SpecialUpgradesButtons : MonoBehaviour, IDataPersistence
{
    public static int lockPickGemPrice, keyGemUpgradePrice, hammerGemUpgradePrice, goldenTouchGemPrice;
    public static float lockPickPurchasePrice, keyPurchasePrice, hammerPurchasePrice, goldenTouchPurchasePrice;
    public static int lockPickBoughtFirstTime, keyBoughtFirstTime, hammerBoughtFirstTime, goldenTouchBoughtFirstTime, treasureBagBoughtFirstTime, XPPotionBoughtFirstTime, damagePotionBoughtFirstTime, lootPotionBoughtFirstTime, miniChestBoughtFirstTime, elixirBoughtFirstTime, scrollBoughtFirstTime, gauntletBoughtFirstTime, relicBoughtFirstTime;

    public GameObject lockedKeys, lockedHammer, lockedGoldenToutch, lockedLockPick, lockedTreasureBag, lockedLootPotion, lockedDamagePotion, lockedXPPotion, lockedElixir, lockedScroll, lockedGauntlet, lockedRelic, lockedTreasurePotion, lockedEnchantedHammer;
    public TextMeshProUGUI keysPriceText, keyGamePriceText;
    public TextMeshProUGUI hammerPriceText, hammerGemPriceText;
    public TextMeshProUGUI goldenTouchPriceText, goldenTouchGemPriceText;
    public TextMeshProUGUI lockPickPriceText, lockPickGemPriceText;

    public GameObject treasurePotionLocked, enchantedHammerLocked, barrelLocked, mimicChestLocked;

    public static bool specialTextChange;
    public static bool changeText;

    public GameObject hammerUpgrade, keyUpgrade, goldenTouchUpgrade;

    public static double newLockPickPrice, newHammerPrice, newLootPotionPrice, newDamagePotionPrice, newXPPotionPrice, newGoldenTouchPrice, newMiniChestPrice, newkeyPrice, newTreasureBagPrice, newScrollPrice, newGauntletPrice, newElixirPRice, newRelicPrice;

    public static bool isHoldingMax;
    public GameObject holdingMaxText;
    public float alphaValueFull, alphavalueHalf;

    public AudioManager audioManager;

    public void Start()
    {
        alphaValueFull = 1f; alphavalueHalf = 0.45f;

        StartCoroutine(waitwait());
        isHoldingMax = false;
    }

    IEnumerator waitwait()
    {
        yield return new WaitForSeconds(0.35f);
        if(PlaceMobileButtons.isMobile == true) { holdingMaxText.GetComponent<TextMeshProUGUI>().text = "PURCHASING 1X"; }
        startMiniChest = false;

        #region load saves
        string path = Application.persistentDataPath + "/player.saveSpecialUpgrades";

        if (File.Exists(path))
        {
            if (SaveAndLoad.onlyLoadNewSave == false)
            {
                GameData data = SaveSystem.LoadSpecialUpgrades();

                lockPickLevel = data.lockPickLevel;
                hammerLevel = data.hammerLevel;
                keyLevel = data.keyLevel;
                goldenTouchLevel = data.goldenTouchLevel;
                treasureBagLevel = data.treasureBagLevel;
                XPPotionLevel = data.xpPotionLevel;
                damagePotionLevel = data.damagePotionLevel;
                lootPotionLevel = data.lootPotionLevel;
                miniChestLevel = data.miniChestLevel;
                elixirLevel = data.elixirLevel;
                scrollLevel = data.scrollLevel;
                gauntletLevel = data.gauntletLevel;
                relicLevel = data.relicLevel;

                keyGemUpgradePrice = data.keyGemPrice;
                hammerGemUpgradePrice = data.hammerGemPrice;
                goldenTouchGemPrice = data.goldenTouchGemPrice;
                lockPickGemPrice = data.lockPickgemPrice;
                treasureBagGemPrice = data.treasurebagGemPrice;
                XPPotionGemPrice = data.xpPotionGemPrice;
                damagePotionGemPrice = data.damagePotionGemPrice;
                lootPotionGemPrice = data.lootPotionGemPrice;
                miniChestGemPrice = data.miniChestGemPrice;
                elixirGemPrice = data.elixirGemPrice;
                scrollGemPrice = data.scrollGemPrice;
                gauntletGemPrice = data.gauntletGemPrice;
                relicGemPrice = data.relicGemPrice;
                relicGemPrice2 = data.relicGemPrice2;

                lockPickPurchasePrice = data.lockPickPrice;
                keyPurchasePrice = data.keyPrice;
                hammerPurchasePrice = data.hammerPrice;
                goldenTouchPurchasePrice = data.goldenTouchPrice;
                treasureBagBuyPrice = data.treasureBagPrice;
                XPPotionBuyPrice = data.xpPotionPrice;
                damagePotionBuyPrice = data.damagePotionPrice;
                lootPotionBuyPrice = data.lootPotionPrice;
                miniChestBuyPrice = data.miniChestPrice;
                elixirBuyPrice = data.elixirPrice;
                scrollBuyPrice = data.scrollPrice;
                gauntletBuyPrice = data.gauntletPrice;
                relicBuyPrice = data.relicPrice;

                keyBoughtFirstTime = data.keyBoughtFirstTime;
                hammerBoughtFirstTime = data.hammerBoughtFirstTime;
                goldenTouchBoughtFirstTime = data.goldenTouchBoughtFirstTime;
                lockPickBoughtFirstTime = data.lockPickBoughtFirstTime;
                treasureBagBoughtFirstTime = data.treasureBagBoughtFirstTime;
                XPPotionBoughtFirstTime = data.XPPotionBoughtFirstTime;
                damagePotionBoughtFirstTime = data.damagePotionBoughtFirstTime;
                lootPotionBoughtFirstTime = data.lootPotionBOughtFirstTime;
                miniChestBoughtFirstTime = data.miniChestBoughtFirsTTime;
                elixirBoughtFirstTime = data.elixirBoughtFirsTTime;
                scrollBoughtFirstTime = data.scrollBoughtFirsTTime;
                gauntletBoughtFirstTime = data.gauntletBoughtFirsTTime;
                relicBoughtFirstTime = data.relicBoughtFirsTTime;

                treasureBagDropChance = data.treasureBagDropChance;
                treasureBagDropChanceIncrement = data.treasureBagDropChanceIncrement;

                lockPickOpenChanceIncrement = data.lockPickOpenChanceIncrement;
                lockPickDropChance = data.lockPickDropChance;
                lockPickDropChanceIncrement = data.lockPickDropChanceIncrement;

                keyDropChance = data.keyDropChance;
                keyDropChanceIncrement = data.keyDropChanceIncrement;
                keyRareDropChance = data.keyRareDropChance;
                keyRareDropChanceIncrement = data.keyRareDropChanceIncrement;

                hammerDamageAmountIncrement = data.hammerDamageAmountIncrement;
                hammerTimer = data.hammerTimer;
                hammerTimerIncrement = data.hammerTimerIncrement;
                hammerDropChance = data.hammerDropChance;
                hammerDropChanceIncrement = data.hammerDropChanceIncrement;

                goldenTouchTimer = data.goldenTouchTimer;
                goldenTouchTimerIncrement = data.goldenTouchTimerIncrement;
                goldenTouchDropChance = data.goldenTouchDropChance;
                goldenTouchDropChanceIncrement = data.goldenTouchDropChanceIncrement;

                XPPotionDropChance = data.XPPotiondropChance;
                XPPotionDropChanceIncrement = data.XPPotiondropChanceIncrement;
                XPPotionXPBuff = data.xpPotionBuff;
                XPPotionBufFIncrement = data.xpPotionBuffIncrement;
                XPPotionTimer = data.xpPotionTimer;
                XPPotionTimerMinus = data.XPPotionTimerMinus;

                damagePotionBuff = data.damagePotionBuff;
                damagePotionBuffIncrement = data.damagePotionBuffIncrement;
                damagePotionTimer = data.damagePotionTimer;
                damagePotionTimerMinus = data.damagePotionTimerMinus;
                damagePotionDropChance = data.damagepotionDropChance;
                damagePotionDropChanceIncrement = data.damagepotionDropChanceIncrement;

                lootPotionBuff = data.lootPotionBuff;
                lootPotionBuffIncrement = data.lootPotionBuffIncrement;
                lootPotionTimer = data.lootPotionTimer;
                lootPotionTimerMinus = data.lootPotionTimerIncrement;
                lootPotionDropChance = data.lootPotionDropChance;
                lootPotionDropChanceIncrement = data.lootPotionDropChanceIncrement;

                miniChestSpawnTimer = data.miniChestTimer;
                miniChestSpawnTimerMinus = data.miniChestTimerIncrement;

                elixirDropChance = data.elixirDropChance;
                elixirDropChanceIncrement = data.elixirDropChanceIncrement;
                elixirBuff = data.elixirBuff;
                elixirBuffIncrement = data.elixirBuffIncrement;
                elixirTimer = data.elixirTimer;
                elixirTimerIncrement = data.elixirTimerIncrement;

                scrollTimer = data.scrollTimer;
                scrollTimerIncrement = data.scrollTimerIncrement;
                scrollDropChance = data.scrollDropChance;
                scrollDropChanceIncrement = data.scrollDropChanceIncrement;

                gauntletTimer = data.gauntletTimer;
                gauntletTimerIncrement = data.gauntletTimerIncrement;
                gauntletDropChance = data.gauntletDropChance;
                gauntletDropChanceIncrement = data.gauntletDropChanceIncrement;
                gauntletGoldDropChance = data.gauntletGoldDropChance;
                gauntletGoldDropChanceIncrement = data.gauntletGoldDropChanceIncrement;

                relicDropChance = data.relicDropChance;
                relicDropChanceIncrement = data.relicDropChanceIncrement;

                newLockPickPrice = lockPickPurchasePrice;
                newHammerPrice = hammerPurchasePrice;
                newLootPotionPrice = lootPotionBuyPrice;
                newDamagePotionPrice = damagePotionBuyPrice;
                newXPPotionPrice = XPPotionBuyPrice;
                newGoldenTouchPrice = goldenTouchPurchasePrice;
                newMiniChestPrice = miniChestBuyPrice;
                newkeyPrice = keyPurchasePrice;
                newTreasureBagPrice = treasureBagBuyPrice;
                newScrollPrice = scrollBuyPrice;
                newGauntletPrice = gauntletBuyPrice;
                newElixirPRice = elixirBuyPrice;
                newRelicPrice = relicBuyPrice;
            }
            else { }
        }
        else
        {
            //Do nothing
        }
        #endregion

        UseConsumable.hammerDamage = 0;
        if (lockPickBoughtFirstTime == 1) { lockedLockPick.SetActive(false); SetHammerUpgrade(); }
        if (hammerBoughtFirstTime == 1) { lockedHammer.SetActive(false); SetLootPotionUpgrade(); }
        if (lootPotionBoughtFirstTime == 1) { lockedLootPotion.SetActive(false); SetDamagePotionUpgrade(); }
        if (damagePotionBoughtFirstTime == 1) { lockedDamagePotion.SetActive(false); SetXPPotionUpgrade(); }
        if (XPPotionBoughtFirstTime == 1) { lockedXPPotion.SetActive(false); SetGoldenTouchUpgrade(); }
        if (goldenTouchBoughtFirstTime == 1) { lockedGoldenToutch.SetActive(false); SetMiniChestUpgrace(); }
        if (miniChestBoughtFirstTime == 1) { SetKeyUpgrade(); StartCoroutine(miniChest()); }
        if (keyBoughtFirstTime == 1) { lockedKeys.SetActive(false); SetTreasureBagUpgrade(); }
        if (treasureBagBoughtFirstTime == 1) { lockedTreasureBag.SetActive(false); SetBarrel(); }
        if (UpdateGame.barrelBoughtFirstTime == 1) {  SetScrollUpgrade(); }
        if (scrollBoughtFirstTime == 1) { lockedScroll.SetActive(false); SetMimicChest(); }
        if (UpdateGame.mimicChestBoughtFirstTime == 1) { SetGauntletUpgrade(); }
        if (gauntletBoughtFirstTime == 1) { lockedGauntlet.SetActive(false); SetElixirUpgrade(); }
        if (elixirBoughtFirstTime == 1) { lockedElixir.SetActive(false); SetRelicUpgrade(); }
        if (relicBoughtFirstTime == 1) { lockedRelic.SetActive(false); SetTreasurePotionUpgrade(); }
        if (UpdateGame.treasurePotionBoughtFirstTime == 1) { lockedTreasurePotion.SetActive(false); SetEnchantedHammer(); }
        if (UpdateGame.knifeBoughtFirstTime == 1) { lockedEnchantedHammer.SetActive(false); }

        if (UseConsumable.hammerCount > 0) { lockedHammer.SetActive(false); }
        if (UseConsumable.lootPotionCount > 0) { lockedLootPotion.SetActive(false); }
        if (UseConsumable.damagePotioncount > 0) { lockedDamagePotion.SetActive(false); }
        if (UseConsumable.XPPotionCount > 0) { lockedXPPotion.SetActive(false); }
        if (UseConsumable.goldenTouchCount > 0) { lockedGoldenToutch.SetActive(false); }
        if (UseConsumable.KeysCount > 0) { lockedKeys.SetActive(false); }
        if (UseConsumable.treasureBagCount > 0) { lockedTreasureBag.SetActive(false); }
        if (UseConsumable.scrollCount > 0) { lockedScroll.SetActive(false); }
        if (UseConsumable.gauntletCount > 0) { lockedGauntlet.SetActive(false); }
        if (UseConsumable.elixirCount > 0) { lockedElixir.SetActive(false); }
        if (UseConsumable.relicCount > 0) { lockedRelic.SetActive(false); }
        if (UpdateGame.treasurePotionCount > 0) { lockedTreasurePotion.SetActive(false); }
        if (UpdateGame.knifeCount > 0) { lockedEnchantedHammer.SetActive(false); }

        changeText = true;
        shopExlemationmark.SetActive(false);
    }

    #region SaveAndLoadJSON
    public void LoadData(GameDataJSON data)
    {
        lockPickLevel = data.lockPickLevel;
        hammerLevel = data.hammerLevel;
        keyLevel = data.keyLevel;
        goldenTouchLevel = data.goldenTouchLevel;
        treasureBagLevel = data.treasureBagLevel;
        XPPotionLevel = data.xpPotionLevel;
        damagePotionLevel = data.damagePotionLevel;
        lootPotionLevel = data.lootPotionLevel;
        miniChestLevel = data.miniChestLevel;
        elixirLevel = data.elixirLevel;
        scrollLevel = data.scrollLevel;
        gauntletLevel = data.gauntletLevel;
        relicLevel = data.relicLevel;

        keyGemUpgradePrice = data.keyGemPrice;
        hammerGemUpgradePrice = data.hammerGemPrice;
        goldenTouchGemPrice = data.goldenTouchGemPrice;
        lockPickGemPrice = data.lockPickgemPrice;
        treasureBagGemPrice = data.treasurebagGemPrice;
        XPPotionGemPrice = data.xpPotionGemPrice;
        damagePotionGemPrice = data.damagePotionGemPrice;
        lootPotionGemPrice = data.lootPotionGemPrice;
        miniChestGemPrice = data.miniChestGemPrice;
        elixirGemPrice = data.elixirGemPrice;
        scrollGemPrice = data.scrollGemPrice;
        gauntletGemPrice = data.gauntletGemPrice;
        relicGemPrice = data.relicGemPrice;
        relicGemPrice2 = data.relicGemPrice2;

        lockPickPurchasePrice = data.lockPickPrice;
        keyPurchasePrice = data.keyPrice;
        hammerPurchasePrice = data.hammerPrice;
        goldenTouchPurchasePrice = data.goldenTouchPrice;
        treasureBagBuyPrice = data.treasureBagPrice;
        XPPotionBuyPrice = data.xpPotionPrice;
        damagePotionBuyPrice = data.damagePotionPrice;
        lootPotionBuyPrice = data.lootPotionPrice;
        miniChestBuyPrice = data.miniChestPrice;
        elixirBuyPrice = data.elixirPrice;
        scrollBuyPrice = data.scrollPrice;
        gauntletBuyPrice = data.gauntletPrice;
        relicBuyPrice = data.relicPrice;

        keyBoughtFirstTime = data.keyBoughtFirstTime;
        hammerBoughtFirstTime = data.hammerBoughtFirstTime;
        goldenTouchBoughtFirstTime = data.goldenTouchBoughtFirstTime;
        lockPickBoughtFirstTime = data.lockPickBoughtFirstTime;
        treasureBagBoughtFirstTime = data.treasureBagBoughtFirstTime;
        XPPotionBoughtFirstTime = data.XPPotionBoughtFirstTime;
        damagePotionBoughtFirstTime = data.damagePotionBoughtFirstTime;
        lootPotionBoughtFirstTime = data.lootPotionBOughtFirstTime;
        miniChestBoughtFirstTime = data.miniChestBoughtFirsTTime;
        elixirBoughtFirstTime = data.elixirBoughtFirsTTime;
        scrollBoughtFirstTime = data.scrollBoughtFirsTTime;
        gauntletBoughtFirstTime = data.gauntletBoughtFirsTTime;
        relicBoughtFirstTime = data.relicBoughtFirsTTime;

        treasureBagDropChance = data.treasureBagDropChance;
        treasureBagDropChanceIncrement = data.treasureBagDropChanceIncrement;

        lockPickOpenChanceIncrement = data.lockPickOpenChanceIncrement;
        lockPickDropChance = data.lockPickDropChance;
        lockPickDropChanceIncrement = data.lockPickDropChanceIncrement;

        keyDropChance = data.keyDropChance;
        keyDropChanceIncrement = data.keyDropChanceIncrement;
        keyRareDropChance = data.keyRareDropChance;
        keyRareDropChanceIncrement = data.keyRareDropChanceIncrement;

        hammerDamageAmountIncrement = data.hammerDamageAmountIncrement;
        hammerTimer = data.hammerTimer;
        hammerTimerIncrement = data.hammerTimerIncrement;
        hammerDropChance = data.hammerDropChance;
        hammerDropChanceIncrement = data.hammerDropChanceIncrement;

        goldenTouchTimer = data.goldenTouchTimer;
        goldenTouchTimerIncrement = data.goldenTouchTimerIncrement;
        goldenTouchDropChance = data.goldenTouchDropChance;
        goldenTouchDropChanceIncrement = data.goldenTouchDropChanceIncrement;

        XPPotionDropChance = data.XPPotiondropChance;
        XPPotionDropChanceIncrement = data.XPPotiondropChanceIncrement;
        XPPotionXPBuff = data.xpPotionBuff;
        XPPotionBufFIncrement = data.xpPotionBuffIncrement;
        XPPotionTimer = data.xpPotionTimer;
        XPPotionTimerMinus = data.XPPotionTimerMinus;

        damagePotionBuff = data.damagePotionBuff;
        damagePotionBuffIncrement = data.damagePotionBuffIncrement;
        damagePotionTimer = data.damagePotionTimer;
        damagePotionTimerMinus = data.damagePotionTimerMinus;
        damagePotionDropChance = data.damagepotionDropChance;
        damagePotionDropChanceIncrement = data.damagepotionDropChanceIncrement;

        lootPotionBuff = data.lootPotionBuff;
        lootPotionBuffIncrement = data.lootPotionBuffIncrement;
        lootPotionTimer = data.lootPotionTimer;
        lootPotionTimerMinus = data.lootPotionTimerIncrement;
        lootPotionDropChance = data.lootPotionDropChance;
        lootPotionDropChanceIncrement = data.lootPotionDropChanceIncrement;

        miniChestSpawnTimer = data.miniChestTimer;
        miniChestSpawnTimerMinus = data.miniChestTimerIncrement;

        elixirDropChance = data.elixirDropChance;
        elixirDropChanceIncrement = data.elixirDropChanceIncrement;
        elixirBuff = data.elixirBuff;
        elixirBuffIncrement = data.elixirBuffIncrement;
        elixirTimer = data.elixirTimer;
        elixirTimerIncrement = data.elixirTimerIncrement;

        scrollTimer = data.scrollTimer;
        scrollTimerIncrement = data.scrollTimerIncrement;
        scrollDropChance = data.scrollDropChance;
        scrollDropChanceIncrement = data.scrollDropChanceIncrement;

        gauntletTimer = data.gauntletTimer;
        gauntletTimerIncrement = data.gauntletTimerIncrement;
        gauntletDropChance = data.gauntletDropChance;
        gauntletDropChanceIncrement = data.gauntletDropChanceIncrement;
        gauntletGoldDropChance = data.gauntletGoldDropChance;
        gauntletGoldDropChanceIncrement = data.gauntletGoldDropChanceIncrement;

        relicDropChance = data.relicDropChance;
        relicDropChanceIncrement = data.relicDropChanceIncrement;

        newLockPickPrice = data.newLockPickPrice;
        newHammerPrice = data.newHammerPrice;
        newLootPotionPrice = data.newLootPotionPrice;
        newDamagePotionPrice = data.newDamagePotionPrice;
        newXPPotionPrice = data.newXPPotionPrice;
        newGoldenTouchPrice = data.newGoldenTouchPrice;
        newMiniChestPrice = data.newMiniChestPrice;
        newkeyPrice = data.newkeyPrice;
        newTreasureBagPrice = data.newTreasureBagPrice;
        newScrollPrice = data.newScrollPrice;
        newGauntletPrice = data.newGauntletPrice;
        newElixirPRice = data.newElixirPRice;
        newRelicPrice = data.newRelicPrice;

    }

    public void SaveData(ref GameDataJSON data)
    {
        data.lockPickLevel = lockPickLevel;
        data.hammerLevel = hammerLevel;
        data.keyLevel = keyLevel;
        data.goldenTouchLevel = goldenTouchLevel;
        data.treasureBagLevel = treasureBagLevel;
        data.xpPotionLevel = XPPotionLevel;
        data.damagePotionLevel = damagePotionLevel;
        data.lootPotionLevel = lootPotionLevel;
        data.miniChestLevel = miniChestLevel;
        data.elixirLevel = elixirLevel;
        data.scrollLevel = scrollLevel;
        data.gauntletLevel = gauntletLevel;
        data.relicLevel = relicLevel;

        data.keyGemPrice = keyGemUpgradePrice;
        data.hammerGemPrice = hammerGemUpgradePrice;
        data.goldenTouchGemPrice = goldenTouchGemPrice;
        data.lockPickgemPrice = lockPickGemPrice;
        data.treasurebagGemPrice = treasureBagGemPrice;
        data.xpPotionGemPrice = XPPotionGemPrice;
        data.damagePotionGemPrice = damagePotionGemPrice;
        data.lootPotionGemPrice = lootPotionGemPrice;
        data.miniChestGemPrice = miniChestGemPrice;
        data.elixirGemPrice = elixirGemPrice;
        data.scrollGemPrice = scrollGemPrice;
        data.gauntletGemPrice = gauntletGemPrice;
        data.relicGemPrice = relicGemPrice;
        data.relicGemPrice2 = relicGemPrice2;

        data.lockPickPrice = lockPickPurchasePrice;
        data.keyPrice = keyPurchasePrice;
        data.hammerPrice = hammerPurchasePrice;
        data.goldenTouchPrice = goldenTouchPurchasePrice;
        data.treasureBagPrice = treasureBagBuyPrice;
        data.xpPotionPrice = XPPotionBuyPrice;
        data.damagePotionPrice = damagePotionBuyPrice;
        data.lootPotionPrice = lootPotionBuyPrice;
        data.miniChestPrice = miniChestBuyPrice;
        data.elixirPrice = elixirBuyPrice;
        data.scrollPrice = scrollBuyPrice;
        data.gauntletPrice = gauntletBuyPrice;
        data.relicPrice = relicBuyPrice;

        data.keyBoughtFirstTime = keyBoughtFirstTime;
        data.hammerBoughtFirstTime = hammerBoughtFirstTime;
        data.goldenTouchBoughtFirstTime = goldenTouchBoughtFirstTime;
        data.lockPickBoughtFirstTime = lockPickBoughtFirstTime;
        data.treasureBagBoughtFirstTime = treasureBagBoughtFirstTime;
        data.XPPotionBoughtFirstTime = XPPotionBoughtFirstTime;
        data.damagePotionBoughtFirstTime = damagePotionBoughtFirstTime;
        data.lootPotionBOughtFirstTime = lootPotionBoughtFirstTime;
        data.miniChestBoughtFirsTTime = miniChestBoughtFirstTime;
        data.elixirBoughtFirsTTime = elixirBoughtFirstTime;
        data.scrollBoughtFirsTTime = scrollBoughtFirstTime;
        data.gauntletBoughtFirsTTime = gauntletBoughtFirstTime;
        data.relicBoughtFirsTTime = relicBoughtFirstTime;

        data.treasureBagDropChance = treasureBagDropChance;
        data.treasureBagDropChanceIncrement = treasureBagDropChanceIncrement;

        data.lockPickOpenChanceIncrement = lockPickOpenChanceIncrement;
        data.lockPickDropChance = lockPickDropChance;
        data.lockPickDropChanceIncrement = lockPickDropChanceIncrement;

        data.keyDropChance = keyDropChance;
        data.keyDropChanceIncrement = keyDropChanceIncrement;
        data.keyRareDropChance = keyRareDropChance;
        data.keyRareDropChanceIncrement = keyRareDropChanceIncrement;

        data.hammerDamageAmountIncrement = hammerDamageAmountIncrement;
        data.hammerTimer = hammerTimer;
        data.hammerTimerIncrement = hammerTimerIncrement;
        data.hammerDropChance = hammerDropChance;
        data.hammerDropChanceIncrement = hammerDropChanceIncrement;

        data.goldenTouchTimer = goldenTouchTimer;
        data.goldenTouchTimerIncrement = goldenTouchTimerIncrement;
        data.goldenTouchDropChance = goldenTouchDropChance;
        data.goldenTouchDropChanceIncrement = goldenTouchDropChanceIncrement;

        data.XPPotiondropChance = XPPotionDropChance;
        data.XPPotiondropChanceIncrement = XPPotionDropChanceIncrement;
        data.xpPotionBuff = XPPotionXPBuff;
        data.xpPotionBuffIncrement = XPPotionBufFIncrement;
        data.xpPotionTimer = XPPotionTimer;
        data.XPPotionTimerMinus = XPPotionTimerMinus;

        data.damagePotionBuff = damagePotionBuff;
        data.damagePotionBuffIncrement = damagePotionBuffIncrement;
        data.damagePotionTimer = damagePotionTimer;
        data.damagePotionTimerMinus = damagePotionTimerMinus;
        data.damagepotionDropChance = damagePotionDropChance;
        data.damagepotionDropChanceIncrement = damagePotionDropChanceIncrement;

        data.lootPotionBuff = lootPotionBuff;
        data.lootPotionBuffIncrement = lootPotionBuffIncrement;
        data.lootPotionTimer = lootPotionTimer;
        data.lootPotionTimerIncrement = lootPotionTimerMinus;
        data.lootPotionDropChance = lootPotionDropChance;
        data.lootPotionDropChanceIncrement = lootPotionDropChanceIncrement;

        data.miniChestTimer = miniChestSpawnTimer;
        data.miniChestTimerIncrement = miniChestSpawnTimerMinus;

        data.elixirDropChance = elixirDropChance;
        data.elixirDropChanceIncrement = elixirDropChanceIncrement;
        data.elixirBuff = elixirBuff;
        data.elixirBuffIncrement = elixirBuffIncrement;
        data.elixirTimer = elixirTimer;
        data.elixirTimerIncrement = elixirTimerIncrement;

        data.scrollTimer = scrollTimer;
        data.scrollTimerIncrement = scrollTimerIncrement;
        data.scrollDropChance = scrollDropChance;
        data.scrollDropChanceIncrement = scrollDropChanceIncrement;

        data.gauntletTimer = gauntletTimer;
        data.gauntletTimerIncrement = gauntletTimerIncrement;
        data.gauntletDropChance = gauntletDropChance;
        data.gauntletDropChanceIncrement = gauntletDropChanceIncrement;
        data.gauntletGoldDropChance = gauntletGoldDropChance;
        data.gauntletGoldDropChanceIncrement = gauntletGoldDropChanceIncrement;

        data.relicDropChance = relicDropChance;
        data.relicDropChanceIncrement = relicDropChanceIncrement;

        data.newLockPickPrice = newLockPickPrice;
        data.newHammerPrice = newHammerPrice;
        data.newLootPotionPrice = newLootPotionPrice;
        data.newDamagePotionPrice = newDamagePotionPrice;
        data.newXPPotionPrice = newXPPotionPrice;
        data.newGoldenTouchPrice = newGoldenTouchPrice;
        data.newMiniChestPrice = newMiniChestPrice;
        data.newkeyPrice = newkeyPrice;
        data.newTreasureBagPrice = newTreasureBagPrice;
        data.newScrollPrice = newScrollPrice;
        data.newGauntletPrice = newGauntletPrice;
        data.newElixirPRice = newElixirPRice;
        data.newRelicPrice = newRelicPrice;

    }
    #endregion

    public static bool miniChestText;
    public bool startMiniChest;
    public static bool isCountdown;

    public TextMeshProUGUI hammerBringBackCursorText;

    IEnumerator miniChest()
    {
        isCountdown = false;
        //Debug.Log("MiniChest");
        yield return new WaitForSeconds(SpecialUpgradesButtons.miniChestSpawnTimer);
        //Debug.Log("MiniChest2");
        startMiniChest = true;
        isCountdown = true;
    }

    public TMP_FontAsset korean, english, russian, japanese, chinese;

    IEnumerator miniChestTextAnim()
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
        chestText.GetComponent<TextMeshProUGUI>().color = Color.yellow;

        if (MiniChests.miniChestGoldReward == true)
        {
            chestText.GetComponent<TextMeshProUGUI>().text = "+" + TotalGoldAmount.FormatCoinsDoubleOneLetter(((SelectChests.currentMiniChestGoldValue / 2) * (1 + SkillTree.skillTreeGold + RareTreasures.runeGold + RareTreasures.cookieGold + RareTreasures.backPackGold + UseConsumable.scrollGoldBuff + UseConsumable.relicPermaGoldBuff)) * 300) + Localization.gold + "!";
            MiniChests.miniChestGoldReward = false;
        }
        if (MiniChests.miniChestSkillPointReward == true)
        {
            chestText.GetComponent<TextMeshProUGUI>().text = "+" + ((PlayerLevel.playerLevel / 10) + 1) + Localization.skillPointsExplinatinMark;
            MiniChests.miniChestSkillPointReward = false;
        }
        if (MiniChests.miniChestTreasureReward == true)
        {
            chestText.GetComponent<TextMeshProUGUI>().text = Localization.treasuresExplinationMark;
            MiniChests.miniChestTreasureReward = false;
        }

        yield return new WaitForSeconds(1.4f);
        ObjectPooling.instance.ReturnMiniChestTextFromPool(chestText);
    }

    public static bool spawnMiniChest;
    public Image purchase1X, purchaseMax;
    public static bool maxButtonActive;
    public Image active1X, activeMax, passive1X, passiveMax;

    public void PurchaseMax()
    {
        maxButtonActive = true;
        isHoldingMax = true;
        if (PlaceMobileButtons.isMobile == false) { holdingMaxText.SetActive(true); }
        else
        {
            holdingMaxText.GetComponent<TextMeshProUGUI>().text = "PURCHASING MAX";
        }
   

        SetAlphaPassive(purchaseMax, alphaValueFull);
        SetAlphaPassive(purchase1X, alphavalueHalf);
        if (AudioManager.audioMuted == 1) { audioManager.Play("PurchaseSound"); }
    }

    public void Purchase1X()
    {
        maxButtonActive = false;
        isHoldingMax = false;
        if (PlaceMobileButtons.isMobile == false) { holdingMaxText.SetActive(false); }
        else
        {
            holdingMaxText.GetComponent<TextMeshProUGUI>().text = "PURCHASING 1X";
        }

        SetAlphaPassive(purchase1X, alphaValueFull);
        SetAlphaPassive(purchaseMax, alphavalueHalf);
        if (AudioManager.audioMuted == 1) { audioManager.Play("PurchaseSound"); }
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

    public TextMeshProUGUI activeMaxUpgradeText;
    public TextMeshProUGUI passiveMaxUpgradeText;

    public void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            SetAlphaPassive(purchaseMax, alphaValueFull);
            SetAlphaPassive(activeMax, alphaValueFull);
            SetAlphaPassive(passiveMax, alphaValueFull);

            SetAlphaPassive(purchase1X, alphavalueHalf);
            SetAlphaPassive(active1X, alphavalueHalf);
            SetAlphaPassive(passive1X, alphavalueHalf);

            activeMaxUpgradeText.text = Localization.upgradeMax;
            passiveMaxUpgradeText.text = Localization.upgradeMax;

            isHoldingMax = true;
            ClickPower.isCursorMax = true;
            ClickPower.isActiveMaxActive = true;
            ClickPower.isPassiveMaxActive = true;
            holdingMaxText.SetActive(true);
        }
        else
        {
            if (maxButtonActive == true) 
            { 
                SetAlphaPassive(purchaseMax, alphaValueFull); SetAlphaPassive(purchase1X, alphavalueHalf);
                if (PlaceMobileButtons.isMobile == false) { holdingMaxText.SetActive(true); }
                isHoldingMax = true; ClickPower.isCursorMax = true; 
            }
            if (maxButtonActive == false)
            { 
                SetAlphaPassive(purchaseMax, alphavalueHalf); SetAlphaPassive(purchase1X, alphaValueFull);
                if(PlaceMobileButtons.isMobile == false) { holdingMaxText.SetActive(false); }
                isHoldingMax = false; ClickPower.isCursorMax = false; 
            }

            if (ClickPower.activeMaxIsActive == true) { SetAlphaPassive(activeMax, alphaValueFull); SetAlphaPassive(active1X, alphavalueHalf); activeMaxUpgradeText.text = Localization.upgradeMax; ClickPower.isActiveMaxActive = true; }
            if (ClickPower.activeMaxIsActive == false) { SetAlphaPassive(activeMax, alphavalueHalf); SetAlphaPassive(active1X, alphaValueFull); activeMaxUpgradeText.text = Localization.upgrade; ClickPower.isActiveMaxActive = false; }

            if(ClickPower.passiveMaxIsActive == true) { SetAlphaPassive(passiveMax, alphaValueFull); SetAlphaPassive(passive1X, alphavalueHalf); passiveMaxUpgradeText.text = Localization.upgradeMax; ClickPower.isPassiveMaxActive = true; }
            if (ClickPower.passiveMaxIsActive == false) { SetAlphaPassive(passiveMax, alphavalueHalf); SetAlphaPassive(passive1X, alphaValueFull); passiveMaxUpgradeText.text = Localization.upgrade; ClickPower.isPassiveMaxActive = false; }
        }


        if (spawnMiniChest == true)
        {
            StartCoroutine(miniChest());
            spawnMiniChest = false;
        }

        if (startMiniChest == true && SpecialUpgradesButtons.miniChestBoughtFirstTime == 1)
        {
            SpecialUpgradesButtons.clickedMiniChest = true;
            GameObject chest = ObjectPooling.instance.GetMiniChestFromPool();

            if (AudioManager.audioMuted == 1) {
                audioManager.Play("MiniChestSpawn");
            }
            if (AudioManager.audioMuted == 0)
            {
                if (SettingsOptions.miniChestSound == 1)
                {
                    audioManager.Play("MiniChestSpawn");
                }
            }

            spawnMiniChest = false;

            startMiniChest = false;
        }


        //Mini chest click text pop up
        if(miniChestText == true)
        {
            StartCoroutine(miniChestTextAnim());
            miniChestText = false;
        }

        if (changeText == true)
        {
            //OldPrices();

            NewPrices();

            #region gemPRices
            lockPickGemPriceText.text = "" + lockPickGemPrice;
            keyGamePriceText.text = "" + keyGemUpgradePrice; 
            hammerGemPriceText.text = hammerGemUpgradePrice + ""; 
            goldenTouchGemPriceText.text = goldenTouchGemPrice + "";
            treasureBagGemPriceText.text = treasureBagGemPrice + "";
            XPPotionGemPriceText.text = XPPotionGemPrice + "";
            damagePotionGemPriceText.text = damagePotionGemPrice + "";
            lootPotionGemPriceText.text = lootPotionGemPrice + "";
            if (miniChestSpawnTimer <= 60)
            {
                maxMiniChestText.SetActive(true);
                miniChestGemPriceText.text = "<color=red>" + Localization.MAX;
            }
            else { miniChestGemPriceText.text = miniChestGemPrice + ""; }
            elixirGemPriceText.text = elixirGemPrice + "";
            scrollGemPriceText.text = scrollGemPrice + "";
            gauntletGemPriceText.text = gauntletGemPrice + "";
            relicGemPriceText.text = relicGemPrice + "";
            relicGemPrice2Text.text = relicGemPrice2 + "";
            #endregion

            #region levels
            lockPickLevelText.text = Localization.lvl + lockPickLevel;
            hammerLevelText.text = Localization.lvl + hammerLevel;
            keyLevelText.text = Localization.lvl + keyLevel;
            goldenTouchLevelText.text = Localization.lvl + goldenTouchLevel;
            treasureBagLevelText.text = Localization.lvl + treasureBagLevel;
            XPPotionLevelText.text = Localization.lvl + XPPotionLevel;
            damagePotionLevelText.text = Localization.lvl + damagePotionLevel;
            lootPotionLevelText.text = Localization.lvl + lootPotionLevel;
            miniChestLevelText.text = Localization.lvl + miniChestLevel;
            elixirLevelText.text = Localization.lvl + elixirLevel;
            scrollLevelText.text = Localization.lvl + scrollLevel;
            gauntletLevelText.text = Localization.lvl + gauntletLevel;
            relicLevelText.text = Localization.lvl + relicLevel;
            #endregion

            #region count red or green text
            if (UseConsumable.lockPickCount == 0) { lockPickOwnedHoverText.text = Localization.owned + UseConsumable.lockPickCount; lockPickOwnedHoverText.color = Color.red; }
            if (UseConsumable.lockPickCount > 0) { lockPickOwnedHoverText.text = Localization.owned + UseConsumable.lockPickCount; lockPickOwnedHoverText.color = Color.green; }

            hammerCountText.text = Localization.owned + UseConsumable.hammerCount;
            if (UseConsumable.hammerCount == 0) { hammerCountText.color = Color.red; }  if (UseConsumable.hammerCount > 0) { hammerCountText.color = Color.green; }

            goldenTouchCount.text = Localization.owned + UseConsumable.goldenTouchCount;
             if (UseConsumable.goldenTouchCount == 0) { goldenTouchCount.color = Color.red; }  if (UseConsumable.goldenTouchCount > 0) { goldenTouchCount.color = Color.green; }

            keyCountText.text = Localization.owned + UseConsumable.KeysCount;
              if (UseConsumable.KeysCount == 0) { keyCountText.color = Color.red; }  if (UseConsumable.KeysCount > 0) { keyCountText.color = Color.green; }

            treasureBagCountText.text = Localization.owned + UseConsumable.treasureBagCount;
             if (UseConsumable.treasureBagCount == 0) { treasureBagCountText.color = Color.red; }  if (UseConsumable.treasureBagCount > 0) { treasureBagCountText.color = Color.green; }

            XPPotionCountText.text = Localization.owned + UseConsumable.XPPotionCount;
              if (UseConsumable.XPPotionCount == 0) { XPPotionCountText.color = Color.red; }  if (UseConsumable.XPPotionCount > 0) { XPPotionCountText.color = Color.green; }

            damagePotionCountText.text = Localization.owned + UseConsumable.damagePotioncount;
              if (UseConsumable.damagePotioncount == 0) { damagePotionCountText.color = Color.red; }  if (UseConsumable.damagePotioncount > 0) { damagePotionCountText.color = Color.green; }

            lootPotionCountText.text = Localization.owned + UseConsumable.lootPotionCount;
              if (UseConsumable.lootPotionCount == 0) { lootPotionCountText.color = Color.red; }  if (UseConsumable.lootPotionCount > 0) { lootPotionCountText.color = Color.green; }

            elixirCountText.text = Localization.owned + UseConsumable.elixirCount;
            if (UseConsumable.elixirCount == 0) { elixirCountText.color = Color.red; }
            if (UseConsumable.elixirCount > 0) { elixirCountText.color = Color.green; }

            scrollCountText.text = Localization.owned + UseConsumable.scrollCount;
            if (UseConsumable.scrollCount == 0) { scrollCountText.color = Color.red; }
            if (UseConsumable.scrollCount > 0) { scrollCountText.color = Color.green; }

            gauntletCountText.text = Localization.owned + UseConsumable.gauntletCount;
            if (UseConsumable.gauntletCount == 0) { gauntletCountText.color = Color.red; }
            if (UseConsumable.gauntletCount > 0) { gauntletCountText.color = Color.green; }

            relicCountText.text = Localization.owned + UseConsumable.relicCount;
            if (UseConsumable.relicCount == 0) { relicCountText.color = Color.red; }
            if (UseConsumable.relicCount > 0) { relicCountText.color = Color.green; }
            #endregion

            #region hoverText
            lockPickOpenChanceText.text = HoverSpecialString.lockPickOpenChanceText;
            lockPickDropChanceText.text = HoverSpecialString.lockPickDropChanceText;
            lockPickHoverPrice.text = HoverSpecialString.lockPickPurchaseText;

            hammerDamageText.text = HoverSpecialString.hammerDamageText;
            hammerDropChanceText.text = HoverSpecialString.hammerDropChanceText;
            hammerHoverPrice.text = HoverSpecialString.hammerPurchaseText;

            keyRareDropChanceText.text = HoverSpecialString.keyRareDropChanceText;
            keyDropChanceText.text = HoverSpecialString.keyDropChanceText;
            keyHoverPrice.text = HoverSpecialString.keyPurchaseText;

            goldenTouchTimerText.text = HoverSpecialString.goldenTouchTimerText;
            goldenTouchDropChanceText.text = HoverSpecialString.goldenTouchDropChance;
            goldenTouchHoverPrice.text = HoverSpecialString.goldenTouchPurchaseText;

            treasureBagDropChanceText.text = HoverSpecialString.treasureChestDropChanceText;
            treasureBagHoverPriceText.text = HoverSpecialString.treasureBagPurchaseText;

            XPPotionChanceText.text = HoverSpecialString.XPPotionDropChanceText;
            XPPotionHoverPriceText.text = HoverSpecialString.XPPotionPurchaseText;
            XPPotionBuffAndTimerText.text = HoverSpecialString.xpPotionBuffText;

            damagePotionChanceText.text = HoverSpecialString.damagePotionDropChanceText;
            damagePotionHoverPriceText.text = HoverSpecialString.damagePotionPurchaseText;
            damagePotionBuffAndTimerText.text = HoverSpecialString.damagePotionBuffText;

            lootPotionChanceText.text = HoverSpecialString.lootPotiontDropChanceText;
            lootPotionHoverPriceText.text = HoverSpecialString.lootPotionPurchaseText;
            lootPotionBuffAndTimerText.text = HoverSpecialString.lootpotionBuffText;

            miniChestTimerText.text = HoverSpecialString.miniChestTimerText;
            miniChestHoverPriceText.text = HoverSpecialString.miniChestPriceText;

            elixirBuffAndTimerText.text = HoverSpecialString.elixirInfo;
            elixirHoverPriceText.text = HoverSpecialString.elixirPurchase;
            elixirChanceText.text = HoverSpecialString.elixirDropChance;

            scrollBuffText.text = HoverSpecialString.scrollInfo;
            scrollHoverPriceText.text = HoverSpecialString.scrollPurchase;
            scrollChanceText.text = HoverSpecialString.scrollDropChance;

            gauntletBuffText.text = HoverSpecialString.gauntletInfo;
            gauntletHoverPriceText.text = HoverSpecialString.gauntletPurchase;
            gauntletChanceText.text = HoverSpecialString.gauntletDropChance;

            relicHoverPriceText.text = HoverSpecialString.relicPurchase;
            relicChanceText.text = HoverSpecialString.relicDropChance;

            hammerBringBackCursorText.text = HoverSpecialString.bringBackCursor;
            #endregion

            changeText = false;
        }


        NewPricesTextColor();

        #region gemPrices
        //Gem prices
        if (RareDropsCollected.quartzCount >= lockPickGemPrice) { lockPickGemPriceText.color = Color.green; }
        if (RareDropsCollected.quartzCount < lockPickGemPrice) { lockPickGemPriceText.color = Color.red; }

        if (RareDropsCollected.quartzCount >= hammerGemUpgradePrice) { hammerGemPriceText.color = Color.green; }
        if (RareDropsCollected.quartzCount < hammerGemUpgradePrice) { hammerGemPriceText.color = Color.red; }

        if (RareDropsCollected.amethystCount >= lootPotionGemPrice) { lootPotionGemPriceText.color = Color.green; }
        if (RareDropsCollected.amethystCount < lootPotionGemPrice) { lootPotionGemPriceText.color = Color.red; }

        if (RareDropsCollected.yellowTopazCount >= damagePotionGemPrice) { damagePotionGemPriceText.color = Color.green; }
        if (RareDropsCollected.yellowTopazCount < damagePotionGemPrice) { damagePotionGemPriceText.color = Color.red; }

        if (RareDropsCollected.albiteCount >= XPPotionGemPrice) { XPPotionGemPriceText.color = Color.green; }
        if (RareDropsCollected.albiteCount < XPPotionGemPrice) { XPPotionGemPriceText.color = Color.red; }

        if (RareDropsCollected.yellowSapphireCount >= miniChestGemPrice) { miniChestGemPriceText.color = Color.green; }
        if (RareDropsCollected.yellowSapphireCount < miniChestGemPrice) { miniChestGemPriceText.color = Color.red; }
        if (miniChestSpawnTimer <= 60) { miniChestGemPriceText.color = Color.red; }

        if (RareDropsCollected.AdventurineCount >= treasureBagGemPrice) { treasureBagGemPriceText.color = Color.green; }
        if (RareDropsCollected.AdventurineCount < treasureBagGemPrice) { treasureBagGemPriceText.color = Color.red; }

        if (RareDropsCollected.pinkTourmalineCount >= keyGemUpgradePrice) { keyGamePriceText.color = Color.green; }
        if (RareDropsCollected.pinkTourmalineCount < keyGemUpgradePrice) { keyGamePriceText.color = Color.red; }

        if (RareDropsCollected.aquamarineCount >= goldenTouchGemPrice) { goldenTouchGemPriceText.color = Color.green; }
        if (RareDropsCollected.aquamarineCount < goldenTouchGemPrice) { goldenTouchGemPriceText.color = Color.red; }

        if (RareDropsCollected.gemSilicaCount >= elixirGemPrice) { elixirGemPriceText.color = Color.green; }
        if (RareDropsCollected.gemSilicaCount < elixirGemPrice) { elixirGemPriceText.color = Color.red; }

        if (RareDropsCollected.diamondCount >= scrollGemPrice) { scrollGemPriceText.color = Color.green; }
        if (RareDropsCollected.diamondCount < scrollGemPrice) { scrollGemPriceText.color = Color.red; }

        if (RareDropsCollected.emeraldCount >= gauntletGemPrice) { gauntletGemPriceText.color = Color.green; }
        if (RareDropsCollected.emeraldCount < gauntletGemPrice) { gauntletGemPriceText.color = Color.red; }

        if (RareDropsCollected.goldeSeaPearlCount >= relicGemPrice) { relicGemPriceText.color = Color.green; }
        if (RareDropsCollected.goldeSeaPearlCount < relicGemPrice) { relicGemPriceText.color = Color.red; }

        if (RareDropsCollected.pinkPlostCount >= relicGemPrice2) { relicGemPrice2Text.color = Color.green; }
        if (RareDropsCollected.pinkPlostCount < relicGemPrice2) { relicGemPrice2Text.color = Color.red; }
        #endregion

        if(shopBar.activeInHierarchy == false)
        {
            if (hammerOff == false && hammerBoughtFirstTime != 1 && UpdateGame.totalGoldHigher >= newHammerPrice) { 
                shopExlemationmark.SetActive(true); hammerOff = true; }
            if (lootOff == false && lootPotionBoughtFirstTime != 1 && UpdateGame.totalGoldHigher >= newLootPotionPrice)
            {
                shopExlemationmark.SetActive(true); lootOff = true;
            }
            if (damageOff == false && damagePotionBoughtFirstTime != 1 && UpdateGame.totalGoldHigher >= newDamagePotionPrice)
            {
                shopExlemationmark.SetActive(true); damageOff = true;
            }
            if (XPOff == false && XPPotionBoughtFirstTime != 1 && UpdateGame.totalGoldHigher >= newXPPotionPrice)
            {
                shopExlemationmark.SetActive(true); XPOff = true;
            }
            if (goldenTouchOff == false && goldenTouchBoughtFirstTime != 1 && UpdateGame.totalGoldHigher >= newGoldenTouchPrice)
            {
                shopExlemationmark.SetActive(true); goldenTouchOff = true;
            }
            if (miniChestOff == false && miniChestBoughtFirstTime != 1 && UpdateGame.totalGoldHigher >= newMiniChestPrice)
            {
                shopExlemationmark.SetActive(true); miniChestOff = true;
            }
            if (keyOff == false && keyBoughtFirstTime != 1 && UpdateGame.totalGoldHigher >= newkeyPrice)
            {
                shopExlemationmark.SetActive(true); keyOff = true;
            }
            if (treasureBagOff == false && treasureBagBoughtFirstTime != 1 && UpdateGame.totalGoldHigher >= newTreasureBagPrice)
            {
                shopExlemationmark.SetActive(true); treasureBagOff = true;
            }
            if (scrollOff == false && scrollBoughtFirstTime != 1 && UpdateGame.totalGoldHigher >= newScrollPrice)
            {
                shopExlemationmark.SetActive(true); scrollOff = true;
            }
            if (gauntletOff == false && gauntletBoughtFirstTime != 1 && UpdateGame.totalGoldHigher >= newGauntletPrice)
            {
                shopExlemationmark.SetActive(true); gauntletOff = true;
            }
            if (elixirOFf == false && elixirBoughtFirstTime != 1 && UpdateGame.totalGoldHigher >= newElixirPRice)
            {
                shopExlemationmark.SetActive(true); elixirOFf = true;
            }
            if (relicOff == false && relicBoughtFirstTime != 1 && UpdateGame.totalGoldHigher >= newRelicPrice)
            {
                shopExlemationmark.SetActive(true); relicOff = true;
            }

        }
    }

    #region oldPrices
    public void OldPrices()
    {
        lockPickPriceText.text = "" + TotalGoldAmount.FormatCoins(lockPickPurchasePrice);
        keysPriceText.text = "" + TotalGoldAmount.FormatCoins(keyPurchasePrice);
        hammerPriceText.text = "" + TotalGoldAmount.FormatCoins(hammerPurchasePrice);
        goldenTouchPriceText.text = "" + TotalGoldAmount.FormatCoins(goldenTouchPurchasePrice);
        treasureBagPriceText.text = "" + TotalGoldAmount.FormatCoins(treasureBagBuyPrice);
        XPPotionPriceText.text = "" + TotalGoldAmount.FormatCoins(XPPotionBuyPrice);
        damagePotionPriceText.text = "" + TotalGoldAmount.FormatCoins(damagePotionBuyPrice);
        lootPotionPriceText.text = "" + TotalGoldAmount.FormatCoins(lootPotionBuyPrice);
        miniChestPriceText.text = "" + TotalGoldAmount.FormatCoins(miniChestBuyPrice);
        elixirPriceText.text = "" + TotalGoldAmount.FormatCoins(elixirBuyPrice);
        scrollPriceText.text = "" + TotalGoldAmount.FormatCoins(scrollBuyPrice);
        gauntletPriceText.text = "" + TotalGoldAmount.FormatCoins(gauntletBuyPrice);
        relicPriceText.text = "" + TotalGoldAmount.FormatCoins(relicBuyPrice);
    }
    #endregion

    #region NewPrices
    public void NewPrices()
    {
        lockPickPriceText.text = "" + TotalGoldAmount.FormatCoinsDoubleOneLetter(newLockPickPrice);
        keysPriceText.text = "" + TotalGoldAmount.FormatCoinsDoubleOneLetter(newkeyPrice);
        hammerPriceText.text = "" + TotalGoldAmount.FormatCoinsDoubleOneLetter(newHammerPrice);
        goldenTouchPriceText.text = "" + TotalGoldAmount.FormatCoinsDoubleOneLetter(newGoldenTouchPrice);
        treasureBagPriceText.text = "" + TotalGoldAmount.FormatCoinsDoubleOneLetter(newTreasureBagPrice);
        XPPotionPriceText.text = "" + TotalGoldAmount.FormatCoinsDoubleOneLetter(newXPPotionPrice);
        damagePotionPriceText.text = "" + TotalGoldAmount.FormatCoinsDoubleOneLetter(newDamagePotionPrice);
        lootPotionPriceText.text = "" + TotalGoldAmount.FormatCoinsDoubleOneLetter(newLootPotionPrice);
        miniChestPriceText.text = "" + TotalGoldAmount.FormatCoinsDoubleOneLetter(newMiniChestPrice);
        elixirPriceText.text = "" + TotalGoldAmount.FormatCoinsDoubleOneLetter(newElixirPRice);
        scrollPriceText.text = "" + TotalGoldAmount.FormatCoinsDoubleOneLetter(newScrollPrice);
        gauntletPriceText.text = "" + TotalGoldAmount.FormatCoinsDoubleOneLetter(newGauntletPrice);
        relicPriceText.text = "" + TotalGoldAmount.FormatCoinsDoubleOneLetter(newRelicPrice);
    }
    #endregion

    #region oldPrices red og green text
    public void OldPricesTextColor()
    {
        if (TotalGoldAmount.totalGold > lockPickPurchasePrice) { lockPickPriceText.color = Color.green; }
        if (TotalGoldAmount.totalGold < lockPickPurchasePrice) { lockPickPriceText.color = Color.red; }

        if (TotalGoldAmount.totalGold > keyPurchasePrice) { keysPriceText.color = Color.green; }
        if (TotalGoldAmount.totalGold < keyPurchasePrice) { keysPriceText.color = Color.red; }

        if (TotalGoldAmount.totalGold > hammerPurchasePrice) { hammerPriceText.color = Color.green; }
        if (TotalGoldAmount.totalGold < hammerPurchasePrice) { hammerPriceText.color = Color.red; }

        if (TotalGoldAmount.totalGold > goldenTouchPurchasePrice) { goldenTouchPriceText.color = Color.green; }
        if (TotalGoldAmount.totalGold < goldenTouchPurchasePrice) { goldenTouchPriceText.color = Color.red; }

        if (TotalGoldAmount.totalGold > treasureBagBuyPrice) { treasureBagPriceText.color = Color.green; }
        if (TotalGoldAmount.totalGold < treasureBagBuyPrice) { treasureBagPriceText.color = Color.red; }

        if (TotalGoldAmount.totalGold > XPPotionBuyPrice) { XPPotionPriceText.color = Color.green; }
        if (TotalGoldAmount.totalGold < XPPotionBuyPrice) { XPPotionPriceText.color = Color.red; }

        if (TotalGoldAmount.totalGold > damagePotionBuyPrice) { damagePotionPriceText.color = Color.green; }
        if (TotalGoldAmount.totalGold < damagePotionBuyPrice) { damagePotionPriceText.color = Color.red; }

        if (TotalGoldAmount.totalGold > lootPotionBuyPrice) { lootPotionPriceText.color = Color.green; }
        if (TotalGoldAmount.totalGold < lootPotionBuyPrice) { lootPotionPriceText.color = Color.red; }

        if (TotalGoldAmount.totalGold > miniChestBuyPrice) { miniChestPriceText.color = Color.green; }
        if (TotalGoldAmount.totalGold < miniChestBuyPrice) { miniChestPriceText.color = Color.red; }

        if (TotalGoldAmount.totalGold > elixirBuyPrice) { elixirPriceText.color = Color.green; }
        if (TotalGoldAmount.totalGold < elixirBuyPrice) { elixirPriceText.color = Color.red; }

        if (TotalGoldAmount.totalGold > scrollBuyPrice) { scrollPriceText.color = Color.green; }
        if (TotalGoldAmount.totalGold < scrollBuyPrice) { scrollPriceText.color = Color.red; }

        if (TotalGoldAmount.totalGold > gauntletBuyPrice) { gauntletPriceText.color = Color.green; }
        if (TotalGoldAmount.totalGold < gauntletBuyPrice) { gauntletPriceText.color = Color.red; }

        if (TotalGoldAmount.totalGold > relicBuyPrice) { relicPriceText.color = Color.green; }
        if (TotalGoldAmount.totalGold < relicBuyPrice) { relicPriceText.color = Color.red; }
    }
    #endregion

    #region newPrices red og green text
    public void NewPricesTextColor()
    {
        if (UpdateGame.totalGoldHigher > newLockPickPrice) { lockPickPriceText.color = Color.green; }
        if (UpdateGame.totalGoldHigher < newLockPickPrice) { lockPickPriceText.color = Color.red; }

        if (UpdateGame.totalGoldHigher > newkeyPrice) { keysPriceText.color = Color.green; }
        if (UpdateGame.totalGoldHigher < newkeyPrice) { keysPriceText.color = Color.red; }

        if (UpdateGame.totalGoldHigher > newHammerPrice) { hammerPriceText.color = Color.green; }
        if (UpdateGame.totalGoldHigher < newHammerPrice) { hammerPriceText.color = Color.red; }

        if (UpdateGame.totalGoldHigher > newGoldenTouchPrice) { goldenTouchPriceText.color = Color.green; }
        if (UpdateGame.totalGoldHigher < newGoldenTouchPrice) { goldenTouchPriceText.color = Color.red; }

        if (UpdateGame.totalGoldHigher > newTreasureBagPrice) { treasureBagPriceText.color = Color.green; }
        if (UpdateGame.totalGoldHigher < newTreasureBagPrice) { treasureBagPriceText.color = Color.red; }

        if (UpdateGame.totalGoldHigher > newXPPotionPrice) { XPPotionPriceText.color = Color.green; }
        if (UpdateGame.totalGoldHigher < newXPPotionPrice) { XPPotionPriceText.color = Color.red; }

        if (UpdateGame.totalGoldHigher > newDamagePotionPrice) { damagePotionPriceText.color = Color.green; }
        if (UpdateGame.totalGoldHigher < newDamagePotionPrice) { damagePotionPriceText.color = Color.red; }

        if (UpdateGame.totalGoldHigher > newLootPotionPrice) { lootPotionPriceText.color = Color.green; }
        if (UpdateGame.totalGoldHigher < newLootPotionPrice) { lootPotionPriceText.color = Color.red; }

        if (UpdateGame.totalGoldHigher > newMiniChestPrice) { miniChestPriceText.color = Color.green; }
        if (UpdateGame.totalGoldHigher < newMiniChestPrice) { miniChestPriceText.color = Color.red; }

        if (UpdateGame.totalGoldHigher > newElixirPRice) { elixirPriceText.color = Color.green; }
        if (UpdateGame.totalGoldHigher < newElixirPRice) { elixirPriceText.color = Color.red; }

        if (UpdateGame.totalGoldHigher > newScrollPrice) { scrollPriceText.color = Color.green; }
        if (UpdateGame.totalGoldHigher < newScrollPrice) { scrollPriceText.color = Color.red; }

        if (UpdateGame.totalGoldHigher > newGauntletPrice) { gauntletPriceText.color = Color.green; }
        if (UpdateGame.totalGoldHigher < newGauntletPrice) { gauntletPriceText.color = Color.red; }

        if (UpdateGame.totalGoldHigher > newRelicPrice) { relicPriceText.color = Color.green; }
        if (UpdateGame.totalGoldHigher < newRelicPrice) { relicPriceText.color = Color.red; }
    }
    #endregion

    public static bool hammerOff, lootOff, damageOff, XPOff,goldenTouchOff, miniChestOff, keyOff, treasureBagOff, scrollOff, gauntletOff, elixirOFf, relicOff;
    public GameObject shopExlemationmark, shopBar;

    #region purchaseAndUpgradeLockPick
    public GameObject lockPickButton;
    public static float lockPickDropChance;
    public static float lockPickDropChanceIncrement;
    public static float lockPickOpenChanceIncrement;

    public static int lockPickLevel;
    public TextMeshProUGUI lockPickOpenChanceText;
    public TextMeshProUGUI lockPickLevelText;
    public TextMeshProUGUI lockPickDropChanceText;
    public TextMeshProUGUI lockPickOwnedHoverText;
    public TextMeshProUGUI lockPickHoverPrice;

    public void PurchaseLockPick()
    {
        if (isHoldingMax == true)
        {
            if (UpdateGame.totalGoldHigher < newLockPickPrice)
            {
                CantAfford();
            }
            while (UpdateGame.totalGoldHigher >= newLockPickPrice)
            {
                NewLockPick();
            }
            LockPickVariables();
        }
        else
        {
            NewLockPick();
            LockPickVariables();
        }
    }

    public void NewLockPick()
    {
            if (UpdateGame.totalGoldHigher < newLockPickPrice)
            {
                CantAfford();
            }
            if (UpdateGame.totalGoldHigher >= newLockPickPrice)
            {
                Stats.itemsPurchased += 1;
                lockPickBoughtFirstTime = 1;
                UseConsumable.lockPickCount += 1;
                UpdateGame.totalGoldHigher -= newLockPickPrice;
                newLockPickPrice *= 1.6f;
            }
    }

    public void LockPickVariables()
    {
        HoverSpecialString.hoverPriceChange = true;
        changeText = true;
        CheckFistTimePurchaseUpgrades();
    }


    public void UpgradeLockPick()
    {
        if (isHoldingMax == true)
        {
            if (RareDropsCollected.quartzCount < lockPickGemPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.quartzCount >= lockPickGemPrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.quartzCount >= lockPickGemPrice)
            {
                LockPickUpgrade();
            }
        }
        else
        {
            if (RareDropsCollected.quartzCount < lockPickGemPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.quartzCount >= lockPickGemPrice)
            {
                LockPickUpgrade();
                UpgradeSound();
            }
        }
    }

    public void LockPickUpgrade()
    {
        Stats.itemsUpgraded += 1;
        lockPickLevel += 1;
        UseConsumable.lockPickSuccessChance += lockPickOpenChanceIncrement;
        lockPickDropChance += lockPickDropChanceIncrement;
        HoverSpecialString.hoverSpecialChance = true;
        RareDropsCollected.quartzCount -= lockPickGemPrice;
        RareDropsCollected.isGemCountUpdated = true;
        lockPickGemPrice += 1;
    }

    #endregion

    #region purchaseAndUpgradeKey

    public static float keyRareDropChance, keyRareDropChanceIncrement;
    public static float keyDropChance, keyDropChanceIncrement;

    public static int keyLevel;
    public TextMeshProUGUI keyLevelText;
    public TextMeshProUGUI keyRareDropChanceText;
    public TextMeshProUGUI keyDropChanceText;
    public TextMeshProUGUI keyCountText;
    public TextMeshProUGUI keyHoverPrice;

    public void PurchaseKey()
    {
        if (isHoldingMax == true)
        {
            if (UpdateGame.totalGoldHigher < newkeyPrice)
            {
                CantAfford();
            }
            while (UpdateGame.totalGoldHigher >= newkeyPrice)
            {
                NewKey();
            }
        }
        else
        {
            NewKey();
        }
    }

    public void NewKey()
    {
        if (UpdateGame.totalGoldHigher < newkeyPrice)
        {
            CantAfford();
        }
        if (UpdateGame.totalGoldHigher >= newkeyPrice)
        {
            Stats.itemsPurchased += 1;
            keyBoughtFirstTime = 1;
            UseConsumable.KeysCount += 1;
            UpdateGame.totalGoldHigher -= newkeyPrice;
            newkeyPrice *= 2f;

            HoverSpecialString.hoverPriceChange = true;
            changeText = true;
            CheckFistTimePurchaseUpgrades();
        }
    }

    public void UpgradeKey()
    {
        if (isHoldingMax == true)
        {
            if (RareDropsCollected.pinkTourmalineCount < keyGemUpgradePrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.pinkTourmalineCount >= keyGemUpgradePrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.pinkTourmalineCount >= keyGemUpgradePrice)
            {
                KeyUpgrade();
            }
        }
        else
        {
            if (RareDropsCollected.pinkTourmalineCount < keyGemUpgradePrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.pinkTourmalineCount >= keyGemUpgradePrice)
            {
                KeyUpgrade();
                UpgradeSound();
            }
        }

    }

    public void KeyUpgrade()
    {
        Stats.itemsUpgraded += 1;
        keyLevel += 1;
        keyRareDropChance += keyRareDropChanceIncrement;
        keyDropChance += keyDropChanceIncrement;
        HoverSpecialString.hoverSpecialChance = true;
        RareDropsCollected.pinkTourmalineCount -= keyGemUpgradePrice;
        RareDropsCollected.isGemCountUpdated = true;
        keyGemUpgradePrice += 2;
    }

    #endregion

    #region purchaseAndUpgradeHammer

    public static float hammerDamageAmountIncrement;
    public static float hammerTimer, hammerTimerIncrement;
    public static float hammerDropChance, hammerDropChanceIncrement;

    public static int hammerLevel;
    public TextMeshProUGUI hammerLevelText;
    public TextMeshProUGUI hammerDamageText;
    public TextMeshProUGUI hammerDropChanceText;
    public TextMeshProUGUI hammerCountText;
    public TextMeshProUGUI hammerHoverPrice;

    public void PurchaseHammer()
    {
        if (isHoldingMax == true)
        {
            if (UpdateGame.totalGoldHigher < newHammerPrice)
            {
                CantAfford();
            }
            while (UpdateGame.totalGoldHigher >= newHammerPrice)
            {
                NewHammer();
            }
        }
        else
        {
            NewHammer();
        }
      
    }

    public void NewHammer()
    {
        if (UpdateGame.totalGoldHigher < newHammerPrice)
        {
            CantAfford();
        }
        if (UpdateGame.totalGoldHigher >= newHammerPrice)
        {
            Stats.itemsPurchased += 1;
            hammerBoughtFirstTime = 1;
            UseConsumable.hammerCount += 1;
            UpdateGame.totalGoldHigher -= newHammerPrice;
            newHammerPrice *= 3f;

            HoverSpecialString.hoverPriceChange = true;
            changeText = true;
            CheckFistTimePurchaseUpgrades();
        }
    }

    public void UpgradeHammer()
    {
        if (isHoldingMax == true)
        {
            if (RareDropsCollected.quartzCount < hammerGemUpgradePrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.quartzCount >= hammerGemUpgradePrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.quartzCount >= hammerGemUpgradePrice)
            {
                HammerUpgrade();
            }
        }
        else
        {
            if (RareDropsCollected.quartzCount < hammerGemUpgradePrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.quartzCount >= hammerGemUpgradePrice)
            {
                HammerUpgrade();
                UpgradeSound();
            }
        }
    }

    public void HammerUpgrade()
    {
        Stats.itemsUpgraded += 1;
        hammerLevel += 1;
        UseConsumable.hammerDamageMultiplier += hammerDamageAmountIncrement;
        hammerTimer += hammerTimerIncrement;
        hammerDropChance += hammerDropChanceIncrement;
        HoverSpecialString.hoverSpecialChance = true;
        RareDropsCollected.quartzCount -= hammerGemUpgradePrice;
        RareDropsCollected.isGemCountUpdated = true;
        hammerGemUpgradePrice += 3;
    }

    #endregion

    #region purchaseAndUpgradeGoldenTouch
    public static float goldenTouchTimer, goldenTouchTimerIncrement;
    public static float goldenTouchDropChance, goldenTouchDropChanceIncrement;

    public static int goldenTouchLevel;
    public TextMeshProUGUI goldenTouchLevelText;
    public TextMeshProUGUI goldenTouchCount;
    public TextMeshProUGUI goldenTouchTimerText;
    public TextMeshProUGUI goldenTouchDropChanceText;
    public TextMeshProUGUI goldenTouchHoverPrice;

    public void PurchaseGoldenTouch()
    {
        if (isHoldingMax == true)
        {
            if (UpdateGame.totalGoldHigher < newGoldenTouchPrice)
            {
                CantAfford();
            }
            while (UpdateGame.totalGoldHigher >= newGoldenTouchPrice)
            {
                NewGoldenTouch();
            }
        }
        else
        {
            NewGoldenTouch();
        }
       
    }


    public void NewGoldenTouch()
    {
        if (UpdateGame.totalGoldHigher < newGoldenTouchPrice)
        {
            CantAfford();
        }
        if (UpdateGame.totalGoldHigher >= newGoldenTouchPrice)
        {
            Stats.itemsPurchased += 1;
            goldenTouchBoughtFirstTime = 1;
            UseConsumable.goldenTouchCount += 1;
            UpdateGame.totalGoldHigher -= newGoldenTouchPrice;
            newGoldenTouchPrice *= 3.35f;

            HoverSpecialString.hoverPriceChange = true;
            changeText = true;
            CheckFistTimePurchaseUpgrades();
        }
    }

    public void UpgradeGoldenTouch()
    {
        if (isHoldingMax == true)
        {
            if (RareDropsCollected.aquamarineCount < goldenTouchGemPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.aquamarineCount >= goldenTouchGemPrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.aquamarineCount >= goldenTouchGemPrice)
            {
                GoldenTouchUpgrade();
            }
        }
        else
        {
            if (RareDropsCollected.aquamarineCount < goldenTouchGemPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.aquamarineCount >= goldenTouchGemPrice)
            {
                GoldenTouchUpgrade();
                UpgradeSound();
            }
        }

       
    }

    public void GoldenTouchUpgrade()
    {
        Stats.itemsUpgraded += 1;
        goldenTouchLevel += 1;
        goldenTouchTimer += goldenTouchTimerIncrement;
        goldenTouchDropChance += goldenTouchDropChanceIncrement;
        HoverSpecialString.hoverSpecialChance = true;
        RareDropsCollected.aquamarineCount -= goldenTouchGemPrice;
        RareDropsCollected.isGemCountUpdated = true;
        goldenTouchGemPrice += 2;
    }
    #endregion

    #region purchaseAndUpgradeTreasureBag
    public static float treasureBagDropChance, treasureBagDropChanceIncrement;
    public static float treasureBagBuyPrice;

    public static int treasureBagLevel;
    public static int treasureBagGemPrice;
    public GameObject treasureBagLocked;
    public TextMeshProUGUI treasureBagLevelText;
    public TextMeshProUGUI treasureBagCountText;
    public TextMeshProUGUI treasureBagDropChanceText;
    public TextMeshProUGUI treasureBagHoverPriceText;
    public TextMeshProUGUI treasureBagPriceText;
    public TextMeshProUGUI treasureBagGemPriceText;

    public void PurchaseTreasureBag()
    {
        if (isHoldingMax == true)
        {
            if (UpdateGame.totalGoldHigher < newTreasureBagPrice)
            {
                CantAfford();
            }
            while (UpdateGame.totalGoldHigher >= newTreasureBagPrice)
            {
                NewTreasureBag();
            }
        }
        else
        {
            NewTreasureBag();
        }
    }
   

    public void NewTreasureBag()
    {
        if (UpdateGame.totalGoldHigher < newTreasureBagPrice)
        {
            CantAfford();
        }
        if (UpdateGame.totalGoldHigher >= newTreasureBagPrice)
        {
            Stats.itemsPurchased += 1;
            treasureBagBoughtFirstTime = 1;
            UseConsumable.treasureBagCount += 1;
            UpdateGame.totalGoldHigher -= newTreasureBagPrice;
            newTreasureBagPrice *= 2.8f;

            HoverSpecialString.hoverPriceChange = true;
            changeText = true;
            CheckFistTimePurchaseUpgrades();
        }
    }

    public void UpgradeTreasureBag()
    {
        if (isHoldingMax == true)
        {
            if (RareDropsCollected.AdventurineCount < treasureBagGemPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.AdventurineCount >= treasureBagGemPrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.AdventurineCount >= treasureBagGemPrice)
            {
                TreasureBagUpgrade();
            }
        }
        else
        {
            if (RareDropsCollected.AdventurineCount < treasureBagGemPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.AdventurineCount >= treasureBagGemPrice)
            {
                TreasureBagUpgrade();
                UpgradeSound();
            }
        }

    }

    public void TreasureBagUpgrade()
    {
        Stats.itemsUpgraded += 1;
        treasureBagLevel += 1;
        treasureBagDropChance += treasureBagDropChanceIncrement;
        HoverSpecialString.hoverSpecialChance = true;
        RareDropsCollected.AdventurineCount -= treasureBagGemPrice;
        RareDropsCollected.isGemCountUpdated = true;
        treasureBagGemPrice += 2;
    }
    #endregion

    #region purchaseAndUpgradeXPPotion
    public static float XPPotionDropChance, XPPotionDropChanceIncrement;
    public static float XPPotionBuyPrice;

    public static int XPPotionLevel;
    public static int XPPotionGemPrice;
    public static float XPPotionXPBuff, XPPotionBufFIncrement;
    public static float XPPotionTimer, XPPotionTimerMinus;
    public GameObject XPPotionLocked;
    public TextMeshProUGUI XPPotionLevelText;
    public TextMeshProUGUI XPPotionCountText;
    public TextMeshProUGUI XPPotionChanceText;
    public TextMeshProUGUI XPPotionBuffAndTimerText;
    public TextMeshProUGUI XPPotionHoverPriceText;
    public TextMeshProUGUI XPPotionPriceText;
    public TextMeshProUGUI XPPotionGemPriceText;

    public void PurchaseXPPotion()
    {
        if (isHoldingMax == true)
        {
            if (UpdateGame.totalGoldHigher < newXPPotionPrice)
            {
                CantAfford();
            }
            while (UpdateGame.totalGoldHigher >= newXPPotionPrice)
            {
                NewXPPotion();
            }
        }
        else
        {
            NewXPPotion();
        }
      
    }

 
    public void NewXPPotion()
    {
        if (UpdateGame.totalGoldHigher < newXPPotionPrice)
        {
            CantAfford();
        }
        if (UpdateGame.totalGoldHigher >= newXPPotionPrice)
        {
            Stats.itemsPurchased += 1;
            XPPotionBoughtFirstTime = 1;
            UseConsumable.XPPotionCount += 1;
            UpdateGame.totalGoldHigher -= newXPPotionPrice;
            newXPPotionPrice *= 1.7f;

            HoverSpecialString.hoverPriceChange = true;
            changeText = true;
            CheckFistTimePurchaseUpgrades();
        }
    }

    public void UpgradeXPPotion()
    {
        if (isHoldingMax == true)
        {
            if (RareDropsCollected.albiteCount < XPPotionGemPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.albiteCount >= XPPotionGemPrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.albiteCount >= XPPotionGemPrice)
            {
                XPPotionUpgrade();
            }
        }
        else
        {
            if (RareDropsCollected.albiteCount < XPPotionGemPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.albiteCount >= XPPotionGemPrice)
            {
                XPPotionUpgrade();
                UpgradeSound();
            }
        }

    }

    public void XPPotionUpgrade()
    {
        Stats.itemsUpgraded += 1;
        XPPotionLevel += 1;
        XPPotionXPBuff += XPPotionBufFIncrement;
        XPPotionTimer += XPPotionTimerMinus;
        XPPotionDropChance += XPPotionDropChanceIncrement;
        HoverSpecialString.hoverSpecialChance = true;
        RareDropsCollected.albiteCount -= XPPotionGemPrice;
        RareDropsCollected.isGemCountUpdated = true;
        XPPotionGemPrice += 2;
    }
    #endregion

    #region purchaseAndUpgradeDamagePotion
    public static float damagePotionDropChance, damagePotionDropChanceIncrement;
    public static float damagePotionBuyPrice;

    public static int damagePotionLevel;
    public static int damagePotionGemPrice;
    public static float damagePotionBuff, damagePotionBuffIncrement;
    public static float damagePotionTimer, damagePotionTimerMinus;
    public GameObject damagePotionLocked;
    public TextMeshProUGUI damagePotionLevelText;
    public TextMeshProUGUI damagePotionCountText;
    public TextMeshProUGUI damagePotionChanceText;
    public TextMeshProUGUI damagePotionBuffAndTimerText;
    public TextMeshProUGUI damagePotionHoverPriceText;
    public TextMeshProUGUI damagePotionPriceText;
    public TextMeshProUGUI damagePotionGemPriceText;

    public void PurchaseDamagePotion()
    {
        if (isHoldingMax == true)
        {
            if (UpdateGame.totalGoldHigher < newDamagePotionPrice)
            {
                CantAfford();
            }
            while (UpdateGame.totalGoldHigher >= newDamagePotionPrice)
            {
                NewDamagePotion();
            }
        }
        else
        {
            NewDamagePotion();
        }
      
    }


    public void NewDamagePotion()
    {
        if (UpdateGame.totalGoldHigher < newDamagePotionPrice)
        {
            CantAfford();
        }
        if (UpdateGame.totalGoldHigher >= newDamagePotionPrice)
        {
            Stats.itemsPurchased += 1;
            damagePotionBoughtFirstTime = 1;
            UseConsumable.damagePotioncount += 1;
            UpdateGame.totalGoldHigher -= newDamagePotionPrice;
            newDamagePotionPrice *= 1.7f;

            HoverSpecialString.hoverPriceChange = true;
            changeText = true;
            CheckFistTimePurchaseUpgrades();
        }
    }

    public void UpgradeDamagePotion()
    {
        if (isHoldingMax == true)
        {
            if (RareDropsCollected.yellowTopazCount < damagePotionGemPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.yellowTopazCount >= damagePotionGemPrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.yellowTopazCount >= damagePotionGemPrice)
            {
                DamagePotionUpgrade();
            }
        }
        else
        {
            if (RareDropsCollected.yellowTopazCount < damagePotionGemPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.yellowTopazCount >= damagePotionGemPrice)
            {
                DamagePotionUpgrade();
                UpgradeSound();
            }
        }
    }

    public void DamagePotionUpgrade()
    {
        Stats.itemsUpgraded += 1;
        damagePotionLevel += 1;
        damagePotionBuff += damagePotionBuffIncrement;
        damagePotionTimer += damagePotionTimerMinus;
        damagePotionDropChance += damagePotionDropChanceIncrement;
        HoverSpecialString.hoverSpecialChance = true;
        RareDropsCollected.yellowTopazCount -= damagePotionGemPrice;
        RareDropsCollected.isGemCountUpdated = true;
        damagePotionGemPrice += 2;
    }
    #endregion

    #region purchaseAndUpgradeLootPotion
    public static float lootPotionDropChance, lootPotionDropChanceIncrement;
    public static float lootPotionBuyPrice;

    public static int lootPotionLevel;
    public static int lootPotionGemPrice;
    public static float lootPotionBuff, lootPotionBuffIncrement;
    public static float lootPotionTimer, lootPotionTimerMinus;
    public GameObject lootPotionLocked;
    public TextMeshProUGUI lootPotionLevelText;
    public TextMeshProUGUI lootPotionCountText;
    public TextMeshProUGUI lootPotionChanceText;
    public TextMeshProUGUI lootPotionBuffAndTimerText;
    public TextMeshProUGUI lootPotionHoverPriceText;
    public TextMeshProUGUI lootPotionPriceText;
    public TextMeshProUGUI lootPotionGemPriceText;

    public void PurchaseLootPotion()
    {
        if (isHoldingMax == true)
        {
            if (UpdateGame.totalGoldHigher < newLootPotionPrice)
            {
                CantAfford();
            }
            while (UpdateGame.totalGoldHigher >= newLootPotionPrice)
            {
                NewLootPotion();
            }
        }
        else
        {
            NewLootPotion();
        }
       
    }

    public void NewLootPotion()
    {
        if (UpdateGame.totalGoldHigher < newLootPotionPrice)
        {
            CantAfford();
        }
        if (UpdateGame.totalGoldHigher >= newLootPotionPrice)
        {
            Stats.itemsPurchased += 1;
            lootPotionBoughtFirstTime = 1;
            UseConsumable.lootPotionCount += 1;
            UpdateGame.totalGoldHigher -= newLootPotionPrice;
            newLootPotionPrice *= 1.7f;

            HoverSpecialString.hoverPriceChange = true;
            changeText = true;
            CheckFistTimePurchaseUpgrades();
        }
    }

    public void UpgradeLootPotion()
    {
        if (isHoldingMax == true)
        {
            if (RareDropsCollected.amethystCount < lootPotionGemPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.amethystCount >= lootPotionGemPrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.amethystCount >= lootPotionGemPrice)
            {
                LootPotionUpgrade();
            }
        }
        else
        {
            if (RareDropsCollected.amethystCount < lootPotionGemPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.amethystCount >= lootPotionGemPrice)
            {
                LootPotionUpgrade();
                UpgradeSound();
            }
        }

    }

    public void LootPotionUpgrade()
    {
        Stats.itemsUpgraded += 1;
        lootPotionLevel += 1;
        lootPotionBuff += lootPotionBuffIncrement;
        lootPotionTimer += lootPotionTimerMinus;
        lootPotionDropChance += lootPotionDropChanceIncrement;
        HoverSpecialString.hoverSpecialChance = true;
        RareDropsCollected.amethystCount -= lootPotionGemPrice;
        RareDropsCollected.isGemCountUpdated = true;
        lootPotionGemPrice += 2;
    }
    #endregion

    #region purchaseAndUpgradeMiniChest

    public GameObject miniChestLocked;

    public static int miniChestLevel;
    public static int miniChestSpawnTimer;
    public static int miniChestSpawnTimerMinus;
    public static int miniChestGemPrice;

    public static float miniChestBuyPrice;

    public TextMeshProUGUI miniChestLevelText;
    public TextMeshProUGUI miniChestTimerText;
    public TextMeshProUGUI miniChestPriceText;
    public TextMeshProUGUI miniChestHoverPriceText;
    public TextMeshProUGUI miniChestGemPriceText;
    public static bool clickedMiniChest;
    public GameObject maxMiniChestText;

    public void PurchaseMiniChest()
    {
        if (isHoldingMax == true)
        {
            if (UpdateGame.totalGoldHigher < newMiniChestPrice)
            {
                CantAfford();
            }
            while (UpdateGame.totalGoldHigher >= newMiniChestPrice)
            {
                NewMiniChest();
            }
        }
        else
        {
            NewMiniChest();
        }
      
    }


    public void NewMiniChest()
    {
        if (UpdateGame.totalGoldHigher < newMiniChestPrice)
        {
            CantAfford();
        }
        if (UpdateGame.totalGoldHigher >= newMiniChestPrice)
        {
            Stats.itemsPurchased += 1;
            if (miniChestBoughtFirstTime != 1) { isCountdown = true; }
            miniChestBoughtFirstTime = 1;
            if (miniChestBoughtFirstTime == 1) { GameObject chest = ObjectPooling.instance.GetMiniChestFromPool(); }

            UpdateGame.totalGoldHigher -= newMiniChestPrice;
            newMiniChestPrice *= 3.9f;

            HoverSpecialString.hoverPriceChange = true;
            changeText = true;
            //clickedMiniChest = true;

            CheckFistTimePurchaseUpgrades();
        }
    }


    public void UpgradeMiniChest()
    {
        if (miniChestSpawnTimer <= 60)
        {
            maxMiniChestText.SetActive(true);
            miniChestGemPriceText.text = "<color=red>" + Localization.MAX;
        }
        if (miniChestSpawnTimer > 60)
        {
            if (isHoldingMax == true)
            {
                if (RareDropsCollected.yellowSapphireCount < miniChestGemPrice)
                {
                    CantAfford();
                }
                if (RareDropsCollected.yellowSapphireCount >= miniChestGemPrice)
                {
                    UpgradeSound();
                }
                while (RareDropsCollected.yellowSapphireCount >= miniChestGemPrice && miniChestSpawnTimer > 60)
                {
                    UpgradeMiniChestVarialbes();
                }
            }
            else
            {
                if (RareDropsCollected.yellowSapphireCount < miniChestGemPrice)
                {
                    CantAfford();
                }
                if (RareDropsCollected.yellowSapphireCount >= miniChestGemPrice)
                {
                    UpgradeMiniChestVarialbes();
                    UpgradeSound();
                }
            }
        }
      
    }

    public void UpgradeMiniChestVarialbes()
    {
        if (miniChestSpawnTimer > 60)
        {
            Stats.itemsUpgraded += 1;
            miniChestLevel += 1;
            miniChestSpawnTimer -= miniChestSpawnTimerMinus;
            HoverSpecialString.hoverSpecialChance = true;
            RareDropsCollected.yellowSapphireCount -= miniChestGemPrice;
            RareDropsCollected.isGemCountUpdated = true;
            miniChestGemPrice += 3;
        }
        if(miniChestSpawnTimer < 60)
        {
            miniChestSpawnTimer = 60;
        }
    }
    #endregion

    #region purchaseAndUpgradeElixir
    public static float elixirDropChance, elixirDropChanceIncrement;
    public static float elixirBuyPrice;

    public static int elixirLevel;
    public static int elixirGemPrice;
    public static float elixirBuff, elixirBuffIncrement;
    public static float elixirTimer, elixirTimerIncrement;
    public GameObject elixirLocked;
    public TextMeshProUGUI elixirLevelText;
    public TextMeshProUGUI elixirCountText;
    public TextMeshProUGUI elixirChanceText;
    public TextMeshProUGUI elixirBuffAndTimerText;
    public TextMeshProUGUI elixirHoverPriceText;
    public TextMeshProUGUI elixirPriceText;
    public TextMeshProUGUI elixirGemPriceText;

    public void PurchaseElixir()
    {
        if (isHoldingMax == true)
        {
            if (UpdateGame.totalGoldHigher < newElixirPRice)
            {
                CantAfford();
            }
            while (UpdateGame.totalGoldHigher >= newElixirPRice)
            {
                NewElixir();
            }
        }
        else
        {
            NewElixir();
        }
      
    }


    public void NewElixir()
    {
        if (UpdateGame.totalGoldHigher < newElixirPRice)
        {
            CantAfford();
        }
        if (UpdateGame.totalGoldHigher >= newElixirPRice)
        {
            Stats.itemsPurchased += 1;
            elixirBoughtFirstTime = 1;
            UseConsumable.elixirCount += 1;
            UpdateGame.totalGoldHigher -= newElixirPRice;
            newElixirPRice *= 4.7f;

            HoverSpecialString.hoverPriceChange = true;
            changeText = true;
            CheckFistTimePurchaseUpgrades();
        }
    }

    public void UpgradeElixir()
    {
        if (isHoldingMax == true)
        {
            if (RareDropsCollected.gemSilicaCount < elixirGemPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.gemSilicaCount >= elixirGemPrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.gemSilicaCount >= elixirGemPrice)
            {
                UpgradeElixirVariables();
            }
        }
        else
        {
            if (RareDropsCollected.gemSilicaCount < elixirGemPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.gemSilicaCount >= elixirGemPrice)
            {
                UpgradeElixirVariables();
                UpgradeSound();
            }
        }

    }

    public void UpgradeElixirVariables()
    {
        Stats.itemsUpgraded += 1;
        elixirLevel += 1;
        elixirBuff += elixirBuffIncrement;
        elixirTimer += elixirTimerIncrement;
        elixirDropChance += elixirDropChanceIncrement;
        HoverSpecialString.hoverSpecialChance = true;
        RareDropsCollected.gemSilicaCount -= elixirGemPrice;
        RareDropsCollected.isGemCountUpdated = true;
        elixirGemPrice += 7;
    }
    #endregion

    #region purchaseAndUpgradeScroll
    public static float scrollDropChance, scrollDropChanceIncrement;
    public static float scrollBuyPrice;

    public static int scrollLevel;
    public static int scrollGemPrice;
    public static float scrollTimer, scrollTimerIncrement;
    public GameObject scrollLocked;
    public TextMeshProUGUI scrollLevelText;
    public TextMeshProUGUI scrollCountText;
    public TextMeshProUGUI scrollChanceText;
    public TextMeshProUGUI scrollBuffText;
    public TextMeshProUGUI scrollHoverPriceText;
    public TextMeshProUGUI scrollPriceText;
    public TextMeshProUGUI scrollGemPriceText;

    public void PurchaseScroll()
    {
        if (isHoldingMax == true)
        {
            if (UpdateGame.totalGoldHigher < newScrollPrice)
            {
                CantAfford();
            }
            while (UpdateGame.totalGoldHigher >= newScrollPrice)
            {
                NewScroll();
            }
        }
        else
        {
            NewScroll();
        }
       
    }


    public void NewScroll()
    {
        if (UpdateGame.totalGoldHigher < newScrollPrice)
        {
            CantAfford();
        }
        if (UpdateGame.totalGoldHigher >= newScrollPrice)
        {
            Stats.itemsPurchased += 1;
            scrollBoughtFirstTime = 1;
            UseConsumable.scrollCount += 1;
            UpdateGame.totalGoldHigher -= newScrollPrice;
            newScrollPrice *= 6.3f;

            HoverSpecialString.hoverPriceChange = true;
            changeText = true;
            CheckFistTimePurchaseUpgrades();
        }
    }

    public void UpgradeScroll()
    {
        if (isHoldingMax == true)
        {
            if (RareDropsCollected.diamondCount < scrollGemPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.diamondCount >= scrollGemPrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.diamondCount >= scrollGemPrice)
            {
                UpgradeScrollVariables();
            }
        }
        else
        {
            if (RareDropsCollected.diamondCount < scrollGemPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.diamondCount >= scrollGemPrice)
            {
                UpgradeScrollVariables();
                UpgradeSound();
            }
        }

    }

    public void UpgradeScrollVariables()
    {
        Stats.itemsUpgraded += 1;
        Stats.itemsUpgraded += 1;
        scrollLevel += 1;
        scrollTimer += scrollTimerIncrement;
        scrollDropChance += scrollDropChanceIncrement;
        HoverSpecialString.hoverSpecialChance = true;
        RareDropsCollected.diamondCount -= scrollGemPrice;
        RareDropsCollected.isGemCountUpdated = true;
        scrollGemPrice += 6;
    }
    #endregion

    #region purchaseAndUpgradeGauntlet
    public static float gauntletDropChance, gauntletDropChanceIncrement;
    public static float gauntletBuyPrice;

    public static int gauntletLevel;
    public static int gauntletGemPrice;
    public static float gauntletGoldDropChance, gauntletGoldDropChanceIncrement;
    public static float gauntletTimer, gauntletTimerIncrement;
    public GameObject gauntletLocked;
    public TextMeshProUGUI gauntletLevelText;
    public TextMeshProUGUI gauntletCountText;
    public TextMeshProUGUI gauntletChanceText;
    public TextMeshProUGUI gauntletBuffText;
    public TextMeshProUGUI gauntletHoverPriceText;
    public TextMeshProUGUI gauntletPriceText;
    public TextMeshProUGUI gauntletGemPriceText;

    public void PurchaseGauntlet()
    {
        if (isHoldingMax == true)
        {
            if (UpdateGame.totalGoldHigher < newGauntletPrice)
            {
                CantAfford();
            }
            while (UpdateGame.totalGoldHigher >= newGauntletPrice)
            {
                NewGauntlet();
            }
        }
        else
        {
            NewGauntlet();
        }
       
    }


    public void NewGauntlet()
    {
        if (UpdateGame.totalGoldHigher < newGauntletPrice)
        {
            CantAfford();
        }
        if (UpdateGame.totalGoldHigher >= newGauntletPrice)
        {
            Stats.itemsPurchased += 1;
            gauntletBoughtFirstTime = 1;
            UseConsumable.gauntletCount += 1;
            UpdateGame.totalGoldHigher -= newGauntletPrice;
            newGauntletPrice *= 8f;

            HoverSpecialString.hoverPriceChange = true;
            changeText = true;
            CheckFistTimePurchaseUpgrades();
        }
    }

    public void UpgradeGauntlet()
    {
        if (isHoldingMax == true)
        {
            if (RareDropsCollected.emeraldCount < gauntletGemPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.emeraldCount >= gauntletGemPrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.emeraldCount >= gauntletGemPrice)
            {
                UpgradeGauntletVariables();
            }
        }
        else
        {
            if (RareDropsCollected.emeraldCount < gauntletGemPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.emeraldCount >= gauntletGemPrice)
            {
                UpgradeGauntletVariables();
                UpgradeSound();
            }
        }

    }

    public void UpgradeGauntletVariables()
    {
        Stats.itemsUpgraded += 1;
        gauntletGoldDropChance += gauntletGoldDropChanceIncrement;

        gauntletLevel += 1;
        gauntletTimer += gauntletTimerIncrement;
        gauntletDropChance += gauntletDropChanceIncrement;
        HoverSpecialString.hoverSpecialChance = true;
        RareDropsCollected.emeraldCount -= gauntletGemPrice;
        RareDropsCollected.isGemCountUpdated = true;
        gauntletGemPrice += 5;
    }
    #endregion

    #region purchaseAndUpgradeRelic
    public static float relicDropChance, relicDropChanceIncrement;
    public static float relicBuyPrice;

    public static int relicLevel;
    public static int relicGemPrice;
    public static int relicGemPrice2;
    public GameObject relicLocked;
    public TextMeshProUGUI relicLevelText;
    public TextMeshProUGUI relicCountText;
    public TextMeshProUGUI relicChanceText;
    public TextMeshProUGUI relicBuffText;
    public TextMeshProUGUI relicHoverPriceText;
    public TextMeshProUGUI relicPriceText;
    public TextMeshProUGUI relicGemPriceText;
    public TextMeshProUGUI relicGemPrice2Text;

    public void PurchaseRelic()
    {
        if (isHoldingMax == true)
        {
            if (UpdateGame.totalGoldHigher < newRelicPrice)
            {
                CantAfford();
            }
            while (UpdateGame.totalGoldHigher >= newRelicPrice)
            {
                NewRelic();
            }
        }
        else
        {
            NewRelic();
        }
       
    }

   

    public void NewRelic()
    {
        if (UpdateGame.totalGoldHigher < newRelicPrice)
        {
            CantAfford();
        }
        if (UpdateGame.totalGoldHigher >= newRelicPrice)
        {
            Stats.itemsPurchased += 1;
            relicBoughtFirstTime = 1;
            UseConsumable.relicCount += 1;
            UpdateGame.totalGoldHigher -= newRelicPrice;
            newRelicPrice *= 5.6f;

            HoverSpecialString.hoverPriceChange = true;
            changeText = true;
            CheckFistTimePurchaseUpgrades();
        }
    }

    public void UpgradeRelic()
    {
        if (isHoldingMax == true)
        {
            if (RareDropsCollected.goldeSeaPearlCount < relicGemPrice || RareDropsCollected.pinkPlostCount < relicGemPrice2)
            {
                CantAfford();
            }
            if (RareDropsCollected.goldeSeaPearlCount >= relicGemPrice && RareDropsCollected.pinkPlostCount >= relicGemPrice2)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.goldeSeaPearlCount >= relicGemPrice && RareDropsCollected.pinkPlostCount >= relicGemPrice2)
            {
                UpgradeRelicVariables();
            }
        }
        else
        {
            if (RareDropsCollected.goldeSeaPearlCount < relicGemPrice || RareDropsCollected.pinkPlostCount < relicGemPrice2)
            {
                CantAfford();
            }
            if (RareDropsCollected.goldeSeaPearlCount >= relicGemPrice && RareDropsCollected.pinkPlostCount >= relicGemPrice2)
            {
                UpgradeRelicVariables();
                UpgradeSound();
            }
        }

    }

    public void UpgradeRelicVariables()
    {
        Stats.itemsUpgraded += 1;
        relicLevel += 1;
        relicDropChance += relicDropChanceIncrement;
        HoverSpecialString.hoverSpecialChance = true;
        RareDropsCollected.goldeSeaPearlCount -= relicGemPrice;
        RareDropsCollected.pinkPlostCount -= relicGemPrice2;
        RareDropsCollected.isGemCountUpdated = true;
        relicGemPrice += 7;
        relicGemPrice2 += 7;
    }
    #endregion



    public void CantAfford()
    {
        if (AudioManager.audioMuted == 1) { audioManager.Play("Error"); }
    }

    public void UpgradeSound()
    {
        int random = Random.Range(1,4);
        if(random == 1) { if (AudioManager.audioMuted == 1) { audioManager.Play("LevelUp"); } }
        if (random == 2) { if (AudioManager.audioMuted == 1) { audioManager.Play("LevelUp2"); } }
        if (random == 3) { if (AudioManager.audioMuted == 1) { audioManager.Play("LevelUp3"); } }
    }

    public GameObject lockPickIcon, hammerIcon, keyIcon, goldenTouchIcon, treasureIcon, XPPotionIcon, damagePotionIcon, LootPotionIcon;

    public void SetIconFalse()
    {

        lockPickIcon.SetActive(false); hammerIcon.SetActive(false); keyIcon.SetActive(false); goldenTouchIcon.SetActive(false);
        treasureIcon.SetActive(false); XPPotionIcon.SetActive(false); damagePotionIcon.SetActive(false); LootPotionIcon.SetActive(false);
    }

    #region animation
    public GameObject plussIcon;
    public float moveDistance = 1.0f;
    public float animationDuration = 0.4f;
     public float fadeDuration = 0.07f;
    private bool isAnimating = false;
    private Color[] originalColors;

    private System.Collections.IEnumerator AnimateObject()
    {
        isAnimating = true;

        originalColors = GetOriginalColors();

        Vector3 startPosition = plussIcon.transform.position;
        Vector3 endPosition = startPosition + Vector3.up * moveDistance;

        float elapsedTime = 0f;

        while (elapsedTime < animationDuration)
        {
            float t = elapsedTime / animationDuration;
            plussIcon.transform.position = Vector3.Lerp(startPosition, endPosition, t);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Fade out all children
        Graphic[] childGraphics = plussIcon.GetComponentsInChildren<Graphic>();

        foreach (Graphic graphic in childGraphics)
        {
            Color startColor = graphic.color;
            Color endColor = new Color(startColor.r, startColor.g, startColor.b, 0f);

            elapsedTime = 0f;

            while (elapsedTime < fadeDuration)
            {
                float t = elapsedTime / fadeDuration;
                graphic.color = Color.Lerp(startColor, endColor, t);
                elapsedTime += Time.deltaTime;
                yield return null;
            }
        }

        // Set alpha of all children back to 100%
        SetOriginalColors();

        plussIcon.SetActive(false);

        isAnimating = false;
    }
    #endregion

    private Color[] GetOriginalColors()
    {
        Graphic[] childGraphics = plussIcon.GetComponentsInChildren<Graphic>();

        Color[] originalColors = new Color[childGraphics.Length];

        for (int i = 0; i < childGraphics.Length; i++)
        {
            originalColors[i] = childGraphics[i].color;
        }

        return originalColors;
    }

    private void SetOriginalColors()
    {
        Graphic[] childGraphics = plussIcon.GetComponentsInChildren<Graphic>();

        for (int i = 0; i < childGraphics.Length; i++)
        {
            childGraphics[i].color = originalColors[i];
        }
    }

    public PlaceMobileButtons mobileScript;

    public void CheckFistTimePurchaseUpgrades()
    {
        if (AudioManager.audioMuted == 1) { audioManager.Play("PurchaseSound"); }
        if (lockPickBoughtFirstTime == 1) { lockedLockPick.SetActive(false); SetHammerUpgrade(); }
        if (hammerBoughtFirstTime == 1) { lockedHammer.SetActive(false);  SetLootPotionUpgrade(); }
        if (lootPotionBoughtFirstTime == 1) { lockedLootPotion.SetActive(false);  SetDamagePotionUpgrade(); }
        if (damagePotionBoughtFirstTime == 1) { lockedDamagePotion.SetActive(false);  SetXPPotionUpgrade(); }
        if (XPPotionBoughtFirstTime == 1) { lockedXPPotion.SetActive(false); SetGoldenTouchUpgrade(); }
        if (goldenTouchBoughtFirstTime == 1) { lockedGoldenToutch.SetActive(false);SetMiniChestUpgrace(); }
        if (miniChestBoughtFirstTime == 1) { SetKeyUpgrade(); }
        if (keyBoughtFirstTime == 1) { lockedKeys.SetActive(false); SetTreasureBagUpgrade(); }
        if (treasureBagBoughtFirstTime == 1) { lockedTreasureBag.SetActive(false);  SetBarrel(); }

        if (scrollBoughtFirstTime == 1) { lockedScroll.SetActive(false);  SetMimicChest(); }
        if (gauntletBoughtFirstTime == 1) { lockedGauntlet.SetActive(false); SetElixirUpgrade(); }
        if (elixirBoughtFirstTime == 1) { lockedElixir.SetActive(false); SetRelicUpgrade(); }
        if (relicBoughtFirstTime == 1) { lockedRelic.SetActive(false); SetTreasurePotionUpgrade(); }
        if (UpdateGame.treasurePotionBoughtFirstTime == 1) { lockedTreasurePotion.SetActive(false); SetEnchantedHammer(); }
        if (UpdateGame.knifeBoughtFirstTime == 1) { lockedEnchantedHammer.SetActive(false); }

        mobileScript.CheckShopQuestionMarks();

        changeText = true;
        specialTextChange = true;
    }

    #region setHammer
    public void SetHammerUpgrade()
    {
        hammerUpgrade.SetActive(true);
    }
    #endregion

    #region setKey
    public void SetKeyUpgrade()
    {
        keyUpgrade.SetActive(true);
    }
    #endregion

    #region setGoldenTouch
    public void SetGoldenTouchUpgrade()
    {
        goldenTouchUpgrade.SetActive(true);
    }
    #endregion

    #region setlootPotion
    public void SetLootPotionUpgrade()
    {
        lootPotionLocked.SetActive(true);
    }
    #endregion

    #region setXPPotion
    public void SetXPPotionUpgrade()
    {
        XPPotionLocked.SetActive(true);
    }
    #endregion

    #region setDamagePotion
    public void SetDamagePotionUpgrade()
    {
        damagePotionLocked.SetActive(true);
    }
    #endregion

    #region setTreasureBag
    public void SetTreasureBagUpgrade()
    {
        treasureBagLocked.SetActive(true);
    }
    #endregion

    #region setMiniChest
    public void SetMiniChestUpgrace()
    {
        miniChestLocked.SetActive(true);
    }
    #endregion

    #region setMiniChest
    public void SetElixirUpgrade()
    {
        elixirLocked.SetActive(true);
    }
    #endregion

    #region setScroll
    public void SetScrollUpgrade()
    {
        scrollLocked.SetActive(true);
    }
    #endregion

    #region setGauntlet
    public void SetGauntletUpgrade()
    {
        gauntletLocked.SetActive(true);
    }
    #endregion

    #region setRelicUpgrade
    public void SetRelicUpgrade()
    {
        relicLocked.SetActive(true);
    }
    #endregion

    #region setTreasurEPotion
    public void SetTreasurePotionUpgrade()
    {
        treasurePotionLocked.SetActive(true);
    }
    #endregion

    #region setEnchantedHammer
    public void SetEnchantedHammer()
    {
        enchantedHammerLocked.SetActive(true);
    }
    #endregion

    #region setBarrel
    public void SetBarrel()
    {
        barrelLocked.SetActive(true);
    }
    #endregion

    #region setMimicChest
    public void SetMimicChest()
    {
        mimicChestLocked.SetActive(true);
    }
    #endregion

    public void ResetSpecialUpgrades()
    {
        changeText = true;
        lockedHammer.SetActive(true);
        lockedLootPotion.SetActive(true);
        lockedDamagePotion.SetActive(true);
        lockedXPPotion.SetActive(true);
        lockedKeys.SetActive(true);
        lockedGoldenToutch.SetActive(true);
        lockedTreasureBag.SetActive(true);
        lockedLockPick.SetActive(true);
        lockedElixir.SetActive(true);
        lockedScroll.SetActive(true);
        lockedGauntlet.SetActive(true);
        lockedRelic.SetActive(true);
        lockedTreasurePotion.SetActive(true);
        lockedEnchantedHammer.SetActive(true);

        hammerUpgrade.SetActive(false);
        lootPotionLocked.SetActive(false);
        XPPotionLocked.SetActive(false);
        damagePotionLocked.SetActive(false);
        keyUpgrade.SetActive(false);
        goldenTouchUpgrade.SetActive(false);
        treasureBagLocked.SetActive(false);
        miniChestLocked.SetActive(false);
        elixirLocked.SetActive(false);
        scrollLocked.SetActive(false);
        gauntletLocked.SetActive(false);
        relicLocked.SetActive(false);
        treasurePotionLocked.SetActive(false);
        enchantedHammerLocked.SetActive(false);
        barrelLocked.SetActive(false);
        mimicChestLocked.SetActive(false);

        StopAllCoroutines();
    }
}
