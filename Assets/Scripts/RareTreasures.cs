using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class RareTreasures : MonoBehaviour, IDataPersistence
{
    public static bool gotSkull, gotTrophy, gotSword, gotRing, gotStar, gotClover, gotCrown, gotBook, gotGuitar, gotTalarian, gotRune, gotBackPack, gotShield, gotPillBottle, gotMedal, gotCookie, gotPresent, gotAxe, got100X, gotEnvelope, gotPotion, gotSoulGem, gotScroll, gotBrick, gotChicken;

    public static int skullFound, trophyFound, swordFound, ringFound, starFound, cloverFound, crownFound, bookFound, guitarFOund, talarianFound, runeFound, backPackFound, shieldFound, pillBottleFound, medalFound, cookieFound, presentFound, axeFound, coin100XFound, envelopeFound, potionFound, soulGemFound, scrollFound, brickFound, chickenFound;

    public GameObject skullIcon, trophyIcon, swordIcon, ringIcon, starIcon, cloverIcon, crownIcon, bookIcon, guitarIcon, talarianIcon, runeIcon, backPackIcon, shieldIcon, pillBottleIcon, medalIcon, cookieIcon, presentIcon, axeIcon, coin100XIcon, envelopeIcon, potionIcon, soulGemIcon, scrollIcon, brickIcon, chickenIcon;

    public TextMeshProUGUI skullText, trophyText, swordText, ringText, starText, cloverText, crownText, bookText, guitarText, talarianText, runeText, backPackText, shieldText, pillBottleText, medalText, cookieText, presentText, axeText, coin100XText, envelopeText, potionText, soulGemText, scrollText, brickText, chickenText;

    public GameObject skullFoundHover, trophyFoundHover, swordFoundHover, ringFoundHover, starFoundHover, cloverFoundHover, crownFoundHover, bookFoundHover, guitarFOundHover, talarianFoundHover, runeFoundHover, backPackFoundHover, shieldFoundHover, pillBottleFoundHover, medalFoundHover, cookieFoundHover, presentFoundHover, axeFoundHover, coin100XFoundHover, envelopeFoundHover, potionFoundHover, soulGemFoundHover, scrollFoundHover, brickFoundHover, chickenGoundHover;

    public GameObject skullNotFoundHover, trophyNotFoundHover, swordNotFoundHover, ringNotFoundHover, starNotFoundHover, cloverNotFoundHover, crownNotFoundHover, bookNotFoundHover, guitarNotFOundHover, talarianNotFoundHover, runeNotFoundHover, backPackNotFoundHover, shieldFoundNotHover, pillBottleFoundNotHover, medalNotFoundHover, cookieNotFoundHover, presentNotFoundHover, axeNotFoundHover, coin100XNotFoundHover, envelopeNotFoundHover, potionNotFoundHover, soulGemNotFoundHover, scrollNotFoundHover, brickNotFoundHover, chickenNotFoundHover;

    public GameObject rareTreasureScreen, exPopUp, nextPagePopUp, previousPagePopUp;

    public string newHexValue = "#FFFFFF";
    public string blackHexValue = "#000000";
    public Color newColor, blackColor;

    public static bool allTreasuresFound;
    public TextMeshProUGUI rareTreasureBuyText, rareTreasureBuyTextHover;

    public AudioManager audioManager;

    public void Start()
    {
        page1.SetActive(true); page2.SetActive(false);

        blackHexValue = "#000000";
        newHexValue = "#FFFFFF";

        clover5XChance = 0; clover10XChance = 0; cookie5X = 0; cookie10X = 0;
        ColorUtility.TryParseHtmlString(newHexValue, out newColor);
        ColorUtility.TryParseHtmlString(blackHexValue, out blackColor);

        setEx = false;

        Invoke("wait", 0.38f);
        Invoke("SetBool", 1f);
    }

    public void SetBool()
    {
        setEx = true;
    }

    bool setEx;

    public void wait()
    {
        string path = Application.persistentDataPath + "/player.saveRareTreasures";

        if (File.Exists(path))
        {
            if (SaveAndLoad.onlyLoadNewSave == false)
            {
                GameData data = SaveSystem.LoadRareTreasures();
                skullFound = data.skullFound;
                trophyFound = data.trophyFound;
                swordFound = data.swordFound;
                ringFound = data.ringFound;
                starFound = data.starFound;
                crownFound = data.crownFound;
                cloverFound = data.cloverFound;
                bookFound = data.bookFound;
                guitarFOund = data.guitarFOund;
                talarianFound = data.talarianFound;
                runeFound = data.runeFound;
                backPackFound = data.backPackFound;
                shieldFound = data.shieldFound;
                pillBottleFound = data.pillBottleFound;
                medalFound = data.medalFound;
                cookieFound = data.cookieFound;
            }
            else { }
        }
        else
        {
            //Do nothing
        }

        if (skullFound == 1) { gotSkull = true; }
        if (trophyFound == 1) { gotTrophy = true; }
        if (swordFound == 1) { gotSword = true; }
        if (ringFound == 1) { gotRing = true; }
        if (starFound == 1) { gotStar = true; }
        if (crownFound == 1) { gotCrown = true; }
        if (cloverFound == 1) { gotClover = true; }
        if (bookFound == 1) { gotBook = true; }
        if (guitarFOund == 1) { gotGuitar = true; }
        if (talarianFound == 1) { gotTalarian = true; }
        if (runeFound == 1) { gotRune = true; }
        if (backPackFound == 1) { gotBackPack = true; }
        if (shieldFound == 1) { gotShield = true; }
        if (pillBottleFound == 1) { gotPillBottle = true; }
        if (medalFound == 1) { gotMedal = true; }
        if (cookieFound == 1) { gotCookie = true; }

        if (presentFound == 1) { gotPresent = true; }
        if (axeFound == 1) { gotAxe = true; }
        if (coin100XFound == 1) { got100X = true; }
        if (envelopeFound == 1) { gotEnvelope = true; }
        if (potionFound == 1) { gotPotion = true; }
        if (soulGemFound == 1) { gotSoulGem = true; }
        if (scrollFound == 1) { gotScroll = true; }
        if (brickFound == 1) { gotBrick = true; }
        if (chickenFound == 1) { gotChicken = true; }

        treasuresClick.clickedARareTreasure = true;

        #region foundOrNotFoundHover
        if (skullFound == 1) { skullFoundHover.SetActive(true); }
        if (skullFound == 0) { skullNotFoundHover.SetActive(true); skullFoundHover.SetActive(false); }

        if (swordFound == 1) { swordFoundHover.SetActive(true); }
        if (swordFound == 0) { swordNotFoundHover.SetActive(true); swordFoundHover.SetActive(false); }

        if (ringFound == 1) { ringFoundHover.SetActive(true); }
        if (ringFound == 0) { ringNotFoundHover.SetActive(true); ringFoundHover.SetActive(false); }

        if (trophyFound == 1) { trophyFoundHover.SetActive(true); }
        if (trophyFound == 0) { trophyNotFoundHover.SetActive(true); trophyFoundHover.SetActive(false); }

        if (starFound == 1) { starFoundHover.SetActive(true); }
        if (starFound == 0) { starNotFoundHover.SetActive(true); starFoundHover.SetActive(false); }

        if (cloverFound == 1) { cloverFoundHover.SetActive(true); }
        if (cloverFound == 0) { cloverNotFoundHover.SetActive(true); cloverFoundHover.SetActive(false); }

        if (crownFound == 1) { crownFoundHover.SetActive(true); }
        if (crownFound == 0) { crownNotFoundHover.SetActive(true); crownFoundHover.SetActive(false); }

        if (bookFound == 1) { bookFoundHover.SetActive(true); }
        if (bookFound == 0) { bookNotFoundHover.SetActive(true); bookFoundHover.SetActive(false); }

        if (guitarFOund == 1) { guitarFOundHover.SetActive(true); }
        if (guitarFOund == 0) { guitarNotFOundHover.SetActive(true); guitarFOundHover.SetActive(false); }

        if (talarianFound == 1) { talarianFoundHover.SetActive(true); }
        if (talarianFound == 0) { talarianNotFoundHover.SetActive(true); talarianFoundHover.SetActive(false); }

        if (runeFound == 1) { runeFoundHover.SetActive(true); }
        if (runeFound == 0) { runeNotFoundHover.SetActive(true); runeFoundHover.SetActive(false); }

        if (backPackFound == 1) { backPackFoundHover.SetActive(true); }
        if (backPackFound == 0) { backPackNotFoundHover.SetActive(true); backPackFoundHover.SetActive(false); }

        if (shieldFound == 1) { shieldFoundHover.SetActive(true); }
        if (shieldFound == 0) { shieldFoundNotHover.SetActive(true); shieldFoundHover.SetActive(false); }

        if (pillBottleFound == 1) { pillBottleFoundHover.SetActive(true); }
        if (pillBottleFound == 0) { pillBottleFoundNotHover.SetActive(true); pillBottleFoundHover.SetActive(false); }

        if (medalFound == 1) { medalFoundHover.SetActive(true); }
        if (medalFound == 0) { medalNotFoundHover.SetActive(true); medalFoundHover.SetActive(false); }

        if (cookieFound == 1) { cookieFoundHover.SetActive(true); }
        if (cookieFound == 0) { cookieNotFoundHover.SetActive(true); cookieFoundHover.SetActive(false); }


        //New
        if (presentFound == 1) { presentFoundHover.SetActive(true); }
        if (presentFound == 0) { presentNotFoundHover.SetActive(true); presentFoundHover.SetActive(false); }

        if (axeFound == 1) { axeFoundHover.SetActive(true); }
        if (axeFound == 0) { axeNotFoundHover.SetActive(true); axeFoundHover.SetActive(false); }

        if (coin100XFound == 1) { coin100XFoundHover.SetActive(true); }
        if (coin100XFound == 0) { coin100XNotFoundHover.SetActive(true); coin100XFoundHover.SetActive(false); }

        if (envelopeFound == 1) { envelopeFoundHover.SetActive(true); }
        if (envelopeFound == 0) { envelopeNotFoundHover.SetActive(true); envelopeFoundHover.SetActive(false); }

        if (potionFound == 1) { potionFoundHover.SetActive(true); }
        if (potionFound == 0) { potionNotFoundHover.SetActive(true); potionFoundHover.SetActive(false); }

        if (soulGemFound == 1) { soulGemFoundHover.SetActive(true); }
        if (soulGemFound == 0) { soulGemNotFoundHover.SetActive(true); soulGemFoundHover.SetActive(false); }

        if (scrollFound == 1) { scrollFoundHover.SetActive(true); }
        if (scrollFound == 0) { scrollNotFoundHover.SetActive(true); scrollFoundHover.SetActive(false); }

        if (brickFound == 1) { brickFoundHover.SetActive(true); }
        if (brickFound == 0) { brickNotFoundHover.SetActive(true); brickFoundHover.SetActive(false); }

        if (chickenFound == 1) { chickenGoundHover.SetActive(true); }
        if (chickenFound == 0) { chickenNotFoundHover.SetActive(true); chickenGoundHover.SetActive(false); }
        #endregion

        ChoseChickenBuff();

        CheckAllTreasureFound();
    }



    #region SaveAndLoadJSON
    public void LoadData(GameDataJSON data)
    {
        skullFound = data.skullFound;
        trophyFound = data.trophyFound;
        swordFound = data.swordFound;
        ringFound = data.ringFound;
        starFound = data.starFound;
        crownFound = data.crownFound;
        cloverFound = data.cloverFound;
        bookFound = data.bookFound;
        guitarFOund = data.guitarFOund;
        talarianFound = data.talarianFound;
        runeFound = data.runeFound;
        backPackFound = data.backPackFound;
        shieldFound = data.shieldFound;
        pillBottleFound = data.pillBottleFound;
        medalFound = data.medalFound;
        cookieFound = data.cookieFound;

        presentFound = data.presentFound;
        axeFound = data.axeFound;
        coin100XFound = data.coin100XFound;
        envelopeFound = data.envelopeFound;
        potionFound = data.potionFound;
        soulGemFound = data.soulGemFound;
        scrollFound = data.scrollFound;
        brickFound = data.brickFound;
        chickenFound = data.chickenFound;

        choseChickenReward = data.choseChickenReward;

        choseActive = data.choseActive;
        chosePassive = data.chosePassive;
        choseCritChance = data.choseCritChance;
        choseCritDamage = data.choseCritDamage;
        choseXP = data.choseXP;
        choseGold = data.choseGold;
        choseTreasureChance = data.choseTreasureChance;
    }

    public void SaveData(ref GameDataJSON data)
    {
        data.skullFound = skullFound;
        data.trophyFound = trophyFound;
        data.swordFound = swordFound;
        data.ringFound = ringFound;
        data.starFound = starFound;
        data.crownFound = crownFound;
        data.cloverFound = cloverFound;
        data.bookFound = bookFound;
        data.guitarFOund = guitarFOund;
        data.talarianFound = talarianFound;
        data.runeFound = runeFound;
        data.backPackFound = backPackFound;
        data.shieldFound = shieldFound;
        data.pillBottleFound = pillBottleFound;
        data.medalFound = medalFound;
        data.cookieFound = cookieFound;

        data.presentFound = presentFound;
        data.axeFound = axeFound;
        data.coin100XFound = coin100XFound;
        data.envelopeFound = envelopeFound;
        data.potionFound = potionFound;
        data.soulGemFound = soulGemFound;
        data.scrollFound = scrollFound;
        data.brickFound = brickFound;
        data.chickenFound = chickenFound;

        data.choseChickenReward = choseChickenReward;

        data.choseActive = choseActive;
        data.chosePassive = chosePassive;
        data.choseCritChance = choseCritChance;
        data.choseCritDamage = choseCritDamage;
        data.choseXP = choseXP;
        data.choseGold = choseGold;
        data.choseTreasureChance = choseTreasureChance;

    }
    #endregion

    public GameObject mobileEXLicon, rareTreasureFrame;

    void Update()
    {
        if (rareTreasureScreen.activeInHierarchy == true)
        {
            exPopUp.SetActive(false);
            if(page1.activeInHierarchy == true) { previousPagePopUp.SetActive(false); }
            if(page2.activeInHierarchy == true) 
            {
                nextPagePopUp.SetActive(false); 
            }
            if(PlaceMobileButtons.isMobile == true) { nextPagePopUp.SetActive(false); previousPagePopUp.SetActive(false); }
        }

        if(treasuresClick.clickedARareTreasure == true)
        {
            if (gotSkull == true) { skullIcon.GetComponent<Image>().color = newColor; ChangeAlpha(skullIcon, newColor, 1f); gotSkull = false; skullFound = 1; SkullBonus(); CheckAllTreasureFound();  }
            if (gotTrophy == true) { trophyIcon.GetComponent<Image>().color = newColor; ChangeAlpha(trophyIcon, newColor, 1f); gotTrophy = false; TrophyBonus(); trophyFound = 1; CheckAllTreasureFound(); }
            if (gotSword == true) { swordIcon.GetComponent<Image>().color = newColor; ChangeAlpha(swordIcon, newColor, 1f); gotSword = false; swordFound = 1; SwordBonus(); CheckAllTreasureFound(); }
            if (gotRing == true) { ringIcon.GetComponent<Image>().color = newColor; ChangeAlpha(ringIcon, newColor, 1f); gotRing = false; RingBonus(); ringFound = 1; CheckAllTreasureFound(); }
            if (gotStar == true) { starIcon.GetComponent<Image>().color = newColor; ChangeAlpha(starIcon, newColor, 1f); gotStar = false; StarBonus(); starFound = 1; CheckAllTreasureFound(); }
            if (gotClover == true) { cloverIcon.GetComponent<Image>().color = newColor; ChangeAlpha(cloverIcon, newColor, 1f); gotClover = false; cloverFound = 1; CloverBonus(); CheckAllTreasureFound(); }
            if (gotCrown == true) { crownIcon.GetComponent<Image>().color = newColor; ChangeAlpha(crownIcon, newColor, 1f); gotCrown = false; CrownBonus(); crownFound = 1; CheckAllTreasureFound(); }
            if (gotBook == true) { bookIcon.GetComponent<Image>().color = newColor; ChangeAlpha(bookIcon, newColor, 1f); gotBook = false; BookBonus(); bookFound = 1; CheckAllTreasureFound(); }
            if (gotGuitar == true) { guitarIcon.GetComponent<Image>().color = newColor; ChangeAlpha(guitarIcon, newColor, 1f); gotGuitar = false; guitarFOund = 1; GuitarBonus(); CheckAllTreasureFound(); }
            if (gotTalarian == true) { talarianIcon.GetComponent<Image>().color = newColor; ChangeAlpha(talarianIcon, newColor, 1f); gotTalarian = false; talarianFound = 1; TalarianBonus(); CheckAllTreasureFound(); }
            if (gotRune == true) { runeIcon.GetComponent<Image>().color = newColor; ChangeAlpha(runeIcon, newColor, 1f); gotRune = false; runeFound = 1; RuneBonus(); CheckAllTreasureFound(); }
            if (gotBackPack == true) { backPackIcon.GetComponent<Image>().color = newColor; ChangeAlpha(backPackIcon, newColor, 1f); gotBackPack = false; BackPackBonus(); backPackFound = 1; CheckAllTreasureFound(); }
            if (gotShield == true) { shieldIcon.GetComponent<Image>().color = newColor; ChangeAlpha(shieldIcon, newColor, 1f); gotShield = false; ShieldBonus(); shieldFound = 1; CheckAllTreasureFound(); }
            if (gotPillBottle == true) { pillBottleIcon.GetComponent<Image>().color = newColor; ChangeAlpha(pillBottleIcon, newColor, 1f); gotPillBottle = false; pillBottleFound = 1; PillBottleBonus(); CheckAllTreasureFound(); }
            if (gotMedal == true) { medalIcon.GetComponent<Image>().color = newColor; ChangeAlpha(medalIcon, newColor, 1f); gotMedal = false; medalFound = 1; MedaLBonus(); CheckAllTreasureFound(); }
            if (gotCookie == true) { cookieIcon.GetComponent<Image>().color = newColor; ChangeAlpha(cookieIcon, newColor, 1f); gotCookie = false; CookieBonus(); cookieFound = 1; CheckAllTreasureFound(); }

            //New treasures
            if (gotPresent == true) { presentIcon.GetComponent<Image>().color = newColor; ChangeAlpha(presentIcon, newColor, 1f); gotPresent = false; PresentBonus(); presentFound = 1; CheckAllTreasureFound(); }
            if (gotAxe == true) { axeIcon.GetComponent<Image>().color = newColor; ChangeAlpha(axeIcon, newColor, 1f); gotAxe = false; AxeBonus(); axeFound = 1; CheckAllTreasureFound(); }
            if (got100X == true) { coin100XIcon.GetComponent<Image>().color = newColor; ChangeAlpha(coin100XIcon, newColor, 1f); got100X = false; Coin100XBonus(); coin100XFound = 1; CheckAllTreasureFound(); }
            if (gotEnvelope == true) { envelopeIcon.GetComponent<Image>().color = newColor; ChangeAlpha(envelopeIcon, newColor, 1f); EnvelopeBonus(); gotEnvelope = false; envelopeFound = 1; CheckAllTreasureFound(); }
            if (gotPotion == true) { potionIcon.GetComponent<Image>().color = newColor; ChangeAlpha(potionIcon, newColor, 1f); gotPotion = false; PotionBonus(); potionFound = 1; CheckAllTreasureFound(); }
            if (gotSoulGem == true) { soulGemIcon.GetComponent<Image>().color = newColor; ChangeAlpha(soulGemIcon, newColor, 1f); gotSoulGem = false; SoulGemBonus(); soulGemFound = 1; CheckAllTreasureFound(); }
            if (gotScroll == true) { scrollIcon.GetComponent<Image>().color = newColor; ChangeAlpha(scrollIcon, newColor, 1f); gotScroll = false; ScrollBonus(); scrollFound = 1; CheckAllTreasureFound(); }
            if (gotBrick == true) { brickIcon.GetComponent<Image>().color = newColor; ChangeAlpha(brickIcon, newColor, 1f); gotBrick = false; BrickBonus(); brickFound = 1; CheckAllTreasureFound(); }
            if (gotChicken == true) { chickenIcon.GetComponent<Image>().color = newColor; ChangeAlpha(chickenIcon, newColor, 1f); gotChicken = false; ChickenBonus(); chickenFound = 1; CheckAllTreasureFound(); }

            if(rareTreasureFrame.activeInHierarchy == false && setEx == true)
            {
                mobileEXLicon.SetActive(true);
            }

            treasuresClick.clickedARareTreasure = false;
        }

        if (PlayerLevel.skillPoints >= 200)
        {
            rareTreasureBuyText.color = Color.green;
            rareTreasureBuyTextHover.text = Localization.priceEqual + " <color=green>" + Localization.skillPoints200;
        }
        if (PlayerLevel.skillPoints < 200)
        {
            rareTreasureBuyText.color = Color.red;
            rareTreasureBuyTextHover.text = Localization.priceEqual + " <color=red>" + Localization.skillPoints200;
        }
    }

    public TMP_FontAsset treasuresFont, blackBoldFont;


    #region skull
    public static float skullPassiveDamage;
    public void SkullBonus()
    {
        SetTextProperties(skullText, Localization.PIRATE_SKULL);
        skullText.fontSize = Localization.skullSize;
        skullPassiveDamage = 0.03f;

        skullFoundHover.SetActive(true); skullNotFoundHover.SetActive(false);
        ClickPower.cursorsPriceChanged = true;
    }
    #endregion

    #region trophy
    public void TrophyBonus()
    {
        SetTextProperties(trophyText, Localization.TROPHY);
        trophyText.fontSize = Localization.trophySize;

        if(trophyFound != 1) {
            Stats.treasureDropChanceIncrease += 0.05f;

            SpawnRewards.quartzBaseChance += 0.05f;
            SpawnRewards.amethystBaseChance += 0.05f;
            SpawnRewards.yellowTopacBaseChance += 0.05f;
            SpawnRewards.albiteBaseChance += 0.05f;
            SpawnRewards.redGarnetBaseChance += 0.05f;
            SpawnRewards.aquamarineBaseChance += 0.05f;
            SpawnRewards.yellowSapphireBaseChance += 0.05f;
            SpawnRewards.pinkTourmalineBaseChance += 0.05f;
            SpawnRewards.adventurineBaseChance += 0.05f;
            SpawnRewards.redGemCBaseChance += 0.05f;
            SpawnRewards.diamondBaseChance += 0.05f;
            SpawnRewards.grandidieriteBaseChance += 0.05f;
            SpawnRewards.violetBaseChance += 0.05f;
            SpawnRewards.akoyaPearlBaseChance += 0.05f;
            SpawnRewards.purpleRupeeBaseChance += 0.05f;
            SpawnRewards.emeraldDropBaseChance += 0.05f;
            SpawnRewards.greenDiamondBaseChance += 0.05f;
            SpawnRewards.fireOpalBaseChance += 0.05f;
            SpawnRewards.gemSilicaBaseChance += 0.05f;
            SpawnRewards.pinkPlortBaseChance += 0.05f;
            SpawnRewards.goldenSeaPearlBaseChance += 0.05f;
            SpawnRewards.kyaniteBaseChance += 0.05f;
            SpawnRewards.blackOpalBaseChance += 0.05f;
            SpawnRewards.painiteBaseChance += 0.05f;
            SpawnRewards.tanzaniteBaseChance += 0.05f;

        }

        trophyFoundHover.SetActive(true); trophyNotFoundHover.SetActive(false);
        SpawnRewards.changeDropChanceValues = true;
    }
    #endregion

    #region sword
    public static float swordActive, swordCrit;
    public void SwordBonus()
    {
        SetTextProperties(swordText, Localization.DEMONIC_SWORD);
        swordText.fontSize = Localization.demonicSwordSize;
       
        swordActive = 0.05f; swordCrit = 0.3f;

        swordFoundHover.SetActive(true); swordNotFoundHover.SetActive(false);
        ClickPower.cursorsPriceChanged = true;
    }
    #endregion

    #region ring
    public void RingBonus()
    {
        SetTextProperties(ringText, Localization.MYSTIC_RING);
        ringText.fontSize = Localization.mysticRingSize;
       

        if(ringFound != 1)
        {
            Stats.treasureDropChanceIncrease += 0.05f;
            SpawnRewards.quartzBaseChance += 0.05f;
            SpawnRewards.amethystBaseChance += 0.05f;
            SpawnRewards.yellowTopacBaseChance += 0.05f;
            SpawnRewards.albiteBaseChance += 0.05f;
            SpawnRewards.redGarnetBaseChance += 0.05f;
            SpawnRewards.aquamarineBaseChance += 0.05f;
            SpawnRewards.yellowSapphireBaseChance += 0.05f;
            SpawnRewards.pinkTourmalineBaseChance += 0.05f;
            SpawnRewards.adventurineBaseChance += 0.05f;
            SpawnRewards.redGemCBaseChance += 0.05f;
            SpawnRewards.diamondBaseChance += 0.05f;
            SpawnRewards.grandidieriteBaseChance += 0.05f;
            SpawnRewards.violetBaseChance += 0.05f;
            SpawnRewards.akoyaPearlBaseChance += 0.05f;
            SpawnRewards.purpleRupeeBaseChance += 0.05f;
            SpawnRewards.emeraldDropBaseChance += 0.05f;
            SpawnRewards.greenDiamondBaseChance += 0.05f;
            SpawnRewards.fireOpalBaseChance += 0.05f;
            SpawnRewards.gemSilicaBaseChance += 0.05f;
            SpawnRewards.pinkPlortBaseChance += 0.05f;
            SpawnRewards.goldenSeaPearlBaseChance += 0.05f;
            SpawnRewards.kyaniteBaseChance += 0.05f;
            SpawnRewards.blackOpalBaseChance += 0.05f;
            SpawnRewards.painiteBaseChance += 0.05f;
            SpawnRewards.tanzaniteBaseChance += 0.05f;
        }
         
        ringFoundHover.SetActive(true); ringNotFoundHover.SetActive(false);
        SpawnRewards.changeDropChanceValues = true;
    }
    #endregion

    #region star
    public void StarBonus()
    {
        SetTextProperties(starText, Localization.FALLEN_STAR);
        starText.fontSize = Localization.fallenStarSize;
       

        if(starFound != 1)
        {
            SpawnRewards.doubleRareDropChance += 4;
        }

        starFoundHover.SetActive(true); starNotFoundHover.SetActive(false);
        SpawnRewards.changeDropChanceValues = true;
    }
    #endregion

    #region clover
    public static int clover5XChance, clover10XChance;

    public void CloverBonus()
    {
        SetTextProperties(cloverText, Localization.CLOVER);
        cloverText.fontSize = Localization.cloverSize;
       

        clover5XChance = 2; clover10XChance = 1;

        cloverFoundHover.SetActive(true);  cloverNotFoundHover.SetActive(false);
    }
    #endregion

    #region book
    public void BookBonus()
    {
        SetTextProperties(bookText, Localization.SPELL_BOOK);
        bookText.fontSize = Localization.spellBookSize;

        if(bookFound != 1)
        {
            #region specialUpgradesLevelUp
            SpecialUpgradesButtons.lockPickDropChanceIncrement += 0.004f;
            SpecialUpgradesButtons.lockPickOpenChanceIncrement += 1;

            SpecialUpgradesButtons.hammerDropChanceIncrement += 0.003f;
            SpecialUpgradesButtons.hammerDamageAmountIncrement += 0.2f;

            SpecialUpgradesButtons.keyDropChanceIncrement += 0.003f;
            SpecialUpgradesButtons.keyRareDropChanceIncrement += 0.1f;

            SpecialUpgradesButtons.goldenTouchDropChanceIncrement += 0.003f;

            SpecialUpgradesButtons.treasureBagDropChanceIncrement += 0.008f;

            SpecialUpgradesButtons.miniChestSpawnTimerMinus += 1;

            SpecialUpgradesButtons.XPPotionDropChanceIncrement += 0.003f;
            SpecialUpgradesButtons.XPPotionBufFIncrement += 0.03f;

            SpecialUpgradesButtons.damagePotionDropChanceIncrement += 0.003f;
            SpecialUpgradesButtons.damagePotionBuffIncrement += 0.05f;

            SpecialUpgradesButtons.lootPotionDropChanceIncrement += 0.003f;
            SpecialUpgradesButtons.lootPotionBuffIncrement += 0.05f;

            SpecialUpgradesButtons.elixirDropChanceIncrement += 0.002f;
            SpecialUpgradesButtons.elixirBuffIncrement += 0.05f;

            SpecialUpgradesButtons.gauntletDropChanceIncrement += 0.001f;
            SpecialUpgradesButtons.gauntletGoldDropChanceIncrement += 1f;

            UpdateGame.knifeDropChanceIncrement = 0.001f;
            UpdateGame.treasurePotionDropChanceIncrement = 0.001f;

            UpdateGame.barrelGoldValueIncrement += 0.01f;

            #endregion
        }

        bookFoundHover.SetActive(true); bookNotFoundHover.SetActive(false);
    }
    #endregion

    #region crown
    public void CrownBonus()
    {
        SetTextProperties(crownText, Localization.KINGS_CROWN);
        crownText.fontSize = Localization.kingsCrownSize;


        if(crownFound != 1) 
        {
            #region strongeractiveCursors
            //Cursor1
            ClickPower.cursor1ActiveBuffIncrement += 0.01f;

            //Cursor3
            ClickPower.cursor3CritChanceIncrement += 0.1f;
            ClickPower.cursor3CritDamageIncrement += 0.1f;

            //Cursor4
            ClickPower.cursor4ActiveDamageIncrement += 0.01f;

            //Cursor5
            ClickPower.cursor5ActiveDamageIncrement += 0.01f;
            ClickPower.cursor5CritDamageIncrement += 0.1f;
            ClickPower.cursor5CritChanceIncrement += 0.1f;

            //Cursor6
            ClickPower.cursor6CritChanceIncrement += 0.1f;
            ClickPower.cursor6ActiveDamageIncrement += 0.01f;
            ClickPower.cursor6CritDamageIncrement += 0.1f;

            //Cursor7
            ClickPower.cursor7ActiveDamageIncrement += 0.01f;
            ClickPower.cursor7CritChanceIncrement += 0.1f;
            ClickPower.cursor7CritDamageIncrement += 0.1f;

            //Cursor8
            ClickPower.cursor8ActiveDamageIncrement += 0.1f;
            ClickPower.cursor8CritChanceIncrement += 0.1f;
            ClickPower.cursor8CritDamageIncrement += 0.1f;

            //Cursor9
            ClickPower.cursor9ActiveDamageIncrement += 0.1f;

            //Cursor11
            ClickPower.cursor11ActiveDamageIncrement += 0.1f;
            ClickPower.cursor11CritChanceIncrement += 0.1f;
            ClickPower.cursor11CritDamageIncrement += 0.1f;

            //Cursor12
            ClickPower.cursor12ActiveDamageIncrement += 0.1f;
            ClickPower.cursor12CritChanceIncrement += 0.1f;
            ClickPower.cursor12CritDamageIncrement += 0.1f;

            //Cursor13
            ClickPower.cursor13ActiveDamageIncrement += 0.2f;
            ClickPower.cursor13CritChanceIncrement += 0.1f;
            ClickPower.cursor13CritDamageIncrement += 0.2f;

            //Cursor14
            ClickPower.cursor14ActiveDamageIncrement += 0.2f;
            ClickPower.cursor14CritChanceIncrement += 0.1f;
            ClickPower.cursor14CritDamageIncrement += 0.2f;

            //Cursor15
            ClickPower.cursor15ActiveDamageIncrement += 0.3f;
            ClickPower.cursor15CritChanceIncrement += 0.1f;
            ClickPower.cursor15CritDamageIncrement += 0.2f;

            //Cursor16
            ClickPower.cursor16ActiveDamageIncrement += 0.3f;
            ClickPower.cursor16CritChanceIncrement += 0.1f;
            ClickPower.cursor16CritDamageIncrement += 0.2f;

            //Cursor17
            ClickPower.cursor17ActiveDamageIncrement += 0.3f;
            ClickPower.cursor17CritChanceIncrement += 0.1f;
            ClickPower.cursor17CritDamageIncrement += 0.2f;

            //Cursor18
            ClickPower.cursor18ActiveDamageIncrement += 0.4f;
            ClickPower.cursor18CritChanceIncrement += 0.1f;
            ClickPower.cursor18CritDamageIncrement += 0.3f;

            //Cursor19
            ClickPower.cursor19ActiveDamageIncrement += 0.5f;
            ClickPower.cursor19CritChanceIncrement += 0.1f;
            ClickPower.cursor19CritDamageIncrement += 0.4f;

            //Cursor20
            ClickPower.cursor20ActiveDamageIncrement += 0.6f;
            ClickPower.cursor20CritChanceIncrement += 0.1f;
            ClickPower.cursor20CritDamageIncrement += 0.5f;

            //Cursor21
            ClickPower.cursor21ActiveDamageIncrement += 0.7f;
            ClickPower.cursor21CritChanceIncrement += 0.1f;
            ClickPower.cursor21CritDamageIncrement += 0.6f;
            #endregion

            #region passiveDamageCursors

            //Cursor1
            ClickPower.cursor2PassiveBuffIncrement += 0.01f;

            //Cursor4
            ClickPower.cursor4PassiveDamageIncrement += 0.01f;

            //Cursor6
            ClickPower.cursor6PassiveDamageIncrement += 0.01f;

            //Cursor8
            ClickPower.cursor8PassiveDamageIncrement += 0.1f;

            //Cursor9
            ClickPower.cursor9PassiveDamageIncrement += 0.1f;

            //Cursor10
            ClickPower.cursor10PassiveDamageIncrement += 0.1f;

            //Cursor12
            ClickPower.cursor12PassiveDamageIncrement += 0.1f;

            //Cursor13
            ClickPower.cursor13PassiveDamageIncrement += 0.2f;

            //Cursor14
            ClickPower.cursor14PassiveDamageIncrement += 0.2f;

            //Cursor15
            ClickPower.cursor15PassiveDamageIncrement += 0.3f;

            //Cursor16
            ClickPower.cursor16PassiveDamageIncrement += 0.3f;

            //Cursor17
            ClickPower.cursor17PassiveDamageIncrement += 0.4f;

            //Cursor18
            ClickPower.cursor18PassiveDamageIncrement += 0.4f;

            //Cursor19
            ClickPower.cursor19PassiveDamageIncrement += 0.6f;

            //Cursor20
            ClickPower.cursor20PassiveDamageIncrement += 0.8f;

            //Cursor21
            ClickPower.cursor21PassiveDamageIncrement += 1f;

            #endregion
        }

        crownFoundHover.SetActive(true); crownNotFoundHover.SetActive(false);
    }
    #endregion

    #region guitar
    public static float guitarActiveAndPassive;
    public void GuitarBonus()
    {
        SetTextProperties(guitarText, Localization.GUITAR);
        guitarText.fontSize = Localization.guitarSize;
        guitarActiveAndPassive = 0.2f;

        ClickPower.cursorsPriceChanged = true;

        guitarFOundHover.SetActive(true); guitarNotFOundHover.SetActive(false);
    }
    #endregion

    #region talarian
    public static float talariaPassive;
    public void TalarianBonus()
    {
        SetTextProperties(talarianText, Localization.TALARIAN);
        talarianText.fontSize = Localization.talarianSize;
        talariaPassive = 0.3f;

        ClickPower.cursorsPriceChanged = true;

        talarianFoundHover.SetActive(true); talarianNotFoundHover.SetActive(false);
    }
    #endregion

    #region rune
    public static float runeGold;
    public void RuneBonus()
    {
        SetTextProperties(runeText, Localization.MYTHRUNE);
        runeText.fontSize = Localization.mythruneSize;
        runeGold = 0.15f;

        runeFoundHover.SetActive(true); runeNotFoundHover.SetActive(false);
    }
    #endregion

    #region backPack
    public static float backPackGold, backPackXP;
    public void BackPackBonus()
    {
        SetTextProperties(backPackText, Localization.EXPLORER_BACKPACK);
        backPackText.fontSize = Localization.explorerBackpackSize;


        backPackGold = 0.15f; backPackXP = 0.15f;

        if(backPackFound != 1)
        {
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
        }

        backPackFoundHover.SetActive(true); backPackNotFoundHover.SetActive(false);

        SpawnRewards.changeDropChanceValues = true; 

    }

    #endregion

    #region shield
    public void ShieldBonus()
    {
        SetTextProperties(shieldText, Localization.VIKING_SHIELD);
        shieldText.fontSize = Localization.vikingShieldSize;

        if(shieldFound != 1)
        {
            SpawnRewards.doubleRareDropChance += 7;
        }

        shieldFoundHover.SetActive(true); shieldFoundNotHover.SetActive(false);
        SpawnRewards.changeDropChanceValues = true;
    }
    #endregion

    #region pillBottle

    public static int lootPotionPillStack, damagePotionPillStack, XPPotionPillStack, elixirPillStack;

    public void PillBottleBonus()
    {
        SetTextProperties(pillBottleText, Localization.PILL_BOTTLE);
        pillBottleText.fontSize = Localization.pillBottleSize;

        lootPotionPillStack = 1; damagePotionPillStack = 1; XPPotionPillStack = 1; elixirPillStack = 1;
        UseConsumable.potionStack = true;

        pillBottleFoundHover.SetActive(true); pillBottleFoundNotHover.SetActive(false);
    }
    #endregion

    #region medal
    public void MedaLBonus()
    {
        SetTextProperties(medalText, Localization.VICTORY_MEDAL);
        medalText.fontSize = Localization.victoryMedalSize;

        medalFoundHover.SetActive(true); medalNotFoundHover.SetActive(false);
    }
    #endregion

    #region cookie

    public static float cookieGold, cookieXP, cookiePassive, cookieActive, cookieCritChance, cookieCritDamage;
    public static int cookie5X, cookie10X;

    public void CookieBonus()
    {
        SetTextProperties(cookieText, Localization.COOKIE);
        cookieText.fontSize = Localization.cookieSize;

        cookieGold = 0.5f; cookieXP = 0.5f; cookiePassive = 0.75f; cookieActive = 0.75f; cookieCritChance = 3f; cookieCritDamage = 1.5f;
        

        if(cookieFound != 1)
        {
            SpawnRewards.doubleRareDropChance += 5;

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
        }


        cookieFoundHover.SetActive(true); cookieNotFoundHover.SetActive(false);
        SpawnRewards.changeDropChanceValues = true;
        ClickPower.cursorsPriceChanged = true;
    }

    public void ClickCookie()
    {
        if(cookieFound == 1)
        {
            clickedCookie = true;
        }
    }

    public static bool clickedCookie;

    #endregion

    public GameObject page1, page2;

    public void NextPage()
    {
        page1.SetActive(false); page2.SetActive(true);
        if (AudioManager.audioMuted == 1) { audioManager.Play("UIClick1"); }
    }

    public void PreviousPage()
    {
        page1.SetActive(true); page2.SetActive(false);
        if (AudioManager.audioMuted == 1) { audioManager.Play("UIClick1"); }
    }

    #region present

    public static float presentTreasurBuff, presentCritChanceBuff, presentCriDamageBuff, presentPassiveDamageBuff, presentActiveDamageBuff, presentXPBuff, presentGoldBuff;

    public void PresentBonus()
    {
        SetTextProperties(presentText, Localization.CHRISTMAS_PRESENT);
        presentText.fontSize = Localization.christmasPresentSize;

        presentTreasurBuff = 0.03f;
        presentCritChanceBuff = 0.07f;
        presentCriDamageBuff = 0.50f;
        presentPassiveDamageBuff = 0.15f;
        presentActiveDamageBuff = 0.25f;
        presentXPBuff = 0.15f;
        presentGoldBuff = 0.15f;

        presentFoundHover.SetActive(true); presentNotFoundHover.SetActive(false);
    }
    #endregion

    #region axe
    public void AxeBonus()
    {
        SetTextProperties(axeText, Localization.BATTLE_AXE);
        axeText.fontSize = Localization.battleAxeSize;

        axeFoundHover.SetActive(true); axeNotFoundHover.SetActive(false);
    }
    #endregion

    #region 100X
    public void Coin100XBonus()
    {
        SetTextProperties(coin100XText, Localization.GOLD_COIN_100X);
        coin100XText.fontSize = Localization.goldCoin100XSize;

        coin100XFoundHover.SetActive(true); coin100XNotFoundHover.SetActive(false);
    }
    #endregion

    #region envelope

    public static float envelopeReinforcedChance;
    public static bool chanceChange;

    public void EnvelopeBonus()
    {
        SetTextProperties(envelopeText, Localization.SEALED_ENVELOPE);
        envelopeText.fontSize = Localization.sealedEnvelopeSize;

        chanceChange = true;
        envelopeReinforcedChance = 0.2f;

        envelopeFoundHover.SetActive(true); envelopeNotFoundHover.SetActive(false);
    }
    #endregion

    #region potion
    public void PotionBonus()
    {
        SetTextProperties(potionText, Localization.STRANGE_POTION);
        potionText.fontSize = Localization.strangePotionSize;

        #region potionsUpgrades
        if (potionFound != 1)
        {
            SpecialUpgradesButtons.XPPotionDropChanceIncrement += 0.001f;
            SpecialUpgradesButtons.XPPotionBufFIncrement += 0.25f;

            SpecialUpgradesButtons.damagePotionDropChanceIncrement += 0.001f;
            SpecialUpgradesButtons.damagePotionBuffIncrement += 0.27f;

            SpecialUpgradesButtons.lootPotionDropChanceIncrement += 0.001f;
            SpecialUpgradesButtons.lootPotionBuffIncrement += 0.30f;

            SpecialUpgradesButtons.elixirDropChanceIncrement += 0.001f;
            SpecialUpgradesButtons.elixirBuffIncrement += 0.35f;

            UpdateGame.treasurePotionDropChanceIncrement += 0.001f;
            UpdateGame.treasurePotionChance += 0.5f;
        }
        #endregion


        potionFoundHover.SetActive(true); potionNotFoundHover.SetActive(false);
    }
    #endregion

    #region soulGem
    public void SoulGemBonus()
    {
        SetTextProperties(soulGemText, Localization.SOUL_GEM);
        soulGemText.fontSize = Localization.soulGemSize;

        soulGemFoundHover.SetActive(true); soulGemNotFoundHover.SetActive(false);
    }
    #endregion

    #region scroll

    public static float scrollRareTreasureTreasure, scrollRareTreasureCritChance, scrollRareTreasureCritDamage, scrollRareTreasureActiveDamage, scrollRareTreasurePassiveDamage, scrollRareTreasureXP, scrollRareTreasureGold;

    public void ScrollBonus()
    {
        SetTextProperties(scrollText, Localization.ANCIENT_SCROLL);
        scrollText.fontSize = Localization.ancientScrollSize;

        scrollRareTreasureTreasure = 0.01f;
        scrollRareTreasureCritChance = 0.01f;
        scrollRareTreasureCritDamage = 0.03f;
        scrollRareTreasureActiveDamage = 0.04f;
        scrollRareTreasurePassiveDamage = 0.02f;
        scrollRareTreasureXP = 0.01f;
        scrollRareTreasureGold = 0.01f;

        scrollFoundHover.SetActive(true); scrollNotFoundHover.SetActive(false);
    }
    #endregion

    #region brick
    public void BrickBonus()
    {
        SetTextProperties(brickText, Localization.BRICK);
        brickText.fontSize = Localization.brickSize;

        brickFoundHover.SetActive(true); brickNotFoundHover.SetActive(false);
    }
    #endregion

    #region chicken
    public void ChickenBonus()
    {
        SetTextProperties(chickenText, Localization.RUBBER_CHICKEN);
        chickenText.fontSize = Localization.rubberChickenSize;

        chickenGoundHover.SetActive(true); chickenNotFoundHover.SetActive(false);
    }
    #endregion

    public GameObject chooseBar;
    public TextMeshProUGUI clickToUseChickenText;
    public static bool choseChickenReward;

    public TextMeshProUGUI chooseActiveDamageText, choosePassiveDamageText, chooseCritChanceText, chooseCritDamageText, chooseXPText, chooseGoldText, chooseTreasureDropChanceText;
    public static int choseActive, chosePassive, choseCritChance, choseCritDamage, choseXP, choseGold, choseTreasureChance;

    #region chicken
    public void ChoseChickenBuff()
    {
        clickToUseChickenText.text = Localization.chooseChickenBuff;

        #region English Language

        if(Localization.EnglishLanguageChosen == 1)
        {
            if (choseActive == 1)
            {
                clickToUseChickenText.text = "YOU CHOSE <color=green>+" + (((SkillTree.skillTreeActiveDamage + RareTreasures.swordActive + RareTreasures.guitarActiveAndPassive + RareTreasures.cookieActive + UseConsumable.relicPermaActiveDamage) / 4) * 100).ToString("F0") + "% Active Damage";
            }

            if (chosePassive == 1)
            {
                clickToUseChickenText.text = "YOU CHOSE <color=green>+" + (((SkillTree.skillTreePassiveDamage + RareTreasures.skullPassiveDamage + RareTreasures.guitarActiveAndPassive + RareTreasures.talariaPassive + RareTreasures.cookiePassive + UseConsumable.relicPermaPassiveDamage) / 4) * 100).ToString("F0") + "% Passive Damage";
            }

            if (choseCritChance == 1)
            {
                clickToUseChickenText.text = "YOU CHOSE <color=green>+" + ((SkillTree.skillTreeCritChance + RareTreasures.cookieCritChance + RareTreasures.swordCrit + UseConsumable.relicPermaCritChance) / 4).ToString("F2") + "% Crit Chance";
            }

            if (choseCritDamage == 1)
            {
                clickToUseChickenText.text = "YOU CHOSE <color=green>+" + (((SkillTree.skillTreeCritDamage + UseConsumable.relicPermaCritDamage) / 4) * 100).ToString("F0") + "% Crit Damage";
            }

            if (choseXP == 1)
            {
                clickToUseChickenText.text = "<color=orange>YOU CHOSE +" + (((SkillTree.skillTreeXP + RareTreasures.backPackXP + RareTreasures.cookieXP + UseConsumable.relicPermaXPBuff) / 4) * 100).ToString("F0") + "% XP";
            }

            if (choseGold == 1)
            {
                clickToUseChickenText.text = "<color=yellow>YOU CHOSE +" + (((SkillTree.skillTreeGold + RareTreasures.runeGold + RareTreasures.cookieGold + RareTreasures.backPackGold + UseConsumable.relicPermaGoldBuff) / 4) * 100).ToString("F0") + "% GOLD";
            }

            if (choseTreasureChance == 1)
            {
                clickToUseChickenText.text = "YOU CHOSE <color=green>+" + ((UseConsumable.relicPermaTreasureBuff + Stats.treasureDropChanceIncrease) / 5).ToString("F2") + "% Treasure Drop Chance";
            }
        }

        #endregion

        #region Russian Language

        if (Localization.RussianLanguageChosen == 1)
        {
            if (choseActive == 1)
            {
                clickToUseChickenText.text = "ВЫ ВЫБРАЛИ <color=green>+" + (((SkillTree.skillTreeActiveDamage + RareTreasures.swordActive + RareTreasures.guitarActiveAndPassive + RareTreasures.cookieActive + UseConsumable.relicPermaActiveDamage) / 4) * 100).ToString("F0") + "% АКТИВНЫЙ УРОН";
            }

            if (chosePassive == 1)
            {
                clickToUseChickenText.text = "ВЫ ВЫБРАЛИ <color=green>+" + (((SkillTree.skillTreePassiveDamage + RareTreasures.skullPassiveDamage + RareTreasures.guitarActiveAndPassive + RareTreasures.talariaPassive + RareTreasures.cookiePassive + UseConsumable.relicPermaPassiveDamage) / 4) * 100).ToString("F0") + "% ПАССИВНЫЙ УРОН";
            }

            if (choseCritChance == 1)
            {
                clickToUseChickenText.text = "ВЫ ВЫБРАЛИ <color=green>+" + ((SkillTree.skillTreeCritChance + RareTreasures.cookieCritChance + RareTreasures.swordCrit + UseConsumable.relicPermaCritChance) / 4).ToString("F2") + "% ШАНС КРИТИЧЕСКОГО УДАРА";
            }

            if (choseCritDamage == 1)
            {
                clickToUseChickenText.text = "ВЫ ВЫБРАЛИ <color=green>+" + (((SkillTree.skillTreeCritDamage + UseConsumable.relicPermaCritDamage) / 4) * 100).ToString("F0") + "% УРОН КРИТИЧЕСКОГО УДАРА";
            }

            if (choseXP == 1)
            {
                clickToUseChickenText.text = "<color=orange>ВЫ ВЫБРАЛИ +" + (((SkillTree.skillTreeXP + RareTreasures.backPackXP + RareTreasures.cookieXP + UseConsumable.relicPermaXPBuff) / 4) * 100).ToString("F0") + "% ОПЫТ";
            }

            if (choseGold == 1)
            {
                clickToUseChickenText.text = "<color=yellow>ВЫ ВЫБРАЛИ +" + (((SkillTree.skillTreeGold + RareTreasures.runeGold + RareTreasures.cookieGold + RareTreasures.backPackGold + UseConsumable.relicPermaGoldBuff) / 4) * 100).ToString("F0") + "% ЗОЛОТО";
            }

            if (choseTreasureChance == 1)
            {
                clickToUseChickenText.text = "ВЫ ВЫБРАЛИ <color=green>+" + ((UseConsumable.relicPermaTreasureBuff + Stats.treasureDropChanceIncrease) / 5).ToString("F2") + "% ШАНС ВЫПАДЕНИЯ СОКРОВИЩА";
            }
        }

        #endregion

        #region Japan Language

        if (Localization.JapaneseLanguageChosen == 1)
        {
            if (choseActive == 1)
            {
                clickToUseChickenText.text = "アクティブダメージ<color=green>+" + (((SkillTree.skillTreeActiveDamage + RareTreasures.swordActive + RareTreasures.guitarActiveAndPassive + RareTreasures.cookieActive + UseConsumable.relicPermaActiveDamage) / 4) * 100).ToString("F0") + "%";
            }

            if (chosePassive == 1)
            {
                clickToUseChickenText.text = "パッシブダメージ<color=green>+" + (((SkillTree.skillTreePassiveDamage + RareTreasures.skullPassiveDamage + RareTreasures.guitarActiveAndPassive + RareTreasures.talariaPassive + RareTreasures.cookiePassive + UseConsumable.relicPermaPassiveDamage) / 4) * 100).ToString("F0") + "%";
            }

            if (choseCritChance == 1)
            {
                clickToUseChickenText.text = "クリティカルチャンス<color=green>+" + ((SkillTree.skillTreeCritChance + RareTreasures.cookieCritChance + RareTreasures.swordCrit + UseConsumable.relicPermaCritChance) / 4).ToString("F2") + "%";
            }

            if (choseCritDamage == 1)
            {
                clickToUseChickenText.text = "クリティカルダメージ<color=green>+" + (((SkillTree.skillTreeCritDamage + UseConsumable.relicPermaCritDamage) / 4) * 100).ToString("F0") + "%";
            }

            if (choseXP == 1)
            {
                clickToUseChickenText.text = "<color=orange>経験値" + (((SkillTree.skillTreeXP + RareTreasures.backPackXP + RareTreasures.cookieXP + UseConsumable.relicPermaXPBuff) / 4) * 100).ToString("F0") + "%";
            }

            if (choseGold == 1)
            {
                clickToUseChickenText.text = "ゴールド" + (((SkillTree.skillTreeGold + RareTreasures.runeGold + RareTreasures.cookieGold + RareTreasures.backPackGold + UseConsumable.relicPermaGoldBuff) / 4) * 100).ToString("F0") + "%";
            }

            if (choseTreasureChance == 1)
            {
                clickToUseChickenText.text = "トレジャードロップチャンス<color=green>" + ((UseConsumable.relicPermaTreasureBuff + Stats.treasureDropChanceIncrease) / 5).ToString("F2") + "%";
            }
        }

        #endregion

        #region Chinese Language

        if (Localization.ChineseLanguageChosen == 1)
        {
            if (choseActive == 1)
            {
                clickToUseChickenText.text = "<color=green>+" + (((SkillTree.skillTreeActiveDamage + RareTreasures.swordActive + RareTreasures.guitarActiveAndPassive + RareTreasures.cookieActive + UseConsumable.relicPermaActiveDamage) / 4) * 100).ToString("F0") + "%主动伤害";
            }

            if (chosePassive == 1)
            {
                clickToUseChickenText.text = "<color=green>+" + (((SkillTree.skillTreePassiveDamage + RareTreasures.skullPassiveDamage + RareTreasures.guitarActiveAndPassive + RareTreasures.talariaPassive + RareTreasures.cookiePassive + UseConsumable.relicPermaPassiveDamage) / 4) * 100).ToString("F0") + "% 被动伤害";
            }

            if (choseCritChance == 1)
            {
                clickToUseChickenText.text = "<color=green>+" + ((SkillTree.skillTreeCritChance + RareTreasures.cookieCritChance + RareTreasures.swordCrit + UseConsumable.relicPermaCritChance) / 4).ToString("F2") + "% 暴击几率";
            }

            if (choseCritDamage == 1)
            {
                clickToUseChickenText.text = "<color=green>+" + (((SkillTree.skillTreeCritDamage + UseConsumable.relicPermaCritDamage) / 4) * 100).ToString("F0") + "% 暴击伤害";
            }

            if (choseXP == 1)
            {
                clickToUseChickenText.text = "<color=orange>+" + (((SkillTree.skillTreeXP + RareTreasures.backPackXP + RareTreasures.cookieXP + UseConsumable.relicPermaXPBuff) / 4) * 100).ToString("F0") + "% 金币";
            }

            if (choseGold == 1)
            {
                clickToUseChickenText.text = "<color=yellow>+" + (((SkillTree.skillTreeGold + RareTreasures.runeGold + RareTreasures.cookieGold + RareTreasures.backPackGold + UseConsumable.relicPermaGoldBuff) / 4) * 100).ToString("F0") + "% 金币";
            }

            if (choseTreasureChance == 1)
            {
                clickToUseChickenText.text = "<color=green>+" + ((UseConsumable.relicPermaTreasureBuff + Stats.treasureDropChanceIncrease) / 5).ToString("F2") + "%宝藏掉落几率";
            }
        }

        #endregion

        #region Korean Language

        if (Localization.KoreanLanguageChosen == 1)
        {
            if (choseActive == 1)
            {
                clickToUseChickenText.text = "<color=green>+" + (((SkillTree.skillTreeActiveDamage + RareTreasures.swordActive + RareTreasures.guitarActiveAndPassive + RareTreasures.cookieActive + UseConsumable.relicPermaActiveDamage) / 4) * 100).ToString("F0") + "% 액티브 데미지";
            }

            if (chosePassive == 1)
            {
                clickToUseChickenText.text = "<color=green>+" + (((SkillTree.skillTreePassiveDamage + RareTreasures.skullPassiveDamage + RareTreasures.guitarActiveAndPassive + RareTreasures.talariaPassive + RareTreasures.cookiePassive + UseConsumable.relicPermaPassiveDamage) / 4) * 100).ToString("F0") + "%  패시브 데미지";
            }

            if (choseCritChance == 1)
            {
                clickToUseChickenText.text = "<color=green>+" + ((SkillTree.skillTreeCritChance + RareTreasures.cookieCritChance + RareTreasures.swordCrit + UseConsumable.relicPermaCritChance) / 4).ToString("F2") + "% 크리티컬 확률";
            }

            if (choseCritDamage == 1)
            {
                clickToUseChickenText.text = "<color=green>+" + (((SkillTree.skillTreeCritDamage + UseConsumable.relicPermaCritDamage) / 4) * 100).ToString("F0") + "% 크리티컬 데미지";
            }

            if (choseXP == 1)
            {
                clickToUseChickenText.text = "<color=orange>+" + (((SkillTree.skillTreeXP + RareTreasures.backPackXP + RareTreasures.cookieXP + UseConsumable.relicPermaXPBuff) / 4) * 100).ToString("F0") + "% XP";
            }

            if (choseGold == 1)
            {
                clickToUseChickenText.text = "<color=yellow>+" + (((SkillTree.skillTreeGold + RareTreasures.runeGold + RareTreasures.cookieGold + RareTreasures.backPackGold + UseConsumable.relicPermaGoldBuff) / 4) * 100).ToString("F0") + "% 골드";
            }

            if (choseTreasureChance == 1)
            {
                clickToUseChickenText.text = "<color=green>+" + ((UseConsumable.relicPermaTreasureBuff + Stats.treasureDropChanceIncrease) / 5).ToString("F2") + "% 보물 드롭 확률 ";
            }
        }

        #endregion
    }




    public void ClickOnChicken()
    {
        if (AudioManager.audioMuted == 1) { audioManager.Play("UIClick1"); }
        if (chickenFound == 1 && choseChickenReward == false)
        {
            chooseBar.SetActive(true);

            chooseActiveDamageText.text = "+" + (((SkillTree.skillTreeActiveDamage + RareTreasures.swordActive + RareTreasures.guitarActiveAndPassive + RareTreasures.cookieActive + UseConsumable.relicPermaActiveDamage) / 4) * 100).ToString("F0") + Localization.activeDamageScring;

            choosePassiveDamageText.text = "+" + (((SkillTree.skillTreePassiveDamage + RareTreasures.skullPassiveDamage + RareTreasures.guitarActiveAndPassive + RareTreasures.talariaPassive + RareTreasures.cookiePassive + UseConsumable.relicPermaPassiveDamage) / 4) * 100).ToString("F0") + Localization.passiveDamageString;

            chooseCritChanceText.text = "+" + ((SkillTree.skillTreeCritChance + RareTreasures.cookieCritChance + RareTreasures.swordCrit + UseConsumable.relicPermaCritChance) / 4).ToString("F2") + Localization.critChanceString;

            chooseCritDamageText.text = "+" + (((SkillTree.skillTreeCritDamage + UseConsumable.relicPermaCritDamage) / 4)*100).ToString("F0") + Localization.critDamageString;

            chooseXPText.text = "<color=orange>+" + (((SkillTree.skillTreeXP + RareTreasures.backPackXP + RareTreasures.cookieXP + UseConsumable.relicPermaXPBuff) / 4) * 100).ToString("F0") + Localization.xp;

            chooseGoldText.text = "<color=yellow>+" + (((SkillTree.skillTreeGold + RareTreasures.runeGold + RareTreasures.cookieGold + RareTreasures.backPackGold + UseConsumable.relicPermaGoldBuff) / 4)* 100).ToString("F0") + Localization.goldPercentString;

            chooseTreasureDropChanceText.text = "+" + ((UseConsumable.relicPermaTreasureBuff + Stats.treasureDropChanceIncrease) / 5).ToString("F2") + Localization.treasureDropChance;
        }
    }

    public void ChangeText()
    {
        chooseActiveDamageText.text = "+" + (((SkillTree.skillTreeActiveDamage + RareTreasures.swordActive + RareTreasures.guitarActiveAndPassive + RareTreasures.cookieActive + UseConsumable.relicPermaActiveDamage) / 4) * 100).ToString("F0") + Localization.activeDamageScring;

        choosePassiveDamageText.text = "+" + (((SkillTree.skillTreePassiveDamage + RareTreasures.skullPassiveDamage + RareTreasures.guitarActiveAndPassive + RareTreasures.talariaPassive + RareTreasures.cookiePassive + UseConsumable.relicPermaPassiveDamage) / 4) * 100).ToString("F0") + Localization.passiveDamageString;

        chooseCritChanceText.text = "+" + ((SkillTree.skillTreeCritChance + RareTreasures.cookieCritChance + RareTreasures.swordCrit + UseConsumable.relicPermaCritChance) / 4).ToString("F2") + Localization.critChanceString;

        chooseCritDamageText.text = "+" + (((SkillTree.skillTreeCritDamage + UseConsumable.relicPermaCritDamage) / 4) * 100).ToString("F0") + Localization.critDamageString;

        chooseXPText.text = "<color=orange>+" + (((SkillTree.skillTreeXP + RareTreasures.backPackXP + RareTreasures.cookieXP + UseConsumable.relicPermaXPBuff) / 4) * 100).ToString("F0") + Localization.xp;

        chooseGoldText.text = "<color=yellow>+" + (((SkillTree.skillTreeGold + RareTreasures.runeGold + RareTreasures.cookieGold + RareTreasures.backPackGold + UseConsumable.relicPermaGoldBuff) / 4) * 100).ToString("F0") + Localization.goldPercentString;

        chooseTreasureDropChanceText.text = "+" + ((UseConsumable.relicPermaTreasureBuff + Stats.treasureDropChanceIncrease) / 5).ToString("F2") + Localization.treasureDropChance;
    }

    public void ChooseActiveDamage()
    {
        UseConsumable.relicPermaActiveDamage += (SkillTree.skillTreeActiveDamage + RareTreasures.swordActive + RareTreasures.guitarActiveAndPassive + RareTreasures.cookieActive + UseConsumable.relicPermaActiveDamage) / 4;

        choseChickenReward = true;
        chooseBar.SetActive(false);

        choseActive = 1;
        ChoseChickenBuff();
        AudioSound();
    }

    public void ChoosePassiveDamage()
    {
        UseConsumable.relicPermaPassiveDamage += (SkillTree.skillTreePassiveDamage + RareTreasures.skullPassiveDamage + RareTreasures.guitarActiveAndPassive + RareTreasures.talariaPassive + RareTreasures.cookiePassive + UseConsumable.relicPermaPassiveDamage) / 4;

        choseChickenReward = true;
        chooseBar.SetActive(false);

        chosePassive = 1;
        ChoseChickenBuff();
        AudioSound();
    }
    public void ChooseCriChance()
    {
        UseConsumable.relicPermaCritChance += (SkillTree.skillTreeCritChance + RareTreasures.cookieCritChance + RareTreasures.swordCrit + UseConsumable.relicPermaCritChance) / 4;

        choseChickenReward = true;
        chooseBar.SetActive(false);

        choseCritChance = 1;
        ChoseChickenBuff();
        AudioSound();
    }

    public void ChooseCritDamage()
    {
        UseConsumable.relicPermaCritDamage += (SkillTree.skillTreeCritDamage + UseConsumable.relicPermaCritDamage) / 4;

        choseChickenReward = true;
        chooseBar.SetActive(false);

        choseCritDamage = 1;
        ChoseChickenBuff();
        AudioSound();
    }

    public void ChooseXP()
    {
        UseConsumable.relicPermaXPBuff += (SkillTree.skillTreeXP + RareTreasures.backPackXP + RareTreasures.cookieXP + UseConsumable.relicPermaXPBuff) /4;

        choseChickenReward = true;
        chooseBar.SetActive(false);

        choseXP = 1;
        ChoseChickenBuff();
        AudioSound();
    }

    public void ChooseGOLD()
    {
        UseConsumable.relicPermaGoldBuff += (SkillTree.skillTreeGold + RareTreasures.runeGold + RareTreasures.cookieGold + RareTreasures.backPackGold + UseConsumable.relicPermaGoldBuff) / 4;

        choseChickenReward = true;
        chooseBar.SetActive(false);

        choseGold = 1;
        ChoseChickenBuff();
        AudioSound();
    }

    public void ChooseTreasureDropChance()
    {
        UseConsumable.relicPermaTreasureBuff += (UseConsumable.relicPermaTreasureBuff + Stats.treasureDropChanceIncrease) / 4;
        SpawnRewards.changeDropChanceValues = true;

        choseChickenReward = true;
        chooseBar.SetActive(false);

        choseTreasureChance = 1;
        ChoseChickenBuff();
        AudioSound();
    }
    #endregion


    public Button RareTreasureButton;
    public GameObject treasureHoverUnlocked, treasureHoverNotUnlocked, treasureButtonLockIcon, treasureButtonPriceText, hudredPercentText, allTreasuresHover;

    public void CheckAllTreasureFound()
    {
        if (Stats.rareTreasuresFound >= 25)
        {
            //Debug.Log(Stats.rareTreasuresFound);
            allTreasuresFound = true;
        }

        if(allTreasuresFound == true)
        {
            RareTreasureButton.interactable = false;
            hudredPercentText.SetActive(true); allTreasuresHover.SetActive(true); treasureButtonPriceText.SetActive(false); treasureButtonLockIcon.SetActive(false); treasureHoverNotUnlocked.SetActive(false); treasureHoverUnlocked.SetActive(false);
        }

    }


    public void PurchaseMissingTreasures()
    {
        if (allTreasuresFound == false)
        {
            if (PlayerLevel.skillPoints >= 200)
            {
                PlayerLevel.skillPoints -= 200;
                CheckMissingTreasure();
            }
            if (PlayerLevel.skillPoints < 200)
            {
                if (AudioManager.audioMuted == 1)
                {
                    audioManager.Play("Error");
                }
            }
        }
    }



    public void CheckMissingTreasure()
    {
        if(skullFound != 1) { SkullBonus(); skullFound = 1; skullIcon.GetComponent<Image>().color = newColor;  }
        else if (swordFound != 1) { SwordBonus(); swordFound = 1; swordIcon.GetComponent<Image>().color = newColor;}
        else if (ringFound != 1) { RingBonus(); ringFound = 1; ringIcon.GetComponent<Image>().color = newColor;  }
        else if (trophyFound != 1) { TrophyBonus(); trophyFound = 1; trophyIcon.GetComponent<Image>().color = newColor;  }
        else if (starFound != 1) { StarBonus(); starFound = 1; starIcon.GetComponent<Image>().color = newColor; }
        else if (cloverFound != 1) { CloverBonus(); cloverFound = 1; cloverIcon.GetComponent<Image>().color = newColor;  }
        else if (crownFound != 1) { CrownBonus(); crownFound = 1; crownIcon.GetComponent<Image>().color = newColor;  }
        else if (bookFound != 1) { BookBonus(); bookFound = 1; bookIcon.GetComponent<Image>().color = newColor;  }
        else if (guitarFOund != 1) { GuitarBonus(); guitarFOund = 1; guitarIcon.GetComponent<Image>().color = newColor;  }
        else if (talarianFound != 1) { TalarianBonus(); talarianFound = 1; talarianIcon.GetComponent<Image>().color = newColor;  }
        else if (runeFound != 1) { RuneBonus(); runeFound = 1; runeIcon.GetComponent<Image>().color = newColor;  }
        else if (backPackFound != 1) { BackPackBonus(); backPackFound = 1; backPackIcon.GetComponent<Image>().color = newColor;  }
        else if (shieldFound != 1) { ShieldBonus(); shieldFound = 1; shieldIcon.GetComponent<Image>().color = newColor;  }
        else if (pillBottleFound != 1) { PillBottleBonus(); pillBottleFound = 1; pillBottleIcon.GetComponent<Image>().color = newColor; }
        else if (medalFound != 1) { MedaLBonus(); medalFound = 1; medalIcon.GetComponent<Image>().color = newColor;  }
        else if (cookieFound != 1) { CookieBonus(); cookieFound = 1; cookieIcon.GetComponent<Image>().color = newColor;  }

        else if (presentFound != 1) { PresentBonus(); presentFound = 1; presentIcon.GetComponent<Image>().color = newColor; }
        else if (axeFound != 1) { AxeBonus(); axeFound = 1; axeIcon.GetComponent<Image>().color = newColor;  }
        else if (coin100XFound != 1) { Coin100XBonus(); coin100XFound = 1; coin100XIcon.GetComponent<Image>().color = newColor;  }
        else if (envelopeFound != 1) { EnvelopeBonus(); envelopeFound = 1; envelopeIcon.GetComponent<Image>().color = newColor;  }
        else if (potionFound != 1) { PotionBonus(); potionFound = 1; potionIcon.GetComponent<Image>().color = newColor;  }
        else if (soulGemFound != 1) { SoulGemBonus(); soulGemFound = 1; soulGemIcon.GetComponent<Image>().color = newColor;  }
        else if (scrollFound != 1) { ScrollBonus(); scrollFound = 1; scrollIcon.GetComponent<Image>().color = newColor;  }
        else if (brickFound != 1) { BrickBonus(); brickFound = 1; brickIcon.GetComponent<Image>().color = newColor;  }
        else if (chickenFound != 1) { ChickenBonus(); chickenFound = 1; chickenIcon.GetComponent<Image>().color = newColor;  }

        if (AudioManager.audioMuted == 1)
        {
            int random = Random.Range(1, 3);
            if (random == 1) { audioManager.Play("RareTreasureSound1"); }
            if (random == 2) { audioManager.Play("RareTreasureSound2"); }
        }

        Stats.rareTreasuresFound += 1;

        CheckAllTreasureFound();
    }

    public void AudioSound()
    {
        if (AudioManager.audioMuted == 1)
        {
            int random = Random.Range(1, 3);
            if (random == 1) { audioManager.Play("RareTreasureSound1"); }
            if (random == 2) { audioManager.Play("RareTreasureSound2"); }
        }
    }


    private void SetTextProperties(TextMeshProUGUI text, string newText)
    {
        text.text = newText;

        // Set alpha to 100% (1.0f)
        Color currentColor = text.color;
        currentColor.a = 1.0f;
        text.color = currentColor;

        text.color = new Color(200f, 200f, 200f); 
    }

    private void SetTextPropertiesBack(TextMeshProUGUI text, string newText)
    {
        text.text = newText;

        // Set alpha to 100% (1.0f)
        Color currentColor = text.color;
        currentColor.a = 1.0f;
        text.color = currentColor;

        text.color = new Color(0.376f, 0.376f, 0.376f);
    }

    private void ChangeAlpha(GameObject targetObject, Color color, float alphaValue)
    {
        Image imageComponent = targetObject.GetComponent<Image>();

        if (imageComponent != null)
        {
            color.a = alphaValue;
            imageComponent.color = color;
        }
        else
        {
            Debug.LogWarning("No Image component found on the target GameObject.");
        }
    }

    public void ResetRareTreasures()
    {
        SetTextPropertiesBack(skullText, "?????"); skullText.fontSize = 36;
        SetTextPropertiesBack(swordText, "?????"); swordText.fontSize = 36;
        SetTextPropertiesBack(ringText, "?????");  ringText.fontSize = 36;
        SetTextPropertiesBack(trophyText, "?????");  trophyText.fontSize = 36;
        SetTextPropertiesBack(starText, "?????");  starText.fontSize = 36;
        SetTextPropertiesBack(crownText, "?????");  crownText.fontSize = 36;
        SetTextPropertiesBack(cloverText, "?????"); cloverText.fontSize = 36;
        SetTextPropertiesBack(bookText, "?????");  bookText.fontSize = 36;
        SetTextPropertiesBack(guitarText, "?????");  guitarText.fontSize = 36;
        SetTextPropertiesBack(talarianText, "?????");  talarianText.fontSize = 36;
        SetTextPropertiesBack(runeText, "?????");  runeText.fontSize = 36;
        SetTextPropertiesBack(backPackText, "?????"); backPackText.fontSize = 36;
        SetTextPropertiesBack(shieldText, "?????");shieldText.fontSize = 36;
        SetTextPropertiesBack(pillBottleText, "?????");  pillBottleText.fontSize = 36;
        SetTextPropertiesBack(medalText, "?????");medalText.fontSize = 36;
        SetTextPropertiesBack(cookieText, "?????"); cookieText.fontSize = 36;

        SetTextPropertiesBack(presentText, "?????");  presentText.fontSize = 36;
        SetTextPropertiesBack(axeText, "?????");  axeText.fontSize = 36;
        SetTextPropertiesBack(coin100XText, "?????");  coin100XText.fontSize = 36;
        SetTextPropertiesBack(envelopeText, "?????"); envelopeText.fontSize = 36;
        SetTextPropertiesBack(potionText, "?????"); potionText.fontSize = 36;
        SetTextPropertiesBack(soulGemText, "?????");  soulGemText.fontSize = 36;
        SetTextPropertiesBack(scrollText, "?????");  scrollText.fontSize = 36;
        SetTextPropertiesBack(brickText, "?????");  brickText.fontSize = 36;
        SetTextPropertiesBack(chickenText, "?????");  chickenText.fontSize = 36;

        skullIcon.GetComponent<Image>().color = blackColor; ChangeAlpha(skullIcon, blackColor, 0.5f);
        swordIcon.GetComponent<Image>().color = blackColor; ChangeAlpha(swordIcon, blackColor, 0.5f);
        ringIcon.GetComponent<Image>().color = blackColor; ChangeAlpha(ringIcon, blackColor, 0.5f);
        trophyIcon.GetComponent<Image>().color = blackColor; ChangeAlpha(trophyIcon, blackColor, 0.5f);
        starIcon.GetComponent<Image>().color = blackColor; ChangeAlpha(starIcon, blackColor, 0.5f);
        cloverIcon.GetComponent<Image>().color = blackColor; ChangeAlpha(cloverIcon, blackColor, 0.5f);
        crownIcon.GetComponent<Image>().color = blackColor; ChangeAlpha(crownIcon, blackColor, 0.5f);
        bookIcon.GetComponent<Image>().color = blackColor; ChangeAlpha(bookIcon, blackColor, 0.5f);
        guitarIcon.GetComponent<Image>().color = blackColor; ChangeAlpha(guitarIcon, blackColor, 0.5f);
        talarianIcon.GetComponent<Image>().color = blackColor; ChangeAlpha(talarianIcon, blackColor, 0.5f);
        runeIcon.GetComponent<Image>().color = blackColor; ChangeAlpha(runeIcon, blackColor, 0.5f);
        backPackIcon.GetComponent<Image>().color = blackColor; ChangeAlpha(backPackIcon, blackColor, 0.5f);
        shieldIcon.GetComponent<Image>().color = blackColor; ChangeAlpha(shieldIcon, blackColor, 0.5f);
        pillBottleIcon.GetComponent<Image>().color = blackColor; ChangeAlpha(pillBottleIcon, blackColor, 0.5f);
        medalIcon.GetComponent<Image>().color = blackColor; ChangeAlpha(medalIcon, blackColor, 0.5f);
        cookieIcon.GetComponent<Image>().color = blackColor; ChangeAlpha(cookieIcon, blackColor, 0.5f);

        presentIcon.GetComponent<Image>().color = blackColor; ChangeAlpha(presentIcon, blackColor, 0.5f);
        axeIcon.GetComponent<Image>().color = blackColor; ChangeAlpha(axeIcon, blackColor, 0.5f);
        coin100XIcon.GetComponent<Image>().color = blackColor; ChangeAlpha(coin100XIcon, blackColor, 0.5f);
        envelopeIcon.GetComponent<Image>().color = blackColor; ChangeAlpha(envelopeIcon, blackColor, 0.5f);
        potionIcon.GetComponent<Image>().color = blackColor; ChangeAlpha(potionIcon, blackColor, 0.5f);
        soulGemIcon.GetComponent<Image>().color = blackColor; ChangeAlpha(soulGemIcon, blackColor, 0.5f);
        scrollIcon.GetComponent<Image>().color = blackColor; ChangeAlpha(scrollIcon, blackColor, 0.5f);
        brickIcon.GetComponent<Image>().color = blackColor; ChangeAlpha(brickIcon, blackColor, 0.5f);
        chickenIcon.GetComponent<Image>().color = blackColor; ChangeAlpha(chickenIcon, blackColor, 0.5f);

        #region foundOrNotFoundHover
        skullNotFoundHover.SetActive(true); skullFoundHover.SetActive(false); 

        swordNotFoundHover.SetActive(true); swordFoundHover.SetActive(false); 

        ringNotFoundHover.SetActive(true); ringFoundHover.SetActive(false); 

        trophyNotFoundHover.SetActive(true); trophyFoundHover.SetActive(false); 

        starNotFoundHover.SetActive(true); starFoundHover.SetActive(false); 

        cloverNotFoundHover.SetActive(true); cloverFoundHover.SetActive(false); 

        crownNotFoundHover.SetActive(true); crownFoundHover.SetActive(false); 

        bookNotFoundHover.SetActive(true); bookFoundHover.SetActive(false); 

        guitarNotFOundHover.SetActive(true); guitarFOundHover.SetActive(false); 

        talarianNotFoundHover.SetActive(true); talarianFoundHover.SetActive(false); 

       runeNotFoundHover.SetActive(true); runeFoundHover.SetActive(false); 

         backPackNotFoundHover.SetActive(true); backPackFoundHover.SetActive(false); 

       shieldFoundNotHover.SetActive(true); shieldFoundHover.SetActive(false); 

        pillBottleFoundNotHover.SetActive(true); pillBottleFoundHover.SetActive(false); 

        medalNotFoundHover.SetActive(true); medalFoundHover.SetActive(false); 

        cookieNotFoundHover.SetActive(true); cookieFoundHover.SetActive(false);


        presentNotFoundHover.SetActive(true); presentFoundHover.SetActive(false);

        axeNotFoundHover.SetActive(true); axeFoundHover.SetActive(false);

        coin100XNotFoundHover.SetActive(true); coin100XFoundHover.SetActive(false);

        envelopeNotFoundHover.SetActive(true); envelopeFoundHover.SetActive(false);

        potionNotFoundHover.SetActive(true); potionFoundHover.SetActive(false);

        soulGemNotFoundHover.SetActive(true); soulGemFoundHover.SetActive(false);

        scrollNotFoundHover.SetActive(true); scrollFoundHover.SetActive(false);

        brickNotFoundHover.SetActive(true); brickFoundHover.SetActive(false);

        chickenNotFoundHover.SetActive(true); chickenGoundHover.SetActive(false);
        #endregion
    }

   
}
