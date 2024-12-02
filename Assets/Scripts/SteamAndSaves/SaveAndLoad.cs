using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class SaveAndLoad : MonoBehaviour, IDataPersistence
{
    public Button autoSaveButton, resetButton;
    public static bool onlyLoadNewSave;

    public void LoadData(GameDataJSON data)
    {
        firstClick = data.firstTimePlayed;
        instantlyReturnToTotal = data.returnInstantlyToTotal;
        maximumStuffOnScreen = data.totalStuffOnScreen;
        onlyLoadNewSave = data.onlyLoadNewSave;
    }

    public void SaveData(ref GameDataJSON data)
    {
        data.firstTimePlayed = firstClick;
        data.returnInstantlyToTotal = instantlyReturnToTotal;
        data.totalStuffOnScreen = maximumStuffOnScreen;
        data.onlyLoadNewSave = onlyLoadNewSave;
    }


    private void Start()
    {
        SkillTree.isPrestiged = false;

        Invoke("wait2", 0.25f);
    }

    public GameObject languageSelect;

    public void wait2()
    {
        string path = Application.persistentDataPath + "/player.saveFirstPlayed";

        if (File.Exists(path))
        {
            if(onlyLoadNewSave == false)
            {
               // Debug.Log("SaveAndLoad");
                GameData data = SaveSystem.LoadFirstPlayed();

                firstClick = data.firstTimePlayed;
                instantlyReturnToTotal = data.returnInstantlyToTotal;
                maximumStuffOnScreen = data.totalStuffOnScreen;
            }
        }
        else
        {
            //Do nothing
        }

        if (firstClick != 1) { 
            if(PlaceMobileButtons.isMobile == true) { languageSelect.SetActive(false); }
            Welcomebar.SetActive(true);
        }


        if (firstClick == 1)
        {
            lootSliderValueSettings.text = "" + maximumStuffOnScreen;
            lootSliderSetting.value = maximumStuffOnScreen;
        }

        if (firstClick != 1)
        {
            resetButton.onClick.Invoke(); Welcomebar.SetActive(true); UIelementsClick.hideCursors = true;
            lootSlider.value = 75;
            maximumStuffOnScreen = 75;
            lootSliderValue.text = "75";
            lootSliderValueSettings.text = "75";
        }
    }
    

    public static int maximumStuffOnScreen;
    public GameObject Welcomebar;
    public static int instantlyReturnToTotal;

    public Slider lootSlider, lootSliderSetting;
    public TextMeshProUGUI lootSliderValue, lootSliderValueSettings;

    public void LootOnScreenSlider()
    {
        int sliderValue = Mathf.RoundToInt(lootSlider.value);
        string valueText = sliderValue.ToString();
        maximumStuffOnScreen = sliderValue;
        lootSliderValue.text = valueText;
        lootSliderValueSettings.text = valueText;
        lootSliderSetting.value = lootSlider.value;
    }

    public void LootOnScreenSliderSettings()
    {
        int sliderValueSettings = Mathf.RoundToInt(lootSliderSetting.value);
        string valueTextSettings = sliderValueSettings.ToString();
        maximumStuffOnScreen = sliderValueSettings;
        lootSliderValueSettings.text = valueTextSettings;

        //Debug.Log(maximumStuffOnScreen);
    }

    private void ClickButton()
    {
        
    }

    public static int firstClick;
    public GameObject shopExlemationmark;

    public void ClickFirstButton()
    {
        UIelementsClick.hideCursors = false;
        shopExlemationmark.SetActive(false);
        resetButton.onClick.Invoke();
        firstClick = 1;
        //ResetAllStats();
        Welcomebar.SetActive(false);

        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("UIClick1"); }
    }

    public GameObject maxMiniChestText;
    public GameObject miscScreen;
    public PlaceMobileButtons mobileScript;

    public void ResetAllStats()
    {
        if(PlaceMobileButtons.isMobile == true)
        {
            miscScreen.SetActive(false);
            mobileScript.OpenJustChests();
        }

        maxMiniChestText.SetActive(false);

        /////
        /////////////////////////////////////////////

        // IF CHANGING STATS IN HERE!!
        // REMEMBER TO ALWAYS CHANGE THE STATS IN SKILL TREE ASWELL
        // FOR WHEN THE PLAYER PRESTIGE

        ////////////////////////////////////////////
        /////


        //Gold
        TotalGoldAmount.totalGold = 0;

        //Auto Damage
        //HealthBar.autoDamage = 0;
        HealthBar.newPassiveDamage = 0;

        //Purchased Chests
        UnlockChests.timesPurchasedChests = 0;
        UnlockChests.boughtChest2 = 0; UnlockChests.boughtChest3 = 0; UnlockChests.boughtChest4 = 0;
        UnlockChests.boughtChest5 = 0; UnlockChests.boughtChest6 = 0; UnlockChests.boughtChest7 = 0;
        UnlockChests.boughtChest8 = 0; UnlockChests.boughtChest9 = 0; UnlockChests.boughtChest10 = 0;
        UnlockChests.boughtChest11 = 0; UnlockChests.boughtChest12 = 0; UnlockChests.boughtChest13 = 0;
        UnlockChests.boughtChest14 = 0; UnlockChests.boughtChest15 = 0; UnlockChests.boughtChest16 = 0;
        UnlockChests.boughtChest17 = 0; UnlockChests.boughtChest18 = 0; UnlockChests.boughtChest19 = 0;
        UnlockChests.boughtChest20 = 0; UnlockChests.boughtChest21 = 0; UnlockChests.boughtChest22 = 0;
        UnlockChests.boughtChest23 = 0; UnlockChests.boughtChest24 = 0; UnlockChests.boughtChest25 = 0;
        UnlockChests.boughtChest26 = 0; UnlockChests.boughtChest27 = 0;

        #region gems
        RareDropsCollected.RedGemCount = 0; RareDropsCollected.amethystCount = 0; RareDropsCollected.diamondCount = 0; RareDropsCollected.violetCrystalCount = 0;
        RareDropsCollected.yellowSapphireCount = 0; RareDropsCollected.greenDiamondCount = 0; RareDropsCollected.grandidieriteCount = 0;
        RareDropsCollected.purpleRupeeCount = 0;
        RareDropsCollected.pinkPlostCount = 0; RareDropsCollected.emeraldCount = 0; RareDropsCollected.quartzCount = 0; RareDropsCollected.redGarnetCount = 0;
        RareDropsCollected.pinkTourmalineCount = 0; RareDropsCollected.yellowTopazCount = 0; RareDropsCollected.aquamarineCount = 0; RareDropsCollected.fireOpalCount = 0;
        RareDropsCollected.goldeSeaPearlCount = 0; RareDropsCollected.akoyaPearlCount = 0; RareDropsCollected.gemSilicaCount = 0; RareDropsCollected.AdventurineCount = 0;
        RareDropsCollected.kyaniteCount = 0; RareDropsCollected.albiteCount = 0; RareDropsCollected.blackOpalCount = 0; RareDropsCollected.painiteCount = 0;
        RareDropsCollected.TanzaniteCount = 0;

        RareDropsCollected.redGemBoughtFirstTime = 0; RareDropsCollected.amethystBoughtFirstTime = 0; RareDropsCollected.diamondBoughtFirstTime = 0;
        RareDropsCollected.violetCrystalBoughtFirstTime = 0; RareDropsCollected.yellowSapphireBoughtFirstTime = 0; RareDropsCollected.greenDiamondBoughtFirstTime = 0;
        RareDropsCollected.grandidieriteBoughtFirstTime = 0; RareDropsCollected.purpleRupeeBoughtFirstTime = 0; RareDropsCollected.pinkPlortBoughtFirstTime = 0;
        RareDropsCollected.emeraldBoughtFirstTime = 0; RareDropsCollected.quartzBoughtFirstTime = 0;
        RareDropsCollected.redGarnetBoughtFirstTime = 0; RareDropsCollected.pinkTourmalineBoughtFirstTime = 0; RareDropsCollected.yellowTopazBoughtFirstTime = 0;
        RareDropsCollected.aquamarineBoughtFirstTime = 0; RareDropsCollected.fireOpalBoughtFirstTime = 0; RareDropsCollected.kyaniteBoughtFirstTime = 0;
        RareDropsCollected.albiteBoughtFirstTime = 0; RareDropsCollected.blackOpalBoughtFirstTime = 0; RareDropsCollected.painiteBoughtFirstTime = 0;
        RareDropsCollected.tanzaniteBoughtFirstTime = 0; RareDropsCollected.adventurineBoughtFirstTime = 0; RareDropsCollected.gemSilicaBoughtFirstTime = 0;
        RareDropsCollected.akoyaPearlBoughtFirstTime = 0; RareDropsCollected.goldeSeaPearlBoughtFirstTime = 0;
        #endregion

        #region CURSORS
        ClickPower.cursor1Equipped = 0; ClickPower.cursor2Equipped = 0; ClickPower.cursor3Equipped = 0; ClickPower.cursor4Equipped = 0; ClickPower.cursor5Equipped = 0; ClickPower.cursor6Equipped = 0; ClickPower.cursor7Equipped = 0; ClickPower.cursor8Equipped = 0; ClickPower.cursor9Equipped = 0; ClickPower.cursor10Equipped = 0; ClickPower.cursor11Equipped = 0; ClickPower.cursor12Equipped = 0; ClickPower.cursor13Equipped = 0; ClickPower.cursor14Equipped = 0; ClickPower.cursor15Equipped = 0; ClickPower.cursor16Equipped = 0; ClickPower.cursor17Equipped = 0; ClickPower.cursor18Equipped = 0;

        ClickPower.Cursor1Level = 1; ClickPower.cursor2Level = 1; ClickPower.cursor3Level = 1; ClickPower.cursor4Level = 1; ClickPower.cursor5Level = 1; ClickPower.cursor6Level = 1; ClickPower.cursor7Level = 1; ClickPower.cursor8Level = 1; ClickPower.cursor9Level = 1; ClickPower.cursor10Level = 1; ClickPower.cursor11Level = 1; ClickPower.cursor12Level = 1; ClickPower.cursor13Level = 1; ClickPower.cursor14Level = 1; ClickPower.cursor15Level = 1; ClickPower.cursor16Level = 1; ClickPower.cursor17Level = 1; ClickPower.cursor18Level = 1;

        //ClickPower
        ClickPower.activeUpgradeLevel = 0; ClickPower.passiveUpgradeLevel = 0; ClickPower.clickPower = 1;
        ClickPower.activeClickPowerPrice = 5; ClickPower.passiveClickPowerPrice = 10;

        //Cursor1
        ClickPower.cursor1ActiveBuffIncrement = 0.03f;

        //Cursor2
        ClickPower.cursor2PassiveBuffIncrement = 0.03f;

        //Cursor3
        ClickPower.cursor3CritChanceIncrement = 0.1f;
        ClickPower.cursor3CritDamageIncrement = 0.3f;

        //Cursor4
        ClickPower.cursor4ActiveDamageIncrement = 0.06f;
        ClickPower.cursor4PassiveDamageIncrement = 0.06f;

        //Cursor5
        ClickPower.cursor5ActiveDamageIncrement = 0.08f;
        ClickPower.cursor5CritDamageIncrement = 0.3f;
        ClickPower.cursor5CritChanceIncrement = 0.1f;

        //Cursor6
        ClickPower.cursor6PassiveDamageIncrement = 0.10f;
        ClickPower.cursor6CritChanceIncrement = 0.1f;
        ClickPower.cursor6ActiveDamageIncrement = 0.08f;
        ClickPower.cursor6CritDamageIncrement = 0.2f;

        //Cursor7
        ClickPower.cursor7CritChanceIncrement = 0.1f;
        ClickPower.cursor7ActiveDamageIncrement = 0.15f;
        ClickPower.cursor7CritDamageIncrement = 0.4f;

        //Cursor8
        ClickPower.cursor8ActiveDamageIncrement = 0.15f;
        ClickPower.cursor8PassiveDamageIncrement = 0.15f;
        ClickPower.cursor8CritChanceIncrement = 0.1f;
        ClickPower.cursor8CritDamageIncrement = 0.5f;

        //Cursor9
        ClickPower.cursor9ActiveDamageIncrement = 0.35f;
        ClickPower.cursor9PassiveDamageIncrement = 0.35f;

        //Cursor10
        ClickPower.cursor10PassiveDamageIncrement = 0.60f;

        //Cursor11
        ClickPower.cursor11ActiveDamageIncrement = 0.4f;
        ClickPower.cursor11CritChanceIncrement = 0.2f;
        ClickPower.cursor11CritDamageIncrement = 0.4f;

        //Cursor12
        ClickPower.cursor12ActiveDamageIncrement = 0.7f;
        ClickPower.cursor12PassiveDamageIncrement = 0.6f;
        ClickPower.cursor12CritChanceIncrement = 0.2f;
        ClickPower.cursor12CritDamageIncrement = 0.4f;

        //Cursor13
        ClickPower.cursor13ActiveDamageIncrement = 1f;
        ClickPower.cursor13PassiveDamageIncrement = 0.8f;
        ClickPower.cursor13CritChanceIncrement = 0.2f;
        ClickPower.cursor13CritDamageIncrement = 0.5f;

        //Cursor14
        ClickPower.cursor14ActiveDamageIncrement = 1.8f;
        ClickPower.cursor14PassiveDamageIncrement = 1.2f;
        ClickPower.cursor14CritChanceIncrement = 0.3f;
        ClickPower.cursor14CritDamageIncrement = 0.8f;

        //Cursor15
        ClickPower.cursor15ActiveDamageIncrement = 2.1f;
        ClickPower.cursor15PassiveDamageIncrement = 1.8f;
        ClickPower.cursor15CritChanceIncrement = 0.1f;
        ClickPower.cursor15CritDamageIncrement = 1f;

        //Cursor16
        ClickPower.cursor16ActiveDamageIncrement = 3f;
        ClickPower.cursor16PassiveDamageIncrement = 2.8f;
        ClickPower.cursor16CritChanceIncrement = 0.3f;
        ClickPower.cursor16CritDamageIncrement = 1.3f;

        //Cursor17
        ClickPower.cursor17ActiveDamageIncrement = 2.7f;
        ClickPower.cursor17PassiveDamageIncrement = 3.6f;
        ClickPower.cursor17CritChanceIncrement = 0.3f;
        ClickPower.cursor17CritDamageIncrement = 2.0f;

        //Cursor18
        ClickPower.cursor18ActiveDamageIncrement = 3.9f;
        ClickPower.cursor18PassiveDamageIncrement = 4.0f;
        ClickPower.cursor18CritChanceIncrement = 0.5f;
        ClickPower.cursor18CritDamageIncrement = 2.2f;

        setCursorsStartStatsActive = true;
        setCursorsStartStatsPassive = true;


        ClickPower.cursor1Change = true; ClickPower.cursor2Change = true; ClickPower.cursor3Change = true; ClickPower.cursor4Change = true; ClickPower.cursor5Change = true; ClickPower.cursor6Change = true; ClickPower.cursor7Change = true; ClickPower.cursor8Change = true; ClickPower.cursor9Change = true; ClickPower.cursor10Change = true; ClickPower.cursor11Change = true; ClickPower.cursor12Change = true; ClickPower.cursor13Change = true; ClickPower.cursor14Change = true; ClickPower.cursor15Change = true; ClickPower.cursor16Change = true; ClickPower.cursor17Change = true; ClickPower.cursor18Change = true;



        //Cursors buffs
        ClickPower.activeDamageMultiplier = 0; ClickPower.passiveDamageMultiplier = 0; ClickPower.critChance = 0; ClickPower.critDamage = 0;
        #endregion

        #region cursorsPrices
        ClickPower.cursor1QuartzUpgradePrice = 1;
        ClickPower.cursor2QuartzUpgradePrice = 1;
        ClickPower.cursor3QuartzPrice = 1;
        ClickPower.cursor3AmethystPrice = 1;
        ClickPower.cursor4TopazPrice = 1;
        ClickPower.cursor5AlbitePrice = 1;
        ClickPower.cursor6AlbitePrice = 1;
        ClickPower.cursor6RedGarnetPrice = 1;
        ClickPower.cursor7AquamarinePrice = 1;
        ClickPower.cursor8AquamarinePrice = 1;
        ClickPower.cursor8YellowSapphirePrice = 1;
        ClickPower.cursor9PinkTourmalinePrice = 1;
        ClickPower.cursor10AdventurinePrice = 1;
        ClickPower.cursor11AdventurinePrice = 1;
        ClickPower.cursor11PinkTourmalinePrice = 1;
        ClickPower.cursor12AdventurinePrice = 1;
        ClickPower.cursor12RedRubyPrice = 1;
        ClickPower.cursor13DiamondPrice = 1;
        ClickPower.cursor13GrandideritePrice = 1;
        ClickPower.cursor14VioletCrystalPrice = 1;
        ClickPower.cursor14GrandideritePrice = 1;
        ClickPower.cursor15AkoyaPeralPrice = 1;
        ClickPower.cursor15PurpleRupeePrice = 1;
        ClickPower.cursor15EmeraldPrice = 1;
        ClickPower.cursor16GreenDiamondPrice = 1;
        ClickPower.cursor16FireOpalPrice = 1;
        ClickPower.cursor16GemSilicaPrice = 1;
        ClickPower.cursor17PinkPlortPrice = 1;
        ClickPower.cursor17GoldenSeaPEarlPrice = 1;
        ClickPower.cursor17KyanitePrice = 1;
        ClickPower.cursor18BlackOpalPrice = 1;
        ClickPower.cursor18PainitePrice = 1;
        ClickPower.cursor18TanzanitePrice = 1;


        #endregion

        #region consumables/items
        //Consumables

        //Count
        UseConsumable.KeysCount = 0; UseConsumable.hammerCount = 0; UseConsumable.goldenTouchCount = 0; UseConsumable.lockPickCount = 0; UseConsumable.treasureBagCount = 0;
        UseConsumable.XPPotionCount = 0; UseConsumable.damagePotioncount = 0; UseConsumable.lootPotionCount = 0;
        UseConsumable.elixirCount = 0; UseConsumable.scrollCount = 0; UseConsumable.gauntletCount = 0; UseConsumable.relicCount = 0;

        //Buffs
        UseConsumable.lockPickSuccessChance = 30;

        UseConsumable.relicPermaActiveDamage = 0; UseConsumable.relicPermaPassiveDamage = 0; UseConsumable.relicPermaCritDamage = 0;
        UseConsumable.relicPermaCritChance = 0; UseConsumable.relicPermaGoldBuff = 0; UseConsumable.relicPermaTreasureBuff = 0;
        UseConsumable.relicPermaXPBuff = 0;

        //Scroll buffs, reset on prestige.
        UseConsumable.scrollActiveDamageBuff = 0; UseConsumable.scrollPassiveDamageBuff = 0; UseConsumable.scrollCritChanceBuff = 0; UseConsumable.scrollCritDamageBuff = 0; UseConsumable.scrollTreasureBuff = 0; UseConsumable.scrollXPBuff = 0; UseConsumable.scrollGoldBuff = 0;


        #endregion

        #region special upgrades

       


        //BoughtFristTime
        SpecialUpgradesButtons.keyBoughtFirstTime = 0; SpecialUpgradesButtons.hammerBoughtFirstTime = 0; SpecialUpgradesButtons.goldenTouchBoughtFirstTime = 0;
        SpecialUpgradesButtons.lockPickBoughtFirstTime = 0; SpecialUpgradesButtons.treasureBagBoughtFirstTime = 0; SpecialUpgradesButtons.XPPotionBoughtFirstTime = 0;
        SpecialUpgradesButtons.damagePotionBoughtFirstTime = 0; SpecialUpgradesButtons.lootPotionBoughtFirstTime = 0; SpecialUpgradesButtons.miniChestBoughtFirstTime = 0; SpecialUpgradesButtons.elixirBoughtFirstTime = 0;
        SpecialUpgradesButtons.scrollBoughtFirstTime = 0; SpecialUpgradesButtons.gauntletBoughtFirstTime = 0;
        SpecialUpgradesButtons.relicBoughtFirstTime = 0;

        //LockPick
        SpecialUpgradesButtons.lockPickPurchasePrice = 20; SpecialUpgradesButtons.lockPickDropChance = 0.1f; SpecialUpgradesButtons.lockPickDropChanceIncrement = 0.008f;
        SpecialUpgradesButtons.lockPickGemPrice = 1; SpecialUpgradesButtons.lockPickLevel = 1; SpecialUpgradesButtons.lockPickOpenChanceIncrement = 1; 
        

        //Hammer
        SpecialUpgradesButtons.hammerPurchasePrice = 500; SpecialUpgradesButtons.hammerGemUpgradePrice = 2; SpecialUpgradesButtons.hammerDropChance = 0.06f;
        SpecialUpgradesButtons.hammerDropChanceIncrement = 0.006f; SpecialUpgradesButtons.hammerLevel = 1; SpecialUpgradesButtons.hammerTimer = (8 + SkillTree.wholeNumberIncrement);
        SpecialUpgradesButtons.hammerTimerIncrement = 1; UseConsumable.hammerDamageMultiplier = 3.5f;
        SpecialUpgradesButtons.hammerDamageAmountIncrement = 0.35f;

        //Key
        SpecialUpgradesButtons.keyPurchasePrice = 15000000; SpecialUpgradesButtons.keyGemUpgradePrice = 1; SpecialUpgradesButtons.keyDropChance = 0.05f;
        SpecialUpgradesButtons.keyDropChanceIncrement = 0.006f; SpecialUpgradesButtons.keyLevel = 1; SpecialUpgradesButtons.keyRareDropChance = 8f;
        SpecialUpgradesButtons.keyRareDropChanceIncrement = 0.8f;

        //GoldenTouch
        SpecialUpgradesButtons.goldenTouchPurchasePrice = 140000; SpecialUpgradesButtons.goldenTouchGemPrice = 2; SpecialUpgradesButtons.goldenTouchDropChance = 0.04f;
        SpecialUpgradesButtons.goldenTouchDropChanceIncrement = 0.005f; SpecialUpgradesButtons.goldenTouchTimer = (15f + SkillTree.wholeNumberIncrement); SpecialUpgradesButtons.goldenTouchTimerIncrement = 1f;
        SpecialUpgradesButtons.goldenTouchLevel = 1;

        //TreasureBag
        SpecialUpgradesButtons.treasureBagBuyPrice = 115000000; SpecialUpgradesButtons.treasureBagGemPrice = 1; SpecialUpgradesButtons.treasureBagDropChanceIncrement = 0.02f;
        SpecialUpgradesButtons.treasureBagDropChance = (0.05f + SkillTree.twoDecimalNumberIncrement); SpecialUpgradesButtons.treasureBagLevel = 1;

        //XPPotion
        SpecialUpgradesButtons.XPPotionBuyPrice = 11000; SpecialUpgradesButtons.XPPotionGemPrice = 2; SpecialUpgradesButtons.XPPotionDropChance = 0.07f;
        SpecialUpgradesButtons.XPPotionDropChanceIncrement = 0.006f; SpecialUpgradesButtons.XPPotionLevel = 1; SpecialUpgradesButtons.XPPotionXPBuff = (0.60f + SkillTree.oneDecimalNumberIncrement);
        SpecialUpgradesButtons.XPPotionBufFIncrement = 0.10f; SpecialUpgradesButtons.XPPotionTimer = (30 + SkillTree.wholeNumberIncrement); SpecialUpgradesButtons.XPPotionTimerMinus = 2;

        //DamagePotion
        SpecialUpgradesButtons.damagePotionBuyPrice = 2500; SpecialUpgradesButtons.damagePotionGemPrice = 2; SpecialUpgradesButtons.damagePotionDropChance = 0.07f;
        SpecialUpgradesButtons.damagePotionDropChanceIncrement = 0.006f; SpecialUpgradesButtons.damagePotionLevel = 1; SpecialUpgradesButtons.damagePotionBuff = (0.7f + SkillTree.oneDecimalNumberIncrement);
        SpecialUpgradesButtons.damagePotionBuffIncrement = 0.10f; SpecialUpgradesButtons.damagePotionTimer = (30 + SkillTree.wholeNumberIncrement); SpecialUpgradesButtons.damagePotionTimerMinus = 2;

        //LootPotion
        SpecialUpgradesButtons.lootPotionBuyPrice = 1200; SpecialUpgradesButtons.lootPotionGemPrice = 2; SpecialUpgradesButtons.lootPotionDropChance = 0.07f;
        SpecialUpgradesButtons.lootPotionDropChanceIncrement = 0.006f; SpecialUpgradesButtons.lootPotionLevel = 1; SpecialUpgradesButtons.lootPotionBuff = (0.75f + SkillTree.oneDecimalNumberIncrement);
        SpecialUpgradesButtons.lootPotionBuffIncrement = 0.10f; SpecialUpgradesButtons.lootPotionTimer = (30 + SkillTree.wholeNumberIncrement); SpecialUpgradesButtons.lootPotionTimerMinus = 2;

        //MiniChest
        SpecialUpgradesButtons.miniChestBuyPrice = 1000000; SpecialUpgradesButtons.miniChestLevel = 1; SpecialUpgradesButtons.miniChestGemPrice = 2;
        SpecialUpgradesButtons.miniChestSpawnTimer = (300 - SkillTree.wholeNumberIncrement); SpecialUpgradesButtons.miniChestSpawnTimerMinus = 4;

        //Elixir
        SpecialUpgradesButtons.elixirLevel = 1; SpecialUpgradesButtons.elixirBoughtFirstTime = 0; SpecialUpgradesButtons.elixirGemPrice = 2;
        SpecialUpgradesButtons.elixirBuyPrice = 750000000000000000000000000f; SpecialUpgradesButtons.elixirDropChance = 0.03f; SpecialUpgradesButtons.elixirDropChanceIncrement = 0.003f; SpecialUpgradesButtons.elixirBuff = (0.7f + SkillTree.oneDecimalNumberIncrement); SpecialUpgradesButtons.elixirBuffIncrement = 0.10f; SpecialUpgradesButtons.elixirTimer = (25f + SkillTree.wholeNumberIncrement);
        SpecialUpgradesButtons.elixirTimerIncrement = 1f;

        //Scroll
        SpecialUpgradesButtons.scrollLevel = 1; SpecialUpgradesButtons.scrollBoughtFirstTime = 0;
        SpecialUpgradesButtons.scrollGemPrice = 2; SpecialUpgradesButtons.scrollBuyPrice = 1500000000000;
        SpecialUpgradesButtons.scrollDropChance = 0.02f; SpecialUpgradesButtons.scrollDropChanceIncrement = 0.001f;
        SpecialUpgradesButtons.scrollTimer = (10 + SkillTree.wholeNumberIncrement); SpecialUpgradesButtons.scrollTimerIncrement = 1;

        //Gauntlet
        SpecialUpgradesButtons.gauntletLevel = 1; SpecialUpgradesButtons.gauntletBoughtFirstTime = 0;
        SpecialUpgradesButtons.gauntletGemPrice = 3; SpecialUpgradesButtons.gauntletBuyPrice = 500000000000000000000f;
        SpecialUpgradesButtons.gauntletDropChance = 0.015f; SpecialUpgradesButtons.gauntletDropChanceIncrement = 0.001f;
        SpecialUpgradesButtons.gauntletTimer = (10f + SkillTree.wholeNumberIncrement); SpecialUpgradesButtons.gauntletTimerIncrement = 1;
        SpecialUpgradesButtons.gauntletGoldDropChance = (35f + SkillTree.wholeNumberIncrement); SpecialUpgradesButtons.gauntletGoldDropChanceIncrement = 2f;

        //Relic
        SpecialUpgradesButtons.relicLevel = 1; SpecialUpgradesButtons.relicBoughtFirstTime = 0;
        SpecialUpgradesButtons.relicGemPrice = 3; SpecialUpgradesButtons.relicGemPrice2 = 3; SpecialUpgradesButtons.relicBuyPrice = 500000000000000000000000000000f;
        SpecialUpgradesButtons.relicDropChance = (0.01f + SkillTree.twoDecimalNumberIncrement); SpecialUpgradesButtons.relicDropChanceIncrement = 0.001f;

        #endregion

        #region treasure drop chance

        SpawnRewards.doubleRareDropChance = 0;

        SpawnRewards.quartzBaseChance = 1.6f; //Common
        SpawnRewards.amethystBaseChance = 1.6f; //Common
        SpawnRewards.yellowTopacBaseChance = 1.6f; //Common
        SpawnRewards.albiteBaseChance = 1.5f; //Common
        SpawnRewards.redGarnetBaseChance = 1.5f; //Common
        SpawnRewards.aquamarineBaseChance = 1.2f; //Uncommon
        SpawnRewards.yellowSapphireBaseChance = 1.2f;//Uncommon
        SpawnRewards.pinkTourmalineBaseChance = 1.15f;//Uncommon
        SpawnRewards.adventurineBaseChance = 1.15f;//Uncommon
        SpawnRewards.redGemCBaseChance = 1f;//Rare
        SpawnRewards.diamondBaseChance = 1f;//Rare
        SpawnRewards.grandidieriteBaseChance = 1f;//Rare
        SpawnRewards.violetBaseChance = 0.85f;//Rare
        SpawnRewards.akoyaPearlBaseChance = 0.85f;//Rare
        SpawnRewards.purpleRupeeBaseChance = 0.72f;//Very rare
        SpawnRewards.emeraldDropBaseChance = 0.72f;//Very rare
        SpawnRewards.greenDiamondBaseChance = 0.69f;//Very rare
        SpawnRewards.fireOpalBaseChance = 0.69f;//Very rare
        SpawnRewards.gemSilicaBaseChance = 0.65f;//Very rare
        SpawnRewards.pinkPlortBaseChance = 0.59f;//Extremely Rare
        SpawnRewards.goldenSeaPearlBaseChance = 0.54f;//Extremely Rare
        SpawnRewards.kyaniteBaseChance = 0.5f;//Extremely Rare
        SpawnRewards.blackOpalBaseChance = 0.15f;//Legendary
        SpawnRewards.painiteBaseChance = 0.15f;//Legendary
        SpawnRewards.tanzaniteBaseChance = 0.15f;//Legendary

        SpawnRewards.astraliumBaseChance = 0.11f;//Ultra
        SpawnRewards.elysiumPrismBaseChance = 0.11f;//Ultra
        SpawnRewards.aerthfireOpalBaseChance = 0.10f;//Ultra
        SpawnRewards.eldrichStarStoneBaseChance = 0.07f;//Mythic
        SpawnRewards.chronolithChardBaseChance = 0.07f;//Mythic
        SpawnRewards.sideriumEssenceBaseChance = 0.06f;//Mythic
        SpawnRewards.quasariteBaseChance = 0.03f;//Eternal
        SpawnRewards.radiantNovaStoneBaseChance = 0.03f;//Eternal
        SpawnRewards.soluniumShardBaseChance = 0.03f;//Eternal
        #endregion

        #region skillTree
        //Skill tree
        SkillTree.crit1Bought = 0; SkillTree.crit2Bought = 0; SkillTree.crit3Bought = 0; SkillTree.crit4Bought = 0; SkillTree.crit5Bought = 0;

        SkillTree.active1Bought = 0; SkillTree.active2Bought = 0; SkillTree.active3Bought = 0; SkillTree.active4Bought = 0; SkillTree.active5Bought = 0; SkillTree.active6Bought = 0; SkillTree.active7Bought = 0;

        SkillTree.activeCursor1Bought = 0; SkillTree.activeCursor2Bought = 0; SkillTree.activeCursor3Bought = 0; SkillTree.activeCursor4Bought = 0;

        SkillTree.autoClicker1Bought = 0; SkillTree.autoClicker2Bought = 0; SkillTree.autoClicker3Bought = 0; SkillTree.autoClicker4Bought = 0;

        SkillTree.autoDamage1Bought = 0; SkillTree.autoDamage2Bought = 0; SkillTree.autoDamage3Bought = 0; SkillTree.autoDamage4Bought = 0; SkillTree.autoDamage5Bought = 0; SkillTree.autoDamage6Bought = 0; SkillTree.autoDamage7Bought = 0; SkillTree.autoDamage8Bought = 0;

        SkillTree.autoCursor1Bought = 0; SkillTree.autoCursor2Bought = 0; SkillTree.autoCursor3Bought = 0; SkillTree.autoCursor4Bought = 0; SkillTree.autoCursor5Bought = 0;

        SkillTree.gold1Bought = 0; SkillTree.gold2Bought = 0; SkillTree.gold3Bought = 0; SkillTree.gold4Bought = 0; SkillTree.gold5Bought = 0; SkillTree.gold6Bought = 0; SkillTree.gold7Bought = 0; SkillTree.gold8Bought = 0; SkillTree.gold9Bought = 0;

        SkillTree.drops1Bought = 0; SkillTree.drops2Bought = 0; SkillTree.drops3Bought = 0; SkillTree.drops4Bought = 0; SkillTree.drops5Bought = 0; SkillTree.drops6Bought = 0; SkillTree.drops7Bought = 0;

        SkillTree.xp1Bought = 0; SkillTree.xp2Bought = 0; SkillTree.xp3Bought = 0; SkillTree.xp4Bought = 0; SkillTree.xp5Bought = 0; SkillTree.xp6Bought = 0; SkillTree.xp7Bought = 0; SkillTree.xp8Bought = 0;

        SkillTree.levelSpecial1Bought = 0; SkillTree.levelSpecial2Bought = 0; SkillTree.levelSpecial3Bought = 0; SkillTree.levelSpecial4Bought = 0; SkillTree.levelSpecial5Bought = 0;

        SkillTree.strongerSpecial1Bought = 0; SkillTree.strongerSpecial2Bought = 0; SkillTree.strongerSpecial3Bought = 0; SkillTree.strongerSpecial4Bought = 0; SkillTree.strongerSpecial5Bought = 0; SkillTree.strongerSpecial6Bought = 0; SkillTree.strongerSpecial7Bought = 0;

        SkillTree.startWithItem1Bought = 0; SkillTree.startWithItem2Bought = 0; SkillTree.startWithItem3Bought = 0; SkillTree.startWithItem4Bought = 0;

        //SKill tree stats
        SkillTree.skillTreeCritChance = 0; SkillTree.skillTreeCritDamage = 0; SkillTree.crit4CritGoldChance = 0; SkillTree.crit5CritTreasureChance = 0;
        SkillTree.skillTreeActiveDamage = 0; SkillTree.active4GoldChance = 0; SkillTree.active5TreasureChance = 0; SkillTree.active6InstantlyOpenChance = 0; SkillTree.autoClicksPerSecond = 0; SkillTree.skillTreePassiveDamage = 0; SkillTree.skillTreeGold = 0; SkillTree.skillTreeXP = 0;


        #endregion

        #region rareTreasures

        RareTreasures.skullFound = 0;
        RareTreasures.trophyFound = 0;
        RareTreasures.swordFound = 0;
        RareTreasures.ringFound = 0;
        RareTreasures.starFound = 0;
        RareTreasures.crownFound = 0;
        RareTreasures.cloverFound = 0;
        RareTreasures.bookFound = 0;
        RareTreasures.guitarFOund = 0;
        RareTreasures.talarianFound = 0;
        RareTreasures.runeFound = 0;
        RareTreasures.backPackFound = 0;
        RareTreasures.shieldFound = 0;
        RareTreasures.pillBottleFound = 0;
        RareTreasures.medalFound = 0;
        RareTreasures.cookieFound = 0;

        RareTreasures.skullPassiveDamage = 0;
        RareTreasures.swordActive = 0;
        RareTreasures.swordCrit = 0;
        RareTreasures.guitarActiveAndPassive = 0;
        RareTreasures.talariaPassive = 0;
        RareTreasures.backPackGold = 0;
        RareTreasures.backPackXP = 0;
        RareTreasures.gotMedal = false;
        RareTreasures.cookieActive = 0;
        RareTreasures.cookiePassive = 0;
        RareTreasures.cookieCritChance = 0;
        RareTreasures.cookieCritDamage = 0;
        RareTreasures.cookieXP = 0;
        RareTreasures.cookieGold = 0;
        RareTreasures.cookie5X = 0;
        RareTreasures.cookie10X = 0;

        //NEW
        RareTreasures.presentFound = 0;
        RareTreasures.axeFound = 0;
        RareTreasures.coin100XFound = 0;
        RareTreasures.envelopeFound = 0;
        RareTreasures.potionFound = 0;
        RareTreasures.soulGemFound = 0;
        RareTreasures.scrollFound = 0;
        RareTreasures.brickFound = 0;
        RareTreasures.chickenFound = 0;

        RareTreasures.choseActive = 0;
        RareTreasures.chosePassive = 0;
        RareTreasures.choseCritChance = 0;
        RareTreasures.choseCritDamage = 0;
        RareTreasures.choseXP = 0;
        RareTreasures.choseGold = 0;
        RareTreasures.choseTreasureChance = 0;

        RareTreasures.choseChickenReward = false;


        #endregion

        #region stats
        Stats.goldCoinsDropped = 0;
        Stats.treasuresDropped = 0;
        Stats.treasuresDoubled = 0;
        Stats.totalGoldRecieved = 0;
        Stats.barrelOfGoldTotal = 0;
        Stats.chestOpened = 0;
        Stats.reinforedChestsOpened = 0;
        Stats.enchantedGoldenChestsOpened = 0;
        Stats.bossChestOpened = 0;
        Stats.chestClicks = 0;
        Stats.autoClicks = 0;
        Stats.criticalHits = 0;
        Stats.cursorUpgraded = 0;
        Stats.coinsSpawnedFromClicks = 0;
        Stats.treasuredSpawnedFromClicks = 0;
        Stats.itemsUsed = 0;
        Stats.itemsDropped = 0;
        Stats.itemsPurchased = 0;
        Stats.itemsUpgraded = 0;
        Stats.treasureDropChanceIncrease = 0;
        Stats.goldCoin5XDropped = 0;
        Stats.goldCoins10XDropped = 0;
        Stats.goldCoin25XDropped = 0;
        Stats.goldCoin100XDropped = 0;

        Stats.totalSkillPoints = 0;
        Stats.commonTreasureDrops = 0;
        Stats.uncommonTreasureDrops = 0;
        Stats.rareTreasureDrops = 0;
        Stats.veryRareTreasureDrops = 0;
        Stats.extremelyRareTreasureDrops = 0;
        Stats.legendaryTreasureDrops = 0;
        Stats.ultraTreasures = 0;
        Stats.mythicTreasures = 0;
        Stats.eternalTreasures = 0;
        Stats.rareTreasuresFound = 0;
        Stats.prestigedTimesCount = 0;
        Stats.prestigeUpgradesPurchased = 0;
        Stats.clickerUpgradePurchased = 0;
        Stats.loungerUpgradesPurchased = 0;
        Stats.pirateUpgradesPurchased = 0;
        Stats.hoarderUpgradeesPurchased = 0;
        Stats.adventurereUpgradesPurchased = 0;

        #endregion

        #region ACH
        Achievements.achSaves[0] = 0;
        Achievements.achSaves[1] = 0;
        Achievements.achSaves[2] = 0;
        Achievements.achSaves[3] = 0;
        Achievements.achSaves[4] = 0;
        Achievements.achSaves[5] = 0;
        Achievements.achSaves[6] = 0;
        Achievements.achSaves[7] = 0;
        Achievements.achSaves[8] = 0;
        Achievements.achSaves[9] = 0;
        Achievements.achSaves[10] = 0;
        Achievements.achSaves[11] = 0;
        Achievements.achSaves[12] = 0;
        Achievements.achSaves[13] = 0;
        Achievements.achSaves[14] = 0;
        Achievements.achSaves[15] = 0;
        Achievements.achSaves[16] = 0;
        Achievements.achSaves[17] = 0;
        Achievements.achSaves[18] = 0;
        Achievements.achSaves[19] = 0;
        Achievements.achSaves[20] = 0;
        Achievements.achSaves[21] = 0;
        Achievements.achSaves[22] = 0;
        Achievements.achSaves[23] = 0;
        Achievements.achSaves[24] = 0;
        Achievements.achSaves[25] = 0;
        Achievements.achSaves[26] = 0;
        Achievements.achSaves[27] = 0;
        Achievements.achSaves[28] = 0;
        Achievements.achSaves[29] = 0;
        Achievements.achSaves[30] = 0;
        Achievements.achSaves[31] = 0;
        Achievements.achSaves[32] = 0;
        Achievements.achSaves[33] = 0;
        Achievements.achSaves[34] = 0;
        Achievements.achSaves[35] = 0;
        Achievements.achSaves[36] = 0;
        Achievements.achSaves[37] = 0;
        Achievements.achSaves[38] = 0;
        Achievements.achSaves[39] = 0;
        Achievements.achSaves[40] = 0;
        Achievements.achSaves[41] = 0;
        Achievements.achSaves[42] = 0;
        Achievements.achSaves[43] = 0;
        Achievements.achSaves[44] = 0;
        Achievements.achSaves[45] = 0;
        Achievements.achSaves[46] = 0;
        Achievements.achSaves[47] = 0;
        Achievements.achSaves[48] = 0;
        Achievements.achSaves[49] = 0;
        Achievements.achSaves[50] = 0;
        Achievements.achSaves[51] = 0;
        Achievements.achSaves[52] = 0;
        Achievements.achSaves[53] = 0;
        Achievements.achSaves[54] = 0;
        Achievements.achSaves[55] = 0;
        Achievements.achSaves[56] = 0;
        Achievements.achSaves[57] = 0;
        Achievements.achSaves[58] = 0;
        Achievements.achSaves[59] = 0;
        Achievements.achSaves[60] = 0;
        Achievements.achSaves[61] = 0;
        Achievements.achSaves[62] = 0;
        Achievements.achSaves[63] = 0;
        Achievements.achSaves[64] = 0;
        Achievements.achSaves[65] = 0;
        Achievements.achSaves[66] = 0;
        Achievements.achSaves[67] = 0;
        Achievements.achSaves[68] = 0;
        Achievements.achSaves[69] = 0;
        Achievements.achSaves[70] = 0;
        Achievements.achSaves[71] = 0;
        Achievements.achSaves[72] = 0;
        Achievements.achSaves[73] = 0;
        Achievements.achSaves[74] = 0;
        Achievements.achSaves[75] = 0;
        Achievements.achSaves[76] = 0;
        Achievements.achSaves[77] = 0;
        Achievements.achSaves[78] = 0;
        Achievements.achSaves[79] = 0;
        Achievements.achSaves[80] = 0;
        Achievements.achSaves[81] = 0;
        Achievements.achSaves[82] = 0;
        Achievements.achSaves[83] = 0;
        Achievements.achSaves[84] = 0;
        Achievements.achSaves[85] = 0;
        Achievements.achSaves[86] = 0;
        Achievements.achSaves[87] = 0;
        Achievements.achSaves[88] = 0;
        Achievements.achSaves[89] = 0;
        Achievements.achSaves[90] = 0;
        Achievements.achSaves[91] = 0;

        Achievements.newAch100BossChest = 0;
        Achievements.newAch1Novemdecillion = 0;
        Achievements.newAch100EnchantedChest = 0;
        Achievements.newAchLevel200 = 0;
        Achievements.newAchAllAdventurer = 0;
        Achievements.newAchEnchantedHammer = 0;
        Achievements.newAchPurchaseChest32 = 0;
        Achievements.newAch25XGoldCoin1000 = 0;


        Achievements.newAch100XGoldCoin = 0;
        Achievements.newAch1Undecillion = 0;
        Achievements.newAch1Duodecillion = 0;
        Achievements.newAch1Tredecillion = 0;
        Achievements.newAch1Quattuordecillion = 0;
        Achievements.newAch1Quindecillion = 0;
        Achievements.newAch1Sexdecillion = 0;
        Achievements.newAch1Septendecillion = 0;
        Achievements.newAch1Octodecillion = 0;
        Achievements.newAchLevel150 = 0;
        Achievements.newAch20KSkillPoints = 0;
        Achievements.newAch2MillionGoldCoins = 0;
        Achievements.newAch100KTreasures = 0;
        Achievements.newAch100Ultra = 0;
        Achievements.newAch100Mythic = 0;
        Achievements.newAch100Eternal = 0;
        Achievements.newAch2500Reinforced = 0;
        Achievements.newAchUseChicken = 0;
        Achievements.newAchChest37 = 0;
        Achievements.newAch5X250KDrop = 0;

        #endregion

        #region newSaves
        //NEW PRICES
        SpecialUpgradesButtons.newLockPickPrice = 20;
        SpecialUpgradesButtons.newHammerPrice = 500;
        SpecialUpgradesButtons.newLootPotionPrice = 1200;
        SpecialUpgradesButtons.newDamagePotionPrice = 2500;
        SpecialUpgradesButtons.newXPPotionPrice = 11000;
        SpecialUpgradesButtons.newGoldenTouchPrice = 140000;
        SpecialUpgradesButtons.newMiniChestPrice = 1000000;
        SpecialUpgradesButtons.newkeyPrice = 15000000;
        SpecialUpgradesButtons.newTreasureBagPrice = 115000000;
        SpecialUpgradesButtons.newScrollPrice = 1500000000000;
        SpecialUpgradesButtons.newGauntletPrice = 500000000000000000000f;
        SpecialUpgradesButtons.newElixirPRice = 750000000000000000000000000f;
        SpecialUpgradesButtons.newRelicPrice = 500000000000000000000000000000f;

        UpdateGame.totalGoldHigher = 0;
        Stats.totalGoldStatsDouble = 0;

        ClickPower.newActiveDamage = 1;
        ClickPower.newActiveDamagePrice = 5;
        ClickPower.newPassiveDamagePrice = 10;

        //All new update saves
        ClickPower.cursor19Equipped = 0;
        ClickPower.cursor20Equipped = 0;
        ClickPower.cursor21Equipped = 0;

        ClickPower.cursor19Level = 1;
        ClickPower.cursor20Level = 1;
        ClickPower.cursor21Level = 1;

        ClickPower.cursor19AstraliumPrice = 1;
        ClickPower.cursor19ElysiumPrismPrice = 1;
        ClickPower.cursor19AerthfireOpalPrice = 1;
        ClickPower.cursor20EldritchStarStonePrice = 1;
        ClickPower.cursor20ChronolithShardPrice = 1;
        ClickPower.cursor20SideriumEssencePrice = 1;
        ClickPower.cursor21QuasaritePrice = 1;
        ClickPower.cursor21RadiantNovaStonePrice = 1;
        ClickPower.cursor21SoluniumShardPrice = 1;

        //Cursor19
        ClickPower.cursor19ActiveDamage = 24f;
        ClickPower.cursor19ActiveDamageIncrement = 4f;
        ClickPower.cursor19PassiveDamage = 27f;
        ClickPower.cursor19PassiveDamageIncrement = 5.5f;
        ClickPower.cursor19CritChance = 6f;
        ClickPower.cursor19CritChanceIncrement = 0.8f;
        ClickPower.cursor19CritDamage = 32f;
        ClickPower.cursor19CritDamageIncrement = 7f;

        //Cursor20
        ClickPower.cursor20ActiveDamage = 49f;
        ClickPower.cursor20ActiveDamageIncrement = 9f;
        ClickPower.cursor20PassiveDamage = 45f;
        ClickPower.cursor20PassiveDamageIncrement = 9f;
        ClickPower.cursor20CritChance = 4f;
        ClickPower.cursor20CritChanceIncrement = 0.4f;
        ClickPower.cursor20CritDamage = 50f;
        ClickPower.cursor20CritDamageIncrement = 10f;

        //Cursor19
        ClickPower.cursor21ActiveDamage = 75f;
        ClickPower.cursor21ActiveDamageIncrement = 10f;
        ClickPower.cursor21PassiveDamage = 75f;
        ClickPower.cursor21PassiveDamageIncrement = 10f;
        ClickPower.cursor21CritChance = 8f;
        ClickPower.cursor21CritChanceIncrement = 0.7f;
        ClickPower.cursor21CritDamage = 100f;
        ClickPower.cursor21CritDamageIncrement = 10f;

        UpdateGame.reinforcedPrestigeChanceIncrease = 0;
        UpdateGame.reinforcedChestHealth = 10;
        UpdateGame.reinforcedChestGoldIncrease = 12;
        UpdateGame.reinforcedXPIncrease = 3;

        UpdateGame.enchantedGoldenChestChance = 0;
        UpdateGame.enchantedGoldenChestHealth = 0;
        UpdateGame.enchantedGoldenChestTreasureDrops = 0;
        UpdateGame.enchantedGoldenChestXPDrops = 0;

        UpdateGame.bossChestChance = 0;
        UpdateGame.bossChestHealth = 0;
        UpdateGame.bossChestGoldAmount = 0;
        UpdateGame.bossChestGoldCoinsDrops = 0;
        UpdateGame.bossChestGoldValue = 0;
        UpdateGame.bossChestXPDrops = 0;

        UpdateGame.barrelBuyPriceDouble = 65000000000;
        UpdateGame.mimicChestBuyPriceDouble = 48000000000000000;
        UpdateGame.treasurePotionBuyPriceDouble = 69000000000000000000000000000000000000f;
        UpdateGame.knifeBuyPriceDouble = 25000000000000000000000000000000000000000000000.5;

        UpdateGame.knifeBoughtFirstTime = 0;
        UpdateGame.barrelBoughtFirstTime = 0;
        UpdateGame.treasurePotionBoughtFirstTime = 0;
        UpdateGame.mimicChestBoughtFirstTime = 0;

        UpdateGame.knifeDropChance = 0.01f;
        UpdateGame.knifeDropChanceIncrement = 0.002f;
        UpdateGame.treasurePotionDropChance = 0.03f;
        UpdateGame.treasurePotionDropChanceIncrement = 0.003f;

        UpdateGame.knifeLevel = 1;
        UpdateGame.barrelLevel = 1;
        UpdateGame.treasurePotionLevel = 1;
        UpdateGame.mimicChestLevel = 1;

        UpdateGame.knifeGemPrice = 3;
        UpdateGame.knifeGemPrice2 = 3;
        UpdateGame.barrelGemPrice = 1;
        UpdateGame.treasurePotionGemPrice = 3;
        UpdateGame.treasurePotionGemPrice2 = 3;
        UpdateGame.mimicChestGemPrice = 1;

        UpdateGame.mimicPositiveBuffChance = 25;
        UpdateGame.mimicPositiveBiffChanceIncrement = 1;
        UpdateGame.mimicNegativeBuffChance = 75;
        UpdateGame.mimicNegativeBuffChanceIncrement = 1;
        UpdateGame.mimicChestTimer = 300;
        UpdateGame.mimicChestTimerIncrement = 3;

        UpdateGame.reinforced1Bought = 0;
        UpdateGame.reinforced2Bought = 0;
        UpdateGame.reinforced3Bought = 0;
        UpdateGame.reinforced4Bought = 0;
        UpdateGame.reinforced5Bought = 0;

        UpdateGame.greaterLoot1Bought = 0;
        UpdateGame.greaterLoot2Bought = 0;
        UpdateGame.greaterLoot3Bought = 0;
        UpdateGame.greaterLoot4Bought = 0;
        UpdateGame.greaterLoot5Bought = 0;

        UpdateGame.newChests1Bought = 0;
        UpdateGame.newChests2Bought = 0;
        UpdateGame.newChests3Bought = 0;
        UpdateGame.newChests4Bought = 0;
        UpdateGame.newChests5Bought = 0;
        UpdateGame.newChests6Bought = 0;

        UpdateGame.barrelOfGoldAmountDouble = 0;

        UpdateGame.knifeTimer = 8;
        UpdateGame.knifeTimerIncrement = 1;
        UpdateGame.knifeCount = 0;

        UpdateGame.treasurePotionTimer = 13;
        UpdateGame.treasurePotionTimerIncrement = 1;
        UpdateGame.treasurePotionCount = 0;

        UpdateGame.barrelGoldValue = 1;
        UpdateGame.barrelGoldValueIncrement = 0.05f;
        #endregion

        //PlayerLevelAndSkillPoints
        PlayerLevel.playerLevel = 0;
        PlayerLevel.skillPoints = 0;
        PlayerLevel.experienceGained = 0;
        PlayerLevel.experienceNeeded = 250;

        RareDropsCollected.isGemCountUpdated = true;
        SpecialUpgradesButtons.changeText = true;
        ClickPower.cursorsPriceChanged = true;
        SpecialUpgradesButtons.specialTextChange = true;
        UseConsumable.changeCountText = true;
        RareDropsCollected.setTreasureTextRed = true;
        pressedResetButton = true;
        ClickPower.resetClickDamage = true;
        SkillTree.setSoulGemInactive = true;

        resetMiniChests = true;
        resetMimicChest = true;



        purchaseTreasure.interactable = false;
        purchaseTreasureLocked.SetActive(true); purchaseTreasureUnlocked.SetActive(false); purchaeTreasureAll.SetActive(false); hunderPercentText.SetActive(false); treasureLockIcon.SetActive(true); treasurePriceText.SetActive(false);

        RareTreasures.allTreasuresFound = false;
        SpawnRewards.prestigeKeyFound = 0;
        SpawnRewards.prestigeChestFound = 0;

        SpecialUpgradesButtons.hammerOff = false; SpecialUpgradesButtons.lootOff = false; SpecialUpgradesButtons.damageOff = false; SpecialUpgradesButtons.XPOff = false; SpecialUpgradesButtons.goldenTouchOff = false; SpecialUpgradesButtons.miniChestOff = false; SpecialUpgradesButtons.keyOff = false; SpecialUpgradesButtons.treasureBagOff = false; SpecialUpgradesButtons.scrollOff = false; SpecialUpgradesButtons.gauntletOff = false; SpecialUpgradesButtons.elixirOFf = false; SpecialUpgradesButtons.relicOff = false;

        StartCoroutine(wait());

        ClickButton();
    }

    public Button purchaseTreasure;
    public GameObject purchaseTreasureLocked, purchaseTreasureUnlocked, purchaeTreasureAll, hunderPercentText, treasureLockIcon, treasurePriceText;

    public static bool resetMiniChests, resetMimicChest;

    public static bool setCursorsStartStatsActive, setCursorsStartStatsPassive;

    private void Update()
    {
        if(pressedResetButton == true)
        {
            TotalGoldAmount.totalGold = 0;
            UpdateGame.totalGoldHigher = 0;
        }

        if(setCursorsStartStatsActive == true)
        {

            //Cursors1
            ClickPower.cursor1ActiveBuff = 0.05f;

            //Cursor3
            ClickPower.cursor3CritChance = 0.8f; ClickPower.cursor3CritDamage = 2f;

            //Cursor4
            ClickPower.cursor4ActiveDamage = 0.11f;  

            //Cursor5
            ClickPower.cursor5ActiveDamage = 0.25f;  ClickPower.cursor5CritChance = 2f; ClickPower.cursor5CritDamage = 2.5f;  

            //Cursor6
              ClickPower.cursor6CritChance = 1f;
             ClickPower.cursor6CritDamage = 4.1f; ClickPower.cursor6ActiveDamage = 0.15f;

            //Cursor7
            ClickPower.cursor7CritChance = 2.5f; ClickPower.cursor7CritDamage = 4.8f;  ClickPower.cursor7ActiveDamage = 0.70f; 

            //Cursor8
            ClickPower.cursor8ActiveDamage = 0.6f; 
            ClickPower.cursor8CritChance = 1.4f; ClickPower.cursor8CritDamage = 6.2f; 

            //Cursor9
            ClickPower.cursor9ActiveDamage = 1.5f;  

            //Cursor11
            ClickPower.cursor11ActiveDamage = 1.7f; ClickPower.cursor11CritChance = 3.4f;  ClickPower.cursor11CritDamage = 4f; 

            //Cursor12
            ClickPower.cursor12ActiveDamage = 2.9f;  ClickPower.cursor12CritChance = 2.9f;  ClickPower.cursor12CritDamage = 6.7f; 

            //Cursor13
            ClickPower.cursor13ActiveDamage = 5.2f;   ClickPower.cursor13CritChance = 1.2f;  ClickPower.cursor13CritDamage = 8.7f;

            //Cursor14
            ClickPower.cursor14ActiveDamage = 5f;   ClickPower.cursor14CritChance = 3f; ClickPower.cursor14CritDamage = 9.3f; 

            //Cursor15
            ClickPower.cursor15ActiveDamage = 8.5f;  ClickPower.cursor15CritChance = 1.8f;  ClickPower.cursor15CritDamage = 14f; 

            //Cursor16
            ClickPower.cursor16ActiveDamage = 8.8f;   ClickPower.cursor16CritChance = 3.9f;  ClickPower.cursor16CritDamage = 13f; 

            //Cursor17
            ClickPower.cursor17ActiveDamage = 11f; ClickPower.cursor17CritChance = 3f;  ClickPower.cursor17CritDamage = 16f; 

            //Cursor18
            ClickPower.cursor18ActiveDamage = 15f;  ClickPower.cursor18CritChance = 4.3f;  ClickPower.cursor18CritDamage = 18f;

            //Cursor 19
            ClickPower.cursor19ActiveDamage = 24f; ClickPower.cursor19CritChance = 6f; ClickPower.cursor19CritDamage = 32f;

            //Cursor 20
            ClickPower.cursor20ActiveDamage = 49f; ClickPower.cursor20CritChance = 4f; ClickPower.cursor20CritDamage = 50f;

            //Cursor 21
            ClickPower.cursor21ActiveDamage = 75f; ClickPower.cursor21CritChance = 8f; ClickPower.cursor21CritDamage = 100f;

            setCursorsStartStatsActive = false;
        }

        if (setCursorsStartStatsPassive == true)
        {
            ClickPower.cursor2PassiveBuff = 0.05f;

            ClickPower.cursor4PassiveDamage = 0.11f;

            ClickPower.cursor6PassiveDamage = 0.35f;

            ClickPower.cursor8PassiveDamage = 0.6f;

            ClickPower.cursor9PassiveDamage = 1.5f;

            ClickPower.cursor10PassiveDamage = 3.2f;

            ClickPower.cursor12PassiveDamage = 2.9f;

            ClickPower.cursor13PassiveDamage = 3.7f;

            ClickPower.cursor14PassiveDamage = 7f;

            ClickPower.cursor15PassiveDamage = 8.5f;

            ClickPower.cursor16PassiveDamage = 10f;

            ClickPower.cursor17PassiveDamage = 11f;

            ClickPower.cursor18PassiveDamage = 15f;

            ClickPower.cursor19PassiveDamage = 27f;

            ClickPower.cursor20PassiveDamage = 45f;

            ClickPower.cursor21PassiveDamage = 75f;

            setCursorsStartStatsPassive = false;
        }

        if(maximumStuffOnScreen < 0)
        {
            maximumStuffOnScreen = 0;
        }

    }

    public static bool pressedResetButton;
    IEnumerator wait()
    {
        yield return new WaitForSeconds(1.5f);
        pressedResetButton = false;
        RareDropsCollected.isGemCountUpdated = true;
        SkillTree.setSoulGemInactive = false;

        UseConsumable.KeysCount = 0; UseConsumable.hammerCount = 0; UseConsumable.goldenTouchCount = 0; UseConsumable.lockPickCount = 0; UseConsumable.treasureBagCount = 0;
        UseConsumable.XPPotionCount = 0; UseConsumable.damagePotioncount = 0; UseConsumable.lootPotionCount = 0;

        resetMiniChests = false;
        resetMimicChest = false;

        #region gems
        RareDropsCollected.RedGemCount = 0; RareDropsCollected.amethystCount = 0; RareDropsCollected.diamondCount = 0; RareDropsCollected.violetCrystalCount = 0;
        RareDropsCollected.yellowSapphireCount = 0; RareDropsCollected.greenDiamondCount = 0; RareDropsCollected.grandidieriteCount = 0;
        RareDropsCollected.purpleRupeeCount = 0;
        RareDropsCollected.pinkPlostCount = 0; RareDropsCollected.emeraldCount = 0; RareDropsCollected.quartzCount = 0; RareDropsCollected.redGarnetCount = 0;
        RareDropsCollected.pinkTourmalineCount = 0; RareDropsCollected.yellowTopazCount = 0; RareDropsCollected.aquamarineCount = 0; RareDropsCollected.fireOpalCount = 0;
        RareDropsCollected.goldeSeaPearlCount = 0; RareDropsCollected.akoyaPearlCount = 0; RareDropsCollected.gemSilicaCount = 0; RareDropsCollected.AdventurineCount = 0;
        RareDropsCollected.kyaniteCount = 0; RareDropsCollected.albiteCount = 0; RareDropsCollected.blackOpalCount = 0; RareDropsCollected.painiteCount = 0;
        RareDropsCollected.TanzaniteCount = 0;

        //NEW
        RareDropsCollected.astraliumCount = 0; RareDropsCollected.elysiumPrismCount = 0; RareDropsCollected.aetherfireOpalCount = 0; RareDropsCollected.eldritchStarstoneCount = 0; RareDropsCollected.chronolithShardCount = 0; RareDropsCollected.sideriumEssenceCount = 0; RareDropsCollected.quasariteCount = 0; RareDropsCollected.radiantNovaStoneCount = 0; RareDropsCollected.soluniumShardCount = 0;


        RareDropsCollected.redGemBoughtFirstTime = 0; RareDropsCollected.amethystBoughtFirstTime = 0; RareDropsCollected.diamondBoughtFirstTime = 0;
        RareDropsCollected.violetCrystalBoughtFirstTime = 0; RareDropsCollected.yellowSapphireBoughtFirstTime = 0; RareDropsCollected.greenDiamondBoughtFirstTime = 0;
        RareDropsCollected.grandidieriteBoughtFirstTime = 0; RareDropsCollected.purpleRupeeBoughtFirstTime = 0; RareDropsCollected.pinkPlortBoughtFirstTime = 0;
        RareDropsCollected.emeraldBoughtFirstTime = 0; RareDropsCollected.quartzBoughtFirstTime = 0;
        RareDropsCollected.redGarnetBoughtFirstTime = 0; RareDropsCollected.pinkTourmalineBoughtFirstTime = 0; RareDropsCollected.yellowTopazBoughtFirstTime = 0;
        RareDropsCollected.aquamarineBoughtFirstTime = 0; RareDropsCollected.fireOpalBoughtFirstTime = 0; RareDropsCollected.kyaniteBoughtFirstTime = 0;
        RareDropsCollected.albiteBoughtFirstTime = 0; RareDropsCollected.blackOpalBoughtFirstTime = 0; RareDropsCollected.painiteBoughtFirstTime = 0;
        RareDropsCollected.tanzaniteBoughtFirstTime = 0; RareDropsCollected.adventurineBoughtFirstTime = 0; RareDropsCollected.gemSilicaBoughtFirstTime = 0;
        RareDropsCollected.akoyaPearlBoughtFirstTime = 0; RareDropsCollected.goldeSeaPearlBoughtFirstTime = 0;

        //NEW
        RareDropsCollected.astraliumBoughtFirstTime = 0; RareDropsCollected.elysiumPrismBoughtFirstTime = 0; RareDropsCollected.aetherfireOpalBoughtFirstTime = 0; RareDropsCollected.eldritchStarstoneBoughtFirstTime = 0; RareDropsCollected.chronolithShardBoughtFirstTime = 0; RareDropsCollected.sideriumEssenceBoughtFirstTime = 0; RareDropsCollected.quasariteBoughtFirstTime = 0; RareDropsCollected.radiantNovaStoneBoughtFirstTime = 0; RareDropsCollected.soluniumShardBoughtFirstTime = 0;

        #endregion
    }


    //public void SaveSaveAndLoad()
    //{
    //    SaveSystem.SaveFirstPlayed(this);
    //}

}
