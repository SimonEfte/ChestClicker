using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class treasureBagClick : MonoBehaviour
{
    private Button button;

    public float minXSpeed;
    public float maxXSpeed;
    public float minYSpeed;
    public float maxYSpeed;
    public float gameobjectPosX;
    public float gameobjectPosY;
    public float yposPluss;
    public static bool clickedTreasureBag;
    public bool inactive;

    private void OnEnable()
    {
        StartCoroutine(wait());
        inactive = true;
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(300);
        HandleButtonClick();
    }

    public void Update()
    {
        if(SkillTree.setSoulGemInactive == true && inactive == true)
        {
            StopAllCoroutines();
            ObjectPooling.instance.ReturnTreasureBadFromPool(gameObject);
            inactive = false;
        }
    }

    private void Start()
    {
        yposPluss = 0.69f;

        minXSpeed = -7.2f;
        maxXSpeed = 7.2f;
        minYSpeed = 4.6f;
        maxYSpeed = 8.8f;
        button = GetComponent<Button>();
        button.onClick.AddListener(HandleButtonClick);
    }

    private void HandleButtonClick()
    {
        SpawnRewards.gemOnScreenCount -= 1;

        StopAllCoroutines();
        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("TreasureBagClick"); }
        SpawnRewards.maxTreasuresBags -= 1;

        clickedTreasureBag = true;

        gameobjectPosX = gameObject.transform.position.x;
        gameobjectPosY = gameObject.transform.position.y;

        int random = Random.Range(1, 35);
        int random2 = Random.Range(1, 35);
        
        #region firstGem
        if (random == 1) { GameObject quartz = ObjectPooling.instance.GetQuartzFromPool(); quartz.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); quartz.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 2) { GameObject amethyst = ObjectPooling.instance.GetAmethystFromPool(); amethyst.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); amethyst.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 3) { GameObject yellowTopaz = ObjectPooling.instance.GetYellowTopazFromPool(); yellowTopaz.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); yellowTopaz.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 4) { GameObject albite = ObjectPooling.instance.GetAlbiteFromPool(); albite.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); albite.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 5) { GameObject redGarnet = ObjectPooling.instance.GetRedGarnetFromPool(); redGarnet.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); redGarnet.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 6) { GameObject aquamarine = ObjectPooling.instance.GetAquamarineFromPool(); aquamarine.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); aquamarine.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 7) { GameObject yellowSapphire = ObjectPooling.instance.GetYellowSapphireFromPool(); yellowSapphire.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); yellowSapphire.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 8) { GameObject pinkTourmaline = ObjectPooling.instance.GetPinkTourmalineFromPool(); pinkTourmaline.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); pinkTourmaline.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 9) { GameObject adventurine = ObjectPooling.instance.GetAdventurineFromPool(); adventurine.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); adventurine.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 10) { GameObject redGem = ObjectPooling.instance.GetRedGemFromPool(); redGem.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); redGem.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 11) { GameObject diamond = ObjectPooling.instance.GetDiamondFromPool(); diamond.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); diamond.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 12) { GameObject grandidierite = ObjectPooling.instance.GetGrandidieriteToPool(); grandidierite.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); grandidierite.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 13) { GameObject violet = ObjectPooling.instance.GetVoiletFromPool(); violet.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); violet.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 14) { GameObject akoyaPearl = ObjectPooling.instance.GetAkoyaPearlFromPool(); akoyaPearl.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); akoyaPearl.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 15) { GameObject purpleRupee = ObjectPooling.instance.GetPurpleRupeeFromPool(); purpleRupee.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); purpleRupee.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 16) { GameObject emerald = ObjectPooling.instance.GetEmeraldFromPool(); emerald.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); emerald.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 17) { GameObject greenDiamond = ObjectPooling.instance.GetGreenDiamondfromPool(); greenDiamond.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); greenDiamond.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 18) { GameObject fireOpal = ObjectPooling.instance.GetFireOpalFromPool(); fireOpal.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); fireOpal.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 19) { GameObject gemSilica = ObjectPooling.instance.GetGemSilicaFromPool(); gemSilica.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); gemSilica.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 20) { GameObject pinkPlort = ObjectPooling.instance.GetPinkPlortFromPool(); pinkPlort.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); pinkPlort.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 21) { GameObject goldenSeaPearl = ObjectPooling.instance.GetGoldenSeaPearlFromPool(); goldenSeaPearl.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); goldenSeaPearl.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 22) { GameObject kyanite = ObjectPooling.instance.GetKyaniteFromPool(); kyanite.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); kyanite.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 23) { GameObject blackOpal = ObjectPooling.instance.GetBlackOpalFromPool(); blackOpal.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); blackOpal.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 24) { GameObject painite = ObjectPooling.instance.GetPainiteFromPool(); painite.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); painite.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 25) { GameObject tanzanite = ObjectPooling.instance.GetTanzaniteFromPool(); tanzanite.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); tanzanite.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 26) { GameObject astralium = ObjectPooling.instance.GetAstraliumFromPool(); astralium.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); astralium.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 27) { GameObject elysiumPrism = ObjectPooling.instance.GetElysiumPrismFromPool(); elysiumPrism.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); elysiumPrism.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 28) { GameObject aerthfireOpal = ObjectPooling.instance.GetAetherfireOpalFromPool(); aerthfireOpal.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); aerthfireOpal.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 29) { GameObject eldrishStartStone = ObjectPooling.instance.GetEldritchStarstoneFromPool(); eldrishStartStone.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); eldrishStartStone.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 30) { GameObject chronolithShard = ObjectPooling.instance.GetChronolithShardFromPool(); chronolithShard.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); chronolithShard.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 31) { GameObject sideriumEssence = ObjectPooling.instance.GetSideriumEssenceFromPool(); sideriumEssence.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); sideriumEssence.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 32) { GameObject quasarite = ObjectPooling.instance.GetQuasariteFromPool(); quasarite.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); quasarite.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 33) { GameObject radiantNovaStone = ObjectPooling.instance.GetRadiantNovaStoneFromPool(); radiantNovaStone.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); radiantNovaStone.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 34) { GameObject solunimShard = ObjectPooling.instance.GetSoluniumShardFromPool(); solunimShard.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); solunimShard.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        #endregion

        #region secondGem
        if (random2 == 1) { GameObject quartz = ObjectPooling.instance.GetQuartzFromPool(); quartz.transform.position = new Vector3((gameobjectPosX + 0.4f), (gameobjectPosY + yposPluss), 0f); quartz.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random2 == 2) { GameObject amethyst = ObjectPooling.instance.GetAmethystFromPool(); amethyst.transform.position = new Vector3((gameobjectPosX + 0.1f), (gameobjectPosY + yposPluss), 0f); amethyst.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random2 == 3) { GameObject yellowTopaz = ObjectPooling.instance.GetYellowTopazFromPool(); yellowTopaz.transform.position = new Vector3((gameobjectPosX + 0.1f), (gameobjectPosY + yposPluss), 0f); yellowTopaz.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random2 == 4) { GameObject albite = ObjectPooling.instance.GetAlbiteFromPool(); albite.transform.position = new Vector3((gameobjectPosX + 0.5f), (gameobjectPosY + yposPluss), 0f); albite.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random2 == 5) { GameObject redGarnet = ObjectPooling.instance.GetRedGarnetFromPool(); redGarnet.transform.position = new Vector3((gameobjectPosX + 0.25f), (gameobjectPosY + yposPluss), 0f); redGarnet.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random2 == 6) { GameObject aquamarine = ObjectPooling.instance.GetAquamarineFromPool(); aquamarine.transform.position = new Vector3(((gameobjectPosX + 0.13f) + 0.21f), (gameobjectPosY + yposPluss), 0f); aquamarine.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random2 == 7) { GameObject yellowSapphire = ObjectPooling.instance.GetYellowSapphireFromPool(); yellowSapphire.transform.position = new Vector3((gameobjectPosX + 0.3f), (gameobjectPosY + yposPluss), 0f); yellowSapphire.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random2 == 8) { GameObject pinkTourmaline = ObjectPooling.instance.GetPinkTourmalineFromPool(); pinkTourmaline.transform.position = new Vector3((gameobjectPosX + 0.35f), (gameobjectPosY + yposPluss), 0f); pinkTourmaline.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random2 == 9) { GameObject adventurine = ObjectPooling.instance.GetAdventurineFromPool(); adventurine.transform.position = new Vector3((gameobjectPosX + 0.23f), (gameobjectPosY + yposPluss), 0f); adventurine.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random2 == 10) { GameObject redGem = ObjectPooling.instance.GetRedGemFromPool(); redGem.transform.position = new Vector3(gameobjectPosX, ((gameobjectPosX + 0.24f) + yposPluss), 0f); redGem.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random2 == 11) { GameObject diamond = ObjectPooling.instance.GetDiamondFromPool(); diamond.transform.position = new Vector3((gameobjectPosX + 0.3f), (gameobjectPosY + yposPluss), 0f); diamond.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random2 == 12) { GameObject grandidierite = ObjectPooling.instance.GetGrandidieriteToPool(); grandidierite.transform.position = new Vector3((gameobjectPosX + 0.24f), (gameobjectPosY + yposPluss), 0f); grandidierite.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random2 == 13) { GameObject violet = ObjectPooling.instance.GetVoiletFromPool(); violet.transform.position = new Vector3((gameobjectPosX + 0.3f), (gameobjectPosY + yposPluss), 0f); violet.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random2 == 14) { GameObject akoyaPearl = ObjectPooling.instance.GetAkoyaPearlFromPool(); akoyaPearl.transform.position = new Vector3((gameobjectPosX + 0.3f), (gameobjectPosY + yposPluss), 0f); akoyaPearl.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random2 == 15) { GameObject purpleRupee = ObjectPooling.instance.GetPurpleRupeeFromPool(); purpleRupee.transform.position = new Vector3((gameobjectPosX + 0.3f), (gameobjectPosY + yposPluss), 0f); purpleRupee.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random2 == 16) { GameObject emerald = ObjectPooling.instance.GetEmeraldFromPool(); emerald.transform.position = new Vector3((gameobjectPosX + 0.3f), (gameobjectPosY + yposPluss), 0f); emerald.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random2 == 17) { GameObject greenDiamond = ObjectPooling.instance.GetGreenDiamondfromPool(); greenDiamond.transform.position = new Vector3((gameobjectPosX + 0.2f), (gameobjectPosY + yposPluss), 0f); greenDiamond.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random2 == 18) { GameObject fireOpal = ObjectPooling.instance.GetFireOpalFromPool(); fireOpal.transform.position = new Vector3((gameobjectPosX + 0.3f), (gameobjectPosY + yposPluss), 0f); fireOpal.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random2 == 19) { GameObject gemSilica = ObjectPooling.instance.GetGemSilicaFromPool(); gemSilica.transform.position = new Vector3((gameobjectPosX + 0.3f), (gameobjectPosY + yposPluss), 0f); gemSilica.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random2 == 20) { GameObject pinkPlort = ObjectPooling.instance.GetPinkPlortFromPool(); pinkPlort.transform.position = new Vector3((gameobjectPosX + 0.3f), (gameobjectPosY + yposPluss), 0f); pinkPlort.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random2 == 21) { GameObject goldenSeaPearl = ObjectPooling.instance.GetGoldenSeaPearlFromPool(); goldenSeaPearl.transform.position = new Vector3((gameobjectPosX + 0.2f), (gameobjectPosY + yposPluss), 0f); goldenSeaPearl.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); }

        if (random2 == 22) { GameObject kyanite = ObjectPooling.instance.GetKyaniteFromPool(); kyanite.transform.position = new Vector3((gameobjectPosX + 0.3f), (gameobjectPosY + yposPluss), 0f); kyanite.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random2 == 23) { GameObject blackOpal = ObjectPooling.instance.GetBlackOpalFromPool(); blackOpal.transform.position = new Vector3((gameobjectPosX + 0.3f), (gameobjectPosY + yposPluss), 0f); blackOpal.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random2 == 24) { GameObject painite = ObjectPooling.instance.GetPainiteFromPool(); painite.transform.position = new Vector3((gameobjectPosX + 0.3f), (gameobjectPosY + yposPluss), 0f); painite.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random2 == 25) { GameObject tanzanite = ObjectPooling.instance.GetTanzaniteFromPool(); tanzanite.transform.position = new Vector3((gameobjectPosX + 0.3f), (gameobjectPosY + yposPluss), 0f); tanzanite.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 26) { GameObject astralium = ObjectPooling.instance.GetAstraliumFromPool(); astralium.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); astralium.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 27) { GameObject elysiumPrism = ObjectPooling.instance.GetElysiumPrismFromPool(); elysiumPrism.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); elysiumPrism.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 28) { GameObject aerthfireOpal = ObjectPooling.instance.GetAetherfireOpalFromPool(); aerthfireOpal.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); aerthfireOpal.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 29) { GameObject eldrishStartStone = ObjectPooling.instance.GetEldritchStarstoneFromPool(); eldrishStartStone.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); eldrishStartStone.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 30) { GameObject chronolithShard = ObjectPooling.instance.GetChronolithShardFromPool(); chronolithShard.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); chronolithShard.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 31) { GameObject sideriumEssence = ObjectPooling.instance.GetSideriumEssenceFromPool(); sideriumEssence.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); sideriumEssence.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 32) { GameObject quasarite = ObjectPooling.instance.GetQuasariteFromPool(); quasarite.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); quasarite.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 33) { GameObject radiantNovaStone = ObjectPooling.instance.GetRadiantNovaStoneFromPool(); radiantNovaStone.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); radiantNovaStone.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }

        if (random == 34) { GameObject solunimShard = ObjectPooling.instance.GetSoluniumShardFromPool(); solunimShard.transform.position = new Vector3(gameobjectPosX, (gameobjectPosY + yposPluss), 0f); solunimShard.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed)); SpawnRewards.gemOnScreenCount += 1; }
        #endregion

        ObjectPooling.instance.ReturnTreasureBadFromPool(gameObject);

    }
}
