using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Threading.Tasks;
public class SelectChests : MonoBehaviour
{
    public static bool notUnlockedChest;

    public GameObject chest1, chest2, chest3, chest4, chest5, chest6, chest7, chest8, chest9, chest10;
    public GameObject chest11, chest12, chest13, chest14, chest15, chest16, chest17, chest18, chest19, chest20;
    public GameObject chest21, chest22, chest23, chest24, chest25, chest26, chest27, chest28, chest29, chest30, chest31, chest32, chest33, chest34, chest35, chest36, chest37, chest38, chest39, chest40;

    public GameObject arrowNextChest1, arrowNextChest2, arrowNextChest3, arrowNextChest4, arrowNextChest5, arrowNextChest6;
    public GameObject arrowNextChest7, arrowNextChest8, arrowNextChest9, arrowNextChest10, arrowNextChest11, arrowNextChest12, arrowNextChest13, arrowNextChest14, arrowNextChest15, arrowNextChest16, arrowNextChest17, arrowNextChest18, arrowNextChest19, arrowNextChest20, arrowNextChest21, arrowNextChest22, arrowNextChest23, arrowNextChest24, arrowNextChest25, arrowNextChest26, arrowNextChest27, arrowNextChest28, arrowNextChest29, arrowNextChest30, arrowNextChest31, arrowNextChest32, arrowNextChest33, arrowNextChest34, arrowNextChest35, arrowNextChest36, arrowNextChest37, arrowNextChest38, arrowNextChest39;

    public GameObject arrowBackChest2, arrowBackChest3, arrowBackChest4, arrowBackChest5, arrowBackChest6, arrowBackChest7;
    public GameObject arrowBackChest8, arrowBackChest9, arrowBackChest10, arrowBackChest11, arrowBackChest12, arrowBackChest13, arrowBackChest14, arrowBackChest15, arrowBackChest16, arrowBackChest17, arrowBackChest18, arrowBackChest19, arrowBackChest20, arrowBackChest21, arrowBackChest22, arrowBackChest23, arrowBackChest24, arrowBackChest25, arrowBackChest26, arrowBackChest27, arrowBackChest28, arrowBackChest29, arrowBackChest30, arrowBackChest31, arrowBackChest32, arrowBackChest33, arrowBackChest34, arrowBackChest35, arrowBackChest36, arrowBackChest37, arrowBackChest38, arrowBackChest39, arrowBackChest40;

    public static double ChestHealth;
    public static double randomMinGold, randomMaxGold;
    public static double randomMinGoldDouble, randomMaxGoldDouble;

    public GameObject redRuby, amethyst, diamond, violetCrystal, yellowSapphire, greenDiamond, grandidierite, purpleRupee, pinkPlort, emerald, quartz, redGarnet, pinkTourmaline, yellowTopaz, aquamarine, fireOpal, goldenSeaPearl, akoyaPearl, gemSilica, adventurine, kyanite, albite, blackOpal, painite, tanzanite, astralium, elysiumPrism, aerthfireOpal, eldrichStarstone, chronolithShard, sideriumEssence, quasarite, riadiantNovaStone, soluniumShard;



    public static bool chest1Active, chest2Active, chest3Active, chest4Active, chest5Active, chest6Active, chest7Active, chest8Active, chest9Active, chest10Active, chest11Active, chest12Active, chest13Active, chest14Active, chest15Active, chest16Active, chest17Active, chest18Active, chest19Active, chest20Active, chest21Active, chest22Active, chest23Active, chest24Active, chest25Active, chest26Active, chest27Active, chest28Active, chest29Active, chest30Active, chest31Active, chest32Active, chest33Active, chest34Active, chest35Active, chest36Active, chest37Active, chest38Active, chest39Active, chest40Active;

    public TextMeshProUGUI chestName, chestGoldDropInfo, chestXPDropInfo, chestGoldCoinsText;

    public GameObject lockedChest;
    public static double chestPrice;
    public TextMeshProUGUI chestPriceText;

    public Vector3 yPos39, yPos51, yPos58, yPos40, yPos48,yPos32, yPos50,yPos64, yPos71, yPos60, yPos55, yPos87, yPos75;
    public Vector3 scale46, scale283, scale279, scale54, scale30, scale61, scale29, scale327, scale281, scale276, scale322, scale325, scale5;

    public int async;
    public float arrowSize;

    public static float reinforcedChestChance;
    public TextMeshProUGUI reinforcedChestChanceText;

    public static bool chest1Wait, chest2Wait, chest3Wait, chest4Wait, chest5Wait, chest6Wait, chest7Wait, chest8Wait, chest9Wait, chest10Wait, chest11Wait, chest12Wait, chest13Wait, chest14Wait, chest15Wait, chest16Wait, chest17Wait, chest18Wait, chest19Wait, chest20Wait, chest21Wait, chest22Wait, chest23Wait, chest24Wait, chest25Wait, chest26Wait, chest27Wait, chest28Wait, chest29Wait, chest30Wait, chest31Wait, chest32Wait, chest33Wait, chest34Wait, chest35Wait, chest36Wait, chest37Wait, chest38Wait, chest39Wait, chest40Wait;

    public void Start()
    {

        isAutoPurchaseOn = false;
        clickChestOnce = true;
        arrowSize = 0.7681164f;
        async = 0;
        lockedChest.SetActive(false);
        StartCoroutine(StartChest());
        yPos39 = chest1.transform.localPosition;
        scale46 = chest1.transform.localScale;

        yPos51 = chest2.transform.localPosition;
        scale283 = chest2.transform.localScale;

        yPos58 = chest3.transform.localPosition;
        scale279 = chest3.transform.localScale;

        yPos40 = chest7.transform.localPosition;
        scale54 = chest7.transform.localScale;

        yPos48 = chest8.transform.localPosition;
        scale30 = chest8.transform.localScale;

        yPos32 = chest10.transform.localPosition;
        scale61 = chest10.transform.localScale;

        yPos50 = chest11.transform.localPosition;
        scale29 = chest11.transform.localScale;

        scale327 = chest12.transform.localScale;

        yPos64 = chest13.transform.localPosition;

        yPos71 = chest14.transform.localPosition;
        scale281 = chest14.transform.localScale;

        yPos60 = chest19.transform.localPosition;

        scale276 = chest23.transform.localScale;

        yPos55 = chest26.transform.localPosition;
        scale322 = chest26.transform.localScale;

        scale325 = chest27.transform.localScale;

        yPos87 = chest34.transform.localPosition;

        yPos75 = chest37.transform.localPosition;
        scale5 = chest37.transform.localScale;

        chestWait = 0.3f; chestWait2 = 1f;


        chest1Wait = false; chest2Wait = false; chest3Wait = false; chest4Wait = false; chest5Wait = false; chest6Wait = false; chest7Wait = false; chest8Wait = false; chest9Wait = false; chest10Wait = false; chest11Wait = false; chest12Wait = false; chest13Wait = false; chest14Wait = false; chest15Wait = false; chest16Wait = false; chest17Wait = false; chest18Wait = false; chest19Wait = false; chest20Wait = false; chest21Wait = false; chest22Wait = false; chest23Wait = false; chest24Wait = false; chest25Wait = false; chest26Wait = false; chest27Wait = false; chest28Wait = false; chest29Wait = false; chest30Wait = false; chest31Wait = false; chest32Wait = false; chest33Wait = false; chest34Wait = false; chest35Wait = false; chest36Wait = false; chest37Wait = false; chest38Wait = false; chest39Wait = false; chest40Wait = false;
    }

  
    IEnumerator StartChest()
    {
        yield return new WaitForSeconds(0.35f);

        if (UnlockChests.timesPurchasedChests > 38) { clickArrowNextChest39(); }
        else if (UnlockChests.timesPurchasedChests > 37) { clickArrowNextChest38(); }
        else if (UnlockChests.timesPurchasedChests > 36) { clickArrowNextChest37(); }
        else if (UnlockChests.timesPurchasedChests > 35) { clickArrowNextChest36(); }
        else if (UnlockChests.timesPurchasedChests > 34) { clickArrowNextChest35(); }
        else if (UnlockChests.timesPurchasedChests > 33) { clickArrowNextChest34(); }
        else if (UnlockChests.timesPurchasedChests > 32) { clickArrowNextChest33(); }
        else if (UnlockChests.timesPurchasedChests > 31) { clickArrowNextChest32(); }
        else if (UnlockChests.timesPurchasedChests > 30) { clickArrowNextChest31(); }
        else if (UnlockChests.timesPurchasedChests > 29) { clickArrowNextChest30(); }
        else if (UnlockChests.timesPurchasedChests > 28) { clickArrowNextChest29(); }
        else if (UnlockChests.timesPurchasedChests > 27) { clickArrowNextChest28(); }
        else if (UnlockChests.timesPurchasedChests > 26) { clickArrowNextChest27(); }
        else if (UnlockChests.boughtChest27 == 1) { clickArrowNextChest26(); }
        else if (UnlockChests.boughtChest26 == 1) { clickArrowNextChest25(); }
        else if (UnlockChests.boughtChest25 == 1) { clickArrowNextChest24(); }
        else if (UnlockChests.boughtChest24 == 1) { clickArrowNextChest23(); }
        else if (UnlockChests.boughtChest23 == 1) { clickArrowNextChest22(); }
        else if (UnlockChests.boughtChest22 == 1) { clickArrowNextChest21(); }
        else if (UnlockChests.boughtChest21 == 1) { clickArrowNextChest20(); }
        else if (UnlockChests.boughtChest20 == 1) { clickArrowNextChest19(); }
        else if (UnlockChests.boughtChest19 == 1) { clickArrowNextChest18(); }
        else if (UnlockChests.boughtChest18 == 1) { clickArrowNextChest17(); }
        else if (UnlockChests.boughtChest17 == 1) { clickArrowNextChest16(); }
        else if (UnlockChests.boughtChest16 == 1) { clickArrowNextChest15(); }
        else if (UnlockChests.boughtChest15 == 1) { clickArrowNextChest14(); }
        else if (UnlockChests.boughtChest14 == 1) { clickArrowNextChest13(); }
        else if (UnlockChests.boughtChest13 == 1) { clickArrowNextChest12(); }
        else if (UnlockChests.boughtChest12 == 1) { clickArrowNextChest11(); }
        else if (UnlockChests.boughtChest11 == 1) { clickArrowNextChest10(); }
        else if (UnlockChests.boughtChest10 == 1) { clickArrowNextChest9(); }
        else if (UnlockChests.boughtChest9 == 1) { clickArrowNextChest8(); }
        else if (UnlockChests.boughtChest8 == 1) { clickArrowNextChest7(); }
        else if (UnlockChests.boughtChest7 == 1) { clickArrowNextChest6(); }
        else if (UnlockChests.boughtChest6 == 1) { clickArrowNextChest5(); }
        else if (UnlockChests.boughtChest5 == 1) { clickArrowNextChest4(); }
        else if (UnlockChests.boughtChest4 == 1) { clickArrowNextChest3(); }
        else if (UnlockChests.boughtChest3 == 1) { clickArrowNextChest2(); }
        else if (UnlockChests.boughtChest2 == 1) { clickArrowNextChest1(); }
        else if (UnlockChests.boughtChest2 != 1) { clickArrowBackChest2(); }

        changeColor();
    }

    public string newHexValue = "#FFFFFF";
    public string blackColor = "#050505";
    public static bool changedColor;
    public bool changeChest;

    public GameObject autoChestPurchaseOffIcon;
    public static bool isAutoPurchaseOn;
    public Button purchaseChest;
    public TextMeshProUGUI onOffText;

    public void autoChestPurchase()
    {
        if(PlaceMobileButtons.isMobile == true) { return; }

        if (autoChestPurchaseOffIcon.activeInHierarchy == true) { autoChestPurchaseOffIcon.SetActive(false); isAutoPurchaseOn = true;
            onOffText.text = Localization.ON; onOffText.color = Color.green;
        }
        else if (autoChestPurchaseOffIcon.activeInHierarchy == false) { autoChestPurchaseOffIcon.SetActive(true); isAutoPurchaseOn = false;
            onOffText.text = Localization.OFF; onOffText.color = Color.red;
        }
    }

