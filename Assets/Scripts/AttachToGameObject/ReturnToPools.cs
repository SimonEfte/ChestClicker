using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Random = UnityEngine.Random;
using UnityEngine.EventSystems;

public class ReturnToPools : MonoBehaviour, IPointerEnterHandler
{
    public static double goldCountDouble;

    public static bool plussGold;
    public static bool plussGoldBarrel;

    public double minGoldDouble, maxGoldDouble;

    private double randomDouble1, randomDouble2;

    public double minValue = 0.0;
    public double maxValue = 1.0;

    public GameObject audioManagerObject;
    public AudioManager audioManager;

    public Rigidbody2D rigidbodyGold;
    public Collider2D colliderGold;
  

    public void Awake()
    {
        rigidbodyGold = GetComponent<Rigidbody2D>();
        colliderGold = GetComponent<Collider2D>();

        audioManagerObject = GameObject.Find("Audio");
        audioManager = audioManagerObject.GetComponent<AudioManager>();

        isNormalGold = false; is5XGold = false; is10xGold = false; is25xGold = false; is100xGold = false;

        if (gameObject.name == "Gold(Clone)") { isNormalGold = true; }
        if (gameObject.name == "5XGoldCoin(Clone)") { is5XGold = true; }
        if (gameObject.name == "10XGoldCoin(Clone)") { is10xGold = true; }
        if (gameObject.name == "25XGoldCoin(Clone)") { is25xGold = true; }
        if (gameObject.name == "100XCoin(Clone)") { is100xGold = true; }

        activeInHiercary = true;
        targetGameObjectGoldBar = GameObject.Find(targetGameObjectGoldBarName);
    }

    public bool isNormalGold, is5XGold, is10xGold, is25xGold, is100xGold;

