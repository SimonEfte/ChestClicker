using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
public class RareDropsCollected : MonoBehaviour, IDataPersistence
{
    public static bool isGemCountUpdated;

    public GameObject redGemLocked, amethystLocked, diamondLocked, violeyCrystalLocked, yellowSapphireLocked,greenDiamondLocked, grandidieriteLocked, purpleRupeeLocked, pinkPlortLocked, emeraldLocked, quartzLocked, redGarnetLocked, pinkTourmalineLocked, yellowTopazLocked, aquamarineLocked, fireOpalLocked, goldenSeaPearlLocked, akoyaPearlLocked, gemSilicaLocked, adventurineLocked, kyaniteLocked, albiteLocked, blackOpalLocked, painiteLocked, tanzaniteLocked, astraliumLocked, elysiumPrismLocked, aetherfireOpalLocked, eldritchStarstoneLocked, chronolithShardLocked, sideriumEssenceLocked, quasariteLocked, radiantNovaStoneLocked, soluniumShardLocked;

    public static int RedGemCount, redGemBoughtFirstTime;
    public static int amethystCount, amethystBoughtFirstTime;
    public static int diamondCount, diamondBoughtFirstTime;
    public static int violetCrystalCount, violetCrystalBoughtFirstTime;
    public static int yellowSapphireCount, yellowSapphireBoughtFirstTime;
    public static int greenDiamondCount, greenDiamondBoughtFirstTime;
    public static int grandidieriteCount, grandidieriteBoughtFirstTime;
    public static int purpleRupeeCount, purpleRupeeBoughtFirstTime;
    public static int akoyaPearlCount, akoyaPearlBoughtFirstTime;
    public static int albiteCount, albiteBoughtFirstTime;
    public static int aquamarineCount, aquamarineBoughtFirstTime;
    public static int AdventurineCount, adventurineBoughtFirstTime;
    public static int emeraldCount, emeraldBoughtFirstTime;
    public static int fireOpalCount, fireOpalBoughtFirstTime;
    public static int gemSilicaCount, gemSilicaBoughtFirstTime;
    public static int goldeSeaPearlCount, goldeSeaPearlBoughtFirstTime;
    public static int kyaniteCount, kyaniteBoughtFirstTime;
    public static int pinkTourmalineCount, pinkTourmalineBoughtFirstTime;
    public static int pinkPlostCount, pinkPlortBoughtFirstTime;
    public static int quartzCount, quartzBoughtFirstTime;
    public static int redGarnetCount, redGarnetBoughtFirstTime;
    public static int yellowTopazCount, yellowTopazBoughtFirstTime;
    public static int blackOpalCount, blackOpalBoughtFirstTime;
    public static int painiteCount, painiteBoughtFirstTime;
    public static int TanzaniteCount, tanzaniteBoughtFirstTime;
    public static int astraliumCount, astraliumBoughtFirstTime;
    public static int elysiumPrismCount, elysiumPrismBoughtFirstTime;
    public static int aetherfireOpalCount, aetherfireOpalBoughtFirstTime;
    public static int eldritchStarstoneCount, eldritchStarstoneBoughtFirstTime;
    public static int chronolithShardCount, chronolithShardBoughtFirstTime;
    public static int sideriumEssenceCount, sideriumEssenceBoughtFirstTime;
    public static int quasariteCount, quasariteBoughtFirstTime;
    public static int radiantNovaStoneCount, radiantNovaStoneBoughtFirstTime;
    public static int soluniumShardCount, soluniumShardBoughtFirstTime;

    public AudioManager audioManager;

    public TextMeshProUGUI redGemCountText;
    public TextMeshProUGUI amethystCountText;
    public TextMeshProUGUI diamondCountText;
    public TextMeshProUGUI violetCountText;
    public TextMeshProUGUI yellowSapphireCountText;
    public TextMeshProUGUI greenDiamondCountText;
    public TextMeshProUGUI grandidieriteCountText;
    public TextMeshProUGUI purpleRupeeCountText;
    public TextMeshProUGUI AkoyaPearlCountText;
    public TextMeshProUGUI AlbiteCountText;
    public TextMeshProUGUI AquamarineCountText;
    public TextMeshProUGUI AdventurineCountText;
    public TextMeshProUGUI emeraldCountText;
    public TextMeshProUGUI fireOpalCountText;
    public TextMeshProUGUI gemSilicaCountText;
    public TextMeshProUGUI goldenSeaPearlCountText;
    public TextMeshProUGUI KyaniteCountText;
    public TextMeshProUGUI PinkTourmalineCountText;
    public TextMeshProUGUI PinkPlortCountText;
    public TextMeshProUGUI QuartzCountText;
    public TextMeshProUGUI RedGarnetCountText;
    public TextMeshProUGUI YellowTopazCountText;
    public TextMeshProUGUI blackOpalCountText;
    public TextMeshProUGUI painiteCountText;
    public TextMeshProUGUI tanzaniteCountText;
    public TextMeshProUGUI astraliumCountText;
    public TextMeshProUGUI elysiumPrismCountText;
    public TextMeshProUGUI aetherfireOpalCountText;
    public TextMeshProUGUI eldritchStarstoneCountText;
    public TextMeshProUGUI chronolithShardCountText;
    public TextMeshProUGUI sideriumEssenceCountText;
    public TextMeshProUGUI quasariteCountText;
    public TextMeshProUGUI radiantNovaStoneCountText;
    public TextMeshProUGUI soluniumShardCountText;

    public GameObject treasureBar;
    public float textSize;

    public Color originalColor;
    private void Start()
    {
        textSize = 2.3f;
        originalColor = redGemCountText.color;

        Invoke("wait", 0.4f);
    }


    public void wait()
    {
        string path = Application.persistentDataPath + "/player.saveGemsCount";

        if (File.Exists(path))
        {
            if (SaveAndLoad.onlyLoadNewSave == false)
            {
                GameData data = SaveSystem.LoadGemsCount();
                RedGemCount = data.redRubyCount;
                amethystCount = data.amethystCount;
                diamondCount = data.diamondCount;
                violetCrystalCount = data.violetCount;
                yellowSapphireCount = data.yellowSapphireCount;
                greenDiamondCount = data.greenDiamondCount;
                grandidieriteCount = data.grandidieriteCount;
                purpleRupeeCount = data.purpleRupeeCount;
                pinkPlostCount = data.pinkPlortCount;
                emeraldCount = data.emeraldCount;
                quartzCount = data.quartzCount;
                redGarnetCount = data.redGarnetCount;
                pinkTourmalineCount = data.pinkTourmalineCount;
                yellowTopazCount = data.yellowTopazCount;
                aquamarineCount = data.aquamarineCount;
                fireOpalCount = data.fireOpalCount;
                goldeSeaPearlCount = data.goldenSeaPearlCount;
                akoyaPearlCount = data.akoyaPearlCount;
                gemSilicaCount = data.gemSilicaCount;
                AdventurineCount = data.adventurineCount;
                kyaniteCount = data.kyaniteCount;
                albiteCount = data.albiteCount;
                blackOpalCount = data.blackOpalCount;
                painiteCount = data.painiteCount;
                TanzaniteCount = data.tanzaniteCount;

                redGemBoughtFirstTime = data.redRubyFirst;
                amethystBoughtFirstTime = data.amethystFirst;
                diamondBoughtFirstTime = data.diamondFirst;
                violetCrystalBoughtFirstTime = data.violetFirst;
                yellowSapphireBoughtFirstTime = data.yellowSapphireFirst;
                greenDiamondBoughtFirstTime = data.greenDiamondFirst;
                grandidieriteBoughtFirstTime = data.grandideriteFirst;
                purpleRupeeBoughtFirstTime = data.purpleRupeeFirst;
                pinkPlortBoughtFirstTime = data.pinkPlortFirst;
                emeraldBoughtFirstTime = data.emeraldFirst;
                quartzBoughtFirstTime = data.quartzFirst;
                redGarnetBoughtFirstTime = data.redGarnetFirst;
                pinkTourmalineBoughtFirstTime = data.pinkTourmalineFirst;
                yellowTopazBoughtFirstTime = data.yellowTopazFirst;
                aquamarineBoughtFirstTime = data.aquamarineFirst;
                fireOpalBoughtFirstTime = data.fireOpalFirst;
                goldeSeaPearlBoughtFirstTime = data.goldenSeaPearlFirst;
                akoyaPearlBoughtFirstTime = data.akoyaPearlFirst;
                gemSilicaBoughtFirstTime = data.gemSilicaFirst;
                adventurineBoughtFirstTime = data.adventurineFirst;
                kyaniteBoughtFirstTime = data.kyaniteFirst;
                albiteBoughtFirstTime = data.albiteFirst;
                blackOpalBoughtFirstTime = data.blackOpalFirst;
                painiteBoughtFirstTime = data.painiteFirst;
                tanzaniteBoughtFirstTime = data.tanzaniteFirst;
            }
            else { }
        }
        else
        {
            //Do nothing
        }

        isGemCountUpdated = true;
    }


