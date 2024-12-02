using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIelementsClick : MonoBehaviour
{
    public GameObject leftBars;
    public GameObject rightBars;
    public GameObject settingsBar;
    public GameObject uniqueDropsBar;
    public float alphaValue = 0.5f;
    public float alphaValueFull = 1f;
    public GameObject statsBar;
    public static bool hideCursors;

    #region UpgradesAndItemsBars

    public void rightBarOpenExit()
    {
        if(rightBars.activeInHierarchy == true) { rightBars.SetActive(false); }
        else if (rightBars.activeInHierarchy == false) {
            rightBars.SetActive(true);
        }
    }

    public void leftBarOpenAndExt()
    {
        if (leftBars.activeInHierarchy == true) { leftBars.SetActive(false); }
        else if (leftBars.activeInHierarchy == false) {
            leftBars.SetActive(true);
        }
    }

    #endregion

    public GameObject rareDropsBar;
    public GameObject consumablesBar;
    public GameObject specialUpgradesBar;
    public GameObject cursorUpgradesBar;
    public GameObject prestigeBar;

    public Image cursorBar, specialBar, itemsBar, conumableBar, prestigeBarLeft;
    public GameObject prestigeExl;
    public GameObject mimicTurnedOffText;

    public void Start()
    {
        prestigeExl.SetActive(false);

        if (!PlayerPrefs.HasKey("MimicChest"))
        {
            turnOfMimicChest = 0;
            offButton.SetActive(false);
            OnButton.SetActive(true);
            mimicTurnedOffText.SetActive(false);
        }
        else
        {
            turnOfMimicChest = PlayerPrefs.GetInt("MimicChest");

            if (turnOfMimicChest == 1)
            {
                offButton.SetActive(true);
                OnButton.SetActive(false);
                mimicTurnedOffText.SetActive(true);
            }

            if (turnOfMimicChest == 0)
            {
                offButton.SetActive(false);
                OnButton.SetActive(true);
                mimicTurnedOffText.SetActive(false);
            }
        }

       
    }

    public void Update()
    {
        if(prestigeBar.activeInHierarchy == true)
        {
            prestigeExl.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("UIClick1"); }
            if (settingsBar.activeInHierarchy == true) { settingsBar.SetActive(false); hideCursors = false; wishToResetBar.SetActive(false); }
            else if (settingsBar.activeInHierarchy == false) { settingsBar.SetActive(true); hideCursors = true; }
            statsBar.SetActive(false);
        }
    }

    public void OpenRareDrops()
    {
        setTreasureFalse();

        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("UIClick3"); }
        prestigeBar.SetActive(false);
        rareDropsBar.SetActive(true);
        consumablesBar.SetActive(false);

        if (consumablesBar != null) { SetAlphaConumableBar(conumableBar, alphaValue); }
        SetAlphaGemBAr(itemsBar, alphaValueFull);
        SetAlphaGemBAr(prestigeBarLeft, alphaValue);
    }

    public void OpenConsumables()
    {
        if(PlaceMobileButtons.isMobile == true) { return; }
        setTreasureFalse();

        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("UIClick3"); }
        prestigeBar.SetActive(false);
        rareDropsBar.SetActive(false);
        consumablesBar.SetActive(true);

        if (itemsBar != null) { SetAlphaGemBAr(itemsBar, alphaValue); }
        SetAlphaConumableBar(conumableBar, alphaValueFull);
        SetAlphaGemBAr(prestigeBarLeft, alphaValue);
    }

    public void OpenPrestigeBar()
    {
        setTreasureFalse();

        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("UIClick3"); }
        rareDropsBar.SetActive(false);
        consumablesBar.SetActive(false);
        prestigeBar.SetActive(true);

        SetAlphaGemBAr(conumableBar, alphaValue);
        SetAlphaGemBAr(itemsBar, alphaValue);
        SetAlphaConumableBar(prestigeBarLeft, alphaValueFull);
    }

    public void setTreasureFalse()
    {
        ReturnRedGem.setQuartz = false; ReturnRedGem.setAmethyst = false; ReturnRedGem.setYellowTopaz = false; ReturnRedGem.setAlbite = false; ReturnRedGem.setRedGarnet = false; ReturnRedGem.setAquamarine = false; ReturnRedGem.setYellowSapphire = false; ReturnRedGem.setPinkTourmaline = false; ReturnRedGem.setAdventurine = false; ReturnRedGem.setRedRuby = false; ReturnRedGem.setDiamond = false; ReturnRedGem.SetGrandiderite = false; ReturnRedGem.setVioletCrystal = false; ReturnRedGem.setAkoyaPearl = false; ReturnRedGem.setPurpleRupee = false; ReturnRedGem.setEmerald = false; ReturnRedGem.setGreenDiamond = false; ReturnRedGem.setFireOpal = false; ReturnRedGem.setGemSilica = false; ReturnRedGem.setPinkPlort = false; ReturnRedGem.setGoldejSeaPearl = false; ReturnRedGem.setKyanite = false; ReturnRedGem.setBlackOpal = false; ReturnRedGem.setPainite = false;
        ReturnRedGem.setTanzanite = false; ReturnRedGem.setAstralium = false; ReturnRedGem.setElysiumPrism = false; ReturnRedGem.setAetherfireOpal = false; ReturnRedGem.setEldritchStarstone = false; ReturnRedGem.setChronolithShard = false; ReturnRedGem.setSideriumEssence = false; ReturnRedGem.setQuasarite = false; ReturnRedGem.setRadiantNovaStone = false; ReturnRedGem.setSoluniumShard = false;

        ReturnRedGem.setLockPick = false; ReturnRedGem.setHammer = false; ReturnRedGem.setLootPotion = false; ReturnRedGem.setDamagePotion = false; ReturnRedGem.setXPPotion = false; ReturnRedGem.setGoldenTouch = false; ReturnRedGem.setKey = false;  ReturnRedGem.setScroll = false; ReturnRedGem.setGauntlet = false; ReturnRedGem.setElixir = false; ReturnRedGem.setRelic = false; ReturnRedGem.setTreasurePotion = false; ReturnRedGem.setKnife = false;
    }

    public GameObject cursorExlemationmark, shopExlemationmar;

    public void OpenCursorsUpgrades()
    {
        if (PlaceMobileButtons.isMobile == true) { return; }
        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("UIClick3"); }
        specialUpgradesBar.SetActive(false);
        cursorUpgradesBar.SetActive(true);
        cursorExlemationmark.SetActive(false);

        if (specialBar != null) { SetAlphaSpecialUpgrades(specialBar, alphaValue); }
        SetAlpha(cursorBar, alphaValueFull);
    }

    public void OpenSpecialUpgrades()
    {
        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("UIClick3"); }
        specialUpgradesBar.SetActive(true);
        cursorUpgradesBar.SetActive(false);

        shopExlemationmar.SetActive(false);

        if (cursorBar != null)
        {
            SetAlpha(cursorBar, alphaValue);
        }
        SetAlphaSpecialUpgrades(specialBar, alphaValueFull);
    }

    public void OpenSettings()
    {
        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("UIClick1"); } 
        if (settingsBar.activeInHierarchy == true) { settingsBar.SetActive(false); hideCursors = false; wishToResetBar.SetActive(false); }
        else if (settingsBar.activeInHierarchy == false) { settingsBar.SetActive(true); hideCursors = true; }
        statsBar.SetActive(false);
    }

    public GameObject generalSettings, infoSettings;
    public Image generalTab, infoTab;

    public void OpenGeneralSettings()
    {
        generalSettings.SetActive(true);
        infoSettings.SetActive(false);

        if (infoTab != null)
        {
            SetAlpha(infoTab, alphaValue);
        }
        SetAlphaSpecialUpgrades(generalTab, alphaValueFull);
    }

    public void OpenInfoSettings()
    {
        generalSettings.SetActive(false);
        infoSettings.SetActive(true);

        if (generalTab != null)
        {
            SetAlpha(generalTab, alphaValue);
        }
        SetAlphaSpecialUpgrades(infoTab, alphaValueFull);
    }

    public void OpenUniqueDrops()
    {
        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("UIClick1"); }
        hideCursors = true;
        if (uniqueDropsBar.activeInHierarchy == true) { uniqueDropsBar.SetActive(false); }
        else if (uniqueDropsBar.activeInHierarchy == false) { uniqueDropsBar.SetActive(true); }
    }

    public void ExitUniqueDrops()
    {
        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("UIClick1"); }
        hideCursors = false;
        uniqueDropsBar.SetActive(false);

    }

    public void ExitSettings()
    {
        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("UIClick1"); }
        hideCursors = false;
        settingsBar.SetActive(false);
        wishToResetBar.SetActive(false);
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


    private void SetAlphaSpecialUpgrades(Graphic graphic, float alpha)
    {
        Color currentColor = graphic.color;
        currentColor.a = alpha;
        graphic.color = currentColor;

        for (int i = 0; i < graphic.transform.childCount; i++)
        {
            Graphic childGraphic = graphic.transform.GetChild(i).GetComponent<Graphic>();
            if (childGraphic != null)
            {
                SetAlphaSpecialUpgrades(childGraphic, alpha);
            }
        }
    }


    private void SetAlphaGemBAr(Graphic graphic, float alpha)
    {
        Color currentColor = graphic.color;
        currentColor.a = alpha;
        graphic.color = currentColor;

        for (int i = 0; i < graphic.transform.childCount; i++)
        {
            Graphic childGraphic = graphic.transform.GetChild(i).GetComponent<Graphic>();
            if (childGraphic != null)
            {
                SetAlphaGemBAr(childGraphic, alpha);
            }
        }
    }


    private void SetAlphaConumableBar(Graphic graphic, float alpha)
    {
        Color currentColor = graphic.color;
        currentColor.a = alpha;
        graphic.color = currentColor;

        for (int i = 0; i < graphic.transform.childCount; i++)
        {
            Graphic childGraphic = graphic.transform.GetChild(i).GetComponent<Graphic>();
            if (childGraphic != null)
            {
                SetAlphaConumableBar(childGraphic, alpha);
            }
        }
    }

    public GameObject wishToResetBar, resetBlock;
    public void WishToResetButton()
    {
        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("UIClick1"); }
        wishToResetBar.SetActive(true);
        if(PlaceMobileButtons.isMobile == true) { resetBlock.transform.localScale = new Vector2(4.4f, 4.4f); }
    }

    public void DoNotReset()
    {
        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("UIClick1"); }
        wishToResetBar.SetActive(false);
    }

    public void YesReset()
    {
        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("UIClick1"); }
        settingsBar.SetActive(false);
        wishToResetBar.SetActive(false);
    }

    public static int turnOfMimicChest;
    public GameObject offButton, OnButton;

    public void TurnOffMimicChest()
    {
        turnOfMimicChest = 1;
        PlayerPrefs.SetInt("MimicChest", turnOfMimicChest);
        offButton.SetActive(true);
        OnButton.SetActive(false);
        mimicTurnedOffText.SetActive(true);
    }

    public void TurnOnMimiChest()
    {
        turnOfMimicChest = 0;
        PlayerPrefs.SetInt("MimicChest", turnOfMimicChest);
        offButton.SetActive(false);
        OnButton.SetActive(true);
        mimicTurnedOffText.SetActive(false);
    }


    public void ExitGame()
    {
        Application.Quit();
    }
}