    private void OnEnable()
    {
        #region gold amount
        if (HealthBar.bossChestReward == true)
        {
            minGoldDouble = (SelectChests.randomMinGold * (1 + UseConsumable.lootPotionGoldBuff + UseConsumable.elixirGoldBuff + ClickPower.cursorEquippedGoldIncrease + SkillTree.skillTreeGold + RareTreasures.runeGold + RareTreasures.cookieGold + RareTreasures.backPackGold + UseConsumable.scrollGoldBuff + UseConsumable.relicPermaGoldBuff + UpdateGame.goldBuffAmount - UpdateGame.goldDebuffAmount)) * UpdateGame.bossChestGoldValue;

            maxGoldDouble = (SelectChests.randomMaxGold * (1 + UseConsumable.lootPotionGoldBuff + UseConsumable.elixirGoldBuff + ClickPower.cursorEquippedGoldIncrease + SkillTree.skillTreeGold + RareTreasures.runeGold + RareTreasures.cookieGold + RareTreasures.backPackGold + UseConsumable.scrollGoldBuff + UseConsumable.relicPermaGoldBuff + UpdateGame.goldBuffAmount - UpdateGame.goldDebuffAmount)) * UpdateGame.bossChestGoldValue;
        }

        if (HealthBar.reinforcedChestActive == true)
        {
                minGoldDouble = (SelectChests.randomMinGold * (1 + UseConsumable.lootPotionGoldBuff + UseConsumable.elixirGoldBuff + ClickPower.cursorEquippedGoldIncrease + SkillTree.skillTreeGold + RareTreasures.runeGold + RareTreasures.cookieGold + RareTreasures.backPackGold + UseConsumable.scrollGoldBuff + UseConsumable.relicPermaGoldBuff + UpdateGame.goldBuffAmount - UpdateGame.goldDebuffAmount)) * UpdateGame.reinforcedChestGoldIncrease;

                maxGoldDouble = (SelectChests.randomMaxGold * (1 + UseConsumable.lootPotionGoldBuff + UseConsumable.elixirGoldBuff + ClickPower.cursorEquippedGoldIncrease + SkillTree.skillTreeGold + RareTreasures.runeGold + RareTreasures.cookieGold + RareTreasures.backPackGold + UseConsumable.scrollGoldBuff + UseConsumable.relicPermaGoldBuff + UpdateGame.goldBuffAmount - UpdateGame.goldDebuffAmount)) * UpdateGame.reinforcedChestGoldIncrease;
        }

        if (HealthBar.reinforcedChestActive == false && HealthBar.bossChestReward == false)
        {
               if (SkillTree.gold4Bought == 1)
               {
                    int random = Random.Range(1, 101);
                   if (random < 4)
                    {
                        minGoldDouble = SelectChests.randomMinGold * (1 + UseConsumable.lootPotionGoldBuff + UseConsumable.elixirGoldBuff + ClickPower.cursorEquippedGoldIncrease + SkillTree.skillTreeGold + RareTreasures.runeGold + RareTreasures.cookieGold + RareTreasures.backPackGold + UseConsumable.scrollGoldBuff + UseConsumable.relicPermaGoldBuff + UpdateGame.goldBuffAmount - UpdateGame.goldDebuffAmount) * 2;

                        maxGoldDouble = SelectChests.randomMaxGold * (1 + UseConsumable.lootPotionGoldBuff + UseConsumable.elixirGoldBuff + ClickPower.cursorEquippedGoldIncrease + SkillTree.skillTreeGold + RareTreasures.runeGold + RareTreasures.cookieGold + RareTreasures.backPackGold + UseConsumable.scrollGoldBuff + UseConsumable.relicPermaGoldBuff + UpdateGame.goldBuffAmount - UpdateGame.goldDebuffAmount) * 2;
                   }
                   else
                   {
                        minGoldDouble = (SelectChests.randomMinGold * (1 + UseConsumable.lootPotionGoldBuff + UseConsumable.elixirGoldBuff + ClickPower.cursorEquippedGoldIncrease + SkillTree.skillTreeGold + RareTreasures.runeGold + RareTreasures.cookieGold + RareTreasures.backPackGold + UseConsumable.scrollGoldBuff + UseConsumable.relicPermaGoldBuff + UpdateGame.goldBuffAmount - UpdateGame.goldDebuffAmount));

                        maxGoldDouble = (SelectChests.randomMaxGold * (1 + UseConsumable.lootPotionGoldBuff + UseConsumable.elixirGoldBuff + ClickPower.cursorEquippedGoldIncrease + SkillTree.skillTreeGold + RareTreasures.runeGold + RareTreasures.cookieGold + RareTreasures.backPackGold + UseConsumable.scrollGoldBuff + UseConsumable.relicPermaGoldBuff + UpdateGame.goldBuffAmount - UpdateGame.goldDebuffAmount));
                  }
              }
              else
              {
                    minGoldDouble = (SelectChests.randomMinGold * (1 + UseConsumable.lootPotionGoldBuff + UseConsumable.elixirGoldBuff + ClickPower.cursorEquippedGoldIncrease + SkillTree.skillTreeGold + RareTreasures.runeGold + RareTreasures.cookieGold + RareTreasures.backPackGold + UseConsumable.scrollGoldBuff + UseConsumable.relicPermaGoldBuff + UpdateGame.goldBuffAmount - UpdateGame.goldDebuffAmount));

                    maxGoldDouble = (SelectChests.randomMaxGold * (1 + UseConsumable.lootPotionGoldBuff + UseConsumable.elixirGoldBuff + ClickPower.cursorEquippedGoldIncrease + SkillTree.skillTreeGold + RareTreasures.runeGold + RareTreasures.cookieGold + RareTreasures.backPackGold + UseConsumable.scrollGoldBuff + UseConsumable.relicPermaGoldBuff + UpdateGame.goldBuffAmount - UpdateGame.goldDebuffAmount));

                    //Debug.Log(minGoldDouble); Debug.Log(maxGoldDouble);
              }
        }
        #endregion

        isMoving = false;
        moveGold = null;

        gameObject.layer = 5;

        rigidbodyGold.gravityScale = 1;
        rigidbodyGold.velocity = new Vector2(Random.Range(SpawnRewards.minXSpeed, SpawnRewards.maxXSpeed), Random.Range(SpawnRewards.minYSpeed, SpawnRewards.maxYSpeed));

        //Debug.Log(SpawnRewards.gemOnScreenCount);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isMoving == true)
        {
            if (collision.gameObject.tag == "GoldAmountBar")
            {
                //GoldCoin
                if (isNormalGold == true)
                {
                    PlayAudio();
                    BasicCoinGold();

                    return;
                }

                if (is5XGold == true)
                {
                    PlayAudio();
                    GoldCoin5X();
                    return;
                }

                if (is10xGold == true)
                {
                    PlayAudio();
                    GoldCoin10X();
                    return;
                }

                if (is25xGold == true)
                {
                    PlayAudio();
                    GoldCoin25X();
                    return;
                }

                if (is100xGold == true)
                {
                    PlayAudio();
                    GoldCoin100X();
                    return;
                }
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Barrel")
        {
            if (isNormalGold == true)
            {
                PlayAudio();
                BasicCoinGoldBarrel();

                if (UpdateGame.isBarrelEmpty == true)
                {
                    UpdateGame.landedInBarrel = true;
                }
                return;
            }

            if (is5XGold == true)
            {
                PlayAudio();
                Barrel5XCoin();

                if (UpdateGame.isBarrelEmpty == true)
                {
                    UpdateGame.landedInBarrel = true;
                }
                return;
            }

            if (is10xGold == true)
            {
                PlayAudio();
                Barrel10XCoin();

                if (UpdateGame.isBarrelEmpty == true)
                {
                    UpdateGame.landedInBarrel = true;
                }
                return;
            }

            if (is25xGold == true)
            {
                PlayAudio();
                Barrel25XCoin();

                if (UpdateGame.isBarrelEmpty == true)
                {
                    UpdateGame.landedInBarrel = true;
                }

                return;
            }

            if (is100xGold == true)
            {
                PlayAudio();
                Barrel100XCoin();

                if (UpdateGame.isBarrelEmpty == true)
                {
                    UpdateGame.landedInBarrel = true;
                }

                return;
            }
        }
    }


    #region playAdio
    public void PlayAudio()
    {
        int randomGold = Random.Range(1, 6);
        if (AudioManager.audioMuted == 1)
        {
            if (randomGold == 1) { audioManager.Play("CoinSound1"); }
            if (randomGold == 2) { audioManager.Play("CoinSound2"); }
            if (randomGold == 3) { audioManager.Play("CoinSound3"); }
            if (randomGold == 4) { audioManager.Play("CoinSound4"); }
            if (randomGold == 5) { audioManager.Play("CoinSound5"); }
        }
    }

    #endregion

    #region basicCoinNormal
    public void BasicCoinGold()
    {
        SpawnRewards.gemOnScreenCount -= 1;
        plussGold = true;

        goldCountDouble = maxGoldDouble;

        //Debug.Log(maxGoldDouble);

        UpdateGame.totalGoldHigher += goldCountDouble;
        Stats.totalGoldStatsDouble += goldCountDouble;

        ObjectPooling.instance.ReturnGoldFromPool(gameObject);
    }
    #endregion

    #region 5XgoldCoin
    public void GoldCoin5X()
    {
        SpawnRewards.gemOnScreenCount -= 1;
        plussGold = true;
        ObjectPooling.instance.ReturnGold5XFromPool(gameObject);

        goldCountDouble = maxGoldDouble * 5;

        UpdateGame.totalGoldHigher += goldCountDouble;
        Stats.totalGoldStatsDouble += goldCountDouble;
    }
    #endregion

    #region 10XgoldCoin
    public void GoldCoin10X()
    {
        SpawnRewards.gemOnScreenCount -= 1;
        plussGold = true;

        ObjectPooling.instance.ReturnGold10XFromPool(gameObject);
        goldCountDouble = maxGoldDouble * 10;
        UpdateGame.totalGoldHigher += goldCountDouble;
        Stats.totalGoldStatsDouble += goldCountDouble;
    }
    #endregion

    #region 25XgoldCoin
    public void GoldCoin25X()
    {
        SpawnRewards.gemOnScreenCount -= 1;
        plussGold = true;

        ObjectPooling.instance.ReturnGold25XFromPool(gameObject);
        goldCountDouble = maxGoldDouble * 25;
        UpdateGame.totalGoldHigher += goldCountDouble;
        Stats.totalGoldStatsDouble += goldCountDouble;
    }
    #endregion

    #region 100XgoldCoin
    public void GoldCoin100X()
    {
        SpawnRewards.gemOnScreenCount -= 1;
        plussGold = true;

        ObjectPooling.instance.ReturnGold100XFromPool(gameObject);
        goldCountDouble = maxGoldDouble * 100;
        UpdateGame.totalGoldHigher += goldCountDouble;
        Stats.totalGoldStatsDouble += goldCountDouble;
    }
    #endregion

    #region basicCoinNormalBarrel
    public void BasicCoinGoldBarrel()
    {
        SpawnRewards.gemOnScreenCount -= 1;
        plussGoldBarrel = true;
       
        goldCountDouble = maxGoldDouble;
        UpdateGame.barrelOfGoldAmountDouble += (goldCountDouble * (1 + UpdateGame.barrelGoldValue));

        ObjectPooling.instance.ReturnGoldFromPool(gameObject);
    }
    #endregion

    #region 5XNormalBarrel
    public void Barrel5XCoin()
    {
        SpawnRewards.gemOnScreenCount -= 1;
        plussGoldBarrel = true;

        goldCountDouble = maxGoldDouble * 5;
        UpdateGame.barrelOfGoldAmountDouble += (goldCountDouble * (1 + UpdateGame.barrelGoldValue));

        ObjectPooling.instance.ReturnGold5XFromPool(gameObject);
    }
    #endregion

    #region 10XNormalBarrel
    public void Barrel10XCoin()
    {
        SpawnRewards.gemOnScreenCount -= 1;
        plussGoldBarrel = true;

        goldCountDouble = maxGoldDouble * 10;
        UpdateGame.barrelOfGoldAmountDouble += (goldCountDouble * (1 + UpdateGame.barrelGoldValue));

        ObjectPooling.instance.ReturnGold10XFromPool(gameObject);
    }
    #endregion

    #region 25XNormalBarrel
    public void Barrel25XCoin()
    {
        SpawnRewards.gemOnScreenCount -= 1;
        plussGoldBarrel = true;

        goldCountDouble = maxGoldDouble * 25;
        UpdateGame.barrelOfGoldAmountDouble += (goldCountDouble * (1 + UpdateGame.barrelGoldValue));

        ObjectPooling.instance.ReturnGold25XFromPool(gameObject);
    }
    #endregion

    #region 100XNormalBarrel
    public void Barrel100XCoin()
    {
        SpawnRewards.gemOnScreenCount -= 1;
        plussGoldBarrel = true;

        goldCountDouble = maxGoldDouble * 100;
        UpdateGame.barrelOfGoldAmountDouble += (goldCountDouble * (1 + UpdateGame.barrelGoldValue));

        ObjectPooling.instance.ReturnGold100XFromPool(gameObject);
    }
    #endregion

    public GameObject targetGameObjectGoldBar;
    public string targetGameObjectGoldBarName = "TotalGoldBar";

    public bool move;
    public static bool activeInHiercary;

    private void OnMouseEnter()
    {
        if (PlaceMobileButtons.isMobile == false)
        {
            if (AudioManager.audioMuted == 1)
            {
                int random = Random.Range(1, 4);
                if (random == 1) { audioManager.Play("Hover1Swoosh"); }
                if (random == 2) { audioManager.Play("Hover2Swoosh"); }
                if (random == 3) { audioManager.Play("Hover3Swoosh"); }
            }
            Transform targetTransform = targetGameObjectGoldBar.transform;
            StartCoroutine(MoveTowardsTarget(gameObject.transform, targetTransform));
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(PlaceMobileButtons.isMobile == true)
        {
            if (AudioManager.audioMuted == 1)
            {
                int random = Random.Range(1, 4);
                if (random == 1) { audioManager.Play("Hover1Swoosh"); }
                if (random == 2) { audioManager.Play("Hover2Swoosh"); }
                if (random == 3) { audioManager.Play("Hover3Swoosh"); }
            }
            Transform targetTransform = targetGameObjectGoldBar.transform;
            StartCoroutine(MoveTowardsTarget(gameObject.transform, targetTransform));
        }
    }

    public Coroutine moveGold;

    private void Update()
    {
        if (SpawnRewards.gemOnScreenCount > SaveAndLoad.maximumStuffOnScreen)
        {
            Transform targetTransform = targetGameObjectGoldBar.transform;
            if(moveGold == null) { moveGold = StartCoroutine(MoveTowardsTarget(gameObject.transform, targetTransform)); }
        }

        if (SaveAndLoad.pressedResetButton == true)
        {
            Transform targetTransform = targetGameObjectGoldBar.transform;
            StartCoroutine(MoveTowardsTarget(gameObject.transform, targetTransform));
        }

        if(SkillTree.pressedPrestige == true)
        {
            Transform targetTransform = targetGameObjectGoldBar.transform;
            StartCoroutine(MoveTowardsTarget(gameObject.transform, targetTransform));
        }

      
    }

    #region goldMovement
    public bool isMoving;

    IEnumerator MoveTowardsTarget(Transform goldTransform, Transform targetTransform)
    {
        gameObject.layer = 12;
        isMoving = true;
        float totalTime = Random.Range(0.38f, 1.24f);
        float elapsedTime = 0f;
        Vector3 initialPosition = goldTransform.position;

        while (elapsedTime < totalTime)
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime / totalTime);
            goldTransform.position = Vector3.Lerp(initialPosition, targetTransform.position, t);
            yield return null;
        }

        moveGold = null;
    }
    #endregion
}




