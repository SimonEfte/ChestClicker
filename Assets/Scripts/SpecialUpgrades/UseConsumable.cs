using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class UseConsumable : MonoBehaviour, IDataPersistence
{

    public static int KeysCount;
    public TextMeshProUGUI keysAmountText;
    public static bool keyActive;
    public GameObject key;

    public static int goldenTouchCount;
    public TextMeshProUGUI goldenTouchCountText;

    public static int lockPickCount;
    public static float lockPickSuccessChance;
    public TextMeshProUGUI lockPickCountText;
    public GameObject lockPick;

    public static bool bigHammerActive;
    public GameObject bigHammer;
    public static float hammerDamageMultiplier;
    public static float hammerDamage;
    public static int hammerCount;
    public TextMeshProUGUI hammerCountText;

    public GameObject glow;
    public static bool goldenTouchActive;

    public TextMeshProUGUI treasureBagCountText;
    public static int treasureBagCount;

    public TextMeshProUGUI XPPotionCountText;
    public static int XPPotionCount;

    public TextMeshProUGUI damagePotionCountText;
    public static int damagePotioncount;

    public TextMeshProUGUI lootPotionCountText;
    public static int lootPotionCount;

    public TextMeshProUGUI elixirCountText;
    public static int elixirCount;

    public TextMeshProUGUI scrollCountText;
    public static int scrollCount;

    public TextMeshProUGUI gauntletCountText;
    public static int gauntletCount;

    public TextMeshProUGUI relicCountText;
    public static int relicCount;

    public Button lockPickButton, hammerButton, keyButton, goldenTouchButton, lootPotionButton, damagePotionButton, XPPotionButton, treasureBagButton;
    public Button elixirButton, scrollButton, gauntletButton, relicButton;

    public Color originalColor;

    public GameObject lockPickUpgrade, keyUpgrade, hammerUpgrade, lootPotionUpgrade, gamagePotionUpgrade, XPPotionUpgrade, goldenTouchUpgrade, exlixirUpgrade, scrollUpgrade, gauntletUpgrade;
    public int lootPotionStack, damagePotionStack, XPPotionStack, elixirStack, hammerStack, goldenTouchStack, scrollStack, gauntletStack;
    public TextMeshProUGUI hammerStackText, goldenTouchStackText, scrollStackText, gauntletStackText;

    public GameObject itemsBar;
    public float textSize;

    public GameObject lootPotionBuffIcon, damagePotionBuffIcon, xpPotionBuffIcon, elixirBuffIcon, goldenTouchBuffIcon;
    public GameObject lootPotionBuffHover, damagePotionBuffHover, xpPotionBuffHover, elixirBuffHover, goldenTouchBuffHover;
    public TextMeshProUGUI lootPotionBuffText, damagePotionBuffText, xpPotionBuffText, elixirGoldBuffText, elixirDamageBuffText, elixirXPBuffText;
    public TextMeshProUGUI lootPotionBuffTimer, damagePotionBuffTimer, xpPotionBuffTimer, elixirBuffTextTimer, goldenTouchBuffTextTimer;

    public AudioManager audioManager;

    public void Start()
    {
        textSize = 1.8f;
        lootPotionDoubleValue = 0;
        treasureSpawnCount = 0;
        XPPotionCritChance = 0;
        XPPotionCritDamage = 0;

        originalColor = lockPickCountText.color;

        Invoke("wait", 0.4f);
    }

    public void wait()
    {
        string path = Application.persistentDataPath + "/player.saveConsumables";

        if (File.Exists(path))
        {
            if (SaveAndLoad.onlyLoadNewSave == false)
            {
                GameData data = SaveSystem.LoadConsumables();
                KeysCount = data.keysCount;
                lockPickCount = data.lockPickCount;
                hammerCount = data.hammerCount;
                goldenTouchCount = data.goldenTouchCount;
                treasureBagCount = data.treasureBagCount;
                XPPotionCount = data.XPPotionCount;
                damagePotioncount = data.damagePotionCount;
                lootPotionCount = data.lootPotionCount;
                elixirCount = data.elixirCount;
                scrollCount = data.scrollCount;
                gauntletCount = data.gauntletCount;
                relicCount = data.relicCount;
                hammerDamageMultiplier = data.hammerDamageMultiplier;
                lockPickSuccessChance = data.lockPickSuccessChance;

                relicPermaActiveDamage = data.relicPermaActiveDamage;
                relicPermaPassiveDamage = data.relicPermaPassiveDamage;
                relicPermaCritDamage = data.relicPermaCritDamage;
                relicPermaCritChance = data.relicPermaCritChance;
                relicPermaGoldBuff = data.relicPermaGoldBuff;
                relicPermaTreasureBuff = data.relicPermaTreasureBuff;
                relicPermaXPBuff = data.relicPermaXPBuff;

                scrollActiveDamageBuff = data.scrollActiveDamageBuff;
                scrollPassiveDamageBuff = data.scrollPassiveDamageBuff;
                scrollCritChanceBuff = data.scrollCritChanceBuff;
                scrollCritDamageBuff = data.scrollCritDamageBuff;
                scrollGoldBuff = data.scrollGoldBuff;
                scrollXPBuff = data.scrollXPBuff;
                scrollTreasureBuff = data.scrollTreasureBuff;
            }
            else { }
        }
        else
        {
            //Do nothing
        }

        StartCoroutine(wait2());

        lootPotionStack = RareTreasures.lootPotionPillStack + SkillTree.skillTreeLootPotionStack + 1;
        damagePotionStack = RareTreasures.damagePotionPillStack + SkillTree.skillTreeDamagePotionStack + 1;
        XPPotionStack = RareTreasures.XPPotionPillStack + SkillTree.skillTreeXPPotionStack + 1;
        elixirStack = RareTreasures.elixirPillStack + SkillTree.skillTreeElixirStack + 1;

        if(SkillTree.strongerSpecial6Bought == 1)
        {
            hammerStack = 2;
            goldenTouchStack = 2;
            scrollStack = 2;
            gauntletStack = 2;
        }

        if (SkillTree.strongerSpecial6Bought != 1)
        {
            hammerStack = 1;
            goldenTouchStack = 1;
            scrollStack = 1;
            gauntletStack = 1;
        }

        hammerStackText.text =  "";
        goldenTouchStackText.text = "";
        scrollStackText.text = "";
        gauntletStackText.text = "";

        lootPotionStackText.text = "";
        damagePotionStackText.text = "";
        XPPotionStackText.text = "";
        ElixirStackText.text = "";
    }


    #region SaveAndLoadJSON
    public void LoadData(GameDataJSON data)
    {
        KeysCount = data.keysCount;
        lockPickCount = data.lockPickCount;
        hammerCount = data.hammerCount;
        goldenTouchCount = data.goldenTouchCount;
        treasureBagCount = data.treasureBagCount;
        XPPotionCount = data.XPPotionCount;
        damagePotioncount = data.damagePotionCount;
        lootPotionCount = data.lootPotionCount;
        elixirCount = data.elixirCount;
        scrollCount = data.scrollCount;
        gauntletCount = data.gauntletCount;
        relicCount = data.relicCount;
        hammerDamageMultiplier = data.hammerDamageMultiplier;
        lockPickSuccessChance = data.lockPickSuccessChance;

        relicPermaActiveDamage = data.relicPermaActiveDamage;
        relicPermaPassiveDamage = data.relicPermaPassiveDamage;
        relicPermaCritDamage = data.relicPermaCritDamage;
        relicPermaCritChance = data.relicPermaCritChance;
        relicPermaGoldBuff = data.relicPermaGoldBuff;
        relicPermaTreasureBuff = data.relicPermaTreasureBuff;
        relicPermaXPBuff = data.relicPermaXPBuff;

        scrollActiveDamageBuff = data.scrollActiveDamageBuff;
        scrollPassiveDamageBuff = data.scrollPassiveDamageBuff;
        scrollCritChanceBuff = data.scrollCritChanceBuff;
        scrollCritDamageBuff = data.scrollCritDamageBuff;
        scrollGoldBuff = data.scrollGoldBuff;
        scrollXPBuff = data.scrollXPBuff;
        scrollTreasureBuff = data.scrollTreasureBuff;
    }

    public void SaveData(ref GameDataJSON data)
    {
        data.keysCount = KeysCount;
        data.lockPickCount = lockPickCount;
        data.hammerCount = hammerCount;
        data.goldenTouchCount = goldenTouchCount;
        data.treasureBagCount = treasureBagCount;
        data.XPPotionCount = XPPotionCount;
        data.damagePotionCount = damagePotioncount;
        data.lootPotionCount = lootPotionCount;
        data.elixirCount = elixirCount;
        data.scrollCount = scrollCount;
        data.gauntletCount = gauntletCount;
        data.relicCount = relicCount;
        data.hammerDamageMultiplier = hammerDamageMultiplier;
        data.lockPickSuccessChance = lockPickSuccessChance;

        data.relicPermaActiveDamage = relicPermaActiveDamage;
        data.relicPermaPassiveDamage = relicPermaPassiveDamage;
        data.relicPermaCritDamage = relicPermaCritDamage;
        data.relicPermaCritChance = relicPermaCritChance;
        data.relicPermaGoldBuff = relicPermaGoldBuff;
        data.relicPermaTreasureBuff = relicPermaTreasureBuff;
        data.relicPermaXPBuff = relicPermaXPBuff;

        data.scrollActiveDamageBuff = scrollActiveDamageBuff;
        data.scrollPassiveDamageBuff = scrollPassiveDamageBuff;
        data.scrollCritChanceBuff = scrollCritChanceBuff;
        data.scrollCritDamageBuff = scrollCritDamageBuff;
        data.scrollGoldBuff = scrollGoldBuff;
        data.scrollXPBuff = scrollXPBuff;
        data.scrollTreasureBuff = scrollTreasureBuff;
    }
    #endregion


    public static bool blockBarSet;
    public static bool potionStack, lootPotionEnded, damagePotionEnded, XPpotionEnded, elixirPotionEnded, hammerEnded, goldenTouchEnded, scrollEnded, gauntletEnded;

    public void Update()
    {
        if(potionStack == true)
        {
            lootPotionStack = RareTreasures.lootPotionPillStack + SkillTree.skillTreeLootPotionStack + 1;
            damagePotionStack = RareTreasures.damagePotionPillStack + SkillTree.skillTreeDamagePotionStack + 1;
            XPPotionStack = RareTreasures.XPPotionPillStack + SkillTree.skillTreeXPPotionStack + 1;
            elixirStack = RareTreasures.elixirPillStack + SkillTree.skillTreeElixirStack + 1;
            hammerStack = 2;
            goldenTouchStack = 2;
            scrollStack = 2;
            gauntletStack = 2;
            potionStack = false;
        }

        if(lootPotionEnded == true)
        {
            lootPotionStack = RareTreasures.lootPotionPillStack + SkillTree.skillTreeLootPotionStack + 1;
            lootPotionEnded = false;
        }

        if (damagePotionEnded == true)
        {
            damagePotionStack = RareTreasures.damagePotionPillStack + SkillTree.skillTreeDamagePotionStack + 1;
            damagePotionEnded = false;
        }

        if (XPpotionEnded == true)
        {
            XPPotionStack = RareTreasures.XPPotionPillStack + SkillTree.skillTreeXPPotionStack + 1;
            XPpotionEnded = false;
        }

        if (elixirPotionEnded == true)
        {
            elixirStack = RareTreasures.elixirPillStack + SkillTree.skillTreeElixirStack + 1;
            elixirPotionEnded = false;
        }

        if(hammerEnded == true)
        {
            if (SkillTree.strongerSpecial6Bought == 1) { hammerStack = 2; }
            if(SkillTree.strongerSpecial6Bought != 1) { hammerStack = 1; }
            hammerEnded = false;
        }

        if (goldenTouchEnded == true)
        {
            if (SkillTree.strongerSpecial6Bought == 1) { goldenTouchStack = 2; }
            if (SkillTree.strongerSpecial6Bought != 1) { goldenTouchStack = 1; }
            goldenTouchEnded = false;
        }

        if (scrollEnded == true)
        {
            if (SkillTree.strongerSpecial6Bought == 1) { scrollStack = 2; }
            if (SkillTree.strongerSpecial6Bought != 1) { scrollStack = 1; }
            
            scrollEnded = false;
        }

        if (gauntletEnded == true)
        {
            if (SkillTree.strongerSpecial6Bought == 1) { gauntletStack = 2; }
            if (SkillTree.strongerSpecial6Bought != 1) { gauntletStack = 1; }
           
            gauntletEnded = false;
        }


     

        if (SpecialUpgradesButtons.specialTextChange == true)
        {
            lockPickCountText.text = "" + lockPickCount;
            keysAmountText.text = "" + KeysCount;
            hammerCountText.text = "" + hammerCount;
            goldenTouchCountText.text = "" + goldenTouchCount;
            treasureBagCountText.text = "" + treasureBagCount;
            XPPotionCountText.text = "" + XPPotionCount;
            lootPotionCountText.text = "" + lootPotionCount;
            damagePotionCountText.text = "" + damagePotioncount;
            elixirCountText.text = "" + elixirCount;
            scrollCountText.text = "" + scrollCount;
            gauntletCountText.text = "" + gauntletCount;
            relicCountText.text = "" + relicCount;

            #region equal0RedColor
            if (SpecialUpgradesButtons.lockPickBoughtFirstTime == 1)
            {
                if (lockPickCount == 0) { lockPickCountText.color = Color.red; }
                if (lockPickCount > 0) { lockPickCountText.color = originalColor; }
            }
            if (SpecialUpgradesButtons.hammerBoughtFirstTime == 1)
            {
                if (hammerCount == 0) { hammerCountText.color = Color.red; }
                if (hammerCount > 0) { hammerCountText.color = originalColor; }
            }
            if (SpecialUpgradesButtons.lootPotionBoughtFirstTime == 1)
            {
                if (lootPotionCount == 0) { lootPotionCountText.color = Color.red; }
                if (lootPotionCount > 0) { lootPotionCountText.color = originalColor; }
            }
            if (SpecialUpgradesButtons.damagePotionBoughtFirstTime == 1)
            {
                if (damagePotioncount == 0) { damagePotionCountText.color = Color.red; }
                if (damagePotioncount > 0) { damagePotionCountText.color = originalColor; }
            }
            if (SpecialUpgradesButtons.XPPotionBoughtFirstTime == 1)
            {
                if (XPPotionCount == 0) { XPPotionCountText.color = Color.red; }
                if (XPPotionCount > 0) { XPPotionCountText.color = originalColor; }
            }
            if (SpecialUpgradesButtons.goldenTouchBoughtFirstTime == 1)
            {
                if (goldenTouchCount == 0) { goldenTouchCountText.color = Color.red; }
                if (goldenTouchCount > 0) { goldenTouchCountText.color = originalColor; }
            }
            if (SpecialUpgradesButtons.keyBoughtFirstTime == 1)
            {
                if (KeysCount == 0) { keysAmountText.color = Color.red; }
                if (KeysCount > 0) { keysAmountText.color = originalColor; }
            }
            if (SpecialUpgradesButtons.treasureBagBoughtFirstTime == 1)
            {
                if (treasureBagCount == 0) { treasureBagCountText.color = Color.red; }
                if (treasureBagCount > 0) { treasureBagCountText.color = originalColor; }
            }
            if (SpecialUpgradesButtons.scrollBoughtFirstTime == 1)
            {
                if (scrollCount == 0) { scrollCountText.color = Color.red; }
                if (scrollCount > 0) { scrollCountText.color = originalColor; }
            }
            if (SpecialUpgradesButtons.gauntletBoughtFirstTime == 1)
            {
                if (gauntletCount == 0) { gauntletCountText.color = Color.red; }
                if (gauntletCount > 0) { gauntletCountText.color = originalColor; }
            }
            if (SpecialUpgradesButtons.elixirBoughtFirstTime == 1)
            {
                if (elixirCount == 0) { elixirCountText.color = Color.red; }
                if (elixirCount > 0) { elixirCountText.color = originalColor; }
            }
            if (SpecialUpgradesButtons.relicBoughtFirstTime == 1)
            {
                if (relicCount == 0) { relicCountText.color = Color.red; }
                if (relicCount > 0) { relicCountText.color = originalColor; }
            }
            #endregion

            SpecialUpgradesButtons.specialTextChange = false;

            if (lockPickCount == 0) { ChangeButtonPressedColor(lockPickButton, Color.red); }
            if (lockPickCount > 0) { ChangeButtonPressedColor(lockPickButton, Color.white); }

            if (hammerCount == 0) { ChangeButtonPressedColor(hammerButton, Color.red); }
            if (hammerCount > 0) { ChangeButtonPressedColor(hammerButton, Color.white); }

            if (KeysCount == 0) { ChangeButtonPressedColor(keyButton, Color.red); }
            if (KeysCount > 0) { ChangeButtonPressedColor(keyButton, Color.white); }

            if (goldenTouchCount == 0) { ChangeButtonPressedColor(goldenTouchButton, Color.red); }
            if (goldenTouchCount > 0) { ChangeButtonPressedColor(goldenTouchButton, Color.white); }

            if (lootPotionCount == 0) { ChangeButtonPressedColor(lootPotionButton, Color.red); }
            if (lootPotionCount > 0) { ChangeButtonPressedColor(lootPotionButton, Color.white); }

            if (damagePotioncount == 0) { ChangeButtonPressedColor(damagePotionButton, Color.red); }
            if (damagePotioncount > 0) { ChangeButtonPressedColor(damagePotionButton, Color.white); }

            if (XPPotionCount == 0) { ChangeButtonPressedColor(XPPotionButton, Color.red); }
            if (XPPotionCount > 0) { ChangeButtonPressedColor(XPPotionButton, Color.white); }

            if (treasureBagCount == 0) { ChangeButtonPressedColor(treasureBagButton, Color.red); }
            if (treasureBagCount > 0) { ChangeButtonPressedColor(treasureBagButton, Color.white); }

            if (elixirCount == 0) { ChangeButtonPressedColor(elixirButton, Color.red); }
            if (elixirCount > 0) { ChangeButtonPressedColor(elixirButton, Color.white); }

            if (scrollCount == 0) { ChangeButtonPressedColor(scrollButton, Color.red); }
            if (scrollCount > 0) { ChangeButtonPressedColor(scrollButton, Color.white); }

            if (gauntletCount == 0) { ChangeButtonPressedColor(gauntletButton, Color.red); }
            if (gauntletCount > 0) { ChangeButtonPressedColor(gauntletButton, Color.white); }

            if (relicCount == 0) { ChangeButtonPressedColor(relicButton, Color.red); }
            if (relicCount > 0) { ChangeButtonPressedColor(relicButton, Color.white); }
        }



        if (itemsBar.activeInHierarchy == true)
        {
            #region lockPickPopUp
            if (ReturnRedGem.setLockPick == true)
            {
                Sounds();
                GameObject itemsText = ObjectPooling.instance.GetGoldTextFromPool();
                itemsText.transform.SetParent(lockPickCountText.transform, false);
                itemsText.transform.position = lockPickCountText.transform.position;
                itemsText.transform.localScale = new Vector3(textSize, textSize, textSize);
                itemsText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isItemDouble == true) { itemsText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isItemDouble == false) { itemsText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(itemsText, 0.7f));

                ReturnRedGem.setLockPick = false;
            }
            #endregion

            #region hammerPopUp
            if (ReturnRedGem.setHammer == true)
            {
                Sounds();
                GameObject itemsText = ObjectPooling.instance.GetGoldTextFromPool();
                itemsText.transform.SetParent(hammerCountText.transform, false);
                itemsText.transform.position = hammerCountText.transform.position;
                itemsText.transform.localScale = new Vector3(textSize, textSize, textSize);
                itemsText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isItemDouble == true) { itemsText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isItemDouble == false) { itemsText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(itemsText, 0.7f));

                ReturnRedGem.setHammer = false;
            }
            #endregion

            #region lootPotionPopUp
            if (ReturnRedGem.setLootPotion == true)
            {
                Sounds();
                GameObject itemsText = ObjectPooling.instance.GetGoldTextFromPool();
                itemsText.transform.SetParent(lootPotionCountText.transform, false);
                itemsText.transform.position = lootPotionCountText.transform.position;
                itemsText.transform.localScale = new Vector3(textSize, textSize, textSize);
                itemsText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isItemDouble == true) { itemsText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isItemDouble == false) { itemsText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(itemsText, 0.7f));

                ReturnRedGem.setLootPotion = false;
            }
            #endregion

            #region damagePotionPopUp
            if (ReturnRedGem.setDamagePotion == true)
            {
                Sounds();
                GameObject itemsText = ObjectPooling.instance.GetGoldTextFromPool();
                itemsText.transform.SetParent(damagePotionCountText.transform, false);
                itemsText.transform.position = damagePotionCountText.transform.position;
                itemsText.transform.localScale = new Vector3(textSize, textSize, textSize);
                itemsText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isItemDouble == true) { itemsText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isItemDouble == false) { itemsText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(itemsText, 0.7f));

                ReturnRedGem.setDamagePotion = false;
            }
            #endregion

            #region XPPotionPopUp
            if (ReturnRedGem.setXPPotion == true)
            {
                Sounds();
                GameObject itemsText = ObjectPooling.instance.GetGoldTextFromPool();
                itemsText.transform.SetParent(XPPotionCountText.transform, false);
                itemsText.transform.position = XPPotionCountText.transform.position;
                itemsText.transform.localScale = new Vector3(textSize, textSize, textSize);
                itemsText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isItemDouble == true) { itemsText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isItemDouble == false) { itemsText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(itemsText, 0.7f));

                ReturnRedGem.setXPPotion = false;
            }
            #endregion

            #region goldenTouchPopUp
            if (ReturnRedGem.setGoldenTouch == true)
            {
                Sounds();
                GameObject itemsText = ObjectPooling.instance.GetGoldTextFromPool();
                itemsText.transform.SetParent(goldenTouchCountText.transform, false);
                itemsText.transform.position = goldenTouchCountText.transform.position;
                itemsText.transform.localScale = new Vector3(textSize, textSize, textSize);
                itemsText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isItemDouble == true) { itemsText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isItemDouble == false) { itemsText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(itemsText, 0.7f));

                ReturnRedGem.setGoldenTouch = false;
            }
            #endregion

            #region keyPopUp
            if (ReturnRedGem.setKey == true)
            {
                Sounds();
                GameObject itemsText = ObjectPooling.instance.GetGoldTextFromPool();
                itemsText.transform.SetParent(keysAmountText.transform, false);
                itemsText.transform.position = keysAmountText.transform.position;
                itemsText.transform.localScale = new Vector3(textSize, textSize, textSize);
                itemsText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isItemDouble == true) { itemsText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isItemDouble == false) { itemsText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(itemsText, 0.7f));

                ReturnRedGem.setKey = false;
            }
            #endregion

            #region scrollPopUp
            if (ReturnRedGem.setScroll == true)
            {
                Sounds();
                GameObject itemsText = ObjectPooling.instance.GetGoldTextFromPool();
                itemsText.transform.SetParent(scrollCountText.transform, false);
                itemsText.transform.position = scrollCountText.transform.position;
                itemsText.transform.localScale = new Vector3(textSize, textSize, textSize);
                itemsText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isItemDouble == true) { itemsText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isItemDouble == false) { itemsText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(itemsText, 0.7f));

                ReturnRedGem.setScroll = false;
            }
            #endregion

            #region gauntletPopUP
            if (ReturnRedGem.setGauntlet == true)
            {
                Sounds();
                GameObject itemsText = ObjectPooling.instance.GetGoldTextFromPool();
                itemsText.transform.SetParent(gauntletCountText.transform, false);
                itemsText.transform.position = gauntletCountText.transform.position;
                itemsText.transform.localScale = new Vector3(textSize, textSize, textSize);
                itemsText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isItemDouble == true) { itemsText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isItemDouble == false) { itemsText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(itemsText, 0.7f));

                ReturnRedGem.setGauntlet = false;
            }
            #endregion

            #region elixirPopUp
            if (ReturnRedGem.setElixir == true)
            {
                Sounds();
                GameObject itemsText = ObjectPooling.instance.GetGoldTextFromPool();
                itemsText.transform.SetParent(elixirCountText.transform, false);
                itemsText.transform.position = elixirCountText.transform.position;
                itemsText.transform.localScale = new Vector3(textSize, textSize, textSize);
                itemsText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isItemDouble == true) { itemsText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isItemDouble == false) { itemsText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(itemsText, 0.7f));

                ReturnRedGem.setElixir = false;
            }
            #endregion

            #region relicPopUp
            if (ReturnRedGem.setRelic == true)
            {
                Sounds();
                GameObject itemsText = ObjectPooling.instance.GetGoldTextFromPool();
                itemsText.transform.SetParent(relicCountText.transform, false);
                itemsText.transform.position = relicCountText.transform.position;
                itemsText.transform.localScale = new Vector3(textSize, textSize, textSize);
                itemsText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isItemDouble == true) { itemsText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isItemDouble == false) { itemsText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(itemsText, 0.7f));

                ReturnRedGem.setRelic = false;
            }
            #endregion
            
        }

        //Hammer
        if (UseConsumable.bigHammerActive == false && blockBarSet == true)
        {
            blockBarSet = false;
            hammerUpgrade.GetComponent<Button>().interactable = true;
        }

        if(changeCountText == true)
        {
            lockPickCountText.color = originalColor;
            hammerCountText.color = originalColor;
            lootPotionCountText.color = originalColor;
            damagePotionCountText.color = originalColor;
            XPPotionCountText.color = originalColor;
            goldenTouchCountText.color = originalColor;
            keysAmountText.color = originalColor;
            treasureBagCountText.color = originalColor;
            scrollCountText.color = originalColor;
            gauntletCountText.color = originalColor;
            elixirCountText.color = originalColor;
            relicCountText.color = originalColor;
            changeCountText = false;
        }
    }


    private IEnumerator ReturnTextFromPoolDelayed(GameObject itemsText, float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        ObjectPooling.instance.ReturnGoldTextFromPool(itemsText);
    }

    public void Sounds()
    {
        if (AudioManager.audioMuted == 1)
        {
            int randomGold = Random.Range(1, 6);
            if (randomGold == 1) { audioManager.Play("CoinSound1"); }
            if (randomGold == 2) { audioManager.Play("CoinSound2"); }
            if (randomGold == 3) { audioManager.Play("CoinSound3"); }
            if (randomGold == 4) { audioManager.Play("CoinSound4"); }
            if (randomGold == 5) { audioManager.Play("CoinSound5"); }
        }
    }

    IEnumerator wait2()
    {
        yield return new WaitForSeconds(0.2f);
        SpecialUpgradesButtons.specialTextChange = true;
    }

    public static bool changeCountText;
    public GameObject notUseOnLockedChestLockPick, notUseOnLockedChestKey;

    #region hammer
    public GameObject hammerCountdownBar;
    public TextMeshProUGUI hammerCountdownText;
    public float hammerCountdownTime;
    public int hammerStackCount;

    public void UseHammer()
    {
        if(hammerCount > 0)
        {
            UseItemSound();
            Stats.itemsUsed += 1;

            hammerStack -= 1;
            if (hammerStack == 0)
            {
                hammerUpgrade.GetComponent<Button>().interactable = false;
            }
            if (SkillTree.strongerSpecial6Bought == 1)
            {
                hammerDamage += hammerDamageMultiplier;
                hammerStackCount += 1;
                hammerStackText.text = Localization.stack + hammerStackCount;
            }
            else { hammerStackCount = 1; hammerDamage += hammerDamageMultiplier; }

            if (bigHammerActive == false)
            {
                if(PlaceMobileButtons.isMobile == false)
                {
                    bigHammer.SetActive(true);
                    bigHammer.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    bigHammer.transform.position = new Vector3(bigHammer.transform.position.x, bigHammer.transform.position.y, 1);
                }

                hammerCountdownTime = SpecialUpgradesButtons.hammerTimer; StartCoroutine(StartHammerCountdown());
            }

            bigHammerActive = true;
            hammerCount -= 1;
            
            SpecialUpgradesButtons.changeText = true;
            SpecialUpgradesButtons.specialTextChange = true;

            if (hammerCount == 0) { hammerCountText.color = Color.red; }
            hammerCountdownBar.SetActive(true);
        }
    }

    private System.Collections.IEnumerator StartHammerCountdown()
    {
        while (hammerCountdownTime > 0)
        {
            hammerCountdownText.text = Mathf.Round(hammerCountdownTime).ToString();
            yield return new WaitForSeconds(1f);
            hammerCountdownTime -= 1f;
        }

        hammerDamage = 0;
        hammerStackCount = 0;
        hammerStackText.text = "";
        bigHammerActive = false;
        hammerEnded = true;
        ClickPower.cursorsPriceChanged = true;
        hammerCountdownBar.SetActive(false);
        hammerUpgrade.GetComponent<Button>().interactable = true;
    }
    #endregion

    #region lockPick

    public GameObject lockPickBrokeText, lockPickAnimation;
    public GameObject itemsFrame;

    public void UseLockPick()
    {
        if(SelectChests.notUnlockedChest == true) {
            if (AudioManager.audioMuted == 1) {
                audioManager.Play("Error");
            }
            notUseOnLockedChestLockPick.SetActive(true);
            StartCoroutine(CantUseTextLockPick());
        }
        if (SelectChests.notUnlockedChest == false)
        {
            if (lockPickCount > 0)
            {
                if(PlaceMobileButtons.isMobile == true)
                {
                    itemsFrame.SetActive(false);
                }
                UseItemSound();
                Stats.itemsUsed += 1;
                lockPickUpgrade.GetComponent<Button>().interactable = false;
                keyUpgrade.GetComponent<Button>().interactable = false;
                lockPickCount -= 1;
                SpecialUpgradesButtons.changeText = true;
                SpecialUpgradesButtons.specialTextChange = true;
                lockPickAnimation.SetActive(true);
                lockPickAnimation.GetComponent<Animation>().Play();

                if (lockPickCount == 0) { lockPickCountText.color = Color.red; }
                StartCoroutine(lockPickAnim());
            }
        }
    }

    public static bool lockPickOpen;

    IEnumerator CantUseTextLockPick()
    {
        yield return new WaitForSeconds(2.5f);
        notUseOnLockedChestLockPick.SetActive(false);
    }

    IEnumerator lockPickAnim()
    {
        yield return new WaitForSeconds(0.250f);

        //Lockpick broke chance
        int random = Random.Range(1, 101);
        if (random > UseConsumable.lockPickSuccessChance)
        {
            if (AudioManager.audioMuted == 1)
            {
                audioManager.Play("Error");

            }
            lockPickBrokeText.SetActive(true);
            lockPickBrokeText.GetComponent<Animation>().Play();
        }
        else
        {
            lockPickOpen = true;
        }

        lockPickAnimation.SetActive(false);
        yield return new WaitForSeconds(0.15f);

        if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isInItemsTab == true)
        {
            itemsFrame.SetActive(true);
        }

        lockPickUpgrade.GetComponent<Button>().interactable = true;
        keyUpgrade.GetComponent<Button>().interactable = true;

    }

    #endregion

    #region keys

    public GameObject keyAnimation;
    public static bool usedKey;

    public void UseKeys()
    {
        if (SelectChests.notUnlockedChest == true)
        {
            if (AudioManager.audioMuted == 1)
            {
                audioManager.Play("Error");
                
            }
            notUseOnLockedChestKey.SetActive(true);
            StartCoroutine(CantUseTextKey());
        }
        if (SelectChests.notUnlockedChest == false)
        {
            if (KeysCount > 0)
            {
                if (PlaceMobileButtons.isMobile == true)
                {
                    itemsFrame.SetActive(false);
                }

                UseItemSound();
                Stats.itemsUsed += 1;
                keyUpgrade.GetComponent<Button>().interactable = false;
                lockPickUpgrade.GetComponent<Button>().interactable = false;
                KeysCount -= 1;
                SpecialUpgradesButtons.changeText = true;
                SpecialUpgradesButtons.specialTextChange = true;

                if (KeysCount == 0) { keysAmountText.color = Color.red; }
                keyAnimation.SetActive(true);
                keyAnimation.GetComponent<Animation>().Play();
                StartCoroutine(keyAnim());
            }
        }
    }

    IEnumerator CantUseTextKey()
    {
        yield return new WaitForSeconds(2.5f);
        notUseOnLockedChestKey.SetActive(false);
    }

    IEnumerator keyAnim()
    {
        yield return new WaitForSeconds(0.250f);

        usedKey = true;

        keyAnimation.SetActive(false);
        yield return new WaitForSeconds(0.15f);
        lockPickUpgrade.GetComponent<Button>().interactable = true;
        keyUpgrade.GetComponent<Button>().interactable = true;

        if (PlaceMobileButtons.isMobile == true && PlaceMobileButtons.isInItemsTab == true)
        {
            itemsFrame.SetActive(true);
        }
    }

    #endregion

    #region lootPotion
    public static float lootPotionGoldBuff;
    public GameObject lootPotionCountdownBar;
    public static int lootPotionDoubleValue;
    public TextMeshProUGUI lootPotionCountdownText;
    public float lootPotionCountdownTime;
    public bool lootPotionActive;
    public int lootPotionStackCount;
    public TextMeshProUGUI lootPotionStackText;

    public void UseLootPotion()
    {
        if(lootPotionCount > 0)
        {
            UseItemSound();

            lootPotionBuffIcon.SetActive(true);

            Stats.itemsUsed += 1;
            ClickPower.cursorsPriceChanged = true;
            
            lootPotionCountdownBar.SetActive(true);
            lootPotionGoldBuff += SpecialUpgradesButtons.lootPotionBuff;
            lootPotionCount -= 1;

            SpecialUpgradesButtons.changeText = true;
            SpecialUpgradesButtons.specialTextChange = true;

            lootPotionStack -= 1;
            if(lootPotionStack == 0)
            {
                lootPotionUpgrade.GetComponent<Button>().interactable = false;
            }
            if(RareTreasures.pillBottleFound == 1 || SkillTree.strongerSpecial3Bought == 1)
            {
                lootPotionStackCount += 1;
                lootPotionStackText.text = Localization.stack + lootPotionStackCount;
            }
            else { lootPotionStackCount = 1; }

            if (lootPotionCount == 0) { lootPotionCountText.color = Color.red; }
            if (lootPotionActive == false)
            {
                lootPotionDoubleValue += 5; lootPotionCountdownTime = SpecialUpgradesButtons.lootPotionTimer; StartCoroutine(StartCountdown()); 
            }
            lootPotionActive = true;
            SpawnRewards.changeDropChanceValues = true;
        }
    }

    private System.Collections.IEnumerator StartCountdown()
    {
        while (lootPotionCountdownTime > 0)
        {
            lootPotionBuffIcon.SetActive(true);
            lootPotionBuffText.text = "<color=yellow>+" + Mathf.Round((SpecialUpgradesButtons.lootPotionBuff * lootPotionStackCount) * 100).ToString() + "%" + Localization.gold;
            lootPotionBuffTimer.text = Localization.forTheNext +" <color=green>" + Mathf.Round(lootPotionCountdownTime).ToString() + "<color=white> " + Localization.seconds;

            lootPotionCountdownText.text = Mathf.Round(lootPotionCountdownTime).ToString(); 
            yield return new WaitForSeconds(1f);
            lootPotionCountdownTime -= 1f;
        }

        lootPotionBuffIcon.SetActive(false);
        lootPotionBuffHover.SetActive(false);

        lootPotionStackText.text = "";
        lootPotionStackCount = 0;
        lootPotionActive = false;
        ClickPower.cursorsPriceChanged = true;
        lootPotionCountdownBar.SetActive(false);
        lootPotionGoldBuff = 0;
        lootPotionEnded = true;
        lootPotionDoubleValue -= 5;
        SpawnRewards.changeDropChanceValues = true;
        lootPotionUpgrade.GetComponent<Button>().interactable = true;
    }

    #endregion

    #region damagePotion
    public static float damagePotionBuff;
    public static float XPPotionCritChance;
    public static float XPPotionCritDamage;

    public GameObject damagePotionCountdownBar;
    public TextMeshProUGUI damagePotionCountdownText;
    public float damagePotionCountdownTime;
    public bool damagePotionActive;
    public int damagePotionStackCount;
    public TextMeshProUGUI damagePotionStackText;

    public void UseDamagePotion()
    {
        if (damagePotioncount > 0)
        {
            UseItemSound();
            Stats.itemsUsed += 1;
            damagePotionBuffIcon.SetActive(true);

            ClickPower.cursorsPriceChanged = true;
           
            damagePotionCountdownBar.SetActive(true);
            damagePotionBuff += SpecialUpgradesButtons.damagePotionBuff;
            XPPotionCritChance = 2;
            XPPotionCritDamage = 0.5f;
            damagePotioncount -= 1;
            SpecialUpgradesButtons.changeText = true;
            SpecialUpgradesButtons.specialTextChange = true;

            damagePotionStack -= 1;
            if (damagePotionStack == 0)
            {
                gamagePotionUpgrade.GetComponent<Button>().interactable = false;
            }

            if (RareTreasures.pillBottleFound == 1 || SkillTree.strongerSpecial3Bought == 1)
            {
                damagePotionStackCount += 1;
                damagePotionStackText.text = Localization.stack + damagePotionStackCount;
            }
            else { damagePotionStackCount = 1; }

            if (damagePotioncount == 0) { damagePotionCountText.color = Color.red; }
            if (damagePotionActive == false) { damagePotionCountdownTime = SpecialUpgradesButtons.damagePotionTimer; StartCoroutine(StartDamageCountDown()); }
            damagePotionActive = true;
        }
    }

    private System.Collections.IEnumerator StartDamageCountDown()
    {
        while (damagePotionCountdownTime > 0)
        {
            damagePotionCountdownText.text = Mathf.Round(damagePotionCountdownTime).ToString();

            damagePotionBuffIcon.SetActive(true);
            damagePotionBuffText.text = "<color=green>+" + Mathf.Round((SpecialUpgradesButtons.damagePotionBuff * damagePotionStackCount) * 100).ToString() + Localization.damagePercent;
            damagePotionBuffTimer.text = Localization.forTheNext + "<color=green>" + Mathf.Round(damagePotionCountdownTime).ToString() + "<color=white>" + Localization.seconds;

            yield return new WaitForSeconds(1f);
            damagePotionCountdownTime -= 1f;
        }

        damagePotionBuffIcon.SetActive(false);
        damagePotionBuffHover.SetActive(false);

        damagePotionStackCount = 0;
        damagePotionStackText.text = "";
        gamagePotionUpgrade.GetComponent<Button>().interactable = true; ;
        ClickPower.cursorsPriceChanged = true;
        damagePotionActive = false;
        damagePotionEnded = true;
        damagePotionCountdownBar.SetActive(false);
        damagePotionBuff = 0;
        XPPotionCritChance = 0;
        XPPotionCritDamage = 0;
    }

    #endregion

    #region XPPotion
    public static float XPPotionBuff;

    public GameObject xpPotionCountdownBar;
    public TextMeshProUGUI xpPotionCountdownText;
    public float xpPotionCountdownTime;
    public static bool XPPotionActive;
    public int XPPotionStackCount;
    public TextMeshProUGUI XPPotionStackText;

    public void UseXPPotion()
    {
        if (XPPotionCount > 0)
        {
            UseItemSound();
            Stats.itemsUsed += 1;

            xpPotionBuffIcon.SetActive(true);

            xpPotionCountdownBar.SetActive(true);

            XPPotionBuff += SpecialUpgradesButtons.XPPotionXPBuff;
            XPPotionCount -= 1;

            XPPotionStack -= 1;
            if (XPPotionStack == 0)
            {
                XPPotionUpgrade.GetComponent<Button>().interactable = false;
            }

            if (RareTreasures.pillBottleFound == 1 || SkillTree.strongerSpecial3Bought == 1)
            {
                XPPotionStackCount += 1;
                XPPotionStackText.text = Localization.stack + XPPotionStackCount;
            }
            else { XPPotionStackCount = 1; }

            if (XPPotionActive == false) { xpPotionCountdownTime = SpecialUpgradesButtons.XPPotionTimer; StartCoroutine(StartXPCountDown());  }
            XPPotionActive = true;

            if (XPPotionCount == 0) { XPPotionCountText.color = Color.red; }
            SpecialUpgradesButtons.changeText = true;
            SpecialUpgradesButtons.specialTextChange = true;
        }
    }

    private System.Collections.IEnumerator StartXPCountDown()
    {
        while (xpPotionCountdownTime > 0)
        {
            xpPotionCountdownText.text = Mathf.Round(xpPotionCountdownTime).ToString();

            xpPotionBuffIcon.SetActive(true);
            xpPotionBuffText.text = "<color=orange>+" + Mathf.Round((SpecialUpgradesButtons.XPPotionXPBuff * XPPotionStackCount) * 100).ToString() + Localization.xp;
            xpPotionBuffTimer.text = Localization.forTheNext + "<color=green>" + Mathf.Round(xpPotionCountdownTime).ToString() + "<color=white>" + Localization.seconds;

            yield return new WaitForSeconds(1f);
            xpPotionCountdownTime -= 1f;
        }

        xpPotionBuffIcon.SetActive(false);
        xpPotionBuffHover.SetActive(false);

        XPPotionStackCount = 0;
        XPPotionStackText.text = "";
        ClickPower.cursorsPriceChanged = true;
        xpPotionCountdownBar.SetActive(false);
        XPpotionEnded = true;
        XPPotionBuff = 0;
        XPPotionActive = false;
        XPPotionUpgrade.GetComponent<Button>().interactable = true;
    }

    #endregion

    #region goldenTouch

    public GameObject goldeTouchCountdownBar;
    public TextMeshProUGUI goldeTouchCountdownText;
    public float goldeTouchCountdownTime;
    public static int goldenTouchStackCount;

    public void UseGoldenTouch()
    {
        if(goldenTouchCount > 0)
        {
            UseItemSound();
            Stats.itemsUsed += 1;

            goldenTouchBuffIcon.SetActive(true);
            
            goldenTouchCount -= 1;

            goldenTouchStack -= 1;
            if (goldenTouchStack == 0)
            {
                goldenTouchUpgrade.GetComponent<Button>().interactable = false;
            }
            if (SkillTree.strongerSpecial6Bought == 1)
            {
                goldenTouchStackCount += 1;
                goldenTouchStackText.text = Localization.stack + goldenTouchStackCount;
            }
            else { goldenTouchStackCount = 1; }

            if (goldenTouchActive == false)
            {
                lootPotionDoubleValue += 10; goldeTouchCountdownTime = SpecialUpgradesButtons.goldenTouchTimer; StartCoroutine(StartGoldenTouchCountDown());
            }

            SpawnRewards.changeDropChanceValues = true;
            goldeTouchCountdownBar.SetActive(true);
            goldenTouchActive = true;
            glow.SetActive(true);
            glow.GetComponent<Animation>().Play();
            

            if (goldenTouchCount == 0) { goldenTouchCountText.color = Color.red; }
            SpecialUpgradesButtons.changeText = true;
            SpecialUpgradesButtons.specialTextChange = true;
        }
    }

    private System.Collections.IEnumerator StartGoldenTouchCountDown()
    {
        while (goldeTouchCountdownTime > 0)
        {
            goldeTouchCountdownText.text = Mathf.Round(goldeTouchCountdownTime).ToString();

            goldenTouchBuffTextTimer.text = Localization.forTheNext + "<color=green>" + Mathf.Round(goldeTouchCountdownTime).ToString() + "<color=white>" + Localization.seconds;

            yield return new WaitForSeconds(1f);
            goldeTouchCountdownTime -= 1f;
        }

        goldenTouchBuffIcon.SetActive(false);
        goldenTouchBuffHover.SetActive(false);

        goldenTouchStackText.text = "";
        goldenTouchStackCount = 0;
        goldenTouchEnded = true;

        goldenTouchActive = false;
        glow.GetComponent<Animation>().Stop();
        glow.SetActive(false);
        ClickPower.cursorsPriceChanged = true;
        goldeTouchCountdownBar.SetActive(false);
        lootPotionDoubleValue -= 10;
        SpawnRewards.changeDropChanceValues = true;
        goldenTouchUpgrade.GetComponent<Button>().interactable = true;
    }
    #endregion

    #region treasureBag
    public static bool spawnTreasureBag;
    public static int treasureSpawnCount;

    public void UseTreasureBag()
    {
        if(treasureBagCount > 0)
        {
            UseItemSound();
            Stats.itemsUsed += 1;
            spawnTreasureBag = true;
            treasureBagCount -= 1;
            treasureSpawnCount += 1;

            if (treasureBagCount == 0) { treasureBagCountText.color = Color.red; }
            SpecialUpgradesButtons.changeText = true;
            SpecialUpgradesButtons.specialTextChange = true;
        }
    }

    #endregion

    #region elixir
    public static float elixirGoldBuff, elixirXPBuff, elixirDamageBuff;
    public GameObject elixirCountdownBar;
    public TextMeshProUGUI elixirCountdownText;
    public float elixirCountdownTime;
    public static float elixirTreasureDropChance;
    public bool elixirActive;
    public int ElixirPotionStackCount;
    public TextMeshProUGUI ElixirStackText;


    public void UseElixirn()
    {
        if (elixirCount > 0)
        {
            UseItemSound();

            elixirBuffIcon.SetActive(true);

            Stats.itemsUsed += 1;
            ClickPower.cursorsPriceChanged = true;
            
            elixirCountdownBar.SetActive(true);
            elixirCount -= 1;
            elixirTreasureDropChance = 0.3f;
            SpawnRewards.changeDropChanceValues = true;

            elixirGoldBuff += (SpecialUpgradesButtons.lootPotionBuff * SpecialUpgradesButtons.elixirBuff);
            elixirXPBuff += (SpecialUpgradesButtons.XPPotionXPBuff * SpecialUpgradesButtons.elixirBuff);
            elixirDamageBuff += (SpecialUpgradesButtons.damagePotionBuff * SpecialUpgradesButtons.elixirBuff);

            elixirStack -= 1;
            if (elixirStack == 0)
            {
                exlixirUpgrade.GetComponent<Button>().interactable = false;
            }

            if (RareTreasures.pillBottleFound == 1 || SkillTree.strongerSpecial3Bought == 1)
            {
                ElixirPotionStackCount += 1;
                ElixirStackText.text = Localization.stack + ElixirPotionStackCount;
            }
            else { ElixirPotionStackCount = 1; }

            if (elixirCount == 0) { elixirCountText.color = Color.red; }
            if (elixirActive == false) { elixirCountdownTime = SpecialUpgradesButtons.elixirTimer; StartCoroutine(StartCountdownElixir()); }
            elixirActive = true;

            SpecialUpgradesButtons.changeText = true;
            SpecialUpgradesButtons.specialTextChange = true;

            //Debug.Log(ElixirPotionStackCount);

        }
    }

    private System.Collections.IEnumerator StartCountdownElixir()
    {
        while (elixirCountdownTime > 0)
        {
            elixirCountdownText.text = Mathf.Round(elixirCountdownTime).ToString();

            elixirBuffIcon.SetActive(true);
            elixirGoldBuffText.text = "<color=yellow>+" + Mathf.Round((elixirGoldBuff) * 100).ToString() + "%" + Localization.gold;
            elixirDamageBuffText.text = "<color=green>+" + Mathf.Round((elixirDamageBuff) * 100).ToString() + Localization.damagePercent;
            elixirXPBuffText.text = "<color=orange>+" + Mathf.Round((elixirXPBuff ) * 100).ToString() + Localization.xp;

            elixirBuffTextTimer.text = Localization.forTheNext + "<color=green>" + Mathf.Round(elixirCountdownTime).ToString() + "<color=white>" + Localization.seconds;

            yield return new WaitForSeconds(1f);
            elixirCountdownTime -= 1f;
        }

        ElixirPotionStackCount = 0;
        ElixirStackText.text = "";

        elixirBuffIcon.SetActive(false);
        elixirBuffHover.SetActive(false);

        ClickPower.cursorsPriceChanged = true;
        elixirCountdownBar.SetActive(false);
        elixirGoldBuff = 0;
        elixirXPBuff = 0;
        elixirDamageBuff = 0;
        elixirTreasureDropChance = 0;
        SpawnRewards.changeDropChanceValues = true;
        elixirActive = false;
        elixirPotionEnded = true;
        exlixirUpgrade.GetComponent<Button>().interactable = true;
    }
    #endregion

    #region scroll
    public static float scrollActiveDamageBuff, scrollPassiveDamageBuff, scrollCritChanceBuff, scrollCritDamageBuff, scrollGoldBuff, scrollXPBuff, scrollTreasureBuff;
    public GameObject scrollCoundownBar;
    public TextMeshProUGUI scrollCountDownText;
    public float scrollCountdownTime;
    public static bool isScrollActive;
    public static int scrollStackCount;
    public void UseScroll()
    {
        if (scrollCount > 0)
        {
            UseItemSound();
            Stats.itemsUsed += 1;
            scrollCount -= 1;
            ClickPower.cursorsPriceChanged = true;

            scrollStack -= 1;
            if (scrollStack == 0)
            {
                scrollUpgrade.GetComponent<Button>().interactable = false;
            }
            if (SkillTree.strongerSpecial6Bought == 1)
            {
                scrollStackCount += 1;
                if(scrollStackCount > 2) { scrollStackCount = 2; }
                scrollStackText.text = Localization.stack + scrollStackCount;
            }
            else { scrollStackCount = 1;  }

            if (isScrollActive == false)
            {
                scrollCountdownTime = SpecialUpgradesButtons.scrollTimer; StartCoroutine(StartCountdownScroll());
            }

            scrollCoundownBar.SetActive(true);

            isScrollActive = true;
            SpecialUpgradesButtons.changeText = true;
            SpecialUpgradesButtons.specialTextChange = true;

            if (scrollCount == 0) { scrollCountText.color = Color.red; }
        }
    }

    private System.Collections.IEnumerator StartCountdownScroll()
    {
        while (scrollCountdownTime > 0)
        {
            scrollCountDownText.text = Mathf.Round(scrollCountdownTime).ToString();
            yield return new WaitForSeconds(1f);
            if (scrollStackCount > 2) 
            {
                scrollStackCount = 2;
                scrollStackText.text = Localization.stack + scrollStackCount;
            }
            
            scrollCountdownTime -= 1f;
        }

        scrollStackCount = 0;
        scrollStackText.text = "";
        scrollEnded = true;

        scrollUpgrade.GetComponent<Button>().interactable = true;
        ClickPower.cursorsPriceChanged = true;
        scrollCoundownBar.SetActive(false);
        isScrollActive = false;
    }
    #endregion

    #region gauntlet
    public GameObject gauntletCoundownBar;
    public TextMeshProUGUI gauntletCountDownText;
    public float gauntletCountdownTime;
    public static bool isGauntletActive;
    public static int gauntletStackCount;
    public void UseGauntlet()
    {
        if (gauntletCount > 0)
        {
            UseItemSound();
            Stats.itemsUsed += 1;
            ClickPower.cursorsPriceChanged = true;
            gauntletCoundownBar.SetActive(true);
            gauntletCount -= 1;

            gauntletStack -= 1;
            if (gauntletStack == 0)
            {
                gauntletUpgrade.GetComponent<Button>().interactable = false;
            }
            if (SkillTree.strongerSpecial6Bought == 1)
            {
                gauntletStackCount += 1;
                gauntletStackText.text = Localization.stack + gauntletStackCount;
            }
            else { gauntletStackCount = 1; }

            if (isGauntletActive == false)
            {
               gauntletCountdownTime = SpecialUpgradesButtons.gauntletTimer; StartCoroutine(StartCountdownGauntlet());
            }

            isGauntletActive = true;

            if (gauntletCount == 0) { gauntletCountText.color = Color.red; }
            SpecialUpgradesButtons.changeText = true;
            SpecialUpgradesButtons.specialTextChange = true;
        }
    }

    private System.Collections.IEnumerator StartCountdownGauntlet()
    {
        while (gauntletCountdownTime > 0)
        {
            gauntletCountDownText.text = Mathf.Round(gauntletCountdownTime).ToString();
            yield return new WaitForSeconds(1f);
            gauntletCountdownTime -= 1f;
        }

        gauntletStackCount = 0;
        gauntletStackText.text = "";
        gauntletEnded = true;

        gauntletUpgrade.GetComponent<Button>().interactable = true;
        ClickPower.cursorsPriceChanged = true;
        gauntletCoundownBar.SetActive(false);
        isGauntletActive = false;
    }
    #endregion

    #region relic

    public static float relicPermaActiveDamage, relicPermaPassiveDamage, relicPermaCritDamage, relicPermaCritChance, relicPermaGoldBuff, relicPermaTreasureBuff, relicPermaXPBuff;
    public TextMeshProUGUI relicBonusText;
    public void UseRelic()
    {
        if (relicCount > 0)
        {
            UseItemSound();
            Stats.itemsUsed += 1;
            relicCount -= 1;

            if (relicCount == 0) { relicCountText.color = Color.red; }
            SpecialUpgradesButtons.specialTextChange = true;
            SpecialUpgradesButtons.changeText = true;
            ClickPower.cursorsPriceChanged = true;

            StartCoroutine(RelicRandomPermaBuff());
        }
    }

    public TMP_FontAsset korean, english, russian, japanese, chinese;
    public Transform relicTextTransform, originalParent;

    IEnumerator RelicRandomPermaBuff()
    {
        int randomRelicBuff = Random.Range(1, 101);
        GameObject chestText = ObjectPooling.instance.GetMiniChestTextFromPool();
        if(PlaceMobileButtons.isMobile == true) { chestText.transform.SetParent(relicTextTransform); }
        if (Localization.EnglishLanguageChosen == 1) { chestText.GetComponent<TextMeshProUGUI>().font = english; }
        if (Localization.RussianLanguageChosen == 1) { chestText.GetComponent<TextMeshProUGUI>().font = russian; }
        if (Localization.JapaneseLanguageChosen == 1) { chestText.GetComponent<TextMeshProUGUI>().font = japanese; }
        if (Localization.ChineseLanguageChosen == 1) { chestText.GetComponent<TextMeshProUGUI>().font = chinese; }
        if (Localization.KoreanLanguageChosen == 1) { chestText.GetComponent<TextMeshProUGUI>().font = korean; }

        chestText.GetComponent<Animation>().Play("relicBonusAnim");
        chestText.GetComponent<TextMeshProUGUI>().color = Color.red;

        if (randomRelicBuff <= 2)
        {
            relicPermaTreasureBuff += (0.05f + RareTreasures.presentTreasurBuff + SkillTree.special7RelicTreasure);

            chestText.GetComponent<TextMeshProUGUI>().text = "+" + (0.05f + RareTreasures.presentTreasurBuff + SkillTree.special7RelicTreasure).ToString("F2") + Localization.treasureDropChance;
            SpawnRewards.changeDropChanceValues = true;
        }
        else if (randomRelicBuff <= 8)
        {
            relicPermaCritChance += (0.2f + RareTreasures.presentCritChanceBuff + SkillTree.special7RelicCritChance);
            chestText.GetComponent<TextMeshProUGUI>().text = "+" + (0.2f + RareTreasures.presentCritChanceBuff + SkillTree.special7RelicCritChance).ToString("F2") + Localization.critChanceString;
        }
        else if (randomRelicBuff <= 25)
        {
            relicPermaCritDamage += (0.75f + RareTreasures.presentCriDamageBuff + SkillTree.special7RelicCritDamage);
            chestText.GetComponent<TextMeshProUGUI>().text = "+" + ((0.75f + RareTreasures.presentCriDamageBuff + SkillTree.special7RelicCritDamage) * 100).ToString("F0") + Localization.critDamageString;
        }
        else if (randomRelicBuff <= 40)
        {
            relicPermaPassiveDamage += (0.35f + RareTreasures.presentPassiveDamageBuff + SkillTree.special7RelicPassiveDamage);
            chestText.GetComponent<TextMeshProUGUI>().text = "+" + ((0.35f + RareTreasures.presentPassiveDamageBuff + SkillTree.special7RelicPassiveDamage) * 100).ToString("F0") + Localization.passiveDamageString;
        }
        else if (randomRelicBuff <= 55)
        {
            relicPermaActiveDamage += (0.50f + RareTreasures.presentActiveDamageBuff + SkillTree.special7RelicActiveDamage);
            chestText.GetComponent<TextMeshProUGUI>().text = "+" + ((0.50f + RareTreasures.presentActiveDamageBuff + SkillTree.special7RelicActiveDamage) * 100).ToString("F0") + Localization.activeDamageScring;
        }
        else if (randomRelicBuff <= 75)
        {
            relicPermaXPBuff += (0.35f + RareTreasures.presentXPBuff + SkillTree.special7RelicXP);
            chestText.GetComponent<TextMeshProUGUI>().text = "+" + ((0.35f + RareTreasures.presentXPBuff + SkillTree.special7RelicXP) * 100).ToString("F0") + Localization.xp;
        }
        else
        {
            relicPermaGoldBuff += (0.35f + RareTreasures.presentGoldBuff + SkillTree.special7RelicTGOLD);
            chestText.GetComponent<TextMeshProUGUI>().text = "+" + ((0.35f + RareTreasures.presentGoldBuff + SkillTree.special7RelicTGOLD) * 100).ToString("F0") + Localization.goldPercentString;
        }
        yield return new WaitForSeconds(1.2f);
        if (PlaceMobileButtons.isMobile == true) { chestText.transform.SetParent(originalParent); }
        ObjectPooling.instance.ReturnMiniChestTextFromPool(chestText);
    }
    #endregion

    public void UseItemSound()
    {
        if (AudioManager.audioMuted == 1) { audioManager.Play("UseItem"); }
    }

    #region RestItems
    public void ResetItems()
    {
        lootPotionActive = false;
        lootPotionCountdownBar.SetActive(false);
        lootPotionGoldBuff = 0;
       
        lootPotionDoubleValue = 0;
        SpawnRewards.changeDropChanceValues = true;
        lootPotionUpgrade.GetComponent<Button>().interactable = true;

        hammerUpgrade.GetComponent<Button>().interactable = true;

        gamagePotionUpgrade.GetComponent<Button>().interactable = true;
        damagePotionActive = false;
        
        damagePotionCountdownBar.SetActive(false);
        damagePotionBuff = 0;
        XPPotionCritChance = 0;
        XPPotionCritDamage = 0;

        xpPotionCountdownBar.SetActive(false);
       
        XPPotionBuff = 0;
        XPPotionActive = false;
        XPPotionUpgrade.GetComponent<Button>().interactable = true;

        gauntletUpgrade.GetComponent<Button>().interactable = true;
        gauntletCoundownBar.SetActive(false);
        isGauntletActive = false;

        scrollUpgrade.GetComponent<Button>().interactable = true;
        scrollCoundownBar.SetActive(false);
        isScrollActive = false;

        elixirCountdownBar.SetActive(false);
        elixirGoldBuff = 0;
        elixirXPBuff = 0;
        elixirDamageBuff = 0;
        elixirTreasureDropChance = 0;
        SpawnRewards.changeDropChanceValues = true;
        elixirActive = false;
        potionStack = true;
        exlixirUpgrade.GetComponent<Button>().interactable = true;

        goldenTouchActive = false;
        glow.GetComponent<Animation>().Stop();
        glow.SetActive(false);
        goldeTouchCountdownBar.SetActive(false);
        lootPotionDoubleValue = 0;
        goldenTouchUpgrade.GetComponent<Button>().interactable = true;

        hammerCountdownBar.SetActive(false);

        hammerDamage = 0;
        bigHammerActive = false;
        hammerEnded = true;
        ClickPower.cursorsPriceChanged = true;

        lockPickUpgrade.GetComponent<Button>().interactable = true;
        keyUpgrade.GetComponent<Button>().interactable = true;

        ChestHover.itemCursorActive = false;

        lootPotionStackCount = 0;
        damagePotionStackCount = 0;
        XPPotionStackCount = 0;
        ElixirPotionStackCount = 0;
        hammerStackCount = 0;
        goldenTouchStackCount = 0;
        scrollStackCount = 0;
        gauntletStackCount = 0;

        lootPotionStackText.text = "";
        damagePotionStackText.text = "";
        XPPotionStackText.text = "";
        ElixirStackText.text = "";
        hammerStackText.text = "";
        goldenTouchStackText.text = "";
        scrollStackText.text = "";
        gauntletStackText.text = "";

        lootPotionBuffIcon.SetActive(false); damagePotionBuffIcon.SetActive(false); xpPotionBuffIcon.SetActive(false); goldenTouchBuffIcon.SetActive(false);
        elixirBuffIcon.SetActive(false);

        ClickPower.cursorsPriceChanged = true;
        StopAllCoroutines();
        StartCoroutine(waitwait());
    }


    IEnumerator waitwait()
    {
        yield return new WaitForSeconds(1.5f);
        TotalGoldAmount.totalGold = 0;
        RareDropsCollected.quartzCount = 0;
        RareDropsCollected.amethystCount = 0;
        RareDropsCollected.yellowTopazCount = 0;
        RareDropsCollected.albiteCount = 0;
        RareDropsCollected.redGarnetCount = 0;
        RareDropsCollected.aquamarineCount = 0;
        RareDropsCollected.yellowSapphireCount = 0;
        RareDropsCollected.pinkTourmalineCount = 0;
        RareDropsCollected.AdventurineCount = 0;
        RareDropsCollected.RedGemCount = 0;
        RareDropsCollected.diamondCount = 0;
        RareDropsCollected.grandidieriteCount = 0;
        RareDropsCollected.violetCrystalCount = 0;
        RareDropsCollected.akoyaPearlCount = 0;
        RareDropsCollected.purpleRupeeCount = 0;
        RareDropsCollected.emeraldCount = 0;
        RareDropsCollected.greenDiamondCount = 0;
        RareDropsCollected.fireOpalCount = 0;
        RareDropsCollected.gemSilicaCount = 0;
        RareDropsCollected.pinkPlostCount = 0;
        RareDropsCollected.goldeSeaPearlCount = 0;
        RareDropsCollected.kyaniteCount = 0;
        RareDropsCollected.blackOpalCount = 0;
        RareDropsCollected.painiteCount = 0;
        RareDropsCollected.TanzaniteCount = 0;

    }
    #endregion

    public void ChangeButtonPressedColor(Button button, Color pressedColor)
    {
        ColorBlock colors = button.colors;
        colors.pressedColor = pressedColor;
        button.colors = colors;
    }

    /*
    public void SaveConsumables()
    {
        SaveSystem.SaveConsumables(this);
    }
    */
}
