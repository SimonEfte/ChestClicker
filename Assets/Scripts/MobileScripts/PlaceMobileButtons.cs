using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlaceMobileButtons : MonoBehaviour
{
    public static bool isMobile;

    public GameObject bottomBar;
    public RectTransform goldBar;
    public GameObject UIElements;

    public float setTransformPos;
    public GameObject allBuffs;

    public GameObject firstTimePlayingScreen;
    public GameObject testObject1, testObject2, testObject3;
    public GameObject scrollView;
    public GameObject googlePlayBtn, appStoreBtn;

    IEnumerator Waititin()
    {
        yield return new WaitForSeconds(10);
        testObject1.SetActive(false);
        testObject2.SetActive(false);
        testObject3.SetActive(false);
        phoneText.gameObject.SetActive(false);
    }

    //samsung SM-S921B

    public TextMeshProUGUI phoneText;
    public static bool isFoldPhone;

    public void Awake()
    {
        isMobile = false;
        if(isMobile == true)
        {
            googlePlayBtn.SetActive(false);
            appStoreBtn.SetActive(false);
            string deviceModel = SystemInfo.deviceModel;

            //phoneText.text = deviceModel;
            //isFoldPhone = true;

            if (deviceModel.Contains("SM-F916B") || deviceModel.Contains("SM-F916U") || deviceModel.Contains("SM-F916N") || deviceModel.Contains("SM-F9160") || deviceModel.Contains("SM-F916W"))
            {
                isFoldPhone = true;
            }

            firstTimePlayingScreen.transform.localScale = new Vector2(0.54f, 0.54f);

            allBuffs.transform.localPosition = new Vector2(-13.69f, 200f);
            allBuffs.transform.localScale = new Vector2(1.3f, 1.3f);
            allBuffs.GetComponent<RectTransform>().sizeDelta = new Vector2(338, 77);

            rightBar.SetActive(true);

            SetAnchor(goldBar, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f));

            SetAnchor(rightBar.GetComponent<RectTransform>(), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f));
            SetAnchor(leftBar.GetComponent<RectTransform>(), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f));
            SetAnchor(maxOr1XFrame.GetComponent<RectTransform>(), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f));
            maxOr1XFrame.SetActive(false);
            chestTransform.transform.localPosition = new Vector2(0, setTransformPos);

            setTransformPos = -10f;
            allBottomsBtns.gameObject.SetActive(true);

            scrollView.SetActive(true);
            scrollBar.SetActive(true);
            bottomBar.SetActive(true);
            UIElements.SetActive(false);
            SetShopAndCursors();
            SetFramesPos();
            StartCoroutine(wait());
            SetRareTreasureFrame();
            SetPrestigeScreen();
        }
        else
        {
            scrollView.SetActive(false);
            scrollBar.SetActive(false);
            rightBar.SetActive(true);
            leftBar.SetActive(true);
            coolStuffBtn.SetActive(true);
            mobileSettingFrame.SetActive(false);
            closeSettings.SetActive(false);
            allBottomsBtns.gameObject.SetActive(false);
            bottomBar.SetActive(false);

            for (int i = 0; i < shopInfoBoxes.Length; i++)
            {
                shopInfoBoxes[i].SetActive(false);
            }

            for (int i = 0; i < cursorInfoBoxes.Length; i++)
            {
                cursorInfoBoxes[i].SetActive(false);
            }
        }
    }

    public void Start()
    {
        if(isMobile == true)
        {
            Application.targetFrameRate = 60;
        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.5f);
        CheckShopQuestionMarks();
        CheckCursorInfo();
    }

    public GameObject rightBar, leftBar, coolStuffBtn, levelBar;
    public Transform selectScrenBtns, chestBackgroundParent, maxFrameParent;
    public GameObject chestBackground;
    public GameObject activeBTN, passiveBTN, infoTooltip, autoPurchaseBTN;
    public GameObject passiveFrameExit, activeFrameExit, itemsTopBTN, treasureTopBTN, prestigeTopBTN, cursorTopBTN, shopTopBTN;
    public GameObject maxOr1XFrame;
    public GameObject shopInfo, cursorInfo, sellTreasureCloseTopRight, skillPoint;
    public GameObject prestigeBarRight;
    public GameObject goldParent, treasuresParent, dropsParent;
    public Transform miscScreen;
    public GameObject max1XframeImage, max1xArrow, x1Button, maxButton, purchasingMaxText;
    public GameObject allBottomsBtns, chestArros;
    public GameObject englishBtn, japaneseBtn;

    #region Set frames pos
    public void SetFramesPos()
    {
        if (isMobile == true)
        {
            chestArros.transform.localPosition = new Vector2(0,0);
            chestArros.transform.localScale = new Vector2(1.04f, 1.04f);

            purchasingMaxText.SetActive(true);
            purchasingMaxText.gameObject.transform.localPosition = new Vector2(91f, -460);
            max1xArrow.SetActive(false);
            max1XframeImage.SetActive(false);
            maxOr1XFrame.GetComponent<RectTransform>().sizeDelta = new Vector2(506, 151);
            maxOr1XFrame.transform.SetParent(selectScrenBtns);
            maxOr1XFrame.gameObject.transform.localScale = new Vector2(1.07f, 1.07f);
            maxOr1XFrame.gameObject.transform.localPosition = new Vector2(0, 141.7f);
            x1Button.gameObject.transform.localPosition = new Vector2(-200f, -35f);
            x1Button.gameObject.transform.localScale = new Vector2(0.75f, 0.75f);
            maxButton.gameObject.transform.localPosition = new Vector2(-113f, -35f);
            maxButton.gameObject.transform.localScale = new Vector2(0.75f, 0.75f);

            prestigeBarRight.SetActive(false);
            sellTreasureCloseTopRight.SetActive(false);
            shopInfo.SetActive(false);
            cursorInfo.SetActive(false);

            statsAchFrame.transform.localPosition = new Vector2(0, 38);
            statsAchFrame.transform.localScale = new Vector2(1.31f, 1.31f);
            statsAchBox.GetComponent<RectTransform>().sizeDelta = new Vector2(573, 851);
            achStatsExtiTopRight.SetActive(false);
            statsText.transform.localPosition = new Vector2(0, 287);
            achText.transform.localPosition = new Vector2(0, 287);
            achivementsSCroll.transform.localPosition = new Vector2(0, -23);
            statsScroll.transform.localPosition = new Vector2(0, -23);
            achivementsSCroll.transform.localScale = new Vector2(1.75f, 1.75f);
            statsScroll.transform.localScale = new Vector2(1.75f, 1.75f);

            devInfoText.transform.SetParent(infoFrame.GetComponent<Transform>());
            reinforcedText.transform.SetParent(infoFrame.GetComponent<Transform>());
            enchantedText.transform.SetParent(infoFrame.GetComponent<Transform>());
            bossChestText.transform.SetParent(infoFrame.GetComponent<Transform>());

            devInfoText.transform.localPosition = new Vector2(-4, 90);
            devInfoText.transform.localScale = new Vector2(0.92f, 0.92f);

            reinforcedText.transform.localPosition = new Vector2(-4, 213);
            reinforcedText.transform.localScale = new Vector2(0.9f, 0.9f);

            enchantedText.transform.localPosition = new Vector2(-4, -7);
            enchantedText.transform.localScale = new Vector2(0.87f, 0.87f);

            bossChestText.transform.localPosition = new Vector2(-4, -300);
            bossChestText.transform.localScale = new Vector2(0.87f, 0.87f);

            pcSettingFrame.SetActive(false);
            mobileSettingFrame.transform.localPosition = new Vector2(1.19f, 53f);
            mobileSettingFrame.transform.localScale = new Vector2(1.1f, 1.1f);
            musicAndSound.transform.SetParent(mobileSettingFrame.GetComponent<Transform>());
            collectableTreasure.transform.SetParent(mobileSettingFrame.GetComponent<Transform>());
            languages.transform.SetParent(mobileSettingFrame.GetComponent<Transform>());
            languages.transform.localPosition = new Vector2(0, -338);
            languages.transform.localScale = new Vector2(3.5f, 3.5f);

            englishBtn.transform.localPosition = new Vector2(-14.4f, 21);
            japaneseBtn.transform.localPosition = new Vector2(7.6f, 21);

            saveBtn.transform.SetParent(miscScreen.GetComponent<Transform>());
            saveBtn.transform.localPosition = new Vector2(0, -350);
            saveBtn.transform.localScale = new Vector2(2.08f, 2.08f);

            cantSaveBlock.transform.SetParent(mobileSettingFrame.GetComponent<Transform>());
            resetBtn.transform.SetParent(mobileSettingFrame.GetComponent<Transform>());
            discrodBtn.transform.SetParent(mobileSettingFrame.GetComponent<Transform>());
            xTwitterBtn.transform.SetParent(mobileSettingFrame.GetComponent<Transform>());

            musicAndSound.transform.localPosition = new Vector2(177, 34);
            musicAndSound.transform.localScale = new Vector2(0.62f, 0.62f);

            collectableTreasure.transform.localPosition = new Vector2(0, 140);
            collectableTreasure.transform.localScale = new Vector2(0.92f, 0.92f);

            gameSave15Text.SetActive(false);

            cantSaveBlock.transform.localPosition = new Vector2(0, -289);
            cantSaveBlock.transform.localScale = new Vector2(1.85f, 1.85f);

            resetBtn.transform.localPosition = new Vector2(175, -159);
            resetBtn.transform.localScale = new Vector2(0.76f, 0.76f);

            discrodBtn.transform.localPosition = new Vector2(0, -159);
            discrodBtn.transform.localScale = new Vector2(0.74f, 0.74f);

            xTwitterBtn.transform.localPosition = new Vector2(-182, -157);
            xTwitterBtn.transform.localScale = new Vector2(1f, 1f);

            steamBTN.SetActive(false);
            generalTab.SetActive(false);
            infoTab.SetActive(false);
            resolution.SetActive(false);
            fullScreen.SetActive(false);
           
            mimicSound.SetActive(false);
            miniSound.SetActive(false);
            settingsCloseTopTight.SetActive(false);

            itemsTopBTN.SetActive(false);
            treasureTopBTN.SetActive(false);
            prestigeTopBTN.SetActive(false);
            cursorTopBTN.SetActive(false);
            shopTopBTN.SetActive(false);

            levelBar.transform.localScale = new Vector2(0.71f, 0.71f);
            if(isFoldPhone == true) 
            {
                levelBar.transform.localScale = new Vector2(0.628f, 0.628f);
                allBottomsBtns.transform.localScale = new Vector2(0.87f, 0.87f);
                chestArros.transform.localScale = new Vector2(0.862f, 0.862f);
            }

            passiveFrameExit.SetActive(false); activeFrameExit.SetActive(false);

            chestBackground.transform.localScale = new Vector2(5.9f, 5.9f);
            chestBackground.transform.localPosition = new Vector2(0, -60f);
            if (isFoldPhone == true)
            {
                chestBackground.transform.localScale = new Vector2(5f, 5f);
                chestBackground.transform.localPosition = new Vector2(0, -60f);
            }

            goldBar.gameObject.transform.SetParent(chestBackgroundParent);
            goldBar.gameObject.transform.localPosition = new Vector2(0, 58f);
            goldBar.gameObject.transform.localScale = new Vector2(0.11f, 0.11f);

            treasuresParent.transform.SetParent(chestBackgroundParent);
            goldParent.transform.SetParent(chestBackgroundParent);
            dropsParent.transform.SetParent(chestBackgroundParent);

            activeBTN.gameObject.transform.SetParent(chestBackgroundParent);
            activeBTN.gameObject.transform.localPosition = new Vector2(-39f, -39f);
            activeBTN.gameObject.transform.localScale = new Vector2(0.15f, 0.15f);

            passiveBTN.gameObject.transform.SetParent(chestBackgroundParent);
            passiveBTN.gameObject.transform.localPosition = new Vector2(39f, -39f);
            passiveBTN.gameObject.transform.localScale = new Vector2(0.15f, 0.15f);

            infoTooltip.gameObject.transform.SetParent(chestBackgroundParent);
            infoTooltip.gameObject.transform.localPosition = new Vector2(-40f, 38.7f);
            infoTooltip.gameObject.transform.localScale = new Vector2(0.13f, 0.13f);

            autoPurchaseBTN.gameObject.transform.SetParent(chestBackgroundParent);
            autoPurchaseBTN.gameObject.transform.localPosition = new Vector2(39, 39);
            autoPurchaseBTN.gameObject.transform.localScale = new Vector2(0.16f, 0.16f);
            
            coolStuffBtn.SetActive(false);

            rightBar.transform.SetParent(selectScrenBtns);
            leftBar.transform.SetParent(selectScrenBtns);

            rightBar.SetActive(false);
            rightBar.transform.localPosition = new Vector2(-4.2f, 602);
            rightBar.transform.localScale = new Vector2(1.085f, 1.085f);
            leftBar.SetActive(false);
            leftBar.transform.localPosition = new Vector2(-15, 613);
            leftBar.transform.localScale = new Vector2(1.29f, 1.29f);
            skillPoint.transform.localPosition = new Vector2(0, 0);
        }
    }
    #endregion

    #region Set rare treasure frame
    public GameObject page1Text, rareTreasureText, exitRareTbtn, nextPageBtn, rareTreasureBottomEXITBtn;
    public GameObject rareTreasureFrame, rareTreasureActive, rareTreasureUnder, rareTreasurePaper, rareTreasureDropsFrame, lockedTreasureBtn;
    public Transform rareTreasureParent, rareTreasureTextParent;

    public GameObject present, axe, coin100X, envelope, potion, heart, scroll, brick, chicken;
    public GameObject presentTextBar, axeTextBar, coin100XTextBar, envelopeTextBar, potionTextBar, heartTextBar, scrollTextBar, brickTextBar, chickenTextBar;

    public void SetRareTreasureFrame()
    {
        lockedTreasureBtn.SetActive(false);
        lockedTreasureBtn.transform.localPosition = new Vector2(-271, -642);
        lockedTreasureBtn.transform.localScale = new Vector2(1.17f, 1.17f);

        present.transform.localScale = new Vector2(0.15f, 0.15f);
        axe.transform.localScale = new Vector2(0.12f, 0.12f);
        coin100X.transform.localScale = new Vector2(0.10f, 0.10f);
        envelope.transform.localScale = new Vector2(0.15f, 0.15f);
        potion.transform.localScale = new Vector2(0.11f, 0.11f);
        heart.transform.localScale = new Vector2(0.12f, 0.12f);
        scroll.transform.localScale = new Vector2(0.15f, 0.15f);
        brick.transform.localScale = new Vector2(0.15f, 0.15f);
        chicken.transform.localScale = new Vector2(0.12f, 0.12f);

        rareTreasureDropsFrame.transform.localPosition = new Vector2(0, 33);

        present.transform.SetParent(rareTreasureParent);
        presentTextBar.transform.SetParent(rareTreasureParent);
        present.transform.localPosition = new Vector2(-34.1f, -51.5f);
        presentTextBar.transform.localPosition = new Vector2(-33.91f, -60.8f);

        axe.transform.SetParent(rareTreasureParent);
        axeTextBar.transform.SetParent(rareTreasureParent);
        axe.transform.localPosition = new Vector2(-11.1f, -51.5f);
        axeTextBar.transform.localPosition = new Vector2(-10.91f, - 60.8f);

        coin100X.transform.SetParent(rareTreasureParent);
        coin100XTextBar.transform.SetParent(rareTreasureParent);
        coin100X.transform.localPosition = new Vector2(10.9f, -51.5f);
        coin100XTextBar.transform.localPosition = new Vector2(11.09f, - 60.8f);

        envelope.transform.SetParent(rareTreasureParent);
        envelopeTextBar.transform.SetParent(rareTreasureParent);
        envelope.transform.localPosition = new Vector2(32.9f, -51.5f);
        envelopeTextBar.transform.localPosition = new Vector2(33f, - 60.8f);

        potion.transform.SetParent(rareTreasureParent);
        potionTextBar.transform.SetParent(rareTreasureParent);
        potion.transform.localPosition = new Vector2(-34.1f, -73.4f);
        potionTextBar.transform.localPosition = new Vector2(-33.9f, -82.7f);

        heart.transform.SetParent(rareTreasureParent);
        heartTextBar.transform.SetParent(rareTreasureParent);
        heart.transform.localPosition = new Vector2(-11.1f, -73.4f);
        heartTextBar.transform.localPosition = new Vector2(-10.91f, -82.7f);

        scroll.transform.SetParent(rareTreasureParent);
        scrollTextBar.transform.SetParent(rareTreasureParent);
        scroll.transform.localPosition = new Vector2(32.9f, -73.4f);
        scrollTextBar.transform.localPosition = new Vector2(33f, -82.7f);

        brick.transform.SetParent(rareTreasureParent);
        brickTextBar.transform.SetParent(rareTreasureParent);
        brick.transform.localPosition = new Vector2(10.9f, -73.4f);
        brickTextBar.transform.localPosition = new Vector2(11.09f, -82.7f);

        chicken.transform.SetParent(rareTreasureParent);
        chickenTextBar.transform.SetParent(rareTreasureParent);
        chicken.transform.localPosition = new Vector2(32.9f, -73.4f);
        chickenTextBar.transform.localPosition = new Vector2(33f, -82.7f);

        rareTreasureText.transform.SetParent(rareTreasureTextParent);
        rareTreasureText.transform.localPosition = new Vector2(0, 0);
        chicken.transform.localPosition = new Vector2(0f, -96f);
        chickenTextBar.transform.localPosition = new Vector2(0f, -105f);

        rareTreasureUnder.GetComponent<RectTransform>().sizeDelta = new Vector2(100, 167);
        rareTreasurePaper.GetComponent<RectTransform>().sizeDelta = new Vector2(100, 169);

        rareTreasureFrame.transform.localPosition = new Vector2(0,21);
        rareTreasureFrame.transform.localScale = new Vector2(0.7f, 0.7f);

        rareTreasureUnder.transform.localPosition = new Vector2(0, -36);
        rareTreasureUnder.transform.localScale = new Vector2(8.5f, 8.5f);

        rareTreasurePaper.transform.localPosition = new Vector2(0, 0);
        rareTreasurePaper.transform.localScale = new Vector2(0.98f, 0.98f);

        //rareTreasureBottomEXITBtn.transform.localPosition = new Vector2(0, -646);

        page1Text.SetActive(false);
        exitRareTbtn.SetActive(false);
        nextPageBtn.SetActive(false);
    }
    //16
    //17
    //24
    //16
    //16

    public GameObject purchaseTreasureBTN;

    public void OpenRareTreasureFrame()
    {
        if(isMobile == true)
        {
            if (Stats.prestigeUpgradesPurchased >= 89)
            {
                purchaseTreasureBTN.SetActive(true);
            }
            else
            {
                purchaseTreasureBTN.SetActive(false);
            }
            if (Stats.rareTreasuresFound == 25) { lockedTreasureBtn.SetActive(false); }
            rareTreasureActive.SetActive(true);
            rareTreasureActive.GetComponent<Image>().raycastTarget = false;

            Color color = rareTreasureActive.GetComponent<Image>().color;
            color.a = 0f;
            rareTreasureActive.GetComponent<Image>().color = color;
            //rareTreasureBottomEXITBtn.SetActive(true);
        }
    }

    public void CloseRareTreasureFrame()
    {
        blackFrame.SetActive(false);
        rareTreasureActive.SetActive(false);
        //rareTreasureBottomEXITBtn.SetActive(false);
    }
    #endregion

    #region Open rare treasure tooltip
    public GameObject[] rareTreasureTooltip;
    public GameObject rareTreasureClose, rareTreasureToolTipBlackBlock;
    public AudioManager audioManager;

    public void OpenRareTreasureTooltip(int tooltip)
    {
        if(isMobile == false) { return; }
        if (AudioManager.audioMuted == 1) { audioManager.Play("UIClick1"); }
        rareTreasureToolTipBlackBlock.SetActive(true);
        rareTreasureClose.SetActive(true);
        rareTreasureTooltipNumber = tooltip;
        rareTreasureTooltip[tooltip].SetActive(true);
        rareTreasureTooltip[tooltip].transform.localScale = new Vector2(1.69f, 1.69f);
        rareTreasureTooltip[tooltip].transform.localPosition = new Vector2(0, 10.5f);

        if (isFoldPhone == true)
        {
            rareTreasureTooltip[tooltip].transform.localScale = new Vector2(1.52f, 1.52f);
            rareTreasureTooltip[tooltip].transform.localPosition = new Vector2(0, 10.5f);
        }

        Transform popUpTransform = transform.Find("PopUp");

        if (popUpTransform != null)
        {
            GameObject popUp = popUpTransform.gameObject;
            if (popUp.activeSelf)
            {
                // Set the GameObject to inactive
                popUp.SetActive(false);
            }
        }
       
    }

    public int rareTreasureTooltipNumber;
    public void CloseRareTreasureTooltip()
    {
        if (AudioManager.audioMuted == 1) { audioManager.Play("UIClick1"); }
        rareTreasureToolTipBlackBlock.SetActive(false);
        rareTreasureClose.SetActive(false);
        rareTreasureTooltip[rareTreasureTooltipNumber].SetActive(false);
    }
    #endregion

    #region Set Shop and Cursor btns and positions
    public GridLayoutGroup gridShop, gridCursor;
    public GameObject[] unlockedShop, unlockedCursor;

    public GameObject[] shopInfoBoxes, cursorInfoBoxes;
    public TextMeshProUGUI[] shopInfoText, cursorInfoText;

    public Button cursor1, cursor2, cursor3, lockpick;

    public void ResetShopInfoBtn()
    {
        for (int i = 0; i < shopInfoBoxes.Length; i++)
        {
            shopInfoBoxes[i].GetComponent<Button>().interactable = false;
            
        }

        for (int i = 0; i < shopInfoText.Length; i++)
        {
            shopInfoText[i].text = "????";
        }

        shopInfoBoxes[0].GetComponent<Button>().interactable = true;
    }

    public void SetShopAndCursors()
    {
        if(isMobile == true)
        {
            if (AudioManager.audioMuted == 1) { audioManager.Play("UIClick1"); }
            //Shop
            gridShop.gameObject.transform.localPosition = new Vector2(-47.4f, -493f);
            gridShop.cellSize = new Vector2(417.6f, 115);

            for (int i = 0; i < unlockedShop.Length; i++)
            {
                unlockedShop[i].GetComponent<RectTransform>().transform.localPosition = new Vector2(208, -57.5f);
                unlockedShop[i].GetComponent<RectTransform>().sizeDelta = new Vector2(417.6f, 115);

                ColorBlock cb = unlockedShop[i].GetComponent<Button>().colors;

                cb.highlightedColor = Color.white;

                unlockedShop[i].GetComponent<Button>().colors = cb;
                lockpick.colors = cb;
            }

            for (int i = 0; i < shopInfoBoxes.Length; i++)
            {
                shopInfoBoxes[i].SetActive(true);
            }

            //cursor
            gridCursor.gameObject.transform.localPosition = new Vector2(-47.7f, -719f);
            gridCursor.cellSize = new Vector2(418.6f, 115);

            for (int i = 0; i < unlockedCursor.Length; i++)
            {
                unlockedCursor[i].GetComponent<RectTransform>().transform.localPosition = new Vector2(209.3f, -57.5f); //18
                unlockedCursor[i].GetComponent<RectTransform>().sizeDelta = new Vector2(418.6f, 115);

                ColorBlock cb = unlockedCursor[i].GetComponent<Button>().colors;

                cb.highlightedColor = Color.white;

                unlockedCursor[i].GetComponent<Button>().colors = cb;
                cursor1.colors = cb;
                cursor2.colors = cb;
                cursor3.colors = cb;
            }

            for (int i = 0; i < cursorInfoBoxes.Length; i++)
            {
                cursorInfoBoxes[i].SetActive(true);
            }
        }
        else
        {
            for (int i = 0; i < shopInfoBoxes.Length; i++)
            {
                shopInfoBoxes[i].SetActive(false);
            }

            for (int i = 0; i < cursorInfoBoxes.Length; i++)
            {
                cursorInfoBoxes[i].SetActive(false);
            }
        }
       
    }
    #endregion

    #region Open shop tooltips
    public GameObject[] shopTooltips;
    public GameObject tooltipBlackFrame, shopCloseBtn;
    public int shopTooltipNumber;

    public void OpenShopTooltips(int shopItem)
    {
        if(isMobile == true)
        {
            if (AudioManager.audioMuted == 1) { audioManager.Play("UIClick1"); }
            HoverSpecialString.hoverSpecialChance = true;
            shopCloseBtn.SetActive(true);
            shopTooltipNumber = shopItem;
            tooltipBlackFrame.SetActive(true);
            shopTooltips[shopItem].SetActive(true);
            shopTooltips[shopItem].transform.localPosition = new Vector2(0f, -366);
            shopCloseBtn.transform.localPosition = new Vector2(0, -472);

            shopTooltips[shopItem].transform.localScale = new Vector2(6f, 6f);
            shopCloseBtn.transform.localScale = new Vector2(5.2f, 5.2f);

            if (isFoldPhone == true)
            {
                shopTooltips[shopItem].transform.localPosition = new Vector2(0f, -295);
                shopCloseBtn.transform.localPosition = new Vector2(0, -384);

                shopTooltips[shopItem].transform.localScale = new Vector2(5f, 5f);
                shopCloseBtn.transform.localScale = new Vector2(4.3f, 4.3f);
            }
        }
    }


    public void CloseShopToolTip()
    {
        if (AudioManager.audioMuted == 1) { audioManager.Play("UIClick1"); }
        shopCloseBtn.SetActive(false);
        tooltipBlackFrame.SetActive(false);
        shopTooltips[shopTooltipNumber].SetActive(false);
    }
    #endregion

    #region Open cursor tooltips
    public GameObject[] cursorTooltips;
    public GameObject cursorCloseBtn;
    public int cursorTooltipNumber;

    public void OpenCursorTooltips(int cursorItem)
    {
        if (isMobile == true)
        {
            if (AudioManager.audioMuted == 1) { audioManager.Play("UIClick1"); }
            ClickPower.cursorHoverChange[cursorItem] = true;
            HoverSetStrings.boughtUpgrade = true;
            ClickPower.cursorsPriceChanged = true;

            if(cursorItem == 0) { ClickPower.cursor1Change = true; }
            if (cursorItem == 1) { ClickPower.cursor2Change = true; }
            if (cursorItem == 2) { ClickPower.cursor3Change = true; }
            if (cursorItem == 3) { ClickPower.cursor4Change = true; }
            if (cursorItem == 4) { ClickPower.cursor5Change = true; }
            if (cursorItem == 5) { ClickPower.cursor6Change = true; }
            if (cursorItem == 6) { ClickPower.cursor7Change = true; }
            if (cursorItem == 7) { ClickPower.cursor8Change = true; }
            if (cursorItem == 8) { ClickPower.cursor9Change = true; }
            if (cursorItem == 9) { ClickPower.cursor10Change = true; }
            if (cursorItem == 10) { ClickPower.cursor11Change = true; }
            if (cursorItem == 11) { ClickPower.cursor12Change = true; }
            if (cursorItem == 12) { ClickPower.cursor13Change = true; }
            if (cursorItem == 13) { ClickPower.cursor14Change = true; }
            if (cursorItem == 14) { ClickPower.cursor15Change = true; }
            if (cursorItem == 15) { ClickPower.cursor16Change = true; }
            if (cursorItem == 16) { ClickPower.cursor17Change = true; }
            if (cursorItem == 17) { ClickPower.cursor18Change = true; }
            if (cursorItem == 18) { ClickPower.cursor19Change = true; }
            if (cursorItem == 19) { ClickPower.cursor20Change = true; }
            if (cursorItem == 20) { ClickPower.cursor21Change = true; }

            cursorCloseBtn.SetActive(true);
            cursorTooltipNumber = cursorItem;
            tooltipBlackFrame.SetActive(true);
            cursorTooltips[cursorItem].SetActive(true);
            cursorTooltips[cursorItem].transform.localPosition = new Vector2(0f, -366);
            cursorCloseBtn.transform.localPosition = new Vector2(0, -472);

            cursorTooltips[cursorItem].transform.localScale = new Vector2(6f, 6f);
            cursorCloseBtn.transform.localScale = new Vector2(5.2f, 5.2f);

            if(isFoldPhone == true)
            {
                cursorTooltips[cursorItem].transform.localPosition = new Vector2(0f, -300);
                cursorCloseBtn.transform.localPosition = new Vector2(0, -388);

                cursorTooltips[cursorItem].transform.localScale = new Vector2(5f, 5f);
                cursorCloseBtn.transform.localScale = new Vector2(4.37f, 4.37f);
            }
        }
    }

    public void CloseCursorToolTip()
    {
        if (AudioManager.audioMuted == 1) { audioManager.Play("UIClick1"); }
        cursorCloseBtn.SetActive(false);
        tooltipBlackFrame.SetActive(false);
        cursorTooltips[cursorTooltipNumber].SetActive(false);
    }
    #endregion

    #region Set anchor
    public void SetAnchor(RectTransform rectTransform, Vector2 anchorMin, Vector2 anchorMax, Vector2 pivot)
    {
        rectTransform.anchorMin = anchorMin;
        rectTransform.anchorMax = anchorMax;
        rectTransform.pivot = pivot;

        // Adjust the anchored position as needed (optional)
        rectTransform.anchoredPosition = Vector2.zero;
    }
    #endregion

    #region OpenDifferentTabs
    public GameObject cursorsFrame, shopFrame, itemsFrame, treasuresFrame, prestigeFrame, blackFrame, miscFrame;
    public GameObject chestTransform, cursorTransform, shopTransform, treasureTransform, itemsTransform, prestigeTransform, miscTransform, rareTreasureTransform, steamBTN;

    public static bool isInItemsTab;

    public void SetAllTransformBack()
    {
        float yPos = -40.5f;
        chestTransform.transform.localPosition = new Vector2(0, yPos);
        cursorTransform.transform.localPosition = new Vector2(0, yPos);
        shopTransform.transform.localPosition = new Vector2(0, yPos);
        treasureTransform.transform.localPosition = new Vector2(0, yPos);
        rareTreasureTransform.transform.localPosition = new Vector2(0, yPos);
        itemsTransform.transform.localPosition = new Vector2(0, yPos);
        prestigeTransform.transform.localPosition = new Vector2(0, yPos);
        miscTransform.transform.localPosition = new Vector2(0, yPos);
    }

    public void OpenJustChests()
    {
        SetAllTransformBack();
        if (AudioManager.audioMuted == 1) { audioManager.Play("UIClick1"); }
        passiveBar.SetActive(false); passiveClose.SetActive(false);
        activeBar.SetActive(false); activeClose.SetActive(false);

        chestTransform.transform.localPosition = new Vector2(0, setTransformPos);
        isInItemsTab = false;
        blackFrame.SetActive(false);
        cursorsFrame.SetActive(false);
        shopFrame.SetActive(false);
        itemsFrame.SetActive(false);
        treasuresFrame.SetActive(false);
        prestigeFrame.SetActive(false);
        rightBar.SetActive(false);
        leftBar.SetActive(false);
        maxOr1XFrame.SetActive(false);
        rareTreasureActive.SetActive(false);
        miscFrame.SetActive(false);
    }

    public void OpenCursors()
    {
        OpenJustChests();
        SetAllTransformBack();

        maxOr1XFrame.SetActive(true);
        cursorTransform.transform.localPosition = new Vector2(0, setTransformPos);

        blackFrame.SetActive(true);
        cursorsFrame.SetActive(true);
        rightBar.SetActive(true);
    }

    public void OpenShop()
    {
        OpenJustChests();
        SetAllTransformBack();

        maxOr1XFrame.SetActive(true);
        shopTransform.transform.localPosition = new Vector2(0, setTransformPos);

        blackFrame.SetActive(true);
        rightBar.SetActive(true);
        shopFrame.SetActive(true);
    }

    public void OpenItems()
    {
        OpenJustChests();
        SetAllTransformBack();

        isInItemsTab = true;

        ReturnRedGem.setLockPick = false; ReturnRedGem.setHammer = false; ReturnRedGem.setLootPotion = false; ReturnRedGem.setDamagePotion = false; ReturnRedGem.setXPPotion = false; ReturnRedGem.setGoldenTouch = false; ReturnRedGem.setKey = false; ReturnRedGem.setScroll = false; ReturnRedGem.setGauntlet = false; ReturnRedGem.setElixir = false; ReturnRedGem.setRelic = false; ReturnRedGem.setTreasurePotion = false; ReturnRedGem.setKnife = false;

        itemsTransform.transform.localPosition = new Vector2(0, setTransformPos);

        blackFrame.SetActive(true);
        leftBar.SetActive(true);
        itemsFrame.SetActive(true);
    }

    public void OpenTreasures()
    {
        OpenJustChests();
        SetAllTransformBack();

        ReturnRedGem.setQuartz = false; ReturnRedGem.setAmethyst = false; ReturnRedGem.setYellowTopaz = false; ReturnRedGem.setAlbite = false; ReturnRedGem.setRedGarnet = false; ReturnRedGem.setAquamarine = false; ReturnRedGem.setYellowSapphire = false; ReturnRedGem.setPinkTourmaline = false; ReturnRedGem.setAdventurine = false; ReturnRedGem.setRedRuby = false; ReturnRedGem.setDiamond = false; ReturnRedGem.SetGrandiderite = false; ReturnRedGem.setVioletCrystal = false; ReturnRedGem.setAkoyaPearl = false; ReturnRedGem.setPurpleRupee = false; ReturnRedGem.setEmerald = false; ReturnRedGem.setGreenDiamond = false; ReturnRedGem.setFireOpal = false; ReturnRedGem.setGemSilica = false; ReturnRedGem.setPinkPlort = false; ReturnRedGem.setGoldejSeaPearl = false; ReturnRedGem.setKyanite = false; ReturnRedGem.setBlackOpal = false; ReturnRedGem.setPainite = false;
        ReturnRedGem.setTanzanite = false; ReturnRedGem.setAstralium = false; ReturnRedGem.setElysiumPrism = false; ReturnRedGem.setAetherfireOpal = false; ReturnRedGem.setEldritchStarstone = false; ReturnRedGem.setChronolithShard = false; ReturnRedGem.setSideriumEssence = false; ReturnRedGem.setQuasarite = false; ReturnRedGem.setRadiantNovaStone = false; ReturnRedGem.setSoluniumShard = false;

        treasureTransform.transform.localPosition = new Vector2(0, setTransformPos);

        blackFrame.SetActive(true);
        leftBar.SetActive(true);
        treasuresFrame.SetActive(true);
    }

    public GameObject mobileEXLicon;

    public void OpenRareTreasure()
    {
        OpenJustChests();
        SetAllTransformBack();

        mobileEXLicon.SetActive(false);

        rareTreasureTransform.transform.localPosition = new Vector2(0, setTransformPos);

        blackFrame.SetActive(true);
        leftBar.SetActive(true);
    }

    public void OpenPrestige()
    {
        OpenJustChests();
        SetAllTransformBack();

        prestigeTransform.transform.localPosition = new Vector2(0, setTransformPos);

        blackFrame.SetActive(true);
        leftBar.SetActive(true);
        prestigeFrame.SetActive(true);
    }

    public void OpenMisc()
    {
        OpenJustChests();
        SetAllTransformBack();

        miscTransform.transform.localPosition = new Vector2(0, setTransformPos);

        blackFrame.SetActive(true);
        miscFrame.SetActive(true);
    }
    #endregion

    #region Misc buttons
    public int miscButton;
    public GameObject settingsScreen, closeSettings;
    public GameObject generalTab, infoTab, resolution, fullScreen, languages, mimicSound, miniSound, settingsCloseTopTight;

    public GameObject mobileSettingFrame, pcSettingFrame;
    public GameObject musicAndSound, collectableTreasure, saveBtn, cantSaveBlock, gameSave15Text, resetBtn, discrodBtn, xTwitterBtn;
    public void OpenSettings()
    {
        if (AudioManager.audioMuted == 1) { audioManager.Play("UIClick1"); }
        miscButton = 1;

        infoFrame.SetActive(false);
        InfoClose.SetActive(false);

        settingsScreen.SetActive(true);
        mobileSettingFrame.SetActive(true);
        closeSettings.SetActive(true);
    }

    public GameObject infoFrame, InfoClose, devInfoText, reinforcedText, enchantedText, bossChestText;

    public void OpenInformation()
    {
        if (AudioManager.audioMuted == 1) { audioManager.Play("UIClick1"); }
        mobileSettingFrame.SetActive(false);
        closeSettings.SetActive(false);

        miscButton = 2;

        infoFrame.SetActive(true);
        InfoClose.SetActive(true);
        settingsScreen.SetActive(true);
    }

    public GameObject statsAchFrame, statsAchBox, achStatsExtiTopRight, achText, statsText, achivementsSCroll, statsScroll, achStatsExitBtn;
    public void OpenAchivements()
    {
        if (AudioManager.audioMuted == 1) { audioManager.Play("UIClick1"); }
        miscButton = 3;
        statsText.SetActive(false);
        achText.SetActive(true);
        statsScroll.SetActive(false);
        achivementsSCroll.SetActive(true);
        statsAchFrame.SetActive(true);
        achStatsExitBtn.SetActive(true);
     
    }

    public void OpenStats()
    {
        if (AudioManager.audioMuted == 1) { audioManager.Play("UIClick1"); }
        Stats.statsScreenOpen = true;
        miscButton = 4;
        statsText.SetActive(true);
        achText.SetActive(false);
        statsScroll.SetActive(true);
        achivementsSCroll.SetActive(false);
        statsAchFrame.SetActive(true);
        achStatsExitBtn.SetActive(true);
    }

    public void CloseCurrentMisc()
    {
        if (AudioManager.audioMuted == 1) { audioManager.Play("UIClick1"); }
        if (miscButton == 1)
        {
            mobileSettingFrame.SetActive(false);
            closeSettings.SetActive(false);
            settingsScreen.SetActive(false);
        }
        if (miscButton == 2)
        {
            settingsScreen.SetActive(false);
            infoFrame.SetActive(false);
            InfoClose.SetActive(false);
        }
        if (miscButton == 3)
        {
            statsText.SetActive(false);
            achText.SetActive(false);
            statsScroll.SetActive(false);
            achivementsSCroll.SetActive(false);
            statsAchFrame.SetActive(false);
            achStatsExitBtn.SetActive(false);
        }
        if (miscButton == 4)
        {
            Stats.statsScreenOpen = false;
            statsText.SetActive(false);
            achText.SetActive(false);
            statsScroll.SetActive(false);
            achivementsSCroll.SetActive(false);
            statsAchFrame.SetActive(false);
            achStatsExitBtn.SetActive(false);
        }
    }

    #endregion

    #region check question marks
    public TextMeshProUGUI shopIem1Text;

    public void CheckShopQuestionMarks()
    {
        for (int i = 0; i < shopInfoText.Length; i++)
        {
            if (Localization.EnglishLanguageChosen != 1)
            {
                shopIem1Text.lineSpacing = -35f;
                shopInfoText[i].lineSpacing = -35f;
            }
            else
            {
                shopIem1Text.lineSpacing = -60f;
                shopInfoText[i].lineSpacing = -60f;
            }
        }


        for (int i = 0; i < shopInfoText.Length; i++)
        {
            if (Localization.JapaneseLanguageChosen == 1) { shopInfoText[i].font = japaneseFont; shopIem1Text.font = japaneseFont; }
            if (Localization.ChineseLanguageChosen == 1) { shopInfoText[i].font = chinseFont; shopIem1Text.font = chinseFont; }
            if (Localization.KoreanLanguageChosen == 1) { shopInfoText[i].font = koreanFont; shopIem1Text.font = koreanFont; }
            if (Localization.EnglishLanguageChosen == 1) { shopInfoText[i].font = englishFont; shopIem1Text.font = englishFont; }
            if (Localization.RussianLanguageChosen == 1) { shopInfoText[i].font = englishFont; shopIem1Text.font = englishFont; }
        }

        shopIem1Text.text = Localization.info;

        if (SpecialUpgradesButtons.lockPickBoughtFirstTime == 1) { shopInfoText[0].text = Localization.info; shopInfoBoxes[1].GetComponent<Button>().interactable = true; }
        else { shopInfoText[0].text = "????"; shopInfoBoxes[1].GetComponent<Button>().interactable = false; }

        if (SpecialUpgradesButtons.hammerBoughtFirstTime == 1) { shopInfoText[1].text = Localization.info; shopInfoBoxes[2].GetComponent<Button>().interactable = true; }
        else { shopInfoText[1].text = "????"; shopInfoBoxes[2].GetComponent<Button>().interactable = false; }

        if (SpecialUpgradesButtons.lootPotionBoughtFirstTime == 1) { shopInfoText[2].text = Localization.info; shopInfoBoxes[3].GetComponent<Button>().interactable = true; }
        else { shopInfoText[2].text = "????"; shopInfoBoxes[3].GetComponent<Button>().interactable = false; }

        if (SpecialUpgradesButtons.damagePotionBoughtFirstTime == 1) { shopInfoText[3].text = Localization.info; shopInfoBoxes[4].GetComponent<Button>().interactable = true; }
        else { shopInfoText[3].text = "????"; shopInfoBoxes[4].GetComponent<Button>().interactable = false; }

        if (SpecialUpgradesButtons.XPPotionBoughtFirstTime == 1) { shopInfoText[4].text = Localization.info; shopInfoBoxes[5].GetComponent<Button>().interactable = true; }
        else { shopInfoText[4].text = "????"; shopInfoBoxes[5].GetComponent<Button>().interactable = false; }

        if (SpecialUpgradesButtons.goldenTouchBoughtFirstTime == 1) { shopInfoText[5].text = Localization.info; shopInfoBoxes[6].GetComponent<Button>().interactable = true; }
        else { shopInfoText[5].text = "????"; shopInfoBoxes[6].GetComponent<Button>().interactable = false; }

        if (SpecialUpgradesButtons.miniChestBoughtFirstTime == 1) { shopInfoText[6].text = Localization.info; shopInfoBoxes[7].GetComponent<Button>().interactable = true; }
        else { shopInfoText[6].text = "????"; shopInfoBoxes[7].GetComponent<Button>().interactable = false; }

        if (SpecialUpgradesButtons.keyBoughtFirstTime == 1) { shopInfoText[7].text = Localization.info; shopInfoBoxes[8].GetComponent<Button>().interactable = true; }
        else { shopInfoText[7].text = "????"; shopInfoBoxes[8].GetComponent<Button>().interactable = false; }

        if (SpecialUpgradesButtons.treasureBagBoughtFirstTime == 1) { shopInfoText[8].text = Localization.info; shopInfoBoxes[9].GetComponent<Button>().interactable = true; }
        else { shopInfoText[8].text = "????"; shopInfoBoxes[9].GetComponent<Button>().interactable = false; }

        if (UpdateGame.barrelBoughtFirstTime== 1) { shopInfoText[9].text = Localization.info; shopInfoBoxes[10].GetComponent<Button>().interactable = true; }
        else { shopInfoText[9].text = "????"; shopInfoBoxes[10].GetComponent<Button>().interactable = false; }

        if (SpecialUpgradesButtons.scrollBoughtFirstTime == 1) { shopInfoText[10].text = Localization.info; shopInfoBoxes[11].GetComponent<Button>().interactable = true; }
        else { shopInfoText[10].text = "????"; shopInfoBoxes[11].GetComponent<Button>().interactable = false; }

        if (UpdateGame.mimicChestBoughtFirstTime == 1) { shopInfoText[11].text = Localization.info; shopInfoBoxes[12].GetComponent<Button>().interactable = true; }
        else { shopInfoText[11].text = "????"; shopInfoBoxes[12].GetComponent<Button>().interactable = false; }

        if (SpecialUpgradesButtons.gauntletBoughtFirstTime == 1) { shopInfoText[12].text = Localization.info; shopInfoBoxes[13].GetComponent<Button>().interactable = true; }
        else { shopInfoText[12].text = "????"; shopInfoBoxes[13].GetComponent<Button>().interactable = false; }

        if (SpecialUpgradesButtons.elixirBoughtFirstTime == 1) { shopInfoText[13].text = Localization.info; shopInfoBoxes[14].GetComponent<Button>().interactable = true; }
        else { shopInfoText[13].text = "????"; shopInfoBoxes[14].GetComponent<Button>().interactable = false; }

        if (SpecialUpgradesButtons.relicBoughtFirstTime == 1) { shopInfoText[14].text = Localization.info; shopInfoBoxes[15].GetComponent<Button>().interactable = true; }
        else { shopInfoText[14].text = "????"; shopInfoBoxes[15].GetComponent<Button>().interactable = false; }

        if (UpdateGame.treasurePotionBoughtFirstTime == 1) { shopInfoText[15].text = Localization.info; shopInfoBoxes[16].GetComponent<Button>().interactable = true; }
        else { shopInfoText[15].text = "????"; shopInfoBoxes[16].GetComponent<Button>().interactable = false; }


    }
    #endregion

    public TMP_FontAsset chinseFont, japaneseFont, koreanFont, englishFont, russianFont;
    public TextMeshProUGUI cursorInfo1, cursorInfo2, cursorInfo3;

    #region check cursor info
    public void CheckCursorInfo()
    {
        for (int i = 0; i < cursorInfoText.Length; i++)
        {
            if(Localization.JapaneseLanguageChosen == 1)
            { 
                cursorInfoText[i].font = japaneseFont;
                cursorInfo1.font = japaneseFont;
                cursorInfo2.font = japaneseFont;
                cursorInfo3.font = japaneseFont;
            }
            if (Localization.ChineseLanguageChosen == 1) 
            {
                cursorInfoText[i].font = chinseFont;
                cursorInfo1.font = chinseFont;
                cursorInfo2.font = chinseFont;
                cursorInfo3.font = chinseFont;
            }
            if (Localization.KoreanLanguageChosen == 1) 
            { 
                cursorInfoText[i].font = koreanFont;
                cursorInfo1.font = koreanFont;
                cursorInfo2.font = koreanFont;
                cursorInfo3.font = koreanFont;
            }
            if (Localization.EnglishLanguageChosen == 1)
            { 
                cursorInfoText[i].font = englishFont;
                cursorInfo1.font = englishFont;
                cursorInfo2.font = englishFont;
                cursorInfo3.font = englishFont;
            }
            if (Localization.RussianLanguageChosen == 1) 
            {
                cursorInfoText[i].font = englishFont;
                cursorInfo1.font = englishFont;
                cursorInfo2.font = englishFont;
                cursorInfo3.font = englishFont;
            }

            cursorInfo1.text = Localization.info;
            cursorInfo2.text = Localization.info;
            cursorInfo3.text = Localization.info;

            if (Localization.EnglishLanguageChosen != 1) 
            {
                cursorInfo1.lineSpacing = -35f;
                cursorInfo2.lineSpacing = -35f;
                cursorInfo3.lineSpacing = -35f;
                cursorInfoText[i].lineSpacing = -35f; 
            }
            else
            { 
                cursorInfoText[i].lineSpacing = -60f;
                cursorInfo1.lineSpacing = -60f;
                cursorInfo2.lineSpacing = -60f;
                cursorInfo3.lineSpacing = -60f;
            }
        }

        //Set text
        if(UnlockChests.boughtChest3 == 0) { cursorInfoText[0].text = Localization.chest + "\n3"; cursorInfoText[0].fontSize = 30;  }
        else { cursorInfoText[0].text = Localization.info; cursorInfoText[0].fontSize = 39;  }

        if (UnlockChests.boughtChest5 == 0) { cursorInfoText[1].text = Localization.chest + "\n5"; cursorInfoText[1].fontSize = 30;  }
        else { cursorInfoText[1].text = Localization.info; cursorInfoText[1].fontSize = 39;  }

        if (UnlockChests.boughtChest5 == 0) { cursorInfoText[2].text = Localization.chest + "\n5"; cursorInfoText[2].fontSize = 30; }
        else { cursorInfoText[2].text = Localization.info; cursorInfoText[2].fontSize = 39; }

        if (UnlockChests.boughtChest7 == 0) { cursorInfoText[3].text = Localization.chest + "\n7"; cursorInfoText[3].fontSize = 30; }
        else { cursorInfoText[3].text = Localization.info; cursorInfoText[3].fontSize = 39; }

        if (UnlockChests.boughtChest8 == 0) { cursorInfoText[4].text = Localization.chest + "\n8"; cursorInfoText[4].fontSize = 30; }
        else { cursorInfoText[4].text = Localization.info; cursorInfoText[4].fontSize = 39; }

        if (UnlockChests.boughtChest10 == 0) { cursorInfoText[5].text = Localization.chest + "\n10"; cursorInfoText[5].fontSize = 30; }
        else { cursorInfoText[5].text = Localization.info; cursorInfoText[5].fontSize = 39; }

        if (UnlockChests.boughtChest12 == 0) { cursorInfoText[6].text = Localization.chest + "\n12"; cursorInfoText[6].fontSize = 30; }
        else { cursorInfoText[6].text = Localization.info; cursorInfoText[6].fontSize = 39; }

        if (UnlockChests.boughtChest14 == 0) { cursorInfoText[7].text = Localization.chest + "\n14"; cursorInfoText[7].fontSize = 30; }
        else { cursorInfoText[7].text = Localization.info; cursorInfoText[7].fontSize = 39; }

        if (UnlockChests.boughtChest14 == 0) { cursorInfoText[8].text = Localization.chest + "\n14"; cursorInfoText[8].fontSize = 30; }
        else { cursorInfoText[8].text = Localization.info; cursorInfoText[8].fontSize = 39; }

        if (UnlockChests.boughtChest16 == 0) { cursorInfoText[9].text = Localization.chest + "\n16"; cursorInfoText[9].fontSize = 30; }
        else { cursorInfoText[9].text = Localization.info; cursorInfoText[9].fontSize = 39; }

        if (UnlockChests.boughtChest18 == 0) { cursorInfoText[10].text = Localization.chest + "\n18"; cursorInfoText[10].fontSize = 30; }
        else { cursorInfoText[10].text = Localization.info; cursorInfoText[10].fontSize = 39; }

        if (UnlockChests.boughtChest20 == 0) { cursorInfoText[11].text = Localization.chest + "\n20"; cursorInfoText[11].fontSize = 30; }
        else { cursorInfoText[11].text = Localization.info; cursorInfoText[11].fontSize = 39; }

        if (UnlockChests.boughtChest23 == 0) { cursorInfoText[12].text = Localization.chest + "\n23"; cursorInfoText[12].fontSize = 30; }
        else { cursorInfoText[12].text = Localization.info; cursorInfoText[12].fontSize = 39; }

        if (UnlockChests.boughtChest24 == 0) { cursorInfoText[13].text = Localization.chest + "\n24"; cursorInfoText[13].fontSize = 30; }
        else { cursorInfoText[13].text = Localization.info; cursorInfoText[13].fontSize = 39; }

        if (UnlockChests.boughtChest27 == 0) { cursorInfoText[14].text = Localization.chest + "\n27"; cursorInfoText[14].fontSize = 30; }
        else { cursorInfoText[14].text = Localization.info; cursorInfoText[14].fontSize = 39; }

        if (UnlockChests.timesPurchasedChests < 30) { cursorInfoText[15].text = Localization.chest + "\n31"; cursorInfoText[15].fontSize = 30; }
        else { cursorInfoText[15].text = Localization.info; cursorInfoText[15].fontSize = 39; }

        if (UnlockChests.timesPurchasedChests < 34) { cursorInfoText[16].text = Localization.chest + "\n35"; cursorInfoText[16].fontSize = 30; }
        else { cursorInfoText[16].text = Localization.info; cursorInfoText[16].fontSize = 39; }

        if (UnlockChests.timesPurchasedChests < 37) { cursorInfoText[17].text = Localization.chest + "\n38"; cursorInfoText[17].fontSize = 30; }
        else { cursorInfoText[17].text = Localization.info; cursorInfoText[17].fontSize = 39; }

        //Sets button active or inactive
        if (UnlockChests.boughtChest3 == 0) { cursorInfoBoxes[3].GetComponent<Button>().interactable = false; }
        else { cursorInfoBoxes[3].GetComponent<Button>().interactable = true; }

        if (UnlockChests.boughtChest5 == 0) 
        { 
            cursorInfoBoxes[4].GetComponent<Button>().interactable = false;
            cursorInfoBoxes[5].GetComponent<Button>().interactable = false;
        }
        else 
        { 
            cursorInfoBoxes[4].GetComponent<Button>().interactable = true;
            cursorInfoBoxes[5].GetComponent<Button>().interactable = true;
        }

        if (UnlockChests.boughtChest7 == 0) { cursorInfoBoxes[6].GetComponent<Button>().interactable = false; }
        else { cursorInfoBoxes[6].GetComponent<Button>().interactable = true; }

        if (UnlockChests.boughtChest8 == 0) { cursorInfoBoxes[7].GetComponent<Button>().interactable = false; }
        else { cursorInfoBoxes[7].GetComponent<Button>().interactable = true; }

        if (UnlockChests.boughtChest10 == 0) { cursorInfoBoxes[8].GetComponent<Button>().interactable = false; }
        else { cursorInfoBoxes[8].GetComponent<Button>().interactable = true; }

        if (UnlockChests.boughtChest12 == 0) { cursorInfoBoxes[9].GetComponent<Button>().interactable = false; }
        else { cursorInfoBoxes[9].GetComponent<Button>().interactable = true; }

        if (UnlockChests.boughtChest14 == 0) { cursorInfoBoxes[10].GetComponent<Button>().interactable = false; }
        else { cursorInfoBoxes[10].GetComponent<Button>().interactable = true; }

        if (UnlockChests.boughtChest14 == 0) { cursorInfoBoxes[11].GetComponent<Button>().interactable = false; }
        else { cursorInfoBoxes[11].GetComponent<Button>().interactable = true; }

        if (UnlockChests.boughtChest16 == 0) { cursorInfoBoxes[12].GetComponent<Button>().interactable = false; }
        else { cursorInfoBoxes[12].GetComponent<Button>().interactable = true; }

        if (UnlockChests.boughtChest18 == 0) { cursorInfoBoxes[13].GetComponent<Button>().interactable = false; }
        else { cursorInfoBoxes[13].GetComponent<Button>().interactable = true; }

        if (UnlockChests.boughtChest20 == 0) { cursorInfoBoxes[14].GetComponent<Button>().interactable = false; }
        else { cursorInfoBoxes[14].GetComponent<Button>().interactable = true; }

        if (UnlockChests.boughtChest23 == 0) { cursorInfoBoxes[15].GetComponent<Button>().interactable = false; }
        else { cursorInfoBoxes[15].GetComponent<Button>().interactable = true; }

        if (UnlockChests.boughtChest24 == 0) { cursorInfoBoxes[16].GetComponent<Button>().interactable = false; }
        else { cursorInfoBoxes[16].GetComponent<Button>().interactable = true; }

        if (UnlockChests.boughtChest27 == 0) { cursorInfoBoxes[17].GetComponent<Button>().interactable = false; }
        else { cursorInfoBoxes[17].GetComponent<Button>().interactable = true; }

        if (UnlockChests.timesPurchasedChests < 30) { cursorInfoBoxes[18].GetComponent<Button>().interactable = false; }
        else { cursorInfoBoxes[18].GetComponent<Button>().interactable = true; }

        if (UnlockChests.timesPurchasedChests < 34) { cursorInfoBoxes[19].GetComponent<Button>().interactable = false; }
        else { cursorInfoBoxes[19].GetComponent<Button>().interactable = true; }

        if (UnlockChests.timesPurchasedChests < 37) { cursorInfoBoxes[20].GetComponent<Button>().interactable = false; }
        else { cursorInfoBoxes[20].GetComponent<Button>().interactable = true; }
    }
    #endregion

    #region Ach button
    public GameObject closeACH, blackACHscreen;
    public Transform toolTipTransform;
    public TextMeshProUGUI cookieFoundTooltip, cookieClickerTooptip, usedChickenTooltip;

    public void SetAchFrame()
    {
        if(isMobile == false) { return; }
        if (AudioManager.audioMuted == 1) { audioManager.Play("UIClick1"); }
        closeACH.SetActive(true);
        blackACHscreen.SetActive(true);

        if(Achievements.achSaves[45] == 1)
        {
            cookieFoundTooltip.text = Localization.findTheCookie;
        }
        else { cookieFoundTooltip.text = "???????????"; }
        if(Achievements.achSaves[46] == 1)
        {
            cookieClickerTooptip.text = Localization.cookieCliker;
        }
        else { cookieClickerTooptip.text = "???????????"; }
        
        StartCoroutine(waitwait());
    }

    IEnumerator waitwait()
    {
        yield return new WaitForSeconds(0.05f);
        if (Achievements.newAchUseChicken == 1 && ToolTipUpgrades.hoveringChicken == true)
        {
            cookieFoundTooltip.text = Localization.useTheChicken;
        }
    }

    public GameObject currentAchTooltip;

    public void CloseAchFrame()
    {
        if (AudioManager.audioMuted == 1) { audioManager.Play("UIClick1"); }
        closeACH.SetActive(false);
        closeACH.transform.SetParent(toolTipTransform);
        blackACHscreen.SetActive(false);
        currentAchTooltip = GameObject.Find("CurrentAchOpen");
        currentAchTooltip.SetActive(false);
        currentAchTooltip.name = "LOL!";
    }
    #endregion

    #region Open treasure tooltip
    public GameObject[] treasureTooltips;

    public GameObject closeTreasureTooltip, darkTreasure, sellTreasureFrame;

    public void OpenTreasureTooltip(int treasureNumber)
    {
        if(isMobile == true)
        {
            treasureTooltips[treasureNumber].SetActive(true);

            closeTreasureTooltip.transform.SetParent(treasureTooltips[treasureNumber].GetComponent<Transform>());

            closeTreasureTooltip.SetActive(true);
            closeTreasureTooltip.transform.localPosition = new Vector2(50.33f, -10.25f);
            closeTreasureTooltip.transform.localScale = new Vector2(0.514f, 0.899f);

            darkTreasure.SetActive(true);
            sellTreasureFrame.SetActive(true);

            sellTreasureFrame.transform.localPosition = new Vector2(-211f, -431f);
            sellTreasureFrame.transform.localScale = new Vector2(1.133f, 1.133f);

            treasureTooltips[treasureNumber].transform.localPosition = new Vector2(0, -250);
            treasureTooltips[treasureNumber].transform.localScale = new Vector2(5.7f, 5.7f);

            if(isFoldPhone == true)
            {
                sellTreasureFrame.transform.localPosition = new Vector2(-189f, -380f);
                sellTreasureFrame.transform.localScale = new Vector2(1.015f, 1.015f);

                treasureTooltips[treasureNumber].transform.localPosition = new Vector2(0, -218);
                treasureTooltips[treasureNumber].transform.localScale = new Vector2(5f, 5f);
            }

            if (AudioManager.audioMuted == 1) { audioManager.Play("UIClick1"); }
        }
    }

    public void CloseTreasureTooltip()
    {
        if (AudioManager.audioMuted == 1) { audioManager.Play("UIClick1"); }
        treasureTooltips[RareDropsCollected.treasureNumber].SetActive(false);
        sellTreasureFrame.SetActive(false);
        darkTreasure.SetActive(false);
        closeTreasureTooltip.SetActive(false);
    } //34
    #endregion

    #region Set Prestige screen
    public GameObject prestigeScroll, scrollBar, prestigeSkillPointsText, extiPRestigeButton, extiPretigeBtn2, exitText;
    public Transform transformPrestige, scrollTransform;
    public GameObject prestigeObjects;
    public GameObject wouldLikeToPrestigeScreen, wouldExitTOpRight, backToOpeningChestScreen;

    public void SetPrestigeScreen()
    {
        backToOpeningChestScreen.transform.localScale = new Vector2(0.92f, 0.92f);
        wouldLikeToPrestigeScreen.transform.localScale = new Vector2(6,6);
        wouldExitTOpRight.SetActive(false);

        prestigeScroll.SetActive(true);
        scrollBar.SetActive(true);

        prestigeObjects.transform.SetParent(scrollTransform);

        prestigeSkillPointsText.transform.SetParent(transformPrestige);
        prestigeSkillPointsText.transform.localPosition = new Vector2(0,620);

        SetAnchor(prestigeSkillPointsText.GetComponent<RectTransform>(), new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(0.5f, 1f));
    }

    public GameObject[] toolTipFrames;
    public int prestigeFrameNumber;
    public GameObject closePrestigeFrameBtn;
    public GameObject purchasePrestigeUpgradeBtn, darkPrestigeUpgeade;
    public float xposClose, yposClose, xposBuy, yposBuy;

    public static bool isPrestigeTooltipOpen;

    public void OpenPrestigeFrame(int upgradeNumber)
    {
        if(isMobile == false) { return; }

        if (AudioManager.audioMuted == 1) { audioManager.Play("UIClick1"); }

        #region Check if unlocked
        if (upgradeNumber == 1 && SkillTree.crit1Bought == 0) { return; }
        else if (upgradeNumber == 2 && SkillTree.crit2Bought == 0) { return; }
        else if (upgradeNumber == 3 && SkillTree.crit3Bought == 0) { return; }
        else if (upgradeNumber == 4 && SkillTree.crit4Bought == 0) { return; }

        else if (upgradeNumber == 6 && SkillTree.active1Bought == 0) { return; }
        else if (upgradeNumber == 7 && SkillTree.active2Bought == 0) { return; }
        else if (upgradeNumber == 8 && SkillTree.active3Bought == 0) { return; }
        else if (upgradeNumber == 9 && SkillTree.active4Bought == 0) { return; }
        else if (upgradeNumber == 10 && SkillTree.active5Bought == 0) { return; }
        else if (upgradeNumber == 11 && SkillTree.active6Bought == 0) { return; }

        else if (upgradeNumber == 13 && SkillTree.activeCursor1Bought == 0) { return; }
        else if (upgradeNumber == 14 && SkillTree.activeCursor2Bought == 0) { return; }
        else if (upgradeNumber == 15 && SkillTree.activeCursor3Bought == 0) { return; }

        else if (upgradeNumber == 17 && SkillTree.autoClicker1Bought == 0) { return; }
        else if (upgradeNumber == 18 && SkillTree.autoClicker2Bought == 0) { return; }
        else if (upgradeNumber == 19 && SkillTree.autoClicker3Bought == 0) { return; }

        else if (upgradeNumber == 21 && SkillTree.autoDamage1Bought == 0) { return; }
        else if (upgradeNumber == 22 && SkillTree.autoDamage2Bought == 0) { return; }
        else if (upgradeNumber == 23 && SkillTree.autoDamage3Bought == 0) { return; }
        else if (upgradeNumber == 24 && SkillTree.autoDamage4Bought == 0) { return; }
        else if (upgradeNumber == 25 && SkillTree.autoDamage5Bought == 0) { return; }
        else if (upgradeNumber == 26 && SkillTree.autoDamage6Bought == 0) { return; }
        else if (upgradeNumber == 27 && SkillTree.autoDamage7Bought == 0) { return; }

        else if (upgradeNumber == 29 && SkillTree.autoCursor1Bought == 0) { return; }
        else if (upgradeNumber == 30 && SkillTree.autoCursor2Bought == 0) { return; }
        else if (upgradeNumber == 31 && SkillTree.autoCursor3Bought == 0) { return; }
        else if (upgradeNumber == 32 && SkillTree.autoCursor4Bought == 0) { return; }

        else if (upgradeNumber == 34 && SkillTree.gold1Bought == 0) { return; }
        else if (upgradeNumber == 35 && SkillTree.gold2Bought == 0) { return; }
        else if (upgradeNumber == 36 && SkillTree.gold3Bought == 0) { return; }
        else if (upgradeNumber == 37 && SkillTree.gold4Bought == 0) { return; }
        else if (upgradeNumber == 38 && SkillTree.gold5Bought == 0) { return; }
        else if (upgradeNumber == 39 && SkillTree.gold6Bought == 0) { return; }
        else if (upgradeNumber == 40 && SkillTree.gold7Bought == 0) { return; }
        else if (upgradeNumber == 41 && SkillTree.gold8Bought == 0) { return; }

        else if (upgradeNumber == 43 && SkillTree.drops1Bought == 0) { return; }
        else if (upgradeNumber == 44 && SkillTree.drops2Bought == 0) { return; }
        else if (upgradeNumber == 45 && SkillTree.drops3Bought == 0) { return; }
        else if (upgradeNumber == 46 && SkillTree.drops4Bought == 0) { return; }
        else if (upgradeNumber == 47 && SkillTree.drops5Bought == 0) { return; }
        else if (upgradeNumber == 48 && SkillTree.drops6Bought == 0) { return; }

        else if (upgradeNumber == 50 && SkillTree.xp1Bought == 0) { return; }
        else if (upgradeNumber == 51 && SkillTree.xp2Bought == 0) { return; }
        else if (upgradeNumber == 52 && SkillTree.xp3Bought == 0) { return; }
        else if (upgradeNumber == 53 && SkillTree.xp4Bought == 0) { return; }
        else if (upgradeNumber == 54 && SkillTree.xp5Bought == 0) { return; }
        else if (upgradeNumber == 55 && SkillTree.xp6Bought == 0) { return; }
        else if (upgradeNumber == 56 && SkillTree.xp7Bought == 0) { return; }

        else if (upgradeNumber == 58 && SkillTree.levelSpecial1Bought == 0) { return; }
        else if (upgradeNumber == 59 && SkillTree.levelSpecial2Bought == 0) { return; }
        else if (upgradeNumber == 60 && SkillTree.levelSpecial3Bought == 0) { return; }
        else if (upgradeNumber == 61 && SkillTree.levelSpecial4Bought == 0) { return; }

        else if (upgradeNumber == 63 && SkillTree.strongerSpecial1Bought == 0) { return; }
        else if (upgradeNumber == 64 && SkillTree.strongerSpecial2Bought == 0) { return; }
        else if (upgradeNumber == 65 && SkillTree.strongerSpecial3Bought == 0) { return; }
        else if (upgradeNumber == 66 && SkillTree.strongerSpecial4Bought == 0) { return; }
        else if (upgradeNumber == 67 && SkillTree.strongerSpecial5Bought == 0) { return; }
        else if (upgradeNumber == 68 && SkillTree.strongerSpecial6Bought == 0) { return; }

        else if (upgradeNumber == 70 && SkillTree.startWithItem1Bought == 0) { return; }
        else if (upgradeNumber == 71 && SkillTree.startWithItem2Bought == 0) { return; }
        else if (upgradeNumber == 72 && SkillTree.startWithItem3Bought == 0) { return; }

        else if (upgradeNumber == 74 && UpdateGame.reinforced1Bought == 0) { return; }
        else if (upgradeNumber == 75 && UpdateGame.reinforced2Bought == 0) { return; }
        else if (upgradeNumber == 76 && UpdateGame.reinforced3Bought == 0) { return; }
        else if (upgradeNumber == 77 && UpdateGame.reinforced4Bought == 0) { return; }

        else if (upgradeNumber == 79 && UpdateGame.greaterLoot1Bought == 0) { return; }
        else if (upgradeNumber == 80 && UpdateGame.greaterLoot2Bought == 0) { return; }
        else if (upgradeNumber == 81 && UpdateGame.greaterLoot3Bought == 0) { return; }
        else if (upgradeNumber == 82 && UpdateGame.greaterLoot4Bought == 0) { return; }

        else if (upgradeNumber == 84 && UpdateGame.newChests1Bought == 0) { return; }
        else if (upgradeNumber == 85 && UpdateGame.newChests2Bought == 0) { return; }
        else if (upgradeNumber == 86 && UpdateGame.newChests3Bought == 0) { return; }
        else if (upgradeNumber == 87 && UpdateGame.newChests4Bought == 0) { return; }
        else if (upgradeNumber == 88 && UpdateGame.newChests5Bought == 0) { return; }
        #endregion

        skillTreeScript.CheckPriceTextColor();
        updateScript.CheckPriceTextColor();

        isPrestigeTooltipOpen = true;

        darkPrestigeUpgeade.SetActive(true);

        prestigeFrameNumber = upgradeNumber;

        toolTipFrames[upgradeNumber].SetActive(true);
        toolTipFrames[upgradeNumber].transform.localPosition = new Vector2(54, 20);
        toolTipFrames[upgradeNumber].transform.localScale = new Vector2(2.4f, 2.4f);

        if(isFoldPhone == true)
        {
            toolTipFrames[upgradeNumber].transform.localPosition = new Vector2(54, 10);
            toolTipFrames[upgradeNumber].transform.localScale = new Vector2(1.95f, 1.95f);
        }

        closePrestigeFrameBtn.SetActive(true);

        xposClose = -83.7f; yposClose = -65;
        xposBuy = -83.7f; yposBuy = 65;

        #region number size check
        if (upgradeNumber == 5) { xposClose = -72.8f; xposBuy = -72.8f; }
        else if (upgradeNumber == 6) { xposClose = -69f; xposBuy = -69f; }
        else if (upgradeNumber == 7) { xposClose = -69f; xposBuy = -69f; }

        else if (upgradeNumber == 14) { xposClose = -75f; xposBuy = -75f; }
        else if (upgradeNumber == 17) { xposClose = -70f; xposBuy = -70f; }
        else if (upgradeNumber == 18) { xposClose = -68f; xposBuy = -68f; }
        else if (upgradeNumber == 19) { xposClose = -70f; xposBuy = -70f; }

        else if (upgradeNumber == 20) { xposClose = -73f; xposBuy = -73f; }
        else if (upgradeNumber == 21) { xposClose = -70.7f; xposBuy = -70.7f; }
        else if (upgradeNumber == 24) { xposClose = -74.6f; xposBuy = -74.6f; }
        else if (upgradeNumber == 27) { xposClose = -71f; xposBuy = -71f; }

        else if (upgradeNumber == 28) { xposClose = -76.5f; xposBuy = -76.5f; }
        else if (upgradeNumber == 29) { xposClose = -77f; xposBuy = -77f; }
        else if (upgradeNumber == 30) { xposClose = -67f; xposBuy = -67f; }

        else if (upgradeNumber == 33) { xposClose = -77f; xposBuy = -77f; }
        else if (upgradeNumber == 34) { xposClose = -77f; xposBuy = -77f; }
        else if (upgradeNumber == 35) { xposClose = -77f; xposBuy = -77f; }
        else if (upgradeNumber == 37) { xposClose = -85f; xposBuy = -85f; }
        else if (upgradeNumber == 38) { xposClose = -74f; xposBuy = -74f; }
        else if (upgradeNumber == 39) { xposClose = -95f; xposBuy = -95f; }
        else if (upgradeNumber == 40) { xposClose = -95f; xposBuy = -95f; }
        else if (upgradeNumber == 41) { xposClose = -95f; xposBuy = -95f; }

        else if (upgradeNumber == 42) { xposClose = -77.3f; xposBuy = -77.3f; }
        else if (upgradeNumber == 43) { xposClose = -77.3f; xposBuy = -77.3f; }
        else if (upgradeNumber == 44) { xposClose = -77.3f; xposBuy = -77.3f; }
        else if (upgradeNumber == 45) { xposClose = -88.4f; xposBuy = -88.4f; }
        else if (upgradeNumber == 46) { xposClose = -88.4f; xposBuy = -88.4f; }
        else if (upgradeNumber == 47) { xposClose = -88.4f; xposBuy = -88.4f; }
        else if (upgradeNumber == 48) { xposClose = -83.7f; xposBuy = -83.7f; }

        else if (upgradeNumber == 49) { xposClose = -77f; xposBuy = -77f; }
        else if (upgradeNumber == 50) { xposClose = -77f; xposBuy = -77f; }
        else if (upgradeNumber == 51) { xposClose = -77f; xposBuy = -77f; }
        else if (upgradeNumber == 52) { xposClose = -77f; xposBuy = -77f; }
        else if (upgradeNumber == 53) { xposClose = -77f; xposBuy = -77f; }
        else if (upgradeNumber == 54) { xposClose = -90f; xposBuy = -90f; }
        else if (upgradeNumber == 55) { xposClose = -90f; xposBuy = -90f; }
        else if (upgradeNumber == 56) { xposClose = -90f; xposBuy = -90f; }

        else if (upgradeNumber == 57) { xposClose = -74f; xposBuy = -74f; }
        else if (upgradeNumber == 58) { xposClose = -74f; xposBuy = -74f; }
        else if (upgradeNumber == 59) { xposClose = -74f; xposBuy = -74f; }
        else if (upgradeNumber == 60) { xposClose = -74f; xposBuy = -74f; }
        else if (upgradeNumber == 61) { xposClose = -74f; xposBuy = -74f; }

        else if (upgradeNumber == 62) { xposClose = -74f; xposBuy = -74f; }
        else if (upgradeNumber == 63) { xposClose = -74f; xposBuy = -74f; }
        else if (upgradeNumber == 64) { xposClose = -74f; xposBuy = -74f; }
        else if (upgradeNumber == 65) { xposClose = -74f; xposBuy = -74f; }
        else if (upgradeNumber == 66) { xposClose = -82.6f; xposBuy = -82.6f; }
        else if (upgradeNumber == 67) { xposClose = -82.6f; xposBuy = -82.6f; }
        else if (upgradeNumber == 68) { xposClose = -82.6f; xposBuy = -82.6f; }

        else if (upgradeNumber == 69) { xposClose = -76.6f; xposBuy = -76.6f; }
        else if (upgradeNumber == 70) { xposClose = -76.6f; xposBuy = -76.6f; }
        else if (upgradeNumber == 71) { xposClose = -76.6f; xposBuy = -76.6f; }
        else if (upgradeNumber == 72) { xposClose = -76.6f; xposBuy = -76.6f; }

        else if (upgradeNumber == 73) { xposClose = -91f; xposBuy = -91f; }
        else if (upgradeNumber == 74) { xposClose = -102f; xposBuy = -102f; }
        else if (upgradeNumber == 75) { xposClose = -87f; xposBuy = -87f; }
        else if (upgradeNumber == 76) { xposClose = -117f; xposBuy = -117f; }
        else if (upgradeNumber == 77) { xposClose = -87f; xposBuy = -87f; }

        else if (upgradeNumber == 78) { xposClose = -77f; xposBuy = -77f; }
        else if (upgradeNumber == 79) { xposClose = -81.7f; xposBuy = -81.7f; }
        else if (upgradeNumber == 80) { xposClose = -82.3f; xposBuy = -82.3f; }
        else if (upgradeNumber == 81) { xposClose = -82f; xposBuy = -82f; }
        else if (upgradeNumber == 82) { xposClose = -93f; xposBuy = -93f; }

        else if (upgradeNumber == 83) { xposClose = -98f; xposBuy = -98f; }
        else if (upgradeNumber == 84) { xposClose = -98f; xposBuy = -98f; }
        else if (upgradeNumber == 85) { xposClose = -82f; xposBuy = -82f; }
        else if (upgradeNumber == 86) { xposClose = -98f; xposBuy = -98f; }
        else if (upgradeNumber == 87) { xposClose = -98f; xposBuy = -98f; }
        else if (upgradeNumber == 88) { xposClose = -98f; xposBuy = -98f; }

        #endregion

        if (SkillTree.isInsideskillTree == true)
        {
            closePrestigeFrameBtn.transform.SetParent(toolTipFrames[upgradeNumber].GetComponent<Transform>());
            closePrestigeFrameBtn.transform.localPosition = new Vector2(xposClose, yposClose);
            closePrestigeFrameBtn.transform.localScale = new Vector2(0.5f, 0.5f);

            purchasePrestigeUpgradeBtn.SetActive(true);
            purchasePrestigeUpgradeBtn.transform.SetParent(toolTipFrames[upgradeNumber].GetComponent<Transform>());
            purchasePrestigeUpgradeBtn.transform.localPosition = new Vector2(xposBuy, yposBuy);
            purchasePrestigeUpgradeBtn.transform.localScale = new Vector2(0.5f, 0.5f);

            //1:40

            #region Check if purchased
            if (upgradeNumber == 0 && SkillTree.crit1Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 1 && SkillTree.crit2Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 2 && SkillTree.crit3Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 3 && SkillTree.crit4Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 4 && SkillTree.crit5Bought == 1) { SetOnlyClose(upgradeNumber); }

            else if (upgradeNumber == 5 && SkillTree.active1Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 6 && SkillTree.active2Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 7 && SkillTree.active3Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 8 && SkillTree.active4Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 9 && SkillTree.active5Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 10 && SkillTree.active6Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 11 && SkillTree.active7Bought == 1) { SetOnlyClose(upgradeNumber); }

            else if (upgradeNumber == 12 && SkillTree.activeCursor1Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 13 && SkillTree.activeCursor2Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 14 && SkillTree.activeCursor3Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 15 && SkillTree.activeCursor4Bought == 1) { SetOnlyClose(upgradeNumber); }

            else if (upgradeNumber == 16 && SkillTree.autoClicker1Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 17 && SkillTree.autoClicker2Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 18 && SkillTree.autoClicker3Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 19 && SkillTree.autoClicker4Bought == 1) { SetOnlyClose(upgradeNumber); }

            else if (upgradeNumber == 20 && SkillTree.autoDamage1Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 21 && SkillTree.autoDamage2Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 22 && SkillTree.autoDamage3Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 23 && SkillTree.autoDamage4Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 24 && SkillTree.autoDamage5Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 25 && SkillTree.autoDamage6Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 26 && SkillTree.autoDamage7Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 27 && SkillTree.autoDamage8Bought == 1) { SetOnlyClose(upgradeNumber); }

            else if (upgradeNumber == 28 && SkillTree.autoCursor1Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 29 && SkillTree.autoCursor2Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 30 && SkillTree.autoCursor3Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 31 && SkillTree.autoCursor4Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 32 && SkillTree.autoCursor5Bought == 1) { SetOnlyClose(upgradeNumber); }

            else if (upgradeNumber == 33 && SkillTree.gold1Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 34 && SkillTree.gold2Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 35 && SkillTree.gold3Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 36 && SkillTree.gold4Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 37 && SkillTree.gold5Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 38 && SkillTree.gold6Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 39 && SkillTree.gold7Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 40 && SkillTree.gold8Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 41 && SkillTree.gold9Bought == 1) { SetOnlyClose(upgradeNumber); }

            else if (upgradeNumber == 42 && SkillTree.drops1Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 43 && SkillTree.drops2Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 44 && SkillTree.drops3Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 45 && SkillTree.drops4Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 46 && SkillTree.drops5Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 47 && SkillTree.drops6Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 48 && SkillTree.drops7Bought == 1) { SetOnlyClose(upgradeNumber); }

            else if (upgradeNumber == 49 && SkillTree.xp1Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 50 && SkillTree.xp2Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 51 && SkillTree.xp3Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 52 && SkillTree.xp4Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 53 && SkillTree.xp5Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 54 && SkillTree.xp6Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 55 && SkillTree.xp7Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 56 && SkillTree.xp8Bought == 1) { SetOnlyClose(upgradeNumber); }

            else if (upgradeNumber == 57 && SkillTree.levelSpecial1Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 58 && SkillTree.levelSpecial2Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 59 && SkillTree.levelSpecial3Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 60 && SkillTree.levelSpecial4Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 61 && SkillTree.levelSpecial5Bought == 1) { SetOnlyClose(upgradeNumber); }

            else if (upgradeNumber == 62 && SkillTree.strongerSpecial1Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 63 && SkillTree.strongerSpecial2Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 64 && SkillTree.strongerSpecial3Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 65 && SkillTree.strongerSpecial4Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 66 && SkillTree.strongerSpecial5Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 67 && SkillTree.strongerSpecial6Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 68 && SkillTree.strongerSpecial7Bought == 1) { SetOnlyClose(upgradeNumber); }

            else if (upgradeNumber == 69 && SkillTree.startWithItem1Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 70 && SkillTree.startWithItem2Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 71 && SkillTree.startWithItem3Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 72 && SkillTree.startWithItem4Bought == 1) { SetOnlyClose(upgradeNumber); }

            else if (upgradeNumber == 73 && UpdateGame.reinforced1Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 74 && UpdateGame.reinforced2Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 75 && UpdateGame.reinforced3Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 76 && UpdateGame.reinforced4Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 77 && UpdateGame.reinforced5Bought == 1) { SetOnlyClose(upgradeNumber); }

            else if (upgradeNumber == 78 && UpdateGame.greaterLoot1Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 79 && UpdateGame.greaterLoot2Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 80 && UpdateGame.greaterLoot3Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 81 && UpdateGame.greaterLoot4Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 82 && UpdateGame.greaterLoot5Bought == 1) { SetOnlyClose(upgradeNumber); }

            else if (upgradeNumber == 83 && UpdateGame.newChests1Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 84 && UpdateGame.newChests2Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 85 && UpdateGame.newChests3Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 86 && UpdateGame.newChests4Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 87 && UpdateGame.newChests5Bought == 1) { SetOnlyClose(upgradeNumber); }
            else if (upgradeNumber == 88 && UpdateGame.newChests6Bought == 1) { SetOnlyClose(upgradeNumber); }


            #endregion
        }
        else
        {
            SetOnlyClose(upgradeNumber);
        }
    }

    public void SetOnlyClose(int number)
    {
        purchasePrestigeUpgradeBtn.SetActive(false);
        yposClose = 0;
        closePrestigeFrameBtn.transform.SetParent(toolTipFrames[number].GetComponent<Transform>());
        closePrestigeFrameBtn.transform.localPosition = new Vector2(xposClose, yposClose);
        closePrestigeFrameBtn.transform.localScale = new Vector2(0.5f, 0.5f);
    }

    public void ClosePrestigeFrame()
    {
        if (AudioManager.audioMuted == 1) { audioManager.Play("UIClick1"); }
        isPrestigeTooltipOpen = false;
        toolTipFrames[prestigeFrameNumber].SetActive(false);
        darkPrestigeUpgeade.SetActive(false);
    }
    #endregion

    #region Purchase prestige upgrade
    public SkillTree skillTreeScript;
    public UpdateGame updateScript;

    public void PurchasePrestigeUpgrade()
    {
        if (prestigeFrameNumber == 0) { skillTreeScript.BuyCrit1Upgrade(); }
        else if (prestigeFrameNumber == 1) { skillTreeScript.BuyCrit2Upgrade(); }
        else if (prestigeFrameNumber == 2) { skillTreeScript.BuyCrit3Upgrade(); }
        else if (prestigeFrameNumber == 3) { skillTreeScript.BuyCrit4Upgrade(); }
        else if (prestigeFrameNumber == 4) { skillTreeScript.BuyCrit5Upgrade(); }

        else if (prestigeFrameNumber == 5) { skillTreeScript.BuyActiveBranch1(); }
        else if (prestigeFrameNumber == 6) { skillTreeScript.BuyActiveBranch2(); }
        else if (prestigeFrameNumber == 7) { skillTreeScript.BuyActiveBranch3(); }
        else if (prestigeFrameNumber == 8) { skillTreeScript.BuyActiveBranch4(); }
        else if (prestigeFrameNumber == 9) { skillTreeScript.BuyActiveBranch5(); }
        else if (prestigeFrameNumber == 10) { skillTreeScript.BuyActiveBranch6(); }
        else if (prestigeFrameNumber == 11) { skillTreeScript.BuyActiveBranch7(); }

        else if (prestigeFrameNumber == 12) { skillTreeScript.BuyActiveCursor1(); }
        else if (prestigeFrameNumber == 13) { skillTreeScript.BuyActiveCursor2(); }
        else if (prestigeFrameNumber == 14) { skillTreeScript.BuyActiveCursor3(); }
        else if (prestigeFrameNumber == 15) { skillTreeScript.BuyActiveCursor4(); }

        else if (prestigeFrameNumber == 16) { skillTreeScript.BuyAutoClicker1(); }
        else if (prestigeFrameNumber == 17) { skillTreeScript.BuyAutoClicker2(); }
        else if (prestigeFrameNumber == 18) { skillTreeScript.BuyAutoClicker3(); }
        else if (prestigeFrameNumber == 19) { skillTreeScript.BuyAutoClicker4(); }

        else if (prestigeFrameNumber == 20) { skillTreeScript.BuyAutoDamage1(); }
        else if (prestigeFrameNumber == 21) { skillTreeScript.BuyAutoDamage2(); }
        else if (prestigeFrameNumber == 22) { skillTreeScript.BuyAutoDamage3(); }
        else if (prestigeFrameNumber == 23) { skillTreeScript.BuyAutoDamage4(); }
        else if (prestigeFrameNumber == 24) { skillTreeScript.BuyAutoDamage5(); }
        else if (prestigeFrameNumber == 25) { skillTreeScript.BuyAutoDamage6(); }
        else if (prestigeFrameNumber == 26) { skillTreeScript.BuyAutoDamage7(); }
        else if (prestigeFrameNumber == 27) { skillTreeScript.BuyAutoDamage8(); }

        else if (prestigeFrameNumber == 28) { skillTreeScript.BuyAutoCursor1(); }
        else if (prestigeFrameNumber == 29) { skillTreeScript.BuyAutoCursor2(); }
        else if (prestigeFrameNumber == 30) { skillTreeScript.BuyAutoCursor3(); }
        else if (prestigeFrameNumber == 31) { skillTreeScript.BuyAutoCursor4(); }
        else if (prestigeFrameNumber == 32) { skillTreeScript.BuyAutoCursor5(); }

        else if (prestigeFrameNumber == 33) { skillTreeScript.BuyGold1(); }
        else if (prestigeFrameNumber == 34) { skillTreeScript.BuyGold2(); }
        else if (prestigeFrameNumber == 35) { skillTreeScript.BuyGold3(); }
        else if (prestigeFrameNumber == 36) { skillTreeScript.BuyGold4(); }
        else if (prestigeFrameNumber == 37) { skillTreeScript.BuyGold5(); }
        else if (prestigeFrameNumber == 38) { skillTreeScript.BuyGold6(); }
        else if (prestigeFrameNumber == 39) { skillTreeScript.BuyGold7(); }
        else if (prestigeFrameNumber == 40) { skillTreeScript.BuyGold8(); }
        else if (prestigeFrameNumber == 41) { skillTreeScript.BuyGold9(); }

        else if (prestigeFrameNumber == 42) { skillTreeScript.BuyDrops1(); }
        else if (prestigeFrameNumber == 43) { skillTreeScript.BuyDrops2(); }
        else if (prestigeFrameNumber == 44) { skillTreeScript.BuyDrops3(); }
        else if (prestigeFrameNumber == 45) { skillTreeScript.BuyDrops4(); }
        else if (prestigeFrameNumber == 46) { skillTreeScript.BuyDrops5(); }
        else if (prestigeFrameNumber == 47) { skillTreeScript.BuyDrops6(); }
        else if (prestigeFrameNumber == 48) { skillTreeScript.BuyDrops7(); }

        else if (prestigeFrameNumber == 49) { skillTreeScript.BuyXP1(); }
        else if (prestigeFrameNumber == 50) { skillTreeScript.BuyXP2(); }
        else if (prestigeFrameNumber == 51) { skillTreeScript.BuyXP3(); }
        else if (prestigeFrameNumber == 52) { skillTreeScript.BuyXP4(); }
        else if (prestigeFrameNumber == 53) { skillTreeScript.BuyXP5(); }
        else if (prestigeFrameNumber == 54) { skillTreeScript.BuyXP6(); }
        else if (prestigeFrameNumber == 55) { skillTreeScript.BuyXP7(); }
        else if (prestigeFrameNumber == 56) { skillTreeScript.BuyXP8(); }

        else if (prestigeFrameNumber == 57) { skillTreeScript.BuyLevelSpecial1(); }
        else if (prestigeFrameNumber == 58) { skillTreeScript.BuyLevelSpecial2(); }
        else if (prestigeFrameNumber == 59) { skillTreeScript.BuyLevelSpecial3(); }
        else if (prestigeFrameNumber == 60) { skillTreeScript.BuyLevelSpecial4(); }
        else if (prestigeFrameNumber == 61) { skillTreeScript.BuyLevelSpecial5(); }

        else if (prestigeFrameNumber == 62) { skillTreeScript.BuyStrongerSpecial1(); }
        else if (prestigeFrameNumber == 63) { skillTreeScript.BuyStrongerSpecial2(); }
        else if (prestigeFrameNumber == 64) { skillTreeScript.BuyStrongerSpecial3(); }
        else if (prestigeFrameNumber == 65) { skillTreeScript.BuyStrongerSpecial4(); }
        else if (prestigeFrameNumber == 66) { skillTreeScript.BuyStrongerSpecial5(); }
        else if (prestigeFrameNumber == 67) { skillTreeScript.BuyStrongerSpecial6(); }
        else if (prestigeFrameNumber == 68) { skillTreeScript.BuyStrongerSpecial7(); }

        else if (prestigeFrameNumber == 69) { skillTreeScript.BuyStartWithItem1(); }
        else if (prestigeFrameNumber == 70) { skillTreeScript.BuyStartWithItem2(); }
        else if (prestigeFrameNumber == 71) { skillTreeScript.BuyStartWithItem3(); }
        else if (prestigeFrameNumber == 72) { skillTreeScript.BuyStartWithItem4(); }

        else if (prestigeFrameNumber == 73) { updateScript.BuyReinforced1Upgrade(); }
        else if (prestigeFrameNumber == 74) { updateScript.BuyReinforced2Upgrade(); }
        else if (prestigeFrameNumber == 75) { updateScript.BuyReinforced3Upgrade(); }
        else if (prestigeFrameNumber == 76) { updateScript.BuyReinforced4Upgrade(); }
        else if (prestigeFrameNumber == 77) { updateScript.BuyReinforced5Upgrade(); }

        else if (prestigeFrameNumber == 78) { updateScript.BuyGreaterLoot1Upgrade(); }
        else if (prestigeFrameNumber == 79) { updateScript.BuyGreaterLoot2Upgrade(); }
        else if (prestigeFrameNumber == 80) { updateScript.BuyGreaterLoot3Upgrade(); }
        else if (prestigeFrameNumber == 81) { updateScript.BuyGreaterLoot4Upgrade(); }
        else if (prestigeFrameNumber == 82) { updateScript.BuyGreaterLoot5Upgrade(); }

        else if (prestigeFrameNumber == 83) { updateScript.BuyNewChests1Upgrade(); }
        else if (prestigeFrameNumber == 84) { updateScript.BuyNewChests2Upgrade(); }
        else if (prestigeFrameNumber == 85) { updateScript.BuyNewChests3Upgrade(); }
        else if (prestigeFrameNumber == 86) { updateScript.BuyNewChests4Upgrade(); }
        else if (prestigeFrameNumber == 87) { updateScript.BuyNewChests5Upgrade(); }
        else if (prestigeFrameNumber == 88) { updateScript.BuyNewChests6Upgrade(); }
    }
    #endregion

    #region OpenActiveAndPassive
    public GameObject activeBar, passiveBar, activeClose, passiveClose;
    public bool isPassive;

    public void OpenActiveOrPassive(bool isActive)
    {
        if(isMobile == true)
        {
            blackFrame.SetActive(true);
            if (isActive == true) { isPassive = false; activeBar.SetActive(true); activeClose.SetActive(true); }
            if (isActive == false) { isPassive = true; passiveBar.SetActive(true); passiveClose.SetActive(true); }
        }
        else
        {
            passiveClose.SetActive(false); activeClose.SetActive(false);
        }
    }

    public void CloseActiveOrPassive()
    {
        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("UIClick1"); }
        blackFrame.SetActive(false);
        if (isPassive == true) { passiveBar.SetActive(false); passiveClose.SetActive(false); }
        if (isPassive == false) { activeBar.SetActive(false); activeClose.SetActive(false); }
    }
    #endregion
}
