using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading.Tasks;
using UnityEngine.EventSystems;

public class ReturnRedGem : MonoBehaviour, IPointerEnterHandler
{
    public GameObject targetGameobjectItemBar;
    public string targetGameObjectItemBarName = "ItemsDropBar";
    public string targetGameObjectItemBarNameMOBILE = "TreasureMobileBTN";
    public bool miniChestMove;

    public GameObject audioManagerObject;
    public AudioManager audioManager;

    public Rigidbody2D rigidbodyTreasure;

    public bool isQuartz, isAmethyst, isYellowTopaz, isAlbite, isRedGarnet, isAquamarine, isYellowSapphire, isPinkTourmaline, isAdventurine, isRedRuby, isDiamond, isGrandidierite, isVioletCrystal, isAkoyaPearl, isPurpleRupee, isEmerald, isGreenDiamond, isFireOpal, isGemSilica, isPinkPlort, isGoldenSeaPearl, isKyanite, isBlackOpal, isPainite, isTanzanite, isAstralium, isElysiumPrism, isAerhfireOpal, isEldrichStarstone, isChonolish, isSideriumEssence, isQuasarite, isRuadiantNovaStone, isSolumiumShard;


    public bool isLockPick, isHammer, isKey, isGoldenTouch, isLootPotion, isXPPotion, isDamagePotion, isScroll, isGauntlet, isElixir, isRelic, isTreasurePotion, isKnife;

    public string moveToString = "ItemsBar";

    public void Start()
    {
        if(PlaceMobileButtons.isMobile == true) { moveToString = "TreasureMobileBTN"; }
        else { moveToString = "ItemsBar"; }
    }

