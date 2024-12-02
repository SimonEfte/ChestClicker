using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
public class SkillTree : MonoBehaviour, IDataPersistence
{
    public static bool isInSkillTree;
    public float alphaValueFull = 1f;
    public float alphaHalf = 0.35f;

    public static float skillTreeCritChance, skillTreeCritDamage;
    public static float skillTreeActiveDamage;
    public static float skillTreeAutoClicker, skillTreePassiveDamage;
    public static float skillTreeGold, skillTreeDrops, skillTreeXP;

    public GameObject prestigeChestPopUp, prestigeChest, prestigeChestOpen;
    public GameObject keyAnim, prestigeScreenAnim;

    public static int wholeNumberIncrement;
    public static float twoDecimalNumberIncrement;
    public static float oneDecimalNumberIncrement;

    public static int activeCursorWholeNumberIncrement;

    public GameObject[] critUnlocked = new GameObject[5];
    public GameObject[] activeUnlocked = new GameObject[6];
    public GameObject[] activeCursorUnlocked = new GameObject[4];

    public GameObject[] autoClickerUnlocked = new GameObject[4];
    public GameObject[] passiveUnlocked = new GameObject[7];
    public GameObject[] passiveCursorUnlocked = new GameObject[4];

    public GameObject[] goldUnlocked = new GameObject[7];
    public GameObject[] treasureUnlocked = new GameObject[6];
    public GameObject[] XPUnlocked = new GameObject[6];

    public GameObject[] levelUpSpecialUnlocked = new GameObject[4];
    public GameObject[] strongerSpecialUnlocked = new GameObject[5];
    public GameObject[] startWitchUnlcoked = new GameObject[4];

    public TextMeshProUGUI[] critTextPricesText = new TextMeshProUGUI[5];
    public TextMeshProUGUI[] activeDamagePricesText = new TextMeshProUGUI[6];
    public TextMeshProUGUI[] activeCursorUpgradePricesText = new TextMeshProUGUI[4];

    public TextMeshProUGUI[] autoClickerPricesText = new TextMeshProUGUI[4];
    public TextMeshProUGUI[] autoDamagePricesText = new TextMeshProUGUI[7];
    public TextMeshProUGUI[] passiveCursorPricesText = new TextMeshProUGUI[4];

    public TextMeshProUGUI[] goldPricesText = new TextMeshProUGUI[7];
    public TextMeshProUGUI[] treasuresPriceText = new TextMeshProUGUI[6];
    public TextMeshProUGUI[] XPPricesText = new TextMeshProUGUI[6];

    public TextMeshProUGUI[] levelUpSpeciaPriceslText = new TextMeshProUGUI[4];
    public TextMeshProUGUI[] strongerSpecialPricesText = new TextMeshProUGUI[5];
    public TextMeshProUGUI[] startWithPricesText = new TextMeshProUGUI[4];

    public static bool isInsideskillTree;
    public int allUpgradesPrice;

    public TextMeshProUGUI  nextSkillPoints;
    public string popUpPrestigeAndLevelText;

    public void Start()
    {
        alphaHalf = 0.45f;
        alphaValueFull = 1f;
        isInsideskillTree = false;

        StartCoroutine(waitSkillTree());
    }

    #region SaveAndLoadJSON
    public void LoadData(GameDataJSON data)
    {
        autoClicksPerSecond = data.autoClicksPerSecond;
        skillTreeCritChance = data.skillTreeCritChance;
        skillTreeCritDamage = data.skillTreeCritDamage;
        crit4CritGoldChance = data.crit4CritGoldChance;
        crit5CritTreasureChance = data.crit5CritTreasureChance;
        skillTreeActiveDamage = data.skillTreeActiveDamage;
        active4GoldChance = data.active4GoldChance;
        active5TreasureChance = data.active5TreasureChance;
        active6InstantlyOpenChance = data.active6InstantlyOpenChance;
        skillTreePassiveDamage = data.skillTreePassiveDamage;
        skillTreeGold = data.skillTreeGold;
        skillTreeXP = data.skillTreeXP;

        crit1Bought = data.crit1Bought;
        crit2Bought = data.crit2Bought;
        crit3Bought = data.crit3Bought;
        crit4Bought = data.crit4Bought;
        crit5Bought = data.crit5Bought;

        active1Bought = data.active1Bought;
        active2Bought = data.active2Bought;
        active3Bought = data.active3Bought;
        active4Bought = data.active4Bought;
        active5Bought = data.active5Bought;
        active6Bought = data.active6Bought;
        active7Bought = data.active7Bought;

        activeCursor1Bought = data.activeCursor1Bought;
        activeCursor2Bought = data.activeCursor2Bought;
        activeCursor3Bought = data.activeCursor3Bought;
        activeCursor4Bought = data.activeCursor4Bought;

        autoClicker1Bought = data.autoClicker1Bought;
        autoClicker2Bought = data.autoClicker2Bought;
        autoClicker3Bought = data.autoClicker3Bought;
        autoClicker4Bought = data.autoClicker4Bought;

        autoDamage1Bought = data.autoDamage1Bought;
        autoDamage2Bought = data.autoDamage2Bought;
        autoDamage3Bought = data.autoDamage3Bought;
        autoDamage4Bought = data.autoDamage4Bought;
        autoDamage5Bought = data.autoDamage5Bought;
        autoDamage6Bought = data.autoDamage6Bought;
        autoDamage7Bought = data.autoDamage7Bought;
        autoDamage8Bought = data.autoDamage8Bought;

        autoCursor1Bought = data.autoCursor1Bought;
        autoCursor2Bought = data.autoCursor2Bought;
        autoCursor3Bought = data.autoCursor3Bought;
        autoCursor4Bought = data.autoCursor4Bought;
        autoCursor5Bought = data.autoCursor5Bought;

        gold1Bought = data.gold1Bought;
        gold2Bought = data.gold2Bought;
        gold3Bought = data.gold3Bought;
        gold4Bought = data.gold4Bought;
        gold5Bought = data.gold5Bought;
        gold6Bought = data.gold6Bought;
        gold7Bought = data.gold7Bought;
        gold8Bought = data.gold8Bought;
        gold9Bought = data.gold9Bought;

        drops1Bought = data.drops1Bought;
        drops2Bought = data.drops2Bought;
        drops3Bought = data.drops3Bought;
        drops4Bought = data.drops4Bought;
        drops5Bought = data.drops5Bought;
        drops6Bought = data.drops6Bought;
        drops7Bought = data.drops7Bought;

        xp1Bought = data.xp1Bought;
        xp2Bought = data.xp2Bought;
        xp3Bought = data.xp3Bought;
        xp4Bought = data.xp4Bought;
        xp5Bought = data.xp5Bought;
        xp6Bought = data.xp6Bought;
        xp7Bought = data.xp7Bought;
        xp8Bought = data.xp8Bought;

        levelSpecial1Bought = data.levelSpecial1Bought;
        levelSpecial2Bought = data.levelSpecial2Bought;
        levelSpecial3Bought = data.levelSpecial3Bought;
        levelSpecial4Bought = data.levelSpecial4Bought;
        levelSpecial5Bought = data.levelSpecial5Bought;

        strongerSpecial1Bought = data.strongerSpecial1Bought;
        strongerSpecial2Bought = data.strongerSpecial2Bought;
        strongerSpecial3Bought = data.strongerSpecial3Bought;
        strongerSpecial4Bought = data.strongerSpecial4Bought;
        strongerSpecial5Bought = data.strongerSpecial5Bought;
        strongerSpecial6Bought = data.strongerSpecial6Bought;
        strongerSpecial7Bought = data.strongerSpecial7Bought;

        startWithItem1Bought = data.startWithItem1Bought;
        startWithItem2Bought = data.startWithItem2Bought;
        startWithItem3Bought = data.startWithItem3Bought;
        startWithItem4Bought = data.startWithItem4Bought;
    }

    public void SaveData(ref GameDataJSON data)
    {
        data.autoClicksPerSecond = autoClicksPerSecond;
        data.skillTreeCritChance = skillTreeCritChance;
        data.skillTreeCritDamage = skillTreeCritDamage;
        data.crit4CritGoldChance = crit4CritGoldChance;
        data.crit5CritTreasureChance = crit5CritTreasureChance;
        data.skillTreeActiveDamage = skillTreeActiveDamage;
        data.active4GoldChance = active4GoldChance;
        data.active5TreasureChance = active5TreasureChance;
        data.active6InstantlyOpenChance = active6InstantlyOpenChance;
        data.skillTreePassiveDamage = skillTreePassiveDamage;
        data.skillTreeGold = skillTreeGold;
        data.skillTreeXP = skillTreeXP;

        data.crit1Bought = crit1Bought;
        data.crit2Bought = crit2Bought;
        data.crit3Bought = crit3Bought;
        data.crit4Bought = crit4Bought;
        data.crit5Bought = crit5Bought;

        data.active1Bought = active1Bought;
        data.active2Bought = active2Bought;
        data.active3Bought = active3Bought;
        data.active4Bought = active4Bought;
        data.active5Bought = active5Bought;
        data.active6Bought = active6Bought;
        data.active7Bought = active7Bought;

        data.activeCursor1Bought = activeCursor1Bought;
        data.activeCursor2Bought = activeCursor2Bought;
        data.activeCursor3Bought = activeCursor3Bought;
        data.activeCursor4Bought = activeCursor4Bought;

        data.autoClicker1Bought = autoClicker1Bought;
        data.autoClicker2Bought = autoClicker2Bought;
        data.autoClicker3Bought = autoClicker3Bought;
        data.autoClicker4Bought = autoClicker4Bought;

        data.autoDamage1Bought = autoDamage1Bought;
        data.autoDamage2Bought = autoDamage2Bought;
        data.autoDamage3Bought = autoDamage3Bought;
        data.autoDamage4Bought = autoDamage4Bought;
        data.autoDamage5Bought = autoDamage5Bought;
        data.autoDamage6Bought = autoDamage6Bought;
        data.autoDamage7Bought = autoDamage7Bought;
        data.autoDamage8Bought = autoDamage8Bought;

        data.autoCursor1Bought = autoCursor1Bought;
        data.autoCursor2Bought = autoCursor2Bought;
        data.autoCursor3Bought = autoCursor3Bought;
        data.autoCursor4Bought = autoCursor4Bought;
        data.autoCursor5Bought = autoCursor5Bought;

        data.gold1Bought = gold1Bought;
        data.gold2Bought = gold2Bought;
        data.gold3Bought = gold3Bought;
        data.gold4Bought = gold4Bought;
        data.gold5Bought = gold5Bought;
        data.gold6Bought = gold6Bought;
        data.gold7Bought = gold7Bought;
        data.gold8Bought = gold8Bought;
        data.gold9Bought = gold9Bought;

        data.drops1Bought = drops1Bought;
        data.drops2Bought = drops2Bought;
        data.drops3Bought = drops3Bought;
        data.drops4Bought = drops4Bought;
        data.drops5Bought = drops5Bought;
        data.drops6Bought = drops6Bought;
        data.drops7Bought = drops7Bought;

        data.xp1Bought = xp1Bought;
        data.xp2Bought = xp2Bought;
        data.xp3Bought = xp3Bought;
        data.xp4Bought = xp4Bought;
        data.xp5Bought = xp5Bought;
        data.xp6Bought = xp6Bought;
        data.xp7Bought = xp7Bought;
        data.xp8Bought = xp8Bought;

        data.levelSpecial1Bought = levelSpecial1Bought;
        data.levelSpecial2Bought = levelSpecial2Bought;
        data.levelSpecial3Bought = levelSpecial3Bought;
        data.levelSpecial4Bought = levelSpecial4Bought;
        data.levelSpecial5Bought = levelSpecial5Bought;

        data.strongerSpecial1Bought = strongerSpecial1Bought;
        data.strongerSpecial2Bought = strongerSpecial2Bought;
        data.strongerSpecial3Bought = strongerSpecial3Bought;
        data.strongerSpecial4Bought = strongerSpecial4Bought;
        data.strongerSpecial5Bought = strongerSpecial5Bought;
        data.strongerSpecial6Bought = strongerSpecial6Bought;
        data.strongerSpecial7Bought = strongerSpecial7Bought;

        data.startWithItem1Bought = startWithItem1Bought;
        data.startWithItem2Bought = startWithItem2Bought;
        data.startWithItem3Bought = startWithItem3Bought;
        data.startWithItem4Bought = startWithItem4Bought;
    }
    #endregion