    #region SaveAndLoadJSON
    public void LoadData(GameDataJSON data)
    {
        RedGemCount = data.redRubyCount;
        amethystCount = data.amethystCount;
        diamondCount = data.diamondCount;
        violetCrystalCount = data.violetCount;
        yellowSapphireCount = data.yellowSapphireCount;
        greenDiamondCount = data.greenDiamondCount;
        grandidieriteCount = data.grandidieriteCount;
        purpleRupeeCount = data.purpleRupeeCount;
        pinkPlostCount = data.pinkPlortCount;
        emeraldCount = data.emeraldCount;
        quartzCount = data.quartzCount;
        redGarnetCount = data.redGarnetCount;
        pinkTourmalineCount = data.pinkTourmalineCount;
        yellowTopazCount = data.yellowTopazCount;
        aquamarineCount = data.aquamarineCount;
        fireOpalCount = data.fireOpalCount;
        goldeSeaPearlCount = data.goldenSeaPearlCount;
        akoyaPearlCount = data.akoyaPearlCount;
        gemSilicaCount = data.gemSilicaCount;
        AdventurineCount = data.adventurineCount;
        kyaniteCount = data.kyaniteCount;
        albiteCount = data.albiteCount;
        blackOpalCount = data.blackOpalCount;
        painiteCount = data.painiteCount;
        TanzaniteCount = data.tanzaniteCount;

        //new
        astraliumCount = data.astraliumCount;
        elysiumPrismCount = data.elysiumPrismCount;
        aetherfireOpalCount = data.aetherfireOpalCount;
        eldritchStarstoneCount = data.eldritchStarstoneCount;
        chronolithShardCount = data.chronolithShardCount;
        sideriumEssenceCount = data.sideriumEssenceCount;
        quasariteCount = data.quasariteCount;
        radiantNovaStoneCount = data.radiantNovaStoneCount;
        soluniumShardCount = data.soluniumShardCount;

        redGemBoughtFirstTime = data.redRubyFirst;
        amethystBoughtFirstTime = data.amethystFirst;
        diamondBoughtFirstTime = data.diamondFirst;
        violetCrystalBoughtFirstTime = data.violetFirst;
        yellowSapphireBoughtFirstTime = data.yellowSapphireFirst;
        greenDiamondBoughtFirstTime = data.greenDiamondFirst;
        grandidieriteBoughtFirstTime = data.grandideriteFirst;
        purpleRupeeBoughtFirstTime = data.purpleRupeeFirst;
        pinkPlortBoughtFirstTime = data.pinkPlortFirst;
        emeraldBoughtFirstTime = data.emeraldFirst;
        quartzBoughtFirstTime = data.quartzFirst;
        redGarnetBoughtFirstTime = data.redGarnetFirst;
        pinkTourmalineBoughtFirstTime = data.pinkTourmalineFirst;
        yellowTopazBoughtFirstTime = data.yellowTopazFirst;
        aquamarineBoughtFirstTime = data.aquamarineFirst;
        fireOpalBoughtFirstTime = data.fireOpalFirst;
        goldeSeaPearlBoughtFirstTime = data.goldenSeaPearlFirst;
        akoyaPearlBoughtFirstTime = data.akoyaPearlFirst;
        gemSilicaBoughtFirstTime = data.gemSilicaFirst;
        adventurineBoughtFirstTime = data.adventurineFirst;
        kyaniteBoughtFirstTime = data.kyaniteFirst;
        albiteBoughtFirstTime = data.albiteFirst;
        blackOpalBoughtFirstTime = data.blackOpalFirst;
        painiteBoughtFirstTime = data.painiteFirst;
        tanzaniteBoughtFirstTime = data.tanzaniteFirst;

        //new
        astraliumBoughtFirstTime = data.astraliumBoughtFirstTime;
        elysiumPrismBoughtFirstTime = data.elysiumPrismBoughtFirstTime;
        aetherfireOpalBoughtFirstTime = data.aetherfireOpalBoughtFirstTime;
        eldritchStarstoneBoughtFirstTime = data.eldritchStarstoneBoughtFirstTime;
        chronolithShardBoughtFirstTime = data.chronolithShardBoughtFirstTime;
        sideriumEssenceBoughtFirstTime = data.sideriumEssenceBoughtFirstTime;
        quasariteBoughtFirstTime = data.quasariteBoughtFirstTime;
        radiantNovaStoneBoughtFirstTime = data.radiantNovaStoneBoughtFirstTime;
        soluniumShardBoughtFirstTime = data.soluniumShardBoughtFirstTime;
    }

    public void SaveData(ref GameDataJSON data)
    {
        data.redRubyCount = RedGemCount;
        data.amethystCount = amethystCount;
        data.diamondCount = diamondCount;
        data.violetCount = violetCrystalCount;
        data.yellowSapphireCount = yellowSapphireCount;
        data.greenDiamondCount = greenDiamondCount;
        data.grandidieriteCount = grandidieriteCount;
        data.purpleRupeeCount = purpleRupeeCount;
        data.pinkPlortCount = pinkPlostCount;
        data.emeraldCount = emeraldCount;
        data.quartzCount = quartzCount;
        data.redGarnetCount = redGarnetCount;
        data.pinkTourmalineCount = pinkTourmalineCount;
        data.yellowTopazCount = yellowTopazCount;
        data.aquamarineCount = aquamarineCount;
        data.fireOpalCount = fireOpalCount;
        data.goldenSeaPearlCount = goldeSeaPearlCount;
        data.akoyaPearlCount = akoyaPearlCount;
        data.gemSilicaCount = gemSilicaCount;
        data.adventurineCount = AdventurineCount;
        data.kyaniteCount = kyaniteCount;
        data.albiteCount = albiteCount;
        data.blackOpalCount = blackOpalCount;
        data.painiteCount = painiteCount;
        data.tanzaniteCount = TanzaniteCount;

        //new
        data.astraliumCount = astraliumCount;
        data.elysiumPrismCount = elysiumPrismCount;
        data.aetherfireOpalCount = aetherfireOpalCount;
        data.eldritchStarstoneCount = eldritchStarstoneCount;
        data.chronolithShardCount = chronolithShardCount;
        data.sideriumEssenceCount = sideriumEssenceCount;
        data.quasariteCount = quasariteCount;
        data.radiantNovaStoneCount = radiantNovaStoneCount;
        data.soluniumShardCount = soluniumShardCount;

        data.redRubyFirst = redGemBoughtFirstTime;
        data.amethystFirst = amethystBoughtFirstTime;
        data.diamondFirst = diamondBoughtFirstTime;
        data.violetFirst = violetCrystalBoughtFirstTime;
        data.yellowSapphireFirst = yellowSapphireBoughtFirstTime;
        data.greenDiamondFirst = greenDiamondBoughtFirstTime;
        data.grandideriteFirst = grandidieriteBoughtFirstTime;
        data.purpleRupeeFirst = purpleRupeeBoughtFirstTime;
        data.pinkPlortFirst = pinkPlortBoughtFirstTime;
        data.emeraldFirst = emeraldBoughtFirstTime;
        data.quartzFirst = quartzBoughtFirstTime;
        data.redGarnetFirst = redGarnetBoughtFirstTime;
        data.pinkTourmalineFirst = pinkTourmalineBoughtFirstTime;
        data.yellowTopazFirst = yellowTopazBoughtFirstTime;
        data.aquamarineFirst = aquamarineBoughtFirstTime;
        data.fireOpalFirst = fireOpalBoughtFirstTime;
        data.goldenSeaPearlFirst = goldeSeaPearlBoughtFirstTime;
        data.akoyaPearlFirst = akoyaPearlBoughtFirstTime;
        data.gemSilicaFirst = gemSilicaBoughtFirstTime;
        data.adventurineFirst = adventurineBoughtFirstTime;
        data.kyaniteFirst = kyaniteBoughtFirstTime;
        data.albiteFirst = albiteBoughtFirstTime;
        data.blackOpalFirst = blackOpalBoughtFirstTime;
        data.painiteFirst = painiteBoughtFirstTime;
        data.tanzaniteFirst = tanzaniteBoughtFirstTime;

        //new
        data.astraliumBoughtFirstTime = astraliumBoughtFirstTime;
        data.elysiumPrismBoughtFirstTime = elysiumPrismBoughtFirstTime;
        data.aetherfireOpalBoughtFirstTime = aetherfireOpalBoughtFirstTime;
        data.eldritchStarstoneBoughtFirstTime = eldritchStarstoneBoughtFirstTime;
        data.chronolithShardBoughtFirstTime = chronolithShardBoughtFirstTime;
        data.sideriumEssenceBoughtFirstTime = sideriumEssenceBoughtFirstTime;
        data.quasariteBoughtFirstTime = quasariteBoughtFirstTime;
        data.radiantNovaStoneBoughtFirstTime = radiantNovaStoneBoughtFirstTime;
        data.soluniumShardBoughtFirstTime = soluniumShardBoughtFirstTime;
    }
    #endregion


