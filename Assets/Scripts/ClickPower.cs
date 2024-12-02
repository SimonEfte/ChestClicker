using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.IO;
public class ClickPower : MonoBehaviour, IDataPersistence 
{

    public static float clickPower;
    public TextMeshProUGUI activeDamageText;

    public static float activeClickPowerPrice;
    public static float passiveClickPowerPrice;
    public TextMeshProUGUI passiveDamagePriceText;
    public TextMeshProUGUI activeDamagePriceText;

    public static int activeUpgradeLevel, passiveUpgradeLevel;
    public TextMeshProUGUI activeLevelText, passiveLevelText;

    public TextMeshProUGUI damagePerSecondText;
    public TextMeshProUGUI passiveDamagePerSecond;
  

    public GameObject passiveClickBar, activeClickBar;
    public static bool cursorsPriceChanged;
    public static bool cursor1Change, cursor2Change, cursor3Change, cursor4Change, cursor5Change, cursor6Change, cursor7Change, cursor8Change, cursor9Change, cursor10Change, cursor11Change, cursor12Change, cursor13Change, cursor14Change, cursor15Change, cursor16Change, cursor17Change, cursor18Change, cursor19Change, cursor20Change, cursor21Change;

    //Cursors buffs. These will never change value.
    public static float activeDamageMultiplier;
    public static float passiveDamageMultiplier;
    public static float critChance;
    public static float critDamage;

    public static float p1, p2, p3, p4, p5, p6, p7;
    public static float a1, a2, a3, a4, a5, a6, a7;

    public string equippedColor = "#AEFFA0";
    public string nowEquippedColor = "#FFC6C4";

    //TopBarTexts
    public TextMeshProUGUI topPassiveDamage, topActiveDamage, topCritChance, topCritDamage;
    public TextMeshProUGUI currentlyEquippedText;

    public static float cursorEquippedChance;
    public static float cursorEquippedGoldIncrease;
    public static float cursorEquippedXPIncrease;

    //AllCursorsBuffs = 0
    public float cursor1Passive, cursor1CritChance, cursor1CritDamage;
    public float cursor2Active, cursor2CritCance, cursor2CritDamage;
    public float cursor3Actice, cursor3Passive;
    public float cursor4CritChance, cursor4CritDamage;
    public float cursor5Passive;
    public float cursor7Passive;
    public float cursor9CritChance, cursor9CritDamage;
    public float cursor10Active, cursor10CritChance, cursor10CritDamage;
    public float cursor11Passive;

    public static bool isCursorMax;

    public static double newActiveDamage, newActiveDamagePrice, newPassiveDamagePrice;

    public GameObject holdingMaxCursorText;

    public AudioManager audioManager;

    void Start()
    {
        alphaValueFull = 1f; alphavalueHalf = 0.45f;

        cursor1Passive = 0; cursor1CritChance = 0; cursor1CritDamage = 0; cursor2Active = 0; cursor2CritCance = 0; cursor2CritDamage = 0;
        cursor3Actice = 0; cursor3Passive = 0; cursor4CritChance = 0; cursor4CritDamage = 0; cursor5Passive = 0; cursor7Passive = 0;
        cursor9CritChance = 0; cursor9CritDamage = 0; cursor10Active = 0; cursor10CritChance = 0; cursor10CritDamage = 0; cursor11Passive = 0;

        p1 = 0.60f; p2 = 0.21f; p3 = 0.18f; p4 = 0.17f; p5 = 0.15f; p6 = 0.13f;

        a1 = 0.32f; a2 = 0.11f; a3 = 0.11f; a4 = 0.11f; a5 = 0.105f; a6 = 0.13f;

        StartCoroutine(wait());
    }