    IEnumerator waitSkillTree()
    {
        yield return new WaitForSeconds(0.34f);
        nextSkillPoints.text = Localization.nextLevelHover + "<color=green>+" + ((PlayerLevel.playerLevel / 5) + 1) + "<color=white>" + Localization.skillPointsHover; ;

        #region oldSave
        string path = Application.persistentDataPath + "/player.saveSkillTree";

        if (File.Exists(path))
        {
            if (SaveAndLoad.onlyLoadNewSave == false)
            {
                GameData data = SaveSystem.LoadSkillTree();

                autoClicksPerSecond = data.autoClicksPerSecond;
                skillTreeCritChance = data.skillTreeCritChance;
                skillTreeCritDamage = data.skillTreeCritDamage;
                crit4CritGoldChance = data.crit4CritGoldChance;
                crit5CritTreasureChance = data.crit5CritTreasureChance;
                skillTreeActiveDamage = data.skillTreeActiveDamage;
                active4GoldChance = data.active4GoldChance;
                active5TreasureChance = data.active5TreasureChance;
                active6InstantlyOpenChance = data.active6InstantlyOpenChance;
                skillTreePassiveDamage = data.skillTreePassiveDamage;
                skillTreeGold = data.skillTreeGold;
                skillTreeXP = data.skillTreeXP;

                crit1Bought = data.crit1Bought;
                crit2Bought = data.crit2Bought;
                crit3Bought = data.crit3Bought;
                crit4Bought = data.crit4Bought;
                crit5Bought = data.crit5Bought;

                active1Bought = data.active1Bought;
                active2Bought = data.active2Bought;
                active3Bought = data.active3Bought;
                active4Bought = data.active4Bought;
                active5Bought = data.active5Bought;
                active6Bought = data.active6Bought;

                activeCursor1Bought = data.activeCursor1Bought;
                activeCursor2Bought = data.activeCursor2Bought;
                activeCursor3Bought = data.activeCursor3Bought;
                activeCursor4Bought = data.activeCursor4Bought;

                autoClicker1Bought = data.autoClicker1Bought;
                autoClicker2Bought = data.autoClicker2Bought;
                autoClicker3Bought = data.autoClicker3Bought;
                autoClicker4Bought = data.autoClicker4Bought;

                autoDamage1Bought = data.autoDamage1Bought;
                autoDamage2Bought = data.autoDamage2Bought;
                autoDamage3Bought = data.autoDamage3Bought;
                autoDamage4Bought = data.autoDamage4Bought;
                autoDamage5Bought = data.autoDamage5Bought;
                autoDamage6Bought = data.autoDamage6Bought;
                autoDamage7Bought = data.autoDamage7Bought;

                autoCursor1Bought = data.autoCursor1Bought;
                autoCursor2Bought = data.autoCursor2Bought;
                autoCursor3Bought = data.autoCursor3Bought;
                autoCursor4Bought = data.autoCursor4Bought;

                gold1Bought = data.gold1Bought;
                gold2Bought = data.gold2Bought;
                gold3Bought = data.gold3Bought;
                gold4Bought = data.gold4Bought;
                gold5Bought = data.gold5Bought;
                gold6Bought = data.gold6Bought;
                gold7Bought = data.gold7Bought;

                drops1Bought = data.drops1Bought;
                drops2Bought = data.drops2Bought;
                drops3Bought = data.drops3Bought;
                drops4Bought = data.drops4Bought;
                drops5Bought = data.drops5Bought;
                drops6Bought = data.drops6Bought;

                xp1Bought = data.xp1Bought;
                xp2Bought = data.xp2Bought;
                xp3Bought = data.xp3Bought;
                xp4Bought = data.xp4Bought;
                xp5Bought = data.xp5Bought;
                xp6Bought = data.xp6Bought;

                levelSpecial1Bought = data.levelSpecial1Bought;
                levelSpecial2Bought = data.levelSpecial2Bought;
                levelSpecial3Bought = data.levelSpecial3Bought;
                levelSpecial4Bought = data.levelSpecial4Bought;

                strongerSpecial1Bought = data.strongerSpecial1Bought;
                strongerSpecial2Bought = data.strongerSpecial2Bought;
                strongerSpecial3Bought = data.strongerSpecial3Bought;
                strongerSpecial4Bought = data.strongerSpecial4Bought;
                strongerSpecial5Bought = data.strongerSpecial5Bought;

                startWithItem1Bought = data.startWithItem1Bought;
                startWithItem2Bought = data.startWithItem2Bought;
                startWithItem3Bought = data.startWithItem3Bought;
                startWithItem4Bought = data.startWithItem4Bought;
            }
            else { }
        }
        else
        {
            //Do nothing
        }
        #endregion

        SomethingAllUpgradesDo();
        playSound = true;

        if (strongerSpecial1Bought == 1) { wholeNumberIncrement = 1; twoDecimalNumberIncrement = 0.01f; oneDecimalNumberIncrement = 0.1f; }
        if (strongerSpecial2Bought == 1) { wholeNumberIncrement = 2; twoDecimalNumberIncrement = 0.03f; oneDecimalNumberIncrement = 0.3f; }
        if (strongerSpecial5Bought == 1) { wholeNumberIncrement = 4; twoDecimalNumberIncrement = 0.05f; oneDecimalNumberIncrement = 0.5f; }

        isInSkillTree = false;

        crit1Price = 13; crit2Price = 70; crit3Price = 100; crit4Price = 175; crit5Price = 250;

        active1Price = 9; active2Price = 50; active3Price = 100; active4Price = 225; active5Price = 290; active6Price = 370; active7Price = 410;

        activeCursor1Price = 25; activeCursor2Price = 50; activeCursor3Price = 150; activeCursor4Price = 185;

        autoClicker1Price = 20; autoClicker2Price = 70; autoClicker3Price = 175; autoClicker4Price = 280;

        autoDamage1Price = 6; autoDamage2Price = 60; autoDamage3Price = 120; autoDamage4Price = 230; autoDamage5Price = 250; autoDamage6Price = 380; autoDamage7Price = 500; autoDamage8Price = 650;

        autoCursor1Price = 25; autoCursor2Price = 90; autoCursor3Price = 150; autoCursor4Price = 290; autoCursor5Price = 325;

        gold1Price = 12; gold2Price = 75; gold3Price = 200; gold4Price = 300; gold5Price = 430; gold6Price = 650; gold7Price = 700; gold8Price = 900;
        gold9Price = 1600;

        drops1Price = 7; drops2Price = 40; drops3Price = 80; drops4Price = 200; drops5Price = 210; drops6Price = 250; drops7Price = 390;

        xp1Price = 12; xp2Price = 100; xp3Price = 260; xp4Price = 400; xp5Price = 620; xp6Price = 700; xp7Price = 800; xp8Price = 1000;

        levelSpecial1Price = 30; levelSpecial2Price = 90; levelSpecial3Price = 245; levelSpecial4Price = 430; levelSpecial5Price = 500;

        strongerSpecial1Price = 9; strongerSpecial2Price = 25; strongerSpecial3Price = 200; strongerSpecial4Price = 200; strongerSpecial5Price = 375; strongerSpecial6Price = 500; strongerSpecial7Price = 700;

        startWithItem1Price = 5; startWithItem2Price = 20; startWithItem3Price = 50; startWithItem4Price = 100;

        //allUpgradesPrice = crit1Price + crit2Price + crit3Price + crit4Price + crit5Price + active1Price + active2Price + active3Price + active4Price + active5Price + active6Price + activeCursor1Price + activeCursor2Price + activeCursor3Price + activeCursor4Price + autoClicker1Price + autoClicker2Price + autoClicker3Price + autoClicker4Price + autoDamage1Price + autoDamage2Price + autoDamage3Price + autoDamage4Price + autoDamage5Price + autoDamage6Price + autoDamage7Price + autoCursor1Price + autoCursor2Price + autoCursor3Price + autoCursor4Price + gold1Price + gold2Price + gold3Price + gold4Price + gold5Price + gold6Price + gold7Price + drops1Price + drops2Price + drops3Price + drops4Price + drops5Price + drops6Price + xp1Price + xp2Price + xp3Price + xp4Price + xp5Price + xp6Price + levelSpecial1Price + levelSpecial2Price + levelSpecial3Price + levelSpecial4Price + strongerSpecial1Price + strongerSpecial2Price + strongerSpecial3Price + strongerSpecial4Price + strongerSpecial5Price + startWithItem1Price + startWithItem2Price + startWithItem3Price + startWithItem4Price;

        //Debug.Log(allUpgradesPrice);

        #region PRICES
        critTextPricesText[0].text = "" + crit1Price;
        critTextPricesText[1].text = "" + crit2Price;
        critTextPricesText[2].text = "" + crit3Price;
        critTextPricesText[3].text = "" + crit4Price;
        critTextPricesText[4].text = "" + crit5Price;

        activeDamagePricesText[0].text = "" + active1Price;
        activeDamagePricesText[1].text = "" + active2Price;
        activeDamagePricesText[2].text = "" + active3Price;
        activeDamagePricesText[3].text = "" + active4Price;
        activeDamagePricesText[4].text = "" + active5Price;
        activeDamagePricesText[5].text = "" + active6Price;
        activeDamagePricesText[6].text = "" + active7Price;

        activeCursorUpgradePricesText[0].text = "" + activeCursor1Price;
        activeCursorUpgradePricesText[1].text = "" + activeCursor2Price;
        activeCursorUpgradePricesText[2].text = "" + activeCursor3Price;
        activeCursorUpgradePricesText[3].text = "" + activeCursor4Price;

        autoClickerPricesText[0].text = "" + autoClicker1Price;
        autoClickerPricesText[1].text = "" + autoClicker2Price;
        autoClickerPricesText[2].text = "" + autoClicker3Price;
        autoClickerPricesText[3].text = "" + autoClicker4Price;

        autoDamagePricesText[0].text = "" + autoDamage1Price;
        autoDamagePricesText[1].text = "" + autoDamage2Price;
        autoDamagePricesText[2].text = "" + autoDamage3Price;
        autoDamagePricesText[3].text = "" + autoDamage4Price;
        autoDamagePricesText[4].text = "" + autoDamage5Price;
        autoDamagePricesText[5].text = "" + autoDamage6Price;
        autoDamagePricesText[6].text = "" + autoDamage7Price;
        autoDamagePricesText[7].text = "" + autoDamage8Price;

        passiveCursorPricesText[0].text = "" + autoCursor1Price;
        passiveCursorPricesText[1].text = "" + autoCursor2Price;
        passiveCursorPricesText[2].text = "" + autoCursor3Price;
        passiveCursorPricesText[3].text = "" + autoCursor4Price;
        passiveCursorPricesText[4].text = "" + autoCursor5Price;

        goldPricesText[0].text = "" + gold1Price;
        goldPricesText[1].text = "" + gold2Price;
        goldPricesText[2].text = "" + gold3Price;
        goldPricesText[3].text = "" + gold4Price;
        goldPricesText[4].text = "" + gold5Price;
        goldPricesText[5].text = "" + gold6Price;
        goldPricesText[6].text = "" + gold7Price;
        goldPricesText[7].text = "" + gold8Price;
        goldPricesText[8].text = "" + gold9Price;

        treasuresPriceText[0].text = "" + drops1Price;
        treasuresPriceText[1].text = "" + drops2Price;
        treasuresPriceText[2].text = "" + drops3Price;
        treasuresPriceText[3].text = "" + drops4Price;
        treasuresPriceText[4].text = "" + drops5Price;
        treasuresPriceText[5].text = "" + drops6Price;
        treasuresPriceText[6].text = "" + drops7Price;

        XPPricesText[0].text = "" + xp1Price;
        XPPricesText[1].text = "" + xp2Price;
        XPPricesText[2].text = "" + xp3Price;
        XPPricesText[3].text = "" + xp4Price;
        XPPricesText[4].text = "" + xp5Price;
        XPPricesText[5].text = "" + xp6Price;
        XPPricesText[6].text = "" + xp7Price;
        XPPricesText[7].text = "" + xp8Price;

        levelUpSpeciaPriceslText[0].text = "" + levelSpecial1Price;
        levelUpSpeciaPriceslText[1].text = "" + levelSpecial2Price;
        levelUpSpeciaPriceslText[2].text = "" + levelSpecial3Price;
        levelUpSpeciaPriceslText[3].text = "" + levelSpecial4Price;
        levelUpSpeciaPriceslText[4].text = "" + levelSpecial5Price;

        strongerSpecialPricesText[0].text = "" + strongerSpecial1Price;
        strongerSpecialPricesText[1].text = "" + strongerSpecial2Price;
        strongerSpecialPricesText[2].text = "" + strongerSpecial3Price;
        strongerSpecialPricesText[3].text = "" + strongerSpecial4Price;
        strongerSpecialPricesText[4].text = "" + strongerSpecial5Price;
        strongerSpecialPricesText[5].text = "" + strongerSpecial6Price;
        strongerSpecialPricesText[6].text = "" + strongerSpecial7Price;

        startWithPricesText[0].text = "" + startWithItem1Price;
        startWithPricesText[1].text = "" + startWithItem2Price;
        startWithPricesText[2].text = "" + startWithItem3Price;
        startWithPricesText[3].text = "" + startWithItem4Price;
        #endregion


        #region critAfford
        if (PlayerLevel.skillPoints >= crit1Price) { critTextPricesText[0].color = Color.green; }
        if (PlayerLevel.skillPoints < crit1Price) { critTextPricesText[0].color = Color.red; }

        if (PlayerLevel.skillPoints >= crit2Price) { critTextPricesText[1].color = Color.green; }
        if (PlayerLevel.skillPoints < crit2Price) { critTextPricesText[1].color = Color.red; }

        if (PlayerLevel.skillPoints >= crit3Price) { critTextPricesText[2].color = Color.green; }
        if (PlayerLevel.skillPoints < crit3Price) { critTextPricesText[2].color = Color.red; }

        if (PlayerLevel.skillPoints >= crit4Price) { critTextPricesText[3].color = Color.green; }
        if (PlayerLevel.skillPoints < crit4Price) { critTextPricesText[3].color = Color.red; }

        if (PlayerLevel.skillPoints >= crit5Price) { critTextPricesText[4].color = Color.green; }
        if (PlayerLevel.skillPoints < crit5Price) { critTextPricesText[4].color = Color.red; }

        #endregion

        #region acitveAfford
        if (PlayerLevel.skillPoints >= active1Price) { activeDamagePricesText[0].color = Color.green; }
        if (PlayerLevel.skillPoints < active1Price) { activeDamagePricesText[0].color = Color.red; }

        if (PlayerLevel.skillPoints >= active2Price) { activeDamagePricesText[1].color = Color.green; }
        if (PlayerLevel.skillPoints < active2Price) { activeDamagePricesText[1].color = Color.red; }

        if (PlayerLevel.skillPoints >= active3Price) { activeDamagePricesText[2].color = Color.green; }
        if (PlayerLevel.skillPoints < active3Price) { activeDamagePricesText[2].color = Color.red; }

        if (PlayerLevel.skillPoints >= active4Price) { activeDamagePricesText[3].color = Color.green; }
        if (PlayerLevel.skillPoints < active4Price) { activeDamagePricesText[3].color = Color.red; }

        if (PlayerLevel.skillPoints >= active5Price) { activeDamagePricesText[4].color = Color.green; }
        if (PlayerLevel.skillPoints < active5Price) { activeDamagePricesText[4].color = Color.red; }

        if (PlayerLevel.skillPoints >= active6Price) { activeDamagePricesText[5].color = Color.green; }
        if (PlayerLevel.skillPoints < active6Price) { activeDamagePricesText[5].color = Color.red; }

        if (PlayerLevel.skillPoints >= active7Price) { activeDamagePricesText[6].color = Color.green; }
        if (PlayerLevel.skillPoints < active7Price) { activeDamagePricesText[6].color = Color.red; }
        #endregion

        #region activeCursor
        if (PlayerLevel.skillPoints >= activeCursor1Price) { activeCursorUpgradePricesText[0].color = Color.green; }
        if (PlayerLevel.skillPoints < activeCursor1Price) { activeCursorUpgradePricesText[0].color = Color.red; }

        if (PlayerLevel.skillPoints >= activeCursor2Price) { activeCursorUpgradePricesText[1].color = Color.green; }
        if (PlayerLevel.skillPoints < activeCursor2Price) { activeCursorUpgradePricesText[1].color = Color.red; }

        if (PlayerLevel.skillPoints >= activeCursor3Price) { activeCursorUpgradePricesText[2].color = Color.green; }
        if (PlayerLevel.skillPoints < activeCursor3Price) { activeCursorUpgradePricesText[2].color = Color.red; }

        if (PlayerLevel.skillPoints >= activeCursor4Price) { activeCursorUpgradePricesText[3].color = Color.green; }
        if (PlayerLevel.skillPoints < activeCursor4Price) { activeCursorUpgradePricesText[3].color = Color.red; }
        #endregion


        #region autoClicker
        if (PlayerLevel.skillPoints >= autoClicker1Price) { autoClickerPricesText[0].color = Color.green; }
        if (PlayerLevel.skillPoints < autoClicker1Price) { autoClickerPricesText[0].color = Color.red; }

        if (PlayerLevel.skillPoints >= autoClicker2Price) { autoClickerPricesText[1].color = Color.green; }
        if (PlayerLevel.skillPoints < autoClicker2Price) { autoClickerPricesText[1].color = Color.red; }

        if (PlayerLevel.skillPoints >= autoClicker3Price) { autoClickerPricesText[2].color = Color.green; }
        if (PlayerLevel.skillPoints < autoClicker3Price) { autoClickerPricesText[2].color = Color.red; }

        if (PlayerLevel.skillPoints >= autoClicker4Price) { autoClickerPricesText[3].color = Color.green; }
        if (PlayerLevel.skillPoints < autoClicker4Price) { autoClickerPricesText[3].color = Color.red; }
        #endregion

        #region autoDamage
        if (PlayerLevel.skillPoints >= autoDamage1Price) { autoDamagePricesText[0].color = Color.green; }
        if (PlayerLevel.skillPoints < autoDamage1Price) { autoDamagePricesText[0].color = Color.red; }

        if (PlayerLevel.skillPoints >= autoDamage2Price) { autoDamagePricesText[1].color = Color.green; }
        if (PlayerLevel.skillPoints < autoDamage2Price) { autoDamagePricesText[1].color = Color.red; }

        if (PlayerLevel.skillPoints >= autoDamage3Price) { autoDamagePricesText[2].color = Color.green; }
        if (PlayerLevel.skillPoints < autoDamage3Price) { autoDamagePricesText[2].color = Color.red; }

        if (PlayerLevel.skillPoints >= autoDamage4Price) { autoDamagePricesText[3].color = Color.green; }
        if (PlayerLevel.skillPoints < autoDamage4Price) { autoDamagePricesText[3].color = Color.red; }

        if (PlayerLevel.skillPoints >= autoDamage5Price) { autoDamagePricesText[4].color = Color.green; }
        if (PlayerLevel.skillPoints < autoDamage5Price) { autoDamagePricesText[4].color = Color.red; }

        if (PlayerLevel.skillPoints >= autoDamage6Price) { autoDamagePricesText[5].color = Color.green; }
        if (PlayerLevel.skillPoints < autoDamage6Price) { autoDamagePricesText[5].color = Color.red; }

        if (PlayerLevel.skillPoints >= autoDamage7Price) { autoDamagePricesText[6].color = Color.green; }
        if (PlayerLevel.skillPoints < autoDamage7Price) { autoDamagePricesText[6].color = Color.red; }

        if (PlayerLevel.skillPoints >= autoDamage8Price) { autoDamagePricesText[7].color = Color.green; }
        if (PlayerLevel.skillPoints < autoDamage8Price) { autoDamagePricesText[7].color = Color.red; }
        #endregion

        #region passiveCursor
        if (PlayerLevel.skillPoints >= autoCursor1Price) { passiveCursorPricesText[0].color = Color.green; }
        if (PlayerLevel.skillPoints < autoCursor1Price) { passiveCursorPricesText[0].color = Color.red; }

        if (PlayerLevel.skillPoints >= autoCursor2Price) { passiveCursorPricesText[1].color = Color.green; }
        if (PlayerLevel.skillPoints < autoCursor2Price) { passiveCursorPricesText[1].color = Color.red; }

        if (PlayerLevel.skillPoints >= autoCursor3Price) { passiveCursorPricesText[2].color = Color.green; }
        if (PlayerLevel.skillPoints < autoCursor3Price) { passiveCursorPricesText[2].color = Color.red; }

        if (PlayerLevel.skillPoints >= autoCursor4Price) { passiveCursorPricesText[3].color = Color.green; }
        if (PlayerLevel.skillPoints < autoCursor4Price) { passiveCursorPricesText[3].color = Color.red; }

        if (PlayerLevel.skillPoints >= autoCursor5Price) { passiveCursorPricesText[4].color = Color.green; }
        if (PlayerLevel.skillPoints < autoCursor5Price) { passiveCursorPricesText[4].color = Color.red; }
        #endregion


        #region gold
        if (PlayerLevel.skillPoints >= gold1Price) { goldPricesText[0].color = Color.green; }
        if (PlayerLevel.skillPoints < gold1Price) { goldPricesText[0].color = Color.red; }

        if (PlayerLevel.skillPoints >= gold2Price) { goldPricesText[1].color = Color.green; }
        if (PlayerLevel.skillPoints < gold2Price) { goldPricesText[1].color = Color.red; }

        if (PlayerLevel.skillPoints >= gold3Price) { goldPricesText[2].color = Color.green; }
        if (PlayerLevel.skillPoints < gold3Price) { goldPricesText[2].color = Color.red; }

        if (PlayerLevel.skillPoints >= gold4Price) { goldPricesText[3].color = Color.green; }
        if (PlayerLevel.skillPoints < gold4Price) { goldPricesText[3].color = Color.red; }

        if (PlayerLevel.skillPoints >= gold5Price) { goldPricesText[4].color = Color.green; }
        if (PlayerLevel.skillPoints < gold5Price) { goldPricesText[4].color = Color.red; }

        if (PlayerLevel.skillPoints >= gold6Price) { goldPricesText[5].color = Color.green; }
        if (PlayerLevel.skillPoints < gold6Price) { goldPricesText[5].color = Color.red; }

        if (PlayerLevel.skillPoints >= gold7Price) { goldPricesText[6].color = Color.green; }
        if (PlayerLevel.skillPoints < gold7Price) { goldPricesText[6].color = Color.red; }

        if (PlayerLevel.skillPoints >= gold8Price) { goldPricesText[7].color = Color.green; }
        if (PlayerLevel.skillPoints < gold8Price) { goldPricesText[7].color = Color.red; }

        if (PlayerLevel.skillPoints >= gold9Price) { goldPricesText[8].color = Color.green; }
        if (PlayerLevel.skillPoints < gold9Price) { goldPricesText[8].color = Color.red; }
        #endregion

        #region treasure

        if (PlayerLevel.skillPoints >= drops1Price) { treasuresPriceText[0].color = Color.green; }
        if (PlayerLevel.skillPoints < drops1Price) { treasuresPriceText[0].color = Color.red; }

        if (PlayerLevel.skillPoints >= drops2Price) { treasuresPriceText[1].color = Color.green; }
        if (PlayerLevel.skillPoints < drops2Price) { treasuresPriceText[1].color = Color.red; }

        if (PlayerLevel.skillPoints >= drops3Price) { treasuresPriceText[2].color = Color.green; }
        if (PlayerLevel.skillPoints < drops3Price) { treasuresPriceText[2].color = Color.red; }

        if (PlayerLevel.skillPoints >= drops4Price) { treasuresPriceText[3].color = Color.green; }
        if (PlayerLevel.skillPoints < drops4Price) { treasuresPriceText[3].color = Color.red; }

        if (PlayerLevel.skillPoints >= drops5Price) { treasuresPriceText[4].color = Color.green; }
        if (PlayerLevel.skillPoints < drops5Price) { treasuresPriceText[4].color = Color.red; }

        if (PlayerLevel.skillPoints >= drops6Price) { treasuresPriceText[5].color = Color.green; }
        if (PlayerLevel.skillPoints < drops6Price) { treasuresPriceText[5].color = Color.red; }

        if (PlayerLevel.skillPoints >= drops7Price) { treasuresPriceText[6].color = Color.green; }
        if (PlayerLevel.skillPoints < drops7Price) { treasuresPriceText[6].color = Color.red; }
        #endregion

        #region xp
        if (PlayerLevel.skillPoints >= xp1Price) { XPPricesText[0].color = Color.green; }
        if (PlayerLevel.skillPoints < xp1Price) { XPPricesText[0].color = Color.red; }

        if (PlayerLevel.skillPoints >= xp2Price) { XPPricesText[1].color = Color.green; }
        if (PlayerLevel.skillPoints < xp2Price) { XPPricesText[1].color = Color.red; }

        if (PlayerLevel.skillPoints >= xp3Price) { XPPricesText[2].color = Color.green; }
        if (PlayerLevel.skillPoints < xp3Price) { XPPricesText[2].color = Color.red; }

        if (PlayerLevel.skillPoints >= xp4Price) { XPPricesText[3].color = Color.green; }
        if (PlayerLevel.skillPoints < xp4Price) { XPPricesText[3].color = Color.red; }

        if (PlayerLevel.skillPoints >= xp5Price) { XPPricesText[4].color = Color.green; }
        if (PlayerLevel.skillPoints < xp5Price) { XPPricesText[4].color = Color.red; }

        if (PlayerLevel.skillPoints >= xp6Price) { XPPricesText[5].color = Color.green; }
        if (PlayerLevel.skillPoints < xp6Price) { XPPricesText[5].color = Color.red; }

        if (PlayerLevel.skillPoints >= xp7Price) { XPPricesText[6].color = Color.green; }
        if (PlayerLevel.skillPoints < xp7Price) { XPPricesText[6].color = Color.red; }

        if (PlayerLevel.skillPoints >= xp8Price) { XPPricesText[7].color = Color.green; }
        if (PlayerLevel.skillPoints < xp8Price) { XPPricesText[7].color = Color.red; }
        #endregion


        #region levelUpSpecial
        if (PlayerLevel.skillPoints >= levelSpecial1Price) { levelUpSpeciaPriceslText[0].color = Color.green; }
        if (PlayerLevel.skillPoints < levelSpecial1Price) { levelUpSpeciaPriceslText[0].color = Color.red; }

        if (PlayerLevel.skillPoints >= levelSpecial2Price) { levelUpSpeciaPriceslText[1].color = Color.green; }
        if (PlayerLevel.skillPoints < levelSpecial2Price) { levelUpSpeciaPriceslText[1].color = Color.red; }

        if (PlayerLevel.skillPoints >= levelSpecial3Price) { levelUpSpeciaPriceslText[2].color = Color.green; }
        if (PlayerLevel.skillPoints < levelSpecial3Price) { levelUpSpeciaPriceslText[2].color = Color.red; }

        if (PlayerLevel.skillPoints >= levelSpecial4Price) { levelUpSpeciaPriceslText[3].color = Color.green; }
        if (PlayerLevel.skillPoints < levelSpecial4Price) { levelUpSpeciaPriceslText[3].color = Color.red; }

        if (PlayerLevel.skillPoints >= levelSpecial5Price) { levelUpSpeciaPriceslText[4].color = Color.green; }
        if (PlayerLevel.skillPoints < levelSpecial5Price) { levelUpSpeciaPriceslText[4].color = Color.red; }
        #endregion

        #region strongerSpecial
        if (PlayerLevel.skillPoints >= strongerSpecial1Price) { strongerSpecialPricesText[0].color = Color.green; }
        if (PlayerLevel.skillPoints < strongerSpecial1Price) { strongerSpecialPricesText[0].color = Color.red; }

        if (PlayerLevel.skillPoints >= strongerSpecial2Price) { strongerSpecialPricesText[1].color = Color.green; }
        if (PlayerLevel.skillPoints < strongerSpecial2Price) { strongerSpecialPricesText[1].color = Color.red; }

        if (PlayerLevel.skillPoints >= strongerSpecial3Price) { strongerSpecialPricesText[2].color = Color.green; }
        if (PlayerLevel.skillPoints < strongerSpecial3Price) { strongerSpecialPricesText[2].color = Color.red; }

        if (PlayerLevel.skillPoints >= strongerSpecial4Price) { strongerSpecialPricesText[3].color = Color.green; }
        if (PlayerLevel.skillPoints < strongerSpecial4Price) { strongerSpecialPricesText[3].color = Color.red; }

        if (PlayerLevel.skillPoints >= strongerSpecial5Price) { strongerSpecialPricesText[4].color = Color.green; }
        if (PlayerLevel.skillPoints < strongerSpecial5Price) { strongerSpecialPricesText[4].color = Color.red; }

        if (PlayerLevel.skillPoints >= strongerSpecial6Price) { strongerSpecialPricesText[5].color = Color.green; }
        if (PlayerLevel.skillPoints < strongerSpecial6Price) { strongerSpecialPricesText[5].color = Color.red; }

        if (PlayerLevel.skillPoints >= strongerSpecial7Price) { strongerSpecialPricesText[6].color = Color.green; }
        if (PlayerLevel.skillPoints < strongerSpecial7Price) { strongerSpecialPricesText[6].color = Color.red; }
        #endregion

        #region startWith
        if (PlayerLevel.skillPoints >= startWithItem1Price) { startWithPricesText[0].color = Color.green; }
        if (PlayerLevel.skillPoints < startWithItem1Price) { startWithPricesText[0].color = Color.red; }

        if (PlayerLevel.skillPoints >= startWithItem2Price) { startWithPricesText[1].color = Color.green; }
        if (PlayerLevel.skillPoints < startWithItem2Price) { startWithPricesText[1].color = Color.red; }

        if (PlayerLevel.skillPoints >= startWithItem3Price) { startWithPricesText[2].color = Color.green; }
        if (PlayerLevel.skillPoints < startWithItem3Price) { startWithPricesText[2].color = Color.red; }

        if (PlayerLevel.skillPoints >= startWithItem4Price) { startWithPricesText[3].color = Color.green; }
        if (PlayerLevel.skillPoints < startWithItem4Price) { startWithPricesText[3].color = Color.red; }
        #endregion


        #region unlockedSetActive
        if (crit1Bought == 1) { critUnlocked[0].SetActive(true); critLocks[0].SetActive(false); critIcons[1].SetActive(true); }
        if (crit2Bought == 1) { critUnlocked[1].SetActive(true); critLocks[1].SetActive(false); critIcons[2].SetActive(true); }
        if (crit3Bought == 1) { critUnlocked[2].SetActive(true); critLocks[2].SetActive(false); critIcons[3].SetActive(true); }
        if (crit4Bought == 1) { critUnlocked[3].SetActive(true); critLocks[3].SetActive(false); critIcons[4].SetActive(true); }
        if (crit5Bought == 1) { critUnlocked[4].SetActive(true); }

        if (active1Bought == 1) { activeUnlocked[0].SetActive(true); activeDamageLocks[0].SetActive(false); activeDamageIcons[0].SetActive(true); }
        if (active2Bought == 1) { activeUnlocked[1].SetActive(true); activeDamageLocks[1].SetActive(false); activeDamageIcons[1].SetActive(true); }
        if (active3Bought == 1) { activeUnlocked[2].SetActive(true); activeDamageLocks[2].SetActive(false); activeDamageIcons[2].SetActive(true); }
        if (active4Bought == 1) { activeUnlocked[3].SetActive(true); activeDamageLocks[3].SetActive(false); activeDamageIcons[3].SetActive(true); }
        if (active5Bought == 1) { activeUnlocked[4].SetActive(true); activeDamageLocks[4].SetActive(false); activeDamageIcons[4].SetActive(true); }
        if (active6Bought == 1) { activeUnlocked[5].SetActive(true); activeDamageLocks[5].SetActive(false); activeDamageIcons[5].SetActive(true); }
        if (active7Bought == 1) { activeUnlocked[6].SetActive(true); }

        if (activeCursor1Bought == 1) { activeCursorUnlocked[0].SetActive(true); activeCursorLocks[0].SetActive(false); activeCursorIcons[0].SetActive(true); }
        if (activeCursor2Bought == 1) { activeCursorUnlocked[1].SetActive(true); activeCursorLocks[1].SetActive(false); activeCursorIcons[1].SetActive(true); }
        if (activeCursor3Bought == 1) { activeCursorUnlocked[2].SetActive(true); activeCursorLocks[2].SetActive(false); activeCursorIcons[2].SetActive(true); }
        if (activeCursor4Bought == 1) { activeCursorUnlocked[3].SetActive(true); }

        if (autoClicker1Bought == 1) { autoClickerUnlocked[0].SetActive(true); autoClickerLocks[0].SetActive(false); autoClickerIcons[0].SetActive(true); }
        if (autoClicker2Bought == 1) { autoClickerUnlocked[1].SetActive(true); autoClickerLocks[1].SetActive(false); autoClickerIcons[1].SetActive(true); }
        if (autoClicker3Bought == 1) { autoClickerUnlocked[2].SetActive(true); autoClickerLocks[2].SetActive(false); autoClickerIcons[2].SetActive(true); }
        if (autoClicker4Bought == 1) { autoClickerUnlocked[3].SetActive(true); }

        if (autoDamage1Bought == 1) { passiveUnlocked[0].SetActive(true); autoDamageLocks[0].SetActive(false); autoDamageIcons[0].SetActive(true); }
        if (autoDamage2Bought == 1) { passiveUnlocked[1].SetActive(true); autoDamageLocks[1].SetActive(false); autoDamageIcons[1].SetActive(true); }
        if (autoDamage3Bought == 1) { passiveUnlocked[2].SetActive(true); autoDamageLocks[2].SetActive(false); autoDamageIcons[2].SetActive(true); }
        if (autoDamage4Bought == 1) { passiveUnlocked[3].SetActive(true); autoDamageLocks[3].SetActive(false); autoDamageIcons[3].SetActive(true); }
        if (autoDamage5Bought == 1) { passiveUnlocked[4].SetActive(true); autoDamageLocks[4].SetActive(false); autoDamageIcons[4].SetActive(true); }
        if (autoDamage6Bought == 1) { passiveUnlocked[5].SetActive(true); autoDamageLocks[5].SetActive(false); autoDamageIcons[5].SetActive(true); }
        if (autoDamage7Bought == 1) { passiveUnlocked[6].SetActive(true); autoDamageLocks[6].SetActive(false); autoDamageIcons[6].SetActive(true); }
        if (autoDamage8Bought == 1) { passiveUnlocked[7].SetActive(true);  }

        if (autoCursor1Bought == 1) { passiveCursorUnlocked[0].SetActive(true); autoCursorLocks[0].SetActive(false); autoCursorsIcons[0].SetActive(true); }
        if (autoCursor2Bought == 1) { passiveCursorUnlocked[1].SetActive(true); autoCursorLocks[1].SetActive(false); autoCursorsIcons[1].SetActive(true); }
        if (autoCursor3Bought == 1) { passiveCursorUnlocked[2].SetActive(true); autoCursorLocks[2].SetActive(false); autoCursorsIcons[2].SetActive(true); }
        if (autoCursor4Bought == 1) { passiveCursorUnlocked[3].SetActive(true); autoCursorLocks[3].SetActive(false); autoCursorsIcons[3].SetActive(true); }
        if (autoCursor5Bought == 1) { passiveCursorUnlocked[4].SetActive(true);}

        if (gold1Bought == 1) { goldUnlocked[0].SetActive(true); goldLockes[0].SetActive(false); goldIcons[0].SetActive(true); }
        if (gold2Bought == 1) { goldUnlocked[1].SetActive(true); goldLockes[1].SetActive(false); goldIcons[1].SetActive(true); }
        if (gold3Bought == 1) { goldUnlocked[2].SetActive(true); goldLockes[2].SetActive(false); goldIcons[2].SetActive(true); }
        if (gold4Bought == 1) { goldUnlocked[3].SetActive(true); goldLockes[3].SetActive(false); goldIcons[3].SetActive(true); }
        if (gold5Bought == 1) { goldUnlocked[4].SetActive(true); goldLockes[4].SetActive(false); goldIcons[4].SetActive(true); }
        if (gold6Bought == 1) { goldUnlocked[5].SetActive(true); goldLockes[5].SetActive(false); goldIcons[5].SetActive(true); }
        if (gold7Bought == 1) { goldUnlocked[6].SetActive(true); goldLockes[6].SetActive(false); goldIcons[6].SetActive(true); }
        if (gold8Bought == 1) { goldUnlocked[7].SetActive(true); goldLockes[7].SetActive(false); goldIcons[7].SetActive(true); }
        if (gold9Bought == 1) { goldUnlocked[8].SetActive(true); }

        if (drops1Bought == 1) { treasureUnlocked[0].SetActive(true); dropsLockes[0].SetActive(false); dropsIcons[0].SetActive(true); }
        if (drops2Bought == 1) { treasureUnlocked[1].SetActive(true); dropsLockes[1].SetActive(false); dropsIcons[1].SetActive(true); }
        if (drops3Bought == 1) { treasureUnlocked[2].SetActive(true); dropsLockes[2].SetActive(false); dropsIcons[2].SetActive(true); }
        if (drops4Bought == 1) { treasureUnlocked[3].SetActive(true); dropsLockes[3].SetActive(false); dropsIcons[3].SetActive(true); }
        if (drops5Bought == 1) { treasureUnlocked[4].SetActive(true); dropsLockes[4].SetActive(false); dropsIcons[4].SetActive(true); }
        if (drops6Bought == 1) { treasureUnlocked[5].SetActive(true); dropsLockes[5].SetActive(false); dropsIcons[5].SetActive(true); }
        if (drops7Bought == 1) { treasureUnlocked[6].SetActive(true); soldTreasureBuff = 5; }
        if(drops7Bought != 1) { soldTreasureBuff = 1; }

        if (xp1Bought == 1) { XPUnlocked[0].SetActive(true); xpLockes[0].SetActive(false); xpIcons[0].SetActive(true); }
        if (xp2Bought == 1) { XPUnlocked[1].SetActive(true); xpLockes[1].SetActive(false); xpIcons[1].SetActive(true); }
        if (xp3Bought == 1) { XPUnlocked[2].SetActive(true); xpLockes[2].SetActive(false); xpIcons[2].SetActive(true); }
        if (xp4Bought == 1) { XPUnlocked[3].SetActive(true); xpLockes[3].SetActive(false); xpIcons[3].SetActive(true); }
        if (xp5Bought == 1) { XPUnlocked[4].SetActive(true); xpLockes[4].SetActive(false); xpIcons[4].SetActive(true); }
        if (xp6Bought == 1) { XPUnlocked[5].SetActive(true); xpLockes[5].SetActive(false); xpIcons[5].SetActive(true); }
        if (xp7Bought == 1) { XPUnlocked[6].SetActive(true); xpLockes[6].SetActive(false); xpIcons[6].SetActive(true); }
        if (xp8Bought == 1) { XPUnlocked[7].SetActive(true); }

        if (levelSpecial1Bought == 1) { levelUpSpecialUnlocked[0].SetActive(true); levelSpecialLockes[0].SetActive(false); levelSpecialIcons[0].SetActive(true); }
        if (levelSpecial2Bought == 1) { levelUpSpecialUnlocked[1].SetActive(true); levelSpecialLockes[1].SetActive(false); levelSpecialIcons[1].SetActive(true); }
        if (levelSpecial3Bought == 1) { levelUpSpecialUnlocked[2].SetActive(true); levelSpecialLockes[2].SetActive(false); levelSpecialIcons[2].SetActive(true); }
        if (levelSpecial4Bought == 1) { levelUpSpecialUnlocked[3].SetActive(true); levelSpecialLockes[3].SetActive(false); levelSpecialIcons[3].SetActive(true); }
        if (levelSpecial5Bought == 1) { levelUpSpecialUnlocked[4].SetActive(true);  }

        if (strongerSpecial1Bought == 1) { strongerSpecialUnlocked[0].SetActive(true); strongerSpecialLockes[0].SetActive(false); strongerSpecialIcons[0].SetActive(true); }

        if (strongerSpecial2Bought == 1) { strongerSpecialUnlocked[1].SetActive(true); strongerSpecialLockes[1].SetActive(false); strongerSpecialIcons[1].SetActive(true); }

        if (strongerSpecial3Bought == 1)
        {
            strongerSpecialUnlocked[2].SetActive(true); strongerSpecialLockes[2].SetActive(false); strongerSpecialIcons[2].SetActive(true);
            skillTreeLootPotionStack = 1; skillTreeDamagePotionStack = 1; skillTreeXPPotionStack = 1; skillTreeElixirStack = 1;
        }

        if (strongerSpecial4Bought == 1) { strongerSpecialUnlocked[3].SetActive(true); strongerSpecialLockes[3].SetActive(false); strongerSpecialIcons[3].SetActive(true); }

        if (strongerSpecial5Bought == 1)
        {
            strongerSpecialUnlocked[4].SetActive(true); strongerSpecialLockes[4].SetActive(false); strongerSpecialIcons[4].SetActive(true);
            skillTreeLootPotionStack = 2; skillTreeDamagePotionStack = 2; skillTreeXPPotionStack = 2; skillTreeElixirStack = 2;
        }
        if (strongerSpecial6Bought == 1)
        {
            strongerSpecialUnlocked[5].SetActive(true); strongerSpecialLockes[5].SetActive(false); strongerSpecialIcons[5].SetActive(true);
        }
        if (strongerSpecial7Bought == 1)
        {
            strongerSpecialUnlocked[6].SetActive(true); 
        }

        if (startWithItem1Bought == 1) { startWitchUnlcoked[0].SetActive(true); startWithItemLockes[0].SetActive(false); startWithItemIcons[0].SetActive(true); startWithItemCount = 1; }
        if (startWithItem2Bought == 1) { startWitchUnlcoked[1].SetActive(true); startWithItemLockes[1].SetActive(false); startWithItemIcons[1].SetActive(true); startWithItemCount = 2; }
        if (startWithItem3Bought == 1) { startWitchUnlcoked[2].SetActive(true); startWithItemLockes[2].SetActive(false); startWithItemIcons[2].SetActive(true); startWithItemCount = 3; }
        if (startWithItem4Bought == 1) { startWitchUnlcoked[3].SetActive(true); startWithItemCount = 5; }


        UseConsumable.potionStack = true;
        #endregion

        if(Stats.prestigeUpgradesPurchased >= 89)
        {
            RareTreasureButton.interactable = true;
            treasureHoverUnlocked.SetActive(true);
            treasureHoverNotUnlocked.SetActive(false);
            treasureButtonLockIcon.SetActive(false);
            treasureButtonPriceText.SetActive(true);

            if(RareTreasures.allTreasuresFound == true)
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

    }

    public Button RareTreasureButton;
    public GameObject treasureHoverUnlocked, treasureHoverNotUnlocked, treasureButtonLockIcon, treasureButtonPriceText, hudredPercentText, allTreasuresHover;


    public void CheckPriceTextColor()
    {
        #region checkAllColorPrices

        #region critAfford
        if (PlayerLevel.skillPoints >= crit1Price) { critTextPricesText[0].color = Color.green; }
        if (PlayerLevel.skillPoints < crit1Price) { critTextPricesText[0].color = Color.red; }

        if (PlayerLevel.skillPoints >= crit2Price) { critTextPricesText[1].color = Color.green; }
        if (PlayerLevel.skillPoints < crit2Price) { critTextPricesText[1].color = Color.red; }

        if (PlayerLevel.skillPoints >= crit3Price) { critTextPricesText[2].color = Color.green; }
        if (PlayerLevel.skillPoints < crit3Price) { critTextPricesText[2].color = Color.red; }

        if (PlayerLevel.skillPoints >= crit4Price) { critTextPricesText[3].color = Color.green; }
        if (PlayerLevel.skillPoints < crit4Price) { critTextPricesText[3].color = Color.red; }

        if (PlayerLevel.skillPoints >= crit5Price) { critTextPricesText[4].color = Color.green; }
        if (PlayerLevel.skillPoints < crit5Price) { critTextPricesText[4].color = Color.red; }

        #endregion

        #region acitveAfford
        if (PlayerLevel.skillPoints >= active1Price) { activeDamagePricesText[0].color = Color.green; }
        if (PlayerLevel.skillPoints < active1Price) { activeDamagePricesText[0].color = Color.red; }

        if (PlayerLevel.skillPoints >= active2Price) { activeDamagePricesText[1].color = Color.green; }
        if (PlayerLevel.skillPoints < active2Price) { activeDamagePricesText[1].color = Color.red; }

        if (PlayerLevel.skillPoints >= active3Price) { activeDamagePricesText[2].color = Color.green; }
        if (PlayerLevel.skillPoints < active3Price) { activeDamagePricesText[2].color = Color.red; }

        if (PlayerLevel.skillPoints >= active4Price) { activeDamagePricesText[3].color = Color.green; }
        if (PlayerLevel.skillPoints < active4Price) { activeDamagePricesText[3].color = Color.red; }

        if (PlayerLevel.skillPoints >= active5Price) { activeDamagePricesText[4].color = Color.green; }
        if (PlayerLevel.skillPoints < active5Price) { activeDamagePricesText[4].color = Color.red; }

        if (PlayerLevel.skillPoints >= active6Price) { activeDamagePricesText[5].color = Color.green; }
        if (PlayerLevel.skillPoints < active6Price) { activeDamagePricesText[5].color = Color.red; }

        if (PlayerLevel.skillPoints >= active7Price) { activeDamagePricesText[6].color = Color.green; }
        if (PlayerLevel.skillPoints < active7Price) { activeDamagePricesText[6].color = Color.red; }
        #endregion

        #region activeCursor
        if (PlayerLevel.skillPoints >= activeCursor1Price) { activeCursorUpgradePricesText[0].color = Color.green; }
        if (PlayerLevel.skillPoints < activeCursor1Price) { activeCursorUpgradePricesText[0].color = Color.red; }

        if (PlayerLevel.skillPoints >= activeCursor2Price) { activeCursorUpgradePricesText[1].color = Color.green; }
        if (PlayerLevel.skillPoints < activeCursor2Price) { activeCursorUpgradePricesText[1].color = Color.red; }

        if (PlayerLevel.skillPoints >= activeCursor3Price) { activeCursorUpgradePricesText[2].color = Color.green; }
        if (PlayerLevel.skillPoints < activeCursor3Price) { activeCursorUpgradePricesText[2].color = Color.red; }

        if (PlayerLevel.skillPoints >= activeCursor4Price) { activeCursorUpgradePricesText[3].color = Color.green; }
        if (PlayerLevel.skillPoints < activeCursor4Price) { activeCursorUpgradePricesText[3].color = Color.red; }
        #endregion


        #region autoClicker
        if (PlayerLevel.skillPoints >= autoClicker1Price) { autoClickerPricesText[0].color = Color.green; }
        if (PlayerLevel.skillPoints < autoClicker1Price) { autoClickerPricesText[0].color = Color.red; }

        if (PlayerLevel.skillPoints >= autoClicker2Price) { autoClickerPricesText[1].color = Color.green; }
        if (PlayerLevel.skillPoints < autoClicker2Price) { autoClickerPricesText[1].color = Color.red; }

        if (PlayerLevel.skillPoints >= autoClicker3Price) { autoClickerPricesText[2].color = Color.green; }
        if (PlayerLevel.skillPoints < autoClicker3Price) { autoClickerPricesText[2].color = Color.red; }

        if (PlayerLevel.skillPoints >= autoClicker4Price) { autoClickerPricesText[3].color = Color.green; }
        if (PlayerLevel.skillPoints < autoClicker4Price) { autoClickerPricesText[3].color = Color.red; }
        #endregion

        #region autoDamage
        if (PlayerLevel.skillPoints >= autoDamage1Price) { autoDamagePricesText[0].color = Color.green; }
        if (PlayerLevel.skillPoints < autoDamage1Price) { autoDamagePricesText[0].color = Color.red; }

        if (PlayerLevel.skillPoints >= autoDamage2Price) { autoDamagePricesText[1].color = Color.green; }
        if (PlayerLevel.skillPoints < autoDamage2Price) { autoDamagePricesText[1].color = Color.red; }

        if (PlayerLevel.skillPoints >= autoDamage3Price) { autoDamagePricesText[2].color = Color.green; }
        if (PlayerLevel.skillPoints < autoDamage3Price) { autoDamagePricesText[2].color = Color.red; }

        if (PlayerLevel.skillPoints >= autoDamage4Price) { autoDamagePricesText[3].color = Color.green; }
        if (PlayerLevel.skillPoints < autoDamage4Price) { autoDamagePricesText[3].color = Color.red; }

        if (PlayerLevel.skillPoints >= autoDamage5Price) { autoDamagePricesText[4].color = Color.green; }
        if (PlayerLevel.skillPoints < autoDamage5Price) { autoDamagePricesText[4].color = Color.red; }

        if (PlayerLevel.skillPoints >= autoDamage6Price) { autoDamagePricesText[5].color = Color.green; }
        if (PlayerLevel.skillPoints < autoDamage6Price) { autoDamagePricesText[5].color = Color.red; }

        if (PlayerLevel.skillPoints >= autoDamage7Price) { autoDamagePricesText[6].color = Color.green; }
        if (PlayerLevel.skillPoints < autoDamage7Price) { autoDamagePricesText[6].color = Color.red; }

        if (PlayerLevel.skillPoints >= autoDamage8Price) { autoDamagePricesText[7].color = Color.green; }
        if (PlayerLevel.skillPoints < autoDamage8Price) { autoDamagePricesText[7].color = Color.red; }
        #endregion

        #region passiveCursor
        if (PlayerLevel.skillPoints >= autoCursor1Price) { passiveCursorPricesText[0].color = Color.green; }
        if (PlayerLevel.skillPoints < autoCursor1Price) { passiveCursorPricesText[0].color = Color.red; }

        if (PlayerLevel.skillPoints >= autoCursor2Price) { passiveCursorPricesText[1].color = Color.green; }
        if (PlayerLevel.skillPoints < autoCursor2Price) { passiveCursorPricesText[1].color = Color.red; }

        if (PlayerLevel.skillPoints >= autoCursor3Price) { passiveCursorPricesText[2].color = Color.green; }
        if (PlayerLevel.skillPoints < autoCursor3Price) { passiveCursorPricesText[2].color = Color.red; }

        if (PlayerLevel.skillPoints >= autoCursor4Price) { passiveCursorPricesText[3].color = Color.green; }
        if (PlayerLevel.skillPoints < autoCursor4Price) { passiveCursorPricesText[3].color = Color.red; }

        if (PlayerLevel.skillPoints >= autoCursor5Price) { passiveCursorPricesText[4].color = Color.green; }
        if (PlayerLevel.skillPoints < autoCursor5Price) { passiveCursorPricesText[4].color = Color.red; }
        #endregion


        #region gold
        if (PlayerLevel.skillPoints >= gold1Price) { goldPricesText[0].color = Color.green; }
        if (PlayerLevel.skillPoints < gold1Price) { goldPricesText[0].color = Color.red; }

        if (PlayerLevel.skillPoints >= gold2Price) { goldPricesText[1].color = Color.green; }
        if (PlayerLevel.skillPoints < gold2Price) { goldPricesText[1].color = Color.red; }

        if (PlayerLevel.skillPoints >= gold3Price) { goldPricesText[2].color = Color.green; }
        if (PlayerLevel.skillPoints < gold3Price) { goldPricesText[2].color = Color.red; }

        if (PlayerLevel.skillPoints >= gold4Price) { goldPricesText[3].color = Color.green; }
        if (PlayerLevel.skillPoints < gold4Price) { goldPricesText[3].color = Color.red; }

        if (PlayerLevel.skillPoints >= gold5Price) { goldPricesText[4].color = Color.green; }
        if (PlayerLevel.skillPoints < gold5Price) { goldPricesText[4].color = Color.red; }

        if (PlayerLevel.skillPoints >= gold6Price) { goldPricesText[5].color = Color.green; }
        if (PlayerLevel.skillPoints < gold6Price) { goldPricesText[5].color = Color.red; }

        if (PlayerLevel.skillPoints >= gold7Price) { goldPricesText[6].color = Color.green; }
        if (PlayerLevel.skillPoints < gold7Price) { goldPricesText[6].color = Color.red; }

        if (PlayerLevel.skillPoints >= gold8Price) { goldPricesText[7].color = Color.green; }
        if (PlayerLevel.skillPoints < gold8Price) { goldPricesText[7].color = Color.red; }

        if (PlayerLevel.skillPoints >= gold9Price) { goldPricesText[8].color = Color.green; }
        if (PlayerLevel.skillPoints < gold9Price) { goldPricesText[8].color = Color.red; }
        #endregion

        #region treasure

        if (PlayerLevel.skillPoints >= drops1Price) { treasuresPriceText[0].color = Color.green; }
        if (PlayerLevel.skillPoints < drops1Price) { treasuresPriceText[0].color = Color.red; }

        if (PlayerLevel.skillPoints >= drops2Price) { treasuresPriceText[1].color = Color.green; }
        if (PlayerLevel.skillPoints < drops2Price) { treasuresPriceText[1].color = Color.red; }

        if (PlayerLevel.skillPoints >= drops3Price) { treasuresPriceText[2].color = Color.green; }
        if (PlayerLevel.skillPoints < drops3Price) { treasuresPriceText[2].color = Color.red; }

        if (PlayerLevel.skillPoints >= drops4Price) { treasuresPriceText[3].color = Color.green; }
        if (PlayerLevel.skillPoints < drops4Price) { treasuresPriceText[3].color = Color.red; }

        if (PlayerLevel.skillPoints >= drops5Price) { treasuresPriceText[4].color = Color.green; }
        if (PlayerLevel.skillPoints < drops5Price) { treasuresPriceText[4].color = Color.red; }

        if (PlayerLevel.skillPoints >= drops6Price) { treasuresPriceText[5].color = Color.green; }
        if (PlayerLevel.skillPoints < drops6Price) { treasuresPriceText[5].color = Color.red; }

        if (PlayerLevel.skillPoints >= drops7Price) { treasuresPriceText[6].color = Color.green; }
        if (PlayerLevel.skillPoints < drops7Price) { treasuresPriceText[6].color = Color.red; }
        #endregion

        #region xp
        if (PlayerLevel.skillPoints >= xp1Price) { XPPricesText[0].color = Color.green; }
        if (PlayerLevel.skillPoints < xp1Price) { XPPricesText[0].color = Color.red; }

        if (PlayerLevel.skillPoints >= xp2Price) { XPPricesText[1].color = Color.green; }
        if (PlayerLevel.skillPoints < xp2Price) { XPPricesText[1].color = Color.red; }

        if (PlayerLevel.skillPoints >= xp3Price) { XPPricesText[2].color = Color.green; }
        if (PlayerLevel.skillPoints < xp3Price) { XPPricesText[2].color = Color.red; }

        if (PlayerLevel.skillPoints >= xp4Price) { XPPricesText[3].color = Color.green; }
        if (PlayerLevel.skillPoints < xp4Price) { XPPricesText[3].color = Color.red; }

        if (PlayerLevel.skillPoints >= xp5Price) { XPPricesText[4].color = Color.green; }
        if (PlayerLevel.skillPoints < xp5Price) { XPPricesText[4].color = Color.red; }

        if (PlayerLevel.skillPoints >= xp6Price) { XPPricesText[5].color = Color.green; }
        if (PlayerLevel.skillPoints < xp6Price) { XPPricesText[5].color = Color.red; }

        if (PlayerLevel.skillPoints >= xp7Price) { XPPricesText[6].color = Color.green; }
        if (PlayerLevel.skillPoints < xp7Price) { XPPricesText[6].color = Color.red; }

        if (PlayerLevel.skillPoints >= xp8Price) { XPPricesText[7].color = Color.green; }
        if (PlayerLevel.skillPoints < xp8Price) { XPPricesText[7].color = Color.red; }
        #endregion


        #region levelUpSpecial
        if (PlayerLevel.skillPoints >= levelSpecial1Price) { levelUpSpeciaPriceslText[0].color = Color.green; }
        if (PlayerLevel.skillPoints < levelSpecial1Price) { levelUpSpeciaPriceslText[0].color = Color.red; }

        if (PlayerLevel.skillPoints >= levelSpecial2Price) { levelUpSpeciaPriceslText[1].color = Color.green; }
        if (PlayerLevel.skillPoints < levelSpecial2Price) { levelUpSpeciaPriceslText[1].color = Color.red; }

        if (PlayerLevel.skillPoints >= levelSpecial3Price) { levelUpSpeciaPriceslText[2].color = Color.green; }
        if (PlayerLevel.skillPoints < levelSpecial3Price) { levelUpSpeciaPriceslText[2].color = Color.red; }

        if (PlayerLevel.skillPoints >= levelSpecial4Price) { levelUpSpeciaPriceslText[3].color = Color.green; }
        if (PlayerLevel.skillPoints < levelSpecial4Price) { levelUpSpeciaPriceslText[3].color = Color.red; }

        if (PlayerLevel.skillPoints >= levelSpecial5Price) { levelUpSpeciaPriceslText[4].color = Color.green; }
        if (PlayerLevel.skillPoints < levelSpecial5Price) { levelUpSpeciaPriceslText[4].color = Color.red; }
        #endregion

        #region strongerSpecial
        if (PlayerLevel.skillPoints >= strongerSpecial1Price) { strongerSpecialPricesText[0].color = Color.green; }
        if (PlayerLevel.skillPoints < strongerSpecial1Price) { strongerSpecialPricesText[0].color = Color.red; }

        if (PlayerLevel.skillPoints >= strongerSpecial2Price) { strongerSpecialPricesText[1].color = Color.green; }
        if (PlayerLevel.skillPoints < strongerSpecial2Price) { strongerSpecialPricesText[1].color = Color.red; }

        if (PlayerLevel.skillPoints >= strongerSpecial3Price) { strongerSpecialPricesText[2].color = Color.green; }
        if (PlayerLevel.skillPoints < strongerSpecial3Price) { strongerSpecialPricesText[2].color = Color.red; }

        if (PlayerLevel.skillPoints >= strongerSpecial4Price) { strongerSpecialPricesText[3].color = Color.green; }
        if (PlayerLevel.skillPoints < strongerSpecial4Price) { strongerSpecialPricesText[3].color = Color.red; }

        if (PlayerLevel.skillPoints >= strongerSpecial5Price) { strongerSpecialPricesText[4].color = Color.green; }
        if (PlayerLevel.skillPoints < strongerSpecial5Price) { strongerSpecialPricesText[4].color = Color.red; }

        if (PlayerLevel.skillPoints >= strongerSpecial6Price) { strongerSpecialPricesText[5].color = Color.green; }
        if (PlayerLevel.skillPoints < strongerSpecial6Price) { strongerSpecialPricesText[5].color = Color.red; }

        if (PlayerLevel.skillPoints >= strongerSpecial7Price) { strongerSpecialPricesText[6].color = Color.green; }
        if (PlayerLevel.skillPoints < strongerSpecial7Price) { strongerSpecialPricesText[6].color = Color.red; }
        #endregion

        #region startWith
        if (PlayerLevel.skillPoints >= startWithItem1Price) { startWithPricesText[0].color = Color.green; }
        if (PlayerLevel.skillPoints < startWithItem1Price) { startWithPricesText[0].color = Color.red; }

        if (PlayerLevel.skillPoints >= startWithItem2Price) { startWithPricesText[1].color = Color.green; }
        if (PlayerLevel.skillPoints < startWithItem2Price) { startWithPricesText[1].color = Color.red; }

        if (PlayerLevel.skillPoints >= startWithItem3Price) { startWithPricesText[2].color = Color.green; }
        if (PlayerLevel.skillPoints < startWithItem3Price) { startWithPricesText[2].color = Color.red; }

        if (PlayerLevel.skillPoints >= startWithItem4Price) { startWithPricesText[3].color = Color.green; }
        if (PlayerLevel.skillPoints < startWithItem4Price) { startWithPricesText[3].color = Color.red; }
        #endregion

        #endregion
    }

    #region open and exit skilltree

    private Vector3 originalPosition;
    public GameObject exitPrestigeScreenButtonOnlyView, exitPrestigeScreenButton;
    public GameObject onlyViewingPrestigeScreen;

    public void ViewPrestigeScreen()
    {
        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("UIClick3"); }
        onlyViewingPrestigeScreen.SetActive(true);
        UIelementsClick.hideCursors = true;
        exitPrestigeScreenButton.SetActive(false);
        exitPrestigeScreenButtonOnlyView.SetActive(true);
        prestigeScreenAnim.SetActive(true);
        prestigeScreenAnim.transform.localScale = new Vector3(1, 1, 1);
        prestigeScreenAnim.transform.localPosition = new Vector3(0, 0, 0);
        isInSkillTree = false;
        CheckPriceTextColor();
        if (PlaceMobileButtons.isMobile == true)
        {
            sliderContent.transform.localPosition = new Vector2(-786, 0);
        }
    }
    public void ExitPrestigeOnlyViewing()
    {
        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("UIClick3"); }
        onlyViewingPrestigeScreen.SetActive(false);
        UIelementsClick.hideCursors = false;
        prestigeScreenAnim.SetActive(false);
        isInSkillTree = false;
    }


    public void ClickOnPrestigeChest()
    {
        dark.SetActive(true);
        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("UIClick3"); }
        if (prestigeChestPopUp.activeInHierarchy == true) { prestigeChestPopUp.SetActive(false); }
        else if (prestigeChestPopUp.activeInHierarchy == false)
        {
            prestigeChestPopUp.SetActive(true);
            CheckPriceTextColor();
        }
    }

    public static bool isPrestiged;
    public GameObject blockSaveButton, dark;
    public void ClickOkOnPrestige()
    {
        dark.SetActive(false);
        //SpecialUpgradesButtons.miniChestSpawnTimer = 10;
        blockSaveButton.SetActive(true);
        UIelementsClick.hideCursors = true;
        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("UIClick3"); }
        isPrestiged = true;
        isInsideskillTree = true;
        if (startWithItem1Bought == 1) { startWithItemCount = 1; }
        if (startWithItem2Bought == 1) { startWithItemCount = 2; }
        if (startWithItem3Bought == 1) { startWithItemCount = 3; }
        if (startWithItem4Bought == 1) { startWithItemCount = 5; }

        originalPosition = keyAnim.transform.position;

        Stats.prestigedTimesCount += 1;

        StartCoroutine(setItems());
        prestigeChestPopUp.SetActive(false);
        keyAnim.SetActive(true); keyAnim.GetComponent<Animation>().Play();
        isInSkillTree = true;
        SaveAndLoad.resetMiniChests = true;
        SaveAndLoad.resetMimicChest = true;

        exitPrestigeScreenButton.SetActive(true);
        exitPrestigeScreenButtonOnlyView.SetActive(false);


        StartCoroutine(prestigeChestWait());
        CheckPriceTextColor();
    }

    public void ExitPrestigePopUp()
    {
        dark.SetActive(false);
        //set key anim back to where it was before the anim started
        prestigeChestPopUp.SetActive(false);
        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("UIClick3"); }
    }
   
    IEnumerator setItems()
    {
        yield return new WaitForSeconds(1.5f);
        UseConsumable.KeysCount = 0; UseConsumable.hammerCount = 0; UseConsumable.goldenTouchCount = 0; UseConsumable.lockPickCount = 0; UseConsumable.treasureBagCount = 0;
        UseConsumable.XPPotionCount = 0; UseConsumable.damagePotioncount = 0; UseConsumable.lootPotionCount = 0;
        UseConsumable.elixirCount = 0; UseConsumable.scrollCount = 0; UseConsumable.gauntletCount = 0; UseConsumable.relicCount = 0; UpdateGame.knifeCount = 0;
        UpdateGame.treasurePotionCount = 0;
        SaveAndLoad.resetMiniChests = false;
        SaveAndLoad.resetMimicChest = false;
    }

    IEnumerator prestigeChestWait()
    {
        yield return new WaitForSeconds(0.333f);
        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("PrestigeAnimSound"); }
        keyAnim.SetActive(false);
        prestigeChestFoundd.SetActive(false);
        prestigeChest.SetActive(false); prestigeChestOpen.SetActive(true);
        prestigeScreenAnim.SetActive(true);
        prestigeScreenAnim.GetComponent<Animation>().Play("skillTreeAnim");
        StartNewPrestigeClick();
        if (PlaceMobileButtons.isMobile == true)
        {
            sliderContent.transform.localPosition = new Vector2(-786, 0);
        }
    }

    //79

    public void stayInSkillTree()
    {
        exitScreen.SetActive(false);
        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("UIClick3"); }
    }

    public GameObject prestigeButtonRed, prestigeButtonGreen, maxMiniChestText;
    public GameObject prestigeKeyFoundd, prestigeKeyNotFound, prestigeChestFoundd, prestigeChestNotFound;
    public GameObject shopBar, cursorBar, prestigeBar, treasureBar, itemsBar;
    public TextMeshProUGUI findTheChestAndKeyText;
    public Scrollbar shopScroll, cursorsScroll, itemsScroll, treasuresScroll;

    public void ExitSkillTree()
    {
        blockSaveButton.SetActive(false);
        UIelementsClick.hideCursors = false;
        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("PrestigeAnimSound"); }
        maxMiniChestText.SetActive(false);
        isPrestiged = false;
        itemsChosen = 0;
        exitScreen.SetActive(false);

        keyAnim.transform.position = originalPosition;
        isInSkillTree = false;

        findTheChestAndKeyText.text = Localization.FindThePrestigeKeyandChest;
        findTheChestAndKeyText.color = Color.red;

        prestigeButtonRed.SetActive(true); prestigeButtonGreen.SetActive(false);
        prestigeKeyFoundd.SetActive(false); prestigeKeyNotFound.SetActive(true); prestigeChestFoundd.SetActive(false); prestigeChestNotFound.SetActive(true);
        SpawnRewards.prestigeKeyFound = 0; SpawnRewards.prestigeChestFound = 0;
        prestigeScreenAnim.GetComponent<Animation>().Play("skillTreeAnimBack");
        StartCoroutine(animBack());
        prestigeChestOpen.SetActive(false);

        if(PlaceMobileButtons.isMobile == false)
        {
            itemsBar.SetActive(true); cursorBar.SetActive(true);
            shopBar.SetActive(true); prestigeBar.SetActive(false); treasureBar.SetActive(true);
        }
        else
        {
            sliderContent.transform.localPosition = new Vector2(-786, 0);
            mobileScript.OpenJustChests();
            itemsBar.SetActive(false); cursorBar.SetActive(false);
            shopBar.SetActive(false); prestigeBar.SetActive(false); treasureBar.SetActive(false);
        }
        

        shopScroll.value = 1; cursorsScroll.value = 1; itemsScroll.value = 1; treasuresScroll.value = 1;

        StartNewPrestige();

        SpecialUpgradesButtons.hammerOff = false; SpecialUpgradesButtons.lootOff = false; SpecialUpgradesButtons.damageOff = false; SpecialUpgradesButtons.XPOff = false; SpecialUpgradesButtons.goldenTouchOff = false; SpecialUpgradesButtons.miniChestOff = false; SpecialUpgradesButtons.keyOff = false; SpecialUpgradesButtons.treasureBagOff = false; SpecialUpgradesButtons.scrollOff = false; SpecialUpgradesButtons.gauntletOff = false; SpecialUpgradesButtons.elixirOFf = false; SpecialUpgradesButtons.relicOff = false; 

        foreach (GameObject obj in itemsCountText)
        {
            obj.SetActive(false);
        }
        choseItemsPupUp.SetActive(false);
        SpawnRewards.gemOnScreenCount = 0;
        mobileScript.ResetShopInfoBtn();

       
    }

    public GameObject sliderContent;

    IEnumerator animBack()
    {
        yield return new WaitForSeconds(0.6f);
        prestigeScreenAnim.SetActive(false);
    }

    #endregion


    //Start with items
    #region startWithITems
    public GameObject exitScreen;
    public GameObject[] startWithLocks = new GameObject[12];
    public GameObject[] startWithIcons = new GameObject[12];
    public GameObject[] itemsCountText = new GameObject[12];
    public GameObject startWithLocked;
    public TextMeshProUGUI chooseItemText;
    public GameObject choseItemsPupUp;
    public GameObject lockPickLock, hammerLock, lootPotionLock, damagePotionLock, xpPotionLock, goldenTouchLock, keyLock, treasureBagLock, scrollLock, gauntletLock, elixirLock, relicLock, treasurePotionLock, knifeLock;

    public void openExitScreen()
    {
        exitScreen.SetActive(true);

        //If player cant whooce item
        if (startWithItem1Bought != 1)
        {
            chooseItemText.text = Localization.choseItemToStartWith;
            startWithLocked.SetActive(true);
            foreach (GameObject obj in startWithIcons)
            {
                obj.SetActive(false);
            }
        }

        //If player can choose item(s)
        if(startWithItem1Bought == 1)
        {
            chooseItemText.text = Localization.choseItemToStartWith;
            startWithLocked.SetActive(false);
            if (SpecialUpgradesButtons.lockPickBoughtFirstTime == 1) { startWithLocks[0].SetActive(false); startWithIcons[0].SetActive(true); }
            if (SpecialUpgradesButtons.hammerBoughtFirstTime == 1) { startWithLocks[1].SetActive(false); startWithIcons[1].SetActive(true); }
            if (SpecialUpgradesButtons.lootPotionBoughtFirstTime == 1) { startWithLocks[2].SetActive(false); startWithIcons[2].SetActive(true); }
            if (SpecialUpgradesButtons.damagePotionBoughtFirstTime == 1) { startWithLocks[3].SetActive(false); startWithIcons[3].SetActive(true); }
            if (SpecialUpgradesButtons.XPPotionBoughtFirstTime == 1) { startWithLocks[4].SetActive(false); startWithIcons[4].SetActive(true); }
            if (SpecialUpgradesButtons.goldenTouchBoughtFirstTime == 1) { startWithLocks[5].SetActive(false); startWithIcons[5].SetActive(true); }
            if (SpecialUpgradesButtons.keyBoughtFirstTime == 1) { startWithLocks[6].SetActive(false); startWithIcons[6].SetActive(true); }
            if (SpecialUpgradesButtons.treasureBagBoughtFirstTime == 1) { startWithLocks[7].SetActive(false); startWithIcons[7].SetActive(true); }
            if (SpecialUpgradesButtons.scrollBoughtFirstTime == 1) { startWithLocks[8].SetActive(false); startWithIcons[8].SetActive(true); }
            if (SpecialUpgradesButtons.gauntletBoughtFirstTime == 1) { startWithLocks[9].SetActive(false); startWithIcons[9].SetActive(true); }
            if (SpecialUpgradesButtons.elixirBoughtFirstTime == 1) { startWithLocks[10].SetActive(false); startWithIcons[10].SetActive(true); }
            if (SpecialUpgradesButtons.relicBoughtFirstTime == 1) { startWithLocks[11].SetActive(false); startWithIcons[11].SetActive(true); }
            if (UpdateGame.treasurePotionBoughtFirstTime == 1) { startWithLocks[12].SetActive(false); startWithIcons[12].SetActive(true); }
            if (UpdateGame.knifeBoughtFirstTime == 1) { startWithLocks[13].SetActive(false); startWithIcons[13].SetActive(true); }
        }
        if(startWithItem2Bought == 1) { chooseItemText.text = Localization.chooseItemsToStartWith2; }
        if (startWithItem3Bought == 1) { chooseItemText.text = Localization.chooseItemsToStartWith3; }
        if (startWithItem4Bought == 1) { chooseItemText.text = Localization.chooseItemsToStartWith5; }
    }

    public int itemsChosen;

    public void ChooseLockPick()
    {
        lockPickLock.SetActive(false);
        UseConsumable.lockPickCount += 1;
        itemsChosen += 1;
        itemsCountText[0].SetActive(true);
        itemsCountText[0].GetComponent<TextMeshProUGUI>().text = "" + itemsChosen;
        startWithItemCount -= 1;
        isItemCountTotal();
    }

    public void ChooseHammer()
    {
        hammerLock.SetActive(false);
        UseConsumable.hammerCount += 1;
        itemsChosen += 1;
        itemsCountText[1].SetActive(true);
        itemsCountText[1].GetComponent<TextMeshProUGUI>().text = "" + itemsChosen;

        startWithItemCount -= 1;
        isItemCountTotal();
    }

    public void ChooselootPotion()
    {
        lootPotionLock.SetActive(false);
        UseConsumable.lootPotionCount += 1;
        itemsChosen += 1;
        itemsCountText[2].SetActive(true);
        itemsCountText[2].GetComponent<TextMeshProUGUI>().text = "" + itemsChosen;

        startWithItemCount -= 1;
        isItemCountTotal();
    }

    public void ChooseDamagePotion()
    {
        damagePotionLock.SetActive(false);
        UseConsumable.damagePotioncount += 1;
        itemsChosen += 1;
        itemsCountText[3].SetActive(true);
        itemsCountText[3].GetComponent<TextMeshProUGUI>().text = "" + itemsChosen;

        startWithItemCount -= 1;
        isItemCountTotal();
    }
    public void ChooseXPPotion()
    {
        xpPotionLock.SetActive(false);
        UseConsumable.XPPotionCount += 1;
        itemsChosen += 1;
        itemsCountText[4].SetActive(true);
        itemsCountText[4].GetComponent<TextMeshProUGUI>().text = "" + itemsChosen;

        startWithItemCount -= 1;
        isItemCountTotal();
    }

    public void ChooseGoldenTouch()
    {
        goldenTouchLock.SetActive(false);
        UseConsumable.goldenTouchCount += 1;
        itemsChosen += 1;
        itemsCountText[5].SetActive(true);
        itemsCountText[5].GetComponent<TextMeshProUGUI>().text = "" + itemsChosen;

        startWithItemCount -= 1;
        isItemCountTotal();
    }

    public void ChooseKey()
    {
        keyLock.SetActive(false);
        UseConsumable.KeysCount += 1;
        itemsChosen += 1;
        itemsCountText[6].SetActive(true);
        itemsCountText[6].GetComponent<TextMeshProUGUI>().text = "" + itemsChosen;

        startWithItemCount -= 1;
        isItemCountTotal();
    }

    public void ChooseTreasureBag()
    {
        treasureBagLock.SetActive(false);
        UseConsumable.treasureBagCount += 1;
        itemsChosen += 1;
        itemsCountText[7].SetActive(true);
        itemsCountText[7].GetComponent<TextMeshProUGUI>().text = "" + itemsChosen;

        startWithItemCount -= 1;
        isItemCountTotal();
    }

    public void ChooseScroll()
    {
        scrollLock.SetActive(false);
        UseConsumable.scrollCount += 1;
        itemsChosen += 1;
        itemsCountText[8].SetActive(true);
        itemsCountText[8].GetComponent<TextMeshProUGUI>().text = "" + itemsChosen;

        startWithItemCount -= 1;
        isItemCountTotal();
    }

    public void ChooseGauntlet()
    {
        gauntletLock.SetActive(false);
        UseConsumable.gauntletCount += 1;
        itemsChosen += 1;
        itemsCountText[9].SetActive(true);
        itemsCountText[9].GetComponent<TextMeshProUGUI>().text = "" + itemsChosen;

        startWithItemCount -= 1;
        isItemCountTotal();
    }
    public void ChooseElixir()
    {
        elixirLock.SetActive(false);
        UseConsumable.elixirCount += 1;
        itemsChosen += 1;
        itemsCountText[10].SetActive(true);
        itemsCountText[10].GetComponent<TextMeshProUGUI>().text = "" + itemsChosen;

        startWithItemCount -= 1;
        isItemCountTotal();
    }
    public void ChooseRelic()
    {
        relicLock.SetActive(false);
        UseConsumable.relicCount += 1;
        itemsChosen += 1;
        itemsCountText[11].SetActive(true);
        itemsCountText[11].GetComponent<TextMeshProUGUI>().text = "" + itemsChosen;

        startWithItemCount -= 1;
        isItemCountTotal();
    }

    public void ChooseTreasurePotion()
    {
        treasurePotionLock.SetActive(false);
        UpdateGame.treasurePotionCount += 1;
        itemsChosen += 1;
        itemsCountText[12].SetActive(true);
        itemsCountText[12].GetComponent<TextMeshProUGUI>().text = "" + itemsChosen;

        startWithItemCount -= 1;
        isItemCountTotal();
    }

    public void ChooseKnife()
    {
        knifeLock.SetActive(false);
        UpdateGame.knifeCount += 1;
        itemsChosen += 1;
        itemsCountText[13].SetActive(true);
        itemsCountText[13].GetComponent<TextMeshProUGUI>().text = "" + itemsChosen;

        startWithItemCount -= 1;
        isItemCountTotal();
    }



    public void isItemCountTotal()
    {
        if(startWithItemCount == 0) {
            choseItemsPupUp.SetActive(true);
        }
    }


    public void chooseSomethingElse()
    {
        itemsChosen = 0;
        choseItemsPupUp.SetActive(false);
        if (startWithItem1Bought == 1) { startWithItemCount = 1; }
        if (startWithItem2Bought == 1) { startWithItemCount = 2; }
        if (startWithItem3Bought == 1) { startWithItemCount = 3; }
        if (startWithItem4Bought == 1) { startWithItemCount = 5; }


        foreach (GameObject obj in itemsCountText)
        {
            obj.SetActive(false);
        }

        UseConsumable.KeysCount = 0; UseConsumable.hammerCount = 0; UseConsumable.goldenTouchCount = 0; UseConsumable.lockPickCount = 0; UseConsumable.treasureBagCount = 0;
        UseConsumable.XPPotionCount = 0; UseConsumable.damagePotioncount = 0; UseConsumable.lootPotionCount = 0;
        UseConsumable.elixirCount = 0; UseConsumable.scrollCount = 0; UseConsumable.gauntletCount = 0; UseConsumable.relicCount = 0;
        UpdateGame.treasurePotionCount = 0; UpdateGame.knifeCount = 0;

        lockPickLock.SetActive(true); hammerLock.SetActive(true); lootPotionLock.SetActive(true); damagePotionLock.SetActive(true); xpPotionLock.SetActive(true); goldenTouchLock.SetActive(true);  keyLock.SetActive(true); treasureBagLock.SetActive(true); scrollLock.SetActive(true); gauntletLock.SetActive(true); elixirLock.SetActive(true); relicLock.SetActive(true); treasurePotionLock.SetActive(true); knifeLock.SetActive(true);
    }
    #endregion


    #region critBRanch
    public Image[] critUpgrade = new Image[5];
    public GameObject[] critLocks = new GameObject[4];
    public GameObject[] critIcons = new GameObject[4];
    public static int crit1Price, crit2Price, crit3Price, crit4Price, crit5Price;
    public static int crit1Bought, crit2Bought, crit3Bought, crit4Bought, crit5Bought;

    public void BuyCrit1Upgrade()
    {
        if(isInSkillTree == true && PlayerLevel.skillPoints >= crit1Price)
        {
            if(PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }

            Stats.prestigeUpgradesPurchased += 1;
            Stats.clickerUpgradePurchased += 1;

            PlayerLevel.skillPoints -= crit1Price;
            crit1Bought = 1;
            skillTreeCritChance += 0.5f;
            skillTreeCritDamage += 1.5f;
            SetAlpha(critUpgrade[0], alphaValueFull);
            critLocks[0].SetActive(false); critIcons[1].SetActive(true);
            SomethingAllUpgradesDo();

            critUnlocked[0].SetActive(true);
        }
        else { NotEnoughPoints(); }
    }

    public void BuyCrit2Upgrade()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= crit2Price && crit1Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.clickerUpgradePurchased += 1;
            PlayerLevel.skillPoints -= crit2Price;
            crit2Bought = 1;
            skillTreeCritChance += 1.5f;
            skillTreeCritDamage += 7.5f;
            SetAlpha(critUpgrade[1], alphaValueFull);
            critLocks[1].SetActive(false); critIcons[2].SetActive(true);
            SomethingAllUpgradesDo();

            critUnlocked[1].SetActive(true);
        }
        else { NotEnoughPoints(); }
    }

    public void BuyCrit3Upgrade()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= crit3Price && crit2Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.clickerUpgradePurchased += 1;
            PlayerLevel.skillPoints -= crit3Price;
            crit3Bought = 1;
            skillTreeCritChance += 1.8f;
            skillTreeCritDamage += 15f;
            SetAlpha(critUpgrade[2], alphaValueFull);
            critLocks[2].SetActive(false); critIcons[3].SetActive(true);
            SomethingAllUpgradesDo();

            critUnlocked[2].SetActive(true);
        }
        else { NotEnoughPoints(); }
    }

    public static int crit4CritGoldChance;
    public void BuyCrit4Upgrade()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= crit4Price && crit3Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.clickerUpgradePurchased += 1;
            PlayerLevel.skillPoints -= crit4Price;
            crit4Bought = 1;
            skillTreeCritChance += 2.2f;
            crit4CritGoldChance = 11;
            SetAlpha(critUpgrade[3], alphaValueFull);
            critLocks[3].SetActive(false); critIcons[4].SetActive(true);
            SomethingAllUpgradesDo();

            critUnlocked[3].SetActive(true);
        }
        else { NotEnoughPoints(); }
    }

    public static int crit5CritTreasureChance;
    public void BuyCrit5Upgrade()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= crit5Price && crit4Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.clickerUpgradePurchased += 1;
            PlayerLevel.skillPoints -= crit5Price;
            crit5Bought = 1;
            crit5CritTreasureChance = 5;
            skillTreeCritDamage += 25f;
            SetAlpha(critUpgrade[4], alphaValueFull);
            SomethingAllUpgradesDo();

            critUnlocked[4].SetActive(true);
        }
        else { NotEnoughPoints(); }

    }
    #endregion

    #region activeBranch
    public Image[] activeDamageUpgrade = new Image[6];
    public GameObject[] activeDamageLocks = new GameObject[5];
    public GameObject[] activeDamageIcons = new GameObject[5];
    public static int active1Price, active2Price, active3Price, active4Price, active5Price, active6Price, active7Price;
    public static int active1Bought, active2Bought, active3Bought, active4Bought, active5Bought, active6Bought, active7Bought;
    public void BuyActiveBranch1()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= active1Price)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.clickerUpgradePurchased += 1;
            PlayerLevel.skillPoints -= active1Price;
            active1Bought = 1;
            skillTreeActiveDamage += 0.5f;
            SetAlpha(activeDamageUpgrade[0], alphaValueFull);
            activeDamageLocks[0].SetActive(false); activeDamageIcons[0].SetActive(true); activeUnlocked[0].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyActiveBranch2()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= active2Price && active1Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.clickerUpgradePurchased += 1;
            PlayerLevel.skillPoints -= active2Price;
            active2Bought = 1;
            skillTreeActiveDamage += 3.25f;
            SetAlpha(activeDamageUpgrade[1], alphaValueFull);
            activeDamageLocks[1].SetActive(false); activeDamageIcons[1].SetActive(true); activeUnlocked[1].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyActiveBranch3()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= active3Price && active2Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.clickerUpgradePurchased += 1;
            PlayerLevel.skillPoints -= active3Price;
            active3Bought = 1;
            skillTreeActiveDamage += 10f;
            SetAlpha(activeDamageUpgrade[2], alphaValueFull);
            activeDamageLocks[2].SetActive(false); activeDamageIcons[2].SetActive(true); activeUnlocked[2].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public static float active4GoldChance;
    public void BuyActiveBranch4()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= active4Price && active3Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.clickerUpgradePurchased += 1;
            PlayerLevel.skillPoints -= active4Price;
            active4Bought = 1;
            skillTreeActiveDamage += 22.5f;
            active4GoldChance = 1f;
            SetAlpha(activeDamageUpgrade[3], alphaValueFull);
            activeDamageLocks[3].SetActive(false); activeDamageIcons[3].SetActive(true); activeUnlocked[3].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public static float active5TreasureChance;
    public void BuyActiveBranch5()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= active5Price && active4Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.clickerUpgradePurchased += 1;
            PlayerLevel.skillPoints -= active5Price;
            active5Bought = 1;
            active5TreasureChance = 0.1f;
            skillTreeActiveDamage += 35f;
            SetAlpha(activeDamageUpgrade[4], alphaValueFull);
            activeDamageLocks[4].SetActive(false); activeDamageIcons[4].SetActive(true); activeUnlocked[4].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public static float active6InstantlyOpenChance;
    public void BuyActiveBranch6()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= active6Price && active5Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.clickerUpgradePurchased += 1;
            PlayerLevel.skillPoints -= active6Price;
            active6Bought = 1;
            active6InstantlyOpenChance = 0.4f;
            skillTreeActiveDamage += 100f;
            SetAlpha(activeDamageUpgrade[5], alphaValueFull);
            activeDamageLocks[5].SetActive(false); activeDamageIcons[5].SetActive(true); activeUnlocked[5].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    //New
    public void BuyActiveBranch7()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= active7Price && active6Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.clickerUpgradePurchased += 1;
            PlayerLevel.skillPoints -= active7Price;
            active7Bought = 1;
            skillTreeActiveDamage += 150f;
            SetAlpha(activeDamageUpgrade[6], alphaValueFull); activeUnlocked[6].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    #endregion

    #region activeCursorBranch

    public Image[] activeCursorUpgrades = new Image[4];
    public GameObject[] activeCursorLocks = new GameObject[3];
    public GameObject[] activeCursorIcons = new GameObject[3];
    public static int activeCursor1Price, activeCursor2Price, activeCursor3Price, activeCursor4Price;
    public static int activeCursor1Bought, activeCursor2Bought, activeCursor3Bought, activeCursor4Bought;

    public void BuyActiveCursor1()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= activeCursor1Price)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.clickerUpgradePurchased += 1;
            PlayerLevel.skillPoints -= activeCursor1Price;

            #region strongeractiveCursors
            //Cursor1
            ClickPower.cursor1ActiveBuffIncrement += 0.01f;

            //Cursor3
            ClickPower.cursor3CritChanceIncrement += 0.1f;
            ClickPower.cursor3CritDamageIncrement += 0.1f;

            //Cursor4
            ClickPower.cursor4ActiveDamageIncrement += 0.01f;

            //Cursor5
            ClickPower.cursor5ActiveDamageIncrement += 0.03f;
            ClickPower.cursor5CritDamageIncrement += 0.1f;
            ClickPower.cursor5CritChanceIncrement += 0.1f;

            //Cursor6
            ClickPower.cursor6CritChanceIncrement += 0.1f;
            ClickPower.cursor6ActiveDamageIncrement += 0.04f;
            ClickPower.cursor6CritDamageIncrement += 0.1f;

            //Cursor7
            ClickPower.cursor7ActiveDamageIncrement += 0.04f;
            ClickPower.cursor7CritChanceIncrement += 0.1f;
            ClickPower.cursor7CritDamageIncrement += 0.2f;

            //Cursor8
            ClickPower.cursor8ActiveDamageIncrement += 0.1f;
            ClickPower.cursor8CritChanceIncrement += 0.1f;
            ClickPower.cursor8CritDamageIncrement += 0.2f;

            //Cursor9
            ClickPower.cursor9ActiveDamageIncrement += 0.2f;

            //Cursor11
            ClickPower.cursor11ActiveDamageIncrement += 0.2f;
            ClickPower.cursor11CritChanceIncrement += 0.1f;
            ClickPower.cursor11CritDamageIncrement += 0.2f;

            //Cursor12
            ClickPower.cursor12ActiveDamageIncrement += 0.2f;
            ClickPower.cursor12CritChanceIncrement += 0.1f;
            ClickPower.cursor12CritDamageIncrement += 0.2f;

            //Cursor13
            ClickPower.cursor13ActiveDamageIncrement += 0.2f;
            ClickPower.cursor13CritChanceIncrement += 0.1f;
            ClickPower.cursor13CritDamageIncrement += 0.2f;

            //Cursor14
            ClickPower.cursor14ActiveDamageIncrement += 0.3f;
            ClickPower.cursor14CritChanceIncrement += 0.1f;
            ClickPower.cursor14CritDamageIncrement += 0.2f;

            //Cursor15
            ClickPower.cursor15ActiveDamageIncrement += 0.3f;
            ClickPower.cursor15CritChanceIncrement += 0.1f;
            ClickPower.cursor15CritDamageIncrement += 0.2f;

            //Cursor16
            ClickPower.cursor16ActiveDamageIncrement += 0.3f;
            ClickPower.cursor16CritChanceIncrement += 0.1f;
            ClickPower.cursor16CritDamageIncrement += 0.3f;

            //Cursor17
            ClickPower.cursor17ActiveDamageIncrement += 0.4f;
            ClickPower.cursor17CritChanceIncrement += 0.1f;
            ClickPower.cursor17CritDamageIncrement += 0.3f;

            //Cursor18
            ClickPower.cursor17ActiveDamageIncrement += 0.5f;
            ClickPower.cursor17CritChanceIncrement += 0.1f;
            ClickPower.cursor17CritDamageIncrement += 0.4f;


            #endregion

            activeCursor1Bought = 1;
            SetAlpha(activeCursorUpgrades[0], alphaValueFull);
            activeCursorLocks[0].SetActive(false); activeCursorIcons[0].SetActive(true); activeCursorUnlocked[0].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyActiveCursor2()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= activeCursor2Price && activeCursor1Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.clickerUpgradePurchased += 1;
            PlayerLevel.skillPoints -= activeCursor2Price;
            activeCursor2Bought = 1;

            #region strongeractiveCursors
            //Cursor1
            ClickPower.cursor1ActiveBuffIncrement += 0.02f;

            //Cursor3
            ClickPower.cursor3CritChanceIncrement += 0.1f;
            ClickPower.cursor3CritDamageIncrement += 0.2f;

            //Cursor4
            ClickPower.cursor4ActiveDamageIncrement += 0.02f;

            //Cursor5
            ClickPower.cursor5ActiveDamageIncrement += 0.04f;
            ClickPower.cursor5CritDamageIncrement += 0.1f;
            ClickPower.cursor5CritChanceIncrement += 0.2f;

            //Cursor6
            ClickPower.cursor6CritChanceIncrement += 0.2f;
            ClickPower.cursor6ActiveDamageIncrement += 0.05f;
            ClickPower.cursor6CritDamageIncrement += 0.2f;

            //Cursor7
            ClickPower.cursor7ActiveDamageIncrement += 0.05f;
            ClickPower.cursor7CritChanceIncrement += 0.1f;
            ClickPower.cursor7CritDamageIncrement += 0.3f;

            //Cursor8
            ClickPower.cursor8ActiveDamageIncrement += 0.2f;
            ClickPower.cursor8CritChanceIncrement += 0.1f;
            ClickPower.cursor8CritDamageIncrement += 0.3f;

            //Cursor9
            ClickPower.cursor9ActiveDamageIncrement += 0.3f;

            //Cursor11
            ClickPower.cursor11ActiveDamageIncrement += 0.3f;
            ClickPower.cursor11CritChanceIncrement += 0.1f;
            ClickPower.cursor11CritDamageIncrement += 0.3f;

            //Cursor12
            ClickPower.cursor12ActiveDamageIncrement += 0.3f;
            ClickPower.cursor12CritChanceIncrement += 0.1f;
            ClickPower.cursor12CritDamageIncrement += 0.3f;

            //Cursor13
            ClickPower.cursor13ActiveDamageIncrement += 0.3f;
            ClickPower.cursor13CritChanceIncrement += 0.1f;
            ClickPower.cursor13CritDamageIncrement += 0.3f;

            //Cursor14
            ClickPower.cursor14ActiveDamageIncrement += 0.4f;
            ClickPower.cursor14CritChanceIncrement += 0.1f;
            ClickPower.cursor14CritDamageIncrement += 0.4f;

            //Cursor15
            ClickPower.cursor15ActiveDamageIncrement += 0.4f;
            ClickPower.cursor15CritChanceIncrement += 0.1f;
            ClickPower.cursor15CritDamageIncrement += 0.4f;

            //Cursor16
            ClickPower.cursor16ActiveDamageIncrement += 0.5f;
            ClickPower.cursor16CritChanceIncrement += 0.1f;
            ClickPower.cursor16CritDamageIncrement += 0.6f;

            //Cursor17
            ClickPower.cursor17ActiveDamageIncrement += 0.5f;
            ClickPower.cursor17CritChanceIncrement += 0.2f;
            ClickPower.cursor17CritDamageIncrement += 0.7f;

            //Cursor18
            ClickPower.cursor17ActiveDamageIncrement += 0.6f;
            ClickPower.cursor17CritChanceIncrement += 0.2f;
            ClickPower.cursor17CritDamageIncrement += 0.8f;
            #endregion

            SetAlpha(activeCursorUpgrades[1], alphaValueFull);
            activeCursorLocks[1].SetActive(false); activeCursorIcons[1].SetActive(true); activeCursorUnlocked[1].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyActiveCursor3()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= activeCursor3Price && activeCursor2Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.clickerUpgradePurchased += 1;
            PlayerLevel.skillPoints -= activeCursor3Price;
            activeCursor3Bought = 1;

            #region strongerCursors

            ClickPower.cursor1ActiveBuff = 0.08f;


            ClickPower.cursor3CritChance = 2.5f;
            ClickPower.cursor3CritDamage = 3f;

            ClickPower.cursor4ActiveDamage = 0.15f;

            ClickPower.cursor5ActiveDamage = 0.30f;
            ClickPower.cursor5CritChance = 5.5f;
            ClickPower.cursor5CritDamage = 3.0f;

            ClickPower.cursor6CritChance = 2.8f;
            ClickPower.cursor6CritDamage = 4.0f; ClickPower.cursor6ActiveDamage = 0.23f; 

            ClickPower.cursor7CritChance = 4.0f;  ClickPower.cursor7CritDamage = 5.90f;ClickPower.cursor7ActiveDamage = 0.65f; 

            ClickPower.cursor8ActiveDamage = 0.7f; 
            ClickPower.cursor8CritChance = 3.3f;ClickPower.cursor8CritDamage = 5.4f;

            ClickPower.cursor9ActiveDamage = 1.6f; 


            ClickPower.cursor11ActiveDamage = 2.1f; ClickPower.cursor11CritChance = 8.5f;  ClickPower.cursor11CritDamage = 4.2f; 

            ClickPower.cursor12ActiveDamage = 3.2f;  ClickPower.cursor12CritChance = 5.2f;  ClickPower.cursor12CritDamage = 6f;

            ClickPower.cursor13ActiveDamage = 5.1f;  ClickPower.cursor13CritChance = 5.5f; ClickPower.cursor13CritDamage = 6.9f;

            ClickPower.cursor14ActiveDamage = 7.1f;   ClickPower.cursor14CritChance = 6.9f;  ClickPower.cursor14CritDamage = 8.1f; 

            ClickPower.cursor15ActiveDamage = 9f;  ClickPower.cursor15CritChance = 3f;  ClickPower.cursor15CritDamage = 14f; 

            ClickPower.cursor16ActiveDamage = 11f;  ClickPower.cursor16CritChance = 6.1f;  ClickPower.cursor16CritDamage = 15f; 

            ClickPower.cursor17ActiveDamage = 14f; ClickPower.cursor17CritChance = 5.3f;  ClickPower.cursor17CritDamage = 19f; 

            ClickPower.cursor18ActiveDamage = 20f;  ClickPower.cursor18CritChance = 8.7f;  ClickPower.cursor18CritDamage = 21f; 

            #endregion

            SetAlpha(activeCursorUpgrades[2], alphaValueFull);
            activeCursorLocks[2].SetActive(false); activeCursorIcons[2].SetActive(true); activeCursorUnlocked[2].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyActiveCursor4()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= activeCursor4Price && activeCursor3Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.clickerUpgradePurchased += 1;
            PlayerLevel.skillPoints -= activeCursor4Price;
            activeCursor4Bought = 1;

            #region strongeractiveCursors
            //Cursor1
            ClickPower.cursor1ActiveBuffIncrement += 0.03f;

            //Cursor3
            ClickPower.cursor3CritChanceIncrement += 0.3f;
            ClickPower.cursor3CritDamageIncrement += 0.3f;

            //Cursor4
            ClickPower.cursor4ActiveDamageIncrement += 0.03f;

            //Cursor5
            ClickPower.cursor5ActiveDamageIncrement += 0.05f;
            ClickPower.cursor5CritDamageIncrement += 0.3f;
            ClickPower.cursor5CritChanceIncrement += 0.3f;

            //Cursor6
            ClickPower.cursor6CritChanceIncrement += 0.3f;
            ClickPower.cursor6ActiveDamageIncrement += 0.06f;
            ClickPower.cursor6CritDamageIncrement += 0.3f;

            //Cursor7
            ClickPower.cursor7ActiveDamageIncrement += 0.06f;
            ClickPower.cursor7CritChanceIncrement += 0.2f;
            ClickPower.cursor7CritDamageIncrement += 0.4f;

            //Cursor8
            ClickPower.cursor8ActiveDamageIncrement += 0.3f;
            ClickPower.cursor8CritChanceIncrement += 0.2f;
            ClickPower.cursor8CritDamageIncrement += 0.4f;

            //Cursor9
            ClickPower.cursor9ActiveDamageIncrement += 0.3f;

            //Cursor11
            ClickPower.cursor11ActiveDamageIncrement += 0.4f;
            ClickPower.cursor11CritChanceIncrement += 0.2f;
            ClickPower.cursor11CritDamageIncrement += 0.4f;

            //Cursor12
            ClickPower.cursor12ActiveDamageIncrement += 0.5f;
            ClickPower.cursor12CritChanceIncrement += 0.3f;
            ClickPower.cursor12CritDamageIncrement += 0.4f;

            //Cursor13
            ClickPower.cursor13ActiveDamageIncrement += 0.5f;
            ClickPower.cursor13CritChanceIncrement += 0.3f;
            ClickPower.cursor13CritDamageIncrement += 0.4f;

            //Cursor14
            ClickPower.cursor14ActiveDamageIncrement += 0.6f;
            ClickPower.cursor14CritChanceIncrement += 0.3f;
            ClickPower.cursor14CritDamageIncrement += 0.4f;

            //Cursor15
            ClickPower.cursor15ActiveDamageIncrement += 0.6f;
            ClickPower.cursor15CritChanceIncrement += 0.3f;
            ClickPower.cursor15CritDamageIncrement += 0.4f;

            //Cursor16
            ClickPower.cursor16ActiveDamageIncrement += 0.7f;
            ClickPower.cursor16CritChanceIncrement += 0.4f;
            ClickPower.cursor16CritDamageIncrement += 0.5f;

            //Cursor17
            ClickPower.cursor17ActiveDamageIncrement += 0.7f;
            ClickPower.cursor17CritChanceIncrement += 0.4f;
            ClickPower.cursor17CritDamageIncrement += 0.5f;

            //Cursor18
            ClickPower.cursor17ActiveDamageIncrement += 0.8f;
            ClickPower.cursor17CritChanceIncrement += 0.5f;
            ClickPower.cursor17CritDamageIncrement += 0.6f;
            #endregion

            #region strongerCursors
            ClickPower.cursor1ActiveBuff = 0.12f;

            ClickPower.cursor2PassiveBuff = 0.12f;

            ClickPower.cursor3CritChance = 3.1f;
            ClickPower.cursor3CritDamage = 3.7f;

            ClickPower.cursor4ActiveDamage = 0.27f;
            ClickPower.cursor4PassiveDamage = 0.27f;

            ClickPower.cursor5ActiveDamage = 0.45f;
            ClickPower.cursor5CritChance = 6.6f;
            ClickPower.cursor5CritDamage = 4.2f;

            ClickPower.cursor6PassiveDamage = 0.67f; ClickPower.cursor6CritChance = 3.5f;
            ClickPower.cursor6CritDamage = 5.1f; ClickPower.cursor6ActiveDamage = 0.4f;

            ClickPower.cursor7CritChance = 5.1f; ClickPower.cursor7CritDamage = 6.7f; ClickPower.cursor7ActiveDamage = 0.85f;

            ClickPower.cursor8ActiveDamage = 0.9f; ClickPower.cursor8PassiveDamage = 0.9f;
            ClickPower.cursor8CritChance = 4.4f; ClickPower.cursor8CritDamage = 6.9f;

            ClickPower.cursor9ActiveDamage = 2.4f; ClickPower.cursor9PassiveDamage = 2.4f;

            ClickPower.cursor10PassiveDamage = 5.0f;

            ClickPower.cursor11ActiveDamage = 3.2f; ClickPower.cursor11CritChance = 10f; ClickPower.cursor11CritDamage = 4.9f;

            ClickPower.cursor12ActiveDamage = 4.3f; ClickPower.cursor12PassiveDamage = 4.6f; ClickPower.cursor12CritChance = 6f; ClickPower.cursor12CritDamage = 7.2f;

            ClickPower.cursor13ActiveDamage = 7.0f; ClickPower.cursor13PassiveDamage = 7f; ClickPower.cursor13CritChance = 5.9f; ClickPower.cursor13CritDamage = 7.8f;

            ClickPower.cursor14ActiveDamage = 9f; ClickPower.cursor14PassiveDamage = 9f; ClickPower.cursor14CritChance = 7.2f; ClickPower.cursor14CritDamage = 9.7f;

            ClickPower.cursor15ActiveDamage = 11f; ClickPower.cursor15PassiveDamage = 13f; ClickPower.cursor15CritChance = 4.1f; ClickPower.cursor15CritDamage = 15.2f;

            ClickPower.cursor16ActiveDamage = 14f; ClickPower.cursor16PassiveDamage = 14f; ClickPower.cursor16CritChance = 6.8f; ClickPower.cursor16CritDamage = 16.8f;

            ClickPower.cursor17ActiveDamage = 19f; ClickPower.cursor17PassiveDamage = 19f; ClickPower.cursor17CritChance = 6.0f; ClickPower.cursor17CritDamage = 21f;

            ClickPower.cursor18ActiveDamage = 25f; ClickPower.cursor18PassiveDamage = 25f; ClickPower.cursor18CritChance = 10f; ClickPower.cursor18CritDamage = 27f;
            #endregion

            SetAlpha(activeCursorUpgrades[3], alphaValueFull); activeCursorUnlocked[3].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    #endregion


    #region autoClickerBranch
    public Image[] autoClickerUpgrades = new Image[4];
    public GameObject[] autoClickerLocks = new GameObject[3];
    public GameObject[] autoClickerIcons = new GameObject[3];
    public static int autoClicker1Price, autoClicker2Price, autoClicker3Price, autoClicker4Price;
    public static int autoClicker1Bought, autoClicker2Bought, autoClicker3Bought, autoClicker4Bought;
    public static float autoClickerDamage;
    public static float autoClicksPerSecond;

    public void BuyAutoClicker1()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= autoClicker1Price)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.loungerUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= autoClicker1Price;
            autoClicker1Bought = 1;
            autoClicksPerSecond = 1;
            SetAlpha(autoClickerUpgrades[0], alphaValueFull);
            autoClickerLocks[0].SetActive(false); autoClickerIcons[0].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyAutoClicker2()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= autoClicker2Price && autoClicker1Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.loungerUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= autoClicker2Price;
            autoClicker2Bought = 1;
            autoClicksPerSecond = 0.5f;
            SetAlpha(autoClickerUpgrades[1], alphaValueFull);
            autoClickerLocks[1].SetActive(false); autoClickerIcons[1].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyAutoClicker3()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= autoClicker3Price && autoClicker2Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.loungerUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= autoClicker3Price;
            autoClicker3Bought = 1;
            autoClicksPerSecond = 0.25f;
            SetAlpha(autoClickerUpgrades[2], alphaValueFull);
            autoClickerLocks[2].SetActive(false); autoClickerIcons[2].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyAutoClicker4()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= autoClicker4Price && autoClicker3Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.loungerUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= autoClicker4Price;
            autoClicker4Bought = 1;
            autoClicksPerSecond = 0.125f;
            SetAlpha(autoClickerUpgrades[3], alphaValueFull);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }
    #endregion

    #region autoDamageBranch
    public Image[] autoDamageUpgrades = new Image[7];
    public GameObject[] autoDamageLocks = new GameObject[6];
    public GameObject[] autoDamageIcons = new GameObject[6];
    public static int autoDamage1Price, autoDamage2Price, autoDamage3Price, autoDamage4Price, autoDamage5Price, autoDamage6Price, autoDamage7Price, autoDamage8Price;
    public static int autoDamage1Bought, autoDamage2Bought, autoDamage3Bought, autoDamage4Bought, autoDamage5Bought, autoDamage6Bought, autoDamage7Bought, autoDamage8Bought;

    public void BuyAutoDamage1()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= autoDamage1Price)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.loungerUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= autoDamage1Price;
            autoDamage1Bought = 1;
            skillTreePassiveDamage += 0.25f;
            SetAlpha(autoDamageUpgrades[0], alphaValueFull);
            autoDamageLocks[0].SetActive(false); autoDamageIcons[0].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }
    public void BuyAutoDamage2()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= autoDamage2Price && autoDamage1Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.loungerUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= autoDamage2Price;
            autoDamage2Bought = 1;
            skillTreePassiveDamage += 1.15f;
            SetAlpha(autoDamageUpgrades[1], alphaValueFull);
            autoDamageLocks[1].SetActive(false); autoDamageIcons[1].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public static int skillTreeAutoDamage3ChestSpawn;

    public void BuyAutoDamage3()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= autoDamage3Price && autoDamage2Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.loungerUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= autoDamage3Price;
            autoDamage3Bought = 1;
            skillTreePassiveDamage += 4f;
            SetAlpha(autoDamageUpgrades[2], alphaValueFull);
            autoDamageLocks[2].SetActive(false); autoDamageIcons[2].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public static int skillTreeAutoDamage4TreasureDrop;

    public void BuyAutoDamage4()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= autoDamage4Price && autoDamage3Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.loungerUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= autoDamage4Price;
            autoDamage4Bought = 1;
            skillTreePassiveDamage += 8.5f;
            SetAlpha(autoDamageUpgrades[3], alphaValueFull);
            autoDamageLocks[3].SetActive(false); autoDamageIcons[3].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyAutoDamage5()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= autoDamage5Price && autoDamage4Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.loungerUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= autoDamage5Price;
            autoDamage5Bought = 1;
            skillTreePassiveDamage += 11f;
            SetAlpha(autoDamageUpgrades[4], alphaValueFull);
            autoDamageLocks[4].SetActive(false); autoDamageIcons[4].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public static float skillTreeAuto6DoubleXP;
    public static int skillTreeAuto6ChestDrops;

    public void BuyAutoDamage6()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= autoDamage6Price && autoDamage5Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.loungerUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= autoDamage6Price;
            autoDamage6Bought = 1;
            skillTreeAuto6DoubleXP = 1;
            skillTreePassiveDamage += 16f;
            SetAlpha(autoDamageUpgrades[5], alphaValueFull);
            autoDamageLocks[5].SetActive(false); autoDamageIcons[5].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyAutoDamage7()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= autoDamage7Price && autoDamage6Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.loungerUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= autoDamage7Price;
            autoDamage7Bought = 1;
            skillTreePassiveDamage += 35f;
            SetAlpha(autoDamageUpgrades[6], alphaValueFull);
            autoDamageLocks[6].SetActive(false); autoDamageIcons[6].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyAutoDamage8()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= autoDamage8Price && autoDamage7Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.loungerUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= autoDamage8Price;
            autoDamage8Bought = 1;
            skillTreePassiveDamage += 65f;
            SetAlpha(autoDamageUpgrades[7], alphaValueFull);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    #endregion

    #region autoCursorBranch

    public Image[] autoCursorUpgrades = new Image[4];
    public GameObject[] autoCursorLocks = new GameObject[3];
    public GameObject[] autoCursorsIcons = new GameObject[3];
    public static int autoCursor1Price, autoCursor2Price, autoCursor3Price, autoCursor4Price, autoCursor5Price;
    public static int autoCursor1Bought, autoCursor2Bought, autoCursor3Bought, autoCursor4Bought, autoCursor5Bought;

    public void BuyAutoCursor1()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= autoCursor1Price)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.loungerUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= autoCursor1Price;
            autoCursor1Bought = 1;

            #region passiveDamageCursors

            //Cursor1
            ClickPower.cursor2PassiveBuffIncrement += 0.01f;

            //Cursor4
            ClickPower.cursor4PassiveDamageIncrement += 0.02f;

            //Cursor6
            ClickPower.cursor6PassiveDamageIncrement += 0.03f;

            //Cursor8
            ClickPower.cursor8PassiveDamageIncrement += 0.1f;

            //Cursor9
            ClickPower.cursor9PassiveDamageIncrement += 0.1f;

            //Cursor10
            ClickPower.cursor10PassiveDamageIncrement += 0.3f;

            //Cursor12
            ClickPower.cursor12PassiveDamageIncrement += 0.3f;

            //Cursor13
            ClickPower.cursor13PassiveDamageIncrement += 0.3f;

            //Cursor14
            ClickPower.cursor14PassiveDamageIncrement += 0.4f;

            //Cursor15
            ClickPower.cursor15PassiveDamageIncrement += 0.5f;

            //Cursor16
            ClickPower.cursor16PassiveDamageIncrement += 0.5f;

            //Cursor17
            ClickPower.cursor17PassiveDamageIncrement += 0.6f;

            //Cursor18
            ClickPower.cursor18PassiveDamageIncrement += 0.6f;

            #endregion

            SetAlpha(autoCursorUpgrades[0], alphaValueFull);
            autoCursorLocks[0].SetActive(false); autoCursorsIcons[0].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }
    public void BuyAutoCursor2()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= autoCursor2Price && autoCursor1Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.loungerUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= autoCursor2Price;
            autoCursor2Bought = 1;

            #region passiveDamageCursors
            //Cursor1
            ClickPower.cursor2PassiveBuffIncrement += 0.02f;

            //Cursor4
            ClickPower.cursor4PassiveDamageIncrement += 0.03f;

            //Cursor6
            ClickPower.cursor6PassiveDamageIncrement += 0.03f;

            //Cursor8
            ClickPower.cursor8PassiveDamageIncrement += 0.2f;

            //Cursor9
            ClickPower.cursor9PassiveDamageIncrement += 0.2f;

            //Cursor10
            ClickPower.cursor10PassiveDamageIncrement += 0.3f;

            //Cursor12
            ClickPower.cursor12PassiveDamageIncrement += 0.3f;

            //Cursor13
            ClickPower.cursor13PassiveDamageIncrement += 0.4f;

            //Cursor14
            ClickPower.cursor14PassiveDamageIncrement += 0.5f;

            //Cursor15
            ClickPower.cursor15PassiveDamageIncrement += 0.6f;

            //Cursor16
            ClickPower.cursor16PassiveDamageIncrement += 0.6f;

            //Cursor17
            ClickPower.cursor17PassiveDamageIncrement += 0.7f;

            //Cursor18
            ClickPower.cursor18PassiveDamageIncrement += 0.7f;

            #endregion

            SetAlpha(autoCursorUpgrades[1], alphaValueFull);
            autoCursorLocks[1].SetActive(false); autoCursorsIcons[1].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }
    public void BuyAutoCursor3()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= autoCursor3Price && autoCursor2Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.loungerUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= autoCursor3Price;
            autoCursor3Bought = 1;

            #region strongerCursors
            ClickPower.cursor2PassiveBuff = 0.08f;
       
            ClickPower.cursor4PassiveDamage = 0.15f;

            ClickPower.cursor6PassiveDamage = 0.45f; 

            ClickPower.cursor8PassiveDamage = 0.7f;

            ClickPower.cursor9PassiveDamage = 1.6f;

            ClickPower.cursor10PassiveDamage = 3.0f;

            ClickPower.cursor12PassiveDamage = 3.3f; 

            ClickPower.cursor13PassiveDamage = 5.1f; 

            ClickPower.cursor14PassiveDamage = 7.1f; 

            ClickPower.cursor15PassiveDamage = 11f; 
 
            ClickPower.cursor16PassiveDamage = 11f; 

            ClickPower.cursor17PassiveDamage = 14f; 

            ClickPower.cursor18PassiveDamage = 18.5f;

            #endregion

            SetAlpha(autoCursorUpgrades[2], alphaValueFull);
            autoCursorLocks[2].SetActive(false); autoCursorsIcons[2].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }
    public void BuyAutoCursor4()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= autoCursor4Price && autoCursor3Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.loungerUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= autoCursor4Price;
            autoCursor4Bought = 1;

            #region passiveDamageCursors
            //Cursor1
            ClickPower.cursor2PassiveBuffIncrement += 0.04f;

            //Cursor4
            ClickPower.cursor4PassiveDamageIncrement += 0.05f;

            //Cursor6
            ClickPower.cursor6PassiveDamageIncrement += 0.05f;

            //Cursor8
            ClickPower.cursor8PassiveDamageIncrement += 0.4f;

            //Cursor9
            ClickPower.cursor9PassiveDamageIncrement += 0.4f;

            //Cursor10
            ClickPower.cursor10PassiveDamageIncrement += 0.5f;

            //Cursor12
            ClickPower.cursor12PassiveDamageIncrement += 0.5f;

            //Cursor13
            ClickPower.cursor13PassiveDamageIncrement += 0.6f;

            //Cursor14
            ClickPower.cursor14PassiveDamageIncrement += 0.7f;

            //Cursor15
            ClickPower.cursor15PassiveDamageIncrement += 0.8f;

            //Cursor16
            ClickPower.cursor16PassiveDamageIncrement += 0.8f;

            //Cursor17
            ClickPower.cursor17PassiveDamageIncrement += 0.9f;

            //Cursor18
            ClickPower.cursor18PassiveDamageIncrement += 0.9f;
            #endregion
            //Debug.Log("1");
            #region strongerCursors
            ClickPower.cursor2PassiveBuff = 0.12f;

            ClickPower.cursor4PassiveDamage = 0.27f;

            ClickPower.cursor6PassiveDamage = 0.67f;

            ClickPower.cursor8PassiveDamage = 0.9f;

            ClickPower.cursor9PassiveDamage = 2.4f;

            ClickPower.cursor10PassiveDamage = 5.0f;

            ClickPower.cursor12PassiveDamage = 4.6f;

            ClickPower.cursor13PassiveDamage = 7f;

            ClickPower.cursor14PassiveDamage = 9f;

            ClickPower.cursor15PassiveDamage = 13f;

            ClickPower.cursor16PassiveDamage = 14f;

            ClickPower.cursor17PassiveDamage = 19f;

            ClickPower.cursor18PassiveDamage = 25f;
            #endregion

            SetAlpha(autoCursorUpgrades[3], alphaValueFull);
            autoCursorLocks[3].SetActive(false); autoCursorsIcons[3].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyAutoCursor5()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= autoCursor5Price && autoCursor4Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.loungerUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= autoCursor5Price;
            autoCursor5Bought = 1;

            #region passiveDamageCursors
            //Cursor1
            ClickPower.cursor2PassiveBuffIncrement += 0.06f;

            //Cursor4
            ClickPower.cursor4PassiveDamageIncrement += 0.07f;

            //Cursor6
            ClickPower.cursor6PassiveDamageIncrement += 0.08f;

            //Cursor8
            ClickPower.cursor8PassiveDamageIncrement += 0.9f;

            //Cursor9
            ClickPower.cursor9PassiveDamageIncrement += 0.9f;

            //Cursor10
            ClickPower.cursor10PassiveDamageIncrement += 1f;

            //Cursor12
            ClickPower.cursor12PassiveDamageIncrement += 1f;

            //Cursor13
            ClickPower.cursor13PassiveDamageIncrement += 1.1f;

            //Cursor14
            ClickPower.cursor14PassiveDamageIncrement += 1.2f;

            //Cursor15
            ClickPower.cursor15PassiveDamageIncrement += 1.3f;

            //Cursor16
            ClickPower.cursor16PassiveDamageIncrement += 1.4f;

            //Cursor17
            ClickPower.cursor17PassiveDamageIncrement += 1.5f;

            //Cursor18
            ClickPower.cursor18PassiveDamageIncrement += 1.6f;
            #endregion

            #region strongerCursors
            ClickPower.cursor2PassiveBuff = 0.20f;

            ClickPower.cursor4PassiveDamage = 0.35f;

            ClickPower.cursor6PassiveDamage = 0.80f;

            ClickPower.cursor8PassiveDamage = 1.3f;

            ClickPower.cursor9PassiveDamage = 3f;

            ClickPower.cursor10PassiveDamage = 6.5f;

            ClickPower.cursor12PassiveDamage = 7f;

            ClickPower.cursor13PassiveDamage = 8f;

            ClickPower.cursor14PassiveDamage = 10f;

            ClickPower.cursor15PassiveDamage = 15f;

            ClickPower.cursor16PassiveDamage = 16f;

            ClickPower.cursor17PassiveDamage = 23f;

            ClickPower.cursor18PassiveDamage = 30f;
            #endregion

            SetAlpha(autoCursorUpgrades[4], alphaValueFull);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    #endregion


    #region goldBrach
    public Image[] goldUpgrades = new Image[7];
    public GameObject[] goldLockes = new GameObject[6];
    public GameObject[] goldIcons = new GameObject[6];
    public static int gold1Price, gold2Price, gold3Price, gold4Price, gold5Price, gold6Price, gold7Price, gold8Price, gold9Price;
    public static int gold1Bought, gold2Bought, gold3Bought, gold4Bought, gold5Bought, gold6Bought, gold7Bought, gold8Bought, gold9Bought;

    public void BuyGold1()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= gold1Price)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.pirateUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= gold1Price;
            gold1Bought = 1;
            skillTreeGold += 0.30f;
            SetAlpha(goldUpgrades[0], alphaValueFull);
            goldLockes[0].SetActive(false); goldIcons[0].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }
    public void BuyGold2()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= gold2Price && gold1Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.pirateUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= gold2Price;
            gold2Bought = 1;
            skillTreeGold += 1.2f;
            SetAlpha(goldUpgrades[1], alphaValueFull);
            goldLockes[1].SetActive(false); goldIcons[1].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }
    public void BuyGold3()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= gold3Price && gold2Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.pirateUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= gold3Price;
            gold3Bought = 1;
            skillTreeGold += 5f;
            SetAlpha(goldUpgrades[2], alphaValueFull);
            goldLockes[2].SetActive(false); goldIcons[2].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }
    public void BuyGold4()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= gold4Price && gold3Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.pirateUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= gold4Price;
            gold4Bought = 1;
            skillTreeGold += 10f;
            SetAlpha(goldUpgrades[3], alphaValueFull);
            goldLockes[3].SetActive(false); goldIcons[3].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }
    public void BuyGold5()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= gold5Price && gold4Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.pirateUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= gold5Price;
            gold5Bought = 1;
            SetAlpha(goldUpgrades[4], alphaValueFull);
            goldLockes[4].SetActive(false); goldIcons[4].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }
    public void BuyGold6()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= gold6Price && gold5Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.pirateUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= gold6Price;
            gold6Bought = 1;
            skillTreeGold += 20f;
            SetAlpha(goldUpgrades[5], alphaValueFull);
            goldLockes[5].SetActive(false); goldIcons[5].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }
    public void BuyGold7()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= gold7Price && gold6Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.pirateUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= gold7Price;
            gold7Bought = 1;
            skillTreeGold += 12.5f;
            SetAlpha(goldUpgrades[6], alphaValueFull);
            goldLockes[6].SetActive(false); goldIcons[6].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyGold8()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= gold8Price && gold7Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.pirateUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= gold8Price;
            gold8Bought = 1;
            skillTreeGold += 40f;
            SetAlpha(goldUpgrades[7], alphaValueFull);
            goldLockes[7].SetActive(false); goldIcons[7].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyGold9()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= gold9Price && gold8Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.pirateUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= gold9Price;
            gold9Bought = 1;
            skillTreeGold += 50f;
            SetAlpha(goldUpgrades[8], alphaValueFull);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    #endregion

    #region treasureBranch
    public Image[] dropsUpgrades = new Image[6];
    public GameObject[] dropsLockes = new GameObject[5];
    public GameObject[] dropsIcons = new GameObject[5];
    public static int drops1Price, drops2Price, drops3Price, drops4Price, drops5Price, drops6Price, drops7Price;
    public static int drops1Bought, drops2Bought, drops3Bought, drops4Bought, drops5Bought, drops6Bought, drops7Bought;
    public static int soldTreasureBuff;
    public void BuyDrops1()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= drops1Price)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.pirateUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= drops1Price;
            drops1Bought = 1;

            #region treasures
            Stats.treasureDropChanceIncrease += 0.1f;

            SpawnRewards.quartzBaseChance += 0.1f;
            SpawnRewards.amethystBaseChance += 0.1f;
            SpawnRewards.yellowTopacBaseChance += 0.1f;
            SpawnRewards.albiteBaseChance += 0.1f;
            SpawnRewards.redGarnetBaseChance += 0.1f;
            SpawnRewards.aquamarineBaseChance += 0.1f;
            SpawnRewards.yellowSapphireBaseChance += 0.1f;
            SpawnRewards.pinkTourmalineBaseChance += 0.1f;
            SpawnRewards.adventurineBaseChance += 0.1f;
            SpawnRewards.redGemCBaseChance += 0.1f;
            SpawnRewards.diamondBaseChance += 0.1f;
            SpawnRewards.grandidieriteBaseChance += 0.1f;
            SpawnRewards.violetBaseChance += 0.1f;
            SpawnRewards.akoyaPearlBaseChance += 0.1f;
            SpawnRewards.purpleRupeeBaseChance += 0.1f;
            SpawnRewards.emeraldDropBaseChance += 0.1f;
            SpawnRewards.greenDiamondBaseChance += 0.1f;
            SpawnRewards.fireOpalBaseChance += 0.1f;
            SpawnRewards.gemSilicaBaseChance += 0.1f;
            SpawnRewards.pinkPlortBaseChance += 0.1f;
            SpawnRewards.goldenSeaPearlBaseChance += 0.1f;
            SpawnRewards.kyaniteBaseChance += 0.1f;
            SpawnRewards.blackOpalBaseChance += 0.1f;
            SpawnRewards.painiteBaseChance += 0.1f;
            SpawnRewards.tanzaniteBaseChance += 0.1f;

            //SpawnRewards.astraliumBaseChance += 0.1f;
            //SpawnRewards.elysiumPrismBaseChance += 0.1f;
            //SpawnRewards.aerthfireOpalBaseChance += 0.1f;
            //SpawnRewards.eldrichStarStoneBaseChance += 0.1f;
            //SpawnRewards.chronolithChardBaseChance += 0.1f;
            //SpawnRewards.sideriumEssenceBaseChance += 0.1f;
            //SpawnRewards.quasariteBaseChance += 0.1f;
            //SpawnRewards.radiantNovaStoneBaseChance += 0.1f;
            //SpawnRewards.soluniumShardBaseChance += 0.1f;
            #endregion

            SetAlpha(dropsUpgrades[0], alphaValueFull);
            dropsLockes[0].SetActive(false); dropsIcons[0].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyDrops2()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= drops2Price && drops1Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.pirateUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= drops2Price;
            drops2Bought = 1;

            #region treasures

            Stats.treasureDropChanceIncrease += 0.2f;

            SpawnRewards.quartzBaseChance += 0.2f;
            SpawnRewards.amethystBaseChance += 0.2f;
            SpawnRewards.yellowTopacBaseChance += 0.2f;
            SpawnRewards.albiteBaseChance += 0.2f;
            SpawnRewards.redGarnetBaseChance += 0.2f;
            SpawnRewards.aquamarineBaseChance += 0.2f;
            SpawnRewards.yellowSapphireBaseChance += 0.2f;
            SpawnRewards.pinkTourmalineBaseChance += 0.2f;
            SpawnRewards.adventurineBaseChance += 0.2f;
            SpawnRewards.redGemCBaseChance += 0.2f;
            SpawnRewards.diamondBaseChance += 0.2f;
            SpawnRewards.grandidieriteBaseChance += 0.2f;
            SpawnRewards.violetBaseChance += 0.2f;
            SpawnRewards.akoyaPearlBaseChance += 0.2f;
            SpawnRewards.purpleRupeeBaseChance += 0.2f;
            SpawnRewards.emeraldDropBaseChance += 0.2f;
            SpawnRewards.greenDiamondBaseChance += 0.2f;
            SpawnRewards.fireOpalBaseChance += 0.2f;
            SpawnRewards.gemSilicaBaseChance += 0.2f;
            SpawnRewards.pinkPlortBaseChance += 0.2f;
            SpawnRewards.goldenSeaPearlBaseChance += 0.2f;
            SpawnRewards.kyaniteBaseChance += 0.2f;
            SpawnRewards.blackOpalBaseChance += 0.2f;
            SpawnRewards.painiteBaseChance += 0.2f;
            SpawnRewards.tanzaniteBaseChance += 0.2f;

     
            #endregion

            SetAlpha(dropsUpgrades[1], alphaValueFull);
            dropsLockes[1].SetActive(false); dropsIcons[1].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyDrops3()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= drops3Price && drops2Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.pirateUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= drops3Price;
            drops3Bought = 1;

            SpawnRewards.doubleRareDropChance += 8;
            SpawnRewards.changeDropChanceValues = true;

            SetAlpha(dropsUpgrades[2], alphaValueFull);
            dropsLockes[2].SetActive(false); dropsIcons[2].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyDrops4()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= drops4Price && drops3Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.pirateUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= drops4Price;
            drops4Bought = 1;

            #region treasures
            Stats.treasureDropChanceIncrease += 0.2f;

            SpawnRewards.quartzBaseChance += 0.2f;
            SpawnRewards.amethystBaseChance += 0.2f;
            SpawnRewards.yellowTopacBaseChance += 0.2f;
            SpawnRewards.albiteBaseChance += 0.2f;
            SpawnRewards.redGarnetBaseChance += 0.2f;
            SpawnRewards.aquamarineBaseChance += 0.2f;
            SpawnRewards.yellowSapphireBaseChance += 0.2f;
            SpawnRewards.pinkTourmalineBaseChance += 0.2f;
            SpawnRewards.adventurineBaseChance += 0.2f;
            SpawnRewards.redGemCBaseChance += 0.2f;
            SpawnRewards.diamondBaseChance += 0.2f;
            SpawnRewards.grandidieriteBaseChance += 0.2f;
            SpawnRewards.violetBaseChance += 0.2f;
            SpawnRewards.akoyaPearlBaseChance += 0.2f;
            SpawnRewards.purpleRupeeBaseChance += 0.2f;
            SpawnRewards.emeraldDropBaseChance += 0.2f;
            SpawnRewards.greenDiamondBaseChance += 0.2f;
            SpawnRewards.fireOpalBaseChance += 0.2f;
            SpawnRewards.gemSilicaBaseChance += 0.2f;
            SpawnRewards.pinkPlortBaseChance += 0.2f;
            SpawnRewards.goldenSeaPearlBaseChance += 0.2f;
            SpawnRewards.kyaniteBaseChance += 0.2f;
            SpawnRewards.blackOpalBaseChance += 0.2f;
            SpawnRewards.painiteBaseChance += 0.2f;
            SpawnRewards.tanzaniteBaseChance += 0.2f;

            #endregion

            SpawnRewards.doubleRareDropChance += 5;
            SpawnRewards.changeDropChanceValues = true;

            SetAlpha(dropsUpgrades[3], alphaValueFull);
            dropsLockes[3].SetActive(false); dropsIcons[3].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyDrops5()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= drops5Price && drops4Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.pirateUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= drops5Price;
            drops5Bought = 1;

            #region treasures
            Stats.treasureDropChanceIncrease += 0.2f;

            SpawnRewards.quartzBaseChance += 0.2f;
            SpawnRewards.amethystBaseChance += 0.2f;
            SpawnRewards.yellowTopacBaseChance += 0.2f;
            SpawnRewards.albiteBaseChance += 0.2f;
            SpawnRewards.redGarnetBaseChance += 0.2f;
            SpawnRewards.aquamarineBaseChance += 0.2f;
            SpawnRewards.yellowSapphireBaseChance += 0.2f;
            SpawnRewards.pinkTourmalineBaseChance += 0.2f;
            SpawnRewards.adventurineBaseChance += 0.2f;
            SpawnRewards.redGemCBaseChance += 0.2f;
            SpawnRewards.diamondBaseChance += 0.2f;
            SpawnRewards.grandidieriteBaseChance += 0.2f;
            SpawnRewards.violetBaseChance += 0.2f;
            SpawnRewards.akoyaPearlBaseChance += 0.2f;
            SpawnRewards.purpleRupeeBaseChance += 0.2f;
            SpawnRewards.emeraldDropBaseChance += 0.2f;
            SpawnRewards.greenDiamondBaseChance += 0.2f;
            SpawnRewards.fireOpalBaseChance += 0.2f;
            SpawnRewards.gemSilicaBaseChance += 0.2f;
            SpawnRewards.pinkPlortBaseChance += 0.2f;
            SpawnRewards.goldenSeaPearlBaseChance += 0.2f;
            SpawnRewards.kyaniteBaseChance += 0.2f;
            SpawnRewards.blackOpalBaseChance += 0.2f;
            SpawnRewards.painiteBaseChance += 0.2f;
            SpawnRewards.tanzaniteBaseChance += 0.2f;

            #endregion
            SpawnRewards.doubleRareDropChance += 10;
            SpawnRewards.changeDropChanceValues = true;

            SetAlpha(dropsUpgrades[4], alphaValueFull);
            dropsLockes[4].SetActive(false); dropsIcons[4].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public static float skillTreeTreasure6TreasureBag;

    public void BuyDrops6()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= drops6Price && drops5Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.pirateUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= drops6Price;
            drops6Bought = 1;

            SpawnRewards.doubleRareDropChance += 13;
            SpawnRewards.changeDropChanceValues = true;
            skillTreeTreasure6TreasureBag = 1f;

            SetAlpha(dropsUpgrades[5], alphaValueFull);
            dropsLockes[5].SetActive(false); dropsIcons[5].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyDrops7()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= drops7Price && drops6Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.pirateUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= drops7Price;
            drops7Bought = 1;

            SpawnRewards.changeDropChanceValues = true;

            #region treasures
            Stats.treasureDropChanceIncrease += 0.4f;

            SpawnRewards.quartzBaseChance += 0.4f;
            SpawnRewards.amethystBaseChance += 0.4f;
            SpawnRewards.yellowTopacBaseChance += 0.4f;
            SpawnRewards.albiteBaseChance += 0.4f;
            SpawnRewards.redGarnetBaseChance += 0.4f;
            SpawnRewards.aquamarineBaseChance += 0.4f;
            SpawnRewards.yellowSapphireBaseChance += 0.4f;
            SpawnRewards.pinkTourmalineBaseChance += 0.4f;
            SpawnRewards.adventurineBaseChance += 0.4f;
            SpawnRewards.redGemCBaseChance += 0.4f;
            SpawnRewards.diamondBaseChance += 0.4f;
            SpawnRewards.grandidieriteBaseChance += 0.4f;
            SpawnRewards.violetBaseChance += 0.4f;
            SpawnRewards.akoyaPearlBaseChance += 0.4f;
            SpawnRewards.purpleRupeeBaseChance += 0.4f;
            SpawnRewards.emeraldDropBaseChance += 0.4f;
            SpawnRewards.greenDiamondBaseChance += 0.4f;
            SpawnRewards.fireOpalBaseChance += 0.4f;
            SpawnRewards.gemSilicaBaseChance += 0.4f;
            SpawnRewards.pinkPlortBaseChance += 0.4f;
            SpawnRewards.goldenSeaPearlBaseChance += 0.4f;
            SpawnRewards.kyaniteBaseChance += 0.4f;
            SpawnRewards.blackOpalBaseChance += 0.4f;
            SpawnRewards.painiteBaseChance += 0.4f;
            SpawnRewards.tanzaniteBaseChance += 0.4f;

            #endregion

            soldTreasureBuff = 5;

            SetAlpha(dropsUpgrades[6], alphaValueFull);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }
    #endregion

    #region xpBranch
    public Image[] xpUpgrades = new Image[6];
    public GameObject[] xpLockes = new GameObject[5];
    public GameObject[] xpIcons = new GameObject[5];
    public static int xp1Price, xp2Price, xp3Price, xp4Price, xp5Price, xp6Price, xp7Price, xp8Price;
    public static int xp1Bought, xp2Bought, xp3Bought, xp4Bought, xp5Bought, xp6Bought, xp7Bought, xp8Bought;

    public void BuyXP1()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= xp1Price)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.pirateUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= xp1Price;
            xp1Bought = 1;
            skillTreeXP += 0.35f;
            SetAlpha(xpUpgrades[0], alphaValueFull);
            xpLockes[0].SetActive(false); xpIcons[0].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyXP2()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= xp2Price && xp1Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.pirateUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= xp2Price;
            xp2Bought = 1;
            skillTreeXP += 1.25f;
            SetAlpha(xpUpgrades[1], alphaValueFull);
            xpLockes[1].SetActive(false); xpIcons[1].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyXP3()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= xp3Price && xp2Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.pirateUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= xp3Price;
            xp3Bought = 1;
            skillTreeXP += 4f;
            SetAlpha(xpUpgrades[2], alphaValueFull);
            xpLockes[2].SetActive(false); xpIcons[2].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyXP4()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= xp4Price && xp3Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.pirateUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= xp4Price;
            xp4Bought = 1;
            skillTreeXP += 9f;
            SetAlpha(xpUpgrades[3], alphaValueFull);
            xpLockes[3].SetActive(false); xpIcons[3].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyXP5()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= xp5Price && xp4Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.pirateUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= xp5Price;
            xp5Bought = 1;
            skillTreeXP += 13f;
            SetAlpha(xpUpgrades[4], alphaValueFull);
            xpLockes[4].SetActive(false); xpIcons[4].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyXP6()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= xp6Price && xp5Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.pirateUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= xp6Price;
            xp6Bought = 1;
            skillTreeXP += 25f;
            SetAlpha(xpUpgrades[5], alphaValueFull);
            xpLockes[5].SetActive(false); xpIcons[5].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyXP7()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= xp7Price && xp6Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.pirateUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= xp7Price;
            xp7Bought = 1;
            skillTreeXP += 40f;
            SetAlpha(xpUpgrades[6], alphaValueFull);
            xpLockes[6].SetActive(false); xpIcons[6].SetActive(true);

            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyXP8()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= xp8Price && xp7Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.pirateUpgradesPurchased += 1;
            PlayerLevel.skillPoints -= xp8Price;
            xp8Bought = 1;
            skillTreeXP += 75f;
            SetAlpha(xpUpgrades[7], alphaValueFull);

            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    #endregion


    #region levelSpecialBranch
    public Image[] levelSpecialUpgrades = new Image[4];
    public GameObject[] levelSpecialLockes = new GameObject[3];
    public GameObject[] levelSpecialIcons = new GameObject[3];
    public static int levelSpecial1Price, levelSpecial2Price, levelSpecial3Price, levelSpecial4Price, levelSpecial5Price;
    public static int levelSpecial1Bought, levelSpecial2Bought, levelSpecial3Bought, levelSpecial4Bought, levelSpecial5Bought;

    public void BuyLevelSpecial1()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= levelSpecial1Price)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.hoarderUpgradeesPurchased += 1;
            PlayerLevel.skillPoints -= levelSpecial1Price;
            levelSpecial1Bought = 1;

            #region specialUpgradesLevelUp
            SpecialUpgradesButtons.lockPickDropChanceIncrement += 0.007f;
            SpecialUpgradesButtons.lockPickOpenChanceIncrement += 1;

            SpecialUpgradesButtons.hammerDropChanceIncrement += 0.004f;
            SpecialUpgradesButtons.hammerDamageAmountIncrement += 0.20f;

            SpecialUpgradesButtons.keyDropChanceIncrement += 0.004f;
            SpecialUpgradesButtons.keyRareDropChanceIncrement += 0.1f;

            SpecialUpgradesButtons.miniChestSpawnTimerMinus += 1;

            SpecialUpgradesButtons.goldenTouchDropChanceIncrement += 0.003f;
            SpecialUpgradesButtons.goldenTouchTimerIncrement += 1f;

            SpecialUpgradesButtons.treasureBagDropChanceIncrement += 0.007f;

            SpecialUpgradesButtons.XPPotionDropChanceIncrement += 0.004f;
            SpecialUpgradesButtons.XPPotionBufFIncrement += 0.03f;

            SpecialUpgradesButtons.damagePotionDropChanceIncrement += 0.004f;
            SpecialUpgradesButtons.damagePotionBuffIncrement += 0.05f;

            SpecialUpgradesButtons.lootPotionDropChanceIncrement += 0.004f;
            SpecialUpgradesButtons.lootPotionBuffIncrement += 0.05f;

            SpecialUpgradesButtons.elixirDropChanceIncrement += 0.002f;
            SpecialUpgradesButtons.elixirBuffIncrement += 0.07f;

            SpecialUpgradesButtons.scrollDropChanceIncrement += 0.001f;

            SpecialUpgradesButtons.gauntletDropChanceIncrement += 0.001f;
            SpecialUpgradesButtons.gauntletGoldDropChanceIncrement += 1f;

            #endregion

            SetAlpha(levelSpecialUpgrades[0], alphaValueFull);
            levelSpecialLockes[0].SetActive(false);
            levelSpecialIcons[0].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyLevelSpecial2()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= levelSpecial2Price && levelSpecial1Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.hoarderUpgradeesPurchased += 1;
            PlayerLevel.skillPoints -= levelSpecial2Price;
            levelSpecial2Bought = 1;

            #region specialUpgradesLevelUp
            SpecialUpgradesButtons.lockPickDropChanceIncrement += 0.01f;
            SpecialUpgradesButtons.lockPickOpenChanceIncrement += 1;

            SpecialUpgradesButtons.hammerDropChanceIncrement += 0.004f;
            SpecialUpgradesButtons.hammerDamageAmountIncrement += 0.32f;

            SpecialUpgradesButtons.keyDropChanceIncrement += 0.004f;
            SpecialUpgradesButtons.keyRareDropChanceIncrement += 0.1f;

            SpecialUpgradesButtons.miniChestSpawnTimerMinus += 1;

            SpecialUpgradesButtons.goldenTouchDropChanceIncrement += 0.003f;

            SpecialUpgradesButtons.treasureBagDropChanceIncrement += 0.008f;

            SpecialUpgradesButtons.XPPotionDropChanceIncrement += 0.004f;
            SpecialUpgradesButtons.XPPotionBufFIncrement += 0.10f;
            SpecialUpgradesButtons.XPPotionTimerMinus += 1;

            SpecialUpgradesButtons.damagePotionDropChanceIncrement += 0.004f;
            SpecialUpgradesButtons.damagePotionBuffIncrement += 0.13f;
            SpecialUpgradesButtons.damagePotionTimerMinus += 1;

            SpecialUpgradesButtons.lootPotionDropChanceIncrement += 0.004f;
            SpecialUpgradesButtons.lootPotionBuffIncrement += 0.13f;
            SpecialUpgradesButtons.lootPotionTimerMinus += 1;

            SpecialUpgradesButtons.elixirDropChanceIncrement += 0.002f;
            SpecialUpgradesButtons.elixirBuffIncrement += 0.15f;
            SpecialUpgradesButtons.elixirTimerIncrement += 1f;

            SpecialUpgradesButtons.gauntletTimerIncrement += 1;
            SpecialUpgradesButtons.gauntletGoldDropChanceIncrement += 1f;

            #endregion

            SetAlpha(levelSpecialUpgrades[1], alphaValueFull);
            levelSpecialLockes[1].SetActive(false);
            levelSpecialIcons[1].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyLevelSpecial3()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= levelSpecial3Price && levelSpecial2Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.hoarderUpgradeesPurchased += 1;
            PlayerLevel.skillPoints -= levelSpecial3Price;
            levelSpecial3Bought = 1;

            #region specialUpgradesLevelUp
            SpecialUpgradesButtons.lockPickDropChanceIncrement += 0.005f;
            SpecialUpgradesButtons.lockPickOpenChanceIncrement += 1;

            SpecialUpgradesButtons.hammerDropChanceIncrement += 0.004f;
            SpecialUpgradesButtons.hammerDamageAmountIncrement += 0.45f;

            SpecialUpgradesButtons.keyRareDropChanceIncrement += 0.2f;

            SpecialUpgradesButtons.goldenTouchDropChanceIncrement += 0.002f;
            SpecialUpgradesButtons.goldenTouchTimerIncrement += 1f;

            SpecialUpgradesButtons.miniChestSpawnTimerMinus += 1;

            SpecialUpgradesButtons.treasureBagDropChanceIncrement += 0.008f;

            SpecialUpgradesButtons.XPPotionDropChanceIncrement += 0.006f;
            SpecialUpgradesButtons.XPPotionBufFIncrement += 0.25f;
            SpecialUpgradesButtons.XPPotionTimerMinus += 1;

            SpecialUpgradesButtons.damagePotionDropChanceIncrement += 0.006f;
            SpecialUpgradesButtons.damagePotionBuffIncrement += 0.30f;
            SpecialUpgradesButtons.damagePotionTimerMinus += 1;

            SpecialUpgradesButtons.lootPotionDropChanceIncrement += 0.006f;
            SpecialUpgradesButtons.lootPotionBuffIncrement += 0.30f;
            SpecialUpgradesButtons.lootPotionTimerMinus += 1;

            SpecialUpgradesButtons.elixirDropChanceIncrement += 0.001f;
            SpecialUpgradesButtons.elixirBuffIncrement += 0.35f;
            SpecialUpgradesButtons.elixirTimerIncrement += 1f;

            SpecialUpgradesButtons.scrollDropChanceIncrement += 0.001f;

            SpecialUpgradesButtons.gauntletDropChanceIncrement += 0.001f;
            SpecialUpgradesButtons.gauntletGoldDropChanceIncrement += 1f;

            SpecialUpgradesButtons.relicDropChanceIncrement += 0.001f;
            #endregion

            SetAlpha(levelSpecialUpgrades[2], alphaValueFull);
            levelSpecialLockes[2].SetActive(false); levelSpecialIcons[2].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyLevelSpecial4()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= levelSpecial4Price && levelSpecial3Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.hoarderUpgradeesPurchased += 1;
            PlayerLevel.skillPoints -= levelSpecial4Price;
            levelSpecial4Bought = 1;

            #region specialUpgradesLevelUp
            SpecialUpgradesButtons.lockPickDropChanceIncrement += 0.007f;
            SpecialUpgradesButtons.lockPickOpenChanceIncrement += 2;

            SpecialUpgradesButtons.hammerDropChanceIncrement += 0.003f;
            SpecialUpgradesButtons.hammerDamageAmountIncrement += 0.5f;

            SpecialUpgradesButtons.keyDropChanceIncrement += 0.003f;
            SpecialUpgradesButtons.keyRareDropChanceIncrement += 0.2f;

            SpecialUpgradesButtons.goldenTouchDropChanceIncrement += 0.001f;
            
            SpecialUpgradesButtons.miniChestSpawnTimerMinus += 1;

            SpecialUpgradesButtons.treasureBagDropChanceIncrement += 0.006f;

            SpecialUpgradesButtons.XPPotionDropChanceIncrement += 0.005f;
            SpecialUpgradesButtons.XPPotionBufFIncrement += 0.50f;
            SpecialUpgradesButtons.XPPotionTimerMinus += 1;

            SpecialUpgradesButtons.damagePotionDropChanceIncrement += 0.005f;
            SpecialUpgradesButtons.damagePotionBuffIncrement += 0.65f;
            SpecialUpgradesButtons.damagePotionTimerMinus += 1;

            SpecialUpgradesButtons.lootPotionDropChanceIncrement += 0.005f;
            SpecialUpgradesButtons.lootPotionBuffIncrement += 0.65f;
            SpecialUpgradesButtons.lootPotionTimerMinus += 1;

            SpecialUpgradesButtons.elixirDropChanceIncrement += 0.001f;
            SpecialUpgradesButtons.elixirBuffIncrement += 0.70f;
            SpecialUpgradesButtons.elixirTimerIncrement += 1f;

            SpecialUpgradesButtons.scrollDropChanceIncrement += 0.002f;
            SpecialUpgradesButtons.scrollTimerIncrement += 1;

            SpecialUpgradesButtons.gauntletDropChanceIncrement += 0.001f;
            SpecialUpgradesButtons.gauntletGoldDropChanceIncrement += 1f;

            SpecialUpgradesButtons.relicDropChanceIncrement += 0.001f;
            #endregion

            SetAlpha(levelSpecialUpgrades[3], alphaValueFull);
            levelSpecialLockes[3].SetActive(false); levelSpecialIcons[3].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyLevelSpecial5()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= levelSpecial5Price && levelSpecial4Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.hoarderUpgradeesPurchased += 1;
            PlayerLevel.skillPoints -= levelSpecial5Price;
            levelSpecial5Bought = 1;

            #region specialUpgradesLevelUp
            SpecialUpgradesButtons.lockPickDropChanceIncrement += 0.010f;
            SpecialUpgradesButtons.lockPickOpenChanceIncrement += 2;

            SpecialUpgradesButtons.hammerDropChanceIncrement += 0.004f;
            SpecialUpgradesButtons.hammerDamageAmountIncrement += 1f;

            SpecialUpgradesButtons.keyDropChanceIncrement += 0.002f;
            SpecialUpgradesButtons.keyRareDropChanceIncrement += 0.3f;

            SpecialUpgradesButtons.goldenTouchDropChanceIncrement += 0.002f;

            SpecialUpgradesButtons.miniChestSpawnTimerMinus += 2;

            SpecialUpgradesButtons.treasureBagDropChanceIncrement += 0.007f;

            SpecialUpgradesButtons.XPPotionDropChanceIncrement += 0.006f;
            SpecialUpgradesButtons.XPPotionBufFIncrement += 0.75f;
            SpecialUpgradesButtons.XPPotionTimerMinus += 1;

            SpecialUpgradesButtons.damagePotionDropChanceIncrement += 0.006f;
            SpecialUpgradesButtons.damagePotionBuffIncrement += 0.80f;
            SpecialUpgradesButtons.damagePotionTimerMinus += 1;

            SpecialUpgradesButtons.lootPotionDropChanceIncrement += 0.006f;
            SpecialUpgradesButtons.lootPotionBuffIncrement += 0.90f;
            SpecialUpgradesButtons.lootPotionTimerMinus += 1;

            SpecialUpgradesButtons.elixirDropChanceIncrement += 0.001f;
            SpecialUpgradesButtons.elixirBuffIncrement += 1f;
            SpecialUpgradesButtons.elixirTimerIncrement += 1f;

            SpecialUpgradesButtons.scrollDropChanceIncrement += 0.001f;
            SpecialUpgradesButtons.scrollTimerIncrement += 1;

            SpecialUpgradesButtons.gauntletDropChanceIncrement += 0.001f;
            SpecialUpgradesButtons.gauntletGoldDropChanceIncrement += 2f;

            SpecialUpgradesButtons.relicDropChanceIncrement += 0.002f;
            #endregion

            SetAlpha(levelSpecialUpgrades[4], alphaValueFull);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    #endregion

    #region strongerSpecialBranch
    public Image[] strongerSpecialUpgrades = new Image[5];
    public GameObject[] strongerSpecialLockes = new GameObject[4];
    public GameObject[] strongerSpecialIcons = new GameObject[4];
    public static int strongerSpecial1Price, strongerSpecial2Price, strongerSpecial3Price, strongerSpecial4Price, strongerSpecial5Price, strongerSpecial6Price, strongerSpecial7Price;
    public static int strongerSpecial1Bought, strongerSpecial2Bought, strongerSpecial3Bought, strongerSpecial4Bought, strongerSpecial5Bought, strongerSpecial6Bought, strongerSpecial7Bought;

    public static int skillTreeLootPotionStack, skillTreeDamagePotionStack, skillTreeXPPotionStack, skillTreeElixirStack;
    public static int skillTreeSpecial4Double;

    public static float special7ScrollTreasure, special7ScrollCritChance, special7ScrollCritDamage, special7ScrollActiveDamage, special7ScrollPassiveDamage, special7ScrollXP, special7ScrollTGOLD;

    public static float special7RelicTreasure, special7RelicCritChance, special7RelicCritDamage, special7RelicActiveDamage, special7RelicPassiveDamage, special7RelicXP, special7RelicTGOLD;

    public void BuyStrongerSpecial1()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= strongerSpecial1Price)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.hoarderUpgradeesPurchased += 1;
            PlayerLevel.skillPoints -= strongerSpecial1Price;
            strongerSpecial1Bought = 1;

            wholeNumberIncrement = 1; twoDecimalNumberIncrement = 0.01f; oneDecimalNumberIncrement = 0.1f;

            SetAlpha(strongerSpecialUpgrades[0], alphaValueFull);
            strongerSpecialLockes[0].SetActive(false);
            strongerSpecialIcons[0].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyStrongerSpecial2()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= strongerSpecial2Price && strongerSpecial1Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.hoarderUpgradeesPurchased += 1;
            PlayerLevel.skillPoints -= strongerSpecial2Price;
            strongerSpecial2Bought = 1;

            wholeNumberIncrement = 2; twoDecimalNumberIncrement = 0.03f; oneDecimalNumberIncrement = 0.3f;

            SetAlpha(strongerSpecialUpgrades[1], alphaValueFull);
            strongerSpecialLockes[1].SetActive(false);
            strongerSpecialIcons[1].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyStrongerSpecial3()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= strongerSpecial3Price && strongerSpecial2Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.hoarderUpgradeesPurchased += 1;
            PlayerLevel.skillPoints -= strongerSpecial3Price;
            strongerSpecial3Bought = 1;
            SetAlpha(strongerSpecialUpgrades[2], alphaValueFull);
            strongerSpecialLockes[2].SetActive(false);
            strongerSpecialIcons[2].SetActive(true);

            skillTreeLootPotionStack = 1; skillTreeDamagePotionStack = 1; skillTreeXPPotionStack = 1; skillTreeElixirStack = 1;
            UseConsumable.potionStack = true;
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyStrongerSpecial4()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= strongerSpecial4Price && strongerSpecial3Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.hoarderUpgradeesPurchased += 1;
            PlayerLevel.skillPoints -= strongerSpecial4Price;
            strongerSpecial4Bought = 1; skillTreeSpecial4Double = 10;
            SetAlpha(strongerSpecialUpgrades[3], alphaValueFull);
            strongerSpecialLockes[3].SetActive(false);
            strongerSpecialIcons[3].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyStrongerSpecial5()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= strongerSpecial5Price && strongerSpecial4Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.hoarderUpgradeesPurchased += 1;
            PlayerLevel.skillPoints -= strongerSpecial5Price;
            strongerSpecial5Bought = 1;

            wholeNumberIncrement = 4; twoDecimalNumberIncrement = 0.05f; oneDecimalNumberIncrement = 0.5f;

            skillTreeLootPotionStack = 2; skillTreeDamagePotionStack = 2; skillTreeXPPotionStack = 2; skillTreeElixirStack = 2;
            UseConsumable.potionStack = true;

            SetAlpha(strongerSpecialUpgrades[4], alphaValueFull);
            strongerSpecialLockes[4].SetActive(false);
            strongerSpecialIcons[4].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyStrongerSpecial6()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= strongerSpecial6Price && strongerSpecial5Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.hoarderUpgradeesPurchased += 1;
            PlayerLevel.skillPoints -= strongerSpecial6Price;
            strongerSpecial6Bought = 1;
            UseConsumable.potionStack = true;

            SetAlpha(strongerSpecialUpgrades[5], alphaValueFull);
            strongerSpecialLockes[5].SetActive(false);
            strongerSpecialIcons[5].SetActive(true);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }


    public void BuyStrongerSpecial7()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= strongerSpecial7Price && strongerSpecial6Bought == 1)
        {
            Stats.prestigeUpgradesPurchased += 1;
            Stats.hoarderUpgradeesPurchased += 1;
            PlayerLevel.skillPoints -= strongerSpecial7Price;
            strongerSpecial7Bought = 1;

            SetAlpha(strongerSpecialUpgrades[6], alphaValueFull);
            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    #endregion

    #region startWithItemBranch

    public Image[] startWithItemUpgrades = new Image[4];
    public GameObject[] startWithItemLockes = new GameObject[3];
    public GameObject[] startWithItemIcons = new GameObject[3];
    public static int startWithItem1Price, startWithItem2Price, startWithItem3Price, startWithItem4Price;
    public static int startWithItem1Bought, startWithItem2Bought, startWithItem3Bought, startWithItem4Bought;
    public static int startWithItemCount;

    public void BuyStartWithItem1()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= startWithItem1Price)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.hoarderUpgradeesPurchased += 1;
            PlayerLevel.skillPoints -= startWithItem1Price;
            startWithItem1Bought = 1;
            SetAlpha(startWithItemUpgrades[0], alphaValueFull);
            startWithItemLockes[0].SetActive(false);
            startWithItemIcons[0].SetActive(true);

            startWithItemCount = 1;

            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyStartWithItem2()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= startWithItem2Price && startWithItem1Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.hoarderUpgradeesPurchased += 1;
            PlayerLevel.skillPoints -= startWithItem2Price;
            startWithItem2Bought = 1;
            SetAlpha(startWithItemUpgrades[1], alphaValueFull);
            startWithItemLockes[1].SetActive(false);
            startWithItemIcons[1].SetActive(true);

            startWithItemCount = 2;

            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyStartWithItem3()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= startWithItem3Price && startWithItem2Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.hoarderUpgradeesPurchased += 1;
            PlayerLevel.skillPoints -= startWithItem3Price;
            startWithItem3Bought = 1;
            SetAlpha(startWithItemUpgrades[2], alphaValueFull);
            startWithItemLockes[2].SetActive(false);
            startWithItemIcons[2].SetActive(true);

            startWithItemCount = 3;

            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    public void BuyStartWithItem4()
    {
        if (isInSkillTree == true && PlayerLevel.skillPoints >= startWithItem4Price && startWithItem3Bought == 1)
        {
            if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isPrestigeTooltipOpen == false) { return; }
            Stats.prestigeUpgradesPurchased += 1;
            Stats.hoarderUpgradeesPurchased += 1;
            PlayerLevel.skillPoints -= startWithItem4Price;
            startWithItem4Bought = 1;
            SetAlpha(startWithItemUpgrades[3], alphaValueFull);

            startWithItemCount = 5;

            SomethingAllUpgradesDo();
        }
        else { NotEnoughPoints(); }
    }

    #endregion


    #region something all upgrads do
    public Button[] critButtons = new Button[5];
    public Button[] activeButtons = new Button[6];
    public Button[] activeCursorsButtons = new Button[4];
    public Button[] autoClickerButtons = new Button[4];
    public Button[] passiveButtons = new Button[7];
    public Button[] passiveCursorButtons = new Button[4];
    public Button[] goldButtons = new Button[7];
    public Button[] dropsButtons = new Button[6];
    public Button[] XPButtons = new Button[6];
    public Button[] levelUpSpecialButtons = new Button[4];
    public Button[] strongerSpecialButtons = new Button[5];
    public Button[] startWithButtons = new Button[4];

    public string basicHexValue = "FFFFFF";
    public string clickerHexValue = "#FFCBC5";
    public string loungerHexValue = "#CAFFC5";
    public string pirateHexValue = "#FFF773";
    public string hoarderHexValue = "#70B7FF";

    public bool playSound;

    public void SomethingAllUpgradesDo()
    {
        if(playSound == true) 
        {
            int random = Random.Range(1, 4);
            if (random == 1) { if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("LevelUp"); } }
            if (random == 2) { if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("LevelUp2"); } }
            if (random == 3) { if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("LevelUp3"); } }
        }

        Color newColorCicker;
        ColorUtility.TryParseHtmlString(clickerHexValue, out newColorCicker);

        #region crit
        if (crit1Bought == 1) { critButtons[0].interactable = false; SetAlpha(critUpgrade[0], alphaValueFull); critUpgrade[0].GetComponent<Image>().color = newColorCicker; } 
        if (crit2Bought == 1) { critButtons[1].interactable = false; SetAlpha(critUpgrade[1], alphaValueFull); critUpgrade[1].GetComponent<Image>().color = newColorCicker; }
        if (crit3Bought == 1) { critButtons[2].interactable = false; SetAlpha(critUpgrade[2], alphaValueFull); critUpgrade[2].GetComponent<Image>().color = newColorCicker; }
        if (crit4Bought == 1) { critButtons[3].interactable = false; SetAlpha(critUpgrade[3], alphaValueFull); critUpgrade[3].GetComponent<Image>().color = newColorCicker; }
        if (crit5Bought == 1) { critButtons[4].interactable = false; SetAlpha(critUpgrade[4], alphaValueFull); critUpgrade[4].GetComponent<Image>().color = newColorCicker; }
        #endregion

        #region active

        if (active1Bought == 1) { activeButtons[0].interactable = false; SetAlpha(activeDamageUpgrade[0], alphaValueFull); activeDamageUpgrade[0].GetComponent<Image>().color = newColorCicker; }
        if (active2Bought == 1) { activeButtons[1].interactable = false; SetAlpha(activeDamageUpgrade[1], alphaValueFull); activeDamageUpgrade[1].GetComponent<Image>().color = newColorCicker; }
        if (active3Bought == 1) { activeButtons[2].interactable = false; SetAlpha(activeDamageUpgrade[2], alphaValueFull); activeDamageUpgrade[2].GetComponent<Image>().color = newColorCicker; }
        if (active4Bought == 1) { activeButtons[3].interactable = false; SetAlpha(activeDamageUpgrade[3], alphaValueFull); activeDamageUpgrade[3].GetComponent<Image>().color = newColorCicker; }
        if (active5Bought == 1) { activeButtons[4].interactable = false; SetAlpha(activeDamageUpgrade[4], alphaValueFull); activeDamageUpgrade[4].GetComponent<Image>().color = newColorCicker; }
        if (active6Bought == 1) { activeButtons[5].interactable = false; SetAlpha(activeDamageUpgrade[5], alphaValueFull); activeDamageUpgrade[5].GetComponent<Image>().color = newColorCicker; }
        if (active7Bought == 1) { activeButtons[6].interactable = false; SetAlpha(activeDamageUpgrade[6], alphaValueFull); activeDamageUpgrade[6].GetComponent<Image>().color = newColorCicker; }
        #endregion

        #region activeCursor
        if (activeCursor1Bought == 1) { activeCursorsButtons[0].interactable = false; SetAlpha(activeCursorUpgrades[0], alphaValueFull); activeCursorUpgrades[0].GetComponent<Image>().color = newColorCicker; }
        if (activeCursor2Bought == 1) { activeCursorsButtons[1].interactable = false; SetAlpha(activeCursorUpgrades[1], alphaValueFull); activeCursorUpgrades[1].GetComponent<Image>().color = newColorCicker; }
        if (activeCursor3Bought == 1) { activeCursorsButtons[2].interactable = false; SetAlpha(activeCursorUpgrades[2], alphaValueFull); activeCursorUpgrades[2].GetComponent<Image>().color = newColorCicker; }
        if (activeCursor4Bought == 1) { activeCursorsButtons[3].interactable = false; SetAlpha(activeCursorUpgrades[3], alphaValueFull); activeCursorUpgrades[3].GetComponent<Image>().color = newColorCicker; }
        #endregion

        Color newColorLounger;
        ColorUtility.TryParseHtmlString(loungerHexValue, out newColorLounger);

        #region autoClicker
        if (autoClicker1Bought == 1) { autoClickerButtons[0].interactable = false; autoClickerUnlocked[0].SetActive(true); SetAlpha(autoClickerUpgrades[0], alphaValueFull); autoClickerUpgrades[0].GetComponent<Image>().color = newColorLounger; }
        if (autoClicker2Bought == 1) { autoClickerButtons[1].interactable = false; autoClickerUnlocked[1].SetActive(true); SetAlpha(autoClickerUpgrades[1], alphaValueFull); autoClickerUpgrades[1].GetComponent<Image>().color = newColorLounger; }
        if (autoClicker3Bought == 1) { autoClickerButtons[2].interactable = false; autoClickerUnlocked[2].SetActive(true); SetAlpha(autoClickerUpgrades[2], alphaValueFull); autoClickerUpgrades[2].GetComponent<Image>().color = newColorLounger; }
        if (autoClicker4Bought == 1) { autoClickerButtons[3].interactable = false; autoClickerUnlocked[3].SetActive(true); SetAlpha(autoClickerUpgrades[3], alphaValueFull); autoClickerUpgrades[3].GetComponent<Image>().color = newColorLounger; }
        #endregion

        #region autoDamage
        if (autoDamage1Bought == 1) { passiveButtons[0].interactable = false; passiveUnlocked[0].SetActive(true); SetAlpha(autoDamageUpgrades[0], alphaValueFull); autoDamageUpgrades[0].GetComponent<Image>().color = newColorLounger; }
        if (autoDamage2Bought == 1) { passiveButtons[1].interactable = false; passiveUnlocked[1].SetActive(true); SetAlpha(autoDamageUpgrades[1], alphaValueFull); autoDamageUpgrades[1].GetComponent<Image>().color = newColorLounger; }
        if (autoDamage3Bought == 1) { passiveButtons[2].interactable = false; passiveUnlocked[2].SetActive(true); SetAlpha(autoDamageUpgrades[2], alphaValueFull); autoDamageUpgrades[2].GetComponent<Image>().color = newColorLounger; }
        if (autoDamage4Bought == 1) { passiveButtons[3].interactable = false; passiveUnlocked[3].SetActive(true); SetAlpha(autoDamageUpgrades[3], alphaValueFull); autoDamageUpgrades[3].GetComponent<Image>().color = newColorLounger; }
        if (autoDamage5Bought == 1) { passiveButtons[4].interactable = false; passiveUnlocked[4].SetActive(true); SetAlpha(autoDamageUpgrades[4], alphaValueFull); autoDamageUpgrades[4].GetComponent<Image>().color = newColorLounger; }
        if (autoDamage6Bought == 1) { passiveButtons[5].interactable = false; passiveUnlocked[5].SetActive(true); SetAlpha(autoDamageUpgrades[5], alphaValueFull); autoDamageUpgrades[5].GetComponent<Image>().color = newColorLounger; }
        if (autoDamage7Bought == 1) { passiveButtons[6].interactable = false; passiveUnlocked[6].SetActive(true); SetAlpha(autoDamageUpgrades[6], alphaValueFull); autoDamageUpgrades[6].GetComponent<Image>().color = newColorLounger; }
        if (autoDamage8Bought == 1) { passiveButtons[7].interactable = false; passiveUnlocked[7].SetActive(true); SetAlpha(autoDamageUpgrades[7], alphaValueFull); autoDamageUpgrades[7].GetComponent<Image>().color = newColorLounger; }
        #endregion

        #region autoCursor
        if (autoCursor1Bought == 1) { passiveCursorButtons[0].interactable = false; passiveCursorUnlocked[0].SetActive(true); SetAlpha(autoCursorUpgrades[0], alphaValueFull); autoCursorUpgrades[0].GetComponent<Image>().color = newColorLounger; }
        if (autoCursor2Bought == 1) { passiveCursorButtons[1].interactable = false; passiveCursorUnlocked[1].SetActive(true); SetAlpha(autoCursorUpgrades[1], alphaValueFull); autoCursorUpgrades[1].GetComponent<Image>().color = newColorLounger; }
        if (autoCursor3Bought == 1) { passiveCursorButtons[2].interactable = false; passiveCursorUnlocked[2].SetActive(true); SetAlpha(autoCursorUpgrades[2], alphaValueFull); autoCursorUpgrades[2].GetComponent<Image>().color = newColorLounger; }
        if (autoCursor4Bought == 1) { passiveCursorButtons[3].interactable = false; passiveCursorUnlocked[3].SetActive(true); SetAlpha(autoCursorUpgrades[3], alphaValueFull); autoCursorUpgrades[3].GetComponent<Image>().color = newColorLounger; }
        if (autoCursor5Bought == 1) { passiveCursorButtons[4].interactable = false; passiveCursorUnlocked[4].SetActive(true); SetAlpha(autoCursorUpgrades[4], alphaValueFull); autoCursorUpgrades[4].GetComponent<Image>().color = newColorLounger; }
        #endregion

        Color newColorPirate;
        ColorUtility.TryParseHtmlString(pirateHexValue, out newColorPirate);

        #region gold
        if (gold1Bought == 1) { goldButtons[0].interactable = false; goldUnlocked[0].SetActive(true); SetAlpha(goldUpgrades[0], alphaValueFull); goldUpgrades[0].GetComponent<Image>().color = newColorPirate; }
        if (gold2Bought == 1) { goldButtons[1].interactable = false; goldUnlocked[1].SetActive(true); SetAlpha(goldUpgrades[1], alphaValueFull); goldUpgrades[1].GetComponent<Image>().color = newColorPirate; }
        if (gold3Bought == 1) { goldButtons[2].interactable = false; goldUnlocked[2].SetActive(true); SetAlpha(goldUpgrades[2], alphaValueFull); goldUpgrades[2].GetComponent<Image>().color = newColorPirate; }
        if (gold4Bought == 1) { goldButtons[3].interactable = false; goldUnlocked[3].SetActive(true); SetAlpha(goldUpgrades[3], alphaValueFull); goldUpgrades[3].GetComponent<Image>().color = newColorPirate; }
        if (gold5Bought == 1) { goldButtons[4].interactable = false; goldUnlocked[4].SetActive(true); SetAlpha(goldUpgrades[4], alphaValueFull); goldUpgrades[4].GetComponent<Image>().color = newColorPirate; }
        if (gold6Bought == 1) { goldButtons[5].interactable = false; goldUnlocked[5].SetActive(true); SetAlpha(goldUpgrades[5], alphaValueFull); goldUpgrades[5].GetComponent<Image>().color = newColorPirate; }
        if (gold7Bought == 1) { goldButtons[6].interactable = false; goldUnlocked[6].SetActive(true); SetAlpha(goldUpgrades[6], alphaValueFull); goldUpgrades[6].GetComponent<Image>().color = newColorPirate; }
        if (gold8Bought == 1) { goldButtons[7].interactable = false; goldUnlocked[7].SetActive(true); SetAlpha(goldUpgrades[7], alphaValueFull); goldUpgrades[7].GetComponent<Image>().color = newColorPirate; }
        if (gold9Bought == 1) { goldButtons[8].interactable = false; goldUnlocked[8].SetActive(true); SetAlpha(goldUpgrades[8], alphaValueFull); goldUpgrades[8].GetComponent<Image>().color = newColorPirate; }
        #endregion

        #region drops
        if (drops1Bought == 1) { dropsButtons[0].interactable = false; treasureUnlocked[0].SetActive(true); SetAlpha(dropsUpgrades[0], alphaValueFull); dropsUpgrades[0].GetComponent<Image>().color = newColorPirate; }
        if (drops2Bought == 1) { dropsButtons[1].interactable = false; treasureUnlocked[1].SetActive(true); SetAlpha(dropsUpgrades[1], alphaValueFull); dropsUpgrades[1].GetComponent<Image>().color = newColorPirate; }
        if (drops3Bought == 1) { dropsButtons[2].interactable = false; treasureUnlocked[2].SetActive(true); SetAlpha(dropsUpgrades[2], alphaValueFull); dropsUpgrades[2].GetComponent<Image>().color = newColorPirate; }
        if (drops4Bought == 1) { dropsButtons[3].interactable = false; treasureUnlocked[3].SetActive(true); SetAlpha(dropsUpgrades[3], alphaValueFull); dropsUpgrades[3].GetComponent<Image>().color = newColorPirate; }
        if (drops5Bought == 1) { dropsButtons[4].interactable = false; treasureUnlocked[4].SetActive(true); SetAlpha(dropsUpgrades[4], alphaValueFull); dropsUpgrades[4].GetComponent<Image>().color = newColorPirate; }
        if (drops6Bought == 1) { dropsButtons[5].interactable = false; treasureUnlocked[5].SetActive(true); SetAlpha(dropsUpgrades[5], alphaValueFull); dropsUpgrades[5].GetComponent<Image>().color = newColorPirate; skillTreeTreasure6TreasureBag = 1f; }
        if (drops7Bought == 1) { dropsButtons[6].interactable = false; treasureUnlocked[6].SetActive(true); SetAlpha(dropsUpgrades[6], alphaValueFull); dropsUpgrades[6].GetComponent<Image>().color = newColorPirate; soldTreasureBuff = 5; }
        #endregion

        #region xp
        if (xp1Bought == 1) { XPButtons[0].interactable = false; XPUnlocked[0].SetActive(true); SetAlpha(xpUpgrades[0], alphaValueFull); xpUpgrades[0].GetComponent<Image>().color = newColorPirate; }
        if (xp2Bought == 1) { XPButtons[1].interactable = false; XPUnlocked[1].SetActive(true); SetAlpha(xpUpgrades[1], alphaValueFull); xpUpgrades[1].GetComponent<Image>().color = newColorPirate; }
        if (xp3Bought == 1) { XPButtons[2].interactable = false; XPUnlocked[2].SetActive(true); SetAlpha(xpUpgrades[2], alphaValueFull); xpUpgrades[2].GetComponent<Image>().color = newColorPirate; }
        if (xp4Bought == 1) { XPButtons[3].interactable = false; XPUnlocked[3].SetActive(true); SetAlpha(xpUpgrades[3], alphaValueFull); xpUpgrades[3].GetComponent<Image>().color = newColorPirate; }
        if (xp5Bought == 1) { XPButtons[4].interactable = false; XPUnlocked[4].SetActive(true); SetAlpha(xpUpgrades[4], alphaValueFull); xpUpgrades[4].GetComponent<Image>().color = newColorPirate; }
        if (xp6Bought == 1) { XPButtons[5].interactable = false; XPUnlocked[5].SetActive(true); SetAlpha(xpUpgrades[5], alphaValueFull); xpUpgrades[5].GetComponent<Image>().color = newColorPirate; }
        if (xp7Bought == 1) { XPButtons[6].interactable = false; XPUnlocked[6].SetActive(true); SetAlpha(xpUpgrades[6], alphaValueFull); xpUpgrades[6].GetComponent<Image>().color = newColorPirate; }
        if (xp8Bought == 1) { XPButtons[7].interactable = false; XPUnlocked[7].SetActive(true); SetAlpha(xpUpgrades[7], alphaValueFull); xpUpgrades[7].GetComponent<Image>().color = newColorPirate; }
        #endregion

        Color newColorHoarder;
        ColorUtility.TryParseHtmlString(hoarderHexValue, out newColorHoarder);

        #region levelSpecial
        if (levelSpecial1Bought == 1) { levelUpSpecialButtons[0].interactable = false; levelUpSpecialUnlocked[0].SetActive(true); SetAlpha(levelSpecialUpgrades[0], alphaValueFull); levelSpecialUpgrades[0].GetComponent<Image>().color = newColorHoarder; }
        if (levelSpecial2Bought == 1) { levelUpSpecialButtons[1].interactable = false; levelUpSpecialUnlocked[1].SetActive(true); SetAlpha(levelSpecialUpgrades[1], alphaValueFull); levelSpecialUpgrades[1].GetComponent<Image>().color = newColorHoarder; }
        if (levelSpecial3Bought == 1) { levelUpSpecialButtons[2].interactable = false; levelUpSpecialUnlocked[2].SetActive(true); SetAlpha(levelSpecialUpgrades[2], alphaValueFull); levelSpecialUpgrades[2].GetComponent<Image>().color = newColorHoarder; }
        if (levelSpecial4Bought == 1) { levelUpSpecialButtons[3].interactable = false; levelUpSpecialUnlocked[3].SetActive(true); SetAlpha(levelSpecialUpgrades[3], alphaValueFull); levelSpecialUpgrades[3].GetComponent<Image>().color = newColorHoarder; }
        if (levelSpecial5Bought == 1) { levelUpSpecialButtons[4].interactable = false; levelUpSpecialUnlocked[4].SetActive(true); SetAlpha(levelSpecialUpgrades[4], alphaValueFull); levelSpecialUpgrades[4].GetComponent<Image>().color = newColorHoarder; }
        #endregion

        #region strongerSpecial
        if (strongerSpecial1Bought == 1) { strongerSpecialButtons[0].interactable = false; strongerSpecialUnlocked[0].SetActive(true); SetAlpha(strongerSpecialUpgrades[0], alphaValueFull); strongerSpecialUpgrades[0].GetComponent<Image>().color = newColorHoarder; }
        if (strongerSpecial2Bought == 1) { strongerSpecialButtons[1].interactable = false; strongerSpecialUnlocked[1].SetActive(true); SetAlpha(strongerSpecialUpgrades[1], alphaValueFull); strongerSpecialUpgrades[1].GetComponent<Image>().color = newColorHoarder; }
        if (strongerSpecial3Bought == 1) { strongerSpecialButtons[2].interactable = false; strongerSpecialUnlocked[2].SetActive(true); SetAlpha(strongerSpecialUpgrades[2], alphaValueFull); strongerSpecialUpgrades[2].GetComponent<Image>().color = newColorHoarder; }
        if (strongerSpecial4Bought == 1) { strongerSpecialButtons[3].interactable = false; strongerSpecialUnlocked[3].SetActive(true); SetAlpha(strongerSpecialUpgrades[3], alphaValueFull); skillTreeSpecial4Double = 10; strongerSpecialUpgrades[3].GetComponent<Image>().color = newColorHoarder; }
        if (strongerSpecial5Bought == 1) { strongerSpecialButtons[4].interactable = false; strongerSpecialUnlocked[4].SetActive(true); SetAlpha(strongerSpecialUpgrades[4], alphaValueFull); strongerSpecialUpgrades[4].GetComponent<Image>().color = newColorHoarder; }
        if (strongerSpecial6Bought == 1) { strongerSpecialButtons[5].interactable = false; strongerSpecialUnlocked[5].SetActive(true); SetAlpha(strongerSpecialUpgrades[5], alphaValueFull); strongerSpecialUpgrades[5].GetComponent<Image>().color = newColorHoarder; }
        if (strongerSpecial7Bought == 1) 
        {
            strongerSpecialButtons[6].interactable = false; strongerSpecialUnlocked[6].SetActive(true); SetAlpha(strongerSpecialUpgrades[6], alphaValueFull); strongerSpecialUpgrades[6].GetComponent<Image>().color = newColorHoarder;

            special7ScrollTreasure = 0.01f;
            special7ScrollCritChance = 0.01f;
            special7ScrollCritDamage = 0.1f;
            special7ScrollActiveDamage = 0.15f;
            special7ScrollPassiveDamage = 0.08f;
            special7ScrollXP = 0.04f;
            special7ScrollTGOLD = 0.05f;

            special7RelicTreasure = 0.03f;
            special7RelicCritChance = 0.02f;
            special7RelicCritDamage = 1;
            special7RelicActiveDamage = 0.5f;
            special7RelicPassiveDamage = 0.4f;
            special7RelicXP = 0.35f;
            special7RelicTGOLD = 0.35f;
        }
        #endregion

        #region startWithItems
        if (startWithItem1Bought == 1) { startWithButtons[0].interactable = false; startWitchUnlcoked[0].SetActive(true); SetAlpha(startWithItemUpgrades[0], alphaValueFull); startWithItemUpgrades[0].GetComponent<Image>().color = newColorHoarder; }
        if (startWithItem2Bought == 1) { startWithButtons[1].interactable = false; startWitchUnlcoked[1].SetActive(true); SetAlpha(startWithItemUpgrades[1], alphaValueFull); startWithItemUpgrades[1].GetComponent<Image>().color = newColorHoarder; }
        if (startWithItem3Bought == 1) { startWithButtons[2].interactable = false; startWitchUnlcoked[2].SetActive(true); SetAlpha(startWithItemUpgrades[2], alphaValueFull); startWithItemUpgrades[2].GetComponent<Image>().color = newColorHoarder; }
        if (startWithItem4Bought == 1) { startWithButtons[3].interactable = false; startWitchUnlcoked[3].SetActive(true); SetAlpha(startWithItemUpgrades[3], alphaValueFull); startWithItemUpgrades[3].GetComponent<Image>().color = newColorHoarder; }
        #endregion


        #region new active cursors increment 
        if (activeCursor1Bought == 1)
        {
            ClickPower.cursor19ActiveDamageIncrement = 4.5f;
            ClickPower.cursor19CritChanceIncrement = 0.9f;
            ClickPower.cursor19CritDamageIncrement = 8f;

            ClickPower.cursor20ActiveDamageIncrement = 10f;
            ClickPower.cursor20CritChanceIncrement = 0.5f;
            ClickPower.cursor20CritDamageIncrement = 11f;

            ClickPower.cursor21ActiveDamageIncrement = 11f;
            ClickPower.cursor21CritChanceIncrement = 0.8f;
            ClickPower.cursor21CritDamageIncrement = 11f;
        }

        if (activeCursor2Bought == 1)
        {
            ClickPower.cursor19ActiveDamageIncrement = 5f;
            ClickPower.cursor19CritChanceIncrement = 1f;
            ClickPower.cursor19CritDamageIncrement = 10f;

            ClickPower.cursor20ActiveDamageIncrement = 11f;
            ClickPower.cursor20CritChanceIncrement = 0.6f;
            ClickPower.cursor20CritDamageIncrement = 12f;

            ClickPower.cursor21ActiveDamageIncrement = 13f;
            ClickPower.cursor21CritChanceIncrement = 0.9f;
            ClickPower.cursor21CritDamageIncrement = 13f;
        }

        if (activeCursor4Bought == 1)
        {
            ClickPower.cursor19ActiveDamageIncrement = 6f;
            ClickPower.cursor19CritChanceIncrement = 1.1f;
            ClickPower.cursor19CritDamageIncrement = 11f;

            ClickPower.cursor20ActiveDamageIncrement = 12f;
            ClickPower.cursor20CritChanceIncrement = 0.7f;
            ClickPower.cursor20CritDamageIncrement = 13f;

            ClickPower.cursor21ActiveDamageIncrement = 14f;
            ClickPower.cursor21CritChanceIncrement = 1f;
            ClickPower.cursor21CritDamageIncrement = 14f;
        }
        #endregion

        #region new passive cursors increment 
        if (autoCursor1Bought == 1)
        {
            ClickPower.cursor19PassiveDamageIncrement = 6f;
            ClickPower.cursor20PassiveDamageIncrement = 10f;
            ClickPower.cursor21PassiveDamageIncrement = 11f;
        }

        if (autoCursor2Bought == 1)
        {
            ClickPower.cursor19PassiveDamageIncrement = 7f;
            ClickPower.cursor20PassiveDamageIncrement = 12f;
            ClickPower.cursor21PassiveDamageIncrement = 15f;
        }

        if (autoCursor4Bought == 1)
        {
            ClickPower.cursor19PassiveDamageIncrement = 9f;
            ClickPower.cursor20PassiveDamageIncrement = 15f;
            ClickPower.cursor21PassiveDamageIncrement = 18f;
        }

        if (autoCursor5Bought == 1)
        {
            ClickPower.cursor19PassiveDamageIncrement = 10f;
            ClickPower.cursor20PassiveDamageIncrement = 20f;
            ClickPower.cursor21PassiveDamageIncrement = 26f;
        }
        #endregion

        #region new items increment
        if (levelSpecial1Bought == 1)
        {
            UpdateGame.knifeDropChanceIncrement = 0.001f;
            UpdateGame.treasurePotionDropChanceIncrement = 0.004f;
            UpdateGame.mimicPositiveBiffChanceIncrement = 1;
            UpdateGame.mimicNegativeBuffChanceIncrement = 1;
            UpdateGame.mimicChestTimerIncrement = 4;
            UpdateGame.knifeTimerIncrement = 1;
            UpdateGame.treasurePotionTimerIncrement = 1;
            UpdateGame.barrelGoldValueIncrement = 0.07f;
        }

        if (levelSpecial2Bought == 1)
        {
            UpdateGame.knifeDropChanceIncrement = 0.002f;
            UpdateGame.treasurePotionDropChanceIncrement = 0.005f;
            UpdateGame.mimicPositiveBiffChanceIncrement = 2;
            UpdateGame.mimicNegativeBuffChanceIncrement = 2;
            UpdateGame.mimicChestTimerIncrement = 5;
            UpdateGame.knifeTimerIncrement = 1;
            UpdateGame.treasurePotionTimerIncrement = 2;
            UpdateGame.barrelGoldValueIncrement = 0.09f;
        }

        if (levelSpecial3Bought == 1)
        {
            UpdateGame.knifeDropChanceIncrement = 0.002f;
            UpdateGame.treasurePotionDropChanceIncrement = 0.005f;
            UpdateGame.mimicPositiveBiffChanceIncrement = 2;
            UpdateGame.mimicNegativeBuffChanceIncrement = 2;
            UpdateGame.mimicChestTimerIncrement = 6;
            UpdateGame.knifeTimerIncrement = 2;
            UpdateGame.treasurePotionTimerIncrement = 2;
            UpdateGame.barrelGoldValueIncrement = 0.11f;
        }

        if (levelSpecial4Bought == 1)
        {
            UpdateGame.knifeDropChanceIncrement = 0.003f;
            UpdateGame.treasurePotionDropChanceIncrement = 0.005f;
            UpdateGame.mimicPositiveBiffChanceIncrement = 3;
            UpdateGame.mimicNegativeBuffChanceIncrement = 3;
            UpdateGame.mimicChestTimerIncrement = 7;
            UpdateGame.knifeTimerIncrement = 2;
            UpdateGame.treasurePotionTimerIncrement = 3;
            UpdateGame.barrelGoldValueIncrement = 0.14f;
        }

        if (levelSpecial5Bought == 1)
        {
            UpdateGame.knifeDropChanceIncrement = 0.003f;
            UpdateGame.treasurePotionDropChanceIncrement = 0.006f;
            UpdateGame.mimicPositiveBiffChanceIncrement = 4;
            UpdateGame.mimicNegativeBuffChanceIncrement = 4;
            UpdateGame.mimicChestTimerIncrement = 9;
            UpdateGame.knifeTimerIncrement = 2;
            UpdateGame.treasurePotionTimerIncrement = 3;
            UpdateGame.barrelGoldValueIncrement = 0.2f;
        }
        #endregion

        //Debug.Log(Stats.prestigeUpgradesPurchased);
        //Debug.Log(Stats.clickerUpgradePurchased);
        //Debug.Log(Stats.loungerUpgradesPurchased);
        //Debug.Log(Stats.pirateUpgradesPurchased);
        //Debug.Log(Stats.hoarderUpgradeesPurchased);

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
        if(PlaceMobileButtons.isMobile == true)
        {
            for (int i = 0; i < critButtons.Length; i++)
            {
                critButtons[i].interactable = true;
            }

            for (int i = 0; i < activeButtons.Length; i++)
            {
                activeButtons[i].interactable = true;
            }

            for (int i = 0; i < activeCursorsButtons.Length; i++)
            {
                activeCursorsButtons[i].interactable = true;
            }

            for (int i = 0; i < autoClickerButtons.Length; i++)
            {
                autoClickerButtons[i].interactable = true;
            }

            for (int i = 0; i < passiveButtons.Length; i++)
            {
                passiveButtons[i].interactable = true;
            }

            for (int i = 0; i < passiveCursorButtons.Length; i++)
            {
                passiveCursorButtons[i].interactable = true;
            }

            for (int i = 0; i < goldButtons.Length; i++)
            {
                goldButtons[i].interactable = true;
            }

            for (int i = 0; i < dropsButtons.Length; i++)
            {
                dropsButtons[i].interactable = true;
            }

            for (int i = 0; i < XPButtons.Length; i++)
            {
                XPButtons[i].interactable = true;
            }

            for (int i = 0; i < levelUpSpecialButtons.Length; i++)
            {
                levelUpSpecialButtons[i].interactable = true;
            }

            for (int i = 0; i < strongerSpecialButtons.Length; i++)
            {
                strongerSpecialButtons[i].interactable = true;
            }

            for (int i = 0; i < startWithButtons.Length; i++)
            {
                startWithButtons[i].interactable = true;
            }

            mobileScript.ClosePrestigeFrame();
        }
        #endregion

        CheckPriceTextColor();
    }
    #endregion

    public PlaceMobileButtons mobileScript;
    public static bool purchasedPrestigeUpgrade;
    public void NotEnoughPoints()
    {
        if(PlaceMobileButtons.isMobile == true)
        { 
            if(PlaceMobileButtons.isPrestigeTooltipOpen == true) { if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("Error"); } }
        }
        else
        {
            if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("Error"); }
        }
    }

    #region Start new prestige
    public void StartNewPrestigeClick()
    {
        ClickPower.activeDamageMultiplier = 0; ClickPower.passiveDamageMultiplier = 0; ClickPower.critChance = 0; ClickPower.critDamage = 0;
        ClickPower.activeUpgradeLevel = 0; ClickPower.passiveUpgradeLevel = 0;
        HealthBar.newPassiveDamage = 0;
        ClickPower.newActiveDamage = 1;
        ClickPower.newActiveDamagePrice = 5;
        ClickPower.newPassiveDamagePrice = 10;
        pressedPrestige = true;
        isInsideskillTree = true;
        ClickPower.resetClickDamage = true;
    }

    public static bool setSoulGemInactive;
    public void StartNewPrestige()
    {
        StartNewPrestigeClick();
        setSoulGemInactive = true;

        //Gold
        UpdateGame.totalGoldHigher = 0;

        //Auto Damage
        //HealthBar.autoDamage = 0;
        HealthBar.newPassiveDamage = 0;

        #region purchased chests
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
        #endregion

        #region gems
        RareDropsCollected.RedGemCount = 0; RareDropsCollected.amethystCount = 0; RareDropsCollected.diamondCount = 0; RareDropsCollected.violetCrystalCount = 0;
        RareDropsCollected.yellowSapphireCount = 0; RareDropsCollected.greenDiamondCount = 0; RareDropsCollected.grandidieriteCount = 0;
        RareDropsCollected.purpleRupeeCount = 0;
        RareDropsCollected.pinkPlostCount = 0; RareDropsCollected.emeraldCount = 0; RareDropsCollected.quartzCount = 0; RareDropsCollected.redGarnetCount = 0;
        RareDropsCollected.pinkTourmalineCount = 0; RareDropsCollected.yellowTopazCount = 0; RareDropsCollected.aquamarineCount = 0; RareDropsCollected.fireOpalCount = 0;
        RareDropsCollected.goldeSeaPearlCount = 0; RareDropsCollected.akoyaPearlCount = 0; RareDropsCollected.gemSilicaCount = 0; RareDropsCollected.AdventurineCount = 0;
        RareDropsCollected.kyaniteCount = 0; RareDropsCollected.albiteCount = 0; RareDropsCollected.blackOpalCount = 0; RareDropsCollected.painiteCount = 0;
        RareDropsCollected.TanzaniteCount = 0; RareDropsCollected.astraliumCount = 0; RareDropsCollected.elysiumPrismCount = 0; RareDropsCollected.eldritchStarstoneCount = 0; RareDropsCollected.chronolithShardCount = 0; RareDropsCollected.sideriumEssenceCount = 0; RareDropsCollected.quasariteCount = 0; RareDropsCollected.radiantNovaStoneCount = 0; RareDropsCollected.soluniumShardCount = 0; RareDropsCollected.aetherfireOpalCount = 0;

        RareDropsCollected.redGemBoughtFirstTime = 0; RareDropsCollected.amethystBoughtFirstTime = 0; RareDropsCollected.diamondBoughtFirstTime = 0;
        RareDropsCollected.violetCrystalBoughtFirstTime = 0; RareDropsCollected.yellowSapphireBoughtFirstTime = 0; RareDropsCollected.greenDiamondBoughtFirstTime = 0;
        RareDropsCollected.grandidieriteBoughtFirstTime = 0; RareDropsCollected.purpleRupeeBoughtFirstTime = 0; RareDropsCollected.pinkPlortBoughtFirstTime = 0;
        RareDropsCollected.emeraldBoughtFirstTime = 0; RareDropsCollected.quartzBoughtFirstTime = 0;
        RareDropsCollected.redGarnetBoughtFirstTime = 0; RareDropsCollected.pinkTourmalineBoughtFirstTime = 0; RareDropsCollected.yellowTopazBoughtFirstTime = 0;
        RareDropsCollected.aquamarineBoughtFirstTime = 0; RareDropsCollected.fireOpalBoughtFirstTime = 0; RareDropsCollected.kyaniteBoughtFirstTime = 0;
        RareDropsCollected.albiteBoughtFirstTime = 0; RareDropsCollected.blackOpalBoughtFirstTime = 0; RareDropsCollected.painiteBoughtFirstTime = 0;
        RareDropsCollected.tanzaniteBoughtFirstTime = 0; RareDropsCollected.adventurineBoughtFirstTime = 0; RareDropsCollected.gemSilicaBoughtFirstTime = 0;
        RareDropsCollected.akoyaPearlBoughtFirstTime = 0; RareDropsCollected.goldeSeaPearlBoughtFirstTime = 0; RareDropsCollected.astraliumBoughtFirstTime = 0; RareDropsCollected.elysiumPrismBoughtFirstTime = 0; RareDropsCollected.aetherfireOpalBoughtFirstTime = 0; RareDropsCollected.eldritchStarstoneBoughtFirstTime = 0; RareDropsCollected.chronolithShardBoughtFirstTime = 0; RareDropsCollected.sideriumEssenceBoughtFirstTime = 0; RareDropsCollected.quasariteBoughtFirstTime = 0; RareDropsCollected.radiantNovaStoneBoughtFirstTime = 0; RareDropsCollected.soluniumShardBoughtFirstTime = 0;
        #endregion

        //Cursors
        #region cursors level and equipped and upgrade price

        //Cursors equipped and level
        ClickPower.cursor1Equipped = 0; ClickPower.cursor2Equipped = 0; ClickPower.cursor3Equipped = 0; ClickPower.cursor4Equipped = 0; ClickPower.cursor5Equipped = 0; ClickPower.cursor6Equipped = 0; ClickPower.cursor7Equipped = 0; ClickPower.cursor8Equipped = 0; ClickPower.cursor9Equipped = 0; ClickPower.cursor10Equipped = 0; ClickPower.cursor11Equipped = 0; ClickPower.cursor12Equipped = 0; ClickPower.cursor13Equipped = 0; ClickPower.cursor14Equipped = 0; ClickPower.cursor15Equipped = 0; ClickPower.cursor16Equipped = 0; ClickPower.cursor17Equipped = 0; ClickPower.cursor18Equipped = 0;
        ClickPower.cursor19Equipped = 0; ClickPower.cursor20Equipped = 0; ClickPower.cursor21Equipped = 0;

        ClickPower.Cursor1Level = 1; ClickPower.cursor2Level = 1; ClickPower.cursor3Level = 1; ClickPower.cursor4Level = 1; ClickPower.cursor5Level = 1; ClickPower.cursor6Level = 1; ClickPower.cursor7Level = 1; ClickPower.cursor8Level = 1; ClickPower.cursor9Level = 1; ClickPower.cursor10Level = 1; ClickPower.cursor11Level = 1; ClickPower.cursor12Level = 1; ClickPower.cursor13Level = 1; ClickPower.cursor14Level = 1; ClickPower.cursor15Level = 1; ClickPower.cursor16Level = 1; ClickPower.cursor17Level = 1; ClickPower.cursor18Level = 1; ClickPower.cursor19Level = 1; ClickPower.cursor20Level = 1; ClickPower.cursor21Level = 1;

        ClickPower.cursor1Change = true; ClickPower.cursor2Change = true; ClickPower.cursor3Change = true; ClickPower.cursor4Change = true; ClickPower.cursor5Change = true; ClickPower.cursor6Change = true; ClickPower.cursor7Change = true; ClickPower.cursor8Change = true; ClickPower.cursor9Change = true; ClickPower.cursor10Change = true; ClickPower.cursor11Change = true; ClickPower.cursor12Change = true; ClickPower.cursor13Change = true; ClickPower.cursor14Change = true; ClickPower.cursor15Change = true; ClickPower.cursor16Change = true; ClickPower.cursor17Change = true; ClickPower.cursor18Change = true; ClickPower.cursor19Change = true; ClickPower.cursor20Change = true; ClickPower.cursor21Change = true;

        //Damage
        ClickPower.activeDamageMultiplier = 0; ClickPower.passiveDamageMultiplier = 0; ClickPower.critChance = 0; ClickPower.critDamage = 0;
        ClickPower.activeUpgradeLevel = 0; ClickPower.passiveUpgradeLevel = 0; ClickPower.clickPower = 1;
        ClickPower.activeClickPowerPrice = 5; ClickPower.passiveClickPowerPrice = 10;


        //Cursor upgrade prices
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

        ClickPower.cursor19AstraliumPrice = 1;
        ClickPower.cursor19ElysiumPrismPrice = 1;
        ClickPower.cursor19AerthfireOpalPrice = 1;

        ClickPower.cursor20EldritchStarStonePrice = 1;
        ClickPower.cursor20ChronolithShardPrice = 1;
        ClickPower.cursor20SideriumEssencePrice = 1;

        ClickPower.cursor21QuasaritePrice = 1;
        ClickPower.cursor21RadiantNovaStonePrice = 1;
        ClickPower.cursor21SoluniumShardPrice = 1;

        #endregion

        //Cursors active
        if (activeCursor3Bought != 1 && activeCursor4Bought != 1)
        {
            SaveAndLoad.setCursorsStartStatsActive = true;
        }

        #region cursor active stronger. Skill tree active upgrade 3

       if(activeCursor3Bought == 1)
        {
            ClickPower.cursor1ActiveBuff = 0.08f;

            ClickPower.cursor3CritChance = 1.2f;
            ClickPower.cursor3CritDamage = 3f;

            ClickPower.cursor4ActiveDamage = 0.16f;

            ClickPower.cursor5ActiveDamage = 0.35f;
            ClickPower.cursor5CritChance = 2.7f;
            ClickPower.cursor5CritDamage = 3.4f;

             ClickPower.cursor6CritChance = 1.6f;
            ClickPower.cursor6CritDamage = 5.5f; ClickPower.cursor6ActiveDamage = 0.23f;

            ClickPower.cursor7CritChance = 3.1f; ClickPower.cursor7CritDamage = 6.90f; ClickPower.cursor7ActiveDamage = 0.85f;

            ClickPower.cursor8ActiveDamage = 0.8f; 
            ClickPower.cursor8CritChance = 2f; ClickPower.cursor8CritDamage = 6.6f;

            ClickPower.cursor9ActiveDamage = 2f;

            ClickPower.cursor11ActiveDamage = 2.1f; ClickPower.cursor11CritChance = 5.5f; ClickPower.cursor11CritDamage = 5.1f;

            ClickPower.cursor12ActiveDamage = 3.3f; ClickPower.cursor12CritChance = 3.3f; ClickPower.cursor12CritDamage = 7.5f;

            ClickPower.cursor13ActiveDamage = 6.2f;  ClickPower.cursor13CritChance = 2.2f; ClickPower.cursor13CritDamage = 10f;

            ClickPower.cursor14ActiveDamage = 6.8f;  ClickPower.cursor14CritChance = 6.9f; ClickPower.cursor14CritDamage = 10.7f;

            ClickPower.cursor15ActiveDamage = 10.4f; ClickPower.cursor15CritChance = 2.6f; ClickPower.cursor15CritDamage = 17f;

            ClickPower.cursor16ActiveDamage = 11f;  ClickPower.cursor16CritChance = 5.2f; ClickPower.cursor16CritDamage = 15f;

            ClickPower.cursor17ActiveDamage = 14f;  ClickPower.cursor17CritChance = 4.4f; ClickPower.cursor17CritDamage = 19f;

            ClickPower.cursor18ActiveDamage = 20f;  ClickPower.cursor18CritChance = 6f; ClickPower.cursor18CritDamage = 21f;

            ClickPower.cursor19ActiveDamage = 27f; ClickPower.cursor19CritChance = 7f; ClickPower.cursor19CritDamage = 35f;

            ClickPower.cursor20ActiveDamage = 52f; ClickPower.cursor20CritChance = 5f; ClickPower.cursor20CritDamage = 55f;

            ClickPower.cursor21ActiveDamage = 80f; ClickPower.cursor21CritChance = 9f; ClickPower.cursor21CritDamage = 115f;
        }

        #endregion

        #region cursor active stronger. Skill tree active upgrade 4

        if (activeCursor4Bought == 1)
        {
            ClickPower.cursor1ActiveBuff = 0.20f;

            ClickPower.cursor3CritChance = 2.2f;
            ClickPower.cursor3CritDamage = 4f;

            ClickPower.cursor4ActiveDamage = 0.30f;

            ClickPower.cursor5ActiveDamage = 0.55f;
            ClickPower.cursor5CritChance = 3.4f;
            ClickPower.cursor5CritDamage = 4.7f;

            ClickPower.cursor6CritChance = 2.4f;
            ClickPower.cursor6CritDamage = 7f; ClickPower.cursor6ActiveDamage = 0.56f;

            ClickPower.cursor7CritChance = 4f; ClickPower.cursor7CritDamage = 8f; ClickPower.cursor7ActiveDamage = 1.15f;

            ClickPower.cursor8ActiveDamage = 1.2f;
            ClickPower.cursor8CritChance = 3f; ClickPower.cursor8CritDamage = 8f;

            ClickPower.cursor9ActiveDamage = 3f;

            ClickPower.cursor11ActiveDamage = 3.5f; ClickPower.cursor11CritChance = 6.3f; ClickPower.cursor11CritDamage = 7f;

            ClickPower.cursor12ActiveDamage = 5f; ClickPower.cursor12CritChance = 4.5f; ClickPower.cursor12CritDamage = 9f;

            ClickPower.cursor13ActiveDamage = 7f; ClickPower.cursor13CritChance = 3.4f; ClickPower.cursor13CritDamage = 13f;

            ClickPower.cursor14ActiveDamage = 8f; ClickPower.cursor14CritChance = 7.3f; ClickPower.cursor14CritDamage = 11f;

            ClickPower.cursor15ActiveDamage = 11.6f; ClickPower.cursor15CritChance = 4f; ClickPower.cursor15CritDamage = 18f;

            ClickPower.cursor16ActiveDamage = 13f; ClickPower.cursor16CritChance = 6.6f; ClickPower.cursor16CritDamage = 16.4f;

            ClickPower.cursor17ActiveDamage = 16.8f; ClickPower.cursor17CritChance = 5.9f; ClickPower.cursor17CritDamage = 21f;

            ClickPower.cursor18ActiveDamage = 27f; ClickPower.cursor18CritChance = 7f; ClickPower.cursor18CritDamage = 25f;

            ClickPower.cursor19ActiveDamage = 31f; ClickPower.cursor19CritChance = 8f; ClickPower.cursor19CritDamage = 42f;

            ClickPower.cursor20ActiveDamage = 60f; ClickPower.cursor20CritChance = 6f; ClickPower.cursor20CritDamage = 66f;

            ClickPower.cursor21ActiveDamage = 90f; ClickPower.cursor21CritChance = 10f; ClickPower.cursor21CritDamage = 130f;
        }

        #endregion

        //Cursors passiv

        if (autoCursor3Bought != 1 && autoCursor4Bought != 1)
        {
            SaveAndLoad.setCursorsStartStatsPassive = true;
        }

        #region cursor passive stronger. Skill tree passive upgrade 3

        if (autoCursor3Bought == 1)
        {
            ClickPower.cursor2PassiveBuff = 0.08f;

            ClickPower.cursor4PassiveDamage = 0.15f;

            ClickPower.cursor6PassiveDamage = 0.45f;

            ClickPower.cursor8PassiveDamage = 0.72f;

            ClickPower.cursor9PassiveDamage = 1.8f;

            ClickPower.cursor10PassiveDamage = 4.0f;

            ClickPower.cursor12PassiveDamage = 3.4f;

            ClickPower.cursor13PassiveDamage = 4.5f;

            ClickPower.cursor14PassiveDamage = 8.3f;

            ClickPower.cursor15PassiveDamage = 9.5f;

            ClickPower.cursor16PassiveDamage = 11.5f;

            ClickPower.cursor17PassiveDamage = 14f;

            ClickPower.cursor18PassiveDamage = 18.5f;

            ClickPower.cursor19PassiveDamage = 31f;

            ClickPower.cursor20PassiveDamage = 50f;

            ClickPower.cursor21PassiveDamage = 81f;
        }

        #endregion

        #region cursor passive stronger. Skill tree passive upgrade 4

        if (autoCursor4Bought == 1)
        {
            ClickPower.cursor2PassiveBuff = 0.2f;

            ClickPower.cursor4PassiveDamage = 0.32f;

            ClickPower.cursor6PassiveDamage = 0.75f;

            ClickPower.cursor8PassiveDamage = 1.2f;

            ClickPower.cursor9PassiveDamage = 2.7f;

            ClickPower.cursor10PassiveDamage = 5.6f;

            ClickPower.cursor12PassiveDamage = 6.4f;

            ClickPower.cursor13PassiveDamage = 8f;

            ClickPower.cursor14PassiveDamage = 10f;

            ClickPower.cursor15PassiveDamage = 14f;

            ClickPower.cursor16PassiveDamage = 15f;

            ClickPower.cursor17PassiveDamage = 20f;

            ClickPower.cursor18PassiveDamage = 26f;

            ClickPower.cursor19PassiveDamage = 36f;

            ClickPower.cursor20PassiveDamage = 60f;

            ClickPower.cursor21PassiveDamage = 98f;
        }

        #endregion

        #region cursor passive stronger. Skill tree passive upgrade 5

        if (autoCursor5Bought == 1)
        {
            ClickPower.cursor2PassiveBuff = 0.35f;

            ClickPower.cursor4PassiveDamage = 0.4f;

            ClickPower.cursor6PassiveDamage = 0.9f;

            ClickPower.cursor8PassiveDamage = 1.5f;

            ClickPower.cursor9PassiveDamage = 3.2f;

            ClickPower.cursor10PassiveDamage = 6.9f;

            ClickPower.cursor12PassiveDamage = 7.6f;

            ClickPower.cursor13PassiveDamage = 10f;

            ClickPower.cursor14PassiveDamage = 13f;

            ClickPower.cursor15PassiveDamage = 17f;

            ClickPower.cursor16PassiveDamage = 21f;

            ClickPower.cursor17PassiveDamage = 28f;

            ClickPower.cursor18PassiveDamage = 33f;

            ClickPower.cursor19PassiveDamage = 45f;

            ClickPower.cursor20PassiveDamage = 76f;

            ClickPower.cursor21PassiveDamage = 135f;
        }

        #endregion

        //Upgrade increment will not reset. It is saved.
        #region items and store upgrades/special upgrades
        //Item count

        //Scroll
        UseConsumable.scrollActiveDamageBuff = 0; UseConsumable.scrollPassiveDamageBuff = 0; UseConsumable.scrollCritChanceBuff = 0; UseConsumable.scrollCritDamageBuff = 0; UseConsumable.scrollTreasureBuff = 0; UseConsumable.scrollXPBuff = 0; UseConsumable.scrollGoldBuff = 0;

        //Items bought first time
        SpecialUpgradesButtons.keyBoughtFirstTime = 0; SpecialUpgradesButtons.hammerBoughtFirstTime = 0; SpecialUpgradesButtons.goldenTouchBoughtFirstTime = 0;
        SpecialUpgradesButtons.lockPickBoughtFirstTime = 0; SpecialUpgradesButtons.treasureBagBoughtFirstTime = 0; SpecialUpgradesButtons.XPPotionBoughtFirstTime = 0;
        SpecialUpgradesButtons.damagePotionBoughtFirstTime = 0; SpecialUpgradesButtons.lootPotionBoughtFirstTime = 0; SpecialUpgradesButtons.miniChestBoughtFirstTime = 0; SpecialUpgradesButtons.elixirBoughtFirstTime = 0;
        SpecialUpgradesButtons.scrollBoughtFirstTime = 0; SpecialUpgradesButtons.gauntletBoughtFirstTime = 0;
        SpecialUpgradesButtons.relicBoughtFirstTime = 0;

        //New purchase price
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

        //Item gem price
        SpecialUpgradesButtons.lockPickGemPrice = 1;
        SpecialUpgradesButtons.hammerGemUpgradePrice = 2;
        SpecialUpgradesButtons.goldenTouchGemPrice = 2;
        SpecialUpgradesButtons.keyGemUpgradePrice = 1;
        SpecialUpgradesButtons.treasureBagGemPrice = 1;
        SpecialUpgradesButtons.XPPotionGemPrice = 2;
        SpecialUpgradesButtons.damagePotionGemPrice = 2;
        SpecialUpgradesButtons.lootPotionGemPrice = 2;
        SpecialUpgradesButtons.miniChestGemPrice = 2;
        SpecialUpgradesButtons.elixirGemPrice = 2;
        SpecialUpgradesButtons.scrollGemPrice = 2;
        SpecialUpgradesButtons.gauntletGemPrice = 3;
        SpecialUpgradesButtons.relicGemPrice = 3;
        SpecialUpgradesButtons.relicGemPrice2 = 3;

        //Item levels
        SpecialUpgradesButtons.lockPickLevel = 1;
        SpecialUpgradesButtons.hammerLevel = 1;
        SpecialUpgradesButtons.keyLevel = 1;
        SpecialUpgradesButtons.goldenTouchLevel = 1;
        SpecialUpgradesButtons.treasureBagLevel = 1;
        SpecialUpgradesButtons.XPPotionLevel = 1;
        SpecialUpgradesButtons.damagePotionLevel = 1;
        SpecialUpgradesButtons.lootPotionLevel = 1;
        SpecialUpgradesButtons.miniChestLevel = 1;
        SpecialUpgradesButtons.elixirLevel = 1;
        SpecialUpgradesButtons.scrollLevel = 1;
        SpecialUpgradesButtons.gauntletLevel = 1;
        SpecialUpgradesButtons.relicLevel = 1;

        //Stronger special upgrade/items branch.
        UseConsumable.lockPickSuccessChance = (30 + SkillTree.wholeNumberIncrement);

        SpecialUpgradesButtons.hammerTimer = (8 + SkillTree.wholeNumberIncrement);
        UseConsumable.hammerDamageMultiplier = (3.5f + SkillTree.wholeNumberIncrement);

        SpecialUpgradesButtons.keyRareDropChance = (8f + SkillTree.wholeNumberIncrement);

        SpecialUpgradesButtons.goldenTouchTimer = (15f + SkillTree.wholeNumberIncrement);

        SpecialUpgradesButtons.XPPotionXPBuff = (0.60f + SkillTree.oneDecimalNumberIncrement);
        SpecialUpgradesButtons.XPPotionTimer = (30 + SkillTree.wholeNumberIncrement);

        SpecialUpgradesButtons.damagePotionBuff = (0.7f + SkillTree.oneDecimalNumberIncrement);
        SpecialUpgradesButtons.damagePotionTimer = (30 + SkillTree.wholeNumberIncrement);

        SpecialUpgradesButtons.lootPotionBuff = (0.75f + SkillTree.oneDecimalNumberIncrement);
        SpecialUpgradesButtons.lootPotionTimer = (30 + SkillTree.wholeNumberIncrement);

        SpecialUpgradesButtons.miniChestSpawnTimer = (300 - SkillTree.wholeNumberIncrement);

        SpecialUpgradesButtons.elixirBuff = (0.7f + SkillTree.oneDecimalNumberIncrement);
        SpecialUpgradesButtons.elixirTimer = (25f + SkillTree.wholeNumberIncrement);

        SpecialUpgradesButtons.scrollTimer = (10 + SkillTree.wholeNumberIncrement);

        SpecialUpgradesButtons.gauntletTimer = (10f + SkillTree.wholeNumberIncrement);
        SpecialUpgradesButtons.gauntletGoldDropChance = (35f + SkillTree.wholeNumberIncrement);
        #endregion

        #region itemsDropChance
        SpecialUpgradesButtons.lockPickDropChance = 0.1f;
        SpecialUpgradesButtons.hammerDropChance = 0.06f;
        SpecialUpgradesButtons.keyDropChance = 0.05f;
        SpecialUpgradesButtons.goldenTouchDropChance = 0.04f;
        SpecialUpgradesButtons.treasureBagDropChance = (0.05f + SkillTree.twoDecimalNumberIncrement + skillTreeTreasure6TreasureBag);
        SpecialUpgradesButtons.XPPotionDropChance = 0.07f;
        SpecialUpgradesButtons.damagePotionDropChance = 0.07f;
        SpecialUpgradesButtons.lootPotionDropChance = 0.07f;
        SpecialUpgradesButtons.elixirDropChance = 0.03f;
        SpecialUpgradesButtons.scrollDropChance = 0.02f;
        SpecialUpgradesButtons.gauntletDropChance = 0.015f;
        SpecialUpgradesButtons.relicDropChance = (0.01f + SkillTree.twoDecimalNumberIncrement);

        #endregion

        #region level
        PlayerLevel.playerLevel = 0;
        PlayerLevel.experienceGained = 0;
        PlayerLevel.experienceNeeded = 250;
        #endregion

        #region new update
        UpdateGame.barrelOfGoldAmountDouble = 0;
        UpdateGame.changeBarrelTexture = true;

        UpdateGame.barrelBuyPriceDouble = 65000000000;
        UpdateGame.mimicChestBuyPriceDouble = 48000000000000000;
        UpdateGame.treasurePotionBuyPriceDouble = 69000000000000000000000000000000000000f;
        UpdateGame.knifeBuyPriceDouble = 25000000000000000000000000000000000000000000000.5;

        UpdateGame.knifeBoughtFirstTime = 0;
        UpdateGame.barrelBoughtFirstTime = 0;
        UpdateGame.treasurePotionBoughtFirstTime = 0;
        UpdateGame.mimicChestBoughtFirstTime = 0;

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

        UpdateGame.barrelGoldValue = 1;
        UpdateGame.knifeTimer = (8 + wholeNumberIncrement);
        UpdateGame.treasurePotionTimer = (13 + wholeNumberIncrement);
        UpdateGame.mimicNegativeBuffChance = 75;
        UpdateGame.mimicPositiveBuffChance = 25;
        UpdateGame.treasurePotionDropChance = 0.03f;
        UpdateGame.knifeDropChance = 0.01f;
        UpdateGame.mimicChestTimer = 300;
        #endregion

        UnlockChests.currentSellPrice = 1;

        RareDropsCollected.isGemCountUpdated = true;
        SpecialUpgradesButtons.changeText = true;
        ClickPower.cursorsPriceChanged = true;
        SpecialUpgradesButtons.specialTextChange = true;
        UseConsumable.changeCountText = true;
        RareDropsCollected.setTreasureTextRed = true;
        pressedPrestige = true;
        UpdateGame.changeItemUpdate = true;

        //SpecialUpgradesButtons.miniChestSpawnTimer = 10;


        StartCoroutine(wait());
        CheckPriceTextColor();

    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(1.2f);
        setSoulGemInactive = false;
        isInsideskillTree = false;
        pressedPrestige = false;
    }
    #endregion


    public static bool pressedPrestige;

    #region setAlpha
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

    private void SetAlphaHalf(Graphic graphic, float alpha)
    {
        Color currentColor = graphic.color;
        currentColor.a = alpha;
        graphic.color = currentColor;
    }
    #endregion

    public void ResetSkillTree()
    {
        #region resetPrestige
        critLocks[0].SetActive(true); critIcons[1].SetActive(false);
        critLocks[1].SetActive(true); critIcons[2].SetActive(false);
        critLocks[2].SetActive(true); critIcons[3].SetActive(false);
        critLocks[3].SetActive(true); critIcons[4].SetActive(false);

        activeDamageLocks[0].SetActive(true); activeDamageIcons[0].SetActive(false);
        activeDamageLocks[1].SetActive(true); activeDamageIcons[1].SetActive(false);
        activeDamageLocks[2].SetActive(true); activeDamageIcons[2].SetActive(false);
        activeDamageLocks[3].SetActive(true); activeDamageIcons[3].SetActive(false);
        activeDamageLocks[4].SetActive(true); activeDamageIcons[4].SetActive(false);
        activeDamageLocks[5].SetActive(true); activeDamageIcons[5].SetActive(false);

        activeCursorLocks[0].SetActive(true); activeCursorIcons[0].SetActive(false);
        activeCursorLocks[1].SetActive(true); activeCursorIcons[1].SetActive(false);
        activeCursorLocks[2].SetActive(true); activeCursorIcons[2].SetActive(false);

        autoClickerLocks[0].SetActive(true); autoClickerIcons[0].SetActive(false);
        autoClickerLocks[1].SetActive(true); autoClickerIcons[1].SetActive(false);
        autoClickerLocks[2].SetActive(true); autoClickerIcons[2].SetActive(false);

        autoDamageLocks[0].SetActive(true); autoDamageIcons[0].SetActive(false);
        autoDamageLocks[1].SetActive(true); autoDamageIcons[1].SetActive(false);
        autoDamageLocks[2].SetActive(true); autoDamageIcons[2].SetActive(false);
        autoDamageLocks[3].SetActive(true); autoDamageIcons[3].SetActive(false);
        autoDamageLocks[4].SetActive(true); autoDamageIcons[4].SetActive(false);
        autoDamageLocks[5].SetActive(true); autoDamageIcons[5].SetActive(false);
        autoDamageLocks[6].SetActive(true); autoDamageIcons[6].SetActive(false);

        autoCursorLocks[0].SetActive(true); autoCursorsIcons[0].SetActive(false);
        autoCursorLocks[1].SetActive(true); autoCursorsIcons[1].SetActive(false);
        autoCursorLocks[2].SetActive(true); autoCursorsIcons[2].SetActive(false);
        autoCursorLocks[3].SetActive(true); autoCursorsIcons[3].SetActive(false);

        goldLockes[0].SetActive(true); goldIcons[0].SetActive(false);
        goldLockes[1].SetActive(true); goldIcons[1].SetActive(false);
        goldLockes[2].SetActive(true); goldIcons[2].SetActive(false);
        goldLockes[3].SetActive(true); goldIcons[3].SetActive(false);
        goldLockes[4].SetActive(true); goldIcons[4].SetActive(false);
        goldLockes[5].SetActive(true); goldIcons[5].SetActive(false);
        goldLockes[6].SetActive(true); goldIcons[6].SetActive(false);
        goldLockes[7].SetActive(true); goldIcons[7].SetActive(false);

        dropsLockes[0].SetActive(true); dropsIcons[0].SetActive(false);
        dropsLockes[1].SetActive(true); dropsIcons[1].SetActive(false);
        dropsLockes[2].SetActive(true); dropsIcons[2].SetActive(false);
        dropsLockes[3].SetActive(true); dropsIcons[3].SetActive(false);
        dropsLockes[4].SetActive(true); dropsIcons[4].SetActive(false);
        dropsLockes[5].SetActive(true); dropsIcons[5].SetActive(false);

        xpLockes[0].SetActive(true); xpIcons[0].SetActive(false);
        xpLockes[1].SetActive(true); xpIcons[1].SetActive(false);
        xpLockes[2].SetActive(true); xpIcons[2].SetActive(false);
        xpLockes[3].SetActive(true); xpIcons[3].SetActive(false);
        xpLockes[4].SetActive(true); xpIcons[4].SetActive(false);
        xpLockes[5].SetActive(true); xpIcons[5].SetActive(false);
        xpLockes[6].SetActive(true); xpIcons[6].SetActive(false);

        levelSpecialLockes[0].SetActive(true); levelSpecialIcons[0].SetActive(false);
        levelSpecialLockes[1].SetActive(true); levelSpecialIcons[1].SetActive(false);
        levelSpecialLockes[2].SetActive(true); levelSpecialIcons[2].SetActive(false);
        levelSpecialLockes[3].SetActive(true); levelSpecialIcons[3].SetActive(false);

        strongerSpecialLockes[0].SetActive(true); strongerSpecialIcons[0].SetActive(false);
        strongerSpecialLockes[1].SetActive(true); strongerSpecialIcons[1].SetActive(false);
        strongerSpecialLockes[2].SetActive(true); strongerSpecialIcons[2].SetActive(false);
        strongerSpecialLockes[3].SetActive(true); strongerSpecialIcons[3].SetActive(false);
        strongerSpecialLockes[4].SetActive(true); strongerSpecialIcons[4].SetActive(false);
        strongerSpecialLockes[5].SetActive(true); strongerSpecialIcons[5].SetActive(false);

        startWithItemLockes[0].SetActive(true); startWithItemIcons[0].SetActive(false);
        startWithItemLockes[1].SetActive(true); startWithItemIcons[1].SetActive(false);
        startWithItemLockes[2].SetActive(true); startWithItemIcons[2].SetActive(false);

        Color newColorBasic;
        ColorUtility.TryParseHtmlString(basicHexValue, out newColorBasic);

        critUpgrade[0].GetComponent<Image>().color = newColorBasic;
        critUpgrade[1].GetComponent<Image>().color = newColorBasic;
        critUpgrade[2].GetComponent<Image>().color = newColorBasic;
        critUpgrade[3].GetComponent<Image>().color = newColorBasic;
        critUpgrade[4].GetComponent<Image>().color = newColorBasic;

        activeDamageUpgrade[0].GetComponent<Image>().color = newColorBasic;
        activeDamageUpgrade[1].GetComponent<Image>().color = newColorBasic;
        activeDamageUpgrade[2].GetComponent<Image>().color = newColorBasic;
        activeDamageUpgrade[3].GetComponent<Image>().color = newColorBasic;
        activeDamageUpgrade[4].GetComponent<Image>().color = newColorBasic;
        activeDamageUpgrade[5].GetComponent<Image>().color = newColorBasic;
        activeDamageUpgrade[6].GetComponent<Image>().color = newColorBasic;

        activeCursorUpgrades[0].GetComponent<Image>().color = newColorBasic;
        activeCursorUpgrades[1].GetComponent<Image>().color = newColorBasic;
        activeCursorUpgrades[2].GetComponent<Image>().color = newColorBasic;
        activeCursorUpgrades[3].GetComponent<Image>().color = newColorBasic;

        autoClickerUpgrades[0].GetComponent<Image>().color = newColorBasic;
        autoClickerUpgrades[1].GetComponent<Image>().color = newColorBasic;
        autoClickerUpgrades[2].GetComponent<Image>().color = newColorBasic;
        autoClickerUpgrades[3].GetComponent<Image>().color = newColorBasic;

        autoDamageUpgrades[0].GetComponent<Image>().color = newColorBasic;
        autoDamageUpgrades[1].GetComponent<Image>().color = newColorBasic;
        autoDamageUpgrades[2].GetComponent<Image>().color = newColorBasic;
        autoDamageUpgrades[3].GetComponent<Image>().color = newColorBasic;
        autoDamageUpgrades[4].GetComponent<Image>().color = newColorBasic;
        autoDamageUpgrades[5].GetComponent<Image>().color = newColorBasic;
        autoDamageUpgrades[6].GetComponent<Image>().color = newColorBasic;
        autoDamageUpgrades[7].GetComponent<Image>().color = newColorBasic;

        autoCursorUpgrades[0].GetComponent<Image>().color = newColorBasic;
        autoCursorUpgrades[1].GetComponent<Image>().color = newColorBasic;
        autoCursorUpgrades[2].GetComponent<Image>().color = newColorBasic;
        autoCursorUpgrades[3].GetComponent<Image>().color = newColorBasic;

        goldUpgrades[0].GetComponent<Image>().color = newColorBasic;
        goldUpgrades[1].GetComponent<Image>().color = newColorBasic;
        goldUpgrades[2].GetComponent<Image>().color = newColorBasic;
        goldUpgrades[3].GetComponent<Image>().color = newColorBasic;
        goldUpgrades[4].GetComponent<Image>().color = newColorBasic;
        goldUpgrades[5].GetComponent<Image>().color = newColorBasic;
        goldUpgrades[6].GetComponent<Image>().color = newColorBasic;
        goldUpgrades[7].GetComponent<Image>().color = newColorBasic;
        goldUpgrades[8].GetComponent<Image>().color = newColorBasic;

        dropsUpgrades[0].GetComponent<Image>().color = newColorBasic;
        dropsUpgrades[1].GetComponent<Image>().color = newColorBasic;
        dropsUpgrades[2].GetComponent<Image>().color = newColorBasic;
        dropsUpgrades[3].GetComponent<Image>().color = newColorBasic;
        dropsUpgrades[4].GetComponent<Image>().color = newColorBasic;
        dropsUpgrades[5].GetComponent<Image>().color = newColorBasic;
        dropsUpgrades[6].GetComponent<Image>().color = newColorBasic;

        xpUpgrades[0].GetComponent<Image>().color = newColorBasic;
        xpUpgrades[1].GetComponent<Image>().color = newColorBasic;
        xpUpgrades[2].GetComponent<Image>().color = newColorBasic;
        xpUpgrades[3].GetComponent<Image>().color = newColorBasic;
        xpUpgrades[4].GetComponent<Image>().color = newColorBasic;
        xpUpgrades[5].GetComponent<Image>().color = newColorBasic;
        xpUpgrades[6].GetComponent<Image>().color = newColorBasic;
        xpUpgrades[7].GetComponent<Image>().color = newColorBasic;

        levelSpecialUpgrades[0].GetComponent<Image>().color = newColorBasic;
        levelSpecialUpgrades[1].GetComponent<Image>().color = newColorBasic;
        levelSpecialUpgrades[2].GetComponent<Image>().color = newColorBasic;
        levelSpecialUpgrades[3].GetComponent<Image>().color = newColorBasic;
        levelSpecialUpgrades[4].GetComponent<Image>().color = newColorBasic;

        strongerSpecialUpgrades[0].GetComponent<Image>().color = newColorBasic;
        strongerSpecialUpgrades[1].GetComponent<Image>().color = newColorBasic;
        strongerSpecialUpgrades[2].GetComponent<Image>().color = newColorBasic;
        strongerSpecialUpgrades[3].GetComponent<Image>().color = newColorBasic;
        strongerSpecialUpgrades[4].GetComponent<Image>().color = newColorBasic;
        strongerSpecialUpgrades[5].GetComponent<Image>().color = newColorBasic;
        strongerSpecialUpgrades[6].GetComponent<Image>().color = newColorBasic;

        startWithItemUpgrades[0].GetComponent<Image>().color = newColorBasic;
        startWithItemUpgrades[1].GetComponent<Image>().color = newColorBasic;
        startWithItemUpgrades[2].GetComponent<Image>().color = newColorBasic;
        startWithItemUpgrades[3].GetComponent<Image>().color = newColorBasic;

        SetAlphaHalf(critUpgrade[0], alphaHalf);
        SetAlphaHalf(critUpgrade[1], alphaHalf);
        SetAlphaHalf(critUpgrade[2], alphaHalf);
        SetAlphaHalf(critUpgrade[3], alphaHalf);
        SetAlphaHalf(critUpgrade[4], alphaHalf);

        SetAlphaHalf(activeDamageUpgrade[0], alphaHalf);
        SetAlphaHalf(activeDamageUpgrade[1], alphaHalf);
        SetAlphaHalf(activeDamageUpgrade[2], alphaHalf);
        SetAlphaHalf(activeDamageUpgrade[3], alphaHalf);
        SetAlphaHalf(activeDamageUpgrade[4], alphaHalf);
        SetAlphaHalf(activeDamageUpgrade[5], alphaHalf);
        SetAlphaHalf(activeDamageUpgrade[6], alphaHalf);

        SetAlphaHalf(activeCursorUpgrades[0], alphaHalf);
        SetAlphaHalf(activeCursorUpgrades[1], alphaHalf);
        SetAlphaHalf(activeCursorUpgrades[2], alphaHalf);
        SetAlphaHalf(activeCursorUpgrades[3], alphaHalf);

        SetAlphaHalf(autoClickerUpgrades[0], alphaHalf);
        SetAlphaHalf(autoClickerUpgrades[1], alphaHalf);
        SetAlphaHalf(autoClickerUpgrades[2], alphaHalf);
        SetAlphaHalf(autoClickerUpgrades[3], alphaHalf);

        SetAlphaHalf(autoDamageUpgrades[0], alphaHalf);
        SetAlphaHalf(autoDamageUpgrades[1], alphaHalf);
        SetAlphaHalf(autoDamageUpgrades[2], alphaHalf);
        SetAlphaHalf(autoDamageUpgrades[3], alphaHalf);
        SetAlphaHalf(autoDamageUpgrades[4], alphaHalf);
        SetAlphaHalf(autoDamageUpgrades[5], alphaHalf);
        SetAlphaHalf(autoDamageUpgrades[6], alphaHalf);
        SetAlphaHalf(autoDamageUpgrades[7], alphaHalf);

        SetAlphaHalf(autoCursorUpgrades[0], alphaHalf);
        SetAlphaHalf(autoCursorUpgrades[1], alphaHalf);
        SetAlphaHalf(autoCursorUpgrades[2], alphaHalf);
        SetAlphaHalf(autoCursorUpgrades[3], alphaHalf);
        SetAlphaHalf(autoCursorUpgrades[4], alphaHalf);

        SetAlphaHalf(goldUpgrades[0], alphaHalf);
        SetAlphaHalf(goldUpgrades[1], alphaHalf);
        SetAlphaHalf(goldUpgrades[2], alphaHalf);
        SetAlphaHalf(goldUpgrades[3], alphaHalf);
        SetAlphaHalf(goldUpgrades[4], alphaHalf);
        SetAlphaHalf(goldUpgrades[5], alphaHalf);
        SetAlphaHalf(goldUpgrades[6], alphaHalf);
        SetAlphaHalf(goldUpgrades[7], alphaHalf);
        SetAlphaHalf(goldUpgrades[8], alphaHalf);

        SetAlphaHalf(dropsUpgrades[0], alphaHalf);
        SetAlphaHalf(dropsUpgrades[1], alphaHalf);
        SetAlphaHalf(dropsUpgrades[2], alphaHalf);
        SetAlphaHalf(dropsUpgrades[3], alphaHalf);
        SetAlphaHalf(dropsUpgrades[4], alphaHalf);
        SetAlphaHalf(dropsUpgrades[5], alphaHalf);
        SetAlphaHalf(dropsUpgrades[6], alphaHalf);

        SetAlphaHalf(xpUpgrades[0], alphaHalf);
        SetAlphaHalf(xpUpgrades[1], alphaHalf);
        SetAlphaHalf(xpUpgrades[2], alphaHalf);
        SetAlphaHalf(xpUpgrades[3], alphaHalf);
        SetAlphaHalf(xpUpgrades[4], alphaHalf);
        SetAlphaHalf(xpUpgrades[5], alphaHalf);
        SetAlphaHalf(xpUpgrades[6], alphaHalf);
        SetAlphaHalf(xpUpgrades[7], alphaHalf);

        SetAlphaHalf(levelSpecialUpgrades[0], alphaHalf);
        SetAlphaHalf(levelSpecialUpgrades[1], alphaHalf);
        SetAlphaHalf(levelSpecialUpgrades[2], alphaHalf);
        SetAlphaHalf(levelSpecialUpgrades[3], alphaHalf);
        SetAlphaHalf(levelSpecialUpgrades[4], alphaHalf);

        SetAlphaHalf(strongerSpecialUpgrades[0], alphaHalf);
        SetAlphaHalf(strongerSpecialUpgrades[1], alphaHalf);
        SetAlphaHalf(strongerSpecialUpgrades[2], alphaHalf);
        SetAlphaHalf(strongerSpecialUpgrades[3], alphaHalf);
        SetAlphaHalf(strongerSpecialUpgrades[4], alphaHalf);
        SetAlphaHalf(strongerSpecialUpgrades[5], alphaHalf);
        SetAlphaHalf(strongerSpecialUpgrades[6], alphaHalf);

        SetAlphaHalf(startWithItemUpgrades[0], alphaHalf);
        SetAlphaHalf(startWithItemUpgrades[1], alphaHalf);
        SetAlphaHalf(startWithItemUpgrades[2], alphaHalf);
        SetAlphaHalf(startWithItemUpgrades[3], alphaHalf);

        critButtons[0].interactable = true;
        critButtons[1].interactable = true;
        critButtons[2].interactable = true;
        critButtons[3].interactable = true;
        critButtons[4].interactable = true;

        activeButtons[0].interactable = true;
        activeButtons[1].interactable = true;
        activeButtons[2].interactable = true;
        activeButtons[3].interactable = true;
        activeButtons[4].interactable = true;
        activeButtons[5].interactable = true;
        activeButtons[6].interactable = true;

        activeCursorsButtons[0].interactable = true;
        activeCursorsButtons[1].interactable = true;
        activeCursorsButtons[2].interactable = true;
        activeCursorsButtons[3].interactable = true;

        autoClickerButtons[0].interactable = true;
        autoClickerButtons[1].interactable = true;
        autoClickerButtons[2].interactable = true;
        autoClickerButtons[3].interactable = true;

        passiveButtons[0].interactable = true;
        passiveButtons[1].interactable = true;
        passiveButtons[2].interactable = true;
        passiveButtons[3].interactable = true;
        passiveButtons[4].interactable = true;
        passiveButtons[5].interactable = true;
        passiveButtons[6].interactable = true;
        passiveButtons[7].interactable = true;

        passiveCursorButtons[0].interactable = true;
        passiveCursorButtons[1].interactable = true;
        passiveCursorButtons[2].interactable = true;
        passiveCursorButtons[3].interactable = true;
        passiveCursorButtons[4].interactable = true;

        goldButtons[0].interactable = true;
        goldButtons[1].interactable = true;
        goldButtons[2].interactable = true;
        goldButtons[3].interactable = true;
        goldButtons[4].interactable = true;
        goldButtons[5].interactable = true;
        goldButtons[6].interactable = true;
        goldButtons[7].interactable = true;
        goldButtons[8].interactable = true;

        dropsButtons[0].interactable = true;
        dropsButtons[1].interactable = true;
        dropsButtons[2].interactable = true;
        dropsButtons[3].interactable = true;
        dropsButtons[4].interactable = true;
        dropsButtons[5].interactable = true;
        dropsButtons[6].interactable = true;

        XPButtons[0].interactable = true;
        XPButtons[1].interactable = true;
        XPButtons[2].interactable = true;
        XPButtons[3].interactable = true;
        XPButtons[4].interactable = true;
        XPButtons[5].interactable = true;
        XPButtons[6].interactable = true;
        XPButtons[7].interactable = true;

        levelUpSpecialButtons[0].interactable = true;
        levelUpSpecialButtons[1].interactable = true;
        levelUpSpecialButtons[2].interactable = true;
        levelUpSpecialButtons[3].interactable = true;
        levelUpSpecialButtons[4].interactable = true;

        strongerSpecialButtons[0].interactable = true;
        strongerSpecialButtons[1].interactable = true;
        strongerSpecialButtons[2].interactable = true;
        strongerSpecialButtons[3].interactable = true;
        strongerSpecialButtons[4].interactable = true;
        strongerSpecialButtons[5].interactable = true;
        strongerSpecialButtons[6].interactable = true;

        startWithButtons[0].interactable = true;
        startWithButtons[1].interactable = true;
        startWithButtons[2].interactable = true;
        startWithButtons[3].interactable = true;

        critUnlocked[0].SetActive(false);
        critUnlocked[1].SetActive(false);
        critUnlocked[2].SetActive(false);
        critUnlocked[3].SetActive(false);
        critUnlocked[4].SetActive(false);

        activeUnlocked[0].SetActive(false);
        activeUnlocked[1].SetActive(false);
        activeUnlocked[2].SetActive(false);
        activeUnlocked[3].SetActive(false);
        activeUnlocked[4].SetActive(false);
        activeUnlocked[5].SetActive(false);
        activeUnlocked[6].SetActive(false);

        activeCursorUnlocked[0].SetActive(false);
        activeCursorUnlocked[1].SetActive(false);
        activeCursorUnlocked[2].SetActive(false);
        activeCursorUnlocked[3].SetActive(false);

        autoClickerUnlocked[0].SetActive(false);
        autoClickerUnlocked[1].SetActive(false);
        autoClickerUnlocked[2].SetActive(false);
        autoClickerUnlocked[3].SetActive(false);

        passiveUnlocked[0].SetActive(false);
        passiveUnlocked[1].SetActive(false);
        passiveUnlocked[2].SetActive(false);
        passiveUnlocked[3].SetActive(false);
        passiveUnlocked[4].SetActive(false);
        passiveUnlocked[5].SetActive(false);
        passiveUnlocked[6].SetActive(false);
        passiveUnlocked[7].SetActive(false);

        passiveCursorUnlocked[0].SetActive(false);
        passiveCursorUnlocked[1].SetActive(false);
        passiveCursorUnlocked[2].SetActive(false);
        passiveCursorUnlocked[3].SetActive(false);
        passiveCursorUnlocked[4].SetActive(false);

        goldUnlocked[0].SetActive(false);
        goldUnlocked[1].SetActive(false);
        goldUnlocked[2].SetActive(false);
        goldUnlocked[3].SetActive(false);
        goldUnlocked[4].SetActive(false);
        goldUnlocked[5].SetActive(false);
        goldUnlocked[6].SetActive(false);
        goldUnlocked[7].SetActive(false);
        goldUnlocked[8].SetActive(false);

        treasureUnlocked[0].SetActive(false);
        treasureUnlocked[1].SetActive(false);
        treasureUnlocked[2].SetActive(false);
        treasureUnlocked[3].SetActive(false);
        treasureUnlocked[4].SetActive(false);
        treasureUnlocked[5].SetActive(false);
        treasureUnlocked[6].SetActive(false);

        XPUnlocked[0].SetActive(false);
        XPUnlocked[1].SetActive(false);
        XPUnlocked[2].SetActive(false);
        XPUnlocked[3].SetActive(false);
        XPUnlocked[4].SetActive(false);
        XPUnlocked[5].SetActive(false);
        XPUnlocked[6].SetActive(false);
        XPUnlocked[7].SetActive(false);

        levelUpSpecialUnlocked[0].SetActive(false);
        levelUpSpecialUnlocked[1].SetActive(false);
        levelUpSpecialUnlocked[2].SetActive(false);
        levelUpSpecialUnlocked[3].SetActive(false);
        levelUpSpecialUnlocked[4].SetActive(false);

        strongerSpecialUnlocked[0].SetActive(false);
        strongerSpecialUnlocked[1].SetActive(false);
        strongerSpecialUnlocked[2].SetActive(false);
        strongerSpecialUnlocked[3].SetActive(false);
        strongerSpecialUnlocked[4].SetActive(false);
        strongerSpecialUnlocked[5].SetActive(false);
        strongerSpecialUnlocked[6].SetActive(false);

        startWitchUnlcoked[0].SetActive(false);
        startWitchUnlcoked[1].SetActive(false);
        startWitchUnlcoked[2].SetActive(false);
        startWitchUnlcoked[3].SetActive(false);
        #endregion
    }

}