    public void Awake()
    {
        isQuartz = false;
        isAmethyst = false;
        isYellowTopaz = false;
        isAlbite = false;
        isRedGarnet = false;
        isAquamarine = false;
        isYellowSapphire = false;
        isPinkTourmaline = false;
        isAdventurine = false;
        isRedRuby = false;
        isDiamond = false;
        isGrandidierite = false;
        isVioletCrystal = false;
        isAkoyaPearl = false;
        isPurpleRupee = false;
        isEmerald = false;
        isGreenDiamond = false;
        isFireOpal = false;
        isGemSilica = false;
        isPinkPlort = false;
        isGoldenSeaPearl = false;
        isKyanite = false;
        isBlackOpal = false;
        isPainite = false;
        isTanzanite = false;
        isAstralium = false;
        isElysiumPrism = false;
        isAerhfireOpal = false;
        isEldrichStarstone = false;
        isChonolish = false;
        isSideriumEssence = false;
        isQuasarite = false;
        isRuadiantNovaStone = false;
        isSolumiumShard = false;

        // Second set of boolean variables
        isLockPick = false;
        isHammer = false;
        isKey = false;
        isGoldenTouch = false;
        isLootPotion = false;
        isXPPotion = false;
        isDamagePotion = false;
        isScroll = false;
        isGauntlet = false;
        isElixir = false;
        isRelic = false;
        isTreasurePotion = false;
        isKnife = false;

        if (gameObject.name == "Quartz(Clone)") { isQuartz = true; }
        if (gameObject.name == "RedRuby(Clone)") { isRedRuby = true; }
        if (gameObject.name == "Amethyst(Clone)") { isAmethyst = true; }
        if (gameObject.name == "Diamond(Clone)") { isDiamond = true; }
        if (gameObject.name == "VioletCrystal(Clone)") { isVioletCrystal = true; }
        if (gameObject.name == "Yellow Sapphire(Clone)") { isYellowSapphire = true; }
        if (gameObject.name == "GreenDiamond(Clone)") { isGreenDiamond = true; }
        if (gameObject.name == "Grandidierite(Clone)") { isGrandidierite = true; }
        if (gameObject.name == "PurpleRupee(Clone)") { isPurpleRupee = true; }
        if (gameObject.name == "PinkPlort(Clone)") { isPinkPlort = true; }
        if (gameObject.name == "Emerald(Clone)") { isEmerald = true; }
        if (gameObject.name == "RedGarnet(Clone)") { isRedGarnet = true; }
        if (gameObject.name == "Pink Tourmaline(Clone)") { isPinkTourmaline = true; }
        if (gameObject.name == "YellowTopaz(Clone)") { isYellowTopaz = true; }
        if (gameObject.name == "Aquamarine(Clone)") { isAquamarine = true; }
        if (gameObject.name == "Fire Opal(Clone)") { isFireOpal = true; }
        if (gameObject.name == "Golden Sea Pearl(Clone)") { isGoldenSeaPearl = true; }
        if (gameObject.name == "Akoya Pearl(Clone)") { isAkoyaPearl = true; }
        if (gameObject.name == "Gem Silica(Clone)") { isGemSilica = true; }
        if (gameObject.name == "Aventurine(Clone)") { isAdventurine = true; }
        if (gameObject.name == "Kyanite(Clone)") { isKyanite = true; }
        if (gameObject.name == "Albite(Clone)") { isAlbite = true; }
        if (gameObject.name == "BlackOpal(Clone)") { isBlackOpal = true; }
        if (gameObject.name == "Painite(Clone)") { isPainite = true; }
        if (gameObject.name == "Tanzanite(Clone)") { isTanzanite = true; }
        if (gameObject.name == "Astralium(Clone)") { isAstralium = true; }
        if (gameObject.name == "ElysiumPrism(Clone)") { isElysiumPrism = true; }
        if (gameObject.name == "AetherfireOpal(Clone)") { isAerhfireOpal = true; }
        if (gameObject.name == "EldritchStarstone(Clone)") { isEldrichStarstone = true; }
        if (gameObject.name == "ChronolithShard(Clone)") { isChonolish = true; }
        if (gameObject.name == "SideriumEssence(Clone)") { isSideriumEssence = true; }
        if (gameObject.name == "Quasarite(Clone)") { isQuasarite = true; }
        if (gameObject.name == "RadiantNovaStone(Clone)") { isRuadiantNovaStone = true; }
        if (gameObject.name == "SoluniumShard(Clone)") { isSolumiumShard = true; }

        if (gameObject.name == "LockPick(Clone)") { isLockPick = true; }
        if (gameObject.name == "Hammer(Clone)") { isHammer = true; }
        if (gameObject.name == "Key(Clone)") { isKey = true; }
        if (gameObject.name == "GoldenTouch(Clone)") { isGoldenTouch = true; }
        if (gameObject.name == "LootPotion(Clone)") { isLootPotion = true; }
        if (gameObject.name == "XPPotion(Clone)") { isXPPotion = true; }
        if (gameObject.name == "DamagePotion(Clone)") { isDamagePotion = true; }
        if (gameObject.name == "ScrollPrefab(Clone)") { isScroll = true; }
        if (gameObject.name == "GauntletPrefab(Clone)") { isGauntlet = true; }
        if (gameObject.name == "ElixirPrefab(Clone)") { isElixir = true; }
        if (gameObject.name == "RelicPrefab(Clone)") { isRelic = true; }
        if (gameObject.name == "TreasurePotionPrefab(Clone)") { isTreasurePotion = true; }
        if (gameObject.name == "KnifePrefab(Clone)") { isKnife = true; }

        rigidbodyTreasure = GetComponent<Rigidbody2D>();

        audioManagerObject = GameObject.Find("Audio");
        audioManager = audioManagerObject.GetComponent<AudioManager>();

        if(PlaceMobileButtons.isMobile == false) { targetGameobjectItemBar = GameObject.Find(targetGameObjectItemBarName); }
        else { targetGameobjectItemBar = GameObject.Find(targetGameObjectItemBarNameMOBILE); }
    }

    private void OnMouseEnter()
    {
        if(PlaceMobileButtons.isMobile == false)
        {
            if (AudioManager.audioMuted == 1)
            {
                int random = Random.Range(1, 4);
                if (random == 1) { audioManager.Play("Hover1Swoosh"); }
                if (random == 2) { audioManager.Play("Hover2Swoosh"); }
                if (random == 3) { audioManager.Play("Hover3Swoosh"); }
            }

            Transform targetTransform = targetGameobjectItemBar.transform;

            if (treasureCoroutine == null) { treasureCoroutine = StartCoroutine(MoveTowardsTarget(gameObject.transform, targetTransform)); }
        }
      
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (PlaceMobileButtons.isMobile == true)
        {
            if (AudioManager.audioMuted == 1)
            {
                int random = Random.Range(1, 4);
                if (random == 1) { audioManager.Play("Hover1Swoosh"); }
                if (random == 2) { audioManager.Play("Hover2Swoosh"); }
                if (random == 3) { audioManager.Play("Hover3Swoosh"); }
            }

            Transform targetTransform = targetGameobjectItemBar.transform;

            if (treasureCoroutine == null) { treasureCoroutine = StartCoroutine(MoveTowardsTarget(gameObject.transform, targetTransform)); }
        }
    }

