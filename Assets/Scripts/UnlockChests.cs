using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class UnlockChests : MonoBehaviour,IDataPersistence
{
    public string newHexValue = "#FFFFFF";
    public static int boughtChest2, boughtChest3, boughtChest4, boughtChest5, boughtChest6, boughtChest7, boughtChest8;
    public static int boughtChest9, boughtChest10, boughtChest11, boughtChest12, boughtChest13, boughtChest14, boughtChest15;
    public static int boughtChest16, boughtChest17, boughtChest18, boughtChest19, boughtChest20, boughtChest21;
    public static int boughtChest22, boughtChest23, boughtChest24, boughtChest25, boughtChest26, boughtChest27;

    public GameObject chest1, chest2, chest3, chest4, chest5, chest6, chest7, chest8, chest9, chest10, chest11, chest12, chest13;
    public GameObject chest14, chest15, chest16, chest17, chest18, chest19, chest20, chest21, chest22, chest23, chest24, chest25, chest26, chest27, chest28, chest29, chest30, chest31, chest32, chest33, chest34, chest35, chest36, chest37, chest38, chest39, chest40;

    public GameObject lockedChest;
    public TextMeshProUGUI textPrice;

    public GameObject unlockedCursor4, unlockedCursor5, unlockedCursor6, unlockedCursor7, unlockedCursor8, unlockedCursor9, unlockedCursor10, unlockedCursor11, unlockedCursor12, unlockedCursor13, unlockedCursor14, unlockedCursor15, unlockedCursor16, unlockedCursor17, unlockedCursor18, unlockedCursor19, unlockedCursor20, unlockedCursor21;

    public void Start()
    {
        Invoke("wait", 0.32f);
    }

    public void wait()
    {
        string path = Application.persistentDataPath + "/player.saveChests";

        if (File.Exists(path))
        {
            if (SaveAndLoad.onlyLoadNewSave == false)
            {
                GameData data = SaveSystem.LoadChests();
                timesPurchasedChests = data.timesPurchasedChests;
                boughtChest2 = data.purchasedChest2;
                boughtChest3 = data.purchasedChest3;
                boughtChest4 = data.purchasedChest4;
                boughtChest5 = data.purchasedChest5;
                boughtChest6 = data.purchasedChest6;
                boughtChest7 = data.purchasedChest7;
                boughtChest8 = data.purchasedChest8;
                boughtChest9 = data.purchasedChest9;
                boughtChest10 = data.purchasedChest10;
                boughtChest11 = data.purchasedChest11;
                boughtChest12 = data.purchasedChest12;
                boughtChest13 = data.purchasedChest13;
                boughtChest14 = data.purchasedChest14;
                boughtChest15 = data.purchasedChest15;
                boughtChest16 = data.purchasedChest16;
                boughtChest17 = data.purchasedChest17;
                boughtChest18 = data.purchasedChest18;
                boughtChest19 = data.purchasedChest19;
                boughtChest20 = data.purchasedChest20;
                boughtChest21 = data.purchasedChest21;
                boughtChest22 = data.purchasedChest22;
                boughtChest23 = data.purchasedChest23;
                boughtChest24 = data.purchasedChest24;
                boughtChest25 = data.purchasedChest25;
                boughtChest26 = data.purchasedChest26;
                boughtChest27 = data.purchasedChest27;
            }
            else { }
        }
        else
        {
            //Do nothing
        }

        cursorExlemationmark.SetActive(false);
        if (timesPurchasedChests >= 2) { unlockedCursor4.SetActive(true); }
        if (timesPurchasedChests >= 4) { unlockedCursor5.SetActive(true); unlockedCursor6.SetActive(true); }
        if (timesPurchasedChests >= 6) { unlockedCursor7.SetActive(true); }
        if (timesPurchasedChests >= 7) { unlockedCursor8.SetActive(true); }
        if (timesPurchasedChests >= 9) { unlockedCursor9.SetActive(true); }
        if (timesPurchasedChests >= 11) { unlockedCursor10.SetActive(true); }
        if (timesPurchasedChests >= 13) { unlockedCursor11.SetActive(true); unlockedCursor12.SetActive(true); }
        if (timesPurchasedChests >= 15) { unlockedCursor13.SetActive(true); }
        if (timesPurchasedChests >= 17) { unlockedCursor14.SetActive(true); }
        if (timesPurchasedChests >= 19) { unlockedCursor15.SetActive(true); }
        if (timesPurchasedChests >= 22) { unlockedCursor16.SetActive(true); }
        if (timesPurchasedChests >= 23) { unlockedCursor17.SetActive(true); }
        if (timesPurchasedChests >= 26) { unlockedCursor18.SetActive(true); }

        if (timesPurchasedChests >= 30) { unlockedCursor19.SetActive(true); }
        if (timesPurchasedChests >= 34) { unlockedCursor20.SetActive(true); }
        if (timesPurchasedChests >= 37) { unlockedCursor21.SetActive(true); }


        ChangeColor();

        StartCoroutine(waitPrice2());
    }


    #region SaveAndLoadJSON
    public void LoadData(GameDataJSON data)
    {
        timesPurchasedChests = data.timesPurchasedChests;
        boughtChest2 = data.purchasedChest2;
        boughtChest3 = data.purchasedChest3;
        boughtChest4 = data.purchasedChest4;
        boughtChest5 = data.purchasedChest5;
        boughtChest6 = data.purchasedChest6;
        boughtChest7 = data.purchasedChest7;
        boughtChest8 = data.purchasedChest8;
        boughtChest9 = data.purchasedChest9;
        boughtChest10 = data.purchasedChest10;
        boughtChest11 = data.purchasedChest11;
        boughtChest12 = data.purchasedChest12;
        boughtChest13 = data.purchasedChest13;
        boughtChest14 = data.purchasedChest14;
        boughtChest15 = data.purchasedChest15;
        boughtChest16 = data.purchasedChest16;
        boughtChest17 = data.purchasedChest17;
        boughtChest18 = data.purchasedChest18;
        boughtChest19 = data.purchasedChest19;
        boughtChest20 = data.purchasedChest20;
        boughtChest21 = data.purchasedChest21;
        boughtChest22 = data.purchasedChest22;
        boughtChest23 = data.purchasedChest23;
        boughtChest24 = data.purchasedChest24;
        boughtChest25 = data.purchasedChest25;
        boughtChest26 = data.purchasedChest26;
        boughtChest27 = data.purchasedChest27;
    }

    public void SaveData(ref GameDataJSON data)
    {
        data.timesPurchasedChests = timesPurchasedChests;
        data.purchasedChest2 = boughtChest2;
        data.purchasedChest3 = boughtChest3;
        data.purchasedChest4 = boughtChest4;
        data.purchasedChest5 = boughtChest5;
        data.purchasedChest6 = boughtChest6;
        data.purchasedChest7 = boughtChest7;
        data.purchasedChest8 = boughtChest8;
        data.purchasedChest9 = boughtChest9;
        data.purchasedChest10 = boughtChest10;
        data.purchasedChest11 = boughtChest11;
        data.purchasedChest12 = boughtChest12;
        data.purchasedChest13 = boughtChest13;
        data.purchasedChest14 = boughtChest14;
        data.purchasedChest15 = boughtChest15;
        data.purchasedChest16 = boughtChest16;
        data.purchasedChest17 = boughtChest17;
        data.purchasedChest18 = boughtChest18;
        data.purchasedChest19 = boughtChest19;
        data.purchasedChest20 = boughtChest20;
        data.purchasedChest21 = boughtChest21;
        data.purchasedChest22 = boughtChest22;
        data.purchasedChest23 = boughtChest23;
        data.purchasedChest24 = boughtChest24;
        data.purchasedChest25 = boughtChest25;
        data.purchasedChest26 = boughtChest26;
        data.purchasedChest27 = boughtChest27;
    }
    #endregion

    public void Update()
    {
        if (UpdateGame.totalGoldHigher < SelectChests.chestPrice) { textPrice.color = Color.red; }
        if (UpdateGame.totalGoldHigher >= SelectChests.chestPrice) { textPrice.color = Color.green; }

    }

    public GameObject arrowNextChest2, arrowNextChest3, arrowNextChest4, arrowNextChest5, arrowNextChest6, arrowNextChest7, arrowNextChest8, arrowNextChest9, arrowNextChest10, arrowNextChest11, arrowNextChest12, arrowNextChest13, arrowNextChest14, arrowNextChest15, arrowNextChest16, arrowNextChest17, arrowNextChest18, arrowNextChest19, arrowNextChest20, arrowNextChest21, arrowNextChest22, arrowNextChest23, arrowNextChest24, arrowNextChest25, arrowNextChest26, arrowNextChest27, arrowNextChest28, arrowNextChest29, arrowNextChest30, arrowNextChest31, arrowNextChest32, arrowNextChest33, arrowNextChest34, arrowNextChest35, arrowNextChest36, arrowNextChest37, arrowNextChest38, arrowNextChest39;

    public static int timesPurchasedChests;
    public TextMeshProUGUI prestigeKeyDropChance, prestigeChestDropChance;
    public GameObject chestNameText;
    public GameObject cursorsBar, cursorExlemationmark;

    public static double currentSellPrice;

    public AudioManager audioManager;
    public PlaceMobileButtons mobileScript;
    public void PurchaseChests()
    {
        if (UpdateGame.totalGoldHigher < SelectChests.chestPrice) {
            if (AudioManager.audioMuted == 1) { audioManager.Play("Error"); }
        }
        if (UpdateGame.totalGoldHigher >= SelectChests.chestPrice)
        {
            if (AudioManager.audioMuted == 1) { audioManager.Play("ChestPurchaseSound"); }
            chestNameText.GetComponent<Animation>().Play();

            timesPurchasedChests += 1;
            if(timesPurchasedChests == 1) { boughtChest2 = 1; arrowNextChest2.SetActive(true);
                chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.TimberwoodChestUnlocked;
            }

            if (timesPurchasedChests == 2) { boughtChest3 = 1; arrowNextChest3.SetActive(true); unlockedCursor4.SetActive(true);
                chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.RockboundChestUnlocked;
                if (cursorsBar.activeInHierarchy == false) { cursorExlemationmark.SetActive(true); }
            }

            if (timesPurchasedChests == 3) { boughtChest4 = 1; arrowNextChest4.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.BronzeChestUnlocked; }

            if (timesPurchasedChests == 4) { boughtChest5 = 1; arrowNextChest5.SetActive(true); unlockedCursor5.SetActive(true); unlockedCursor6.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.SequoiaChestUnlocked;
                if (cursorsBar.activeInHierarchy == false) { cursorExlemationmark.SetActive(true); }
            }

            if (timesPurchasedChests == 5) { boughtChest6 = 1; arrowNextChest6.SetActive(true);
                chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.IronboundChestUnlocked;
            }

            if (timesPurchasedChests == 6) { boughtChest7 = 1; arrowNextChest7.SetActive(true); unlockedCursor7.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.StoneshieldChestUnlocked;
                if (cursorsBar.activeInHierarchy == false) { cursorExlemationmark.SetActive(true); }
            }

            if (timesPurchasedChests == 7) { boughtChest8 = 1; arrowNextChest8.SetActive(true); unlockedCursor8.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.OceanChestUnlocked;
                if (cursorsBar.activeInHierarchy == false) { cursorExlemationmark.SetActive(true); }
            }

            if (timesPurchasedChests == 8) { boughtChest9 = 1; arrowNextChest9.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.PoisonousChestUnlocked; }

            if (timesPurchasedChests == 9) { boughtChest10 = 1; arrowNextChest10.SetActive(true); unlockedCursor9.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.GoldenChestUnlocked;
                if (cursorsBar.activeInHierarchy == false) { cursorExlemationmark.SetActive(true); }
            }

            if (timesPurchasedChests == 10) { boughtChest11 = 1; arrowNextChest11.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.DesertChestUnlocked; }

            if (timesPurchasedChests == 11) { boughtChest12 = 1; arrowNextChest12.SetActive(true); unlockedCursor10.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.PirateChestUnlocked;
                if (cursorsBar.activeInHierarchy == false) { cursorExlemationmark.SetActive(true); }
            }

            if (timesPurchasedChests == 12) { boughtChest13 = 1; arrowNextChest13.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.CrystalChestUnlocked; }

            if (timesPurchasedChests == 13) { boughtChest14 = 1; arrowNextChest14.SetActive(true); unlockedCursor11.SetActive(true); unlockedCursor12.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.CelestialChestUnlocked;
                if (cursorsBar.activeInHierarchy == false) { cursorExlemationmark.SetActive(true); }
            }

            if (timesPurchasedChests == 14) { boughtChest15 = 1; arrowNextChest15.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.PhantomChestUnlocked; }

            if (timesPurchasedChests == 15) { boughtChest16 = 1; arrowNextChest16.SetActive(true); unlockedCursor13.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.PrismaticChestUnlocked;
                if (cursorsBar.activeInHierarchy == false) { cursorExlemationmark.SetActive(true); }
            }

            if (timesPurchasedChests == 16) { boughtChest17 = 1; arrowNextChest17.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.AquaticChestUnlocked; }

            if (timesPurchasedChests == 17) { boughtChest18 = 1; arrowNextChest18.SetActive(true); unlockedCursor14.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.WindwalkersChestUnlocked;
                if (cursorsBar.activeInHierarchy == false) { cursorExlemationmark.SetActive(true); }
            }

            if (timesPurchasedChests == 18) { boughtChest19 = 1; arrowNextChest19.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.EnchantedChestUnlocked; }

            if (timesPurchasedChests == 19) { boughtChest20 = 1; arrowNextChest20.SetActive(true); unlockedCursor15.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.RoyalChestUnlocked;
                if (cursorsBar.activeInHierarchy == false) { cursorExlemationmark.SetActive(true); }
            }

            if (timesPurchasedChests == 20) { boughtChest21 = 1; arrowNextChest21.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.ArcaneChestUnlocked; }

            if (timesPurchasedChests == 21) { boughtChest22 = 1; arrowNextChest22.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.GrandioseChestUnlocked; }

            if (timesPurchasedChests == 22) { boughtChest23 = 1; arrowNextChest23.SetActive(true); unlockedCursor16.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.LuxuriousGoldenChestUnlocked;
                if (cursorsBar.activeInHierarchy == false) { cursorExlemationmark.SetActive(true); }
            }

            if (timesPurchasedChests == 23) { boughtChest24 = 1; arrowNextChest24.SetActive(true); unlockedCursor17.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.SacredChestUnlocked;
                if (cursorsBar.activeInHierarchy == false) { cursorExlemationmark.SetActive(true); }
            }

            if (timesPurchasedChests == 24) { boughtChest25 = 1; arrowNextChest25.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.EternitysEmbraceChestUnlocked; }

            if (timesPurchasedChests == 25) { boughtChest26 = 1; arrowNextChest26.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.ForgottenChestUnlocked; }

            if (timesPurchasedChests == 26) { boughtChest27 = 1; arrowNextChest27.SetActive(true); unlockedCursor18.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.LivingLuminousChestUnlocked;
                if (cursorsBar.activeInHierarchy == false) { cursorExlemationmark.SetActive(true); }
            }

            if (timesPurchasedChests == 27)
            {
                 arrowNextChest28.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.FortressOfWealthUnlocked;
                if (cursorsBar.activeInHierarchy == false) {  }
            }

            if (timesPurchasedChests == 28)
            {
                arrowNextChest29.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.FortifiedTimberChestUnlocked;
                if (cursorsBar.activeInHierarchy == false) { }
            }

            if (timesPurchasedChests == 29)
            {
                arrowNextChest30.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.RadiantFrostlockUnlocked;
                if (cursorsBar.activeInHierarchy == false) { }
            }

            if (timesPurchasedChests == 30)
            {
                arrowNextChest31.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.InfernoEmbracedChestUnlocked;
                unlockedCursor19.SetActive(true);
                if (cursorsBar.activeInHierarchy == false) { cursorExlemationmark.SetActive(true); }
            }

            if (timesPurchasedChests == 31)
            {
                arrowNextChest32.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.DeathChestUnlocked;
                if (cursorsBar.activeInHierarchy == false) { }
            }
            if (timesPurchasedChests == 32)
            {
                arrowNextChest33.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.AlienChestUnlocked;
                if (cursorsBar.activeInHierarchy == false) { }
            }
            if (timesPurchasedChests == 33)
            {
                arrowNextChest34.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.CraftsmansReliquaryUnlocked;
                if (cursorsBar.activeInHierarchy == false) { }
            }
            if (timesPurchasedChests == 34)
            {
                arrowNextChest35.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.HellfireGuardianChestUnlocked;
                unlockedCursor20.SetActive(true);
                if (cursorsBar.activeInHierarchy == false) { cursorExlemationmark.SetActive(true); }
            }
            if (timesPurchasedChests == 35)
            {
                arrowNextChest36.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.GhastlySoulHoardChestUnlocked;
                if (cursorsBar.activeInHierarchy == false) { }
            }
            if (timesPurchasedChests == 36)
            {
                arrowNextChest37.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.HighTechCacheUnlocked;
                if (cursorsBar.activeInHierarchy == false) { }
            }
            if (timesPurchasedChests == 37)
            {
                arrowNextChest38.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.EliteHackersStrongboxUnlocked;
                unlockedCursor21.SetActive(true);
                if (cursorsBar.activeInHierarchy == false) { cursorExlemationmark.SetActive(true); }
            }
            if (timesPurchasedChests == 38)
            {
                arrowNextChest39.SetActive(true); chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.CollectorsVaultUnlocked;
                if (cursorsBar.activeInHierarchy == false) { }
            }
            if (timesPurchasedChests == 39)
            {
                chestNameText.GetComponent<TextMeshProUGUI>().text = Localization.ExquisiteAzureRadianceChestUnlocked;
                if (cursorsBar.activeInHierarchy == false) { }
            }

            StartCoroutine(waitPrice());

            SelectChests.currentMiniChestGoldValue = ((SelectChests.randomMinGold + SelectChests.randomMaxGold) / 2);
           

            prestigeKeyDropChance.text = Localization.prestigeKeyChance1 + 0.017 * (UnlockChests.timesPurchasedChests + 1) + Localization.prestigeKeyChance2;
            prestigeChestDropChance.text = Localization.prestieChestKey1 + 0.017 * (UnlockChests.timesPurchasedChests + 1) + Localization.prestieChestKey2;

            SelectChests.chestNotUnlocked = false;

            UpdateGame.totalGoldHigher -= SelectChests.chestPrice;
            lockedChest.SetActive(false);
            SelectChests.notUnlockedChest = false;
            ChangeColor();
            mobileScript.CheckCursorInfo();
        }
    }

    IEnumerator waitPrice()
    {
        yield return new WaitForSeconds(0.35f);

        currentSellPrice = SelectChests.randomMaxGold * (1 + SkillTree.skillTreeGold + RareTreasures.runeGold + RareTreasures.cookieGold + RareTreasures.backPackGold + UseConsumable.scrollGoldBuff + UseConsumable.relicPermaGoldBuff);

    }

    IEnumerator waitPrice2()
    {
        yield return new WaitForSeconds(1.25f);

        currentSellPrice = SelectChests.randomMaxGold * (1 + SkillTree.skillTreeGold + RareTreasures.runeGold + RareTreasures.cookieGold + RareTreasures.backPackGold + UseConsumable.scrollGoldBuff + UseConsumable.relicPermaGoldBuff);

        //Debug.Log(currentSellPrice);
    }

    public void ChangeColor()
    {
        Color newColor;
        ColorUtility.TryParseHtmlString(newHexValue, out newColor);

        if (boughtChest2 == 1) { chest2.GetComponent<Image>().color = newColor; }
        if (boughtChest3 == 1) { chest3.GetComponent<Image>().color = newColor; }
        if (boughtChest4 == 1) { chest4.GetComponent<Image>().color = newColor; }
        if (boughtChest5 == 1) { chest5.GetComponent<Image>().color = newColor; }
        if (boughtChest6 == 1) { chest6.GetComponent<Image>().color = newColor; }
        if (boughtChest7 == 1) { chest7.GetComponent<Image>().color = newColor; }
        if (boughtChest8 == 1) { chest8.GetComponent<Image>().color = newColor; }
        if (boughtChest9 == 1) { chest9.GetComponent<Image>().color = newColor; }
        if (boughtChest10 == 1) { chest10.GetComponent<Image>().color = newColor; }
        if (boughtChest11 == 1) { chest11.GetComponent<Image>().color = newColor; }
        if (boughtChest12 == 1) { chest12.GetComponent<Image>().color = newColor; }
        if (boughtChest13 == 1) { chest13.GetComponent<Image>().color = newColor; }
        if (boughtChest14 == 1) { chest14.GetComponent<Image>().color = newColor; }
        if (boughtChest15 == 1) { chest15.GetComponent<Image>().color = newColor; }
        if (boughtChest16 == 1) { chest16.GetComponent<Image>().color = newColor; }
        if (boughtChest17 == 1) { chest17.GetComponent<Image>().color = newColor; }
        if (boughtChest18 == 1) { chest18.GetComponent<Image>().color = newColor; }
        if (boughtChest19 == 1) { chest19.GetComponent<Image>().color = newColor; }
        if (boughtChest20 == 1) { chest20.GetComponent<Image>().color = newColor; }
        if (boughtChest21 == 1) { chest21.GetComponent<Image>().color = newColor; }
        if (boughtChest22 == 1) { chest22.GetComponent<Image>().color = newColor; }
        if (boughtChest23 == 1) { chest23.GetComponent<Image>().color = newColor; }
        if (boughtChest24 == 1) { chest24.GetComponent<Image>().color = newColor; }
        if (boughtChest25 == 1) { chest25.GetComponent<Image>().color = newColor; }
        if (boughtChest26 == 1) { chest26.GetComponent<Image>().color = newColor; }
        if (boughtChest27 == 1) { chest27.GetComponent<Image>().color = newColor; }
        if (timesPurchasedChests > 26) { chest28.GetComponent<Image>().color = newColor; }
        if (timesPurchasedChests > 27) { chest29.GetComponent<Image>().color = newColor; }
        if (timesPurchasedChests > 28) { chest30.GetComponent<Image>().color = newColor; }
        if (timesPurchasedChests > 29) { chest31.GetComponent<Image>().color = newColor; }
        if (timesPurchasedChests > 30) { chest32.GetComponent<Image>().color = newColor; }
        if (timesPurchasedChests > 31) { chest33.GetComponent<Image>().color = newColor; }
        if (timesPurchasedChests > 32) { chest34.GetComponent<Image>().color = newColor; }
        if (timesPurchasedChests > 33) { chest35.GetComponent<Image>().color = newColor; }
        if (timesPurchasedChests > 34) { chest36.GetComponent<Image>().color = newColor; }
        if (timesPurchasedChests > 35) { chest37.GetComponent<Image>().color = newColor; }
        if (timesPurchasedChests > 36) { chest38.GetComponent<Image>().color = newColor; }
        if (timesPurchasedChests > 37) { chest39.GetComponent<Image>().color = newColor; }
        if (timesPurchasedChests > 38) { chest40.GetComponent<Image>().color = newColor; }
    }
   

    public void ResetUnlockedCursors()
    {
        unlockedCursor4.SetActive(false);
        unlockedCursor5.SetActive(false);
        unlockedCursor6.SetActive(false);
        unlockedCursor7.SetActive(false);
        unlockedCursor8.SetActive(false);
        unlockedCursor9.SetActive(false);
        unlockedCursor10.SetActive(false);
        unlockedCursor11.SetActive(false);
        unlockedCursor12.SetActive(false);
        unlockedCursor13.SetActive(false);
        unlockedCursor14.SetActive(false);
        unlockedCursor15.SetActive(false);
        unlockedCursor16.SetActive(false);
        unlockedCursor17.SetActive(false);
        unlockedCursor18.SetActive(false);
        unlockedCursor19.SetActive(false);
        unlockedCursor20.SetActive(false);
        unlockedCursor21.SetActive(false);
    }
}
