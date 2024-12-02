using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameDataJSON 
{
    //First time playing.
    //Set all variables properly
    public GameDataJSON()
    {
        //Debug.Log("Load JSON saves");
        SavedFirstPlayed();
        SavedGoldAmount();
        SavePurchasedChests();
        SavedTreasures();
        SavedCursors();
        SavedPassiveDamage();
        SavedItems();
        SavedShop();
        SavedLeveLAndSkillPoints();
        SavedStats();
        SavedTreasureDropChance();
        SavedRareTreasurs();
        SavedSkillTree();
        SavedAchievements();
        NewHighNumberVariables();
        NewUpdate1NewSaves();
    }

    #region FirstTimePlayed
    public int firstTimePlayed;
    public int totalStuffOnScreen;
    public int returnInstantlyToTotal;
    public bool onlyLoadNewSave;

    public void SavedFirstPlayed()
    {
        this.firstTimePlayed = 0;
        this.totalStuffOnScreen = 75;
        this.returnInstantlyToTotal = 0;
        this.onlyLoadNewSave = false;
    }
    #endregion

    #region TotalGold
    public float totalGold;
    public void SavedGoldAmount()
    {
        this.totalGold = 0;
    }
    #endregion

    #region PurchasedChests
    public int purchasedChest2, purchasedChest3, purchasedChest4, purchasedChest5, purchasedChest6, purchasedChest7, purchasedChest8, purchasedChest9, purchasedChest10, purchasedChest11, purchasedChest12, purchasedChest13, purchasedChest14, purchasedChest15, purchasedChest16, purchasedChest17, purchasedChest18, purchasedChest19, purchasedChest20, purchasedChest21, purchasedChest22, purchasedChest23, purchasedChest24, purchasedChest25, purchasedChest26, purchasedChest27;

    public int timesPurchasedChests;

    public void SavePurchasedChests()
    {
        timesPurchasedChests = 0;

        this.purchasedChest2 = 0;
        this.purchasedChest3 = 0;
        this.purchasedChest4 = 0;
        this.purchasedChest5 = 0;
        this.purchasedChest6 = 0;
        this.purchasedChest7 = 0;
        this.purchasedChest8 = 0;
        this.purchasedChest9 = 0;
        this.purchasedChest10 = 0;
        this.purchasedChest11 = 0;
        this.purchasedChest12 = 0;
        this.purchasedChest13 = 0;
        this.purchasedChest14 = 0;
        this.purchasedChest15 = 0;
        this.purchasedChest16 = 0;
        this.purchasedChest17 = 0;
        this.purchasedChest18 = 0;
        this.purchasedChest19 = 0;
        this.purchasedChest20 = 0;
        this.purchasedChest21 = 0;
        this.purchasedChest22 = 0;
        this.purchasedChest23 = 0;
        this.purchasedChest24 = 0;
        this.purchasedChest25 = 0;
        this.purchasedChest26 = 0;
        this.purchasedChest27 = 0;
    }
    #endregion

    #region Treasures
    public int redRubyCount;
    public int amethystCount;
    public int diamondCount;
    public int violetCount;
    public int yellowSapphireCount;
    public int greenDiamondCount;
    public int grandidieriteCount;
    public int purpleRupeeCount;
    public int pinkPlortCount;
    public int emeraldCount;
    public int quartzCount;
    public int redGarnetCount;
    public int pinkTourmalineCount;
    public int yellowTopazCount;
    public int aquamarineCount;
    public int fireOpalCount;
    public int goldenSeaPearlCount;
    public int akoyaPearlCount;
    public int gemSilicaCount;
    public int adventurineCount;
    public int kyaniteCount;
    public int albiteCount;
    public int blackOpalCount;
    public int painiteCount;
    public int tanzaniteCount;

    public int redRubyFirst;
    public int amethystFirst;
    public int diamondFirst;
    public int violetFirst;
    public int yellowSapphireFirst;
    public int greenDiamondFirst;
    public int grandideriteFirst;
    public int purpleRupeeFirst;
    public int pinkPlortFirst;
    public int emeraldFirst;
    public int quartzFirst;
    public int redGarnetFirst;
    public int pinkTourmalineFirst;
    public int yellowTopazFirst;
    public int aquamarineFirst;
    public int fireOpalFirst;
    public int goldenSeaPearlFirst;
    public int akoyaPearlFirst;
    public int gemSilicaFirst;
    public int adventurineFirst;
    public int kyaniteFirst;
    public int albiteFirst;
    public int blackOpalFirst;
    public int painiteFirst;
    public int tanzaniteFirst;

    public int astraliumCount, astraliumBoughtFirstTime;
    public int elysiumPrismCount, elysiumPrismBoughtFirstTime;
    public int aetherfireOpalCount, aetherfireOpalBoughtFirstTime;
    public int eldritchStarstoneCount, eldritchStarstoneBoughtFirstTime;
    public int chronolithShardCount, chronolithShardBoughtFirstTime;
    public int sideriumEssenceCount, sideriumEssenceBoughtFirstTime;
    public int quasariteCount, quasariteBoughtFirstTime;
    public int radiantNovaStoneCount, radiantNovaStoneBoughtFirstTime;
    public int soluniumShardCount, soluniumShardBoughtFirstTime;

    public void SavedTreasures()
    {
        this.redRubyCount = 0;
        this.amethystCount = 0;
        this.diamondCount = 0;
        this.violetCount = 0;
        this.yellowSapphireCount = 0;
        this.greenDiamondCount = 0;
        this.grandidieriteCount = 0;
        this.purpleRupeeCount = 0;
        this.pinkPlortCount = 0;
        this.emeraldCount = 0;
        this.quartzCount = 0;
        this.redGarnetCount = 0;
        this.pinkTourmalineCount = 0;
        this.yellowTopazCount = 0;
        this.aquamarineCount = 0;
        this.fireOpalCount = 0;
        this.goldenSeaPearlCount = 0;
        this.akoyaPearlCount = 0;
        this.gemSilicaCount = 0;
        this.adventurineCount = 0;
        this.kyaniteCount = 0;
        this.albiteCount = 0;
        this.blackOpalCount = 0;
        this.painiteCount = 0;
        this.tanzaniteCount = 0;

        //New treasure count
        this.astraliumCount = 0;
        this.elysiumPrismCount = 0;
        this.aetherfireOpalCount = 0;
        this.eldritchStarstoneCount = 0;
        this.chronolithShardCount = 0;
        this.sideriumEssenceCount = 0;
        this.quasariteCount = 0;
        this.radiantNovaStoneCount = 0;
        this.soluniumShardCount = 0;

        this.redRubyFirst = 0;
        this.amethystFirst = 0;
        this.diamondFirst = 0;
        this.violetFirst = 0;
        this.yellowSapphireFirst = 0;
        this.greenDiamondFirst = 0;
        this.grandideriteFirst = 0;
        this.purpleRupeeFirst = 0;
        this.pinkPlortFirst = 0;
        this.emeraldFirst = 0;
        this.quartzFirst = 0;
        this.redGarnetFirst = 0;
        this.pinkTourmalineFirst = 0;
        this.yellowTopazFirst = 0;
        this.aquamarineFirst = 0;
        this.fireOpalFirst = 0;
        this.goldenSeaPearlFirst = 0;
        this.akoyaPearlFirst = 0;
        this.gemSilicaFirst = 0;
        this.adventurineFirst = 0;
        this.kyaniteFirst = 0;
        this.albiteFirst = 0;
        this.blackOpalFirst = 0;
        this.painiteFirst = 0;
        this.tanzaniteFirst = 0;

        //new
        this.astraliumBoughtFirstTime = 0;
        this.elysiumPrismBoughtFirstTime = 0;
        this.aetherfireOpalBoughtFirstTime = 0;
        this.eldritchStarstoneBoughtFirstTime = 0;
        this.chronolithShardBoughtFirstTime = 0;
        this.sideriumEssenceBoughtFirstTime = 0;
        this.quasariteBoughtFirstTime = 0;
        this.radiantNovaStoneBoughtFirstTime = 0;
        this.soluniumShardBoughtFirstTime = 0;
    }
    #endregion

    #region Cursors
    public float activeClickDamage;
    public float activeClickDamagePrice;
    public float passiveClickDamagePrice;

    public int activeClickPowerLevel;
    public int passiveClickPowerLvel;

    //cursor1
    public int cursor1Equipped;
    public int cursor1Level;
    public int cursor1QuartzPirce;
    public float cursor1ActiveDamageBuff;
    public float cursor1ActiveIncrement;

    //cursor2
    public int cursor2Equipped;
    public int cursor2Level;
    public int cursor2QuartzPrice;
    public float cursor2PassiveDamageBuff;
    public float cursor2PassiveIncrement;

    //Cursor3
    public int cursor3Equipped;
    public int cursor3Level;
    public int cursor3QuartzPrice;
    public int cursor3AmethystPrice;
    public float cursor3CritChanceBuff;
    public float cursor3CritChanceIncrement;
    public float cursor3CritDamageBuff;
    public float cursor3CritDamageIncrement;

    //Cursor4
    public float cursor4ActiveDamage;
    public float cursor4ActiveDamageIncrement;
    public float cursor4PassiveDamage;
    public float cursor4PassiveDamageIncrement;
    public int cursor4Level;
    public int cursor4Equipped;

    //Cursor5
    public float cursor5ActiveDamage;
    public float cursor5ActiveDamageIncrement;
    public float cursor5CritDamage;
    public float cursor5CritDamageIncrement;
    public float cursor5CritChance;
    public float cursor5CritChanceIncrement;
    public int cursor5Level;
    public int cursor5Equipped;

    //Cursor6
    public float cursor6ActiveDamage;
    public float cursor6ActiveDamageIncrement;
    public float cursor6PassiveDamage;
    public float cursor6PassiveDamageIncrement;
    public float cursor6CritDamage;
    public float cursor6CritDamageIncrement;
    public float cursor6CritChance;
    public float cursor6CritChanceIncrement;
    public int cursor6Level;
    public int cursor6Equipped;

    //Cursor7
    public float cursor7ActiveDamage;
    public float cursor7ActiveDamageIncrement;
    public float cursor7CritDamage;
    public float cursor7CritDamageIncrement;
    public float cursor7CritChance;
    public float cursor7CritChanceIncrement;
    public int cursor7Level;
    public int cursor7Equipped;

    //Cursor8
    public float cursor8ActiveDamage;
    public float cursor8ActiveDamageIncrement;
    public float cursor8PassiveDamage;
    public float cursor8PassiveDamageIncrement;
    public float cursor8CritDamage;
    public float cursor8CritDamageIncrement;
    public float cursor8CritChance;
    public float cursor8CritChanceIncrement;
    public int cursor8Level;
    public int cursor8Equipped;

    //Cursor9
    public float cursor9ActiveDamage;
    public float cursor9ActiveDamageIncrement;
    public float cursor9PassiveDamage;
    public float cursor9PassiveDamageIncrement;
    public int cursor9Level;
    public int cursor9Equipped;

    //Cursor10
    public int cursor10QuartzPrice;
    public float cursor10PassiveDamage;
    public float cursor10PassiveDamageIncrement;
    public int cursor10Level;
    public int cursor10Equipped;

    //Cursor11
    public int cursor11QuartzPrice;
    public float cursor11ActiveDamage;
    public float cursor11ActiveDamageIncrement;
    public float cursor11CritChance;
    public float cursor11CritChanceIncrement;
    public float cursor11CritDamage;
    public float cursor11CritDamageIncrement;
    public int cursor11Level;
    public int cursor11Equipped;

    //Cursor12
    public int cursor12QuartzPrice;
    public float cursor12ActiveDamage;
    public float cursor12ActiveDamageIncrement;
    public float cursor12PassiveDamage;
    public float cursor12PassiveDamageIncrement;
    public float cursor12CritChance;
    public float cursor12CritChanceIncrement;
    public float cursor12CritDamage;
    public float cursor12CritDamageIncrement;
    public int cursor12Level;
    public int cursor12Equipped;

    //Cursor13
    public float cursor13ActiveDamage;
    public float cursor13ActiveDamageIncrement;
    public float cursor13PassiveDamage;
    public float cursor13PassiveDamageIncrement;
    public float cursor13CritChance;
    public float cursor13CritChanceIncrement;
    public float cursor13CritDamage;
    public float cursor13CritDamageIncrement;
    public int cursor13Level;
    public int cursor13Equipped;

    //Cursor14
    public float cursor14ActiveDamage;
    public float cursor14ActiveDamageIncrement;
    public float cursor14PassiveDamage;
    public float cursor14PassiveDamageIncrement;
    public float cursor14CritChance;
    public float cursor14CritChanceIncrement;
    public float cursor14CritDamage;
    public float cursor14CritDamageIncrement;
    public int cursor14Level;
    public int cursor14Equipped;

    //Cursor15
    public float cursor15ActiveDamage;
    public float cursor15ActiveDamageIncrement;
    public float cursor15PassiveDamage;
    public float cursor15PassiveDamageIncrement;
    public float cursor15CritChance;
    public float cursor15CritChanceIncrement;
    public float cursor15CritDamage;
    public float cursor15CritDamageIncrement;
    public int cursor15Level;
    public int cursor15Equipped;

    //Cursor16
    public float cursor16ActiveDamage;
    public float cursor16ActiveDamageIncrement;
    public float cursor16PassiveDamage;
    public float cursor16PassiveDamageIncrement;
    public float cursor16CritChance;
    public float cursor16CritChanceIncrement;
    public float cursor16CritDamage;
    public float cursor16CritDamageIncrement;
    public int cursor16Level;
    public int cursor16Equipped;

    //Cursor17
    public float cursor17ActiveDamage;
    public float cursor17ActiveDamageIncrement;
    public float cursor17PassiveDamage;
    public float cursor17PassiveDamageIncrement;
    public float cursor17CritChance;
    public float cursor17CritChanceIncrement;
    public float cursor17CritDamage;
    public float cursor17CritDamageIncrement;
    public int cursor17Level;
    public int cursor17Equipped;

    //Cursor18
    public float cursor18ActiveDamage;
    public float cursor18ActiveDamageIncrement;
    public float cursor18PassiveDamage;
    public float cursor18PassiveDamageIncrement;
    public float cursor18CritChance;
    public float cursor18CritChanceIncrement;
    public float cursor18CritDamage;
    public float cursor18CritDamageIncrement;
    public int cursor18Level;
    public int cursor18Equipped;

    //Cursor 19
   
    public float cursor19ActiveDamage;
    public float cursor19ActiveDamageIncrement;
    public float cursor19PassiveDamage;
    public float cursor19PassiveDamageIncrement;
    public float cursor19CritChance;
    public float cursor19CritChanceIncrement;
    public float cursor19CritDamage;
    public float cursor19CritDamageIncrement;
    public int cursor19Level;
    public int cursor19Equipped;

    //Cursor 20
    public float cursor20ActiveDamage;
    public float cursor20ActiveDamageIncrement;
    public float cursor20PassiveDamage;
    public float cursor20PassiveDamageIncrement;
    public float cursor20CritChance;
    public float cursor20CritChanceIncrement;
    public float cursor20CritDamage;
    public float cursor20CritDamageIncrement;
    public int cursor20Level;
    public int cursor20Equipped;

    //Cursor 21
   
    public float cursor21ActiveDamage;
    public float cursor21ActiveDamageIncrement;
    public float cursor21PassiveDamage;
    public float cursor21PassiveDamageIncrement;
    public float cursor21CritChance;
    public float cursor21CritChanceIncrement;
    public float cursor21CritDamage;
    public float cursor21CritDamageIncrement;
    public int cursor21Level;
    public int cursor21Equipped;

    //Cursor4-19 Prices
    public int cursor4TopazPrice;
    public int cursor5AlbitePrice;
    public int cursor6albitePrice;
    public int cursor6RedGarnetPrice;
    public int cursor7AquamarinePrice;
    public int cursor8AquamarinePrice;
    public int cursor8YellopSapphirePrice;
    public int cursor9PinkTourmalinePrice;
    public int cursor10AdventurinePrice;
    public int cursor11AdventurinePrice;
    public int cursor11PinkTourmalinePrice;
    public int cursor12AdventurinePrice;
    public int cursor12RedRubyPrice;
    public int cursor13DiamondPrice;
    public int cursor13GrandideritePrice;
    public int cursor14VioletCrystalPrice;
    public int cursor14GrandideritePrice;
    public int cursor15AkoyaPearlPrice;
    public int cursor15PurpleRupeePrice;
    public int cursor15EmeraldPrice;
    public int cursor16GreenDiamondPrice;
    public int cursor16FireOpalPrice;
    public int cursor16GemSilicaPrice;
    public int cursor17PinkPlortPrice;
    public int cursor17GoldenSeaPearlPrice;
    public int cursor17KyanitePrice;
    public int cursor18BlackOpalPrice;
    public int cursor18PainitePrice;
    public int cursor18TanzanitePrice;
    public int cursor19AstraliumPrice;
    public int cursor19ElysiumPrismPrice;
    public int cursor19AerthfireOpalPrice;
    public int cursor20EldritchStarStonePrice;
    public int cursor20ChronolithShardPrice;
    public int cursor20SideriumEssencePrice;
    public int cursor21QuasaritePrice;
    public int cursor21RadiantNovaStonePrice;
    public int cursor21SoluniumShardPrice;

    public void SavedCursors()
    {
        //Saves for all cursor prices
        this.cursor1QuartzPirce = 1;
        this.cursor2QuartzPrice = 1;
        this.cursor3QuartzPrice = 1;
        this.cursor3AmethystPrice = 1;
        this.cursor4TopazPrice =1;
        this.cursor5AlbitePrice = 1;
        this.cursor6albitePrice = 1;
        this.cursor6RedGarnetPrice = 1;
        this.cursor7AquamarinePrice = 1;
        this.cursor8AquamarinePrice = 1;
        this.cursor8YellopSapphirePrice =1;
        this.cursor9PinkTourmalinePrice = 1;
        this.cursor10AdventurinePrice = 1;
        this.cursor11AdventurinePrice = 1;
        this.cursor11PinkTourmalinePrice = 1;
        this.cursor12AdventurinePrice = 1;
        this.cursor12RedRubyPrice = 1;
        this.cursor13DiamondPrice = 1;
        this.cursor13GrandideritePrice = 1;
        this.cursor14VioletCrystalPrice = 1;
        this.cursor14GrandideritePrice = 1;
        this.cursor15AkoyaPearlPrice = 1;
        this.cursor15PurpleRupeePrice = 1;
        this.cursor15EmeraldPrice = 1;
        this.cursor16GreenDiamondPrice = 1;
        this.cursor16FireOpalPrice = 1;
        this.cursor16GemSilicaPrice = 1;
        this.cursor17PinkPlortPrice = 1;
        this.cursor17GoldenSeaPearlPrice = 1;
        this.cursor17KyanitePrice = 1;
        this.cursor18BlackOpalPrice = 1;
        this.cursor18PainitePrice = 1;
        this.cursor18TanzanitePrice = 1;

        //New cursors
        this.cursor19AstraliumPrice = 1;
        this.cursor19ElysiumPrismPrice = 1;
        this.cursor19AerthfireOpalPrice = 1;
        this.cursor20EldritchStarStonePrice = 1;
        this.cursor20ChronolithShardPrice = 1;
        this.cursor20SideriumEssencePrice = 1;
        this.cursor21QuasaritePrice = 1;
        this.cursor21RadiantNovaStonePrice = 1;
        this.cursor21SoluniumShardPrice = 1;

        //General Click damage
        this.activeClickDamage = 1;

        //Price of active and passive damage
        this.activeClickDamagePrice = 5;
        this.passiveClickDamagePrice = 10;

        //Passive and active levels
        this.activeClickPowerLevel = 0;
        this.passiveClickPowerLvel = 0;

        this.cursor1Level = 1;
        this.cursor2Level = 1;
        this.cursor3Level = 1;
        this.cursor4Level = 1;
        this.cursor5Level = 1;
        this.cursor6Level = 1;
        this.cursor7Level = 1;
        this.cursor8Level = 1;
        this.cursor9Level = 1;
        this.cursor10Level = 1;
        this.cursor11Level = 1;
        this.cursor12Level = 1;
        this.cursor13Level = 1;
        this.cursor14Level = 1;
        this.cursor15Level = 1;
        this.cursor16Level = 1;
        this.cursor17Level = 1;
        this.cursor18Level = 1;

        //New cursors
        this.cursor19Level = 1;
        this.cursor20Level = 1;
        this.cursor21Level = 1;

        this.cursor1Equipped = 0;
        this.cursor2Equipped = 0;
        this.cursor3Equipped = 0;
        this.cursor4Equipped = 0;
        this.cursor5Equipped = 0;
        this.cursor6Equipped = 0;
        this.cursor7Equipped = 0;
        this.cursor8Equipped = 0;
        this.cursor9Equipped = 0;
        this.cursor10Equipped = 0;
        this.cursor11Equipped = 0;
        this.cursor12Equipped = 0;
        this.cursor13Equipped = 0;
        this.cursor14Equipped = 0;
        this.cursor15Equipped = 0;
        this.cursor16Equipped = 0;
        this.cursor17Equipped = 0;
        this.cursor18Equipped = 0;

        //New cursors
        this.cursor19Equipped = 0;
        this.cursor20Equipped = 0;
        this.cursor21Equipped = 0;


        //Cursor1
        this.cursor1ActiveDamageBuff = 0.05f;
        this.cursor1ActiveIncrement = 0.03f;

        //cursor2
        this.cursor2PassiveDamageBuff = 0.05f;
        this.cursor2PassiveIncrement = 0.03f;

        //Cursor3

        this.cursor3CritChanceBuff = 0.8f;
        this.cursor3CritChanceIncrement = 0.1f;
        this.cursor3CritDamageBuff = 2f;
        this.cursor3CritDamageIncrement = 0.3f;

        //Cursor4
        this.cursor4ActiveDamage = 0.11f;
        this.cursor4ActiveDamageIncrement = 0.06f;
        this.cursor4PassiveDamage = 0.11f;
        this.cursor4PassiveDamageIncrement = 0.06f;

        //Cursor5
        this.cursor5ActiveDamage = 0.25f;
        this.cursor5ActiveDamageIncrement = 0.08f;
        this.cursor5CritChance = 2f;
        this.cursor5CritChanceIncrement = 0.1f;
        this.cursor5CritDamage = 2.5f;
        this.cursor5CritDamageIncrement = 0.3f;

        //Cursor6
        this.cursor6ActiveDamage = 0.15f;
        this.cursor6ActiveDamageIncrement = 0.08f;
        this.cursor6PassiveDamage = 0.35f;
        this.cursor6PassiveDamageIncrement = 0.10f;
        this.cursor6CritChance = 1f;
        this.cursor6CritChanceIncrement = 0.1f;
        this.cursor6CritDamage = 4.1f;
        this.cursor6CritDamageIncrement = 0.2f;

        //Cursor7
        this.cursor7ActiveDamage = 0.70f;
        this.cursor7ActiveDamageIncrement = 0.15f;
        this.cursor7CritChance = 2.5f;
        this.cursor7CritChanceIncrement = 0.1f;
        this.cursor7CritDamage = 4.8f;
        this.cursor7CritDamageIncrement = 0.4f;

        //Cursor8
        this.cursor8ActiveDamage = 0.6f;
        this.cursor8ActiveDamageIncrement = 0.15f;
        this.cursor8PassiveDamage = 0.6f;
        this.cursor8PassiveDamageIncrement = 0.15f;
        this.cursor8CritChance = 1.4f;
        this.cursor8CritChanceIncrement = 0.1f;
        this.cursor8CritDamage = 6.2f;
        this.cursor8CritDamageIncrement = 0.5f;

        //Cursor9
        this.cursor9ActiveDamage = 1.5f;
        this.cursor9ActiveDamageIncrement = 0.35f;
        this.cursor9PassiveDamage = 1.5f;
        this.cursor9PassiveDamageIncrement = 0.35f;

        //Cursor10
        this.cursor10PassiveDamage = 3.2f;
        this.cursor10PassiveDamageIncrement = 0.60f;

        //Cursor11
        this.cursor11ActiveDamage = 1.7f;
        this.cursor11ActiveDamageIncrement = 0.4f;
        this.cursor11CritChance = 3.4f;
        this.cursor11CritChanceIncrement = 0.2f;
        this.cursor11CritDamage = 4f;
        this.cursor11CritDamageIncrement = 0.4f;

        //Cursor12
        this.cursor12ActiveDamage = 2.9f;
        this.cursor12ActiveDamageIncrement = 0.7f;
        this.cursor12PassiveDamage = 2.9f;
        this.cursor12PassiveDamageIncrement = 0.6f;
        this.cursor12CritChance = 2.9f;
        this.cursor12CritChanceIncrement = 0.2f;
        this.cursor12CritDamage = 6.7f;
        this.cursor12CritDamageIncrement = 0.4f;

        //Cursor13
        this.cursor13ActiveDamage = 5.2f;
        this.cursor13ActiveDamageIncrement = 1f;
        this.cursor13PassiveDamage = 3.7f;
        this.cursor13PassiveDamageIncrement = 0.8f;
        this.cursor13CritChance = 1.2f;
        this.cursor13CritChanceIncrement = 0.2f;
        this.cursor13CritDamage = 8.7f;
        this.cursor13CritDamageIncrement = 0.5f;


        //Cursor14
        this.cursor14ActiveDamage = 5f;
        this.cursor14ActiveDamageIncrement = 1.8f;
        this.cursor14PassiveDamage = 7f;
        this.cursor14PassiveDamageIncrement = 1.2f;
        this.cursor14CritChance = 3f;
        this.cursor14CritChanceIncrement = 0.3f;
        this.cursor14CritDamage = 9.3f;
        this.cursor14CritDamageIncrement = 0.8f;

        //Cursor15
        this.cursor15ActiveDamage = 8.5f;
        this.cursor15ActiveDamageIncrement = 2.1f;
        this.cursor15PassiveDamage = 8.5f;
        this.cursor15PassiveDamageIncrement = 1.8f;
        this.cursor15CritChance = 1.8f;
        this.cursor15CritChanceIncrement = 0.1f;
        this.cursor15CritDamage = 14f;
        this.cursor15CritDamageIncrement = 1f;

        //Cursor16
        this.cursor16ActiveDamage = 8.8f;
        this.cursor16ActiveDamageIncrement  = 3f;
        this.cursor16PassiveDamage = 10f;
        this.cursor16PassiveDamageIncrement = 2.8f;
        this.cursor16CritChance = 3.9f;
        this.cursor16CritChanceIncrement = 0.3f;
        this.cursor16CritDamage = 13f;
        this.cursor16CritDamageIncrement = 1.3f;

        //Cursor17
        this.cursor17ActiveDamage = 11f;
        this.cursor17ActiveDamageIncrement = 2.7f;
        this.cursor17PassiveDamage = 11f;
        this.cursor17PassiveDamageIncrement = 3.6f;
        this.cursor17CritChance = 3f;
        this.cursor17CritChanceIncrement = 0.3f;
        this.cursor17CritDamage = 16f;
        this.cursor17CritDamageIncrement = 2.0f;

        //Cursor18
        this.cursor18ActiveDamage = 15f;
        this.cursor18ActiveDamageIncrement = 3.9f;
        this.cursor18PassiveDamage = 15f;
        this.cursor18PassiveDamageIncrement = 4.0f;
        this.cursor18CritChance = 4.3f;
        this.cursor18CritChanceIncrement = 0.5f;
        this.cursor18CritDamage = 18f;
        this.cursor18CritDamageIncrement = 2.2f;

        //New cursors

        //Cursor19
        this.cursor19ActiveDamage = 24f;
        this.cursor19ActiveDamageIncrement = 4f;
        this.cursor19PassiveDamage = 27f;
        this.cursor19PassiveDamageIncrement = 5.5f;
        this.cursor19CritChance = 6f;
        this.cursor19CritChanceIncrement = 0.8f;
        this.cursor19CritDamage = 32f;
        this.cursor19CritDamageIncrement = 7f;

        //Cursor20
        this.cursor20ActiveDamage = 49f;
        this.cursor20ActiveDamageIncrement = 9f;
        this.cursor20PassiveDamage = 45f;
        this.cursor20PassiveDamageIncrement = 9f;
        this.cursor20CritChance = 4f;
        this.cursor20CritChanceIncrement = 0.4f;
        this.cursor20CritDamage = 50f;
        this.cursor20CritDamageIncrement = 10f;

        //Cursor19
        this.cursor21ActiveDamage = 75f;
        this.cursor21ActiveDamageIncrement = 10f;
        this.cursor21PassiveDamage = 75f;
        this.cursor21PassiveDamageIncrement = 10f;
        this.cursor21CritChance = 8f;
        this.cursor21CritChanceIncrement = 0.7f;
        this.cursor21CritDamage = 100f;
        this.cursor21CritDamageIncrement = 10f;
    }
    #endregion

    #region PassiveDamage
    public float passiveDamage;
    public void SavedPassiveDamage()
    {
        this.passiveDamage = 0;
    }
    #endregion

    #region Items
    public int keysCount;
    public int hammerCount;
    public int goldenTouchCount;
    public int lockPickCount;
    public int treasureBagCount;
    public int XPPotionCount;
    public int damagePotionCount;
    public int lootPotionCount;
    public int elixirCount;
    public int scrollCount;
    public int gauntletCount;
    public int relicCount;

    public float lockPickSuccessChance;
    public float hammerDamageMultiplier;

    public float scrollActiveDamageBuff, scrollPassiveDamageBuff, scrollCritChanceBuff, scrollCritDamageBuff, scrollGoldBuff, scrollXPBuff, scrollTreasureBuff;

    public float relicPermaActiveDamage, relicPermaPassiveDamage, relicPermaCritDamage, relicPermaCritChance, relicPermaGoldBuff, relicPermaTreasureBuff, relicPermaXPBuff;
    public void SavedItems()
    {
        this.keysCount = 0;
        this.hammerCount = 0;
        this.goldenTouchCount = 0;
        this.lockPickCount = 0;
        this.treasureBagCount = 0;
        this.XPPotionCount = 0;
        this.damagePotionCount = 0;
        this.lootPotionCount = 0;
        this.elixirCount = 0;
        this.scrollCount = 0;
        this.gauntletCount = 0;
        this.relicCount = 0;

        this.lockPickSuccessChance = 30;
        this.hammerDamageMultiplier = 3.5f;

        this.scrollActiveDamageBuff = 0;
        this.scrollPassiveDamageBuff = 0;
        this.scrollCritChanceBuff = 0;
        this.scrollCritDamageBuff = 0;
        this.scrollGoldBuff = 0;
        this.scrollXPBuff = 0;
        this.scrollTreasureBuff = 0;

        this.scrollTreasureBuff = 0;
        this.relicPermaPassiveDamage = 0;
        this.relicPermaCritDamage = 0;
        this.relicPermaCritChance = 0;
        this.relicPermaGoldBuff = 0;
        this.relicPermaTreasureBuff = 0;
        this.relicPermaXPBuff = 0;
    }
    #endregion

    #region Shop
    public int lockPickLevel, hammerLevel, keyLevel, goldenTouchLevel, treasureBagLevel, xpPotionLevel, damagePotionLevel, lootPotionLevel, elixirLevel, scrollLevel, gauntletLevel, relicLevel;

    public int keyBoughtFirstTime;
    public int hammerBoughtFirstTime;
    public int goldenTouchBoughtFirstTime;
    public int lockPickBoughtFirstTime;
    public int treasureBagBoughtFirstTime;
    public int XPPotionBoughtFirstTime;
    public int damagePotionBoughtFirstTime;
    public int lootPotionBOughtFirstTime;
    public int miniChestBoughtFirsTTime;
    public int elixirBoughtFirsTTime;
    public int scrollBoughtFirsTTime;
    public int gauntletBoughtFirsTTime;
    public int relicBoughtFirsTTime;

    public int keyGemPrice, hammerGemPrice, goldenTouchGemPrice, lockPickgemPrice, treasurebagGemPrice, xpPotionGemPrice, damagePotionGemPrice, lootPotionGemPrice, elixirGemPrice, scrollGemPrice, gauntletGemPrice, relicGemPrice, relicGemPrice2;
    public float keyPrice, hammerPrice, goldenTouchPrice, lockPickPrice, treasureBagPrice, xpPotionPrice, damagePotionPrice, lootPotionPrice, elixirPrice, scrollPrice, gauntletPrice, relicPrice;

    public float lockPickDropChance, hammerDropChance, keyDropChance, goldenTouchDropChance, treasureBagDropChance, XPPotiondropChance, damagepotionDropChance, lootPotionDropChance, elixirDropChance, scrollDropChance, gauntletDropChance, relicDropChance;

    public float lockPickDropChanceIncrement, hammerDropChanceIncrement, keyDropChanceIncrement, goldenTouchDropChanceIncrement, treasureBagDropChanceIncrement, XPPotiondropChanceIncrement, damagepotionDropChanceIncrement, lootPotionDropChanceIncrement, elixirDropChanceIncrement, scrollDropChanceIncrement, gauntletDropChanceIncrement, relicDropChanceIncrement;

    public float lockPickOpenChanceIncrement, keyRareDropChance, keyRareDropChanceIncrement, hammerDamageAmountIncrement, hammerTimer, hammerTimerIncrement, goldenTouchTimer, goldenTouchTimerIncrement, xpPotionBuff, xpPotionBuffIncrement, xpPotionTimer, XPPotionTimerMinus, damagePotionBuff, damagePotionBuffIncrement, damagePotionTimer, damagePotionTimerMinus, lootPotionBuff, lootPotionBuffIncrement, lootPotionTimer, lootPotionTimerIncrement;

    public float elixirBuff, elixirBuffIncrement, elixirTimer, elixirTimerIncrement;
    public float scrollTimer, scrollTimerIncrement;
    public float gauntletTimer, gauntletTimerIncrement, gauntletGoldDropChance, gauntletGoldDropChanceIncrement;

    public float miniChestPrice;
    public int miniChestGemPrice, miniChestLevel, miniChestTimer, miniChestTimerIncrement;

    public void SavedShop()
    {
        this.lockPickLevel = 1;
        this.hammerLevel = 1;
        this.lootPotionLevel = 1;
        this.damagePotionLevel = 1;
        this.xpPotionLevel = 1;
        this.goldenTouchLevel = 1;
        this.miniChestLevel = 1;
        this.keyLevel = 1;
        this.treasureBagLevel = 1;
        this.scrollLevel = 1;
        this.gauntletLevel = 1;
        this.elixirLevel = 1;
        this.relicLevel = 1;

        this.lockPickBoughtFirstTime = 0; this.hammerBoughtFirstTime = 0; this.lootPotionBOughtFirstTime = 0; this.damagePotionBoughtFirstTime = 0; this.XPPotionBoughtFirstTime = 0; this.goldenTouchBoughtFirstTime = 0; this.miniChestBoughtFirsTTime = 0; this.keyBoughtFirstTime = 0; this.treasureBagBoughtFirstTime = 0; this.scrollBoughtFirsTTime = 0; this.gauntletBoughtFirsTTime = 0; this.elixirBoughtFirsTTime = 0; this.relicBoughtFirsTTime = 0;

        this.lockPickgemPrice = 1; this.hammerGemPrice = 2; this.lootPotionGemPrice = 2; this.damagePotionGemPrice = 2; this.xpPotionGemPrice = 2; this.goldenTouchGemPrice = 2; this.miniChestGemPrice = 2; this.keyGemPrice = 1; this.treasurebagGemPrice = 1; this.scrollGemPrice = 2; this.gauntletGemPrice = 3; this.elixirGemPrice = 2; this.relicGemPrice = 3; this.relicGemPrice2 = 3;

        this.lockPickPrice = 20; this.hammerPrice = 500; this.lootPotionPrice = 1200; this.damagePotionPrice = 2500; this.xpPotionPrice = 11000; this.goldenTouchPrice = 140000; this.miniChestPrice = 1000000; this.keyPrice = 15000000; this.treasureBagPrice = 115000000; this.scrollPrice = 1500000000000; this.gauntletPrice = 500000000000000000000f; this.elixirPrice = 750000000000000000000000000f; this.relicPrice = 500000000000000000000000000000f;

        this.lockPickDropChance = 0.1f; this.hammerDropChance = 0.06f; this.lootPotionDropChance = 0.07f; this.damagepotionDropChance = 0.07f; this.XPPotiondropChance = 0.07f; this.goldenTouchDropChance = 0.04f; this.keyDropChance = 0.05f; this.treasureBagDropChance = 0.05f; this.scrollDropChance = 0.02f; this.gauntletDropChance = 0.015f; this.elixirDropChance = 0.03f; this.relicDropChance = 0.01f;

        this.lockPickDropChanceIncrement = 0.008f; this.hammerDropChanceIncrement = 0.006f; this.lootPotionDropChanceIncrement = 0.006f; this.damagepotionDropChanceIncrement = 0.006f; this.XPPotiondropChanceIncrement = 0.006f; this.goldenTouchDropChanceIncrement = 0.005f; this.keyDropChanceIncrement = 0.006f; this.treasureBagDropChanceIncrement = 0.02f; this.scrollDropChanceIncrement = 0.001f; this.gauntletDropChanceIncrement = 0.001f; this.elixirDropChanceIncrement = 0.003f; this.relicDropChanceIncrement = 0.001f;

        this.lockPickOpenChanceIncrement =1; this.keyRareDropChance = 8f; this.keyRareDropChanceIncrement = 0.8f; this.hammerDamageAmountIncrement = 0.35f; this.hammerTimer = 8f; this.hammerTimerIncrement = 1; this.goldenTouchTimer = 15; this.goldenTouchTimerIncrement = 1; this.xpPotionBuff = 0.60f; this.xpPotionBuffIncrement = 0.10f; this.xpPotionTimer = 30; this.XPPotionTimerMinus = 2; this.damagePotionBuff = 0.7f; this.damagePotionBuffIncrement = 0.10f; this.damagePotionTimer = 30; this.damagePotionTimerMinus = 2; this.lootPotionBuff = 0.75f; this.lootPotionBuffIncrement = 0.10f; this.lootPotionTimer = 30; this.lootPotionTimerIncrement = 2;

        this.elixirBuff = 0.7f; this.elixirBuffIncrement = 0.10f; this.elixirTimer = 25; this.elixirTimerIncrement = 1; this.scrollTimer = 10; this.scrollTimerIncrement = 1;
        this.gauntletTimer = 10; this.gauntletTimerIncrement = 1; this.gauntletGoldDropChance = 35; this.gauntletGoldDropChanceIncrement = 2;

        this.miniChestTimer = 300; this.miniChestTimerIncrement = 4;
    }
    #endregion

    #region Skill points and level

    public int skillPoints;
    public int playerLevel;
    public float experienceNeeded, experienceGained;

    public void SavedLeveLAndSkillPoints()
    {
        this.skillPoints = 0;
        this.playerLevel = 0;
        this.experienceGained = 0;
        this.experienceNeeded = 250;
    }
    #endregion

    #region Stats
    public int totalGoldCoins, totalTreasures, treasuresDoubled;
    public float totalGoldRecieved;

    public int chestsOpened, reinforcedChestsOpened;

    public int chestClicks, autoClicks, criticalHits, cursorUpgraded, coinsSpawnedFromClicks, treasuredSpawnedFromClicks;

    public int itemsUsed, itemsDropped, itemsPurchased, itemsUpgraded;

    public float treasureDropChanceIncrease;
    public int goldCoin5XDropped, goldCoins10XDropped;

    public int rareTreasureFound;

    public int totalSkillPoints;

    public int commonTreasures, uncommonTreasures, rareTreasures, veryRareTreasures, extremelyRareTreasures, legendaryTreasures;

    public int prestigedTimesCount, prestigeUpgradesPurchased, clickerUpgradePurchased, loungerUpgradesPurchased, pirateUpgradesPurchased, hoarderUpgradeesPurchased;

    public int enchantedGoldenChestsOpened, bossChestOpened, goldCoin25XDropped, goldCoin100XDropped, ultraTreasures, mythicTreasures, eternalTreasures, adventurereUpgradesPurchased;

    public double barrelOfGoldTotal;

    public void SavedStats()
    {
        this.totalGoldCoins = 0;
        this.totalTreasures = 0;
        this.treasuresDoubled = 0;
        this.totalGoldRecieved = 0;
        this.chestsOpened = 0;
        this.reinforcedChestsOpened = 0;
        this.chestClicks = 0;
        this.autoClicks = 0;
        this.criticalHits = 0;
        this.cursorUpgraded = 0;
        this.coinsSpawnedFromClicks = 0;
        this.treasuredSpawnedFromClicks = 0;
        this.itemsUsed = 0;
        this.itemsDropped = 0;
        this.itemsUpgraded = 0;
        this.treasureDropChanceIncrease = 0;
        this.goldCoin5XDropped = 0;
        this.goldCoins10XDropped = 0;
        this.rareTreasureFound = 0;
        this.totalSkillPoints = 0;
        this.commonTreasures = 0;
        this.uncommonTreasures = 0;
        this.rareTreasures = 0;
        this.veryRareTreasures = 0;
        this.extremelyRareTreasures = 0;
        this.legendaryTreasures = 0;
        this.prestigedTimesCount = 0;
        this.prestigeUpgradesPurchased = 0;
        this.clickerUpgradePurchased = 0;
        this.loungerUpgradesPurchased = 0;
        this.pirateUpgradesPurchased = 0;
        this.hoarderUpgradeesPurchased = 0;
        this.itemsPurchased = 0;

        //New stats
        this.enchantedGoldenChestsOpened = 0;
        this.bossChestOpened = 0;
        this.goldCoin25XDropped = 0;
        this.goldCoin100XDropped = 0;
        this.ultraTreasures = 0;
        this.mythicTreasures = 0;
        this.eternalTreasures = 0;
        this.adventurereUpgradesPurchased = 0;
        this.barrelOfGoldTotal = 0;
    }
    #endregion

    #region Treasure Drop Chance
    public float quartzBaseChance, amethystBaseChance, yellowTopazBaseChance, albiteBaseChance, redGarnetBaseChance, aquamarineBaseChance, yellowSapphireBaseChance, pinkTourmalineBaseChance, adventurineBaseChance, redGemCBaseChance, diamondBaseChance, grandidieriteBaseChance, violetBaseChance, akoyaPearlBaseChance, purpleRupeeBaseChance, emeraldDropBaseChance, greenDiamondBaseChance, fireOpalBaseChance, gemSilicaBaseChance, pinkPlortBaseChance, goldenSeaPearlBaseChance, kyaniteBaseChance, blackOpalBaseChance, painiteBaseChance, tanzaniteBaseChance, astraliumBaseChance, elysiumPrismBaseChance, aerthfireOpalBaseChance, eldrichStarStoneBaseChance, chronolithChardBaseChance, sideriumEssenceBaseChance, quasariteBaseChance, radiantNovaStoneBaseChance, soluniumShardBaseChance;

    public float doubleValueTreasure;

    public int prestigeKeyFound, prestigeChestFound;
    public void SavedTreasureDropChance()
    {
        this.quartzBaseChance = 1.6f; //Common
        this.amethystBaseChance = 1.6f; //Common
        this.yellowTopazBaseChance = 1.6f; //Common
        this.albiteBaseChance = 1.5f; //Common
        this.redGarnetBaseChance = 1.5f; //Common
        this.aquamarineBaseChance = 1.2f; //Uncommon
        this.yellowSapphireBaseChance = 1.2f;//Uncommon
        this.pinkTourmalineBaseChance = 1.15f;//Uncommon
        this.adventurineBaseChance = 1.15f;//Uncommon
        this.redGemCBaseChance = 1f;//Rare
        this.diamondBaseChance = 1f;//Rare
        this.grandidieriteBaseChance = 1f;//Rare
        this.violetBaseChance = 0.85f;//Rare
        this.akoyaPearlBaseChance = 0.85f;//Rare
        this.purpleRupeeBaseChance = 0.72f;//Very rare
        this.emeraldDropBaseChance = 0.72f;//Very rare
        this.greenDiamondBaseChance = 0.69f;//Very rare
        this.fireOpalBaseChance = 0.69f;//Very rare
        this.gemSilicaBaseChance = 0.65f;//Very rare
        this.pinkPlortBaseChance = 0.59f;//Extremely Rare
        this.goldenSeaPearlBaseChance = 0.54f;//Extremely Rare
        this.kyaniteBaseChance = 0.5f;//Extremely Rare
        this.blackOpalBaseChance = 0.15f;//Legendary
        this.painiteBaseChance = 0.15f;//Legendary
        this.tanzaniteBaseChance = 0.15f;//Legendary

        //New
        this.astraliumBaseChance = 0.11f;//Ultra
        this.elysiumPrismBaseChance = 0.11f;//Ultra
        this.aerthfireOpalBaseChance = 0.10f;//Ultra
        this.eldrichStarStoneBaseChance = 0.07f;//Mythic
        this.chronolithChardBaseChance = 0.07f;//Mythic
        this.sideriumEssenceBaseChance = 0.06f;//Mythic
        this.quasariteBaseChance = 0.03f;//Eternal
        this.radiantNovaStoneBaseChance = 0.03f;//Eternal
        this.soluniumShardBaseChance = 0.03f;//Eternal


        this.doubleValueTreasure = 0;
        this.prestigeKeyFound = 0;
        this.prestigeChestFound = 0;
    }
    #endregion

    #region RareTreasures
    public int skullFound, trophyFound, swordFound, ringFound, starFound, cloverFound, crownFound, bookFound, guitarFOund, talarianFound, runeFound, backPackFound, shieldFound, pillBottleFound, medalFound, cookieFound, presentFound, axeFound, coin100XFound, envelopeFound, potionFound, soulGemFound, scrollFound, brickFound, chickenFound;

    public bool choseChickenReward;

    public int choseActive, chosePassive, choseCritChance, choseCritDamage, choseXP, choseGold, choseTreasureChance;

    public void SavedRareTreasurs()
    {
        this.choseActive = 0;
        this.chosePassive = 0;
        this.choseCritChance = 0;
        this.choseCritDamage = 0;
        this.choseXP = 0;
        this.choseGold = 0;
        this.choseTreasureChance = 0;

        this.skullFound = 0;
        this.trophyFound = 0;
        this.swordFound = 0;
        this.ringFound = 0;
        this.starFound = 0;
        this.cloverFound = 0;
        this.crownFound = 0;
        this.bookFound = 0;
        this.guitarFOund = 0;
        this.talarianFound = 0;
        this.runeFound = 0;
        this.backPackFound = 0;
        this.shieldFound = 0;
        this.pillBottleFound = 0;
        this.medalFound = 0;
        this.cookieFound = 0;

        //NEW
        this.presentFound = 0;
        this.axeFound = 0;
        this.coin100XFound = 0;
        this.envelopeFound = 0;
        this.potionFound = 0;
        this.soulGemFound = 0;
        this.scrollFound = 0;
        this.brickFound = 0;
        this.chickenFound = 0;

        this.choseChickenReward = false;
    }
    #endregion

    #region SkillTree
    public int crit1Bought, crit2Bought, crit3Bought, crit4Bought, crit5Bought;
    public int active1Bought, active2Bought, active3Bought, active4Bought, active5Bought, active6Bought, active7Bought;
    public int activeCursor1Bought, activeCursor2Bought, activeCursor3Bought, activeCursor4Bought;

    public int autoClicker1Bought, autoClicker2Bought, autoClicker3Bought, autoClicker4Bought;
    public int autoDamage1Bought, autoDamage2Bought, autoDamage3Bought, autoDamage4Bought, autoDamage5Bought, autoDamage6Bought, autoDamage7Bought, autoDamage8Bought;
    public int autoCursor1Bought, autoCursor2Bought, autoCursor3Bought, autoCursor4Bought, autoCursor5Bought;

    public int gold1Bought, gold2Bought, gold3Bought, gold4Bought, gold5Bought, gold6Bought, gold7Bought, gold8Bought, gold9Bought;
    public int drops1Bought, drops2Bought, drops3Bought, drops4Bought, drops5Bought, drops6Bought, drops7Bought;
    public int xp1Bought, xp2Bought, xp3Bought, xp4Bought, xp5Bought, xp6Bought, xp7Bought, xp8Bought;

    public int levelSpecial1Bought, levelSpecial2Bought, levelSpecial3Bought, levelSpecial4Bought, levelSpecial5Bought;
    public int strongerSpecial1Bought, strongerSpecial2Bought, strongerSpecial3Bought, strongerSpecial4Bought, strongerSpecial5Bought, strongerSpecial6Bought, strongerSpecial7Bought;
    public int startWithItem1Bought, startWithItem2Bought, startWithItem3Bought, startWithItem4Bought;

    public float skillTreeCritChance, skillTreeCritDamage, skillTreeActiveDamage, active4GoldChance, active5TreasureChance, active6InstantlyOpenChance, skillTreePassiveDamage, skillTreeGold, skillTreeXP;

    public int crit4CritGoldChance, crit5CritTreasureChance;

    public float autoClicksPerSecond;
    public void SavedSkillTree()
    {
        this.crit1Bought = 0;
        this.crit2Bought = 0;
        this.crit3Bought = 0;
        this.crit4Bought = 0;
        this.crit5Bought = 0;

        this.active1Bought = 0;
        this.active2Bought = 0;
        this.active3Bought = 0;
        this.active4Bought = 0;
        this.active5Bought = 0;
        this.active6Bought = 0;
        this.active7Bought = 0;

        this.activeCursor1Bought = 0;
        this.activeCursor2Bought = 0;
        this.activeCursor3Bought = 0;
        this.activeCursor4Bought = 0;

        this.autoClicker1Bought = 0;
        this.autoClicker2Bought = 0;
        this.autoClicker3Bought = 0;
        this.autoClicker4Bought = 0;

        this.autoDamage1Bought = 0;
        this.autoDamage2Bought = 0;
        this.autoDamage3Bought = 0;
        this.autoDamage4Bought = 0;
        this.autoDamage5Bought = 0;
        this.autoDamage6Bought = 0;
        this.autoDamage7Bought = 0;
        this.autoDamage8Bought = 0;

        this.autoCursor1Bought = 0;
        this.autoCursor2Bought = 0;
        this.autoCursor3Bought = 0;
        this.autoCursor4Bought = 0;
        this.autoCursor5Bought = 0;

        this.gold1Bought = 0;
        this.gold2Bought = 0;
        this.gold3Bought = 0;
        this.gold4Bought = 0;
        this.gold5Bought = 0;
        this.gold6Bought = 0;
        this.gold7Bought = 0;
        this.gold8Bought = 0;
        this.gold9Bought = 0;

        this.drops1Bought = 0;
        this.drops2Bought = 0;
        this.drops3Bought = 0;
        this.drops4Bought = 0;
        this.drops5Bought = 0;
        this.drops6Bought = 0;
        this.drops7Bought = 0;

        this.xp1Bought = 0;
        this.xp2Bought = 0;
        this.xp3Bought = 0;
        this.xp4Bought = 0;
        this.xp5Bought = 0;
        this.xp6Bought = 0;
        this.xp7Bought = 0;
        this.xp8Bought = 0;

        this.levelSpecial1Bought = 0;
        this.levelSpecial2Bought = 0;
        this.levelSpecial3Bought = 0;
        this.levelSpecial4Bought = 0;
        this.levelSpecial5Bought = 0;

        this.strongerSpecial1Bought = 0;
        this.strongerSpecial2Bought = 0;
        this.strongerSpecial3Bought = 0;
        this.strongerSpecial4Bought = 0;
        this.strongerSpecial5Bought = 0;
        this.strongerSpecial6Bought = 0;
        this.strongerSpecial7Bought = 0;

        this.startWithItem1Bought = 0;
        this.startWithItem2Bought = 0;
        this.startWithItem3Bought = 0;
        this.startWithItem4Bought = 0;

        this.skillTreeCritChance = 0;
        this.skillTreeCritDamage = 0;
        this.skillTreeActiveDamage = 0;
        this.active4GoldChance = 0;
        this.active5TreasureChance = 0;
        this.active6InstantlyOpenChance = 0;
        this.skillTreePassiveDamage = 0;
        this.skillTreeGold = 0;
        this.skillTreeXP = 0;

        this.crit4CritGoldChance = 0;
        this.crit5CritTreasureChance = 0;

        this.autoClicksPerSecond = 0;
    }
    #endregion

    #region ACH
    public int[] achSaves = new int[92];

    public int newAch1Novemdecillion, newAch100EnchantedChest, newAch100BossChest, newAchLevel200, newAchAllAdventurer, newAchEnchantedHammer, newAchPurchaseChest32, newAch25XGoldCoin1000;

    public int newAch100XGoldCoin, newAch1Undecillion, newAch1Duodecillion, newAch1Tredecillion, newAch1Quattuordecillion, newAch1Quindecillion, newAch1Sexdecillion, newAch1Septendecillion, newAch1Octodecillion, newAchLevel150, newAch20KSkillPoints, newAch2MillionGoldCoins, newAch100KTreasures, newAch100Ultra, newAch100Mythic, newAch100Eternal, newAch2500Reinforced, newAchUseChicken, newAchChest37, newAch5X250KDrop;

    public void SavedAchievements()
    {
        this.newAch100XGoldCoin = 0;
        this.newAch1Undecillion = 0;
        this.newAch1Duodecillion = 0;
        this.newAch1Tredecillion = 0;
        this.newAch1Quattuordecillion = 0;
        this.newAch1Quindecillion = 0;
        this.newAch1Sexdecillion = 0;
        this.newAch1Septendecillion = 0;
        this.newAch1Octodecillion = 0;
        this.newAchLevel150 = 0;
        this.newAch20KSkillPoints = 0;
        this.newAch2MillionGoldCoins = 0;
        this.newAch100KTreasures = 0;
        this.newAch100Ultra = 0;
        this.newAch100Mythic = 0;
        this.newAch100Eternal = 0;
        this.newAch2500Reinforced = 0;
        this.newAchUseChicken = 0;
        this.newAchChest37 = 0;
        this.newAch5X250KDrop = 0;

        this.newAch1Novemdecillion = 0;
        this.newAch100EnchantedChest = 0;
        this.newAch100BossChest = 0;
        this.newAchLevel200 = 0;
        this.newAchAllAdventurer = 0;
        this.newAchEnchantedHammer = 0;
        this.newAchPurchaseChest32 = 0;
        this.newAch25XGoldCoin1000 = 0;

        this.achSaves[0] = 0;
        this.achSaves[1] = 0;
        this.achSaves[2] = 0;
        this.achSaves[3] = 0;
        this.achSaves[4] = 0;
        this.achSaves[5] = 0;
        this.achSaves[6] = 0;
        this.achSaves[7] = 0;
        this.achSaves[8] = 0;
        this.achSaves[9] = 0;
        this.achSaves[10] = 0;
        this.achSaves[11] = 0;
        this.achSaves[12] = 0;
        this.achSaves[13] = 0;
        this.achSaves[14] = 0;
        this.achSaves[15] = 0;
        this.achSaves[16] = 0;
        this.achSaves[17] = 0;
        this.achSaves[18] = 0;
        this.achSaves[19] = 0;
        this.achSaves[20] = 0;
        this.achSaves[21] = 0;
        this.achSaves[22] = 0;
        this.achSaves[23] = 0;
        this.achSaves[24] = 0;
        this.achSaves[25] = 0;
        this.achSaves[26] = 0;
        this.achSaves[27] = 0;
        this.achSaves[28] = 0;
        this.achSaves[29] = 0;
        this.achSaves[30] = 0;
        this.achSaves[31] = 0;
        this.achSaves[32] = 0;
        this.achSaves[33] = 0;
        this.achSaves[34] = 0;
        this.achSaves[35] = 0;
        this.achSaves[36] = 0;
        this.achSaves[37] = 0;
        this.achSaves[38] = 0;
        this.achSaves[39] = 0;
        this.achSaves[40] = 0;
        this.achSaves[41] = 0;
        this.achSaves[42] = 0;
        this.achSaves[43] = 0;
        this.achSaves[44] = 0;
        this.achSaves[45] = 0;
        this.achSaves[46] = 0;
        this.achSaves[47] = 0;
        this.achSaves[48] = 0;
        this.achSaves[49] = 0;
        this.achSaves[50] = 0;
        this.achSaves[51] = 0;
        this.achSaves[52] = 0;
        this.achSaves[53] = 0;
        this.achSaves[54] = 0;
        this.achSaves[55] = 0;
        this.achSaves[56] = 0;
        this.achSaves[57] = 0;
        this.achSaves[58] = 0;
        this.achSaves[59] = 0;
        this.achSaves[60] = 0;
        this.achSaves[61] = 0;
        this.achSaves[62] = 0;
        this.achSaves[63] = 0;
        this.achSaves[64] = 0;
        this.achSaves[65] = 0;
        this.achSaves[66] = 0;
        this.achSaves[67] = 0;
        this.achSaves[68] = 0;
        this.achSaves[69] = 0;
        this.achSaves[70] = 0;
        this.achSaves[71] = 0;
        this.achSaves[72] = 0;
        this.achSaves[73] = 0;
        this.achSaves[74] = 0;
        this.achSaves[75] = 0;
        this.achSaves[76] = 0;
        this.achSaves[77] = 0;
        this.achSaves[78] = 0;
        this.achSaves[79] = 0;
        this.achSaves[80] = 0;
        this.achSaves[81] = 0;
        this.achSaves[82] = 0;
        this.achSaves[83] = 0;
        this.achSaves[84] = 0;
        this.achSaves[85] = 0;
        this.achSaves[86] = 0;
        this.achSaves[87] = 0;
        this.achSaves[88] = 0;
        this.achSaves[89] = 0;
        this.achSaves[90] = 0;
        this.achSaves[91] = 0;
    }
    #endregion

    #region newDoubleNumbers
    public double totalGoldAmountNew, totalGoldAmountStatsNew, activeDamageTotal, passiveDamageTotal, activeDamagePriceTotal, passiveDamagePriceTotal;
    public double newLockPickPrice, newHammerPrice, newLootPotionPrice, newDamagePotionPrice, newXPPotionPrice, newGoldenTouchPrice, newMiniChestPrice, newkeyPrice, newTreasureBagPrice, newScrollPrice, newGauntletPrice, newElixirPRice, newRelicPrice;
    //21 New variables

    public void NewHighNumberVariables()
    {
        this.totalGoldAmountNew = 0;
        this.totalGoldAmountStatsNew = 0;
        this.activeDamageTotal = 1;
        this.passiveDamageTotal = 0;
        this.activeDamagePriceTotal = 5;
        this.passiveDamagePriceTotal = 10;
        this.newLockPickPrice = 20;
        this.newHammerPrice = 500;
        this.newLootPotionPrice = 1200;
        this.newDamagePotionPrice = 2500;
        this.newXPPotionPrice = 11000;
        this.newGoldenTouchPrice = 140000;
        this.newMiniChestPrice = 1000000;
        this.newkeyPrice = 15000000;
        this.newTreasureBagPrice = 115000000;
        this.newScrollPrice = 1500000000000;
        this.newGauntletPrice = 500000000000000000000f;
        this.newElixirPRice = 750000000000000000000000000f;
        this.newRelicPrice = 500000000000000000000000000000f;
    }
    #endregion

    #region NewUpdateSaves
    //Reinforced chests
    public float reinforcedPrestigeChanceIncrease;
    public int reinforcedChestHealth;
    public int reinforcedChestGoldIncrease, reinforcedXPIncrease;

    //New chests
    public float enchantedGoldenChestChance, bossChestChance;
    public int enchantedGoldenChestHealth, bossChestHealth;
    public int bossChestGoldAmount;
    public int enchantedGoldenChestTreasureDrops, bossChestGoldCoinsDrops, bossChestGoldValue;
    public int enchantedGoldenChestXPDrops, bossChestXPDrops;

    //Items
    public int knifeBoughtFirstTime, barrelBoughtFirstTime, treasurePotionBoughtFirstTime, mimicChestBoughtFirstTime;
    public float knifeDropChance, knifeDropChanceIncrement, treasurePotionDropChance, treasurePotionDropChanceIncrement;
    public double knifeBuyPriceDouble, barrelBuyPriceDouble, treasurePotionBuyPriceDouble, mimicChestBuyPriceDouble;
    public int knifeLevel, barrelLevel, treasurePotionLevel, mimicChestLevel;
    public int knifeGemPrice, knifeGemPrice2, barrelGemPrice, treasurePotionGemPrice, treasurePotionGemPrice2, mimicChestGemPrice;

    public int mimicPositiveBuffChance, mimicPositiveBiffChanceIncrement, mimicNegativeBuffChance, mimicNegativeBuffChanceIncrement, mimicChestTimer, mimicChestTimerIncrement;

    public int reinforced1Bought, reinforced2Bought, reinforced3Bought, reinforced4Bought, reinforced5Bought;
    public int greaterLoot1Bought, greaterLoot2Bought, greaterLoot3Bought, greaterLoot4Bought, greaterLoot5Bought;
    public int newChests1Bought, newChests2Bought, newChests3Bought, newChests4Bought, newChests5Bought, newChests6Bought;

    public double barrelOfGoldAmountDouble;

    public int knifeTimer, knifeTimerIncrement;
    public int knifeCount;
    public int treasurePotionTimer, treasurePotionTimerIncrement;
    public int treasurePotionCount;
    public float barrelGoldValue, barrelGoldValueIncrement;

    public void NewUpdate1NewSaves()
    {
        this.reinforcedPrestigeChanceIncrease = 0;
        this.reinforcedChestHealth = 10;
        this.reinforcedChestGoldIncrease = 12;
        this.reinforcedXPIncrease = 3;

        this.enchantedGoldenChestChance = 0;
        this.enchantedGoldenChestHealth = 0;
        this.enchantedGoldenChestTreasureDrops = 0;
        this.enchantedGoldenChestXPDrops = 0;

        this.bossChestChance = 0;
        this.bossChestHealth = 0;
        this.bossChestGoldAmount = 0;
        this.bossChestGoldCoinsDrops = 0;
        this.bossChestGoldValue = 0;
        this.bossChestXPDrops = 0;

        this.barrelBuyPriceDouble = 65000000000;
        this.mimicChestBuyPriceDouble = 48000000000000000;
        this.treasurePotionBuyPriceDouble = 69000000000000000000000000000000000000f;
        this.knifeBuyPriceDouble = 25000000000000000000000000000000000000000000000.5;

        this.knifeBoughtFirstTime = 0;
        this.barrelBoughtFirstTime = 0;
        this.treasurePotionBoughtFirstTime = 0;
        this.mimicChestBoughtFirstTime = 0;

        this.knifeDropChance = 0.01f;
        this.knifeDropChanceIncrement = 0.001f;
        this.treasurePotionDropChance = 0.03f;
        this.treasurePotionDropChanceIncrement = 0.003f;

        this.knifeLevel = 1;
        this.barrelLevel = 1;
        this.treasurePotionLevel = 1;
        this.mimicChestLevel = 1;

        this.knifeGemPrice = 3;
        this.knifeGemPrice2 = 3;
        this.barrelGemPrice = 1;
        this.treasurePotionGemPrice = 3;
        this.treasurePotionGemPrice2 = 3;
        this.mimicChestGemPrice = 1;

        this.mimicPositiveBuffChance = 25;
        this.mimicPositiveBiffChanceIncrement = 1;
        this.mimicNegativeBuffChance = 75;
        this.mimicNegativeBuffChanceIncrement = 1;
        this.mimicChestTimer = 300;
        this.mimicChestTimerIncrement = 3;

        this.reinforced1Bought = 0;
        this.reinforced2Bought = 0;
        this.reinforced3Bought = 0;
        this.reinforced4Bought = 0;
        this.reinforced5Bought = 0;

        this.greaterLoot1Bought = 0;
        this.greaterLoot2Bought = 0;
        this.greaterLoot3Bought = 0;
        this.greaterLoot4Bought = 0;
        this.greaterLoot5Bought = 0;

        this.newChests1Bought = 0;
        this.newChests2Bought = 0;
        this.newChests3Bought = 0;
        this.newChests4Bought = 0;
        this.newChests5Bought = 0;
        this.newChests6Bought = 0;

        this.barrelOfGoldAmountDouble = 0;

        this.knifeTimer = 8;
        this.knifeTimerIncrement = 1;
        this.knifeCount = 0;

        this.treasurePotionTimer = 13;
        this.treasurePotionTimerIncrement = 1;
        this.treasurePotionCount = 0;

        this.barrelGoldValue = 1;
        this.barrelGoldValueIncrement = 0.05f;
    }

    #endregion

}