    private void OnEnable()
    {
        gameObject.layer = 5;
        isMoving = false;
        treasureCoroutine = null;

        if (SpecialUpgradesButtons.clickedMiniChest == true)
        {
            ChestMove();
            miniChestMove = true;
        }

        rigidbodyTreasure.gravityScale = 1;
        rigidbodyTreasure.velocity = new Vector2(Random.Range(SpawnRewards.minXSpeed, SpawnRewards.maxXSpeed), Random.Range(SpawnRewards.minYSpeed, SpawnRewards.maxYSpeed));
    }

    public async void ChestMove()
    {
        await Task.Delay(5);
        Transform targetTransform = targetGameobjectItemBar.transform;
        if (treasureCoroutine == null) { treasureCoroutine = StartCoroutine(MoveTowardsTarget(gameObject.transform, targetTransform)); }
    }

    private void Update()
    {
        if(SpawnRewards.gemOnScreenCount < 0) { SpawnRewards.gemOnScreenCount = 0; }

        if(SpawnRewards.gemOnScreenCount > SaveAndLoad.maximumStuffOnScreen)
        {
            Transform targetTransform = targetGameobjectItemBar.transform;
            if (treasureCoroutine == null) { treasureCoroutine = StartCoroutine(MoveTowardsTarget(gameObject.transform, targetTransform)); }
        }

        if(SaveAndLoad.pressedResetButton == true)
        {
            Transform targetTransform = targetGameobjectItemBar.transform;
            if (treasureCoroutine == null) { treasureCoroutine = StartCoroutine(MoveTowardsTarget(gameObject.transform, targetTransform)); }
        }

        if (SkillTree.pressedPrestige == true)
        {
            Transform targetTransform = targetGameobjectItemBar.transform;
            if (treasureCoroutine == null) { treasureCoroutine = StartCoroutine(MoveTowardsTarget(gameObject.transform, targetTransform)); }
        }
    }

    public Coroutine treasureCoroutine;
    public bool isMoving;