    public void Update()
    {
        if (!isGemCountUpdated)
        {
            return;
        }

        if(SaveAndLoad.pressedResetButton == false)
        {
            #region LockedTreasures
            if (RedGemCount > 0 || redGemBoughtFirstTime == 1) { redGemLocked.SetActive(false); SelectChests.changedColor = true; }
            if (amethystCount > 0 || amethystBoughtFirstTime == 1) { amethystLocked.SetActive(false); SelectChests.changedColor = true; }
            if (diamondCount > 0 || diamondBoughtFirstTime == 1) { diamondLocked.SetActive(false); SelectChests.changedColor = true; }
            if (violetCrystalCount > 0 || violetCrystalBoughtFirstTime == 1) { violeyCrystalLocked.SetActive(false); SelectChests.changedColor = true; }
            if (yellowSapphireCount > 0 || yellowSapphireBoughtFirstTime == 1) { yellowSapphireLocked.SetActive(false); SelectChests.changedColor = true; }
            if (greenDiamondCount > 0 || greenDiamondBoughtFirstTime == 1) { greenDiamondLocked.SetActive(false); SelectChests.changedColor = true; }
            if (grandidieriteCount > 0 || grandidieriteBoughtFirstTime == 1) { grandidieriteLocked.SetActive(false); SelectChests.changedColor = true; }
            if (purpleRupeeCount > 0 || purpleRupeeBoughtFirstTime == 1) { purpleRupeeLocked.SetActive(false); SelectChests.changedColor = true; }
            if (pinkPlostCount > 0 || pinkPlortBoughtFirstTime == 1) { pinkPlortLocked.SetActive(false); SelectChests.changedColor = true; }
            if (emeraldCount > 0 || emeraldBoughtFirstTime == 1) { emeraldLocked.SetActive(false); SelectChests.changedColor = true; }
            if (quartzCount > 0 || quartzBoughtFirstTime == 1) { quartzLocked.SetActive(false); SelectChests.changedColor = true; }
            if (redGarnetCount > 0 || redGarnetBoughtFirstTime == 1) { redGarnetLocked.SetActive(false); SelectChests.changedColor = true; }
            if (pinkTourmalineCount > 0 || pinkTourmalineBoughtFirstTime == 1) { pinkTourmalineLocked.SetActive(false); SelectChests.changedColor = true; }
            if (yellowTopazCount > 0 || yellowTopazBoughtFirstTime == 1) { yellowTopazLocked.SetActive(false); SelectChests.changedColor = true; }
            if (aquamarineCount > 0 || aquamarineBoughtFirstTime == 1) { aquamarineLocked.SetActive(false); SelectChests.changedColor = true; }
            if (fireOpalCount > 0 || fireOpalBoughtFirstTime == 1) { fireOpalLocked.SetActive(false); SelectChests.changedColor = true; }
            if (goldeSeaPearlCount > 0 || goldeSeaPearlBoughtFirstTime == 1) { goldenSeaPearlLocked.SetActive(false); SelectChests.changedColor = true; }
            if (akoyaPearlCount > 0 || akoyaPearlBoughtFirstTime == 1) { akoyaPearlLocked.SetActive(false); SelectChests.changedColor = true; }
            if (gemSilicaCount > 0 || gemSilicaBoughtFirstTime == 1) { gemSilicaLocked.SetActive(false); SelectChests.changedColor = true; }
            if (AdventurineCount > 0 || adventurineBoughtFirstTime == 1) { adventurineLocked.SetActive(false); SelectChests.changedColor = true; }
            if (kyaniteCount > 0 || kyaniteBoughtFirstTime == 1) { kyaniteLocked.SetActive(false); SelectChests.changedColor = true; }
            if (albiteCount > 0 || albiteBoughtFirstTime == 1) { albiteLocked.SetActive(false); SelectChests.changedColor = true; }
            if (blackOpalCount > 0 || blackOpalBoughtFirstTime == 1) { blackOpalLocked.SetActive(false); SelectChests.changedColor = true; }
            if (painiteCount > 0 || painiteBoughtFirstTime == 1) { painiteLocked.SetActive(false); SelectChests.changedColor = true; }
            if (TanzaniteCount > 0 || tanzaniteBoughtFirstTime == 1) { tanzaniteLocked.SetActive(false); SelectChests.changedColor = true; }
            if (astraliumCount > 0 || astraliumBoughtFirstTime == 1) { astraliumLocked.SetActive(false); SelectChests.changedColor = true; }
            if (elysiumPrismCount > 0 || elysiumPrismBoughtFirstTime == 1) { elysiumPrismLocked.SetActive(false); SelectChests.changedColor = true; }
            if (aetherfireOpalCount > 0 || aetherfireOpalBoughtFirstTime == 1) { aetherfireOpalLocked.SetActive(false); SelectChests.changedColor = true; }
            if (eldritchStarstoneCount > 0 || eldritchStarstoneBoughtFirstTime == 1) { eldritchStarstoneLocked.SetActive(false); SelectChests.changedColor = true; }
            if (chronolithShardCount > 0 || chronolithShardBoughtFirstTime == 1) { chronolithShardLocked.SetActive(false); SelectChests.changedColor = true; }
            if (sideriumEssenceCount > 0 || sideriumEssenceBoughtFirstTime == 1) { sideriumEssenceLocked.SetActive(false); SelectChests.changedColor = true; }
            if (quasariteCount > 0 || quasariteBoughtFirstTime == 1) { quasariteLocked.SetActive(false); SelectChests.changedColor = true; }
            if (radiantNovaStoneCount > 0 || radiantNovaStoneBoughtFirstTime == 1) { radiantNovaStoneLocked.SetActive(false); SelectChests.changedColor = true; }
            if (soluniumShardCount > 0 || soluniumShardBoughtFirstTime == 1) { soluniumShardLocked.SetActive(false); SelectChests.changedColor = true; }
            #endregion

            #region colorRed
            if (redGemBoughtFirstTime == 1)
            {
                if(RedGemCount == 0) { redGemCountText.color = Color.red; }
                if (RedGemCount > 0) { redGemCountText.color = originalColor; }
            }
            if (amethystBoughtFirstTime == 1)
            {
                if (amethystCount == 0) { amethystCountText.color = Color.red; }
                if (amethystCount > 0) { amethystCountText.color = originalColor; }
            }
            if (diamondBoughtFirstTime == 1)
            {
                if (diamondCount == 0) { diamondCountText.color = Color.red; }
                if (diamondCount > 0) { diamondCountText.color = originalColor; }
            }
            if (violetCrystalBoughtFirstTime == 1)
            {
                if (violetCrystalCount == 0) { violetCountText.color = Color.red; }
                if (violetCrystalCount > 0) { violetCountText.color = originalColor; }
            }
            if (yellowSapphireBoughtFirstTime == 1)
            {
                if (yellowSapphireCount == 0) { yellowSapphireCountText.color = Color.red; }
                if (yellowSapphireCount > 0) { yellowSapphireCountText.color = originalColor; }
            }
            if (greenDiamondBoughtFirstTime == 1)
            {
                if (greenDiamondCount == 0) { greenDiamondCountText.color = Color.red; }
                if (greenDiamondCount > 0) { greenDiamondCountText.color = originalColor; }
            }
            if (grandidieriteBoughtFirstTime == 1)
            {
                if (grandidieriteCount == 0) { grandidieriteCountText.color = Color.red; }
                if (grandidieriteCount > 0) { grandidieriteCountText.color = originalColor; }
            }
            if (purpleRupeeBoughtFirstTime == 1)
            {
                if (purpleRupeeCount == 0) { purpleRupeeCountText.color = Color.red; }
                if (purpleRupeeCount > 0) { purpleRupeeCountText.color = originalColor; }
            }
            if (pinkPlortBoughtFirstTime == 1)
            {
                if (pinkPlostCount == 0) { PinkPlortCountText.color = Color.red; }
                if (pinkPlostCount > 0) { PinkPlortCountText.color = originalColor; }
            }
            if (emeraldBoughtFirstTime == 1)
            {
                if (emeraldCount == 0) { emeraldCountText.color = Color.red; }
                if (emeraldCount > 0) { emeraldCountText.color = originalColor; }
            }
            if (quartzBoughtFirstTime == 1)
            {
                if (quartzCount == 0) { QuartzCountText.color = Color.red; }
                if (quartzCount > 0) { QuartzCountText.color = originalColor; }
            }
            if (redGarnetBoughtFirstTime == 1)
            {
                if (redGarnetCount == 0) { RedGarnetCountText.color = Color.red; }
                if (redGarnetCount > 0) { RedGarnetCountText.color = originalColor; }
            }
            if (pinkTourmalineBoughtFirstTime == 1)
            {
                if (pinkTourmalineCount == 0) { PinkTourmalineCountText.color = Color.red; }
                if (pinkTourmalineCount > 0) { PinkTourmalineCountText.color = originalColor; }
            }
            if (yellowTopazBoughtFirstTime == 1)
            {
                if (yellowTopazCount == 0) { YellowTopazCountText.color = Color.red; }
                if (yellowTopazCount > 0) { YellowTopazCountText.color = originalColor; }
            }
            if (aquamarineBoughtFirstTime == 1)
            {
                if (aquamarineCount == 0) { AquamarineCountText.color = Color.red; }
                if (aquamarineCount > 0) { AquamarineCountText.color = originalColor; }
            }
            if (fireOpalBoughtFirstTime == 1)
            {
                if (fireOpalCount == 0) { fireOpalCountText.color = Color.red; }
                if (fireOpalCount > 0) { fireOpalCountText.color = originalColor; }
            }
            if (goldeSeaPearlBoughtFirstTime == 1)
            {
                if (goldeSeaPearlCount == 0) { goldenSeaPearlCountText.color = Color.red; }
                if (goldeSeaPearlCount > 0) { goldenSeaPearlCountText.color = originalColor; }
            }
            if (akoyaPearlBoughtFirstTime == 1)
            {
                if (akoyaPearlCount == 0) { AkoyaPearlCountText.color = Color.red; }
                if (akoyaPearlCount > 0) { AkoyaPearlCountText.color = originalColor; }
            }
            if (gemSilicaBoughtFirstTime == 1)
            {
                if (gemSilicaCount == 0) { gemSilicaCountText.color = Color.red; }
                if (gemSilicaCount > 0) { gemSilicaCountText.color = originalColor; }
            }
            if (adventurineBoughtFirstTime == 1)
            {
                if (AdventurineCount == 0) { AdventurineCountText.color = Color.red; }
                if (AdventurineCount > 0) { AdventurineCountText.color = originalColor; }
            }
            if (kyaniteBoughtFirstTime == 1)
            {
                if (kyaniteCount == 0) { KyaniteCountText.color = Color.red; }
                if (kyaniteCount > 0) { KyaniteCountText.color = originalColor; }
            }
            if (albiteBoughtFirstTime == 1)
            {
                if (albiteCount == 0) { AlbiteCountText.color = Color.red; }
                if (albiteCount > 0) { AlbiteCountText.color = originalColor; }
            }
            if (blackOpalBoughtFirstTime == 1)
            {
                if (blackOpalCount == 0) { blackOpalCountText.color = Color.red; }
                if (blackOpalCount > 0) { blackOpalCountText.color = originalColor; }
            }
            if (painiteBoughtFirstTime == 1)
            {
                if (painiteCount == 0) { painiteCountText.color = Color.red; }
                if (painiteCount > 0) { painiteCountText.color = originalColor; }
            }
            if (tanzaniteBoughtFirstTime == 1)
            {
                if (TanzaniteCount == 0) { tanzaniteCountText.color = Color.red; }
                if (TanzaniteCount > 0) { tanzaniteCountText.color = originalColor; }
            }
            if (astraliumBoughtFirstTime == 1)
            {
                if (astraliumCount == 0) { astraliumCountText.color = Color.red; }
                if (astraliumCount > 0) { astraliumCountText.color = originalColor; }
            }
            if (elysiumPrismBoughtFirstTime == 1)
            {
                if (elysiumPrismCount == 0) { elysiumPrismCountText.color = Color.red; }
                if (elysiumPrismCount > 0) { elysiumPrismCountText.color = originalColor; }
            }
            if (aetherfireOpalBoughtFirstTime == 1)
            {
                if (aetherfireOpalCount == 0) { aetherfireOpalCountText.color = Color.red; }
                if (aetherfireOpalCount > 0) { aetherfireOpalCountText.color = originalColor; }
            }
            if (eldritchStarstoneBoughtFirstTime == 1)
            {
                if (eldritchStarstoneCount == 0) { eldritchStarstoneCountText.color = Color.red; }
                if (eldritchStarstoneCount > 0) { eldritchStarstoneCountText.color = originalColor; }
            }
            if (chronolithShardBoughtFirstTime == 1)
            {
                if (chronolithShardCount == 0) { chronolithShardCountText.color = Color.red; }
                if (chronolithShardCount > 0) { chronolithShardCountText.color = originalColor; }
            }
            if (sideriumEssenceBoughtFirstTime == 1)
            {
                if (sideriumEssenceCount == 0) { sideriumEssenceCountText.color = Color.red; }
                if (sideriumEssenceCount > 0) { sideriumEssenceCountText.color = originalColor; }
            }
            if (quasariteBoughtFirstTime == 1)
            {
                if (quasariteCount == 0) { quasariteCountText.color = Color.red; }
                if (quasariteCount > 0) { quasariteCountText.color = originalColor; }
            }
            if (radiantNovaStoneBoughtFirstTime == 1)
            {
                if (radiantNovaStoneCount == 0) { radiantNovaStoneCountText.color = Color.red; }
                if (radiantNovaStoneCount > 0) { radiantNovaStoneCountText.color = originalColor; }
            }
            if (soluniumShardBoughtFirstTime == 1)
            {
                if (soluniumShardCount == 0) { soluniumShardCountText.color = Color.red; }
                if (soluniumShardCount > 0) { soluniumShardCountText.color = originalColor; }
            }

            #endregion

            redGemCountText.text = RedGemCount + "";
            amethystCountText.text = amethystCount + "";
            diamondCountText.text = diamondCount + "";
            violetCountText.text = violetCrystalCount + "";
            yellowSapphireCountText.text = yellowSapphireCount + "";
            greenDiamondCountText.text = greenDiamondCount + "";
            grandidieriteCountText.text = grandidieriteCount + "";
            purpleRupeeCountText.text = purpleRupeeCount + "";
            PinkPlortCountText.text = pinkPlostCount + "";
            emeraldCountText.text = emeraldCount + "";
            QuartzCountText.text = quartzCount + "";
            RedGarnetCountText.text = redGarnetCount + "";
            PinkTourmalineCountText.text = pinkTourmalineCount + "";
            YellowTopazCountText.text = yellowTopazCount + "";
            AquamarineCountText.text = aquamarineCount + "";
            fireOpalCountText.text = fireOpalCount + "";
            goldenSeaPearlCountText.text = goldeSeaPearlCount + "";
            AkoyaPearlCountText.text = akoyaPearlCount + "";
            gemSilicaCountText.text = gemSilicaCount + "";
            AdventurineCountText.text = AdventurineCount + "";
            KyaniteCountText.text = kyaniteCount + "";
            AlbiteCountText.text = albiteCount + "";
            blackOpalCountText.text = blackOpalCount + "";
            painiteCountText.text = painiteCount + "";
            tanzaniteCountText.text = TanzaniteCount + "";
            astraliumCountText.text = astraliumCount + "";
            elysiumPrismCountText.text = elysiumPrismCount + "";
            aetherfireOpalCountText.text = aetherfireOpalCount + "";
            eldritchStarstoneCountText.text = eldritchStarstoneCount + "";
            chronolithShardCountText.text = chronolithShardCount + "";
            sideriumEssenceCountText.text = sideriumEssenceCount + "";
            quasariteCountText.text = quasariteCount + "";
            radiantNovaStoneCountText.text = radiantNovaStoneCount + "";
            soluniumShardCountText.text = soluniumShardCount + "";

            ClickPower.cursorsPriceChanged = true;
        }

        isGemCountUpdated = false;

        if(setTreasureTextRed == true)
        {
            redGemCountText.color = originalColor;
            amethystCountText.color = originalColor;
            diamondCountText.color = originalColor;
            violetCountText.color = originalColor;
            yellowSapphireCountText.color = originalColor;
            greenDiamondCountText.color = originalColor;
            grandidieriteCountText.color = originalColor;
            purpleRupeeCountText.color = originalColor;
            PinkPlortCountText.color = originalColor;
            emeraldCountText.color = originalColor;
            QuartzCountText.color = originalColor;
            RedGarnetCountText.color = originalColor;
            PinkTourmalineCountText.color = originalColor;
            YellowTopazCountText.color = originalColor;
            AquamarineCountText.color = originalColor;
            fireOpalCountText.color = originalColor;
            goldenSeaPearlCountText.color = originalColor;
            AkoyaPearlCountText.color = originalColor;
            gemSilicaCountText.color = originalColor;
            AdventurineCountText.color = originalColor;
            KyaniteCountText.color = originalColor;
            AlbiteCountText.color = originalColor;
            blackOpalCountText.color = originalColor;
            painiteCountText.color = originalColor;
            tanzaniteCountText.color = originalColor;
            astraliumCountText.color = originalColor;
            elysiumPrismCountText.color = originalColor;
            aetherfireOpalCountText.color = originalColor;
            eldritchStarstoneCountText.color = originalColor;
            chronolithShardCountText.color = originalColor;
            sideriumEssenceCountText.color = originalColor;
            quasariteCountText.color = originalColor;
            radiantNovaStoneCountText.color = originalColor;
            soluniumShardCountText.color = originalColor;


            setTreasureTextRed = false;
        }

        if(treasureBar.activeInHierarchy == true)
        {
            #region quartzPopUp
            if (ReturnRedGem.setQuartz == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(QuartzCountText.transform, false);
                treasureText.transform.position = QuartzCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setQuartz = false;
            }
            #endregion

            #region amethystPopUp
            if (ReturnRedGem.setAmethyst == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(amethystCountText.transform, false);
                treasureText.transform.position = amethystCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setAmethyst = false;
            }
            #endregion

            #region yellowTopazPopUp
            if (ReturnRedGem.setYellowTopaz == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(YellowTopazCountText.transform, false);
                treasureText.transform.position = YellowTopazCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setYellowTopaz = false;
            }
            #endregion

            #region albitePopUP
            if (ReturnRedGem.setAlbite == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(AlbiteCountText.transform, false);
                treasureText.transform.position = AlbiteCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setAlbite = false;
            }
            #endregion

            #region redGarnetPupUp
            if (ReturnRedGem.setRedGarnet == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(RedGarnetCountText.transform, false);
                treasureText.transform.position = RedGarnetCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setRedGarnet = false;
            }
            #endregion

            #region aquamarinePopUp
            if (ReturnRedGem.setAquamarine == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(AquamarineCountText.transform, false);
                treasureText.transform.position = AquamarineCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setAquamarine = false;
            }
            #endregion

            #region yellowSapphire
            if (ReturnRedGem.setYellowSapphire == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(yellowSapphireCountText.transform, false);
                treasureText.transform.position = yellowSapphireCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setYellowSapphire = false;
            }
            #endregion

            #region pinkTourmaline
            if (ReturnRedGem.setPinkTourmaline == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(PinkTourmalineCountText.transform, false);
                treasureText.transform.position = PinkTourmalineCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setPinkTourmaline = false;
            }
            #endregion

            #region adventurinePopUp
            if (ReturnRedGem.setAdventurine == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(AdventurineCountText.transform, false);
                treasureText.transform.position = AdventurineCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setAdventurine = false;
            }
            #endregion

            #region redRubyPopUp
            if (ReturnRedGem.setRedRuby == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(redGemCountText.transform, false);
                treasureText.transform.position = redGemCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setRedRuby = false;
            }
            #endregion

            #region diamondPopUp
            if (ReturnRedGem.setDiamond == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(diamondCountText.transform, false);
                treasureText.transform.position = diamondCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setDiamond = false;
            }
            #endregion

            #region grandideritePopUp
            if (ReturnRedGem.SetGrandiderite == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(grandidieriteCountText.transform, false);
                treasureText.transform.position = grandidieriteCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.SetGrandiderite = false;
            }
            #endregion

            #region violetCrystalPupUp
            if (ReturnRedGem.setVioletCrystal == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(violetCountText.transform, false);
                treasureText.transform.position = violetCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setVioletCrystal = false;
            }
            #endregion

            #region akoyaPearlPopUp
            if (ReturnRedGem.setAkoyaPearl == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(AkoyaPearlCountText.transform, false);
                treasureText.transform.position = AkoyaPearlCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setAkoyaPearl = false;
            }
            #endregion

            #region purpleRuppePopUp
            if (ReturnRedGem.setPurpleRupee == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(purpleRupeeCountText.transform, false);
                treasureText.transform.position = purpleRupeeCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setPurpleRupee = false;
            }
            #endregion

            #region emeraldPopUp
            if (ReturnRedGem.setEmerald == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(emeraldCountText.transform, false);
                treasureText.transform.position = emeraldCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setEmerald = false;
            }
            #endregion

            #region greenDiamondPopUp
            if (ReturnRedGem.setGreenDiamond == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(greenDiamondCountText.transform, false);
                treasureText.transform.position = greenDiamondCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setGreenDiamond = false;
            }
            #endregion

            #region fipeOpalPopUp
            if (ReturnRedGem.setFireOpal == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(fireOpalCountText.transform, false);
                treasureText.transform.position = fireOpalCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setFireOpal = false;
            }
            #endregion

            #region gemSilicaPopUp
            if (ReturnRedGem.setGemSilica == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(gemSilicaCountText.transform, false);
                treasureText.transform.position = gemSilicaCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setGemSilica = false;
            }
            #endregion

            #region pinkPlortPopUp
            if (ReturnRedGem.setPinkPlort == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(PinkPlortCountText.transform, false);
                treasureText.transform.position = PinkPlortCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setPinkPlort = false;
            }
            #endregion

            #region goldenSeaPearlPopUp
            if (ReturnRedGem.setGoldejSeaPearl == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(goldenSeaPearlCountText.transform, false);
                treasureText.transform.position = goldenSeaPearlCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setGoldejSeaPearl = false;
            }
            #endregion

            #region ktanitePopUp
            if (ReturnRedGem.setKyanite == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(KyaniteCountText.transform, false);
                treasureText.transform.position = KyaniteCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setKyanite = false;
            }
            #endregion

            #region blackOpalPopUp
            if (ReturnRedGem.setBlackOpal == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(blackOpalCountText.transform, false);
                treasureText.transform.position = blackOpalCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setBlackOpal = false;
            }
            #endregion

            #region painitePopUp
            if (ReturnRedGem.setPainite == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(painiteCountText.transform, false);
                treasureText.transform.position = painiteCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setPainite = false;
            }
            #endregion

            #region tanzanitePopUP
            if (ReturnRedGem.setTanzanite == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(tanzaniteCountText.transform, false);
                treasureText.transform.position = tanzaniteCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setTanzanite = false;
            }
            #endregion

            #region astraliumPopUP
            if (ReturnRedGem.setAstralium == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(astraliumCountText.transform, false);
                treasureText.transform.position = astraliumCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setAstralium = false;
            }
            #endregion

            // elysiumPrism
            #region elysiumPrismPopUP
            if (ReturnRedGem.setElysiumPrism == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(elysiumPrismCountText.transform, false);
                treasureText.transform.position = elysiumPrismCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setElysiumPrism = false;
            }
            #endregion

            // aetherfireOpal
            #region aetherfireOpalPopUP
            if (ReturnRedGem.setAetherfireOpal == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(aetherfireOpalCountText.transform, false);
                treasureText.transform.position = aetherfireOpalCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setAetherfireOpal = false;
            }
            #endregion

            // eldritchStarstone
            #region eldritchStarstonePopUP
            if (ReturnRedGem.setEldritchStarstone == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(eldritchStarstoneCountText.transform, false);
                treasureText.transform.position = eldritchStarstoneCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setEldritchStarstone = false;
            }
            #endregion

            // chronolithShard
            #region chronolithShardPopUP
            if (ReturnRedGem.setChronolithShard == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(chronolithShardCountText.transform, false);
                treasureText.transform.position = chronolithShardCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setChronolithShard = false;
            }
            #endregion

            // sideriumEssence
            #region sideriumEssencePopUP
            if (ReturnRedGem.setSideriumEssence == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(sideriumEssenceCountText.transform, false);
                treasureText.transform.position = sideriumEssenceCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setSideriumEssence = false;
            }
            #endregion

            // quasarite
            #region quasaritePopUP
            if (ReturnRedGem.setQuasarite == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(quasariteCountText.transform, false);
                treasureText.transform.position = quasariteCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setQuasarite = false;
            }
            #endregion

            // radiantNovaStone
            #region radiantNovaStonePopUP
            if (ReturnRedGem.setRadiantNovaStone == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(radiantNovaStoneCountText.transform, false);
                treasureText.transform.position = radiantNovaStoneCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setRadiantNovaStone = false;
            }
            #endregion

            // soluniumShard
            #region soluniumShardPopUP
            if (ReturnRedGem.setSoluniumShard == true)
            {
                Sounds();
                GameObject treasureText = ObjectPooling.instance.GetGoldTextFromPool();
                treasureText.transform.SetParent(soluniumShardCountText.transform, false);
                treasureText.transform.position = soluniumShardCountText.transform.position;
                treasureText.transform.localScale = new Vector3(textSize, textSize, textSize);
                treasureText.GetComponent<Animation>().Play();
                if (ReturnRedGem.isTreasureDouble == true) { treasureText.GetComponent<TextMeshProUGUI>().text = "+2"; }
                if (ReturnRedGem.isTreasureDouble == false) { treasureText.GetComponent<TextMeshProUGUI>().text = "+1"; }

                StartCoroutine(ReturnTextFromPoolDelayed(treasureText, 0.7f));

                ReturnRedGem.setSoluniumShard = false;
            }
            #endregion
        }
    }