    public void AutoChest(bool off)
    {
        if (off == false)
        {
            if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("UIClick1"); }
            autoChestPurchaseOffIcon.SetActive(false); isAutoPurchaseOn = true;
            onOffText.text = Localization.ON; onOffText.color = Color.green;
        }
        else if (off == true)
        {
            if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("UIClick1"); }
            autoChestPurchaseOffIcon.SetActive(true); isAutoPurchaseOn = false;
            onOffText.text = Localization.OFF; onOffText.color = Color.red;
        }
    }

    public void turnOffAutoPurchase()
    {
        autoChestPurchaseOffIcon.SetActive(true); isAutoPurchaseOn = false;
        onOffText.text = Localization.OFF; onOffText.color = Color.red;
    }

    IEnumerator PurchaseChest()
    {
        yield return new WaitForSeconds(0.07f);
        purchaseChest.onClick.Invoke();
        clickChestOnce = true;
    }
    public bool clickChestOnce;

    public void Update()
    {
        if(isAutoPurchaseOn == true && clickChestOnce == true)
        {
            if(UnlockChests.timesPurchasedChests == 0 && UpdateGame.totalGoldHigher > chest2Price) { clickArrowNextChest1(); StartCoroutine(PurchaseChest()); clickChestOnce = false; 
            }
            if (UnlockChests.timesPurchasedChests == 1 && UpdateGame.totalGoldHigher > chest3Price)
            {
                clickArrowNextChest2(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 2 && UpdateGame.totalGoldHigher > chest4Price)
            {
                clickArrowNextChest3(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 3 && UpdateGame.totalGoldHigher > chest5Price)
            {
                clickArrowNextChest4(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 4 && UpdateGame.totalGoldHigher > chest6Price)
            {
                clickArrowNextChest5(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 5 && UpdateGame.totalGoldHigher > chest7Price)
            {
                clickArrowNextChest6(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 6 && UpdateGame.totalGoldHigher > chest8Price)
            {
                clickArrowNextChest7(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 7 && UpdateGame.totalGoldHigher > chest9Price)
            {
                clickArrowNextChest8(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 8 && UpdateGame.totalGoldHigher > chest10Price)
            {
                clickArrowNextChest9(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 9 && UpdateGame.totalGoldHigher > chest11Price)
            {
                clickArrowNextChest10(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 10 && UpdateGame.totalGoldHigher > chest12Price)
            {
                clickArrowNextChest11(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 11 && UpdateGame.totalGoldHigher > chest13Price)
            {
                clickArrowNextChest12(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 12 && UpdateGame.totalGoldHigher > chest14Price)
            {
                clickArrowNextChest13(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 13 && UpdateGame.totalGoldHigher > chest15Price)
            {
                clickArrowNextChest14(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 14 && UpdateGame.totalGoldHigher > chest16Price)
            {
                clickArrowNextChest15(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 15 && UpdateGame.totalGoldHigher > chest17Price)
            {
                clickArrowNextChest16(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 16 && UpdateGame.totalGoldHigher > chest18Price)
            {
                clickArrowNextChest17(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 17 && UpdateGame.totalGoldHigher > chest19Price)
            {
                clickArrowNextChest18(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 18 && UpdateGame.totalGoldHigher > chest20Price)
            {
                clickArrowNextChest19(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 19 && UpdateGame.totalGoldHigher > chest21Price)
            {
                clickArrowNextChest20(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 20 && UpdateGame.totalGoldHigher > chest22Price)
            {
                clickArrowNextChest21(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 21 && UpdateGame.totalGoldHigher > chest23Price)
            {
                clickArrowNextChest22(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 22 && UpdateGame.totalGoldHigher > chest24Price)
            {
                clickArrowNextChest23(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 23 && UpdateGame.totalGoldHigher > chest25Price)
            {
                clickArrowNextChest24(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 24 && UpdateGame.totalGoldHigher > chest26Price)
            {
                clickArrowNextChest25(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 25 && UpdateGame.totalGoldHigher > chest27Price)
            {
                clickArrowNextChest26(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 26 && UpdateGame.totalGoldHigher > chest28Price)
            {
                clickArrowNextChest27(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 27 && UpdateGame.totalGoldHigher > chest29Price)
            {
                clickArrowNextChest28(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 28 && UpdateGame.totalGoldHigher > chest30Price)
            {
                clickArrowNextChest29(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 29 && UpdateGame.totalGoldHigher > chest31Price)
            {
                clickArrowNextChest30(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 30 && UpdateGame.totalGoldHigher > chest32Price)
            {
                clickArrowNextChest31(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 31 && UpdateGame.totalGoldHigher > chest33Price)
            {
                clickArrowNextChest32(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 32 && UpdateGame.totalGoldHigher > chest34Price)
            {
                clickArrowNextChest33(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 33 && UpdateGame.totalGoldHigher > chest35Price)
            {
                clickArrowNextChest34(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 34 && UpdateGame.totalGoldHigher > chest36Price)
            {
                clickArrowNextChest35(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 35 && UpdateGame.totalGoldHigher > chest37Price)
            {
                clickArrowNextChest36(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 36 && UpdateGame.totalGoldHigher > chest38Price)
            {
                clickArrowNextChest37(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 37 && UpdateGame.totalGoldHigher > chest39Price)
            {
                clickArrowNextChest38(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }
            if (UnlockChests.timesPurchasedChests == 38 && UpdateGame.totalGoldHigher > chest40Price)
            {
                clickArrowNextChest39(); StartCoroutine(PurchaseChest()); clickChestOnce = false;
            }

        }

        #region treasure color
        if (RareDropsCollected.RedGemCount == 1 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.amethystCount == 1 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.diamondCount == 1 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.violetCrystalCount == 1 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.yellowSapphireCount == 1 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.greenDiamondCount == 1 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.grandidieriteCount == 1 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.purpleRupeeCount == 1 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.pinkPlostCount == 1 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.emeraldCount == 1 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.quartzCount == 1 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.redGarnetCount == 1 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.pinkTourmalineCount == 1 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.yellowTopazCount == 1 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.aquamarineCount == 1 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.fireOpalCount == 1 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.goldeSeaPearlCount == 1 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.akoyaPearlCount == 1 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.gemSilicaCount == 1 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.AdventurineCount == 1 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.kyaniteCount == 1 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.albiteCount == 1 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.blackOpalCount == 1 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.painiteCount == 1 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.TanzaniteCount == 1 && changedColor == true) { changeColor(); changedColor = false; }

        if (RareDropsCollected.astraliumCount == 1 || RareDropsCollected.astraliumCount == 2 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.elysiumPrismCount == 1 || RareDropsCollected.elysiumPrismCount == 2 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.aetherfireOpalCount == 1 || RareDropsCollected.aetherfireOpalCount == 2 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.eldritchStarstoneCount == 1 || RareDropsCollected.eldritchStarstoneCount == 2 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.chronolithShardCount == 1 || RareDropsCollected.chronolithShardCount == 2 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.sideriumEssenceCount == 1 || RareDropsCollected.sideriumEssenceCount == 2 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.quasariteCount == 1 || RareDropsCollected.quasariteCount == 2 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.radiantNovaStoneCount == 1 || RareDropsCollected.radiantNovaStoneCount == 2 && changedColor == true) { changeColor(); changedColor = false; }
        if (RareDropsCollected.soluniumShardCount == 1 || RareDropsCollected.soluniumShardCount == 2 && changedColor == true) { changeColor(); changedColor = false; }
        #endregion

        if (chest1.activeInHierarchy)
        {
            DeactivateAllExcept(chest1);
        }
        if (chest2.activeInHierarchy)
        {
            DeactivateAllExcept(chest2);
        }
        if (chest3.activeInHierarchy)
        {
            DeactivateAllExcept(chest3);
        }


        if(RareTreasures.chanceChange == true)
        {
            CurrentReinforcedChance();
            RareTreasures.chanceChange = false;
        }

    }


    void DeactivateAllExcept(GameObject activeChest)
    {
        foreach (Transform child in transform)
        {
            if (child.gameObject != activeChest)
            {
                child.gameObject.SetActive(false);
            }
        }
    }

    public float chestWait, chestWait2;


    public void ChangeColor(Image image, string hexadecimalColor)
    {
        // Convert the hexadecimal color to Unity's Color type
        Color color = HexToColor(hexadecimalColor);

        // Set the color of the Image component
        image.color = color;
    }

    private Color HexToColor(string hexadecimalColor)
    {
        // Remove the '#' character if present
        if (hexadecimalColor.StartsWith("#"))
            hexadecimalColor = hexadecimalColor.Substring(1);

        // Parse the hexadecimal color
        Color color;
        ColorUtility.TryParseHtmlString("#" + hexadecimalColor, out color);

        return color;
    }

    public Image backgroundImage;
    public string normalHexValue = "FFFFFF";
    public string chest3HexValue = "FFFFFF";

    public static bool chestNotUnlocked;

    #region chest1Next
    public async void clickArrowNextChest1()
    {
        Chest2Price();
        ChangeColor(backgroundImage, normalHexValue);

        await Task.Delay(async);
        SetAllGemsInactive();
        //SetChest2Info();
        SetEverythingElseFalse();
        chest2.SetActive(true);
        arrowBackChest2.SetActive(true);
        if(UnlockChests.boughtChest2 == 1) { lockedChest.SetActive(false); arrowNextChest2.SetActive(true); chest2Wait = true;
            Invoke("waitChests2", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.boughtChest2 != 1) { lockedChest.SetActive(true); arrowNextChest2.SetActive(false);
            notUnlockedChest = true; Invoke("SetChest2", chestWait);
        }

        chest2Active = true;
        chest1Active = false;
        chest1.SetActive(false);

        if (UnlockChests.boughtChest2 != 1) { chestNotUnlocked = true; }
        if (UnlockChests.boughtChest2 == 1) { chestNotUnlocked = false; }

    }

    public void waitChests()
    {
        chest1Wait = false;
    }

    public void SetChest1()
    {
        SetChest1Info();
    }
    #endregion

    #region chest2NextBack
    public async void clickArrowBackChest2()
    {
        ChangeColor(backgroundImage, normalHexValue);
        await Task.Delay(async);
        SetAllGemsInactive();
        SetChest1Info();
        SetEverythingElseFalse();
        chest1.SetActive(true);
        arrowNextChest1.SetActive(true);
        notUnlockedChest = false;
        lockedChest.SetActive(false);

        chest1Active = true;
        chest2Active = false;
        chest2.SetActive(false);

        chest1Wait = true;
        Invoke("waitChests", chestWait);
        Invoke("SetChest1", chestWait);

        chestNotUnlocked = false;

    }

    public void waitChests2()
    {
        chest2Wait = false;
        SetChest2Info();
    }
    public void SetChest2()
    {
        SetChest2Info();
    }


    public async  void clickArrowNextChest2()
    {
        Chest3Price();
        ChangeColor(backgroundImage, chest3HexValue);
        await Task.Delay(async);
        SetAllGemsInactive();
        //SetChest3Info();
        SetEverythingElseFalse();
        chest3.SetActive(true);
        arrowBackChest3.SetActive(true);
        
        if (UnlockChests.boughtChest3 == 1) { lockedChest.SetActive(false); arrowNextChest3.SetActive(true); chest3Wait = true;
            Invoke("waitChests3", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.boughtChest3 != 1) { lockedChest.SetActive(true); arrowNextChest3.SetActive(false);
            notUnlockedChest = true; Invoke("SetChest3", chestWait);
        }

        //await Task.Delay(async);
        chest3Active = true;
        chest2Active = false;
        chest2.SetActive(false);

        if (UnlockChests.boughtChest3 != 1) { chestNotUnlocked = true; }
        if (UnlockChests.boughtChest3 == 1) { chestNotUnlocked = false; }

    }
    #endregion

    #region chest3NextBack
    public async void clickArrowBackChest3()
    {
        Chest2Price();
        ChangeColor(backgroundImage, normalHexValue);
        await Task.Delay(async);
        SetAllGemsInactive();
        SetChest2Info();
        SetEverythingElseFalse();
        chest2.SetActive(true);
        arrowNextChest2.SetActive(true);
        arrowBackChest2.SetActive(true);
        
        notUnlockedChest = false;
        lockedChest.SetActive(false);

        //await Task.Delay(async);
        chest2Active = true;
        chest3Active = false;
        chest3.SetActive(false);

        chest2Wait = true;
        Invoke("waitChests2", chestWait);

        //HealthBar.autoClickerOn = true;
        chestNotUnlocked = false;

    }

    public void waitChests3()
    {
        chest3Wait = false;
        SetChest3Info();
    }

    public void SetChest3()
    {
        SetChest3Info();
    }

    public  async void clickArrowNextChest3()
    {
        Chest4Price();
        await Task.Delay(async);
        SetAllGemsInactive();
        //SetChest4Info();
        SetEverythingElseFalse();
        chest4.SetActive(true);
        arrowBackChest4.SetActive(true);
        
        if (UnlockChests.boughtChest4 == 1) { lockedChest.SetActive(false); arrowNextChest4.SetActive(true); chest4Wait = true;
            Invoke("waitChests4", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.boughtChest4 != 1) { lockedChest.SetActive(true); arrowNextChest4.SetActive(false); notUnlockedChest = true; Invoke("SetChest4", chestWait); }

        //await Task.Delay(async);
        chest4Active = true;
        chest3Active = false;
        chest3.SetActive(false);

        if (UnlockChests.boughtChest4 != 1) { chestNotUnlocked = true; }
        if (UnlockChests.boughtChest4 == 1) { chestNotUnlocked = false; }
    }
    #endregion

    #region chest4NextBack
    public async void clickArrowBackChest4()
    {
        Chest3Price();
        SetAllGemsInactive();
        SetChest3Info();
        SetEverythingElseFalse();
        chest3.SetActive(true);
        arrowNextChest3.SetActive(true);
        arrowBackChest3.SetActive(true);
        
        notUnlockedChest = false;
        lockedChest.SetActive(false);

        await Task.Delay(async);
        chest3Active = true;
        chest4Active = false;
        chest4.SetActive(false);

        chest3Wait = true;
        Invoke("waitChests3", chestWait);

        //HealthBar.autoClickerOn = true;
        chestNotUnlocked = false;
    }

    public void waitChests4()
    {
        SetChest4Info();
        chest4Wait = false;
    }
    public void SetChest4()
    {
        SetChest4Info();
    }

    public async void clickArrowNextChest4()
    {
        Chest5Price();
        SetAllGemsInactive();
        //SetChest5Info();
        SetEverythingElseFalse();
        chest5.SetActive(true);
        arrowBackChest5.SetActive(true);
        
        if (UnlockChests.boughtChest5 == 1) { lockedChest.SetActive(false); arrowNextChest5.SetActive(true); chest5Wait = true;
            Invoke("waitChests5", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.boughtChest5 != 1) { lockedChest.SetActive(true); notUnlockedChest = true; arrowNextChest5.SetActive(false);
            Invoke("SetChest5", chestWait);
        }

        await Task.Delay(async);
        chest5Active = true;
        chest4Active = false;
        chest4.SetActive(false);

        if (UnlockChests.boughtChest5 != 1) { chestNotUnlocked = true; }
        if (UnlockChests.boughtChest5 == 1) { chestNotUnlocked = false; }
    }
    #endregion

    #region chest5NextBack
    public async void clickArrowBackChest5()
    {
        Chest4Price();
        SetAllGemsInactive();
        SetChest4Info();
        SetEverythingElseFalse();
        chest4.SetActive(true);
        arrowNextChest4.SetActive(true);
        arrowBackChest4.SetActive(true);
        notUnlockedChest = false;
        lockedChest.SetActive(false);

        await Task.Delay(async);
        chest4Active = true;
        chest5Active = false;
        chest5.SetActive(false);

        chest4Wait = true;
        Invoke("waitChests4", chestWait);
        chestNotUnlocked = false;
    }

    public void waitChests5()
    {
        SetChest5Info();
        chest5Wait = false;
    }
    public void SetChest5()
    {
        SetChest5Info();
    }
    public async void clickArrowNextChest5()
    {
        Chest6Price();
        SetAllGemsInactive();
        //SetChest6Info();
        SetEverythingElseFalse();
        chest6.SetActive(true);
        arrowBackChest6.SetActive(true);
        if (UnlockChests.boughtChest6 == 1) { lockedChest.SetActive(false); arrowNextChest6.SetActive(true); chest6Wait = true;
            Invoke("waitChests6", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.boughtChest6 != 1) { lockedChest.SetActive(true); notUnlockedChest = true; arrowNextChest6.SetActive(false);
            Invoke("SetChest6", chestWait);
        }

        await Task.Delay(async);
        chest6Active = true;
        chest5Active = false;
        chest5.SetActive(false);

        if (UnlockChests.boughtChest6 != 1) { chestNotUnlocked = true; }
        if (UnlockChests.boughtChest6 == 1) { chestNotUnlocked = false; }
    }

    #endregion

    #region chest6NextBack
    public async void clickArrowBackChest6()
    {
        Chest5Price();
        SetAllGemsInactive();
        SetChest5Info();
        SetEverythingElseFalse();
        chest5.SetActive(true);
        arrowNextChest5.SetActive(true);
        arrowBackChest5.SetActive(true);
        
        notUnlockedChest = false;
        lockedChest.SetActive(false);

        await Task.Delay(async);
        chest5Active = true;
        chest6Active = false;
        chest6.SetActive(false);

        chest5Wait = true;
        Invoke("waitChests5", chestWait);
        chestNotUnlocked = false;
    }

    public void waitChests6()
    {
        SetChest6Info();
        chest6Wait = false;
    }

    public void SetChest6()
    {
        SetChest6Info();
    }

    public async void clickArrowNextChest6()
    {
        Chest7Price();
        SetAllGemsInactive();
        //SetChest7Info();
        SetEverythingElseFalse();
        chest7.SetActive(true);
        arrowBackChest7.SetActive(true);
        
        if (UnlockChests.boughtChest7 == 1) { lockedChest.SetActive(false); arrowNextChest7.SetActive(true); chest7Wait = true;
            Invoke("waitChests7", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.boughtChest7 != 1) { lockedChest.SetActive(true); notUnlockedChest = true; arrowNextChest7.SetActive(false); Invoke("SetChest7", chestWait); }

        await Task.Delay(async);
        chest7Active = true;
        chest6Active = false;
        chest6.SetActive(false);

        if (UnlockChests.boughtChest7 != 1) { chestNotUnlocked = true; }
        if (UnlockChests.boughtChest7 == 1) { chestNotUnlocked = false; }
    }

    #endregion

    #region chest7NextBack
    public async void clickArrowBackChest7()
    {
        Chest6Price();
        SetAllGemsInactive();
        SetChest6Info();
        SetEverythingElseFalse();
        chest6.SetActive(true);
        arrowNextChest6.SetActive(true);
        arrowBackChest6.SetActive(true);
        
        notUnlockedChest = false;
        lockedChest.SetActive(false);

        await Task.Delay(async);
        chest6Active = true;
        chest7Active = false;
        chest7.SetActive(false);

        chest6Wait = true;
        Invoke("waitChests6", chestWait);
        chestNotUnlocked = false;
    }

    public void waitChests7()
    {
        SetChest7Info();
        chest7Wait = false;
    }

    public void SetChest7()
    {
        SetChest7Info();
    }

    public async void clickArrowNextChest7()
    {
        Chest8Price();
        SetAllGemsInactive();
        //SetChest8Info();
        SetEverythingElseFalse();
        chest8.SetActive(true);
        arrowBackChest8.SetActive(true);
        
        if (UnlockChests.boughtChest8 == 1) { lockedChest.SetActive(false); arrowNextChest8.SetActive(true); chest8Wait = true;
            Invoke("waitChests8", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.boughtChest8 != 1) { lockedChest.SetActive(true); notUnlockedChest = true; arrowNextChest8.SetActive(false); Invoke("SetChest8", chestWait); }

        await Task.Delay(async);
        chest8Active = true;
        chest7Active = false;
        chest7.SetActive(false);

        if (UnlockChests.boughtChest8 != 1) { chestNotUnlocked = true; }
        if (UnlockChests.boughtChest8 == 1) { chestNotUnlocked = false; }
    }

    #endregion

    #region chest8NextBack
    public async void clickArrowBackChest8()
    {
        Chest7Price();
        SetAllGemsInactive();
        SetChest7Info();
        SetEverythingElseFalse();
        chest7.SetActive(true);
        arrowNextChest7.SetActive(true);
        arrowBackChest7.SetActive(true);
        notUnlockedChest = false;
        lockedChest.SetActive(false);

        await Task.Delay(async);
        chest7Active = true;
        chest8Active = false;
        chest8.SetActive(false);

        chest7Wait = true;
        Invoke("waitChests7", chestWait);
        chestNotUnlocked = false;
    }

    public void waitChests8()
    {
        SetChest8Info();
        chest8Wait = false;
    }
    public void SetChest8()
    {
        SetChest8Info();
    }
    public async void clickArrowNextChest8()
    {
        Chest9Price();
        SetAllGemsInactive();
        //SetChest9Info();
        SetEverythingElseFalse();
        
        arrowBackChest9.SetActive(true);
        chest9Active = true;
        if (UnlockChests.boughtChest9 == 1) { lockedChest.SetActive(false); arrowNextChest9.SetActive(true); chest9Wait = true;
            Invoke("waitChests9", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.boughtChest9 != 1) { lockedChest.SetActive(true); notUnlockedChest = true; arrowNextChest9.SetActive(false); Invoke("SetChest9", chestWait); }

        await Task.Delay(async);
        chest9.SetActive(true);
        chest8Active = false;
        chest8.SetActive(false);

        if (UnlockChests.boughtChest9 != 1) { chestNotUnlocked = true; }
        if (UnlockChests.boughtChest9 == 1) { chestNotUnlocked = false; }
    }
    #endregion

    #region chest9NextBack
    public async void clickArrowBackChest9()
    {
        Chest8Price();
        SetAllGemsInactive();
        SetChest8Info();
        SetEverythingElseFalse();
        chest8.SetActive(true);
        arrowNextChest8.SetActive(true);
        arrowBackChest8.SetActive(true);
        notUnlockedChest = false;
        lockedChest.SetActive(false);

        await Task.Delay(async);
        chest8Active = true;
        chest9Active = false;
        chest9.SetActive(false);

        chest8Wait = true;
        Invoke("waitChests8", chestWait);
        chestNotUnlocked = false;
    }

    public void waitChests9()
    {
        SetChest9Info();
        chest9Wait = false;
    }

    public void SetChest9()
    {
        SetChest9Info();
    }

    public async void clickArrowNextChest9()
    {
        Chest10Price();
        SetAllGemsInactive();
        //SetChest10Info();
        SetEverythingElseFalse();
        chest10.SetActive(true);
        arrowBackChest10.SetActive(true);
        
        if (UnlockChests.boughtChest10 == 1) { lockedChest.SetActive(false); arrowNextChest10.SetActive(true); chest10Wait = true;
            Invoke("waitChests10", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.boughtChest10 != 1) { lockedChest.SetActive(true); notUnlockedChest = true; arrowNextChest10.SetActive(false); Invoke("SetChest10", chestWait); }

        await Task.Delay(async);
        chest10Active = true;
        chest9Active = false;
        chest9.SetActive(false);

        if (UnlockChests.boughtChest10 != 1) { chestNotUnlocked = true; }
        if (UnlockChests.boughtChest10 == 1) { chestNotUnlocked = false; }
    }
    #endregion

    #region chest10NextBack
    public async void clickArrowBackChest10()
    {
        Chest9Price();
        SetAllGemsInactive();
        SetChest9Info();
        SetEverythingElseFalse();
        chest9.SetActive(true);
        arrowNextChest9.SetActive(true);
        arrowBackChest9.SetActive(true);
        
        notUnlockedChest = false;
        lockedChest.SetActive(false);

        await Task.Delay(async);
        chest9Active = true;
        chest10Active = false;
        chest10.SetActive(false);

        chest9Wait = true;
        Invoke("waitChests9", chestWait);
        chestNotUnlocked = false;
    }

    public void waitChests10()
    {
        SetChest10Info();
        chest10Wait = false;
    }

    public void SetChest10()
    {
        SetChest10Info();
    }

    public async void clickArrowNextChest10()
    {
        Chest11Price();
        SetAllGemsInactive();
        //SetChest11Info();
        SetEverythingElseFalse();
        chest11.SetActive(true);
        arrowBackChest11.SetActive(true);
        
        if (UnlockChests.boughtChest11 == 1) { lockedChest.SetActive(false); arrowNextChest11.SetActive(true); chest11Wait = true;
            Invoke("waitChests11", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.boughtChest11 != 1) { lockedChest.SetActive(true); notUnlockedChest = true; arrowNextChest11.SetActive(false); Invoke("SetChest11", chestWait); }

        await Task.Delay(async);
        chest11Active = true;
        chest10Active = false;
        chest10.SetActive(false);

        if (UnlockChests.boughtChest11 != 1) { chestNotUnlocked = true; }
        if (UnlockChests.boughtChest11 == 1) { chestNotUnlocked = false; }
    }
    #endregion

    #region chest11NextBack
    public async void clickArrowBackChest11()
    {
        Chest10Price();
        SetAllGemsInactive();
        SetChest10Info();
        SetEverythingElseFalse();
        chest10.SetActive(true);
        arrowNextChest10.SetActive(true);
        arrowBackChest10.SetActive(true);
        
        notUnlockedChest = false;
        lockedChest.SetActive(false);

        await Task.Delay(async);
        chest10Active = true;
        chest11Active = false;
        chest11.SetActive(false);

        chest10Wait = true;
        Invoke("waitChests10", chestWait);
        chestNotUnlocked = false;
    }
    public void waitChests11()
    {
        SetChest11Info();
        chest11Wait = false;
    }
    public void SetChest11()
    {
        SetChest11Info();
    }
    public async void clickArrowNextChest11()
    {
        Chest12Price();
        SetAllGemsInactive();
        //SetChest12Info();
        SetEverythingElseFalse();
        chest12.SetActive(true);
        arrowBackChest12.SetActive(true);
        if (UnlockChests.boughtChest12 == 1) { lockedChest.SetActive(false); arrowNextChest12.SetActive(true); chest12Wait = true;
            Invoke("waitChests12", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.boughtChest12 != 1) { lockedChest.SetActive(true); notUnlockedChest = true; arrowNextChest12.SetActive(false); Invoke("SetChest12", chestWait); }

        await Task.Delay(async);
        chest12Active = true;
        chest11Active = false;
        chest11.SetActive(false);

        if (UnlockChests.boughtChest12 != 1) { chestNotUnlocked = true; }
        if (UnlockChests.boughtChest12 == 1) { chestNotUnlocked = false; }
    }
    #endregion

    #region chest12NextBack
    public async void clickArrowBackChest12()
    {
        Chest11Price();
        SetAllGemsInactive();
        SetChest11Info();
        SetEverythingElseFalse();
        chest11.SetActive(true);
        arrowNextChest11.SetActive(true);
        arrowBackChest11.SetActive(true);
        notUnlockedChest = false;
        lockedChest.SetActive(false);

        await Task.Delay(async);
        chest11Active = true;
        chest12Active = false;
        chest12.SetActive(false);

        chest11Wait = true;
        Invoke("waitChests11", chestWait);
        chestNotUnlocked = false;
    }
    public void waitChests12()
    {
        SetChest12Info();
        chest12Wait = false;
    }
    public void SetChest12()
    {
        SetChest12Info();
    }
    public async void clickArrowNextChest12()
    {
        Chest13Price();
        SetAllGemsInactive();
        //SetChest13Info();
        SetEverythingElseFalse();
        chest13.SetActive(true);
        arrowBackChest13.SetActive(true);
        if (UnlockChests.boughtChest13 == 1) { lockedChest.SetActive(false); arrowNextChest13.SetActive(true); chest13Wait = true;
            Invoke("waitChests13", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.boughtChest13 != 1) { lockedChest.SetActive(true); notUnlockedChest = true; arrowNextChest13.SetActive(false); Invoke("SetChest13", chestWait); }

        await Task.Delay(async);
        chest13Active = true;
        chest12Active = false;
        chest12.SetActive(false);

        if (UnlockChests.boughtChest13 != 1) { chestNotUnlocked = true; }
        if (UnlockChests.boughtChest13 == 1) { chestNotUnlocked = false; }
    }
    #endregion

    #region chest13NextBack
    public async void clickArrowBackChest13()
    {
        Chest12Price();
        SetAllGemsInactive();
        SetChest12Info();
        SetEverythingElseFalse();
        chest12.SetActive(true);
        arrowNextChest12.SetActive(true);
        arrowBackChest12.SetActive(true);
        notUnlockedChest = false;
        lockedChest.SetActive(false);

        await Task.Delay(async);
        chest12Active = true;
        chest13Active = false;
        chest13.SetActive(false);

        chest12Wait = true;
        Invoke("waitChests12", chestWait);
        chestNotUnlocked = false;
    }

    public void waitChests13()
    {
        SetChest13Info();
        chest13Wait = false;
    }
    public void SetChest13()
    {
        SetChest13Info();
    }
    public async void clickArrowNextChest13()
    {
        Chest14Price();
        SetAllGemsInactive();
        //SetChest14Info();
        SetEverythingElseFalse();
        chest14.SetActive(true);
        arrowBackChest14.SetActive(true);
        if (UnlockChests.boughtChest14 == 1) { lockedChest.SetActive(false); arrowNextChest14.SetActive(true); chest14Wait = true;
            Invoke("waitChests14", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.boughtChest14 != 1) { lockedChest.SetActive(true); notUnlockedChest = true; arrowNextChest14.SetActive(false); Invoke("SetChest14", chestWait); }

        await Task.Delay(async);
        chest14Active = true;
        chest13Active = false;
        chest13.SetActive(false);

        if (UnlockChests.boughtChest14 != 1) { chestNotUnlocked = true; }
        if (UnlockChests.boughtChest14 == 1) { chestNotUnlocked = false; }
    }
    #endregion

    #region chest14NextBack
    public async void clickArrowBackChest14()
    {
        Chest13Price();
        SetAllGemsInactive();
        SetChest13Info();
        SetEverythingElseFalse();
        chest13.SetActive(true);
        arrowNextChest13.SetActive(true);
        arrowBackChest13.SetActive(true);
        chest13Active = true;
        notUnlockedChest = false;
        lockedChest.SetActive(false);

        await Task.Delay(async);
        chest13Active = true;
        chest14Active = false;
        chest14.SetActive(false);

        chest13Wait = true;
        Invoke("waitChests13", chestWait);
        chestNotUnlocked = false;
    }

    public void waitChests14()
    {
        SetChest14Info();
        chest14Wait = false;
    }
    public void SetChest14()
    {
        SetChest14Info();
    }
    public async void clickArrowNextChest14()
    {
        Chest15Price();
        SetAllGemsInactive();
        //SetChest15Info();
        SetEverythingElseFalse();
        chest15.SetActive(true);
        arrowBackChest15.SetActive(true);
        if (UnlockChests.boughtChest15 == 1) { lockedChest.SetActive(false); arrowNextChest15.SetActive(true); chest15Wait = true;
            Invoke("waitChests15", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.boughtChest15 != 1) { lockedChest.SetActive(true); notUnlockedChest = true; arrowNextChest15.SetActive(false); Invoke("SetChest15", chestWait); }

        await Task.Delay(async);
        chest15Active = true;
        chest14Active = false;
        chest14.SetActive(false);

        if (UnlockChests.boughtChest15 != 1) { chestNotUnlocked = true; }
        if (UnlockChests.boughtChest15 == 1) { chestNotUnlocked = false; }
    }
    #endregion

    #region chest15NextBack
    public async void clickArrowBackChest15()
    {
        Chest14Price();
        lockedChest.SetActive(false);
        SetAllGemsInactive();
        SetChest14Info();
        SetEverythingElseFalse();
        chest14.SetActive(true);
        arrowNextChest14.SetActive(true);
        arrowBackChest14.SetActive(true);
        notUnlockedChest = false;

        await Task.Delay(async);
        chest14Active = true;
        chest15Active = false;
        chest15.SetActive(false);

        chest14Wait = true;
        Invoke("waitChests14", chestWait);
        chestNotUnlocked = false;
    }

    public void waitChests15()
    {
        SetChest15Info();
        chest15Wait = false;
    }
    public void SetChest15()
    {
        SetChest15Info();
    }
    public async void clickArrowNextChest15()
    {
        Chest16Price();
        SetAllGemsInactive();
        //SetChest16Info();
        SetEverythingElseFalse();
        chest16.SetActive(true);
        arrowBackChest16.SetActive(true);
        if (UnlockChests.boughtChest16 == 1) { lockedChest.SetActive(false); arrowNextChest16.SetActive(true); chest16Wait = true;
            Invoke("waitChests16", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.boughtChest16 != 1) { lockedChest.SetActive(true); notUnlockedChest = true; arrowNextChest16.SetActive(false); Invoke("SetChest16", chestWait); }

        await Task.Delay(async);
        chest16Active = true;
        chest15Active = false;
        chest15.SetActive(false);

        if (UnlockChests.boughtChest16 != 1) { chestNotUnlocked = true; }
        if (UnlockChests.boughtChest16 == 1) { chestNotUnlocked = false; }
    }
    #endregion

    #region chest16NextBack
    public async void clickArrowBackChest16()
    {
        Chest15Price();
        lockedChest.SetActive(false);
        SetAllGemsInactive();
        SetChest15Info();
        SetEverythingElseFalse();
        chest15.SetActive(true);
        arrowNextChest15.SetActive(true);
        arrowBackChest15.SetActive(true);
        notUnlockedChest = false;

        await Task.Delay(async);
        chest15Active = true;
        chest16Active = false;
        chest16.SetActive(false);

        chest15Wait = true;
        Invoke("waitChests15", chestWait);
        chestNotUnlocked = false;
    }

    public void waitChests16()
    {
        SetChest16Info();
        chest16Wait = false;
    }
    public void SetChest16()
    {
        SetChest16Info();
    }
    public async void clickArrowNextChest16()
    {
        Chest17Price();
        SetAllGemsInactive();
        //SetChest17Info();
        SetEverythingElseFalse();
        chest17.SetActive(true);
        arrowBackChest17.SetActive(true);
        if (UnlockChests.boughtChest17 == 1) { lockedChest.SetActive(false); arrowNextChest17.SetActive(true); chest17Wait = true;
            Invoke("waitChests17", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.boughtChest17 != 1) { lockedChest.SetActive(true); notUnlockedChest = true; arrowNextChest17.SetActive(false); Invoke("SetChest17", chestWait); }

        await Task.Delay(async);
        chest17Active = true;
        chest16Active = false;
        chest16.SetActive(false);

        if (UnlockChests.boughtChest17 != 1) { chestNotUnlocked = true; }
        if (UnlockChests.boughtChest17 == 1) { chestNotUnlocked = false; }
    }
    #endregion

    #region chest17NextBack
    public async void clickArrowBackChest17()
    {
        Chest16Price();
        lockedChest.SetActive(false);
        SetAllGemsInactive();
        SetChest16Info();
        SetEverythingElseFalse();
        
        arrowNextChest16.SetActive(true);
        arrowBackChest16.SetActive(true);
        chest16Active = true;
        notUnlockedChest = false;

        await Task.Delay(async);
        chest16.SetActive(true);
        chest17Active = false;
        chest17.SetActive(false);

        chest16Wait = true;
        Invoke("waitChests16", chestWait);
        chestNotUnlocked = false;
    }
    public void SetChest17()
    {
        SetChest17Info();
    }
    public void waitChests17()
    {
        SetChest17Info();
        chest17Wait = false;
    }
    public async void clickArrowNextChest17()
    {
        Chest18Price();
        SetAllGemsInactive();
        //SetChest18Info();
        SetEverythingElseFalse();
        chest18.SetActive(true);
        arrowBackChest18.SetActive(true);
        if (UnlockChests.boughtChest18 == 1) { lockedChest.SetActive(false); arrowNextChest18.SetActive(true); chest18Wait = true;
            Invoke("waitChests18", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.boughtChest18 != 1) { lockedChest.SetActive(true); notUnlockedChest = true; arrowNextChest18.SetActive(false); Invoke("SetChest18", chestWait); }

        await Task.Delay(async);
        chest18Active = true;
        chest17Active = false;
        chest17.SetActive(false);

        if (UnlockChests.boughtChest18 != 1) { chestNotUnlocked = true; }
        if (UnlockChests.boughtChest18 == 1) { chestNotUnlocked = false; }
    }
    #endregion

    #region chest18NextBack
    public async void clickArrowBackChest18()
    {
        Chest17Price();
        lockedChest.SetActive(false);
        SetAllGemsInactive();
        SetChest17Info();
        SetEverythingElseFalse();
        chest17.SetActive(true);
        arrowNextChest17.SetActive(true);
        arrowBackChest17.SetActive(true);
        notUnlockedChest = false;

        await Task.Delay(async);
        chest17Active = true;
        chest18Active = false;
        chest18.SetActive(false);

        chest17Wait = true;
        Invoke("waitChests17", chestWait);
        chestNotUnlocked = false;
    }

    public void waitChests18()
    {
        SetChest18Info();
        chest18Wait = false;
    }
    public void SetChest18()
    {
        SetChest18Info();
    }

    public async void clickArrowNextChest18()
    {
        Chest19Price();
        SetAllGemsInactive();
        //SetChest19Info();
        SetEverythingElseFalse();
        chest19.SetActive(true);
        arrowBackChest19.SetActive(true);
        if (UnlockChests.boughtChest19 == 1) { lockedChest.SetActive(false); arrowNextChest19.SetActive(true); chest19Wait = true;
            Invoke("waitChests19", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.boughtChest19 != 1) { lockedChest.SetActive(true); notUnlockedChest = true; arrowNextChest19.SetActive(false); Invoke("SetChest19", chestWait); }

        await Task.Delay(async);
        chest19Active = true;
        chest18Active = false;
        chest18.SetActive(false);

        if (UnlockChests.boughtChest19 != 1) { chestNotUnlocked = true; }
        if (UnlockChests.boughtChest19 == 1) { chestNotUnlocked = false; }
    }
    #endregion

    #region chest19NextBack
    public async void clickArrowBackChest19()
    {
        Chest18Price();
        lockedChest.SetActive(false);
        SetAllGemsInactive();
        SetChest18Info();
        SetEverythingElseFalse();
        chest18.SetActive(true);
        arrowNextChest18.SetActive(true);
        arrowBackChest18.SetActive(true);
        notUnlockedChest = false;

        await Task.Delay(async);
        chest18Active = true;
        chest19Active = false;
        chest19.SetActive(false);

        chest18Wait = true;
        Invoke("waitChests18", chestWait);
        chestNotUnlocked = false;
    }

    public void waitChests19()
    {
        SetChest19Info();
        chest19Wait = false;
    }
    public void SetChest19()
    {
        SetChest19Info();
    }
    public async void clickArrowNextChest19()
    {
        Chest20Price();
        SetAllGemsInactive();
        //SetChest20Info();
        SetEverythingElseFalse();
        chest20.SetActive(true);
        arrowBackChest20.SetActive(true);
        
        if (UnlockChests.boughtChest20 == 1) { lockedChest.SetActive(false); arrowNextChest20.SetActive(true); chest20Wait = true;
            Invoke("waitChests20", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.boughtChest20 != 1) { lockedChest.SetActive(true); notUnlockedChest = true; arrowNextChest20.SetActive(false); Invoke("SetChest20", chestWait); }

        await Task.Delay(async);
        chest20Active = true;
        chest19Active = false;
        chest19.SetActive(false);

        if (UnlockChests.boughtChest20 != 1) { chestNotUnlocked = true; }
        if (UnlockChests.boughtChest20 == 1) { chestNotUnlocked = false; }
    }
    #endregion

    #region chest20NextBack
    public async void clickArrowBackChest20()
    {
        Chest19Price();
        lockedChest.SetActive(false);
        SetAllGemsInactive();
        SetChest19Info();
        SetEverythingElseFalse();
        chest19.SetActive(true);
        arrowNextChest19.SetActive(true);
        arrowBackChest19.SetActive(true);
        notUnlockedChest = false;

        await Task.Delay(async);
        chest19Active = true;
        chest20Active = false;
        chest20.SetActive(false);

        chest19Wait = true;
        Invoke("waitChests19", chestWait);
        chestNotUnlocked = false;
    }

    public void waitChests20()
    {
        SetChest20Info();
        chest20Wait = false;
    }
    public void SetChest20()
    {
        SetChest20Info();
    }

    public async void clickArrowNextChest20()
    {
        Chest21Price();
        SetAllGemsInactive();
        //SetChest21Info();
        SetEverythingElseFalse();
        chest21.SetActive(true);
        arrowBackChest21.SetActive(true);
        if (UnlockChests.boughtChest21 == 1) { lockedChest.SetActive(false); arrowNextChest21.SetActive(true); chest21Wait = true;
            Invoke("waitChests21", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.boughtChest21 != 1) { lockedChest.SetActive(true); notUnlockedChest = true; arrowNextChest21.SetActive(false); Invoke("SetChest21", chestWait); }

        await Task.Delay(async);
        chest21Active = true;
        chest20Active = false;
        chest20.SetActive(false);

        if (UnlockChests.boughtChest21 != 1) { chestNotUnlocked = true; }
        if (UnlockChests.boughtChest21 == 1) { chestNotUnlocked = false; }
    }
    #endregion

    #region chest21NextBack
    public async void clickArrowBackChest21()
    {
        Chest20Price();
        lockedChest.SetActive(false);
        SetAllGemsInactive();
        SetChest20Info();
        SetEverythingElseFalse();
        chest20.SetActive(true);
        arrowNextChest20.SetActive(true);
        arrowBackChest20.SetActive(true);
        notUnlockedChest = false;

        await Task.Delay(async);
        chest20Active = true;
        chest21Active = false;
        chest21.SetActive(false);

        chest20Wait = true;
        Invoke("waitChests20", chestWait);
        chestNotUnlocked = false;
    }

    public void waitChests21()
    {
        SetChest21Info();
        chest21Wait = false;
    }
    public void SetChest21()
    {
        SetChest21Info();
    }

    public async void clickArrowNextChest21()
    {
        Chest22Price();
        SetAllGemsInactive();
        //SetChest22Info();
        SetEverythingElseFalse();
        chest22.SetActive(true);
        arrowBackChest22.SetActive(true);
        if (UnlockChests.boughtChest22 == 1) { lockedChest.SetActive(false); arrowNextChest22.SetActive(true); chest22Wait = true;
            Invoke("waitChests22", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.boughtChest22 != 1) { lockedChest.SetActive(true); notUnlockedChest = true; arrowNextChest22.SetActive(false); Invoke("SetChest22", chestWait); }

        await Task.Delay(async);
        chest22Active = true;
        chest21Active = false;
        chest21.SetActive(false);

        if (UnlockChests.boughtChest22 != 1) { chestNotUnlocked = true; }
        if (UnlockChests.boughtChest22 == 1) { chestNotUnlocked = false; }
    }
    #endregion

    #region chest22NextBack
    public async void clickArrowBackChest22()
    {
        Chest21Price();
        lockedChest.SetActive(false);
        SetAllGemsInactive();
        SetChest21Info();
        SetEverythingElseFalse();
        chest21.SetActive(true);
        arrowNextChest21.SetActive(true);
        arrowBackChest21.SetActive(true);
        notUnlockedChest = false;

        await Task.Delay(async);
        chest21Active = true;
        chest22Active = false;
        chest22.SetActive(false);

        chest21Wait = true;
        Invoke("waitChests21", chestWait);
        chestNotUnlocked = false;
    }

    public void waitChests22()
    {
        SetChest22Info();
        chest22Wait = false;
    }
    public void SetChest22()
    {
        SetChest22Info();
    }
    public async void clickArrowNextChest22()
    {
        Chest23Price();
        SetAllGemsInactive();
        //SetChest23Info();
        SetEverythingElseFalse();
        chest23.SetActive(true);
        arrowBackChest23.SetActive(true);
        
        if (UnlockChests.boughtChest23 == 1) { lockedChest.SetActive(false); arrowNextChest23.SetActive(true); chest23Wait = true;
            Invoke("waitChests23", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.boughtChest23 != 1) { lockedChest.SetActive(true); notUnlockedChest = true; arrowNextChest23.SetActive(false); Invoke("SetChest23", chestWait); }

        await Task.Delay(async);
        chest23Active = true;
        chest22Active = false;
        chest22.SetActive(false);

        if (UnlockChests.boughtChest23 != 1) { chestNotUnlocked = true; }
        if (UnlockChests.boughtChest23 == 1) { chestNotUnlocked = false; }
    }
    #endregion

    #region chest23NextBack
    public async void clickArrowBackChest23()
    {
        Chest22Price();
        lockedChest.SetActive(false);
        SetAllGemsInactive();
        SetChest22Info();
        SetEverythingElseFalse();
        chest22.SetActive(true);
        arrowNextChest22.SetActive(true);
        arrowBackChest22.SetActive(true);
        notUnlockedChest = false;

        await Task.Delay(async);
        chest22Active = true;
        chest23Active = false;
        chest23.SetActive(false);

        chest22Wait = true;
        Invoke("waitChests22", chestWait);
        chestNotUnlocked = false;
    }
    public void waitChests23()
    {
        SetChest23Info();
        chest23Wait = false;
    }
    public void SetChest23()
    {
        SetChest23Info();
    }

    public async void clickArrowNextChest23()
    {
        Chest24Price();
        SetAllGemsInactive();
        //SetChest24Info();
        SetEverythingElseFalse();
        chest24.SetActive(true);
        arrowBackChest24.SetActive(true);
        if (UnlockChests.boughtChest24 == 1) { lockedChest.SetActive(false); arrowNextChest24.SetActive(true); chest24Wait = true;
            Invoke("waitChests24", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.boughtChest24 != 1) { lockedChest.SetActive(true); notUnlockedChest = true; arrowNextChest24.SetActive(false); Invoke("SetChest24", chestWait); }

        await Task.Delay(async);
        chest24Active = true;
        chest23Active = false;
        chest23.SetActive(false);

        if (UnlockChests.boughtChest24 != 1) { chestNotUnlocked = true; }
        if (UnlockChests.boughtChest24 == 1) { chestNotUnlocked = false; }
    }
    #endregion

    #region chest24NextBack
    public async void clickArrowBackChest24()
    {
        Chest23Price();
        lockedChest.SetActive(false);
        SetAllGemsInactive();
        SetChest23Info();
        SetEverythingElseFalse();
        chest23.SetActive(true);
        arrowNextChest23.SetActive(true);
        arrowBackChest23.SetActive(true);
        notUnlockedChest = false;

        await Task.Delay(async);
        chest23Active = true;
        chest24Active = false;
        chest24.SetActive(false);

        chest23Wait = true;
        Invoke("waitChests23", chestWait);
        chestNotUnlocked = false;
    }

    public void waitChests24()
    {
        SetChest24Info();
        chest24Wait = false;
    }
    public void SetChest24()
    {
        SetChest24Info();
    }
    public async void clickArrowNextChest24()
    {
        Chest25Price();
        SetAllGemsInactive();
        //SetChest25Info();
        SetEverythingElseFalse();
        chest25.SetActive(true);
        arrowBackChest25.SetActive(true);
        if (UnlockChests.boughtChest25 == 1) { lockedChest.SetActive(false); arrowNextChest25.SetActive(true); chest25Wait = true;
            Invoke("waitChests25", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.boughtChest25 != 1) { lockedChest.SetActive(true); notUnlockedChest = true; arrowNextChest25.SetActive(false); Invoke("SetChest25", chestWait); }

        await Task.Delay(async);
        chest25Active = true;
        chest24Active = false;
        chest24.SetActive(false);

        if (UnlockChests.boughtChest25 != 1) { chestNotUnlocked = true; }
        if (UnlockChests.boughtChest25 == 1) { chestNotUnlocked = false; }
    }
    #endregion

    #region chest25NextBack
    public async void clickArrowBackChest25()
    {
        Chest24Price();
        lockedChest.SetActive(false);
        SetAllGemsInactive();
        SetChest24Info();
        SetEverythingElseFalse();
        chest24.SetActive(true);
        arrowNextChest24.SetActive(true);
        arrowBackChest24.SetActive(true);
        notUnlockedChest = false;

        await Task.Delay(async);
        chest24Active = true;
        chest25Active = false;
        chest25.SetActive(false);

        chest24Wait = true;
        Invoke("waitChests24", chestWait);
        chestNotUnlocked = false;
    }
    public void waitChests25()
    {
        SetChest25Info();
        chest25Wait = false;
    }
    public void SetChest25()
    {
        SetChest25Info();
    }
    public async void clickArrowNextChest25()
    {
        Chest26Price();
        SetAllGemsInactive();
        //SetChest26Info();
        SetEverythingElseFalse();
        chest26.SetActive(true);
        arrowBackChest26.SetActive(true);
        if (UnlockChests.boughtChest26 == 1) { lockedChest.SetActive(false); arrowNextChest26.SetActive(true); chest26Wait = true;
            Invoke("waitChests26", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.boughtChest26 != 1) { lockedChest.SetActive(true); notUnlockedChest = true; arrowNextChest26.SetActive(false); Invoke("SetChest26", chestWait); }

        await Task.Delay(async);
        chest26Active = true;
        chest25Active = false;
        chest25.SetActive(false);

        if (UnlockChests.boughtChest26 != 1) { chestNotUnlocked = true; }
        if (UnlockChests.boughtChest26 == 1) { chestNotUnlocked = false; }
    }
    #endregion

    #region chest26NextBack
    public async void clickArrowBackChest26()
    {
        Chest25Price();
        lockedChest.SetActive(false);
        SetAllGemsInactive();
        SetChest25Info();
        SetEverythingElseFalse();
        chest25.SetActive(true);
        arrowNextChest25.SetActive(true);
        arrowBackChest25.SetActive(true);
        notUnlockedChest = false;

        await Task.Delay(async);
        chest25Active = true;
        chest26Active = false;
        chest26.SetActive(false);

        chest25Wait = true;
        Invoke("waitChests25", chestWait);
        chestNotUnlocked = false;
    }
    public void waitChests26()
    {
        SetChest26Info();
        chest26Wait = false;
    }
    public void SetChest26()
    {
        SetChest26Info();
    }
    public async void clickArrowNextChest26()
    {
        Chest27Price();
        SetAllGemsInactive();
        //SetChest27Info();
        SetEverythingElseFalse();
        chest27.SetActive(true);
        arrowBackChest27.SetActive(true);
        if (UnlockChests.boughtChest27 == 1) { arrowNextChest27.SetActive(true); lockedChest.SetActive(false); chest27Wait = true;
            Invoke("waitChests27", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.boughtChest27 != 1) { arrowNextChest27.SetActive(false); lockedChest.SetActive(true); notUnlockedChest = true; Invoke("SetChest27", chestWait); }

        await Task.Delay(async);
        chest27Active = true;
        chest26Active = false;
        chest26.SetActive(false);

        if (UnlockChests.boughtChest27 != 1) { chestNotUnlocked = true; }
        if (UnlockChests.boughtChest27 == 1) { chestNotUnlocked = false; }
    }
    #endregion

    #region chest27NextBack
    public async void clickArrowBackChest27()
    {
        Chest26Price();
        lockedChest.SetActive(false);
        SetAllGemsInactive();
        SetChest26Info();
        SetEverythingElseFalse();
        chest26.SetActive(true);
        arrowNextChest26.SetActive(true);
        arrowBackChest26.SetActive(true);
        chest26Active = true;
        notUnlockedChest = false;

        await Task.Delay(async);
        chest26Active = true;
        chest27Active = false;
        chest27.SetActive(false);

        chest26Wait = true;
        Invoke("waitChests26", chestWait);
        chestNotUnlocked = false;
    }
    public void SetChest27()
    {
        SetChest27Info();
    }
    public void waitChests27()
    {
        SetChest27Info();
        chest27Wait = false;
    }

    public async void clickArrowNextChest27()
    {
        Chest28Price();
        SetAllGemsInactive();
        SetEverythingElseFalse();
        chest28.SetActive(true);
        arrowBackChest28.SetActive(true);
        if (UnlockChests.timesPurchasedChests >= 27)
        {
            arrowNextChest28.SetActive(true);
            lockedChest.SetActive(false); chest28Wait = true;
            Invoke("waitChests28", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.timesPurchasedChests < 27) { arrowNextChest28.SetActive(false); lockedChest.SetActive(true); notUnlockedChest = true; Invoke("SetChest28", chestWait); }

        await Task.Delay(async);
        chest28Active = true;
        chest27Active = false;
        chest27.SetActive(false);

        if (UnlockChests.timesPurchasedChests < 27) { chestNotUnlocked = true; }
        if (UnlockChests.timesPurchasedChests >= 27) { chestNotUnlocked = false; }
    }
    #endregion

    #region chest28NextBack
    public async void clickArrowBackChest28()
    {
        Chest27Price();
        lockedChest.SetActive(false);
        SetAllGemsInactive();
        SetChest27Info();
        SetEverythingElseFalse();
        chest27.SetActive(true);
        arrowNextChest27.SetActive(true);
        arrowBackChest27.SetActive(true);
        chest27Active = true;
        notUnlockedChest = false;

        await Task.Delay(async);
        chest27Active = true;
        chest28Active = false;
        chest28.SetActive(false);

        chest27Wait = true;
        Invoke("waitChests27", chestWait);
        chestNotUnlocked = false;
    }

    public void SetChest28()
    {
        SetChest28Info();
    }

    public void waitChests28()
    {
        SetChest28Info();
        chest28Wait = false;
    }

    public async void clickArrowNextChest28()
    {
        Chest29Price();
        SetAllGemsInactive();
        SetEverythingElseFalse();
        chest29.SetActive(true);
        arrowBackChest29.SetActive(true);
        if (UnlockChests.timesPurchasedChests >= 28)
        {
            arrowNextChest29.SetActive(true);
            lockedChest.SetActive(false);
            chest29Wait = true;
            Invoke("waitChests29", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.timesPurchasedChests < 28)
        {
            arrowNextChest29.SetActive(false);
            lockedChest.SetActive(true);
            notUnlockedChest = true;
            Invoke("SetChest29", chestWait);
        }

        await Task.Delay(async);
        chest29Active = true;
        chest28Active = false;
        chest28.SetActive(false);

        if (UnlockChests.timesPurchasedChests < 28)
        {
            chestNotUnlocked = true;
        }
        if (UnlockChests.timesPurchasedChests >= 28)
        {
            chestNotUnlocked = false;
        }
    }
    #endregion

    #region chest29NextBack
    public async void clickArrowBackChest29()
    {
        Chest28Price();
        lockedChest.SetActive(false);
        SetAllGemsInactive();
        SetChest28Info();
        SetEverythingElseFalse();
        chest28.SetActive(true);
        arrowNextChest28.SetActive(true);
        arrowBackChest28.SetActive(true);
        chest28Active = true;
        notUnlockedChest = false;

        await Task.Delay(async);
        chest28Active = true;
        chest29Active = false;
        chest29.SetActive(false);

        chest28Wait = true;
        Invoke("waitChests28", chestWait);
        chestNotUnlocked = false;
    }

    public void SetChest29()
    {
        SetChest29Info();
    }

    public void waitChests29()
    {
        SetChest29Info();
        chest29Wait = false;
    }

    public async void clickArrowNextChest29()
    {
        Chest30Price();
        SetAllGemsInactive();
        SetEverythingElseFalse();
        chest30.SetActive(true);
        arrowBackChest30.SetActive(true);
        if (UnlockChests.timesPurchasedChests >= 29)
        {
            arrowNextChest30.SetActive(true);
            lockedChest.SetActive(false);
            chest30Wait = true;
            Invoke("waitChests30", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.timesPurchasedChests < 29)
        {
            arrowNextChest30.SetActive(false);
            lockedChest.SetActive(true);
            notUnlockedChest = true;
            Invoke("SetChest30", chestWait);
        }

        await Task.Delay(async);
        chest30Active = true;
        chest29Active = false;
        chest29.SetActive(false);

        if (UnlockChests.timesPurchasedChests < 29)
        {
            chestNotUnlocked = true;
        }
        if (UnlockChests.timesPurchasedChests >= 29)
        {
            chestNotUnlocked = false;
        }
    }
    #endregion

    #region chest30NextBack
    public async void clickArrowBackChest30()
    {
        Chest29Price();
        lockedChest.SetActive(false);
        SetAllGemsInactive();
        SetChest29Info();
        SetEverythingElseFalse();
        chest29.SetActive(true);
        arrowNextChest29.SetActive(true);
        arrowBackChest29.SetActive(true);
        chest29Active = true;
        notUnlockedChest = false;

        await Task.Delay(async);
        chest29Active = true;
        chest30Active = false;
        chest30.SetActive(false);

        chest29Wait = true;
        Invoke("waitChests29", chestWait);
        chestNotUnlocked = false;
    }

    public void SetChest30()
    {
        SetChest30Info();
    }

    public void waitChests30()
    {
        SetChest30Info();
        chest30Wait = false;
    }

    public async void clickArrowNextChest30()
    {
        Chest31Price();
        SetAllGemsInactive();
        SetEverythingElseFalse();
        chest31.SetActive(true);
        arrowBackChest31.SetActive(true);
        if (UnlockChests.timesPurchasedChests >= 30)
        {
            arrowNextChest31.SetActive(true);
            lockedChest.SetActive(false);
            chest31Wait = true;
            Invoke("waitChests31", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.timesPurchasedChests < 30)
        {
            arrowNextChest31.SetActive(false);
            lockedChest.SetActive(true);
            notUnlockedChest = true;
            Invoke("SetChest31", chestWait);
        }

        await Task.Delay(async);
        chest31Active = true;
        chest30Active = false;
        chest30.SetActive(false);

        if (UnlockChests.timesPurchasedChests < 30)
        {
            chestNotUnlocked = true;
        }
        if (UnlockChests.timesPurchasedChests >= 30)
        {
            chestNotUnlocked = false;
        }
    }
    #endregion

    #region chest31NextBack
    public async void clickArrowBackChest31()
    {
        Chest30Price();
        lockedChest.SetActive(false);
        SetAllGemsInactive();
        SetChest30Info();
        SetEverythingElseFalse();
        chest30.SetActive(true);
        arrowNextChest30.SetActive(true);
        arrowBackChest30.SetActive(true);
        chest30Active = true;
        notUnlockedChest = false;

        await Task.Delay(async);
        chest30Active = true;
        chest31Active = false;
        chest31.SetActive(false);

        chest30Wait = true;
        Invoke("waitChests30", chestWait);
        chestNotUnlocked = false;
    }

    public void SetChest31()
    {
        SetChest31Info();
    }

    public void waitChests31()
    {
        SetChest31Info();
        chest31Wait = false;
    }

    public async void clickArrowNextChest31()
    {
        Chest32Price();
        SetAllGemsInactive();
        SetEverythingElseFalse();
        chest32.SetActive(true);
        arrowBackChest32.SetActive(true);
        if (UnlockChests.timesPurchasedChests >= 31)
        {
            arrowNextChest32.SetActive(true);
            lockedChest.SetActive(false);
            chest32Wait = true;
            Invoke("waitChests32", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.timesPurchasedChests < 31)
        {
            arrowNextChest32.SetActive(false);
            lockedChest.SetActive(true);
            notUnlockedChest = true;
            Invoke("SetChest32", chestWait);
        }

        await Task.Delay(async);
        chest32Active = true;
        chest31Active = false;
        chest31.SetActive(false);

        if (UnlockChests.timesPurchasedChests < 31)
        {
            chestNotUnlocked = true;
        }
        if (UnlockChests.timesPurchasedChests >= 31)
        {
            chestNotUnlocked = false;
        }
    }
    #endregion

    #region chest32NextBack
    public async void clickArrowBackChest32()
    {
        Chest31Price();
        lockedChest.SetActive(false);
        SetAllGemsInactive();
        SetChest31Info();
        SetEverythingElseFalse();
        chest31.SetActive(true);
        arrowNextChest31.SetActive(true);
        arrowBackChest31.SetActive(true);
        chest31Active = true;
        notUnlockedChest = false;

        await Task.Delay(async);
        chest31Active = true;
        chest32Active = false;
        chest32.SetActive(false);

        chest31Wait = true;
        Invoke("waitChests31", chestWait);
        chestNotUnlocked = false;
    }

    public void SetChest32()
    {
        SetChest32Info();
    }

    public void waitChests32()
    {
        SetChest32Info();
        chest32Wait = false;
    }

    public async void clickArrowNextChest32()
    {
        Chest33Price();
        SetAllGemsInactive();
        SetEverythingElseFalse();
        chest33.SetActive(true);
        arrowBackChest33.SetActive(true);
        if (UnlockChests.timesPurchasedChests >= 32)
        {
            arrowNextChest33.SetActive(true);
            lockedChest.SetActive(false);
            chest33Wait = true;
            Invoke("waitChests33", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.timesPurchasedChests < 32)
        {
            arrowNextChest33.SetActive(false);
            lockedChest.SetActive(true);
            notUnlockedChest = true;
            Invoke("SetChest33", chestWait);
        }

        await Task.Delay(async);
        chest33Active = true;
        chest32Active = false;
        chest32.SetActive(false);

        if (UnlockChests.timesPurchasedChests < 32)
        {
            chestNotUnlocked = true;
        }
        if (UnlockChests.timesPurchasedChests >= 32)
        {
            chestNotUnlocked = false;
        }
    }
    #endregion

    #region chest33NextBack
    public async void clickArrowBackChest33()
    {
        Chest32Price();
        lockedChest.SetActive(false);
        SetAllGemsInactive();
        SetChest32Info();
        SetEverythingElseFalse();
        chest32.SetActive(true);
        arrowNextChest32.SetActive(true);
        arrowBackChest32.SetActive(true);
        chest32Active = true;
        notUnlockedChest = false;

        await Task.Delay(async);
        chest32Active = true;
        chest33Active = false;
        chest33.SetActive(false);

        chest32Wait = true;
        Invoke("waitChests32", chestWait);
        chestNotUnlocked = false;
    }

    public void SetChest33()
    {
        SetChest33Info();
    }

    public void waitChests33()
    {
        SetChest33Info();
        chest33Wait = false;
    }

    public async void clickArrowNextChest33()
    {
        Chest34Price();
        SetAllGemsInactive();
        SetEverythingElseFalse();
        chest34.SetActive(true);
        arrowBackChest34.SetActive(true);
        if (UnlockChests.timesPurchasedChests >= 33)
        {
            arrowNextChest34.SetActive(true);
            lockedChest.SetActive(false);
            chest34Wait = true;
            Invoke("waitChests34", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.timesPurchasedChests < 33)
        {
            arrowNextChest34.SetActive(false);
            lockedChest.SetActive(true);
            notUnlockedChest = true;
            Invoke("SetChest34", chestWait);
        }

        await Task.Delay(async);
        chest34Active = true;
        chest33Active = false;
        chest33.SetActive(false);

        if (UnlockChests.timesPurchasedChests < 33)
        {
            chestNotUnlocked = true;
        }
        if (UnlockChests.timesPurchasedChests >= 33)
        {
            chestNotUnlocked = false;
        }
    }
    #endregion

    #region chest34NextBack
    public async void clickArrowBackChest34()
    {
        Chest33Price();
        lockedChest.SetActive(false);
        SetAllGemsInactive();
        SetChest33Info();
        SetEverythingElseFalse();
        chest33.SetActive(true);
        arrowNextChest33.SetActive(true);
        arrowBackChest33.SetActive(true);
        chest33Active = true;
        notUnlockedChest = false;

        await Task.Delay(async);
        chest33Active = true;
        chest34Active = false;
        chest34.SetActive(false);

        chest33Wait = true;
        Invoke("waitChests33", chestWait);
        chestNotUnlocked = false;
    }

    public void SetChest34()
    {
        SetChest34Info();
    }

    public void waitChests34()
    {
        SetChest34Info();
        chest34Wait = false;
    }

    public async void clickArrowNextChest34()
    {
        Chest35Price();
        SetAllGemsInactive();
        SetEverythingElseFalse();
        chest35.SetActive(true);
        arrowBackChest35.SetActive(true);
        if (UnlockChests.timesPurchasedChests >= 34)
        {
            arrowNextChest35.SetActive(true);
            lockedChest.SetActive(false);
            chest35Wait = true;
            Invoke("waitChests35", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.timesPurchasedChests < 34)
        {
            arrowNextChest35.SetActive(false);
            lockedChest.SetActive(true);
            notUnlockedChest = true;
            Invoke("SetChest35", chestWait);
        }

        await Task.Delay(async);
        chest35Active = true;
        chest34Active = false;
        chest34.SetActive(false);

        if (UnlockChests.timesPurchasedChests < 34)
        {
            chestNotUnlocked = true;
        }
        if (UnlockChests.timesPurchasedChests >= 34)
        {
            chestNotUnlocked = false;
        }
    }
    #endregion

    #region chest35NextBack
    public async void clickArrowBackChest35()
    {
        Chest34Price();
        lockedChest.SetActive(false);
        SetAllGemsInactive();
        SetChest34Info();
        SetEverythingElseFalse();
        chest34.SetActive(true);
        arrowNextChest34.SetActive(true);
        arrowBackChest34.SetActive(true);
        chest34Active = true;
        notUnlockedChest = false;

        await Task.Delay(async);
        chest34Active = true;
        chest35Active = false;
        chest35.SetActive(false);

        chest34Wait = true;
        Invoke("waitChests34", chestWait);
        chestNotUnlocked = false;
    }

    public void SetChest35()
    {
        SetChest35Info();
    }

    public void waitChests35()
    {
        SetChest35Info();
        chest35Wait = false;
    }

    public async void clickArrowNextChest35()
    {
        Chest36Price();
        SetAllGemsInactive();
        SetEverythingElseFalse();
        chest36.SetActive(true);
        arrowBackChest36.SetActive(true);
        if (UnlockChests.timesPurchasedChests >= 35)
        {
            arrowNextChest36.SetActive(true);
            lockedChest.SetActive(false);
            chest36Wait = true;
            Invoke("waitChests36", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.timesPurchasedChests < 35)
        {
            arrowNextChest36.SetActive(false);
            lockedChest.SetActive(true);
            notUnlockedChest = true;
            Invoke("SetChest36", chestWait);
        }

        await Task.Delay(async);
        chest36Active = true;
        chest35Active = false;
        chest35.SetActive(false);

        if (UnlockChests.timesPurchasedChests < 35)
        {
            chestNotUnlocked = true;
        }
        if (UnlockChests.timesPurchasedChests >= 35)
        {
            chestNotUnlocked = false;
        }
    }
    #endregion

    #region chest36NextBack
    public async void clickArrowBackChest36()
    {
        Chest35Price();
        lockedChest.SetActive(false);
        SetAllGemsInactive();
        SetChest35Info();
        SetEverythingElseFalse();
        chest35.SetActive(true);
        arrowNextChest35.SetActive(true);
        arrowBackChest35.SetActive(true);
        chest35Active = true;
        notUnlockedChest = false;

        await Task.Delay(async);
        chest35Active = true;
        chest36Active = false;
        chest36.SetActive(false);

        chest35Wait = true;
        Invoke("waitChests35", chestWait);
        chestNotUnlocked = false;
    }

    public void SetChest36()
    {
        SetChest36Info();
    }

    public void waitChests36()
    {
        SetChest36Info();
        chest36Wait = false;
    }

    public async void clickArrowNextChest36()
    {
        Chest37Price();
        SetAllGemsInactive();
        SetEverythingElseFalse();
        chest37.SetActive(true);
        arrowBackChest37.SetActive(true);
        if (UnlockChests.timesPurchasedChests >= 36)
        {
            arrowNextChest37.SetActive(true);
            lockedChest.SetActive(false);
            chest37Wait = true;
            Invoke("waitChests37", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.timesPurchasedChests < 36)
        {
            arrowNextChest37.SetActive(false);
            lockedChest.SetActive(true);
            notUnlockedChest = true;
            Invoke("SetChest37", chestWait);
        }

        await Task.Delay(async);
        chest37Active = true;
        chest36Active = false;
        chest36.SetActive(false);

        if (UnlockChests.timesPurchasedChests < 36)
        {
            chestNotUnlocked = true;
        }
        if (UnlockChests.timesPurchasedChests >= 36)
        {
            chestNotUnlocked = false;
        }
    }
    #endregion

    #region chest37NextBack
    public async void clickArrowBackChest37()
    {
        Chest36Price();
        lockedChest.SetActive(false);
        SetAllGemsInactive();
        SetChest36Info();
        SetEverythingElseFalse();
        chest36.SetActive(true);
        arrowNextChest36.SetActive(true);
        arrowBackChest36.SetActive(true);
        chest36Active = true;
        notUnlockedChest = false;

        await Task.Delay(async);
        chest36Active = true;
        chest37Active = false;
        chest37.SetActive(false);

        chest36Wait = true;
        Invoke("waitChests36", chestWait);
        chestNotUnlocked = false;
    }

    public void SetChest37()
    {
        SetChest37Info();
    }

    public void waitChests37()
    {
        SetChest37Info();
        chest37Wait = false;
    }

    public async void clickArrowNextChest37()
    {
        Chest38Price();
        SetAllGemsInactive();
        SetEverythingElseFalse();
        chest38.SetActive(true);
        arrowBackChest38.SetActive(true);
        if (UnlockChests.timesPurchasedChests >= 37)
        {
            arrowNextChest38.SetActive(true);
            lockedChest.SetActive(false);
            chest38Wait = true;
            Invoke("waitChests38", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.timesPurchasedChests < 37)
        {
            arrowNextChest38.SetActive(false);
            lockedChest.SetActive(true);
            notUnlockedChest = true;
            Invoke("SetChest38", chestWait);
        }

        await Task.Delay(async);
        chest38Active = true;
        chest37Active = false;
        chest37.SetActive(false);

        if (UnlockChests.timesPurchasedChests < 37)
        {
            chestNotUnlocked = true;
        }
        if (UnlockChests.timesPurchasedChests >= 37)
        {
            chestNotUnlocked = false;
        }
    }
    #endregion

    #region chest38NextBack
    public async void clickArrowBackChest38()
    {
        Chest37Price();
        lockedChest.SetActive(false);
        SetAllGemsInactive();
        SetChest37Info();
        SetEverythingElseFalse();
        chest37.SetActive(true);
        arrowNextChest37.SetActive(true);
        arrowBackChest37.SetActive(true);
        chest37Active = true;
        notUnlockedChest = false;

        await Task.Delay(async);
        chest37Active = true;
        chest38Active = false;
        chest38.SetActive(false);

        chest37Wait = true;
        Invoke("waitChests37", chestWait);
        chestNotUnlocked = false;
    }

    public void SetChest38()
    {
        SetChest38Info();
    }

    public void waitChests38()
    {
        SetChest38Info();
        chest38Wait = false;
    }

    public async void clickArrowNextChest38()
    {
        Chest39Price();
        SetAllGemsInactive();
        SetEverythingElseFalse();
        chest39.SetActive(true);
        arrowBackChest39.SetActive(true);
        if (UnlockChests.timesPurchasedChests >= 38)
        {
            arrowNextChest39.SetActive(true);
            lockedChest.SetActive(false);
            chest39Wait = true;
            Invoke("waitChests39", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.timesPurchasedChests < 38)
        {
            arrowNextChest39.SetActive(false);
            lockedChest.SetActive(true);
            notUnlockedChest = true;
            Invoke("SetChest39", chestWait);
        }

        await Task.Delay(async);
        chest39Active = true;
        chest38Active = false;
        chest38.SetActive(false);

        if (UnlockChests.timesPurchasedChests < 38)
        {
            chestNotUnlocked = true;
        }
        if (UnlockChests.timesPurchasedChests >= 38)
        {
            chestNotUnlocked = false;
        }
    }
    #endregion

    #region chest39NextBack
    public async void clickArrowBackChest39()
    {
        Chest38Price();
        lockedChest.SetActive(false);
        SetAllGemsInactive();
        SetChest38Info();
        SetEverythingElseFalse();
        chest38.SetActive(true);
        arrowNextChest38.SetActive(true);
        arrowBackChest38.SetActive(true);
        chest38Active = true;
        notUnlockedChest = false;

        await Task.Delay(async);
        chest38Active = true;
        chest39Active = false;
        chest39.SetActive(false);

        chest38Wait = true;
        Invoke("waitChests38", chestWait);
        chestNotUnlocked = false;
    }

    public void SetChest39()
    {
        SetChest39Info();
    }

    public void waitChests39()
    {
        SetChest39Info();
        chest39Wait = false;
    }

    public async void clickArrowNextChest39()
    {
        Chest40Price();
        SetAllGemsInactive();
        SetEverythingElseFalse();
        chest40.SetActive(true);
        arrowBackChest40.SetActive(true);
        if (UnlockChests.timesPurchasedChests >= 39)
        {
            lockedChest.SetActive(false);
            chest40Wait = true;
            Invoke("waitChests40", chestWait);
            Invoke("CurrentMiniChestGold", chestWait);
        }
        if (UnlockChests.timesPurchasedChests < 39)
        {
            lockedChest.SetActive(true);
            notUnlockedChest = true;
            Invoke("SetChest40", chestWait);
        }

        await Task.Delay(async);
        chest40Active = true;
        chest39Active = false;
        chest39.SetActive(false);

        if (UnlockChests.timesPurchasedChests < 39)
        {
            chestNotUnlocked = true;
        }
        if (UnlockChests.timesPurchasedChests >= 39)
        {
            chestNotUnlocked = false;
        }
    }
    #endregion

    #region chest40NextBack
    public async void clickArrowBackChest40()
    {
        Chest39Price();
        lockedChest.SetActive(false);
        SetAllGemsInactive();
        SetChest39Info();
        SetEverythingElseFalse();
        chest39.SetActive(true);
        arrowNextChest39.SetActive(true);
        arrowBackChest39.SetActive(true);
        chest39Active = true;
        notUnlockedChest = false;

        await Task.Delay(async);
        chest39Active = true;
        chest40Active = false;
        chest40.SetActive(false);

        chest39Wait = true;
        Invoke("waitChests39", chestWait);
        chestNotUnlocked = false;
    }

    public void SetChest40()
    {
        SetChest40Info();
    }

    public void waitChests40()
    {
        SetChest40Info();
        chest40Wait = false;
    }
    #endregion


    public TextMeshProUGUI chestNumberName;
    public TextMeshProUGUI prestigeKeyDropChance, prestigeChestDropChance;
    public static double averageChestGoldSpawn;

    public static double currentMiniChestGoldValue;

    //All chests info

    #region Chest1Info
    public void SetChest1Info()
    {
        chestNumberName.text = Localization.chestNumber + "1" + Localization.chestNO;
        chest1.transform.localPosition = yPos39;
        chest1.transform.localScale = scale46;
        chest1.GetComponent<Animation>().Rewind("FirstChestOpen");
        ChestHealth = 20;
        chestName.text = Localization.WoodenChest;
        randomMinGold = 1; randomMaxGold = 2;
        PlayerLevel.xpChestDrop = 3;

        reinforcedChestChance = 3f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        averageChestGoldSpawn = (randomMaxGold) * 4;
        //Debug.Log(averageChestGoldSpawn);

        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>3-5";

        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;

        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        quartz.SetActive(true);

    }
    #endregion

    #region Chest2Info
    public static double chest2Price;
    public static string chest2Name;
    public void SetChest2Info()
    {
        chestNumberName.text = Localization.chestNumber + "2" + Localization.chestNO;
        chest2.transform.localPosition = yPos51;
        chest2.transform.localScale = scale283;

        chest2Name = Localization.TimberwoodChest;
        chestName.text = chest2Name;
        randomMinGold = 3; randomMaxGold = 4;
        PlayerLevel.xpChestDrop = 5;

        reinforcedChestChance = 2.9f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        averageChestGoldSpawn = (randomMaxGold) * 4;
        //Debug.Log(averageChestGoldSpawn);

        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>3-5";
        //chestGoldDropInfo.text = "Gold coin value: <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMinGold) + "-" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + " Gold";

        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;

        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        quartz.SetActive(true);
        amethyst.SetActive(true);

      
    }

    public void Chest2Price()
    {
        ChestHealth = 125;
        chestPrice = 220;
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest3Info
    public static double chest3Price;
    public static string chest3Name;
    public void SetChest3Info()
    {
        chestNumberName.text = Localization.chestNumber + "3" + Localization.chestNO;
        chest3.transform.localPosition = yPos58;
        chest3.transform.localScale = scale279;

        randomMinGold = 8; randomMaxGold = 13;
       
        chest3Name = Localization.RockboundChest;
        chestName.text = chest3Name;
        PlayerLevel.xpChestDrop = 7;

        averageChestGoldSpawn = (randomMaxGold) * 6;
        //Debug.Log(averageChestGoldSpawn);

        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>5-7";


        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;

        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        reinforcedChestChance = 2.8f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        quartz.SetActive(true);
        amethyst.SetActive(true);
        yellowTopaz.SetActive(true);

       
    }

    public void Chest3Price()
    {
        ChestHealth = 800;
        chestPrice = 1000;
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest4Info
    public static double chest4Price;
    public static string chest4Name;
    public void SetChest4Info()
    {
        chestNumberName.text = Localization.chestNumber + "4" + Localization.chestNO;
        chest4.transform.localPosition = yPos58;
        chest4.transform.localScale = scale279;

        randomMinGold = 20; randomMaxGold = 30;
        
        chest4Name = Localization.BronzeChest;
        chestName.text = chest4Name;
        PlayerLevel.xpChestDrop = 9;  

        averageChestGoldSpawn = (randomMaxGold) * 6;
        //Debug.Log(averageChestGoldSpawn);

        reinforcedChestChance = 2.8f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>5-7";


        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;

        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        quartz.SetActive(true);
        amethyst.SetActive(true);
        yellowTopaz.SetActive(true);
        albite.SetActive(true);

        
    }

    public void Chest4Price()
    {
        ChestHealth = 4000;
        chestPrice = 7000;
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest5Info
    public static double chest5Price;
    public static string chest5Name;
    public void SetChest5Info()
    {
        chestNumberName.text = Localization.chestNumber + "5" + Localization.chestNO;
        chest5.transform.localPosition = yPos58;
        chest5.transform.localScale = scale279;
       
        randomMinGold = 50; randomMaxGold = 70;
        
        chest5Name = Localization.SequoiaChest;
        chestName.text = chest5Name;
        PlayerLevel.xpChestDrop = 13;

        reinforcedChestChance = 2.7f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        averageChestGoldSpawn = (randomMaxGold) * 6;
        //Debug.Log(averageChestGoldSpawn);

        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>5-7";

        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        quartz.SetActive(true);
        amethyst.SetActive(true);
        yellowTopaz.SetActive(true);
        albite.SetActive(true);
        redGarnet.SetActive(true);
    }

    public void Chest5Price()
    {
        ChestHealth = 13000;
        chestPrice = 23000;
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest6Info
    public static double chest6Price;
    public static string chest6Name;
    public void SetChest6Info()
    {
        chestNumberName.text = Localization.chestNumber + "6" + Localization.chestNO;
        chest6.transform.localPosition = yPos58;
        chest6.transform.localScale = scale279;

        randomMinGold = 105; randomMaxGold = 135;
       
        chest6Name = Localization.IronboundChest;
        chestName.text = chest6Name;
        PlayerLevel.xpChestDrop = 18;

        reinforcedChestChance = 2.5f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        averageChestGoldSpawn = (randomMaxGold) * 8;
        //Debug.Log(averageChestGoldSpawn);

        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>7-9";
       
        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        quartz.SetActive(true);
        amethyst.SetActive(true);
        yellowTopaz.SetActive(true);
        albite.SetActive(true);
        redGarnet.SetActive(true);

        
    }


    public void Chest6Price()
    {
        ChestHealth = 45000;
        chestPrice = 85000;
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest7Info
    public static double chest7Price;
    public static string chest7Name;
    public void SetChest7Info()
    {
        chestNumberName.text = Localization.chestNumber + "7" + Localization.chestNO;
        chest7.transform.localPosition = yPos40;
        chest7.transform.localScale = scale54;
      
        randomMinGold = 380; randomMaxGold = 420;
      
        chest7Name = Localization.StoneshieldChest;
        chestName.text = chest7Name;
        PlayerLevel.xpChestDrop = 25;

        reinforcedChestChance = 2.3f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        averageChestGoldSpawn = (randomMaxGold) * 8;
        //Debug.Log(averageChestGoldSpawn);

        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>7-9";

        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        quartz.SetActive(true);
        amethyst.SetActive(true);
        yellowTopaz.SetActive(true);
        albite.SetActive(true);
        redGarnet.SetActive(true);
        aquamarine.SetActive(true);

       
    }

    public void Chest7Price()
    {
        ChestHealth = 220000;
        chestPrice = 300000;
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest8Info
    public static double chest8Price;
    public static string chest8Name;
    public void SetChest8Info()
    {
        chestNumberName.text = Localization.chestNumber + "8" + Localization.chestNO;
        chest8.transform.localPosition = yPos48;
        chest8.transform.localScale = scale30;

        randomMinGold = 850; randomMaxGold = 950;

        chest8Name = Localization.OceanChest;
        chestName.text = chest8Name;
        PlayerLevel.xpChestDrop = 41;

        averageChestGoldSpawn = (randomMaxGold) * 8;
        //Debug.Log(averageChestGoldSpawn);

        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>7-9";

        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        reinforcedChestChance = 2.3f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        quartz.SetActive(true);
        amethyst.SetActive(true);
        yellowTopaz.SetActive(true);
        albite.SetActive(true);
        redGarnet.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);

      
    }

    public void Chest8Price()
    {
        ChestHealth = 500000;
        chestPrice = 1300000;
        chestPriceText.text = chestPrice + "";
    }

    #endregion

    #region Chest9Info
    public static double chest9Price;
    public static string chest9Name;

    public void SetChest9Info()
    {
        chestNumberName.text = Localization.chestNumber + "9" + Localization.chestNO;
        chest9.transform.localPosition = yPos48;
        chest9.transform.localScale = scale30;

        randomMinGold = 1800; randomMaxGold = 2000;

        chest9Name = Localization.PoisonousChest;
        chestName.text = chest9Name;
        PlayerLevel.xpChestDrop = 70;

        averageChestGoldSpawn = (randomMaxGold) * 10.5f;
        //Debug.Log(averageChestGoldSpawn);

        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>9-12";

        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        reinforcedChestChance = 2.2f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        quartz.SetActive(true);
        amethyst.SetActive(true);
        yellowTopaz.SetActive(true);
        albite.SetActive(true);
        redGarnet.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);

       
    }

    public void Chest9Price()
    {
        ChestHealth = 1700000;
        chestPrice = 5500000;
        chestPriceText.text = chestPrice + "";
    }

    #endregion

    #region Chest10Info
    public static double chest10Price;
    public static string chest10Name;

    public void SetChest10Info()
    {
        chestNumberName.text = Localization.chestNumber + "10" + Localization.chestNO;
        chest10.transform.localPosition = yPos32;
        chest10.transform.localScale = scale61;

        randomMinGold = 6500; randomMaxGold = 7250;
       

        chest10Name = Localization.GoldenChest;
        chestName.text = chest10Name;
        PlayerLevel.xpChestDrop = 135;

        averageChestGoldSpawn = (randomMaxGold) * 10.5f;
        //Debug.Log(averageChestGoldSpawn);

        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>9-12";

        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        reinforcedChestChance = 2.1f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        quartz.SetActive(true);
        albite.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);

       
    }

    public void Chest10Price()
    {
        ChestHealth = 13500000;
        chestPrice = 20000000;
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest11Info
    public static double chest11Price;
    public static string chest11Name;

    public void SetChest11Info()
    {
        chestNumberName.text = Localization.chestNumber + "11" + Localization.chestNO;
        chest11.transform.localPosition = yPos50;
        chest11.transform.localScale = scale29;

        randomMinGold = 15000; randomMaxGold = 17000;
       
        chest11Name = Localization.DesertChest;
        chestName.text = chest11Name;
        PlayerLevel.xpChestDrop = 250;

        averageChestGoldSpawn = (randomMaxGold) * 10.5f;
        //Debug.Log(averageChestGoldSpawn);

        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>9-12";

        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        reinforcedChestChance = 1.9f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        albite.SetActive(true);
        quartz.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);

      
    }

    public void Chest11Price()
    {
        ChestHealth = 88000000;
        chestPrice = 125000000;
        chestPriceText.text = chestPrice + "";
    }

    #endregion

    #region Chest12Info
    public static double chest12Price;
    public static string chest12Name;
    public void SetChest12Info()
    {
        chestNumberName.text = Localization.chestNumber + "12" + Localization.chestNO;
        chest12.transform.localPosition = yPos50;
        chest12.transform.localScale = scale327;

        randomMinGold = 44000; randomMaxGold = 53000;

        chest12Name = Localization.PirateChest;
        chestName.text = chest12Name;
        PlayerLevel.xpChestDrop = 615;

        averageChestGoldSpawn = (randomMaxGold) * 11.5f;
        //Debug.Log(averageChestGoldSpawn);

        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>10-13";

        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        reinforcedChestChance = 1.9f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        albite.SetActive(true);
        quartz.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);
        adventurine.SetActive(true);

       
    }
    public void Chest12Price()
    {
        ChestHealth = 240000000;
        chestPrice = 620000000;
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest13Info
    public static double chest13Price;
    public static string chest13Name;

    public void SetChest13Info()
    {
        chestNumberName.text = Localization.chestNumber + "13" + Localization.chestNO;
        chest13.transform.localPosition = yPos64;
        chest13.transform.localScale = scale327;

        randomMinGold = 520000; randomMaxGold = 560000;
        

        chest13Name = Localization.CrystalChest;
        chestName.text = chest13Name;
        PlayerLevel.xpChestDrop = 1400;

        averageChestGoldSpawn = (randomMaxGold) * 11.5f;
        //Debug.Log(averageChestGoldSpawn);

        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>10-13";

        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        reinforcedChestChance = 1.8f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        albite.SetActive(true);
        quartz.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);
        adventurine.SetActive(true);

      
    }
    public void Chest13Price()
    {
        ChestHealth = 2100000000;
        chestPrice = 3300000000;
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest14Info
    public static double chest14Price;
    public static string chest14Name;

    public void SetChest14Info()
    {
        chestNumberName.text = Localization.chestNumber + "14" + Localization.chestNO;
        chest14.transform.localPosition = yPos71;
        chest14.transform.localScale = scale281;

        randomMinGold = 7000000; randomMaxGold = 7600000;
        

        chest14Name = Localization.CelestialChest;
        chestName.text = chest14Name;
        PlayerLevel.xpChestDrop = 3500;

        averageChestGoldSpawn = (randomMaxGold) * 11.5f;
        //Debug.Log(TotalGoldAmount.FormatCoins(averageChestGoldSpawn));

        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>10-13";

        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        reinforcedChestChance = 1.6f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        quartz.SetActive(true);
        albite.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);
        adventurine.SetActive(true);
        redRuby.SetActive(true);

       
    }
    public void Chest14Price()
    {
        ChestHealth = 65000000000;
        chestPrice = 67000000000;
        chestPriceText.text = chestPrice + "";
    } 
    #endregion

    #region Chest15Info
    public static double chest15Price;
    public static string chest15Name;

    public void SetChest15Info()
    {
        chestNumberName.text = Localization.chestNumber + "15" + Localization.chestNO;
        chest15.transform.localPosition = yPos71;
        chest15.transform.localScale = scale281;

        randomMinGold = 350000000; randomMaxGold = 395000000;
      
        chest15Name = Localization.PhantomChest;
        chestName.text = chest15Name;
        PlayerLevel.xpChestDrop = 10000;

        averageChestGoldSpawn = (randomMaxGold) * 11.5f;
        //Debug.Log(TotalGoldAmount.FormatCoins(averageChestGoldSpawn));

        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>10-13";

        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        reinforcedChestChance = 1.6f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        albite.SetActive(true);
        quartz.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);
        adventurine.SetActive(true);
        redRuby.SetActive(true);
        diamond.SetActive(true);

      
    }
    public void Chest15Price()
    {
        ChestHealth = 1000000000000;
        chestPrice = 1450000000000;
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest16Info
    public static double chest16Price;
    public static string chest16Name;

    public void SetChest16Info()
    {
        chestNumberName.text = Localization.chestNumber + "16" + Localization.chestNO;
        chest16.transform.localPosition = yPos71;
        chest16.transform.localScale = scale281;

        randomMinGold = 19000000000; randomMaxGold = 20500000000;
       
        chest16Name = Localization.PrismaticChest;
        chestName.text = chest16Name;
        PlayerLevel.xpChestDrop = 43000;

        averageChestGoldSpawn = (randomMaxGold) * 11.5f;
        //Debug.Log(TotalGoldAmount.FormatCoins(averageChestGoldSpawn));

        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>10-13";

        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        reinforcedChestChance = 1.5f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        albite.SetActive(true);
        quartz.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);
        adventurine.SetActive(true);
        redRuby.SetActive(true);
        diamond.SetActive(true);
        grandidierite.SetActive(true);

      
    }
    public void Chest16Price()
    {
        ChestHealth = 93000000000000;
        chestPrice = 88000000000000;
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest17Info
    public static double chest17Price;
    public static string chest17Name;

    public void SetChest17Info()
    {
        chestNumberName.text = Localization.chestNumber + "17" + Localization.chestNO;
        chest17.transform.localPosition = yPos71;
        chest17.transform.localScale = scale281;

        randomMinGold = 450000000000; randomMaxGold = 500000000000;
      
        chest17Name = Localization.AquaticChest;
        chestName.text = chest17Name;
        PlayerLevel.xpChestDrop = 140000;

        averageChestGoldSpawn = (randomMaxGold) * 12.5f;
        //Debug.Log(TotalGoldAmount.FormatCoins(averageChestGoldSpawn));

        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>11-14";

        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        reinforcedChestChance = 1.4f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        albite.SetActive(true);
        quartz.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);
        adventurine.SetActive(true);
        redRuby.SetActive(true);
        diamond.SetActive(true);
        grandidierite.SetActive(true);

       
    }
    public void Chest17Price()
    {
        ChestHealth = 8000000000000000;
        chestPrice = 5600000000000000f;
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest18Info
    public static double chest18Price;
    public static string chest18Name;

    public void SetChest18Info()
    {
        chestNumberName.text = Localization.chestNumber + "18" + Localization.chestNO;
        chest18.transform.localPosition = yPos71;
        chest18.transform.localScale = scale281;
     
        randomMinGold = 43000000000000; randomMaxGold = 51000000000000;

        chest18Name = Localization.WindwalkersChest;
        chestName.text = chest18Name;
        PlayerLevel.xpChestDrop = 720000;

        averageChestGoldSpawn = (randomMaxGold) * 12.5f;
        //Debug.Log(TotalGoldAmount.FormatCoins(averageChestGoldSpawn));

        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>11-14";

        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        reinforcedChestChance = 1.3f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        albite.SetActive(true);
        quartz.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);
        adventurine.SetActive(true);
        redRuby.SetActive(true);
        diamond.SetActive(true);
        grandidierite.SetActive(true);
        violetCrystal.SetActive(true);

       
    }

    public void Chest18Price()
    {
        ChestHealth = 650000000000000000;
        chestPrice = 320000000000000000;
        chestPriceText.text = chestPrice + "";
    }

    #endregion

    #region Chest19Info
    public static double chest19Price;
    public static string chest19Name;

    public void SetChest19Info()
    {
        chestNumberName.text = Localization.chestNumber + "19" + Localization.chestNO;
        chest19.transform.localPosition = yPos60;
        chest19.transform.localScale = scale281;

        randomMinGold = 420000000000000; randomMaxGold = 460000000000000;

        chest19Name = Localization.EnchantedChest;
        chestName.text = chest19Name;
        PlayerLevel.xpChestDrop = 1700000;

        averageChestGoldSpawn = (randomMaxGold) * 12.5f;
        //Debug.Log(TotalGoldAmount.FormatCoins(averageChestGoldSpawn));

        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>11-14";

        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        reinforcedChestChance = 1.1f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        albite.SetActive(true);
        quartz.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);
        adventurine.SetActive(true);
        redRuby.SetActive(true);
        diamond.SetActive(true);
        grandidierite.SetActive(true);
        violetCrystal.SetActive(true);
        akoyaPearl.SetActive(true);
        purpleRupee.SetActive(true);
    }
    public void Chest19Price()
    {
        ChestHealth = 18000000000000000000f;
        chestPrice = 57000000000000000000f;
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest20Info
    public static double chest20Price;
    public static string chest20Name;

    public void SetChest20Info()
    {
        chestNumberName.text = Localization.chestNumber + "20" + Localization.chestNO;
        chest20.transform.localPosition = yPos60;
        chest20.transform.localScale = scale281;
      
        randomMinGold = 70000000000000000f; randomMaxGold = 75000000000000000f;

        chest20Name = Localization.RoyalChest;
        chestName.text = chest20Name;
        PlayerLevel.xpChestDrop = 5000000;

        averageChestGoldSpawn = (randomMaxGold) * 12.5f;
        //Debug.Log(TotalGoldAmount.FormatCoins(averageChestGoldSpawn));

        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>11-14";

        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        reinforcedChestChance = 1f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        albite.SetActive(true);
        quartz.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);
        adventurine.SetActive(true);
        redRuby.SetActive(true);
        diamond.SetActive(true);
        grandidierite.SetActive(true);
        violetCrystal.SetActive(true);
        akoyaPearl.SetActive(true);
        purpleRupee.SetActive(true);
        emerald.SetActive(true);

    }
    public void Chest20Price()
    {
        ChestHealth = 700000000000000000000f;
        chestPrice = 290000000000000000000f;
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest21Info
    public static double chest21Price;
    public static string chest21Name;

    public void SetChest21Info()
    {
        chestNumberName.text = Localization.chestNumber + "21" + Localization.chestNO;
        chest21.transform.localPosition = yPos60;
        chest21.transform.localScale = scale281;
      
        randomMinGold = 10000000000000000000f; randomMaxGold = 11500000000000000000f;

        chest21Name = Localization.ArcaneChest;
        chestName.text = chest21Name;
        PlayerLevel.xpChestDrop = 15000000;

        averageChestGoldSpawn = (randomMaxGold) * 12.5f;
        //Debug.Log(TotalGoldAmount.FormatCoins(averageChestGoldSpawn));

        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>11-14";

        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        reinforcedChestChance = 1f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        albite.SetActive(true);
        quartz.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);
        adventurine.SetActive(true);
        redRuby.SetActive(true);
        diamond.SetActive(true);
        grandidierite.SetActive(true);
        violetCrystal.SetActive(true);
        akoyaPearl.SetActive(true);
        purpleRupee.SetActive(true);
        emerald.SetActive(true);
        greenDiamond.SetActive(true);

      
    }
    public void Chest21Price()
    {
        ChestHealth = 40000000000000000000000f;
        chestPrice = 81000000000000000000000f;
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest22Info
    public static double chest22Price;
    public static string chest22Name;

    public void SetChest22Info()
    {
        chestNumberName.text = Localization.chestNumber + "22" + Localization.chestNO;
        chest22.transform.localPosition = yPos60;
        chest22.transform.localScale = scale281;

        randomMinGold = 600000000000000000000f; randomMaxGold = 715000000000000000000f;
        
        chest22Name = Localization.GrandioseChest;
        chestName.text = chest22Name;
        PlayerLevel.xpChestDrop = 40000000;

        averageChestGoldSpawn = (randomMaxGold) * 13.5f;
        //Debug.Log(TotalGoldAmount.FormatCoins(averageChestGoldSpawn));

        chestGoldCoinsText.text = Localization.GoldCoinsDrop + " <color=yellow>12-15";

        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        reinforcedChestChance = 0.9f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        albite.SetActive(true);
        quartz.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);
        adventurine.SetActive(true);
        redRuby.SetActive(true);
        diamond.SetActive(true);
        grandidierite.SetActive(true);
        violetCrystal.SetActive(true);
        akoyaPearl.SetActive(true);
        purpleRupee.SetActive(true);
        emerald.SetActive(true);
        greenDiamond.SetActive(true);
        fireOpal.SetActive(true);

      
    }
    public void Chest22Price()
    {
        ChestHealth = 7200000000000000000000000f;
        chestPrice = 20000000000000000000000000f;
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest23Info
    public static double chest23Price;
    public static string chest23Name;

    public void SetChest23Info()
    {
        chestNumberName.text = Localization.chestNumber + "23" + Localization.chestNO;
        chest23.transform.localPosition = yPos60;
        chest23.transform.localScale = scale276;

        randomMinGold = 15000000000000000000000f; randomMaxGold = 18500000000000000000000f;

        chest23Name = Localization.LuxuriousGoldenChest;
        chestName.text = chest23Name;

        PlayerLevel.xpChestDrop = 100000000;

        averageChestGoldSpawn = (randomMaxGold) * 13.5f;
        //Debug.Log(TotalGoldAmount.FormatCoins(averageChestGoldSpawn));

        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>12-15";

        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        reinforcedChestChance = 0.8f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        albite.SetActive(true);
        quartz.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);
        adventurine.SetActive(true);
        redRuby.SetActive(true);
        diamond.SetActive(true);
        grandidierite.SetActive(true);
        violetCrystal.SetActive(true);
        akoyaPearl.SetActive(true);
        purpleRupee.SetActive(true);
        emerald.SetActive(true);
        greenDiamond.SetActive(true);
        fireOpal.SetActive(true);
        gemSilica.SetActive(true);
        pinkPlort.SetActive(true);
    }
    public void Chest23Price()
    {
        ChestHealth = 270000000000000000000000000f;
        chestPrice = 720000000000000000000000000f;
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest24Info
    public static double chest24Price;
    public static string chest24Name;

    public void SetChest24Info()
    {
        chestNumberName.text = Localization.chestNumber + "24" + Localization.chestNO;
        chest24.transform.localPosition = yPos60;
        chest24.transform.localScale = scale276;
      
        randomMinGold = 190000000000000000000000f; randomMaxGold = 245000000000000000000000f;

        chest24Name = Localization.SacredChest;
        chestName.text = chest24Name;
        PlayerLevel.xpChestDrop = 200000000;

        averageChestGoldSpawn = (randomMaxGold) * 13.5f;
        //Debug.Log(TotalGoldAmount.FormatCoinsDouble(averageChestGoldSpawn));

        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>12-15";

        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        reinforcedChestChance = 0.7f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        albite.SetActive(true);
        quartz.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);
        adventurine.SetActive(true);
        redRuby.SetActive(true);
        diamond.SetActive(true);
        grandidierite.SetActive(true);
        violetCrystal.SetActive(true);
        akoyaPearl.SetActive(true);
        purpleRupee.SetActive(true);
        emerald.SetActive(true);
        greenDiamond.SetActive(true);
        fireOpal.SetActive(true);
        gemSilica.SetActive(true);
        pinkPlort.SetActive(true);
        goldenSeaPearl.SetActive(true);
        kyanite.SetActive(true);

      
    }
    public void Chest24Price()
    {
        ChestHealth = 10000000000000000000000000000f;
        chestPrice = 63000000000000000000000000000.5;
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest25Info
    public static double chest25Price;
    public static string chest25Name;
    public void SetChest25Info()
    {
        chestNumberName.text = Localization.chestNumber + "25" + Localization.chestNO;
        chest25.transform.localPosition = yPos60;
        chest25.transform.localScale = scale276;

        randomMinGold = 10000000000000000000000000f; randomMaxGold = 16500000000000000000000000f;

        chest25Name = Localization.EternitysEmbraceChest;
        chestName.text = chest25Name;
        PlayerLevel.xpChestDrop = 900000000;

        averageChestGoldSpawn = (randomMaxGold) * 13.5f;
        //Debug.Log(TotalGoldAmount.FormatCoinsDouble(averageChestGoldSpawn));

        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>12-15";

        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        reinforcedChestChance = 0.6f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        albite.SetActive(true);
        quartz.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);
        adventurine.SetActive(true);
        redRuby.SetActive(true);
        diamond.SetActive(true);
        grandidierite.SetActive(true);
        violetCrystal.SetActive(true);
        akoyaPearl.SetActive(true);
        purpleRupee.SetActive(true);
        emerald.SetActive(true);
        greenDiamond.SetActive(true);
        fireOpal.SetActive(true);
        gemSilica.SetActive(true);
        pinkPlort.SetActive(true);
        goldenSeaPearl.SetActive(true);
        kyanite.SetActive(true);
        blackOpal.SetActive(true);

       
    }
    public void Chest25Price()
    {
        ChestHealth = 350000000000000000000000000000f;
        chestPrice = 800000000000000000000000000000f;
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest26Info
    public static double chest26Price;
    public static string chest26Name;

    public void SetChest26Info()
    {
        chestNumberName.text = Localization.chestNumber + "26" + Localization.chestNO;
        chest26.transform.localPosition = yPos55;
        chest26.transform.localScale = scale322;

        randomMinGold = 90000000000000000000000000f; randomMaxGold = 120000000000000000000000000f;
       

        chest26Name = Localization.ForgottenChest;
        chestName.text = chest26Name;

        PlayerLevel.xpChestDrop = 1500000000;

        averageChestGoldSpawn = (randomMaxGold) * 13.5f;
        //Debug.Log(TotalGoldAmount.FormatCoinsDouble(averageChestGoldSpawn));

        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>12-15";
        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        reinforcedChestChance = 0.5f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        albite.SetActive(true);
        quartz.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);
        adventurine.SetActive(true);
        redRuby.SetActive(true);
        diamond.SetActive(true);
        grandidierite.SetActive(true);
        violetCrystal.SetActive(true);
        akoyaPearl.SetActive(true);
        purpleRupee.SetActive(true);
        emerald.SetActive(true);
        greenDiamond.SetActive(true);
        fireOpal.SetActive(true);
        gemSilica.SetActive(true);
        pinkPlort.SetActive(true);
        goldenSeaPearl.SetActive(true);
        kyanite.SetActive(true);
        blackOpal.SetActive(true);
        painite.SetActive(true);

    }
    public void Chest26Price()
    {
        ChestHealth = 11000000000000000000000000000000.5;
        chestPrice = 67000000000000000000000000000000.5;
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest27Info
    public static double chest27Price;
    public static string chest27Name;
    public void SetChest27Info()
    {
        chestNumberName.text = Localization.chestNumber + "27" + Localization.chestNO;
        chest27.transform.localPosition = yPos60;
        chest27.transform.localScale = scale325;
         
        randomMinGold = 1000000000000000000000000000f; randomMaxGold = 4500000000000000000000000000f;

        chest27Name = Localization.LivingLuminousChest;
        chestName.text = chest27Name;
        PlayerLevel.xpChestDrop = 20000000000;
        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>12-15";
        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        averageChestGoldSpawn = (randomMaxGold) * 13.5f;
        //Debug.Log(TotalGoldAmount.FormatCoinsDouble(averageChestGoldSpawn));

        reinforcedChestChance = 0.3f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        albite.SetActive(true);
        quartz.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);
        adventurine.SetActive(true);
        redRuby.SetActive(true);
        diamond.SetActive(true);
        grandidierite.SetActive(true);
        violetCrystal.SetActive(true);
        akoyaPearl.SetActive(true);
        purpleRupee.SetActive(true);
        emerald.SetActive(true);
        greenDiamond.SetActive(true);
        fireOpal.SetActive(true);
        gemSilica.SetActive(true);
        pinkPlort.SetActive(true);
        goldenSeaPearl.SetActive(true);
        kyanite.SetActive(true);
        blackOpal.SetActive(true);
        painite.SetActive(true);
        tanzanite.SetActive(true);
    }

    public void Chest27Price()
    {
        ChestHealth = 220000000000000000000000000000000f;
        chestPrice = 750000000000000000000000000000000f;
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest28Info
    public static double chest28Price;
    public static string chest28Name;
    public void SetChest28Info()
    {
        chestNumberName.text = Localization.chestNumber + "28" + Localization.chestNO;
        chest28.transform.localPosition = yPos60;  
        chest28.transform.localScale = scale325;   

        randomMaxGold = 70000000000000000000000000000f;

        chest28Name = Localization.FortressOfWealth;
        chestName.text = chest28Name;
        PlayerLevel.xpChestDrop = 90000000000;  
        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>12-15";
        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        averageChestGoldSpawn = (randomMaxGold) * 13.5f;
        //Debug.Log(TotalGoldAmount.FormatCoinsDouble(averageChestGoldSpawn));

        reinforcedChestChance = 0.3f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        albite.SetActive(true);
        quartz.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);
        adventurine.SetActive(true);
        redRuby.SetActive(true);
        diamond.SetActive(true);
        grandidierite.SetActive(true);
        violetCrystal.SetActive(true);
        akoyaPearl.SetActive(true);
        purpleRupee.SetActive(true);
        emerald.SetActive(true);
        greenDiamond.SetActive(true);
        fireOpal.SetActive(true);
        gemSilica.SetActive(true);
        pinkPlort.SetActive(true);
        goldenSeaPearl.SetActive(true);
        kyanite.SetActive(true);
        blackOpal.SetActive(true);
        painite.SetActive(true);
        tanzanite.SetActive(true);
    }

    public void Chest28Price()
    {
        ChestHealth = 6000000000000000000000000000000000f;  
        chestPrice = 45000000000000000000000000000000000.5;  
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest29Info
    public static double chest29Price;
    public static string chest29Name;
    public void SetChest29Info()
    {
        chestNumberName.text = Localization.chestNumber + "29" + Localization.chestNO;
        chest29.transform.localPosition = yPos58;
        chest29.transform.localScale = scale281;

        randomMaxGold = 3900000000000000000000000000000.5;

        chest29Name = Localization.FortifiedTimberChest;
        chestName.text = chest29Name;
        PlayerLevel.xpChestDrop = 220000000000; 
        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>12-15";
        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        averageChestGoldSpawn = (randomMaxGold) * 13.5f;
        //Debug.Log(TotalGoldAmount.FormatCoinsDouble(averageChestGoldSpawn));

        reinforcedChestChance = 0.3f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        albite.SetActive(true);
        quartz.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);
        adventurine.SetActive(true);
        redRuby.SetActive(true);
        diamond.SetActive(true);
        grandidierite.SetActive(true);
        violetCrystal.SetActive(true);
        akoyaPearl.SetActive(true);
        purpleRupee.SetActive(true);
        emerald.SetActive(true);
        greenDiamond.SetActive(true);
        fireOpal.SetActive(true);
        gemSilica.SetActive(true);
        pinkPlort.SetActive(true);
        goldenSeaPearl.SetActive(true);
        kyanite.SetActive(true);
        blackOpal.SetActive(true);
        painite.SetActive(true);
        tanzanite.SetActive(true);
        astralium.SetActive(true);
    }

    public void Chest29Price()
    {
        ChestHealth = 90000000000000000000000000000000000f;  
        chestPrice = 1000000000000000000000000000000000000.5; 
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest30Info
    public static double chest30Price;
    public static string chest30Name;
    public void SetChest30Info()
    {
        chestNumberName.text = Localization.chestNumber + "30" + Localization.chestNO;
        chest30.transform.localPosition = yPos60; 
        chest30.transform.localScale = scale325;

        randomMaxGold = 72000000000000000000000000000000.5;

        chest30Name = Localization.RadiantFrostlock;
        chestName.text = chest30Name;
        PlayerLevel.xpChestDrop = 800000000000;  
        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>13-16";
        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        averageChestGoldSpawn = (randomMaxGold) * 14.5f;
        //Debug.Log(TotalGoldAmount.FormatCoinsDouble(averageChestGoldSpawn));

        reinforcedChestChance = 0.3f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        albite.SetActive(true);
        quartz.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);
        adventurine.SetActive(true);
        redRuby.SetActive(true);
        diamond.SetActive(true);
        grandidierite.SetActive(true);
        violetCrystal.SetActive(true);
        akoyaPearl.SetActive(true);
        purpleRupee.SetActive(true);
        emerald.SetActive(true);
        greenDiamond.SetActive(true);
        fireOpal.SetActive(true);
        gemSilica.SetActive(true);
        pinkPlort.SetActive(true);
        goldenSeaPearl.SetActive(true);
        kyanite.SetActive(true);
        blackOpal.SetActive(true);
        painite.SetActive(true);
        tanzanite.SetActive(true);
        astralium.SetActive(true);
        elysiumPrism.SetActive(true);
    }

    public void Chest30Price()
    {
        ChestHealth = 3000000000000000000000000000000000000f;  
        chestPrice = 125000000000000000000000000000000000000.5; 
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest31Info
    public static double chest31Price;
    public static string chest31Name;
    public void SetChest31Info()
    {
        chestNumberName.text = Localization.chestNumber + "31" + Localization.chestNO;
        chest31.transform.localPosition = yPos60; 
        chest31.transform.localScale = scale325;

        randomMaxGold = 6000000000000000000000000000000000.5;

        chest31Name = Localization.InfernoEmbracedChest;
        chestName.text = chest31Name;
        PlayerLevel.xpChestDrop = 2000000000000; 
        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>13-16";
        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        averageChestGoldSpawn = (randomMaxGold) * 14.5f;
        //Debug.Log(TotalGoldAmount.FormatCoinsDouble(averageChestGoldSpawn));

        reinforcedChestChance = 0.25f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        albite.SetActive(true);
        quartz.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);
        adventurine.SetActive(true);
        redRuby.SetActive(true);
        diamond.SetActive(true);
        grandidierite.SetActive(true);
        violetCrystal.SetActive(true);
        akoyaPearl.SetActive(true);
        purpleRupee.SetActive(true);
        emerald.SetActive(true);
        greenDiamond.SetActive(true);
        fireOpal.SetActive(true);
        gemSilica.SetActive(true);
        pinkPlort.SetActive(true);
        goldenSeaPearl.SetActive(true);
        kyanite.SetActive(true);
        blackOpal.SetActive(true);
        painite.SetActive(true);
        tanzanite.SetActive(true);

        astralium.SetActive(true);
        elysiumPrism.SetActive(true);
        aerthfireOpal.SetActive(true);
    }

    public void Chest31Price()
    {
        ChestHealth = 190000000000000000000000000000000000000.5;  
        chestPrice = 3300000000000000000000000000000000000000.5; 
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest32Info
    public static double chest32Price;
    public static string chest32Name;
    public void SetChest32Info()
    {
        chestNumberName.text = Localization.chestNumber + "32" + Localization.chestNO;
        chest32.transform.localPosition = yPos60;  // Changed from chest30 to chest31
        chest32.transform.localScale = scale325;

        randomMaxGold = 83000000000000000000000000000000000.5;

        chest32Name = Localization.DeathChest;
        chestName.text = chest32Name;
        PlayerLevel.xpChestDrop = 25000000000000; 
        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>13-16";
        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        averageChestGoldSpawn = (randomMaxGold) * 14.5f;
        //Debug.Log(TotalGoldAmount.FormatCoinsDouble(averageChestGoldSpawn));

        reinforcedChestChance = 0.25f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        albite.SetActive(true);
        quartz.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);
        adventurine.SetActive(true);
        redRuby.SetActive(true);
        diamond.SetActive(true);
        grandidierite.SetActive(true);
        violetCrystal.SetActive(true);
        akoyaPearl.SetActive(true);
        purpleRupee.SetActive(true);
        emerald.SetActive(true);
        greenDiamond.SetActive(true);
        fireOpal.SetActive(true);
        gemSilica.SetActive(true);
        pinkPlort.SetActive(true);
        goldenSeaPearl.SetActive(true);
        kyanite.SetActive(true);
        blackOpal.SetActive(true);
        painite.SetActive(true);
        tanzanite.SetActive(true);

        astralium.SetActive(true);
        elysiumPrism.SetActive(true);
        aerthfireOpal.SetActive(true);
    }

    public void Chest32Price()
    {
        ChestHealth = 3330000000000000000000000000000000000000.5;  
        chestPrice = 420000000000000000000000000000000000000000.5; 
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest33Info
    public static double chest33Price;
    public static string chest33Name;
    public void SetChest33Info()
    {
        chestNumberName.text = Localization.chestNumber + "33" + Localization.chestNO;
        chest33.transform.localPosition = yPos60;
        chest33.transform.localScale = scale325;

        randomMaxGold = 11000000000000000000000000000000000000.5;

        chest33Name = Localization.AlienChest;
        chestName.text = chest33Name;
        PlayerLevel.xpChestDrop = 175000000000000;  
        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>13-16";
        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        averageChestGoldSpawn = (randomMaxGold) * 14.5f;
        //Debug.Log(TotalGoldAmount.FormatCoinsDouble(averageChestGoldSpawn)); ;

        reinforcedChestChance = 0.25f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        albite.SetActive(true);
        quartz.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);
        adventurine.SetActive(true);
        redRuby.SetActive(true);
        diamond.SetActive(true);
        grandidierite.SetActive(true);
        violetCrystal.SetActive(true);
        akoyaPearl.SetActive(true);
        purpleRupee.SetActive(true);
        emerald.SetActive(true);
        greenDiamond.SetActive(true);
        fireOpal.SetActive(true);
        gemSilica.SetActive(true);
        pinkPlort.SetActive(true);
        goldenSeaPearl.SetActive(true);
        kyanite.SetActive(true);
        blackOpal.SetActive(true);
        painite.SetActive(true);
        tanzanite.SetActive(true);
        astralium.SetActive(true);
        elysiumPrism.SetActive(true);
        aerthfireOpal.SetActive(true);
        eldrichStarstone.SetActive(true);
    }

    public void Chest33Price()
    {
        ChestHealth = 130000000000000000000000000000000000000000.5;  
        chestPrice = 8500000000000000000000000000000000000000000.5; 
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest34Info
    public static double chest34Price;
    public static string chest34Name;
    public void SetChest34Info()
    {
        chestNumberName.text = Localization.chestNumber + "34" + Localization.chestNO;
        chest34.transform.localPosition = yPos87;  
        chest34.transform.localScale = scale54;

        randomMaxGold = 777000000000000000000000000000000000000.5;

        chest34Name = Localization.CraftsmansReliquary;
        chestName.text = chest34Name;
        PlayerLevel.xpChestDrop = 680000000000000;  
        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>13-16";
        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        averageChestGoldSpawn = (randomMaxGold) * 14.5f;
        //Debug.Log(TotalGoldAmount.FormatCoinsDouble(averageChestGoldSpawn));

        reinforcedChestChance = 0.2f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        albite.SetActive(true);
        quartz.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);
        adventurine.SetActive(true);
        redRuby.SetActive(true);
        diamond.SetActive(true);
        grandidierite.SetActive(true);
        violetCrystal.SetActive(true);
        akoyaPearl.SetActive(true);
        purpleRupee.SetActive(true);
        emerald.SetActive(true);
        greenDiamond.SetActive(true);
        fireOpal.SetActive(true);
        gemSilica.SetActive(true);
        pinkPlort.SetActive(true);
        goldenSeaPearl.SetActive(true);
        kyanite.SetActive(true);
        blackOpal.SetActive(true);
        painite.SetActive(true);
        tanzanite.SetActive(true);
        astralium.SetActive(true);
        elysiumPrism.SetActive(true);
        aerthfireOpal.SetActive(true);
        eldrichStarstone.SetActive(true);
        chronolithShard.SetActive(true);
    }

    public void Chest34Price()
    {
        ChestHealth = 10000000000000000000000000000000000000000000.5;  
        chestPrice = 1500000000000000000000000000000000000000000000.5; 
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest35Info
    public static double chest35Price;
    public static string chest35Name;
    public void SetChest35Info()
    {
        chestNumberName.text = Localization.chestNumber + "35" + Localization.chestNO;
        chest35.transform.localPosition = yPos64; 
        chest35.transform.localScale = scale54;

        randomMaxGold = 43000000000000000000000000000000000000000.5;

        chest35Name = Localization.HellfireGuardianChest;
        chestName.text = chest35Name;
        PlayerLevel.xpChestDrop = 3500000000000000;  
        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>13-16";
        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        averageChestGoldSpawn = (randomMaxGold) * 14.5f;
        //Debug.Log(TotalGoldAmount.FormatCoinsDouble(averageChestGoldSpawn));

        reinforcedChestChance = 0.2f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        albite.SetActive(true);
        quartz.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);
        adventurine.SetActive(true);
        redRuby.SetActive(true);
        diamond.SetActive(true);
        grandidierite.SetActive(true);
        violetCrystal.SetActive(true);
        akoyaPearl.SetActive(true);
        purpleRupee.SetActive(true);
        emerald.SetActive(true);
        greenDiamond.SetActive(true);
        fireOpal.SetActive(true);
        gemSilica.SetActive(true);
        pinkPlort.SetActive(true);
        goldenSeaPearl.SetActive(true);
        kyanite.SetActive(true);
        blackOpal.SetActive(true);
        painite.SetActive(true);
        tanzanite.SetActive(true);
        astralium.SetActive(true);
        elysiumPrism.SetActive(true);
        aerthfireOpal.SetActive(true);
        eldrichStarstone.SetActive(true);
        chronolithShard.SetActive(true);
        sideriumEssence.SetActive(true);
    }

    public void Chest35Price()
    {
        ChestHealth = 330000000000000000000000000000000000000000000.5;  
        chestPrice = 140000000000000000000000000000000000000000000000.5; 
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest36Info
    public static double chest36Price;
    public static string chest36Name;
    public void SetChest36Info()
    {
        chestNumberName.text = Localization.chestNumber + "36" + Localization.chestNO;
        chest36.transform.localPosition = yPos87;
        chest36.transform.localScale = scale54;

        randomMaxGold = 2000000000000000000000000000000000000000000.5;

        chest36Name = Localization.GhastlySoulHoardChest;
        chestName.text = chest36Name;
        PlayerLevel.xpChestDrop = 61000000000000000; 
        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>14-17";
        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        averageChestGoldSpawn = (randomMaxGold) * 15.5f;
        //Debug.Log(TotalGoldAmount.FormatCoinsDouble(averageChestGoldSpawn));

        reinforcedChestChance = 0.2f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        albite.SetActive(true);
        quartz.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);
        adventurine.SetActive(true);
        redRuby.SetActive(true);
        diamond.SetActive(true);
        grandidierite.SetActive(true);
        violetCrystal.SetActive(true);
        akoyaPearl.SetActive(true);
        purpleRupee.SetActive(true);
        emerald.SetActive(true);
        greenDiamond.SetActive(true);
        fireOpal.SetActive(true);
        gemSilica.SetActive(true);
        pinkPlort.SetActive(true);
        goldenSeaPearl.SetActive(true);
        kyanite.SetActive(true);
        blackOpal.SetActive(true);
        painite.SetActive(true);
        tanzanite.SetActive(true);
        astralium.SetActive(true);
        elysiumPrism.SetActive(true);
        aerthfireOpal.SetActive(true);
        eldrichStarstone.SetActive(true);
        chronolithShard.SetActive(true);
        sideriumEssence.SetActive(true);
        quasarite.SetActive(true);
    }

    public void Chest36Price()
    {
        ChestHealth = 36000000000000000000000000000000000000000000000.5;  
        chestPrice = 11000000000000000000000000000000000000000000000000.5; 
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest37Info
    public static double chest37Price;
    public static string chest37Name;
    public void SetChest37Info()
    {
        chestNumberName.text = Localization.chestNumber + "37" + Localization.chestNO;
        chest37.transform.localPosition = yPos75;  
        chest37.transform.localScale = scale5;

        randomMaxGold = 290000000000000000000000000000000000000000000.5;

        chest37Name = Localization.HighTechCache;
        chestName.text = chest37Name;
        PlayerLevel.xpChestDrop = 200000000000000000;  
        chestGoldCoinsText.text = Localization.GoldCoinsDrop + " <color=yellow>14-17";
        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        averageChestGoldSpawn = (randomMaxGold) * 15.5f;
        //Debug.Log(TotalGoldAmount.FormatCoinsDouble(averageChestGoldSpawn));

        reinforcedChestChance = 0.15f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        albite.SetActive(true);
        quartz.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);
        adventurine.SetActive(true);
        redRuby.SetActive(true);
        diamond.SetActive(true);
        grandidierite.SetActive(true);
        violetCrystal.SetActive(true);
        akoyaPearl.SetActive(true);
        purpleRupee.SetActive(true);
        emerald.SetActive(true);
        greenDiamond.SetActive(true);
        fireOpal.SetActive(true);
        gemSilica.SetActive(true);
        pinkPlort.SetActive(true);
        goldenSeaPearl.SetActive(true);
        kyanite.SetActive(true);
        blackOpal.SetActive(true);
        painite.SetActive(true);
        tanzanite.SetActive(true);

        astralium.SetActive(true);
        elysiumPrism.SetActive(true);
        aerthfireOpal.SetActive(true);
        eldrichStarstone.SetActive(true);
        chronolithShard.SetActive(true);
        sideriumEssence.SetActive(true);
        quasarite.SetActive(true);
        riadiantNovaStone.SetActive(true);
    }

    public void Chest37Price()
    {
        ChestHealth = 520000000000000000000000000000000000000000000000.5;  
        chestPrice = 700000000000000000000000000000000000000000000000000.5; 
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest38Info
    public static double chest38Price;
    public static string chest38Name;
    public void SetChest38Info()
    {
        chestNumberName.text = Localization.chestNumber + "38" + Localization.chestNO;
        chest38.transform.localPosition = yPos75;
        chest38.transform.localScale = scale5;

        randomMaxGold = 45000000000000000000000000000000000000000000000.5;

        chest38Name = Localization.EliteHackersStrongbox;
        chestName.text = chest38Name;
        PlayerLevel.xpChestDrop = 950000000000000000;  
        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>14-17";
        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        averageChestGoldSpawn = (randomMaxGold) * 15.5f;
        //Debug.Log(TotalGoldAmount.FormatCoinsDouble(averageChestGoldSpawn));

        reinforcedChestChance = 0.15f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        albite.SetActive(true);
        quartz.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);
        adventurine.SetActive(true);
        redRuby.SetActive(true);
        diamond.SetActive(true);
        grandidierite.SetActive(true);
        violetCrystal.SetActive(true);
        akoyaPearl.SetActive(true);
        purpleRupee.SetActive(true);
        emerald.SetActive(true);
        greenDiamond.SetActive(true);
        fireOpal.SetActive(true);
        gemSilica.SetActive(true);
        pinkPlort.SetActive(true);
        goldenSeaPearl.SetActive(true);
        kyanite.SetActive(true);
        blackOpal.SetActive(true);
        painite.SetActive(true);
        tanzanite.SetActive(true);
        astralium.SetActive(true);
        elysiumPrism.SetActive(true);
        aerthfireOpal.SetActive(true);
        eldrichStarstone.SetActive(true);
        chronolithShard.SetActive(true);
        sideriumEssence.SetActive(true);
        quasarite.SetActive(true);
        riadiantNovaStone.SetActive(true);
        soluniumShard.SetActive(true);
    }

    public void Chest38Price()
    {
        ChestHealth = 68000000000000000000000000000000000000000000000000.5;  
        chestPrice = 200000000000000000000000000000000000000000000000000000.5; 
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest39Info
    public static double chest39Price;
    public static string chest39Name;
    public void SetChest39Info()
    {
        chestNumberName.text = Localization.chestNumber + "39" + Localization.chestNO;
        chest39.transform.localPosition = yPos75;
        chest39.transform.localScale = scale5;

        randomMaxGold = 24000000000000000000000000000000000000000000000000.5;

        chest39Name = Localization.CollectorsVault;
        chestName.text = chest39Name;
        PlayerLevel.xpChestDrop = 6000000000000000000; 
        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>14-17";
        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        averageChestGoldSpawn = (randomMaxGold) * 15.5f;
        //Debug.Log(TotalGoldAmount.FormatCoinsDouble(averageChestGoldSpawn));

        reinforcedChestChance = 0.1f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        albite.SetActive(true);
        quartz.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);
        adventurine.SetActive(true);
        redRuby.SetActive(true);
        diamond.SetActive(true);
        grandidierite.SetActive(true);
        violetCrystal.SetActive(true);
        akoyaPearl.SetActive(true);
        purpleRupee.SetActive(true);
        emerald.SetActive(true);
        greenDiamond.SetActive(true);
        fireOpal.SetActive(true);
        gemSilica.SetActive(true);
        pinkPlort.SetActive(true);
        goldenSeaPearl.SetActive(true);
        kyanite.SetActive(true);
        blackOpal.SetActive(true);
        painite.SetActive(true);
        tanzanite.SetActive(true);
        astralium.SetActive(true);
        elysiumPrism.SetActive(true);
        aerthfireOpal.SetActive(true);
        eldrichStarstone.SetActive(true);
        chronolithShard.SetActive(true);
        sideriumEssence.SetActive(true);
        quasarite.SetActive(true);
        riadiantNovaStone.SetActive(true);
        soluniumShard.SetActive(true);
    }

    public void Chest39Price()
    {
        ChestHealth = 900000000000000000000000000000000000000000000000000.5;  
        chestPrice = 35000000000000000000000000000000000000000000000000000000.5;  
        chestPriceText.text = chestPrice + "";
    }
    #endregion

    #region Chest40Info
    public static double chest40Price;
    public static string chest40Name;
    public void SetChest40Info()
    {
        chestNumberName.text = Localization.chestNumber + "40" + Localization.chestNO;
        chest40.transform.localPosition = yPos75;
        chest40.transform.localScale = scale5;

        randomMaxGold = 20000000000000000000000000000000000000000000000000000.5;

        chest40Name = Localization.ExquisiteAzureRadianceChest;
        chestName.text = chest40Name;
        PlayerLevel.xpChestDrop = 60000000000000000000f;  
        chestGoldCoinsText.text = Localization.GoldCoinsDrop + "<color=yellow>14-17";
        chestGoldDropInfo.text = Localization.goldCoinValue + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(randomMaxGold) + Localization.gold;
        chestXPDropInfo.text = Localization.XPDrop + "<color=#FFAD00>" + TotalGoldAmount.FormatCoins(PlayerLevel.xpChestDrop);

        averageChestGoldSpawn = (randomMaxGold) * 15.5f;
        //Debug.Log(TotalGoldAmount.FormatCoinsDouble(averageChestGoldSpawn));

        reinforcedChestChance = 0.1f + UpdateGame.reinforcedPrestigeChanceIncrease + RareTreasures.envelopeReinforcedChance;
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;

        albite.SetActive(true);
        quartz.SetActive(true);
        amethyst.SetActive(true);
        redGarnet.SetActive(true);
        yellowTopaz.SetActive(true);
        aquamarine.SetActive(true);
        yellowSapphire.SetActive(true);
        pinkTourmaline.SetActive(true);
        adventurine.SetActive(true);
        redRuby.SetActive(true);
        diamond.SetActive(true);
        grandidierite.SetActive(true);
        violetCrystal.SetActive(true);
        akoyaPearl.SetActive(true);
        purpleRupee.SetActive(true);
        emerald.SetActive(true);
        greenDiamond.SetActive(true);
        fireOpal.SetActive(true);
        gemSilica.SetActive(true);
        pinkPlort.SetActive(true);
        goldenSeaPearl.SetActive(true);
        kyanite.SetActive(true);
        blackOpal.SetActive(true);
        painite.SetActive(true);
        tanzanite.SetActive(true);
        astralium.SetActive(true);
        elysiumPrism.SetActive(true);
        aerthfireOpal.SetActive(true);
        eldrichStarstone.SetActive(true);
        chronolithShard.SetActive(true);
        sideriumEssence.SetActive(true);
        quasarite.SetActive(true);
        riadiantNovaStone.SetActive(true);
        soluniumShard.SetActive(true);
    }

    public void Chest40Price()
    {
        ChestHealth = 1500000000000000000000000000000000000000000000000000000.5;  
        chestPrice = 50000000000000000000000000000000000000000000000000000000000.5; 
        chestPriceText.text = chestPrice + "";
    }
    #endregion


    public void CurrentReinforcedChance()
    {
        reinforcedChestChanceText.text = reinforcedChestChance + RareTreasures.envelopeReinforcedChance / 100f * 100 + "%<color=white> Reinforced chest chance";
    }

    public void CurrentMiniChestGold()
    {
        currentMiniChestGoldValue = (randomMaxGold);
    }

    public static bool checkOverlap;

    public void SetAllGemsInactive()
    {
        checkOverlap = true;

        redRuby.SetActive(false);
        amethyst.SetActive(false);
        diamond.SetActive(false);
        violetCrystal.SetActive(false);
        yellowSapphire.SetActive(false);
        greenDiamond.SetActive(false);
        grandidierite.SetActive(false);
        purpleRupee.SetActive(false);
        pinkPlort.SetActive(false);
        emerald.SetActive(false);
        quartz.SetActive(false);
        redGarnet.SetActive(false);
        pinkTourmaline.SetActive(false);
        yellowTopaz.SetActive(false);
        aquamarine.SetActive(false);
        fireOpal.SetActive(false);
        goldenSeaPearl.SetActive(false);
        akoyaPearl.SetActive(false);
        gemSilica.SetActive(false);
        adventurine.SetActive(false);
        kyanite.SetActive(false);
        albite.SetActive(false);
        blackOpal.SetActive(false);
        painite.SetActive(false);
        tanzanite.SetActive(false);
        astralium.SetActive(false);
        elysiumPrism.SetActive(false);
        aerthfireOpal.SetActive(false);
        eldrichStarstone.SetActive(false);
        chronolithShard.SetActive(false);
        sideriumEssence.SetActive(false);
        quasarite.SetActive(false);
        riadiantNovaStone.SetActive(false);
        soluniumShard.SetActive(false);
    }

    public static bool changesChest;
    public GameObject reinforcedChest;
    public static bool returnText;
    public GameObject enchantedChest, bossChest, enchantedChestPopUp, bossChestPopUp;

    IEnumerator waiting()
    {
        yield return new WaitForSeconds(0.1f);
        returnText = false;
    }

    public void CheckChestText()
    {
        if(chest1Active == true) { SetChest1Info(); }
        if (chest2Active == true) { SetChest2Info(); }
        if (chest3Active == true) { SetChest3Info(); }
        if (chest4Active == true) { SetChest4Info(); }
        if (chest5Active == true) { SetChest5Info(); }
        if (chest6Active == true) { SetChest6Info(); }
        if (chest7Active == true) { SetChest7Info(); }
        if (chest8Active == true) { SetChest8Info(); }
        if (chest9Active == true) { SetChest9Info(); }
        if (chest10Active == true) { SetChest10Info(); }
        if (chest11Active == true) { SetChest11Info(); }
        if (chest12Active == true) { SetChest12Info(); }
        if (chest13Active == true) { SetChest13Info(); }
        if (chest14Active == true) { SetChest14Info(); }
        if (chest15Active == true) { SetChest15Info(); }
        if (chest16Active == true) { SetChest16Info(); }
        if (chest17Active == true) { SetChest17Info(); }
        if (chest18Active == true) { SetChest18Info(); }
        if (chest19Active == true) { SetChest19Info(); }
        if (chest20Active == true) { SetChest20Info(); }
        if (chest21Active == true) { SetChest21Info(); }
        if (chest22Active == true) { SetChest22Info(); }
        if (chest23Active == true) { SetChest23Info(); }
        if (chest24Active == true) { SetChest24Info(); }
        if (chest25Active == true) { SetChest25Info(); }
        if (chest26Active == true) { SetChest26Info(); }
        if (chest27Active == true) { SetChest27Info(); }
        if (chest28Active == true) { SetChest28Info(); }
        if (chest29Active == true) { SetChest29Info(); }
        if (chest30Active == true) { SetChest30Info(); }
        if (chest31Active == true) { SetChest31Info(); }
        if (chest32Active == true) { SetChest32Info(); }
        if (chest33Active == true) { SetChest33Info(); }
        if (chest34Active == true) { SetChest34Info(); }
        if (chest35Active == true) { SetChest35Info(); }
        if (chest36Active == true) { SetChest36Info(); }
        if (chest37Active == true) { SetChest37Info(); }
        if (chest38Active == true) { SetChest38Info(); }
        if (chest39Active == true) { SetChest39Info(); }
        if (chest40Active == true) { SetChest40Info(); }

        if(isAutoPurchaseOn == true) { onOffText.text = Localization.ON; onOffText.color = Color.green; }
        if (isAutoPurchaseOn == false) { onOffText.text = Localization.OFF; onOffText.color = Color.red; }
    }

    public void SetEverythingElseFalse()
    {
        HealthBar.enchantedGoldenChestIsActive = false; HealthBar.bossChestIsActive = false;

        enchantedChest.SetActive(false); bossChest.SetActive(false);
        enchantedChestPopUp.SetActive(false); bossChestPopUp.SetActive(false);
        returnText = true;
        StartCoroutine(waiting());

        chest2Price = 220;
        chest3Price = 1000;
        chest4Price = 7000;
        chest5Price = 23000;
        chest6Price = 85000;
        chest7Price = 300000;
        chest8Price = 1300000;
        chest9Price = 5500000;
        chest10Price = 20000000;
        chest11Price = 125000000;
        chest12Price = 620000000;
        chest13Price = 3300000000;
        chest14Price = 67000000000;
        chest15Price = 1450000000000;
        chest16Price = 88000000000000;
        chest17Price = 5600000000000000f;
        chest18Price = 320000000000000000;
        chest19Price = 57000000000000000000f;
        chest20Price = 290000000000000000000f;
        chest21Price = 81000000000000000000000f;
        chest22Price = 20000000000000000000000000f;
        chest23Price = 720000000000000000000000000f;
        chest24Price = 63000000000000000000000000000.5;
        chest25Price = 800000000000000000000000000000.5;
        chest26Price = 67000000000000000000000000000000.5;
        chest27Price = 750000000000000000000000000000000.5;
        chest28Price = 45000000000000000000000000000000000.5;
        chest29Price = 1000000000000000000000000000000000000.5;
        chest30Price = 125000000000000000000000000000000000000.5;
        chest31Price = 3300000000000000000000000000000000000000.5;
        chest32Price = 420000000000000000000000000000000000000000.5;
        chest33Price = 8500000000000000000000000000000000000000000.5;
        chest34Price = 1500000000000000000000000000000000000000000000.5;
        chest35Price = 140000000000000000000000000000000000000000000000.5;
        chest36Price = 11000000000000000000000000000000000000000000000000.5;
        chest37Price = 700000000000000000000000000000000000000000000000000.5;
        chest38Price = 200000000000000000000000000000000000000000000000000000.5;
        chest39Price = 35000000000000000000000000000000000000000000000000000000.5;
        chest40Price = 50000000000000000000000000000000000000000000000000000000000.5;

        //Debug.Log(TotalGoldAmount.FormatCoinsDouble(chest27Price));


        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("UIClick1"); }

        chestPriceText.text = TotalGoldAmount.FormatCoinsDoubleOneLetter(chestPrice);

        prestigeKeyDropChance.text = Localization.prestigeKeyChance1 + 0.017 * (UnlockChests.timesPurchasedChests + 1) + Localization.prestigeKeyChance2;
        prestigeChestDropChance.text = Localization.prestieChestKey1 + 0.017 * (UnlockChests.timesPurchasedChests +1) + Localization.prestieChestKey2;

        HealthBar.reinforcedChestActive = false;
        reinforcedChest.SetActive(false);
        reinforcedChestChanceText.text = Localization.reinforcedChestChance1 + reinforcedChestChance / 100f * 100 + "%<color=white>" + Localization.reinforcedChestChance2;


        changeChest = true;
        changesChest = true;
        //Chest False
        chest1.SetActive(false); chest2.SetActive(false); chest3.SetActive(false); chest4.SetActive(false); chest5.SetActive(false);
        chest6.SetActive(false); chest7.SetActive(false); chest8.SetActive(false); chest9.SetActive(false); chest10.SetActive(false);
        chest11.SetActive(false); chest12.SetActive(false); chest13.SetActive(false); chest14.SetActive(false); chest15.SetActive(false);
        chest16.SetActive(false); chest17.SetActive(false); chest18.SetActive(false); chest19.SetActive(false); chest20.SetActive(false);
        chest21.SetActive(false); chest22.SetActive(false); chest23.SetActive(false); chest24.SetActive(false); chest25.SetActive(false);
        chest26.SetActive(false); chest27.SetActive(false);  chest28.SetActive(false);  chest29.SetActive(false); chest30.SetActive(false); chest31.SetActive(false); chest32.SetActive(false); chest33.SetActive(false); chest34.SetActive(false); chest35.SetActive(false); chest36.SetActive(false); chest37.SetActive(false); chest38.SetActive(false); chest39.SetActive(false); chest40.SetActive(false);


        //ArrowsNext False
        arrowNextChest1.SetActive(false); arrowNextChest2.SetActive(false); arrowNextChest3.SetActive(false);
        arrowNextChest4.SetActive(false); arrowNextChest5.SetActive(false); arrowNextChest6.SetActive(false);
        arrowNextChest7.SetActive(false); arrowNextChest8.SetActive(false); arrowNextChest9.SetActive(false);
        arrowNextChest10.SetActive(false); arrowNextChest11.SetActive(false); arrowNextChest12.SetActive(false);
        arrowNextChest13.SetActive(false); arrowNextChest14.SetActive(false); arrowNextChest15.SetActive(false);
        arrowNextChest16.SetActive(false); arrowNextChest17.SetActive(false); arrowNextChest18.SetActive(false);
        arrowNextChest19.SetActive(false); arrowNextChest20.SetActive(false); arrowNextChest21.SetActive(false);
        arrowNextChest22.SetActive(false); arrowNextChest23.SetActive(false); arrowNextChest24.SetActive(false);
        arrowNextChest25.SetActive(false); arrowNextChest26.SetActive(false); arrowNextChest27.SetActive(false);
        arrowNextChest28.SetActive(false); arrowNextChest29.SetActive(false); arrowNextChest30.SetActive(false);
        arrowNextChest31.SetActive(false); arrowNextChest32.SetActive(false); arrowNextChest33.SetActive(false);
        arrowNextChest34.SetActive(false); arrowNextChest35.SetActive(false); arrowNextChest36.SetActive(false);
        arrowNextChest37.SetActive(false); arrowNextChest38.SetActive(false); arrowNextChest39.SetActive(false);

        #region arrowSize
        arrowNextChest1.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest2.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest3.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest4.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest5.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest6.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest7.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest8.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest9.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest10.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest11.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest12.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest13.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest14.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest15.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest16.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest17.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest18.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest19.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest20.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest21.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest22.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest23.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest24.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest25.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest26.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest27.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest28.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest29.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest30.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest31.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest32.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest33.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest34.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest35.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest36.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest37.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest38.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest39.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest2.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest3.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest4.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest5.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest6.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest7.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest8.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest9.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest10.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest11.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest12.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest13.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest14.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest15.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest16.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest17.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest18.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest19.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest20.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest21.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest22.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest23.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest24.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest25.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest26.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest27.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest28.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest29.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest30.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest31.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest32.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest33.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest34.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest35.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest36.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest37.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest38.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest39.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest40.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        #endregion

        //ArrowsBack False
        arrowBackChest2.SetActive(false); arrowBackChest3.SetActive(false); arrowBackChest4.SetActive(false);
        arrowBackChest5.SetActive(false); arrowBackChest6.SetActive(false); arrowBackChest7.SetActive(false);
        arrowBackChest8.SetActive(false); arrowBackChest9.SetActive(false); arrowBackChest10.SetActive(false);
        arrowBackChest11.SetActive(false); arrowBackChest12.SetActive(false); arrowBackChest13.SetActive(false);
        arrowBackChest14.SetActive(false); arrowBackChest15.SetActive(false); arrowBackChest16.SetActive(false);
        arrowBackChest17.SetActive(false); arrowBackChest18.SetActive(false); arrowBackChest19.SetActive(false);
        arrowBackChest20.SetActive(false); arrowBackChest21.SetActive(false); arrowBackChest22.SetActive(false);
        arrowBackChest23.SetActive(false); arrowBackChest24.SetActive(false); arrowBackChest25.SetActive(false);
        arrowBackChest26.SetActive(false); arrowBackChest27.SetActive(false); arrowBackChest28.SetActive(false);
        arrowBackChest29.SetActive(false); arrowBackChest30.SetActive(false); arrowBackChest31.SetActive(false);
        arrowBackChest32.SetActive(false); arrowBackChest33.SetActive(false); arrowBackChest34.SetActive(false);
        arrowBackChest35.SetActive(false); arrowBackChest36.SetActive(false); arrowBackChest37.SetActive(false);
        arrowBackChest38.SetActive(false); arrowBackChest39.SetActive(false); arrowBackChest40.SetActive(false);


        //Set all chests inactive
        chest1Active = false; chest2Active = false; chest3Active = false; chest4Active = false; chest5Active = false;
        chest6Active = false; chest7Active = false; chest8Active = false; chest9Active = false; chest10Active = false;
        chest11Active = false; chest12Active = false; chest13Active = false; chest14Active = false; chest15Active = false;
        chest16Active = false; chest17Active = false; chest18Active = false; chest19Active = false; chest20Active = false;
        chest21Active = false; chest22Active = false; chest23Active = false; chest24Active = false; chest25Active = false;
        chest26Active = false; chest27Active = false; chest28Active = false; chest29Active = false; chest30Active = false; chest31Active = false; chest32Active = false; chest33Active = false; chest34Active = false; chest35Active = false; chest36Active = false; chest37Active = false; chest38Active = false; chest39Active = false; chest40Active = false;

        changeChest = false;
    }

    
    public void changeColor()
    {
        Color newColor;
        ColorUtility.TryParseHtmlString(newHexValue, out newColor);
        if (RareDropsCollected.RedGemCount > 0) { redRuby.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.amethystCount > 0) { amethyst.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.diamondCount > 0) { diamond.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.violetCrystalCount > 0) { violetCrystal.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.yellowSapphireCount > 0) { yellowSapphire.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.greenDiamondCount > 0) { greenDiamond.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.grandidieriteCount > 0) { grandidierite.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.purpleRupeeCount > 0) { purpleRupee.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.pinkPlostCount > 0) { pinkPlort.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.emeraldCount > 0) { emerald.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.quartzCount > 0) { quartz.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.redGarnetCount > 0) { redGarnet.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.pinkTourmalineCount > 0) { pinkTourmaline.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.yellowTopazCount > 0) { yellowTopaz.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.aquamarineCount > 0) { aquamarine.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.fireOpalCount > 0) { fireOpal.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.goldeSeaPearlCount > 0) { goldenSeaPearl.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.akoyaPearlCount > 0) { akoyaPearl.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.gemSilicaCount > 0) { gemSilica.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.AdventurineCount > 0) { adventurine.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.kyaniteCount > 0) { kyanite.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.albiteCount > 0) { albite.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.blackOpalCount > 0) { blackOpal.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.painiteCount > 0) { painite.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.TanzaniteCount > 0) { tanzanite.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.astraliumCount > 0) { astralium.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.elysiumPrismCount > 0) { elysiumPrism.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.aetherfireOpalCount > 0) { aerthfireOpal.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.eldritchStarstoneCount > 0) { eldrichStarstone.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.chronolithShardCount > 0) { chronolithShard.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.sideriumEssenceCount > 0) { sideriumEssence.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.quasariteCount > 0) { quasarite.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.radiantNovaStoneCount > 0) { riadiantNovaStone.GetComponent<Image>().color = newColor; }
        if (RareDropsCollected.soluniumShardCount > 0) { soluniumShard.GetComponent<Image>().color = newColor; }
    }

    public void ResetButton()
    {

        #region Set chests and arrows false
        chestPriceText.text = TotalGoldAmount.FormatCoinsDoubleOneLetter(chestPrice);
        changeChest = true;
        changesChest = true;
        //Chest False
        chest1.SetActive(false); chest2.SetActive(false); chest3.SetActive(false); chest4.SetActive(false); chest5.SetActive(false);
        chest6.SetActive(false); chest7.SetActive(false); chest8.SetActive(false); chest9.SetActive(false); chest10.SetActive(false);
        chest11.SetActive(false); chest12.SetActive(false); chest13.SetActive(false); chest14.SetActive(false); chest15.SetActive(false);
        chest16.SetActive(false); chest17.SetActive(false); chest18.SetActive(false); chest19.SetActive(false); chest20.SetActive(false);
        chest21.SetActive(false); chest22.SetActive(false); chest23.SetActive(false); chest24.SetActive(false); chest25.SetActive(false);
        chest26.SetActive(false); chest27.SetActive(false); chest28.SetActive(false); chest29.SetActive(false); chest30.SetActive(false); chest31.SetActive(false); chest32.SetActive(false); chest33.SetActive(false); chest34.SetActive(false); chest35.SetActive(false); chest36.SetActive(false); chest37.SetActive(false); chest38.SetActive(false); chest39.SetActive(false); chest40.SetActive(false);

        

        //ArrowsNext False
        arrowNextChest1.SetActive(false); arrowNextChest2.SetActive(false); arrowNextChest3.SetActive(false);
        arrowNextChest4.SetActive(false); arrowNextChest5.SetActive(false); arrowNextChest6.SetActive(false);
        arrowNextChest7.SetActive(false); arrowNextChest8.SetActive(false); arrowNextChest9.SetActive(false);
        arrowNextChest10.SetActive(false); arrowNextChest11.SetActive(false); arrowNextChest12.SetActive(false);
        arrowNextChest13.SetActive(false); arrowNextChest14.SetActive(false); arrowNextChest15.SetActive(false);
        arrowNextChest16.SetActive(false); arrowNextChest17.SetActive(false); arrowNextChest18.SetActive(false);
        arrowNextChest19.SetActive(false); arrowNextChest20.SetActive(false); arrowNextChest21.SetActive(false);
        arrowNextChest22.SetActive(false); arrowNextChest23.SetActive(false); arrowNextChest24.SetActive(false);
        arrowNextChest25.SetActive(false); arrowNextChest26.SetActive(false); arrowNextChest27.SetActive(false);
        arrowNextChest28.SetActive(false); arrowNextChest29.SetActive(false); arrowNextChest30.SetActive(false);
        arrowNextChest31.SetActive(false); arrowNextChest32.SetActive(false); arrowNextChest33.SetActive(false);
        arrowNextChest34.SetActive(false); arrowNextChest35.SetActive(false); arrowNextChest36.SetActive(false);
        arrowNextChest37.SetActive(false); arrowNextChest38.SetActive(false); arrowNextChest39.SetActive(false);

        //ArrowsBack False
        arrowBackChest2.SetActive(false); arrowBackChest3.SetActive(false); arrowBackChest4.SetActive(false);
        arrowBackChest5.SetActive(false); arrowBackChest6.SetActive(false); arrowBackChest7.SetActive(false);
        arrowBackChest8.SetActive(false); arrowBackChest9.SetActive(false); arrowBackChest10.SetActive(false);
        arrowBackChest11.SetActive(false); arrowBackChest12.SetActive(false); arrowBackChest13.SetActive(false);
        arrowBackChest14.SetActive(false); arrowBackChest15.SetActive(false); arrowBackChest16.SetActive(false);
        arrowBackChest17.SetActive(false); arrowBackChest18.SetActive(false); arrowBackChest19.SetActive(false);
        arrowBackChest20.SetActive(false); arrowBackChest21.SetActive(false); arrowBackChest22.SetActive(false);
        arrowBackChest23.SetActive(false); arrowBackChest24.SetActive(false); arrowBackChest25.SetActive(false);
        arrowBackChest26.SetActive(false); arrowBackChest27.SetActive(false); arrowBackChest28.SetActive(false);
        arrowBackChest29.SetActive(false); arrowBackChest30.SetActive(false); arrowBackChest31.SetActive(false);
        arrowBackChest32.SetActive(false); arrowBackChest33.SetActive(false); arrowBackChest34.SetActive(false);
        arrowBackChest35.SetActive(false); arrowBackChest36.SetActive(false); arrowBackChest37.SetActive(false);
        arrowBackChest38.SetActive(false); arrowBackChest39.SetActive(false); arrowBackChest40.SetActive(false);

        //Set all chests inactive
        chest1Active = false; chest2Active = false; chest3Active = false; chest4Active = false; chest5Active = false;
        chest6Active = false; chest7Active = false; chest8Active = false; chest9Active = false; chest10Active = false;
        chest11Active = false; chest12Active = false; chest13Active = false; chest14Active = false; chest15Active = false;
        chest16Active = false; chest17Active = false; chest18Active = false; chest19Active = false; chest20Active = false;
        chest21Active = false; chest22Active = false; chest23Active = false; chest24Active = false; chest25Active = false;
        chest26Active = false; chest27Active = false; chest28Active = false; chest29Active = false; chest30Active = false; chest31Active = false; chest32Active = false; chest33Active = false; chest34Active = false; chest35Active = false; chest36Active = false; chest37Active = false; chest38Active = false; chest39Active = false; chest40Active = false;

        changeChest = false;
        #endregion

        #region arrowSize
        arrowNextChest1.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest2.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest3.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest4.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest5.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest6.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest7.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest8.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest9.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest10.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest11.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest12.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest13.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest14.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest15.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest16.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest17.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest18.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest19.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest20.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest21.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest22.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest23.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest24.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest25.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest26.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest27.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest28.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest29.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest30.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest31.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest32.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest33.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest34.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest35.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest36.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest37.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest38.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowNextChest39.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest2.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest3.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest4.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest5.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest6.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest7.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest8.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest9.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest10.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest11.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest12.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest13.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest14.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest15.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest16.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest17.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest18.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest19.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest20.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest21.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest22.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest23.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest24.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest25.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest26.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest27.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest28.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest29.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest30.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest31.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest32.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest33.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest34.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest35.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest36.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest37.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest38.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest39.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        arrowBackChest40.transform.localScale = new Vector3(arrowSize, arrowSize, arrowSize);
        #endregion

        #region colorOfchestHover
        Color newColor;
        ColorUtility.TryParseHtmlString(blackColor, out newColor);
        redRuby.GetComponent<Image>().color = newColor;
        amethyst.GetComponent<Image>().color = newColor;
        diamond.GetComponent<Image>().color = newColor;
        violetCrystal.GetComponent<Image>().color = newColor;
        yellowSapphire.GetComponent<Image>().color = newColor;
        greenDiamond.GetComponent<Image>().color = newColor;
        grandidierite.GetComponent<Image>().color = newColor;
        purpleRupee.GetComponent<Image>().color = newColor;
        pinkPlort.GetComponent<Image>().color = newColor;
        emerald.GetComponent<Image>().color = newColor;
        quartz.GetComponent<Image>().color = newColor;
        redGarnet.GetComponent<Image>().color = newColor;
        pinkTourmaline.GetComponent<Image>().color = newColor;
        yellowTopaz.GetComponent<Image>().color = newColor;
        aquamarine.GetComponent<Image>().color = newColor;
        fireOpal.GetComponent<Image>().color = newColor;
        goldenSeaPearl.GetComponent<Image>().color = newColor;
        akoyaPearl.GetComponent<Image>().color = newColor;
        gemSilica.GetComponent<Image>().color = newColor;
        adventurine.GetComponent<Image>().color = newColor;
        kyanite.GetComponent<Image>().color = newColor;
        albite.GetComponent<Image>().color = newColor;
        blackOpal.GetComponent<Image>().color = newColor;
        painite.GetComponent<Image>().color = newColor;
        tanzanite.GetComponent<Image>().color = newColor;
        astralium.GetComponent<Image>().color = newColor;
        elysiumPrism.GetComponent<Image>().color = newColor;
        aerthfireOpal.GetComponent<Image>().color = newColor;
        eldrichStarstone.GetComponent<Image>().color = newColor;
        chronolithShard.GetComponent<Image>().color = newColor;
        sideriumEssence.GetComponent<Image>().color = newColor;
        quasarite.GetComponent<Image>().color = newColor;
        riadiantNovaStone.GetComponent<Image>().color = newColor;
        soluniumShard.GetComponent<Image>().color = newColor;

        quartz.SetActive(true);

        redRuby.SetActive(false);
        amethyst.SetActive(false);
        diamond.SetActive(false);
        violetCrystal.SetActive(false);
        yellowSapphire.SetActive(false);
        greenDiamond.SetActive(false);
        grandidierite.SetActive(false);
        purpleRupee.SetActive(false);
        pinkPlort.SetActive(false);
        emerald.SetActive(false);
        redGarnet.SetActive(false);
        pinkTourmaline.SetActive(false);
        yellowTopaz.SetActive(false);
        aquamarine.SetActive(false);
        fireOpal.SetActive(false);
        goldenSeaPearl.SetActive(false);
        akoyaPearl.SetActive(false);
        gemSilica.SetActive(false);
        adventurine.SetActive(false);
        kyanite.SetActive(false);
        albite.SetActive(false);
        blackOpal.SetActive(false);
        painite.SetActive(false);
        tanzanite.SetActive(false);
        astralium.SetActive(false);
        elysiumPrism.SetActive(false);
        aerthfireOpal.SetActive(false);
        eldrichStarstone.SetActive(false);
        chronolithShard.SetActive(false);
        sideriumEssence.SetActive(false);
        quasarite.SetActive(false);
        riadiantNovaStone.SetActive(false);
        soluniumShard.SetActive(false);

        chest2.GetComponent<Image>().color = newColor;
        chest3.GetComponent<Image>().color = newColor;
        chest4.GetComponent<Image>().color = newColor;
        chest5.GetComponent<Image>().color = newColor;
        chest6.GetComponent<Image>().color = newColor;
        chest7.GetComponent<Image>().color = newColor;
        chest8.GetComponent<Image>().color = newColor;
        chest9.GetComponent<Image>().color = newColor;
        chest10.GetComponent<Image>().color = newColor;
        chest11.GetComponent<Image>().color = newColor;
        chest12.GetComponent<Image>().color = newColor;
        chest13.GetComponent<Image>().color = newColor;
        chest14.GetComponent<Image>().color = newColor;
        chest15.GetComponent<Image>().color = newColor;
        chest16.GetComponent<Image>().color = newColor;
        chest17.GetComponent<Image>().color = newColor;
        chest18.GetComponent<Image>().color = newColor;
        chest19.GetComponent<Image>().color = newColor;
        chest20.GetComponent<Image>().color = newColor;
        chest21.GetComponent<Image>().color = newColor;
        chest22.GetComponent<Image>().color = newColor;
        chest23.GetComponent<Image>().color = newColor;
        chest24.GetComponent<Image>().color = newColor;
        chest25.GetComponent<Image>().color = newColor;
        chest26.GetComponent<Image>().color = newColor;
        chest27.GetComponent<Image>().color = newColor;
        chest28.GetComponent<Image>().color = newColor;
        chest29.GetComponent<Image>().color = newColor;
        chest30.GetComponent<Image>().color = newColor;
        chest31.GetComponent<Image>().color = newColor;
        chest32.GetComponent<Image>().color = newColor;
        chest33.GetComponent<Image>().color = newColor;
        chest34.GetComponent<Image>().color = newColor;
        chest35.GetComponent<Image>().color = newColor;
        chest36.GetComponent<Image>().color = newColor;
        chest37.GetComponent<Image>().color = newColor;
        chest38.GetComponent<Image>().color = newColor;
        chest39.GetComponent<Image>().color = newColor;
        chest40.GetComponent<Image>().color = newColor;
        #endregion

        clickArrowBackChest2();

    }
}