    IEnumerator MoveTowardsTarget(Transform redGem, Transform targetTransform)
    {
        gameObject.layer = 14;
        isMoving = true;

        float totalTime = Random.Range(0.55f, 1.35f);
        float elapsedTime = 0f;
        Vector3 initialPosition = redGem.position;

        while (elapsedTime < totalTime)
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime / totalTime);
            redGem.position = Vector3.Lerp(initialPosition, targetTransform.position, t);
            yield return null;
        }
    }

    public static bool setQuartz, setAmethyst, setYellowTopaz, setAlbite, setRedGarnet, setAquamarine, setYellowSapphire, setPinkTourmaline, setAdventurine, setRedRuby, setDiamond, SetGrandiderite, setVioletCrystal, setAkoyaPearl, setPurpleRupee, setEmerald, setGreenDiamond, setFireOpal, setGemSilica, setPinkPlort, setGoldejSeaPearl, setKyanite, setBlackOpal, setPainite, setTanzanite, setAstralium, setElysiumPrism, setAetherfireOpal, setEldritchStarstone, setChronolithShard, setSideriumEssence, setQuasarite, setRadiantNovaStone, setSoluniumShard;

    public static bool setLockPick, setHammer, setLootPotion, setDamagePotion, setXPPotion, setGoldenTouch, setKey, setScroll, setGauntlet, setElixir, setRelic, setTreasurePotion, setKnife;

    public static bool isTreasureDouble, isItemDouble;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(isMoving == true)
        {
            int randomDouble = Random.Range(1, 101);

            if (SpecialUpgradesButtons.clickedMiniChest == true)
            {
                SpecialUpgradesButtons.clickedMiniChest = false;
            }

            if(collision.gameObject.tag == moveToString)
            {
                if (isRedRuby == true)
                {
                    Stats.rareTreasureDrops += 1;
                    Stats.treasuresDropped += 1;
                    ObjectPooling.instance.ReturnRedGemFromPool(gameObject);
                    RareDropsCollected.RedGemCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.RedGemCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.redGemBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;
                    SpawnRewards.gemOnScreenCount -= 1;

                    setRedRuby = true;

                    return;
                }

                if (isAmethyst == true)
                {
                    Stats.commonTreasureDrops += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnAmethystFromPool(gameObject);
                    RareDropsCollected.amethystCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.amethystCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.amethystBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setAmethyst = true;

                    return;
                }
                if (isDiamond == true)
                {
                    Stats.rareTreasureDrops += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnDiamondFromPool(gameObject);
                    RareDropsCollected.diamondCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.diamondCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.diamondBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setDiamond = true;

                    return;
                }
                if (isVioletCrystal == true)
                {
                    Stats.rareTreasureDrops += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnVoiletFromPool(gameObject);
                    RareDropsCollected.violetCrystalCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.violetCrystalCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.violetCrystalBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setVioletCrystal = true;
                    return;
                }
                if (isYellowSapphire == true)
                {
                    Stats.uncommonTreasureDrops += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnYellowSapphireFromPool(gameObject);
                    RareDropsCollected.yellowSapphireCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.yellowSapphireCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.yellowSapphireBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setYellowSapphire = true;
                    return;
                }
                if (isGreenDiamond == true)
                {
                    Stats.veryRareTreasureDrops += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnGreenDiamondFromPool(gameObject);
                    RareDropsCollected.greenDiamondCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.greenDiamondCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.greenDiamondBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setGreenDiamond = true;
                    return;
                }
                if (isGrandidierite == true)
                {
                    Stats.rareTreasureDrops += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnGrandidieriteFromPool(gameObject);
                    RareDropsCollected.grandidieriteCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.grandidieriteCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.grandidieriteBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    SetGrandiderite = true;
                    return;
                }
                if (isPurpleRupee == true)
                {
                    Stats.veryRareTreasureDrops += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnPurpleRupeeFromPool(gameObject);
                    RareDropsCollected.purpleRupeeCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.purpleRupeeCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.purpleRupeeBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setPurpleRupee = true;
                    return;
                }
                if (isPinkPlort == true)
                {
                    Stats.extremelyRareTreasureDrops += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnPinkPlortFromPool(gameObject);
                    RareDropsCollected.pinkPlostCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.pinkPlostCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.pinkPlortBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setPinkPlort = true;
                    return;
                }
                if (isEmerald == true)
                {
                    Stats.veryRareTreasureDrops += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnEmeraldFromPool(gameObject);
                    RareDropsCollected.emeraldCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.emeraldCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.emeraldBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setEmerald = true;
                    return;
                }
                if (isQuartz == true)
                {
                    Stats.commonTreasureDrops += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnQuartzFromPool(gameObject);
                    RareDropsCollected.quartzCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue))
                    {
                        RareDropsCollected.quartzCount += 1; Stats.treasuresDoubled += 1;
                        isTreasureDouble = true;
                    }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.quartzBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setQuartz = true;
                    return;
                }
                if (isRedGarnet == true)
                {
                    Stats.commonTreasureDrops += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnRedGarnetFromPool(gameObject);
                    RareDropsCollected.redGarnetCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.redGarnetCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.redGarnetBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setRedGarnet = true;
                    return;
                }
                if (isPinkTourmaline == true)
                {
                    Stats.uncommonTreasureDrops += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnPinkTourmalineFromPool(gameObject);
                    RareDropsCollected.pinkTourmalineCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.pinkTourmalineCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.pinkTourmalineBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setPinkTourmaline = true;
                    return;
                }
                if (isYellowTopaz == true)
                {
                    Stats.commonTreasureDrops += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnYellowTopazFromPool(gameObject);
                    RareDropsCollected.yellowTopazCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.yellowTopazCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.yellowTopazBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setYellowTopaz = true;
                    return;
                }
                if (isAquamarine == true)
                {
                    Stats.uncommonTreasureDrops += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnAquamarineFromPool(gameObject);
                    RareDropsCollected.aquamarineCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.aquamarineCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.aquamarineBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setAquamarine = true;
                    return;
                }
                if (isFireOpal == true)
                {
                    Stats.veryRareTreasureDrops += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnFireOpalFromPool(gameObject);
                    RareDropsCollected.fireOpalCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.fireOpalCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.fireOpalBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setFireOpal = true;
                    return;
                }
                if (isGoldenSeaPearl == true)
                {
                    Stats.extremelyRareTreasureDrops += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnGoldenSeaPearlFromPool(gameObject);
                    RareDropsCollected.goldeSeaPearlCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.goldeSeaPearlCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.goldeSeaPearlBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setGoldejSeaPearl = true;
                    return;
                }
                if (isAkoyaPearl == true)
                {
                    Stats.rareTreasureDrops += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnAkoyaPearlFromPool(gameObject);
                    RareDropsCollected.akoyaPearlCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.akoyaPearlCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.akoyaPearlBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setAkoyaPearl = true;
                    return;
                }
                if (isGemSilica == true)
                {
                    Stats.veryRareTreasureDrops += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnGemSilicaFromPool(gameObject);
                    RareDropsCollected.gemSilicaCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.gemSilicaCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.gemSilicaBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setGemSilica = true;
                    return;
                }
                if (isAdventurine == true)
                {
                    Stats.uncommonTreasureDrops += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnAdventurineFromPool(gameObject);
                    RareDropsCollected.AdventurineCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.AdventurineCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.adventurineBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setAdventurine = true;
                    return;
                }
                if (isKyanite == true)
                {
                    Stats.extremelyRareTreasureDrops += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnKyaniteFromPool(gameObject);
                    RareDropsCollected.kyaniteCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.kyaniteCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.kyaniteBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setKyanite = true;
                    return;
                }
                if (isAlbite == true)
                {
                    Stats.commonTreasureDrops += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnAlbiteFromPool(gameObject);
                    RareDropsCollected.albiteCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.albiteCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.albiteBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setAlbite = true;
                    return;
                }
                if (isBlackOpal == true)
                {
                    Stats.legendaryTreasureDrops += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnBlackOpalFromPool(gameObject);
                    RareDropsCollected.blackOpalCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.blackOpalCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.blackOpalBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setBlackOpal = true;
                    return;
                }
                if (isPainite == true)
                {
                    Stats.legendaryTreasureDrops += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnPainiteFromPool(gameObject);
                    RareDropsCollected.painiteCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.painiteCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.painiteBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setPainite = true;
                    return;
                }
                if (isTanzanite == true)
                {
                    Stats.legendaryTreasureDrops += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnTanzaniteFromPool(gameObject);
                    RareDropsCollected.TanzaniteCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.TanzaniteCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.tanzaniteBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setTanzanite = true;
                    return;
                }
                // astralium
                if (isAstralium == true)
                {
                    Stats.ultraTreasures += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnAstraliumFromPool(gameObject);
                    RareDropsCollected.astraliumCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.astraliumCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.astraliumBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setAstralium = true;
                    return;
                }

                // elysiumPrism
                if (isElysiumPrism == true)
                {
                    Stats.ultraTreasures += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnElysiumPrismFromPool(gameObject);
                    RareDropsCollected.elysiumPrismCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.elysiumPrismCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.elysiumPrismBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setElysiumPrism = true;
                    return;
                }

                // aetherfireOpal
                if (isAerhfireOpal == true)
                {
                    Stats.ultraTreasures += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnAetherfireOpalFromPool(gameObject);
                    RareDropsCollected.aetherfireOpalCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.aetherfireOpalCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.aetherfireOpalBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setAetherfireOpal = true;
                    return;
                }

                // eldritchStarstone
                if (isEldrichStarstone == true)
                {
                    Stats.mythicTreasures += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnEldritchStarstoneFromPool(gameObject);
                    RareDropsCollected.eldritchStarstoneCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.eldritchStarstoneCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.eldritchStarstoneBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setEldritchStarstone = true;
                    return;
                }

                // chronolithShard
                if (isChonolish == true)
                {
                    Stats.mythicTreasures += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnChronolithShardFromPool(gameObject);
                    RareDropsCollected.chronolithShardCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.chronolithShardCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.chronolithShardBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setChronolithShard = true;
                    return;
                }

                // sideriumEssence
                if (isSideriumEssence == true)
                {
                    Stats.mythicTreasures += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnSideriumEssenceFromPool(gameObject);
                    RareDropsCollected.sideriumEssenceCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.sideriumEssenceCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.sideriumEssenceBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setSideriumEssence = true;
                    return;
                }

                // quasarite
                if (isQuasarite == true)
                {
                    Stats.eternalTreasures += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnQuasariteFromPool(gameObject);
                    RareDropsCollected.quasariteCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.quasariteCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.quasariteBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setQuasarite = true;
                    return;
                }

                // radiantNovaStone
                if (isRuadiantNovaStone == true)
                {
                    Stats.eternalTreasures += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnRadiantNovaStoneFromPool(gameObject);
                    RareDropsCollected.radiantNovaStoneCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.radiantNovaStoneCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.radiantNovaStoneBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setRadiantNovaStone = true;
                    return;
                }

                // soluniumShard
                if (isSolumiumShard == true)
                {
                    Stats.eternalTreasures += 1;
                    Stats.treasuresDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnSoluniumShardeFromPool(gameObject);
                    RareDropsCollected.soluniumShardCount += 1; if (randomDouble <= (SpawnRewards.doubleRareDropChance + ClickPower.cursorEquippedChance + UseConsumable.lootPotionDoubleValue)) { RareDropsCollected.soluniumShardCount += 1; Stats.treasuresDoubled += 1; isTreasureDouble = true; }
                    else { isTreasureDouble = false; }
                    RareDropsCollected.soluniumShardBoughtFirstTime = 1;
                    RareDropsCollected.isGemCountUpdated = true;

                    setSoluniumShard = true;
                    return;
                }

                //Items
                if (isLockPick == true)
                {
                    Stats.itemsDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnLockPickFromPool(gameObject);
                    UseConsumable.lockPickCount += 1; if (randomDouble <= SkillTree.skillTreeSpecial4Double) { UseConsumable.lockPickCount += 1; Stats.itemsDropped += 1; isItemDouble = true; }
                    else { isItemDouble = false; }
                    SpecialUpgradesButtons.lockPickBoughtFirstTime = 1;
                    SpecialUpgradesButtons.specialTextChange = true;

                    setLockPick = true;
                    return;
                }
                if (isHammer == true)
                {
                    Stats.itemsDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnHammerFromPool(gameObject);
                    UseConsumable.hammerCount += 1; if (randomDouble <= SkillTree.skillTreeSpecial4Double) { UseConsumable.hammerCount += 1; Stats.itemsDropped += 1; isItemDouble = true; }
                    else { isItemDouble = false; }
                    SpecialUpgradesButtons.specialTextChange = true;

                    setHammer = true;
                    return;
                }
                if (isKey == true)
                {
                    Stats.itemsDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnKeyFromPool(gameObject);
                    UseConsumable.KeysCount += 1; if (randomDouble <= SkillTree.skillTreeSpecial4Double) { UseConsumable.KeysCount += 1; Stats.itemsDropped += 1; isItemDouble = true; }
                    else { isItemDouble = false; }
                    SpecialUpgradesButtons.specialTextChange = true;

                    setKey = true;
                    return;
                }
                if (isGoldenTouch == true)
                {
                    Stats.itemsDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnGoldenTouchFromPool(gameObject);
                    UseConsumable.goldenTouchCount += 1; if (randomDouble <= SkillTree.skillTreeSpecial4Double) { UseConsumable.goldenTouchCount += 1; Stats.itemsDropped += 1; isItemDouble = true; }
                    else { isItemDouble = false; }
                    SpecialUpgradesButtons.specialTextChange = true;

                    setGoldenTouch = true;
                    return;
                }
                if (isLootPotion == true)
                {
                    Stats.itemsDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnLootPotionFromPool(gameObject);
                    UseConsumable.lootPotionCount += 1; if (randomDouble <= SkillTree.skillTreeSpecial4Double) { UseConsumable.lootPotionCount += 1; Stats.itemsDropped += 1; isItemDouble = true; }
                    else { isItemDouble = false; }
                    SpecialUpgradesButtons.specialTextChange = true;

                    setLootPotion = true;
                    return;
                }
                if (isXPPotion == true)
                {
                    Stats.itemsDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnXPPotionFromPool(gameObject);
                    UseConsumable.XPPotionCount += 1; if (randomDouble <= SkillTree.skillTreeSpecial4Double) { UseConsumable.XPPotionCount += 1; Stats.itemsDropped += 1; isItemDouble = true; }
                    else { isItemDouble = false; }
                    SpecialUpgradesButtons.specialTextChange = true;

                    setXPPotion = true;
                    return;
                }
                if (isDamagePotion == true)
                {
                    Stats.itemsDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnDamagePotionFromPool(gameObject);
                    UseConsumable.damagePotioncount += 1; if (randomDouble <= SkillTree.skillTreeSpecial4Double) { UseConsumable.damagePotioncount += 1; Stats.itemsDropped += 1; isItemDouble = true; }
                    else { isItemDouble = false; }
                    SpecialUpgradesButtons.specialTextChange = true;

                    setDamagePotion = true;
                    return;
                }
                if (isScroll == true)
                {
                    Stats.itemsDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnScrollFromPool(gameObject);
                    UseConsumable.scrollCount += 1; if (randomDouble <= SkillTree.skillTreeSpecial4Double) { UseConsumable.scrollCount += 1; Stats.itemsDropped += 1; isItemDouble = true; }
                    else { isItemDouble = false; }
                    SpecialUpgradesButtons.specialTextChange = true;

                    setScroll = true;
                    return;
                }
                if (isGauntlet == true)
                {
                    Stats.itemsDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnGauntletFromPool(gameObject);
                    UseConsumable.gauntletCount += 1; if (randomDouble <= SkillTree.skillTreeSpecial4Double) { UseConsumable.gauntletCount += 1; Stats.itemsDropped += 1; isItemDouble = true; }
                    else { isItemDouble = false; }
                    SpecialUpgradesButtons.specialTextChange = true;

                    setGauntlet = true;
                    return;
                }
                if (isElixir == true)
                {
                    Stats.itemsDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnElixirFromPool(gameObject);
                    UseConsumable.elixirCount += 1; if (randomDouble <= SkillTree.skillTreeSpecial4Double) { UseConsumable.elixirCount += 1; Stats.itemsDropped += 1; isItemDouble = true; }
                    else { isItemDouble = false; }
                    SpecialUpgradesButtons.specialTextChange = true;

                    setElixir = true;
                    return;
                }
                if (isRelic == true)
                {
                    Stats.itemsDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnRelicFromPool(gameObject);
                    UseConsumable.relicCount += 1; if (randomDouble <= SkillTree.skillTreeSpecial4Double) { UseConsumable.relicCount += 1; Stats.itemsDropped += 1; isItemDouble = true; }
                    else { isItemDouble = false; }
                    SpecialUpgradesButtons.specialTextChange = true;

                    setRelic = true;
                    return;
                }

                if (isTreasurePotion == true)
                {
                    Stats.itemsDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnTreasurePotionFromPool(gameObject);
                    UpdateGame.treasurePotionCount += 1;
                    if (randomDouble <= SkillTree.skillTreeSpecial4Double)
                    {
                        UpdateGame.treasurePotionCount += 1;
                        Stats.itemsDropped += 1;
                        isItemDouble = true;
                    }
                    else
                    {
                        isItemDouble = false;
                    }
                    UpdateGame.changeItemUpdate = true;

                    setTreasurePotion = true;
                    return;
                }

                if (isKnife == true)
                {
                    Stats.itemsDropped += 1;
                    SpawnRewards.gemOnScreenCount -= 1;
                    ObjectPooling.instance.ReturnKnifeFromPool(gameObject);
                    UpdateGame.knifeCount += 1;
                    if (randomDouble <= SkillTree.skillTreeSpecial4Double)
                    {
                        UpdateGame.knifeCount += 1;
                        Stats.itemsDropped += 1;
                        isItemDouble = true;
                    }
                    else
                    {
                        isItemDouble = false;
                    }
                    UpdateGame.changeItemUpdate = true;

                    setKnife = true;
                }
            }
        }
    }
}