    private IEnumerator ReturnTextFromPoolDelayed(GameObject treasureText, float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        ObjectPooling.instance.ReturnGoldTextFromPool(treasureText);
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

    public static bool setTreasureTextRed;


    #region resetButtonSetLocked

    public void ResetLocked()
    {
        redGemLocked.SetActive(true);
        amethystLocked.SetActive(true);
        diamondLocked.SetActive(true);
        violeyCrystalLocked.SetActive(true);
        yellowSapphireLocked.SetActive(true);
        greenDiamondLocked.SetActive(true);
        grandidieriteLocked.SetActive(true);
        purpleRupeeLocked.SetActive(true);
        pinkPlortLocked.SetActive(true);
        emeraldLocked.SetActive(true);
        quartzLocked.SetActive(true);
        redGarnetLocked.SetActive(true);
        pinkTourmalineLocked.SetActive(true);
        yellowTopazLocked.SetActive(true);
        aquamarineLocked.SetActive(true);
        fireOpalLocked.SetActive(true);
        goldenSeaPearlLocked.SetActive(true);
        akoyaPearlLocked.SetActive(true);
        gemSilicaLocked.SetActive(true);
        adventurineLocked.SetActive(true);
        kyaniteLocked.SetActive(true);
        albiteLocked.SetActive(true);
        blackOpalLocked.SetActive(true);
        painiteLocked.SetActive(true);
        tanzaniteLocked.SetActive(true);

        astraliumLocked.SetActive(true);
        elysiumPrismLocked.SetActive(true);
        aetherfireOpalLocked.SetActive(true);
        eldritchStarstoneLocked.SetActive(true);
        chronolithShardLocked.SetActive(true);
        sideriumEssenceLocked.SetActive(true);
        quasariteLocked.SetActive(true);
        radiantNovaStoneLocked.SetActive(true);
        soluniumShardLocked.SetActive(true);
    }

    #endregion

    public TextMeshProUGUI sellText;
    public GameObject sellBar;
    public static int treasureNumber;
    public GameObject transformBar;

    public void ExitSellBar()
    {
        sellBar.SetActive(false);
    }

    //Common
    #region sellQaurtz
    public void OpenSellQuartz()
    {
        SetSellZero();
        if(PlaceMobileButtons.isMobile== false)
        {
            transformBar.transform.position = quartzLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 1) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 1;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UnlockChests.currentSellPrice * SkillTree.soldTreasureBuff) + Localization.sellGold; 
    }
    #endregion

