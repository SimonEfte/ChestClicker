using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class TotalGoldAmount : MonoBehaviour, IDataPersistence
{
    public TextMeshProUGUI goldAmountText;
    public Image goldImage;
    public static float totalGold = 0;

    public GameObject textParent, barrelParent;
    public void Start()
    {
        Invoke("wait", 0.4f);
    }

    public void wait()
    {
        string path = Application.persistentDataPath + "/player.saveGold";

        if (File.Exists(path))
        {
            //Load Auto Damage
            if (SaveAndLoad.onlyLoadNewSave == false)
            {
                GameData data = SaveSystem.loadGold();
                totalGold = data.totalGold;

                UpdateGame.totalGoldHigher = totalGold;
            }
            else { }
        }
        else
        {
            //Do nothing
        }
    }

    #region SaveAndLoadJSON
    public void LoadData(GameDataJSON data)
    {
        totalGold = data.totalGold;
    }

    public void SaveData(ref GameDataJSON data)
    {
        data.totalGold = totalGold;
    }
    #endregion

    #region format coins FLOAT
    public static string FormatCoins(float coins)
    {
        return coins switch
        {
            >= 1E+36f => ((float)coins / 1E+36).ToString("0.###") + "U",
            >= 1E+33f => ((float)coins / 1E+33).ToString("0.###") + "D",
            >= 1E+30f => ((float)coins / 1E+30).ToString("0.###") + "N",
            >= 1E+27f => ((float)coins / 1E+27).ToString("0.###") + " OCT",
            >= 1E+24f => ((float)coins / 1E+24).ToString("0.###") + "SPT",
            >= 1E+21f => ((float)coins / 1E+21).ToString("0.###") + "SXT",
            >= 1E+18f => ((float)coins / 1E+18).ToString("0.###") + "QT",
            >= 1E+15f => ((float)coins / 1E+15).ToString("0.###") + "QD",
            >= 1E+12f => ((float)coins / 1E+12).ToString("0.###") + "T",
            >= 1E+09f => ((float)coins / 1E+09).ToString("0.###") + "B",
            >= 1000000f => ((float)coins / 1E+06).ToString("0.###") + "M",
            >= 1000f => ((float)coins / 1).ToString("0"),
            _ => coins.ToString("0")
        };
    }

    public static string FormatCoinsFull(float coins)
    {
        return coins switch
        {
            >= 1E+36f => ((float)coins / 1E+36).ToString("0.###") + " Undecillion",
            >= 1E+33f => ((float)coins / 1E+33).ToString("0.###") + " Decillion",
            >= 1E+30f => ((float)coins / 1E+30).ToString("0.###") + " Nonillion",
            >= 1E+27f => ((float)coins / 1E+27).ToString("0.###") + " Octillion",
            >= 1E+24f => ((float)coins / 1E+24).ToString("0.###") + " Septillion",
            >= 1E+21f => ((float)coins / 1E+21).ToString("0.###") + " Sextillion",
            >= 1E+18f => ((float)coins / 1E+18).ToString("0.###") + " Quintillion",
            >= 1E+15f => ((float)coins / 1E+15).ToString("0.###") + " Quadrillion",
            >= 1E+12f => ((float)coins / 1E+12).ToString("0.###") + " Trillion",
            >= 1E+09f => ((float)coins / 1E+09).ToString("0.###") + " Billion",
            >= 1000000f => ((float)coins / 1E+06).ToString("0.###") + " Million",
            >= 1000f => ((float)coins / 1).ToString("0"),
            _ => coins.ToString("0")
        };
    }
    #endregion

    #region format coins DOUBLE
    public static string FormatCoinsDouble(double coins)
    {
        return coins switch
        {
            >= 1E+72 => (coins / 1E+72).ToString("0.###") + Localization.Trevigintillion,
            >= 1E+69 => (coins / 1E+69).ToString("0.###") + Localization.Duovigintillion,
            >= 1E+66 => (coins / 1E+66).ToString("0.###") + Localization.Unvigintillion,
            >= 1E+63 => (coins / 1E+63).ToString("0.###") + Localization.Vigintillion,
            >= 1E+60 => (coins / 1E+60).ToString("0.###") + Localization.Novemdecillion,
            >= 1E+57 => (coins / 1E+57).ToString("0.###") + Localization.Octodecillion,
            >= 1E+54 => (coins / 1E+54).ToString("0.###") + Localization.Septendecillion,
            >= 1E+51 => (coins / 1E+51).ToString("0.###") + Localization.Sexdecillion,
            >= 1E+48 => (coins / 1E+48).ToString("0.###") + Localization.Quindecillion,
            >= 1E+45 => (coins / 1E+45).ToString("0.###") + Localization.Quattuordecillion,
            >= 1E+42 => (coins / 1E+42).ToString("0.###") + Localization.Tredecillion,
            >= 1E+39 => (coins / 1E+39).ToString("0.###") + Localization.Duodecillion,
            >= 1E+36 => (coins / 1E+36).ToString("0.###") + Localization.Undecillion,
            >= 1E+33 => (coins / 1E+33).ToString("0.###") + Localization.Decillion,
            >= 1E+30 => (coins / 1E+30).ToString("0.###") + Localization.Nonillion,
            >= 1E+27 => (coins / 1E+27).ToString("0.###") + Localization.Octillion,
            >= 1E+24 => (coins / 1E+24).ToString("0.###") + Localization.Septillion,
            >= 1E+21 => (coins / 1E+21).ToString("0.###") + Localization.Sextillion,
            >= 1E+18 => (coins / 1E+18).ToString("0.###") + Localization.Quintillion,
            >= 1E+15 => (coins / 1E+15).ToString("0.###") + Localization.Quadrillion,
            >= 1E+12 => (coins / 1E+12).ToString("0.###") + Localization.Trillion,
            >= 1E+09 => (coins / 1E+09).ToString("0.###") + Localization.Billion,
            >= 1E+06 => (coins / 1E+06).ToString("0.###") + Localization.Million,
            _ => coins.ToString("0")
        };
    }

    public static string FormatCoinsDoubleOneLetter(double coins)
    {
        return coins switch
        {
            >= 1E+72 => (coins / 1E+72).ToString("0.###") + Localization.TrevigintillionShort,
            >= 1E+69 => (coins / 1E+69).ToString("0.###") + Localization.DuovigintillionShort,
            >= 1E+66 => (coins / 1E+66).ToString("0.###") + Localization.UnvigintillionShort,
            >= 1E+63 => (coins / 1E+63).ToString("0.###") + Localization.VigintillionShort,
            >= 1E+60 => (coins / 1E+60).ToString("0.###") + Localization.NovemdecillionShort,
            >= 1E+57 => (coins / 1E+57).ToString("0.###") + Localization.OctodecillionShort,
            >= 1E+54 => (coins / 1E+54).ToString("0.###") + Localization.SeptendecillionShort,
            >= 1E+51 => (coins / 1E+51).ToString("0.###") + Localization.SexdecillionShort,
            >= 1E+48 => (coins / 1E+48).ToString("0.###") + Localization.QuindecillionShort,
            >= 1E+45 => (coins / 1E+45).ToString("0.###") + Localization.QuattuordecillionShort,
            >= 1E+42 => (coins / 1E+42).ToString("0.###") + Localization.TredecillionShort,
            >= 1E+39 => (coins / 1E+39).ToString("0.###") + Localization.DuodecillionShort,
            >= 1E+36 => (coins / 1E+36).ToString("0.###") + Localization.UndecillionShort,
            >= 1E+33 => (coins / 1E+33).ToString("0.###") + Localization.DecillionShort,
            >= 1E+30 => (coins / 1E+30).ToString("0.###") + Localization.NonillionShort,
            >= 1E+27 => (coins / 1E+27).ToString("0.###") + Localization.OctillionShort,
            >= 1E+24 => (coins / 1E+24).ToString("0.###") + Localization.SeptillionShort,
            >= 1E+21 => (coins / 1E+21).ToString("0.###") + Localization.SextillionShort,
            >= 1E+18 => (coins / 1E+18).ToString("0.###") + Localization.QuintillionShort,
            >= 1E+15 => (coins / 1E+15).ToString("0.###") + Localization.QuadrillionShort,
            >= 1E+12 => (coins / 1E+12).ToString("0.###") + Localization.TrillionShort,
            >= 1E+09 => (coins / 1E+09).ToString("0.###") + Localization.BillionShort,
            >= 1E+06 => (coins / 1E+06).ToString("0.###") + Localization.MillionShort,
            _ => coins.ToString("0")
        };
    }

    #endregion

    public TMP_FontAsset korean, english, russian, japanese, chinese;

    void Update()
    {
        goldAmountText.text = FormatCoinsDouble(UpdateGame.totalGoldHigher);
        if(PlaceMobileButtons.isMobile == true && Localization.RussianLanguageChosen == 1) { goldAmountText.fontSize = 33f; }
        else { goldAmountText.fontSize = 42f; }

        //if(totalGold < 50000000000000000000000000000000000000f) { goldAmountText.text = FormatCoinsFull(totalGold); }
        //if (totalGold > 50000000000000000000000000000000000000f) { goldAmountText.text = FormatCoinsDouble(UpdateGame.totalGoldHigher); }

        if (ReturnToPools.plussGold == true)
        {
            ReturnToPools.plussGold = false;
            GameObject goldText = ObjectPooling.instance.GetGoldTextFromPool();

            if (Localization.EnglishLanguageChosen == 1) { goldText.GetComponent<TextMeshProUGUI>().font = english; }
            if (Localization.RussianLanguageChosen == 1) { goldText.GetComponent<TextMeshProUGUI>().font = russian; }
            if (Localization.JapaneseLanguageChosen == 1) { goldText.GetComponent<TextMeshProUGUI>().font = japanese; }
            if (Localization.ChineseLanguageChosen == 1) { goldText.GetComponent<TextMeshProUGUI>().font = chinese; }
            if (Localization.KoreanLanguageChosen == 1) { goldText.GetComponent<TextMeshProUGUI>().font = korean; }

            goldText.GetComponent<Animation>().Play();
            goldText.transform.SetParent(textParent.transform, false);
            goldText.transform.localScale = new Vector3(1, 1, 1);
            goldText.transform.position = textParent.transform.position;
            goldText.GetComponent<TextMeshProUGUI>().text = "+" + FormatCoinsDouble(ReturnToPools.goldCountDouble);
            StartCoroutine(ReturnTextFromPoolDelayed(goldText, 0.5f));
        }

        if (ReturnToPools.plussGoldBarrel == true)
        {
            ReturnToPools.plussGoldBarrel = false;
            GameObject goldText = ObjectPooling.instance.GetGoldTextFromPool();

            if (Localization.EnglishLanguageChosen == 1) { goldText.GetComponent<TextMeshProUGUI>().font = english; }
            if (Localization.RussianLanguageChosen == 1) { goldText.GetComponent<TextMeshProUGUI>().font = russian; }
            if (Localization.JapaneseLanguageChosen == 1) { goldText.GetComponent<TextMeshProUGUI>().font = japanese; }
            if (Localization.ChineseLanguageChosen == 1) { goldText.GetComponent<TextMeshProUGUI>().font = chinese; }
            if (Localization.KoreanLanguageChosen == 1) { goldText.GetComponent<TextMeshProUGUI>().font = korean; }

            goldText.GetComponent<Animation>().Play();
            goldText.transform.SetParent(barrelParent.transform, false);
            goldText.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
            goldText.transform.position = barrelParent.transform.position;
            goldText.GetComponent<TextMeshProUGUI>().text = "+" + FormatCoinsDouble(ReturnToPools.goldCountDouble * (1 + UpdateGame.barrelGoldValue));
            StartCoroutine(ReturnTextFromPoolDelayed(goldText, 0.5f));
        }

    }
    private IEnumerator ReturnTextFromPoolDelayed(GameObject goldText, float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        ObjectPooling.instance.ReturnGoldTextFromPool(goldText);
    }

    public void RemovePlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }

    public void plussGoldChest()
    {
        UpdateGame.totalGoldHigher += SelectChests.chestPrice;
    }

    public void plussGold()
    {
        UpdateGame.totalGoldHigher += 999000000000000000000000000000000000000000000000000000000.5;
        PlayerLevel.playerLevel += 1;
    }
    public void pluss1T()
    {
        PlayerLevel.skillPoints += 1000;
        UpdateGame.totalGoldHigher += 1000000000000000000000000f;
    }
    public void pluss1B()
    {
        UpdateGame.totalGoldHigher += 1000000000;
    }
    public void pluss1M()
    {
        UpdateGame.totalGoldHigher += 1000000;
    }
    public void pluss100K()
    {
        UpdateGame.totalGoldHigher += 100000;
    }
    public void pluss1K()
    {
        UpdateGame.totalGoldHigher += 1000;
    }

    public void resetSpesific()
    {
        //PlayerLevel.skillPoints += 1000;
        RareDropsCollected.violetCrystalCount += 500;
        RareDropsCollected.yellowSapphireCount += 500;
        RareDropsCollected.elysiumPrismCount += 500;
        RareDropsCollected.astraliumCount += 500;

        RareDropsCollected.quasariteCount += 500;
        RareDropsCollected.radiantNovaStoneCount += 500;
        RareDropsCollected.soluniumShardCount += 500;

        UseConsumable.relicCount += 500;
    }

    public GameObject savedGameText;

    public void SaveText()
    {
        savedGameText.SetActive(true);
        StartCoroutine(wait2());
    }

    IEnumerator wait2()
    {
        yield return new WaitForSeconds(1.5f);
        savedGameText.SetActive(false);
    }
}
