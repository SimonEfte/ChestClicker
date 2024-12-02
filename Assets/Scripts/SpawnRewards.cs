using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Threading.Tasks;
using System.IO;
public class SpawnRewards : MonoBehaviour, IDataPersistence
{
    public GameObject goldPrefab;
    public GameObject XP;
    public Transform parentTransform;
    public GameObject targetGameObjectXRPBar;
    //public static double goldRewardAmount;

    public static float minXSpeed;
    public static float maxXSpeed;
    public static float minYSpeed;
    public static float maxYSpeed;

    public float ySpawnPos;

    public static bool changedRareDropsChance;

    public TextMeshProUGUI quartzChanceText, amethystChanceText, yellowTopazChanceText, albiteChanceText, redGarnetChanceText, aquamarineChanceText, yellowShapphireChanceText, pinkTourmalineChanceText, adventurineChanceText, redRubyChanceText, diamondChanceText, grandidieriteChanceText, violetCrystalChanceText, akoyaPearlChanceText, purpleRupeeChanceText, emeraldChanceText, greenDiamondChanceText, fireOpalChanceText, gemSilicaChanceText, pinkPlortChanceText, goldenSeaPearlChanceText, kyaniteChanceText, blackOpalChanceText, painiteChanceText, tanzaniteChanceText, astraliumChanceText, elysiumPrismChanceText, aerthfireOpalChanceText, eldrichStarStoneChanceText, chronolithChardChanceText, sideriumEssenceChanceText, quasariteChanceText, radiantNovaStoneChanceText, soluniumShardChanceText;

    public TextMeshProUGUI quartzDoubleValue, amethystDoubleValue, yellowTopazDoubleValue, albiteDoubleValue, redGarnetDoubleValue, aquamarineDoubleValue, yellowShapphireDoubleValue, pinkTourmalineDoubleValue, adventurineDoubleValue, redRubyDoubleValue, diamondDoubleValue, grandidieriteDoubleValue, violetCrystalDoubleValue, akoyaPearlDoubleValue, purpleRupeeDoubleValue, emeraldDoubleValue, greenDiamondDoubleValue, fireOpalDoubleValue, gemSilicaDoubleValue, pinkPlortDoubleValue, goldenSeaPearlDoubleValue, kyaniteDoubleValue, blackOpalDoubleValue, painiteDoubleValue, tanzaniteDoubleValue, astraliumDoubleValue, elysiumPrismDoubleValue, aerthfireOpalDoubleValue, eldrichStarStoneDoubleValue, chronolithChardDoubleValue, sideriumEssenceDoubleValue, quasariteDoubleValue, radiantNovaStoneDoubleValue, soluniumShardDoubleValue;

    public static float quartzBaseChance, amethystBaseChance, yellowTopacBaseChance, albiteBaseChance, redGarnetBaseChance, aquamarineBaseChance, yellowSapphireBaseChance, pinkTourmalineBaseChance, adventurineBaseChance, redGemCBaseChance, diamondBaseChance, grandidieriteBaseChance, violetBaseChance, akoyaPearlBaseChance, purpleRupeeBaseChance, emeraldDropBaseChance, greenDiamondBaseChance, fireOpalBaseChance, gemSilicaBaseChance, pinkPlortBaseChance, goldenSeaPearlBaseChance, kyaniteBaseChance, blackOpalBaseChance, painiteBaseChance, tanzaniteBaseChance, astraliumBaseChance, elysiumPrismBaseChance, aerthfireOpalBaseChance, eldrichStarStoneBaseChance, chronolithChardBaseChance, sideriumEssenceBaseChance, quasariteBaseChance, radiantNovaStoneBaseChance, soluniumShardBaseChance;

    public static float doubleRareDropChance;

    public TextMeshProUGUI pirateSkullDropChanceText, swordDropChanceText, ringDropChanceText, trophyDropChanceText, starDropChanceText, cloverDropChanceText, crownDropChanceText, bookDropChanceText, guitarDropChanceText, talarianDropChanceText, runeDropChanceText, backPackDropChanceText, shieldDropChanceText, pillBottleDropChanceText, medalDropChanceText, cookieDropChanceText, presentDropChanceText, axeDropChanceText, coin100XDropChanceText, envelopeDropChanceText, potionDropChanceText, soulGemDropChanceText, scrollDropChanceText, brickDropChanceText, chickenDropChanceText;


    public void Start()
    {
        minXSpeed = -7.2f;
        maxXSpeed = 7.2f;
        minYSpeed = 5.9f;
        maxYSpeed = 10.7f;

        maxTreasuresBags = 0;
        treasuresYPos = -0.5f;
        ySpawnPos = -0.5f;

        Invoke("wait", 0.7f);
    }


    public void wait()
    {
        string path = Application.persistentDataPath + "/player.saveTreasureChance";

        if (File.Exists(path))
        {
            if (SaveAndLoad.onlyLoadNewSave == false)
            {
                GameData data = SaveSystem.LoadTreasureDropChance();

                doubleRareDropChance = data.doubleValueTreasure;

                prestigeKeyFound = data.prestigeKeyFound;
                prestigeChestFound = data.prestigeChestFound;

                quartzBaseChance = data.quartzBaseChance;
                amethystBaseChance = data.amethystBaseChance;
                yellowTopacBaseChance = data.yellowTopazBaseChance;
                albiteBaseChance = data.albiteBaseChance;
                redGarnetBaseChance = data.redGarnetBaseChance;
                aquamarineBaseChance = data.aquamarineBaseChance;
                yellowSapphireBaseChance = data.yellowSapphireBaseChance;
                pinkTourmalineBaseChance = data.pinkTourmalineBaseChance;
                adventurineBaseChance = data.adventurineBaseChance;
                redGemCBaseChance = data.redGemCBaseChance;
                diamondBaseChance = data.diamondBaseChance;
                grandidieriteBaseChance = data.grandidieriteBaseChance;
                akoyaPearlBaseChance = data.akoyaPearlBaseChance;
                purpleRupeeBaseChance = data.purpleRupeeBaseChance;
                violetBaseChance = data.violetBaseChance;
                emeraldDropBaseChance = data.emeraldDropBaseChance;
                greenDiamondBaseChance = data.greenDiamondBaseChance;
                fireOpalBaseChance = data.fireOpalBaseChance;
                gemSilicaBaseChance = data.gemSilicaBaseChance;
                pinkPlortBaseChance = data.pinkPlortBaseChance;
                goldenSeaPearlBaseChance = data.goldenSeaPearlBaseChance;
                kyaniteBaseChance = data.kyaniteBaseChance;
                blackOpalBaseChance = data.blackOpalBaseChance;
                painiteBaseChance = data.painiteBaseChance;
                tanzaniteBaseChance = data.tanzaniteBaseChance;
            }
            else { }

            StartCoroutine(deleteOldSaveFile());

        }
        else
        {
            //Do nothing
        }

        changedRareDropsChance = true;

        quartzDropChance = quartzBaseChance;
        amethystDropChance = amethystBaseChance;
        yellowTopacChance = yellowTopacBaseChance;
        albiteChance = albiteBaseChance;
        redGarnetDropChance = redGarnetBaseChance;
        aquamarineChance = aquamarineBaseChance;
        yellowSapphireChance = yellowSapphireBaseChance;
        pinkTourmalineChance = pinkTourmalineBaseChance;
        adventurineChance = adventurineBaseChance;
        redGemChance = redGemCBaseChance;
        diamondDropChance = diamondBaseChance;
        grandidieriteChance = grandidieriteBaseChance;
        violetDropChance = violetBaseChance;
        akoyaPearlChance = akoyaPearlBaseChance;
        purpleRupeeDropChance = purpleRupeeBaseChance;
        emeraldDropChance = emeraldDropBaseChance;
        greenDiamondChance = greenDiamondBaseChance;
        fireOpalChance = fireOpalBaseChance;
        gemSilicaChance = gemSilicaBaseChance;
        pinkPlortDropChance = pinkPlortBaseChance;
        goldenSeaPearlChance = goldenSeaPearlBaseChance;
        kyaniteChance = kyaniteBaseChance;
        blackOpalChance = blackOpalBaseChance;
        painiteChance = painiteBaseChance;
        tanzaniteChance = tanzaniteBaseChance;

        //New
        astraliumChance = astraliumBaseChance;
        elysiumPrismChance = elysiumPrismBaseChance;
        aetherfireOpalChance = aerthfireOpalBaseChance;
        eldritchStarstoneChance = eldrichStarStoneBaseChance;
        chronolithShardChance = chronolithChardBaseChance;
        sideriumEssenceChance = sideriumEssenceBaseChance;
        quasariteChance = quasariteBaseChance;
        radiantNovaStoneChance = radiantNovaStoneBaseChance;
        soluniumShardChance = soluniumShardBaseChance;


        if (prestigeKeyFound == 1)
        {
            prestigeKeyFoundd.SetActive(true); prestigeKeyNotFound.SetActive(false);
            findTheChestAndKeyText.text = Localization.FindThePrestigeKeyandChest;
            findTheChestAndKeyText.color = Color.red;
        }

        if (prestigeChestFound == 1)
        {
            prestigeChestFoundd.SetActive(true); prestigeChestNotFound.SetActive(false);
            findTheChestAndKeyText.text = Localization.FindThePrestigeKeyandChest;
            findTheChestAndKeyText.color = Color.red;
        }

        if (prestigeChestFound == 1 && prestigeKeyFound == 1)
        {
            prestigeButtonRed.SetActive(false); prestigeButtonGreen.SetActive(true);
            findTheChestAndKeyText.text = Localization.youFoundThePrestigeKetAndChest;
            findTheChestAndKeyText.color = Color.green;
        }

        RareTreasuresChances();
        changeDropChanceValues = true;
    }


    #region SaveAndLoadJSON
    public void LoadData(GameDataJSON data)
    {
        doubleRareDropChance = data.doubleValueTreasure;

        prestigeKeyFound = data.prestigeKeyFound;
        prestigeChestFound = data.prestigeChestFound;

        quartzBaseChance = data.quartzBaseChance;
        amethystBaseChance = data.amethystBaseChance;
        yellowTopacBaseChance = data.yellowTopazBaseChance;
        albiteBaseChance = data.albiteBaseChance;
        redGarnetBaseChance = data.redGarnetBaseChance;
        aquamarineBaseChance = data.aquamarineBaseChance;
        yellowSapphireBaseChance = data.yellowSapphireBaseChance;
        pinkTourmalineBaseChance = data.pinkTourmalineBaseChance;
        adventurineBaseChance = data.adventurineBaseChance;
        redGemCBaseChance = data.redGemCBaseChance;
        diamondBaseChance = data.diamondBaseChance;
        grandidieriteBaseChance = data.grandidieriteBaseChance;
        akoyaPearlBaseChance = data.akoyaPearlBaseChance;
        purpleRupeeBaseChance = data.purpleRupeeBaseChance;
        violetBaseChance = data.violetBaseChance;
        emeraldDropBaseChance = data.emeraldDropBaseChance;
        greenDiamondBaseChance = data.greenDiamondBaseChance;
        fireOpalBaseChance = data.fireOpalBaseChance;
        gemSilicaBaseChance = data.gemSilicaBaseChance;
        pinkPlortBaseChance = data.pinkPlortBaseChance;
        goldenSeaPearlBaseChance = data.goldenSeaPearlBaseChance;
        kyaniteBaseChance = data.kyaniteBaseChance;
        blackOpalBaseChance = data.blackOpalBaseChance;
        painiteBaseChance = data.painiteBaseChance;
        tanzaniteBaseChance = data.tanzaniteBaseChance;

        //New
        astraliumBaseChance = data.astraliumBaseChance;
        elysiumPrismBaseChance = data.elysiumPrismBaseChance;
        aerthfireOpalBaseChance = data.aerthfireOpalBaseChance;
        eldrichStarStoneBaseChance = data.eldrichStarStoneBaseChance;
        chronolithChardBaseChance = data.chronolithChardBaseChance;
        sideriumEssenceBaseChance = data.sideriumEssenceBaseChance;
        quasariteBaseChance = data.quasariteBaseChance;
        radiantNovaStoneBaseChance = data.radiantNovaStoneBaseChance;
        soluniumShardBaseChance = data.soluniumShardBaseChance;
    }

    public void SaveData(ref GameDataJSON data)
    {
        data.doubleValueTreasure = doubleRareDropChance;

        data.prestigeKeyFound = prestigeKeyFound;
        data.prestigeChestFound = prestigeChestFound;

        data.quartzBaseChance = quartzBaseChance;
        data.amethystBaseChance = amethystBaseChance;
        data.yellowTopazBaseChance = yellowTopacBaseChance;
        data.albiteBaseChance = albiteBaseChance;
        data.redGarnetBaseChance = redGarnetBaseChance;
        data.aquamarineBaseChance = aquamarineBaseChance;
        data.yellowSapphireBaseChance = yellowSapphireBaseChance;
        data.pinkTourmalineBaseChance = pinkTourmalineBaseChance;
        data.adventurineBaseChance = adventurineBaseChance;
        data.redGemCBaseChance = redGemCBaseChance;
        data.diamondBaseChance = diamondBaseChance;
        data.grandidieriteBaseChance = grandidieriteBaseChance;
        data.akoyaPearlBaseChance = akoyaPearlBaseChance;
        data.purpleRupeeBaseChance = purpleRupeeBaseChance;
        data.violetBaseChance = violetBaseChance;
        data.emeraldDropBaseChance = emeraldDropBaseChance;
        data.greenDiamondBaseChance = greenDiamondBaseChance;
        data.fireOpalBaseChance = fireOpalBaseChance;
        data.gemSilicaBaseChance = gemSilicaBaseChance;
        data.pinkPlortBaseChance = pinkPlortBaseChance;
        data.goldenSeaPearlBaseChance = goldenSeaPearlBaseChance;
        data.kyaniteBaseChance = kyaniteBaseChance;
        data.blackOpalBaseChance = blackOpalBaseChance;
        data.painiteBaseChance = painiteBaseChance;
        data.tanzaniteBaseChance = tanzaniteBaseChance;

        //New
        data.astraliumBaseChance = astraliumBaseChance;
        data.elysiumPrismBaseChance = elysiumPrismBaseChance;
        data.aerthfireOpalBaseChance = aerthfireOpalBaseChance;
        data.eldrichStarStoneBaseChance = eldrichStarStoneBaseChance;
        data.chronolithChardBaseChance = chronolithChardBaseChance;
        data.sideriumEssenceBaseChance = sideriumEssenceBaseChance;
        data.quasariteBaseChance = quasariteBaseChance;
        data.radiantNovaStoneBaseChance = radiantNovaStoneBaseChance;
        data.soluniumShardBaseChance = soluniumShardBaseChance;
    }
    #endregion

    #region DeleteOldBinarySaveFile
    IEnumerator deleteOldSaveFile()
    {
        yield return new WaitForSeconds(4);
        string path = Application.persistentDataPath + "/player.saveGold";
        string path2 = Application.persistentDataPath + "/player.saveChests";
        string path3 = Application.persistentDataPath + "/player.saveFirstPlayed";
        string path4 = Application.persistentDataPath + "/player.saveGemsCount";
        string path5 = Application.persistentDataPath + "/player.saveClickPower";
        string path6 = Application.persistentDataPath + "/player.saveAutoDamage";
        string path7 = Application.persistentDataPath + "/player.saveConsumables";
        string path8 = Application.persistentDataPath + "/player.saveSpecialUpgrades";
        string path9 = Application.persistentDataPath + "/player.savePlayerLevel";
        string path10 = Application.persistentDataPath + "/player.saveTreasureChance";
        string path11 = Application.persistentDataPath + "/player.saveRareTreasures";
        string path12 = Application.persistentDataPath + "/player.saveStats";
        string path13 = Application.persistentDataPath + "/player.saveSkillTree";
        string path14 = Application.persistentDataPath + "/player.saveACH";

        if (File.Exists(path))
        {
            File.Delete(path);
            File.Delete(path2);
            File.Delete(path3);
            File.Delete(path4);
            File.Delete(path5);
            File.Delete(path6);
            File.Delete(path7);
            File.Delete(path8);
            File.Delete(path9);
            File.Delete(path10);
            File.Delete(path11);
            File.Delete(path12);
            File.Delete(path13);
            File.Delete(path14);
            //Debug.Log("Save file deleted: " + path);

            SaveAndLoad.onlyLoadNewSave = true;
        }

    }
    #endregion

    public static bool changeDropChanceValues;
    public static bool treasureXPMouse;

    public void Update()
    {
        if (changeDropChanceValues == true)
        {
            #region treasure chances
            quartzDropChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + quartzBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount - UpdateGame.treasureDebuffAmount);

            amethystDropChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + amethystBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount - UpdateGame.treasureDebuffAmount);

            yellowTopacChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + yellowTopacBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount - UpdateGame.treasureDebuffAmount);

            albiteChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + albiteBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount - UpdateGame.treasureDebuffAmount);

            redGarnetDropChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + redGarnetBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount - UpdateGame.treasureDebuffAmount);

            aquamarineChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + aquamarineBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount - UpdateGame.treasureDebuffAmount);

            yellowSapphireChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + yellowSapphireBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount - UpdateGame.treasureDebuffAmount);

            pinkTourmalineChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + pinkTourmalineBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount - UpdateGame.treasureDebuffAmount);

            adventurineChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + adventurineBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount - UpdateGame.treasureDebuffAmount);

            redGemChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + redGemCBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount - UpdateGame.treasureDebuffAmount);

            diamondDropChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + diamondBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount - UpdateGame.treasureDebuffAmount);

            grandidieriteChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + grandidieriteBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount - UpdateGame.treasureDebuffAmount);

            violetDropChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + violetBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount - UpdateGame.treasureDebuffAmount);

            akoyaPearlChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + akoyaPearlBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount - UpdateGame.treasureDebuffAmount);

            purpleRupeeDropChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + purpleRupeeBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount - UpdateGame.treasureDebuffAmount);

            emeraldDropChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + emeraldDropBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount - UpdateGame.treasureDebuffAmount); 

            greenDiamondChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + greenDiamondBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount - UpdateGame.treasureDebuffAmount);

            fireOpalChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + fireOpalBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount - UpdateGame.treasureDebuffAmount);

            gemSilicaChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + gemSilicaBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount - UpdateGame.treasureDebuffAmount);

            pinkPlortDropChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + pinkPlortBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount - UpdateGame.treasureDebuffAmount);

            goldenSeaPearlChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + goldenSeaPearlBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount - UpdateGame.treasureDebuffAmount);

            kyaniteChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + kyaniteBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount - UpdateGame.treasureDebuffAmount);

            blackOpalChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + blackOpalBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount - UpdateGame.treasureDebuffAmount);

            painiteChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + painiteBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount - UpdateGame.treasureDebuffAmount);

            tanzaniteChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + tanzaniteBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount - UpdateGame.treasureDebuffAmount);

            //NEW
            astraliumChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + astraliumBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount + Stats.treasureDropChanceIncrease - UpdateGame.treasureDebuffAmount);

            elysiumPrismChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + elysiumPrismBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount + Stats.treasureDropChanceIncrease - UpdateGame.treasureDebuffAmount);

            aetherfireOpalChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + aerthfireOpalBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount + Stats.treasureDropChanceIncrease - UpdateGame.treasureDebuffAmount);

            eldritchStarstoneChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + eldrichStarStoneBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount + Stats.treasureDropChanceIncrease - UpdateGame.treasureDebuffAmount);

            chronolithShardChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + chronolithChardBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount + Stats.treasureDropChanceIncrease - UpdateGame.treasureDebuffAmount);

            sideriumEssenceChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + sideriumEssenceBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount + Stats.treasureDropChanceIncrease - UpdateGame.treasureDebuffAmount);

            quasariteChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + quasariteBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount + Stats.treasureDropChanceIncrease - UpdateGame.treasureDebuffAmount);

            radiantNovaStoneChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + radiantNovaStoneBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount + Stats.treasureDropChanceIncrease - UpdateGame.treasureDebuffAmount);

            soluniumShardChance = (ClickPower.cursor5RareDropsBonus + UseConsumable.elixirTreasureDropChance + soluniumShardBaseChance + UseConsumable.scrollTreasureBuff + UseConsumable.relicPermaTreasureBuff + UpdateGame.treasurePotionChance + UpdateGame.treasureDropBuffAmount + Stats.treasureDropChanceIncrease - UpdateGame.treasureDebuffAmount);



            quartzChanceText.text =  quartzDropChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            amethystChanceText.text = amethystDropChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            yellowTopazChanceText.text = yellowTopacChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            albiteChanceText.text =  albiteChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            redGarnetChanceText.text =  redGarnetDropChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            aquamarineChanceText.text = aquamarineChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            yellowShapphireChanceText.text = yellowSapphireChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            pinkTourmalineChanceText.text =  pinkTourmalineChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            adventurineChanceText.text = adventurineChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            redRubyChanceText.text = redGemChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            diamondChanceText.text =diamondDropChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            grandidieriteChanceText.text =  grandidieriteChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            violetCrystalChanceText.text = violetDropChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            akoyaPearlChanceText.text = akoyaPearlChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            purpleRupeeChanceText.text =purpleRupeeDropChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            emeraldChanceText.text =  emeraldDropChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            greenDiamondChanceText.text = greenDiamondChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            fireOpalChanceText.text = fireOpalChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            gemSilicaChanceText.text = gemSilicaChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            pinkPlortChanceText.text = pinkPlortDropChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            goldenSeaPearlChanceText.text = goldenSeaPearlChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            kyaniteChanceText.text = kyaniteChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            blackOpalChanceText.text = blackOpalChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            painiteChanceText.text = painiteChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            tanzaniteChanceText.text = tanzaniteChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            astraliumChanceText.text = astraliumChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            elysiumPrismChanceText.text = elysiumPrismChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            aerthfireOpalChanceText.text = aetherfireOpalChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            eldrichStarStoneChanceText.text =eldritchStarstoneChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            chronolithChardChanceText.text = chronolithShardChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            sideriumEssenceChanceText.text = sideriumEssenceChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            quasariteChanceText.text = quasariteChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            radiantNovaStoneChanceText.text = radiantNovaStoneChance.ToString("F2") + Localization.tDropChanceRussAndEng;
            soluniumShardChanceText.text = soluniumShardChance.ToString("F2") + Localization.tDropChanceRussAndEng;

            quartzDoubleValue.text = Localization.quartsGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            amethystDoubleValue.text = Localization.amethystGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            yellowTopazDoubleValue.text = Localization.yellowTopazGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            albiteDoubleValue.text = Localization.albiteGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            redGarnetDoubleValue.text = Localization.redGarnetGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            aquamarineDoubleValue.text = Localization.aquamarineGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            yellowShapphireDoubleValue.text = Localization.yellowShapphireGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            pinkTourmalineDoubleValue.text = Localization.pinkTourmalineGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            adventurineDoubleValue.text = Localization.adventurineGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            redRubyDoubleValue.text = Localization.redRubyGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            diamondDoubleValue.text = Localization.diamondGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            grandidieriteDoubleValue.text = Localization.grandidieriteGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            violetCrystalDoubleValue.text = Localization.violetCrystalGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            akoyaPearlDoubleValue.text = Localization.akoyaPearlGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            purpleRupeeDoubleValue.text = Localization.purpleRupeeGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            emeraldDoubleValue.text = Localization.emeraldGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            greenDiamondDoubleValue.text = Localization.greenDiamondGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            fireOpalDoubleValue.text = Localization.fireOpalGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            gemSilicaDoubleValue.text = Localization.gemSilicaGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            pinkPlortDoubleValue.text = Localization.pinkPlortGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            goldenSeaPearlDoubleValue.text = Localization.goldenSeaPearlGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            kyaniteDoubleValue.text = Localization.kyaniteGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            blackOpalDoubleValue.text = Localization.blackOpalGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            painiteDoubleValue.text = Localization.painiteGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            tanzaniteDoubleValue.text = Localization.tanzaniteGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            astraliumDoubleValue.text = Localization.astraliumGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            elysiumPrismDoubleValue.text = Localization.elysiumPrismGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            aerthfireOpalDoubleValue.text = Localization.aerthfireOpalGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            eldrichStarStoneDoubleValue.text = Localization.eldrichStarStoneGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            chronolithChardDoubleValue.text = Localization.chronolithChardGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            sideriumEssenceDoubleValue.text = Localization.sideriumEssenceGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            quasariteDoubleValue.text = Localization.quasariteGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            radiantNovaStoneDoubleValue.text = Localization.radiantNovaGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            soluniumShardDoubleValue.text = Localization.soluniumShardGained + "<color=green>" + (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue) + "%<color=white>" + Localization.doubleInValue;
            #endregion

            changeDropChanceValues = false;
        }

        #region treasurebagBonus
        if(treasureBagClick.clickedTreasureBag == true)
        {
            treasureXPMouse = true;
            XPSpawn(); XPSpawn(); XPSpawn(); XPSpawn(); XPSpawn();
            treasureBagClick.clickedTreasureBag = false;
        }

        #endregion

        #region lockPickBonus
        if (HealthBar.lockPickOpen == true)
        {
            int random = Random.Range(1, 3);
            if(random == 2) { AllRareDropsTesting(); }
            HealthBar.lockPickOpen = false;
        }
        #endregion

        #region hammerBonus

        if (HealthBar.hitHammerCrit == true)
        {
            int randomHammer = Random.Range(1,101);
            if(randomHammer <= 35)
            {
                Stats.coinsSpawnedFromClicks += 1;
                GoldSpawn();
            }
            HealthBar.hitHammerCrit = false;
        }

        #endregion

        #region cursor1Bonus
            if (HealthBar.hitCursor1Buff == true)
        {
            GoldSpawn();
            HealthBar.hitCursor1Buff = false;
        }
        #endregion

        #region cursor2Bonus
        if (HealthBar.cursor2Buff == 10)
        {
            int random = Random.Range(1, 101);
            if (random < 26) { GoldSpawn(); GoldSpawn(); GoldSpawn(); GoldSpawn(); GoldSpawn(); }
            HealthBar.cursor2Buff = 0;
        }
        #endregion

        #region cursor4Bonus
        if (HealthBar.cursor4Buff == 35)
        {
            GoldSpawn(); GoldSpawn(); GoldSpawn(); GoldSpawn(); GoldSpawn(); GoldSpawn(); GoldSpawn();
            HealthBar.cursor4Buff = 0;
        }
        #endregion

        #region cursor3Bonus
        if (HealthBar.hitCursor3Buff == true)
        {
            GoldSpawn(); 
            HealthBar.hitCursor3Buff = false;
        }
        #endregion

        #region cursor6Bonus
        if (HealthBar.hitCursor6Buff == true)
        {
            Stats.treasuredSpawnedFromClicks += 1;
            DropRareDrops();
            HealthBar.hitCursor6Buff = false;
        }
        #endregion

        #region cursor11Bonus
        if (HealthBar.hitCursor11Buff == true)
        {
            int random = Random.Range(1, 101);
            if (random < 31) { GoldSpawn(); Stats.coinsSpawnedFromClicks += 1; }
            if (random < 6) { DropRareDrops(); Stats.treasuredSpawnedFromClicks += 1; }
            HealthBar.hitCursor11Buff = false;
        }
        #endregion

        #region cursor13Bonus
        if (HealthBar.hitCursor13Buff == true)
        {
            GoldSpawn(); Stats.coinsSpawnedFromClicks += 1; 
            HealthBar.hitCursor13Buff = false;
        }
        #endregion

        #region cursor15Bonus
        if (HealthBar.hitCursor15Buff == true)
        {
            int random = Random.Range(1,101);
            if (random <= 13) { DropRareDrops(); Stats.treasuredSpawnedFromClicks += 1; }
          
            HealthBar.hitCursor15Buff = false;
        }
        #endregion

      

        #region cursor18Bonus
        if (HealthBar.hitCursor18Buff == true)
        {
            GoldSpawn();
            Stats.coinsSpawnedFromClicks += 1;
            HealthBar.hitCursor18Buff = false;
        }
        #endregion

        #region skillTreeCrit4
        if (HealthBar.hitSkillTreeCrit4 == true)
        {
            GoldSpawn();
            Stats.coinsSpawnedFromClicks += 1;
            HealthBar.hitSkillTreeCrit4 = false;
        }
        #endregion

        #region skillTreeCrit5
        if (HealthBar.hitSkillTreeCrit5 == true)
        {
            Stats.treasuredSpawnedFromClicks += 1;
            DropRareDrops();
            HealthBar.hitSkillTreeCrit5 = false;
        }
        #endregion

        #region skillTreeActive4
        if (HealthBar.hitSkillTreeActive4 == true)
        {
            GoldSpawn();
            Stats.coinsSpawnedFromClicks += 1;
            HealthBar.hitSkillTreeActive4 = false;
        }
        #endregion

        #region skillTreeActive5
        if (HealthBar.hitSkillTreeActive5 == true)
        {
            Stats.treasuredSpawnedFromClicks += 1;
            DropRareDrops();
            HealthBar.hitSkillTreeActive5 = false;
        }
        #endregion

        #region skillTreeActive7
        if(HealthBar.hitSkillTreeActive7 == true)
        {
            Drop5XGoldCoin();
            HealthBar.hitSkillTreeActive7 = false;
        }
        #endregion

        #region skillTreeAuto3
        if (SkillTree.skillTreeAutoDamage3ChestSpawn == 7)
        {
            GoldSpawn();
            SkillTree.skillTreeAutoDamage3ChestSpawn = 0;
        }
        #endregion

        #region skillTreeAuto4
        if (SkillTree.skillTreeAutoDamage4TreasureDrop == 25)
        {
            DropRareDrops();
            SkillTree.skillTreeAutoDamage4TreasureDrop = 0;
        }
        #endregion

        #region skillTreeAuto6
        if (SkillTree.skillTreeAuto6ChestDrops == 25)
        {
            GoldSpawn(); GoldSpawn(); GoldSpawn(); DropRareDrops(); XPSpawn();
            SkillTree.skillTreeAuto6ChestDrops = 0;
        }
        #endregion

        #region hitGauntlet
        if (HealthBar.hitGauntlet == true)
        {
            Stats.coinsSpawnedFromClicks += 1;
            GoldSpawn();
            if(UseConsumable.gauntletStackCount == 2) { GoldSpawn(); }
            HealthBar.hitGauntlet = false;
        }
        #endregion

        #region hitGauntletTreasure

        if(HealthBar.hitGauntletTreasure == true)
        {
            Stats.treasuredSpawnedFromClicks += 1;
            DropRareDrops();
            HealthBar.hitGauntletTreasure = false;
        }

        #endregion

        #region usedKey
        if (HealthBar.usedKey == true)
        {
            int random = Random.Range(1, 5);
            if (random < 2) { GoldSpawn();  }
            if (random < 3) { GoldSpawn();  }
            if (random < 4) { GoldSpawn();  }
            if (random < 5) { GoldSpawn();  }
            HealthBar.usedKey = false;
        }
        #endregion

        #region keyTreasureDrop

        if(HealthBar.hitTreasureKey == true)
        {
            DropRareDrops();
            HealthBar.hitTreasureKey = false;
        }

        #endregion

        #region medalBuff
        if(HealthBar.hitMedalGold == true)
        {
            Stats.coinsSpawnedFromClicks += 1;
            GoldSpawn();
            HealthBar.hitMedalGold = false;
        }
        if(HealthBar.hitMedalTreasure == true)
        {
            Stats.treasuredSpawnedFromClicks += 1;
            DropRareDrops();
            HealthBar.hitMedalTreasure = false;
        }


        #endregion

        if(HealthBar.hitAxe == true)
        {
            spawnRewards();
            HealthBar.hitAxe = false;
        }

        #region prestige greaterLoot1 Buff
        if(HealthBar.prestigeGreaterLoot1Buff == true)
        {
            GoldSpawn();
            HealthBar.prestigeGreaterLoot1Buff = false;
        }
        #endregion

        #region prestige greaterLoot2 Buff
        if (HealthBar.prestigeGreaterLoot2Buff == true)
        {
            Drop5XGoldCoin(); XPSpawn(); XPSpawn(); XPSpawn();
            HealthBar.prestigeGreaterLoot2Buff = false;
        }
        #endregion

        #region prestige greaterLoot3 Buff
        if (HealthBar.prestigeGreaterLoot3Buff == true)
        {
            int randomCoinDrop = Random.Range(1,4);
            if(randomCoinDrop == 1) { Drop5XGoldCoin(); Drop10XGoldCoin(); }
            if (randomCoinDrop == 2) { Drop5XGoldCoin(); Drop10XGoldCoin(); Drop5XGoldCoin(); }
            if (randomCoinDrop == 3) { Drop5XGoldCoin(); Drop10XGoldCoin(); Drop5XGoldCoin(); Drop10XGoldCoin(); }

            XPSpawn(); XPSpawn(); XPSpawn(); XPSpawn(); XPSpawn();
            HealthBar.prestigeGreaterLoot3Buff = false;
        }
        #endregion

        #region prestige greaterLoot4 Buff
        if (HealthBar.prestigeGreaterLoot4Buff == true)
        {
            Drop25XGoldCoin(); Drop25XGoldCoin(); Drop25XGoldCoin(); 

            int randomTreasures = Random.Range(1,5);
            if(randomTreasures == 1) { DropRareDrops(); DropRareDrops(); }
            if (randomTreasures == 2) { DropRareDrops(); DropRareDrops(); DropRareDrops(); }
            if (randomTreasures == 3) { DropRareDrops(); DropRareDrops(); DropRareDrops(); DropRareDrops(); }
            if (randomTreasures == 4) { DropRareDrops(); DropRareDrops(); DropRareDrops(); DropRareDrops(); DropRareDrops(); }

            HealthBar.prestigeGreaterLoot4Buff = false;
        }
        #endregion

        #region prestige greaterLoot5 Buff
        if (HealthBar.prestigeGreaterLoot5Buff == true)
        {
            Drop5XGoldCoin();
            XPSpawn();

            float random10X = Random.Range(0,100);
            if(random10X < 5) { Drop10XGoldCoin(); }
            if (random10X > 97.5f) { Drop10XGoldCoin(); }

            HealthBar.prestigeGreaterLoot5Buff = false;
        }
        #endregion

        if (HealthBar.spawnRewards == true)
        {
            if(UpdateGame.KnifeActive == true)
            {
                spawnRewards();
                int randomChance = Random.Range(1,101);
                if(randomChance < 3)
                {
                    spawnRewards();
                }
            }

            #region cursor20Bonus
            if (ClickPower.cursor20Equipped == 1)
            {
                float randomChance = Random.Range(0, 100);
                if (randomChance < 2.5f)
                {
                    spawnRewards();
                }
            }
            #endregion

            #region enchanted golden chest treasures

            if (HealthBar.enchantedGoldenChestOpened == true)
            {
                enchantedXP = true;

                for (int i = 0; i < UpdateGame.enchantedGoldenChestTreasureDrops; i++)
                {
                    DropRareDrops();
                }

                TriggerAllSuperRareDrops();
                TriggerAllSuperRareDrops();
                TriggerAllSuperRareDrops();
                TriggerAllSuperRareDrops();
                TriggerAllSuperRareDrops();

                if (UpdateGame.newChests6Bought == 1)
                {
                    TriggerAllSuperRareDrops();
                    TriggerAllSuperRareDrops();
                    TriggerAllSuperRareDrops();
                    TriggerAllSuperRareDrops();
                    TriggerAllSuperRareDrops();
                }
                HealthBar.enchantedGoldenChestOpened = false;
            }

            if (HealthBar.bossChestOpened == true)
            {
                bossXP = true;

                for (int i = 0; i < UpdateGame.bossChestGoldCoinsDrops; i++)
                {
                    if (UpdateGame.newChests6Bought == 1)
                    {
                        Drop25XGoldCoin();
                    }
                    else
                    {
                        int randomCoinDrops = Random.Range(1, 3);
                        if (randomCoinDrops == 1) { Drop10XGoldCoin(); }
                        if (randomCoinDrops == 2) { Drop25XGoldCoin(); }
                    }
                }

                TriggerAllSuperRareDrops(); TriggerAllSuperRareDrops(); TriggerAllSuperRareDrops(); TriggerAllSuperRareDrops();
                TriggerAllSuperRareDrops(); TriggerAllSuperRareDrops(); TriggerAllSuperRareDrops(); TriggerAllSuperRareDrops();
                TriggerAllSuperRareDrops(); TriggerAllSuperRareDrops(); TriggerAllSuperRareDrops(); TriggerAllSuperRareDrops();

                if (UpdateGame.newChests6Bought == 1)
                {
                    TriggerAllSuperRareDrops();
                    TriggerAllSuperRareDrops();
                    TriggerAllSuperRareDrops();
                    TriggerAllSuperRareDrops();
                    TriggerAllSuperRareDrops();
                }

                HealthBar.bossChestOpened = false;
            }

            #endregion

            HealthBar.spawnRewards = false;
        }

        if (changedRareDropsChance == true)
        {
          
            changedRareDropsChance = false;

        }
    }

    public void spawnRewards()
    {
        StartCoroutine(SpawnAllRewards());
    }

    IEnumerator SpawnAllRewards()
    {
        if(UpdateGame.isRareTreasureDropBuffActive == true)
        {
            TriggerAllSuperRareDrops();
            TriggerAllSuperRareDrops();
            TriggerAllSuperRareDrops();
            TriggerAllSuperRareDrops();
        }

        TriggerAllSuperRareDrops(); 

        AllItemsDropChance();
        PrestigeKeyDrop();
        PrestigeChestDrop();

        int randomGoldCount = Random.Range(1, 14);
        float randomWait = Random.Range(0.007f, 0.02f);

        TreasureBagDropChance();
        if (UseConsumable.spawnTreasureBag == true) {
            for (int i = 0; i < UseConsumable.treasureSpawnCount; i++)
            {
                TreasureBagDrop();
            }
        }

        //XP
        int randomXP = Random.Range(1, 101);
        XPSpawn(); if(ClickPower.cursor8Equipped == 1) {if (randomXP < 7) {  XPSpawn(); } }
        if (HealthBar.cursor10Buff == 25) { HealthBar.cursor10Buff = 0; DropRareDrops(); XPSpawn(); XPSpawn();  }

        if(HealthBar.reinforcedChestActive == true) { XPSpawn(); XPSpawn(); }

        //GoldCoins
       
        if (UpdateGame.goldCoinDebuffAmount == 0) { GoldSpawn(); GoldSpawn();  }
        if (UpdateGame.goldCoinDebuffAmount == 1) { GoldSpawn(); }


        if (UpdateGame.isGoldCoinDropBuffActive == true)
        {
            if(UpdateGame.goldCoinBuffAmount == 1) { GoldSpawn(); }
            if (UpdateGame.goldCoinBuffAmount == 2) { GoldSpawn(); GoldSpawn(); }
        }

        yield return new WaitForSeconds(randomWait);

        //Skill tree auto damage 7 branch bought
        if(SkillTree.autoDamage7Bought == 1)
        {
            GoldSpawn();
        }

        #region cursor16Bonus
        if (ClickPower.cursor16Equipped == 1)
        {
            XPSpawn();
        }
        #endregion

        #region cursor18Bonus
        if (ClickPower.cursor18Equipped == 1)
        {
            XPSpawn();
        }
        #endregion

        #region cursor19Bonus
        if (ClickPower.cursor19Equipped == 1)
        {
            TriggerAllSuperRareDrops();
        }
        #endregion

        #region cursor21Bonus
        if (ClickPower.cursor21Equipped == 1)
        {
            XPSpawn();
            int random = Random.Range(1,101);
            if(random < 5) { StartCoroutine(SpawnAllGoldCoins());  }
        }
        #endregion

        StartCoroutine(SpawnAllGoldCoins());

        #region goldenTouch
        if (UseConsumable.goldenTouchActive == true)
        {
            GoldSpawn();
            GoldSpawn();
            GoldSpawn();
            GoldSpawn();

            if(UseConsumable.goldenTouchStackCount == 2)
            {
                GoldSpawn();
                GoldSpawn();
                GoldSpawn();
                GoldSpawn();
            }
            if(randomGoldCount < 6) {
                yield return new WaitForSeconds(randomWait);
                GoldSpawn();
                GoldSpawn();
                GoldSpawn();
                if (UseConsumable.goldenTouchStackCount == 2)
                {
                    GoldSpawn();
                    GoldSpawn();
                    GoldSpawn();
                }
            }
            if (randomGoldCount == 6)
            {
                GoldSpawn();
                GoldSpawn();
                yield return new WaitForSeconds(randomWait);
                GoldSpawn();
                GoldSpawn();
                GoldSpawn();
                GoldSpawn();

                if (UseConsumable.goldenTouchStackCount == 2)
                {
                    GoldSpawn();
                    GoldSpawn();
                    yield return new WaitForSeconds(randomWait);
                    GoldSpawn();
                    GoldSpawn();
                    GoldSpawn();
                    GoldSpawn();
                }
            }
            if (randomGoldCount > 6)
            {
                GoldSpawn();
                GoldSpawn();
                yield return new WaitForSeconds(randomWait);
                if (UseConsumable.goldenTouchStackCount == 2)
                {
                    GoldSpawn();
                    GoldSpawn();
                }
            }

        }
        #endregion

        #region progressionDrops
        //RANDOMSPAWNS
        if (SelectChests.chest1Active == true)
        {
            //AllRareDropsTesting();
            QuartzDropChance();
        }
        if (SelectChests.chest2Active == true)
        {
            QuartzDropChance();
            AmethystDropChance();
        }
        if (SelectChests.chest3Active == true)
        {
            QuartzDropChance();
            AmethystDropChance();
            YellowTopazDropChance();
        }
        if (SelectChests.chest4Active == true)
        {
            QuartzDropChance();
            AmethystDropChance();
            YellowTopazDropChance();
            AlbiteDropChance();
        }
        if (SelectChests.chest5Active == true)
        {
            QuartzDropChance();
            AmethystDropChance();
            YellowTopazDropChance();
            AlbiteDropChance();
            RedGarnetDropChance();
        }
        if (SelectChests.chest6Active == true)
        {
            QuartzDropChance();
            AmethystDropChance();
            YellowTopazDropChance();
            AlbiteDropChance();
            RedGarnetDropChance();
        }
        if (SelectChests.chest7Active == true)
        {
            QuartzDropChance();
            AmethystDropChance();
            YellowTopazDropChance();
            AlbiteDropChance();
            RedGarnetDropChance();
            AquamarineDropChance();
        }
        if (SelectChests.chest8Active == true)
        {
            QuartzDropChance();
            AmethystDropChance();
            YellowTopazDropChance();
            AlbiteDropChance();
            RedGarnetDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
        }
        if (SelectChests.chest9Active == true)
        {
            QuartzDropChance();
            AmethystDropChance();
            YellowTopazDropChance();
            AlbiteDropChance();
            RedGarnetDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
        }
        if (SelectChests.chest10Active == true)
        {
            QuartzDropChance();
            AmethystDropChance();
            YellowTopazDropChance();
            AlbiteDropChance();
            RedGarnetDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
        }
        if (SelectChests.chest11Active == true)
        {
            QuartzDropChance();
            AmethystDropChance();
            YellowTopazDropChance();
            AlbiteDropChance();
            RedGarnetDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
        }
        if (SelectChests.chest12Active == true)
        {
            QuartzDropChance();
            AmethystDropChance();
            YellowTopazDropChance();
            AlbiteDropChance();
            RedGarnetDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
            AdventurineDropChance();
        }
        if (SelectChests.chest13Active == true)
        {
            QuartzDropChance();
            AmethystDropChance();
            YellowTopazDropChance();
            AlbiteDropChance();
            RedGarnetDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
            AdventurineDropChance();
        }
        if (SelectChests.chest14Active == true)
        {
            QuartzDropChance();
            AlbiteDropChance();
            AmethystDropChance();
            RedGarnetDropChance();
            YellowTopazDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
            AdventurineDropChance();
            RedGemChance();
        }
        if (SelectChests.chest15Active == true)
        {
            QuartzDropChance();
            AlbiteDropChance();
            AmethystDropChance();
            RedGarnetDropChance();
            YellowTopazDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
            AdventurineDropChance();
            RedGemChance();
            DiamondDropChance();
        }
        if (SelectChests.chest16Active == true)
        {
            QuartzDropChance();
            AlbiteDropChance();
            AmethystDropChance();
            RedGarnetDropChance();
            YellowTopazDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
            AdventurineDropChance();
            RedGemChance();
            DiamondDropChance();
            GrandidieriteDropChance();
        }
        if (SelectChests.chest17Active == true)
        {
            QuartzDropChance();
            AlbiteDropChance();
            AmethystDropChance();
            RedGarnetDropChance();
            YellowTopazDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
            AdventurineDropChance();
            RedGemChance();
            DiamondDropChance();
            GrandidieriteDropChance();
        }
        if (SelectChests.chest18Active == true)
        {
            QuartzDropChance();
            AlbiteDropChance();
            AmethystDropChance();
            RedGarnetDropChance();
            YellowTopazDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
            AdventurineDropChance();
            RedGemChance();
            DiamondDropChance();
            GrandidieriteDropChance();
            VioletDropChance();
        }
        if (SelectChests.chest19Active == true)
        {
            QuartzDropChance();
            AlbiteDropChance();
            AmethystDropChance();
            RedGarnetDropChance();
            YellowTopazDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
            AdventurineDropChance();
            RedGemChance();
            DiamondDropChance();
            GrandidieriteDropChance();
            VioletDropChance();
            AkoyaPearlDropChance();
            PurpleRupeeDropChance();
        }
        if (SelectChests.chest20Active == true)
        {
            QuartzDropChance();
            AlbiteDropChance();
            AmethystDropChance();
            RedGarnetDropChance();
            YellowTopazDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
            AdventurineDropChance();
            RedGemChance();
            DiamondDropChance();
            GrandidieriteDropChance();
            VioletDropChance();
            AkoyaPearlDropChance();
            PurpleRupeeDropChance();
            EmeraldDropChance();
        }
        if (SelectChests.chest21Active == true)
        {
            QuartzDropChance();
            AlbiteDropChance();
            AmethystDropChance();
            RedGarnetDropChance();
            YellowTopazDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
            AdventurineDropChance();
            RedGemChance();
            DiamondDropChance();
            GrandidieriteDropChance();
            VioletDropChance();
            AkoyaPearlDropChance();
            PurpleRupeeDropChance();
            EmeraldDropChance();
            GreenDiamondChance();
        }
        if (SelectChests.chest22Active == true)
        {
            //Debug.Log(redGemChance);

            QuartzDropChance();
            AlbiteDropChance();
            AmethystDropChance();
            RedGarnetDropChance();
            YellowTopazDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
            AdventurineDropChance();
            RedGemChance();
            DiamondDropChance();
            GrandidieriteDropChance();
            VioletDropChance();
            AkoyaPearlDropChance();
            PurpleRupeeDropChance();
            EmeraldDropChance();
            GreenDiamondChance();
            FireOpalDropChance();
        }
        if (SelectChests.chest23Active == true)
        {
            QuartzDropChance();
            AlbiteDropChance();
            AmethystDropChance();
            RedGarnetDropChance();
            YellowTopazDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
            AdventurineDropChance();
            RedGemChance();
            DiamondDropChance();
            GrandidieriteDropChance();
            VioletDropChance();
            AkoyaPearlDropChance();
            PurpleRupeeDropChance();
            EmeraldDropChance();
            GreenDiamondChance();
            FireOpalDropChance();
            GemSilicaDropChance();
            PinkPlortDropChance();
        }
        if (SelectChests.chest24Active == true)
        {
            QuartzDropChance();
            AlbiteDropChance();
            AmethystDropChance();
            RedGarnetDropChance();
            YellowTopazDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
            AdventurineDropChance();
            RedGemChance();
            DiamondDropChance();
            GrandidieriteDropChance();
            VioletDropChance();
            AkoyaPearlDropChance();
            PurpleRupeeDropChance();
            EmeraldDropChance();
            GreenDiamondChance();
            FireOpalDropChance();
            GemSilicaDropChance();
            PinkPlortDropChance();
            GoldenSeaPearlDropChance();
            KyaniteDropChance();
        }
        if (SelectChests.chest25Active == true)
        {
            QuartzDropChance();
            AlbiteDropChance();
            AmethystDropChance();
            RedGarnetDropChance();
            YellowTopazDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
            AdventurineDropChance();
            RedGemChance();
            DiamondDropChance();
            GrandidieriteDropChance();
            VioletDropChance();
            AkoyaPearlDropChance();
            PurpleRupeeDropChance();
            EmeraldDropChance();
            GreenDiamondChance();
            FireOpalDropChance();
            GemSilicaDropChance();
            PinkPlortDropChance();
            GoldenSeaPearlDropChance();
            KyaniteDropChance();
            BlackOpalDropChance();
        }
        if (SelectChests.chest26Active == true)
        {
            QuartzDropChance();
            AlbiteDropChance();
            AmethystDropChance();
            RedGarnetDropChance();
            YellowTopazDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
            AdventurineDropChance();
            RedGemChance();
            DiamondDropChance();
            GrandidieriteDropChance();
            VioletDropChance();
            AkoyaPearlDropChance();
            PurpleRupeeDropChance();
            EmeraldDropChance();
            GreenDiamondChance();
            FireOpalDropChance();
            GemSilicaDropChance();
            PinkPlortDropChance();
            GoldenSeaPearlDropChance();
            KyaniteDropChance();
            BlackOpalDropChance();
            PainiteDropChance();
        }
        if (SelectChests.chest27Active == true)
        {
            QuartzDropChance();
            AlbiteDropChance();
            AmethystDropChance();
            RedGarnetDropChance();
            YellowTopazDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
            AdventurineDropChance();
            RedGemChance();
            DiamondDropChance();
            GrandidieriteDropChance();
            VioletDropChance();
            AkoyaPearlDropChance();
            PurpleRupeeDropChance();
            EmeraldDropChance();
            GreenDiamondChance();
            FireOpalDropChance();
            GemSilicaDropChance();
            PinkPlortDropChance();
            GoldenSeaPearlDropChance();
            KyaniteDropChance();
            BlackOpalDropChance();
            PainiteDropChance();
            TanzaniteDropChance();
        }

        if (SelectChests.chest28Active == true)
        {
            #region treasures
            QuartzDropChance();
            AlbiteDropChance();
            AmethystDropChance();
            RedGarnetDropChance();
            YellowTopazDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
            AdventurineDropChance();
            RedGemChance();
            DiamondDropChance();
            GrandidieriteDropChance();
            VioletDropChance();
            AkoyaPearlDropChance();
            PurpleRupeeDropChance();
            EmeraldDropChance();
            GreenDiamondChance();
            FireOpalDropChance();
            GemSilicaDropChance();
            PinkPlortDropChance();
            GoldenSeaPearlDropChance();
            KyaniteDropChance();
            BlackOpalDropChance();
            PainiteDropChance();
            TanzaniteDropChance();
            #endregion
        }
        if (SelectChests.chest29Active == true)
        {
            #region treasures
            QuartzDropChance();
            AlbiteDropChance();
            AmethystDropChance();
            RedGarnetDropChance();
            YellowTopazDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
            AdventurineDropChance();
            RedGemChance();
            DiamondDropChance();
            GrandidieriteDropChance();
            VioletDropChance();
            AkoyaPearlDropChance();
            PurpleRupeeDropChance();
            EmeraldDropChance();
            GreenDiamondChance();
            FireOpalDropChance();
            GemSilicaDropChance();
            PinkPlortDropChance();
            GoldenSeaPearlDropChance();
            KyaniteDropChance();
            BlackOpalDropChance();
            PainiteDropChance();
            TanzaniteDropChance();

            //NEW
            AstraliumDropChance();
            #endregion
        }
        if (SelectChests.chest30Active == true)
        {
            #region treasures
            QuartzDropChance();
            AlbiteDropChance();
            AmethystDropChance();
            RedGarnetDropChance();
            YellowTopazDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
            AdventurineDropChance();
            RedGemChance();
            DiamondDropChance();
            GrandidieriteDropChance();
            VioletDropChance();
            AkoyaPearlDropChance();
            PurpleRupeeDropChance();
            EmeraldDropChance();
            GreenDiamondChance();
            FireOpalDropChance();
            GemSilicaDropChance();
            PinkPlortDropChance();
            GoldenSeaPearlDropChance();
            KyaniteDropChance();
            BlackOpalDropChance();
            PainiteDropChance();
            TanzaniteDropChance();

            //NEW
            AstraliumDropChance();
            ElysiumPrismDropChance();
            #endregion
        }
        if (SelectChests.chest31Active == true)
        {
            #region treasures
            QuartzDropChance();
            AlbiteDropChance();
            AmethystDropChance();
            RedGarnetDropChance();
            YellowTopazDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
            AdventurineDropChance();
            RedGemChance();
            DiamondDropChance();
            GrandidieriteDropChance();
            VioletDropChance();
            AkoyaPearlDropChance();
            PurpleRupeeDropChance();
            EmeraldDropChance();
            GreenDiamondChance();
            FireOpalDropChance();
            GemSilicaDropChance();
            PinkPlortDropChance();
            GoldenSeaPearlDropChance();
            KyaniteDropChance();
            BlackOpalDropChance();
            PainiteDropChance();
            TanzaniteDropChance();

            //NEW
            AstraliumDropChance();
            ElysiumPrismDropChance();
            AetherfireOpalDropChance();
            #endregion
        }
        if (SelectChests.chest32Active == true)
        {
            #region treasures
            QuartzDropChance();
            AlbiteDropChance();
            AmethystDropChance();
            RedGarnetDropChance();
            YellowTopazDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
            AdventurineDropChance();
            RedGemChance();
            DiamondDropChance();
            GrandidieriteDropChance();
            VioletDropChance();
            AkoyaPearlDropChance();
            PurpleRupeeDropChance();
            EmeraldDropChance();
            GreenDiamondChance();
            FireOpalDropChance();
            GemSilicaDropChance();
            PinkPlortDropChance();
            GoldenSeaPearlDropChance();
            KyaniteDropChance();
            BlackOpalDropChance();
            PainiteDropChance();
            TanzaniteDropChance();

            //NEW
            AstraliumDropChance();
            ElysiumPrismDropChance();
            AetherfireOpalDropChance();
            #endregion
        }
        if (SelectChests.chest33Active == true)
        {
            #region treasures
            QuartzDropChance();
            AlbiteDropChance();
            AmethystDropChance();
            RedGarnetDropChance();
            YellowTopazDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
            AdventurineDropChance();
            RedGemChance();
            DiamondDropChance();
            GrandidieriteDropChance();
            VioletDropChance();
            AkoyaPearlDropChance();
            PurpleRupeeDropChance();
            EmeraldDropChance();
            GreenDiamondChance();
            FireOpalDropChance();
            GemSilicaDropChance();
            PinkPlortDropChance();
            GoldenSeaPearlDropChance();
            KyaniteDropChance();
            BlackOpalDropChance();
            PainiteDropChance();
            TanzaniteDropChance();

            //NEW
            AstraliumDropChance();
            ElysiumPrismDropChance();
            AetherfireOpalDropChance();
            EldritchStarstoneDropChance();
            #endregion
        }
        if (SelectChests.chest34Active == true)
        {
            #region treasures
            QuartzDropChance();
            AlbiteDropChance();
            AmethystDropChance();
            RedGarnetDropChance();
            YellowTopazDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
            AdventurineDropChance();
            RedGemChance();
            DiamondDropChance();
            GrandidieriteDropChance();
            VioletDropChance();
            AkoyaPearlDropChance();
            PurpleRupeeDropChance();
            EmeraldDropChance();
            GreenDiamondChance();
            FireOpalDropChance();
            GemSilicaDropChance();
            PinkPlortDropChance();
            GoldenSeaPearlDropChance();
            KyaniteDropChance();
            BlackOpalDropChance();
            PainiteDropChance();
            TanzaniteDropChance();

            //NEW
            AstraliumDropChance();
            ElysiumPrismDropChance();
            AetherfireOpalDropChance();
            EldritchStarstoneDropChance();
            ChronolithShardDropChance();
            #endregion
        }
        if (SelectChests.chest35Active == true)
        {
            #region treasures
            QuartzDropChance();
            AlbiteDropChance();
            AmethystDropChance();
            RedGarnetDropChance();
            YellowTopazDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
            AdventurineDropChance();
            RedGemChance();
            DiamondDropChance();
            GrandidieriteDropChance();
            VioletDropChance();
            AkoyaPearlDropChance();
            PurpleRupeeDropChance();
            EmeraldDropChance();
            GreenDiamondChance();
            FireOpalDropChance();
            GemSilicaDropChance();
            PinkPlortDropChance();
            GoldenSeaPearlDropChance();
            KyaniteDropChance();
            BlackOpalDropChance();
            PainiteDropChance();
            TanzaniteDropChance();

            //NEW
            AstraliumDropChance();
            ElysiumPrismDropChance();
            AetherfireOpalDropChance();
            EldritchStarstoneDropChance();
            ChronolithShardDropChance();
            SideriumEssenceDropChance();
            #endregion
        }
        if (SelectChests.chest36Active == true)
        {
            #region treasures
            QuartzDropChance();
            AlbiteDropChance();
            AmethystDropChance();
            RedGarnetDropChance();
            YellowTopazDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
            AdventurineDropChance();
            RedGemChance();
            DiamondDropChance();
            GrandidieriteDropChance();
            VioletDropChance();
            AkoyaPearlDropChance();
            PurpleRupeeDropChance();
            EmeraldDropChance();
            GreenDiamondChance();
            FireOpalDropChance();
            GemSilicaDropChance();
            PinkPlortDropChance();
            GoldenSeaPearlDropChance();
            KyaniteDropChance();
            BlackOpalDropChance();
            PainiteDropChance();
            TanzaniteDropChance();

            //NEW
            AstraliumDropChance();
            ElysiumPrismDropChance();
            AetherfireOpalDropChance();
            EldritchStarstoneDropChance();
            ChronolithShardDropChance();
            SideriumEssenceDropChance();
            QuasariteDropChance();
            #endregion
        }
        if (SelectChests.chest37Active == true)
        {
            #region treasures
            QuartzDropChance();
            AlbiteDropChance();
            AmethystDropChance();
            RedGarnetDropChance();
            YellowTopazDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
            AdventurineDropChance();
            RedGemChance();
            DiamondDropChance();
            GrandidieriteDropChance();
            VioletDropChance();
            AkoyaPearlDropChance();
            PurpleRupeeDropChance();
            EmeraldDropChance();
            GreenDiamondChance();
            FireOpalDropChance();
            GemSilicaDropChance();
            PinkPlortDropChance();
            GoldenSeaPearlDropChance();
            KyaniteDropChance();
            BlackOpalDropChance();
            PainiteDropChance();
            TanzaniteDropChance();

            //NEW
            AstraliumDropChance();
            ElysiumPrismDropChance();
            AetherfireOpalDropChance();
            EldritchStarstoneDropChance();
            ChronolithShardDropChance();
            SideriumEssenceDropChance();
            QuasariteDropChance();
            RadiantNovaStoneDropChance();
            #endregion
        }
        if (SelectChests.chest38Active == true)
        {
            #region treasures
            QuartzDropChance();
            AlbiteDropChance();
            AmethystDropChance();
            RedGarnetDropChance();
            YellowTopazDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
            AdventurineDropChance();
            RedGemChance();
            DiamondDropChance();
            GrandidieriteDropChance();
            VioletDropChance();
            AkoyaPearlDropChance();
            PurpleRupeeDropChance();
            EmeraldDropChance();
            GreenDiamondChance();
            FireOpalDropChance();
            GemSilicaDropChance();
            PinkPlortDropChance();
            GoldenSeaPearlDropChance();
            KyaniteDropChance();
            BlackOpalDropChance();
            PainiteDropChance();
            TanzaniteDropChance();

            //NEW
            AstraliumDropChance();
            ElysiumPrismDropChance();
            AetherfireOpalDropChance();
            EldritchStarstoneDropChance();
            ChronolithShardDropChance();
            SideriumEssenceDropChance();
            QuasariteDropChance();
            RadiantNovaStoneDropChance();
            SoluniumShardDropChance();
            #endregion
        }
        if (SelectChests.chest39Active == true)
        {
            #region treasures
            QuartzDropChance();
            AlbiteDropChance();
            AmethystDropChance();
            RedGarnetDropChance();
            YellowTopazDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
            AdventurineDropChance();
            RedGemChance();
            DiamondDropChance();
            GrandidieriteDropChance();
            VioletDropChance();
            AkoyaPearlDropChance();
            PurpleRupeeDropChance();
            EmeraldDropChance();
            GreenDiamondChance();
            FireOpalDropChance();
            GemSilicaDropChance();
            PinkPlortDropChance();
            GoldenSeaPearlDropChance();
            KyaniteDropChance();
            BlackOpalDropChance();
            PainiteDropChance();
            TanzaniteDropChance();

            //NEW
            AstraliumDropChance();
            ElysiumPrismDropChance();
            AetherfireOpalDropChance();
            EldritchStarstoneDropChance();
            ChronolithShardDropChance();
            SideriumEssenceDropChance();
            QuasariteDropChance();
            RadiantNovaStoneDropChance();
            SoluniumShardDropChance();
            #endregion
        }
        if (SelectChests.chest40Active == true)
        {
            #region treasures
            QuartzDropChance();
            AlbiteDropChance();
            AmethystDropChance();
            RedGarnetDropChance();
            YellowTopazDropChance();
            AquamarineDropChance();
            YellowSapphireChance();
            PinkTourmalineDropChance();
            AdventurineDropChance();
            RedGemChance();
            DiamondDropChance();
            GrandidieriteDropChance();
            VioletDropChance();
            AkoyaPearlDropChance();
            PurpleRupeeDropChance();
            EmeraldDropChance();
            GreenDiamondChance();
            FireOpalDropChance();
            GemSilicaDropChance();
            PinkPlortDropChance();
            GoldenSeaPearlDropChance();
            KyaniteDropChance();
            BlackOpalDropChance();
            PainiteDropChance();
            TanzaniteDropChance();

            //NEW
            AstraliumDropChance();
            ElysiumPrismDropChance();
            AetherfireOpalDropChance();
            EldritchStarstoneDropChance();
            ChronolithShardDropChance();
            SideriumEssenceDropChance();
            QuasariteDropChance();
            RadiantNovaStoneDropChance();
            SoluniumShardDropChance();
            #endregion
        }
        #endregion

        #region soul gem
        if (RareTreasures.soulGemFound == 1)
        {
            float randomSoulGem = Random.Range(0f, 100f);
            if (randomSoulGem < 0.2f)
            {
                DropSoulGem();
            }
        }
        #endregion

        if (RareTreasures.coin100XFound == 1)
        {
            float random = Random.Range(0f, 100f);
            if(random < 0.05f)
            {
                Drop100XGoldCoin();
            }
        }

        //float random = Random.Range(SelectChests.randomMinGold, SelectChests.randomMaxGold);
        //goldRewardAmount = random;

    }

    public static int goldAmountOnScreen;
    public static int gemOnScreenCount;

    #region spawnAllGoldCoins

    IEnumerator SpawnAllGoldCoins()
    {
        int randomGoldCount = Random.Range(1, 14);
        float randomWait = Random.Range(0.007f, 0.02f);

        #region complicatedRandomGoldDrops

        #region chest1-2
        //Chest 1-2  Min = 3. Max = 5
        if (SelectChests.chest1Active == true || SelectChests.chest2Active == true)
        {
            GoldSpawn();
            yield return new WaitForSeconds(randomWait);
            if (randomGoldCount < 5) { GoldSpawn(); GoldSpawn(); }
            if (randomGoldCount > 7) { GoldSpawn(); }
        }
        #endregion

        #region chest3-5
        //Chest 3-5  Min = 5. Max = 7
        if (SelectChests.chest3Active == true || SelectChests.chest4Active == true || SelectChests.chest5Active == true)
        {
            GoldSpawn();
            yield return new WaitForSeconds(randomWait);
            GoldSpawn(); GoldSpawn();
            if (randomGoldCount > 11) { GoldSpawn(); GoldSpawn(); }
            if (randomGoldCount < 8) { GoldSpawn(); }
        }
        #endregion

        #region chest6-8
        //Chest 6-8  Min = 7. Max = 9
        if (SelectChests.chest6Active == true || SelectChests.chest7Active == true || SelectChests.chest8Active == true)
        {
            GoldSpawn(); GoldSpawn();
            yield return new WaitForSeconds(randomWait);
            GoldSpawn(); GoldSpawn();
            GoldSpawn();
            if (randomGoldCount > 11) { GoldSpawn(); GoldSpawn(); }
            if (randomGoldCount < 8) { GoldSpawn(); }
        }
        #endregion

        #region chest9-11
        //Chest 9-11  Min = 9. Max = 12
        if (SelectChests.chest9Active == true || SelectChests.chest10Active == true || SelectChests.chest11Active == true)
        {
            GoldSpawn(); GoldSpawn();
            GoldSpawn(); GoldSpawn();
            yield return new WaitForSeconds(randomWait);
            GoldSpawn(); GoldSpawn(); GoldSpawn();
            if (randomGoldCount > 11) { GoldSpawn(); GoldSpawn(); }
            if (randomGoldCount == 8) { GoldSpawn(); GoldSpawn(); GoldSpawn(); }
            if (randomGoldCount < 8) { GoldSpawn(); }
        }
        #endregion

        #region chest12-16
        //Chest 12-16  Min = 10. Max = 13
        if (SelectChests.chest12Active == true || SelectChests.chest13Active == true || SelectChests.chest14Active == true || SelectChests.chest15Active == true || SelectChests.chest16Active == true)
        {
            GoldSpawn(); GoldSpawn(); GoldSpawn();
            yield return new WaitForSeconds(randomWait);
            GoldSpawn(); GoldSpawn();
            GoldSpawn(); GoldSpawn(); GoldSpawn();
            if (randomGoldCount > 11) { GoldSpawn(); GoldSpawn(); }
            if (randomGoldCount == 8) { GoldSpawn(); GoldSpawn(); GoldSpawn(); }
            if (randomGoldCount < 8) { GoldSpawn(); }
        }
        #endregion

        #region chest17-21
        //Chest 17-21  Min = 11. Max = 14
        if (SelectChests.chest17Active == true || SelectChests.chest18Active == true || SelectChests.chest19Active == true || SelectChests.chest20Active == true || SelectChests.chest21Active == true)
        {
            GoldSpawn(); GoldSpawn(); GoldSpawn();
            yield return new WaitForSeconds(randomWait);
            GoldSpawn(); GoldSpawn(); GoldSpawn();
            GoldSpawn(); GoldSpawn(); GoldSpawn();
            if (randomGoldCount > 11) { GoldSpawn(); GoldSpawn(); }
            if (randomGoldCount == 8) { GoldSpawn(); GoldSpawn(); GoldSpawn(); }
            if (randomGoldCount < 8) { GoldSpawn(); }
        }
        #endregion

        #region chest22-29
        //Chest 22-29  Min = 12. Max = 15
        if (SelectChests.chest22Active == true || SelectChests.chest23Active == true || SelectChests.chest24Active == true || SelectChests.chest25Active == true || SelectChests.chest26Active == true || SelectChests.chest27Active == true || SelectChests.chest28Active == true || SelectChests.chest29Active == true)
        {
            GoldSpawn(); GoldSpawn(); GoldSpawn();
            yield return new WaitForSeconds(randomWait);
            GoldSpawn(); GoldSpawn();
            GoldSpawn(); GoldSpawn(); GoldSpawn();
            GoldSpawn(); GoldSpawn();
            if (randomGoldCount > 11) { GoldSpawn(); GoldSpawn(); }
            if (randomGoldCount == 8) { GoldSpawn(); GoldSpawn(); GoldSpawn(); }
            if (randomGoldCount < 8) { GoldSpawn(); }
        }
        #endregion

        #region chest30-35
        //Chest 30-35  Min = 13. Max = 16
        if (SelectChests.chest30Active == true || SelectChests.chest31Active == true || SelectChests.chest32Active == true || SelectChests.chest33Active == true || SelectChests.chest34Active == true || SelectChests.chest35Active == true)
        {
            GoldSpawn(); GoldSpawn(); GoldSpawn();
            yield return new WaitForSeconds(randomWait);
            GoldSpawn(); GoldSpawn(); GoldSpawn();
            GoldSpawn(); GoldSpawn(); GoldSpawn();
            GoldSpawn(); GoldSpawn();
            if (randomGoldCount > 11) { GoldSpawn(); GoldSpawn(); }
            if (randomGoldCount == 8) { GoldSpawn(); GoldSpawn(); GoldSpawn(); }
            if (randomGoldCount < 8) { GoldSpawn(); }
        }
        #endregion

        #region chest36-40
        //Chest 36-40  Min = 14. Max = 17
        if (SelectChests.chest36Active == true || SelectChests.chest37Active == true || SelectChests.chest38Active == true || SelectChests.chest39Active == true || SelectChests.chest40Active == true)
        {
            GoldSpawn(); GoldSpawn(); GoldSpawn();
            yield return new WaitForSeconds(randomWait);
            GoldSpawn(); GoldSpawn(); GoldSpawn();
            GoldSpawn(); GoldSpawn(); GoldSpawn();
            GoldSpawn(); GoldSpawn(); GoldSpawn();
            if (randomGoldCount > 11) { GoldSpawn(); GoldSpawn(); }
            if (randomGoldCount == 8) { GoldSpawn(); GoldSpawn(); GoldSpawn(); }
            if (randomGoldCount < 8) { GoldSpawn(); }
        }
        #endregion

        #endregion

    }

    #endregion

    #region xPMovement

    public bool enchantedXP, bossXP;

    public void XPSpawn()
    {
        GameObject xp = ObjectPooling.instance.GetXPFromPool();

        if(treasureXPMouse == true)
        {
            xp.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        else
        {
            xp.transform.position = new Vector3(0, 0, 0);
        }
        Transform targetTransform = targetGameObjectXRPBar.transform;
        StartCoroutine(MoveXPTowardsTarger(xp.transform, targetTransform));
    }

    IEnumerator MoveXPTowardsTarger(Transform xPTransform, Transform targetTransform)
    {
        float totalTime = 0.26f;
        float elapsedTime = 0f;
        Vector3 initialPosition = xPTransform.position;

        while (elapsedTime < totalTime)
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime / totalTime);
            xPTransform.position = Vector3.Lerp(initialPosition, targetTransform.position, t);
            yield return null;
        }

        //XP potion
        if(UseConsumable.XPPotionActive == true)
        {
            float randomSkill = Random.Range(0, 100);
            if(randomSkill <= 0.1f) { PlayerLevel.skillPoints += 1; Stats.totalSkillPoints += 1; }
        }

        //Skill tree XP upgrade 6
        if(SkillTree.xp6Bought == 1)
        {
            float random = Random.Range(0, 100);
            if(random <= 0.25f) { PlayerLevel.skillPoints += 1; Stats.totalSkillPoints += 1; }
        }

        if(SkillTree.xp7Bought == 1)
        {
            float random = Random.Range(0, 100);
            if (random >= 99.25f) { PlayerLevel.skillPoints += 1; Stats.totalSkillPoints += 1; }
        }

        if (SkillTree.xp8Bought == 1)
        {
            int random = Random.Range(0, 100);
            if (random == 3f) { PlayerLevel.skillPoints += 1; Stats.totalSkillPoints += 1; }
        }

        treasureXPMouse = false;
        PlayerLevel.experienceGained += (PlayerLevel.xpChestDrop * (UseConsumable.XPPotionBuff + UseConsumable.elixirXPBuff + SkillTree.skillTreeXP + ClickPower.cursorEquippedXPIncrease + RareTreasures.backPackXP + RareTreasures.cookieXP + UseConsumable.scrollXPBuff + UseConsumable.relicPermaXPBuff + UpdateGame.XPBuffAmount - UpdateGame.XPDebuffAmount + 1));

        if (enchantedXP == true)
        {
            PlayerLevel.experienceGained += (PlayerLevel.xpChestDrop * (UseConsumable.XPPotionBuff + UseConsumable.elixirXPBuff + SkillTree.skillTreeXP + ClickPower.cursorEquippedXPIncrease + RareTreasures.backPackXP + RareTreasures.cookieXP + UseConsumable.scrollXPBuff + UseConsumable.relicPermaXPBuff + UpdateGame.XPBuffAmount - UpdateGame.XPDebuffAmount + 1)) * UpdateGame.enchantedGoldenChestXPDrops;
        }
        if (bossXP == true)
        {
            PlayerLevel.experienceGained += (PlayerLevel.xpChestDrop * (UseConsumable.XPPotionBuff + UseConsumable.elixirXPBuff + SkillTree.skillTreeXP + ClickPower.cursorEquippedXPIncrease + RareTreasures.backPackXP + RareTreasures.cookieXP + UseConsumable.scrollXPBuff + UseConsumable.relicPermaXPBuff + UpdateGame.XPBuffAmount - UpdateGame.XPDebuffAmount + 1)) * UpdateGame.bossChestXPDrops;
        }

        enchantedXP = false;
        bossXP = false;

    }
    #endregion

    #region goldSpawn
    public void GoldSpawn()
    {
        Stats.goldCoinsDropped += 1;

        //Debug.Log(gemOnScreenCount);

        ReturnToPools.activeInHiercary = true;
        float random = Random.Range(-0.8f, 0.6f);
        float x5Xrandom = Random.Range(-1f, 0.9f);

        //If only clover is found and no skill tree is bought
        if(RareTreasures.cloverFound == 1 && SkillTree.gold5Bought != 1 && SkillTree.gold7Bought != 1 && SkillTree.gold8Bought != 1)
        {
            int random5X10X = Random.Range(1, 101);
            if(random5X10X < 3)
            {
                //Debug.Log("OnlyClover5X");
                Drop5XGoldCoin();
            }
            else if (random5X10X == 50)
            {
                //Debug.Log("OnlyClover10X");
                Drop10XGoldCoin();
            }
            else
            {
                gemOnScreenCount += 1;
                //Debug.Log("OnlyClover1X");
                GameObject goldObject = ObjectPooling.instance.GetGoldFromPool();
                goldObject.transform.position = new Vector3(random, ySpawnPos, 0);
            }

        }

        //If skill only gold 5 is bought;
        if (SkillTree.gold5Bought == 1 && SkillTree.gold7Bought != 1)
        {
            int random5X = Random.Range(1, 101);
            if(random5X < (4 + RareTreasures.clover5XChance))
            {
                //Debug.Log("OnlyGold5Bought 5X");
                Drop5XGoldCoin();
            }
            else
            {
                gemOnScreenCount += 1;
                //Debug.Log("OnlyGold5Bought 1X");
                GameObject goldObject = ObjectPooling.instance.GetGoldFromPool();
                goldObject.transform.position = new Vector3(random, ySpawnPos, 0);
            }


            if (RareTreasures.cloverFound == 1)
            {
                //Debug.Log("OnlyGold5Bought 10X");
                if (random5X == 50)
                {
                    //Debug.Log("Gold5And7 10X");
                    Drop10XGoldCoin();
                }
            }
        }

        //If skill tree gold 5 and 7 is bought
        if (SkillTree.gold5Bought == 1 && SkillTree.gold7Bought == 1 && SkillTree.gold8Bought != 1 && SkillTree.gold9Bought != 1)
        {
            int random5X = Random.Range(1, 101);
            if (random5X < (4 + RareTreasures.clover5XChance))
            {
                Drop5XGoldCoin();
                //Debug.Log("Gold5And7 5X");

            }
            else if(random5X > (98 - RareTreasures.clover10XChance))
            {
                //Debug.Log("Gold5And7 10X");
                Drop10XGoldCoin();
            }
            else
            {
                gemOnScreenCount += 1;
                //Debug.Log("Gold5And7 1X");
                GameObject goldObject = ObjectPooling.instance.GetGoldFromPool();
                goldObject.transform.position = new Vector3(random, ySpawnPos, 0);
            }
        }

        //If skill tree gold 5 and 7 and 8 is bought
        if (SkillTree.gold5Bought == 1 && SkillTree.gold7Bought == 1 && SkillTree.gold8Bought == 1 && SkillTree.gold9Bought != 1)
        {
            int random5X = Random.Range(1, 101);
            if (random5X < (4 + RareTreasures.clover5XChance))
            {
                Drop5XGoldCoin();
            }
            else if (random5X > (98 - RareTreasures.clover10XChance))
            {
                Drop10XGoldCoin();
            }
            else if (random5X == 50)
            {
                Drop25XGoldCoin();
            }
            else
            {
                gemOnScreenCount += 1;
                //Debug.Log("Gold5And7 1X");
                GameObject goldObject = ObjectPooling.instance.GetGoldFromPool();
                goldObject.transform.position = new Vector3(random, ySpawnPos, 0);
            }
        }

        //If final skill tree gold is purchased
        if (SkillTree.gold9Bought == 1)
        {
            int random5X = Random.Range(1, 101);
            if (random5X < (4 + RareTreasures.clover5XChance))
            {
                Drop5XGoldCoin();
            }
            else if (random5X > (98 - RareTreasures.clover10XChance))
            {
                Drop10XGoldCoin();
            }
            else if (random5X == 50)
            {
                Drop25XGoldCoin();
            }
            else
            {
                Drop5XGoldCoin();
            }
        }

        //If skill tree gold 5 and 7 is not bought and clover not found
        if (SkillTree.gold5Bought != 1 && SkillTree.gold7Bought != 1 && RareTreasures.cloverFound != 1 && SkillTree.gold8Bought != 1)
        {
            gemOnScreenCount += 1;
            //Debug.Log("nogold56andnoclover");
            GameObject goldObject = ObjectPooling.instance.GetGoldFromPool();
            goldObject.transform.position = new Vector3(random, ySpawnPos, 0);
        }
    }
    #endregion

    #region 5XGoldCoinDrop
    public void Drop5XGoldCoin()
    {
        float x5Xrandom = Random.Range(-1f, 0.9f);
        Stats.goldCoin5XDropped += 1;
        gemOnScreenCount += 1;
        GameObject gold5X = ObjectPooling.instance.GetGold5XFromPool();
        gold5X.transform.position = new Vector3(x5Xrandom, ySpawnPos, 0);
    }
    #endregion

    #region 10XGoldCoinDrop
    public void Drop10XGoldCoin()
    {
        float random = Random.Range(-0.8f, 0.6f);
        Stats.goldCoins10XDropped += 1;
        gemOnScreenCount += 1;
        GameObject gold10X = ObjectPooling.instance.GetGold10XFromPool();
        gold10X.transform.position = new Vector3(random, ySpawnPos, 0);
    }
    #endregion

    #region 25XGoldCoinDrop
    public void Drop25XGoldCoin()
    {
        float random = Random.Range(-0.8f, 0.6f);
        Stats.goldCoin25XDropped += 1;
        gemOnScreenCount += 1;
        GameObject gold25X = ObjectPooling.instance.GetGold25XFromPool();
        gold25X.transform.position = new Vector3(random, ySpawnPos, 0);
    }
    #endregion

    #region 100XGoldCoinDrop
    public void Drop100XGoldCoin()
    {
        float random = Random.Range(-0.8f, 0.6f);
        Stats.goldCoin100XDropped += 1;
        gemOnScreenCount += 1;
        GameObject gold100X = ObjectPooling.instance.GetGold100XFromPool();
        gold100X.transform.position = new Vector3(random, ySpawnPos, 0);
    }
    #endregion

    #region SoulGem
    public void DropSoulGem()
    {
        float random = Random.Range(-0.8f, 0.6f);
        gemOnScreenCount += 1;
        GameObject soulGem = ObjectPooling.instance.GetSoulGemFromPool();
        soulGem.transform.position = new Vector3(random, ySpawnPos, 0);
        soulGem.GetComponent<Rigidbody2D>().gravityScale = 1;
        soulGem.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));
    }
    #endregion

    #region quartz
    public static float quartzDropChance;

    public void QuartzDropChance()
    {
        float random = Random.Range(0, 100);

        if (random < quartzDropChance)
        {
            gemOnScreenCount += 1;
            GameObject quartz = ObjectPooling.instance.GetQuartzFromPool();
            float randomPos = Random.Range(-0.74f, 0.74f);
            quartz.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropQuartz()
    {
        gemOnScreenCount += 1;
        GameObject quartz = ObjectPooling.instance.GetQuartzFromPool();
        float randomPos = Random.Range(-0.62f, 0.62f);
        quartz.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }

    #endregion

    #region AmethystDropChance
    public static float amethystDropChance;

    public void AmethystDropChance()
    {
        float random = Random.Range(0, 100);

        if (random < amethystDropChance)
        {
            gemOnScreenCount += 1;
            GameObject amethyst = ObjectPooling.instance.GetAmethystFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            amethyst.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropAmethyst()
    {
        gemOnScreenCount += 1;
        GameObject amethyst = ObjectPooling.instance.GetAmethystFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        amethyst.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }

    #endregion

    #region yellowTopaz
    public static float yellowTopacChance;

    public void YellowTopazDropChance()
    {
        //float random = Random.Range(0, 2);
        float random = Random.Range(0, 100);

        if (random < yellowTopacChance)
        {
            gemOnScreenCount += 1;
            GameObject yellowTopaz = ObjectPooling.instance.GetYellowTopazFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            yellowTopaz.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropYellowTopaz()
    {
        gemOnScreenCount += 1;
        GameObject yellowTopaz = ObjectPooling.instance.GetYellowTopazFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        yellowTopaz.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }

    #endregion

    #region albite
    public static float albiteChance;

    public void AlbiteDropChance()
    {
        float random = Random.Range(0, 100);

        if (random < albiteChance)
        {
            gemOnScreenCount += 1;
            GameObject albite = ObjectPooling.instance.GetAlbiteFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            albite.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropAlbite()
    {
        gemOnScreenCount += 1;
        GameObject albite = ObjectPooling.instance.GetAlbiteFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        albite.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }

    #endregion

    #region redGarnet
    public static float redGarnetDropChance;

    public void RedGarnetDropChance()
    {
        float random = Random.Range(0, 100);

        if (random < redGarnetDropChance)
        {
            gemOnScreenCount += 1;
            GameObject redGarnet = ObjectPooling.instance.GetRedGarnetFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            redGarnet.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropRedGarnet()
    {
        gemOnScreenCount += 1;
        GameObject redGarnet = ObjectPooling.instance.GetRedGarnetFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        redGarnet.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }
    #endregion

    #region auqmarine
    public static float aquamarineChance;

    public void AquamarineDropChance()
    {
        float random = Random.Range(0, 100);

        if (random < aquamarineChance)
        {
            gemOnScreenCount += 1;
            GameObject aquamarine = ObjectPooling.instance.GetAquamarineFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            aquamarine.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropAquamarine()
    {
        gemOnScreenCount += 1;
        GameObject aquamarine = ObjectPooling.instance.GetAquamarineFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        aquamarine.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }

    #endregion

    #region yellowSapphire
    public static float yellowSapphireChance;

    public void YellowSapphireChance()
    {

        float random = Random.Range(0, 100);

        if (random < yellowSapphireChance)
        {
            gemOnScreenCount += 1;
            GameObject yellowSapphire = ObjectPooling.instance.GetYellowSapphireFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            yellowSapphire.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropYellowSapphire()
    {
        gemOnScreenCount += 1;
        GameObject yellowSapphire = ObjectPooling.instance.GetYellowSapphireFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        yellowSapphire.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }

    #endregion

    #region pinkTourmaline
    public static float pinkTourmalineChance;

    public void PinkTourmalineDropChance()
    {

        float random = Random.Range(0, 100);

        if (random < pinkTourmalineChance)
        {
            gemOnScreenCount += 1;
            GameObject pinkTourmaline = ObjectPooling.instance.GetPinkTourmalineFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            pinkTourmaline.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropPinkTourmaline()
    {
        gemOnScreenCount += 1;
        GameObject pinkTourmaline = ObjectPooling.instance.GetPinkTourmalineFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        pinkTourmaline.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }

    #endregion

    #region adventurine
    public static float adventurineChance;

    public void AdventurineDropChance()
    {

        float random = Random.Range(0, 100);

        if (random < adventurineChance)
        {
            gemOnScreenCount += 1;
            GameObject adventurine = ObjectPooling.instance.GetAdventurineFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            adventurine.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropAdventurine()
    {
        gemOnScreenCount += 1;
        GameObject adventurine = ObjectPooling.instance.GetAdventurineFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        adventurine.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }
    #endregion

    #region redGemDropChance
    public GameObject itemCollecteBar;
    public static float redGemChance;

    public void RedGemChance()
    {
        //float random = Random.Range(0, 2);
        float random = Random.Range(0, 100);

        if (random < redGemChance)
        {
            gemOnScreenCount += 1;
            GameObject redGem = ObjectPooling.instance.GetRedGemFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            redGem.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropRedGem()
    {
        gemOnScreenCount += 1;
        GameObject redGem = ObjectPooling.instance.GetRedGemFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        redGem.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }

    #endregion

    #region diamondDropChance
    public static float diamondDropChance;

    public void DiamondDropChance()
    {

        float random = Random.Range(0, 100);

        if (random < diamondDropChance)
        {
            gemOnScreenCount += 1;
            GameObject diamond = ObjectPooling.instance.GetDiamondFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            diamond.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropDiamond()
    {
        gemOnScreenCount += 1;
        GameObject diamond = ObjectPooling.instance.GetDiamondFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        diamond.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }

    #endregion

    #region grandidierite
    public static float grandidieriteChance;

    public void GrandidieriteDropChance()
    {

        float random = Random.Range(0, 100);

        if (random < grandidieriteChance)
        {
            gemOnScreenCount += 1;
            GameObject grandidierite = ObjectPooling.instance.GetGrandidieriteToPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            grandidierite.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropGrandidierite()
    {
        gemOnScreenCount += 1;
        GameObject grandidierite = ObjectPooling.instance.GetGrandidieriteToPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        grandidierite.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }

    #endregion

    #region violetCrystal
    public static float violetDropChance;

    public void VioletDropChance()
    {

        float random = Random.Range(0, 100);

        if (random < violetDropChance)
        {
            gemOnScreenCount += 1;
            GameObject violet = ObjectPooling.instance.GetVoiletFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            violet.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropViolet()
    {
        gemOnScreenCount += 1;
        GameObject violet = ObjectPooling.instance.GetVoiletFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        violet.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }

    #endregion

    #region akoyaPearl
    public static float akoyaPearlChance;

    public void AkoyaPearlDropChance()
    {
        float random = Random.Range(0, 100);

        if (random < akoyaPearlChance)
        {
            gemOnScreenCount += 1;
            GameObject akoyaPearl = ObjectPooling.instance.GetAkoyaPearlFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            akoyaPearl.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropAkoyaPearl()
    {
        gemOnScreenCount += 1;
        GameObject akoyaPearl = ObjectPooling.instance.GetAkoyaPearlFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        akoyaPearl.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }

    #endregion

    #region purpleRupee
    public static float purpleRupeeDropChance;

    public void PurpleRupeeDropChance()
    {
        float random = Random.Range(0, 100);

        if (random < purpleRupeeDropChance)
        {
            gemOnScreenCount += 1;
            GameObject purpleRupee = ObjectPooling.instance.GetPurpleRupeeFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            purpleRupee.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropPurpleRupee()
    {
        gemOnScreenCount += 1;
        GameObject purpleRupee = ObjectPooling.instance.GetPurpleRupeeFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        purpleRupee.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }

    #endregion

    #region emerald
    public static float emeraldDropChance;

    public void EmeraldDropChance()
    {
        float random = Random.Range(0, 100);

        if (random < emeraldDropChance)
        {
            gemOnScreenCount += 1;
            GameObject emerald = ObjectPooling.instance.GetEmeraldFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            emerald.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropEmerald()
    {
        gemOnScreenCount += 1;
        GameObject emerald = ObjectPooling.instance.GetEmeraldFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        emerald.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }

    #endregion

    #region greenDiamond
    public static float greenDiamondChance;

    public void GreenDiamondChance()
    {

        float random = Random.Range(0, 100);

        if (random < greenDiamondChance)
        {
            gemOnScreenCount += 1;
            GameObject greenDiamond = ObjectPooling.instance.GetGreenDiamondfromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            greenDiamond.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropGreenDiamond()
    {
        gemOnScreenCount += 1;
        GameObject greenDiamond = ObjectPooling.instance.GetGreenDiamondfromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        greenDiamond.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }

    #endregion

    #region fireOpal
    public static float fireOpalChance;

    public void FireOpalDropChance()
    {

        float random = Random.Range(0, 100);

        if (random < fireOpalChance)
        {
            gemOnScreenCount += 1;
            GameObject fireOpal = ObjectPooling.instance.GetFireOpalFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            fireOpal.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropFireOpal()
    {
        gemOnScreenCount += 1;
        GameObject fireOpal = ObjectPooling.instance.GetFireOpalFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        fireOpal.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }

    #endregion

    #region gemSilica
    public static float gemSilicaChance;

    public void GemSilicaDropChance()
    {
        float random = Random.Range(0, 100);

        if (random < gemSilicaChance)
        {
            gemOnScreenCount += 1;
            GameObject gemSilica = ObjectPooling.instance.GetGemSilicaFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            gemSilica.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropGemSilica()
    {
        gemOnScreenCount += 1;
        GameObject gemSilica = ObjectPooling.instance.GetGemSilicaFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        gemSilica.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }

    #endregion

    #region pinkPlort
    public static float pinkPlortDropChance;

    public void PinkPlortDropChance()
    {
        float random = Random.Range(0, 100);

        if (random < pinkPlortDropChance)
        {
            gemOnScreenCount += 1;
            GameObject pinkPlort = ObjectPooling.instance.GetPinkPlortFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            pinkPlort.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropPinkPlort()
    {
        gemOnScreenCount += 1;
        GameObject pinkPlort = ObjectPooling.instance.GetPinkPlortFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        pinkPlort.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }

    #endregion

    #region goldenSeaPearl
    public static float goldenSeaPearlChance;

    public void GoldenSeaPearlDropChance()
    {
        float random = Random.Range(0, 100);

        if (random < goldenSeaPearlChance)
        {
            gemOnScreenCount += 1;
            GameObject goldenSeaPearl = ObjectPooling.instance.GetGoldenSeaPearlFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            goldenSeaPearl.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropGoldenSeaPearl()
    {
        gemOnScreenCount += 1;
        GameObject goldenSeaPearl = ObjectPooling.instance.GetGoldenSeaPearlFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        goldenSeaPearl.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }

    #endregion

    #region kyanite
    public static float kyaniteChance;

    public void KyaniteDropChance()
    {
        float random = Random.Range(0, 100);

        if (random < kyaniteChance)
        {
            gemOnScreenCount += 1;
            GameObject kyanite = ObjectPooling.instance.GetKyaniteFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            kyanite.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropKyanite()
    {
        gemOnScreenCount += 1;
        GameObject kyanite = ObjectPooling.instance.GetKyaniteFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        kyanite.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }
    #endregion

    #region blackOpal
    public static float blackOpalChance;

    public void BlackOpalDropChance()
    {
        float random = Random.Range(0, 100);

        if (random < blackOpalChance)
        {
            gemOnScreenCount += 1;
            GameObject blackOpal = ObjectPooling.instance.GetBlackOpalFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            blackOpal.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropBlackOpal()
    {
        gemOnScreenCount += 1;
        GameObject blackOpal = ObjectPooling.instance.GetBlackOpalFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        blackOpal.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }
    #endregion

    #region painite
    public static float painiteChance;

    public void PainiteDropChance()
    {
        float random = Random.Range(0, 100);

        if (random < painiteChance)
        {
            gemOnScreenCount += 1;
            GameObject painite = ObjectPooling.instance.GetPainiteFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            painite.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropPainite()
    {
        gemOnScreenCount += 1;
        GameObject painite = ObjectPooling.instance.GetPainiteFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        painite.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }
    #endregion

    #region tanzanite
    public static float tanzaniteChance;
    public void TanzaniteDropChance()
    {
        float random = Random.Range(0, 100);

        if (random < tanzaniteChance)
        {
            gemOnScreenCount += 1;
            GameObject tanzanite = ObjectPooling.instance.GetTanzaniteFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            tanzanite.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropTanzanite()
    {
        gemOnScreenCount += 1;
        GameObject tanzanite = ObjectPooling.instance.GetTanzaniteFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        tanzanite.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }
    #endregion

    #region astralium
    public static float astraliumChance;
    public void AstraliumDropChance()
    {
        float random = Random.Range(0, 100);

        if (random < astraliumChance)
        {
            gemOnScreenCount += 1;
            GameObject astralium = ObjectPooling.instance.GetAstraliumFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            astralium.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropAstralium()
    {
        gemOnScreenCount += 1;
        GameObject astralium = ObjectPooling.instance.GetAstraliumFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        astralium.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }
    #endregion

    #region elysiumPrism
    public static float elysiumPrismChance;
    public void ElysiumPrismDropChance()
    {
        float random = Random.Range(0, 100);

        if (random < elysiumPrismChance)
        {
            gemOnScreenCount += 1;
            GameObject elysiumPrism = ObjectPooling.instance.GetElysiumPrismFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            elysiumPrism.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropElysiumPrism()
    {
        gemOnScreenCount += 1;
        GameObject elysiumPrism = ObjectPooling.instance.GetElysiumPrismFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        elysiumPrism.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }
    #endregion

    #region aetherfireOpal
    public static float aetherfireOpalChance;
    public void AetherfireOpalDropChance()
    {
        float random = Random.Range(0, 100);

        if (random < aetherfireOpalChance)
        {
            gemOnScreenCount += 1;
            GameObject aetherfireOpal = ObjectPooling.instance.GetAetherfireOpalFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            aetherfireOpal.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropAetherfireOpal()
    {
        gemOnScreenCount += 1;
        GameObject aetherfireOpal = ObjectPooling.instance.GetAetherfireOpalFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        aetherfireOpal.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }
    #endregion

    #region eldritchStarstone
    public static float eldritchStarstoneChance;
    public void EldritchStarstoneDropChance()
    {
        float random = Random.Range(0, 100);

        if (random < eldritchStarstoneChance)
        {
            gemOnScreenCount += 1;
            GameObject eldritchStarstone = ObjectPooling.instance.GetEldritchStarstoneFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            eldritchStarstone.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropEldritchStarstone()
    {
        gemOnScreenCount += 1;
        GameObject eldritchStarstone = ObjectPooling.instance.GetEldritchStarstoneFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        eldritchStarstone.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }
    #endregion

    #region chronolithShard
    public static float chronolithShardChance;
    public void ChronolithShardDropChance()
    {
        float random = Random.Range(0, 100);

        if (random < chronolithShardChance)
        {
            gemOnScreenCount += 1;
            GameObject chronolithShard = ObjectPooling.instance.GetChronolithShardFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            chronolithShard.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropChronolithShard()
    {
        gemOnScreenCount += 1;
        GameObject chronolithShard = ObjectPooling.instance.GetChronolithShardFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        chronolithShard.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }
    #endregion

    #region sideriumEssence
    public static float sideriumEssenceChance;
    public void SideriumEssenceDropChance()
    {
        float random = Random.Range(0, 100);

        if (random < sideriumEssenceChance)
        {
            gemOnScreenCount += 1;
            GameObject sideriumEssence = ObjectPooling.instance.GetSideriumEssenceFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            sideriumEssence.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropSideriumEssence()
    {
        gemOnScreenCount += 1;
        GameObject sideriumEssence = ObjectPooling.instance.GetSideriumEssenceFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        sideriumEssence.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }
    #endregion

    #region quasarite
    public static float quasariteChance;
    public void QuasariteDropChance()
    {
        float random = Random.Range(0, 100);

        if (random < quasariteChance)
        {
            gemOnScreenCount += 1;
            GameObject quasarite = ObjectPooling.instance.GetQuasariteFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            quasarite.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropQuasarite()
    {
        gemOnScreenCount += 1;
        GameObject quasarite = ObjectPooling.instance.GetQuasariteFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        quasarite.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }
    #endregion

    #region radiantNovaStone
    public static float radiantNovaStoneChance;
    public void RadiantNovaStoneDropChance()
    {
        float random = Random.Range(0, 100);

        if (random < radiantNovaStoneChance)
        {
            gemOnScreenCount += 1;
            GameObject radiantNovaStone = ObjectPooling.instance.GetRadiantNovaStoneFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            radiantNovaStone.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropRadiantNovaStone()
    {
        gemOnScreenCount += 1;
        GameObject radiantNovaStone = ObjectPooling.instance.GetRadiantNovaStoneFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        radiantNovaStone.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }
    #endregion

    #region soluniumShard
    public static float soluniumShardChance;
    public void SoluniumShardDropChance()
    {
        float random = Random.Range(0, 100);

        if (random < soluniumShardChance)
        {
            gemOnScreenCount += 1;
            GameObject soluniumShard = ObjectPooling.instance.GetSoluniumShardFromPool();
            float randomPos = Random.Range(-0.5f, 0.5f);
            soluniumShard.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;
        }
    }

    public void DropSoluniumShard()
    {
        gemOnScreenCount += 1;
        GameObject soluniumShard = ObjectPooling.instance.GetSoluniumShardFromPool();
        float randomPos = Random.Range(-0.5f, 0.5f);
        soluniumShard.transform.position = new Vector3(randomPos, ySpawnPos, 0);
        Transform targetTransform = itemCollecteBar.transform;
    }
    #endregion

    public void DropRareDrops()
    {
        if (SelectChests.chest1Active == true)
        {
            DropQuartz();
        }
        if (SelectChests.chest2Active == true)
        {
            int random = Random.Range(1, 3);
            if(random == 1) { DropQuartz(); }
            if(random == 2) { DropAmethyst(); }
        }
        if (SelectChests.chest3Active == true)
        {
            int random = Random.Range(1, 4);
            if (random == 1) { DropQuartz(); }
            if (random == 2) { DropAmethyst(); }
            if (random == 3) { DropYellowTopaz(); }
        }
        if (SelectChests.chest4Active == true)
        {
            int random = Random.Range(1, 5);
            if (random == 1) { DropQuartz(); }
            if (random == 2) { DropAmethyst(); }
            if (random == 3) { DropYellowTopaz(); }
            if (random == 4) { DropAlbite(); }
           
        }
        if (SelectChests.chest5Active == true)
        {
            int random = Random.Range(1, 6);
            if (random == 1) { DropQuartz(); }
            if (random == 2) { DropAmethyst(); }
            if (random == 3) { DropYellowTopaz(); }
            if (random == 4) { DropAlbite(); }
            if (random == 5) { DropRedGarnet(); }
        }
        if (SelectChests.chest6Active == true)
        {
            int random = Random.Range(1, 6);
            if (random == 1) { DropQuartz(); }
            if (random == 2) { DropAmethyst(); }
            if (random == 3) { DropYellowTopaz(); }
            if (random == 4) { DropAlbite(); }
            if (random == 5) { DropRedGarnet(); }
        }
        if (SelectChests.chest7Active == true)
        {
            int random = Random.Range(1, 6);
            if (random == 1) { DropAmethyst(); }
            if (random == 2) { DropYellowTopaz(); }
            if (random == 3) { DropAlbite(); }
            if (random == 4) { DropRedGarnet(); }
            if (random == 5) { DropAquamarine(); }
        }
        if (SelectChests.chest8Active == true)
        {
            int random = Random.Range(1, 6);
            if (random == 1) { DropYellowSapphire(); }
            if (random == 2) { DropYellowTopaz(); }
            if (random == 3) { DropAlbite(); }
            if (random == 4) { DropRedGarnet(); }
            if (random == 5) { DropAquamarine(); }
        }
        if (SelectChests.chest9Active == true)
        {
            int random = Random.Range(1, 6);
            if (random == 1) { DropYellowSapphire(); }
            if (random == 2) { DropYellowTopaz(); }
            if (random == 3) { DropAlbite(); }
            if (random == 4) { DropRedGarnet(); }
            if (random == 5) { DropAquamarine(); }
        }
        if (SelectChests.chest10Active == true)
        {
            int random = Random.Range(1, 6);
            if (random == 1) { DropYellowSapphire(); }
            if (random == 2) { DropPinkTourmaline(); }
            if (random == 3) { DropAlbite(); }
            if (random == 4) { DropRedGarnet(); }
            if (random == 5) { DropAquamarine(); }
        }
        if (SelectChests.chest11Active == true)
        {
            int random = Random.Range(1, 6);
            if (random == 1) { DropYellowSapphire(); }
            if (random == 2) { DropPinkTourmaline(); }
            if (random == 3) { DropAlbite(); }
            if (random == 4) { DropRedGarnet(); }
            if (random == 5) { DropAquamarine(); }
        }
        if (SelectChests.chest12Active == true)
        {
            int random = Random.Range(1, 6);
            if (random == 1) { DropRedGarnet(); }
            if (random == 2) { DropAquamarine(); }
            if (random == 3) { DropYellowSapphire(); }
            if (random == 4) { DropPinkTourmaline(); }
            if (random == 5) { DropAdventurine(); }
        }
        if (SelectChests.chest13Active == true)
        {
            int random = Random.Range(1, 6);
            if (random == 1) { DropRedGarnet(); }
            if (random == 2) { DropAquamarine(); }
            if (random == 3) { DropYellowSapphire(); }
            if (random == 4) { DropPinkTourmaline(); }
            if (random == 5) { DropAdventurine(); }
        }
        if (SelectChests.chest14Active == true)
        {
            int random = Random.Range(1, 6);
            if (random == 1) { DropRedGem(); }
            if (random == 2) { DropAquamarine(); }
            if (random == 3) { DropYellowSapphire(); }
            if (random == 4) { DropPinkTourmaline(); }
            if (random == 5) { DropAdventurine(); }
        }
        if (SelectChests.chest15Active == true)
        {
            int random = Random.Range(1, 6);
            if (random == 1) { DropYellowSapphire(); }
            if (random == 2) { DropPinkTourmaline(); }
            if (random == 3) { DropAdventurine(); }
            if (random == 4) { DropRedGem(); }
            if (random == 5) { DropDiamond(); }
        }
        if (SelectChests.chest16Active == true)
        {
            int random = Random.Range(1, 6);
            if (random == 1) { DropGrandidierite(); }
            if (random == 2) { DropPinkTourmaline(); }
            if (random == 3) { DropAdventurine(); }
            if (random == 4) { DropRedGem(); }
            if (random == 5) { DropDiamond(); }
        }
        if (SelectChests.chest17Active == true)
        {
            int random = Random.Range(1, 6);
            if (random == 1) { DropGrandidierite(); }
            if (random == 2) { DropPinkTourmaline(); }
            if (random == 3) { DropAdventurine(); }
            if (random == 4) { DropRedGem(); }
            if (random == 5) { DropDiamond(); }
        }
        if (SelectChests.chest18Active == true)
        {
            int random = Random.Range(1, 7);
            if (random == 1) { DropGrandidierite(); }
            if (random == 2) { DropPinkTourmaline(); }
            if (random == 3) { DropAdventurine(); }
            if (random == 4) { DropRedGem(); }
            if (random == 5) { DropDiamond(); }
            if (random == 6) { DropViolet(); }
        }
        if (SelectChests.chest19Active == true)
        {
            int random = Random.Range(1, 7);
            if (random == 1) { DropRedGem(); }
            if (random == 2) { DropDiamond(); }
            if (random == 3) { DropGrandidierite(); }
            if (random == 4) { DropViolet(); }
            if (random == 5) { DropAkoyaPearl(); }
            if (random == 6) { DropPurpleRupee(); }
        }
        if (SelectChests.chest20Active == true)
        {
            int random = Random.Range(1, 7);
            if (random == 1) { DropEmerald(); }
            if (random == 2) { DropDiamond(); }
            if (random == 3) { DropGrandidierite(); }
            if (random == 4) { DropViolet(); }
            if (random == 5) { DropAkoyaPearl(); }
            if (random == 6) { DropPurpleRupee(); }
        }
        if (SelectChests.chest21Active == true)
        {
            int random = Random.Range(1, 7);
            if (random == 1) { DropEmerald(); }
            if (random == 2) { DropGreenDiamond(); }
            if (random == 3) { DropGrandidierite(); }
            if (random == 4) { DropViolet(); }
            if (random == 5) { DropAkoyaPearl(); }
            if (random == 6) { DropPurpleRupee(); }
        }
        if (SelectChests.chest22Active == true)
        {
            int random = Random.Range(1, 7);
            if (random == 1) { DropEmerald(); }
            if (random == 2) { DropGreenDiamond(); }
            if (random == 3) { DropFireOpal(); }
            if (random == 4) { DropViolet(); }
            if (random == 5) { DropAkoyaPearl(); }
            if (random == 6) { DropPurpleRupee(); }
        }
        if (SelectChests.chest23Active == true)
        {
            int random = Random.Range(1, 7);
            if (random == 1) { DropEmerald(); }
            if (random == 2) { DropGreenDiamond(); }
            if (random == 3) { DropFireOpal(); }
            if (random == 4) { DropGemSilica(); }
            if (random == 5) { DropPinkPlort(); }
            if (random == 6) { DropPurpleRupee(); }
        }
        if (SelectChests.chest24Active == true)
        {
            int random = Random.Range(1, 7);
            if (random == 1) { DropKyanite(); }
            if (random == 2) { DropGreenDiamond(); }
            if (random == 3) { DropFireOpal(); }
            if (random == 4) { DropGemSilica(); }
            if (random == 5) { DropPinkPlort(); }
            if (random == 6) { DropGoldenSeaPearl(); }
        }
        if (SelectChests.chest25Active == true)
        {
            int random = Random.Range(1, 8);
            if (random == 1) { DropKyanite(); }
            if (random == 2) { DropGreenDiamond(); }
            if (random == 3) { DropFireOpal(); }
            if (random == 4) { DropGemSilica(); }
            if (random == 5) { DropPinkPlort(); }
            if (random == 6) { DropGoldenSeaPearl(); }
            if (random == 7) { DropBlackOpal(); }
        }
        if (SelectChests.chest26Active == true)
        {
            int random = Random.Range(1, 10);
            if (random == 1) { DropEmerald(); }
            if (random == 2) { DropGreenDiamond(); }
            if (random == 3) { DropFireOpal(); }
            if (random == 4) { DropGemSilica(); }
            if (random == 5) { DropPinkPlort(); }
            if (random == 6) { DropGoldenSeaPearl(); }
            if (random == 7) { DropKyanite(); }
            if (random == 8) { DropBlackOpal(); }
            if (random == 9) { DropPainite(); }
        }
        #region chest27
        if (SelectChests.chest27Active == true)
        {
            int random = Random.Range(1, 10);
            if (random == 1) { DropTanzanite(); }
            if (random == 2) { DropGreenDiamond(); }
            if (random == 3) { DropFireOpal(); }
            if (random == 4) { DropGemSilica(); }
            if (random == 5) { DropPinkPlort(); }
            if (random == 6) { DropGoldenSeaPearl(); }
            if (random == 7) { DropKyanite(); }
            if (random == 8) { DropBlackOpal(); }
            if (random == 9) { DropPainite(); }
        }
        #endregion

        #region chest28
        if (SelectChests.chest28Active == true)
        {
            int random = Random.Range(1, 10);
            if (random == 1) { DropTanzanite(); }
            if (random == 2) { DropGreenDiamond(); }
            if (random == 3) { DropFireOpal(); }
            if (random == 4) { DropGemSilica(); }
            if (random == 5) { DropPinkPlort(); }
            if (random == 6) { DropGoldenSeaPearl(); }
            if (random == 7) { DropKyanite(); }
            if (random == 8) { DropBlackOpal(); }
            if (random == 9) { DropPainite(); }
        }
        #endregion

        #region chest29
        if (SelectChests.chest29Active == true)
        {
            int random = Random.Range(1, 11);
            if (random == 1) { DropTanzanite(); }
            if (random == 2) { DropGreenDiamond(); }
            if (random == 3) { DropFireOpal(); }
            if (random == 4) { DropGemSilica(); }
            if (random == 5) { DropPinkPlort(); }
            if (random == 6) { DropGoldenSeaPearl(); }
            if (random == 7) { DropKyanite(); }
            if (random == 8) { DropBlackOpal(); }
            if (random == 9) { DropPainite(); }
            if (random == 10) { DropAstralium(); }
        }
        #endregion

        #region chest30
        if (SelectChests.chest30Active == true)
        {
            int random = Random.Range(1, 12);
            if (random == 1) { DropTanzanite(); }
            if (random == 2) { DropGreenDiamond(); }
            if (random == 3) { DropFireOpal(); }
            if (random == 4) { DropGemSilica(); }
            if (random == 5) { DropPinkPlort(); }
            if (random == 6) { DropGoldenSeaPearl(); }
            if (random == 7) { DropKyanite(); }
            if (random == 8) { DropBlackOpal(); }
            if (random == 9) { DropPainite(); }
            if (random == 10) { DropAstralium(); }
            if (random == 11) { DropElysiumPrism(); }
        }
        #endregion

        #region chest31
        if (SelectChests.chest31Active == true)
        {
            int random = Random.Range(1, 13);
            if (random == 1) { DropTanzanite(); }
            if (random == 2) { DropGreenDiamond(); }
            if (random == 3) { DropFireOpal(); }
            if (random == 4) { DropGemSilica(); }
            if (random == 5) { DropPinkPlort(); }
            if (random == 6) { DropGoldenSeaPearl(); }
            if (random == 7) { DropKyanite(); }
            if (random == 8) { DropBlackOpal(); }
            if (random == 9) { DropPainite(); }
            if (random == 10) { DropAstralium(); }
            if (random == 11) { DropElysiumPrism(); }
            if (random == 12) { DropAetherfireOpal(); }
        }
        #endregion

        #region chest32
        if (SelectChests.chest32Active == true)
        {
            int random = Random.Range(1, 13);
            if (random == 1) { DropTanzanite(); }
            if (random == 2) { DropGreenDiamond(); }
            if (random == 3) { DropFireOpal(); }
            if (random == 4) { DropGemSilica(); }
            if (random == 5) { DropPinkPlort(); }
            if (random == 6) { DropGoldenSeaPearl(); }
            if (random == 7) { DropKyanite(); }
            if (random == 8) { DropBlackOpal(); }
            if (random == 9) { DropPainite(); }
            if (random == 10) { DropAstralium(); }
            if (random == 11) { DropElysiumPrism(); }
            if (random == 12) { DropAetherfireOpal(); }
        }
        #endregion

        #region chest33
        if (SelectChests.chest33Active == true)
        {
            int random = Random.Range(1, 14);
            if (random == 1) { DropTanzanite(); }
            if (random == 2) { DropGreenDiamond(); }
            if (random == 3) { DropFireOpal(); }
            if (random == 4) { DropGemSilica(); }
            if (random == 5) { DropPinkPlort(); }
            if (random == 6) { DropGoldenSeaPearl(); }
            if (random == 7) { DropKyanite(); }
            if (random == 8) { DropBlackOpal(); }
            if (random == 9) { DropPainite(); }
            if (random == 10) { DropAstralium(); }
            if (random == 11) { DropElysiumPrism(); }
            if (random == 12) { DropAetherfireOpal(); }
            if (random == 13) { DropEldritchStarstone(); }
        }
        #endregion

        #region chest34
        if (SelectChests.chest34Active == true)
        {
            int random = Random.Range(1, 15);
            if (random == 1) { DropTanzanite(); }
            if (random == 2) { DropGreenDiamond(); }
            if (random == 3) { DropFireOpal(); }
            if (random == 4) { DropGemSilica(); }
            if (random == 5) { DropPinkPlort(); }
            if (random == 6) { DropGoldenSeaPearl(); }
            if (random == 7) { DropKyanite(); }
            if (random == 8) { DropBlackOpal(); }
            if (random == 9) { DropPainite(); }
            if (random == 10) { DropAstralium(); }
            if (random == 11) { DropElysiumPrism(); }
            if (random == 12) { DropAetherfireOpal(); }
            if (random == 13) { DropEldritchStarstone(); }
            if (random == 14) { DropChronolithShard(); }
        }
        #endregion

        #region chest35
        if (SelectChests.chest35Active == true)
        {
            int random = Random.Range(1, 16);
            if (random == 1) { DropTanzanite(); }
            if (random == 2) { DropGreenDiamond(); }
            if (random == 3) { DropFireOpal(); }
            if (random == 4) { DropGemSilica(); }
            if (random == 5) { DropPinkPlort(); }
            if (random == 6) { DropGoldenSeaPearl(); }
            if (random == 7) { DropKyanite(); }
            if (random == 8) { DropBlackOpal(); }
            if (random == 9) { DropPainite(); }
            if (random == 10) { DropAstralium(); }
            if (random == 11) { DropElysiumPrism(); }
            if (random == 12) { DropAetherfireOpal(); }
            if (random == 13) { DropEldritchStarstone(); }
            if (random == 14) { DropChronolithShard(); }
            if (random == 15) { DropSideriumEssence(); }
        }
        #endregion

        #region chest36
        if (SelectChests.chest36Active == true)
        {
            int random = Random.Range(1, 17);
            if (random == 1) { DropTanzanite(); }
            if (random == 2) { DropGreenDiamond(); }
            if (random == 3) { DropFireOpal(); }
            if (random == 4) { DropGemSilica(); }
            if (random == 5) { DropPinkPlort(); }
            if (random == 6) { DropGoldenSeaPearl(); }
            if (random == 7) { DropKyanite(); }
            if (random == 8) { DropBlackOpal(); }
            if (random == 9) { DropPainite(); }
            if (random == 10) { DropAstralium(); }
            if (random == 11) { DropElysiumPrism(); }
            if (random == 12) { DropAetherfireOpal(); }
            if (random == 13) { DropEldritchStarstone(); }
            if (random == 14) { DropChronolithShard(); }
            if (random == 15) { DropSideriumEssence(); }
            if (random == 16) { DropQuasarite(); }
        }
        #endregion

        #region chest37
        if (SelectChests.chest37Active == true)
        {
            int random = Random.Range(1, 18);
            if (random == 1) { DropTanzanite(); }
            if (random == 2) { DropGreenDiamond(); }
            if (random == 3) { DropFireOpal(); }
            if (random == 4) { DropGemSilica(); }
            if (random == 5) { DropPinkPlort(); }
            if (random == 6) { DropGoldenSeaPearl(); }
            if (random == 7) { DropKyanite(); }
            if (random == 8) { DropBlackOpal(); }
            if (random == 9) { DropPainite(); }
            if (random == 10) { DropAstralium(); }
            if (random == 11) { DropElysiumPrism(); }
            if (random == 12) { DropAetherfireOpal(); }
            if (random == 13) { DropEldritchStarstone(); }
            if (random == 14) { DropChronolithShard(); }
            if (random == 15) { DropSideriumEssence(); }
            if (random == 16) { DropQuasarite(); }
            if (random == 17) { DropRadiantNovaStone(); }
        }
        #endregion

        #region chest38
        if (SelectChests.chest38Active == true)
        {
            int random = Random.Range(1, 19);
            if (random == 1) { DropTanzanite(); }
            if (random == 2) { DropGreenDiamond(); }
            if (random == 3) { DropFireOpal(); }
            if (random == 4) { DropGemSilica(); }
            if (random == 5) { DropPinkPlort(); }
            if (random == 6) { DropGoldenSeaPearl(); }
            if (random == 7) { DropKyanite(); }
            if (random == 8) { DropBlackOpal(); }
            if (random == 9) { DropPainite(); }
            if (random == 10) { DropAstralium(); }
            if (random == 11) { DropElysiumPrism(); }
            if (random == 12) { DropAetherfireOpal(); }
            if (random == 13) { DropEldritchStarstone(); }
            if (random == 14) { DropChronolithShard(); }
            if (random == 15) { DropSideriumEssence(); }
            if (random == 16) { DropQuasarite(); }
            if (random == 17) { DropRadiantNovaStone(); }
            if (random == 18) { DropSoluniumShard(); }
        }
        #endregion

        #region chest39
        if (SelectChests.chest39Active == true)
        {
            int random = Random.Range(1, 19);
            if (random == 1) { DropTanzanite(); }
            if (random == 2) { DropGreenDiamond(); }
            if (random == 3) { DropFireOpal(); }
            if (random == 4) { DropGemSilica(); }
            if (random == 5) { DropPinkPlort(); }
            if (random == 6) { DropGoldenSeaPearl(); }
            if (random == 7) { DropKyanite(); }
            if (random == 8) { DropBlackOpal(); }
            if (random == 9) { DropPainite(); }
            if (random == 10) { DropAstralium(); }
            if (random == 11) { DropElysiumPrism(); }
            if (random == 12) { DropAetherfireOpal(); }
            if (random == 13) { DropEldritchStarstone(); }
            if (random == 14) { DropChronolithShard(); }
            if (random == 15) { DropSideriumEssence(); }
            if (random == 16) { DropQuasarite(); }
            if (random == 17) { DropRadiantNovaStone(); }
            if (random == 18) { DropSoluniumShard(); }
        }
        #endregion

        #region chest40
        if (SelectChests.chest40Active == true)
        {
            int random = Random.Range(1, 19);
            if (random == 1) { DropTanzanite(); }
            if (random == 2) { DropGreenDiamond(); }
            if (random == 3) { DropFireOpal(); }
            if (random == 4) { DropGemSilica(); }
            if (random == 5) { DropPinkPlort(); }
            if (random == 6) { DropGoldenSeaPearl(); }
            if (random == 7) { DropKyanite(); }
            if (random == 8) { DropBlackOpal(); }
            if (random == 9) { DropPainite(); }
            if (random == 10) { DropAstralium(); }
            if (random == 11) { DropElysiumPrism(); }
            if (random == 12) { DropAetherfireOpal(); }
            if (random == 13) { DropEldritchStarstone(); }
            if (random == 14) { DropChronolithShard(); }
            if (random == 15) { DropSideriumEssence(); }
            if (random == 16) { DropQuasarite(); }
            if (random == 17) { DropRadiantNovaStone(); }
            if (random == 18) { DropSoluniumShard(); }
        }
        #endregion
    }

    public float treasuresYPos;

    public void AllRareDropsTesting()
    {
        RedGemChance();
        AmethystDropChance();
        YellowSapphireChance();
        DiamondDropChance();
        PurpleRupeeDropChance();
        VioletDropChance();
        GrandidieriteDropChance();
        GreenDiamondChance();
        PinkPlortDropChance();
        EmeraldDropChance();
        QuartzDropChance();
        RedGarnetDropChance();
        PinkTourmalineDropChance();
        YellowTopazDropChance();
        AquamarineDropChance();
        FireOpalDropChance();
        GoldenSeaPearlDropChance();
        AkoyaPearlDropChance();
        GemSilicaDropChance();
        AdventurineDropChance();
        KyaniteDropChance();
        AlbiteDropChance();
        BlackOpalDropChance();
        PainiteDropChance();
        TanzaniteDropChance();
    }

    //Rare Treasures
    #region SuperRareDrops
    public void TriggerAllSuperRareDrops()
    {
        //Debug.Log("Open");
        SkullDrop();
        SwordDrop();
        RingDrop();
        TrophyDrop();
        StarDrop();
        CloverChance();
        CrownChance();
        BookChance();
        GuitarDrop();
        TalarianDrop();
        RuneDrop();
        BackPackDrop();
        ShieldDrop();
        PillBottleDrop();
        MedalDrop();
        CookieDrop();
        PresentDrop();
        AxeDrop();
        Coin100XDrop();
        EnvelopeDrop();
        PotionDrop();
        SoulGemDrop();
        ScrollDrop();
        BrickDrop();
        ChickenDrop();
    }
    #endregion

    #region treasureChances
    public int skullTopChance, swordTopChance, ringTopChance, trophyTopChance,starTopChance,cloverTopChance,crownTopChance,bookTopChance,guitarTopChance,talarianTopChance, runeTopChance,backPackTopChance, shieldTopChance, pillBottleTopChance, medalTopChance, cookieTopChance,presentTopChance, axeTopChance, coin100XTopChance, envelopeTopChance, potionTopChance, soulGemTopChance, scrollTopChance, brickTopChance, chickenTopChance ;

    //Display percent variables
    public float skullDropChance, swordDropChance, ringDropChance, trophyDropChance, starDropChance, cloverDropChance, crownDropChance, bookDropChance, guitatDropChance, talatianDropChance, runeDropChance, backPackDropChance, shieldDropChance,pillBottleDropChance, medalDropChance, cookieDropChance, presentDropChance, axeDropChance, coin100XdropChance, envelopeDropChance, potionDropChance, soulGemDropChance, scrollDropChance, brickDropChance, chickenDropChance;

    public void RareTreasuresChances()
    {
        if(PlaceMobileButtons.isMobile == false)
        {
            skullChance = 5; skullTopChance = 18000;
            skullDropChance = (float)skullChance / skullTopChance * 100f;

            swordChance = 5; swordTopChance = 42000;
            swordDropChance = (float)swordChance / swordTopChance * 100f;

            ringChance = 5; ringTopChance = 99000;
            ringDropChance = (float)ringChance / ringTopChance * 100f;

            trophyChance = 5; trophyTopChance = 100000;
            trophyDropChance = (float)trophyChance / trophyTopChance * 100f;

            starChance = 5; starTopChance = 660000;
            starDropChance = (float)starChance / starTopChance * 100f;

            cloverChance = 5; cloverTopChance = 1110000;
            cloverDropChance = (float)cloverChance / cloverTopChance * 100f;

            crownChance = 5; crownTopChance = 780000;
            crownDropChance = (float)crownChance / crownTopChance * 100f;

            bookChance = 5; bookTopChance = 790000;
            bookDropChance = (float)bookChance / bookTopChance * 100f;

            guitarChance = 5; guitarTopChance = 570000;
            guitatDropChance = (float)guitarChance / guitarTopChance * 100f;

            talarianChance = 5; talarianTopChance = 650000;
            talatianDropChance = (float)talarianChance / talarianTopChance * 100f;

            runeChance = 5; runeTopChance = 320000;
            runeDropChance = (float)runeChance / runeTopChance * 100f;

            backPackChance = 5; backPackTopChance = 960000;
            backPackDropChance = (float)backPackChance / backPackTopChance * 100f;

            shieldChance = 5; shieldTopChance = 800000;
            shieldDropChance = (float)shieldChance / shieldTopChance * 100f;

            pillBottleChance = 5; pillBottleTopChance = 1000000;
            pillBottleDropChance = (float)pillBottleChance / pillBottleTopChance * 100f;

            medalChance = 5; medalTopChance = 1200000;
            medalDropChance = (float)medalChance / medalTopChance * 100f;

            cookieChance = 5; cookieTopChance = 1450000;
            cookieDropChance = (float)cookieChance / cookieTopChance * 100f;

            presentChance = 5; presentTopChance = 1300000;
            presentDropChance = (float)presentChance / presentTopChance * 100f;

            axeChance = 5; axeTopChance = 1570000;
            axeDropChance = (float)axeChance / axeTopChance * 100f;

            coin100XChance = 5; coin100XTopChance = 1650000;
            coin100XdropChance = (float)coin100XChance / coin100XTopChance * 100f;

            envelopeChance = 5; envelopeTopChance = 1400000;
            envelopeDropChance = (float)envelopeChance / envelopeTopChance * 100f;

            potionChance = 5; potionTopChance = 1690000;
            potionDropChance = (float)potionChance / potionTopChance * 100f;

            soulGemChance = 5; soulGemTopChance = 1460000;
            soulGemDropChance = (float)soulGemChance / soulGemTopChance * 100f;

            scrollChance = 5; scrollTopChance = 1710000;
            scrollDropChance = (float)scrollChance / scrollTopChance * 100f;

            brickChance = 5; brickTopChance = 1900000;
            brickDropChance = (float)brickChance / brickTopChance * 100f;

            chickenChance = 5; chickenTopChance = 2000000;
            chickenDropChance = (float)chickenChance / chickenTopChance * 100f;
        }

        if (PlaceMobileButtons.isMobile == true)
        {
            skullChance = 5; skullTopChance = 11000;
            skullDropChance = (float)skullChance / skullTopChance * 100f;

            swordChance = 5; swordTopChance = 20000;
            swordDropChance = (float)swordChance / swordTopChance * 100f;

            ringChance = 5; ringTopChance = 50000;
            ringDropChance = (float)ringChance / ringTopChance * 100f;

            trophyChance = 5; trophyTopChance = 60000;
            trophyDropChance = (float)trophyChance / trophyTopChance * 100f;

            starChance = 5; starTopChance = 210000;
            starDropChance = (float)starChance / starTopChance * 100f;

            cloverChance = 5; cloverTopChance = 650000;
            cloverDropChance = (float)cloverChance / cloverTopChance * 100f;

            crownChance = 5; crownTopChance = 500000;
            crownDropChance = (float)crownChance / crownTopChance * 100f;

            bookChance = 5; bookTopChance = 540000;
            bookDropChance = (float)bookChance / bookTopChance * 100f;

            guitarChance = 5; guitarTopChance = 400000;
            guitatDropChance = (float)guitarChance / guitarTopChance * 100f;

            talarianChance = 5; talarianTopChance = 500000;
            talatianDropChance = (float)talarianChance / talarianTopChance * 100f;

            runeChance = 5; runeTopChance = 200000;
            runeDropChance = (float)runeChance / runeTopChance * 100f;

            backPackChance = 5; backPackTopChance = 700000;
            backPackDropChance = (float)backPackChance / backPackTopChance * 100f;

            shieldChance = 5; shieldTopChance = 710000;
            shieldDropChance = (float)shieldChance / shieldTopChance * 100f;

            pillBottleChance = 5; pillBottleTopChance = 750000;
            pillBottleDropChance = (float)pillBottleChance / pillBottleTopChance * 100f;

            medalChance = 5; medalTopChance = 900000;
            medalDropChance = (float)medalChance / medalTopChance * 100f;

            cookieChance = 5; cookieTopChance = 980000;
            cookieDropChance = (float)cookieChance / cookieTopChance * 100f;

            presentChance = 5; presentTopChance = 1000000;
            presentDropChance = (float)presentChance / presentTopChance * 100f;

            axeChance = 5; axeTopChance = 1120000;
            axeDropChance = (float)axeChance / axeTopChance * 100f;

            coin100XChance = 5; coin100XTopChance = 1100000;
            coin100XdropChance = (float)coin100XChance / coin100XTopChance * 100f;

            envelopeChance = 5; envelopeTopChance = 1110000;
            envelopeDropChance = (float)envelopeChance / envelopeTopChance * 100f;

            potionChance = 5; potionTopChance = 1200000;
            potionDropChance = (float)potionChance / potionTopChance * 100f;

            soulGemChance = 5; soulGemTopChance = 1290000;
            soulGemDropChance = (float)soulGemChance / soulGemTopChance * 100f;

            scrollChance = 5; scrollTopChance = 1500000;
            scrollDropChance = (float)scrollChance / scrollTopChance * 100f;

            brickChance = 5; brickTopChance = 1400000;
            brickDropChance = (float)brickChance / brickTopChance * 100f;

            chickenChance = 5; chickenTopChance = 1800000;
            chickenDropChance = (float)chickenChance / chickenTopChance * 100f;
        }
    }
    #endregion

    #region SkullDrop
    public GameObject skull;
    public static int skullChance;

    public void SkullDrop()
    {
        int random = Random.Range(1, skullTopChance);
        if(RareTreasures.skullFound != 1)
        {
            if (random <= skullChance)
            {
                SetColor(skull);
                skull.SetActive(true);
                skull.transform.position = new Vector3(1, treasuresYPos, 0);

                skull.GetComponent<Rigidbody2D>().gravityScale = 1;
                skull.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));

                //StartCoroutine(MoveTowardsTarget(redGem.transform, targetTransform));
            }
        }
    }
    #endregion

    #region swordDrop
    public GameObject sword;
    public static int swordChance;

    public void SwordDrop()
    {
        if (RareTreasures.swordFound != 1)
        {
            int random = Random.Range(1, swordTopChance);

            if (random <= swordChance)
            {
                SetColor(sword);
                sword.SetActive(true);

                sword.transform.position = new Vector3(1, treasuresYPos, 0);

                sword.GetComponent<Rigidbody2D>().gravityScale = 1;
                sword.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));
            }
        }
        
    }
    #endregion

    #region ringDrop
    public GameObject ring;
    public static int ringChance;

    public void RingDrop()
    {
        if (RareTreasures.ringFound != 1)
        {
            int random = Random.Range(1, ringTopChance);

            if (random <= ringChance)
            {
                SetColor(ring);
                ring.SetActive(true);
                ring.transform.position = new Vector3(1, treasuresYPos, 0);

                ring.GetComponent<Rigidbody2D>().gravityScale = 1;
                ring.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));
            }
        }
    }
    #endregion

    #region trophyDrop
    public GameObject trophy;
    public static int trophyChance;

    public void TrophyDrop()
    {
        if (RareTreasures.trophyFound != 1)
        {
            int random = Random.Range(1, trophyTopChance);

            if (random <= trophyChance)
            {
                SetColor(trophy);
                trophy.SetActive(true);
                trophy.transform.position = new Vector3(1, treasuresYPos, 0);

                trophy.GetComponent<Rigidbody2D>().gravityScale = 1;
                trophy.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));
            }
        }
        
    }
    #endregion

    #region starDrop
    public GameObject star;
    public static int starChance;

    public void StarDrop()
    {
        int random = Random.Range(1, starTopChance);

        if (RareTreasures.starFound != 1)
        {
            if (random <= starChance)
            {
                SetColor(star);
                star.SetActive(true);
                star.transform.position = new Vector3(1, treasuresYPos, 0);

                star.GetComponent<Rigidbody2D>().gravityScale = 1;
                star.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));
            }
        }
    }
    #endregion

    #region cloverDrop
    public GameObject clover;
    public static int cloverChance;

    public void CloverChance()
    {
        int random = Random.Range(1, cloverTopChance);

        if (RareTreasures.cloverFound != 1)
        {
            if (random <= cloverChance)
            {
                SetColor(clover);
                clover.SetActive(true);
                clover.transform.position = new Vector3(1, treasuresYPos, 0);

                clover.GetComponent<Rigidbody2D>().gravityScale = 1;
                clover.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));
            }
        }
    }
    #endregion

    #region crownDrop
    public GameObject crown;
    public static int crownChance;

    public void CrownChance()
    {
        int random = Random.Range(1, crownTopChance);

        if (RareTreasures.crownFound != 1)
        {
            if (random <= crownChance)
            {
                SetColor(crown);
                crown.SetActive(true);
                crown.transform.position = new Vector3(1, treasuresYPos, 0);

                crown.GetComponent<Rigidbody2D>().gravityScale = 1;
                crown.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));
            }
        }
    }
    #endregion

    #region bookDrop
    public GameObject book;
    public static int bookChance;

    public void BookChance()
    {
        int random = Random.Range(1, bookTopChance);

        if (RareTreasures.bookFound != 1)
        {
            if (random <= bookChance)
            {
                SetColor(book);
                book.SetActive(true);
                book.transform.position = new Vector3(1, treasuresYPos, 0);

                book.GetComponent<Rigidbody2D>().gravityScale = 1;
                book.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));
            }
        }
    }
    #endregion

    #region guitarDrop
    public GameObject guitar;
    public static int guitarChance;

    public void GuitarDrop()
    {
        int random = Random.Range(1, guitarTopChance);

        if (RareTreasures.guitarFOund != 1)
        {
            if (random <= guitarChance)
            {
                SetColor(guitar);
                guitar.SetActive(true);
                guitar.transform.position = new Vector3(1, treasuresYPos, 0);

                guitar.GetComponent<Rigidbody2D>().gravityScale = 1;
                guitar.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));
            }
        }
    }
    #endregion

    #region talarianDrop
    public GameObject talarian;
    public static int talarianChance;

    public void TalarianDrop()
    {
        if (RareTreasures.talarianFound != 1)
        {
            int random = Random.Range(1, talarianTopChance);

            if (random <= talarianChance)
            {
                SetColor(talarian);
                talarian.SetActive(true);
                talarian.transform.position = new Vector3(1, treasuresYPos, 0);

                talarian.GetComponent<Rigidbody2D>().gravityScale = 1;
                talarian.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));
            }
        }
    }
    #endregion

    #region runeDrop
    public GameObject rune;
    public static int runeChance;

    public void RuneDrop()
    {
        int random = Random.Range(1, runeTopChance);

        if (RareTreasures.runeFound != 1)
        {
            if (random <= runeChance)
            {
                SetColor(rune);
                rune.SetActive(true);
                rune.transform.position = new Vector3(1, treasuresYPos, 0);

                rune.GetComponent<Rigidbody2D>().gravityScale = 1;
                rune.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));
            }
        }
       
    }
    #endregion

    #region backPackDrop
    public GameObject backPack;
    public static int backPackChance;

    public void BackPackDrop()
    {
        int random = Random.Range(1, backPackTopChance);

        if (RareTreasures.backPackFound != 1)
        {
            if (random <= backPackChance)
            {
                SetColor(backPack);
                backPack.SetActive(true);
                backPack.transform.position = new Vector3(1, treasuresYPos, 0);

                backPack.GetComponent<Rigidbody2D>().gravityScale = 1;
                backPack.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));
            }
        }
    }
    #endregion

    #region shieldDrop
    public GameObject shield;
    public static int shieldChance;

    public void ShieldDrop()
    {
        int random = Random.Range(1, shieldTopChance);

        if (RareTreasures.shieldFound != 1)
        {
            if (random <= shieldChance)
            {
                SetColor(shield);
                shield.SetActive(true);
                shield.transform.position = new Vector3(1, treasuresYPos, 0);

                shield.GetComponent<Rigidbody2D>().gravityScale = 1;
                shield.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));
            }
        }
    }
    #endregion

    #region pillBottleDrop
    public GameObject pillBottle;
    public static int pillBottleChance;

    public void PillBottleDrop()
    {
        int random = Random.Range(1, pillBottleTopChance);

        if (RareTreasures.pillBottleFound != 1)
        {
            if (random <= pillBottleChance)
            {
                SetColor(pillBottle);
                pillBottle.SetActive(true);
                pillBottle.transform.position = new Vector3(1, treasuresYPos, 0);

                pillBottle.GetComponent<Rigidbody2D>().gravityScale = 1;
                pillBottle.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));
            }
        }
    }
    #endregion

    #region medalDrop
    public GameObject medal;
    public static int medalChance;

    public void MedalDrop()
    {
        int random = Random.Range(1, medalTopChance);

        if (RareTreasures.medalFound != 1)
        {
            if (random <= medalChance)
            {
                SetColor(medal);
                medal.SetActive(true);
                medal.transform.position = new Vector3(1, treasuresYPos, 0);

                medal.GetComponent<Rigidbody2D>().gravityScale = 1;
                medal.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));
            }
        }
    }
    #endregion

    #region cookieDrop
    public GameObject cookie;
    public static int cookieChance;

    public void CookieDrop()
    {
        int random = Random.Range(1, cookieTopChance);

        if (RareTreasures.cookieFound != 1)
        {
            if (random <= cookieChance)
            {
                SetColor(cookie);
                cookie.SetActive(true);
                cookie.transform.position = new Vector3(1, treasuresYPos, 0);

                cookie.GetComponent<Rigidbody2D>().gravityScale = 1;
                cookie.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));
            }
        }
    }
    #endregion

    #region presentDrop
    public GameObject present;
    public static int presentChance;

    public void PresentDrop()
    {
        int random = Random.Range(1, presentTopChance);

        if (RareTreasures.presentFound != 1)
        {
            if (random <= presentChance)
            {
                SetColor(present);
                present.SetActive(true);
                present.transform.position = new Vector3(1, treasuresYPos, 0);

                present.GetComponent<Rigidbody2D>().gravityScale = 1;
                present.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));
            }
        }
    }
    #endregion

    #region axeDrop
    public GameObject axe;
    public static int axeChance;

    public void AxeDrop()
    {
        int random = Random.Range(1, axeTopChance);

        if (RareTreasures.axeFound != 1)
        {
            if (random <= axeChance)
            {
                SetColor(axe);
                axe.SetActive(true);
                axe.transform.position = new Vector3(1, treasuresYPos, 0);

                axe.GetComponent<Rigidbody2D>().gravityScale = 1;
                axe.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));
            }
        }
    }
    #endregion

    #region 100Drop
    public GameObject coin100X;
    public static int coin100XChance;

    public void Coin100XDrop()
    {
        int random = Random.Range(1, coin100XTopChance);

        if (RareTreasures.coin100XFound != 1)
        {
            if (random <= coin100XChance)
            {
                SetColor(coin100X);
                coin100X.SetActive(true);
                coin100X.transform.position = new Vector3(1, treasuresYPos, 0);

                coin100X.GetComponent<Rigidbody2D>().gravityScale = 1;
                coin100X.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));
            }
        }
    }
    #endregion

    #region envelopeDrop
    public GameObject envlope;
    public static int envelopeChance;

    public void EnvelopeDrop()
    {
        int random = Random.Range(1, envelopeTopChance);

        if (RareTreasures.envelopeFound != 1)
        {
            if (random <= envelopeChance)
            {
                SetColor(envlope);
                envlope.SetActive(true);
                envlope.transform.position = new Vector3(1, treasuresYPos, 0);

                envlope.GetComponent<Rigidbody2D>().gravityScale = 1;
                envlope.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));
            }
        }
    }
    #endregion

    #region potionDrop
    public GameObject potion;
    public static int potionChance;

    public void PotionDrop()
    {
        int random = Random.Range(1, potionTopChance);

        if (RareTreasures.potionFound != 1)
        {
            if (random <= potionChance)
            {
                SetColor(potion);
                potion.SetActive(true);
                potion.transform.position = new Vector3(1, treasuresYPos, 0);

                potion.GetComponent<Rigidbody2D>().gravityScale = 1;
                potion.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));
            }
        }
    }
    #endregion

    #region soulGemDrop
    public GameObject soulGem;
    public static int soulGemChance;

    public void SoulGemDrop()
    {
        int random = Random.Range(1, soulGemTopChance);

        if (RareTreasures.soulGemFound != 1)
        {
            if (random <= soulGemChance)
            {
                SetColor(soulGem);
                soulGem.SetActive(true);
                soulGem.transform.position = new Vector3(1, treasuresYPos, 0);

                soulGem.GetComponent<Rigidbody2D>().gravityScale = 1;
                soulGem.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));
            }
        }
    }
    #endregion

    #region scrollDrop
    public GameObject scroll;
    public static int scrollChance;

    public void ScrollDrop()
    {
        int random = Random.Range(1, scrollTopChance);

        if (RareTreasures.scrollFound != 1)
        {
            if (random <= scrollChance)
            {
                SetColor(scroll);
                scroll.SetActive(true);
                scroll.transform.position = new Vector3(1, treasuresYPos, 0);

                scroll.GetComponent<Rigidbody2D>().gravityScale = 1;
                scroll.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));
            }
        }
    }
    #endregion

    #region brickDrop
    public GameObject brick;
    public static int brickChance;

    public void BrickDrop()
    {
        int random = Random.Range(1, brickTopChance);

        if (RareTreasures.brickFound != 1)
        {
            if (random <= brickChance)
            {
                SetColor(brick);
                brick.SetActive(true);
                brick.transform.position = new Vector3(1, treasuresYPos, 0);

                brick.GetComponent<Rigidbody2D>().gravityScale = 1;
                brick.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));
            }
        }
    }
    #endregion

    #region chickenDrop
    public GameObject chicken;
    public static int chickenChance;

    public void ChickenDrop()
    {
        int random = Random.Range(1, chickenTopChance);

        if (RareTreasures.chickenFound != 1)
        {
            if (random <= chickenChance)
            {
                SetColor(chicken);
                chicken.SetActive(true);
                chicken.transform.position = new Vector3(1, treasuresYPos, 0);

                chicken.GetComponent<Rigidbody2D>().gravityScale = 1;
                chicken.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));
            }
        }
    }
    #endregion

    public void SetColor(GameObject treasure)
    {
        treasure.GetComponent<Rigidbody2D>().gravityScale = 1;
        treasure.GetComponent<Button>().interactable = true;
        Color newColor = treasure.GetComponent<Image>().color; newColor.a = 1f;
        treasure.GetComponent<Image>().color = newColor;
        treasure.GetComponent<Image>().raycastTarget = true;
        treasure.GetComponent<Collider2D>().enabled = true;
    }

    //Mini Chest
    #region miniChest
    public GameObject miniChest;

    #endregion

    //TreasureBag
    #region treasureBag

    public static int maxTreasuresBags;

    public void TreasureBagDropChance()
    {

        if(SpecialUpgradesButtons.treasureBagBoughtFirstTime == 1)
        {
            float random = Random.Range(0, 100f);

            if (random < SpecialUpgradesButtons.treasureBagDropChance)
            {
                if(maxTreasuresBags < 51)
                {
                    maxTreasuresBags += 1;
                    gemOnScreenCount += 1;
                    GameObject bag = ObjectPooling.instance.GetTreasureBagFromPool();
                    float randomPos = Random.Range(-0.5f, 0.5f);
                    bag.transform.position = new Vector3(randomPos, ySpawnPos, 0);
                    Transform targetTransform = itemCollecteBar.transform;

                    bag.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));
                }
            }
        }
    }

    public async void TreasureBagDrop()
    {
            gemOnScreenCount += 1;
            GameObject bag = ObjectPooling.instance.GetTreasureBagFromPool();
            float randomPos = Random.Range(-1.5f, 1.5f);
            bag.transform.position = new Vector3(randomPos, ySpawnPos, 0);
            Transform targetTransform = itemCollecteBar.transform;

            bag.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));

        await Task.Delay(50);
        UseConsumable.treasureSpawnCount = 0;
        UseConsumable.spawnTreasureBag = false;
    }
    #endregion

    //Items

    #region allItemsDrops

    public void AllItemsDropChance()
    {
        LockPickDropChance();
        HammerDropChance();
        KeyDropChance();
        GoldenTouchDropChance();
        LootPotionChance();
        DamagePotionChance();
        XPPotionChance();
        ScrollChance();
        GauntletChance();
        ElixirChance();
        RelicChance();
        TreasurePotionChance();
        KnifeChance();
    }

    #endregion

    #region lockPick
    public void LockPickDropChance()
    {
        float random = Random.Range(0f, 100f);
        if(SpecialUpgradesButtons.lockPickBoughtFirstTime == 1)
        {
            if (random < SpecialUpgradesButtons.lockPickDropChance)
            {
                gemOnScreenCount += 1;
                GameObject lockPick = ObjectPooling.instance.GetLockPickFromPool();
                float randomPos = Random.Range(-0.5f, 0.5f);
                lockPick.transform.position = new Vector3(randomPos, ySpawnPos, 0);
                Transform targetTransform = itemCollecteBar.transform;
            }
        }
    }
    #endregion

    #region hammer
    public void HammerDropChance()
    {
        if(SpecialUpgradesButtons.hammerBoughtFirstTime == 1) 
        {
            float random = Random.Range(0f, 100f);
            if (random < SpecialUpgradesButtons.hammerDropChance)
            {
                gemOnScreenCount += 1;
                GameObject hammer = ObjectPooling.instance.GetHammerFromPool();
                float randomPos = Random.Range(-0.5f, 0.5f);
                hammer.transform.position = new Vector3(randomPos, ySpawnPos, 0);
                Transform targetTransform = itemCollecteBar.transform;
            }
        }
    }
    #endregion

    #region key
    public void KeyDropChance()
    {
        if(SpecialUpgradesButtons.keyBoughtFirstTime == 1)
        {
            float random = Random.Range(0f, 100f);
            if (random < SpecialUpgradesButtons.keyDropChance)
            {
                gemOnScreenCount += 1;
                GameObject key = ObjectPooling.instance.GetKeyFromPool();
                float randomPos = Random.Range(-0.5f, 0.5f);
                key.transform.position = new Vector3(randomPos, ySpawnPos, 0);
                Transform targetTransform = itemCollecteBar.transform;
            }
        }
    }
    #endregion

    #region goldentouch
    public void GoldenTouchDropChance()
    {
        if (SpecialUpgradesButtons.goldenTouchBoughtFirstTime == 1)
        {
            float random = Random.Range(0f, 100f);
            if (random < SpecialUpgradesButtons.goldenTouchDropChance)
            {
                gemOnScreenCount += 1;
                GameObject goldenTouch = ObjectPooling.instance.GetGoldeTouchFromPool();
                float randomPos = Random.Range(-0.5f, 0.5f);
                goldenTouch.transform.position = new Vector3(randomPos, ySpawnPos, 0);
                Transform targetTransform = itemCollecteBar.transform;
            }
        }
       
    }
    #endregion

    #region lootPotion
    public void LootPotionChance()
    {
        if (SpecialUpgradesButtons.lootPotionBoughtFirstTime == 1)
        {
            float random = Random.Range(0f, 100f);
            if (random < SpecialUpgradesButtons.lootPotionDropChance)
            {
                gemOnScreenCount += 1;
                GameObject lootPotion = ObjectPooling.instance.GetLootPotionFromPool();
                float randomPos = Random.Range(-0.5f, 0.5f);
                lootPotion.transform.position = new Vector3(randomPos, ySpawnPos, 0);
                Transform targetTransform = itemCollecteBar.transform;
            }
        }

    }
    #endregion

    #region damagePotion
    public void DamagePotionChance()
    {
        if (SpecialUpgradesButtons.damagePotionBoughtFirstTime == 1)
        {
            float random = Random.Range(0f, 100f);
            if (random < SpecialUpgradesButtons.damagePotionDropChance)
            {
                gemOnScreenCount += 1;
                GameObject damagePotion = ObjectPooling.instance.GetDamagePotionFromPool();
                float randomPos = Random.Range(-0.5f, 0.5f);
                damagePotion.transform.position = new Vector3(randomPos, ySpawnPos, 0);
                Transform targetTransform = itemCollecteBar.transform;
            }
        }
    }
    #endregion

    #region XPPotion
    public void XPPotionChance()
    {
        if (SpecialUpgradesButtons.XPPotionBoughtFirstTime == 1)
        {
            float random = Random.Range(0f, 100f);
            if (random < SpecialUpgradesButtons.XPPotionDropChance)
            {
                gemOnScreenCount += 1;
                GameObject xpPotion = ObjectPooling.instance.GetXPPotionFromPool();
                float randomPos = Random.Range(-0.5f, 0.5f);
                xpPotion.transform.position = new Vector3(randomPos, ySpawnPos, 0);
                Transform targetTransform = itemCollecteBar.transform;
            }
        }
    }
    #endregion

    #region scroll
    public void ScrollChance()
    {
        if (SpecialUpgradesButtons.scrollBoughtFirstTime == 1)
        {
            float random = Random.Range(0f, 100f);
            if (random < SpecialUpgradesButtons.scrollDropChance)
            {
                gemOnScreenCount += 1;
                GameObject scroll = ObjectPooling.instance.GetScrollFromPool();
                float randomPos = Random.Range(-0.5f, 0.5f);
                scroll.transform.position = new Vector3(randomPos, ySpawnPos, 0);
                Transform targetTransform = itemCollecteBar.transform;
            }
        }
    }
    #endregion

    #region gauntlet
    public void GauntletChance()
    {
        if (SpecialUpgradesButtons.gauntletBoughtFirstTime == 1)
        {
            float random = Random.Range(0f, 100f);
            if (random < SpecialUpgradesButtons.gauntletDropChance)
            {
                gemOnScreenCount += 1;
                GameObject gauntlet = ObjectPooling.instance.GetGauntletFromPool();
                float randomPos = Random.Range(-0.5f, 0.5f);
                gauntlet.transform.position = new Vector3(randomPos, ySpawnPos, 0);
                Transform targetTransform = itemCollecteBar.transform;
            }
        }
    }
    #endregion

    #region elixir
    public void ElixirChance()
    {
        if (SpecialUpgradesButtons.elixirBoughtFirstTime == 1)
        {
            float random = Random.Range(0f, 100f);
            if (random < SpecialUpgradesButtons.elixirDropChance)
            {
                gemOnScreenCount += 1;
                GameObject elixir = ObjectPooling.instance.GetElixirFromPool();
                float randomPos = Random.Range(-0.5f, 0.5f);
                elixir.transform.position = new Vector3(randomPos, ySpawnPos, 0);
                Transform targetTransform = itemCollecteBar.transform;
            }
        }
    }
    #endregion

    #region relic
    public void RelicChance()
    {
        if (SpecialUpgradesButtons.relicBoughtFirstTime == 1)
        {
            float random = Random.Range(0f, 100f);
            if (random < SpecialUpgradesButtons.relicDropChance)
            {
                gemOnScreenCount += 1;
                GameObject relic = ObjectPooling.instance.GetRelicFromPool();
                float randomPos = Random.Range(-0.5f, 0.5f);
                relic.transform.position = new Vector3(randomPos, ySpawnPos, 0);
                Transform targetTransform = itemCollecteBar.transform;
            }
        }
    }
    #endregion

    #region treasurePotion
    public void TreasurePotionChance()
    {
        if (UpdateGame.treasurePotionBoughtFirstTime == 1)
        {
            float random = Random.Range(0f, 100f);
            if (random < UpdateGame.treasurePotionDropChance)
            {
                gemOnScreenCount += 1;
                GameObject treasurePotion = ObjectPooling.instance.GetTreasurePotionFromPool();
                float randomPos = Random.Range(-0.5f, 0.5f);
                treasurePotion.transform.position = new Vector3(randomPos, ySpawnPos, 0);
                Transform targetTransform = itemCollecteBar.transform;
            }
        }
    }
    #endregion

    #region knife
    public void KnifeChance()
    {
        if (UpdateGame.knifeBoughtFirstTime == 1)
        {
            float random = Random.Range(0f, 100f);
            if (random < UpdateGame.knifeDropChance)
            {
                gemOnScreenCount += 1;
                GameObject knife = ObjectPooling.instance.GetKnifeFromPool();
                float randomPos = Random.Range(-0.5f, 0.5f);
                knife.transform.position = new Vector3(randomPos, ySpawnPos, 0);
                Transform targetTransform = itemCollecteBar.transform;
            }
        }
    }
    #endregion

    public GameObject prestigeButtonRed, prestigeButtonGreen;
    public GameObject prestigeKeyFoundd, prestigeKeyNotFound, prestigeChestFoundd, prestigeChestNotFound;
    public TextMeshProUGUI findTheChestAndKeyText;
    public GameObject prestigeExl;

    #region prestigeKey
    public GameObject prestigeKey;
    public GameObject prestigeKeyIcon;
    public GameObject treasuresBar;
    public TextMeshProUGUI treasureText;
    public static int prestigeKeyFound;
    public void PrestigeKeyDrop()
    {
        float random = Random.Range(0f, 100f);
      
        if(prestigeKeyFound != 1)
        {
            if (random <= (0.017 * (UnlockChests.timesPurchasedChests + 1)))
            {
                prestigeKey.SetActive(true);
                prestigeKey.transform.position = new Vector3(1, treasuresYPos, 0);

                prestigeKey.GetComponent<Rigidbody2D>().gravityScale = 1;
                prestigeKey.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));

                
            }
        }
    }
   

    public void ClickPrestigeKey()
    {
        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("PrestigeKeyAndChestSound"); }
        StartCoroutine(PrestigeAnim());
    }

    IEnumerator PrestigeAnim()
    {
        prestigeKey.SetActive(false);
        prestigeKeyIcon.SetActive(true); treasuresBar.SetActive(true);
        treasureText.text = Localization.youFoundPrestigeKey;

        if (PlaceMobileButtons.isMobile == false) { prestigeKeyIcon.GetComponent<Animation>().Play("prestigeKeyAnim"); }
        else { prestigeKeyIcon.GetComponent<Animation>().Play("PrestigeKeyMobile"); }
        
        yield return new WaitForSeconds(2.2f);
        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("PrestigeAnimSound"); }
        treasuresBar.SetActive(false);

        yield return new WaitForSeconds(0.5f);
        prestigeExl.SetActive(true);

        prestigeKeyIcon.SetActive(false);
        prestigeKeyFound = 1;
        prestigeKeyFoundd.SetActive(true);
        prestigeKeyNotFound.SetActive(false);

        if (prestigeKeyFound == 1 && prestigeChestFound == 1) { prestigeButtonRed.SetActive(false); prestigeButtonGreen.SetActive(true);
            findTheChestAndKeyText.text =Localization.youFoundThePrestigeKetAndChest;
            findTheChestAndKeyText.color = Color.green;
        }
    }
    #endregion

    #region prestigeChest
    public GameObject prestigeChest;
    public GameObject prestigeChestIcon;
    public static int prestigeChestFound;
    public void PrestigeChestDrop()
    {
        float random = Random.Range(0f, 100f);

        if (prestigeChestFound != 1)
        {
            if (random <= (0.017 * (UnlockChests.timesPurchasedChests +1)))
            {
                prestigeChest.SetActive(true);
                prestigeChest.transform.position = new Vector3(1, treasuresYPos, 0);

                prestigeChest.GetComponent<Rigidbody2D>().gravityScale = 1;
                prestigeChest.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));
            }
        }

    }


    public void ClickPrestigeChest()
    {
        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("PrestigeKeyAndChestSound"); }
        StartCoroutine(PrestigeChestAnim());
    }

    IEnumerator PrestigeChestAnim()
    {
        prestigeChest.SetActive(false);
        prestigeChestIcon.SetActive(true); treasuresBar.SetActive(true);
        treasureText.text = Localization.youFoundPrestigeChest;

        if (PlaceMobileButtons.isMobile == false) { prestigeChestIcon.GetComponent<Animation>().Play("prestigeKeyAnim"); }
        else { prestigeChestIcon.GetComponent<Animation>().Play("PrestigeChestMobile"); }
        
        yield return new WaitForSeconds(2.2f);
        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("PrestigeAnimSound"); }
        treasuresBar.SetActive(false);

        yield return new WaitForSeconds(0.5f);
        prestigeExl.SetActive(true);

        prestigeChestIcon.SetActive(false);
        prestigeChestFound = 1;
        prestigeChestFoundd.SetActive(true); prestigeChestNotFound.SetActive(false);
       

        if (prestigeKeyFound == 1 && prestigeChestFound == 1) { prestigeButtonRed.SetActive(false); prestigeButtonGreen.SetActive(true);
            findTheChestAndKeyText.text = Localization.youFoundThePrestigeKetAndChest;
            findTheChestAndKeyText.color = Color.green;

        }
    }
    #endregion

    /*public void SaveTreasureDropChance()
    {
        SaveSystem.SaveTreasureDropChance(this);
    }*/
}