    #region sellAmerthyst
    public void OpenSellAmethyst()
    {
        SetSellZero();
        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = amethystLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 2) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 2;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 1.01f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    #region sellYellowTopaz
    public void OpenSellYellopTopaz()
    {
        SetSellZero();
        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = yellowTopazLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 3) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 3;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 1.02f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    #region sellAlbite
    public void OpenSellAlbite()
    {
        SetSellZero();

        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = albiteLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 4) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 4;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 1.03f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    #region sellRedGarnet
    public void OpenSellRedGarnet()
    {
        SetSellZero();

        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = redGarnetLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 5) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 5;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 1.04f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    //Uncommon
    #region sellAquamarine
    public void OpenSellAquamarine()
    {
        SetSellZero();

        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = aquamarineLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }
          
        if (treasureNumber != 6) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 6;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 1.1f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    #region sellYellowSapphire
    public void OpenSellYellowSapphire()
    {
        SetSellZero();

        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = yellowSapphireLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 7) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 7;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 1.12f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    #region sellPinkTourmaline
    public void OpenSellPinkTourmaline()
    {
        SetSellZero();

        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = pinkTourmalineLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 8) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 8;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 1.13f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    #region sellAdventurine
    public void OpenSellAdventurine()
    {
        SetSellZero();

        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = adventurineLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 9) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 9;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 1.14f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    //Rare
    #region sellRedRuby
    public void OpenSellRedRuby()
    {
        SetSellZero();

        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = redGemLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 10) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 10;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 1.25f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    #region sellDiamond
    public void OpenSellDiamond()
    {
        SetSellZero();

        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = diamondLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 11) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 11;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 1.27f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    #region sellGrandiderite
    public void OpenSellGrandiderite()
    {
        SetSellZero();

        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = grandidieriteLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 12) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 12;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 1.29f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    #region sellVioletCrystal
    public void OpenSellVioletCrystal()
    {
        SetSellZero();

        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = violeyCrystalLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 13) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 13;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 1.30f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    #region sellAkoyaPearl
    public void OpenSellAkoyaPearl()
    {
        SetSellZero();

        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = akoyaPearlLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 14) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 14;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 1.32f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    //Very Rare
    #region sellPurpleRupee
    public void OpenSellPrupleRupee()
    {
        SetSellZero();

        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = purpleRupeeLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 15) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 15;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 1.41f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    #region sellEmerald
    public void OpenSellEmerald()
    {
        SetSellZero();

        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = emeraldLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 16) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 16;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 1.42f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    #region greenDiamond
    public void OpenSellGreenDiamond()
    {
        SetSellZero();

        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = greenDiamondLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 17) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 17;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 1.44f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    #region fireOpal
    public void OpenSellFireOpal()
    {
        SetSellZero();
        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = fireOpalLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 18) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 18;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 1.45f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    #region sellGemSilica
    public void OpenSellGemSilica()
    {
        SetSellZero();

        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = gemSilicaLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 19) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 19;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 1.48f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    //ExtremelyRare
    #region SellPinkPlort
    public void OpenSellPinkPlort()
    {
        SetSellZero();

        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = pinkPlortLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 20) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 20;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 1.8f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    #region sellGoldneSeaPearl
    public void OpenSellGoldenSeaPearl()
    {
        SetSellZero();

        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = goldenSeaPearlLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 21) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 21;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 1.86f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    #region sellKyanite
    public void OpenSellKyanite()
    {
        SetSellZero();

        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = kyaniteLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 22) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 22;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 1.9f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    //Legendary
    #region sellBlackOpal
    public void OpenSellBlackOpal()
    {
        SetSellZero();

        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = blackOpalLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 23) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 23;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 2.25f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    #region sellPainite
    public void OpenSellPainite()
    {
        SetSellZero();

        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = painiteLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 24) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 24;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 2.27f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    #region sellTanzanite
    public void OpenSellTanzanite()
    {
        SetSellZero();

        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = tanzaniteLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 25) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 25;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 2.3f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion


    //New Treasures

    // astralium
    #region sellAstralium
    public void OpenSellAstralium()
    {
        SetSellZero();

        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = astraliumLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 26) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 26;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 2.4f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    // elysiumPrism
    #region sellElysiumPrism
    public void OpenSellElysiumPrism()
    {
        SetSellZero();

        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = elysiumPrismLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 27) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 27;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 2.5f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    // aetherfireOpal
    #region sellAetherfireOpal
    public void OpenSellAetherfireOpal()
    {
        SetSellZero();

        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = aetherfireOpalLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 28) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 28;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 2.6f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    // eldritchStarstone
    #region sellEldritchStarstone
    public void OpenSellEldritchStarstone()
    {
        SetSellZero();

        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = eldritchStarstoneLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 29) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 29;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 2.7f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    // chronolithShard
    #region sellChronolithShard
    public void OpenSellChronolithShard()
    {
        SetSellZero();

        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = chronolithShardLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 30) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 30;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 2.8f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    // sideriumEssence
    #region sellSideriumEssence
    public void OpenSellSideriumEssence()
    {
        SetSellZero();

        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = sideriumEssenceLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 31) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 31;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 2.9f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    // quasarite
    #region sellQuasarite
    public void OpenSellQuasarite()
    {
        SetSellZero();

        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = quasariteLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 32) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 32;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 3f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    // radiantNovaStone
    #region sellRadiantNovaStone
    public void OpenSellRadiantNovaStone()
    {
        SetSellZero();
        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = radiantNovaStoneLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 33) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 33;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 3.1f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion

    // soluniumShard
    #region sellSoluniumShard
    public void OpenSellSoluniumShard()
    {
        SetSellZero();

        if (PlaceMobileButtons.isMobile == false)
        {
            transformBar.transform.position = soluniumShardLocked.transform.position;
            sellBar.transform.position = transformBar.transform.position;
        }

        if (treasureNumber != 34) { sellBar.SetActive(true); }
        else
        {
            if (sellBar.activeInHierarchy == true) { sellBar.SetActive(false); }
            else if (sellBar.activeInHierarchy == false) { sellBar.SetActive(true); }
        }

        treasureNumber = 34;
        sellText.text = Localization.sellTreasureFor + "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((UnlockChests.currentSellPrice * 3.2f) * SkillTree.soldTreasureBuff) + Localization.sellGold;
    }
    #endregion


    #region SellTreasures
    public void SellTreasures()
    {
        //Quartz
        if(treasureNumber == 1)
        {
            if (quartzCount == 0) { ErrorSound(); }
            if (quartzCount > 0)
            {
                SellSound();
                quartzCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += UnlockChests.currentSellPrice * SkillTree.soldTreasureBuff;
            }
        }

        //Amthyst
        if (treasureNumber == 2)
        {
            if (amethystCount == 0) { ErrorSound(); }
            if (treasureNumber == 2 && amethystCount > 0)
            {
                SellSound();
                amethystCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 1.01f) * SkillTree.soldTreasureBuff;
            }
        }

