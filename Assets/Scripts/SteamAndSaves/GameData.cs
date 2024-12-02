using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    //TotalGold
    public float totalGold;
    public GameData ( TotalGoldAmount gold)
    {
        totalGold = TotalGoldAmount.totalGold;
    }

    //First time played button
    public int firstTimePlayed;
    public int totalStuffOnScreen;
    public int returnInstantlyToTotal;
    public GameData (SaveAndLoad firstTimePlayedClick)
    {
        firstTimePlayed = SaveAndLoad.firstClick;
        totalStuffOnScreen = SaveAndLoad.maximumStuffOnScreen;
        returnInstantlyToTotal = SaveAndLoad.instantlyReturnToTotal;
    }

    #region savedUnlockedChest
    //SavedChestsUnlocked
    public int purchasedChest2, purchasedChest3, purchasedChest4, purchasedChest5, purchasedChest6 , purchasedChest7, purchasedChest8, purchasedChest9, purchasedChest10, purchasedChest11, purchasedChest12, purchasedChest13, purchasedChest14, purchasedChest15, purchasedChest16, purchasedChest17, purchasedChest18, purchasedChest19, purchasedChest20, purchasedChest21, purchasedChest22, purchasedChest23, purchasedChest24, purchasedChest25, purchasedChest26, purchasedChest27;
    
    public int timesPurchasedChests;

    public GameData (UnlockChests chests)
    {
        timesPurchasedChests = UnlockChests.timesPurchasedChests;
        purchasedChest2 = UnlockChests.boughtChest2;
        purchasedChest3 = UnlockChests.boughtChest3;
        purchasedChest4 = UnlockChests.boughtChest4;
        purchasedChest5 = UnlockChests.boughtChest5;
        purchasedChest6 = UnlockChests.boughtChest6;
        purchasedChest7 = UnlockChests.boughtChest7;
        purchasedChest8 = UnlockChests.boughtChest8;
        purchasedChest9 = UnlockChests.boughtChest9;
        purchasedChest10 = UnlockChests.boughtChest10;
        purchasedChest11 = UnlockChests.boughtChest11;
        purchasedChest12 = UnlockChests.boughtChest12;
        purchasedChest13 = UnlockChests.boughtChest13;
        purchasedChest14 = UnlockChests.boughtChest14;
        purchasedChest15 = UnlockChests.boughtChest15;
        purchasedChest16 = UnlockChests.boughtChest16;
        purchasedChest17 = UnlockChests.boughtChest17;
        purchasedChest18 = UnlockChests.boughtChest18;
        purchasedChest19 = UnlockChests.boughtChest19;
        purchasedChest20 = UnlockChests.boughtChest20;
        purchasedChest21 = UnlockChests.boughtChest21;
        purchasedChest22 = UnlockChests.boughtChest22;
        purchasedChest23 = UnlockChests.boughtChest23;
        purchasedChest24 = UnlockChests.boughtChest24;
        purchasedChest25 = UnlockChests.boughtChest25;
        purchasedChest26 = UnlockChests.boughtChest26;
        purchasedChest27 = UnlockChests.boughtChest27;
    }
    #endregion

    #region gems
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


    public GameData(RareDropsCollected gems)
    {
        redRubyCount = RareDropsCollected.RedGemCount;
        amethystCount = RareDropsCollected.amethystCount;
        diamondCount = RareDropsCollected.diamondCount;
        violetCount = RareDropsCollected.violetCrystalCount;
        yellowSapphireCount = RareDropsCollected.yellowSapphireCount;
        greenDiamondCount = RareDropsCollected.greenDiamondCount;
        grandidieriteCount = RareDropsCollected.grandidieriteCount;
        purpleRupeeCount = RareDropsCollected.purpleRupeeCount;
        pinkPlortCount = RareDropsCollected.pinkPlostCount;
        emeraldCount = RareDropsCollected.emeraldCount;
        quartzCount = RareDropsCollected.quartzCount;
        redGarnetCount = RareDropsCollected.redGarnetCount;
        pinkTourmalineCount = RareDropsCollected.pinkTourmalineCount;
        yellowTopazCount = RareDropsCollected.yellowTopazCount;
        aquamarineCount = RareDropsCollected.aquamarineCount;
        fireOpalCount = RareDropsCollected.fireOpalCount;
        goldenSeaPearlCount = RareDropsCollected.goldeSeaPearlCount;
        akoyaPearlCount = RareDropsCollected.akoyaPearlCount;
        gemSilicaCount = RareDropsCollected.gemSilicaCount;
        adventurineCount = RareDropsCollected.AdventurineCount;
        kyaniteCount = RareDropsCollected.kyaniteCount;
        albiteCount = RareDropsCollected.albiteCount;
        blackOpalCount = RareDropsCollected.blackOpalCount;
        painiteCount = RareDropsCollected.painiteCount;
        tanzaniteCount = RareDropsCollected.TanzaniteCount;

        redRubyFirst = RareDropsCollected.redGemBoughtFirstTime;
        amethystFirst = RareDropsCollected.amethystBoughtFirstTime;
        diamondFirst = RareDropsCollected.diamondBoughtFirstTime;
        violetFirst = RareDropsCollected.violetCrystalBoughtFirstTime;
        yellowSapphireFirst = RareDropsCollected.yellowSapphireBoughtFirstTime;
        greenDiamondFirst = RareDropsCollected.greenDiamondBoughtFirstTime;
        grandideriteFirst = RareDropsCollected.grandidieriteBoughtFirstTime;
        purpleRupeeFirst = RareDropsCollected.purpleRupeeBoughtFirstTime;
        pinkPlortFirst = RareDropsCollected.pinkPlortBoughtFirstTime;
        emeraldFirst = RareDropsCollected.emeraldBoughtFirstTime;
        quartzFirst = RareDropsCollected.quartzBoughtFirstTime;
        redGarnetFirst = RareDropsCollected.redGarnetBoughtFirstTime;
        pinkTourmalineFirst = RareDropsCollected.pinkTourmalineBoughtFirstTime;
        yellowTopazFirst = RareDropsCollected.yellowTopazBoughtFirstTime;
        aquamarineFirst = RareDropsCollected.aquamarineBoughtFirstTime;
        fireOpalFirst = RareDropsCollected.fireOpalBoughtFirstTime;
        goldenSeaPearlFirst = RareDropsCollected.goldeSeaPearlBoughtFirstTime;
        akoyaPearlFirst = RareDropsCollected.akoyaPearlBoughtFirstTime;
        gemSilicaFirst = RareDropsCollected.gemSilicaBoughtFirstTime;
        adventurineFirst = RareDropsCollected.adventurineBoughtFirstTime;
        kyaniteFirst = RareDropsCollected.kyaniteBoughtFirstTime;
        albiteFirst = RareDropsCollected.albiteBoughtFirstTime;
        blackOpalFirst = RareDropsCollected.blackOpalBoughtFirstTime;
        painiteFirst = RareDropsCollected.painiteBoughtFirstTime;
        tanzaniteFirst = RareDropsCollected.tanzaniteBoughtFirstTime;
    }
    #endregion

    #region clickPowerUpgrades

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
    public  float cursor6PassiveDamageIncrement;
    public  float cursor6CritDamage;
    public  float cursor6CritDamageIncrement;
    public  float cursor6CritChance;
    public  float cursor6CritChanceIncrement;
    public  int cursor6Level;
    public  int cursor6Equipped;

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

    public GameData(ClickPower clickPowerUpgrades)
    {

        //Saves for all cursor prices
        cursor4TopazPrice = ClickPower.cursor4TopazPrice;
        cursor5AlbitePrice = ClickPower.cursor5AlbitePrice;
        cursor6albitePrice = ClickPower.cursor6AlbitePrice;
        cursor6RedGarnetPrice = ClickPower.cursor6RedGarnetPrice;
        cursor7AquamarinePrice = ClickPower.cursor7AquamarinePrice;
        cursor8AquamarinePrice = ClickPower.cursor8AquamarinePrice;
        cursor8YellopSapphirePrice = ClickPower.cursor8YellowSapphirePrice;
        cursor9PinkTourmalinePrice = ClickPower.cursor9PinkTourmalinePrice;
        cursor10AdventurinePrice = ClickPower.cursor10AdventurinePrice;
        cursor11AdventurinePrice = ClickPower.cursor11AdventurinePrice;
        cursor11PinkTourmalinePrice = ClickPower.cursor11PinkTourmalinePrice;
        cursor12AdventurinePrice = ClickPower.cursor12AdventurinePrice;
        cursor12RedRubyPrice = ClickPower.cursor12RedRubyPrice;
        cursor13DiamondPrice = ClickPower.cursor13DiamondPrice;
        cursor13GrandideritePrice = ClickPower.cursor13GrandideritePrice;
        cursor14VioletCrystalPrice = ClickPower.cursor14VioletCrystalPrice;
        cursor14GrandideritePrice = ClickPower.cursor14GrandideritePrice;
        cursor15AkoyaPearlPrice = ClickPower.cursor15AkoyaPeralPrice;
        cursor15PurpleRupeePrice = ClickPower.cursor15PurpleRupeePrice;
        cursor15EmeraldPrice = ClickPower.cursor15EmeraldPrice;
        cursor16GreenDiamondPrice = ClickPower.cursor16GreenDiamondPrice;
        cursor16FireOpalPrice = ClickPower.cursor16FireOpalPrice;
        cursor16GemSilicaPrice = ClickPower.cursor16GemSilicaPrice;
        cursor17PinkPlortPrice = ClickPower.cursor17PinkPlortPrice;
        cursor17GoldenSeaPearlPrice = ClickPower.cursor17GoldenSeaPEarlPrice;
        cursor17KyanitePrice = ClickPower.cursor17KyanitePrice;
        cursor18BlackOpalPrice = ClickPower.cursor18BlackOpalPrice;
        cursor18PainitePrice = ClickPower.cursor18PainitePrice;
        cursor18TanzanitePrice = ClickPower.cursor18TanzanitePrice;

        //General Click damage
        activeClickDamage = ClickPower.clickPower;

        //Price of active and passive damage
        activeClickDamagePrice = ClickPower.activeClickPowerPrice;
        passiveClickDamagePrice = ClickPower.passiveClickPowerPrice;

        //Passive and active levels
        activeClickPowerLevel = ClickPower.activeUpgradeLevel;
        passiveClickPowerLvel = ClickPower.passiveUpgradeLevel;

        //Cursor1
        cursor1Level = ClickPower.Cursor1Level;
        cursor1QuartzPirce = ClickPower.cursor1QuartzUpgradePrice;
        cursor1ActiveDamageBuff = ClickPower.cursor1ActiveBuff;
        cursor1Equipped = ClickPower.cursor1Equipped;
        cursor1ActiveIncrement = ClickPower.cursor1ActiveBuffIncrement;

        //cursor2
        cursor2Level = ClickPower.cursor2Level;
        cursor2QuartzPrice = ClickPower.cursor2QuartzUpgradePrice;
        cursor2PassiveDamageBuff = ClickPower.cursor2PassiveBuff;
        cursor2Equipped = ClickPower.cursor2Equipped;
        cursor2PassiveIncrement = ClickPower.cursor2PassiveBuffIncrement;

        //Cursor3
        cursor3Level = ClickPower.cursor3Level;
        cursor3QuartzPrice = ClickPower.cursor3QuartzPrice;
        cursor3AmethystPrice = ClickPower.cursor3AmethystPrice;
        cursor3CritChanceBuff = ClickPower.cursor3CritChance;
        cursor3CritChanceIncrement = ClickPower.cursor3CritChanceIncrement;
        cursor3CritDamageBuff = ClickPower.cursor3CritDamage;
        cursor3CritDamageIncrement = ClickPower.cursor3CritDamageIncrement;
        cursor3Equipped = ClickPower.cursor3Equipped;

        //Cursor4
        cursor4Level = ClickPower.cursor4Level;
        cursor4ActiveDamage = ClickPower.cursor4ActiveDamage;
        cursor4ActiveDamageIncrement = ClickPower.cursor4ActiveDamageIncrement;
        cursor4PassiveDamage = ClickPower.cursor4PassiveDamage;
        cursor4PassiveDamageIncrement = ClickPower.cursor4PassiveDamageIncrement;
        cursor4Equipped = ClickPower.cursor4Equipped;

        //Cursor5
        cursor5Level = ClickPower.cursor5Level;
        cursor5ActiveDamage = ClickPower.cursor5ActiveDamage;
        cursor5ActiveDamageIncrement = ClickPower.cursor5ActiveDamageIncrement;
        cursor5CritChance = ClickPower.cursor5CritChance;
        cursor5CritChanceIncrement = ClickPower.cursor5CritChanceIncrement;
        cursor5CritDamage = ClickPower.cursor5CritDamage;
        cursor5CritDamageIncrement = ClickPower.cursor5CritDamageIncrement;
        cursor5Equipped = ClickPower.cursor5Equipped;

        //Cursor6
        cursor6Level = ClickPower.cursor6Level;
        cursor6ActiveDamage = ClickPower.cursor6ActiveDamage;
        cursor6ActiveDamageIncrement = ClickPower.cursor6ActiveDamageIncrement;
        cursor6PassiveDamage = ClickPower.cursor6PassiveDamage;
        cursor6PassiveDamageIncrement = ClickPower.cursor6PassiveDamageIncrement;
        cursor6CritChance = ClickPower.cursor6CritChance;
        cursor6CritChanceIncrement = ClickPower.cursor6CritChanceIncrement;
        cursor6CritDamage = ClickPower.cursor6CritDamage;
        cursor6CritDamageIncrement = ClickPower.cursor6CritDamageIncrement;
        cursor6Equipped = ClickPower.cursor6Equipped;

        //Cursor7
        cursor7Level = ClickPower.cursor7Level;
        cursor7ActiveDamage = ClickPower.cursor7ActiveDamage;
        cursor7ActiveDamageIncrement = ClickPower.cursor7ActiveDamageIncrement;
        cursor7CritChance = ClickPower.cursor7CritChance;
        cursor7CritChanceIncrement = ClickPower.cursor7CritChanceIncrement;
        cursor7CritDamage = ClickPower.cursor7CritDamage;
        cursor7CritDamageIncrement = ClickPower.cursor7CritDamageIncrement;
        cursor7Equipped = ClickPower.cursor7Equipped;

        //Cursor8
        cursor8Level = ClickPower.cursor8Level;
        cursor8ActiveDamage = ClickPower.cursor8ActiveDamage;
        cursor8ActiveDamageIncrement = ClickPower.cursor8ActiveDamageIncrement;
        cursor8PassiveDamage = ClickPower.cursor8PassiveDamage;
        cursor8PassiveDamageIncrement = ClickPower.cursor8PassiveDamageIncrement;
        cursor8CritChance = ClickPower.cursor8CritChance;
        cursor8CritChanceIncrement = ClickPower.cursor8CritChanceIncrement;
        cursor8CritDamage = ClickPower.cursor8CritDamage;
        cursor8CritDamageIncrement = ClickPower.cursor8CritDamageIncrement;
        cursor8Equipped = ClickPower.cursor8Equipped;

        //Cursor9
        cursor9Level = ClickPower.cursor9Level;
        cursor9ActiveDamage = ClickPower.cursor9ActiveDamage;
        cursor9ActiveDamageIncrement = ClickPower.cursor9ActiveDamageIncrement;
        cursor9PassiveDamage = ClickPower.cursor9PassiveDamage;
        cursor9PassiveDamageIncrement = ClickPower.cursor9PassiveDamageIncrement;
        cursor9Equipped = ClickPower.cursor9Equipped;

        //Cursor10
        cursor10Level = ClickPower.cursor10Level;
        cursor10PassiveDamage = ClickPower.cursor10PassiveDamage;
        cursor10PassiveDamageIncrement = ClickPower.cursor10PassiveDamageIncrement;
        cursor10Equipped = ClickPower.cursor10Equipped;

        //Cursor11
        cursor11Level = ClickPower.cursor11Level;
        cursor11ActiveDamage = ClickPower.cursor11ActiveDamage;
        cursor11ActiveDamageIncrement = ClickPower.cursor11ActiveDamageIncrement;
        cursor11CritChance = ClickPower.cursor11CritChance;
        cursor11CritChanceIncrement = ClickPower.cursor11CritChanceIncrement;
        cursor11CritDamage = ClickPower.cursor11CritDamage;
        cursor11CritDamageIncrement = ClickPower.cursor11CritDamageIncrement;
        cursor11Equipped = ClickPower.cursor11Equipped;

        //Cursor12
        cursor12Level = ClickPower.cursor12Level;
        cursor12ActiveDamage = ClickPower.cursor12ActiveDamage;
        cursor12ActiveDamageIncrement = ClickPower.cursor12ActiveDamageIncrement;
        cursor12PassiveDamage = ClickPower.cursor12PassiveDamage;
        cursor12PassiveDamageIncrement = ClickPower.cursor12PassiveDamageIncrement;
        cursor12CritChance = ClickPower.cursor12CritChance;
        cursor12CritChanceIncrement = ClickPower.cursor12CritChanceIncrement;
        cursor12CritDamage = ClickPower.cursor12CritDamage;
        cursor12CritDamageIncrement = ClickPower.cursor12CritDamageIncrement;
        cursor12Equipped = ClickPower.cursor12Equipped;

        //Cursor13
        cursor13Level = ClickPower.cursor13Level;
        cursor13ActiveDamage = ClickPower.cursor13ActiveDamage;
        cursor13ActiveDamageIncrement = ClickPower.cursor13ActiveDamageIncrement;
        cursor13PassiveDamage = ClickPower.cursor13PassiveDamage;
        cursor13PassiveDamageIncrement = ClickPower.cursor13PassiveDamageIncrement;
        cursor13CritChance = ClickPower.cursor13CritChance;
        cursor13CritChanceIncrement = ClickPower.cursor13CritChanceIncrement;
        cursor13CritDamage = ClickPower.cursor13CritDamage;
        cursor13CritDamageIncrement = ClickPower.cursor13CritDamageIncrement;
        cursor13Equipped = ClickPower.cursor13Equipped;

        //Cursor14
        cursor14Level = ClickPower.cursor14Level;
        cursor14ActiveDamage = ClickPower.cursor14ActiveDamage;
        cursor14ActiveDamageIncrement = ClickPower.cursor14ActiveDamageIncrement;
        cursor14PassiveDamage = ClickPower.cursor14PassiveDamage;
        cursor14PassiveDamageIncrement = ClickPower.cursor14PassiveDamageIncrement;
        cursor14CritChance = ClickPower.cursor14CritChance;
        cursor14CritChanceIncrement = ClickPower.cursor14CritChanceIncrement;
        cursor14CritDamage = ClickPower.cursor14CritDamage;
        cursor14CritDamageIncrement = ClickPower.cursor14CritDamageIncrement;
        cursor14Equipped = ClickPower.cursor14Equipped;

        //Cursor15
        cursor15Level = ClickPower.cursor15Level;
        cursor15ActiveDamage = ClickPower.cursor15ActiveDamage;
        cursor15ActiveDamageIncrement = ClickPower.cursor15ActiveDamageIncrement;
        cursor15PassiveDamage = ClickPower.cursor15PassiveDamage;
        cursor15PassiveDamageIncrement = ClickPower.cursor15PassiveDamageIncrement;
        cursor15CritChance = ClickPower.cursor15CritChance;
        cursor15CritChanceIncrement = ClickPower.cursor15CritChanceIncrement;
        cursor15CritDamage = ClickPower.cursor15CritDamage;
        cursor15CritDamageIncrement = ClickPower.cursor15CritDamageIncrement;
        cursor15Equipped = ClickPower.cursor15Equipped;

        //Cursor16
        cursor16Level = ClickPower.cursor16Level;
        cursor16ActiveDamage = ClickPower.cursor16ActiveDamage;
        cursor16ActiveDamageIncrement = ClickPower.cursor16ActiveDamageIncrement;
        cursor16PassiveDamage = ClickPower.cursor16PassiveDamage;
        cursor16PassiveDamageIncrement = ClickPower.cursor16PassiveDamageIncrement;
        cursor16CritChance = ClickPower.cursor16CritChance;
        cursor16CritChanceIncrement = ClickPower.cursor16CritChanceIncrement;
        cursor16CritDamage = ClickPower.cursor16CritDamage;
        cursor16CritDamageIncrement = ClickPower.cursor16CritDamageIncrement;
        cursor16Equipped = ClickPower.cursor16Equipped;

        //Cursor17
        cursor17Level = ClickPower.cursor17Level;
        cursor17ActiveDamage = ClickPower.cursor17ActiveDamage;
        cursor17ActiveDamageIncrement = ClickPower.cursor17ActiveDamageIncrement;
        cursor17PassiveDamage = ClickPower.cursor17PassiveDamage;
        cursor17PassiveDamageIncrement = ClickPower.cursor17PassiveDamageIncrement;
        cursor17CritChance = ClickPower.cursor17CritChance;
        cursor17CritChanceIncrement = ClickPower.cursor17CritChanceIncrement;
        cursor17CritDamage = ClickPower.cursor17CritDamage;
        cursor17CritDamageIncrement = ClickPower.cursor17CritDamageIncrement;
        cursor17Equipped = ClickPower.cursor17Equipped;

        //Cursor18
        cursor18Level = ClickPower.cursor18Level;
        cursor18ActiveDamage = ClickPower.cursor18ActiveDamage;
        cursor18ActiveDamageIncrement = ClickPower.cursor18ActiveDamageIncrement;
        cursor18PassiveDamage = ClickPower.cursor18PassiveDamage;
        cursor18PassiveDamageIncrement = ClickPower.cursor18PassiveDamageIncrement;
        cursor18CritChance = ClickPower.cursor18CritChance;
        cursor18CritChanceIncrement = ClickPower.cursor18CritChanceIncrement;
        cursor18CritDamage = ClickPower.cursor18CritDamage;
        cursor18CritDamageIncrement = ClickPower.cursor18CritDamageIncrement;
        cursor18Equipped = ClickPower.cursor18Equipped;

    }

    #endregion

    #region autoDamage

    public float autoDamage;

    public GameData(HealthBar auto)
    {
        autoDamage = HealthBar.autoDamage;
    }


    #endregion

    #region consumables
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

    public GameData (UseConsumable consumable)
    {
        relicPermaActiveDamage = UseConsumable.relicPermaActiveDamage;
        relicPermaPassiveDamage = UseConsumable.relicPermaPassiveDamage;
        relicPermaCritDamage = UseConsumable.relicPermaCritDamage;
        relicPermaCritChance = UseConsumable.relicPermaCritChance;
        relicPermaGoldBuff = UseConsumable.relicPermaGoldBuff;
        relicPermaTreasureBuff = UseConsumable.relicPermaTreasureBuff;
        relicPermaXPBuff = UseConsumable.relicPermaXPBuff;

        scrollActiveDamageBuff = UseConsumable.scrollActiveDamageBuff;
        scrollPassiveDamageBuff = UseConsumable.scrollPassiveDamageBuff;
        scrollCritChanceBuff = UseConsumable.scrollCritChanceBuff;
        scrollCritDamageBuff = UseConsumable.scrollCritDamageBuff;
        scrollGoldBuff = UseConsumable.scrollGoldBuff;
        scrollXPBuff = UseConsumable.scrollXPBuff;
        scrollTreasureBuff = UseConsumable.scrollTreasureBuff;

        lockPickCount = UseConsumable.lockPickCount;
        keysCount = UseConsumable.KeysCount;
        hammerCount = UseConsumable.hammerCount;
        goldenTouchCount = UseConsumable.goldenTouchCount;
        treasureBagCount = UseConsumable.treasureBagCount;
        XPPotionCount = UseConsumable.XPPotionCount;
        damagePotionCount = UseConsumable.damagePotioncount;
        lootPotionCount = UseConsumable.lootPotionCount;
        elixirCount = UseConsumable.elixirCount;
        scrollCount = UseConsumable.scrollCount;
        gauntletCount = UseConsumable.gauntletCount;
        relicCount = UseConsumable.relicCount;

        hammerDamageMultiplier = UseConsumable.hammerDamageMultiplier;
        lockPickSuccessChance = UseConsumable.lockPickSuccessChance;
    }
    #endregion

    #region specialUpgrades

    public int lockPickLevel, hammerLevel, keyLevel, goldenTouchLevel, treasureBagLevel, xpPotionLevel, damagePotionLevel, lootPotionLevel, elixirLevel,scrollLevel, gauntletLevel, relicLevel;

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

    public GameData(SpecialUpgradesButtons specialUpgrades)
    {
        miniChestPrice = SpecialUpgradesButtons.miniChestBuyPrice;
        miniChestLevel = SpecialUpgradesButtons.miniChestLevel;
        miniChestGemPrice = SpecialUpgradesButtons.miniChestGemPrice;
        miniChestTimer = SpecialUpgradesButtons.miniChestSpawnTimer;
        miniChestTimerIncrement = SpecialUpgradesButtons.miniChestSpawnTimerMinus;

        lockPickLevel = SpecialUpgradesButtons.lockPickLevel;
        hammerLevel = SpecialUpgradesButtons.hammerLevel;
        keyLevel = SpecialUpgradesButtons.keyLevel;
        goldenTouchLevel = SpecialUpgradesButtons.goldenTouchLevel;
        treasureBagLevel = SpecialUpgradesButtons.treasureBagLevel;
        xpPotionLevel = SpecialUpgradesButtons.XPPotionLevel;
        damagePotionLevel = SpecialUpgradesButtons.damagePotionLevel;
        lootPotionLevel = SpecialUpgradesButtons.lootPotionLevel;
        elixirLevel = SpecialUpgradesButtons.elixirLevel;
        scrollLevel = SpecialUpgradesButtons.scrollLevel;
        gauntletLevel = SpecialUpgradesButtons.gauntletLevel;
        relicLevel = SpecialUpgradesButtons.relicLevel;

        lockPickBoughtFirstTime = SpecialUpgradesButtons.lockPickBoughtFirstTime;
        keyBoughtFirstTime = SpecialUpgradesButtons.keyBoughtFirstTime;
        hammerBoughtFirstTime = SpecialUpgradesButtons.hammerBoughtFirstTime;
        goldenTouchBoughtFirstTime = SpecialUpgradesButtons.goldenTouchBoughtFirstTime;
        treasureBagBoughtFirstTime = SpecialUpgradesButtons.treasureBagBoughtFirstTime;
        XPPotionBoughtFirstTime = SpecialUpgradesButtons.XPPotionBoughtFirstTime;
        damagePotionBoughtFirstTime = SpecialUpgradesButtons.damagePotionBoughtFirstTime;
        lootPotionBOughtFirstTime = SpecialUpgradesButtons.lootPotionBoughtFirstTime;
        miniChestBoughtFirsTTime = SpecialUpgradesButtons.miniChestBoughtFirstTime;
        elixirBoughtFirsTTime = SpecialUpgradesButtons.elixirBoughtFirstTime;
        scrollBoughtFirsTTime = SpecialUpgradesButtons.scrollBoughtFirstTime;
        gauntletBoughtFirsTTime = SpecialUpgradesButtons.gauntletBoughtFirstTime;
        relicBoughtFirsTTime = SpecialUpgradesButtons.relicBoughtFirstTime;

        lockPickgemPrice = SpecialUpgradesButtons.lockPickGemPrice;
        keyGemPrice = SpecialUpgradesButtons.keyGemUpgradePrice;
        hammerGemPrice = SpecialUpgradesButtons.hammerGemUpgradePrice;
        goldenTouchGemPrice = SpecialUpgradesButtons.goldenTouchGemPrice;
        treasurebagGemPrice = SpecialUpgradesButtons.treasureBagGemPrice;
        xpPotionGemPrice = SpecialUpgradesButtons.XPPotionGemPrice;
        damagePotionGemPrice = SpecialUpgradesButtons.damagePotionGemPrice;
        lootPotionGemPrice = SpecialUpgradesButtons.lootPotionGemPrice;
        elixirGemPrice = SpecialUpgradesButtons.elixirGemPrice;
        scrollGemPrice = SpecialUpgradesButtons.scrollGemPrice;
        gauntletGemPrice = SpecialUpgradesButtons.gauntletGemPrice;
        relicGemPrice = SpecialUpgradesButtons.relicGemPrice;
        relicGemPrice2 = SpecialUpgradesButtons.relicGemPrice2;

        lockPickPrice = SpecialUpgradesButtons.lockPickPurchasePrice;
        keyPrice = SpecialUpgradesButtons.keyPurchasePrice;
        hammerPrice = SpecialUpgradesButtons.hammerPurchasePrice;
        goldenTouchPrice = SpecialUpgradesButtons.goldenTouchPurchasePrice;
        treasureBagPrice = SpecialUpgradesButtons.treasureBagBuyPrice;
        xpPotionPrice = SpecialUpgradesButtons.XPPotionBuyPrice;
        damagePotionPrice = SpecialUpgradesButtons.damagePotionBuyPrice;
        lootPotionPrice = SpecialUpgradesButtons.lootPotionBuyPrice;
        elixirPrice = SpecialUpgradesButtons.elixirBuyPrice;
        scrollPrice = SpecialUpgradesButtons.scrollBuyPrice;
        gauntletPrice = SpecialUpgradesButtons.gauntletBuyPrice;
        relicPrice = SpecialUpgradesButtons.relicBuyPrice;

        lockPickDropChance = SpecialUpgradesButtons.lockPickDropChance;
        hammerDropChance = SpecialUpgradesButtons.hammerDropChance;
        keyDropChance = SpecialUpgradesButtons.keyDropChance;
        goldenTouchDropChance = SpecialUpgradesButtons.goldenTouchDropChance;
        treasureBagDropChance = SpecialUpgradesButtons.treasureBagDropChance;
        XPPotiondropChance = SpecialUpgradesButtons.XPPotionDropChance;
        damagepotionDropChance = SpecialUpgradesButtons.damagePotionDropChance;
        lootPotionDropChance = SpecialUpgradesButtons.lootPotionDropChance;
        elixirDropChance = SpecialUpgradesButtons.elixirDropChance;
        scrollDropChance = SpecialUpgradesButtons.scrollDropChance;
        gauntletDropChance = SpecialUpgradesButtons.gauntletDropChance;
        relicDropChance = SpecialUpgradesButtons.relicDropChance;

        lockPickDropChanceIncrement = SpecialUpgradesButtons.lockPickDropChanceIncrement;
        hammerDropChanceIncrement = SpecialUpgradesButtons.hammerDropChanceIncrement;
        keyDropChanceIncrement = SpecialUpgradesButtons.keyDropChanceIncrement;
        goldenTouchDropChanceIncrement = SpecialUpgradesButtons.goldenTouchDropChanceIncrement;
        treasureBagDropChanceIncrement = SpecialUpgradesButtons.treasureBagDropChanceIncrement;
        XPPotiondropChanceIncrement = SpecialUpgradesButtons.XPPotionDropChanceIncrement;
        damagepotionDropChanceIncrement = SpecialUpgradesButtons.damagePotionDropChanceIncrement;
        lootPotionDropChanceIncrement = SpecialUpgradesButtons.lootPotionDropChanceIncrement;
        elixirDropChanceIncrement = SpecialUpgradesButtons.elixirDropChanceIncrement;
        scrollDropChanceIncrement = SpecialUpgradesButtons.scrollDropChanceIncrement;
        gauntletDropChanceIncrement = SpecialUpgradesButtons.gauntletDropChanceIncrement;
        relicDropChanceIncrement = SpecialUpgradesButtons.relicDropChanceIncrement;

        lockPickOpenChanceIncrement = SpecialUpgradesButtons.lockPickOpenChanceIncrement;
        keyRareDropChance = SpecialUpgradesButtons.keyRareDropChance;
        keyRareDropChanceIncrement = SpecialUpgradesButtons.keyRareDropChanceIncrement;
        hammerDamageAmountIncrement = SpecialUpgradesButtons.hammerDamageAmountIncrement;
        hammerTimer = SpecialUpgradesButtons.hammerTimer;
        hammerTimerIncrement = SpecialUpgradesButtons.hammerTimerIncrement;
        goldenTouchTimer = SpecialUpgradesButtons.goldenTouchTimer;
        goldenTouchTimerIncrement = SpecialUpgradesButtons.goldenTouchTimerIncrement;
        xpPotionBuff = SpecialUpgradesButtons.XPPotionXPBuff;
        xpPotionBuffIncrement = SpecialUpgradesButtons.XPPotionBufFIncrement;
        xpPotionTimer = SpecialUpgradesButtons.XPPotionTimer;
        XPPotionTimerMinus = SpecialUpgradesButtons.XPPotionTimerMinus;
        damagePotionBuff = SpecialUpgradesButtons.damagePotionBuff;
        damagePotionBuffIncrement = SpecialUpgradesButtons.damagePotionBuffIncrement;
        damagePotionTimer = SpecialUpgradesButtons.damagePotionTimer;
        damagePotionTimerMinus = SpecialUpgradesButtons.damagePotionTimerMinus;
        lootPotionBuff = SpecialUpgradesButtons.lootPotionBuff;
        lootPotionBuffIncrement = SpecialUpgradesButtons.lootPotionBuffIncrement;
        lootPotionTimer = SpecialUpgradesButtons.lootPotionTimer;
        lootPotionTimerIncrement = SpecialUpgradesButtons.lootPotionTimerMinus;

        elixirBuff = SpecialUpgradesButtons.elixirBuff;
        elixirBuffIncrement = SpecialUpgradesButtons.elixirBuffIncrement;
        elixirTimer = SpecialUpgradesButtons.elixirTimer;
        elixirTimerIncrement = SpecialUpgradesButtons.elixirTimerIncrement;

        scrollTimer = SpecialUpgradesButtons.scrollTimer;
        scrollTimerIncrement = SpecialUpgradesButtons.scrollTimerIncrement;

        gauntletTimer = SpecialUpgradesButtons.gauntletTimer;
        gauntletTimerIncrement = SpecialUpgradesButtons.gauntletTimerIncrement;
        gauntletGoldDropChance = SpecialUpgradesButtons.gauntletGoldDropChance;
        gauntletGoldDropChanceIncrement = SpecialUpgradesButtons.gauntletGoldDropChanceIncrement;
    }
    #endregion

    #region levelAndSkillPoints

    public int skillPoints;
    public int playerLevel;
    public float experienceNeeded, experienceGained;

    public GameData(PlayerLevel playerLeveLAndSkillpoints)
    {
        skillPoints = PlayerLevel.skillPoints;
        playerLevel = PlayerLevel.playerLevel;
        experienceNeeded = PlayerLevel.experienceNeeded;
        experienceGained = PlayerLevel.experienceGained;

    }

    #endregion

    #region stats
    public int totalGoldCoins, totalTreasures, treasuresDoubled;
    public float totalGoldRecieved;

    public int chestsOpened, reinforcedChestsOpened;

    public int chestClicks, autoClicks, criticalHits, cursorUpgraded, coinsSpawnedFromClicks, treasuredSpawnedFromClicks;

    public  int itemsUsed, itemsDropped, itemsPurchased, itemsUpgraded;

    public float treasureDropChanceIncrease;
    public  int goldCoin5XDropped, goldCoins10XDropped;

    public int rareTreasureFound;

    public int totalSkillPoints;

    public int commonTreasures, uncommonTreasures, rareTreasures, veryRareTreasures, extremelyRareTreasures, legendaryTreasures;

    public int prestigedTimesCount, prestigeUpgradesPurchased, clickerUpgradePurchased, loungerUpgradesPurchased, pirateUpgradesPurchased, hoarderUpgradeesPurchased;

    public GameData(Stats stats)
    {
        totalGoldRecieved = Stats.totalGoldRecieved;
        totalGoldCoins = Stats.goldCoinsDropped;
        totalTreasures = Stats.treasuresDropped;
        treasuresDoubled = Stats.treasuresDoubled;

        chestsOpened = Stats.chestOpened;
        reinforcedChestsOpened = Stats.reinforedChestsOpened;

        chestClicks = Stats.chestClicks;
        autoClicks = Stats.autoClicks;
        criticalHits = Stats.criticalHits;
        cursorUpgraded = Stats.cursorUpgraded;
        coinsSpawnedFromClicks = Stats.coinsSpawnedFromClicks;
        treasuredSpawnedFromClicks = Stats.treasuredSpawnedFromClicks;

        itemsUsed = Stats.itemsUsed;
        itemsDropped = Stats.itemsDropped;
        itemsPurchased = Stats.itemsPurchased;
        itemsUpgraded = Stats.itemsUpgraded;

        treasureDropChanceIncrease = Stats.treasureDropChanceIncrease;
        goldCoin5XDropped = Stats.goldCoin5XDropped;
        goldCoins10XDropped = Stats.goldCoins10XDropped;

        rareTreasureFound = Stats.rareTreasuresFound;

        totalSkillPoints = Stats.totalSkillPoints;

        commonTreasures = Stats.commonTreasureDrops;
        uncommonTreasures = Stats.uncommonTreasureDrops;
        rareTreasures = Stats.rareTreasureDrops;
        veryRareTreasures = Stats.veryRareTreasureDrops;
        extremelyRareTreasures = Stats.extremelyRareTreasureDrops;
        legendaryTreasures = Stats.legendaryTreasureDrops;

        prestigedTimesCount = Stats.prestigedTimesCount;
        prestigeUpgradesPurchased = Stats.prestigeUpgradesPurchased;
        clickerUpgradePurchased = Stats.clickerUpgradePurchased;
        loungerUpgradesPurchased = Stats.loungerUpgradesPurchased;
        pirateUpgradesPurchased = Stats.pirateUpgradesPurchased;
        hoarderUpgradeesPurchased = Stats.hoarderUpgradeesPurchased;
    }

    #endregion

    #region treasure drop chance

    public float quartzBaseChance, amethystBaseChance, yellowTopazBaseChance, albiteBaseChance, redGarnetBaseChance, aquamarineBaseChance, yellowSapphireBaseChance, pinkTourmalineBaseChance, adventurineBaseChance, redGemCBaseChance, diamondBaseChance, grandidieriteBaseChance, violetBaseChance, akoyaPearlBaseChance, purpleRupeeBaseChance, emeraldDropBaseChance, greenDiamondBaseChance, fireOpalBaseChance, gemSilicaBaseChance, pinkPlortBaseChance, goldenSeaPearlBaseChance, kyaniteBaseChance, blackOpalBaseChance, painiteBaseChance, tanzaniteBaseChance;

    public float doubleValueTreasure;

    public int prestigeKeyFound, prestigeChestFound;

    public GameData(SpawnRewards treasureChance)
    {
        prestigeKeyFound = SpawnRewards.prestigeKeyFound;
        prestigeChestFound = SpawnRewards.prestigeChestFound;

        doubleValueTreasure = SpawnRewards.doubleRareDropChance;

        quartzBaseChance = SpawnRewards.quartzBaseChance;
        amethystBaseChance = SpawnRewards.amethystBaseChance;
        yellowTopazBaseChance = SpawnRewards.yellowTopacBaseChance;
        albiteBaseChance = SpawnRewards.albiteBaseChance;
        redGarnetBaseChance = SpawnRewards.redGarnetBaseChance;
        aquamarineBaseChance = SpawnRewards.aquamarineBaseChance;
        yellowSapphireBaseChance = SpawnRewards.yellowSapphireBaseChance;
        pinkTourmalineBaseChance = SpawnRewards.pinkTourmalineBaseChance;
        adventurineBaseChance = SpawnRewards.adventurineBaseChance;
        redGemCBaseChance = SpawnRewards.redGemCBaseChance;
        diamondBaseChance = SpawnRewards.diamondBaseChance;
        violetBaseChance = SpawnRewards.violetBaseChance;
        grandidieriteBaseChance = SpawnRewards.grandidieriteBaseChance;
        akoyaPearlBaseChance = SpawnRewards.akoyaPearlBaseChance;
        purpleRupeeBaseChance = SpawnRewards.purpleRupeeBaseChance;
        emeraldDropBaseChance = SpawnRewards.emeraldDropBaseChance;
        greenDiamondBaseChance = SpawnRewards.greenDiamondBaseChance;
        fireOpalBaseChance = SpawnRewards.fireOpalBaseChance;
        gemSilicaBaseChance = SpawnRewards.gemSilicaBaseChance;
        pinkPlortBaseChance = SpawnRewards.pinkPlortBaseChance;
        goldenSeaPearlBaseChance = SpawnRewards.goldenSeaPearlBaseChance;
        kyaniteBaseChance = SpawnRewards.kyaniteBaseChance;
        blackOpalBaseChance = SpawnRewards.blackOpalBaseChance;
        painiteBaseChance = SpawnRewards.painiteBaseChance;
        tanzaniteBaseChance = SpawnRewards.tanzaniteBaseChance;

    }


    #endregion

    #region rareTreasures

    public int skullFound, trophyFound, swordFound, ringFound, starFound, cloverFound, crownFound, bookFound, guitarFOund, talarianFound, runeFound, backPackFound, shieldFound, pillBottleFound, medalFound, cookieFound;

    public GameData(RareTreasures rareTreasures)
    {
        skullFound = RareTreasures.skullFound;
        trophyFound = RareTreasures.trophyFound;
        swordFound = RareTreasures.swordFound;
        ringFound = RareTreasures.ringFound;
        starFound = RareTreasures.starFound;
        crownFound = RareTreasures.crownFound;
        cloverFound = RareTreasures.cloverFound;
        bookFound = RareTreasures.bookFound;
        guitarFOund = RareTreasures.guitarFOund;
        talarianFound = RareTreasures.talarianFound;
        runeFound = RareTreasures.runeFound;
        backPackFound = RareTreasures.backPackFound;
        shieldFound = RareTreasures.shieldFound;
        pillBottleFound = RareTreasures.pillBottleFound;
        medalFound = RareTreasures.medalFound;
        cookieFound = RareTreasures.cookieFound;
    }

    #endregion

    #region skillTreeSaves
    public int crit1Bought, crit2Bought, crit3Bought, crit4Bought, crit5Bought;
    public int active1Bought, active2Bought, active3Bought, active4Bought, active5Bought, active6Bought;
    public int activeCursor1Bought, activeCursor2Bought, activeCursor3Bought, activeCursor4Bought;

    public int autoClicker1Bought, autoClicker2Bought, autoClicker3Bought, autoClicker4Bought;
    public int autoDamage1Bought, autoDamage2Bought, autoDamage3Bought, autoDamage4Bought, autoDamage5Bought, autoDamage6Bought, autoDamage7Bought;
    public int autoCursor1Bought, autoCursor2Bought, autoCursor3Bought, autoCursor4Bought;

    public int gold1Bought, gold2Bought, gold3Bought, gold4Bought, gold5Bought, gold6Bought, gold7Bought;
    public int drops1Bought, drops2Bought, drops3Bought, drops4Bought, drops5Bought, drops6Bought, drops7Bought;
    public int xp1Bought, xp2Bought, xp3Bought, xp4Bought, xp5Bought, xp6Bought, xp7Bought;

    public int levelSpecial1Bought, levelSpecial2Bought, levelSpecial3Bought, levelSpecial4Bought;
    public int strongerSpecial1Bought, strongerSpecial2Bought, strongerSpecial3Bought, strongerSpecial4Bought, strongerSpecial5Bought;
    public int startWithItem1Bought, startWithItem2Bought, startWithItem3Bought, startWithItem4Bought;

    public float skillTreeCritChance, skillTreeCritDamage, skillTreeActiveDamage, active4GoldChance, active5TreasureChance, active6InstantlyOpenChance,skillTreePassiveDamage, skillTreeGold, skillTreeXP;

    public int crit4CritGoldChance, crit5CritTreasureChance;

    public float autoClicksPerSecond;
    public GameData(SkillTree skillsBought)
    {
        autoClicksPerSecond = SkillTree.autoClicksPerSecond;
        skillTreeCritChance = SkillTree.skillTreeCritChance;
        skillTreeCritDamage = SkillTree.skillTreeCritDamage;
        crit4CritGoldChance = SkillTree.crit4CritGoldChance;
        crit5CritTreasureChance = SkillTree.crit5CritTreasureChance;
        skillTreeActiveDamage = SkillTree.skillTreeActiveDamage;
        active4GoldChance = SkillTree.active4GoldChance;
        active5TreasureChance = SkillTree.active5TreasureChance;
        active6InstantlyOpenChance = SkillTree.active6InstantlyOpenChance;
        skillTreePassiveDamage = SkillTree.skillTreePassiveDamage;
        skillTreeGold = SkillTree.skillTreeGold;
        skillTreeXP = SkillTree.skillTreeXP;

        crit1Bought = SkillTree.crit1Bought;
        crit2Bought = SkillTree.crit2Bought;
        crit3Bought = SkillTree.crit3Bought;
        crit4Bought = SkillTree.crit4Bought;
        crit5Bought = SkillTree.crit5Bought;

        active1Bought = SkillTree.active1Bought;
        active2Bought = SkillTree.active2Bought;
        active3Bought = SkillTree.active3Bought;
        active4Bought = SkillTree.active4Bought;
        active5Bought = SkillTree.active5Bought;
        active6Bought = SkillTree.active6Bought;

        activeCursor1Bought = SkillTree.activeCursor1Bought;
        activeCursor2Bought = SkillTree.activeCursor2Bought;
        activeCursor3Bought = SkillTree.activeCursor3Bought;
        activeCursor4Bought = SkillTree.activeCursor4Bought;

        autoClicker1Bought = SkillTree.autoClicker1Bought;
        autoClicker2Bought = SkillTree.autoClicker2Bought;
        autoClicker3Bought = SkillTree.autoClicker3Bought;
        autoClicker4Bought = SkillTree.autoClicker4Bought;

        autoDamage1Bought = SkillTree.autoDamage1Bought;
        autoDamage2Bought = SkillTree.autoDamage2Bought;
        autoDamage3Bought = SkillTree.autoDamage3Bought;
        autoDamage4Bought = SkillTree.autoDamage4Bought;
        autoDamage5Bought = SkillTree.autoDamage5Bought;
        autoDamage6Bought = SkillTree.autoDamage6Bought;
        autoDamage7Bought = SkillTree.autoDamage7Bought;

        autoCursor1Bought = SkillTree.autoCursor1Bought;
        autoCursor2Bought = SkillTree.autoCursor2Bought;
        autoCursor3Bought = SkillTree.autoCursor3Bought;
        autoCursor4Bought = SkillTree.autoCursor4Bought;

        gold1Bought = SkillTree.gold1Bought;
        gold2Bought = SkillTree.gold2Bought;
        gold3Bought = SkillTree.gold3Bought;
        gold4Bought = SkillTree.gold4Bought;
        gold5Bought = SkillTree.gold5Bought;
        gold6Bought = SkillTree.gold6Bought;
        gold7Bought = SkillTree.gold7Bought;

        drops1Bought = SkillTree.drops1Bought;
        drops2Bought = SkillTree.drops2Bought;
        drops3Bought = SkillTree.drops3Bought;
        drops4Bought = SkillTree.drops4Bought;
        drops5Bought = SkillTree.drops5Bought;
        drops6Bought = SkillTree.drops6Bought;

        xp1Bought = SkillTree.xp1Bought;
        xp2Bought = SkillTree.xp2Bought;
        xp3Bought = SkillTree.xp3Bought;
        xp4Bought = SkillTree.xp4Bought;
        xp5Bought = SkillTree.xp5Bought;
        xp6Bought = SkillTree.xp6Bought;

        levelSpecial1Bought = SkillTree.levelSpecial1Bought;
        levelSpecial2Bought = SkillTree.levelSpecial2Bought;
        levelSpecial3Bought = SkillTree.levelSpecial3Bought;
        levelSpecial4Bought = SkillTree.levelSpecial4Bought;

        strongerSpecial1Bought = SkillTree.strongerSpecial1Bought;
        strongerSpecial2Bought = SkillTree.strongerSpecial2Bought;
        strongerSpecial3Bought = SkillTree.strongerSpecial3Bought;
        strongerSpecial4Bought = SkillTree.strongerSpecial4Bought;
        strongerSpecial5Bought = SkillTree.strongerSpecial5Bought;

        startWithItem1Bought = SkillTree.startWithItem1Bought;
        startWithItem2Bought = SkillTree.startWithItem2Bought;
        startWithItem3Bought = SkillTree.startWithItem3Bought;
        startWithItem4Bought = SkillTree.startWithItem4Bought;
    }

    #endregion

    #region ACH
    public int[] achSaves = new int[92];

    public GameData(Achievements ACH)
    {
        achSaves[0] = Achievements.achSaves[0];
        achSaves[1] = Achievements.achSaves[1];
        achSaves[2] = Achievements.achSaves[2];
        achSaves[3] = Achievements.achSaves[3];
        achSaves[4] = Achievements.achSaves[4];
        achSaves[5] = Achievements.achSaves[5];
        achSaves[6] = Achievements.achSaves[6];
        achSaves[7] = Achievements.achSaves[7];
        achSaves[8] = Achievements.achSaves[8];
        achSaves[9] = Achievements.achSaves[9];
        achSaves[10] = Achievements.achSaves[10];
        achSaves[11] = Achievements.achSaves[11];
        achSaves[12] = Achievements.achSaves[12];
        achSaves[13] = Achievements.achSaves[13];
        achSaves[14] = Achievements.achSaves[14];
        achSaves[15] = Achievements.achSaves[15];
        achSaves[16] = Achievements.achSaves[16];
        achSaves[17] = Achievements.achSaves[17];
        achSaves[18] = Achievements.achSaves[18];
        achSaves[19] = Achievements.achSaves[19];
        achSaves[20] = Achievements.achSaves[20];
        achSaves[21] = Achievements.achSaves[21];
        achSaves[22] = Achievements.achSaves[22];
        achSaves[23] = Achievements.achSaves[23];
        achSaves[24] = Achievements.achSaves[24];
        achSaves[25] = Achievements.achSaves[25];
        achSaves[26] = Achievements.achSaves[26];
        achSaves[27] = Achievements.achSaves[27];
        achSaves[28] = Achievements.achSaves[28];
        achSaves[29] = Achievements.achSaves[29];
        achSaves[30] = Achievements.achSaves[30];
        achSaves[31] = Achievements.achSaves[31];
        achSaves[32] = Achievements.achSaves[32];
        achSaves[33] = Achievements.achSaves[33];
        achSaves[34] = Achievements.achSaves[34];
        achSaves[35] = Achievements.achSaves[35];
        achSaves[36] = Achievements.achSaves[36];
        achSaves[37] = Achievements.achSaves[37];
        achSaves[38] = Achievements.achSaves[38];
        achSaves[39] = Achievements.achSaves[39];
        achSaves[40] = Achievements.achSaves[40];
        achSaves[41] = Achievements.achSaves[41];
        achSaves[42] = Achievements.achSaves[42];
        achSaves[43] = Achievements.achSaves[43];
        achSaves[44] = Achievements.achSaves[44];
        achSaves[45] = Achievements.achSaves[45];
        achSaves[46] = Achievements.achSaves[46];
        achSaves[47] = Achievements.achSaves[47];
        achSaves[48] = Achievements.achSaves[48];
        achSaves[49] = Achievements.achSaves[49];
        achSaves[50] = Achievements.achSaves[50];
        achSaves[51] = Achievements.achSaves[51];
        achSaves[52] = Achievements.achSaves[52];
        achSaves[53] = Achievements.achSaves[53];
        achSaves[54] = Achievements.achSaves[54];
        achSaves[55] = Achievements.achSaves[55];
        achSaves[56] = Achievements.achSaves[56];
        achSaves[57] = Achievements.achSaves[57];
        achSaves[58] = Achievements.achSaves[58];
        achSaves[59] = Achievements.achSaves[59];
        achSaves[60] = Achievements.achSaves[60];
        achSaves[61] = Achievements.achSaves[61];
        achSaves[62] = Achievements.achSaves[62];
        achSaves[63] = Achievements.achSaves[63];
        achSaves[64] = Achievements.achSaves[64];
        achSaves[65] = Achievements.achSaves[65];
        achSaves[66] = Achievements.achSaves[66];
        achSaves[67] = Achievements.achSaves[67];
        achSaves[68] = Achievements.achSaves[68];
        achSaves[69] = Achievements.achSaves[69];
        achSaves[70] = Achievements.achSaves[70];
        achSaves[71] = Achievements.achSaves[71];
        achSaves[72] = Achievements.achSaves[72];
        achSaves[73] = Achievements.achSaves[73];
        achSaves[74] = Achievements.achSaves[74];
        achSaves[75] = Achievements.achSaves[75];
        achSaves[76] = Achievements.achSaves[76];
        achSaves[77] = Achievements.achSaves[77];
        achSaves[78] = Achievements.achSaves[78];
        achSaves[79] = Achievements.achSaves[79];
        achSaves[80] = Achievements.achSaves[80];
        achSaves[81] = Achievements.achSaves[81];
        achSaves[82] = Achievements.achSaves[82];
        achSaves[83] = Achievements.achSaves[83];
        achSaves[84] = Achievements.achSaves[84];
        achSaves[85] = Achievements.achSaves[85];
        achSaves[86] = Achievements.achSaves[86];
        achSaves[87] = Achievements.achSaves[87];
        achSaves[88] = Achievements.achSaves[88];
        achSaves[89] = Achievements.achSaves[89];
        achSaves[90] = Achievements.achSaves[90];
        achSaves[91] = Achievements.achSaves[91];
    }
    #endregion

 

}
