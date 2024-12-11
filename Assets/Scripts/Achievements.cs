using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Achievements : MonoBehaviour, IDataPersistence
{
    public static int[] achSaves = new int[92];
    public GameObject goldCoinAch1, goldCoinAch2, goldCoinAch3, goldCoinAch4, goldCoin2Million;
    public GameObject goldAmountAch1, goldAmountAch2, goldAmountAch3, goldAmountAch4, goldAmountAch5, goldAmountAch6, goldAmountAch7, goldAmountAch8, goldAmountAch9, goldAmountAch10, goldAmountAch11, goldAmountAch12, goldAmountAch13, goldUndecillion, goldDuodecillion, goldTredecillion, goldQuattuordecillion, goldQuindecillion, goldSexdecillion, goldSeptendecillion, goldOctodecillion, goldVingintillion;
    public GameObject goldCoin5X1, goldCoin5X2, goldCoin5X3, goldCoin5X250K, goldCoin10X1, goldCoin10X2, goldCoin10X3, goldCoin25X;
    public GameObject clickSpawn1, clickSpawn2, clickSpawn3;
    public GameObject treasure1, treasure2, treasure3, treasure4, treasure5, treasure100K;
    public GameObject common100, uncommon100, rare100, veryRare100, extremelyRare100, legendary100, ultra100, mythic100, eternal100;
    public GameObject treasureClick1, treasureClick2, treasureClick3, treasuresDoubled;
    public GameObject rareTreasure1, rareTreasure2, rareTreasure3, rareTreasure4, rareTreasure5, findCookie, clickCookie;
    public GameObject prestige1, prestige2, prestige3;
    public GameObject purchasePrestigeUpgrade1, purchasePrestigeUpgrade2, purchasePrestigeUpgrade3, purchasePrestigeUpgrade4, purchasePrestigeUpgrade5;
    public GameObject allClicker, allLounger, allPirate, allHoarder, allAdventurer;
    public GameObject purchaseLoot, purchaseGolden, purchaseScroll, purchaseKey, purchaseElixir, purchaseRelic, purchaseEnchantedHammer;
    public GameObject openChests1, openChests2, openChests3, openChests4, openChests5, openChests6;
    public GameObject purchaseChest2, purchaseChest5, purchaseChest8, purchaseChest12, purchaseChest15, purchaseChest20, purchaseChest24, purchaseChest27, purchaseChest32, purchaseChest37, openFinalChest;
    public GameObject openReinforcedChest1, openReinforcedChest2, openReinforcedChest3, openReinforcedChest4, reinforcedChests2500;
    public GameObject enchantedGoldenChest100, bossChest100;
    public GameObject skillPoints1, skillPoints2, skillPoints3, skillPoints4, skillPoints5, skillPoints20K;
    public GameObject level10, level25, level50, level100, level150, level200;
    public GameObject goldCoin100X, useChicken;

    public static int newAch1Novemdecillion, newAch100EnchantedChest, newAch100BossChest, newAchLevel200, newAchAllAdventurer, newAchEnchantedHammer, newAchPurchaseChest32, newAch25XGoldCoin1000;

    public static int newAch100XGoldCoin, newAch1Undecillion, newAch1Duodecillion, newAch1Tredecillion, newAch1Quattuordecillion, newAch1Quindecillion, newAch1Sexdecillion, newAch1Septendecillion, newAch1Octodecillion, newAchLevel150, newAch20KSkillPoints, newAch2MillionGoldCoins, newAch100KTreasures, newAch100Ultra, newAch100Mythic, newAch100Eternal, newAch2500Reinforced, newAchUseChicken, newAchChest37, newAch5X250KDrop;

    void Start()
    {
        StartCoroutine(wait());
    }

   IEnumerator wait()
    {
        yield return new WaitForSeconds(0.5f);

        string path = Application.persistentDataPath + "/player.saveACH";

        if (File.Exists(path))
        {
            //Load Auto Damage
            if (SaveAndLoad.onlyLoadNewSave == false)
            {
                GameData data = SaveSystem.LoadACH();
                achSaves[0] = data.achSaves[0];
                achSaves[1] = data.achSaves[1];
                achSaves[2] = data.achSaves[2];
                achSaves[3] = data.achSaves[3];
                achSaves[4] = data.achSaves[4];
                achSaves[5] = data.achSaves[5];
                achSaves[6] = data.achSaves[6];
                achSaves[7] = data.achSaves[7];
                achSaves[8] = data.achSaves[8];
                achSaves[9] = data.achSaves[9];
                achSaves[10] = data.achSaves[10];
                achSaves[11] = data.achSaves[11];
                achSaves[12] = data.achSaves[12];
                achSaves[13] = data.achSaves[13];
                achSaves[14] = data.achSaves[14];
                achSaves[15] = data.achSaves[15];
                achSaves[16] = data.achSaves[16];
                achSaves[17] = data.achSaves[17];
                achSaves[18] = data.achSaves[18];
                achSaves[19] = data.achSaves[19];
                achSaves[20] = data.achSaves[20];
                achSaves[21] = data.achSaves[21];
                achSaves[22] = data.achSaves[22];
                achSaves[23] = data.achSaves[23];
                achSaves[24] = data.achSaves[24];
                achSaves[25] = data.achSaves[25];
                achSaves[26] = data.achSaves[26];
                achSaves[27] = data.achSaves[27];
                achSaves[28] = data.achSaves[28];
                achSaves[29] = data.achSaves[29];
                achSaves[30] = data.achSaves[30];
                achSaves[31] = data.achSaves[31];
                achSaves[32] = data.achSaves[32];
                achSaves[33] = data.achSaves[33];
                achSaves[34] = data.achSaves[34];
                achSaves[35] = data.achSaves[35];
                achSaves[36] = data.achSaves[36];
                achSaves[37] = data.achSaves[37];
                achSaves[38] = data.achSaves[38];
                achSaves[39] = data.achSaves[39];
                achSaves[40] = data.achSaves[40];
                achSaves[41] = data.achSaves[41];
                achSaves[42] = data.achSaves[42];
                achSaves[43] = data.achSaves[43];
                achSaves[44] = data.achSaves[44];
                achSaves[45] = data.achSaves[45];
                achSaves[46] = data.achSaves[46];
                achSaves[47] = data.achSaves[47];
                achSaves[48] = data.achSaves[48];
                achSaves[49] = data.achSaves[49];
                achSaves[50] = data.achSaves[50];
                achSaves[51] = data.achSaves[51];
                achSaves[52] = data.achSaves[52];
                achSaves[53] = data.achSaves[53];
                achSaves[54] = data.achSaves[54];
                achSaves[55] = data.achSaves[55];
                achSaves[56] = data.achSaves[56];
                achSaves[57] = data.achSaves[57];
                achSaves[58] = data.achSaves[58];
                achSaves[59] = data.achSaves[59];
                achSaves[60] = data.achSaves[60];
                achSaves[61] = data.achSaves[61];
                achSaves[62] = data.achSaves[62];
                achSaves[63] = data.achSaves[63];
                achSaves[64] = data.achSaves[64];
                achSaves[65] = data.achSaves[65];
                achSaves[66] = data.achSaves[66];
                achSaves[67] = data.achSaves[67];
                achSaves[68] = data.achSaves[68];
                achSaves[69] = data.achSaves[69];
                achSaves[70] = data.achSaves[70];
                achSaves[71] = data.achSaves[71];
                achSaves[72] = data.achSaves[72];
                achSaves[73] = data.achSaves[73];
                achSaves[74] = data.achSaves[74];
                achSaves[75] = data.achSaves[75];
                achSaves[76] = data.achSaves[76];
                achSaves[77] = data.achSaves[77];
                achSaves[78] = data.achSaves[78];
                achSaves[79] = data.achSaves[79];
                achSaves[80] = data.achSaves[80];
                achSaves[81] = data.achSaves[81];
                achSaves[82] = data.achSaves[82];
                achSaves[83] = data.achSaves[83];
                achSaves[84] = data.achSaves[84];
                achSaves[85] = data.achSaves[85];
                achSaves[86] = data.achSaves[86];
                achSaves[87] = data.achSaves[87];
                achSaves[88] = data.achSaves[88];
                achSaves[89] = data.achSaves[89];
                achSaves[90] = data.achSaves[90];
                achSaves[91] = data.achSaves[91];
            }
            else { }
        }
        else
        {
            //Do nothing
        }


        if (achSaves[0] == 1) { goldCoinAch1.SetActive(true); CheckAchTrigger("goldCoin25"); }
        if (achSaves[1] == 1) { goldCoinAch2.SetActive(true); CheckAchTrigger("goldCoin1000"); }
        if (achSaves[2] == 1) { goldCoinAch3.SetActive(true); CheckAchTrigger("goldCoin100000"); }
        if (achSaves[3] == 1) { goldCoinAch4.SetActive(true); CheckAchTrigger("goldCoin1Million"); }
        if (achSaves[4] == 1) { goldAmountAch1.SetActive(true); CheckAchTrigger("gold100"); }
        if (achSaves[5] == 1) { goldAmountAch2.SetActive(true); CheckAchTrigger("gold100000"); }
        if (achSaves[6] == 1) { goldAmountAch3.SetActive(true); CheckAchTrigger("gold1Million"); }
        if (achSaves[7] == 1) { goldAmountAch4.SetActive(true); CheckAchTrigger("gold1Billion"); }
        if (achSaves[8] == 1) { goldAmountAch5.SetActive(true); CheckAchTrigger("gold1Trillion"); }
        if (achSaves[9] == 1) { goldAmountAch6.SetActive(true); CheckAchTrigger("gold1Quadrillion"); }
        if (achSaves[10] == 1) { goldAmountAch7.SetActive(true); CheckAchTrigger("gold1Quintillion"); }
        if (achSaves[11] == 1) { goldAmountAch8.SetActive(true); CheckAchTrigger("gold1Sextillion"); }
        if (achSaves[12] == 1) { goldAmountAch9.SetActive(true); CheckAchTrigger("gold1Septillion"); }
        if (achSaves[13] == 1) { goldAmountAch10.SetActive(true); CheckAchTrigger("gold1Octillion"); }
        if (achSaves[14] == 1) { goldAmountAch11.SetActive(true); CheckAchTrigger("gold1Nonillion"); }
        if (achSaves[15] == 1) { goldAmountAch12.SetActive(true); CheckAchTrigger("gold1Decillion"); }
        if (achSaves[16] == 1) { goldCoin5X1.SetActive(true); CheckAchTrigger("goldCoin5X1"); }
        if (achSaves[17] == 1) { goldCoin5X2.SetActive(true); CheckAchTrigger("goldCoin5X1000"); }
        if (achSaves[18] == 1) { goldCoin5X3.SetActive(true); CheckAchTrigger("goldCoin5X50000"); }
        if (achSaves[19] == 1) { goldCoin10X1.SetActive(true); CheckAchTrigger("goldCoin10X1"); }
        if (achSaves[20] == 1) { goldCoin10X2.SetActive(true); CheckAchTrigger("goldCoin10X1000"); }
        if (achSaves[21] == 1) { goldCoin10X3.SetActive(true); CheckAchTrigger("goldCoin10X25000"); }
        if (achSaves[22] == 1) { clickSpawn1.SetActive(true); CheckAchTrigger("coinClicks10"); }
        if (achSaves[23] == 1) { clickSpawn2.SetActive(true); CheckAchTrigger("coinClicks100"); }
        if (achSaves[24] == 1) { clickSpawn3.SetActive(true); CheckAchTrigger("coinClicks1000"); }
        if (achSaves[25] == 1) { treasure1.SetActive(true); CheckAchTrigger("treasure1"); }
        if (achSaves[26] == 1) { treasure2.SetActive(true); CheckAchTrigger("treasure100"); }
        if (achSaves[27] == 1) { treasure3.SetActive(true); CheckAchTrigger("treasure1000"); }
        if (achSaves[28] == 1) { treasure4.SetActive(true); CheckAchTrigger("treasure10000"); }
        if (achSaves[29] == 1) { treasure5.SetActive(true); CheckAchTrigger("treasure50000"); }
        if (achSaves[30] == 1) { common100.SetActive(true); CheckAchTrigger("common100"); }
        if (achSaves[31] == 1) { uncommon100.SetActive(true); CheckAchTrigger("uncommon100"); }
        if (achSaves[32] == 1) { rare100.SetActive(true); CheckAchTrigger("rare100"); }
        if (achSaves[33] == 1) { veryRare100.SetActive(true); CheckAchTrigger("veryRare100"); }
        if (achSaves[34] == 1) { extremelyRare100.SetActive(true); CheckAchTrigger("extremelyRare100"); }
        if (achSaves[35] == 1) { legendary100.SetActive(true); CheckAchTrigger("legendary100"); }
        if (achSaves[36] == 1) { treasureClick1.SetActive(true); CheckAchTrigger("treasureClicks10"); }
        if (achSaves[37] == 1) { treasureClick2.SetActive(true); CheckAchTrigger("treasureClicks100"); }
        if (achSaves[38] == 1) { treasureClick3.SetActive(true); CheckAchTrigger("treasureClicks1000"); }
        if (achSaves[39] == 1) { treasuresDoubled.SetActive(true); CheckAchTrigger("treasureDouble100"); }
        if (achSaves[40] == 1) { rareTreasure1.SetActive(true); CheckAchTrigger("RareTresure1"); }
        if (achSaves[41] == 1) { rareTreasure2.SetActive(true); CheckAchTrigger("RareTresure3"); }
        if (achSaves[42] == 1) { rareTreasure3.SetActive(true); CheckAchTrigger("RareTresure5"); }
        if (achSaves[43] == 1) { rareTreasure4.SetActive(true); CheckAchTrigger("RareTresure13"); }
        if (achSaves[44] == 1) { rareTreasure5.SetActive(true); CheckAchTrigger("RareTresure21"); }
        if (achSaves[45] == 1) { findCookie.SetActive(true); CheckAchTrigger("FindCookie"); }
        if (achSaves[46] == 1) { clickCookie.SetActive(true); CheckAchTrigger("ClickCookie"); }
        if (achSaves[47] == 1) { prestige1.SetActive(true); CheckAchTrigger("Prestige"); }
        if (achSaves[48] == 1) { prestige2.SetActive(true); CheckAchTrigger("Prestige5"); }
        if (achSaves[49] == 1) { prestige3.SetActive(true); CheckAchTrigger("Prestige10"); }
        if (achSaves[50] == 1) { purchasePrestigeUpgrade1.SetActive(true); CheckAchTrigger("PrestigeUpgrades5"); }
        if (achSaves[51] == 1) { purchasePrestigeUpgrade2.SetActive(true); CheckAchTrigger("PrestigeUpgrades15"); }
        if (achSaves[52] == 1) { purchasePrestigeUpgrade3.SetActive(true); CheckAchTrigger("PrestigeUpgrades25"); }
        if (achSaves[53] == 1) { purchasePrestigeUpgrade4.SetActive(true); CheckAchTrigger("PrestigeUpgrades40"); }
        if (achSaves[54] == 1) { purchasePrestigeUpgrade5.SetActive(true); CheckAchTrigger("AllPrestigeUpgrades"); }
        if (achSaves[55] == 1) { allClicker.SetActive(true); CheckAchTrigger("PurchaseClicker"); }
        if (achSaves[56] == 1) { allLounger.SetActive(true); CheckAchTrigger("PurchaseLounger"); }
        if (achSaves[57] == 1) { allPirate.SetActive(true); CheckAchTrigger("PurchasePirate"); }
        if (achSaves[58] == 1) { allHoarder.SetActive(true); CheckAchTrigger("PurchaseHoarder"); }
        if (achSaves[59] == 1) { purchaseLoot.SetActive(true); CheckAchTrigger("PurchaseLootPotion"); }
        if (achSaves[60] == 1) { purchaseGolden.SetActive(true); CheckAchTrigger("PurchaseGoldeTouch"); }
        if (achSaves[61] == 1) { purchaseScroll.SetActive(true); CheckAchTrigger("PurchaseScroll"); }
        if (achSaves[62] == 1) { purchaseKey.SetActive(true); CheckAchTrigger("PurchaseKey"); }
        if (achSaves[63] == 1) { purchaseElixir.SetActive(true); CheckAchTrigger("PurchaseElixir"); }
        if (achSaves[64] == 1) { purchaseRelic.SetActive(true); CheckAchTrigger("PurchaseRelic"); }
        if (achSaves[65] == 1) { openChests1.SetActive(true); CheckAchTrigger("Open1Chest"); }
        if (achSaves[66] == 1) { openChests2.SetActive(true); CheckAchTrigger("Open100Chests"); }
        if (achSaves[67] == 1) { openChests3.SetActive(true); CheckAchTrigger("Open1000Chests"); }
        if (achSaves[68] == 1) { openChests4.SetActive(true); CheckAchTrigger("Open10000Chests"); }
        if (achSaves[69] == 1) { openChests5.SetActive(true); CheckAchTrigger("Open100000Chests"); }
        if (achSaves[70] == 1) { openChests6.SetActive(true); CheckAchTrigger("Open250000Chests"); }
        if (achSaves[71] == 1) { purchaseChest2.SetActive(true); CheckAchTrigger("PurchaseChest2"); }
        if (achSaves[72] == 1) { purchaseChest5.SetActive(true); CheckAchTrigger("PurchaseChest5"); }
        if (achSaves[73] == 1) { purchaseChest8.SetActive(true); CheckAchTrigger("PurchaseChest8"); }
        if (achSaves[74] == 1) { purchaseChest12.SetActive(true); CheckAchTrigger("PurchaseChest12"); }
        if (achSaves[75] == 1) { purchaseChest15.SetActive(true); CheckAchTrigger("PurchaseChest15"); }
        if (achSaves[76] == 1) { purchaseChest20.SetActive(true); CheckAchTrigger("PurchaseChest20"); }
        if (achSaves[77] == 1) { purchaseChest24.SetActive(true); CheckAchTrigger("PurchaseChest24"); }
        if (achSaves[78] == 1) { purchaseChest27.SetActive(true); CheckAchTrigger("PurchaseChestFINAL"); }
        if (achSaves[79] == 1) { openFinalChest.SetActive(true); CheckAchTrigger("OpenLastChest"); }
        if (achSaves[80] == 1) { openReinforcedChest1.SetActive(true); CheckAchTrigger("Open1Reinforced"); }
        if (achSaves[81] == 1) { openReinforcedChest2.SetActive(true); CheckAchTrigger("Open100Reinforced"); }
        if (achSaves[82] == 1) { openReinforcedChest3.SetActive(true); CheckAchTrigger("Open1000Reinforced"); }
        if (achSaves[83] == 1) { openReinforcedChest4.SetActive(true); CheckAchTrigger("Open10000Reinfoced"); }
        if (achSaves[84] == 1) { skillPoints1.SetActive(true); CheckAchTrigger("SkillPoints50"); }
        if (achSaves[85] == 1) { skillPoints2.SetActive(true); CheckAchTrigger("SkillPoints500"); }
        if (achSaves[86] == 1) { skillPoints3.SetActive(true); CheckAchTrigger("SkillPoints1000"); }
        if (achSaves[87] == 1) { skillPoints4.SetActive(true); CheckAchTrigger("SkillPoints10000"); }
        if (achSaves[88] == 1) { level10.SetActive(true); CheckAchTrigger("level10"); }
        if (achSaves[89] == 1) { level25.SetActive(true); CheckAchTrigger("level25"); }
        if (achSaves[90] == 1) { level50.SetActive(true); CheckAchTrigger("level50"); }
        if (achSaves[91] == 1) { level100.SetActive(true); CheckAchTrigger("level100"); }

        //New
        if (newAch1Novemdecillion == 1) { goldAmountAch13.SetActive(true); CheckAchTrigger("Novemdecillion"); }
        if (newAch100EnchantedChest == 1) { enchantedGoldenChest100.SetActive(true); CheckAchTrigger("enchanted100"); }
        if (newAch100BossChest == 1) { bossChest100.SetActive(true); CheckAchTrigger("bossChest100"); }
        if (newAchLevel200 == 1) { level200.SetActive(true); CheckAchTrigger("level200"); }
        if (newAchAllAdventurer == 1) { allAdventurer.SetActive(true); CheckAchTrigger("allAdventure"); }
        if (newAchEnchantedHammer == 1) { purchaseEnchantedHammer.SetActive(true); CheckAchTrigger("enchantedHammer"); }
        if (newAchPurchaseChest32 == 1) { purchaseChest32.SetActive(true); CheckAchTrigger("purchaseChest32"); }
        if (newAch25XGoldCoin1000 == 1) { goldCoin25X.SetActive(true); CheckAchTrigger("goldcoin25X1000"); }

        //New after big update
        if (newAch100XGoldCoin == 1) { goldCoin100X.SetActive(true); CheckAchTrigger("coldCoin100X1"); }
        if (newAch1Undecillion == 1) { goldUndecillion.SetActive(true); CheckAchTrigger("undecillion"); }
        if (newAch1Duodecillion == 1) { goldDuodecillion.SetActive(true); CheckAchTrigger("duodecillion"); }
        if (newAch1Tredecillion == 1) { goldTredecillion.SetActive(true); CheckAchTrigger("Tredecillion"); }
        if (newAch1Quattuordecillion == 1) { goldQuattuordecillion.SetActive(true); CheckAchTrigger("Quattuordecillion"); }
        if (newAch1Quindecillion == 1) { goldQuindecillion.SetActive(true); CheckAchTrigger("Quindecillion"); }
        if (newAch1Sexdecillion == 1) { goldSexdecillion.SetActive(true); CheckAchTrigger("Sexdecillion"); }
        if (newAch1Septendecillion == 1) { goldSeptendecillion.SetActive(true); CheckAchTrigger("Septendecillion"); }
        if (newAch1Octodecillion == 1) { goldOctodecillion.SetActive(true); CheckAchTrigger("Octodecillion"); }
        if (newAchLevel150 == 1) { level150.SetActive(true); CheckAchTrigger("level150"); }
        if (newAch20KSkillPoints == 1) { skillPoints20K.SetActive(true); CheckAchTrigger("skillPoints2000"); }
        if (newAch2MillionGoldCoins == 1) { goldCoin2Million.SetActive(true); CheckAchTrigger("goldCoins2Mill"); }
        if (newAch100KTreasures == 1) { treasure100K.SetActive(true); CheckAchTrigger("treasures100K"); }
        if (newAch100Ultra == 1) { ultra100.SetActive(true); CheckAchTrigger("ultra100"); }
        if (newAch100Mythic == 1) { mythic100.SetActive(true); CheckAchTrigger("mythic100"); }
        if (newAch100Eternal == 1) { eternal100.SetActive(true); CheckAchTrigger("eternal100"); }
        if (newAch2500Reinforced == 1) { reinforcedChests2500.SetActive(true); CheckAchTrigger("reinforced2500"); }
        if (newAchUseChicken == 1) { useChicken.SetActive(true); CheckAchTrigger("useChicken"); }
        if (newAchChest37 == 1) { purchaseChest37.SetActive(true); CheckAchTrigger("chest37"); }
        if (newAch5X250KDrop == 1) { goldCoin5X250K.SetActive(true); CheckAchTrigger("goldCoin5X250K"); }
    }


    #region SaveAndLoadJSON
    public void LoadData(GameDataJSON data)
    {
        achSaves[0] = data.achSaves[0];
        achSaves[1] = data.achSaves[1];
        achSaves[2] = data.achSaves[2];
        achSaves[3] = data.achSaves[3];
        achSaves[4] = data.achSaves[4];
        achSaves[5] = data.achSaves[5];
        achSaves[6] = data.achSaves[6];
        achSaves[7] = data.achSaves[7];
        achSaves[8] = data.achSaves[8];
        achSaves[9] = data.achSaves[9];
        achSaves[10] = data.achSaves[10];
        achSaves[11] = data.achSaves[11];
        achSaves[12] = data.achSaves[12];
        achSaves[13] = data.achSaves[13];
        achSaves[14] = data.achSaves[14];
        achSaves[15] = data.achSaves[15];
        achSaves[16] = data.achSaves[16];
        achSaves[17] = data.achSaves[17];
        achSaves[18] = data.achSaves[18];
        achSaves[19] = data.achSaves[19];
        achSaves[20] = data.achSaves[20];
        achSaves[21] = data.achSaves[21];
        achSaves[22] = data.achSaves[22];
        achSaves[23] = data.achSaves[23];
        achSaves[24] = data.achSaves[24];
        achSaves[25] = data.achSaves[25];
        achSaves[26] = data.achSaves[26];
        achSaves[27] = data.achSaves[27];
        achSaves[28] = data.achSaves[28];
        achSaves[29] = data.achSaves[29];
        achSaves[30] = data.achSaves[30];
        achSaves[31] = data.achSaves[31];
        achSaves[32] = data.achSaves[32];
        achSaves[33] = data.achSaves[33];
        achSaves[34] = data.achSaves[34];
        achSaves[35] = data.achSaves[35];
        achSaves[36] = data.achSaves[36];
        achSaves[37] = data.achSaves[37];
        achSaves[38] = data.achSaves[38];
        achSaves[39] = data.achSaves[39];
        achSaves[40] = data.achSaves[40];
        achSaves[41] = data.achSaves[41];
        achSaves[42] = data.achSaves[42];
        achSaves[43] = data.achSaves[43];
        achSaves[44] = data.achSaves[44];
        achSaves[45] = data.achSaves[45];
        achSaves[46] = data.achSaves[46];
        achSaves[47] = data.achSaves[47];
        achSaves[48] = data.achSaves[48];
        achSaves[49] = data.achSaves[49];
        achSaves[50] = data.achSaves[50];
        achSaves[51] = data.achSaves[51];
        achSaves[52] = data.achSaves[52];
        achSaves[53] = data.achSaves[53];
        achSaves[54] = data.achSaves[54];
        achSaves[55] = data.achSaves[55];
        achSaves[56] = data.achSaves[56];
        achSaves[57] = data.achSaves[57];
        achSaves[58] = data.achSaves[58];
        achSaves[59] = data.achSaves[59];
        achSaves[60] = data.achSaves[60];
        achSaves[61] = data.achSaves[61];
        achSaves[62] = data.achSaves[62];
        achSaves[63] = data.achSaves[63];
        achSaves[64] = data.achSaves[64];
        achSaves[65] = data.achSaves[65];
        achSaves[66] = data.achSaves[66];
        achSaves[67] = data.achSaves[67];
        achSaves[68] = data.achSaves[68];
        achSaves[69] = data.achSaves[69];
        achSaves[70] = data.achSaves[70];
        achSaves[71] = data.achSaves[71];
        achSaves[72] = data.achSaves[72];
        achSaves[73] = data.achSaves[73];
        achSaves[74] = data.achSaves[74];
        achSaves[75] = data.achSaves[75];
        achSaves[76] = data.achSaves[76];
        achSaves[77] = data.achSaves[77];
        achSaves[78] = data.achSaves[78];
        achSaves[79] = data.achSaves[79];
        achSaves[80] = data.achSaves[80];
        achSaves[81] = data.achSaves[81];
        achSaves[82] = data.achSaves[82];
        achSaves[83] = data.achSaves[83];
        achSaves[84] = data.achSaves[84];
        achSaves[85] = data.achSaves[85];
        achSaves[86] = data.achSaves[86];
        achSaves[87] = data.achSaves[87];
        achSaves[88] = data.achSaves[88];
        achSaves[89] = data.achSaves[89];
        achSaves[90] = data.achSaves[90];
        achSaves[91] = data.achSaves[91];

        newAch1Novemdecillion = data.newAch1Novemdecillion;
        newAch100EnchantedChest = data.newAch100EnchantedChest;
        newAch100BossChest = data.newAch100BossChest;
        newAchLevel200 = data.newAchLevel200;
        newAchAllAdventurer = data.newAchAllAdventurer;
        newAchEnchantedHammer = data.newAchEnchantedHammer;
        newAchPurchaseChest32 = data.newAchPurchaseChest32;
        newAch25XGoldCoin1000 = data.newAch25XGoldCoin1000;

        newAch100XGoldCoin = data.newAch100XGoldCoin;
        newAch1Undecillion = data.newAch1Undecillion;
        newAch1Duodecillion = data.newAch1Duodecillion;
        newAch1Tredecillion = data.newAch1Tredecillion;
        newAch1Quattuordecillion = data.newAch1Quattuordecillion;
        newAch1Quindecillion = data.newAch1Quindecillion;
        newAch1Sexdecillion = data.newAch1Sexdecillion;
        newAch1Septendecillion = data.newAch1Septendecillion;
        newAch1Octodecillion = data.newAch1Octodecillion;
        newAchLevel150 = data.newAchLevel150;
        newAch20KSkillPoints = data.newAch20KSkillPoints;
        newAch2MillionGoldCoins = data.newAch2MillionGoldCoins;
        newAch100KTreasures = data.newAch100KTreasures;
        newAch100Ultra = data.newAch100Ultra;
        newAch100Mythic = data.newAch100Mythic;
        newAch100Eternal = data.newAch100Eternal;
        newAch2500Reinforced = data.newAch2500Reinforced;
        newAchUseChicken = data.newAchUseChicken;
        newAchChest37 = data.newAchChest37;
        newAch5X250KDrop = data.newAch5X250KDrop;
    }

    public void SaveData(ref GameDataJSON data)
    {
        data.achSaves[0] = achSaves[0];
        data.achSaves[1] = achSaves[1];
        data.achSaves[2] = achSaves[2];
        data.achSaves[3] = achSaves[3];
        data.achSaves[4] = achSaves[4];
        data.achSaves[5] = achSaves[5];
        data.achSaves[6] = achSaves[6];
        data.achSaves[7] = achSaves[7];
        data.achSaves[8] = achSaves[8];
        data.achSaves[9] = achSaves[9];
        data.achSaves[10] = achSaves[10];
        data.achSaves[11] = achSaves[11];
        data.achSaves[12] = achSaves[12];
        data.achSaves[13] = achSaves[13];
        data.achSaves[14] = achSaves[14];
        data.achSaves[15] = achSaves[15];
        data.achSaves[16] = achSaves[16];
        data.achSaves[17] = achSaves[17];
        data.achSaves[18] = achSaves[18];
        data.achSaves[19] = achSaves[19];
        data.achSaves[20] = achSaves[20];
        data.achSaves[21] = achSaves[21];
        data.achSaves[22] = achSaves[22];
        data.achSaves[23] = achSaves[23];
        data.achSaves[24] = achSaves[24];
        data.achSaves[25] = achSaves[25];
        data.achSaves[26] = achSaves[26];
        data.achSaves[27] = achSaves[27];
        data.achSaves[28] = achSaves[28];
        data.achSaves[29] = achSaves[29];
        data.achSaves[30] = achSaves[30];
        data.achSaves[31] = achSaves[31];
        data.achSaves[32] = achSaves[32];
        data.achSaves[33] = achSaves[33];
        data.achSaves[34] = achSaves[34];
        data.achSaves[35] = achSaves[35];
        data.achSaves[36] = achSaves[36];
        data.achSaves[37] = achSaves[37];
        data.achSaves[38] = achSaves[38];
        data.achSaves[39] = achSaves[39];
        data.achSaves[40] = achSaves[40];
        data.achSaves[41] = achSaves[41];
        data.achSaves[42] = achSaves[42];
        data.achSaves[43] = achSaves[43];
        data.achSaves[44] = achSaves[44];
        data.achSaves[45] = achSaves[45];
        data.achSaves[46] = achSaves[46];
        data.achSaves[47] = achSaves[47];
        data.achSaves[48] = achSaves[48];
        data.achSaves[49] = achSaves[49];
        data.achSaves[50] = achSaves[50];
        data.achSaves[51] = achSaves[51];
        data.achSaves[52] = achSaves[52];
        data.achSaves[53] = achSaves[53];
        data.achSaves[54] = achSaves[54];
        data.achSaves[55] = achSaves[55];
        data.achSaves[56] = achSaves[56];
        data.achSaves[57] = achSaves[57];
        data.achSaves[58] = achSaves[58];
        data.achSaves[59] = achSaves[59];
        data.achSaves[60] = achSaves[60];
        data.achSaves[61] = achSaves[61];
        data.achSaves[62] = achSaves[62];
        data.achSaves[63] = achSaves[63];
        data.achSaves[64] = achSaves[64];
        data.achSaves[65] = achSaves[65];
        data.achSaves[66] = achSaves[66];
        data.achSaves[67] = achSaves[67];
        data.achSaves[68] = achSaves[68];
        data.achSaves[69] = achSaves[69];
        data.achSaves[70] = achSaves[70];
        data.achSaves[71] = achSaves[71];
        data.achSaves[72] = achSaves[72];
        data.achSaves[73] = achSaves[73];
        data.achSaves[74] = achSaves[74];
        data.achSaves[75] = achSaves[75];
        data.achSaves[76] = achSaves[76];
        data.achSaves[77] = achSaves[77];
        data.achSaves[78] = achSaves[78];
        data.achSaves[79] = achSaves[79];
        data.achSaves[80] = achSaves[80];
        data.achSaves[81] = achSaves[81];
        data.achSaves[82] = achSaves[82];
        data.achSaves[83] = achSaves[83];
        data.achSaves[84] = achSaves[84];
        data.achSaves[85] = achSaves[85];
        data.achSaves[86] = achSaves[86];
        data.achSaves[87] = achSaves[87];
        data.achSaves[88] = achSaves[88];
        data.achSaves[89] = achSaves[89];
        data.achSaves[90] = achSaves[90];
        data.achSaves[91] = achSaves[91];

        data.newAch1Novemdecillion = newAch1Novemdecillion;
        data.newAch100EnchantedChest = newAch100EnchantedChest;
        data.newAch100BossChest = newAch100BossChest;
        data.newAchLevel200 = newAchLevel200;
        data.newAchAllAdventurer = newAchAllAdventurer;
        data.newAchEnchantedHammer = newAchEnchantedHammer;
        data.newAchPurchaseChest32 = newAchPurchaseChest32;
        data.newAch25XGoldCoin1000 = newAch25XGoldCoin1000;

        data.newAch100XGoldCoin = newAch100XGoldCoin;
        data.newAch1Undecillion = newAch1Undecillion;
        data.newAch1Duodecillion = newAch1Duodecillion;
        data.newAch1Tredecillion = newAch1Tredecillion;
        data.newAch1Quattuordecillion = newAch1Quattuordecillion;
        data.newAch1Quindecillion = newAch1Quindecillion;
        data.newAch1Sexdecillion = newAch1Sexdecillion;
        data.newAch1Septendecillion = newAch1Septendecillion;
        data.newAch1Octodecillion = newAch1Octodecillion;
        data.newAchLevel150 = newAchLevel150;
        data.newAch20KSkillPoints = newAch20KSkillPoints;
        data.newAch2MillionGoldCoins = newAch2MillionGoldCoins;
        data.newAch100KTreasures = newAch100KTreasures;
        data.newAch100Ultra = newAch100Ultra;
        data.newAch100Mythic = newAch100Mythic;
        data.newAch100Eternal = newAch100Eternal;
        data.newAch2500Reinforced = newAch2500Reinforced;
        data.newAchUseChicken = newAchUseChicken;
        data.newAchChest37 = newAchChest37;
        data.newAch5X250KDrop = newAch5X250KDrop;
    }
    #endregion

    public void CheckAchTrigger(string achName)
    {
        if (Facepunch.noSteamInt == true) { return; }
        if (PlaceMobileButtons.isMobile == true) { return; }

        var ach = new Steamworks.Data.Achievement(achName);
        if (ach.State == false)
        {
            ach.Trigger();
        }
        ach.Trigger();
    }


    public void TriggerAch(string achName)
    {
        if (Facepunch.noSteamInt == true) { return; }
        if (PlaceMobileButtons.isMobile == true) { return; }

        var ach = new Steamworks.Data.Achievement(achName);
        if (ach.State == false)
        {
            ach.Trigger();
         }
        ach.Trigger();
    }


    //ALL NEW ACH
    void Update()
    {
        //Gold coins
        #region goldCoin25
        if (Stats.goldCoinsDropped >= 25)
        {
            if (achSaves[0] != 1)
            {
                achSaves[0] = 1;
                goldCoinAch1.SetActive(true);
                TriggerAch("goldCoin25");
            }
        }
        #endregion

        #region goldCoin1000
        if (Stats.goldCoinsDropped >= 1000)
        {
            if (achSaves[1] != 1)
            {
                achSaves[1] = 1;
                goldCoinAch2.SetActive(true);
                TriggerAch("goldCoin1000");
            }
        }
        #endregion

        #region goldCoin100000
        if (Stats.goldCoinsDropped >= 100000)
        {
            if (achSaves[2] != 1)
            {
                achSaves[2] = 1;
                goldCoinAch3.SetActive(true);
                TriggerAch("goldCoin100000");
            }
        }
        #endregion

        #region goldCoin1Imillion
        if (Stats.goldCoinsDropped >= 1000000)
        {
            if (achSaves[3] != 1)
            {
                achSaves[3] = 1;
                goldCoinAch4.SetActive(true);
                TriggerAch("goldCoin1Million");
            }
        }
        #endregion

        #region goldCoin2Imillion
        if (Stats.goldCoinsDropped >= 2000000)
        {
            if (newAch2MillionGoldCoins != 1)
            {
                newAch2MillionGoldCoins = 1;
                goldCoin2Million.SetActive(true);
                TriggerAch("goldCoins2Mill");
            }
        }
        #endregion

        //Gold total
        #region 100Gold
        if (UpdateGame.totalGoldHigher >= 100)
        {
            if (achSaves[4] != 1)
            {
                achSaves[4] = 1;
                goldAmountAch1.SetActive(true);
                TriggerAch("gold100");
            }
        }
        #endregion

        #region 100000Gold
        if (UpdateGame.totalGoldHigher >= 100000)
        {
            if (achSaves[5] != 1)
            {
                achSaves[5] = 1;
                goldAmountAch2.SetActive(true);
                TriggerAch("gold100000");
            }
        }
        #endregion

        #region 1000000Gold
        if (UpdateGame.totalGoldHigher >= 1000000)
        {
            if (achSaves[6] != 1)
            {
                achSaves[6] = 1;
                goldAmountAch3.SetActive(true);
                TriggerAch("gold1Million");
            }
        }
        #endregion

        #region 1BillionGold
        if (UpdateGame.totalGoldHigher >= 1000000000)
        {
            if (achSaves[7] != 1)
            {
                achSaves[7] = 1;
                goldAmountAch4.SetActive(true);
                TriggerAch("gold1Billion");
            }
        }
        #endregion

        #region 1TrillionGold
        if (UpdateGame.totalGoldHigher >= 1000000000000)
        {
            if (achSaves[8] != 1)
            {
                achSaves[8] = 1;
                goldAmountAch5.SetActive(true);
                TriggerAch("gold1Trillion");
            }
        }
        #endregion

        #region 1QuadrillionGold
        if (UpdateGame.totalGoldHigher >= 1000000000000000)
        {
            if (achSaves[9] != 1)
            {
                achSaves[9] = 1;
                goldAmountAch6.SetActive(true);
                TriggerAch("gold1Quadrillion");
            }
        }
        #endregion

        #region 1QuintillionGold
        if (UpdateGame.totalGoldHigher >= 1000000000000000000)
        {
            if (achSaves[10] != 1)
            {
                achSaves[10] = 1;
                goldAmountAch7.SetActive(true);
                TriggerAch("gold1Quintillion");
            }
        }
        #endregion

        #region 1Sextillion
        if (UpdateGame.totalGoldHigher >= 1000000000000000000000f)
        {
            if (achSaves[11] != 1)
            {
                achSaves[11] = 1;
                goldAmountAch8.SetActive(true);
                TriggerAch("gold1Sextillion");
            }
        }
        #endregion

        #region 1Septillion
        if (UpdateGame.totalGoldHigher >= 1000000000000000000000000f)
        {
            if (achSaves[12] != 1)
            {
                achSaves[12] = 1;
                goldAmountAch9.SetActive(true);
                TriggerAch("gold1Septillion");
            }
        }
        #endregion

        #region 1Octillion
        if (UpdateGame.totalGoldHigher >= 1000000000000000000000000000f)
        {
            if (achSaves[13] != 1)
            {
                achSaves[13] = 1;
                goldAmountAch10.SetActive(true);
                TriggerAch("gold1Octillion");
            }
        }
        #endregion

        #region 1Nonillion
        if (UpdateGame.totalGoldHigher >= 1000000000000000000000000000000f)
        {
            if (achSaves[14] != 1)
            {
                achSaves[14] = 1;
                goldAmountAch11.SetActive(true);
                TriggerAch("gold1Nonillion");
            }
        }
        #endregion

        #region 1Decillion
        if (UpdateGame.totalGoldHigher >= 1000000000000000000000000000000000f)
        {
            if (achSaves[15] != 1)
            {
                achSaves[15] = 1;
                goldAmountAch12.SetActive(true);
                TriggerAch("gold1Decillion");
            }
        }
        #endregion

        //New
        #region 1Undecillion
        if (UpdateGame.totalGoldHigher >= 1000000000000000000000000000000000000.5)
        {
            if (newAch1Undecillion != 1)
            {
                newAch1Undecillion = 1;
                goldUndecillion.SetActive(true);
                TriggerAch("undecillion");
            }
        }
        #endregion

        #region 1Duodecillion
        if (UpdateGame.totalGoldHigher >= 1000000000000000000000000000000000000000.5)
        {
            if (newAch1Duodecillion != 1)
            {
                newAch1Duodecillion = 1;
                goldDuodecillion.SetActive(true);
                TriggerAch("duodecillion");
            }
        }
        #endregion

        #region 1Tredecillion
        if (UpdateGame.totalGoldHigher >= 1000000000000000000000000000000000000000000.5)
        {
            if (newAch1Tredecillion != 1)
            {
                newAch1Tredecillion = 1;
                goldTredecillion.SetActive(true);
                TriggerAch("Tredecillion");
            }
        }
        #endregion

        #region 1Quatuodecillion
        if (UpdateGame.totalGoldHigher >= 1000000000000000000000000000000000000000000000.5)
        {
            if (newAch1Quattuordecillion != 1)
            {
                newAch1Quattuordecillion = 1;
                goldQuattuordecillion.SetActive(true);
                TriggerAch("Quattuordecillion");
            }
        }
        #endregion

        #region 1Quindecillion
        if (UpdateGame.totalGoldHigher >= 1000000000000000000000000000000000000000000000000.5)
        {
            if (newAch1Quindecillion != 1)
            {
                newAch1Quindecillion = 1;
                goldQuindecillion.SetActive(true);
                TriggerAch("Quindecillion");
            }
        }
        #endregion

        #region 1Sexdecillion
        if (UpdateGame.totalGoldHigher >= 1000000000000000000000000000000000000000000000000000.5)
        {
            if (newAch1Sexdecillion != 1)
            {
                newAch1Sexdecillion = 1;
                goldSexdecillion.SetActive(true);
                TriggerAch("Sexdecillion");
            }
        }
        #endregion

        #region 1Septendecillion
        if (UpdateGame.totalGoldHigher >= 1000000000000000000000000000000000000000000000000000000.5)
        {
            if (newAch1Septendecillion != 1)
            {
                newAch1Septendecillion = 1;
                goldSeptendecillion.SetActive(true);
                TriggerAch("Septendecillion");
            }
        }
        #endregion

        #region 1Octodecillion
        if (UpdateGame.totalGoldHigher >= 1000000000000000000000000000000000000000000000000000000000.5)
        {
            if (newAch1Octodecillion != 1)
            {
                newAch1Octodecillion = 1;
                goldOctodecillion.SetActive(true);
                TriggerAch("Octodecillion");
            }
        }
        #endregion

        #region 1Novemdecillion	
        if (UpdateGame.totalGoldHigher >= 1000000000000000000000000000000000000000000000000000000000000.5)
        {
            if (newAch1Novemdecillion != 1)
            {
                newAch1Novemdecillion = 1;
                goldAmountAch13.SetActive(true);
                TriggerAch("Novemdecillion");
            }
        }
        #endregion

        //5X Gold coins
        #region 5XgoldCoin
        if (Stats.goldCoin5XDropped >= 1)
        {
            if (achSaves[16] != 1)
            {
                achSaves[16] = 1;
                goldCoin5X1.SetActive(true);
                TriggerAch("goldCoin5X1");
            }
        }
        #endregion

        #region 5XgoldCoin1000
        if (Stats.goldCoin5XDropped >= 1000)
        {
            if (achSaves[17] != 1)
            {
                achSaves[17] = 1;
                goldCoin5X2.SetActive(true);
                TriggerAch("goldCoin5X1000");
            }
        }
        #endregion

        #region 5XgoldCoin50000
        if (Stats.goldCoin5XDropped >= 50000)
        {
            if (achSaves[18] != 1)
            {
                achSaves[18] = 1;
                goldCoin5X3.SetActive(true);
                TriggerAch("goldCoin5X50000");
            }
        }
        #endregion

        #region 5XgoldCoin250000
        if (Stats.goldCoin5XDropped >= 250000)
        {
            if (newAch5X250KDrop != 1)
            {
                newAch5X250KDrop = 1;
                goldCoin5X250K.SetActive(true);
                TriggerAch("goldCoin5X250K");
            }
        }
        #endregion

        //10XGold Coins
        #region 10XGoldCoin
        if (Stats.goldCoins10XDropped >= 1)
        {
            if (achSaves[19] != 1)
            {
                achSaves[19] = 1;
                goldCoin10X1.SetActive(true);
                TriggerAch("goldCoin10X1");
            }
        }
        #endregion

        #region 10XGoldCoin1000
        if (Stats.goldCoins10XDropped >= 1000)
        {
            if (achSaves[20] != 1)
            {
                achSaves[20] = 1;
                goldCoin10X2.SetActive(true);
                TriggerAch("goldCoin10X1000");
            }
        }
        #endregion

        #region 10XGoldCoin25000
        if (Stats.goldCoins10XDropped >= 15000)
        {
            if (achSaves[21] != 1)
            {
                achSaves[21] = 1;
                goldCoin10X3.SetActive(true);
                TriggerAch("goldCoin10X25000");
            }
        }
        #endregion

        //25XGoldCoins
        #region 25XGoldCoin1000
        if (Stats.goldCoin25XDropped >= 1000)
        {
            if (newAch25XGoldCoin1000 != 1)
            {
                newAch25XGoldCoin1000 = 1;
                goldCoin25X.SetActive(true);
                TriggerAch("goldcoin25X1000");
            }
        }
        #endregion

        //100XGoldCoin
        #region 100XGoldCoi9n
        if (Stats.goldCoin100XDropped >= 1)
        {
            if (newAch100XGoldCoin != 1)
            {
                newAch100XGoldCoin = 1;
                goldCoin100X.SetActive(true);
                TriggerAch("coldCoin100X1");
            }
        }
        #endregion


        //Gold coins click and treasures clicks
        #region 10ClickCoins
        if (Stats.coinsSpawnedFromClicks >= 10)
        {
            if (achSaves[22] != 1)
            {
                achSaves[22] = 1;
                clickSpawn1.SetActive(true);
                TriggerAch("coinClicks10");
            }
        }
        #endregion

        #region 100ClickCoins
        if (Stats.coinsSpawnedFromClicks >= 100)
        {
            if (achSaves[23] != 1)
            {
                achSaves[23] = 1;
                clickSpawn2.SetActive(true);
                TriggerAch("coinClicks100");
            }
        }
        #endregion

        #region 1000ClickCoins
        if (Stats.coinsSpawnedFromClicks >= 1000)
        {
            if (achSaves[24] != 1)
            {
                achSaves[24] = 1;
                clickSpawn3.SetActive(true);
                TriggerAch("coinClicks1000");
            }
        }
        #endregion

        //Treasure drop
        #region 1Treasure
        if (Stats.treasuresDropped >= 1)
        {
            if (achSaves[25] != 1)
            {
                achSaves[25] = 1;
                treasure1.SetActive(true);
                TriggerAch("treasure1");
            }
        }
        #endregion

        #region 100Treasure
        if (Stats.treasuresDropped >= 100)
        {
            if (achSaves[26] != 1)
            {
                achSaves[26] = 1;
                treasure2.SetActive(true);
                TriggerAch("treasure100");
            }
        }
        #endregion

        #region 1000Treasure
        if (Stats.treasuresDropped >= 1000)
        {
            if (achSaves[27] != 1)
            {
                achSaves[27] = 1;
                treasure3.SetActive(true);
                TriggerAch("treasure1000");
            }
        }
        #endregion

        #region 10000Treasure
        if (Stats.treasuresDropped >= 10000)
        {
            if (achSaves[28] != 1)
            {
                achSaves[28] = 1;
                treasure4.SetActive(true);
                TriggerAch("treasure10000");
            }
        }
        #endregion

        #region 50000Treasure
        if (Stats.treasuresDropped >= 50000)
        {
            if (achSaves[29] != 1)
            {
                achSaves[29] = 1;
                treasure5.SetActive(true);
                TriggerAch("treasure50000");
            }
        }
        #endregion

        #region 100000Treasure
        if (Stats.treasuresDropped >= 100000)
        {
            if (newAch100KTreasures != 1)
            {
                newAch100KTreasures = 1;
                treasure100K.SetActive(true);
                TriggerAch("treasures100K");
            }
        }
        #endregion

        #region 100Common
        if (Stats.commonTreasureDrops >= 100)
        {
            if (achSaves[30] != 1)
            {
                achSaves[30] = 1;
                common100.SetActive(true);
                TriggerAch("common100");
            }
        }
        #endregion

        #region 100Uncommon
        if (Stats.uncommonTreasureDrops >= 100)
        {
            if (achSaves[31] != 1)
            {
                achSaves[31] = 1;
                uncommon100.SetActive(true);
                TriggerAch("uncommon100");
            }
        }
        #endregion

        #region 100Rare
        if (Stats.rareTreasureDrops >= 100)
        {
            if (achSaves[32] != 1)
            {
                achSaves[32] = 1;
                rare100.SetActive(true);
                TriggerAch("rare100");
            }
        }
        #endregion

        #region 100Veryrare
        if (Stats.veryRareTreasureDrops >= 100)
        {
            if (achSaves[33] != 1)
            {
                achSaves[33] = 1;
                veryRare100.SetActive(true);
                TriggerAch("veryRare100");
            }
        }
        #endregion

        #region 100ExtremelyRare
        if (Stats.extremelyRareTreasureDrops >= 100)
        {
            if (achSaves[34] != 1)
            {
                achSaves[34] = 1;
                extremelyRare100.SetActive(true);
                TriggerAch("extremelyRare100");
            }
        }
        #endregion

        #region 100Legendary
        if (Stats.legendaryTreasureDrops >= 100)
        {
            if (achSaves[35] != 1)
            {
                achSaves[35] = 1;
                legendary100.SetActive(true);
                TriggerAch("legendary100");
            }
        }
        #endregion

        #region 100Ultra
        if (Stats.ultraTreasures >= 100)
        {
            if (newAch100Ultra != 1)
            {
                newAch100Ultra = 1;
                ultra100.SetActive(true);
                TriggerAch("ultra100");
            }
        }
        #endregion

        #region 100Mythic
        if (Stats.mythicTreasures >= 100)
        {
            if (newAch100Mythic != 1)
            {
                newAch100Mythic = 1;
                mythic100.SetActive(true);
                TriggerAch("mythic100");
            }
        }
        #endregion

        #region 100Eternal
        if (Stats.eternalTreasures >= 100)
        {
            if (newAch100Eternal != 1)
            {
                newAch100Eternal = 1;
                eternal100.SetActive(true);
                TriggerAch("eternal100");
            }
        }
        #endregion

        #region 10TreasureClicks
        if (Stats.treasuredSpawnedFromClicks >= 10)
        {
            if (achSaves[36] != 1)
            {
                achSaves[36] = 1;
                treasureClick1.SetActive(true);
                TriggerAch("treasureClicks10");
            }
        }
        #endregion

        #region 100TreasureClicks
        if (Stats.treasuredSpawnedFromClicks >= 100)
        {
            if (achSaves[37] != 1)
            {
                achSaves[37] = 1;
                treasureClick2.SetActive(true);
                TriggerAch("treasureClicks100");
            }
        }
        #endregion

        #region 1000TreasureClicks
        if (Stats.treasuredSpawnedFromClicks >= 1000)
        {
            if (achSaves[38] != 1)
            {
                achSaves[38] = 1;
                treasureClick3.SetActive(true);
                TriggerAch("treasureClicks1000");
            }
        }
        #endregion

        #region 100Doubled
        if (Stats.treasuresDoubled >= 100)
        {
            if (achSaves[39] != 1)
            {
                achSaves[39] = 1;
                treasuresDoubled.SetActive(true);
                TriggerAch("treasureDouble100");
            }
        }
        #endregion

        //Rare treasures
        #region 1RareTrease
        if (Stats.rareTreasuresFound >= 1)
        {
            if (achSaves[40] != 1)
            {
                achSaves[40] = 1;
                rareTreasure1.SetActive(true);
                TriggerAch("RareTresure1");
            }
        }
        #endregion

        #region 3RareTrease
        if (Stats.rareTreasuresFound >= 3)
        {
            if (achSaves[41] != 1)
            {
                achSaves[41] = 1;
                rareTreasure2.SetActive(true);
                TriggerAch("RareTresure3");
            }
        }
        #endregion

        #region 5RareTrease
        if (Stats.rareTreasuresFound >= 5)
        {
            if (achSaves[42] != 1)
            {
                achSaves[42] = 1;
                rareTreasure3.SetActive(true);
                TriggerAch("RareTresure5");
            }
        }
        #endregion

        #region 13RareTrease
        if (Stats.rareTreasuresFound >= 13)
        {
            if (achSaves[43] != 1)
            {
                achSaves[43] = 1;
                rareTreasure4.SetActive(true);
                TriggerAch("RareTresure13");
            }
        }
        #endregion

        #region 25RareTrease
        if (Stats.rareTreasuresFound >= 25)
        {
            if (achSaves[44] != 1)
            {
                achSaves[44] = 1;
                rareTreasure5.SetActive(true);
                TriggerAch("RareTresure21");
            }
        }
        #endregion

        #region cookie
        if (RareTreasures.cookieFound == 1)
        {
            if (achSaves[45] != 1)
            {
                achSaves[45] = 1;
                findCookie.SetActive(true);
                TriggerAch("FindCookie");
            }
        }
        #endregion

        #region clickCookie
        if (RareTreasures.clickedCookie == true)
        {
            if (achSaves[46] != 1)
            {
                achSaves[46] = 1;
                clickCookie.SetActive(true);
                TriggerAch("ClickCookie");
            }
        }
        #endregion

        #region useChicken
        if (RareTreasures.choseChickenReward == true)
        {
            if (newAchUseChicken != 1)
            {
                newAchUseChicken = 1;
                useChicken.SetActive(true);
                TriggerAch("useChicken");
            }
        }
        #endregion

        //Prestige
        #region Prestige1
        if (Stats.prestigedTimesCount >= 1)
        {
            if (achSaves[47] != 1)
            {
                achSaves[47] = 1;
                prestige1.SetActive(true);
                TriggerAch("Prestige");
            }
        }
        #endregion

        #region Prestige5
        if (Stats.prestigedTimesCount >= 5)
        {
            if (achSaves[48] != 1)
            {
                achSaves[48] = 1;
                prestige2.SetActive(true);
                TriggerAch("Prestige5");
            }
        }
        #endregion

        #region Prestige15
        if (Stats.prestigedTimesCount >= 15)
        {
            if (achSaves[49] != 1)
            {
                achSaves[49] = 1;
                prestige3.SetActive(true);
                TriggerAch("Prestige10");
            }
        }
        #endregion

        #region PrestigeUpgrades5
        if (Stats.prestigeUpgradesPurchased >= 5)
        {
            if (achSaves[50] != 1)
            {
                achSaves[50] = 1;
                purchasePrestigeUpgrade1.SetActive(true);
                TriggerAch("PrestigeUpgrades5");
            }
        }
        #endregion

        #region PrestigeUpgrades15
        if (Stats.prestigeUpgradesPurchased >= 15)
        {
            if (achSaves[51] != 1)
            {
                achSaves[51] = 1;
                purchasePrestigeUpgrade2.SetActive(true);
                TriggerAch("PrestigeUpgrades15");
            }
        }
        #endregion

        #region PrestigeUpgrades35
        if (Stats.prestigeUpgradesPurchased >= 35)
        {
            if (achSaves[52] != 1)
            {
                achSaves[52] = 1;
                purchasePrestigeUpgrade3.SetActive(true);
                TriggerAch("PrestigeUpgrades25");
            }
        }
        #endregion

        #region PrestigeUpgrades60
        if (Stats.prestigeUpgradesPurchased >= 60)
        {
            if (achSaves[53] != 1)
            {
                achSaves[53] = 1;
                purchasePrestigeUpgrade4.SetActive(true);
                TriggerAch("PrestigeUpgrades40");
            }
        }
        #endregion

        #region PrestigeUpgradesALL
        if (Stats.prestigeUpgradesPurchased >= 89)
        {
            if (achSaves[54] != 1)
            {
                achSaves[54] = 1;
                purchasePrestigeUpgrade5.SetActive(true);
                TriggerAch("AllPrestigeUpgrades");
            }
        }
        #endregion

        #region PrestigeAllClicker
        if (Stats.clickerUpgradePurchased >= 16)
        {
            if (achSaves[55] != 1)
            {
                achSaves[55] = 1;
                allClicker.SetActive(true);
                TriggerAch("PurchaseClicker");
            }
        }
        #endregion

        #region PrestigeAllLounger
        if (Stats.loungerUpgradesPurchased >= 17)
        {
            if (achSaves[56] != 1)
            {
                achSaves[56] = 1;
                allLounger.SetActive(true);
                TriggerAch("PurchaseLounger");
            }
        }
        #endregion

        #region PrestigeAllPirate
        if (Stats.pirateUpgradesPurchased >= 24)
        {
            if (achSaves[57] != 1)
            {
                achSaves[57] = 1;
                allPirate.SetActive(true);
                TriggerAch("PurchasePirate");
            }
        }
        #endregion

        #region PrestigeAllHoarder
        if (Stats.hoarderUpgradeesPurchased >= 16)
        {
            if (achSaves[58] != 1)
            {
                achSaves[58] = 1;
                allHoarder.SetActive(true);
                TriggerAch("PurchaseHoarder");
            }
        }
        #endregion

        #region PrestigeAllAdventurer
        if (Stats.adventurereUpgradesPurchased >= 16)
        {
            if (newAchAllAdventurer != 1)
            {
                newAchAllAdventurer = 1;
                allAdventurer.SetActive(true);
                TriggerAch("allAdventure");
            }
        }
        #endregion

        //Items
        #region lootPotion
        if (UseConsumable.lootPotionCount >= 1)
        {
            if (achSaves[59] != 1)
            {
                achSaves[59] = 1;
                purchaseLoot.SetActive(true);
                TriggerAch("PurchaseLootPotion");
            }
        }
        #endregion

        #region goldenTouch
        if (UseConsumable.goldenTouchCount >= 1)
        {
            if (achSaves[60] != 1)
            {
                achSaves[60] = 1;
                purchaseGolden.SetActive(true);
                TriggerAch("PurchaseGoldeTouch");
            }
        }
        #endregion

        #region scroll
        if (UseConsumable.scrollCount >= 1)
        {
            if (achSaves[61] != 1)
            {
                achSaves[61] = 1;
                purchaseScroll.SetActive(true);
                TriggerAch("PurchaseScroll");
            }
        }
        #endregion

        #region key
        if (UseConsumable.KeysCount >= 1)
        {
            if (achSaves[62] != 1)
            {
                achSaves[62] = 1;
                purchaseKey.SetActive(true);
                TriggerAch("PurchaseKey");
            }
        }
        #endregion

        #region elixir
        if (UseConsumable.elixirCount >= 1)
        {
            if (achSaves[63] != 1)
            {
                achSaves[63] = 1;
                purchaseElixir.SetActive(true);
                TriggerAch("PurchaseElixir");
            }
        }
        #endregion

        #region relic
        if (UseConsumable.relicCount >= 1)
        {
            if (achSaves[64] != 1)
            {
                achSaves[64] = 1;
                purchaseRelic.SetActive(true);
                TriggerAch("PurchaseRelic");
            }
        }
        #endregion

        #region enchantedHammer
        if (UpdateGame.knifeCount >= 1)
        {
            if (newAchEnchantedHammer != 1)
            {
                newAchEnchantedHammer = 1;
                purchaseEnchantedHammer.SetActive(true);
                TriggerAch("enchantedHammer");
            }
        }
        #endregion

        //Chests
        #region Chest1
        if (Stats.chestOpened >= 1)
        {
            if (achSaves[65] != 1)
            {
                achSaves[65] = 1;
                openChests1.SetActive(true);
                TriggerAch("Open1Chest");
            }
        }
        #endregion

        #region Chest100
        if (Stats.chestOpened >= 100)
        {
            if (achSaves[66] != 1)
            {
                achSaves[66] = 1;
                openChests2.SetActive(true);
                TriggerAch("Open100Chests");
            }
        }
        #endregion

        #region Chest1000
        if (Stats.chestOpened >= 1000)
        {
            if (achSaves[67] != 1)
            {
                achSaves[67] = 1;
                openChests3.SetActive(true);
                TriggerAch("Open1000Chests");
            }
        }
        #endregion

        #region Chest10000
        if (Stats.chestOpened >= 10000)
        {
            if (achSaves[68] != 1)
            {
                achSaves[68] = 1;
                openChests4.SetActive(true);
                TriggerAch("Open10000Chests");
            }
        }
        #endregion

        #region Chest100000
        if (Stats.chestOpened >= 100000)
        {
            if (achSaves[69] != 1)
            {
                achSaves[69] = 1;
                openChests5.SetActive(true);
                TriggerAch("Open100000Chests");
            }
        }
        #endregion

        #region Chest200000
        if (Stats.chestOpened >= 200000)
        {
            if (achSaves[70] != 1)
            {
                achSaves[70] = 1;
                openChests6.SetActive(true);
                TriggerAch("Open250000Chests");
            }
        }
        #endregion

        #region purchaseChest2
        if (UnlockChests.timesPurchasedChests == 1)
        {
            if (achSaves[71] != 1)
            {
                achSaves[71] = 1;
                purchaseChest2.SetActive(true);
                TriggerAch("PurchaseChest2");
            }
        }
        #endregion

        #region purchaseChest5
        if (UnlockChests.timesPurchasedChests == 4)
        {
            if (achSaves[72] != 1)
            {
                achSaves[72] = 1;
                purchaseChest5.SetActive(true);
                TriggerAch("PurchaseChest5");
            }
        }
        #endregion

        #region purchaseChest8
        if (UnlockChests.timesPurchasedChests == 7)
        {
            if (achSaves[73] != 1)
            {
                achSaves[73] = 1;
                purchaseChest8.SetActive(true);
                TriggerAch("PurchaseChest8");
            }
        }
        #endregion

        #region purchaseChest12
        if (UnlockChests.timesPurchasedChests == 11)
        {
            if (achSaves[74] != 1)
            {
                achSaves[74] = 1;
                purchaseChest12.SetActive(true);
                TriggerAch("PurchaseChest12");
            }
        }
        #endregion

        #region purchaseChest15
        if (UnlockChests.timesPurchasedChests == 14)
        {
            if (achSaves[75] != 1)
            {
                achSaves[75] = 1;
                purchaseChest15.SetActive(true);
                TriggerAch("PurchaseChest15");
            }
        }
        #endregion

        #region purchaseChest20
        if (UnlockChests.timesPurchasedChests == 19)
        {
            if (achSaves[76] != 1)
            {
                achSaves[76] = 1;
                purchaseChest20.SetActive(true);
                TriggerAch("PurchaseChest20");
            }
        }
        #endregion

        #region purchaseChest24
        if (UnlockChests.timesPurchasedChests == 23)
        {
            if (achSaves[77] != 1)
            {
                achSaves[77] = 1;
                purchaseChest24.SetActive(true);
                TriggerAch("PurchaseChest24");
            }
        }
        #endregion

        #region purchaseChest32
        if (UnlockChests.timesPurchasedChests == 31)
        {
            if (newAchPurchaseChest32 != 1)
            {
                newAchPurchaseChest32 = 1;
                purchaseChest32.SetActive(true);
                TriggerAch("purchaseChest32");
            }
        }
        #endregion

        #region purchaseChest37
        if (UnlockChests.timesPurchasedChests >= 36)
        {
            if (newAchChest37 != 1)
            {
                newAchChest37 = 1;
                purchaseChest37.SetActive(true);
                TriggerAch("chest37");
            }
        }
        #endregion

        #region purchaseChest39
        if (UnlockChests.timesPurchasedChests == 39)
        {
            if (achSaves[78] != 1)
            {
                achSaves[78] = 1;
                purchaseChest27.SetActive(true);
                TriggerAch("PurchaseChestFINAL");
            }
        }
        #endregion

        #region openFinalChest
        if (HealthBar.openFinalChest == true)
        {
            if (achSaves[79] != 1)
            {
                achSaves[79] = 1;
                openFinalChest.SetActive(true);
                TriggerAch("OpenLastChest");
            }
        }
        #endregion

        //Reinforced
        #region reinforced1
        if (Stats.reinforedChestsOpened >= 1)
        {
            if (achSaves[80] != 1)
            {
                achSaves[80] = 1;
                openReinforcedChest1.SetActive(true);
                TriggerAch("Open1Reinforced");
            }
        }
        #endregion

        #region reinforced100
        if (Stats.reinforedChestsOpened >= 100)
        {
            if (achSaves[81] != 1)
            {
                achSaves[81] = 1;
                openReinforcedChest2.SetActive(true);
                TriggerAch("Open100Reinforced");
            }
        }
        #endregion

        #region reinforced500
        if (Stats.reinforedChestsOpened >= 500)
        {
            if (achSaves[82] != 1)
            {
                achSaves[82] = 1;
                openReinforcedChest3.SetActive(true);
                TriggerAch("Open1000Reinforced");
            }
        }
        #endregion

        #region reinforced1000
        if (Stats.reinforedChestsOpened >= 1000)
        {
            if (achSaves[83] != 1)
            {
                achSaves[83] = 1;
                openReinforcedChest4.SetActive(true);
                TriggerAch("Open10000Reinfoced");
            }
        }
        #endregion

        #region reinforced2500
        if (Stats.reinforedChestsOpened >= 2500)
        {
            if (newAch2500Reinforced != 1)
            {
                newAch2500Reinforced = 1;
                reinforcedChests2500.SetActive(true);
                TriggerAch("reinforced2500");
            }
        }
        #endregion

        //Enchanted and boss chests
        #region 100EnchantedGoldenCHest
        if (Stats.enchantedGoldenChestsOpened >= 100)
        {
            if (newAch100EnchantedChest != 1)
            {
                newAch100EnchantedChest = 1;
                enchantedGoldenChest100.SetActive(true);
                TriggerAch("enchanted100");
            }
        }
        #endregion

        #region 100EBosschest
        if (Stats.bossChestOpened >= 100)
        {
            if (newAch100BossChest != 1)
            {
                newAch100BossChest = 1;
                bossChest100.SetActive(true);
                TriggerAch("bossChest100");
            }
        }
        #endregion

        //Skillpoints and level
        #region 50SkillPoints
        if (Stats.totalSkillPoints >= 50)
        {
            if (achSaves[84] != 1)
            {
                achSaves[84] = 1;
                skillPoints1.SetActive(true);
                TriggerAch("SkillPoints50");
            }
        }
        #endregion

        #region 500SkillPoints
        if (Stats.totalSkillPoints >= 500)
        {
            if (achSaves[85] != 1)
            {
                achSaves[85] = 1;
                skillPoints2.SetActive(true);
                TriggerAch("SkillPoints500");
            }
        }
        #endregion

        #region 1000SkillPoints
        if (Stats.totalSkillPoints >= 1000)
        {
            if (achSaves[86] != 1)
            {
                achSaves[86] = 1;
                skillPoints3.SetActive(true);
                TriggerAch("SkillPoints1000");
            }
        }
        #endregion

        #region 10000SkillPoints
        if (Stats.totalSkillPoints >= 10000)
        {
            if (achSaves[87] != 1)
            {
                achSaves[87] = 1;
                skillPoints4.SetActive(true);
                TriggerAch("SkillPoints10000");
            }
        }
        #endregion

        #region 20000SkillPoints
        if (Stats.totalSkillPoints >= 20000)
        {
            if (newAch20KSkillPoints != 1)
            {
                newAch20KSkillPoints = 1;
                skillPoints20K.SetActive(true);
                TriggerAch("skillPoints2000");
            }
        }
        #endregion


        #region level10
        if (PlayerLevel.playerLevel >= 10)
        {
            if (achSaves[88] != 1)
            {
                achSaves[88] = 1;
                level10.SetActive(true);
                TriggerAch("level10");
            }
        }
        #endregion

        #region level25
        if (PlayerLevel.playerLevel >= 25)
        {
            if (achSaves[89] != 1)
            {
                achSaves[89] = 1;
                level25.SetActive(true);
                TriggerAch("level25");
            }
        }
        #endregion

        #region level50
        if (PlayerLevel.playerLevel >= 50)
        {
            if (achSaves[90] != 1)
            {
                achSaves[90] = 1;
                level50.SetActive(true);
                TriggerAch("level50");
            }
        }
        #endregion

        #region level100
        if (PlayerLevel.playerLevel >= 100)
        {
            if (achSaves[91] != 1)
            {
                achSaves[91] = 1;
                level100.SetActive(true);
                TriggerAch("level100");
            }
        }
        #endregion

        #region level150
        if (PlayerLevel.playerLevel >= 150)
        {
            if (newAchLevel150 != 1)
            {
                newAchLevel150 = 1;
                level150.SetActive(true);
                TriggerAch("level150");
            }
        }
        #endregion

        #region level200
        if (PlayerLevel.playerLevel >= 200)
        {
            if (newAchLevel200 != 1)
            {
                newAchLevel200 = 1;
                level200.SetActive(true);
                TriggerAch("level200");
            }
        }
        #endregion
    }
}
