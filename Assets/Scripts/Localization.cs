using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Localization : MonoBehaviour
{
    //Item/Shop hover text changes inside HoverSpecialString
    //Chicken Buff text changes inside RareTreasures
    //Barrel hover inside UpdateGame

    //Add this to japan font ホ
    public SpecialUpgradesButtons specialScript;

    public static int EnglishLanguageChosen, RussianLanguageChosen, JapaneseLanguageChosen, ChineseLanguageChosen, KoreanLanguageChosen;

    void Start()
    {
        if (!PlayerPrefs.HasKey("SaveEnglish"))
        {
            EnglishLanguage();
        }
        else
        {
            EnglishLanguageChosen = PlayerPrefs.GetInt("SaveEnglish");
            RussianLanguageChosen = PlayerPrefs.GetInt("SaveRussian");
            JapaneseLanguageChosen = PlayerPrefs.GetInt("SaveJapanese");
            ChineseLanguageChosen = PlayerPrefs.GetInt("SaveChinese");
            KoreanLanguageChosen = PlayerPrefs.GetInt("SaveKorean");
            if(EnglishLanguageChosen == 1) { EnglishLanguage(); }
            if (RussianLanguageChosen == 1) { RussianLanguage(); }
            if (JapaneseLanguageChosen == 1) { JapaneseLanguage(); }
            if (ChineseLanguageChosen == 1) { ChineseLanguage(); }
            if (KoreanLanguageChosen == 1) { KoreanLanguage(); }
        }
    }

    public TMP_FontAsset AlataRegular, ChangaBoldSDF, ChangaBoldSDF1, MontserratMediumSDF1, MontserratExtraLight, MontserratRegular, MontserratBold, MontserratSemiBold, changaMedium, liberationSans, robotoBold, myriadPro;

    public TMP_FontAsset russianLight, russianNono_SemiSkinny, russianNono_Medium, russianNono_MediumOutLine, russianNono_Bold, russian_SemiBold, russianNonoBoldOutLine;

    public TMP_FontAsset japaneseLight, japaneseRegular, japaneseMedium, japaneseMediumOutline, japaneseBold, japaneseBoldOutline, japaneseSemiBold;

    public TMP_FontAsset chineseFont, chineseRegulatOutline, chineseBoldOutline;

    public TMP_FontAsset koreanFont;

    //Light (Light) = MontserratExtraLight and MontserratRegular

    //Semi Skinny (Regular) = liberationSans and myriadPro

    //Medium (Medium) = MontserratBold and AlataRegular and MontserratSemiBold

    //Medium Outline (Medium With outline edited) = MontserratMediumSDF1

    //Semi Bold (Semi Bold) = changaMedium

    //Bold (Bold) = ChangaBoldSDF and robotoBold

    //Bold Outline (Bold) = ChangaBoldSDF1

    public UpdateGame updateGame;
    public ClickPower clickPower;
    public RareTreasures rareTreasure;
    public SelectChests selectChests;

    [Header("Settings")]
    #region Settings Variables
    public TextMeshProUGUI settings_text;
    public TextMeshProUGUI general_text;
    public TextMeshProUGUI info_text;
    public TextMeshProUGUI music_text;
    public TextMeshProUGUI sound_text;
    public TextMeshProUGUI miniChestAndMimicChestSpawnSound_text;
    public TextMeshProUGUI mimicChestSpawning_text;
    public TextMeshProUGUI fullscreen_text;
    public TextMeshProUGUI onFullScreen_text;
    public TextMeshProUGUI offFullScreen_text;
    public TextMeshProUGUI onMimicSpawn_text;
    public TextMeshProUGUI offMimicSpawn_text;
    public TextMeshProUGUI onMiniAndMimicSound_text;
    public TextMeshProUGUI offMiniAndMimicSound_text;
    public TextMeshProUGUI resolution_text;
    public TextMeshProUGUI exit_text;
    public TextMeshProUGUI save_text;
    public TextMeshProUGUI gameSavesEvery15Seconds_text;
    public TextMeshProUGUI cantSaveDuringPrestige_text;
    public TextMeshProUGUI resetGame_text;
    public TextMeshProUGUI discord_text;
    public TextMeshProUGUI numberOfCoinsAndTreasuresOnScreen_text;
    public TextMeshProUGUI reinforcedChests_text;
    public TextMeshProUGUI reinforcedChestsDescription_text;
    public TextMeshProUGUI reinforcedChestsDescription_text2;
    public TextMeshProUGUI enchantedGoldenChests_text;
    public TextMeshProUGUI enchantedGoldenChestsDescription_text;
    public TextMeshProUGUI bossChests_text;
    public TextMeshProUGUI bossChestsDescription_text;
    public TextMeshProUGUI musicBy_text;
    public TextMeshProUGUI developerInfo_text;
    public TextMeshProUGUI resetConfirmation_text;
    public TextMeshProUGUI yes_text;
    public TextMeshProUGUI no_text;
    public TextMeshProUGUI gameSaves_Text;
    #endregion

    [Header("Stats")]
    #region Stats Variables
    public TextMeshProUGUI stats_text;
    public TextMeshProUGUI goldCoinsDropped_text;
    public TextMeshProUGUI totalGoldReceived_text;
    public TextMeshProUGUI totalBarrelGold_text;
    public TextMeshProUGUI treasuresDropped_text;
    public TextMeshProUGUI commonTreasures_text;
    public TextMeshProUGUI uncommonTreasures_text;
    public TextMeshProUGUI rareTreasures_text;
    public TextMeshProUGUI veryRareTreasures_text;
    public TextMeshProUGUI extremelyRareTreasures_text;
    public TextMeshProUGUI legendaryTreasures_text;
    public TextMeshProUGUI ultraTreasures_text;
    public TextMeshProUGUI mythicTreasures_text;
    public TextMeshProUGUI eternalTreasures_text;
    public TextMeshProUGUI treasuresDoubled_text;
    public TextMeshProUGUI chestsOpened_text;
    public TextMeshProUGUI reinforcedChestsOpened_text;
    public TextMeshProUGUI enchantedGoldenChestsOpened_text;
    public TextMeshProUGUI bossChestsOpened_text;
    public TextMeshProUGUI chestClicks_text;
    public TextMeshProUGUI autoClicks_text;
    public TextMeshProUGUI criticalHits_text;
    public TextMeshProUGUI activeDamage_text;
    public TextMeshProUGUI passiveDamage_text;
    public TextMeshProUGUI critChance_text;
    public TextMeshProUGUI critDamage_text;
    public TextMeshProUGUI cursorsLeveledUp_text;
    public TextMeshProUGUI coinsSpawnedFromClicks_text;
    public TextMeshProUGUI treasuresSpawnedFromClicks_text;
    public TextMeshProUGUI itemsUsed_text;
    public TextMeshProUGUI itemsDropped_text;
    public TextMeshProUGUI itemsPurchased_text;
    public TextMeshProUGUI itemsLeveledUp_text;
    public TextMeshProUGUI prestigeCount_text;
    public TextMeshProUGUI prestigeUpgradesPurchased_text;
    public TextMeshProUGUI skillPointsReceived_text;
    public TextMeshProUGUI goldIncrease_text;
    public TextMeshProUGUI xpIncrease_text;
    public TextMeshProUGUI activeDamageIncrease_text;
    public TextMeshProUGUI passiveDamageIncrease_text;
    public TextMeshProUGUI critChanceIncrease_text;
    public TextMeshProUGUI critDamageIncrease_text;
    public TextMeshProUGUI treasureChanceIncrease_text;
    public TextMeshProUGUI goldCoins5xDropped_text;
    public TextMeshProUGUI goldCoins10xDropped_text;
    public TextMeshProUGUI goldCoins25xDropped_text;
    public TextMeshProUGUI goldCoins100xDropped_text;

    public TextMeshProUGUI goldAndTreasures_text, chests_text, damage_text, items, buffsAndPrestige_text;
    #endregion

    [Header("Achievements")]
    #region Achievement variables
    //10
    public TextMeshProUGUI achievements_text;
    public TextMeshProUGUI drop25GoldCoins_text;
    public TextMeshProUGUI drop1000GoldCoins_text;
    public TextMeshProUGUI drop100000GoldCoins_text;
    public TextMeshProUGUI drop1MillionGoldCoins_text;
    public TextMeshProUGUI total100Gold_text;
    public TextMeshProUGUI total100000Gold_text;
    public TextMeshProUGUI total1MillionGold_text;
    public TextMeshProUGUI total1BillionGold_text;
    public TextMeshProUGUI total1TrillionGold_text;

    //20
    public TextMeshProUGUI total1QuadrillionGold_text;
    public TextMeshProUGUI total1QuintillionGold_text;
    public TextMeshProUGUI total1SextillionGold_text;
    public TextMeshProUGUI total1SeptillionGold_text;
    public TextMeshProUGUI total1OctillionGold_text;
    public TextMeshProUGUI total1NonillionGold_text;
    public TextMeshProUGUI total1DecillionGold_text;
    public TextMeshProUGUI total1NovemdecillionGold_text;
    public TextMeshProUGUI drop5XGoldCoin_text;
    public TextMeshProUGUI drop1000_5XGoldCoins_text;

    //30
    public TextMeshProUGUI drop50000_5XGoldCoins_text;
    public TextMeshProUGUI drop10XGoldCoin_text;
    public TextMeshProUGUI drop1000_10XGoldCoins_text;
    public TextMeshProUGUI drop15000_10XGoldCoins_text;
    public TextMeshProUGUI spawn10GoldCoinsFromClicks_text;
    public TextMeshProUGUI spawn100GoldCoinsFromClicks_text;
    public TextMeshProUGUI spawn1000GoldCoinsFromClicks_text;
    public TextMeshProUGUI oneTreasureDropped_text;
    public TextMeshProUGUI hundredTreasuresDropped_text;
    public TextMeshProUGUI thousandTreasuresDropped_text;

    //40
    public TextMeshProUGUI tenThousandTreasuresDropped_text;
    public TextMeshProUGUI fiftyThousandTreasuresDropped_text;
    public TextMeshProUGUI hundredCommonTreasures_text;
    public TextMeshProUGUI hundredUncommonTreasures_text;
    public TextMeshProUGUI hundredRareTreasures_text;
    public TextMeshProUGUI hundredVeryRareTreasures_text;
    public TextMeshProUGUI hundredExtremelyRareTreasures_text;
    public TextMeshProUGUI hundredLegendaryTreasures_text;
    public TextMeshProUGUI spawn10TreasuresFromClicks_text;
    public TextMeshProUGUI spawn100TreasuresFromClicks_text;

    //50
    public TextMeshProUGUI spawn1000TreasuresFromClicks_text;
    public TextMeshProUGUI hundredTreasuresDoubled_text;
    public TextMeshProUGUI find1RareTreasure_text;
    public TextMeshProUGUI find3RareTreasures_text;
    public TextMeshProUGUI find5RareTreasures_text;
    public TextMeshProUGUI find13RareTreasures_text;
    public TextMeshProUGUI findAll25RareTreasures_text;
    public TextMeshProUGUI findTheCookie_text;
    public TextMeshProUGUI cookieClicker_text;
    public TextMeshProUGUI prestige_text;

    //60
    public TextMeshProUGUI prestige5Times_text;
    public TextMeshProUGUI prestige15Times_text;
    public TextMeshProUGUI purchase5PrestigeUpgrades_text;
    public TextMeshProUGUI purchase15PrestigeUpgrades_text;
    public TextMeshProUGUI purchase35PrestigeUpgrades_text;
    public TextMeshProUGUI purchase60PrestigeUpgrades_text;
    public TextMeshProUGUI purchaseAllPrestigeUpgrades_text;
    public TextMeshProUGUI purchaseAllPrestigeClickerUpgrades_text;
    public TextMeshProUGUI purchaseAllPrestigeLoungerUpgrades_text;
    public TextMeshProUGUI purchaseAllPrestigePirateUpgrades_text;

    //70
    public TextMeshProUGUI purchaseAllPrestigeHoarderUpgrades_text;
    public TextMeshProUGUI purchaseAllPrestigeAdventurerUpgrades_text;
    public TextMeshProUGUI purchaseLootPotion_text;
    public TextMeshProUGUI purchaseGoldenTouch_text;
    public TextMeshProUGUI purchaseSerendipityScroll_text;
    public TextMeshProUGUI purchaseKey_text;
    public TextMeshProUGUI purchaseMagicalElixir_text;
    public TextMeshProUGUI purchaseAncientRelic_text;
    public TextMeshProUGUI purchaseEnchantedHammer_text;
    public TextMeshProUGUI openChest_text;

    //80
    public TextMeshProUGUI open100Chests_text;
    public TextMeshProUGUI open1000Chests_text;
    public TextMeshProUGUI open10000Chests_text;
    public TextMeshProUGUI open100000Chests_text;
    public TextMeshProUGUI open200000Chests_text;
    public TextMeshProUGUI purchaseChestNo2_text;
    public TextMeshProUGUI purchaseChestNo5_text;
    public TextMeshProUGUI purchaseChestNo8_text;
    public TextMeshProUGUI purchaseChestNo12_text;
    public TextMeshProUGUI purchaseChestNo15_text;

    //90
    public TextMeshProUGUI purchaseChestNo20_text;
    public TextMeshProUGUI purchaseChestNo24_text;
    public TextMeshProUGUI purchaseChestNo32_text;
    public TextMeshProUGUI purchaseTheFinalChest_text;
    public TextMeshProUGUI openTheFinalChest_text;
    public TextMeshProUGUI openAReinforcedChest_text;
    public TextMeshProUGUI open100ReinforcedChests_text;
    public TextMeshProUGUI open500ReinforcedChests_text;
    public TextMeshProUGUI open1000ReinforcedChests_text;
    public TextMeshProUGUI open100EnchantedGoldenChests_text;

    //100
    public TextMeshProUGUI open100BossChests_text;
    public TextMeshProUGUI receiveTotal50SkillPoints_text;
    public TextMeshProUGUI receiveTotal500SkillPoints_text;
    public TextMeshProUGUI receiveTotal1000SkillPoints_text;
    public TextMeshProUGUI receiveTotal10000SkillPoints_text;
    public TextMeshProUGUI reachLevel10_text;
    public TextMeshProUGUI reachLevel25_text;
    public TextMeshProUGUI reachLevel50_text;
    public TextMeshProUGUI reachLevel100_text;
    public TextMeshProUGUI reachLevel200_text;

    //110
    public TextMeshProUGUI drop1000_25XGoldCoins_text;
    public TextMeshProUGUI drop2MillionGoldCoins_text;
    public TextMeshProUGUI drop100XGoldCoin_text;
    public TextMeshProUGUI haveTotal1UndecillionGold_text;
    public TextMeshProUGUI haveTotal1DuodecillionGold_text;
    public TextMeshProUGUI haveTotal1TredecillionGold_text;
    public TextMeshProUGUI haveTotal1QuattuordecillionGold_text;
    public TextMeshProUGUI haveTotal1QuindecillionGold_text;
    public TextMeshProUGUI haveTotal1SexdecillionGold_text;
    public TextMeshProUGUI haveTotal1SeptendecillionGold_text;

    //120
    public TextMeshProUGUI haveTotal1OctodecillionGold_text;
    public TextMeshProUGUI reachLevel150_text;
    public TextMeshProUGUI receiveTotal20000SkillPoints_text;
    public TextMeshProUGUI chestsHaveDropped100KTreasures_text;
    public TextMeshProUGUI hundredUltraTreasuresDropped_text;
    public TextMeshProUGUI hundredMythicTreasuresDropped_text;
    public TextMeshProUGUI hundredEternalTreasuresDropped_text;
    public TextMeshProUGUI open2500ReinforcedChests_text;
    public TextMeshProUGUI purchaseChestNo37_text;
    public TextMeshProUGUI useTheChicken_text;

    //121
    public TextMeshProUGUI drop250000_5XGoldCoins_text;
    #endregion

    [Header("Cursors")]
    #region Cursors Variables
    public TextMeshProUGUI[] lvlsHover_text = new TextMeshProUGUI[21];
    public TextMeshProUGUI[] equippedHover_text = new TextMeshProUGUI[21];
    public TextMeshProUGUI[] levelUp_text = new TextMeshProUGUI[21];
    public TextMeshProUGUI[] level_text = new TextMeshProUGUI[21];
    public TextMeshProUGUI cursor1ActiveDamage_Text;
    public TextMeshProUGUI cursor1PassiveDamage_Text;
    public TextMeshProUGUI cursor1CritChance_Text;
    public TextMeshProUGUI cursor1CritDamage_Text;
    public TextMeshProUGUI cursor2ActiveDamage_Text;
    public TextMeshProUGUI cursor2PassiveDamage_Text;
    public TextMeshProUGUI cursor2CritChance_Text;
    public TextMeshProUGUI cursor2CritDamage_Text;
    public TextMeshProUGUI cursor3ActiveDamage_Text;
    public TextMeshProUGUI cursor3PassiveDamage_Text;
    public TextMeshProUGUI cursor3CritChance_Text;
    public TextMeshProUGUI cursor3CritDamage_Text;
    public TextMeshProUGUI cursor4ActiveDamage_Text;
    public TextMeshProUGUI cursor4PassiveDamage_Text;
    public TextMeshProUGUI cursor4CritChance_Text;
    public TextMeshProUGUI cursor4CritDamage_Text;
    public TextMeshProUGUI cursor5ActiveDamage_Text;
    public TextMeshProUGUI cursor5PassiveDamage_Text;
    public TextMeshProUGUI cursor5CritChance_Text;
    public TextMeshProUGUI cursor5CritDamage_Text;
    public TextMeshProUGUI cursor6ActiveDamage_Text;
    public TextMeshProUGUI cursor6PassiveDamage_Text;
    public TextMeshProUGUI cursor6CritChance_Text;
    public TextMeshProUGUI cursor6CritDamage_Text;
    public TextMeshProUGUI cursor7ActiveDamage_Text;
    public TextMeshProUGUI cursor7PassiveDamage_Text;
    public TextMeshProUGUI cursor7CritChance_Text;
    public TextMeshProUGUI cursor7CritDamage_Text;
    public TextMeshProUGUI cursor8ActiveDamage_Text;
    public TextMeshProUGUI cursor8PassiveDamage_Text;
    public TextMeshProUGUI cursor8CritChance_Text;
    public TextMeshProUGUI cursor8CritDamage_Text;
    public TextMeshProUGUI cursor9ActiveDamage_Text;
    public TextMeshProUGUI cursor9PassiveDamage_Text;
    public TextMeshProUGUI cursor9CritChance_Text;
    public TextMeshProUGUI cursor9CritDamage_Text;
    public TextMeshProUGUI cursor10ActiveDamage_Text;
    public TextMeshProUGUI cursor10PassiveDamage_Text;
    public TextMeshProUGUI cursor10CritChance_Text;
    public TextMeshProUGUI cursor10CritDamage_Text;
    public TextMeshProUGUI cursor11ActiveDamage_Text;
    public TextMeshProUGUI cursor11PassiveDamage_Text;
    public TextMeshProUGUI cursor11CritChance_Text;
    public TextMeshProUGUI cursor11CritDamage_Text;
    public TextMeshProUGUI cursor12ActiveDamage_Text;
    public TextMeshProUGUI cursor12PassiveDamage_Text;
    public TextMeshProUGUI cursor12CritChance_Text;
    public TextMeshProUGUI cursor12CritDamage_Text;
    public TextMeshProUGUI cursor13ActiveDamage_Text;
    public TextMeshProUGUI cursor13PassiveDamage_Text;
    public TextMeshProUGUI cursor13CritChance_Text;
    public TextMeshProUGUI cursor13CritDamage_Text;
    public TextMeshProUGUI cursor14ActiveDamage_Text;
    public TextMeshProUGUI cursor14PassiveDamage_Text;
    public TextMeshProUGUI cursor14CritChance_Text;
    public TextMeshProUGUI cursor14CritDamage_Text;
    public TextMeshProUGUI cursor15ActiveDamage_Text;
    public TextMeshProUGUI cursor15PassiveDamage_Text;
    public TextMeshProUGUI cursor15CritChance_Text;
    public TextMeshProUGUI cursor15CritDamage_Text;
    public TextMeshProUGUI cursor16ActiveDamage_Text;
    public TextMeshProUGUI cursor16PassiveDamage_Text;
    public TextMeshProUGUI cursor16CritChance_Text;
    public TextMeshProUGUI cursor16CritDamage_Text;
    public TextMeshProUGUI cursor17ActiveDamage_Text;
    public TextMeshProUGUI cursor17PassiveDamage_Text;
    public TextMeshProUGUI cursor17CritChance_Text;
    public TextMeshProUGUI cursor17CritDamage_Text;
    public TextMeshProUGUI cursor18ActiveDamage_Text;
    public TextMeshProUGUI cursor18PassiveDamage_Text;
    public TextMeshProUGUI cursor18CritChance_Text;
    public TextMeshProUGUI cursor18CritDamage_Text;
    public TextMeshProUGUI cursor19ActiveDamage_Text;
    public TextMeshProUGUI cursor19PassiveDamage_Text;
    public TextMeshProUGUI cursor19CritChance_Text;
    public TextMeshProUGUI cursor19CritDamage_Text;
    public TextMeshProUGUI cursor20ActiveDamage_Text;
    public TextMeshProUGUI cursor20PassiveDamage_Text;
    public TextMeshProUGUI cursor20CritChance_Text;
    public TextMeshProUGUI cursor20CritDamage_Text;
    public TextMeshProUGUI cursor21ActiveDamage_Text;
    public TextMeshProUGUI cursor21PassiveDamage_Text;
    public TextMeshProUGUI cursor21CritChance_Text;
    public TextMeshProUGUI cursor21CritDamage_Text;
    public TextMeshProUGUI cursors_text;
    public TextMeshProUGUI cursorsHover_text;
    public TextMeshProUGUI equippedEquals_text;
    public TextMeshProUGUI onlyOneCursorEquipped_text;
    public TextMeshProUGUI equipCursorFitsPlaystyle_text;
    public TextMeshProUGUI uniqueCursorBonus_text;
    public TextMeshProUGUI levelUpCursors_text;
    public TextMeshProUGUI dpsTopBar_text;
    public TextMeshProUGUI clickDamageTopBar_text;
    public TextMeshProUGUI critChanceTopBar_text;
    public TextMeshProUGUI critDamageTopBar_text;
    public TextMeshProUGUI gentleTap_text;
    public TextMeshProUGUI gentleTap2_text;
    public TextMeshProUGUI gentleTapCursorBonus_text;
    public TextMeshProUGUI relaxedPalm_text;
    public TextMeshProUGUI relaxedPalm2_text;
    public TextMeshProUGUI relaxedPalmCursorBonus_text;
    public TextMeshProUGUI galeForce_text;
    public TextMeshProUGUI galeForce2_text;
    public TextMeshProUGUI galeForceCursorBonus_text;
    public TextMeshProUGUI radiantTouch_text;
    public TextMeshProUGUI radiantTouch2_text;
    public TextMeshProUGUI radiantTouchCursorBonus_text;
    public TextMeshProUGUI energySurge_text;
    public TextMeshProUGUI energySurge2_text;
    public TextMeshProUGUI energySurgeCursorBonus_text;
    public TextMeshProUGUI phantomPalm_text;
    public TextMeshProUGUI phantomPalm2_text;
    public TextMeshProUGUI phantomPalmCursorBonus_text;
    public TextMeshProUGUI steelStrike_text;
    public TextMeshProUGUI steelStrike2_text;
    public TextMeshProUGUI steelStrikeCursorBonus_text;
    public TextMeshProUGUI lethalTouch_text;
    public TextMeshProUGUI lethalTouch2_text;
    public TextMeshProUGUI lethalTouchCursorBonus_text;
    public TextMeshProUGUI precisionPoint_text;
    public TextMeshProUGUI precisionPoint2_text;
    public TextMeshProUGUI precisionPointCursorBonus_text;
    public TextMeshProUGUI vortexTap_text;
    public TextMeshProUGUI vortexTap2_text;
    public TextMeshProUGUI vortexTapCursorBonus_text;
    public TextMeshProUGUI cursedClaw_text;
    public TextMeshProUGUI cursedClaw2_text;
    public TextMeshProUGUI cursedClawCursorBonus_text;
    public TextMeshProUGUI sniperClick_text;
    public TextMeshProUGUI sniperClick2_text;
    public TextMeshProUGUI sniperClickCursorBonus_text;
    public TextMeshProUGUI shadowSurge_text;
    public TextMeshProUGUI shadowSurge2_text;
    public TextMeshProUGUI shadowSurgeCursorBonus_text;
    public TextMeshProUGUI cripplingCrush_text;
    public TextMeshProUGUI cripplingCrush2_text;
    public TextMeshProUGUI cripplingCrushCursorBonus_text;
    public TextMeshProUGUI rapidClick_text;
    public TextMeshProUGUI rapidClick2_text;
    public TextMeshProUGUI rapidClickCursorBonus_text;
    public TextMeshProUGUI celestialTouch_text;
    public TextMeshProUGUI celestialTouch2_text;
    public TextMeshProUGUI celestialTouchCursorBonus_text;
    public TextMeshProUGUI arcaneClick_text;
    public TextMeshProUGUI arcaneClick2_text;
    public TextMeshProUGUI arcaneClickCursorBonus_text;
    public TextMeshProUGUI eternalTouch_text;
    public TextMeshProUGUI eternalTouch2_text;
    public TextMeshProUGUI eternalTouchCursorBonus_text;
    public TextMeshProUGUI doomTouch_text;
    public TextMeshProUGUI doomTouch2_text;
    public TextMeshProUGUI doomTouchCursorBonus_text;
    public TextMeshProUGUI solarSweep_text;
    public TextMeshProUGUI solarSweep2_text;
    public TextMeshProUGUI solarSweepCursorBonus_text;
    public TextMeshProUGUI infernoFist_text;
    public TextMeshProUGUI infernoFist2_text;
    public TextMeshProUGUI infernoFistCursorBonus_text;
    public TextMeshProUGUI locked_text;
    public TextMeshProUGUI noNotUnlcoked_text;
    public TextMeshProUGUI unlockedAfterChest_text;
    #endregion

    [Header("Shop And Items")]
    #region Shop and Items Variables
    public TextMeshProUGUI[] itemsPrice_text = new TextMeshProUGUI[17];
    public TextMeshProUGUI[] itemsPriceHover_text = new TextMeshProUGUI[17];
    public TextMeshProUGUI[] itemsLevelUp_text = new TextMeshProUGUI[17];
    public TextMeshProUGUI[] owned_text = new TextMeshProUGUI[17];
    public TextMeshProUGUI[] itemsLvlHover_text = new TextMeshProUGUI[17];

    public TextMeshProUGUI shop_text;
    public TextMeshProUGUI shop2_text;
    public TextMeshProUGUI items_text;
    public TextMeshProUGUI lockpick_text;
    public TextMeshProUGUI lockpick2_text;
    public TextMeshProUGUI lockPickDropChance_text;
    public TextMeshProUGUI lockPickInfo;
    public TextMeshProUGUI lockpickItemBonus_text;
    public TextMeshProUGUI hammer_text;
    public TextMeshProUGUI hammer2_text;
    public TextMeshProUGUI hammerInfo_text;
    public TextMeshProUGUI hammerDropChance_text;
    public TextMeshProUGUI hammerItemBonus_text;
    public TextMeshProUGUI lootPotion_text;
    public TextMeshProUGUI lootPotion2_text;
    public TextMeshProUGUI lootPotionInfo_text;
    public TextMeshProUGUI lootPotionDropChance_text;
    public TextMeshProUGUI lootPotionItemBonus_text;
    public TextMeshProUGUI damagePotion_text;
    public TextMeshProUGUI damagePotion2_text;
    public TextMeshProUGUI damagePotionInfo_text;
    public TextMeshProUGUI damagePotionDropChance_text;
    public TextMeshProUGUI damagePotionItemBonus_text;
    public TextMeshProUGUI xpPotion_text;
    public TextMeshProUGUI xpPotion2_text;
    public TextMeshProUGUI xpPotionInfo_text;
    public TextMeshProUGUI xpPotionDropChance_text;
    public TextMeshProUGUI xpPotionItemBonus_text;
    public TextMeshProUGUI goldenTouch_text;
    public TextMeshProUGUI goldenTouch2_text;
    public TextMeshProUGUI goldenTouchInfo_text;
    public TextMeshProUGUI goldenTouchDropChance_text;
    public TextMeshProUGUI goldenTouchItemBonus_text;
    public TextMeshProUGUI miniChestMaxHover_text;
    public TextMeshProUGUI miniChest_text;
    public TextMeshProUGUI miniChest2_text;
    public TextMeshProUGUI miniChestInfo_text;
    public TextMeshProUGUI miniChestUpgradeBonus_text;
    public TextMeshProUGUI key_text;
    public TextMeshProUGUI key2_text;
    public TextMeshProUGUI keyInstantlOpens_text;
    public TextMeshProUGUI keyInfo_text;
    public TextMeshProUGUI keyDropChance_text;
    public TextMeshProUGUI keyItemBonus_text;
    public TextMeshProUGUI treasureBag_text;
    public TextMeshProUGUI treasureBag2_text;
    public TextMeshProUGUI treasureBagInfo_text;
    public TextMeshProUGUI treasureBagDrop_text;
    public TextMeshProUGUI treasureBagItemBonus_text;
    public TextMeshProUGUI serendipityScroll_text;
    public TextMeshProUGUI serendipityScroll2_text;
    public TextMeshProUGUI serendipityScrollInfo_text;
    public TextMeshProUGUI serendipityScollDropChance_text;
    public TextMeshProUGUI serendipityScrollStatsReset_text;
    public TextMeshProUGUI gauntletOfGreed_text;
    public TextMeshProUGUI gauntletOfGreed2_text;
    public TextMeshProUGUI gauntletOfGreenInfo_text;
    public TextMeshProUGUI gauntletOfGreenDropChance_text;
    public TextMeshProUGUI gauntletOfGreenBonus_text;
    public TextMeshProUGUI magicalElixir_text;
    public TextMeshProUGUI magicalElixir2_text;
    public TextMeshProUGUI magicalElixirInfo;
    public TextMeshProUGUI magicalElixirDropChance_text;
    public TextMeshProUGUI magicalElixirItemBonus_text;
    public TextMeshProUGUI ancientRelic_text;
    public TextMeshProUGUI ancientRelic2_text;
    public TextMeshProUGUI ancientRelicGivesBuff_text;
    public TextMeshProUGUI ancientRelicKeepBuff_text;
    public TextMeshProUGUI ancientRelicDropChance_text;
    public TextMeshProUGUI enchantedHammer_text;
    public TextMeshProUGUI enchantedHammer2_text;
    public TextMeshProUGUI enchantedHammerInfo_text;
    public TextMeshProUGUI enchantedHammerDropChance_text;
    public TextMeshProUGUI enchantedHammerItemBonus_text;
    public TextMeshProUGUI treasurePotion_text;
    public TextMeshProUGUI treasurePotion2_text;
    public TextMeshProUGUI treasurePotionInfo_text;
    public TextMeshProUGUI treasurePotionItemBonus_text;
    public TextMeshProUGUI treasurePotionDropChance_text;
    public TextMeshProUGUI barrelOfGold_text;
    public TextMeshProUGUI barrelOfGold2_text;
    public TextMeshProUGUI barrelOfGoldBonus_text;
    public TextMeshProUGUI barrelOfGoldInfo_text;
    public TextMeshProUGUI barrelSpawns_text;
    public TextMeshProUGUI barrelGoldCoinsInside_text;
    public TextMeshProUGUI barrelOfGoldTotalGold_text;
    public TextMeshProUGUI clickToCollect_text;
    public TextMeshProUGUI mimicChest_text;
    public TextMeshProUGUI mimicChest2_text;
    public TextMeshProUGUI mimicChestSpawns_text;
    public TextMeshProUGUI mimicChestChanceForBuff_text;
    public TextMeshProUGUI mimicChestItemBonus_text;
    public TextMeshProUGUI mimicChestMaxHover_text;
    public TextMeshProUGUI turnedOff_text;
    public TextMeshProUGUI purchaseAnItem_text;
    public TextMeshProUGUI useItems_text;
    public TextMeshProUGUI itemsGetExpensive_text;
    public TextMeshProUGUI levelUpItems_text;
    public TextMeshProUGUI stack_text1, stack_text2, stack_text3, stack_text4, stack_text5, stack_text6, stack_text7, stack_text8;
    public TextMeshProUGUI broke_text;

    public TextMeshProUGUI goldBuffText_text, lootPotionBuff_text, damagePotionBuff_text, damageBuff_text, treasureBuff_text, xpBuff_text, xpPotionBuff, elixirGoldBuff_text, elixirXPBuff_text, elixirDamageBuff_text, goldCoinsDropBuff_text, treasurePotionBuff_text, goldenTouchBuff, rareTreasureBuff_text;
    public TextMeshProUGUI negativeGold_text, negativeDamage_text, negativeTreasure_text, negativeXP_text, negativeGoldCoinsDrop_text;
    public TextMeshProUGUI goldBuffTimer_text, lootPotionBuffTimer_text, damageBuffTimer_text, damagePotionTimer_text, treasureBuffTimer_text, xpBuffTimer_text, XpPotionTimer_text, elixirTimer_text, goldCoinsDropsTimer_text, treasurePotionTimer_Text, goldenTouchTimer_text, rareTreasuresTimer_text, negativeGoldtimer_Text, negativeDamageTimer_text, negativeTreasureTimer_text, negativeXPTimer_text, negativeGoldCoinsDropTimer_text;
    #endregion

    [Header("Treasures")]
    #region Treasures Variables

    public TextMeshProUGUI treasureBar_text;

    public TextMeshProUGUI[] commonText_text = new TextMeshProUGUI[5];
    public TextMeshProUGUI[] unCommonText_text = new TextMeshProUGUI[4];
    public TextMeshProUGUI[] rareText_text = new TextMeshProUGUI[5];
    public TextMeshProUGUI[] veryRare_text = new TextMeshProUGUI[5];
    public TextMeshProUGUI[] extremelyRare_text = new TextMeshProUGUI[3];
    public TextMeshProUGUI[] legendary_text = new TextMeshProUGUI[3];
    public TextMeshProUGUI[] ultra_text = new TextMeshProUGUI[3];
    public TextMeshProUGUI[] mythic_text = new TextMeshProUGUI[3];
    public TextMeshProUGUI[] eternal_text = new TextMeshProUGUI[3];

    public TextMeshProUGUI[] treasureDropChanceText_text = new TextMeshProUGUI[34];
    public TextMeshProUGUI[] treasreDoubleText_text = new TextMeshProUGUI[34];

    public TextMeshProUGUI quartz_text;
    public TextMeshProUGUI amethyst_text;
    public TextMeshProUGUI yellowTopaz_text;
    public TextMeshProUGUI albite_text;
    public TextMeshProUGUI redGarnet_text;
    public TextMeshProUGUI aquamarine_text;
    public TextMeshProUGUI yellowSapphire_text;
    public TextMeshProUGUI pinkTourmaline_text;
    public TextMeshProUGUI aventurine_text;
    public TextMeshProUGUI redRuby_text;
    public TextMeshProUGUI diamond_text;
    public TextMeshProUGUI grandidierite_text;
    public TextMeshProUGUI violetCrystal_text;
    public TextMeshProUGUI akoyaPearl_text;
    public TextMeshProUGUI purpleRupee_text;
    public TextMeshProUGUI emerald_text;
    public TextMeshProUGUI greenDiamond_text;
    public TextMeshProUGUI fireOpal_text;
    public TextMeshProUGUI gemSilica_text;
    public TextMeshProUGUI pinkPlort_text;
    public TextMeshProUGUI goldenSeaPearl_text;
    public TextMeshProUGUI kyanite_text;
    public TextMeshProUGUI blackOpal_text;
    public TextMeshProUGUI painite_text;
    public TextMeshProUGUI tanzanite_text;
    public TextMeshProUGUI astralium_text;
    public TextMeshProUGUI elysiumPrism_text;
    public TextMeshProUGUI aerthfireOpal_text;
    public TextMeshProUGUI eldrichStarstone_text;
    public TextMeshProUGUI chronolithShard_text;
    public TextMeshProUGUI sideriumEssence_text;
    public TextMeshProUGUI quadarite_text;
    public TextMeshProUGUI radiantNovaStone_text;
    public TextMeshProUGUI soluniumShard_text;

    public TextMeshProUGUI sellTreasureFor_text;
    public TextMeshProUGUI sell_text;
    public TextMeshProUGUI sellAll_text;
    #endregion

    [Header("Treasures")]
    #region Rare Treasures Variables
    public TextMeshProUGUI coolStuff_text;
    public TextMeshProUGUI rareTreasuresTop_text;
    public TextMeshProUGUI rareTreasuresTop2_text;
    public TextMeshProUGUI page1_text;
    public TextMeshProUGUI page2_text;
    public TextMeshProUGUI pirateSkull_text;
    public TextMeshProUGUI pirateSkull2_text;
    public TextMeshProUGUI demonicSword_text;
    public TextMeshProUGUI demonicSword2_text;
    public TextMeshProUGUI mysticRing_text;
    public TextMeshProUGUI mysticRing2_text;
    public TextMeshProUGUI trophy_text;
    public TextMeshProUGUI trophy2_text;
    public TextMeshProUGUI fallenStar_text;
    public TextMeshProUGUI fallenStar2_text;
    public TextMeshProUGUI clover_text;
    public TextMeshProUGUI clover2_text;
    public TextMeshProUGUI kingsCrown_text;
    public TextMeshProUGUI kingsCrown2_text;
    public TextMeshProUGUI spellBook_text;
    public TextMeshProUGUI spellBook2_text;
    public TextMeshProUGUI guitar_text;
    public TextMeshProUGUI guitar2_text;
    public TextMeshProUGUI talarian_text;
    public TextMeshProUGUI talarian2_text;
    public TextMeshProUGUI mythrune_text;
    public TextMeshProUGUI mythrune2_text;
    public TextMeshProUGUI explorerBackpack_text;
    public TextMeshProUGUI explorerBackpack2_text;
    public TextMeshProUGUI vikingShield_text;
    public TextMeshProUGUI vikingShield2_text;
    public TextMeshProUGUI pillBottle_text;
    public TextMeshProUGUI pillBottle2_text;
    public TextMeshProUGUI victoryMedal_text;
    public TextMeshProUGUI victoryMedal2_text;
    public TextMeshProUGUI cookie_text;
    public TextMeshProUGUI cookie2_text;
    public TextMeshProUGUI christmasPresent_text;
    public TextMeshProUGUI christmasPresent2_text;
    public TextMeshProUGUI battleAxe_text;
    public TextMeshProUGUI battleAxe2_text;
    public TextMeshProUGUI goldCoin100X_text;
    public TextMeshProUGUI goldCoin100X2_text;
    public TextMeshProUGUI sealedEnvelope_text;
    public TextMeshProUGUI sealedEnvelope2_text;
    public TextMeshProUGUI strangePotion_text;
    public TextMeshProUGUI strangePotion2_text;
    public TextMeshProUGUI soulGem_text;
    public TextMeshProUGUI soulGem2_text;
    public TextMeshProUGUI ancientScroll_text;
    public TextMeshProUGUI ancientScroll2_text;
    public TextMeshProUGUI brick_text;
    public TextMeshProUGUI brick2_text;
    public TextMeshProUGUI rubberChicken_text;
    public TextMeshProUGUI rubberChicken2_text;
    public TextMeshProUGUI foundRareTreasurePopUp_text;

    public TextMeshProUGUI skullFoundReward_text;
    public TextMeshProUGUI swordFoundReward_text;
    public TextMeshProUGUI ringFoundReward_text;
    public TextMeshProUGUI trophyFoundReward_text;
    public TextMeshProUGUI fallenStarFoundReward_text;
    public TextMeshProUGUI cloverFoundReward_text;
    public TextMeshProUGUI kingsCrownFoundReward_text;
    public TextMeshProUGUI spellBookFoundReward_text;
    public TextMeshProUGUI guitarFoundReward_text;
    public TextMeshProUGUI talarianFoundReward_text;
    public TextMeshProUGUI mythruneFoundReward_text;
    public TextMeshProUGUI backPackFoundReward_text;
    public TextMeshProUGUI shieldFoundReward_text;
    public TextMeshProUGUI pillBottleFoundReward_text;
    public TextMeshProUGUI medalFoundReward_text;
    public TextMeshProUGUI cookieFoundReward_text;
    public TextMeshProUGUI presentFoundReward_text;
    public TextMeshProUGUI axeFoundReward_text;
    public TextMeshProUGUI coin100XFoundReward_text;
    public TextMeshProUGUI envelopeFoundReward_text;
    public TextMeshProUGUI potionFoundReward_text;
    public TextMeshProUGUI soulGemFoundReward_text;
    public TextMeshProUGUI sscrollFoundReward_text;
    public TextMeshProUGUI brickFoundReward_text;
    public TextMeshProUGUI chickenFoundReward_text;

    public TextMeshProUGUI allSkullRewards_text;
    public TextMeshProUGUI allDemonicSwordRewards_text;
    public TextMeshProUGUI allMysticRingRewards_text;
    public TextMeshProUGUI allTrophyRewards_text;
    public TextMeshProUGUI allFallenStarRewards_text;
    public TextMeshProUGUI allCloverRewards_text;
    public TextMeshProUGUI allKingsCrownRewards_text;
    public TextMeshProUGUI allSpellBookRewards_text;
    public TextMeshProUGUI allGuitarRewards_text;
    public TextMeshProUGUI allTalarianRewards_text;
    public TextMeshProUGUI allMythruneRewards_text;
    public TextMeshProUGUI allExplorerBackpackRewards_text;
    public TextMeshProUGUI allVikingShieldRewards_text;
    public TextMeshProUGUI allPillBottleRewards_text;
    public TextMeshProUGUI allVictoryMedalRewards_text;
    public TextMeshProUGUI foundCookieRewards_text;
    public TextMeshProUGUI foundChristmasPresentRewards_text;
    public TextMeshProUGUI foundBattleAxeRewards_text;
    public TextMeshProUGUI foundEnvelopeRewards;
    public TextMeshProUGUI foundGoldCoin100XRewards_text;
    public TextMeshProUGUI foundPotionRewards_text;
    public TextMeshProUGUI foundSoulGemRewards_text;
    public TextMeshProUGUI foundAncientScrollRewards_text;
    public TextMeshProUGUI foundBrickRewards_text;
    public TextMeshProUGUI foundRubberChickenRewards_text;
    public TextMeshProUGUI foundRubberChickenRewards2_text;

    public TextMeshProUGUI pirateSkullDescription_text;
    public TextMeshProUGUI demonicSwordDescription_text;
    public TextMeshProUGUI mysticRingDescription_text;
    public TextMeshProUGUI trophyDescription_text;
    public TextMeshProUGUI fallenStarDescription_text;
    public TextMeshProUGUI cloverDescription_text;
    public TextMeshProUGUI kingsCrownDescription_text;
    public TextMeshProUGUI spellBookDescription_text;
    public TextMeshProUGUI guitarDescription_text;
    public TextMeshProUGUI talarianDescription_text;
    public TextMeshProUGUI strangeRuneDescription_text;
    public TextMeshProUGUI explorerBackpackDescription_text;
    public TextMeshProUGUI vikingShieldDescription_text;
    public TextMeshProUGUI pillBottleDescription_text;
    public TextMeshProUGUI victoryMedalDescription_text;
    public TextMeshProUGUI cookieDescription_text;
    public TextMeshProUGUI christmasPresentDescription_text;
    public TextMeshProUGUI battleAxeDescription_text;
    public TextMeshProUGUI goldCoin100XDescription_text;
    public TextMeshProUGUI sealedEnvelopeDescription_text;
    public TextMeshProUGUI strangePotionDescription_text;
    public TextMeshProUGUI soulGemDescription_text;
    public TextMeshProUGUI ancientScrollDescription_text;
    public TextMeshProUGUI brickDescription_text;
    public TextMeshProUGUI rubberChickenDescription_text;

    public TextMeshProUGUI congratsMessage_text;
    public TextMeshProUGUI purchaseRareTreasure_text;
    public TextMeshProUGUI price200SkillPoints_text;
    public TextMeshProUGUI purchase1MissingTreasure_text;
    public TextMeshProUGUI skullDropChance_text;
    public TextMeshProUGUI democSwordDropChance_text;
    public TextMeshProUGUI mysticRingDropChance_text;
    public TextMeshProUGUI trophyDropChance_text;
    public TextMeshProUGUI fallenStarDropChance_text;
    public TextMeshProUGUI cloverDropChance_text;
    public TextMeshProUGUI kingsCrownDropChance_text;
    public TextMeshProUGUI spellBookDropChance_text;
    public TextMeshProUGUI guitarDropChance_text;
    public TextMeshProUGUI talarianDropChance_text;
    public TextMeshProUGUI mythRuneDropChance_text;
    public TextMeshProUGUI backPackDropChance_text;
    public TextMeshProUGUI vikingShieldDropChance_text;
    public TextMeshProUGUI pillBottleDropChance_text;
    public TextMeshProUGUI victoryMedalDropChance_text;
    public TextMeshProUGUI cookieDropChance_text;
    public TextMeshProUGUI presentDropChance_text;
    public TextMeshProUGUI battleAxeDropChance_text;
    public TextMeshProUGUI coin100XDropChance_text;
    public TextMeshProUGUI envelopeDropChance_text;
    public TextMeshProUGUI strangePotionDropChance_text;
    public TextMeshProUGUI soulGemDropChance_text;
    public TextMeshProUGUI ancientScrollDropChance_text;
    public TextMeshProUGUI brickDropChance_text;
    public TextMeshProUGUI chickenDropChance_text;

    public TextMeshProUGUI chooseChickenBuff_text;
    public TextMeshProUGUI coose1_text;
    public TextMeshProUGUI coose2_text;
    public TextMeshProUGUI coose3_text;
    public TextMeshProUGUI coose4_text;
    public TextMeshProUGUI coose5_text;
    public TextMeshProUGUI coose6_text;
    public TextMeshProUGUI coose7_text;
    public TextMeshProUGUI chooseText1_text;
    public TextMeshProUGUI chooseText2_text;
    public TextMeshProUGUI chooseText3_text;
    public TextMeshProUGUI chooseText4_text;
    public TextMeshProUGUI chooseText5_text;
    public TextMeshProUGUI chooseText6_text;
    public TextMeshProUGUI chooseText7_text;

    #endregion

    [Header("Treasure Chests")]
    #region Treasure Chest Variables
    public TextMeshProUGUI chestPurchase_text;
    public TextMeshProUGUI chestPrice_text;
    public TextMeshProUGUI chestHP_text;
    public TextMeshProUGUI autoPurchase_text;
    public TextMeshProUGUI autoPurchaseONOFF_text;
    public TextMeshProUGUI chestHoverName_text;
    public TextMeshProUGUI chestNO_text;
    public TextMeshProUGUI chestXPAmount_text;
    public TextMeshProUGUI chestGoldCoins_text;
    public TextMeshProUGUI chestGoldAmount_text;
    public TextMeshProUGUI chestReinforcedChance;
    public TextMeshProUGUI chestTREASURESDROP_text;
    public TextMeshProUGUI chestPurchasedName_text;
    public TextMeshProUGUI reinforcedPopUp_text;
    public TextMeshProUGUI enchantedGoldenChestPopUp_text;
    public TextMeshProUGUI bossChest_text;
    public TextMeshProUGUI reinforcedHover_text;
    public TextMeshProUGUI reinforcedHoverHealth_text;
    public TextMeshProUGUI reinforcedHoverGold_text;
    public TextMeshProUGUI reinforcedHoverXP_text;
    public TextMeshProUGUI enchantedGoldenHover_text;
    public TextMeshProUGUI enchantedGoldenHoverHealth_text;
    public TextMeshProUGUI enchantedGoldenHoverTreasures_text;
    public TextMeshProUGUI enchantedGoldenHoverXP_text;
    public TextMeshProUGUI enchantedGoldenHoverLockPickKeys_text;
    public TextMeshProUGUI bossChestHover_text;
    public TextMeshProUGUI bossChestHoverHealth_text;
    public TextMeshProUGUI bossChestHoverGoldValue_text;
    public TextMeshProUGUI bossChestHoverGoldCoins_text;
    public TextMeshProUGUI bossChestHoverXP_text;
    public TextMeshProUGUI bossChestHoverLockPickKeys_text;

    #endregion

    [Header("Prestige")]
    #region Prestige Variables
    
    public TextMeshProUGUI[] lockedPrestige_text = new TextMeshProUGUI[89];
    public TextMeshProUGUI[] unlockedPrestige_text = new TextMeshProUGUI[89];

    public TextMeshProUGUI prestigeTop_text;
    public TextMeshProUGUI prestigeButton_text;
    public TextMeshProUGUI openPrestigeScreen_text;
    public TextMeshProUGUI skillPoints_text;
    public TextMeshProUGUI skillPointsAmount_text;
    public TextMeshProUGUI findThePrestigeKeyAncChest_text;
    public TextMeshProUGUI prestigeKeyDropChance_text;
    public TextMeshProUGUI prestigeChestDropChance_text;
    public TextMeshProUGUI wouldYouLikeToPrestige_text;
    public TextMeshProUGUI youWillKeep_text;
    public TextMeshProUGUI keepText_text;
    public TextMeshProUGUI youWillLose_text;
    public TextMeshProUGUI loseText_text;
    public TextMeshProUGUI prestigeWillTakeYou_text;
    public TextMeshProUGUI prestigeYES_text;
    public TextMeshProUGUI prestigeNO_text;
    public TextMeshProUGUI prestigeAndSkillPoints_text;
    public TextMeshProUGUI prestigeExplinations_text;
    public TextMeshProUGUI prestigeExplinations2_text;
    public TextMeshProUGUI nextLeveEqualSkillPoints_text;
    public TextMeshProUGUI currentlyViewingPrestige_text;
    public TextMeshProUGUI skillPointsAmountInside_text;
    public TextMeshProUGUI skillPointsTextInsode_text;

    public TextMeshProUGUI clickerUnder_text;
    public TextMeshProUGUI loungerUnder_text;
    public TextMeshProUGUI pirateUnder_text;
    public TextMeshProUGUI hoarderUnder_text;
    public TextMeshProUGUI adventurerUnder_text;

    public TextMeshProUGUI hardenedFist_text;
    public TextMeshProUGUI ruthlessStrikes_text;
    public TextMeshProUGUI lethalPrecision_text;
    public TextMeshProUGUI savageCrits_text;
    public TextMeshProUGUI cripplingStrikes_text;
    public TextMeshProUGUI tapMastery_text;
    public TextMeshProUGUI clickersFury_text;
    public TextMeshProUGUI tapPrecision_text;
    public TextMeshProUGUI clickstorm_text;
    public TextMeshProUGUI fury_text;
    public TextMeshProUGUI swiftblade_text;
    public TextMeshProUGUI crushingForce_text;
    public TextMeshProUGUI cursorEnhanced_text;
    public TextMeshProUGUI cursorEvolution_text;
    public TextMeshProUGUI advancedCursors_text;
    public TextMeshProUGUI cursorEnchantment_text;
    public TextMeshProUGUI autoClicker1_text;
    public TextMeshProUGUI autoClicker2_text;
    public TextMeshProUGUI autoClicker3_text;
    public TextMeshProUGUI autoClicker4_text;
    public TextMeshProUGUI idler_text;
    public TextMeshProUGUI idlersMastery_text;
    public TextMeshProUGUI lazyRewards_text;
    public TextMeshProUGUI restfulIdler_text;
    public TextMeshProUGUI loungingOgre_text;
    public TextMeshProUGUI loungingPirate_text;
    public TextMeshProUGUI loungingKing_text;
    public TextMeshProUGUI effortless_text;
    public TextMeshProUGUI sloppyFist_text;
    public TextMeshProUGUI reforgedCursors_text;
    public TextMeshProUGUI mightyCursors_text;
    public TextMeshProUGUI potentCursors_text;
    public TextMeshProUGUI cursorMastery_text;
    public TextMeshProUGUI wealth_text;
    public TextMeshProUGUI wealthy_text;
    public TextMeshProUGUI extremelyWealthy_text;
    public TextMeshProUGUI fortune_text;
    public TextMeshProUGUI luckyPenny_text;
    public TextMeshProUGUI wealthEmpire_text;
    public TextMeshProUGUI fortuneCoin_text;
    public TextMeshProUGUI ancientCoin_text;
    public TextMeshProUGUI unfathomableWealth_text;
    public TextMeshProUGUI treasureHunter_text;
    public TextMeshProUGUI collector_text;
    public TextMeshProUGUI treasureAmplifier_text;
    public TextMeshProUGUI lootEnhancer_text;
    public TextMeshProUGUI pirate_text;
    public TextMeshProUGUI fortuneSeeker_text;
    public TextMeshProUGUI masterPirate_text;
    public TextMeshProUGUI xpBoost_text;
    public TextMeshProUGUI advancement_text;
    public TextMeshProUGUI levelMastery_text;
    public TextMeshProUGUI proficiency_text;
    public TextMeshProUGUI xpAccelerator_text;
    public TextMeshProUGUI elevation_text;
    public TextMeshProUGUI rapidLeveling_text;
    public TextMeshProUGUI transcendence_text;
    public TextMeshProUGUI student_text;
    public TextMeshProUGUI wizard_text;
    public TextMeshProUGUI enchantmentQuill_text;
    public TextMeshProUGUI itemMastery_text;
    public TextMeshProUGUI enchantedItems_text;
    public TextMeshProUGUI enhancedItems_text;
    public TextMeshProUGUI fortifiedItems_text;
    public TextMeshProUGUI potionStacker_text;
    public TextMeshProUGUI reinforcedItems_text;
    public TextMeshProUGUI potionChug_text;
    public TextMeshProUGUI stackingSplendor_text;
    public TextMeshProUGUI buffsGalore_text;
    public TextMeshProUGUI goodieBag_text;
    public TextMeshProUGUI travelBag_text;
    public TextMeshProUGUI stashedItems_text;
    public TextMeshProUGUI wellPrepared_text;
    public TextMeshProUGUI reinforcedPlus_text;
    public TextMeshProUGUI gildedFortification_text;
    public TextMeshProUGUI fortified_text;
    public TextMeshProUGUI strongbox_text;
    public TextMeshProUGUI treasuryReinforcement_text;
    public TextMeshProUGUI greaterLoot_text;
    public TextMeshProUGUI chestEnrichment_text;
    public TextMeshProUGUI lootBonanza_text;
    public TextMeshProUGUI luxuriousLooting_text;
    public TextMeshProUGUI piratesParadise_text;
    public TextMeshProUGUI enchantedGoldenChest_text;
    public TextMeshProUGUI bossChestPresige_text;
    public TextMeshProUGUI fortifiedFortune_text;
    public TextMeshProUGUI chestSurge_text;
    public TextMeshProUGUI chestBlessing_text;
    public TextMeshProUGUI reinforcedRiches_text;
    public TextMeshProUGUI bossChestPresitgeName_text;

    public TextMeshProUGUI critDes1_text;
    public TextMeshProUGUI critDes1_2_text;
    public TextMeshProUGUI critDes2_text;
    public TextMeshProUGUI critDes2_2_text;
    public TextMeshProUGUI critDes3_text;
    public TextMeshProUGUI critDes3_2_text;
    public TextMeshProUGUI critDes4_text;
    public TextMeshProUGUI critDes4_2_text;
    public TextMeshProUGUI critDes5_text;
    public TextMeshProUGUI critDes5_2_text;

    public TextMeshProUGUI activeDes1_text;
    public TextMeshProUGUI activeDes2_text;
    public TextMeshProUGUI activeDes3_text;
    public TextMeshProUGUI activeDes4_text;
    public TextMeshProUGUI activeDes4_2_text;
    public TextMeshProUGUI activeDes5_text;
    public TextMeshProUGUI activeDes5_2_text;
    public TextMeshProUGUI activeDes6_text;
    public TextMeshProUGUI activeDes6_2_text;
    public TextMeshProUGUI activeDes7_text;
    public TextMeshProUGUI activeDes7_2_text;

    // Active Cursor Descriptions
    public TextMeshProUGUI activeCursorDes1_text;
    public TextMeshProUGUI activeCursorDes2_text;
    public TextMeshProUGUI activeCursorDes3_text;
    public TextMeshProUGUI activeCursorDes4_text;
    public TextMeshProUGUI activeCursorDes4_2_text;

    // Auto Clicker Descriptions
    public TextMeshProUGUI autoClickerDes1_text;
    public TextMeshProUGUI autoClickerDes1_2_text;
    public TextMeshProUGUI autoClickerDes2_text;
    public TextMeshProUGUI autoClickerDes3_text;
    public TextMeshProUGUI autoClickerDes4_text;

    // Passive Descriptions
    public TextMeshProUGUI passiveDes1_text;
    public TextMeshProUGUI passiveDes2_text;
    public TextMeshProUGUI passiveDes3_text;
    public TextMeshProUGUI passiveDes3_2_text;
    public TextMeshProUGUI passiveDes4_text;
    public TextMeshProUGUI passiveDes4_2_text;
    public TextMeshProUGUI passiveDes5_text;
    public TextMeshProUGUI passiveDes6_text;
    public TextMeshProUGUI passiveDes6_2_text;
    public TextMeshProUGUI passiveDes7_text;
    public TextMeshProUGUI passiveDes7_2_text;
    public TextMeshProUGUI passiveDes8_text;

    // Passive Cursor Descriptions
    public TextMeshProUGUI passiveCursorDes1_text;
    public TextMeshProUGUI passiveCursorDes2_text;
    public TextMeshProUGUI passiveCursorDes3_text;
    public TextMeshProUGUI passiveCursorDes4_text;
    public TextMeshProUGUI passiveCursorDes4_2_text;
    public TextMeshProUGUI passiveCursorDes5_text;
    public TextMeshProUGUI passiveCursorDes5_2_text;

    // Gold Descriptions
    public TextMeshProUGUI goldDes1_text;
    public TextMeshProUGUI goldDes2_text;
    public TextMeshProUGUI goldDes3_text;
    public TextMeshProUGUI goldDes4_text;
    public TextMeshProUGUI goldDes4_2_text;
    public TextMeshProUGUI goldDes5_text;
    public TextMeshProUGUI goldDes6_text;
    public TextMeshProUGUI goldDes7_text;
    public TextMeshProUGUI goldDes7_2_text;
    public TextMeshProUGUI goldDes8_text;
    public TextMeshProUGUI goldDes8_2_text;
    public TextMeshProUGUI goldDes9_text;
    public TextMeshProUGUI goldDes9_2_text;

    // Treasure Descriptions
    public TextMeshProUGUI treasureDes1_text;
    public TextMeshProUGUI treasureDes2_text;
    public TextMeshProUGUI treasureDes3_text;
    public TextMeshProUGUI treasureDes4_text;
    public TextMeshProUGUI treasureDes4_2_text;
    public TextMeshProUGUI treasureDes5_text;
    public TextMeshProUGUI treasureDes5_2_text;
    public TextMeshProUGUI treasureDes6_text;
    public TextMeshProUGUI treasureDes6_2_text;
    public TextMeshProUGUI treasureDes7_text;
    public TextMeshProUGUI treasureDes7_2_text;

    // XP Descriptions
    public TextMeshProUGUI xpDes1_text;
    public TextMeshProUGUI xpDes2_text;
    public TextMeshProUGUI xpDes3_text;
    public TextMeshProUGUI xpDes4_text;
    public TextMeshProUGUI xpDes5_text;
    public TextMeshProUGUI xpDes6_text;
    public TextMeshProUGUI xpDes6_2_text;
    public TextMeshProUGUI xpDes7_text;
    public TextMeshProUGUI xpDes7_2_text;
    public TextMeshProUGUI xpDes8_text;
    public TextMeshProUGUI xpDes8_2_text;

    // Level Special Descriptions
    public TextMeshProUGUI levelSpecialDes1_text;
    public TextMeshProUGUI levelSpecialDes2_text;
    public TextMeshProUGUI levelSpecialDes3_text;
    public TextMeshProUGUI levelSpecialDes4_text;
    public TextMeshProUGUI levelSpecialDes5_text;

    // Stronger Special Descriptions
    public TextMeshProUGUI strongerSpecialDes1_text;
    public TextMeshProUGUI strongerSpecialDes2_text;
    public TextMeshProUGUI strongerSpecialDes3_text;
    public TextMeshProUGUI strongerSpecialDes4_text;
    public TextMeshProUGUI strongerSpecialDes5_text;
    public TextMeshProUGUI strongerSpecialDes5_2_text;
    public TextMeshProUGUI strongerSpecialDes6_text;
    public TextMeshProUGUI strongerSpecialDes7_text;

    // Start With Descriptions
    public TextMeshProUGUI startWithDes1_text;
    public TextMeshProUGUI startWithDes2_text;
    public TextMeshProUGUI startWithDes3_text;
    public TextMeshProUGUI startWithDes4_text;

    // Reinforced Descriptions
    public TextMeshProUGUI reinforcedDes1_text;
    public TextMeshProUGUI reinforcedDes1_2_text;
    public TextMeshProUGUI reinforcedDes2_text;
    public TextMeshProUGUI reinforcedDes2_2_text;
    public TextMeshProUGUI reinforcedDes2_3_text;
    public TextMeshProUGUI reinforcedDes3_text;
    public TextMeshProUGUI reinforcedDes3_2_text;
    public TextMeshProUGUI reinforcedDes4_text;
    public TextMeshProUGUI reinforcedDes4_2_text;
    public TextMeshProUGUI reinforcedDes4_3_text;
    public TextMeshProUGUI reinforcedDes4_4_text;
    public TextMeshProUGUI reinforcedDes5_text;
    public TextMeshProUGUI reinforcedDes5_2_text;

    // More Loot Descriptions
    public TextMeshProUGUI moreLootDes1_text;
    public TextMeshProUGUI moreLootDes2_text;
    public TextMeshProUGUI moreLootDes3_text;
    public TextMeshProUGUI moreLootDes4_text;
    public TextMeshProUGUI moreLootDes5_text;

    // New Chests Descriptions
    public TextMeshProUGUI newChestsDes1_text;
    public TextMeshProUGUI newChestsDes1_2_text;
    public TextMeshProUGUI newChestsDes1_3_text;
    public TextMeshProUGUI newChestsDes2_text;
    public TextMeshProUGUI newChestsDes2_2_text;
    public TextMeshProUGUI newChestsDes2_3_text;
    public TextMeshProUGUI newChestsDes3_text;
    public TextMeshProUGUI newChestsDes3_2_text;
    public TextMeshProUGUI newChestsDes4_text;
    public TextMeshProUGUI newChestsDes4_2_text;
    public TextMeshProUGUI newChestsDes4_3_text;
    public TextMeshProUGUI newChestsDes5_text;
    public TextMeshProUGUI newChestsDes5_2_text;
    public TextMeshProUGUI newChestsDes5_3_text;
    public TextMeshProUGUI newChestsDes6_text;
    public TextMeshProUGUI newChestsDes6_2_text;
    public TextMeshProUGUI newChestsDes6_3_text;

    public TextMeshProUGUI wouldYouLiketoGoBack_text;
    public TextMeshProUGUI butFirst_text;
    public TextMeshProUGUI chooseItemToStartWith_text;
    public TextMeshProUGUI purchaseTheGoodieBag_text;
    public TextMeshProUGUI goBackYES_text;
    public TextMeshProUGUI goBackNO_text;
    public TextMeshProUGUI itesmChosen_text;
    public TextMeshProUGUI chooseSomethingElse_text;

    public TextMeshProUGUI prestigeExit_text;
    #endregion

    [Header("Other")]
    #region Other Missedn Variables
    public TextMeshProUGUI totalGold_text;
    public TextMeshProUGUI maxPurchaseText_text;
    public TextMeshProUGUI youCanAlsoHoldDown_text;
    public TextMeshProUGUI levelText_text;
    public TextMeshProUGUI xpNeededText_text;
    public TextMeshProUGUI X1_text1, X1_text2, X1_text3;
    public TextMeshProUGUI MAX_text1, MAX_text2, MAX_text3;
    public TextMeshProUGUI activeDamageBar_text;
    public TextMeshProUGUI activeDamageAmount_text;
    public TextMeshProUGUI acitveDamagePrice_text;
    public TextMeshProUGUI activeDamageUPGRADE_text;
    public TextMeshProUGUI activeDamageACTIVE_text;
    public TextMeshProUGUI activeDamageLEVEL_text;
    public TextMeshProUGUI activeDamageLEVELAmount_text;

    public TextMeshProUGUI damageUnderChest;

    public TextMeshProUGUI passiveDamageBar_text;
    public TextMeshProUGUI passiveDamageAmount_text;
    public TextMeshProUGUI passiveDamagePrice_text;
    public TextMeshProUGUI passiveDamageUPGRADE_text;
    public TextMeshProUGUI passivePASSIVE_Text;
    public TextMeshProUGUI passiveLEVEL_text;
    public TextMeshProUGUI passiveLEVELAmount_text;

    public TextMeshProUGUI welcome;
    public TextMeshProUGUI beforeWeCanStartPlaying;
    public TextMeshProUGUI changeAnyTime;
    public TextMeshProUGUI playGame;

    public TextMeshProUGUI welcomeBack;
    public TextMeshProUGUI thisHappendWhileGone;
    public TextMeshProUGUI youOpened;
    public TextMeshProUGUI cool;
    public TextMeshProUGUI timeGone;
    public TextMeshProUGUI timeGoneTotal;

    #endregion


    //Strings
    #region Enchanted, reinforced and Boss chest hover and info STRING
    public static string enchantedGoldenChestHealth;
    public static string enchantedGoldenChestTreasureDrops;
    public static string enchantedGoldenChestXPDrop;

    public static string bossChestHealth;
    public static string bossChestGoldValue;
    public static string bossChestGoldCoins, bossChestGoldCoins2;
    public static string bossChestXP;

    public static string reinforcedHealth;
    public static string reinforcedGold;
    public static string reinforcedXP;

    public static string reinforcedInfo;
    public static string enchantedChestInfo;
    public static string bossChestInfo1, bossChestInfo2;

    public static string purchaseTheEnchanted;
    public static string purchaseTheBossChest;
    #endregion

    #region Stats strings

    public static string goldCoinsDropped;
    public static string totalGoldReceived;
    public static string totalBarrelGold;
    public static string treasuresDropped;
    public static string commonTreasures;
    public static string uncommonTreasures;
    public static string rareTreasures;
    public static string veryRareTreasures;
    public static string extremelyRareTreasures;
    public static string legendaryTreasures;
    public static string ultraTreasures;
    public static string mythicTreasures;
    public static string eternalTreasures;
    public static string treasuresDoubled;
    public static string chestsOpened;
    public static string reinforcedChestsOpened;
    public static string enchantedGoldenChestsOpened;
    public static string bossChestsOpened;
    public static string chestClicks;
    public static string autoClicks;
    public static string criticalHits;
    public static string activeDamage;
    public static string passiveDamage;
    public static string critChance;
    public static string critDamage;
    public static string cursorsLeveledUp;
    public static string coinsSpawnedFromClicks;
    public static string treasuresSpawnedFromClicks;
    public static string itemsUsed;
    public static string itemsDropped;
    public static string itemsPurchased;
    public static string itemsLeveledUp;
    public static string prestigeCount;
    public static string prestigeUpgradesPurchased;
    public static string skillPointsReceived;
    public static string goldIncrease;
    public static string xpIncrease;
    public static string activeDamageIncrease;
    public static string passiveDamageIncrease;
    public static string critChanceIncrease;
    public static string critDamageIncrease;
    public static string treasureChanceIncrease;
    public static string goldCoins5xDropped;
    public static string goldCoins10xDropped;
    public static string goldCoins25xDropped;
    public static string goldCoins100xDropped;

    #endregion

    #region Cursors strings
    public static string passiveDamageString, activeDamageScring, critChanceString, critDamageString;
    public static string equipped, unequpped;
    public static string cursor1Equipped, cursor2Equipped, cursor3Equipped, cursor4Equipped, cursor5Equipped, cursor6Equipped, cursor7Equipped, cursor8Equipped, cursor9Equipped, cursor10Equipped, cursor11Equipped, cursor12Equipped, cursor13Equipped, cursor14Equipped, cursor15Equipped, cursor16Equipped, cursor17Equipped, cursor18Equipped, cursor19Equipped, cursor20Equipped, cursor21Equipped;
    public static string equippedNONE;
    public static string clickDamage, activeDamageTop, dps;
    public static string lvl;
    public static string price;
    public static string gold;
    public static string damage;
    public static string upgrade, upgradeMax;
    public static string NOdot;
    #endregion

    #region Total gold strings
    public static string Million;
    public static string Billion;
    public static string Trillion;
    public static string Quadrillion;
    public static string Quintillion;
    public static string Sextillion;
    public static string Septillion;
    public static string Octillion;
    public static string Nonillion;
    public static string Decillion ;
    public static string Undecillion;
    public static string Duodecillion;
    public static string Tredecillion;
    public static string Quattuordecillion;
    public static string Quindecillion;
    public static string Sexdecillion;
    public static string Septendecillion;
    public static string Octodecillion;
    public static string Novemdecillion;
    public static string Vigintillion;
    public static string Unvigintillion;
    public static string Duovigintillion;
    public static string Trevigintillion;

    public static string MillionShort;
    public static string BillionShort;
    public static string TrillionShort;
    public static string QuadrillionShort;
    public static string QuintillionShort;
    public static string SextillionShort;
    public static string SeptillionShort;
    public static string OctillionShort;
    public static string NonillionShort;
    public static string DecillionShort;
    public static string UndecillionShort;
    public static string DuodecillionShort;
    public static string TredecillionShort;
    public static string QuattuordecillionShort;
    public static string QuindecillionShort;
    public static string SexdecillionShort;
    public static string SeptendecillionShort;
    public static string OctodecillionShort;
    public static string NovemdecillionShort;
    public static string VigintillionShort;
    public static string UnvigintillionShort;
    public static string DuovigintillionShort;
    public static string TrevigintillionShort;
    #endregion

    #region Items String
    public static string MAX;
    public static string owned;
    public static string treasuresExplinationMark;
    public static string skillPointsExplinatinMark;

    public static string stack;

    public static string forTheNext;
    public static string seconds;

    public static string damagePercent;
    public static string xp, xpNoPercent;
    public static string treasureDropChance;
    public static string goldCoinsDrop;
    public static string goldPercentString;
    #endregion

    #region Treasures string
    public static string tDropChanceRussAndEng, tDropChanceJapChiKor;
    public static string doubleInValue;
    public static string quartsGained;
    public static string amethystGained;
    public static string yellowTopazGained;
    public static string albiteGained;
    public static string redGarnetGained;
    public static string aquamarineGained;
    public static string yellowShapphireGained;
    public static string pinkTourmalineGained;
    public static string adventurineGained;
    public static string redRubyGained;
    public static string diamondGained;
    public static string grandidieriteGained;
    public static string violetCrystalGained;
    public static string akoyaPearlGained;
    public static string purpleRupeeGained;
    public static string emeraldGained;
    public static string greenDiamondGained;
    public static string fireOpalGained;
    public static string gemSilicaGained;
    public static string pinkPlortGained;
    public static string goldenSeaPearlGained;
    public static string kyaniteGained;
    public static string blackOpalGained;
    public static string painiteGained;
    public static string tanzaniteGained;
    public static string astraliumGained;
    public static string elysiumPrismGained;
    public static string aerthfireOpalGained;
    public static string eldrichStarStoneGained;
    public static string chronolithChardGained;
    public static string sideriumEssenceGained;
    public static string quasariteGained;
    public static string radiantNovaGained;
    public static string soluniumShardGained;

    public static string sellTreasureFor, sellGold;


    #endregion

    #region Rare Treasures String
    public static string PIRATE_SKULL;
    public static string DEMONIC_SWORD;
    public static string MYSTIC_RING;
    public static string TROPHY;
    public static string FALLEN_STAR;
    public static string CLOVER;
    public static string KINGS_CROWN;
    public static string SPELL_BOOK;
    public static string GUITAR;
    public static string TALARIAN;
    public static string MYTHRUNE;
    public static string EXPLORER_BACKPACK;
    public static string VIKING_SHIELD;
    public static string PILL_BOTTLE;
    public static string VICTORY_MEDAL;
    public static string COOKIE;
    public static string CHRISTMAS_PRESENT;
    public static string BATTLE_AXE;
    public static string GOLD_COIN_100X;
    public static string SEALED_ENVELOPE;
    public static string STRANGE_POTION;
    public static string SOUL_GEM;
    public static string ANCIENT_SCROLL;
    public static string BRICK;
    public static string RUBBER_CHICKEN;

    public static string priceEqual;
    public static string skillPoints200;

    public static string chooseChickenBuff;

    public static float skullSize;
    public static float demonicSwordSize;
    public static float mysticRingSize;
    public static float trophySize;
    public static float fallenStarSize;
    public static float cloverSize;
    public static float kingsCrownSize;
    public static float spellBookSize;
    public static float guitarSize;
    public static float talarianSize;
    public static float mythruneSize;
    public static float explorerBackpackSize;
    public static float vikingShieldSize;
    public static float pillBottleSize;
    public static float victoryMedalSize;
    public static float cookieSize;
    public static float christmasPresentSize;
    public static float battleAxeSize;
    public static float goldCoin100XSize;
    public static float sealedEnvelopeSize;
    public static float strangePotionSize;
    public static float soulGemSize;
    public static float ancientScrollSize;
    public static float brickSize;
    public static float rubberChickenSize;


    public static string YOU_FOUND_A_SKULL;
    public static string YOU_FOUND_A_TROPHY;
    public static string YOU_FOUND_A_DEMONIC_SWORD;
    public static string YOU_FOUND_A_RING;
    public static string YOU_FOUND_A_STAR;
    public static string YOU_FOUND_A_CLOVER;
    public static string YOU_FOUND_A_KINGS_CROWN;
    public static string YOU_FOUND_A_BOOK;
    public static string YOU_FOUND_A_GUITAR;
    public static string YOU_FOUND_A_TALARIAN;
    public static string YOU_FOUND_A_STRANGE_RUNE;
    public static string YOU_FOUND_A_BACKPACK;
    public static string YOU_FOUND_A_SHIELD;
    public static string YOU_FOUND_A_PILL_BOTTLE;
    public static string YOU_FOUND_A_MEDAL;
    public static string YOU_FOUND_A_COOKIE;
    public static string YOU_FOUND_A_CHRISTMAS_PRESENT;
    public static string YOU_FOUND_A_BATTLE_AXE;
    public static string YOU_FOUND_A_100X_GOLD_COIN;
    public static string YOU_FOUND_A_SEALED_ENVELOPE;
    public static string YOU_FOUND_A_STRANGE_POTION;
    public static string YOU_FOUND_A_SOUL_GEM;
    public static string YOU_FOUND_AN_ANCIENT_SCROLL;
    public static string YOU_FOUND_A_BRICK;
    public static string YOU_FOUND_A_RUBBER_CHICKEN;
    #endregion

    #region Chests Strings
    public static string ON, OFF;
    public static string WoodenChest;
    public static string TimberwoodChest;
    public static string RockboundChest;
    public static string BronzeChest;
    public static string SequoiaChest;
    public static string IronboundChest;
    public static string StoneshieldChest;
    public static string OceanChest;
    public static string PoisonousChest;
    public static string GoldenChest;
    public static string DesertChest;
    public static string PirateChest;
    public static string CrystalChest;
    public static string CelestialChest;
    public static string PhantomChest;
    public static string PrismaticChest;
    public static string AquaticChest;
    public static string WindwalkersChest;
    public static string EnchantedChest;
    public static string RoyalChest;
    public static string ArcaneChest;
    public static string GrandioseChest;
    public static string LuxuriousGoldenChest;
    public static string SacredChest;
    public static string EternitysEmbraceChest;
    public static string ForgottenChest;
    public static string LivingLuminousChest;
    public static string FortressOfWealth;
    public static string FortifiedTimberChest;
    public static string RadiantFrostlock;
    public static string InfernoEmbracedChest;
    public static string DeathChest;
    public static string AlienChest;
    public static string CraftsmansReliquary;
    public static string HellfireGuardianChest;
    public static string GhastlySoulHoardChest;
    public static string HighTechCache;
    public static string EliteHackersStrongbox;
    public static string CollectorsVault;
    public static string ExquisiteAzureRadianceChest;

    public static string TimberwoodChestUnlocked;
    public static string RockboundChestUnlocked;
    public static string BronzeChestUnlocked;
    public static string SequoiaChestUnlocked;
    public static string IronboundChestUnlocked;
    public static string StoneshieldChestUnlocked;
    public static string OceanChestUnlocked;
    public static string PoisonousChestUnlocked;
    public static string GoldenChestUnlocked;
    public static string DesertChestUnlocked;
    public static string PirateChestUnlocked;
    public static string CrystalChestUnlocked;
    public static string CelestialChestUnlocked;
    public static string PhantomChestUnlocked;
    public static string PrismaticChestUnlocked;
    public static string AquaticChestUnlocked;
    public static string WindwalkersChestUnlocked;
    public static string EnchantedChestUnlocked;
    public static string RoyalChestUnlocked;
    public static string ArcaneChestUnlocked;
    public static string GrandioseChestUnlocked;
    public static string LuxuriousGoldenChestUnlocked;
    public static string SacredChestUnlocked;
    public static string EternitysEmbraceChestUnlocked;
    public static string ForgottenChestUnlocked;
    public static string LivingLuminousChestUnlocked;
    public static string FortressOfWealthUnlocked;
    public static string FortifiedTimberChestUnlocked;
    public static string RadiantFrostlockUnlocked;
    public static string InfernoEmbracedChestUnlocked;
    public static string DeathChestUnlocked;
    public static string AlienChestUnlocked;
    public static string CraftsmansReliquaryUnlocked;
    public static string HellfireGuardianChestUnlocked;
    public static string GhastlySoulHoardChestUnlocked;
    public static string HighTechCacheUnlocked;
    public static string EliteHackersStrongboxUnlocked;
    public static string CollectorsVaultUnlocked;
    public static string ExquisiteAzureRadianceChestUnlocked;


    public static string GoldCoinsDrop;
    public static string goldCoinValue;
    public static string XPDrop;

    public static string chestNumber, chestNO;

    public static string reinforcedChestChance1, reinforcedChestChance2;
    #endregion

    #region Prestige String
    public static string FindThePrestigeKeyandChest, youFoundThePrestigeKetAndChest;
    public static string prestigeKeyChance1, prestigeKeyChance2, prestieChestKey1, prestieChestKey2;
    public static string youFoundPrestigeKey, youFoundPrestigeChest;

    public static string nextLevelHover, skillPointsHover;
    public static string choseItemToStartWith, chooseItemsToStartWith2, chooseItemsToStartWith3, chooseItemsToStartWith5;

    #endregion

    #region Other Strings
    public static string level;
    public static string crit;
    public static string friendlyMimic, evilMimic, secondsMimic, rareTreasureDropChance;

    #endregion


    #region english  
    public void EnglishLanguage()
    {
        JapaneseLanguageChosen = 0;
        RussianLanguageChosen = 0;
        EnglishLanguageChosen = 1;
        ChineseLanguageChosen = 0;
        KoreanLanguageChosen = 0;

        if (PlaceMobileButtons.isMobile == true) { ChangeMobileText(); }

        PlayerPrefs.SetInt("SaveEnglish", EnglishLanguageChosen);
        PlayerPrefs.SetInt("SaveRussian", RussianLanguageChosen);
        PlayerPrefs.SetInt("SaveJapanese", JapaneseLanguageChosen);
        PlayerPrefs.SetInt("SaveChinese", ChineseLanguageChosen);
        PlayerPrefs.SetInt("SaveKorean", KoreanLanguageChosen);

        #region TotalGold Strings
        Million = " Million";
        Billion = " Billion";
        Trillion = " Trillion";
        Quadrillion = " Quadrillion";
        Quintillion = " Quintillion";
        Sextillion = " Sextillion";
        Septillion = " Septillion";
        Octillion = " Octillion";
        Nonillion = " Nonillion";
        Decillion = " Decillion";
        Undecillion = " Undecillion";
        Duodecillion = " Duodecillion";
        Tredecillion = " Tredecillion";
        Quattuordecillion = " Quattuordecillion";
        Quindecillion = " Quindecillion";
        Sexdecillion = " Sexdecillion";
        Septendecillion = " Septendecillion";
        Octodecillion = " Octodecillion";
        Novemdecillion = " Novemdecillion";
        Vigintillion = " Vigintillion";
        Unvigintillion = " Unvigintillion";
        Duovigintillion = " Duovigintillion";
        Trevigintillion = " Trevigintillion";

        MillionShort = "M";
        BillionShort = "B";
        TrillionShort = "T";
        QuadrillionShort = "QD";
        QuintillionShort = "QT";
        SextillionShort = "SXT";
        SeptillionShort = "SPT";
        OctillionShort = " OCT";
        NonillionShort = "N";
        DecillionShort = "D";
        UndecillionShort = "U";
        DuodecillionShort = "DUO";
        TredecillionShort = "TRE";
        QuattuordecillionShort = "QTD";
        QuindecillionShort = "QUD";
        SexdecillionShort = "SXD";
        SeptendecillionShort = "SPD";
        OctodecillionShort = " OCD";
        NovemdecillionShort = "NOV";
        VigintillionShort = "VIG";
        UnvigintillionShort = "UNV";
        DuovigintillionShort = "DVG";
        TrevigintillionShort = "TRE";
        #endregion

        #region Pluss Buffs Strings
        gold = " GOLD";
        goldPercentString = "% GOLD";

        clickDamage = " CLICK DAMAGE ";
        activeDamageTop = " Active damage";
        dps = "DPS";
        passiveDamageString = "% Passive damage ";
        activeDamageScring = "% Active damage ";
        critChanceString = "% Crit chance ";
        critDamageString = "% Crit damage ";

        damagePercent = "% DAMAGE";
        xp = "% XP";
        treasureDropChance = "% TREASURE DROP CHANCE";
        goldCoinsDrop = " Gold Coins Drop";

        friendlyMimic = "FRIENDLY MIMIC! ";
        evilMimic = "EVIL MIMIC! ";
        secondsMimic = " SECONDS";

        rareTreasureDropChance = "+RARE TREASURE DROP CHANCE ";
        #endregion



        #region Settings Text
        settings_text.text = "Settings"; settings_text.font = ChangaBoldSDF1; settings_text.fontSize = 36;

        general_text.text = "GENERAL"; general_text.font = ChangaBoldSDF1; general_text.fontSize = 19;

        info_text.text = "INFO"; info_text.font = ChangaBoldSDF1; info_text.fontSize = 20;

        music_text.text = "MUSIC"; music_text.font = AlataRegular; music_text.fontSize = 25;

        sound_text.text = "SOUND"; sound_text.font = AlataRegular; sound_text.fontSize = 24;

        miniChestAndMimicChestSpawnSound_text.text = "MINI CHEST AND MIMIC CHEST SPAWN SOUND"; miniChestAndMimicChestSpawnSound_text.font = AlataRegular; miniChestAndMimicChestSpawnSound_text.fontSize = 16;

        mimicChestSpawning_text.text = "MIMIC CHEST SPAWNING"; mimicChestSpawning_text.font = AlataRegular; mimicChestSpawning_text.fontSize = 20;

        fullscreen_text.text = "FULLSCREEN"; fullscreen_text.font = AlataRegular; fullscreen_text.fontSize = 15;

        onFullScreen_text.text = "ON"; onFullScreen_text.font = ChangaBoldSDF; onFullScreen_text.fontSize = 30;

        offFullScreen_text.text = "OFF"; offFullScreen_text.font = ChangaBoldSDF; offFullScreen_text.fontSize = 30;

        onMimicSpawn_text.text = "ON"; onMimicSpawn_text.font = ChangaBoldSDF; onMimicSpawn_text.fontSize = 30;

        offMimicSpawn_text.text = "OFF"; offMimicSpawn_text.font = ChangaBoldSDF; offMimicSpawn_text.fontSize = 30;

        onMiniAndMimicSound_text.text = "ON"; onMiniAndMimicSound_text.font = ChangaBoldSDF; onMiniAndMimicSound_text.fontSize = 30;

        offMiniAndMimicSound_text.text = "OFF"; offMiniAndMimicSound_text.font = ChangaBoldSDF; offMiniAndMimicSound_text.fontSize = 30;

        resolution_text.text = "RESOLUTION"; resolution_text.font = AlataRegular; resolution_text.fontSize = 19;

        exit_text.text = "EXIT"; exit_text.font = ChangaBoldSDF; exit_text.fontSize = 60;

        save_text.text = "SAVE"; save_text.font = ChangaBoldSDF; save_text.fontSize = 36;

        gameSavesEvery15Seconds_text.text = "Game saves every 5 seconds"; gameSavesEvery15Seconds_text.font = ChangaBoldSDF1; gameSavesEvery15Seconds_text.fontSize = 11;

        cantSaveDuringPrestige_text.text = "CAN'T SAVE DURING PRESTIGE"; cantSaveDuringPrestige_text.font = ChangaBoldSDF; cantSaveDuringPrestige_text.fontSize = 20;

        resetGame_text.text = "RESET GAME"; resetGame_text.font = ChangaBoldSDF; resetGame_text.fontSize = 25; resetGame_text.lineSpacing = -90;

        discord_text.text = "DISCORD"; discord_text.font = AlataRegular; discord_text.fontSize = 32;

        numberOfCoinsAndTreasuresOnScreen_text.text = "NUMBER OF COINS AND TREASURES ON SCREEN BEFORE THEY COLLECT AUTOMATICALLY"; numberOfCoinsAndTreasuresOnScreen_text.font = AlataRegular; numberOfCoinsAndTreasuresOnScreen_text.fontSize = 16;

        reinforcedChests_text.text = "REINFORCED CHESTS"; reinforcedChests_text.font = AlataRegular; reinforcedChests_text.fontSize = 17;

        reinforcedChestsDescription_text.text = "Each chest have a chance to be a reinforced version of the chest. The reinforced chance depends on which chest is purchased."; reinforcedChestsDescription_text.font = AlataRegular; reinforcedChestsDescription_text.fontSize = 10;


        enchantedGoldenChests_text.text = "ENCHANTED GOLDEN CHESTS"; enchantedGoldenChests_text.font = AlataRegular; enchantedGoldenChests_text.fontSize = 17;

        bossChests_text.text = "BOSS CHESTS"; bossChests_text.font = AlataRegular; bossChests_text.fontSize = 17;

        musicBy_text.text = "Music by: Kevin MacLeod - Arpent"; musicBy_text.font = AlataRegular; musicBy_text.fontSize = 15;

        developerInfo_text.text = "Treasure Chest Clicker is developed by: Simon Eftestøl"; developerInfo_text.font = AlataRegular; developerInfo_text.fontSize = 15;

        resetConfirmation_text.text = "Do you wish to reset everything? The game will start from the beginning."; resetConfirmation_text.font = ChangaBoldSDF1; resetConfirmation_text.fontSize = 20;

        yes_text.text = "YES"; yes_text.font = ChangaBoldSDF1; yes_text.fontSize = 55;

        no_text.text = "NO"; no_text.font = ChangaBoldSDF1; no_text.fontSize = 55;

        gameSaves_Text.text = "GAME SAVED!"; gameSaves_Text.font = ChangaBoldSDF1; gameSaves_Text.fontSize = 15;
        #endregion

        #region stats
        stats_text.text = "STATISTICS"; stats_text.font = ChangaBoldSDF1; stats_text.fontSize = 40;
        goldAndTreasures_text.text = "GOLD & TREASURES"; goldAndTreasures_text.font = changaMedium; goldAndTreasures_text.fontSize = 45;
        chests_text.text = "CHESTS"; chests_text.font = changaMedium; chests_text.fontSize = 55;
        damage_text.text = "DAMAGE"; damage_text.font = changaMedium; damage_text.fontSize = 55;
        items.text = "ITEMS"; items.font = changaMedium; items.fontSize = 55;
        buffsAndPrestige_text.text = "BUFFS & PRESTIGE"; buffsAndPrestige_text.font = changaMedium; buffsAndPrestige_text.fontSize = 45;
        #endregion

        #region Achievements
        achievements_text.text = "ACHIEVEMENTS"; achievements_text.font = ChangaBoldSDF1; achievements_text.fontSize = 40;
        drop25GoldCoins_text.text = "Drop 25 gold coins from chests"; drop25GoldCoins_text.font = MontserratMediumSDF1; drop25GoldCoins_text.fontSize = 24;
        drop1000GoldCoins_text.text = "Drop 1000 gold coins from chests"; drop1000GoldCoins_text.font = MontserratMediumSDF1; drop1000GoldCoins_text.fontSize = 24;
        drop100000GoldCoins_text.text = "Drop 100 000 gold coins from chests"; drop100000GoldCoins_text.font = MontserratMediumSDF1; drop100000GoldCoins_text.fontSize = 24;
        drop1MillionGoldCoins_text.text = "Drop 1 Million gold coins from chests"; drop1MillionGoldCoins_text.font = MontserratMediumSDF1; drop1MillionGoldCoins_text.fontSize = 24;
        total100Gold_text.text = "Have a total of 100 gold"; total100Gold_text.font = MontserratMediumSDF1; total100Gold_text.fontSize = 24;
        total100000Gold_text.text = "Have a total of 100 000 gold"; total100000Gold_text.font = MontserratMediumSDF1; total100000Gold_text.fontSize = 24;
        total1MillionGold_text.text = "Have a total of 1 Million Gold"; total1MillionGold_text.font = MontserratMediumSDF1; total1MillionGold_text.fontSize = 24;
        total1BillionGold_text.text = "Have a total of 1 Billion Gold"; total1BillionGold_text.font = MontserratMediumSDF1; total1BillionGold_text.fontSize = 24;
        total1TrillionGold_text.text = "Have a total of 1 Trillion Gold"; total1TrillionGold_text.font = MontserratMediumSDF1; total1TrillionGold_text.fontSize = 24;

        //10
        total1QuadrillionGold_text.text = "Have a total of 1 Quadrillion Gold"; total1QuadrillionGold_text.font = MontserratMediumSDF1; total1QuadrillionGold_text.fontSize = 24;
        total1QuintillionGold_text.text = "Have a total of 1 Quintillion Gold"; total1QuintillionGold_text.font = MontserratMediumSDF1; total1QuintillionGold_text.fontSize = 24;
        total1SextillionGold_text.text = "Have a total of 1 Sextillion Gold"; total1SextillionGold_text.font = MontserratMediumSDF1; total1SextillionGold_text.fontSize = 24;
        total1SeptillionGold_text.text = "Have a total of 1 Septillion Gold"; total1SeptillionGold_text.font = MontserratMediumSDF1; total1SeptillionGold_text.fontSize = 24;
        total1OctillionGold_text.text = "Have a total of 1 Octillion Gold"; total1OctillionGold_text.font = MontserratMediumSDF1; total1OctillionGold_text.fontSize = 24;
        total1NonillionGold_text.text = "Have a total of 1 Nonillion Gold"; total1NonillionGold_text.font = MontserratMediumSDF1; total1NonillionGold_text.fontSize = 24;
        total1DecillionGold_text.text = "Have a total of 1 Decillion Gold"; total1DecillionGold_text.font = MontserratMediumSDF1; total1DecillionGold_text.fontSize = 24;
        total1NovemdecillionGold_text.text = "Have a total of 1 Novemdecillion Gold"; total1NovemdecillionGold_text.font = MontserratMediumSDF1; total1NovemdecillionGold_text.fontSize = 24;
        drop5XGoldCoin_text.text = "Drop a 5X gold coin"; drop5XGoldCoin_text.font = MontserratMediumSDF1; drop5XGoldCoin_text.fontSize = 24;
        drop1000_5XGoldCoins_text.text = "Drop 1000, 5X gold coins"; drop1000_5XGoldCoins_text.font = MontserratMediumSDF1; drop1000_5XGoldCoins_text.fontSize = 24;

        //20
        drop50000_5XGoldCoins_text.text = "Drop 50000, 5X gold coins"; drop50000_5XGoldCoins_text.font = MontserratMediumSDF1; drop50000_5XGoldCoins_text.fontSize = 24;
        drop10XGoldCoin_text.text = "Drop a 10X gold coin"; drop10XGoldCoin_text.font = MontserratMediumSDF1; drop10XGoldCoin_text.fontSize = 24;
        drop1000_10XGoldCoins_text.text = "Drop 1000, 10X gold coins"; drop1000_10XGoldCoins_text.font = MontserratMediumSDF1; drop1000_10XGoldCoins_text.fontSize = 24;
        drop15000_10XGoldCoins_text.text = "Drop 15000, 10X gold coins"; drop15000_10XGoldCoins_text.font = MontserratMediumSDF1; drop15000_10XGoldCoins_text.fontSize = 24;
        spawn10GoldCoinsFromClicks_text.text = "Spawn 10 gold coins from clicks"; spawn10GoldCoinsFromClicks_text.font = MontserratMediumSDF1; spawn10GoldCoinsFromClicks_text.fontSize = 24;
        spawn100GoldCoinsFromClicks_text.text = "Spawn 100 gold coins from clicks"; spawn100GoldCoinsFromClicks_text.font = MontserratMediumSDF1; spawn100GoldCoinsFromClicks_text.fontSize = 24;
        spawn1000GoldCoinsFromClicks_text.text = "Spawn 1000 gold coins from clicks"; spawn1000GoldCoinsFromClicks_text.font = MontserratMediumSDF1; spawn1000GoldCoinsFromClicks_text.fontSize = 24;
        oneTreasureDropped_text.text = "1 Treasure dropped from chest"; oneTreasureDropped_text.font = MontserratMediumSDF1; oneTreasureDropped_text.fontSize = 24;
        hundredTreasuresDropped_text.text = "100 Treasures dropped from chests"; hundredTreasuresDropped_text.font = MontserratMediumSDF1; hundredTreasuresDropped_text.fontSize = 24;
        thousandTreasuresDropped_text.text = "1000 Treasures dropped from chests"; thousandTreasuresDropped_text.font = MontserratMediumSDF1; thousandTreasuresDropped_text.fontSize = 24;
        tenThousandTreasuresDropped_text.text = "10000 Treasures dropped from chests"; tenThousandTreasuresDropped_text.font = MontserratMediumSDF1; tenThousandTreasuresDropped_text.fontSize = 24;
        fiftyThousandTreasuresDropped_text.text = "50000 Treasures dropped from chests"; fiftyThousandTreasuresDropped_text.font = MontserratMediumSDF1; fiftyThousandTreasuresDropped_text.fontSize = 24;

        //30 (Continued from 20)
        hundredCommonTreasures_text.text = "100 Common treasures dropped from chests"; hundredCommonTreasures_text.font = MontserratMediumSDF1; hundredCommonTreasures_text.fontSize = 22;
        hundredUncommonTreasures_text.text = "100 Uncommon treasures dropped from chests"; hundredUncommonTreasures_text.font = MontserratMediumSDF1; hundredUncommonTreasures_text.fontSize = 22;
        hundredRareTreasures_text.text = "100 Rare treasures dropped from chests"; hundredRareTreasures_text.font = MontserratMediumSDF1; hundredRareTreasures_text.fontSize = 22;
        hundredVeryRareTreasures_text.text = "100 Very Rare treasures dropped from chests"; hundredVeryRareTreasures_text.font = MontserratMediumSDF1; hundredVeryRareTreasures_text.fontSize = 22;
        hundredExtremelyRareTreasures_text.text = "100 Extremely Rare treasures dropped from chests"; hundredExtremelyRareTreasures_text.font = MontserratMediumSDF1; hundredExtremelyRareTreasures_text.fontSize = 24;
        hundredLegendaryTreasures_text.text = "100 Legendary treasures dropped from chests"; hundredLegendaryTreasures_text.font = MontserratMediumSDF1; hundredLegendaryTreasures_text.fontSize = 24;
        spawn10TreasuresFromClicks_text.text = "Spawn 10 treasures from clicks"; spawn10TreasuresFromClicks_text.font = MontserratMediumSDF1; spawn10TreasuresFromClicks_text.fontSize = 24;
        spawn100TreasuresFromClicks_text.text = "Spawn 100 treasures from clicks"; spawn100TreasuresFromClicks_text.font = MontserratMediumSDF1; spawn100TreasuresFromClicks_text.fontSize = 24;
        spawn1000TreasuresFromClicks_text.text = "Spawn 1000 treasures from clicks"; spawn1000TreasuresFromClicks_text.font = MontserratMediumSDF1; spawn1000TreasuresFromClicks_text.fontSize = 24;
        hundredTreasuresDoubled_text.text = "100 Treasures doubled in value"; hundredTreasuresDoubled_text.font = MontserratMediumSDF1; hundredTreasuresDoubled_text.fontSize = 24;

        //40 (Continued from 30)
        find1RareTreasure_text.text = "Find 1 rare treasure"; find1RareTreasure_text.font = MontserratMediumSDF1; find1RareTreasure_text.fontSize = 24;
        find3RareTreasures_text.text = "Find 3 rare treasures"; find3RareTreasures_text.font = MontserratMediumSDF1; find3RareTreasures_text.fontSize = 24;
        find5RareTreasures_text.text = "Find 5 rare treasures"; find5RareTreasures_text.font = MontserratMediumSDF1; find5RareTreasures_text.fontSize = 24;
        find13RareTreasures_text.text = "Find 13 rare treasures"; find13RareTreasures_text.font = MontserratMediumSDF1; find13RareTreasures_text.fontSize = 24;
        findAll25RareTreasures_text.text = "Find all 25 rare treasures"; findAll25RareTreasures_text.font = MontserratMediumSDF1; findAll25RareTreasures_text.fontSize = 24;
        findTheCookie_text.text = "Find the cookie!"; findTheCookie_text.font = MontserratMediumSDF1; findTheCookie_text.fontSize = 24;
        cookieClicker_text.text = "Cookie Clicker!"; cookieClicker_text.font = MontserratMediumSDF1; cookieClicker_text.fontSize = 24;
        prestige_text.text = "Prestige"; prestige_text.font = MontserratMediumSDF1; prestige_text.fontSize = 24;
        prestige5Times_text.text = "Prestige 5 times"; prestige5Times_text.font = MontserratMediumSDF1; prestige5Times_text.fontSize = 24;
        prestige15Times_text.text = "Prestige 15 times"; prestige15Times_text.font = MontserratMediumSDF1; prestige15Times_text.fontSize = 24;

        //50 (Continued from 40)
        purchase5PrestigeUpgrades_text.text = "Purchase 5 prestige upgrades"; purchase5PrestigeUpgrades_text.font = MontserratMediumSDF1; purchase5PrestigeUpgrades_text.fontSize = 24;
        purchase15PrestigeUpgrades_text.text = "Purchase 15 prestige upgrades"; purchase15PrestigeUpgrades_text.font = MontserratMediumSDF1; purchase15PrestigeUpgrades_text.fontSize = 24;
        purchase35PrestigeUpgrades_text.text = "Purchase 35 prestige upgrades"; purchase35PrestigeUpgrades_text.font = MontserratMediumSDF1; purchase35PrestigeUpgrades_text.fontSize = 24;
        purchase60PrestigeUpgrades_text.text = "Purchase 60 prestige upgrades"; purchase60PrestigeUpgrades_text.font = MontserratMediumSDF1; purchase60PrestigeUpgrades_text.fontSize = 24;
        purchaseAllPrestigeUpgrades_text.text = "Purchase ALL prestige upgrades"; purchaseAllPrestigeUpgrades_text.font = MontserratMediumSDF1; purchaseAllPrestigeUpgrades_text.fontSize = 24;
        purchaseAllPrestigeClickerUpgrades_text.text = "Purchase ALL prestige CLICKER upgrades"; purchaseAllPrestigeClickerUpgrades_text.font = MontserratMediumSDF1; purchaseAllPrestigeClickerUpgrades_text.fontSize = 24;
        purchaseAllPrestigeLoungerUpgrades_text.text = "Purchase ALL prestige LOUNGER upgrades"; purchaseAllPrestigeLoungerUpgrades_text.font = MontserratMediumSDF1; purchaseAllPrestigeLoungerUpgrades_text.fontSize = 24;
        purchaseAllPrestigePirateUpgrades_text.text = "Purchase ALL prestige PIRATE upgrades"; purchaseAllPrestigePirateUpgrades_text.font = MontserratMediumSDF1; purchaseAllPrestigePirateUpgrades_text.fontSize = 24;
        purchaseAllPrestigeHoarderUpgrades_text.text = "Purchase ALL prestige HOARDER upgrades"; purchaseAllPrestigeHoarderUpgrades_text.font = MontserratMediumSDF1; purchaseAllPrestigeHoarderUpgrades_text.fontSize = 24;
        purchaseAllPrestigeAdventurerUpgrades_text.text = "Purchase ALL prestige ADVENTURER upgrades"; purchaseAllPrestigeAdventurerUpgrades_text.font = MontserratMediumSDF1; purchaseAllPrestigeAdventurerUpgrades_text.fontSize = 24;

        //60 (Continued from 50)
        purchaseLootPotion_text.text = "Purchase the loot potion"; purchaseLootPotion_text.font = MontserratMediumSDF1; purchaseLootPotion_text.fontSize = 24;
        purchaseGoldenTouch_text.text = "Purchase the golden touch"; purchaseGoldenTouch_text.font = MontserratMediumSDF1; purchaseGoldenTouch_text.fontSize = 24;
        purchaseSerendipityScroll_text.text = "Purchase the serendipity scroll"; purchaseSerendipityScroll_text.font = MontserratMediumSDF1; purchaseSerendipityScroll_text.fontSize = 24;
        purchaseKey_text.text = "Purchase the key"; purchaseKey_text.font = MontserratMediumSDF1; purchaseKey_text.fontSize = 24;
        purchaseMagicalElixir_text.text = "Purchase the magical elixir"; purchaseMagicalElixir_text.font = MontserratMediumSDF1; purchaseMagicalElixir_text.fontSize = 24;
        purchaseAncientRelic_text.text = "Purchase the ancient relic"; purchaseAncientRelic_text.font = MontserratMediumSDF1; purchaseAncientRelic_text.fontSize = 24;
        purchaseEnchantedHammer_text.text = "Purchase the Enchanted Hammer"; purchaseEnchantedHammer_text.font = MontserratMediumSDF1; purchaseEnchantedHammer_text.fontSize = 24;
        openChest_text.text = "Open a chest"; openChest_text.font = MontserratMediumSDF1; openChest_text.fontSize = 24;
        open100Chests_text.text = "Open 100 chests"; open100Chests_text.font = MontserratMediumSDF1; open100Chests_text.fontSize = 24;
        open1000Chests_text.text = "Open 1000 chests"; open1000Chests_text.font = MontserratMediumSDF1; open1000Chests_text.fontSize = 24;

        //70 (Continued from 60)
        open10000Chests_text.text = "Open 10000 chests"; open10000Chests_text.font = MontserratMediumSDF1; open10000Chests_text.fontSize = 24;
        open100000Chests_text.text = "Open 100 000 chests"; open100000Chests_text.font = MontserratMediumSDF1; open100000Chests_text.fontSize = 24;
        open200000Chests_text.text = "Open 200 000 chests"; open200000Chests_text.font = MontserratMediumSDF1; open200000Chests_text.fontSize = 24;
        purchaseChestNo2_text.text = "Purchase chest NO.2"; purchaseChestNo2_text.font = MontserratMediumSDF1; purchaseChestNo2_text.fontSize = 24;
        purchaseChestNo5_text.text = "Purchase chest NO.5"; purchaseChestNo5_text.font = MontserratMediumSDF1; purchaseChestNo5_text.fontSize = 24;
        purchaseChestNo8_text.text = "Purchase chest NO.8"; purchaseChestNo8_text.font = MontserratMediumSDF1; purchaseChestNo8_text.fontSize = 24;
        purchaseChestNo12_text.text = "Purchase chest NO.12"; purchaseChestNo12_text.font = MontserratMediumSDF1; purchaseChestNo12_text.fontSize = 24;
        purchaseChestNo15_text.text = "Purchase chest NO.15"; purchaseChestNo15_text.font = MontserratMediumSDF1; purchaseChestNo15_text.fontSize = 24;
        purchaseChestNo20_text.text = "Purchase chest NO.20"; purchaseChestNo20_text.font = MontserratMediumSDF1; purchaseChestNo20_text.fontSize = 24;
        purchaseChestNo24_text.text = "Purchase chest NO.24"; purchaseChestNo24_text.font = MontserratMediumSDF1; purchaseChestNo24_text.fontSize = 24;

        //80 (Continued from 70)
        purchaseChestNo32_text.text = "Purchase chest NO. 32"; purchaseChestNo32_text.font = MontserratMediumSDF1; purchaseChestNo32_text.fontSize = 24;
        purchaseTheFinalChest_text.text = "Purchase the final chest"; purchaseTheFinalChest_text.font = MontserratMediumSDF1; purchaseTheFinalChest_text.fontSize = 24;
        openTheFinalChest_text.text = "Open the final chest"; openTheFinalChest_text.font = MontserratMediumSDF1; openTheFinalChest_text.fontSize = 24;
        openAReinforcedChest_text.text = "Open a reinforced chest"; openAReinforcedChest_text.font = MontserratMediumSDF1; openAReinforcedChest_text.fontSize = 24;
        open100ReinforcedChests_text.text = "Open 100 reinforced chests"; open100ReinforcedChests_text.font = MontserratMediumSDF1; open100ReinforcedChests_text.fontSize = 24;
        open500ReinforcedChests_text.text = "Open 500 reinforced chests"; open500ReinforcedChests_text.font = MontserratMediumSDF1; open500ReinforcedChests_text.fontSize = 24;
        open1000ReinforcedChests_text.text = "Open 1000 reinforced chests"; open1000ReinforcedChests_text.font = MontserratMediumSDF1; open1000ReinforcedChests_text.fontSize = 24;
        open100EnchantedGoldenChests_text.text = "Open 100 Enchanted Golden Chests"; open100EnchantedGoldenChests_text.font = MontserratMediumSDF1; open100EnchantedGoldenChests_text.fontSize = 24;
        open100BossChests_text.text = "Open 100 Boss Chests"; open100BossChests_text.font = MontserratMediumSDF1; open100BossChests_text.fontSize = 24;
        receiveTotal50SkillPoints_text.text = "Receive a total of 50 skill points"; receiveTotal50SkillPoints_text.font = MontserratMediumSDF1; receiveTotal50SkillPoints_text.fontSize = 24;

        //90 (Continued from 80)
        receiveTotal500SkillPoints_text.text = "Receive a total of 500 skill points"; receiveTotal500SkillPoints_text.font = MontserratMediumSDF1; receiveTotal500SkillPoints_text.fontSize = 24;
        receiveTotal1000SkillPoints_text.text = "Receive a total of 1000 skill points"; receiveTotal1000SkillPoints_text.font = MontserratMediumSDF1; receiveTotal1000SkillPoints_text.fontSize = 24;
        receiveTotal10000SkillPoints_text.text = "Receive a total of 10000 skill points"; receiveTotal10000SkillPoints_text.font = MontserratMediumSDF1; receiveTotal10000SkillPoints_text.fontSize = 24;
        reachLevel10_text.text = "Reach level 10"; reachLevel10_text.font = MontserratMediumSDF1; reachLevel10_text.fontSize = 24;
        reachLevel25_text.text = "Reach level 25"; reachLevel25_text.font = MontserratMediumSDF1; reachLevel25_text.fontSize = 24;
        reachLevel50_text.text = "Reach level 50"; reachLevel50_text.font = MontserratMediumSDF1; reachLevel50_text.fontSize = 24;
        reachLevel100_text.text = "Reach level 100"; reachLevel100_text.font = MontserratMediumSDF1; reachLevel100_text.fontSize = 24;
        reachLevel200_text.text = "Reach level 200"; reachLevel200_text.font = MontserratMediumSDF1; reachLevel200_text.fontSize = 24;
        drop1000_25XGoldCoins_text.text = "Drop 1000, 25X gold coins"; drop1000_25XGoldCoins_text.font = MontserratMediumSDF1; drop1000_25XGoldCoins_text.fontSize = 24;
        drop2MillionGoldCoins_text.text = "Drop 2 Million gold coins"; drop2MillionGoldCoins_text.font = MontserratMediumSDF1; drop2MillionGoldCoins_text.fontSize = 24;

        //100 (Continued from 90)
        drop100XGoldCoin_text.text = "Drop a 100X gold coin"; drop100XGoldCoin_text.font = MontserratMediumSDF1; drop100XGoldCoin_text.fontSize = 24;
        haveTotal1UndecillionGold_text.text = "Have a total of 1 Undecillion Gold"; haveTotal1UndecillionGold_text.font = MontserratMediumSDF1; haveTotal1UndecillionGold_text.fontSize = 24;
        haveTotal1DuodecillionGold_text.text = "Have a total of 1 Duodecillion Gold"; haveTotal1DuodecillionGold_text.font = MontserratMediumSDF1; haveTotal1DuodecillionGold_text.fontSize = 24;
        haveTotal1TredecillionGold_text.text = "Have a total of 1 Tredecillion Gold"; haveTotal1TredecillionGold_text.font = MontserratMediumSDF1; haveTotal1TredecillionGold_text.fontSize = 24;
        haveTotal1QuattuordecillionGold_text.text = "Have a total of 1 Quattuordecillion Gold"; haveTotal1QuattuordecillionGold_text.font = MontserratMediumSDF1; haveTotal1QuattuordecillionGold_text.fontSize = 24;
        haveTotal1QuindecillionGold_text.text = "Have a total of 1 Quindecillion Gold"; haveTotal1QuindecillionGold_text.font = MontserratMediumSDF1; haveTotal1QuindecillionGold_text.fontSize = 24;
        haveTotal1SexdecillionGold_text.text = "Have a total of 1 Sexdecillion Gold"; haveTotal1SexdecillionGold_text.font = MontserratMediumSDF1; haveTotal1SexdecillionGold_text.fontSize = 24;
        haveTotal1SeptendecillionGold_text.text = "Have a total of 1 Septendecillion Gold"; haveTotal1SeptendecillionGold_text.font = MontserratMediumSDF1; haveTotal1SeptendecillionGold_text.fontSize = 24;
        haveTotal1OctodecillionGold_text.text = "Have a total of 1 Octodecillion Gold"; haveTotal1OctodecillionGold_text.font = MontserratMediumSDF1; haveTotal1OctodecillionGold_text.fontSize = 24;
        reachLevel150_text.text = "Reach level 150"; reachLevel150_text.font = MontserratMediumSDF1; reachLevel150_text.fontSize = 24;

        //110 (Continued from 100)
        receiveTotal20000SkillPoints_text.text = "Recieve a total of 20000 skill points"; receiveTotal20000SkillPoints_text.font = MontserratMediumSDF1; receiveTotal20000SkillPoints_text.fontSize = 24;
        chestsHaveDropped100KTreasures_text.text = "Chests have dropped 100K treasures"; chestsHaveDropped100KTreasures_text.font = MontserratMediumSDF1; chestsHaveDropped100KTreasures_text.fontSize = 24;
        hundredUltraTreasuresDropped_text.text = "100 Ultra treasures dropped from chests"; hundredUltraTreasuresDropped_text.font = MontserratMediumSDF1; hundredUltraTreasuresDropped_text.fontSize = 24;
        hundredMythicTreasuresDropped_text.text = "100 Mythic treasures dropped from chests"; hundredMythicTreasuresDropped_text.font = MontserratMediumSDF1; hundredMythicTreasuresDropped_text.fontSize = 24;
        hundredEternalTreasuresDropped_text.text = "100 Eternal treasures dropped from chests"; hundredEternalTreasuresDropped_text.font = MontserratMediumSDF1; hundredEternalTreasuresDropped_text.fontSize = 24;
        open2500ReinforcedChests_text.text = "Open 2500 reinforced chests"; open2500ReinforcedChests_text.font = MontserratMediumSDF1; open2500ReinforcedChests_text.fontSize = 24;
        purchaseChestNo37_text.text = "Purchase chest NO.37"; purchaseChestNo37_text.font = MontserratMediumSDF1; purchaseChestNo37_text.fontSize = 24;
        useTheChicken_text.text = "Use the chicken"; useTheChicken_text.font = MontserratMediumSDF1; useTheChicken_text.fontSize = 24;
        drop250000_5XGoldCoins_text.text = "Drop 250000, 5X gold coins"; drop250000_5XGoldCoins_text.font = MontserratMediumSDF1; drop250000_5XGoldCoins_text.fontSize = 24;
        #endregion

        #region Cursors
        // Cursors - Cursors Hover Text
       
        // Cursors - Cursors Hover Text
        for (int i = 0; i < 21; i++)
        {
            levelUp_text[i].text = "LEVEL UP"; levelUp_text[i].font = changaMedium; levelUp_text[i].fontSize = 22;
        }

        // Cursors - Others
        cursor1PassiveDamage_Text.text = "+0% Passive damage"; cursor1PassiveDamage_Text.font = robotoBold; cursor1PassiveDamage_Text.fontSize = 20;
        cursor1CritChance_Text.text = "+0% Crit chance"; cursor1CritChance_Text.font = robotoBold; cursor1CritChance_Text.fontSize = 20;
        cursor1CritDamage_Text.text = "+0% Crit damage"; cursor1CritDamage_Text.font = robotoBold; cursor1CritDamage_Text.fontSize = 20;

        // Cursors - Cursor 2
        cursor2ActiveDamage_Text.text = "+0% Active damage"; cursor2ActiveDamage_Text.font = robotoBold; cursor2ActiveDamage_Text.fontSize = 20;
        cursor2CritChance_Text.text = "+0% Crit chance"; cursor2CritChance_Text.font = robotoBold; cursor2CritChance_Text.fontSize = 20;
        cursor2CritDamage_Text.text = "+0% Crit damage"; cursor2CritDamage_Text.font = robotoBold; cursor2CritDamage_Text.fontSize = 20;

        // Cursors - Cursor 3
        cursor3ActiveDamage_Text.text = "+0% Active damage"; cursor3ActiveDamage_Text.font = robotoBold; cursor3ActiveDamage_Text.fontSize = 20;
        cursor3PassiveDamage_Text.text = "+0% Passive damage"; cursor3PassiveDamage_Text.font = robotoBold; cursor3PassiveDamage_Text.fontSize = 20;

        // Cursors - Cursor 4
        cursor4CritChance_Text.text = "+0% Crit chance"; cursor4CritChance_Text.font = robotoBold; cursor4CritChance_Text.fontSize = 20;
        cursor4CritDamage_Text.text = "+0% Crit damage"; cursor4CritDamage_Text.font = robotoBold; cursor4CritDamage_Text.fontSize = 20;

        // Cursors - Cursor 5
        cursor5PassiveDamage_Text.text = "+0% Passive damage"; cursor5PassiveDamage_Text.font = robotoBold; cursor5PassiveDamage_Text.fontSize = 20;

        // Cursors - Cursor 7
        cursor7PassiveDamage_Text.text = "+0% Passive damage"; cursor7PassiveDamage_Text.font = robotoBold; cursor7PassiveDamage_Text.fontSize = 20;

        // Cursors - Cursor 9
        cursor9CritChance_Text.text = "+0% Crit chance"; cursor9CritChance_Text.font = robotoBold; cursor9CritChance_Text.fontSize = 20;
        cursor9CritDamage_Text.text = "+0% Crit damage"; cursor9CritDamage_Text.font = robotoBold; cursor9CritDamage_Text.fontSize = 20;

        // Cursors - Cursor 10
        cursor10ActiveDamage_Text.text = "+0% Active damage"; cursor10ActiveDamage_Text.font = robotoBold; cursor10ActiveDamage_Text.fontSize = 20;
        cursor10CritChance_Text.text = "+0% Crit chance"; cursor10CritChance_Text.font = robotoBold; cursor10CritChance_Text.fontSize = 20;
        cursor10CritDamage_Text.text = "+0% Crit damage"; cursor10CritDamage_Text.font = robotoBold; cursor10CritDamage_Text.fontSize = 20;

        // Cursors - Cursor 11
        cursor11PassiveDamage_Text.text = "+0% Passive damage"; cursor11PassiveDamage_Text.font = robotoBold; cursor11PassiveDamage_Text.fontSize = 20;


        cursors_text.text = "CURSORS"; cursors_text.font = changaMedium; cursors_text.fontSize = 55;
        cursorsHover_text.text = "CURSORS"; cursorsHover_text.font = changaMedium; cursorsHover_text.fontSize = 40;
        onlyOneCursorEquipped_text.text = "-Only 1 cursor can be equipped."; onlyOneCursorEquipped_text.font = liberationSans; onlyOneCursorEquipped_text.fontSize = 21.5f;
        equipCursorFitsPlaystyle_text.text = "-Equipp the cursor that fits your playstyle."; equipCursorFitsPlaystyle_text.font = liberationSans; equipCursorFitsPlaystyle_text.fontSize = 21.5f;
        uniqueCursorBonus_text.text = "-Each cursor has a unique cursor bonus."; uniqueCursorBonus_text.font = liberationSans; uniqueCursorBonus_text.fontSize = 21.5f;
        levelUpCursors_text.text = "-Level up your cursors by spending your treasures."; levelUpCursors_text.font = liberationSans; levelUpCursors_text.fontSize = 21.5f;
        
        gentleTap_text.text = "GENTLE TAP"; gentleTap_text.font = changaMedium; gentleTap_text.fontSize = 35f;
        gentleTap2_text.text = "GENTLE TAP"; gentleTap2_text.font = changaMedium; gentleTap2_text.fontSize = 24f;
        gentleTapCursorBonus_text.text = "Cursor bonus:<color=yellow><color=white> Every click has a <color=green>1%<color=white> chance of spawning <color=yellow>1 gold coin<color=green>"; gentleTapCursorBonus_text.font = robotoBold; gentleTapCursorBonus_text.fontSize = 21f;
        relaxedPalm_text.text = "RELAXED PALM"; relaxedPalm_text.font = changaMedium; relaxedPalm_text.fontSize = 35f;
        relaxedPalm2_text.text = "RELAXED PALM"; relaxedPalm2_text.font = changaMedium; relaxedPalm2_text.fontSize = 24f;
        relaxedPalmCursorBonus_text.text = "Cursor bonus:<color=yellow><color=white> Every 10 chests opened has a <color=green>25%<color=white> chance to spawn <color=yellow>5 gold coins"; relaxedPalmCursorBonus_text.font = robotoBold; relaxedPalmCursorBonus_text.fontSize = 21f;
        galeForce_text.text = "GALE FORCE"; galeForce_text.font = changaMedium; galeForce_text.fontSize = 35f;
        galeForce2_text.text = "GALE FORCE"; galeForce2_text.font = changaMedium; galeForce2_text.fontSize = 24f;
        galeForceCursorBonus_text.text = "Cursor bonus:<color=yellow><color=white> Every time you deal a critical hit, there is a <color=green>25%<color=white> chance to spawn <color=yellow>1 gold coin<color=green>"; galeForceCursorBonus_text.font = robotoBold; galeForceCursorBonus_text.fontSize = 21f;
        radiantTouch_text.text = "RADIANT TOUCH"; radiantTouch_text.font = changaMedium; radiantTouch_text.fontSize = 35f;
        radiantTouch2_text.text = "RADIANT TOUCH"; radiantTouch2_text.font = changaMedium; radiantTouch2_text.fontSize = 24f;
        radiantTouchCursorBonus_text.text = "Cursor bonus:<color=yellow><color=white> Spawns <color=yellow>7 gold coins<color=white> for every 35 chests opened"; radiantTouchCursorBonus_text.font = robotoBold; radiantTouchCursorBonus_text.fontSize = 21f;
        energySurge_text.text = "ENERGY SURGE"; energySurge_text.font = changaMedium; energySurge_text.fontSize = 35f;
        energySurge2_text.text = "ENERGY SURGE"; energySurge2_text.font = changaMedium; energySurge2_text.fontSize = 24f;
        energySurgeCursorBonus_text.text = "Cursor bonus:<color=yellow><color=white> Every treasure gains a <color=green>+0.1%<color=white> drop chance"; energySurgeCursorBonus_text.font = robotoBold; energySurgeCursorBonus_text.fontSize = 21f;
        phantomPalm_text.text = "PHANTOM PALM"; phantomPalm_text.font = changaMedium; phantomPalm_text.fontSize = 35f;
        phantomPalm2_text.text = "PHANTOM PALM"; phantomPalm2_text.font = changaMedium; phantomPalm2_text.fontSize = 24f;
        phantomPalmCursorBonus_text.text = "Cursor bonus:<color=yellow><color=white> Every critical hit has a <color=green>7%<color=white> chance to spawn a treasure. Each treasure has a <color=green>3%<color=white> to double in value"; phantomPalmCursorBonus_text.font = robotoBold; phantomPalmCursorBonus_text.fontSize = 21f;
        steelStrike_text.text = "STEEL STRIKE"; steelStrike_text.font = changaMedium; steelStrike_text.fontSize = 35f;
        steelStrike2_text.text = "STEEL STRIKE"; steelStrike2_text.font = changaMedium; steelStrike2_text.fontSize = 24f;
        steelStrikeCursorBonus_text.text = "Cursor bonus:<color=yellow> <color=green>+5%<color=white> More gold<color=white>. <color=green>+5%<color=white> More <color=orange>XP"; steelStrikeCursorBonus_text.font = robotoBold; steelStrikeCursorBonus_text.fontSize = 21f;
        lethalTouch_text.text = "LETHAL TOUCH"; lethalTouch_text.font = changaMedium; lethalTouch_text.fontSize = 35f;
        lethalTouch2_text.text = "LETHAL TOUCH"; lethalTouch2_text.font = changaMedium; lethalTouch2_text.fontSize = 24f;
        lethalTouchCursorBonus_text.text = "Cursor bonus:<color=yellow><color=white> Everytime a chest is opened, it has a <color=green>6%<color=white> chance to give double<color=orange> XP"; lethalTouchCursorBonus_text.font = robotoBold; lethalTouchCursorBonus_text.fontSize = 21f;
        precisionPoint_text.text = "PRECISION POINT"; precisionPoint_text.font = changaMedium; precisionPoint_text.fontSize = 35f;
        precisionPoint2_text.text = "PRECISION POINT"; precisionPoint2_text.font = changaMedium; precisionPoint2_text.fontSize = 24f;
        precisionPointCursorBonus_text.text = "Cursor bonus:<color=yellow><color=white> Everytime treasure dropped has a <color=green>+7%<color=white> chance to double in value"; precisionPointCursorBonus_text.font = robotoBold; precisionPointCursorBonus_text.fontSize = 21f;
        vortexTap_text.text = "VORTEX TAP"; vortexTap_text.font = changaMedium; vortexTap_text.fontSize = 35f;
        vortexTap2_text.text = "VORTEX TAP"; vortexTap2_text.font = changaMedium; vortexTap2_text.fontSize = 24f;
        vortexTapCursorBonus_text.text = "Cursor bonus:<color=yellow><color=white> Every 25 chests opened will spawn 1 treasure and give triple <color=orange>XP"; vortexTapCursorBonus_text.font = robotoBold; vortexTapCursorBonus_text.fontSize = 21f;
        cursedClaw_text.text = "CURSED CLAW"; cursedClaw_text.font = changaMedium; cursedClaw_text.fontSize = 35f;
        cursedClaw2_text.text = "CURSED CLAW"; cursedClaw2_text.font = changaMedium; cursedClaw2_text.fontSize = 24f;
        cursedClawCursorBonus_text.text = "Cursor bonus:<color=yellow><color=white> Everytime a critical hit is dealt, you have <color=green>30%<color=white> chance to spawn a gold coin and <color=green>3%<color=white> chance to spawn a treasure"; cursedClawCursorBonus_text.font = robotoBold; cursedClawCursorBonus_text.fontSize = 21f;
        sniperClick_text.text = "SNIPER CLICK"; sniperClick_text.font = changaMedium; sniperClick_text.fontSize = 35f;
        sniperClick2_text.text = "SNIPER CLICK"; sniperClick2_text.font = changaMedium; sniperClick2_text.fontSize = 24f;
        sniperClickCursorBonus_text.text = "Cursor bonus:<color=yellow><color=white> <color=green>10%<color=white> More gold and <color=green>15%<color=white> more <color=orange>XP"; sniperClickCursorBonus_text.font = robotoBold; sniperClickCursorBonus_text.fontSize = 21f;
        shadowSurge_text.text = "SHADOW SURGE"; shadowSurge_text.font = changaMedium; shadowSurge_text.fontSize = 35f;
        shadowSurge2_text.text = "SHADOW SURGE"; shadowSurge2_text.font = changaMedium; shadowSurge2_text.fontSize = 24f;
        shadowSurgeCursorBonus_text.text = "Cursor bonus:<color=yellow><color=white> Every critical hit will spawn <color=yellow>1 gold coin<color=green>"; shadowSurgeCursorBonus_text.font = robotoBold; shadowSurgeCursorBonus_text.fontSize = 21f;
        cripplingCrush_text.text = "CRIPPLING CRUSH"; cripplingCrush_text.font = changaMedium; cripplingCrush_text.fontSize = 35f;
        cripplingCrush2_text.text = "CRIPPLING CRUSH"; cripplingCrush2_text.font = changaMedium; cripplingCrush2_text.fontSize = 24f;
        cripplingCrushCursorBonus_text.text = "Cursor bonus:<color=yellow><color=white> Every time you gain a treasure, it has a <color=green>25%<color=white> chance to double in value"; cripplingCrushCursorBonus_text.font = robotoBold; cripplingCrushCursorBonus_text.fontSize = 21f;
        rapidClick_text.text = "RAPID CLICK"; rapidClick_text.font = changaMedium; rapidClick_text.fontSize = 35f;
        rapidClick2_text.text = "RAPID CLICK"; rapidClick2_text.font = changaMedium; rapidClick2_text.fontSize = 24f;
        rapidClickCursorBonus_text.text = "Cursor bonus:<color=yellow><color=white> Every critical hit has a <color=green>13%<color=white> chance to spawn a treasure"; rapidClickCursorBonus_text.font = robotoBold; rapidClickCursorBonus_text.fontSize = 21f;
        celestialTouch_text.text = "CELESTIAL TOUCH"; celestialTouch_text.font = changaMedium; celestialTouch_text.fontSize = 35f;
        celestialTouch2_text.text = "CELESTIAL TOUCH"; celestialTouch2_text.font = changaMedium; celestialTouch2_text.fontSize = 24f;
        celestialTouchCursorBonus_text.text = "Cursor bonus:<color=yellow><color=white> <color=orange>XP<color=white> is doubled"; celestialTouchCursorBonus_text.font = robotoBold; celestialTouchCursorBonus_text.fontSize = 21f;
        arcaneClick_text.text = "ARCANE CLICK"; arcaneClick_text.font = changaMedium; arcaneClick_text.fontSize = 35f;
        arcaneClick2_text.text = "ARCANE CLICK"; arcaneClick2_text.font = changaMedium; arcaneClick2_text.fontSize = 24f;
        arcaneClickCursorBonus_text.text = "Cursor bonus:<color=yellow><color=white> Every treasure is doubled in value. "; arcaneClickCursorBonus_text.font = robotoBold; arcaneClickCursorBonus_text.fontSize = 21f;
        eternalTouch_text.text = "ETERNAL TOUCH"; eternalTouch_text.font = changaMedium; eternalTouch_text.fontSize = 35f;
        eternalTouch2_text.text = "ETERNAL TOUCH"; eternalTouch2_text.font = changaMedium; eternalTouch2_text.fontSize = 24f;
        eternalTouchCursorBonus_text.text = "Cursor bonus:<color=yellow><color=orange> XP<color=white> and treasures are doubled. <color=green>5%<color=white> chance to gain a <color=yellow>gold coin<color=white> on every click"; eternalTouchCursorBonus_text.font = robotoBold; eternalTouchCursorBonus_text.fontSize = 21f;
        doomTouch_text.text = "DOOM TOUCH"; doomTouch_text.font = changaMedium; doomTouch_text.fontSize = 35f;
        doomTouch2_text.text = "DOOM TOUCH"; doomTouch2_text.font = changaMedium; doomTouch2_text.fontSize = 24f;
        doomTouchCursorBonus_text.text = "Cursor bonus:<color=white> Slightly smaller chance for rare treasure drops. "; doomTouchCursorBonus_text.font = robotoBold; doomTouchCursorBonus_text.fontSize = 21f;
        solarSweep_text.text = "SOLAR SWEEP"; solarSweep_text.font = changaMedium; solarSweep_text.fontSize = 35f;
        solarSweep2_text.text = "SOLAR SWEEP"; solarSweep2_text.font = changaMedium; solarSweep2_text.fontSize = 24f;
        solarSweepCursorBonus_text.text = "Cursor bonus:<color=green> +2.5%<color=white> chance to double chest rewards"; solarSweepCursorBonus_text.font = robotoBold; solarSweepCursorBonus_text.fontSize = 21f;
        infernoFist_text.text = "INFERNO FIST"; infernoFist_text.font = changaMedium; infernoFist_text.fontSize = 35f;
        infernoFist2_text.text = "INFERNO FIST"; infernoFist2_text.font = changaMedium; infernoFist2_text.fontSize = 24f;
        infernoFistCursorBonus_text.text = "Cursor bonus:<color=orange> XP<color=white> is doubled. <color=white> Every treasure is doubled in value. <color=green>4%<color=white> Chance to double <color=yellow>gold."; infernoFistCursorBonus_text.font = robotoBold; infernoFistCursorBonus_text.fontSize = 21f;
        locked_text.text = "LOCKED"; locked_text.font = changaMedium; locked_text.fontSize = 45f;
        unlockedAfterChest_text.text = "UNLOCKED AFTER PURCHASING CHEST"; unlockedAfterChest_text.font = ChangaBoldSDF; unlockedAfterChest_text.fontSize = 37f;

        if (PlaceMobileButtons.isMobile == true)
        {
            relaxedPalm_text.fontSize = 30;
            radiantTouch_text.fontSize = 30; 
            energySurge_text.fontSize = 32; 
            phantomPalm_text.fontSize = 30;
            lethalTouch_text.fontSize = 33; 
            precisionPoint_text.fontSize = 29; 
            shadowSurge_text.fontSize = 31; 
            cripplingCrush_text.fontSize = 30;
            celestialTouch_text.fontSize = 29; 
            eternalTouch_text.fontSize = 30; 
        }

        #endregion

        #region Shop And Items
        for (int i = 0; i < 17; i++)
        {
            itemsLevelUp_text[i].text = "LEVEL UP"; itemsLevelUp_text[i].font = changaMedium; itemsLevelUp_text[i].fontSize = 22;
        }

        goldenTouchBuff.text = "<color=yellow>+6-10 Gold coin drop"; goldenTouchBuff.font = ChangaBoldSDF1; goldenTouchBuff.fontSize = 10;
        treasurePotionBuff_text.text = "+3% Treasure Drop Chance"; treasurePotionBuff_text.font = ChangaBoldSDF1; treasurePotionBuff_text.fontSize = 10;

        

            shop_text.text = "SHOP"; shop_text.font = changaMedium; shop_text.fontSize = 90;
        shop2_text.text = "SHOP"; shop2_text.font = changaMedium; shop2_text.fontSize = 40;
        items_text.text = "ITEMS"; items_text.font = changaMedium; items_text.fontSize = 50;
        lockpick_text.text = "Lockpick"; lockpick_text.font = changaMedium; lockpick_text.fontSize = 29;
        lockpick2_text.text = "LOCKPICK"; lockpick2_text.font = changaMedium; lockpick2_text.fontSize = 25;
        lockpickItemBonus_text.text = "Item bonus:<color=yellow><color=white> There is a slightly small chance for a treasure to drop when a chest is opened with a lockpick"; lockpickItemBonus_text.font = robotoBold; lockpickItemBonus_text.fontSize = 21;

        hammer_text.text = "Hammer"; hammer_text.font = changaMedium; hammer_text.fontSize = 26;
        hammer2_text.text = "HAMMER"; hammer2_text.font = changaMedium; hammer2_text.fontSize = 25;
        hammerItemBonus_text.text = "Item bonus:<color=yellow><color=white> If you get a critical hit while using the hammer, <color=yellow>1 gold coin<color=white> has a <color=green>35%<color=white> chance to spawn"; hammerItemBonus_text.font = robotoBold; hammerItemBonus_text.fontSize = 21;

        lootPotion_text.text = "Loot Potion"; lootPotion_text.font = changaMedium; lootPotion_text.fontSize = 25;
        lootPotion2_text.text = "LOOT POTION"; lootPotion2_text.font = changaMedium; lootPotion2_text.fontSize = 25;
        lootPotionItemBonus_text.text = "Item Bonus:<color=yellow><color=white> Treasures recieved while this potion is active have a <color=green>+5%<color=white> chance to double in value"; lootPotionItemBonus_text.font = robotoBold; lootPotionItemBonus_text.fontSize = 21;

        damagePotion_text.text = "Damage Potion"; damagePotion_text.font = changaMedium; damagePotion_text.fontSize = 25;
        damagePotion2_text.text = "DAMAGE POTION"; damagePotion2_text.font = changaMedium; damagePotion2_text.fontSize = 25;
        damagePotionItemBonus_text.text = "Item Bonus:<color=yellow><color=white> Also gives <color=green>+2%<color=white> crit chance and <color=green>+50%<color=white> crit damage while active"; damagePotionItemBonus_text.font = robotoBold; damagePotionItemBonus_text.fontSize = 21;

        xpPotion_text.text = "XP Potion"; xpPotion_text.font = changaMedium; xpPotion_text.fontSize = 25;
        xpPotion2_text.text = "XP POTION"; xpPotion2_text.font = changaMedium; xpPotion2_text.fontSize = 25;
        xpPotionItemBonus_text.text = "Item Bonus:<color=yellow><color=white> Everytime <color=orange>XP<color=white> is gained, you have a <color=green>0.1%<color=white> chance to get +1 skill point"; xpPotionItemBonus_text.font = robotoBold; xpPotionItemBonus_text.fontSize = 21;

        goldenTouch_text.text = "Golden Touch"; goldenTouch_text.font = changaMedium; goldenTouch_text.fontSize = 25;
        goldenTouch2_text.text = "GOLDEN TOUCH"; goldenTouch2_text.font = changaMedium; goldenTouch2_text.fontSize = 25;
        goldenTouchItemBonus_text.text = "Item bonus:<color=yellow><color=white> While Golden Touch is active, treasures have a  <color=green>+10%<color=white> chance to double in value"; goldenTouchItemBonus_text.font = robotoBold; goldenTouchItemBonus_text.fontSize = 21;

        miniChest_text.text = "Mini Chest"; miniChest_text.font = changaMedium; miniChest_text.fontSize = 25;
        miniChest2_text.text = "MINI CHEST"; miniChest2_text.font = changaMedium; miniChest2_text.fontSize = 29;
        miniChestUpgradeBonus_text.text = "Upgrade Bonus:<color=yellow><color=white> Mini chests will give one of three possible rewards"; miniChestUpgradeBonus_text.font = robotoBold; miniChestUpgradeBonus_text.fontSize = 21;
        miniChestMaxHover_text.text = "MAX LEVEL"; miniChestMaxHover_text.font = ChangaBoldSDF; miniChestMaxHover_text.fontSize = 10;

        key_text.text = "Key"; key_text.font = changaMedium; key_text.fontSize = 26;
        key2_text.text = "KEY"; key2_text.font = changaMedium; key2_text.fontSize = 25;
        keyInstantlOpens_text.text = "Instantly opens a chest."; keyInstantlOpens_text.font = robotoBold; keyInstantlOpens_text.fontSize = 23;
        keyItemBonus_text.text = "Item bonus:<color=yellow><color=white> Chests drops <color=yellow>2-4 extra gold coins<color=white> when a key is used"; keyItemBonus_text.font = robotoBold; keyItemBonus_text.fontSize = 21;

        treasureBag_text.text = "Treasure Bag"; treasureBag_text.font = changaMedium; treasureBag_text.fontSize = 25;
        treasureBag2_text.text = "TREASURE BAG"; treasureBag2_text.font = changaMedium; treasureBag2_text.fontSize = 25;
        treasureBagDrop_text.text = "Treasure bags will drop 2 treasures"; treasureBagDrop_text.font = robotoBold; treasureBagDrop_text.fontSize = 17;
        treasureBagItemBonus_text.text = "Item Bonus:<color=yellow><color=white> Treasures from any chest can drop. Treasure bags also give you <color=orange>5 XP <color=white>drops"; treasureBagItemBonus_text.font = robotoBold; treasureBagItemBonus_text.fontSize = 21;

        serendipityScroll_text.text = "Serendipity Scroll"; serendipityScroll_text.font = changaMedium; serendipityScroll_text.fontSize = 25;
        serendipityScroll2_text.text = "SERENDIPITY SCROLL"; serendipityScroll2_text.font = changaMedium; serendipityScroll2_text.fontSize = 20;
        serendipityScrollStatsReset_text.text = "Stats from serendipity scroll will be reset on prestige"; serendipityScrollStatsReset_text.font = robotoBold; serendipityScrollStatsReset_text.fontSize = 21;

        gauntletOfGreed_text.text = "Gauntlet of Greed"; gauntletOfGreed_text.font = changaMedium; gauntletOfGreed_text.fontSize = 25;
        gauntletOfGreed2_text.text = "GAUNTLET OF GREED"; gauntletOfGreed2_text.font = changaMedium; gauntletOfGreed2_text.fontSize = 20;
        gauntletOfGreenBonus_text.text = "Item Bonus:<color=yellow><color=white> <color=green>3%<color=white> Chance to spawn a treasure on every click"; gauntletOfGreenBonus_text.font = robotoBold; gauntletOfGreenBonus_text.fontSize = 21;

        magicalElixir_text.text = "Magical Elixir"; magicalElixir_text.font = changaMedium; magicalElixir_text.fontSize = 25;
        magicalElixir2_text.text = "MAGICAL ELIXIR"; magicalElixir2_text.font = changaMedium; magicalElixir2_text.fontSize = 24;
        magicalElixirItemBonus_text.text = "Item Bonus:<color=green> +0.3%<color=white> drop chance to every treasure while the Elixir is active"; magicalElixirItemBonus_text.font = robotoBold; magicalElixirItemBonus_text.fontSize = 21;

        ancientRelic_text.text = "Ancient Relic"; ancientRelic_text.font = changaMedium; ancientRelic_text.fontSize = 25;
        ancientRelic2_text.text = "ANCIENT RELIC"; ancientRelic2_text.font = changaMedium; ancientRelic2_text.fontSize = 22;
        ancientRelicGivesBuff_text.text = "Gives a permanet buff to a random stat"; ancientRelicGivesBuff_text.font = robotoBold; ancientRelicGivesBuff_text.fontSize = 22;
        ancientRelicKeepBuff_text.text = "<color=yellow><color=white> You will keep every buff gained by the acient relic after prestige"; ancientRelicKeepBuff_text.font = robotoBold; ancientRelicKeepBuff_text.fontSize = 21;

        enchantedHammer_text.text = "Enchanted Hammer"; enchantedHammer_text.font = changaMedium; enchantedHammer_text.fontSize = 23;
        enchantedHammer2_text.text = "ENCHANTED HAMMER"; enchantedHammer2_text.font = changaMedium; enchantedHammer2_text.fontSize = 20;
        enchantedHammerItemBonus_text.text = "<color=yellow>Item Bonus:<color=green> 2%<color=white> Chance to tripple the chest rewards"; enchantedHammerItemBonus_text.font = robotoBold; enchantedHammerItemBonus_text.fontSize = 21;

        treasurePotion_text.text = "Treasure Potion"; treasurePotion_text.font = changaMedium; treasurePotion_text.fontSize = 26;
        treasurePotion2_text.text = "TREASURE POTION"; treasurePotion2_text.font = changaMedium; treasurePotion2_text.fontSize = 20;
        treasurePotionItemBonus_text.text = "<color=yellow>Item Bonus:<color=white> Items dropped get a <color=green>+25%<color=white> chance to double in value"; treasurePotionItemBonus_text.font = robotoBold; treasurePotionItemBonus_text.fontSize = 21;

        barrelOfGold_text.text = "Barrel Of Gold"; barrelOfGold_text.font = changaMedium; barrelOfGold_text.fontSize = 26;
        barrelOfGold2_text.text = "BARREL OF GOLD"; barrelOfGold2_text.font = changaMedium; barrelOfGold2_text.fontSize = 20;
        barrelOfGoldBonus_text.text = "<color=yellow>Item Bonus:<color=white> Choose where to place the barrel by dragging it"; barrelOfGoldBonus_text.font = robotoBold; barrelOfGoldBonus_text.fontSize = 21;
        barrelSpawns_text.text = "Spawns a barrel."; barrelSpawns_text.font = robotoBold; barrelSpawns_text.fontSize = 24;
        barrelGoldCoinsInside_text.text = "The barrel has collected a total of:"; barrelGoldCoinsInside_text.font = ChangaBoldSDF1; barrelGoldCoinsInside_text.fontSize = 10;
        clickToCollect_text.text = "Click to collect!"; clickToCollect_text.font = ChangaBoldSDF1; clickToCollect_text.fontSize = 12;

        mimicChest_text.text = "Mimic Chest"; mimicChest_text.font = changaMedium; mimicChest_text.fontSize = 26;
        mimicChest2_text.text = "MIMIC CHEST"; mimicChest2_text.font = changaMedium; mimicChest2_text.fontSize = 20;
        mimicChestItemBonus_text.text = "<color=yellow>Item Bonus:<color=white> Positive buffs have a <color=green>15%<color=white> chance to last twice as long"; mimicChestItemBonus_text.font = robotoBold; mimicChestItemBonus_text.fontSize = 21;
        turnedOff_text.text = "TURNED OFF"; turnedOff_text.font = changaMedium; turnedOff_text.fontSize = 18;
        
        purchaseAnItem_text.text = "-Purchase an item by spending your gold."; purchaseAnItem_text.font = liberationSans; purchaseAnItem_text.fontSize = 21.5f;
        useItems_text.text = "-Use your items in the ITEMS tab to the left."; useItems_text.font = liberationSans; useItems_text.fontSize = 21.5f;
        itemsGetExpensive_text.text = "-Each item gets more expensive each time you buy one."; itemsGetExpensive_text.font = liberationSans; itemsGetExpensive_text.fontSize = 21.5f;
        levelUpItems_text.text = "-Level up your items by spending your treasurs."; levelUpItems_text.font = liberationSans; levelUpItems_text.fontSize = 21.5f;
        broke_text.text = "BROKE!"; broke_text.font = changaMedium; broke_text.fontSize = 36f;

        rareTreasureBuff_text.text = "<color=orange>+Really small RARE TREASURE drop chance"; rareTreasureBuff_text.font = ChangaBoldSDF1; rareTreasureBuff_text.fontSize = 9;

        if (PlaceMobileButtons.isMobile == true)
        {
            damagePotion_text.fontSize = 21.5f;
            barrelOfGold_text.fontSize = 24;
            serendipityScroll_text.text = "Serendipity\nScroll";
            serendipityScroll_text.lineSpacing = -101f;

            gauntletOfGreed_text.text = "Gauntlet of\nGreed";
            gauntletOfGreed_text.lineSpacing = -101f;

            treasurePotion_text.fontSize = 23;

            enchantedHammer_text.lineSpacing = -101f;
            enchantedHammer_text.text = "Enchanted\nHammer";

            treasurePotion_text.fontSize = 23.5f;
        }
        #endregion

        #region Treasures
        treasureBar_text.text = "TREASURES"; treasureBar_text.font = changaMedium; treasureBar_text.fontSize = 48;

        for (int i = 0; i < 5; i++)
        {
            commonText_text[i].text = "COMMON"; commonText_text[i].font = ChangaBoldSDF; commonText_text[i].fontSize = 14;
            rareText_text[i].text = "RARE"; rareText_text[i].font = ChangaBoldSDF; rareText_text[i].fontSize = 15;
            veryRare_text[i].text = "VERY RARE"; veryRare_text[i].font = ChangaBoldSDF; veryRare_text[i].fontSize = 14;
        }

        for (int i = 0; i < 4; i++)
        {
            unCommonText_text[i].text = "UNCOMMON"; unCommonText_text[i].font = ChangaBoldSDF; unCommonText_text[i].fontSize = 14;
        }

        for (int i = 0; i < 3; i++)
        {
            extremelyRare_text[i].text = "EXTREMELY RARE"; extremelyRare_text[i].font = ChangaBoldSDF; extremelyRare_text[i].fontSize = 10;
            legendary_text[i].text = "LEGENDARY"; legendary_text[i].font = ChangaBoldSDF; legendary_text[i].fontSize = 12;
            ultra_text[i].text = "ULTRA"; ultra_text[i].font = ChangaBoldSDF; ultra_text[i].fontSize = 14;
            mythic_text[i].text = "MYTHIC"; mythic_text[i].font = ChangaBoldSDF; mythic_text[i].fontSize = 13;
            eternal_text[i].text = "ETERNAL"; eternal_text[i].font = ChangaBoldSDF; eternal_text[i].fontSize = 13;
        }


        quartz_text.text = "QUARTZ"; quartz_text.font = changaMedium; quartz_text.fontSize = 28;
        amethyst_text.text = "AMETHYST"; amethyst_text.font = changaMedium; amethyst_text.fontSize = 28;
        yellowTopaz_text.text = "YELLOW TOPAZ"; yellowTopaz_text.font = changaMedium; yellowTopaz_text.fontSize = 26;
        albite_text.text = "ALBITE"; albite_text.font = changaMedium; albite_text.fontSize = 27;
        redGarnet_text.text = "RED GARNET"; redGarnet_text.font = changaMedium; redGarnet_text.fontSize = 27;
        aquamarine_text.text = "AQUAMARINE"; aquamarine_text.font = changaMedium; aquamarine_text.fontSize = 27;
        yellowSapphire_text.text = "YELLOW SAPPHIRE"; yellowSapphire_text.font = changaMedium; yellowSapphire_text.fontSize = 23;
        pinkTourmaline_text.text = "PINK TOURMALINE"; pinkTourmaline_text.font = changaMedium; pinkTourmaline_text.fontSize = 22;
        aventurine_text.text = "AVENTURINE"; aventurine_text.font = changaMedium; aventurine_text.fontSize = 22;
        redRuby_text.text = "RED RUBY"; redRuby_text.font = changaMedium; redRuby_text.fontSize = 26;
        diamond_text.text = "DIAMOND"; diamond_text.font = changaMedium; diamond_text.fontSize = 27;
        grandidierite_text.text = "GRANDIDIERITE"; grandidierite_text.font = changaMedium; grandidierite_text.fontSize = 25;
        violetCrystal_text.text = "VIOLET CRYSTAL"; violetCrystal_text.font = changaMedium; violetCrystal_text.fontSize = 25;
        akoyaPearl_text.text = "AKOYA PEARL"; akoyaPearl_text.font = changaMedium; akoyaPearl_text.fontSize = 25;
        purpleRupee_text.text = "PURPLE RUPEE"; purpleRupee_text.font = changaMedium; purpleRupee_text.fontSize = 26;
        emerald_text.text = "EMERALD"; emerald_text.font = changaMedium; emerald_text.fontSize = 28;
        greenDiamond_text.text = "GREEN DIAMOND"; greenDiamond_text.font = changaMedium; greenDiamond_text.fontSize = 24;
        fireOpal_text.text = "FIRE OPAL"; fireOpal_text.font = changaMedium; fireOpal_text.fontSize = 26;
        gemSilica_text.text = "GEM SILICA"; gemSilica_text.font = changaMedium; gemSilica_text.fontSize = 26;
        pinkPlort_text.text = "PINK PLORT"; pinkPlort_text.font = changaMedium; pinkPlort_text.fontSize = 26;
        goldenSeaPearl_text.text = "GOLDEN SEA PEARL"; goldenSeaPearl_text.font = changaMedium; goldenSeaPearl_text.fontSize = 21;
        kyanite_text.text = "KYANITE"; kyanite_text.font = changaMedium; kyanite_text.fontSize = 27;
        blackOpal_text.text = "BLACK OPAL"; blackOpal_text.font = changaMedium; blackOpal_text.fontSize = 27;
        painite_text.text = "PAINITE"; painite_text.font = changaMedium; painite_text.fontSize = 28;
        tanzanite_text.text = "TANZANITE"; tanzanite_text.font = changaMedium; tanzanite_text.fontSize = 27;
        astralium_text.text = "ASTRALIUM"; astralium_text.font = changaMedium; astralium_text.fontSize = 27;
        elysiumPrism_text.text = "ELYSIUM PRISM"; elysiumPrism_text.font = changaMedium; elysiumPrism_text.fontSize = 26;
        aerthfireOpal_text.text = "AETHERFIRE OPAL"; aerthfireOpal_text.font = changaMedium; aerthfireOpal_text.fontSize = 23;
        eldrichStarstone_text.text = "ELDRITCH STARSTONE"; eldrichStarstone_text.font = changaMedium; eldrichStarstone_text.fontSize = 19;
        chronolithShard_text.text = "CHRONOLITH SHARD"; chronolithShard_text.font = changaMedium; chronolithShard_text.fontSize = 20;
        sideriumEssence_text.text = "SIDERIUM ESSENCE"; sideriumEssence_text.font = changaMedium; sideriumEssence_text.fontSize = 20;
        quadarite_text.text = "QUASARITE"; quadarite_text.font = changaMedium; quadarite_text.fontSize = 22;
        radiantNovaStone_text.text = "RADIANT NOVA STONE"; radiantNovaStone_text.font = changaMedium; radiantNovaStone_text.fontSize = 19;
        soluniumShard_text.text = "SOLUNIUM SHARD"; soluniumShard_text.font = changaMedium; soluniumShard_text.fontSize = 21;

        sell_text.text = "SELL"; sell_text.font = ChangaBoldSDF1; sell_text.fontSize = 25;
        sellAll_text.text = "SELL ALL"; sellAll_text.font = ChangaBoldSDF1; sellAll_text.fontSize = 24;
        #endregion

        #region Rare Treasures

        coolStuff_text.text = "cool stuff"; coolStuff_text.font = ChangaBoldSDF; coolStuff_text.fontSize = 25;
        rareTreasuresTop2_text.text = "RARE TREASURES"; rareTreasuresTop2_text.font = ChangaBoldSDF; rareTreasuresTop2_text.fontSize = 23;
        page1_text.text = "PAGE 1"; page1_text.font = ChangaBoldSDF; page1_text.fontSize = 12;
        page2_text.text = "PAGE 2"; page2_text.font = ChangaBoldSDF; page2_text.fontSize = 12;
        pirateSkull2_text.text = "PIRATE SKULL"; pirateSkull2_text.font = ChangaBoldSDF; pirateSkull2_text.fontSize = 20;
        demonicSword2_text.text = "DEMONIC SWORD"; demonicSword2_text.font = ChangaBoldSDF; demonicSword2_text.fontSize = 17;
        mysticRing2_text.text = "MYSTIC RING"; mysticRing2_text.font = ChangaBoldSDF; mysticRing2_text.fontSize = 17;
        trophy2_text.text = "TROPHY"; trophy2_text.font = ChangaBoldSDF; trophy2_text.fontSize = 20;
        fallenStar2_text.text = "FALLEN STAR"; fallenStar2_text.font = ChangaBoldSDF; fallenStar2_text.fontSize = 20;
        clover2_text.text = "CLOVER"; clover2_text.font = ChangaBoldSDF; clover2_text.fontSize = 20;
        kingsCrown2_text.text = "KINGS CROWN"; kingsCrown2_text.font = ChangaBoldSDF; kingsCrown2_text.fontSize = 19;
        spellBook2_text.text = "SPELL BOOK"; spellBook2_text.font = ChangaBoldSDF; spellBook2_text.fontSize = 19;
        guitar2_text.text = "GUITAR"; guitar2_text.font = ChangaBoldSDF; guitar2_text.fontSize = 19;
        talarian2_text.text = "TALARIAN"; talarian2_text.font = ChangaBoldSDF; talarian2_text.fontSize = 19;
        mythrune2_text.text = "MYTHRUNE"; mythrune2_text.font = ChangaBoldSDF; mythrune2_text.fontSize = 19;
        explorerBackpack2_text.text = "EXPLORER BACKPACK"; explorerBackpack2_text.font = ChangaBoldSDF; explorerBackpack2_text.fontSize = 14;
        vikingShield2_text.text = "VIKING SHIELD"; vikingShield2_text.font = ChangaBoldSDF; vikingShield2_text.fontSize = 17;
        pillBottle2_text.text = "PILL BOTTLE"; pillBottle2_text.font = ChangaBoldSDF; pillBottle2_text.fontSize = 17;
        victoryMedal2_text.text = "VICTORY MEDAL"; victoryMedal2_text.font = ChangaBoldSDF; victoryMedal2_text.fontSize = 17;
        cookie2_text.text = "COOKIE"; cookie2_text.font = ChangaBoldSDF; cookie2_text.fontSize = 17;
        christmasPresent2_text.text = "CHRISTMAS PRESENT"; christmasPresent2_text.font = ChangaBoldSDF; christmasPresent2_text.fontSize = 15;
        battleAxe2_text.text = "BATTLE AXE"; battleAxe2_text.font = ChangaBoldSDF; battleAxe2_text.fontSize = 19;
        goldCoin100X2_text.text = "100X GOLD COIN"; goldCoin100X2_text.font = ChangaBoldSDF; goldCoin100X2_text.fontSize = 16;
        sealedEnvelope2_text.text = "SEALED ENVELOPE"; sealedEnvelope2_text.font = ChangaBoldSDF; sealedEnvelope2_text.fontSize = 16;
        strangePotion2_text.text = "STRANGE POTION"; strangePotion2_text.font = ChangaBoldSDF; strangePotion2_text.fontSize = 15;
        soulGem2_text.text = "SOUL GEM"; soulGem2_text.font = ChangaBoldSDF; soulGem2_text.fontSize = 17;
        ancientScroll2_text.text = "ANCIENT SCROLL"; ancientScroll2_text.font = ChangaBoldSDF; ancientScroll2_text.fontSize = 17;
        brick2_text.text = "brick"; brick2_text.font = ChangaBoldSDF; brick2_text.fontSize = 17;
        rubberChicken2_text.text = "RUBBER CHICKEN"; rubberChicken2_text.font = ChangaBoldSDF; rubberChicken2_text.fontSize = 17;

        skullFoundReward_text.text = "Reward for finding the pirate skull:"; skullFoundReward_text.font = MontserratExtraLight; skullFoundReward_text.fontSize = 6.8f;
        swordFoundReward_text.text = "Reward for finding the demonic sword:"; swordFoundReward_text.font = MontserratExtraLight; swordFoundReward_text.fontSize = 6.8f;
        ringFoundReward_text.text = "Reward for finding the mystic ring:"; ringFoundReward_text.font = MontserratExtraLight; ringFoundReward_text.fontSize = 6.8f;
        trophyFoundReward_text.text = "Reward for finding the trophy:"; trophyFoundReward_text.font = MontserratExtraLight; trophyFoundReward_text.fontSize = 6.8f;
        fallenStarFoundReward_text.text = "Reward for finding the fallen star:"; fallenStarFoundReward_text.font = MontserratExtraLight; fallenStarFoundReward_text.fontSize = 6.8f;
        cloverFoundReward_text.text = "Reward for finding the clover:"; cloverFoundReward_text.font = MontserratExtraLight; cloverFoundReward_text.fontSize = 6.7f;
        kingsCrownFoundReward_text.text = "Reward for finding the kings crown:"; kingsCrownFoundReward_text.font = MontserratExtraLight; kingsCrownFoundReward_text.fontSize = 6.7f;
        spellBookFoundReward_text.text = "Reward for finding the spell book:"; spellBookFoundReward_text.font = MontserratExtraLight; spellBookFoundReward_text.fontSize = 6.7f;
        guitarFoundReward_text.text = "Reward for finding the guitar:"; guitarFoundReward_text.font = MontserratExtraLight; guitarFoundReward_text.fontSize = 6.7f;
        talarianFoundReward_text.text = "Reward for finding the talaria:"; talarianFoundReward_text.font = MontserratExtraLight; talarianFoundReward_text.fontSize = 6.7f;
        mythruneFoundReward_text.text = "Reward for finding the mythrune:"; mythruneFoundReward_text.font = MontserratExtraLight; mythruneFoundReward_text.fontSize = 6.7f;
        backPackFoundReward_text.text = "Reward for finding the explorer backpack:"; backPackFoundReward_text.font = MontserratExtraLight; backPackFoundReward_text.fontSize = 6.5f;
        shieldFoundReward_text.text = "Reward for finding the viking shield:"; shieldFoundReward_text.font = MontserratExtraLight; shieldFoundReward_text.fontSize = 6.5f;
        pillBottleFoundReward_text.text = "Reward for finding the pill bottle:"; pillBottleFoundReward_text.font = MontserratExtraLight; pillBottleFoundReward_text.fontSize = 6.5f;
        medalFoundReward_text.text = "Reward for finding the victory medal:"; medalFoundReward_text.font = MontserratExtraLight; medalFoundReward_text.fontSize = 6.5f;
        cookieFoundReward_text.text = "Reward for finding the cookie:"; cookieFoundReward_text.font = MontserratExtraLight; cookieFoundReward_text.fontSize = 6.5f;
        presentFoundReward_text.text = "Reward for finding the christmas present:"; presentFoundReward_text.font = MontserratExtraLight; presentFoundReward_text.fontSize = 6.8f;
        axeFoundReward_text.text = "Reward for finding the battle axe:"; axeFoundReward_text.font = MontserratExtraLight; axeFoundReward_text.fontSize = 6.8f;
        envelopeFoundReward_text.text = "Reward for finding the sealed envelope:"; envelopeFoundReward_text.font = MontserratExtraLight; envelopeFoundReward_text.fontSize = 6.8f;
        coin100XFoundReward_text.text = "Reward for finding the 100X gold coin:"; coin100XFoundReward_text.font = MontserratExtraLight; coin100XFoundReward_text.fontSize = 6.8f;
        potionFoundReward_text.text = "Reward for finding the potion:"; potionFoundReward_text.font = MontserratExtraLight; potionFoundReward_text.fontSize = 6.8f;
        soulGemFoundReward_text.text = "Reward for finding the soul gem:"; soulGemFoundReward_text.font = MontserratExtraLight; soulGemFoundReward_text.fontSize = 6.8f;
        sscrollFoundReward_text.text = "Reward for finding the ancient scroll"; sscrollFoundReward_text.font = MontserratExtraLight; sscrollFoundReward_text.fontSize = 6.8f;
        brickFoundReward_text.text = "Reward for finding the brick"; brickFoundReward_text.font = MontserratExtraLight; brickFoundReward_text.fontSize = 6.8f;
        chickenFoundReward_text.text = "Reward for finding the rubber chicken"; chickenFoundReward_text.font = MontserratExtraLight; chickenFoundReward_text.fontSize = 6.8f;

        allSkullRewards_text.text = "+3% <color=white>Passive damage"; allSkullRewards_text.font = MontserratMediumSDF1; allSkullRewards_text.fontSize = 11f;
        allDemonicSwordRewards_text.text = "+5% <color=white>Active damage. <color=green>+0.3%<color=white> <color=white>Crit Chance"; allDemonicSwordRewards_text.font = MontserratMediumSDF1; allDemonicSwordRewards_text.fontSize = 9f;
        allMysticRingRewards_text.text = "+0.05% <color=white>Treasure drop chance"; allMysticRingRewards_text.font = MontserratMediumSDF1; allMysticRingRewards_text.fontSize = 9f;
        allTrophyRewards_text.text = "+0.05% <color=white>Treasure drop chance"; allTrophyRewards_text.font = MontserratMediumSDF1; allTrophyRewards_text.fontSize = 9f;
        allFallenStarRewards_text.text = "+4% <color=white>Chance for a treasure to double in value"; allFallenStarRewards_text.font = MontserratMediumSDF1; allFallenStarRewards_text.fontSize = 7.5f;
        allCloverRewards_text.text = "+2% <color=white>for a 5X gold coin  <color=green>+1%<color=white> for a 10X gold coin"; allCloverRewards_text.font = MontserratMediumSDF1; allCloverRewards_text.fontSize = 7.5f;
        allKingsCrownRewards_text.text = "<color=white>Leveling up cursors makes them stronger"; allKingsCrownRewards_text.font = MontserratMediumSDF1; allKingsCrownRewards_text.fontSize = 7.5f;
        allSpellBookRewards_text.text = "<color=white>Leveling up items makes them stronger"; allSpellBookRewards_text.font = MontserratMediumSDF1; allSpellBookRewards_text.fontSize = 7f;
        allGuitarRewards_text.text = "+20% <color=white>Active and passive damage"; allGuitarRewards_text.font = MontserratMediumSDF1; allGuitarRewards_text.fontSize = 7.5f;
        allTalarianRewards_text.text = "+30% <color=white>Passive damage"; allTalarianRewards_text.font = MontserratMediumSDF1; allTalarianRewards_text.fontSize = 7.5f;
        allMythruneRewards_text.text = "+15% <color=white>gold"; allMythruneRewards_text.font = MontserratMediumSDF1; allMythruneRewards_text.fontSize = 7.5f;
        allExplorerBackpackRewards_text.text = "+15% <color=white>XP, <color=green> +15% <color=white>Gold,  <color=green>+0.1% <color=white>Treasure drop chance"; allExplorerBackpackRewards_text.font = MontserratMediumSDF1; allExplorerBackpackRewards_text.fontSize = 7.1f;
        allVikingShieldRewards_text.text = "+7% <color=white>For a treasure to double in value"; allVikingShieldRewards_text.font = MontserratMediumSDF1; allVikingShieldRewards_text.fontSize = 7.1f;
        allPillBottleRewards_text.text = "<color=white>Potions stack +1 times"; allPillBottleRewards_text.font = MontserratMediumSDF1; allPillBottleRewards_text.fontSize = 7.1f;
        allVictoryMedalRewards_text.text = "+1%<color=white> Chance to spawn a gold coin on each click & <color=green> +0.2% <color=white>Chance to spawn a treasure"; allVictoryMedalRewards_text.font = MontserratMediumSDF1; allVictoryMedalRewards_text.fontSize = 6.8f;
        foundCookieRewards_text.text = "+50%<color=white> Gold. <color=green>+50 <color=white>XP. <color=green>+0.2% <color=white>Treasure drop chance. <color=green>+5% <color=white>Treasure double in value. <color=green>+75%<color=white> Active and passive damage. <color=white><color=green>+3%<color=white> Crit chance.<color=green> +150%<color=white> Crit Damage"; foundCookieRewards_text.font = MontserratMediumSDF1; foundCookieRewards_text.fontSize = 6.6f;
        foundChristmasPresentRewards_text.text = "Ancient relic gives stronger buffs"; foundChristmasPresentRewards_text.font = MontserratMediumSDF1; foundChristmasPresentRewards_text.fontSize = 9f;
        foundBattleAxeRewards_text.text = "<color=white>Every click has a <color=green>+0.1% <color=white>chance to instantly open a chest. Instantly opening a chest will double the chest rewards"; foundBattleAxeRewards_text.font = MontserratMediumSDF1; foundBattleAxeRewards_text.fontSize = 6f;
        foundEnvelopeRewards.text = "+0.2%<color=white> Reinforced chest chance"; foundEnvelopeRewards.font = MontserratMediumSDF1; foundEnvelopeRewards.fontSize = 8f;
        foundGoldCoin100XRewards_text.text = "0.05%<color=white> Chance to drop a <color=yellow>100X gold coin"; foundGoldCoin100XRewards_text.font = MontserratMediumSDF1; foundGoldCoin100XRewards_text.fontSize = 8f;
        foundPotionRewards_text.text = "All potions get much stronger when upgraded"; foundPotionRewards_text.font = MontserratMediumSDF1; foundPotionRewards_text.fontSize = 7f;
        foundSoulGemRewards_text.text = "Soul gems will continue to drop. Click on the soul gem to gain a permanent buff to a random stat. <color=green>0.2% <color=white>Soul gem drop chance."; foundSoulGemRewards_text.font = MontserratMediumSDF1; foundSoulGemRewards_text.fontSize = 6.25f;
        foundAncientScrollRewards_text.text = "Serendipity scroll gives stronger buffs"; foundAncientScrollRewards_text.font = MontserratMediumSDF1; foundAncientScrollRewards_text.fontSize = 8f;
        foundBrickRewards_text.text = "well its just a brick... so... nothing..."; foundBrickRewards_text.font = MontserratMediumSDF1; foundBrickRewards_text.fontSize = 8f;
        foundRubberChickenRewards_text.text = "Gives a massive buff to a stat of your choosing."; foundRubberChickenRewards_text.font = MontserratMediumSDF1; foundRubberChickenRewards_text.fontSize = 7f;
       

        pirateSkullDescription_text.text = "\"Through stormy seas and battles untold, this skull harbors the legacy of a ruthless pirate.\""; pirateSkullDescription_text.font = MontserratRegular; pirateSkullDescription_text.fontSize = 7f;

        demonicSwordDescription_text.text = "\"A weapon of unholy origin, this demonic sword embodies the very essence of damnation\""; demonicSwordDescription_text.font = MontserratRegular; demonicSwordDescription_text.fontSize = 7f;

        mysticRingDescription_text.text = "\"The Mystic Ring enhances your fortune, making treasures drop more frequently\""; mysticRingDescription_text.font = MontserratRegular; mysticRingDescription_text.fontSize = 7f;

        trophyDescription_text.text = "\"Intrigue lingers. Why store the Trophy, a testament to greatness, within a chest ? \""; trophyDescription_text.font = MontserratRegular; trophyDescription_text.fontSize = 7f;

        fallenStarDescription_text.text = "\"These chests holds rare treasures.A Fallen Star, a cosmic relic of wonder.\""; fallenStarDescription_text.font = MontserratRegular; fallenStarDescription_text.fontSize = 7f;

        cloverDescription_text.text = "\"Discover the luck - bringing charm—the four-leafed Clover nestled within a chest.\""; cloverDescription_text.font = MontserratRegular; cloverDescription_text.fontSize = 7f;

        kingsCrownDescription_text.text = "\"Reveal the majestic artifact—a crown that carries the weight of a kingdom's legacy.\""; kingsCrownDescription_text.font = MontserratRegular; kingsCrownDescription_text.fontSize = 7.6f;

        spellBookDescription_text.text = "\"Unveil the Spell Book's hidden knowledge, empowering you with the art of magic.\""; spellBookDescription_text.font = MontserratRegular; spellBookDescription_text.fontSize = 7.6f;

        guitarDescription_text.text = "\"Why was this Guitar hidden away inside a chest? Its strings carry echoes of a deeply personal connection.\""; guitarDescription_text.font = MontserratRegular; guitarDescription_text.fontSize = 6.9f;

        talarianDescription_text.text = "\"Within the treasure chest lies the legendary Talaria, a symbol of swiftness and freedom.\""; talarianDescription_text.font = MontserratRegular; talarianDescription_text.fontSize = 6.9f;

        strangeRuneDescription_text.text = "\"Unearth the Mythrune's essence, and be touched by the echoes of ancient magic.\""; strangeRuneDescription_text.font = MontserratRegular; strangeRuneDescription_text.fontSize = 6.7f;

        explorerBackpackDescription_text.text = "\"Open the Explorer Backpack and uncover a trove of tools for daring adventures.\""; explorerBackpackDescription_text.font = MontserratRegular; explorerBackpackDescription_text.fontSize = 6.7f;

        vikingShieldDescription_text.text = "\"Within the Viking Shield resides the legacy of valiant warriors who feared no battle.\""; vikingShieldDescription_text.font = MontserratRegular; vikingShieldDescription_text.fontSize = 7f;

        pillBottleDescription_text.text = "\"Amidst the riches, an unassuming pill bottle hides, its purpose intriguingly obscure.\""; pillBottleDescription_text.font = MontserratRegular; pillBottleDescription_text.fontSize = 7f;

        victoryMedalDescription_text.text = "\"Embrace the Victory Medal, a symbol of triumphant glory and unwavering determination.\""; victoryMedalDescription_text.font = MontserratRegular; victoryMedalDescription_text.fontSize = 6.5f;

        cookieDescription_text.text = "CLICK IT"; cookieDescription_text.font = MontserratRegular; cookieDescription_text.fontSize = 7f;

        christmasPresentDescription_text.text = "\"We will never know whats inside it\""; christmasPresentDescription_text.font = MontserratRegular; christmasPresentDescription_text.fontSize = 7f;

        battleAxeDescription_text.text = "\"This battle axe, forged with expert craftsmanship, gleams with a deadly edge, ready to cleave through your foes with ruthless efficiency.\""; battleAxeDescription_text.font = MontserratRegular; battleAxeDescription_text.fontSize = 6f;

        goldCoin100XDescription_text.text = "\"There are not many of these coins left in the world\""; goldCoin100XDescription_text.font = MontserratRegular; goldCoin100XDescription_text.fontSize = 7f;

        sealedEnvelopeDescription_text.text = "\"Most likely written by a historical figure\""; sealedEnvelopeDescription_text.font = MontserratRegular; sealedEnvelopeDescription_text.fontSize = 7f;

        strangePotionDescription_text.text = "\"This mysterious potion swirls with enigmatic colors, promising both risks and rewards to those daring enough to consume it.\""; strangePotionDescription_text.font = MontserratRegular; strangePotionDescription_text.fontSize = 6f;

        soulGemDescription_text.text = "\"This radiant gem pulses with the power of the cosmos, promising to augment your character's strength and capabilities.\""; soulGemDescription_text.font = MontserratRegular; soulGemDescription_text.fontSize = 6f;

        ancientScrollDescription_text.text = "\"An ancient scroll filled with age-old wisdom and insights.\""; ancientScrollDescription_text.font = MontserratRegular; ancientScrollDescription_text.fontSize = 7f;

        brickDescription_text.text = "\"Yep... its just a brick\""; brickDescription_text.font = MontserratRegular; brickDescription_text.fontSize = 7f;

        rubberChickenDescription_text.text = "\"You might think this rubber chicken is joke, but inside it holds a powerfull force\""; rubberChickenDescription_text.font = MontserratRegular; rubberChickenDescription_text.fontSize = 7f;

        skullDropChance_text.text = "0,0278%<color=white> Drop chance"; skullDropChance_text.font = MontserratExtraLight; skullDropChance_text.fontSize = 10f;
        democSwordDropChance_text.text = "0,0119%<color=white> Drop chance"; democSwordDropChance_text.font = MontserratExtraLight; democSwordDropChance_text.fontSize = 10f;
        mysticRingDropChance_text.text = "0,0051%<color=white> Drop chance"; mysticRingDropChance_text.font = MontserratExtraLight; mysticRingDropChance_text.fontSize = 10f;
        trophyDropChance_text.text = "0,0050%<color=white> Drop chance"; trophyDropChance_text.font = MontserratExtraLight; trophyDropChance_text.fontSize = 10f;
        fallenStarDropChance_text.text = "0,0008%<color=white> Drop chance"; fallenStarDropChance_text.font = MontserratExtraLight; fallenStarDropChance_text.fontSize = 10f;
        cloverDropChance_text.text = "0,0005%<color=white> Drop chance"; cloverDropChance_text.font = MontserratExtraLight; cloverDropChance_text.fontSize = 10f;
        kingsCrownDropChance_text.text = "0,0006%<color=white> Drop chance"; kingsCrownDropChance_text.font = MontserratExtraLight; kingsCrownDropChance_text.fontSize = 10f;
        spellBookDropChance_text.text = "0,0006%<color=white> Drop chance"; spellBookDropChance_text.font = MontserratExtraLight; spellBookDropChance_text.fontSize = 10f;
        guitarDropChance_text.text = "0,0009%<color=white> Drop chance"; guitarDropChance_text.font = MontserratExtraLight; guitarDropChance_text.fontSize = 10f;
        talarianDropChance_text.text = "0,00077%<color=white> Drop chance"; talarianDropChance_text.font = MontserratExtraLight; talarianDropChance_text.fontSize = 10f;
        mythRuneDropChance_text.text = "0,0016%<color=white> Drop chance"; mythRuneDropChance_text.font = MontserratExtraLight; mythRuneDropChance_text.fontSize = 10f;
        backPackDropChance_text.text = "0,00052%<color=white> Drop chance"; backPackDropChance_text.font = MontserratExtraLight; backPackDropChance_text.fontSize = 10f;
        vikingShieldDropChance_text.text = "0,00063%<color=white> Drop chance"; vikingShieldDropChance_text.font = MontserratExtraLight; vikingShieldDropChance_text.fontSize = 10f;
        pillBottleDropChance_text.text = "0,00050%<color=white> Drop chance"; pillBottleDropChance_text.font = MontserratExtraLight; pillBottleDropChance_text.fontSize = 10f;
        victoryMedalDropChance_text.text = "0,00042%<color=white> Drop chance"; victoryMedalDropChance_text.font = MontserratExtraLight; victoryMedalDropChance_text.fontSize = 10f;
        cookieDropChance_text.text = "0,00034%<color=white> Drop chance"; cookieDropChance_text.font = MontserratExtraLight; cookieDropChance_text.fontSize = 10f;
        presentDropChance_text.text = "0,00038%<color=white> Drop chance"; presentDropChance_text.font = MontserratExtraLight; presentDropChance_text.fontSize = 10f;
        battleAxeDropChance_text.text = "0,00032%<color=white> Drop chance"; battleAxeDropChance_text.font = MontserratExtraLight; battleAxeDropChance_text.fontSize = 10f;
        coin100XDropChance_text.text = "0,00030%<color=white> Drop chance"; coin100XDropChance_text.font = MontserratExtraLight; coin100XDropChance_text.fontSize = 10f;
        envelopeDropChance_text.text = "0,00036%<color=white> Drop chance"; envelopeDropChance_text.font = MontserratExtraLight; envelopeDropChance_text.fontSize = 10f;
        strangePotionDropChance_text.text = "0,00030%<color=white> Drop chance"; strangePotionDropChance_text.font = MontserratExtraLight; strangePotionDropChance_text.fontSize = 10f;
        soulGemDropChance_text.text = "0,00034%<color=white> Drop chance"; soulGemDropChance_text.font = MontserratExtraLight; soulGemDropChance_text.fontSize = 10f;
        ancientScrollDropChance_text.text = "0,00029%<color=white> Drop chance"; ancientScrollDropChance_text.font = MontserratExtraLight; ancientScrollDropChance_text.fontSize = 10f;
        brickDropChance_text.text = "0,00026%<color=white> Drop chance"; brickDropChance_text.font = MontserratExtraLight; brickDropChance_text.fontSize = 10f;
        chickenDropChance_text.text = "0,00025%<color=white> Drop chance"; chickenDropChance_text.font = MontserratExtraLight; chickenDropChance_text.fontSize = 10f;

        congratsMessage_text.text = "Congrats! You have all 25 rare treasures!"; congratsMessage_text.font = changaMedium; congratsMessage_text.fontSize = 17f;
        purchaseRareTreasure_text.text = "Purchase all prestige upgrades to unlock."; purchaseRareTreasure_text.font = changaMedium; purchaseRareTreasure_text.fontSize = 17f;
        purchase1MissingTreasure_text.text = "Purchase 1 rare treasure that is missing?"; purchase1MissingTreasure_text.font = changaMedium; purchase1MissingTreasure_text.fontSize = 12f;

        chooseChickenBuff_text.text = "CHOOSE BUFF FROM THE CHICKEN:"; chooseChickenBuff_text.font = ChangaBoldSDF1; chooseChickenBuff_text.fontSize = 36f;
        coose1_text.text = "CHOOSE"; coose1_text.font = ChangaBoldSDF1; coose1_text.fontSize = 23f;
        coose2_text.text = "CHOOSE"; coose2_text.font = ChangaBoldSDF1; coose2_text.fontSize = 23f;
        coose3_text.text = "CHOOSE"; coose3_text.font = ChangaBoldSDF1; coose3_text.fontSize = 23f;
        coose4_text.text = "CHOOSE"; coose4_text.font = ChangaBoldSDF1; coose4_text.fontSize = 23f;
        coose5_text.text = "CHOOSE"; coose5_text.font = ChangaBoldSDF1; coose5_text.fontSize = 23f;
        coose6_text.text = "CHOOSE"; coose6_text.font = ChangaBoldSDF1; coose6_text.fontSize = 23f;
        coose7_text.text = "CHOOSE"; coose7_text.font = ChangaBoldSDF1; coose7_text.fontSize = 23f;
        #endregion

        #region Treasure Chests
        chestPurchase_text.text = "PURCHASE"; chestPurchase_text.font = ChangaBoldSDF; chestPurchase_text.fontSize = 36;
        autoPurchase_text.text = "Automatically purchase the next chest when affordable:"; autoPurchase_text.font = MontserratExtraLight; autoPurchase_text.fontSize = 11;
        chestTREASURESDROP_text.text = "TREASURE DROPS:"; chestTREASURESDROP_text.font = changaMedium; chestTREASURESDROP_text.fontSize = 18;
        reinforcedPopUp_text.text = "REINFORCED CHEST"; reinforcedPopUp_text.font = MontserratBold; reinforcedPopUp_text.fontSize = 36;
        enchantedGoldenChestPopUp_text.text = "ENCHANTED GOLDEN CHEST"; enchantedGoldenChestPopUp_text.font = MontserratBold; enchantedGoldenChestPopUp_text.fontSize = 32;
        bossChest_text.text = "BOSS CHEST"; bossChest_text.font = MontserratBold; bossChest_text.fontSize = 50;
        reinforcedHover_text.text = "REINFORCED CHEST"; reinforcedHover_text.font = MontserratBold; reinforcedHover_text.fontSize = 25;
       
        enchantedGoldenHover_text.text = "ENCHANTED GOLDEN CHEST"; enchantedGoldenHover_text.font = MontserratBold; enchantedGoldenHover_text.fontSize =24;
        enchantedGoldenHoverLockPickKeys_text.text = "-Lockpicks and keys only removes 25% of the health"; enchantedGoldenHoverLockPickKeys_text.font = myriadPro; enchantedGoldenHoverLockPickKeys_text.fontSize = 17;

        bossChestHover_text.text = "BOSS CHEST"; bossChestHover_text.font = MontserratBold; bossChestHover_text.fontSize = 38;
        bossChestHoverLockPickKeys_text.text = "-Lockpicks and keys only removes 25% of the health"; bossChestHoverLockPickKeys_text.font = myriadPro; bossChestHoverLockPickKeys_text.fontSize = 16;


        #endregion

        #region prestige

        wouldYouLiketoGoBack_text.text = "Would you like to go back and open some more chests?";
        wouldYouLiketoGoBack_text.font = MontserratSemiBold; wouldYouLiketoGoBack_text.fontSize = 40;

        butFirst_text.text = "but first...";
        butFirst_text.font = MontserratSemiBold; butFirst_text.fontSize = 20;

        purchaseTheGoodieBag_text.text = "Purchase the \"Goodie Bag\" Prestige Upgrade to unlock";
        purchaseTheGoodieBag_text.font = MontserratMediumSDF1; purchaseTheGoodieBag_text.fontSize = 22;

        goBackYES_text.text = "YES"; goBackYES_text.font = changaMedium; goBackYES_text.fontSize = 60;

        goBackNO_text.text = "NO"; goBackNO_text.font = changaMedium; goBackNO_text.fontSize = 60;

        itesmChosen_text.text = "Items Chosen!"; itesmChosen_text.font = MontserratMediumSDF1; itesmChosen_text.fontSize = 26;

        chooseSomethingElse_text.text = "CHOOSE SOMETHING ELSE"; chooseSomethingElse_text.font = ChangaBoldSDF1; chooseSomethingElse_text.fontSize = 31;

        prestigeExit_text.text = "EXIT"; prestigeExit_text.font = ChangaBoldSDF; prestigeExit_text.fontSize = 47;

        for (int i = 0; i < lockedPrestige_text.Length; i++)
        {
            lockedPrestige_text[i].text = "LOCKED"; lockedPrestige_text[i].font = MontserratMediumSDF1; lockedPrestige_text[i].fontSize = 12f;
             unlockedPrestige_text[i].text = "UNLOCKED"; unlockedPrestige_text[i].font = MontserratMediumSDF1; unlockedPrestige_text[i].fontSize = 8.6f;
        }

        findThePrestigeKeyAncChest_text.lineSpacing = -75;
        openPrestigeScreen_text.lineSpacing = -95;

        loseText_text.lineSpacing = -70;
        keepText_text.lineSpacing = -60;

        // For individual variables
        prestigeTop_text.text = "PRESTIGE"; prestigeTop_text.font = ChangaBoldSDF; prestigeTop_text.fontSize = 50;
        prestigeButton_text.text = "PRESTIGE"; prestigeButton_text.font = ChangaBoldSDF; prestigeButton_text.fontSize = 36;
        openPrestigeScreen_text.text = "OPEN PRESTIGE SCREEN"; openPrestigeScreen_text.font = ChangaBoldSDF; openPrestigeScreen_text.fontSize = 28;
        skillPoints_text.text = "SKILL POINTS"; skillPoints_text.font = ChangaBoldSDF; skillPoints_text.fontSize = 20;
        
        wouldYouLikeToPrestige_text.text = "Would you like to prestige?"; wouldYouLikeToPrestige_text.font = ChangaBoldSDF1; wouldYouLikeToPrestige_text.fontSize = 22;
        youWillKeep_text.text = "YOU WILL KEEP"; youWillKeep_text.font = ChangaBoldSDF1; youWillKeep_text.fontSize = 46;
        keepText_text.text = "-Prestige upgrades \n-Rare treasures \n-Achievement"; keepText_text.font = ChangaBoldSDF1; keepText_text.fontSize = 34;
        youWillLose_text.text = "YOU WILL LOSE"; youWillLose_text.font = ChangaBoldSDF1; youWillLose_text.fontSize = 46;
        loseText_text.text = "-All Gold\n-Treasures\n-Levels\n-Items\n-Item LVLS\n-Cursors\n-Cursor LVLS\n-Scroll stats"; loseText_text.font = ChangaBoldSDF1; loseText_text.fontSize = 37;
        prestigeWillTakeYou_text.text = "Prestige will take you to the skill tree where you can purchase permanent upgrades"; prestigeWillTakeYou_text.font = ChangaBoldSDF1; prestigeWillTakeYou_text.fontSize = 14.4f;
        prestigeYES_text.text = "YES"; prestigeYES_text.font = ChangaBoldSDF1; prestigeYES_text.fontSize = 25;
        prestigeNO_text.text = "NO"; prestigeNO_text.font = ChangaBoldSDF1; prestigeNO_text.fontSize = 25;
        prestigeAndSkillPoints_text.text = "Prestige & Skill Points"; prestigeAndSkillPoints_text.font = ChangaBoldSDF1; prestigeAndSkillPoints_text.fontSize = 80;
        prestigeExplinations_text.text = "-The Prestige Key and Prestige Chest gets a <color=green>+0.017% <color=white>drop chance after a new chest is unlocked"; prestigeExplinations_text.font = liberationSans; prestigeExplinations_text.fontSize = 32;
        prestigeExplinations2_text.text = "-You recieve skill points at every level up. Each fifth level gives you +1 skill point to the total skill points recieved. Skill points recieved each level =<color=green> (Current level / 5) + 1"; prestigeExplinations2_text.font = liberationSans; prestigeExplinations2_text.fontSize = 32;
        currentlyViewingPrestige_text.text = "You are currently only viewing the prestige screen. Press the <color=green>\"Prestige\"<color=white> button to prestige and start spending your skill points!"; currentlyViewingPrestige_text.font = MontserratMediumSDF1; currentlyViewingPrestige_text.fontSize = 38;
        skillPointsTextInsode_text.text = "SKILL POINTS"; skillPointsTextInsode_text.font = changaMedium; skillPointsTextInsode_text.fontSize = 36;

        clickerUnder_text.text = "CLICKER"; clickerUnder_text.font = changaMedium; clickerUnder_text.fontSize = 44;
        loungerUnder_text.text = "LOUNGER"; loungerUnder_text.font = changaMedium; loungerUnder_text.fontSize = 44;
        pirateUnder_text.text = "PIRATE"; pirateUnder_text.font = changaMedium; pirateUnder_text.fontSize = 44;
        hoarderUnder_text.text = "HOARDER"; hoarderUnder_text.font = changaMedium; hoarderUnder_text.fontSize = 44;
        adventurerUnder_text.text = "ADVENTURER"; adventurerUnder_text.font = changaMedium; adventurerUnder_text.fontSize = 44;

        bossChestPresitgeName_text.text = "BOSS CHEST"; bossChestPresitgeName_text.font = ChangaBoldSDF; bossChestPresitgeName_text.fontSize = 26;
        reinforcedItems_text.text = "Reinforced Items"; reinforcedItems_text.font = ChangaBoldSDF; reinforcedItems_text.fontSize = 22;
        potionStacker_text.text = "Potion Stacker"; potionStacker_text.font = ChangaBoldSDF; potionStacker_text.fontSize = 24;
        fortifiedItems_text.text = "Fortified Items"; fortifiedItems_text.font = ChangaBoldSDF; fortifiedItems_text.fontSize = 26;
        enhancedItems_text.text = "Enchanced Items"; enhancedItems_text.font = ChangaBoldSDF; enhancedItems_text.fontSize = 23;
        enchantedItems_text.text = "Enchanted Items"; enchantedItems_text.font = ChangaBoldSDF; enchantedItems_text.fontSize = 22;
        itemMastery_text.text = "Item Mastery"; itemMastery_text.font = ChangaBoldSDF; itemMastery_text.fontSize = 26;
        enchantmentQuill_text.text = "Echantment Quill"; enchantmentQuill_text.font = ChangaBoldSDF; enchantmentQuill_text.fontSize = 23;
        wizard_text.text = "Wizard"; wizard_text.font = ChangaBoldSDF; wizard_text.fontSize = 26;
        student_text.text = "Student"; student_text.font = ChangaBoldSDF; student_text.fontSize = 26;
        potionChug_text.text = "Potion Chug"; potionChug_text.font = ChangaBoldSDF; potionChug_text.fontSize = 26;
        transcendence_text.text = "Transcendence"; transcendence_text.font = ChangaBoldSDF; transcendence_text.fontSize = 23;
        elevation_text.text = "Elevation"; elevation_text.font = ChangaBoldSDF; elevation_text.fontSize = 26;
        xpAccelerator_text.text = "XP Accelerator"; xpAccelerator_text.font = ChangaBoldSDF; xpAccelerator_text.fontSize = 25;
        proficiency_text.text = "Proficiency"; proficiency_text.font = ChangaBoldSDF; proficiency_text.fontSize = 26;
        levelMastery_text.text = "Level Mastery"; levelMastery_text.font = ChangaBoldSDF; levelMastery_text.fontSize = 26;
        advancement_text.text = "Advancment"; advancement_text.font = ChangaBoldSDF; advancement_text.fontSize = 26;
        xpBoost_text.text = "XP Boost"; xpBoost_text.font = ChangaBoldSDF; xpBoost_text.fontSize = 26;
        masterPirate_text.text = "Master Pirate"; masterPirate_text.font = ChangaBoldSDF; masterPirate_text.fontSize = 26;
        fortuneSeeker_text.text = "Fortune Seeker"; fortuneSeeker_text.font = ChangaBoldSDF; fortuneSeeker_text.fontSize = 26;
        pirate_text.text = "Pirate"; pirate_text.font = ChangaBoldSDF; pirate_text.fontSize = 26;
        rapidLeveling_text.text = "Rapid Leveling"; rapidLeveling_text.font = ChangaBoldSDF; rapidLeveling_text.fontSize = 26;
        treasureAmplifier_text.text = "Treasure Amplifier"; treasureAmplifier_text.font = ChangaBoldSDF; treasureAmplifier_text.fontSize = 22;
        stackingSplendor_text.text = "Stacking Splendor"; stackingSplendor_text.font = ChangaBoldSDF; stackingSplendor_text.fontSize = 21;
        goodieBag_text.text = "Goodie Bag"; goodieBag_text.font = ChangaBoldSDF; goodieBag_text.fontSize = 26;
        reinforcedRiches_text.text = "Reinforced Riches"; reinforcedRiches_text.font = ChangaBoldSDF; reinforcedRiches_text.fontSize = 20;
        chestBlessing_text.text = "Chest Blessing"; chestBlessing_text.font = ChangaBoldSDF; chestBlessing_text.fontSize = 25;
        chestSurge_text.text = "Chest Surge"; chestSurge_text.font = ChangaBoldSDF; chestSurge_text.fontSize = 26;
        fortifiedFortune_text.text = "Fortified Fortune"; fortifiedFortune_text.font = ChangaBoldSDF; fortifiedFortune_text.fontSize = 23;
        enchantedGoldenChest_text.text = "Enchanted Golden Chest"; enchantedGoldenChest_text.font = ChangaBoldSDF; enchantedGoldenChest_text.fontSize = 17;
        piratesParadise_text.text = "Pirate's Paradise"; piratesParadise_text.font = ChangaBoldSDF; piratesParadise_text.fontSize = 23;
        luxuriousLooting_text.text = "Luxurious Looting"; luxuriousLooting_text.font = ChangaBoldSDF; luxuriousLooting_text.fontSize = 21;
        lootBonanza_text.text = "Loot Bonanza"; lootBonanza_text.font = ChangaBoldSDF; lootBonanza_text.fontSize = 26;
        chestEnrichment_text.text = "Chest Enrichment"; chestEnrichment_text.font = ChangaBoldSDF; chestEnrichment_text.fontSize = 21;
        greaterLoot_text.text = "Greater Loot"; greaterLoot_text.font = ChangaBoldSDF; greaterLoot_text.fontSize = 26;
        treasuryReinforcement_text.text = "Treasury Reinforcement"; treasuryReinforcement_text.font = ChangaBoldSDF; treasuryReinforcement_text.fontSize = 16;
        strongbox_text.text = "Strongbox"; strongbox_text.font = ChangaBoldSDF; strongbox_text.fontSize = 27;
        fortified_text.text = "Fortified "; fortified_text.font = ChangaBoldSDF; fortified_text.fontSize = 26;
        gildedFortification_text.text = "Gilded Fortification"; gildedFortification_text.font = ChangaBoldSDF; gildedFortification_text.fontSize = 21;
        reinforcedPlus_text.text = "Reinforced +"; reinforcedPlus_text.font = ChangaBoldSDF; reinforcedPlus_text.fontSize = 26;
        wellPrepared_text.text = "Well Prepared"; wellPrepared_text.font = ChangaBoldSDF; wellPrepared_text.fontSize = 26;
        stashedItems_text.text = "Stashed Items"; stashedItems_text.font = ChangaBoldSDF; stashedItems_text.fontSize = 26;
        travelBag_text.text = "Travel Bag"; travelBag_text.font = ChangaBoldSDF; travelBag_text.fontSize = 26;
        buffsGalore_text.text = "Buffs Galore"; buffsGalore_text.font = ChangaBoldSDF; buffsGalore_text.fontSize = 24;
        lootEnhancer_text.text = "Loot Enhancer"; lootEnhancer_text.font = ChangaBoldSDF; lootEnhancer_text.fontSize = 24;
        treasureHunter_text.text = "Treasure Hunter"; treasureHunter_text.font = ChangaBoldSDF; treasureHunter_text.fontSize = 26;
        collector_text.text = "Collector"; collector_text.font = ChangaBoldSDF; collector_text.fontSize = 26;
        autoClicker1_text.text = "Auto Clicker "; autoClicker1_text.font = ChangaBoldSDF; autoClicker1_text.fontSize = 26;
        autoClicker2_text.text = "Auto Clicker +"; autoClicker2_text.font = ChangaBoldSDF; autoClicker2_text.fontSize = 26;
        autoClicker3_text.text = "Auto Clicker ++"; autoClicker3_text.font = ChangaBoldSDF; autoClicker3_text.fontSize = 26;
        autoClicker4_text.text = "Rapid Clicker"; autoClicker4_text.font = ChangaBoldSDF; autoClicker4_text.fontSize = 26;
        cursorEnchantment_text.text = "Cursor Enchantment"; cursorEnchantment_text.font = ChangaBoldSDF; cursorEnchantment_text.fontSize = 20;
        advancedCursors_text.text = "Advanced Cursors"; advancedCursors_text.font = ChangaBoldSDF; advancedCursors_text.fontSize = 22;
        cursorEvolution_text.text = "Cursor Evolution"; cursorEvolution_text.font = ChangaBoldSDF; cursorEvolution_text.fontSize = 24;
        cursorEnhanced_text.text = "Cursor Enhanced"; cursorEnhanced_text.font = ChangaBoldSDF; cursorEnhanced_text.fontSize = 23;
        crushingForce_text.text = "Crushing Force"; crushingForce_text.font = ChangaBoldSDF; crushingForce_text.fontSize = 26;
        swiftblade_text.text = "Swiftblade"; swiftblade_text.font = ChangaBoldSDF; swiftblade_text.fontSize = 26;
        fury_text.text = "Fury"; fury_text.font = ChangaBoldSDF; fury_text.fontSize = 26;
        clickstorm_text.text = "Clickstorm"; clickstorm_text.font = ChangaBoldSDF; clickstorm_text.fontSize = 26;
        tapPrecision_text.text = "Tap Precision"; tapPrecision_text.font = ChangaBoldSDF; tapPrecision_text.fontSize = 26;
        clickersFury_text.text = "Clicker's Fury"; clickersFury_text.font = ChangaBoldSDF; clickersFury_text.fontSize = 26;
        tapMastery_text.text = "Tap Mastery"; tapMastery_text.font = ChangaBoldSDF; tapMastery_text.fontSize = 26;
        cripplingStrikes_text.text = "Crippling Strikes"; cripplingStrikes_text.font = ChangaBoldSDF; cripplingStrikes_text.fontSize = 24;
        savageCrits_text.text = "Savage Crits"; savageCrits_text.font = ChangaBoldSDF; savageCrits_text.fontSize = 26;
        lethalPrecision_text.text = "Lethal Precision"; lethalPrecision_text.font = ChangaBoldSDF; lethalPrecision_text.fontSize = 24;
        ruthlessStrikes_text.text = "Ruthless Strikes"; ruthlessStrikes_text.font = ChangaBoldSDF; ruthlessStrikes_text.fontSize = 26;
        hardenedFist_text.text = "Hardened Fist"; hardenedFist_text.font = ChangaBoldSDF; hardenedFist_text.fontSize = 26;
        idler_text.text = "Idler"; idler_text.font = ChangaBoldSDF; idler_text.fontSize = 26;
        lazyRewards_text.text = "Lazy Rewards"; lazyRewards_text.font = ChangaBoldSDF; lazyRewards_text.fontSize = 26;
        unfathomableWealth_text.text = "UNFATHOMABLE WEALTH"; unfathomableWealth_text.font = ChangaBoldSDF; unfathomableWealth_text.fontSize = 15;
        ancientCoin_text.text = "Ancient Coin"; ancientCoin_text.font = ChangaBoldSDF; ancientCoin_text.fontSize = 26;
        fortuneCoin_text.text = "Fortune Coin"; fortuneCoin_text.font = ChangaBoldSDF; fortuneCoin_text.fontSize = 26;
        wealthEmpire_text.text = "Wealth Empire"; wealthEmpire_text.font = ChangaBoldSDF; wealthEmpire_text.fontSize = 26;
        luckyPenny_text.text = "Lucky Penny"; luckyPenny_text.font = ChangaBoldSDF; luckyPenny_text.fontSize = 26;
        fortune_text.text = "Fortune"; fortune_text.font = ChangaBoldSDF; fortune_text.fontSize = 26;
        extremelyWealthy_text.text = "Extremely Wealthy"; extremelyWealthy_text.font = ChangaBoldSDF; extremelyWealthy_text.fontSize = 21;
        wealthy_text.text = "Wealthy"; wealthy_text.font = ChangaBoldSDF; wealthy_text.fontSize = 26;
        idlersMastery_text.text = "Idler's Mastery"; idlersMastery_text.font = ChangaBoldSDF; idlersMastery_text.fontSize = 26;
        wealth_text.text = "Wealth"; wealth_text.font = ChangaBoldSDF; wealth_text.fontSize = 26;
        potentCursors_text.text = "Potent Cursors"; potentCursors_text.font = ChangaBoldSDF; potentCursors_text.fontSize = 26;
        mightyCursors_text.text = "Migthy Cursors"; mightyCursors_text.font = ChangaBoldSDF; mightyCursors_text.fontSize = 23;
        reforgedCursors_text.text = "Reforged Cursors"; reforgedCursors_text.font = ChangaBoldSDF; reforgedCursors_text.fontSize = 23;
        sloppyFist_text.text = "Sloppy Fist"; sloppyFist_text.font = ChangaBoldSDF; sloppyFist_text.fontSize = 26;
        effortless_text.text = "Effortless"; effortless_text.font = ChangaBoldSDF; effortless_text.fontSize = 26;
        loungingKing_text.text = "Lounging King"; loungingKing_text.font = ChangaBoldSDF; loungingKing_text.fontSize = 26;
        loungingPirate_text.text = "Lounging Pirate"; loungingPirate_text.font = ChangaBoldSDF; loungingPirate_text.fontSize = 24;
        loungingOgre_text.text = "Lounging Ogre"; loungingOgre_text.font = ChangaBoldSDF; loungingOgre_text.fontSize = 26;
        restfulIdler_text.text = "Restful Idler"; restfulIdler_text.font = ChangaBoldSDF; restfulIdler_text.fontSize = 26;
        cursorMastery_text.text = "Cursor Mastery"; cursorMastery_text.font = ChangaBoldSDF; cursorMastery_text.fontSize = 26;

        critDes1_text.text = ""; critDes1_text.font = MontserratSemiBold; critDes1_text.fontSize = 15;

        // Crit Descriptions
        critDes1_text.text = "<color=green>+0.5%<color=white> Crit chance";
        critDes1_2_text.text = "<color=green>+150%<color=white> Crit damage";
        critDes2_text.text = "<color=green>+1.5%<color=white> Crit chance";
        critDes2_2_text.text = "<color=green>+750%<color=white> Crit damage";
        critDes3_text.text = "<color=green>+1.8%<color=white> Crit chance";
        critDes3_2_text.text = "<color=green>+1500%<color=white> Crit damage";
        critDes4_text.text = "<color=green>+2.2%<color=white> Crit chance";
        critDes4_2_text.text = "<color=green>+10%<color=white> Chance to spawn a gold coin on critical hit";
        critDes5_text.text = "<color=green>+2500%<color=white> Crit damage";
        critDes5_2_text.text = "<color=green>+4%<color=white> Chance to spawn a treasure on critical hit";

        critDes1_text.font = MontserratSemiBold;
        critDes1_2_text.font = MontserratSemiBold;
        critDes2_text.font = MontserratSemiBold;
        critDes2_2_text.font = MontserratSemiBold;
        critDes3_text.font = MontserratSemiBold;
        critDes3_2_text.font = MontserratSemiBold;
        critDes4_text.font = MontserratSemiBold;
        critDes4_2_text.font = MontserratSemiBold;
        critDes5_text.font = MontserratSemiBold;
        critDes5_2_text.font = MontserratSemiBold;

        critDes1_text.fontSize = 15;
        critDes1_2_text.fontSize = 15;
        critDes2_text.fontSize = 15;
        critDes2_2_text.fontSize = 15;
        critDes3_text.fontSize = 15;
        critDes3_2_text.fontSize = 15;
        critDes4_text.fontSize = 15;
        critDes4_2_text.fontSize = 15;
        critDes5_text.fontSize = 15;
        critDes5_2_text.fontSize = 15;

        // Active Descriptions
        activeDes1_text.text = "<color=green>+50%<color=white> Active damage";
        activeDes2_text.text = "<color=green>+325%<color=white> Active damage";
        activeDes3_text.text = "<color=green>+1000%<color=white> Active damage";
        activeDes4_text.text = "<color=green>+2250%<color=white> Active damage";
        activeDes4_2_text.text = "<color=green>+1%<color=white> Chance to spawn a gold coin each click";
        activeDes5_text.text = "<color=green>+3500%<color=white> Active damage";
        activeDes5_2_text.text = "<color=green>+0.1%<color=white> Chance to spawn a treasure each click";
        activeDes6_text.text = "<color=green>+10000%<color=white> Active damage";
        activeDes6_2_text.text = "Every click has a <color=green>+0.4% <color=white>chance to instantly open a chest";
        activeDes7_text.text = "<color=green>+15000%<color=white> Active damage";
        activeDes7_2_text.text = "Every click has a <color=green>1%<color=white> chance to spawn a <color=yellow>5X gold coin";

        activeDes1_text.font = MontserratSemiBold;
        activeDes2_text.font = MontserratSemiBold;
        activeDes3_text.font = MontserratSemiBold;
        activeDes4_text.font = MontserratSemiBold;
        activeDes4_2_text.font = MontserratSemiBold;
        activeDes5_text.font = MontserratSemiBold;
        activeDes5_2_text.font = MontserratSemiBold;
        activeDes6_text.font = MontserratSemiBold;
        activeDes6_2_text.font = MontserratSemiBold;
        activeDes7_text.font = MontserratSemiBold;
        activeDes7_2_text.font = MontserratSemiBold;

        activeDes1_text.fontSize = 15;
        activeDes2_text.fontSize = 15;
        activeDes3_text.fontSize = 15;
        activeDes4_text.fontSize = 15;
        activeDes4_2_text.fontSize = 15;
        activeDes5_text.fontSize = 15;
        activeDes5_2_text.fontSize = 15;
        activeDes6_text.fontSize = 15;
        activeDes6_2_text.fontSize = 15;
        activeDes7_text.fontSize = 15;
        activeDes7_2_text.fontSize = 14.9f;

        // Active Cursor Descriptions
        activeCursorDes1_text.text = "Leveling up cursors with active damage, crit chance and crit damage makes them stronger";
        activeCursorDes2_text.text = "Leveling up cursors with active damage, crit chance and crit damage makes them stronger";
        activeCursorDes3_text.text = "All active damage, crit chance and crit damage cursors start out stronger";
        activeCursorDes4_text.text = "All active damage, crit chance and crit damage cursors start out stronger";
        activeCursorDes4_2_text.text = "Leveling up cursors with active damage, crit chance and crit damage makes them stronger";

        activeCursorDes1_text.font = MontserratSemiBold;
        activeCursorDes2_text.font = MontserratSemiBold;
        activeCursorDes3_text.font = MontserratSemiBold;
        activeCursorDes4_text.font = MontserratSemiBold;
        activeCursorDes4_2_text.font = MontserratSemiBold;

        activeCursorDes1_text.fontSize = 14;
        activeCursorDes2_text.fontSize = 14;
        activeCursorDes3_text.fontSize = 14;
        activeCursorDes4_text.fontSize = 13;
        activeCursorDes4_2_text.fontSize = 12.6f;

        // Auto Clicker Descriptions
        autoClickerDes1_text.text = "Auto clicker performs <color=green>1<color=white> click per second";
        autoClickerDes1_2_text.text = "Each click deals <color=green>100% <color=white>of your total active damage";
        autoClickerDes2_text.text = "Auto clicker performs <color=green>2<color=white> click per second";
        autoClickerDes3_text.text = "Auto clicker performs <color=green>4<color=white> click per second";
        autoClickerDes4_text.text = "Auto clicker performs <color=green>8<color=white> click per second";

        autoClickerDes1_text.font = MontserratSemiBold;
        autoClickerDes1_2_text.font = MontserratSemiBold;
        autoClickerDes2_text.font = MontserratSemiBold;
        autoClickerDes3_text.font = MontserratSemiBold;
        autoClickerDes4_text.font = MontserratSemiBold;

        autoClickerDes1_text.fontSize = 14;
        autoClickerDes1_2_text.fontSize = 14;
        autoClickerDes2_text.fontSize = 14;
        autoClickerDes3_text.fontSize = 14;
        autoClickerDes4_text.fontSize = 14;

        // Passive Descriptions
        passiveDes1_text.text = "<color=green>+25%<color=white> Passive damage";
        passiveDes2_text.text = "<color=green>+115%<color=white> Passive damage";
        passiveDes3_text.text = "<color=green>+400%<color=white> Passive damage";
        passiveDes3_2_text.text = "Spawns <color=yellow>1 gold coin<color=white> for every <color=green>7<color=white> chests opened";
        passiveDes4_text.text = "<color=green>+850%<color=white> Passive damage";
        passiveDes4_2_text.text = "Spawns 1 treasure for every <color=green>25<color=white> chests opened";
        passiveDes5_text.text = "<color=green>+1100%<color=white> Passive damage";
        passiveDes6_text.text = "<color=green>+1600%<color=white> Passive damage";
        passiveDes6_2_text.text = "Spawns 1 treasure and <color=yellow>4 gold coins<color=white> for every <color=green>25 <color=white>chests opened";
        passiveDes7_text.text = "<color=green>+3500%<color=white> Passive damage";
        passiveDes7_2_text.text = "Every chest drops <color=yellow>1 extra gold coin";
        passiveDes8_text.text = "<color=green>+6500%<color=white> Passive damage";

        passiveDes1_text.font = MontserratSemiBold;
        passiveDes2_text.font = MontserratSemiBold;
        passiveDes3_text.font = MontserratSemiBold;
        passiveDes3_2_text.font = MontserratSemiBold;
        passiveDes4_text.font = MontserratSemiBold;
        passiveDes4_2_text.font = MontserratSemiBold;
        passiveDes5_text.font = MontserratSemiBold;
        passiveDes6_text.font = MontserratSemiBold;
        passiveDes6_2_text.font = MontserratSemiBold;
        passiveDes7_text.font = MontserratSemiBold;
        passiveDes7_2_text.font = MontserratSemiBold;
        passiveDes8_text.font = MontserratSemiBold;

        passiveDes1_text.fontSize = 15;
        passiveDes2_text.fontSize = 15;
        passiveDes3_text.fontSize = 15;
        passiveDes3_2_text.fontSize = 15;
        passiveDes4_text.fontSize = 15;
        passiveDes4_2_text.fontSize = 15;
        passiveDes5_text.fontSize = 15;
        passiveDes6_text.fontSize = 15;
        passiveDes6_2_text.fontSize = 15;
        passiveDes7_text.fontSize = 15;
        passiveDes7_2_text.fontSize = 15;
        passiveDes8_text.fontSize = 15;

        // Passive Cursor Descriptions
        passiveCursorDes1_text.text = "Leveling up cursors with passive damage makes them stronger";
        passiveCursorDes2_text.text = "Leveling up cursors with passive damage makes them stronger";
        passiveCursorDes3_text.text = "Passive damage cursors start out stronger";
        passiveCursorDes4_text.text = "Passive damage cursors start out stronger";
        passiveCursorDes4_2_text.text = "Leveling up cursors with passive damage makes them stronger";
        passiveCursorDes5_text.text = "Passive damage cursors start out stronger";
        passiveCursorDes5_2_text.text = "Leveling up cursors with passive damage makes them stronger";

        passiveCursorDes1_text.font = MontserratSemiBold;
        passiveCursorDes2_text.font = MontserratSemiBold;
        passiveCursorDes3_text.font = MontserratSemiBold;
        passiveCursorDes4_text.font = MontserratSemiBold;
        passiveCursorDes4_2_text.font = MontserratSemiBold;
        passiveCursorDes5_text.font = MontserratSemiBold;
        passiveCursorDes5_2_text.font = MontserratSemiBold;

        passiveCursorDes1_text.fontSize = 14;
        passiveCursorDes2_text.fontSize = 14;
        passiveCursorDes3_text.fontSize = 13.8f;
        passiveCursorDes4_text.fontSize = 13.8f;
        passiveCursorDes4_2_text.fontSize = 14;
        passiveCursorDes5_text.fontSize = 13.8f;
        passiveCursorDes5_2_text.fontSize = 14;

        // Gold Descriptions
        goldDes1_text.text = "Gold coins give <color=yellow>+30% more gold";
        goldDes2_text.text = "Gold coins give <color=yellow>+120% more gold";
        goldDes3_text.text = "Gold coins give <color=yellow>+500% more gold";
        goldDes4_text.text = "Gold coins give <color=yellow>+1000% more gold";
        goldDes4_2_text.text = "Gold coins have a <color=green>3%<color=white> chance to be worth <color=yellow>2X gold";
        goldDes5_text.text = "Chests have a <color=green>3%<color=white> chance to drop a gold coin worth <color=yellow>5X gold.";
        goldDes6_text.text = "Gold coins give <color=yellow>+2000% more gold";
        goldDes7_text.text = "Chests have a <color=green>2%<color=white> chance to drop a gold coin worth <color=yellow>10X gold.";
        goldDes7_2_text.text = "Gold coins give <color=yellow>+1250% more gold";
        goldDes8_text.text = "Chests have a <color=green>1%<color=white> chance to drop a gold coin worth <color=yellow>25X gold.";
        goldDes8_2_text.text = "Gold coins give <color=yellow>+4000% more gold";
        goldDes9_text.text = "Only<color=yellow> 5X, 10X and 25X gold coins<color=white> will drop from chests.";
        goldDes9_2_text.text = "Gold coins give <color=yellow>+5000% more gold";

        goldDes1_text.font = MontserratSemiBold;
        goldDes2_text.font = MontserratSemiBold;
        goldDes3_text.font = MontserratSemiBold;
        goldDes4_text.font = MontserratSemiBold;
        goldDes4_2_text.font = MontserratSemiBold;
        goldDes5_text.font = MontserratSemiBold;
        goldDes6_text.font = MontserratSemiBold;
        goldDes7_text.font = MontserratSemiBold;
        goldDes7_2_text.font = MontserratSemiBold;
        goldDes8_text.font = MontserratSemiBold;
        goldDes8_2_text.font = MontserratSemiBold;
        goldDes9_text.font = MontserratSemiBold;
        goldDes9_2_text.font = MontserratSemiBold;

        goldDes1_text.fontSize = 14;
        goldDes2_text.fontSize = 14;
        goldDes3_text.fontSize = 14;
        goldDes4_text.fontSize = 14;
        goldDes4_2_text.fontSize = 14;
        goldDes5_text.fontSize = 14;
        goldDes6_text.fontSize = 14;
        goldDes7_text.fontSize = 14;
        goldDes7_2_text.fontSize = 14;
        goldDes8_text.fontSize = 14;
        goldDes8_2_text.fontSize = 14;
        goldDes9_text.fontSize = 14;
        goldDes9_2_text.fontSize = 14;

        // Treasure Descriptions
        treasureDes1_text.text = "<color=green>+0.1% <color=white>Treasure drop chance";
        treasureDes2_text.text = "<color=green>+0.2% <color=white>Treasure drop chance";
        treasureDes3_text.text = "<color=green>+8% <color=white>For a treasure to double in value";
        treasureDes4_text.text = "<color=green>+5% <color=white>For a treasure to double in value";
        treasureDes4_2_text.text = "<color=green>+0.2% <color=white>Treasure drop chance";
        treasureDes5_text.text = "<color=green>+10% <color=white>For a treasure to double in value";
        treasureDes5_2_text.text = "<color=green>+0.2% <color=white>Treasure drop chance";
        treasureDes6_text.text = "<color=green>+13% <color=white>For a treasure to double in value";
        treasureDes6_2_text.text = "<color=green>+1% <color=white>Treasure bag drop chance";
        treasureDes7_text.text = "<color=green>+0.4% <color=white>Treasure drop chance";
        treasureDes7_2_text.text = "Sold treasures are now worth 5X more gold.";

        treasureDes1_text.font = MontserratSemiBold;
        treasureDes2_text.font = MontserratSemiBold;
        treasureDes3_text.font = MontserratSemiBold;
        treasureDes4_text.font = MontserratSemiBold;
        treasureDes4_2_text.font = MontserratSemiBold;
        treasureDes5_text.font = MontserratSemiBold;
        treasureDes5_2_text.font = MontserratSemiBold;
        treasureDes6_text.font = MontserratSemiBold;
        treasureDes6_2_text.font = MontserratSemiBold;
        treasureDes7_text.font = MontserratSemiBold;
        treasureDes7_2_text.font = MontserratSemiBold;

        treasureDes1_text.fontSize = 14;
        treasureDes2_text.fontSize = 14;
        treasureDes3_text.fontSize = 14;
        treasureDes4_text.fontSize = 14;
        treasureDes4_2_text.fontSize = 14;
        treasureDes5_text.fontSize = 14;
        treasureDes6_text.fontSize = 14;
        treasureDes6_2_text.fontSize = 14;
        treasureDes7_text.fontSize = 14;
        treasureDes7_2_text.fontSize = 14;

        // XP Descriptions
        xpDes1_text.text = "<color=green>+35% <color=white>XP ";
        xpDes2_text.text = "<color=green>+125% <color=white>XP";
        xpDes3_text.text = "<color=green>+400% <color=white>XP";
        xpDes4_text.text = "<color=green>+900% <color=white>XP";
        xpDes5_text.text = "<color=green>+1300% <color=white>XP";
        xpDes6_text.text = "<color=green>+2500% <color=white>XP ";
        xpDes6_2_text.text = "Every XP drop has a <color=green>+0.25%<color=white> chance to give +1 skill point";
        xpDes7_text.text = "<color=green>+4000% <color=white>XP ";
        xpDes7_2_text.text = "Every XP drop has a <color=green>+0.75%<color=white> chance to give +1 skill point";
        xpDes8_text.text = "<color=green>+7500% <color=white>XP ";
        xpDes8_2_text.text = "Every XP drop has a <color=green>+1%<color=white> chance to give +1 skill point";

        xpDes1_text.font = MontserratSemiBold;
        xpDes2_text.font = MontserratSemiBold;
        xpDes3_text.font = MontserratSemiBold;
        xpDes4_text.font = MontserratSemiBold;
        xpDes5_text.font = MontserratSemiBold;
        xpDes6_text.font = MontserratSemiBold;
        xpDes6_2_text.font = MontserratSemiBold;
        xpDes7_text.font = MontserratSemiBold;
        xpDes7_2_text.font = MontserratSemiBold;
        xpDes8_text.font = MontserratSemiBold;
        xpDes8_2_text.font = MontserratSemiBold;

        xpDes1_text.fontSize = 15;
        xpDes2_text.fontSize = 15;
        xpDes3_text.fontSize = 15;
        xpDes4_text.fontSize = 15;
        xpDes5_text.fontSize = 15;
        xpDes6_text.fontSize = 15;
        xpDes6_2_text.fontSize = 15;
        xpDes7_text.fontSize = 15;
        xpDes7_2_text.fontSize = 15;
        xpDes8_text.fontSize = 15;
        xpDes8_2_text.fontSize = 15;

        // Level Special Descriptions
        levelSpecialDes1_text.text = "Leveling up items makes them stronger";
        levelSpecialDes2_text.text = "Leveling up items makes them stronger";
        levelSpecialDes3_text.text = "Leveling up items makes them stronger";
        levelSpecialDes4_text.text = "Leveling up items makes them stronger";
        levelSpecialDes5_text.text = "Leveling up items makes them stronger";

        levelSpecialDes1_text.font = MontserratSemiBold;
        levelSpecialDes2_text.font = MontserratSemiBold;
        levelSpecialDes3_text.font = MontserratSemiBold;
        levelSpecialDes4_text.font = MontserratSemiBold;
        levelSpecialDes5_text.font = MontserratSemiBold;

        levelSpecialDes1_text.fontSize = 14;
        levelSpecialDes2_text.fontSize = 14;
        levelSpecialDes3_text.fontSize = 14;
        levelSpecialDes4_text.fontSize = 14;
        levelSpecialDes5_text.fontSize = 14;

        // Stronger Special Descriptions
        strongerSpecialDes1_text.text = "All items start out stronger";
        strongerSpecialDes2_text.text = "All items start out stronger";
        strongerSpecialDes3_text.text = "Potions can now be stacked <color=green>+1<color=white> times";
        strongerSpecialDes4_text.text = "Items dropped from chests have a <color=green>10%<color=white> chance to double in value";
        strongerSpecialDes5_text.text = "Potions can be stacked <color=green>+1<color=white> times";
        strongerSpecialDes5_2_text.text = "All items start out stronger";
        strongerSpecialDes6_text.text = "You can now stack the Hammer, Golden Touch, Serendipity Scroll and Gauntlet of greed";
        strongerSpecialDes7_text.text = "Serendipity scroll and ancient relic gives stronger buffs";

        strongerSpecialDes1_text.font = MontserratSemiBold;
        strongerSpecialDes2_text.font = MontserratSemiBold;
        strongerSpecialDes3_text.font = MontserratSemiBold;
        strongerSpecialDes4_text.font = MontserratSemiBold;
        strongerSpecialDes5_text.font = MontserratSemiBold;
        strongerSpecialDes5_2_text.font = MontserratSemiBold;
        strongerSpecialDes6_text.font = MontserratSemiBold;
        strongerSpecialDes7_text.font = MontserratSemiBold;

        strongerSpecialDes1_text.fontSize = 14;
        strongerSpecialDes2_text.fontSize = 14;
        strongerSpecialDes3_text.fontSize = 14;
        strongerSpecialDes4_text.fontSize = 14;
        strongerSpecialDes5_text.fontSize = 14;
        strongerSpecialDes5_2_text.fontSize = 14;
        strongerSpecialDes6_text.fontSize = 14;
        strongerSpecialDes7_text.fontSize = 14;

        // Start With Descriptions
        startWithDes1_text.text = "Choose <color=green>1 item<color=white> to start with after each prestige (You can only choose items that you have purchased once)";
        startWithDes2_text.text = "Choose <color=green>2 items<color=white> to start with after each prestige ";
        startWithDes3_text.text = "Choose <color=green>3 items<color=white> to start with after each prestige ";
        startWithDes4_text.text = "Choose <color=green>5 items<color=white> to start with after each prestige ";

        startWithDes1_text.font = MontserratSemiBold;
        startWithDes2_text.font = MontserratSemiBold;
        startWithDes3_text.font = MontserratSemiBold;
        startWithDes4_text.font = MontserratSemiBold;

        startWithDes1_text.fontSize = 13;
        startWithDes2_text.fontSize = 13;
        startWithDes3_text.fontSize = 13;
        startWithDes4_text.fontSize = 13;

        // Reinforced Descriptions
        reinforcedDes1_text.text = "Gold coins dropped from reinforced chests are now worth <color=yellow>17X gold";
        reinforcedDes1_2_text.text = "<color=green>+0.1% <color=white>Reinforced chest chance";
        reinforcedDes2_text.text = "Gold coins dropped from reinforced chests are now worth <color=yellow>24X gold";
        reinforcedDes2_2_text.text = "Reinforced chests now have <color=red>9X health";
        reinforcedDes2_3_text.text = "Reinforced chests now give <color=orange>6X XP";
        reinforcedDes3_text.text = "Gold coins dropped from reinforced chests are now worth <color=yellow>33X gold";
        reinforcedDes3_2_text.text = "<color=green>+0.3% <color=white>Reinforced chest chance";
        reinforcedDes4_text.text = "Gold coins dropped from reinforced chests are now worth <color=yellow>47X gold";
        reinforcedDes4_2_text.text = "<color=green>+0.5% <color=white>Reinforced chest chance";
        reinforcedDes4_3_text.text = "Reinforced chests now have <color=red>8X health";
        reinforcedDes4_4_text.text = "Reinforced chests now give <color=orange>11X XP";
        reinforcedDes5_text.text = "Gold coins dropped from reinforced chests are now worth <color=yellow>85X gold";
        reinforcedDes5_2_text.text = "<color=green>+1% <color=white>Reinforced chest chance";

        reinforcedDes1_text.font = MontserratSemiBold;
        reinforcedDes1_2_text.font = MontserratSemiBold;
        reinforcedDes2_text.font = MontserratSemiBold;
        reinforcedDes2_2_text.font = MontserratSemiBold;
        reinforcedDes2_3_text.font = MontserratSemiBold;
        reinforcedDes3_text.font = MontserratSemiBold;
        reinforcedDes3_2_text.font = MontserratSemiBold;
        reinforcedDes4_text.font = MontserratSemiBold;
        reinforcedDes4_2_text.font = MontserratSemiBold;
        reinforcedDes4_3_text.font = MontserratSemiBold;
        reinforcedDes4_4_text.font = MontserratSemiBold;
        reinforcedDes5_text.font = MontserratSemiBold;
        reinforcedDes5_2_text.font = MontserratSemiBold;

        reinforcedDes1_text.fontSize = 13;
        reinforcedDes1_2_text.fontSize = 13;
        reinforcedDes2_text.fontSize = 13;
        reinforcedDes2_2_text.fontSize = 13;
        reinforcedDes2_3_text.fontSize = 13;
        reinforcedDes3_text.fontSize = 13;
        reinforcedDes3_2_text.fontSize = 13;
        reinforcedDes4_text.fontSize = 13;
        reinforcedDes4_2_text.fontSize = 13;
        reinforcedDes4_3_text.fontSize = 13;
        reinforcedDes4_4_text.fontSize = 13;
        reinforcedDes5_text.fontSize = 13;
        reinforcedDes5_2_text.fontSize = 13;

        // More Loot Descriptions
        moreLootDes1_text.text = "Every 10 chests opened drops <color=yellow>1 extra gold coin";
        moreLootDes2_text.text = "Every 19 chests opened drops a <color=yellow>5X gold coin <color=white> and gives <color=orange>3X XP";
        moreLootDes3_text.text = "Every 18 chests opened drops <color=yellow>2-4 Gold coins<color=white>, all which are<color=yellow> 5X or 10X gold coins. <color=white> Also gives <color=orange>5X XP";
        moreLootDes4_text.text = "Every 30 chests opened drops <color=yellow>3 gold coins, all which are 25X gold coins <color=white>and drops<color=green> 2-5 treasures";
        moreLootDes5_text.text = "Every chest opened drops a <color=yellow>5X gold coin <color=white>and has a<color=green> 5% <color=white>chance to drop a <color=yellow>10X <color=white>gold coin and a <color=green>2.5%<color=white> chance to drop a <color=yellow>25X gold coin. <color=white> Also drops <color=orange>2X XP";

        moreLootDes1_text.font = MontserratSemiBold;
        moreLootDes2_text.font = MontserratSemiBold;
        moreLootDes3_text.font = MontserratSemiBold;
        moreLootDes4_text.font = MontserratSemiBold;
        moreLootDes5_text.font = MontserratSemiBold;

        moreLootDes1_text.fontSize = 13;
        moreLootDes2_text.fontSize = 13;
        moreLootDes3_text.fontSize = 13;
        moreLootDes4_text.fontSize = 13;
        moreLootDes5_text.fontSize = 13;

        // New Chests Descriptions
        newChestsDes1_text.text = "An enchanted golden chest<color=white> has a<color=green> 0.2% <color=white>chance to appear";
        newChestsDes1_2_text.text = "Enchanted golden chests<color=white> have <color=red>30X health<color=white>. 20 treasures wil drop. <color=white>Lock picks and keys only removes 33% of the chest health.";
        newChestsDes1_3_text.text = "Read more about this chest once it appears or in settings.";
        newChestsDes2_text.text = "A BOSS CHEST<color=white> has a<color=green> 0.1% <color=white>chance to appear";
        newChestsDes2_2_text.text = "BOSS CHESTS have <color=red>100X health. <color=white>\nBoss chests will drop<color=yellow> 25 gold coins<color=white>, all which are <color=yellow> 10X and 25X gold coins.";
        newChestsDes2_3_text.text = "Read more about boss chests once it appears or in the settings.";
        newChestsDes3_text.text = "BOSS CHEST have a <color=green>+0.05% <color=white>chance to appear";
        newChestsDes3_2_text.text = "ENCHANTED GOLDEN CHESTS have a <color=green>+0.1% <color=white>chance to appear";
        newChestsDes4_text.text = "BOSS CHEST have a <color=green>+0.1% <color=white>chance to appear";
        newChestsDes4_2_text.text = "ENCHANTED GOLDEN CHESTS have a <color=green>+0.15% <color=white>chance to appear";
        newChestsDes4_3_text.text = "Enchanted golden chest drop 25 treasures\nBoss chest drop <color=yellow> 30 gold coins";
        newChestsDes5_text.text = "Enchanted golden chests drops 30 treasures.\nBoss Chests drops <color=yellow> 35 gold coins<color=white>, all which are <color=yellow> 25X gold coins";
        newChestsDes5_2_text.text = "ENCHANTED GOLDEN CHESTS have a <color=green>+0.2% <color=white>chance to appear";
        newChestsDes5_3_text.text = "BOSS CHEST have a <color=green>+0.15% <color=white>chance to appear";
        newChestsDes6_text.text = "BOSS CHEST have a <color=green>+0.4% <color=white>chance to appear";
        newChestsDes6_2_text.text = "ENCHANTED GOLDEN CHESTS have a <color=green>+0.75% <color=white>chance to appear";
        newChestsDes6_3_text.text = "Boss chest drop <color=orange>20X XP<color=white>. Enchanted golden chests drop <color=orange>12X XP<color=white>. Both chests get a slightly higher chance to drop rare treasures.";

        newChestsDes1_text.font = MontserratSemiBold;
        newChestsDes1_2_text.font = MontserratSemiBold;
        newChestsDes1_3_text.font = MontserratSemiBold;
        newChestsDes2_text.font = MontserratSemiBold;
        newChestsDes2_2_text.font = MontserratSemiBold;
        newChestsDes2_3_text.font = MontserratSemiBold;
        newChestsDes3_text.font = MontserratSemiBold;
        newChestsDes3_2_text.font = MontserratSemiBold;
        newChestsDes4_text.font = MontserratSemiBold;
        newChestsDes4_2_text.font = MontserratSemiBold;
        newChestsDes4_3_text.font = MontserratSemiBold;
        newChestsDes5_text.font = MontserratSemiBold;
        newChestsDes5_2_text.font = MontserratSemiBold;
        newChestsDes5_3_text.font = MontserratSemiBold;
        newChestsDes6_text.font = MontserratSemiBold;
        newChestsDes6_2_text.font = MontserratSemiBold;
        newChestsDes6_3_text.font = MontserratSemiBold;

        newChestsDes1_text.fontSize = 12;
        newChestsDes1_2_text.fontSize = 12;
        newChestsDes1_3_text.fontSize = 9.5f;
        newChestsDes2_text.fontSize = 13;
        newChestsDes2_2_text.fontSize = 13;
        newChestsDes2_3_text.fontSize = 9.5f;
        newChestsDes3_text.fontSize = 12;
        newChestsDes3_2_text.fontSize = 12;
        newChestsDes4_text.fontSize = 12;
        newChestsDes4_2_text.fontSize = 12;
        newChestsDes4_3_text.fontSize = 12;
        newChestsDes5_text.fontSize = 12;
        newChestsDes5_2_text.fontSize = 12;
        newChestsDes5_3_text.fontSize = 12;
        newChestsDes6_text.fontSize = 12;
        newChestsDes6_2_text.fontSize = 12;
        newChestsDes6_3_text.fontSize = 12;

        #endregion

        #region Other
        maxPurchaseText_text.text = "PURCHASING MAX"; maxPurchaseText_text.font = ChangaBoldSDF1; maxPurchaseText_text.fontSize = 32;
        if(PlaceMobileButtons.isMobile == false) { youCanAlsoHoldDown_text.text = "You can also hold down LEFT CONTROL to purchase MAX"; youCanAlsoHoldDown_text.font = MontserratBold; }
        else { youCanAlsoHoldDown_text.text = ""; youCanAlsoHoldDown_text.font = MontserratBold; }
      youCanAlsoHoldDown_text.fontSize = 12;

        X1_text1.text = "X1"; X1_text1.font = AlataRegular; X1_text1.fontSize = 35;
        X1_text2.text = "X1"; X1_text2.font = AlataRegular; X1_text2.fontSize = 32;
        X1_text3.text = "X1"; X1_text3.font = AlataRegular; X1_text3.fontSize = 32;
        MAX_text1.text = "MAX"; MAX_text1.font = AlataRegular; MAX_text1.fontSize = 35;
        MAX_text2.text = "MAX"; MAX_text2.font = AlataRegular; MAX_text2.fontSize = 32;
        MAX_text3.text = "MAX"; MAX_text3.font = AlataRegular; MAX_text3.fontSize = 32;

        activeDamageBar_text.text = "ACTIVE DAMAGE"; activeDamageBar_text.font = ChangaBoldSDF; activeDamageBar_text.fontSize = 36;
        activeDamageACTIVE_text.text = "ACTIVE"; activeDamageACTIVE_text.font = MontserratMediumSDF1; activeDamageACTIVE_text.fontSize = 21;
        activeDamageLEVEL_text.text = "LEVEL"; activeDamageLEVEL_text.font = ChangaBoldSDF; activeDamageLEVEL_text.fontSize = 27;

        passiveDamageBar_text.text = "PASSIVE  DAMAGE"; passiveDamageBar_text.font = ChangaBoldSDF; passiveDamageBar_text.fontSize = 36;
        passivePASSIVE_Text.text = "PASSIVE"; passivePASSIVE_Text.font = MontserratMediumSDF1; passivePASSIVE_Text.fontSize = 20;
        passiveLEVEL_text.text = "LEVEL"; passiveLEVEL_text.font = ChangaBoldSDF; passiveLEVEL_text.fontSize = 27;

        welcome.text = "WELCOME!"; welcome.font = ChangaBoldSDF1; welcome.fontSize = 21;
        beforeWeCanStartPlaying.text = "Before we can start playing. How much loot do you want to have on screen before the loot starts collecting on it's own?"; beforeWeCanStartPlaying.font = MontserratMediumSDF1; beforeWeCanStartPlaying.fontSize = 11.4f;
        changeAnyTime.text = "YOU CAN CHANGE THIS IN SETTINGS AT ANY TIME"; changeAnyTime.font = MontserratMediumSDF1; changeAnyTime.fontSize = 10;
        playGame.text = "PLAY"; playGame.font = MontserratMediumSDF1; playGame.fontSize = 65;

        if(PlaceMobileButtons.isMobile == false) 
        {
            welcomeBack.text = "WELCOME BACK!"; welcomeBack.font = ChangaBoldSDF1; welcomeBack.fontSize = 65;
            thisHappendWhileGone.text = "This happened while you were gone..."; thisHappendWhileGone.font = MontserratMediumSDF1; thisHappendWhileGone.fontSize = 27;
        }
        else
        {
            welcomeBack.text = "WELCOME\nBACK!"; welcomeBack.font = ChangaBoldSDF1; welcomeBack.fontSize = 55;
            thisHappendWhileGone.text = "This happened while you were gone..."; thisHappendWhileGone.font = MontserratMediumSDF1; thisHappendWhileGone.fontSize = 24;
        }
     
    
        cool.text = "Cool!"; cool.font = ChangaBoldSDF1; cool.fontSize = 42;
        timeGone.text = "Time Gone:"; timeGone.font = ChangaBoldSDF1; timeGone.fontSize = 55;

        #endregion

        //Text That Changes
        #region info settings
        enchantedGoldenChestHealth = "-Enchanted golden chest have <color=red>" + UpdateGame.enchantedGoldenChestHealth + "X health";
        enchantedGoldenChestTreasureDrops = "-" + UpdateGame.enchantedGoldenChestTreasureDrops + " Treasure drops";
        enchantedGoldenChestXPDrop = "-<color=orange>+" + UpdateGame.enchantedGoldenChestXPDrops + "X XP Drop";

        bossChestHealth = "-Boss chests have <color=red>" + UpdateGame.bossChestHealth + "X health";
        bossChestGoldValue = "-Gold coin value = <color=yellow>" + UpdateGame.bossChestGoldValue + "X gold";
        bossChestGoldCoins = "-<color=yellow>" + UpdateGame.bossChestGoldCoinsDrops + " Gold coins<color=white> will drop, all which are <color=yellow>10X and 25X gold coins.";
        bossChestGoldCoins2 = "-<color=yellow>" + UpdateGame.bossChestGoldCoinsDrops + " Gold coins<color=white> will drop, all which are<color=yellow> 25X gold coins.";
        bossChestXP = "-<color=orange>+" + UpdateGame.bossChestXPDrops + "X XP Drop";

        reinforcedHealth = "-Reinforced chests have <color=red>" + UpdateGame.reinforcedChestHealth + "X health";
        reinforcedGold = "-Gold coins dropped give <color=yellow>" + UpdateGame.reinforcedChestGoldIncrease + "X gold";
        reinforcedXP = "<color=orange>+" + UpdateGame.reinforcedXPIncrease + "X XP <color=white>Drop";

        reinforcedInfo = "Reinforced chests have " + UpdateGame.reinforcedChestHealth + "X health, give " + UpdateGame.reinforcedChestGoldIncrease + "X gold and " + UpdateGame.reinforcedXPIncrease + "X XP.";

        enchantedChestInfo = (100 - UpdateGame.enchantedGoldenChestChance).ToString("F2") + "% Spawn chance. \nEnchanted golden chests have " + UpdateGame.enchantedGoldenChestHealth + "X health, drops " + UpdateGame.enchantedGoldenChestTreasureDrops + " treasures and " + UpdateGame.enchantedGoldenChestXPDrops + "X XP.\n Using a lockpick or key only removes 33% of the chest health. \nEnchanted golden chests also have a slightly higher chance to drop a rare treasure";

        bossChestInfo1 = (UpdateGame.bossChestChance).ToString("F2") + "% Spawn chance.\nBoss chests have " + UpdateGame.bossChestHealth + "X health. Gold coins are worth " + UpdateGame.bossChestGoldValue + "X gold. Boss chests drops " + UpdateGame.bossChestGoldCoinsDrops + " gold coins, all which are 10X or 25X gold coins. (Gold coin value from boss chest = (Current chest gold coin value * 5) * 10 or 25). Also gives " + UpdateGame.bossChestXPDrops + "X XP.\nUsing a lock pick or key only removes 25% of the chest health. \nBoss chest also have a slightly higher chance to drop a rare treasure.";

        bossChestInfo2 = (UpdateGame.bossChestChance).ToString("F2") + "% Spawn chance.\nBoss chests have " + UpdateGame.bossChestHealth + "X health. Gold coins are worth " + UpdateGame.bossChestGoldValue + "X gold. Boss chests drops " + UpdateGame.bossChestGoldCoinsDrops + " gold coins, all which are 25X gold coins. (Gold coin value from boss chest = (Current chest gold coin value * 5) * 25). Also gives " + UpdateGame.bossChestXPDrops + "X XP.\nUsing a lock pick or key only removes 25% of the chest health. \nBoss chest also have a slightly higher chance to drop a rare treasure.";

        purchaseTheEnchanted = "Purchase the \"enchanted golden chest\" prestige upgrade to view info";
        purchaseTheBossChest = "Purchase the \"boss chest\" prestige upgrade to view info";

        reinforcedChestsDescription_text2.font = AlataRegular; reinforcedChestsDescription_text2.fontSize = 12;

        enchantedGoldenChestsDescription_text.font = AlataRegular; enchantedGoldenChestsDescription_text.fontSize = 10;

        bossChestsDescription_text.font = AlataRegular; bossChestsDescription_text.fontSize = 10;
        #endregion

        #region stats

        goldCoinsDropped = "Gold coins dropped: ";
        totalGoldReceived = "Total gold received: ";
        totalBarrelGold = "Total barrel gold: ";
        treasuresDropped = "Treasures dropped: ";
        commonTreasures = "Common treasures: ";
        uncommonTreasures = "Uncommon treasures: ";
        rareTreasures = "Rare treasures: ";
        veryRareTreasures = "Very Rare treasures: ";
        extremelyRareTreasures = "Extremely Rare treasures: ";
        legendaryTreasures = "Legendary treasures: ";
        ultraTreasures = "Ultra treasures: ";
        mythicTreasures = "Mythic treasures: ";
        eternalTreasures = "Eternal treasures: ";
        treasuresDoubled = "Treasures doubled: ";
        chestsOpened = "Chests opened: ";
        reinforcedChestsOpened = "Reinforced chests opened: ";
        enchantedGoldenChestsOpened = "Enchanted golden chests opened: ";
        bossChestsOpened = "Boss chests opened: ";
        chestClicks = "Chest clicks: ";
        autoClicks = "Auto clicks: ";
        criticalHits = "Critical hits: ";
        activeDamage = "Active damage: ";
        passiveDamage = "Passive damage: ";
        critChance = "Crit chance: ";
        critDamage = "Crit damage: ";
        cursorsLeveledUp = "Cursors leveled up: ";
        coinsSpawnedFromClicks = "Coins spawned from clicks: ";
        treasuresSpawnedFromClicks = "Treasures spawned from clicks: ";
        itemsUsed = "Items used: ";
        itemsDropped = "Items dropped: ";
        itemsPurchased = "Items purchased: ";
        itemsLeveledUp = "Items leveled up: ";
        prestigeCount = "Prestige count: ";
        prestigeUpgradesPurchased = "Prestige upgrades purchased: ";
        skillPointsReceived = "Skill points received: ";
        goldIncrease = "Gold increase: ";
        xpIncrease = "XP increase: ";
        activeDamageIncrease = "Active damage increase: ";
        passiveDamageIncrease = "Passive damage increase: ";
        critChanceIncrease = "Crit chance increase: ";
        critDamageIncrease = "Crit damage increase: ";
        treasureChanceIncrease = "Treasure chance increase: ";
        goldCoins5xDropped = "5X Gold coins dropped:  ";
        goldCoins10xDropped = "10X Gold coins dropped: ";
        goldCoins25xDropped = "25X Gold coins dropped: ";
        goldCoins100xDropped = "100X Gold coins dropped: ";

        goldCoinsDropped_text.font = MontserratMediumSDF1; goldCoinsDropped_text.fontSize = 27;
        totalGoldReceived_text.font = MontserratMediumSDF1; totalGoldReceived_text.fontSize = 27;
        totalBarrelGold_text.font = MontserratMediumSDF1; totalBarrelGold_text.fontSize = 27;
        treasuresDropped_text.font = MontserratMediumSDF1; treasuresDropped_text.fontSize = 27;
        commonTreasures_text.font = MontserratMediumSDF1; commonTreasures_text.fontSize = 27;
        uncommonTreasures_text.font = MontserratMediumSDF1; uncommonTreasures_text.fontSize = 27;
        rareTreasures_text.font = MontserratMediumSDF1; rareTreasures_text.fontSize = 27;
        veryRareTreasures_text.font = MontserratMediumSDF1; veryRareTreasures_text.fontSize = 27;
        extremelyRareTreasures_text.font = MontserratMediumSDF1; extremelyRareTreasures_text.fontSize = 27;
        legendaryTreasures_text.font = MontserratMediumSDF1; legendaryTreasures_text.fontSize = 27;
        ultraTreasures_text.font = MontserratMediumSDF1; ultraTreasures_text.fontSize = 27;
        mythicTreasures_text.font = MontserratMediumSDF1; mythicTreasures_text.fontSize = 27;
        eternalTreasures_text.font = MontserratMediumSDF1; eternalTreasures_text.fontSize = 27;
        treasuresDoubled_text.font = MontserratMediumSDF1; treasuresDoubled_text.fontSize = 27;
        chestsOpened_text.font = MontserratMediumSDF1; chestsOpened_text.fontSize = 27;
        reinforcedChestsOpened_text.font = MontserratMediumSDF1; reinforcedChestsOpened_text.fontSize = 25;
        enchantedGoldenChestsOpened_text.font = MontserratMediumSDF1; enchantedGoldenChestsOpened_text.fontSize = 27f;
        bossChestsOpened_text.font = MontserratMediumSDF1; bossChestsOpened_text.fontSize = 27;
        chestClicks_text.font = MontserratMediumSDF1; chestClicks_text.fontSize = 27;
        autoClicks_text.font = MontserratMediumSDF1; autoClicks_text.fontSize = 27;
        criticalHits_text.font = MontserratMediumSDF1; criticalHits_text.fontSize = 27;
        activeDamage_text.font = MontserratMediumSDF1; activeDamage_text.fontSize = 27;
        passiveDamage_text.font = MontserratMediumSDF1; passiveDamage_text.fontSize = 27;
        critChance_text.font = MontserratMediumSDF1; critChance_text.fontSize = 27;
        critDamage_text.font = MontserratMediumSDF1; critDamage_text.fontSize = 27;
        cursorsLeveledUp_text.font = MontserratMediumSDF1; cursorsLeveledUp_text.fontSize = 27;
        coinsSpawnedFromClicks_text.font = MontserratMediumSDF1; coinsSpawnedFromClicks_text.fontSize = 26;
        treasuresSpawnedFromClicks_text.font = MontserratMediumSDF1; treasuresSpawnedFromClicks_text.fontSize = 23.8f;
        itemsUsed_text.font = MontserratMediumSDF1; itemsUsed_text.fontSize = 27;
        itemsDropped_text.font = MontserratMediumSDF1; itemsDropped_text.fontSize = 27;
        itemsPurchased_text.font = MontserratMediumSDF1; itemsPurchased_text.fontSize = 27;
        itemsLeveledUp_text.font = MontserratMediumSDF1; itemsLeveledUp_text.fontSize = 27;
        prestigeCount_text.font = MontserratMediumSDF1; prestigeCount_text.fontSize = 27;
        prestigeUpgradesPurchased_text.font = MontserratMediumSDF1; prestigeUpgradesPurchased_text.fontSize = 27;
        skillPointsReceived_text.font = MontserratMediumSDF1; skillPointsReceived_text.fontSize = 27;
        goldIncrease_text.font = MontserratMediumSDF1; goldIncrease_text.fontSize = 27;
        xpIncrease_text.font = MontserratMediumSDF1; xpIncrease_text.fontSize = 27;
        activeDamageIncrease_text.font = MontserratMediumSDF1; activeDamageIncrease_text.fontSize = 27;
        passiveDamageIncrease_text.font = MontserratMediumSDF1; passiveDamageIncrease_text.fontSize = 27;
        critChanceIncrease_text.font = MontserratMediumSDF1; critChanceIncrease_text.fontSize = 27;
        critDamageIncrease_text.font = MontserratMediumSDF1; critDamageIncrease_text.fontSize = 27;
        treasureChanceIncrease_text.font = MontserratMediumSDF1; treasureChanceIncrease_text.fontSize = 27;
        goldCoins5xDropped_text.font = MontserratMediumSDF1; goldCoins5xDropped_text.fontSize = 27;
        goldCoins10xDropped_text.font = MontserratMediumSDF1; goldCoins10xDropped_text.fontSize = 27;
        goldCoins25xDropped_text.font = MontserratMediumSDF1; goldCoins25xDropped_text.fontSize = 27;
        goldCoins100xDropped_text.font = MontserratMediumSDF1; goldCoins100xDropped_text.fontSize = 27;
        #endregion

        #region cursors
        NOdot = "NO.";

        upgrade = "UPGRADE";
        upgradeMax = "UPGRADE (MAX)";

        lvl = "Lvl ";

        price = "PRICE: ";
        damage = "DAMAGE: ";

        equipped = "Equipped";
        unequpped = "Unequipped";

        equippedNONE = "Equipped = <color=red>NONE";

       

        cursor1Equipped = "Equipped = <color=green>GENTLE TAP";
        cursor2Equipped = "Equipped = <color=green>RELAXED PALM";
        cursor3Equipped = "Equipped = <color=green>GALE FORCE";
        cursor4Equipped = "Equipped = <color=green>RADIANT TOUCH";
        cursor5Equipped = "Equipped = <color=green>ENERGY SURGE";
        cursor6Equipped = "Equipped = <color=green>PHANTOM PALM";
        cursor7Equipped = "Equipped = <color=green>STEEL STRIKE";
        cursor8Equipped = "Equipped = <color=green>LETHAL TOUCH";
        cursor9Equipped = "Equipped = <color=green>PRECISION POINT";
        cursor10Equipped = "Equipped = <color=green>VORTEX TAP";
        cursor11Equipped = "Equipped = <color=green>CURSED CLAW";
        cursor12Equipped = "Equipped = <color=green>SNIPER CLICK";
        cursor13Equipped = "Equipped = <color=green>SHADOW SURGE";
        cursor14Equipped = "Equipped = <color=green>CRIPPLING CRUSH";
        cursor15Equipped = "Equipped = <color=green>RAPID CLICK";
        cursor16Equipped = "Equipped = <color=green>CELESTIAL TOUCH";
        cursor17Equipped = "Equipped = <color=green>ARCANE CLICK";
        cursor18Equipped = "Equipped = <color=green>ETERNAL TOUCH";
        cursor19Equipped = "Equipped = <color=green>DOOM TOUCH";
        cursor20Equipped = "Equipped = <color=green>SOLAR SWEEP";
        cursor21Equipped = "Equipped = <color=green>INFERNO FIST";

       

        for (int i = 0; i < 21; i++)
        {
            lvlsHover_text[i].font = changaMedium; lvlsHover_text[i].fontSize = 32;

            equippedHover_text[i].font = changaMedium; equippedHover_text[i].fontSize = 28;
            level_text[i].font = changaMedium; level_text[i].fontSize = 39;
        }

        equippedEquals_text.font = changaMedium; equippedEquals_text.fontSize = 23f;
        dpsTopBar_text.font = changaMedium; dpsTopBar_text.fontSize = 29f;
        clickDamageTopBar_text.font = changaMedium; clickDamageTopBar_text.fontSize = 29f;
        critChanceTopBar_text.font = changaMedium; critChanceTopBar_text.fontSize = 29f;
        critDamageTopBar_text.font = changaMedium; critDamageTopBar_text.fontSize = 29f;

        noNotUnlcoked_text.font = ChangaBoldSDF; noNotUnlcoked_text.fontSize = 70f;

        cursor1ActiveDamage_Text.font = robotoBold; cursor1ActiveDamage_Text.fontSize = 19;

        cursor2PassiveDamage_Text.font = robotoBold; cursor2PassiveDamage_Text.fontSize = 19;

        cursor3CritChance_Text.font = robotoBold; cursor3CritChance_Text.fontSize = 19;
        cursor3CritDamage_Text.font = robotoBold; cursor3CritDamage_Text.fontSize = 19;

        cursor4ActiveDamage_Text.font = robotoBold; cursor4ActiveDamage_Text.fontSize = 19;
        cursor4PassiveDamage_Text.font = robotoBold; cursor4PassiveDamage_Text.fontSize = 19;

        cursor5ActiveDamage_Text.font = robotoBold; cursor5ActiveDamage_Text.fontSize = 19;
        cursor5CritChance_Text.font = robotoBold; cursor5CritChance_Text.fontSize = 19;
        cursor5CritDamage_Text.font = robotoBold; cursor5CritDamage_Text.fontSize = 19;

        cursor6ActiveDamage_Text.font = robotoBold; cursor6ActiveDamage_Text.fontSize = 19;
        cursor6PassiveDamage_Text.font = robotoBold; cursor6PassiveDamage_Text.fontSize = 19;
        cursor6CritChance_Text.font = robotoBold; cursor6CritChance_Text.fontSize = 19;
        cursor6CritDamage_Text.font = robotoBold; cursor6CritDamage_Text.fontSize = 19;

        cursor7ActiveDamage_Text.font = robotoBold; cursor7ActiveDamage_Text.fontSize = 19;
        cursor7CritChance_Text.font = robotoBold; cursor7CritChance_Text.fontSize = 19;
        cursor7CritDamage_Text.font = robotoBold; cursor7CritDamage_Text.fontSize = 19;

        cursor8ActiveDamage_Text.font = robotoBold; cursor8ActiveDamage_Text.fontSize = 19;
        cursor8PassiveDamage_Text.font = robotoBold; cursor8PassiveDamage_Text.fontSize = 19;
        cursor8CritChance_Text.font = robotoBold; cursor8CritChance_Text.fontSize = 19;
        cursor8CritDamage_Text.font = robotoBold; cursor8CritDamage_Text.fontSize = 19;

        cursor9ActiveDamage_Text.font = robotoBold; cursor9ActiveDamage_Text.fontSize = 19;
        cursor9PassiveDamage_Text.font = robotoBold; cursor9PassiveDamage_Text.fontSize = 19;

        cursor10PassiveDamage_Text.font = robotoBold; cursor10PassiveDamage_Text.fontSize = 19;

        cursor11ActiveDamage_Text.font = robotoBold; cursor11ActiveDamage_Text.fontSize = 19;
        cursor11CritChance_Text.font = robotoBold; cursor11CritChance_Text.fontSize = 19;
        cursor11CritDamage_Text.font = robotoBold; cursor11CritDamage_Text.fontSize = 19;

        cursor12ActiveDamage_Text.font = robotoBold; cursor12ActiveDamage_Text.fontSize = 19;
        cursor12PassiveDamage_Text.font = robotoBold; cursor12PassiveDamage_Text.fontSize = 19;
        cursor12CritChance_Text.font = robotoBold; cursor12CritChance_Text.fontSize = 19;
        cursor12CritDamage_Text.font = robotoBold; cursor12CritDamage_Text.fontSize = 19;

        cursor13ActiveDamage_Text.font = robotoBold; cursor13ActiveDamage_Text.fontSize = 19;
        cursor13PassiveDamage_Text.font = robotoBold; cursor13PassiveDamage_Text.fontSize = 19;
        cursor13CritChance_Text.font = robotoBold; cursor13CritChance_Text.fontSize = 19;
        cursor13CritDamage_Text.font = robotoBold; cursor13CritDamage_Text.fontSize = 19;

        cursor14ActiveDamage_Text.font = robotoBold; cursor14ActiveDamage_Text.fontSize = 19;
        cursor14PassiveDamage_Text.font = robotoBold; cursor14PassiveDamage_Text.fontSize = 19;
        cursor14CritChance_Text.font = robotoBold; cursor14CritChance_Text.fontSize = 19;
        cursor14CritDamage_Text.font = robotoBold; cursor14CritDamage_Text.fontSize = 19;

        cursor15ActiveDamage_Text.font = robotoBold; cursor15ActiveDamage_Text.fontSize = 19;
        cursor15PassiveDamage_Text.font = robotoBold; cursor15PassiveDamage_Text.fontSize = 19;
        cursor15CritChance_Text.font = robotoBold; cursor15CritChance_Text.fontSize = 19;
        cursor15CritDamage_Text.font = robotoBold; cursor15CritDamage_Text.fontSize = 19;

        cursor16ActiveDamage_Text.font = robotoBold; cursor16ActiveDamage_Text.fontSize = 19;
        cursor16PassiveDamage_Text.font = robotoBold; cursor16PassiveDamage_Text.fontSize = 19;
        cursor16CritChance_Text.font = robotoBold; cursor16CritChance_Text.fontSize = 19;
        cursor16CritDamage_Text.font = robotoBold; cursor16CritDamage_Text.fontSize = 19;

        cursor17ActiveDamage_Text.font = robotoBold; cursor17ActiveDamage_Text.fontSize = 19;
        cursor17PassiveDamage_Text.font = robotoBold; cursor17PassiveDamage_Text.fontSize = 19;
        cursor17CritChance_Text.font = robotoBold; cursor17CritChance_Text.fontSize = 19;
        cursor17CritDamage_Text.font = robotoBold; cursor17CritDamage_Text.fontSize = 19;

        cursor18ActiveDamage_Text.font = robotoBold; cursor18ActiveDamage_Text.fontSize = 19;
        cursor18PassiveDamage_Text.font = robotoBold; cursor18PassiveDamage_Text.fontSize = 19;
        cursor18CritChance_Text.font = robotoBold; cursor18CritChance_Text.fontSize = 19;
        cursor18CritDamage_Text.font = robotoBold; cursor18CritDamage_Text.fontSize = 19;

        cursor19ActiveDamage_Text.font = robotoBold; cursor19ActiveDamage_Text.fontSize = 18;
        cursor19PassiveDamage_Text.font = robotoBold; cursor19PassiveDamage_Text.fontSize = 18;
        cursor19CritChance_Text.font = robotoBold; cursor19CritChance_Text.fontSize = 18;
        cursor19CritDamage_Text.font = robotoBold; cursor19CritDamage_Text.fontSize = 18;

        cursor20ActiveDamage_Text.font = robotoBold; cursor20ActiveDamage_Text.fontSize = 18f;
        cursor20PassiveDamage_Text.font = robotoBold; cursor20PassiveDamage_Text.fontSize = 18;
        cursor20CritChance_Text.font = robotoBold; cursor20CritChance_Text.fontSize = 18;
        cursor20CritDamage_Text.font = robotoBold; cursor20CritDamage_Text.fontSize = 18;

        cursor21ActiveDamage_Text.font = robotoBold; cursor21ActiveDamage_Text.fontSize = 18f;
        cursor21PassiveDamage_Text.font = robotoBold; cursor21PassiveDamage_Text.fontSize = 18f;
        cursor21CritChance_Text.font = robotoBold; cursor21CritChance_Text.fontSize = 18f;
        cursor21CritDamage_Text.font = robotoBold; cursor21CritDamage_Text.fontSize = 18f;
        #endregion

        #region items and shop

        MAX = "MAX";
        owned = "Owned: ";
        treasuresExplinationMark = "TREASURES!";
        skillPointsExplinatinMark = " SKILL POINTS!";

        stack = "STACK X";

        forTheNext = "For the next ";
        seconds = " seconds";

        for (int i = 0; i < 17; i++)
        {
            itemsPrice_text[i].font = changaMedium; itemsPrice_text[i].fontSize = 20;
            itemsLvlHover_text[i].font = changaMedium; itemsLvlHover_text[i].fontSize = 31;
            itemsPriceHover_text[i].font = robotoBold; itemsPriceHover_text[i].fontSize = 16;
        }

        for (int i = 0; i < 14; i++)
        {
            owned_text[i].font = changaMedium; owned_text[i].fontSize = 22;
        }

        stack_text1.font = MontserratMediumSDF1; stack_text1.fontSize = 25f;
        stack_text2.font = MontserratMediumSDF1; stack_text2.fontSize = 25f;
        stack_text3.font = MontserratMediumSDF1; stack_text3.fontSize = 25f;
        stack_text4.font = MontserratMediumSDF1; stack_text4.fontSize = 25f;
        stack_text5.font = MontserratMediumSDF1; stack_text5.fontSize = 25f;
        stack_text6.font = MontserratMediumSDF1; stack_text6.fontSize = 25f;
        stack_text7.font = MontserratMediumSDF1; stack_text7.fontSize = 25f;
        stack_text8.font = MontserratMediumSDF1; stack_text8.fontSize = 25f;

        lockPickDropChance_text.font = myriadPro; lockPickDropChance_text.fontSize = 19f;
        lockPickInfo.font = robotoBold; lockPickInfo.fontSize = 23f;
        hammerInfo_text.font = robotoBold; hammerInfo_text.fontSize = 21f;
        hammerDropChance_text.font = myriadPro; hammerDropChance_text.fontSize = 19f;
        lootPotionInfo_text.font = robotoBold; lootPotionInfo_text.fontSize = 20f;
        lootPotionDropChance_text.font = myriadPro; lootPotionDropChance_text.fontSize = 19f;
        damagePotionInfo_text.font = robotoBold; damagePotionInfo_text.fontSize = 21f;
        damagePotionDropChance_text.font = myriadPro; damagePotionDropChance_text.fontSize = 19f;
        xpPotionInfo_text.font = robotoBold; xpPotionInfo_text.fontSize = 21f;
        xpPotionDropChance_text.font = myriadPro; xpPotionDropChance_text.fontSize = 19f;
        goldenTouchInfo_text.font = robotoBold; goldenTouchInfo_text.fontSize = 21f;
        goldenTouchDropChance_text.font = myriadPro; goldenTouchDropChance_text.fontSize = 19f;
        miniChestInfo_text.font = robotoBold; miniChestInfo_text.fontSize = 21f;
        keyInfo_text.font = robotoBold; keyInfo_text.fontSize = 17f;
        keyDropChance_text.font = myriadPro; keyDropChance_text.fontSize = 19f;
        treasureBagInfo_text.font = robotoBold; treasureBagInfo_text.fontSize = 19f;
        serendipityScrollInfo_text.font = robotoBold; serendipityScrollInfo_text.fontSize = 19f;
        serendipityScollDropChance_text.font = myriadPro; serendipityScollDropChance_text.fontSize = 19f;
        gauntletOfGreenInfo_text.font = robotoBold; gauntletOfGreenInfo_text.fontSize = 18f;
        gauntletOfGreenDropChance_text.font = myriadPro; gauntletOfGreenDropChance_text.fontSize = 19f;
        magicalElixirInfo.font = robotoBold; magicalElixirInfo.fontSize = 18f;
        magicalElixirDropChance_text.font = myriadPro; magicalElixirDropChance_text.fontSize = 19f;
        ancientRelicDropChance_text.font = myriadPro; ancientRelicDropChance_text.fontSize = 19f;
        enchantedHammerInfo_text.font = robotoBold; enchantedHammerInfo_text.fontSize = 18f;
        enchantedHammerDropChance_text.font = myriadPro; enchantedHammerDropChance_text.fontSize = 19f;
        treasurePotionInfo_text.font = robotoBold; treasurePotionInfo_text.fontSize = 18f;
        treasurePotionDropChance_text.font = myriadPro; treasurePotionDropChance_text.fontSize = 19f;
        barrelOfGoldTotalGold_text.font = ChangaBoldSDF1; barrelOfGoldTotalGold_text.fontSize = 13f;
        mimicChestSpawns_text.font = robotoBold; mimicChestSpawns_text.fontSize = 17f;
        mimicChestChanceForBuff_text.font = robotoBold; mimicChestChanceForBuff_text.fontSize = 15.4f;
        barrelOfGoldInfo_text.font = robotoBold; barrelOfGoldInfo_text.fontSize = 17f;

        //Item and mimic chest buffs
        goldBuffText_text.font = ChangaBoldSDF1; goldBuffText_text.fontSize = 14;
        lootPotionBuff_text.font = ChangaBoldSDF1; lootPotionBuff_text.fontSize = 14;
        damagePotionBuff_text.font = ChangaBoldSDF1; damagePotionBuff_text.fontSize = 12;
        damageBuff_text.font = ChangaBoldSDF1; damageBuff_text.fontSize = 12;
        treasureBuff_text.font = ChangaBoldSDF1; treasureBuff_text.fontSize = 11; treasureBuff_text.lineSpacing = -90;
        xpBuff_text.font = ChangaBoldSDF1; xpBuff_text.fontSize = 13;
        xpPotionBuff.font = ChangaBoldSDF1; xpPotionBuff.fontSize = 13;
        elixirGoldBuff_text.font = ChangaBoldSDF1; elixirGoldBuff_text.fontSize = 11;
        elixirXPBuff_text.font = ChangaBoldSDF1; elixirXPBuff_text.fontSize = 11;
        elixirDamageBuff_text.font = ChangaBoldSDF1; elixirDamageBuff_text.fontSize = 11;
        goldCoinsDropBuff_text.font = ChangaBoldSDF1; goldCoinsDropBuff_text.fontSize = 11;
        goldenTouchBuff.font = ChangaBoldSDF1; goldenTouchBuff.fontSize = 10;

        negativeGold_text.font = ChangaBoldSDF1; negativeGold_text.fontSize = 14;
        negativeDamage_text.font = ChangaBoldSDF1; negativeDamage_text.fontSize = 12;
        negativeTreasure_text.font = ChangaBoldSDF1; negativeTreasure_text.fontSize = 11;
        negativeXP_text.font = ChangaBoldSDF1; negativeXP_text.fontSize = 13;
        negativeGoldCoinsDrop_text.font = ChangaBoldSDF1; negativeGoldCoinsDrop_text.fontSize = 11.4f;

        goldBuffTimer_text.font = ChangaBoldSDF1; goldBuffTimer_text.fontSize = 10;
        lootPotionBuffTimer_text.font = ChangaBoldSDF1; lootPotionBuffTimer_text.fontSize = 10;
        damageBuffTimer_text.font = ChangaBoldSDF1; damageBuffTimer_text.fontSize = 10;
        damagePotionTimer_text.font = ChangaBoldSDF1; damagePotionTimer_text.fontSize = 10;
        treasureBuffTimer_text.font = ChangaBoldSDF1; treasureBuffTimer_text.fontSize = 10;
        xpBuffTimer_text.font = ChangaBoldSDF1; xpBuffTimer_text.fontSize = 10;
        XpPotionTimer_text.font = ChangaBoldSDF1; XpPotionTimer_text.fontSize = 10;
        elixirTimer_text.font = ChangaBoldSDF1; elixirTimer_text.fontSize = 10;
        goldCoinsDropsTimer_text.font = ChangaBoldSDF1; goldCoinsDropsTimer_text.fontSize = 10;
        treasurePotionTimer_Text.font = ChangaBoldSDF1; treasurePotionTimer_Text.fontSize = 10;
        goldenTouchTimer_text.font = ChangaBoldSDF1; goldenTouchTimer_text.fontSize = 10;
        rareTreasuresTimer_text.font = ChangaBoldSDF1; rareTreasuresTimer_text.fontSize = 10;
        negativeGoldtimer_Text.font = ChangaBoldSDF1; negativeGoldtimer_Text.fontSize = 10;
        negativeDamageTimer_text.font = ChangaBoldSDF1; negativeDamageTimer_text.fontSize = 10;
        negativeTreasureTimer_text.font = ChangaBoldSDF1; negativeTreasureTimer_text.fontSize = 10;
        negativeXPTimer_text.font = ChangaBoldSDF1; negativeXPTimer_text.fontSize = 10;
        negativeGoldCoinsDropTimer_text.font = ChangaBoldSDF1; negativeGoldCoinsDropTimer_text.fontSize = 10;
        #endregion

        #region Treasures
        chooseChickenBuff = "<color=green>CLICK ON THE CHICKEN TO CHOOSE BUFF";

        foundRubberChickenRewards2_text.font = MontserratMediumSDF1; foundRubberChickenRewards2_text.fontSize = 7f;

        tDropChanceRussAndEng = "% Chance to drop from a chest";
        youFoundThePrestigeKetAndChest = "";

        doubleInValue = " chance to double in value";

        quartsGained = "Quartz gained has a ";
        amethystGained = "Amethyst gained has a ";
        yellowTopazGained = "Yellow Topaz gained has a ";
        albiteGained = "Albite gained has a ";
        redGarnetGained = "Red Garnet gained has a ";
        aquamarineGained = "Aquamarine gained has a ";
        yellowShapphireGained = "Yellow Shapphire gained has a ";
        pinkTourmalineGained = "Pink Tourmaline gained has a ";
        adventurineGained = "Adventurine gained has a ";
        redRubyGained = "Red Ruby gained has a ";
        diamondGained = "Diamond gained has a ";
        grandidieriteGained = "Grandidierite gained has a ";
        violetCrystalGained = "Violet Crystal gained has a ";
        akoyaPearlGained = "Akoya Pearl gained has a ";
        purpleRupeeGained = "Purple Rupee gained has a ";
        emeraldGained = "Emerald gained has a ";
        greenDiamondGained = "Green Diamond gained has a ";
        fireOpalGained = "Fire Opal gained has a ";
        gemSilicaGained = "Gem Silica gained has a ";
        pinkPlortGained = "Pink Plort gained has a ";
        goldenSeaPearlGained = "Golden Sea Pearl gained has a ";
        kyaniteGained = "Kyanite gained has a ";
        blackOpalGained = "Black Opal gained has a ";
        painiteGained = "Painite gained has a ";
        tanzaniteGained = "Tanzanite gained has a ";
        astraliumGained = "Astralium gained has a ";
        elysiumPrismGained = "Elysium Prism gained has a ";
        aerthfireOpalGained = "Aetherfire Opal gained has a ";
        eldrichStarStoneGained = "Eldritch Starstone gained has a ";
        chronolithChardGained = "Chronolith Shard gained has a ";
        sideriumEssenceGained = "Siderium Essence gained has a ";
        quasariteGained = "Quasarite gained has a ";
        radiantNovaGained = "Radiant Nova Stone gained has a ";
        soluniumShardGained = "Solunium Shard gained has a ";

        for (int i = 0; i < 34; i++)
        {
            treasureDropChanceText_text[i].font = robotoBold; treasureDropChanceText_text[i].fontSize = 23;
            treasreDoubleText_text[i].font = robotoBold; treasreDoubleText_text[i].fontSize = 20;
        }

        sellTreasureFor_text.font = ChangaBoldSDF; sellTreasureFor_text.fontSize = 22; sellTreasureFor_text.lineSpacing = -90;
        sellTreasureFor = "Sell for "; sellGold = " Gold";

        #endregion

        #region Rare Treasures

        YOU_FOUND_A_SKULL = "YOU FOUND A SKULL!";
        YOU_FOUND_A_TROPHY = "YOU FOUND A TROPHY!";
        YOU_FOUND_A_DEMONIC_SWORD = "YOU FOUND A DEMONIC SWORD!";
        YOU_FOUND_A_RING = "YOU FOUND A RING!";
        YOU_FOUND_A_STAR = "YOU FOUND A STAR!";
        YOU_FOUND_A_CLOVER = "YOU FOUND A CLOVER!";
        YOU_FOUND_A_KINGS_CROWN = "YOU FOUND A KINGS CROWN!";
        YOU_FOUND_A_BOOK = "YOU FOUND A BOOK!";
        YOU_FOUND_A_GUITAR = "YOU FOUND A GUITAR!";
        YOU_FOUND_A_TALARIAN = "YOU FOUND A TALARIAN!";
        YOU_FOUND_A_STRANGE_RUNE = "YOU FOUND A STRANGE RUNE!";
        YOU_FOUND_A_BACKPACK = "YOU FOUND A BACKPACK!";
        YOU_FOUND_A_SHIELD = "YOU FOUND A SHIELD!";
        YOU_FOUND_A_PILL_BOTTLE = "YOU FOUND A PILL BOTTLE!";
        YOU_FOUND_A_MEDAL = "YOU FOUND A MEDAL!";
        YOU_FOUND_A_COOKIE = "YOU FOUND A COOKIE!";
        YOU_FOUND_A_CHRISTMAS_PRESENT = "YOU FOUND A CHRISTMAS PRESENT!";
        YOU_FOUND_A_BATTLE_AXE = "YOU FOUND A BATTLE AXE!";
        YOU_FOUND_A_100X_GOLD_COIN = "YOU FOUND A 100X GOLD COIN!";
        YOU_FOUND_A_SEALED_ENVELOPE = "YOU FOUND A SEALED ENVELOPE!";
        YOU_FOUND_A_STRANGE_POTION = "YOU FOUND A STRANGE POTION!";
        YOU_FOUND_A_SOUL_GEM = "YOU FOUND A SOUL GEM!";
        YOU_FOUND_AN_ANCIENT_SCROLL = "YOU FOUND AN ANCIENT SCROLL!";
        YOU_FOUND_A_BRICK = "YOU FOUND A BRICK!";
        YOU_FOUND_A_RUBBER_CHICKEN = "YOU FOUND A RUBBER CHICKEN!";

        PIRATE_SKULL = "PIRATE SKULL";
        DEMONIC_SWORD = "DEMONIC SWORD";
        MYSTIC_RING = "MYSTIC RING";
        TROPHY = "TROPHY";
        FALLEN_STAR = "FALLEN STAR";
        CLOVER = "CLOVER";
        KINGS_CROWN = "KINGS CROWN";
        SPELL_BOOK = "SPELL BOOK";
        GUITAR = "GUITAR";
        TALARIAN = "TALARIAN";
        MYTHRUNE = "MYTHRUNE";
        EXPLORER_BACKPACK = "EXPLORER BACKPACK";
        VIKING_SHIELD = "VIKING SHIELD";
        PILL_BOTTLE = "PILL BOTTLE";
        VICTORY_MEDAL = "VICTORY MEDAL";
        COOKIE = "COOKIE";
        CHRISTMAS_PRESENT = "CHRISTMAS PRESENT";
        BATTLE_AXE = "BATTLE AXE";
        GOLD_COIN_100X = "100X GOLD COIN";
        SEALED_ENVELOPE = "SEALED ENVELOPE";
        STRANGE_POTION = "STRANGE POTION";
        SOUL_GEM = "SOUL GEM";
        ANCIENT_SCROLL = "ANCIENT SCROLL";
        BRICK = "brick";
        RUBBER_CHICKEN = "RUBBER CHICKEN";



        demonicSwordSize = 22;
        mysticRingSize = 25;
        trophySize = 30;
        fallenStarSize = 21;
        cloverSize = 30;
        kingsCrownSize = 24;
        spellBookSize = 22;
        guitarSize = 29;
        talarianSize = 25;
        mythruneSize = 23;
        explorerBackpackSize = 21;
        skullSize = 25;
        rubberChickenSize = 22;
        brickSize = 30;
        ancientScrollSize = 22;
        soulGemSize = 22;
        strangePotionSize = 22;
        sealedEnvelopeSize = 20;
        goldCoin100XSize = 19;
        vikingShieldSize = 25;
        pillBottleSize = 24;
        victoryMedalSize = 25;
        cookieSize = 29;
        christmasPresentSize = 18;
        battleAxeSize = 22;

        pirateSkull_text.font = changaMedium; pirateSkull_text.fontSize = skullSize;
        demonicSword_text.font = changaMedium; demonicSword_text.fontSize = demonicSwordSize;
        mysticRing_text.font = changaMedium; mysticRing_text.fontSize = mysticRingSize;
        trophy_text.font = changaMedium; trophy_text.fontSize = trophySize;
        fallenStar_text.font = changaMedium; fallenStar_text.fontSize = fallenStarSize;
        clover_text.font = changaMedium; clover_text.fontSize = cloverSize;
        kingsCrown_text.font = changaMedium; kingsCrown_text.fontSize = kingsCrownSize;
        spellBook_text.font = changaMedium; spellBook_text.fontSize = spellBookSize;
        guitar_text.font = changaMedium; guitar_text.fontSize = guitarSize;
        talarian_text.font = changaMedium; talarian_text.fontSize = talarianSize;
        mythrune_text.font = changaMedium; mythrune_text.fontSize = mythruneSize;
        explorerBackpack_text.font = changaMedium; explorerBackpack_text.fontSize = explorerBackpackSize;
        vikingShield_text.font = changaMedium; vikingShield_text.fontSize = vikingShieldSize;
        pillBottle_text.font = changaMedium; pillBottle_text.fontSize = pillBottleSize;
        victoryMedal_text.font = changaMedium; victoryMedal_text.fontSize = victoryMedalSize;
        cookie_text.font = changaMedium; cookie_text.fontSize = cookieSize;
        christmasPresent_text.font = changaMedium; christmasPresent_text.fontSize = christmasPresentSize;
        battleAxe_text.font = changaMedium; battleAxe_text.fontSize = battleAxeSize;
        goldCoin100X_text.font = changaMedium; goldCoin100X_text.fontSize = goldCoin100XSize;
        sealedEnvelope_text.font = changaMedium; sealedEnvelope_text.fontSize = sealedEnvelopeSize;
        strangePotion_text.font = changaMedium; strangePotion_text.fontSize = strangePotionSize;
        soulGem_text.font = changaMedium; soulGem_text.fontSize = soulGemSize;
        ancientScroll_text.font = changaMedium; ancientScroll_text.fontSize = ancientScrollSize;
        brick_text.font = changaMedium; brick_text.fontSize = brickSize;
        rubberChicken_text.font = changaMedium; rubberChicken_text.fontSize = rubberChickenSize;



        if (RareTreasures.skullFound == 1)
        {
            pirateSkull_text.text = "PIRATE SKULL"; 
        }
        if (RareTreasures.swordFound == 1)
        {
            demonicSword_text.text = "DEMONIC SWORD"; 
        }
        if (RareTreasures.ringFound == 1)
        {
            mysticRing_text.text = "MYSTIC RING"; 
        }
        if (RareTreasures.trophyFound == 1)
        {
            trophy_text.text = "TROPHY"; 
        }
        if (RareTreasures.starFound == 1)
        {
            fallenStar_text.text = "FALLEN STAR"; 
        }
        if (RareTreasures.cloverFound == 1)
        {
            clover_text.text = "CLOVER";
        }
        if (RareTreasures.crownFound == 1)
        {
            kingsCrown_text.text = "KINGS CROWN";
        }
        if (RareTreasures.bookFound == 1)
        {
            spellBook_text.text = "SPELL BOOK"; 
        }
        if (RareTreasures.guitarFOund == 1)
        {
            guitar_text.text = "GUITAR";
        }
        if (RareTreasures.talarianFound == 1)
        {
            talarian_text.text = "TALARIAN";
        }
        if (RareTreasures.runeFound == 1)
        {
            mythrune_text.text = "MYTHRUNE"; 
        }
        if (RareTreasures.backPackFound == 1)
        {
            explorerBackpack_text.text = "EXPLORER BACKPACK";
        }
        if (RareTreasures.shieldFound == 1)
        {
            vikingShield_text.text = "VIKING SHIELD"; 
        }
        if (RareTreasures.pillBottleFound == 1)
        {
            pillBottle_text.text = "PILL BOTTLE"; 
        }
        if (RareTreasures.medalFound == 1)
        {
            victoryMedal_text.text = "VICTORY MEDAL"; 
        }
        if (RareTreasures.cookieFound == 1)
        {
            cookie_text.text = "COOKIE";
        }
        if (RareTreasures.presentFound == 1)
        {
            christmasPresent_text.text = "CHRISTMAS PRESENT"; 
        }
        if (RareTreasures.axeFound == 1)
        {
            battleAxe_text.text = "BATTLE AXE";
        }
        if (RareTreasures.coin100XFound == 1)
        {
            goldCoin100X_text.text = "100X GOLD COIN"; 
        }
        if (RareTreasures.envelopeFound == 1)
        {
            sealedEnvelope_text.text = "SEALED ENVELOPE"; 
        }
        if (RareTreasures.potionFound == 1)
        {
            strangePotion_text.text = "STRANGE POTION"; 
        }
        if (RareTreasures.soulGemFound == 1)
        {
            soulGem_text.text = "SOUL GEM"; 
        }
        if (RareTreasures.scrollFound == 1)
        {
            ancientScroll_text.text = "ANCIENT SCROLL"; 
        }
        if (RareTreasures.brickFound == 1)
        {
            brick_text.text = "brick"; 
        }
        if (RareTreasures.chickenFound == 1)
        {
            rubberChicken_text.text = "RUBBER CHICKEN";
        }

        foundRareTreasurePopUp_text.lineSpacing = -90;

        foundRareTreasurePopUp_text.font = ChangaBoldSDF1; foundRareTreasurePopUp_text.fontSize = 32;

        pirateSkull_text.lineSpacing = -105;
        demonicSword_text.lineSpacing = -105;
        mysticRing_text.lineSpacing = -105;
        trophy_text.lineSpacing = -105;
        fallenStar_text.lineSpacing = -105;
        clover_text.lineSpacing = -105;
        kingsCrown_text.lineSpacing = -105;
        spellBook_text.lineSpacing = -105;
        guitar_text.lineSpacing = -105;
        talarian_text.lineSpacing = -105;
        mythrune_text.lineSpacing = -105;
        explorerBackpack_text.lineSpacing = -105;
        vikingShield_text.lineSpacing = -105;
        pillBottle_text.lineSpacing = -105;
        victoryMedal_text.lineSpacing = -105;
        cookie_text.lineSpacing = -105;
        christmasPresent_text.lineSpacing = -105;
        battleAxe_text.lineSpacing = -105;
        goldCoin100X_text.lineSpacing = -105;
        sealedEnvelope_text.lineSpacing = -105;
        strangePotion_text.lineSpacing = -105;
        soulGem_text.lineSpacing = -105;
        ancientScroll_text.lineSpacing = -105;
        brick_text.lineSpacing = -105;
        rubberChicken_text.lineSpacing = -105;
        

        chooseText1_text.font = ChangaBoldSDF1; chooseText1_text.fontSize = 25f;
        chooseText2_text.font = ChangaBoldSDF1; chooseText2_text.fontSize = 25f;
        chooseText3_text.font = ChangaBoldSDF1; chooseText3_text.fontSize = 25f;
        chooseText4_text.font = ChangaBoldSDF1; chooseText4_text.fontSize = 25f;
        chooseText5_text.font = ChangaBoldSDF1; chooseText5_text.fontSize = 25f;
        chooseText6_text.font = ChangaBoldSDF1; chooseText6_text.fontSize = 23f;
        chooseText7_text.font = ChangaBoldSDF1; chooseText7_text.fontSize = 25f;

       
        price200SkillPoints_text.font = changaMedium; price200SkillPoints_text.fontSize = 12.6f;
        priceEqual = "PRICE =";
        skillPoints200 = "200 SKILL POINTS";
        if (PlayerLevel.skillPoints >= 200)
        {
            price200SkillPoints_text.text = Localization.priceEqual + " <color=green>" + Localization.skillPoints200;
        }
        if (PlayerLevel.skillPoints < 200)
        {
            price200SkillPoints_text.text = Localization.priceEqual + " <color=red>" + Localization.skillPoints200;
        }
        #endregion

        #region Treasure Chests
        ON = "ON"; OFF = "OFF";

        GoldCoinsDrop = "Gold coins drop: ";
        goldCoinValue = "Gold coin value: ";
        XPDrop = "XP Drop: ";

        chestNumber = "Chest no. "; chestNO = "";

        reinforcedChestChance1 = ""; reinforcedChestChance2 = " Reinforced chest chance";

        WoodenChest = "Wooden Chest";
        TimberwoodChest = "Timberwood Chest";
        RockboundChest = "Rockbound Chest";
        BronzeChest = "Bronze Chest";
        SequoiaChest = "Sequoia Chest";
        IronboundChest = "Ironbound Chest";
        StoneshieldChest = "Stoneshield Chest";
        OceanChest = "Ocean Chest";
        PoisonousChest = "Poisonous Chest";
        GoldenChest = "Golden Chest";
        DesertChest = "Desert Chest";
        PirateChest = "Pirate Chest";
        CrystalChest = "Crystal Chest";
        CelestialChest = "Celestial Chest";
        PhantomChest = "Phantom Chest";
        PrismaticChest = "Prismatic Chest";
        AquaticChest = "Aquatic Chest";
        WindwalkersChest = "Windwalker's Chest";
        EnchantedChest = "Enchanted Chest";
        RoyalChest = "Royal Chest";
        ArcaneChest = "Arcane Chest";
        GrandioseChest = "Grandiose Chest";
        LuxuriousGoldenChest = "Luxurious Golden Chest";
        SacredChest = "Sacred Chest";
        EternitysEmbraceChest = "Eternity's Embrace Chest";
        ForgottenChest = "Forgotten Chest";
        LivingLuminousChest = "Living Luminous Chest";
        FortressOfWealth = "Fortress of Wealth";
        FortifiedTimberChest = "Fortified Timber Chest";
        RadiantFrostlock = "Radiant Frostlock";
        InfernoEmbracedChest = "Inferno-Embraced Chest";
        DeathChest = "Death Chest";
        AlienChest = "Alien Chest";
        CraftsmansReliquary = "Craftsman's Reliquary";
        HellfireGuardianChest = "Hellfire Guardian Chest";
        GhastlySoulHoardChest = "Ghastly Soul-Hoard Chest";
        HighTechCache = "High-Tech Cache";
        EliteHackersStrongbox = "Elite Hacker's Strongbox";
        CollectorsVault = "Collector's Vault";
        ExquisiteAzureRadianceChest = "Exquisite Azure Radiance Chest";

        TimberwoodChestUnlocked = "Timberwood Chest Unlocked";
        RockboundChestUnlocked = "Rockbound Chest Unlocked";
        BronzeChestUnlocked = "Bronze Chest Unlocked";
        SequoiaChestUnlocked = "Sequoia Chest Unlocked";
        IronboundChestUnlocked = "Ironbound Chest Unlocked";
        StoneshieldChestUnlocked = "Stoneshield Chest Unlocked";
        OceanChestUnlocked = "Ocean Chest Unlocked";
        PoisonousChestUnlocked = "Poisonous Chest Unlocked";
        GoldenChestUnlocked = "Golden Chest Unlocked";
        DesertChestUnlocked = "Desert Chest Unlocked";
        PirateChestUnlocked = "Pirate Chest Unlocked";
        CrystalChestUnlocked = "Crystal Chest Unlocked";
        CelestialChestUnlocked = "Celestial Chest Unlocked";
        PhantomChestUnlocked = "Phantom Chest Unlocked";
        PrismaticChestUnlocked = "Prismatic Chest Unlocked";
        AquaticChestUnlocked = "Aquatic Chest Unlocked";
        WindwalkersChestUnlocked = "Windwalker's Chest Unlocked";
        EnchantedChestUnlocked = "Enchanted Chest Unlocked";
        RoyalChestUnlocked = "Royal Chest Unlocked";
        ArcaneChestUnlocked = "Arcane Chest Unlocked";
        GrandioseChestUnlocked = "Grandiose Chest Unlocked";
        LuxuriousGoldenChestUnlocked = "Luxurious Golden Chest Unlocked";
        SacredChestUnlocked = "Sacred Chest Unlocked";
        EternitysEmbraceChestUnlocked = "Eternity's Embrace Chest Unlocked";
        ForgottenChestUnlocked = "Forgotten Chest Unlocked";
        LivingLuminousChestUnlocked = "Living Luminous Chest Unlocked";
        FortressOfWealthUnlocked = "Fortress of Wealth Unlocked";
        FortifiedTimberChestUnlocked = "Fortified Timber Chest Unlocked";
        RadiantFrostlockUnlocked = "Radiant Frostlock Unlocked";
        InfernoEmbracedChestUnlocked = "Inferno-Embraced Chest Unlocked";
        DeathChestUnlocked = "Death Chest Unlocked";
        AlienChestUnlocked = "Alien Chest Unlocked";
        CraftsmansReliquaryUnlocked = "Craftsman's Reliquary Unlocked";
        HellfireGuardianChestUnlocked = "Hellfire Guardian Chest Unlocked";
        GhastlySoulHoardChestUnlocked = "Ghastly Soul-Hoard Chest Unlocked";
        HighTechCacheUnlocked = "High-Tech Cache Unlocked";
        EliteHackersStrongboxUnlocked = "Elite Hacker's Strongbox Unlocked";
        CollectorsVaultUnlocked = "Collector's Vault Unlocked";
        ExquisiteAzureRadianceChestUnlocked = "Exquisite Azure Radiance Chest Unlocked";

        chestPrice_text.font = robotoBold; chestPrice_text.fontSize = 25;
        chestHP_text.font = robotoBold; chestHP_text.fontSize = 34;

        chestPrice_text.text = TotalGoldAmount.FormatCoinsDoubleOneLetter(SelectChests.chestPrice) + "";
        chestHP_text.text = TotalGoldAmount.FormatCoinsDoubleOneLetter(SelectChests.ChestHealth) + "";

        autoPurchaseONOFF_text.font = ChangaBoldSDF; autoPurchaseONOFF_text.fontSize = 40;
        chestHoverName_text.font = ChangaBoldSDF1; chestHoverName_text.fontSize = 31;
        chestNO_text.font = MontserratMediumSDF1; chestNO_text.fontSize = 30;
        chestXPAmount_text.font = MontserratMediumSDF1; chestXPAmount_text.fontSize = 19;
        chestGoldCoins_text.font = MontserratMediumSDF1; chestGoldCoins_text.fontSize = 19;
        chestGoldAmount_text.font = MontserratMediumSDF1; chestGoldAmount_text.fontSize = 19;
        chestReinforcedChance.font = MontserratMediumSDF1; chestReinforcedChance.fontSize = 19;
        chestPurchasedName_text.font = changaMedium; chestPurchasedName_text.fontSize = 45;

        reinforcedHoverHealth_text.font = myriadPro; reinforcedHoverHealth_text.fontSize = 20;
        reinforcedHoverGold_text.font = myriadPro; reinforcedHoverGold_text.fontSize = 20;
        reinforcedHoverXP_text.font = myriadPro; reinforcedHoverXP_text.fontSize = 20;

        enchantedGoldenHoverHealth_text.font = myriadPro; enchantedGoldenHoverHealth_text.fontSize = 17;
        enchantedGoldenHoverTreasures_text.font = myriadPro; enchantedGoldenHoverTreasures_text.fontSize = 17;
        enchantedGoldenHoverXP_text.font = myriadPro; enchantedGoldenHoverXP_text.fontSize = 17;

        bossChestHoverHealth_text.font = myriadPro; bossChestHoverHealth_text.fontSize = 17;
        bossChestHoverGoldValue_text.font = myriadPro; bossChestHoverGoldValue_text.fontSize = 17;
        bossChestHoverGoldCoins_text.font = myriadPro; bossChestHoverGoldCoins_text.fontSize = 17;
        bossChestHoverXP_text.font = myriadPro; bossChestHoverXP_text.fontSize = 17;
        #endregion

        #region Prestige

        prestigeKeyChance1 = ""; prestigeKeyChance2 = "% Prestige key drop chance";
        prestieChestKey1 = ""; prestieChestKey2 = "% Prestige chest drop chance";

        FindThePrestigeKeyandChest = "Find the Prestige Key and Prestige Chest";
        youFoundThePrestigeKetAndChest = "You found the Prestige Key and Prestige Chest!";

        youFoundPrestigeKey = "You found the Prestige Key!";
        youFoundPrestigeChest = "You found the Prestige Chest";

        nextLevelHover = "Next level = "; skillPointsHover = " skill points";

        choseItemToStartWith = "Choose 1 item to start with";
        chooseItemsToStartWith2 = "Choose 2 items to start with";
        chooseItemsToStartWith3 = "Choose 3 items to start with";
        chooseItemsToStartWith5 = "Choose 5 items to start with";


        findThePrestigeKeyAncChest_text.font = ChangaBoldSDF1; findThePrestigeKeyAncChest_text.fontSize = 14; 
        

        if (SpawnRewards.prestigeKeyFound == 0)
        {
            findThePrestigeKeyAncChest_text.text = FindThePrestigeKeyandChest;
        }
        if (SpawnRewards.prestigeChestFound == 0)
        {
            findThePrestigeKeyAncChest_text.text = FindThePrestigeKeyandChest;
        }
        if (SpawnRewards.prestigeChestFound == 1 && SpawnRewards.prestigeKeyFound == 1)
        {
            findThePrestigeKeyAncChest_text.text = youFoundThePrestigeKetAndChest;
        }

        prestigeKeyDropChance_text.font = MontserratExtraLight; prestigeKeyDropChance_text.fontSize = 20;
        prestigeChestDropChance_text.font = MontserratExtraLight; prestigeChestDropChance_text.fontSize = 20;
        prestigeKeyDropChance_text.text = Localization.prestigeKeyChance1 + 0.017 * (UnlockChests.timesPurchasedChests + 1) + Localization.prestigeKeyChance2;
        prestigeChestDropChance_text.text = Localization.prestieChestKey1 + 0.017 * (UnlockChests.timesPurchasedChests + 1) + Localization.prestieChestKey2;

        nextLeveEqualSkillPoints_text.font = changaMedium; nextLeveEqualSkillPoints_text.fontSize = 55;
        nextLeveEqualSkillPoints_text.text = Localization.nextLevelHover + "<color=green>+" + ((PlayerLevel.playerLevel / 5) + 1) + "<color=white>" + Localization.skillPointsHover;


        chooseItemToStartWith_text.font = MontserratMediumSDF1; chooseItemToStartWith_text.fontSize = 42;
        #endregion

        #region Other
        level = "LEVEL ";
        xpNoPercent = "XP";
        crit = "CRIT!";

        totalGold_text.font = changaMedium; totalGold_text.fontSize = 46;
        levelText_text.font = MontserratSemiBold; levelText_text.fontSize = 36; levelText_text.text = "LEVEL " + PlayerLevel.playerLevel;
        xpNeededText_text.font = MontserratRegular; xpNeededText_text.fontSize = 15;
        activeDamageAmount_text.font = robotoBold; activeDamageAmount_text.fontSize = 20f;
        passiveDamageAmount_text.font = robotoBold; passiveDamageAmount_text.fontSize = 20f;
        acitveDamagePrice_text.font = robotoBold; acitveDamagePrice_text.fontSize = 18f;
        passiveDamagePrice_text.font = robotoBold; passiveDamagePrice_text.fontSize = 18f;
        activeDamageLEVELAmount_text.font = ChangaBoldSDF; activeDamageLEVELAmount_text.fontSize = 30f;
        passiveLEVELAmount_text.font = ChangaBoldSDF; passiveLEVELAmount_text.fontSize = 30f;
        passiveDamageUPGRADE_text.font = robotoBold; passiveDamageUPGRADE_text.fontSize = 20f;
        activeDamageUPGRADE_text.font = robotoBold; activeDamageUPGRADE_text.fontSize = 20f;

        youOpened.font = ChangaBoldSDF1; youOpened.fontSize = 40; youOpened.lineSpacing = -70;
        timeGoneTotal.font = ChangaBoldSDF1; timeGoneTotal.fontSize = 40;

        damageUnderChest.font = MontserratSemiBold; damageUnderChest.fontSize = 6;
        #endregion

        if (PlaceMobileButtons.isFoldPhone == true)
        {
            musicBy_text.fontSize = 13.5f;
            developerInfo_text.text = "Treasure Chest Clicker is developed by:\nSimon Eftestøl"; developerInfo_text.font = AlataRegular; developerInfo_text.fontSize = 12;
        }

        ChangeAllText();
    }
    #endregion

    #region Russian  
    public void RussianLanguage()
    {
        JapaneseLanguageChosen = 0;
        RussianLanguageChosen = 1;
        EnglishLanguageChosen = 0;
        ChineseLanguageChosen = 0;
        KoreanLanguageChosen = 0;

        if (PlaceMobileButtons.isMobile == true) { ChangeMobileText(); }

        PlayerPrefs.SetInt("SaveEnglish", EnglishLanguageChosen);
        PlayerPrefs.SetInt("SaveRussian", RussianLanguageChosen);
        PlayerPrefs.SetInt("SaveJapanese", JapaneseLanguageChosen);
        PlayerPrefs.SetInt("SaveChinese", ChineseLanguageChosen);
        PlayerPrefs.SetInt("SaveKorean", KoreanLanguageChosen);

        #region TotalGold Variables
        Million = " Миллион";
        Billion = " Миллиард";
        Trillion = " Триллион";
        Quadrillion = " Квадриллион";
        Quintillion = " Квинтиллион";
        Sextillion = " Секстиллион";
        Septillion = " Септиллион";
        Octillion = " Октиллион";
        Nonillion = " Нониллион";
        Decillion = " Дециллион";
        Undecillion = " Ундециллион";
        Duodecillion = " Дуодециллион";
        Tredecillion = " Тредециллион";
        Quattuordecillion = " Кваттуордециллион";
        Quindecillion = " Квиндециллион";
        Sexdecillion = " Сексдециллион";
        Septendecillion = " Септендециллион";
        Octodecillion = " Октодециллион";
        Novemdecillion = " Новемдециллион";
        Vigintillion = " Вигинтиллион";
        Unvigintillion = " Унвигинтиллион";
        Duovigintillion = " Дуовигинтиллион";
        Trevigintillion = " Тревигинтиллион";

        MillionShort = "Млн";
        BillionShort = "Млрд";
        TrillionShort = "Трлн";
        QuadrillionShort = "Квдрлн";
        QuintillionShort = "Квнтлн";
        SextillionShort = "Скстлн";
        SeptillionShort = "Сптлн";
        OctillionShort = "Октлн";
        NonillionShort = "Ннлн";
        DecillionShort = "Дцлн";
        UndecillionShort = "Ундцлн";
        DuodecillionShort = "Дуодцлн";
        TredecillionShort = "Тредцлн";
        QuattuordecillionShort = "Квтрдцлн";
        QuindecillionShort = "Квндцлн";
        SexdecillionShort = "Сксдцлн";
        SeptendecillionShort = "Сптдцлн";
        OctodecillionShort = "Октдцлн";
        NovemdecillionShort = "Нвмдцлн";
        VigintillionShort = "Вгнтлн";
        UnvigintillionShort = "Унвгнтлн";
        DuovigintillionShort = "Дуовгнтлн";
        TrevigintillionShort = "Тревгнтлн";
        #endregion

        #region Pluss Buffs Strings
        gold = " ЗОЛОТО";
        goldPercentString = "% ЗОЛОТО";

        clickDamage = " урона за клик ";
        activeDamageTop = " Активного Урона";
        dps = "УВС";
        passiveDamageString = "% Пассивного Урона ";
        activeDamageScring = "% Активного Урона ";
        critChanceString = "% Шанс Крита ";
        critDamageString = "% Урон Крита ";

        damagePercent = "% УРОНА";
        xp = "% ОПЫТ";

        treasureDropChance = "% ШАНС ВЫПАДЕНИЯ СОКРОВИЩА";
        goldCoinsDrop = " Выпадение золотых монет";

        friendlyMimic = "ДОБРЫЙ МИМИК! ";
        evilMimic = "ЗЛОБНЫЙ МИМИК! ";
        secondsMimic = " СЕКУНД";

        rareTreasureDropChance = "+ШАНС ВЫПАДЕНИЯ РЕДКОГО СОКРОВИЩА ";

        #endregion


        #region Settings Text
        settings_text.text = "Настройки"; settings_text.font = russianNonoBoldOutLine; settings_text.fontSize = 27;

        general_text.text = "ОБЩЕЕ"; general_text.font = russianNonoBoldOutLine; general_text.fontSize = 19;

        info_text.text = "ИНФО"; info_text.font = russianNonoBoldOutLine; info_text.fontSize = 20;

        music_text.text = "МУЗЫКА"; music_text.font = russianNono_Medium; music_text.fontSize = 20;

        sound_text.text = "ЗВУК"; sound_text.font = russianNono_Medium; sound_text.fontSize = 24;

        miniChestAndMimicChestSpawnSound_text.text = "ЗВУК ПОЯВЛЕНИЯ МИНИ-СУНДУКА И МИМИК-СУНДУКА"; miniChestAndMimicChestSpawnSound_text.font = russianNono_Medium; miniChestAndMimicChestSpawnSound_text.fontSize = 16;

        mimicChestSpawning_text.text = "ПОЯВЛЕНИЕ МИМИК-СУНДУКА"; mimicChestSpawning_text.font = russianNono_Medium; mimicChestSpawning_text.fontSize = 18;

        fullscreen_text.text = "ПОЛНОЭКРАННЫЙ РЕЖИМ"; fullscreen_text.font = russianNono_Medium; fullscreen_text.fontSize = 11;

        onFullScreen_text.text = "ВКЛ"; onFullScreen_text.font = russianNono_Bold; onFullScreen_text.fontSize = 21;

        offFullScreen_text.text = "ВЫКЛ"; offFullScreen_text.font = russianNono_Bold; offFullScreen_text.fontSize = 21;

        onMimicSpawn_text.text = "ВКЛ"; onMimicSpawn_text.font = russianNono_Bold; onMimicSpawn_text.fontSize = 24;

        offMimicSpawn_text.text = "ВЫКЛ"; offMimicSpawn_text.font = russianNono_Bold; offMimicSpawn_text.fontSize = 22;

        onMiniAndMimicSound_text.text = "ВКЛ"; onMiniAndMimicSound_text.font = russianNono_Bold; onMiniAndMimicSound_text.fontSize = 24;

        offMiniAndMimicSound_text.text = "ВЫКЛ"; offMiniAndMimicSound_text.font = russianNono_Bold; offMiniAndMimicSound_text.fontSize = 22;

        resolution_text.text = "РАЗРЕШЕНИЕ"; resolution_text.font = russianNono_Medium; resolution_text.fontSize = 19;

        exit_text.text = "ВЫХОД"; exit_text.font = russianNono_Bold; exit_text.fontSize = 34;

        save_text.text = "СОХРАНИТЬ"; save_text.font = russianNono_Bold; save_text.fontSize = 14;

        gameSavesEvery15Seconds_text.text = "Игра сохраняется каждые 15 секунд"; gameSavesEvery15Seconds_text.font = russianNono_Bold; gameSavesEvery15Seconds_text.fontSize = 9;

        cantSaveDuringPrestige_text.text = "НЕЛЬЗЯ СОХРАНИТЬ ВО ВРЕМЯ ПРЕСТИЖА"; cantSaveDuringPrestige_text.font = russianNono_Bold; cantSaveDuringPrestige_text.fontSize = 20;

        resetGame_text.text = "СБРОС ИГРЫ"; resetGame_text.font = russianNono_Bold; resetGame_text.fontSize = 23; resetGame_text.lineSpacing = -40;

        discord_text.text = "ДИСКОРД"; discord_text.font = russianNono_Medium; discord_text.fontSize = 27;

        numberOfCoinsAndTreasuresOnScreen_text.text = "КОЛИЧЕСТВО МОНЕТ И СОКРОВИЩ НА ЭКРАНЕ ПЕРЕД АВТОМАТИЧЕСКИМ СБОРОМ"; numberOfCoinsAndTreasuresOnScreen_text.font = russianNono_Medium; numberOfCoinsAndTreasuresOnScreen_text.fontSize = 16;

        reinforcedChests_text.text = "УСИЛЕННЫЕ СУНДУКИ"; reinforcedChests_text.font = russianNono_Medium; reinforcedChests_text.fontSize = 14;

        reinforcedChestsDescription_text.text = "Каждый сундук может быть усиленной версией сундука. Вероятность усиления зависит от приобретенного сундука."; reinforcedChestsDescription_text.font = russianNono_Medium; reinforcedChestsDescription_text.fontSize = 10;

        enchantedGoldenChests_text.text = "ЗАЧАРОВАННЫЕ ЗОЛОТЫЕ СУНДУКИ"; enchantedGoldenChests_text.font = russianNono_Medium; enchantedGoldenChests_text.fontSize = 12;

        bossChests_text.text = "СУНДУКИ БОССОВ"; bossChests_text.font = russianNono_Medium; bossChests_text.fontSize = 17;

        musicBy_text.text = "Музыка от: Kevin MacLeod - Arpent"; musicBy_text.font = russianNono_Medium; musicBy_text.fontSize = 15;

        developerInfo_text.text = "Treasure Chest Clicker разработан: Simon Eftestøl"; developerInfo_text.font = russianNono_Medium; developerInfo_text.fontSize = 15;

        resetConfirmation_text.text = "Вы хотите сделать полный сброс?\nИгра начнётся сначала."; resetConfirmation_text.font = russianNono_Bold; resetConfirmation_text.fontSize = 20;

        yes_text.text = "ДА"; yes_text.font = russianNono_Bold; yes_text.fontSize = 55;

        no_text.text = "НЕТ"; no_text.font = russianNono_Bold; no_text.fontSize = 55;

        gameSaves_Text.text = "ИГРА СОХРАНЕНА!"; gameSaves_Text.font = russianNono_Bold; gameSaves_Text.fontSize = 15;
        #endregion

        #region stats
        stats_text.text = "СТАТИСТИКА"; stats_text.font = russianNonoBoldOutLine; stats_text.fontSize = 40;
        goldAndTreasures_text.text = "ЗОЛОТО & СОКРОВИЩА"; goldAndTreasures_text.font = russian_SemiBold; goldAndTreasures_text.fontSize = 36;
        chests_text.text = "СУНДУКИ"; chests_text.font = russian_SemiBold; chests_text.fontSize = 55;
        damage_text.text = "УРОН"; damage_text.font = russian_SemiBold; damage_text.fontSize = 55;
        items.text = "ПРЕДМЕТЫ"; items.font = russian_SemiBold; items.fontSize = 55;
        buffsAndPrestige_text.text = "БАФЫ И ПРЕСТИЖ"; buffsAndPrestige_text.font = russian_SemiBold; buffsAndPrestige_text.fontSize = 45;
        #endregion

        #region Achievements
        achievements_text.text = "ДОСТИЖЕНИЯ"; achievements_text.font = russianNonoBoldOutLine; achievements_text.fontSize = 40;
        drop25GoldCoins_text.text = "Выбросить 25 золотых монет из сундуков"; drop25GoldCoins_text.font = russianNono_MediumOutLine; drop25GoldCoins_text.fontSize = 24;
        drop1000GoldCoins_text.text = "Выбросить 1000 золотых монет из сундуков"; drop1000GoldCoins_text.font = russianNono_MediumOutLine; drop1000GoldCoins_text.fontSize = 24;
        drop100000GoldCoins_text.text = "Выбросить 100 000 золотых монет из сундуков"; drop100000GoldCoins_text.font = russianNono_MediumOutLine; drop100000GoldCoins_text.fontSize = 24;
        drop1MillionGoldCoins_text.text = "Выбросить 1 миллион золотых монет из сундуков"; drop1MillionGoldCoins_text.font = russianNono_MediumOutLine; drop1MillionGoldCoins_text.fontSize = 24;
        total100Gold_text.text = "Иметь всего 100 золота"; total100Gold_text.font = russianNono_MediumOutLine; total100Gold_text.fontSize = 24;
        total100000Gold_text.text = "Иметь всего 100 000 золота"; total100000Gold_text.font = russianNono_MediumOutLine; total100000Gold_text.fontSize = 24;
        total1MillionGold_text.text = "Иметь всего 1 миллион золота"; total1MillionGold_text.font = russianNono_MediumOutLine; total1MillionGold_text.fontSize = 24;
        total1BillionGold_text.text = "Иметь всего 1 миллиард золота"; total1BillionGold_text.font = russianNono_MediumOutLine; total1BillionGold_text.fontSize = 24;
        total1TrillionGold_text.text = "Иметь всего 1 триллион золота"; total1TrillionGold_text.font = russianNono_MediumOutLine; total1TrillionGold_text.fontSize = 24;

        //10
        total1QuadrillionGold_text.text = "Иметь всего 1 квадриллион золота"; total1QuadrillionGold_text.font = russianNono_MediumOutLine; total1QuadrillionGold_text.fontSize = 24;
        total1QuintillionGold_text.text = "Иметь всего 1 квинтиллион золота"; total1QuintillionGold_text.font = russianNono_MediumOutLine; total1QuintillionGold_text.fontSize = 24;
        total1SextillionGold_text.text = "Иметь всего 1 секстиллион золота"; total1SextillionGold_text.font = russianNono_MediumOutLine; total1SextillionGold_text.fontSize = 24;
        total1SeptillionGold_text.text = "Иметь всего 1 септиллион золота"; total1SeptillionGold_text.font = russianNono_MediumOutLine; total1SeptillionGold_text.fontSize = 24;
        total1OctillionGold_text.text = "Иметь всего 1 октиллион золота"; total1OctillionGold_text.font = russianNono_MediumOutLine; total1OctillionGold_text.fontSize = 24;
        total1NonillionGold_text.text = "Иметь всего 1 нониллион золота"; total1NonillionGold_text.font = russianNono_MediumOutLine; total1NonillionGold_text.fontSize = 24;
        total1DecillionGold_text.text = "Иметь всего 1 дециллион золота"; total1DecillionGold_text.font = russianNono_MediumOutLine; total1DecillionGold_text.fontSize = 24;
        total1NovemdecillionGold_text.text = "Иметь всего 1 новемдециллион золота"; total1NovemdecillionGold_text.font = russianNono_MediumOutLine; total1NovemdecillionGold_text.fontSize = 24;
        drop5XGoldCoin_text.text = "Выбросить золотую монету 5X"; drop5XGoldCoin_text.font = russianNono_MediumOutLine; drop5XGoldCoin_text.fontSize = 24;
        drop1000_5XGoldCoins_text.text = "Выбросить 1000 золотых монет 5X"; drop1000_5XGoldCoins_text.font = russianNono_MediumOutLine; drop1000_5XGoldCoins_text.fontSize = 24;

        //20
        drop50000_5XGoldCoins_text.text = "Выбросить 50 000 золотых монет 5X"; drop50000_5XGoldCoins_text.font = russianNono_MediumOutLine; drop50000_5XGoldCoins_text.fontSize = 24;
        drop10XGoldCoin_text.text = "Выбросить золотую монету 10X"; drop10XGoldCoin_text.font = russianNono_MediumOutLine; drop10XGoldCoin_text.fontSize = 24;
        drop1000_10XGoldCoins_text.text = "Выбросить 1000 золотых монет 10X"; drop1000_10XGoldCoins_text.font = russianNono_MediumOutLine; drop1000_10XGoldCoins_text.fontSize = 24;
        drop15000_10XGoldCoins_text.text = "Выбросить 15 000 золотых монет 10X"; drop15000_10XGoldCoins_text.font = russianNono_MediumOutLine; drop15000_10XGoldCoins_text.fontSize = 24;
        spawn10GoldCoinsFromClicks_text.text = "Появить 10 золотых монет от кликов"; spawn10GoldCoinsFromClicks_text.font = russianNono_MediumOutLine; spawn10GoldCoinsFromClicks_text.fontSize = 24;
        spawn100GoldCoinsFromClicks_text.text = "Появить 100 золотых монет от кликов"; spawn100GoldCoinsFromClicks_text.font = russianNono_MediumOutLine; spawn100GoldCoinsFromClicks_text.fontSize = 24;
        spawn1000GoldCoinsFromClicks_text.text = "Появить 1000 золотых монет от кликов"; spawn1000GoldCoinsFromClicks_text.font = russianNono_MediumOutLine; spawn1000GoldCoinsFromClicks_text.fontSize = 24;
        oneTreasureDropped_text.text = "1 Сокровище выброшено из сундука"; oneTreasureDropped_text.font = russianNono_MediumOutLine; oneTreasureDropped_text.fontSize = 24;
        hundredTreasuresDropped_text.text = "100 Сокровищ выброшено из сундуков"; hundredTreasuresDropped_text.font = russianNono_MediumOutLine; hundredTreasuresDropped_text.fontSize = 24;
        thousandTreasuresDropped_text.text = "1000 Сокровищ выброшено из сундуков"; thousandTreasuresDropped_text.font = russianNono_MediumOutLine; thousandTreasuresDropped_text.fontSize = 24;
        tenThousandTreasuresDropped_text.text = "10 000 Сокровищ выброшено из сундуков"; tenThousandTreasuresDropped_text.font = russianNono_MediumOutLine; tenThousandTreasuresDropped_text.fontSize = 24;
        fiftyThousandTreasuresDropped_text.text = "50 000 Сокровищ выброшено из сундуков"; fiftyThousandTreasuresDropped_text.font = russianNono_MediumOutLine; fiftyThousandTreasuresDropped_text.fontSize = 24;

        //30 (Continued from 20)
        hundredCommonTreasures_text.text = "100 Обычных сокровищ выброшено из сундуков"; hundredCommonTreasures_text.font = russianNono_MediumOutLine; hundredCommonTreasures_text.fontSize = 22;
        hundredUncommonTreasures_text.text = "100 Необычных сокровищ выброшено из сундуков"; hundredUncommonTreasures_text.font = russianNono_MediumOutLine; hundredUncommonTreasures_text.fontSize = 22;
        hundredRareTreasures_text.text = "100 Редких сокровищ выброшено из сундуков"; hundredRareTreasures_text.font = russianNono_MediumOutLine; hundredRareTreasures_text.fontSize = 22;
        hundredVeryRareTreasures_text.text = "100 Очень редких сокровищ выброшено из сундуков"; hundredVeryRareTreasures_text.font = russianNono_MediumOutLine; hundredVeryRareTreasures_text.fontSize = 22;
        hundredExtremelyRareTreasures_text.text = "100 Чрезвычайно редких сокровищ выброшено из сундуков"; hundredExtremelyRareTreasures_text.font = russianNono_MediumOutLine; hundredExtremelyRareTreasures_text.fontSize = 24;
        hundredLegendaryTreasures_text.text = "100 Легендарных сокровищ выброшено из сундуков"; hundredLegendaryTreasures_text.font = russianNono_MediumOutLine; hundredLegendaryTreasures_text.fontSize = 24;
        spawn10TreasuresFromClicks_text.text = "Появить 10 сокровищ от кликов"; spawn10TreasuresFromClicks_text.font = russianNono_MediumOutLine; spawn10TreasuresFromClicks_text.fontSize = 24;
        spawn100TreasuresFromClicks_text.text = "Появить 100 сокровищ от кликов"; spawn100TreasuresFromClicks_text.font = russianNono_MediumOutLine; spawn100TreasuresFromClicks_text.fontSize = 24;
        spawn1000TreasuresFromClicks_text.text = "Появить 1000 сокровищ от кликов"; spawn1000TreasuresFromClicks_text.font = russianNono_MediumOutLine; spawn1000TreasuresFromClicks_text.fontSize = 24;
        hundredTreasuresDoubled_text.text = "100 Сокровищ удвоены в стоимости"; hundredTreasuresDoubled_text.font = russianNono_MediumOutLine; hundredTreasuresDoubled_text.fontSize = 24;

        //40 (Continued from 30)
        find1RareTreasure_text.text = "Найти 1 редкое сокровище"; find1RareTreasure_text.font = russianNono_MediumOutLine; find1RareTreasure_text.fontSize = 24;
        find3RareTreasures_text.text = "Найти 3 редких сокровища"; find3RareTreasures_text.font = russianNono_MediumOutLine; find3RareTreasures_text.fontSize = 24;
        find5RareTreasures_text.text = "Найти 5 редких сокровищ"; find5RareTreasures_text.font = russianNono_MediumOutLine; find5RareTreasures_text.fontSize = 24;
        find13RareTreasures_text.text = "Найти 13 редких сокровищ"; find13RareTreasures_text.font = russianNono_MediumOutLine; find13RareTreasures_text.fontSize = 24;
        findAll25RareTreasures_text.text = "Найти все 25 редких сокровищ"; findAll25RareTreasures_text.font = russianNono_MediumOutLine; findAll25RareTreasures_text.fontSize = 24;
        findTheCookie_text.text = "Найти печеньку!"; findTheCookie_text.font = russianNono_MediumOutLine; findTheCookie_text.fontSize = 24;
        cookieClicker_text.text = "Кликер печенек!"; cookieClicker_text.font = russianNono_MediumOutLine; cookieClicker_text.fontSize = 24;
        prestige_text.text = "Престиж"; prestige_text.font = russianNono_MediumOutLine; prestige_text.fontSize = 24;
        prestige5Times_text.text = "Достигнуть престижа 5 раз"; prestige5Times_text.font = russianNono_MediumOutLine; prestige5Times_text.fontSize = 24;
        prestige15Times_text.text = "Достигнуть престижа 15 раз"; prestige15Times_text.font = russianNono_MediumOutLine; prestige15Times_text.fontSize = 24;

        //50 (Continued from 40)
        purchase5PrestigeUpgrades_text.text = "Купить 5 улучшений престижа"; purchase5PrestigeUpgrades_text.font = russianNono_MediumOutLine; purchase5PrestigeUpgrades_text.fontSize = 24;
        purchase15PrestigeUpgrades_text.text = "Купить 15 улучшений престижа"; purchase15PrestigeUpgrades_text.font = russianNono_MediumOutLine; purchase15PrestigeUpgrades_text.fontSize = 24;
        purchase35PrestigeUpgrades_text.text = "Купить 35 улучшений престижа"; purchase35PrestigeUpgrades_text.font = russianNono_MediumOutLine; purchase35PrestigeUpgrades_text.fontSize = 24;
        purchase60PrestigeUpgrades_text.text = "Купить 60 улучшений престижа"; purchase60PrestigeUpgrades_text.font = russianNono_MediumOutLine; purchase60PrestigeUpgrades_text.fontSize = 24;
        purchaseAllPrestigeUpgrades_text.text = "Купить ВСЕ улучшения престижа"; purchaseAllPrestigeUpgrades_text.font = russianNono_MediumOutLine; purchaseAllPrestigeUpgrades_text.fontSize = 24;
        purchaseAllPrestigeClickerUpgrades_text.text = "Купить ВСЕ улучшения престижа CLICKER"; purchaseAllPrestigeClickerUpgrades_text.font = russianNono_MediumOutLine; purchaseAllPrestigeClickerUpgrades_text.fontSize = 24;
        purchaseAllPrestigeLoungerUpgrades_text.text = "Купить ВСЕ улучшения престижа LOUNGER"; purchaseAllPrestigeLoungerUpgrades_text.font = russianNono_MediumOutLine; purchaseAllPrestigeLoungerUpgrades_text.fontSize = 24;
        purchaseAllPrestigePirateUpgrades_text.text = "Купить ВСЕ улучшения престижа PIRATE"; purchaseAllPrestigePirateUpgrades_text.font = russianNono_MediumOutLine; purchaseAllPrestigePirateUpgrades_text.fontSize = 24;
        purchaseAllPrestigeHoarderUpgrades_text.text = "Купить ВСЕ улучшения престижа HOARDER"; purchaseAllPrestigeHoarderUpgrades_text.font = russianNono_MediumOutLine; purchaseAllPrestigeHoarderUpgrades_text.fontSize = 24;
        purchaseAllPrestigeAdventurerUpgrades_text.text = "Купить ВСЕ улучшения престижа ADVENTURER"; purchaseAllPrestigeAdventurerUpgrades_text.font = russianNono_MediumOutLine; purchaseAllPrestigeAdventurerUpgrades_text.fontSize = 24;

        //60 (Continued from 50)
        purchaseLootPotion_text.text = "Купить зелье добычи"; purchaseLootPotion_text.font = russianNono_MediumOutLine; purchaseLootPotion_text.fontSize = 24;
        purchaseGoldenTouch_text.text = "Купить золотой прикосновение"; purchaseGoldenTouch_text.font = russianNono_MediumOutLine; purchaseGoldenTouch_text.fontSize = 24;
        purchaseSerendipityScroll_text.text = "Купить свиток удачи"; purchaseSerendipityScroll_text.font = russianNono_MediumOutLine; purchaseSerendipityScroll_text.fontSize = 24;
        purchaseKey_text.text = "Купить ключ"; purchaseKey_text.font = russianNono_MediumOutLine; purchaseKey_text.fontSize = 24;
        purchaseMagicalElixir_text.text = "Купить магический эликсир"; purchaseMagicalElixir_text.font = russianNono_MediumOutLine; purchaseMagicalElixir_text.fontSize = 24;
        purchaseAncientRelic_text.text = "Купить древний реликварий"; purchaseAncientRelic_text.font = russianNono_MediumOutLine; purchaseAncientRelic_text.fontSize = 24;
        purchaseEnchantedHammer_text.text = "Купить Зачарованный Молот"; purchaseEnchantedHammer_text.font = russianNono_MediumOutLine; purchaseEnchantedHammer_text.fontSize = 24;
        openChest_text.text = "Открыть сундук"; openChest_text.font = russianNono_MediumOutLine; openChest_text.fontSize = 24;
        open100Chests_text.text = "Открыть 100 сундуков"; open100Chests_text.font = russianNono_MediumOutLine; open100Chests_text.fontSize = 24;
        open1000Chests_text.text = "Открыть 1000 сундуков"; open1000Chests_text.font = russianNono_MediumOutLine; open1000Chests_text.fontSize = 24;

        //70 (Continued from 60)
        open10000Chests_text.text = "Открыть 10 000 сундуков"; open10000Chests_text.font = russianNono_MediumOutLine; open10000Chests_text.fontSize = 24;
        open100000Chests_text.text = "Открыть 100 000 сундуков"; open100000Chests_text.font = russianNono_MediumOutLine; open100000Chests_text.fontSize = 24;
        open200000Chests_text.text = "Открыть 200 000 сундуков"; open200000Chests_text.font = russianNono_MediumOutLine; open200000Chests_text.fontSize = 24;
        purchaseChestNo2_text.text = "Купить сундук №2"; purchaseChestNo2_text.font = russianNono_MediumOutLine; purchaseChestNo2_text.fontSize = 24;
        purchaseChestNo5_text.text = "Купить сундук №5"; purchaseChestNo5_text.font = russianNono_MediumOutLine; purchaseChestNo5_text.fontSize = 24;
        purchaseChestNo8_text.text = "Купить сундук №8"; purchaseChestNo8_text.font = russianNono_MediumOutLine; purchaseChestNo8_text.fontSize = 24;
        purchaseChestNo12_text.text = "Купить сундук №12"; purchaseChestNo12_text.font = russianNono_MediumOutLine; purchaseChestNo12_text.fontSize = 24;
        purchaseChestNo15_text.text = "Купить сундук №15"; purchaseChestNo15_text.font = russianNono_MediumOutLine; purchaseChestNo15_text.fontSize = 24;
        purchaseChestNo20_text.text = "Купить сундук №20"; purchaseChestNo20_text.font = russianNono_MediumOutLine; purchaseChestNo20_text.fontSize = 24;
        purchaseChestNo24_text.text = "Купить сундук №24"; purchaseChestNo24_text.font = russianNono_MediumOutLine; purchaseChestNo24_text.fontSize = 24;

        //80 (Continued from 70)
        purchaseChestNo32_text.text = "Купить сундук №32"; purchaseChestNo32_text.font = russianNono_MediumOutLine; purchaseChestNo32_text.fontSize = 24;
        purchaseTheFinalChest_text.text = "Купить финальный сундук"; purchaseTheFinalChest_text.font = russianNono_MediumOutLine; purchaseTheFinalChest_text.fontSize = 24;
        openTheFinalChest_text.text = "Открыть финальный сундук"; openTheFinalChest_text.font = russianNono_MediumOutLine; openTheFinalChest_text.fontSize = 24;
        openAReinforcedChest_text.text = "Открыть усиленный сундук"; openAReinforcedChest_text.font = russianNono_MediumOutLine; openAReinforcedChest_text.fontSize = 24;
        open100ReinforcedChests_text.text = "Открыть 100 усиленных сундуков"; open100ReinforcedChests_text.font = russianNono_MediumOutLine; open100ReinforcedChests_text.fontSize = 24;
        open500ReinforcedChests_text.text = "Открыть 500 усиленных сундуков"; open500ReinforcedChests_text.font = russianNono_MediumOutLine; open500ReinforcedChests_text.fontSize = 24;
        open1000ReinforcedChests_text.text = "Открыть 1000 усиленных сундуков"; open1000ReinforcedChests_text.font = russianNono_MediumOutLine; open1000ReinforcedChests_text.fontSize = 24;
        open100EnchantedGoldenChests_text.text = "Открыть 100 Зачарованных Золотых Сундуков"; open100EnchantedGoldenChests_text.font = russianNono_MediumOutLine; open100EnchantedGoldenChests_text.fontSize = 24;
        open100BossChests_text.text = "Открыть 100 Сундуков Босса"; open100BossChests_text.font = russianNono_MediumOutLine; open100BossChests_text.fontSize = 24;
        receiveTotal50SkillPoints_text.text = "Получить всего 50 очков навыков"; receiveTotal50SkillPoints_text.font = russianNono_MediumOutLine; receiveTotal50SkillPoints_text.fontSize = 24;

        //90 (Continued from 80)
        receiveTotal500SkillPoints_text.text = "Получить всего 500 очков навыков"; receiveTotal500SkillPoints_text.font = russianNono_MediumOutLine; receiveTotal500SkillPoints_text.fontSize = 24;
        receiveTotal1000SkillPoints_text.text = "Получить всего 1000 очков навыков"; receiveTotal1000SkillPoints_text.font = russianNono_MediumOutLine; receiveTotal1000SkillPoints_text.fontSize = 24;
        receiveTotal10000SkillPoints_text.text = "Получить всего 10000 очков навыков"; receiveTotal10000SkillPoints_text.font = russianNono_MediumOutLine; receiveTotal10000SkillPoints_text.fontSize = 24;
        reachLevel10_text.text = "Достигнуть 10 уровня"; reachLevel10_text.font = russianNono_MediumOutLine; reachLevel10_text.fontSize = 24;
        reachLevel25_text.text = "Достигнуть 25 уровня"; reachLevel25_text.font = russianNono_MediumOutLine; reachLevel25_text.fontSize = 24;
        reachLevel50_text.text = "Достигнуть 50 уровня"; reachLevel50_text.font = russianNono_MediumOutLine; reachLevel50_text.fontSize = 24;
        reachLevel100_text.text = "Достигнуть 100 уровня"; reachLevel100_text.font = russianNono_MediumOutLine; reachLevel100_text.fontSize = 24;
        reachLevel200_text.text = "Достигнуть 200 уровня"; reachLevel200_text.font = russianNono_MediumOutLine; reachLevel200_text.fontSize = 24;
        drop1000_25XGoldCoins_text.text = "Выбросить 1000, 25X золотых монет"; drop1000_25XGoldCoins_text.font = russianNono_MediumOutLine; drop1000_25XGoldCoins_text.fontSize = 24;
        drop2MillionGoldCoins_text.text = "Выбросить 2 миллиона золотых монет"; drop2MillionGoldCoins_text.font = russianNono_MediumOutLine; drop2MillionGoldCoins_text.fontSize = 24;

        //100 (Continued from 90)
        drop100XGoldCoin_text.text = "Выбросить 100X золотую монету"; drop100XGoldCoin_text.font = russianNono_MediumOutLine; drop100XGoldCoin_text.fontSize = 24;
        haveTotal1UndecillionGold_text.text = "Иметь всего 1 андециллион золота"; haveTotal1UndecillionGold_text.font = russianNono_MediumOutLine; haveTotal1UndecillionGold_text.fontSize = 24;
        haveTotal1DuodecillionGold_text.text = "Иметь всего 1 дуодециллион золота"; haveTotal1DuodecillionGold_text.font = russianNono_MediumOutLine; haveTotal1DuodecillionGold_text.fontSize = 24;
        haveTotal1TredecillionGold_text.text = "Иметь всего 1 тредециллион золота"; haveTotal1TredecillionGold_text.font = russianNono_MediumOutLine; haveTotal1TredecillionGold_text.fontSize = 24;
        haveTotal1QuattuordecillionGold_text.text = "Иметь всего 1 кваттуордециллион золота"; haveTotal1QuattuordecillionGold_text.font = russianNono_MediumOutLine; haveTotal1QuattuordecillionGold_text.fontSize = 24;
        haveTotal1QuindecillionGold_text.text = "Иметь всего 1 квиндециллион золота"; haveTotal1QuindecillionGold_text.font = russianNono_MediumOutLine; haveTotal1QuindecillionGold_text.fontSize = 24;
        haveTotal1SexdecillionGold_text.text = "Иметь всего 1 сексдециллион золота"; haveTotal1SexdecillionGold_text.font = russianNono_MediumOutLine; haveTotal1SexdecillionGold_text.fontSize = 24;
        haveTotal1SeptendecillionGold_text.text = "Иметь всего 1 септендециллион золота"; haveTotal1SeptendecillionGold_text.font = russianNono_MediumOutLine; haveTotal1SeptendecillionGold_text.fontSize = 24;
        haveTotal1OctodecillionGold_text.text = "Иметь всего 1 октодециллион золота"; haveTotal1OctodecillionGold_text.font = russianNono_MediumOutLine; haveTotal1OctodecillionGold_text.fontSize = 24;
        reachLevel150_text.text = "Достигнуть 150 уровня"; reachLevel150_text.font = russianNono_MediumOutLine; reachLevel150_text.fontSize = 24;

        //110 (Continued from 100)
        receiveTotal20000SkillPoints_text.text = "Получить всего 20000 очков навыков"; receiveTotal20000SkillPoints_text.font = russianNono_MediumOutLine; receiveTotal20000SkillPoints_text.fontSize = 24;
        chestsHaveDropped100KTreasures_text.text = "Из сундуков выпало 100K сокровищ"; chestsHaveDropped100KTreasures_text.font = russianNono_MediumOutLine; chestsHaveDropped100KTreasures_text.fontSize = 24;
        hundredUltraTreasuresDropped_text.text = "100 Ультра сокровищ выпало из сундуков"; hundredUltraTreasuresDropped_text.font = russianNono_MediumOutLine; hundredUltraTreasuresDropped_text.fontSize = 24;
        hundredMythicTreasuresDropped_text.text = "100 Мифических сокровищ выпало из сундуков"; hundredMythicTreasuresDropped_text.font = russianNono_MediumOutLine; hundredMythicTreasuresDropped_text.fontSize = 24;
        hundredEternalTreasuresDropped_text.text = "100 Вечных сокровищ выпало из сундуков"; hundredEternalTreasuresDropped_text.font = russianNono_MediumOutLine; hundredEternalTreasuresDropped_text.fontSize = 24;
        open2500ReinforcedChests_text.text = "Открыть 2500 усиленных сундуков"; open2500ReinforcedChests_text.font = russianNono_MediumOutLine; open2500ReinforcedChests_text.fontSize = 24;
        purchaseChestNo37_text.text = "Купить сундук №37"; purchaseChestNo37_text.font = russianNono_MediumOutLine; purchaseChestNo37_text.fontSize = 24;
        useTheChicken_text.text = "Использовать курицу"; useTheChicken_text.font = russianNono_MediumOutLine; useTheChicken_text.fontSize = 24;
        drop250000_5XGoldCoins_text.text = "Выбросить 250000, 5X золотых монет"; drop250000_5XGoldCoins_text.font = russianNono_MediumOutLine; drop250000_5XGoldCoins_text.fontSize = 24;
        #endregion

        #region Cursors
        // Cursors - Cursors Hover Text
        for (int i = 0; i < 21; i++)
        {
            levelUp_text[i].text = "УЛУЧШЕНИЕ"; levelUp_text[i].font = russian_SemiBold; levelUp_text[i].fontSize = 21;
            if (PlaceMobileButtons.isMobile == true) { levelUp_text[i].fontSize = 15.5f; }
        }

        // Cursors - Others
        cursor1PassiveDamage_Text.text = "+0% Пассивного Урона"; cursor1PassiveDamage_Text.font = robotoBold; cursor1PassiveDamage_Text.fontSize = 20;
        cursor1CritChance_Text.text = "+0% Шанс Крита"; cursor1CritChance_Text.font = robotoBold; cursor1CritChance_Text.fontSize = 20;
        cursor1CritDamage_Text.text = "+0% Урон Крита"; cursor1CritDamage_Text.font = robotoBold; cursor1CritDamage_Text.fontSize = 20;

        // Cursors - Cursor 2
        cursor2ActiveDamage_Text.text = "+0% Активного Урона"; cursor2ActiveDamage_Text.font = robotoBold; cursor2ActiveDamage_Text.fontSize = 20;
        cursor2CritChance_Text.text = "+0% Шанс Крита"; cursor2CritChance_Text.font = robotoBold; cursor2CritChance_Text.fontSize = 20;
        cursor2CritDamage_Text.text = "+0% Урон Крита"; cursor2CritDamage_Text.font = robotoBold; cursor2CritDamage_Text.fontSize = 20;

        // Cursors - Cursor 3
        cursor3ActiveDamage_Text.text = "+0% Активного Урона"; cursor3ActiveDamage_Text.font = robotoBold; cursor3ActiveDamage_Text.fontSize = 20;
        cursor3PassiveDamage_Text.text = "+0% Пассивного Урона"; cursor3PassiveDamage_Text.font = robotoBold; cursor3PassiveDamage_Text.fontSize = 20;

        // Cursors - Cursor 4
        cursor4CritChance_Text.text = "+0% Шанс Крита"; cursor4CritChance_Text.font = robotoBold; cursor4CritChance_Text.fontSize = 20;
        cursor4CritDamage_Text.text = "+0% Урон Крита"; cursor4CritDamage_Text.font = robotoBold; cursor4CritDamage_Text.fontSize = 20;

        // Cursors - Cursor 5
        cursor5PassiveDamage_Text.text = "+0% Пассивного Урона"; cursor5PassiveDamage_Text.font = robotoBold; cursor5PassiveDamage_Text.fontSize = 20;

        // Cursors - Cursor 7
        cursor7PassiveDamage_Text.text = "+0% Пассивного Урона"; cursor7PassiveDamage_Text.font = robotoBold; cursor7PassiveDamage_Text.fontSize = 20;

        // Cursors - Cursor 9
        cursor9CritChance_Text.text = "+0% Шанс Крита"; cursor9CritChance_Text.font = robotoBold; cursor9CritChance_Text.fontSize = 20;
        cursor9CritDamage_Text.text = "+0% Урон Крита"; cursor9CritDamage_Text.font = robotoBold; cursor9CritDamage_Text.fontSize = 20;

        // Cursors - Cursor 10
        cursor10ActiveDamage_Text.text = "+0% Активного Урона"; cursor10ActiveDamage_Text.font = robotoBold; cursor10ActiveDamage_Text.fontSize = 20;
        cursor10CritChance_Text.text = "+0% Шанс Крита"; cursor10CritChance_Text.font = robotoBold; cursor10CritChance_Text.fontSize = 20;
        cursor10CritDamage_Text.text = "+0% Урон Крита"; cursor10CritDamage_Text.font = robotoBold; cursor10CritDamage_Text.fontSize = 20;

        // Cursors - Cursor 11
        cursor11PassiveDamage_Text.text = "+0% Пассивного Урона"; cursor11PassiveDamage_Text.font = robotoBold; cursor11PassiveDamage_Text.fontSize = 20;


        cursors_text.text = "КУРСОРЫ"; cursors_text.font = russian_SemiBold; cursors_text.fontSize = 55;
        cursorsHover_text.text = "КУРСОРЫ"; cursorsHover_text.font = russian_SemiBold; cursorsHover_text.fontSize = 37;
        onlyOneCursorEquipped_text.text = "-Можно экипировать только 1 курсор"; onlyOneCursorEquipped_text.font = russianNono_SemiSkinny; onlyOneCursorEquipped_text.fontSize = 21.5f;
        equipCursorFitsPlaystyle_text.text = "-Экипируйте курсор, который подходит вашему стилю игры"; equipCursorFitsPlaystyle_text.font = russianNono_SemiSkinny; equipCursorFitsPlaystyle_text.fontSize = 16f;
        uniqueCursorBonus_text.text = "-У каждого курсора есть уникальный бонус"; uniqueCursorBonus_text.font = russianNono_SemiSkinny; uniqueCursorBonus_text.fontSize = 21.5f;
        levelUpCursors_text.text = "-Повышайте уровень своих курсоров, тратя свои сокровища"; levelUpCursors_text.font = russianNono_SemiSkinny; levelUpCursors_text.fontSize = 20f;

        gentleTap_text.text = "ЛЕГКОЕ КАСАНИЕ"; gentleTap_text.font = russian_SemiBold; gentleTap_text.fontSize = 31f;
        if (PlaceMobileButtons.isMobile == true) { gentleTap_text.fontSize = 22; }
        gentleTap2_text.text = "ЛЕГКОЕ КАСАНИЕ"; gentleTap2_text.font = russian_SemiBold; gentleTap2_text.fontSize = 19f;
        gentleTapCursorBonus_text.text = "Бонус курсора:<color=white>  Каждый клик имеет 1% шанс породить 1 золотую монету"; gentleTapCursorBonus_text.font = robotoBold; gentleTapCursorBonus_text.fontSize = 21f;

        relaxedPalm_text.text = "СПОКОЙНАЯ ЛАДОНЬ"; relaxedPalm_text.font = russian_SemiBold; relaxedPalm_text.fontSize = 25f;
        if (PlaceMobileButtons.isMobile == true) { relaxedPalm_text.fontSize = 18; }
        relaxedPalm2_text.text = "СПОКОЙНАЯ ЛАДОНЬ"; relaxedPalm2_text.font = russian_SemiBold; relaxedPalm2_text.fontSize = 16f;
        relaxedPalmCursorBonus_text.text = "Бонус курсора:<color=white>  Каждые 10 открытых сундуков имеют 25% шанс породить 5 золотых монет"; relaxedPalmCursorBonus_text.font = robotoBold; relaxedPalmCursorBonus_text.fontSize = 21f;

        galeForce_text.text = "ШТОРМОВАЯ СИЛА"; galeForce_text.font = russian_SemiBold; galeForce_text.fontSize = 28f;
        if (PlaceMobileButtons.isMobile == true) { galeForce_text.fontSize = 20; }
        galeForce2_text.text = "ШТОРМОВАЯ СИЛА"; galeForce2_text.font = russian_SemiBold; galeForce2_text.fontSize = 18f;
        galeForceCursorBonus_text.text = "Бонус курсора:<color=white>  Каждый раз, когда вы наносите критический удар, есть 25% шанс породить 1 золотую монету"; galeForceCursorBonus_text.font = robotoBold; galeForceCursorBonus_text.fontSize = 21f;

        radiantTouch_text.text = "СВЕТЛОЕ КАСАНИЕ"; radiantTouch_text.font = russian_SemiBold; radiantTouch_text.fontSize = 29f;
        if (PlaceMobileButtons.isMobile == true) { radiantTouch_text.fontSize = 20; }
        radiantTouch2_text.text = "СВЕТЛОЕ КАСАНИЕ"; radiantTouch2_text.font = russian_SemiBold; radiantTouch2_text.fontSize = 18f;
        radiantTouchCursorBonus_text.text = "Бонус курсора:<color=white>  Порождает 7 золотых монет за каждые 35 открытых сундуков"; radiantTouchCursorBonus_text.font = robotoBold; radiantTouchCursorBonus_text.fontSize = 21f;

        energySurge_text.text = "ПОТОК ЭНЕРГИИ"; energySurge_text.font = russian_SemiBold; energySurge_text.fontSize = 32f;
        if (PlaceMobileButtons.isMobile == true) { energySurge_text.fontSize = 23; }
        energySurge2_text.text = "ПОТОК ЭНЕРГИИ"; energySurge2_text.font = russian_SemiBold; energySurge2_text.fontSize = 19f;
        energySurgeCursorBonus_text.text = "Бонус курсора:<color=white>  Каждое сокровище получает +0,1% шанса на выпадение"; energySurgeCursorBonus_text.font = robotoBold; energySurgeCursorBonus_text.fontSize = 21f;

        phantomPalm_text.text = "ПРИЗРАЧНАЯ ЛАДОНЬ"; phantomPalm_text.font = russian_SemiBold; phantomPalm_text.fontSize = 25f;
        if (PlaceMobileButtons.isMobile == true) { phantomPalm_text.fontSize = 18; }
        phantomPalm2_text.text = "ПРИЗРАЧНАЯ ЛАДОНЬ"; phantomPalm2_text.font = russian_SemiBold; phantomPalm2_text.fontSize = 15f;
        phantomPalmCursorBonus_text.text = "Бонус курсора: <color=white> Каждый критический удар имеет 7% шанс породить сокровище. Каждое сокровище имеет 3% шанса удвоиться в стоимости"; phantomPalmCursorBonus_text.font = robotoBold; phantomPalmCursorBonus_text.fontSize = 21f;

        steelStrike_text.text = "СТАЛЬНОЙ УДАР"; steelStrike_text.font = russian_SemiBold; steelStrike_text.fontSize = 33f;
        if (PlaceMobileButtons.isMobile == true) { steelStrike_text.fontSize = 24; }
        steelStrike2_text.text = "СТАЛЬНОЙ УДАР"; steelStrike2_text.font = russian_SemiBold; steelStrike2_text.fontSize = 19f;
        steelStrikeCursorBonus_text.text = "Бонус курсора:<color=white>  +5% больше золота. +5% больше опыта"; steelStrikeCursorBonus_text.font = robotoBold; steelStrikeCursorBonus_text.fontSize = 21f;

        lethalTouch_text.text = "СМЕРТЕЛЬНОЕ КАСАНИЕ"; lethalTouch_text.font = russian_SemiBold; lethalTouch_text.fontSize = 22f;
        if (PlaceMobileButtons.isMobile == true) { lethalTouch_text.fontSize = 16; }
        lethalTouch2_text.text = "СМЕРТЕЛЬНОЕ КАСАНИЕ"; lethalTouch2_text.font = russian_SemiBold; lethalTouch2_text.fontSize = 14f;
        lethalTouchCursorBonus_text.text = "Бонус курсора: <color=white> Каждый раз при открытии сундука есть 6% шанс получить двойной опыт"; lethalTouchCursorBonus_text.font = robotoBold; lethalTouchCursorBonus_text.fontSize = 21f;

        precisionPoint_text.text = "ТОЧКА ТОЧНОСТИ"; precisionPoint_text.font = russian_SemiBold; precisionPoint_text.fontSize = 30f;
        if (PlaceMobileButtons.isMobile == true) { precisionPoint_text.fontSize = 21; }
        precisionPoint2_text.text = "ТОЧКА ТОЧНОСТИ"; precisionPoint2_text.font = russian_SemiBold; precisionPoint2_text.fontSize = 18f;
        precisionPointCursorBonus_text.text = "Бонус курсора:<color=white>  Каждое выпавшее сокровище имеет +7% шанса удвоиться в стоимости"; precisionPointCursorBonus_text.font = robotoBold; precisionPointCursorBonus_text.fontSize = 21f;

        vortexTap_text.text = "ВОРТЕКСНЫЙ ТАП"; vortexTap_text.font = russian_SemiBold; vortexTap_text.fontSize = 30f;
        if (PlaceMobileButtons.isMobile == true) { vortexTap_text.fontSize = 22; }
        vortexTap2_text.text = "ВОРТЕКСНЫЙ ТАП"; vortexTap2_text.font = russian_SemiBold; vortexTap2_text.fontSize = 19f;
        vortexTapCursorBonus_text.text = "Бонус курсора:<color=white>  Каждые 25 открытых сундуков породят 1 сокровище и дадут тройной опыт"; vortexTapCursorBonus_text.font = robotoBold; vortexTapCursorBonus_text.fontSize = 21f;

        cursedClaw_text.text = "ПРОКЛЯТЫЙ КОГОТЬ"; cursedClaw_text.font = russian_SemiBold; cursedClaw_text.fontSize = 26f;
        if (PlaceMobileButtons.isMobile == true) { cursedClaw_text.fontSize = 19; }
        cursedClaw2_text.text = "ПРОКЛЯТЫЙ КОГОТЬ"; cursedClaw2_text.font = russian_SemiBold; cursedClaw2_text.fontSize = 16f;
        cursedClawCursorBonus_text.text = "Бонус курсора:<color=white>  Каждый раз, когда наносится критический удар, есть 30% шанс породить золотую монету и 3% шанс породить сокровище"; cursedClawCursorBonus_text.font = robotoBold; cursedClawCursorBonus_text.fontSize = 21f;

        sniperClick_text.text = "СНАЙПЕРСКИЙ КЛИК"; sniperClick_text.font = russian_SemiBold; sniperClick_text.fontSize = 25f;
        if (PlaceMobileButtons.isMobile == true) { sniperClick_text.fontSize = 18; }
        sniperClick2_text.text = "СНАЙПЕРСКИЙ КЛИК"; sniperClick2_text.font = russian_SemiBold; sniperClick2_text.fontSize = 16f;
        sniperClickCursorBonus_text.text = "Бонус курсора:<color=white>  10% больше золота и 15% больше опыта"; sniperClickCursorBonus_text.font = robotoBold; sniperClickCursorBonus_text.fontSize = 21f;

        shadowSurge_text.text = "ТЕНЕВОЙ ПОТОК"; shadowSurge_text.font = russian_SemiBold; shadowSurge_text.fontSize = 26f;
        if (PlaceMobileButtons.isMobile == true) { shadowSurge_text.fontSize = 23; }
        shadowSurge2_text.text = "ТЕНЕВОЙ ПОТОК"; shadowSurge2_text.font = russian_SemiBold; shadowSurge2_text.fontSize = 20f;
        shadowSurgeCursorBonus_text.text = "Бонус курсора:<color=white>  Каждый критический удар породит 1 золотую монету"; shadowSurgeCursorBonus_text.font = robotoBold; shadowSurgeCursorBonus_text.fontSize = 21f;

        cripplingCrush_text.text = "ПАРАЛИЗУЮЩИЙ УДАР"; cripplingCrush_text.font = russian_SemiBold; cripplingCrush_text.fontSize = 23f;
        if (PlaceMobileButtons.isMobile == true) { cripplingCrush_text.fontSize = 16; }
        cripplingCrush2_text.text = "ПАРАЛИЗУЮЩИЙ УДАР"; cripplingCrush2_text.font = russian_SemiBold; cripplingCrush2_text.fontSize = 14f;
        cripplingCrushCursorBonus_text.text = "Бонус курсора:<color=white>  Каждый раз, когда вы получаете сокровище, есть 25% шанс удвоить его стоимость"; cripplingCrushCursorBonus_text.font = robotoBold; cripplingCrushCursorBonus_text.fontSize = 21f;

        rapidClick_text.text = "БЫСТРЫЙ КЛИК"; rapidClick_text.font = russian_SemiBold; rapidClick_text.fontSize = 29f;
        if (PlaceMobileButtons.isMobile == true) { rapidClick_text.fontSize = 24; }
        rapidClick2_text.text = "БЫСТРЫЙ КЛИК"; rapidClick2_text.font = russian_SemiBold; rapidClick2_text.fontSize = 19f;
        rapidClickCursorBonus_text.text = "Бонус курсора: <color=white> Каждый критический удар имеет 13% шанс породить сокровище"; rapidClickCursorBonus_text.font = robotoBold; rapidClickCursorBonus_text.fontSize = 21f;

        celestialTouch_text.text = "НЕБЕСНОЕ КАСАНИЕ"; celestialTouch_text.font = russian_SemiBold; celestialTouch_text.fontSize = 26f;
        if (PlaceMobileButtons.isMobile == true) { celestialTouch_text.fontSize = 19; }
        celestialTouch2_text.text = "НЕБЕСНОЕ КАСАНИЕ"; celestialTouch2_text.font = russian_SemiBold; celestialTouch2_text.fontSize = 17f;
        celestialTouchCursorBonus_text.text = "Бонус курсора: <color=white> Опыт удваивается"; celestialTouchCursorBonus_text.font = robotoBold; celestialTouchCursorBonus_text.fontSize = 21f;

        arcaneClick_text.text = "ТАИНСТВЕННЫЙ КЛИК"; arcaneClick_text.font = russian_SemiBold; arcaneClick_text.fontSize = 21f;
        if (PlaceMobileButtons.isMobile == true) { arcaneClick_text.fontSize = 17; }
        arcaneClick2_text.text = "ТАИНСТВЕННЫЙ КЛИК"; arcaneClick2_text.font = russian_SemiBold; arcaneClick2_text.fontSize = 15f;
        arcaneClickCursorBonus_text.text = "Бонус курсора:<color=white>  Стоимость каждого сокровища удваивается"; arcaneClickCursorBonus_text.font = robotoBold; arcaneClickCursorBonus_text.fontSize = 21f;

        eternalTouch_text.text = "ВЕЧНОЕ КАСАНИЕ"; eternalTouch_text.font = russian_SemiBold; eternalTouch_text.fontSize = 29f;
        if (PlaceMobileButtons.isMobile == true) { eternalTouch_text.fontSize = 23; }
        eternalTouch2_text.text = "ВЕЧНОЕ КАСАНИЕ"; eternalTouch2_text.font = russian_SemiBold; eternalTouch2_text.fontSize = 18f;
        eternalTouchCursorBonus_text.text = "Бонус курсора:<color=white>  Опыт и сокровища удваиваются. 5% шанс получить золотую монету каждый клик"; eternalTouchCursorBonus_text.font = robotoBold; eternalTouchCursorBonus_text.fontSize = 21f;

        doomTouch_text.text = "КАСАНИЕ РОКА"; doomTouch_text.font = russian_SemiBold; doomTouch_text.fontSize = 28f;
        if (PlaceMobileButtons.isMobile == true) { doomTouch_text.fontSize = 24; }
        doomTouch2_text.text = "КАСАНИЕ РОКА"; doomTouch2_text.font = russian_SemiBold; doomTouch2_text.fontSize = 23f;
        doomTouchCursorBonus_text.text = "Бонус курсора: <color=white> Немного меньший шанс на выпадение редких сокровищ."; doomTouchCursorBonus_text.font = robotoBold; doomTouchCursorBonus_text.fontSize = 21f;

        solarSweep_text.text = "СОЛНЕЧНЫЙ РАЗМЕТ"; solarSweep_text.font = russian_SemiBold; solarSweep_text.fontSize = 25f;
        if (PlaceMobileButtons.isMobile == true) { solarSweep_text.fontSize = 19; }
        solarSweep2_text.text = "СОЛНЕЧНЫЙ РАЗМЕТ"; solarSweep2_text.font = russian_SemiBold; solarSweep2_text.fontSize = 16f;
        solarSweepCursorBonus_text.text = "Бонус курсора:<color=white>  +2,5% шанса удвоить награды из сундуков"; solarSweepCursorBonus_text.font = robotoBold; solarSweepCursorBonus_text.fontSize = 21f;

        infernoFist_text.text = "ИНФЕРНАЛЬНЫЙ КУЛАК"; infernoFist_text.font = russian_SemiBold; infernoFist_text.fontSize = 22f;
        if (PlaceMobileButtons.isMobile == true) { infernoFist_text.fontSize = 17; }
        infernoFist2_text.text = "ИНФЕРНАЛЬНЫЙ КУЛАК"; infernoFist2_text.font = russian_SemiBold; infernoFist2_text.fontSize = 14f;
        infernoFistCursorBonus_text.text = "Бонус курсора:<color=white>  Опыт удваивается. Стоимость каждого сокровища удваивается. 4% Шанса удвоить золото."; infernoFistCursorBonus_text.font = robotoBold; infernoFistCursorBonus_text.fontSize = 21f;

        locked_text.text = "ЗАБЛОКИРОВАНО"; locked_text.font = russian_SemiBold; locked_text.fontSize = 21f;
        unlockedAfterChest_text.text = "РАЗБЛОКИРОВАНО ПОСЛЕ ПОКУПКИ"; unlockedAfterChest_text.font = russianNono_Bold; unlockedAfterChest_text.fontSize = 36f;

        #endregion

        #region Shop And Items

        for (int i = 0; i < 17; i++)
        {
            itemsLevelUp_text[i].text = "УЛУЧШЕНИЕ"; itemsLevelUp_text[i].font = russian_SemiBold; itemsLevelUp_text[i].fontSize = 21;
            if (PlaceMobileButtons.isMobile == true) { itemsLevelUp_text[i].fontSize = 16; }
        }

        goldenTouchBuff.text = "<color=yellow>+6-10 ВЫПАДЕНИЕ ЗОЛОТОЙ МОНЕТЫ"; goldenTouchBuff.font = ChangaBoldSDF1; goldenTouchBuff.fontSize = 9;
        treasurePotionBuff_text.text = "+3% ШАНС ВЫПАДЕНИЯ СОКРОВИЩА"; treasurePotionBuff_text.font = russianNonoBoldOutLine; treasurePotionBuff_text.fontSize = 10;

        shop_text.text = "МАГАЗИН"; shop_text.font = russian_SemiBold; shop_text.fontSize = 90;
        shop2_text.text = "МАГАЗИН"; shop2_text.font = russian_SemiBold; shop2_text.fontSize = 37;
        items_text.text = "ПРЕДМЕТЫ"; items_text.font = russian_SemiBold; items_text.fontSize = 50;
        lockpick_text.text = "Отмычка"; lockpick_text.font = russian_SemiBold; lockpick_text.fontSize = 29;
        lockpick2_text.text = "Отмычка"; lockpick2_text.font = russian_SemiBold; lockpick2_text.fontSize = 25;
        lockpickItemBonus_text.text = "Бонус предмета:<color=white>  Есть небольшой шанс, что при открытии сундука отмычкой выпадет сокровище"; lockpickItemBonus_text.font = robotoBold; lockpickItemBonus_text.fontSize = 21;

        hammer_text.text = "МОЛОТ"; hammer_text.font = russian_SemiBold; hammer_text.fontSize = 26;
        if (PlaceMobileButtons.isMobile == true) { hammer_text.fontSize = 24; }
        hammer2_text.text = "МОЛОТ"; hammer2_text.font = russian_SemiBold; hammer2_text.fontSize = 25;
        hammerItemBonus_text.text = "Бонус предмета:<color=white>  Если вы нанесете критический удар, используя молот, с 35% шансом появится 1 золотая монета"; hammerItemBonus_text.font = robotoBold; hammerItemBonus_text.fontSize = 21;

        lootPotion_text.text = "ЗЕЛЬЕ ЛУТА"; lootPotion_text.font = russian_SemiBold; lootPotion_text.fontSize = 25;
        if (PlaceMobileButtons.isMobile == true) { lootPotion_text.fontSize = 23; }
        lootPotion2_text.text = "ЗЕЛЬЕ ЛУТА"; lootPotion2_text.font = russian_SemiBold; lootPotion2_text.fontSize = 25;
        lootPotionItemBonus_text.text = "Бонус предмета:<color=white>  Сокровища, полученные во время действия этого зелья, имеют +5% шанса удвоить свою стоимость"; lootPotionItemBonus_text.font = robotoBold; lootPotionItemBonus_text.fontSize = 21;

        damagePotion_text.text = "ЗЕЛЬЕ УРОНА"; damagePotion_text.font = russian_SemiBold; damagePotion_text.fontSize = 25;
        if (PlaceMobileButtons.isMobile == true) { damagePotion_text.fontSize = 20; }
        damagePotion2_text.text = "ЗЕЛЬЕ УРОНА"; damagePotion2_text.font = russian_SemiBold; damagePotion2_text.fontSize = 25;
        damagePotionItemBonus_text.text = "Бонус предмета:<color=white>  Также дает +2% шанса на крит и +50% урона от крита во время действия"; damagePotionItemBonus_text.font = robotoBold; damagePotionItemBonus_text.fontSize = 21;

        xpPotion_text.text = "ЗЕЛЬЕ ОПЫТА"; xpPotion_text.font = russian_SemiBold; xpPotion_text.fontSize = 25;
        if (PlaceMobileButtons.isMobile == true) { xpPotion_text.fontSize = 20; }
        xpPotion2_text.text = "ЗЕЛЬЕ ОПЫТА"; xpPotion2_text.font = russian_SemiBold; xpPotion2_text.fontSize = 25;
        xpPotionItemBonus_text.text = "Бонус предмета:<color=white>  Каждый раз, когда вы получаете опыт, у вас есть 0.1% шанс получить +1 очко навыка"; xpPotionItemBonus_text.font = robotoBold; xpPotionItemBonus_text.fontSize = 21;

        goldenTouch_text.text = "ЗОЛОТОЕ КАСАНИЕ"; goldenTouch_text.font = russian_SemiBold; goldenTouch_text.fontSize = 19;
        if (PlaceMobileButtons.isMobile == true) { goldenTouch_text.fontSize = 14; }
        goldenTouch2_text.text = "ЗОЛОТОЕ КАСАНИЕ"; goldenTouch2_text.font = russian_SemiBold; goldenTouch2_text.fontSize = 18;
        goldenTouchItemBonus_text.text = "Бонус предмета:<color=white>  Пока Золотое Касание активно, сокровища имеют +10% шанс удвоить свою стоимость"; goldenTouchItemBonus_text.font = robotoBold; goldenTouchItemBonus_text.fontSize = 21;

        miniChest_text.text = "МИНИ СУНДУК"; miniChest_text.font = russian_SemiBold; miniChest_text.fontSize = 25;
        if (PlaceMobileButtons.isMobile == true) { miniChest_text.fontSize = 18; }
        miniChest2_text.text = "МИНИ СУНДУК"; miniChest2_text.font = russian_SemiBold; miniChest2_text.fontSize = 23;
        miniChestUpgradeBonus_text.text = "Бонус улучшения:<color=white>  Мини сундуки будут давать одну из трех возможных наград"; miniChestUpgradeBonus_text.font = robotoBold; miniChestUpgradeBonus_text.fontSize = 21;
        miniChestMaxHover_text.text = "МАКС УРОВЕНЬ"; miniChestMaxHover_text.font = russianNono_Bold; miniChestMaxHover_text.fontSize = 10;

        key_text.text = "КЛЮЧ"; key_text.font = russian_SemiBold; key_text.fontSize = 26;
        key2_text.text = "КЛЮЧ"; key2_text.font = russian_SemiBold; key2_text.fontSize = 25;
        keyInstantlOpens_text.text = "Мгновенно открывает сундук"; keyInstantlOpens_text.font = robotoBold; keyInstantlOpens_text.fontSize = 19;
        keyItemBonus_text.text = "Бонус предмета:<color=white>  Сундуки дают от 2 до 4 дополнительных золотых монет, когда используется ключ"; keyItemBonus_text.font = robotoBold; keyItemBonus_text.fontSize = 21;

        treasureBag_text.text = "МЕШОК С СОКРОВИЩАМИ"; treasureBag_text.font = russian_SemiBold; treasureBag_text.fontSize = 14;
        if (PlaceMobileButtons.isMobile == true) { treasureBag_text.fontSize = 10; }
        treasureBag2_text.text = "МЕШОК С СОКРОВИЩАМИ"; treasureBag2_text.font = russian_SemiBold; treasureBag2_text.fontSize = 13;
        treasureBagDrop_text.text = "Мешки с сокровищами будут давать 2 сокровища"; treasureBagDrop_text.font = robotoBold; treasureBagDrop_text.fontSize = 17;
        treasureBagItemBonus_text.text = "Бонус предмета:<color=white>  Сокровища из любого сундука могут выпасть. Мешки с сокровищами также дают вам 5 капель опыта"; treasureBagItemBonus_text.font = robotoBold; treasureBagItemBonus_text.fontSize = 18;

        serendipityScroll_text.text = "СВИТОК УДАЧИ"; serendipityScroll_text.font = russian_SemiBold; serendipityScroll_text.fontSize = 25;
        if (PlaceMobileButtons.isMobile == true) { serendipityScroll_text.fontSize = 17; }
        serendipityScroll2_text.text = "СВИТОК УДАЧИ"; serendipityScroll2_text.font = russian_SemiBold; serendipityScroll2_text.fontSize = 20;
        serendipityScrollStatsReset_text.text = "Характеристики от свитка удачи будут сброшены при переходе на новый уровень"; serendipityScrollStatsReset_text.font = robotoBold; serendipityScrollStatsReset_text.fontSize = 21;

        gauntletOfGreed_text.text = "РУКАВИЦА АЛЧНОСТИ"; gauntletOfGreed_text.font = russian_SemiBold; gauntletOfGreed_text.fontSize = 18;
        if (PlaceMobileButtons.isMobile == true) { gauntletOfGreed_text.fontSize = 12; }
        gauntletOfGreed2_text.text = "РУКАВИЦА АЛЧНОСТИ"; gauntletOfGreed2_text.font = russian_SemiBold; gauntletOfGreed2_text.fontSize = 15;
        gauntletOfGreenBonus_text.text = "Бонус предмета:<color=white>  3% Шанс создать сокровище каждым кликом"; gauntletOfGreenBonus_text.font = robotoBold; gauntletOfGreenBonus_text.fontSize = 21;

        magicalElixir_text.text = "ВОЛШЕБНЫЙ ЭЛИКСИР"; magicalElixir_text.font = russian_SemiBold; magicalElixir_text.fontSize = 17;
        if (PlaceMobileButtons.isMobile == true) { magicalElixir_text.fontSize = 12; }
        magicalElixir2_text.text = "ВОЛШЕБНЫЙ ЭЛИКСИР"; magicalElixir2_text.font = russian_SemiBold; magicalElixir2_text.fontSize = 14;
        magicalElixirItemBonus_text.text = "Бонус предмета:<color=white>  +0.3% шанс выпадения к каждому сокровищу пока Эликсир активен"; magicalElixirItemBonus_text.font = robotoBold; magicalElixirItemBonus_text.fontSize = 21;

        ancientRelic_text.text = "ДРЕВНЯЯ РЕЛИКВИЯ"; ancientRelic_text.font = russian_SemiBold; ancientRelic_text.fontSize = 18;
        if (PlaceMobileButtons.isMobile == true) { ancientRelic_text.fontSize = 13.5f; }
        ancientRelic2_text.text = "ДРЕВНЯЯ РЕЛИКВИЯ"; ancientRelic2_text.font = russian_SemiBold; ancientRelic2_text.fontSize = 16;
        ancientRelicGivesBuff_text.text = "Дает постоянный бафф на случайную характеристику"; ancientRelicGivesBuff_text.font = robotoBold; ancientRelicGivesBuff_text.fontSize = 22;
        ancientRelicKeepBuff_text.text = "Вы сохраните каждый бафф, полученный от древней реликвии после престижа"; ancientRelicKeepBuff_text.font = robotoBold; ancientRelicKeepBuff_text.fontSize = 21;

        enchantedHammer_text.text = "ЗАЧАРОВАННЫЙ МОЛОТ"; enchantedHammer_text.font = russian_SemiBold; enchantedHammer_text.fontSize = 16;
        if (PlaceMobileButtons.isMobile == true) { enchantedHammer_text.fontSize = 11.5f; }
        enchantedHammer2_text.text = "ЗАЧАРОВАННЫЙ МОЛОТ"; enchantedHammer2_text.font = russian_SemiBold; enchantedHammer2_text.fontSize = 14;
        enchantedHammerItemBonus_text.text = "Бонус предмета:<color=white>  2% Шанс утроить награды с сундука"; enchantedHammerItemBonus_text.font = robotoBold; enchantedHammerItemBonus_text.fontSize = 21;

        treasurePotion_text.text = "ЗЕЛЬЕ СОКРОВИЩ"; treasurePotion_text.font = russian_SemiBold; treasurePotion_text.fontSize = 21;
        if (PlaceMobileButtons.isMobile == true) { treasurePotion_text.fontSize = 14.5f; }
        treasurePotion2_text.text = "ЗЕЛЬЕ СОКРОВИЩ"; treasurePotion2_text.font = russian_SemiBold; treasurePotion2_text.fontSize = 20;
        treasurePotionItemBonus_text.text = "Бонус предмета:<color=white>  Полученные предметы имеют +25% шанс удвоить свою стоимость"; treasurePotionItemBonus_text.font = robotoBold; treasurePotionItemBonus_text.fontSize = 21;

        barrelOfGold_text.text = "БОЧОНОК ЗОЛОТА"; barrelOfGold_text.font = russian_SemiBold; barrelOfGold_text.fontSize = 19;
        if (PlaceMobileButtons.isMobile == true) { barrelOfGold_text.fontSize = 14; }
        barrelOfGold2_text.text = "БОЧОНОК ЗОЛОТА"; barrelOfGold2_text.font = russian_SemiBold; barrelOfGold2_text.fontSize = 20;
        barrelOfGoldBonus_text.text = "Бонус предмета:<color=white>  Выберите, куда поставить бочонок, перетащив его"; barrelOfGoldBonus_text.font = robotoBold; barrelOfGoldBonus_text.fontSize = 21;
        barrelSpawns_text.text = "Появляется бочонок."; barrelSpawns_text.font = robotoBold; barrelSpawns_text.fontSize = 24;
        barrelGoldCoinsInside_text.text = "В бочонке собрано всего:"; barrelGoldCoinsInside_text.font = russianNonoBoldOutLine; barrelGoldCoinsInside_text.fontSize = 10;
        clickToCollect_text.text = "Нажмите, чтобы собрать!"; clickToCollect_text.font = russianNonoBoldOutLine; clickToCollect_text.fontSize = 12;

        mimicChest_text.text = "СУНДУК-МИМИК"; mimicChest_text.font = russian_SemiBold; mimicChest_text.fontSize = 23;
        if (PlaceMobileButtons.isMobile == true) { mimicChest_text.fontSize = 16.5f; }
        mimicChest2_text.text = "СУНДУК-МИМИК"; mimicChest2_text.font = russian_SemiBold; mimicChest2_text.fontSize = 20;
        mimicChestItemBonus_text.text = "Бонус предмета: <color=white> Положительные баффы имеют 15% шанс продлиться вдвое"; mimicChestItemBonus_text.font = robotoBold; mimicChestItemBonus_text.fontSize = 21;
        turnedOff_text.text = "ВЫКЛЮЧЕНО"; turnedOff_text.font = russian_SemiBold; turnedOff_text.fontSize = 18;

        purchaseAnItem_text.text = "-Приобретите предмет, потратив ваше золото."; purchaseAnItem_text.font = russianNono_SemiSkinny; purchaseAnItem_text.fontSize = 19f;
        useItems_text.text = "-Используйте ваши предметы на вкладке \"Предметы\" слева."; useItems_text.font = russianNono_SemiSkinny; useItems_text.fontSize = 15f;
        itemsGetExpensive_text.text = "-Каждый предмет становится дороже каждый раз, когда вы покупаете его."; itemsGetExpensive_text.font = russianNono_SemiSkinny; itemsGetExpensive_text.fontSize = 17f;
        levelUpItems_text.text = "-Повышайте уровень ваших предметов, потратив ваши сокровища."; levelUpItems_text.font = russianNono_SemiSkinny; levelUpItems_text.fontSize = 15f;
        broke_text.text = "РАЗОРЕН!"; broke_text.font = russian_SemiBold; broke_text.fontSize = 36f;

        rareTreasureBuff_text.text = "<color=green>Очень маленький шанс выпадения РЕДКОГО СОКРОВИЩА"; rareTreasureBuff_text.font = russianNonoBoldOutLine; rareTreasureBuff_text.fontSize = 7.4f;

        //Minus XP

        #endregion

        #region Treasures
        treasureBar_text.text = "СОКРОВИЩА"; treasureBar_text.font = russian_SemiBold; treasureBar_text.fontSize = 44;

        for (int i = 0; i < 5; i++)
        {
            commonText_text[i].text = "ОБЫЧНЫЙ"; commonText_text[i].font = russianNono_Bold; commonText_text[i].fontSize = 14;
            rareText_text[i].text = "РЕДКИЙ"; rareText_text[i].font = russianNono_Bold; rareText_text[i].fontSize = 15;
            veryRare_text[i].text = "ОЧЕНЬ РЕДКИЙ"; veryRare_text[i].font = russianNono_Bold; veryRare_text[i].fontSize = 10;
        }

        for (int i = 0; i < 4; i++)
        {
            unCommonText_text[i].text = "НЕОБЫЧНЫЙ"; unCommonText_text[i].font = russianNono_Bold; unCommonText_text[i].fontSize = 11;
        }

        for (int i = 0; i < 3; i++)
        {
            extremelyRare_text[i].text = "ЧРЕЗВЫЧАЙНО РЕДКИЙ"; extremelyRare_text[i].font = russianNono_Bold; extremelyRare_text[i].fontSize = 6;
            legendary_text[i].text = "ЛЕГЕНДАРНЫЙ"; legendary_text[i].font = russianNono_Bold; legendary_text[i].fontSize = 10;
            ultra_text[i].text = "УЛЬТРА"; ultra_text[i].font = russianNono_Bold; ultra_text[i].fontSize = 14;
            mythic_text[i].text = "МИФИЧЕСКИЙ"; mythic_text[i].font = russianNono_Bold; mythic_text[i].fontSize = 10;
            eternal_text[i].text = "ВЕЧНЫЙ"; eternal_text[i].font = russianNono_Bold; eternal_text[i].fontSize = 13;
        }


        quartz_text.text = "Кварц"; quartz_text.font = russian_SemiBold; quartz_text.fontSize = 28;
        amethyst_text.text = "Аметист"; amethyst_text.font = russian_SemiBold; amethyst_text.fontSize = 28;
        yellowTopaz_text.text = "Жёлтый Топаз"; yellowTopaz_text.font = russian_SemiBold; yellowTopaz_text.fontSize = 26;
        albite_text.text = "Альбит"; albite_text.font = russian_SemiBold; albite_text.fontSize = 27;
        redGarnet_text.text = "Красный Гранат"; redGarnet_text.font = russian_SemiBold; redGarnet_text.fontSize = 21;
        aquamarine_text.text = "Аквамарин"; aquamarine_text.font = russian_SemiBold; aquamarine_text.fontSize = 27;
        yellowSapphire_text.text = "Жёлтый Сапфир"; yellowSapphire_text.font = russian_SemiBold; yellowSapphire_text.fontSize = 20;
        pinkTourmaline_text.text = "Розовый Турмалин"; pinkTourmaline_text.font = russian_SemiBold; pinkTourmaline_text.fontSize = 17;
        aventurine_text.text = "Авантюрин"; aventurine_text.font = russian_SemiBold; aventurine_text.fontSize = 22;
        redRuby_text.text = "Красный Рубин"; redRuby_text.font = russian_SemiBold; redRuby_text.fontSize = 20;
        diamond_text.text = "Алмаз"; diamond_text.font = russian_SemiBold; diamond_text.fontSize = 27;
        grandidierite_text.text = "Грандидиерит"; grandidierite_text.font = russian_SemiBold; grandidierite_text.fontSize = 25;
        violetCrystal_text.text = "Фиолетовый Кристалл"; violetCrystal_text.font = russian_SemiBold; violetCrystal_text.fontSize = 15;
        akoyaPearl_text.text = "Жемчуг Акоя"; akoyaPearl_text.font = russian_SemiBold; akoyaPearl_text.fontSize = 25;
        purpleRupee_text.text = "Фиолетовый Рупий"; purpleRupee_text.font = russian_SemiBold; purpleRupee_text.fontSize = 18;
        emerald_text.text = "Изумруд"; emerald_text.font = russian_SemiBold; emerald_text.fontSize = 28;
        greenDiamond_text.text = "Зелёный Алмаз"; greenDiamond_text.font = russian_SemiBold; greenDiamond_text.fontSize = 20;
        fireOpal_text.text = "Огненный Опал"; fireOpal_text.font = russian_SemiBold; fireOpal_text.fontSize = 20;
        gemSilica_text.text = "Каменный Хризоколл"; gemSilica_text.font = russian_SemiBold; gemSilica_text.fontSize = 16;
        pinkPlort_text.text = "Розовый Плорт"; pinkPlort_text.font = russian_SemiBold; pinkPlort_text.fontSize = 19;
        goldenSeaPearl_text.text = "Золотой Морской Жемчуг"; goldenSeaPearl_text.font = russian_SemiBold; goldenSeaPearl_text.fontSize = 13;
        kyanite_text.text = "Кианит"; kyanite_text.font = russian_SemiBold; kyanite_text.fontSize = 27;
        blackOpal_text.text = "Чёрный Опал"; blackOpal_text.font = russian_SemiBold; blackOpal_text.fontSize = 27;
        painite_text.text = "Пайнит"; painite_text.font = russian_SemiBold; painite_text.fontSize = 28;
        tanzanite_text.text = "Танзанит"; tanzanite_text.font = russian_SemiBold; tanzanite_text.fontSize = 27;
        astralium_text.text = "Астралит"; astralium_text.font = russian_SemiBold; astralium_text.fontSize = 27;
        elysiumPrism_text.text = "Призма Элизиума"; elysiumPrism_text.font = russian_SemiBold; elysiumPrism_text.fontSize = 19;
        aerthfireOpal_text.text = "Опал Аэртфаер"; aerthfireOpal_text.font = russian_SemiBold; aerthfireOpal_text.fontSize = 23;
        eldrichStarstone_text.text = "Звездный Камень Элдрич"; eldrichStarstone_text.font = russian_SemiBold; eldrichStarstone_text.fontSize = 13;
        chronolithShard_text.text = "Осколок Хронолита"; chronolithShard_text.font = russian_SemiBold; chronolithShard_text.fontSize = 17;
        sideriumEssence_text.text = "Сущность Сидерия"; sideriumEssence_text.font = russian_SemiBold; sideriumEssence_text.fontSize = 18;
        quadarite_text.text = "Квадарит"; quadarite_text.font = russian_SemiBold; quadarite_text.fontSize = 22;
        radiantNovaStone_text.text = "Сияющий Камень Нова"; radiantNovaStone_text.font = russian_SemiBold; radiantNovaStone_text.fontSize = 14;
        soluniumShard_text.text = "Осколок Солуниума"; soluniumShard_text.font = russian_SemiBold; soluniumShard_text.fontSize = 17;

        sell_text.text = "ПРОДАТЬ"; sell_text.font = russianNonoBoldOutLine; sell_text.fontSize = 19;
        sellAll_text.text = "ПРОДАТЬ ВСЕ"; sellAll_text.font = russianNonoBoldOutLine; sellAll_text.fontSize = 14;
        #endregion

        #region Rare Treasures
        coolStuff_text.text = "крутые вещи"; coolStuff_text.font = russianNono_Bold; coolStuff_text.fontSize = 17;
        rareTreasuresTop2_text.text = "РЕДКИЕ СОКРОВИЩА"; rareTreasuresTop2_text.font = russianNono_Bold; rareTreasuresTop2_text.fontSize = 16;
        page1_text.text = "СТРАНИЦА 1"; page1_text.font = russianNono_Bold; page1_text.fontSize = 12;
        page2_text.text = "СТРАНИЦА 2"; page2_text.font = russianNono_Bold; page2_text.fontSize = 12;
        pirateSkull2_text.text = "ПИРАТСКИЙ ЧЕРЕП"; pirateSkull2_text.font = russianNono_Bold; pirateSkull2_text.fontSize = 13;
        demonicSword2_text.text = "ДЕМОНИЧЕСКИЙ МЕЧ"; demonicSword2_text.font = russianNono_Bold; demonicSword2_text.fontSize = 11;
        mysticRing2_text.text = "МИСТИЧЕСКОЕ КОЛЬЦО"; mysticRing2_text.font = russianNono_Bold; mysticRing2_text.fontSize = 11;
        trophy2_text.text = "ТРОФЕЙ"; trophy2_text.font = russianNono_Bold; trophy2_text.fontSize = 20;
        fallenStar2_text.text = "ПАДШАЯ ЗВЕЗДА"; fallenStar2_text.font = russianNono_Bold; fallenStar2_text.fontSize = 15;
        clover2_text.text = "КЛЕВЕР"; clover2_text.font = russianNono_Bold; clover2_text.fontSize = 20;
        kingsCrown2_text.text = "КОРОЛЕВСКАЯ КОРОНА"; kingsCrown2_text.font = russianNono_Bold; kingsCrown2_text.fontSize = 11;
        spellBook2_text.text = "КНИГА ЗАКЛИНАНИЙ"; spellBook2_text.font = russianNono_Bold; spellBook2_text.fontSize = 12;
        guitar2_text.text = "ГИТАРА"; guitar2_text.font = russianNono_Bold; guitar2_text.fontSize = 19;
        talarian2_text.text = "ТАЛАРИА"; talarian2_text.font = russianNono_Bold; talarian2_text.fontSize = 19;
        mythrune2_text.text = "МИФРУНА"; mythrune2_text.font = russianNono_Bold; mythrune2_text.fontSize = 19;
        explorerBackpack2_text.text = "РЮКЗАК ИССЛЕДОВАТЕЛЯ"; explorerBackpack2_text.font = russianNono_Bold; explorerBackpack2_text.fontSize = 10;
        vikingShield2_text.text = "ЩИТ ВИКИНГА"; vikingShield2_text.font = russianNono_Bold; vikingShield2_text.fontSize = 17;
        pillBottle2_text.text = "БАНКА С ТАБЛЕТКАМИ"; pillBottle2_text.font = russianNono_Bold; pillBottle2_text.fontSize = 12;
        victoryMedal2_text.text = "МЕДАЛЬ ПОБЕДЫ"; victoryMedal2_text.font = russianNono_Bold; victoryMedal2_text.fontSize = 15;
        cookie2_text.text = "ПЕЧЕНЬЕ"; cookie2_text.font = russianNono_Bold; cookie2_text.fontSize = 17;
        christmasPresent2_text.text = "РОЖДЕСТВЕНСКИЙ ПОДАРОК"; christmasPresent2_text.font = russianNono_Bold; christmasPresent2_text.fontSize = 9;
        battleAxe2_text.text = "БОЕВОЙ ТОПОР"; battleAxe2_text.font = russianNono_Bold; battleAxe2_text.fontSize = 17;
        goldCoin100X2_text.text = "100X ЗОЛОТАЯ МОНЕТА"; goldCoin100X2_text.font = russianNono_Bold; goldCoin100X2_text.fontSize = 11;
        sealedEnvelope2_text.text = "ЗАПЕЧАТАННЫЙ КОНВЕРТ"; sealedEnvelope2_text.font = russianNono_Bold; sealedEnvelope2_text.fontSize = 10;
        strangePotion2_text.text = "СТРАННОЕ ЗЕЛЬЕ"; strangePotion2_text.font = russianNono_Bold; strangePotion2_text.fontSize = 15;
        soulGem2_text.text = "ДРАГОЦЕННЫЙ КАМЕНЬ ДУШИ"; soulGem2_text.font = russianNono_Bold; soulGem2_text.fontSize = 8.6f;
        ancientScroll2_text.text = "ДРЕВНИЙ СВИТОК"; ancientScroll2_text.font = russianNono_Bold; ancientScroll2_text.fontSize = 14;
        brick2_text.text = "кирпич"; brick2_text.font = russianNono_Bold; brick2_text.fontSize = 17;
        rubberChicken2_text.text = "РЕЗИНОВАЯ КУРИЦА"; rubberChicken2_text.font = russianNono_Bold; rubberChicken2_text.fontSize = 12;

        skullFoundReward_text.text = "Награда за нахождение пиратского черепа:"; skullFoundReward_text.font = russianLight; skullFoundReward_text.fontSize = 6.8f;
        swordFoundReward_text.text = "Награда за нахождение демонического меча:"; swordFoundReward_text.font = russianLight; swordFoundReward_text.fontSize = 6.8f;
        ringFoundReward_text.text = "Награда за нахождение мистического кольца:"; ringFoundReward_text.font = russianLight; ringFoundReward_text.fontSize = 6.8f;
        trophyFoundReward_text.text = "Награда за нахождение трофея:"; trophyFoundReward_text.font = russianLight; trophyFoundReward_text.fontSize = 6.8f;
        fallenStarFoundReward_text.text = "Награда за нахождение павшей звезды:"; fallenStarFoundReward_text.font = russianLight; fallenStarFoundReward_text.fontSize = 6.8f;
        cloverFoundReward_text.text = "Награда за нахождение клевера:"; cloverFoundReward_text.font = russianLight; cloverFoundReward_text.fontSize = 6.7f;
        kingsCrownFoundReward_text.text = "Награда за нахождение королевской короны:"; kingsCrownFoundReward_text.font = russianLight; kingsCrownFoundReward_text.fontSize = 6.7f;
        spellBookFoundReward_text.text = "Награда за нахождение книги заклинаний:"; spellBookFoundReward_text.font = russianLight; spellBookFoundReward_text.fontSize = 6.7f;
        guitarFoundReward_text.text = "Награда за нахождение гитары:"; guitarFoundReward_text.font = russianLight; guitarFoundReward_text.fontSize = 6.7f;
        talarianFoundReward_text.text = "Награда за нахождение талария:"; talarianFoundReward_text.font = russianLight; talarianFoundReward_text.fontSize = 6.7f;
        mythruneFoundReward_text.text = "Награда за нахождение мифруны:"; mythruneFoundReward_text.font = russianLight; mythruneFoundReward_text.fontSize = 6.7f;
        backPackFoundReward_text.text = "Награда за нахождение рюкзака исследователя:"; backPackFoundReward_text.font = russianLight; backPackFoundReward_text.fontSize = 6.5f;
        shieldFoundReward_text.text = "Награда за нахождение щита викинга:"; shieldFoundReward_text.font = russianLight; shieldFoundReward_text.fontSize = 6.5f;
        pillBottleFoundReward_text.text = "Награда за нахождение банки с таблетками:"; pillBottleFoundReward_text.font = russianLight; pillBottleFoundReward_text.fontSize = 6.5f;
        medalFoundReward_text.text = "Награда за нахождение медали победы:"; medalFoundReward_text.font = russianLight; medalFoundReward_text.fontSize = 6.5f;
        cookieFoundReward_text.text = "Награда за нахождение печенья:"; cookieFoundReward_text.font = russianLight; cookieFoundReward_text.fontSize = 6.5f;
        presentFoundReward_text.text = "Награда за нахождение рождественского подарка:"; presentFoundReward_text.font = russianLight; presentFoundReward_text.fontSize = 6.8f;
        axeFoundReward_text.text = "Награда за нахождение боевого топора:"; axeFoundReward_text.font = russianLight; axeFoundReward_text.fontSize = 6.8f;
        envelopeFoundReward_text.text = "Награда за нахождение запечатанного конверта:"; envelopeFoundReward_text.font = russianLight; envelopeFoundReward_text.fontSize = 6.8f;
        coin100XFoundReward_text.text = "Награда за нахождение золотой монеты в 100X:"; coin100XFoundReward_text.font = russianLight; coin100XFoundReward_text.fontSize = 6.8f;
        potionFoundReward_text.text = "Награда за нахождение зелья:"; potionFoundReward_text.font = russianLight; potionFoundReward_text.fontSize = 6.8f;
        soulGemFoundReward_text.text = "Награда за нахождение камня души:"; soulGemFoundReward_text.font = russianLight; soulGemFoundReward_text.fontSize = 6.8f;
        sscrollFoundReward_text.text = "Награда за нахождение древнего свитка:"; sscrollFoundReward_text.font = russianLight; sscrollFoundReward_text.fontSize = 6.8f;
        brickFoundReward_text.text = "Награда за нахождение кирпича:"; brickFoundReward_text.font = russianLight; brickFoundReward_text.fontSize = 6.8f;
        chickenFoundReward_text.text = "Награда за нахождение резиновой курицы:"; chickenFoundReward_text.font = russianLight; chickenFoundReward_text.fontSize = 6.8f;

        allSkullRewards_text.text = "+3% Пассивный урон"; allSkullRewards_text.font = russianNono_MediumOutLine; allSkullRewards_text.fontSize = 11f;
        allDemonicSwordRewards_text.text = "+5% АКТИВНЫЙ УРОН. +0.3% ШАНС КРИТИЧЕСКОГО УДАРА"; allDemonicSwordRewards_text.font = russianNono_MediumOutLine; allDemonicSwordRewards_text.fontSize = 6f;
        allMysticRingRewards_text.text = "+0.05% ШАНС ВЫПАДЕНИЯ СОКРОВИЩА"; allMysticRingRewards_text.font = russianNono_MediumOutLine; allMysticRingRewards_text.fontSize = 9f;
        allTrophyRewards_text.text = "+0.05% ШАНС ВЫПАДЕНИЯ СОКРОВИЩА"; allTrophyRewards_text.font = russianNono_MediumOutLine; allTrophyRewards_text.fontSize = 9f;
        allFallenStarRewards_text.text = "+4% Шанс удвоения стоимости сокровища"; allFallenStarRewards_text.font = russianNono_MediumOutLine; allFallenStarRewards_text.fontSize = 7.5f;
        allCloverRewards_text.text = "+2% на 5X золотую монету. +1% на 10X золотую монету"; allCloverRewards_text.font = russianNono_MediumOutLine; allCloverRewards_text.fontSize = 6.4f;
        allKingsCrownRewards_text.text = "Повышение уровня курсоров делает их сильнее"; allKingsCrownRewards_text.font = russianNono_MediumOutLine; allKingsCrownRewards_text.fontSize = 7.5f;
        allSpellBookRewards_text.text = "Повышение уровня специальных улучшений делает их сильнее"; allSpellBookRewards_text.font = russianNono_MediumOutLine; allSpellBookRewards_text.fontSize = 5.5f;
        allGuitarRewards_text.text = "+20% Активный и пассивный урон"; allGuitarRewards_text.font = russianNono_MediumOutLine; allGuitarRewards_text.fontSize = 7.5f;
        allTalarianRewards_text.text = "+30% Пассивный урон"; allTalarianRewards_text.font = russianNono_MediumOutLine; allTalarianRewards_text.fontSize = 7.5f;
        allMythruneRewards_text.text = "+15% ЗОЛОТО"; allMythruneRewards_text.font = russianNono_MediumOutLine; allMythruneRewards_text.fontSize = 7.5f;
        allExplorerBackpackRewards_text.text = "+15% ОПЫТ, +15% ЗОЛОТО, +0.1% ШАНС ВЫПАДЕНИЯ СОКРОВИЩА"; allExplorerBackpackRewards_text.font = russianNono_MediumOutLine; allExplorerBackpackRewards_text.fontSize = 5.4f;
        allVikingShieldRewards_text.text = "+4% Шанс удвоения стоимости сокровища"; allVikingShieldRewards_text.font = russianNono_MediumOutLine; allVikingShieldRewards_text.fontSize = 7.1f;
        allPillBottleRewards_text.text = "Зелья суммируются +1 раз"; allPillBottleRewards_text.font = russianNono_MediumOutLine; allPillBottleRewards_text.fontSize = 7.1f;
        allVictoryMedalRewards_text.text = "+1% Шанс появления золотой монеты при каждом клике & +0.2% Шанс появления сокровища"; allVictoryMedalRewards_text.font = russianNono_MediumOutLine; allVictoryMedalRewards_text.fontSize = 6.8f;
        foundCookieRewards_text.text = "+50% ЗОЛОТО. +50% ОПЫТ. +0.2% ШАНС ВЫПАДЕНИЯ СОКРОВИЩА. +5% Шанс удвоения стоимости сокровища. +75% Активный и пассивный урон. +3% шанс крита. 150% критический урон"; foundCookieRewards_text.font = russianNono_MediumOutLine; foundCookieRewards_text.fontSize = 6.6f;
        foundChristmasPresentRewards_text.text = "Древний реликвии даёт более сильные баффы"; foundChristmasPresentRewards_text.font = russianNono_MediumOutLine; foundChristmasPresentRewards_text.fontSize = 7.4f;
        foundBattleAxeRewards_text.text = "Каждый клик имеет +0.1% шанса мгновенно открыть сундук. Мгновенное открытие сундука удваивает награды из сундука"; foundBattleAxeRewards_text.font = russianNono_MediumOutLine; foundBattleAxeRewards_text.fontSize = 5.6f;
        foundEnvelopeRewards.text = "+0.2% Шанс на укреплённый сундук"; foundEnvelopeRewards.font = russianNono_MediumOutLine; foundEnvelopeRewards.fontSize = 8f;
        foundGoldCoin100XRewards_text.text = "0.05% Шанс выпадения золотой монеты в 100X"; foundGoldCoin100XRewards_text.font = russianNono_MediumOutLine; foundGoldCoin100XRewards_text.fontSize = 7f;
        foundPotionRewards_text.text = "Все зелья становятся гораздо сильнее при улучшении"; foundPotionRewards_text.font = russianNono_MediumOutLine; foundPotionRewards_text.fontSize = 6.4f;
        foundSoulGemRewards_text.text = "Камни души будут продолжать выпадать. Кликните по камню души, чтобы получить постоянный бафф на случайный стат."; foundSoulGemRewards_text.font = russianNono_MediumOutLine; foundSoulGemRewards_text.fontSize = 6f;
        foundAncientScrollRewards_text.text = "Свиток Удачи даёт более сильные баффы"; foundAncientScrollRewards_text.font = russianNono_MediumOutLine; foundAncientScrollRewards_text.fontSize = 8f;
        foundBrickRewards_text.text = "ну это просто кирпич... так что... ничего..."; foundBrickRewards_text.font = russianNono_MediumOutLine; foundBrickRewards_text.fontSize = 8f;
        foundRubberChickenRewards_text.text = "Даёт огромный бафф на характеристику на ваш выбор."; foundRubberChickenRewards_text.font = russianNono_MediumOutLine; foundRubberChickenRewards_text.fontSize = 6f;
      

        pirateSkullDescription_text.text = "\"Через бурные моря и несметные битвы, этот череп хранит наследие жестокого пирата.\""; pirateSkullDescription_text.font = russianLight; pirateSkullDescription_text.fontSize = 7f;

        demonicSwordDescription_text.text = "\"Оружие нечестивого происхождения, этот демонический меч воплощает суть проклятия\""; demonicSwordDescription_text.font = russianLight; demonicSwordDescription_text.fontSize = 7f;

        mysticRingDescription_text.text = "\"Мистическое кольцо увеличивает ваше богатство, делая сокровища более частыми\""; mysticRingDescription_text.font = russianLight; mysticRingDescription_text.fontSize = 7f;

        trophyDescription_text.text = "\"Интрига таится. Почему Трофей, символ величия, хранится в сундуке?\""; trophyDescription_text.font = russianLight; trophyDescription_text.fontSize = 7f;

        fallenStarDescription_text.text = "\"В этих сундуках находятся редкие сокровища. Падшая звезда, космический реликт чуда.\""; fallenStarDescription_text.font = russianLight; fallenStarDescription_text.fontSize = 7f;

        cloverDescription_text.text = "\"Обнаружьте принесение удачи — четырёхлистный клевер, спрятанный в сундуке.\""; cloverDescription_text.font = russianLight; cloverDescription_text.fontSize = 7f;

        kingsCrownDescription_text.text = "\"Раскройте великолепный артефакт — корону, несущую тяжесть наследия королевства.\""; kingsCrownDescription_text.font = russianLight; kingsCrownDescription_text.fontSize = 7.6f;

        spellBookDescription_text.text = "\"Откройте тайные знания Книги Заклинаний, наделяющие вас искусством магии.\""; spellBookDescription_text.font = russianLight; spellBookDescription_text.fontSize = 7.6f;

        guitarDescription_text.text = "\"Почему эта Гитара была спрятана в сундуке? Её струны несут эхо глубокой личной связи.\""; guitarDescription_text.font = russianLight; guitarDescription_text.fontSize = 6.9f;

        talarianDescription_text.text = "\"В сундуке находятся легендарные Таларии, символ быстроты и свободы.\""; talarianDescription_text.font = russianLight; talarianDescription_text.fontSize = 6.9f;

        strangeRuneDescription_text.text = "\"Обнаружьте сущность Мифруна и почувствуйте эхо древней магии.\""; strangeRuneDescription_text.font = russianLight; strangeRuneDescription_text.fontSize = 6.7f;

        explorerBackpackDescription_text.text = "\"Откройте Рюкзак Исследователя и найдите клад инструментов для смелых приключений.\""; explorerBackpackDescription_text.font = russianLight; explorerBackpackDescription_text.fontSize = 6.7f;

        vikingShieldDescription_text.text = "\"В Щите викинга живет наследие храбрых воинов, которые не боялись битвы.\""; vikingShieldDescription_text.font = russianLight; vikingShieldDescription_text.fontSize = 7f;

        pillBottleDescription_text.text = "\"Среди богатств скрывается невзрачная баночка с таблетками, её назначение интригующе неясно.\""; pillBottleDescription_text.font = russianLight; pillBottleDescription_text.fontSize = 7f;

        victoryMedalDescription_text.text = "\"Примите Медаль Победы, символ триумфальной славы и непоколебимой решимости.\""; victoryMedalDescription_text.font = russianLight; victoryMedalDescription_text.fontSize = 6.5f;

        cookieDescription_text.text = "КЛИКНИТЕ ПО НЕМУ"; cookieDescription_text.font = russianLight; cookieDescription_text.fontSize = 7f;

        christmasPresentDescription_text.text = "\"Мы никогда не узнаем, что внутри\""; christmasPresentDescription_text.font = russianLight; christmasPresentDescription_text.fontSize = 7f;

        battleAxeDescription_text.text = "\"Этот боевой топор, кованный с мастерством, блестит острым лезвием, готовым с легкостью разрубить ваших врагов.\""; battleAxeDescription_text.font = russianLight; battleAxeDescription_text.fontSize = 6f;

        goldCoin100XDescription_text.text = "\"Таких монет осталось не так много в мире\""; goldCoin100XDescription_text.font = russianLight; goldCoin100XDescription_text.fontSize = 7f;

        sealedEnvelopeDescription_text.text = "\"Скорее всего, написано исторической личностью\""; sealedEnvelopeDescription_text.font = russianLight; sealedEnvelopeDescription_text.fontSize = 7f;

        strangePotionDescription_text.text = "\"Это таинственное зелье мерцает таинственными цветами, обещая риск и награды смелым, кто его выпьет.\""; strangePotionDescription_text.font = russianLight; strangePotionDescription_text.fontSize = 6f;

        soulGemDescription_text.text = "\"Этот сияющий камень пульсирует космической энергией, обещая усилить силу и возможности вашего персонажа.\""; soulGemDescription_text.font = russianLight; soulGemDescription_text.fontSize = 6f;

        ancientScrollDescription_text.text = "\"Древний свиток, наполненный вековой мудростью и пониманием.\""; ancientScrollDescription_text.font = russianLight; ancientScrollDescription_text.fontSize = 7f;

        brickDescription_text.text = "\"Да... это просто кирпич\""; brickDescription_text.font = russianLight; brickDescription_text.fontSize = 7f;

        rubberChickenDescription_text.text = "\"Вы можете думать, что эта резиновая курица — шутка, но внутри неё скрыта мощная сила\""; rubberChickenDescription_text.font = russianLight; rubberChickenDescription_text.fontSize = 7f;

        skullDropChance_text.text = "0,0278%<color=white> Шанс Дропа"; skullDropChance_text.font = russianLight; skullDropChance_text.fontSize = 10f;
        democSwordDropChance_text.text = "0,0119%<color=white> Шанс Дропа"; democSwordDropChance_text.font = russianLight; democSwordDropChance_text.fontSize = 10f;
        mysticRingDropChance_text.text = "0,0051%<color=white> Шанс Дропа"; mysticRingDropChance_text.font = russianLight; mysticRingDropChance_text.fontSize = 10f;
        trophyDropChance_text.text = "0,0050%<color=white> Шанс Дропа"; trophyDropChance_text.font = russianLight; trophyDropChance_text.fontSize = 10f;
        fallenStarDropChance_text.text = "0,0008%<color=white> Шанс Дропа"; fallenStarDropChance_text.font = russianLight; fallenStarDropChance_text.fontSize = 10f;
        cloverDropChance_text.text = "0,0005%<color=white> Шанс Дропа"; cloverDropChance_text.font = russianLight; cloverDropChance_text.fontSize = 10f;
        kingsCrownDropChance_text.text = "0,0006%<color=white> Шанс Дропа"; kingsCrownDropChance_text.font = russianLight; kingsCrownDropChance_text.fontSize = 10f;
        spellBookDropChance_text.text = "0,0006%<color=white> Шанс Дропа"; spellBookDropChance_text.font = russianLight; spellBookDropChance_text.fontSize = 10f;
        guitarDropChance_text.text = "0,0009%<color=white> Шанс Дропа"; guitarDropChance_text.font = russianLight; guitarDropChance_text.fontSize = 10f;
        talarianDropChance_text.text = "0,00077%<color=white> Шанс Дропа"; talarianDropChance_text.font = russianLight; talarianDropChance_text.fontSize = 10f;
        mythRuneDropChance_text.text = "0,0016%<color=white> Шанс Дропа"; mythRuneDropChance_text.font = russianLight; mythRuneDropChance_text.fontSize = 10f;
        backPackDropChance_text.text = "0,00052%<color=white> Шанс Дропа"; backPackDropChance_text.font = russianLight; backPackDropChance_text.fontSize = 10f;
        vikingShieldDropChance_text.text = "0,00063%<color=white> Шанс Дропа"; vikingShieldDropChance_text.font = russianLight; vikingShieldDropChance_text.fontSize = 10f;
        pillBottleDropChance_text.text = "0,00050%<color=white> Шанс Дропа"; pillBottleDropChance_text.font = russianLight; pillBottleDropChance_text.fontSize = 10f;
        victoryMedalDropChance_text.text = "0,00042%<color=white> Шанс Дропа"; victoryMedalDropChance_text.font = russianLight; victoryMedalDropChance_text.fontSize = 10f;
        cookieDropChance_text.text = "0,00034%<color=white> Шанс Дропа"; cookieDropChance_text.font = russianLight; cookieDropChance_text.fontSize = 10f;
        presentDropChance_text.text = "0,00038%<color=white> Шанс Дропа"; presentDropChance_text.font = russianLight; presentDropChance_text.fontSize = 10f;
        battleAxeDropChance_text.text = "0,00032%<color=white> Шанс Дропа"; battleAxeDropChance_text.font = russianLight; battleAxeDropChance_text.fontSize = 10f;
        coin100XDropChance_text.text = "0,00030%<color=white> Шанс Дропа"; coin100XDropChance_text.font = russianLight; coin100XDropChance_text.fontSize = 10f;
        envelopeDropChance_text.text = "0,00036%<color=white> Шанс Дропа"; envelopeDropChance_text.font = russianLight; envelopeDropChance_text.fontSize = 10f;
        strangePotionDropChance_text.text = "0,00030%<color=white> Шанс Дропа"; strangePotionDropChance_text.font = russianLight; strangePotionDropChance_text.fontSize = 10f;
        soulGemDropChance_text.text = "0,00034%<color=white> Шанс Дропа"; soulGemDropChance_text.font = russianLight; soulGemDropChance_text.fontSize = 10f;
        ancientScrollDropChance_text.text = "0,00029%<color=white> Шанс Дропа"; ancientScrollDropChance_text.font = russianLight; ancientScrollDropChance_text.fontSize = 10f;
        brickDropChance_text.text = "0,00026%<color=white> Шанс Дропа"; brickDropChance_text.font = russianLight; brickDropChance_text.fontSize = 10f;
        chickenDropChance_text.text = "0,00025%<color=white> Шанс Дропа"; chickenDropChance_text.font = russianLight; chickenDropChance_text.fontSize = 10f;

        congratsMessage_text.text = "Поздравляем! У вас есть все 25 редких сокровищ!"; congratsMessage_text.font = russian_SemiBold; congratsMessage_text.fontSize = 17f;
        purchaseRareTreasure_text.text = "Чтобы разблокировать, приобретите все престижные улучшения."; purchaseRareTreasure_text.font = russian_SemiBold; purchaseRareTreasure_text.fontSize = 17f;
        purchase1MissingTreasure_text.text = "Купить 1 отсутствующее редкое сокровище?"; purchase1MissingTreasure_text.font = russian_SemiBold; purchase1MissingTreasure_text.fontSize = 12f;

        chooseChickenBuff_text.text = "ВЫБЕРИТЕ БАФФ ИЗ КУРИЦЫ:"; chooseChickenBuff_text.font = russianNonoBoldOutLine; chooseChickenBuff_text.fontSize = 36f;
        coose1_text.text = "ВЫБЕРИТЕ"; coose1_text.font = russianNonoBoldOutLine; coose1_text.fontSize = 19f;
        coose2_text.text = "ВЫБЕРИТЕ"; coose2_text.font = russianNonoBoldOutLine; coose2_text.fontSize = 19f;
        coose3_text.text = "ВЫБЕРИТЕ"; coose3_text.font = russianNonoBoldOutLine; coose3_text.fontSize = 19f;
        coose4_text.text = "ВЫБЕРИТЕ"; coose4_text.font = russianNonoBoldOutLine; coose4_text.fontSize = 19f;
        coose5_text.text = "ВЫБЕРИТЕ"; coose5_text.font = russianNonoBoldOutLine; coose5_text.fontSize = 19f;
        coose6_text.text = "ВЫБЕРИТЕ"; coose6_text.font = russianNonoBoldOutLine; coose6_text.fontSize = 19f;
        coose7_text.text = "ВЫБЕРИТЕ"; coose7_text.font = russianNonoBoldOutLine; coose7_text.fontSize = 19f;
        #endregion

        #region Treasure Chests
        chestPurchase_text.text = "ПОКУПКА"; chestPurchase_text.font = russianNono_Bold; chestPurchase_text.fontSize = 36;
        autoPurchase_text.text = "Автоматически покупает следующий сундук, когда это возможно:"; autoPurchase_text.font = russianLight; autoPurchase_text.fontSize = 9;
        chestTREASURESDROP_text.text = "СУНДУКИ С СОКРОВИЩАМИ:"; chestTREASURESDROP_text.font = russian_SemiBold; chestTREASURESDROP_text.fontSize = 13;
        reinforcedPopUp_text.text = "УКРЕПЛЁННЫЙ СУНДУК"; reinforcedPopUp_text.font = russianNono_Medium; reinforcedPopUp_text.fontSize = 32;
        enchantedGoldenChestPopUp_text.text = "ЗАЧАРОВАННЫЙ ЗОЛОТОЙ СУНДУК"; enchantedGoldenChestPopUp_text.font = russianNono_Medium; enchantedGoldenChestPopUp_text.fontSize = 30;
        bossChest_text.text = "СУНДУК БОССА"; bossChest_text.font = russianNono_Medium; bossChest_text.fontSize = 50;
        reinforcedHover_text.text = "УКРЕПЛЁННЫЙ СУНДУК"; reinforcedHover_text.font = russianNono_Medium; reinforcedHover_text.fontSize = 25;

        enchantedGoldenHover_text.text = "ЗАЧАРОВАННЫЙ ЗОЛОТОЙ СУНДУК"; enchantedGoldenHover_text.font = russianNono_Medium; enchantedGoldenHover_text.fontSize = 19;
        enchantedGoldenHoverLockPickKeys_text.text = "-Использование отмычки или ключа убирает только 25% здоровья сундука."; enchantedGoldenHoverLockPickKeys_text.font = russianNono_SemiSkinny; enchantedGoldenHoverLockPickKeys_text.fontSize = 17;

        bossChestHover_text.text = "СУНДУК БОССА"; bossChestHover_text.font = russianNono_Medium; bossChestHover_text.fontSize = 38;
        bossChestHoverLockPickKeys_text.text = "-Использование отмычки или ключа убирает только 25% здоровья сундука."; bossChestHoverLockPickKeys_text.font = russianNono_SemiSkinny; bossChestHoverLockPickKeys_text.fontSize = 16;


        #endregion

        #region prestige
        prestigeExit_text.text = "ВЫХОД"; prestigeExit_text.font = russianNono_Bold; prestigeExit_text.fontSize = 47;

        wouldYouLiketoGoBack_text.text = "Хотите вернуться и открыть ещё несколько сундуков?";
        wouldYouLiketoGoBack_text.font = russianNono_Medium; wouldYouLiketoGoBack_text.fontSize = 40;

        butFirst_text.text = "но сначала...";
        butFirst_text.font = russianNono_Medium; butFirst_text.fontSize = 15;

        purchaseTheGoodieBag_text.text = "Приобретите прокачку престижа \"Мешок Лакомств\", чтобы разблокировать";
        purchaseTheGoodieBag_text.font = russianNono_MediumOutLine; purchaseTheGoodieBag_text.fontSize = 22;

        goBackYES_text.text = "ДА"; goBackYES_text.font = russian_SemiBold; goBackYES_text.fontSize = 60;

        goBackNO_text.text = "НЕТ"; goBackNO_text.font = russian_SemiBold; goBackNO_text.fontSize = 60;

        itesmChosen_text.text = "Выбранные предметы!"; itesmChosen_text.font = russianNono_MediumOutLine; itesmChosen_text.fontSize = 26;

        chooseSomethingElse_text.text = "ВЫБЕРИТЕ ЧТО-ТО ДРУГОЕ"; chooseSomethingElse_text.font = russianNonoBoldOutLine; chooseSomethingElse_text.fontSize = 20;

        findThePrestigeKeyAncChest_text.lineSpacing = -40;
        openPrestigeScreen_text.lineSpacing = -45;

        for (int i = 0; i < lockedPrestige_text.Length; i++)
        {
            lockedPrestige_text[i].text = "ЗАБЛОКИРОВАНО"; lockedPrestige_text[i].font = russianNono_MediumOutLine; lockedPrestige_text[i].fontSize = 5.4f;
            unlockedPrestige_text[i].text = "РАЗБЛОКИРОВАНО"; unlockedPrestige_text[i].font = russianNono_MediumOutLine; unlockedPrestige_text[i].fontSize = 5f;
        }

        // For individual variables
        prestigeTop_text.text = "ПРЕСТИЖ"; prestigeTop_text.font = russianNono_Bold; prestigeTop_text.fontSize = 50;
        prestigeButton_text.text = "ПРЕСТИЖ"; prestigeButton_text.font = russianNono_Bold; prestigeButton_text.fontSize = 36;
        openPrestigeScreen_text.text = "ОТКРЫТЬ ЭКРАН ПРЕСТИЖА"; openPrestigeScreen_text.font = russianNono_Bold; openPrestigeScreen_text.fontSize = 23;
        skillPoints_text.text = "ОЧКОВ НАВЫКА"; skillPoints_text.font = russianNono_Bold; skillPoints_text.fontSize = 15;

        loseText_text.lineSpacing = -45;
        keepText_text.lineSpacing = -30;

        wouldYouLikeToPrestige_text.text = "Хотите получить престиж?"; wouldYouLikeToPrestige_text.font = russianNonoBoldOutLine; wouldYouLikeToPrestige_text.fontSize = 20;
        youWillKeep_text.text = "ВЫ СОХРАНИТЕ"; youWillKeep_text.font = russianNonoBoldOutLine; youWillKeep_text.fontSize = 37;
        keepText_text.text = "- Престижные улучшения\n- Редкие сокровища\n- Достижения"; keepText_text.font = russianNonoBoldOutLine; keepText_text.fontSize = 34;
        youWillLose_text.text = "ВЫ ПОТЕРЯЕТЕ"; youWillLose_text.font = russianNonoBoldOutLine; youWillLose_text.fontSize = 40;
        loseText_text.text = "- Все Золото\n- Сокровища\n- Уровни\n- Предметы\n- Уровни Предметов\n- Курсоры\n- Уровни Курсоров\n- Статистику Свитков"; loseText_text.font = russianNonoBoldOutLine; loseText_text.fontSize = 37;
        prestigeWillTakeYou_text.text = "Получение престижа отправит вас в дерево навыков, где вы сможете приобрести постоянные улучшения"; prestigeWillTakeYou_text.font = russianNonoBoldOutLine; prestigeWillTakeYou_text.fontSize = 14.4f;
        prestigeYES_text.text = "ДА"; prestigeYES_text.font = russianNonoBoldOutLine; prestigeYES_text.fontSize = 25;
        prestigeNO_text.text = "НЕТ"; prestigeNO_text.font = russianNonoBoldOutLine; prestigeNO_text.fontSize = 25;
        prestigeAndSkillPoints_text.text = "Престиж и Очки Навыка"; prestigeAndSkillPoints_text.font = russianNonoBoldOutLine; prestigeAndSkillPoints_text.fontSize = 64;
        prestigeExplinations_text.text = "- Ключ и Сундук престижа получают +0.017% шанса выпадения после открытия нового сундука"; prestigeExplinations_text.font = russianNono_SemiSkinny; prestigeExplinations_text.fontSize = 32;
        prestigeExplinations2_text.text = "- Вы получаете очки навыка при каждом повышении уровня. Каждый пятый уровень дает вам +1 очко навыка к общему числу полученных очков навыка. Получаемые очки навыка за уровень = (Текущий уровень / 5) + 1"; prestigeExplinations2_text.font = russianNono_SemiSkinny; prestigeExplinations2_text.fontSize = 29;
        currentlyViewingPrestige_text.text = "В настоящее время вы просматриваете только экран престижа!"; currentlyViewingPrestige_text.font = russianNono_MediumOutLine; currentlyViewingPrestige_text.fontSize = 38;
        skillPointsTextInsode_text.text = "ОЧКОВ НАВЫКА"; skillPointsTextInsode_text.font = russian_SemiBold; skillPointsTextInsode_text.fontSize = 31;

        clickerUnder_text.text = "CLICKER"; clickerUnder_text.font = russian_SemiBold; clickerUnder_text.fontSize = 44;
        loungerUnder_text.text = "LOUNGER"; loungerUnder_text.font = russian_SemiBold; loungerUnder_text.fontSize = 44;
        pirateUnder_text.text = "PIRATE"; pirateUnder_text.font = russian_SemiBold; pirateUnder_text.fontSize = 44;
        hoarderUnder_text.text = "HOARDER"; hoarderUnder_text.font = russian_SemiBold; hoarderUnder_text.fontSize = 44;
        adventurerUnder_text.text = "ADVENTURER"; adventurerUnder_text.font = russian_SemiBold; adventurerUnder_text.fontSize = 44;

        bossChestPresitgeName_text.text = "СУНДУК БОССА"; bossChestPresitgeName_text.font = russianNono_Bold; bossChestPresitgeName_text.fontSize = 24;
        reinforcedItems_text.text = "Укрепленные Предметы"; reinforcedItems_text.font = russianNono_Bold; reinforcedItems_text.fontSize = 14;
        potionStacker_text.text = "Стопка Зелий"; potionStacker_text.font = russianNono_Bold; potionStacker_text.fontSize = 24;
        fortifiedItems_text.text = "Укрепленные Предметы"; fortifiedItems_text.font = russianNono_Bold; fortifiedItems_text.fontSize = 14;
        enhancedItems_text.text = "Улучшенные Предметы"; enhancedItems_text.font = russianNono_Bold; enhancedItems_text.fontSize = 15;
        enchantedItems_text.text = "Зачарованные Предметы"; enchantedItems_text.font = russianNono_Bold; enchantedItems_text.fontSize = 13;
        itemMastery_text.text = "Освоение Предмета"; itemMastery_text.font = russianNono_Bold; itemMastery_text.fontSize = 16;
        enchantmentQuill_text.text = "Перо Зачарования"; enchantmentQuill_text.font = russianNono_Bold; enchantmentQuill_text.fontSize = 18;
        wizard_text.text = "Волшебник"; wizard_text.font = russianNono_Bold; wizard_text.fontSize = 26;
        student_text.text = "Студент"; student_text.font = russianNono_Bold; student_text.fontSize = 26;
        potionChug_text.text = "Залп Зелий"; potionChug_text.font = russianNono_Bold; potionChug_text.fontSize = 26;
        transcendence_text.text = "Трансцендентность"; transcendence_text.font = russianNono_Bold; transcendence_text.fontSize = 15;
        elevation_text.text = "Возвышение"; elevation_text.font = russianNono_Bold; elevation_text.fontSize = 26;
        xpAccelerator_text.text = "Ускоритель Опыта"; xpAccelerator_text.font = russianNono_Bold; xpAccelerator_text.fontSize = 17;
        proficiency_text.text = "Профессионализм"; proficiency_text.font = russianNono_Bold; proficiency_text.fontSize = 18;
        levelMastery_text.text = "Освоение Уровня"; levelMastery_text.font = russianNono_Bold; levelMastery_text.fontSize = 19;
        advancement_text.text = "Прогресс"; advancement_text.font = russianNono_Bold; advancement_text.fontSize = 26;
        xpBoost_text.text = "Усилитель Опыта"; xpBoost_text.font = russianNono_Bold; xpBoost_text.fontSize = 21;
        masterPirate_text.text = "Пират-Мастер"; masterPirate_text.font = russianNono_Bold; masterPirate_text.fontSize = 24;
        fortuneSeeker_text.text = "Искатель Счастья"; fortuneSeeker_text.font = russianNono_Bold; fortuneSeeker_text.fontSize = 18;
        pirate_text.text = "Пират"; pirate_text.font = russianNono_Bold; pirate_text.fontSize = 26;
        rapidLeveling_text.text = "Быстрое Повышение Уровня"; rapidLeveling_text.font = russianNono_Bold; rapidLeveling_text.fontSize = 14;
        treasureAmplifier_text.text = "Усилитель Сокровищ"; treasureAmplifier_text.font = russianNono_Bold; treasureAmplifier_text.fontSize = 17;
        stackingSplendor_text.text = "Славное Накопление"; stackingSplendor_text.font = russianNono_Bold; stackingSplendor_text.fontSize = 15;
        goodieBag_text.text = "Мешок Лакомств"; goodieBag_text.font = russianNono_Bold; goodieBag_text.fontSize = 20;
        reinforcedRiches_text.text = "Укрепленные Богатства"; reinforcedRiches_text.font = russianNono_Bold; reinforcedRiches_text.fontSize = 14;
        chestBlessing_text.text = "Благословение Сундука"; chestBlessing_text.font = russianNono_Bold; chestBlessing_text.fontSize = 14;
        chestSurge_text.text = "Всплеск Сундука"; chestSurge_text.font = russianNono_Bold; chestSurge_text.fontSize = 19;
        fortifiedFortune_text.text = "Укрепленное Счастье"; fortifiedFortune_text.font = russianNono_Bold; fortifiedFortune_text.fontSize = 16;
        enchantedGoldenChest_text.text = "Зачарованный Золотой Сундук"; enchantedGoldenChest_text.font = russianNono_Bold; enchantedGoldenChest_text.fontSize = 12;
        piratesParadise_text.text = "Рай Пирата"; piratesParadise_text.font = russianNono_Bold; piratesParadise_text.fontSize = 23;
        luxuriousLooting_text.text = "Роскошный Лут"; luxuriousLooting_text.font = russianNono_Bold; luxuriousLooting_text.fontSize = 21;
        lootBonanza_text.text = "Бонанза Лута"; lootBonanza_text.font = russianNono_Bold; lootBonanza_text.fontSize = 24;
        chestEnrichment_text.text = "Обогащение Сундука"; chestEnrichment_text.font = russianNono_Bold; chestEnrichment_text.fontSize = 16;
        greaterLoot_text.text = "Больше Лута"; greaterLoot_text.font = russianNono_Bold; greaterLoot_text.fontSize = 26;
        treasuryReinforcement_text.text = "Укрепление Казначейства"; treasuryReinforcement_text.font = russianNono_Bold; treasuryReinforcement_text.fontSize = 13;
        strongbox_text.text = "Сейф"; strongbox_text.font = russianNono_Bold; strongbox_text.fontSize = 27;
        fortified_text.text = "Укрепленный "; fortified_text.font = russianNono_Bold; fortified_text.fontSize = 26;
        gildedFortification_text.text = "Золотое Укрепление"; gildedFortification_text.font = russianNono_Bold; gildedFortification_text.fontSize = 17;
        reinforcedPlus_text.text = "Укрепленный +"; reinforcedPlus_text.font = russianNono_Bold; reinforcedPlus_text.fontSize = 22;
        wellPrepared_text.text = "Хорошо Подготовленный"; wellPrepared_text.font = russianNono_Bold; wellPrepared_text.fontSize = 13;
        stashedItems_text.text = "Спрятанные Предметы"; stashedItems_text.font = russianNono_Bold; stashedItems_text.fontSize = 15;
        travelBag_text.text = "Сумка Путешественника"; travelBag_text.font = russianNono_Bold; travelBag_text.fontSize = 14;
        buffsGalore_text.text = "Множество Бафов"; buffsGalore_text.font = russianNono_Bold; buffsGalore_text.fontSize = 18;
        lootEnhancer_text.text = "Улучшитель Лута"; lootEnhancer_text.font = russianNono_Bold; lootEnhancer_text.fontSize = 19;
        treasureHunter_text.text = "Охотник за Сокровищами"; treasureHunter_text.font = russianNono_Bold; treasureHunter_text.fontSize = 14;
        collector_text.text = "Коллекционер"; collector_text.font = russianNono_Bold; collector_text.fontSize = 24;
        autoClicker1_text.text = "Авто Кликер "; autoClicker1_text.font = russianNono_Bold; autoClicker1_text.fontSize = 26;
        autoClicker2_text.text = "Авто Кликер +"; autoClicker2_text.font = russianNono_Bold; autoClicker2_text.fontSize = 26;
        autoClicker3_text.text = "Авто Кликер ++"; autoClicker3_text.font = russianNono_Bold; autoClicker3_text.fontSize = 21;
        autoClicker4_text.text = "Быстрый Кликер"; autoClicker4_text.font = russianNono_Bold; autoClicker4_text.fontSize = 20;
        cursorEnchantment_text.text = "Зачарование Курсора"; cursorEnchantment_text.font = russianNono_Bold; cursorEnchantment_text.fontSize = 15;
        advancedCursors_text.text = "Продвинутые Курсоры"; advancedCursors_text.font = russianNono_Bold; advancedCursors_text.fontSize = 15;
        cursorEvolution_text.text = "Эволюция Курсора"; cursorEvolution_text.font = russianNono_Bold; cursorEvolution_text.fontSize = 19;
        cursorEnhanced_text.text = "Улучшенный Курсор"; cursorEnhanced_text.font = russianNono_Bold; cursorEnhanced_text.fontSize = 17;
        crushingForce_text.text = "Сокрушительная Сила"; crushingForce_text.font = russianNono_Bold; crushingForce_text.fontSize = 15;
        swiftblade_text.text = "Быстрый Клинок"; swiftblade_text.font = russianNono_Bold; swiftblade_text.fontSize = 19;
        fury_text.text = "Ярость"; fury_text.font = russianNono_Bold; fury_text.fontSize = 26;
        clickstorm_text.text = "Шторм Кликов"; clickstorm_text.font = russianNono_Bold; clickstorm_text.fontSize = 21;
        tapPrecision_text.text = "Точность Тапа"; tapPrecision_text.font = russianNono_Bold; tapPrecision_text.fontSize = 22;
        clickersFury_text.text = "Ярость Кликера"; clickersFury_text.font = russianNono_Bold; clickersFury_text.fontSize = 22;
        tapMastery_text.text = "Мастер Тапа"; tapMastery_text.font = russianNono_Bold; tapMastery_text.fontSize = 26;
        cripplingStrikes_text.text = "Сокрушительные Удары"; cripplingStrikes_text.font = russianNono_Bold; cripplingStrikes_text.fontSize = 13;
        savageCrits_text.text = "Свирепые Криты"; savageCrits_text.font = russianNono_Bold; savageCrits_text.fontSize = 19;
        lethalPrecision_text.text = "Смертоносная Точность"; lethalPrecision_text.font = russianNono_Bold; lethalPrecision_text.fontSize = 14;
        ruthlessStrikes_text.text = "Безжалостные Удары"; ruthlessStrikes_text.font = russianNono_Bold; ruthlessStrikes_text.fontSize = 16;
        hardenedFist_text.text = "Окаменевший Кулак"; hardenedFist_text.font = russianNono_Bold; hardenedFist_text.fontSize = 16;
        idler_text.text = "Лентяй"; idler_text.font = russianNono_Bold; idler_text.fontSize = 26;
        lazyRewards_text.text = "Ленивые Награды"; lazyRewards_text.font = russianNono_Bold; lazyRewards_text.fontSize = 18;
        unfathomableWealth_text.text = "НЕПОСТИЖИМОЕ БОГАТСТВО"; unfathomableWealth_text.font = russianNono_Bold; unfathomableWealth_text.fontSize = 11;
        ancientCoin_text.text = "Древняя Монета"; ancientCoin_text.font = russianNono_Bold; ancientCoin_text.fontSize = 19;
        fortuneCoin_text.text = "Монета Судьбы"; fortuneCoin_text.font = russianNono_Bold; fortuneCoin_text.fontSize = 21;
        wealthEmpire_text.text = "Империя Богатства"; wealthEmpire_text.font = russianNono_Bold; wealthEmpire_text.fontSize = 17;
        luckyPenny_text.text = "Счастливая Копейка"; luckyPenny_text.font = russianNono_Bold; luckyPenny_text.fontSize = 16;
        fortune_text.text = "Судьба"; fortune_text.font = russianNono_Bold; fortune_text.fontSize = 26;
        extremelyWealthy_text.text = "Чрезвычайно Богатый"; extremelyWealthy_text.font = russianNono_Bold; extremelyWealthy_text.fontSize = 14;
        wealthy_text.text = "Богатый"; wealthy_text.font = russianNono_Bold; wealthy_text.fontSize = 26;
        idlersMastery_text.text = "Мастер Лентяя"; idlersMastery_text.font = russianNono_Bold; idlersMastery_text.fontSize = 23;
        wealth_text.text = "Богатство"; wealth_text.font = russianNono_Bold; wealth_text.fontSize = 26;
        potentCursors_text.text = "Мощные Курсоры"; potentCursors_text.font = russianNono_Bold; potentCursors_text.fontSize = 18;
        mightyCursors_text.text = "Могучие Курсоры"; mightyCursors_text.font = russianNono_Bold; mightyCursors_text.fontSize = 19;
        reforgedCursors_text.text = "Перекованные Курсоры"; reforgedCursors_text.font = russianNono_Bold; reforgedCursors_text.fontSize = 15;
        sloppyFist_text.text = "Неуклюжий Кулак"; sloppyFist_text.font = russianNono_Bold; sloppyFist_text.fontSize = 19;
        effortless_text.text = "Безнапряжный"; effortless_text.font = russianNono_Bold; effortless_text.fontSize = 21;
        loungingKing_text.text = "Король Отдыха"; loungingKing_text.font = russianNono_Bold; loungingKing_text.fontSize = 22;
        loungingPirate_text.text = "Пират Отдыха"; loungingPirate_text.font = russianNono_Bold; loungingPirate_text.fontSize = 24;
        loungingOgre_text.text = "Огр Отдыха"; loungingOgre_text.font = russianNono_Bold; loungingOgre_text.fontSize = 26;
        restfulIdler_text.text = "Отдыхающий Лент"; restfulIdler_text.font = russianNono_Bold; restfulIdler_text.fontSize = 17;
        cursorMastery_text.text = "Мастерство Курсора"; cursorMastery_text.font = russianNono_Bold; cursorMastery_text.fontSize = 17;

        // Crit Descriptions
        critDes1_text.text = "+0.5% Шанс Крита";
        critDes1_2_text.text = "+150% Урон Крита";
        critDes2_text.text = "+1.5% Шанс Крита";
        critDes2_2_text.text = "+750% Урон Крита";
        critDes3_text.text = "+1.8% Шанс Крита";
        critDes3_2_text.text = "+1500% Урон Крита";
        critDes4_text.text = "+2.2% Шанс Крита";
        critDes4_2_text.text = "+10% шанс спауна золотой монеты при критическом ударе";
        critDes5_text.text = "+2500% Шанс Крита";
        critDes5_2_text.text = "+4% шанс спауна сокровища при критическом ударе";

        critDes1_text.font = russianNono_Medium;
        critDes1_2_text.font = russianNono_Medium;
        critDes2_text.font = russianNono_Medium;
        critDes2_2_text.font = russianNono_Medium;
        critDes3_text.font = russianNono_Medium;
        critDes3_2_text.font = russianNono_Medium;
        critDes4_text.font = russianNono_Medium;
        critDes4_2_text.font = russianNono_Medium;
        critDes5_text.font = russianNono_Medium;
        critDes5_2_text.font = russianNono_Medium;

        critDes1_text.fontSize = 15;
        critDes1_2_text.fontSize = 15;
        critDes2_text.fontSize = 15;
        critDes2_2_text.fontSize = 15;
        critDes3_text.fontSize = 15;
        critDes3_2_text.fontSize = 15;
        critDes4_text.fontSize = 15;
        critDes4_2_text.fontSize = 15;
        critDes5_text.fontSize = 15;
        critDes5_2_text.fontSize = 15;

        // Active Descriptions
        activeDes1_text.text = "+50% активный урон";
        activeDes2_text.text = "+325% активный урон";
        activeDes3_text.text = "+1000% активный урон";
        activeDes4_text.text = "+2250% активный урон";
        activeDes4_2_text.text = "+1% шанс спауна золотой монеты при каждом клике";
        activeDes5_text.text = "+3500% активный урон";
        activeDes5_2_text.text = "+0.1% шанс спауна сокровища при каждом клике";
        activeDes6_text.text = "+10000% активный урон";
        activeDes6_2_text.text = "Каждый клик имеет +0.4% шанс мгновенно открыть сундук";
        activeDes7_text.text = "+15000% активный урон";
        activeDes7_2_text.text = "Каждый клик имеет 1% шанс спауна золотой монеты х5";

        activeDes1_text.font = russianNono_Medium;
        activeDes2_text.font = russianNono_Medium;
        activeDes3_text.font = russianNono_Medium;
        activeDes4_text.font = russianNono_Medium;
        activeDes4_2_text.font = russianNono_Medium;
        activeDes5_text.font = russianNono_Medium;
        activeDes5_2_text.font = russianNono_Medium;
        activeDes6_text.font = russianNono_Medium;
        activeDes6_2_text.font = russianNono_Medium;
        activeDes7_text.font = russianNono_Medium;
        activeDes7_2_text.font = russianNono_Medium;

        activeDes1_text.fontSize = 15;
        activeDes2_text.fontSize = 15;
        activeDes3_text.fontSize = 15;
        activeDes4_text.fontSize = 15;
        activeDes4_2_text.fontSize = 15;
        activeDes5_text.fontSize = 15;
        activeDes5_2_text.fontSize = 15;
        activeDes6_text.fontSize = 15;
        activeDes6_2_text.fontSize = 15;
        activeDes7_text.fontSize = 15;
        activeDes7_2_text.fontSize = 14.9f;

        // Active Cursor Descriptions
        activeCursorDes1_text.text = "Повышение уровня курсоров с активным уроном, шансом крита и критическим уроном делает их сильнее";
        activeCursorDes2_text.text = "Повышение уровня курсоров с активным уроном, шансом крита и критическим уроном делает их сильнее";
        activeCursorDes3_text.text = "Все курсоры с активным уроном, шансом крита и критическим уроном становятся сильнее с самого начала";
        activeCursorDes4_text.text = "Все курсоры с активным уроном, шансом крита и критическим уроном становятся сильнее с самого начала";
        activeCursorDes4_2_text.text = "Повышение уровня курсоров с активным уроном, шансом крита и критическим уроном делает их сильнее";

        activeCursorDes1_text.font = russianNono_Medium;
        activeCursorDes2_text.font = russianNono_Medium;
        activeCursorDes3_text.font = russianNono_Medium;
        activeCursorDes4_text.font = russianNono_Medium;
        activeCursorDes4_2_text.font = russianNono_Medium;

        activeCursorDes1_text.fontSize = 10;
        activeCursorDes2_text.fontSize = 10;
        activeCursorDes3_text.fontSize = 10;
        activeCursorDes4_text.fontSize = 10;
        activeCursorDes4_2_text.fontSize = 10f;

        // Auto Clicker Descriptions
        autoClickerDes1_text.text = "Авто-кликер совершает 1 клик в секунду";
        autoClickerDes1_2_text.text = "Каждый клик наносит 100% вашего общего активного урона";
        autoClickerDes2_text.text = "Авто-кликер совершает 2 клик в секунду";
        autoClickerDes3_text.text = "Авто-кликер совершает 4 клик в секунду";
        autoClickerDes4_text.text = "Авто-кликер совершает 8 клик в секунду";

        autoClickerDes1_text.font = russianNono_Medium;
        autoClickerDes1_2_text.font = russianNono_Medium;
        autoClickerDes2_text.font = russianNono_Medium;
        autoClickerDes3_text.font = russianNono_Medium;
        autoClickerDes4_text.font = russianNono_Medium;

        autoClickerDes1_text.fontSize = 14;
        autoClickerDes1_2_text.fontSize = 14;
        autoClickerDes2_text.fontSize = 14;
        autoClickerDes3_text.fontSize = 14;
        autoClickerDes4_text.fontSize = 14;

        // Passive Descriptions
        passiveDes1_text.text = "+25% пассивный урон";
        passiveDes2_text.text = "+115% пассивный урон";
        passiveDes3_text.text = "+400% пассивный урон";
        passiveDes3_2_text.text = "Спаунит 1 золотую монету на каждые 7 открытых сундуков";
        passiveDes4_text.text = "+850% пассивный урон";
        passiveDes4_2_text.text = "Спаунит 1 сокровище на каждые 25 открытых сундуков";
        passiveDes5_text.text = "+1100% пассивный урон";
        passiveDes6_text.text = "+1600% пассивный урон";
        passiveDes6_2_text.text = "Спаунит 1 сокровище и 4 золотых монеты на каждые 25 открытых сундуков";
        passiveDes7_text.text = "+3500% пассивный урон";
        passiveDes7_2_text.text = "Каждый сундук дает 1 дополнительную золотую монету";
        passiveDes8_text.text = "+6500% пассивный урон";

        passiveDes1_text.font = russianNono_Medium;
        passiveDes2_text.font = russianNono_Medium;
        passiveDes3_text.font = russianNono_Medium;
        passiveDes3_2_text.font = russianNono_Medium;
        passiveDes4_text.font = russianNono_Medium;
        passiveDes4_2_text.font = russianNono_Medium;
        passiveDes5_text.font = russianNono_Medium;
        passiveDes6_text.font = russianNono_Medium;
        passiveDes6_2_text.font = russianNono_Medium;
        passiveDes7_text.font = russianNono_Medium;
        passiveDes7_2_text.font = russianNono_Medium;
        passiveDes8_text.font = russianNono_Medium;

        passiveDes1_text.fontSize = 15;
        passiveDes2_text.fontSize = 15;
        passiveDes3_text.fontSize = 15;
        passiveDes3_2_text.fontSize = 15;
        passiveDes4_text.fontSize = 15;
        passiveDes4_2_text.fontSize = 15;
        passiveDes5_text.fontSize = 15;
        passiveDes6_text.fontSize = 15;
        passiveDes6_2_text.fontSize = 13;
        passiveDes7_text.fontSize = 15;
        passiveDes7_2_text.fontSize = 15;
        passiveDes8_text.fontSize = 15;

        // Passive Cursor Descriptions
        passiveCursorDes1_text.text = "Повышение уровня курсоров с пассивным уроном делает их сильнее";
        passiveCursorDes2_text.text = "Повышение уровня курсоров с пассивным уроном делает их сильнее";
        passiveCursorDes3_text.text = "Курсоры с пассивным уроном с самого начала становятся сильнее";
        passiveCursorDes4_text.text = "Курсоры с пассивным уроном с самого начала становятся сильнее";
        passiveCursorDes4_2_text.text = "Повышение уровня курсоров с пассивным уроном делает их сильнее";
        passiveCursorDes5_text.text = "Курсоры с пассивным уроном с самого начала становятся сильнее";
        passiveCursorDes5_2_text.text = "Повышение уровня курсоров с пассивным уроном делает их сильнее";

        passiveCursorDes1_text.font = russianNono_Medium;
        passiveCursorDes2_text.font = russianNono_Medium;
        passiveCursorDes3_text.font = russianNono_Medium;
        passiveCursorDes4_text.font = russianNono_Medium;
        passiveCursorDes4_2_text.font = russianNono_Medium;
        passiveCursorDes5_text.font = russianNono_Medium;
        passiveCursorDes5_2_text.font = russianNono_Medium;

        passiveCursorDes1_text.fontSize = 12;
        passiveCursorDes2_text.fontSize = 12;
        passiveCursorDes3_text.fontSize = 12;
        passiveCursorDes4_text.fontSize = 12f;
        passiveCursorDes4_2_text.fontSize = 12;
        passiveCursorDes5_text.fontSize = 12f;
        passiveCursorDes5_2_text.fontSize = 12;

        // Gold Descriptions
        goldDes1_text.text = "Золотые монеты дают +30% больше золота";
        goldDes2_text.text = "Золотые монеты дают +120% больше золота";
        goldDes3_text.text = "Золотые монеты дают +500% больше золота";
        goldDes4_text.text = "Золотые монеты дают +1000% больше золота";
        goldDes4_2_text.text = "У золотых монет 3% шанс стоить в 2 раза дороже";
        goldDes5_text.text = "У сундуков 3% шанс дропнуть золотую монету х5.";
        goldDes6_text.text = "Золотые монеты дают +2000% больше золота";
        goldDes7_text.text = "У сундуков 2% шанс дропнуть золотую монету х10.";
        goldDes7_2_text.text = "Золотые монеты дают +1250% больше золота";
        goldDes8_text.text = "У сундуков 1% шанс дропнуть золотую монету х25.";
        goldDes8_2_text.text = "Золотые монеты дают +4000% больше золота";
        goldDes9_text.text = "Только монеты х5, х10 и х25 будут выпадать из сундуков.";
        goldDes9_2_text.text = "Золотые монеты дают +5000% больше золота";

        goldDes1_text.font = russianNono_Medium;
        goldDes2_text.font = russianNono_Medium;
        goldDes3_text.font = russianNono_Medium;
        goldDes4_text.font = russianNono_Medium;
        goldDes4_2_text.font = russianNono_Medium;
        goldDes5_text.font = russianNono_Medium;
        goldDes6_text.font = russianNono_Medium;
        goldDes7_text.font = russianNono_Medium;
        goldDes7_2_text.font = russianNono_Medium;
        goldDes8_text.font = russianNono_Medium;
        goldDes8_2_text.font = russianNono_Medium;
        goldDes9_text.font = russianNono_Medium;
        goldDes9_2_text.font = russianNono_Medium;

        goldDes1_text.fontSize = 14;
        goldDes2_text.fontSize = 14;
        goldDes3_text.fontSize = 14;
        goldDes4_text.fontSize = 14;
        goldDes4_2_text.fontSize = 14;
        goldDes5_text.fontSize = 14;
        goldDes6_text.fontSize = 14;
        goldDes7_text.fontSize = 14;
        goldDes7_2_text.fontSize = 14;
        goldDes8_text.fontSize = 14;
        goldDes8_2_text.fontSize = 14;
        goldDes9_text.fontSize = 14;
        goldDes9_2_text.fontSize = 14;

        // Treasure Descriptions
        treasureDes1_text.text = "+0.1% ШАНС ВЫПАДЕНИЯ СОКРОВИЩА";
        treasureDes2_text.text = "+0.2% ШАНС ВЫПАДЕНИЯ СОКРОВИЩА";
        treasureDes3_text.text = "+8% шанс удвоить стоимость сокровища";
        treasureDes4_text.text = "+5% шанс удвоить стоимость сокровища";
        treasureDes4_2_text.text = "+0.2% ШАНС ВЫПАДЕНИЯ СОКРОВИЩА";
        treasureDes5_text.text = "+10% шанс удвоить стоимость сокровища";
        treasureDes5_2_text.text = "+0.2% ШАНС ВЫПАДЕНИЯ СОКРОВИЩА";
        treasureDes6_text.text = "+13% шанс удвоить стоимость сокровища";
        treasureDes6_2_text.text = "1% шанс дропа мешка с сокровищами";
        treasureDes7_text.text = "+0.4% ШАНС ВЫПАДЕНИЯ СОКРОВИЩА";
        treasureDes7_2_text.text = "Проданные сокровища теперь стоят в 5 раз дороже.";

        treasureDes1_text.font = russianNono_Medium;
        treasureDes2_text.font = russianNono_Medium;
        treasureDes3_text.font = russianNono_Medium;
        treasureDes4_text.font = russianNono_Medium;
        treasureDes4_2_text.font = russianNono_Medium;
        treasureDes5_text.font = russianNono_Medium;
        treasureDes5_2_text.font = russianNono_Medium;
        treasureDes6_text.font = russianNono_Medium;
        treasureDes6_2_text.font = russianNono_Medium;
        treasureDes7_text.font = russianNono_Medium;
        treasureDes7_2_text.font = russianNono_Medium;

        treasureDes1_text.fontSize = 14;
        treasureDes2_text.fontSize = 14;
        treasureDes3_text.fontSize = 14;
        treasureDes4_text.fontSize = 14;
        treasureDes4_2_text.fontSize = 14;
        treasureDes5_text.fontSize = 14;
        treasureDes6_text.fontSize = 14;
        treasureDes6_2_text.fontSize = 14;
        treasureDes7_text.fontSize = 14;
        treasureDes7_2_text.fontSize = 14;

        // XP Descriptions
        xpDes1_text.text = "+35% ОПЫТ";
        xpDes2_text.text = "+125% ОПЫТ";
        xpDes3_text.text = "+400% ОПЫТ";
        xpDes4_text.text = "+900% ОПЫТ";
        xpDes5_text.text = "+1300% ОПЫТ";
        xpDes6_text.text = "+2500% ОПЫТ";
        xpDes6_2_text.text = "Каждый дроп опыта имеет +0.25% шанс дать +1 очко навыка";
        xpDes7_text.text = "+4000% ОПЫТ";
        xpDes7_2_text.text = "Каждый дроп опыта имеет +0.75% шанс дать +1 очко навыка";
        xpDes8_text.text = "+7500% ОПЫТ";
        xpDes8_2_text.text = "Каждый дроп опыта имеет +1% шанс дать +1 очко навыка";

        xpDes1_text.font = russianNono_Medium;
        xpDes2_text.font = russianNono_Medium;
        xpDes3_text.font = russianNono_Medium;
        xpDes4_text.font = russianNono_Medium;
        xpDes5_text.font = russianNono_Medium;
        xpDes6_text.font = russianNono_Medium;
        xpDes6_2_text.font = russianNono_Medium;
        xpDes7_text.font = russianNono_Medium;
        xpDes7_2_text.font = russianNono_Medium;
        xpDes8_text.font = russianNono_Medium;
        xpDes8_2_text.font = russianNono_Medium;

        xpDes1_text.fontSize = 15;
        xpDes2_text.fontSize = 15;
        xpDes3_text.fontSize = 15;
        xpDes4_text.fontSize = 15;
        xpDes5_text.fontSize = 15;
        xpDes6_text.fontSize = 15;
        xpDes6_2_text.fontSize = 15;
        xpDes7_text.fontSize = 15;
        xpDes7_2_text.fontSize = 15;
        xpDes8_text.fontSize = 15;
        xpDes8_2_text.fontSize = 15;

        // Level Special Descriptions
        levelSpecialDes1_text.text = "Повышение уровня предметов делает их сильнее";
        levelSpecialDes2_text.text = "Повышение уровня предметов делает их сильнее";
        levelSpecialDes3_text.text = "Повышение уровня предметов делает их сильнее";
        levelSpecialDes4_text.text = "Повышение уровня предметов делает их сильнее";
        levelSpecialDes5_text.text = "Повышение уровня предметов делает их сильнее";

        levelSpecialDes1_text.font = russianNono_Medium;
        levelSpecialDes2_text.font = russianNono_Medium;
        levelSpecialDes3_text.font = russianNono_Medium;
        levelSpecialDes4_text.font = russianNono_Medium;
        levelSpecialDes5_text.font = russianNono_Medium;

        levelSpecialDes1_text.fontSize = 14;
        levelSpecialDes2_text.fontSize = 14;
        levelSpecialDes3_text.fontSize = 14;
        levelSpecialDes4_text.fontSize = 14;
        levelSpecialDes5_text.fontSize = 14;

        // Stronger Special Descriptions
        strongerSpecialDes1_text.text = "Все предметы с самого начала становятся сильнее";
        strongerSpecialDes2_text.text = "Все предметы с самого начала становятся сильнее";
        strongerSpecialDes3_text.text = "Теперь можно накладывать зелья +1 раз";
        strongerSpecialDes4_text.text = "Предметы, выпавшие из сундуков, имеют 10% шанс удвоить свою стоимость";
        strongerSpecialDes5_text.text = "Теперь можно накладывать зелья +1 раз";
        strongerSpecialDes5_2_text.text = "Все предметы с самого начала становятся сильнее";
        strongerSpecialDes6_text.text = "Теперь вы можете накладывать Молот, Золотой Касание, Свиток Серендипити и Рукавицу Алчности";
        strongerSpecialDes7_text.text = "Свиток Серендипити и древняя реликвия дают сильные баффы";

        strongerSpecialDes1_text.font = russianNono_Medium;
        strongerSpecialDes2_text.font = russianNono_Medium;
        strongerSpecialDes3_text.font = russianNono_Medium;
        strongerSpecialDes4_text.font = russianNono_Medium;
        strongerSpecialDes5_text.font = russianNono_Medium;
        strongerSpecialDes5_2_text.font = russianNono_Medium;
        strongerSpecialDes6_text.font = russianNono_Medium;
        strongerSpecialDes7_text.font = russianNono_Medium;

        strongerSpecialDes1_text.fontSize = 14;
        strongerSpecialDes2_text.fontSize = 14;
        strongerSpecialDes3_text.fontSize = 14;
        strongerSpecialDes4_text.fontSize = 14;
        strongerSpecialDes5_text.fontSize = 14;
        strongerSpecialDes5_2_text.fontSize = 14;
        strongerSpecialDes6_text.fontSize = 14;
        strongerSpecialDes7_text.fontSize = 14;

        // Start With Descriptions
        startWithDes1_text.text = "Выберите 1 предмет после каждого престижа (Вы можете выбрать только те предметы, которые были приобретены один раз)";
        startWithDes2_text.text = "Выберите 2 предмет после каждого престижа";
        startWithDes3_text.text = "Выберите 3 предмет после каждого престижа";
        startWithDes4_text.text = "Выберите 5 предмет после каждого престижа";

        startWithDes1_text.font = russianNono_Medium;
        startWithDes2_text.font = russianNono_Medium;
        startWithDes3_text.font = russianNono_Medium;
        startWithDes4_text.font = russianNono_Medium;

        startWithDes1_text.fontSize = 13;
        startWithDes2_text.fontSize = 13;
        startWithDes3_text.fontSize = 13;
        startWithDes4_text.fontSize = 13;

        // Reinforced Descriptions
        reinforcedDes1_text.text = "Золотые монеты, выпавшие из усиленных сундуков, теперь стоят в 17 раз дороже";
        reinforcedDes1_2_text.text = "+0.1% Шанс на укреплённый сундук";
        reinforcedDes2_text.text = "Золотые монеты, выпавшие из усиленных сундуков, теперь стоят в 24 раз дороже";
        reinforcedDes2_2_text.text = "Теперь у усиленных сундуков 9X здоровья";
        reinforcedDes2_3_text.text = "Усиленные сундуки теперь дают 6X опыта";
        reinforcedDes3_text.text = "Золотые монеты, выпавшие из усиленных сундуков, теперь стоят в 33 раз дороже";
        reinforcedDes3_2_text.text = "+0.3% Шанс на укреплённый сундук";
        reinforcedDes4_text.text = "Золотые монеты, выпавшие из усиленных сундуков, теперь стоят в 47 раз дороже";
        reinforcedDes4_2_text.text = "+0.5% Шанс на укреплённый сундук";
        reinforcedDes4_3_text.text = "Теперь у усиленных сундуков 8X здоровья";
        reinforcedDes4_4_text.text = "Усиленные сундуки теперь дают 11X опыта";
        reinforcedDes5_text.text = "Золотые монеты, выпавшие из усиленных сундуков, теперь стоят в 85 раз дороже";
        reinforcedDes5_2_text.text = "+1% Шанс на укреплённый сундук";

        reinforcedDes1_text.font = russianNono_Medium;
        reinforcedDes1_2_text.font = russianNono_Medium;
        reinforcedDes2_text.font = russianNono_Medium;
        reinforcedDes2_2_text.font = russianNono_Medium;
        reinforcedDes2_3_text.font = russianNono_Medium;
        reinforcedDes3_text.font = russianNono_Medium;
        reinforcedDes3_2_text.font = russianNono_Medium;
        reinforcedDes4_text.font = russianNono_Medium;
        reinforcedDes4_2_text.font = russianNono_Medium;
        reinforcedDes4_3_text.font = russianNono_Medium;
        reinforcedDes4_4_text.font = russianNono_Medium;
        reinforcedDes5_text.font = russianNono_Medium;
        reinforcedDes5_2_text.font = russianNono_Medium;

        reinforcedDes1_text.fontSize = 13;
        reinforcedDes1_2_text.fontSize = 13;
        reinforcedDes2_text.fontSize = 13;
        reinforcedDes2_2_text.fontSize = 13;
        reinforcedDes2_3_text.fontSize = 13;
        reinforcedDes3_text.fontSize = 13;
        reinforcedDes3_2_text.fontSize = 13;
        reinforcedDes4_text.fontSize = 13;
        reinforcedDes4_2_text.fontSize = 13;
        reinforcedDes4_3_text.fontSize = 13;
        reinforcedDes4_4_text.fontSize = 13;
        reinforcedDes5_text.fontSize = 13;
        reinforcedDes5_2_text.fontSize = 13;

        // More Loot Descriptions
        moreLootDes1_text.text = "Каждые 10 открытых сундуков дают 1 дополнительную золотую монету";
        moreLootDes2_text.text = "Каждые 19 открытых сундуков дают золотую монету 5X и 3X опыта";
        moreLootDes3_text.text = "Каждые 18 открытых сундуков дают 2-4 золотые монеты, все они 5X или 10X золотые монеты. Также дают 5X опыта";
        moreLootDes4_text.text = "Каждые 30 открытых сундуков дают 3 золотые монеты, все они 25X золотые монеты и 2-5 сокровищ";
        moreLootDes5_text.text = "Каждый открытый сундук дает золотую монету 5X и имеет 5% шанс дать золотую монету 10X и 2.5% шанс дать золотую монету 25X. Также даёт 2X опыта";

        moreLootDes1_text.font = russianNono_Medium;
        moreLootDes2_text.font = russianNono_Medium;
        moreLootDes3_text.font = russianNono_Medium;
        moreLootDes4_text.font = russianNono_Medium;
        moreLootDes5_text.font = russianNono_Medium;

        moreLootDes1_text.fontSize = 13;
        moreLootDes2_text.fontSize = 13;
        moreLootDes3_text.fontSize = 13;
        moreLootDes4_text.fontSize = 13;
        moreLootDes5_text.fontSize = 13;

        // New Chests Descriptions
        newChestsDes1_text.text = "Волшебный золотой сундук имеет 0.2% шанс появиться";
        newChestsDes1_2_text.text = "У волшебных золотых сундуков 30X здоровья. Упадет 20 сокровищ. Отмычки и ключи убирают только 33% здоровья сундука.";
        newChestsDes1_3_text.text = "Узнайте больше о этом сундуке, когда он появится или в настройках.";
        newChestsDes2_text.text = "СУНДУК БОССА имеет 0.1% шанс появиться";
        newChestsDes2_2_text.text = "У СУНДУКОВ БОССА 100X здоровья.\nСундуки босса уронят 25 золотых монет, все они х10 и х25 золотые монеты.";
        newChestsDes2_3_text.text = "Узнайте больше о сундуках босса, когда они появятся или в настройках.";
        newChestsDes3_text.text = "У СУНДУКА БОССА +0.05% шанс появиться";
        newChestsDes3_2_text.text = "У ВОЛШЕБНЫХ ЗОЛОТЫХ СУНДУКОВ +0.1% шанс появиться";
        newChestsDes4_text.text = "У СУНДУКА БОССА +0.1% шанс появиться";
        newChestsDes4_2_text.text = "У ВОЛШЕБНЫХ ЗОЛОТЫХ СУНДУКОВ +0.15% шанс появиться";
        newChestsDes4_3_text.text = "Волшебные золотые сундуки уронят 25 сокровищ.\nСундуки босса уронят 30 золотых монет";
        newChestsDes5_text.text = "Волшебные золотые сундуки уронят 30 сокровищ.\nСундуки босса уронят 35 золотых монет, все они х25 золотые монеты.";
        newChestsDes5_2_text.text = "У ВОЛШЕБНЫХ ЗОЛОТЫХ СУНДУКОВ +0.2% шанс появиться";
        newChestsDes5_3_text.text = "У СУНДУКА БОССА +0.15% шанс появиться";
        newChestsDes6_text.text = "У СУНДУКА БОССА +0.4% шанс появиться";
        newChestsDes6_2_text.text = "У ВОЛШЕБНЫХ ЗОЛОТЫХ СУНДУКОВ +0.75% шанс появиться";
        newChestsDes6_3_text.text = "Сундуки босса дают 20X опыта. Волшебные золотые сундуки дают 12X опыта. У обоих сундуков немного больше шансов уронить редкие сокровища.";

        newChestsDes1_text.font = russianNono_Medium;
        newChestsDes1_2_text.font = russianNono_Medium;
        newChestsDes1_3_text.font = russianNono_Medium;
        newChestsDes2_text.font = russianNono_Medium;
        newChestsDes2_2_text.font = russianNono_Medium;
        newChestsDes2_3_text.font = russianNono_Medium;
        newChestsDes3_text.font = russianNono_Medium;
        newChestsDes3_2_text.font = russianNono_Medium;
        newChestsDes4_text.font = russianNono_Medium;
        newChestsDes4_2_text.font = russianNono_Medium;
        newChestsDes4_3_text.font = russianNono_Medium;
        newChestsDes5_text.font = russianNono_Medium;
        newChestsDes5_2_text.font = russianNono_Medium;
        newChestsDes5_3_text.font = russianNono_Medium;
        newChestsDes6_text.font = russianNono_Medium;
        newChestsDes6_2_text.font = russianNono_Medium;
        newChestsDes6_3_text.font = russianNono_Medium;

        newChestsDes1_text.fontSize = 12;
        newChestsDes1_2_text.fontSize = 12;
        newChestsDes1_3_text.fontSize = 8f;
        newChestsDes2_text.fontSize = 13;
        newChestsDes2_2_text.fontSize = 11;
        newChestsDes2_3_text.fontSize = 8f;
        newChestsDes3_text.fontSize = 12;
        newChestsDes3_2_text.fontSize = 12;
        newChestsDes4_text.fontSize = 12;
        newChestsDes4_2_text.fontSize = 12;
        newChestsDes4_3_text.fontSize = 12;
        newChestsDes5_text.fontSize = 12;
        newChestsDes5_2_text.fontSize = 12;
        newChestsDes5_3_text.fontSize = 12;
        newChestsDes6_text.fontSize = 12;
        newChestsDes6_2_text.fontSize = 12;
        newChestsDes6_3_text.fontSize = 11;

        #endregion

        #region Other
        maxPurchaseText_text.text = "ПОКУПКА МАКС"; maxPurchaseText_text.font = russianNonoBoldOutLine; maxPurchaseText_text.fontSize = 32;
        youCanAlsoHoldDown_text.text = "Вы также можете удерживать LEFT CONTROL, чтобы купить МАКС"; youCanAlsoHoldDown_text.font = russianNono_Medium; youCanAlsoHoldDown_text.fontSize = 10;

        X1_text1.text = "X1"; X1_text1.font = russianNono_Medium; X1_text1.fontSize = 35;
        X1_text2.text = "X1"; X1_text2.font = russianNono_Medium; X1_text2.fontSize = 32;
        X1_text3.text = "X1"; X1_text3.font = russianNono_Medium; X1_text3.fontSize = 32;
        MAX_text1.text = "МАКС"; MAX_text1.font = russianNono_Medium; MAX_text1.fontSize = 28;
        MAX_text2.text = "МАКС"; MAX_text2.font = russianNono_Medium; MAX_text2.fontSize = 25;
        MAX_text3.text = "МАКС"; MAX_text3.font = russianNono_Medium; MAX_text3.fontSize = 25;

        activeDamageBar_text.text = "АКТИВНЫЙ УРОН"; activeDamageBar_text.font = russianNono_Bold; activeDamageBar_text.fontSize = 36;
        activeDamageACTIVE_text.text = "АКТИВНЫЙ"; activeDamageACTIVE_text.font = russianNono_MediumOutLine; activeDamageACTIVE_text.fontSize = 16;
        activeDamageLEVEL_text.text = "УРОВЕНЬ"; activeDamageLEVEL_text.font = russianNono_Bold; activeDamageLEVEL_text.fontSize = 17;

        passiveDamageBar_text.text = "ПАССИВНЫЙ УРОН"; passiveDamageBar_text.font = russianNono_Bold; passiveDamageBar_text.fontSize = 36;
        passivePASSIVE_Text.text = "ПАССИВНЫЙ"; passivePASSIVE_Text.font = russianNono_MediumOutLine; passivePASSIVE_Text.fontSize = 14;
        passiveLEVEL_text.text = "УРОВЕНЬ"; passiveLEVEL_text.font = russianNono_Bold; passiveLEVEL_text.fontSize = 17;

        welcome.text = "ДОБРО ПОЖАЛОВАТЬ!"; welcome.font = russianNonoBoldOutLine; welcome.fontSize = 21;
        beforeWeCanStartPlaying.text = "Прежде чем мы начнем играть. Сколько добычи вы хотите видеть на экране, прежде чем добыча начнет собираться сама по себе?"; beforeWeCanStartPlaying.font = russianNono_MediumOutLine; beforeWeCanStartPlaying.fontSize = 11f;
        changeAnyTime.text = "ВЫ МОЖЕТЕ ИЗМЕНИТЬ ЭТО В НАСТРОЙКАХ В ЛЮБОЕ ВРЕМЯ"; changeAnyTime.font = russianNono_MediumOutLine; changeAnyTime.fontSize = 10;
        playGame.text = "ИГРАТЬ"; playGame.font = russianNono_MediumOutLine; playGame.fontSize = 65;

        welcomeBack.text = "С ВОЗВРАЩЕНИЕМ!"; welcomeBack.font = russianNonoBoldOutLine; welcomeBack.fontSize = 65;
        if(PlaceMobileButtons.isMobile == true) { welcomeBack.fontSize = 30; }
        thisHappendWhileGone.text = "Вот что произошло, пока вас не было..."; thisHappendWhileGone.font = russianNono_MediumOutLine; thisHappendWhileGone.fontSize = 27;
        cool.text = "Круто!"; cool.font = russianNonoBoldOutLine; cool.fontSize = 42;
        timeGone.text = "Времени прошло:"; timeGone.font = russianNonoBoldOutLine; timeGone.fontSize = 55;
        #endregion

        //Text That Changes
        #region info settings
        enchantedGoldenChestHealth = "-У зачарованных золотых сундуков здоровье в" + UpdateGame.enchantedGoldenChestHealth + "X";
        enchantedGoldenChestTreasureDrops = "-Выпадение" + UpdateGame.enchantedGoldenChestTreasureDrops + " Сокровищ";
        enchantedGoldenChestXPDrop = "-+" + UpdateGame.enchantedGoldenChestXPDrops + "X Выпадение ОП";

        bossChestHealth = "-У сундуков босса здоровье в " + UpdateGame.bossChestHealth + "X";
        bossChestGoldValue = "-Ценность золотой монеты = " + UpdateGame.bossChestGoldValue + "X Золота";
        bossChestGoldCoins = "-Выпадет" + UpdateGame.bossChestGoldCoinsDrops + " золотых монет, все из которых – 10X и 25X золотые монеты";
        bossChestGoldCoins2 = "-Выпадет" + UpdateGame.bossChestGoldCoinsDrops + " золотых монет, все из которых – 25X золотые монеты";
        bossChestXP = "-+" + UpdateGame.bossChestXPDrops + "X Выпадение ОП";

        reinforcedHealth = "-У укреплённых сундуков здоровье в" + UpdateGame.reinforcedChestHealth + "X";
        reinforcedGold = "-Выпавшие золотые монеты дают" + UpdateGame.reinforcedChestGoldIncrease + "X Золота";
        reinforcedXP = "+" + UpdateGame.reinforcedXPIncrease + "X Выпадение ОП";

        reinforcedInfo = "Усиленные сундуки имеют " + UpdateGame.reinforcedChestHealth + "X здоровья, дают " + UpdateGame.reinforcedChestGoldIncrease + "X золота и " + UpdateGame.reinforcedXPIncrease + "X опыта.";

        enchantedChestInfo = (100 - UpdateGame.enchantedGoldenChestChance).ToString("F2") + "% Шанс появления. \nЗачарованные золотые сундуки имеют " + UpdateGame.enchantedGoldenChestHealth + "X здоровья, дают " + UpdateGame.enchantedGoldenChestTreasureDrops + " сокровищ и " + UpdateGame.enchantedGoldenChestXPDrops + "X опыта.\n Использование отмычки или ключа убирает только 33% здоровья сундука.\nУ зачарованных золотых сундуков также немного выше шанс выпадения редкого сокровища.";

        bossChestInfo1 = (UpdateGame.bossChestChance).ToString("F2") + "% SШанс появления.\nСундуки боссов имеют " + UpdateGame.bossChestHealth + "X здоровья. Золотые монеты стоят " + UpdateGame.bossChestGoldValue + "X. Сундук босса даёт " + UpdateGame.bossChestGoldCoinsDrops + " золотых монет, каждая из которых стоит 10X или 25X золотых монет. (Значение золотой монеты из сундука босса = (Текущее значение золотой монеты сундука * 5) * 10 или 25) Также даёт " + UpdateGame.bossChestXPDrops + "X опыта.\nИспользование отмычки или ключа убирает только 25% здоровья сундука.\nУ сундуков боссов также немного выше шанс выпадения редкого сокровища.";

        bossChestInfo2 = (UpdateGame.bossChestChance).ToString("F2") + "% SШанс появления.\nСундуки боссов имеют " + UpdateGame.bossChestHealth + "X здоровья. Золотые монеты стоят " + UpdateGame.bossChestGoldValue + "X. Сундук босса даёт " + UpdateGame.bossChestGoldCoinsDrops + " золотых монет, каждая из которых стоит 25X золотых монет. (Значение золотой монеты из сундука босса = (Текущее значение золотой монеты сундука * 5) * 25) Также даёт " + UpdateGame.bossChestXPDrops + "X опыта.\nИспользование отмычки или ключа убирает только 25% здоровья сундука.\nУ сундуков боссов также немного выше шанс выпадения редкого сокровища.";

        purchaseTheEnchanted = "Приобретите престижное улучшение зачарованного золотого сундука, чтобы просмотреть информацию";
        purchaseTheBossChest = "Приобретите престижное улучшение сундука босса, чтобы просмотреть информацию";



        reinforcedChestsDescription_text2.font = russianNono_Medium; reinforcedChestsDescription_text2.fontSize = 10;

        enchantedGoldenChestsDescription_text.font = russianNono_Medium; enchantedGoldenChestsDescription_text.fontSize = 10;

        bossChestsDescription_text.font = russianNono_Medium; bossChestsDescription_text.fontSize = 9;
        #endregion

        #region stats
        goldCoinsDropped = "Выброшено золотых монет: ";
        totalGoldReceived = "Всего золота получено: ";
        totalBarrelGold = "Золото из бочонков: ";
        treasuresDropped = "Сокровищ выброшено: ";
        commonTreasures = "Обычные сокровища: ";
        uncommonTreasures = "Необычные сокровища: ";
        rareTreasures = "Редкие сокровища: ";
        veryRareTreasures = "Очень редкие сокровища: ";
        extremelyRareTreasures = "Чрезвычайно редкие сокровища: ";
        legendaryTreasures = "Легендарные сокровища: ";
        ultraTreasures = "Ультра сокровища: ";
        mythicTreasures = "Мифические сокровища: ";
        eternalTreasures = "Вечные сокровища: ";
        treasuresDoubled = "Сокровища удвоены: ";
        chestsOpened = "Сундуки открыты: ";
        reinforcedChestsOpened = "Усиленные сундуки открыты: ";
        enchantedGoldenChestsOpened = "Зачарованные золотые сундуки открыты: ";
        bossChestsOpened = "Сундуки боссов открыты: ";
        chestClicks = "Клики по сундукам: ";
        autoClicks = "Автоклики: ";
        criticalHits = "Критические удары: ";
        activeDamage = "Активный урон: ";
        passiveDamage = "Пассивный урон: ";
        critChance = "Шанс крита: ";
        critDamage = "Урон крита: ";
        cursorsLeveledUp = "Уровни курсоров повышены: ";
        coinsSpawnedFromClicks = "Монеты, появившиеся от кликов: ";
        treasuresSpawnedFromClicks = "Сокровища, появившиеся от кликов: ";
        itemsUsed = "Использовано предметов: ";
        itemsDropped = "Выброшено предметов: ";
        itemsPurchased = "Приобретено предметов: ";
        itemsLeveledUp = "Предметы улучшены: ";
        prestigeCount = "Счет престижей: ";
        prestigeUpgradesPurchased = "Приобретено улучшений престиж: ";
        skillPointsReceived = "Получено очков навыков: ";
        goldIncrease = "Увеличение золота: ";
        xpIncrease = "Увеличение опыта: ";
        activeDamageIncrease = "Увеличение активного урона: ";
        passiveDamageIncrease = "Увеличение пассивного урона: ";
        critChanceIncrease = "Увеличение шанса крита: ";
        critDamageIncrease = "Увеличение урона крита: ";
        treasureChanceIncrease = "Увеличение шанса на сокровище: ";
        goldCoins5xDropped = "5X Золотые монеты выброшены: ";
        goldCoins10xDropped = "10X Золотые монеты выброшены: ";
        goldCoins25xDropped = "25X Золотые монеты выброшены: ";
        goldCoins100xDropped = "100X Золотые монеты выброшены: ";


        goldCoinsDropped_text.font = russianNono_MediumOutLine; goldCoinsDropped_text.fontSize = 24;
        totalGoldReceived_text.font = russianNono_MediumOutLine; totalGoldReceived_text.fontSize = 27;
        totalBarrelGold_text.font = russianNono_MediumOutLine; totalBarrelGold_text.fontSize = 27;
        treasuresDropped_text.font = russianNono_MediumOutLine; treasuresDropped_text.fontSize = 27;
        commonTreasures_text.font = russianNono_MediumOutLine; commonTreasures_text.fontSize = 27;
        uncommonTreasures_text.font = russianNono_MediumOutLine; uncommonTreasures_text.fontSize = 27;
        rareTreasures_text.font = russianNono_MediumOutLine; rareTreasures_text.fontSize = 27;
        veryRareTreasures_text.font = russianNono_MediumOutLine; veryRareTreasures_text.fontSize = 27;
        extremelyRareTreasures_text.font = russianNono_MediumOutLine; extremelyRareTreasures_text.fontSize = 23;
        legendaryTreasures_text.font = russianNono_MediumOutLine; legendaryTreasures_text.fontSize = 27;
        ultraTreasures_text.font = russianNono_MediumOutLine; ultraTreasures_text.fontSize = 27;
        mythicTreasures_text.font = russianNono_MediumOutLine; mythicTreasures_text.fontSize = 27;
        eternalTreasures_text.font = russianNono_MediumOutLine; eternalTreasures_text.fontSize = 27;
        treasuresDoubled_text.font = russianNono_MediumOutLine; treasuresDoubled_text.fontSize = 27;
        chestsOpened_text.font = russianNono_MediumOutLine; chestsOpened_text.fontSize = 27;
        reinforcedChestsOpened_text.font = russianNono_MediumOutLine; reinforcedChestsOpened_text.fontSize = 25;
        enchantedGoldenChestsOpened_text.font = russianNono_MediumOutLine; enchantedGoldenChestsOpened_text.fontSize = 27;
        bossChestsOpened_text.font = russianNono_MediumOutLine; bossChestsOpened_text.fontSize = 27;
        chestClicks_text.font = russianNono_MediumOutLine; chestClicks_text.fontSize = 27;
        autoClicks_text.font = russianNono_MediumOutLine; autoClicks_text.fontSize = 27;
        criticalHits_text.font = russianNono_MediumOutLine; criticalHits_text.fontSize = 27;
        activeDamage_text.font = russianNono_MediumOutLine; activeDamage_text.fontSize = 27;
        passiveDamage_text.font = russianNono_MediumOutLine; passiveDamage_text.fontSize = 27;
        critChance_text.font = russianNono_MediumOutLine; critChance_text.fontSize = 27;
        critDamage_text.font = russianNono_MediumOutLine; critDamage_text.fontSize = 27;
        cursorsLeveledUp_text.font = russianNono_MediumOutLine; cursorsLeveledUp_text.fontSize = 27;
        coinsSpawnedFromClicks_text.font = russianNono_MediumOutLine; coinsSpawnedFromClicks_text.fontSize = 23;
        treasuresSpawnedFromClicks_text.font = russianNono_MediumOutLine; treasuresSpawnedFromClicks_text.fontSize = 21;
        itemsUsed_text.font = russianNono_MediumOutLine; itemsUsed_text.fontSize = 27;
        itemsDropped_text.font = russianNono_MediumOutLine; itemsDropped_text.fontSize = 27;
        itemsPurchased_text.font = russianNono_MediumOutLine; itemsPurchased_text.fontSize = 27;
        itemsLeveledUp_text.font = russianNono_MediumOutLine; itemsLeveledUp_text.fontSize = 27;

        prestigeCount_text.font = russianNono_MediumOutLine; prestigeCount_text.fontSize = 27;
        prestigeUpgradesPurchased_text.font = russianNono_MediumOutLine; prestigeUpgradesPurchased_text.fontSize = 23;
        skillPointsReceived_text.font = russianNono_MediumOutLine; skillPointsReceived_text.fontSize = 27;
        goldIncrease_text.font = russianNono_MediumOutLine; goldIncrease_text.fontSize = 27;
        xpIncrease_text.font = russianNono_MediumOutLine; xpIncrease_text.fontSize = 27;
        activeDamageIncrease_text.font = russianNono_MediumOutLine; activeDamageIncrease_text.fontSize = 23;
        passiveDamageIncrease_text.font = russianNono_MediumOutLine; passiveDamageIncrease_text.fontSize = 23;
        critChanceIncrease_text.font = russianNono_MediumOutLine; critChanceIncrease_text.fontSize = 27;
        critDamageIncrease_text.font = russianNono_MediumOutLine; critDamageIncrease_text.fontSize = 27;
        treasureChanceIncrease_text.font = russianNono_MediumOutLine; treasureChanceIncrease_text.fontSize = 22;
        goldCoins5xDropped_text.font = russianNono_MediumOutLine; goldCoins5xDropped_text.fontSize = 22;
        goldCoins10xDropped_text.font = russianNono_MediumOutLine; goldCoins10xDropped_text.fontSize = 22;
        goldCoins25xDropped_text.font = russianNono_MediumOutLine; goldCoins25xDropped_text.fontSize = 22;
        goldCoins100xDropped_text.font = russianNono_MediumOutLine; goldCoins100xDropped_text.fontSize = 22;
        #endregion

        #region cursors
        NOdot = "№.";

        upgrade = "УЛУЧШЕНИЕ";
        upgradeMax = "УЛУЧШЕНИЕ (МАКС)";

        lvl = "УРОВЕНЬ ";
        price = "ЦЕНА: ";
        
        damage = "УРОН: ";
        equipped = "ЭКИПИРОВАН";
        unequpped = "НЕ ЭКИПИРОВАН";

        equippedNONE = "Экипирован =";

        cursor1Equipped = "Экипирован = <color=green>ЛЕГКОЕ КАСАНИЕ";
        cursor2Equipped = "Экипирован = <color=green>СПОКОЙНАЯ ЛАДОНЬ";
        cursor3Equipped = "Экипирован = <color=green>ШТОРМОВАЯ СИЛА";
        cursor4Equipped = "Экипирован = <color=green>СВЕТЛОЕ КАСАНИЕ";
        cursor5Equipped = "Экипирован = <color=green>ПОТОК ЭНЕРГИИ";
        cursor6Equipped = "Экипирован = <color=green>ПРИЗРАЧНАЯ ЛАДОНЬ";
        cursor7Equipped = "Экипирован = <color=green>СТАЛЬНОЙ УДАР";
        cursor8Equipped = "Экипирован = <color=green>СМЕРТЕЛЬНОЕ КАСАНИЕ";
        cursor9Equipped = "Экипирован = <color=green>ТОЧКА ТОЧНОСТИ";
        cursor10Equipped = "Экипирован = <color=green>ВОРТЕКСНЫЙ ТАП";
        cursor11Equipped = "Экипирован = <color=green>ПРОКЛЯТЫЙ КОГОТЬ";
        cursor12Equipped = "Экипирован = <color=green>СНАЙПЕРСКИЙ КЛИК";
        cursor13Equipped = "Экипирован = <color=green>ТЕНЕВОЙ ПОТОК";
        cursor14Equipped = "Экипирован = <color=green>ПАРАЛИЗУЮЩИЙ УДАР";
        cursor15Equipped = "Экипирован = <color=green>БЫСТРЫЙ КЛИК";
        cursor16Equipped = "Экипирован = <color=green>НЕБЕСНОЕ КАСАНИЕ";
        cursor17Equipped = "Экипирован = <color=green>ТАИНСТВЕННЫЙ КЛИК";
        cursor18Equipped = "Экипирован = <color=green>ВЕЧНОЕ КАСАНИЕ";
        cursor19Equipped = "Экипирован = <color=green>КАСАНИЕ РОКА";
        cursor20Equipped = "Экипирован = <color=green>СОЛНЕЧНЫЙ РАЗМЕТ";
        cursor21Equipped = "Экипирован =<color=green>ИНФЕРНАЛЬНЫЙ КУЛАК";

       


        for (int i = 0; i < 21; i++)
        {
            lvlsHover_text[i].font = russian_SemiBold; lvlsHover_text[i].fontSize = 14;

            equippedHover_text[i].font = russian_SemiBold; equippedHover_text[i].fontSize = 23;
            level_text[i].font = russian_SemiBold; level_text[i].fontSize = 30;
        }

        equippedEquals_text.font = russian_SemiBold; equippedEquals_text.fontSize = 14f;
        dpsTopBar_text.font = russian_SemiBold; dpsTopBar_text.fontSize = 25f;
        clickDamageTopBar_text.font = russian_SemiBold; clickDamageTopBar_text.fontSize = 25f;
        critChanceTopBar_text.font = russian_SemiBold; critChanceTopBar_text.fontSize = 25f;
        critDamageTopBar_text.font = russian_SemiBold; critDamageTopBar_text.fontSize = 25f;

        noNotUnlcoked_text.font = russianNono_Bold; noNotUnlcoked_text.fontSize = 70f;

        cursor1ActiveDamage_Text.font = robotoBold; cursor1ActiveDamage_Text.fontSize = 20f;

        cursor2PassiveDamage_Text.font = robotoBold; cursor2PassiveDamage_Text.fontSize = 20f;

        cursor3CritChance_Text.font = robotoBold; cursor3CritChance_Text.fontSize = 20f;
        cursor3CritDamage_Text.font = robotoBold; cursor3CritDamage_Text.fontSize = 20f;

        cursor4ActiveDamage_Text.font = robotoBold; cursor4ActiveDamage_Text.fontSize = 20f;
        cursor4PassiveDamage_Text.font = robotoBold; cursor4PassiveDamage_Text.fontSize = 20f;

        cursor5ActiveDamage_Text.font = robotoBold; cursor5ActiveDamage_Text.fontSize = 20f;
        cursor5CritChance_Text.font = robotoBold; cursor5CritChance_Text.fontSize = 20f;
        cursor5CritDamage_Text.font = robotoBold; cursor5CritDamage_Text.fontSize = 20f;

        cursor6ActiveDamage_Text.font = robotoBold; cursor6ActiveDamage_Text.fontSize = 20f;
        cursor6PassiveDamage_Text.font = robotoBold; cursor6PassiveDamage_Text.fontSize = 20f;
        cursor6CritChance_Text.font = robotoBold; cursor6CritChance_Text.fontSize = 20f;
        cursor6CritDamage_Text.font = robotoBold; cursor6CritDamage_Text.fontSize = 20f;

        cursor7ActiveDamage_Text.font = robotoBold; cursor7ActiveDamage_Text.fontSize = 20f;
        cursor7CritChance_Text.font = robotoBold; cursor7CritChance_Text.fontSize = 20f;
        cursor7CritDamage_Text.font = robotoBold; cursor7CritDamage_Text.fontSize = 20f;

        cursor8ActiveDamage_Text.font = robotoBold; cursor8ActiveDamage_Text.fontSize = 20f;
        cursor8PassiveDamage_Text.font = robotoBold; cursor8PassiveDamage_Text.fontSize = 20f;
        cursor8CritChance_Text.font = robotoBold; cursor8CritChance_Text.fontSize = 20f;
        cursor8CritDamage_Text.font = robotoBold; cursor8CritDamage_Text.fontSize = 20f;

        cursor9ActiveDamage_Text.font = robotoBold; cursor9ActiveDamage_Text.fontSize = 20f;
        cursor9PassiveDamage_Text.font = robotoBold; cursor9PassiveDamage_Text.fontSize = 20f;

        cursor10PassiveDamage_Text.font = robotoBold; cursor10PassiveDamage_Text.fontSize = 20f;

        cursor11ActiveDamage_Text.font = robotoBold; cursor11ActiveDamage_Text.fontSize = 20f;
        cursor11CritChance_Text.font = robotoBold; cursor11CritChance_Text.fontSize = 20f;
        cursor11CritDamage_Text.font = robotoBold; cursor11CritDamage_Text.fontSize = 20f;

        cursor12ActiveDamage_Text.font = robotoBold; cursor12ActiveDamage_Text.fontSize = 20f;
        cursor12PassiveDamage_Text.font = robotoBold; cursor12PassiveDamage_Text.fontSize = 20f;
        cursor12CritChance_Text.font = robotoBold; cursor12CritChance_Text.fontSize = 20f;
        cursor12CritDamage_Text.font = robotoBold; cursor12CritDamage_Text.fontSize = 20f;

        cursor13ActiveDamage_Text.font = robotoBold; cursor13ActiveDamage_Text.fontSize = 20f;
        cursor13PassiveDamage_Text.font = robotoBold; cursor13PassiveDamage_Text.fontSize = 20f;
        cursor13CritChance_Text.font = robotoBold; cursor13CritChance_Text.fontSize = 20f;
        cursor13CritDamage_Text.font = robotoBold; cursor13CritDamage_Text.fontSize = 20f;

        cursor14ActiveDamage_Text.font = robotoBold; cursor14ActiveDamage_Text.fontSize = 20f;
        cursor14PassiveDamage_Text.font = robotoBold; cursor14PassiveDamage_Text.fontSize = 20f;
        cursor14CritChance_Text.font = robotoBold; cursor14CritChance_Text.fontSize = 20f;
        cursor14CritDamage_Text.font = robotoBold; cursor14CritDamage_Text.fontSize = 20f;

        cursor15ActiveDamage_Text.font = robotoBold; cursor15ActiveDamage_Text.fontSize = 20f;
        cursor15PassiveDamage_Text.font = robotoBold; cursor15PassiveDamage_Text.fontSize = 20f;
        cursor15CritChance_Text.font = robotoBold; cursor15CritChance_Text.fontSize = 20f;
        cursor15CritDamage_Text.font = robotoBold; cursor15CritDamage_Text.fontSize = 20f;

        cursor16ActiveDamage_Text.font = robotoBold; cursor16ActiveDamage_Text.fontSize = 20f;
        cursor16PassiveDamage_Text.font = robotoBold; cursor16PassiveDamage_Text.fontSize = 20f;
        cursor16CritChance_Text.font = robotoBold; cursor16CritChance_Text.fontSize = 20f;
        cursor16CritDamage_Text.font = robotoBold; cursor16CritDamage_Text.fontSize = 20f;

        cursor17ActiveDamage_Text.font = robotoBold; cursor17ActiveDamage_Text.fontSize = 20f;
        cursor17PassiveDamage_Text.font = robotoBold; cursor17PassiveDamage_Text.fontSize = 20f;
        cursor17CritChance_Text.font = robotoBold; cursor17CritChance_Text.fontSize = 20f;
        cursor17CritDamage_Text.font = robotoBold; cursor17CritDamage_Text.fontSize = 20f;

        cursor18ActiveDamage_Text.font = robotoBold; cursor18ActiveDamage_Text.fontSize = 20f;
        cursor18PassiveDamage_Text.font = robotoBold; cursor18PassiveDamage_Text.fontSize = 20f;
        cursor18CritChance_Text.font = robotoBold; cursor18CritChance_Text.fontSize = 20f;
        cursor18CritDamage_Text.font = robotoBold; cursor18CritDamage_Text.fontSize = 20f;

        cursor19ActiveDamage_Text.font = robotoBold; cursor19ActiveDamage_Text.fontSize = 20f;
        cursor19PassiveDamage_Text.font = robotoBold; cursor19PassiveDamage_Text.fontSize = 20f;
        cursor19CritChance_Text.font = robotoBold; cursor19CritChance_Text.fontSize = 20f;
        cursor19CritDamage_Text.font = robotoBold; cursor19CritDamage_Text.fontSize = 20f;

        cursor20ActiveDamage_Text.font = robotoBold; cursor20ActiveDamage_Text.fontSize = 20f;
        cursor20PassiveDamage_Text.font = robotoBold; cursor20PassiveDamage_Text.fontSize = 20f;
        cursor20CritChance_Text.font = robotoBold; cursor20CritChance_Text.fontSize = 20f;
        cursor20CritDamage_Text.font = robotoBold; cursor20CritDamage_Text.fontSize = 20f;

        cursor21ActiveDamage_Text.font = robotoBold; cursor21ActiveDamage_Text.fontSize = 20f;
        cursor21PassiveDamage_Text.font = robotoBold; cursor21PassiveDamage_Text.fontSize = 20f;
        cursor21CritChance_Text.font = robotoBold; cursor21CritChance_Text.fontSize = 20f;
        cursor21CritDamage_Text.font = robotoBold; cursor21CritDamage_Text.fontSize = 20f;
        #endregion

        #region items and shop

        MAX = "МАКС";
        owned = "В наличии: ";
        treasuresExplinationMark = "СОКРОВИЩА!";
        skillPointsExplinatinMark = " ОЧКА НАВЫКОВ!";

        stack = "СТОПКА X";

         forTheNext = "В ТЕЧЕНИЕ СЛЕДУЮЩИХ ";
        seconds = " СЕКУНД";

        for (int i = 0; i < 17; i++)
        {
            itemsPrice_text[i].font = russian_SemiBold; itemsPrice_text[i].fontSize = 19;
            itemsLvlHover_text[i].font = russian_SemiBold; itemsLvlHover_text[i].fontSize = 15;
            itemsPriceHover_text[i].font = robotoBold; itemsPriceHover_text[i].fontSize = 16;
        }

        itemsPriceHover_text[8].fontSize = 14;

        for (int i = 0; i < 14; i++)
        {
            owned_text[i].font = russian_SemiBold; owned_text[i].fontSize = 22;
        }

        stack_text1.font = russianNono_MediumOutLine; stack_text1.fontSize = 23f;
        stack_text2.font = russianNono_MediumOutLine; stack_text2.fontSize = 23f;
        stack_text3.font = russianNono_MediumOutLine; stack_text3.fontSize = 23f;
        stack_text4.font = russianNono_MediumOutLine; stack_text4.fontSize = 23f;
        stack_text5.font = russianNono_MediumOutLine; stack_text5.fontSize = 23f;
        stack_text6.font = russianNono_MediumOutLine; stack_text6.fontSize = 23f;
        stack_text7.font = russianNono_MediumOutLine; stack_text7.fontSize = 23f;
        stack_text8.font = russianNono_MediumOutLine; stack_text8.fontSize = 23f;

        lockPickDropChance_text.font = russianNono_SemiSkinny; lockPickDropChance_text.fontSize = 17f;
        lockPickInfo.font = robotoBold; lockPickInfo.fontSize = 23f;
        hammerInfo_text.font = robotoBold; hammerInfo_text.fontSize = 19f;
        hammerDropChance_text.font = russianNono_SemiSkinny; hammerDropChance_text.fontSize = 17f;
        lootPotionInfo_text.font = robotoBold; lootPotionInfo_text.fontSize = 20f;
        lootPotionDropChance_text.font = russianNono_SemiSkinny; lootPotionDropChance_text.fontSize = 17f;
        damagePotionInfo_text.font = robotoBold; damagePotionInfo_text.fontSize = 17f;
        damagePotionDropChance_text.font = russianNono_SemiSkinny; damagePotionDropChance_text.fontSize = 17f;
        xpPotionInfo_text.font = robotoBold; xpPotionInfo_text.fontSize = 18f;
        xpPotionDropChance_text.font = russianNono_SemiSkinny; xpPotionDropChance_text.fontSize = 17f;
        goldenTouchInfo_text.font = robotoBold; goldenTouchInfo_text.fontSize = 16f;
        goldenTouchDropChance_text.font = russianNono_SemiSkinny; goldenTouchDropChance_text.fontSize = 17f;
        miniChestInfo_text.font = robotoBold; miniChestInfo_text.fontSize = 21f;
        keyInfo_text.font = robotoBold; keyInfo_text.fontSize = 17f;
        keyDropChance_text.font = russianNono_SemiSkinny; keyDropChance_text.fontSize = 17f;
        treasureBagInfo_text.font = robotoBold; treasureBagInfo_text.fontSize = 19f;
        serendipityScrollInfo_text.font = robotoBold; serendipityScrollInfo_text.fontSize = 16f;
        serendipityScollDropChance_text.font = russianNono_SemiSkinny; serendipityScollDropChance_text.fontSize = 17f;
        gauntletOfGreenInfo_text.font = robotoBold; gauntletOfGreenInfo_text.fontSize = 18f;
        gauntletOfGreenDropChance_text.font = russianNono_SemiSkinny; gauntletOfGreenDropChance_text.fontSize = 17f;
        magicalElixirInfo.font = robotoBold; magicalElixirInfo.fontSize = 18f;
        magicalElixirDropChance_text.font = russianNono_SemiSkinny; magicalElixirDropChance_text.fontSize = 17f;
        ancientRelicDropChance_text.font = russianNono_SemiSkinny; ancientRelicDropChance_text.fontSize = 17f;
        enchantedHammerInfo_text.font = robotoBold; enchantedHammerInfo_text.fontSize = 15f;
        enchantedHammerDropChance_text.font = russianNono_SemiSkinny; enchantedHammerDropChance_text.fontSize = 17f;
        treasurePotionInfo_text.font = robotoBold; treasurePotionInfo_text.fontSize = 17f;
        treasurePotionDropChance_text.font = russianNono_SemiSkinny; treasurePotionDropChance_text.fontSize = 17f;
        barrelOfGoldTotalGold_text.font = russianNonoBoldOutLine; barrelOfGoldTotalGold_text.fontSize = 13f;
        mimicChestSpawns_text.font = robotoBold; mimicChestSpawns_text.fontSize = 16f;
        mimicChestChanceForBuff_text.font = robotoBold; mimicChestChanceForBuff_text.fontSize = 14f;
        barrelOfGoldInfo_text.font = robotoBold; barrelOfGoldInfo_text.fontSize = 15f;
        
        //Minus treasure drop chance

        //Item and mimic chest buffs
        goldBuffText_text.font = russianNonoBoldOutLine; goldBuffText_text.fontSize = 10;
        lootPotionBuff_text.font = russianNonoBoldOutLine; lootPotionBuff_text.fontSize = 10;
        damagePotionBuff_text.font = russianNonoBoldOutLine; damagePotionBuff_text.fontSize = 10;
        damageBuff_text.font = russianNonoBoldOutLine; damageBuff_text.fontSize = 10;
        treasureBuff_text.font = russianNonoBoldOutLine; treasureBuff_text.fontSize = 10; treasureBuff_text.lineSpacing = -40;
        xpBuff_text.font = russianNonoBoldOutLine; xpBuff_text.fontSize = 10;
        xpPotionBuff.font = russianNonoBoldOutLine; xpPotionBuff.fontSize = 10;
        elixirGoldBuff_text.font = russianNonoBoldOutLine; elixirGoldBuff_text.fontSize = 10;
        elixirXPBuff_text.font = russianNonoBoldOutLine; elixirXPBuff_text.fontSize = 10;
        elixirDamageBuff_text.font = russianNonoBoldOutLine; elixirDamageBuff_text.fontSize = 10;
        goldCoinsDropBuff_text.font = russianNonoBoldOutLine; goldCoinsDropBuff_text.fontSize = 10;
        treasurePotionBuff_text.font = russianNonoBoldOutLine; treasurePotionBuff_text.fontSize = 10;
        goldenTouchBuff.font = russianNonoBoldOutLine; goldenTouchBuff.fontSize = 10;

        negativeGold_text.font = russianNonoBoldOutLine; negativeGold_text.fontSize = 10;
        negativeDamage_text.font = russianNonoBoldOutLine; negativeDamage_text.fontSize = 10;
        negativeTreasure_text.font = russianNonoBoldOutLine; negativeTreasure_text.fontSize = 10;
        negativeXP_text.font = russianNonoBoldOutLine; negativeXP_text.fontSize = 10;
        negativeGoldCoinsDrop_text.font = russianNonoBoldOutLine; negativeGoldCoinsDrop_text.fontSize = 10f;

        goldBuffTimer_text.font = russianNonoBoldOutLine; goldBuffTimer_text.fontSize = 8;
        lootPotionBuffTimer_text.font = russianNonoBoldOutLine; lootPotionBuffTimer_text.fontSize = 8;
        damageBuffTimer_text.font = russianNonoBoldOutLine; damageBuffTimer_text.fontSize = 8;
        damagePotionTimer_text.font = russianNonoBoldOutLine; damagePotionTimer_text.fontSize = 8;
        treasureBuffTimer_text.font = russianNonoBoldOutLine; treasureBuffTimer_text.fontSize = 8;
        xpBuffTimer_text.font = russianNonoBoldOutLine; xpBuffTimer_text.fontSize = 8;
        XpPotionTimer_text.font = russianNonoBoldOutLine; XpPotionTimer_text.fontSize = 8;
        elixirTimer_text.font = russianNonoBoldOutLine; elixirTimer_text.fontSize = 8;
        goldCoinsDropsTimer_text.font = russianNonoBoldOutLine; goldCoinsDropsTimer_text.fontSize = 8;
        treasurePotionTimer_Text.font = russianNonoBoldOutLine; treasurePotionTimer_Text.fontSize = 8;
        goldenTouchTimer_text.font = russianNonoBoldOutLine; goldenTouchTimer_text.fontSize = 8;
        rareTreasuresTimer_text.font = russianNonoBoldOutLine; rareTreasuresTimer_text.fontSize = 8;
        negativeGoldtimer_Text.font = russianNonoBoldOutLine; negativeGoldtimer_Text.fontSize = 8;
        negativeDamageTimer_text.font = russianNonoBoldOutLine; negativeDamageTimer_text.fontSize = 8;
        negativeTreasureTimer_text.font = russianNonoBoldOutLine; negativeTreasureTimer_text.fontSize = 8;
        negativeXPTimer_text.font = russianNonoBoldOutLine; negativeXPTimer_text.fontSize = 8;
        negativeGoldCoinsDropTimer_text.font = russianNonoBoldOutLine; negativeGoldCoinsDropTimer_text.fontSize = 8;
        #endregion

        #region Treasures

        tDropChanceRussAndEng = "% Шанс выпасть из сундука";
        youFoundThePrestigeKetAndChest = "";

        doubleInValue = " шанс удвоить свою стоимость";

        quartsGained = "Полученный Кварц имеет ";
        amethystGained = "Полученный аметист имеет ";
        yellowTopazGained = "Полученный Жёлтый Топаз имеет ";
        albiteGained = "Полученный Альбит имеет ";
        redGarnetGained = "Полученный Красный Гранат имеет ";
        aquamarineGained = "Полученный Аквамарин имеет ";
        yellowShapphireGained = "Полученный Жёлтый Сапфир имеет ";
        pinkTourmalineGained = "Полученный Розовый Турмалин имеет ";
        adventurineGained = "Полученный Авантюрин имеет ";
        redRubyGained = "Полученный Красный Рубин имеет ";
        diamondGained = "Полученный Алмаз имеет ";
        grandidieriteGained = "Полученный Грандидиерит имеет ";
        violetCrystalGained = "Полученный Фиолетовый Кристалл имеет ";
        akoyaPearlGained = "Полученный Жемчуг Акоя имеет ";
        purpleRupeeGained = "Полученный Фиолетовый Рупий имеет ";
        emeraldGained = "Полученный Изумруд имеет ";
        greenDiamondGained = "Полученный Зелёный Алмаз имеет ";
        fireOpalGained = "Полученный Огненный Опал имеет ";
        gemSilicaGained = "Полученный Каменный Хризоколл имеет ";
        pinkPlortGained = "Полученный Розовый Плорт имеет ";
        goldenSeaPearlGained = "Полученный Золотой Морской Жемчуг имеет ";
        kyaniteGained = "Полученный Кианит имеет ";
        blackOpalGained = "Полученный Чёрный Опал имеет ";
        painiteGained = "Полученный Пайнит имеет ";
        tanzaniteGained = "Полученный Танзанит имеет ";
        astraliumGained = "Полученный Астралит имеет ";
        elysiumPrismGained = "Полученный Призма Элизиума имеет ";
        aerthfireOpalGained = "Полученный Опал Аэртфаер имеет ";
        eldrichStarStoneGained = "Полученный Звездный Камень Элдрич имеет ";
        chronolithChardGained = "Полученный Осколок Хронолита имеет ";
        sideriumEssenceGained = "Полученный Сущность Сидерия имеет ";
        quasariteGained = "Полученный Квадарит имеет ";
        radiantNovaGained = "Полученный Сияющий Камень Нова имеет ";
        soluniumShardGained = "Полученный Осколок Солуниума имеет ";

        for (int i = 0; i < 34; i++)
        {
            treasureDropChanceText_text[i].font = russianNono_Bold; treasureDropChanceText_text[i].fontSize = 23;
            treasreDoubleText_text[i].font = russianNono_Bold; treasreDoubleText_text[i].fontSize = 18;
        }
        sellTreasureFor_text.font = russianNono_Bold; sellTreasureFor_text.fontSize = 22; sellTreasureFor_text.lineSpacing = -35;
        sellTreasureFor = "Продать за "; sellGold = " Золота";


        #endregion

        #region Rare Treasures

        chooseChickenBuff = "<color=green>КЛИКНИТЕ ПО КУРИЦЕ, ЧТОБЫ ВЫБРАТЬ БАФФ";
        foundRubberChickenRewards2_text.font = russianNono_MediumOutLine; foundRubberChickenRewards2_text.fontSize = 7f;

        YOU_FOUND_A_SKULL = "ВЫ НАШЛИ ЧЕРЕП!";
        YOU_FOUND_A_TROPHY = "ВЫ НАШЛИ ТРОФЕЙ!";
        YOU_FOUND_A_DEMONIC_SWORD = "ВЫ НАШЛИ ДЕМОНИЧЕСКИЙ МЕЧ!";
        YOU_FOUND_A_RING = "ВЫ НАШЛИ КОЛЬЦО!";
        YOU_FOUND_A_STAR = "ВЫ НАШЛИ ЗВЕЗДУ!";
        YOU_FOUND_A_CLOVER = "ВЫ НАШЛИ КЛЕВЕР!";
        YOU_FOUND_A_KINGS_CROWN = "ВЫ НАШЛИ КОРОЛЕВСКУЮ КОРОНУ!";
        YOU_FOUND_A_BOOK = "ВЫ НАШЛИ КНИГУ!";
        YOU_FOUND_A_GUITAR = "ВЫ НАШЛИ ГИТАРУ!";
        YOU_FOUND_A_TALARIAN = "ВЫ НАШЛИ ТАЛАРИА!";
        YOU_FOUND_A_STRANGE_RUNE = "ВЫ НАШЛИ СТРАННУЮ РУНУ!";
        YOU_FOUND_A_BACKPACK = "ВЫ НАШЛИ РЮКЗАК!";
        YOU_FOUND_A_SHIELD = "ВЫ НАШЛИ ЩИТ!";
        YOU_FOUND_A_PILL_BOTTLE = "ВЫ НАШЛИ БАНКУ С ТАБЛЕТКАМИ!";
        YOU_FOUND_A_MEDAL = "ВЫ НАШЛИ МЕДАЛЬ!";
        YOU_FOUND_A_COOKIE = "ВЫ НАШЛИ ПЕЧЕНЬЕ!";
        YOU_FOUND_A_CHRISTMAS_PRESENT = "ВЫ НАШЛИ РОЖДЕСТВЕНСКИЙ ПОДАРОК!";
        YOU_FOUND_A_BATTLE_AXE = "ВЫ НАШЛИ БОЕВОЙ ТОПОР!";
        YOU_FOUND_A_100X_GOLD_COIN = "ВЫ НАШЛИ 100X ЗОЛОТУЮ МОНЕТУ!";
        YOU_FOUND_A_SEALED_ENVELOPE = "ВЫ НАШЛИ ЗАПЕЧАТАННЫЙ КОНВЕРТ!";
        YOU_FOUND_A_STRANGE_POTION = "ВЫ НАШЛИ СТРАННОЕ ЗЕЛЬЕ!";
        YOU_FOUND_A_SOUL_GEM = "ВЫ НАШЛИ ДРАГОЦЕННЫЙ КАМЕНЬ ДУШИ!";
        YOU_FOUND_AN_ANCIENT_SCROLL = "ВЫ НАШЛИ ДРЕВНИЙ СВИТОК!";
        YOU_FOUND_A_BRICK = "ВЫ НАШЛИ КИРПИЧ!";
        YOU_FOUND_A_RUBBER_CHICKEN = "ВЫ НАШЛИ РЕЗИНОВУЮ КУРИЦУ!";


        PIRATE_SKULL = "ПИРАТСКИЙ ЧЕРЕП";
        DEMONIC_SWORD = "ДЕМОНИЧЕСКИЙ МЕЧ";
        MYSTIC_RING = "МИСТИЧЕСКОЕ КОЛЬЦО";
        TROPHY = "ТРОФЕЙ";
        FALLEN_STAR = "ПАДШАЯ ЗВЕЗДА";
        CLOVER = "КЛЕВЕР";
        KINGS_CROWN = "КОРОЛЕВСКАЯ КОРОНА";
        SPELL_BOOK = "КНИГА ЗАКЛИНАНИЙ";
        GUITAR = "ГИТАРА";
        TALARIAN = "ТАЛАРИА";
        MYTHRUNE = "МИФРУНА";
        EXPLORER_BACKPACK = "РЮКЗАК ИССЛЕДОВАТЕЛЯ";
        VIKING_SHIELD = "ЩИТ ВИКИНГА";
        PILL_BOTTLE = "БАНКА С ТАБЛЕТКАМИ";
        VICTORY_MEDAL = "МЕДАЛЬ ПОБЕДЫ";
        COOKIE = "ПЕЧЕНЬЕ";
        CHRISTMAS_PRESENT = "РОЖДЕСТВЕНСКИЙ ПОДАРОК";
        BATTLE_AXE = "БОЕВОЙ ТОПОР";
        GOLD_COIN_100X = "100X ЗОЛОТАЯ МОНЕТА";
        SEALED_ENVELOPE = "ЗАПЕЧАТАННЫЙ КОНВЕРТ";
        STRANGE_POTION = "СТРАННОЕ ЗЕЛЬЕ";
        SOUL_GEM = "ДРАГОЦЕННЫЙ КАМЕНЬ ДУШИ";
        ANCIENT_SCROLL = "ДРЕВНИЙ СВИТОК";
        BRICK = "кирпич";
        RUBBER_CHICKEN = "РЕЗИНОВАЯ КУРИЦА";

        
         skullSize = 14.5f;
        demonicSwordSize = 15;
        mysticRingSize = 16;
        trophySize = 25;
        fallenStarSize = 14;
        cloverSize = 30;
        kingsCrownSize = 16;
        spellBookSize = 12;
        guitarSize = 29;
        talarianSize = 25;
        mythruneSize = 20;
        explorerBackpackSize = 15;
        vikingShieldSize = 18;
        pillBottleSize = 13.5f;
        victoryMedalSize = 19;
        cookieSize = 26;
        rubberChickenSize = 14.7f;
        brickSize = 22.8f;
        ancientScrollSize = 17;
        soulGemSize = 14.3f;
        strangePotionSize = 17;
        christmasPresentSize = 17;
        battleAxeSize = 19;
        goldCoin100XSize = 16;
        sealedEnvelopeSize = 15;

        pirateSkull_text.font = russianNono_Bold; pirateSkull_text.fontSize = 14.5f;
        demonicSword_text.font = russianNono_Bold; demonicSword_text.fontSize = 15;
        mysticRing_text.font = russianNono_Bold; mysticRing_text.fontSize = 16;
        trophy_text.font = russianNono_Bold; trophy_text.fontSize = 25;
        fallenStar_text.font = russianNono_Bold; fallenStar_text.fontSize = 14;
        clover_text.font = russianNono_Bold; clover_text.fontSize = 30;
        kingsCrown_text.font = russianNono_Bold; kingsCrown_text.fontSize = 16;
        spellBook_text.font = russianNono_Bold; spellBook_text.fontSize = 12;
        guitar_text.font = russianNono_Bold; guitar_text.fontSize = 29;
        talarian_text.font = russianNono_Bold; talarian_text.fontSize = 25;
        mythrune_text.font = russianNono_Bold; mythrune_text.fontSize = 20;
        explorerBackpack_text.font = russianNono_Bold; explorerBackpack_text.fontSize = 15;
        vikingShield_text.font = russianNono_Bold; vikingShield_text.fontSize = 18;
        pillBottle_text.font = russianNono_Bold; pillBottle_text.fontSize = 13.5f;
        victoryMedal_text.font = russianNono_Bold; victoryMedal_text.fontSize = 19;
        cookie_text.font = russianNono_Bold; cookie_text.fontSize = 26;
        christmasPresent_text.font = russianNono_Bold; christmasPresent_text.fontSize = 17;
        battleAxe_text.font = russianNono_Bold; battleAxe_text.fontSize = 19;
        goldCoin100X_text.font = russianNono_Bold; goldCoin100X_text.fontSize = 16;
        sealedEnvelope_text.font = russianNono_Bold; sealedEnvelope_text.fontSize = 15;
        strangePotion_text.font = russianNono_Bold; strangePotion_text.fontSize = 17;
        soulGem_text.font = russianNono_Bold; soulGem_text.fontSize = 14.3f;
        ancientScroll_text.font = russianNono_Bold; ancientScroll_text.fontSize = 17;
        brick_text.font = russianNono_Bold; brick_text.fontSize = 22.8f;
        rubberChicken_text.font = russianNono_Bold; rubberChicken_text.fontSize = 14.7f;


        if (RareTreasures.skullFound == 1)
        {
            pirateSkull_text.text = "ПИРАТСКИЙ ЧЕРЕП"; 
        }
        if (RareTreasures.swordFound == 1)
        {
            demonicSword_text.text = "ДЕМОНИЧЕСКИЙ МЕЧ"; 
        }
        if (RareTreasures.ringFound == 1)
        {
            mysticRing_text.text = "МИСТИЧЕСКОЕ КОЛЬЦО"; 
        }
        if (RareTreasures.trophyFound == 1)
        {
            trophy_text.text = "ТРОФЕЙ"; 
        }
        if (RareTreasures.starFound == 1)
        {
            fallenStar_text.text = "ПАДШАЯ ЗВЕЗДА"; 
        }
        if (RareTreasures.cloverFound == 1)
        {
            clover_text.text = "КЛЕВЕР"; 
        }
        if (RareTreasures.crownFound == 1)
        {
            kingsCrown_text.text = "КОРОЛЕВСКАЯ КОРОНА"; 
        }
        if (RareTreasures.bookFound == 1)
        {
            spellBook_text.text = "КНИГА ЗАКЛИНАНИЙ";
        }
        if (RareTreasures.guitarFOund == 1)
        {
            guitar_text.text = "ГИТАРА";
        }
        if (RareTreasures.talarianFound == 1)
        {
            talarian_text.text = "ТАЛАРИА"; 
        }
        if (RareTreasures.runeFound == 1)
        {
            mythrune_text.text = "МИФРУНА"; 
        }
        if (RareTreasures.backPackFound == 1)
        {
            explorerBackpack_text.text = "РЮКЗАК ИССЛЕДОВАТЕЛЯ"; 
        }
        if (RareTreasures.shieldFound == 1)
        {
            vikingShield_text.text = "ЩИТ ВИКИНГА"; 
        }
        if (RareTreasures.pillBottleFound == 1)
        {
            pillBottle_text.text = "БАНКА С ТАБЛЕТКАМИ"; 
        }
        if (RareTreasures.medalFound == 1)
        {
            victoryMedal_text.text = "МЕДАЛЬ ПОБЕДЫ";
        }
        if (RareTreasures.cookieFound == 1)
        {
            cookie_text.text = "ПЕЧЕНЬЕ"; 
        }
        if (RareTreasures.presentFound == 1)
        {
            christmasPresent_text.text = "РОЖДЕСТВЕНСКИЙ ПОДАРОК";
        }
        if (RareTreasures.axeFound == 1)
        {
            battleAxe_text.text = "БОЕВОЙ ТОПОР"; 
        }
        if (RareTreasures.coin100XFound == 1)
        {
            goldCoin100X_text.text = "100X ЗОЛОТАЯ МОНЕТА"; 
        }
        if (RareTreasures.envelopeFound == 1)
        {
            sealedEnvelope_text.text = "ЗАПЕЧАТАННЫЙ КОНВЕРТ"; 
        }
        if (RareTreasures.potionFound == 1)
        {
            strangePotion_text.text = "СТРАННОЕ ЗЕЛЬЕ";
        }
        if (RareTreasures.soulGemFound == 1)
        {
            soulGem_text.text = "ДРАГОЦЕННЫЙ КАМЕНЬ ДУШИ"; 
        }
        if (RareTreasures.scrollFound == 1)
        {
            ancientScroll_text.text = "ДРЕВНИЙ СВИТОК";
        }
        if (RareTreasures.brickFound == 1)
        {
            brick_text.text = "кирпич"; 
        }
        if (RareTreasures.chickenFound == 1)
        {
            rubberChicken_text.text = "РЕЗИНОВАЯ КУРИЦА"; rubberChicken_text.font = russianNono_Bold; rubberChicken_text.fontSize = 14.7f;
        }




        foundRareTreasurePopUp_text.lineSpacing = -50;
        foundRareTreasurePopUp_text.text = ""; foundRareTreasurePopUp_text.font = russianNono_Bold; foundRareTreasurePopUp_text.fontSize = 32;

        pirateSkull_text.lineSpacing = -50;
        demonicSword_text.lineSpacing = -50;
        mysticRing_text.lineSpacing = -50;
        trophy_text.lineSpacing = -50;
        fallenStar_text.lineSpacing = -50;
        clover_text.lineSpacing = -50;
        kingsCrown_text.lineSpacing = -50;
        spellBook_text.lineSpacing = -50;
        guitar_text.lineSpacing = -50;
        talarian_text.lineSpacing = -50;
        mythrune_text.lineSpacing = -50;
        explorerBackpack_text.lineSpacing = -50;
        vikingShield_text.lineSpacing = -50;
        pillBottle_text.lineSpacing = -50;
        victoryMedal_text.lineSpacing = -50;
        cookie_text.lineSpacing = -50;
        christmasPresent_text.lineSpacing = -50;
        battleAxe_text.lineSpacing = -50;
        goldCoin100X_text.lineSpacing = -50;
        sealedEnvelope_text.lineSpacing = -50;
        strangePotion_text.lineSpacing = -50;
        soulGem_text.lineSpacing = -50;
        ancientScroll_text.lineSpacing = -50;
        brick_text.lineSpacing = -50;
        rubberChicken_text.lineSpacing = -50;

        chooseText1_text.font = russianNonoBoldOutLine; chooseText1_text.fontSize = 15f;
        chooseText2_text.font = russianNonoBoldOutLine; chooseText2_text.fontSize = 15f;
        chooseText3_text.font = russianNonoBoldOutLine; chooseText3_text.fontSize = 15f;
        chooseText4_text.font = russianNonoBoldOutLine; chooseText4_text.fontSize = 15f;
        chooseText5_text.font = russianNonoBoldOutLine; chooseText5_text.fontSize = 15f;
        chooseText6_text.font = russianNonoBoldOutLine; chooseText6_text.fontSize = 15f;
        chooseText7_text.font = russianNonoBoldOutLine; chooseText7_text.fontSize = 15f;
        price200SkillPoints_text.font = russian_SemiBold; price200SkillPoints_text.fontSize = 12.6f;

        priceEqual = "ЦЕНА =";
        skillPoints200 = "200 ОЧКОВ НАВЫКА";
        if (PlayerLevel.skillPoints >= 200)
        {
            price200SkillPoints_text.text = Localization.priceEqual + " <color=green>" + Localization.skillPoints200;
        }
        if (PlayerLevel.skillPoints < 200)
        {
            price200SkillPoints_text.text = Localization.priceEqual + " <color=red>" + Localization.skillPoints200;
        }
        #endregion

        #region Treasure Chests
        ON = "ВКЛ"; OFF = "ВЫКЛ";

        GoldCoinsDrop = "Выпадение золотых монет: ";
        goldCoinValue = "Ценность золотой монеты: ";
        XPDrop = "Выпадение ОП: ";

        chestNumber = "Сундук № "; chestNO = "";

        reinforcedChestChance1 = ""; reinforcedChestChance2 = " Шанс Укреплённого Сундука";

        WoodenChest = "Деревянный Сундук";
        TimberwoodChest = "Тимбервудский Сундук";
        RockboundChest = "Скалистый Сундук";
        BronzeChest = "Бронзовый Сундук";
        SequoiaChest = "Секвойевый Сундук";
        IronboundChest = "Железный Сундук";
        StoneshieldChest = "Каменный Щитовый Сундук";
        OceanChest = "Океанский Сундук";
        PoisonousChest = "Ядовитый Сундук";
        GoldenChest = "Золотой Сундук";
        DesertChest = "Пустынный Сундук";
        PirateChest = "Пиратский Сундук";
        CrystalChest = "Хрустальный Сундук";
        CelestialChest = "Небесный Сундук";
        PhantomChest = "Призрачный Сундук";
        PrismaticChest = "Призматический Сундук";
        AquaticChest = "Водный Сундук";
        WindwalkersChest = "Сундук Ходока Ветра";
        EnchantedChest = "Зачарованный Сундук";
        RoyalChest = "Королевский Сундук";
        ArcaneChest = "Магический Сундук";
        GrandioseChest = "Великолепный Сундук";
        LuxuriousGoldenChest = "Роскошный Золотой Сундук";
        SacredChest = "Священный Сундук";
        EternitysEmbraceChest = "Сундук Объятий Вечности";
        ForgottenChest = "Забытый Сундук";
        LivingLuminousChest = "Живой Светящийся Сундук";
        FortressOfWealth = "Крепость Богатства";
        FortifiedTimberChest = "Укреплённый Тимбервудский Сундук";
        RadiantFrostlock = "Сияющий Замок Мороза";
        InfernoEmbracedChest = "Охваченный Инферно Сундук";
        DeathChest = "Сундук Смерти";
        AlienChest = "Чужеродный Сундук";
        CraftsmansReliquary = "Реликвия Ремесленника";
        HellfireGuardianChest = "Страж Адского Огня Сундук";
        GhastlySoulHoardChest = "Сундук Призрачного Собирателя Душ";
        HighTechCache = "Высокотехнологичный Кэш";
        EliteHackersStrongbox = "Сильнейший Хакерский Сейф";
        CollectorsVault = "Свод Собирателя";
        ExquisiteAzureRadianceChest = "Изысканный Сундук Лазурного Сияния";

        TimberwoodChestUnlocked = "Тимбервудский Сундук Открыт";
        RockboundChestUnlocked = "Скалистый Сундук Открыт";
        BronzeChestUnlocked = "Бронзовый Сундук Открыт";
        SequoiaChestUnlocked = "Секвойевый Сундук Открыт";
        IronboundChestUnlocked = "Железный Сундук Открыт";
        StoneshieldChestUnlocked = "Каменный Щитовый Сундук Открыт";
        OceanChestUnlocked = "Океанский Сундук Открыт";
        PoisonousChestUnlocked = "Ядовитый Сундук Открыт";
        GoldenChestUnlocked = "Золотой Сундук Открыт";
        DesertChestUnlocked = "Пустынный Сундук Открыт";
        PirateChestUnlocked = "Пиратский Сундук Открыт";
        CrystalChestUnlocked = "Хрустальный Сундук Открыт";
        CelestialChestUnlocked = "Небесный Сундук Открыт";
        PhantomChestUnlocked = "Призрачный Сундук Открыт";
        PrismaticChestUnlocked = "Призматический Сундук Открыт";
        AquaticChestUnlocked = "Водный Сундук Открыт";
        WindwalkersChestUnlocked = "Сундук Ходока Ветра Открыт";
        EnchantedChestUnlocked = "Зачарованный Сундук Открыт";
        RoyalChestUnlocked = "Королевский Сундук Открыт";
        ArcaneChestUnlocked = "Магический Сундук Открыт";
        GrandioseChestUnlocked = "Великолепный Сундук Открыт";
        LuxuriousGoldenChestUnlocked = "Роскошный Золотой Сундук Открыт";
        SacredChestUnlocked = "Священный Сундук Открыт";
        EternitysEmbraceChestUnlocked = "Сундук Объятий Вечности Открыт";
        ForgottenChestUnlocked = "Забытый Сундук Открыт";
        LivingLuminousChestUnlocked = "Живой Светящийся Сундук Открыт";
        FortressOfWealthUnlocked = "Крепость Богатства Открыт";
        FortifiedTimberChestUnlocked = "Укреплённый Тимбервудский Сундук Открыт";
        RadiantFrostlockUnlocked = "Сияющий Замок Мороза Открыт";
        InfernoEmbracedChestUnlocked = "Охваченный Инферно Сундук Открыт";
        DeathChestUnlocked = "Сундук Смерти Открыт";
        AlienChestUnlocked = "Чужеродный Сундук Открыт";
        CraftsmansReliquaryUnlocked = "Реликвия Ремесленника Открыт";
        HellfireGuardianChestUnlocked = "Страж Адского Огня Сундук Открыт";
        GhastlySoulHoardChestUnlocked = "Сундук Призрачного Собирателя Душ Открыт";
        HighTechCacheUnlocked = "Высокотехнологичный Кэш Открыт";
        EliteHackersStrongboxUnlocked = "Сильнейший Хакерский Сейф Открыт";
        CollectorsVaultUnlocked = "Свод Собирателя Открыт";
        ExquisiteAzureRadianceChestUnlocked = "Изысканный Сундук Лазурного Сияния Открыт";


        chestPrice_text.font = robotoBold; chestPrice_text.fontSize = 25;
        chestHP_text.font = robotoBold; chestHP_text.fontSize = 34;
        autoPurchaseONOFF_text.font = russianNono_Bold; autoPurchaseONOFF_text.fontSize = 40;
        chestHoverName_text.font = russianNonoBoldOutLine; chestHoverName_text.fontSize = 22;
        chestNO_text.font = russianNono_MediumOutLine; chestNO_text.fontSize = 30;
        chestXPAmount_text.font = russianNono_MediumOutLine; chestXPAmount_text.fontSize = 19;
        chestGoldCoins_text.font = russianNono_MediumOutLine; chestGoldCoins_text.fontSize = 19;
        chestGoldAmount_text.font = russianNono_MediumOutLine; chestGoldAmount_text.fontSize = 19;
        chestReinforcedChance.font = russianNono_MediumOutLine; chestReinforcedChance.fontSize = 19;
        chestPurchasedName_text.font = russian_SemiBold; chestPurchasedName_text.fontSize = 45;

        reinforcedHoverHealth_text.font = russianNono_SemiSkinny; reinforcedHoverHealth_text.fontSize = 17;
        reinforcedHoverGold_text.font = russianNono_SemiSkinny; reinforcedHoverGold_text.fontSize = 15;
        reinforcedHoverXP_text.font = russianNono_SemiSkinny; reinforcedHoverXP_text.fontSize = 20;

        enchantedGoldenHoverHealth_text.font = russianNono_SemiSkinny; enchantedGoldenHoverHealth_text.fontSize = 14;
        enchantedGoldenHoverTreasures_text.font = russianNono_SemiSkinny; enchantedGoldenHoverTreasures_text.fontSize = 17;
        enchantedGoldenHoverXP_text.font = russianNono_SemiSkinny; enchantedGoldenHoverXP_text.fontSize = 15;

        bossChestHoverHealth_text.font = russianNono_SemiSkinny; bossChestHoverHealth_text.fontSize = 17;
        bossChestHoverGoldValue_text.font = russianNono_SemiSkinny; bossChestHoverGoldValue_text.fontSize = 17;
        bossChestHoverGoldCoins_text.font = russianNono_SemiSkinny; bossChestHoverGoldCoins_text.fontSize = 15;
        bossChestHoverXP_text.font = russianNono_SemiSkinny; bossChestHoverXP_text.fontSize = 15;
        #endregion

        #region Prestige

        prestigeKeyChance1 = ""; prestigeKeyChance2 = "% шанс выпадения ключа престижа";
        prestieChestKey1 = ""; prestieChestKey2 = "% шанс выпадения сундука престижа";

        FindThePrestigeKeyandChest = "Найдите ключ и сундук престижа";
        youFoundThePrestigeKetAndChest = "Вы нашли ключ и сундук престижа!";

        youFoundPrestigeKey = "ВЫ НАШЛИ КЛЮЧ ПРЕСТИЖА!";
        youFoundPrestigeChest = "ВЫ НАШЛИ СУНДУК ПРЕСТИЖА!";

        nextLevelHover = "Следующий уровень = "; skillPointsHover = " очков навыка";

        choseItemToStartWith = "Выберите 1 предмет, чтобы начать";
        chooseItemsToStartWith2 = "Выберите 2 предмет, чтобы начать";
        chooseItemsToStartWith3 = "Выберите 3 предмет, чтобы начать";
        chooseItemsToStartWith5 = "Выберите 5 предмет, чтобы начать";

        if (SpawnRewards.prestigeKeyFound == 0)
        {
            findThePrestigeKeyAncChest_text.text = FindThePrestigeKeyandChest;
        }
        if (SpawnRewards.prestigeChestFound == 0)
        {
            findThePrestigeKeyAncChest_text.text = FindThePrestigeKeyandChest;
        }
        if (SpawnRewards.prestigeChestFound == 1 && SpawnRewards.prestigeKeyFound == 1)
        {
            findThePrestigeKeyAncChest_text.text = youFoundThePrestigeKetAndChest;
        }

        prestigeKeyDropChance_text.font = russianLight; prestigeKeyDropChance_text.fontSize = 17;
        prestigeKeyDropChance_text.text = Localization.prestigeKeyChance1 + 0.017 * (UnlockChests.timesPurchasedChests + 1) + Localization.prestigeKeyChance2;

        prestigeChestDropChance_text.font = russianLight; prestigeChestDropChance_text.fontSize = 17;
        prestigeChestDropChance_text.text = Localization.prestieChestKey1 + 0.017 * (UnlockChests.timesPurchasedChests + 1) + Localization.prestieChestKey2;

        nextLeveEqualSkillPoints_text.text = Localization.nextLevelHover + "<color=green>+" + ((PlayerLevel.playerLevel / 5) + 1) + "<color=white>" + Localization.skillPointsHover;


        findThePrestigeKeyAncChest_text.font = russianNonoBoldOutLine; findThePrestigeKeyAncChest_text.fontSize = 14;
        nextLeveEqualSkillPoints_text.font = russian_SemiBold; nextLeveEqualSkillPoints_text.fontSize = 39;

        chooseItemToStartWith_text.font = russianNono_MediumOutLine; chooseItemToStartWith_text.fontSize = 35;

        #endregion

        #region Other
        level = "УРОВЕНЬ ";
        xpNoPercent = "ОПЫТ";
        crit = "КРИТ!";

        totalGold_text.font = russian_SemiBold; totalGold_text.fontSize = 46;
        levelText_text.font = russianNono_Medium; levelText_text.fontSize = 36; levelText_text.text = "УРОВЕНЬ " + PlayerLevel.playerLevel;
        xpNeededText_text.font = russianLight; xpNeededText_text.fontSize = 15;
        activeDamageAmount_text.font = robotoBold; activeDamageAmount_text.fontSize = 20f;
        passiveDamageAmount_text.font = robotoBold; passiveDamageAmount_text.fontSize = 20f;
        acitveDamagePrice_text.font = robotoBold; acitveDamagePrice_text.fontSize = 20f;
        passiveDamagePrice_text.font = robotoBold; passiveDamagePrice_text.fontSize = 20f;
        activeDamageLEVELAmount_text.font = russianNono_Bold; activeDamageLEVELAmount_text.fontSize = 30f;
        passiveLEVELAmount_text.font = russianNono_Bold; passiveLEVELAmount_text.fontSize = 30f;
        passiveDamageUPGRADE_text.font = robotoBold; passiveDamageUPGRADE_text.fontSize = 20f;
        activeDamageUPGRADE_text.font = robotoBold; activeDamageUPGRADE_text.fontSize = 20f;

        youOpened.font = russianNonoBoldOutLine; youOpened.fontSize = 40; youOpened.lineSpacing = -35;
        timeGoneTotal.font = russianNonoBoldOutLine; timeGoneTotal.fontSize = 40;

        damageUnderChest.font = russianNono_Medium; damageUnderChest.fontSize = 6;
        #endregion



        ChangeAllText();
    }
    #endregion

    #region Japanese  
    public void JapaneseLanguage()
    {
        JapaneseLanguageChosen = 1;
        RussianLanguageChosen = 0;
        EnglishLanguageChosen = 0;
        ChineseLanguageChosen = 0;
        KoreanLanguageChosen = 0;

        if (PlaceMobileButtons.isMobile == true) { ChangeMobileText(); }

        PlayerPrefs.SetInt("SaveEnglish", EnglishLanguageChosen);
        PlayerPrefs.SetInt("SaveRussian", RussianLanguageChosen);
        PlayerPrefs.SetInt("SaveJapanese", JapaneseLanguageChosen);
        PlayerPrefs.SetInt("SaveChinese", ChineseLanguageChosen);
        PlayerPrefs.SetInt("SaveKorean", KoreanLanguageChosen);

        #region TotalGold Strings
        Million = " 百万";
        Billion = " 十億";
        Trillion = " 兆";
        Quadrillion = " 千兆";
        Quintillion = " 京";
        Sextillion = " 千京";
        Septillion = " 垓";
        Octillion = " 千垓";
        Nonillion = " 秭";
        Decillion = " 千秭";
        Undecillion = " 京秭";
        Duodecillion = " 千京秭";
        Tredecillion = " 垓秭";
        Quattuordecillion = " 千垓秭";
        Quindecillion = " 京垓秭";
        Sexdecillion = " 千京垓秭";
        Septendecillion = " 垓垓秭";
        Octodecillion = " 千垓垓秭";
        Novemdecillion = " 京垓垓秭";
        Vigintillion = " 𥝱";
        Unvigintillion = " 𥝱𥝱";
        Duovigintillion = " 千𥝱𥝱";
        Trevigintillion = " 京𥝱𥝱";

        MillionShort = "百万";
        BillionShort = "十億";
        TrillionShort = "兆";
        QuadrillionShort = "千兆";
        QuintillionShort = "京";
        SextillionShort = "千京";
        SeptillionShort = "垓";
        OctillionShort = "千垓";
        NonillionShort = "秭";
        DecillionShort = "千秭";
        UndecillionShort = "京秭";
        DuodecillionShort = "千京秭";
        TredecillionShort = "垓秭";
        QuattuordecillionShort = "千垓秭";
        QuindecillionShort = "京垓秭";
        SexdecillionShort = "千京垓秭";
        SeptendecillionShort = "垓垓秭";
        OctodecillionShort = "千垓垓秭";
        NovemdecillionShort = "京垓垓秭";
        VigintillionShort = "𥝱";
        UnvigintillionShort = "𥝱𥝱";
        DuovigintillionShort = "千𥝱𥝱";
        TrevigintillionShort = "京𥝱𥝱";
        #endregion

        #region Pluss Buffs Strings
        gold = "ゴールド";
        goldPercentString = "%ゴールド";

        clickDamage = "クリックダメージ";
        activeDamageTop = "アクティブダメージ";
        dps = "ダメージ/秒";
        passiveDamageString = "%パッシブダメージ";
        activeDamageScring = "%アクティブダメージ";
        critChanceString = "%クリティカルチャンス";
        critDamageString = "%クリティカルダメージ";

        damagePercent = "%ダメージ";
        xp = "%経験値";
        treasureDropChance = "%トレジャードロップチャンス";
        goldCoinsDrop = "金貨ドロップ";

        friendlyMimic = "友好的な模倣";
        evilMimic = "邪悪な模倣";
        secondsMimic = "秒";

        rareTreasureDropChance = "+レアトレジャードロップチャンス";
        #endregion



        #region Settings Text
        settings_text.text = "設定"; settings_text.font = japaneseBoldOutline; settings_text.fontSize = 36;

        general_text.text = "一般"; general_text.font = japaneseBoldOutline; general_text.fontSize = 19;

        info_text.text = "情報"; info_text.font = japaneseBoldOutline; info_text.fontSize = 20;

        music_text.text = "音楽"; music_text.font = japaneseMedium; music_text.fontSize = 25;

        sound_text.text = "音"; sound_text.font = japaneseMedium; sound_text.fontSize = 24;

        miniChestAndMimicChestSpawnSound_text.text = "ミニチェストとミミックチェストのスポーンサウンド"; miniChestAndMimicChestSpawnSound_text.font = japaneseMedium; miniChestAndMimicChestSpawnSound_text.fontSize = 16;

        mimicChestSpawning_text.text = "胸の産卵を模倣する"; mimicChestSpawning_text.font = japaneseMedium; mimicChestSpawning_text.fontSize = 20;

        fullscreen_text.text = "フルスクリーン"; fullscreen_text.font = japaneseMedium; fullscreen_text.fontSize = 15;

        onFullScreen_text.text = "オン"; onFullScreen_text.font = japaneseBold; onFullScreen_text.fontSize = 30;

        offFullScreen_text.text = "オフ"; offFullScreen_text.font = japaneseBold; offFullScreen_text.fontSize = 30;

        onMimicSpawn_text.text = "オン"; onMimicSpawn_text.font = japaneseBold; onMimicSpawn_text.fontSize = 30;

        offMimicSpawn_text.text = "オフ"; offMimicSpawn_text.font = japaneseBold; offMimicSpawn_text.fontSize = 30;

        onMiniAndMimicSound_text.text = "オン"; onMiniAndMimicSound_text.font = japaneseBold; onMiniAndMimicSound_text.fontSize = 30;

        offMiniAndMimicSound_text.text = "オフ"; offMiniAndMimicSound_text.font = japaneseBold; offMiniAndMimicSound_text.fontSize = 30;

        resolution_text.text = "解像度"; resolution_text.font = japaneseMedium; resolution_text.fontSize = 19;

        exit_text.text = "出口"; exit_text.font = japaneseBold; exit_text.fontSize = 60;

        save_text.text = "保存"; save_text.font = japaneseBold; save_text.fontSize = 36;

        gameSavesEvery15Seconds_text.text = "ゲームは15秒ごとに保存されます"; gameSavesEvery15Seconds_text.font = japaneseBoldOutline; gameSavesEvery15Seconds_text.fontSize = 11;

        cantSaveDuringPrestige_text.text = "プレステージ中に保存できません"; cantSaveDuringPrestige_text.font = japaneseBold; cantSaveDuringPrestige_text.fontSize = 20;

        resetGame_text.text = "リセットゲーム"; resetGame_text.font = japaneseBold; resetGame_text.fontSize = 25; resetGame_text.lineSpacing = -50;

        discord_text.text = "不和"; discord_text.font = japaneseMedium; discord_text.fontSize = 32;

        numberOfCoinsAndTreasuresOnScreen_text.text = "彼らは自動的に収集する前に、画面上のコインや宝物の数"; numberOfCoinsAndTreasuresOnScreen_text.font = japaneseMedium; numberOfCoinsAndTreasuresOnScreen_text.fontSize = 16;

        reinforcedChests_text.text = "強化チェスト"; reinforcedChests_text.font = japaneseMedium; reinforcedChests_text.fontSize = 17;

        reinforcedChestsDescription_text.text = "各胸には、胸の強化バージョンになるチャンスがあります。強化されたチャンスは、どの胸が購入されているかによって異なります。"; reinforcedChestsDescription_text.font = japaneseMedium; reinforcedChestsDescription_text.fontSize = 10;

        enchantedGoldenChests_text.text = "エンチャントされた黄金の宝箱"; enchantedGoldenChests_text.font = japaneseMedium; enchantedGoldenChests_text.fontSize = 17;

        bossChests_text.text = "ボスチェスト"; bossChests_text.font = japaneseMedium; bossChests_text.fontSize = 17;

        musicBy_text.text = "音楽： Kevin MacLeod - Arpent"; musicBy_text.font = japaneseMedium; musicBy_text.fontSize = 15;

        developerInfo_text.text = "宝箱クリッカーはによって開発されています： Simon Eftestøl"; developerInfo_text.font = japaneseMedium; developerInfo_text.fontSize = 15;

        resetConfirmation_text.text = "あなたはすべてをリセットしたいですか？ゲームは最初から始まります。"; resetConfirmation_text.font = japaneseBoldOutline; resetConfirmation_text.fontSize = 20;

        yes_text.text = "はい"; yes_text.font = japaneseBoldOutline; yes_text.fontSize = 55;

        no_text.text = "いいえ"; no_text.font = japaneseBoldOutline; no_text.fontSize = 55;

        gameSaves_Text.text = "ゲーム保存！"; gameSaves_Text.font = japaneseBoldOutline; gameSaves_Text.fontSize = 15;
        #endregion

        #region stats
        stats_text.text = "ﾂづ慊つｷﾂ"; stats_text.font = japaneseBoldOutline; stats_text.fontSize = 40;
        goldAndTreasures_text.text = "ゴールド＆トレジャーズ"; goldAndTreasures_text.font = japaneseSemiBold; goldAndTreasures_text.fontSize = 37;
        chests_text.text = "チェスト"; chests_text.font = japaneseSemiBold; chests_text.fontSize = 55;
        damage_text.text = "ダメージ"; damage_text.font = japaneseSemiBold; damage_text.fontSize = 55;
        items.text = "アイテム"; items.font = japaneseSemiBold; items.fontSize = 55;
        buffsAndPrestige_text.text = "バフ＆プレステージ"; buffsAndPrestige_text.font = japaneseSemiBold; buffsAndPrestige_text.fontSize = 45;
        #endregion

        #region Achievements
        achievements_text.text = "実績"; achievements_text.font = japaneseBoldOutline; achievements_text.fontSize = 40;
        drop25GoldCoins_text.text = "宝箱から金貨25枚を落とす"; drop25GoldCoins_text.font = japaneseMediumOutline; drop25GoldCoins_text.fontSize = 24;
        drop1000GoldCoins_text.text = "チェストから金貨を1000枚落とす"; drop1000GoldCoins_text.font = japaneseMediumOutline; drop1000GoldCoins_text.fontSize = 24;
        drop100000GoldCoins_text.text = "チェストから金貨を10万枚落とす"; drop100000GoldCoins_text.font = japaneseMediumOutline; drop100000GoldCoins_text.fontSize = 24;
        drop1MillionGoldCoins_text.text = "宝箱から金貨100万枚を落とす"; drop1MillionGoldCoins_text.font = japaneseMediumOutline; drop1MillionGoldCoins_text.fontSize = 24;
        total100Gold_text.text = "合計100ゴールドを持っている"; total100Gold_text.font = japaneseMediumOutline; total100Gold_text.fontSize = 24;
        total100000Gold_text.text = "合計100,000ゴールドを持っている"; total100000Gold_text.font = japaneseMediumOutline; total100000Gold_text.fontSize = 24;
        total1MillionGold_text.text = "合計100万ゴールドを持っている"; total1MillionGold_text.font = japaneseMediumOutline; total1MillionGold_text.fontSize = 24;
        total1BillionGold_text.text = "合計10億ゴールドを持っている"; total1BillionGold_text.font = japaneseMediumOutline; total1BillionGold_text.fontSize = 24;
        total1TrillionGold_text.text = "合計1兆ゴールドを持っている"; total1TrillionGold_text.font = japaneseMediumOutline; total1TrillionGold_text.fontSize = 24;

        //10
        total1QuadrillionGold_text.text = "合計1兆ゴールドを持っている"; total1QuadrillionGold_text.font = japaneseMediumOutline; total1QuadrillionGold_text.fontSize = 24;
        total1QuintillionGold_text.text = "合計1クインティリオンゴールドを持っている"; total1QuintillionGold_text.font = japaneseMediumOutline; total1QuintillionGold_text.fontSize = 24;
        total1SextillionGold_text.text = "合計1セクスティリオンゴールドを個所持う"; total1SextillionGold_text.font = japaneseMediumOutline; total1SextillionGold_text.fontSize = 24;
        total1SeptillionGold_text.text = "合計1セプティリオンゴールドを1個所持う"; total1SeptillionGold_text.font = japaneseMediumOutline; total1SeptillionGold_text.fontSize = 24;
        total1OctillionGold_text.text = "合計1オクティリオンゴールドを持っている"; total1OctillionGold_text.font = japaneseMediumOutline; total1OctillionGold_text.fontSize = 24;
        total1NonillionGold_text.text = "合計1つのノニリオンゴールドを持っている"; total1NonillionGold_text.font = japaneseMediumOutline; total1NonillionGold_text.fontSize = 24;
        total1DecillionGold_text.text = "合計1デシリオンゴールドを持っている"; total1DecillionGold_text.font = japaneseMediumOutline; total1DecillionGold_text.fontSize = 24;
        total1NovemdecillionGold_text.text = "合計11月金を持っている"; total1NovemdecillionGold_text.font = japaneseMediumOutline; total1NovemdecillionGold_text.fontSize = 24;
        drop5XGoldCoin_text.text = "5倍の金貨を落とす"; drop5XGoldCoin_text.font = japaneseMediumOutline; drop5XGoldCoin_text.fontSize = 24;
        drop1000_5XGoldCoins_text.text = "1000、5倍の金貨をドロップ"; drop1000_5XGoldCoins_text.font = japaneseMediumOutline; drop1000_5XGoldCoins_text.fontSize = 24;

        //20
        drop50000_5XGoldCoins_text.text = "50000、5倍の金貨をドロップ"; drop50000_5XGoldCoins_text.font = japaneseMediumOutline; drop50000_5XGoldCoins_text.fontSize = 24;
        drop10XGoldCoin_text.text = "10倍の金貨を落とす"; drop10XGoldCoin_text.font = japaneseMediumOutline; drop10XGoldCoin_text.fontSize = 24;
        drop1000_10XGoldCoins_text.text = "1000、10倍の金貨を落とす"; drop1000_10XGoldCoins_text.font = japaneseMediumOutline; drop1000_10XGoldCoins_text.fontSize = 24;
        drop15000_10XGoldCoins_text.text = "15000、10倍の金貨をドロップ"; drop15000_10XGoldCoins_text.font = japaneseMediumOutline; drop15000_10XGoldCoins_text.fontSize = 24;
        spawn10GoldCoinsFromClicks_text.text = "クリックで金貨を10枚スポーンする"; spawn10GoldCoinsFromClicks_text.font = japaneseMediumOutline; spawn10GoldCoinsFromClicks_text.fontSize = 24;
        spawn100GoldCoinsFromClicks_text.text = "クリックで金貨を100枚スポーンする"; spawn100GoldCoinsFromClicks_text.font = japaneseMediumOutline; spawn100GoldCoinsFromClicks_text.fontSize = 24;
        spawn1000GoldCoinsFromClicks_text.text = "クリックから1000枚の金貨をスポーンする"; spawn1000GoldCoinsFromClicks_text.font = japaneseMediumOutline; spawn1000GoldCoinsFromClicks_text.fontSize = 24;
        oneTreasureDropped_text.text = "宝箱から落とした宝物1個"; oneTreasureDropped_text.font = japaneseMediumOutline; oneTreasureDropped_text.fontSize = 24;
        hundredTreasuresDropped_text.text = "宝箱から落とした宝物100個"; hundredTreasuresDropped_text.font = japaneseMediumOutline; hundredTreasuresDropped_text.fontSize = 24;
        thousandTreasuresDropped_text.text = "宝箱から落とした宝物1000個"; thousandTreasuresDropped_text.font = japaneseMediumOutline; thousandTreasuresDropped_text.fontSize = 24;
        tenThousandTreasuresDropped_text.text = "宝箱から10000個の宝物を落とした"; tenThousandTreasuresDropped_text.font = japaneseMediumOutline; tenThousandTreasuresDropped_text.fontSize = 24;
        fiftyThousandTreasuresDropped_text.text = "宝箱から50000個の宝物がドロップ"; fiftyThousandTreasuresDropped_text.font = japaneseMediumOutline; fiftyThousandTreasuresDropped_text.fontSize = 24;

        //30 (Continued from 20)
        hundredCommonTreasures_text.text = "チェストから落とした100の共通の宝物"; hundredCommonTreasures_text.font = japaneseMediumOutline; hundredCommonTreasures_text.fontSize = 22;
        hundredUncommonTreasures_text.text = "チェストから落とした珍しい宝物100個"; hundredUncommonTreasures_text.font = japaneseMediumOutline; hundredUncommonTreasures_text.fontSize = 22;
        hundredRareTreasures_text.text = "宝箱から落とすレア宝物100個"; hundredRareTreasures_text.font = japaneseMediumOutline; hundredRareTreasures_text.fontSize = 22;
        hundredVeryRareTreasures_text.text = "宝箱から落とす非常に珍しい宝物100個"; hundredVeryRareTreasures_text.font = japaneseMediumOutline; hundredVeryRareTreasures_text.fontSize = 22;
        hundredExtremelyRareTreasures_text.text = "宝箱から落とす極稀レア宝物100個"; hundredExtremelyRareTreasures_text.font = japaneseMediumOutline; hundredExtremelyRareTreasures_text.fontSize = 24;
        hundredLegendaryTreasures_text.text = "宝箱から落とした伝説の宝物100個"; hundredLegendaryTreasures_text.font = japaneseMediumOutline; hundredLegendaryTreasures_text.fontSize = 24;
        spawn10TreasuresFromClicks_text.text = "クリックで宝物を10個スポーンする"; spawn10TreasuresFromClicks_text.font = japaneseMediumOutline; spawn10TreasuresFromClicks_text.fontSize = 24;
        spawn100TreasuresFromClicks_text.text = "クリックで100個の宝物をスポーンする"; spawn100TreasuresFromClicks_text.font = japaneseMediumOutline; spawn100TreasuresFromClicks_text.fontSize = 24;
        spawn1000TreasuresFromClicks_text.text = "クリックで1000個の宝物をスポーンする"; spawn1000TreasuresFromClicks_text.font = japaneseMediumOutline; spawn1000TreasuresFromClicks_text.fontSize = 24;
        hundredTreasuresDoubled_text.text = "100個の宝物の価値が2倍に"; hundredTreasuresDoubled_text.font = japaneseMediumOutline; hundredTreasuresDoubled_text.fontSize = 24;

        //40 (Continued from 30)
        find1RareTreasure_text.text = "珍しい宝物を1つ見つけよう"; find1RareTreasure_text.font = japaneseMediumOutline; find1RareTreasure_text.fontSize = 24;
        find3RareTreasures_text.text = "珍しい宝物を3つ見つけよう"; find3RareTreasures_text.font = japaneseMediumOutline; find3RareTreasures_text.fontSize = 24;
        find5RareTreasures_text.text = "珍しい宝物を5つ見つけよう"; find5RareTreasures_text.font = japaneseMediumOutline; find5RareTreasures_text.fontSize = 24;
        find13RareTreasures_text.text = "珍しい宝物を13個見つけよう"; find13RareTreasures_text.font = japaneseMediumOutline; find13RareTreasures_text.fontSize = 24;
        findAll25RareTreasures_text.text = "25種類のレアな宝物をすべて見つけよう"; findAll25RareTreasures_text.font = japaneseMediumOutline; findAll25RareTreasures_text.fontSize = 24;
        findTheCookie_text.text = "クッキーを見つけよう!"; findTheCookie_text.font = japaneseMediumOutline; findTheCookie_text.fontSize = 24;
        cookieClicker_text.text = "クッキークリッカー!"; cookieClicker_text.font = japaneseMediumOutline; cookieClicker_text.fontSize = 24;
        prestige_text.text = "名誉"; prestige_text.font = japaneseMediumOutline; prestige_text.fontSize = 24;
        prestige5Times_text.text = "プレステージ5回"; prestige5Times_text.font = japaneseMediumOutline; prestige5Times_text.fontSize = 24;
        prestige15Times_text.text = "プレステージ15回"; prestige15Times_text.font = japaneseMediumOutline; prestige15Times_text.fontSize = 24;

        //50 (Continued from 40)
        purchase5PrestigeUpgrades_text.text = "プレステージアップグレードを5つ購入する"; purchase5PrestigeUpgrades_text.font = japaneseMediumOutline; purchase5PrestigeUpgrades_text.fontSize = 24;
        purchase15PrestigeUpgrades_text.text = "プレステージアップグレードを15個購入する"; purchase15PrestigeUpgrades_text.font = japaneseMediumOutline; purchase15PrestigeUpgrades_text.fontSize = 24;
        purchase35PrestigeUpgrades_text.text = "プレステージアップグレードを35個購入"; purchase35PrestigeUpgrades_text.font = japaneseMediumOutline; purchase35PrestigeUpgrades_text.fontSize = 24;
        purchase60PrestigeUpgrades_text.text = "プレステージアップグレードを60個購入"; purchase60PrestigeUpgrades_text.font = japaneseMediumOutline; purchase60PrestigeUpgrades_text.fontSize = 24;
        purchaseAllPrestigeUpgrades_text.text = "すべてのプレステージアップグレードを購入する"; purchaseAllPrestigeUpgrades_text.font = japaneseMediumOutline; purchaseAllPrestigeUpgrades_text.fontSize = 24;
        purchaseAllPrestigeClickerUpgrades_text.text = "すべてのプレステージクリッカーアップグレードを購入する"; purchaseAllPrestigeClickerUpgrades_text.font = japaneseMediumOutline; purchaseAllPrestigeClickerUpgrades_text.fontSize = 24;
        purchaseAllPrestigeLoungerUpgrades_text.text = "すべてのプレステージラウンジャーアップグレードを購入する"; purchaseAllPrestigeLoungerUpgrades_text.font = japaneseMediumOutline; purchaseAllPrestigeLoungerUpgrades_text.fontSize = 24;
        purchaseAllPrestigePirateUpgrades_text.text = "すべてのプレステージ海賊アップグレードを購入する"; purchaseAllPrestigePirateUpgrades_text.font = japaneseMediumOutline; purchaseAllPrestigePirateUpgrades_text.fontSize = 24;
        purchaseAllPrestigeHoarderUpgrades_text.text = "すべてのプレステージ買いだめアップグレードを購入する"; purchaseAllPrestigeHoarderUpgrades_text.font = japaneseMediumOutline; purchaseAllPrestigeHoarderUpgrades_text.fontSize = 24;
        purchaseAllPrestigeAdventurerUpgrades_text.text = "すべてのプレステージアドベンチャーアップグレードを購入する"; purchaseAllPrestigeAdventurerUpgrades_text.font = japaneseMediumOutline; purchaseAllPrestigeAdventurerUpgrades_text.fontSize = 24;

        //60 (Continued from 50)
        purchaseLootPotion_text.text = "戦利品ポーションを購入する"; purchaseLootPotion_text.font = japaneseMediumOutline; purchaseLootPotion_text.fontSize = 24;
        purchaseGoldenTouch_text.text = "ゴールデンタッチを購入する"; purchaseGoldenTouch_text.font = japaneseMediumOutline; purchaseGoldenTouch_text.fontSize = 24;
        purchaseSerendipityScroll_text.text = "セレンディピティスクロールを購入する"; purchaseSerendipityScroll_text.font = japaneseMediumOutline; purchaseSerendipityScroll_text.fontSize = 24;
        purchaseKey_text.text = "キーを購入する"; purchaseKey_text.font = japaneseMediumOutline; purchaseKey_text.fontSize = 24;
        purchaseMagicalElixir_text.text = "魔法のエリクサーを購入する"; purchaseMagicalElixir_text.font = japaneseMediumOutline; purchaseMagicalElixir_text.fontSize = 24;
        purchaseAncientRelic_text.text = "古代の遺物を購入する"; purchaseAncientRelic_text.font = japaneseMediumOutline; purchaseAncientRelic_text.fontSize = 24;
        purchaseEnchantedHammer_text.text = "エンチャンテッドハンマーを購入する"; purchaseEnchantedHammer_text.font = japaneseMediumOutline; purchaseEnchantedHammer_text.fontSize = 24;
        openChest_text.text = "チェストを開く"; openChest_text.font = japaneseMediumOutline; openChest_text.fontSize = 24;
        open100Chests_text.text = "100個のチェストを開く"; open100Chests_text.font = japaneseMediumOutline; open100Chests_text.fontSize = 24;
        open1000Chests_text.text = "1000個のチェストを開く"; open1000Chests_text.font = japaneseMediumOutline; open1000Chests_text.fontSize = 24;

        //70 (Continued from 60)
        open10000Chests_text.text = "10000個のチェストを開く"; open10000Chests_text.font = japaneseMediumOutline; open10000Chests_text.fontSize = 24;
        open100000Chests_text.text = "100,000個のチェストを開く"; open100000Chests_text.font = japaneseMediumOutline; open100000Chests_text.fontSize = 24;
        open200000Chests_text.text = "200,000個のチェストを開く"; open200000Chests_text.font = japaneseMediumOutline; open200000Chests_text.fontSize = 24;
        purchaseChestNo2_text.text = "購入チェスト2号"; purchaseChestNo2_text.font = japaneseMediumOutline; purchaseChestNo2_text.fontSize = 24;
        purchaseChestNo5_text.text = "購入チェスト5号"; purchaseChestNo5_text.font = japaneseMediumOutline; purchaseChestNo5_text.fontSize = 24;
        purchaseChestNo8_text.text = "購入チェスト8号"; purchaseChestNo8_text.font = japaneseMediumOutline; purchaseChestNo8_text.fontSize = 24;
        purchaseChestNo12_text.text = "購入チェスト12号"; purchaseChestNo12_text.font = japaneseMediumOutline; purchaseChestNo12_text.fontSize = 24;
        purchaseChestNo15_text.text = "購入チェスト15号"; purchaseChestNo15_text.font = japaneseMediumOutline; purchaseChestNo15_text.fontSize = 24;
        purchaseChestNo20_text.text = "購入チェスト20号"; purchaseChestNo20_text.font = japaneseMediumOutline; purchaseChestNo20_text.fontSize = 24;
        purchaseChestNo24_text.text = "購入チェスト24号"; purchaseChestNo24_text.font = japaneseMediumOutline; purchaseChestNo24_text.fontSize = 24;

        //80 (Continued from 70)
        purchaseChestNo32_text.text = "購入チェスト32号"; purchaseChestNo32_text.font = japaneseMediumOutline; purchaseChestNo32_text.fontSize = 24;
        purchaseTheFinalChest_text.text = "最後の宝箱を購入する"; purchaseTheFinalChest_text.font = japaneseMediumOutline; purchaseTheFinalChest_text.fontSize = 24;
        openTheFinalChest_text.text = "最後のチェストを開ける"; openTheFinalChest_text.font = japaneseMediumOutline; openTheFinalChest_text.fontSize = 24;
        openAReinforcedChest_text.text = "強化されたチェストを開く"; openAReinforcedChest_text.font = japaneseMediumOutline; openAReinforcedChest_text.fontSize = 24;
        open100ReinforcedChests_text.text = "100個の強化チェストを開く"; open100ReinforcedChests_text.font = japaneseMediumOutline; open100ReinforcedChests_text.fontSize = 24;
        open500ReinforcedChests_text.text = "500個の強化チェストを開く"; open500ReinforcedChests_text.font = japaneseMediumOutline; open500ReinforcedChests_text.fontSize = 24;
        open1000ReinforcedChests_text.text = "1000個の強化チェストを開く"; open1000ReinforcedChests_text.font = japaneseMediumOutline; open1000ReinforcedChests_text.fontSize = 24;
        open100EnchantedGoldenChests_text.text = "魔法の黄金の宝箱を100個開ける"; open100EnchantedGoldenChests_text.font = japaneseMediumOutline; open100EnchantedGoldenChests_text.fontSize = 24;
        open100BossChests_text.text = "ボス宝箱を100個開ける"; open100BossChests_text.font = japaneseMediumOutline; open100BossChests_text.fontSize = 24;
        receiveTotal50SkillPoints_text.text = "合計50スキルポイントを獲得"; receiveTotal50SkillPoints_text.font = japaneseMediumOutline; receiveTotal50SkillPoints_text.fontSize = 24;

        //90 (Continued from 80)
        receiveTotal500SkillPoints_text.text = "合計500スキルポイントを獲得"; receiveTotal500SkillPoints_text.font = japaneseMediumOutline; receiveTotal500SkillPoints_text.fontSize = 24;
        receiveTotal1000SkillPoints_text.text = "合計1000スキルポイントを受け取る"; receiveTotal1000SkillPoints_text.font = japaneseMediumOutline; receiveTotal1000SkillPoints_text.fontSize = 24;
        receiveTotal10000SkillPoints_text.text = "合計10000スキルポイントを受け取る"; receiveTotal10000SkillPoints_text.font = japaneseMediumOutline; receiveTotal10000SkillPoints_text.fontSize = 24;
        reachLevel10_text.text = "レベル10に到達する"; reachLevel10_text.font = japaneseMediumOutline; reachLevel10_text.fontSize = 24;
        reachLevel25_text.text = "レベル25に到達"; reachLevel25_text.font = japaneseMediumOutline; reachLevel25_text.fontSize = 24;
        reachLevel50_text.text = "レベル50に到達する"; reachLevel50_text.font = japaneseMediumOutline; reachLevel50_text.fontSize = 24;
        reachLevel100_text.text = "レベル100に到達する"; reachLevel100_text.font = japaneseMediumOutline; reachLevel100_text.fontSize = 24;
        reachLevel200_text.text = "レベル200に達する"; reachLevel200_text.font = japaneseMediumOutline; reachLevel200_text.fontSize = 24;
        drop1000_25XGoldCoins_text.text = "1000、25倍の金貨を落とす"; drop1000_25XGoldCoins_text.font = japaneseMediumOutline; drop1000_25XGoldCoins_text.fontSize = 24;
        drop2MillionGoldCoins_text.text = "200万枚の金貨をドロップする"; drop2MillionGoldCoins_text.font = japaneseMediumOutline; drop2MillionGoldCoins_text.fontSize = 24;

        //100 (Continued from 90)
        drop100XGoldCoin_text.text = "100倍の金貨を落とす"; drop100XGoldCoin_text.font = japaneseMediumOutline; drop100XGoldCoin_text.fontSize = 24;
        haveTotal1UndecillionGold_text.text = "合計1デシリオンゴールドを持っている"; haveTotal1UndecillionGold_text.font = japaneseMediumOutline; haveTotal1UndecillionGold_text.fontSize = 24;
        haveTotal1DuodecillionGold_text.text = "合計1ドゥオデシリオンゴールドを持っている"; haveTotal1DuodecillionGold_text.font = japaneseMediumOutline; haveTotal1DuodecillionGold_text.fontSize = 24;
        haveTotal1TredecillionGold_text.text = "合計1トレデシリオンゴールドを個所持う"; haveTotal1TredecillionGold_text.font = japaneseMediumOutline; haveTotal1TredecillionGold_text.fontSize = 24;
        haveTotal1QuattuordecillionGold_text.text = "合計1クワットゥオルデシリオンゴールドを持っている"; haveTotal1QuattuordecillionGold_text.font = japaneseMediumOutline; haveTotal1QuattuordecillionGold_text.fontSize = 24;
        haveTotal1QuindecillionGold_text.text = "合計1キンデシリオンゴールドを持っている"; haveTotal1QuindecillionGold_text.font = japaneseMediumOutline; haveTotal1QuindecillionGold_text.fontSize = 24;
        haveTotal1SexdecillionGold_text.text = "合計1つのセクデシリオンゴールドを持っている"; haveTotal1SexdecillionGold_text.font = japaneseMediumOutline; haveTotal1SexdecillionGold_text.fontSize = 24;
        haveTotal1SeptendecillionGold_text.text = "合計1セプテンデシリオンゴールドを持っている"; haveTotal1SeptendecillionGold_text.font = japaneseMediumOutline; haveTotal1SeptendecillionGold_text.fontSize = 24;
        haveTotal1OctodecillionGold_text.text = "合計1オクトデシリオンゴールドを持っている"; haveTotal1OctodecillionGold_text.font = japaneseMediumOutline; haveTotal1OctodecillionGold_text.fontSize = 24;
        reachLevel150_text.text = "レベル150に達する"; reachLevel150_text.font = japaneseMediumOutline; reachLevel150_text.fontSize = 24;

        //110 (Continued from 100)
        receiveTotal20000SkillPoints_text.text = "合計20000スキルポイントを受け取る"; receiveTotal20000SkillPoints_text.font = japaneseMediumOutline; receiveTotal20000SkillPoints_text.fontSize = 24;
        chestsHaveDropped100KTreasures_text.text = "チェストは100Kの宝物を落としました"; chestsHaveDropped100KTreasures_text.font = japaneseMediumOutline; chestsHaveDropped100KTreasures_text.fontSize = 24;
        hundredUltraTreasuresDropped_text.text = "チェストからドロップしたウルトラの宝物100個"; hundredUltraTreasuresDropped_text.font = japaneseMediumOutline; hundredUltraTreasuresDropped_text.fontSize = 24;
        hundredMythicTreasuresDropped_text.text = "チェストから落とした100の神話の宝物"; hundredMythicTreasuresDropped_text.font = japaneseMediumOutline; hundredMythicTreasuresDropped_text.fontSize = 24;
        hundredEternalTreasuresDropped_text.text = "宝箱から落とされた永遠の宝物100個"; hundredEternalTreasuresDropped_text.font = japaneseMediumOutline; hundredEternalTreasuresDropped_text.fontSize = 24;
        open2500ReinforcedChests_text.text = "2500の強化チェストを開く"; open2500ReinforcedChests_text.font = japaneseMediumOutline; open2500ReinforcedChests_text.fontSize = 24;
        purchaseChestNo37_text.text = "購入チェスト37号"; purchaseChestNo37_text.font = japaneseMediumOutline; purchaseChestNo37_text.fontSize = 24;
        useTheChicken_text.text = "鶏肉を使う"; useTheChicken_text.font = japaneseMediumOutline; useTheChicken_text.fontSize = 24;
        drop250000_5XGoldCoins_text.text = "250000、5X倍の金貨をドロップ"; drop250000_5XGoldCoins_text.font = japaneseMediumOutline; drop250000_5XGoldCoins_text.fontSize = 24;
        #endregion

        #region Cursors
        // Cursors - Cursors Hover Text

        // Cursors - Cursors Hover Text
        for (int i = 0; i < 21; i++)
        {
            levelUp_text[i].text = "アップグレード"; levelUp_text[i].font = japaneseSemiBold; levelUp_text[i].fontSize = 20;
            if (PlaceMobileButtons.isMobile == true) { levelUp_text[i].fontSize = 15; }
        }

        // Cursors - Others
        cursor1PassiveDamage_Text.text = "+0%パッシブダメージ"; cursor1PassiveDamage_Text.font = japaneseBold; cursor1PassiveDamage_Text.fontSize = 20;
        cursor1CritChance_Text.text = "+0%クリティカルチャンス"; cursor1CritChance_Text.font = japaneseBold; cursor1CritChance_Text.fontSize = 20;
        cursor1CritDamage_Text.text = "+0%クリティカルダメージ"; cursor1CritDamage_Text.font = japaneseBold; cursor1CritDamage_Text.fontSize = 20;

        // Cursors - Cursor 2
        cursor2ActiveDamage_Text.text = "+0%アクティブダメージ"; cursor2ActiveDamage_Text.font = japaneseBold; cursor2ActiveDamage_Text.fontSize = 20;
        cursor2CritChance_Text.text = "+0%クリティカルチャンス"; cursor2CritChance_Text.font = japaneseBold; cursor2CritChance_Text.fontSize = 20;
        cursor2CritDamage_Text.text = "+0%クリティカルダメージ"; cursor2CritDamage_Text.font = japaneseBold; cursor2CritDamage_Text.fontSize = 20;

        // Cursors - Cursor 3
        cursor3ActiveDamage_Text.text = "+0%アクティブダメージ"; cursor3ActiveDamage_Text.font = japaneseBold; cursor3ActiveDamage_Text.fontSize = 20;
        cursor3PassiveDamage_Text.text = "+0%パッシブダメージ"; cursor3PassiveDamage_Text.font = japaneseBold; cursor3PassiveDamage_Text.fontSize = 20;

        // Cursors - Cursor 4
        cursor4CritChance_Text.text = "+0%クリティカルチャンス"; cursor4CritChance_Text.font = japaneseBold; cursor4CritChance_Text.fontSize = 20;
        cursor4CritDamage_Text.text = "+0%クリティカルダメージ"; cursor4CritDamage_Text.font = japaneseBold; cursor4CritDamage_Text.fontSize = 20;

        // Cursors - Cursor 5
        cursor5PassiveDamage_Text.text = "+0%パッシブダメージ"; cursor5PassiveDamage_Text.font = japaneseBold; cursor5PassiveDamage_Text.fontSize = 20;

        // Cursors - Cursor 7
        cursor7PassiveDamage_Text.text = "+0%パッシブダメージ"; cursor7PassiveDamage_Text.font = japaneseBold; cursor7PassiveDamage_Text.fontSize = 20;

        // Cursors - Cursor 9
        cursor9CritChance_Text.text = "+0%クリティカルチャンス"; cursor9CritChance_Text.font = japaneseBold; cursor9CritChance_Text.fontSize = 20;
        cursor9CritDamage_Text.text = "+0%クリティカルダメージ"; cursor9CritDamage_Text.font = japaneseBold; cursor9CritDamage_Text.fontSize = 20;

        // Cursors - Cursor 10
        cursor10ActiveDamage_Text.text = "+0%アクティブダメージ"; cursor10ActiveDamage_Text.font = japaneseBold; cursor10ActiveDamage_Text.fontSize = 20;
        cursor10CritChance_Text.text = "+0%クリティカルチャンス"; cursor10CritChance_Text.font = japaneseBold; cursor10CritChance_Text.fontSize = 20;
        cursor10CritDamage_Text.text = "+0%クリティカルダメージ"; cursor10CritDamage_Text.font = japaneseBold; cursor10CritDamage_Text.fontSize = 20;

        // Cursors - Cursor 11
        cursor11PassiveDamage_Text.text = "+0%パッシブダメージ"; cursor11PassiveDamage_Text.font = japaneseBold; cursor11PassiveDamage_Text.fontSize = 20;


        cursors_text.text = "カーソル"; cursors_text.font = japaneseSemiBold; cursors_text.fontSize = 55;
        cursorsHover_text.text = "カーソル"; cursorsHover_text.font = japaneseSemiBold; cursorsHover_text.fontSize = 40;
        onlyOneCursorEquipped_text.text = "カーソルは1つだけ装備できます"; onlyOneCursorEquipped_text.font = japaneseRegular; onlyOneCursorEquipped_text.fontSize = 21.5f;
        equipCursorFitsPlaystyle_text.text = "あなたのプレイスタイルに合ったカーソルを装備"; equipCursorFitsPlaystyle_text.font = japaneseRegular; equipCursorFitsPlaystyle_text.fontSize = 21.5f;
        uniqueCursorBonus_text.text = "各カーソルには一意のカーソルボーナスがあります"; uniqueCursorBonus_text.font = japaneseRegular; uniqueCursorBonus_text.fontSize = 21.5f;
        levelUpCursors_text.text = "あなたの宝物を費やすことによって、あなたのカーソルをレベルアップ。"; levelUpCursors_text.font = japaneseRegular; levelUpCursors_text.fontSize = 21.5f;

        gentleTap_text.text = "ジェントルタップ"; gentleTap_text.font = japaneseSemiBold; gentleTap_text.fontSize = 35f;
        if(PlaceMobileButtons.isMobile == true) { gentleTap_text.fontSize = 23f; }
        gentleTap2_text.text = "ジェントルタップ"; gentleTap2_text.font = japaneseSemiBold; gentleTap2_text.fontSize = 24f;
        gentleTapCursorBonus_text.text = "カーソルボーナス：クリックするたびに1％の確率で1つの金貨が生成されます"; gentleTapCursorBonus_text.font = japaneseBold; gentleTapCursorBonus_text.fontSize = 21f;
        relaxedPalm_text.text = "リラックスした手のひら"; relaxedPalm_text.font = japaneseSemiBold; relaxedPalm_text.fontSize = 24f;
        if (PlaceMobileButtons.isMobile == true) { relaxedPalm_text.fontSize = 17f; }
        relaxedPalm2_text.text = "リラックスした手のひら"; relaxedPalm2_text.font = japaneseSemiBold; relaxedPalm2_text.fontSize = 17f;
        relaxedPalmCursorBonus_text.text = "カーソルボーナス：開かれた10個のチェストごとに25％のチャンスがあり、5個の金貨をスポーンします"; relaxedPalmCursorBonus_text.font = japaneseBold; relaxedPalmCursorBonus_text.fontSize = 21f;
        galeForce_text.text = "ゲイルフォース"; galeForce_text.font = japaneseSemiBold; galeForce_text.fontSize = 35f;
        if (PlaceMobileButtons.isMobile == true) { galeForce_text.fontSize = 27f; }
        galeForce2_text.text = "ゲイルフォース"; galeForce2_text.font = japaneseSemiBold; galeForce2_text.fontSize = 24f;
        galeForceCursorBonus_text.text = "カーソルボーナス：あなたがクリティカルヒットを扱うたびに、25％のチャンスがあります1金貨をスポーン"; galeForceCursorBonus_text.font = japaneseBold; galeForceCursorBonus_text.fontSize = 21f;
        radiantTouch_text.text = "ラディアントタッチ"; radiantTouch_text.font = japaneseSemiBold; radiantTouch_text.fontSize = 18f;
        radiantTouch2_text.text = "ラディアントタッチ"; radiantTouch2_text.font = japaneseSemiBold; radiantTouch2_text.fontSize = 19f;
        radiantTouchCursorBonus_text.text = "カーソルボーナス：開いたチェストごとに7つの金貨を35個スポーンします"; radiantTouchCursorBonus_text.font = japaneseBold; radiantTouchCursorBonus_text.fontSize = 21f;
        energySurge_text.text = "エネルギーサージ"; energySurge_text.font = japaneseSemiBold; energySurge_text.fontSize = 35f;
        if (PlaceMobileButtons.isMobile == true) { energySurge_text.fontSize = 24f; }
        energySurge2_text.text = "エネルギーサージ"; energySurge2_text.font = japaneseSemiBold; energySurge2_text.fontSize = 24f;
        energySurgeCursorBonus_text.text = "カーソルボーナス：すべての宝物は+0.1％のドロップチャンスを得る"; energySurgeCursorBonus_text.font = japaneseBold; energySurgeCursorBonus_text.fontSize = 21f;
        phantomPalm_text.text = "ファントムパーム"; phantomPalm_text.font = japaneseSemiBold; phantomPalm_text.fontSize = 35f;
        if (PlaceMobileButtons.isMobile == true) { phantomPalm_text.fontSize = 25f; }
        phantomPalm2_text.text = "ファントムパーム"; phantomPalm2_text.font = japaneseSemiBold; phantomPalm2_text.fontSize = 24f;
        phantomPalmCursorBonus_text.text = "カーソルボーナス：すべてのクリティカルヒットは、宝をスポーンする7％のチャンスを持っています。各宝物は、3％が値の倍を行う持っています"; phantomPalmCursorBonus_text.font = japaneseBold; phantomPalmCursorBonus_text.fontSize = 17f;
        steelStrike_text.text = "スチールストライク"; steelStrike_text.font = japaneseSemiBold; steelStrike_text.fontSize = 30f;
        if (PlaceMobileButtons.isMobile == true) { steelStrike_text.fontSize = 22f; }
        steelStrike2_text.text = "スチールストライク"; steelStrike2_text.font = japaneseSemiBold; steelStrike2_text.fontSize = 20f;
        steelStrikeCursorBonus_text.text = "カーソルボーナス:+5%より多くの金.+5%より多くのXP"; steelStrikeCursorBonus_text.font = japaneseBold; steelStrikeCursorBonus_text.fontSize = 21f;
        lethalTouch_text.text = "致命的なタッチ"; lethalTouch_text.font = japaneseSemiBold; lethalTouch_text.fontSize = 35f;
        if (PlaceMobileButtons.isMobile == true) { lethalTouch_text.fontSize = 28f; }
        lethalTouch2_text.text = "致命的なタッチ"; lethalTouch2_text.font = japaneseSemiBold; lethalTouch2_text.fontSize = 24f;
        lethalTouchCursorBonus_text.text = "カーソルボーナス：チェストが開かれるたびに、6％のチャンスがありますダブルXPを与える"; lethalTouchCursorBonus_text.font = japaneseBold; lethalTouchCursorBonus_text.fontSize = 21f;
        precisionPoint_text.text = "精密ポイント"; precisionPoint_text.font = japaneseSemiBold; precisionPoint_text.fontSize = 35f;
        precisionPoint2_text.text = "精密ポイント"; precisionPoint2_text.font = japaneseSemiBold; precisionPoint2_text.fontSize = 24f;
        precisionPointCursorBonus_text.text = "カーソルボーナス：毎回宝物がドロップされた値で倍増する+7％のチャンスを持っています"; precisionPointCursorBonus_text.font = japaneseBold; precisionPointCursorBonus_text.fontSize = 21f;
        vortexTap_text.text = "渦タップ"; vortexTap_text.font = japaneseSemiBold; vortexTap_text.fontSize = 35f;
        vortexTap2_text.text = "渦タップ"; vortexTap2_text.font = japaneseSemiBold; vortexTap2_text.fontSize = 24f;
        vortexTapCursorBonus_text.text = "カーソルボーナス：開かれた25個の宝箱ごとに1個の宝を生成し、トリプルXPを与えます"; vortexTapCursorBonus_text.font = japaneseBold; vortexTapCursorBonus_text.fontSize = 21f;
        cursedClaw_text.text = "呪われた爪"; cursedClaw_text.font = japaneseSemiBold; cursedClaw_text.fontSize = 35f;
        cursedClaw2_text.text = "呪われた爪"; cursedClaw2_text.font = japaneseSemiBold; cursedClaw2_text.fontSize = 24f; //11
        cursedClawCursorBonus_text.text = "カーソルボーナス：クリティカルヒットが配られるたびに、金貨をスポーンする30％のチャンスと宝をスポーンする3％のチャンスがあります"; cursedClawCursorBonus_text.font = japaneseBold; cursedClawCursorBonus_text.fontSize = 17f;
        sniperClick_text.text = "スナイパークリック"; sniperClick_text.font = japaneseSemiBold; sniperClick_text.fontSize = 28f;
        if (PlaceMobileButtons.isMobile == true) { sniperClick_text.fontSize = 22f; }
        sniperClick2_text.text = "スナイパークリック"; sniperClick2_text.font = japaneseSemiBold; sniperClick2_text.fontSize = 19f; 
        sniperClickCursorBonus_text.text = "カーソルボーナス:10%より多くのゴールドと15%より多くのXP"; sniperClickCursorBonus_text.font = japaneseBold; sniperClickCursorBonus_text.fontSize = 21f;
        shadowSurge_text.text = "シャドウサージ"; shadowSurge_text.font = japaneseSemiBold; shadowSurge_text.fontSize = 35f;
        if (PlaceMobileButtons.isMobile == true) { shadowSurge_text.fontSize = 28f; }
        shadowSurge2_text.text = "シャドウサージ"; shadowSurge2_text.font = japaneseSemiBold; shadowSurge2_text.fontSize = 24f;
        shadowSurgeCursorBonus_text.text = "カーソルボーナス：すべてのクリティカルヒットは1金貨をスポーンします"; shadowSurgeCursorBonus_text.font = japaneseBold; shadowSurgeCursorBonus_text.fontSize = 21f;
        cripplingCrush_text.text = "クリップリングクラッシュ"; cripplingCrush_text.font = japaneseSemiBold; cripplingCrush_text.fontSize = 23f;
        if(PlaceMobileButtons.isMobile == true) { cripplingCrush_text.fontSize = 17f; }
        cripplingCrush2_text.text = "クリップリングクラッシュ"; cripplingCrush2_text.font = japaneseSemiBold; cripplingCrush2_text.fontSize = 15f;
        cripplingCrushCursorBonus_text.text = "カーソルボーナス：あなたが宝物を得るたびに、それは価値が倍増する25％のチャンスを持っています"; cripplingCrushCursorBonus_text.font = japaneseBold; cripplingCrushCursorBonus_text.fontSize = 21f;
        rapidClick_text.text = "クイッククリック"; rapidClick_text.font = japaneseSemiBold; rapidClick_text.fontSize = 30f;
        if (PlaceMobileButtons.isMobile == true) { rapidClick_text.fontSize = 25f; }
        rapidClick2_text.text = "クイッククリック"; rapidClick2_text.font = japaneseSemiBold; rapidClick2_text.fontSize = 24f;
        rapidClickCursorBonus_text.text = "カーソルボーナス：すべてのクリティカルヒットは、宝物をスポーンする13％のチャンスを持っています"; rapidClickCursorBonus_text.font = japaneseBold; rapidClickCursorBonus_text.fontSize = 21f;
        celestialTouch_text.text = "天のタッチ"; celestialTouch_text.font = japaneseSemiBold; celestialTouch_text.fontSize = 35f;
        celestialTouch2_text.text = "天のタッチ"; celestialTouch2_text.font = japaneseSemiBold; celestialTouch2_text.fontSize = 24f;
        celestialTouchCursorBonus_text.text = "カーソルボーナス：XPが2倍になります"; celestialTouchCursorBonus_text.font = japaneseBold; celestialTouchCursorBonus_text.fontSize = 21f;
        arcaneClick_text.text = "秘儀クリック"; arcaneClick_text.font = japaneseSemiBold; arcaneClick_text.fontSize = 35f;
        arcaneClick2_text.text = "秘儀クリック"; arcaneClick2_text.font = japaneseSemiBold; arcaneClick2_text.fontSize = 24f;
        arcaneClickCursorBonus_text.text = "カーソルボーナス：すべての宝の価値が2倍になります."; arcaneClickCursorBonus_text.font = japaneseBold; arcaneClickCursorBonus_text.fontSize = 21f;
        eternalTouch_text.text = "エターナルタッチ"; eternalTouch_text.font = japaneseSemiBold; eternalTouch_text.fontSize = 35f;
        if (PlaceMobileButtons.isMobile == true) { eternalTouch_text.fontSize = 25f; }
        eternalTouch2_text.text = "エターナルタッチ"; eternalTouch2_text.font = japaneseSemiBold; eternalTouch2_text.fontSize = 24f;
        eternalTouchCursorBonus_text.text = "カーソルボーナス：XPと宝物が2倍になります。すべてのクリックで金貨を得るために5％のチャンス"; eternalTouchCursorBonus_text.font = japaneseBold; eternalTouchCursorBonus_text.fontSize = 21f;
        doomTouch_text.text = "ドゥームタッチ"; doomTouch_text.font = japaneseSemiBold; doomTouch_text.fontSize = 35f;
        if (PlaceMobileButtons.isMobile == true) { doomTouch_text.fontSize = 28f; }
        doomTouch2_text.text = "ドゥームタッチ"; doomTouch2_text.font = japaneseSemiBold; doomTouch2_text.fontSize = 24f;
        doomTouchCursorBonus_text.text = "カーソルボーナス:まれな宝の滴のためのわずかに小さいチャンス."; doomTouchCursorBonus_text.font = japaneseBold; doomTouchCursorBonus_text.fontSize = 21f;
        solarSweep_text.text = "ソーラースイープ"; solarSweep_text.font = japaneseSemiBold; solarSweep_text.fontSize = 35f;
        if (PlaceMobileButtons.isMobile == true) { solarSweep_text.fontSize = 24f; }
        solarSweep2_text.text = "ソーラースイープ"; solarSweep2_text.font = japaneseSemiBold; solarSweep2_text.fontSize = 24f;
        solarSweepCursorBonus_text.text = "カーソルボーナス:+2.5%チェスト報酬を倍増するチャンス"; solarSweepCursorBonus_text.font = japaneseBold; solarSweepCursorBonus_text.fontSize = 21f;
        infernoFist_text.text = "インフェルノ-フィスト"; infernoFist_text.font = japaneseSemiBold; infernoFist_text.fontSize = 25f;
        if (PlaceMobileButtons.isMobile == true) { infernoFist_text.fontSize = 19f; }
        infernoFist2_text.text = "インフェルノ-フィスト"; infernoFist2_text.font = japaneseSemiBold; infernoFist2_text.fontSize = 18f;
        infernoFistCursorBonus_text.text = "カーソルボーナス：XPは2倍になります。すべての宝物は価値が2倍になります。4%ゴールドを倍増するチャンス."; infernoFistCursorBonus_text.font = japaneseBold; infernoFistCursorBonus_text.fontSize = 21f;
        locked_text.text = "ロックされた"; locked_text.font = japaneseSemiBold; locked_text.fontSize = 32f;
        unlockedAfterChest_text.text = "チェストを購入した後にロック解除されました"; unlockedAfterChest_text.font = japaneseBold; unlockedAfterChest_text.fontSize = 37f;

        #endregion

        #region Shop And Items
        for (int i = 0; i < 17; i++)
        {
            itemsLevelUp_text[i].text = "アップグレード"; itemsLevelUp_text[i].font = japaneseSemiBold; itemsLevelUp_text[i].fontSize = 22;
            if(PlaceMobileButtons.isMobile  == true) { itemsLevelUp_text[i].fontSize = 16; }
        }

        goldenTouchBuff.text = "<color=yellow>+6-10金貨ドロップ"; goldenTouchBuff.font = japaneseBoldOutline; goldenTouchBuff.fontSize = 10;
        treasurePotionBuff_text.text = "+3%トレジャードロップチャンス"; treasurePotionBuff_text.font = japaneseBoldOutline; treasurePotionBuff_text.fontSize = 10;


        shop_text.text = "ショップ"; shop_text.font = japaneseSemiBold; shop_text.fontSize = 90;
        shop2_text.text = "ショップ"; shop2_text.font = japaneseSemiBold; shop2_text.fontSize = 40;
        items_text.text = "アイテム"; items_text.font = japaneseSemiBold; items_text.fontSize = 50;
        lockpick_text.text = "ロックピック"; lockpick_text.font = japaneseSemiBold; lockpick_text.fontSize = 29;
        if (PlaceMobileButtons.isMobile == true) { lockpick_text.fontSize = 22; }
        lockpick2_text.text = "ロックピック"; lockpick2_text.font = japaneseSemiBold; lockpick2_text.fontSize = 25;
        lockpickItemBonus_text.text = "アイテムボーナス：ロックピックで胸を開いたときに宝が落ちる可能性はわずかに小さいです"; lockpickItemBonus_text.font = japaneseBold; lockpickItemBonus_text.fontSize = 21;

        hammer_text.text = "ハンマー"; hammer_text.font = japaneseSemiBold; hammer_text.fontSize = 26;
        hammer2_text.text = "ハンマー"; hammer2_text.font = japaneseSemiBold; hammer2_text.fontSize = 25;
        hammerItemBonus_text.text = "アイテムボーナス：ハンマーを使用している間にクリティカルヒットを取得した場合、1つの金貨は35％の確率で出現します"; hammerItemBonus_text.font = japaneseBold; hammerItemBonus_text.fontSize = 21;

        lootPotion_text.text = "戦利品ポーション"; lootPotion_text.font = japaneseSemiBold; lootPotion_text.fontSize = 25;
        if (PlaceMobileButtons.isMobile == true) { lootPotion_text.fontSize = 17; }
        lootPotion2_text.text = "戦利品ポーション"; lootPotion2_text.font = japaneseSemiBold; lootPotion2_text.fontSize = 22;
        lootPotionItemBonus_text.text = "アイテムボーナス：このポーションがアクティブである間に受け取った宝物は、値が倍増する+5％のチャンスを持っています"; lootPotionItemBonus_text.font = japaneseBold; lootPotionItemBonus_text.fontSize = 19;

        damagePotion_text.text = "ダメージポーション"; damagePotion_text.font = japaneseSemiBold; damagePotion_text.fontSize = 20;
        if (PlaceMobileButtons.isMobile == true) { damagePotion_text.fontSize = 15; }
        damagePotion2_text.text = "ダメージポーション"; damagePotion2_text.font = japaneseSemiBold; damagePotion2_text.fontSize = 19;
        damagePotionItemBonus_text.text = "アイテムボーナス:アクティブ中に+2%のクリティカルチャンスと+50%のクリティカルダメージを与える"; damagePotionItemBonus_text.font = japaneseBold; damagePotionItemBonus_text.fontSize = 19;

        xpPotion_text.text = "XPポーション"; xpPotion_text.font = japaneseSemiBold; xpPotion_text.fontSize = 25;
        if (PlaceMobileButtons.isMobile == true) { xpPotion_text.fontSize = 22; }
        xpPotion2_text.text = "XPポーション"; xpPotion2_text.font = japaneseSemiBold; xpPotion2_text.fontSize = 25;
        xpPotionItemBonus_text.text = "アイテムボーナス：XPが獲得されるたびに、0.1％のチャンスが+1スキルポイントを得ることができます"; xpPotionItemBonus_text.font = japaneseBold; xpPotionItemBonus_text.fontSize = 21;

        goldenTouch_text.text = "ゴールデンタッチ"; goldenTouch_text.font = japaneseSemiBold; goldenTouch_text.fontSize = 25;
        if (PlaceMobileButtons.isMobile == true) { goldenTouch_text.fontSize = 17; }
        goldenTouch2_text.text = "ゴールデンタッチ"; goldenTouch2_text.font = japaneseSemiBold; goldenTouch2_text.fontSize = 21;
        goldenTouchItemBonus_text.text = "アイテムボーナス：ゴールデンタッチがアクティブである間、宝物は値が倍増する+10％のチャンスを持っています"; goldenTouchItemBonus_text.font = japaneseBold; goldenTouchItemBonus_text.fontSize = 21;

        miniChest_text.text = "ミニチェスト"; miniChest_text.font = japaneseSemiBold; miniChest_text.fontSize = 25;
        if (PlaceMobileButtons.isMobile == true) { miniChest_text.fontSize = 20; }
        miniChest2_text.text = "ミニチェスト"; miniChest2_text.font = japaneseSemiBold; miniChest2_text.fontSize = 29;
        miniChestUpgradeBonus_text.text = "アップグレードボーナス：ミニチェストは3つの可能な報酬のうちの1つを与えます"; miniChestUpgradeBonus_text.font = japaneseBold; miniChestUpgradeBonus_text.fontSize = 21;
        miniChestMaxHover_text.text = "最大レベル"; miniChestMaxHover_text.font = japaneseBold; miniChestMaxHover_text.fontSize = 10;

        key_text.text = "キー"; key_text.font = japaneseSemiBold; key_text.fontSize = 26;
        key2_text.text = "キー"; key2_text.font = japaneseSemiBold; key2_text.fontSize = 25;
        keyInstantlOpens_text.text = "すぐに胸を開きます."; keyInstantlOpens_text.font = japaneseBold; keyInstantlOpens_text.fontSize = 23;
        keyItemBonus_text.text = "アイテムボーナス：チェストは、キーが使用されたときに2-4余分な金貨をドロップします"; keyItemBonus_text.font = japaneseBold; keyItemBonus_text.fontSize = 21;

        treasureBag_text.text = "宝袋"; treasureBag_text.font = japaneseSemiBold; treasureBag_text.fontSize = 25;
        treasureBag2_text.text = "宝袋"; treasureBag2_text.font = japaneseSemiBold; treasureBag2_text.fontSize = 25;
        treasureBagDrop_text.text = "宝の袋は2つの宝物を落とします"; treasureBagDrop_text.font = japaneseBold; treasureBagDrop_text.fontSize = 17;
        treasureBagItemBonus_text.text = "アイテムボーナス：任意の胸からの宝物をドロップすることができます。宝の袋はまた、あなたに5XPドロップを与えます"; treasureBagItemBonus_text.font = japaneseBold; treasureBagItemBonus_text.fontSize = 21;

        serendipityScroll_text.text = "セレンディピティスクロール"; serendipityScroll_text.font = japaneseSemiBold; serendipityScroll_text.fontSize = 15;
        if (PlaceMobileButtons.isMobile == true) { serendipityScroll_text.fontSize = 11; }
        serendipityScroll2_text.text = "セレンディピティスクロール"; serendipityScroll2_text.font = japaneseSemiBold; serendipityScroll2_text.fontSize = 14;
        serendipityScrollStatsReset_text.text = "セレンディピティスクロールからの統計はプレステージでリセットされます"; serendipityScrollStatsReset_text.font = japaneseBold; serendipityScrollStatsReset_text.fontSize = 21;

        gauntletOfGreed_text.text = "欲のガントレット"; gauntletOfGreed_text.font = japaneseSemiBold; gauntletOfGreed_text.fontSize = 25;
        if (PlaceMobileButtons.isMobile == true) { gauntletOfGreed_text.fontSize = 17; }
        gauntletOfGreed2_text.text = "欲のガントレット"; gauntletOfGreed2_text.font = japaneseSemiBold; gauntletOfGreed2_text.fontSize = 20;
        gauntletOfGreenBonus_text.text = "アイテムボーナス：3％のチャンスは、すべてのクリックで宝物をスポーンする"; gauntletOfGreenBonus_text.font = japaneseBold; gauntletOfGreenBonus_text.fontSize = 21;

        magicalElixir_text.text = "魔法のエリクサー"; magicalElixir_text.font = japaneseSemiBold; magicalElixir_text.fontSize = 25;
        if (PlaceMobileButtons.isMobile == true) { magicalElixir_text.fontSize = 17; }
        magicalElixir2_text.text = "魔法のエリクサー"; magicalElixir2_text.font = japaneseSemiBold; magicalElixir2_text.fontSize = 24;
        magicalElixirItemBonus_text.text = "アイテムボーナス：エリクサーがアクティブである間、すべての宝物に+0.3％ドロップチャンス"; magicalElixirItemBonus_text.font = japaneseBold; magicalElixirItemBonus_text.fontSize = 21;

        ancientRelic_text.text = "古代遺物"; ancientRelic_text.font = japaneseSemiBold; ancientRelic_text.fontSize = 25;
      
        ancientRelic2_text.text = "古代遺物"; ancientRelic2_text.font = japaneseSemiBold; ancientRelic2_text.fontSize = 22;
        ancientRelicGivesBuff_text.text = "ランダムな統計に永続的なバフを与えます"; ancientRelicGivesBuff_text.font = japaneseBold; ancientRelicGivesBuff_text.fontSize = 22;
        ancientRelicKeepBuff_text.text = "あなたは威信の後に古代の遺物によって得られたすべてのバフを維持します"; ancientRelicKeepBuff_text.font = japaneseBold; ancientRelicKeepBuff_text.fontSize = 21;

        enchantedHammer_text.text = "エンチャントされたハンマー"; enchantedHammer_text.font = japaneseSemiBold; enchantedHammer_text.fontSize = 15;
        if (PlaceMobileButtons.isMobile == true) { enchantedHammer_text.fontSize = 10.5f; }
        enchantedHammer2_text.text = "エンチャントされたハンマー"; enchantedHammer2_text.font = japaneseSemiBold; enchantedHammer2_text.fontSize = 13;
        enchantedHammerItemBonus_text.text = "アイテムボーナス：胸の報酬を3倍にする2％のチャンス"; enchantedHammerItemBonus_text.font = japaneseBold; enchantedHammerItemBonus_text.fontSize = 21;

        treasurePotion_text.text = "トレジャーポーション"; treasurePotion_text.font = japaneseSemiBold; treasurePotion_text.fontSize = 20;
        if (PlaceMobileButtons.isMobile == true) { treasurePotion_text.fontSize = 14; }
        treasurePotion2_text.text = "トレジャーポーション"; treasurePotion2_text.font = japaneseSemiBold; treasurePotion2_text.fontSize = 17;
        treasurePotionItemBonus_text.text = "アイテムボーナス：ドロップされたアイテムは、値を倍増する+25％のチャンスを得る"; treasurePotionItemBonus_text.font = japaneseBold; treasurePotionItemBonus_text.fontSize = 21;

        barrelOfGold_text.text = "金の樽"; barrelOfGold_text.font = japaneseSemiBold; barrelOfGold_text.fontSize = 26;
        barrelOfGold2_text.text = "金の樽"; barrelOfGold2_text.font = japaneseSemiBold; barrelOfGold2_text.fontSize = 20;
        barrelOfGoldBonus_text.text = "アイテムボーナス：それをドラッグしてバレルを配置する場所を選択します"; barrelOfGoldBonus_text.font = japaneseBold; barrelOfGoldBonus_text.fontSize = 21;
        barrelSpawns_text.text = "バレルをスポーンします。"; barrelSpawns_text.font = japaneseBold; barrelSpawns_text.fontSize = 24;
        barrelGoldCoinsInside_text.text = "バレルは合計を集めました："; barrelGoldCoinsInside_text.font = japaneseBoldOutline; barrelGoldCoinsInside_text.fontSize = 10;
        clickToCollect_text.text = "収集するためにクリック！"; clickToCollect_text.font = japaneseBoldOutline; clickToCollect_text.fontSize = 12;

        mimicChest_text.text = "胸を模倣する"; mimicChest_text.font = japaneseSemiBold; mimicChest_text.fontSize = 26;
        if (PlaceMobileButtons.isMobile == true) { mimicChest_text.fontSize = 20; }
        mimicChest2_text.text = "胸を模倣する"; mimicChest2_text.font = japaneseSemiBold; mimicChest2_text.fontSize = 20;
        mimicChestItemBonus_text.text = "アイテムボーナス：正のバフは倍の長さを持続する15％のチャンスを持っています"; mimicChestItemBonus_text.font = japaneseBold; mimicChestItemBonus_text.fontSize = 21;
        turnedOff_text.text = "オフになっています"; turnedOff_text.font = japaneseSemiBold; turnedOff_text.fontSize = 18;

        purchaseAnItem_text.text = "あなたの金を費やしてアイテムを購入します。"; purchaseAnItem_text.font = japaneseRegular; purchaseAnItem_text.fontSize = 21.5f;
        useItems_text.text = "左の\"アイテム\"タブであなたのアイテムを使用してください。"; useItems_text.font = japaneseRegular; useItems_text.fontSize = 21.5f;
        itemsGetExpensive_text.text = "各項目は、あなたがいずれかを購入するたびに、より高価になります。"; itemsGetExpensive_text.font = japaneseRegular; itemsGetExpensive_text.fontSize = 21.5f;
        levelUpItems_text.text = "あなたの宝物を費やすことによって、あなたのアイテムをレベルアップ。"; levelUpItems_text.font = japaneseRegular; levelUpItems_text.fontSize = 17f;
        broke_text.text = "壊れた！"; broke_text.font = japaneseSemiBold; broke_text.fontSize = 36f;

        rareTreasureBuff_text.text = "<color=orange>本当に小さな珍しい宝のドロップチャンス"; rareTreasureBuff_text.font = japaneseBoldOutline; rareTreasureBuff_text.fontSize = 9;

        #endregion

        #region Treasures
        treasureBar_text.text = "宝物"; treasureBar_text.font = japaneseSemiBold; treasureBar_text.fontSize = 48;

        for (int i = 0; i < 5; i++)
        {
            commonText_text[i].text = "共通"; commonText_text[i].font = japaneseBold; commonText_text[i].fontSize = 14;
            rareText_text[i].text = "レア"; rareText_text[i].font = japaneseBold; rareText_text[i].fontSize = 15;
            veryRare_text[i].text = "非常にまれな"; veryRare_text[i].font = japaneseBold; veryRare_text[i].fontSize = 12;
        }

        for (int i = 0; i < 4; i++)
        {
            unCommonText_text[i].text = "珍しい"; unCommonText_text[i].font = japaneseBold; unCommonText_text[i].fontSize = 14;
        }

        for (int i = 0; i < 3; i++)
        {
            extremelyRare_text[i].text = "非常にまれな"; extremelyRare_text[i].font = japaneseBold; extremelyRare_text[i].fontSize = 10;
            legendary_text[i].text = "伝説"; legendary_text[i].font = japaneseBold; legendary_text[i].fontSize = 12;
            ultra_text[i].text = "ウルトラ"; ultra_text[i].font = japaneseBold; ultra_text[i].fontSize = 14;
            mythic_text[i].text = "ミシック(曖昧さ回避"; mythic_text[i].font = japaneseBold; mythic_text[i].fontSize = 8;
            eternal_text[i].text = "エターナル"; eternal_text[i].font = japaneseBold; eternal_text[i].fontSize = 13;
        }


        quartz_text.text = "クォーツ"; quartz_text.font = japaneseSemiBold; quartz_text.fontSize = 28;
        amethyst_text.text = "アメジスト"; amethyst_text.font = japaneseSemiBold; amethyst_text.fontSize = 28;
        yellowTopaz_text.text = "イエロートパーズ"; yellowTopaz_text.font = japaneseSemiBold; yellowTopaz_text.fontSize = 22;
        albite_text.text = "アルビテ"; albite_text.font = japaneseSemiBold; albite_text.fontSize = 27;
        redGarnet_text.text = "レッドガーネット"; redGarnet_text.font = japaneseSemiBold; redGarnet_text.fontSize = 21;
        aquamarine_text.text = "アクアマリン"; aquamarine_text.font = japaneseSemiBold; aquamarine_text.fontSize = 27;
        yellowSapphire_text.text = "イエローサファイア"; yellowSapphire_text.font = japaneseSemiBold; yellowSapphire_text.fontSize = 18;
        pinkTourmaline_text.text = "ピンクトルマリン"; pinkTourmaline_text.font = japaneseSemiBold; pinkTourmaline_text.fontSize = 22;
        aventurine_text.text = "アベンチュリン"; aventurine_text.font = japaneseSemiBold; aventurine_text.fontSize = 22;
        redRuby_text.text = "赤いルビー"; redRuby_text.font = japaneseSemiBold; redRuby_text.fontSize = 26;
        diamond_text.text = "ダイヤモンド"; diamond_text.font = japaneseSemiBold; diamond_text.fontSize = 27;
        grandidierite_text.text = "グランディエライト"; grandidierite_text.font = japaneseSemiBold; grandidierite_text.fontSize = 19;
        violetCrystal_text.text = "紫水晶"; violetCrystal_text.font = japaneseSemiBold; violetCrystal_text.fontSize = 25;
        akoyaPearl_text.text = "アコヤ真珠"; akoyaPearl_text.font = japaneseSemiBold; akoyaPearl_text.fontSize = 25;
        purpleRupee_text.text = "パープルルピー"; purpleRupee_text.font = japaneseSemiBold; purpleRupee_text.fontSize = 26;
        emerald_text.text = "エメラルド"; emerald_text.font = japaneseSemiBold; emerald_text.fontSize = 28;
        greenDiamond_text.text = "グリーンダイヤモンド"; greenDiamond_text.font = japaneseSemiBold; greenDiamond_text.fontSize = 17;
        fireOpal_text.text = "ファイアオパール"; fireOpal_text.font = japaneseSemiBold; fireOpal_text.fontSize = 21;
        gemSilica_text.text = "ジェムシリカ"; gemSilica_text.font = japaneseSemiBold; gemSilica_text.fontSize = 26;
        pinkPlort_text.text = "ピンクのプロート"; pinkPlort_text.font = japaneseSemiBold; pinkPlort_text.fontSize = 26;
        goldenSeaPearl_text.text = "黄金の海の真珠"; goldenSeaPearl_text.font = japaneseSemiBold; goldenSeaPearl_text.fontSize = 21;
        kyanite_text.text = "カヤナイト"; kyanite_text.font = japaneseSemiBold; kyanite_text.fontSize = 27;
        blackOpal_text.text = "ブラックオパール"; blackOpal_text.font = japaneseSemiBold; blackOpal_text.fontSize = 22;
        painite_text.text = "パイナイト"; painite_text.font = japaneseSemiBold; painite_text.fontSize = 28;
        tanzanite_text.text = "タンザナイト"; tanzanite_text.font = japaneseSemiBold; tanzanite_text.fontSize = 27;
        astralium_text.text = "アストラリウム"; astralium_text.font = japaneseSemiBold; astralium_text.fontSize = 27;
        elysiumPrism_text.text = "エリジウムプリズム"; elysiumPrism_text.font = japaneseSemiBold; elysiumPrism_text.fontSize = 19;
        aerthfireOpal_text.text = "アースファイアオパール"; aerthfireOpal_text.font = japaneseSemiBold; aerthfireOpal_text.fontSize = 16;
        eldrichStarstone_text.text = "エルドリッチ-スターストーン"; eldrichStarstone_text.font = japaneseSemiBold; eldrichStarstone_text.fontSize = 14;
        chronolithShard_text.text = "クロノリスシャード"; chronolithShard_text.font = japaneseSemiBold; chronolithShard_text.fontSize = 20;
        sideriumEssence_text.text = "シデリウムエッセンス"; sideriumEssence_text.font = japaneseSemiBold; sideriumEssence_text.fontSize = 18;
        quadarite_text.text = "クワダライト"; quadarite_text.font = japaneseSemiBold; quadarite_text.fontSize = 22;
        radiantNovaStone_text.text = "ラディアントノヴァストーン"; radiantNovaStone_text.font = japaneseSemiBold; radiantNovaStone_text.fontSize = 13;
        soluniumShard_text.text = "ソルニウムシャード"; soluniumShard_text.font = japaneseSemiBold; soluniumShard_text.fontSize = 21;

        sell_text.text = "売る"; sell_text.font = japaneseBoldOutline; sell_text.fontSize = 25;
        sellAll_text.text = "すべてを売る"; sellAll_text.font = japaneseBoldOutline; sellAll_text.fontSize = 17;
        #endregion

        #region Rare Treasures
        coolStuff_text.text = "クールなもの"; coolStuff_text.font = japaneseBold; coolStuff_text.fontSize = 19;
        rareTreasuresTop2_text.text = "珍しい宝物"; rareTreasuresTop2_text.font = japaneseBold; rareTreasuresTop2_text.fontSize = 23;
        page1_text.text = "1ページ目"; page1_text.font = japaneseBold; page1_text.fontSize = 12;
        page2_text.text = "2ページ目"; page2_text.font = japaneseBold; page2_text.fontSize = 12;
        pirateSkull2_text.text = "海賊スカル"; pirateSkull2_text.font = japaneseBold; pirateSkull2_text.fontSize = 20;
        demonicSword2_text.text = "魔剣"; demonicSword2_text.font = japaneseBold; demonicSword2_text.fontSize = 17;
        mysticRing2_text.text = "ミスティックリング"; mysticRing2_text.font = japaneseBold; mysticRing2_text.fontSize = 17;
        trophy2_text.text = "トロフィー"; trophy2_text.font = japaneseBold; trophy2_text.fontSize = 20;
        fallenStar2_text.text = "堕ちた星"; fallenStar2_text.font = japaneseBold; fallenStar2_text.fontSize = 20;
        clover2_text.text = "クローバー"; clover2_text.font = japaneseBold; clover2_text.fontSize = 20;
        kingsCrown2_text.text = "キングスクラウン"; kingsCrown2_text.font = japaneseBold; kingsCrown2_text.fontSize = 19;
        spellBook2_text.text = "スペルブック"; spellBook2_text.font = japaneseBold; spellBook2_text.fontSize = 19;
        guitar2_text.text = "ギター"; guitar2_text.font = japaneseBold; guitar2_text.fontSize = 19;
        talarian2_text.text = "タラリア人"; talarian2_text.font = japaneseBold; talarian2_text.fontSize = 19;
        mythrune2_text.text = "ミスルーン"; mythrune2_text.font = japaneseBold; mythrune2_text.fontSize = 19;
        explorerBackpack2_text.text = "エクスプローラーバックパック"; explorerBackpack2_text.font = japaneseBold; explorerBackpack2_text.fontSize = 9;
        vikingShield2_text.text = "バイキングシールド"; vikingShield2_text.font = japaneseBold; vikingShield2_text.fontSize = 17;
        pillBottle2_text.text = "ピルボトル"; pillBottle2_text.font = japaneseBold; pillBottle2_text.fontSize = 17;
        victoryMedal2_text.text = "ビクトリーメダル"; victoryMedal2_text.font = japaneseBold; victoryMedal2_text.fontSize = 17;
        cookie2_text.text = "クッキー"; cookie2_text.font = japaneseBold; cookie2_text.fontSize = 17;
        christmasPresent2_text.text = "クリスマスプレゼント"; christmasPresent2_text.font = japaneseBold; christmasPresent2_text.fontSize = 13;
        battleAxe2_text.text = "バトルアックス"; battleAxe2_text.font = japaneseBold; battleAxe2_text.fontSize = 19;
        goldCoin100X2_text.text = "100Xゴールドコイン"; goldCoin100X2_text.font = japaneseBold; goldCoin100X2_text.fontSize = 16;
        sealedEnvelope2_text.text = "密封された封筒"; sealedEnvelope2_text.font = japaneseBold; sealedEnvelope2_text.fontSize = 16;
        strangePotion2_text.text = "奇妙なポーション"; strangePotion2_text.font = japaneseBold; strangePotion2_text.fontSize = 15;
        soulGem2_text.text = "ソウルジェム"; soulGem2_text.font = japaneseBold; soulGem2_text.fontSize = 17;
        ancientScroll2_text.text = "古代の巻物"; ancientScroll2_text.font = japaneseBold; ancientScroll2_text.fontSize = 17;
        brick2_text.text = "レンガ"; brick2_text.font = japaneseBold; brick2_text.fontSize = 17;
        rubberChicken2_text.text = "ゴムチキン"; rubberChicken2_text.font = japaneseBold; rubberChicken2_text.fontSize = 17;

        skullFoundReward_text.text = "海賊の頭蓋骨を見つけるための報酬:"; skullFoundReward_text.font = japaneseLight; skullFoundReward_text.fontSize = 6.8f;
        swordFoundReward_text.text = "悪魔の剣を見つけるための報酬:"; swordFoundReward_text.font = japaneseLight; swordFoundReward_text.fontSize = 6.8f;
        ringFoundReward_text.text = "ミスティックリングを見つけるための報酬:"; ringFoundReward_text.font = japaneseLight; ringFoundReward_text.fontSize = 6.8f;
        trophyFoundReward_text.text = "トロフィーを見つけるための報酬:"; trophyFoundReward_text.font = japaneseLight; trophyFoundReward_text.fontSize = 6.8f;
        fallenStarFoundReward_text.text = "落ちた星を見つけるための報酬:"; fallenStarFoundReward_text.font = japaneseLight; fallenStarFoundReward_text.fontSize = 6.8f;
        cloverFoundReward_text.text = "クローバーを見つけるための報酬:"; cloverFoundReward_text.font = japaneseLight; cloverFoundReward_text.fontSize = 6.7f;
        kingsCrownFoundReward_text.text = "王の王冠を見つけるための報酬:"; kingsCrownFoundReward_text.font = japaneseLight; kingsCrownFoundReward_text.fontSize = 6.7f;
        spellBookFoundReward_text.text = "呪文の本を見つけるための報酬:"; spellBookFoundReward_text.font = japaneseLight; spellBookFoundReward_text.fontSize = 6.7f;
        guitarFoundReward_text.text = "ギターを見つけるための報酬:"; guitarFoundReward_text.font = japaneseLight; guitarFoundReward_text.fontSize = 6.7f;
        talarianFoundReward_text.text = "タラリアを見つけるための報酬:"; talarianFoundReward_text.font = japaneseLight; talarianFoundReward_text.fontSize = 6.7f;
        mythruneFoundReward_text.text = "ミスルーンを見つけるための報酬:"; mythruneFoundReward_text.font = japaneseLight; mythruneFoundReward_text.fontSize = 6.7f;
        backPackFoundReward_text.text = "エクスプローラのバックパックを見つけるための報酬:"; backPackFoundReward_text.font = japaneseLight; backPackFoundReward_text.fontSize = 6.5f;
        shieldFoundReward_text.text = "バイキングの盾を見つけるための報酬:"; shieldFoundReward_text.font = japaneseLight; shieldFoundReward_text.fontSize = 6.5f;
        pillBottleFoundReward_text.text = "薬瓶を見つけるための報酬:"; pillBottleFoundReward_text.font = japaneseLight; pillBottleFoundReward_text.fontSize = 6.5f;
        medalFoundReward_text.text = "勝利メダルを見つけるための報酬:"; medalFoundReward_text.font = japaneseLight; medalFoundReward_text.fontSize = 6.5f;
        cookieFoundReward_text.text = "クッキーを見つけるための報酬:"; cookieFoundReward_text.font = japaneseLight; cookieFoundReward_text.fontSize = 6.5f;
        presentFoundReward_text.text = "クリスマスプレゼントを見つけるための報酬:"; presentFoundReward_text.font = japaneseLight; presentFoundReward_text.fontSize = 6.8f;
        axeFoundReward_text.text = "バトルアックスを見つけるための報酬:"; axeFoundReward_text.font = japaneseLight; axeFoundReward_text.fontSize = 6.8f;
        envelopeFoundReward_text.text = "封印された封筒を見つけるための報酬:"; envelopeFoundReward_text.font = japaneseLight; envelopeFoundReward_text.fontSize = 6.8f;
        coin100XFoundReward_text.text = "100X金貨を見つけるための報酬:"; coin100XFoundReward_text.font = japaneseLight; coin100XFoundReward_text.fontSize = 6.8f;
        potionFoundReward_text.text = "ポーションを見つけるための報酬:"; potionFoundReward_text.font = japaneseLight; potionFoundReward_text.fontSize = 6.8f;
        soulGemFoundReward_text.text = "ソウルジェムを見つけるための報酬:"; soulGemFoundReward_text.font = japaneseLight; soulGemFoundReward_text.fontSize = 6.8f;
        sscrollFoundReward_text.text = "古代の巻物を見つけるための報酬:"; sscrollFoundReward_text.font = japaneseLight; sscrollFoundReward_text.fontSize = 6.8f;
        brickFoundReward_text.text = "レンガを見つけるための報酬:"; brickFoundReward_text.font = japaneseLight; brickFoundReward_text.fontSize = 6.8f;
        chickenFoundReward_text.text = "ゴム鶏を見つけるための報酬:"; chickenFoundReward_text.font = japaneseLight; chickenFoundReward_text.fontSize = 6.8f;

        allSkullRewards_text.text = "パッシブダメージ3%"; allSkullRewards_text.font = japaneseMediumOutline; allSkullRewards_text.fontSize = 11f;
        allDemonicSwordRewards_text.text = "+5%アクティブダメージ. +0.3%クリティカルチャンス"; allDemonicSwordRewards_text.font = japaneseMediumOutline; allDemonicSwordRewards_text.fontSize = 7f;
        allMysticRingRewards_text.text = "+0.05%トレジャードロップチャンス"; allMysticRingRewards_text.font = japaneseMediumOutline; allMysticRingRewards_text.fontSize = 9f;
        allTrophyRewards_text.text = "+0.05%トレジャードロップチャンス"; allTrophyRewards_text.font = japaneseMediumOutline; allTrophyRewards_text.fontSize = 9f;
        allFallenStarRewards_text.text = "宝の価値が2倍になる可能性が4％"; allFallenStarRewards_text.font = japaneseMediumOutline; allFallenStarRewards_text.fontSize = 7.5f;
        allCloverRewards_text.text = "2%5Xゴールドコインのための.1%のために10Xゴールドコイン"; allCloverRewards_text.font = japaneseMediumOutline; allCloverRewards_text.fontSize = 6f;
        allKingsCrownRewards_text.text = "カーソルをレベルアップすると、カーソルが強くなります"; allKingsCrownRewards_text.font = japaneseMediumOutline; allKingsCrownRewards_text.fontSize = 7f;
        allSpellBookRewards_text.text = "特別なアップグレードをレベルアップすると、それらが強くなります"; allSpellBookRewards_text.font = japaneseMediumOutline; allSpellBookRewards_text.fontSize = 5.5f;
        allGuitarRewards_text.text = "+20%の活動的で、受動の損傷"; allGuitarRewards_text.font = japaneseMediumOutline; allGuitarRewards_text.fontSize = 7.5f;
        allTalarianRewards_text.text = "パッシブダメージ30%"; allTalarianRewards_text.font = japaneseMediumOutline; allTalarianRewards_text.fontSize = 7.5f;
        allMythruneRewards_text.text = "+15%ゴールド"; allMythruneRewards_text.font = japaneseMediumOutline; allMythruneRewards_text.fontSize = 7.5f;
        allExplorerBackpackRewards_text.text = "+15%経験値, +15%ゴールド, +0.1%トレジャードロップチャンス"; allExplorerBackpackRewards_text.font = japaneseMediumOutline; allExplorerBackpackRewards_text.fontSize = 6f;
        allVikingShieldRewards_text.text = "宝の価値が2倍になる可能性が7％"; allVikingShieldRewards_text.font = japaneseMediumOutline; allVikingShieldRewards_text.fontSize = 7.1f;
        allPillBottleRewards_text.text = "ポーションスタック+1回"; allPillBottleRewards_text.font = japaneseMediumOutline; allPillBottleRewards_text.fontSize = 7.1f;
        allVictoryMedalRewards_text.text = "各クリックで金貨をスポーンする+1％のチャンスと宝物をスポーンする+0.2％のチャンス"; allVictoryMedalRewards_text.font = japaneseMediumOutline; allVictoryMedalRewards_text.fontSize = 6.8f;
        foundCookieRewards_text.text = "+50%ゴールド. +50経験値. +0.2%トレジャードロップチャンス. +5% 宝の価値が2倍になる可能性が. +75%の活動的で、受動の損傷. +3%クリティカルチャンス. +150%クリティカルダメージ"; foundCookieRewards_text.font = japaneseMediumOutline; foundCookieRewards_text.fontSize = 6.6f;
        foundChristmasPresentRewards_text.text = "古代の遺物はより強いバフを与えます"; foundChristmasPresentRewards_text.font = japaneseMediumOutline; foundChristmasPresentRewards_text.fontSize = 9f;
        foundBattleAxeRewards_text.text = "クリックするたびに+0.1％のチャンスがあり、すぐに胸を開くことができます. すぐに胸を開くと、胸の報酬が2倍になります"; foundBattleAxeRewards_text.font = japaneseMediumOutline; foundBattleAxeRewards_text.fontSize = 6f;
        foundEnvelopeRewards.text = "強化された胸のチャンス+0.2％"; foundEnvelopeRewards.font = japaneseMediumOutline; foundEnvelopeRewards.fontSize = 8f;
        foundGoldCoin100XRewards_text.text = "0.05%100X金貨をドロップするチャンス"; foundGoldCoin100XRewards_text.font = japaneseMediumOutline; foundGoldCoin100XRewards_text.fontSize = 8f;
        foundPotionRewards_text.text = "アップグレードすると、すべてのポーションがはるかに強くなります"; foundPotionRewards_text.font = japaneseMediumOutline; foundPotionRewards_text.fontSize = 5f;
        foundSoulGemRewards_text.text = "ソウルジェムはドロップし続けます。魂の宝石をクリックすると、ランダムな統計に永久的なバフを得ることができます. ソウルジェムドロップチャンス0.2%"; foundSoulGemRewards_text.font = japaneseMediumOutline; foundSoulGemRewards_text.fontSize = 6f;
        foundAncientScrollRewards_text.text = "セレンディピティスクロールはより強いバフを与えます"; foundAncientScrollRewards_text.font = japaneseMediumOutline; foundAncientScrollRewards_text.fontSize = 7f;
        foundBrickRewards_text.text = "まあそれはただのレンガです。..だから..何でもない.."; foundBrickRewards_text.font = japaneseMediumOutline; foundBrickRewards_text.fontSize = 7f;
        foundRubberChickenRewards_text.text = "あなたが選んだ統計に大規模なバフを与えます。."; foundRubberChickenRewards_text.font = japaneseMediumOutline; foundRubberChickenRewards_text.fontSize = 7f;


        pirateSkullDescription_text.text = "\"嵐の海と莫大な戦いを通して、この頭蓋骨は冷酷な海賊の遺産を抱いています\""; pirateSkullDescription_text.font = japaneseLight; pirateSkullDescription_text.fontSize = 7f;

        demonicSwordDescription_text.text = "\"不浄な起源の武器であるこの悪魔の剣は、天罰の本質を体現しています\""; demonicSwordDescription_text.font = japaneseLight; demonicSwordDescription_text.fontSize = 7f;

        mysticRingDescription_text.text = "\"神秘的なリングはあなたの幸運を高め、宝物をより頻繁に落とす\""; mysticRingDescription_text.font = japaneseLight; mysticRingDescription_text.fontSize = 7f;

        trophyDescription_text.text = "\"陰謀は残っています。偉大さの証であるトロフィーを胸の中に保管するのはなぜですか？\""; trophyDescription_text.font = japaneseLight; trophyDescription_text.fontSize = 7f;

        fallenStarDescription_text.text = "\"これらの胸には珍しい宝物があります。落ちた星、不思議の宇宙の遺物。\""; fallenStarDescription_text.font = japaneseLight; fallenStarDescription_text.fontSize = 7f;

        cloverDescription_text.text = "\"幸運をもたらす魅力-胸の中に囲まれた四つ葉のクローバーを発見してください。\""; cloverDescription_text.font = japaneseLight; cloverDescription_text.fontSize = 7f;

        kingsCrownDescription_text.text = "\"王国の遺産の重さを運ぶ王冠である雄大なアーティファクトを明らかにしてください。\""; kingsCrownDescription_text.font = japaneseLight; kingsCrownDescription_text.fontSize = 7.6f;

        spellBookDescription_text.text = "\"呪文の本の隠された知識を明らかにし、魔法の芸術であなたに力を与えます。\""; spellBookDescription_text.font = japaneseLight; spellBookDescription_text.fontSize = 7.6f;

        guitarDescription_text.text = "\"なぜこのギターは胸の中に隠されていたのですか？その弦は深く個人的なつながりのエコーを運びます。\""; guitarDescription_text.font = japaneseLight; guitarDescription_text.fontSize = 6.9f;

        talarianDescription_text.text = "\"宝箱の中には、迅速さと自由の象徴である伝説のタラリアがあります。\""; talarianDescription_text.font = japaneseLight; talarianDescription_text.fontSize = 6.9f;

        strangeRuneDescription_text.text = "\"ミスルーンのエッセンスを発掘し、古代の魔法のエコーに触れてください。\""; strangeRuneDescription_text.font = japaneseLight; strangeRuneDescription_text.fontSize = 6.7f;

        explorerBackpackDescription_text.text = "\"エクスプローラのバックパックを開き、大胆な冒険のためのツールの山を明らかにします。\""; explorerBackpackDescription_text.font = japaneseLight; explorerBackpackDescription_text.fontSize = 6.7f;

        vikingShieldDescription_text.text = "\"バイキングの盾の中には、戦いを恐れなかった勇敢な戦士の遺産があります。\""; vikingShieldDescription_text.font = japaneseLight; vikingShieldDescription_text.fontSize = 7f;

        pillBottleDescription_text.text = "\"富の中で、控えめなピルボトルが隠れており、その目的は興味深いほど不明瞭です。\""; pillBottleDescription_text.font = japaneseLight; pillBottleDescription_text.fontSize = 7f;

        victoryMedalDescription_text.text = "\"勝利のメダル、勝利の栄光と揺るぎない決意の象徴を受け入れます。\""; victoryMedalDescription_text.font = japaneseLight; victoryMedalDescription_text.fontSize = 6.5f;

        cookieDescription_text.text = "クリックしてください"; cookieDescription_text.font = japaneseLight; cookieDescription_text.fontSize = 7f;

        christmasPresentDescription_text.text = "\"私たちはその中に何があるのか決して知りません\""; christmasPresentDescription_text.font = japaneseLight; christmasPresentDescription_text.fontSize = 7f;

        battleAxeDescription_text.text = "\"専門家の職人技で鍛造されたこの戦いの斧は、冷酷な効率であなたの敵を切断する準備ができて、致命的なエッジで輝きます。\""; battleAxeDescription_text.font = japaneseLight; battleAxeDescription_text.fontSize = 6f;

        goldCoin100XDescription_text.text = "\"世界に残っているこれらのコインの多くはありません」\""; goldCoin100XDescription_text.font = japaneseLight; goldCoin100XDescription_text.fontSize = 7f;

        sealedEnvelopeDescription_text.text = "\"歴史上の人物によって書かれた可能性が最も高い\""; sealedEnvelopeDescription_text.font = japaneseLight; sealedEnvelopeDescription_text.fontSize = 7f;

        strangePotionDescription_text.text = "\"この神秘的なポーションは謎めいた色で渦巻いており、それを消費するのに十分な大胆さを持つ人々にリスクと報酬の両方を約束しています。\""; strangePotionDescription_text.font = japaneseLight; strangePotionDescription_text.fontSize = 6f;

        soulGemDescription_text.text = "\"この輝く宝石は、あなたのキャラクターの強さと能力を強化することを約束し、宇宙の力でパルスします。\""; soulGemDescription_text.font = japaneseLight; soulGemDescription_text.fontSize = 6f;

        ancientScrollDescription_text.text = "\"古くからの知恵と洞察に満ちた古代の巻物。\""; ancientScrollDescription_text.font = japaneseLight; ancientScrollDescription_text.fontSize = 7f;

        brickDescription_text.text = "\"うん...それはただのレンガです」\""; brickDescription_text.font = japaneseLight; brickDescription_text.fontSize = 7f;

        rubberChickenDescription_text.text = "\"このゴム鶏は冗談だと思うかもしれませんが、その中には強力な力があります\""; rubberChickenDescription_text.font = japaneseLight; rubberChickenDescription_text.fontSize = 7f;

        skullDropChance_text.text = "0,0278%<color=white>ドロップチャンス"; skullDropChance_text.font = japaneseLight; skullDropChance_text.fontSize = 10f;
        democSwordDropChance_text.text = "0,0119%<color=white>ドロップチャンス"; democSwordDropChance_text.font = japaneseLight; democSwordDropChance_text.fontSize = 10f;
        mysticRingDropChance_text.text = "0,0051%<color=white>ドロップチャンス"; mysticRingDropChance_text.font = japaneseLight; mysticRingDropChance_text.fontSize = 10f;
        trophyDropChance_text.text = "0,0050%<color=white>ドロップチャンス"; trophyDropChance_text.font = japaneseLight; trophyDropChance_text.fontSize = 10f;
        fallenStarDropChance_text.text = "0,0008%<color=white>ドロップチャンス"; fallenStarDropChance_text.font = japaneseLight; fallenStarDropChance_text.fontSize = 10f;
        cloverDropChance_text.text = "0,0005%<color=white>ドロップチャンス"; cloverDropChance_text.font = japaneseLight; cloverDropChance_text.fontSize = 10f;
        kingsCrownDropChance_text.text = "0,0006%<color=white>ドロップチャンス"; kingsCrownDropChance_text.font = japaneseLight; kingsCrownDropChance_text.fontSize = 10f;
        spellBookDropChance_text.text = "0,0006%<color=white>ドロップチャンス"; spellBookDropChance_text.font = japaneseLight; spellBookDropChance_text.fontSize = 10f;
        guitarDropChance_text.text = "0,0009%<color=white>ドロップチャンス"; guitarDropChance_text.font = japaneseLight; guitarDropChance_text.fontSize = 10f;
        talarianDropChance_text.text = "0,00077%<color=white>ドロップチャンス"; talarianDropChance_text.font = japaneseLight; talarianDropChance_text.fontSize = 10f;
        mythRuneDropChance_text.text = "0,0016%<color=white>ドロップチャンス"; mythRuneDropChance_text.font = japaneseLight; mythRuneDropChance_text.fontSize = 10f;
        backPackDropChance_text.text = "0,00052%<color=white>ドロップチャンス"; backPackDropChance_text.font = japaneseLight; backPackDropChance_text.fontSize = 10f;
        vikingShieldDropChance_text.text = "0,00063%<color=white>ドロップチャンス"; vikingShieldDropChance_text.font = japaneseLight; vikingShieldDropChance_text.fontSize = 10f;
        pillBottleDropChance_text.text = "0,00050%<color=white>ドロップチャンス"; pillBottleDropChance_text.font = japaneseLight; pillBottleDropChance_text.fontSize = 10f;
        victoryMedalDropChance_text.text = "0,00042%<color=white>ドロップチャンス"; victoryMedalDropChance_text.font = japaneseLight; victoryMedalDropChance_text.fontSize = 10f;
        cookieDropChance_text.text = "0,00034%<color=white>ドロップチャンス"; cookieDropChance_text.font = japaneseLight; cookieDropChance_text.fontSize = 10f;
        presentDropChance_text.text = "0,00038%<color=white>ドロップチャンス"; presentDropChance_text.font = japaneseLight; presentDropChance_text.fontSize = 10f;
        battleAxeDropChance_text.text = "0,00032%<color=white>ドロップチャンス"; battleAxeDropChance_text.font = japaneseLight; battleAxeDropChance_text.fontSize = 10f;
        coin100XDropChance_text.text = "0,00030%<color=white>ドロップチャンス"; coin100XDropChance_text.font = japaneseLight; coin100XDropChance_text.fontSize = 10f;
        envelopeDropChance_text.text = "0,00036%<color=white>ドロップチャンス"; envelopeDropChance_text.font = japaneseLight; envelopeDropChance_text.fontSize = 10f;
        strangePotionDropChance_text.text = "0,00030%<color=white>ドロップチャンス"; strangePotionDropChance_text.font = japaneseLight; strangePotionDropChance_text.fontSize = 10f;
        soulGemDropChance_text.text = "0,00034%<color=white>ドロップチャンス"; soulGemDropChance_text.font = japaneseLight; soulGemDropChance_text.fontSize = 10f;
        ancientScrollDropChance_text.text = "0,00029%<color=white>ドロップチャンス"; ancientScrollDropChance_text.font = japaneseLight; ancientScrollDropChance_text.fontSize = 10f;
        brickDropChance_text.text = "0,00026%<color=white>ドロップチャンス"; brickDropChance_text.font = japaneseLight; brickDropChance_text.fontSize = 10f;
        chickenDropChance_text.text = "0,00025%<color=white>ドロップチャンス"; chickenDropChance_text.font = japaneseLight; chickenDropChance_text.fontSize = 10f;

        congratsMessage_text.text = "おめでとう！あなたはすべての25の珍しい宝物を持っています！"; congratsMessage_text.font = japaneseSemiBold; congratsMessage_text.fontSize = 17f;
        purchaseRareTreasure_text.text = "ロックを解除するには、すべてのプレステージ アップグレードを購入してください."; purchaseRareTreasure_text.font = japaneseSemiBold; purchaseRareTreasure_text.fontSize = 17f;
        purchase1MissingTreasure_text.text = "不足している珍しい宝物を1つ購入しますか？"; purchase1MissingTreasure_text.font = japaneseSemiBold; purchase1MissingTreasure_text.fontSize = 12f;

        chooseChickenBuff_text.text = "鶏からバフを選択してください:"; chooseChickenBuff_text.font = japaneseBoldOutline; chooseChickenBuff_text.fontSize = 36f;
        coose1_text.text = "選ぶ:"; coose1_text.font = japaneseBoldOutline; coose1_text.fontSize = 23f;
        coose2_text.text = "選ぶ:"; coose2_text.font = japaneseBoldOutline; coose2_text.fontSize = 23f;
        coose3_text.text = "選ぶ:"; coose3_text.font = japaneseBoldOutline; coose3_text.fontSize = 23f;
        coose4_text.text = "選ぶ:"; coose4_text.font = japaneseBoldOutline; coose4_text.fontSize = 23f;
        coose5_text.text = "選ぶ:"; coose5_text.font = japaneseBoldOutline; coose5_text.fontSize = 23f;
        coose6_text.text = "選ぶ:"; coose6_text.font = japaneseBoldOutline; coose6_text.fontSize = 23f;
        coose7_text.text = "選ぶ:"; coose7_text.font = japaneseBoldOutline; coose7_text.fontSize = 23f;
        #endregion

        #region Treasure Chests
        chestPurchase_text.text = "購入"; chestPurchase_text.font = japaneseBold; chestPurchase_text.fontSize = 36;
        autoPurchase_text.text = "手頃な価格のときに自動的に次の胸を購入します:"; autoPurchase_text.font = japaneseLight; autoPurchase_text.fontSize = 11;
        chestTREASURESDROP_text.text = "宝の滴:"; chestTREASURESDROP_text.font = japaneseSemiBold; chestTREASURESDROP_text.fontSize = 18;
        reinforcedPopUp_text.text = "強化チェスト"; reinforcedPopUp_text.font = japaneseMedium; reinforcedPopUp_text.fontSize = 36;
        enchantedGoldenChestPopUp_text.text = "エンチャントされた黄金の宝箱"; enchantedGoldenChestPopUp_text.font = japaneseMedium; enchantedGoldenChestPopUp_text.fontSize = 32;
        bossChest_text.text = "ボスチェスト"; bossChest_text.font = japaneseMedium; bossChest_text.fontSize = 50;
        reinforcedHover_text.text = "強化チェスト"; reinforcedHover_text.font = japaneseMedium; reinforcedHover_text.fontSize = 25;

        enchantedGoldenHover_text.text = "エンチャントされた黄金の宝箱"; enchantedGoldenHover_text.font = japaneseMedium; enchantedGoldenHover_text.fontSize = 24;
        enchantedGoldenHoverLockPickKeys_text.text = ""; enchantedGoldenHoverLockPickKeys_text.font = japaneseRegular; enchantedGoldenHoverLockPickKeys_text.fontSize = 17;

        bossChestHover_text.text = "ボスチェスト"; bossChestHover_text.font = japaneseMedium; bossChestHover_text.fontSize = 38;
        bossChestHoverLockPickKeys_text.text = ""; bossChestHoverLockPickKeys_text.font = japaneseRegular; bossChestHoverLockPickKeys_text.fontSize = 16;


        #endregion

        #region prestige

        wouldYouLiketoGoBack_text.text = "あなたは戻って、いくつかのより多くの胸を開きたいですか？";
        wouldYouLiketoGoBack_text.font = japaneseMedium; wouldYouLiketoGoBack_text.fontSize = 37;

        butFirst_text.text = "しかし、最初に。..";
        butFirst_text.font = japaneseMedium; butFirst_text.fontSize = 13;

        purchaseTheGoodieBag_text.text = "グッディバッグを通販で購入する(通信販売で予約する)";
        purchaseTheGoodieBag_text.font = japaneseMediumOutline; purchaseTheGoodieBag_text.fontSize = 22;

        goBackYES_text.text = "はい"; goBackYES_text.font = japaneseSemiBold; goBackYES_text.fontSize = 60;

        goBackNO_text.text = "いいえ"; goBackNO_text.font = japaneseSemiBold; goBackNO_text.fontSize = 60;

        itesmChosen_text.text = "選ばれたアイテム！"; itesmChosen_text.font = japaneseMediumOutline; itesmChosen_text.fontSize = 26;

        chooseSomethingElse_text.text = "何か他のものを選んでください"; chooseSomethingElse_text.font = japaneseBoldOutline; chooseSomethingElse_text.fontSize = 20;

        prestigeExit_text.text = "出口"; prestigeExit_text.font = japaneseBold; prestigeExit_text.fontSize = 47;

        for (int i = 0; i < lockedPrestige_text.Length; i++)
        {
            lockedPrestige_text[i].text = "ロックされた"; lockedPrestige_text[i].font = japaneseMediumOutline; lockedPrestige_text[i].fontSize = 8.6f;
            unlockedPrestige_text[i].text = "ロック解除"; unlockedPrestige_text[i].font = japaneseMediumOutline; unlockedPrestige_text[i].fontSize = 8.6f;
        }

        findThePrestigeKeyAncChest_text.lineSpacing = -50;
        openPrestigeScreen_text.lineSpacing = -95;

        loseText_text.lineSpacing = -40;
        keepText_text.lineSpacing = -20;

        // For individual variables
        prestigeTop_text.text = "プレステージ"; prestigeTop_text.font = japaneseBold; prestigeTop_text.fontSize = 50;
        prestigeButton_text.text = "プレステージ"; prestigeButton_text.font = japaneseBold; prestigeButton_text.fontSize = 28;
        openPrestigeScreen_text.text = "プレステージ画面を開く"; openPrestigeScreen_text.font = japaneseBold; openPrestigeScreen_text.fontSize = 18;
        skillPoints_text.text = "スキルポイント"; skillPoints_text.font = japaneseBold; skillPoints_text.fontSize = 20;

        wouldYouLikeToPrestige_text.text = "あなたは威信をしたいですか？"; wouldYouLikeToPrestige_text.font = japaneseBoldOutline; wouldYouLikeToPrestige_text.fontSize = 19;
        youWillKeep_text.text = "あなたは維持します"; youWillKeep_text.font = japaneseBoldOutline; youWillKeep_text.fontSize = 34;
        keepText_text.text = "-プレステージアップグレード\n-珍しい宝物\n-実績"; keepText_text.font = japaneseBoldOutline; keepText_text.fontSize = 28;
        youWillLose_text.text = "あなたは失うことになります"; youWillLose_text.font = japaneseBoldOutline; youWillLose_text.fontSize = 23;
        loseText_text.text = "-すべての金\n-宝物\n-レベル\n-アイテム\n-アイテムレベル\n-カーソル\n-カーソルレベル\n-スクロール統計"; loseText_text.font = japaneseBoldOutline; loseText_text.fontSize = 37;
        prestigeWillTakeYou_text.text = "プレステージでは、恒久的なアップグレードを購入することができますスキルツリーに行くことができます"; prestigeWillTakeYou_text.font = japaneseBoldOutline; prestigeWillTakeYou_text.fontSize = 14.4f;
        prestigeYES_text.text = "はい"; prestigeYES_text.font = japaneseBoldOutline; prestigeYES_text.fontSize = 25;
        prestigeNO_text.text = "いいえ"; prestigeNO_text.font = japaneseBoldOutline; prestigeNO_text.fontSize = 25;
        prestigeAndSkillPoints_text.text = "プレステージ＆スキルポイント"; prestigeAndSkillPoints_text.font = japaneseBoldOutline; prestigeAndSkillPoints_text.fontSize = 58;
        prestigeExplinations_text.text = "プレステージキーとプレステージチェストは、新しいチェストのロックが解除された後、+0.017％のドロップチャンスを取得します"; prestigeExplinations_text.font = japaneseRegular; prestigeExplinations_text.fontSize = 27;
        prestigeExplinations2_text.text = "あなたはすべてのレベルアップでスキルポイントを受け取ります。各5番目のレベルは、受け取った合計スキルポイントに+1スキルポイントを与えます。各レベルを獲得したスキルポイント=（現在のレベル/5）+1"; prestigeExplinations2_text.font = japaneseRegular; prestigeExplinations2_text.fontSize = 27;
        currentlyViewingPrestige_text.text = "現在はプレステージ画面のみを表示しています。"; currentlyViewingPrestige_text.font = japaneseMediumOutline; currentlyViewingPrestige_text.fontSize = 38;
        skillPointsTextInsode_text.text = "スキルポイント"; skillPointsTextInsode_text.font = japaneseSemiBold; skillPointsTextInsode_text.fontSize = 36;

        clickerUnder_text.text = "クリッカー"; clickerUnder_text.font = japaneseSemiBold; clickerUnder_text.fontSize = 44;
        loungerUnder_text.text = "ラウンジャー"; loungerUnder_text.font = japaneseSemiBold; loungerUnder_text.fontSize = 44;
        pirateUnder_text.text = "海賊"; pirateUnder_text.font = japaneseSemiBold; pirateUnder_text.fontSize = 44;
        hoarderUnder_text.text = "ホーダー"; hoarderUnder_text.font = japaneseSemiBold; hoarderUnder_text.fontSize = 44;
        adventurerUnder_text.text = "アドベンチャー"; adventurerUnder_text.font = japaneseSemiBold; adventurerUnder_text.fontSize = 44;

        bossChestPresitgeName_text.text = "ボスチェスト"; bossChestPresitgeName_text.font = japaneseBold; bossChestPresitgeName_text.fontSize = 26;
        reinforcedItems_text.text = "強化アイテム"; reinforcedItems_text.font = japaneseBold; reinforcedItems_text.fontSize = 22;
        potionStacker_text.text = "ポーションスタッカー"; potionStacker_text.font = japaneseBold; potionStacker_text.fontSize = 17;
        fortifiedItems_text.text = "強化アイテム"; fortifiedItems_text.font = japaneseBold; fortifiedItems_text.fontSize = 26;
        enhancedItems_text.text = "強化アイテム"; enhancedItems_text.font = japaneseBold; enhancedItems_text.fontSize = 23;
        enchantedItems_text.text = "エンチャントされたアイテム"; enchantedItems_text.font = japaneseBold; enchantedItems_text.fontSize = 13;
        itemMastery_text.text = "アイテムマスタリー"; itemMastery_text.font = japaneseBold; itemMastery_text.fontSize = 18;
        enchantmentQuill_text.text = "エンチャントクイル"; enchantmentQuill_text.font = japaneseBold; enchantmentQuill_text.fontSize = 19;
        wizard_text.text = "ウィザード"; wizard_text.font = japaneseBold; wizard_text.fontSize = 26;
        student_text.text = "学生"; student_text.font = japaneseBold; student_text.fontSize = 26;
        potionChug_text.text = "ポーションチャグ"; potionChug_text.font = japaneseBold; potionChug_text.fontSize = 21;
        transcendence_text.text = "超絶"; transcendence_text.font = japaneseBold; transcendence_text.fontSize = 23;
        elevation_text.text = "標高"; elevation_text.font = japaneseBold; elevation_text.fontSize = 26;
        xpAccelerator_text.text = "XPアクセラレータ"; xpAccelerator_text.font = japaneseBold; xpAccelerator_text.fontSize = 21;
        proficiency_text.text = "習熟度"; proficiency_text.font = japaneseBold; proficiency_text.fontSize = 26;
        levelMastery_text.text = "レベルの習得"; levelMastery_text.font = japaneseBold; levelMastery_text.fontSize = 26;
        advancement_text.text = "アドバンス"; advancement_text.font = japaneseBold; advancement_text.fontSize = 26;
        xpBoost_text.text = "XPブースト"; xpBoost_text.font = japaneseBold; xpBoost_text.fontSize = 26;
        masterPirate_text.text = "マスター海賊"; masterPirate_text.font = japaneseBold; masterPirate_text.fontSize = 26;
        fortuneSeeker_text.text = "フォーチュンシーカー"; fortuneSeeker_text.font = japaneseBold; fortuneSeeker_text.fontSize = 18;
        pirate_text.text = "海賊"; pirate_text.font = japaneseBold; pirate_text.fontSize = 26;
        rapidLeveling_text.text = "急速な水平になること"; rapidLeveling_text.font = japaneseBold; rapidLeveling_text.fontSize = 17;
        treasureAmplifier_text.text = "トレジャーアンプ"; treasureAmplifier_text.font = japaneseBold; treasureAmplifier_text.fontSize = 22;
        stackingSplendor_text.text = "スタッキングの素晴らしさ"; stackingSplendor_text.font = japaneseBold; stackingSplendor_text.fontSize = 14;
        goodieBag_text.text = "グッディバッグ"; goodieBag_text.font = japaneseBold; goodieBag_text.fontSize = 26;
        reinforcedRiches_text.text = "強化された富"; reinforcedRiches_text.font = japaneseBold; reinforcedRiches_text.fontSize = 20;
        chestBlessing_text.text = "胸の祝福"; chestBlessing_text.font = japaneseBold; chestBlessing_text.fontSize = 25;
        chestSurge_text.text = "胸のサージ"; chestSurge_text.font = japaneseBold; chestSurge_text.fontSize = 26;
        fortifiedFortune_text.text = "フォーティファイド-フォーチュン"; fortifiedFortune_text.font = japaneseBold; fortifiedFortune_text.fontSize = 12;
        enchantedGoldenChest_text.text = "魅惑の黄金の胸"; enchantedGoldenChest_text.font = japaneseBold; enchantedGoldenChest_text.fontSize = 17;
        piratesParadise_text.text = "海賊の楽園"; piratesParadise_text.font = japaneseBold; piratesParadise_text.fontSize = 23;
        luxuriousLooting_text.text = "豪華な略奪"; luxuriousLooting_text.font = japaneseBold; luxuriousLooting_text.fontSize = 21;
        lootBonanza_text.text = "戦利品ボナンザ"; lootBonanza_text.font = japaneseBold; lootBonanza_text.fontSize = 26;
        chestEnrichment_text.text = "胸の豊かさ"; chestEnrichment_text.font = japaneseBold; chestEnrichment_text.fontSize = 21;
        greaterLoot_text.text = "より大きな戦利品"; greaterLoot_text.font = japaneseBold; greaterLoot_text.fontSize = 23;
        treasuryReinforcement_text.text = "財務強化"; treasuryReinforcement_text.font = japaneseBold; treasuryReinforcement_text.fontSize = 16;
        strongbox_text.text = "ストロングボックス"; strongbox_text.font = japaneseBold; strongbox_text.fontSize = 18;
        fortified_text.text = "要塞化された "; fortified_text.font = japaneseBold; fortified_text.fontSize = 26;
        gildedFortification_text.text = "金色の要塞"; gildedFortification_text.font = japaneseBold; gildedFortification_text.fontSize = 21;
        reinforcedPlus_text.text = "強化+"; reinforcedPlus_text.font = japaneseBold; reinforcedPlus_text.fontSize = 26;
        wellPrepared_text.text = "よく準備された"; wellPrepared_text.font = japaneseBold; wellPrepared_text.fontSize = 26;
        stashedItems_text.text = "隠しアイテム"; stashedItems_text.font = japaneseBold; stashedItems_text.fontSize = 26;
        travelBag_text.text = "トラベルバッグ"; travelBag_text.font = japaneseBold; travelBag_text.fontSize = 26;
        buffsGalore_text.text = "バフ豊富"; buffsGalore_text.font = japaneseBold; buffsGalore_text.fontSize = 24;
        lootEnhancer_text.text = "戦利品エンハンサー"; lootEnhancer_text.font = japaneseBold; lootEnhancer_text.fontSize = 19;
        treasureHunter_text.text = "トレジャーハンター"; treasureHunter_text.font = japaneseBold; treasureHunter_text.fontSize = 20;
        collector_text.text = "コレクター"; collector_text.font = japaneseBold; collector_text.fontSize = 26;
        autoClicker1_text.text = "オートクリッカー"; autoClicker1_text.font = japaneseBold; autoClicker1_text.fontSize = 21;
        autoClicker2_text.text = "オートクリッカー+"; autoClicker2_text.font = japaneseBold; autoClicker2_text.fontSize = 21;
        autoClicker3_text.text = "オートクリッカー++"; autoClicker3_text.font = japaneseBold; autoClicker3_text.fontSize = 21;
        autoClicker4_text.text = "ラピッドクリッカー"; autoClicker4_text.font = japaneseBold; autoClicker4_text.fontSize = 19;
        cursorEnchantment_text.text = "カーソルエンチャント"; cursorEnchantment_text.font = japaneseBold; cursorEnchantment_text.fontSize = 18;
        advancedCursors_text.text = "高度なカーソル"; advancedCursors_text.font = japaneseBold; advancedCursors_text.fontSize = 22;
        cursorEvolution_text.text = "カーソルの進化"; cursorEvolution_text.font = japaneseBold; cursorEvolution_text.fontSize = 24;
        cursorEnhanced_text.text = "カーソル強化"; cursorEnhanced_text.font = japaneseBold; cursorEnhanced_text.fontSize = 23;
        crushingForce_text.text = "力を押しつぶすこと"; crushingForce_text.font = japaneseBold; crushingForce_text.fontSize = 19;
        swiftblade_text.text = "スウィフトブレード"; swiftblade_text.font = japaneseBold; swiftblade_text.fontSize = 19;
        fury_text.text = "フューリー"; fury_text.font = japaneseBold; fury_text.fontSize = 26;
        clickstorm_text.text = "クリックストーム"; clickstorm_text.font = japaneseBold; clickstorm_text.fontSize = 21;
        tapPrecision_text.text = "タップ精度"; tapPrecision_text.font = japaneseBold; tapPrecision_text.fontSize = 26;
        clickersFury_text.text = "クリッカーズ-フューリー"; clickersFury_text.font = japaneseBold; clickersFury_text.fontSize = 17;
        tapMastery_text.text = "タップマスタリー"; tapMastery_text.font = japaneseBold; tapMastery_text.fontSize = 23;
        cripplingStrikes_text.text = "壊滅的なストライキ"; cripplingStrikes_text.font = japaneseBold; cripplingStrikes_text.fontSize = 19;
        savageCrits_text.text = "サベージクリッツ"; savageCrits_text.font = japaneseBold; savageCrits_text.fontSize = 22;
        lethalPrecision_text.text = "致命的な精度"; lethalPrecision_text.font = japaneseBold; lethalPrecision_text.fontSize = 24;
        ruthlessStrikes_text.text = "無慈悲なストライキ"; ruthlessStrikes_text.font = japaneseBold; ruthlessStrikes_text.fontSize = 20;
        hardenedFist_text.text = "硬くなった拳"; hardenedFist_text.font = japaneseBold; hardenedFist_text.fontSize = 26;
        idler_text.text = "アイドラー"; idler_text.font = japaneseBold; idler_text.fontSize = 26;
        lazyRewards_text.text = "怠け者の報酬"; lazyRewards_text.font = japaneseBold; lazyRewards_text.fontSize = 26;
        unfathomableWealth_text.text = "計り知れない富"; unfathomableWealth_text.font = japaneseBold; unfathomableWealth_text.fontSize = 15;
        ancientCoin_text.text = "古代コイン"; ancientCoin_text.font = japaneseBold; ancientCoin_text.fontSize = 26;
        fortuneCoin_text.text = "フォーチュンコイン"; fortuneCoin_text.font = japaneseBold; fortuneCoin_text.fontSize = 19;
        wealthEmpire_text.text = "富の帝国"; wealthEmpire_text.font = japaneseBold; wealthEmpire_text.fontSize = 26;
        luckyPenny_text.text = "ラッキーペニ"; luckyPenny_text.font = japaneseBold; luckyPenny_text.fontSize = 26;
        fortune_text.text = "フォーチュン"; fortune_text.font = japaneseBold; fortune_text.fontSize = 26;
        extremelyWealthy_text.text = "非常に裕福な"; extremelyWealthy_text.font = japaneseBold; extremelyWealthy_text.fontSize = 21;
        wealthy_text.text = "裕福な"; wealthy_text.font = japaneseBold; wealthy_text.fontSize = 26;
        idlersMastery_text.text = "アイドラーズマスタリー"; idlersMastery_text.font = japaneseBold; idlersMastery_text.fontSize = 16;
        wealth_text.text = "富"; wealth_text.font = japaneseBold; wealth_text.fontSize = 26;
        potentCursors_text.text = "強力なカーソル"; potentCursors_text.font = japaneseBold; potentCursors_text.fontSize = 26;
        mightyCursors_text.text = "マイティカーソル"; mightyCursors_text.font = japaneseBold; mightyCursors_text.fontSize = 23;
        reforgedCursors_text.text = "リフォージされたカーソル"; reforgedCursors_text.font = japaneseBold; reforgedCursors_text.fontSize = 15;
        sloppyFist_text.text = "雑にな拳"; sloppyFist_text.font = japaneseBold; sloppyFist_text.fontSize = 26;
        effortless_text.text = "楽な"; effortless_text.font = japaneseBold; effortless_text.fontSize = 26;
        loungingKing_text.text = "ラウンディングキング"; loungingKing_text.font = japaneseBold; loungingKing_text.fontSize = 17;
        loungingPirate_text.text = "ラウンジパイレーツ"; loungingPirate_text.font = japaneseBold; loungingPirate_text.fontSize = 19;
        loungingOgre_text.text = "鬼の寝息"; loungingOgre_text.font = japaneseBold; loungingOgre_text.fontSize = 26;
        restfulIdler_text.text = "安らかなアイドラー"; restfulIdler_text.font = japaneseBold; restfulIdler_text.fontSize = 19;
        cursorMastery_text.text = "カーソルマスタリー"; cursorMastery_text.font = japaneseBold; cursorMastery_text.fontSize = 19;

        critDes1_text.text = ""; critDes1_text.font = japaneseMedium; critDes1_text.fontSize = 15;

        // Crit Descriptions
        critDes1_text.text = "+0.5%クリティカルチャンス";
        critDes1_2_text.text = "+150%クリティカルダメージ";
        critDes2_text.text = "+1.5%クリティカルチャンス";
        critDes2_2_text.text = "+750%クリティカルダメージ";
        critDes3_text.text = ">+1.8%クリティカルチャンス";
        critDes3_2_text.text = "+1500%クリティカルダメージ";
        critDes4_text.text = "+2.2%クリティカルチャンス";
        critDes4_2_text.text = "クリティカルヒットで金貨をスポーンする10％のチャンス";
        critDes5_text.text = "+2500%クリティカルダメージ";
        critDes5_2_text.text = "クリティカルヒットで宝を出現させる確率4%";

        critDes1_text.font = japaneseMedium;
        critDes1_2_text.font = japaneseMedium;
        critDes2_text.font = japaneseMedium;
        critDes2_2_text.font = japaneseMedium;
        critDes3_text.font = japaneseMedium;
        critDes3_2_text.font = japaneseMedium;
        critDes4_text.font = japaneseMedium;
        critDes4_2_text.font = japaneseMedium;
        critDes5_text.font = japaneseMedium;
        critDes5_2_text.font = japaneseMedium;

        critDes1_text.fontSize = 15;
        critDes1_2_text.fontSize = 15;
        critDes2_text.fontSize = 15;
        critDes2_2_text.fontSize = 15;
        critDes3_text.fontSize = 15;
        critDes3_2_text.fontSize = 15;
        critDes4_text.fontSize = 15;
        critDes4_2_text.fontSize = 15;
        critDes5_text.fontSize = 15;
        critDes5_2_text.fontSize = 15;

        // Active Descriptions
        activeDes1_text.text = "+50%の活動的な損傷";
        activeDes2_text.text = "+325%の活動的な損傷";
        activeDes3_text.text = "+1000%の活動的な損傷";
        activeDes4_text.text = "+2250%の活動的な損傷";
        activeDes4_2_text.text = "クリックするたびに金貨を生成する1％のチャンス";
        activeDes5_text.text = "+3500%の活動的な損傷";
        activeDes5_2_text.text = "クリックごとに宝を生成するチャンス0.1%";
        activeDes6_text.text = "+10000%の活動的な損傷";
        activeDes6_2_text.text = "クリックするたびに+0.4％のチャンスがあり、すぐに胸を開くことができます";
        activeDes7_text.text = "+15000%の活動的な損傷";
        activeDes7_2_text.text = "クリックするたびに1％のチャンスがあり、5倍の金貨をスポーンします";

        activeDes1_text.font = japaneseMedium;
        activeDes2_text.font = japaneseMedium;
        activeDes3_text.font = japaneseMedium;
        activeDes4_text.font = japaneseMedium;
        activeDes4_2_text.font = japaneseMedium;
        activeDes5_text.font = japaneseMedium;
        activeDes5_2_text.font = japaneseMedium;
        activeDes6_text.font = japaneseMedium;
        activeDes6_2_text.font = japaneseMedium;
        activeDes7_text.font = japaneseMedium;
        activeDes7_2_text.font = japaneseMedium;

        activeDes1_text.fontSize = 15;
        activeDes2_text.fontSize = 15;
        activeDes3_text.fontSize = 15;
        activeDes4_text.fontSize = 15;
        activeDes4_2_text.fontSize = 15;
        activeDes5_text.fontSize = 15;
        activeDes5_2_text.fontSize = 15;
        activeDes6_text.fontSize = 15;
        activeDes6_2_text.fontSize = 15;
        activeDes7_text.fontSize = 15;
        activeDes7_2_text.fontSize = 14.9f;

        // Active Cursor Descriptions
        activeCursorDes1_text.text = "アクティブダメージ、クリティカルチャンス、クリティカルダメージでカーソルをレベルアップすると、";
        activeCursorDes2_text.text = "アクティブダメージ、クリティカルチャンス、クリティカルダメージでカーソルをレベルアップすると、";
        activeCursorDes3_text.text = "すべてのアクティブダメージ、クリティカルチャンス、クリティカルダメージカーソルはより強くなります";
        activeCursorDes4_text.text = "すべてのアクティブダメージ、クリティカルチャンス、クリティカルダメージカーソルはより強くなります";
        activeCursorDes4_2_text.text = "アクティブダメージ、クリティカルチャンス、クリティカルダメージでカーソルをレベルアップすると、";

        activeCursorDes1_text.font = japaneseMedium;
        activeCursorDes2_text.font = japaneseMedium;
        activeCursorDes3_text.font = japaneseMedium;
        activeCursorDes4_text.font = japaneseMedium;
        activeCursorDes4_2_text.font = japaneseMedium;

        activeCursorDes1_text.fontSize = 14;
        activeCursorDes2_text.fontSize = 14;
        activeCursorDes3_text.fontSize = 12;
        activeCursorDes4_text.fontSize = 13;
        activeCursorDes4_2_text.fontSize = 11f;

        // Auto Clicker Descriptions
        autoClickerDes1_text.text = "自動クリッカーは1秒あたり1クリックを実行します";
        autoClickerDes1_2_text.text = "各クリックは、あなたの総アクティブダメージの100％を得ます";
        autoClickerDes2_text.text = "自動クリッカーは1秒あたり2クリックを実行します";
        autoClickerDes3_text.text = "自動クリッカーは1秒あたり4クリックを実行します";
        autoClickerDes4_text.text = "自動クリッカーは1秒あたり8クリックを実行します";

        autoClickerDes1_text.font = japaneseMedium;
        autoClickerDes1_2_text.font = japaneseMedium;
        autoClickerDes2_text.font = japaneseMedium;
        autoClickerDes3_text.font = japaneseMedium;
        autoClickerDes4_text.font = japaneseMedium;

        autoClickerDes1_text.fontSize = 12;
        autoClickerDes1_2_text.fontSize = 12;
        autoClickerDes2_text.fontSize = 12;
        autoClickerDes3_text.fontSize = 12;
        autoClickerDes4_text.fontSize = 12;

        // Passive Descriptions
        passiveDes1_text.text = "+25%パッシブダメージ";
        passiveDes2_text.text = "+115%パッシブダメージ";
        passiveDes3_text.text = "+400%パッシブダメージ";
        passiveDes3_2_text.text = "開いた7つの胸ごとに1つの金貨をスポーンします";
        passiveDes4_text.text = "+850%パッシブダメージ";
        passiveDes4_2_text.text = "開いた25個の宝箱ごとに1個の宝をスポーンする";
        passiveDes5_text.text = "+1100%パッシブダメージ";
        passiveDes6_text.text = "+1600%パッシブダメージ";
        passiveDes6_2_text.text = "開いた25個の宝箱ごとに1個の宝と4個の金貨をスポーンする";
        passiveDes7_text.text = "+3500%パッシブダメージ";
        passiveDes7_2_text.text = "すべての胸は1余分な金貨をドロップします";
        passiveDes8_text.text = "+6500%パッシブダメージ";

        passiveDes1_text.font = japaneseMedium;
        passiveDes2_text.font = japaneseMedium;
        passiveDes3_text.font = japaneseMedium;
        passiveDes3_2_text.font = japaneseMedium;
        passiveDes4_text.font = japaneseMedium;
        passiveDes4_2_text.font = japaneseMedium;
        passiveDes5_text.font = japaneseMedium;
        passiveDes6_text.font = japaneseMedium;
        passiveDes6_2_text.font = japaneseMedium;
        passiveDes7_text.font = japaneseMedium;
        passiveDes7_2_text.font = japaneseMedium;
        passiveDes8_text.font = japaneseMedium;

        passiveDes1_text.fontSize = 15;
        passiveDes2_text.fontSize = 15;
        passiveDes3_text.fontSize = 15;
        passiveDes3_2_text.fontSize = 15;
        passiveDes4_text.fontSize = 15;
        passiveDes4_2_text.fontSize = 15;
        passiveDes5_text.fontSize = 15;
        passiveDes6_text.fontSize = 15;
        passiveDes6_2_text.fontSize = 15;
        passiveDes7_text.fontSize = 15;
        passiveDes7_2_text.fontSize = 15;
        passiveDes8_text.fontSize = 15;

        // Passive Cursor Descriptions
        passiveCursorDes1_text.text = "パッシブダメージでカーソルをレベルアップすると、カーソルが強くなります";
        passiveCursorDes2_text.text = "パッシブダメージでカーソルをレベルアップすると、カーソルが強くなります";
        passiveCursorDes3_text.text = "パッシブダメージカーソルが強くなり始めます";
        passiveCursorDes4_text.text = "パッシブダメージカーソルが強くなり始めます";
        passiveCursorDes4_2_text.text = "パッシブダメージでカーソルをレベルアップすると、カーソルが強くなります";
        passiveCursorDes5_text.text = "パッシブダメージカーソルが強くなり始めます";
        passiveCursorDes5_2_text.text = "パッシブダメージでカーソルをレベルアップすると、カーソルが強くなります";

        passiveCursorDes1_text.font = japaneseMedium;
        passiveCursorDes2_text.font = japaneseMedium;
        passiveCursorDes3_text.font = japaneseMedium;
        passiveCursorDes4_text.font = japaneseMedium;
        passiveCursorDes4_2_text.font = japaneseMedium;
        passiveCursorDes5_text.font = japaneseMedium;
        passiveCursorDes5_2_text.font = japaneseMedium;

        passiveCursorDes1_text.fontSize = 14;
        passiveCursorDes2_text.fontSize = 14;
        passiveCursorDes3_text.fontSize = 13.8f;
        passiveCursorDes4_text.fontSize = 13.8f;
        passiveCursorDes4_2_text.fontSize = 14;
        passiveCursorDes5_text.fontSize = 13.8f;
        passiveCursorDes5_2_text.fontSize = 14;

        // Gold Descriptions
        goldDes1_text.text = "金貨は+30％多くの金を与えます";
        goldDes2_text.text = "金貨は+120％多くの金を与えます";
        goldDes3_text.text = "金貨は+500％多くの金を与えます";
        goldDes4_text.text = "金貨は+1000％多くの金を与えます";
        goldDes4_2_text.text = "金貨は2倍の金の価値がある3％のチャンスを持っています";
        goldDes5_text.text = "チェストには3％のチャンスがあり、5倍の金の価値がある金貨を落とすことができます。";
        goldDes6_text.text = "金貨は+2000％多くの金を与えます";
        goldDes7_text.text = "チェストには2％のチャンスがあり、10倍の金の価値がある金貨を落とすことができます。";
        goldDes7_2_text.text = "金貨は+1250％多くの金を与えます";
        goldDes8_text.text = "チェストには1％のチャンスがあり、25倍の金の価値がある金貨を落とすことができます。";
        goldDes8_2_text.text = "金貨は+4000％多くの金を与えます";
        goldDes9_text.text = "5X、10X、25Xの金貨のみが胸からドロップされます。";
        goldDes9_2_text.text = "金貨は+5000％多くの金を与えます";

        goldDes1_text.font = japaneseMedium;
        goldDes2_text.font = japaneseMedium;
        goldDes3_text.font = japaneseMedium;
        goldDes4_text.font = japaneseMedium;
        goldDes4_2_text.font = japaneseMedium;
        goldDes5_text.font = japaneseMedium;
        goldDes6_text.font = japaneseMedium;
        goldDes7_text.font = japaneseMedium;
        goldDes7_2_text.font = japaneseMedium;
        goldDes8_text.font = japaneseMedium;
        goldDes8_2_text.font = japaneseMedium;
        goldDes9_text.font = japaneseMedium;
        goldDes9_2_text.font = japaneseMedium;

        goldDes1_text.fontSize = 14;
        goldDes2_text.fontSize = 14;
        goldDes3_text.fontSize = 14;
        goldDes4_text.fontSize = 14;
        goldDes4_2_text.fontSize = 14;
        goldDes5_text.fontSize = 14;
        goldDes6_text.fontSize = 14;
        goldDes7_text.fontSize = 14;
        goldDes7_2_text.fontSize = 14;
        goldDes8_text.fontSize = 14;
        goldDes8_2_text.fontSize = 14;
        goldDes9_text.fontSize = 14;
        goldDes9_2_text.fontSize = 14;

        // Treasure Descriptions
        treasureDes1_text.text = "+0.1%トレジャードロップチャンス";
        treasureDes2_text.text = "+0.2%トレジャードロップチャンス";
        treasureDes3_text.text = "+8%宝の価値が2倍になる可能性が";
        treasureDes4_text.text = "+5%宝の価値が2倍になる可能性が";
        treasureDes4_2_text.text = "+0.2%トレジャードロップチャンス";
        treasureDes5_text.text = "+10%宝の価値が2倍になる可能性が";
        treasureDes5_2_text.text = "+0.2%トレジャードロップチャンス";
        treasureDes6_text.text = "+13%宝の価値が2倍になる可能性が";
        treasureDes6_2_text.text = "+1%トレジャーバッグドロップチャンス";
        treasureDes7_text.text = "+0.4%トレジャードロップチャンス";
        treasureDes7_2_text.text = "販売された宝物は今5倍以上の金の価値があります。";

        treasureDes1_text.font = japaneseMedium;
        treasureDes2_text.font = japaneseMedium;
        treasureDes3_text.font = japaneseMedium;
        treasureDes4_text.font = japaneseMedium;
        treasureDes4_2_text.font = japaneseMedium;
        treasureDes5_text.font = japaneseMedium;
        treasureDes5_2_text.font = japaneseMedium;
        treasureDes6_text.font = japaneseMedium;
        treasureDes6_2_text.font = japaneseMedium;
        treasureDes7_text.font = japaneseMedium;
        treasureDes7_2_text.font = japaneseMedium;

        treasureDes1_text.fontSize = 14;
        treasureDes2_text.fontSize = 14;
        treasureDes3_text.fontSize = 14;
        treasureDes4_text.fontSize = 14;
        treasureDes4_2_text.fontSize = 14;
        treasureDes5_text.fontSize = 14;
        treasureDes6_text.fontSize = 14;
        treasureDes6_2_text.fontSize = 14;
        treasureDes7_text.fontSize = 14;
        treasureDes7_2_text.fontSize = 14;

        // XP Descriptions
        xpDes1_text.text = "+35%経験値";
        xpDes2_text.text = "+125%経験値";
        xpDes3_text.text = "+400%経験値";
        xpDes4_text.text = "+900%経験値";
        xpDes5_text.text = "+1300%経験値";
        xpDes6_text.text = "+2500%経験値";
        xpDes6_2_text.text = "XPドロップごとに+0.25%のチャンスがあり、+1スキルポイントを与えることができます";
        xpDes7_text.text = "+4000%経験値";
        xpDes7_2_text.text = "XPドロップごとに+0.75%のチャンスがあり、+1スキルポイントを与えることができます";
        xpDes8_text.text = "+7500%経験値";
        xpDes8_2_text.text = "XPドロップごとに+1%のチャンスがあり、+1スキルポイントを与えることができます";

        xpDes1_text.font = japaneseMedium;
        xpDes2_text.font = japaneseMedium;
        xpDes3_text.font = japaneseMedium;
        xpDes4_text.font = japaneseMedium;
        xpDes5_text.font = japaneseMedium;
        xpDes6_text.font = japaneseMedium;
        xpDes6_2_text.font = japaneseMedium;
        xpDes7_text.font = japaneseMedium;
        xpDes7_2_text.font = japaneseMedium;
        xpDes8_text.font = japaneseMedium;
        xpDes8_2_text.font = japaneseMedium;

        xpDes1_text.fontSize = 15;
        xpDes2_text.fontSize = 15;
        xpDes3_text.fontSize = 15;
        xpDes4_text.fontSize = 15;
        xpDes5_text.fontSize = 15;
        xpDes6_text.fontSize = 15;
        xpDes6_2_text.fontSize = 12;
        xpDes7_text.fontSize = 15;
        xpDes7_2_text.fontSize = 12;
        xpDes8_text.fontSize = 15;
        xpDes8_2_text.fontSize = 12;

        // Level Special Descriptions
        levelSpecialDes1_text.text = "アイテムをレベルアップすると、アイテムが強くなります";
        levelSpecialDes2_text.text = "アイテムをレベルアップすると、アイテムが強くなります";
        levelSpecialDes3_text.text = "アイテムをレベルアップすると、アイテムが強くなります";
        levelSpecialDes4_text.text = "アイテムをレベルアップすると、アイテムが強くなります";
        levelSpecialDes5_text.text = "アイテムをレベルアップすると、アイテムが強くなります";

        levelSpecialDes1_text.font = japaneseMedium;
        levelSpecialDes2_text.font = japaneseMedium;
        levelSpecialDes3_text.font = japaneseMedium;
        levelSpecialDes4_text.font = japaneseMedium;
        levelSpecialDes5_text.font = japaneseMedium;

        levelSpecialDes1_text.fontSize = 14;
        levelSpecialDes2_text.fontSize = 14;
        levelSpecialDes3_text.fontSize = 14;
        levelSpecialDes4_text.fontSize = 14;
        levelSpecialDes5_text.fontSize = 14;

        // Stronger Special Descriptions
        strongerSpecialDes1_text.text = "すべての項目が強く出て開始します";
        strongerSpecialDes2_text.text = "すべての項目が強く出て開始します";
        strongerSpecialDes3_text.text = "ポーションは+1回積み重ねることができるようになりました";
        strongerSpecialDes4_text.text = "チェストからドロップされたアイテムは、値が倍増する10％のチャンスを持っています";
        strongerSpecialDes5_text.text = "ポーションは+1回積み重ねることができるようになりました";
        strongerSpecialDes5_2_text.text = "すべての項目が強く出て開始します";
        strongerSpecialDes6_text.text = "これで、ハンマー、ゴールデンタッチ、セレンディピティスクロールと貪欲のガントレットを積み重ねることができます";
        strongerSpecialDes7_text.text = "セレンディピティスクロールと古代の遺物はより強いバフを与えます";

        strongerSpecialDes1_text.font = japaneseMedium;
        strongerSpecialDes2_text.font = japaneseMedium;
        strongerSpecialDes3_text.font = japaneseMedium;
        strongerSpecialDes4_text.font = japaneseMedium;
        strongerSpecialDes5_text.font = japaneseMedium;
        strongerSpecialDes5_2_text.font = japaneseMedium;
        strongerSpecialDes6_text.font = japaneseMedium;
        strongerSpecialDes7_text.font = japaneseMedium;

        strongerSpecialDes1_text.fontSize = 14;
        strongerSpecialDes2_text.fontSize = 14;
        strongerSpecialDes3_text.fontSize = 14;
        strongerSpecialDes4_text.fontSize = 14;
        strongerSpecialDes5_text.fontSize = 14;
        strongerSpecialDes5_2_text.fontSize = 14;
        strongerSpecialDes6_text.fontSize = 14;
        strongerSpecialDes7_text.fontSize = 14;

        // Start With Descriptions
        startWithDes1_text.text = "各プレステージの後に開始する1つのアイテムを選択します（あなたは一度購入したアイテムのみを選択することができます）";
        startWithDes2_text.text = "各プレステージの後に開始する2つのアイテムを選択します";
        startWithDes3_text.text = "各プレステージの後に開始する3つのアイテムを選択します";
        startWithDes4_text.text = "各プレステージの後に開始する5つのアイテムを選択します";

        startWithDes1_text.font = japaneseMedium;
        startWithDes2_text.font = japaneseMedium;
        startWithDes3_text.font = japaneseMedium;
        startWithDes4_text.font = japaneseMedium;

        startWithDes1_text.fontSize = 13;
        startWithDes2_text.fontSize = 13;
        startWithDes3_text.fontSize = 13;
        startWithDes4_text.fontSize = 13;

        // Reinforced Descriptions
        reinforcedDes1_text.text = "強化された胸から落とされた金貨は、現在17Xゴールドの価値があります";
        reinforcedDes1_2_text.text = "+0.1%強化された胸のチャンス";
        reinforcedDes2_text.text = "強化された胸から落とされた金貨は、現在24Xゴールドの価値があります";
        reinforcedDes2_2_text.text = "強化されたチェストは今9倍の健康を持っています";
        reinforcedDes2_3_text.text = "強化されたチェストは今6XXPを与える";
        reinforcedDes3_text.text = "強化された胸から落とされた金貨は、現在33Xゴールドの価値があります";
        reinforcedDes3_2_text.text = "+0.3%強化された胸のチャンス";
        reinforcedDes4_text.text = "強化された胸から落とされた金貨は、現在47Xゴールドの価値があります";
        reinforcedDes4_2_text.text = "+0.5%強化された胸のチャンス";
        reinforcedDes4_3_text.text = "強化されたチェストは今8倍の健康を持っています";
        reinforcedDes4_4_text.text = "強化されたチェストは今11XXPを与える";
        reinforcedDes5_text.text = "強化された胸から落とされた金貨は、現在85Xゴールドの価値があります";
        reinforcedDes5_2_text.text = "+1%強化された胸のチャンス";

        reinforcedDes1_text.font = japaneseMedium;
        reinforcedDes1_2_text.font = japaneseMedium;
        reinforcedDes2_text.font = japaneseMedium;
        reinforcedDes2_2_text.font = japaneseMedium;
        reinforcedDes2_3_text.font = japaneseMedium;
        reinforcedDes3_text.font = japaneseMedium;
        reinforcedDes3_2_text.font = japaneseMedium;
        reinforcedDes4_text.font = japaneseMedium;
        reinforcedDes4_2_text.font = japaneseMedium;
        reinforcedDes4_3_text.font = japaneseMedium;
        reinforcedDes4_4_text.font = japaneseMedium;
        reinforcedDes5_text.font = japaneseMedium;
        reinforcedDes5_2_text.font = japaneseMedium;

        reinforcedDes1_text.fontSize = 13;
        reinforcedDes1_2_text.fontSize = 13;
        reinforcedDes2_text.fontSize = 13;
        reinforcedDes2_2_text.fontSize = 13;
        reinforcedDes2_3_text.fontSize = 13;
        reinforcedDes3_text.fontSize = 13;
        reinforcedDes3_2_text.fontSize = 13;
        reinforcedDes4_text.fontSize = 13;
        reinforcedDes4_2_text.fontSize = 13;
        reinforcedDes4_3_text.fontSize = 13;
        reinforcedDes4_4_text.fontSize = 13;
        reinforcedDes5_text.fontSize = 13;
        reinforcedDes5_2_text.fontSize = 13;

        // More Loot Descriptions
        moreLootDes1_text.text = "開いた10個のチェストごとに1個の余分な金貨をドロップします";
        moreLootDes2_text.text = "開いた19個のチェストごとに5倍の金貨を落とし、3倍のXPを与える";
        moreLootDes3_text.text = "開いた18個のチェストごとに、2〜4個の金貨がドロップされ、すべて5倍または10倍の金貨がドロップされます。また、5倍のXPを与えます";
        moreLootDes4_text.text = "開いた30個の宝箱ごとに3個の金貨を落とし、すべて25倍の金貨であり、2-5個の宝物を落とす";
        moreLootDes5_text.text = "開かれたすべての胸は5倍の金貨を落とし、5％の確率で10倍の金貨を落とし、2.5％の確率で25倍の金貨を落とすことができます。また、2倍のXPをドロップします";

        moreLootDes1_text.font = japaneseMedium;
        moreLootDes2_text.font = japaneseMedium;
        moreLootDes3_text.font = japaneseMedium;
        moreLootDes4_text.font = japaneseMedium;
        moreLootDes5_text.font = japaneseMedium;

        moreLootDes1_text.fontSize = 13;
        moreLootDes2_text.fontSize = 13;
        moreLootDes3_text.fontSize = 13;
        moreLootDes4_text.fontSize = 13;
        moreLootDes5_text.fontSize = 13;

        // New Chests Descriptions
        newChestsDes1_text.text = "エンチャントされた黄金の胸には0.2％の確率で出現します";
        newChestsDes1_2_text.text = "エンチャントされた黄金の宝箱は30倍の健康を持っています。20の宝物がドロップされます。ロックピックとキーは、胸の健康状態の33％を削除するだけです。";
        newChestsDes1_3_text.text = "それが表示されたら、または設定でこの胸についての詳細をお読みください。";
        newChestsDes2_text.text = "ボスの胸には0.1％の確率で出現します";
        newChestsDes2_2_text.text = "ボスチェストは100倍の健康を持っています。ボスチェストは、10倍と25倍の金貨であるすべての25金貨を、ドロップします。";
        newChestsDes2_3_text.text = "それが表示されたら、または設定でボスチェストについての詳細をお読みください。";
        newChestsDes3_text.text = "ボスの胸には+0.05%の確率で出現します";
        newChestsDes3_2_text.text = "エンチャントされた黄金の宝箱には+0.1%の確率で出現します";
        newChestsDes4_text.text = "ボスの胸には+0.1%の確率で出現します";
        newChestsDes4_2_text.text = "エンチャントされた黄金の宝箱には+0.15%の確率で出現します";
        newChestsDes4_3_text.text = "魅惑のゴールデンチェストドロップ25\nトレジャーボスチェストドロップ30金貨";
        newChestsDes5_text.text = "魅惑のゴールデンチェストドロップ30\nボスチェストは35枚の金貨を落とし、すべて25倍の金貨です";
        newChestsDes5_2_text.text = "エンチャントされた黄金の宝箱には+0.2の確率で出現します";
        newChestsDes5_3_text.text = "ボスの胸には+0.15%の確率で出現します";
        newChestsDes6_text.text = "ボスの胸には+0.4%の確率で出現します";
        newChestsDes6_2_text.text = "エンチャントされた黄金の宝箱には+0.75%の確率で出現します";
        newChestsDes6_3_text.text = "ボスチェストドロップ20XXP.エンチャントされた黄金の宝箱は、12倍の経験値をドロップします。どちらのチェストも、珍しい宝物を落とすチャンスがわずかに高くなります。";

        newChestsDes1_text.font = japaneseMedium;
        newChestsDes1_2_text.font = japaneseMedium;
        newChestsDes1_3_text.font = japaneseMedium;
        newChestsDes2_text.font = japaneseMedium;
        newChestsDes2_2_text.font = japaneseMedium;
        newChestsDes2_3_text.font = japaneseMedium;
        newChestsDes3_text.font = japaneseMedium;
        newChestsDes3_2_text.font = japaneseMedium;
        newChestsDes4_text.font = japaneseMedium;
        newChestsDes4_2_text.font = japaneseMedium;
        newChestsDes4_3_text.font = japaneseMedium;
        newChestsDes5_text.font = japaneseMedium;
        newChestsDes5_2_text.font = japaneseMedium;
        newChestsDes5_3_text.font = japaneseMedium;
        newChestsDes6_text.font = japaneseMedium;
        newChestsDes6_2_text.font = japaneseMedium;
        newChestsDes6_3_text.font = japaneseMedium;

        newChestsDes1_text.fontSize = 12;
        newChestsDes1_2_text.fontSize = 12;
        newChestsDes1_3_text.fontSize = 8f;
        newChestsDes2_text.fontSize = 13;
        newChestsDes2_2_text.fontSize = 13;
        newChestsDes2_3_text.fontSize = 8f;
        newChestsDes3_text.fontSize = 12;
        newChestsDes3_2_text.fontSize = 12;
        newChestsDes4_text.fontSize = 12;
        newChestsDes4_2_text.fontSize = 12;
        newChestsDes4_3_text.fontSize = 12;
        newChestsDes5_text.fontSize = 12;
        newChestsDes5_2_text.fontSize = 12;
        newChestsDes5_3_text.fontSize = 12;
        newChestsDes6_text.fontSize = 12;
        newChestsDes6_2_text.fontSize = 12;
        newChestsDes6_3_text.fontSize = 10;

        #endregion

        #region Other
        maxPurchaseText_text.text = "最大の購入"; maxPurchaseText_text.font = japaneseBoldOutline; maxPurchaseText_text.fontSize = 32;
        youCanAlsoHoldDown_text.text = "また、最大を購入するために左のコントロールを押したままにすることができます"; youCanAlsoHoldDown_text.font = japaneseMedium; youCanAlsoHoldDown_text.fontSize = 10;

        X1_text1.text = "X1"; X1_text1.font = japaneseMedium; X1_text1.fontSize = 35;
        X1_text2.text = "X1"; X1_text2.font = japaneseMedium; X1_text2.fontSize = 32;
        X1_text3.text = "X1"; X1_text3.font = japaneseMedium; X1_text3.fontSize = 32;
        MAX_text1.text = "マックス"; MAX_text1.font = japaneseMedium; MAX_text1.fontSize = 21;
        MAX_text2.text = "マックス"; MAX_text2.font = japaneseMedium; MAX_text2.fontSize = 21;
        MAX_text3.text = "マックス"; MAX_text3.font = japaneseMedium; MAX_text3.fontSize = 21;

        activeDamageBar_text.text = "アクティブダメージ"; activeDamageBar_text.font = japaneseBold; activeDamageBar_text.fontSize = 36;
        activeDamageACTIVE_text.text = "アクティ"; activeDamageACTIVE_text.font = japaneseMediumOutline; activeDamageACTIVE_text.fontSize = 21;
        activeDamageLEVEL_text.text = "レベル"; activeDamageLEVEL_text.font = japaneseBold; activeDamageLEVEL_text.fontSize = 27;

        passiveDamageBar_text.text = "パッシブダメージ"; passiveDamageBar_text.font = japaneseBold; passiveDamageBar_text.fontSize = 36;
        passivePASSIVE_Text.text = "パッシ"; passivePASSIVE_Text.font = japaneseMediumOutline; passivePASSIVE_Text.fontSize = 20;
        passiveLEVEL_text.text = "レベル"; passiveLEVEL_text.font = japaneseBold; passiveLEVEL_text.fontSize = 27;

        welcome.text = "ようこそ！"; welcome.font = japaneseBoldOutline; welcome.fontSize = 21;
        beforeWeCanStartPlaying.text = "我々は再生を開始することができます前に。あなたは戦利品がそれ自身で収集を開始する前に、画面上に持っているどのくらいの戦利品をしたいですか?"; beforeWeCanStartPlaying.font = japaneseMediumOutline; beforeWeCanStartPlaying.fontSize = 11f;
        changeAnyTime.text = "これは、いつでも設定で変更できます"; changeAnyTime.font = japaneseMediumOutline; changeAnyTime.fontSize = 10;
        playGame.text = "プレイ"; playGame.font = japaneseMediumOutline; playGame.fontSize = 62;

        welcomeBack.text = "おかえりなさい!"; welcomeBack.font = japaneseBoldOutline; welcomeBack.fontSize = 65;
        if(PlaceMobileButtons.isMobile == true) { welcomeBack.fontSize = 38; }
        thisHappendWhileGone.text = "これはあなたがいなくなっている間に起こりました。.."; thisHappendWhileGone.font = japaneseMediumOutline; thisHappendWhileGone.fontSize = 27;
        cool.text = "かっこいい!"; cool.font = japaneseBoldOutline; cool.fontSize = 34;
        timeGone.text = "時間がなくなった:"; timeGone.font = japaneseBoldOutline; timeGone.fontSize = 55;

        #endregion

        //Text That Changes
        #region info settings
        enchantedGoldenChestHealth = "エンチャントされた黄金の宝箱は" + UpdateGame.enchantedGoldenChestHealth + "倍の健康を持っています";
        enchantedGoldenChestTreasureDrops = "-" + UpdateGame.enchantedGoldenChestTreasureDrops + "宝の雫";
        enchantedGoldenChestXPDrop = "+" + UpdateGame.enchantedGoldenChestXPDrops + "Xドロップ";

        bossChestHealth = "ボスチェストは" + UpdateGame.bossChestHealth + "倍の健康を持っています";
        bossChestGoldValue = "ゴールドコイン値=" + UpdateGame.bossChestGoldValue + "ゴールド";
        bossChestGoldCoins = "" + UpdateGame.bossChestGoldCoinsDrops + "金貨は、10Xと25X金貨であるすべて、ドロップされます";
        bossChestGoldCoins2 = "" + UpdateGame.bossChestGoldCoinsDrops + "金貨は25X金貨であるすべて、ドロップされます";
        bossChestXP = "+" + UpdateGame.bossChestXPDrops + "XXPドロップ";

        reinforcedHealth = "強化されたチェストは" + UpdateGame.reinforcedChestHealth + "倍の健康を持っています";
        reinforcedGold = "ドロップされた金貨は" + UpdateGame.reinforcedChestGoldIncrease + "倍の金を与えます";
        reinforcedXP = "+" + UpdateGame.reinforcedXPIncrease + "XXPドロップ";

        reinforcedInfo = "強化されたチェストは" + UpdateGame.reinforcedChestHealth + "倍のヘルスを持ち、" + UpdateGame.reinforcedChestGoldIncrease + "倍のゴールドと" + UpdateGame.reinforcedXPIncrease + "倍のXPを与えます。";

        enchantedChestInfo = (100 - UpdateGame.enchantedGoldenChestChance).ToString("F2") + "%スポーンのチャンス\nエンチャントされた黄金の宝箱は、 " + UpdateGame.enchantedGoldenChestHealth + "倍の健康を持っている" + UpdateGame.enchantedGoldenChestTreasureDrops + "宝物と" + UpdateGame.enchantedGoldenChestXPDrops + "倍のXPをドロップします.\nロックピックまたはキーを使用すると、胸の健康状態の33％しか削除されません\nエンチャントされた黄金の宝箱はまた、珍しい宝を落とす可能性がわずかに高くなります。";

        bossChestInfo1 = (UpdateGame.bossChestChance).ToString("F2") + "%スポーンのチャンス\nボスチェストは" + UpdateGame.bossChestHealth + "倍の健康を持っています。金貨は" + UpdateGame.bossChestGoldValue + "倍の価値があります。 ボスチェストは" + UpdateGame.bossChestGoldCoinsDrops + "枚の金貨を落とし、すべて10倍または25倍の金貨です.(金貨値フォームボス胸=(現在の胸金貨値*5)*10または25). また、" + UpdateGame.bossChestXPDrops + "XXPを与えます.\nUロックピックまたはキーを使用すると、胸の健康状態の25％しか削除されません。ボスの胸はまた、珍しい宝物をドロップするわずかに高いチャンスを持っています。";

        bossChestInfo2 = (UpdateGame.bossChestChance).ToString("F2") + "%スポーンのチャンス\nボスチェストは" + UpdateGame.bossChestHealth + "倍の健康を持っています。金貨は" + UpdateGame.bossChestGoldValue + "倍の価値があります。 ボスチェストは" + UpdateGame.bossChestGoldCoinsDrops + "ボスチェストは25枚の金貨を落とし、すべて25倍の金貨です.(金貨値フォームボス胸=(現在の胸金貨値*5)*25). また、" + UpdateGame.bossChestXPDrops + "XXPを与えます.\nUロックピックまたはキーを使用すると、胸の健康状態の25％しか削除されません。ボスの胸はまた、珍しい宝物をドロップするわずかに高いチャンスを持っています。";

        purchaseTheEnchanted = "エンチャントされたゴールデンチェストプレステージアップグレードを購入して情報を表示します";
        purchaseTheBossChest = "ボスチェストプレステージアップグレードを購入して情報を表示する";

        reinforcedChestsDescription_text2.font = japaneseMedium; reinforcedChestsDescription_text2.fontSize = 12;

        enchantedGoldenChestsDescription_text.font = japaneseMedium; enchantedGoldenChestsDescription_text.fontSize = 10;

        bossChestsDescription_text.font = japaneseMedium; bossChestsDescription_text.fontSize = 10;
        #endregion

        #region stats

        goldCoinsDropped = "落とした金貨: ";
        totalGoldReceived = "受け取った金の合計: ";
        totalBarrelGold = "総バレル金: ";
        treasuresDropped = "ドロップされた宝物: ";
        commonTreasures = "人気ランキング: ";
        uncommonTreasures = "珍品: ";
        rareTreasures = "珍品: ";
        veryRareTreasures = "非常に珍しい宝物: ";
        extremelyRareTreasures = "珍品: ";
        legendaryTreasures = "伝説の宝物: ";
        ultraTreasures = "超お宝: ";
        mythicTreasures = "神話の宝物: ";
        eternalTreasures = "永遠の宝物: ";
        treasuresDoubled = "宝物: ";
        chestsOpened = "開いたチェスト: ";
        reinforcedChestsOpened = "オープン: ";
        enchantedGoldenChestsOpened = "エンチャントされた黄金の宝箱が開かれました: ";
        bossChestsOpened = "ボスチェスト開いた: ";
        chestClicks = "クリック: ";
        autoClicks = "自動クリック: ";
        criticalHits = "クリティカルヒット数: ";
        activeDamage = "アクティブダメージ: ";
        passiveDamage = "受動被害: ";
        critChance = "クリティカルチャンス: ";
        critDamage = "クリティカルダメージ: ";
        cursorsLeveledUp = "カーソルがレベルアップ: ";
        coinsSpawnedFromClicks = "クリック: ";
        treasuresSpawnedFromClicks = "クリック: ";
        itemsUsed = "使用アイテム数: ";
        itemsDropped = "削除されたアイテム: ";
        itemsPurchased = "購入アイテム数: ";
        itemsLeveledUp = "アイテム数: ";
        prestigeCount = "プレステージ数: ";
        prestigeUpgradesPurchased = "購入数: ";
        skillPointsReceived = "獲得スキルポイント: ";
        goldIncrease = "ゴールド増加: ";
        xpIncrease = "XPの増加: ";
        activeDamageIncrease = "アクティブダメージ増加: ";
        passiveDamageIncrease = "パッシブダメージ増加: ";
        critChanceIncrease = "クリティカルチャンス増加: ";
        critDamageIncrease = "クリティカルダメージ増加: ";
        treasureChanceIncrease = "宝チャンス増加: ";
        goldCoins5xDropped = "ドロップされた5倍の金貨:  ";
        goldCoins10xDropped = "ドロップされた10倍の金貨: ";
        goldCoins25xDropped = "ドロップされた25倍の金貨: ";
        goldCoins100xDropped = "ドロップされた100Xゴールドコイン： ";

        goldCoinsDropped_text.font = japaneseMediumOutline; goldCoinsDropped_text.fontSize = 27;
        totalGoldReceived_text.font = japaneseMediumOutline; totalGoldReceived_text.fontSize = 27;
        totalBarrelGold_text.font = japaneseMediumOutline; totalBarrelGold_text.fontSize = 27;
        treasuresDropped_text.font = japaneseMediumOutline; treasuresDropped_text.fontSize = 27;
        commonTreasures_text.font = japaneseMediumOutline; commonTreasures_text.fontSize = 27;
        uncommonTreasures_text.font = japaneseMediumOutline; uncommonTreasures_text.fontSize = 27;
        rareTreasures_text.font = japaneseMediumOutline; rareTreasures_text.fontSize = 27;
        veryRareTreasures_text.font = japaneseMediumOutline; veryRareTreasures_text.fontSize = 27;
        extremelyRareTreasures_text.font = japaneseMediumOutline; extremelyRareTreasures_text.fontSize = 27;
        legendaryTreasures_text.font = japaneseMediumOutline; legendaryTreasures_text.fontSize = 27;
        ultraTreasures_text.font = japaneseMediumOutline; ultraTreasures_text.fontSize = 27;
        mythicTreasures_text.font = japaneseMediumOutline; mythicTreasures_text.fontSize = 27;
        eternalTreasures_text.font = japaneseMediumOutline; eternalTreasures_text.fontSize = 27;
        treasuresDoubled_text.font = japaneseMediumOutline; treasuresDoubled_text.fontSize = 27;
        chestsOpened_text.font = japaneseMediumOutline; chestsOpened_text.fontSize = 27;
        reinforcedChestsOpened_text.font = japaneseMediumOutline; reinforcedChestsOpened_text.fontSize = 25;
        enchantedGoldenChestsOpened_text.font = japaneseMediumOutline; enchantedGoldenChestsOpened_text.fontSize = 27;
        bossChestsOpened_text.font = japaneseMediumOutline; bossChestsOpened_text.fontSize = 27;
        chestClicks_text.font = japaneseMediumOutline; chestClicks_text.fontSize = 27;
        autoClicks_text.font = japaneseMediumOutline; autoClicks_text.fontSize = 27;
        criticalHits_text.font = japaneseMediumOutline; criticalHits_text.fontSize = 27;
        activeDamage_text.font = japaneseMediumOutline; activeDamage_text.fontSize = 27;
        passiveDamage_text.font = japaneseMediumOutline; passiveDamage_text.fontSize = 27;
        critChance_text.font = japaneseMediumOutline; critChance_text.fontSize = 27;
        critDamage_text.font = japaneseMediumOutline; critDamage_text.fontSize = 27;
        cursorsLeveledUp_text.font = japaneseMediumOutline; cursorsLeveledUp_text.fontSize = 27;
        coinsSpawnedFromClicks_text.font = japaneseMediumOutline; coinsSpawnedFromClicks_text.fontSize = 27;
        treasuresSpawnedFromClicks_text.font = japaneseMediumOutline; treasuresSpawnedFromClicks_text.fontSize = 24;
        itemsUsed_text.font = japaneseMediumOutline; itemsUsed_text.fontSize = 27;
        itemsDropped_text.font = japaneseMediumOutline; itemsDropped_text.fontSize = 27;
        itemsPurchased_text.font = japaneseMediumOutline; itemsPurchased_text.fontSize = 27;
        itemsLeveledUp_text.font = japaneseMediumOutline; itemsLeveledUp_text.fontSize = 27;
        prestigeCount_text.font = japaneseMediumOutline; prestigeCount_text.fontSize = 27;
        prestigeUpgradesPurchased_text.font = japaneseMediumOutline; prestigeUpgradesPurchased_text.fontSize = 27;
        skillPointsReceived_text.font = japaneseMediumOutline; skillPointsReceived_text.fontSize = 27;
        goldIncrease_text.font = japaneseMediumOutline; goldIncrease_text.fontSize = 27;
        xpIncrease_text.font = japaneseMediumOutline; xpIncrease_text.fontSize = 27;
        activeDamageIncrease_text.font = japaneseMediumOutline; activeDamageIncrease_text.fontSize = 27;
        passiveDamageIncrease_text.font = japaneseMediumOutline; passiveDamageIncrease_text.fontSize = 27;
        critChanceIncrease_text.font = japaneseMediumOutline; critChanceIncrease_text.fontSize = 27;
        critDamageIncrease_text.font = japaneseMediumOutline; critDamageIncrease_text.fontSize = 27;
        treasureChanceIncrease_text.font = japaneseMediumOutline; treasureChanceIncrease_text.fontSize = 27;
        goldCoins5xDropped_text.font = japaneseMediumOutline; goldCoins5xDropped_text.fontSize = 27;
        goldCoins10xDropped_text.font = japaneseMediumOutline; goldCoins10xDropped_text.fontSize = 27;
        goldCoins25xDropped_text.font = japaneseMediumOutline; goldCoins25xDropped_text.fontSize = 27;
        goldCoins100xDropped_text.font = japaneseMediumOutline; goldCoins100xDropped_text.fontSize = 27;
        #endregion

        #region cursors
        NOdot = "";

        upgrade = "アップグレード";
        upgradeMax = "アップグレード（最大）";

        lvl = "レベル";

        price = "価格: ";
        damage = "ダメージ: ";

        equipped = "装備されている";
        unequpped = "不装備";

        equippedNONE = "装備=";

        cursor1Equipped = "装備=<color=green>ジェントルタップ";
        cursor2Equipped = "装備=<color=green>リラックスした手のひら";
        cursor3Equipped = "装備=<color=green>ゲイルフォース";
        cursor4Equipped = "装備=<color=green>ラディアントタッチ";
        cursor5Equipped = "装備=<color=green>エネルギーサージ";
        cursor6Equipped = "装備=<color=green>ファントムパーム";
        cursor7Equipped = "装備=<color=green>スチールストライク";
        cursor8Equipped = "装備=<color=green>致命的なタッチ";
        cursor9Equipped = "装備=<color=green>精密ポイント";
        cursor10Equipped = "装備=<color=green>渦タップ";
        cursor11Equipped = "装備=<color=green>呪われた爪";
        cursor12Equipped = "装備=<color=green>スナイパークリック";
        cursor13Equipped = "装備=<color=green>シャドウサージ";
        cursor14Equipped = "装備=<color=green>クリップリングクラッシュ";
        cursor15Equipped = "装備=<color=green>クイッククリック";
        cursor16Equipped = "装備=<color=green>天のタッチ";
        cursor17Equipped = "装備=<color=green>秘儀クリック";
        cursor18Equipped = "装備=<color=green>エターナルタッチ";
        cursor19Equipped = "装備=<color=green>ドゥームタッチ";
        cursor20Equipped = "装備=<color=green>ソーラースイープ";
        cursor21Equipped = "装備=<color=green>インフェルノ-フィスト";

        for (int i = 0; i < 21; i++)
        {
            lvlsHover_text[i].font = japaneseSemiBold; lvlsHover_text[i].fontSize = 21;

            equippedHover_text[i].font = japaneseSemiBold; equippedHover_text[i].fontSize = 28;
            level_text[i].font = japaneseSemiBold; level_text[i].fontSize = 39;
        }

        equippedEquals_text.font = japaneseSemiBold; equippedEquals_text.fontSize = 23f;
        dpsTopBar_text.font = japaneseSemiBold; dpsTopBar_text.fontSize = 23f;
        clickDamageTopBar_text.font = japaneseSemiBold; clickDamageTopBar_text.fontSize = 23f;
        critChanceTopBar_text.font = japaneseSemiBold; critChanceTopBar_text.fontSize = 23f;
        critDamageTopBar_text.font = japaneseSemiBold; critDamageTopBar_text.fontSize = 23f;

        noNotUnlcoked_text.font = japaneseBold; noNotUnlcoked_text.fontSize = 70f;

        cursor1ActiveDamage_Text.font = japaneseBold; cursor1ActiveDamage_Text.fontSize = 17f;

        cursor2PassiveDamage_Text.font = japaneseBold; cursor2PassiveDamage_Text.fontSize = 17f;

        cursor3CritChance_Text.font = japaneseBold; cursor3CritChance_Text.fontSize = 17f;
        cursor3CritDamage_Text.font = japaneseBold; cursor3CritDamage_Text.fontSize = 17f;

        cursor4ActiveDamage_Text.font = japaneseBold; cursor4ActiveDamage_Text.fontSize = 17f;
        cursor4PassiveDamage_Text.font = japaneseBold; cursor4PassiveDamage_Text.fontSize = 17f;

        cursor5ActiveDamage_Text.font = japaneseBold; cursor5ActiveDamage_Text.fontSize = 17f;
        cursor5CritChance_Text.font = japaneseBold; cursor5CritChance_Text.fontSize = 17f;
        cursor5CritDamage_Text.font = japaneseBold; cursor5CritDamage_Text.fontSize = 17f;

        cursor6ActiveDamage_Text.font = japaneseBold; cursor6ActiveDamage_Text.fontSize = 17f;
        cursor6PassiveDamage_Text.font = japaneseBold; cursor6PassiveDamage_Text.fontSize = 17f;
        cursor6CritChance_Text.font = japaneseBold; cursor6CritChance_Text.fontSize = 17f;
        cursor6CritDamage_Text.font = japaneseBold; cursor6CritDamage_Text.fontSize = 17f;

        cursor7ActiveDamage_Text.font = japaneseBold; cursor7ActiveDamage_Text.fontSize = 17f;
        cursor7CritChance_Text.font = japaneseBold; cursor7CritChance_Text.fontSize = 17f;
        cursor7CritDamage_Text.font = japaneseBold; cursor7CritDamage_Text.fontSize = 17f;

        cursor8ActiveDamage_Text.font = japaneseBold; cursor8ActiveDamage_Text.fontSize = 17f;
        cursor8PassiveDamage_Text.font = japaneseBold; cursor8PassiveDamage_Text.fontSize = 17f;
        cursor8CritChance_Text.font = japaneseBold; cursor8CritChance_Text.fontSize = 17f;
        cursor8CritDamage_Text.font = japaneseBold; cursor8CritDamage_Text.fontSize = 17f;

        cursor9ActiveDamage_Text.font = japaneseBold; cursor9ActiveDamage_Text.fontSize = 17f;
        cursor9PassiveDamage_Text.font = japaneseBold; cursor9PassiveDamage_Text.fontSize = 17f;

        cursor10PassiveDamage_Text.font = japaneseBold; cursor10PassiveDamage_Text.fontSize = 17f;

        cursor11ActiveDamage_Text.font = japaneseBold; cursor11ActiveDamage_Text.fontSize = 17f;
        cursor11CritChance_Text.font = japaneseBold; cursor11CritChance_Text.fontSize = 17f;
        cursor11CritDamage_Text.font = japaneseBold; cursor11CritDamage_Text.fontSize = 17f;

        cursor12ActiveDamage_Text.font = japaneseBold; cursor12ActiveDamage_Text.fontSize = 17f;
        cursor12PassiveDamage_Text.font = japaneseBold; cursor12PassiveDamage_Text.fontSize = 17f;
        cursor12CritChance_Text.font = japaneseBold; cursor12CritChance_Text.fontSize = 17f;
        cursor12CritDamage_Text.font = japaneseBold; cursor12CritDamage_Text.fontSize = 17f;

        cursor13ActiveDamage_Text.font = japaneseBold; cursor13ActiveDamage_Text.fontSize = 17f;
        cursor13PassiveDamage_Text.font = japaneseBold; cursor13PassiveDamage_Text.fontSize = 17f;
        cursor13CritChance_Text.font = japaneseBold; cursor13CritChance_Text.fontSize = 17f;
        cursor13CritDamage_Text.font = japaneseBold; cursor13CritDamage_Text.fontSize = 17f;

        cursor14ActiveDamage_Text.font = japaneseBold; cursor14ActiveDamage_Text.fontSize = 17f;
        cursor14PassiveDamage_Text.font = japaneseBold; cursor14PassiveDamage_Text.fontSize = 17f;
        cursor14CritChance_Text.font = japaneseBold; cursor14CritChance_Text.fontSize = 17f;
        cursor14CritDamage_Text.font = japaneseBold; cursor14CritDamage_Text.fontSize = 17f;

        cursor15ActiveDamage_Text.font = japaneseBold; cursor15ActiveDamage_Text.fontSize = 17f;
        cursor15PassiveDamage_Text.font = japaneseBold; cursor15PassiveDamage_Text.fontSize = 17f;
        cursor15CritChance_Text.font = japaneseBold; cursor15CritChance_Text.fontSize = 17f;
        cursor15CritDamage_Text.font = japaneseBold; cursor15CritDamage_Text.fontSize = 17f;

        cursor16ActiveDamage_Text.font = japaneseBold; cursor16ActiveDamage_Text.fontSize = 17f;
        cursor16PassiveDamage_Text.font = japaneseBold; cursor16PassiveDamage_Text.fontSize = 17f;
        cursor16CritChance_Text.font = japaneseBold; cursor16CritChance_Text.fontSize = 17f;
        cursor16CritDamage_Text.font = japaneseBold; cursor16CritDamage_Text.fontSize = 17f;

        cursor17ActiveDamage_Text.font = japaneseBold; cursor17ActiveDamage_Text.fontSize = 17f;
        cursor17PassiveDamage_Text.font = japaneseBold; cursor17PassiveDamage_Text.fontSize = 17f;
        cursor17CritChance_Text.font = japaneseBold; cursor17CritChance_Text.fontSize = 17f;
        cursor17CritDamage_Text.font = japaneseBold; cursor17CritDamage_Text.fontSize = 17f;

        cursor18ActiveDamage_Text.font = japaneseBold; cursor18ActiveDamage_Text.fontSize = 17f;
        cursor18PassiveDamage_Text.font = japaneseBold; cursor18PassiveDamage_Text.fontSize = 17f;
        cursor18CritChance_Text.font = japaneseBold; cursor18CritChance_Text.fontSize = 17f;
        cursor18CritDamage_Text.font = japaneseBold; cursor18CritDamage_Text.fontSize = 17f;

        cursor19ActiveDamage_Text.font = japaneseBold; cursor19ActiveDamage_Text.fontSize = 17f;
        cursor19PassiveDamage_Text.font = japaneseBold; cursor19PassiveDamage_Text.fontSize = 17f;
        cursor19CritChance_Text.font = japaneseBold; cursor19CritChance_Text.fontSize = 17f;
        cursor19CritDamage_Text.font = japaneseBold; cursor19CritDamage_Text.fontSize = 17f;

        cursor20ActiveDamage_Text.font = japaneseBold; cursor20ActiveDamage_Text.fontSize = 17f;
        cursor20PassiveDamage_Text.font = japaneseBold; cursor20PassiveDamage_Text.fontSize = 17f;
        cursor20CritChance_Text.font = japaneseBold; cursor20CritChance_Text.fontSize = 17f;
        cursor20CritDamage_Text.font = japaneseBold; cursor20CritDamage_Text.fontSize = 17f;

        cursor21ActiveDamage_Text.font = japaneseBold; cursor21ActiveDamage_Text.fontSize = 17f;
        cursor21PassiveDamage_Text.font = japaneseBold; cursor21PassiveDamage_Text.fontSize = 17f;
        cursor21CritChance_Text.font = japaneseBold; cursor21CritChance_Text.fontSize = 17f;
        cursor21CritDamage_Text.font = japaneseBold; cursor21CritDamage_Text.fontSize = 17f;
        #endregion

        #region items and shop

        MAX = "マックス";
        owned = "所有:";
        treasuresExplinationMark = "宝物！";
        skillPointsExplinatinMark = "つのスキルポイント！";

        stack = "スタックX";

        forTheNext = "次の";
        seconds = "秒のために";

        for (int i = 0; i < 17; i++)
        {
            itemsPrice_text[i].font = japaneseSemiBold; itemsPrice_text[i].fontSize = 20;
            itemsLvlHover_text[i].font = japaneseSemiBold; itemsLvlHover_text[i].fontSize = 21;
            itemsPriceHover_text[i].font = japaneseBold; itemsPriceHover_text[i].fontSize = 18;
        }

        for (int i = 0; i < 14; i++)
        {
            owned_text[i].font = japaneseSemiBold; owned_text[i].fontSize = 22;
        }

        stack_text1.font = japaneseMediumOutline; stack_text1.fontSize = 25f;
        stack_text2.font = japaneseMediumOutline; stack_text2.fontSize = 25f;
        stack_text3.font = japaneseMediumOutline; stack_text3.fontSize = 25f;
        stack_text4.font = japaneseMediumOutline; stack_text4.fontSize = 25f;
        stack_text5.font = japaneseMediumOutline; stack_text5.fontSize = 25f;
        stack_text6.font = japaneseMediumOutline; stack_text6.fontSize = 25f;
        stack_text7.font = japaneseMediumOutline; stack_text7.fontSize = 25f;
        stack_text8.font = japaneseMediumOutline; stack_text8.fontSize = 25f;

        lockPickDropChance_text.font = japaneseRegular; lockPickDropChance_text.fontSize = 19f;
        lockPickInfo.font = japaneseBold; lockPickInfo.fontSize = 23f;
        hammerInfo_text.font = japaneseBold; hammerInfo_text.fontSize = 21f;
        hammerDropChance_text.font = japaneseRegular; hammerDropChance_text.fontSize = 19f;
        lootPotionInfo_text.font = japaneseBold; lootPotionInfo_text.fontSize = 20f;
        lootPotionDropChance_text.font = japaneseRegular; lootPotionDropChance_text.fontSize = 19f;
        damagePotionInfo_text.font = japaneseBold; damagePotionInfo_text.fontSize = 21f;
        damagePotionDropChance_text.font = japaneseRegular; damagePotionDropChance_text.fontSize = 19f;
        xpPotionInfo_text.font = japaneseBold; xpPotionInfo_text.fontSize = 21f;
        xpPotionDropChance_text.font = japaneseRegular; xpPotionDropChance_text.fontSize = 19f;
        goldenTouchInfo_text.font = japaneseBold; goldenTouchInfo_text.fontSize = 21f;
        goldenTouchDropChance_text.font = japaneseRegular; goldenTouchDropChance_text.fontSize = 19f;
        miniChestInfo_text.font = japaneseBold; miniChestInfo_text.fontSize = 21f;
        keyInfo_text.font = japaneseBold; keyInfo_text.fontSize = 17f;
        keyDropChance_text.font = japaneseRegular; keyDropChance_text.fontSize = 19f;
        treasureBagInfo_text.font = japaneseBold; treasureBagInfo_text.fontSize = 19f;
        serendipityScrollInfo_text.font = japaneseBold; serendipityScrollInfo_text.fontSize = 19f;
        serendipityScollDropChance_text.font = japaneseRegular; serendipityScollDropChance_text.fontSize = 19f;
        gauntletOfGreenInfo_text.font = japaneseBold; gauntletOfGreenInfo_text.fontSize = 18f;
        gauntletOfGreenDropChance_text.font = japaneseRegular; gauntletOfGreenDropChance_text.fontSize = 19f;
        magicalElixirInfo.font = japaneseBold; magicalElixirInfo.fontSize = 18f;
        magicalElixirDropChance_text.font = japaneseRegular; magicalElixirDropChance_text.fontSize = 19f;
        ancientRelicDropChance_text.font = japaneseRegular; ancientRelicDropChance_text.fontSize = 19f;
        enchantedHammerInfo_text.font = japaneseBold; enchantedHammerInfo_text.fontSize = 16f;
        enchantedHammerDropChance_text.font = japaneseRegular; enchantedHammerDropChance_text.fontSize = 19f;
        treasurePotionInfo_text.font = japaneseBold; treasurePotionInfo_text.fontSize = 18f;
        treasurePotionDropChance_text.font = japaneseRegular; treasurePotionDropChance_text.fontSize = 19f;
        barrelOfGoldTotalGold_text.font = japaneseBoldOutline; barrelOfGoldTotalGold_text.fontSize = 13f;
        mimicChestSpawns_text.font = japaneseBold; mimicChestSpawns_text.fontSize = 17f;
        mimicChestChanceForBuff_text.font = japaneseBold; mimicChestChanceForBuff_text.fontSize = 15.4f;
        barrelOfGoldInfo_text.font = japaneseBold; barrelOfGoldInfo_text.fontSize = 17f;

        //Item and mimic chest buffs
        goldBuffText_text.font = japaneseBoldOutline; goldBuffText_text.fontSize = 14;
        lootPotionBuff_text.font = japaneseBoldOutline; lootPotionBuff_text.fontSize = 14;
        damagePotionBuff_text.font = japaneseBoldOutline; damagePotionBuff_text.fontSize = 12;
        damageBuff_text.font = japaneseBoldOutline; damageBuff_text.fontSize = 12;
        treasureBuff_text.font = japaneseBoldOutline; treasureBuff_text.fontSize = 11; treasureBuff_text.lineSpacing = -90;
        xpBuff_text.font = japaneseBoldOutline; xpBuff_text.fontSize = 13;
        xpPotionBuff.font = japaneseBoldOutline; xpPotionBuff.fontSize = 13;
        elixirGoldBuff_text.font = japaneseBoldOutline; elixirGoldBuff_text.fontSize = 11;
        elixirXPBuff_text.font = japaneseBoldOutline; elixirXPBuff_text.fontSize = 11;
        elixirDamageBuff_text.font = japaneseBoldOutline; elixirDamageBuff_text.fontSize = 11;
        goldCoinsDropBuff_text.font = japaneseBoldOutline; goldCoinsDropBuff_text.fontSize = 11;
        goldenTouchBuff.font = japaneseBoldOutline; goldenTouchBuff.fontSize = 10;

        negativeGold_text.font = japaneseBoldOutline; negativeGold_text.fontSize = 14;
        negativeDamage_text.font = japaneseBoldOutline; negativeDamage_text.fontSize = 12;
        negativeTreasure_text.font = japaneseBoldOutline; negativeTreasure_text.fontSize = 11;
        negativeXP_text.font = japaneseBoldOutline; negativeXP_text.fontSize = 13;
        negativeGoldCoinsDrop_text.font = japaneseBoldOutline; negativeGoldCoinsDrop_text.fontSize = 11.4f;

        goldBuffTimer_text.font = japaneseBoldOutline; goldBuffTimer_text.fontSize = 10;
        lootPotionBuffTimer_text.font = japaneseBoldOutline; lootPotionBuffTimer_text.fontSize = 10;
        damageBuffTimer_text.font = japaneseBoldOutline; damageBuffTimer_text.fontSize = 10;
        damagePotionTimer_text.font = japaneseBoldOutline; damagePotionTimer_text.fontSize = 10;
        treasureBuffTimer_text.font = japaneseBoldOutline; treasureBuffTimer_text.fontSize = 10;
        xpBuffTimer_text.font = japaneseBoldOutline; xpBuffTimer_text.fontSize = 10;
        XpPotionTimer_text.font = japaneseBoldOutline; XpPotionTimer_text.fontSize = 10;
        elixirTimer_text.font = japaneseBoldOutline; elixirTimer_text.fontSize = 10;
        goldCoinsDropsTimer_text.font = japaneseBoldOutline; goldCoinsDropsTimer_text.fontSize = 10;
        treasurePotionTimer_Text.font = japaneseBoldOutline; treasurePotionTimer_Text.fontSize = 10;
        goldenTouchTimer_text.font = japaneseBoldOutline; goldenTouchTimer_text.fontSize = 10;
        rareTreasuresTimer_text.font = japaneseBoldOutline; rareTreasuresTimer_text.fontSize = 10;
        negativeGoldtimer_Text.font = japaneseBoldOutline; negativeGoldtimer_Text.fontSize = 10;
        negativeDamageTimer_text.font = japaneseBoldOutline; negativeDamageTimer_text.fontSize = 10;
        negativeTreasureTimer_text.font = japaneseBoldOutline; negativeTreasureTimer_text.fontSize = 10;
        negativeXPTimer_text.font = japaneseBoldOutline; negativeXPTimer_text.fontSize = 10;
        negativeGoldCoinsDropTimer_text.font = japaneseBoldOutline; negativeGoldCoinsDropTimer_text.fontSize = 10;
        #endregion

        #region Treasures
        chooseChickenBuff = "<color=green>バフを選択するには、鶏をクリックしてください";

        foundRubberChickenRewards2_text.font = japaneseMediumOutline; foundRubberChickenRewards2_text.fontSize = 7f;

        tDropChanceRussAndEng = "%胸から落ちる確率";

        doubleInValue = "のチャンスを持っていま";

        quartsGained = "獲得したクォーツは、値が倍増する";
        amethystGained = "獲得したアメジストは、値が倍増する";
        yellowTopazGained = "獲得したイエロートパーズは、値が倍増する";
        albiteGained = "獲得したアルビテは、値が倍増する";
        redGarnetGained = "獲得したレッドガーネットは、値が倍増する";
        aquamarineGained = "獲得したアクアマリンは、値が倍増する";
        yellowShapphireGained = "獲得したイエローサファイアは、値が倍増する";
        pinkTourmalineGained = "獲得したピンクトルマリンは、値が倍増する";
        adventurineGained = "獲得したアベンチュリンは、値が倍増する";
        redRubyGained = "獲得した赤いルビーは、値が倍増する";
        diamondGained = "獲得したダイヤモンドは、値が倍増する";
        grandidieriteGained = "獲得したグランディエライトは、値が倍増する";
        violetCrystalGained = "獲得した紫水晶は、値が倍増する";
        akoyaPearlGained = "獲得したアコヤ真珠は、値が倍増する";
        purpleRupeeGained = "獲得したパープルルピーは、値が倍増する";
        emeraldGained = "獲得したエメラルドは、値が倍増する";
        greenDiamondGained = "獲得したグリーンダイヤモンドは、値が倍増する";
        fireOpalGained = "獲得したファイアオパールは、値が倍増する";
        gemSilicaGained = "獲得したジェムシリカは、値が倍増する";
        pinkPlortGained = "獲得したピンクのプロートは、値が倍増する";
        goldenSeaPearlGained = "獲得した黄金の海の真珠は、値が倍増する";
        kyaniteGained = "獲得したカヤナイトは、値が倍増する";
        blackOpalGained = "獲得したブラックオパールは、値が倍増する";
        painiteGained = "獲得したパイナイトは、値が倍増する";
        tanzaniteGained = "獲得したタンザナイトは、値が倍増する";
        astraliumGained = "獲得したアストラリウムは、値が倍増する";
        elysiumPrismGained = "獲得したエリジウムプリズムは、値が倍増する";
        aerthfireOpalGained = "獲得したアースファイアオパールは、値が倍増する";
        eldrichStarStoneGained = "獲得したエルドリッチ-スターストーンは、値が倍増する";
        chronolithChardGained = "獲得したクロノリスシャードは、値が倍増する";
        sideriumEssenceGained = "獲得したシデリウムエッセンスは、値が倍増する";
        quasariteGained = "獲得したクワダライトは、値が倍増する";
        radiantNovaGained = "獲得したラディアントノヴァストーンは、値が倍増する";
        soluniumShardGained = "獲得したソルニウムシャードは、値が倍増する";

        for (int i = 0; i < 34; i++)
        {
            treasureDropChanceText_text[i].font = japaneseBold; treasureDropChanceText_text[i].fontSize = 23;
            treasreDoubleText_text[i].font = japaneseBold; treasreDoubleText_text[i].fontSize = 17;
        }

        sellTreasureFor_text.font = japaneseBold; sellTreasureFor_text.fontSize = 22; sellTreasureFor_text.lineSpacing = -90;
        sellTreasureFor = "で売る"; sellGold = "金";

        #endregion

        #region Rare Treasures

        YOU_FOUND_A_SKULL = "あなたは頭蓋骨を見つけました！";
        YOU_FOUND_A_TROPHY = "あなたはトロフィーを見つけました！";
        YOU_FOUND_A_DEMONIC_SWORD = "あなたは悪魔の剣を見つけました！";
        YOU_FOUND_A_RING = "あなたは指輪を見つけました！";
        YOU_FOUND_A_STAR = "あなたは星を見つけました！";
        YOU_FOUND_A_CLOVER = "あなたはクローバーを見つけました！";
        YOU_FOUND_A_KINGS_CROWN = "あなたは王の王冠を見つけました！";
        YOU_FOUND_A_BOOK = "あなたは本を見つけました！";
        YOU_FOUND_A_GUITAR = "あなたはギターを見つけました！";
        YOU_FOUND_A_TALARIAN = "あなたはタラリア人を見つけました！";
        YOU_FOUND_A_STRANGE_RUNE = "あなたは奇妙なルーンを見つけました！";
        YOU_FOUND_A_BACKPACK = "あなたはバックパックを見つけました！";
        YOU_FOUND_A_SHIELD = "あなたは盾を見つけました！";
        YOU_FOUND_A_PILL_BOTTLE = "あなたは薬瓶を見つけました！";
        YOU_FOUND_A_MEDAL = "あなたはメダルを見つけました！";
        YOU_FOUND_A_COOKIE = "あなたはクッキーを見つけました！";
        YOU_FOUND_A_CHRISTMAS_PRESENT = "あなたはクリスマスプレゼントを見つけました！";
        YOU_FOUND_A_BATTLE_AXE = "あなたは戦いの斧を見つけました！";
        YOU_FOUND_A_100X_GOLD_COIN = "あなたは100倍の金貨を見つけました！";
        YOU_FOUND_A_SEALED_ENVELOPE = "あなたは封印された封筒を見つけました！";
        YOU_FOUND_A_STRANGE_POTION = "あなたは奇妙な薬を見つけました！";
        YOU_FOUND_A_SOUL_GEM = "あなたはソウルジェムを見つけました！";
        YOU_FOUND_AN_ANCIENT_SCROLL = "あなたは古代の巻物を見つけました！";
        YOU_FOUND_A_BRICK = "あなたはレンガを見つけました！";
        YOU_FOUND_A_RUBBER_CHICKEN = "あなたはゴムチキンを見つけました！";

        PIRATE_SKULL = "海賊スカル";
        DEMONIC_SWORD = "魔剣";
        MYSTIC_RING = "ミスティックリング";
        TROPHY = "トロフィー";
        FALLEN_STAR = "堕ちた星";
        CLOVER = "クローバー";
        KINGS_CROWN = "キングスクラウン";
        SPELL_BOOK = "スペルブック";
        GUITAR = "ギター";
        TALARIAN = "タラリア人";
        MYTHRUNE = "ミスルーン";
        EXPLORER_BACKPACK = "エクスプローラーバックパック";
        VIKING_SHIELD = "バイキングシールド";
        PILL_BOTTLE = "ピルボトル";
        VICTORY_MEDAL = "ビクトリーメダルL";
        COOKIE = "クッキー";
        CHRISTMAS_PRESENT = "クリスマスプレゼント";
        BATTLE_AXE = "バトルアックス";
        GOLD_COIN_100X = "100Xゴールドコイン";
        SEALED_ENVELOPE = "密封された封筒";
        STRANGE_POTION = "奇妙なポーション";
        SOUL_GEM = "ソウルジェム";
        ANCIENT_SCROLL = "古代の巻物";
        BRICK = "レンガ";
        RUBBER_CHICKEN = "ゴムチキン";


        skullSize = 18;
        demonicSwordSize = 27;
        mysticRingSize = 18;
        trophySize = 25;
        fallenStarSize = 21;
        cloverSize = 23;
        kingsCrownSize = 24;
        spellBookSize = 22;
        guitarSize = 29;
        talarianSize = 25;
        mythruneSize = 23;
        explorerBackpackSize = 12;
        rubberChickenSize = 22;
        brickSize = 30;
        ancientScrollSize = 22;
        soulGemSize = 22;
        strangePotionSize = 17;
        sealedEnvelopeSize = 20;
        goldCoin100XSize = 17;
        vikingShieldSize = 19;
        pillBottleSize = 24;
        victoryMedalSize = 18;
        cookieSize = 29;
        christmasPresentSize = 18;
        battleAxeSize = 22;

        pirateSkull_text.font = japaneseBold; pirateSkull_text.fontSize = skullSize;
        demonicSword_text.font = japaneseBold; demonicSword_text.fontSize = demonicSwordSize;
        mysticRing_text.font = japaneseBold; mysticRing_text.fontSize = mysticRingSize;
        trophy_text.font = japaneseBold; trophy_text.fontSize = trophySize;
        fallenStar_text.font = japaneseBold; fallenStar_text.fontSize = fallenStarSize;
        clover_text.font = japaneseBold; clover_text.fontSize = cloverSize;
        kingsCrown_text.font = japaneseBold; kingsCrown_text.fontSize = kingsCrownSize;
        spellBook_text.font = japaneseBold; spellBook_text.fontSize = spellBookSize;
        guitar_text.font = japaneseBold; guitar_text.fontSize = guitarSize;
        talarian_text.font = japaneseBold; talarian_text.fontSize = talarianSize;
        mythrune_text.font = japaneseBold; mythrune_text.fontSize = mythruneSize;
        explorerBackpack_text.font = japaneseBold; explorerBackpack_text.fontSize = explorerBackpackSize;
        vikingShield_text.font = japaneseBold; vikingShield_text.fontSize = vikingShieldSize;
        pillBottle_text.font = japaneseBold; pillBottle_text.fontSize = pillBottleSize;
        victoryMedal_text.font = japaneseBold; victoryMedal_text.fontSize = victoryMedalSize;
        cookie_text.font = japaneseBold; cookie_text.fontSize = cookieSize;
        christmasPresent_text.font = japaneseBold; christmasPresent_text.fontSize = christmasPresentSize;
        battleAxe_text.font = japaneseBold; battleAxe_text.fontSize = battleAxeSize;
        goldCoin100X_text.font = japaneseBold; goldCoin100X_text.fontSize = goldCoin100XSize;
        sealedEnvelope_text.font = japaneseBold; sealedEnvelope_text.fontSize = sealedEnvelopeSize;
        strangePotion_text.font = japaneseBold; strangePotion_text.fontSize = strangePotionSize;
        soulGem_text.font = japaneseBold; soulGem_text.fontSize = soulGemSize;
        ancientScroll_text.font = japaneseBold; ancientScroll_text.fontSize = ancientScrollSize;
        brick_text.font = japaneseBold; brick_text.fontSize = brickSize;
        rubberChicken_text.font = japaneseBold; rubberChicken_text.fontSize = rubberChickenSize;



        if (RareTreasures.skullFound == 1)
        {
            pirateSkull_text.text = PIRATE_SKULL;
        }
        if (RareTreasures.swordFound == 1)
        {
            demonicSword_text.text = DEMONIC_SWORD;
        }
        if (RareTreasures.ringFound == 1)
        {
            mysticRing_text.text = MYSTIC_RING;
        }
        if (RareTreasures.trophyFound == 1)
        {
            trophy_text.text = TROPHY;
        }
        if (RareTreasures.starFound == 1)
        {
            fallenStar_text.text = FALLEN_STAR;
        }
        if (RareTreasures.cloverFound == 1)
        {
            clover_text.text = CLOVER;
        }
        if (RareTreasures.crownFound == 1)
        {
            kingsCrown_text.text = KINGS_CROWN;
        }
        if (RareTreasures.bookFound == 1)
        {
            spellBook_text.text = SPELL_BOOK;
        }
        if (RareTreasures.guitarFOund == 1)
        {
            guitar_text.text = GUITAR;
        }
        if (RareTreasures.talarianFound == 1)
        {
            talarian_text.text = TALARIAN;
        }
        if (RareTreasures.runeFound == 1)
        {
            mythrune_text.text = MYTHRUNE;
        }
        if (RareTreasures.backPackFound == 1)
        {
            explorerBackpack_text.text = EXPLORER_BACKPACK;
        }
        if (RareTreasures.shieldFound == 1)
        {
            vikingShield_text.text = VIKING_SHIELD;
        }
        if (RareTreasures.pillBottleFound == 1)
        {
            pillBottle_text.text = PILL_BOTTLE;
        }
        if (RareTreasures.medalFound == 1)
        {
            victoryMedal_text.text = VICTORY_MEDAL;
        }
        if (RareTreasures.cookieFound == 1)
        {
            cookie_text.text = COOKIE;
        }
        if (RareTreasures.presentFound == 1)
        {
            christmasPresent_text.text = CHRISTMAS_PRESENT;
        }
        if (RareTreasures.axeFound == 1)
        {
            battleAxe_text.text = BATTLE_AXE;
        }
        if (RareTreasures.coin100XFound == 1)
        {
            goldCoin100X_text.text = GOLD_COIN_100X;
        }
        if (RareTreasures.envelopeFound == 1)
        {
            sealedEnvelope_text.text = SEALED_ENVELOPE;
        }
        if (RareTreasures.potionFound == 1)
        {
            strangePotion_text.text = STRANGE_POTION;
        }
        if (RareTreasures.soulGemFound == 1)
        {
            soulGem_text.text = SOUL_GEM;
        }
        if (RareTreasures.scrollFound == 1)
        {
            ancientScroll_text.text = ANCIENT_SCROLL;
        }
        if (RareTreasures.brickFound == 1)
        {
            brick_text.text = BRICK;
        }
        if (RareTreasures.chickenFound == 1)
        {
            rubberChicken_text.text = RUBBER_CHICKEN;
        }

        foundRareTreasurePopUp_text.lineSpacing = -40;

        foundRareTreasurePopUp_text.font = japaneseBoldOutline; foundRareTreasurePopUp_text.fontSize = 30;

        pirateSkull_text.lineSpacing = -40;
        demonicSword_text.lineSpacing = -40;
        mysticRing_text.lineSpacing = -40;
        trophy_text.lineSpacing = -40;
        fallenStar_text.lineSpacing = -40;
        clover_text.lineSpacing = -40;
        kingsCrown_text.lineSpacing = -40;
        spellBook_text.lineSpacing = -40;
        guitar_text.lineSpacing = -40;
        talarian_text.lineSpacing = -40;
        mythrune_text.lineSpacing = -40;
        explorerBackpack_text.lineSpacing = -40;
        vikingShield_text.lineSpacing = -40;
        pillBottle_text.lineSpacing = -40;
        victoryMedal_text.lineSpacing = -40;
        cookie_text.lineSpacing = -40;
        christmasPresent_text.lineSpacing = -40;
        battleAxe_text.lineSpacing = -40;
        goldCoin100X_text.lineSpacing = -40;
        sealedEnvelope_text.lineSpacing = -40;
        strangePotion_text.lineSpacing = -40;
        soulGem_text.lineSpacing = -40;
        ancientScroll_text.lineSpacing = -40;
        brick_text.lineSpacing = -40;
        rubberChicken_text.lineSpacing = -40;


        chooseText1_text.font = japaneseBoldOutline; chooseText1_text.fontSize = 25f;
        chooseText2_text.font = japaneseBoldOutline; chooseText2_text.fontSize = 25f;
        chooseText3_text.font = japaneseBoldOutline; chooseText3_text.fontSize = 25f;
        chooseText4_text.font = japaneseBoldOutline; chooseText4_text.fontSize = 25f;
        chooseText5_text.font = japaneseBoldOutline; chooseText5_text.fontSize = 25f;
        chooseText6_text.font = japaneseBoldOutline; chooseText6_text.fontSize = 23f;
        chooseText7_text.font = japaneseBoldOutline; chooseText7_text.fontSize = 25f;


        price200SkillPoints_text.font = japaneseSemiBold; price200SkillPoints_text.fontSize = 12.6f;
        priceEqual = "価格=";
        skillPoints200 = "200ポイント";
        if (PlayerLevel.skillPoints >= 200)
        {
            price200SkillPoints_text.text = Localization.priceEqual + " <color=green>" + Localization.skillPoints200;
        }
        if (PlayerLevel.skillPoints < 200)
        {
            price200SkillPoints_text.text = Localization.priceEqual + " <color=red>" + Localization.skillPoints200;
        }
        #endregion

        #region Treasure Chests
        ON = "オン"; OFF = "オフ";

        GoldCoinsDrop = "金貨ドロップ:";
        goldCoinValue = "ゴールドコイン値:";
        XPDrop = "XPドロップ";

        chestNumber = "チェスト"; chestNO = "号";

        reinforcedChestChance1 = "強化された胸のチャンス"; reinforcedChestChance2 = "";

        WoodenChest = "木製チェスト";
        TimberwoodChest = "ティンバーウッドチェスト";
        RockboundChest = "ロックバウンドチェスト";
        BronzeChest = "ブロンズチェスト";
        SequoiaChest = "セコイア-チェスト";
        IronboundChest = "アイアンバウンドチェスト";
        StoneshieldChest = "石の盾の箱";
        OceanChest = "オーシャンチェスト";
        PoisonousChest = "毒のある胸";
        GoldenChest = "黄金の胸";
        DesertChest = "砂漠の胸";
        PirateChest = "海賊の胸";
        CrystalChest = "クリスタルチェスト";
        CelestialChest = "天の胸";
        PhantomChest = "ファントムチェスト";
        PrismaticChest = "角柱状の胸";
        AquaticChest = "アクアティックチェスト";
        WindwalkersChest = "ウインドウォーカーの胸";
        EnchantedChest = "魅惑の胸";
        RoyalChest = "ロイヤルチェスト";
        ArcaneChest = "秘儀の胸";
        GrandioseChest = "壮大な胸";
        LuxuriousGoldenChest = "豪華な黄金の胸";
        SacredChest = "セイクリッド-チェスト";
        EternitysEmbraceChest = "永遠の抱擁の胸";
        ForgottenChest = "忘れられた胸";
        LivingLuminousChest = "リビングルミナス胸";
        FortressOfWealth = "富の要塞";
        FortifiedTimberChest = "強化された材木の箱";
        RadiantFrostlock = "ラディアントフロストロック";
        InfernoEmbracedChest = "インフェルノ-抱かれた胸";
        DeathChest = "デス-チェスト";
        AlienChest = "エイリアンチェスト";
        CraftsmansReliquary = "職人の聖遺物箱";
        HellfireGuardianChest = "ヘルファイアガーディアンチェスト";
        GhastlySoulHoardChest = "恐ろしい魂-買いだめの胸";
        HighTechCache = "ハイテクキャッシュ";
        EliteHackersStrongbox = "エリートハッカーのストロングボックス";
        CollectorsVault = "コレクターズ-ヴォールト";
        ExquisiteAzureRadianceChest = "絶妙な紺碧の輝きの胸";

        TimberwoodChestUnlocked = "木製チェストのロック解除";
        RockboundChestUnlocked = "ティンバーウッドチェストのロック解除";
        BronzeChestUnlocked = "ロックバウンドチェストのロック解除";
        SequoiaChestUnlocked = "ブロンズチェストのロック解除";
        IronboundChestUnlocked = "アイアンバウンドチェストのロック解除";
        StoneshieldChestUnlocked = "石の盾の箱のロック解除";
        OceanChestUnlocked = "オーシャンチェストのロック解除";
        PoisonousChestUnlocked = "毒のある胸のロック解除";
        GoldenChestUnlocked = "黄金の胸のロック解除";
        DesertChestUnlocked = "砂漠の胸のロック解除";
        PirateChestUnlocked = "海賊の胸のロック解除";
        CrystalChestUnlocked = "クリスタルチェストのロック解除";
        CelestialChestUnlocked = "天の胸のロック解除";
        PhantomChestUnlocked = "ファントムチェストのロック解除";
        PrismaticChestUnlocked = "角柱状の胸のロック解除";
        AquaticChestUnlocked = "アクアティックチェストのロック解除";
        WindwalkersChestUnlocked = "ウインドウォーカーの胸のロック解除";
        EnchantedChestUnlocked = "魅惑の胸のロック解除";
        RoyalChestUnlocked = "ロイヤルチェストのロック解除";
        ArcaneChestUnlocked = "秘儀の胸のロック解除";
        GrandioseChestUnlocked = "壮大な胸のロック解除";
        LuxuriousGoldenChestUnlocked = "豪華な黄金の胸のロック解除";
        SacredChestUnlocked = "セイクリッド-チェストのロック解除";
        EternitysEmbraceChestUnlocked = "永遠の抱擁の胸のロック解除";
        ForgottenChestUnlocked = "忘れられた胸のロック解除";
        LivingLuminousChestUnlocked = "リビングルミナス胸のロック解除";
        FortressOfWealthUnlocked = "富の要塞のロック解除";
        FortifiedTimberChestUnlocked = "強化された材木の箱のロック解除";
        RadiantFrostlockUnlocked = "ラディアントフロストロックのロック解除";
        InfernoEmbracedChestUnlocked = "インフェルノ-抱かれた胸のロック解除";
        DeathChestUnlocked = "デス-チェストのロック解除";
        AlienChestUnlocked = "エイリアンチェストのロック解除";
        CraftsmansReliquaryUnlocked = "職人の聖遺物箱のロック解除";
        HellfireGuardianChestUnlocked = "ヘルファイアガーディアンチェストのロック解除";
        GhastlySoulHoardChestUnlocked = "恐ろしい魂-買いだめの胸のロック解除";
        HighTechCacheUnlocked = "ハイテクキャッシュのロック解除";
        EliteHackersStrongboxUnlocked = "エリートハッカーのストロングボックスのロック解除";
        CollectorsVaultUnlocked = "コレクターズ-ヴォールトのロック解除";
        ExquisiteAzureRadianceChestUnlocked = "絶妙な紺碧の輝きの胸のロック解除";

        chestPrice_text.font = japaneseBold; chestPrice_text.fontSize = 25;
        chestHP_text.font = japaneseBold; chestHP_text.fontSize = 34;
        autoPurchaseONOFF_text.font = japaneseBold; autoPurchaseONOFF_text.fontSize = 40;
        chestHoverName_text.font = japaneseBoldOutline; chestHoverName_text.fontSize = 25;
        chestNO_text.font = japaneseMediumOutline; chestNO_text.fontSize = 30;
        chestXPAmount_text.font = japaneseMediumOutline; chestXPAmount_text.fontSize = 19;
        chestGoldCoins_text.font = japaneseMediumOutline; chestGoldCoins_text.fontSize = 19;
        chestGoldAmount_text.font = japaneseMediumOutline; chestGoldAmount_text.fontSize = 19;
        chestReinforcedChance.font = japaneseMediumOutline; chestReinforcedChance.fontSize = 19;
        chestPurchasedName_text.font = japaneseSemiBold; chestPurchasedName_text.fontSize = 45;

        reinforcedHoverHealth_text.font = japaneseRegular; reinforcedHoverHealth_text.fontSize = 20;
        reinforcedHoverGold_text.font = japaneseRegular; reinforcedHoverGold_text.fontSize = 20;
        reinforcedHoverXP_text.font = japaneseRegular; reinforcedHoverXP_text.fontSize = 20;

        enchantedGoldenHoverHealth_text.font = japaneseRegular; enchantedGoldenHoverHealth_text.fontSize = 17;
        enchantedGoldenHoverTreasures_text.font = japaneseRegular; enchantedGoldenHoverTreasures_text.fontSize = 17;
        enchantedGoldenHoverXP_text.font = japaneseRegular; enchantedGoldenHoverXP_text.fontSize = 17;

        bossChestHoverHealth_text.font = japaneseRegular; bossChestHoverHealth_text.fontSize = 17;
        bossChestHoverGoldValue_text.font = japaneseRegular; bossChestHoverGoldValue_text.fontSize = 17;
        bossChestHoverGoldCoins_text.font = japaneseRegular; bossChestHoverGoldCoins_text.fontSize = 17;
        bossChestHoverXP_text.font = japaneseRegular; bossChestHoverXP_text.fontSize = 17;
        #endregion

        #region Prestige

        prestigeKeyChance1 = "プレステージキードロップチャンス"; prestigeKeyChance2 = "%";
        prestieChestKey1 = ""; prestieChestKey2 = "%プレステージチェストドロップチャンス";

        FindThePrestigeKeyandChest = "プレステージキーとプレステージチェストを探す";
        youFoundThePrestigeKetAndChest = "あなたはプレステージキーとプレステージチェストを見つけました！";

        youFoundPrestigeKey = "あなたはプレステージキーを見つけました！";
        youFoundPrestigeChest = "あなたはプレステージの胸を見つけました！";

        nextLevelHover = "次のレベル=+"; skillPointsHover = "スキルポイント";

        choseItemToStartWith = "で始まる1つの項目を選択してください";
        chooseItemsToStartWith2 = "で始まる2つの項目を選択してください";
        chooseItemsToStartWith3 = "で始まる3つの項目を選択してください";
        chooseItemsToStartWith5 = "で始まる5つの項目を選択してください";


        findThePrestigeKeyAncChest_text.font = japaneseBoldOutline; findThePrestigeKeyAncChest_text.fontSize = 14;


        if (SpawnRewards.prestigeKeyFound == 0)
        {
            findThePrestigeKeyAncChest_text.text = FindThePrestigeKeyandChest;
        }
        if (SpawnRewards.prestigeChestFound == 0)
        {
            findThePrestigeKeyAncChest_text.text = FindThePrestigeKeyandChest;
        }
        if (SpawnRewards.prestigeChestFound == 1 && SpawnRewards.prestigeKeyFound == 1)
        {
            findThePrestigeKeyAncChest_text.text = youFoundThePrestigeKetAndChest;
        }

        prestigeKeyDropChance_text.font = japaneseBoldOutline; prestigeKeyDropChance_text.fontSize = 16;
        prestigeChestDropChance_text.font = japaneseBoldOutline; prestigeChestDropChance_text.fontSize = 16;
        prestigeKeyDropChance_text.text = Localization.prestigeKeyChance1 + 0.017 * (UnlockChests.timesPurchasedChests + 1) + Localization.prestigeKeyChance2;
        prestigeChestDropChance_text.text = Localization.prestieChestKey1 + 0.017 * (UnlockChests.timesPurchasedChests + 1) + Localization.prestieChestKey2;

        nextLeveEqualSkillPoints_text.font = japaneseSemiBold; nextLeveEqualSkillPoints_text.fontSize = 55;
        nextLeveEqualSkillPoints_text.text = Localization.nextLevelHover + "<color=green>+" + ((PlayerLevel.playerLevel / 5) + 1) + "<color=white>" + Localization.skillPointsHover;

        chooseItemToStartWith_text.font = japaneseMediumOutline; chooseItemToStartWith_text.fontSize = 34;
        #endregion

        #region Other
        level = "レベル";
        xpNoPercent = "経験値";
        crit = "クリティカル!";

        totalGold_text.font = japaneseRegular; totalGold_text.fontSize = 46;
        levelText_text.font = japaneseMedium; levelText_text.fontSize = 36; levelText_text.text = "レベル" + PlayerLevel.playerLevel;
        xpNeededText_text.font = japaneseLight; xpNeededText_text.fontSize = 15;
        activeDamageAmount_text.font = japaneseBold; activeDamageAmount_text.fontSize = 20f;
        passiveDamageAmount_text.font = japaneseBold; passiveDamageAmount_text.fontSize = 20f;
        acitveDamagePrice_text.font = japaneseBold; acitveDamagePrice_text.fontSize = 18f;
        passiveDamagePrice_text.font = japaneseBold; passiveDamagePrice_text.fontSize = 18f;
        activeDamageLEVELAmount_text.font = japaneseBold; activeDamageLEVELAmount_text.fontSize = 30f;
        passiveLEVELAmount_text.font = japaneseBold; passiveLEVELAmount_text.fontSize = 30f;
        passiveDamageUPGRADE_text.font = japaneseBold; passiveDamageUPGRADE_text.fontSize = 20f;
        activeDamageUPGRADE_text.font = japaneseBold; activeDamageUPGRADE_text.fontSize = 20f;

        youOpened.font = japaneseBoldOutline; youOpened.fontSize = 40; youOpened.lineSpacing = -70;
        timeGoneTotal.font = japaneseBoldOutline; timeGoneTotal.fontSize = 40;

        damageUnderChest.font = japaneseMedium; damageUnderChest.fontSize = 6;
        #endregion

        ChangeAllText();
    }
    #endregion

    #region Chinese  
    public void ChineseLanguage()
    {
        JapaneseLanguageChosen = 0;
        RussianLanguageChosen = 0;
        EnglishLanguageChosen = 0;
        ChineseLanguageChosen = 1;
        KoreanLanguageChosen = 0;

        if (PlaceMobileButtons.isMobile == true) { ChangeMobileText(); }

        PlayerPrefs.SetInt("SaveEnglish", EnglishLanguageChosen);
        PlayerPrefs.SetInt("SaveRussian", RussianLanguageChosen);
        PlayerPrefs.SetInt("SaveJapanese", JapaneseLanguageChosen);
        PlayerPrefs.SetInt("SaveChinese", ChineseLanguageChosen);
        PlayerPrefs.SetInt("SaveKorean", KoreanLanguageChosen);

        #region TotalGold Strings
        Million = "百万";
        Billion = "十亿";
        Trillion = "一兆";
        Quadrillion = "千兆";
        Quintillion = "百京";
        Sextillion = "十垓";
        Septillion = "姊";
        Octillion = "千姊";
        Nonillion = "百穰";
        Decillion = "十沟";
        Undecillion = "涧";
        Duodecillion = "千涧";
        Tredecillion = "百正";
        Quattuordecillion = "十载";
        Quindecillion = "极";
        Sexdecillion = "千极";
        Septendecillion = "百恒河沙";
        Octodecillion = "十阿僧只";
        Novemdecillion = "那由它";
        Vigintillion = "千那由它";
        Unvigintillion = "百不可思议";
        Duovigintillion = "十无量";
        Trevigintillion = "大数";

        MillionShort = "百万";
        BillionShort = "十亿";
        TrillionShort = "一兆";
        QuadrillionShort = "千兆";
        QuintillionShort = "百京";
        SextillionShort = "十垓";
        SeptillionShort = "姊";
        OctillionShort = "千姊";
        NonillionShort = "百穰";
        DecillionShort = "十沟";
        UndecillionShort = "涧";
        DuodecillionShort = "千涧";
        TredecillionShort = "百正";
        QuattuordecillionShort = "十载";
        QuindecillionShort = "极";
        SexdecillionShort = "千极";
        SeptendecillionShort = "百恒河沙";
        OctodecillionShort = "十阿僧只";
        NovemdecillionShort = "那由它";
        VigintillionShort = "千那由它";
        UnvigintillionShort = "百不可思议";
        DuovigintillionShort = "十无量";
        TrevigintillionShort = "大数";
        #endregion

        #region Pluss Buffs Strings
        gold = "金币";
        goldPercentString = "% 金币";

        clickDamage = "主动伤害";
        activeDamageTop = "主动伤害";
        dps = "每秒伤害";
        passiveDamageString = "% 被动伤害";
        activeDamageScring = "% 主动伤害";
        critChanceString = "% 暴击几率";
        critDamageString = "% 暴击伤害";

        damagePercent = "% 伤害";
        xp = "% 经验";
        treasureDropChance = "% 宝藏掉落几率";
        goldCoinsDrop = "金币掉落";

        friendlyMimic = "友好模仿";
        evilMimic = "邪恶模仿";
        secondsMimic = "秒";

        rareTreasureDropChance = "+稀有宝藏掉落几率";
        #endregion



        #region Settings Text
        settings_text.text = "设置"; settings_text.font = chineseFont; settings_text.fontSize = 36;

        general_text.text = "常规"; general_text.font = chineseFont; general_text.fontSize = 19;

        info_text.text = "资讯"; info_text.font = chineseFont; info_text.fontSize = 20;

        music_text.text = "音乐"; music_text.font = chineseFont; music_text.fontSize = 25;

        sound_text.text = "音效"; sound_text.font = chineseFont; sound_text.fontSize = 24;

        miniChestAndMimicChestSpawnSound_text.text = "小宝箱和模仿宝箱生成音效"; miniChestAndMimicChestSpawnSound_text.font = chineseFont; miniChestAndMimicChestSpawnSound_text.fontSize = 16;

        mimicChestSpawning_text.text = "模仿宝箱生成"; mimicChestSpawning_text.font = chineseFont; mimicChestSpawning_text.fontSize = 20;

        fullscreen_text.text = "全屏"; fullscreen_text.font = chineseFont; fullscreen_text.fontSize = 15;

        onFullScreen_text.text = "开启"; onFullScreen_text.font = chineseFont; onFullScreen_text.fontSize = 30;

        offFullScreen_text.text = "关闭"; offFullScreen_text.font = chineseFont; offFullScreen_text.fontSize = 30;

        onMimicSpawn_text.text = "开启"; onMimicSpawn_text.font = chineseFont; onMimicSpawn_text.fontSize = 30;

        offMimicSpawn_text.text = "关闭"; offMimicSpawn_text.font = chineseFont; offMimicSpawn_text.fontSize = 30;

        onMiniAndMimicSound_text.text = "开启"; onMiniAndMimicSound_text.font = chineseFont; onMiniAndMimicSound_text.fontSize = 30;

        offMiniAndMimicSound_text.text = "关闭"; offMiniAndMimicSound_text.font = chineseFont; offMiniAndMimicSound_text.fontSize = 30;

        resolution_text.text = "分辨率"; resolution_text.font = chineseFont; resolution_text.fontSize = 19;

        exit_text.text = "退出"; exit_text.font = chineseFont; exit_text.fontSize = 60;

        save_text.text = "保存"; save_text.font = chineseFont; save_text.fontSize = 36;

        gameSavesEvery15Seconds_text.text = "游戏每15秒自动保存"; gameSavesEvery15Seconds_text.font = chineseFont; gameSavesEvery15Seconds_text.fontSize = 11;

        cantSaveDuringPrestige_text.text = "声望阶段无法保存"; cantSaveDuringPrestige_text.font = chineseFont; cantSaveDuringPrestige_text.fontSize = 20;

        resetGame_text.text = "重置游戏"; resetGame_text.font = chineseFont; resetGame_text.fontSize = 19; resetGame_text.lineSpacing = -90;

        discord_text.text = "Discord"; discord_text.font = chineseFont; discord_text.fontSize = 32;

        numberOfCoinsAndTreasuresOnScreen_text.text = "屏幕上的金币和宝藏达到指定数量后自动收集"; numberOfCoinsAndTreasuresOnScreen_text.font = chineseFont; numberOfCoinsAndTreasuresOnScreen_text.fontSize = 16;

        reinforcedChests_text.text = "强化宝箱"; reinforcedChests_text.font = chineseFont; reinforcedChests_text.fontSize = 17;

        reinforcedChestsDescription_text.text = "每个宝箱都有机会成为强化版本，而强化概率取决于购买的宝箱种类。"; reinforcedChestsDescription_text.font = chineseFont; reinforcedChestsDescription_text.fontSize = 10;


        enchantedGoldenChests_text.text = "强化金宝箱"; enchantedGoldenChests_text.font = chineseFont; enchantedGoldenChests_text.fontSize = 17;

        bossChests_text.text = "首领宝箱"; bossChests_text.font = chineseFont; bossChests_text.fontSize = 17;

        musicBy_text.text = "音乐由Kevin MacLeod - Arpent创作"; musicBy_text.font = chineseFont; musicBy_text.fontSize = 15;

        developerInfo_text.text = "《宝藏宝箱点击器》由Simon Eftestøl开发"; developerInfo_text.font = chineseFont; developerInfo_text.fontSize = 15;

        resetConfirmation_text.text = "您是否要重置一切？游戏将从头开始。"; resetConfirmation_text.font = chineseFont; resetConfirmation_text.fontSize = 20;

        yes_text.text = "是"; yes_text.font = chineseFont; yes_text.fontSize = 55;

        no_text.text = "否"; no_text.font = chineseFont; no_text.fontSize = 55;

        gameSaves_Text.text = "游戏已保存！"; gameSaves_Text.font = chineseFont; gameSaves_Text.fontSize = 15;
        #endregion

        #region stats
        stats_text.text = "数据"; stats_text.font = chineseFont; stats_text.fontSize = 40;
        goldAndTreasures_text.text = "黄金和宝藏"; goldAndTreasures_text.font = chineseFont; goldAndTreasures_text.fontSize = 45;
        chests_text.text = "宝箱"; chests_text.font = chineseFont; chests_text.fontSize = 55;
        damage_text.text = "伤害"; damage_text.font = chineseFont; damage_text.fontSize = 55;
        items.text = "物品"; items.font = chineseFont; items.fontSize = 55;
        buffsAndPrestige_text.text = "增益和声望"; buffsAndPrestige_text.font = chineseFont; buffsAndPrestige_text.fontSize = 45;
        #endregion

        #region Achievements
        achievements_text.text = "成就"; achievements_text.font = chineseFont; achievements_text.fontSize = 40;
        drop25GoldCoins_text.text = "从宝箱掉落25个金币"; drop25GoldCoins_text.font = chineseFont; drop25GoldCoins_text.fontSize = 24;
        drop1000GoldCoins_text.text = "从宝箱掉落1000个金币"; drop1000GoldCoins_text.font = chineseFont; drop1000GoldCoins_text.fontSize = 24;
        drop100000GoldCoins_text.text = "从宝箱掉落100,000个金币"; drop100000GoldCoins_text.font = chineseFont; drop100000GoldCoins_text.fontSize = 24;
        drop1MillionGoldCoins_text.text = "从宝箱掉落1百万个金币"; drop1MillionGoldCoins_text.font = chineseFont; drop1MillionGoldCoins_text.fontSize = 24;
        total100Gold_text.text = "拥有总计100个金币"; total100Gold_text.font = chineseFont; total100Gold_text.fontSize = 24;
        total100000Gold_text.text = "拥有总计100,000个金币"; total100000Gold_text.font = chineseFont; total100000Gold_text.fontSize = 24;
        total1MillionGold_text.text = "拥有总计1百万个金币"; total1MillionGold_text.font = chineseFont; total1MillionGold_text.fontSize = 24;
        total1BillionGold_text.text = "拥有总计1十亿个金币"; total1BillionGold_text.font = chineseFont; total1BillionGold_text.fontSize = 24;
        total1TrillionGold_text.text = "拥有总计1兆个金币"; total1TrillionGold_text.font = chineseFont; total1TrillionGold_text.fontSize = 24;

        //10
        total1QuadrillionGold_text.text = "拥有总计1千兆个金币"; total1QuadrillionGold_text.font = chineseFont; total1QuadrillionGold_text.fontSize = 24;
        total1QuintillionGold_text.text = "拥有总计1百京个金币"; total1QuintillionGold_text.font = chineseFont; total1QuintillionGold_text.fontSize = 24;
        total1SextillionGold_text.text = "拥有总计1十垓个金币"; total1SextillionGold_text.font = chineseFont; total1SextillionGold_text.fontSize = 24;
        total1SeptillionGold_text.text = "拥有总计1姊个金币"; total1SeptillionGold_text.font = chineseFont; total1SeptillionGold_text.fontSize = 24;
        total1OctillionGold_text.text = "拥有总计1千姊个金币"; total1OctillionGold_text.font = chineseFont; total1OctillionGold_text.fontSize = 24;
        total1NonillionGold_text.text = "拥有总计1百穰个金币"; total1NonillionGold_text.font = chineseFont; total1NonillionGold_text.fontSize = 24;
        total1DecillionGold_text.text = "拥有总计1十沟个金币"; total1DecillionGold_text.font = chineseFont; total1DecillionGold_text.fontSize = 24;
        total1NovemdecillionGold_text.text = "拥有总计1那由它个金币"; total1NovemdecillionGold_text.font = chineseFont; total1NovemdecillionGold_text.fontSize = 24;
        drop5XGoldCoin_text.text = "从宝箱掉落5倍金币"; drop5XGoldCoin_text.font = chineseFont; drop5XGoldCoin_text.fontSize = 24;
        drop1000_5XGoldCoins_text.text = "从宝箱掉落1000个5倍金币"; drop1000_5XGoldCoins_text.font = chineseFont; drop1000_5XGoldCoins_text.fontSize = 24;

        //20
        drop50000_5XGoldCoins_text.text = "从宝箱掉落50000个5倍金币"; drop50000_5XGoldCoins_text.font = chineseFont; drop50000_5XGoldCoins_text.fontSize = 24;
        drop10XGoldCoin_text.text = "从宝箱掉落10倍金币"; drop10XGoldCoin_text.font = chineseFont; drop10XGoldCoin_text.fontSize = 24;
        drop1000_10XGoldCoins_text.text = "从宝箱掉落1000个10倍金币"; drop1000_10XGoldCoins_text.font = chineseFont; drop1000_10XGoldCoins_text.fontSize = 24;
        drop15000_10XGoldCoins_text.text = "从宝箱掉落15000个10倍金币"; drop15000_10XGoldCoins_text.font = chineseFont; drop15000_10XGoldCoins_text.fontSize = 24;
        spawn10GoldCoinsFromClicks_text.text = "点击生成10个金币"; spawn10GoldCoinsFromClicks_text.font = chineseFont; spawn10GoldCoinsFromClicks_text.fontSize = 24;
        spawn100GoldCoinsFromClicks_text.text = "点击生成100个金币"; spawn100GoldCoinsFromClicks_text.font = chineseFont; spawn100GoldCoinsFromClicks_text.fontSize = 24;
        spawn1000GoldCoinsFromClicks_text.text = "点击生成1000个金币"; spawn1000GoldCoinsFromClicks_text.font = chineseFont; spawn1000GoldCoinsFromClicks_text.fontSize = 24;
        oneTreasureDropped_text.text = "从宝箱掉落1个宝藏"; oneTreasureDropped_text.font = chineseFont; oneTreasureDropped_text.fontSize = 24;
        hundredTreasuresDropped_text.text = "从宝箱掉落100个宝藏"; hundredTreasuresDropped_text.font = chineseFont; hundredTreasuresDropped_text.fontSize = 24;
        thousandTreasuresDropped_text.text = "从宝箱掉落1000个宝藏"; thousandTreasuresDropped_text.font = chineseFont; thousandTreasuresDropped_text.fontSize = 24;
        tenThousandTreasuresDropped_text.text = "从宝箱掉落10000个宝藏"; tenThousandTreasuresDropped_text.font = chineseFont; tenThousandTreasuresDropped_text.fontSize = 24;
        fiftyThousandTreasuresDropped_text.text = "从宝箱掉落50000个宝藏"; fiftyThousandTreasuresDropped_text.font = chineseFont; fiftyThousandTreasuresDropped_text.fontSize = 24;

        //30 (Continued from 20)
        hundredCommonTreasures_text.text = "从宝箱掉落100个普通宝藏"; hundredCommonTreasures_text.font = chineseFont; hundredCommonTreasures_text.fontSize = 22;
        hundredUncommonTreasures_text.text = "从宝箱掉落100个非常宝藏"; hundredUncommonTreasures_text.font = chineseFont; hundredUncommonTreasures_text.fontSize = 22;
        hundredRareTreasures_text.text = "从宝箱掉落100个稀有宝藏"; hundredRareTreasures_text.font = chineseFont; hundredRareTreasures_text.fontSize = 22;
        hundredVeryRareTreasures_text.text = "从宝箱掉落100个非常稀有宝藏"; hundredVeryRareTreasures_text.font = chineseFont; hundredVeryRareTreasures_text.fontSize = 22;
        hundredExtremelyRareTreasures_text.text = "从宝箱掉落100个极其稀有宝藏"; hundredExtremelyRareTreasures_text.font = chineseFont; hundredExtremelyRareTreasures_text.fontSize = 24;
        hundredLegendaryTreasures_text.text = "从宝箱掉落100个传奇宝藏"; hundredLegendaryTreasures_text.font = chineseFont; hundredLegendaryTreasures_text.fontSize = 24;
        spawn10TreasuresFromClicks_text.text = "点击生成10个宝藏"; spawn10TreasuresFromClicks_text.font = chineseFont; spawn10TreasuresFromClicks_text.fontSize = 24;
        spawn100TreasuresFromClicks_text.text = "点击生成100个宝藏"; spawn100TreasuresFromClicks_text.font = chineseFont; spawn100TreasuresFromClicks_text.fontSize = 24;
        spawn1000TreasuresFromClicks_text.text = "点击生成1000个宝藏"; spawn1000TreasuresFromClicks_text.font = chineseFont; spawn1000TreasuresFromClicks_text.fontSize = 24;
        hundredTreasuresDoubled_text.text = "100个宝藏翻倍"; hundredTreasuresDoubled_text.font = chineseFont; hundredTreasuresDoubled_text.fontSize = 24;

        //40 (Continued from 30)
        find1RareTreasure_text.text = "发现1个稀有宝藏"; find1RareTreasure_text.font = chineseFont; find1RareTreasure_text.fontSize = 24;
        find3RareTreasures_text.text = "发现3个稀有宝藏"; find3RareTreasures_text.font = chineseFont; find3RareTreasures_text.fontSize = 24;
        find5RareTreasures_text.text = "发现5个稀有宝藏"; find5RareTreasures_text.font = chineseFont; find5RareTreasures_text.fontSize = 24;
        find13RareTreasures_text.text = "发现13个稀有宝藏"; find13RareTreasures_text.font = chineseFont; find13RareTreasures_text.fontSize = 24;
        findAll25RareTreasures_text.text = "找到所有25个稀有宝藏"; findAll25RareTreasures_text.font = chineseFont; findAll25RareTreasures_text.fontSize = 24;
        findTheCookie_text.text = "找到饼干！"; findTheCookie_text.font = chineseFont; findTheCookie_text.fontSize = 24;
        cookieClicker_text.text = "饼干点击大师！"; cookieClicker_text.font = chineseFont; cookieClicker_text.fontSize = 24;
        prestige_text.text = "声望"; prestige_text.font = chineseFont; prestige_text.fontSize = 24;
        prestige5Times_text.text = "声望5次"; prestige5Times_text.font = chineseFont; prestige5Times_text.fontSize = 24;
        prestige15Times_text.text = "声望15次"; prestige15Times_text.font = chineseFont; prestige15Times_text.fontSize = 24;

        //50 (Continued from 40)
        purchase5PrestigeUpgrades_text.text = "购买5个声望升级"; purchase5PrestigeUpgrades_text.font = chineseFont; purchase5PrestigeUpgrades_text.fontSize = 24;
        purchase15PrestigeUpgrades_text.text = "购买15个声望升级"; purchase15PrestigeUpgrades_text.font = chineseFont; purchase15PrestigeUpgrades_text.fontSize = 24;
        purchase35PrestigeUpgrades_text.text = "购买35个声望升级"; purchase35PrestigeUpgrades_text.font = chineseFont; purchase35PrestigeUpgrades_text.fontSize = 24;
        purchase60PrestigeUpgrades_text.text = "购买60个声望升级"; purchase60PrestigeUpgrades_text.font = chineseFont; purchase60PrestigeUpgrades_text.fontSize = 24;
        purchaseAllPrestigeUpgrades_text.text = "购买所有声望升级"; purchaseAllPrestigeUpgrades_text.font = chineseFont; purchaseAllPrestigeUpgrades_text.fontSize = 24;
        purchaseAllPrestigeClickerUpgrades_text.text = "购买所有声望点击升级"; purchaseAllPrestigeClickerUpgrades_text.font = chineseFont; purchaseAllPrestigeClickerUpgrades_text.fontSize = 24;
        purchaseAllPrestigeLoungerUpgrades_text.text = "购买所有声望休息升级"; purchaseAllPrestigeLoungerUpgrades_text.font = chineseFont; purchaseAllPrestigeLoungerUpgrades_text.fontSize = 24;
        purchaseAllPrestigePirateUpgrades_text.text = "购买所有声望海盗升级"; purchaseAllPrestigePirateUpgrades_text.font = chineseFont; purchaseAllPrestigePirateUpgrades_text.fontSize = 24;
        purchaseAllPrestigeHoarderUpgrades_text.text = "购买所有声望囤积升级"; purchaseAllPrestigeHoarderUpgrades_text.font = chineseFont; purchaseAllPrestigeHoarderUpgrades_text.fontSize = 24;
        purchaseAllPrestigeAdventurerUpgrades_text.text = "购买所有声望冒险家升级"; purchaseAllPrestigeAdventurerUpgrades_text.font = chineseFont; purchaseAllPrestigeAdventurerUpgrades_text.fontSize = 24;

        //60 (Continued from 50)
        purchaseLootPotion_text.text = "购买战利品药水"; purchaseLootPotion_text.font = chineseFont; purchaseLootPotion_text.fontSize = 24;
        purchaseGoldenTouch_text.text = "购买黄金之触"; purchaseGoldenTouch_text.font = chineseFont; purchaseGoldenTouch_text.fontSize = 24;
        purchaseSerendipityScroll_text.text = "购买幸运卷轴"; purchaseSerendipityScroll_text.font = chineseFont; purchaseSerendipityScroll_text.fontSize = 24;
        purchaseKey_text.text = "购买钥匙"; purchaseKey_text.font = chineseFont; purchaseKey_text.fontSize = 24;
        purchaseMagicalElixir_text.text = "购买神奇药剂"; purchaseMagicalElixir_text.font = chineseFont; purchaseMagicalElixir_text.fontSize = 24;
        purchaseAncientRelic_text.text = "购买古老文物"; purchaseAncientRelic_text.font = chineseFont; purchaseAncientRelic_text.fontSize = 24;
        purchaseEnchantedHammer_text.text = "购买强化锤子"; purchaseEnchantedHammer_text.font = MontserratMediumSDF1; purchaseEnchantedHammer_text.fontSize = 24;
        openChest_text.text = "打开一个宝箱"; openChest_text.font = chineseFont; openChest_text.fontSize = 24;
        open100Chests_text.text = "打开100个宝箱"; open100Chests_text.font = chineseFont; open100Chests_text.fontSize = 24;
        open1000Chests_text.text = "打开1000个宝箱"; open1000Chests_text.font = chineseFont; open1000Chests_text.fontSize = 24;

        //70 (Continued from 60)
        open10000Chests_text.text = "打开10000个宝箱"; open10000Chests_text.font = chineseFont; open10000Chests_text.fontSize = 24;
        open100000Chests_text.text = "打开100,000个宝箱"; open100000Chests_text.font = chineseFont; open100000Chests_text.fontSize = 24;
        open200000Chests_text.text = "打开200,000个宝箱"; open200000Chests_text.font = chineseFont; open200000Chests_text.fontSize = 24;
        purchaseChestNo2_text.text = "购买宝箱2号"; purchaseChestNo2_text.font = chineseFont; purchaseChestNo2_text.fontSize = 24;
        purchaseChestNo5_text.text = "购买宝箱5号"; purchaseChestNo5_text.font = chineseFont; purchaseChestNo5_text.fontSize = 24;
        purchaseChestNo8_text.text = "购买宝箱8号"; purchaseChestNo8_text.font = chineseFont; purchaseChestNo8_text.fontSize = 24;
        purchaseChestNo12_text.text = "购买宝箱12号"; purchaseChestNo12_text.font = chineseFont; purchaseChestNo12_text.fontSize = 24;
        purchaseChestNo15_text.text = "购买宝箱15号"; purchaseChestNo15_text.font = chineseFont; purchaseChestNo15_text.fontSize = 24;
        purchaseChestNo20_text.text = "购买宝箱20号"; purchaseChestNo20_text.font = chineseFont; purchaseChestNo20_text.fontSize = 24;
        purchaseChestNo24_text.text = "购买宝箱24号"; purchaseChestNo24_text.font = chineseFont; purchaseChestNo24_text.fontSize = 24;

        //80 (Continued from 70)
        purchaseChestNo32_text.text = "购买宝箱32号"; purchaseChestNo32_text.font = chineseFont; purchaseChestNo32_text.fontSize = 24;
        purchaseTheFinalChest_text.text = "购买最终宝箱"; purchaseTheFinalChest_text.font = chineseFont; purchaseTheFinalChest_text.fontSize = 24;
        openTheFinalChest_text.text = "打开最终宝箱"; openTheFinalChest_text.font = chineseFont; openTheFinalChest_text.fontSize = 24;
        openAReinforcedChest_text.text = "打开一个强化宝箱"; openAReinforcedChest_text.font = chineseFont; openAReinforcedChest_text.fontSize = 24;
        open100ReinforcedChests_text.text = "打开100个强化宝箱"; open100ReinforcedChests_text.font = chineseFont; open100ReinforcedChests_text.fontSize = 24;
        open500ReinforcedChests_text.text = "打开500个强化宝箱"; open500ReinforcedChests_text.font = chineseFont; open500ReinforcedChests_text.fontSize = 24;
        open1000ReinforcedChests_text.text = "打开1000个强化宝箱"; open1000ReinforcedChests_text.font = chineseFont; open1000ReinforcedChests_text.fontSize = 24;
        open100EnchantedGoldenChests_text.text = "打开100个强化金宝箱"; open100EnchantedGoldenChests_text.font = chineseFont; open100EnchantedGoldenChests_text.fontSize = 24;
        open100BossChests_text.text = "打开100个首领宝箱"; open100BossChests_text.font = chineseFont; open100BossChests_text.fontSize = 24;
        receiveTotal50SkillPoints_text.text = "获得总计50技能点"; receiveTotal50SkillPoints_text.font = chineseFont; receiveTotal50SkillPoints_text.fontSize = 24;

        //90 (Continued from 80)
        receiveTotal500SkillPoints_text.text = "获得总计500技能点"; receiveTotal500SkillPoints_text.font = chineseFont; receiveTotal500SkillPoints_text.fontSize = 24;
        receiveTotal1000SkillPoints_text.text = "获得总计1000技能点"; receiveTotal1000SkillPoints_text.font = chineseFont; receiveTotal1000SkillPoints_text.fontSize = 24;
        receiveTotal10000SkillPoints_text.text = "获得总计10,000技能点"; receiveTotal10000SkillPoints_text.font = chineseFont; receiveTotal10000SkillPoints_text.fontSize = 24;
        reachLevel10_text.text = "达到10级"; reachLevel10_text.font = chineseFont; reachLevel10_text.fontSize = 24;
        reachLevel25_text.text = "达到25级"; reachLevel25_text.font = chineseFont; reachLevel25_text.fontSize = 24;
        reachLevel50_text.text = "达到50级"; reachLevel50_text.font = chineseFont; reachLevel50_text.fontSize = 24;
        reachLevel100_text.text = "达到100级"; reachLevel100_text.font = chineseFont; reachLevel100_text.fontSize = 24;
        reachLevel200_text.text = "达到200级"; reachLevel200_text.font = chineseFont; reachLevel200_text.fontSize = 24;
        drop1000_25XGoldCoins_text.text = "从宝箱掉落1000个25倍金币"; drop1000_25XGoldCoins_text.font = chineseFont; drop1000_25XGoldCoins_text.fontSize = 24;
        drop2MillionGoldCoins_text.text = "从宝箱掉落200万金币"; drop2MillionGoldCoins_text.font = chineseFont; drop2MillionGoldCoins_text.fontSize = 24;

        //100 (Continued from 90)
        drop100XGoldCoin_text.text = "从宝箱掉落100倍金币"; drop100XGoldCoin_text.font = chineseFont; drop100XGoldCoin_text.fontSize = 24;
        haveTotal1UndecillionGold_text.text = "拥有总计1涧个金币"; haveTotal1UndecillionGold_text.font = chineseFont; haveTotal1UndecillionGold_text.fontSize = 24;
        haveTotal1DuodecillionGold_text.text = "拥有总计1千涧个金币"; haveTotal1DuodecillionGold_text.font = chineseFont; haveTotal1DuodecillionGold_text.fontSize = 24;
        haveTotal1TredecillionGold_text.text = "拥有总计1百正个金币"; haveTotal1TredecillionGold_text.font = chineseFont; haveTotal1TredecillionGold_text.fontSize = 24;
        haveTotal1QuattuordecillionGold_text.text = "拥有总计1十载个金币"; haveTotal1QuattuordecillionGold_text.font = chineseFont; haveTotal1QuattuordecillionGold_text.fontSize = 24;
        haveTotal1QuindecillionGold_text.text = "拥有总计1极个金币"; haveTotal1QuindecillionGold_text.font = chineseFont; haveTotal1QuindecillionGold_text.fontSize = 24;
        haveTotal1SexdecillionGold_text.text = "拥有总计1千极个金币"; haveTotal1SexdecillionGold_text.font = chineseFont; haveTotal1SexdecillionGold_text.fontSize = 24;
        haveTotal1SeptendecillionGold_text.text = "拥有总计1百恒河沙个金币"; haveTotal1SeptendecillionGold_text.font = chineseFont; haveTotal1SeptendecillionGold_text.fontSize = 24;
        haveTotal1OctodecillionGold_text.text = "拥有总计1十阿僧只个金币"; haveTotal1OctodecillionGold_text.font = chineseFont; haveTotal1OctodecillionGold_text.fontSize = 24;
        reachLevel150_text.text = "达到150级"; reachLevel150_text.font = chineseFont; reachLevel150_text.fontSize = 24;

        //110 (Continued from 100)
        receiveTotal20000SkillPoints_text.text = "获得总计20,000技能点"; receiveTotal20000SkillPoints_text.font = chineseFont; receiveTotal20000SkillPoints_text.fontSize = 24;
        chestsHaveDropped100KTreasures_text.text = "宝箱已掉落100,000个宝藏"; chestsHaveDropped100KTreasures_text.font = chineseFont; chestsHaveDropped100KTreasures_text.fontSize = 24;
        hundredUltraTreasuresDropped_text.text = "100个极致宝藏从宝箱掉落"; hundredUltraTreasuresDropped_text.font = chineseFont; hundredUltraTreasuresDropped_text.fontSize = 24;
        hundredMythicTreasuresDropped_text.text = "100个神秘宝藏从宝箱掉落"; hundredMythicTreasuresDropped_text.font = chineseFont; hundredMythicTreasuresDropped_text.fontSize = 24;
        hundredEternalTreasuresDropped_text.text = "100个永恒宝藏从宝箱掉落"; hundredEternalTreasuresDropped_text.font = chineseFont; hundredEternalTreasuresDropped_text.fontSize = 24;
        open2500ReinforcedChests_text.text = "打开2500个强化宝箱"; open2500ReinforcedChests_text.font = chineseFont; open2500ReinforcedChests_text.fontSize = 24;
        purchaseChestNo37_text.text = "购买宝箱37号"; purchaseChestNo37_text.font = chineseFont; purchaseChestNo37_text.fontSize = 24;
        useTheChicken_text.text = "使用鸡"; useTheChicken_text.font = chineseFont; useTheChicken_text.fontSize = 24;
        drop250000_5XGoldCoins_text.text = "从宝箱掉落250,000个5倍金币"; drop250000_5XGoldCoins_text.font = chineseFont; drop250000_5XGoldCoins_text.fontSize = 24;
        #endregion

        #region Cursors
        // Cursors - Cursors Hover Text

        // Cursors - Cursors Hover Text
        for (int i = 0; i < 21; i++)
        {
            levelUp_text[i].text = "升级"; levelUp_text[i].font = chineseFont; levelUp_text[i].fontSize = 22;
        }

        // Cursors - Others
        cursor1PassiveDamage_Text.text = "+0% 被动伤害"; cursor1PassiveDamage_Text.font = chineseFont; cursor1PassiveDamage_Text.fontSize = 20;
        cursor1CritChance_Text.text = "+0% 暴击几率"; cursor1CritChance_Text.font = chineseFont; cursor1CritChance_Text.fontSize = 20;
        cursor1CritDamage_Text.text = "+0% 暴击伤害"; cursor1CritDamage_Text.font = chineseFont; cursor1CritDamage_Text.fontSize = 20;

        // Cursors - Cursor 2
        cursor2ActiveDamage_Text.text = "+0% 主动伤害"; cursor2ActiveDamage_Text.font = chineseFont; cursor2ActiveDamage_Text.fontSize = 20;
        cursor2CritChance_Text.text = "+0% 暴击几率"; cursor2CritChance_Text.font = chineseFont; cursor2CritChance_Text.fontSize = 20;
        cursor2CritDamage_Text.text = "+0% 暴击伤害"; cursor2CritDamage_Text.font = chineseFont; cursor2CritDamage_Text.fontSize = 20;

        // Cursors - Cursor 3
        cursor3ActiveDamage_Text.text = "+0% 主动伤害"; cursor3ActiveDamage_Text.font = chineseFont; cursor3ActiveDamage_Text.fontSize = 20;
        cursor3PassiveDamage_Text.text = "+0% 被动伤害"; cursor3PassiveDamage_Text.font = chineseFont; cursor3PassiveDamage_Text.fontSize = 20;

        // Cursors - Cursor 4
        cursor4CritChance_Text.text = "+0% 暴击几率"; cursor4CritChance_Text.font = chineseFont; cursor4CritChance_Text.fontSize = 20;
        cursor4CritDamage_Text.text = "+0% 暴击伤害"; cursor4CritDamage_Text.font = chineseFont; cursor4CritDamage_Text.fontSize = 20;

        // Cursors - Cursor 5
        cursor5PassiveDamage_Text.text = "+0% 被动伤害"; cursor5PassiveDamage_Text.font = chineseFont; cursor5PassiveDamage_Text.fontSize = 20;

        // Cursors - Cursor 7
        cursor7PassiveDamage_Text.text = "+0% 被动伤害"; cursor7PassiveDamage_Text.font = chineseFont; cursor7PassiveDamage_Text.fontSize = 20;

        // Cursors - Cursor 9
        cursor9CritChance_Text.text = "+0% 暴击几率"; cursor9CritChance_Text.font = chineseFont; cursor9CritChance_Text.fontSize = 20;
        cursor9CritDamage_Text.text = "+0% 暴击伤害"; cursor9CritDamage_Text.font = chineseFont; cursor9CritDamage_Text.fontSize = 20;

        // Cursors - Cursor 10
        cursor10ActiveDamage_Text.text = "+0% 主动伤害"; cursor10ActiveDamage_Text.font = chineseFont; cursor10ActiveDamage_Text.fontSize = 20;
        cursor10CritChance_Text.text = "+0% 暴击几率"; cursor10CritChance_Text.font = chineseFont; cursor10CritChance_Text.fontSize = 20;
        cursor10CritDamage_Text.text = "+0% 暴击伤害"; cursor10CritDamage_Text.font = robotoBold; cursor10CritDamage_Text.fontSize = 20;

        // Cursors - Cursor 11
        cursor11PassiveDamage_Text.text = "+0% 被动伤害"; cursor11PassiveDamage_Text.font = chineseFont; cursor11PassiveDamage_Text.fontSize = 20;


        cursors_text.text = "光标"; cursors_text.font = chineseFont; cursors_text.fontSize = 55;
        cursorsHover_text.text = "光标"; cursorsHover_text.font = chineseFont; cursorsHover_text.fontSize = 40;
        onlyOneCursorEquipped_text.text = "-只能装备一个光标"; onlyOneCursorEquipped_text.font = chineseFont; onlyOneCursorEquipped_text.fontSize = 21.5f;
        equipCursorFitsPlaystyle_text.text = "-选择适合你玩法的光标"; equipCursorFitsPlaystyle_text.font = chineseFont; equipCursorFitsPlaystyle_text.fontSize = 21.5f;
        uniqueCursorBonus_text.text = "-每个光标都有独特的光标奖励"; uniqueCursorBonus_text.font = chineseFont; uniqueCursorBonus_text.fontSize = 21.5f;
        levelUpCursors_text.text = "-通过花费你的宝物来升级你的光标"; levelUpCursors_text.font = chineseFont; levelUpCursors_text.fontSize = 21.5f;

        gentleTap_text.text = "轻轻一点"; gentleTap_text.font = chineseFont; gentleTap_text.fontSize = 35f;
        gentleTap2_text.text = "轻轻一点"; gentleTap2_text.font = chineseFont; gentleTap2_text.fontSize = 24f;
        gentleTapCursorBonus_text.text = "光标奖励：每次点击有1%的几率生成1个金币"; gentleTapCursorBonus_text.font = chineseFont; gentleTapCursorBonus_text.fontSize = 21f;
        relaxedPalm_text.text = "轻松一掌"; relaxedPalm_text.font = chineseFont; relaxedPalm_text.fontSize = 35f;
        relaxedPalm2_text.text = "轻松一掌"; relaxedPalm2_text.font = chineseFont; relaxedPalm2_text.fontSize = 24f;
        relaxedPalmCursorBonus_text.text = "光标奖励：每打开10个宝箱有25%的几率生成5个金币"; relaxedPalmCursorBonus_text.font = chineseFont; relaxedPalmCursorBonus_text.fontSize = 21f;
        galeForce_text.text = "狂风"; galeForce_text.font = chineseFont; galeForce_text.fontSize = 35f;
        galeForce2_text.text = "狂风E"; galeForce2_text.font = chineseFont; galeForce2_text.fontSize = 24f;
        galeForceCursorBonus_text.text = "光标奖励：每次你造成暴击时，有25%的几率生成1个金币"; galeForceCursorBonus_text.font = chineseFont; galeForceCursorBonus_text.fontSize = 21f;
        radiantTouch_text.text = "光芒之触"; radiantTouch_text.font = chineseFont; radiantTouch_text.fontSize = 35f;
        radiantTouch2_text.text = "光芒之触"; radiantTouch2_text.font = chineseFont; radiantTouch2_text.fontSize = 24f;
        radiantTouchCursorBonus_text.text = "光标奖励：每打开35个宝箱生成7个金币"; radiantTouchCursorBonus_text.font = chineseFont; radiantTouchCursorBonus_text.fontSize = 21f;
        energySurge_text.text = "能量涌动"; energySurge_text.font = chineseFont; energySurge_text.fontSize = 35f;
        energySurge2_text.text = "能量涌动"; energySurge2_text.font = chineseFont; energySurge2_text.fontSize = 24f;
        energySurgeCursorBonus_text.text = "光标奖励：每个宝物获得+0.1%的掉落几率"; energySurgeCursorBonus_text.font = chineseFont; energySurgeCursorBonus_text.fontSize = 21f;
        phantomPalm_text.text = "幻影手掌"; phantomPalm_text.font = chineseFont; phantomPalm_text.fontSize = 35f;
        phantomPalm2_text.text = "幻影手掌"; phantomPalm2_text.font = chineseFont; phantomPalm2_text.fontSize = 24f;
        phantomPalmCursorBonus_text.text = "光标奖励：每次暴击有7%的几率生成一个宝物。每个宝物有3%的几率翻倍价值"; phantomPalmCursorBonus_text.font = chineseFont; phantomPalmCursorBonus_text.fontSize = 21f;
        steelStrike_text.text = "钢铁打击"; steelStrike_text.font = chineseFont; steelStrike_text.fontSize = 35f;
        steelStrike2_text.text = "钢铁打击"; steelStrike2_text.font = chineseFont; steelStrike2_text.fontSize = 24f;
        steelStrikeCursorBonus_text.text = "光标奖励：+5% 更多金币。+5% 更多经验"; steelStrikeCursorBonus_text.font = chineseFont; steelStrikeCursorBonus_text.fontSize = 21f;
        lethalTouch_text.text = "致命之触"; lethalTouch_text.font = chineseFont; lethalTouch_text.fontSize = 35f;
        lethalTouch2_text.text = "致命之触"; lethalTouch2_text.font = chineseFont; lethalTouch2_text.fontSize = 24f;
        lethalTouchCursorBonus_text.text = "光标奖励：每次打开一个宝箱时，有6%的几率获得双倍经验"; lethalTouchCursorBonus_text.font = chineseFont; lethalTouchCursorBonus_text.fontSize = 21f;
        precisionPoint_text.text = "精确之点"; precisionPoint_text.font = chineseFont; precisionPoint_text.fontSize = 35f;
        precisionPoint2_text.text = "精确之点"; precisionPoint2_text.font = chineseFont; precisionPoint2_text.fontSize = 24f;
        precisionPointCursorBonus_text.text = "光标奖励：每次宝藏掉落时，有+7%的几率翻倍价值"; precisionPointCursorBonus_text.font = chineseFont; precisionPointCursorBonus_text.fontSize = 21f;
        vortexTap_text.text = "漩涡轻点"; vortexTap_text.font = chineseFont; vortexTap_text.fontSize = 35f;
        vortexTap2_text.text = "漩涡轻点"; vortexTap2_text.font = chineseFont; vortexTap2_text.fontSize = 24f;
        vortexTapCursorBonus_text.text = "光标奖励：每打开25个宝箱会生成1个宝物并提供三倍经验"; vortexTapCursorBonus_text.font = chineseFont; vortexTapCursorBonus_text.fontSize = 21f;
        cursedClaw_text.text = "诅咒之爪"; cursedClaw_text.font = chineseFont; cursedClaw_text.fontSize = 35f;
        cursedClaw2_text.text = "诅咒之爪"; cursedClaw2_text.font = chineseFont; cursedClaw2_text.fontSize = 24f;
        cursedClawCursorBonus_text.text = "光标奖励：每次造成暴击时，有30%的几率生成一个金币和3%的几率生成一个宝物"; cursedClawCursorBonus_text.font = chineseFont; cursedClawCursorBonus_text.fontSize = 21f;
        sniperClick_text.text = "狙击点击"; sniperClick_text.font = chineseFont; sniperClick_text.fontSize = 35f;
        sniperClick2_text.text = "狙击点击"; sniperClick2_text.font = chineseFont; sniperClick2_text.fontSize = 24f;
        sniperClickCursorBonus_text.text = "光标奖励：+10% 更多金币和+15% 更多经验"; sniperClickCursorBonus_text.font = chineseFont; sniperClickCursorBonus_text.fontSize = 21f;
        shadowSurge_text.text = "阴影涌动"; shadowSurge_text.font = chineseFont; shadowSurge_text.fontSize = 35f;
        shadowSurge2_text.text = "阴影涌动"; shadowSurge2_text.font = chineseFont; shadowSurge2_text.fontSize = 24f;
        shadowSurgeCursorBonus_text.text = "光标奖励：每次暴击都会生成1个金币"; shadowSurgeCursorBonus_text.font = chineseFont; shadowSurgeCursorBonus_text.fontSize = 21f;
        cripplingCrush_text.text = "致命压碎"; cripplingCrush_text.font = chineseFont; cripplingCrush_text.fontSize = 35f;
        cripplingCrush2_text.text = "致命压碎"; cripplingCrush2_text.font = chineseFont; cripplingCrush2_text.fontSize = 24f;
        cripplingCrushCursorBonus_text.text = "光标奖励：每次获得一个宝物时，有25%的几率翻倍价值"; cripplingCrushCursorBonus_text.font = chineseFont; cripplingCrushCursorBonus_text.fontSize = 21f;
        rapidClick_text.text = "迅捷点击"; rapidClick_text.font = chineseFont; rapidClick_text.fontSize = 35f;
        rapidClick2_text.text = "迅捷点击"; rapidClick2_text.font = chineseFont; rapidClick2_text.fontSize = 24f;
        rapidClickCursorBonus_text.text = "光标奖励：每次暴击有13%的几率生成一个宝物"; rapidClickCursorBonus_text.font = chineseFont; rapidClickCursorBonus_text.fontSize = 21f;
        celestialTouch_text.text = "天界之触"; celestialTouch_text.font = chineseFont; celestialTouch_text.fontSize = 35f;
        celestialTouch2_text.text = "天界之触"; celestialTouch2_text.font = chineseFont; celestialTouch2_text.fontSize = 24f;
        celestialTouchCursorBonus_text.text = "光标奖励：经验翻倍"; celestialTouchCursorBonus_text.font = chineseFont; celestialTouchCursorBonus_text.fontSize = 21f;
        arcaneClick_text.text = "秘法点击"; arcaneClick_text.font = chineseFont; arcaneClick_text.fontSize = 35f;
        arcaneClick2_text.text = "秘法点击"; arcaneClick2_text.font = chineseFont; arcaneClick2_text.fontSize = 24f;
        arcaneClickCursorBonus_text.text = "光标奖励：每个宝物翻倍价值"; arcaneClickCursorBonus_text.font = chineseFont; arcaneClickCursorBonus_text.fontSize = 21f;
        eternalTouch_text.text = "永恒之触"; eternalTouch_text.font = chineseFont; eternalTouch_text.fontSize = 35f;
        eternalTouch2_text.text = "永恒之触"; eternalTouch2_text.font = chineseFont; eternalTouch2_text.fontSize = 24f;
        eternalTouchCursorBonus_text.text = "光标奖励：经验和宝物翻倍。每次点击有5%的几率获得一个金币"; eternalTouchCursorBonus_text.font = chineseFont; eternalTouchCursorBonus_text.fontSize = 21f;
        doomTouch_text.text = "厄运之触"; doomTouch_text.font = chineseFont; doomTouch_text.fontSize = 35f;
        doomTouch2_text.text = "厄运之触"; doomTouch2_text.font = chineseFont; doomTouch2_text.fontSize = 24f;
        doomTouchCursorBonus_text.text = "光标奖励：稀有宝藏掉落的几率稍微较小"; doomTouchCursorBonus_text.font = chineseFont; doomTouchCursorBonus_text.fontSize = 21f;
        solarSweep_text.text = "太阳扫过"; solarSweep_text.font = chineseFont; solarSweep_text.fontSize = 35f;
        solarSweep2_text.text = "太阳扫过"; solarSweep2_text.font = chineseFont; solarSweep2_text.fontSize = 24f;
        solarSweepCursorBonus_text.text = "光标奖励：+2.5% 几率翻倍宝箱奖励"; solarSweepCursorBonus_text.font = chineseFont; solarSweepCursorBonus_text.fontSize = 21f;
        infernoFist_text.text = "地狱之拳"; infernoFist_text.font = chineseFont; infernoFist_text.fontSize = 35f;
        infernoFist2_text.text = "地狱之拳"; infernoFist2_text.font = chineseFont; infernoFist2_text.fontSize = 24f;
        infernoFistCursorBonus_text.text = "光标奖励：经验翻倍。每个宝物翻倍价值。4%的几率获得双倍金币"; infernoFistCursorBonus_text.font = chineseFont; infernoFistCursorBonus_text.fontSize = 21f;
        locked_text.text = "封锁"; locked_text.font = chineseFont; locked_text.fontSize = 45f;
        unlockedAfterChest_text.text = "购买宝箱后解锁"; unlockedAfterChest_text.font = chineseFont; unlockedAfterChest_text.fontSize = 37f;

        #endregion

        #region Shop And Items
        for (int i = 0; i < 17; i++)
        {
            itemsLevelUp_text[i].text = "升级"; itemsLevelUp_text[i].font = chineseFont; itemsLevelUp_text[i].fontSize = 22;
        }

        goldenTouchBuff.text = "<color=yellow>+6-10金币掉落"; goldenTouchBuff.font = chineseFont; goldenTouchBuff.fontSize = 10;
        treasurePotionBuff_text.text = "+3% 宝藏掉落几率"; treasurePotionBuff_text.font = chineseFont; treasurePotionBuff_text.fontSize = 10;


        shop_text.text = "商店"; shop_text.font = chineseFont; shop_text.fontSize = 90;
        shop2_text.text = "商店"; shop2_text.font = chineseFont; shop2_text.fontSize = 40;
        items_text.text = "物品"; items_text.font = chineseFont; items_text.fontSize = 50;
        lockpick_text.text = "锁匠工具"; lockpick_text.font = chineseFont; lockpick_text.fontSize = 29;
        lockpick2_text.text = "锁匠工具"; lockpick2_text.font = chineseFont; lockpick2_text.fontSize = 25;
        lockpickItemBonus_text.text = "物品奖励：使用锁匠工具打开宝箱时，有略微几率掉落宝物"; lockpickItemBonus_text.font = chineseFont; lockpickItemBonus_text.fontSize = 21;

        hammer_text.text = "锤子"; hammer_text.font = chineseFont; hammer_text.fontSize = 26;
        hammer2_text.text = "锤子"; hammer2_text.font = chineseFont; hammer2_text.fontSize = 25;
        hammerItemBonus_text.text = "物品奖励：使用锤子时，如果暴击，1个金币有35%的几率生成"; hammerItemBonus_text.font = chineseFont; hammerItemBonus_text.fontSize = 21;

        lootPotion_text.text = "战利品药水"; lootPotion_text.font = chineseFont; lootPotion_text.fontSize = 25;
        lootPotion2_text.text = "战利品药水"; lootPotion2_text.font = chineseFont; lootPotion2_text.fontSize = 25;
        lootPotionItemBonus_text.text = "物品奖励：在药水生效期间获得的宝物有+5%的几率翻倍价值"; lootPotionItemBonus_text.font = chineseFont; lootPotionItemBonus_text.fontSize = 21;

        damagePotion_text.text = "伤害药水"; damagePotion_text.font = chineseFont; damagePotion_text.fontSize = 25;
        damagePotion2_text.text = "伤害药水"; damagePotion2_text.font = chineseFont; damagePotion2_text.fontSize = 25;
        damagePotionItemBonus_text.text = "物品奖励：在生效期间还提供+2%的暴击几率和+50%的暴击伤害"; damagePotionItemBonus_text.font = chineseFont; damagePotionItemBonus_text.fontSize = 21;

        xpPotion_text.text = "经验药水"; xpPotion_text.font = chineseFont; xpPotion_text.fontSize = 25;
        xpPotion2_text.text = "经验药水"; xpPotion2_text.font = chineseFont; xpPotion2_text.fontSize = 25;
        xpPotionItemBonus_text.text = "物品奖励：每次获得经验时，你有0.1%的几率获得+1技能点"; xpPotionItemBonus_text.font = chineseFont; xpPotionItemBonus_text.fontSize = 21;

        goldenTouch_text.text = "黄金之触"; goldenTouch_text.font = chineseFont; goldenTouch_text.fontSize = 25;
        goldenTouch2_text.text = "黄金之触"; goldenTouch2_text.font = chineseFont; goldenTouch2_text.fontSize = 25;
        goldenTouchItemBonus_text.text = "物品奖励：在黄金之触生效期间，宝物有+10%的几率翻倍价值"; goldenTouchItemBonus_text.font = chineseFont; goldenTouchItemBonus_text.fontSize = 21;

        miniChest_text.text = "小宝箱"; miniChest_text.font = chineseFont; miniChest_text.fontSize = 25;
        miniChest2_text.text = "小宝箱"; miniChest2_text.font = chineseFont; miniChest2_text.fontSize = 29;
        miniChestUpgradeBonus_text.text = "升级奖励：小宝箱将提供三种可能的奖励之一"; miniChestUpgradeBonus_text.font = chineseFont; miniChestUpgradeBonus_text.fontSize = 21;
        miniChestMaxHover_text.text = "最大等级"; miniChestMaxHover_text.font = chineseFont; miniChestMaxHover_text.fontSize = 10;

        key_text.text = "钥匙"; key_text.font = chineseFont; key_text.fontSize = 26;
        key2_text.text = "钥匙"; key2_text.font = chineseFont; key2_text.fontSize = 25;
        keyInstantlOpens_text.text = "立即打开一个宝箱"; keyInstantlOpens_text.font = chineseFont; keyInstantlOpens_text.fontSize = 23;
        keyItemBonus_text.text = "物品奖励：使用钥匙打开宝箱时，会额外掉落2-4个金币"; keyItemBonus_text.font = chineseFont; keyItemBonus_text.fontSize = 21;

        treasureBag_text.text = "宝藏袋"; treasureBag_text.font = chineseFont; treasureBag_text.fontSize = 25;
        treasureBag2_text.text = "宝藏袋"; treasureBag2_text.font = chineseFont; treasureBag2_text.fontSize = 25;
        treasureBagDrop_text.text = "宝藏袋将掉落2个宝物"; treasureBagDrop_text.font = chineseFont; treasureBagDrop_text.fontSize = 17;
        treasureBagItemBonus_text.text = "物品奖励：任何宝箱都可能掉落宝藏袋。宝藏袋还会提供5个经验点"; treasureBagItemBonus_text.font = chineseFont; treasureBagItemBonus_text.fontSize = 21;

        serendipityScroll_text.text = "幸运卷轴"; serendipityScroll_text.font = chineseFont; serendipityScroll_text.fontSize = 25;
        serendipityScroll2_text.text = "幸运卷轴"; serendipityScroll2_text.font = chineseFont; serendipityScroll2_text.fontSize = 20;
        serendipityScrollStatsReset_text.text = "来自幸运卷轴的统计数据将在声望时重置"; serendipityScrollStatsReset_text.font = chineseFont; serendipityScrollStatsReset_text.fontSize = 21;

        gauntletOfGreed_text.text = "贪婪护手"; gauntletOfGreed_text.font = chineseFont; gauntletOfGreed_text.fontSize = 25;
        gauntletOfGreed2_text.text = "贪婪护手"; gauntletOfGreed2_text.font = chineseFont; gauntletOfGreed2_text.fontSize = 20;
        gauntletOfGreenBonus_text.text = "物品奖励：每次点击都有3%的几率生成一个宝物"; gauntletOfGreenBonus_text.font = chineseFont; gauntletOfGreenBonus_text.fontSize = 21;

        magicalElixir_text.text = "魔法药剂"; magicalElixir_text.font = chineseFont; magicalElixir_text.fontSize = 25;
        magicalElixir2_text.text = "魔法药剂"; magicalElixir2_text.font = chineseFont; magicalElixir2_text.fontSize = 24;
        magicalElixirItemBonus_text.text = "物品奖励：在药剂生效期间，每个宝物有+0.3%的掉落几率"; magicalElixirItemBonus_text.font = chineseFont; magicalElixirItemBonus_text.fontSize = 21;

        ancientRelic_text.text = "古代遗物"; ancientRelic_text.font = chineseFont; ancientRelic_text.fontSize = 25;
        ancientRelic2_text.text = "古代遗物"; ancientRelic2_text.font = chineseFont; ancientRelic2_text.fontSize = 22;
        ancientRelicGivesBuff_text.text = "为随机属性提供永久加成"; ancientRelicGivesBuff_text.font = chineseFont; ancientRelicGivesBuff_text.fontSize = 22;
        ancientRelicKeepBuff_text.text = "你在声望后仍会保留古代遗物获得的每个加成"; ancientRelicKeepBuff_text.font = chineseFont; ancientRelicKeepBuff_text.fontSize = 21;

        enchantedHammer_text.text = "强化锤子"; enchantedHammer_text.font = chineseFont; enchantedHammer_text.fontSize = 23;
        enchantedHammer2_text.text = "强化锤子"; enchantedHammer2_text.font = chineseFont; enchantedHammer2_text.fontSize = 20;
        enchantedHammerItemBonus_text.text = "物品奖励：2%的几率使宝箱奖励翻三倍"; enchantedHammerItemBonus_text.font = chineseFont; enchantedHammerItemBonus_text.fontSize = 21;

        treasurePotion_text.text = "宝藏药剂"; treasurePotion_text.font = chineseFont; treasurePotion_text.fontSize = 26;
        treasurePotion2_text.text = "宝藏药剂"; treasurePotion2_text.font = chineseFont; treasurePotion2_text.fontSize = 20;
        treasurePotionItemBonus_text.text = "物品奖励：物品掉落的几率提高25%以翻倍价值"; treasurePotionItemBonus_text.font = chineseFont; treasurePotionItemBonus_text.fontSize = 21;

        barrelOfGold_text.text = "金币桶"; barrelOfGold_text.font = chineseFont; barrelOfGold_text.fontSize = 26;
        barrelOfGold2_text.text = "金币桶"; barrelOfGold2_text.font = chineseFont; barrelOfGold2_text.fontSize = 20;
        barrelOfGoldBonus_text.text = "物品奖励：通过拖动选择桶子的放置位置"; barrelOfGoldBonus_text.font = chineseFont; barrelOfGoldBonus_text.fontSize = 21;
        barrelSpawns_text.text = "生成一个金币桶。"; barrelSpawns_text.font = chineseFont; barrelSpawns_text.fontSize = 24;
        barrelGoldCoinsInside_text.text = "桶子已经收集了："; barrelGoldCoinsInside_text.font = chineseFont; barrelGoldCoinsInside_text.fontSize = 10;
        clickToCollect_text.text = "点击收集！"; clickToCollect_text.font = chineseFont; clickToCollect_text.fontSize = 12;

        mimicChest_text.text = "模仿宝箱"; mimicChest_text.font = chineseFont; mimicChest_text.fontSize = 26;
        mimicChest2_text.text = "模仿宝箱"; mimicChest2_text.font = chineseFont; mimicChest2_text.fontSize = 20;
        mimicChestItemBonus_text.text = "物品奖励：正面增益有15%的几率持续时间加倍"; mimicChestItemBonus_text.font = chineseFont; mimicChestItemBonus_text.fontSize = 21;
        turnedOff_text.text = "关闭"; turnedOff_text.font = chineseFont; turnedOff_text.fontSize = 18;

        purchaseAnItem_text.text = "-通过花费你的金币购买物品。"; purchaseAnItem_text.font = chineseFont; purchaseAnItem_text.fontSize = 21.5f;
        useItems_text.text = "-在左侧的“物品”选项卡中使用你的物品。"; useItems_text.font = chineseFont; useItems_text.fontSize = 21.5f;
        itemsGetExpensive_text.text = "-每次购买物品时，每个物品都会变得更加昂贵。"; itemsGetExpensive_text.font = chineseFont; itemsGetExpensive_text.fontSize = 21.5f;
        levelUpItems_text.text = "通过花费你的宝物来升级你的物品。"; levelUpItems_text.font = chineseFont; levelUpItems_text.fontSize = 21.5f;
        broke_text.text = "破产！"; broke_text.font = chineseFont; broke_text.fontSize = 36f;

        rareTreasureBuff_text.text = "<color=orange>+极小几率获得稀有宝藏"; rareTreasureBuff_text.font = chineseFont; rareTreasureBuff_text.fontSize = 9;

        #endregion

        #region Treasures
        treasureBar_text.text = "宝物"; treasureBar_text.font = chineseFont; treasureBar_text.fontSize = 48;

        for (int i = 0; i < 5; i++)
        {
            commonText_text[i].text = "普通"; commonText_text[i].font = chineseFont; commonText_text[i].fontSize = 14;
            rareText_text[i].text = "非常稀有"; rareText_text[i].font = chineseFont; rareText_text[i].fontSize = 15;
            veryRare_text[i].text = "极其稀有"; veryRare_text[i].font = chineseFont; veryRare_text[i].fontSize = 14;
        }

        for (int i = 0; i < 4; i++)
        {
            unCommonText_text[i].text = "稀有"; unCommonText_text[i].font = chineseFont; unCommonText_text[i].fontSize = 14;
        }

        for (int i = 0; i < 3; i++)
        {
            extremelyRare_text[i].text = "超级稀有"; extremelyRare_text[i].font = chineseFont; extremelyRare_text[i].fontSize = 10;
            legendary_text[i].text = "传奇"; legendary_text[i].font = chineseFont; legendary_text[i].fontSize = 12;
            ultra_text[i].text = "极限"; ultra_text[i].font = chineseFont; ultra_text[i].fontSize = 14;
            mythic_text[i].text = "神话"; mythic_text[i].font = chineseFont; mythic_text[i].fontSize = 13;
            eternal_text[i].text = "永恒"; eternal_text[i].font = chineseFont; eternal_text[i].fontSize = 13;
        }


        quartz_text.text = "石英"; quartz_text.font = chineseFont; quartz_text.fontSize = 28;
        amethyst_text.text = "紫水晶"; amethyst_text.font = chineseFont; amethyst_text.fontSize = 28;
        yellowTopaz_text.text = "黄托帕石"; yellowTopaz_text.font = chineseFont; yellowTopaz_text.fontSize = 26;
        albite_text.text = "白钙石"; albite_text.font = chineseFont; albite_text.fontSize = 27;
        redGarnet_text.text = "红石榴石"; redGarnet_text.font = chineseFont; redGarnet_text.fontSize = 27;
        aquamarine_text.text = "海蓝宝石"; aquamarine_text.font = chineseFont; aquamarine_text.fontSize = 27;
        yellowSapphire_text.text = "黄蓝宝石"; yellowSapphire_text.font = chineseFont; yellowSapphire_text.fontSize = 23;
        pinkTourmaline_text.text = "粉碧玺"; pinkTourmaline_text.font = chineseFont; pinkTourmaline_text.fontSize = 22;
        aventurine_text.text = "幸运石"; aventurine_text.font = chineseFont; aventurine_text.fontSize = 22;
        redRuby_text.text = "红宝石"; redRuby_text.font = chineseFont; redRuby_text.fontSize = 26;
        diamond_text.text = "钻石"; diamond_text.font = chineseFont; diamond_text.fontSize = 27;
        grandidierite_text.text = "格朗迪耶瑟翠"; grandidierite_text.font = chineseFont; grandidierite_text.fontSize = 25;
        violetCrystal_text.text = "紫水晶"; violetCrystal_text.font = chineseFont; violetCrystal_text.fontSize = 25;
        akoyaPearl_text.text = "阿科亚珍珠"; akoyaPearl_text.font = chineseFont; akoyaPearl_text.fontSize = 25;
        purpleRupee_text.text = "紫色盧比"; purpleRupee_text.font = chineseFont; purpleRupee_text.fontSize = 26;
        emerald_text.text = "翡翠"; emerald_text.font = chineseFont; emerald_text.fontSize = 28;
        greenDiamond_text.text = "绿钻石"; greenDiamond_text.font = chineseFont; greenDiamond_text.fontSize = 24;
        fireOpal_text.text = "火焰蛋白石"; fireOpal_text.font = chineseFont; fireOpal_text.fontSize = 26;
        gemSilica_text.text = "宝石矽化物"; gemSilica_text.font = chineseFont; gemSilica_text.fontSize = 26;
        pinkPlort_text.text = "粉色黏液"; pinkPlort_text.font = chineseFont; pinkPlort_text.fontSize = 26;
        goldenSeaPearl_text.text = "黄金海珍珠"; goldenSeaPearl_text.font = chineseFont; goldenSeaPearl_text.fontSize = 21;
        kyanite_text.text = "矿物"; kyanite_text.font = chineseFont; kyanite_text.fontSize = 27;
        blackOpal_text.text = "黑玛瑙"; blackOpal_text.font = chineseFont; blackOpal_text.fontSize = 27;
        painite_text.text = "痛苦石"; painite_text.font = chineseFont; painite_text.fontSize = 28;
        tanzanite_text.text = "坦桑石"; tanzanite_text.font = chineseFont; tanzanite_text.fontSize = 27;
        astralium_text.text = "星体"; astralium_text.font = chineseFont; astralium_text.fontSize = 27;
        elysiumPrism_text.text = "艾利西亚棱镜"; elysiumPrism_text.font = chineseFont; elysiumPrism_text.fontSize = 26;
        aerthfireOpal_text.text = "艾尔斯火蛋白石"; aerthfireOpal_text.font = chineseFont; aerthfireOpal_text.fontSize = 23;
        eldrichStarstone_text.text = "埃尔德里奇星石"; eldrichStarstone_text.font = chineseFont; eldrichStarstone_text.fontSize = 19;
        chronolithShard_text.text = "时空碑碎片"; chronolithShard_text.font = chineseFont; chronolithShard_text.fontSize = 20;
        sideriumEssence_text.text = "锡德里姆精华"; sideriumEssence_text.font = chineseFont; sideriumEssence_text.fontSize = 20;
        quadarite_text.text = "瓜达瑞特"; quadarite_text.font = chineseFont; quadarite_text.fontSize = 22;
        radiantNovaStone_text.text = "辐射新星石"; radiantNovaStone_text.font = chineseFont; radiantNovaStone_text.fontSize = 19;
        soluniumShard_text.text = "索伦尼姆碎片"; soluniumShard_text.font = chineseFont; soluniumShard_text.fontSize = 21;

        sell_text.text = "出售"; sell_text.font = chineseFont; sell_text.fontSize = 25;
        sellAll_text.text = "全部出售"; sellAll_text.font = chineseFont; sellAll_text.fontSize = 24;
        #endregion

        #region Rare Treasures
        coolStuff_text.text = "酷炫的东西"; coolStuff_text.font = chineseFont; coolStuff_text.fontSize = 21;
        rareTreasuresTop2_text.text = "稀有宝藏"; rareTreasuresTop2_text.font = chineseFont; rareTreasuresTop2_text.fontSize = 23;
        page1_text.text = "第1页"; page1_text.font = chineseFont; page1_text.fontSize = 12;
        page2_text.text = "第2页"; page2_text.font = chineseFont; page2_text.fontSize = 12;
        pirateSkull2_text.text = "海盗骷髅"; pirateSkull2_text.font = chineseFont; pirateSkull2_text.fontSize = 20;
        demonicSword2_text.text = "邪恶之剑"; demonicSword2_text.font = chineseFont; demonicSword2_text.fontSize = 17;
        mysticRing2_text.text = "神秘之戒"; mysticRing2_text.font = chineseFont; mysticRing2_text.fontSize = 17;
        trophy2_text.text = "奖杯"; trophy2_text.font = chineseFont; trophy2_text.fontSize = 20;
        fallenStar2_text.text = "堕落之星"; fallenStar2_text.font = chineseFont; fallenStar2_text.fontSize = 20;
        clover2_text.text = "幸运草"; clover2_text.font = chineseFont; clover2_text.fontSize = 20;
        kingsCrown2_text.text = "国王的皇冠"; kingsCrown2_text.font = chineseFont; kingsCrown2_text.fontSize = 19;
        spellBook2_text.text = "咒语书"; spellBook2_text.font = chineseFont; spellBook2_text.fontSize = 19;
        guitar2_text.text = "吉他"; guitar2_text.font = chineseFont; guitar2_text.fontSize = 19;
        talarian2_text.text = "塔拉里安"; talarian2_text.font = chineseFont; talarian2_text.fontSize = 19;
        mythrune2_text.text = "神秘符文"; mythrune2_text.font = chineseFont; mythrune2_text.fontSize = 19;
        explorerBackpack2_text.text = "探险家背包"; explorerBackpack2_text.font = chineseFont; explorerBackpack2_text.fontSize = 14;
        vikingShield2_text.text = "维京盾牌"; vikingShield2_text.font = chineseFont; vikingShield2_text.fontSize = 17;
        pillBottle2_text.text = "药瓶"; pillBottle2_text.font = chineseFont; pillBottle2_text.fontSize = 17;
        victoryMedal2_text.text = "胜利奖章"; victoryMedal2_text.font = chineseFont; victoryMedal2_text.fontSize = 17;
        cookie2_text.text = "饼干"; cookie2_text.font = chineseFont; cookie2_text.fontSize = 17;
        christmasPresent2_text.text = "圣诞礼物"; christmasPresent2_text.font = chineseFont; christmasPresent2_text.fontSize = 15;
        battleAxe2_text.text = "战斧"; battleAxe2_text.font = chineseFont; battleAxe2_text.fontSize = 19;
        goldCoin100X2_text.text = "100倍金币"; goldCoin100X2_text.font = chineseFont; goldCoin100X2_text.fontSize = 16;
        sealedEnvelope2_text.text = "密封信封"; sealedEnvelope2_text.font = chineseFont; sealedEnvelope2_text.fontSize = 16;
        strangePotion2_text.text = "奇怪的药水"; strangePotion2_text.font = chineseFont; strangePotion2_text.fontSize = 15;
        soulGem2_text.text = "灵魂宝石"; soulGem2_text.font = chineseFont; soulGem2_text.fontSize = 17;
        ancientScroll2_text.text = "古老卷轴"; ancientScroll2_text.font = chineseFont; ancientScroll2_text.fontSize = 17;
        brick2_text.text = "砖块"; brick2_text.font = chineseFont; brick2_text.fontSize = 17;
        rubberChicken2_text.text = "橡皮鸡"; rubberChicken2_text.font = chineseFont; rubberChicken2_text.fontSize = 17;

        skullFoundReward_text.text = "找到海盗骷髅的奖励："; skullFoundReward_text.font = chineseFont; skullFoundReward_text.fontSize = 6.8f;
        swordFoundReward_text.text = "找到邪恶之剑的奖励："; swordFoundReward_text.font = chineseFont; swordFoundReward_text.fontSize = 6.8f;
        ringFoundReward_text.text = "找到神秘之戒的奖励："; ringFoundReward_text.font = chineseFont; ringFoundReward_text.fontSize = 6.8f;
        trophyFoundReward_text.text = "找到奖杯的奖励："; trophyFoundReward_text.font = chineseFont; trophyFoundReward_text.fontSize = 6.8f;
        fallenStarFoundReward_text.text = "找到流星的奖励："; fallenStarFoundReward_text.font = chineseFont; fallenStarFoundReward_text.fontSize = 6.8f;
        cloverFoundReward_text.text = "找到幸运草的奖励："; cloverFoundReward_text.font = chineseFont; cloverFoundReward_text.fontSize = 6.7f;
        kingsCrownFoundReward_text.text = "找到国王皇冠的奖励："; kingsCrownFoundReward_text.font = chineseFont; kingsCrownFoundReward_text.fontSize = 6.7f;
        spellBookFoundReward_text.text = "找到法术书的奖励："; spellBookFoundReward_text.font = chineseFont; spellBookFoundReward_text.fontSize = 6.7f;
        guitarFoundReward_text.text = "找到吉他的奖励："; guitarFoundReward_text.font = chineseFont; guitarFoundReward_text.fontSize = 6.7f;
        talarianFoundReward_text.text = "找到特拉利亚的奖励："; talarianFoundReward_text.font = chineseFont; talarianFoundReward_text.fontSize = 6.7f;
        mythruneFoundReward_text.text = "找到神秘符文的奖励："; mythruneFoundReward_text.font = chineseFont; mythruneFoundReward_text.fontSize = 6.7f;
        backPackFoundReward_text.text = "找到探险者背包的奖励："; backPackFoundReward_text.font = chineseFont; backPackFoundReward_text.fontSize = 6.5f;
        shieldFoundReward_text.text = "找到维京盾的奖励："; shieldFoundReward_text.font = chineseFont; shieldFoundReward_text.fontSize = 6.5f;
        pillBottleFoundReward_text.text = "找到药瓶的奖励："; pillBottleFoundReward_text.font = chineseFont; pillBottleFoundReward_text.fontSize = 6.5f;
        medalFoundReward_text.text = "找到胜利勋章的奖励："; medalFoundReward_text.font = chineseFont; medalFoundReward_text.fontSize = 6.5f;
        cookieFoundReward_text.text = "找到饼干的奖励："; cookieFoundReward_text.font = chineseFont; cookieFoundReward_text.fontSize = 6.5f;
        presentFoundReward_text.text = "找到圣诞礼物的奖励："; presentFoundReward_text.font = chineseFont; presentFoundReward_text.fontSize = 6.8f;
        axeFoundReward_text.text = "找到战斧的奖励："; axeFoundReward_text.font = chineseFont; axeFoundReward_text.fontSize = 6.8f;
        envelopeFoundReward_text.text = "找到密封信封的奖励："; envelopeFoundReward_text.font = chineseFont; envelopeFoundReward_text.fontSize = 6.8f;
        coin100XFoundReward_text.text = "找到 100X 金币的奖励："; coin100XFoundReward_text.font = chineseFont; coin100XFoundReward_text.fontSize = 6.8f;
        potionFoundReward_text.text = "找到药水的奖励："; potionFoundReward_text.font = chineseFont; potionFoundReward_text.fontSize = 6.8f;
        soulGemFoundReward_text.text = "找到灵魂宝石的奖励："; soulGemFoundReward_text.font = chineseFont; soulGemFoundReward_text.fontSize = 6.8f;
        sscrollFoundReward_text.text = "找到远古卷轴的奖励："; sscrollFoundReward_text.font = chineseFont; sscrollFoundReward_text.fontSize = 6.8f;
        brickFoundReward_text.text = "找到砖块的奖励："; brickFoundReward_text.font = chineseFont; brickFoundReward_text.fontSize = 6.8f;
        chickenFoundReward_text.text = "找到橡皮鸡的奖励："; chickenFoundReward_text.font = chineseFont; chickenFoundReward_text.fontSize = 6.8f;

        allSkullRewards_text.text = "+3% 被动伤害。"; allSkullRewards_text.font = chineseFont; allSkullRewards_text.fontSize = 11f;
        allDemonicSwordRewards_text.text = "+5% 主动伤害. +0.3%暴击几率"; allDemonicSwordRewards_text.font = chineseFont; allDemonicSwordRewards_text.fontSize = 9f;
        allMysticRingRewards_text.text = "+0.05% 宝藏掉落几率"; allMysticRingRewards_text.font = chineseFont; allMysticRingRewards_text.fontSize = 9f;
        allTrophyRewards_text.text = "+0.05% 宝藏掉落几率"; allTrophyRewards_text.font = chineseFont; allTrophyRewards_text.fontSize = 9f;
        allFallenStarRewards_text.text = "+4% 的几率让一个宝物的价值翻倍。"; allFallenStarRewards_text.font = chineseFont; allFallenStarRewards_text.fontSize = 7.5f;
        allCloverRewards_text.text = "+2% 的几率获得 5 倍金币。1% 的几率获得 10 倍金币。"; allCloverRewards_text.font = chineseFont; allCloverRewards_text.fontSize = 7f;
        allKingsCrownRewards_text.text = "升级指针会让它们变得更强大。"; allKingsCrownRewards_text.font = chineseFont; allKingsCrownRewards_text.fontSize = 7.5f;
        allSpellBookRewards_text.text = "升级特殊升级会让它们变得更强大。"; allSpellBookRewards_text.font = chineseFont; allSpellBookRewards_text.fontSize = 7f;
        allGuitarRewards_text.text = "20% 主动和被动伤害。"; allGuitarRewards_text.font = chineseFont; allGuitarRewards_text.fontSize = 7.5f;
        allTalarianRewards_text.text = "+30% 被动伤害。"; allTalarianRewards_text.font = chineseFont; allTalarianRewards_text.fontSize = 7.5f;
        allMythruneRewards_text.text = "+15% 金币"; allMythruneRewards_text.font = chineseFont; allMythruneRewards_text.fontSize = 7.5f;
        allExplorerBackpackRewards_text.text = "+15% 经验, +15% 金币, +0.1% 宝藏掉落几率"; allExplorerBackpackRewards_text.font = chineseFont; allExplorerBackpackRewards_text.fontSize = 7.1f;
        allVikingShieldRewards_text.text = "+7% 的几率让一个宝物的价值翻倍。"; allVikingShieldRewards_text.font = chineseFont; allVikingShieldRewards_text.fontSize = 7.1f;
        allPillBottleRewards_text.text = "药瓶效果叠加 +1 次。"; allPillBottleRewards_text.font = chineseFont; allPillBottleRewards_text.fontSize = 7.1f;
        allVictoryMedalRewards_text.text = "每次点击有 1% 的几率产生一枚金币，并且增加 0.2% 的几率来生成一个宝物。"; allVictoryMedalRewards_text.font = chineseFont; allVictoryMedalRewards_text.fontSize = 5.2f;
        foundCookieRewards_text.text = "+50% 金币. +50 经验. +0.2% 宝藏掉落几率. +4% 的几率让一个宝物的价值翻倍。 75% 主动和被动伤害。+3% 暴击几率. +150% 暴击伤害"; foundCookieRewards_text.font = chineseFont; foundCookieRewards_text.fontSize = 6.6f;
        foundChristmasPresentRewards_text.text = "<color=green>远古遗物提供更强大的增益。"; foundChristmasPresentRewards_text.font = chineseFont; foundChristmasPresentRewards_text.fontSize = 9f;
        foundBattleAxeRewards_text.text = "<color=green>每次点击都有 0.1% 的几率立即打开一个宝箱。 立即打开宝箱将使宝箱奖励翻倍。"; foundBattleAxeRewards_text.font = chineseFont; foundBattleAxeRewards_text.fontSize = 6f;
        foundEnvelopeRewards.text = "<color=green>+0.2% 的几率获得强化宝箱的机会。"; foundEnvelopeRewards.font = chineseFont; foundEnvelopeRewards.fontSize = 8f;
        foundGoldCoin100XRewards_text.text = "<color=green>0.05% 的几率获得一枚 100X 金币。"; foundGoldCoin100XRewards_text.font = chineseFont; foundGoldCoin100XRewards_text.fontSize = 8f;
        foundPotionRewards_text.text = "<color=green>所有药水在升级时变得更强大。"; foundPotionRewards_text.font = chineseFont; foundPotionRewards_text.fontSize = 7f;
        foundSoulGemRewards_text.text = "<color=green>灵魂宝石将继续掉落。点击灵魂宝石以永久性地提升一个随机属性的增益。 0.2% 的几率获得灵魂宝石。"; foundSoulGemRewards_text.font = chineseFont; foundSoulGemRewards_text.fontSize = 6.25f;

        foundAncientScrollRewards_text.text = "<color=green>幸运卷轴给予千载难逢的智慧和见解。"; foundAncientScrollRewards_text.font = chineseFont; foundAncientScrollRewards_text.fontSize = 8f;

        foundBrickRewards_text.text = "<color=green>这只是一块砖……所以……什么也没有……"; foundBrickRewards_text.font = chineseFont; foundBrickRewards_text.fontSize = 8f;

        foundRubberChickenRewards_text.text = "<color=green>选择自己选择的属性的大幅度增强。"; foundRubberChickenRewards_text.font = chineseFont; foundRubberChickenRewards_text.fontSize = 7f;


        pirateSkullDescription_text.text = "\"通过风浪汹涌的海域和未知的战斗，这颗颅骨承载着一位无情海盗的传奇。\""; pirateSkullDescription_text.font = chineseFont; pirateSkullDescription_text.fontSize = 7f;

        demonicSwordDescription_text.text = "\"这把来自邪恶来源的武器体现了诅咒的本质。\""; demonicSwordDescription_text.font = chineseFont; demonicSwordDescription_text.fontSize = 7f;

        mysticRingDescription_text.text = "\"神秘之戒增强了你的运势，使宝物更频繁地掉落。\""; mysticRingDescription_text.font = chineseFont; mysticRingDescription_text.fontSize = 7f;

        trophyDescription_text.text = "\"令人好奇的是，为什么把这个表彰伟大的奖杯藏在宝箱里呢？\""; trophyDescription_text.font = chineseFont; trophyDescription_text.fontSize = 7f;

        fallenStarDescription_text.text = "\"这些箱子中包含着稀有的宝物。一颗流星，一个令人惊叹的宇宙遗物。\""; fallenStarDescription_text.font = chineseFont; fallenStarDescription_text.fontSize = 7f;

        cloverDescription_text.text = "\"找到这个幸运物——幸运草，它隐藏在宝箱中，带来了好运。\""; cloverDescription_text.font = chineseFont; cloverDescription_text.fontSize = 7f;

        kingsCrownDescription_text.text = "\"揭示这个威严的神器——一顶背负着王国传承的王冠。\""; kingsCrownDescription_text.font = chineseFont; kingsCrownDescription_text.fontSize = 7.6f;

        spellBookDescription_text.text = "\"揭开法术书的隐藏知识，赋予你魔法的艺术。\""; spellBookDescription_text.font = chineseFont; spellBookDescription_text.fontSize = 7.6f;

        guitarDescription_text.text = "\"为什么这把吉他会被隐藏在宝箱里呢？它的琴弦带着深刻的个人联系的回响。\""; guitarDescription_text.font = chineseFont; guitarDescription_text.fontSize = 6.9f;

        talarianDescription_text.text = "\"宝箱中藏着传奇的特拉利亚，象征着迅捷和自由。\""; talarianDescription_text.font = chineseFont; talarianDescription_text.fontSize = 6.9f;

        strangeRuneDescription_text.text = "\"挖掘神秘符文的精髓，并被远古魔法的回声所触动。\""; strangeRuneDescription_text.font = chineseFont; strangeRuneDescription_text.fontSize = 6.7f;

        explorerBackpackDescription_text.text = "\"打开探险者背包，找到一大堆供大胆冒险使用的工具。\""; explorerBackpackDescription_text.font = chineseFont; explorerBackpackDescription_text.fontSize = 6.7f;

        vikingShieldDescription_text.text = "\"维京盾内蕴藏着无畏战士的遗产，他们毫不畏惧战斗。\""; vikingShieldDescription_text.font = chineseFont; vikingShieldDescription_text.fontSize = 7f;

        pillBottleDescription_text.text = "\"在财富中，有一个不起眼的药瓶隐藏着，其用途令人着迷。\""; pillBottleDescription_text.font = chineseFont; pillBottleDescription_text.fontSize = 7f;

        victoryMedalDescription_text.text = "\"拥抱胜利勋章，它是胜利和坚定不移决心的象征。\""; victoryMedalDescription_text.font = chineseFont; victoryMedalDescription_text.fontSize = 6.5f;

        cookieDescription_text.text = "点击它"; cookieDescription_text.font = chineseFont; cookieDescription_text.fontSize = 7f;

        christmasPresentDescription_text.text = "\"我们永远不会知道里面有什么\""; christmasPresentDescription_text.font = chineseFont; christmasPresentDescription_text.fontSize = 7f;

        battleAxeDescription_text.text = "\"这把战斧由熟练的工匠锻造，闪烁着致命的锋刃，随时准备用无情的效率斩杀你的敌人。\""; battleAxeDescription_text.font = chineseFont; battleAxeDescription_text.fontSize = 6f;

        goldCoin100XDescription_text.text = "\"世界上这种金币已经不多了\""; goldCoin100XDescription_text.font = chineseFont; goldCoin100XDescription_text.fontSize = 7f;

        sealedEnvelopeDescription_text.text = "\"很可能是由历史人物撰写的\""; sealedEnvelopeDescription_text.font = chineseFont; sealedEnvelopeDescription_text.fontSize = 7f;

        strangePotionDescription_text.text = "\"T这种神秘的药水以其神秘的颜色涡流，向那些足够大胆敢尝试的人承诺风险和回报。\""; strangePotionDescription_text.font = chineseFont; strangePotionDescription_text.fontSize = 6f;

        soulGemDescription_text.text = "\"这颗光芒四射的宝石脉动着宇宙的力量，承诺增强你的角色的力量和能力。\""; soulGemDescription_text.font = chineseFont; soulGemDescription_text.fontSize = 6f;

        ancientScrollDescription_text.text = "\"一卷充满古老智慧和见解的古代卷轴。\""; ancientScrollDescription_text.font = chineseFont; ancientScrollDescription_text.fontSize = 7f;

        brickDescription_text.text = "\"是的...它只是一块砖...\""; brickDescription_text.font = chineseFont; brickDescription_text.fontSize = 7f;

        rubberChickenDescription_text.text = "\"你可能会认为这只橡皮鸡是个笑话，但它内部蕴藏着强大的力量。\""; rubberChickenDescription_text.font = chineseFont; rubberChickenDescription_text.fontSize = 7f;

        skullDropChance_text.text = "0,0278%<color=white>的掉落几率"; skullDropChance_text.font = chineseFont; skullDropChance_text.fontSize = 10f;
        democSwordDropChance_text.text = "0,0119%<color=white>的掉落几率"; democSwordDropChance_text.font = chineseFont; democSwordDropChance_text.fontSize = 10f;
        mysticRingDropChance_text.text = "0,0051%<color=white>的掉落几率"; mysticRingDropChance_text.font = chineseFont; mysticRingDropChance_text.fontSize = 10f;
        trophyDropChance_text.text = "0,0050%<color=white>的掉落几率"; trophyDropChance_text.font = chineseFont; trophyDropChance_text.fontSize = 10f;
        fallenStarDropChance_text.text = "0,0008%<color=white>的掉落几率"; fallenStarDropChance_text.font = chineseFont; fallenStarDropChance_text.fontSize = 10f;
        cloverDropChance_text.text = "0,0005%<color=white>的掉落几率"; cloverDropChance_text.font = chineseFont; cloverDropChance_text.fontSize = 10f;
        kingsCrownDropChance_text.text = "0,0006%<color=white>的掉落几率"; kingsCrownDropChance_text.font = chineseFont; kingsCrownDropChance_text.fontSize = 10f;
        spellBookDropChance_text.text = "0,0006%<color=white>的掉落几率"; spellBookDropChance_text.font = chineseFont; spellBookDropChance_text.fontSize = 10f;
        guitarDropChance_text.text = "0,0009%<color=white>的掉落几率"; guitarDropChance_text.font = chineseFont; guitarDropChance_text.fontSize = 10f;
        talarianDropChance_text.text = "0,00077%<color=white>的掉落几率"; talarianDropChance_text.font = chineseFont; talarianDropChance_text.fontSize = 10f;
        mythRuneDropChance_text.text = "0,0016%<color=white>的掉落几率"; mythRuneDropChance_text.font = chineseFont; mythRuneDropChance_text.fontSize = 10f;
        backPackDropChance_text.text = "0,00052%<color=white>的掉落几率"; backPackDropChance_text.font = chineseFont; backPackDropChance_text.fontSize = 10f;
        vikingShieldDropChance_text.text = "0,00063%<color=white>的掉落几率"; vikingShieldDropChance_text.font = chineseFont; vikingShieldDropChance_text.fontSize = 10f;
        pillBottleDropChance_text.text = "0,00050%<color=white>的掉落几率"; pillBottleDropChance_text.font = chineseFont; pillBottleDropChance_text.fontSize = 10f;
        victoryMedalDropChance_text.text = "0,00042%<color=white>的掉落几率"; victoryMedalDropChance_text.font = chineseFont; victoryMedalDropChance_text.fontSize = 10f;
        cookieDropChance_text.text = "0,00034%<color=white>的掉落几率"; cookieDropChance_text.font = chineseFont; cookieDropChance_text.fontSize = 10f;
        presentDropChance_text.text = "0,00038%<color=white>的掉落几率"; presentDropChance_text.font = chineseFont; presentDropChance_text.fontSize = 10f;
        battleAxeDropChance_text.text = "0,00032%<color=white>的掉落几率"; battleAxeDropChance_text.font = chineseFont; battleAxeDropChance_text.fontSize = 10f;
        coin100XDropChance_text.text = "0,00030%<color=white>的掉落几率"; coin100XDropChance_text.font = chineseFont; coin100XDropChance_text.fontSize = 10f;
        envelopeDropChance_text.text = "0,00036%<color=white>的掉落几率"; envelopeDropChance_text.font = chineseFont; envelopeDropChance_text.fontSize = 10f;
        strangePotionDropChance_text.text = "0,00030%<color=white>的掉落几率"; strangePotionDropChance_text.font = chineseFont; strangePotionDropChance_text.fontSize = 10f;
        soulGemDropChance_text.text = "0,00034%<color=white>的掉落几率"; soulGemDropChance_text.font = chineseFont; soulGemDropChance_text.fontSize = 10f;
        ancientScrollDropChance_text.text = "0,00029%<color=white>的掉落几率"; ancientScrollDropChance_text.font = chineseFont; ancientScrollDropChance_text.fontSize = 10f;
        brickDropChance_text.text = "0,00026%<color=white>的掉落几率"; brickDropChance_text.font = chineseFont; brickDropChance_text.fontSize = 10f;
        chickenDropChance_text.text = "0,00025%<color=white>的掉落几率"; chickenDropChance_text.font = chineseFont; chickenDropChance_text.fontSize = 10f;

        congratsMessage_text.text = "恭喜！你已经获得了全部 25 个稀有宝物！"; congratsMessage_text.font = chineseFont; congratsMessage_text.fontSize = 17f;
        purchaseRareTreasure_text.text = "购买所有声望升级即可解锁。"; purchaseRareTreasure_text.font = chineseFont; purchaseRareTreasure_text.fontSize = 17f;
        purchase1MissingTreasure_text.text = "购买一个缺失的稀有宝物吗？"; purchase1MissingTreasure_text.font = chineseFont; purchase1MissingTreasure_text.fontSize = 12f;

        chooseChickenBuff_text.text = "点击橡皮鸡选择增益属性:"; chooseChickenBuff_text.font = chineseFont; chooseChickenBuff_text.fontSize = 36f;
        coose1_text.text = "选择："; coose1_text.font = chineseFont; coose1_text.fontSize = 23f;
        coose2_text.text = "选择："; coose2_text.font = chineseFont; coose2_text.fontSize = 23f;
        coose3_text.text = "选择："; coose3_text.font = chineseFont; coose3_text.fontSize = 23f;
        coose4_text.text = "选择："; coose4_text.font = chineseFont; coose4_text.fontSize = 23f;
        coose5_text.text = "选择："; coose5_text.font = chineseFont; coose5_text.fontSize = 23f;
        coose6_text.text = "选择："; coose6_text.font = chineseFont; coose6_text.fontSize = 23f;
        coose7_text.text = "选择："; coose7_text.font = chineseFont; coose7_text.fontSize = 23f;
        #endregion

        #region Treasure Chests
        chestPurchase_text.text = "购买"; chestPurchase_text.font = chineseFont; chestPurchase_text.fontSize = 36;
        autoPurchase_text.text = "当可以负担得起时自动购买下一个宝箱："; autoPurchase_text.font = chineseFont; autoPurchase_text.fontSize = 11;
        chestTREASURESDROP_text.text = "宝物掉落："; chestTREASURESDROP_text.font = chineseFont; chestTREASURESDROP_text.fontSize = 18;
        reinforcedPopUp_text.text = "强化宝箱"; reinforcedPopUp_text.font = chineseFont; reinforcedPopUp_text.fontSize = 36;
        enchantedGoldenChestPopUp_text.text = "强化黄金宝箱"; enchantedGoldenChestPopUp_text.font = chineseFont; enchantedGoldenChestPopUp_text.fontSize = 32;
        bossChest_text.text = "首领宝箱"; bossChest_text.font = chineseFont; bossChest_text.fontSize = 50;
        reinforcedHover_text.text = "强化宝箱"; reinforcedHover_text.font = chineseFont; reinforcedHover_text.fontSize = 25;

        enchantedGoldenHover_text.text = "强化黄金宝箱"; enchantedGoldenHover_text.font = chineseFont; enchantedGoldenHover_text.fontSize = 24;
        enchantedGoldenHoverLockPickKeys_text.text = "使用挑锁器或钥匙仅会移除宝箱生命值的33%"; enchantedGoldenHoverLockPickKeys_text.font = chineseFont; enchantedGoldenHoverLockPickKeys_text.fontSize = 17;

        bossChestHover_text.text = "首领宝箱"; bossChestHover_text.font = chineseFont; bossChestHover_text.fontSize = 38;
        bossChestHoverLockPickKeys_text.text = "使用挑锁器或钥匙仅会移除宝箱生命值的33%"; bossChestHoverLockPickKeys_text.font = chineseFont; bossChestHoverLockPickKeys_text.fontSize = 16;


        #endregion

        #region prestige

        wouldYouLiketoGoBack_text.text = "你是否要返回并打开更多宝箱？";
        wouldYouLiketoGoBack_text.font = chineseFont; wouldYouLiketoGoBack_text.fontSize = 40;

        butFirst_text.text = "但首先...";
        butFirst_text.font = chineseFont; butFirst_text.fontSize = 20;

        purchaseTheGoodieBag_text.text = "购买“好物袋”声望升级以解锁";
        purchaseTheGoodieBag_text.font = chineseFont; purchaseTheGoodieBag_text.fontSize = 22;

        goBackYES_text.text = "是"; goBackYES_text.font = chineseFont; goBackYES_text.fontSize = 60;

        goBackNO_text.text = "否"; goBackNO_text.font = chineseFont; goBackNO_text.fontSize = 60;

        itesmChosen_text.text = "已选择物品！"; itesmChosen_text.font = chineseFont; itesmChosen_text.fontSize = 26;

        chooseSomethingElse_text.text = "选择其他物品"; chooseSomethingElse_text.font = chineseFont; chooseSomethingElse_text.fontSize = 31;

        prestigeExit_text.text = "退出"; prestigeExit_text.font = chineseFont; prestigeExit_text.fontSize = 47;

        for (int i = 0; i < lockedPrestige_text.Length; i++)
        {
            lockedPrestige_text[i].text = "封锁"; lockedPrestige_text[i].font = chineseFont; lockedPrestige_text[i].fontSize = 12f;
            unlockedPrestige_text[i].text = "已解锁"; unlockedPrestige_text[i].font = chineseFont; unlockedPrestige_text[i].fontSize = 8.6f;
        }

        findThePrestigeKeyAncChest_text.lineSpacing = -75;
        openPrestigeScreen_text.lineSpacing = -95;

        loseText_text.lineSpacing = -35;
        keepText_text.lineSpacing = -30;

        // For individual variables
        prestigeTop_text.text = "声望"; prestigeTop_text.font = chineseFont; prestigeTop_text.fontSize = 50;
        prestigeButton_text.text = "声望"; prestigeButton_text.font = chineseFont; prestigeButton_text.fontSize = 36;
        openPrestigeScreen_text.text = "打开声望界面"; openPrestigeScreen_text.font = chineseFont; openPrestigeScreen_text.fontSize = 28;
        skillPoints_text.text = "技能点"; skillPoints_text.font = chineseFont; skillPoints_text.fontSize = 20;

        wouldYouLikeToPrestige_text.text = "你是否要声望？"; wouldYouLikeToPrestige_text.font = chineseFont; wouldYouLikeToPrestige_text.fontSize = 22;
        youWillKeep_text.text = "你将保留"; youWillKeep_text.font = chineseFont; youWillKeep_text.fontSize = 46;
        keepText_text.text = "-声望升级\n-稀有宝物\n-成就"; keepText_text.font = chineseFont; keepText_text.fontSize = 34;
        youWillLose_text.text = "你将失去"; youWillLose_text.font = chineseFont; youWillLose_text.fontSize = 46;
        loseText_text.text = "-所有金币\n-宝物\n-等级\n-物品\n-物品等级\n-光标\n-光标等级\n-卷轴统计"; loseText_text.font = chineseFont; loseText_text.fontSize = 37;
        prestigeWillTakeYou_text.text = "声望将带你到技能树界面，你可以购买永久性升级"; prestigeWillTakeYou_text.font = chineseFont; prestigeWillTakeYou_text.fontSize = 14.4f;
        prestigeYES_text.text = "是"; prestigeYES_text.font = chineseFont; prestigeYES_text.fontSize = 25;
        prestigeNO_text.text = "否"; prestigeNO_text.font = chineseFont; prestigeNO_text.fontSize = 25;
        prestigeAndSkillPoints_text.text = "声望 & 技能点"; prestigeAndSkillPoints_text.font = chineseFont; prestigeAndSkillPoints_text.fontSize = 80;
        prestigeExplinations_text.text = "-当解锁新宝箱后，声望之钥和声望宝箱的掉落几率会增加 +0.017%"; prestigeExplinations_text.font = chineseFont; prestigeExplinations_text.fontSize = 32;
        prestigeExplinations2_text.text = "每次升级都会获得技能点。每第五级会额外获得 +1 技能点，总技能点数为（当前等级 / 5）+ 1"; prestigeExplinations2_text.font = chineseFont; prestigeExplinations2_text.fontSize = 32;
        currentlyViewingPrestige_text.text = "您当前仅查看声望屏幕"; currentlyViewingPrestige_text.font = chineseFont; currentlyViewingPrestige_text.fontSize = 38;
        skillPointsTextInsode_text.text = "技能点"; skillPointsTextInsode_text.font = chineseFont; skillPointsTextInsode_text.fontSize = 36;

        clickerUnder_text.text = "点击"; clickerUnder_text.font = chineseFont; clickerUnder_text.fontSize = 44;
        loungerUnder_text.text = "休息"; loungerUnder_text.font = chineseFont; loungerUnder_text.fontSize = 44;
        pirateUnder_text.text = "海盗"; pirateUnder_text.font = chineseFont; pirateUnder_text.fontSize = 44;
        hoarderUnder_text.text = "囤积"; hoarderUnder_text.font = chineseFont; hoarderUnder_text.fontSize = 44;
        adventurerUnder_text.text = "冒险家"; adventurerUnder_text.font = chineseFont; adventurerUnder_text.fontSize = 44;

        bossChestPresitgeName_text.text = "首领宝箱"; bossChestPresitgeName_text.font = chineseFont; bossChestPresitgeName_text.fontSize = 26;
        reinforcedItems_text.text = "强化物品"; reinforcedItems_text.font = chineseFont; reinforcedItems_text.fontSize = 22;
        potionStacker_text.text = "药水叠加"; potionStacker_text.font = chineseFont; potionStacker_text.fontSize = 24;
        fortifiedItems_text.text = "强化物品"; fortifiedItems_text.font = chineseFont; fortifiedItems_text.fontSize = 26;
        enhancedItems_text.text = "增强物品"; enhancedItems_text.font = chineseFont; enhancedItems_text.fontSize = 23;
        enchantedItems_text.text = "强化物品"; enchantedItems_text.font = chineseFont; enchantedItems_text.fontSize = 22;
        itemMastery_text.text = "物品精通"; itemMastery_text.font = chineseFont; itemMastery_text.fontSize = 26;
        enchantmentQuill_text.text = "强化羽毛笔"; enchantmentQuill_text.font = chineseFont; enchantmentQuill_text.fontSize = 23;
        wizard_text.text = "巫师"; wizard_text.font = chineseFont; wizard_text.fontSize = 26;
        student_text.text = "学生"; student_text.font = chineseFont; student_text.fontSize = 26;
        potionChug_text.text = "饮用药水"; potionChug_text.font = chineseFont; potionChug_text.fontSize = 26;
        transcendence_text.text = "升华"; transcendence_text.font = chineseFont; transcendence_text.fontSize = 23;
        elevation_text.text = "提升"; elevation_text.font = chineseFont; elevation_text.fontSize = 26;
        xpAccelerator_text.text = "经验加速器"; xpAccelerator_text.font = chineseFont; xpAccelerator_text.fontSize = 25;
        proficiency_text.text = "精通"; proficiency_text.font = chineseFont; proficiency_text.fontSize = 26;
        levelMastery_text.text = "等级精通"; levelMastery_text.font = chineseFont; levelMastery_text.fontSize = 26;
        advancement_text.text = "提升"; advancement_text.font = chineseFont; advancement_text.fontSize = 26;
        xpBoost_text.text = "经验提升"; xpBoost_text.font = chineseFont; xpBoost_text.fontSize = 26;
        masterPirate_text.text = "大海盗"; masterPirate_text.font = chineseFont; masterPirate_text.fontSize = 26;
        fortuneSeeker_text.text = "寻宝者"; fortuneSeeker_text.font = chineseFont; fortuneSeeker_text.fontSize = 26;
        pirate_text.text = "海盗"; pirate_text.font = chineseFont; pirate_text.fontSize = 26;
        rapidLeveling_text.text = "快速升级"; rapidLeveling_text.font = chineseFont; rapidLeveling_text.fontSize = 26;
        treasureAmplifier_text.text = "财宝放大器"; treasureAmplifier_text.font = chineseFont; treasureAmplifier_text.fontSize = 22;
        stackingSplendor_text.text = "堆叠荣耀"; stackingSplendor_text.font = chineseFont; stackingSplendor_text.fontSize = 21;
        goodieBag_text.text = "礼品袋"; goodieBag_text.font = chineseFont; goodieBag_text.fontSize = 26;
        reinforcedRiches_text.text = "强化财富"; reinforcedRiches_text.font = chineseFont; reinforcedRiches_text.fontSize = 20;
        chestBlessing_text.text = "宝箱祝福"; chestBlessing_text.font = chineseFont; chestBlessing_text.fontSize = 25;
        chestSurge_text.text = "宝箱涌动"; chestSurge_text.font = chineseFont; chestSurge_text.fontSize = 26;
        fortifiedFortune_text.text = "强化财富"; fortifiedFortune_text.font = chineseFont; fortifiedFortune_text.fontSize = 23;
        enchantedGoldenChest_text.text = "魔法金宝箱"; enchantedGoldenChest_text.font = chineseFont; enchantedGoldenChest_text.fontSize = 17;
        piratesParadise_text.text = "海盗天堂"; piratesParadise_text.font = chineseFont; piratesParadise_text.fontSize = 23;
        luxuriousLooting_text.text = "豪华掠夺"; luxuriousLooting_text.font = chineseFont; luxuriousLooting_text.fontSize = 21;
        lootBonanza_text.text = "掠夺盛宴"; lootBonanza_text.font = chineseFont; lootBonanza_text.fontSize = 26;
        chestEnrichment_text.text = "宝箱丰富"; chestEnrichment_text.font = chineseFont; chestEnrichment_text.fontSize = 21;
        greaterLoot_text.text = "更多掠夺"; greaterLoot_text.font = chineseFont; greaterLoot_text.fontSize = 26;
        treasuryReinforcement_text.text = "财宝强化"; treasuryReinforcement_text.font = chineseFont; treasuryReinforcement_text.fontSize = 16;
        strongbox_text.text = "保险箱"; strongbox_text.font = chineseFont; strongbox_text.fontSize = 27;
        fortified_text.text = "加强 "; fortified_text.font = chineseFont; fortified_text.fontSize = 26;
        gildedFortification_text.text = "镀金防御"; gildedFortification_text.font = chineseFont; gildedFortification_text.fontSize = 21;
        reinforcedPlus_text.text = "强化 +"; reinforcedPlus_text.font = chineseFont; reinforcedPlus_text.fontSize = 26;
        wellPrepared_text.text = "准备就绪"; wellPrepared_text.font = chineseFont; wellPrepared_text.fontSize = 26;
        stashedItems_text.text = "储存物品"; stashedItems_text.font = chineseFont; stashedItems_text.fontSize = 26;
        travelBag_text.text = "旅行包"; travelBag_text.font = chineseFont; travelBag_text.fontSize = 26;
        buffsGalore_text.text = "增益效果多多"; buffsGalore_text.font = chineseFont; buffsGalore_text.fontSize = 24;
        lootEnhancer_text.text = "战利品增强"; lootEnhancer_text.font = chineseFont; lootEnhancer_text.fontSize = 24;
        treasureHunter_text.text = "寻宝者"; treasureHunter_text.font = chineseFont; treasureHunter_text.fontSize = 26;
        collector_text.text = "收藏家"; collector_text.font = chineseFont; collector_text.fontSize = 26;
        autoClicker1_text.text = "自动点击器 "; autoClicker1_text.font = chineseFont; autoClicker1_text.fontSize = 26;
        autoClicker2_text.text = "自动点击器 +"; autoClicker2_text.font = chineseFont; autoClicker2_text.fontSize = 26;
        autoClicker3_text.text = "自动点击器 ++"; autoClicker3_text.font = chineseFont; autoClicker3_text.fontSize = 26;
        autoClicker4_text.text = "快速点击器"; autoClicker4_text.font = chineseFont; autoClicker4_text.fontSize = 26;
        cursorEnchantment_text.text = "光标强化"; cursorEnchantment_text.font = chineseFont; cursorEnchantment_text.fontSize = 20;
        advancedCursors_text.text = "高级光标"; advancedCursors_text.font = chineseFont; advancedCursors_text.fontSize = 22;
        cursorEvolution_text.text = "光标进化"; cursorEvolution_text.font = chineseFont; cursorEvolution_text.fontSize = 24;
        cursorEnhanced_text.text = "光标增强"; cursorEnhanced_text.font = chineseFont; cursorEnhanced_text.fontSize = 23;
        crushingForce_text.text = "毁灭力量"; crushingForce_text.font = chineseFont; crushingForce_text.fontSize = 26;
        swiftblade_text.text = "迅猛刀锋"; swiftblade_text.font = chineseFont; swiftblade_text.fontSize = 26;
        fury_text.text = "狂怒"; fury_text.font = chineseFont; fury_text.fontSize = 26;
        clickstorm_text.text = "点击风暴"; clickstorm_text.font = chineseFont; clickstorm_text.fontSize = 26;
        tapPrecision_text.text = "点击精度"; tapPrecision_text.font = chineseFont; tapPrecision_text.fontSize = 26;
        clickersFury_text.text = "点击者之怒"; clickersFury_text.font = chineseFont; clickersFury_text.fontSize = 26;
        tapMastery_text.text = "点击精通"; tapMastery_text.font = chineseFont; tapMastery_text.fontSize = 26;
        cripplingStrikes_text.text = "致命打击"; cripplingStrikes_text.font = chineseFont; cripplingStrikes_text.fontSize = 24;
        savageCrits_text.text = "致命暴击"; savageCrits_text.font = chineseFont; savageCrits_text.fontSize = 26;
        lethalPrecision_text.text = "致命精度"; lethalPrecision_text.font = chineseFont; lethalPrecision_text.fontSize = 24;
        ruthlessStrikes_text.text = "无情打击"; ruthlessStrikes_text.font = chineseFont; ruthlessStrikes_text.fontSize = 26;
        hardenedFist_text.text = "坚韧之拳"; hardenedFist_text.font = chineseFont; hardenedFist_text.fontSize = 26;
        idler_text.text = "懒人"; idler_text.font = chineseFont; idler_text.fontSize = 26;
        lazyRewards_text.text = "懒人奖励"; lazyRewards_text.font = chineseFont; lazyRewards_text.fontSize = 26;
        unfathomableWealth_text.text = "难以置信的财富"; unfathomableWealth_text.font = chineseFont; unfathomableWealth_text.fontSize = 15;
        ancientCoin_text.text = "古老硬币"; ancientCoin_text.font = chineseFont; ancientCoin_text.fontSize = 26;
        fortuneCoin_text.text = "幸运硬币"; fortuneCoin_text.font = chineseFont; fortuneCoin_text.fontSize = 26;
        wealthEmpire_text.text = "财富帝国"; wealthEmpire_text.font = chineseFont; wealthEmpire_text.fontSize = 26;
        luckyPenny_text.text = "幸运的便士"; luckyPenny_text.font = chineseFont; luckyPenny_text.fontSize = 26;
        fortune_text.text = "幸运"; fortune_text.font = chineseFont; fortune_text.fontSize = 26;
        extremelyWealthy_text.text = "极富"; extremelyWealthy_text.font = chineseFont; extremelyWealthy_text.fontSize = 21;
        wealthy_text.text = "富裕"; wealthy_text.font = chineseFont; wealthy_text.fontSize = 26;
        idlersMastery_text.text = "懒人的精通"; idlersMastery_text.font = chineseFont; idlersMastery_text.fontSize = 26;
        wealth_text.text = "财富"; wealth_text.font = chineseFont; wealth_text.fontSize = 26;
        potentCursors_text.text = "强大的光标"; potentCursors_text.font = chineseFont; potentCursors_text.fontSize = 26;
        mightyCursors_text.text = "强大的光标"; mightyCursors_text.font = chineseFont; mightyCursors_text.fontSize = 23;
        reforgedCursors_text.text = "重铸光标"; reforgedCursors_text.font = chineseFont; reforgedCursors_text.fontSize = 23;
        sloppyFist_text.text = "无力拳头"; sloppyFist_text.font = chineseFont; sloppyFist_text.fontSize = 26;
        effortless_text.text = "毫不费力的"; effortless_text.font = chineseFont; effortless_text.fontSize = 26;
        loungingKing_text.text = "懒散的国王"; loungingKing_text.font = chineseFont; loungingKing_text.fontSize = 26;
        loungingPirate_text.text = "懒散的海盗"; loungingPirate_text.font = chineseFont; loungingPirate_text.fontSize = 24;
        loungingOgre_text.text = "懒散的食人魔"; loungingOgre_text.font = chineseFont; loungingOgre_text.fontSize = 26;
        restfulIdler_text.text = "安静的懒人"; restfulIdler_text.font = chineseFont; restfulIdler_text.fontSize = 26;
        cursorMastery_text.text = "光标精通"; cursorMastery_text.font = chineseFont; cursorMastery_text.fontSize = 26;

        critDes1_text.text = ""; critDes1_text.font = chineseFont; critDes1_text.fontSize = 15;

        // Crit Descriptions
        critDes1_text.text = "<color=green>+0.5%<color=white> 暴击几率";
        critDes1_2_text.text = "<color=green>+150%<color=white> 暴击伤害";
        critDes2_text.text = "<color=green>+1.5%<color=white> 暴击几率";
        critDes2_2_text.text = "<color=green>+750%<color=white> 暴击伤害";
        critDes3_text.text = "<color=green>+1.8%<color=white> 暴击几率";
        critDes3_2_text.text = "<color=green>+1500%<color=white> 暴击伤害";
        critDes4_text.text = "<color=green>+2.2%<color=white> 暴击几率";
        critDes4_2_text.text = "每次暴击有 10% 的几率掉落一枚金币";
        critDes5_text.text = "<color=green>+2500%<color=white> 暴击伤害";
        critDes5_2_text.text = "每次暴击有 4% 的几率掉落一个宝物";

        critDes1_text.font = chineseFont;
        critDes1_2_text.font = chineseFont;
        critDes2_text.font = chineseFont;
        critDes2_2_text.font = chineseFont;
        critDes3_text.font = chineseFont;
        critDes3_2_text.font = chineseFont;
        critDes4_text.font = chineseFont;
        critDes4_2_text.font = chineseFont;
        critDes5_text.font = chineseFont;
        critDes5_2_text.font = chineseFont;

        critDes1_text.fontSize = 15;
        critDes1_2_text.fontSize = 15;
        critDes2_text.fontSize = 15;
        critDes2_2_text.fontSize = 15;
        critDes3_text.fontSize = 15;
        critDes3_2_text.fontSize = 15;
        critDes4_text.fontSize = 15;
        critDes4_2_text.fontSize = 15;
        critDes5_text.fontSize = 15;
        critDes5_2_text.fontSize = 15;

        // Active Descriptions
        activeDes1_text.text = "<color=green>+50%<color=white> 主动伤害";
        activeDes2_text.text = "<color=green>+325%<color=white> 主动伤害";
        activeDes3_text.text = "<color=green>+1000%<color=white> 主动伤害";
        activeDes4_text.text = "<color=green>+2250%<color=white> 主动伤害";
        activeDes4_2_text.text = "每次点击有 1% 的几率掉落一枚金币";
        activeDes5_text.text = "<color=green>+3500%<color=white> 主动伤害";
        activeDes5_2_text.text = "每次点击有 0.1% 的几率掉落一个宝物";
        activeDes6_text.text = "<color=green>+10000%<color=white> 主动伤害";
        activeDes6_2_text.text = "每次点击都有 +0.4% 的几率立即打开一个宝箱";
        activeDes7_text.text = "<color=green>+15000%<color=white> 主动伤害";
        activeDes7_2_text.text = "每次点击都有 1% 的几率掉落一个 5X 金币";

        activeDes1_text.font = chineseFont;
        activeDes2_text.font = chineseFont;
        activeDes3_text.font = chineseFont;
        activeDes4_text.font = chineseFont;
        activeDes4_2_text.font = chineseFont;
        activeDes5_text.font = chineseFont;
        activeDes5_2_text.font = chineseFont;
        activeDes6_text.font = chineseFont;
        activeDes6_2_text.font = chineseFont;
        activeDes7_text.font = chineseFont;
        activeDes7_2_text.font = chineseFont;

        activeDes1_text.fontSize = 15;
        activeDes2_text.fontSize = 15;
        activeDes3_text.fontSize = 15;
        activeDes4_text.fontSize = 15;
        activeDes4_2_text.fontSize = 15;
        activeDes5_text.fontSize = 15;
        activeDes5_2_text.fontSize = 15;
        activeDes6_text.fontSize = 15;
        activeDes6_2_text.fontSize = 15;
        activeDes7_text.fontSize = 15;
        activeDes7_2_text.fontSize = 14.9f;

        // Active Cursor Descriptions
        activeCursorDes1_text.text = "升级带有主动伤害、暴击几率和暴击伤害的光标会使它们变得更强大";
        activeCursorDes2_text.text = "升级带有主动伤害、暴击几率和暴击伤害的光标会使它们变得更强大";
        activeCursorDes3_text.text = "所有主动伤害、暴击几率和暴击伤害的光标初始效果更强";
        activeCursorDes4_text.text = "所有主动伤害、暴击几率和暴击伤害的光标初始效果更强";
        activeCursorDes4_2_text.text = "升级带有主动伤害、暴击几率和暴击伤害的光标会使它们变得更强大";

        activeCursorDes1_text.font = chineseFont;
        activeCursorDes2_text.font = chineseFont;
        activeCursorDes3_text.font = chineseFont;
        activeCursorDes4_text.font = chineseFont;
        activeCursorDes4_2_text.font = chineseFont;

        activeCursorDes1_text.fontSize = 14;
        activeCursorDes2_text.fontSize = 14;
        activeCursorDes3_text.fontSize = 14;
        activeCursorDes4_text.fontSize = 13;
        activeCursorDes4_2_text.fontSize = 12.6f;

        // Auto Clicker Descriptions
        autoClickerDes1_text.text = "自动点击器每秒执行 1 次点击";
        autoClickerDes1_2_text.text = "每次点击会造成你总主动伤害的 100%";
        autoClickerDes2_text.text = "自动点击器每秒执行 2 次点击";
        autoClickerDes3_text.text = "自动点击器每秒执行 4 次点击";
        autoClickerDes4_text.text = "自动点击器每秒执行 8 次点击";

        autoClickerDes1_text.font = chineseFont;
        autoClickerDes1_2_text.font = chineseFont;
        autoClickerDes2_text.font = chineseFont;
        autoClickerDes3_text.font = chineseFont;
        autoClickerDes4_text.font = chineseFont;

        autoClickerDes1_text.fontSize = 14;
        autoClickerDes1_2_text.fontSize = 14;
        autoClickerDes2_text.fontSize = 14;
        autoClickerDes3_text.fontSize = 14;
        autoClickerDes4_text.fontSize = 14;

        // Passive Descriptions
        passiveDes1_text.text = "<color=green>+25%<color=white> 被动伤害";
        passiveDes2_text.text = "<color=green>+115%<color=white> 被动伤害";
        passiveDes3_text.text = "<color=green>+400%<color=white> 被动伤害";
        passiveDes3_2_text.text = "每打开 7 个宝箱就会掉落 1 枚金币";
        passiveDes4_text.text = "<color=green>+850%<color=white> Passive damage";
        passiveDes4_2_text.text = "每打开 25 个宝箱就会掉落 1 个宝物";
        passiveDes5_text.text = "<color=green>+1100%<color=white> 被动伤害";
        passiveDes6_text.text = "<color=green>+1600%<color=white> 被动伤害";
        passiveDes6_2_text.text = "每打开 25 个宝箱就会掉落 1 个宝物和 4 枚金币";
        passiveDes7_text.text = "<color=green>+3500%<color=white> 被动伤害";
        passiveDes7_2_text.text = "每个宝箱都会额外掉落 1 枚金币";
        passiveDes8_text.text = "<color=green>+6500%<color=white> 被动伤害";

        passiveDes1_text.font = chineseFont;
        passiveDes2_text.font = chineseFont;
        passiveDes3_text.font = chineseFont;
        passiveDes3_2_text.font = chineseFont;
        passiveDes4_text.font = chineseFont;
        passiveDes4_2_text.font = chineseFont;
        passiveDes5_text.font = chineseFont;
        passiveDes6_text.font = chineseFont;
        passiveDes6_2_text.font = chineseFont;
        passiveDes7_text.font = chineseFont;
        passiveDes7_2_text.font = chineseFont;
        passiveDes8_text.font = chineseFont;

        passiveDes1_text.fontSize = 15;
        passiveDes2_text.fontSize = 15;
        passiveDes3_text.fontSize = 15;
        passiveDes3_2_text.fontSize = 15;
        passiveDes4_text.fontSize = 15;
        passiveDes4_2_text.fontSize = 15;
        passiveDes5_text.fontSize = 15;
        passiveDes6_text.fontSize = 15;
        passiveDes6_2_text.fontSize = 15;
        passiveDes7_text.fontSize = 15;
        passiveDes7_2_text.fontSize = 15;
        passiveDes8_text.fontSize = 15;

        // Passive Cursor Descriptions
        passiveCursorDes1_text.text = "升级带有被动伤害的光标会使它们变得更强大";
        passiveCursorDes2_text.text = "升级带有被动伤害的光标会使它们变得更强大";
        passiveCursorDes3_text.text = "初始效果更强的被动伤害光标";
        passiveCursorDes4_text.text = "初始效果更强的被动伤害光标";
        passiveCursorDes4_2_text.text = "升级带有被动伤害的光标会使它们变得更强大";
        passiveCursorDes5_text.text = "初始效果更强的被动伤害光标";
        passiveCursorDes5_2_text.text = "升级带有被动伤害的光标会使它们变得更强大";

        passiveCursorDes1_text.font = chineseFont;
        passiveCursorDes2_text.font = chineseFont;
        passiveCursorDes3_text.font = chineseFont;
        passiveCursorDes4_text.font = chineseFont;
        passiveCursorDes4_2_text.font = chineseFont;
        passiveCursorDes5_text.font = chineseFont;
        passiveCursorDes5_2_text.font = chineseFont;

        passiveCursorDes1_text.fontSize = 14;
        passiveCursorDes2_text.fontSize = 14;
        passiveCursorDes3_text.fontSize = 13.8f;
        passiveCursorDes4_text.fontSize = 13.8f;
        passiveCursorDes4_2_text.fontSize = 14;
        passiveCursorDes5_text.fontSize = 13.8f;
        passiveCursorDes5_2_text.fontSize = 14;

        // Gold Descriptions
        goldDes1_text.text = "金币可以额外获得 +30% 的金币";
        goldDes2_text.text = "金币可以额外获得 +120% 的金币";
        goldDes3_text.text = "金币可以额外获得 +500% 的金币";
        goldDes4_text.text = "金币可以额外获得 +1000% 的金币";
        goldDes4_2_text.text = "金币有 3% 的几率价值加倍";
        goldDes5_text.text = "宝箱有 3% 的几率掉落价值为 5X 金币的金币";
        goldDes6_text.text = "金币可以额外获得 +2000% 的金币";
        goldDes7_text.text = "宝箱有 2% 的几率掉落价值为 10X 金币的金币";
        goldDes7_2_text.text = "金币可以额外获得 +1250% 的金币";
        goldDes8_text.text = "宝箱有 1% 的几率掉落价值为 25X 金币的金币";
        goldDes8_2_text.text = "金币可以额外获得 +4000% 的金币";
        goldDes9_text.text = "宝箱只会掉落 5X、10X 和 25X 金币";
        goldDes9_2_text.text = "金币可以额外获得 +5000% 的金币";

        goldDes1_text.font = chineseFont;
        goldDes2_text.font = chineseFont;
        goldDes3_text.font = chineseFont;
        goldDes4_text.font = chineseFont;
        goldDes4_2_text.font = chineseFont;
        goldDes5_text.font = chineseFont;
        goldDes6_text.font = chineseFont;
        goldDes7_text.font = chineseFont;
        goldDes7_2_text.font = chineseFont;
        goldDes8_text.font = chineseFont;
        goldDes8_2_text.font = chineseFont;
        goldDes9_text.font = chineseFont;
        goldDes9_2_text.font = chineseFont;

        goldDes1_text.fontSize = 14;
        goldDes2_text.fontSize = 14;
        goldDes3_text.fontSize = 14;
        goldDes4_text.fontSize = 14;
        goldDes4_2_text.fontSize = 14;
        goldDes5_text.fontSize = 14;
        goldDes6_text.fontSize = 14;
        goldDes7_text.fontSize = 14;
        goldDes7_2_text.fontSize = 14;
        goldDes8_text.fontSize = 14;
        goldDes8_2_text.fontSize = 14;
        goldDes9_text.fontSize = 14;
        goldDes9_2_text.fontSize = 14;

        // Treasure Descriptions
        treasureDes1_text.text = "<color=green>+0.1% <color=white>宝藏掉落几率";
        treasureDes2_text.text = "<color=green>+0.2% <color=white>宝藏掉落几率";
        treasureDes3_text.text = "<color=green>+8% <color=white>的几率让一个宝物的价值翻倍。";
        treasureDes4_text.text = "<color=green>+5% <color=white>的几率让一个宝物的价值翻倍。";
        treasureDes4_2_text.text = "<color=green>+0.2% <color=white>宝藏掉落几率";
        treasureDes5_text.text = "<color=green>+10% <color=white>的几率让一个宝物的价值翻倍。";
        treasureDes5_2_text.text = "<color=green>+0.2% <color=white>宝藏掉落几率";
        treasureDes6_text.text = "<color=green>+13% <color=white>的几率让一个宝物的价值翻倍。";
        treasureDes6_2_text.text = "<color=green>+1% <color=white>宝物袋掉落几率";
        treasureDes7_text.text = "<color=green>+0.4% <color=white>宝藏掉落几率";
        treasureDes7_2_text.text = "出售宝物现在价值提高了 5X 的金币";

        treasureDes1_text.font = chineseFont;
        treasureDes2_text.font = chineseFont;
        treasureDes3_text.font = chineseFont;
        treasureDes4_text.font = chineseFont;
        treasureDes4_2_text.font = chineseFont;
        treasureDes5_text.font = chineseFont;
        treasureDes5_2_text.font = chineseFont;
        treasureDes6_text.font = chineseFont;
        treasureDes6_2_text.font = chineseFont;
        treasureDes7_text.font = chineseFont;
        treasureDes7_2_text.font = chineseFont;

        treasureDes1_text.fontSize = 14;
        treasureDes2_text.fontSize = 14;
        treasureDes3_text.fontSize = 14;
        treasureDes4_text.fontSize = 14;
        treasureDes4_2_text.fontSize = 14;
        treasureDes5_text.fontSize = 14;
        treasureDes6_text.fontSize = 14;
        treasureDes6_2_text.fontSize = 14;
        treasureDes7_text.fontSize = 14;
        treasureDes7_2_text.fontSize = 14;

        // XP Descriptions
        xpDes1_text.text = "<color=green>+35% <color=white>经验";
        xpDes2_text.text = "<color=green>+125% <color=white>经验";
        xpDes3_text.text = "<color=green>+400% <color=white>经验";
        xpDes4_text.text = "<color=green>+900% <color=white>经验";
        xpDes5_text.text = "<color=green>+1300% <color=white>经验";
        xpDes6_text.text = "<color=green>+2500% <color=white>经验 ";
        xpDes6_2_text.text = "每次经验掉落有 +0.25% 的几率获得 +1 技能点";
        xpDes7_text.text = "<color=green>+4000% <color=white>经验 ";
        xpDes7_2_text.text = "每次经验掉落有 +0.75% 的几率获得 +1 技能点";
        xpDes8_text.text = "<color=green>+7500% <color=white>经验 ";
        xpDes8_2_text.text = "每次经验掉落有 +1% 的几率获得 +1 技能点";

        xpDes1_text.font = chineseFont;
        xpDes2_text.font = chineseFont;
        xpDes3_text.font = chineseFont;
        xpDes4_text.font = chineseFont;
        xpDes5_text.font = chineseFont;
        xpDes6_text.font = chineseFont;
        xpDes6_2_text.font = chineseFont;
        xpDes7_text.font = chineseFont;
        xpDes7_2_text.font = chineseFont;
        xpDes8_text.font = chineseFont;
        xpDes8_2_text.font = chineseFont;

        xpDes1_text.fontSize = 15;
        xpDes2_text.fontSize = 15;
        xpDes3_text.fontSize = 15;
        xpDes4_text.fontSize = 15;
        xpDes5_text.fontSize = 15;
        xpDes6_text.fontSize = 15;
        xpDes6_2_text.fontSize = 15;
        xpDes7_text.fontSize = 15;
        xpDes7_2_text.fontSize = 15;
        xpDes8_text.fontSize = 15;
        xpDes8_2_text.fontSize = 15;

        // Level Special Descriptions
        levelSpecialDes1_text.text = "升级物品使其变得更强大";
        levelSpecialDes2_text.text = "升级物品使其变得更强大";
        levelSpecialDes3_text.text = "升级物品使其变得更强大";
        levelSpecialDes4_text.text = "升级物品使其变得更强大";
        levelSpecialDes5_text.text = "升级物品使其变得更强大";

        levelSpecialDes1_text.font = chineseFont;
        levelSpecialDes2_text.font = chineseFont;
        levelSpecialDes3_text.font = chineseFont;
        levelSpecialDes4_text.font = chineseFont;
        levelSpecialDes5_text.font = chineseFont;

        levelSpecialDes1_text.fontSize = 14;
        levelSpecialDes2_text.fontSize = 14;
        levelSpecialDes3_text.fontSize = 14;
        levelSpecialDes4_text.fontSize = 14;
        levelSpecialDes5_text.fontSize = 14;

        // Stronger Special Descriptions
        strongerSpecialDes1_text.text = "所有物品初始效果更强";
        strongerSpecialDes2_text.text = "所有物品初始效果更强";
        strongerSpecialDes3_text.text = "药水现在可以叠加 +1 次";
        strongerSpecialDes4_text.text = "从宝箱掉落的物品有 10% 的几率加倍价值";
        strongerSpecialDes5_text.text = "药水现在可以叠加 +1 次";
        strongerSpecialDes5_2_text.text = "所有物品初始效果更强";
        strongerSpecialDes6_text.text = "你现在可以叠加锤子、金手指、幸运卷轴和贪婪护手";
        strongerSpecialDes7_text.text = "幸运卷轴和古代遗物提供更强大的增益效果";

        strongerSpecialDes1_text.font = chineseFont;
        strongerSpecialDes2_text.font = chineseFont;
        strongerSpecialDes3_text.font = chineseFont;
        strongerSpecialDes4_text.font = chineseFont;
        strongerSpecialDes5_text.font = chineseFont;
        strongerSpecialDes5_2_text.font = chineseFont;
        strongerSpecialDes6_text.font = chineseFont;
        strongerSpecialDes7_text.font = chineseFont;

        strongerSpecialDes1_text.fontSize = 14;
        strongerSpecialDes2_text.fontSize = 14;
        strongerSpecialDes3_text.fontSize = 14;
        strongerSpecialDes4_text.fontSize = 14;
        strongerSpecialDes5_text.fontSize = 14;
        strongerSpecialDes5_2_text.fontSize = 14;
        strongerSpecialDes6_text.fontSize = 14;
        strongerSpecialDes7_text.fontSize = 14;

        // Start With Descriptions
        startWithDes1_text.text = "每次声望后，选择 1 个物品作为起始物品（只能选择已购买过的物品）";
        startWithDes2_text.text = "每次声望后，选择 2 个物品作为起始物品";
        startWithDes3_text.text = "每次声望后，选择 3 个物品作为起始物品";
        startWithDes4_text.text = "每次声望后，选择 5 个物品作为起始物品";

        startWithDes1_text.font = chineseFont;
        startWithDes2_text.font = chineseFont;
        startWithDes3_text.font = chineseFont;
        startWithDes4_text.font = chineseFont;

        startWithDes1_text.fontSize = 13;
        startWithDes2_text.fontSize = 13;
        startWithDes3_text.fontSize = 13;
        startWithDes4_text.fontSize = 13;

        // Reinforced Descriptions
        reinforcedDes1_text.text = "从强化宝箱掉落的金币现在价值 17X 的金币";
        reinforcedDes1_2_text.text = "<color=green>+0.1% <color=white>的几率获得强化宝箱的机会。";
        reinforcedDes2_text.text = "从强化宝箱掉落的金币现在价值 24X 的金币";
        reinforcedDes2_2_text.text = "强化宝箱现在有 9X 的生命值";
        reinforcedDes2_3_text.text = "强化宝箱现在掉落 6X 经验";
        reinforcedDes3_text.text = "从强化宝箱掉落的金币现在价值 33X 的金币";
        reinforcedDes3_2_text.text = "<color=green>+0.3% <color=white>的几率获得强化宝箱的机会。";
        reinforcedDes4_text.text = "从强化宝箱掉落的金币现在价值 47X 的金币";
        reinforcedDes4_2_text.text = "<color=green>+0.5% <color=white>的几率获得强化宝箱的机会。";
        reinforcedDes4_3_text.text = "强化宝箱现在有 8X 的生命值";
        reinforcedDes4_4_text.text = "强化宝箱现在掉落 11X 经验";
        reinforcedDes5_text.text = "从强化宝箱掉落的金币现在价值 85X 的金币";
        reinforcedDes5_2_text.text = "<color=green>+1% <color=white>的几率获得强化宝箱的机会。";

        reinforcedDes1_text.font = chineseFont;
        reinforcedDes1_2_text.font = chineseFont;
        reinforcedDes2_text.font = chineseFont;
        reinforcedDes2_2_text.font = chineseFont;
        reinforcedDes2_3_text.font = chineseFont;
        reinforcedDes3_text.font = chineseFont;
        reinforcedDes3_2_text.font = chineseFont;
        reinforcedDes4_text.font = chineseFont;
        reinforcedDes4_2_text.font = chineseFont;
        reinforcedDes4_3_text.font = chineseFont;
        reinforcedDes4_4_text.font = chineseFont;
        reinforcedDes5_text.font = chineseFont;
        reinforcedDes5_2_text.font = chineseFont;

        reinforcedDes1_text.fontSize = 13;
        reinforcedDes1_2_text.fontSize = 13;
        reinforcedDes2_text.fontSize = 13;
        reinforcedDes2_2_text.fontSize = 13;
        reinforcedDes2_3_text.fontSize = 13;
        reinforcedDes3_text.fontSize = 13;
        reinforcedDes3_2_text.fontSize = 13;
        reinforcedDes4_text.fontSize = 13;
        reinforcedDes4_2_text.fontSize = 13;
        reinforcedDes4_3_text.fontSize = 13;
        reinforcedDes4_4_text.fontSize = 13;
        reinforcedDes5_text.fontSize = 13;
        reinforcedDes5_2_text.fontSize = 13;

        // More Loot Descriptions
        moreLootDes1_text.text = "每打开 10 个宝箱就会额外掉落 1 枚金币";
        moreLootDes2_text.text = "每打开 19 个宝箱就会额外掉落 1 枚 5X 金币，并提供 3X 经验";
        moreLootDes3_text.text = "每打开 18 个宝箱就会额外掉落 2-4 枚金币，全部为 5X 或 10X 金币，还提供 5X 经验";
        moreLootDes4_text.text = "每打开 30 个宝箱就会额外掉落 3 枚金币，全部为 25X 金币，并额外掉落 2-5 个宝物";
        moreLootDes5_text.text = "每个宝箱都会额外掉落 1 枚 5X 金币，有 5% 的几率掉落 10X 金币和 2.5% 的几率掉落 25X 金币，还会额外掉落 2X 经验";

        moreLootDes1_text.font = chineseFont;
        moreLootDes2_text.font = chineseFont;
        moreLootDes3_text.font = chineseFont;
        moreLootDes4_text.font = chineseFont;
        moreLootDes5_text.font = chineseFont;

        moreLootDes1_text.fontSize = 13;
        moreLootDes2_text.fontSize = 13;
        moreLootDes3_text.fontSize = 13;
        moreLootDes4_text.fontSize = 13;
        moreLootDes5_text.fontSize = 13;

        // New Chests Descriptions
        newChestsDes1_text.text = "强化黄金宝箱有 0.2% 的几率出现";
        newChestsDes1_2_text.text = "强化黄金宝箱有 30X 的生命值。将锁匠工具和钥匙用于它只会移除 33% 的宝箱生命值";
        newChestsDes1_3_text.text = "了解更多关于此宝箱的信息，一旦它出现或在设置中查看";
        newChestsDes2_text.text = "首领 宝箱有 0.1% 的几率出现";
        newChestsDes2_2_text.text = "首领 宝箱有 100X 的生命值\n首领 宝箱将掉落 25 枚金币，全部为 10X 和 25X 金币";
        newChestsDes2_3_text.text = "了解更多关于此宝箱的信息，一旦它出现或在设置中查看";
        newChestsDes3_text.text = "首领 宝箱有 +0.05% 的几率出现";
        newChestsDes3_2_text.text = "强化黄金宝箱有 +0.1% 的几率出现";
        newChestsDes4_text.text = "首领 宝箱有 +0.1% 的几率出现";
        newChestsDes4_2_text.text = "强化黄金宝箱有 +0.15% 的几率出现";
        newChestsDes4_3_text.text = "强化黄金宝箱掉落 25 个宝物\n首领 宝箱掉落 30 枚金币";
        newChestsDes5_text.text = "强化黄金宝箱掉落 30 个宝物\n首领 宝箱掉落 35 枚金币，全部为 25X 金币";
        newChestsDes5_2_text.text = "强化黄金宝箱有 +0.2% 的几率出现";
        newChestsDes5_3_text.text = "首领 宝箱有 +0.15% 的几率出现";
        newChestsDes6_text.text = "首领 宝箱有 +0.4% 的几率出现";
        newChestsDes6_2_text.text = "强化黄金宝箱有 +0.75% 的几率出现";
        newChestsDes6_3_text.text = "首领 宝箱掉落 20X 经验。强化黄金宝箱掉落 12X 经验。这两个宝箱有更高几率掉落稀有宝物";

        newChestsDes1_text.font = chineseFont;
        newChestsDes1_2_text.font = chineseFont;
        newChestsDes1_3_text.font = chineseFont;
        newChestsDes2_text.font = chineseFont;
        newChestsDes2_2_text.font = chineseFont;
        newChestsDes2_3_text.font = chineseFont;
        newChestsDes3_text.font = chineseFont;
        newChestsDes3_2_text.font = chineseFont;
        newChestsDes4_text.font = chineseFont;
        newChestsDes4_2_text.font = chineseFont;
        newChestsDes4_3_text.font = chineseFont;
        newChestsDes5_text.font = chineseFont;
        newChestsDes5_2_text.font = chineseFont;
        newChestsDes5_3_text.font = chineseFont;
        newChestsDes6_text.font = chineseFont;
        newChestsDes6_2_text.font = chineseFont;
        newChestsDes6_3_text.font = chineseFont;

        newChestsDes1_text.fontSize = 12;
        newChestsDes1_2_text.fontSize = 12;
        newChestsDes1_3_text.fontSize = 9.5f;
        newChestsDes2_text.fontSize = 13;
        newChestsDes2_2_text.fontSize = 13;
        newChestsDes2_3_text.fontSize = 9.5f;
        newChestsDes3_text.fontSize = 12;
        newChestsDes3_2_text.fontSize = 12;
        newChestsDes4_text.fontSize = 12;
        newChestsDes4_2_text.fontSize = 12;
        newChestsDes4_3_text.fontSize = 12;
        newChestsDes5_text.fontSize = 12;
        newChestsDes5_2_text.fontSize = 12;
        newChestsDes5_3_text.fontSize = 12;
        newChestsDes6_text.fontSize = 12;
        newChestsDes6_2_text.fontSize = 12;
        newChestsDes6_3_text.fontSize = 12;

        #endregion

        #region Other
        maxPurchaseText_text.text = "购买最大"; maxPurchaseText_text.font = chineseFont; maxPurchaseText_text.fontSize = 32;
        youCanAlsoHoldDown_text.text = "您还可以按住左控制键购买最大数量"; youCanAlsoHoldDown_text.font = chineseFont; youCanAlsoHoldDown_text.fontSize = 12;

        X1_text1.text = "X1"; X1_text1.font = chineseFont; X1_text1.fontSize = 35;
        X1_text2.text = "X1"; X1_text2.font = chineseFont; X1_text2.fontSize = 32;
        X1_text3.text = "X1"; X1_text3.font = chineseFont; X1_text3.fontSize = 32;
        MAX_text1.text = "最大"; MAX_text1.font = chineseFont; MAX_text1.fontSize = 35;
        MAX_text2.text = "最大"; MAX_text2.font = chineseFont; MAX_text2.fontSize = 32;
        MAX_text3.text = "最大"; MAX_text3.font = chineseFont; MAX_text3.fontSize = 32;

        activeDamageBar_text.text = "主动伤害"; activeDamageBar_text.font = chineseFont; activeDamageBar_text.fontSize = 36;
        activeDamageACTIVE_text.text = "主动伤害"; activeDamageACTIVE_text.font = chineseFont; activeDamageACTIVE_text.fontSize = 21;
        activeDamageLEVEL_text.text = "等级"; activeDamageLEVEL_text.font = chineseFont; activeDamageLEVEL_text.fontSize = 27;

        passiveDamageBar_text.text = "被动伤害"; passiveDamageBar_text.font = chineseFont; passiveDamageBar_text.fontSize = 36;
        passivePASSIVE_Text.text = "被动伤害"; passivePASSIVE_Text.font = chineseFont; passivePASSIVE_Text.fontSize = 20;
        passiveLEVEL_text.text = "等级"; passiveLEVEL_text.font = chineseFont; passiveLEVEL_text.fontSize = 27;

        welcome.text = "欢迎！"; welcome.font = chineseFont; welcome.fontSize = 21;
        beforeWeCanStartPlaying.text = "在我们开始玩之前，您希望在屏幕上显示多少战利品，然后战利品才会自动收集？"; beforeWeCanStartPlaying.font = chineseFont; beforeWeCanStartPlaying.fontSize = 11.4f;
        changeAnyTime.text = "您可以随时在设置中更改此设置E"; changeAnyTime.font = chineseFont; changeAnyTime.fontSize = 10;
        playGame.text = "播放"; playGame.font = chineseFont; playGame.fontSize = 65;

        welcomeBack.text = "欢迎回来!"; welcomeBack.font = chineseFont; welcomeBack.fontSize = 65;
        thisHappendWhileGone.text = "这是您离开期间发生的事情..."; thisHappendWhileGone.font = chineseFont; thisHappendWhileGone.fontSize = 27;
        cool.text = "很酷！"; cool.font = chineseFont; cool.fontSize = 42;
        timeGone.text = "离开时间："; timeGone.font = chineseFont; timeGone.fontSize = 55;

        #endregion

        //Text That Changes
        #region info settings
        enchantedGoldenChestHealth = "-强化黄金宝箱有 <color=red>" + UpdateGame.enchantedGoldenChestHealth + " 倍的生命值";
        enchantedGoldenChestTreasureDrops = "-掉落" + UpdateGame.enchantedGoldenChestTreasureDrops + " 个宝物";
        enchantedGoldenChestXPDrop = "-<color=orange>+" + UpdateGame.enchantedGoldenChestXPDrops + "倍经验掉落";

        bossChestHealth = "-首领宝箱有  <color=red>" + UpdateGame.bossChestHealth + "倍的生命值";
        bossChestGoldValue = "-金币价值 =  <color=yellow>" + UpdateGame.bossChestGoldValue + "倍金币";
        bossChestGoldCoins = "-会掉落" + UpdateGame.bossChestGoldCoinsDrops + " 枚金币，全部为 10X 和 25X 金币";
        bossChestGoldCoins2 = "-<color=yellow>会掉落" + UpdateGame.bossChestGoldCoinsDrops + " 枚金币，全部为 25X 金币.";
        bossChestXP = "-<color=orange>+" + UpdateGame.bossChestXPDrops + "倍经验掉落";

        reinforcedHealth = "-强化宝箱有 <color=red>" + UpdateGame.reinforcedChestHealth + "倍的生命值";
        reinforcedGold = "-金币掉落可获得<color=yellow>" + UpdateGame.reinforcedChestGoldIncrease + "倍的金币";
        reinforcedXP = "<color=orange>+" + UpdateGame.reinforcedXPIncrease + "倍经验掉落";

        reinforcedInfo = "强化宝箱具有" + UpdateGame.reinforcedChestHealth + "倍的生命值、" + UpdateGame.reinforcedChestGoldIncrease + "倍的金币奖励和" + UpdateGame.reinforcedXPIncrease + "倍的经验奖励。";

        enchantedChestInfo = (100 - UpdateGame.enchantedGoldenChestChance).ToString("F2") + "%生成几率\n强化金宝箱具有" + UpdateGame.enchantedGoldenChestHealth + "倍的生命值，掉落" + UpdateGame.enchantedGoldenChestTreasureDrops + "个宝藏和" + UpdateGame.enchantedGoldenChestXPDrops + "倍的经验奖励。\n 使用挑锁器或钥匙仅会移除宝箱生命值的33%。\n此外，强化金宝箱也有略高的几率掉落稀有宝藏。";

        bossChestInfo1 = (UpdateGame.bossChestChance).ToString("F2") + "%生成几率\nB首领宝箱具有" + UpdateGame.bossChestHealth + "倍的生命值。金币价值增加" + UpdateGame.bossChestGoldValue + "倍。首领宝箱掉落" + UpdateGame.bossChestGoldCoinsDrops + "个金币，这些金币价值分别为10倍或25倍。(首领宝箱金币价值=（当前宝箱金币价值*5）*10或25）此外，还提供" + UpdateGame.bossChestXPDrops + "倍的经验奖励\n使用挑锁器或钥匙仅会移除宝箱生命值的25%.\n首领宝箱也有略高的几率掉落稀有宝藏。";

        bossChestInfo2 = (UpdateGame.bossChestChance).ToString("F2") + "%生成几率\nB首领宝箱具有" + UpdateGame.bossChestHealth + "倍的生命值。金币价值增加" + UpdateGame.bossChestGoldValue + "倍。首领宝箱掉落" + UpdateGame.bossChestGoldCoinsDrops + "个金币，这些金币价值分别为倍25倍。(首领宝箱金币价值=（当前宝箱金币价值*5）*25）此外，还提供" + UpdateGame.bossChestXPDrops + "倍的经验奖励\n使用挑锁器或钥匙仅会移除宝箱生命值的25%.\n首领宝箱也有略高的几率掉落稀有宝藏。";

        purchaseTheEnchanted = "购买强化黄金宝箱威望升级以查看信息";
        purchaseTheBossChest = "购买首领宝箱威望升级以查看信息";

        reinforcedChestsDescription_text2.font = chineseFont; reinforcedChestsDescription_text2.fontSize = 12;

        enchantedGoldenChestsDescription_text.font = chineseFont; enchantedGoldenChestsDescription_text.fontSize = 10;

        bossChestsDescription_text.font = chineseFont; bossChestsDescription_text.fontSize = 10;
        #endregion

        #region stats
        goldCoinsDropped = "金币掉落: ";
        totalGoldReceived = "总金币收益: ";
        totalBarrelGold = "总桶中的金币: ";
        treasuresDropped = "宝藏掉落: ";
        commonTreasures = "普通宝藏: ";
        uncommonTreasures = "非常宝藏: ";
        rareTreasures = "稀有宝藏: ";
        veryRareTreasures = "极其稀有宝藏: ";
        extremelyRareTreasures = "超级稀有宝藏: ";
        legendaryTreasures = "传奇宝藏: ";
        ultraTreasures = "极致宝藏: ";
        mythicTreasures = "神秘宝藏: ";
        eternalTreasures = "永恒宝藏: ";
        treasuresDoubled = "宝藏翻倍: ";
        chestsOpened = "宝箱打开: ";
        reinforcedChestsOpened = "强化宝箱打开: ";
        enchantedGoldenChestsOpened = "强化金宝箱打开: ";
        bossChestsOpened = "首领宝箱打开: ";
        chestClicks = "宝箱点击: ";
        autoClicks = "自动点击: ";
        criticalHits = "暴击次数: ";
        activeDamage = "主动伤害: ";
        passiveDamage = "被动伤害: ";
        critChance = "暴击几率: ";
        critDamage = "暴击伤害: ";
        cursorsLeveledUp = "游标升级: ";
        coinsSpawnedFromClicks = "点击产生的金币: ";
        treasuresSpawnedFromClicks = "点击产生的宝藏: ";
        itemsUsed = "物品使用: ";
        itemsDropped = "物品掉落: ";
        itemsPurchased = "物品购买: ";
        itemsLeveledUp = "物品升级: ";
        prestigeCount = "声望次数: ";
        prestigeUpgradesPurchased = "声望升级购买: ";
        skillPointsReceived = "技能点数获得: ";
        goldIncrease = "金币增加: ";
        xpIncrease = "经验增加: ";
        activeDamageIncrease = "主动伤害增加: ";
        passiveDamageIncrease = "被动伤害增加: ";
        critChanceIncrease = "暴击几率增加: ";
        critDamageIncrease = "暴击伤害增加: ";
        treasureChanceIncrease = "宝藏几率增加: ";
        goldCoins5xDropped = "5倍金币掉落:  ";
        goldCoins10xDropped = "10倍金币掉落: ";
        goldCoins25xDropped = "25倍金币掉落: ";
        goldCoins100xDropped = "100倍金币掉落: ";

        goldCoinsDropped_text.font = chineseFont; goldCoinsDropped_text.fontSize = 27;
        totalGoldReceived_text.font = chineseFont; totalGoldReceived_text.fontSize = 27;
        totalBarrelGold_text.font = chineseFont; totalBarrelGold_text.fontSize = 27;
        treasuresDropped_text.font = chineseFont; treasuresDropped_text.fontSize = 27;
        commonTreasures_text.font = chineseFont; commonTreasures_text.fontSize = 27;
        uncommonTreasures_text.font = chineseFont; uncommonTreasures_text.fontSize = 27;
        rareTreasures_text.font = chineseFont; rareTreasures_text.fontSize = 27;
        veryRareTreasures_text.font = chineseFont; veryRareTreasures_text.fontSize = 27;
        extremelyRareTreasures_text.font = chineseFont; extremelyRareTreasures_text.fontSize = 27;
        legendaryTreasures_text.font = chineseFont; legendaryTreasures_text.fontSize = 27;
        ultraTreasures_text.font = chineseFont; ultraTreasures_text.fontSize = 27;
        mythicTreasures_text.font = chineseFont; mythicTreasures_text.fontSize = 27;
        eternalTreasures_text.font = chineseFont; eternalTreasures_text.fontSize = 27;
        treasuresDoubled_text.font = chineseFont; treasuresDoubled_text.fontSize = 27;
        chestsOpened_text.font = chineseFont; chestsOpened_text.fontSize = 27;
        reinforcedChestsOpened_text.font = chineseFont; reinforcedChestsOpened_text.fontSize = 25;
        enchantedGoldenChestsOpened_text.font = chineseFont; enchantedGoldenChestsOpened_text.fontSize = 27;
        bossChestsOpened_text.font = chineseFont; bossChestsOpened_text.fontSize = 27;
        chestClicks_text.font = chineseFont; chestClicks_text.fontSize = 27;
        autoClicks_text.font = chineseFont; autoClicks_text.fontSize = 27;
        criticalHits_text.font = chineseFont; criticalHits_text.fontSize = 27;
        activeDamage_text.font = chineseFont; activeDamage_text.fontSize = 27;
        passiveDamage_text.font = chineseFont; passiveDamage_text.fontSize = 27;
        critChance_text.font = chineseFont; critChance_text.fontSize = 27;
        critDamage_text.font = chineseFont; critDamage_text.fontSize = 27;
        cursorsLeveledUp_text.font = chineseFont; cursorsLeveledUp_text.fontSize = 27;
        coinsSpawnedFromClicks_text.font = chineseFont; coinsSpawnedFromClicks_text.fontSize = 27;
        treasuresSpawnedFromClicks_text.font = chineseFont; treasuresSpawnedFromClicks_text.fontSize = 24;
        itemsUsed_text.font = chineseFont; itemsUsed_text.fontSize = 27;
        itemsDropped_text.font = chineseFont; itemsDropped_text.fontSize = 27;
        itemsPurchased_text.font = chineseFont; itemsPurchased_text.fontSize = 27;
        itemsLeveledUp_text.font = chineseFont; itemsLeveledUp_text.fontSize = 27;
        prestigeCount_text.font = chineseFont; prestigeCount_text.fontSize = 27;
        prestigeUpgradesPurchased_text.font = chineseFont; prestigeUpgradesPurchased_text.fontSize = 27;
        skillPointsReceived_text.font = chineseFont; skillPointsReceived_text.fontSize = 27;
        goldIncrease_text.font = chineseFont; goldIncrease_text.fontSize = 27;
        xpIncrease_text.font = chineseFont; xpIncrease_text.fontSize = 27;
        activeDamageIncrease_text.font = chineseFont; activeDamageIncrease_text.fontSize = 27;
        passiveDamageIncrease_text.font = chineseFont; passiveDamageIncrease_text.fontSize = 27;
        critChanceIncrease_text.font = chineseFont; critChanceIncrease_text.fontSize = 27;
        critDamageIncrease_text.font = chineseFont; critDamageIncrease_text.fontSize = 27;
        treasureChanceIncrease_text.font = chineseFont; treasureChanceIncrease_text.fontSize = 27;
        goldCoins5xDropped_text.font = chineseFont; goldCoins5xDropped_text.fontSize = 27;
        goldCoins10xDropped_text.font = chineseFont; goldCoins10xDropped_text.fontSize = 27;
        goldCoins25xDropped_text.font = chineseFont; goldCoins25xDropped_text.fontSize = 27;
        goldCoins100xDropped_text.font = chineseFont; goldCoins100xDropped_text.fontSize = 27;
        #endregion

        #region cursors
        NOdot = "";

        upgrade = "升级";
        upgradeMax = "升级（最大）";

        lvl = "等级 ";

        price = "价格： ";
        damage = "伤害: ";

        equipped = "已装备";
        unequpped = "未装备";

        equippedNONE = "已装备 =<color=red>";

        cursor1Equipped = "已装备 = <color=green>轻轻一点";
        cursor2Equipped = "已装备 = <color=green>轻松一掌";
        cursor3Equipped = "已装备 = <color=green>狂风";
        cursor4Equipped = "已装备 = <color=green>光芒之触";
        cursor5Equipped = "已装备 = <color=green>能量涌动";
        cursor6Equipped = "已装备 = <color=green>幻影手掌";
        cursor7Equipped = "已装备 = <color=green>钢铁打击";
        cursor8Equipped = "已装备 = <color=green>致命之触";
        cursor9Equipped = "已装备 = <color=green>精确之点";
        cursor10Equipped = "已装备 = <color=green>漩涡轻点";
        cursor11Equipped = "已装备 = <color=green>诅咒之爪";
        cursor12Equipped = "已装备 = <color=green>狙击点击";
        cursor13Equipped = "已装备 = <color=green>阴影涌动";
        cursor14Equipped = "已装备 = <color=green>致命压碎";
        cursor15Equipped = "已装备 = <color=green>迅捷点击";
        cursor16Equipped = "已装备 = <color=green>天界之触";
        cursor17Equipped = "已装备 = <color=green>秘法点击";
        cursor18Equipped = "已装备 = <color=green>永恒之触";
        cursor19Equipped = "已装备 = <color=green>厄运之触";
        cursor20Equipped = "已装备 = <color=green>太阳扫过";
        cursor21Equipped = "已装备 = <color=green>地狱之拳";

        for (int i = 0; i < 21; i++)
        {
            lvlsHover_text[i].font = chineseFont; lvlsHover_text[i].fontSize = 24;

            equippedHover_text[i].font = chineseFont; equippedHover_text[i].fontSize = 28;
            level_text[i].font = chineseFont; level_text[i].fontSize = 39;
        }

        equippedEquals_text.font = chineseFont; equippedEquals_text.fontSize = 23f;
        dpsTopBar_text.font = chineseFont; dpsTopBar_text.fontSize = 29f;
        clickDamageTopBar_text.font = chineseFont; clickDamageTopBar_text.fontSize = 29f;
        critChanceTopBar_text.font = chineseFont; critChanceTopBar_text.fontSize = 29f;
        critDamageTopBar_text.font = chineseFont; critDamageTopBar_text.fontSize = 29f;

        noNotUnlcoked_text.font = chineseFont; noNotUnlcoked_text.fontSize = 70f;

        cursor1ActiveDamage_Text.font = chineseFont; cursor1ActiveDamage_Text.fontSize = 20f;

        cursor2PassiveDamage_Text.font = chineseFont; cursor2PassiveDamage_Text.fontSize = 20f;

        cursor3CritChance_Text.font = chineseFont; cursor3CritChance_Text.fontSize = 20f;
        cursor3CritDamage_Text.font = chineseFont; cursor3CritDamage_Text.fontSize = 20f;

        cursor4ActiveDamage_Text.font = chineseFont; cursor4ActiveDamage_Text.fontSize = 20f;
        cursor4PassiveDamage_Text.font = chineseFont; cursor4PassiveDamage_Text.fontSize = 20f;

        cursor5ActiveDamage_Text.font = chineseFont; cursor5ActiveDamage_Text.fontSize = 20f;
        cursor5CritChance_Text.font = chineseFont; cursor5CritChance_Text.fontSize = 20f;
        cursor5CritDamage_Text.font = chineseFont; cursor5CritDamage_Text.fontSize = 20f;

        cursor6ActiveDamage_Text.font = chineseFont; cursor6ActiveDamage_Text.fontSize = 20f;
        cursor6PassiveDamage_Text.font = chineseFont; cursor6PassiveDamage_Text.fontSize = 20f;
        cursor6CritChance_Text.font = chineseFont; cursor6CritChance_Text.fontSize = 20f;
        cursor6CritDamage_Text.font = chineseFont; cursor6CritDamage_Text.fontSize = 20f;

        cursor7ActiveDamage_Text.font = chineseFont; cursor7ActiveDamage_Text.fontSize = 20f;
        cursor7CritChance_Text.font = chineseFont; cursor7CritChance_Text.fontSize = 20f;
        cursor7CritDamage_Text.font = chineseFont; cursor7CritDamage_Text.fontSize = 20f;

        cursor8ActiveDamage_Text.font = chineseFont; cursor8ActiveDamage_Text.fontSize = 20f;
        cursor8PassiveDamage_Text.font = chineseFont; cursor8PassiveDamage_Text.fontSize = 20f;
        cursor8CritChance_Text.font = chineseFont; cursor8CritChance_Text.fontSize = 20f;
        cursor8CritDamage_Text.font = chineseFont; cursor8CritDamage_Text.fontSize = 20f;

        cursor9ActiveDamage_Text.font = chineseFont; cursor9ActiveDamage_Text.fontSize = 20f;
        cursor9PassiveDamage_Text.font = chineseFont; cursor9PassiveDamage_Text.fontSize = 20f;

        cursor10PassiveDamage_Text.font = chineseFont; cursor10PassiveDamage_Text.fontSize = 20f;

        cursor11ActiveDamage_Text.font = chineseFont; cursor11ActiveDamage_Text.fontSize = 20f;
        cursor11CritChance_Text.font = chineseFont; cursor11CritChance_Text.fontSize = 20f;
        cursor11CritDamage_Text.font = chineseFont; cursor11CritDamage_Text.fontSize = 20f;

        cursor12ActiveDamage_Text.font = chineseFont; cursor12ActiveDamage_Text.fontSize = 20f;
        cursor12PassiveDamage_Text.font = chineseFont; cursor12PassiveDamage_Text.fontSize = 20f;
        cursor12CritChance_Text.font = chineseFont; cursor12CritChance_Text.fontSize = 20f;
        cursor12CritDamage_Text.font = chineseFont; cursor12CritDamage_Text.fontSize = 20f;

        cursor13ActiveDamage_Text.font = chineseFont; cursor13ActiveDamage_Text.fontSize = 20f;
        cursor13PassiveDamage_Text.font = chineseFont; cursor13PassiveDamage_Text.fontSize = 20f;
        cursor13CritChance_Text.font = chineseFont; cursor13CritChance_Text.fontSize = 20f;
        cursor13CritDamage_Text.font = chineseFont; cursor13CritDamage_Text.fontSize = 20f;

        cursor14ActiveDamage_Text.font = chineseFont; cursor14ActiveDamage_Text.fontSize = 20f;
        cursor14PassiveDamage_Text.font = chineseFont; cursor14PassiveDamage_Text.fontSize = 20f;
        cursor14CritChance_Text.font = chineseFont; cursor14CritChance_Text.fontSize = 20f;
        cursor14CritDamage_Text.font = chineseFont; cursor14CritDamage_Text.fontSize = 20f;

        cursor15ActiveDamage_Text.font = chineseFont; cursor15ActiveDamage_Text.fontSize = 20f;
        cursor15PassiveDamage_Text.font = chineseFont; cursor15PassiveDamage_Text.fontSize = 20f;
        cursor15CritChance_Text.font = chineseFont; cursor15CritChance_Text.fontSize = 20f;
        cursor15CritDamage_Text.font = chineseFont; cursor15CritDamage_Text.fontSize = 20f;

        cursor16ActiveDamage_Text.font = chineseFont; cursor16ActiveDamage_Text.fontSize = 20f;
        cursor16PassiveDamage_Text.font = chineseFont; cursor16PassiveDamage_Text.fontSize = 20f;
        cursor16CritChance_Text.font = chineseFont; cursor16CritChance_Text.fontSize = 20f;
        cursor16CritDamage_Text.font = chineseFont; cursor16CritDamage_Text.fontSize = 20f;

        cursor17ActiveDamage_Text.font = chineseFont; cursor17ActiveDamage_Text.fontSize = 20f;
        cursor17PassiveDamage_Text.font = chineseFont; cursor17PassiveDamage_Text.fontSize = 20f;
        cursor17CritChance_Text.font = chineseFont; cursor17CritChance_Text.fontSize = 20f;
        cursor17CritDamage_Text.font = chineseFont; cursor17CritDamage_Text.fontSize = 20f;

        cursor18ActiveDamage_Text.font = chineseFont; cursor18ActiveDamage_Text.fontSize = 20f;
        cursor18PassiveDamage_Text.font = chineseFont; cursor18PassiveDamage_Text.fontSize = 20f;
        cursor18CritChance_Text.font = chineseFont; cursor18CritChance_Text.fontSize = 20f;
        cursor18CritDamage_Text.font = chineseFont; cursor18CritDamage_Text.fontSize = 20f;

        cursor19ActiveDamage_Text.font = chineseFont; cursor19ActiveDamage_Text.fontSize = 20f;
        cursor19PassiveDamage_Text.font = chineseFont; cursor19PassiveDamage_Text.fontSize = 20f;
        cursor19CritChance_Text.font = chineseFont; cursor19CritChance_Text.fontSize = 20f;
        cursor19CritDamage_Text.font = chineseFont; cursor19CritDamage_Text.fontSize = 20f;

        cursor20ActiveDamage_Text.font = chineseFont; cursor20ActiveDamage_Text.fontSize = 20f;
        cursor20PassiveDamage_Text.font = chineseFont; cursor20PassiveDamage_Text.fontSize = 20f;
        cursor20CritChance_Text.font = chineseFont; cursor20CritChance_Text.fontSize = 20f;
        cursor20CritDamage_Text.font = chineseFont; cursor20CritDamage_Text.fontSize = 20f;

        cursor21ActiveDamage_Text.font = chineseFont; cursor21ActiveDamage_Text.fontSize = 20f;
        cursor21PassiveDamage_Text.font = chineseFont; cursor21PassiveDamage_Text.fontSize = 20f;
        cursor21CritChance_Text.font = chineseFont; cursor21CritChance_Text.fontSize = 20f;
        cursor21CritDamage_Text.font = chineseFont; cursor21CritDamage_Text.fontSize = 20f;
        #endregion

        #region items and shop

        MAX = "最大";
        owned = "拥有: ";
        treasuresExplinationMark = "宝藏！";
        skillPointsExplinatinMark = " 技能点！";

        stack = "叠加 X";

        forTheNext = "在接下来的";
        seconds = "秒内";

        for (int i = 0; i < 17; i++)
        {
            itemsPrice_text[i].font = chineseFont; itemsPrice_text[i].fontSize = 20;
            itemsLvlHover_text[i].font = chineseFont; itemsLvlHover_text[i].fontSize = 24;
            itemsPriceHover_text[i].font = chineseFont; itemsPriceHover_text[i].fontSize = 18;
        }

        for (int i = 0; i < 14; i++)
        {
            owned_text[i].font = chineseFont; owned_text[i].fontSize = 22;
        }

        stack_text1.font = chineseFont; stack_text1.fontSize = 25f;
        stack_text2.font = chineseFont; stack_text2.fontSize = 25f;
        stack_text3.font = chineseFont; stack_text3.fontSize = 25f;
        stack_text4.font = chineseFont; stack_text4.fontSize = 25f;
        stack_text5.font = chineseFont; stack_text5.fontSize = 25f;
        stack_text6.font = chineseFont; stack_text6.fontSize = 25f;
        stack_text7.font = chineseFont; stack_text7.fontSize = 25f;
        stack_text8.font = chineseFont; stack_text8.fontSize = 25f;

        lockPickDropChance_text.font = chineseFont; lockPickDropChance_text.fontSize = 19f;
        lockPickInfo.font = chineseFont; lockPickInfo.fontSize = 23f;
        hammerInfo_text.font = chineseFont; hammerInfo_text.fontSize = 21f;
        hammerDropChance_text.font = chineseFont; hammerDropChance_text.fontSize = 19f;
        lootPotionInfo_text.font = chineseFont; lootPotionInfo_text.fontSize = 20f;
        lootPotionDropChance_text.font = chineseFont; lootPotionDropChance_text.fontSize = 19f;
        damagePotionInfo_text.font = chineseFont; damagePotionInfo_text.fontSize = 21f;
        damagePotionDropChance_text.font = chineseFont; damagePotionDropChance_text.fontSize = 19f;
        xpPotionInfo_text.font = chineseFont; xpPotionInfo_text.fontSize = 21f;
        xpPotionDropChance_text.font = chineseFont; xpPotionDropChance_text.fontSize = 19f;
        goldenTouchInfo_text.font = chineseFont; goldenTouchInfo_text.fontSize = 21f;
        goldenTouchDropChance_text.font = chineseFont; goldenTouchDropChance_text.fontSize = 19f;
        miniChestInfo_text.font = chineseFont; miniChestInfo_text.fontSize = 21f;
        keyInfo_text.font = chineseFont; keyInfo_text.fontSize = 17f;
        keyDropChance_text.font = chineseFont; keyDropChance_text.fontSize = 19f;
        treasureBagInfo_text.font = chineseFont; treasureBagInfo_text.fontSize = 19f;
        serendipityScrollInfo_text.font = chineseFont; serendipityScrollInfo_text.fontSize = 19f;
        serendipityScollDropChance_text.font = chineseFont; serendipityScollDropChance_text.fontSize = 19f;
        gauntletOfGreenInfo_text.font = chineseFont; gauntletOfGreenInfo_text.fontSize = 18f;
        gauntletOfGreenDropChance_text.font = chineseFont; gauntletOfGreenDropChance_text.fontSize = 19f;
        magicalElixirInfo.font = chineseFont; magicalElixirInfo.fontSize = 18f;
        magicalElixirDropChance_text.font = chineseFont; magicalElixirDropChance_text.fontSize = 19f;
        ancientRelicDropChance_text.font = chineseFont; ancientRelicDropChance_text.fontSize = 19f;
        enchantedHammerInfo_text.font = chineseFont; enchantedHammerInfo_text.fontSize = 18f;
        enchantedHammerDropChance_text.font = chineseFont; enchantedHammerDropChance_text.fontSize = 19f;
        treasurePotionInfo_text.font = chineseFont; treasurePotionInfo_text.fontSize = 18f;
        treasurePotionDropChance_text.font = chineseFont; treasurePotionDropChance_text.fontSize = 19f;
        barrelOfGoldTotalGold_text.font = chineseFont; barrelOfGoldTotalGold_text.fontSize = 13f;
        mimicChestSpawns_text.font = chineseFont; mimicChestSpawns_text.fontSize = 17f;
        mimicChestChanceForBuff_text.font = chineseFont; mimicChestChanceForBuff_text.fontSize = 15.4f;
        barrelOfGoldInfo_text.font = chineseFont; barrelOfGoldInfo_text.fontSize = 17f;

        //Item and mimic chest buffs
        goldBuffText_text.font = chineseFont; goldBuffText_text.fontSize = 14;
        lootPotionBuff_text.font = chineseFont; lootPotionBuff_text.fontSize = 14;
        damagePotionBuff_text.font = chineseFont; damagePotionBuff_text.fontSize = 12;
        damageBuff_text.font = chineseFont; damageBuff_text.fontSize = 12;
        treasureBuff_text.font = chineseFont; treasureBuff_text.fontSize = 11; treasureBuff_text.lineSpacing = -90;
        xpBuff_text.font = chineseFont; xpBuff_text.fontSize = 13;
        xpPotionBuff.font = chineseFont; xpPotionBuff.fontSize = 13;
        elixirGoldBuff_text.font = chineseFont; elixirGoldBuff_text.fontSize = 11;
        elixirXPBuff_text.font = chineseFont; elixirXPBuff_text.fontSize = 11;
        elixirDamageBuff_text.font = chineseFont; elixirDamageBuff_text.fontSize = 11;
        goldCoinsDropBuff_text.font = chineseFont; goldCoinsDropBuff_text.fontSize = 11;
        goldenTouchBuff.font = chineseFont; goldenTouchBuff.fontSize = 10;

        negativeGold_text.font = chineseFont; negativeGold_text.fontSize = 14;
        negativeDamage_text.font = chineseFont; negativeDamage_text.fontSize = 12;
        negativeTreasure_text.font = chineseFont; negativeTreasure_text.fontSize = 11;
        negativeXP_text.font = chineseFont; negativeXP_text.fontSize = 13;
        negativeGoldCoinsDrop_text.font = chineseFont; negativeGoldCoinsDrop_text.fontSize = 11.4f;

        goldBuffTimer_text.font = chineseFont; goldBuffTimer_text.fontSize = 10;
        lootPotionBuffTimer_text.font = chineseFont; lootPotionBuffTimer_text.fontSize = 10;
        damageBuffTimer_text.font = chineseFont; damageBuffTimer_text.fontSize = 10;
        damagePotionTimer_text.font = chineseFont; damagePotionTimer_text.fontSize = 10;
        treasureBuffTimer_text.font = chineseFont; treasureBuffTimer_text.fontSize = 10;
        xpBuffTimer_text.font = chineseFont; xpBuffTimer_text.fontSize = 10;
        XpPotionTimer_text.font = chineseFont; XpPotionTimer_text.fontSize = 10;
        elixirTimer_text.font = chineseFont; elixirTimer_text.fontSize = 10;
        goldCoinsDropsTimer_text.font = chineseFont; goldCoinsDropsTimer_text.fontSize = 10;
        treasurePotionTimer_Text.font = chineseFont; treasurePotionTimer_Text.fontSize = 10;
        goldenTouchTimer_text.font = chineseFont; goldenTouchTimer_text.fontSize = 10;
        rareTreasuresTimer_text.font = chineseFont; rareTreasuresTimer_text.fontSize = 10;
        negativeGoldtimer_Text.font = chineseFont; negativeGoldtimer_Text.fontSize = 10;
        negativeDamageTimer_text.font = chineseFont; negativeDamageTimer_text.fontSize = 10;
        negativeTreasureTimer_text.font = chineseFont; negativeTreasureTimer_text.fontSize = 10;
        negativeXPTimer_text.font = chineseFont; negativeXPTimer_text.fontSize = 10;
        negativeGoldCoinsDropTimer_text.font = chineseFont; negativeGoldCoinsDropTimer_text.fontSize = 10;
        #endregion

        #region Treasures
        chooseChickenBuff = "<color=green>点击橡皮鸡来选择增益属性。";

        foundRubberChickenRewards2_text.font = chineseFont; foundRubberChickenRewards2_text.fontSize = 7f;

        tDropChanceRussAndEng = "% 从宝箱中掉落的几率";
        youFoundThePrestigeKetAndChest = "";

        doubleInValue = "的几率翻倍";

        quartsGained = "获得的石英有";
        amethystGained = "获得的紫水晶有";
        yellowTopazGained = "获得的黄托帕石有";
        albiteGained = "获得的白钙石有";
        redGarnetGained = "获得的红石榴石有";
        aquamarineGained = "获得的海蓝宝石有";
        yellowShapphireGained = "获得的黄蓝宝石有";
        pinkTourmalineGained = "获得的粉碧玺有";
        adventurineGained = "获得的幸运石有";
        redRubyGained = "获得的红宝石有";
        diamondGained = "获得的钻石有";
        grandidieriteGained = "获得的格朗迪耶瑟翠有";
        violetCrystalGained = "获得的阿科亚珍珠有";
        akoyaPearlGained = "获得的紫色盧比有";
        purpleRupeeGained = "获得的翡翠有";
        emeraldGained = "获得的绿钻石有";
        greenDiamondGained = "获得的火焰蛋白石有";
        fireOpalGained = "获得的宝石矽化物有";
        gemSilicaGained = "获得的粉色黏液有";
        pinkPlortGained = "获得的粉色黏液有";
        goldenSeaPearlGained = "获得的黄金海珍珠有";
        kyaniteGained = "获得的矿物有";
        blackOpalGained = "获得的黑玛瑙有";
        painiteGained = "获得的痛苦石有";
        tanzaniteGained = "获得的坦桑石有";
        astraliumGained = "获得的星体有";
        elysiumPrismGained = "获得的艾利西亚棱镜有";
        aerthfireOpalGained = "获得的艾尔斯火蛋白石有";
        eldrichStarStoneGained = "获得的埃尔德里奇星石有";
        chronolithChardGained = "获得的时空碑碎片有";
        sideriumEssenceGained = "获得的锡德里姆精华有";
        quasariteGained = "获得的瓜达瑞特有";
        radiantNovaGained = "获得的辐射新星石有";
        soluniumShardGained = "获得的索伦尼姆碎片有";

        for (int i = 0; i < 34; i++)
        {
            treasureDropChanceText_text[i].font = chineseFont; treasureDropChanceText_text[i].fontSize = 23;
            treasreDoubleText_text[i].font = chineseFont; treasreDoubleText_text[i].fontSize = 20;
        }

        sellTreasureFor_text.font = chineseFont; sellTreasureFor_text.fontSize = 22; sellTreasureFor_text.lineSpacing = -90;
        sellTreasureFor = "出售以获得"; sellGold = "金币";

        #endregion

        #region Rare Treasures
        YOU_FOUND_A_SKULL = "你找到了一个骷髅！";
        YOU_FOUND_A_TROPHY = "你找到了一个奖杯！";
        YOU_FOUND_A_DEMONIC_SWORD = "你找到了一把邪恶之剑！";
        YOU_FOUND_A_RING = "你找到了一个戒指！";
        YOU_FOUND_A_STAR = "你找到了一颗星星！";
        YOU_FOUND_A_CLOVER = "你找到了一个幸运草！";
        YOU_FOUND_A_KINGS_CROWN = "你找到了一顶国王的皇冠！";
        YOU_FOUND_A_BOOK = "你找到了一本书！";
        YOU_FOUND_A_GUITAR = "你找到了一把吉他！";
        YOU_FOUND_A_TALARIAN = "你找到了一颗塔拉里安！";
        YOU_FOUND_A_STRANGE_RUNE = "你找到了一颗奇怪的符文！";
        YOU_FOUND_A_BACKPACK = "你找到了一个背包！";
        YOU_FOUND_A_SHIELD = "你找到了一个维京盾牌！";
        YOU_FOUND_A_PILL_BOTTLE = "你找到了一瓶药丸！";
        YOU_FOUND_A_MEDAL = "你找到了一枚胜利奖章！";
        YOU_FOUND_A_COOKIE = "你找到了一个饼干！";
        YOU_FOUND_A_CHRISTMAS_PRESENT = "你找到了一个圣诞礼物！";
        YOU_FOUND_A_BATTLE_AXE = "你找到了一把战斧！";
        YOU_FOUND_A_100X_GOLD_COIN = "你找到了一个100倍金币！";
        YOU_FOUND_A_SEALED_ENVELOPE = "你找到了一个密封信封！";
        YOU_FOUND_A_STRANGE_POTION = "你找到了一个奇怪的药水！";
        YOU_FOUND_A_SOUL_GEM = "你找到了一个灵魂宝石！";
        YOU_FOUND_AN_ANCIENT_SCROLL = "你找到了一个古老卷轴！";
        YOU_FOUND_A_BRICK = "你找到了一块砖块！";
        YOU_FOUND_A_RUBBER_CHICKEN = "你找到了一只橡皮鸡！";

        PIRATE_SKULL = "海盗骷髅";
        DEMONIC_SWORD = "邪恶之剑";
        MYSTIC_RING = "神秘之戒";
        TROPHY = "奖杯";
        FALLEN_STAR = "堕落之星";
        CLOVER = "幸运草";
        KINGS_CROWN = "国王的皇冠";
        SPELL_BOOK = "咒语书";
        GUITAR = "吉他";
        TALARIAN = "吉他";
        MYTHRUNE = "神秘符文";
        EXPLORER_BACKPACK = "探险家背包";
        VIKING_SHIELD = "维京盾牌";
        PILL_BOTTLE = "药瓶";
        VICTORY_MEDAL = "胜利奖章";
        COOKIE = "饼干";
        CHRISTMAS_PRESENT = "圣诞礼物";
        BATTLE_AXE = "战斧";
        GOLD_COIN_100X = "100倍金币";
        SEALED_ENVELOPE = "密封信封";
        STRANGE_POTION = "奇怪的药水";
        SOUL_GEM = "灵魂宝石";
        ANCIENT_SCROLL = "古老卷轴";
        BRICK = "砖块";
        RUBBER_CHICKEN = "橡皮鸡";

        demonicSwordSize = 22;
        mysticRingSize = 22;
        trophySize = 30;
        fallenStarSize = 21;
        cloverSize = 30;
        kingsCrownSize = 19;
        spellBookSize = 22;
        guitarSize = 29;
        talarianSize = 25;
        mythruneSize = 23;
        explorerBackpackSize = 19;
        skullSize = 22;
        rubberChickenSize = 22;
        brickSize = 30;
        ancientScrollSize = 22;
        soulGemSize = 22;
        strangePotionSize = 18;
        sealedEnvelopeSize = 20;
        goldCoin100XSize = 19;
        vikingShieldSize = 23;
        pillBottleSize = 24;
        victoryMedalSize = 22;
        cookieSize = 29;
        christmasPresentSize = 18;
        battleAxeSize = 22;

        pirateSkull_text.font = chineseFont; pirateSkull_text.fontSize = skullSize;
        demonicSword_text.font = chineseFont; demonicSword_text.fontSize = demonicSwordSize;
        mysticRing_text.font = chineseFont; mysticRing_text.fontSize = mysticRingSize;
        trophy_text.font = chineseFont; trophy_text.fontSize = trophySize;
        fallenStar_text.font = chineseFont; fallenStar_text.fontSize = fallenStarSize;
        clover_text.font = chineseFont; clover_text.fontSize = cloverSize;
        kingsCrown_text.font = chineseFont; kingsCrown_text.fontSize = kingsCrownSize;
        spellBook_text.font = chineseFont; spellBook_text.fontSize = spellBookSize;
        guitar_text.font = chineseFont; guitar_text.fontSize = guitarSize;
        talarian_text.font = chineseFont; talarian_text.fontSize = talarianSize;
        mythrune_text.font = chineseFont; mythrune_text.fontSize = mythruneSize;
        explorerBackpack_text.font = chineseFont; explorerBackpack_text.fontSize = explorerBackpackSize;
        vikingShield_text.font = chineseFont; vikingShield_text.fontSize = vikingShieldSize;
        pillBottle_text.font = chineseFont; pillBottle_text.fontSize = pillBottleSize;
        victoryMedal_text.font = chineseFont; victoryMedal_text.fontSize = victoryMedalSize;
        cookie_text.font = chineseFont; cookie_text.fontSize = cookieSize;
        christmasPresent_text.font = chineseFont; christmasPresent_text.fontSize = christmasPresentSize;
        battleAxe_text.font = chineseFont; battleAxe_text.fontSize = battleAxeSize;
        goldCoin100X_text.font = chineseFont; goldCoin100X_text.fontSize = goldCoin100XSize;
        sealedEnvelope_text.font = chineseFont; sealedEnvelope_text.fontSize = sealedEnvelopeSize;
        strangePotion_text.font = chineseFont; strangePotion_text.fontSize = strangePotionSize;
        soulGem_text.font = chineseFont; soulGem_text.fontSize = soulGemSize;
        ancientScroll_text.font = chineseFont; ancientScroll_text.fontSize = ancientScrollSize;
        brick_text.font = chineseFont; brick_text.fontSize = brickSize;
        rubberChicken_text.font = chineseFont; rubberChicken_text.fontSize = rubberChickenSize;



        if (RareTreasures.skullFound == 1)
        {
            pirateSkull_text.text = PIRATE_SKULL;
        }
        if (RareTreasures.swordFound == 1)
        {
            demonicSword_text.text = DEMONIC_SWORD;
        }
        if (RareTreasures.ringFound == 1)
        {
            mysticRing_text.text = MYSTIC_RING;
        }
        if (RareTreasures.trophyFound == 1)
        {
            trophy_text.text = TROPHY;
        }
        if (RareTreasures.starFound == 1)
        {
            fallenStar_text.text = FALLEN_STAR;
        }
        if (RareTreasures.cloverFound == 1)
        {
            clover_text.text = CLOVER;
        }
        if (RareTreasures.crownFound == 1)
        {
            kingsCrown_text.text = KINGS_CROWN;
        }
        if (RareTreasures.bookFound == 1)
        {
            spellBook_text.text = SPELL_BOOK;
        }
        if (RareTreasures.guitarFOund == 1)
        {
            guitar_text.text = GUITAR;
        }
        if (RareTreasures.talarianFound == 1)
        {
            talarian_text.text = TALARIAN;
        }
        if (RareTreasures.runeFound == 1)
        {
            mythrune_text.text = MYTHRUNE;
        }
        if (RareTreasures.backPackFound == 1)
        {
            explorerBackpack_text.text = EXPLORER_BACKPACK;
        }
        if (RareTreasures.shieldFound == 1)
        {
            vikingShield_text.text = VIKING_SHIELD;
        }
        if (RareTreasures.pillBottleFound == 1)
        {
            pillBottle_text.text = PILL_BOTTLE;
        }
        if (RareTreasures.medalFound == 1)
        {
            victoryMedal_text.text = VICTORY_MEDAL;
        }
        if (RareTreasures.cookieFound == 1)
        {
            cookie_text.text = COOKIE;
        }
        if (RareTreasures.presentFound == 1)
        {
            christmasPresent_text.text = CHRISTMAS_PRESENT;
        }
        if (RareTreasures.axeFound == 1)
        {
            battleAxe_text.text = BATTLE_AXE;
        }
        if (RareTreasures.coin100XFound == 1)
        {
            goldCoin100X_text.text = GOLD_COIN_100X;
        }
        if (RareTreasures.envelopeFound == 1)
        {
            sealedEnvelope_text.text = SEALED_ENVELOPE;
        }
        if (RareTreasures.potionFound == 1)
        {
            strangePotion_text.text = STRANGE_POTION;
        }
        if (RareTreasures.soulGemFound == 1)
        {
            soulGem_text.text = SOUL_GEM;
        }
        if (RareTreasures.scrollFound == 1)
        {
            ancientScroll_text.text = ANCIENT_SCROLL;
        }
        if (RareTreasures.brickFound == 1)
        {
            brick_text.text = BRICK;
        }
        if (RareTreasures.chickenFound == 1)
        {
            rubberChicken_text.text = RUBBER_CHICKEN;
        }

        foundRareTreasurePopUp_text.lineSpacing = -35;

        foundRareTreasurePopUp_text.font = chineseFont; foundRareTreasurePopUp_text.fontSize = 25;

        pirateSkull_text.lineSpacing = -105;
        demonicSword_text.lineSpacing = -105;
        mysticRing_text.lineSpacing = -105;
        trophy_text.lineSpacing = -105;
        fallenStar_text.lineSpacing = -105;
        clover_text.lineSpacing = -105;
        kingsCrown_text.lineSpacing = -105;
        spellBook_text.lineSpacing = -105;
        guitar_text.lineSpacing = -105;
        talarian_text.lineSpacing = -105;
        mythrune_text.lineSpacing = -105;
        explorerBackpack_text.lineSpacing = -105;
        vikingShield_text.lineSpacing = -105;
        pillBottle_text.lineSpacing = -105;
        victoryMedal_text.lineSpacing = -105;
        cookie_text.lineSpacing = -105;
        christmasPresent_text.lineSpacing = -105;
        battleAxe_text.lineSpacing = -105;
        goldCoin100X_text.lineSpacing = -105;
        sealedEnvelope_text.lineSpacing = -105;
        strangePotion_text.lineSpacing = -105;
        soulGem_text.lineSpacing = -105;
        ancientScroll_text.lineSpacing = -105;
        brick_text.lineSpacing = -105;
        rubberChicken_text.lineSpacing = -105;


        chooseText1_text.font = chineseFont; chooseText1_text.fontSize = 25f;
        chooseText2_text.font = chineseFont; chooseText2_text.fontSize = 25f;
        chooseText3_text.font = chineseFont; chooseText3_text.fontSize = 25f;
        chooseText4_text.font = chineseFont; chooseText4_text.fontSize = 25f;
        chooseText5_text.font = chineseFont; chooseText5_text.fontSize = 25f;
        chooseText6_text.font = chineseFont; chooseText6_text.fontSize = 23f;
        chooseText7_text.font = chineseFont; chooseText7_text.fontSize = 25f;


        price200SkillPoints_text.font = chineseFont; price200SkillPoints_text.fontSize = 12.6f;
        priceEqual = "价格 =";
        skillPoints200 = "技能点。";
        if (PlayerLevel.skillPoints >= 200)
        {
            price200SkillPoints_text.text = Localization.priceEqual + " <color=green>" + Localization.skillPoints200;
        }
        if (PlayerLevel.skillPoints < 200)
        {
            price200SkillPoints_text.text = Localization.priceEqual + " <color=red>" + Localization.skillPoints200;
        }
        #endregion

        #region Treasure Chests
        ON = "开启"; OFF = "关闭";

        GoldCoinsDrop = "金币掉落: ";
        goldCoinValue = "金币价值: ";
        XPDrop = "经验掉落: ";

        chestNumber = "宝箱."; chestNO = "号";

        reinforcedChestChance1 = ""; reinforcedChestChance2 = " 强化宝箱几率";

        WoodenChest = "木制宝箱";
        TimberwoodChest = "木材宝箱";
        RockboundChest = "岩石宝箱";
        BronzeChest = "青铜宝箱";
        SequoiaChest = "红杉宝箱";
        IronboundChest = "铁制宝箱";
        StoneshieldChest = "石盾宝箱";
        OceanChest = "海洋宝箱";
        PoisonousChest = "毒宝箱";
        GoldenChest = "黄金宝箱";
        DesertChest = "沙漠宝箱";
        PirateChest = "海盗宝箱";
        CrystalChest = "水晶宝箱";
        CelestialChest = "天界宝箱";
        PhantomChest = "幻影宝箱";
        PrismaticChest = "多彩宝箱";
        AquaticChest = "水生宝箱";
        WindwalkersChest = "风行者宝箱";
        EnchantedChest = "强化宝箱";
        RoyalChest = "皇家宝箱";
        ArcaneChest = "奥术宝箱";
        GrandioseChest = "宏伟宝箱";
        LuxuriousGoldenChest = "豪华黄金宝箱";
        SacredChest = "神圣宝箱";
        EternitysEmbraceChest = "永恒之拥宝箱";
        ForgottenChest = "被遗忘宝箱";
        LivingLuminousChest = "生命之光宝箱";
        FortressOfWealth = "财富堡垒";
        FortifiedTimberChest = "强化木材宝箱";
        RadiantFrostlock = "光辉霜锁";
        InfernoEmbracedChest = "烈火拥抱宝箱";
        DeathChest = "死亡宝箱";
        AlienChest = "外星宝箱";
        CraftsmansReliquary = "工匠的遗物库";
        HellfireGuardianChest = "地狱火守卫宝箱";
        GhastlySoulHoardChest = "幽灵灵魂储藏宝箱";
        HighTechCache = "高科技储藏宝箱";
        EliteHackersStrongbox = "精英黑客保险箱";
        CollectorsVault = "收藏家保险库";
        ExquisiteAzureRadianceChest = "精致的蔚蓝之光宝箱";

        TimberwoodChestUnlocked = "木材宝箱已解锁";
        RockboundChestUnlocked = "岩石宝箱已解锁";
        BronzeChestUnlocked = "青铜宝箱已解锁";
        SequoiaChestUnlocked = "红杉宝箱已解锁";
        IronboundChestUnlocked = "铁制宝箱已解锁";
        StoneshieldChestUnlocked = "石盾宝箱已解锁";
        OceanChestUnlocked = "海洋宝箱已解锁";
        PoisonousChestUnlocked = "毒宝箱已解锁";
        GoldenChestUnlocked = "黄金宝箱已解锁";
        DesertChestUnlocked = "沙漠宝箱已解锁";
        PirateChestUnlocked = "海盗宝箱已解锁";
        CrystalChestUnlocked = "水晶宝箱已解锁";
        CelestialChestUnlocked = "天界宝箱已解锁";
        PhantomChestUnlocked = "幻影宝箱已解锁";
        PrismaticChestUnlocked = "多彩宝箱已解锁";
        AquaticChestUnlocked = "水生宝箱已解锁";
        WindwalkersChestUnlocked = "风行者宝箱已解锁";
        EnchantedChestUnlocked = "强化宝箱已解锁";
        RoyalChestUnlocked = "皇家宝箱已解锁";
        ArcaneChestUnlocked = "奥术宝箱已解锁";
        GrandioseChestUnlocked = "宏伟宝箱已解锁";
        LuxuriousGoldenChestUnlocked = "豪华黄金宝箱已解锁";
        SacredChestUnlocked = "神圣宝箱已解锁";
        EternitysEmbraceChestUnlocked = "永恒之拥宝箱已解锁";
        ForgottenChestUnlocked = "被遗忘宝箱已解锁";
        LivingLuminousChestUnlocked = "生命之光宝箱已解锁";
        FortressOfWealthUnlocked = "财富堡垒已解锁";
        FortifiedTimberChestUnlocked = "强化木材宝箱已解锁";
        RadiantFrostlockUnlocked = "光辉霜锁已解锁";
        InfernoEmbracedChestUnlocked = "烈火拥抱宝箱已解锁";
        DeathChestUnlocked = "死亡宝箱已解锁";
        AlienChestUnlocked = "外星宝箱已解锁";
        CraftsmansReliquaryUnlocked = "工匠的遗物库已解锁";
        HellfireGuardianChestUnlocked = "地狱火守卫宝箱已解锁";
        GhastlySoulHoardChestUnlocked = "幽灵灵魂储藏宝箱已解锁";
        HighTechCacheUnlocked = "高科技储藏宝箱已解锁";
        EliteHackersStrongboxUnlocked = "精英黑客保险箱已解锁";
        CollectorsVaultUnlocked = "收藏家保险库已解锁";
        ExquisiteAzureRadianceChestUnlocked = "精致的蔚蓝之光宝箱已解锁";

        chestPrice_text.font = chineseFont; chestPrice_text.fontSize = 25;
        chestHP_text.font = chineseFont; chestHP_text.fontSize = 34;
        autoPurchaseONOFF_text.font = chineseFont; autoPurchaseONOFF_text.fontSize = 40;
        chestHoverName_text.font = chineseFont; chestHoverName_text.fontSize = 31;
        chestNO_text.font = chineseFont; chestNO_text.fontSize = 30;
        chestXPAmount_text.font = chineseFont; chestXPAmount_text.fontSize = 19;
        chestGoldCoins_text.font = chineseFont; chestGoldCoins_text.fontSize = 19;
        chestGoldAmount_text.font = chineseFont; chestGoldAmount_text.fontSize = 19;
        chestReinforcedChance.font = chineseFont; chestReinforcedChance.fontSize = 19;
        chestPurchasedName_text.font = chineseFont; chestPurchasedName_text.fontSize = 45;

        reinforcedHoverHealth_text.font = chineseFont; reinforcedHoverHealth_text.fontSize = 20;
        reinforcedHoverGold_text.font = chineseFont; reinforcedHoverGold_text.fontSize = 20;
        reinforcedHoverXP_text.font = chineseFont; reinforcedHoverXP_text.fontSize = 20;

        enchantedGoldenHoverHealth_text.font = chineseFont; enchantedGoldenHoverHealth_text.fontSize = 17;
        enchantedGoldenHoverTreasures_text.font = chineseFont; enchantedGoldenHoverTreasures_text.fontSize = 17;
        enchantedGoldenHoverXP_text.font = chineseFont; enchantedGoldenHoverXP_text.fontSize = 17;

        bossChestHoverHealth_text.font = chineseFont; bossChestHoverHealth_text.fontSize = 17;
        bossChestHoverGoldValue_text.font = chineseFont; bossChestHoverGoldValue_text.fontSize = 17;
        bossChestHoverGoldCoins_text.font = chineseFont; bossChestHoverGoldCoins_text.fontSize = 17;
        bossChestHoverXP_text.font = chineseFont; bossChestHoverXP_text.fontSize = 17;
        #endregion

        #region Prestige

        prestigeKeyChance1 = ""; prestigeKeyChance2 = "% 声望之钥掉落几率";
        prestieChestKey1 = ""; prestieChestKey2 = "% 声望宝箱掉落几率";

        FindThePrestigeKeyandChest = "寻找声望之钥和声望宝箱";
        youFoundThePrestigeKetAndChest = "你找到了声望之钥和声望宝箱！";

        youFoundPrestigeKey = "您找到了声望之钥！";
        youFoundPrestigeChest = "您找到了声望之箱！";

        nextLevelHover = "下一级 = +"; skillPointsHover = " 技能点";

        choseItemToStartWith = "选择 1 个物品作为起始物品";
        chooseItemsToStartWith2 = "选择 2 个物品作为起始物品";
        chooseItemsToStartWith3 = "选择 3 个物品作为起始物品";
        chooseItemsToStartWith5 = "选择 5 个物品作为起始物品";


        findThePrestigeKeyAncChest_text.font = chineseFont; findThePrestigeKeyAncChest_text.fontSize = 11.5f;


        if (SpawnRewards.prestigeKeyFound == 0)
        {
            findThePrestigeKeyAncChest_text.text = FindThePrestigeKeyandChest;
        }
        if (SpawnRewards.prestigeChestFound == 0)
        {
            findThePrestigeKeyAncChest_text.text = FindThePrestigeKeyandChest;
        }
        if (SpawnRewards.prestigeChestFound == 1 && SpawnRewards.prestigeKeyFound == 1)
        {
            findThePrestigeKeyAncChest_text.text = youFoundThePrestigeKetAndChest;
        }

        prestigeKeyDropChance_text.font = chineseFont; prestigeKeyDropChance_text.fontSize = 20;
        prestigeChestDropChance_text.font = chineseFont; prestigeChestDropChance_text.fontSize = 20;
        prestigeKeyDropChance_text.text = Localization.prestigeKeyChance1 + 0.017 * (UnlockChests.timesPurchasedChests + 1) + Localization.prestigeKeyChance2;
        prestigeChestDropChance_text.text = Localization.prestieChestKey1 + 0.017 * (UnlockChests.timesPurchasedChests + 1) + Localization.prestieChestKey2;

        nextLeveEqualSkillPoints_text.font = chineseFont; nextLeveEqualSkillPoints_text.fontSize = 55;
        nextLeveEqualSkillPoints_text.text = Localization.nextLevelHover + "<color=green>+" + ((PlayerLevel.playerLevel / 5) + 1) + "<color=white>" + Localization.skillPointsHover;


        chooseItemToStartWith_text.font = chineseFont; chooseItemToStartWith_text.fontSize = 42;
        #endregion

        #region Other
        level = "等级 ";
        xpNoPercent = "经验";
        crit = "暴击！";

        totalGold_text.font = chineseFont; totalGold_text.fontSize = 46;
        levelText_text.font = chineseFont; levelText_text.fontSize = 36; levelText_text.text = "等级 " + PlayerLevel.playerLevel;
        xpNeededText_text.font = chineseFont; xpNeededText_text.fontSize = 15;
        activeDamageAmount_text.font = chineseFont; activeDamageAmount_text.fontSize = 20f;
        passiveDamageAmount_text.font = chineseFont; passiveDamageAmount_text.fontSize = 20f;
        acitveDamagePrice_text.font = chineseFont; acitveDamagePrice_text.fontSize = 18f;
        passiveDamagePrice_text.font = chineseFont; passiveDamagePrice_text.fontSize = 18f;
        activeDamageLEVELAmount_text.font = chineseFont; activeDamageLEVELAmount_text.fontSize = 30f;
        passiveLEVELAmount_text.font = chineseFont; passiveLEVELAmount_text.fontSize = 30f;
        passiveDamageUPGRADE_text.font = chineseFont; passiveDamageUPGRADE_text.fontSize = 20f;
        activeDamageUPGRADE_text.font = chineseFont; activeDamageUPGRADE_text.fontSize = 20f;

        youOpened.font = chineseFont; youOpened.fontSize = 40; youOpened.lineSpacing = -70;
        timeGoneTotal.font = chineseFont; timeGoneTotal.fontSize = 40;

        damageUnderChest.font = chineseFont; damageUnderChest.fontSize = 6;
        #endregion

        ChangeAllText();
    }
    #endregion

    #region Korean  
    public void KoreanLanguage()
    {
        JapaneseLanguageChosen = 0;
        RussianLanguageChosen = 0;
        EnglishLanguageChosen = 0;
        ChineseLanguageChosen = 0;
        KoreanLanguageChosen = 1;

        if (PlaceMobileButtons.isMobile == true) { ChangeMobileText(); }

        PlayerPrefs.SetInt("SaveEnglish", EnglishLanguageChosen);
        PlayerPrefs.SetInt("SaveRussian", RussianLanguageChosen);
        PlayerPrefs.SetInt("SaveJapanese", JapaneseLanguageChosen);
        PlayerPrefs.SetInt("SaveChinese", ChineseLanguageChosen);
        PlayerPrefs.SetInt("SaveKorean", KoreanLanguageChosen);

        #region TotalGold Strings
        Million = "만";
        Billion = "억";
        Trillion = "조";
        Quadrillion = "1000조";
        Quintillion = "100경";
        Sextillion = "10해";
        Septillion = "자";
        Octillion = "1000자";
        Nonillion = "100양";
        Decillion = "10구";
        Undecillion = "간";
        Duodecillion = "1000간";
        Tredecillion = "100정";
        Quattuordecillion = "10재";
        Quindecillion = "극";
        Sexdecillion = "1000극";
        Septendecillion = "100항하사";
        Octodecillion = "10아승기";
        Novemdecillion = "나유타";
        Vigintillion = "1000나유타";
        Unvigintillion = "100불가사의";
        Duovigintillion = "무량대수";
        Trevigintillion = "무량대수";

        MillionShort = "만";
        BillionShort = "억";
        TrillionShort = "조";
        QuadrillionShort = "1000조";
        QuintillionShort = "100경";
        SextillionShort = "10해";
        SeptillionShort = "자";
        OctillionShort = "1000자";
        NonillionShort = "100양";
        DecillionShort = "10구";
        UndecillionShort = "간";
        DuodecillionShort = "1000간";
        TredecillionShort = "100정";
        QuattuordecillionShort = "10재";
        QuindecillionShort = "극";
        SexdecillionShort = "1000극";
        SeptendecillionShort = "100항하사";
        OctodecillionShort = "10아승기";
        NovemdecillionShort = "나유타";
        VigintillionShort = "1000나유타";
        UnvigintillionShort = "100불가사의";
        DuovigintillionShort = "무량대수";
        TrevigintillionShort = "무량대수";
        #endregion

        #region Pluss Buffs Strings
        gold = "골드";
        goldPercentString = "% 골드";

        clickDamage = "클릭 데미지";
        activeDamageTop = "액티브 데미지";
        dps = "초당 데미지";
        passiveDamageString = "% 패시브 데미지";
        activeDamageScring = "% 액티브 데미지";
        critChanceString = "% 크리티컬 가능성";
        critDamageString = "% 크리티컬 데미지";

        damagePercent = "% 데미지";
        xp = "% XP";
        treasureDropChance = "% 보물 드롭 확률";
        goldCoinsDrop = "골드 코인 드롭";

        friendlyMimic = "우호적인 모방! ";
        evilMimic = "악의적인 모방! ";
        secondsMimic = "초간";

        rareTreasureDropChance = "+레이 보물 드롭 확률";
        #endregion



        #region Settings Text
        settings_text.text = "설정"; settings_text.font = koreanFont; settings_text.fontSize = 36;

        general_text.text = "일반"; general_text.font = koreanFont; general_text.fontSize = 19;

        info_text.text = "정보"; info_text.font = koreanFont; info_text.fontSize = 20;

        music_text.text = "음악"; music_text.font = koreanFont; music_text.fontSize = 25;

        sound_text.text = "소리"; sound_text.font = koreanFont; sound_text.fontSize = 24;

        miniChestAndMimicChestSpawnSound_text.text = "작은 상자와 모방 상자 스폰 소리"; miniChestAndMimicChestSpawnSound_text.font = koreanFont; miniChestAndMimicChestSpawnSound_text.fontSize = 16;

        mimicChestSpawning_text.text = "모방 상자 스폰 중"; mimicChestSpawning_text.font = koreanFont; mimicChestSpawning_text.fontSize = 20;

        fullscreen_text.text = "전체화면"; fullscreen_text.font = koreanFont; fullscreen_text.fontSize = 15;

        onFullScreen_text.text = "켬"; onFullScreen_text.font = koreanFont; onFullScreen_text.fontSize = 30;

        offFullScreen_text.text = "끔"; offFullScreen_text.font = koreanFont; offFullScreen_text.fontSize = 30;

        onMimicSpawn_text.text = "켬"; onMimicSpawn_text.font = koreanFont; onMimicSpawn_text.fontSize = 30;

        offMimicSpawn_text.text = "끔"; offMimicSpawn_text.font = koreanFont; offMimicSpawn_text.fontSize = 30;

        onMiniAndMimicSound_text.text = "켬"; onMiniAndMimicSound_text.font = koreanFont; onMiniAndMimicSound_text.fontSize = 30;

        offMiniAndMimicSound_text.text = "끔"; offMiniAndMimicSound_text.font = koreanFont; offMiniAndMimicSound_text.fontSize = 30;

        resolution_text.text = "해상도"; resolution_text.font = koreanFont; resolution_text.fontSize = 19;

        exit_text.text = "나가기"; exit_text.font = koreanFont; exit_text.fontSize = 45;

        save_text.text = "저장하기"; save_text.font = koreanFont; save_text.fontSize = 24;

        gameSavesEvery15Seconds_text.text = "게임은 매 15초마다 저장됩니다"; gameSavesEvery15Seconds_text.font = koreanFont; gameSavesEvery15Seconds_text.fontSize = 11;

        cantSaveDuringPrestige_text.text = "프레스티지 간 저장할 수 없습니다"; cantSaveDuringPrestige_text.font = koreanFont; cantSaveDuringPrestige_text.fontSize = 20;

        resetGame_text.text = "게임 초기화"; resetGame_text.font = koreanFont; resetGame_text.fontSize = 16; resetGame_text.lineSpacing = -90;

        discord_text.text = "디스코드"; discord_text.font = koreanFont; discord_text.fontSize = 32;

        numberOfCoinsAndTreasuresOnScreen_text.text = "자동으로 수집되기 전, 화면에 있는 코인과 보물 수"; numberOfCoinsAndTreasuresOnScreen_text.font = koreanFont; numberOfCoinsAndTreasuresOnScreen_text.fontSize = 16;

        reinforcedChests_text.text = "강화 상자들"; reinforcedChests_text.font = koreanFont; reinforcedChests_text.fontSize = 17;

        reinforcedChestsDescription_text.text = "각 상자들은 강화 상자가 될 기회를 갖고 있습니다. 강화 기회는 어떤 상자를 구매했느냐에 달려있습니다. "; reinforcedChestsDescription_text.font = koreanFont; reinforcedChestsDescription_text.fontSize = 10;


        enchantedGoldenChests_text.text = "마법에 걸린 황금 상자"; enchantedGoldenChests_text.font = koreanFont; enchantedGoldenChests_text.fontSize = 17;

        bossChests_text.text = "보스 상자"; bossChests_text.font = koreanFont; bossChests_text.fontSize = 17;

        musicBy_text.text = "음악: Kevin MacLeod - Arpent"; musicBy_text.font = koreanFont; musicBy_text.fontSize = 15;

        developerInfo_text.text = "보물 상자 클리커는  Simon Eftestøl에 의해 개발되었습니다. "; developerInfo_text.font = koreanFont; developerInfo_text.fontSize = 15;

        resetConfirmation_text.text = "모든 것을 초기화하시겠어요?"; resetConfirmation_text.font = koreanFont; resetConfirmation_text.fontSize = 20;

        yes_text.text = "예"; yes_text.font = koreanFont; yes_text.fontSize = 55;

        no_text.text = "아니오"; no_text.font = koreanFont; no_text.fontSize = 55;

        gameSaves_Text.text = "게임 저장됨!"; gameSaves_Text.font = koreanFont; gameSaves_Text.fontSize = 15;
        #endregion

        #region stats
        stats_text.text = "스탯"; stats_text.font = koreanFont; stats_text.fontSize = 40;
        goldAndTreasures_text.text = "골드 & 보물"; goldAndTreasures_text.font = koreanFont; goldAndTreasures_text.fontSize = 45;
        chests_text.text = "상자"; chests_text.font = koreanFont; chests_text.fontSize = 55;
        damage_text.text = "데미지"; damage_text.font = koreanFont; damage_text.fontSize = 55;
        items.text = "아이템"; items.font = koreanFont; items.fontSize = 55;
        buffsAndPrestige_text.text = "버프 & 프레스티지"; buffsAndPrestige_text.font = koreanFont; buffsAndPrestige_text.fontSize = 45;
        #endregion

        #region Achievements
        achievements_text.text = "업적"; achievements_text.font = koreanFont; achievements_text.fontSize = 40;
        drop25GoldCoins_text.text = "상자에서 25개의 골드 코인을 드롭하세요"; drop25GoldCoins_text.font = koreanFont; drop25GoldCoins_text.fontSize = 24;
        drop1000GoldCoins_text.text = "상자에서 1000개의 골드 코인을 드롭하세요"; drop1000GoldCoins_text.font = koreanFont; drop1000GoldCoins_text.fontSize = 24;
        drop100000GoldCoins_text.text = "상자에서 100 000개의 골드 코인을 드롭하세요"; drop100000GoldCoins_text.font = koreanFont; drop100000GoldCoins_text.fontSize = 24;
        drop1MillionGoldCoins_text.text = "상자에서 100만개의 골드 코인을 드롭하세요"; drop1MillionGoldCoins_text.font = koreanFont; drop1MillionGoldCoins_text.fontSize = 24;
        total100Gold_text.text = "총 100 골드를 소유하세요"; total100Gold_text.font = koreanFont; total100Gold_text.fontSize = 24;
        total100000Gold_text.text = "총 100 000 골드를 소유하세요"; total100000Gold_text.font = koreanFont; total100000Gold_text.fontSize = 24;
        total1MillionGold_text.text = "총 100만 골드를 소유하세요"; total1MillionGold_text.font = koreanFont; total1MillionGold_text.fontSize = 24;
        total1BillionGold_text.text = "총 10억 골드를 소유하세요"; total1BillionGold_text.font = koreanFont; total1BillionGold_text.fontSize = 24;
        total1TrillionGold_text.text = "총 1조 골드를 소유하세요"; total1TrillionGold_text.font = koreanFont; total1TrillionGold_text.fontSize = 24;

        //10
        total1QuadrillionGold_text.text = "총 100 골드를 소유하세요"; total1QuadrillionGold_text.font = koreanFont; total1QuadrillionGold_text.fontSize = 24;
        total1QuintillionGold_text.text = "총 1000조 골드를 소유하세요"; total1QuintillionGold_text.font = koreanFont; total1QuintillionGold_text.fontSize = 24;
        total1SextillionGold_text.text = "총 100 골드를 소유하세요"; total1SextillionGold_text.font = koreanFont; total1SextillionGold_text.fontSize = 24;
        total1SeptillionGold_text.text = "총 1자 골드를 소유하세요"; total1SeptillionGold_text.font = koreanFont; total1SeptillionGold_text.fontSize = 24;
        total1OctillionGold_text.text = "총 1000자 골드를 소유하세요"; total1OctillionGold_text.font = koreanFont; total1OctillionGold_text.fontSize = 24;
        total1NonillionGold_text.text = "총 100양 골드를 소유하세요"; total1NonillionGold_text.font = koreanFont; total1NonillionGold_text.fontSize = 24;
        total1DecillionGold_text.text = "총 10구 골드를 소유하세요"; total1DecillionGold_text.font = koreanFont; total1DecillionGold_text.fontSize = 24;
        total1NovemdecillionGold_text.text = "총 1나유타 골드를 소유하세요"; total1NovemdecillionGold_text.font = koreanFont; total1NovemdecillionGold_text.fontSize = 24;
        drop5XGoldCoin_text.text = "5X 골드 코인을 드롭하세요"; drop5XGoldCoin_text.font = koreanFont; drop5XGoldCoin_text.fontSize = 24;
        drop1000_5XGoldCoins_text.text = "1000, 5X 골드 코인을 드롭하세요"; drop1000_5XGoldCoins_text.font = koreanFont; drop1000_5XGoldCoins_text.fontSize = 24;

        //20
        drop50000_5XGoldCoins_text.text = "50000, 5X 골드 코인을 드롭하세요"; drop50000_5XGoldCoins_text.font = koreanFont; drop50000_5XGoldCoins_text.fontSize = 24;
        drop10XGoldCoin_text.text = "10X 골드 코인을 드롭하세요"; drop10XGoldCoin_text.font = koreanFont; drop10XGoldCoin_text.fontSize = 24;
        drop1000_10XGoldCoins_text.text = "1000, 10X 골드 코인을 드롭하세요"; drop1000_10XGoldCoins_text.font = koreanFont; drop1000_10XGoldCoins_text.fontSize = 24;
        drop15000_10XGoldCoins_text.text = "15000, 10X 골드 코인을 드롭하세요"; drop15000_10XGoldCoins_text.font = koreanFont; drop15000_10XGoldCoins_text.fontSize = 24;
        spawn10GoldCoinsFromClicks_text.text = "클릭으로부터 10 골드 코인을 스폰하세요"; spawn10GoldCoinsFromClicks_text.font = koreanFont; spawn10GoldCoinsFromClicks_text.fontSize = 24;
        spawn100GoldCoinsFromClicks_text.text = "클릭으로부터 100 골드 코인을 스폰하세요"; spawn100GoldCoinsFromClicks_text.font = koreanFont; spawn100GoldCoinsFromClicks_text.fontSize = 24;
        spawn1000GoldCoinsFromClicks_text.text = "클릭으로부터 1000 골드 코인을 스폰하세요"; spawn1000GoldCoinsFromClicks_text.font = koreanFont; spawn1000GoldCoinsFromClicks_text.fontSize = 24;
        oneTreasureDropped_text.text = "상자로부터 보물 1개가 드롭되었습니다"; oneTreasureDropped_text.font = koreanFont; oneTreasureDropped_text.fontSize = 24;
        hundredTreasuresDropped_text.text = "상자로부터 보물 100개가 드롭되었습니다"; hundredTreasuresDropped_text.font = koreanFont; hundredTreasuresDropped_text.fontSize = 24;
        thousandTreasuresDropped_text.text = "상자로부터 보물 1000개가 드롭되었습니다"; thousandTreasuresDropped_text.font = koreanFont; thousandTreasuresDropped_text.fontSize = 24;
        tenThousandTreasuresDropped_text.text = "상자로부터 보물 10000개가 드롭되었습니다"; tenThousandTreasuresDropped_text.font = koreanFont; tenThousandTreasuresDropped_text.fontSize = 24;
        fiftyThousandTreasuresDropped_text.text = "상자로부터 보물 50000개가 드롭되었습니다"; fiftyThousandTreasuresDropped_text.font = koreanFont; fiftyThousandTreasuresDropped_text.fontSize = 24;

        //30 (Continued from 20)
        hundredCommonTreasures_text.text = "상자로부터 커먼 보물 100개가 드롭되었습니다"; hundredCommonTreasures_text.font = koreanFont; hundredCommonTreasures_text.fontSize = 22;
        hundredUncommonTreasures_text.text = "상자로부터 언커먼 보물 100개가 드롭되었습니다"; hundredUncommonTreasures_text.font = koreanFont; hundredUncommonTreasures_text.fontSize = 22;
        hundredRareTreasures_text.text = "상자로부터 레어 보물 100개가 드롭되었습니다"; hundredRareTreasures_text.font = koreanFont; hundredRareTreasures_text.fontSize = 22;
        hundredVeryRareTreasures_text.text = "상자로부터 매우 레어한 보물 100개가 드롭되었습니다"; hundredVeryRareTreasures_text.font = koreanFont; hundredVeryRareTreasures_text.fontSize = 22;
        hundredExtremelyRareTreasures_text.text = "상자로부터 극적으로 레어한 보물 100개가 드롭되었습니다"; hundredExtremelyRareTreasures_text.font = koreanFont; hundredExtremelyRareTreasures_text.fontSize = 24;
        hundredLegendaryTreasures_text.text = "상자로부터 레전드 보물 100개가 드롭되었습니다"; hundredLegendaryTreasures_text.font = koreanFont; hundredLegendaryTreasures_text.fontSize = 24;
        spawn10TreasuresFromClicks_text.text = "클릭으로부터 10개의 보물을 스폰하세요"; spawn10TreasuresFromClicks_text.font = koreanFont; spawn10TreasuresFromClicks_text.fontSize = 24;
        spawn100TreasuresFromClicks_text.text = "클릭으로부터 100개의 보물을 스폰하세요"; spawn100TreasuresFromClicks_text.font = koreanFont; spawn100TreasuresFromClicks_text.fontSize = 24;
        spawn1000TreasuresFromClicks_text.text = "클릭으로부터 1000개의 보물을 스폰하세요"; spawn1000TreasuresFromClicks_text.font = koreanFont; spawn1000TreasuresFromClicks_text.fontSize = 24;
        hundredTreasuresDoubled_text.text = "가치가 두 배로 높아진 보물 100개 "; hundredTreasuresDoubled_text.font = koreanFont; hundredTreasuresDoubled_text.fontSize = 24;

        //40 (Continued from 30)
        find1RareTreasure_text.text = "레어 보물 1개를 찾으세요"; find1RareTreasure_text.font = koreanFont; find1RareTreasure_text.fontSize = 24;
        find3RareTreasures_text.text = "레어 보물 3개를 찾으세요"; find3RareTreasures_text.font = koreanFont; find3RareTreasures_text.fontSize = 24;
        find5RareTreasures_text.text = "레어 보물 5개를 찾으세요"; find5RareTreasures_text.font = koreanFont; find5RareTreasures_text.fontSize = 24;
        find13RareTreasures_text.text = "레어 보물 13개를 찾으세요"; find13RareTreasures_text.font = koreanFont; find13RareTreasures_text.fontSize = 24;
        findAll25RareTreasures_text.text = "레어 보물 25개를 찾으세요"; findAll25RareTreasures_text.font = koreanFont; findAll25RareTreasures_text.fontSize = 24;
        findTheCookie_text.text = "쿠키를 찾으세요!"; findTheCookie_text.font = koreanFont; findTheCookie_text.fontSize = 24;
        cookieClicker_text.text = "쿠키 클리커!"; cookieClicker_text.font = koreanFont; cookieClicker_text.fontSize = 24;
        prestige_text.text = "프레스티지"; prestige_text.font = koreanFont; prestige_text.fontSize = 24;
        prestige5Times_text.text = "프레스티지 5회"; prestige5Times_text.font = koreanFont; prestige5Times_text.fontSize = 24;
        prestige15Times_text.text = "프레스티지 15회"; prestige15Times_text.font = koreanFont; prestige15Times_text.fontSize = 24;

        //50 (Continued from 40)
        purchase5PrestigeUpgrades_text.text = "프레스티지 업그레이드 5개를 구매하세요"; purchase5PrestigeUpgrades_text.font = koreanFont; purchase5PrestigeUpgrades_text.fontSize = 24;
        purchase15PrestigeUpgrades_text.text = "프레스티지 업그레이드 15개를 구매하세요"; purchase15PrestigeUpgrades_text.font = koreanFont; purchase15PrestigeUpgrades_text.fontSize = 24;
        purchase35PrestigeUpgrades_text.text = "프레스티지 업그레이드 35개를 구매하세요"; purchase35PrestigeUpgrades_text.font = koreanFont; purchase35PrestigeUpgrades_text.fontSize = 24;
        purchase60PrestigeUpgrades_text.text = "프레스티지 업그레이드 60개를 구매하세요"; purchase60PrestigeUpgrades_text.font = koreanFont; purchase60PrestigeUpgrades_text.fontSize = 24;
        purchaseAllPrestigeUpgrades_text.text = "모든 프레스티지 업그레이드를 구매하세요"; purchaseAllPrestigeUpgrades_text.font = koreanFont; purchaseAllPrestigeUpgrades_text.fontSize = 24;
        purchaseAllPrestigeClickerUpgrades_text.text = "모든 프레스티지 클리커 업그레이드를 구매하세요"; purchaseAllPrestigeClickerUpgrades_text.font = koreanFont; purchaseAllPrestigeClickerUpgrades_text.fontSize = 24;
        purchaseAllPrestigeLoungerUpgrades_text.text = "모든 프레스티지 라운저 업그레이드를 구매하세요"; purchaseAllPrestigeLoungerUpgrades_text.font = koreanFont; purchaseAllPrestigeLoungerUpgrades_text.fontSize = 24;
        purchaseAllPrestigePirateUpgrades_text.text = "모든 프레스티지 해적 업그레이드를 구매하세요"; purchaseAllPrestigePirateUpgrades_text.font = koreanFont; purchaseAllPrestigePirateUpgrades_text.fontSize = 24;
        purchaseAllPrestigeHoarderUpgrades_text.text = "모든 프레스티지 호더 업그레이드를 구매하세요"; purchaseAllPrestigeHoarderUpgrades_text.font = koreanFont; purchaseAllPrestigeHoarderUpgrades_text.fontSize = 24;
        purchaseAllPrestigeAdventurerUpgrades_text.text = "모든 프레스티지 모험가 업그레이드를 구매하세요"; purchaseAllPrestigeAdventurerUpgrades_text.font = koreanFont; purchaseAllPrestigeAdventurerUpgrades_text.fontSize = 24;

        //60 (Continued from 50)
        purchaseLootPotion_text.text = "루트 포션을 구매하세요"; purchaseLootPotion_text.font = koreanFont; purchaseLootPotion_text.fontSize = 24;
        purchaseGoldenTouch_text.text = "골든 터치를 구매하세요"; purchaseGoldenTouch_text.font = koreanFont; purchaseGoldenTouch_text.fontSize = 24;
        purchaseSerendipityScroll_text.text = "세렌디피티 두루마리를 구매하세요"; purchaseSerendipityScroll_text.font = koreanFont; purchaseSerendipityScroll_text.fontSize = 24;
        purchaseKey_text.text = "열쇠를 구매하세요"; purchaseKey_text.font = koreanFont; purchaseKey_text.fontSize = 24;
        purchaseMagicalElixir_text.text = "마법의 엘릭서를 구매하세요"; purchaseMagicalElixir_text.font = koreanFont; purchaseMagicalElixir_text.fontSize = 24;
        purchaseAncientRelic_text.text = "고대 유물을 구매하세요"; purchaseAncientRelic_text.font = koreanFont; purchaseAncientRelic_text.fontSize = 24;
        purchaseEnchantedHammer_text.text = "마법 망치를 구매하세요"; purchaseEnchantedHammer_text.font = koreanFont; purchaseEnchantedHammer_text.fontSize = 24;
        openChest_text.text = "상자 1개를 여세요"; openChest_text.font = koreanFont; openChest_text.fontSize = 24;
        open100Chests_text.text = "상자 100개를 여세요"; open100Chests_text.font = koreanFont; open100Chests_text.fontSize = 24;
        open1000Chests_text.text = "상자 1000개를 여세요"; open1000Chests_text.font = koreanFont; open1000Chests_text.fontSize = 24;

        //70 (Continued from 60)
        open10000Chests_text.text = "상자 10000개를 여세요"; open10000Chests_text.font = koreanFont; open10000Chests_text.fontSize = 24;
        open100000Chests_text.text = "상자 100 000개를 여세요"; open100000Chests_text.font = koreanFont; open100000Chests_text.fontSize = 24;
        open200000Chests_text.text = "상자 200 000개를 여세요"; open200000Chests_text.font = koreanFont; open200000Chests_text.fontSize = 24;
        purchaseChestNo2_text.text = "2호 상자를 구매하세요"; purchaseChestNo2_text.font = koreanFont; purchaseChestNo2_text.fontSize = 24;
        purchaseChestNo5_text.text = "5호 상자를 구매하세요"; purchaseChestNo5_text.font = koreanFont; purchaseChestNo5_text.fontSize = 24;
        purchaseChestNo8_text.text = "8호 상자를 구매하세요"; purchaseChestNo8_text.font = koreanFont; purchaseChestNo8_text.fontSize = 24;
        purchaseChestNo12_text.text = "12호 상자를 구매하세요"; purchaseChestNo12_text.font = koreanFont; purchaseChestNo12_text.fontSize = 24;
        purchaseChestNo15_text.text = "15호 상자를 구매하세요"; purchaseChestNo15_text.font = koreanFont; purchaseChestNo15_text.fontSize = 24;
        purchaseChestNo20_text.text = "20호 상자를 구매하세요"; purchaseChestNo20_text.font = koreanFont; purchaseChestNo20_text.fontSize = 24;
        purchaseChestNo24_text.text = "24호 상자를 구매하세요"; purchaseChestNo24_text.font = koreanFont; purchaseChestNo24_text.fontSize = 24;

        //80 (Continued from 70)
        purchaseChestNo32_text.text = "32호 상자를 구매하세요"; purchaseChestNo32_text.font = koreanFont; purchaseChestNo32_text.fontSize = 24;
        purchaseTheFinalChest_text.text = "마지막 상자를 구매하세요"; purchaseTheFinalChest_text.font = koreanFont; purchaseTheFinalChest_text.fontSize = 24;
        openTheFinalChest_text.text = "마지막 상자를 여세요"; openTheFinalChest_text.font = koreanFont; openTheFinalChest_text.fontSize = 24;
        openAReinforcedChest_text.text = "강화 상자 1개를 여세요"; openAReinforcedChest_text.font = koreanFont; openAReinforcedChest_text.fontSize = 24;
        open100ReinforcedChests_text.text = "강화 상자 100개를 여세요"; open100ReinforcedChests_text.font = koreanFont; open100ReinforcedChests_text.fontSize = 24;
        open500ReinforcedChests_text.text = "강화 상자 500개를 여세요"; open500ReinforcedChests_text.font = koreanFont; open500ReinforcedChests_text.fontSize = 24;
        open1000ReinforcedChests_text.text = "강화 상자 1000개를 여세요"; open1000ReinforcedChests_text.font = koreanFont; open1000ReinforcedChests_text.fontSize = 24;
        open100EnchantedGoldenChests_text.text = "마법에 걸린 황금 상자 100개를 여세요"; open100EnchantedGoldenChests_text.font = koreanFont; open100EnchantedGoldenChests_text.fontSize = 24;
        open100BossChests_text.text = "보스 상자 100개를 여세요"; open100BossChests_text.font = koreanFont; open100BossChests_text.fontSize = 24;
        receiveTotal50SkillPoints_text.text = "총 50개의 스킬 포인트를 얻으세요"; receiveTotal50SkillPoints_text.font = koreanFont; receiveTotal50SkillPoints_text.fontSize = 24;

        //90 (Continued from 80)
        receiveTotal500SkillPoints_text.text = "총 500개의 스킬 포인트를 얻으세요"; receiveTotal500SkillPoints_text.font = koreanFont; receiveTotal500SkillPoints_text.fontSize = 24;
        receiveTotal1000SkillPoints_text.text = "총 1000개의 스킬 포인트를 얻으세요"; receiveTotal1000SkillPoints_text.font = koreanFont; receiveTotal1000SkillPoints_text.fontSize = 24;
        receiveTotal10000SkillPoints_text.text = "총 10000개의 스킬 포인트를 얻으세요"; receiveTotal10000SkillPoints_text.font = koreanFont; receiveTotal10000SkillPoints_text.fontSize = 24;
        reachLevel10_text.text = "레벨 10을 달성하세요"; reachLevel10_text.font = koreanFont; reachLevel10_text.fontSize = 24;
        reachLevel25_text.text = "레벨 25를 달성하세요"; reachLevel25_text.font = koreanFont; reachLevel25_text.fontSize = 24;
        reachLevel50_text.text = "레벨 50을 달성하세요"; reachLevel50_text.font = koreanFont; reachLevel50_text.fontSize = 24;
        reachLevel100_text.text = "레벨 100을 달성하세요"; reachLevel100_text.font = koreanFont; reachLevel100_text.fontSize = 24;
        reachLevel200_text.text = "레벨 200을 달성하세요"; reachLevel200_text.font = koreanFont; reachLevel200_text.fontSize = 24;
        drop1000_25XGoldCoins_text.text = "1000, 25X 골드 코인을 드롭하세요"; drop1000_25XGoldCoins_text.font = koreanFont; drop1000_25XGoldCoins_text.fontSize = 24;
        drop2MillionGoldCoins_text.text = "200만 골드 코인을 드롭하세요"; drop2MillionGoldCoins_text.font = koreanFont; drop2MillionGoldCoins_text.fontSize = 24;

        //100 (Continued from 90)
        drop100XGoldCoin_text.text = "100X 골드 코인을 드롭하세요"; drop100XGoldCoin_text.font = koreanFont; drop100XGoldCoin_text.fontSize = 24;
        haveTotal1UndecillionGold_text.text = "총 1간개의 골드를 소유하세요"; haveTotal1UndecillionGold_text.font = koreanFont; haveTotal1UndecillionGold_text.fontSize = 24;
        haveTotal1DuodecillionGold_text.text = "총 1000간개의 골드를 소유하세요"; haveTotal1DuodecillionGold_text.font = koreanFont; haveTotal1DuodecillionGold_text.fontSize = 24;
        haveTotal1TredecillionGold_text.text = "총 100정개의 골드를 소유하세요"; haveTotal1TredecillionGold_text.font = koreanFont; haveTotal1TredecillionGold_text.fontSize = 24;
        haveTotal1QuattuordecillionGold_text.text = "총 10재개의 골드를 소유하세요"; haveTotal1QuattuordecillionGold_text.font = koreanFont; haveTotal1QuattuordecillionGold_text.fontSize = 24;
        haveTotal1QuindecillionGold_text.text = "총 1극개의 골드를 소유하세요"; haveTotal1QuindecillionGold_text.font = koreanFont; haveTotal1QuindecillionGold_text.fontSize = 24;
        haveTotal1SexdecillionGold_text.text = "총 1000극개의 골드를 소유하세요"; haveTotal1SexdecillionGold_text.font = koreanFont; haveTotal1SexdecillionGold_text.fontSize = 24;
        haveTotal1SeptendecillionGold_text.text = "총 100항하사개의 골드를 소유하세요"; haveTotal1SeptendecillionGold_text.font = koreanFont; haveTotal1SeptendecillionGold_text.fontSize = 24;
        haveTotal1OctodecillionGold_text.text = "총 10아승기개의 골드를 소유하세요"; haveTotal1OctodecillionGold_text.font = koreanFont; haveTotal1OctodecillionGold_text.fontSize = 24;
        reachLevel150_text.text = "레벨 150을 달성하세요"; reachLevel150_text.font = koreanFont; reachLevel150_text.fontSize = 24;

        //110 (Continued from 100)
        receiveTotal20000SkillPoints_text.text = "총 20000개의 스킬 포인트를 얻으세요"; receiveTotal20000SkillPoints_text.font = koreanFont; receiveTotal20000SkillPoints_text.fontSize = 24;
        chestsHaveDropped100KTreasures_text.text = "상자가 10만개의 보물을 드롭하였습니다"; chestsHaveDropped100KTreasures_text.font = koreanFont; chestsHaveDropped100KTreasures_text.fontSize = 24;
        hundredUltraTreasuresDropped_text.text = "상자로부터 울트라 보물 100개가 드롭되었습니다"; hundredUltraTreasuresDropped_text.font = koreanFont; hundredUltraTreasuresDropped_text.fontSize = 24;
        hundredMythicTreasuresDropped_text.text = "상자로부터 신화적 보물 100개가 드롭되었습니다"; hundredMythicTreasuresDropped_text.font = koreanFont; hundredMythicTreasuresDropped_text.fontSize = 24;
        hundredEternalTreasuresDropped_text.text = "상자로부터 이터널 보물 100개가 드롭되었습니다"; hundredEternalTreasuresDropped_text.font = koreanFont; hundredEternalTreasuresDropped_text.fontSize = 24;
        open2500ReinforcedChests_text.text = "강화 상자 2500개를 여세요"; open2500ReinforcedChests_text.font = koreanFont; open2500ReinforcedChests_text.fontSize = 24;
        purchaseChestNo37_text.text = "37호 상자를 구매하세요"; purchaseChestNo37_text.font = koreanFont; purchaseChestNo37_text.fontSize = 24;
        useTheChicken_text.text = "닭을 사용하세요"; useTheChicken_text.font = koreanFont; useTheChicken_text.fontSize = 24;
        drop250000_5XGoldCoins_text.text = "25만, 5X 골드 코인을 드롭하세요"; drop250000_5XGoldCoins_text.font = koreanFont; drop250000_5XGoldCoins_text.fontSize = 24;
        #endregion

        #region Cursors
        // Cursors - Cursors Hover Text

        // Cursors - Cursors Hover Text
        for (int i = 0; i < 21; i++)
        {
            levelUp_text[i].text = "업그레이드"; levelUp_text[i].font = koreanFont; levelUp_text[i].fontSize = 22;
        }

        // Cursors - Others
        cursor1PassiveDamage_Text.text = "+0% 패시브 데미지"; cursor1PassiveDamage_Text.font = koreanFont; cursor1PassiveDamage_Text.fontSize = 20;
        cursor1CritChance_Text.text = "+0% 크리티컬 가능성"; cursor1CritChance_Text.font = koreanFont; cursor1CritChance_Text.fontSize = 20;
        cursor1CritDamage_Text.text = "+0% 크리티컬 데미지"; cursor1CritDamage_Text.font = koreanFont; cursor1CritDamage_Text.fontSize = 20;

        // Cursors - Cursor 2
        cursor2ActiveDamage_Text.text = "+0% 액티브 데미지"; cursor2ActiveDamage_Text.font = koreanFont; cursor2ActiveDamage_Text.fontSize = 20;
   
        cursor2CritChance_Text.text = "+0% 크리티컬 가능성"; cursor2CritChance_Text.font = koreanFont; cursor2CritChance_Text.fontSize = 20;
        cursor2CritDamage_Text.text = "+0% 크리티컬 데미지"; cursor2CritDamage_Text.font = koreanFont; cursor2CritDamage_Text.fontSize = 20;

        // Cursors - Cursor 3
        cursor3ActiveDamage_Text.text = "+0% 액티브 데미지"; cursor3ActiveDamage_Text.font = koreanFont; cursor3ActiveDamage_Text.fontSize = 20;
        cursor3PassiveDamage_Text.text = "+0% 패시브 데미지"; cursor3PassiveDamage_Text.font = koreanFont; cursor3PassiveDamage_Text.fontSize = 20;

        // Cursors - Cursor 4
        cursor4CritChance_Text.text = "+0% 크리티컬 가능성"; cursor4CritChance_Text.font = koreanFont; cursor4CritChance_Text.fontSize = 20;
        cursor4CritDamage_Text.text = "+0% 크리티컬 데미지"; cursor4CritDamage_Text.font = koreanFont; cursor4CritDamage_Text.fontSize = 20;

        // Cursors - Cursor 5
        cursor5PassiveDamage_Text.text = "+0% 패시브 데미지"; cursor5PassiveDamage_Text.font = koreanFont; cursor5PassiveDamage_Text.fontSize = 20;

        // Cursors - Cursor 7
        cursor7PassiveDamage_Text.text = "+0% 패시브 데미지"; cursor7PassiveDamage_Text.font = koreanFont; cursor7PassiveDamage_Text.fontSize = 20;

        // Cursors - Cursor 9
        cursor9CritChance_Text.text = "+0% 크리티컬 가능성"; cursor9CritChance_Text.font = koreanFont; cursor9CritChance_Text.fontSize = 20;
        cursor9CritDamage_Text.text = "+0% 크리티컬 데미지"; cursor9CritDamage_Text.font = koreanFont; cursor9CritDamage_Text.fontSize = 20;

        // Cursors - Cursor 10
        cursor10ActiveDamage_Text.text = "+0% 액티브 데미지"; cursor10ActiveDamage_Text.font = koreanFont; cursor10ActiveDamage_Text.fontSize = 20;
        cursor10CritChance_Text.text = "+0% 크리티컬 가능성"; cursor10CritChance_Text.font = koreanFont; cursor10CritChance_Text.fontSize = 20;
        cursor10CritDamage_Text.text = "+0% 크리티컬 데미지"; cursor10CritDamage_Text.font = koreanFont; cursor10CritDamage_Text.fontSize = 20;

        // Cursors - Cursor 11
        cursor11PassiveDamage_Text.text = "+0% 패시브 데미지"; cursor11PassiveDamage_Text.font = koreanFont; cursor11PassiveDamage_Text.fontSize = 20;


        cursors_text.text = "커서"; cursors_text.font = koreanFont; cursors_text.fontSize = 55;
        cursorsHover_text.text = "커서"; cursorsHover_text.font = koreanFont; cursorsHover_text.fontSize = 40;
        onlyOneCursorEquipped_text.text = "-1개의 커서만 장착될 수 있습니다 "; onlyOneCursorEquipped_text.font = koreanFont; onlyOneCursorEquipped_text.fontSize = 21.5f;
        equipCursorFitsPlaystyle_text.text = "-플레이 스타일에 맞는 커서를 장착하세요"; equipCursorFitsPlaystyle_text.font = koreanFont; equipCursorFitsPlaystyle_text.fontSize = 21.5f;
        uniqueCursorBonus_text.text = "-각 커서들은 고유의 커서 보너스를 갖고 있습니다"; uniqueCursorBonus_text.font = koreanFont; uniqueCursorBonus_text.fontSize = 21.5f;
        levelUpCursors_text.text = "-보물을 사용함으로써 커서를 레벨업하세요"; levelUpCursors_text.font = koreanFont; levelUpCursors_text.fontSize = 21.5f;

        gentleTap_text.text = "젠틀 탭"; gentleTap_text.font = koreanFont; gentleTap_text.fontSize = 35f;
        gentleTap2_text.text = "젠틀 탭"; gentleTap2_text.font = koreanFont; gentleTap2_text.fontSize = 24f;
        gentleTapCursorBonus_text.text = "커서 보너스: 매 클릭마다 1 골드 코인을 스폰할 가능성 1%를 얻습니다"; gentleTapCursorBonus_text.font = koreanFont; gentleTapCursorBonus_text.fontSize = 21f;
        relaxedPalm_text.text = "안정된 손바닥"; relaxedPalm_text.font = koreanFont; relaxedPalm_text.fontSize = 35f;
        if (PlaceMobileButtons.isMobile == true) { relaxedPalm_text.fontSize = 32; }
        relaxedPalm2_text.text = "안정된 손바닥"; relaxedPalm2_text.font = koreanFont; relaxedPalm2_text.fontSize = 24f;
        relaxedPalmCursorBonus_text.text = "커서 보너스: 상자 10개를 오픈할마다 5 골드 코인을 스폰할 가능성 25%를 얻습니다"; relaxedPalmCursorBonus_text.font = koreanFont; relaxedPalmCursorBonus_text.fontSize = 21f;
        galeForce_text.text = "강풍 포스"; galeForce_text.font = koreanFont; galeForce_text.fontSize = 35f;
        galeForce2_text.text = "강풍 포스"; galeForce2_text.font = koreanFont; galeForce2_text.fontSize = 24f;
        galeForceCursorBonus_text.text = "커서 보너스: 크리티컬 히트를 가할 때마다 1골드 코인을 스폰할 가능성 25%를 얻습니다"; galeForceCursorBonus_text.font = koreanFont; galeForceCursorBonus_text.fontSize = 21f;
        radiantTouch_text.text = "레이디언트 터치"; radiantTouch_text.font = koreanFont; radiantTouch_text.fontSize = 35f;
        if (PlaceMobileButtons.isMobile == true) { radiantTouch_text.fontSize = 29; }
        radiantTouch2_text.text = "레이디언트 터치"; radiantTouch2_text.font = koreanFont; radiantTouch2_text.fontSize = 24f;
        radiantTouchCursorBonus_text.text = "커서 보너스: 상자 35개를 오픈할 때마다 7 골드 코인을 스폰합니다"; radiantTouchCursorBonus_text.font = koreanFont; radiantTouchCursorBonus_text.fontSize = 21f;
        energySurge_text.text = "에너지 파동"; energySurge_text.font = koreanFont; energySurge_text.fontSize = 35f;
        energySurge2_text.text = "에너지 파동"; energySurge2_text.font = koreanFont; energySurge2_text.fontSize = 24f;
        energySurgeCursorBonus_text.text = "커서 보너스: 모든 보물은 추가로 0.1%의 드롭 가능성을 얻습니다"; energySurgeCursorBonus_text.font = koreanFont; energySurgeCursorBonus_text.fontSize = 21f;
        phantomPalm_text.text = "팬텀 손바닥"; phantomPalm_text.font = koreanFont; phantomPalm_text.fontSize = 35f;
        phantomPalm2_text.text = "팬텀 손바닥"; phantomPalm2_text.font = koreanFont; phantomPalm2_text.fontSize = 24f;
        phantomPalmCursorBonus_text.text = "커서 보너스: 모든 크리티컬 히트는 보물을 스폰할 7 % 의 가능성을 얻습니다.각 보물들은 가치를 두배로 뛰게 할 3 % 의 가능성을 얻습니다"; phantomPalmCursorBonus_text.font = koreanFont; phantomPalmCursorBonus_text.fontSize = 21f;
        steelStrike_text.text = "강철 스트라이크"; steelStrike_text.font = koreanFont; steelStrike_text.fontSize = 35f;
        if (PlaceMobileButtons.isMobile == true) { steelStrike_text.fontSize = 28; }
        steelStrike2_text.text = "강철 스트라이크"; steelStrike2_text.font = koreanFont; steelStrike2_text.fontSize = 24f;
        steelStrikeCursorBonus_text.text = "커서 보너스: 골드를 5% 더 받습니다. XP도 5% 더 받습니다"; steelStrikeCursorBonus_text.font = koreanFont; steelStrikeCursorBonus_text.fontSize = 21f;
        lethalTouch_text.text = "치명적인 터치"; lethalTouch_text.font = koreanFont; lethalTouch_text.fontSize = 35f;
        lethalTouch2_text.text = "치명적인 터치"; lethalTouch2_text.font = koreanFont; lethalTouch2_text.fontSize = 24f;
        lethalTouchCursorBonus_text.text = "커서 보너스: 상자가 열릴 때마다 두배의 XP를 얻을 6%의 가능성을 얻습니다. "; lethalTouchCursorBonus_text.font = koreanFont; lethalTouchCursorBonus_text.fontSize = 21f;
        precisionPoint_text.text = "정밀한 포인트"; precisionPoint_text.font = koreanFont; precisionPoint_text.fontSize = 35f;
        precisionPoint2_text.text = "정밀한 포인트"; precisionPoint2_text.font = koreanFont; precisionPoint2_text.fontSize = 24f;
        precisionPointCursorBonus_text.text = "커서 보너스: 보물이 드롭될 때마다 가치가 두배로 뛸 확률이 7% 높아집니다 "; precisionPointCursorBonus_text.font = koreanFont; precisionPointCursorBonus_text.fontSize = 21f;
        vortexTap_text.text = "소용돌이 탭"; vortexTap_text.font = koreanFont; vortexTap_text.fontSize = 35f;
        vortexTap2_text.text = "소용돌이 탭"; vortexTap2_text.font = koreanFont; vortexTap2_text.fontSize = 24f;
        vortexTapCursorBonus_text.text = "커서 보너스: 25개의 상자가 오픈될 때마다 보물 1개를 스폰하고 XP 3배를 부여합니다"; vortexTapCursorBonus_text.font = koreanFont; vortexTapCursorBonus_text.fontSize = 21f;
        cursedClaw_text.text = "저주받은 발톱"; cursedClaw_text.font = koreanFont; cursedClaw_text.fontSize = 35f;
        cursedClaw2_text.text = "저주받은 발톱"; cursedClaw2_text.font = koreanFont; cursedClaw2_text.fontSize = 24f;
        cursedClawCursorBonus_text.text = "커서 보너스: 크리티컬 히트가 가해질 때마다 골드 코인을 스폰할 가능성 30%와 보물을 스폰할 3%의 가능성을 얻습니다"; cursedClawCursorBonus_text.font = koreanFont; cursedClawCursorBonus_text.fontSize = 21f;
        sniperClick_text.text = "스나이퍼 클릭"; sniperClick_text.font = koreanFont; sniperClick_text.fontSize = 35f;
        sniperClick2_text.text = "스나이퍼 클릭"; sniperClick2_text.font = koreanFont; sniperClick2_text.fontSize = 24f;
        sniperClickCursorBonus_text.text = "커서 보너스: 골드를 10%만큼, XP를 15%만큼 더 받습니다"; sniperClickCursorBonus_text.font = koreanFont; sniperClickCursorBonus_text.fontSize = 21f;
        shadowSurge_text.text = "그림자 파동"; shadowSurge_text.font = koreanFont; shadowSurge_text.fontSize = 35f;
        shadowSurge2_text.text = "그림자 파동"; shadowSurge2_text.font = koreanFont; shadowSurge2_text.fontSize = 24f;
        shadowSurgeCursorBonus_text.text = "커서 보너스: 모든 크리티컬 히트는 1골드 코인을 스폰합니다"; shadowSurgeCursorBonus_text.font = koreanFont; shadowSurgeCursorBonus_text.fontSize = 21f;
        cripplingCrush_text.text = "심각한 충돌"; cripplingCrush_text.font = koreanFont; cripplingCrush_text.fontSize = 35f;
        cripplingCrush2_text.text = "심각한 충돌"; cripplingCrush2_text.font = koreanFont; cripplingCrush2_text.fontSize = 24f;
        cripplingCrushCursorBonus_text.text = "커서 보너스: 보물을 얻을 때마다 가치가 두배로 뛸 확률 25%를 얻게 됩니다"; cripplingCrushCursorBonus_text.font = koreanFont; cripplingCrushCursorBonus_text.fontSize = 21f;
        rapidClick_text.text = "난타"; rapidClick_text.font = koreanFont; rapidClick_text.fontSize = 35f;
        rapidClick2_text.text = "난타"; rapidClick2_text.font = koreanFont; rapidClick2_text.fontSize = 24f;
        rapidClickCursorBonus_text.text = "커서 보너스: 모든 크리티컬 히트는 보물을 스폰할 가능성 13%를 얻습니다"; rapidClickCursorBonus_text.font = koreanFont; rapidClickCursorBonus_text.fontSize = 21f;
        celestialTouch_text.text = "거룩한 터치"; celestialTouch_text.font = koreanFont; celestialTouch_text.fontSize = 35f;
        celestialTouch2_text.text = "거룩한 터치"; celestialTouch2_text.font = koreanFont; celestialTouch2_text.fontSize = 24f;
        celestialTouchCursorBonus_text.text = "커서 보너스: XP가 두배로 뜁니다"; celestialTouchCursorBonus_text.font = koreanFont; celestialTouchCursorBonus_text.fontSize = 21f;
        arcaneClick_text.text = "신비한 클릭"; arcaneClick_text.font = koreanFont; arcaneClick_text.fontSize = 35f;
        arcaneClick2_text.text = "신비한 클릭"; arcaneClick2_text.font = koreanFont; arcaneClick2_text.fontSize = 24f;
        arcaneClickCursorBonus_text.text = "커서 보너스: 모든 보물의 가치가 두 배로 뜁니다"; arcaneClickCursorBonus_text.font = koreanFont; arcaneClickCursorBonus_text.fontSize = 21f;
        eternalTouch_text.text = "이터널 터치"; eternalTouch_text.font = koreanFont; eternalTouch_text.fontSize = 35f;
        eternalTouch2_text.text = "이터널 터치"; eternalTouch2_text.font = koreanFont; eternalTouch2_text.fontSize = 24f;
        eternalTouchCursorBonus_text.text = "커서 보너스: XP와 보물들이 두 배로 많아집니다. 매 클릭마다 골드 코인을 얻을 가능성 5%를 얻습니다"; eternalTouchCursorBonus_text.font = koreanFont; eternalTouchCursorBonus_text.fontSize = 21f;
        doomTouch_text.text = "파멸의 터치"; doomTouch_text.font = koreanFont; doomTouch_text.fontSize = 35f;
        doomTouch2_text.text = "파멸의 터치"; doomTouch2_text.font = koreanFont; doomTouch2_text.fontSize = 24f;
        doomTouchCursorBonus_text.text = "커서 보너스: 레어 보물 드롭과 관련된 가능성을 약간 얻습니다."; doomTouchCursorBonus_text.font = koreanFont; doomTouchCursorBonus_text.fontSize = 21f;
        solarSweep_text.text = "태양의 솔질"; solarSweep_text.font = koreanFont; solarSweep_text.fontSize = 35f;
        solarSweep2_text.text = "태양의 솔질"; solarSweep2_text.font = koreanFont; solarSweep2_text.fontSize = 24f;
        solarSweepCursorBonus_text.text = "커서 보너스: 상자 리워드를 두 배로 뛰게 할 가능성 2.5%를 얻습니다"; solarSweepCursorBonus_text.font = koreanFont; solarSweepCursorBonus_text.fontSize = 21f;
        infernoFist_text.text = "지옥 주먹"; infernoFist_text.font = koreanFont; infernoFist_text.fontSize = 35f;
        infernoFist2_text.text = "지옥 주먹"; infernoFist2_text.font = koreanFont; infernoFist2_text.fontSize = 24f;
        infernoFistCursorBonus_text.text = "커서 보너스: 보물 가치가 두 배로 뛸 때마다 XP가 두 배로 뜁니다. 골드를 두 배로 뛰게 할 가능성 4%를 얻습니다"; infernoFistCursorBonus_text.font = koreanFont; infernoFistCursorBonus_text.fontSize = 21f;
        locked_text.text = "잠김"; locked_text.font = koreanFont; locked_text.fontSize = 45f;
        unlockedAfterChest_text.text = "상자 구매 후에 잠금 해제됨"; unlockedAfterChest_text.font = koreanFont; unlockedAfterChest_text.fontSize = 37f;

        #endregion

        #region Shop And Items
        for (int i = 0; i < 17; i++)
        {
            itemsLevelUp_text[i].text = "업그레이드"; itemsLevelUp_text[i].font = koreanFont; itemsLevelUp_text[i].fontSize = 22;
        }

        goldenTouchBuff.text = "<color=yellow>+6-10 골드 코인 드롭"; goldenTouchBuff.font = koreanFont; goldenTouchBuff.fontSize = 10;
        treasurePotionBuff_text.text = "+3% 보물 드롭 확률"; treasurePotionBuff_text.font = koreanFont; treasurePotionBuff_text.fontSize = 10;


        shop_text.text = "상점"; shop_text.font = koreanFont; shop_text.fontSize = 90;
        shop2_text.text = "상점"; shop2_text.font = koreanFont; shop2_text.fontSize = 40;
        items_text.text = "아이템"; items_text.font = koreanFont; items_text.fontSize = 50;
        lockpick_text.text = "자물쇠 따개"; lockpick_text.font = koreanFont; lockpick_text.fontSize = 29;
        lockpick2_text.text = "자물쇠 따개"; lockpick2_text.font = koreanFont; lockpick2_text.fontSize = 25;
        lockpickItemBonus_text.text = "아이템 보너스: 상자가 자물쇠 따개로 열릴 때 보물이 드롭될 가능성이 약간 생깁니다"; lockpickItemBonus_text.font = koreanFont; lockpickItemBonus_text.fontSize = 21;

        hammer_text.text = "망치"; hammer_text.font = koreanFont; hammer_text.fontSize = 26;
        hammer2_text.text = "망치"; hammer2_text.font = koreanFont; hammer2_text.fontSize = 25;
        hammerItemBonus_text.text = "아이템 보너스: 해머 사용 시에 크리티컬 히트를 얻게 되면 1 골드 코인이 스폰된 확률 35%를 얻게 됩니다"; hammerItemBonus_text.font = koreanFont; hammerItemBonus_text.fontSize = 21;

        lootPotion_text.text = "루트 포션 "; lootPotion_text.font = koreanFont; lootPotion_text.fontSize = 25;
        lootPotion2_text.text = "루트 포션 "; lootPotion2_text.font = koreanFont; lootPotion2_text.fontSize = 25;
        lootPotionItemBonus_text.text = "아이템 보너스: 이 포션이 활성화되었을 때 얻게 된 보물들은 가치가 두 배로 뛸 가능성을 5% 더 얻게 됩니다. "; lootPotionItemBonus_text.font = koreanFont; lootPotionItemBonus_text.fontSize = 21;

        damagePotion_text.text = "데미지 포션"; damagePotion_text.font = koreanFont; damagePotion_text.fontSize = 25;
        damagePotion2_text.text = "데미지 포션"; damagePotion2_text.font = koreanFont; damagePotion2_text.fontSize = 25;
        damagePotionItemBonus_text.text = "아이템 보너스: 또한 활성화되었을 때 크리티컬 확률 2%와 크리티컬 데미지 50%를 추가로 부여합니다"; damagePotionItemBonus_text.font = koreanFont; damagePotionItemBonus_text.fontSize = 21;

        xpPotion_text.text = "XP 포션"; xpPotion_text.font = koreanFont; xpPotion_text.fontSize = 25;
        xpPotion2_text.text = "XP 포션"; xpPotion2_text.font = koreanFont; xpPotion2_text.fontSize = 25;
        xpPotionItemBonus_text.text = "아이템 보너스: XP가 얻어질 때마다 1 스킬 포인트를 얻을 가능성 0.1%를 얻게 됩니다"; xpPotionItemBonus_text.font = koreanFont; xpPotionItemBonus_text.fontSize = 21;

        goldenTouch_text.text = "골든 터치"; goldenTouch_text.font = koreanFont; goldenTouch_text.fontSize = 25;
        goldenTouch2_text.text = "골든 터치"; goldenTouch2_text.font = koreanFont; goldenTouch2_text.fontSize = 25;
        goldenTouchItemBonus_text.text = "아이템 보너스: 골든 터치가 활성화되었을 때, 보물들은 가치가 두 배로 뛸 확률 10%를 추가로 얻게 됩니다"; goldenTouchItemBonus_text.font = koreanFont; goldenTouchItemBonus_text.fontSize = 21;

        miniChest_text.text = "미니 상자"; miniChest_text.font = koreanFont; miniChest_text.fontSize = 25;
        miniChest2_text.text = "미니 상자"; miniChest2_text.font = koreanFont; miniChest2_text.fontSize = 29;
        miniChestUpgradeBonus_text.text = "업그레이드 보너스: 미니 상자는 3개의 가능한 리워드 중 1개를 부여할 것입니다"; miniChestUpgradeBonus_text.font = koreanFont; miniChestUpgradeBonus_text.fontSize = 21;
        miniChestMaxHover_text.text = "최대 레벨"; miniChestMaxHover_text.font = koreanFont; miniChestMaxHover_text.fontSize = 10;

        key_text.text = "열쇠"; key_text.font = koreanFont; key_text.fontSize = 26;
        key2_text.text = "열쇠"; key2_text.font = koreanFont; key2_text.fontSize = 25;
        keyInstantlOpens_text.text = "상자를 즉시 오픈합니다"; keyInstantlOpens_text.font = koreanFont; keyInstantlOpens_text.fontSize = 23;
        keyItemBonus_text.text = "아이템 보너스: 열쇠가 사용되었을 때 상자들은 2-4개의 추가적인 골드 코인들을 드롭합니다. "; keyItemBonus_text.font = koreanFont; keyItemBonus_text.fontSize = 21;

        treasureBag_text.text = "보물 가방"; treasureBag_text.font = koreanFont; treasureBag_text.fontSize = 25;
        treasureBag2_text.text = "보물 가방"; treasureBag2_text.font = koreanFont; treasureBag2_text.fontSize = 25;
        treasureBagDrop_text.text = "보물 가방들은 2개의 보물을 드롭할 것입니다"; treasureBagDrop_text.font = koreanFont; treasureBagDrop_text.fontSize = 17;
        treasureBagItemBonus_text.text = "아이템 보너스: 아무 상자로부터 나온 보물들이 드롭할 수 있습니다. 보물 가방들은 또한 5 XP 드롭을 부여합니다"; treasureBagItemBonus_text.font = koreanFont; treasureBagItemBonus_text.fontSize = 21;

        serendipityScroll_text.text = "세런디피티 두루마리"; serendipityScroll_text.font = koreanFont; serendipityScroll_text.fontSize = 25;
        if(PlaceMobileButtons.isMobile == true) { serendipityScroll_text.fontSize = 16; }
        serendipityScroll2_text.text = "세런디피티 두루마리"; serendipityScroll2_text.font = koreanFont; serendipityScroll2_text.fontSize = 20;
        serendipityScrollStatsReset_text.text = "세런디피티 두루마리에 영향 받은 스탯은 프레스티지에서 초기화될 것입니다"; serendipityScrollStatsReset_text.font = koreanFont; serendipityScrollStatsReset_text.fontSize = 21;

        gauntletOfGreed_text.text = "욕망의 긴 장갑"; gauntletOfGreed_text.font = koreanFont; gauntletOfGreed_text.fontSize = 25;
        if (PlaceMobileButtons.isMobile == true) { gauntletOfGreed_text.fontSize = 22; }
        gauntletOfGreed2_text.text = "욕망의 긴 장갑"; gauntletOfGreed2_text.font = koreanFont; gauntletOfGreed2_text.fontSize = 20;
        gauntletOfGreenBonus_text.text = "아이템 보너스: 모든 클릭으로부터 보물을 스폰할 가능성 3%"; gauntletOfGreenBonus_text.font = koreanFont; gauntletOfGreenBonus_text.fontSize = 21;

        magicalElixir_text.text = "마법의 엘릭서"; magicalElixir_text.font = koreanFont; magicalElixir_text.fontSize = 25;
        magicalElixir2_text.text = "마법의 엘릭서"; magicalElixir2_text.font = koreanFont; magicalElixir2_text.fontSize = 24;
        magicalElixirItemBonus_text.text = "아이템 보너스: 엘릭서가 활성화되었을 때 모든 보물들에 대한 드롭 확률 0.3%가 추가로 얻어집니다"; magicalElixirItemBonus_text.font = koreanFont; magicalElixirItemBonus_text.fontSize = 21;

        ancientRelic_text.text = "고대 유물"; ancientRelic_text.font = koreanFont; ancientRelic_text.fontSize = 25;
        ancientRelic2_text.text = "고대 유물"; ancientRelic2_text.font = koreanFont; ancientRelic2_text.fontSize = 22;
        ancientRelicGivesBuff_text.text = "랜덤한 스탯에 영구적인 버프를 부여합니다"; ancientRelicGivesBuff_text.font = koreanFont; ancientRelicGivesBuff_text.fontSize = 22;
        ancientRelicKeepBuff_text.text = "프레스티지 이후에도 고대 유물로 얻어진 모든 버프를 유지할 것입니다"; ancientRelicKeepBuff_text.font = koreanFont; ancientRelicKeepBuff_text.fontSize = 21;

        enchantedHammer_text.text = "마법의 망치"; enchantedHammer_text.font = koreanFont; enchantedHammer_text.fontSize = 23;
        enchantedHammer2_text.text = "마법의 망치"; enchantedHammer2_text.font = koreanFont; enchantedHammer2_text.fontSize = 20;
        enchantedHammerItemBonus_text.text = "아이템 보너스: 상자 리워드를 3배로 뛰게 할 확률 2% "; enchantedHammerItemBonus_text.font = koreanFont; enchantedHammerItemBonus_text.fontSize = 21;

        treasurePotion_text.text = "보물 포션"; treasurePotion_text.font = koreanFont; treasurePotion_text.fontSize = 26;
        treasurePotion2_text.text = "보물 포션"; treasurePotion2_text.font = koreanFont; treasurePotion2_text.fontSize = 20;
        treasurePotionItemBonus_text.text = "아이템 보너스: 드롭된 아이템은 가치가 두 배로 뛸 확률 25%를 추가로 얻습니다"; treasurePotionItemBonus_text.font = koreanFont; treasurePotionItemBonus_text.fontSize = 21;

        barrelOfGold_text.text = "골드 배럴"; barrelOfGold_text.font = koreanFont; barrelOfGold_text.fontSize = 26;
        barrelOfGold2_text.text = "골드 배럴"; barrelOfGold2_text.font = koreanFont; barrelOfGold2_text.fontSize = 20;
        barrelOfGoldBonus_text.text = "아이템 보너스: 드래그함으로써 배럴을 어디에 놓을지 선택하세요"; barrelOfGoldBonus_text.font = koreanFont; barrelOfGoldBonus_text.fontSize = 21;
        barrelSpawns_text.text = "배럴을 스폰합니다."; barrelSpawns_text.font = koreanFont; barrelSpawns_text.fontSize = 24;
        barrelGoldCoinsInside_text.text = "모은:"; barrelGoldCoinsInside_text.font = koreanFont; barrelGoldCoinsInside_text.fontSize = 10;
        clickToCollect_text.text = "수집하기 위해서 클릭하세요!"; clickToCollect_text.font = koreanFont; clickToCollect_text.fontSize = 12;

        mimicChest_text.text = "모방 상자"; mimicChest_text.font = koreanFont; mimicChest_text.fontSize = 26;
        mimicChest2_text.text = "모방 상자"; mimicChest2_text.font = koreanFont; mimicChest2_text.fontSize = 20;
        mimicChestItemBonus_text.text = "아이템 보너스: 긍정 버프는 두 배로 길게 지속될 확률 15%를 얻습니다 "; mimicChestItemBonus_text.font = koreanFont; mimicChestItemBonus_text.fontSize = 21;
        turnedOff_text.text = "꺼짐"; turnedOff_text.font = koreanFont; turnedOff_text.fontSize = 18;

        purchaseAnItem_text.text = " -골드를 지불함으로써 아이템을 구매하세요."; purchaseAnItem_text.font = koreanFont; purchaseAnItem_text.fontSize = 21.5f;
        useItems_text.text = " -좌측 \"아이템\" 탭에 있는 아이템을 사용하세요."; useItems_text.font = koreanFont; useItems_text.fontSize = 21.5f;
        itemsGetExpensive_text.text = " -각 아이템들은 1개를 구매할 때마다 더 비싸집니다."; itemsGetExpensive_text.font = koreanFont; itemsGetExpensive_text.fontSize = 21.5f;
        levelUpItems_text.text = " -보물을 지불함으로써 아이템을 레벨업 시키세요."; levelUpItems_text.font = koreanFont; levelUpItems_text.fontSize = 21.5f;
        broke_text.text = "부서짐!"; broke_text.font = koreanFont; broke_text.fontSize = 36f;

        rareTreasureBuff_text.text = "<color=orange>+레어 보물을 드롭할 정말 작은 확률"; rareTreasureBuff_text.font = koreanFont; rareTreasureBuff_text.fontSize = 9;

        #endregion

        #region Treasures
        treasureBar_text.text = "보물"; treasureBar_text.font = koreanFont; treasureBar_text.fontSize = 48;

        for (int i = 0; i < 5; i++)
        {
            commonText_text[i].text = "커먼"; commonText_text[i].font = koreanFont; commonText_text[i].fontSize = 14;
            rareText_text[i].text = "레어"; rareText_text[i].font = koreanFont; rareText_text[i].fontSize = 15;
            veryRare_text[i].text = "매우 레어한"; veryRare_text[i].font = koreanFont; veryRare_text[i].fontSize = 14;
        }

        for (int i = 0; i < 4; i++)
        {
            unCommonText_text[i].text = "언커먼"; unCommonText_text[i].font = koreanFont; unCommonText_text[i].fontSize = 14;
        }

        for (int i = 0; i < 3; i++)
        {
            extremelyRare_text[i].text = "극적으로 레어한"; extremelyRare_text[i].font = koreanFont; extremelyRare_text[i].fontSize = 10;
            legendary_text[i].text = "레전드 "; legendary_text[i].font = koreanFont; legendary_text[i].fontSize = 12;
            ultra_text[i].text = "울트라"; ultra_text[i].font = koreanFont; ultra_text[i].fontSize = 14;
            mythic_text[i].text = "신화적"; mythic_text[i].font = koreanFont; mythic_text[i].fontSize = 13;
            eternal_text[i].text = "이터널"; eternal_text[i].font = koreanFont; eternal_text[i].fontSize = 13;
        }


        quartz_text.text = "수정"; quartz_text.font = koreanFont; quartz_text.fontSize = 28;
        amethyst_text.text = "자수정"; amethyst_text.font = koreanFont; amethyst_text.fontSize = 28;
        yellowTopaz_text.text = "황옥"; yellowTopaz_text.font = koreanFont; yellowTopaz_text.fontSize = 26;
        albite_text.text = "조장석"; albite_text.font = koreanFont; albite_text.fontSize = 27;
        redGarnet_text.text = "빨간 가넷"; redGarnet_text.font = koreanFont; redGarnet_text.fontSize = 27;
        aquamarine_text.text = "아쿠아마린"; aquamarine_text.font = koreanFont; aquamarine_text.fontSize = 27;
        yellowSapphire_text.text = "옐로우 사파이어"; yellowSapphire_text.font = koreanFont; yellowSapphire_text.fontSize = 23;
        pinkTourmaline_text.text = "핑크 투어멀린"; pinkTourmaline_text.font = koreanFont; pinkTourmaline_text.fontSize = 22;
        aventurine_text.text = "어벤츄린"; aventurine_text.font = koreanFont; aventurine_text.fontSize = 22;
        redRuby_text.text = "빨간 루비"; redRuby_text.font = koreanFont; redRuby_text.fontSize = 26;
        diamond_text.text = "다이아몬드"; diamond_text.font = koreanFont; diamond_text.fontSize = 27;
        grandidierite_text.text = "그란디디어라이트"; grandidierite_text.font = koreanFont; grandidierite_text.fontSize = 25;
        violetCrystal_text.text = "크리스탈 바이올렛"; violetCrystal_text.font = koreanFont; violetCrystal_text.fontSize = 25;
        akoyaPearl_text.text = "아코야 진주"; akoyaPearl_text.font = koreanFont; akoyaPearl_text.fontSize = 25;
        purpleRupee_text.text = "보라색 루피"; purpleRupee_text.font = koreanFont; purpleRupee_text.fontSize = 26;
        emerald_text.text = "에메랄드"; emerald_text.font = koreanFont; emerald_text.fontSize = 28;
        greenDiamond_text.text = "그린 다이아몬드"; greenDiamond_text.font = koreanFont; greenDiamond_text.fontSize = 24;
        fireOpal_text.text = "파이어 오팔"; fireOpal_text.font = koreanFont; fireOpal_text.fontSize = 26;
        gemSilica_text.text = "젬 실리카"; gemSilica_text.font = koreanFont; gemSilica_text.fontSize = 26;
        pinkPlort_text.text = "핑크 플로트"; pinkPlort_text.font = koreanFont; pinkPlort_text.fontSize = 26;
        goldenSeaPearl_text.text = "골든 바다 진주"; goldenSeaPearl_text.font = koreanFont; goldenSeaPearl_text.fontSize = 21;
        kyanite_text.text = "카이언나이트"; kyanite_text.font = koreanFont; kyanite_text.fontSize = 27;
        blackOpal_text.text = "블랙오팔"; blackOpal_text.font = koreanFont; blackOpal_text.fontSize = 27;
        painite_text.text = "페이나이트"; painite_text.font = koreanFont; painite_text.fontSize = 28;
        tanzanite_text.text = "탄자나이트"; tanzanite_text.font = koreanFont; tanzanite_text.fontSize = 27;
        astralium_text.text = "아스트랄륨"; astralium_text.font = koreanFont; astralium_text.fontSize = 27;
        elysiumPrism_text.text = "엘리시움 프리즘"; elysiumPrism_text.font = koreanFont; elysiumPrism_text.fontSize = 26;
        aerthfireOpal_text.text = "얼스파이어 오팔"; aerthfireOpal_text.font = koreanFont; aerthfireOpal_text.fontSize = 23;
        eldrichStarstone_text.text = "엘드리히 스타스톤"; eldrichStarstone_text.font = koreanFont; eldrichStarstone_text.fontSize = 19;
        chronolithShard_text.text = "크로놀리트 샤드"; chronolithShard_text.font = koreanFont; chronolithShard_text.fontSize = 20;
        sideriumEssence_text.text = "시더리움 에센스"; sideriumEssence_text.font = koreanFont; sideriumEssence_text.fontSize = 20;
        quadarite_text.text = "쿼더라이트"; quadarite_text.font = koreanFont; quadarite_text.fontSize = 22;
        radiantNovaStone_text.text = "레이디언트 노바 스톤"; radiantNovaStone_text.font = koreanFont; radiantNovaStone_text.fontSize = 19;
        soluniumShard_text.text = "솔루늄 샤드"; soluniumShard_text.font = koreanFont; soluniumShard_text.fontSize = 21;

        sell_text.text = "팔기"; sell_text.font = koreanFont; sell_text.fontSize = 25;
        sellAll_text.text = "모두 팔기"; sellAll_text.font = koreanFont; sellAll_text.fontSize = 24;
        #endregion

        #region Rare Treasures
        coolStuff_text.text = "멋진 것들"; coolStuff_text.font = koreanFont; coolStuff_text.fontSize = 25;
        rareTreasuresTop2_text.text = "레어 보물"; rareTreasuresTop2_text.font = koreanFont; rareTreasuresTop2_text.fontSize = 23;
        page1_text.text = "페이지 1"; page1_text.font = koreanFont; page1_text.fontSize = 12;
        page2_text.text = "페이지 2"; page2_text.font = koreanFont; page2_text.fontSize = 12;
        pirateSkull2_text.text = "해적 해골"; pirateSkull2_text.font = koreanFont; pirateSkull2_text.fontSize = 20;
        demonicSword2_text.text = "악귀의 검"; demonicSword2_text.font = koreanFont; demonicSword2_text.fontSize = 17;
        mysticRing2_text.text = "신비로운 반지"; mysticRing2_text.font = koreanFont; mysticRing2_text.fontSize = 17;
        trophy2_text.text = "트로피"; trophy2_text.font = koreanFont; trophy2_text.fontSize = 20;
        fallenStar2_text.text = "떨어진 별"; fallenStar2_text.font = koreanFont; fallenStar2_text.fontSize = 20;
        clover2_text.text = "클로버"; clover2_text.font = koreanFont; clover2_text.fontSize = 20;
        kingsCrown2_text.text = "왕관"; kingsCrown2_text.font = koreanFont; kingsCrown2_text.fontSize = 19;
        spellBook2_text.text = "주문서적"; spellBook2_text.font = koreanFont; spellBook2_text.fontSize = 19;
        guitar2_text.text = "기타"; guitar2_text.font = koreanFont; guitar2_text.fontSize = 19;
        talarian2_text.text = "탈라리안"; talarian2_text.font = koreanFont; talarian2_text.fontSize = 19;
        mythrune2_text.text = "미스룬"; mythrune2_text.font = koreanFont; mythrune2_text.fontSize = 19;
        explorerBackpack2_text.text = "모험가 가방"; explorerBackpack2_text.font = koreanFont; explorerBackpack2_text.fontSize = 14;
        vikingShield2_text.text = "바이킹 방패"; vikingShield2_text.font = koreanFont; vikingShield2_text.fontSize = 17;
        pillBottle2_text.text = "알약 물병"; pillBottle2_text.font = koreanFont; pillBottle2_text.fontSize = 17;
        victoryMedal2_text.text = "승리 메달"; victoryMedal2_text.font = koreanFont; victoryMedal2_text.fontSize = 17;
        cookie2_text.text = "쿠키"; cookie2_text.font = koreanFont; cookie2_text.fontSize = 17;
        christmasPresent2_text.text = "크리스마스 선물"; christmasPresent2_text.font = koreanFont; christmasPresent2_text.fontSize = 15;
        battleAxe2_text.text = "전투 도끼"; battleAxe2_text.font = koreanFont; battleAxe2_text.fontSize = 19;
        goldCoin100X2_text.text = "100X 골드 코인"; goldCoin100X2_text.font = koreanFont; goldCoin100X2_text.fontSize = 16;
        sealedEnvelope2_text.text = "봉인된 봉투"; sealedEnvelope2_text.font = koreanFont; sealedEnvelope2_text.fontSize = 16;
        strangePotion2_text.text = "이상한 포션"; strangePotion2_text.font = koreanFont; strangePotion2_text.fontSize = 15;
        soulGem2_text.text = "영혼 보석"; soulGem2_text.font = koreanFont; soulGem2_text.fontSize = 17;
        ancientScroll2_text.text = "고대 두루마리"; ancientScroll2_text.font = koreanFont; ancientScroll2_text.fontSize = 17;
        brick2_text.text = "벽돌"; brick2_text.font = koreanFont; brick2_text.fontSize = 17;
        rubberChicken2_text.text = "고무 닭"; rubberChicken2_text.font = koreanFont; rubberChicken2_text.fontSize = 17;

        skullFoundReward_text.text = "해적 해골을 찾은 것에 대한 보상:"; skullFoundReward_text.font = koreanFont; skullFoundReward_text.fontSize = 6.8f;
        swordFoundReward_text.text = "악귀의 검을 찾은 것에 대한 보상:"; swordFoundReward_text.font = koreanFont; swordFoundReward_text.fontSize = 6.8f;
        ringFoundReward_text.text = "신비로운 반지를 찾은 것에 대한 보상:"; ringFoundReward_text.font = koreanFont; ringFoundReward_text.fontSize = 6.8f;
        trophyFoundReward_text.text = "트로피를 찾은 것에 대한 보상:"; trophyFoundReward_text.font = koreanFont; trophyFoundReward_text.fontSize = 6.8f;
        fallenStarFoundReward_text.text = "떨어진 별을 찾은 것에 대한 보상:"; fallenStarFoundReward_text.font = koreanFont; fallenStarFoundReward_text.fontSize = 6.8f;
        cloverFoundReward_text.text = "클로버를 찾은 것에 대한 보상:"; cloverFoundReward_text.font = koreanFont; cloverFoundReward_text.fontSize = 6.7f;
        kingsCrownFoundReward_text.text = "왕관을 찾은 것에 대한 보상:"; kingsCrownFoundReward_text.font = koreanFont; kingsCrownFoundReward_text.fontSize = 6.7f;
        spellBookFoundReward_text.text = "주문서적을 찾은 것에 대한 보상:"; spellBookFoundReward_text.font = koreanFont; spellBookFoundReward_text.fontSize = 6.7f;
        guitarFoundReward_text.text = "기타를 찾은 것에 대한 보상:"; guitarFoundReward_text.font = koreanFont; guitarFoundReward_text.fontSize = 6.7f;
        talarianFoundReward_text.text = "탈라리아를 찾은 것에 대한 보상:"; talarianFoundReward_text.font = koreanFont; talarianFoundReward_text.fontSize = 6.7f;
        mythruneFoundReward_text.text = "미스룬을 찾은 것에 대한 보상:"; mythruneFoundReward_text.font = koreanFont; mythruneFoundReward_text.fontSize = 6.7f;
        backPackFoundReward_text.text = "모험가 가방을 찾은 것에 대한 보상:"; backPackFoundReward_text.font = koreanFont; backPackFoundReward_text.fontSize = 6.5f;
        shieldFoundReward_text.text = "바이킹을 찾은 것에 대한 보상:"; shieldFoundReward_text.font = koreanFont; shieldFoundReward_text.fontSize = 6.5f;
        pillBottleFoundReward_text.text = "알약 물병을 찾은 것에 대한 보상:"; pillBottleFoundReward_text.font = koreanFont; pillBottleFoundReward_text.fontSize = 6.5f;
        medalFoundReward_text.text = "승리 메달을 찾은 것에 대한 보상:"; medalFoundReward_text.font = koreanFont; medalFoundReward_text.fontSize = 6.5f;
        cookieFoundReward_text.text = "쿠키를 찾은 것에 대한 보상:"; cookieFoundReward_text.font = koreanFont; cookieFoundReward_text.fontSize = 6.5f;
        presentFoundReward_text.text = "크리스마스 선물을 찾은 것에 대한 보상:"; presentFoundReward_text.font = koreanFont; presentFoundReward_text.fontSize = 6.8f;
        axeFoundReward_text.text = "전투 도끼를 찾은 것에 대한 보상:"; axeFoundReward_text.font = koreanFont; axeFoundReward_text.fontSize = 6.8f;
        envelopeFoundReward_text.text = "봉인된 봉투를 찾은 것에 대한 보상:"; envelopeFoundReward_text.font = koreanFont; envelopeFoundReward_text.fontSize = 6.8f;
        coin100XFoundReward_text.text = "100X 골드 코인을 찾은 것에 대한 보상:"; coin100XFoundReward_text.font = koreanFont; coin100XFoundReward_text.fontSize = 6.8f;
        potionFoundReward_text.text = "포션을 찾은 것에 대한 보상:"; potionFoundReward_text.font = koreanFont; potionFoundReward_text.fontSize = 6.8f;
        soulGemFoundReward_text.text = "영혼 보석을 찾은 것에 대한 보상:"; soulGemFoundReward_text.font = koreanFont; soulGemFoundReward_text.fontSize = 6.8f;
        sscrollFoundReward_text.text = "고대 두루마리를 찾은 것에 대한 보상:"; sscrollFoundReward_text.font = koreanFont; sscrollFoundReward_text.fontSize = 6.8f;
        brickFoundReward_text.text = "벽돌을 찾은 것에 대한 보상:"; brickFoundReward_text.font = koreanFont; brickFoundReward_text.fontSize = 6.8f;
        chickenFoundReward_text.text = "고무 닭을 찾은 것에 대한 보상:"; chickenFoundReward_text.font = koreanFont; chickenFoundReward_text.fontSize = 6.8f;

        allSkullRewards_text.text = "<color=green>+3% 패시브 데미지"; allSkullRewards_text.font = koreanFont; allSkullRewards_text.fontSize = 11f;
        allDemonicSwordRewards_text.text = "+5% 액티브 데미지. +0.3%크리티컬 가능성"; allDemonicSwordRewards_text.font = koreanFont; allDemonicSwordRewards_text.fontSize = 9f;
        allMysticRingRewards_text.text = "+0.05% 보물 드롭 확률"; allMysticRingRewards_text.font = koreanFont; allMysticRingRewards_text.fontSize = 9f;
        allTrophyRewards_text.text = "+0.05% 보물 드롭 확률"; allTrophyRewards_text.font = koreanFont; allTrophyRewards_text.fontSize = 9f;
        allFallenStarRewards_text.text = "보물 가치가 두 배로 뛸 +4%의 확률"; allFallenStarRewards_text.font = koreanFont; allFallenStarRewards_text.fontSize = 7.5f;
        allCloverRewards_text.text = "5X 골드 코인에 대한 +2%. 10X 골드 코인에 대한 +1%의 확률"; allCloverRewards_text.font = koreanFont; allCloverRewards_text.fontSize = 7f;
        allKingsCrownRewards_text.text = "커서를 레벨업시키는 것은 커서를 더 강하게 합니다"; allKingsCrownRewards_text.font = koreanFont; allKingsCrownRewards_text.fontSize = 7.5f;
        allSpellBookRewards_text.text = "특별 업그레이드를 레벨업시키는 것은 커서를 더 강하게 합니다"; allSpellBookRewards_text.font = koreanFont; allSpellBookRewards_text.fontSize = 7f;
        allGuitarRewards_text.text = "액티브 및 패시브 데미지 +20%"; allGuitarRewards_text.font = koreanFont; allGuitarRewards_text.fontSize = 7.5f;
        allTalarianRewards_text.text = "+30% 패시브 데미지"; allTalarianRewards_text.font = koreanFont; allTalarianRewards_text.fontSize = 7.5f;
        allMythruneRewards_text.text = "+15% 골드"; allMythruneRewards_text.font = koreanFont; allMythruneRewards_text.fontSize = 7.5f;
        allExplorerBackpackRewards_text.text = "+15% XP. +15% 골드. +0.1% 보물 드롭 확률"; allExplorerBackpackRewards_text.font = koreanFont; allExplorerBackpackRewards_text.fontSize = 7.1f;
        allVikingShieldRewards_text.text = "보물 가치가 두 배로 뛸 +4%의 확률"; allVikingShieldRewards_text.font = koreanFont; allVikingShieldRewards_text.fontSize = 7.1f;
        allPillBottleRewards_text.text = "포션 스택 1회 추가"; allPillBottleRewards_text.font = koreanFont; allPillBottleRewards_text.fontSize = 7.1f;
        allVictoryMedalRewards_text.text = "매 클릭마다 골드 코인을 스폰할 1%의 가능성 & 보물을 스폰할 0.2%의 추가적인 확률"; allVictoryMedalRewards_text.font = koreanFont; allVictoryMedalRewards_text.fontSize = 5f;
        foundCookieRewards_text.text = "+50%골드. +50 XP. +0.2% 보물 드롭 확률. 보물 가치가 두 배로 뛸 +5%의 확률. 액티브 및 패시브 데미지 75%. +3% 크리티컬 가능성. +150% 크리티컬 데미지"; foundCookieRewards_text.font = koreanFont; foundCookieRewards_text.fontSize = 6.6f;
        foundChristmasPresentRewards_text.text = "<color=green>고대 유물은 더 강한 버프를 부여합니다"; foundChristmasPresentRewards_text.font = koreanFont; foundChristmasPresentRewards_text.fontSize = 9f;
        foundBattleAxeRewards_text.text = "<color=green>모든 클릭은 상자를 즉시 오픈할 수 있는 0.1%의 추가 확률을 갖고 있습니다. 상자를 즉각적으로 오픈하는 것은 상자 리워드를 두 배로 얻게 할 것입니다."; foundBattleAxeRewards_text.font = koreanFont; foundBattleAxeRewards_text.fontSize = 5f;
        foundEnvelopeRewards.text = "<color=green>+0.2% 강화 상자 확률"; foundEnvelopeRewards.font = koreanFont; foundEnvelopeRewards.fontSize = 8f;
        foundGoldCoin100XRewards_text.text = "<color=green>100X 골드 코인을 드롭할 0.05%의 확률"; foundGoldCoin100XRewards_text.font = koreanFont; foundGoldCoin100XRewards_text.fontSize = 8f;
        foundPotionRewards_text.text = "<color=green>모든 포션들은 업그레이드 됐을 때 훨씬 강해집니다"; foundPotionRewards_text.font = koreanFont; foundPotionRewards_text.fontSize = 7f;
        foundSoulGemRewards_text.text = "<color=green>영혼 보석들은 지속적으로 드롭될 것입니다. 랜덤한 스탯에 버프를 주기 위해 열혼 보석을 클릭하세요. 영혼 보석 드롭 확률 0.2%"; foundSoulGemRewards_text.font = koreanFont; foundSoulGemRewards_text.fontSize = 6.25f;
        foundAncientScrollRewards_text.text = "<color=green>세런디피티 두루마리는 더 강한 버프를 부여합니다"; foundAncientScrollRewards_text.font = koreanFont; foundAncientScrollRewards_text.fontSize = 8f;
        foundBrickRewards_text.text = "<color=green>뭐, 그냥 벽돌이니.. 뭐…"; foundBrickRewards_text.font = koreanFont; foundBrickRewards_text.fontSize = 8f;
        foundRubberChickenRewards_text.text = "<color=green>선택하시는 스탯에 엄청난 버프를 부여합니다."; foundRubberChickenRewards_text.font = koreanFont; foundRubberChickenRewards_text.fontSize = 7f;


        pirateSkullDescription_text.text = "\"폭풍이 몰아치는 바다와 알려지지 않은 전투들을 통해서, 해골은 무자비한 해적의 유산을 지니고 있죠\""; pirateSkullDescription_text.font = koreanFont; pirateSkullDescription_text.fontSize = 7f;

        demonicSwordDescription_text.text = "\"본래 신성하지 않은 무기로서, 이 악귀의 검은 저주 그 자체의 정수를 구현하고 있죠\""; demonicSwordDescription_text.font = koreanFont; demonicSwordDescription_text.fontSize = 7f;

        mysticRingDescription_text.text = "\"신비로운 반지는 운을 향상시킴으로써 보물 드롭을 자주 일어나게 하죠\""; mysticRingDescription_text.font = koreanFont; mysticRingDescription_text.fontSize = 7f;

        trophyDescription_text.text = "\"여운이 남네요. 위대함의 증표인 트로피를 왜 상자 안에 보관하죠?\""; trophyDescription_text.font = koreanFont; trophyDescription_text.fontSize = 7f;

        fallenStarDescription_text.text = "\"이 상자들은 레어 보물을 가지고 있지. 떨어진 별은 경이로움에 대한 우주의 유물이지\""; fallenStarDescription_text.font = koreanFont; fallenStarDescription_text.fontSize = 7f;

        cloverDescription_text.text = "\"운을 가져오는 마력인, 상자에 자리잡은 네잎 클로버 알아보세요\""; cloverDescription_text.font = koreanFont; cloverDescription_text.fontSize = 7f;

        kingsCrownDescription_text.text = "\"왕국의 유산에 대한 무게를 지고 있는 왕관인 장엄한 유산을 밝히세요.\""; kingsCrownDescription_text.font = koreanFont; kingsCrownDescription_text.fontSize = 7.6f;

        spellBookDescription_text.text = "\"주문서적의 숨겨진 지식을 밝혀내세요. 이는 마법의 기술을 전수해줄 것입니다\""; spellBookDescription_text.font = koreanFont; spellBookDescription_text.fontSize = 7.6f;

        guitarDescription_text.text = "\"이 기타는 왜 상자 안에 숨겨져 있었을까요? 이 기타의 줄은 매우 개인적인 연의 메아리를 가지고 있습니다\""; guitarDescription_text.font = koreanFont; guitarDescription_text.fontSize = 6.9f;

        talarianDescription_text.text = "\"보물 상자 안에는 전설적인 탈라리아가 놓여 있습니다. 이는 신속함과 자유로움의 상징이죠\""; talarianDescription_text.font = koreanFont; talarianDescription_text.fontSize = 6.9f;

        strangeRuneDescription_text.text = "\"미스룬의 정수를 밝혀내시고 고대 마법의 메아리에 감동을 받으세요\""; strangeRuneDescription_text.font = koreanFont; strangeRuneDescription_text.fontSize = 6.7f;

        explorerBackpackDescription_text.text = "\"모험가 가방을 여시고 대담한 모험을 위한 여러 도구들을 찾아보세요\""; explorerBackpackDescription_text.font = koreanFont; explorerBackpackDescription_text.fontSize = 6.7f;

        vikingShieldDescription_text.text = "\"바이킹 방패에는 전투를 두려워하지 않은 훌륭한 전사들의 유산이 깃들어 있습니다\""; vikingShieldDescription_text.font = koreanFont; vikingShieldDescription_text.fontSize = 7f;

        pillBottleDescription_text.text = "\"풍부함 속에서, 겸손한 알약 물병은 목적이 흥미롭게도 희미한 채로 숨어 있습니다\""; pillBottleDescription_text.font = koreanFont; pillBottleDescription_text.fontSize = 7f;

        victoryMedalDescription_text.text = "\"의기양양한 영광과 흔들리지 않는 결의의 상징인 승리 메달을 받아들이세요\""; victoryMedalDescription_text.font = koreanFont; victoryMedalDescription_text.fontSize = 6.5f;

        cookieDescription_text.text = "클릭하세요"; cookieDescription_text.font = koreanFont; cookieDescription_text.fontSize = 7f;

        christmasPresentDescription_text.text = "\"안에 무엇이 들어있는지 절대 모를 거에요\""; christmasPresentDescription_text.font = koreanFont; christmasPresentDescription_text.fontSize = 7f;

        battleAxeDescription_text.text = "\"이 전투 도끼는 전문적인 장인정신으로 다듬어지고 치명적인 날이 번득임으로써, 무자비한 효율성으로 적을 쪼갤 준비가 되었습니다\""; battleAxeDescription_text.font = koreanFont; battleAxeDescription_text.fontSize = 6f;

        goldCoin100XDescription_text.text = "\"세상에 이런 코인들은 얼마 남지 않았습니다\""; goldCoin100XDescription_text.font = koreanFont; goldCoin100XDescription_text.fontSize = 7f;

        sealedEnvelopeDescription_text.text = "\"역사적인 인물에 의해서 쓰였을 가능성이 높습니다\""; sealedEnvelopeDescription_text.font = koreanFont; sealedEnvelopeDescription_text.fontSize = 7f;

        strangePotionDescription_text.text = "\"이 미스터리 포션은 수수께끼같은 색깔로 휘몰아침으로써, 이를 마시고자 하는 대담한 자들에게 위험과 보상을 약속합니다.\""; strangePotionDescription_text.font = koreanFont; strangePotionDescription_text.fontSize = 6f;

        soulGemDescription_text.text = "\"이 발산하는 보석은 코스모스의 힘과 함께 파동침으로써 캐릭터의 힘과 능력을 증대시킬 것을 약속합니다.\""; soulGemDescription_text.font = koreanFont; soulGemDescription_text.fontSize = 6f;

        ancientScrollDescription_text.text = "\"오래된 지혜와 통찰력으로 채워져 있는 고대 두루마리\""; ancientScrollDescription_text.font = koreanFont; ancientScrollDescription_text.fontSize = 7f;

        brickDescription_text.text = "\"그치.. 그냥 벽돌이야\""; brickDescription_text.font = koreanFont; brickDescription_text.fontSize = 7f;

        rubberChickenDescription_text.text = "\"이 고무 닭이 장난일 것이라고 생각하시겠지만, 고무 닭 내부는 강력한 힘을 지니고 있습니다\""; rubberChickenDescription_text.font = koreanFont; rubberChickenDescription_text.fontSize = 7f;

        skullDropChance_text.text = "0,0278%<color=white> 드롭 확률"; skullDropChance_text.font = koreanFont; skullDropChance_text.fontSize = 10f;
        democSwordDropChance_text.text = "0,0119%<color=white> 드롭 확률"; democSwordDropChance_text.font = koreanFont; democSwordDropChance_text.fontSize = 10f;
        mysticRingDropChance_text.text = "0,0051%<color=white> 드롭 확률"; mysticRingDropChance_text.font = koreanFont; mysticRingDropChance_text.fontSize = 10f;
        trophyDropChance_text.text = "0,0050%<color=white> 드롭 확률"; trophyDropChance_text.font = koreanFont; trophyDropChance_text.fontSize = 10f;
        fallenStarDropChance_text.text = "0,0008%<color=white> 드롭 확률"; fallenStarDropChance_text.font = koreanFont; fallenStarDropChance_text.fontSize = 10f;
        cloverDropChance_text.text = "0,0005%<color=white> 드롭 확률"; cloverDropChance_text.font = koreanFont; cloverDropChance_text.fontSize = 10f;
        kingsCrownDropChance_text.text = "0,0006%<color=white> 드롭 확률"; kingsCrownDropChance_text.font = koreanFont; kingsCrownDropChance_text.fontSize = 10f;
        spellBookDropChance_text.text = "0,0006%<color=white> 드롭 확률"; spellBookDropChance_text.font = koreanFont; spellBookDropChance_text.fontSize = 10f;
        guitarDropChance_text.text = "0,0009%<color=white> 드롭 확률"; guitarDropChance_text.font = koreanFont; guitarDropChance_text.fontSize = 10f;
        talarianDropChance_text.text = "0,00077%<color=white> 드롭 확률"; talarianDropChance_text.font = koreanFont; talarianDropChance_text.fontSize = 10f;
        mythRuneDropChance_text.text = "0,0016%<color=white> 드롭 확률"; mythRuneDropChance_text.font = koreanFont; mythRuneDropChance_text.fontSize = 10f;
        backPackDropChance_text.text = "0,00052%<color=white> 드롭 확률"; backPackDropChance_text.font = koreanFont; backPackDropChance_text.fontSize = 10f;
        vikingShieldDropChance_text.text = "0,00063%<color=white> 드롭 확률"; vikingShieldDropChance_text.font = koreanFont; vikingShieldDropChance_text.fontSize = 10f;
        pillBottleDropChance_text.text = "0,00050%<color=white> 드롭 확률"; pillBottleDropChance_text.font = koreanFont; pillBottleDropChance_text.fontSize = 10f;
        victoryMedalDropChance_text.text = "0,00042%<color=white> 드롭 확률"; victoryMedalDropChance_text.font = koreanFont; victoryMedalDropChance_text.fontSize = 10f;
        cookieDropChance_text.text = "0,00034%<color=white> 드롭 확률"; cookieDropChance_text.font = koreanFont; cookieDropChance_text.fontSize = 10f;
        presentDropChance_text.text = "0,00038%<color=white> 드롭 확률"; presentDropChance_text.font = koreanFont; presentDropChance_text.fontSize = 10f;
        battleAxeDropChance_text.text = "0,00032%<color=white> 드롭 확률"; battleAxeDropChance_text.font = koreanFont; battleAxeDropChance_text.fontSize = 10f;
        coin100XDropChance_text.text = "0,00030%<color=white> 드롭 확률"; coin100XDropChance_text.font = koreanFont; coin100XDropChance_text.fontSize = 10f;
        envelopeDropChance_text.text = "0,00036%<color=white> 드롭 확률"; envelopeDropChance_text.font = koreanFont; envelopeDropChance_text.fontSize = 10f;
        strangePotionDropChance_text.text = "0,00030%<color=white> 드롭 확률"; strangePotionDropChance_text.font = koreanFont; strangePotionDropChance_text.fontSize = 10f;
        soulGemDropChance_text.text = "0,00034%<color=white> 드롭 확률"; soulGemDropChance_text.font = koreanFont; soulGemDropChance_text.fontSize = 10f;
        ancientScrollDropChance_text.text = "0,00029%<color=white> 드롭 확률"; ancientScrollDropChance_text.font = koreanFont; ancientScrollDropChance_text.fontSize = 10f;
        brickDropChance_text.text = "0,00026%<color=white> 드롭 확률"; brickDropChance_text.font = koreanFont; brickDropChance_text.fontSize = 10f;
        chickenDropChance_text.text = "0,00025%<color=white> 드롭 확률"; chickenDropChance_text.font = koreanFont; chickenDropChance_text.fontSize = 10f;

        congratsMessage_text.text = "축하합니다! 25개의 모든 보물들을 얻으셨습니다!"; congratsMessage_text.font = koreanFont; congratsMessage_text.fontSize = 17f;
        purchaseRareTreasure_text.text = "잠금을 해제하려면 모든 프레스티지 업그레이드를 구매하세요."; purchaseRareTreasure_text.font = koreanFont; purchaseRareTreasure_text.fontSize = 17f;
        purchase1MissingTreasure_text.text = "가지고 있지 않는 레어 보물 1개를 구매하시겠습니까?"; purchase1MissingTreasure_text.font = koreanFont; purchase1MissingTreasure_text.fontSize = 12f;

        chooseChickenBuff_text.text = "닭으로부터 버프를 선택하세요:"; chooseChickenBuff_text.font = koreanFont; chooseChickenBuff_text.fontSize = 36f;
        coose1_text.text = "선택"; coose1_text.font = koreanFont; coose1_text.fontSize = 23f;
        coose2_text.text = "선택"; coose2_text.font = koreanFont; coose2_text.fontSize = 23f;
        coose3_text.text = "선택"; coose3_text.font = koreanFont; coose3_text.fontSize = 23f;
        coose4_text.text = "선택"; coose4_text.font = koreanFont; coose4_text.fontSize = 23f;
        coose5_text.text = "선택"; coose5_text.font = koreanFont; coose5_text.fontSize = 23f;
        coose6_text.text = "선택"; coose6_text.font = koreanFont; coose6_text.fontSize = 23f;
        coose7_text.text = "선택"; coose7_text.font = koreanFont; coose7_text.fontSize = 23f;
        #endregion

        #region Treasure Chests
        chestPurchase_text.text = "구입"; chestPurchase_text.font = koreanFont; chestPurchase_text.fontSize = 36;
        autoPurchase_text.text = "지불할 수 있을 경우 다음 상자를 자동으로 구매합니다: "; autoPurchase_text.font = koreanFont; autoPurchase_text.fontSize = 11;
        chestTREASURESDROP_text.text = "보물 드롭:"; chestTREASURESDROP_text.font = koreanFont; chestTREASURESDROP_text.fontSize = 18;
        reinforcedPopUp_text.text = "강화 상자 "; reinforcedPopUp_text.font = koreanFont; reinforcedPopUp_text.fontSize = 36;
        enchantedGoldenChestPopUp_text.text = "마법에 걸린 황금 상자"; enchantedGoldenChestPopUp_text.font = koreanFont; enchantedGoldenChestPopUp_text.fontSize = 32;
        bossChest_text.text = "보스 상자"; bossChest_text.font = koreanFont; bossChest_text.fontSize = 50;
        reinforcedHover_text.text = "강화 상자"; reinforcedHover_text.font = koreanFont; reinforcedHover_text.fontSize = 25;

        enchantedGoldenHover_text.text = "마법에 걸린 황금 상자"; enchantedGoldenHover_text.font = koreanFont; enchantedGoldenHover_text.fontSize = 24;
        enchantedGoldenHoverLockPickKeys_text.text = "자물쇠 따개와 열쇠는 상자의 HP 중 33%만을 제거합니다."; enchantedGoldenHoverLockPickKeys_text.font = koreanFont; enchantedGoldenHoverLockPickKeys_text.fontSize = 17;

        bossChestHover_text.text = "보스 상자"; bossChestHover_text.font = koreanFont; bossChestHover_text.fontSize = 38;
        bossChestHoverLockPickKeys_text.text = "자물쇠 따개와 열쇠는 상자의 HP 중 33%만을 제거합니다."; bossChestHoverLockPickKeys_text.font = koreanFont; bossChestHoverLockPickKeys_text.fontSize = 16;


        #endregion

        #region prestige

        wouldYouLiketoGoBack_text.text = "뒤로 돌아가시고 상자 몇 개를 더 오픈해보시겠어요? ";
        wouldYouLiketoGoBack_text.font = koreanFont; wouldYouLiketoGoBack_text.fontSize = 40;

        butFirst_text.text = "하지만 먼저…";
        butFirst_text.font = koreanFont; butFirst_text.fontSize = 20;

        purchaseTheGoodieBag_text.text = "잠금 해제하기 위해서 \"사탕 가방\" 프레스티지 업그레이드를 구매하세요";
        purchaseTheGoodieBag_text.font = koreanFont; purchaseTheGoodieBag_text.fontSize = 22;

        goBackYES_text.text = "예"; goBackYES_text.font = koreanFont; goBackYES_text.fontSize = 60;

        goBackNO_text.text = "아니오"; goBackNO_text.font = koreanFont; goBackNO_text.fontSize = 60;

        itesmChosen_text.text = "아이템 선택 완료!"; itesmChosen_text.font = koreanFont; itesmChosen_text.fontSize = 26;

        chooseSomethingElse_text.text = "다른 것을 선택해주세요"; chooseSomethingElse_text.font = koreanFont; chooseSomethingElse_text.fontSize = 28;

        prestigeExit_text.text = "나가기"; prestigeExit_text.font = koreanFont; prestigeExit_text.fontSize = 47;

        for (int i = 0; i < lockedPrestige_text.Length; i++)
        {
            lockedPrestige_text[i].text = "잠금됨"; lockedPrestige_text[i].font = koreanFont; lockedPrestige_text[i].fontSize = 12f;
            unlockedPrestige_text[i].text = "잠금 해제됨"; unlockedPrestige_text[i].font = koreanFont; unlockedPrestige_text[i].fontSize = 8.6f;
        }

        findThePrestigeKeyAncChest_text.lineSpacing = -35;
        openPrestigeScreen_text.lineSpacing = -50;

        loseText_text.lineSpacing = -30;
        keepText_text.lineSpacing = -30;

        // For individual variables
        prestigeTop_text.text = "프레스티지"; prestigeTop_text.font = koreanFont; prestigeTop_text.fontSize = 50;
        prestigeButton_text.text = "프레스티지"; prestigeButton_text.font = koreanFont; prestigeButton_text.fontSize = 36;
        openPrestigeScreen_text.text = "프레스티지 화면 오픈하기"; openPrestigeScreen_text.font = koreanFont; openPrestigeScreen_text.fontSize = 28;
        skillPoints_text.text = "스킬 포인트"; skillPoints_text.font = koreanFont; skillPoints_text.fontSize = 20;

        wouldYouLikeToPrestige_text.text = "프레스티지를 하시겠어요?"; wouldYouLikeToPrestige_text.font = koreanFont; wouldYouLikeToPrestige_text.fontSize = 22;
        youWillKeep_text.text = "다음의 것들을 유지하게 됩니다"; youWillKeep_text.font = koreanFont; youWillKeep_text.fontSize = 25;
        keepText_text.text = "-프레스티지 업그레이드 \n-레어 보물 \n-업적"; keepText_text.font = koreanFont; keepText_text.fontSize = 34;
        youWillLose_text.text = "다음의 것들을 잃게 됩니다"; youWillLose_text.font = koreanFont; youWillLose_text.fontSize = 27;
        loseText_text.text = "-모든 골드 \n-보물\n-레벨\n-아이템\n-아이템 레벨 \n-커서\n-커서 레벨 \n-스크롤 스탯"; loseText_text.font = koreanFont; loseText_text.fontSize = 37;
        prestigeWillTakeYou_text.text = "프레스티지는 영구 업그레이드를 구매하실 수 있으신 곳인 스킬 나무로 데려다드릴 것입니다"; prestigeWillTakeYou_text.font = koreanFont; prestigeWillTakeYou_text.fontSize = 14.4f;
        prestigeYES_text.text = "예"; prestigeYES_text.font = koreanFont; prestigeYES_text.fontSize = 25;
        prestigeNO_text.text = "아니오"; prestigeNO_text.font = koreanFont; prestigeNO_text.fontSize = 25;
        prestigeAndSkillPoints_text.text = "프레스티지 & 스킬 포인트"; prestigeAndSkillPoints_text.font = koreanFont; prestigeAndSkillPoints_text.fontSize = 80;
        prestigeExplinations_text.text = " -프레스티지 열쇠와 프레스티지 상자는 새로운 상자가 잠금해제된 이후에 추가적으로 0.017% 드롭 확률을 얻습니다"; prestigeExplinations_text.font = koreanFont; prestigeExplinations_text.fontSize = 32;
        prestigeExplinations2_text.text = " -레벨업을 할 때마다 스킬 포인트를 얻습니다. 5 레벨마다 얻은 총 스킬 포인트에 1 스킬 포인트를 추가적으로 부여합니다. 각 레벨마다 얻은 스킬 포인트 = (현재 레벨/ 5) + 1"; prestigeExplinations2_text.font = koreanFont; prestigeExplinations2_text.fontSize = 32;
        currentlyViewingPrestige_text.text = "현재 프레스티지 화면만 보고 계십니다."; currentlyViewingPrestige_text.font = koreanFont; currentlyViewingPrestige_text.fontSize = 38;
        skillPointsTextInsode_text.text = "스킬 포인트"; skillPointsTextInsode_text.font = koreanFont; skillPointsTextInsode_text.fontSize = 36;

        clickerUnder_text.text = "클리커"; clickerUnder_text.font = koreanFont; clickerUnder_text.fontSize = 44;
        loungerUnder_text.text = "라운저"; loungerUnder_text.font = koreanFont; loungerUnder_text.fontSize = 44;
        pirateUnder_text.text = "해적"; pirateUnder_text.font = koreanFont; pirateUnder_text.fontSize = 44;
        hoarderUnder_text.text = "호더"; hoarderUnder_text.font = koreanFont; hoarderUnder_text.fontSize = 44;
        adventurerUnder_text.text = "모험가"; adventurerUnder_text.font = koreanFont; adventurerUnder_text.fontSize = 44;

        bossChestPresitgeName_text.text = "보스 상자"; bossChestPresitgeName_text.font = koreanFont; bossChestPresitgeName_text.fontSize = 26;
        reinforcedItems_text.text = "강화 아이템"; reinforcedItems_text.font = koreanFont; reinforcedItems_text.fontSize = 22;
        potionStacker_text.text = "포션 스태커"; potionStacker_text.font = koreanFont; potionStacker_text.fontSize = 24;
        fortifiedItems_text.text = "요새화된 아이템"; fortifiedItems_text.font = koreanFont; fortifiedItems_text.fontSize = 26;
        enhancedItems_text.text = "개선된 아이템"; enhancedItems_text.font = koreanFont; enhancedItems_text.fontSize = 23;
        enchantedItems_text.text = "마법에 걸린 아이템"; enchantedItems_text.font = koreanFont; enchantedItems_text.fontSize = 22;
        itemMastery_text.text = "아이템 숙련도"; itemMastery_text.font = koreanFont; itemMastery_text.fontSize = 26;
        enchantmentQuill_text.text = "마법 깃"; enchantmentQuill_text.font = koreanFont; enchantmentQuill_text.fontSize = 23;
        wizard_text.text = "마법사"; wizard_text.font = koreanFont; wizard_text.fontSize = 26;
        student_text.text = "학생"; student_text.font = koreanFont; student_text.fontSize = 26;
        potionChug_text.text = "포션 원샷"; potionChug_text.font = koreanFont; potionChug_text.fontSize = 26;
        transcendence_text.text = "초월"; transcendence_text.font = koreanFont; transcendence_text.fontSize = 23;
        elevation_text.text = "높이"; elevation_text.font = koreanFont; elevation_text.fontSize = 26;
        xpAccelerator_text.text = "XP 가속시"; xpAccelerator_text.font = koreanFont; xpAccelerator_text.fontSize = 25;
        proficiency_text.text = "능숙도"; proficiency_text.font = koreanFont; proficiency_text.fontSize = 26;
        levelMastery_text.text = "레벨 숙련도"; levelMastery_text.font = koreanFont; levelMastery_text.fontSize = 26;
        advancement_text.text = "전진"; advancement_text.font = koreanFont; advancement_text.fontSize = 26;
        xpBoost_text.text = "XP 부스트"; xpBoost_text.font = koreanFont; xpBoost_text.fontSize = 26;
        masterPirate_text.text = "마스터 해적"; masterPirate_text.font = koreanFont; masterPirate_text.fontSize = 26;
        fortuneSeeker_text.text = "재산을 노리는 사람"; fortuneSeeker_text.font = koreanFont; fortuneSeeker_text.fontSize = 22;
        pirate_text.text = "해적"; pirate_text.font = koreanFont; pirate_text.fontSize = 26;
        rapidLeveling_text.text = "재빠른 레벨링"; rapidLeveling_text.font = koreanFont; rapidLeveling_text.fontSize = 26;
        treasureAmplifier_text.text = "보물 증폭기"; treasureAmplifier_text.font = koreanFont; treasureAmplifier_text.fontSize = 22;
        stackingSplendor_text.text = "쌓여진 화려함"; stackingSplendor_text.font = koreanFont; stackingSplendor_text.fontSize = 21;
        goodieBag_text.text = "사탕 가방"; goodieBag_text.font = koreanFont; goodieBag_text.fontSize = 26;
        reinforcedRiches_text.text = "강화된 풍부함"; reinforcedRiches_text.font = koreanFont; reinforcedRiches_text.fontSize = 20;
        chestBlessing_text.text = "상자 축복"; chestBlessing_text.font = koreanFont; chestBlessing_text.fontSize = 25;
        chestSurge_text.text = "상자 파동"; chestSurge_text.font = koreanFont; chestSurge_text.fontSize = 26;
        fortifiedFortune_text.text = "요새화된 재산"; fortifiedFortune_text.font = koreanFont; fortifiedFortune_text.fontSize = 23;
        enchantedGoldenChest_text.text = "마법에 걸린 황금 상자 "; enchantedGoldenChest_text.font = koreanFont; enchantedGoldenChest_text.fontSize = 17;
        piratesParadise_text.text = "해적의 천국"; piratesParadise_text.font = koreanFont; piratesParadise_text.fontSize = 23;
        luxuriousLooting_text.text = "사치스러운 약탈"; luxuriousLooting_text.font = koreanFont; luxuriousLooting_text.fontSize = 21;
        lootBonanza_text.text = "약탈 노다지 광맥"; lootBonanza_text.font = koreanFont; lootBonanza_text.fontSize = 26;
        chestEnrichment_text.text = "상자 강화"; chestEnrichment_text.font = koreanFont; chestEnrichment_text.fontSize = 21;
        greaterLoot_text.text = "더 거대한 약탈"; greaterLoot_text.font = koreanFont; greaterLoot_text.fontSize = 26;
        treasuryReinforcement_text.text = "보물 강화 "; treasuryReinforcement_text.font = koreanFont; treasuryReinforcement_text.fontSize = 16;
        strongbox_text.text = "금고"; strongbox_text.font = koreanFont; strongbox_text.fontSize = 27;
        fortified_text.text = "요새화된 "; fortified_text.font = koreanFont; fortified_text.fontSize = 26;
        gildedFortification_text.text = "화려한 요새화"; gildedFortification_text.font = koreanFont; gildedFortification_text.fontSize = 21;
        reinforcedPlus_text.text = "강화된 +"; reinforcedPlus_text.font = koreanFont; reinforcedPlus_text.fontSize = 26;
        wellPrepared_text.text = "잘 준비된"; wellPrepared_text.font = koreanFont; wellPrepared_text.fontSize = 26;
        stashedItems_text.text = "숨겨진 아이템"; stashedItems_text.font = koreanFont; stashedItems_text.fontSize = 26;
        travelBag_text.text = "여행 가방"; travelBag_text.font = koreanFont; travelBag_text.fontSize = 26;
        buffsGalore_text.text = "충분한 버프"; buffsGalore_text.font = koreanFont; buffsGalore_text.fontSize = 24;
        lootEnhancer_text.text = "약탈 개선기"; lootEnhancer_text.font = koreanFont; lootEnhancer_text.fontSize = 24;
        treasureHunter_text.text = "보물사냥꾼"; treasureHunter_text.font = koreanFont; treasureHunter_text.fontSize = 26;
        collector_text.text = "수집가"; collector_text.font = koreanFont; collector_text.fontSize = 26;
        autoClicker1_text.text = "자동 클릭기 "; autoClicker1_text.font = koreanFont; autoClicker1_text.fontSize = 26;
        autoClicker2_text.text = "자동 클릭기 +"; autoClicker2_text.font = koreanFont; autoClicker2_text.fontSize = 26;
        autoClicker3_text.text = "자동 클릭기 ++"; autoClicker3_text.font = koreanFont; autoClicker3_text.fontSize = 26;
        autoClicker4_text.text = "난타 클리커"; autoClicker4_text.font = koreanFont; autoClicker4_text.fontSize = 26;
        cursorEnchantment_text.text = "커서 마법 걸기"; cursorEnchantment_text.font = koreanFont; cursorEnchantment_text.fontSize = 20;
        advancedCursors_text.text = "고급 커서"; advancedCursors_text.font = koreanFont; advancedCursors_text.fontSize = 22;
        cursorEvolution_text.text = "커서 진화"; cursorEvolution_text.font = koreanFont; cursorEvolution_text.fontSize = 24;
        cursorEnhanced_text.text = "개선된 커서"; cursorEnhanced_text.font = koreanFont; cursorEnhanced_text.fontSize = 23;
        crushingForce_text.text = "충돌하는 힘"; crushingForce_text.font = koreanFont; crushingForce_text.fontSize = 26;
        swiftblade_text.text = "스위프트 블레이드"; swiftblade_text.font = koreanFont; swiftblade_text.fontSize = 23;
        fury_text.text = "분노"; fury_text.font = koreanFont; fury_text.fontSize = 26;
        clickstorm_text.text = "클릭스톰"; clickstorm_text.font = koreanFont; clickstorm_text.fontSize = 26;
        tapPrecision_text.text = "정밀한 탭"; tapPrecision_text.font = koreanFont; tapPrecision_text.fontSize = 26;
        clickersFury_text.text = "클리커의 분노"; clickersFury_text.font = koreanFont; clickersFury_text.fontSize = 26;
        tapMastery_text.text = "탭 숙련도"; tapMastery_text.font = koreanFont; tapMastery_text.fontSize = 26;
        cripplingStrikes_text.text = "치명적인 타격"; cripplingStrikes_text.font = koreanFont; cripplingStrikes_text.fontSize = 24;
        savageCrits_text.text = "잔인한 크리티컬 히트"; savageCrits_text.font = koreanFont; savageCrits_text.fontSize = 20;
        lethalPrecision_text.text = "치명적인 정밀함"; lethalPrecision_text.font = koreanFont; lethalPrecision_text.fontSize = 24;
        ruthlessStrikes_text.text = "무자비한 타격"; ruthlessStrikes_text.font = koreanFont; ruthlessStrikes_text.fontSize = 26;
        hardenedFist_text.text = "딱딱해진 주먹"; hardenedFist_text.font = koreanFont; hardenedFist_text.fontSize = 26;
        idler_text.text = "게으름뱅이"; idler_text.font = koreanFont; idler_text.fontSize = 26;
        lazyRewards_text.text = "게으른 리워드"; lazyRewards_text.font = koreanFont; lazyRewards_text.fontSize = 26;
        unfathomableWealth_text.text = "잴 수 없는 부"; unfathomableWealth_text.font = koreanFont; unfathomableWealth_text.fontSize = 24;
        ancientCoin_text.text = "고대 코인"; ancientCoin_text.font = koreanFont; ancientCoin_text.fontSize = 26;
        fortuneCoin_text.text = "운 코인"; fortuneCoin_text.font = koreanFont; fortuneCoin_text.fontSize = 26;
        wealthEmpire_text.text = "부유 제국"; wealthEmpire_text.font = koreanFont; wealthEmpire_text.fontSize = 26;
        luckyPenny_text.text = "운 코인"; luckyPenny_text.font = koreanFont; luckyPenny_text.fontSize = 26;
        fortune_text.text = "운 코인"; fortune_text.font = koreanFont; fortune_text.fontSize = 26;
        extremelyWealthy_text.text = "매우 부유함"; extremelyWealthy_text.font = koreanFont; extremelyWealthy_text.fontSize = 21;
        wealthy_text.text = "부유함"; wealthy_text.font = koreanFont; wealthy_text.fontSize = 26;
        idlersMastery_text.text = "게으름뱅이의 숙련도"; idlersMastery_text.font = koreanFont; idlersMastery_text.fontSize = 23;
        wealth_text.text = "부"; wealth_text.font = koreanFont; wealth_text.fontSize = 26;
        potentCursors_text.text = "유력한 커서"; potentCursors_text.font = koreanFont; potentCursors_text.fontSize = 26;
        mightyCursors_text.text = "강력한 커서"; mightyCursors_text.font = koreanFont; mightyCursors_text.fontSize = 23;
        reforgedCursors_text.text = "재련된 커서"; reforgedCursors_text.font = koreanFont; reforgedCursors_text.fontSize = 23;
        sloppyFist_text.text = "엉성한 주먹"; sloppyFist_text.font = koreanFont; sloppyFist_text.fontSize = 26;
        effortless_text.text = "손쉽게"; effortless_text.font = koreanFont; effortless_text.fontSize = 26;
        loungingKing_text.text = "게으른 왕"; loungingKing_text.font = koreanFont; loungingKing_text.fontSize = 26;
        loungingPirate_text.text = "게으른 해적"; loungingPirate_text.font = koreanFont; loungingPirate_text.fontSize = 24;
        loungingOgre_text.text = "게으른 오우거"; loungingOgre_text.font = koreanFont; loungingOgre_text.fontSize = 26;
        restfulIdler_text.text = "조용한 게으름뱅이"; restfulIdler_text.font = koreanFont; restfulIdler_text.fontSize = 26;
        cursorMastery_text.text = "커서 숙련도"; cursorMastery_text.font = koreanFont; cursorMastery_text.fontSize = 26;

        critDes1_text.text = ""; critDes1_text.font = koreanFont; critDes1_text.fontSize = 15;

        // Crit Descriptions
        critDes1_text.text = "<color=green>+0.5%<color=white> 크리티컬 확률";
        critDes1_2_text.text = "<color=green>+150%<color=white> 크리티컬 데미지";
        critDes2_text.text = "<color=green>+1.5%<color=white> 크리티컬 확률";
        critDes2_2_text.text = "<color=green>+750%<color=white> 크리티컬 데미지";
        critDes3_text.text = "<color=green>+1.8%<color=white> 크리티컬 확률";
        critDes3_2_text.text = "<color=green>+1500%<color=white> 크리티컬 데미지";
        critDes4_text.text = "<color=green>+2.2%<color=white> 크리티컬 확률";
        critDes4_2_text.text = "크리티컬 히트에서 골드 코인을 스폰할 10%의 확률";
        critDes5_text.text = "<color=green>+2500%<color=white> 크리티컬 데미지";
        critDes5_2_text.text = "크리티컬 히트에서 보물을 스폰할 4%의 확률";

        critDes1_text.font = koreanFont;
        critDes1_2_text.font = koreanFont;
        critDes2_text.font = koreanFont;
        critDes2_2_text.font = koreanFont;
        critDes3_text.font = koreanFont;
        critDes3_2_text.font = koreanFont;
        critDes4_text.font = koreanFont;
        critDes4_2_text.font = koreanFont;
        critDes5_text.font = koreanFont;
        critDes5_2_text.font = koreanFont;

        critDes1_text.fontSize = 15;
        critDes1_2_text.fontSize = 15;
        critDes2_text.fontSize = 15;
        critDes2_2_text.fontSize = 15;
        critDes3_text.fontSize = 15;
        critDes3_2_text.fontSize = 15;
        critDes4_text.fontSize = 15;
        critDes4_2_text.fontSize = 15;
        critDes5_text.fontSize = 15;
        critDes5_2_text.fontSize = 15;

        // Active Descriptions
        activeDes1_text.text = "<color=green>+50%<color=white> 액티브 데미지";
        activeDes2_text.text = "<color=green>+325%<color=white> 액티브 데미지";
        activeDes3_text.text = "<color=green>+1000%<color=white> 액티브 데미지";
        activeDes4_text.text = "<color=green>+2250%<color=white> 액티브 데미지";
        activeDes4_2_text.text = "클릭할 때마다 골드 코인을 스폰할 수 있는 1%의 확률";
        activeDes5_text.text = "<color=green>+3500%<color=white> 액티브 데미지";
        activeDes5_2_text.text = "클릭할 때마다 보물을 스폰할 수 있는 0.1%의 확률";
        activeDes6_text.text = "<color=green>+10000%<color=white> 액티브 데미지";
        activeDes6_2_text.text = "모든 클릭은 상자를 즉각적으로 오픈할 수 있는 0.4%의 확률을 추가로 얻게 됩니다";
        activeDes7_text.text = "<color=green>+15000%<color=white> 액티브 데미지";
        activeDes7_2_text.text = "모든 클릭은 5X 골드 코인을 스폰할 수 있는 1%의 확률을 추가로 얻게 됩니다";

        activeDes1_text.font = koreanFont;
        activeDes2_text.font = koreanFont;
        activeDes3_text.font = koreanFont;
        activeDes4_text.font = koreanFont;
        activeDes4_2_text.font = koreanFont;
        activeDes5_text.font = koreanFont;
        activeDes5_2_text.font = koreanFont;
        activeDes6_text.font = koreanFont;
        activeDes6_2_text.font = koreanFont;
        activeDes7_text.font = koreanFont;
        activeDes7_2_text.font = koreanFont;

        activeDes1_text.fontSize = 15;
        activeDes2_text.fontSize = 15;
        activeDes3_text.fontSize = 15;
        activeDes4_text.fontSize = 15;
        activeDes4_2_text.fontSize = 15;
        activeDes5_text.fontSize = 15;
        activeDes5_2_text.fontSize = 15;
        activeDes6_text.fontSize = 15;
        activeDes6_2_text.fontSize = 15;
        activeDes7_text.fontSize = 15;
        activeDes7_2_text.fontSize = 14.9f;

        // Active Cursor Descriptions
        activeCursorDes1_text.text = "액티브 데미지, 크리티컬 확률, 그리고 크리티컬 데미지로 커서를 레벨업시키는 것은 커서를 강하게 합니다";
        activeCursorDes2_text.text = "액티브 데미지, 크리티컬 확률, 그리고 크리티컬 데미지로 커서를 레벨업시키는 것은 커서를 강하게 합니다";
        activeCursorDes3_text.text = "모든 액티브 데미지, 크리티컬 확률과 크리티컬 데미지 커서는 강력하게 시작합니다";
        activeCursorDes4_text.text = "모든 액티브 데미지, 크리티컬 확률과 크리티컬 데미지 커서는 강력하게 시작합니다";
        activeCursorDes4_2_text.text = "액티브 데미지, 크리티컬 확률, 그리고 크리티컬 데미지로 커서를 레벨업시키는 것은 커서를 강하게 합니다";

        activeCursorDes1_text.font = koreanFont;
        activeCursorDes2_text.font = koreanFont;
        activeCursorDes3_text.font = koreanFont;
        activeCursorDes4_text.font = koreanFont;
        activeCursorDes4_2_text.font = koreanFont;

        activeCursorDes1_text.fontSize = 14;
        activeCursorDes2_text.fontSize = 14;
        activeCursorDes3_text.fontSize = 14;
        activeCursorDes4_text.fontSize = 13;
        activeCursorDes4_2_text.fontSize = 12.6f;

        // Auto Clicker Descriptions
        autoClickerDes1_text.text = "자동 클리커는 초당 1클릭을 수행합니다";
        autoClickerDes1_2_text.text = "각 클릭은 총 액티브 데미지의 100%를 가합니다";
        autoClickerDes2_text.text = "자동 클리커는 초당 2클릭을 수행합니다";
        autoClickerDes3_text.text = "자동 클리커는 초당 4클릭을 수행합니다";
        autoClickerDes4_text.text = "자동 클리커는 초당 8클릭을 수행합니다";

        autoClickerDes1_text.font = koreanFont;
        autoClickerDes1_2_text.font = koreanFont;
        autoClickerDes2_text.font = koreanFont;
        autoClickerDes3_text.font = koreanFont;
        autoClickerDes4_text.font = koreanFont;

        autoClickerDes1_text.fontSize = 14;
        autoClickerDes1_2_text.fontSize = 14;
        autoClickerDes2_text.fontSize = 14;
        autoClickerDes3_text.fontSize = 14;
        autoClickerDes4_text.fontSize = 14;

        // Passive Descriptions
        passiveDes1_text.text = "<color=green>+25%<color=white> 패시브 데미지";
        passiveDes2_text.text = "<color=green>+115%<color=white> 패시브 데미지";
        passiveDes3_text.text = "<color=green>+400%<color=white> 패시브 데미지";
        passiveDes3_2_text.text = "상자 7개가 오픈될 때마다 1 골드 코인을 스폰합니다";
        passiveDes4_text.text = "<color=green>+850%<color=white> 패시브 데미지";
        passiveDes4_2_text.text = "상자 25개가 오픈될 때마다 보물 1개를 스폰합니다";
        passiveDes5_text.text = "<color=green>+1100%<color=white> 패시브 데미지";
        passiveDes6_text.text = "<color=green>+1600%<color=white> 패시브 데미지";
        passiveDes6_2_text.text = "상자 25개가 오픈될 때마다 보물 1개와 4 골드 코인을 스폰합니다";
        passiveDes7_text.text = "<color=green>+3500%<color=white> 패시브 데미지";
        passiveDes7_2_text.text = "모든 상자는 1 골드 코인을 추가로 드롭합니다";
        passiveDes8_text.text = "<color=green>+6500%<color=white> 패시브 데미지";

        passiveDes1_text.font = koreanFont;
        passiveDes2_text.font = koreanFont;
        passiveDes3_text.font = koreanFont;
        passiveDes3_2_text.font = koreanFont;
        passiveDes4_text.font = koreanFont;
        passiveDes4_2_text.font = koreanFont;
        passiveDes5_text.font = koreanFont;
        passiveDes6_text.font = koreanFont;
        passiveDes6_2_text.font = koreanFont;
        passiveDes7_text.font = koreanFont;
        passiveDes7_2_text.font = koreanFont;
        passiveDes8_text.font = koreanFont;

        passiveDes1_text.fontSize = 15;
        passiveDes2_text.fontSize = 15;
        passiveDes3_text.fontSize = 15;
        passiveDes3_2_text.fontSize = 15;
        passiveDes4_text.fontSize = 15;
        passiveDes4_2_text.fontSize = 15;
        passiveDes5_text.fontSize = 15;
        passiveDes6_text.fontSize = 15;
        passiveDes6_2_text.fontSize = 15;
        passiveDes7_text.fontSize = 15;
        passiveDes7_2_text.fontSize = 15;
        passiveDes8_text.fontSize = 15;

        // Passive Cursor Descriptions
        passiveCursorDes1_text.text = "패시브 데미지로 커서를 레벨업 시키는 것은 커서를 강하게 합니다";
        passiveCursorDes2_text.text = "패시브 데미지로 커서를 레벨업 시키는 것은 커서를 강하게 합니다";
        passiveCursorDes3_text.text = "패시브 데미지 커서는 강력하게 시작합니다";
        passiveCursorDes4_text.text = "패시브 데미지 커서는 강력하게 시작합니다";
        passiveCursorDes4_2_text.text = "패시브 데미지로 커서를 레벨업 시키는 것은 커서를 강하게 합니다";
        passiveCursorDes5_text.text = "패시브 데미지 커서는 강력하게 시작합니다";
        passiveCursorDes5_2_text.text = "패시브 데미지로 커서를 레벨업 시키는 것은 커서를 강하게 합니다";

        passiveCursorDes1_text.font = koreanFont;
        passiveCursorDes2_text.font = koreanFont;
        passiveCursorDes3_text.font = koreanFont;
        passiveCursorDes4_text.font = koreanFont;
        passiveCursorDes4_2_text.font = koreanFont;
        passiveCursorDes5_text.font = koreanFont;
        passiveCursorDes5_2_text.font = koreanFont;

        passiveCursorDes1_text.fontSize = 14;
        passiveCursorDes2_text.fontSize = 14;
        passiveCursorDes3_text.fontSize = 13.8f;
        passiveCursorDes4_text.fontSize = 13.8f;
        passiveCursorDes4_2_text.fontSize = 14;
        passiveCursorDes5_text.fontSize = 13.8f;
        passiveCursorDes5_2_text.fontSize = 14;

        // Gold Descriptions
        goldDes1_text.text = "골드 코인은 30%의 골드를 추가로 더 줍니다";
        goldDes2_text.text = "골드 코인은 120%의 골드를 추가로 더 줍니다";
        goldDes3_text.text = "골드 코인은 500%의 골드를 추가로 더 줍니다";
        goldDes4_text.text = "골드 코인은 1000%의 골드를 추가로 더 줍니다";
        goldDes4_2_text.text = "골드 코인은 2X 골드의 가치를 지닐 3%의 확률을 갖고 있습니다";
        goldDes5_text.text = "상자들은 5X 골드의 가치를 지닌 골드 코인을 드롭할 3%의 확률을 갖고 있습니다";
        goldDes6_text.text = "골드 코인은 2000%의 골드를 추가로 더 줍니다";
        goldDes7_text.text = "상자들은 10X 골드의 가치를 지닌 골드 코인을 드롭할 2%의 확률을 갖고 있습니다";
        goldDes7_2_text.text = "골드 코인은 1250%의 골드를 추가로 더 줍니다";
        goldDes8_text.text = "상자들은 25X 골드의 가치를 지닌 골드 코인을 드롭할 1%의 확률을 갖고 있습니다";
        goldDes8_2_text.text = "골드 코인은 4000%의 골드를 추가로 더 줍니다";
        goldDes9_text.text = "5X, 10X, 그리고 25X 골드 코인만이 상자에서 드롭될 것입니다.";
        goldDes9_2_text.text = "골드 코인은 5000%의 골드를 추가로 더 줍니다";

        goldDes1_text.font = koreanFont;
        goldDes2_text.font = koreanFont;
        goldDes3_text.font = koreanFont;
        goldDes4_text.font = koreanFont;
        goldDes4_2_text.font = koreanFont;
        goldDes5_text.font = koreanFont;
        goldDes6_text.font = koreanFont;
        goldDes7_text.font = koreanFont;
        goldDes7_2_text.font = koreanFont;
        goldDes8_text.font = koreanFont;
        goldDes8_2_text.font = koreanFont;
        goldDes9_text.font = koreanFont;
        goldDes9_2_text.font = koreanFont;

        goldDes1_text.fontSize = 14;
        goldDes2_text.fontSize = 14;
        goldDes3_text.fontSize = 14;
        goldDes4_text.fontSize = 14;
        goldDes4_2_text.fontSize = 14;
        goldDes5_text.fontSize = 14;
        goldDes6_text.fontSize = 14;
        goldDes7_text.fontSize = 14;
        goldDes7_2_text.fontSize = 14;
        goldDes8_text.fontSize = 14;
        goldDes8_2_text.fontSize = 14;
        goldDes9_text.fontSize = 14;
        goldDes9_2_text.fontSize = 14;

        // Treasure Descriptions
        treasureDes1_text.text = "<color=green>+0.1% <color=white>보물 드롭 확률";
        treasureDes2_text.text = "<color=green>+0.2% <color=white>보물 드롭 확률";
        treasureDes3_text.text = "보물 가치가 두 배로 뛸 확률 8%";
        treasureDes4_text.text = "보물 가치가 두 배로 뛸 확률 5%";
        treasureDes4_2_text.text = "<color=green>+0.2% <color=white>보물 드롭 확률";
        treasureDes5_text.text = "보물 가치가 두 배로 뛸 확률 10%";
        treasureDes5_2_text.text = "<color=green>+0.2% <color=white>보물 드롭 확률";
        treasureDes6_text.text = "보물 가치가 두 배로 뛸 확률 13%";
        treasureDes6_2_text.text = "보물 가방 드롭 확률 +1%";
        treasureDes7_text.text = "<color=green>+0.4% <color=white>보물 드롭 확률";
        treasureDes7_2_text.text = "몇몇 보물들은 현재 5X 보다 많은 골드의 가치를 지니고 있습니다";

        treasureDes1_text.font = koreanFont;
        treasureDes2_text.font = koreanFont;
        treasureDes3_text.font = koreanFont;
        treasureDes4_text.font = koreanFont;
        treasureDes4_2_text.font = koreanFont;
        treasureDes5_text.font = koreanFont;
        treasureDes5_2_text.font = koreanFont;
        treasureDes6_text.font = koreanFont;
        treasureDes6_2_text.font = koreanFont;
        treasureDes7_text.font = koreanFont;
        treasureDes7_2_text.font = koreanFont;

        treasureDes1_text.fontSize = 14;
        treasureDes2_text.fontSize = 14;
        treasureDes3_text.fontSize = 14;
        treasureDes4_text.fontSize = 14;
        treasureDes4_2_text.fontSize = 14;
        treasureDes5_text.fontSize = 14;
        treasureDes6_text.fontSize = 14;
        treasureDes6_2_text.fontSize = 14;
        treasureDes7_text.fontSize = 14;
        treasureDes7_2_text.fontSize = 14;

        // XP Descriptions
        xpDes1_text.text = "<color=green>+35% <color=white>XP";
        xpDes2_text.text = "<color=green>+125% <color=white>XP";
        xpDes3_text.text = "<color=green>+400% <color=white>XP";
        xpDes4_text.text = "<color=green>+900% <color=white>XP";
        xpDes5_text.text = "<color=green>+1300% <color=white>XP";
        xpDes6_text.text = "<color=green>+2500% <color=white>XP ";
        xpDes6_2_text.text = "모든 XP 드롭은 +1 스킬 포인트를 주기 위한 0.25%의 추가적인 확률을 갖고 있습니다";
        xpDes7_text.text = "<color=green>+4000% <color=white>XP ";
        xpDes7_2_text.text = "모든 XP 드롭은 +1 스킬 포인트를 주기 위한 0.75%의 추가적인 확률을 갖고 있습니다";
        xpDes8_text.text = "<color=green>+7500% <color=white>XP ";
        xpDes8_2_text.text = "모든 XP 드롭은 +1 스킬 포인트를 주기 위한 1%의 추가적인 확률을 갖고 있습니다";

        xpDes1_text.font = koreanFont;
        xpDes2_text.font = koreanFont;
        xpDes3_text.font = koreanFont;
        xpDes4_text.font = koreanFont;
        xpDes5_text.font = koreanFont;
        xpDes6_text.font = koreanFont;
        xpDes6_2_text.font = koreanFont;
        xpDes7_text.font = koreanFont;
        xpDes7_2_text.font = koreanFont;
        xpDes8_text.font = koreanFont;
        xpDes8_2_text.font = koreanFont;

        xpDes1_text.fontSize = 15;
        xpDes2_text.fontSize = 15;
        xpDes3_text.fontSize = 15;
        xpDes4_text.fontSize = 15;
        xpDes5_text.fontSize = 15;
        xpDes6_text.fontSize = 15;
        xpDes6_2_text.fontSize = 15;
        xpDes7_text.fontSize = 15;
        xpDes7_2_text.fontSize = 15;
        xpDes8_text.fontSize = 15;
        xpDes8_2_text.fontSize = 15;

        // Level Special Descriptions
        levelSpecialDes1_text.text = "아이템을 레벨업 시키는 것은 아이템을 더 강하게 합니다";
        levelSpecialDes2_text.text = "아이템을 레벨업 시키는 것은 아이템을 더 강하게 합니다";
        levelSpecialDes3_text.text = "아이템을 레벨업 시키는 것은 아이템을 더 강하게 합니다";
        levelSpecialDes4_text.text = "아이템을 레벨업 시키는 것은 아이템을 더 강하게 합니다";
        levelSpecialDes5_text.text = "아이템을 레벨업 시키는 것은 아이템을 더 강하게 합니다";

        levelSpecialDes1_text.font = koreanFont;
        levelSpecialDes2_text.font = koreanFont;
        levelSpecialDes3_text.font = koreanFont;
        levelSpecialDes4_text.font = koreanFont;
        levelSpecialDes5_text.font = koreanFont;

        levelSpecialDes1_text.fontSize = 14;
        levelSpecialDes2_text.fontSize = 14;
        levelSpecialDes3_text.fontSize = 14;
        levelSpecialDes4_text.fontSize = 14;
        levelSpecialDes5_text.fontSize = 14;

        // Stronger Special Descriptions
        strongerSpecialDes1_text.text = "모든 아이템은 강력하게 시작합니다";
        strongerSpecialDes2_text.text = "모든 아이템은 강력하게 시작합니다";
        strongerSpecialDes3_text.text = "포션은 이제 +1 회 스택될 수 있습니다";
        strongerSpecialDes4_text.text = "상자에서 드롭된 아이템은 가치가 두 배로 뛸 10%의 확률을 가지고 있습니다";
        strongerSpecialDes5_text.text = "포션은 이제 +1 회 스택될 수 있습니다";
        strongerSpecialDes5_2_text.text = "모든 아이템은 강력하게 시작합니다";
        strongerSpecialDes6_text.text = "이제 망치, 골든 터치, 세런디피티 두루마리와 욕망의 긴 장갑을 쌓을 수 있습니다";
        strongerSpecialDes7_text.text = "세런디피티 두루마리와 고대 유물은 더 당력한 버프를 줍니다";

        strongerSpecialDes1_text.font = koreanFont;
        strongerSpecialDes2_text.font = koreanFont;
        strongerSpecialDes3_text.font = koreanFont;
        strongerSpecialDes4_text.font = koreanFont;
        strongerSpecialDes5_text.font = koreanFont;
        strongerSpecialDes5_2_text.font = koreanFont;
        strongerSpecialDes6_text.font = koreanFont;
        strongerSpecialDes7_text.font = koreanFont;

        strongerSpecialDes1_text.fontSize = 14;
        strongerSpecialDes2_text.fontSize = 14;
        strongerSpecialDes3_text.fontSize = 14;
        strongerSpecialDes4_text.fontSize = 14;
        strongerSpecialDes5_text.fontSize = 14;
        strongerSpecialDes5_2_text.fontSize = 14;
        strongerSpecialDes6_text.fontSize = 14;
        strongerSpecialDes7_text.fontSize = 14;

        // Start With Descriptions
        startWithDes1_text.text = "각 프레스티지마다 시작할 아이템 1개를 선택하세요 (이미 한번 구매한 아이템만 선택할 수 있습니다)";
        startWithDes2_text.text = "각 프레스티지마다 시작할 아이템 2개를 선택하세요 ";
        startWithDes3_text.text = "각 프레스티지마다 시작할 아이템 3개를 선택하세요";
        startWithDes4_text.text = "각 프레스티지마다 시작할 아이템 5개를 선택하세요";

        startWithDes1_text.font = koreanFont;
        startWithDes2_text.font = koreanFont;
        startWithDes3_text.font = koreanFont;
        startWithDes4_text.font = koreanFont;

        startWithDes1_text.fontSize = 13;
        startWithDes2_text.fontSize = 13;
        startWithDes3_text.fontSize = 13;
        startWithDes4_text.fontSize = 13;

        // Reinforced Descriptions
        reinforcedDes1_text.text = "강화 상자에서 드롭된 골드 코인은 이제 17X 골드의 가치를 지니고 있습니다";
        reinforcedDes1_2_text.text = "<color=green>+0.1% <color=white>강화 상자 확률";
        reinforcedDes2_text.text = "강화 상자에서 드롭된 골드 코인은 이제 24X 골드의 가치를 지니고 있습니다";
        reinforcedDes2_2_text.text = "강화 상자는 이제 9X HP를 가지고 있습니다";
        reinforcedDes2_3_text.text = "강화 상자는 이제 6X XP를 줍니다";
        reinforcedDes3_text.text = "강화 상자에서 드롭된 골드 코인은 이제 33X 골드의 가치를 지니고 있습니다";
        reinforcedDes3_2_text.text = "<color=green>+0.3% <color=white>강화 상자 확률";
        reinforcedDes4_text.text = "강화 상자에서 드롭된 골드 코인은 이제 47X 골드의 가치를 지니고 있습니다";
        reinforcedDes4_2_text.text = "<color=green>+0.5% <color=white>강화 상자 확률";
        reinforcedDes4_3_text.text = "강화 상자는 이제 8X HP를 가지고 있습니다";
        reinforcedDes4_4_text.text = "강화 상자는 이제 11X XP를 줍니다";
        reinforcedDes5_text.text = "강화 상자에서 드롭된 골드 코인은 이제 85X 골드의 가치를 지니고 있습니다";
        reinforcedDes5_2_text.text = "<color=green>+1% <color=white>강화 상자 확률";

        reinforcedDes1_text.font = koreanFont;
        reinforcedDes1_2_text.font = koreanFont;
        reinforcedDes2_text.font = koreanFont;
        reinforcedDes2_2_text.font = koreanFont;
        reinforcedDes2_3_text.font = koreanFont;
        reinforcedDes3_text.font = koreanFont;
        reinforcedDes3_2_text.font = koreanFont;
        reinforcedDes4_text.font = koreanFont;
        reinforcedDes4_2_text.font = koreanFont;
        reinforcedDes4_3_text.font = koreanFont;
        reinforcedDes4_4_text.font = koreanFont;
        reinforcedDes5_text.font = koreanFont;
        reinforcedDes5_2_text.font = koreanFont;

        reinforcedDes1_text.fontSize = 13;
        reinforcedDes1_2_text.fontSize = 13;
        reinforcedDes2_text.fontSize = 13;
        reinforcedDes2_2_text.fontSize = 13;
        reinforcedDes2_3_text.fontSize = 13;
        reinforcedDes3_text.fontSize = 13;
        reinforcedDes3_2_text.fontSize = 13;
        reinforcedDes4_text.fontSize = 13;
        reinforcedDes4_2_text.fontSize = 13;
        reinforcedDes4_3_text.fontSize = 13;
        reinforcedDes4_4_text.fontSize = 13;
        reinforcedDes5_text.fontSize = 13;
        reinforcedDes5_2_text.fontSize = 13;

        // More Loot Descriptions
        moreLootDes1_text.text = "상자 10개를 오픈할 때마다 1 골드 코인을 추가로 드롭합니다 ";
        moreLootDes2_text.text = "상자 19개를 오픈할 때마다 5X 골드 코인을 드롭하고 3X XP를 줍니다";
        moreLootDes3_text.text = "상자 18개를 오픈할 때마다 2-4 골드 코인을 드롭합니다. 이 골드 코인은 모두 5X 나 10X 골드 코인으로 구성되어 있습니다. 또한, 5X XP를 줍니다";
        moreLootDes4_text.text = "상자 30개를 오픈할 때마다 3 골드 코인을 드롭합니다. 이 골드 코인은 모두 25X 골드 코인입니다. 또한, 2-5개의 보물들을 드롭합니다";
        moreLootDes5_text.text = "상자를 오픈할 때마다 5X 골드 코인을 드롭하고 10X 골드 코인을 드롭할 확률 5%와 25X 골드 코인을 드롭할 확률 2.5%를 갖고 있습니다. 또한, 2X XP를 드롭합니다";

        moreLootDes1_text.font = koreanFont;
        moreLootDes2_text.font = koreanFont;
        moreLootDes3_text.font = koreanFont;
        moreLootDes4_text.font = koreanFont;
        moreLootDes5_text.font = koreanFont;

        moreLootDes1_text.fontSize = 13;
        moreLootDes2_text.fontSize = 13;
        moreLootDes3_text.fontSize = 13;
        moreLootDes4_text.fontSize = 13;
        moreLootDes5_text.fontSize = 13;

        // New Chests Descriptions
        newChestsDes1_text.text = "마법에 걸린 황금 상자는 나타날 확률이 0.2%입니다";
        newChestsDes1_2_text.text = "마법에 걸린 황금 상자는 30X HP를 가지고 있습니다. 20개의 보물들이 드롭될 것입니다. 자물쇠 따개와 열쇠는 상자의 HP 중 33%만을 제거합니다.";
        newChestsDes1_3_text.text = "이 상자가 나타날 경우에 이 상자에 대한 정보를 설정에서 더 읽어보세요";
        newChestsDes2_text.text = "보스 상자는 나타날 확률이 0.1%입니다";
        newChestsDes2_2_text.text = "보스 상자는 100X HP를 갖고 있습니다. \n보스 상자는 25 골드 코인을 드롭하는데, 이는 모두 10X와 25X 골드 코인들로 구성되어 있습니다.";
        newChestsDes2_3_text.text = "이 상자가 나타날 경우에 이 상자에 대한 정보를 설정에서 더 읽어보세요";
        newChestsDes3_text.text = "보스 상자는 나타날 확률 +0.05%를 갖고 있습니다";
        newChestsDes3_2_text.text = "마법에 걸린 황금 상자는 나타날 확률 +0.1%를 갖고 있습니다";
        newChestsDes4_text.text = "보스 상자는 나타날 확률 +0.1%를 갖고 있습니다";
        newChestsDes4_2_text.text = "마법에 걸린 황금 상자는 나타날 확률 +0.15%를 갖고 있습니다";
        newChestsDes4_3_text.text = "마법에 걸린 황금 상자는 25개의 보물들을 드롭합니다\n보스 상자는 30 골드 코인을 드롭합니다";
        newChestsDes5_text.text = "마법에 걸린 황금 상자는 30개의 보물을 드롭합니다 \n보스 상자는 35 골드 코인을 드롭하는데 이는 모두 25X 골드 코인으로 구성되어 있습니다";
        newChestsDes5_2_text.text = "마법에 걸린 황금 상자는 나타날 확률 +0.2%를 갖고 있습니다";
        newChestsDes5_3_text.text = "보스 상자는 나타날 확률 +0.15%를 갖고 있습니다";
        newChestsDes6_text.text = "보스 상자는 나타날 확률 +0.4%를 갖고 있습니다";
        newChestsDes6_2_text.text = "마법에 걸린 황금 상자는 나타날 확률 +0.75%를 갖고 있습니다";
        newChestsDes6_3_text.text = "보스 상자는 20X XP를 드롭합니다. 마법에 걸린 황금 상자는 12X XP를 드롭합니다. 두 상자 모두 레어 보물을 드롭할 약간 높은 확률을 얻습니다.";

        newChestsDes1_text.font = koreanFont;
        newChestsDes1_2_text.font = koreanFont;
        newChestsDes1_3_text.font = koreanFont;
        newChestsDes2_text.font = koreanFont;
        newChestsDes2_2_text.font = koreanFont;
        newChestsDes2_3_text.font = koreanFont;
        newChestsDes3_text.font = koreanFont;
        newChestsDes3_2_text.font = koreanFont;
        newChestsDes4_text.font = koreanFont;
        newChestsDes4_2_text.font = koreanFont;
        newChestsDes4_3_text.font = koreanFont;
        newChestsDes5_text.font = koreanFont;
        newChestsDes5_2_text.font = koreanFont;
        newChestsDes5_3_text.font = koreanFont;
        newChestsDes6_text.font = koreanFont;
        newChestsDes6_2_text.font = koreanFont;
        newChestsDes6_3_text.font = koreanFont;

        newChestsDes1_text.fontSize = 12;
        newChestsDes1_2_text.fontSize = 12;
        newChestsDes1_3_text.fontSize = 9.5f;
        newChestsDes2_text.fontSize = 13;
        newChestsDes2_2_text.fontSize = 13;
        newChestsDes2_3_text.fontSize = 9.5f;
        newChestsDes3_text.fontSize = 12;
        newChestsDes3_2_text.fontSize = 12;
        newChestsDes4_text.fontSize = 12;
        newChestsDes4_2_text.fontSize = 12;
        newChestsDes4_3_text.fontSize = 12;
        newChestsDes5_text.fontSize = 12;
        newChestsDes5_2_text.fontSize = 12;
        newChestsDes5_3_text.fontSize = 12;
        newChestsDes6_text.fontSize = 12;
        newChestsDes6_2_text.fontSize = 12;
        newChestsDes6_3_text.fontSize = 12;

        #endregion

        #region Other
        maxPurchaseText_text.text = "결제 최대치에 도달함"; maxPurchaseText_text.font = koreanFont; maxPurchaseText_text.fontSize = 32;
        youCanAlsoHoldDown_text.text = "최대한으로 구매하기 위해서 또한, 좌측 컨트롤을 누르고 계실 수 있습니다"; youCanAlsoHoldDown_text.font = koreanFont; youCanAlsoHoldDown_text.fontSize = 11;

        X1_text1.text = "X1"; X1_text1.font = koreanFont; X1_text1.fontSize = 35;
        X1_text2.text = "X1"; X1_text2.font = koreanFont; X1_text2.fontSize = 32;
        X1_text3.text = "X1"; X1_text3.font = koreanFont; X1_text3.fontSize = 32;
        MAX_text1.text = "최대 "; MAX_text1.font = koreanFont; MAX_text1.fontSize = 35;
        MAX_text2.text = "최대 "; MAX_text2.font = koreanFont; MAX_text2.fontSize = 32;
        MAX_text3.text = "최대 "; MAX_text3.font = koreanFont; MAX_text3.fontSize = 32;

        activeDamageBar_text.text = "액티브 데미지"; activeDamageBar_text.font = koreanFont; activeDamageBar_text.fontSize = 36;
        activeDamageACTIVE_text.text = "액티브 데미지"; activeDamageACTIVE_text.font = koreanFont; activeDamageACTIVE_text.fontSize = 16;
        activeDamageLEVEL_text.text = "레벨"; activeDamageLEVEL_text.font = koreanFont; activeDamageLEVEL_text.fontSize = 27;

        passiveDamageBar_text.text = "패시브 데미지"; passiveDamageBar_text.font = koreanFont; passiveDamageBar_text.fontSize = 36;
        passivePASSIVE_Text.text = "패시브 데미지"; passivePASSIVE_Text.font = koreanFont; passivePASSIVE_Text.fontSize = 16;
        passiveLEVEL_text.text = "레벨"; passiveLEVEL_text.font = koreanFont; passiveLEVEL_text.fontSize = 27;

        welcome.text = "환영합니다!"; welcome.font = koreanFont; welcome.fontSize = 21;
        beforeWeCanStartPlaying.text = "플레이하기 전에, 노획이 알아서 진행되기 전에 화면 내에서 얼마나 많은 노획을 하고 싶으신가요? "; beforeWeCanStartPlaying.font = koreanFont; beforeWeCanStartPlaying.fontSize = 11.4f;
        changeAnyTime.text = "이 설정은 언제든 변경하실 수 있습니다"; changeAnyTime.font = koreanFont; changeAnyTime.fontSize = 10;
        playGame.text = "플레이하기  "; playGame.font = koreanFont; playGame.fontSize = 50;

        welcomeBack.text = "돌아오신 것을 환영합니다"; welcomeBack.font = koreanFont; welcomeBack.fontSize = 65;
        if(PlaceMobileButtons.isMobile == true) { welcomeBack.fontSize = 28; }
        thisHappendWhileGone.text = "게임에서 나가시고 나서 이런 일이 발생했습니다…"; thisHappendWhileGone.font = koreanFont; thisHappendWhileGone.fontSize = 27;
        cool.text = "멋지네요!"; cool.font = koreanFont; cool.fontSize = 42;
        timeGone.text = "지나간 시간:"; timeGone.font = koreanFont; timeGone.fontSize = 55;

        #endregion

        //Text That Changes
        #region info settings
        enchantedGoldenChestHealth = "-마법에 걸린 황금 상자는 " + UpdateGame.enchantedGoldenChestHealth + "를 가지고 있습니다";
        enchantedGoldenChestTreasureDrops = "-" + UpdateGame.enchantedGoldenChestTreasureDrops + "개의 보물 드롭";
        enchantedGoldenChestXPDrop = "-+" + UpdateGame.enchantedGoldenChestXPDrops + "X XP 드롭";

        bossChestHealth = "-보스 상자는" + UpdateGame.bossChestHealth + "HP를 갖고 있습니다";
        bossChestGoldValue = "-골드 코인 가치 " + UpdateGame.bossChestGoldValue + "X 골드";
        bossChestGoldCoins = "-" + UpdateGame.bossChestGoldCoinsDrops + " 25 골드 코인이 드롭될 것입니다. 코인은 모두 10X와 25X 골드 코인입니다";
        bossChestGoldCoins2 = "-" + UpdateGame.bossChestGoldCoinsDrops + " 25 골드 코인이 드롭될 것입니다. 코인은 모두 25X 골드 코인입니다";
        bossChestXP = "+" + UpdateGame.bossChestXPDrops + "X XP 드롭";

        reinforcedHealth = "-강화 상자는 " + UpdateGame.reinforcedChestHealth + "HP를 가지고 있습니다";
        reinforcedGold = "-드롭된 골드 코인은<color=yellow>" + UpdateGame.reinforcedChestGoldIncrease + "X 골드를 줍니다";
        reinforcedXP = "+" + UpdateGame.reinforcedXPIncrease + "X XP 드롭";

        reinforcedInfo = "강화 상자들은" + UpdateGame.reinforcedChestHealth + "HP를 갖고 있고 " + UpdateGame.reinforcedChestGoldIncrease + "X 골드, 그리고 " + UpdateGame.reinforcedXPIncrease + "X XP를 줍니다.";

        enchantedChestInfo = (100 - UpdateGame.enchantedGoldenChestChance).ToString("F2") + "% 의 스폰 확률.\n마법에 걸린 황금 상자는" + UpdateGame.enchantedGoldenChestHealth + "X HP를 갖고 있고 보물" + UpdateGame.enchantedGoldenChestTreasureDrops + "개와" + UpdateGame.enchantedGoldenChestXPDrops + "X XP를 드롭합니다\n자물쇠 따개나 열쇠를 사용한다고 해도 상자의 HP 중 33%만 제거하게 됩니다.\n마법에 걸린 황금 상자는 또한 레어 보물을 드롭할 조금 더 높은 확률을 갖고 있습니다";

        bossChestInfo1 = (UpdateGame.bossChestChance).ToString("F2") + "% 의 스폰 확률.\n보스 상자는" + UpdateGame.bossChestHealth + "X HP를 갖고 있습니다. 골드 코인은" + UpdateGame.bossChestGoldValue + "X의 가치를 가지고 있습니다. 보스 상자는" + UpdateGame.bossChestGoldCoinsDrops + "골드 코인을 드롭하는데, 이는 모두 10X 혹은 25X 골드 코인들로 구성되어 있습니다. (보스 상자에서 나온 골드 코인 가치 = (상자에 있는 현재 골드 코인 가치 * 5) * 10 혹은 25). 또한 " + UpdateGame.bossChestXPDrops + "X XP를 줍니다\n자물쇠 따개나 열쇠를 사용한다고 해도 상자의 HP 중 25%만 제거하게 됩니다.\n보스 상자는 또한 레어 보물을 드롭할 조금 더 높은 확률을 갖고 있습니다. ";

        bossChestInfo2 = (UpdateGame.bossChestChance).ToString("F2") + "% 의 스폰 확률.\n보스 상자는" + UpdateGame.bossChestHealth + "X HP를 갖고 있습니다. 골드 코인은" + UpdateGame.bossChestGoldValue + "X의 가치를 가지고 있습니다. 보스 상자는" + UpdateGame.bossChestGoldCoinsDrops + "골드 코인을 드롭하는데, 이는 모두 25X 골드 코인들로 구성되어 있습니다. (보스 상자에서 나온 골드 코인 가치 = (상자에 있는 현재 골드 코인 가치 * 5) * 25). 또한 " + UpdateGame.bossChestXPDrops + "X XP를 줍니다\n자물쇠 따개나 열쇠를 사용한다고 해도 상자의 HP 중 25%만 제거하게 됩니다.\n보스 상자는 또한 레어 보물을 드롭할 조금 더 높은 확률을 갖고 있습니다. ";

        purchaseTheEnchanted = "정보를 보기 위해서 마법에 걸린 황금 상자에 대한 프레스티지 업그레이드를 구매하세요";
        purchaseTheBossChest = "정보를 보기 위해서 보스 상자 프레스티지 업그레이드를 구매하세요";

        reinforcedChestsDescription_text2.font = koreanFont; reinforcedChestsDescription_text2.fontSize = 12;

        enchantedGoldenChestsDescription_text.font = koreanFont; enchantedGoldenChestsDescription_text.fontSize = 10;

        bossChestsDescription_text.font = koreanFont; bossChestsDescription_text.fontSize = 9;
        #endregion

        #region stats
        goldCoinsDropped = "드롭된 골드 코인: ";
        totalGoldReceived = "얻은 총 골드: ";
        totalBarrelGold = "수집된 골드 배럴: ";
        treasuresDropped = "드롭된 보물: ";
        commonTreasures = "커먼 보물: ";
        uncommonTreasures = "언커먼 보물: ";
        rareTreasures = "레어 보물: ";
        veryRareTreasures = "매우 레어한 보물: ";
        extremelyRareTreasures = "극적으로 레어한 보물: ";
        legendaryTreasures = "레전드 보물: ";
        ultraTreasures = "울트라 보물: ";
        mythicTreasures = "신화적 보물: ";
        eternalTreasures = "이터널 보물: ";
        treasuresDoubled = "가치가 두 배로 뛴 보물: ";
        chestsOpened = "오픈된 상자: ";
        reinforcedChestsOpened = "오픈된 강화 상자: ";
        enchantedGoldenChestsOpened = "오픈된 마법에 걸린 황금 상자: ";
        bossChestsOpened = "오픈된 보스 상자: ";
        chestClicks = "클릭된 상자: ";
        autoClicks = "자동 클릭: ";
        criticalHits = "크리티컬 히트: ";
        activeDamage = "액티브 데미지: ";
        passiveDamage = "패시브 데미지: ";
        critChance = "크리티컬 확률: ";
        critDamage = "크리티컬 데미지:: ";
        cursorsLeveledUp = "레벨업된 커서: ";
        coinsSpawnedFromClicks = "클릭으로부터 스폰된 코인: ";
        treasuresSpawnedFromClicks = "클릭으로부터 스폰된 보물: ";
        itemsUsed = "사용된 아이템: ";
        itemsDropped = "드롭된 아이템: ";
        itemsPurchased = "결제된 아이템: ";
        itemsLeveledUp = "레벨업된 아이템: ";
        prestigeCount = "프레스티지 카운트: ";
        prestigeUpgradesPurchased = "결제된 프레스티지 업그레이드: ";
        skillPointsReceived = "얻은 스킬 포인트: ";
        goldIncrease = "골드 증가분: ";
        xpIncrease = "XP 증가분: ";
        activeDamageIncrease = "액티브 데미지 증가분: ";
        passiveDamageIncrease = "패시브 데미지 증가분: ";
        critChanceIncrease = "크리티컬 확률 증가분: ";
        critDamageIncrease = "크리티컬 데미지 증가분: ";
        treasureChanceIncrease = "보물 확률 증가분: ";
        goldCoins5xDropped = "드롭된 5X 골드 코인:  ";
        goldCoins10xDropped = "드롭된 10X 골드 코인: ";
        goldCoins25xDropped = "드롭된 25X 골드 코인: ";
        goldCoins100xDropped = "드롭된 100X 골드 코인: ";

        goldCoinsDropped_text.font = koreanFont; goldCoinsDropped_text.fontSize = 27;
        totalGoldReceived_text.font = koreanFont; totalGoldReceived_text.fontSize = 27;
        totalBarrelGold_text.font = koreanFont; totalBarrelGold_text.fontSize = 27;
        treasuresDropped_text.font = koreanFont; treasuresDropped_text.fontSize = 27;
        commonTreasures_text.font = koreanFont; commonTreasures_text.fontSize = 27;
        uncommonTreasures_text.font = koreanFont; uncommonTreasures_text.fontSize = 27;
        rareTreasures_text.font = koreanFont; rareTreasures_text.fontSize = 27;
        veryRareTreasures_text.font = koreanFont; veryRareTreasures_text.fontSize = 27;
        extremelyRareTreasures_text.font = koreanFont; extremelyRareTreasures_text.fontSize = 27;
        legendaryTreasures_text.font = koreanFont; legendaryTreasures_text.fontSize = 27;
        ultraTreasures_text.font = koreanFont; ultraTreasures_text.fontSize = 27;
        mythicTreasures_text.font = koreanFont; mythicTreasures_text.fontSize = 27;
        eternalTreasures_text.font = koreanFont; eternalTreasures_text.fontSize = 27;
        treasuresDoubled_text.font = koreanFont; treasuresDoubled_text.fontSize = 27;
        chestsOpened_text.font = koreanFont; chestsOpened_text.fontSize = 27;
        reinforcedChestsOpened_text.font = koreanFont; reinforcedChestsOpened_text.fontSize = 25;
        enchantedGoldenChestsOpened_text.font = koreanFont; enchantedGoldenChestsOpened_text.fontSize = 27;
        bossChestsOpened_text.font = koreanFont; bossChestsOpened_text.fontSize = 27;
        chestClicks_text.font = koreanFont; chestClicks_text.fontSize = 27;
        autoClicks_text.font = koreanFont; autoClicks_text.fontSize = 27;
        criticalHits_text.font = koreanFont; criticalHits_text.fontSize = 27;
        activeDamage_text.font = koreanFont; activeDamage_text.fontSize = 27;
        passiveDamage_text.font = koreanFont; passiveDamage_text.fontSize = 27;
        critChance_text.font = koreanFont; critChance_text.fontSize = 27;
        critDamage_text.font = koreanFont; critDamage_text.fontSize = 27;
        cursorsLeveledUp_text.font = koreanFont; cursorsLeveledUp_text.fontSize = 27;
        coinsSpawnedFromClicks_text.font = koreanFont; coinsSpawnedFromClicks_text.fontSize = 27;
        treasuresSpawnedFromClicks_text.font = koreanFont; treasuresSpawnedFromClicks_text.fontSize = 24;
        itemsUsed_text.font = koreanFont; itemsUsed_text.fontSize = 27;
        itemsDropped_text.font = koreanFont; itemsDropped_text.fontSize = 27;
        itemsPurchased_text.font = koreanFont; itemsPurchased_text.fontSize = 27;
        itemsLeveledUp_text.font = koreanFont; itemsLeveledUp_text.fontSize = 27;
        prestigeCount_text.font = koreanFont; prestigeCount_text.fontSize = 27;
        prestigeUpgradesPurchased_text.font = koreanFont; prestigeUpgradesPurchased_text.fontSize = 27;
        skillPointsReceived_text.font = koreanFont; skillPointsReceived_text.fontSize = 27;
        goldIncrease_text.font = koreanFont; goldIncrease_text.fontSize = 27;
        xpIncrease_text.font = koreanFont; xpIncrease_text.fontSize = 27;
        activeDamageIncrease_text.font = koreanFont; activeDamageIncrease_text.fontSize = 27;
        passiveDamageIncrease_text.font = koreanFont; passiveDamageIncrease_text.fontSize = 27;
        critChanceIncrease_text.font = koreanFont; critChanceIncrease_text.fontSize = 27;
        critDamageIncrease_text.font = koreanFont; critDamageIncrease_text.fontSize = 27;
        treasureChanceIncrease_text.font = koreanFont; treasureChanceIncrease_text.fontSize = 27;
        goldCoins5xDropped_text.font = koreanFont; goldCoins5xDropped_text.fontSize = 27;
        goldCoins10xDropped_text.font = koreanFont; goldCoins10xDropped_text.fontSize = 27;
        goldCoins25xDropped_text.font = koreanFont; goldCoins25xDropped_text.fontSize = 27;
        goldCoins100xDropped_text.font = koreanFont; goldCoins100xDropped_text.fontSize = 27;
        #endregion

        #region cursors
        NOdot = "";

        upgrade = "업그레이드";
        upgradeMax = "업그레이드 (최대)";

        lvl = "레벨 ";

        price = "가격: ";
        damage = "데미지: ";

        equipped = "착용됨";
        unequpped = "착용되지 않음";

        equippedNONE = "착용됨 = ";

        cursor1Equipped = "착용됨 = <color=green>젠틀 탭";
        cursor2Equipped = "착용됨 = <color=green>안정된 손바닥";
        cursor3Equipped = "착용됨 = <color=green>강풍 포스";
        cursor4Equipped = "착용됨 = <color=green>레이디언트 터치";
        cursor5Equipped = "착용됨 = <color=green>에너지 파동";
        cursor6Equipped = "착용됨 = <color=green>팬텀 손바닥";
        cursor7Equipped = "착용됨 = <color=green>강철 스트라이크";
        cursor8Equipped = "착용됨 = <color=green>치명적인 터치";
        cursor9Equipped = "착용됨 = <color=green>정밀한 포인트";
        cursor10Equipped = "착용됨 = <color=green>소용돌이 탭";
        cursor11Equipped = "착용됨 = <color=green>저주받은 발톱";
        cursor12Equipped = "착용됨 = <color=green>스나이퍼 클릭";
        cursor13Equipped = "착용됨 = <color=green>그림자 파동";
        cursor14Equipped = "착용됨 = <color=green>심각한 충돌";
        cursor15Equipped = "착용됨 = <color=green>난타";
        cursor16Equipped = "착용됨 = <color=green>거룩한 터치";
        cursor17Equipped = "착용됨 = <color=green>신비한 클릭";
        cursor18Equipped = "착용됨 = <color=green>이터널 터치";
        cursor19Equipped = "착용됨 = <color=green>파멸의 터치";
        cursor20Equipped = "착용됨 = <color=green>태양의 솔질";
        cursor21Equipped = "착용됨 = <color=green>지옥 주먹";

        for (int i = 0; i < 21; i++)
        {
            lvlsHover_text[i].font = koreanFont; lvlsHover_text[i].fontSize = 26;

            equippedHover_text[i].font = koreanFont; equippedHover_text[i].fontSize = 28;
            level_text[i].font = koreanFont; level_text[i].fontSize = 39;
        }

        equippedEquals_text.font = koreanFont; equippedEquals_text.fontSize = 23f;
        dpsTopBar_text.font = koreanFont; dpsTopBar_text.fontSize = 29f;
        clickDamageTopBar_text.font = koreanFont; clickDamageTopBar_text.fontSize = 29f;
        critChanceTopBar_text.font = koreanFont; critChanceTopBar_text.fontSize = 29f;
        critDamageTopBar_text.font = koreanFont; critDamageTopBar_text.fontSize = 29f;

        noNotUnlcoked_text.font = koreanFont; noNotUnlcoked_text.fontSize = 70f;

        cursor1ActiveDamage_Text.font = koreanFont; cursor1ActiveDamage_Text.fontSize = 20f;

        cursor2PassiveDamage_Text.font = koreanFont; cursor2PassiveDamage_Text.fontSize = 20f;

        cursor3CritChance_Text.font = koreanFont; cursor3CritChance_Text.fontSize = 20f;
        cursor3CritDamage_Text.font = koreanFont; cursor3CritDamage_Text.fontSize = 20f;

        cursor4ActiveDamage_Text.font = koreanFont; cursor4ActiveDamage_Text.fontSize = 20f;
        cursor4PassiveDamage_Text.font = koreanFont; cursor4PassiveDamage_Text.fontSize = 20f;

        cursor5ActiveDamage_Text.font = koreanFont; cursor5ActiveDamage_Text.fontSize = 20f;
        cursor5CritChance_Text.font = koreanFont; cursor5CritChance_Text.fontSize = 20f;
        cursor5CritDamage_Text.font = koreanFont; cursor5CritDamage_Text.fontSize = 20f;

        cursor6ActiveDamage_Text.font = koreanFont; cursor6ActiveDamage_Text.fontSize = 20f;
        cursor6PassiveDamage_Text.font = koreanFont; cursor6PassiveDamage_Text.fontSize = 20f;
        cursor6CritChance_Text.font = koreanFont; cursor6CritChance_Text.fontSize = 20f;
        cursor6CritDamage_Text.font = koreanFont; cursor6CritDamage_Text.fontSize = 20f;

        cursor7ActiveDamage_Text.font = koreanFont; cursor7ActiveDamage_Text.fontSize = 20f;
        cursor7CritChance_Text.font = koreanFont; cursor7CritChance_Text.fontSize = 20f;
        cursor7CritDamage_Text.font = koreanFont; cursor7CritDamage_Text.fontSize = 20f;

        cursor8ActiveDamage_Text.font = koreanFont; cursor8ActiveDamage_Text.fontSize = 20f;
        cursor8PassiveDamage_Text.font = koreanFont; cursor8PassiveDamage_Text.fontSize = 20f;
        cursor8CritChance_Text.font = koreanFont; cursor8CritChance_Text.fontSize = 20f;
        cursor8CritDamage_Text.font = koreanFont; cursor8CritDamage_Text.fontSize = 20f;

        cursor9ActiveDamage_Text.font = koreanFont; cursor9ActiveDamage_Text.fontSize = 20f;
        cursor9PassiveDamage_Text.font = koreanFont; cursor9PassiveDamage_Text.fontSize = 20f;

        cursor10PassiveDamage_Text.font = koreanFont; cursor10PassiveDamage_Text.fontSize = 20f;

        cursor11ActiveDamage_Text.font = koreanFont; cursor11ActiveDamage_Text.fontSize = 20f;
        cursor11CritChance_Text.font = koreanFont; cursor11CritChance_Text.fontSize = 20f;
        cursor11CritDamage_Text.font = koreanFont; cursor11CritDamage_Text.fontSize = 20f;

        cursor12ActiveDamage_Text.font = koreanFont; cursor12ActiveDamage_Text.fontSize = 20f;
        cursor12PassiveDamage_Text.font = koreanFont; cursor12PassiveDamage_Text.fontSize = 20f;
        cursor12CritChance_Text.font = koreanFont; cursor12CritChance_Text.fontSize = 20f;
        cursor12CritDamage_Text.font = koreanFont; cursor12CritDamage_Text.fontSize = 20f;

        cursor13ActiveDamage_Text.font = koreanFont; cursor13ActiveDamage_Text.fontSize = 20f;
        cursor13PassiveDamage_Text.font = koreanFont; cursor13PassiveDamage_Text.fontSize = 20f;
        cursor13CritChance_Text.font = koreanFont; cursor13CritChance_Text.fontSize = 20f;
        cursor13CritDamage_Text.font = koreanFont; cursor13CritDamage_Text.fontSize = 20f;

        cursor14ActiveDamage_Text.font = koreanFont; cursor14ActiveDamage_Text.fontSize = 20f;
        cursor14PassiveDamage_Text.font = koreanFont; cursor14PassiveDamage_Text.fontSize = 20f;
        cursor14CritChance_Text.font = koreanFont; cursor14CritChance_Text.fontSize = 20f;
        cursor14CritDamage_Text.font = koreanFont; cursor14CritDamage_Text.fontSize = 20f;

        cursor15ActiveDamage_Text.font = koreanFont; cursor15ActiveDamage_Text.fontSize = 20f;
        cursor15PassiveDamage_Text.font = koreanFont; cursor15PassiveDamage_Text.fontSize = 20f;
        cursor15CritChance_Text.font = koreanFont; cursor15CritChance_Text.fontSize = 20f;
        cursor15CritDamage_Text.font = koreanFont; cursor15CritDamage_Text.fontSize = 20f;

        cursor16ActiveDamage_Text.font = koreanFont; cursor16ActiveDamage_Text.fontSize = 20f;
        cursor16PassiveDamage_Text.font = koreanFont; cursor16PassiveDamage_Text.fontSize = 20f;
        cursor16CritChance_Text.font = koreanFont; cursor16CritChance_Text.fontSize = 20f;
        cursor16CritDamage_Text.font = koreanFont; cursor16CritDamage_Text.fontSize = 20f;

        cursor17ActiveDamage_Text.font = koreanFont; cursor17ActiveDamage_Text.fontSize = 20f;
        cursor17PassiveDamage_Text.font = koreanFont; cursor17PassiveDamage_Text.fontSize = 20f;
        cursor17CritChance_Text.font = koreanFont; cursor17CritChance_Text.fontSize = 20f;
        cursor17CritDamage_Text.font = koreanFont; cursor17CritDamage_Text.fontSize = 20f;

        cursor18ActiveDamage_Text.font = koreanFont; cursor18ActiveDamage_Text.fontSize = 20f;
        cursor18PassiveDamage_Text.font = koreanFont; cursor18PassiveDamage_Text.fontSize = 20f;
        cursor18CritChance_Text.font = koreanFont; cursor18CritChance_Text.fontSize = 20f;
        cursor18CritDamage_Text.font = koreanFont; cursor18CritDamage_Text.fontSize = 20f;

        cursor19ActiveDamage_Text.font = koreanFont; cursor19ActiveDamage_Text.fontSize = 20f;
        cursor19PassiveDamage_Text.font = koreanFont; cursor19PassiveDamage_Text.fontSize = 20f;
        cursor19CritChance_Text.font = koreanFont; cursor19CritChance_Text.fontSize = 20f;
        cursor19CritDamage_Text.font = koreanFont; cursor19CritDamage_Text.fontSize = 20f;

        cursor20ActiveDamage_Text.font = koreanFont; cursor20ActiveDamage_Text.fontSize = 20f;
        cursor20PassiveDamage_Text.font = koreanFont; cursor20PassiveDamage_Text.fontSize = 20f;
        cursor20CritChance_Text.font = koreanFont; cursor20CritChance_Text.fontSize = 20f;
        cursor20CritDamage_Text.font = koreanFont; cursor20CritDamage_Text.fontSize = 20f;

        cursor21ActiveDamage_Text.font = koreanFont; cursor21ActiveDamage_Text.fontSize = 20f;
        cursor21PassiveDamage_Text.font = koreanFont; cursor21PassiveDamage_Text.fontSize = 20f;
        cursor21CritChance_Text.font = koreanFont; cursor21CritChance_Text.fontSize = 20f;
        cursor21CritDamage_Text.font = koreanFont; cursor21CritDamage_Text.fontSize = 20f;
        #endregion

        #region items and shop

        MAX = "최대";
        owned = "소유 중: ";
        treasuresExplinationMark = "보물!";
        skillPointsExplinatinMark = " 스킬 포인트!";

        stack = "스택 X";

        forTheNext = "다음 ";
        seconds = " 초간 ";

        for (int i = 0; i < 17; i++)
        {
            itemsPrice_text[i].font = koreanFont; itemsPrice_text[i].fontSize = 20;
            itemsLvlHover_text[i].font = koreanFont; itemsLvlHover_text[i].fontSize = 26;
            itemsPriceHover_text[i].font = koreanFont; itemsPriceHover_text[i].fontSize = 17;
        }

        for (int i = 0; i < 14; i++)
        {
            owned_text[i].font = koreanFont; owned_text[i].fontSize = 22;
        }

        stack_text1.font = koreanFont; stack_text1.fontSize = 25f;
        stack_text2.font = koreanFont; stack_text2.fontSize = 25f;
        stack_text3.font = koreanFont; stack_text3.fontSize = 25f;
        stack_text4.font = koreanFont; stack_text4.fontSize = 25f;
        stack_text5.font = koreanFont; stack_text5.fontSize = 25f;
        stack_text6.font = koreanFont; stack_text6.fontSize = 25f;
        stack_text7.font = koreanFont; stack_text7.fontSize = 25f;
        stack_text8.font = koreanFont; stack_text8.fontSize = 25f;

        lockPickDropChance_text.font = koreanFont; lockPickDropChance_text.fontSize = 19f;
        lockPickInfo.font = koreanFont; lockPickInfo.fontSize = 23f;
        hammerInfo_text.font = koreanFont; hammerInfo_text.fontSize = 21f;
        hammerDropChance_text.font = koreanFont; hammerDropChance_text.fontSize = 19f;
        lootPotionInfo_text.font = koreanFont; lootPotionInfo_text.fontSize = 20f;
        lootPotionDropChance_text.font = koreanFont; lootPotionDropChance_text.fontSize = 19f;
        damagePotionInfo_text.font = koreanFont; damagePotionInfo_text.fontSize = 21f;
        damagePotionDropChance_text.font = koreanFont; damagePotionDropChance_text.fontSize = 19f;
        xpPotionInfo_text.font = koreanFont; xpPotionInfo_text.fontSize = 21f;
        xpPotionDropChance_text.font = koreanFont; xpPotionDropChance_text.fontSize = 19f;
        goldenTouchInfo_text.font = koreanFont; goldenTouchInfo_text.fontSize = 21f;
        goldenTouchDropChance_text.font = koreanFont; goldenTouchDropChance_text.fontSize = 19f;
        miniChestInfo_text.font = koreanFont; miniChestInfo_text.fontSize = 21f;
        keyInfo_text.font = koreanFont; keyInfo_text.fontSize = 17f;
        keyDropChance_text.font = koreanFont; keyDropChance_text.fontSize = 19f;
        treasureBagInfo_text.font = koreanFont; treasureBagInfo_text.fontSize = 19f;
        serendipityScrollInfo_text.font = koreanFont; serendipityScrollInfo_text.fontSize = 19f;
        serendipityScollDropChance_text.font = koreanFont; serendipityScollDropChance_text.fontSize = 19f;
        gauntletOfGreenInfo_text.font = koreanFont; gauntletOfGreenInfo_text.fontSize = 18f;
        gauntletOfGreenDropChance_text.font = koreanFont; gauntletOfGreenDropChance_text.fontSize = 19f;
        magicalElixirInfo.font = koreanFont; magicalElixirInfo.fontSize = 18f;
        magicalElixirDropChance_text.font = koreanFont; magicalElixirDropChance_text.fontSize = 19f;
        ancientRelicDropChance_text.font = koreanFont; ancientRelicDropChance_text.fontSize = 19f;
        enchantedHammerInfo_text.font = koreanFont; enchantedHammerInfo_text.fontSize = 18f;
        enchantedHammerDropChance_text.font = koreanFont; enchantedHammerDropChance_text.fontSize = 19f;
        treasurePotionInfo_text.font = koreanFont; treasurePotionInfo_text.fontSize = 18f;
        treasurePotionDropChance_text.font = koreanFont; treasurePotionDropChance_text.fontSize = 19f;
        barrelOfGoldTotalGold_text.font = koreanFont; barrelOfGoldTotalGold_text.fontSize = 13f;
        mimicChestSpawns_text.font = koreanFont; mimicChestSpawns_text.fontSize = 17f;
        mimicChestChanceForBuff_text.font = koreanFont; mimicChestChanceForBuff_text.fontSize = 15.4f;
        barrelOfGoldInfo_text.font = koreanFont; barrelOfGoldInfo_text.fontSize = 17f;

        //Item and mimic chest buffs
        goldBuffText_text.font = koreanFont; goldBuffText_text.fontSize = 14;
        lootPotionBuff_text.font = koreanFont; lootPotionBuff_text.fontSize = 14;
        damagePotionBuff_text.font = koreanFont; damagePotionBuff_text.fontSize = 12;
        damageBuff_text.font = koreanFont; damageBuff_text.fontSize = 12;
        treasureBuff_text.font = koreanFont; treasureBuff_text.fontSize = 11; treasureBuff_text.lineSpacing = -90;
        xpBuff_text.font = koreanFont; xpBuff_text.fontSize = 13;
        xpPotionBuff.font = koreanFont; xpPotionBuff.fontSize = 13;
        elixirGoldBuff_text.font = koreanFont; elixirGoldBuff_text.fontSize = 11;
        elixirXPBuff_text.font = koreanFont; elixirXPBuff_text.fontSize = 11;
        elixirDamageBuff_text.font = koreanFont; elixirDamageBuff_text.fontSize = 11;
        goldCoinsDropBuff_text.font = koreanFont; goldCoinsDropBuff_text.fontSize = 11;
        goldenTouchBuff.font = koreanFont; goldenTouchBuff.fontSize = 10;

        negativeGold_text.font = koreanFont; negativeGold_text.fontSize = 14;
        negativeDamage_text.font = koreanFont; negativeDamage_text.fontSize = 12;
        negativeTreasure_text.font = koreanFont; negativeTreasure_text.fontSize = 11;
        negativeXP_text.font = koreanFont; negativeXP_text.fontSize = 13;
        negativeGoldCoinsDrop_text.font = koreanFont; negativeGoldCoinsDrop_text.fontSize = 11.4f;

        goldBuffTimer_text.font = koreanFont; goldBuffTimer_text.fontSize = 10;
        lootPotionBuffTimer_text.font = koreanFont; lootPotionBuffTimer_text.fontSize = 10;
        damageBuffTimer_text.font = koreanFont; damageBuffTimer_text.fontSize = 10;
        damagePotionTimer_text.font = koreanFont; damagePotionTimer_text.fontSize = 10;
        treasureBuffTimer_text.font = koreanFont; treasureBuffTimer_text.fontSize = 10;
        xpBuffTimer_text.font = koreanFont; xpBuffTimer_text.fontSize = 10;
        XpPotionTimer_text.font = koreanFont; XpPotionTimer_text.fontSize = 10;
        elixirTimer_text.font = koreanFont; elixirTimer_text.fontSize = 10;
        goldCoinsDropsTimer_text.font = koreanFont; goldCoinsDropsTimer_text.fontSize = 10;
        treasurePotionTimer_Text.font = koreanFont; treasurePotionTimer_Text.fontSize = 10;
        goldenTouchTimer_text.font = koreanFont; goldenTouchTimer_text.fontSize = 10;
        rareTreasuresTimer_text.font = koreanFont; rareTreasuresTimer_text.fontSize = 10;
        negativeGoldtimer_Text.font = koreanFont; negativeGoldtimer_Text.fontSize = 10;
        negativeDamageTimer_text.font = koreanFont; negativeDamageTimer_text.fontSize = 10;
        negativeTreasureTimer_text.font = koreanFont; negativeTreasureTimer_text.fontSize = 10;
        negativeXPTimer_text.font = koreanFont; negativeXPTimer_text.fontSize = 10;
        negativeGoldCoinsDropTimer_text.font = koreanFont; negativeGoldCoinsDropTimer_text.fontSize = 10;
        #endregion

        #region Treasures
        chooseChickenBuff = "<color=green>버프를 선택하기 위해 닭을 클릭하세요";

        foundRubberChickenRewards2_text.font = koreanFont; foundRubberChickenRewards2_text.fontSize = 7f;

        tDropChanceRussAndEng = "% 상자로부터 드롭할 확률";
        youFoundThePrestigeKetAndChest = "";

        doubleInValue = "%를 얻었습니다";

        quartsGained = "수정은 가치가 두 배로 뛸 확률";
        amethystGained = "자수정은 가치가 두 배로 뛸 확률";
        yellowTopazGained = "황옥정은 가치가 두 배로 뛸 확률";
        albiteGained = "조장석은 가치가 두 배로 뛸 확률";
        redGarnetGained = "빨간 가넷은 가치가 두 배로 뛸 확률";
        aquamarineGained = "아쿠아마린은 가치가 두 배로 뛸 확률";
        yellowShapphireGained = "옐로우 사파이어은 가치가 두 배로 뛸 확률";
        pinkTourmalineGained = "핑크 투어멀린은 가치가 두 배로 뛸 확률";
        adventurineGained = "어벤츄린은 가치가 두 배로 뛸 확률";
        redRubyGained = "빨간 루비은 가치가 두 배로 뛸 확률";
        diamondGained = "다이아몬드은 가치가 두 배로 뛸 확률";
        grandidieriteGained = "그란디디어라이트은 가치가 두 배로 뛸 확률";
        violetCrystalGained = "크리스탈 바이올렛은 가치가 두 배로 뛸 확률";
        akoyaPearlGained = "아코야 진주은 가치가 두 배로 뛸 확률";
        purpleRupeeGained = "보라색 루피은 가치가 두 배로 뛸 확률";
        emeraldGained = "에메랄드은 가치가 두 배로 뛸 확률";
        greenDiamondGained = "그린 다이아몬드은 가치가 두 배로 뛸 확률";
        fireOpalGained = "파이어 오팔은 가치가 두 배로 뛸 확률";
        gemSilicaGained = "젬 실리카은 가치가 두 배로 뛸 확률";
        pinkPlortGained = "핑크 플로트은 가치가 두 배로 뛸 확률";
        goldenSeaPearlGained = "골든 바다 진주은 가치가 두 배로 뛸 확률";
        kyaniteGained = "카이언나이트은 가치가 두 배로 뛸 확률";
        blackOpalGained = "블랙오팔은 가치가 두 배로 뛸 확률";
        painiteGained = "페이나이트은 가치가 두 배로 뛸 확률";
        tanzaniteGained = "탄자나이트은 가치가 두 배로 뛸 확률";
        astraliumGained = "아스트랄륨은 가치가 두 배로 뛸 확률";
        elysiumPrismGained = "엘리시움 프리즘은 가치가 두 배로 뛸 확률";
        aerthfireOpalGained = "얼스파이어 오팔은 가치가 두 배로 뛸 확률";
        eldrichStarStoneGained = "엘드리히 스타스톤은 가치가 두 배로 뛸 확률";
        chronolithChardGained = "크로놀리트 샤드은 가치가 두 배로 뛸 확률";
        sideriumEssenceGained = "시더리움 에센스은 가치가 두 배로 뛸 확률";
        quasariteGained = "쿼더라이트은 가치가 두 배로 뛸 확률";
        radiantNovaGained = "레이디언트 노바 스톤은 가치가 두 배로 뛸 확률";
        soluniumShardGained = "솔루늄 샤드은 가치가 두 배로 뛸 확률";

        for (int i = 0; i < 34; i++)
        {
            treasureDropChanceText_text[i].font = koreanFont; treasureDropChanceText_text[i].fontSize = 22;
            treasreDoubleText_text[i].font = koreanFont; treasreDoubleText_text[i].fontSize = 18;
        }

        sellTreasureFor_text.font = koreanFont; sellTreasureFor_text.fontSize = 22; sellTreasureFor_text.lineSpacing = -90;
        sellTreasureFor = "를 "; sellGold = " 골드에 팔기";

        #endregion

        #region Rare Treasures

        YOU_FOUND_A_SKULL = "해골을 찾으셨습니다!";
        YOU_FOUND_A_TROPHY = "트로피를 찾으셨습니다!";
        YOU_FOUND_A_DEMONIC_SWORD = "악귀의 검을 찾으셨습니다!";
        YOU_FOUND_A_RING = "반지를 찾으셨습니다!";
        YOU_FOUND_A_STAR = "별을 찾으셨습니다!";
        YOU_FOUND_A_CLOVER = "클로버를 찾으셨습니다!";
        YOU_FOUND_A_KINGS_CROWN = "왕관을 찾으셨습니다!";
        YOU_FOUND_A_BOOK = "책을 찾으셨습니다!";
        YOU_FOUND_A_GUITAR = "기타를 찾으셨습니다!";
        YOU_FOUND_A_TALARIAN = "탈라리안을 찾으셨습니다!";
        YOU_FOUND_A_STRANGE_RUNE = "이상한 룬을 찾으셨습니다!";
        YOU_FOUND_A_BACKPACK = "가방을 찾으셨습니다!";
        YOU_FOUND_A_SHIELD = "방패를 찾으셨습니다!";
        YOU_FOUND_A_PILL_BOTTLE = "알약 물병을 찾으셨습니다!";
        YOU_FOUND_A_MEDAL = "메달을 찾으셨습니다!";
        YOU_FOUND_A_COOKIE = "쿠키를 찾으셨습니다!";
        YOU_FOUND_A_CHRISTMAS_PRESENT = "크리스마스 선물을 찾으셨습니다!!";
        YOU_FOUND_A_BATTLE_AXE = "전투 도끼를 찾으셨습니다!";
        YOU_FOUND_A_100X_GOLD_COIN = "100X 골드 코인을 찾으셨습니다!";
        YOU_FOUND_A_SEALED_ENVELOPE = "봉인된 봉투를 찾으셨습니다!";
        YOU_FOUND_A_STRANGE_POTION = "이상한 포션을 찾으셨습니다!";
        YOU_FOUND_A_SOUL_GEM = "영혼 보석을 찾으셨습니다!";
        YOU_FOUND_AN_ANCIENT_SCROLL = "고대 두루마리를 찾으셨습니다!";
        YOU_FOUND_A_BRICK = "벽돌을 찾으셨습니다!";
        YOU_FOUND_A_RUBBER_CHICKEN = "고무 닭을 찾으셨습니다!";

        PIRATE_SKULL = "해적 해골";
        DEMONIC_SWORD = "악귀의 검";
        MYSTIC_RING = "신비로운 반지";
        TROPHY = "트로피";
        FALLEN_STAR = "떨어진 별";
        CLOVER = "클로버";
        KINGS_CROWN = "왕관";
        SPELL_BOOK = "주문서적";
        GUITAR = "기타";
        TALARIAN = "탈라리안";
        MYTHRUNE = "미스룬";
        EXPLORER_BACKPACK = "모험가 가방";
        VIKING_SHIELD = "바이킹 방패";
        PILL_BOTTLE = "알약 물병";
        VICTORY_MEDAL = "승리 메달";
        COOKIE = "쿠키";
        CHRISTMAS_PRESENT = "크리스마스 선물";
        BATTLE_AXE = "전투 도끼";
        GOLD_COIN_100X = "100X 골드 코인";
        SEALED_ENVELOPE = "봉인된 봉투";
        STRANGE_POTION = "이상한 포션";
        SOUL_GEM = "영혼 보석";
        ANCIENT_SCROLL = "고대 두루마리";
        BRICK = "벽돌";
        RUBBER_CHICKEN = "고무 닭";



        demonicSwordSize = 22;
        mysticRingSize = 16;
        trophySize = 30;
        fallenStarSize = 21;
        cloverSize = 30;
        kingsCrownSize = 24;
        spellBookSize = 22;
        guitarSize = 29;
        talarianSize = 25;
        mythruneSize = 23;
        explorerBackpackSize = 19;
        skullSize = 23;
        rubberChickenSize = 22;
        brickSize = 30;
        ancientScrollSize = 22;
        soulGemSize = 22;
        strangePotionSize = 19;
        sealedEnvelopeSize = 20;
        goldCoin100XSize = 14;
        vikingShieldSize = 25;
        pillBottleSize = 24;
        victoryMedalSize = 23;
        cookieSize = 29;
        christmasPresentSize = 14;
        battleAxeSize = 22;

        pirateSkull_text.font = koreanFont; pirateSkull_text.fontSize = skullSize;
        demonicSword_text.font = koreanFont; demonicSword_text.fontSize = demonicSwordSize;
        mysticRing_text.font = koreanFont; mysticRing_text.fontSize = mysticRingSize;
        trophy_text.font = koreanFont; trophy_text.fontSize = trophySize;
        fallenStar_text.font = koreanFont; fallenStar_text.fontSize = fallenStarSize;
        clover_text.font = koreanFont; clover_text.fontSize = cloverSize;
        kingsCrown_text.font = koreanFont; kingsCrown_text.fontSize = kingsCrownSize;
        spellBook_text.font = koreanFont; spellBook_text.fontSize = spellBookSize;
        guitar_text.font = koreanFont; guitar_text.fontSize = guitarSize;
        talarian_text.font = koreanFont; talarian_text.fontSize = talarianSize;
        mythrune_text.font = koreanFont; mythrune_text.fontSize = mythruneSize;
        explorerBackpack_text.font = koreanFont; explorerBackpack_text.fontSize = explorerBackpackSize;
        vikingShield_text.font = koreanFont; vikingShield_text.fontSize = vikingShieldSize;
        pillBottle_text.font = koreanFont; pillBottle_text.fontSize = pillBottleSize;
        victoryMedal_text.font = koreanFont; victoryMedal_text.fontSize = victoryMedalSize;
        cookie_text.font = koreanFont; cookie_text.fontSize = cookieSize;
        christmasPresent_text.font = koreanFont; christmasPresent_text.fontSize = christmasPresentSize;
        battleAxe_text.font = koreanFont; battleAxe_text.fontSize = battleAxeSize;
        goldCoin100X_text.font = koreanFont; goldCoin100X_text.fontSize = goldCoin100XSize;
        sealedEnvelope_text.font = koreanFont; sealedEnvelope_text.fontSize = sealedEnvelopeSize;
        strangePotion_text.font = koreanFont; strangePotion_text.fontSize = strangePotionSize;
        soulGem_text.font = koreanFont; soulGem_text.fontSize = soulGemSize;
        ancientScroll_text.font = koreanFont; ancientScroll_text.fontSize = ancientScrollSize;
        brick_text.font = koreanFont; brick_text.fontSize = brickSize;
        rubberChicken_text.font = koreanFont; rubberChicken_text.fontSize = rubberChickenSize;



        if (RareTreasures.skullFound == 1)
        {
            pirateSkull_text.text = PIRATE_SKULL;
        }
        if (RareTreasures.swordFound == 1)
        {
            demonicSword_text.text = DEMONIC_SWORD;
        }
        if (RareTreasures.ringFound == 1)
        {
            mysticRing_text.text = MYSTIC_RING;
        }
        if (RareTreasures.trophyFound == 1)
        {
            trophy_text.text = TROPHY;
        }
        if (RareTreasures.starFound == 1)
        {
            fallenStar_text.text = FALLEN_STAR;
        }
        if (RareTreasures.cloverFound == 1)
        {
            clover_text.text = CLOVER;
        }
        if (RareTreasures.crownFound == 1)
        {
            kingsCrown_text.text = KINGS_CROWN;
        }
        if (RareTreasures.bookFound == 1)
        {
            spellBook_text.text = SPELL_BOOK;
        }
        if (RareTreasures.guitarFOund == 1)
        {
            guitar_text.text = GUITAR;
        }
        if (RareTreasures.talarianFound == 1)
        {
            talarian_text.text = TALARIAN;
        }
        if (RareTreasures.runeFound == 1)
        {
            mythrune_text.text = MYTHRUNE;
        }
        if (RareTreasures.backPackFound == 1)
        {
            explorerBackpack_text.text = EXPLORER_BACKPACK;
        }
        if (RareTreasures.shieldFound == 1)
        {
            vikingShield_text.text = VIKING_SHIELD;
        }
        if (RareTreasures.pillBottleFound == 1)
        {
            pillBottle_text.text = PILL_BOTTLE;
        }
        if (RareTreasures.medalFound == 1)
        {
            victoryMedal_text.text = VICTORY_MEDAL;
        }
        if (RareTreasures.cookieFound == 1)
        {
            cookie_text.text = COOKIE;
        }
        if (RareTreasures.presentFound == 1)
        {
            christmasPresent_text.text = CHRISTMAS_PRESENT;
        }
        if (RareTreasures.axeFound == 1)
        {
            battleAxe_text.text = BATTLE_AXE;
        }
        if (RareTreasures.coin100XFound == 1)
        {
            goldCoin100X_text.text = GOLD_COIN_100X;
        }
        if (RareTreasures.envelopeFound == 1)
        {
            sealedEnvelope_text.text = SEALED_ENVELOPE;
        }
        if (RareTreasures.potionFound == 1)
        {
            strangePotion_text.text = STRANGE_POTION;
        }
        if (RareTreasures.soulGemFound == 1)
        {
            soulGem_text.text = SOUL_GEM;
        }
        if (RareTreasures.scrollFound == 1)
        {
            ancientScroll_text.text = ANCIENT_SCROLL;
        }
        if (RareTreasures.brickFound == 1)
        {
            brick_text.text = BRICK;
        }
        if (RareTreasures.chickenFound == 1)
        {
            rubberChicken_text.text = RUBBER_CHICKEN;
        }

        foundRareTreasurePopUp_text.lineSpacing = -35;

        foundRareTreasurePopUp_text.font = koreanFont; foundRareTreasurePopUp_text.fontSize = 32;

        pirateSkull_text.lineSpacing = -105;
        demonicSword_text.lineSpacing = -105;
        mysticRing_text.lineSpacing = -105;
        trophy_text.lineSpacing = -105;
        fallenStar_text.lineSpacing = -105;
        clover_text.lineSpacing = -105;
        kingsCrown_text.lineSpacing = -105;
        spellBook_text.lineSpacing = -105;
        guitar_text.lineSpacing = -105;
        talarian_text.lineSpacing = -105;
        mythrune_text.lineSpacing = -105;
        explorerBackpack_text.lineSpacing = -105;
        vikingShield_text.lineSpacing = -105;
        pillBottle_text.lineSpacing = -105;
        victoryMedal_text.lineSpacing = -105;
        cookie_text.lineSpacing = -105;
        christmasPresent_text.lineSpacing = -105;
        battleAxe_text.lineSpacing = -105;
        goldCoin100X_text.lineSpacing = -105;
        sealedEnvelope_text.lineSpacing = -105;
        strangePotion_text.lineSpacing = -105;
        soulGem_text.lineSpacing = -105;
        ancientScroll_text.lineSpacing = -105;
        brick_text.lineSpacing = -105;
        rubberChicken_text.lineSpacing = -105;


        chooseText1_text.font = koreanFont; chooseText1_text.fontSize = 18;
        chooseText2_text.font = koreanFont; chooseText2_text.fontSize = 18;
        chooseText3_text.font = koreanFont; chooseText3_text.fontSize = 18;
        chooseText4_text.font = koreanFont; chooseText4_text.fontSize = 18;
        chooseText5_text.font = koreanFont; chooseText5_text.fontSize = 18;
        chooseText6_text.font = koreanFont; chooseText6_text.fontSize = 18;
        chooseText7_text.font = koreanFont; chooseText7_text.fontSize = 18;


        price200SkillPoints_text.font = koreanFont; price200SkillPoints_text.fontSize = 12.6f;
        priceEqual = "가격 =";
        skillPoints200 = "200 스킬 포인트";
        if (PlayerLevel.skillPoints >= 200)
        {
            price200SkillPoints_text.text = Localization.priceEqual + " <color=green>" + Localization.skillPoints200;
        }
        if (PlayerLevel.skillPoints < 200)
        {
            price200SkillPoints_text.text = Localization.priceEqual + " <color=red>" + Localization.skillPoints200;
        }
        #endregion

        #region Treasure Chests
        ON = "켬"; OFF = "끔";

        GoldCoinsDrop = "골드 코인 드롭: ";
        goldCoinValue = "골드 코인 가치: ";
        XPDrop = "XP 드롭: ";

        chestNumber = ""; chestNO = "호 상자";

        reinforcedChestChance1 = "강화 상자 확률 "; reinforcedChestChance2 = "";

        WoodenChest = "나무 상자";
        TimberwoodChest = "팀버우드 상자";
        RockboundChest = "록바운드 상자";
        BronzeChest = "브론즈 상자";
        SequoiaChest = "세쿼이아 상자";
        IronboundChest = "아이언바운드 상자";
        StoneshieldChest = "스톤실드 상자";
        OceanChest = "바다 상자";
        PoisonousChest = "독성 상자";
        GoldenChest = "황금 상자";
        DesertChest = "사막 상자";
        PirateChest = "해적 상자";
        CrystalChest = "크리스탈 상자";
        CelestialChest = "천체 상자";
        PhantomChest = "유령 상자";
        PrismaticChest = "프리즈매틱 상자";
        AquaticChest = "아쿠아틱 상자";
        WindwalkersChest = "풍운의 상자";
        EnchantedChest = "마법의 상자";
        RoyalChest = "로얄 상자";
        ArcaneChest = "신비한 상자";
        GrandioseChest = "웅장한 상자";
        LuxuriousGoldenChest = "럭셔리 골드 상자";
        SacredChest = "신성한 상자";
        EternitysEmbraceChest = "영원의 포옹 상자";
        ForgottenChest = "잊혀진 상자";
        LivingLuminousChest = "활기롭게 빛나는 상자";
        FortressOfWealth = "부의 요새";
        FortifiedTimberChest = "요새화된 목재 상자";
        RadiantFrostlock = "발산하는 프로스트락";
        InfernoEmbracedChest = "지옥을 아우른 상자";
        DeathChest = "죽음의 상자";
        AlienChest = "외계인 상자";
        CraftsmansReliquary = "장인의 유물함";
        HellfireGuardianChest = "지옥불 가디언 상자";
        GhastlySoulHoardChest = "무시무시한 영혼 비축 상자";
        HighTechCache = "고급 기술 캐시";
        EliteHackersStrongbox = "엘리트 해커의 금고";
        CollectorsVault = "수집가의 금고";
        ExquisiteAzureRadianceChest = "정교한 애저 발광 상자";

        TimberwoodChestUnlocked = "팀버우드 상자 잠금해제됨";
        RockboundChestUnlocked = "록바운드 상자 잠금해제됨";
        BronzeChestUnlocked = "브론즈 상자 잠금해제됨";
        SequoiaChestUnlocked = "세쿼이아 상자 잠금해제됨";
        IronboundChestUnlocked = "아이언바운드 상자 잠금해제됨";
        StoneshieldChestUnlocked = "스톤실드 상자 잠금해제됨";
        OceanChestUnlocked = "바다 상자 잠금해제됨";
        PoisonousChestUnlocked = "독성 상자 잠금해제됨";
        GoldenChestUnlocked = "황금 상자 잠금해제됨";
        DesertChestUnlocked = "사막 상자 잠금해제됨";
        PirateChestUnlocked = "해적 상자 잠금해제됨";
        CrystalChestUnlocked = "크리스탈 상자 잠금해제됨";
        CelestialChestUnlocked = "천체 상자 잠금해제됨";
        PhantomChestUnlocked = "유령 상자 잠금해제됨";
        PrismaticChestUnlocked = "프리즈매틱 상자 잠금해제됨";
        AquaticChestUnlocked = "아쿠아틱 상자잠금해제됨";
        WindwalkersChestUnlocked = "풍운의 상자 잠금해제됨";
        EnchantedChestUnlocked = "마법의 상자 잠금해제됨";
        RoyalChestUnlocked = "로얄 상자 잠금해제됨";
        ArcaneChestUnlocked = "신비한 상자 잠금해제됨";
        GrandioseChestUnlocked = "웅장한 상자 잠금해제됨";
        LuxuriousGoldenChestUnlocked = "럭셔리 골드 상자 잠금해제됨";
        SacredChestUnlocked = "신성한 상자 잠금해제됨";
        EternitysEmbraceChestUnlocked = "영원의 포옹 상자 잠금해제됨";
        ForgottenChestUnlocked = "잊혀진 상자 잠금해제됨";
        LivingLuminousChestUnlocked = "활기롭게 빛나는 상자 잠금해제됨";
        FortressOfWealthUnlocked = "부의 요새 잠금해제됨";
        FortifiedTimberChestUnlocked = "요새화된 목재 상자 잠금해제됨";
        RadiantFrostlockUnlocked = "발산하는 프로스트락 잠금해제됨";
        InfernoEmbracedChestUnlocked = "지옥을 아우른 상자 잠금해제됨";
        DeathChestUnlocked = "죽음의 상자 잠금해제됨";
        AlienChestUnlocked = "외계인 상자 잠금해제됨";
        CraftsmansReliquaryUnlocked = "장인의 유물함 잠금해제됨";
        HellfireGuardianChestUnlocked = "지옥불 가디언 상자 잠금해제됨";
        GhastlySoulHoardChestUnlocked = "무시무시한 영혼 비축 상자 잠금해제됨";
        HighTechCacheUnlocked = "고급 기술 캐시 잠금해제됨";
        EliteHackersStrongboxUnlocked = "엘리트 해커의 금고 잠금해제됨";
        CollectorsVaultUnlocked = "수집가의 금고 잠금해제됨";
        ExquisiteAzureRadianceChestUnlocked = "정교한 애저 발광 상자 잠금해제됨";

        chestPrice_text.font = koreanFont; chestPrice_text.fontSize = 25;
        chestHP_text.font = koreanFont; chestHP_text.fontSize = 34;
        autoPurchaseONOFF_text.font = koreanFont; autoPurchaseONOFF_text.fontSize = 40;
        chestHoverName_text.font = koreanFont; chestHoverName_text.fontSize = 31;
        chestNO_text.font = koreanFont; chestNO_text.fontSize = 30;
        chestXPAmount_text.font = koreanFont; chestXPAmount_text.fontSize = 19;
        chestGoldCoins_text.font = koreanFont; chestGoldCoins_text.fontSize = 19;
        chestGoldAmount_text.font = koreanFont; chestGoldAmount_text.fontSize = 19;
        chestReinforcedChance.font = koreanFont; chestReinforcedChance.fontSize = 19;
        chestPurchasedName_text.font = koreanFont; chestPurchasedName_text.fontSize = 45;

        reinforcedHoverHealth_text.font = koreanFont; reinforcedHoverHealth_text.fontSize = 20;
        reinforcedHoverGold_text.font = koreanFont; reinforcedHoverGold_text.fontSize = 20;
        reinforcedHoverXP_text.font = koreanFont; reinforcedHoverXP_text.fontSize = 20;

        enchantedGoldenHoverHealth_text.font = koreanFont; enchantedGoldenHoverHealth_text.fontSize = 17;
        enchantedGoldenHoverTreasures_text.font = koreanFont; enchantedGoldenHoverTreasures_text.fontSize = 17;
        enchantedGoldenHoverXP_text.font = koreanFont; enchantedGoldenHoverXP_text.fontSize = 17;

        bossChestHoverHealth_text.font = koreanFont; bossChestHoverHealth_text.fontSize = 17;
        bossChestHoverGoldValue_text.font = koreanFont; bossChestHoverGoldValue_text.fontSize = 17;
        bossChestHoverGoldCoins_text.font = koreanFont; bossChestHoverGoldCoins_text.fontSize = 17;
        bossChestHoverXP_text.font = koreanFont; bossChestHoverXP_text.fontSize = 17;
        #endregion

        #region Prestige

        prestigeKeyChance1 = "프레스티지 열쇠 드롭 확률 "; prestigeKeyChance2 = "%";
        prestieChestKey1 = "프레스티지 상자 드롭 확률 "; prestieChestKey2 = "%";

        FindThePrestigeKeyandChest = "프레스티지 열쇠와 프레스티지 상자를 찾으세요";
        youFoundThePrestigeKetAndChest = "프레스티지 열쇠와 프레스티지 상자를 찾으셨습니다!";

        youFoundPrestigeKey = "프레스티지 열쇠를 찾으셨습니다!";
        youFoundPrestigeChest = "프레스티지 상자를 찾으셨습니다!";

        nextLevelHover = "다음 레벨 = "; skillPointsHover = " 스킬 포인트";

        choseItemToStartWith = "시작할 아이템 1개를 선택하세요";
        chooseItemsToStartWith2 = "시작할 아이템 2개를 선택하세요";
        chooseItemsToStartWith3 = "시작할 아이템 3개를 선택하세요";
        chooseItemsToStartWith5 = "시작할 아이템 5개를 선택하세요";


        findThePrestigeKeyAncChest_text.font = koreanFont; findThePrestigeKeyAncChest_text.fontSize = 14;


        if (SpawnRewards.prestigeKeyFound == 0)
        {
            findThePrestigeKeyAncChest_text.text = FindThePrestigeKeyandChest;
        }
        if (SpawnRewards.prestigeChestFound == 0)
        {
            findThePrestigeKeyAncChest_text.text = FindThePrestigeKeyandChest;
        }
        if (SpawnRewards.prestigeChestFound == 1 && SpawnRewards.prestigeKeyFound == 1)
        {
            findThePrestigeKeyAncChest_text.text = youFoundThePrestigeKetAndChest;
        }

        prestigeKeyDropChance_text.font = koreanFont; prestigeKeyDropChance_text.fontSize = 20;
        prestigeChestDropChance_text.font = koreanFont; prestigeChestDropChance_text.fontSize = 20;
        prestigeKeyDropChance_text.text = Localization.prestigeKeyChance1 + 0.017 * (UnlockChests.timesPurchasedChests + 1) + Localization.prestigeKeyChance2;
        prestigeChestDropChance_text.text = Localization.prestieChestKey1 + 0.017 * (UnlockChests.timesPurchasedChests + 1) + Localization.prestieChestKey2;

        nextLeveEqualSkillPoints_text.font = koreanFont; nextLeveEqualSkillPoints_text.fontSize = 55;
        nextLeveEqualSkillPoints_text.text = Localization.nextLevelHover + "<color=green>+" + ((PlayerLevel.playerLevel / 5) + 1) + "<color=white>" + Localization.skillPointsHover;


        chooseItemToStartWith_text.font = koreanFont; chooseItemToStartWith_text.fontSize = 42;
        #endregion

        #region Other
        level = "레벨 ";
        xpNoPercent = "XP";
        crit = "크리티컬!";

        totalGold_text.font = koreanFont; totalGold_text.fontSize = 46;
        levelText_text.font = koreanFont; levelText_text.fontSize = 36; levelText_text.text = "레벨 " + PlayerLevel.playerLevel;
        xpNeededText_text.font = koreanFont; xpNeededText_text.fontSize = 15;
        activeDamageAmount_text.font = koreanFont; activeDamageAmount_text.fontSize = 20f;
        passiveDamageAmount_text.font = koreanFont; passiveDamageAmount_text.fontSize = 20f;
        acitveDamagePrice_text.font = koreanFont; acitveDamagePrice_text.fontSize = 18f;
        passiveDamagePrice_text.font = koreanFont; passiveDamagePrice_text.fontSize = 18f;
        activeDamageLEVELAmount_text.font = koreanFont; activeDamageLEVELAmount_text.fontSize = 30f;
        passiveLEVELAmount_text.font = koreanFont; passiveLEVELAmount_text.fontSize = 30f;
        passiveDamageUPGRADE_text.font = koreanFont; passiveDamageUPGRADE_text.fontSize = 20f;
        activeDamageUPGRADE_text.font = koreanFont; activeDamageUPGRADE_text.fontSize = 20f;

        youOpened.font = koreanFont; youOpened.fontSize = 40; youOpened.lineSpacing = -70;
        timeGoneTotal.font = koreanFont; timeGoneTotal.fontSize = 40;

        damageUnderChest.font = koreanFont; damageUnderChest.fontSize = 6;
        #endregion

        ChangeAllText();
    }
    #endregion

    public void ChangeAllText()
    {
        specialScript.NewPrices();
        updateGame.SetInfoText();
        clickPower.SetTopText();
        clickPower.ChangeText();
        rareTreasure.ChoseChickenBuff();
        rareTreasure.ChangeText();
        selectChests.CheckChestText();

        chestPrice_text.text = TotalGoldAmount.FormatCoinsDoubleOneLetter(SelectChests.chestPrice) + "";
        chestHP_text.text = TotalGoldAmount.FormatCoinsDoubleOneLetter(SelectChests.ChestHealth) + "";

        SpawnRewards.changeDropChanceValues = true;
        UpdateGame.changeItemUpdate = true;
    }

    public TextMeshProUGUI settingsText, informationText, achievementsText, statisticsText;
    public static string info, chest, findTheCookie, cookieCliker, useTheChicken;

    public TextMeshProUGUI settingsClose, informationClose, achievementsClose, statsClose, prestigeInfoClose, rareTreasureClose, treasureClose, itemsInfoCLose, cursorInfoClose, chestInfoClose, activeClose, passiveClose, turnOff, turnOn, autoPurchaseChestClose, prestigeUpgradeClose, prestigeUpgradeBuy;

    public TextMeshProUGUI miscText, bucketClaimText, bucketCloseText, settingsText2;
    //remeber barrel

    public PlaceMobileButtons mobileScript;

    public void ChangeMobileText()
    {
        //English
        if (EnglishLanguageChosen == 1)
        {
            miscText.text = "Misc"; miscText.font = ChangaBoldSDF1; miscText.fontSize = 130;
            bucketClaimText.text = "CLAIM"; bucketClaimText.font = ChangaBoldSDF1; bucketClaimText.fontSize = 42;
            bucketCloseText.text = "CLOSE"; bucketCloseText.font = ChangaBoldSDF1; bucketCloseText.fontSize = 42;

            findTheCookie = "Find the cookie!";
            cookieCliker = "Cookie clicker!";
            useTheChicken = "Use the chicken";

            settingsText.text = "SETTINGS"; settingsText.font = ChangaBoldSDF1; settingsText.fontSize = 66;
            settingsText2.text = "Settings"; settingsText2.font = ChangaBoldSDF1; settingsText2.fontSize = 42;
            informationText.text = "INFORMATION"; informationText.font = ChangaBoldSDF1; informationText.fontSize = 55;
            achievementsText.text = "ACHIEVEMENTS"; achievementsText.font = ChangaBoldSDF1; achievementsText.fontSize = 48;
            statisticsText.text = "STATS"; statisticsText.font = ChangaBoldSDF1; statisticsText.fontSize = 65;
            info = "Info";
            chest = "Chest"; 

            settingsClose.text = "CLOSE"; settingsClose.font = ChangaBoldSDF1; settingsClose.fontSize = 83;
            informationClose.text = "CLOSE"; informationClose.font = ChangaBoldSDF1; informationClose.fontSize = 83;
            achievementsClose.text = "CLOSE"; achievementsClose.font = ChangaBoldSDF1; achievementsClose.fontSize = 84;
            statsClose.text = "CLOSE"; statsClose.font = ChangaBoldSDF1; statsClose.fontSize = 84;
            prestigeInfoClose.text = "CLOSE"; prestigeInfoClose.font = ChangaBoldSDF1; prestigeInfoClose.fontSize = 58;
            rareTreasureClose.text = "CLOSE"; rareTreasureClose.font = ChangaBoldSDF1; rareTreasureClose.fontSize = 39;
            treasureClose.text = "CLOSE"; treasureClose.font = ChangaBoldSDF1; treasureClose.fontSize = 40;
            itemsInfoCLose.text = "CLOSE"; itemsInfoCLose.font = ChangaBoldSDF1; itemsInfoCLose.fontSize = 32;
            cursorInfoClose.text = "CLOSE"; cursorInfoClose.font = ChangaBoldSDF1; cursorInfoClose.fontSize = 32;
            chestInfoClose.text = "CLOSE"; chestInfoClose.font = ChangaBoldSDF1; chestInfoClose.fontSize = 50;
            activeClose.text = "CLOSE"; activeClose.font = ChangaBoldSDF1; activeClose.fontSize = 99;
            passiveClose.text = "CLOSE"; passiveClose.font = ChangaBoldSDF1; passiveClose.fontSize = 99;
            turnOff.text = "TURN OFF"; turnOff.font = ChangaBoldSDF1; turnOff.fontSize = 30;
            turnOn.text = "TURN ON"; turnOn.font = ChangaBoldSDF1; turnOn.fontSize = 30;
            autoPurchaseChestClose.text = "CLOSE"; autoPurchaseChestClose.font = ChangaBoldSDF1; autoPurchaseChestClose.fontSize = 56;
            prestigeUpgradeClose.text = "CLOSE"; prestigeUpgradeClose.font = ChangaBoldSDF1; prestigeUpgradeClose.fontSize = 90;
            prestigeUpgradeBuy.text = "BUY"; prestigeUpgradeBuy.font = ChangaBoldSDF1; prestigeUpgradeBuy.fontSize = 90;
        }

        //Russian
        if (RussianLanguageChosen == 1) 
        {
            miscText.text = "Разное";
            bucketClaimText.text = "Заявить";
            bucketCloseText.text = "Закрыть";

            miscText.font = russianNono_Bold; miscText.fontSize = 130;
            bucketClaimText.font = russianNono_Bold; bucketClaimText.fontSize = 26;
            bucketCloseText.font = russianNono_Bold; bucketCloseText.fontSize = 26;

            findTheCookie = "Найти печеньку!";
            cookieCliker = "Кликер печенек!";
            useTheChicken = "Использовать курицу";

            settingsText2.text = "Настройки"; settingsText2.font = russianNono_Bold; settingsText2.fontSize = 31;
            settingsText.text = "Настройки"; settingsText.font = russianNono_Bold; settingsText.fontSize = 42;
            informationText.text = "ИНФО"; informationText.font = russianNono_Bold; informationText.fontSize = 55;
            achievementsText.text = "ДОСТИЖЕНИЯ"; achievementsText.font = russianNono_Bold; achievementsText.fontSize = 38;
            statisticsText.text = "СТАТИСТИКА"; statisticsText.font = russianNono_Bold; statisticsText.fontSize = 41;
            info = "ИНФО";
            chest = "Сундук";

            settingsClose.text = "Закрыть"; settingsClose.font = russianNono_Bold; settingsClose.fontSize = 66;
            informationClose.text = "Закрыть"; informationClose.font = russianNono_Bold; informationClose.fontSize = 66;
            achievementsClose.text = "Закрыть"; achievementsClose.font = russianNono_Bold; achievementsClose.fontSize = 47;
            statsClose.text = "Закрыть"; statsClose.font = russianNono_Bold; statsClose.fontSize = 39;
            prestigeInfoClose.text = "Закрыть"; prestigeInfoClose.font = russianNono_Bold; prestigeInfoClose.fontSize = 39;
            rareTreasureClose.text = "Закрыть"; rareTreasureClose.font = russianNono_Bold; rareTreasureClose.fontSize = 59;
            treasureClose.text = "Закрыть"; treasureClose.font = russianNono_Bold; treasureClose.fontSize = 67;
            itemsInfoCLose.text = "Закрыть"; itemsInfoCLose.font = russianNono_Bold; itemsInfoCLose.fontSize = 32;
            cursorInfoClose.text = "Закрыть"; cursorInfoClose.font = russianNono_Bold; cursorInfoClose.fontSize = 32;
            chestInfoClose.text = "Закрыть"; chestInfoClose.font = russianNono_Bold; chestInfoClose.fontSize = 33;
            activeClose.text = "Закрыть"; activeClose.font = russianNono_Bold; activeClose.fontSize = 77;
            passiveClose.text = "Закрыть"; passiveClose.font = russianNono_Bold; passiveClose.fontSize = 77;
            turnOff.text = "Включить"; turnOff.font = russianNono_Bold; turnOff.fontSize = 22;
            turnOn.text = "Выключить"; turnOn.font = russianNono_Bold; turnOn.fontSize = 22;
            autoPurchaseChestClose.text = "Закрыть"; autoPurchaseChestClose.font = russianNono_Bold; autoPurchaseChestClose.fontSize = 39;
            prestigeUpgradeClose.text = "Закрыть"; prestigeUpgradeClose.font = russianNono_Bold; prestigeUpgradeClose.fontSize = 51;
            prestigeUpgradeBuy.text = "Купить"; prestigeUpgradeBuy.font = russianNono_Bold; prestigeUpgradeBuy.fontSize = 60;
        }

        //Japanese
        if (JapaneseLanguageChosen == 1) 
        {
            miscText.text = "雑多なもの";
            bucketClaimText.text = "得る";
            bucketCloseText.text = "出口";

            miscText.font = japaneseSemiBold; miscText.fontSize = 100;
            bucketClaimText.font = japaneseSemiBold; bucketClaimText.fontSize = 42;
            bucketCloseText.font = japaneseSemiBold; bucketCloseText.fontSize = 42;

            findTheCookie = "クッキーを見つけよう!";
            cookieCliker = "クッキークリッカー!";
            useTheChicken = "鶏肉を使う";

            settingsText2.text = "設定"; settingsText2.font = japaneseSemiBold; settingsText2.fontSize = 42;
            settingsText.text = "設定"; settingsText.font = japaneseSemiBold; settingsText.fontSize = 66;
            informationText.text = "情報"; informationText.font = japaneseSemiBold; informationText.fontSize = 55;
            achievementsText.text = "実績"; achievementsText.font = japaneseSemiBold; achievementsText.fontSize = 48;
            statisticsText.text = "ﾂづ慊つｷﾂ"; statisticsText.font = japaneseSemiBold; statisticsText.fontSize = 65;
            info = "情報";
            chest = "胸";

            settingsClose.text = "出口"; settingsClose.font = japaneseSemiBold; settingsClose.fontSize = 83;
            informationClose.text = "出口"; informationClose.font = japaneseSemiBold; informationClose.fontSize = 83;
            achievementsClose.text = "出口"; achievementsClose.font = japaneseSemiBold; achievementsClose.fontSize = 84;
            statsClose.text = "出口"; statsClose.font = japaneseSemiBold; statsClose.fontSize = 84;
            prestigeInfoClose.text = "出口"; prestigeInfoClose.font = japaneseSemiBold; prestigeInfoClose.fontSize = 54;
            rareTreasureClose.text = "出口"; rareTreasureClose.font = japaneseSemiBold; rareTreasureClose.fontSize = 37;
            treasureClose.text = "出口"; treasureClose.font = japaneseSemiBold; treasureClose.fontSize = 41;
            itemsInfoCLose.text = "出口"; itemsInfoCLose.font = japaneseSemiBold; itemsInfoCLose.fontSize = 32;
            cursorInfoClose.text = "出口"; cursorInfoClose.font = japaneseSemiBold; cursorInfoClose.fontSize = 32;
            chestInfoClose.text = "出口"; chestInfoClose.font = japaneseSemiBold; chestInfoClose.fontSize = 50;
            activeClose.text = "出口"; activeClose.font = japaneseSemiBold; activeClose.fontSize = 99;
            passiveClose.text = "出口"; passiveClose.font = japaneseSemiBold; passiveClose.fontSize = 99;
            turnOff.text = " 消す"; turnOff.font = japaneseSemiBold; turnOff.fontSize = 30;
            turnOn.text = "つける"; turnOn.font = japaneseSemiBold; turnOn.fontSize = 30;
            autoPurchaseChestClose.text = "出口"; autoPurchaseChestClose.font = japaneseSemiBold; autoPurchaseChestClose.fontSize = 56;
            prestigeUpgradeClose.text = "出口"; prestigeUpgradeClose.font = japaneseSemiBold; prestigeUpgradeClose.fontSize = 90;
            prestigeUpgradeBuy.text = "買う"; prestigeUpgradeBuy.font = japaneseSemiBold; prestigeUpgradeBuy.fontSize = 90;
        }

        //Chinese
        if (ChineseLanguageChosen == 1) 
        {
            miscText.text = "Misc";
            bucketClaimText.text = "得到";
            bucketCloseText.text = "关闭";

            miscText.font = chineseFont; miscText.fontSize = 130;
            bucketClaimText.font = chineseFont; bucketClaimText.fontSize = 42;
            bucketCloseText.font = chineseFont; bucketCloseText.fontSize = 42;

            findTheCookie = "找到饼干！";
            cookieCliker = "饼干点击大师！";
            useTheChicken = "使用鸡";

            settingsText2.text = "设置"; settingsText2.font = chineseFont; settingsText2.fontSize = 42;
            settingsText.text = "设置"; settingsText.font = chineseFont; settingsText.fontSize = 66;
            informationText.text = "资讯"; informationText.font = chineseFont; informationText.fontSize = 55;
            achievementsText.text = "成就"; achievementsText.font = chineseFont; achievementsText.fontSize = 48;
            statisticsText.text = "数据"; statisticsText.font = chineseFont; statisticsText.fontSize = 65;
            info = "资讯";
            chest = "宝箱";

            settingsClose.text = "关闭"; settingsClose.font = chineseFont; settingsClose.fontSize = 83;
            informationClose.text = "关闭"; informationClose.font = chineseFont; informationClose.fontSize = 83;
            achievementsClose.text = "关闭"; achievementsClose.font = chineseFont; achievementsClose.fontSize = 84;
            statsClose.text = "关闭"; statsClose.font = chineseFont; statsClose.fontSize = 84;
            prestigeInfoClose.text = "关闭"; prestigeInfoClose.font = chineseFont; prestigeInfoClose.fontSize = 58;
            rareTreasureClose.text = "关闭"; rareTreasureClose.font = chineseFont; rareTreasureClose.fontSize = 59;
            treasureClose.text = "关闭"; treasureClose.font = chineseFont; treasureClose.fontSize = 67;
            itemsInfoCLose.text = "关闭"; itemsInfoCLose.font = chineseFont; itemsInfoCLose.fontSize = 32;
            cursorInfoClose.text = "关闭"; cursorInfoClose.font = chineseFont; cursorInfoClose.fontSize = 32;
            chestInfoClose.text = "关闭"; chestInfoClose.font = chineseFont; chestInfoClose.fontSize = 50;
            activeClose.text = "关闭"; activeClose.font = chineseFont; activeClose.fontSize = 99;
            passiveClose.text = "关闭"; passiveClose.font = chineseFont; passiveClose.fontSize = 99;
            turnOff.text = "关掉"; turnOff.font = chineseFont; turnOff.fontSize = 30;
            turnOn.text = "打开"; turnOn.font = chineseFont; turnOn.fontSize = 30;
            autoPurchaseChestClose.text = "关闭"; autoPurchaseChestClose.font = chineseFont; autoPurchaseChestClose.fontSize = 56;
            prestigeUpgradeClose.text = "关闭"; prestigeUpgradeClose.font = chineseFont; prestigeUpgradeClose.fontSize = 90;
            prestigeUpgradeBuy.text = "买"; prestigeUpgradeBuy.font = chineseFont; prestigeUpgradeBuy.fontSize = 90;
        }

        //Korean
        if (KoreanLanguageChosen == 1) 
        {
            miscText.text = "기타";
            bucketClaimText.text = "주장하다";
            bucketCloseText.text = "나가기";

            miscText.font = koreanFont; miscText.fontSize = 130;
            bucketClaimText.font = koreanFont; bucketClaimText.fontSize = 30;
            bucketCloseText.font = koreanFont; bucketCloseText.fontSize = 42;

            findTheCookie = "쿠키를 찾으세요!";
            cookieCliker = "쿠키 클리커!";
            useTheChicken = "닭을 사용하세요";

            settingsText2.text = "설정"; settingsText2.font = koreanFont; settingsText2.fontSize = 42;
            settingsText.text = "설정"; settingsText.font = koreanFont; settingsText.fontSize = 66;
            informationText.text = "정보"; informationText.font = koreanFont; informationText.fontSize = 55;
            achievementsText.text = "업적"; achievementsText.font = koreanFont; achievementsText.fontSize = 48;
            statisticsText.text = "스탯"; statisticsText.font = koreanFont; statisticsText.fontSize = 65;
            info = "정보";
            chest = "상자";

            settingsClose.text = "나가기"; settingsClose.font = koreanFont; settingsClose.fontSize = 83;
            informationClose.text = "나가기"; informationClose.font = koreanFont; informationClose.fontSize = 83;
            achievementsClose.text = "나가기"; achievementsClose.font = koreanFont; achievementsClose.fontSize = 84;
            statsClose.text = "나가기"; statsClose.font = koreanFont; statsClose.fontSize = 84;
            prestigeInfoClose.text = "나가기"; prestigeInfoClose.font = koreanFont; prestigeInfoClose.fontSize = 58;
            rareTreasureClose.text = "나가기"; rareTreasureClose.font = koreanFont; rareTreasureClose.fontSize = 59;
            treasureClose.text = "나가기"; treasureClose.font = koreanFont; treasureClose.fontSize = 67;
            itemsInfoCLose.text = "나가기"; itemsInfoCLose.font = koreanFont; itemsInfoCLose.fontSize = 32;
            cursorInfoClose.text = "나가기"; cursorInfoClose.font = koreanFont; cursorInfoClose.fontSize = 32;
            chestInfoClose.text = "나가기"; chestInfoClose.font = koreanFont; chestInfoClose.fontSize = 50;
            activeClose.text = "나가기"; activeClose.font = koreanFont; activeClose.fontSize = 99;
            passiveClose.text = "나가기"; passiveClose.font = koreanFont; passiveClose.fontSize = 99;
            turnOff.text = "켬"; turnOff.font = koreanFont; turnOff.fontSize = 30;
            turnOn.text = "켬"; turnOn.font = koreanFont; turnOn.fontSize = 30;
            autoPurchaseChestClose.text = "나가기"; autoPurchaseChestClose.font = koreanFont; autoPurchaseChestClose.fontSize = 56;
            prestigeUpgradeClose.text = "나가기"; prestigeUpgradeClose.font = koreanFont; prestigeUpgradeClose.fontSize = 90;
            prestigeUpgradeBuy.text = "사다"; prestigeUpgradeBuy.font = koreanFont; prestigeUpgradeBuy.fontSize = 90;
        }

        mobileScript.CheckCursorInfo();
        mobileScript.CheckShopQuestionMarks();
    }

}
