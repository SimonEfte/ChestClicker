using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class HealthBar : MonoBehaviour, IDataPersistence
{
    //AUTOCLICK
    public static float autoDamage;
    public float tickRate = 0.01f;
    private float timeSinceLastTick = 0.01f;

    //public static float chest1Health;
    public static double chest1Health;
    public Slider slider;
    public TextMeshProUGUI chest1HealtchText;
    public GameObject chest1, chest2, chest3, chest4, chest5, chest6, chest7, chest8, chest9, chest10, chest11, chest12, chest13, chest14, chest15, chest16, chest17, chest18, chest19, chest20, chest21, chest22, chest23, chest24, chest25, chest26, chest27, chest28, chest29, chest30, chest31, chest32, chest33, chest34, chest35, chest36, chest37, chest38, chest39, chest40;
    
    public GameObject chest1Open, chest2Open, chest3Open, chest4Open, chest5Open, chest6Open, chest7Open, chest8Open, chest9Open, chest10Open, chest11Open, chest12Open, chest13Open, chest14Open, chest15Open, chest16Open, chest17Open, chest18Open, chest19Open, chest20Open, chest21Open, chest22Open, chest23Open, chest24Open, chest25Open, chest26Open, chest27Open, chest28Open, chest29Open, chest30Open, chest31Open, chest32Open, chest33Open, chest34Open, chest35Open, chest36Open, chest37Open, chest38Open, chest39Open, chest40Open;
    public GameObject lockLocked, lockOpen;

    public static int cursor2Buff;
    public static int cursor4Buff;
    public static int cursor10Buff;

    public static int prestigeGreaterLoot1Amount, prestigeGreaterLoot2Amount, prestigeGreaterLoot3Amount, prestigeGreaterLoot4Amount, prestigeGreaterLoot5Amount;
    public static bool prestigeGreaterLoot1Buff, prestigeGreaterLoot2Buff, prestigeGreaterLoot3Buff, prestigeGreaterLoot4Buff, prestigeGreaterLoot5Buff;

    public static double newPassiveDamage;
    private double scalingFactor;

    void Start()
    {
        enchantedGoldenChest.SetActive(true); bossChest.SetActive(true);

        scalingFactor = 1000000000000000000.0;
        SelectChests.chestNotUnlocked = true;
        cursor10Buff = 0;
        cursor4Buff = 0;
        cursor2Buff = 0;
        chest1Health = 20;

        //setText();
        Invoke("wait2", 0.01f);
        Invoke("wait", 0.4f);
    }

    public bool waitForUpdate;

    public void wait2()
    {
        bossChest.SetActive(false); enchantedGoldenChest.SetActive(false);
    }

    public void wait()
    {
        autoClickerOn = true;
        isDealingAutoDamage = true;

        chest1Health = SelectChests.ChestHealth;
        double scaledValue = chest1Health / scalingFactor;
        slider.maxValue = (float)scaledValue;

        string path = Application.persistentDataPath + "/player.saveAutoDamage";

        if (File.Exists(path))
        {
            if(SaveAndLoad.onlyLoadNewSave == false)
            {
                GameData data = SaveSystem.LoadAutoDamage();
                autoDamage = data.autoDamage;

                newPassiveDamage = autoDamage;
            }
        }
        else
        {
            //Do nothing
        }
        //Debug.Log("HealthBar");

        waitForUpdate = true;
        ClickPower.cursorsPriceChanged = true;
        setText();

        
    }

    #region SaveAndLoadJSON
    public void LoadData(GameDataJSON data)
    {
        autoDamage = data.passiveDamage;
        newPassiveDamage = data.passiveDamageTotal;
    }

    public void SaveData(ref GameDataJSON data)
    {
        data.passiveDamage = autoDamage;
        data.passiveDamageTotal = newPassiveDamage;
    }
    #endregion


    public bool isDealingAutoDamage;
    public GameObject key;
    public GameObject lockPick;
    public GameObject lockPickBrokeText;

    public float clickThreshold = 50f; // Number of clicks per second to detect auto clicker
    public float resetThreshold = 10f;
    private bool isAutoClickerDetected = false;
    private int clickCount = 0;
    private float detectionTime = 1f;

    void Update()
    {
        // Detect mouse clicks
        if (Input.GetMouseButtonDown(0))
        {
            clickCount++;
        }

        // Check if the click count exceeds the threshold in the detection time interval
        detectionTime -= Time.deltaTime;

        if (detectionTime <= 0)
        {
            float clicksPerSecond = clickCount / 1f; // Divide by the detection time

            if (clicksPerSecond > clickThreshold)
            {
                isAutoClickerDetected = true;
                //Debug.Log("Auto clicker detected!");
            }
            else if (clicksPerSecond < resetThreshold)
            {
                isAutoClickerDetected = false;
            }

            clickCount = 0; // Reset click count for the next detection interval
            detectionTime = 1f; // Reset detection time
        }


        #region lockPickOpen
        if (UseConsumable.lockPickOpen == true)
        {
            if (enchantedGoldenChestIsActive == true) { chest1Health -= (slider.maxValue / 3) * scalingFactor; }
            else if (bossChestIsActive == true) { chest1Health -= (slider.maxValue / 5) * scalingFactor; }
            else { chest1Health -= chest1Health; }
            UseConsumable.lockPickOpen = false;
        }
        #endregion

        #region using key
        //Key
        if (UseConsumable.usedKey == true)
        {
            usedKey = true;
            if(enchantedGoldenChestIsActive == true) { chest1Health -= (slider.maxValue / 3) * scalingFactor; }
            else if(bossChestIsActive == true) { chest1Health -= (slider.maxValue / 5) * scalingFactor; }
            else { chest1Health -= chest1Health; }
            
            float random = Random.Range(1, 101);
            if (random <= SpecialUpgradesButtons.keyRareDropChance)
            {
                hitTreasureKey = true;
            }

            UseConsumable.usedKey = false;

        }
        #endregion

        timeSinceLastTick += Time.deltaTime;

        if(waitForUpdate == true)
        {
            // Check if it's time to deal damage
            while (timeSinceLastTick >= tickRate)
            {
                // Deal auto damage
                if (SelectChests.notUnlockedChest == true) { }
                if (SelectChests.notUnlockedChest == false && SelectChests.chest1Wait == false && SelectChests.chest2Wait == false && SelectChests.chest3Wait == false && SelectChests.chest4Wait == false && SelectChests.chest5Wait == false && SelectChests.chest6Wait == false && SelectChests.chest7Wait == false && SelectChests.chest8Wait == false && SelectChests.chest9Wait == false && SelectChests.chest10Wait == false && SelectChests.chest11Wait == false && SelectChests.chest12Wait == false && SelectChests.chest13Wait == false && SelectChests.chest14Wait == false && SelectChests.chest15Wait == false && SelectChests.chest16Wait == false && SelectChests.chest17Wait == false && SelectChests.chest18Wait == false && SelectChests.chest19Wait == false && SelectChests.chest20Wait == false && SelectChests.chest21Wait == false && SelectChests.chest22Wait == false && SelectChests.chest23Wait == false && SelectChests.chest24Wait == false && SelectChests.chest25Wait == false && SelectChests.chest26Wait == false && SelectChests.chest27Wait == false && SelectChests.chest28Wait == false && SelectChests.chest29Wait == false && SelectChests.chest30Wait == false && SelectChests.chest31Wait == false && SelectChests.chest32Wait == false && SelectChests.chest33Wait == false && SelectChests.chest34Wait == false && SelectChests.chest35Wait == false && SelectChests.chest36Wait == false && SelectChests.chest37Wait == false && SelectChests.chest38Wait == false && SelectChests.chest39Wait == false && SelectChests.chest40Wait == false && SkillTree.isPrestiged == false) { DealAutoDamge(newPassiveDamage * tickRate); }

                // Subtract the time interval from the elapsed time
                timeSinceLastTick -= tickRate;
            }
        }
        

        if(SelectChests.changesChest == true)
        {
            StartCoroutine(StopAnims());
            SelectChests.changesChest = false;
        }

        #region autoClicker

        if (SkillTree.autoClicker1Bought == 1 && SkillTree.isInsideskillTree == false && SelectChests.chestNotUnlocked == false)
        {
         if(SelectChests.chestNotUnlocked == false) { StartCoroutine(autoClicker()); SelectChests.chestNotUnlocked = true; }

        }

        #endregion

        #region soulGem drop
        if(SoulGemClick.clickedOnSoulGem == true)
        {
            StartCoroutine(SoulGemBonus());
            SoulGemClick.clickedOnSoulGem = false;
        }
        #endregion
    }

    public static bool autoClickerOn;
    IEnumerator autoClicker()
    {
        yield return new WaitForSeconds(SkillTree.autoClicksPerSecond);

        DealAutoDamage();
        Stats.autoClicks += 1;
        SelectChests.chestNotUnlocked = false;
    }

    public bool dealDamage;
    public double test;

    public void DealAutoDamge(double damage)
    {
        //chest1Health -= (((autoDamage) * (ClickPower.passiveDamageMultiplier + UseConsumable.damagePotionBuff + UseConsumable.elixirDamageBuff + SkillTree.skillTreePassiveDamage + RareTreasures.skullPassiveDamage + RareTreasures.guitarActiveAndPassive + RareTreasures.talariaPassive + RareTreasures.cookiePassive + UseConsumable.scrollPassiveDamageBuff + UpdateGame.damageBuffAmount - UpdateGame.damageDebuffAmount + 1 ))  * (tickRate));

        chest1Health -= (((newPassiveDamage) * (ClickPower.passiveDamageMultiplier + UseConsumable.damagePotionBuff + UseConsumable.elixirDamageBuff + SkillTree.skillTreePassiveDamage + RareTreasures.skullPassiveDamage + RareTreasures.guitarActiveAndPassive + RareTreasures.talariaPassive + RareTreasures.cookiePassive + UseConsumable.scrollPassiveDamageBuff + UseConsumable.relicPermaPassiveDamage + UpdateGame.damageBuffAmount - UpdateGame.damageDebuffAmount + 1)) * (tickRate));

        if (chest1Health <= 0 && dealDamage == false)
        {
            #region cursor 2 bonus
            if (ClickPower.cursor2Equipped == 1)
            {
                cursor2Buff += 1;
            }
            #endregion

            #region cursor 4 bonus
            if (ClickPower.cursor4Equipped == 1)
            {
                cursor4Buff += 1;
            }
            #endregion

            #region cursor 10 bonus

            if(ClickPower.cursor10Equipped == 1)
            {
                cursor10Buff += 1;
            }

            #endregion

            #region skill tree auto 3
            if (SkillTree.autoDamage3Bought == 1)
            {
                SkillTree.skillTreeAutoDamage3ChestSpawn += 1;
            }
            #endregion

            #region skill tree auto 4
            if (SkillTree.autoDamage4Bought == 1)
            {
                SkillTree.skillTreeAutoDamage4TreasureDrop += 1;
            }
            #endregion

            #region skill tree auto 6
            if (SkillTree.autoDamage6Bought == 1)
            {
                SkillTree.skillTreeAuto6ChestDrops += 1;
            }
            #endregion

            spawnRewards = true;

            if (reinforcedChestActive == true)
            {
                Stats.reinforedChestsOpened += 1;
            }

            if (enchantedGoldenChestIsActive == true)
            {
                Stats.enchantedGoldenChestsOpened += 1;
            }

            if (bossChestIsActive == true)
            {
                Stats.bossChestOpened += 1;
            }

            AllPRestigeGreaterLootBuffs();

            StartCoroutine(ChestOpenAnimations());

            StartCoroutine(SetChestHealth());

            dealDamage = true;
        }

        double scaledValue = chest1Health / scalingFactor;
        slider.value = (float)scaledValue;
        setText();
        isDealingAutoDamage = true;

    }

    public void SetHealth()
    {
        chest1Health = SelectChests.ChestHealth;
        double scaledValue = chest1Health / scalingFactor;
        slider.maxValue = (float)scaledValue;
        slider.value = slider.maxValue;

        setText();
    }

    public static bool spawnRewards;
    public double critDamageAmount;
    public double normalDamageAmount;
    public static bool hitCursor1Buff;
    public static bool hitCursor3Buff;
    public static bool hitCursor6Buff;
    public static bool hitCursor11Buff;
    public static bool hitCursor13Buff;
    public static bool hitCursor15Buff;
    public static bool hitCursor18Buff;

    public static bool hitSkillTreeCrit4;
    public static bool hitSkillTreeCrit5;

    public static bool hitSkillTreeActive4;
    public static bool hitSkillTreeActive5, hitSkillTreeActive7;

    public static bool hitGauntlet, hitGauntletTreasure;

    public bool activeClick, autoClick;
    public static bool lockPickOpen;
    public static bool hitHammerCrit;

    public static bool usedKey;
    public static bool hitTreasureKey;

    public static bool hitMedalGold, hitMedalTreasure;
    public float critDam, activeDam;

    public static bool hitAxe;

    public AudioManager audioManager;

    #region autoDamage/AutoClicker
    public void DealAutoDamage()
    {
        int randomAudio = Random.Range(1,4);
        if(randomAudio == 1) { if (AudioManager.audioMuted == 1) { audioManager.Play("ChestClick"); } }
        if (randomAudio == 2) { if (AudioManager.audioMuted == 1) { audioManager.Play("ChestClick2"); } }
        if (randomAudio == 3) { if (AudioManager.audioMuted == 1) { audioManager.Play("ChestClick3"); } }

        Stats.chestClicks += 1;
        float randomCrit = Random.Range(0, 100);

        #region cursor1 bonus
        //Cursor 1 bonus buff
        if (ClickPower.cursor1Equipped == 1)
        {
            int random = Random.Range(1, 101);
            if (random < 2) { hitCursor1Buff = true; Stats.coinsSpawnedFromClicks += 1; }
        }
        #endregion

        #region cursor18 bonus
        //Cursor 18 bonus buff
        if (ClickPower.cursor18Equipped == 1)
        {
            int random = Random.Range(1, 101);
            if (random < 6) { hitCursor18Buff = true; }
        }
        #endregion

        #region skill tree active 4
        if (SkillTree.active4Bought == 1)
        {
            float random = Random.Range(1, 101);
            if (random < SkillTree.active4GoldChance) { hitSkillTreeActive4 = true; }
        }
        #endregion

        #region skill tree active 5
        if (SkillTree.active5Bought == 1)
        {
            float random = Random.Range(1, 101);
            if (random < SkillTree.active5TreasureChance) { hitSkillTreeActive5 = true; }
        }
        #endregion

        #region skill tree active 7
        if (SkillTree.active7Bought == 1)
        {
            int random = Random.Range(1, 101);
            if (random == 5)
            {
                hitSkillTreeActive7 = true;
            }
        }
        #endregion

        #region skill tree active 6
        if (SkillTree.active6Bought == 1)
        {
            float random = Random.Range(0, 100);
            if (random <= SkillTree.active6InstantlyOpenChance) { chest1Health -= chest1Health; }
        }
        #endregion

        #region gauntletOfGreed

        if (UseConsumable.isGauntletActive == true)
        {
            int randomGauntlet = Random.Range(1, 101);
            if (randomGauntlet <= SpecialUpgradesButtons.gauntletGoldDropChance)
            {
                hitGauntlet = true;
            }

            int randomGauntletTreasure = Random.Range(1, 101);
            if (randomGauntletTreasure == 69) { hitGauntletTreasure = true; }

        }

        #endregion

        #region medalFoundBoff

        if (RareTreasures.medalFound == 1)
        {
            int randomMedalGold = Random.Range(1, 101);
            if (randomMedalGold <= 1) { hitMedalGold = true;  }
            float randomMedalTreasure = Random.Range(0, 100);
            if (randomMedalTreasure <= 0.2f) { hitMedalTreasure = true;  }
        }

        #endregion

        #region axe treasure buff
        if (RareTreasures.axeFound == 1)
        {
            float random = Random.Range(0, 100);
            if (random < 0.1f)
            {
                chest1Health -= chest1Health;
                hitAxe = true;
            }
        }
        #endregion

        if (randomCrit >= (ClickPower.critChance + UseConsumable.XPPotionCritChance + SkillTree.skillTreeCritChance + UseConsumable.scrollCritChanceBuff + RareTreasures.cookieCritChance + RareTreasures.swordCrit + UseConsumable.relicPermaCritChance))
        {
            chest1Health -= ((ClickPower.newActiveDamage) * (1 + UseConsumable.hammerDamage + UseConsumable.damagePotionBuff + UseConsumable.elixirDamageBuff + ClickPower.activeDamageMultiplier + SkillTree.skillTreeActiveDamage + RareTreasures.swordActive + RareTreasures.guitarActiveAndPassive + RareTreasures.cookieActive + UseConsumable.scrollActiveDamageBuff + UseConsumable.relicPermaActiveDamage + UpdateGame.damageBuffAmount - UpdateGame.damageDebuffAmount));

            normalDamageAmount = ((ClickPower.newActiveDamage) * (1 + UseConsumable.hammerDamage + UseConsumable.damagePotionBuff + UseConsumable.elixirDamageBuff + ClickPower.activeDamageMultiplier + SkillTree.skillTreeActiveDamage + RareTreasures.swordActive + RareTreasures.guitarActiveAndPassive + RareTreasures.cookieActive + UseConsumable.scrollActiveDamageBuff + UseConsumable.relicPermaActiveDamage + UpdateGame.damageBuffAmount - UpdateGame.damageDebuffAmount));
            critDamageAmount = 0;

            ShowDamageTextAutoClick();
        }

        if (randomCrit < (ClickPower.critChance + UseConsumable.XPPotionCritChance + SkillTree.skillTreeCritChance + UseConsumable.scrollCritChanceBuff + RareTreasures.cookieCritChance + RareTreasures.swordCrit + UseConsumable.relicPermaCritChance))
        {
            Stats.criticalHits += 1;

            //ActiveDamage total
            activeDam = ClickPower.activeDamageMultiplier + UseConsumable.hammerDamage + UseConsumable.damagePotionBuff + UseConsumable.elixirDamageBuff + SkillTree.skillTreeActiveDamage + RareTreasures.swordActive + RareTreasures.guitarActiveAndPassive + RareTreasures.cookieActive + UseConsumable.scrollActiveDamageBuff + UseConsumable.relicPermaActiveDamage + UpdateGame.damageBuffAmount - UpdateGame.damageDebuffAmount + 1;

            //Crit damage total
            critDam = RareTreasures.cookieCritDamage + SkillTree.skillTreeCritDamage + ClickPower.critDamage + UseConsumable.XPPotionCritDamage + UseConsumable.scrollCritDamageBuff + UseConsumable.relicPermaCritDamage + 1;


            //Damage dealth
            chest1Health -= (ClickPower.newActiveDamage * activeDam) * critDam;

            //Crit damage displayed on text
            critDamageAmount = (ClickPower.newActiveDamage * activeDam) * critDam;


            normalDamageAmount = 0;

            #region cursor 2 bonus
            if (ClickPower.cursor2Equipped == 1)
            {
                cursor2Buff += 1;
            }
            #endregion

            #region cursor3Buff
            if (ClickPower.cursor3Equipped == 1)
            {
                int random = Random.Range(1, 101);
                if (random < 26) { hitCursor3Buff = true; Stats.coinsSpawnedFromClicks += 1; }
            }
            #endregion

            #region cursor6Buff
            if (ClickPower.cursor6Equipped == 1)
            {
                int random = Random.Range(1, 101);
                if (random < 11) { hitCursor6Buff = true; }
            }
            #endregion

            if (ClickPower.cursor11Equipped == 1) { hitCursor11Buff = true; }

            if (ClickPower.cursor13Equipped == 1) { hitCursor13Buff = true; }

            if (ClickPower.cursor15Equipped == 1) { hitCursor15Buff = true; }

            #region skillTreeCrit4
            if (SkillTree.crit4Bought == 1)
            {
                int random = Random.Range(1, 101);
                if (random < SkillTree.crit4CritGoldChance) { hitSkillTreeCrit4 = true; }
            }
            #endregion

            #region skillTreeCrit5
            if (SkillTree.crit5Bought == 1)
            {
                int random = Random.Range(1, 101);
                if (random < SkillTree.crit5CritTreasureChance) { hitSkillTreeCrit5 = true; }
            }
            #endregion

            #region hammerBonus
            if (UseConsumable.bigHammerActive == true)
            {
                hitHammerCrit = true;
            }
            #endregion

            ShowDamageTextAutoCrit();

        }

        if (chest1Health <= 0 && dealDamage == false)
        {
            spawnRewards = true;

            #region cursor 4 bonus
            if (ClickPower.cursor4Equipped == 1)
            {
                cursor4Buff += 1;
            }
            #endregion

            #region cursor 10 bonus
            if (ClickPower.cursor10Equipped == 1)
            {
                cursor10Buff += 1;
            }
            #endregion

            #region skill tree auto 3
            if (SkillTree.autoDamage3Bought == 1)
            {
                SkillTree.skillTreeAutoDamage3ChestSpawn += 1;
            }
            #endregion

            #region skill tree auto 4
            if (SkillTree.autoDamage4Bought == 1)
            {
                SkillTree.skillTreeAutoDamage4TreasureDrop += 1;
            }
            #endregion

            #region skill tree auto 6
            if (SkillTree.autoDamage6Bought == 1)
            {
                SkillTree.skillTreeAuto6ChestDrops += 1;
            }
            #endregion

            if (reinforcedChestActive == true)
            {
                Stats.reinforedChestsOpened += 1;
            }

            if (enchantedGoldenChestIsActive == true)
            {
                Stats.enchantedGoldenChestsOpened += 1;
            }

            if (bossChestIsActive == true)
            {
                Stats.bossChestOpened += 1;
            }

            AllPRestigeGreaterLootBuffs();

            StartCoroutine(ChestOpenAnimations());

            StartCoroutine(SetChestHealth());
            dealDamage = true;
        }

        #region knife item
        if (UpdateGame.KnifeActive == true)
        {
            chest1Health -= chest1Health;
        }
        #endregion

        double scaledValue = chest1Health / scalingFactor;
        slider.value = (float)scaledValue;
        setText();
    }

    #endregion

    public void DealDamage()
    {
        if(isAutoClickerDetected == false)
        {
            int randomAudio = Random.Range(1, 6);
            if (randomAudio == 1) { if (AudioManager.audioMuted == 1) { audioManager.Play("ChestClick"); } }
            if (randomAudio == 2) { if (AudioManager.audioMuted == 1) { audioManager.Play("ChestClick2"); } }
            if (randomAudio == 3) { if (AudioManager.audioMuted == 1) { audioManager.Play("ChestClick3"); } }
            if (randomAudio == 4) { if (AudioManager.audioMuted == 1) { audioManager.Play("ChestClick4"); } }
            if (randomAudio == 5) { if (AudioManager.audioMuted == 1) { audioManager.Play("ChestClick5"); } }
        }
        if (isAutoClickerDetected == true)
        {
            int randomClick = Random.Range(1, 101);
            if (randomClick < 7) { if (AudioManager.audioMuted == 1) { audioManager.Play("ChestClick"); } }

            if (randomClick > 7 && randomClick < 14) { if (AudioManager.audioMuted == 1) { audioManager.Play("ChestClick2"); }  }

            if (randomClick > 93) { if (AudioManager.audioMuted == 1) { audioManager.Play("ChestClick3"); }  }

        }



        Stats.chestClicks += 1;
        float randomCrit = Random.Range(0, 100);


        #region cursor1 bonus
        //Cursor 1 bonus buff
        if (ClickPower.cursor1Equipped == 1)
        {
            int random = Random.Range(1, 101);
            if(random < 2) { hitCursor1Buff = true; Stats.coinsSpawnedFromClicks += 1; }
        }
        #endregion

        #region cursor18 bonus
        //Cursor 18 bonus buff
        if (ClickPower.cursor18Equipped == 1)
        {
            int random = Random.Range(1, 101);
            if (random < 6) { hitCursor18Buff = true; }
        }
        #endregion

        #region skill tree active 4
        if(SkillTree.active4Bought == 1)
        {
            float random = Random.Range(1,101);
            if(random < SkillTree.active4GoldChance) { hitSkillTreeActive4 = true; }
        }
        #endregion

        #region skill tree active 5
        if (SkillTree.active5Bought == 1)
        {
            float random = Random.Range(1, 101);
            if (random < SkillTree.active5TreasureChance) { hitSkillTreeActive5 = true; }
        }
        #endregion

        #region skill tree active 6
        if (SkillTree.active6Bought == 1)
        {
            float random = Random.Range(0, 100);
            if (random <= SkillTree.active6InstantlyOpenChance) { chest1Health -= chest1Health; }
        }
        #endregion

        #region gauntletOfGreed

        if(UseConsumable.isGauntletActive == true)
        {
            int randomGauntlet = Random.Range(1, 101);
            if (randomGauntlet <= SpecialUpgradesButtons.gauntletGoldDropChance)
            {
                hitGauntlet = true;
            }

            int randomGauntletTreasure = Random.Range(1, 101);
            if(randomGauntletTreasure  == 69) { hitGauntletTreasure = true; }

        }

        #endregion

        #region medalFoundBoff

        if(RareTreasures.medalFound == 1)
        {
            int randomMedalGold = Random.Range(1, 101);
            if(randomMedalGold <= 1) { hitMedalGold = true; }
            float randomMedalTreasure = Random.Range(0, 100);
            if (randomMedalTreasure <= 0.2f) { hitMedalTreasure = true;}
        }

        #endregion

        #region skill tree active 7
        if(SkillTree.active7Bought == 1)
        {
            int random = Random.Range(1, 101);
            if(random == 5)
            {
                hitSkillTreeActive7 = true;
            }
        }
        #endregion

        #region axe treasure buff
        if (RareTreasures.axeFound == 1)
        {
            float random = Random.Range(0,100);
            if(random < 0.1f)
            {
                chest1Health -= chest1Health;
                hitAxe = true;
            }
        }
        #endregion

        if (randomCrit >= (ClickPower.critChance + UseConsumable.XPPotionCritChance + SkillTree.skillTreeCritChance + UseConsumable.scrollCritChanceBuff + RareTreasures.cookieCritChance + RareTreasures.swordCrit + UseConsumable.relicPermaCritChance))
        {
            chest1Health -= ((ClickPower.newActiveDamage) * (1 + UseConsumable.hammerDamage + UseConsumable.damagePotionBuff + UseConsumable.elixirDamageBuff + ClickPower.activeDamageMultiplier + SkillTree.skillTreeActiveDamage + RareTreasures.swordActive + RareTreasures.guitarActiveAndPassive + RareTreasures.cookieActive + UseConsumable.scrollActiveDamageBuff + UseConsumable.relicPermaActiveDamage + UpdateGame.damageBuffAmount - UpdateGame.damageDebuffAmount));

            normalDamageAmount = ((ClickPower.newActiveDamage) * (1 + UseConsumable.hammerDamage + UseConsumable.damagePotionBuff + UseConsumable.elixirDamageBuff + ClickPower.activeDamageMultiplier + SkillTree.skillTreeActiveDamage + RareTreasures.swordActive + RareTreasures.guitarActiveAndPassive + RareTreasures.cookieActive + UseConsumable.scrollActiveDamageBuff + UseConsumable.relicPermaActiveDamage + UpdateGame.damageBuffAmount - UpdateGame.damageDebuffAmount));
            critDamageAmount = 0;

            ShowDamageText();
        }

        if (randomCrit < (ClickPower.critChance + UseConsumable.XPPotionCritChance + SkillTree.skillTreeCritChance + UseConsumable.scrollCritChanceBuff + RareTreasures.cookieCritChance + RareTreasures.swordCrit + UseConsumable.relicPermaCritChance))
        {
            Stats.criticalHits += 1;

            //ActiveDamage total
            activeDam = ClickPower.activeDamageMultiplier + UseConsumable.hammerDamage + UseConsumable.damagePotionBuff + UseConsumable.elixirDamageBuff + SkillTree.skillTreeActiveDamage + RareTreasures.swordActive + RareTreasures.guitarActiveAndPassive + RareTreasures.cookieActive + UseConsumable.scrollActiveDamageBuff + UseConsumable.relicPermaActiveDamage + UpdateGame.damageBuffAmount - UpdateGame.damageDebuffAmount + 1;

            //Crit damage total
            critDam = RareTreasures.cookieCritDamage + SkillTree.skillTreeCritDamage + ClickPower.critDamage + UseConsumable.XPPotionCritDamage + UseConsumable.scrollCritDamageBuff + UseConsumable.relicPermaCritDamage  + 1;


            //Damage dealth
            chest1Health -= (ClickPower.newActiveDamage * activeDam) * critDam;

            //Crit damage displayed on text
            critDamageAmount = (ClickPower.newActiveDamage * activeDam) * critDam;


            normalDamageAmount = 0;

            #region cursor 2 bonus
            if (ClickPower.cursor2Equipped == 1)
            {
                cursor2Buff += 1;
            }
            #endregion

            #region cursor3Buff
            if (ClickPower.cursor3Equipped == 1)
            {
                int random = Random.Range(1, 101);
                if (random < 26) { hitCursor3Buff = true; Stats.coinsSpawnedFromClicks += 1; }
            }
            #endregion

            #region cursor6Buff
            if (ClickPower.cursor6Equipped == 1)
            {
                int random = Random.Range(1, 101);
                if(random < 8) { hitCursor6Buff = true; }
            }
            #endregion

            if (ClickPower.cursor11Equipped == 1) { hitCursor11Buff = true; }

            if(ClickPower.cursor13Equipped == 1) { hitCursor13Buff = true; }

            if(ClickPower.cursor15Equipped == 1) { hitCursor15Buff = true; }

            #region skillTreeCrit4
            if (SkillTree.crit4Bought == 1)
            {
                int random = Random.Range(1,101);
                if(random < SkillTree.crit4CritGoldChance) { hitSkillTreeCrit4 = true; }
            }
            #endregion

            #region skillTreeCrit5
            if (SkillTree.crit5Bought == 1)
            {
                int random = Random.Range(1, 101);
                if (random < SkillTree.crit5CritTreasureChance) { hitSkillTreeCrit5 = true; }
            }
            #endregion

            #region hammerBonus
            if (UseConsumable.bigHammerActive == true)
            {
                hitHammerCrit = true;
            }
            #endregion

            ShowDamageTextCrit();

        }

        if (chest1Health <= 0 && dealDamage == false) 
        {
            spawnRewards = true;

            #region cursor 4 bonus
            if (ClickPower.cursor4Equipped == 1)
            {
                cursor4Buff += 1;
            }
            #endregion

            #region cursor 10 bonus
            if (ClickPower.cursor10Equipped == 1)
            {
                cursor10Buff += 1;
            }
            #endregion

            #region skill tree auto 3
            if (SkillTree.autoDamage3Bought == 1)
            {
                SkillTree.skillTreeAutoDamage3ChestSpawn += 1;
            }
            #endregion

            #region skill tree auto 4
            if (SkillTree.autoDamage4Bought == 1)
            {
                SkillTree.skillTreeAutoDamage4TreasureDrop += 1;
            }
            #endregion

            #region skill tree auto 6
            if (SkillTree.autoDamage6Bought == 1)
            {
                SkillTree.skillTreeAuto6ChestDrops += 1;
            }
            #endregion

            if (reinforcedChestActive == true)
            {
                Stats.reinforedChestsOpened += 1;
            }

            if (enchantedGoldenChestIsActive == true)
            {
                Stats.enchantedGoldenChestsOpened += 1;
            }

            if (bossChestIsActive == true)
            {
                Stats.bossChestOpened += 1;
            }

            AllPRestigeGreaterLootBuffs();

            StartCoroutine(ChestOpenAnimations());

            StartCoroutine(SetChestHealth());
            dealDamage = true;
        }

        #region knife item
        if (UpdateGame.KnifeActive == true)
        {
            chest1Health -= chest1Health;
        }
        #endregion

        double scaledValue = chest1Health / scalingFactor;
        slider.value = (float)scaledValue;
        setText();
    }

    #region allChestAnimations
    public Button chestAnimButton;
    public static bool openFinalChest;
    public static bool enchantedGoldenChestIsActive, bossChestIsActive;
    public GameObject enchantedGoldenChest, anchantedGoldenChestOpen, bossChest, bossChestOpen;
    public static bool enchantedGoldenChestOpened, bossChestOpened, bossChestReward;

    IEnumerator ChestOpenAnimations()
    {
        if(SelectChests.checkOverlap == true)
        {
            CheckOverlapChests();
            SelectChests.checkOverlap = false;
        }

        if(SelectChests.chest40Active == true)
        {
            openFinalChest = true;
        }
        chestAnimButton.onClick.Invoke();
        Stats.chestOpened += 1;

        if (AudioManager.audioMuted == 1) {
            int random = Random.Range(1, 4);
            if(random == 1) { audioManager.Play("ChestOpenSound1"); }
            if (random == 2) { audioManager.Play("ChestOpenSound2"); }
            if (random == 3) { audioManager.Play("ChestOpenSound3"); }
        }

        if (enchantedGoldenChestIsActive == true)
        {
            anchantedGoldenChestOpen.GetComponent<Animation>().Play("EnchantedGoldenChestOpenAnim");
            enchantedGoldenChestOpened = true;
            enchantedGoldenChestIsActive = false;
        }
        if(bossChestIsActive == true)
        {
            bossChestOpen.GetComponent<Animation>().Play("BossChestOpenAnim");
            bossChestOpened = true;
            bossChestReward = true;
            bossChestIsActive = false;
        }


         #region NormalChestSpawn
        if (enchantedGoldenChestIsActive == false || bossChestIsActive == false)
        {
            bossChest.SetActive(false); enchantedGoldenChest.SetActive(false);
            if (SelectChests.chest1Active == true)
            {
                chest1.SetActive(false);
                chest1Open.SetActive(true);
                chest1Open.GetComponent<Animation>().Play("Chest1OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest1Open.SetActive(false);
                chest1.SetActive(true);
                chest1.GetComponent<Animation>().Play("FirstChestOpen");
            }

            if (SelectChests.chest2Active == true)
            {
                chest2.SetActive(false);
                chest2Open.SetActive(true);
                chest2Open.GetComponent<Animation>().Play("Chest2OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest2Open.SetActive(false);
                chest2.SetActive(true);
                chest2.GetComponent<Animation>().Play("Chest2Down");
            }

            if (SelectChests.chest3Active == true)
            {
                chest3.SetActive(false);
                chest3Open.SetActive(true);
                chest3Open.GetComponent<Animation>().Play("Chest3OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest3Open.SetActive(false);
                chest3.SetActive(true);
                chest3.GetComponent<Animation>().Play("Chest3Down");
            }

            if (SelectChests.chest4Active == true)
            {
                chest4.SetActive(false);
                chest4Open.SetActive(true);
                chest4Open.GetComponent<Animation>().Play("Chest4OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest4Open.SetActive(false);
                chest4.SetActive(true);
                chest4.GetComponent<Animation>().Play("Chest4Down");
            }

            if (SelectChests.chest5Active == true)
            {
                chest5.SetActive(false);
                chest5Open.SetActive(true);
                chest5Open.GetComponent<Animation>().Play("Chest5OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest5Open.SetActive(false);
                chest5.SetActive(true);
                chest5.GetComponent<Animation>().Play("Chest5Down");
            }

            if (SelectChests.chest6Active == true)
            {
                chest6.SetActive(false);
                chest6Open.SetActive(true);
                chest6Open.GetComponent<Animation>().Play("Chest6OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest6Open.SetActive(false);
                chest6.SetActive(true);
                chest6.GetComponent<Animation>().Play("Chest6Down");
            }

            if (SelectChests.chest7Active == true)
            {
                chest7.SetActive(false);
                chest7Open.SetActive(true);
                chest7Open.GetComponent<Animation>().Play("Chest7OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest7Open.SetActive(false);
                chest7.SetActive(true);
                chest7.GetComponent<Animation>().Play("Chest7Down");
            }

            if (SelectChests.chest8Active == true)
            {
                chest8.SetActive(false);
                chest8Open.SetActive(true);
                chest8Open.GetComponent<Animation>().Play("Chest8OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest8Open.SetActive(false);
                chest8.SetActive(true);
                chest8.GetComponent<Animation>().Play("Chest8Down");
            }

            if (SelectChests.chest9Active == true)
            {
                chest9.SetActive(false);
                chest9Open.SetActive(true);
                chest9Open.GetComponent<Animation>().Play("Chest9OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest9Open.SetActive(false);
                chest9.SetActive(true);
                chest9.GetComponent<Animation>().Play("Chest9Down");
            }

            if (SelectChests.chest10Active == true)
            {
                chest10.SetActive(false);
                chest10Open.SetActive(true);
                chest10Open.GetComponent<Animation>().Play("Chest10OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest10Open.SetActive(false);
                chest10.SetActive(true);
                chest10.GetComponent<Animation>().Play("Chest10Down");
            }

            if (SelectChests.chest11Active == true)
            {
                chest11.SetActive(false);
                chest11Open.SetActive(true);
                chest11Open.GetComponent<Animation>().Play("Chest11OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest11Open.SetActive(false);
                chest11.SetActive(true);
                chest11.GetComponent<Animation>().Play("Chest11Down");
            }

            if (SelectChests.chest12Active == true)
            {
                chest12.SetActive(false);
                chest12Open.SetActive(true);
                chest12Open.GetComponent<Animation>().Play("Chest12OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest12Open.SetActive(false);
                chest12.SetActive(true);
                chest12.GetComponent<Animation>().Play("Chest12Down");
            }

            if (SelectChests.chest13Active == true)
            {
                chest13.SetActive(false);
                chest13Open.SetActive(true);
                chest13Open.GetComponent<Animation>().Play("Chest13OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest13Open.SetActive(false);
                chest13.SetActive(true);
                chest13.GetComponent<Animation>().Play("Chest13Down");
            }

            if (SelectChests.chest14Active == true)
            {
                chest14.SetActive(false);
                chest14Open.SetActive(true);
                chest14Open.GetComponent<Animation>().Play("Chest14OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest14Open.SetActive(false);
                chest14.SetActive(true);
                chest14.GetComponent<Animation>().Play("Chest14Down");
            }

            if (SelectChests.chest15Active == true)
            {
                chest15.SetActive(false);
                chest15Open.SetActive(true);
                chest15Open.GetComponent<Animation>().Play("Chest15OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest15Open.SetActive(false);
                chest15.SetActive(true);
                chest15.GetComponent<Animation>().Play("Chest15Down");
            }

            if (SelectChests.chest16Active == true)
            {
                chest16.SetActive(false);
                chest16Open.SetActive(true);
                chest16Open.GetComponent<Animation>().Play("Chest16OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest16Open.SetActive(false);
                chest16.SetActive(true);
                chest16.GetComponent<Animation>().Play("Chest16Down");
            }

            if (SelectChests.chest17Active == true)
            {
                chest17.SetActive(false);
                chest17Open.SetActive(true);
                chest17Open.GetComponent<Animation>().Play("Chest17OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest17Open.SetActive(false);
                chest17.SetActive(true);
                chest17.GetComponent<Animation>().Play("Chest17Down");
            }

            if (SelectChests.chest18Active == true)
            {
                chest18.SetActive(false);
                chest18Open.SetActive(true);
                chest18Open.GetComponent<Animation>().Play("Chest18OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest18Open.SetActive(false);
                chest18.SetActive(true);
                chest18.GetComponent<Animation>().Play("Chest18Down");
            }

            if (SelectChests.chest19Active == true)
            {
                chest19.SetActive(false);
                chest19Open.SetActive(true);
                chest19Open.GetComponent<Animation>().Play("Chest19OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest19Open.SetActive(false);
                chest19.SetActive(true);
                chest19.GetComponent<Animation>().Play("Chest19Down");
            }

            if (SelectChests.chest20Active == true)
            {
                chest20.SetActive(false);
                chest20Open.SetActive(true);
                chest20Open.GetComponent<Animation>().Play("Chest20OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest20Open.SetActive(false);
                chest20.SetActive(true);
                chest20.GetComponent<Animation>().Play("Chest20Down");
            }

            if (SelectChests.chest21Active == true)
            {
                chest21.SetActive(false);
                chest21Open.SetActive(true);
                chest21Open.GetComponent<Animation>().Play("Chest21OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest21Open.SetActive(false);
                chest21.SetActive(true);
                chest21.GetComponent<Animation>().Play("Chest21Down");
            }

            if (SelectChests.chest22Active == true)
            {
                chest22.SetActive(false);
                chest22Open.SetActive(true);
                chest22Open.GetComponent<Animation>().Play("Chest22OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest22Open.SetActive(false);
                chest22.SetActive(true);
                chest22.GetComponent<Animation>().Play("Chest22Down");
            }

            if (SelectChests.chest23Active == true)
            {
                chest23.SetActive(false);
                chest23Open.SetActive(true);
                chest23Open.GetComponent<Animation>().Play("Chest23OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest23Open.SetActive(false);
                chest23.SetActive(true);
                chest23.GetComponent<Animation>().Play("Chest23Down");
            }

            if (SelectChests.chest24Active == true)
            {
                chest24.SetActive(false);
                chest24Open.SetActive(true);
                chest24Open.GetComponent<Animation>().Play("Chest24OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest24Open.SetActive(false);
                chest24.SetActive(true);
                chest24.GetComponent<Animation>().Play("Chest24Down");
            }

            if (SelectChests.chest25Active == true)
            {
                chest25.SetActive(false);
                chest25Open.SetActive(true);
                chest25Open.GetComponent<Animation>().Play("Chest25OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest25Open.SetActive(false);
                chest25.SetActive(true);
                chest25.GetComponent<Animation>().Play("Chest25Down");
            }

            if (SelectChests.chest26Active == true)
            {
                chest26.SetActive(false);
                chest26Open.SetActive(true);
                chest26Open.GetComponent<Animation>().Play("Chest26OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest26Open.SetActive(false);
                chest26.SetActive(true);
                chest26.GetComponent<Animation>().Play("Chest26Down");
            }

            if (SelectChests.chest27Active == true)
            {
                chest27.SetActive(false);
                chest27Open.SetActive(true);
                chest27Open.GetComponent<Animation>().Play("Chest27OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest27Open.SetActive(false);
                chest27.SetActive(true);
                chest27.GetComponent<Animation>().Play("Chest27Down");
            }

            if (SelectChests.chest28Active == true)
            {
                chest28.SetActive(false);
                chest28Open.SetActive(true);
                chest28Open.GetComponent<Animation>().Play("Chest27OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest28Open.SetActive(false);
                chest28.SetActive(true);
                chest28.GetComponent<Animation>().Play("Chest27Down");
            }

            if (SelectChests.chest29Active == true)
            {
                chest29.SetActive(false);
                chest29Open.SetActive(true);
                chest29Open.GetComponent<Animation>().Play("Chest29OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest29Open.SetActive(false);
                chest29.SetActive(true);
                chest29.GetComponent<Animation>().Play("Chest29Down");
            }

            if (SelectChests.chest30Active == true)
            {
                chest30.SetActive(false);
                chest30Open.SetActive(true);
                chest30Open.GetComponent<Animation>().Play("Chest30OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest30Open.SetActive(false);
                chest30.SetActive(true);
                chest30.GetComponent<Animation>().Play("Chest27Down");
            }

            if (SelectChests.chest31Active == true)
            {
                chest31.SetActive(false);
                chest31Open.SetActive(true);
                chest31Open.GetComponent<Animation>().Play("Chest27OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest31Open.SetActive(false);
                chest31.SetActive(true);
                chest31.GetComponent<Animation>().Play("Chest27Down");
            }

            if (SelectChests.chest32Active == true)
            {
                chest32.SetActive(false);
                chest32Open.SetActive(true);
                chest32Open.GetComponent<Animation>().Play("Chest26OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest32Open.SetActive(false);
                chest32.SetActive(true);
                chest32.GetComponent<Animation>().Play("Chest26Down");
            }

            if (SelectChests.chest33Active == true)
            {
                chest33.SetActive(false);
                chest33Open.SetActive(true);
                chest33Open.GetComponent<Animation>().Play("Chest27OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest33Open.SetActive(false);
                chest33.SetActive(true);
                chest33.GetComponent<Animation>().Play("Chest27Down");
            }

            if (SelectChests.chest34Active == true)
            {
                chest34.SetActive(false);
                chest34Open.SetActive(true);
                chest34Open.GetComponent<Animation>().Play("Chest34OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest34Open.SetActive(false);
                chest34.SetActive(true);
                chest34.GetComponent<Animation>().Play("Chest34Down");
            }

            if (SelectChests.chest35Active == true)
            {
                chest35.SetActive(false);
                chest35Open.SetActive(true);
                chest35Open.GetComponent<Animation>().Play("Chest35OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest35Open.SetActive(false);
                chest35.SetActive(true);
                chest35.GetComponent<Animation>().Play("Chest35Down");
            }

            if (SelectChests.chest36Active == true)
            {
                chest36.SetActive(false);
                chest36Open.SetActive(true);
                chest36Open.GetComponent<Animation>().Play("Chest34OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest36Open.SetActive(false);
                chest36.SetActive(true);
                chest36.GetComponent<Animation>().Play("Chest34Down");
            }

            if (SelectChests.chest37Active == true)
            {
                chest37.SetActive(false);
                chest37Open.SetActive(true);
                chest37Open.GetComponent<Animation>().Play("Chest38OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest37Open.SetActive(false);
                chest37.SetActive(true);
                chest37.GetComponent<Animation>().Play("Chest38Down");
            }

            if (SelectChests.chest38Active == true)
            {
                chest38.SetActive(false);
                chest38Open.SetActive(true);
                chest38Open.GetComponent<Animation>().Play("Chest38OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest38Open.SetActive(false);
                chest38.SetActive(true);
                chest38.GetComponent<Animation>().Play("Chest38Down");
            }

            if (SelectChests.chest39Active == true)
            {
                chest39.SetActive(false);
                chest39Open.SetActive(true);
                chest39Open.GetComponent<Animation>().Play("Chest38OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest39Open.SetActive(false);
                chest39.SetActive(true);
                chest39.GetComponent<Animation>().Play("Chest38Down");
            }

            if (SelectChests.chest40Active == true)
            {
                chest40.SetActive(false);
                chest40Open.SetActive(true);
                chest40Open.GetComponent<Animation>().Play("Chest38OpenAnim");
                yield return new WaitForSeconds(0.25f);
                chest40Open.SetActive(false);
                chest40.SetActive(true);
                chest40.GetComponent<Animation>().Play("Chest38Down");
            }
        }
        #endregion


        if (UpdateGame.newChests1Bought == 1)
        {
            float randomSpecialChest = Random.Range(0.0f, 100.0f);
            if (randomSpecialChest >= UpdateGame.enchantedGoldenChestChance)
            {
                enchantedGoldenChestIsActive = true;
                StopAnims();
                SetAllChestsFalse();
                enchantedGoldenChest.SetActive(true);
                enchantedGoldenChest.GetComponent<Animation>().Play("EnchantedGoldenChestDown");
            }

            if (randomSpecialChest <= UpdateGame.bossChestChance)
            {
                bossChestIsActive = true;
                StopAnims();
                SetAllChestsFalse();
                bossChest.SetActive(true);
                bossChest.GetComponent<Animation>().Play("BossChestDown");
            }

            //Debug.Log(randomSpecialChest);

            //Debug.Log(UpdateGame.enchantedGoldenChestChance);
            //Debug.Log(UpdateGame.bossChestChance);
        }
    }
    #endregion

    public void CheckOverlapChests()
    {
        if(SelectChests.chest1Active == true) { SetOpenChestInactive(1); }
        if (SelectChests.chest2Active == true) { SetOpenChestInactive(2); }
        if (SelectChests.chest3Active == true) { SetOpenChestInactive(3); }
        if (SelectChests.chest4Active == true) { SetOpenChestInactive(4); }
        if (SelectChests.chest5Active == true) { SetOpenChestInactive(5); }
        if (SelectChests.chest6Active == true) { SetOpenChestInactive(6); }
        if (SelectChests.chest7Active == true) { SetOpenChestInactive(7); }
        if (SelectChests.chest8Active == true) { SetOpenChestInactive(8); }
        if (SelectChests.chest9Active == true) { SetOpenChestInactive(9); }
        if (SelectChests.chest10Active == true) { SetOpenChestInactive(10); }
        if (SelectChests.chest11Active == true) { SetOpenChestInactive(11); }
        if (SelectChests.chest12Active == true) { SetOpenChestInactive(12); }
        if (SelectChests.chest13Active == true) { SetOpenChestInactive(13); }
        if (SelectChests.chest14Active == true) { SetOpenChestInactive(14); }
        if (SelectChests.chest15Active == true) { SetOpenChestInactive(15); }
        if (SelectChests.chest16Active == true) { SetOpenChestInactive(16); }
        if (SelectChests.chest17Active == true) { SetOpenChestInactive(17); }
        if (SelectChests.chest18Active == true) { SetOpenChestInactive(18); }
        if (SelectChests.chest19Active == true) { SetOpenChestInactive(19); }
        if (SelectChests.chest20Active == true) { SetOpenChestInactive(20); }
        if (SelectChests.chest21Active == true) { SetOpenChestInactive(21); }
        if (SelectChests.chest22Active == true) { SetOpenChestInactive(22); }
        if (SelectChests.chest23Active == true) { SetOpenChestInactive(23); }
        if (SelectChests.chest24Active == true) { SetOpenChestInactive(24); }
        if (SelectChests.chest25Active == true) { SetOpenChestInactive(25); }
        if (SelectChests.chest26Active == true) { SetOpenChestInactive(26); }
        if (SelectChests.chest27Active == true) { SetOpenChestInactive(27); }
        if (SelectChests.chest28Active == true) { SetOpenChestInactive(28); }
        if (SelectChests.chest29Active == true) { SetOpenChestInactive(29); }
        if (SelectChests.chest30Active == true) { SetOpenChestInactive(30); }
        if (SelectChests.chest31Active == true) { SetOpenChestInactive(31); }
        if (SelectChests.chest32Active == true) { SetOpenChestInactive(32); }
        if (SelectChests.chest33Active == true) { SetOpenChestInactive(33); }
        if (SelectChests.chest34Active == true) { SetOpenChestInactive(34); }
        if (SelectChests.chest35Active == true) { SetOpenChestInactive(35); }
        if (SelectChests.chest36Active == true) { SetOpenChestInactive(36); }
        if (SelectChests.chest37Active == true) { SetOpenChestInactive(37); }
        if (SelectChests.chest38Active == true) { SetOpenChestInactive(38); }
        if (SelectChests.chest39Active == true) { SetOpenChestInactive(39); }
        if (SelectChests.chest40Active == true) { SetOpenChestInactive(40); }
    }

    #region Set Open chest inactive
    public void SetOpenChestInactive(int chestNumber)
    {
        if (chest1Open.activeInHierarchy == true && chestNumber != 1) { chest1Open.SetActive(false); }
        if (chest2Open.activeInHierarchy == true && chestNumber != 2) { chest2Open.SetActive(false); }
        if (chest3Open.activeInHierarchy == true && chestNumber != 3) { chest3Open.SetActive(false); }
        if (chest4Open.activeInHierarchy == true && chestNumber != 4) { chest4Open.SetActive(false); }
        if (chest5Open.activeInHierarchy == true && chestNumber != 5) { chest5Open.SetActive(false); }
        if (chest6Open.activeInHierarchy == true && chestNumber != 6) { chest6Open.SetActive(false); }
        if (chest7Open.activeInHierarchy == true && chestNumber != 7) { chest7Open.SetActive(false); }
        if (chest8Open.activeInHierarchy == true && chestNumber != 8) { chest8Open.SetActive(false); }
        if (chest9Open.activeInHierarchy == true && chestNumber != 9) { chest9Open.SetActive(false); }
        if (chest10Open.activeInHierarchy == true && chestNumber != 10) { chest10Open.SetActive(false); }
        if (chest11Open.activeInHierarchy == true && chestNumber != 11) { chest11Open.SetActive(false); }
        if (chest12Open.activeInHierarchy == true && chestNumber != 12) { chest12Open.SetActive(false); }
        if (chest13Open.activeInHierarchy == true && chestNumber != 13) { chest13Open.SetActive(false); }
        if (chest14Open.activeInHierarchy == true && chestNumber != 14) { chest14Open.SetActive(false); }
        if (chest15Open.activeInHierarchy == true && chestNumber != 15) { chest15Open.SetActive(false); }
        if (chest16Open.activeInHierarchy == true && chestNumber != 16) { chest16Open.SetActive(false); }
        if (chest17Open.activeInHierarchy == true && chestNumber != 17) { chest17Open.SetActive(false); }
        if (chest18Open.activeInHierarchy == true && chestNumber != 18) { chest18Open.SetActive(false); }
        if (chest19Open.activeInHierarchy == true && chestNumber != 19) { chest19Open.SetActive(false); }
        if (chest20Open.activeInHierarchy == true && chestNumber != 20) { chest20Open.SetActive(false); }
        if (chest21Open.activeInHierarchy == true && chestNumber != 21) { chest21Open.SetActive(false); }
        if (chest22Open.activeInHierarchy == true && chestNumber != 22) { chest22Open.SetActive(false); }
        if (chest23Open.activeInHierarchy == true && chestNumber != 23) { chest23Open.SetActive(false); }
        if (chest24Open.activeInHierarchy == true && chestNumber != 24) { chest24Open.SetActive(false); }
        if (chest25Open.activeInHierarchy == true && chestNumber != 25) { chest25Open.SetActive(false); }
        if (chest26Open.activeInHierarchy == true && chestNumber != 26) { chest26Open.SetActive(false); }
        if (chest27Open.activeInHierarchy == true && chestNumber != 27) { chest27Open.SetActive(false); }
        if (chest28Open.activeInHierarchy == true && chestNumber != 28) { chest28Open.SetActive(false); }
        if (chest29Open.activeInHierarchy == true && chestNumber != 29) { chest29Open.SetActive(false); }
        if (chest30Open.activeInHierarchy == true && chestNumber != 30) { chest30Open.SetActive(false); }
        if (chest31Open.activeInHierarchy == true && chestNumber != 31) { chest31Open.SetActive(false); }
        if (chest32Open.activeInHierarchy == true && chestNumber != 32) { chest32Open.SetActive(false); }
        if (chest33Open.activeInHierarchy == true && chestNumber != 33) { chest33Open.SetActive(false); }
        if (chest34Open.activeInHierarchy == true && chestNumber != 34) { chest34Open.SetActive(false); }
        if (chest35Open.activeInHierarchy == true && chestNumber != 35) { chest35Open.SetActive(false); }
        if (chest36Open.activeInHierarchy == true && chestNumber != 36) { chest36Open.SetActive(false); }
        if (chest37Open.activeInHierarchy == true && chestNumber != 37) { chest37Open.SetActive(false); }
        if (chest38Open.activeInHierarchy == true && chestNumber != 38) { chest38Open.SetActive(false); }
        if (chest39Open.activeInHierarchy == true && chestNumber != 39) { chest39Open.SetActive(false); }
        if (chest40Open.activeInHierarchy == true && chestNumber != 40) { chest40Open.SetActive(false); }
    }
    #endregion

    public TMP_FontAsset korean, english, russian, japanese, chinese;

    #region showDamage and crit text
    public void ShowDamageText()
    {
        GameObject text = ObjectPooling.instance.GetTextFromPool();
        if (Localization.EnglishLanguageChosen == 1) { text.GetComponent<TextMeshProUGUI>().font = english; }
        if (Localization.RussianLanguageChosen == 1) { text.GetComponent<TextMeshProUGUI>().font = russian; }
        if (Localization.JapaneseLanguageChosen == 1) { text.GetComponent<TextMeshProUGUI>().font = japanese; }
        if (Localization.ChineseLanguageChosen == 1) { text.GetComponent<TextMeshProUGUI>().font = chinese; }
        if (Localization.KoreanLanguageChosen == 1) { text.GetComponent<TextMeshProUGUI>().font = korean; }

        text.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        text.transform.position = new Vector3(text.transform.position.x, text.transform.position.y, 1); 

        text.GetComponent<TextMeshProUGUI>().text = "-" + TotalGoldAmount.FormatCoinsDoubleOneLetter(critDamageAmount + normalDamageAmount);
        text.GetComponent<Animation>().Play();

        StartCoroutine(ReturnTextFromPoolDelayed(text, 0.5f));

        activeClick = false;
    }

    public void ShowDamageTextCrit()
    {
        GameObject text = ObjectPooling.instance.GetTextFromPool();

        if (Localization.EnglishLanguageChosen == 1) { text.GetComponent<TextMeshProUGUI>().font = english; }
        if (Localization.RussianLanguageChosen == 1) { text.GetComponent<TextMeshProUGUI>().font = russian; }
        if (Localization.JapaneseLanguageChosen == 1) { text.GetComponent<TextMeshProUGUI>().font = japanese; }
        if (Localization.ChineseLanguageChosen == 1) { text.GetComponent<TextMeshProUGUI>().font = chinese; }
        if (Localization.KoreanLanguageChosen == 1) { text.GetComponent<TextMeshProUGUI>().font = korean; }

        text.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        text.transform.position = new Vector3(text.transform.position.x, text.transform.position.y, 1);

        text.GetComponent<TextMeshProUGUI>().text = Localization.crit + " -" + TotalGoldAmount.FormatCoinsDoubleOneLetter(critDamageAmount + normalDamageAmount);

        text.GetComponent<Animation>().Play();

        StartCoroutine(ReturnTextFromPoolDelayed(text, 0.65f));

        activeClick = false;
    }


    //AutoClick
    public void ShowDamageTextAutoClick()
    {
        GameObject text = ObjectPooling.instance.GetTextFromPool();
            text.transform.position = new Vector3(0, 0, 0);

        if (Localization.EnglishLanguageChosen == 1) { text.GetComponent<TextMeshProUGUI>().font = english; }
        if (Localization.RussianLanguageChosen == 1) { text.GetComponent<TextMeshProUGUI>().font = russian; }
        if (Localization.JapaneseLanguageChosen == 1) { text.GetComponent<TextMeshProUGUI>().font = japanese; }
        if (Localization.ChineseLanguageChosen == 1) { text.GetComponent<TextMeshProUGUI>().font = chinese; }
        if (Localization.KoreanLanguageChosen == 1) { text.GetComponent<TextMeshProUGUI>().font = korean; }

        text.GetComponent<TextMeshProUGUI>().text = "-" + TotalGoldAmount.FormatCoinsDoubleOneLetter(critDamageAmount + normalDamageAmount);
        text.GetComponent<Animation>().Play();

        StartCoroutine(ReturnTextFromPoolDelayed(text, 0.5f));

        autoClick = false;
    }

    public void ShowDamageTextAutoCrit()
    {
        GameObject text = ObjectPooling.instance.GetTextFromPool();
        text.transform.position = new Vector3(0, 0, 0);

        if (Localization.EnglishLanguageChosen == 1) { text.GetComponent<TextMeshProUGUI>().font = english; }
        if (Localization.RussianLanguageChosen == 1) { text.GetComponent<TextMeshProUGUI>().font = russian; }
        if (Localization.JapaneseLanguageChosen == 1) { text.GetComponent<TextMeshProUGUI>().font = japanese; }
        if (Localization.ChineseLanguageChosen == 1) { text.GetComponent<TextMeshProUGUI>().font = chinese; }
        if (Localization.KoreanLanguageChosen == 1) { text.GetComponent<TextMeshProUGUI>().font = korean; }

        text.GetComponent<TextMeshProUGUI>().text = Localization.crit + " -" + TotalGoldAmount.FormatCoinsDoubleOneLetter(critDamageAmount + normalDamageAmount);

        text.GetComponent<Animation>().Play();

        StartCoroutine(ReturnTextFromPoolDelayed(text, 0.65f));

        autoClick = false;
    }



    private IEnumerator ReturnTextFromPoolDelayed(GameObject text, float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        ObjectPooling.instance.ReturnTextFromPool(text);
    }
    #endregion

    #region AllGreasterLootPtrestigeBuffs
    public void AllPRestigeGreaterLootBuffs()
    {
        if(UpdateGame.greaterLoot1Bought == 1)
        {
            prestigeGreaterLoot1Amount += 1;
            if(prestigeGreaterLoot1Amount == 10) { prestigeGreaterLoot1Buff = true;  prestigeGreaterLoot1Amount = 0; }
        }

        if (UpdateGame.greaterLoot2Bought == 1)
        {
            prestigeGreaterLoot2Amount += 1;
            if (prestigeGreaterLoot2Amount == 19) { prestigeGreaterLoot2Buff = true;  prestigeGreaterLoot2Amount = 0; }
        }

        if (UpdateGame.greaterLoot3Bought == 1)
        {
            prestigeGreaterLoot3Amount += 1;
            if (prestigeGreaterLoot3Amount == 18) { prestigeGreaterLoot3Buff = true;  prestigeGreaterLoot3Amount = 0; }
        }

        if (UpdateGame.greaterLoot4Bought == 1)
        {
            prestigeGreaterLoot4Amount += 1;
            if (prestigeGreaterLoot4Amount == 30) { prestigeGreaterLoot4Buff = true; prestigeGreaterLoot4Amount = 0; }
        }

        if (UpdateGame.greaterLoot5Bought == 1)
        {
             prestigeGreaterLoot5Buff = true; //Debug.Log("HitGreaterLoot5"); 
        }
    }
    #endregion


    public void setText()
    {
        if (chest1Health <= 0)
        {
            chest1HealtchText.text = "0";
        }
        else
        {
            chest1HealtchText.text = TotalGoldAmount.FormatCoinsDoubleOneLetter(chest1Health);
        }

    }

    public GameObject reinforcedChestPopUp, reinforcedPopUp;
    public GameObject normalLock, reinforcedLock;
    public GameObject enchantedGoldenChestPopUp, enchantedInfoPopUp, bossChestPopUp, bossChestInfoPopUp;
    public static bool reinforcedChestActive;

    IEnumerator SetChestHealth()
    {
        //SerendipityScroll
        if (UseConsumable.isScrollActive == true)
        {
            StartCoroutine(scrollTextPopUp());
            if(UseConsumable.scrollStackCount == 2)
            {
                StartCoroutine(scrollTextPopUp());
            }
        }

        yield return new WaitForSeconds(0.4f);

        bossChestReward = false;


        if (enchantedGoldenChestIsActive == true)
        {
            chest1Health = (SelectChests.ChestHealth * UpdateGame.enchantedGoldenChestHealth);
            normalLock.SetActive(false); reinforcedChestPopUp.SetActive(false); bossChestPopUp.SetActive(false);
            enchantedGoldenChestPopUp.SetActive(true);
        }
        else if(bossChestIsActive == true)
        {
            chest1Health = (SelectChests.ChestHealth * UpdateGame.bossChestHealth);
            normalLock.SetActive(false); reinforcedChestPopUp.SetActive(false);  enchantedGoldenChestPopUp.SetActive(false);
            bossChestPopUp.SetActive(true);
        }
        else
        {
            float randomReinfored = Random.Range(0f, 100f);
            if (randomReinfored <= SelectChests.reinforcedChestChance)
            {
                chest1Health = (SelectChests.ChestHealth * UpdateGame.reinforcedChestHealth);
                bossChestPopUp.SetActive(false); enchantedGoldenChestPopUp.SetActive(false);
                normalLock.SetActive(false); reinforcedLock.SetActive(true);
                reinforcedChestPopUp.SetActive(true);
                reinforcedChestActive = true;
            }
            else { chest1Health = SelectChests.ChestHealth; normalLock.SetActive(true); reinforcedLock.SetActive(false); reinforcedChestPopUp.SetActive(false); reinforcedChestActive = false; bossChestPopUp.SetActive(false); enchantedGoldenChestPopUp.SetActive(false); }
        }
       
        reinforcedPopUp.SetActive(false); enchantedInfoPopUp.SetActive(false); bossChestInfoPopUp.SetActive(false);

        double scaledValue = chest1Health / scalingFactor;
        slider.maxValue = (float)scaledValue;
        dealDamage = false;
    }

    #region ScrollBonuses
    IEnumerator scrollTextPopUp()
    {
        GameObject chestText = ObjectPooling.instance.GetMiniChestTextFromPool();
        float randomX = 0;
        float randomY = 0;
        if (PlaceMobileButtons.isMobile == false) { randomX = Random.Range(-2.65f, 2.65f); randomY = Random.Range(-2.65f, 2.65f); }
        else { randomX = Random.Range(-1, 1f); randomY = Random.Range(-1.85f, 1.85f); }

        chestText.transform.position = new Vector3(randomX, randomY, 1);
        
        chestText.GetComponent<TextMeshProUGUI>().color = Color.yellow;

        int randomScrollBonus = Random.Range(1,101);
        if (randomScrollBonus <= 1)
        {
            UseConsumable.scrollTreasureBuff += (0.01f + RareTreasures.scrollRareTreasureTreasure + SkillTree.special7ScrollTreasure);

            chestText.GetComponent<TextMeshProUGUI>().text = "+" + (0.01f + RareTreasures.scrollRareTreasureTreasure + SkillTree.special7ScrollTreasure).ToString("F2") + "% TREASURE DROP CHANCE!";
            SpawnRewards.changeDropChanceValues = true;
        }
        else if (randomScrollBonus <= 5)
        {
            UseConsumable.scrollCritChanceBuff += (0.01f + RareTreasures.scrollRareTreasureCritChance + SkillTree.special7ScrollCritChance);
            chestText.GetComponent<TextMeshProUGUI>().text = "+" + (0.01f + RareTreasures.scrollRareTreasureCritChance + SkillTree.special7ScrollCritChance).ToString("F2") + "% CRIT CHANCE!";
        }
        else if (randomScrollBonus <= 20)
        {
            UseConsumable.scrollCritDamageBuff += (0.03f + RareTreasures.scrollRareTreasureCritDamage + SkillTree.special7ScrollCritDamage);
            chestText.GetComponent<TextMeshProUGUI>().text = "+" + ((0.03f + RareTreasures.scrollRareTreasureCritDamage + SkillTree.special7ScrollCritDamage) * 100).ToString("F0") + "% CRIT DAMAGE!";
        }
        else if (randomScrollBonus <= 40)
        {
            UseConsumable.scrollActiveDamageBuff += (0.04f + RareTreasures.scrollRareTreasureActiveDamage + SkillTree.special7ScrollActiveDamage);
            chestText.GetComponent<TextMeshProUGUI>().text = "+" + ((0.04f + RareTreasures.scrollRareTreasureActiveDamage + SkillTree.special7ScrollActiveDamage) * 100).ToString("F0") + "% ACTIVE DAMAGE!";
        }
        else if (randomScrollBonus <= 55)
        {
            UseConsumable.scrollPassiveDamageBuff += (0.02f + RareTreasures.scrollRareTreasurePassiveDamage + SkillTree.special7ScrollPassiveDamage);
            chestText.GetComponent<TextMeshProUGUI>().text = "+" + ((0.02f + RareTreasures.scrollRareTreasurePassiveDamage + SkillTree.special7ScrollPassiveDamage) * 100).ToString("F0") + "% PASSIVE DAMAGE!";
        }
        else if (randomScrollBonus <= 75)
        {
            UseConsumable.scrollXPBuff += (0.02f + RareTreasures.scrollRareTreasureXP + SkillTree.special7ScrollXP);
            chestText.GetComponent<TextMeshProUGUI>().text = "+" + ((0.02f + RareTreasures.scrollRareTreasureXP + SkillTree.special7ScrollXP) * 100).ToString("F0") + "% XP!";
        }
        else
        {
            UseConsumable.scrollGoldBuff += (0.02f + RareTreasures.scrollRareTreasureGold + SkillTree.special7ScrollTGOLD);
            chestText.GetComponent<TextMeshProUGUI>().text = "+" + ((0.02f + RareTreasures.scrollRareTreasureGold + SkillTree.special7ScrollTGOLD) * 100).ToString("F0") + "% GOLD!";
        }

        int ranomm = Random.Range(1, 1000000001);
        if(ranomm == 69) { chestText.GetComponent<TextMeshProUGUI>().text = "DEEZ NUTS!"; }

        ClickPower.cursorsPriceChanged = true;

        yield return new WaitForSeconds(1.317f);
        ObjectPooling.instance.ReturnMiniChestTextFromPool(chestText);
    }
    #endregion



    #region SoulGemBonus
    IEnumerator SoulGemBonus()
    {
        GameObject chestText = ObjectPooling.instance.GetMiniChestTextFromPool();

        if (Localization.EnglishLanguageChosen == 1) { chestText.GetComponent<TextMeshProUGUI>().font = english; }
        if (Localization.RussianLanguageChosen == 1) { chestText.GetComponent<TextMeshProUGUI>().font = russian; }
        if (Localization.JapaneseLanguageChosen == 1) { chestText.GetComponent<TextMeshProUGUI>().font = japanese; }
        if (Localization.ChineseLanguageChosen == 1) { chestText.GetComponent<TextMeshProUGUI>().font = chinese; }
        if (Localization.KoreanLanguageChosen == 1) { chestText.GetComponent<TextMeshProUGUI>().font = korean; }

        chestText.transform.localPosition = SoulGemClick.soulGemPos;

        chestText.GetComponent<Animation>().Play("miniChestTextAnim");
        chestText.GetComponent<TextMeshProUGUI>().color = Color.red;

        int randomSoulGemBonus = Random.Range(1, 101);
        if (randomSoulGemBonus <= 1)
        {
            UseConsumable.relicPermaTreasureBuff += 0.02f;
            chestText.GetComponent<TextMeshProUGUI>().text = "+0.02" + Localization.treasureDropChance;
            SpawnRewards.changeDropChanceValues = true;
        }
        else if (randomSoulGemBonus <= 5)
        {
            UseConsumable.relicPermaCritChance += 0.05f;
            chestText.GetComponent<TextMeshProUGUI>().text = "+0.05" + Localization.critChanceString;
        }
        else if (randomSoulGemBonus <= 20)
        {
            UseConsumable.relicPermaCritDamage += 0.2f;
            chestText.GetComponent<TextMeshProUGUI>().text = "+20" + Localization.critDamageString;
        }
        else if (randomSoulGemBonus <= 40)
        {
            UseConsumable.relicPermaActiveDamage += 0.3f;
            chestText.GetComponent<TextMeshProUGUI>().text = "+30" + Localization.activeDamageScring;
        }
        else if (randomSoulGemBonus <= 55)
        {
            UseConsumable.relicPermaPassiveDamage += 0.2f;
            chestText.GetComponent<TextMeshProUGUI>().text = "+20" + Localization.passiveDamageString;
        }
        else if (randomSoulGemBonus <= 75)
        {
            UseConsumable.relicPermaXPBuff += 0.20f;
            chestText.GetComponent<TextMeshProUGUI>().text = "+20" + Localization.xp;
        }
        else
        {
            UseConsumable.relicPermaGoldBuff += 0.20f;
            chestText.GetComponent<TextMeshProUGUI>().text = "+20" + Localization.goldPercentString;
        }

        int ranomm = Random.Range(1, 1000000001);
        if (ranomm == 69) { chestText.GetComponent<TextMeshProUGUI>().text = "DEEZ NUTS!"; }

        ClickPower.cursorsPriceChanged = true;

        yield return new WaitForSeconds(1.317f);
        ObjectPooling.instance.ReturnMiniChestTextFromPool(chestText);
    }
    #endregion



    public void SetChestsHealth()
    {
        chest1Health = SelectChests.ChestHealth;

        double scaledValue = chest1Health / scalingFactor;
        slider.maxValue = (float)scaledValue;
        dealDamage = false;
    }


    IEnumerator StopAnims()
    {
        StopAllCoroutines();
        SetChestsHealth();
        yield return new WaitForSeconds(0.2f);

    }

    public void SetAllChestsFalse()
    {
        chest1.SetActive(false); chest2.SetActive(false); chest3.SetActive(false); chest4.SetActive(false); chest5.SetActive(false); chest6.SetActive(false); chest7.SetActive(false); chest8.SetActive(false); chest9.SetActive(false); chest10.SetActive(false); chest11.SetActive(false); chest12.SetActive(false); chest13.SetActive(false); chest14.SetActive(false); chest15.SetActive(false); chest16.SetActive(false); chest17.SetActive(false); chest18.SetActive(false); chest19.SetActive(false); chest20.SetActive(false); chest21.SetActive(false); chest22.SetActive(false); chest23.SetActive(false); chest24.SetActive(false); chest25.SetActive(false); chest26.SetActive(false); chest27.SetActive(false); chest28.SetActive(false); chest29.SetActive(false); chest30.SetActive(false); chest31.SetActive(false); chest32.SetActive(false); chest33.SetActive(false); chest34.SetActive(false); chest35.SetActive(false); chest36.SetActive(false); chest37.SetActive(false); chest38.SetActive(false); chest39.SetActive(false); chest40.SetActive(false); 
    }

    #region Set Open chest inactive
    public void SetOpenChestInactive()
    {
        chest1Open.SetActive(false);
        chest2Open.SetActive(false);
        chest3Open.SetActive(false);
        chest4Open.SetActive(false);
        chest5Open.SetActive(false);
        chest6Open.SetActive(false);
        chest7Open.SetActive(false);
        chest8Open.SetActive(false);
        chest9Open.SetActive(false);
        chest10Open.SetActive(false);
        chest11Open.SetActive(false);
        chest12Open.SetActive(false);
        chest13Open.SetActive(false);
        chest14Open.SetActive(false);
        chest15Open.SetActive(false);
        chest16Open.SetActive(false);
        chest17Open.SetActive(false);
        chest18Open.SetActive(false);
        chest19Open.SetActive(false);
        chest20Open.SetActive(false);
        chest21Open.SetActive(false);
        chest22Open.SetActive(false);
        chest23Open.SetActive(false);
        chest24Open.SetActive(false);
        chest25Open.SetActive(false);
        chest26Open.SetActive(false);
        chest27Open.SetActive(false);
        chest28Open.SetActive(false);
        chest29Open.SetActive(false);
        chest30Open.SetActive(false);
        chest31Open.SetActive(false);
        chest32Open.SetActive(false);
        chest33Open.SetActive(false);
        chest34Open.SetActive(false);
        chest35Open.SetActive(false);
        chest36Open.SetActive(false);
        chest37Open.SetActive(false);
        chest38Open.SetActive(false);
        chest39Open.SetActive(false);
        chest40Open.SetActive(false);
    }
    #endregion

}