    public bool playSound;

    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.55f);

        string path = Application.persistentDataPath + "/player.saveClickPower";

        if (File.Exists(path))
        {
            if(SaveAndLoad.onlyLoadNewSave == false)
            {
                GameData data = SaveSystem.LoadClickPower();

                #region saves
                clickPower = data.activeClickDamage;
                activeClickPowerPrice = data.activeClickDamagePrice;
                passiveClickPowerPrice = data.passiveClickDamagePrice;
                activeUpgradeLevel = data.activeClickPowerLevel;
                passiveUpgradeLevel = data.passiveClickPowerLvel;

                //Cursor1
                Cursor1Level = data.cursor1Level;
                cursor1QuartzUpgradePrice = data.cursor1QuartzPirce;
                cursor1ActiveBuff = data.cursor1ActiveDamageBuff;
                cursor1ActiveBuffIncrement = data.cursor1ActiveIncrement;
                cursor1Equipped = data.cursor1Equipped;

                //Cursor2
                cursor2Level = data.cursor2Level;
                cursor2QuartzUpgradePrice = data.cursor2QuartzPrice;
                cursor2PassiveBuff = data.cursor2PassiveDamageBuff;
                cursor2PassiveBuffIncrement = data.cursor2PassiveIncrement;
                cursor2Equipped = data.cursor2Equipped;

                //Cursor3
                cursor3Level = data.cursor3Level;
                cursor3QuartzPrice = data.cursor3QuartzPrice;
                cursor3AmethystPrice = data.cursor3AmethystPrice;
                cursor3Equipped = data.cursor3Equipped;
                cursor3CritDamage = data.cursor3CritDamageBuff;
                cursor3CritDamageIncrement = data.cursor3CritDamageIncrement;
                cursor3CritChance = data.cursor3CritChanceBuff;
                cursor3CritChanceIncrement = data.cursor3CritChanceIncrement;

                //Cursor4
                cursor4Level = data.cursor4Level;
                cursor4ActiveDamage = data.cursor4ActiveDamage;
                cursor4ActiveDamageIncrement = data.cursor4ActiveDamageIncrement;
                cursor4PassiveDamage = data.cursor4PassiveDamage;
                cursor4PassiveDamageIncrement = data.cursor4PassiveDamageIncrement;
                cursor4Equipped = data.cursor4Equipped;

                //Cursor5
                cursor5Level = data.cursor5Level;
                cursor5ActiveDamage = data.cursor5ActiveDamage;
                cursor5ActiveDamageIncrement = data.cursor5ActiveDamageIncrement;
                cursor5CritChance = data.cursor5CritChance;
                cursor5CritChanceIncrement = data.cursor5CritChanceIncrement;
                cursor5CritDamage = data.cursor5CritDamage;
                cursor5CritDamageIncrement = data.cursor5CritDamageIncrement;
                cursor5Equipped = data.cursor5Equipped;

                //Cursor6
                cursor6Level = data.cursor6Level;
                cursor6ActiveDamage = data.cursor6ActiveDamage;
                cursor6ActiveDamageIncrement = data.cursor6ActiveDamageIncrement;
                cursor6PassiveDamage = data.cursor6PassiveDamage;
                cursor6PassiveDamageIncrement = data.cursor6PassiveDamageIncrement;
                cursor6CritChance = data.cursor6CritChance;
                cursor6CritChanceIncrement = data.cursor6CritChanceIncrement;
                cursor6CritDamage = data.cursor6CritDamage;
                cursor6CritDamageIncrement = data.cursor6CritDamageIncrement;
                cursor6Equipped = data.cursor6Equipped;

                //Cursor7
                cursor7Level = data.cursor7Level;
                cursor7ActiveDamage = data.cursor7ActiveDamage;
                cursor7ActiveDamageIncrement = data.cursor7ActiveDamageIncrement;
                cursor7CritChance = data.cursor7CritChance;
                cursor7CritChanceIncrement = data.cursor7CritChanceIncrement;
                cursor7CritDamage = data.cursor7CritDamage;
                cursor7CritDamageIncrement = data.cursor7CritDamageIncrement;
                cursor7Equipped = data.cursor7Equipped;

                //Cursor8
                cursor8Level = data.cursor8Level;
                cursor8ActiveDamage = data.cursor8ActiveDamage;
                cursor8ActiveDamageIncrement = data.cursor8ActiveDamageIncrement;
                cursor8PassiveDamage = data.cursor8PassiveDamage;
                cursor8PassiveDamageIncrement = data.cursor8PassiveDamageIncrement;
                cursor8CritChance = data.cursor8CritChance;
                cursor8CritChanceIncrement = data.cursor8CritChanceIncrement;
                cursor8CritDamage = data.cursor8CritDamage;
                cursor8CritDamageIncrement = data.cursor8CritDamageIncrement;
                cursor8Equipped = data.cursor8Equipped;

                //Cursor9
                cursor9Level = data.cursor9Level;
                cursor9ActiveDamage = data.cursor9ActiveDamage;
                cursor9ActiveDamageIncrement = data.cursor9ActiveDamageIncrement;
                cursor9PassiveDamage = data.cursor9PassiveDamage;
                cursor9PassiveDamageIncrement = data.cursor9PassiveDamageIncrement;
                cursor9Equipped = data.cursor9Equipped;

                //Cursor10
                cursor10Level = data.cursor10Level;
                cursor10PassiveDamage = data.cursor10PassiveDamage;
                cursor10PassiveDamageIncrement = data.cursor10PassiveDamageIncrement;
                cursor10Equipped = data.cursor10Equipped;

                //Cursor11
                cursor11Level = data.cursor11Level;
                cursor11ActiveDamage = data.cursor11ActiveDamage;
                cursor11ActiveDamageIncrement = data.cursor11ActiveDamageIncrement;
                cursor11CritChance = data.cursor11CritChance;
                cursor11CritChanceIncrement = data.cursor11CritChanceIncrement;
                cursor11CritDamage = data.cursor11CritDamage;
                cursor11CritDamageIncrement = data.cursor11CritDamageIncrement;
                cursor11Equipped = data.cursor11Equipped;

                //Cursor12
                cursor12Level = data.cursor12Level;
                cursor12ActiveDamage = data.cursor12ActiveDamage;
                cursor12ActiveDamageIncrement = data.cursor12ActiveDamageIncrement;
                cursor12PassiveDamage = data.cursor12PassiveDamage;
                cursor12PassiveDamageIncrement = data.cursor12PassiveDamageIncrement;
                cursor12CritChance = data.cursor12CritChance;
                cursor12CritChanceIncrement = data.cursor12CritChanceIncrement;
                cursor12CritDamage = data.cursor12CritDamage;
                cursor12CritDamageIncrement = data.cursor12CritDamageIncrement;
                cursor12Equipped = data.cursor12Equipped;

                //Cursor13
                cursor13Level = data.cursor13Level;
                cursor13ActiveDamage = data.cursor13ActiveDamage;
                cursor13ActiveDamageIncrement = data.cursor13ActiveDamageIncrement;
                cursor13PassiveDamage = data.cursor13PassiveDamage;
                cursor13PassiveDamageIncrement = data.cursor13PassiveDamageIncrement;
                cursor13CritChance = data.cursor13CritChance;
                cursor13CritChanceIncrement = data.cursor13CritChanceIncrement;
                cursor13CritDamage = data.cursor13CritDamage;
                cursor13CritDamageIncrement = data.cursor13CritDamageIncrement;
                cursor13Equipped = data.cursor13Equipped;

                //Cursor14
                cursor14Level = data.cursor14Level;
                cursor14ActiveDamage = data.cursor14ActiveDamage;
                cursor14ActiveDamageIncrement = data.cursor14ActiveDamageIncrement;
                cursor14PassiveDamage = data.cursor14PassiveDamage;
                cursor14PassiveDamageIncrement = data.cursor14PassiveDamageIncrement;
                cursor14CritChance = data.cursor14CritChance;
                cursor14CritChanceIncrement = data.cursor14CritChanceIncrement;
                cursor14CritDamage = data.cursor14CritDamage;
                cursor14CritDamageIncrement = data.cursor14CritDamageIncrement;
                cursor14Equipped = data.cursor14Equipped;

                //Cursor15
                cursor15Level = data.cursor15Level;
                cursor15ActiveDamage = data.cursor15ActiveDamage;
                cursor15ActiveDamageIncrement = data.cursor15ActiveDamageIncrement;
                cursor15PassiveDamage = data.cursor15PassiveDamage;
                cursor15PassiveDamageIncrement = data.cursor15PassiveDamageIncrement;
                cursor15CritChance = data.cursor15CritChance;
                cursor15CritChanceIncrement = data.cursor15CritChanceIncrement;
                cursor15CritDamage = data.cursor15CritDamage;
                cursor15CritDamageIncrement = data.cursor15CritDamageIncrement;
                cursor15Equipped = data.cursor15Equipped;

                //Cursor16
                cursor16Level = data.cursor16Level;
                cursor16ActiveDamage = data.cursor16ActiveDamage;
                cursor16ActiveDamageIncrement = data.cursor16ActiveDamageIncrement;
                cursor16PassiveDamage = data.cursor16PassiveDamage;
                cursor16PassiveDamageIncrement = data.cursor16PassiveDamageIncrement;
                cursor16CritChance = data.cursor16CritChance;
                cursor16CritChanceIncrement = data.cursor16CritChanceIncrement;
                cursor16CritDamage = data.cursor16CritDamage;
                cursor16CritDamageIncrement = data.cursor16CritDamageIncrement;
                cursor16Equipped = data.cursor16Equipped;

                //Cursor17
                cursor17Level = data.cursor17Level;
                cursor17ActiveDamage = data.cursor17ActiveDamage;
                cursor17ActiveDamageIncrement = data.cursor17ActiveDamageIncrement;
                cursor17PassiveDamage = data.cursor17PassiveDamage;
                cursor17PassiveDamageIncrement = data.cursor17PassiveDamageIncrement;
                cursor17CritChance = data.cursor17CritChance;
                cursor17CritChanceIncrement = data.cursor17CritChanceIncrement;
                cursor17CritDamage = data.cursor17CritDamage;
                cursor17CritDamageIncrement = data.cursor17CritDamageIncrement;
                cursor17Equipped = data.cursor17Equipped;

                //Cursor18
                cursor18Level = data.cursor18Level;
                cursor18ActiveDamage = data.cursor18ActiveDamage;
                cursor18ActiveDamageIncrement = data.cursor18ActiveDamageIncrement;
                cursor18PassiveDamage = data.cursor18PassiveDamage;
                cursor18PassiveDamageIncrement = data.cursor18PassiveDamageIncrement;
                cursor18CritChance = data.cursor18CritChance;
                cursor18CritChanceIncrement = data.cursor18CritChanceIncrement;
                cursor18CritDamage = data.cursor18CritDamage;
                cursor18CritDamageIncrement = data.cursor18CritDamageIncrement;
                cursor18Equipped = data.cursor18Equipped;

                cursor4TopazPrice = data.cursor4TopazPrice;
                cursor5AlbitePrice = data.cursor5AlbitePrice;
                cursor6AlbitePrice = data.cursor6albitePrice;
                cursor6RedGarnetPrice = data.cursor6RedGarnetPrice;
                cursor7AquamarinePrice = data.cursor7AquamarinePrice;
                cursor8AquamarinePrice = data.cursor8AquamarinePrice;
                cursor8YellowSapphirePrice = data.cursor8YellopSapphirePrice;
                cursor9PinkTourmalinePrice = data.cursor9PinkTourmalinePrice;
                cursor10AdventurinePrice = data.cursor10AdventurinePrice;
                cursor11AdventurinePrice = data.cursor11AdventurinePrice;
                cursor11PinkTourmalinePrice = data.cursor11PinkTourmalinePrice;
                cursor12AdventurinePrice = data.cursor12AdventurinePrice;
                cursor12RedRubyPrice = data.cursor12RedRubyPrice;
                cursor13DiamondPrice = data.cursor13DiamondPrice;
                cursor13GrandideritePrice = data.cursor13GrandideritePrice;
                cursor14VioletCrystalPrice = data.cursor14VioletCrystalPrice;
                cursor14GrandideritePrice = data.cursor14GrandideritePrice;
                cursor15AkoyaPeralPrice = data.cursor15AkoyaPearlPrice;
                cursor15PurpleRupeePrice = data.cursor15PurpleRupeePrice;
                cursor15EmeraldPrice = data.cursor15EmeraldPrice;
                cursor16GreenDiamondPrice = data.cursor16GreenDiamondPrice;
                cursor16FireOpalPrice = data.cursor16FireOpalPrice;
                cursor16GemSilicaPrice = data.cursor16GemSilicaPrice;
                cursor17PinkPlortPrice = data.cursor17PinkPlortPrice;
                cursor17GoldenSeaPEarlPrice = data.cursor17GoldenSeaPearlPrice;
                cursor17KyanitePrice = data.cursor17KyanitePrice;
                cursor18BlackOpalPrice = data.cursor18BlackOpalPrice;
                cursor18PainitePrice = data.cursor18PainitePrice;
                cursor18TanzanitePrice = data.cursor18TanzanitePrice;

                newActiveDamage = clickPower;
                newActiveDamagePrice = activeClickPowerPrice;
                newPassiveDamagePrice = passiveClickPowerPrice;
                #endregion
            }
        }
        else
        {
            //Do nothing
        }

        setCursorsZero();
        if (cursor1Equipped == 1) { EquippCursor1(); }
        else if (cursor2Equipped == 1) { EquippCursor2(); }
        else if (cursor3Equipped == 1) { EquippCursor3(); }
        else if (cursor4Equipped == 1) { EquippCursor4(); }
        else if (cursor5Equipped == 1) { EquippCursor5(); }
        else if (cursor6Equipped == 1) { EquippCursor6(); }
        else if (cursor7Equipped == 1) { EquippCursor7(); }
        else if (cursor8Equipped == 1) { EquippCursor8(); }
        else if (cursor9Equipped == 1) { EquippCursor9(); }
        else if (cursor10Equipped == 1) { EquippCursor10(); }
        else if (cursor11Equipped == 1) { EquippCursor11(); }
        else if (cursor12Equipped == 1) { EquippCursor12(); }
        else if (cursor13Equipped == 1) { EquippCursor13(); }
        else if (cursor14Equipped == 1) { EquippCursor14(); }
        else if (cursor15Equipped == 1) { EquippCursor15(); }
        else if (cursor16Equipped == 1) { EquippCursor16(); }
        else if (cursor17Equipped == 1) { EquippCursor17(); }
        else if (cursor18Equipped == 1) { EquippCursor18(); }
        else if (cursor19Equipped == 1) { EquippCursor19(); }
        else if (cursor20Equipped == 1) { EquippCursor20(); }
        else if (cursor21Equipped == 1) { EquippCursor21(); }
        else { currentlyEquippedText.text = Localization.equippedNONE; }

        //New
        if (newActiveDamage > 1000000000) { activeIncrease = a6; }
        else if (newActiveDamage > 1000000) { activeIncrease = a5; }
        else if (newActiveDamage > 10000) { activeIncrease = a4; }
        else if (newActiveDamage > 100) { activeIncrease = a3; }
        else if (newActiveDamage > 10) { activeIncrease = a2; }
        else if (newActiveDamage < 10) { activeIncrease = a1; }

        //NEW
        if (HealthBar.newPassiveDamage > 1000000000) { passiveIncrease = p6; }
        else if (HealthBar.newPassiveDamage > 1000000) { passiveIncrease = p5; }
        else if (HealthBar.newPassiveDamage > 10000) { passiveIncrease = p4; }
        else if (HealthBar.newPassiveDamage > 100) { passiveIncrease = p3; }
        else if (HealthBar.newPassiveDamage > 10) { passiveIncrease = p2; }
        else if (HealthBar.newPassiveDamage < 10) { passiveIncrease = p1; }

        //Active

        //NEW
        if (newActiveDamage < 10) { activeDamageText.text = (newActiveDamage.ToString("F2")) + Localization.clickDamage + " <color=green>(+" + (newActiveDamage * activeIncrease).ToString("F2") + ")<color=green>"; }
        if (newActiveDamage > 10) { activeDamageText.text = TotalGoldAmount.FormatCoinsDoubleOneLetter(newActiveDamage) + Localization.clickDamage + " <color=green>(+" + TotalGoldAmount.FormatCoinsDoubleOneLetter(newActiveDamage * activeIncrease) + ")<color=green>"; }


        SetTopText();
        cursorsPriceChanged = true;

        cursor1Change = true; cursor2Change = true; cursor3Change = true; cursor4Change = true; cursor5Change = true; cursor6Change = true; cursor7Change = true;
        cursor8Change = true; cursor9Change = true; cursor10Change = true; cursor11Change = true; cursor12Change = true; cursor13Change = true; cursor14Change = true;
        cursor15Change = true; cursor16Change = true; cursor17Change = true; cursor18Change = true; cursor19Change = true; cursor20Change = true; cursor21Change = true;

        SetNewAutoDamage();
        playSound = true;
    }

    #region SaveAndLoadJSON
    public void LoadData(GameDataJSON data)
    {
        clickPower = data.activeClickDamage;
        activeClickPowerPrice = data.activeClickDamagePrice;
        passiveClickPowerPrice = data.passiveClickDamagePrice;
        activeUpgradeLevel = data.activeClickPowerLevel;
        passiveUpgradeLevel = data.passiveClickPowerLvel;

        Cursor1Level = data.cursor1Level;
        cursor1QuartzUpgradePrice = data.cursor1QuartzPirce;
        cursor1ActiveBuff = data.cursor1ActiveDamageBuff;
        cursor1ActiveBuffIncrement = data.cursor1ActiveIncrement;
        cursor1Equipped = data.cursor1Equipped;

        cursor2Level = data.cursor2Level;
        cursor2QuartzUpgradePrice = data.cursor2QuartzPrice;
        cursor2PassiveBuff = data.cursor2PassiveDamageBuff;
        cursor2PassiveBuffIncrement = data.cursor2PassiveIncrement;
        cursor2Equipped = data.cursor2Equipped;

        cursor3Level = data.cursor3Level;
        cursor3QuartzPrice = data.cursor3QuartzPrice;
        cursor3AmethystPrice = data.cursor3AmethystPrice;
        cursor3Equipped = data.cursor3Equipped;
        cursor3CritDamage = data.cursor3CritDamageBuff;
        cursor3CritDamageIncrement = data.cursor3CritDamageIncrement;
        cursor3CritChance = data.cursor3CritChanceBuff;
        cursor3CritChanceIncrement = data.cursor3CritChanceIncrement;

        cursor4Level = data.cursor4Level;
        cursor4ActiveDamage = data.cursor4ActiveDamage;
        cursor4ActiveDamageIncrement = data.cursor4ActiveDamageIncrement;
        cursor4PassiveDamage = data.cursor4PassiveDamage;
        cursor4PassiveDamageIncrement = data.cursor4PassiveDamageIncrement;
        cursor4Equipped = data.cursor4Equipped;

        cursor5Level = data.cursor5Level;
        cursor5ActiveDamage = data.cursor5ActiveDamage;
        cursor5ActiveDamageIncrement = data.cursor5ActiveDamageIncrement;
        cursor5CritChance = data.cursor5CritChance;
        cursor5CritChanceIncrement = data.cursor5CritChanceIncrement;
        cursor5CritDamage = data.cursor5CritDamage;
        cursor5CritDamageIncrement = data.cursor5CritDamageIncrement;
        cursor5Equipped = data.cursor5Equipped;

        cursor6Level = data.cursor6Level;
        cursor6ActiveDamage = data.cursor6ActiveDamage;
        cursor6ActiveDamageIncrement = data.cursor6ActiveDamageIncrement;
        cursor6PassiveDamage = data.cursor6PassiveDamage;
        cursor6PassiveDamageIncrement = data.cursor6PassiveDamageIncrement;
        cursor6CritChance = data.cursor6CritChance;
        cursor6CritChanceIncrement = data.cursor6CritChanceIncrement;
        cursor6CritDamage = data.cursor6CritDamage;
        cursor6CritDamageIncrement = data.cursor6CritDamageIncrement;
        cursor6Equipped = data.cursor6Equipped;

        cursor7Level = data.cursor7Level;
        cursor7ActiveDamage = data.cursor7ActiveDamage;
        cursor7ActiveDamageIncrement = data.cursor7ActiveDamageIncrement;
        cursor7CritChance = data.cursor7CritChance;
        cursor7CritChanceIncrement = data.cursor7CritChanceIncrement;
        cursor7CritDamage = data.cursor7CritDamage;
        cursor7CritDamageIncrement = data.cursor7CritDamageIncrement;
        cursor7Equipped = data.cursor7Equipped;

        cursor8Level = data.cursor8Level;
        cursor8ActiveDamage = data.cursor8ActiveDamage;
        cursor8ActiveDamageIncrement = data.cursor8ActiveDamageIncrement;
        cursor8PassiveDamage = data.cursor8PassiveDamage;
        cursor8PassiveDamageIncrement = data.cursor8PassiveDamageIncrement;
        cursor8CritChance = data.cursor8CritChance;
        cursor8CritChanceIncrement = data.cursor8CritChanceIncrement;
        cursor8CritDamage = data.cursor8CritDamage;
        cursor8CritDamageIncrement = data.cursor8CritDamageIncrement;
        cursor8Equipped = data.cursor8Equipped;

        cursor9Level = data.cursor9Level;
        cursor9ActiveDamage = data.cursor9ActiveDamage;
        cursor9ActiveDamageIncrement = data.cursor9ActiveDamageIncrement;
        cursor9PassiveDamage = data.cursor9PassiveDamage;
        cursor9PassiveDamageIncrement = data.cursor9PassiveDamageIncrement;
        cursor9Equipped = data.cursor9Equipped;

        cursor10Level = data.cursor10Level;
        cursor10PassiveDamage = data.cursor10PassiveDamage;
        cursor10PassiveDamageIncrement = data.cursor10PassiveDamageIncrement;
        cursor10Equipped = data.cursor10Equipped;

        cursor11Level = data.cursor11Level;
        cursor11ActiveDamage = data.cursor11ActiveDamage;
        cursor11ActiveDamageIncrement = data.cursor11ActiveDamageIncrement;
        cursor11CritChance = data.cursor11CritChance;
        cursor11CritChanceIncrement = data.cursor11CritChanceIncrement;
        cursor11CritDamage = data.cursor11CritDamage;
        cursor11CritDamageIncrement = data.cursor11CritDamageIncrement;
        cursor11Equipped = data.cursor11Equipped;

        cursor12Level = data.cursor12Level;
        cursor12ActiveDamage = data.cursor12ActiveDamage;
        cursor12ActiveDamageIncrement = data.cursor12ActiveDamageIncrement;
        cursor12PassiveDamage = data.cursor12PassiveDamage;
        cursor12PassiveDamageIncrement = data.cursor12PassiveDamageIncrement;
        cursor12CritChance = data.cursor12CritChance;
        cursor12CritChanceIncrement = data.cursor12CritChanceIncrement;
        cursor12CritDamage = data.cursor12CritDamage;
        cursor12CritDamageIncrement = data.cursor12CritDamageIncrement;
        cursor12Equipped = data.cursor12Equipped;

        cursor13Level = data.cursor13Level;
        cursor13ActiveDamage = data.cursor13ActiveDamage;
        cursor13ActiveDamageIncrement = data.cursor13ActiveDamageIncrement;
        cursor13PassiveDamage = data.cursor13PassiveDamage;
        cursor13PassiveDamageIncrement = data.cursor13PassiveDamageIncrement;
        cursor13CritChance = data.cursor13CritChance;
        cursor13CritChanceIncrement = data.cursor13CritChanceIncrement;
        cursor13CritDamage = data.cursor13CritDamage;
        cursor13CritDamageIncrement = data.cursor13CritDamageIncrement;
        cursor13Equipped = data.cursor13Equipped;

        cursor14Level = data.cursor14Level;
        cursor14ActiveDamage = data.cursor14ActiveDamage;
        cursor14ActiveDamageIncrement = data.cursor14ActiveDamageIncrement;
        cursor14PassiveDamage = data.cursor14PassiveDamage;
        cursor14PassiveDamageIncrement = data.cursor14PassiveDamageIncrement;
        cursor14CritChance = data.cursor14CritChance;
        cursor14CritChanceIncrement = data.cursor14CritChanceIncrement;
        cursor14CritDamage = data.cursor14CritDamage;
        cursor14CritDamageIncrement = data.cursor14CritDamageIncrement;
        cursor14Equipped = data.cursor14Equipped;

        cursor15Level = data.cursor15Level;
        cursor15ActiveDamage = data.cursor15ActiveDamage;
        cursor15ActiveDamageIncrement = data.cursor15ActiveDamageIncrement;
        cursor15PassiveDamage = data.cursor15PassiveDamage;
        cursor15PassiveDamageIncrement = data.cursor15PassiveDamageIncrement;
        cursor15CritChance = data.cursor15CritChance;
        cursor15CritChanceIncrement = data.cursor15CritChanceIncrement;
        cursor15CritDamage = data.cursor15CritDamage;
        cursor15CritDamageIncrement = data.cursor15CritDamageIncrement;
        cursor15Equipped = data.cursor15Equipped;

        cursor16Level = data.cursor16Level;
        cursor16ActiveDamage = data.cursor16ActiveDamage;
        cursor16ActiveDamageIncrement = data.cursor16ActiveDamageIncrement;
        cursor16PassiveDamage = data.cursor16PassiveDamage;
        cursor16PassiveDamageIncrement = data.cursor16PassiveDamageIncrement;
        cursor16CritChance = data.cursor16CritChance;
        cursor16CritChanceIncrement = data.cursor16CritChanceIncrement;
        cursor16CritDamage = data.cursor16CritDamage;
        cursor16CritDamageIncrement = data.cursor16CritDamageIncrement;
        cursor16Equipped = data.cursor16Equipped;

        cursor17Level = data.cursor17Level;
        cursor17ActiveDamage = data.cursor17ActiveDamage;
        cursor17ActiveDamageIncrement = data.cursor17ActiveDamageIncrement;
        cursor17PassiveDamage = data.cursor17PassiveDamage;
        cursor17PassiveDamageIncrement = data.cursor17PassiveDamageIncrement;
        cursor17CritChance = data.cursor17CritChance;
        cursor17CritChanceIncrement = data.cursor17CritChanceIncrement;
        cursor17CritDamage = data.cursor17CritDamage;
        cursor17CritDamageIncrement = data.cursor17CritDamageIncrement;
        cursor17Equipped = data.cursor17Equipped;

        cursor18Level = data.cursor18Level;
        cursor18ActiveDamage = data.cursor18ActiveDamage;
        cursor18ActiveDamageIncrement = data.cursor18ActiveDamageIncrement;
        cursor18PassiveDamage = data.cursor18PassiveDamage;
        cursor18PassiveDamageIncrement = data.cursor18PassiveDamageIncrement;
        cursor18CritChance = data.cursor18CritChance;
        cursor18CritChanceIncrement = data.cursor18CritChanceIncrement;
        cursor18CritDamage = data.cursor18CritDamage;
        cursor18CritDamageIncrement = data.cursor18CritDamageIncrement;
        cursor18Equipped = data.cursor18Equipped;

        //New cursors
        cursor19Level = data.cursor19Level;
        cursor19ActiveDamage = data.cursor19ActiveDamage;
        cursor19ActiveDamageIncrement = data.cursor19ActiveDamageIncrement;
        cursor19PassiveDamage = data.cursor19PassiveDamage;
        cursor19PassiveDamageIncrement = data.cursor19PassiveDamageIncrement;
        cursor19CritChance = data.cursor19CritChance;
        cursor19CritChanceIncrement = data.cursor19CritChanceIncrement;
        cursor19CritDamage = data.cursor19CritDamage;
        cursor19CritDamageIncrement = data.cursor19CritDamageIncrement;
        cursor19Equipped = data.cursor19Equipped;

        cursor20Level = data.cursor20Level;
        cursor20ActiveDamage = data.cursor20ActiveDamage;
        cursor20ActiveDamageIncrement = data.cursor20ActiveDamageIncrement;
        cursor20PassiveDamage = data.cursor20PassiveDamage;
        cursor20PassiveDamageIncrement = data.cursor20PassiveDamageIncrement;
        cursor20CritChance = data.cursor20CritChance;
        cursor20CritChanceIncrement = data.cursor20CritChanceIncrement;
        cursor20CritDamage = data.cursor20CritDamage;
        cursor20CritDamageIncrement = data.cursor20CritDamageIncrement;
        cursor20Equipped = data.cursor20Equipped;

        cursor21Level = data.cursor21Level;
        cursor21ActiveDamage = data.cursor21ActiveDamage;
        cursor21ActiveDamageIncrement = data.cursor21ActiveDamageIncrement;
        cursor21PassiveDamage = data.cursor21PassiveDamage;
        cursor21PassiveDamageIncrement = data.cursor21PassiveDamageIncrement;
        cursor21CritChance = data.cursor21CritChance;
        cursor21CritChanceIncrement = data.cursor21CritChanceIncrement;
        cursor21CritDamage = data.cursor21CritDamage;
        cursor21CritDamageIncrement = data.cursor21CritDamageIncrement;
        cursor21Equipped = data.cursor21Equipped;


        cursor4TopazPrice = data.cursor4TopazPrice;
        cursor5AlbitePrice = data.cursor5AlbitePrice;
        cursor6AlbitePrice = data.cursor6albitePrice;
        cursor6RedGarnetPrice = data.cursor6RedGarnetPrice;
        cursor7AquamarinePrice = data.cursor7AquamarinePrice;
        cursor8AquamarinePrice = data.cursor8AquamarinePrice;
        cursor8YellowSapphirePrice = data.cursor8YellopSapphirePrice;
        cursor9PinkTourmalinePrice = data.cursor9PinkTourmalinePrice;
        cursor10AdventurinePrice = data.cursor10AdventurinePrice;
        cursor11AdventurinePrice = data.cursor11AdventurinePrice;
        cursor11PinkTourmalinePrice = data.cursor11PinkTourmalinePrice;
        cursor12AdventurinePrice = data.cursor12AdventurinePrice;
        cursor12RedRubyPrice = data.cursor12RedRubyPrice;
        cursor13DiamondPrice = data.cursor13DiamondPrice;
        cursor13GrandideritePrice = data.cursor13GrandideritePrice;
        cursor14VioletCrystalPrice = data.cursor14VioletCrystalPrice;
        cursor14GrandideritePrice = data.cursor14GrandideritePrice;
        cursor15AkoyaPeralPrice = data.cursor15AkoyaPearlPrice;
        cursor15PurpleRupeePrice = data.cursor15PurpleRupeePrice;
        cursor15EmeraldPrice = data.cursor15EmeraldPrice;
        cursor16GreenDiamondPrice = data.cursor16GreenDiamondPrice;
        cursor16FireOpalPrice = data.cursor16FireOpalPrice;
        cursor16GemSilicaPrice = data.cursor16GemSilicaPrice;
        cursor17PinkPlortPrice = data.cursor17PinkPlortPrice;
        cursor17GoldenSeaPEarlPrice = data.cursor17GoldenSeaPearlPrice;
        cursor17KyanitePrice = data.cursor17KyanitePrice;
        cursor18BlackOpalPrice = data.cursor18BlackOpalPrice;
        cursor18PainitePrice = data.cursor18PainitePrice;
        cursor18TanzanitePrice = data.cursor18TanzanitePrice;

        //New gem prices
        cursor19AstraliumPrice = data.cursor19AstraliumPrice;
        cursor19ElysiumPrismPrice = data.cursor19ElysiumPrismPrice;
        cursor19AerthfireOpalPrice = data.cursor19AerthfireOpalPrice;
        cursor20EldritchStarStonePrice = data.cursor20EldritchStarStonePrice;
        cursor20ChronolithShardPrice = data.cursor20ChronolithShardPrice;
        cursor20SideriumEssencePrice = data.cursor20SideriumEssencePrice;
        cursor21QuasaritePrice = data.cursor21QuasaritePrice;
        cursor21RadiantNovaStonePrice = data.cursor21RadiantNovaStonePrice;
        cursor21SoluniumShardPrice = data.cursor21SoluniumShardPrice;

        newActiveDamage = data.activeDamageTotal;
        newActiveDamagePrice = data.activeDamagePriceTotal;
        newPassiveDamagePrice = data.passiveDamagePriceTotal;
    }

    public void SaveData(ref GameDataJSON data)
    {
        data.activeClickDamage = clickPower;
        data.activeClickDamagePrice = activeClickPowerPrice;
        data.passiveClickDamagePrice = passiveClickPowerPrice;
        data.activeClickPowerLevel = activeUpgradeLevel;
        data.passiveClickPowerLvel = passiveUpgradeLevel;

        data.cursor1Level = Cursor1Level;
        data.cursor1QuartzPirce = cursor1QuartzUpgradePrice;
        data.cursor1ActiveDamageBuff = cursor1ActiveBuff;
        data.cursor1ActiveIncrement = cursor1ActiveBuffIncrement;
        data.cursor1Equipped = cursor1Equipped;

        data.cursor2Level = cursor2Level;
        data.cursor2QuartzPrice = cursor2QuartzUpgradePrice;
        data.cursor2PassiveDamageBuff = cursor2PassiveBuff;
        data.cursor2PassiveIncrement = cursor2PassiveBuffIncrement;
        data.cursor2Equipped = cursor2Equipped;

        data.cursor3Level = cursor3Level;
        data.cursor3QuartzPrice = cursor3QuartzPrice;
        data.cursor3AmethystPrice = cursor3AmethystPrice;
        data.cursor3Equipped = cursor3Equipped;
        data.cursor3CritDamageBuff = cursor3CritDamage;
        data.cursor3CritDamageIncrement = cursor3CritDamageIncrement;
        data.cursor3CritChanceBuff = cursor3CritChance;
        data.cursor3CritChanceIncrement = cursor3CritChanceIncrement;

        data.cursor4Level = cursor4Level;
        data.cursor4ActiveDamage = cursor4ActiveDamage;
        data.cursor4ActiveDamageIncrement = cursor4ActiveDamageIncrement;
        data.cursor4PassiveDamage = cursor4PassiveDamage;
        data.cursor4PassiveDamageIncrement = cursor4PassiveDamageIncrement;
        data.cursor4Equipped = cursor4Equipped;

        data.cursor5Level = cursor5Level;
        data.cursor5ActiveDamage = cursor5ActiveDamage;
        data.cursor5ActiveDamageIncrement = cursor5ActiveDamageIncrement;
        data.cursor5CritChance = cursor5CritChance;
        data.cursor5CritChanceIncrement = cursor5CritChanceIncrement;
        data.cursor5CritDamage = cursor5CritDamage;
        data.cursor5CritDamageIncrement = cursor5CritDamageIncrement;
        data.cursor5Equipped = cursor5Equipped;

        data.cursor6Level = cursor6Level;
        data.cursor6ActiveDamage = cursor6ActiveDamage;
        data.cursor6ActiveDamageIncrement = cursor6ActiveDamageIncrement;
        data.cursor6PassiveDamage = cursor6PassiveDamage;
        data.cursor6PassiveDamageIncrement = cursor6PassiveDamageIncrement;
        data.cursor6CritChance = cursor6CritChance;
        data.cursor6CritChanceIncrement = cursor6CritChanceIncrement;
        data.cursor6CritDamage = cursor6CritDamage;
        data.cursor6CritDamageIncrement = cursor6CritDamageIncrement;
        data.cursor6Equipped = cursor6Equipped;

        data.cursor7Level = cursor7Level;
        data.cursor7ActiveDamage = cursor7ActiveDamage;
        data.cursor7ActiveDamageIncrement = cursor7ActiveDamageIncrement;
        data.cursor7CritChance = cursor7CritChance;
        data.cursor7CritChanceIncrement = cursor7CritChanceIncrement;
        data.cursor7CritDamage = cursor7CritDamage;
        data.cursor7CritDamageIncrement = cursor7CritDamageIncrement;
        data.cursor7Equipped = cursor7Equipped;

        data.cursor8Level = cursor8Level;
        data.cursor8ActiveDamage = cursor8ActiveDamage;
        data.cursor8ActiveDamageIncrement = cursor8ActiveDamageIncrement;
        data.cursor8PassiveDamage = cursor8PassiveDamage;
        data.cursor8PassiveDamageIncrement = cursor8PassiveDamageIncrement;
        data.cursor8CritChance = cursor8CritChance;
        data.cursor8CritChanceIncrement = cursor8CritChanceIncrement;
        data.cursor8CritDamage = cursor8CritDamage;
        data.cursor8CritDamageIncrement = cursor8CritDamageIncrement;
        data.cursor8Equipped = cursor8Equipped;

        data.cursor9Level = cursor9Level;
        data.cursor9ActiveDamage = cursor9ActiveDamage;
        data.cursor9ActiveDamageIncrement = cursor9ActiveDamageIncrement;
        data.cursor9PassiveDamage = cursor9PassiveDamage;
        data.cursor9PassiveDamageIncrement = cursor9PassiveDamageIncrement;
        data.cursor9Equipped = cursor9Equipped;

        data.cursor10Level = cursor10Level;
        data.cursor10PassiveDamage = cursor10PassiveDamage;
        data.cursor10PassiveDamageIncrement = cursor10PassiveDamageIncrement;
        data.cursor10Equipped = cursor10Equipped;

        data.cursor11Level = cursor11Level;
        data.cursor11ActiveDamage = cursor11ActiveDamage;
        data.cursor11ActiveDamageIncrement = cursor11ActiveDamageIncrement;
        data.cursor11CritChance = cursor11CritChance;
        data.cursor11CritChanceIncrement = cursor11CritChanceIncrement;
        data.cursor11CritDamage = cursor11CritDamage;
        data.cursor11CritDamageIncrement = cursor11CritDamageIncrement;
        data.cursor11Equipped = cursor11Equipped;

        data.cursor12Level = cursor12Level;
        data.cursor12ActiveDamage = cursor12ActiveDamage;
        data.cursor12ActiveDamageIncrement = cursor12ActiveDamageIncrement;
        data.cursor12PassiveDamage = cursor12PassiveDamage;
        data.cursor12PassiveDamageIncrement = cursor12PassiveDamageIncrement;
        data.cursor12CritChance = cursor12CritChance;
        data.cursor12CritChanceIncrement = cursor12CritChanceIncrement;
        data.cursor12CritDamage = cursor12CritDamage;
        data.cursor12CritDamageIncrement = cursor12CritDamageIncrement;
        data.cursor12Equipped = cursor12Equipped;

        data.cursor13Level = cursor13Level;
        data.cursor13ActiveDamage = cursor13ActiveDamage;
        data.cursor13ActiveDamageIncrement = cursor13ActiveDamageIncrement;
        data.cursor13PassiveDamage = cursor13PassiveDamage;
        data.cursor13PassiveDamageIncrement = cursor13PassiveDamageIncrement;
        data.cursor13CritChance = cursor13CritChance;
        data.cursor13CritChanceIncrement = cursor13CritChanceIncrement;
        data.cursor13CritDamage = cursor13CritDamage;
        data.cursor13CritDamageIncrement = cursor13CritDamageIncrement;
        data.cursor13Equipped = cursor13Equipped;

        data.cursor14Level = cursor14Level;
        data.cursor14ActiveDamage = cursor14ActiveDamage;
        data.cursor14ActiveDamageIncrement = cursor14ActiveDamageIncrement;
        data.cursor14PassiveDamage = cursor14PassiveDamage;
        data.cursor14PassiveDamageIncrement = cursor14PassiveDamageIncrement;
        data.cursor14CritChance = cursor14CritChance;
        data.cursor14CritChanceIncrement = cursor14CritChanceIncrement;
        data.cursor14CritDamage = cursor14CritDamage;
        data.cursor14CritDamageIncrement = cursor14CritDamageIncrement;
        data.cursor14Equipped = cursor14Equipped;

        data.cursor15Level = cursor15Level;
        data.cursor15ActiveDamage = cursor15ActiveDamage;
        data.cursor15ActiveDamageIncrement = cursor15ActiveDamageIncrement;
        data.cursor15PassiveDamage = cursor15PassiveDamage;
        data.cursor15PassiveDamageIncrement = cursor15PassiveDamageIncrement;
        data.cursor15CritChance = cursor15CritChance;
        data.cursor15CritChanceIncrement = cursor15CritChanceIncrement;
        data.cursor15CritDamage = cursor15CritDamage;
        data.cursor15CritDamageIncrement = cursor15CritDamageIncrement;
        data.cursor15Equipped = cursor15Equipped;

        data.cursor16Level = cursor16Level;
        data.cursor16ActiveDamage = cursor16ActiveDamage;
        data.cursor16ActiveDamageIncrement = cursor16ActiveDamageIncrement;
        data.cursor16PassiveDamage = cursor16PassiveDamage;
        data.cursor16PassiveDamageIncrement = cursor16PassiveDamageIncrement;
        data.cursor16CritChance = cursor16CritChance;
        data.cursor16CritChanceIncrement = cursor16CritChanceIncrement;
        data.cursor16CritDamage = cursor16CritDamage;
        data.cursor16CritDamageIncrement = cursor16CritDamageIncrement;
        data.cursor16Equipped = cursor16Equipped;

        data.cursor17Level = cursor17Level;
        data.cursor17ActiveDamage = cursor17ActiveDamage;
        data.cursor17ActiveDamageIncrement = cursor17ActiveDamageIncrement;
        data.cursor17PassiveDamage = cursor17PassiveDamage;
        data.cursor17PassiveDamageIncrement = cursor17PassiveDamageIncrement;
        data.cursor17CritChance = cursor17CritChance;
        data.cursor17CritChanceIncrement = cursor17CritChanceIncrement;
        data.cursor17CritDamage = cursor17CritDamage;
        data.cursor17CritDamageIncrement = cursor17CritDamageIncrement;
        data.cursor17Equipped = cursor17Equipped;

        data.cursor18Level = cursor18Level;
        data.cursor18ActiveDamage = cursor18ActiveDamage;
        data.cursor18ActiveDamageIncrement = cursor18ActiveDamageIncrement;
        data.cursor18PassiveDamage = cursor18PassiveDamage;
        data.cursor18PassiveDamageIncrement = cursor18PassiveDamageIncrement;
        data.cursor18CritChance = cursor18CritChance;
        data.cursor18CritChanceIncrement = cursor18CritChanceIncrement;
        data.cursor18CritDamage = cursor18CritDamage;
        data.cursor18CritDamageIncrement = cursor18CritDamageIncrement;
        data.cursor18Equipped = cursor18Equipped;


        //New cursors
        data.cursor19Level = cursor19Level;
        data.cursor19ActiveDamage = cursor19ActiveDamage;
        data.cursor19ActiveDamageIncrement = cursor19ActiveDamageIncrement;
        data.cursor19PassiveDamage = cursor19PassiveDamage;
        data.cursor19PassiveDamageIncrement = cursor19PassiveDamageIncrement;
        data.cursor19CritChance = cursor19CritChance;
        data.cursor19CritChanceIncrement = cursor19CritChanceIncrement;
        data.cursor19CritDamage = cursor19CritDamage;
        data.cursor19CritDamageIncrement = cursor19CritDamageIncrement;
        data.cursor19Equipped = cursor19Equipped;

        data.cursor20Level = cursor20Level;
        data.cursor20ActiveDamage = cursor20ActiveDamage;
        data.cursor20ActiveDamageIncrement = cursor20ActiveDamageIncrement;
        data.cursor20PassiveDamage = cursor20PassiveDamage;
        data.cursor20PassiveDamageIncrement = cursor20PassiveDamageIncrement;
        data.cursor20CritChance = cursor20CritChance;
        data.cursor20CritChanceIncrement = cursor20CritChanceIncrement;
        data.cursor20CritDamage = cursor20CritDamage;
        data.cursor20CritDamageIncrement = cursor20CritDamageIncrement;
        data.cursor20Equipped = cursor20Equipped;

        data.cursor21Level = cursor21Level;
        data.cursor21ActiveDamage = cursor21ActiveDamage;
        data.cursor21ActiveDamageIncrement = cursor21ActiveDamageIncrement;
        data.cursor21PassiveDamage = cursor21PassiveDamage;
        data.cursor21PassiveDamageIncrement = cursor21PassiveDamageIncrement;
        data.cursor21CritChance = cursor21CritChance;
        data.cursor21CritChanceIncrement = cursor21CritChanceIncrement;
        data.cursor21CritDamage = cursor21CritDamage;
        data.cursor21CritDamageIncrement = cursor21CritDamageIncrement;
        data.cursor21Equipped = cursor21Equipped;

        data.cursor4TopazPrice = cursor4TopazPrice;
        data.cursor5AlbitePrice = cursor5AlbitePrice;
        data.cursor6albitePrice = cursor6AlbitePrice;
        data.cursor6RedGarnetPrice = cursor6RedGarnetPrice;
        data.cursor7AquamarinePrice = cursor7AquamarinePrice;
        data.cursor8AquamarinePrice = cursor8AquamarinePrice;
        data.cursor8YellopSapphirePrice = cursor8YellowSapphirePrice;
        data.cursor9PinkTourmalinePrice = cursor9PinkTourmalinePrice;
        data.cursor10AdventurinePrice = cursor10AdventurinePrice;
        data.cursor11AdventurinePrice = cursor11AdventurinePrice;
        data.cursor11PinkTourmalinePrice = cursor11PinkTourmalinePrice;
        data.cursor12AdventurinePrice = cursor12AdventurinePrice;
        data.cursor12RedRubyPrice = cursor12RedRubyPrice;
        data.cursor13DiamondPrice = cursor13DiamondPrice;
        data.cursor13GrandideritePrice = cursor13GrandideritePrice;
        data.cursor14VioletCrystalPrice = cursor14VioletCrystalPrice;
        data.cursor14GrandideritePrice = cursor14GrandideritePrice;
        data.cursor15AkoyaPearlPrice = cursor15AkoyaPeralPrice;
        data.cursor15PurpleRupeePrice = cursor15PurpleRupeePrice;
        data.cursor15EmeraldPrice = cursor15EmeraldPrice;
        data.cursor16GreenDiamondPrice = cursor16GreenDiamondPrice;
        data.cursor16FireOpalPrice = cursor16FireOpalPrice;
        data.cursor16GemSilicaPrice = cursor16GemSilicaPrice;
        data.cursor17PinkPlortPrice = cursor17PinkPlortPrice;
        data.cursor17GoldenSeaPearlPrice = cursor17GoldenSeaPEarlPrice;
        data.cursor17KyanitePrice = cursor17KyanitePrice;
        data.cursor18BlackOpalPrice = cursor18BlackOpalPrice;
        data.cursor18PainitePrice = cursor18PainitePrice;
        data.cursor18TanzanitePrice = cursor18TanzanitePrice;

        //New gem prices
        data.cursor19AstraliumPrice = cursor19AstraliumPrice;
        data.cursor19ElysiumPrismPrice = cursor19ElysiumPrismPrice;
        data.cursor19AerthfireOpalPrice = cursor19AerthfireOpalPrice;
        data.cursor20EldritchStarStonePrice = cursor20EldritchStarStonePrice;
        data.cursor20ChronolithShardPrice = cursor20ChronolithShardPrice;
        data.cursor20SideriumEssencePrice = cursor20SideriumEssencePrice;
        data.cursor21QuasaritePrice = cursor21QuasaritePrice;
        data.cursor21RadiantNovaStonePrice = cursor21RadiantNovaStonePrice;
        data.cursor21SoluniumShardPrice = cursor21SoluniumShardPrice;

        data.activeDamageTotal = newActiveDamage;
        data.activeDamagePriceTotal = newActiveDamagePrice;
        data.passiveDamagePriceTotal = newPassiveDamagePrice;
    }
    #endregion


    #region openPassiveAndActiveUpgrades

    public void OpenPassiveDamageUpgrade()
    {
        if (AudioManager.audioMuted == 1) { audioManager.Play("UIClick1"); }
        if (passiveClickBar.activeInHierarchy == true) { passiveClickBar.SetActive(false);  }
        else if (passiveClickBar.activeInHierarchy == false) { passiveClickBar.SetActive(true);  }

        if(PlaceMobileButtons.isMobile == true)
        {
            passiveClickBar.transform.localScale = new Vector2(1.45f, 1.45f);
            passiveClickBar.transform.localPosition = new Vector2(0, -70f);
        }
        if (PlaceMobileButtons.isFoldPhone == true)
        {
            passiveClickBar.transform.localScale = new Vector2(1.28f, 1.28f);
            passiveClickBar.transform.localPosition = new Vector2(0, -74.4f);
        }

        activeClickBar.SetActive(false);
    }

    public void ExitPassiveDamage()
    {
        if (AudioManager.audioMuted == 1) { audioManager.Play("UIClick1"); }
        passiveClickBar.SetActive(false);
    }

    public void ExitActiveDamage()
    {
        if (AudioManager.audioMuted == 1) { audioManager.Play("UIClick1"); }
        activeClickBar.SetActive(false);
    }

    public void OpenActiveDamageUpgrade()
    {
        if (AudioManager.audioMuted == 1) { audioManager.Play("UIClick1"); }
        if (activeClickBar.activeInHierarchy == true) { activeClickBar.SetActive(false); }
        else if (activeClickBar.activeInHierarchy == false) { activeClickBar.SetActive(true); }

        passiveClickBar.SetActive(false);

        if (PlaceMobileButtons.isMobile == true)
        {
            activeClickBar.transform.localScale = new Vector2(1.45f, 1.45f);
            activeClickBar.transform.localPosition = new Vector2(0, -70f);
            if(PlaceMobileButtons.isFoldPhone == true)
            {
                activeClickBar.transform.localScale = new Vector2(1.28f, 1.28f);
                activeClickBar.transform.localPosition = new Vector2(0, -74.4f);
            }
        }
    }
    #endregion

   
    public static bool[] cursorHoverChange = new bool [21]; 


    public void Update()
    {
        if(SpawnRewards.gemOnScreenCount < 0) { SpawnRewards.gemOnScreenCount = 0; }

        //Comparing cursors stats/buffs
        if (SaveAndLoad.firstClick == 1)
        {
            #region comparing cursor buffs

            #region cursor1
            if (cursor1ActiveBuff == activeDamageMultiplier) { cursor1ActivePercentText.color = Color.white; }
            if (cursor1ActiveBuff > activeDamageMultiplier) { cursor1ActivePercentText.color = Color.green; }
            if (cursor1ActiveBuff < activeDamageMultiplier) { cursor1ActivePercentText.color = Color.red; }

            if (cursor1Passive == passiveDamageMultiplier) { cursor1PassivePercentText.color = Color.white; }
            if (cursor1Passive > passiveDamageMultiplier) { cursor1PassivePercentText.color = Color.green; }
            if (cursor1Passive < passiveDamageMultiplier) { cursor1PassivePercentText.color = Color.red; }

            if (cursor1CritChance == critChance) { cursor1CritChanceText.color = Color.white; }
            if (cursor1CritChance > critChance) { cursor1CritChanceText.color = Color.green; }
            if (cursor1CritChance < critChance) { cursor1CritChanceText.color = Color.red; }

            if (cursor1CritDamage == critDamage) { cursor1CritDamageText.color = Color.white; }
            if (cursor1CritDamage > critDamage) { cursor1CritDamageText.color = Color.green; }
            if (cursor1CritDamage < critDamage) { cursor1CritDamageText.color = Color.red; }

            #endregion

            #region cursor2
            if (cursor2PassiveBuff == passiveDamageMultiplier) { cursor2PassivePercentText.color = Color.white; }
            if (cursor2PassiveBuff > passiveDamageMultiplier) { cursor2PassivePercentText.color = Color.green; }
            if (cursor2PassiveBuff < passiveDamageMultiplier) { cursor2PassivePercentText.color = Color.red; }

            if (cursor2Active == activeDamageMultiplier) { cursor2ActiveText.color = Color.white; }
            if (cursor2Active > activeDamageMultiplier) { cursor2ActiveText.color = Color.green; }
            if (cursor2Active < activeDamageMultiplier) { cursor2ActiveText.color = Color.red; }

            if (cursor2CritCance == critChance) { cursor2CritChanceText.color = Color.white; }
            if (cursor2CritCance > critChance) { cursor2CritChanceText.color = Color.green; }
            if (cursor2CritCance < critChance) { cursor2CritChanceText.color = Color.red; }

            if (cursor2CritDamage == critDamage) { cursor2CritDamageText.color = Color.white; }
            if (cursor2CritDamage > critDamage) { cursor2CritDamageText.color = Color.green; }
            if (cursor2CritDamage < critDamage) { cursor2CritDamageText.color = Color.red; }
            #endregion

            #region cursor3
            if (cursor3Passive == passiveDamageMultiplier) { cursor3PassiveText.color = Color.white; }
            if (cursor3Passive > passiveDamageMultiplier) { cursor3PassiveText.color = Color.green; }
            if (cursor3Passive < passiveDamageMultiplier) { cursor3PassiveText.color = Color.red; }

            if (cursor3Actice == activeDamageMultiplier) { cursor3ActiveText.color = Color.white; }
            if (cursor3Actice > activeDamageMultiplier) { cursor3ActiveText.color = Color.green; }
            if (cursor3Actice < activeDamageMultiplier) { cursor3ActiveText.color = Color.red; }

            if (cursor3CritChance == critChance) { cursors3CritChancePercentText.color = Color.white; }
            if (cursor3CritChance > critChance) { cursors3CritChancePercentText.color = Color.green; }
            if (cursor3CritChance < critChance) { cursors3CritChancePercentText.color = Color.red; }

            if (cursor3CritDamage == critDamage) { cursor3CritDamagePercentTect.color = Color.white; }
            if (cursor3CritDamage > critDamage) { cursor3CritDamagePercentTect.color = Color.green; }
            if (cursor3CritDamage < critDamage) { cursor3CritDamagePercentTect.color = Color.red; }
            #endregion

            #region cursor4
            if (cursor4PassiveDamage == passiveDamageMultiplier) { cursor4PassiveDamagePercentText.color = Color.white; }
            if (cursor4PassiveDamage > passiveDamageMultiplier) { cursor4PassiveDamagePercentText.color = Color.green; }
            if (cursor4PassiveDamage < passiveDamageMultiplier) { cursor4PassiveDamagePercentText.color = Color.red; }

            if (cursor4ActiveDamage == activeDamageMultiplier) { cursor4ActiveDamagePercentText.color = Color.white; }
            if (cursor4ActiveDamage > activeDamageMultiplier) { cursor4ActiveDamagePercentText.color = Color.green; }
            if (cursor4ActiveDamage < activeDamageMultiplier) { cursor4ActiveDamagePercentText.color = Color.red; }

            if (cursor4CritChance == critChance) { cursor4CritChanceText.color = Color.white; }
            if (cursor4CritChance > critChance) { cursor4CritChanceText.color = Color.green; }
            if (cursor4CritChance < critChance) { cursor4CritChanceText.color = Color.red; }

            if (cursor4CritDamage == critDamage) { cursor4CritDamageText.color = Color.white; }
            if (cursor4CritDamage > critDamage) { cursor4CritDamageText.color = Color.green; }
            if (cursor4CritDamage < critDamage) { cursor4CritDamageText.color = Color.red; }
            #endregion

            #region cursor5
            if (cursor5Passive == passiveDamageMultiplier) { cursor5PassiveText.color = Color.white; }
            if (cursor5Passive > passiveDamageMultiplier) { cursor5PassiveText.color = Color.green; }
            if (cursor5Passive < passiveDamageMultiplier) { cursor5PassiveText.color = Color.red; }

            if (cursor5ActiveDamage == activeDamageMultiplier) { cursor5ActiveDamagePercentText.color = Color.white; }
            if (cursor5ActiveDamage > activeDamageMultiplier) { cursor5ActiveDamagePercentText.color = Color.green; }
            if (cursor5ActiveDamage < activeDamageMultiplier) { cursor5ActiveDamagePercentText.color = Color.red; }

            if (cursor5CritChance == critChance) { cursor5CritChancePercentText.color = Color.white; }
            if (cursor5CritChance > critChance) { cursor5CritChancePercentText.color = Color.green; }
            if (cursor5CritChance < critChance) { cursor5CritChancePercentText.color = Color.red; }

            if (cursor5CritDamage == critDamage) { cursor5CritDamagePercentText.color = Color.white; }
            if (cursor5CritDamage > critDamage) { cursor5CritDamagePercentText.color = Color.green; }
            if (cursor5CritDamage < critDamage) { cursor5CritDamagePercentText.color = Color.red; }
            #endregion

            #region cursor6
            if (cursor6PassiveDamage == passiveDamageMultiplier) { cursor6PassiveDamagePercentText.color = Color.white; }
            if (cursor6PassiveDamage > passiveDamageMultiplier) { cursor6PassiveDamagePercentText.color = Color.green; }
            if (cursor6PassiveDamage < passiveDamageMultiplier) { cursor6PassiveDamagePercentText.color = Color.red; }

            if (cursor6ActiveDamage == activeDamageMultiplier) { cursor6ActiveDamagePercentText.color = Color.white; }
            if (cursor6ActiveDamage > activeDamageMultiplier) { cursor6ActiveDamagePercentText.color = Color.green; }
            if (cursor6ActiveDamage < activeDamageMultiplier) { cursor6ActiveDamagePercentText.color = Color.red; }

            if (cursor6CritChance == critChance) { cursor6CritChancePercentText.color = Color.white; }
            if (cursor6CritChance > critChance) { cursor6CritChancePercentText.color = Color.green; }
            if (cursor6CritChance < critChance) { cursor6CritChancePercentText.color = Color.red; }

            if (cursor6CritDamage == critDamage) { cursor6CritDamagePercentText.color = Color.white; }
            if (cursor6CritDamage > critDamage) { cursor6CritDamagePercentText.color = Color.green; }
            if (cursor6CritDamage < critDamage) { cursor6CritDamagePercentText.color = Color.red; }
            #endregion

            #region cursor7
            if (cursor7Passive == passiveDamageMultiplier) { cursor7PassiveText.color = Color.white; }
            if (cursor7Passive > passiveDamageMultiplier) { cursor7PassiveText.color = Color.green; }
            if (cursor7Passive < passiveDamageMultiplier) { cursor7PassiveText.color = Color.red; }

            if (cursor7ActiveDamage == activeDamageMultiplier) { cursor7ActiveDamagePercentText.color = Color.white; }
            if (cursor7ActiveDamage > activeDamageMultiplier) { cursor7ActiveDamagePercentText.color = Color.green; }
            if (cursor7ActiveDamage < activeDamageMultiplier) { cursor7ActiveDamagePercentText.color = Color.red; }

            if (cursor7CritChance == critChance) { cursor7CritChancePercentText.color = Color.white; }
            if (cursor7CritChance > critChance) { cursor7CritChancePercentText.color = Color.green; }
            if (cursor7CritChance < critChance) { cursor7CritChancePercentText.color = Color.red; }

            if (cursor7CritDamage == critDamage) { cursor7CritDamagePercentText.color = Color.white; }
            if (cursor7CritDamage > critDamage) { cursor7CritDamagePercentText.color = Color.green; }
            if (cursor7CritDamage < critDamage) { cursor7CritDamagePercentText.color = Color.red; }
            #endregion

            #region cursor8
            if (cursor8PassiveDamage == passiveDamageMultiplier) { cursor8PassiveDamagePercentText.color = Color.white; }
            if (cursor8PassiveDamage > passiveDamageMultiplier) { cursor8PassiveDamagePercentText.color = Color.green; }
            if (cursor8PassiveDamage < passiveDamageMultiplier) { cursor8PassiveDamagePercentText.color = Color.red; }

            if (cursor8ActiveDamage == activeDamageMultiplier) { cursor8ActiveDamagePercentText.color = Color.white; }
            if (cursor8ActiveDamage > activeDamageMultiplier) { cursor8ActiveDamagePercentText.color = Color.green; }
            if (cursor8ActiveDamage < activeDamageMultiplier) { cursor8ActiveDamagePercentText.color = Color.red; }

            if (cursor8CritChance == critChance) { cursor8CritChancePercentText.color = Color.white; }
            if (cursor8CritChance > critChance) { cursor8CritChancePercentText.color = Color.green; }
            if (cursor8CritChance < critChance) { cursor8CritChancePercentText.color = Color.red; }

            if (cursor8CritDamage == critDamage) { cursor8CritDamagePercentText.color = Color.white; }
            if (cursor8CritDamage > critDamage) { cursor8CritDamagePercentText.color = Color.green; }
            if (cursor8CritDamage < critDamage) { cursor8CritDamagePercentText.color = Color.red; }
            #endregion

            #region cursor9
            if (cursor9PassiveDamage == passiveDamageMultiplier) { cursor9PassiveDamagePercentText.color = Color.white; }
            if (cursor9PassiveDamage > passiveDamageMultiplier) { cursor9PassiveDamagePercentText.color = Color.green; }
            if (cursor9PassiveDamage < passiveDamageMultiplier) { cursor9PassiveDamagePercentText.color = Color.red; }

            if (cursor9ActiveDamage == activeDamageMultiplier) { cursor9ActiveDamagePercentText.color = Color.white; }
            if (cursor9ActiveDamage > activeDamageMultiplier) { cursor9ActiveDamagePercentText.color = Color.green; }
            if (cursor9ActiveDamage < activeDamageMultiplier) { cursor9ActiveDamagePercentText.color = Color.red; }

            if (cursor9CritChance == critChance) { cursor9CritChancePercentText.color = Color.white; }
            if (cursor9CritChance > critChance) { cursor9CritChancePercentText.color = Color.green; }
            if (cursor9CritChance < critChance) { cursor9CritChancePercentText.color = Color.red; }

            if (cursor9CritDamage == critDamage) { cursor9CritDamagePercentText.color = Color.white; }
            if (cursor9CritDamage > critDamage) { cursor9CritDamagePercentText.color = Color.green; }
            if (cursor9CritDamage < critDamage) { cursor9CritDamagePercentText.color = Color.red; }
            #endregion

            #region cursor10
            if (cursor10PassiveDamage == passiveDamageMultiplier) { cursor10PassiveDamagePercentText.color = Color.white; }
            if (cursor10PassiveDamage > passiveDamageMultiplier) { cursor10PassiveDamagePercentText.color = Color.green; }
            if (cursor10PassiveDamage < passiveDamageMultiplier) { cursor10PassiveDamagePercentText.color = Color.red; }

            if (cursor10Active == activeDamageMultiplier) { cursor10ActiveText.color = Color.white; }
            if (cursor10Active > activeDamageMultiplier) { cursor10ActiveText.color = Color.green; }
            if (cursor10Active < activeDamageMultiplier) { cursor10ActiveText.color = Color.red; }

            if (cursor10CritChance == critChance) { cursor10CritChanceText.color = Color.white; }
            if (cursor10CritChance > critChance) { cursor10CritChanceText.color = Color.green; }
            if (cursor10CritChance < critChance) { cursor10CritChanceText.color = Color.red; }

            if (cursor10CritDamage == critDamage) { cursor10CritDamageText.color = Color.white; }
            if (cursor10CritDamage > critDamage) { cursor10CritDamageText.color = Color.green; }
            if (cursor10CritDamage < critDamage) { cursor10CritDamageText.color = Color.red; }
            #endregion

            #region cursor11
            if (cursor11Passive == passiveDamageMultiplier) { cursor11PassiveText.color = Color.white; }
            if (cursor11Passive > passiveDamageMultiplier) { cursor11PassiveText.color = Color.green; }
            if (cursor11Passive < passiveDamageMultiplier) { cursor11PassiveText.color = Color.red; }

            if (cursor11ActiveDamage == activeDamageMultiplier) { cursor11ActiveDamagePercentText.color = Color.white; }
            if (cursor11ActiveDamage > activeDamageMultiplier) { cursor11ActiveDamagePercentText.color = Color.green; }
            if (cursor11ActiveDamage < activeDamageMultiplier) { cursor11ActiveDamagePercentText.color = Color.red; }

            if (cursor11CritChance == critChance) { cursor11CritChancePercentText.color = Color.white; }
            if (cursor11CritChance > critChance) { cursor11CritChancePercentText.color = Color.green; }
            if (cursor11CritChance < critChance) { cursor11CritChancePercentText.color = Color.red; }

            if (cursor11CritDamage == critDamage) { cursor11CritDamagePercentText.color = Color.white; }
            if (cursor11CritDamage > critDamage) { cursor11CritDamagePercentText.color = Color.green; }
            if (cursor11CritDamage < critDamage) { cursor11CritDamagePercentText.color = Color.red; }
            #endregion

            #region cursor12
            if (cursor12PassiveDamage == passiveDamageMultiplier) { cursor12PassiveDamagePercentText.color = Color.white; }
            if (cursor12PassiveDamage > passiveDamageMultiplier) { cursor12PassiveDamagePercentText.color = Color.green; }
            if (cursor12PassiveDamage < passiveDamageMultiplier) { cursor12PassiveDamagePercentText.color = Color.red; }

            if (cursor12ActiveDamage == activeDamageMultiplier) { cursor12ActiveDamagePercentText.color = Color.white; }
            if (cursor12ActiveDamage > activeDamageMultiplier) { cursor12ActiveDamagePercentText.color = Color.green; }
            if (cursor12ActiveDamage < activeDamageMultiplier) { cursor12ActiveDamagePercentText.color = Color.red; }

            if (cursor12CritChance == critChance) { cursor12CritChancePercentText.color = Color.white; }
            if (cursor12CritChance > critChance) { cursor12CritChancePercentText.color = Color.green; }
            if (cursor12CritChance < critChance) { cursor12CritChancePercentText.color = Color.red; }

            if (cursor12CritDamage == critDamage) { cursor12CritDamagePercentText.color = Color.white; }
            if (cursor12CritDamage > critDamage) { cursor12CritDamagePercentText.color = Color.green; }
            if (cursor12CritDamage < critDamage) { cursor12CritDamagePercentText.color = Color.red; }
            #endregion

            #region cursor13
            if (cursor13PassiveDamage == passiveDamageMultiplier) { cursor13PassiveDamagePercentText.color = Color.white; }
            if (cursor13PassiveDamage > passiveDamageMultiplier) { cursor13PassiveDamagePercentText.color = Color.green; }
            if (cursor13PassiveDamage < passiveDamageMultiplier) { cursor13PassiveDamagePercentText.color = Color.red; }

            if (cursor13ActiveDamage == activeDamageMultiplier) { cursor13ActiveDamagePercentText.color = Color.white; }
            if (cursor13ActiveDamage > activeDamageMultiplier) { cursor13ActiveDamagePercentText.color = Color.green; }
            if (cursor13ActiveDamage < activeDamageMultiplier) { cursor13ActiveDamagePercentText.color = Color.red; }

            if (cursor13CritChance == critChance) { cursor13CritChancePercentText.color = Color.white; }
            if (cursor13CritChance > critChance) { cursor13CritChancePercentText.color = Color.green; }
            if (cursor13CritChance < critChance) { cursor13CritChancePercentText.color = Color.red; }

            if (cursor13CritDamage == critDamage) { cursor13CritDamagePercentText.color = Color.white; }
            if (cursor13CritDamage > critDamage) { cursor13CritDamagePercentText.color = Color.green; }
            if (cursor13CritDamage < critDamage) { cursor13CritDamagePercentText.color = Color.red; }
            #endregion

            #region cursor14
            if (cursor14PassiveDamage == passiveDamageMultiplier) { cursor14PassiveDamagePercentText.color = Color.white; }
            if (cursor14PassiveDamage > passiveDamageMultiplier) { cursor14PassiveDamagePercentText.color = Color.green; }
            if (cursor14PassiveDamage < passiveDamageMultiplier) { cursor14PassiveDamagePercentText.color = Color.red; }

            if (cursor14ActiveDamage == activeDamageMultiplier) { cursor14ActiveDamagePercentText.color = Color.white; }
            if (cursor14ActiveDamage > activeDamageMultiplier) { cursor14ActiveDamagePercentText.color = Color.green; }
            if (cursor14ActiveDamage < activeDamageMultiplier) { cursor14ActiveDamagePercentText.color = Color.red; }

            if (cursor14CritChance == critChance) { cursor14CritChancePercentText.color = Color.white; }
            if (cursor14CritChance > critChance) { cursor14CritChancePercentText.color = Color.green; }
            if (cursor14CritChance < critChance) { cursor14CritChancePercentText.color = Color.red; }

            if (cursor14CritDamage == critDamage) { cursor14CritDamagePercentText.color = Color.white; }
            if (cursor14CritDamage > critDamage) { cursor14CritDamagePercentText.color = Color.green; }
            if (cursor14CritDamage < critDamage) { cursor14CritDamagePercentText.color = Color.red; }
            #endregion

            #region cursor15
            if (cursor15PassiveDamage == passiveDamageMultiplier) { cursor15PassiveDamagePercentText.color = Color.white; }
            if (cursor15PassiveDamage > passiveDamageMultiplier) { cursor15PassiveDamagePercentText.color = Color.green; }
            if (cursor15PassiveDamage < passiveDamageMultiplier) { cursor15PassiveDamagePercentText.color = Color.red; }

            if (cursor15ActiveDamage == activeDamageMultiplier) { cursor15ActiveDamagePercentText.color = Color.white; }
            if (cursor15ActiveDamage > activeDamageMultiplier) { cursor15ActiveDamagePercentText.color = Color.green; }
            if (cursor15ActiveDamage < activeDamageMultiplier) { cursor15ActiveDamagePercentText.color = Color.red; }

            if (cursor15CritChance == critChance) { cursor15CritChancePercentText.color = Color.white; }
            if (cursor15CritChance > critChance) { cursor15CritChancePercentText.color = Color.green; }
            if (cursor15CritChance < critChance) { cursor15CritChancePercentText.color = Color.red; }

            if (cursor15CritDamage == critDamage) { cursor15CritDamagePercentText.color = Color.white; }
            if (cursor15CritDamage > critDamage) { cursor15CritDamagePercentText.color = Color.green; }
            if (cursor15CritDamage < critDamage) { cursor15CritDamagePercentText.color = Color.red; }
            #endregion

            #region cursor16
            if (cursor16PassiveDamage == passiveDamageMultiplier) { cursor16PassiveDamagePercentText.color = Color.white; }
            if (cursor16PassiveDamage > passiveDamageMultiplier) { cursor16PassiveDamagePercentText.color = Color.green; }
            if (cursor16PassiveDamage < passiveDamageMultiplier) { cursor16PassiveDamagePercentText.color = Color.red; }

            if (cursor16ActiveDamage == activeDamageMultiplier) { cursor16ActiveDamagePercentText.color = Color.white; }
            if (cursor16ActiveDamage > activeDamageMultiplier) { cursor16ActiveDamagePercentText.color = Color.green; }
            if (cursor16ActiveDamage < activeDamageMultiplier) { cursor16ActiveDamagePercentText.color = Color.red; }

            if (cursor16CritChance == critChance) { cursor16CritChancePercentText.color = Color.white; }
            if (cursor16CritChance > critChance) { cursor16CritChancePercentText.color = Color.green; }
            if (cursor16CritChance < critChance) { cursor16CritChancePercentText.color = Color.red; }

            if (cursor16CritDamage == critDamage) { cursor16CritDamagePercentText.color = Color.white; }
            if (cursor16CritDamage > critDamage) { cursor16CritDamagePercentText.color = Color.green; }
            if (cursor16CritDamage < critDamage) { cursor16CritDamagePercentText.color = Color.red; }
            #endregion

            #region cursor17
            if (cursor17PassiveDamage == passiveDamageMultiplier) { cursor17PassiveDamagePercentText.color = Color.white; }
            if (cursor17PassiveDamage > passiveDamageMultiplier) { cursor17PassiveDamagePercentText.color = Color.green; }
            if (cursor17PassiveDamage < passiveDamageMultiplier) { cursor17PassiveDamagePercentText.color = Color.red; }

            if (cursor17ActiveDamage == activeDamageMultiplier) { cursor17ActiveDamagePercentText.color = Color.white; }
            if (cursor17ActiveDamage > activeDamageMultiplier) { cursor17ActiveDamagePercentText.color = Color.green; }
            if (cursor17ActiveDamage < activeDamageMultiplier) { cursor17ActiveDamagePercentText.color = Color.red; }

            if (cursor17CritChance == critChance) { cursor17CritChancePercentText.color = Color.white; }
            if (cursor17CritChance > critChance) { cursor17CritChancePercentText.color = Color.green; }
            if (cursor17CritChance < critChance) { cursor17CritChancePercentText.color = Color.red; }

            if (cursor17CritDamage == critDamage) { cursor17CritDamagePercentText.color = Color.white; }
            if (cursor17CritDamage > critDamage) { cursor17CritDamagePercentText.color = Color.green; }
            if (cursor17CritDamage < critDamage) { cursor17CritDamagePercentText.color = Color.red; }
            #endregion

            #region cursor18
            if (cursor18PassiveDamage == passiveDamageMultiplier) { cursor18PassiveDamagePercentText.color = Color.white; }
            if (cursor18PassiveDamage > passiveDamageMultiplier) { cursor18PassiveDamagePercentText.color = Color.green; }
            if (cursor18PassiveDamage < passiveDamageMultiplier) { cursor18PassiveDamagePercentText.color = Color.red; }

            if (cursor18ActiveDamage == activeDamageMultiplier) { cursor18ActiveDamagePercentText.color = Color.white; }
            if (cursor18ActiveDamage > activeDamageMultiplier) { cursor18ActiveDamagePercentText.color = Color.green; }
            if (cursor18ActiveDamage < activeDamageMultiplier) { cursor18ActiveDamagePercentText.color = Color.red; }

            if (cursor18CritChance == critChance) { cursor18CritChancePercentText.color = Color.white; }
            if (cursor18CritChance > critChance) { cursor18CritChancePercentText.color = Color.green; }
            if (cursor18CritChance < critChance) { cursor18CritChancePercentText.color = Color.red; }

            if (cursor18CritDamage == critDamage) { cursor18CritDamagePercentText.color = Color.white; }
            if (cursor18CritDamage > critDamage) { cursor18CritDamagePercentText.color = Color.green; }
            if (cursor18CritDamage < critDamage) { cursor18CritDamagePercentText.color = Color.red; }
            #endregion

            #region cursor19
            if (cursor19PassiveDamage == passiveDamageMultiplier) { cursor19PassiveDamagePercentText.color = Color.white; }
            if (cursor19PassiveDamage > passiveDamageMultiplier) { cursor19PassiveDamagePercentText.color = Color.green; }
            if (cursor19PassiveDamage < passiveDamageMultiplier) { cursor19PassiveDamagePercentText.color = Color.red; }

            if (cursor19ActiveDamage == activeDamageMultiplier) { cursor19ActiveDamagePercentText.color = Color.white; }
            if (cursor19ActiveDamage > activeDamageMultiplier) { cursor19ActiveDamagePercentText.color = Color.green; }
            if (cursor19ActiveDamage < activeDamageMultiplier) { cursor19ActiveDamagePercentText.color = Color.red; }

            if (cursor19CritChance == critChance) { cursor19CritChancePercentText.color = Color.white; }
            if (cursor19CritChance > critChance) { cursor19CritChancePercentText.color = Color.green; }
            if (cursor19CritChance < critChance) { cursor19CritChancePercentText.color = Color.red; }

            if (cursor19CritDamage == critDamage) { cursor19CritDamagePercentText.color = Color.white; }
            if (cursor19CritDamage > critDamage) { cursor19CritDamagePercentText.color = Color.green; }
            if (cursor19CritDamage < critDamage) { cursor19CritDamagePercentText.color = Color.red; }
            #endregion

            #region cursor20
            if (cursor20PassiveDamage == passiveDamageMultiplier) { cursor20PassiveDamagePercentText.color = Color.white; }
            if (cursor20PassiveDamage > passiveDamageMultiplier) { cursor20PassiveDamagePercentText.color = Color.green; }
            if (cursor20PassiveDamage < passiveDamageMultiplier) { cursor20PassiveDamagePercentText.color = Color.red; }

            if (cursor20ActiveDamage == activeDamageMultiplier) { cursor20ActiveDamagePercentText.color = Color.white; }
            if (cursor20ActiveDamage > activeDamageMultiplier) { cursor20ActiveDamagePercentText.color = Color.green; }
            if (cursor20ActiveDamage < activeDamageMultiplier) { cursor20ActiveDamagePercentText.color = Color.red; }

            if (cursor20CritChance == critChance) { cursor20CritChancePercentText.color = Color.white; }
            if (cursor20CritChance > critChance) { cursor20CritChancePercentText.color = Color.green; }
            if (cursor20CritChance < critChance) { cursor20CritChancePercentText.color = Color.red; }

            if (cursor20CritDamage == critDamage) { cursor20CritDamagePercentText.color = Color.white; }
            if (cursor20CritDamage > critDamage) { cursor20CritDamagePercentText.color = Color.green; }
            if (cursor20CritDamage < critDamage) { cursor20CritDamagePercentText.color = Color.red; }
            #endregion

            #region cursor21
            if (cursor21PassiveDamage == passiveDamageMultiplier) { cursor21PassiveDamagePercentText.color = Color.white; }
            if (cursor21PassiveDamage > passiveDamageMultiplier) { cursor21PassiveDamagePercentText.color = Color.green; }
            if (cursor21PassiveDamage < passiveDamageMultiplier) { cursor21PassiveDamagePercentText.color = Color.red; }

            if (cursor21ActiveDamage == activeDamageMultiplier) { cursor21ActiveDamagePercentText.color = Color.white; }
            if (cursor21ActiveDamage > activeDamageMultiplier) { cursor21ActiveDamagePercentText.color = Color.green; }
            if (cursor21ActiveDamage < activeDamageMultiplier) { cursor21ActiveDamagePercentText.color = Color.red; }

            if (cursor21CritChance == critChance) { cursor21CritChancePercentText.color = Color.white; }
            if (cursor21CritChance > critChance) { cursor21CritChancePercentText.color = Color.green; }
            if (cursor21CritChance < critChance) { cursor21CritChancePercentText.color = Color.red; }

            if (cursor21CritDamage == critDamage) { cursor21CritDamagePercentText.color = Color.white; }
            if (cursor21CritDamage > critDamage) { cursor21CritDamagePercentText.color = Color.green; }
            if (cursor21CritDamage < critDamage) { cursor21CritDamagePercentText.color = Color.red; }
            #endregion

            #endregion
        }


        if (UpdateGame.totalGoldHigher >= newPassiveDamagePrice)
        {
            passiveDamagePriceText.color = Color.green;
        }
        if (UpdateGame.totalGoldHigher < newPassiveDamagePrice) { passiveDamagePriceText.color = Color.red; }

        //NEW
        if (UpdateGame.totalGoldHigher >= newActiveDamagePrice)
        {
            activeDamagePriceText.color = Color.green;
        }
        if (UpdateGame.totalGoldHigher < newActiveDamagePrice) { activeDamagePriceText.color = Color.red; }

       

        if (cursor1Change == true)
        {
            //Cursor1
            cursorLevelText.text = Localization.lvl + Cursor1Level;
            cursor1LevelHoverText.text = Localization.lvl + Cursor1Level;
            cursor1ActivePercentText.text = HoverSetStrings.cursor1ActiveText;
            cursor1QuartzPriceText.text = cursor1QuartzUpgradePrice + "";
            cursorHoverChange[0] = true;
            cursor1Change = false;
        }

        else if (cursor2Change == true)
        {
            //Cursor2
            cursor2LevelText.text = Localization.lvl + cursor2Level;
            cursor2LevelHoverText.text = Localization.lvl + cursor2Level;
            cursor2PassivePercentText.text = HoverSetStrings.cursor2PassiveText;
            cursor2QuartzPriceText.text = cursor2QuartzUpgradePrice + "";
            cursorHoverChange[1] = true;
            cursor2Change = false;
        }

        else if (cursor3Change == true)
        {
            //Cursor3
            cursor3LevelText.text = Localization.lvl + cursor3Level;
            cursor3LevelHoverText.text = Localization.lvl + cursor3Level;
            cursor3QuartzPriceText.text = cursor3QuartzPrice + "";
            cursor3AmethystPriceText.text = cursor3AmethystPrice + "";
            cursor3CritDamagePercentTect.text = HoverSetStrings.cursor3CritDamage;
            cursors3CritChancePercentText.text = HoverSetStrings.cursor3CritChance;
            cursorHoverChange[2] = true;
            cursor3Change = false;
        }

        else if (cursor4Change == true)
        {
            //Cursor4
            cursor4LevelText.text = Localization.lvl + cursor4Level;
            cursor4LevelHoverText.text = Localization.lvl + cursor4Level;
            cursor4TopazPriceText.text = cursor4TopazPrice + "";
            cursor4ActiveDamagePercentText.text = HoverSetStrings.cursor4ActiveText;
            cursor4PassiveDamagePercentText.text = HoverSetStrings.cursor4PassiveText;
            cursorHoverChange[3] = true;
            cursor4Change = false;
        }

        else if (cursor5Change == true)
        {
            //Cursor5
            cursor5LevelText.text = Localization.lvl + cursor5Level;
            cursor5LevelHoverText.text = Localization.lvl + cursor5Level;
            cursor5AlbitePriceText.text = cursor5AlbitePrice + "";
            cursor5ActiveDamagePercentText.text = HoverSetStrings.cursor5ActiveText;
            cursor5CritChancePercentText.text = HoverSetStrings.cursor5CritChanceText;
            cursor5CritDamagePercentText.text = HoverSetStrings.cursor5CritDamageText;
            cursorHoverChange[4] = true;
            cursor5Change = false;
        }

        else if (cursor6Change == true)
        {
            //Cursor6
            cursor6LevelText.text = Localization.lvl + cursor6Level;
            cursor6LevelHoverText.text = Localization.lvl + cursor6Level;
            cursor6AlbitePriceText.text = cursor6AlbitePrice + "";
            cursor6ReGarnetPriceText.text = cursor6RedGarnetPrice + "";
            cursor6ActiveDamagePercentText.text = HoverSetStrings.cursor6ActiveText;
            cursor6PassiveDamagePercentText.text = HoverSetStrings.cursor6PassiveText;
            cursor6CritChancePercentText.text = HoverSetStrings.cursor6CritChanceText;
            cursor6CritDamagePercentText.text = HoverSetStrings.cursor6CritDamageText;
            cursorHoverChange[5] = true;
            cursor6Change = false;
        }

        else if (cursor7Change == true)
        {
            //Cursor7
            cursor7LevelText.text = Localization.lvl + cursor7Level;
            cursor7LevelHoverText.text = Localization.lvl + cursor7Level;
            cursor7AquamarineText.text = cursor7AquamarinePrice + "";
            cursor7ActiveDamagePercentText.text = HoverSetStrings.cursor7ActiveText;
            cursor7CritChancePercentText.text = HoverSetStrings.cursor7CritChanceText;
            cursor7CritDamagePercentText.text = HoverSetStrings.cursor7CritDamageText;
            cursorHoverChange[6] = true;
            cursor7Change = false;
        }

        else if (cursor8Change == true)
        {
            //Cursor8
            cursor8LevelText.text = Localization.lvl + cursor8Level;
            cursor8LevelHoverText.text = Localization.lvl + cursor8Level;
            cursor8AquamarinePriceText.text = cursor8AquamarinePrice + "";
            cursor8YellowSapphirePriceText.text = cursor8YellowSapphirePrice + "";
            cursor8ActiveDamagePercentText.text = HoverSetStrings.cursor8ActiveText;
            cursor8PassiveDamagePercentText.text = HoverSetStrings.cursor8PassiveText;
            cursor8CritChancePercentText.text = HoverSetStrings.cursor8CritChanceText;
            cursor8CritDamagePercentText.text = HoverSetStrings.cursor8CritDamageText;
            cursorHoverChange[7] = true;
            cursor8Change = false;
        }

        else if (cursor9Change == true)
        {
            //Cursor9
            cursor9LevelText.text = Localization.lvl + cursor9Level;
            cursor9LevelHoverText.text = Localization.lvl + cursor9Level;
            cursor9PinkTourmalinePriceText.text = cursor9PinkTourmalinePrice + "";
            cursor9ActiveDamagePercentText.text = HoverSetStrings.cursor9ActiveText;
            cursor9PassiveDamagePercentText.text = HoverSetStrings.cursor9PassiveText;
            cursorHoverChange[8] = true;
            cursor9Change = false;
        }

        else if (cursor10Change == true)
        {
            //Cursor10
            cursor10LevelText.text = Localization.lvl + cursor10Level;
            cursor10LevelHoverText.text = Localization.lvl + cursor10Level;
            cursor10AdventurinePriceText.text = cursor10AdventurinePrice + "";
            cursor10PassiveDamagePercentText.text = HoverSetStrings.cursor10PassiveText;
            cursorHoverChange[9] = true;
            cursor10Change = false;
        }

        else if (cursor11Change == true)
        {
            //Cursor11
            cursor11LevelText.text = Localization.lvl + cursor11Level;
            cursor11LevelHoverText.text = Localization.lvl + cursor11Level;
            cursor11AdventurinePriceText.text = cursor11AdventurinePrice + "";
            cursor11PinkTourmalinePriceText.text = cursor11PinkTourmalinePrice + "";
            cursor11ActiveDamagePercentText.text = HoverSetStrings.cursor11ActiveText;
            cursor11CritChancePercentText.text = HoverSetStrings.cursor11CritChanceText;
            cursor11CritDamagePercentText.text = HoverSetStrings.cursor11CritDamageText;
            cursorHoverChange[10] = true;
            cursor11Change = false;
        }

        else if (cursor12Change == true)
        {
            //Cursor12
            cursor12LevelText.text = Localization.lvl + cursor12Level;
            cursor12LevelHoverText.text = Localization.lvl + cursor12Level;
            cursor12AdventurinePriceText.text = cursor12AdventurinePrice + "";
            cursor12RedRubyPriceText.text = cursor12RedRubyPrice + "";
            cursor12ActiveDamagePercentText.text = HoverSetStrings.cursor12ActiveText;
            cursor12PassiveDamagePercentText.text = HoverSetStrings.cursor12PassiveText;
            cursor12CritChancePercentText.text = HoverSetStrings.cursor12CritChanceText;
            cursor12CritDamagePercentText.text = HoverSetStrings.cursor12CritDamageText;
            cursorHoverChange[11] = true;
            cursor12Change = false;
        }

        else if (cursor13Change == true)
        {
            //Cursor13
            cursor13LevelText.text = Localization.lvl + cursor13Level;
            cursor13LevelHoverText.text = Localization.lvl + cursor13Level;
            cursor13DiamondPriceText.text = cursor13DiamondPrice + "";
            cursor13GrandideritePriceText.text = cursor13GrandideritePrice + "";
            cursor13ActiveDamagePercentText.text = HoverSetStrings.cursor13ActiveText;
            cursor13PassiveDamagePercentText.text = HoverSetStrings.cursor13PassiveText;
            cursor13CritChancePercentText.text = HoverSetStrings.cursor13CritChanceText;
            cursor13CritDamagePercentText.text = HoverSetStrings.cursor13CritDamageText;
            cursorHoverChange[12] = true;
            cursor13Change = false;
        }

        else if (cursor14Change == true)
        {
            //Cursor14
            cursor14LevelText.text = Localization.lvl + cursor14Level;
            cursor14LevelHoverText.text = Localization.lvl + cursor14Level;
            cursor14VioletCrystalPriceText.text = cursor14VioletCrystalPrice + "";
            cursor14GrandideritePriceText.text = cursor14GrandideritePrice + "";
            cursor14ActiveDamagePercentText.text = HoverSetStrings.cursor14ActiveText;
            cursor14PassiveDamagePercentText.text = HoverSetStrings.cursor14PassiveText;
            cursor14CritChancePercentText.text = HoverSetStrings.cursor14CritChanceText;
            cursor14CritDamagePercentText.text = HoverSetStrings.cursor14CritDamageText;
            cursorHoverChange[13] = true;
            cursor14Change = false;
        }

        else if (cursor15Change == true)
        {
            //Cursor15
            cursor15LevelText.text = Localization.lvl + cursor15Level;
            cursor15LevelHoverText.text = Localization.lvl + cursor15Level;
            cursor15AkoyaPeralPriceText.text = cursor15AkoyaPeralPrice + "";
            cursor15PurpleRupeePriceText.text = cursor15PurpleRupeePrice + "";
            cursor15EmeraldPriceText.text = cursor15EmeraldPrice + "";
            cursor15ActiveDamagePercentText.text = HoverSetStrings.cursor15ActiveText;
            cursor15PassiveDamagePercentText.text = HoverSetStrings.cursor15PassiveText;
            cursor15CritChancePercentText.text = HoverSetStrings.cursor15CritChanceText;
            cursor15CritDamagePercentText.text = HoverSetStrings.cursor15CritDamageText;
            cursorHoverChange[14] = true;
            cursor15Change = false;
        }

        else if (cursor16Change == true)
        {
            //Cursor16
            cursor16LevelText.text = Localization.lvl + cursor16Level;
            cursor16LevelHoverText.text = Localization.lvl + cursor16Level;
            cursor16GreenDiamondPriceText.text = cursor16GreenDiamondPrice + "";
            cursor16FireOpalPriceText.text = cursor16FireOpalPrice + "";
            cursor16GemSilicaPriceText.text = cursor16GemSilicaPrice + "";
            cursor16ActiveDamagePercentText.text = HoverSetStrings.cursor16ActiveText;
            cursor16PassiveDamagePercentText.text = HoverSetStrings.cursor16PassiveText;
            cursor16CritChancePercentText.text = HoverSetStrings.cursor16CritChanceText;
            cursor16CritDamagePercentText.text = HoverSetStrings.cursor16CritDamageText;
            cursorHoverChange[15] = true;
            cursor16Change = false;
        }

        else if (cursor17Change == true)
        {
            //Cursor17
            cursor17LevelText.text = Localization.lvl + cursor17Level;
            cursor17LevelHoverText.text = Localization.lvl + cursor17Level;
            cursor17PinkPlortPriceText.text = cursor17PinkPlortPrice + "";
            cursor17GoldenSeaPEarlPriceText.text = cursor17GoldenSeaPEarlPrice + "";
            cursor17KyanitePriceText.text = cursor17KyanitePrice + "";
            cursor17ActiveDamagePercentText.text = HoverSetStrings.cursor17ActiveText;
            cursor17PassiveDamagePercentText.text = HoverSetStrings.cursor17PassiveText;
            cursor17CritChancePercentText.text = HoverSetStrings.cursor17CritChanceText;
            cursor17CritDamagePercentText.text = HoverSetStrings.cursor17CritDamageText;
            cursorHoverChange[16] = true;
            cursor17Change = false;
        }

        else if (cursor18Change == true)
        {
            //Cursor18
            cursor18LevelText.text = Localization.lvl + cursor18Level;
            cursor18LevelHoverText.text = Localization.lvl + cursor18Level;
            cursor18BlackOpalPriceText.text = cursor18BlackOpalPrice + "";
            cursor18PainitePriceText.text = cursor18PainitePrice + "";
            cursor18TanzanitePriceText.text = cursor18TanzanitePrice + "";
            cursor18ActiveDamagePercentText.text = HoverSetStrings.cursor18ActiveText;
            cursor18PassiveDamagePercentText.text = HoverSetStrings.cursor18PassiveText;
            cursor18CritChancePercentText.text = HoverSetStrings.cursor18CritChanceText;
            cursor18CritDamagePercentText.text = HoverSetStrings.cursor18CritDamageText;
            cursorHoverChange[17] = true;
            cursor18Change = false;
        }

        else if (cursor19Change == true)
        {
            //Cursor19
            cursor19LevelText.text = Localization.lvl + cursor19Level;
            cursor19LevelHoverText.text = Localization.lvl + cursor19Level;
            cursor19AstraliumPriceText.text = cursor19AstraliumPrice + "";
            cursor19ElysiumPrismPriceText.text = cursor19ElysiumPrismPrice + "";
            cursor19AerthfireOpalPriceText.text = cursor19AerthfireOpalPrice + "";
            cursor19ActiveDamagePercentText.text = HoverSetStrings.cursor19ActiveText;
            cursor19PassiveDamagePercentText.text = HoverSetStrings.cursor19PassiveText;
            cursor19CritChancePercentText.text = HoverSetStrings.cursor19CritChanceText;
            cursor19CritDamagePercentText.text = HoverSetStrings.cursor19CritDamageText;
            cursorHoverChange[18] = true;
            cursor19Change = false;
        }

        else if (cursor20Change == true)
        {
            //Cursor20
            cursor20LevelText.text = Localization.lvl + cursor20Level;
            cursor20LevelHoverText.text = Localization.lvl + cursor20Level;
            cursor20EldritchStarStonePriceText.text = cursor20EldritchStarStonePrice + "";
            cursor20ChronolithShardPriceText.text = cursor20ChronolithShardPrice + "";
            cursor20SideriumEssencePriceText.text = cursor20SideriumEssencePrice + "";
            cursor20ActiveDamagePercentText.text = HoverSetStrings.cursor20ActiveText;
            cursor20PassiveDamagePercentText.text = HoverSetStrings.cursor20PassiveText;
            cursor20CritChancePercentText.text = HoverSetStrings.cursor20CritChanceText;
            cursor20CritDamagePercentText.text = HoverSetStrings.cursor20CritDamageText;
            cursorHoverChange[19] = true;
            cursor20Change = false;
        }

        else if (cursor21Change == true)
        {
            //Cursor21
            cursor21LevelText.text = Localization.lvl + cursor21Level;
            cursor21LevelHoverText.text = Localization.lvl + cursor21Level;
            cursor21QuasaritePriceText.text = cursor21QuasaritePrice + "";
            cursor21RadiantNovaStonePriceText.text = cursor21RadiantNovaStonePrice + "";
            cursor21SoluniumShardPriceText.text = cursor21SoluniumShardPrice + "";
            cursor21ActiveDamagePercentText.text = HoverSetStrings.cursor21ActiveText;
            cursor21PassiveDamagePercentText.text = HoverSetStrings.cursor21PassiveText;
            cursor21CritChancePercentText.text = HoverSetStrings.cursor21CritChanceText;
            cursor21CritDamagePercentText.text = HoverSetStrings.cursor21CritDamageText;
            cursorHoverChange[20] = true;
            cursor21Change = false;
        }


        if (!cursorsPriceChanged)
        {
            return;
        }

        UpgradesRedOrGreen();

        activeLevelText.text = "" + activeUpgradeLevel;
        passiveLevelText.text = "" + passiveUpgradeLevel;

        passiveDamagePriceText.text = Localization.price + TotalGoldAmount.FormatCoinsDoubleOneLetter(newPassiveDamagePrice) + Localization.gold;

        //NEW
        activeDamagePriceText.text = Localization.price + TotalGoldAmount.FormatCoinsDoubleOneLetter(newActiveDamagePrice) + Localization.gold;

        SetTopText();
        cursorsPriceChanged = false;

        if(resetClickDamage == true)
        {
            //New
            activeDamageText.text = (newActiveDamage.ToString("F2")) + Localization.clickDamage + " <color=green>(+" + (newActiveDamage * activeIncrease).ToString("F2") + ")<color=green>";

            SetEquippedFalse();
            setCursorsZero();

            currentlyEquippedText.text = Localization.equippedNONE;

            resetClickDamage = false;

        }
    }

    public static bool resetClickDamage;
  

    public void UpgradesRedOrGreen()
    {
        #region cursor1Price
        //Cursor 1 price
        if (RareDropsCollected.quartzCount >= cursor1QuartzUpgradePrice)
        {
            cursor1QuartzPriceText.color = Color.green;
        }
        if (RareDropsCollected.quartzCount < cursor1QuartzUpgradePrice)
        {
            cursor1QuartzPriceText.color = Color.red;
        }
        #endregion

        #region cursor2Price
        //Cursor 2 price
        if (RareDropsCollected.quartzCount >= cursor2QuartzUpgradePrice)
        {
            cursor2QuartzPriceText.color = Color.green;
        }
        if (RareDropsCollected.quartzCount < cursor2QuartzUpgradePrice)
        {
            cursor2QuartzPriceText.color = Color.red;
        }
        #endregion

        #region cursor3Price
        if (RareDropsCollected.quartzCount >= cursor3QuartzPrice)
        {
            cursor3QuartzPriceText.color = Color.green;
        }
        if (RareDropsCollected.quartzCount < cursor3QuartzPrice)
        {
            cursor3QuartzPriceText.color = Color.red;
        }

        if (RareDropsCollected.amethystCount >= cursor3AmethystPrice)
        {
            cursor3AmethystPriceText.color = Color.green;
        }
        if (RareDropsCollected.amethystCount < cursor3AmethystPrice)
        {
            cursor3AmethystPriceText.color = Color.red;
        }
        #endregion

        #region cursor4Price
        if (RareDropsCollected.yellowTopazCount >= cursor4TopazPrice)
        {
            cursor4TopazPriceText.color = Color.green;
        }
        if (RareDropsCollected.yellowTopazCount < cursor4TopazPrice)
        {
            cursor4TopazPriceText.color = Color.red;
        }
        #endregion

        #region cursor5Price
        if (RareDropsCollected.albiteCount >= cursor5AlbitePrice)
        {
            cursor5AlbitePriceText.color = Color.green;
        }
        if (RareDropsCollected.albiteCount < cursor5AlbitePrice)
        {
            cursor5AlbitePriceText.color = Color.red;
        }
        #endregion

        #region cursor6Price
        if (RareDropsCollected.albiteCount >= cursor6AlbitePrice)
        {
            cursor6AlbitePriceText.color = Color.green;
        }
        if (RareDropsCollected.albiteCount < cursor6AlbitePrice)
        {
            cursor6AlbitePriceText.color = Color.red;
        }

        if (RareDropsCollected.redGarnetCount >= cursor6RedGarnetPrice)
        {
            cursor6ReGarnetPriceText.color = Color.green;
        }
        if (RareDropsCollected.redGarnetCount < cursor6RedGarnetPrice)
        {
            cursor6ReGarnetPriceText.color = Color.red;
        }
        #endregion

        #region cursor7Price
        if (RareDropsCollected.aquamarineCount >= cursor7AquamarinePrice)
        {
            cursor7AquamarineText.color = Color.green;
        }
        if (RareDropsCollected.aquamarineCount < cursor7AquamarinePrice)
        {
            cursor7AquamarineText.color = Color.red;
        }
        #endregion

        #region cursor8Price
        if (RareDropsCollected.aquamarineCount >= cursor8AquamarinePrice)
        {
            cursor8AquamarinePriceText.color = Color.green;
        }
        if (RareDropsCollected.aquamarineCount < cursor8AquamarinePrice)
        {
            cursor8AquamarinePriceText.color = Color.red;
        }

        if (RareDropsCollected.yellowSapphireCount >= cursor8YellowSapphirePrice)
        {
            cursor8YellowSapphirePriceText.color = Color.green;
        }
        if (RareDropsCollected.yellowSapphireCount < cursor8YellowSapphirePrice)
        {
            cursor8YellowSapphirePriceText.color = Color.red;
        }
        #endregion

        #region cursor9Price
        if (RareDropsCollected.pinkTourmalineCount >= cursor9PinkTourmalinePrice)
        {
            cursor9PinkTourmalinePriceText.color = Color.green;
        }
        if (RareDropsCollected.pinkTourmalineCount < cursor9PinkTourmalinePrice)
        {
            cursor9PinkTourmalinePriceText.color = Color.red;
        }
        #endregion

        #region cursor10Price
        if (RareDropsCollected.AdventurineCount >= cursor10AdventurinePrice)
        {
            cursor10AdventurinePriceText.color = Color.green;
        }
        if (RareDropsCollected.AdventurineCount < cursor10AdventurinePrice)
        {
            cursor10AdventurinePriceText.color = Color.red;
        }
        #endregion

        #region cursor11Price
        if (RareDropsCollected.AdventurineCount >= cursor11AdventurinePrice)
        {
            cursor11AdventurinePriceText.color = Color.green;
        }
        if (RareDropsCollected.AdventurineCount < cursor11AdventurinePrice)
        {
            cursor11AdventurinePriceText.color = Color.red;
        }

        if (RareDropsCollected.pinkTourmalineCount >= cursor11PinkTourmalinePrice)
        {
            cursor11PinkTourmalinePriceText.color = Color.green;
        }
        if (RareDropsCollected.pinkTourmalineCount < cursor11PinkTourmalinePrice)
        {
            cursor11PinkTourmalinePriceText.color = Color.red;
        }
        #endregion

        #region cursor12Price
        if (RareDropsCollected.AdventurineCount >= cursor12AdventurinePrice)
        {
            cursor12AdventurinePriceText.color = Color.green;
        }
        if (RareDropsCollected.AdventurineCount < cursor12AdventurinePrice)
        {
            cursor12AdventurinePriceText.color = Color.red;
        }

        if (RareDropsCollected.RedGemCount >= cursor12RedRubyPrice)
        {
            cursor12RedRubyPriceText.color = Color.green;
        }
        if (RareDropsCollected.RedGemCount < cursor12RedRubyPrice)
        {
            cursor12RedRubyPriceText.color = Color.red;
        }
        #endregion

        #region cursor13Price
        if (RareDropsCollected.diamondCount >= cursor13DiamondPrice)
        {
            cursor13DiamondPriceText.color = Color.green;
        }
        if (RareDropsCollected.diamondCount < cursor13DiamondPrice)
        {
            cursor13DiamondPriceText.color = Color.red;
        }

        if (RareDropsCollected.grandidieriteCount >= cursor13GrandideritePrice)
        {
            cursor13GrandideritePriceText.color = Color.green;
        }
        if (RareDropsCollected.grandidieriteCount < cursor13GrandideritePrice)
        {
            cursor13GrandideritePriceText.color = Color.red;
        }
        #endregion

        #region cursor14Price
        if (RareDropsCollected.violetCrystalCount >= cursor14VioletCrystalPrice)
        {
            cursor14VioletCrystalPriceText.color = Color.green;
        }
        if (RareDropsCollected.violetCrystalCount < cursor14VioletCrystalPrice)
        {
            cursor14VioletCrystalPriceText.color = Color.red;
        }

        if (RareDropsCollected.grandidieriteCount >= cursor14GrandideritePrice)
        {
            cursor14GrandideritePriceText.color = Color.green;
        }
        if (RareDropsCollected.grandidieriteCount < cursor14GrandideritePrice)
        {
            cursor14GrandideritePriceText.color = Color.red;
        }
        #endregion

        #region cursor15Price
        if (RareDropsCollected.akoyaPearlCount >= cursor15AkoyaPeralPrice)
        {
            cursor15AkoyaPeralPriceText.color = Color.green;
        }
        if (RareDropsCollected.akoyaPearlCount < cursor15AkoyaPeralPrice)
        {
            cursor15AkoyaPeralPriceText.color = Color.red;
        }

        if (RareDropsCollected.purpleRupeeCount >= cursor15PurpleRupeePrice)
        {
            cursor15PurpleRupeePriceText.color = Color.green;
        }
        if (RareDropsCollected.purpleRupeeCount < cursor15PurpleRupeePrice)
        {
            cursor15PurpleRupeePriceText.color = Color.red;
        }

        if (RareDropsCollected.emeraldCount >= cursor15EmeraldPrice)
        {
            cursor15EmeraldPriceText.color = Color.green;
        }
        if (RareDropsCollected.emeraldCount < cursor15EmeraldPrice)
        {
            cursor15EmeraldPriceText.color = Color.red;
        }
        #endregion

        #region cursor16Price
        if (RareDropsCollected.greenDiamondCount >= cursor16GreenDiamondPrice)
        {
            cursor16GreenDiamondPriceText.color = Color.green;
        }
        if (RareDropsCollected.greenDiamondCount < cursor16GreenDiamondPrice)
        {
            cursor16GreenDiamondPriceText.color = Color.red;
        }

        if (RareDropsCollected.fireOpalCount >= cursor16FireOpalPrice)
        {
            cursor16FireOpalPriceText.color = Color.green;
        }
        if (RareDropsCollected.fireOpalCount < cursor16FireOpalPrice)
        {
            cursor16FireOpalPriceText.color = Color.red;
        }

        if (RareDropsCollected.gemSilicaCount >= cursor16GemSilicaPrice)
        {
            cursor16GemSilicaPriceText.color = Color.green;
        }
        if (RareDropsCollected.gemSilicaCount < cursor16GemSilicaPrice)
        {
            cursor16GemSilicaPriceText.color = Color.red;
        }
        #endregion

        #region cursor17Price
        if (RareDropsCollected.pinkPlostCount >= cursor17PinkPlortPrice)
        {
            cursor17PinkPlortPriceText.color = Color.green;
        }
        if (RareDropsCollected.pinkPlostCount < cursor17PinkPlortPrice)
        {
            cursor17PinkPlortPriceText.color = Color.red;
        }

        if (RareDropsCollected.goldeSeaPearlCount >= cursor17GoldenSeaPEarlPrice)
        {
            cursor17GoldenSeaPEarlPriceText.color = Color.green;
        }
        if (RareDropsCollected.goldeSeaPearlCount < cursor17GoldenSeaPEarlPrice)
        {
            cursor17GoldenSeaPEarlPriceText.color = Color.red;
        }

        if (RareDropsCollected.kyaniteCount >= cursor17KyanitePrice)
        {
            cursor17KyanitePriceText.color = Color.green;
        }
        if (RareDropsCollected.kyaniteCount < cursor17KyanitePrice)
        {
            cursor17KyanitePriceText.color = Color.red;
        }
        #endregion

        #region cursor18Price
        if (RareDropsCollected.blackOpalCount >= cursor18BlackOpalPrice)
        {
            cursor18BlackOpalPriceText.color = Color.green;
        }
        if (RareDropsCollected.blackOpalCount < cursor18BlackOpalPrice)
        {
            cursor18BlackOpalPriceText.color = Color.red;
        }

        if (RareDropsCollected.painiteCount >= cursor18PainitePrice)
        {
            cursor18PainitePriceText.color = Color.green;
        }
        if (RareDropsCollected.painiteCount < cursor18PainitePrice)
        {
            cursor18PainitePriceText.color = Color.red;
        }

        if (RareDropsCollected.TanzaniteCount >= cursor18TanzanitePrice)
        {
            cursor18TanzanitePriceText.color = Color.green;
        }
        if (RareDropsCollected.TanzaniteCount < cursor18TanzanitePrice)
        {
            cursor18TanzanitePriceText.color = Color.red;
        }
        #endregion

        #region cursor19Price
        if (RareDropsCollected.astraliumCount >= cursor19AstraliumPrice)
        {
            cursor19AstraliumPriceText.color = Color.green;
        }
        if (RareDropsCollected.astraliumCount < cursor19AstraliumPrice)
        {
            cursor19AstraliumPriceText.color = Color.red;
        }

        if (RareDropsCollected.elysiumPrismCount >= cursor19ElysiumPrismPrice)
        {
            cursor19ElysiumPrismPriceText.color = Color.green;
        }
        if (RareDropsCollected.elysiumPrismCount < cursor19ElysiumPrismPrice)
        {
            cursor19ElysiumPrismPriceText.color = Color.red;
        }

        if (RareDropsCollected.aetherfireOpalCount >= cursor19AerthfireOpalPrice)
        {
            cursor19AerthfireOpalPriceText.color = Color.green;
        }
        if (RareDropsCollected.aetherfireOpalCount < cursor19AerthfireOpalPrice)
        {
            cursor19AerthfireOpalPriceText.color = Color.red;
        }
        #endregion

        #region cursor20Price
        if (RareDropsCollected.eldritchStarstoneCount >= cursor20EldritchStarStonePrice)
        {
            cursor20EldritchStarStonePriceText.color = Color.green;
        }
        if (RareDropsCollected.eldritchStarstoneCount < cursor20EldritchStarStonePrice)
        {
            cursor20EldritchStarStonePriceText.color = Color.red;
        }

        if (RareDropsCollected.chronolithShardCount >= cursor20ChronolithShardPrice)
        {
            cursor20ChronolithShardPriceText.color = Color.green;
        }
        if (RareDropsCollected.chronolithShardCount < cursor20ChronolithShardPrice)
        {
            cursor20ChronolithShardPriceText.color = Color.red;
        }

        if (RareDropsCollected.sideriumEssenceCount >= cursor20SideriumEssencePrice)
        {
            cursor20SideriumEssencePriceText.color = Color.green;
        }
        if (RareDropsCollected.sideriumEssenceCount < cursor20SideriumEssencePrice)
        {
            cursor20SideriumEssencePriceText.color = Color.red;
        }
        #endregion

        #region cursor21Price
        if (RareDropsCollected.quasariteCount >= cursor21QuasaritePrice)
        {
            cursor21QuasaritePriceText.color = Color.green;
        }
        if (RareDropsCollected.quasariteCount < cursor21QuasaritePrice)
        {
            cursor21QuasaritePriceText.color = Color.red;
        }

        if (RareDropsCollected.radiantNovaStoneCount >= cursor21RadiantNovaStonePrice)
        {
            cursor21RadiantNovaStonePriceText.color = Color.green;
        }
        if (RareDropsCollected.radiantNovaStoneCount < cursor21RadiantNovaStonePrice)
        {
            cursor21RadiantNovaStonePriceText.color = Color.red;
        }

        if (RareDropsCollected.soluniumShardCount >= cursor21SoluniumShardPrice)
        {
            cursor21SoluniumShardPriceText.color = Color.green;
        }
        if (RareDropsCollected.soluniumShardCount < cursor21SoluniumShardPrice)
        {
            cursor21SoluniumShardPriceText.color = Color.red;
        }
        #endregion

    }


    #region activeClickDamageUpgrade

    public float activeIncrease;

    public static bool isActiveMaxActive;
    public Image active1XButton, activeMaxButton;
    public TextMeshProUGUI activeMaxUpgradeText;
    public int activeMaxTimesUpgraded;
    public static bool activeMaxIsActive;

    //1k = 57 passive damae and 19 levels. Next price is 142 gold. (+12)


    public void Active1XButton()
    {
        activeMaxUpgradeText.text = Localization.upgrade;
        if (AudioManager.audioMuted == 1) { audioManager.Play("PurchaseSound"); }
        isActiveMaxActive = false;
        activeMaxIsActive = false;
        SetAlphaPassive(active1XButton, alphaValueFull);
        SetAlphaPassive(activeMaxButton, alphavalueHalf);
    }

    public void ActiveMaxButton()
    {
        activeMaxUpgradeText.text = Localization.upgradeMax;
        if (AudioManager.audioMuted == 1) { audioManager.Play("PurchaseSound"); }
        isActiveMaxActive = true;
        activeMaxIsActive = true;
        SetAlphaPassive(active1XButton, alphavalueHalf);
        SetAlphaPassive(activeMaxButton, alphaValueFull);
    }



    public void ClickPowerActiveButton()
    {
        if (isActiveMaxActive == false) { PurchaseActive(); }
        if (isActiveMaxActive == true)
        {
            while (UpdateGame.totalGoldHigher >= newActiveDamagePrice)
            {
                PurchaseActive();
            }

            if (UpdateGame.totalGoldHigher < newActiveDamagePrice)
            {
                if (AudioManager.audioMuted == 1) { audioManager.Play("Error"); } 
            }

        }
    }

    public void PurchaseActive()
    {
        if (UpdateGame.totalGoldHigher < newActiveDamagePrice)
        {
            if (AudioManager.audioMuted == 1)
            {
                audioManager.Play("Error");
            }
        }
        if (UpdateGame.totalGoldHigher >= newActiveDamagePrice)
        {
            if (AudioManager.audioMuted == 1) { audioManager.Play("PurchaseSound"); }
            UpdateGame.totalGoldHigher -= newActiveDamagePrice;

            //New
            if (newActiveDamage > 1000000000) { newActiveDamage += (newActiveDamage * a6); activeIncrease = a6; }
            else if (newActiveDamage > 1000000) { newActiveDamage += (newActiveDamage * a5); activeIncrease = a5; }
            else if (newActiveDamage > 10000) { newActiveDamage += (newActiveDamage * a4); activeIncrease = a4; }
            else if (newActiveDamage > 100) { newActiveDamage += (newActiveDamage * a3); activeIncrease = a3; }
            else if (newActiveDamage > 10) { newActiveDamage += (newActiveDamage * a2); activeIncrease = a2; }
            else if (newActiveDamage < 10) { newActiveDamage += (newActiveDamage * a1); activeIncrease = a1; }


            newActiveDamagePrice *= 1.15f;

            // Check if activeClickPowerPrice has any decimal points
            if (newActiveDamagePrice % 1 != 0)
            {
                // Calculate the decimal component
                double decimalComponent = newActiveDamagePrice % 1;

                // Check if the decimal component is less than 0.5
                if (decimalComponent < 0.5f)
                {
                    // Subtract the decimal component from activeClickPowerPrice
                    newActiveDamagePrice -= decimalComponent;
                }
                else
                {
                    // Add the difference to make the number whole
                    newActiveDamagePrice += (1 - decimalComponent);
                }
            }

            //NEW
            if (newActiveDamage < 10) { activeDamageText.text = (newActiveDamage.ToString("F2")) + Localization.clickDamage + "<color=green>(+" + (newActiveDamage * activeIncrease).ToString("F2") + ")<color=green>"; }
            if (newActiveDamage > 10) { activeDamageText.text = TotalGoldAmount.FormatCoinsDoubleOneLetter(newActiveDamage) + Localization.clickDamage + " <color=green>(+" + TotalGoldAmount.FormatCoinsDoubleOneLetter(newActiveDamage * activeIncrease) + ")<color=green>"; }

           

            activeUpgradeLevel += 1;
            activeLevelText.text = "" + activeUpgradeLevel;
            cursorsPriceChanged = true;
            SetTopText();
        }
    }

    #endregion

    #region passiveClickDamageUpgrade
    public float passiveIncrease;
    public static bool isPassiveMaxActive;
    public Image passive1XButton, passiveMaxButton;
    public float alphaValueFull, alphavalueHalf;
    public TextMeshProUGUI passiveMaxUpgradeText;
    public static bool passiveMaxIsActive;


    public void Passive1XButton()
    {
        passiveMaxUpgradeText.text = Localization.upgrade;
        if (AudioManager.audioMuted == 1) { audioManager.Play("PurchaseSound"); }
        isPassiveMaxActive = false;
        passiveMaxIsActive = false;
        SetAlphaPassive(passive1XButton, alphaValueFull);
        SetAlphaPassive(passiveMaxButton, alphavalueHalf);
    }

    public void PassiveMaxButton()
    {
        passiveMaxUpgradeText.text = Localization.upgradeMax;
        if (AudioManager.audioMuted == 1) { audioManager.Play("PurchaseSound"); }
        isPassiveMaxActive = true;
        passiveMaxIsActive = true;
        SetAlphaPassive(passive1XButton, alphavalueHalf);
        SetAlphaPassive(passiveMaxButton, alphaValueFull);
    }


    public void ClickPowerPassiveButton()
    {
        if(isPassiveMaxActive == false) { UpgradePassive(); }
        if (isPassiveMaxActive == true)
        { 
            while (UpdateGame.totalGoldHigher >= newPassiveDamagePrice)
            {
                UpgradePassive();
            }

            if (UpdateGame.totalGoldHigher < newPassiveDamagePrice)
            {
                if (AudioManager.audioMuted == 1) { audioManager.Play("Error"); }
            }

        }
    }

    public void UpgradePassive()
    {
        if (UpdateGame.totalGoldHigher < newPassiveDamagePrice)
        {
            if (AudioManager.audioMuted == 1)
            {
                audioManager.Play("Error");
            }
        }

        if (UpdateGame.totalGoldHigher >= newPassiveDamagePrice)
        {
            if (AudioManager.audioMuted == 1) { audioManager.Play("PurchaseSound"); }
            passiveUpgradeLevel += 1;
            passiveLevelText.text = "" + passiveUpgradeLevel;

            UpdateGame.totalGoldHigher -= newPassiveDamagePrice;


            newPassiveDamagePrice *= 1.15f;

            if (newPassiveDamagePrice % 1 != 0)
            {
                double decimalComponent = newPassiveDamagePrice % 1;

                if (decimalComponent < 0.5f)
                {
                    newPassiveDamagePrice -= decimalComponent;
                }
                else
                {
                    newPassiveDamagePrice += (1 - decimalComponent);
                }
            }

            passiveDamagePriceText.text = Localization.price + TotalGoldAmount.FormatCoinsDoubleOneLetter(newPassiveDamagePrice) + Localization.gold;

            //NEW
            if (HealthBar.newPassiveDamage == 0)
            {
                HealthBar.newPassiveDamage = 0.15f;
                SetNewAutoDamage();
            }
            else
            {
                if (HealthBar.newPassiveDamage > 1000000000) { HealthBar.newPassiveDamage += (HealthBar.newPassiveDamage * p6); passiveIncrease = p6; }
                else if (HealthBar.newPassiveDamage > 1000000) { HealthBar.newPassiveDamage += (HealthBar.newPassiveDamage * p5); passiveIncrease = p5; }
                else if (HealthBar.newPassiveDamage > 10000) { HealthBar.newPassiveDamage += (HealthBar.newPassiveDamage * p4); passiveIncrease = p4; }
                else if (HealthBar.newPassiveDamage > 100) { HealthBar.newPassiveDamage += (HealthBar.newPassiveDamage * p3); passiveIncrease = p3; }
                else if (HealthBar.newPassiveDamage > 10) { HealthBar.newPassiveDamage += (HealthBar.newPassiveDamage * p2); passiveIncrease = p2; }
                else if (HealthBar.newPassiveDamage < 10) { HealthBar.newPassiveDamage += (HealthBar.newPassiveDamage * p1); passiveIncrease = p1; }
                else if (HealthBar.newPassiveDamage < 1) { HealthBar.newPassiveDamage += (HealthBar.newPassiveDamage * 0.65f); }

                SetTopText();
                SetNewAutoDamage();
            }

           
            cursorsPriceChanged = true;
        }
    }


    private void SetAlphaPassive(Graphic graphic, float alpha)
    {
        Color currentColor = graphic.color;
        currentColor.a = alpha;
        graphic.color = currentColor;

        for (int i = 0; i < graphic.transform.childCount; i++)
        {
            Graphic childGraphic = graphic.transform.GetChild(i).GetComponent<Graphic>();
            if (childGraphic != null)
            {
                SetAlphaPassive(childGraphic, alpha);
            }
        }
    }

    public void SetNewAutoDamage()
    {
        if (HealthBar.newPassiveDamage < 10)
        {
            damagePerSecondText.text = Localization.dps + ": <color=green>" + ((HealthBar.newPassiveDamage) * (1 + passiveDamageMultiplier + UseConsumable.damagePotionBuff + UseConsumable.elixirDamageBuff + SkillTree.skillTreePassiveDamage + RareTreasures.skullPassiveDamage + RareTreasures.guitarActiveAndPassive + RareTreasures.talariaPassive + RareTreasures.cookiePassive + UseConsumable.scrollPassiveDamageBuff + UseConsumable.relicPermaPassiveDamage + UpdateGame.damageBuffAmount - UpdateGame.damageDebuffAmount)).ToString("F2");

            passiveDamagePerSecond.text = (HealthBar.newPassiveDamage.ToString("F2")) + " " + Localization.dps +  "<color=green>(+" + (HealthBar.newPassiveDamage * passiveIncrease).ToString("F2") + ")<color=green>";

            if (HealthBar.newPassiveDamage == 0)
            {
                passiveDamagePerSecond.text = "0" + Localization.dps + ": " + "<color=green>(+0.15)";
            }
        }
        if (HealthBar.newPassiveDamage > 10)
        {
            damagePerSecondText.text = Localization.dps + ": <color=green>" + TotalGoldAmount.FormatCoinsDoubleOneLetter((HealthBar.newPassiveDamage) * (1 + passiveDamageMultiplier + UseConsumable.damagePotionBuff + UseConsumable.elixirDamageBuff + SkillTree.skillTreePassiveDamage + RareTreasures.skullPassiveDamage + RareTreasures.guitarActiveAndPassive + RareTreasures.talariaPassive + RareTreasures.cookiePassive + UseConsumable.scrollPassiveDamageBuff + UseConsumable.relicPermaPassiveDamage + UpdateGame.damageBuffAmount - UpdateGame.damageDebuffAmount));

            passiveDamagePerSecond.text = TotalGoldAmount.FormatCoinsDoubleOneLetter((HealthBar.newPassiveDamage)) + " " + Localization.dps + " " + "<color=green>(+" + TotalGoldAmount.FormatCoinsDoubleOneLetter((HealthBar.newPassiveDamage) * passiveIncrease) + ")<color=green>";
        }

    }
    #endregion


    #region Cursor1
    public static int cursor1QuartzUpgradePrice;
    public static float cursor1ActiveBuff;
    public static float cursor1ActiveBuffIncrement;
    public static int Cursor1Level;
    public static int cursor1Equipped;

    public GameObject Cursor1Button;
    public TextMeshProUGUI equippedTextCursor1;
    public TextMeshProUGUI cursor1ActivePercentText,cursor1PassivePercentText, cursor1CritChanceText,cursor1CritDamageText;
    public TextMeshProUGUI cursor1QuartzPriceText;
    public TextMeshProUGUI cursorLevelText;
    public TextMeshProUGUI cursor1LevelHoverText;

    public void EquippCursor1()
    {
        currentlyEquippedText.text = Localization.cursor1Equipped;
        SetEquippedFalse();
        setCursorsZero();
        equippedTextCursor1.text = Localization.equipped; equippedTextCursor1.color = Color.green;
        activeDamageMultiplier = cursor1ActiveBuff;

        cursor1Equipped = 1;

        Color newColor;
        ColorUtility.TryParseHtmlString(equippedColor, out newColor);
        cursorButtons[0].color = newColor;
        SetTopText();
    }

    public void UpgradeCursor1()
    {
        if (isCursorMax == true)
        {
            if (RareDropsCollected.quartzCount < cursor1QuartzUpgradePrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.quartzCount >= cursor1QuartzUpgradePrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.quartzCount >= cursor1QuartzUpgradePrice)
            {
                Cursor1Variables();
            }
        }
        else
        {
            if (RareDropsCollected.quartzCount < cursor1QuartzUpgradePrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.quartzCount >= cursor1QuartzUpgradePrice)
            {
                Cursor1Variables();
                UpgradeSound();
            }
        }
    }

    public void Cursor1Variables()
    {
        Stats.cursorUpgraded += 1;
        RareDropsCollected.isGemCountUpdated = true;
        RareDropsCollected.quartzCount -= cursor1QuartzUpgradePrice;
        cursor1ActiveBuff += cursor1ActiveBuffIncrement;
        if (cursor1Equipped == 1) { activeDamageMultiplier = cursor1ActiveBuff; SetTopText(); }

        cursor1QuartzUpgradePrice += 1;
        Cursor1Level += 1;

        HoverSetStrings.boughtUpgrade = true;
        cursorsPriceChanged = true;
        cursor1Change = true;
    }

    #endregion

    #region Cursor2
    public static int cursor2QuartzUpgradePrice;
    public static float cursor2PassiveBuff;
    public static float cursor2PassiveBuffIncrement;
    public static int cursor2Level;
    public static int cursor2Equipped;

    public GameObject Cursor2Button;
    public TextMeshProUGUI equippedTextCursor2;
    public TextMeshProUGUI cursor2PassivePercentText, cursor2ActiveText, cursor2CritChanceText, cursor2CritDamageText;
    public TextMeshProUGUI cursor2QuartzPriceText;
    public TextMeshProUGUI cursor2LevelText;
    public TextMeshProUGUI cursor2LevelHoverText;

    public void EquippCursor2()
    {
        currentlyEquippedText.text = Localization.cursor2Equipped;
        SetEquippedFalse();
        setCursorsZero();
        equippedTextCursor2.text = Localization.equipped; equippedTextCursor2.color = Color.green;
        passiveDamageMultiplier = cursor2PassiveBuff;
        
        cursor2Equipped = 1;

        Color newColor;
        ColorUtility.TryParseHtmlString(equippedColor, out newColor);
        cursorButtons[1].color = newColor;
        SetTopText();
    }

    public void UpgradeCursor2()
    {
        if (isCursorMax == true)
        {
            if (RareDropsCollected.quartzCount < cursor2QuartzUpgradePrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.quartzCount >= cursor2QuartzUpgradePrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.quartzCount >= cursor2QuartzUpgradePrice)
            {
                Cursor2Variables();
            }
        }
        else
        {
            if (RareDropsCollected.quartzCount < cursor2QuartzUpgradePrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.quartzCount >= cursor2QuartzUpgradePrice)
            {
                Cursor2Variables();
                UpgradeSound();
            }
        }
    }

    public void Cursor2Variables()
    {
        Stats.cursorUpgraded += 1;
        RareDropsCollected.isGemCountUpdated = true;
        RareDropsCollected.quartzCount -= cursor2QuartzUpgradePrice;

        cursor2PassiveBuff += cursor2PassiveBuffIncrement;
        if (cursor2Equipped == 1) { passiveDamageMultiplier = cursor2PassiveBuff; SetTopText(); }
        cursor2QuartzUpgradePrice += 2;
        cursor2Level += 1;

        HoverSetStrings.boughtUpgrade = true;
        cursorsPriceChanged = true;
        cursor2Change = true;
    }
    #endregion

    #region Cursor3
    public static int cursor3QuartzPrice;
    public static int cursor3AmethystPrice;
    public static float cursor3CritDamage;
    public static float cursor3CritDamageIncrement;
    public static float cursor3CritChance;
    public static float cursor3CritChanceIncrement;
    public static int cursor3Level;
    public static int cursor3Equipped;

    public GameObject cursor3Button;
    public TextMeshProUGUI equippedTextCursor3;
    public TextMeshProUGUI cursors3CritChancePercentText;
    public TextMeshProUGUI cursor3CritDamagePercentTect, cursor3ActiveText, cursor3PassiveText;
    public TextMeshProUGUI cursor3QuartzPriceText;
    public TextMeshProUGUI cursor3AmethystPriceText;
    public TextMeshProUGUI cursor3LevelText;
    public TextMeshProUGUI cursor3LevelHoverText;

    public void EquippCursor3()
    {
        currentlyEquippedText.text = Localization.cursor3Equipped;
        SetEquippedFalse();
        setCursorsZero();

        equippedTextCursor3.text = Localization.equipped; equippedTextCursor3.color = Color.green;
        critDamage = cursor3CritDamage;
        critChance = cursor3CritChance;

        Color newColor;
        ColorUtility.TryParseHtmlString(equippedColor, out newColor);
        cursorButtons[2].color = newColor;
        SetTopText();
        cursor3Equipped = 1;
    }

    public void UpgradeCursor3()
    {
        if (isCursorMax == true)
        {
            if (RareDropsCollected.quartzCount < cursor3QuartzPrice || RareDropsCollected.amethystCount < cursor3AmethystPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.quartzCount >= cursor3QuartzPrice && RareDropsCollected.amethystCount >= cursor3AmethystPrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.quartzCount >= cursor3QuartzPrice && RareDropsCollected.amethystCount >= cursor3AmethystPrice)
            {
                Cursor3Variables();
            }
        }
        else
        {
            if (RareDropsCollected.quartzCount < cursor3QuartzPrice || RareDropsCollected.amethystCount < cursor3AmethystPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.quartzCount >= cursor3QuartzPrice && RareDropsCollected.amethystCount >= cursor3AmethystPrice)
            {
                Cursor3Variables();
                UpgradeSound();
            }
        }
    }

    public void Cursor3Variables()
    {
        Stats.cursorUpgraded += 1;
        RareDropsCollected.isGemCountUpdated = true;
        RareDropsCollected.quartzCount -= cursor3QuartzPrice;
        RareDropsCollected.amethystCount -= cursor3AmethystPrice;

        cursor3CritChance += cursor3CritChanceIncrement;
        cursor3CritDamage += cursor3CritDamageIncrement;

        if (cursor3Equipped == 1) { critDamage = cursor3CritDamage; critChance = cursor3CritChance; SetTopText(); }
        cursor3QuartzPrice += 1;
        cursor3AmethystPrice += 1;
        cursor3Level += 1;

        HoverSetStrings.boughtUpgrade = true;
        cursorsPriceChanged = true;
        cursor3Change = true;
    }

    #endregion

    #region Cursor4
    public static int cursor4TopazPrice;
    public static float cursor4ActiveDamage;
    public static float cursor4ActiveDamageIncrement;
    public static float cursor4PassiveDamage;
    public static float cursor4PassiveDamageIncrement;
    public static int cursor4Level;
    public static int cursor4Equipped;

    public GameObject cursor4Button;
    public TextMeshProUGUI equippedTextCursor4;
    public TextMeshProUGUI cursor4ActiveDamagePercentText;
    public TextMeshProUGUI cursor4PassiveDamagePercentText, cursor4CritChanceText, cursor4CritDamageText;
    public TextMeshProUGUI cursor4LevelText;
    public TextMeshProUGUI cursor4LevelHoverText;
    public TextMeshProUGUI cursor4TopazPriceText;

    public void EquippCursor4()
    {
        currentlyEquippedText.text = Localization.cursor4Equipped;
        SetEquippedFalse();
        setCursorsZero();

        equippedTextCursor4.text = Localization.equipped; equippedTextCursor4.color = Color.green;
        activeDamageMultiplier = cursor4ActiveDamage;
        passiveDamageMultiplier = cursor4PassiveDamage;

        Color newColor;
        ColorUtility.TryParseHtmlString(equippedColor, out newColor);
        cursorButtons[3].color = newColor;
        SetTopText();
        cursor4Equipped = 1;
    }

    public void UpgradeCursor4()
    {
        if (isCursorMax == true)
        {
            if (RareDropsCollected.yellowTopazCount < cursor4TopazPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.yellowTopazCount >= cursor4TopazPrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.yellowTopazCount >= cursor4TopazPrice)
            {
                Cursor4Variables();
            }
        }
        else
        {
            if (RareDropsCollected.yellowTopazCount < cursor4TopazPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.yellowTopazCount >= cursor4TopazPrice)
            {
                Cursor4Variables();
                UpgradeSound();
            }
        }

    }

    public void Cursor4Variables()
    {
        Stats.cursorUpgraded += 1;
        RareDropsCollected.isGemCountUpdated = true;
        RareDropsCollected.yellowTopazCount -= cursor4TopazPrice;

        cursor4ActiveDamage += cursor4ActiveDamageIncrement;
        cursor4PassiveDamage += cursor4PassiveDamageIncrement;

        if (cursor4Equipped == 1) { activeDamageMultiplier = cursor4ActiveDamage; passiveDamageMultiplier = cursor4PassiveDamage; SetTopText(); }
        cursor4TopazPrice += 1;
        cursor4Level += 1;

        HoverSetStrings.boughtUpgrade = true;
        cursorsPriceChanged = true;
        cursor4Change = true;
    }

    #endregion

    #region Cursor5
    public static int cursor5AlbitePrice;
    public static float cursor5ActiveDamage;
    public static float cursor5ActiveDamageIncrement;
    public static float cursor5CritDamage;
    public static float cursor5CritDamageIncrement;
    public static float cursor5CritChance;
    public static float cursor5CritChanceIncrement;
    public static int cursor5Level;
    public static int cursor5Equipped;
    public static float cursor5RareDropsBonus;

    public GameObject cursor5Button;
    public TextMeshProUGUI equippedTextCursor5;
    public TextMeshProUGUI cursor5ActiveDamagePercentText;
    public TextMeshProUGUI cursor5CritDamagePercentText;
    public TextMeshProUGUI cursor5CritChancePercentText, cursor5PassiveText;
    public TextMeshProUGUI cursor5LevelText;
    public TextMeshProUGUI cursor5LevelHoverText;
    public TextMeshProUGUI cursor5AlbitePriceText;

    public void EquippCursor5()
    {
        currentlyEquippedText.text = Localization.cursor5Equipped;
        SetEquippedFalse();
        setCursorsZero();

        cursor5RareDropsBonus = 0.1f;
        SpawnRewards.changeDropChanceValues = true;

        equippedTextCursor5.text = Localization.equipped; equippedTextCursor5.color = Color.green;
        activeDamageMultiplier = cursor5ActiveDamage;
        critChance = cursor5CritChance;
        critDamage = cursor5CritDamage;

        Color newColor;
        ColorUtility.TryParseHtmlString(equippedColor, out newColor);
        cursorButtons[4].color = newColor;
        SetTopText();
        cursor5Equipped = 1;
    }

    public void UpgradeCursor5()
    {
        if (isCursorMax == true)
        {
            if (RareDropsCollected.albiteCount < cursor5AlbitePrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.albiteCount >= cursor5AlbitePrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.albiteCount >= cursor5AlbitePrice)
            {
                Cursor5Variables();
            }
        }
        else
        {
            if (RareDropsCollected.albiteCount < cursor5AlbitePrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.albiteCount >= cursor5AlbitePrice)
            {
                Cursor5Variables();
                UpgradeSound();
            }
        }
    }

    public void Cursor5Variables()
    {
        Stats.cursorUpgraded += 1;
        RareDropsCollected.isGemCountUpdated = true;
        RareDropsCollected.albiteCount -= cursor5AlbitePrice;

        cursor5ActiveDamage += cursor5ActiveDamageIncrement;
        cursor5CritChance += cursor5CritChanceIncrement;
        cursor5CritDamage += cursor5CritDamageIncrement;

        if (cursor5Equipped == 1) { activeDamageMultiplier = cursor5ActiveDamage; critChance = cursor5CritChance; critDamage = cursor5CritDamage; SetTopText(); }
        cursor5AlbitePrice += 1;
        cursor5Level += 1;

        HoverSetStrings.boughtUpgrade = true;
        cursorsPriceChanged = true;
        cursor5Change = true;
    }

    #endregion

    #region Cursor6
    public static int cursor6AlbitePrice;
    public static int cursor6RedGarnetPrice;
    public static float cursor6ActiveDamage;
    public static float cursor6ActiveDamageIncrement;
    public static float cursor6PassiveDamage;
    public static float cursor6PassiveDamageIncrement;
    public static float cursor6CritDamage;
    public static float cursor6CritDamageIncrement;
    public static float cursor6CritChance;
    public static float cursor6CritChanceIncrement;
    public static int cursor6Level;
    public static int cursor6Equipped;

    public GameObject cursor6Button;
    public TextMeshProUGUI equippedTextCursor6;
    public TextMeshProUGUI cursor6ActiveDamagePercentText;
    public TextMeshProUGUI cursor6PassiveDamagePercentText;
    public TextMeshProUGUI cursor6CritDamagePercentText;
    public TextMeshProUGUI cursor6CritChancePercentText;
    public TextMeshProUGUI cursor6LevelText;
    public TextMeshProUGUI cursor6LevelHoverText;

    public TextMeshProUGUI cursor6AlbitePriceText;
    public TextMeshProUGUI cursor6ReGarnetPriceText;


    public void EquippCursor6()
    {
        currentlyEquippedText.text = Localization.cursor6Equipped;
        SetEquippedFalse();
        setCursorsZero();

        cursorEquippedChance = 3;

        equippedTextCursor6.text = Localization.equipped; equippedTextCursor6.color = Color.green;
        activeDamageMultiplier = cursor6ActiveDamage;
        passiveDamageMultiplier = cursor6PassiveDamage;
        critChance = cursor6CritChance;
        critDamage = cursor6CritDamage;

        Color newColor;
        ColorUtility.TryParseHtmlString(equippedColor, out newColor);
        cursorButtons[5].color = newColor;
        SetTopText();
        cursor6Equipped = 1;
    }

    public void UpgradeCursor6()
    {
        if (isCursorMax == true)
        {
            if (RareDropsCollected.albiteCount < cursor6AlbitePrice || RareDropsCollected.redGarnetCount < cursor6RedGarnetPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.albiteCount >= cursor6AlbitePrice && RareDropsCollected.redGarnetCount >= cursor6RedGarnetPrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.albiteCount >= cursor6AlbitePrice && RareDropsCollected.redGarnetCount >= cursor6RedGarnetPrice)
            {
                Cursor6Variables();
            }
        }
        else
        {
            if (RareDropsCollected.albiteCount < cursor6AlbitePrice || RareDropsCollected.redGarnetCount < cursor6RedGarnetPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.albiteCount >= cursor6AlbitePrice && RareDropsCollected.redGarnetCount >= cursor6RedGarnetPrice)
            {
                Cursor6Variables();
                UpgradeSound();
            }
        }
    }

    public void Cursor6Variables()
    {
        Stats.cursorUpgraded += 1;
        RareDropsCollected.isGemCountUpdated = true;
        RareDropsCollected.albiteCount -= cursor6AlbitePrice;
        RareDropsCollected.redGarnetCount -= cursor6RedGarnetPrice;

        cursor6ActiveDamage += cursor6ActiveDamageIncrement;
        cursor6PassiveDamage += cursor6PassiveDamageIncrement;
        cursor6CritChance += cursor6CritChanceIncrement;
        cursor6CritDamage += cursor6CritDamageIncrement;

        if (cursor6Equipped == 1) { activeDamageMultiplier = cursor6ActiveDamage; critChance = cursor6CritChance; critDamage = cursor6CritDamage; passiveDamageMultiplier = cursor6PassiveDamage; SetTopText(); }
        cursor6AlbitePrice += 2;
        cursor6RedGarnetPrice += 2;
        cursor6Level += 1;

        HoverSetStrings.boughtUpgrade = true;
        cursorsPriceChanged = true;
        cursor6Change = true;
    }

    #endregion

    #region Cursor7
    public static int cursor7AquamarinePrice;
    public static float cursor7ActiveDamage;
    public static float cursor7ActiveDamageIncrement;
    public static float cursor7CritDamage;
    public static float cursor7CritDamageIncrement;
    public static float cursor7CritChance;
    public static float cursor7CritChanceIncrement;
    public static int cursor7Level;
    public static int cursor7Equipped;

    public GameObject cursor7Button;
    public TextMeshProUGUI equippedTextCursor7;
    public TextMeshProUGUI cursor7ActiveDamagePercentText;
    public TextMeshProUGUI cursor7CritDamagePercentText;
    public TextMeshProUGUI cursor7CritChancePercentText, cursor7PassiveText;
    public TextMeshProUGUI cursor7LevelText;
    public TextMeshProUGUI cursor7LevelHoverText;
    public TextMeshProUGUI cursor7AquamarineText;

    public void EquippCursor7()
    {
        currentlyEquippedText.text = Localization.cursor7Equipped;
        SetEquippedFalse();
        setCursorsZero();

        equippedTextCursor7.text = Localization.equipped; equippedTextCursor7.color = Color.green;

        cursorEquippedGoldIncrease = 0.05f;
        cursorEquippedXPIncrease = 0.05f;

        activeDamageMultiplier = cursor7ActiveDamage;
        critChance = cursor7CritChance;
        critDamage = cursor7CritDamage;

        Color newColor;
        ColorUtility.TryParseHtmlString(equippedColor, out newColor);
        cursorButtons[6].color = newColor;
        SetTopText();
        cursor7Equipped = 1;
    }

    public void UpgradeCursor7()
    {
        if (isCursorMax == true)
        {
            if (RareDropsCollected.aquamarineCount < cursor7AquamarinePrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.aquamarineCount >= cursor7AquamarinePrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.aquamarineCount >= cursor7AquamarinePrice)
            {
                Cursor7Variables();
            }
        }
        else
        {
            if (RareDropsCollected.aquamarineCount < cursor7AquamarinePrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.aquamarineCount >= cursor7AquamarinePrice)
            {
                Cursor7Variables();
                UpgradeSound();
            }
        }
    }

    public void Cursor7Variables()
    {
        Stats.cursorUpgraded += 1;
        RareDropsCollected.isGemCountUpdated = true;
        RareDropsCollected.aquamarineCount -= cursor7AquamarinePrice;

        cursor7ActiveDamage += cursor7ActiveDamageIncrement;
        cursor7CritChance += cursor7CritChanceIncrement;
        cursor7CritDamage += cursor7CritDamageIncrement;

        if (cursor7Equipped == 1) { activeDamageMultiplier = cursor7ActiveDamage; critChance = cursor7CritChance; critDamage = cursor7CritDamage; SetTopText(); }
        cursor7AquamarinePrice += 2;
        cursor7Level += 1;

        HoverSetStrings.boughtUpgrade = true;
        cursorsPriceChanged = true;
        cursor7Change = true;
    }
    #endregion

    #region Cursor8
    public static int cursor8AquamarinePrice;
    public static int cursor8YellowSapphirePrice;
    public static float cursor8ActiveDamage;
    public static float cursor8ActiveDamageIncrement;
    public static float cursor8PassiveDamage;
    public static float cursor8PassiveDamageIncrement;
    public static float cursor8CritDamage;
    public static float cursor8CritDamageIncrement;
    public static float cursor8CritChance;
    public static float cursor8CritChanceIncrement;
    public static int cursor8Level;
    public static int cursor8Equipped;

    public GameObject cursor8Button;
    public TextMeshProUGUI equippedTextCursor8;
    public TextMeshProUGUI cursor8ActiveDamagePercentText;
    public TextMeshProUGUI cursor8PassiveDamagePercentText;
    public TextMeshProUGUI cursor8CritDamagePercentText;
    public TextMeshProUGUI cursor8CritChancePercentText;
    public TextMeshProUGUI cursor8LevelText;
    public TextMeshProUGUI cursor8LevelHoverText;

    public TextMeshProUGUI cursor8AquamarinePriceText;
    public TextMeshProUGUI cursor8YellowSapphirePriceText;

    public void EquippCursor8()
    {
        currentlyEquippedText.text = Localization.cursor8Equipped;
        SetEquippedFalse();
        setCursorsZero();

        equippedTextCursor8.text = Localization.equipped; equippedTextCursor8.color = Color.green;
        activeDamageMultiplier = cursor8ActiveDamage;
        passiveDamageMultiplier = cursor8PassiveDamage;
        critChance = cursor8CritChance;
        critDamage = cursor8CritDamage;

        Color newColor;
        ColorUtility.TryParseHtmlString(equippedColor, out newColor);
        cursorButtons[7].color = newColor;
        SetTopText();
        cursor8Equipped = 1;
    }

    public void UpgradeCursor8()
    {
        if (isCursorMax == true)
        {
            if (RareDropsCollected.aquamarineCount < cursor8AquamarinePrice || RareDropsCollected.yellowSapphireCount < cursor8YellowSapphirePrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.aquamarineCount >= cursor8AquamarinePrice && RareDropsCollected.yellowSapphireCount >= cursor8YellowSapphirePrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.aquamarineCount >= cursor8AquamarinePrice && RareDropsCollected.yellowSapphireCount >= cursor8YellowSapphirePrice)
            {
                Cursor8Variables();
            }
        }
        else
        {
            if (RareDropsCollected.aquamarineCount < cursor8AquamarinePrice || RareDropsCollected.yellowSapphireCount < cursor8YellowSapphirePrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.aquamarineCount >= cursor8AquamarinePrice && RareDropsCollected.yellowSapphireCount >= cursor8YellowSapphirePrice)
            {
                Cursor8Variables();
                UpgradeSound();
            }
        }
    }

    public void Cursor8Variables()
    {
        Stats.cursorUpgraded += 1;
        RareDropsCollected.isGemCountUpdated = true;
        RareDropsCollected.aquamarineCount -= cursor8AquamarinePrice;
        RareDropsCollected.yellowSapphireCount -= cursor8YellowSapphirePrice;

        cursor8ActiveDamage += cursor8ActiveDamageIncrement;
        cursor8PassiveDamage += cursor8PassiveDamageIncrement;
        cursor8CritChance += cursor8CritChanceIncrement;
        cursor8CritDamage += cursor8CritDamageIncrement;

        if (cursor8Equipped == 1) { activeDamageMultiplier = cursor8ActiveDamage; critChance = cursor8CritChance; critDamage = cursor8CritDamage; passiveDamageMultiplier = cursor8PassiveDamage; SetTopText(); }
        cursor8AquamarinePrice += 2;
        cursor8YellowSapphirePrice += 2;
        cursor8Level += 1;

        HoverSetStrings.boughtUpgrade = true;
        cursorsPriceChanged = true;
        cursor8Change = true;
    }

    #endregion

    #region Cursor9
    public static int cursor9PinkTourmalinePrice;
    public static float cursor9ActiveDamage;
    public static float cursor9ActiveDamageIncrement;
    public static float cursor9PassiveDamage;
    public static float cursor9PassiveDamageIncrement;
    public static int cursor9Level;
    public static int cursor9Equipped;

    public GameObject cursor9Button;
    public TextMeshProUGUI equippedTextCursor9;
    public TextMeshProUGUI cursor9ActiveDamagePercentText;
    public TextMeshProUGUI cursor9PassiveDamagePercentText;
    public TextMeshProUGUI cursor9CritDamagePercentText;
    public TextMeshProUGUI cursor9CritChancePercentText;
    public TextMeshProUGUI cursor9LevelText;
    public TextMeshProUGUI cursor9LevelHoverText;

    public TextMeshProUGUI cursor9PinkTourmalinePriceText;
    public void EquippCursor9()
    {
        currentlyEquippedText.text = Localization.cursor9Equipped;
        SetEquippedFalse();
        setCursorsZero();

        cursorEquippedChance = 7;

        equippedTextCursor9.text = Localization.equipped; equippedTextCursor9.color = Color.green;
        activeDamageMultiplier = cursor9ActiveDamage;
        passiveDamageMultiplier = cursor9PassiveDamage;

        Color newColor;
        ColorUtility.TryParseHtmlString(equippedColor, out newColor);
        cursorButtons[8].color = newColor;
        SetTopText();
        cursor9Equipped = 1;
    }

    public void UpgradeCursor9()
    {
        if (isCursorMax == true)
        {
            if (RareDropsCollected.pinkTourmalineCount < cursor9PinkTourmalinePrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.pinkTourmalineCount >= cursor9PinkTourmalinePrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.pinkTourmalineCount >= cursor9PinkTourmalinePrice)
            {
                Cursor9Variables();
            }
        }
        else
        {
            if (RareDropsCollected.pinkTourmalineCount < cursor9PinkTourmalinePrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.pinkTourmalineCount >= cursor9PinkTourmalinePrice)
            {
                Cursor9Variables();
                UpgradeSound();
            }
        }
    }

    public void Cursor9Variables()
    {
        Stats.cursorUpgraded += 1;
        RareDropsCollected.isGemCountUpdated = true;
        RareDropsCollected.pinkTourmalineCount -= cursor9PinkTourmalinePrice;

        cursor9ActiveDamage += cursor9ActiveDamageIncrement;
        cursor9PassiveDamage += cursor9PassiveDamageIncrement;

        if (cursor9Equipped == 1) { activeDamageMultiplier = cursor9ActiveDamage; passiveDamageMultiplier = cursor9PassiveDamage; SetTopText(); }
        cursor9PinkTourmalinePrice += 2;
        cursor9Level += 1;

        HoverSetStrings.boughtUpgrade = true;
        cursorsPriceChanged = true;
        cursor9Change = true;
    }
    #endregion

    #region Cursor10
    public static int cursor10AdventurinePrice;
    public static float cursor10PassiveDamage;
    public static float cursor10PassiveDamageIncrement;
    public static int cursor10Level;
    public static int cursor10Equipped;

    public GameObject cursor10Button;
    public TextMeshProUGUI equippedTextCursor10;
    public TextMeshProUGUI cursor10PassiveDamagePercentText, cursor10ActiveText, cursor10CritChanceText, cursor10CritDamageText;
    public TextMeshProUGUI cursor10LevelText;
    public TextMeshProUGUI cursor10LevelHoverText;

    public TextMeshProUGUI cursor10AdventurinePriceText;

    public void EquippCursor10()
    {
        currentlyEquippedText.text = Localization.cursor10Equipped;
        SetEquippedFalse();
        setCursorsZero();

        equippedTextCursor10.text = Localization.equipped; equippedTextCursor10.color = Color.green;
        passiveDamageMultiplier = cursor10PassiveDamage;

        Color newColor;
        ColorUtility.TryParseHtmlString(equippedColor, out newColor);
        cursorButtons[9].color = newColor;
        SetTopText();
        cursor10Equipped = 1;
    }

    public void UpgradeCursor10()
    {
        if (isCursorMax == true)
        {
            if (RareDropsCollected.AdventurineCount < cursor10AdventurinePrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.AdventurineCount >= cursor10AdventurinePrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.AdventurineCount >= cursor10AdventurinePrice)
            {
                Cursor10Variables();
            }
        }
        else
        {
            if (RareDropsCollected.AdventurineCount < cursor10AdventurinePrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.AdventurineCount >= cursor10AdventurinePrice)
            {
                Cursor10Variables();
                UpgradeSound();
            }
        }
    }

    public void Cursor10Variables()
    {
        Stats.cursorUpgraded += 1;
        RareDropsCollected.isGemCountUpdated = true;
        RareDropsCollected.AdventurineCount -= cursor10AdventurinePrice;

        cursor10PassiveDamage += cursor10PassiveDamageIncrement;

        if (cursor10Equipped == 1) { passiveDamageMultiplier = cursor10PassiveDamage; SetTopText(); }
        cursor10AdventurinePrice += 3;
        cursor10Level += 1;

        HoverSetStrings.boughtUpgrade = true;
        cursorsPriceChanged = true;
        cursor10Change = true;
    }
    #endregion

    #region Cursor11
    public static int cursor11AdventurinePrice;
    public static int cursor11PinkTourmalinePrice;
    public static float cursor11ActiveDamage;
    public static float cursor11ActiveDamageIncrement;
    public static float cursor11CritChance;
    public static float cursor11CritChanceIncrement;
    public static float cursor11CritDamage;
    public static float cursor11CritDamageIncrement;
    public static int cursor11Level;
    public static int cursor11Equipped;

    public GameObject cursor11Button;
    public TextMeshProUGUI equippedTextCursor11;
    public TextMeshProUGUI cursor11ActiveDamagePercentText;
    public TextMeshProUGUI cursor11CritChancePercentText;
    public TextMeshProUGUI cursor11CritDamagePercentText, cursor11PassiveText;
    public TextMeshProUGUI cursor11LevelText;
    public TextMeshProUGUI cursor11LevelHoverText;

    public TextMeshProUGUI cursor11AdventurinePriceText;
    public TextMeshProUGUI cursor11PinkTourmalinePriceText;

    public void EquippCursor11()
    {
        currentlyEquippedText.text = Localization.cursor11Equipped;
        SetEquippedFalse();
        setCursorsZero();

        equippedTextCursor11.text = Localization.equipped; equippedTextCursor11.color = Color.green;
        activeDamageMultiplier = cursor11ActiveDamage;
        critChance = cursor11CritChance;
        critDamage = cursor11CritDamage;

        Color newColor;
        ColorUtility.TryParseHtmlString(equippedColor, out newColor);
        cursorButtons[10].color = newColor;
        SetTopText();
        cursor11Equipped = 1;
    }

    public void UpgradeCursor11()
    {
        if (isCursorMax == true)
        {
            if (RareDropsCollected.AdventurineCount < cursor11AdventurinePrice || RareDropsCollected.pinkTourmalineCount < cursor11PinkTourmalinePrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.AdventurineCount >= cursor11AdventurinePrice && RareDropsCollected.pinkTourmalineCount >= cursor11PinkTourmalinePrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.AdventurineCount >= cursor11AdventurinePrice && RareDropsCollected.pinkTourmalineCount >= cursor11PinkTourmalinePrice)
            {
                Cursor11Variables();
            }
        }
        else
        {
            if (RareDropsCollected.AdventurineCount < cursor11AdventurinePrice || RareDropsCollected.pinkTourmalineCount < cursor11PinkTourmalinePrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.AdventurineCount >= cursor11AdventurinePrice && RareDropsCollected.pinkTourmalineCount >= cursor11PinkTourmalinePrice)
            {
                Cursor11Variables();
                UpgradeSound();
            }
        }
    }

    public void Cursor11Variables()
    {
        Stats.cursorUpgraded += 1;
        RareDropsCollected.isGemCountUpdated = true;
        RareDropsCollected.AdventurineCount -= cursor11AdventurinePrice;
        RareDropsCollected.pinkTourmalineCount -= cursor11PinkTourmalinePrice;

        cursor11ActiveDamage += cursor11ActiveDamageIncrement;
        cursor11CritChance += cursor11CritChanceIncrement;
        cursor11CritDamage += cursor11CritDamageIncrement;

        if (cursor11Equipped == 1) { activeDamageMultiplier = cursor11ActiveDamage; critChance = cursor11CritChance; critDamage = cursor11CritDamage; SetTopText(); }
        cursor11AdventurinePrice += 2;
        cursor11PinkTourmalinePrice += 2;
        cursor11Level += 1;

        HoverSetStrings.boughtUpgrade = true;
        cursorsPriceChanged = true;
        cursor11Change = true;
    }
    #endregion

    #region Cursor12
    public static int cursor12AdventurinePrice;
    public static int cursor12RedRubyPrice;
    public static float cursor12ActiveDamage;
    public static float cursor12ActiveDamageIncrement;
    public static float cursor12PassiveDamage;
    public static float cursor12PassiveDamageIncrement;
    public static float cursor12CritChance;
    public static float cursor12CritChanceIncrement;
    public static float cursor12CritDamage;
    public static float cursor12CritDamageIncrement;
    public static int cursor12Level;
    public static int cursor12Equipped;

    public GameObject cursor12Button;
    public TextMeshProUGUI equippedTextCursor12;
    public TextMeshProUGUI cursor12ActiveDamagePercentText;
    public TextMeshProUGUI cursor12PassiveDamagePercentText;
    public TextMeshProUGUI cursor12CritChancePercentText;
    public TextMeshProUGUI cursor12CritDamagePercentText;
    public TextMeshProUGUI cursor12LevelText;
    public TextMeshProUGUI cursor12LevelHoverText;

    public TextMeshProUGUI cursor12AdventurinePriceText;
    public TextMeshProUGUI cursor12RedRubyPriceText;

    public void EquippCursor12()
    {
        currentlyEquippedText.text = Localization.cursor12Equipped;
        SetEquippedFalse();
        setCursorsZero();

        cursorEquippedGoldIncrease = 0.15f;
        cursorEquippedXPIncrease = 0.15f;

        equippedTextCursor12.text = Localization.equipped; equippedTextCursor12.color = Color.green;
        activeDamageMultiplier = cursor12ActiveDamage;
        passiveDamageMultiplier = cursor12PassiveDamage;
        critChance = cursor12CritChance;
        critDamage = cursor12CritDamage;

        Color newColor;
        ColorUtility.TryParseHtmlString(equippedColor, out newColor);
        cursorButtons[11].color = newColor;
        SetTopText();
        cursor12Equipped = 1;
    }

    public void UpgradeCursor12()
    {
        if (isCursorMax == true)
        {
            if (RareDropsCollected.AdventurineCount < cursor12AdventurinePrice || RareDropsCollected.RedGemCount < cursor12RedRubyPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.AdventurineCount >= cursor12AdventurinePrice && RareDropsCollected.RedGemCount >= cursor12RedRubyPrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.AdventurineCount >= cursor12AdventurinePrice && RareDropsCollected.RedGemCount >= cursor12RedRubyPrice)
            {
                Cursor12Variables();
            }
        }
        else
        {
            if (RareDropsCollected.AdventurineCount < cursor12AdventurinePrice || RareDropsCollected.RedGemCount < cursor12RedRubyPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.AdventurineCount >= cursor12AdventurinePrice && RareDropsCollected.RedGemCount >= cursor12RedRubyPrice)
            {
                Cursor12Variables();
                UpgradeSound();
            }
        }
    }

    public void Cursor12Variables()
    {
        Stats.cursorUpgraded += 1;
        RareDropsCollected.isGemCountUpdated = true;
        RareDropsCollected.AdventurineCount -= cursor12AdventurinePrice;
        RareDropsCollected.RedGemCount -= cursor12RedRubyPrice;

        cursor12ActiveDamage += cursor12ActiveDamageIncrement;
        cursor12PassiveDamage += cursor12PassiveDamageIncrement;
        cursor12CritChance += cursor12CritChanceIncrement;
        cursor12CritDamage += cursor12CritDamageIncrement;

        if (cursor12Equipped == 1) { activeDamageMultiplier = cursor12ActiveDamage; critChance = cursor12CritChance; critDamage = cursor12CritDamage; passiveDamageMultiplier = cursor12PassiveDamage; SetTopText(); }
        cursor12AdventurinePrice += 2;
        cursor12RedRubyPrice += 2;
        cursor12Level += 1;

        HoverSetStrings.boughtUpgrade = true;
        cursorsPriceChanged = true;
        cursor12Change = true;
    }
    #endregion

    #region Cursor13
    public static int cursor13DiamondPrice;
    public static int cursor13GrandideritePrice;
    public static float cursor13ActiveDamage;
    public static float cursor13ActiveDamageIncrement;
    public static float cursor13PassiveDamage;
    public static float cursor13PassiveDamageIncrement;
    public static float cursor13CritChance;
    public static float cursor13CritChanceIncrement;
    public static float cursor13CritDamage;
    public static float cursor13CritDamageIncrement;
    public static int cursor13Level;
    public static int cursor13Equipped;

    public GameObject cursor13Button;
    public TextMeshProUGUI equippedTextCursor13;
    public TextMeshProUGUI cursor13ActiveDamagePercentText;
    public TextMeshProUGUI cursor13PassiveDamagePercentText;
    public TextMeshProUGUI cursor13CritChancePercentText;
    public TextMeshProUGUI cursor13CritDamagePercentText;
    public TextMeshProUGUI cursor13LevelText;
    public TextMeshProUGUI cursor13LevelHoverText;

    public TextMeshProUGUI cursor13DiamondPriceText;
    public TextMeshProUGUI cursor13GrandideritePriceText;
    public void EquippCursor13()
    {
        currentlyEquippedText.text = Localization.cursor13Equipped;
        SetEquippedFalse();
        setCursorsZero();

        equippedTextCursor13.text = Localization.equipped; equippedTextCursor13.color = Color.green;
        activeDamageMultiplier = cursor13ActiveDamage;
        passiveDamageMultiplier = cursor13PassiveDamage;
        critChance = cursor13CritChance;
        critDamage = cursor13CritDamage;

        Color newColor;
        ColorUtility.TryParseHtmlString(equippedColor, out newColor);
        cursorButtons[12].color = newColor;
        SetTopText();
        cursor13Equipped = 1;
    }

    public void UpgradeCursor13()
    {
        if (isCursorMax == true)
        {
            if (RareDropsCollected.diamondCount < cursor13DiamondPrice || RareDropsCollected.grandidieriteCount < cursor13GrandideritePrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.diamondCount >= cursor13DiamondPrice && RareDropsCollected.grandidieriteCount >= cursor13GrandideritePrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.diamondCount >= cursor13DiamondPrice && RareDropsCollected.grandidieriteCount >= cursor13GrandideritePrice)
            {
                Cursor13Variables();
            }
        }
        else
        {
            if (RareDropsCollected.diamondCount < cursor13DiamondPrice || RareDropsCollected.grandidieriteCount < cursor13GrandideritePrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.diamondCount >= cursor13DiamondPrice && RareDropsCollected.grandidieriteCount >= cursor13GrandideritePrice)
            {
                Cursor13Variables();
                UpgradeSound();
            }
        }

    }

    public void Cursor13Variables()
    {
        Stats.cursorUpgraded += 1;
        RareDropsCollected.isGemCountUpdated = true;
        RareDropsCollected.diamondCount -= cursor13DiamondPrice;
        RareDropsCollected.grandidieriteCount -= cursor13GrandideritePrice;

        cursor13ActiveDamage += cursor13ActiveDamageIncrement;
        cursor13PassiveDamage += cursor13PassiveDamageIncrement;
        cursor13CritChance += cursor13CritChanceIncrement;
        cursor13CritDamage += cursor13CritDamageIncrement;

        if (cursor13Equipped == 1) { activeDamageMultiplier = cursor13ActiveDamage; critChance = cursor13CritChance; critDamage = cursor13CritDamage; passiveDamageMultiplier = cursor13PassiveDamage; SetTopText(); }
        cursor13DiamondPrice += 3;
        cursor13GrandideritePrice += 3;
        cursor13Level += 1;

        HoverSetStrings.boughtUpgrade = true;
        cursorsPriceChanged = true;
        cursor13Change = true;
    }
    #endregion

    #region Cursor14
    public static int cursor14VioletCrystalPrice;
    public static int cursor14GrandideritePrice;
    public static float cursor14ActiveDamage;
    public static float cursor14ActiveDamageIncrement;
    public static float cursor14PassiveDamage;
    public static float cursor14PassiveDamageIncrement;
    public static float cursor14CritChance;
    public static float cursor14CritChanceIncrement;
    public static float cursor14CritDamage;
    public static float cursor14CritDamageIncrement;
    public static int cursor14Level;
    public static int cursor14Equipped;

    public GameObject cursor14Button;
    public TextMeshProUGUI equippedTextCursor14;
    public TextMeshProUGUI cursor14ActiveDamagePercentText;
    public TextMeshProUGUI cursor14PassiveDamagePercentText;
    public TextMeshProUGUI cursor14CritChancePercentText;
    public TextMeshProUGUI cursor14CritDamagePercentText;
    public TextMeshProUGUI cursor14LevelText;
    public TextMeshProUGUI cursor14LevelHoverText;

    public TextMeshProUGUI cursor14VioletCrystalPriceText;
    public TextMeshProUGUI cursor14GrandideritePriceText;

    public void EquippCursor14()
    {
        currentlyEquippedText.text = Localization.cursor14Equipped;
        SetEquippedFalse();
        setCursorsZero();

        cursorEquippedChance = 25;

        equippedTextCursor14.text = Localization.equipped; equippedTextCursor14.color = Color.green;
        activeDamageMultiplier = cursor14ActiveDamage;
        passiveDamageMultiplier = cursor14PassiveDamage;
        critChance = cursor14CritChance;
        critDamage = cursor14CritDamage;

        Color newColor;
        ColorUtility.TryParseHtmlString(equippedColor, out newColor);
        cursorButtons[13].color = newColor;
        SetTopText();
        cursor14Equipped = 1;
    }

    public void UpgradeCursor14()
    {
        if (isCursorMax == true)
        {
            if (RareDropsCollected.violetCrystalCount < cursor14VioletCrystalPrice || RareDropsCollected.grandidieriteCount < cursor14GrandideritePrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.violetCrystalCount >= cursor14VioletCrystalPrice && RareDropsCollected.grandidieriteCount >= cursor14GrandideritePrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.violetCrystalCount >= cursor14VioletCrystalPrice && RareDropsCollected.grandidieriteCount >= cursor14GrandideritePrice)
            {
                Cursor14Variables();
            }
        }
        else
        {
            if (RareDropsCollected.violetCrystalCount < cursor14VioletCrystalPrice || RareDropsCollected.grandidieriteCount < cursor14GrandideritePrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.violetCrystalCount >= cursor14VioletCrystalPrice && RareDropsCollected.grandidieriteCount >= cursor14GrandideritePrice)
            {
                Cursor14Variables();
                UpgradeSound();
            }
        }
    }

    public void Cursor14Variables()
    {
        Stats.cursorUpgraded += 1;
        RareDropsCollected.isGemCountUpdated = true;
        RareDropsCollected.violetCrystalCount -= cursor14VioletCrystalPrice;
        RareDropsCollected.grandidieriteCount -= cursor14GrandideritePrice;

        cursor14ActiveDamage += cursor14ActiveDamageIncrement;
        cursor14PassiveDamage += cursor14PassiveDamageIncrement;
        cursor14CritChance += cursor14CritChanceIncrement;
        cursor14CritDamage += cursor14CritDamageIncrement;

        if (cursor14Equipped == 1) { activeDamageMultiplier = cursor14ActiveDamage; critChance = cursor14CritChance; critDamage = cursor14CritDamage; passiveDamageMultiplier = cursor14PassiveDamage; SetTopText(); }
        cursor14VioletCrystalPrice += 4;
        cursor14GrandideritePrice += 4;
        cursor14Level += 1;

        HoverSetStrings.boughtUpgrade = true;
        cursorsPriceChanged = true;
        cursor14Change = true;
    }
    #endregion

    #region Cursor15
    public static int cursor15AkoyaPeralPrice;
    public static int cursor15PurpleRupeePrice;
    public static int cursor15EmeraldPrice;
    public static float cursor15ActiveDamage;
    public static float cursor15ActiveDamageIncrement;
    public static float cursor15PassiveDamage;
    public static float cursor15PassiveDamageIncrement;
    public static float cursor15CritChance;
    public static float cursor15CritChanceIncrement;
    public static float cursor15CritDamage;
    public static float cursor15CritDamageIncrement;
    public static int cursor15Level;
    public static int cursor15Equipped;

    public GameObject cursor15Button;
    public TextMeshProUGUI equippedTextCursor15;
    public TextMeshProUGUI cursor15ActiveDamagePercentText;
    public TextMeshProUGUI cursor15PassiveDamagePercentText;
    public TextMeshProUGUI cursor15CritChancePercentText;
    public TextMeshProUGUI cursor15CritDamagePercentText;
    public TextMeshProUGUI cursor15LevelText;
    public TextMeshProUGUI cursor15LevelHoverText;

    public TextMeshProUGUI cursor15AkoyaPeralPriceText;
    public TextMeshProUGUI cursor15PurpleRupeePriceText;
    public TextMeshProUGUI cursor15EmeraldPriceText;
    public void EquippCursor15()
    {
        currentlyEquippedText.text = Localization.cursor15Equipped;
        SetEquippedFalse();
        setCursorsZero();

        equippedTextCursor15.text = Localization.equipped; equippedTextCursor15.color = Color.green;
        activeDamageMultiplier = cursor15ActiveDamage;
        passiveDamageMultiplier = cursor15PassiveDamage;
        critChance = cursor15CritChance;
        critDamage = cursor15CritDamage;

        Color newColor;
        ColorUtility.TryParseHtmlString(equippedColor, out newColor);
        cursorButtons[14].color = newColor;
        SetTopText();
        cursor15Equipped = 1;
    }

    public void UpgradeCursor15()
    {
        if (isCursorMax == true)
        {
            if (RareDropsCollected.akoyaPearlCount < cursor15AkoyaPeralPrice || RareDropsCollected.purpleRupeeCount < cursor15PurpleRupeePrice || RareDropsCollected.emeraldCount < cursor15EmeraldPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.akoyaPearlCount >= cursor15AkoyaPeralPrice && RareDropsCollected.purpleRupeeCount >= cursor15PurpleRupeePrice && RareDropsCollected.emeraldCount >= cursor15EmeraldPrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.akoyaPearlCount >= cursor15AkoyaPeralPrice && RareDropsCollected.purpleRupeeCount >= cursor15PurpleRupeePrice && RareDropsCollected.emeraldCount >= cursor15EmeraldPrice)
            {
                Cursor15Variables();
            }
        }
        else
        {
            if (RareDropsCollected.akoyaPearlCount < cursor15AkoyaPeralPrice || RareDropsCollected.purpleRupeeCount < cursor15PurpleRupeePrice || RareDropsCollected.emeraldCount < cursor15EmeraldPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.akoyaPearlCount >= cursor15AkoyaPeralPrice && RareDropsCollected.purpleRupeeCount >= cursor15PurpleRupeePrice && RareDropsCollected.emeraldCount >= cursor15EmeraldPrice)
            {
                Cursor15Variables();
                UpgradeSound();
            }
        }
    }

    public void Cursor15Variables()
    {
        Stats.cursorUpgraded += 1;
        RareDropsCollected.isGemCountUpdated = true;
        RareDropsCollected.akoyaPearlCount -= cursor15AkoyaPeralPrice;
        RareDropsCollected.purpleRupeeCount -= cursor15PurpleRupeePrice;
        RareDropsCollected.emeraldCount -= cursor15EmeraldPrice;

        cursor15ActiveDamage += cursor15ActiveDamageIncrement;
        cursor15PassiveDamage += cursor15PassiveDamageIncrement;
        cursor15CritChance += cursor15CritChanceIncrement;
        cursor15CritDamage += cursor15CritDamageIncrement;

        if (cursor15Equipped == 1) { activeDamageMultiplier = cursor15ActiveDamage; critChance = cursor15CritChance; critDamage = cursor15CritDamage; passiveDamageMultiplier = cursor15PassiveDamage; SetTopText(); }
        cursor15AkoyaPeralPrice += 4;
        cursor15PurpleRupeePrice += 4;
        cursor15EmeraldPrice += 4;

        cursor15Level += 1;

        HoverSetStrings.boughtUpgrade = true;
        cursorsPriceChanged = true;
        cursor15Change = true;
    }
    #endregion

    #region Cursor16
    public static int cursor16GreenDiamondPrice;
    public static int cursor16FireOpalPrice;
    public static int cursor16GemSilicaPrice;
    public static float cursor16ActiveDamage;
    public static float cursor16ActiveDamageIncrement;
    public static float cursor16PassiveDamage;
    public static float cursor16PassiveDamageIncrement;
    public static float cursor16CritChance;
    public static float cursor16CritChanceIncrement;
    public static float cursor16CritDamage;
    public static float cursor16CritDamageIncrement;
    public static int cursor16Level;
    public static int cursor16Equipped;

    public GameObject cursor16Button;
    public TextMeshProUGUI equippedTextCursor16;
    public TextMeshProUGUI cursor16ActiveDamagePercentText;
    public TextMeshProUGUI cursor16PassiveDamagePercentText;
    public TextMeshProUGUI cursor16CritChancePercentText;
    public TextMeshProUGUI cursor16CritDamagePercentText;
    public TextMeshProUGUI cursor16LevelText;
    public TextMeshProUGUI cursor16LevelHoverText;

    public TextMeshProUGUI cursor16GreenDiamondPriceText;
    public TextMeshProUGUI cursor16FireOpalPriceText;
    public TextMeshProUGUI cursor16GemSilicaPriceText;

    public void EquippCursor16()
    {
        currentlyEquippedText.text = Localization.cursor16Equipped;
        SetEquippedFalse();
        setCursorsZero();

        equippedTextCursor16.text = Localization.equipped; equippedTextCursor16.color = Color.green;
        activeDamageMultiplier = cursor16ActiveDamage;
        passiveDamageMultiplier = cursor16PassiveDamage;
        critChance = cursor16CritChance;
        critDamage = cursor16CritDamage;

        Color newColor;
        ColorUtility.TryParseHtmlString(equippedColor, out newColor);
        cursorButtons[15].color = newColor;
        SetTopText();
        cursor16Equipped = 1;
    }

    public void UpgradeCursor16()
    {
        if (isCursorMax == true)
        {
            if (RareDropsCollected.greenDiamondCount < cursor16GreenDiamondPrice || RareDropsCollected.fireOpalCount < cursor16FireOpalPrice || RareDropsCollected.gemSilicaCount < cursor16GemSilicaPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.greenDiamondCount >= cursor16GreenDiamondPrice && RareDropsCollected.fireOpalCount >= cursor16FireOpalPrice && RareDropsCollected.gemSilicaCount >= cursor16GemSilicaPrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.greenDiamondCount >= cursor16GreenDiamondPrice && RareDropsCollected.fireOpalCount >= cursor16FireOpalPrice && RareDropsCollected.gemSilicaCount >= cursor16GemSilicaPrice)
            {
                Cursor16Variables();
            }
        }
        else
        {
            if (RareDropsCollected.greenDiamondCount < cursor16GreenDiamondPrice || RareDropsCollected.fireOpalCount < cursor16FireOpalPrice || RareDropsCollected.gemSilicaCount < cursor16GemSilicaPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.greenDiamondCount >= cursor16GreenDiamondPrice && RareDropsCollected.fireOpalCount >= cursor16FireOpalPrice && RareDropsCollected.gemSilicaCount >= cursor16GemSilicaPrice)
            {
                Cursor16Variables();
                UpgradeSound();
            }
        }
    }

    public void Cursor16Variables()
    {
        Stats.cursorUpgraded += 1;
        RareDropsCollected.isGemCountUpdated = true;
        RareDropsCollected.greenDiamondCount -= cursor16GreenDiamondPrice;
        RareDropsCollected.fireOpalCount -= cursor16FireOpalPrice;
        RareDropsCollected.gemSilicaCount -= cursor16GemSilicaPrice;

        cursor16ActiveDamage += cursor16ActiveDamageIncrement;
        cursor16PassiveDamage += cursor16PassiveDamageIncrement;
        cursor16CritChance += cursor16CritChanceIncrement;
        cursor16CritDamage += cursor16CritDamageIncrement;

        if (cursor16Equipped == 1) { activeDamageMultiplier = cursor16ActiveDamage; critChance = cursor16CritChance; critDamage = cursor16CritDamage; passiveDamageMultiplier = cursor16PassiveDamage; SetTopText(); }
        cursor16GreenDiamondPrice += 4;
        cursor16FireOpalPrice += 4;
        cursor16GemSilicaPrice += 4;

        cursor16Level += 1;

        HoverSetStrings.boughtUpgrade = true;
        cursorsPriceChanged = true;
        cursor16Change = true;
    }

    #endregion

    #region Cursor17
    public static int cursor17PinkPlortPrice;
    public static int cursor17GoldenSeaPEarlPrice;
    public static int cursor17KyanitePrice;
    public static float cursor17ActiveDamage;
    public static float cursor17ActiveDamageIncrement;
    public static float cursor17PassiveDamage;
    public static float cursor17PassiveDamageIncrement;
    public static float cursor17CritChance;
    public static float cursor17CritChanceIncrement;
    public static float cursor17CritDamage;
    public static float cursor17CritDamageIncrement;
    public static int cursor17Level;
    public static int cursor17Equipped;

    public GameObject cursor17Button;
    public TextMeshProUGUI equippedTextCursor17;
    public TextMeshProUGUI cursor17ActiveDamagePercentText;
    public TextMeshProUGUI cursor17PassiveDamagePercentText;
    public TextMeshProUGUI cursor17CritChancePercentText;
    public TextMeshProUGUI cursor17CritDamagePercentText;
    public TextMeshProUGUI cursor17LevelText;
    public TextMeshProUGUI cursor17LevelHoverText;

    public TextMeshProUGUI cursor17PinkPlortPriceText;
    public TextMeshProUGUI cursor17GoldenSeaPEarlPriceText;
    public TextMeshProUGUI cursor17KyanitePriceText;

    public void EquippCursor17()
    {
        currentlyEquippedText.text = Localization.cursor17Equipped;
        SetEquippedFalse();
        setCursorsZero();

        cursorEquippedXPIncrease = 0.25f;
        cursorEquippedChance = 100;

        equippedTextCursor17.text = Localization.equipped; equippedTextCursor17.color = Color.green;
        activeDamageMultiplier = cursor17ActiveDamage;
        passiveDamageMultiplier = cursor17PassiveDamage;
        critChance = cursor17CritChance;
        critDamage = cursor17CritDamage;

        Color newColor;
        ColorUtility.TryParseHtmlString(equippedColor, out newColor);
        cursorButtons[16].color = newColor;
        SetTopText();
        cursor17Equipped = 1;
    }

    public void UpgradeCursor17()
    {
        if (isCursorMax == true)
        {
            if (RareDropsCollected.pinkPlostCount < cursor17PinkPlortPrice || RareDropsCollected.goldeSeaPearlCount < cursor17GoldenSeaPEarlPrice || RareDropsCollected.kyaniteCount < cursor17KyanitePrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.pinkPlostCount >= cursor17PinkPlortPrice && RareDropsCollected.goldeSeaPearlCount >= cursor17GoldenSeaPEarlPrice && RareDropsCollected.kyaniteCount >= cursor17KyanitePrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.pinkPlostCount >= cursor17PinkPlortPrice && RareDropsCollected.goldeSeaPearlCount >= cursor17GoldenSeaPEarlPrice && RareDropsCollected.kyaniteCount >= cursor17KyanitePrice)
            {
                Cursor17Variables();
            }
        }
        else
        {
            if (RareDropsCollected.pinkPlostCount < cursor17PinkPlortPrice || RareDropsCollected.goldeSeaPearlCount < cursor17GoldenSeaPEarlPrice || RareDropsCollected.kyaniteCount < cursor17KyanitePrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.pinkPlostCount >= cursor17PinkPlortPrice && RareDropsCollected.goldeSeaPearlCount >= cursor17GoldenSeaPEarlPrice && RareDropsCollected.kyaniteCount >= cursor17KyanitePrice)
            {
                Cursor17Variables();
                UpgradeSound();
            }
        }
    }

    public void Cursor17Variables()
    {
        Stats.cursorUpgraded += 1;
        RareDropsCollected.isGemCountUpdated = true;
        RareDropsCollected.pinkPlostCount -= cursor17PinkPlortPrice;
        RareDropsCollected.goldeSeaPearlCount -= cursor17GoldenSeaPEarlPrice;
        RareDropsCollected.kyaniteCount -= cursor17KyanitePrice;

        cursor17ActiveDamage += cursor17ActiveDamageIncrement;
        cursor17PassiveDamage += cursor17PassiveDamageIncrement;
        cursor17CritChance += cursor17CritChanceIncrement;
        cursor17CritDamage += cursor17CritDamageIncrement;

        if (cursor17Equipped == 1) { activeDamageMultiplier = cursor17ActiveDamage; critChance = cursor17CritChance; critDamage = cursor17CritDamage; passiveDamageMultiplier = cursor17PassiveDamage; SetTopText(); }
        cursor17PinkPlortPrice += 5;
        cursor17GoldenSeaPEarlPrice += 5;
        cursor17KyanitePrice += 5;
        cursor17Level += 1;

        HoverSetStrings.boughtUpgrade = true;
        cursorsPriceChanged = true;
        cursor17Change = true;
    }
    #endregion

    #region Cursor18
    public static int cursor18BlackOpalPrice;
    public static int cursor18PainitePrice;
    public static int cursor18TanzanitePrice;
    public static float cursor18ActiveDamage;
    public static float cursor18ActiveDamageIncrement;
    public static float cursor18PassiveDamage;
    public static float cursor18PassiveDamageIncrement;
    public static float cursor18CritChance;
    public static float cursor18CritChanceIncrement;
    public static float cursor18CritDamage;
    public static float cursor18CritDamageIncrement;
    public static int cursor18Level;
    public static int cursor18Equipped;

    public GameObject cursor18Button;
    public TextMeshProUGUI equippedTextCursor18;
    public TextMeshProUGUI cursor18ActiveDamagePercentText;
    public TextMeshProUGUI cursor18PassiveDamagePercentText;
    public TextMeshProUGUI cursor18CritChancePercentText;
    public TextMeshProUGUI cursor18CritDamagePercentText;
    public TextMeshProUGUI cursor18LevelText;
    public TextMeshProUGUI cursor18LevelHoverText;

    public TextMeshProUGUI cursor18BlackOpalPriceText;
    public TextMeshProUGUI cursor18PainitePriceText;
    public TextMeshProUGUI cursor18TanzanitePriceText;

    public void EquippCursor18()
    {
        currentlyEquippedText.text = Localization.cursor18Equipped;
        SetEquippedFalse();
        setCursorsZero();

        cursorEquippedGoldIncrease = 1;
        cursorEquippedXPIncrease = 0.40f;
        cursorEquippedChance = 100;

        equippedTextCursor18.text = Localization.equipped; equippedTextCursor18.color = Color.green;
        activeDamageMultiplier = cursor18ActiveDamage;
        passiveDamageMultiplier = cursor18PassiveDamage;
        critChance = cursor18CritChance;
        critDamage = cursor18CritDamage;

        Color newColor;
        ColorUtility.TryParseHtmlString(equippedColor, out newColor);
        cursorButtons[17].color = newColor;
        SetTopText();
        cursor18Equipped = 1;
    }

    public void UpgradeCursor18()
    {
        if (isCursorMax == true)
        {
            if (RareDropsCollected.blackOpalCount < cursor18BlackOpalPrice || RareDropsCollected.painiteCount < cursor18PainitePrice || RareDropsCollected.TanzaniteCount < cursor18TanzanitePrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.blackOpalCount >= cursor18BlackOpalPrice && RareDropsCollected.painiteCount >= cursor18PainitePrice && RareDropsCollected.TanzaniteCount >= cursor18TanzanitePrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.blackOpalCount >= cursor18BlackOpalPrice && RareDropsCollected.painiteCount >= cursor18PainitePrice && RareDropsCollected.TanzaniteCount >= cursor18TanzanitePrice)
            {
                Cursor18Variables();
            }
        }
        else
        {
            if (RareDropsCollected.blackOpalCount < cursor18BlackOpalPrice || RareDropsCollected.painiteCount < cursor18PainitePrice || RareDropsCollected.TanzaniteCount < cursor18TanzanitePrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.blackOpalCount >= cursor18BlackOpalPrice && RareDropsCollected.painiteCount >= cursor18PainitePrice && RareDropsCollected.TanzaniteCount >= cursor18TanzanitePrice)
            {
                Cursor18Variables();
                UpgradeSound();
            }
        }
    }

    public void Cursor18Variables()
    {
        Stats.cursorUpgraded += 1;
        RareDropsCollected.isGemCountUpdated = true;
        RareDropsCollected.blackOpalCount -= cursor18BlackOpalPrice;
        RareDropsCollected.painiteCount -= cursor18PainitePrice;
        RareDropsCollected.TanzaniteCount -= cursor18TanzanitePrice;

        cursor18ActiveDamage += cursor18ActiveDamageIncrement;
        cursor18PassiveDamage += cursor18PassiveDamageIncrement;
        cursor18CritChance += cursor18CritChanceIncrement;
        cursor18CritDamage += cursor18CritDamageIncrement;

        if (cursor18Equipped == 1) { activeDamageMultiplier = cursor18ActiveDamage; critChance = cursor18CritChance; critDamage = cursor18CritDamage; passiveDamageMultiplier = cursor18PassiveDamage; SetTopText(); }
        cursor18BlackOpalPrice += 5;
        cursor18PainitePrice += 5;
        cursor18TanzanitePrice += 5;

        cursor18Level += 1;

        HoverSetStrings.boughtUpgrade = true;
        cursorsPriceChanged = true;
        cursor18Change = true;
    }


    #endregion

    #region Cursor19
    public static int cursor19AstraliumPrice;
    public static int cursor19ElysiumPrismPrice;
    public static int cursor19AerthfireOpalPrice;
    public static float cursor19ActiveDamage;
    public static float cursor19ActiveDamageIncrement;
    public static float cursor19PassiveDamage;
    public static float cursor19PassiveDamageIncrement;
    public static float cursor19CritChance;
    public static float cursor19CritChanceIncrement;
    public static float cursor19CritDamage;
    public static float cursor19CritDamageIncrement;
    public static int cursor19Level;
    public static int cursor19Equipped;

    public GameObject cursor19Button;
    public TextMeshProUGUI equippedTextCursor19;
    public TextMeshProUGUI cursor19ActiveDamagePercentText;
    public TextMeshProUGUI cursor19PassiveDamagePercentText;
    public TextMeshProUGUI cursor19CritChancePercentText;
    public TextMeshProUGUI cursor19CritDamagePercentText;
    public TextMeshProUGUI cursor19LevelText;
    public TextMeshProUGUI cursor19LevelHoverText;

    public TextMeshProUGUI cursor19AstraliumPriceText;
    public TextMeshProUGUI cursor19ElysiumPrismPriceText;
    public TextMeshProUGUI cursor19AerthfireOpalPriceText;

    public void EquippCursor19()
    {
        currentlyEquippedText.text = Localization.cursor19Equipped;
        SetEquippedFalse();
        setCursorsZero();

        equippedTextCursor19.text = Localization.equipped; equippedTextCursor19.color = Color.green;
        activeDamageMultiplier = cursor19ActiveDamage;
        passiveDamageMultiplier = cursor19PassiveDamage;
        critChance = cursor19CritChance;
        critDamage = cursor19CritDamage;

        Color newColor;
        ColorUtility.TryParseHtmlString(equippedColor, out newColor);
        cursorButtons[18].color = newColor;
        SetTopText();
        cursor19Equipped = 1;
    }

    public void UpgradeCursor19()
    {
        if (isCursorMax == true)
        {
            if (RareDropsCollected.astraliumCount < cursor19AstraliumPrice || RareDropsCollected.elysiumPrismCount < cursor19ElysiumPrismPrice || RareDropsCollected.aetherfireOpalCount < cursor19AerthfireOpalPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.astraliumCount >= cursor19AstraliumPrice && RareDropsCollected.elysiumPrismCount >= cursor19ElysiumPrismPrice && RareDropsCollected.aetherfireOpalCount >= cursor19AerthfireOpalPrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.astraliumCount >= cursor19AstraliumPrice && RareDropsCollected.elysiumPrismCount >= cursor19ElysiumPrismPrice && RareDropsCollected.aetherfireOpalCount >= cursor19AerthfireOpalPrice)
            {
                Cursor19Variables();
            }
        }
        else
        {
            if (RareDropsCollected.astraliumCount < cursor19AstraliumPrice || RareDropsCollected.elysiumPrismCount < cursor19ElysiumPrismPrice || RareDropsCollected.aetherfireOpalCount < cursor19AerthfireOpalPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.astraliumCount >= cursor19AstraliumPrice && RareDropsCollected.elysiumPrismCount >= cursor19ElysiumPrismPrice && RareDropsCollected.aetherfireOpalCount >= cursor19AerthfireOpalPrice)
            {
                Cursor19Variables();
                UpgradeSound();
            }
        }
    }

    public void Cursor19Variables()
    {
        Stats.cursorUpgraded += 1;
        RareDropsCollected.isGemCountUpdated = true;
        RareDropsCollected.astraliumCount -= cursor19AstraliumPrice;
        RareDropsCollected.elysiumPrismCount -= cursor19ElysiumPrismPrice;
        RareDropsCollected.aetherfireOpalCount -= cursor19AerthfireOpalPrice;

        cursor19ActiveDamage += cursor19ActiveDamageIncrement;
        cursor19PassiveDamage += cursor19PassiveDamageIncrement;
        cursor19CritChance += cursor19CritChanceIncrement;
        cursor19CritDamage += cursor19CritDamageIncrement;

        if (cursor19Equipped == 1) { activeDamageMultiplier = cursor19ActiveDamage; critChance = cursor19CritChance; critDamage = cursor19CritDamage; passiveDamageMultiplier = cursor19PassiveDamage; SetTopText(); }
        cursor19AstraliumPrice += 8;
        cursor19ElysiumPrismPrice += 8;
        cursor19AerthfireOpalPrice += 8;

        cursor19Level += 1;

        HoverSetStrings.boughtUpgrade = true;
        cursorsPriceChanged = true;
        cursor19Change = true;
    }
    #endregion

    #region Cursor20
    public static int cursor20EldritchStarStonePrice;
    public static int cursor20ChronolithShardPrice;
    public static int cursor20SideriumEssencePrice;
    public static float cursor20ActiveDamage;
    public static float cursor20ActiveDamageIncrement;
    public static float cursor20PassiveDamage;
    public static float cursor20PassiveDamageIncrement;
    public static float cursor20CritChance;
    public static float cursor20CritChanceIncrement;
    public static float cursor20CritDamage;
    public static float cursor20CritDamageIncrement;
    public static int cursor20Level;
    public static int cursor20Equipped;

    public GameObject cursor20Button;
    public TextMeshProUGUI equippedTextCursor20;
    public TextMeshProUGUI cursor20ActiveDamagePercentText;
    public TextMeshProUGUI cursor20PassiveDamagePercentText;
    public TextMeshProUGUI cursor20CritChancePercentText;
    public TextMeshProUGUI cursor20CritDamagePercentText;
    public TextMeshProUGUI cursor20LevelText;
    public TextMeshProUGUI cursor20LevelHoverText;

    public TextMeshProUGUI cursor20EldritchStarStonePriceText;
    public TextMeshProUGUI cursor20ChronolithShardPriceText;
    public TextMeshProUGUI cursor20SideriumEssencePriceText;

    public void EquippCursor20()
    {
        currentlyEquippedText.text = Localization.cursor20Equipped;
        SetEquippedFalse();
        setCursorsZero();

        equippedTextCursor20.text = Localization.equipped; equippedTextCursor20.color = Color.green;
        activeDamageMultiplier = cursor20ActiveDamage;
        passiveDamageMultiplier = cursor20PassiveDamage;
        critChance = cursor20CritChance;
        critDamage = cursor20CritDamage;

        Color newColor;
        ColorUtility.TryParseHtmlString(equippedColor, out newColor);
        cursorButtons[19].color = newColor;
        SetTopText();
        cursor20Equipped = 1;
    }

    public void UpgradeCursor20()
    {
        if (isCursorMax == true)
        {
            if (RareDropsCollected.eldritchStarstoneCount < cursor20EldritchStarStonePrice || RareDropsCollected.chronolithShardCount < cursor20ChronolithShardPrice || RareDropsCollected.sideriumEssenceCount < cursor20SideriumEssencePrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.eldritchStarstoneCount >= cursor20EldritchStarStonePrice && RareDropsCollected.chronolithShardCount >= cursor20ChronolithShardPrice && RareDropsCollected.sideriumEssenceCount >= cursor20SideriumEssencePrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.eldritchStarstoneCount >= cursor20EldritchStarStonePrice && RareDropsCollected.chronolithShardCount >= cursor20ChronolithShardPrice && RareDropsCollected.sideriumEssenceCount >= cursor20SideriumEssencePrice)
            {
                Cursor20Variables();
            }
        }
        else
        {
            if (RareDropsCollected.eldritchStarstoneCount < cursor20EldritchStarStonePrice || RareDropsCollected.chronolithShardCount < cursor20ChronolithShardPrice || RareDropsCollected.sideriumEssenceCount < cursor20SideriumEssencePrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.eldritchStarstoneCount >= cursor20EldritchStarStonePrice && RareDropsCollected.chronolithShardCount >= cursor20ChronolithShardPrice && RareDropsCollected.sideriumEssenceCount >= cursor20SideriumEssencePrice)
            {
                Cursor20Variables();
                UpgradeSound();
            }
        }

    }

    public void Cursor20Variables()
    {
        Stats.cursorUpgraded += 1;
        RareDropsCollected.isGemCountUpdated = true;
        RareDropsCollected.eldritchStarstoneCount -= cursor20EldritchStarStonePrice;
        RareDropsCollected.chronolithShardCount -= cursor20ChronolithShardPrice;
        RareDropsCollected.sideriumEssenceCount -= cursor20SideriumEssencePrice;

        cursor20ActiveDamage += cursor20ActiveDamageIncrement;
        cursor20PassiveDamage += cursor20PassiveDamageIncrement;
        cursor20CritChance += cursor20CritChanceIncrement;
        cursor20CritDamage += cursor20CritDamageIncrement;

        if (cursor20Equipped == 1) { activeDamageMultiplier = cursor20ActiveDamage; critChance = cursor20CritChance; critDamage = cursor20CritDamage; passiveDamageMultiplier = cursor20PassiveDamage; SetTopText(); }
        cursor20EldritchStarStonePrice += 10;
        cursor20ChronolithShardPrice += 10;
        cursor20SideriumEssencePrice += 10;

        cursor20Level += 1;

        HoverSetStrings.boughtUpgrade = true;
        cursorsPriceChanged = true;
        cursor20Change = true;
    }
    #endregion

    #region Cursor21
    public static int cursor21QuasaritePrice;
    public static int cursor21RadiantNovaStonePrice;
    public static int cursor21SoluniumShardPrice;
    public static float cursor21ActiveDamage;
    public static float cursor21ActiveDamageIncrement;
    public static float cursor21PassiveDamage;
    public static float cursor21PassiveDamageIncrement;
    public static float cursor21CritChance;
    public static float cursor21CritChanceIncrement;
    public static float cursor21CritDamage;
    public static float cursor21CritDamageIncrement;
    public static int cursor21Level;
    public static int cursor21Equipped;

    public GameObject cursor21Button;
    public TextMeshProUGUI equippedTextCursor21;
    public TextMeshProUGUI cursor21ActiveDamagePercentText;
    public TextMeshProUGUI cursor21PassiveDamagePercentText;
    public TextMeshProUGUI cursor21CritChancePercentText;
    public TextMeshProUGUI cursor21CritDamagePercentText;
    public TextMeshProUGUI cursor21LevelText;
    public TextMeshProUGUI cursor21LevelHoverText;

    public TextMeshProUGUI cursor21QuasaritePriceText;
    public TextMeshProUGUI cursor21RadiantNovaStonePriceText;
    public TextMeshProUGUI cursor21SoluniumShardPriceText;

    public void EquippCursor21()
    {
        currentlyEquippedText.text = Localization.cursor21Equipped;
        SetEquippedFalse();
        setCursorsZero();

        cursorEquippedChance = 100;

        equippedTextCursor21.text = Localization.equipped; equippedTextCursor21.color = Color.green;
        activeDamageMultiplier = cursor21ActiveDamage;
        passiveDamageMultiplier = cursor21PassiveDamage;
        critChance = cursor21CritChance;
        critDamage = cursor21CritDamage;

        Color newColor;
        ColorUtility.TryParseHtmlString(equippedColor, out newColor);
        cursorButtons[20].color = newColor;
        SetTopText();
        cursor21Equipped = 1;
    }

    public void UpgradeCursor21()
    {
        if (isCursorMax == true)
        {
            if (RareDropsCollected.quasariteCount < cursor21QuasaritePrice || RareDropsCollected.radiantNovaStoneCount < cursor21RadiantNovaStonePrice || RareDropsCollected.soluniumShardCount < cursor21SoluniumShardPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.quasariteCount >= cursor21QuasaritePrice && RareDropsCollected.radiantNovaStoneCount >= cursor21RadiantNovaStonePrice && RareDropsCollected.soluniumShardCount >= cursor21SoluniumShardPrice)
            {
                UpgradeSound();
            }
            while (RareDropsCollected.quasariteCount >= cursor21QuasaritePrice && RareDropsCollected.radiantNovaStoneCount >= cursor21RadiantNovaStonePrice && RareDropsCollected.soluniumShardCount >= cursor21SoluniumShardPrice)
            {
                Cursor21Variables();
            }
        }
        else
        {
            if (RareDropsCollected.quasariteCount < cursor21QuasaritePrice || RareDropsCollected.radiantNovaStoneCount < cursor21RadiantNovaStonePrice || RareDropsCollected.soluniumShardCount < cursor21SoluniumShardPrice)
            {
                CantAfford();
            }
            if (RareDropsCollected.quasariteCount >= cursor21QuasaritePrice && RareDropsCollected.radiantNovaStoneCount >= cursor21RadiantNovaStonePrice && RareDropsCollected.soluniumShardCount >= cursor21SoluniumShardPrice)
            {
                Cursor21Variables();
                UpgradeSound();
            }
        }
    }

    public void Cursor21Variables()
    {
        Stats.cursorUpgraded += 1;
        RareDropsCollected.isGemCountUpdated = true;
        RareDropsCollected.quasariteCount -= cursor21QuasaritePrice;
        RareDropsCollected.radiantNovaStoneCount -= cursor21RadiantNovaStonePrice;
        RareDropsCollected.soluniumShardCount -= cursor21SoluniumShardPrice;

        cursor21ActiveDamage += cursor21ActiveDamageIncrement;
        cursor21PassiveDamage += cursor21PassiveDamageIncrement;
        cursor21CritChance += cursor21CritChanceIncrement;
        cursor21CritDamage += cursor21CritDamageIncrement;

        if (cursor21Equipped == 1) { activeDamageMultiplier = cursor21ActiveDamage; critChance = cursor21CritChance; critDamage = cursor21CritDamage; passiveDamageMultiplier = cursor21PassiveDamage; SetTopText(); }
        cursor21QuasaritePrice += 11;
        cursor21RadiantNovaStonePrice += 11;
        cursor21SoluniumShardPrice += 11;

        cursor21Level += 1;

        HoverSetStrings.boughtUpgrade = true;
        cursorsPriceChanged = true;
        cursor21Change = true;
    }
    #endregion


    public void CantAfford()
    {
        if (AudioManager.audioMuted == 1) { audioManager.Play("Error"); }
    }

    public void UpgradeSound()
    {
        int random = Random.Range(1, 4);
        if (random == 1) { if (AudioManager.audioMuted == 1) { audioManager.Play("LevelUp"); } }
        if (random == 2) { if (AudioManager.audioMuted == 1) { audioManager.Play("LevelUp2"); } }
        if (random == 3) { if (AudioManager.audioMuted == 1) { audioManager.Play("LevelUp3"); } }
    }

    public static double totalPassiveDamage;

    public void SetTopText()
    {
        //Damage for offline progression

        totalPassiveDamage = (HealthBar.newPassiveDamage * (1 + passiveDamageMultiplier + UseConsumable.damagePotionBuff + UseConsumable.elixirDamageBuff + SkillTree.skillTreePassiveDamage + RareTreasures.skullPassiveDamage + RareTreasures.guitarActiveAndPassive + RareTreasures.talariaPassive + RareTreasures.cookiePassive + UseConsumable.scrollPassiveDamageBuff + UseConsumable.relicPermaPassiveDamage));

        topActiveDamage.text = TotalGoldAmount.FormatCoinsDoubleOneLetter((newActiveDamage) * (1 + activeDamageMultiplier + UseConsumable.damagePotionBuff + UseConsumable.elixirDamageBuff + SkillTree.skillTreeActiveDamage + RareTreasures.swordActive + RareTreasures.guitarActiveAndPassive + RareTreasures.cookieActive + UseConsumable.scrollActiveDamageBuff + UseConsumable.relicPermaActiveDamage + UpdateGame.damageBuffAmount - UpdateGame.damageDebuffAmount)) + Localization.activeDamageTop;

       
        topPassiveDamage.text = TotalGoldAmount.FormatCoinsDoubleOneLetter((HealthBar.newPassiveDamage) * (1 + passiveDamageMultiplier + UseConsumable.damagePotionBuff + UseConsumable.elixirDamageBuff + SkillTree.skillTreePassiveDamage + RareTreasures.skullPassiveDamage + RareTreasures.guitarActiveAndPassive + RareTreasures.talariaPassive + RareTreasures.cookiePassive + UseConsumable.scrollPassiveDamageBuff + UseConsumable.relicPermaPassiveDamage + UpdateGame.damageBuffAmount - UpdateGame.damageDebuffAmount)) + " " + Localization.dps;
        
        if((critChance + UseConsumable.XPPotionCritChance + SkillTree.skillTreeCritChance + RareTreasures.cookieCritChance + RareTreasures.swordCrit + UseConsumable.scrollCritChanceBuff + UseConsumable.relicPermaCritChance) == 0) { topCritChance.text = "0" + Localization.critChanceString; }
        else { topCritChance.text = ((critChance + UseConsumable.XPPotionCritChance + SkillTree.skillTreeCritChance + RareTreasures.cookieCritChance + RareTreasures.swordCrit + UseConsumable.scrollCritChanceBuff + UseConsumable.relicPermaCritChance)).ToString("F2") + Localization.critChanceString; }
       
        topCritDamage.text = ((critDamage + UseConsumable.XPPotionCritDamage + SkillTree.skillTreeCritDamage + RareTreasures.cookieCritDamage + UseConsumable.scrollCritDamageBuff + UseConsumable.relicPermaCritDamage) *100).ToString("F0") + Localization.critDamageString;
        SetNewAutoDamage();
    }

    public Image[] cursorButtons;

    public void setCursorsZero()
    {
        if(playSound == true)
        {
            if (AudioManager.audioMuted == 1) { audioManager.Play("UIClick1"); }
        }

        Color newColor;
        ColorUtility.TryParseHtmlString(nowEquippedColor, out newColor);
        cursorButtons[0].color = newColor;
        cursorButtons[1].color = newColor;
        cursorButtons[2].color = newColor;
        cursorButtons[3].color = newColor;
        cursorButtons[4].color = newColor;
        cursorButtons[5].color = newColor;
        cursorButtons[6].color = newColor;
        cursorButtons[7].color = newColor;
        cursorButtons[8].color = newColor;
        cursorButtons[9].color = newColor;
        cursorButtons[10].color = newColor;
        cursorButtons[11].color = newColor;
        cursorButtons[12].color = newColor;
        cursorButtons[13].color = newColor;
        cursorButtons[14].color = newColor;
        cursorButtons[15].color = newColor;
        cursorButtons[16].color = newColor;
        cursorButtons[17].color = newColor;
        cursorButtons[18].color = newColor;
        cursorButtons[19].color = newColor;
        cursorButtons[20].color = newColor;

        activeDamageMultiplier = 0;
        passiveDamageMultiplier = 0;
        critChance = 0;
        critDamage = 0;

        equippedTextCursor1.text = Localization.unequpped; equippedTextCursor1.color = Color.red;
        equippedTextCursor2.text = Localization.unequpped; equippedTextCursor2.color = Color.red;
        equippedTextCursor3.text = Localization.unequpped; equippedTextCursor3.color = Color.red;
        equippedTextCursor4.text = Localization.unequpped; equippedTextCursor4.color = Color.red;
        equippedTextCursor5.text = Localization.unequpped; equippedTextCursor5.color = Color.red;
        equippedTextCursor6.text = Localization.unequpped; equippedTextCursor6.color = Color.red;
        equippedTextCursor7.text = Localization.unequpped; equippedTextCursor7.color = Color.red;
        equippedTextCursor8.text = Localization.unequpped; equippedTextCursor8.color = Color.red;
        equippedTextCursor9.text = Localization.unequpped; equippedTextCursor9.color = Color.red;
        equippedTextCursor10.text = Localization.unequpped; equippedTextCursor10.color = Color.red;
        equippedTextCursor11.text = Localization.unequpped; equippedTextCursor11.color = Color.red;
        equippedTextCursor12.text = Localization.unequpped; equippedTextCursor12.color = Color.red;
        equippedTextCursor13.text = Localization.unequpped; equippedTextCursor13.color = Color.red;
        equippedTextCursor14.text = Localization.unequpped; equippedTextCursor14.color = Color.red;
        equippedTextCursor15.text = Localization.unequpped; equippedTextCursor15.color = Color.red;
        equippedTextCursor16.text = Localization.unequpped; equippedTextCursor16.color = Color.red;
        equippedTextCursor17.text = Localization.unequpped; equippedTextCursor17.color = Color.red;
        equippedTextCursor18.text = Localization.unequpped; equippedTextCursor18.color = Color.red;
        equippedTextCursor19.text = Localization.unequpped; equippedTextCursor19.color = Color.red;
        equippedTextCursor20.text = Localization.unequpped; equippedTextCursor20.color = Color.red;
        equippedTextCursor21.text = Localization.unequpped; equippedTextCursor21.color = Color.red;
    }

    public void SetEquippedFalse()
    {
        cursorEquippedChance = 0;
        cursor5RareDropsBonus = 0f;
        cursorEquippedGoldIncrease = 0;
        cursorEquippedXPIncrease = 0;
        SpawnRewards.changeDropChanceValues = true;

        cursor1Equipped = 0;
        cursor2Equipped = 0;
        cursor3Equipped = 0;
        cursor4Equipped = 0;
        cursor5Equipped = 0;
        cursor6Equipped = 0;
        cursor7Equipped = 0;
        cursor8Equipped = 0;
        cursor9Equipped = 0;
        cursor10Equipped = 0;
        cursor11Equipped = 0;
        cursor12Equipped = 0;
        cursor13Equipped = 0;
        cursor14Equipped = 0;
        cursor15Equipped = 0;
        cursor16Equipped = 0;
        cursor17Equipped = 0;
        cursor18Equipped = 0;
        cursor19Equipped = 0;
        cursor20Equipped = 0;
        cursor21Equipped = 0;

        cursorsPriceChanged = true;
        RareDropsCollected.isGemCountUpdated = true;


    }

    public void ChangeText()
    {
        cursor1Change = true;
        cursor2Change = true;
        cursor3Change = true;
        cursor4Change = true;
        cursor5Change = true;
        cursor6Change = true;
        cursor7Change = true;
        cursor8Change = true;
        cursor9Change = true;
        cursor10Change = true;
        cursor11Change = true;
        cursor12Change = true;
        cursor13Change = true;
        cursor14Change = true;
        cursor15Change = true;
        cursor16Change = true;
        cursor17Change = true;
        cursor18Change = true;
        cursor19Change = true;
        cursor20Change = true;
        cursor21Change = true;

        SetNewAutoDamage();

        if (newActiveDamage < 10) { activeDamageText.text = (newActiveDamage.ToString("F2")) + Localization.clickDamage + "<color=green>(+" + (newActiveDamage * activeIncrease).ToString("F2") + ")<color=green>"; }
        if (newActiveDamage > 10) { activeDamageText.text = TotalGoldAmount.FormatCoinsDoubleOneLetter(newActiveDamage) + Localization.clickDamage + " <color=green>(+" + TotalGoldAmount.FormatCoinsDoubleOneLetter(newActiveDamage * activeIncrease) + ")<color=green>"; }

        equippedTextCursor1.text = Localization.unequpped; equippedTextCursor1.color = Color.red;
        equippedTextCursor2.text = Localization.unequpped; equippedTextCursor2.color = Color.red;
        equippedTextCursor3.text = Localization.unequpped; equippedTextCursor3.color = Color.red;
        equippedTextCursor4.text = Localization.unequpped; equippedTextCursor4.color = Color.red;
        equippedTextCursor5.text = Localization.unequpped; equippedTextCursor5.color = Color.red;
        equippedTextCursor6.text = Localization.unequpped; equippedTextCursor6.color = Color.red;
        equippedTextCursor7.text = Localization.unequpped; equippedTextCursor7.color = Color.red;
        equippedTextCursor8.text = Localization.unequpped; equippedTextCursor8.color = Color.red;
        equippedTextCursor9.text = Localization.unequpped; equippedTextCursor9.color = Color.red;
        equippedTextCursor10.text = Localization.unequpped; equippedTextCursor10.color = Color.red;
        equippedTextCursor11.text = Localization.unequpped; equippedTextCursor11.color = Color.red;
        equippedTextCursor12.text = Localization.unequpped; equippedTextCursor12.color = Color.red;
        equippedTextCursor13.text = Localization.unequpped; equippedTextCursor13.color = Color.red;
        equippedTextCursor14.text = Localization.unequpped; equippedTextCursor14.color = Color.red;
        equippedTextCursor15.text = Localization.unequpped; equippedTextCursor15.color = Color.red;
        equippedTextCursor16.text = Localization.unequpped; equippedTextCursor16.color = Color.red;
        equippedTextCursor17.text = Localization.unequpped; equippedTextCursor17.color = Color.red;
        equippedTextCursor18.text = Localization.unequpped; equippedTextCursor18.color = Color.red;
        equippedTextCursor19.text = Localization.unequpped; equippedTextCursor19.color = Color.red;
        equippedTextCursor20.text = Localization.unequpped; equippedTextCursor20.color = Color.red;
        equippedTextCursor21.text = Localization.unequpped; equippedTextCursor21.color = Color.red;


        if (cursor1Equipped == 1) { EquippCursor1(); }
        else if (cursor2Equipped == 1) { EquippCursor2(); }
        else if (cursor3Equipped == 1) { EquippCursor3(); }
        else if (cursor4Equipped == 1) { EquippCursor4(); }
        else if (cursor5Equipped == 1) { EquippCursor5(); }
        else if (cursor6Equipped == 1) { EquippCursor6(); }
        else if (cursor7Equipped == 1) { EquippCursor7(); }
        else if (cursor8Equipped == 1) { EquippCursor8(); }
        else if (cursor9Equipped == 1) { EquippCursor9(); }
        else if (cursor10Equipped == 1) { EquippCursor10(); }
        else if (cursor11Equipped == 1) { EquippCursor11(); }
        else if (cursor12Equipped == 1) { EquippCursor12(); }
        else if (cursor13Equipped == 1) { EquippCursor13(); }
        else if (cursor14Equipped == 1) { EquippCursor14(); }
        else if (cursor15Equipped == 1) { EquippCursor15(); }
        else if (cursor16Equipped == 1) { EquippCursor16(); }
        else if (cursor17Equipped == 1) { EquippCursor17(); }
        else if (cursor18Equipped == 1) { EquippCursor18(); }
        else if (cursor19Equipped == 1) { EquippCursor19(); }
        else if (cursor20Equipped == 1) { EquippCursor20(); }
        else if (cursor21Equipped == 1) { EquippCursor21(); }
        else { currentlyEquippedText.text = Localization.equippedNONE; }
    }

    /*public void SavedClickPower()
    {
        SaveSystem.SaveClickPower(this);
    }*/
}