        //YellowTopaz
        if (treasureNumber == 3)
        {
            if (yellowTopazCount == 0) { ErrorSound(); }
            if (treasureNumber == 3 && yellowTopazCount > 0)
            {
                SellSound();
                yellowTopazCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 1.02f) * SkillTree.soldTreasureBuff;
            }
        }

        if (treasureNumber == 4)
        {
            //Albite
            if (albiteCount == 0) { ErrorSound(); }
            if (treasureNumber == 4 && albiteCount > 0)
            {
                SellSound();
                albiteCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 1.03f) * SkillTree.soldTreasureBuff;
            }
        }

        if (treasureNumber == 5)
        {
            //RedGarnet
            if (redGarnetCount == 0) { ErrorSound(); }
            if (treasureNumber == 5 && redGarnetCount > 0)
            {
                SellSound();
                redGarnetCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 1.04f) * SkillTree.soldTreasureBuff;
            }
        }

        if (treasureNumber == 6)
        {
            //Aquamarine
            if (aquamarineCount == 0) { ErrorSound(); }
            if (treasureNumber == 6 && aquamarineCount > 0)
            {
                SellSound();
                aquamarineCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 1.1f) * SkillTree.soldTreasureBuff;
            }
        }

        if (treasureNumber == 7)
        {
            //YellowSapphire
            if (yellowSapphireCount == 0) { ErrorSound(); }
            if (treasureNumber == 7 && yellowSapphireCount > 0)
            {
                SellSound();
                yellowSapphireCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 1.12f) * SkillTree.soldTreasureBuff;
            }
        }

        if (treasureNumber == 8)
        {
            //PinkTourmaline
            if (pinkTourmalineCount == 0) { ErrorSound(); }
            if (treasureNumber == 8 && pinkTourmalineCount > 0)
            {
                SellSound();
                pinkTourmalineCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 1.13f) * SkillTree.soldTreasureBuff;
            }
        }

        if (treasureNumber == 9)
        {
            //Adventurine
            if (AdventurineCount == 0) { ErrorSound(); }
            if (treasureNumber == 9 && AdventurineCount > 0)
            {
                SellSound();
                AdventurineCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 1.14f) * SkillTree.soldTreasureBuff;
            }

        }

        if (treasureNumber == 10)
        {
            //RedRuby
            if (RedGemCount == 0) { ErrorSound(); }
            if (treasureNumber == 10 && RedGemCount > 0)
            {
                SellSound();
                RedGemCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 1.25f) * SkillTree.soldTreasureBuff;
            }
        }

        if (treasureNumber == 11)
        {
            //diamond
            if (diamondCount == 0) { ErrorSound(); }
            if (treasureNumber == 11 && diamondCount > 0)
            {
                SellSound();
                diamondCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 1.27f) * SkillTree.soldTreasureBuff;
            }
        }

        if (treasureNumber == 12)
        {
            //grandiderite
            if (grandidieriteCount == 0) { ErrorSound(); }
            if (treasureNumber == 12 && grandidieriteCount > 0)
            {
                SellSound();
                grandidieriteCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 1.29f) * SkillTree.soldTreasureBuff; 
            }
        }

        if (treasureNumber == 13)
        {
            //violetCrystal
            if (violetCrystalCount == 0) { ErrorSound(); }
            if (violetCrystalCount > 0)
            {
                SellSound();
                violetCrystalCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 1.3f) * SkillTree.soldTreasureBuff;
            }
        }

        if (treasureNumber == 14)
        {
            //AkoyaPearl
            if (akoyaPearlCount == 0) { ErrorSound(); }
            if (akoyaPearlCount > 0)
            {
                SellSound();
                akoyaPearlCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 1.31f) * SkillTree.soldTreasureBuff;
            }
        }

        if (treasureNumber == 15)
        {
            //PurpleRupee
            if (purpleRupeeCount == 0) { ErrorSound(); }
            if (purpleRupeeCount > 0)
            {
                SellSound();
                purpleRupeeCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 1.41f) * SkillTree.soldTreasureBuff;
            }
        }

        if (treasureNumber == 16)
        {
            //Emerald
            if (emeraldCount == 0) { ErrorSound(); }
            if (emeraldCount > 0)
            {
                SellSound();
                emeraldCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 1.43f) * SkillTree.soldTreasureBuff;
            }
        }

        if (treasureNumber == 17)
        {
            //GreenDiamond
            if (greenDiamondCount == 0) { ErrorSound(); }
            if (greenDiamondCount > 0)
            {
                SellSound();
                greenDiamondCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 1.44f) * SkillTree.soldTreasureBuff;
            }
        }

        if (treasureNumber == 18)
        {
            //FireOpal
            if (fireOpalCount == 0) { ErrorSound(); }
            if (fireOpalCount > 0)
            {
                SellSound();
                fireOpalCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 1.45f) * SkillTree.soldTreasureBuff;
            }
        }

        if (treasureNumber == 19)
        {
            //GemSilica
            if (gemSilicaCount == 0) { ErrorSound(); }
            if (gemSilicaCount > 0)
            {
                SellSound();
                gemSilicaCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 1.48f) * SkillTree.soldTreasureBuff;
            }
        }

        if (treasureNumber == 20)
        {
            //PinkPlort
            if (pinkPlostCount == 0) { ErrorSound(); }
            if (pinkPlostCount > 0)
            {
                SellSound();
                pinkPlostCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 1.8f) * SkillTree.soldTreasureBuff;
            }
        }

        if (treasureNumber == 21)
        {
            //GoldenSeaPeal
            if (goldeSeaPearlCount == 0) { ErrorSound(); }
            if (goldeSeaPearlCount > 0)
            {
                SellSound();
                goldeSeaPearlCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 1.85f) * SkillTree.soldTreasureBuff;
            }
        }

        if (treasureNumber == 22)
        {
            //Kyanite
            if (kyaniteCount == 0) { ErrorSound(); }
            if (kyaniteCount > 0)
            {
                SellSound();
                kyaniteCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 1.9f) * SkillTree.soldTreasureBuff;
            }
        }

        if (treasureNumber == 23)
        {
            //BlackOpal
            if (blackOpalCount == 0) { ErrorSound(); }
            if (blackOpalCount > 0)
            {
                SellSound();
                blackOpalCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 2.25f) * SkillTree.soldTreasureBuff;
            }
        }

        if (treasureNumber == 24)
        {
            //Painite
            if (painiteCount == 0) { ErrorSound(); }
            if (painiteCount > 0)
            {
                SellSound();
                painiteCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 2.27f) * SkillTree.soldTreasureBuff;
            }
        }

        if (treasureNumber == 25)
        {
            //Tanzanite
            if (TanzaniteCount == 0) { ErrorSound(); }
            if (TanzaniteCount > 0)
            {
                SellSound();
                TanzaniteCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 2.3f) * SkillTree.soldTreasureBuff;
            }
        }

        if (treasureNumber == 26)
        {
            if (astraliumCount == 0) { ErrorSound(); }
            if (astraliumCount > 0)
            {
                SellSound();
                astraliumCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 2.4f) * SkillTree.soldTreasureBuff;
            }
        }

        if (treasureNumber == 27)
        {
            if (elysiumPrismCount == 0) { ErrorSound(); }
            if (elysiumPrismCount > 0)
            {
                SellSound();
                elysiumPrismCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 2.5f) * SkillTree.soldTreasureBuff;
            }
        }

        if (treasureNumber == 28)
        {
            if (aetherfireOpalCount == 0) { ErrorSound(); }
            if (aetherfireOpalCount > 0)
            {
                SellSound();
                aetherfireOpalCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 2.6f) * SkillTree.soldTreasureBuff;
            }
        }
        if (treasureNumber == 29)
        {
            if (eldritchStarstoneCount == 0) { ErrorSound(); }
            if (eldritchStarstoneCount > 0)
            {
                SellSound();
                eldritchStarstoneCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 2.7f) * SkillTree.soldTreasureBuff;
            }

        }

        if (treasureNumber == 30)
        {
            if (chronolithShardCount == 0) { ErrorSound(); }
            if (chronolithShardCount > 0)
            {
                SellSound();
                chronolithShardCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 2.8f) * SkillTree.soldTreasureBuff;
            }
        }

        if (treasureNumber == 31)
        {
            if (sideriumEssenceCount == 0) { ErrorSound(); }
            if (sideriumEssenceCount > 0)
            {
                SellSound();
                sideriumEssenceCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 2.9f) * SkillTree.soldTreasureBuff;
            }
        }

        if (treasureNumber == 32)
        {
            if (quasariteCount == 0) { ErrorSound(); }
            if (quasariteCount > 0)
            {
                SellSound();
                quasariteCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 3f) * SkillTree.soldTreasureBuff;
            }
        }

        if (treasureNumber == 33)
        {
            if (radiantNovaStoneCount == 0) { ErrorSound(); }
            if (radiantNovaStoneCount > 0)
            {
                SellSound();
                radiantNovaStoneCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 3.1f) * SkillTree.soldTreasureBuff;
            }
        }

        if (treasureNumber == 34)
        {
            if (soluniumShardCount == 0) { ErrorSound(); }
            if (soluniumShardCount > 0)
            {
                SellSound();
                soluniumShardCount -= 1;
                isGemCountUpdated = true;

                UpdateGame.totalGoldHigher += (UnlockChests.currentSellPrice * 3.2f) * SkillTree.soldTreasureBuff;
            }
        }

    }
    #endregion

    #region SellAllTreasures
    public void SellAllTreasures()
    {
        //Quartz
        if (treasureNumber == 1)
        {
            if (quartzCount == 0) { ErrorSound(); }
            if (quartzCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * SkillTree.soldTreasureBuff) ) * quartzCount;

                quartzCount -= quartzCount;
                isGemCountUpdated = true;
            }
        }

        //Amthyst
        if (treasureNumber == 2)
        {
            if (amethystCount == 0) { ErrorSound(); }
            if (treasureNumber == 2 && amethystCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 1.01f) * SkillTree.soldTreasureBuff) * amethystCount;

                amethystCount -= amethystCount;
                isGemCountUpdated = true;
            }
        }

        //YellowTopaz
        if (treasureNumber == 3)
        {
            if (yellowTopazCount == 0) { ErrorSound(); }
            if (treasureNumber == 3 && yellowTopazCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 1.02f) * SkillTree.soldTreasureBuff) * yellowTopazCount;

                yellowTopazCount -= yellowTopazCount;
                isGemCountUpdated = true;
            }
        }

        if (treasureNumber == 4)
        {
            //Albite
            if (albiteCount == 0) { ErrorSound(); }
            if (treasureNumber == 4 && albiteCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 1.03f) * SkillTree.soldTreasureBuff) * albiteCount;

                albiteCount -= albiteCount;
                isGemCountUpdated = true;
            }
        }

        if (treasureNumber == 5)
        {
            //RedGarnet
            if (redGarnetCount == 0) { ErrorSound(); }
            if (treasureNumber == 5 && redGarnetCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 1.04f) * SkillTree.soldTreasureBuff) * redGarnetCount;

                redGarnetCount -= redGarnetCount;
                isGemCountUpdated = true;

            }
        }

        if (treasureNumber == 6)
        {
            //Aquamarine
            if (aquamarineCount == 0) { ErrorSound(); }
            if (treasureNumber == 6 && aquamarineCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 1.1f) * SkillTree.soldTreasureBuff) * aquamarineCount;

                aquamarineCount -= aquamarineCount;
                isGemCountUpdated = true;

            }
        }

        if (treasureNumber == 7)
        {
            //YellowSapphire
            if (yellowSapphireCount == 0) { ErrorSound(); }
            if (treasureNumber == 7 && yellowSapphireCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 1.12f) * SkillTree.soldTreasureBuff) * yellowSapphireCount;

                yellowSapphireCount -= yellowSapphireCount;
                isGemCountUpdated = true;
            }
        }

        if (treasureNumber == 8)
        {
            //PinkTourmaline
            if (pinkTourmalineCount == 0) { ErrorSound(); }
            if (pinkTourmalineCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 1.13f) * SkillTree.soldTreasureBuff) * pinkTourmalineCount;

                pinkTourmalineCount -= pinkTourmalineCount;
                isGemCountUpdated = true;
            }
        }

        if (treasureNumber == 9)
        {
            //Adventurine
            if (AdventurineCount == 0) { ErrorSound(); }
            if (AdventurineCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 1.14f) * SkillTree.soldTreasureBuff) * AdventurineCount;

                AdventurineCount -= AdventurineCount;
                isGemCountUpdated = true;
            }

        }

        if (treasureNumber == 10)
        {
            //RedRuby
            if (RedGemCount == 0) { ErrorSound(); }
            if (RedGemCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 1.25f) * SkillTree.soldTreasureBuff) * RedGemCount;

                RedGemCount -= RedGemCount;
                isGemCountUpdated = true;
            }
        }

        if (treasureNumber == 11)
        {
            //diamond
            if (diamondCount == 0) { ErrorSound(); }
            if (diamondCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 1.27f) * SkillTree.soldTreasureBuff) * diamondCount;

                diamondCount -= diamondCount;
                isGemCountUpdated = true;
            }
        }

        if (treasureNumber == 12)
        {
            //grandiderite
            if (grandidieriteCount == 0) { ErrorSound(); }
            if (treasureNumber == 12 && grandidieriteCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 1.28f) * SkillTree.soldTreasureBuff) * grandidieriteCount;
                
                grandidieriteCount -= grandidieriteCount;
                isGemCountUpdated = true;
            }
        }

        if (treasureNumber == 13)
        {
            //violetCrystal
            if (violetCrystalCount == 0) { ErrorSound(); }
            if (violetCrystalCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 1.3f) * SkillTree.soldTreasureBuff) * violetCrystalCount;

                violetCrystalCount -= violetCrystalCount;
                isGemCountUpdated = true;
            }
        }

        if (treasureNumber == 14)
        {
            //AkoyaPearl
            if (akoyaPearlCount == 0) { ErrorSound(); }
            if (akoyaPearlCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 1.31f) * SkillTree.soldTreasureBuff) * akoyaPearlCount;

                akoyaPearlCount -= akoyaPearlCount;
                isGemCountUpdated = true;
            }
        }

        if (treasureNumber == 15)
        {
            //PurpleRupee
            if (purpleRupeeCount == 0) { ErrorSound(); }
            if (purpleRupeeCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 1.41f) * SkillTree.soldTreasureBuff) * purpleRupeeCount;

                purpleRupeeCount -= purpleRupeeCount;
                isGemCountUpdated = true;
            }
        }

        if (treasureNumber == 16)
        {
            //Emerald
            if (emeraldCount == 0) { ErrorSound(); }
            if (emeraldCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 1.42f) * SkillTree.soldTreasureBuff) * emeraldCount;

                emeraldCount -= emeraldCount;
                isGemCountUpdated = true;
            }
        }

        if (treasureNumber == 17)
        {
            //GreenDiamond
            if (greenDiamondCount == 0) { ErrorSound(); }
            if (greenDiamondCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 1.43f) * SkillTree.soldTreasureBuff) * greenDiamondCount;

                greenDiamondCount -= greenDiamondCount;
                isGemCountUpdated = true;
            }
        }

        if (treasureNumber == 18)
        {
            //FireOpal
            if (fireOpalCount == 0) { ErrorSound(); }
            if (fireOpalCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 1.45f) * SkillTree.soldTreasureBuff) * fireOpalCount;

                fireOpalCount -= fireOpalCount;
                isGemCountUpdated = true;
            }
        }

        if (treasureNumber == 19)
        {
            //GemSilica
            if (gemSilicaCount == 0) { ErrorSound(); }
            if (gemSilicaCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 1.48f) * SkillTree.soldTreasureBuff) * gemSilicaCount;

                gemSilicaCount -= gemSilicaCount;
                isGemCountUpdated = true;
            }
        }

        if (treasureNumber == 20)
        {
            //PinkPlort
            if (pinkPlostCount == 0) { ErrorSound(); }
            if (pinkPlostCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 1.8f) * SkillTree.soldTreasureBuff) * pinkPlostCount;

                pinkPlostCount -= pinkPlostCount;
                isGemCountUpdated = true;
            }
        }

        if (treasureNumber == 21)
        {
            //GoldenSeaPeal
            if (goldeSeaPearlCount == 0) { ErrorSound(); }
            if (goldeSeaPearlCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 1.85f) * SkillTree.soldTreasureBuff) * goldeSeaPearlCount;

                goldeSeaPearlCount -= goldeSeaPearlCount;
                isGemCountUpdated = true;
            }
        }

        if (treasureNumber == 22)
        {
            //Kyanite
            if (kyaniteCount == 0) { ErrorSound(); }
            if (kyaniteCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 1.9f) * SkillTree.soldTreasureBuff) * kyaniteCount;

                kyaniteCount -= kyaniteCount;
                isGemCountUpdated = true;
            }
        }

        if (treasureNumber == 23)
        {
            //BlackOpal
            if (blackOpalCount == 0) { ErrorSound(); }
            if (blackOpalCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 2.25f) * SkillTree.soldTreasureBuff) * blackOpalCount;

                blackOpalCount -= blackOpalCount;
                isGemCountUpdated = true;
            }
        }

        if (treasureNumber == 24)
        {
            //Painite
            if (painiteCount == 0) { ErrorSound(); }
            if (painiteCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 2.27f) * SkillTree.soldTreasureBuff) * painiteCount;

                painiteCount -= painiteCount;
                isGemCountUpdated = true;
            }
        }

        if (treasureNumber == 25)
        {
            //Tanzanite
            if (TanzaniteCount == 0) { ErrorSound(); }
            if (TanzaniteCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 2.3f) * SkillTree.soldTreasureBuff) * TanzaniteCount;

                TanzaniteCount -= TanzaniteCount;
                isGemCountUpdated = true;
            }
        }

        if (treasureNumber == 26)
        {
            // astralium
            if (astraliumCount == 0) { ErrorSound(); }
            if (astraliumCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 2.4f) * SkillTree.soldTreasureBuff) * astraliumCount;
                astraliumCount -= astraliumCount;
                isGemCountUpdated = true;
            }
        }

        if (treasureNumber == 27)
        {
            // elysiumPrism
            if (elysiumPrismCount == 0) { ErrorSound(); }
            if (elysiumPrismCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 2.5f) * SkillTree.soldTreasureBuff) * elysiumPrismCount;
                elysiumPrismCount -= elysiumPrismCount;
                isGemCountUpdated = true;
            }
        }

        if (treasureNumber == 28)
        {
            // aetherfireOpal
            if (aetherfireOpalCount == 0) { ErrorSound(); }
            if (aetherfireOpalCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 2.6f) * SkillTree.soldTreasureBuff) * aetherfireOpalCount;
                aetherfireOpalCount -= aetherfireOpalCount;
                isGemCountUpdated = true;
            }
        }

        if (treasureNumber == 29)
        {
            // eldritchStarstone
            if (eldritchStarstoneCount == 0) { ErrorSound(); }
            if (eldritchStarstoneCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 2.7f) * SkillTree.soldTreasureBuff) * eldritchStarstoneCount;
                eldritchStarstoneCount -= eldritchStarstoneCount;
                isGemCountUpdated = true;
            }
        }

        if (treasureNumber == 30)
        {
            // chronolithShard
            if (chronolithShardCount == 0) { ErrorSound(); }
            if (chronolithShardCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 2.8f) * SkillTree.soldTreasureBuff) * chronolithShardCount;
                chronolithShardCount -= chronolithShardCount;
                isGemCountUpdated = true;
            }
        }

        if (treasureNumber == 31)
        {
            // sideriumEssence
            if (sideriumEssenceCount == 0) { ErrorSound(); }
            if (sideriumEssenceCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 2.9f) * SkillTree.soldTreasureBuff) * sideriumEssenceCount;
                sideriumEssenceCount -= sideriumEssenceCount;
                isGemCountUpdated = true;
            }
        }

        if (treasureNumber == 32)
        {
            // quasarite
            if (quasariteCount == 0) { ErrorSound(); }
            if (quasariteCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 3f) * SkillTree.soldTreasureBuff) * quasariteCount;
                quasariteCount -= quasariteCount;
                isGemCountUpdated = true;
            }
        }

        if (treasureNumber == 33)
        {
            // radiantNovaStone
            if (radiantNovaStoneCount == 0) { ErrorSound(); }
            if (radiantNovaStoneCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 3.1) * SkillTree.soldTreasureBuff) * radiantNovaStoneCount;
                radiantNovaStoneCount -= radiantNovaStoneCount;
                isGemCountUpdated = true;
            }
        }

        if (treasureNumber == 34)
        {
            // soluniumShard
            if (soluniumShardCount == 0) { ErrorSound(); }
            if (soluniumShardCount > 0)
            {
                SellSound();
                UpdateGame.totalGoldHigher += ((UnlockChests.currentSellPrice * 3.2f) * SkillTree.soldTreasureBuff) * soluniumShardCount;
                soluniumShardCount -= soluniumShardCount;
                isGemCountUpdated = true;
            }
        }

    }
    #endregion

    public void SetSellZero()
    {
        SellBarInavtice.isMouseOver = true;
    }

    public void ErrorSound()
    {
        if (AudioManager.audioMuted == 1) { audioManager.Play("Error"); }
    }

    public void SellSound()
    {
        if (AudioManager.audioMuted == 1) { audioManager.Play("SellItem"); }
    }

    /*public void SaveGemCount()
    {
        SaveSystem.SaveGemsCount(this);
    }*/
}
