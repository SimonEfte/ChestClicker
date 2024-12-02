using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HoverSetStrings : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public static string cursor1ActiveText;
    public static string cursor2PassiveText;
    public static string cursor3CritChance, cursor3CritDamage;
    public static string cursor4ActiveText, cursor4PassiveText;
    public static string cursor5ActiveText, cursor5CritChanceText, cursor5CritDamageText;
    public static string cursor6PassiveText, cursor6ActiveText, cursor6CritChanceText, cursor6CritDamageText;
    public static string cursor7ActiveText, cursor7CritChanceText, cursor7CritDamageText;
    public static string cursor8ActiveText, cursor8PassiveText, cursor8CritChanceText, cursor8CritDamageText;
    public static string cursor9ActiveText, cursor9PassiveText;
    public static string cursor10PassiveText;
    public static string cursor11ActiveText, cursor11CritChanceText, cursor11CritDamageText;
    public static string cursor12ActiveText, cursor12PassiveText, cursor12CritChanceText, cursor12CritDamageText;
    public static string cursor13ActiveText, cursor13PassiveText, cursor13CritChanceText, cursor13CritDamageText;
    public static string cursor14ActiveText, cursor14PassiveText, cursor14CritChanceText, cursor14CritDamageText;
    public static string cursor15ActiveText, cursor15PassiveText, cursor15CritChanceText, cursor15CritDamageText;
    public static string cursor16ActiveText, cursor16PassiveText, cursor16CritChanceText, cursor16CritDamageText;
    public static string cursor17ActiveText, cursor17PassiveText, cursor17CritChanceText, cursor17CritDamageText;
    public static string cursor18ActiveText, cursor18PassiveText, cursor18CritChanceText, cursor18CritDamageText;
    public static string cursor19ActiveText, cursor19PassiveText, cursor19CritChanceText, cursor19CritDamageText;
    public static string cursor20ActiveText, cursor20PassiveText, cursor20CritChanceText, cursor20CritDamageText;
    public static string cursor21ActiveText, cursor21PassiveText, cursor21CritChanceText, cursor21CritDamageText;

    public void Start()
    {
        boughtUpgrade = true;
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        if (PlaceMobileButtons.isMobile == true) { return; }

            string objectName = eventData.pointerEnter.name;

        #region cursor1
        if (objectName == "Cursor1") { cursor1ActiveText = "+" + (ClickPower.cursor1ActiveBuff * 100).ToString("F0") + Localization.activeDamageScring;
            ClickPower.cursor1Change = true; }
        if (objectName == "Cursor1Upgrade") { cursor1ActiveText = "+" + (ClickPower.cursor1ActiveBuff * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor1ActiveBuffIncrement * 100).ToString("F0") + "%)<color=green>"; 
            ClickPower.cursor1Change = true; 
        }

        #endregion

        #region cursor2
        if (objectName == "Cursor2") { cursor2PassiveText = "+" + (ClickPower.cursor2PassiveBuff * 100).ToString("F0") + Localization.passiveDamageString; ClickPower.cursor2Change = true; }
        if (objectName == "Cursor2Upgrade") { cursor2PassiveText = "+" + (ClickPower.cursor2PassiveBuff * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor2PassiveBuffIncrement * 100).ToString("F0") + "%)<color=green>"; ClickPower.cursor2Change = true; }
        #endregion

        #region cursor3
        if (objectName == "Cursor3") {
            cursor3CritChance = "+" + (ClickPower.cursor3CritChance).ToString("F1") + Localization.critChanceString;
            cursor3CritDamage = "+" + (ClickPower.cursor3CritDamage * 100).ToString("F0") + Localization.critDamageString;
            ClickPower.cursor3Change = true;
        }
        if (objectName == "Cursor3Upgrade") {
            cursor3CritChance = "+" + (ClickPower.cursor3CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor3CritChanceIncrement).ToString("F1") + "%)<color=green>" ;
            cursor3CritDamage = "+" + (ClickPower.cursor3CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor3CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            ClickPower.cursor3Change = true;
        }
        #endregion

        #region cursor4
        if (objectName == "Cursor4")
        {
            cursor4ActiveText = "+" + (ClickPower.cursor4ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
            cursor4PassiveText = "+" + (ClickPower.cursor4PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString;
            ClickPower.cursor4Change = true;
        }
        if (objectName == "Cursor4Upgrade")
        {
            cursor4ActiveText = "+" + (ClickPower.cursor4ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor4ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            cursor4PassiveText = "+" + (ClickPower.cursor4PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor4PassiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            ClickPower.cursor4Change = true;
        }
        #endregion

        #region cursor5
        if (objectName == "Cursor5")
        {
            cursor5ActiveText = "+" + (ClickPower.cursor5ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
            cursor5CritChanceText = "+" + (ClickPower.cursor5CritChance).ToString("F1") + Localization.critChanceString;
            cursor5CritDamageText = "+" + (ClickPower.cursor5CritDamage * 100).ToString("F0") + Localization.critDamageString;
            ClickPower.cursor5Change = true;
        }
        if (objectName == "Cursor5Upgrade")
        {
            cursor5ActiveText = "+" + (ClickPower.cursor5ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor5ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            cursor5CritChanceText = "+" + (ClickPower.cursor5CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor5CritChanceIncrement).ToString("F1") + "%)<color=green>";
            cursor5CritDamageText = "+" + (ClickPower.cursor5CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor5CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            ClickPower.cursor5Change = true;
        }
        #endregion

        #region cursor6
        if (objectName == "Cursor6")
        {
            cursor6ActiveText = "+" + (ClickPower.cursor6ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
            cursor6PassiveText = "+" + (ClickPower.cursor6PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString;
            cursor6CritChanceText = "+" + (ClickPower.cursor6CritChance).ToString("F1") + Localization.critChanceString;
            cursor6CritDamageText = "+" + (ClickPower.cursor6CritDamage * 100).ToString("F0") + Localization.critDamageString;
            ClickPower.cursor6Change = true;
        }
        if (objectName == "Cursor6Upgrade")
        {
            cursor6PassiveText = "+" + (ClickPower.cursor6PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor6PassiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            cursor6ActiveText = "+" + (ClickPower.cursor6ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor6ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            cursor6CritChanceText = "+" + (ClickPower.cursor6CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor6CritChanceIncrement).ToString("F1") + "%)<color=green>";
            cursor6CritDamageText = "+" + (ClickPower.cursor6CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor6CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            ClickPower.cursor6Change = true;
        }
        #endregion

        #region cursor7
        if (objectName == "Cursor7")
        {
            cursor7ActiveText = "+" + (ClickPower.cursor7ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
            cursor7CritChanceText = "+" + (ClickPower.cursor7CritChance).ToString("F1") + Localization.critChanceString;
            cursor7CritDamageText = "+" + (ClickPower.cursor7CritDamage * 100).ToString("F0") + Localization.critDamageString;
            ClickPower.cursor7Change = true;
        }
        if (objectName == "Cursor7Upgrade")
        {
            cursor7ActiveText = "+" + (ClickPower.cursor7ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor7ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            cursor7CritChanceText = "+" + (ClickPower.cursor7CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor7CritChanceIncrement).ToString("F1") + "%)<color=green>";
            cursor7CritDamageText = "+" + (ClickPower.cursor7CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor7CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            ClickPower.cursor7Change = true;
        }
        #endregion

        #region cursor8
        if (objectName == "Cursor8")
        {
            cursor8ActiveText = "+" + (ClickPower.cursor8ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
            cursor8PassiveText = "+" + (ClickPower.cursor8PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString;
            cursor8CritChanceText = "+" + (ClickPower.cursor8CritChance).ToString("F1") + Localization.critChanceString;
            cursor8CritDamageText = "+" + (ClickPower.cursor8CritDamage * 100).ToString("F0") + Localization.critDamageString;
            ClickPower.cursor8Change = true;
        }
        if (objectName == "Cursor8Upgrade")
        {
            cursor8PassiveText = "+" + (ClickPower.cursor8PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor8PassiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            cursor8ActiveText = "+" + (ClickPower.cursor8ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor8ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            cursor8CritChanceText = "+" + (ClickPower.cursor8CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor8CritChanceIncrement).ToString("F1") + "%)<color=green>";
            cursor8CritDamageText = "+" + (ClickPower.cursor8CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor8CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            ClickPower.cursor8Change = true;
        }
        #endregion

        #region cursor9
        if (objectName == "Cursor9")
        {
            cursor9ActiveText = "+" + (ClickPower.cursor9ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
            cursor9PassiveText = "+" + (ClickPower.cursor9PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString;
            ClickPower.cursor9Change = true;
        }
        if (objectName == "Cursor9Upgrade")
        {
            cursor9PassiveText = "+" + (ClickPower.cursor9PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor9PassiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            cursor9ActiveText = "+" + (ClickPower.cursor9ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor9ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            ClickPower.cursor9Change = true;
        }
        #endregion

        #region cursor10
        if (objectName == "Cursor10")
        {
            cursor10PassiveText = "+" + (ClickPower.cursor10PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString;
            ClickPower.cursor10Change = true;
        }
        if (objectName == "Cursor10Upgrade")
        {
            cursor10PassiveText = "+" + (ClickPower.cursor10PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor10PassiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            ClickPower.cursor10Change = true;
        }
        #endregion

        #region cursor11
        if (objectName == "Cursor11")
        {
            cursor11ActiveText = "+" + (ClickPower.cursor11ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
            cursor11CritChanceText = "+" + (ClickPower.cursor11CritChance).ToString("F1") + Localization.critChanceString;
            cursor11CritDamageText = "+" + (ClickPower.cursor11CritDamage * 100).ToString("F0") + Localization.critDamageString;
            ClickPower.cursor11Change = true;
        }
        if (objectName == "Cursor11Upgrade")
        {
            cursor11ActiveText = "+" + (ClickPower.cursor11ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor11ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            cursor11CritChanceText = "+" + (ClickPower.cursor11CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor11CritChanceIncrement).ToString("F1") + "%)<color=green>";
            cursor11CritDamageText = "+" + (ClickPower.cursor11CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor11CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            ClickPower.cursor11Change = true;
        }
        #endregion

        #region cursor12
        if (objectName == "Cursor12")
        {
            cursor12ActiveText = "+" + (ClickPower.cursor12ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
            cursor12PassiveText = "+" + (ClickPower.cursor12PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString;
            cursor12CritChanceText = "+" + (ClickPower.cursor12CritChance).ToString("F1") + Localization.critChanceString;
            cursor12CritDamageText = "+" + (ClickPower.cursor12CritDamage * 100).ToString("F0") + Localization.critDamageString;
            ClickPower.cursor12Change = true;
        }
        if (objectName == "Cursor12Upgrade")
        {
            cursor12PassiveText = "+" + (ClickPower.cursor12PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor12PassiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            cursor12ActiveText = "+" + (ClickPower.cursor12ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor12ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            cursor12CritChanceText = "+" + (ClickPower.cursor12CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor12CritChanceIncrement).ToString("F1") + "%)<color=green>";
            cursor12CritDamageText = "+" + (ClickPower.cursor12CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor12CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            ClickPower.cursor12Change = true;
        }
        #endregion

        #region cursor13
        if (objectName == "Cursor13")
        {
            cursor13ActiveText = "+" + (ClickPower.cursor13ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
            cursor13PassiveText = "+" + (ClickPower.cursor13PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString;
            cursor13CritChanceText = "+" + (ClickPower.cursor13CritChance).ToString("F1") + Localization.critChanceString;
            cursor13CritDamageText = "+" + (ClickPower.cursor13CritDamage * 100).ToString("F0") + Localization.critDamageString;
            ClickPower.cursor13Change = true;
        }
        if (objectName == "Cursor13Upgrade")
        {
            cursor13PassiveText = "+" + (ClickPower.cursor13PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor13PassiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            cursor13ActiveText = "+" + (ClickPower.cursor13ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor13ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            cursor13CritChanceText = "+" + (ClickPower.cursor13CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor13CritChanceIncrement).ToString("F1") + "%)<color=green>";
            cursor13CritDamageText = "+" + (ClickPower.cursor13CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor13CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            ClickPower.cursor13Change = true;
        }
        #endregion

        #region cursor14
        if (objectName == "Cursor14")
        {
            cursor14ActiveText = "+" + (ClickPower.cursor14ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
            cursor14PassiveText = "+" + (ClickPower.cursor14PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString;
            cursor14CritChanceText = "+" + (ClickPower.cursor14CritChance).ToString("F1") + Localization.critChanceString;
            cursor14CritDamageText = "+" + (ClickPower.cursor14CritDamage * 100).ToString("F0") + Localization.critDamageString;
            ClickPower.cursor14Change = true;
        }
        if (objectName == "Cursor14Upgrade")
        {
            cursor14PassiveText = "+" + (ClickPower.cursor14PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor14PassiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            cursor14ActiveText = "+" + (ClickPower.cursor14ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor14ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            cursor14CritChanceText = "+" + (ClickPower.cursor14CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor14CritChanceIncrement).ToString("F1") + "%)<color=green>";
            cursor14CritDamageText = "+" + (ClickPower.cursor14CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor14CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            ClickPower.cursor14Change = true;
        }
        #endregion

        #region cursor15
        if (objectName == "Cursor15")
        {
            cursor15ActiveText = "+" + (ClickPower.cursor15ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
            cursor15PassiveText = "+" + (ClickPower.cursor15PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString;
            cursor15CritChanceText = "+" + (ClickPower.cursor15CritChance).ToString("F1") + Localization.critChanceString;
            cursor15CritDamageText = "+" + (ClickPower.cursor15CritDamage * 100).ToString("F0") + Localization.critDamageString;
            ClickPower.cursor15Change = true;
        }
        if (objectName == "Cursor15Upgrade")
        {
            cursor15PassiveText = "+" + (ClickPower.cursor15PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor15PassiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            cursor15ActiveText = "+" + (ClickPower.cursor15ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor15ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            cursor15CritChanceText = "+" + (ClickPower.cursor15CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor15CritChanceIncrement).ToString("F1") + "%)<color=green>";
            cursor15CritDamageText = "+" + (ClickPower.cursor15CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor15CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            ClickPower.cursor15Change = true;
        }
        #endregion

        #region cursor16
        if (objectName == "Cursor16")
        {
            cursor16ActiveText = "+" + (ClickPower.cursor16ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
            cursor16PassiveText = "+" + (ClickPower.cursor16PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString;
            cursor16CritChanceText = "+" + (ClickPower.cursor16CritChance).ToString("F1") + Localization.critChanceString;
            cursor16CritDamageText = "+" + (ClickPower.cursor16CritDamage * 100).ToString("F0") + Localization.critDamageString;
            ClickPower.cursor16Change = true;
        }
        if (objectName == "Cursor16Upgrade")
        {
            cursor16PassiveText = "+" + (ClickPower.cursor16PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor16PassiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            cursor16ActiveText = "+" + (ClickPower.cursor16ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor16ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            cursor16CritChanceText = "+" + (ClickPower.cursor16CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor16CritChanceIncrement).ToString("F1") + "%)<color=green>";
            cursor16CritDamageText = "+" + (ClickPower.cursor16CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor16CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            ClickPower.cursor16Change = true;
        }
        #endregion

        #region cursor17
        if (objectName == "Cursor17")
        {
            cursor17ActiveText = "+" + (ClickPower.cursor17ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
            cursor17PassiveText = "+" + (ClickPower.cursor17PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString;
            cursor17CritChanceText = "+" + (ClickPower.cursor17CritChance).ToString("F1") + Localization.critChanceString;
            cursor17CritDamageText = "+" + (ClickPower.cursor17CritDamage * 100).ToString("F0") + Localization.critDamageString;
            ClickPower.cursor17Change = true;
        }
        if (objectName == "Cursor17Upgrade")
        {
            cursor17PassiveText = "+" + (ClickPower.cursor17PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor17PassiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            cursor17ActiveText = "+" + (ClickPower.cursor17ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor17ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            cursor17CritChanceText = "+" + (ClickPower.cursor17CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor17CritChanceIncrement).ToString("F1") + "%)<color=green>";
            cursor17CritDamageText = "+" + (ClickPower.cursor17CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor17CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            ClickPower.cursor17Change = true;
        }
        #endregion

        #region cursor18
        if (objectName == "Cursor18")
        {
            cursor18ActiveText = "+" + (ClickPower.cursor18ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
            cursor18PassiveText = "+" + (ClickPower.cursor18PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString;
            cursor18CritChanceText = "+" + (ClickPower.cursor18CritChance).ToString("F1") + Localization.critChanceString;
            cursor18CritDamageText = "+" + (ClickPower.cursor18CritDamage * 100).ToString("F0") + Localization.critDamageString;
            ClickPower.cursor18Change = true;
        }
        if (objectName == "Cursor18Upgrade")
        {
            cursor18PassiveText = "+" + (ClickPower.cursor18PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor18PassiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            cursor18ActiveText = "+" + (ClickPower.cursor18ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor18ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            cursor18CritChanceText = "+" + (ClickPower.cursor18CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor18CritChanceIncrement).ToString("F1") + "%)<color=green>";
            cursor18CritDamageText = "+" + (ClickPower.cursor18CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor18CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            ClickPower.cursor18Change = true;
        }
        #endregion

        #region cursor19
        if (objectName == "Cursor19")
        {
            cursor19ActiveText = "+" + (ClickPower.cursor19ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
            cursor19PassiveText = "+" + (ClickPower.cursor19PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString;
            cursor19CritChanceText = "+" + (ClickPower.cursor19CritChance).ToString("F1") + Localization.critChanceString;
            cursor19CritDamageText = "+" + (ClickPower.cursor19CritDamage * 100).ToString("F0") + Localization.critDamageString;
            ClickPower.cursor19Change = true;
        }
        if (objectName == "Cursor19Upgrade")
        {
            cursor19PassiveText = "+" + (ClickPower.cursor19PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor19PassiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            cursor19ActiveText = "+" + (ClickPower.cursor19ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor19ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            cursor19CritChanceText = "+" + (ClickPower.cursor19CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor19CritChanceIncrement).ToString("F1") + "%)<color=green>";
            cursor19CritDamageText = "+" + (ClickPower.cursor19CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor19CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            ClickPower.cursor19Change = true;
        }
        #endregion

        #region cursor20
        if (objectName == "Cursor20")
        {
            cursor20ActiveText = "+" + (ClickPower.cursor20ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
            cursor20PassiveText = "+" + (ClickPower.cursor20PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString;
            cursor20CritChanceText = "+" + (ClickPower.cursor20CritChance).ToString("F1") + Localization.critChanceString;
            cursor20CritDamageText = "+" + (ClickPower.cursor20CritDamage * 100).ToString("F0") + Localization.critDamageString;
            ClickPower.cursor20Change = true;
        }
        if (objectName == "Cursor20Upgrade")
        {
            cursor20PassiveText = "+" + (ClickPower.cursor20PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor20PassiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            cursor20ActiveText = "+" + (ClickPower.cursor20ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor20ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            cursor20CritChanceText = "+" + (ClickPower.cursor20CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor20CritChanceIncrement).ToString("F1") + "%)<color=green>";
            cursor20CritDamageText = "+" + (ClickPower.cursor20CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor20CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            ClickPower.cursor20Change = true;
        }
        #endregion

        #region cursor21
        if (objectName == "Cursor21")
        {
            cursor21ActiveText = "+" + (ClickPower.cursor21ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
            cursor21PassiveText = "+" + (ClickPower.cursor21PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString;
            cursor21CritChanceText = "+" + (ClickPower.cursor21CritChance).ToString("F1") + Localization.critChanceString;
            cursor21CritDamageText = "+" + (ClickPower.cursor21CritDamage * 100).ToString("F0") + Localization.critDamageString;
            ClickPower.cursor21Change = true;
        }
        if (objectName == "Cursor21Upgrade")
        {
            cursor21PassiveText = "+" + (ClickPower.cursor21PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor21PassiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            cursor21ActiveText = "+" + (ClickPower.cursor21ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor21ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            cursor21CritChanceText = "+" + (ClickPower.cursor21CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor21CritChanceIncrement).ToString("F1") + "%)<color=green>";
            cursor21CritDamageText = "+" + (ClickPower.cursor21CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor21CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
            ClickPower.cursor21Change = true;
        }
        #endregion

        ClickPower.cursorsPriceChanged = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (PlaceMobileButtons.isMobile == true) { return; }

        ClickPower.cursorsPriceChanged = true;

        #region allCursorTextExit
        cursor1ActiveText = "+" + (ClickPower.cursor1ActiveBuff * 100).ToString("F0") + Localization.activeDamageScring; 

        cursor2PassiveText = "+" + (ClickPower.cursor2PassiveBuff * 100).ToString("F0") + Localization.passiveDamageString; 

        cursor3CritChance = "+" + (ClickPower.cursor3CritChance).ToString("F1") + Localization.critChanceString;
        cursor3CritDamage = "+" + (ClickPower.cursor3CritDamage * 100).ToString("F0") + Localization.critDamageString;

        cursor4ActiveText = "+" + (ClickPower.cursor4ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
        cursor4PassiveText = "+" + (ClickPower.cursor4PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString;

        cursor5ActiveText = "+" + (ClickPower.cursor5ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
        cursor5CritChanceText = "+" + (ClickPower.cursor5CritChance).ToString("F1") + Localization.critChanceString;
        cursor5CritDamageText = "+" + (ClickPower.cursor5CritDamage * 100).ToString("F0") + Localization.critDamageString;

        cursor6ActiveText = "+" + (ClickPower.cursor6ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
        cursor6PassiveText = "+" + (ClickPower.cursor6PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString;
        cursor6CritChanceText = "+" + (ClickPower.cursor6CritChance).ToString("F1") + Localization.critChanceString;
        cursor6CritDamageText = "+" + (ClickPower.cursor6CritDamage * 100).ToString("F0") + Localization.critDamageString;

        cursor7ActiveText = "+" + (ClickPower.cursor7ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
        cursor7CritChanceText = "+" + (ClickPower.cursor7CritChance).ToString("F1") + Localization.critChanceString;
        cursor7CritDamageText = "+" + (ClickPower.cursor7CritDamage * 100).ToString("F0") + Localization.critDamageString;

        cursor8ActiveText = "+" + (ClickPower.cursor8ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
        cursor8PassiveText = "+" + (ClickPower.cursor8PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString;
        cursor8CritChanceText = "+" + (ClickPower.cursor8CritChance).ToString("F1") + Localization.critChanceString;
        cursor8CritDamageText = "+" + (ClickPower.cursor8CritDamage * 100).ToString("F0") + Localization.critDamageString;

        cursor9ActiveText = "+" + (ClickPower.cursor9ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
        cursor9PassiveText = "+" + (ClickPower.cursor9PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString;

        cursor10PassiveText = "+" + (ClickPower.cursor10PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString;

        cursor11ActiveText = "+" + (ClickPower.cursor11ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
        cursor11CritChanceText = "+" + (ClickPower.cursor11CritChance).ToString("F1") + Localization.critChanceString;
        cursor11CritDamageText = "+" + (ClickPower.cursor11CritDamage * 100).ToString("F0") + Localization.critDamageString;

        cursor12ActiveText = "+" + (ClickPower.cursor12ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
        cursor12PassiveText = "+" + (ClickPower.cursor12PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString;
        cursor12CritChanceText = "+" + (ClickPower.cursor12CritChance).ToString("F1") + Localization.critChanceString;
        cursor12CritDamageText = "+" + (ClickPower.cursor12CritDamage * 100).ToString("F0") + Localization.critDamageString;

        cursor13ActiveText = "+" + (ClickPower.cursor13ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
        cursor13PassiveText = "+" + (ClickPower.cursor13PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString;
        cursor13CritChanceText = "+" + (ClickPower.cursor13CritChance).ToString("F1") + Localization.critChanceString;
        cursor13CritDamageText = "+" + (ClickPower.cursor13CritDamage * 100).ToString("F0") + Localization.critDamageString;

        cursor14ActiveText = "+" + (ClickPower.cursor14ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
        cursor14PassiveText = "+" + (ClickPower.cursor14PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString;
        cursor14CritChanceText = "+" + (ClickPower.cursor14CritChance).ToString("F1") + Localization.critChanceString;
        cursor14CritDamageText = "+" + (ClickPower.cursor14CritDamage * 100).ToString("F0") + Localization.critDamageString;

        cursor15ActiveText = "+" + (ClickPower.cursor15ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
        cursor15PassiveText = "+" + (ClickPower.cursor15PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString;
        cursor15CritChanceText = "+" + (ClickPower.cursor15CritChance).ToString("F1") + Localization.critChanceString;
        cursor15CritDamageText = "+" + (ClickPower.cursor15CritDamage * 100).ToString("F0") + Localization.critDamageString;

        cursor16ActiveText = "+" + (ClickPower.cursor16ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
        cursor16PassiveText = "+" + (ClickPower.cursor16PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString;
        cursor16CritChanceText = "+" + (ClickPower.cursor16CritChance).ToString("F1") + Localization.critChanceString;
        cursor16CritDamageText = "+" + (ClickPower.cursor16CritDamage * 100).ToString("F0") + Localization.critDamageString;

        cursor17ActiveText = "+" + (ClickPower.cursor17ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
        cursor17PassiveText = "+" + (ClickPower.cursor17PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString;
        cursor17CritChanceText = "+" + (ClickPower.cursor17CritChance).ToString("F1") + Localization.critChanceString;
        cursor17CritDamageText = "+" + (ClickPower.cursor17CritDamage * 100).ToString("F0") + Localization.critDamageString;

        cursor18ActiveText = "+" + (ClickPower.cursor18ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
        cursor18PassiveText = "+" + (ClickPower.cursor18PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString;
        cursor18CritChanceText = "+" + (ClickPower.cursor18CritChance).ToString("F1") + Localization.critChanceString;
        cursor18CritDamageText = "+" + (ClickPower.cursor18CritDamage * 100).ToString("F0") + Localization.critDamageString;

        cursor19ActiveText = "+" + (ClickPower.cursor19ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
        cursor19PassiveText = "+" + (ClickPower.cursor19PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString;
        cursor19CritChanceText = "+" + (ClickPower.cursor19CritChance).ToString("F1") + Localization.critChanceString;
        cursor19CritDamageText = "+" + (ClickPower.cursor19CritDamage * 100).ToString("F0") + Localization.critDamageString;

        cursor20ActiveText = "+" + (ClickPower.cursor20ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
        cursor20PassiveText = "+" + (ClickPower.cursor20PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString;
        cursor20CritChanceText = "+" + (ClickPower.cursor20CritChance).ToString("F1") + Localization.critChanceString;
        cursor20CritDamageText = "+" + (ClickPower.cursor20CritDamage * 100).ToString("F0") + Localization.critDamageString;

        cursor21ActiveText = "+" + (ClickPower.cursor21ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring;
        cursor21PassiveText = "+" + (ClickPower.cursor21PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString;
        cursor21CritChanceText = "+" + (ClickPower.cursor21CritChance).ToString("F1") + Localization.critChanceString;
        cursor21CritDamageText = "+" + (ClickPower.cursor21CritDamage * 100).ToString("F0") + Localization.critDamageString;
        #endregion

        #region cursorsChange
        ClickPower.cursor1Change = true; ClickPower.cursor2Change = true; ClickPower.cursor3Change = true; ClickPower.cursor4Change = true; ClickPower.cursor5Change = true; ClickPower.cursor6Change = true; ClickPower.cursor7Change = true; ClickPower.cursor8Change = true; ClickPower.cursor9Change = true; ClickPower.cursor10Change = true; ClickPower.cursor11Change = true; ClickPower.cursor12Change = true; ClickPower.cursor13Change = true; ClickPower.cursor14Change = true; ClickPower.cursor15Change = true; ClickPower.cursor16Change = true; ClickPower.cursor17Change = true; ClickPower.cursor18Change = true; ClickPower.cursor19Change = true; ClickPower.cursor20Change = true; ClickPower.cursor21Change = true;
        #endregion
    }

    public static bool boughtUpgrade;
    public void Update()
    {
        if(boughtUpgrade == true)
        {
            #region Cursor 1
            if (ClickPower.cursorHoverChange[0] == true)
            {
                cursor1ActiveText = "+" + (ClickPower.cursor1ActiveBuff * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor1ActiveBuffIncrement * 100).ToString("F0") + "%)<color=green>";
                ClickPower.cursorHoverChange[0] = false;
            }
            #endregion

            #region Cursor 2
            if (ClickPower.cursorHoverChange[1] == true)
            {
                cursor2PassiveText = "+" + (ClickPower.cursor2PassiveBuff * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor2PassiveBuffIncrement * 100).ToString("F0") + "%)<color=green>";
                ClickPower.cursorHoverChange[1] = false;
            }
            #endregion

            #region Cursor 3
            if (ClickPower.cursorHoverChange[2] == true)
            {
                cursor3CritChance = "+" + (ClickPower.cursor3CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor3CritChanceIncrement).ToString("F1") + "%)<color=green>";
                cursor3CritDamage = "+" + (ClickPower.cursor3CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor3CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                ClickPower.cursorHoverChange[2] = false;
            }
            #endregion

            #region Cursor 4
            if (ClickPower.cursorHoverChange[3] == true)
            {
                cursor4ActiveText = "+" + (ClickPower.cursor4ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor4ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                cursor4PassiveText = "+" + (ClickPower.cursor4PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor4PassiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                ClickPower.cursorHoverChange[3] = false;
            }
            #endregion

            #region Cursor 5
            if (ClickPower.cursorHoverChange[4] == true)
            {
                cursor5ActiveText = "+" + (ClickPower.cursor5ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor5ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                cursor5CritChanceText = "+" + (ClickPower.cursor5CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor5CritChanceIncrement).ToString("F1") + "%)<color=green>";
                cursor5CritDamageText = "+" + (ClickPower.cursor5CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor5CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                ClickPower.cursorHoverChange[4] = false;
            }
            #endregion

            #region Cursor 6
            if (ClickPower.cursorHoverChange[5] == true)
            {
                cursor6PassiveText = "+" + (ClickPower.cursor6PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor6PassiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                cursor6ActiveText = "+" + (ClickPower.cursor6ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor6ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                cursor6CritChanceText = "+" + (ClickPower.cursor6CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor6CritChanceIncrement).ToString("F1") + "%)<color=green>";
                cursor6CritDamageText = "+" + (ClickPower.cursor6CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor6CritDamageIncrement * 100).ToString("F0") + "%)<color=green>"; ClickPower.cursorHoverChange[5] = false;
            }
            #endregion

            #region Cursor 7
            if (ClickPower.cursorHoverChange[6] == true)
            {
                cursor7ActiveText = "+" + (ClickPower.cursor7ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor7ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                cursor7CritChanceText = "+" + (ClickPower.cursor7CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor7CritChanceIncrement).ToString("F1") + "%)<color=green>";
                cursor7CritDamageText = "+" + (ClickPower.cursor7CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor7CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                ClickPower.cursorHoverChange[6] = false;
            }
            #endregion

            #region Cursor 8
            if (ClickPower.cursorHoverChange[7] == true)
            {
                cursor8PassiveText = "+" + (ClickPower.cursor8PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor8PassiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                cursor8ActiveText = "+" + (ClickPower.cursor8ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor8ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                cursor8CritChanceText = "+" + (ClickPower.cursor8CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor8CritChanceIncrement).ToString("F1") + "%)<color=green>";
                cursor8CritDamageText = "+" + (ClickPower.cursor8CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor8CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                ClickPower.cursorHoverChange[7] = false;
            }
            #endregion

            #region Cursor 9
            if (ClickPower.cursorHoverChange[8] == true)
            {
                cursor9PassiveText = "+" + (ClickPower.cursor9PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor9PassiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                cursor9ActiveText = "+" + (ClickPower.cursor9ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor9ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                ClickPower.cursorHoverChange[8] = false;
            }
            #endregion

            #region Cursor 10
            if (ClickPower.cursorHoverChange[9] == true)
            {
                cursor10PassiveText = "+" + (ClickPower.cursor10PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor10PassiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                ClickPower.cursorHoverChange[9] = false;
            }
            #endregion

            #region Cursor 11
            if (ClickPower.cursorHoverChange[10] == true)
            {
                cursor11ActiveText = "+" + (ClickPower.cursor11ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor11ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                cursor11CritChanceText = "+" + (ClickPower.cursor11CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor11CritChanceIncrement).ToString("F1") + "%)<color=green>";
                cursor11CritDamageText = "+" + (ClickPower.cursor11CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor11CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                ClickPower.cursorHoverChange[10] = false;
            }
            #endregion

            #region Cursor 12
            if (ClickPower.cursorHoverChange[11] == true)
            {
                cursor12PassiveText = "+" + (ClickPower.cursor12PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor12PassiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                cursor12ActiveText = "+" + (ClickPower.cursor12ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor12ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                cursor12CritChanceText = "+" + (ClickPower.cursor12CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor12CritChanceIncrement).ToString("F1") + "%)<color=green>";
                cursor12CritDamageText = "+" + (ClickPower.cursor12CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor12CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                ClickPower.cursorHoverChange[11] = false;
            }
            #endregion

            #region Cursor 13
            if (ClickPower.cursorHoverChange[12] == true)
            {
                cursor13PassiveText = "+" + (ClickPower.cursor13PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor13PassiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                cursor13ActiveText = "+" + (ClickPower.cursor13ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor13ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                cursor13CritChanceText = "+" + (ClickPower.cursor13CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor13CritChanceIncrement).ToString("F1") + "%)<color=green>";
                cursor13CritDamageText = "+" + (ClickPower.cursor13CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor13CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                ClickPower.cursorHoverChange[12] = false;
            }
            #endregion

            #region Cursor 14
            if (ClickPower.cursorHoverChange[13] == true)
            {
                cursor14PassiveText = "+" + (ClickPower.cursor14PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor14PassiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                cursor14ActiveText = "+" + (ClickPower.cursor14ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor14ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                cursor14CritChanceText = "+" + (ClickPower.cursor14CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor14CritChanceIncrement).ToString("F1") + "%)<color=green>";
                cursor14CritDamageText = "+" + (ClickPower.cursor14CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor14CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                ClickPower.cursorHoverChange[13] = false;
            }
            #endregion

            #region Cursor 15
            if (ClickPower.cursorHoverChange[14] == true)
            {
                cursor15PassiveText = "+" + (ClickPower.cursor15PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor15PassiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                cursor15ActiveText = "+" + (ClickPower.cursor15ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor15ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                cursor15CritChanceText = "+" + (ClickPower.cursor15CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor15CritChanceIncrement).ToString("F1") + "%)<color=green>";
                cursor15CritDamageText = "+" + (ClickPower.cursor15CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor15CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                ClickPower.cursorHoverChange[14] = false;
            }
            #endregion

            #region Cursor 16
            if (ClickPower.cursorHoverChange[15] == true)
            {
                cursor16PassiveText = "+" + (ClickPower.cursor16PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor16PassiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                cursor16ActiveText = "+" + (ClickPower.cursor16ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor16ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                cursor16CritChanceText = "+" + (ClickPower.cursor16CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor16CritChanceIncrement).ToString("F1") + "%)<color=green>";
                cursor16CritDamageText = "+" + (ClickPower.cursor16CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor16CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                ClickPower.cursorHoverChange[15] = false;
            }
            #endregion

            #region Cursor 17
            if (ClickPower.cursorHoverChange[16] == true)
            {
                cursor17PassiveText = "+" + (ClickPower.cursor17PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor17PassiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                cursor17ActiveText = "+" + (ClickPower.cursor17ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor17ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                cursor17CritChanceText = "+" + (ClickPower.cursor17CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor17CritChanceIncrement).ToString("F1") + "%)<color=green>";
                cursor17CritDamageText = "+" + (ClickPower.cursor17CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor17CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                ClickPower.cursorHoverChange[16] = false;
            }
            #endregion

            #region Cursor 18
            if (ClickPower.cursorHoverChange[17] == true)
            {
                cursor18PassiveText = "+" + (ClickPower.cursor18PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor18PassiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                cursor18ActiveText = "+" + (ClickPower.cursor18ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor18ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                cursor18CritChanceText = "+" + (ClickPower.cursor18CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor18CritChanceIncrement).ToString("F1") + "%)<color=green>";
                cursor18CritDamageText = "+" + (ClickPower.cursor18CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor18CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                ClickPower.cursorHoverChange[17] = false;
            }
            #endregion

            #region Cursor 19
            if (ClickPower.cursorHoverChange[18] == true)
            {
                cursor19PassiveText = "+" + (ClickPower.cursor19PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor19PassiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                cursor19ActiveText = "+" + (ClickPower.cursor19ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor19ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                cursor19CritChanceText = "+" + (ClickPower.cursor19CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor19CritChanceIncrement).ToString("F1") + "%)<color=green>";
                cursor19CritDamageText = "+" + (ClickPower.cursor19CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor19CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                ClickPower.cursorHoverChange[18] = false;
            }
            #endregion

            #region Cursor 20
            if (ClickPower.cursorHoverChange[19] == true)
            {
                cursor20PassiveText = "+" + (ClickPower.cursor20PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor20PassiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                cursor20ActiveText = "+" + (ClickPower.cursor20ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor20ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                cursor20CritChanceText = "+" + (ClickPower.cursor20CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor20CritChanceIncrement).ToString("F1") + "%)<color=green>";
                cursor20CritDamageText = "+" + (ClickPower.cursor20CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor20CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                ClickPower.cursorHoverChange[19] = false;
            }
            #endregion

            #region Cursor 21
            if (ClickPower.cursorHoverChange[20] == true)
            {
                cursor21PassiveText = "+" + (ClickPower.cursor21PassiveDamage * 100).ToString("F0") + Localization.passiveDamageString + "<color=green>(+" + (ClickPower.cursor21PassiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                cursor21ActiveText = "+" + (ClickPower.cursor21ActiveDamage * 100).ToString("F0") + Localization.activeDamageScring + "<color=green>(+" + (ClickPower.cursor21ActiveDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                cursor21CritChanceText = "+" + (ClickPower.cursor21CritChance).ToString("F1") + Localization.critChanceString + "<color=green>(+" + (ClickPower.cursor21CritChanceIncrement).ToString("F1") + "%)<color=green>";
                cursor21CritDamageText = "+" + (ClickPower.cursor21CritDamage * 100).ToString("F0") + Localization.critDamageString + "<color=green>(+" + (ClickPower.cursor21CritDamageIncrement * 100).ToString("F0") + "%)<color=green>";
                ClickPower.cursorHoverChange[20] = false;
            }
            #endregion

            boughtUpgrade = false;
        }
    }
}
