using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HoverSpecialString : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public static string lockPickOpenChanceText, lockPickDropChanceText, lockPickPurchaseText;
    public static string hammerDamageText, hammerDropChanceText, hammerPurchaseText;
    public static string keyRareDropChanceText, keyDropChanceText, keyPurchaseText;
    public static string goldenTouchTimerText, goldenTouchDropChance, goldenTouchPurchaseText;
    public static string treasureChestDropChanceText, treasureBagPurchaseText;
    public static string XPPotionDropChanceText, xpPotionBuffText, XPPotionPurchaseText;
    public static string damagePotionDropChanceText, damagePotionBuffText, damagePotionPurchaseText;
    public static string lootPotiontDropChanceText, lootpotionBuffText, lootPotionPurchaseText;
    public static string miniChestTimerText, miniChestPriceText;
    public static string elixirInfo, elixirDropChance, elixirPurchase;
    public static string scrollInfo, scrollDropChance, scrollPurchase;
    public static string gauntletInfo, gauntletDropChance, gauntletPurchase;
    public static string relicInfo, relicDropChance, relicPurchase;
    public static string bringBackCursor;
    public static string knifeInfo, knifeDropChance, KnifePurhcase;
    public static string treasurePotionInfo, treasurePotionDropChance, treasurePotionPurchase;
    public static string barrelInfo;
    public static string mimicChestInfo, mimicChestPurchase, mimicChestTimer;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(PlaceMobileButtons.isMobile == true) { return; }

        string objectName = eventData.pointerEnter.name;

        //English
        #region EnglishLanguage
        if(Localization.EnglishLanguageChosen == 1)
        {
            #region lockPick
            //LockPick
            if (objectName == "PurchaseLockPick")
            {
                lockPickOpenChanceText = UseConsumable.lockPickSuccessChance + "% Chance to instantly open a chest";
                lockPickDropChanceText = SpecialUpgradesButtons.lockPickDropChance.ToString("F2") + "% Chance to drop from a chest";
                lockPickPurchaseText = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newLockPickPrice) + " Gold";
            }
            else if (objectName == "LockPickUpgrade")
            {
                lockPickOpenChanceText = UseConsumable.lockPickSuccessChance + "% Chance to instantly open a chest " + "<color=green>(+" + SpecialUpgradesButtons.lockPickOpenChanceIncrement + "%)<color=green>";
                lockPickDropChanceText = SpecialUpgradesButtons.lockPickDropChance.ToString("F2") + "% Chance to drop from a chest " + "<color=green>(+" + SpecialUpgradesButtons.lockPickDropChanceIncrement.ToString("F3") + "%)<color=green>";
                lockPickPurchaseText = "";
            }
            else if (objectName == "lockPickIcon")
            {
                lockPickOpenChanceText = UseConsumable.lockPickSuccessChance + "% Chance to instantly open a chest ";
                lockPickDropChanceText = "";
                lockPickPurchaseText = "Click to use a LOCKPICK on a chest";
            }

            #endregion

            #region hammer
            //Hammer
            else if (objectName == "LockedHammerUpgrade")
            {
                hammerDamageText = "Deals +" + (UseConsumable.hammerDamageMultiplier * 100).ToString("F0") + "% active damage for " + SpecialUpgradesButtons.hammerTimer + " seconds";
                hammerDropChanceText = SpecialUpgradesButtons.hammerDropChance.ToString("F2") + "% Chance to drop from a chest";
                hammerPurchaseText = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newHammerPrice) + " Gold";
                bringBackCursor = "";
            }
            else if (objectName == "UpgradeHammer")
            {
                hammerDamageText = "Deals +" + (UseConsumable.hammerDamageMultiplier * 100).ToString("F0") + "% <color=green>(+" + (SpecialUpgradesButtons.hammerDamageAmountIncrement * 100) + "%)<color=white>" + " active damage for " + SpecialUpgradesButtons.hammerTimer + " <color=green>(+" + (SpecialUpgradesButtons.hammerTimerIncrement) + "S)<color=white> seconds";

                hammerDropChanceText = SpecialUpgradesButtons.hammerDropChance.ToString("F2") + "% Chance to drop from a chest " + "<color=green>(+" + SpecialUpgradesButtons.hammerDropChanceIncrement.ToString("F3") + "%)<color=green>";
                hammerPurchaseText = "";
                bringBackCursor = "";
            }

            else if (objectName == "hammerIcon")
            {
                hammerDamageText = "Deals +" + (UseConsumable.hammerDamageMultiplier * 100).ToString("F0") + "% active damage for " + SpecialUpgradesButtons.hammerTimer + " seconds";
                hammerDropChanceText = "";
                hammerPurchaseText = "Click to use a HAMMER";
                bringBackCursor = "Press ESCAPE to bring back the cursor while using the hammer";
            }
            #endregion

            #region key
            //Key
            else if (objectName == "LockedKey")
            {
                keyRareDropChanceText = SpecialUpgradesButtons.keyRareDropChance.ToString("F2") + "% Chance to drop a treasure from a chest";
                keyDropChanceText = SpecialUpgradesButtons.keyDropChance + "% Chance to drop from a chest";
                keyPurchaseText = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newkeyPrice) + " Gold";
            }
            else if (objectName == "UpgradeKey")
            {
                keyRareDropChanceText = SpecialUpgradesButtons.keyRareDropChance.ToString("F2") + "% Chance to drop a treasure from a chest" + "<color=green>(+" + SpecialUpgradesButtons.keyRareDropChanceIncrement + "%)<color=green>";

                keyDropChanceText = SpecialUpgradesButtons.keyDropChance.ToString("F2") + "% Chance to drop from a chest " + "<color=green>(+" + SpecialUpgradesButtons.keyDropChanceIncrement.ToString("F3") + "%)<color=green>";
                keyPurchaseText = "";
            }
            else if (objectName == "keyIcon")
            {
                keyRareDropChanceText = SpecialUpgradesButtons.keyRareDropChance.ToString("F2") + "% Chance to drop a treasure from a chest";
                keyDropChanceText = "";
                keyPurchaseText = "Click to use a KEY on a chest";
            }
            #endregion

            #region goldentouch
            //GoldenTouch
            else if (objectName == "LockedGoldenTouch")
            {
                goldenTouchTimerText = "Chests spawn 6-10 more gold coins for " + SpecialUpgradesButtons.goldenTouchTimer + " seconds";
                goldenTouchDropChance = SpecialUpgradesButtons.goldenTouchDropChance.ToString("F2") + "% Chance to drop from a chest";
                goldenTouchPurchaseText = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newGoldenTouchPrice) + " Gold";
            }
            else if (objectName == "UpgradeGoldenTouch")
            {
                goldenTouchTimerText = "Chests spawn 6-10 more gold coins for " + SpecialUpgradesButtons.goldenTouchTimer + " <color=green>(+" + SpecialUpgradesButtons.goldenTouchTimerIncrement + "S)<color=white>" + " seconds";

                goldenTouchDropChance = SpecialUpgradesButtons.goldenTouchDropChance.ToString("F2") + "% Chance to drop from a chest " + "<color=green>(+" + SpecialUpgradesButtons.goldenTouchDropChanceIncrement.ToString("F3") + "%)<color=green>";
                goldenTouchPurchaseText = "";
            }
            else if (objectName == "goldenTouchIcon")
            {
                goldenTouchTimerText = "Chests spawn 6-10 more gold coins for " + SpecialUpgradesButtons.goldenTouchTimer + " seconds";
                goldenTouchDropChance = "";
                goldenTouchPurchaseText = "Click to use a GOLDEN TOUCH";
            }
            #endregion

            #region treasureBag
            //TreasureBag
            else if (objectName == "lockedTreasureBag")
            {
                treasureChestDropChanceText = SpecialUpgradesButtons.treasureBagDropChance.ToString("F2") + "% Chance to drop a treasure bag from a chest ";
                treasureBagPurchaseText = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newTreasureBagPrice) + " Gold";
            }
            else if (objectName == "upgradeTreasureBag")
            {
                treasureChestDropChanceText = SpecialUpgradesButtons.treasureBagDropChance.ToString("F2") + "%<color=green>(+" + SpecialUpgradesButtons.treasureBagDropChanceIncrement.ToString("F3") + "%)<color=white> Chance to drop a treasure bag from a chest ";
                treasureBagPurchaseText = "";
            }
            else if (objectName == "treasureBagIcon")
            {
                treasureChestDropChanceText = SpecialUpgradesButtons.treasureBagDropChance.ToString("F2") + "% Chance to drop a treasure bag from a chest ";
                treasureBagPurchaseText = "Click to spawn a TREASURE BAG the next time a chest is opened";
            }
            #endregion

            #region xpPotion
            //XPPotion
            else if (objectName == "lockedXPPotion")
            {
                XPPotionDropChanceText = SpecialUpgradesButtons.XPPotionDropChance.ToString("F2") + "% Chance to drop from a chest";
                xpPotionBuffText = "Gives +" + (SpecialUpgradesButtons.XPPotionXPBuff * 100).ToString("F0") + "% XP for the next " + SpecialUpgradesButtons.XPPotionTimer + " seconds";
                XPPotionPurchaseText = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newXPPotionPrice) + " Gold";
            }
            else if (objectName == "upgradeXPPotion")
            {
                XPPotionDropChanceText = SpecialUpgradesButtons.XPPotionDropChance.ToString("F2") + "% Chance to drop from a chest " + "<color=green>(+" + SpecialUpgradesButtons.XPPotionDropChanceIncrement.ToString("F3") + "%)<color=green>";

                xpPotionBuffText = "Gives +" + (SpecialUpgradesButtons.XPPotionXPBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.XPPotionBufFIncrement * 100) + "%)<color=white> XP for the next " + SpecialUpgradesButtons.XPPotionTimer + "<color=green>(+" + SpecialUpgradesButtons.XPPotionTimerMinus + "S) <color=white>seconds";
                XPPotionPurchaseText = "";
            }
            else if (objectName == "xpPotionIcon")
            {
                XPPotionDropChanceText = "";
                xpPotionBuffText = "Gives +" + (SpecialUpgradesButtons.XPPotionXPBuff * 100).ToString("F0") + "% XP for the next " + SpecialUpgradesButtons.XPPotionTimer + " seconds";
                XPPotionPurchaseText = "Click to use an XP POTION";
            }
            #endregion

            #region damagePotion
            //DamagePotion
            else if (objectName == "lockedDamagePotion")
            {
                damagePotionDropChanceText = SpecialUpgradesButtons.damagePotionDropChance.ToString("F2") + "% Chance to drop from a chest";
                damagePotionBuffText = "Deal +" + (SpecialUpgradesButtons.damagePotionBuff * 100).ToString("F0") + "% more damage for the next " + SpecialUpgradesButtons.damagePotionTimer + " seconds";
                damagePotionPurchaseText = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newDamagePotionPrice) + " Gold";
            }
            else if (objectName == "upgradeDamagePotion")
            {
                damagePotionDropChanceText = SpecialUpgradesButtons.damagePotionDropChance.ToString("F2") + "% Chance to drop from a chest " + "<color=green>(+" + SpecialUpgradesButtons.damagePotionDropChanceIncrement.ToString("F3") + "%)<color=green>";

                damagePotionBuffText = "Deal +" + (SpecialUpgradesButtons.damagePotionBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.damagePotionBuffIncrement * 100) + "%)<color=white> more damage for the next " + SpecialUpgradesButtons.damagePotionTimer + "<color=green>(+" + SpecialUpgradesButtons.damagePotionTimerMinus + "S) <color=white>seconds";
                damagePotionPurchaseText = "";
            }
            else if (objectName == "damagePotionIcon")
            {
                damagePotionDropChanceText = "";
                damagePotionBuffText = "Deal +" + (SpecialUpgradesButtons.damagePotionBuff * 100).ToString("F0") + "% more damage for the next " + SpecialUpgradesButtons.damagePotionTimer + " seconds";
                damagePotionPurchaseText = "Click to use a DAMAGE POTION";
            }
            #endregion

            #region lootpotion
            //LootPotion
            else if (objectName == "lockedLootPotion")
            {
                lootPotiontDropChanceText = SpecialUpgradesButtons.lootPotionDropChance.ToString("F2") + "% Chance to drop from a chest";
                lootpotionBuffText = "Gives +" + (SpecialUpgradesButtons.lootPotionBuff * 100).ToString("F0") + "% more gold for the next " + SpecialUpgradesButtons.lootPotionTimer + " seconds";

                lootPotionPurchaseText = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newLootPotionPrice) + " Gold";
            }
            else if (objectName == "upgradeLootPotion")
            {
                lootPotiontDropChanceText = SpecialUpgradesButtons.lootPotionDropChance.ToString("F2") + "% Chance to drop from a chest " + "<color=green>(+" + SpecialUpgradesButtons.lootPotionDropChanceIncrement.ToString("F3") + "%)<color=green>";

                lootpotionBuffText = "Gives +" + (SpecialUpgradesButtons.lootPotionBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.lootPotionBuffIncrement * 100) + "%)<color=white> more gold for the next " + SpecialUpgradesButtons.lootPotionTimer + "<color=green>(+" + SpecialUpgradesButtons.lootPotionTimerMinus + "S) <color=white>seconds";
                lootPotionPurchaseText = "";
            }
            else if (objectName == "lootPotionIcon")
            {
                lootPotiontDropChanceText = "";
                lootpotionBuffText = "Gives +" + (SpecialUpgradesButtons.lootPotionBuff * 100).ToString("F0") + "% more gold for the next " + SpecialUpgradesButtons.lootPotionTimer + " seconds";

                lootPotionPurchaseText = "Click to use a LOOT POTION";
            }
            #endregion

            #region minichest
            //MiniChest
            else if (objectName == "lockedMiniChest")
            {
                miniChestTimerText = "Spawns a small clickable chest every " + SpecialUpgradesButtons.miniChestSpawnTimer + " second";

                miniChestPriceText = "Spawn 1 mini chest for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newMiniChestPrice) + " Gold";
            }
            else if (objectName == "upgradeMiniChest")
            {
                miniChestTimerText = "Spawns a small clickable chest every " + SpecialUpgradesButtons.miniChestSpawnTimer + " seconds <color=green>(-" + (SpecialUpgradesButtons.miniChestSpawnTimerMinus) + "S)";

                miniChestPriceText = "";

            }
            #endregion

            #region elixir
            //MiniChest
            else if (objectName == "lockedMagicalElixir")
            {
                elixirDropChance = SpecialUpgradesButtons.elixirDropChance.ToString("F2") + "% Chance to drop from a chest";

                elixirInfo = "Gives +" + (SpecialUpgradesButtons.elixirBuff * 100).ToString("F0") + "% of the buffs from all 3 potions for the next " + SpecialUpgradesButtons.elixirTimer + " seconds";

                elixirPurchase = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newElixirPRice) + " Gold";
            }
            else if (objectName == "upgradeMagicalElixir")
            {
                elixirDropChance = SpecialUpgradesButtons.elixirDropChance.ToString("F2") + "% Chance to drop from a chest<color=green>(+" + SpecialUpgradesButtons.elixirDropChanceIncrement.ToString("F3") + "%)<color=green>";

                elixirInfo = "Gives +" + (SpecialUpgradesButtons.elixirBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.elixirBuffIncrement * 100) + "%)<color=white> of the buffs from all 3 potions for the next " + SpecialUpgradesButtons.elixirTimer + "<color=green>(+" + SpecialUpgradesButtons.elixirTimerIncrement + "S) <color=white>seconds";

                elixirPurchase = "";
            }
            else if (objectName == "elixirIcon")
            {
                elixirDropChance = "";

                elixirInfo = "Gives +" + (SpecialUpgradesButtons.elixirBuff * 100).ToString("F0") + "% of the buffs from all 3 potions for the next " + SpecialUpgradesButtons.elixirTimer + " seconds";

                elixirPurchase = "Click to use a MAGICAL ELIXIR";
            }
            #endregion

            #region scroll
            //MiniChest
            else if (objectName == "lockedScroll")
            {
                scrollDropChance = SpecialUpgradesButtons.scrollDropChance.ToString("F2") + "% Chance to drop from a chest";

                scrollInfo = "Gives a small buff to a random stat for every chest opened for " + SpecialUpgradesButtons.scrollTimer + " seconds";

                scrollPurchase = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newScrollPrice) + " Gold";
            }
            else if (objectName == "upgradeScroll")
            {
                scrollDropChance = SpecialUpgradesButtons.scrollDropChance.ToString("F2") + "% Chance to drop from a chest<color=green>(+" + SpecialUpgradesButtons.scrollDropChanceIncrement.ToString("F3") + "%)<color=green>";

                scrollInfo = "Gives a small buff bonus to a random stat for every chest opened for " + SpecialUpgradesButtons.scrollTimer + "<color=green>(+" + SpecialUpgradesButtons.scrollTimerIncrement + "S) <color=white>seconds";

                scrollPurchase = "";
            }
            else if (objectName == "scrollIcon")
            {
                scrollDropChance = "";

                scrollInfo = "Gives a small buff to a random stat for every chest opened for " + SpecialUpgradesButtons.scrollTimer + " seconds";

                scrollPurchase = "Click to use a SERENDIPITY SCROLL";
            }
            #endregion

            #region gauntlet

            else if (objectName == "lockedGauntletOfGreen")
            {
                gauntletDropChance = SpecialUpgradesButtons.gauntletDropChance.ToString("F2") + "% Chance to drop from a chest";

                gauntletInfo = "Every click has a " + SpecialUpgradesButtons.gauntletGoldDropChance + "% chance to spawn a gold coin for the next " + SpecialUpgradesButtons.gauntletTimer + " seconds";

                gauntletPurchase = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newGauntletPrice) + " Gold";
            }
            else if (objectName == "upgradeGauntlet")
            {
                gauntletDropChance = SpecialUpgradesButtons.gauntletDropChance.ToString("F2") + "% Chance to drop from a chest<color=green>(+" + SpecialUpgradesButtons.gauntletDropChanceIncrement.ToString("F3") + "%)<color=green>";

                gauntletInfo = "Every click has a " + SpecialUpgradesButtons.gauntletGoldDropChance + "%<color=green>(+" + SpecialUpgradesButtons.gauntletGoldDropChanceIncrement + "%)<color=white> chance to spawn a gold coin for the next " + SpecialUpgradesButtons.gauntletTimer + "<color=green>(+" + SpecialUpgradesButtons.gauntletTimerIncrement + "S) seconds";

                gauntletPurchase = "";
            }
            else if (objectName == "gauntletIcon")
            {
                gauntletDropChance = "";

                gauntletInfo = "Every click has a " + SpecialUpgradesButtons.gauntletGoldDropChance + "% chance to spawn a gold coin for the next " + SpecialUpgradesButtons.gauntletTimer + " seconds";

                gauntletPurchase = "Click to use a GAUNTLET OF GREED";
            }
            #endregion

            #region relic
            //MiniChest
            else if (objectName == "lockedAncientRelic")
            {
                relicDropChance = SpecialUpgradesButtons.relicDropChance.ToString("F2") + "% Chance to drop from a chest";

                relicInfo = "Gives a permanent buff to a random stat";

                relicPurchase = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newRelicPrice) + " Gold";
            }
            else if (objectName == "upgradeRelic")
            {
                relicDropChance = SpecialUpgradesButtons.relicDropChance.ToString("F2") + "% Chance to drop from a chest<color=green>(+" + SpecialUpgradesButtons.relicDropChanceIncrement.ToString("F3") + "%)<color=green>";

                relicInfo = "Gives a permanent buff to a random stat";

                relicPurchase = "";
            }
            else if (objectName == "relicIcon")
            {
                relicDropChance = "";

                relicInfo = "Gives a permanent buff to a random stat";

                relicPurchase = "Click to use an ANCIENT RELIC";
            }
            #endregion

            #region knife
            //knife
            else if (objectName == "lockedKnife")
            {
                knifeDropChance = UpdateGame.knifeDropChance.ToString("F2") + "% Chance to drop from a chest";

                knifeInfo = "Each click instantly opens a chest for the next " + UpdateGame.knifeTimer + " seconds and doubles the chest rewards";

                KnifePurhcase = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.knifeBuyPriceDouble) + " Gold";
            }
            else if (objectName == "upgradeKnife")
            {
                knifeDropChance = UpdateGame.knifeDropChance.ToString("F2") + "% Chance to drop from a chest<color=green>(+" + UpdateGame.knifeDropChanceIncrement.ToString("F3") + "%)";

                knifeInfo = "Each click instantly opens a chest for the next " + UpdateGame.knifeTimer + " seconds<color=green>(+" + UpdateGame.knifeTimerIncrement + "S) <color=white>and doubles the chest rewards";

                KnifePurhcase = "";
            }
            else if (objectName == "knifeIcon")
            {
                knifeDropChance = "";

                knifeInfo = "Each click instantly opens a chest for the next " + UpdateGame.knifeTimer + " seconds and doubles the chest rewards";

                KnifePurhcase = "Click to use the ENCHANTED HAMMER";
            }
            #endregion

            #region treasurePotion
            //treasurePotion
            else if (objectName == "lockedTreasurePotion")
            {
                treasurePotionDropChance = UpdateGame.treasurePotionDropChance.ToString("F2") + "% Chance to drop from a chest";

                treasurePotionInfo = "+3% Treasure drop chance for the next " + UpdateGame.treasurePotionTimer + " seconds";

                treasurePotionPurchase = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.treasurePotionBuyPriceDouble) + " Gold";
            }
            else if (objectName == "upgradeTreasurePotion")
            {
                treasurePotionDropChance = UpdateGame.treasurePotionDropChance.ToString("F2") + "% Chance to drop from a chest<color=green>(+" + UpdateGame.treasurePotionDropChanceIncrement.ToString("F3") + "%)";

                treasurePotionInfo = "+3% Treasure drop chance for the next " + UpdateGame.treasurePotionTimer + " seconds<color=green>(+" + UpdateGame.treasurePotionTimerIncrement + "S)";

                treasurePotionPurchase = "";
            }
            else if (objectName == "potionIcon")
            {
                treasurePotionDropChance = "<color=red>Treasure Potions cannot stack";

                treasurePotionInfo = "+3% Treasure drop chance for the next " + UpdateGame.treasurePotionTimer + " seconds";

                treasurePotionPurchase = "Click to use a TREASURE POTION";
            }
            #endregion

            #region barrel
            else if (objectName == "lockedBarrel")
            {
                barrelInfo = "Gold coins that lands inside the barrel is worth " + (UpdateGame.barrelGoldValue + 1) + "X more gold. Click on the barrel to collect the gold";
            }
            else if (objectName == "upgradeBarrel")
            {
                barrelInfo = "Gold coins that lands inside the barrel is worth " + (UpdateGame.barrelGoldValue + 1) + "X<color=green>(+" + UpdateGame.barrelGoldValueIncrement.ToString("F2") + "X)<color=white> more gold. Click on the barrel to collect the gold";
            }
            #endregion

            #region mimicChest
            else if (objectName == "lockedMimicChest")
            {
                mimicChestTimer = "Spawns a <color=red>EVIL<color=white> or <color=green>FRIENDLY<color=white> mimic chest every " + UpdateGame.mimicChestTimer + " seconds";

                mimicChestInfo = UpdateGame.mimicPositiveBuffChance + "% Chance for a temorary positive buff " + UpdateGame.mimicNegativeBuffChance + "% Chance for a temporary negative buff";

                mimicChestPurchase = "Spawn 1 Mimic Chest for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.mimicChestBuyPriceDouble) + " Gold";

            }
            else if (objectName == "upgradeMimicChest")
            {
                mimicChestTimer = "Spawns a <color=red>EVIL<color=white> or <color=green>FRIENDLY<color=white> mimic chest every " + UpdateGame.mimicChestTimer + " seconds<color=green>(-" + UpdateGame.mimicChestTimerIncrement + "S)";

                mimicChestInfo = UpdateGame.mimicPositiveBuffChance + "% Chance <color=green>(+" + UpdateGame.mimicPositiveBiffChanceIncrement + "%)<color=white> for a temorary positive buff\n" + UpdateGame.mimicNegativeBuffChance + "% Chance <color=green>(-" + UpdateGame.mimicNegativeBuffChanceIncrement + "%)<color=white> for a temporary negative buff";

                //text.text = "This text on a line - This text on the line below"

                mimicChestPurchase = "";
            }
            #endregion
        }

        #endregion


        //Russian
        #region RussianLanguage
        if(Localization.RussianLanguageChosen == 1)
        {
            #region lockPick
            //LockPick
            if (objectName == "PurchaseLockPick")
            {
                lockPickOpenChanceText = UseConsumable.lockPickSuccessChance + "% Шанс мгновенно открыть сундук";
                lockPickDropChanceText = SpecialUpgradesButtons.lockPickDropChance.ToString("F2") + "% Шанс выпасть из сундука";
                lockPickPurchaseText = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newLockPickPrice) + " Золота";
            }
            else if (objectName == "LockPickUpgrade")
            {
                lockPickOpenChanceText = UseConsumable.lockPickSuccessChance + "% Шанс мгновенно открыть сундук " + "<color=green>(+" + SpecialUpgradesButtons.lockPickOpenChanceIncrement + "%)<color=green>";
                lockPickDropChanceText = SpecialUpgradesButtons.lockPickDropChance.ToString("F2") + "% Шанс выпасть из сундука " + "<color=green>(+" + SpecialUpgradesButtons.lockPickDropChanceIncrement.ToString("F3") + "%)<color=green>";
                lockPickPurchaseText = "";
            }
            else if (objectName == "lockPickIcon")
            {
                lockPickOpenChanceText = UseConsumable.lockPickSuccessChance + "% Шанс мгновенно открыть сундук ";
                lockPickDropChanceText = "";
                lockPickPurchaseText = "Нажмите, чтобы использовать Отмычку на сундуке";
            }

            #endregion

            #region hammer
            //Hammer
            else if (objectName == "LockedHammerUpgrade")
            {
                hammerDamageText = "Наносит +" + (UseConsumable.hammerDamageMultiplier * 100).ToString("F0") + "% активного урона в течение " + SpecialUpgradesButtons.hammerTimer + " секунд.";
                hammerDropChanceText = SpecialUpgradesButtons.hammerDropChance.ToString("F2") + "% Шанс выпасть из сундука";
                hammerPurchaseText = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newHammerPrice) + " Золота";
                bringBackCursor = "";
            }
            else if (objectName == "UpgradeHammer")
            {
                hammerDamageText = "Наносит +" + (UseConsumable.hammerDamageMultiplier * 100).ToString("F0") + "% <color=green>(+" + (SpecialUpgradesButtons.hammerDamageAmountIncrement * 100) + "%)<color=white>" + " активного урона в течение " + SpecialUpgradesButtons.hammerTimer + " <color=green>(+" + (SpecialUpgradesButtons.hammerTimerIncrement) + ")<color=white> секунд.";

                hammerDropChanceText = SpecialUpgradesButtons.hammerDropChance.ToString("F2") + "% Шанс выпасть из сундука " + "<color=green>(+" + SpecialUpgradesButtons.hammerDropChanceIncrement.ToString("F3") + "%)<color=green>";
                hammerPurchaseText = "";
                bringBackCursor = "";
            }

            else if (objectName == "hammerIcon")
            {
                hammerDamageText = "Наносит +" + (UseConsumable.hammerDamageMultiplier * 100).ToString("F0") + "% активного урона в течение " + SpecialUpgradesButtons.hammerTimer + " секунд.";
                hammerDropChanceText = "";
                hammerPurchaseText = "Нажмите, чтобы использовать МОЛОТ";
                bringBackCursor = "";
            }
            #endregion

            #region key
            //Key
            else if (objectName == "LockedKey")
            {
                keyRareDropChanceText = SpecialUpgradesButtons.keyRareDropChance.ToString("F2") + "% Шанс выпадения сокровища из сундука";
                keyDropChanceText = SpecialUpgradesButtons.keyDropChance + "% Шанс выпасть из сундука";
                keyPurchaseText = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newkeyPrice) + " Золота";
            }
            else if (objectName == "UpgradeKey")
            {
                keyRareDropChanceText = SpecialUpgradesButtons.keyRareDropChance.ToString("F2") + "% Шанс выпадения сокровища из сундука" + "<color=green>(+" + SpecialUpgradesButtons.keyRareDropChanceIncrement + "%)<color=green>";

                keyDropChanceText = SpecialUpgradesButtons.keyDropChance.ToString("F2") + "% Шанс выпасть из сундука " + "<color=green>(+" + SpecialUpgradesButtons.keyDropChanceIncrement.ToString("F3") + "%)<color=green>";
                keyPurchaseText = "";
            }
            else if (objectName == "keyIcon")
            {
                keyRareDropChanceText = SpecialUpgradesButtons.keyRareDropChance.ToString("F2") + "% Шанс выпадения сокровища из сундука";
                keyDropChanceText = "";
                keyPurchaseText = "Нажмите, чтобы использовать КЛЮЧ";
            }
            #endregion

            #region goldentouch
            //GoldenTouch
            else if (objectName == "LockedGoldenTouch")
            {
                goldenTouchTimerText = "Сундуки создают от 6 до 10 дополнительных золотых монет в течение " + SpecialUpgradesButtons.goldenTouchTimer + " секунд";
                goldenTouchDropChance = SpecialUpgradesButtons.goldenTouchDropChance.ToString("F2") + "% Шанс выпасть из сундука";
                goldenTouchPurchaseText = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newGoldenTouchPrice) + " Золота";
            }
            else if (objectName == "UpgradeGoldenTouch")
            {
                goldenTouchTimerText = "Сундуки создают от 6 до 10 дополнительных золотых монет в течение " + SpecialUpgradesButtons.goldenTouchTimer + " <color=green>(+" + SpecialUpgradesButtons.goldenTouchTimerIncrement + ")<color=white>" + " секунд";

                goldenTouchDropChance = SpecialUpgradesButtons.goldenTouchDropChance.ToString("F2") + "% Шанс выпасть из сундука " + "<color=green>(+" + SpecialUpgradesButtons.goldenTouchDropChanceIncrement.ToString("F3") + "%)<color=green>";
                goldenTouchPurchaseText = "";
            }
            else if (objectName == "goldenTouchIcon")
            {
                goldenTouchTimerText = "Сундуки создают от 6 до 10 дополнительных золотых монет в течение " + SpecialUpgradesButtons.goldenTouchTimer + " секунд";
                goldenTouchDropChance = "";
                goldenTouchPurchaseText = "Нажмите, чтобы использовать ЗОЛОТОЕ КАСАНИЕ";
            }
            #endregion

            #region treasureBag
            //TreasureBag
            else if (objectName == "lockedTreasureBag")
            {
                treasureChestDropChanceText = SpecialUpgradesButtons.treasureBagDropChance.ToString("F2") + "% Шанс выпасть мешку с сокровищами из сундука";
                treasureBagPurchaseText = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newTreasureBagPrice) + " Золота";
            }
            else if (objectName == "upgradeTreasureBag")
            {
                treasureChestDropChanceText = SpecialUpgradesButtons.treasureBagDropChance.ToString("F2") + "%<color=green>(+" + SpecialUpgradesButtons.treasureBagDropChanceIncrement.ToString("F3") + "%)<color=white> Шанс выпасть мешку с сокровищами из сундука";
                treasureBagPurchaseText = "";
            }
            else if (objectName == "treasureBagIcon")
            {
                treasureChestDropChanceText = SpecialUpgradesButtons.treasureBagDropChance.ToString("F2") + "% Шанс выпасть мешку с сокровищами из сундука";
                treasureBagPurchaseText = "Нажмите, чтобы создать МЕШОК С СОКРОВИЩАМИ при следующем открытии сундука";
            }
            #endregion

            #region xpPotion
            //XPPotion
            else if (objectName == "lockedXPPotion")
            {
                XPPotionDropChanceText = SpecialUpgradesButtons.XPPotionDropChance.ToString("F2") + "% Шанс выпасть из сундука";
                xpPotionBuffText = "Дает на +" + (SpecialUpgradesButtons.XPPotionXPBuff * 100).ToString("F0") + "% больше опыта на следующие " + SpecialUpgradesButtons.XPPotionTimer + " секунд";
                XPPotionPurchaseText = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newXPPotionPrice) + " Золота";
            }
            else if (objectName == "upgradeXPPotion")
            {
                XPPotionDropChanceText = SpecialUpgradesButtons.XPPotionDropChance.ToString("F2") + "% Шанс выпасть из сундука " + "<color=green>(+" + SpecialUpgradesButtons.XPPotionDropChanceIncrement.ToString("F3") + "%)<color=green>";

                xpPotionBuffText = "Дает на +" + (SpecialUpgradesButtons.XPPotionXPBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.XPPotionBufFIncrement * 100) + "%)<color=white> больше опыта на следующие " + SpecialUpgradesButtons.XPPotionTimer + "<color=green>(+" + SpecialUpgradesButtons.XPPotionTimerMinus + ") <color=white>секунд";
                XPPotionPurchaseText = "";
            }
            else if (objectName == "xpPotionIcon")
            {
                XPPotionDropChanceText = "";
                xpPotionBuffText = "Дает на +" + (SpecialUpgradesButtons.XPPotionXPBuff * 100).ToString("F0") + "% больше опыта на следующие " + SpecialUpgradesButtons.XPPotionTimer + " секунд";
                XPPotionPurchaseText = "Нажмите, чтобы использовать ЗЕЛЬЕ ОПЫТА";
            }
            #endregion

            #region damagePotion
            //DamagePotion
            else if (objectName == "lockedDamagePotion")
            {
                damagePotionDropChanceText = SpecialUpgradesButtons.damagePotionDropChance.ToString("F2") + "% Шанс выпасть из сундука";
                damagePotionBuffText = "Наносите на +" + (SpecialUpgradesButtons.damagePotionBuff * 100).ToString("F0") + "% больше урона в течение следующих " + SpecialUpgradesButtons.damagePotionTimer + " секунд";
                damagePotionPurchaseText = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newDamagePotionPrice) + " Золота";
            }
            else if (objectName == "upgradeDamagePotion")
            {
                damagePotionDropChanceText = SpecialUpgradesButtons.damagePotionDropChance.ToString("F2") + "% Шанс выпасть из сундука " + "<color=green>(+" + SpecialUpgradesButtons.damagePotionDropChanceIncrement.ToString("F3") + "%)<color=green>";

                damagePotionBuffText = "Наносите на +" + (SpecialUpgradesButtons.damagePotionBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.damagePotionBuffIncrement * 100) + "%)<color=white> больше урона в течение следующих " + SpecialUpgradesButtons.damagePotionTimer + "<color=green>(+" + SpecialUpgradesButtons.damagePotionTimerMinus + ") <color=white>секунд";
                damagePotionPurchaseText = "";
            }
            else if (objectName == "damagePotionIcon")
            {
                damagePotionDropChanceText = "";
                damagePotionBuffText = "Наносите на +" + (SpecialUpgradesButtons.damagePotionBuff * 100).ToString("F0") + "% больше урона в течение следующих " + SpecialUpgradesButtons.damagePotionTimer + " секунд";
                damagePotionPurchaseText = "Нажмите, чтобы использовать ЗЕЛЬЕ УРОНА";
            }
            #endregion

            #region lootpotion
            //LootPotion
            else if (objectName == "lockedLootPotion")
            {
                lootPotiontDropChanceText = SpecialUpgradesButtons.lootPotionDropChance.ToString("F2") + "% Шанс выпасть из сундука";
                lootpotionBuffText = "Дает на +" + (SpecialUpgradesButtons.lootPotionBuff * 100).ToString("F0") + "% больше золота на следующие " + SpecialUpgradesButtons.lootPotionTimer + " секунд";

                lootPotionPurchaseText = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newLootPotionPrice) + " Золота";
            }
            else if (objectName == "upgradeLootPotion")
            {
                lootPotiontDropChanceText = SpecialUpgradesButtons.lootPotionDropChance.ToString("F2") + "% Шанс выпасть из сундука " + "<color=green>(+" + SpecialUpgradesButtons.lootPotionDropChanceIncrement.ToString("F3") + "%)<color=green>";

                lootpotionBuffText = "Дает на +" + (SpecialUpgradesButtons.lootPotionBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.lootPotionBuffIncrement * 100) + "%)<color=white> больше золота на следующие " + SpecialUpgradesButtons.lootPotionTimer + "<color=green>(+" + SpecialUpgradesButtons.lootPotionTimerMinus + ") <color=white>секунд";
                lootPotionPurchaseText = "";
            }
            else if (objectName == "lootPotionIcon")
            {
                lootPotiontDropChanceText = "";
                lootpotionBuffText = "Дает на +" + (SpecialUpgradesButtons.lootPotionBuff * 100).ToString("F0") + "% больше золота на следующие " + SpecialUpgradesButtons.lootPotionTimer + " секунд";

                lootPotionPurchaseText = "Нажмите, чтобы использовать ЗЕЛЬЕ ЛУТА";
            }
            #endregion

            #region minichest
            //MiniChest
            else if (objectName == "lockedMiniChest")
            {
                miniChestTimerText = "Создает маленький, на который можно нажать, сундук каждые " + SpecialUpgradesButtons.miniChestSpawnTimer + " секунд";

                miniChestPriceText = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newMiniChestPrice) + " Золота";
            }
            else if (objectName == "upgradeMiniChest")
            {
                miniChestTimerText = "Создает маленький, на который можно нажать, сундук каждые " + SpecialUpgradesButtons.miniChestSpawnTimer + " секунд <color=green>(-" + (SpecialUpgradesButtons.miniChestSpawnTimerMinus) + ")";

                miniChestPriceText = "";

            }
            #endregion

            #region elixir
            //MiniChest
            else if (objectName == "lockedMagicalElixir")
            {
                elixirDropChance = SpecialUpgradesButtons.elixirDropChance.ToString("F2") + "% Шанс выпасть из сундука";

                elixirInfo = "Дает +" + (SpecialUpgradesButtons.elixirBuff * 100).ToString("F0") + "% баффов от всех трех зелий на следующие " + SpecialUpgradesButtons.elixirTimer + " секунд";

                elixirPurchase = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newElixirPRice) + " Золота";
            }
            else if (objectName == "upgradeMagicalElixir")
            {
                elixirDropChance = SpecialUpgradesButtons.elixirDropChance.ToString("F2") + "% Шанс выпасть из сундука<color=green>(+" + SpecialUpgradesButtons.elixirDropChanceIncrement.ToString("F3") + "%)<color=green>";

                elixirInfo = "Дает +" + (SpecialUpgradesButtons.elixirBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.elixirBuffIncrement * 100) + "%)<color=white> баффов от всех трех зелий на следующие " + SpecialUpgradesButtons.elixirTimer + "<color=green>(+" + SpecialUpgradesButtons.elixirTimerIncrement + ") <color=white>секунд";

                elixirPurchase = "";
            }
            else if (objectName == "elixirIcon")
            {
                elixirDropChance = "";

                elixirInfo = "Дает +" + (SpecialUpgradesButtons.elixirBuff * 100).ToString("F0") + "% баффов от всех трех зелий на следующие " + SpecialUpgradesButtons.elixirTimer + " секунд";

                elixirPurchase = "Нажмите, чтобы использовать ЭЛИКСИР";
            }
            #endregion

            #region scroll
            //MiniChest
            else if (objectName == "lockedScroll")
            {
                scrollDropChance = SpecialUpgradesButtons.scrollDropChance.ToString("F2") + "% Шанс выпасть из сундука";

                scrollInfo = "Дает небольшой бафф к случайной характеристике для каждого открытого сундука на протяжении " + SpecialUpgradesButtons.scrollTimer + " секунд";

                scrollPurchase = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newScrollPrice) + " Золота";
            }
            else if (objectName == "upgradeScroll")
            {
                scrollDropChance = SpecialUpgradesButtons.scrollDropChance.ToString("F2") + "% Шанс выпасть из сундука<color=green>(+" + SpecialUpgradesButtons.scrollDropChanceIncrement.ToString("F3") + "%)<color=green>";

                scrollInfo = "Дает небольшой бафф к случайной характеристике для каждого открытого сундука на протяжении " + SpecialUpgradesButtons.scrollTimer + "<color=green>(+" + SpecialUpgradesButtons.scrollTimerIncrement + ") <color=white>секунд";

                scrollPurchase = "";
            }
            else if (objectName == "scrollIcon")
            {
                scrollDropChance = "";

                scrollInfo = "Дает небольшой бафф к случайной характеристике для каждого открытого сундука на протяжении " + SpecialUpgradesButtons.scrollTimer + " секунд";

                scrollPurchase = "Нажмите, чтобы использовать СВИТОК УДАЧИ";
            }
            #endregion

            #region gauntlet

            else if (objectName == "lockedGauntletOfGreen")
            {
                gauntletDropChance = SpecialUpgradesButtons.gauntletDropChance.ToString("F2") + "% Шанс выпасть из сундука";

                gauntletInfo = "Каждый клик с " + SpecialUpgradesButtons.gauntletGoldDropChance + "% шансом создает золотую монету на следующие " + SpecialUpgradesButtons.gauntletTimer + " секунд";

                gauntletPurchase = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newGauntletPrice) + " Золота";
            }
            else if (objectName == "upgradeGauntlet")
            {
                gauntletDropChance = SpecialUpgradesButtons.gauntletDropChance.ToString("F2") + "% Шанс выпасть из сундука<color=green>(+" + SpecialUpgradesButtons.gauntletDropChanceIncrement.ToString("F3") + "%)<color=green>";

                gauntletInfo = "Каждый клик с " + SpecialUpgradesButtons.gauntletGoldDropChance + "%<color=green>(+" + SpecialUpgradesButtons.gauntletGoldDropChanceIncrement + "%)<color=white> шансом создает золотую монету на следующие " + SpecialUpgradesButtons.gauntletTimer + "<color=green>(+" + SpecialUpgradesButtons.gauntletTimerIncrement + ") секунд";

                gauntletPurchase = "";
            }
            else if (objectName == "gauntletIcon")
            {
                gauntletDropChance = "";

                gauntletInfo = "Каждый клик с " + SpecialUpgradesButtons.gauntletGoldDropChance + "% шансом создает золотую монету на следующие " + SpecialUpgradesButtons.gauntletTimer + " секунд";

                gauntletPurchase = "Нажмите, чтобы использовать РУКАВИЦУ АЛЧНОСТИ";
            }
            #endregion

            #region relic
            //MiniChest
            else if (objectName == "lockedAncientRelic")
            {
                relicDropChance = SpecialUpgradesButtons.relicDropChance.ToString("F2") + "% Шанс выпасть из сундука";


                relicPurchase = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newRelicPrice) + " Золота";
            }
            else if (objectName == "upgradeRelic")
            {
                relicDropChance = SpecialUpgradesButtons.relicDropChance.ToString("F2") + "% Шанс выпасть из сундука<color=green>(+" + SpecialUpgradesButtons.relicDropChanceIncrement.ToString("F3") + "%)<color=green>";

                relicPurchase = "";
            }
            else if (objectName == "relicIcon")
            {
                relicDropChance = "";

                relicPurchase = "Нажмите, чтобы использовать ДРЕВНЮЮ РЕЛИКВИЮ";
            }
            #endregion

            #region knife
            //knife
            else if (objectName == "lockedKnife")
            {
                knifeDropChance = UpdateGame.knifeDropChance.ToString("F2") + "% Шанс выпасть из сундука";

                knifeInfo = "Каждый клик мгновенно открывает сундук в течение следующих " + UpdateGame.knifeTimer + " секунд и удваивает награды с сундука";

                KnifePurhcase = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.knifeBuyPriceDouble) + " Золота";
            }
            else if (objectName == "upgradeKnife")
            {
                knifeDropChance = UpdateGame.knifeDropChance.ToString("F2") + "% Chance to drop from a chest<color=green>(+" + UpdateGame.knifeDropChanceIncrement.ToString("F3") + "%)";

                knifeInfo = "Каждый клик мгновенно открывает сундук в течение следующих " + UpdateGame.knifeTimer + " seconds<color=green>(+" + UpdateGame.knifeTimerIncrement + ") <color=white>секунд и удваивает награды с сундука";

                KnifePurhcase = "";
            }
            else if (objectName == "knifeIcon")
            {
                knifeDropChance = "";

                knifeInfo = "Каждый клик мгновенно открывает сундук в течение следующих " + UpdateGame.knifeTimer + " секунд и удваивает награды с сундука";

                KnifePurhcase = "Нажмите, чтобы использовать ЗАЧАРОВАННЫЙ МОЛОТ";
            }
            #endregion

            #region treasurePotion
            //treasurePotion
            else if (objectName == "lockedTreasurePotion")
            {
                treasurePotionDropChance = UpdateGame.treasurePotionDropChance.ToString("F2") + "% Шанс выпасть из сундука";

                treasurePotionInfo = "+3%  шанса на выпадение сокровища на следующие " + UpdateGame.treasurePotionTimer + " секунд";

                treasurePotionPurchase = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.treasurePotionBuyPriceDouble) + " Золота";
            }
            else if (objectName == "upgradeTreasurePotion")
            {
                treasurePotionDropChance = UpdateGame.treasurePotionDropChance.ToString("F2") + "% Шанс выпасть из сундука<color=green>(+" + UpdateGame.treasurePotionDropChanceIncrement.ToString("F3") + "%)";

                treasurePotionInfo = "+3%  шанса на выпадение сокровища на следующие " + UpdateGame.treasurePotionTimer + " секунд<color=green>(+" + UpdateGame.treasurePotionTimerIncrement + ")";

                treasurePotionPurchase = "";
            }
            else if (objectName == "potionIcon")
            {
                treasurePotionDropChance = "<color=red>Зелье сокровищ не складывается!";

                treasurePotionInfo = "+3%  шанса на выпадение сокровища на следующие " + UpdateGame.treasurePotionTimer + " секунд";

                treasurePotionPurchase = "Нажмите, чтобы использовать ЗЕЛЬЕ СОКРОВИЩ";
            }
            #endregion

            #region barrel
            else if (objectName == "lockedBarrel")
            {
                barrelInfo = "Золотые монеты, попавшие в бочонок, стоят в " + (UpdateGame.barrelGoldValue + 1) + "X раза дороже. Нажмите на бочонок, чтобы собрать золото";
            }
            else if (objectName == "upgradeBarrel")
            {
                barrelInfo = "Золотые монеты, попавшие в бочонок, стоят в " + (UpdateGame.barrelGoldValue + 1) + "X<color=green>(+" + UpdateGame.barrelGoldValueIncrement.ToString("F2") + "X)<color=white> раза дороже. Нажмите на бочонок, чтобы собрать золото";
            }
            #endregion

            #region mimicChest
            else if (objectName == "lockedMimicChest")
            {
                mimicChestTimer = "Появляется <color=red>ЗЛОБНЫЙ <color=white> или <color=green>ДОБРЫЙ<color=white> сундук-мимик каждые " + UpdateGame.mimicChestTimer + " секунд";

                mimicChestInfo = UpdateGame.mimicPositiveBuffChance + "% шанс на временный положительный бафф \n" + UpdateGame.mimicNegativeBuffChance + "% шанс на временный отрицательный бафф";

                mimicChestPurchase = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.mimicChestBuyPriceDouble) + " Золота";

            }
            else if (objectName == "upgradeMimicChest")
            {
                mimicChestTimer = "Появляется <color=red>ЗЛОБНЫЙ <color=white> или <color=green>ДОБРЫЙ<color=white> сундук-мимик каждые " + UpdateGame.mimicChestTimer + " секунд<color=green>(-" + UpdateGame.mimicChestTimerIncrement + ")";

                mimicChestInfo = UpdateGame.mimicPositiveBuffChance + "% шанс на <color=green>(+" + UpdateGame.mimicPositiveBiffChanceIncrement + "%)<color=white> временный положительный бафф\n" + UpdateGame.mimicNegativeBuffChance + "% шанс на <color=green>(-" + UpdateGame.mimicNegativeBuffChanceIncrement + "%)<color=white> временный отрицательный бафф";

                //text.text = "This text on a line - This text on the line below"

                mimicChestPurchase = "";
            }
            #endregion
        }
        #endregion


        //Japanese
        #region Japanese Language
        if (Localization.JapaneseLanguageChosen == 1)
        {
            #region lockPick
            //LockPick
            if (objectName == "PurchaseLockPick")
            {
                lockPickOpenChanceText = "即座に胸を開くために" + UseConsumable.lockPickSuccessChance + "％のチャンス";
                lockPickDropChanceText = "胸から落ちる確率" + SpecialUpgradesButtons.lockPickDropChance.ToString("F2") + "%";
                lockPickPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newLockPickPrice) + "金のための購入";
            }
            else if (objectName == "LockPickUpgrade")
            {
                lockPickOpenChanceText = "即座に胸を開くために" + UseConsumable.lockPickSuccessChance + "％のチャンス" + "<color=green>(+" + SpecialUpgradesButtons.lockPickOpenChanceIncrement + "%)<color=green>";
                lockPickDropChanceText = "胸から落ちる確率" + SpecialUpgradesButtons.lockPickDropChance.ToString("F2") + "%" + "<color=green>(+" + SpecialUpgradesButtons.lockPickDropChanceIncrement.ToString("F3") + "%)<color=green>";
                lockPickPurchaseText = "";
            }
            else if (objectName == "lockPickIcon")
            {
                lockPickOpenChanceText = "即座に胸を開くために" + UseConsumable.lockPickSuccessChance + "％のチャンス";
                lockPickDropChanceText = "";
                lockPickPurchaseText = "胸にロックピックを使用するにはクリックします";
            }

            #endregion

            #region hammer
            //Hammer
            else if (objectName == "LockedHammerUpgrade")
            {
                hammerDamageText = "" + (UseConsumable.hammerDamageMultiplier * 100).ToString("F0") + "%のアクティブダメージを" + SpecialUpgradesButtons.hammerTimer + " 秒間与える";
                hammerDropChanceText = "胸から落ちる確率" + SpecialUpgradesButtons.hammerDropChance.ToString("F2") + "%";
                hammerPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newHammerPrice) + "金のための購入";
                bringBackCursor = "";
            }
            else if (objectName == "UpgradeHammer")
            {
                hammerDamageText = "" + (UseConsumable.hammerDamageMultiplier * 100).ToString("F0") + "% <color=green>(+" + (SpecialUpgradesButtons.hammerDamageAmountIncrement * 100) + "%)<color=white>" + "のアクティブダメージを" + SpecialUpgradesButtons.hammerTimer + " <color=green>(+" + (SpecialUpgradesButtons.hammerTimerIncrement) + ")<color=white>秒間与える";

                hammerDropChanceText = "胸から落ちる確率" + SpecialUpgradesButtons.hammerDropChance.ToString("F2") + "%" + "<color=green>(+" + SpecialUpgradesButtons.hammerDropChanceIncrement.ToString("F3") + "%)<color=green>";
                hammerPurchaseText = "";
                bringBackCursor = "";
            }

            else if (objectName == "hammerIcon")
            {
                hammerDamageText = "" + (UseConsumable.hammerDamageMultiplier * 100).ToString("F0") + "%のアクティブダメージを" + SpecialUpgradesButtons.hammerTimer + " 秒間与える";
                hammerDropChanceText = "";
                hammerPurchaseText = "クリックしてハンマーを使用します";
                bringBackCursor = "";
            }
            #endregion

            #region key
            //Key
            else if (objectName == "LockedKey")
            {
                keyRareDropChanceText = SpecialUpgradesButtons.keyRareDropChance.ToString("F2") + "%胸から宝をドロップするチャンス";
                keyDropChanceText = "胸から落ちる確率" + SpecialUpgradesButtons.keyDropChance + "%";
                keyPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newkeyPrice) + "金のための購入";
            }
            else if (objectName == "UpgradeKey")
            {
                keyRareDropChanceText = SpecialUpgradesButtons.keyRareDropChance.ToString("F2") + "%胸から宝をドロップするチャンス" + "<color=green>(+" + SpecialUpgradesButtons.keyRareDropChanceIncrement + "%)<color=green>";

                keyDropChanceText = "胸から落ちる確率" + SpecialUpgradesButtons.keyDropChance.ToString("F2") + "%" + "<color=green>(+" + SpecialUpgradesButtons.keyDropChanceIncrement.ToString("F3") + "%)<color=green>";
                keyPurchaseText = "";
            }
            else if (objectName == "keyIcon")
            {
                keyRareDropChanceText = SpecialUpgradesButtons.keyRareDropChance.ToString("F2") + "%胸から宝をドロップするチャンス";
                keyDropChanceText = "";
                keyPurchaseText = "キーを使用するにはクリックします";
            }
            #endregion

            #region goldentouch
            //GoldenTouch
            else if (objectName == "LockedGoldenTouch")
            {
                goldenTouchTimerText = "チェストは6-10秒のためのより多くの金貨をスポーン" + SpecialUpgradesButtons.goldenTouchTimer + "";
                goldenTouchDropChance = "胸から落ちる確率" + SpecialUpgradesButtons.goldenTouchDropChance.ToString("F2") + "%";
                goldenTouchPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newGoldenTouchPrice) + "金のための購入";
            }
            else if (objectName == "UpgradeGoldenTouch")
            {
                goldenTouchTimerText = "チェストは6-10秒のためのより多くの金貨をスポーン" + SpecialUpgradesButtons.goldenTouchTimer + " <color=green>(+" + SpecialUpgradesButtons.goldenTouchTimerIncrement + ")<color=white>" + "";

                goldenTouchDropChance = "胸から落ちる確率" + SpecialUpgradesButtons.goldenTouchDropChance.ToString("F2") + "%" + "<color=green>(+" + SpecialUpgradesButtons.goldenTouchDropChanceIncrement.ToString("F3") + "%)<color=green>";
                goldenTouchPurchaseText = "";
            }
            else if (objectName == "goldenTouchIcon")
            {
                goldenTouchTimerText = "チェストは6-10秒のためのより多くの金貨をスポーン" + SpecialUpgradesButtons.goldenTouchTimer + "";
                goldenTouchDropChance = "";
                goldenTouchPurchaseText = "金色のタッチを使用するには、クリックしてください";
            }
            #endregion

            #region treasureBag
            //TreasureBag
            else if (objectName == "lockedTreasureBag")
            {
                treasureChestDropChanceText = "宝の袋を胸から落とす確率" + SpecialUpgradesButtons.treasureBagDropChance.ToString("F2") + "%";
                treasureBagPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newTreasureBagPrice) + "金のための購入";
            }
            else if (objectName == "upgradeTreasureBag")
            {
                treasureChestDropChanceText = "宝の袋を胸から落とす確率" + SpecialUpgradesButtons.treasureBagDropChance.ToString("F2") + "%<color=green>(+" + SpecialUpgradesButtons.treasureBagDropChanceIncrement.ToString("F3") + "%)";
                treasureBagPurchaseText = "";
            }
            else if (objectName == "treasureBagIcon")
            {
                treasureChestDropChanceText = "宝の袋を胸から落とす確率" + SpecialUpgradesButtons.treasureBagDropChance.ToString("F2") + "%";
                treasureBagPurchaseText = "次に胸を開いたときに宝の袋をスポーンするには、をクリックします";
            }
            #endregion

            #region xpPotion
            //XPPotion
            else if (objectName == "lockedXPPotion")
            {
                XPPotionDropChanceText = "胸から落ちる確率" + SpecialUpgradesButtons.XPPotionDropChance.ToString("F2") + "%";
                xpPotionBuffText = "+" + (SpecialUpgradesButtons.XPPotionXPBuff * 100).ToString("F0") + "%XP" + SpecialUpgradesButtons.XPPotionTimer + "秒";
                XPPotionPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newXPPotionPrice) + "金のための購入";
            }
            else if (objectName == "upgradeXPPotion")
            {
                XPPotionDropChanceText = "胸から落ちる確率" + SpecialUpgradesButtons.XPPotionDropChance.ToString("F2") + "%" + "<color=green>(+" + SpecialUpgradesButtons.XPPotionDropChanceIncrement.ToString("F3") + "%)<color=green>";

                xpPotionBuffText = "+" + (SpecialUpgradesButtons.XPPotionXPBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.XPPotionBufFIncrement * 100) + "%)<color=white>%XP" + SpecialUpgradesButtons.XPPotionTimer + "<color=green>(+" + SpecialUpgradesButtons.XPPotionTimerMinus + "秒";
                XPPotionPurchaseText = "";
            }
            else if (objectName == "xpPotionIcon")
            {
                XPPotionDropChanceText = "";
                xpPotionBuffText = "+" + (SpecialUpgradesButtons.XPPotionXPBuff * 100).ToString("F0") + "%%XP" + SpecialUpgradesButtons.XPPotionTimer + "秒";
                XPPotionPurchaseText = "XPポーションを使用するにはクリックしてください";
            }
            #endregion

            #region damagePotion
            //DamagePotion
            else if (objectName == "lockedDamagePotion")
            {
                damagePotionDropChanceText = "胸から落ちる確率" + SpecialUpgradesButtons.damagePotionDropChance.ToString("F2") + "%";
                damagePotionBuffText = "+" + (SpecialUpgradesButtons.damagePotionBuff * 100).ToString("F0") + "%ダメージ" + SpecialUpgradesButtons.damagePotionTimer + "秒";
                damagePotionPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newDamagePotionPrice) + "金のための購入";
            }
            else if (objectName == "upgradeDamagePotion")
            {
                damagePotionDropChanceText = "胸から落ちる確率" + SpecialUpgradesButtons.damagePotionDropChance.ToString("F2") + "%" + "<color=green>(+" + SpecialUpgradesButtons.damagePotionDropChanceIncrement.ToString("F3") + "%)<color=green>";

                damagePotionBuffText = "+" + (SpecialUpgradesButtons.damagePotionBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.damagePotionBuffIncrement * 100) + "%)<color=white>ダメージ" + SpecialUpgradesButtons.damagePotionTimer + "<color=green>(+" + SpecialUpgradesButtons.damagePotionTimerMinus + ")<color=white>秒";
                damagePotionPurchaseText = "";
            }
            else if (objectName == "damagePotionIcon")
            {
                damagePotionDropChanceText = "";
                damagePotionBuffText = "+" + (SpecialUpgradesButtons.damagePotionBuff * 100).ToString("F0") + "%ダメージ" + SpecialUpgradesButtons.damagePotionTimer + "秒";
                damagePotionPurchaseText = "ダメージポーションを使用するにはクリックしてください";
            }
            #endregion

            #region lootpotion
            //LootPotion
            else if (objectName == "lockedLootPotion")
            {
                lootPotiontDropChanceText = "胸から落ちる確率" + SpecialUpgradesButtons.lootPotionDropChance.ToString("F2") + "%";
                lootpotionBuffText = "+" + (SpecialUpgradesButtons.lootPotionBuff * 100).ToString("F0") + "%ゴールド" + SpecialUpgradesButtons.lootPotionTimer + "秒";

                lootPotionPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newLootPotionPrice) + "金のための購入";
            }
            else if (objectName == "upgradeLootPotion")
            {
                lootPotiontDropChanceText = "胸から落ちる確率" + SpecialUpgradesButtons.lootPotionDropChance.ToString("F2") + "%" + "<color=green>(+" + SpecialUpgradesButtons.lootPotionDropChanceIncrement.ToString("F3") + "%)<color=green>";

                lootpotionBuffText = "+" + (SpecialUpgradesButtons.lootPotionBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.lootPotionBuffIncrement * 100) + "%)<color=white>ゴールド" + SpecialUpgradesButtons.lootPotionTimer + "<color=green>(+" + SpecialUpgradesButtons.lootPotionTimerMinus + ")<color=white>秒";
                lootPotionPurchaseText = "";
            }
            else if (objectName == "lootPotionIcon")
            {
                lootPotiontDropChanceText = "";
                lootpotionBuffText = "" + (SpecialUpgradesButtons.lootPotionBuff * 100).ToString("F0") + "%ゴールド" + SpecialUpgradesButtons.lootPotionTimer + "秒";

                lootPotionPurchaseText = "クリックして戦利品のポーションを使用します";
            }
            #endregion

            #region minichest
            //MiniChest
            else if (objectName == "lockedMiniChest")
            {
                miniChestTimerText = "クリック可能な小さな胸を" + SpecialUpgradesButtons.miniChestSpawnTimer + "秒ごとにスポーンします";

                miniChestPriceText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newMiniChestPrice) + "金のための購入";
            }
            else if (objectName == "upgradeMiniChest")
            {
                miniChestTimerText = "クリック可能な小さな胸を" + SpecialUpgradesButtons.miniChestSpawnTimer + "秒ごとにスポーンします<color=green>(-" + (SpecialUpgradesButtons.miniChestSpawnTimerMinus) + ")";

                miniChestPriceText = "";

            }
            #endregion

            #region elixir
            //MiniChest
            else if (objectName == "lockedMagicalElixir")
            {
                elixirDropChance = "胸から落ちる確率" + SpecialUpgradesButtons.elixirDropChance.ToString("F2") + "%";

                elixirInfo = "与える+" + (SpecialUpgradesButtons.elixirBuff * 100).ToString("F0") + "%すべてからのバフの3次のためのポーション" + SpecialUpgradesButtons.elixirTimer + "秒";

                elixirPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newElixirPRice) + "金のための購入";
            }
            else if (objectName == "upgradeMagicalElixir")
            {
                elixirDropChance = "胸から落ちる確率" + SpecialUpgradesButtons.elixirDropChance.ToString("F2") + "%<color=green>(+" + SpecialUpgradesButtons.elixirDropChanceIncrement.ToString("F3") + "%)<color=green>";

                elixirInfo = "与える+" + (SpecialUpgradesButtons.elixirBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.elixirBuffIncrement * 100) + "%)<color=white>すべてからのバフの3次のためのポーション" + SpecialUpgradesButtons.elixirTimer + "<color=green>(+" + SpecialUpgradesButtons.elixirTimerIncrement + ")<color=white>秒";

                elixirPurchase = "";
            }
            else if (objectName == "elixirIcon")
            {
                elixirDropChance = "";

                elixirInfo = "与える+" + (SpecialUpgradesButtons.elixirBuff * 100).ToString("F0") + "%すべてからのバフの3次のためのポーション" + SpecialUpgradesButtons.elixirTimer + "秒";

                elixirPurchase = "エリクサーを使用するにはクリックしてください";
            }
            #endregion

            #region scroll
            //MiniChest
            else if (objectName == "lockedScroll")
            {
                scrollDropChance = "胸から落ちる確率" + SpecialUpgradesButtons.scrollDropChance.ToString("F2") + "%";

                scrollInfo = "" + SpecialUpgradesButtons.scrollTimer + "秒間開いたすべての胸のランダムな統計に小さなバフを与えます";

                scrollPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newScrollPrice) + "金のための購入";
            }
            else if (objectName == "upgradeScroll")
            {
                scrollDropChance = "胸から落ちる確率" + SpecialUpgradesButtons.scrollDropChance.ToString("F2") + "%<color=green>(+" + SpecialUpgradesButtons.scrollDropChanceIncrement.ToString("F3") + "%)<color=green>";

                scrollInfo = "" + SpecialUpgradesButtons.scrollTimer + "<color=green>(+" + SpecialUpgradesButtons.scrollTimerIncrement + ")<color=white>秒間開いたすべての胸のランダムな統計に小さなバフを与えます";

                scrollPurchase = "";
            }
            else if (objectName == "scrollIcon")
            {
                scrollDropChance = "";

                scrollInfo = "" + SpecialUpgradesButtons.scrollTimer + "秒間開いたすべての胸のランダムな統計に小さなバフを与えます";

                scrollPurchase = "クリックしてセレンディピティスクロールを使用します";
            }
            #endregion

            #region gauntlet

            else if (objectName == "lockedGauntletOfGreen")
            {
                gauntletDropChance = "胸から落ちる確率" + SpecialUpgradesButtons.gauntletDropChance.ToString("F2") + "%";

                gauntletInfo = "すべてのクリックは、次の" + SpecialUpgradesButtons.gauntletTimer + "秒間金貨をスポーンする" + SpecialUpgradesButtons.gauntletGoldDropChance + "%のチャンスを持っています";

                gauntletPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newGauntletPrice) + "金のための購入";
            }
            else if (objectName == "upgradeGauntlet")
            {
                gauntletDropChance = "胸から落ちる確率" + SpecialUpgradesButtons.gauntletDropChance.ToString("F2") + "%<color=green>(+" + SpecialUpgradesButtons.gauntletDropChanceIncrement.ToString("F3") + "%)<color=green>";

                gauntletInfo = "すべてのクリックは、次の" + SpecialUpgradesButtons.gauntletTimer + "%<color=green>(+" + SpecialUpgradesButtons.gauntletTimerIncrement + ")<color=white>秒間金貨をスポーンする" + SpecialUpgradesButtons.gauntletGoldDropChance + "%<color=green>(+" + SpecialUpgradesButtons.gauntletGoldDropChanceIncrement + ")<color=white>のチャンスを持っています";

                gauntletPurchase = "";
            }
            else if (objectName == "gauntletIcon")
            {
                gauntletDropChance = "";

                gauntletInfo = "すべてのクリックは、次の" + SpecialUpgradesButtons.gauntletTimer + "秒間金貨をスポーンする" + SpecialUpgradesButtons.gauntletGoldDropChance + "%のチャンスを持っています";

                gauntletPurchase = "クリックして欲のガントレットを使用します";
            }
            #endregion

            #region relic
            //MiniChest
            else if (objectName == "lockedAncientRelic")
            {
                relicDropChance = "胸から落ちる確率" + SpecialUpgradesButtons.relicDropChance.ToString("F2") + "%";

                relicInfo = "ランダムな統計に永続的なバフを与えます";

                relicPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newRelicPrice) + "金のための購入";
            }
            else if (objectName == "upgradeRelic")
            {
                relicDropChance = "胸から落ちる確率" + SpecialUpgradesButtons.relicDropChance.ToString("F2") + "%<color=green>(+" + SpecialUpgradesButtons.relicDropChanceIncrement.ToString("F3") + "%)<color=green>";

                relicInfo = "ランダムな統計に永続的なバフを与えます";

                relicPurchase = "";
            }
            else if (objectName == "relicIcon")
            {
                relicDropChance = "";

                relicInfo = "ランダムな統計に永続的なバフを与えます";

                relicPurchase = "古代の遺物を使用するにはクリックしてください";
            }
            #endregion

            #region knife
            //knife
            else if (objectName == "lockedKnife")
            {
                knifeDropChance = "胸から落ちる確率" + UpdateGame.knifeDropChance.ToString("F2") + "%";

                knifeInfo = "クリックするたびにすぐに次の" + UpdateGame.knifeTimer + "秒間胸が開き、胸の報酬が2倍になります";

                KnifePurhcase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.knifeBuyPriceDouble) + "金のための購入";
            }
            else if (objectName == "upgradeKnife")
            {
                knifeDropChance = "胸から落ちる確率" + UpdateGame.knifeDropChance.ToString("F2") + "%<color=green>(+" + UpdateGame.knifeDropChanceIncrement.ToString("F3") + "%)";

                knifeInfo = "クリックするたびにすぐに次の" + UpdateGame.knifeTimer + "秒間胸が開き、胸の報酬が2倍になります<color=green>(+" + UpdateGame.knifeTimerIncrement + ")";

                KnifePurhcase = "";
            }
            else if (objectName == "knifeIcon")
            {
                knifeDropChance = "";

                knifeInfo = "クリックするたびにすぐに次の" + UpdateGame.knifeTimer + "秒間胸が開き、胸の報酬が2倍になります";

                KnifePurhcase = "クリックしてエンチャントされたハンマーを使用します";
            }
            #endregion

            #region treasurePotion
            //treasurePotion
            else if (objectName == "lockedTreasurePotion")
            {
                treasurePotionDropChance = "胸から落ちる確率" + UpdateGame.treasurePotionDropChance.ToString("F2") + "%";

                treasurePotionInfo = "与える+3%次のための宝のドロップチャンス" + UpdateGame.treasurePotionTimer + "秒";

                treasurePotionPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.treasurePotionBuyPriceDouble) + "金のための購入";
            }
            else if (objectName == "upgradeTreasurePotion")
            {
                treasurePotionDropChance = "胸から落ちる確率" + UpdateGame.treasurePotionDropChance.ToString("F2") + "%<color=green>(+" + UpdateGame.treasurePotionDropChanceIncrement.ToString("F3") + "%)";

                treasurePotionInfo = "与える+3%次のための宝のドロップチャンス" + UpdateGame.treasurePotionTimer + "秒<color=green>(+" + UpdateGame.treasurePotionTimerIncrement + ")";

                treasurePotionPurchase = "";
            }
            else if (objectName == "potionIcon")
            {
                treasurePotionDropChance = "<color=red>トレジャーポーションはスタックできません";

                treasurePotionInfo = "与える+3%次のための宝のドロップチャンス" + UpdateGame.treasurePotionTimer + "秒";

                treasurePotionPurchase = "宝のポーションを使用するにはクリックしてください";
            }
            #endregion

            #region barrel
            else if (objectName == "lockedBarrel")
            {
                barrelInfo = "バレルの中に着地する金貨は、" + (UpdateGame.barrelGoldValue + 1) + "倍の金の価値があります。金を収集するためにバレルをクリックしてください";
            }
            else if (objectName == "upgradeBarrel")
            {
                barrelInfo = "バレルの中に着地する金貨は、 " + (UpdateGame.barrelGoldValue + 1) + "X<color=green>(+" + UpdateGame.barrelGoldValueIncrement.ToString("F2") + ")<color=white>倍の金の価値があります。金を収集するためにバレルをクリックしてください";
            }
            #endregion

            #region mimicChest
            else if (objectName == "lockedMimicChest")
            {
                mimicChestTimer = "悪または友好的な模倣の胸をスポーン" + UpdateGame.mimicChestTimer + "秒ごとにスポーン";

                mimicChestInfo = "一時的な正のバフのための" + UpdateGame.mimicPositiveBuffChance + "%％のチャンス一時的な負のバフのための" + UpdateGame.mimicNegativeBuffChance + "％のチャンス";

                mimicChestPurchase = "" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.mimicChestBuyPriceDouble) + "金のための購入";

            }
            else if (objectName == "upgradeMimicChest")
            {
                mimicChestTimer = "悪または友好的な模倣の胸をスポーン" + UpdateGame.mimicChestTimer + "秒ごとにスポーン<color=green>(-" + UpdateGame.mimicChestTimerIncrement + ")";

                mimicChestInfo = "一時的な正のバフのための" + UpdateGame.mimicPositiveBuffChance + "%(+" + UpdateGame.mimicPositiveBiffChanceIncrement + "%)<color=white>のチャンス一時的な負のバフのための\n" + UpdateGame.mimicNegativeBuffChance + "%<color=green>(-" + UpdateGame.mimicNegativeBuffChanceIncrement + "%)<color=white> ％のチャンス";

                //text.text = "This text on a line - This text on the line below"

                mimicChestPurchase = "";
            }
            #endregion
        }

        #endregion


        //Chinese
        #region Chinese Language
        if (Localization.ChineseLanguageChosen == 1)
        {
            #region lockPick
            //LockPick
            if (objectName == "PurchaseLockPick")
            {
                lockPickOpenChanceText = UseConsumable.lockPickSuccessChance + "%  的几率立即打开宝箱。";
                lockPickDropChanceText = SpecialUpgradesButtons.lockPickDropChance.ToString("F2") + "% 从宝箱中掉落的几率";
                lockPickPurchaseText = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newLockPickPrice) + " 金币购买";
            }
            else if (objectName == "LockPickUpgrade")
            {
                lockPickOpenChanceText = UseConsumable.lockPickSuccessChance + "%  的几率立即打开宝箱。 " + "<color=green>(+" + SpecialUpgradesButtons.lockPickOpenChanceIncrement + "%)<color=green>";
                lockPickDropChanceText = SpecialUpgradesButtons.lockPickDropChance.ToString("F2") + "% 从宝箱中掉落的几率" + "<color=green>(+" + SpecialUpgradesButtons.lockPickDropChanceIncrement.ToString("F3") + "%)<color=green>";
                lockPickPurchaseText = "";
            }
            else if (objectName == "lockPickIcon")
            {
                lockPickOpenChanceText = UseConsumable.lockPickSuccessChance + "%  的几率立即打开宝箱。 ";
                lockPickDropChanceText = "";
                lockPickPurchaseText = "点击使用锁匠工具打开宝箱";
            }

            #endregion

            #region hammer

            //(UseConsumable.hammerDamageMultiplier * 100)
            //SpecialUpgradesButtons.hammerTimer

            //Hammer
            else if (objectName == "LockedHammerUpgrade")
            {
                hammerDamageText = "在接下来的" + SpecialUpgradesButtons.hammerTimer + "秒内提供" + (UseConsumable.hammerDamageMultiplier * 100) + "%的主动伤害";

                hammerDropChanceText = SpecialUpgradesButtons.hammerDropChance.ToString("F2") + "% 从宝箱中掉落的几率";
                hammerPurchaseText = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newHammerPrice) + " 金币购买";
                bringBackCursor = "";
            }
            else if (objectName == "UpgradeHammer")
            {
                hammerDamageText = "在接下来的" + SpecialUpgradesButtons.hammerTimer + " <color=green>(+" + SpecialUpgradesButtons.hammerTimerIncrement + ")<color=white>" + "秒内提供" + (UseConsumable.hammerDamageMultiplier * 100) + " <color=green>(+" + (SpecialUpgradesButtons.hammerDamageAmountIncrement * 100) + ")<color=white>%的主动伤害";

                hammerDropChanceText = SpecialUpgradesButtons.hammerDropChance.ToString("F2") + "% 从宝箱中掉落的几率" + "<color=green>(+" + SpecialUpgradesButtons.hammerDropChanceIncrement.ToString("F3") + "%)<color=green>";
                hammerPurchaseText = "";
                bringBackCursor = "";
            }

            else if (objectName == "hammerIcon")
            {
                hammerDamageText = "在接下来的" + SpecialUpgradesButtons.hammerTimer + "秒内提供" + (UseConsumable.hammerDamageMultiplier * 100) + "%的主动伤害";

                hammerDropChanceText = "";
                hammerPurchaseText = "点击使用锤子";
                bringBackCursor = "";
            }
            #endregion

            #region key
            //Key
            else if (objectName == "LockedKey")
            {
                keyRareDropChanceText = SpecialUpgradesButtons.keyRareDropChance.ToString("F2") + "% 从宝箱中掉落宝物的几率";
                keyDropChanceText = SpecialUpgradesButtons.keyDropChance + "% 从宝箱中掉落的几率";
                keyPurchaseText = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newkeyPrice) + " 金币购买";
            }
            else if (objectName == "UpgradeKey")
            {
                keyRareDropChanceText = SpecialUpgradesButtons.keyRareDropChance.ToString("F2") + "% 从宝箱中掉落宝物的几率" + "<color=green>(+" + SpecialUpgradesButtons.keyRareDropChanceIncrement + "%)<color=green>";

                keyDropChanceText = SpecialUpgradesButtons.keyDropChance.ToString("F2") + "% 从宝箱中掉落的几率" + "<color=green>(+" + SpecialUpgradesButtons.keyDropChanceIncrement.ToString("F3") + "%)<color=green>";
                keyPurchaseText = "";
            }
            else if (objectName == "keyIcon")
            {
                keyRareDropChanceText = SpecialUpgradesButtons.keyRareDropChance.ToString("F2") + "% 从宝箱中掉落宝物的几率";
                keyDropChanceText = "";
                keyPurchaseText = "点击使用钥匙";
            }
            #endregion

            #region goldentouch
            //GoldenTouch
            else if (objectName == "LockedGoldenTouch")
            {
                goldenTouchTimerText = "宝箱在接下来的" + SpecialUpgradesButtons.goldenTouchTimer + "秒内会多生成6-10个金币";
                goldenTouchDropChance = SpecialUpgradesButtons.goldenTouchDropChance.ToString("F2") + "% 从宝箱中掉落的几率";
                goldenTouchPurchaseText = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newGoldenTouchPrice) + " 金币购买";
            }
            else if (objectName == "UpgradeGoldenTouch")
            {
                goldenTouchTimerText = "宝箱在接下来的" + SpecialUpgradesButtons.goldenTouchTimer + " <color=green>(+" + SpecialUpgradesButtons.goldenTouchTimerIncrement + ")<color=white>" + "秒内会多生成6-10个金币";

                goldenTouchDropChance = SpecialUpgradesButtons.goldenTouchDropChance.ToString("F2") + "% 从宝箱中掉落的几率" + "<color=green>(+" + SpecialUpgradesButtons.goldenTouchDropChanceIncrement.ToString("F3") + "%)<color=green>";
                goldenTouchPurchaseText = "";
            }
            else if (objectName == "goldenTouchIcon")
            {
                goldenTouchTimerText = "宝箱在接下来的" + SpecialUpgradesButtons.goldenTouchTimer + "秒内会多生成6-10个金币";
                goldenTouchDropChance = "";
                goldenTouchPurchaseText = "点击使用黄金之触";
            }
            #endregion

            #region treasureBag
            //TreasureBag
            else if (objectName == "lockedTreasureBag")
            {
                treasureChestDropChanceText = SpecialUpgradesButtons.treasureBagDropChance.ToString("F2") + "% 从宝箱中掉落宝藏袋的几率";
                treasureBagPurchaseText = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newTreasureBagPrice) + " 金币购买";
            }
            else if (objectName == "upgradeTreasureBag")
            {
                treasureChestDropChanceText = SpecialUpgradesButtons.treasureBagDropChance.ToString("F2") + "%<color=green>(+" + SpecialUpgradesButtons.treasureBagDropChanceIncrement.ToString("F3") + "%)<color=white> 从宝箱中掉落宝藏袋的几率";
                treasureBagPurchaseText = "";
            }
            else if (objectName == "treasureBagIcon")
            {
                treasureChestDropChanceText = SpecialUpgradesButtons.treasureBagDropChance.ToString("F2") + "%从宝箱中掉落宝藏袋的几率";
                treasureBagPurchaseText = "点击在下次打开宝箱时生成宝藏袋";
            }
            #endregion

            #region xpPotion
            //XPPotion
            else if (objectName == "lockedXPPotion")
            {
                XPPotionDropChanceText = SpecialUpgradesButtons.XPPotionDropChance.ToString("F2") + "% 从宝箱中掉落的几率";
                xpPotionBuffText = "+" + (SpecialUpgradesButtons.XPPotionXPBuff * 100).ToString("F0") + "%XP" + SpecialUpgradesButtons.XPPotionTimer + "秒";
                XPPotionPurchaseText = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newXPPotionPrice) + " 金币购买";
            }
            else if (objectName == "upgradeXPPotion")
            {
                XPPotionDropChanceText = SpecialUpgradesButtons.XPPotionDropChance.ToString("F2") + "% 从宝箱中掉落的几率" + "<color=green>(+" + SpecialUpgradesButtons.XPPotionDropChanceIncrement.ToString("F3") + "%)<color=green>";

                xpPotionBuffText = "+" + (SpecialUpgradesButtons.XPPotionXPBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.XPPotionBufFIncrement * 100) + "%)<color=white>XP。" + SpecialUpgradesButtons.XPPotionTimer + "<color=green>(+" + SpecialUpgradesButtons.XPPotionTimerMinus + ") <color=white>秒。";
                XPPotionPurchaseText = "";
            }
            else if (objectName == "xpPotionIcon")
            {
                XPPotionDropChanceText = "";
                xpPotionBuffText = "+" + (SpecialUpgradesButtons.XPPotionXPBuff * 100).ToString("F0") + "%XP。" + SpecialUpgradesButtons.XPPotionTimer + "秒。";
                XPPotionPurchaseText = "点击使用经验药水";
            }
            #endregion

            #region damagePotion
            //DamagePotion
            else if (objectName == "lockedDamagePotion")
            {
                damagePotionDropChanceText = SpecialUpgradesButtons.damagePotionDropChance.ToString("F2") + "% 从宝箱中掉落的几率";
                damagePotionBuffText = "+" + (SpecialUpgradesButtons.damagePotionBuff * 100).ToString("F0") + "%伤害。" + SpecialUpgradesButtons.damagePotionTimer + "秒。";
                damagePotionPurchaseText = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newDamagePotionPrice) + " 金币购买";
            }
            else if (objectName == "upgradeDamagePotion")
            {
                damagePotionDropChanceText = SpecialUpgradesButtons.damagePotionDropChance.ToString("F2") + "% 从宝箱中掉落的几率" + "<color=green>(+" + SpecialUpgradesButtons.damagePotionDropChanceIncrement.ToString("F3") + "%)<color=green>";

                damagePotionBuffText = "+" + (SpecialUpgradesButtons.damagePotionBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.damagePotionBuffIncrement * 100) + "%)<color=white>伤害。" + SpecialUpgradesButtons.damagePotionTimer + "<color=green>(+" + SpecialUpgradesButtons.damagePotionTimerMinus + ")<color=white>秒。";
                damagePotionPurchaseText = "";
            }
            else if (objectName == "damagePotionIcon")
            {
                damagePotionDropChanceText = "";
                damagePotionBuffText = "+" + (SpecialUpgradesButtons.damagePotionBuff * 100).ToString("F0") + "%伤害。" + SpecialUpgradesButtons.damagePotionTimer + "秒。";
                damagePotionPurchaseText = "点击使用伤害药水";
            }
            #endregion

            #region lootpotion
            //LootPotion
            else if (objectName == "lockedLootPotion")
            {
                lootPotiontDropChanceText = SpecialUpgradesButtons.lootPotionDropChance.ToString("F2") + "% 从宝箱中掉落的几率";
                lootpotionBuffText = "+" + (SpecialUpgradesButtons.lootPotionBuff * 100).ToString("F0") + "%金币。" + SpecialUpgradesButtons.lootPotionTimer + "秒。";

                lootPotionPurchaseText = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newLootPotionPrice) + " 金币购买";
            }
            else if (objectName == "upgradeLootPotion")
            {
                lootPotiontDropChanceText = SpecialUpgradesButtons.lootPotionDropChance.ToString("F2") + "% 从宝箱中掉落的几率" + "<color=green>(+" + SpecialUpgradesButtons.lootPotionDropChanceIncrement.ToString("F3") + "%)<color=green>";

                lootpotionBuffText = "+" + (SpecialUpgradesButtons.lootPotionBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.lootPotionBuffIncrement * 100) + "%)<color=white>金币。" + SpecialUpgradesButtons.lootPotionTimer + "<color=green>(+" + SpecialUpgradesButtons.lootPotionTimerMinus + ")<color=white>秒。";
                lootPotionPurchaseText = "";
            }
            else if (objectName == "lootPotionIcon")
            {
                lootPotiontDropChanceText = "";
                lootpotionBuffText = "+" + (SpecialUpgradesButtons.lootPotionBuff * 100).ToString("F0") + "%金币。" + SpecialUpgradesButtons.lootPotionTimer + "秒。";

                lootPotionPurchaseText = "点击使用战利品药水";
            }
            #endregion

            #region minichest
            //MiniChest
            else if (objectName == "lockedMiniChest")
            {
                miniChestTimerText = "每" + SpecialUpgradesButtons.miniChestSpawnTimer + "秒生成一个小宝箱可点击";

                miniChestPriceText = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newMiniChestPrice) + " 金币购买";
            }
            else if (objectName == "upgradeMiniChest")
            {
                miniChestTimerText = "每" + SpecialUpgradesButtons.miniChestSpawnTimer + "秒生成一个小宝箱可点击<color=green>(-" + (SpecialUpgradesButtons.miniChestSpawnTimerMinus) + ")";

                miniChestPriceText = "";

            }
            #endregion

            #region elixir
            //MiniChest
            else if (objectName == "lockedMagicalElixir")
            {
                elixirDropChance = SpecialUpgradesButtons.elixirDropChance.ToString("F2") + "% 从宝箱中掉落的几率";

                elixirInfo = "从所有3种药水中获得" + (SpecialUpgradesButtons.elixirBuff * 100).ToString("F0") + "%的奖励。持续" + SpecialUpgradesButtons.elixirTimer + "秒。";

                elixirPurchase = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newElixirPRice) + " 金币购买";
            }
            else if (objectName == "upgradeMagicalElixir")
            {
                elixirDropChance = SpecialUpgradesButtons.elixirDropChance.ToString("F2") + "% 从宝箱中掉落的几率<color=green>(+" + SpecialUpgradesButtons.elixirDropChanceIncrement.ToString("F3") + "%)<color=green>";

                elixirInfo = "从所有3种药水中获得" + (SpecialUpgradesButtons.elixirBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.elixirBuffIncrement * 100) + "%)<color=white>的奖励。持续" + SpecialUpgradesButtons.elixirTimer + "<color=green>(+" + SpecialUpgradesButtons.elixirTimerIncrement + ")<color=white>秒。";

                elixirPurchase = "";
            }
            else if (objectName == "elixirIcon")
            {
                elixirDropChance = "";

                elixirInfo = "从所有3种药水中获得" + (SpecialUpgradesButtons.elixirBuff * 100).ToString("F0") + "%的奖励。持续" + SpecialUpgradesButtons.elixirTimer + "秒。";

                elixirPurchase = "点击使用药剂";
            }
            #endregion

            #region scroll
            //MiniChest
            else if (objectName == "lockedScroll")
            {
                scrollDropChance = SpecialUpgradesButtons.scrollDropChance.ToString("F2") + "% 从宝箱中掉落的几率";

                scrollInfo = "为每个打开的宝箱提供随机的短暂加成，持续" + SpecialUpgradesButtons.scrollTimer + "秒";

                scrollPurchase = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newScrollPrice) + " 金币购买";
            }
            else if (objectName == "upgradeScroll")
            {
                scrollDropChance = SpecialUpgradesButtons.scrollDropChance.ToString("F2") + "% 从宝箱中掉落的几率<color=green>(+" + SpecialUpgradesButtons.scrollDropChanceIncrement.ToString("F3") + "%)<color=green>";

                scrollInfo = "为每个打开的宝箱提供随机的短暂加成，持续" + SpecialUpgradesButtons.scrollTimer + "<color=green>(+" + SpecialUpgradesButtons.scrollTimerIncrement + ")<color=white>秒";

                scrollPurchase = "";
            }
            else if (objectName == "scrollIcon")
            {
                scrollDropChance = "";

                scrollInfo = "为每个打开的宝箱提供随机的短暂加成，持续" + SpecialUpgradesButtons.scrollTimer + "秒";

                scrollPurchase = "点击使用幸运卷轴";
            }
            #endregion

            #region gauntlet

            else if (objectName == "lockedGauntletOfGreen")
            {
                gauntletDropChance = SpecialUpgradesButtons.gauntletDropChance.ToString("F2") + "% 从宝箱中掉落的几率";

                gauntletInfo = "在接下来的" + SpecialUpgradesButtons.gauntletTimer + "秒内，每次点击都有" + SpecialUpgradesButtons.gauntletGoldDropChance + "%的几率生成一个金币";

                gauntletPurchase = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newGauntletPrice) + " 金币购买";
            }
            else if (objectName == "upgradeGauntlet")
            {
                gauntletDropChance = SpecialUpgradesButtons.gauntletDropChance.ToString("F2") + "% 从宝箱中掉落的几率<color=green>(+" + SpecialUpgradesButtons.gauntletDropChanceIncrement.ToString("F3") + "%)<color=green>";

                gauntletInfo = "在接下来的" + SpecialUpgradesButtons.gauntletTimer + "<color=green>(+" + SpecialUpgradesButtons.gauntletTimerIncrement + ")<color=white>秒内，每次点击都有 " + SpecialUpgradesButtons.gauntletGoldDropChance + "%<color=green>(+" + SpecialUpgradesButtons.gauntletGoldDropChanceIncrement + ")<color=white>的几率生成一个金币";

                gauntletPurchase = "";
            }
            else if (objectName == "gauntletIcon")
            {
                gauntletDropChance = "";

                gauntletInfo = "在接下来的" + SpecialUpgradesButtons.gauntletTimer + "秒内，每次点击都有" + SpecialUpgradesButtons.gauntletGoldDropChance + "%的几率生成一个金币";

                gauntletPurchase = "点击使用贪婪护手";
            }
            #endregion

            #region relic
            //MiniChest
            else if (objectName == "lockedAncientRelic")
            {
                relicDropChance = SpecialUpgradesButtons.relicDropChance.ToString("F2") + "% 从宝箱中掉落的几率";

                relicInfo = "为随机属性提供永久加成";

                relicPurchase = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newRelicPrice) + " 金币购买";
            }
            else if (objectName == "upgradeRelic")
            {
                relicDropChance = SpecialUpgradesButtons.relicDropChance.ToString("F2") + "% 从宝箱中掉落的几率<color=green>(+" + SpecialUpgradesButtons.relicDropChanceIncrement.ToString("F3") + "%)<color=green>";

                relicInfo = "为随机属性提供永久加成";

                relicPurchase = "";
            }
            else if (objectName == "relicIcon")
            {
                relicDropChance = "";

                relicInfo = "为随机属性提供永久加成";

                relicPurchase = "点击使用古代遗物";
            }
            #endregion

            #region knife
            //knife
            else if (objectName == "lockedKnife")
            {
                knifeDropChance = UpdateGame.knifeDropChance.ToString("F2") + "% 从宝箱中掉落的几率";

                knifeInfo = "接下来的" + UpdateGame.knifeTimer + "秒内，每次点击都会立即打开一个宝箱并使宝箱奖励翻倍";

                KnifePurhcase = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.knifeBuyPriceDouble) + " 金币购买";
            }
            else if (objectName == "upgradeKnife")
            {
                knifeDropChance = UpdateGame.knifeDropChance.ToString("F2") + "% 从宝箱中掉落的几率<color=green>(+" + UpdateGame.knifeDropChanceIncrement.ToString("F3") + "%)";

                knifeInfo = "接下来的" + UpdateGame.knifeTimer + "<color=green>(+" + UpdateGame.knifeTimerIncrement + ") <color=white>秒内，每次点击都会立即打开一个宝箱并使宝箱奖励翻倍";

                KnifePurhcase = "";
            }
            else if (objectName == "knifeIcon")
            {
                knifeDropChance = "";

                knifeInfo = "接下来的" + UpdateGame.knifeTimer + "秒内，每次点击都会立即打开一个宝箱并使宝箱奖励翻倍";

                KnifePurhcase = "点击使用强化锤子";
            }
            #endregion

            #region treasurePotion
            //treasurePotion
            else if (objectName == "lockedTreasurePotion")
            {
                treasurePotionDropChance = UpdateGame.treasurePotionDropChance.ToString("F2") + "% 从宝箱中掉落的几率";

                treasurePotionInfo = "在接下来的" + UpdateGame.treasurePotionTimer + "秒内，提供+3%的宝藏掉落几率";

                treasurePotionPurchase = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.treasurePotionBuyPriceDouble) + " 金币购买";
            }
            else if (objectName == "upgradeTreasurePotion")
            {
                treasurePotionDropChance = UpdateGame.treasurePotionDropChance.ToString("F2") + "% 从宝箱中掉落的几率<color=green>(+" + UpdateGame.treasurePotionDropChanceIncrement.ToString("F3") + "%)";

                treasurePotionInfo = "在接下来的" + UpdateGame.treasurePotionTimer + "秒内，提供+3%的宝藏掉落几率<color=green>(+" + UpdateGame.treasurePotionTimerIncrement + ")";

                treasurePotionPurchase = "";
            }
            else if (objectName == "potionIcon")
            {
                treasurePotionDropChance = "<color=red>宝藏药剂无法叠加！";

                treasurePotionInfo = "在接下来的" + UpdateGame.treasurePotionTimer + "秒内，提供+3%的宝藏掉落几率";

                treasurePotionPurchase = "点击使用宝藏药剂";
            }
            #endregion

            #region barrel
            else if (objectName == "lockedBarrel")
            {
                barrelInfo = "落入桶中的金币价值增加" + (UpdateGame.barrelGoldValue + 1) + "倍。点击桶收集金币。";
            }
            else if (objectName == "upgradeBarrel")
            {
                barrelInfo = "落入桶中的金币价值增加" + (UpdateGame.barrelGoldValue + 1) + "X<color=green>(+" + UpdateGame.barrelGoldValueIncrement.ToString("F2") + ")<color=white>倍。点击桶收集金币。";
            }
            #endregion

            #region mimicChest
            else if (objectName == "lockedMimicChest")
            {
                mimicChestTimer = "每" + UpdateGame.mimicChestTimer + "秒生成一个邪恶或友好的模仿宝箱";

                mimicChestInfo = UpdateGame.mimicPositiveBuffChance + "%的几率获得临时正面增益\n" + UpdateGame.mimicNegativeBuffChance + "%的几率获得临时负面增益";

                mimicChestPurchase = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.mimicChestBuyPriceDouble) + " 金币购买";

            }
            else if (objectName == "upgradeMimicChest")
            {
                mimicChestTimer = "每" + UpdateGame.mimicChestTimer + "秒生成一个邪恶或友好的模仿宝箱<color=green>(-" + UpdateGame.mimicChestTimerIncrement + ")";

                mimicChestInfo = UpdateGame.mimicPositiveBuffChance + "%的几率获得临时正面增益<color=green>(+" + UpdateGame.mimicPositiveBiffChanceIncrement + "%)<color=white>\n" + UpdateGame.mimicNegativeBuffChance + "%<color=green>(-" + UpdateGame.mimicNegativeBuffChanceIncrement + "%)<color=white>的几率获得临时负面增益";

                //text.text = "This text on a line - This text on the line below"

                mimicChestPurchase = "";
            }
            #endregion
        }

        #endregion


        //Korean
        #region Korean Language
        if (Localization.KoreanLanguageChosen == 1)
        {
            #region lockPick
            //LockPick
            if (objectName == "PurchaseLockPick")
            {
                lockPickOpenChanceText = "상자를 즉시 오픈할 가능성 " + UseConsumable.lockPickSuccessChance + "%";
                lockPickDropChanceText = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.lockPickDropChance.ToString("F2") + "%";
                lockPickPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newLockPickPrice) + "골드로 구매하기";
            }
            else if (objectName == "LockPickUpgrade")
            {
                lockPickOpenChanceText = "상자를 즉시 오픈할 가능성 " + UseConsumable.lockPickSuccessChance + "%" + "<color=green>(+" + SpecialUpgradesButtons.lockPickOpenChanceIncrement + "%)<color=green>";
                lockPickDropChanceText = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.lockPickDropChance.ToString("F2") + "%" + "<color=green>(+" + SpecialUpgradesButtons.lockPickDropChanceIncrement.ToString("F3") + "%)<color=green>";
                lockPickPurchaseText = "";
            }
            else if (objectName == "lockPickIcon")
            {
                lockPickOpenChanceText = "상자를 즉시 오픈할 가능성 " + UseConsumable.lockPickSuccessChance + "%";
                lockPickDropChanceText = "";
                lockPickPurchaseText = "상자에 자물쇠 따개를 사용하기 위해 클릭하세요";
            }

            #endregion

            #region hammer
            //Hammer
            else if (objectName == "LockedHammerUpgrade")
            {
                hammerDamageText = "" + SpecialUpgradesButtons.hammerTimer + "초간 " + (UseConsumable.hammerDamageMultiplier * 100).ToString("F0") + "%의 액티브 데미지를 가합니다.";
                hammerDropChanceText = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.hammerDropChance.ToString("F2") + "%";
                hammerPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newHammerPrice) + "골드로 구매하기";
                bringBackCursor = "";
            }
            else if (objectName == "UpgradeHammer")
            {
                hammerDamageText = "" + SpecialUpgradesButtons.hammerTimer + "초간<color=green>(+" + SpecialUpgradesButtons.hammerTimerIncrement + ")<color=white>" + (UseConsumable.hammerDamageMultiplier * 100).ToString("F0") + " 의 액티브 데미지를 가합니다. <color=green>(+" + (SpecialUpgradesButtons.hammerDamageAmountIncrement * 100) + ")<color=white>";

                hammerDropChanceText = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.hammerDropChance.ToString("F2") + "%" + "<color=green>(+" + SpecialUpgradesButtons.hammerDropChanceIncrement.ToString("F3") + "%)<color=green>";
                hammerPurchaseText = "";
                bringBackCursor = "";
            }

            else if (objectName == "hammerIcon")
            {
                hammerDamageText = "" + SpecialUpgradesButtons.hammerTimer + "초간 " + (UseConsumable.hammerDamageMultiplier * 100) + "%의 액티브 데미지를 가합니다.";
                hammerDropChanceText = "";
                hammerPurchaseText = "망치를 사용하기 위해 클릭하세요";
                bringBackCursor = "";
            }
            #endregion

            #region key
            //Key
            else if (objectName == "LockedKey")
            {
                keyRareDropChanceText = "상자로부터 보물을 드롭할 가능성" + SpecialUpgradesButtons.keyRareDropChance.ToString("F2") + "%";
                keyDropChanceText = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.keyDropChance + "%";
                keyPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newkeyPrice) + "골드로 구매하기";
            }
            else if (objectName == "UpgradeKey")
            {
                keyRareDropChanceText = "상자로부터 보물을 드롭할 가능성" + SpecialUpgradesButtons.keyRareDropChance.ToString("F2") + "%" + "<color=green>(+" + SpecialUpgradesButtons.keyRareDropChanceIncrement + "%)<color=green>";

                keyDropChanceText = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.keyDropChance.ToString("F2") + "%" + "<color=green>(+" + SpecialUpgradesButtons.keyDropChanceIncrement.ToString("F3") + "%)<color=green>";
                keyPurchaseText = "";
            }
            else if (objectName == "keyIcon")
            {
                keyRareDropChanceText = "상자로부터 보물을 드롭할 가능성" + SpecialUpgradesButtons.keyRareDropChance.ToString("F2") + "%";
                keyDropChanceText = "";
                keyPurchaseText = "열쇠를 사용하기 위해 클릭하세요";
            }
            #endregion

            #region goldentouch
            //GoldenTouch
            else if (objectName == "LockedGoldenTouch")
            {
                goldenTouchTimerText = "상자는 " + SpecialUpgradesButtons.goldenTouchTimer + "초간 6-10개의 골드 코인을 더 스폰합니다. ";
                goldenTouchDropChance = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.goldenTouchDropChance.ToString("F2") + "%";
                goldenTouchPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newGoldenTouchPrice) + "골드로 구매하기";
            }
            else if (objectName == "UpgradeGoldenTouch")
            {
                goldenTouchTimerText = "상자는 " + SpecialUpgradesButtons.goldenTouchTimer + " <color=green>(+" + SpecialUpgradesButtons.goldenTouchTimerIncrement + ")<color=white>" + "초간 6-10개의 골드 코인을 더 스폰합니다. ";

                goldenTouchDropChance = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.goldenTouchDropChance.ToString("F2") + "%" + "<color=green>(+" + SpecialUpgradesButtons.goldenTouchDropChanceIncrement.ToString("F3") + "%)<color=green>";
                goldenTouchPurchaseText = "";
            }
            else if (objectName == "goldenTouchIcon")
            {
                goldenTouchTimerText = "상자는 " + SpecialUpgradesButtons.goldenTouchTimer + "초간 6-10개의 골드 코인을 더 스폰합니다. ";
                goldenTouchDropChance = "";
                goldenTouchPurchaseText = "골든 터치를 사용하기 위해서 클릭하세요";
            }
            #endregion

            #region treasureBag
            //TreasureBag
            else if (objectName == "lockedTreasureBag")
            {
                treasureChestDropChanceText = "상자로부터 보물을 드롭할 가능성 " + SpecialUpgradesButtons.treasureBagDropChance.ToString("F2") + "%";
                treasureBagPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newTreasureBagPrice) + "골드로 구매하기";
            }
            else if (objectName == "upgradeTreasureBag")
            {
                treasureChestDropChanceText = "상자로부터 보물을 드롭할 가능성 " + SpecialUpgradesButtons.treasureBagDropChance.ToString("F2") + "%<color=green>(+" + SpecialUpgradesButtons.treasureBagDropChanceIncrement.ToString("F3") + "%)<color=white>";
                treasureBagPurchaseText = "";
            }
            else if (objectName == "treasureBagIcon")
            {
                treasureChestDropChanceText = "상자로부터 보물을 드롭할 가능성 " + SpecialUpgradesButtons.treasureBagDropChance.ToString("F2") + "%";
                treasureBagPurchaseText = "다음에 상자가 오픈될 때 보물 가방을 스폰하기 위해 클릭하세요 ";
            }
            #endregion

            #region xpPotion
            //XPPotion
            else if (objectName == "lockedXPPotion")
            {
                XPPotionDropChanceText = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.XPPotionDropChance.ToString("F2") + "%";
                xpPotionBuffText = "+" + (SpecialUpgradesButtons.XPPotionXPBuff * 100).ToString("F0") + "% XP. " + SpecialUpgradesButtons.XPPotionTimer + "초.";
                XPPotionPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newXPPotionPrice) + "골드로 구매하기";
            }
            else if (objectName == "upgradeXPPotion")
            {
                XPPotionDropChanceText = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.XPPotionDropChance.ToString("F2") + "%" + "<color=green>(+" + SpecialUpgradesButtons.XPPotionDropChanceIncrement.ToString("F3") + "%)<color=green>";

                xpPotionBuffText = "+" + (SpecialUpgradesButtons.XPPotionXPBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.XPPotionBufFIncrement * 100) + "%)<color=white> XP. " + SpecialUpgradesButtons.XPPotionTimer + "<color=green>(+" + SpecialUpgradesButtons.XPPotionTimerMinus + ") <color=white>초.";
                XPPotionPurchaseText = "";
            }
            else if (objectName == "xpPotionIcon")
            {
                XPPotionDropChanceText = "";
                xpPotionBuffText = "" + (SpecialUpgradesButtons.XPPotionXPBuff * 100).ToString("F0") + "% XP. " + SpecialUpgradesButtons.XPPotionTimer + "초.";
                XPPotionPurchaseText = "XP 포션을 사용하기 위해서 클릭하세요";
            }
            #endregion

            #region damagePotion
            //DamagePotion
            else if (objectName == "lockedDamagePotion")
            {
                damagePotionDropChanceText = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.damagePotionDropChance.ToString("F2") + "% ";
                damagePotionBuffText = "+" + (SpecialUpgradesButtons.damagePotionBuff * 100).ToString("F0") + "% 데미지. " + SpecialUpgradesButtons.damagePotionTimer + " 초.";
                damagePotionPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newDamagePotionPrice) + " 골드로 구매하기";
            }
            else if (objectName == "upgradeDamagePotion")
            {
                damagePotionDropChanceText = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.damagePotionDropChance.ToString("F2") + "%" + "<color=green>(+" + SpecialUpgradesButtons.damagePotionDropChanceIncrement.ToString("F3") + "%)<color=green>";

                damagePotionBuffText = "+" + (SpecialUpgradesButtons.damagePotionBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.damagePotionBuffIncrement * 100) + "%)<color=white>데미지. " + SpecialUpgradesButtons.damagePotionTimer + "<color=green>(+" + SpecialUpgradesButtons.damagePotionTimerMinus + ")<color=white>초.";
                damagePotionPurchaseText = "";
            }
            else if (objectName == "damagePotionIcon")
            {
                damagePotionDropChanceText = "";
                damagePotionBuffText = "+" + (SpecialUpgradesButtons.damagePotionBuff * 100).ToString("F0") + "%데미지. " + SpecialUpgradesButtons.damagePotionTimer + "초.";
                damagePotionPurchaseText = "데미지 포션을 사용하기 위해 클릭하세요";
            }
            #endregion

            #region lootpotion
            //LootPotion
            else if (objectName == "lockedLootPotion")
            {
                lootPotiontDropChanceText = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.lootPotionDropChance.ToString("F2") + "%";
                lootpotionBuffText = "+" + (SpecialUpgradesButtons.lootPotionBuff * 100).ToString("F0") + "%골드" + SpecialUpgradesButtons.lootPotionTimer + "초.";

                lootPotionPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newLootPotionPrice) + "골드로 구매하기";
            }
            else if (objectName == "upgradeLootPotion")
            {
                lootPotiontDropChanceText = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.lootPotionDropChance.ToString("F2") + "%" + "<color=green>(+" + SpecialUpgradesButtons.lootPotionDropChanceIncrement.ToString("F3") + "%)<color=green>";

                lootpotionBuffText = "+" + (SpecialUpgradesButtons.lootPotionBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.lootPotionBuffIncrement * 100) + "%)<color=white>골드" + SpecialUpgradesButtons.lootPotionTimer + "<color=green>(+" + SpecialUpgradesButtons.lootPotionTimerMinus + ")<color=white>초.";
                lootPotionPurchaseText = "";
            }
            else if (objectName == "lootPotionIcon")
            {
                lootPotiontDropChanceText = "";
                lootpotionBuffText = "+" + (SpecialUpgradesButtons.lootPotionBuff * 100).ToString("F0") + "%골드" + SpecialUpgradesButtons.lootPotionTimer + "초.";

                lootPotionPurchaseText = "루트 포션을 사용하기 위해 클릭하세요";
            }
            #endregion

            #region minichest
            //MiniChest
            else if (objectName == "lockedMiniChest")
            {
                miniChestTimerText = "매 " + SpecialUpgradesButtons.miniChestSpawnTimer + "초마다 클릭할 수 있는 작은 상자 1개를 스폰합니다";

                miniChestPriceText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newMiniChestPrice) + "골드로 구매하기";
            }
            else if (objectName == "upgradeMiniChest")
            {
                miniChestTimerText = "매 " + SpecialUpgradesButtons.miniChestSpawnTimer + "초마다 클릭할 수 있는 작은 상자 1개를 스폰합니다<color=green>(-" + (SpecialUpgradesButtons.miniChestSpawnTimerMinus) + ")";

                miniChestPriceText = "";

            }
            #endregion

            #region elixir
            //MiniChest
            else if (objectName == "lockedMagicalElixir")
            {
                elixirDropChance = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.elixirDropChance.ToString("F2") + "%";

                elixirInfo = "" + SpecialUpgradesButtons.elixirTimer + "초간 3개의 포션 모두로부터" + (SpecialUpgradesButtons.elixirBuff * 100).ToString("F0") + "%의 버프를 부여합니다";

                elixirPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newElixirPRice) + "골드로 구매하기";
            }
            else if (objectName == "upgradeMagicalElixir")
            {
                elixirDropChance = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.elixirDropChance.ToString("F2") + "%<color=green>(+" + SpecialUpgradesButtons.elixirDropChanceIncrement.ToString("F3") + "%)<color=green>";

                elixirInfo = "" + SpecialUpgradesButtons.elixirTimer + "<color=green>(+" + (SpecialUpgradesButtons.elixirTimerIncrement) + "%)<color=white>초간 3개의 포션 모두로부터 " + (SpecialUpgradesButtons.elixirBuff * 100).ToString("F0") + "<color=green>(+" + SpecialUpgradesButtons.elixirBuffIncrement + ") <color=white>%의 버프를 부여합니다";

                elixirPurchase = "";
            }
            else if (objectName == "elixirIcon")
            {
                elixirDropChance = "";

                elixirInfo = "" + SpecialUpgradesButtons.elixirTimer + "초간 3개의 포션 모두로부터" + (SpecialUpgradesButtons.elixirBuff * 100).ToString("F0") + "%의 버프를 부여합니다";

                elixirPurchase = "엘릭서를 사용하기 위해서 클릭하세요";
            }
            #endregion

            #region scroll
            //MiniChest
            else if (objectName == "lockedScroll")
            {
                scrollDropChance = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.scrollDropChance.ToString("F2") + "%";

                scrollInfo = "매번 상자가 오픈될 때마다" + SpecialUpgradesButtons.scrollTimer + "초간 랜덤한 스탯에 작은 버프를 부여합니다.";

                scrollPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newScrollPrice) + "골드로 구매하기";
            }
            else if (objectName == "upgradeScroll")
            {
                scrollDropChance = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.scrollDropChance.ToString("F2") + "%<color=green>(+" + SpecialUpgradesButtons.scrollDropChanceIncrement.ToString("F3") + "%)<color=green>";

                scrollInfo = "매번 상자가 오픈될 때마다" + SpecialUpgradesButtons.scrollTimer + "<color=green>(+" + SpecialUpgradesButtons.scrollTimerIncrement + ") <color=white>초간 랜덤한 스탯에 작은 버프를 부여합니다.";

                scrollPurchase = "";
            }
            else if (objectName == "scrollIcon")
            {
                scrollDropChance = "";

                scrollInfo = "매번 상자가 오픈될 때마다" + SpecialUpgradesButtons.scrollTimer + "초간 랜덤한 스탯에 작은 버프를 부여합니다.";

                scrollPurchase = "세런디피티 두루마리을 사용하기 위해서 클릭하세요";
            }
            #endregion

            #region gauntlet

            else if (objectName == "lockedGauntletOfGreen")
            {
                gauntletDropChance = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.gauntletDropChance.ToString("F2") + "%";

                gauntletInfo = "모든 클릭은 " + SpecialUpgradesButtons.gauntletTimer + "초간 골드 코인을 스폰할 확률" + SpecialUpgradesButtons.gauntletGoldDropChance + "%를 얻습니다. ";

                gauntletPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newGauntletPrice) + "골드로 구매하기";
            }
            else if (objectName == "upgradeGauntlet")
            {
                gauntletDropChance = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.gauntletDropChance.ToString("F2") + "%<color=green>(+" + SpecialUpgradesButtons.gauntletDropChanceIncrement.ToString("F3") + "%)<color=green>";

                gauntletInfo = "모든 클릭은 " + SpecialUpgradesButtons.gauntletTimer + "%<color=green>(+" + SpecialUpgradesButtons.gauntletTimerIncrement + "%)<color=white>초간 골드 코인을 스폰할 확률" + SpecialUpgradesButtons.gauntletGoldDropChance + "<color=green>(+" + SpecialUpgradesButtons.gauntletGoldDropChanceIncrement + ") <color=white>%를 얻습니다. ";

                gauntletPurchase = "";
            }
            else if (objectName == "gauntletIcon")
            {
                gauntletDropChance = "";

                gauntletInfo = "모든 클릭은 " + SpecialUpgradesButtons.gauntletTimer + "초간 골드 코인을 스폰할 확률" + SpecialUpgradesButtons.gauntletGoldDropChance + "%를 얻습니다. ";

                gauntletPurchase = "욕망의 긴 장갑을 사용하기 위해 클릭하세요";
            }
            #endregion

            #region relic
            //MiniChest
            else if (objectName == "lockedAncientRelic")
            {
                relicDropChance = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.relicDropChance.ToString("F2") + "%";

                relicInfo = "랜덤한 스탯에 영구적인 버프를 부여합니다";

                relicPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newRelicPrice) + "골드로 구매하기";
            }
            else if (objectName == "upgradeRelic")
            {
                relicDropChance = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.relicDropChance.ToString("F2") + "%<color=green>(+" + SpecialUpgradesButtons.relicDropChanceIncrement.ToString("F3") + "%)<color=green>";

                relicInfo = "랜덤한 스탯에 영구적인 버프를 부여합니다";

                relicPurchase = "";
            }
            else if (objectName == "relicIcon")
            {
                relicDropChance = "";

                relicInfo = "랜덤한 스탯에 영구적인 버프를 부여합니다";

                relicPurchase = "고대 유물을 사용하기 위해서 클릭하세요";
            }
            #endregion

            #region knife
            //knife
            else if (objectName == "lockedKnife")
            {
                knifeDropChance = "상자로부터 드롭할 가능성 " + UpdateGame.knifeDropChance.ToString("F2") + "%";

                knifeInfo = "" + UpdateGame.knifeTimer + "초간 모든 클릭은 상자를 즉각적으로 오픈하고 상자 리워드를 두 배로 얻게 합니다 ";

                KnifePurhcase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.knifeBuyPriceDouble) + "골드로 구매하기";
            }
            else if (objectName == "upgradeKnife")
            {
                knifeDropChance = "상자로부터 드롭할 가능성 " + UpdateGame.knifeDropChance.ToString("F2") + "%<color=green>(+" + UpdateGame.knifeDropChanceIncrement.ToString("F3") + "%)";

                knifeInfo = "" + UpdateGame.knifeTimer + "<color=green>(+" + UpdateGame.knifeTimerIncrement + ") <color=white>초간 모든 클릭은 상자를 즉각적으로 오픈하고 상자 리워드를 두 배로 얻게 합니다 ";

                KnifePurhcase = "";
            }
            else if (objectName == "knifeIcon")
            {
                knifeDropChance = "";

                knifeInfo = "" + UpdateGame.knifeTimer + "초간 모든 클릭은 상자를 즉각적으로 오픈하고 상자 리워드를 두 배로 얻게 합니다 ";

                KnifePurhcase = "마법의 망치를 사용하기 위해서 클릭하세요";
            }
            #endregion

            #region treasurePotion
            //treasurePotion
            else if (objectName == "lockedTreasurePotion")
            {
                treasurePotionDropChance = "상자로부터 드롭할 가능성 " + UpdateGame.treasurePotionDropChance.ToString("F2") + "%";

                treasurePotionInfo = "" + UpdateGame.treasurePotionTimer + "초간 보물 드롭 확률 3%를 추가로 부여합니다";

                treasurePotionPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.treasurePotionBuyPriceDouble) + "골드로 구매하기";
            }
            else if (objectName == "upgradeTreasurePotion")
            {
                treasurePotionDropChance = "상자로부터 드롭할 가능성 " + UpdateGame.treasurePotionDropChance.ToString("F2") + "%<color=green>(+" + UpdateGame.treasurePotionDropChanceIncrement.ToString("F3") + "%)";

                treasurePotionInfo = "" + UpdateGame.treasurePotionTimer + "<color=green>(+" + UpdateGame.treasurePotionTimerIncrement + ")<color=white>초간 보물 드롭 확률 3%를 추가로 부여합니다";

                treasurePotionPurchase = "";
            }
            else if (objectName == "potionIcon")
            {
                treasurePotionDropChance = "<color=red>보물 포션이 스택될 수 없음!";

                treasurePotionInfo = "" + UpdateGame.treasurePotionTimer + "초간 보물 드롭 확률 3%를 추가로 부여합니다";

                treasurePotionPurchase = "보물 포션을 사용하기 위해서 클릭하세요";
            }
            #endregion

            #region barrel
            else if (objectName == "lockedBarrel")
            {
                barrelInfo = "배럴 안에 떨어지는 골드 코인은" + (UpdateGame.barrelGoldValue + 1) + "배의 가치를 지니고 있습니다. 골드를 수집하기 위해서 바렐을 클릭하세요.";
            }
            else if (objectName == "upgradeBarrel")
            {
                barrelInfo = "배럴 안에 떨어지는 골드 코인은" + (UpdateGame.barrelGoldValue + 1) + "<color=green>(+" + UpdateGame.barrelGoldValueIncrement.ToString("F2") + ")<color=white>배의 가치를 지니고 있습니다. 골드를 수집하기 위해서 바렐을 클릭하세요.";
            }
            #endregion

            #region mimicChest
            else if (objectName == "lockedMimicChest")
            {
                mimicChestTimer = "악의적/우호적인 모방 상자를 매" + UpdateGame.mimicChestTimer + "초마다 스폰합니다";

                mimicChestInfo = "일시적인 긍정 버프에 대한 확률 " + UpdateGame.mimicPositiveBuffChance + "%\n" + "일시적인 부정 버프에 대한 확률" + UpdateGame.mimicNegativeBuffChance + "%";

                mimicChestPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.mimicChestBuyPriceDouble) + "골드로 구매하기";

            }
            else if (objectName == "upgradeMimicChest")
            {
                mimicChestTimer = "악의적/우호적인 모방 상자를 매" + UpdateGame.mimicChestTimer + "초마다 스폰합니다<color=green>(-" + UpdateGame.mimicChestTimerIncrement + ")";

                mimicChestInfo = "일시적인 긍정 버프에 대한 확률 " + UpdateGame.mimicPositiveBuffChance + "<color=green>(+" + UpdateGame.mimicPositiveBiffChanceIncrement + "%)<color=white>\n" + "일시적인 부정 버프에 대한 확률" + UpdateGame.mimicNegativeBuffChance + "<color=green>(-" + UpdateGame.mimicNegativeBuffChanceIncrement + "%)<color=white>";

                //text.text = "This text on a line - This text on the line below"

                mimicChestPurchase = "";
            }
            #endregion
        }

        #endregion


        UpdateGame.changeItemUpdate = true;
        SpecialUpgradesButtons.changeText = true;
    }


    public void OnPointerExit(PointerEventData eventData)
    {
        if (PlaceMobileButtons.isMobile == true) { return; }

        //English
        #region English Language
        if (Localization.EnglishLanguageChosen == 1)
        {
            bringBackCursor = "";
            lockPickOpenChanceText = UseConsumable.lockPickSuccessChance + "% Chance to instantly open a chest";
            lockPickDropChanceText = SpecialUpgradesButtons.lockPickDropChance.ToString("F2") + "% Chance to drop from a chest";
            lockPickPurchaseText = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newLockPickPrice) + " Gold";

            hammerDamageText = "Deals +" + (UseConsumable.hammerDamageMultiplier * 100).ToString("F0") + "% active damage for " + SpecialUpgradesButtons.hammerTimer + " seconds";
            hammerDropChanceText = SpecialUpgradesButtons.hammerDropChance.ToString("F2") + "% Chance to drop from a chest";
            hammerPurchaseText = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newHammerPrice) + " Gold";

            keyRareDropChanceText = SpecialUpgradesButtons.keyRareDropChance.ToString("F2") + "% Chance to drop a treasure from a chest";
            keyDropChanceText = SpecialUpgradesButtons.keyDropChance.ToString("F2") + "% Chance to drop from a chest";
            keyPurchaseText = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newkeyPrice) + " Gold";

            goldenTouchTimerText = "Chests spawn 6-10 more gold coins for " + SpecialUpgradesButtons.goldenTouchTimer + " seconds";
            goldenTouchDropChance = SpecialUpgradesButtons.goldenTouchDropChance.ToString("F2") + "% Chance to drop from a chest";
            goldenTouchPurchaseText = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newGoldenTouchPrice) + " Gold";

            treasureChestDropChanceText = SpecialUpgradesButtons.treasureBagDropChance.ToString("F2") + "% Chance to drop a treasure bag from a chest ";
            treasureBagPurchaseText = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newTreasureBagPrice) + " Gold";

            XPPotionDropChanceText = SpecialUpgradesButtons.XPPotionDropChance.ToString("F2") + "% Chance to drop from a chest";
            xpPotionBuffText = "Gives +" + (SpecialUpgradesButtons.XPPotionXPBuff * 100).ToString("F0") + "% XP for the next " + SpecialUpgradesButtons.XPPotionTimer + " seconds";
            XPPotionPurchaseText = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newXPPotionPrice) + " Gold";

            damagePotionDropChanceText = SpecialUpgradesButtons.damagePotionDropChance.ToString("F2") + "% Chance to drop from a chest";
            damagePotionBuffText = "Deal +" + (SpecialUpgradesButtons.damagePotionBuff * 100).ToString("F0") + "% more damage for the next " + SpecialUpgradesButtons.damagePotionTimer + " seconds";
            damagePotionPurchaseText = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newDamagePotionPrice) + " Gold";

            lootPotiontDropChanceText = SpecialUpgradesButtons.lootPotionDropChance.ToString("F2") + "% Chance to drop from a chest";
            lootpotionBuffText = "Gives +" + (SpecialUpgradesButtons.lootPotionBuff * 100).ToString("F0") + "% more gold for the next " + SpecialUpgradesButtons.lootPotionTimer + " seconds";
            lootPotionPurchaseText = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newLootPotionPrice) + " Gold";

            miniChestTimerText = "Spawns a small clickable chest every " + SpecialUpgradesButtons.miniChestSpawnTimer + " second";
            miniChestPriceText = "Spawn 1 mini chest for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newMiniChestPrice) + " Gold";

            elixirDropChance = SpecialUpgradesButtons.elixirDropChance.ToString("F2") + "% Chance to drop from a chest";
            elixirInfo = "Gives +" + (SpecialUpgradesButtons.elixirBuff * 100).ToString("F0") + "% of the buffs from all 3 potions for the next " + SpecialUpgradesButtons.elixirTimer + " seconds";
            elixirPurchase = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newElixirPRice) + " Gold";

            scrollDropChance = SpecialUpgradesButtons.scrollDropChance.ToString("F2") + "% Chance to drop from a chest";
            scrollInfo = "Gives a small buff to a random stat for every chest opened for " + SpecialUpgradesButtons.scrollTimer + " seconds";
            scrollPurchase = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newScrollPrice) + " Gold";

            gauntletDropChance = SpecialUpgradesButtons.gauntletDropChance.ToString("F2") + "% Chance to drop from a chest";
            gauntletInfo = "Every click has a " + SpecialUpgradesButtons.gauntletGoldDropChance + "% chance to spawn a gold coin for the next " + SpecialUpgradesButtons.gauntletTimer + " seconds";
            gauntletPurchase = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newGauntletPrice) + " Gold";

            relicDropChance = SpecialUpgradesButtons.relicDropChance.ToString("F2") + "% Chance to drop from a chest";
            relicInfo = "Gives a permanent buff to a random stat";
            relicPurchase = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newRelicPrice) + " Gold";

            knifeDropChance = UpdateGame.knifeDropChance.ToString("F2") + "% Chance to drop from a chest";
            knifeInfo = "Each click instantly opens a chest for the next " + UpdateGame.knifeTimer + " seconds and doubles the chest rewards";
            KnifePurhcase = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.knifeBuyPriceDouble) + " Gold";

            treasurePotionDropChance = UpdateGame.treasurePotionDropChance.ToString("F2") + "% Chance to drop from a chest";
            treasurePotionInfo = "+3% Treasure drop chance for the next " + UpdateGame.treasurePotionTimer + " seconds";
            treasurePotionPurchase = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.treasurePotionBuyPriceDouble) + " Gold";

            barrelInfo = "Gold coins that lands inside the barrel is worth " + (UpdateGame.barrelGoldValue + 1) + "X more gold. Click on the barrel to collect the gold";

            mimicChestInfo = UpdateGame.mimicPositiveBuffChance + "% Chance for a temorary positive buff " + UpdateGame.mimicNegativeBuffChance + "% Chance for a temporary negative buff";
            mimicChestPurchase = "Spawn 1 Mimic Chest for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.mimicChestBuyPriceDouble) + " Gold";

            mimicChestTimer = "Spawns a <color=red>EVIL<color=white> or <color=green>FRIENDLY<color=white> mimic chest every " + UpdateGame.mimicChestTimer + " seconds";
        }
        #endregion

        //Russian
        #region Russian Language
        if (Localization.RussianLanguageChosen == 1)
        {
            bringBackCursor = "";
            lockPickOpenChanceText = UseConsumable.lockPickSuccessChance + "% Шанс мгновенно открыть сундук";
            lockPickDropChanceText = SpecialUpgradesButtons.lockPickDropChance.ToString("F2") + "% Шанс выпасть из сундука";
            lockPickPurchaseText = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newLockPickPrice) + " Золота";

            hammerDamageText = "Наносит +" + (UseConsumable.hammerDamageMultiplier * 100).ToString("F0") + "% активного урона в течение " + SpecialUpgradesButtons.hammerTimer + " секунд.";
            hammerDropChanceText = SpecialUpgradesButtons.hammerDropChance.ToString("F2") + "% Шанс выпасть из сундука";
            hammerPurchaseText = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newHammerPrice) + " Золота";

            keyRareDropChanceText = SpecialUpgradesButtons.keyRareDropChance.ToString("F2") + "% Шанс выпадения сокровища из сундука";
            keyDropChanceText = SpecialUpgradesButtons.keyDropChance.ToString("F2") + "% Шанс выпасть из сундука";
            keyPurchaseText = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newkeyPrice) + " Золота";

            goldenTouchTimerText = "Сундуки создают от 6 до 10 дополнительных золотых монет в течение " + SpecialUpgradesButtons.goldenTouchTimer + " секунд";
            goldenTouchDropChance = SpecialUpgradesButtons.goldenTouchDropChance.ToString("F2") + "% Шанс выпасть из сундука";
            goldenTouchPurchaseText = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newGoldenTouchPrice) + " Золота";

            treasureChestDropChanceText = SpecialUpgradesButtons.treasureBagDropChance.ToString("F2") + "% Шанс выпасть мешку с сокровищами из сундука";
            treasureBagPurchaseText = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newTreasureBagPrice) + " Золота";

            XPPotionDropChanceText = SpecialUpgradesButtons.XPPotionDropChance.ToString("F2") + "% Шанс выпасть из сундука";
            xpPotionBuffText = "Дает на +" + (SpecialUpgradesButtons.XPPotionXPBuff * 100).ToString("F0") + "% больше опыта на следующие " + SpecialUpgradesButtons.XPPotionTimer + " секунд";
            XPPotionPurchaseText = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newXPPotionPrice) + " Золота";

            damagePotionDropChanceText = SpecialUpgradesButtons.damagePotionDropChance.ToString("F2") + "% Шанс выпасть из сундука";
            damagePotionBuffText = "Наносите на +" + (SpecialUpgradesButtons.damagePotionBuff * 100).ToString("F0") + "%  больше урона в течение следующих " + SpecialUpgradesButtons.damagePotionTimer + " секунд";
            damagePotionPurchaseText = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newDamagePotionPrice) + " Золота";

            lootPotiontDropChanceText = SpecialUpgradesButtons.lootPotionDropChance.ToString("F2") + "% Шанс выпасть из сундука";
            lootpotionBuffText = "Дает на +" + (SpecialUpgradesButtons.lootPotionBuff * 100).ToString("F0") + "% больше золота на следующие " + SpecialUpgradesButtons.lootPotionTimer + " секунд";
            lootPotionPurchaseText = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newLootPotionPrice) + " Золота";

            miniChestTimerText = "Создает маленький, на который можно нажать, сундук каждые " + SpecialUpgradesButtons.miniChestSpawnTimer + " секунд";
            miniChestPriceText = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newMiniChestPrice) + " Золота";

            elixirDropChance = SpecialUpgradesButtons.elixirDropChance.ToString("F2") + "% Шанс выпасть из сундука";
            elixirInfo = "Дает +" + (SpecialUpgradesButtons.elixirBuff * 100).ToString("F0") + "% баффов от всех трех зелий на следующие " + SpecialUpgradesButtons.elixirTimer + " секунд";
            elixirPurchase = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newElixirPRice) + " Золота";

            scrollDropChance = SpecialUpgradesButtons.scrollDropChance.ToString("F2") + "% Шанс выпасть из сундука";
            scrollInfo = "Дает небольшой бафф к случайной характеристике для каждого открытого сундука на протяжении " + SpecialUpgradesButtons.scrollTimer + " секунд";
            scrollPurchase = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newScrollPrice) + " Золота";

            gauntletDropChance = SpecialUpgradesButtons.gauntletDropChance.ToString("F2") + "% Шанс выпасть из сундука";
            gauntletInfo = "Каждый клик с " + SpecialUpgradesButtons.gauntletGoldDropChance + "% шансом создает золотую монету на следующие " + SpecialUpgradesButtons.gauntletTimer + " секунд";
            gauntletPurchase = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newGauntletPrice) + " Золота";

            relicDropChance = SpecialUpgradesButtons.relicDropChance.ToString("F2") + "% Шанс выпасть из сундука";
            relicPurchase = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newRelicPrice) + " Золота";

            knifeDropChance = UpdateGame.knifeDropChance.ToString("F2") + "% Шанс выпасть из сундука";
            knifeInfo = "Каждый клик мгновенно открывает сундук в течение следующих " + UpdateGame.knifeTimer + " секунд и удваивает награды с сундука";
            KnifePurhcase = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.knifeBuyPriceDouble) + " Золота";

            treasurePotionDropChance = UpdateGame.treasurePotionDropChance.ToString("F2") + "% Шанс выпасть из сундука";
            treasurePotionInfo = "+3% шанса на выпадение сокровища на следующие " + UpdateGame.treasurePotionTimer + " секунд";
            treasurePotionPurchase = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.treasurePotionBuyPriceDouble) + " Золота";

            barrelInfo = "Золотые монеты, попавшие в бочонок, стоят в " + (UpdateGame.barrelGoldValue + 1) + "X раза дороже. Нажмите на бочонок, чтобы собрать золото";

            mimicChestInfo = UpdateGame.mimicPositiveBuffChance + "% шанс на временный положительный бафф\n" + UpdateGame.mimicNegativeBuffChance + "% шанс на временный отрицательный бафф";
            mimicChestPurchase = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.mimicChestBuyPriceDouble) + " Золота";

            mimicChestTimer = "Появляется <color=red>ЗЛОБНЫЙ<color=white> или <color=green>ДОБРЫЙ<color=white> сундук-мимик каждые " + UpdateGame.mimicChestTimer + " секунд";
        }
        #endregion

        //Japanese
        #region Japanese Language
        if (Localization.JapaneseLanguageChosen == 1)
        {
            bringBackCursor = "";
            lockPickOpenChanceText = "即座に胸を開くために" + UseConsumable.lockPickSuccessChance + "％のチャンス";
            lockPickDropChanceText = "胸から落ちる確率" + SpecialUpgradesButtons.lockPickDropChance.ToString("F2") + "%";
            lockPickPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newLockPickPrice) + "金のための購入";

            hammerDamageText = "" + (UseConsumable.hammerDamageMultiplier * 100).ToString("F0") + "%のアクティブダメージを" + SpecialUpgradesButtons.hammerTimer + " 秒間与える";
            hammerDropChanceText ="胸から落ちる確率" + SpecialUpgradesButtons.hammerDropChance.ToString("F2") + "%";
            hammerPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newHammerPrice) + "金のための購入";

            keyRareDropChanceText = SpecialUpgradesButtons.keyRareDropChance.ToString("F2") + "%胸から宝をドロップするチャンス";
            keyDropChanceText = "胸から落ちる確率" + SpecialUpgradesButtons.keyDropChance.ToString("F2") + "%";
            keyPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newkeyPrice) + "金のための購入";

            goldenTouchTimerText = "チェストは6-10秒のためのより多くの金貨をスポーン" + SpecialUpgradesButtons.goldenTouchTimer + "";
            goldenTouchDropChance = "胸から落ちる確率" + SpecialUpgradesButtons.goldenTouchDropChance.ToString("F2") + "%";
            goldenTouchPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newGoldenTouchPrice) + "金のための購入";

            treasureChestDropChanceText = "宝の袋を胸から落とす確率" + SpecialUpgradesButtons.treasureBagDropChance.ToString("F2") + "%";
            treasureBagPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newTreasureBagPrice) + "金のための購入";

            XPPotionDropChanceText = "胸から落ちる確率" + SpecialUpgradesButtons.XPPotionDropChance.ToString("F2") + "%";
            xpPotionBuffText = "+" + (SpecialUpgradesButtons.XPPotionXPBuff * 100).ToString("F0") + "%XP" + SpecialUpgradesButtons.XPPotionTimer + "秒";
            XPPotionPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newXPPotionPrice) + "金のための購入";

            damagePotionDropChanceText = "胸から落ちる確率" + SpecialUpgradesButtons.damagePotionDropChance.ToString("F2") + "%";
            damagePotionBuffText = "+" + (SpecialUpgradesButtons.damagePotionBuff * 100).ToString("F0") + "%ダメージ" + SpecialUpgradesButtons.damagePotionTimer + "秒";
            damagePotionPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newDamagePotionPrice) + "金のための購入";

            lootPotiontDropChanceText = "胸から落ちる確率" + SpecialUpgradesButtons.lootPotionDropChance.ToString("F2") + "%";
            lootpotionBuffText = "+" + (SpecialUpgradesButtons.lootPotionBuff * 100).ToString("F0") + "%ゴールド" + SpecialUpgradesButtons.lootPotionTimer + "秒";
            lootPotionPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newLootPotionPrice) + "金のための購入";

            miniChestTimerText = "クリック可能な小さな胸を" + SpecialUpgradesButtons.miniChestSpawnTimer + "秒ごとにスポーンします";
            miniChestPriceText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newMiniChestPrice) + "金のための購入";

            elixirDropChance = "胸から落ちる確率" + SpecialUpgradesButtons.elixirDropChance.ToString("F2") + "%";
            elixirInfo = "与える+" + (SpecialUpgradesButtons.elixirBuff * 100).ToString("F0") + "%すべてからのバフの3次のためのポーション" + SpecialUpgradesButtons.elixirTimer + "秒";
            elixirPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newElixirPRice) + "金のための購入";

            scrollDropChance = "胸から落ちる確率" + SpecialUpgradesButtons.scrollDropChance.ToString("F2") + "%";
            scrollInfo = "" + SpecialUpgradesButtons.scrollTimer + "秒間開いたすべての胸のランダムな統計に小さなバフを与えます";
            scrollPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newScrollPrice) + "金のための購入";

            gauntletDropChance = "胸から落ちる確率" + SpecialUpgradesButtons.gauntletDropChance.ToString("F2") + "%";
            gauntletInfo = "すべてのクリックは、次の" + SpecialUpgradesButtons.gauntletTimer + "秒間金貨をスポーンする" + SpecialUpgradesButtons.gauntletGoldDropChance + "％のチャンスを持っています";
            gauntletPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newGauntletPrice) + "金のための購入";

            relicDropChance = "胸から落ちる確率" + SpecialUpgradesButtons.relicDropChance.ToString("F2") + "%";
            relicInfo = "ランダムな統計に永続的なバフを与えます";
            relicPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newRelicPrice) + "金のための購入";

            knifeDropChance = "胸から落ちる確率" + UpdateGame.knifeDropChance.ToString("F2") + "%";
            knifeInfo = "クリックするたびにすぐに次の" + UpdateGame.knifeTimer + "秒間胸が開き、胸の報酬が2倍になります";
            KnifePurhcase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.knifeBuyPriceDouble) + "金のための購入";

            treasurePotionDropChance = "胸から落ちる確率" + UpdateGame.treasurePotionDropChance.ToString("F2") + "%";
            treasurePotionInfo = "与える+3%次のための宝のドロップチャンス" + UpdateGame.treasurePotionTimer + "秒";
            treasurePotionPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.treasurePotionBuyPriceDouble) + "金のための購入";

            barrelInfo = "バレルの中に着地する金貨は、" + (UpdateGame.barrelGoldValue + 1) + "倍の金の価値があります。金を収集するためにバレルをクリックしてください";

            mimicChestInfo = "一時的な正のバフのための" + UpdateGame.mimicPositiveBuffChance + "%のチャンス一時的な負のバフのための" + UpdateGame.mimicNegativeBuffChance + "％のチャンス";
            mimicChestPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.mimicChestBuyPriceDouble) + "金のための購入";

            mimicChestTimer = "悪または友好的な模倣の胸をスポーン" + UpdateGame.mimicChestTimer + "秒ごとにスポーン";
        }
        #endregion

        //Chinese
        #region Chinese Language
        if (Localization.ChineseLanguageChosen == 1)
        {
            bringBackCursor = "";
            lockPickOpenChanceText = UseConsumable.lockPickSuccessChance + "%  的几率立即打开宝箱。";
            lockPickDropChanceText = SpecialUpgradesButtons.lockPickDropChance.ToString("F2") + "% 从宝箱中掉落的几率";
            lockPickPurchaseText = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newLockPickPrice) + " 金币购买";

            hammerDamageText = "在接下来的" + SpecialUpgradesButtons.hammerTimer + "秒内提供" + (UseConsumable.hammerDamageMultiplier * 100) + "%的主动伤害";

            hammerDropChanceText = SpecialUpgradesButtons.hammerDropChance.ToString("F2") + "% 从宝箱中掉落的几率";
            hammerPurchaseText = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newHammerPrice) + " 金币购买";

            keyRareDropChanceText = SpecialUpgradesButtons.keyRareDropChance.ToString("F2") + "% 从宝箱中掉落宝物的几率";
            keyDropChanceText = SpecialUpgradesButtons.keyDropChance.ToString("F2") + "% 从宝箱中掉落的几率";
            keyPurchaseText = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newkeyPrice) + " 金币购买";

            goldenTouchTimerText = "宝箱在接下来的" + SpecialUpgradesButtons.goldenTouchTimer + "秒内会多生成6-10个金币";
            goldenTouchDropChance = SpecialUpgradesButtons.goldenTouchDropChance.ToString("F2") + "% 从宝箱中掉落的几率";
            goldenTouchPurchaseText = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newGoldenTouchPrice) + " 金币购买";

            treasureChestDropChanceText = SpecialUpgradesButtons.treasureBagDropChance.ToString("F2") + "% 从宝箱中掉落宝藏袋的几率";
            treasureBagPurchaseText = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newTreasureBagPrice) + " 金币购买";

            XPPotionDropChanceText = SpecialUpgradesButtons.XPPotionDropChance.ToString("F2") + "% 从宝箱中掉落的几率";
            xpPotionBuffText = "+" + (SpecialUpgradesButtons.XPPotionXPBuff * 100).ToString("F0") + "%XP。" + SpecialUpgradesButtons.XPPotionTimer + " 秒。";
            XPPotionPurchaseText = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newXPPotionPrice) + " 金币购买";

            damagePotionDropChanceText = SpecialUpgradesButtons.damagePotionDropChance.ToString("F2") + "% 从宝箱中掉落的几率";
            damagePotionBuffText = "+" + (SpecialUpgradesButtons.damagePotionBuff * 100).ToString("F0") + "%伤害。" + SpecialUpgradesButtons.damagePotionTimer + "4秒。";
            damagePotionPurchaseText = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newDamagePotionPrice) + " 金币购买";

            lootPotiontDropChanceText = SpecialUpgradesButtons.lootPotionDropChance.ToString("F2") + "% 从宝箱中掉落的几率";
            lootpotionBuffText = "+" + (SpecialUpgradesButtons.lootPotionBuff * 100).ToString("F0") + "%金币。" + SpecialUpgradesButtons.lootPotionTimer + "秒。";
            lootPotionPurchaseText = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newLootPotionPrice) + " 金币购买";

            miniChestTimerText = "每" + SpecialUpgradesButtons.miniChestSpawnTimer + "秒生成一个小宝箱可点击";
            miniChestPriceText = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newMiniChestPrice) + " 金币购买";

            elixirDropChance = SpecialUpgradesButtons.elixirDropChance.ToString("F2") + "% 从宝箱中掉落的几率";
            elixirInfo = "从所有3种药水中获得" + (SpecialUpgradesButtons.elixirBuff * 100).ToString("F0") + "%的奖励。持续" + SpecialUpgradesButtons.elixirTimer + "秒。";
            elixirPurchase = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newElixirPRice) + " 金币购买";

            scrollDropChance = SpecialUpgradesButtons.scrollDropChance.ToString("F2") + "% 从宝箱中掉落的几率";
            scrollInfo = "为每个打开的宝箱提供随机的短暂加成，持续" + SpecialUpgradesButtons.scrollTimer + "秒";
            scrollPurchase = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newScrollPrice) + " 金币购买";

            gauntletDropChance = SpecialUpgradesButtons.gauntletDropChance.ToString("F2") + "% 从宝箱中掉落的几率";
            gauntletInfo = "在接下来的" + SpecialUpgradesButtons.gauntletTimer + "秒内，每次点击都有" + SpecialUpgradesButtons.gauntletGoldDropChance + "%的几率生成一个金币";
            gauntletPurchase = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newGauntletPrice) + " 金币购买";

            relicDropChance = SpecialUpgradesButtons.relicDropChance.ToString("F2") + "% 从宝箱中掉落的几率";
            relicInfo = "为随机属性提供永久加成";
            relicPurchase = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newRelicPrice) + " 金币购买";

            knifeDropChance = UpdateGame.knifeDropChance.ToString("F2") + "% 从宝箱中掉落的几率";
            knifeInfo = "接下来的" + UpdateGame.knifeTimer + "秒内，每次点击都会立即打开一个宝箱并使宝箱奖励翻倍";
            KnifePurhcase = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.knifeBuyPriceDouble) + " 金币购买";

            treasurePotionDropChance = UpdateGame.treasurePotionDropChance.ToString("F2") + "% 从宝箱中掉落的几率";
            treasurePotionInfo = "在接下来的" + UpdateGame.treasurePotionTimer + "秒内，提供+3%的宝藏掉落几率";
            treasurePotionPurchase = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.treasurePotionBuyPriceDouble) + " 金币购买";

            barrelInfo = "落入桶中的金币价值增加" + (UpdateGame.barrelGoldValue + 1) + "倍。点击桶收集金币。";

            mimicChestInfo = UpdateGame.mimicPositiveBuffChance + "%的几率获得临时正面增益\n" + UpdateGame.mimicNegativeBuffChance + "%的几率获得临时负面增益";
            mimicChestPurchase = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.mimicChestBuyPriceDouble) + " 金币购买";

            mimicChestTimer = "每" + UpdateGame.mimicChestTimer + "秒生成一个邪恶或友好的模仿宝箱";
        }
        #endregion

        //Korean
        #region Korean Language
        if (Localization.KoreanLanguageChosen == 1)
        {
            bringBackCursor = "";
            lockPickOpenChanceText = "상자를 즉시 오픈할 가능성 " + UseConsumable.lockPickSuccessChance + "%";
            lockPickDropChanceText = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.lockPickDropChance.ToString("F2") + "%";
            lockPickPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newLockPickPrice) + "골드로 구매하기";

            hammerDamageText = "" + SpecialUpgradesButtons.hammerTimer + "초간 " + (UseConsumable.hammerDamageMultiplier * 100).ToString("F0") + "%의 액티브 데미지를 가합니다.";
            hammerDropChanceText = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.hammerDropChance.ToString("F2") + "%";
            hammerPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newHammerPrice) + "골드로 구매하기";

            keyRareDropChanceText = "상자로부터 보물을 드롭할 가능성" + SpecialUpgradesButtons.keyRareDropChance.ToString("F2") + "%";
            keyDropChanceText = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.keyDropChance.ToString("F2") + "%";
            keyPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newkeyPrice) + " 골드로 구매하기";

            goldenTouchTimerText = "상자는 " + SpecialUpgradesButtons.goldenTouchTimer + "초간 6-10개의 골드 코인을 더 스폰합니다. ";
            goldenTouchDropChance = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.goldenTouchDropChance.ToString("F2") + "%";
            goldenTouchPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newGoldenTouchPrice) + "골드로 구매하기";

            treasureChestDropChanceText = "상자로부터 보물을 드롭할 가능성 " + SpecialUpgradesButtons.treasureBagDropChance.ToString("F2") + "%";
            treasureBagPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newTreasureBagPrice) + "골드로 구매하기";

            XPPotionDropChanceText = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.XPPotionDropChance.ToString("F2") + "%";
            xpPotionBuffText = "+" + (SpecialUpgradesButtons.XPPotionXPBuff * 100).ToString("F0") + "% XP. " + SpecialUpgradesButtons.XPPotionTimer + "초.";
            XPPotionPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newXPPotionPrice) + "골드로 구매하기";

            damagePotionDropChanceText = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.damagePotionDropChance.ToString("F2") + "%";
            damagePotionBuffText = "+" + (SpecialUpgradesButtons.damagePotionBuff * 100).ToString("F0") + "%데미지. " + SpecialUpgradesButtons.damagePotionTimer + "초.";
            damagePotionPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newDamagePotionPrice) + "골드로 구매하기";

            lootPotiontDropChanceText = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.lootPotionDropChance.ToString("F2") + "%";
            lootpotionBuffText = "+" + (SpecialUpgradesButtons.lootPotionBuff * 100).ToString("F0") + "%골드. " + SpecialUpgradesButtons.lootPotionTimer + "초.";
            lootPotionPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newLootPotionPrice) + "골드로 구매하기";

            miniChestTimerText = "매" + SpecialUpgradesButtons.miniChestSpawnTimer + "초마다 클릭할 수 있는 작은 상자 1개를 스폰합니다";
            miniChestPriceText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newMiniChestPrice) + "골드로 구매하기";

            elixirDropChance = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.elixirDropChance.ToString("F2") + "%";
            elixirInfo = "" + SpecialUpgradesButtons.elixirTimer + "초간 3개의 포션 모두로부터" + (SpecialUpgradesButtons.elixirBuff * 100).ToString("F0") + "%의 버프를 부여합니다";
            elixirPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newElixirPRice) + "골드로 구매하기";

            scrollDropChance = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.scrollDropChance.ToString("F2") + "%";
            scrollInfo = "매번 상자가 오픈될 때마다" + SpecialUpgradesButtons.scrollTimer + "초간 랜덤한 스탯에 작은 버프를 부여합니다.";
            scrollPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newScrollPrice) + "골드로 구매하기";

            gauntletDropChance = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.gauntletDropChance.ToString("F2") + "%";
            gauntletInfo = "모든 클릭은 " + SpecialUpgradesButtons.gauntletTimer + "초간 골드 코인을 스폰할 확률" + SpecialUpgradesButtons.gauntletGoldDropChance + "%를 얻습니다. ";
            gauntletPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newGauntletPrice) + "골드로 구매하기";

            relicDropChance = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.relicDropChance.ToString("F2") + "%";
            relicInfo = "랜덤한 스탯에 영구적인 버프를 부여합니다";
            relicPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newRelicPrice) + "골드로 구매하기";

            knifeDropChance = "상자로부터 드롭할 가능성 " + UpdateGame.knifeDropChance.ToString("F2") + "%";
            knifeInfo = "" + UpdateGame.knifeTimer + "초간 모든 클릭은 상자를 즉각적으로 오픈하고 상자 리워드를 두 배로 얻게 합니다 ";
            KnifePurhcase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.knifeBuyPriceDouble) + "골드로 구매하기";

            treasurePotionDropChance = "상자로부터 드롭할 가능성 " + UpdateGame.treasurePotionDropChance.ToString("F2") + "%";
            treasurePotionInfo = "" + UpdateGame.treasurePotionTimer + "초간 보물 드롭 확률 3%를 추가로 부여합니다";
            treasurePotionPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.treasurePotionBuyPriceDouble) + "골드로 구매하기";

            barrelInfo = "배럴 안에 떨어지는 골드 코인은" + (UpdateGame.barrelGoldValue + 1) + "배의 가치를 지니고 있습니다. 골드를 수집하기 위해서 바렐을 클릭하세요.";

            mimicChestInfo = "일시적인 긍정 버프에 대한 확률 " + UpdateGame.mimicPositiveBuffChance + "%\n" + "일시적인 부정 버프에 대한 확률" + UpdateGame.mimicNegativeBuffChance + "%";
            mimicChestPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.mimicChestBuyPriceDouble) + "골드로 구매하기";

            mimicChestTimer = "악의적/우호적인 모방 상자를 매" + UpdateGame.mimicChestTimer + "초마다 스폰합니다";
        }
        #endregion

        UpdateGame.changeItemUpdate = true;
        SpecialUpgradesButtons.changeText = true;
    }

    public static bool hoverPriceChange;
    public static bool hoverSpecialChance;

    public void Update()
    {
        if(hoverPriceChange == true)
        {
            #region English Language
            if (Localization.EnglishLanguageChosen == 1)
            {
                lockPickPurchaseText = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newLockPickPrice) + " Gold";
                keyPurchaseText = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newkeyPrice) + " Gold";
                hammerPurchaseText = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newHammerPrice) + " Gold";
                goldenTouchPurchaseText = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newGoldenTouchPrice) + " Gold";
                treasureBagPurchaseText = "Purchase for  <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newTreasureBagPrice) + " Gold";
                XPPotionPurchaseText = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newXPPotionPrice) + " Gold";
                damagePotionPurchaseText = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newDamagePotionPrice) + " Gold";
                lootPotionPurchaseText = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newLootPotionPrice) + " Gold";
                miniChestTimerText = "Spawns a small clickable chest every " + SpecialUpgradesButtons.miniChestSpawnTimer + " second";

                elixirPurchase = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newElixirPRice) + " Gold";
                scrollPurchase = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newScrollPrice) + " Gold";
                gauntletPurchase = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newGauntletPrice) + " Gold";
                relicPurchase = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newRelicPrice) + " Gold";

                miniChestPriceText = "Spawn 1 mini chest for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newMiniChestPrice) + " Gold";
                mimicChestPurchase = "Spawn 1 mimic chest for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.mimicChestBuyPriceDouble) + " Gold";

                treasurePotionPurchase = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.treasurePotionBuyPriceDouble) + " Gold";
                KnifePurhcase = "Purchase for <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.knifeBuyPriceDouble) + " Gold";
            }
            #endregion

            #region Russian Language
            if (Localization.RussianLanguageChosen == 1)
            {
                lockPickPurchaseText = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newLockPickPrice) + " Золота";
                keyPurchaseText = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newkeyPrice) + " Золота";
                hammerPurchaseText = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newHammerPrice) + " Золота";
                goldenTouchPurchaseText = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newGoldenTouchPrice) + " Золота";
                treasureBagPurchaseText = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newTreasureBagPrice) + " Золота";
                XPPotionPurchaseText = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newXPPotionPrice) + " Золота";
                damagePotionPurchaseText = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newDamagePotionPrice) + " Золота";
                lootPotionPurchaseText = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newLootPotionPrice) + " Золота";
                miniChestTimerText = "Создает маленький, на который можно нажать, сундук каждые " + SpecialUpgradesButtons.miniChestSpawnTimer + " секунд";

                elixirPurchase = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newElixirPRice) + " Золота";
                scrollPurchase = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newScrollPrice) + " Золота";
                gauntletPurchase = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newGauntletPrice) + " Золота";
                relicPurchase = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newRelicPrice) + " Золота";

                miniChestPriceText = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newMiniChestPrice) + " Золота";
                mimicChestPurchase = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.mimicChestBuyPriceDouble) + " Золота";

                treasurePotionPurchase = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.treasurePotionBuyPriceDouble) + " Золота";
                KnifePurhcase = "Купить за <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.knifeBuyPriceDouble) + " Золота";
            }
            #endregion

            #region Japenese Language
            if (Localization.JapaneseLanguageChosen == 1)
            {
                lockPickPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newLockPickPrice) + "金のための購入";
                keyPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newkeyPrice) + "金のための購入";
                hammerPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newHammerPrice) + "金のための購入";
                goldenTouchPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newGoldenTouchPrice) + "金のための購入";
                treasureBagPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newTreasureBagPrice) + "金のための購入";
                XPPotionPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newXPPotionPrice) + "金のための購入";
                damagePotionPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newDamagePotionPrice) + "金のための購入";
                lootPotionPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newLootPotionPrice) + "金のための購入";
                miniChestTimerText = "クリック可能な小さな胸を" + SpecialUpgradesButtons.miniChestSpawnTimer + "秒ごとにスポーンします";

                elixirPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newElixirPRice) + "金のための購入";
                scrollPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newScrollPrice) + "金のための購入";
                gauntletPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newGauntletPrice) + "金のための購入";
                relicPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newRelicPrice) + "金のための購入";

                miniChestPriceText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newMiniChestPrice) + "金のための購入";
                mimicChestPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.mimicChestBuyPriceDouble) + "金のための購入";

                treasurePotionPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.treasurePotionBuyPriceDouble) + "金のための購入";
                KnifePurhcase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.knifeBuyPriceDouble) + "金のための購入";
            }
            #endregion

            #region Chinese Language
            if (Localization.ChineseLanguageChosen == 1)
            {
                lockPickPurchaseText = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newLockPickPrice) + " 金币购买";
                keyPurchaseText = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newkeyPrice) + " 金币购买";
                hammerPurchaseText = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newHammerPrice) + " 金币购买";
                goldenTouchPurchaseText = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newGoldenTouchPrice) + " 金币购买";
                treasureBagPurchaseText = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newTreasureBagPrice) + " 金币购买";
                XPPotionPurchaseText = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newXPPotionPrice) + " 金币购买";
                damagePotionPurchaseText = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newDamagePotionPrice) + " 金币购买";
                lootPotionPurchaseText = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newLootPotionPrice) + " 金币购买";
                miniChestTimerText = "每" + SpecialUpgradesButtons.miniChestSpawnTimer + "秒生成一个小宝箱可点击";

                elixirPurchase = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newElixirPRice) + " 金币购买";
                scrollPurchase = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newScrollPrice) + " 金币购买";
                gauntletPurchase = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newGauntletPrice) + " 金币购买";
                relicPurchase = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newRelicPrice) + " 金币购买";

                miniChestPriceText = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newMiniChestPrice) + " 金币购买";
                mimicChestPurchase = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.mimicChestBuyPriceDouble) + " 金币购买";

                treasurePotionPurchase = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.treasurePotionBuyPriceDouble) + " 金币购买";
                KnifePurhcase = "花费 <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.knifeBuyPriceDouble) + " 金币购买";
            }
            #endregion

            #region Korean Language
            if (Localization.KoreanLanguageChosen == 1)
            {
                lockPickPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newLockPickPrice) + " 골드로 구매하기";
                keyPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newkeyPrice) + "골드로 구매하기";
                hammerPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newHammerPrice) + "골드로 구매하기";
                goldenTouchPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newGoldenTouchPrice) + "골드로 구매하기";
                treasureBagPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newTreasureBagPrice) + "골드로 구매하기";
                XPPotionPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newXPPotionPrice) + "골드로 구매하기";
                damagePotionPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newDamagePotionPrice) + "골드로 구매하기";
                lootPotionPurchaseText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newLootPotionPrice) + "골드로 구매하기";
                miniChestTimerText = "매" + SpecialUpgradesButtons.miniChestSpawnTimer + "초마다 클릭할 수 있는 작은 상자 1개를 스폰합니다";

                elixirPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newElixirPRice) + "골드로 구매하기";
                scrollPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newScrollPrice) + "골드로 구매하기";
                gauntletPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newGauntletPrice) + "골드로 구매하기";
                relicPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newRelicPrice) + "골드로 구매하기";

                miniChestPriceText = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(SpecialUpgradesButtons.newMiniChestPrice) + "골드로 구매하기";
                mimicChestPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.mimicChestBuyPriceDouble) + "골드로 구매하기";

                treasurePotionPurchase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.treasurePotionBuyPriceDouble) + "골드로 구매하기";
                KnifePurhcase = "<color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(UpdateGame.knifeBuyPriceDouble) + "골드로 구매하기";
            }
            #endregion

            UpdateGame.changeItemUpdate = true;
            hoverPriceChange = false;
            SpecialUpgradesButtons.changeText = true;
        }
        if(hoverSpecialChance == true)
        {
            //English
            #region English Language
            if (Localization.EnglishLanguageChosen == 1)
            {
                //LockPick
                lockPickOpenChanceText = UseConsumable.lockPickSuccessChance + "% Chance to instantly open a chest " + "<color=green>(+" + SpecialUpgradesButtons.lockPickOpenChanceIncrement + "%)<color=green>";
                lockPickDropChanceText = SpecialUpgradesButtons.lockPickDropChance.ToString("F2") + "% Chance to drop from a chest " + "<color=green>(+" + SpecialUpgradesButtons.lockPickDropChanceIncrement.ToString("F3") + "%)<color=green>";
                if(PlaceMobileButtons.isMobile == false) { lockPickPurchaseText = ""; }

                //Hammer
                hammerDamageText = "Deals +" + (UseConsumable.hammerDamageMultiplier * 100).ToString("F0") + "% <color=green>(+" + (SpecialUpgradesButtons.hammerDamageAmountIncrement * 100) + "%)<color=white>" + " active damage for " + SpecialUpgradesButtons.hammerTimer + " <color=green>(+" + (SpecialUpgradesButtons.hammerTimerIncrement) + "S)<color=white> seconds";
                hammerDropChanceText = SpecialUpgradesButtons.hammerDropChance.ToString("F2") + "% Chance to drop from a chest " + "<color=green>(+" + SpecialUpgradesButtons.hammerDropChanceIncrement.ToString("F3") + "%)<color=green>";
                if (PlaceMobileButtons.isMobile == false) { hammerPurchaseText = ""; }
                //Key

                keyRareDropChanceText = SpecialUpgradesButtons.keyRareDropChance.ToString("F2") + "% Chance to drop a treasure from a chest " + "<color=green>(+" + SpecialUpgradesButtons.keyRareDropChanceIncrement + "%)<color=green>";

                keyDropChanceText = SpecialUpgradesButtons.keyDropChance.ToString("F2") + "% Chance to drop from a chest " + "<color=green>(+" + SpecialUpgradesButtons.keyDropChanceIncrement.ToString("F3") + "%)<color=green>";
                if (PlaceMobileButtons.isMobile == false) { keyPurchaseText = ""; }

                //GoldenTouch
                goldenTouchTimerText = "Chests spawn 6-10 more gold coins for " + SpecialUpgradesButtons.goldenTouchTimer + " <color=green>(+" + SpecialUpgradesButtons.goldenTouchTimerIncrement + "S)<color=white>" + " seconds";

                goldenTouchDropChance = SpecialUpgradesButtons.goldenTouchDropChance.ToString("F2") + "% Chance to drop from a chest " + "<color=green>(+" + SpecialUpgradesButtons.goldenTouchDropChanceIncrement.ToString("F3") + "%)<color=green>";
                if (PlaceMobileButtons.isMobile == false) { goldenTouchPurchaseText = ""; }

                //TreasureBag
                treasureChestDropChanceText = SpecialUpgradesButtons.treasureBagDropChance.ToString("F2") + "%<color=green>(+" + SpecialUpgradesButtons.treasureBagDropChanceIncrement.ToString("F3") + "%)<color=white> Chance to drop a treasure bag from a chest ";
                if (PlaceMobileButtons.isMobile == false) { treasureBagPurchaseText = ""; }

                //XPPotion
                XPPotionDropChanceText = SpecialUpgradesButtons.XPPotionDropChance.ToString("F2") + "% Chance to drop from a chest " + "<color=green>(+" + SpecialUpgradesButtons.XPPotionDropChanceIncrement.ToString("F3") + "%)<color=green>";

                xpPotionBuffText = "Gives +" + (SpecialUpgradesButtons.XPPotionXPBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.XPPotionBufFIncrement * 100) + "%)<color=white> XP for the next " + SpecialUpgradesButtons.XPPotionTimer + "<color=green>(+" + SpecialUpgradesButtons.XPPotionTimerMinus + "S) <color=white>seconds";
                if (PlaceMobileButtons.isMobile == false) { XPPotionPurchaseText = ""; }

                //DamagePotion
                damagePotionDropChanceText = SpecialUpgradesButtons.damagePotionDropChance.ToString("F2") + "% Chance to drop from a chest " + "<color=green>(+" + SpecialUpgradesButtons.damagePotionDropChanceIncrement.ToString("F3") + "%)<color=green>";

                damagePotionBuffText = "Deal +" + (SpecialUpgradesButtons.damagePotionBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.damagePotionBuffIncrement * 100) + "%)<color=white> more damage for the next " + SpecialUpgradesButtons.damagePotionTimer + "<color=green>(+" + SpecialUpgradesButtons.damagePotionTimerMinus + "S) <color=white>seconds";
                if (PlaceMobileButtons.isMobile == false) { damagePotionPurchaseText = ""; }

                //LootPotion
                lootpotionBuffText = "Gives +" + (SpecialUpgradesButtons.lootPotionBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.lootPotionBuffIncrement * 100) + "%)<color=white> more gold for the next " + SpecialUpgradesButtons.lootPotionTimer + "<color=green>(+" + SpecialUpgradesButtons.lootPotionTimerMinus + "S) <color=white>seconds";
                if (PlaceMobileButtons.isMobile == false) { lootPotionPurchaseText = ""; }
                lootPotiontDropChanceText = SpecialUpgradesButtons.lootPotionDropChance.ToString("F2") + "% Chance to drop from a chest " + "<color=green>(+" + SpecialUpgradesButtons.lootPotionDropChanceIncrement.ToString("F3") + "%)<color=green>";

                //MiniChest
                miniChestTimerText = "Spawns a small clickable chest every " + SpecialUpgradesButtons.miniChestSpawnTimer + " seconds <color=green>(-" + (SpecialUpgradesButtons.miniChestSpawnTimerMinus) + "S)";
                if (PlaceMobileButtons.isMobile == false) { miniChestPriceText = ""; }

                //Elixir
                elixirDropChance = SpecialUpgradesButtons.elixirDropChance.ToString("F2") + "% Chance to drop from a chest<color=green>(+" + SpecialUpgradesButtons.elixirDropChanceIncrement.ToString("F3") + "%)<color=green>";

                elixirInfo = "Gives +" + (SpecialUpgradesButtons.elixirBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.elixirBuffIncrement * 100) + "%)<color=white>% of the buffs from all 3 potions for the next " + SpecialUpgradesButtons.elixirTimer + "<color=green>(+" + SpecialUpgradesButtons.elixirTimerIncrement + "S) <color=white>seconds";
                if (PlaceMobileButtons.isMobile == false) { elixirPurchase = ""; }

                //Scroll
                scrollDropChance = SpecialUpgradesButtons.scrollDropChance.ToString("F2") + "% Chance to drop from a chest<color=green>(+" + SpecialUpgradesButtons.scrollDropChanceIncrement.ToString("F3") + "%)<color=green>";

                scrollInfo = "Gives a small buff to a random stat for every chest opened for " + SpecialUpgradesButtons.scrollTimer + "<color=green>(+" + SpecialUpgradesButtons.scrollTimerIncrement + "S) <color=white>seconds";
                if (PlaceMobileButtons.isMobile == false) { scrollPurchase = ""; }

                //Gauntlet
                gauntletDropChance = SpecialUpgradesButtons.gauntletDropChance.ToString("F2") + "% Chance to drop from a chest<color=green>(+" + SpecialUpgradesButtons.gauntletDropChanceIncrement.ToString("F3") + "%)<color=green>";

                gauntletInfo = "Every click has a " + SpecialUpgradesButtons.gauntletGoldDropChance + "%<color=green>(+" + SpecialUpgradesButtons.gauntletGoldDropChanceIncrement + "%)<color=white> chance to spawn a gold coin for the next " + SpecialUpgradesButtons.gauntletTimer + "<color=green>(+" + SpecialUpgradesButtons.gauntletTimerIncrement + "S) seconds";
                if (PlaceMobileButtons.isMobile == false) { gauntletPurchase = ""; }

                //Ancient
                relicDropChance = SpecialUpgradesButtons.relicDropChance.ToString("F2") + "% Chance to drop from a chest<color=green>(+" + SpecialUpgradesButtons.relicDropChanceIncrement.ToString("F3") + "%)<color=green>";

                relicInfo = "Gives a permanent buff to a random stat";
                if (PlaceMobileButtons.isMobile == false) { relicPurchase = ""; }

                //Knife
                knifeDropChance = UpdateGame.knifeDropChance.ToString("F2") + "% Chance to drop from a chest<color=green>(+" + UpdateGame.knifeDropChanceIncrement.ToString("F3") + "%)";

                knifeInfo = "Each click instantly opens a chest for the next " + UpdateGame.knifeTimer + " seconds<color=green>(+" + UpdateGame.knifeTimerIncrement + "S) <color=white>and doubles the chest rewards";
                if (PlaceMobileButtons.isMobile == false) { KnifePurhcase = ""; }

                //TreasurePotion
                treasurePotionDropChance = UpdateGame.treasurePotionDropChance.ToString("F2") + "% Chance to drop from a chest<color=green>(+" + UpdateGame.treasurePotionDropChanceIncrement.ToString("F3") + "%)";

                treasurePotionInfo = "+3% Treasure drop chance for the next " + UpdateGame.treasurePotionTimer + " seconds<color=green>(+" + UpdateGame.treasurePotionTimerIncrement + "S)";
                if (PlaceMobileButtons.isMobile == false) { treasurePotionPurchase = ""; }

                //Barrel
                barrelInfo = "Gold coins that lands inside the barrel is worth " + (UpdateGame.barrelGoldValue + 1) + "X<color=green>(+" + UpdateGame.barrelGoldValueIncrement.ToString("F2") + "X)<color=white> more gold. Click on the barrel to collect the gold";

                //Mimic Chest
                mimicChestInfo = UpdateGame.mimicPositiveBuffChance + "% Chance <color=green>(+" + UpdateGame.mimicPositiveBiffChanceIncrement + "%)<color=white> for a temorary positive buff\n" + UpdateGame.mimicNegativeBuffChance + "% Chance <color=green>(-" + UpdateGame.mimicNegativeBuffChanceIncrement + "%)<color=white> for a temporary negative buff";

                mimicChestTimer = "Spawns a <color=red>EVIL<color=white> or <color=green>FRIENDLY<color=white> mimic chest every " + UpdateGame.mimicChestTimer + " seconds<color=green>(-" + UpdateGame.mimicChestTimerIncrement + "S)";
                if (PlaceMobileButtons.isMobile == false) { mimicChestPurchase = ""; }
            }
            #endregion

            //Russian
            #region RussianLanguage
            if (Localization.RussianLanguageChosen == 1)
            {
                //LockPick
                lockPickOpenChanceText = UseConsumable.lockPickSuccessChance + "% Шанс мгновенно открыть сундук " + "<color=green>(+" + SpecialUpgradesButtons.lockPickOpenChanceIncrement + "%)<color=green>";
                lockPickDropChanceText = SpecialUpgradesButtons.lockPickDropChance.ToString("F2") + "% Шанс выпасть из сундука " + "<color=green>(+" + SpecialUpgradesButtons.lockPickDropChanceIncrement.ToString("F3") + "%)<color=green>";
                lockPickPurchaseText = "";

                //Hammer
                hammerDamageText = "Наносит +" + (UseConsumable.hammerDamageMultiplier * 100).ToString("F0") + "% <color=green>(+" + (SpecialUpgradesButtons.hammerDamageAmountIncrement * 100) + "%)<color=white>" + " активного урона в течение " + SpecialUpgradesButtons.hammerTimer + " <color=green>(+" + (SpecialUpgradesButtons.hammerTimerIncrement) + ")<color=white> секунд.";
                hammerDropChanceText = SpecialUpgradesButtons.hammerDropChance.ToString("F2") + "% Шанс выпасть из сундука " + "<color=green>(+" + SpecialUpgradesButtons.hammerDropChanceIncrement.ToString("F3") + "%)<color=green>";
                hammerPurchaseText = "";

                //Key
                keyRareDropChanceText = SpecialUpgradesButtons.keyRareDropChance.ToString("F2") + "% Шанс выпадения сокровища из сундука " + "<color=green>(+" + SpecialUpgradesButtons.keyRareDropChanceIncrement + "%)<color=green>";

                keyDropChanceText = SpecialUpgradesButtons.keyDropChance.ToString("F2") + "% Шанс выпасть из сундука " + "<color=green>(+" + SpecialUpgradesButtons.keyDropChanceIncrement.ToString("F3") + "%)<color=green>";
                keyPurchaseText = "";

                //GoldenTouch
                goldenTouchTimerText = "Сундуки создают от 6 до 10 дополнительных золотых монет в течение " + SpecialUpgradesButtons.goldenTouchTimer + " <color=green>(+" + SpecialUpgradesButtons.goldenTouchTimerIncrement + ")<color=white>" + " секунд";

                goldenTouchDropChance = SpecialUpgradesButtons.goldenTouchDropChance.ToString("F2") + "% Шанс выпасть из сундука " + "<color=green>(+" + SpecialUpgradesButtons.goldenTouchDropChanceIncrement.ToString("F3") + "%)<color=green>";
                goldenTouchPurchaseText = "";

                //TreasureBag
                treasureChestDropChanceText = SpecialUpgradesButtons.treasureBagDropChance.ToString("F2") + "%<color=green>(+" + SpecialUpgradesButtons.treasureBagDropChanceIncrement.ToString("F3") + "%)<color=white> Шанс выпасть мешку с сокровищами из сундука";
                treasureBagPurchaseText = "";

                //XPPotion
                XPPotionDropChanceText = SpecialUpgradesButtons.XPPotionDropChance.ToString("F2") + "% Шанс выпасть из сундука " + "<color=green>(+" + SpecialUpgradesButtons.XPPotionDropChanceIncrement.ToString("F3") + "%)<color=green>";

                xpPotionBuffText = "Дает на +" + (SpecialUpgradesButtons.XPPotionXPBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.XPPotionBufFIncrement * 100) + "%)<color=white>  больше опыта на следующие " + SpecialUpgradesButtons.XPPotionTimer + "<color=green>(+" + SpecialUpgradesButtons.XPPotionTimerMinus + ") <color=white>секунд";
                XPPotionPurchaseText = "";

                //DamagePotion
                damagePotionDropChanceText = SpecialUpgradesButtons.damagePotionDropChance.ToString("F2") + "% Шанс выпасть из сундука " + "<color=green>(+" + SpecialUpgradesButtons.damagePotionDropChanceIncrement.ToString("F3") + "%)<color=green>";

                damagePotionBuffText = "Наносите на +" + (SpecialUpgradesButtons.damagePotionBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.damagePotionBuffIncrement * 100) + "%)<color=white>  больше урона в течение следующих " + SpecialUpgradesButtons.damagePotionTimer + "<color=green>(+" + SpecialUpgradesButtons.damagePotionTimerMinus + ") <color=white>секунд";
                damagePotionPurchaseText = "";

                //LootPotion
                lootpotionBuffText = "Дает на +" + (SpecialUpgradesButtons.lootPotionBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.lootPotionBuffIncrement * 100) + "%)<color=white> больше золота на следующие " + SpecialUpgradesButtons.lootPotionTimer + "<color=green>(+" + SpecialUpgradesButtons.lootPotionTimerMinus + ") <color=white>секунд";
                lootPotionPurchaseText = "";
                lootPotiontDropChanceText = SpecialUpgradesButtons.lootPotionDropChance.ToString("F2") + "% Шанс выпасть из сундука " + "<color=green>(+" + SpecialUpgradesButtons.lootPotionDropChanceIncrement.ToString("F3") + "%)<color=green>";

                //MiniChest
                miniChestTimerText = "Создает маленький, на который можно нажать, сундук каждые " + SpecialUpgradesButtons.miniChestSpawnTimer + " секунд <color=green>(-" + (SpecialUpgradesButtons.miniChestSpawnTimerMinus) + ")";

                miniChestPriceText = "";

                //Elixir
                elixirDropChance = SpecialUpgradesButtons.elixirDropChance.ToString("F2") + "% Шанс выпасть из сундука<color=green>(+" + SpecialUpgradesButtons.elixirDropChanceIncrement.ToString("F3") + "%)<color=green>";

                elixirInfo = "Дает +" + (SpecialUpgradesButtons.elixirBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.elixirBuffIncrement * 100) + "%)<color=white>% баффов от всех трех зелий на следующие " + SpecialUpgradesButtons.elixirTimer + "<color=green>(+" + SpecialUpgradesButtons.elixirTimerIncrement + ") <color=white>секунд";

                elixirPurchase = "";

                //Scroll
                scrollDropChance = SpecialUpgradesButtons.scrollDropChance.ToString("F2") + "% Шанс выпасть из сундука<color=green>(+" + SpecialUpgradesButtons.scrollDropChanceIncrement.ToString("F3") + "%)<color=green>";

                scrollInfo = "Дает небольшой бафф к случайной характеристике для каждого открытого сундука на протяжении " + SpecialUpgradesButtons.scrollTimer + "<color=green>(+" + SpecialUpgradesButtons.scrollTimerIncrement + ") <color=white>секунд";

                scrollPurchase = "";

                //Gauntlet
                gauntletDropChance = SpecialUpgradesButtons.gauntletDropChance.ToString("F2") + "% Шанс выпасть из сундука<color=green>(+" + SpecialUpgradesButtons.gauntletDropChanceIncrement.ToString("F3") + "%)<color=green>";

                gauntletInfo = "Каждый клик с " + SpecialUpgradesButtons.gauntletGoldDropChance + "%<color=green>(+" + SpecialUpgradesButtons.gauntletGoldDropChanceIncrement + "%)<color=white> шансом создает золотую монету на следующие " + SpecialUpgradesButtons.gauntletTimer + "<color=green>(+" + SpecialUpgradesButtons.gauntletTimerIncrement + ") секунд";

                gauntletPurchase = "";

                //Ancient
                relicDropChance = SpecialUpgradesButtons.relicDropChance.ToString("F2") + "% Шанс выпасть из сундука<color=green>(+" + SpecialUpgradesButtons.relicDropChanceIncrement.ToString("F3") + "%)<color=green>";

                relicPurchase = "";

                //Knife
                knifeDropChance = UpdateGame.knifeDropChance.ToString("F2") + "% Шанс выпасть из сундука<color=green>(+" + UpdateGame.knifeDropChanceIncrement.ToString("F3") + "%)";

                knifeInfo = "Каждый клик мгновенно открывает сундук в течение следующих " + UpdateGame.knifeTimer + " секунд<color=green>(+" + UpdateGame.knifeTimerIncrement + ") <color=white>и удваивает награды с сундука";

                KnifePurhcase = "";

                //TreasurePotion
                treasurePotionDropChance = UpdateGame.treasurePotionDropChance.ToString("F2") + "% Шанс выпасть из сундука<color=green>(+" + UpdateGame.treasurePotionDropChanceIncrement.ToString("F3") + "%)";

                treasurePotionInfo = "+3% шанса на выпадение сокровища на следующие " + UpdateGame.treasurePotionTimer + " секунд<color=green>(+" + UpdateGame.treasurePotionTimerIncrement + ")";

                treasurePotionPurchase = "";

                //Barrel
                barrelInfo = "Золотые монеты, попавшие в бочонок, стоят в " + (UpdateGame.barrelGoldValue + 1) + "X<color=green>(+" + UpdateGame.barrelGoldValueIncrement.ToString("F2") + "X)<color=white> раза дороже. Нажмите на бочонок, чтобы собрать золото";

                //Mimic Chest
                mimicChestInfo = UpdateGame.mimicPositiveBuffChance + "% шанс на <color=green>(+" + UpdateGame.mimicPositiveBiffChanceIncrement + "%)<color=white> временный положительный бафф\n" + UpdateGame.mimicNegativeBuffChance + "% шанс на <color=green>(-" + UpdateGame.mimicNegativeBuffChanceIncrement + "%)<color=white> временный отрицательный бафф";

                mimicChestTimer = "Появляется <color=red>ЗЛОБНЫЙ<color=white> или <color=green>ДОБРЫЙ<color=white> сундук-мимик каждые " + UpdateGame.mimicChestTimer + " секунд<color=green>(-" + UpdateGame.mimicChestTimerIncrement + ")";

                mimicChestPurchase = "";
            }
            #endregion

            //Japanese
            #region Japanese Language
            if (Localization.JapaneseLanguageChosen == 1)
            {
                //LockPick
                lockPickOpenChanceText = "即座に胸を開くために" + UseConsumable.lockPickSuccessChance + "％のチャンス" + "<color=green>(+" + SpecialUpgradesButtons.lockPickOpenChanceIncrement + "%)<color=green>";
                lockPickDropChanceText = "胸から落ちる確率" + SpecialUpgradesButtons.lockPickDropChance.ToString("F2") + "%" + "<color=green>(+" + SpecialUpgradesButtons.lockPickDropChanceIncrement.ToString("F3") + "%)<color=green>";
                lockPickPurchaseText = "";

                //Hammer
                hammerDamageText = "" + (UseConsumable.hammerDamageMultiplier * 100).ToString("F0") + "% <color=green>(+" + (SpecialUpgradesButtons.hammerDamageAmountIncrement * 100) + "%)<color=white>" + "のアクティブダメージを" + SpecialUpgradesButtons.hammerTimer + " <color=green>(+" + (SpecialUpgradesButtons.hammerTimerIncrement) + ")<color=white>秒間与える";
                hammerDropChanceText = "胸から落ちる確率" + SpecialUpgradesButtons.hammerDropChance.ToString("F2") + "%" + "<color=green>(+" + SpecialUpgradesButtons.hammerDropChanceIncrement.ToString("F3") + "%)<color=green>";
                hammerPurchaseText = "";

                //Key
                keyRareDropChanceText = SpecialUpgradesButtons.keyRareDropChance.ToString("F2") + "%胸から宝をドロップするチャンス" + "<color=green>(+" + SpecialUpgradesButtons.keyRareDropChanceIncrement + "%)<color=green>";

                keyDropChanceText = "胸から落ちる確率" + SpecialUpgradesButtons.keyDropChance.ToString("F2") + "%" + "<color=green>(+" + SpecialUpgradesButtons.keyDropChanceIncrement.ToString("F3") + "%)<color=green>";
                keyPurchaseText = "";

                //GoldenTouch
                goldenTouchTimerText = "チェストは6-10秒のためのより多くの金貨をスポーン" + SpecialUpgradesButtons.goldenTouchTimer + " <color=green>(+" + SpecialUpgradesButtons.goldenTouchTimerIncrement + ")<color=white>" + "";

                goldenTouchDropChance = "胸から落ちる確率" + SpecialUpgradesButtons.goldenTouchDropChance.ToString("F2") + "%" + "<color=green>(+" + SpecialUpgradesButtons.goldenTouchDropChanceIncrement.ToString("F3") + "%)<color=green>";
                goldenTouchPurchaseText = "";

                //TreasureBag
                treasureChestDropChanceText = "宝の袋を胸から落とす確率" + SpecialUpgradesButtons.treasureBagDropChance.ToString("F2") + "%<color=green>(+" + SpecialUpgradesButtons.treasureBagDropChanceIncrement.ToString("F3") + "%)";
                treasureBagPurchaseText = "";

                //XPPotion
                XPPotionDropChanceText = "胸から落ちる確率" + SpecialUpgradesButtons.XPPotionDropChance.ToString("F2") + "%" + "<color=green>(+" + SpecialUpgradesButtons.XPPotionDropChanceIncrement.ToString("F3") + "%)<color=green>";

                xpPotionBuffText = "+" + (SpecialUpgradesButtons.XPPotionXPBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.XPPotionBufFIncrement * 100) + "%)<color=white>%XP" + SpecialUpgradesButtons.XPPotionTimer + "<color=green>(+" + SpecialUpgradesButtons.XPPotionTimerMinus + ")秒";
                XPPotionPurchaseText = "";

                //DamagePotion
                damagePotionDropChanceText = "胸から落ちる確率" + SpecialUpgradesButtons.damagePotionDropChance.ToString("F2") + "%" + "<color=green>(+" + SpecialUpgradesButtons.damagePotionDropChanceIncrement.ToString("F3") + "%)<color=green>";

                damagePotionBuffText = "+" + (SpecialUpgradesButtons.damagePotionBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.damagePotionBuffIncrement * 100) + "%)<color=white>ダメージ" + SpecialUpgradesButtons.damagePotionTimer + "<color=green>(+" + SpecialUpgradesButtons.damagePotionTimerMinus + ")<color=white>秒";
                damagePotionPurchaseText = "";

                //LootPotion
                lootpotionBuffText = "+" + (SpecialUpgradesButtons.lootPotionBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.lootPotionBuffIncrement * 100) + "%)<color=white>ゴールド" + SpecialUpgradesButtons.lootPotionTimer + "<color=green>(+" + SpecialUpgradesButtons.lootPotionTimerMinus + ")<color=white>秒";
                lootPotionPurchaseText = "";
                lootPotiontDropChanceText = "胸から落ちる確率" + SpecialUpgradesButtons.lootPotionDropChance.ToString("F2") + "%" + "<color=green>(+" + SpecialUpgradesButtons.lootPotionDropChanceIncrement.ToString("F3") + "%)<color=green>";

                //MiniChest
                miniChestTimerText = "クリック可能な小さな胸を" + SpecialUpgradesButtons.miniChestSpawnTimer + "秒ごとにスポーンします<color=green>(-" + (SpecialUpgradesButtons.miniChestSpawnTimerMinus) + ")";

                miniChestPriceText = "";

                //Elixir
                elixirDropChance = "胸から落ちる確率" + SpecialUpgradesButtons.elixirDropChance.ToString("F2") + "%<color=green>(+" + SpecialUpgradesButtons.elixirDropChanceIncrement.ToString("F3") + "%)<color=green>";

                elixirInfo = "与える+" + (SpecialUpgradesButtons.elixirBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.elixirBuffIncrement * 100) + "%)<color=white>%すべてからのバフの3次のためのポーション" + SpecialUpgradesButtons.elixirTimer + "<color=green>(+" + SpecialUpgradesButtons.elixirTimerIncrement + ")<color=white>秒";

                elixirPurchase = "";

                //Scroll
                scrollDropChance = "胸から落ちる確率" + SpecialUpgradesButtons.scrollDropChance.ToString("F2") + "%<color=green>(+" + SpecialUpgradesButtons.scrollDropChanceIncrement.ToString("F3") + "%)<color=green>";

                scrollInfo = "" + SpecialUpgradesButtons.scrollTimer + "<color=green>(+" + SpecialUpgradesButtons.scrollTimerIncrement + ")<color=white>秒間開いたすべての胸のランダムな統計に小さなバフを与えます";

                scrollPurchase = "";

                //Gauntlet
                gauntletDropChance = "胸から落ちる確率" + SpecialUpgradesButtons.gauntletDropChance.ToString("F2") + "%<color=green>(+" + SpecialUpgradesButtons.gauntletDropChanceIncrement.ToString("F3") + "%)<color=green>";

                gauntletInfo = "すべてのクリックは、次の" + SpecialUpgradesButtons.gauntletTimer + "<color=green>(+" + SpecialUpgradesButtons.gauntletTimerIncrement + ")<color=white>秒間金貨をスポーンする" + SpecialUpgradesButtons.gauntletGoldDropChance + "<color=green>(+" + SpecialUpgradesButtons.gauntletGoldDropChanceIncrement + ")％<color=white>のチャンスを持っています";

                gauntletPurchase = "";

                //Ancient
                relicDropChance = "胸から落ちる確率" + SpecialUpgradesButtons.relicDropChance.ToString("F2") + "%<color=green>(+" + SpecialUpgradesButtons.relicDropChanceIncrement.ToString("F3") + "%)<color=green>";

                relicInfo = "ランダムな統計に永続的なバフを与えます";

                relicPurchase = "";

                //Knife
                knifeDropChance = "胸から落ちる確率" + UpdateGame.knifeDropChance.ToString("F2") + "%<color=green>(+" + UpdateGame.knifeDropChanceIncrement.ToString("F3") + "%)";

                knifeInfo = "クリックするたびにすぐに次の" + UpdateGame.knifeTimer + "秒間胸が開き、胸の報酬が2倍になります<color=green>(+" + UpdateGame.knifeTimerIncrement + ")";

                KnifePurhcase = "";

                //TreasurePotion
                treasurePotionDropChance = "胸から落ちる確率" + UpdateGame.treasurePotionDropChance.ToString("F2") + "<color=green>(+" + UpdateGame.treasurePotionDropChanceIncrement.ToString("F3") + "%)";

                treasurePotionInfo = "与える+3%次のための宝のドロップチャンス" + UpdateGame.treasurePotionTimer + "秒<color=green>(+" + UpdateGame.treasurePotionTimerIncrement + ")";

                treasurePotionPurchase = "";

                //Barrel
                barrelInfo = "バレルの中に着地する金貨は、" + (UpdateGame.barrelGoldValue + 1) + "X<color=green>(+" + UpdateGame.barrelGoldValueIncrement.ToString("F2") + ")<color=white>倍の金の価値があります。金を収集するためにバレルをクリックしてください";

                //Mimic Chest
                mimicChestInfo = "一時的な正のバフのための" + UpdateGame.mimicPositiveBuffChance + "%(+" + UpdateGame.mimicPositiveBiffChanceIncrement + "%)<color=white>のチャンス一時的な負のバフのための\n" + UpdateGame.mimicNegativeBuffChance + "%<color=green>(-" + UpdateGame.mimicNegativeBuffChanceIncrement + "%)<color=white> ％のチャンス";

                mimicChestTimer = "悪または友好的な模倣の胸をスポーン" + UpdateGame.mimicChestTimer + "秒ごとにスポーン<color=green>(-" + UpdateGame.mimicChestTimerIncrement + ")";

                mimicChestPurchase = "";
            }
            #endregion

            //Chinese
            #region Chinese Language
            if (Localization.ChineseLanguageChosen == 1)
            {
                //LockPick
                lockPickOpenChanceText = UseConsumable.lockPickSuccessChance + "%  的几率立即打开宝箱。" + "<color=green>(+" + SpecialUpgradesButtons.lockPickOpenChanceIncrement + "%)<color=green>";
                lockPickDropChanceText = SpecialUpgradesButtons.lockPickDropChance.ToString("F2") + "% 从宝箱中掉落的几率" + "<color=green>(+" + SpecialUpgradesButtons.lockPickDropChanceIncrement.ToString("F3") + "%)<color=green>";
                lockPickPurchaseText = "";

                //Hammer
                hammerDamageText = "在接下来的" + SpecialUpgradesButtons.hammerTimer + " <color=green>(+" + SpecialUpgradesButtons.hammerTimerIncrement + ")<color=white>" + "秒内提供" + (UseConsumable.hammerDamageMultiplier * 100) + " <color=green>(+" + (SpecialUpgradesButtons.hammerDamageAmountIncrement * 100) + ")<color=white>%的主动伤害";
                hammerDropChanceText = SpecialUpgradesButtons.hammerDropChance.ToString("F2") + "% 从宝箱中掉落的几率" + "<color=green>(+" + SpecialUpgradesButtons.hammerDropChanceIncrement.ToString("F3") + "%)<color=green>";
                hammerPurchaseText = "";

                //Key
                keyRareDropChanceText = SpecialUpgradesButtons.keyRareDropChance.ToString("F2") + "% 从宝箱中掉落宝物的几率" + "<color=green>(+" + SpecialUpgradesButtons.keyRareDropChanceIncrement + "%)<color=green>";

                keyDropChanceText = SpecialUpgradesButtons.keyDropChance.ToString("F2") + "% 从宝箱中掉落的几率" + "<color=green>(+" + SpecialUpgradesButtons.keyDropChanceIncrement.ToString("F3") + "%)<color=green>";
                keyPurchaseText = "";

                //GoldenTouch
                goldenTouchTimerText = "宝箱在接下来的" + SpecialUpgradesButtons.goldenTouchTimer + " <color=green>(+" + SpecialUpgradesButtons.goldenTouchTimerIncrement + ")<color=white>" + "秒内会多生成6-10个金币";

                goldenTouchDropChance = SpecialUpgradesButtons.goldenTouchDropChance.ToString("F2") + "% 从宝箱中掉落的几率" + "<color=green>(+" + SpecialUpgradesButtons.goldenTouchDropChanceIncrement.ToString("F3") + "%)<color=green>";
                goldenTouchPurchaseText = "";

                //TreasureBag
                treasureChestDropChanceText = SpecialUpgradesButtons.treasureBagDropChance.ToString("F2") + "%<color=green>(+" + SpecialUpgradesButtons.treasureBagDropChanceIncrement.ToString("F3") + "%)<color=white> 从宝箱中掉落宝藏袋的几率";
                treasureBagPurchaseText = "";

                //XPPotion
                XPPotionDropChanceText = SpecialUpgradesButtons.XPPotionDropChance.ToString("F2") + "% 从宝箱中掉落的几率" + "<color=green>(+" + SpecialUpgradesButtons.XPPotionDropChanceIncrement.ToString("F3") + "%)<color=green>";

                xpPotionBuffText = "+" + (SpecialUpgradesButtons.XPPotionXPBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.XPPotionBufFIncrement * 100) + "%)<color=white>XP。" + SpecialUpgradesButtons.XPPotionTimer + "<color=green>(+" + SpecialUpgradesButtons.XPPotionTimerMinus + ") <color=white>秒";
                XPPotionPurchaseText = "";

                //DamagePotion
                damagePotionDropChanceText = SpecialUpgradesButtons.damagePotionDropChance.ToString("F2") + "% 从宝箱中掉落的几率" + "<color=green>(+" + SpecialUpgradesButtons.damagePotionDropChanceIncrement.ToString("F3") + "%)<color=green>";

                damagePotionBuffText = "+" + (SpecialUpgradesButtons.damagePotionBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.damagePotionBuffIncrement * 100) + "%)<color=white>伤害。" + SpecialUpgradesButtons.damagePotionTimer + "<color=green>(+" + SpecialUpgradesButtons.damagePotionTimerMinus + ")<color=white>4秒。";
                damagePotionPurchaseText = "";

                //LootPotion
                lootpotionBuffText = "+" + (SpecialUpgradesButtons.lootPotionBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.lootPotionBuffIncrement * 100) + "%)<color=white>金币。" + SpecialUpgradesButtons.lootPotionTimer + "<color=green>(+" + SpecialUpgradesButtons.lootPotionTimerMinus + ")<color=white>秒。";
                lootPotionPurchaseText = "";
                lootPotiontDropChanceText = SpecialUpgradesButtons.lootPotionDropChance.ToString("F2") + "% 从宝箱中掉落的几率" + "<color=green>(+" + SpecialUpgradesButtons.lootPotionDropChanceIncrement.ToString("F3") + "%)<color=green>";

                //MiniChest
                miniChestTimerText = "每" + SpecialUpgradesButtons.miniChestSpawnTimer + "秒生成一个小宝箱可点击<color=green>(-" + (SpecialUpgradesButtons.miniChestSpawnTimerMinus) + ")";

                miniChestPriceText = "";

                //Elixir
                elixirDropChance = SpecialUpgradesButtons.elixirDropChance.ToString("F2") + "% 从宝箱中掉落的几率<color=green>(+" + SpecialUpgradesButtons.elixirDropChanceIncrement.ToString("F3") + "%)<color=green>";

                elixirInfo = "从所有3种药水中获得" + (SpecialUpgradesButtons.elixirBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.elixirBuffIncrement * 100) + "%)<color=white>%的奖励。持续" + SpecialUpgradesButtons.elixirTimer + "<color=green>(+" + SpecialUpgradesButtons.elixirTimerIncrement + ")<color=white>秒。";

                elixirPurchase = "";

                //Scroll
                scrollDropChance = SpecialUpgradesButtons.scrollDropChance.ToString("F2") + "% 从宝箱中掉落的几率<color=green>(+" + SpecialUpgradesButtons.scrollDropChanceIncrement.ToString("F3") + "%)<color=green>";

                scrollInfo = "为每个打开的宝箱提供随机的短暂加成，持续" + SpecialUpgradesButtons.scrollTimer + "<color=green>(+" + SpecialUpgradesButtons.scrollTimerIncrement + ")<color=white>秒";

                scrollPurchase = "";

                //Gauntlet
                gauntletDropChance = SpecialUpgradesButtons.gauntletDropChance.ToString("F2") + "% 从宝箱中掉落的几率<color=green>(+" + SpecialUpgradesButtons.gauntletDropChanceIncrement.ToString("F3") + "%)<color=green>";

                gauntletInfo = "在接下来的" + SpecialUpgradesButtons.gauntletTimer + "<color=green>(+" + SpecialUpgradesButtons.gauntletTimerIncrement + ")<color=white>秒内，每次点击都有 " + SpecialUpgradesButtons.gauntletGoldDropChance + "%<color=green>(+" + SpecialUpgradesButtons.gauntletGoldDropChanceIncrement + ")<color=white>的几率生成一个金币";

                gauntletPurchase = "";

                //Ancient
                relicDropChance = SpecialUpgradesButtons.relicDropChance.ToString("F2") + "% 从宝箱中掉落的几率<color=green>(+" + SpecialUpgradesButtons.relicDropChanceIncrement.ToString("F3") + "%)<color=green>";

                relicInfo = "为随机属性提供永久加成";

                relicPurchase = "";

                //Knife
                knifeDropChance = UpdateGame.knifeDropChance.ToString("F2") + "% 从宝箱中掉落的几率<color=green>(+" + UpdateGame.knifeDropChanceIncrement.ToString("F3") + "%)";

                knifeInfo = "接下来的" + UpdateGame.knifeTimer + "<color=green>(+" + UpdateGame.knifeTimerIncrement + ") <color=white>秒内，每次点击都会立即打开一个宝箱并使宝箱奖励翻倍";

                KnifePurhcase = "";

                //TreasurePotion
                treasurePotionDropChance = UpdateGame.treasurePotionDropChance.ToString("F2") + "% 从宝箱中掉落的几率<color=green>(+" + UpdateGame.treasurePotionDropChanceIncrement.ToString("F3") + "%)";

                treasurePotionInfo = "在接下来的" + UpdateGame.treasurePotionTimer + "秒内，提供+3%的宝藏掉落几率<color=green>(+" + UpdateGame.treasurePotionTimerIncrement + ")";

                treasurePotionPurchase = "";

                //Barrel
                barrelInfo = "落入桶中的金币价值增加" + (UpdateGame.barrelGoldValue + 1) + "X<color=green>(+" + UpdateGame.barrelGoldValueIncrement.ToString("F2") + ")<color=white>倍。点击桶收集金币。";

                //Mimic Chest
                mimicChestInfo = UpdateGame.mimicPositiveBuffChance + "%的几率获得临时正面增益<color=green>(+" + UpdateGame.mimicPositiveBiffChanceIncrement + "%)<color=white>\n" + UpdateGame.mimicNegativeBuffChance + "%<color=green>(-" + UpdateGame.mimicNegativeBuffChanceIncrement + "%)<color=white>的几率获得临时负面增益";

                mimicChestTimer = "每" + UpdateGame.mimicChestTimer + "秒生成一个邪恶或友好的模仿宝箱<color=green>(-" + UpdateGame.mimicChestTimerIncrement + ")";

                mimicChestPurchase = "";
            }
            #endregion

            //English
            #region Korean Language
            if (Localization.KoreanLanguageChosen == 1)
            {
                //LockPick
                lockPickOpenChanceText = "상자를 즉시 오픈할 가능성 " + UseConsumable.lockPickSuccessChance + "%" + "<color=green>(+" + SpecialUpgradesButtons.lockPickOpenChanceIncrement + "%)<color=green>";
                lockPickDropChanceText = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.lockPickDropChance.ToString("F2") + "%" + "<color=green>(+" + SpecialUpgradesButtons.lockPickDropChanceIncrement.ToString("F3") + "%)<color=green>";
                lockPickPurchaseText = "";

                //Hammer
                hammerDamageText = "" + SpecialUpgradesButtons.hammerTimer + "초간<color=green>(+" + SpecialUpgradesButtons.hammerTimerIncrement + ")<color=white>" + (UseConsumable.hammerDamageMultiplier * 100).ToString("F0") + " 의 액티브 데미지를 가합니다. <color=green>(+" + (SpecialUpgradesButtons.hammerDamageAmountIncrement * 100) + ")<color=white>";

                hammerDropChanceText = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.hammerDropChance.ToString("F2") + "%" + "<color=green>(+" + SpecialUpgradesButtons.hammerDropChanceIncrement.ToString("F3") + "%)<color=green>";
                hammerPurchaseText = "";

                //Key
                keyRareDropChanceText = "상자로부터 보물을 드롭할 가능성" + SpecialUpgradesButtons.keyRareDropChance.ToString("F2") + "%" + "<color=green>(+" + SpecialUpgradesButtons.keyRareDropChanceIncrement + "%)<color=green>";

                keyDropChanceText = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.keyDropChance.ToString("F2") + "%" + "<color=green>(+" + SpecialUpgradesButtons.keyDropChanceIncrement.ToString("F3") + "%)<color=green>";
                keyPurchaseText = "";

                //GoldenTouch
                goldenTouchTimerText = "상자는 " + SpecialUpgradesButtons.goldenTouchTimer + " <color=green>(+" + SpecialUpgradesButtons.goldenTouchTimerIncrement + ")<color=white>" + "초간 6-10개의 골드 코인을 더 스폰합니다. ";

                goldenTouchDropChance = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.goldenTouchDropChance.ToString("F2") + "%" + "<color=green>(+" + SpecialUpgradesButtons.goldenTouchDropChanceIncrement.ToString("F3") + "%)<color=green>";
                goldenTouchPurchaseText = "";

                //TreasureBag
                treasureChestDropChanceText = "상자로부터 보물을 드롭할 가능성 " + SpecialUpgradesButtons.treasureBagDropChance.ToString("F2") + "%<color=green>(+" + SpecialUpgradesButtons.treasureBagDropChanceIncrement.ToString("F3") + "%)<color=white>";
                treasureBagPurchaseText = "";

                //XPPotion
                XPPotionDropChanceText = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.XPPotionDropChance.ToString("F2") + "%" + "<color=green>(+" + SpecialUpgradesButtons.XPPotionDropChanceIncrement.ToString("F3") + "%)<color=green>";

                xpPotionBuffText = "+" + (SpecialUpgradesButtons.XPPotionXPBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.XPPotionBufFIncrement * 100) + "%)<color=white> XP. " + SpecialUpgradesButtons.XPPotionTimer + "<color=green>(+" + SpecialUpgradesButtons.XPPotionTimerMinus + ") <color=white>초.";
                XPPotionPurchaseText = "";

                //DamagePotion
                damagePotionDropChanceText = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.damagePotionDropChance.ToString("F2") + "%" + "<color=green>(+" + SpecialUpgradesButtons.damagePotionDropChanceIncrement.ToString("F3") + "%)<color=green>";

                damagePotionBuffText = "+" + (SpecialUpgradesButtons.damagePotionBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.damagePotionBuffIncrement * 100) + "%)<color=white>데미지. " + SpecialUpgradesButtons.damagePotionTimer + "<color=green>(+" + SpecialUpgradesButtons.damagePotionTimerMinus + ")<color=white>초.";
                damagePotionPurchaseText = "";

                //LootPotion
                lootpotionBuffText = "+" + (SpecialUpgradesButtons.lootPotionBuff * 100).ToString("F0") + "%<color=green>(+" + (SpecialUpgradesButtons.lootPotionBuffIncrement * 100) + "%)<color=white>골드. " + SpecialUpgradesButtons.lootPotionTimer + "<color=green>(+" + SpecialUpgradesButtons.lootPotionTimerMinus + ")<color=white>초.";
                lootPotionPurchaseText = "";
                lootPotiontDropChanceText = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.lootPotionDropChance.ToString("F2") + "%" + "<color=green>(+" + SpecialUpgradesButtons.lootPotionDropChanceIncrement.ToString("F3") + "%)<color=green>";

                //MiniChest
                miniChestTimerText = "매 " + SpecialUpgradesButtons.miniChestSpawnTimer + "초마다 클릭할 수 있는 작은 상자 1개를 스폰합니다<color=green>(-" + (SpecialUpgradesButtons.miniChestSpawnTimerMinus) + ")";

                miniChestPriceText = "";

                //Elixir
                elixirDropChance = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.elixirDropChance.ToString("F2") + "%<color=green>(+" + SpecialUpgradesButtons.elixirDropChanceIncrement.ToString("F3") + "%)<color=green>";

                elixirInfo = "" + SpecialUpgradesButtons.elixirTimer + "<color=green>(+" + (SpecialUpgradesButtons.elixirTimerIncrement) + "%)<color=white>초간 3개의 포션 모두로부터 " + (SpecialUpgradesButtons.elixirBuff * 100).ToString("F0") + "<color=green>(+" + SpecialUpgradesButtons.elixirBuffIncrement + ") <color=white>%의 버프를 부여합니다";

                elixirPurchase = "";

                //Scroll
                scrollDropChance = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.scrollDropChance.ToString("F2") + "%<color=green>(+" + SpecialUpgradesButtons.scrollDropChanceIncrement.ToString("F3") + "%)<color=green>";

                scrollInfo = "매번 상자가 오픈될 때마다" + SpecialUpgradesButtons.scrollTimer + "<color=green>(+" + SpecialUpgradesButtons.scrollTimerIncrement + ") <color=white>초간 랜덤한 스탯에 작은 버프를 부여합니다.";

                scrollPurchase = "";

                //Gauntlet
                gauntletDropChance = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.gauntletDropChance.ToString("F2") + "%<color=green>(+" + SpecialUpgradesButtons.gauntletDropChanceIncrement.ToString("F3") + "%)<color=green>";

                gauntletInfo = "모든 클릭은 " + SpecialUpgradesButtons.gauntletTimer + "%<color=green>(+" + SpecialUpgradesButtons.gauntletTimerIncrement + "%)<color=white>초간 골드 코인을 스폰할 확률" + SpecialUpgradesButtons.gauntletGoldDropChance + "<color=green>(+" + SpecialUpgradesButtons.gauntletGoldDropChanceIncrement + ") %를 <color=white>얻습니다. ";

                gauntletPurchase = "";

                //Ancient
                relicDropChance = "상자로부터 드롭할 가능성 " + SpecialUpgradesButtons.relicDropChance.ToString("F2") + "%<color=green>(+" + SpecialUpgradesButtons.relicDropChanceIncrement.ToString("F3") + "%)<color=green>";

                relicInfo = "랜덤한 스탯에 영구적인 버프를 부여합니다";

                relicPurchase = "";

                //Knife
                knifeDropChance = "상자로부터 드롭할 가능성 " + UpdateGame.knifeDropChance.ToString("F2") + "%<color=green>(+" + UpdateGame.knifeDropChanceIncrement.ToString("F3") + "%)";

                knifeInfo = "" + UpdateGame.knifeTimer + "<color=green>(+" + UpdateGame.knifeTimerIncrement + ") <color=white>초간 모든 클릭은 상자를 즉각적으로 오픈하고 상자 리워드를 두 배로 얻게 합니다 ";

                KnifePurhcase = "";

                //TreasurePotion
                treasurePotionDropChance = "상자로부터 드롭할 가능성 " + UpdateGame.treasurePotionDropChance.ToString("F2") + "%<color=green>(+" + UpdateGame.treasurePotionDropChanceIncrement.ToString("F3") + "%)";

                treasurePotionInfo = "" + UpdateGame.treasurePotionTimer + "<color=green>(+" + UpdateGame.treasurePotionTimerIncrement + ")<color=white>초간 보물 드롭 확률 3%를 추가로 부여합니다";

                treasurePotionPurchase = "";

                //Barrel
                barrelInfo = "배럴 안에 떨어지는 골드 코인은 " + (UpdateGame.barrelGoldValue + 1) + "<color=green>(+" + UpdateGame.barrelGoldValueIncrement.ToString("F2") + ")<color=white>배의 가치를 지니고 있습니다. 골드를 수집하기 위해서 바렐을 클릭하세요";

                //Mimic Chest
                mimicChestInfo = "일시적인 긍정 버프에 대한 확률 " + UpdateGame.mimicPositiveBuffChance + "<color=green>(+" + UpdateGame.mimicPositiveBiffChanceIncrement + "%)<color=white>\n" + "일시적인 부정 버프에 대한 확률" + UpdateGame.mimicNegativeBuffChance + "<color=green>(-" + UpdateGame.mimicNegativeBuffChanceIncrement + "%)<color=white>";

                mimicChestTimer = "악의적/우호적인 모방 상자를 매" + UpdateGame.mimicChestTimer + "초마다 스폰합니다<color=green>(-" + UpdateGame.mimicChestTimerIncrement + ")";

                mimicChestPurchase = "";
            }
            #endregion

            UpdateGame.changeItemUpdate = true;
            SpecialUpgradesButtons.changeText = true;
            hoverSpecialChance = false;
        }
    }
}
