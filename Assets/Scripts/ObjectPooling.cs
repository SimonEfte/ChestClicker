using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    public static ObjectPooling instance;

    [SerializeField] private GameObject soulGemPrefab;
    private Queue<GameObject> soulGemPool = new Queue<GameObject>();
    [SerializeField] private int soulGemPoolSize = 20;

    public Transform mimiMimicParent;

    #region goldAndXp
    [SerializeField] private GameObject goldPrefab;
    private Queue<GameObject> goldPool = new Queue<GameObject>();
    [SerializeField] private int goldPoolSize = 100;

    [SerializeField] private GameObject XPPrefab;
    private Queue<GameObject> XPPool = new Queue<GameObject>();
    [SerializeField] private int XPPoolSize = 100;

    [SerializeField] private GameObject Gold5XPrefab;
    private Queue<GameObject> Gold5XPool = new Queue<GameObject>();
    [SerializeField] private int Gold5XPoolSize = 6;

    [SerializeField] private GameObject Gold10XPrefab;
    private Queue<GameObject> Gold10XPool = new Queue<GameObject>();
    [SerializeField] private int Gold10XPoolSize = 20;

    [SerializeField] private GameObject Gold25XPrefab;
    private Queue<GameObject> Gold25XPool = new Queue<GameObject>();
    [SerializeField] private int Gold25XPoolSize = 50;

    [SerializeField] private GameObject Gold100XPrefab;
    private Queue<GameObject> Gold100XPool = new Queue<GameObject>();
    [SerializeField] private int Gold100XPoolSize = 10;

    #endregion

    #region GemsPool
    [SerializeField] private GameObject redGemPrefab;
    private Queue<GameObject> RedGemPool = new Queue<GameObject>();
    [SerializeField] private int RedGemPoolSize = 20;

    [SerializeField] private GameObject amethystGemPrefab;
    private Queue<GameObject> amethystPool = new Queue<GameObject>();
    [SerializeField] private int amethystPoolSize = 20;

    [SerializeField] private GameObject diamondPrefab;
    private Queue<GameObject> diamondPool = new Queue<GameObject>();
    [SerializeField] private int diamondPoolSize = 20;

    [SerializeField] private GameObject violetCrystalPrefab;
    private Queue<GameObject> violetPool = new Queue<GameObject>();
    [SerializeField] private int violetPoolSize = 20;

    [SerializeField] private GameObject yellowSapphirePrefab;
    private Queue<GameObject> yellowSapphirePool = new Queue<GameObject>();
    [SerializeField] private int yellowSapphirePoolSoize = 20;

    [SerializeField] private GameObject greenDiamondPrefab;
    private Queue<GameObject> greenDiamondPool = new Queue<GameObject>();
    [SerializeField] private int greenDiamondPoolSize = 20;

    [SerializeField] private GameObject grandidieritePrefab;
    private Queue<GameObject> grandidieritePool = new Queue<GameObject>();
    [SerializeField] private int grandidieritePoolSize = 20;

    [SerializeField] private GameObject purpleRupeePrefab;
    private Queue<GameObject> purplerupeePool = new Queue<GameObject>();
    [SerializeField] private int purpleRupeePoolSize = 20;

    [SerializeField] private GameObject PinkPlortPrefab;
    private Queue<GameObject> PinkPlortPool = new Queue<GameObject>();
    [SerializeField] private int PinkPlortPoolSize = 20;

    [SerializeField] private GameObject EmeraldPrefab;
    private Queue<GameObject> EmeraldPool = new Queue<GameObject>();
    [SerializeField] private int EmeraldPoolSize = 20;

    [SerializeField] private GameObject QuartzPrefab;
    private Queue<GameObject> QuartzPool = new Queue<GameObject>();
    [SerializeField] private int QuartzPoolSize = 20;

    [SerializeField] private GameObject RedGarnetPrefab;
    private Queue<GameObject> RedGarnetPool = new Queue<GameObject>();
    [SerializeField] private int RedGarnetPoolSize = 20;

    [SerializeField] private GameObject PinkTourmalinePrefab;
    private Queue<GameObject> PinkTourmalinePool = new Queue<GameObject>();
    [SerializeField] private int PinkTourmalinePoolSize = 20;

    [SerializeField] private GameObject YellowTopazPrefab;
    private Queue<GameObject> YellowTopazPool = new Queue<GameObject>();
    [SerializeField] private int YellowTopazPoolSize = 20;

    [SerializeField] private GameObject AquamarinePrefab;
    private Queue<GameObject> AquamarinePool = new Queue<GameObject>();
    [SerializeField] private int AquamarinePoolSize = 20;

    [SerializeField] private GameObject FireOpalPrefab;
    private Queue<GameObject> FireOpalPool = new Queue<GameObject>();
    [SerializeField] private int FireOpalPoolSize = 12;

    [SerializeField] private GameObject GoldenSeaPearlPrefab;
    private Queue<GameObject> GoldenSeaPearlPool = new Queue<GameObject>();
    [SerializeField] private int GoldenSeaPearlPoolSize = 12;

    [SerializeField] private GameObject AkoyaPearlPrefab;
    private Queue<GameObject> AkoyaPearlPool = new Queue<GameObject>();
    [SerializeField] private int AkoyaPearlPoolSize = 12;

    [SerializeField] private GameObject GemSilicaPrefab;
    private Queue<GameObject> GemSilicaPool = new Queue<GameObject>();
    [SerializeField] private int GemSilicaPoolSize = 12;

    [SerializeField] private GameObject AdventurinePrefab;
    private Queue<GameObject> AdventurinePool = new Queue<GameObject>();
    [SerializeField] private int AdventurinePoolSize = 12;

    [SerializeField] private GameObject KyanitePrefab;
    private Queue<GameObject> KyanitePool = new Queue<GameObject>();
    [SerializeField] private int KyanitePoolSize = 12;

    [SerializeField] private GameObject AlbitePrefab;
    private Queue<GameObject> AlbitePool = new Queue<GameObject>();
    [SerializeField] private int AlbitePoolSize = 12;

    [SerializeField] private GameObject blackopelPrefab;
    private Queue<GameObject> blackOpalPool = new Queue<GameObject>();
    [SerializeField] private int blackOpalPoolSize = 12;

    [SerializeField] private GameObject painitePrefab;
    private Queue<GameObject> painitePool = new Queue<GameObject>();
    [SerializeField] private int painitePoolSize = 12;

    [SerializeField] private GameObject tanzanitePrefab;
    private Queue<GameObject> tanzanitePool = new Queue<GameObject>();
    [SerializeField] private int tanzanitePoolSize = 12;

    [SerializeField] private GameObject astraliumPrefab;
    private Queue<GameObject> astraliumPool = new Queue<GameObject>();
    [SerializeField] private int astraliumPoolSize = 12;

    [SerializeField] private GameObject elysiumPrismPrefab;
    private Queue<GameObject> elysiumPrismPool = new Queue<GameObject>();
    [SerializeField] private int elysiumPrismPoolSize = 12;

    [SerializeField] private GameObject aetherfireOpalPrefab;
    private Queue<GameObject> aetherfireOpalPool = new Queue<GameObject>();
    [SerializeField] private int aetherfireOpalPoolSize = 12;

    [SerializeField] private GameObject eldritchStarstonePrefab;
    private Queue<GameObject> eldritchStarstonePool = new Queue<GameObject>();
    [SerializeField] private int eldritchStarstonePoolSize = 12;

    [SerializeField] private GameObject chronolithPrefab;
    private Queue<GameObject> chronolithPool = new Queue<GameObject>();
    [SerializeField] private int chronolithPoolSize = 12;

    [SerializeField] private GameObject sideriumEssencePrefab;
    private Queue<GameObject> sideriumEssencePool = new Queue<GameObject>();
    [SerializeField] private int sideriumEssencePoolSize = 12;

    [SerializeField] private GameObject quasaritePrefab;
    private Queue<GameObject> quasaritePool = new Queue<GameObject>();
    [SerializeField] private int quasaritePoolSize = 12;

    [SerializeField] private GameObject radiantNovaStonePrefab;
    private Queue<GameObject> radiantNovaStonePool = new Queue<GameObject>();
    [SerializeField] private int radiantNovaStonePoolSize = 12;

    [SerializeField] private GameObject soluniumShardPrefab;
    private Queue<GameObject> soluniumShardPool = new Queue<GameObject>();
    [SerializeField] private int soluniumShardPoolSize = 12;

    #endregion

    #region Text

    [SerializeField] private GameObject textPrefab;
    private Queue<GameObject> textPool = new Queue<GameObject>();
    [SerializeField] private int textPoolSize = 99;

    [SerializeField] private GameObject goldTextPrefab;
    private Queue<GameObject> goldTextPool = new Queue<GameObject>();
    [SerializeField] private int goldTextPoolSize = 99;

    [SerializeField] private GameObject miniChestTextPrefab;
    private Queue<GameObject> miniChestTextPool = new Queue<GameObject>();
    [SerializeField] private int miniChestTextPoolSize = 15;

    #endregion

    #region itemsDropPool
    [SerializeField] private GameObject lockPickPrefab;
    private Queue<GameObject> lockPickPool = new Queue<GameObject>();
    [SerializeField] private int lockPickPoolSize = 6;

    [SerializeField] private GameObject hammerPrefab;
    private Queue<GameObject> hammerPool = new Queue<GameObject>();
    [SerializeField] private int hammerPoolSize = 6;

    [SerializeField] private GameObject keyPrefab;
    private Queue<GameObject> keyPool = new Queue<GameObject>();
    [SerializeField] private int keyPoolSize = 6;

    [SerializeField] private GameObject goldenTouchPrefab;
    private Queue<GameObject> goldenTouchPool = new Queue<GameObject>();
    [SerializeField] private int goldenTouchPoolSize = 6;

    [SerializeField] private GameObject treasureBagPrefab;
    private Queue<GameObject> treasureBagPool = new Queue<GameObject>();
    [SerializeField] private int treasureBagPoolSize = 6;

    [SerializeField] private GameObject damagePotionPrefab;
    private Queue<GameObject> damagePotionPool = new Queue<GameObject>();
    [SerializeField] private int damagePotionPoolSize = 6;

    [SerializeField] private GameObject XPPotionPrefab;
    private Queue<GameObject> XPPotionPool = new Queue<GameObject>();
    [SerializeField] private int XPPotionPoolSize = 6;

    [SerializeField] private GameObject lootPotionPrefab;
    private Queue<GameObject> lootPotionPool = new Queue<GameObject>();
    [SerializeField] private int lootPotionPoolSize = 6;

    [SerializeField] private GameObject miniChestPrefab;
    private Queue<GameObject> miniChestPool = new Queue<GameObject>();
    [SerializeField] private int miniChestPoolSize = 25;

    [SerializeField] private GameObject scrollPrefab;
    private Queue<GameObject> scrollPool = new Queue<GameObject>();
    [SerializeField] private int scrollPoolSize = 6;

    [SerializeField] private GameObject gauntletPrefab;
    private Queue<GameObject> gauntletPool = new Queue<GameObject>();
    [SerializeField] private int gauntletPoolSize = 6;

    [SerializeField] private GameObject elixirPrefab;
    private Queue<GameObject> elixirPool = new Queue<GameObject>();
    [SerializeField] private int elixirPoolSize = 6;

    [SerializeField] private GameObject relicPrefab;
    private Queue<GameObject> relicPool = new Queue<GameObject>();
    [SerializeField] private int relicPoolSize = 6;

    [SerializeField] private GameObject knifePrefab;
    private Queue<GameObject> knifePool = new Queue<GameObject>();
    [SerializeField] private int knifePoolSize = 10;

    [SerializeField] private GameObject treasurePotionPrefab;
    private Queue<GameObject> treasurePotionPool = new Queue<GameObject>();
    [SerializeField] private int treasurePotionPoolSize = 7;

    [SerializeField] private GameObject mimicChestPrefab;
    private Queue<GameObject> mimicChestPool = new Queue<GameObject>();
    [SerializeField] private int mimicChestPoolSize = 10;

    #endregion


    //public GameObject

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        #region goldAndXp
        for (int i = 0; i < goldPoolSize; i++)
        {
            float random = Random.Range(0.23f, 0.44f);
            GameObject gold = Instantiate(goldPrefab);
            goldPool.Enqueue(gold);
            gold.SetActive(false);
            gold.transform.SetParent(GameObject.FindGameObjectWithTag("RewardSpawn").transform, true);
            gold.transform.localScale = new Vector3(random, random, random);
        }

        for (int i = 0; i < XPPoolSize; i++)
        {
            GameObject XP = Instantiate(XPPrefab);
            XPPool.Enqueue(XP);
            XP.SetActive(false);
            XP.transform.SetParent(GameObject.FindGameObjectWithTag("TextPopUp").transform, true);
            XP.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
        }

        for (int i = 0; i < Gold5XPoolSize; i++)
        {
            GameObject gold5X = Instantiate(Gold5XPrefab);
            Gold5XPool.Enqueue(gold5X);
            gold5X.SetActive(false);
            gold5X.transform.SetParent(GameObject.FindGameObjectWithTag("RewardSpawn").transform, true);
            gold5X.transform.localScale = new Vector3(0.78f, 0.78f, 0.78f);
        }

        for (int i = 0; i < Gold10XPoolSize; i++)
        {
            GameObject gold10X = Instantiate(Gold10XPrefab);
            Gold10XPool.Enqueue(gold10X);
            gold10X.SetActive(false);
            gold10X.transform.SetParent(GameObject.FindGameObjectWithTag("RewardSpawn").transform, true);
            gold10X.transform.localScale = new Vector3(0.45f, 0.45f, 0.45f);
        }

        for (int i = 0; i < Gold25XPoolSize; i++)
        {
            GameObject gold25X = Instantiate(Gold25XPrefab);
            Gold25XPool.Enqueue(gold25X);
            gold25X.SetActive(false);
            gold25X.transform.SetParent(GameObject.FindGameObjectWithTag("RewardSpawn").transform, true);
            gold25X.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
        }

        for (int i = 0; i < Gold100XPoolSize; i++)
        {
            GameObject gold100X = Instantiate(Gold100XPrefab);
            Gold100XPool.Enqueue(gold100X);
            gold100X.SetActive(false);
            gold100X.transform.SetParent(GameObject.FindGameObjectWithTag("RewardSpawn").transform, true);
            gold100X.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
        }

        for (int i = 0; i < miniChestPoolSize; i++)
        {
            GameObject miniChest = Instantiate(miniChestPrefab);
            miniChestPool.Enqueue(miniChest);
            miniChest.SetActive(false);
            miniChest.transform.SetParent(mimiMimicParent);
            miniChest.transform.localScale = new Vector3(2f, 2f, 2f);
        }
        #endregion

        #region RareRewardDrops 1-3 RedGem, amethyst, diamond

        for (int i = 0; i < RedGemPoolSize; i++)
        {
            GameObject redGem = Instantiate(redGemPrefab);
            RedGemPool.Enqueue(redGem);
            redGem.SetActive(false);
            redGem.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            redGem.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
        }

        for (int i = 0; i < amethystPoolSize; i++)
        {
            GameObject amethyst = Instantiate(amethystGemPrefab);
            amethystPool.Enqueue(amethyst);
            amethyst.SetActive(false);
            amethyst.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            amethyst.transform.localScale = new Vector3(1f, 1f, 1f);
            amethyst.transform.position = new Vector3(0, 0, 1);
        }

        for (int i = 0; i < diamondPoolSize; i++)
        {
            GameObject diamond = Instantiate(diamondPrefab);
            diamondPool.Enqueue(diamond);
            diamond.SetActive(false);
            diamond.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            diamond.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
            diamond.transform.position = new Vector3(0, 0, 1);
        }

        #endregion

        #region RareRewardDrops 4-6 violetCrystal, yellowSapphire, greenDiamod

        for (int i = 0; i < violetPoolSize; i++)
        {
            GameObject violet = Instantiate(violetCrystalPrefab);
            violetPool.Enqueue(violet);
            violet.SetActive(false);
            violet.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            violet.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
            violet.transform.position = new Vector3(1, 2, 1);
        }

        for (int i = 0; i < yellowSapphirePoolSoize; i++)
        {
            GameObject yellowSapphire = Instantiate(yellowSapphirePrefab);
            yellowSapphirePool.Enqueue(yellowSapphire);
            yellowSapphire.SetActive(false);
            yellowSapphire.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            yellowSapphire.transform.localScale = new Vector3(0.65f, 0.65f, 0.65f);
            yellowSapphire.transform.position = new Vector3(1.5f, 3, 1);
        }

        for (int i = 0; i < greenDiamondPoolSize; i++)
        {
            GameObject greenDiamond = Instantiate(greenDiamondPrefab);
            greenDiamondPool.Enqueue(greenDiamond);
            greenDiamond.SetActive(false);
            greenDiamond.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            greenDiamond.transform.localScale = new Vector3(1.15f, 1.15f, 1.15f);
            greenDiamond.transform.position = new Vector3(1.5f, 3, 1);
        }

        #endregion

        #region RareRewardDrops 7-9 grandidierite, purpleRupee, pinkPlort

        for (int i = 0; i < grandidieritePoolSize; i++)
        {
            GameObject grandidierite = Instantiate(grandidieritePrefab);
            grandidieritePool.Enqueue(grandidierite);
            grandidierite.SetActive(false);
            grandidierite.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            grandidierite.transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
            grandidierite.transform.position = new Vector3(0f, 0, 0);
        }

        for (int i = 0; i < purpleRupeePoolSize; i++)
        {
            GameObject purpleRupee = Instantiate(purpleRupeePrefab);
            purplerupeePool.Enqueue(purpleRupee);
            purpleRupee.SetActive(false);
            purpleRupee.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            purpleRupee.transform.localScale = new Vector3(1.32f, 1.32f, 1.32f);
            purpleRupee.transform.position = new Vector3(0f, 0, 0);
        }

        for (int i = 0; i < PinkPlortPoolSize; i++)
        {
            GameObject pinkPlort = Instantiate(PinkPlortPrefab);
            PinkPlortPool.Enqueue(pinkPlort);
            pinkPlort.SetActive(false);
            pinkPlort.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            pinkPlort.transform.localScale = new Vector3(0.75f, 0.7f, 0.7f);
            pinkPlort.transform.position = new Vector3(0f, 0, 0);
        }

        #endregion

        #region RareRewardDrops 10-12 emerald, quartz, redGarnet

        for (int i = 0; i < EmeraldPoolSize; i++)
        {
            GameObject emerald = Instantiate(EmeraldPrefab);
            EmeraldPool.Enqueue(emerald);
            emerald.SetActive(false);
            emerald.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            emerald.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            emerald.transform.position = new Vector3(0f, 0, 0);
        }

        for (int i = 0; i < QuartzPoolSize; i++)
        {
            GameObject quartz = Instantiate(QuartzPrefab);
            QuartzPool.Enqueue(quartz);
            quartz.SetActive(false);
            quartz.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            quartz.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            quartz.transform.position = new Vector3(0f, 0, 0);
        }

        for (int i = 0; i < RedGarnetPoolSize; i++)
        {
            GameObject redGarnet = Instantiate(RedGarnetPrefab);
            RedGarnetPool.Enqueue(redGarnet);
            redGarnet.SetActive(false);
            redGarnet.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            redGarnet.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
            redGarnet.transform.position = new Vector3(0f, 0, 0);
        }

        #endregion

        #region RareRewardDrops 13-15 PinkTourmaline, YellowTopaz, Aquamarine

        for (int i = 0; i < PinkTourmalinePoolSize; i++)
        {
            GameObject pinkTourmaline = Instantiate(PinkTourmalinePrefab);
            PinkTourmalinePool.Enqueue(pinkTourmaline);
            pinkTourmaline.SetActive(false);
            pinkTourmaline.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            pinkTourmaline.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            pinkTourmaline.transform.position = new Vector3(0f, 0, 0);
        }

        for (int i = 0; i < YellowTopazPoolSize; i++)
        {
            GameObject yellowTopaz = Instantiate(YellowTopazPrefab);
            YellowTopazPool.Enqueue(yellowTopaz);
            yellowTopaz.SetActive(false);
            yellowTopaz.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            yellowTopaz.transform.localScale = new Vector3(0.70f, 0.70f, 0.70f);
            yellowTopaz.transform.position = new Vector3(0f, 0, 0);
        }

        for (int i = 0; i < AquamarinePoolSize; i++)
        {
            GameObject aquamarine = Instantiate(AquamarinePrefab);
            AquamarinePool.Enqueue(aquamarine);
            aquamarine.SetActive(false);
            aquamarine.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            aquamarine.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
            aquamarine.transform.position = new Vector3(0f, 0, 0);
        }


        #endregion

        #region RareRewardDrops 16-18 PinkOpal, GoldenSeaPearl, OkoyaPearl

        for (int i = 0; i < FireOpalPoolSize; i++)
        {
            GameObject fireOpal = Instantiate(FireOpalPrefab);
            FireOpalPool.Enqueue(fireOpal);
            fireOpal.SetActive(false);
            fireOpal.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            fireOpal.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
            fireOpal.transform.position = new Vector3(0f, 0, 0);
        }

        for (int i = 0; i < GoldenSeaPearlPoolSize; i++)
        {
            GameObject goldenSeaPearl = Instantiate(GoldenSeaPearlPrefab);
            GoldenSeaPearlPool.Enqueue(goldenSeaPearl);
            goldenSeaPearl.SetActive(false);
            goldenSeaPearl.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            goldenSeaPearl.transform.localScale = new Vector3(0.68f, 0.68f, 0.68f);
            goldenSeaPearl.transform.position = new Vector3(0f, 0, 0);
        }

        for (int i = 0; i < AkoyaPearlPoolSize; i++)
        {
            GameObject akoyaPearl = Instantiate(AkoyaPearlPrefab);
            AkoyaPearlPool.Enqueue(akoyaPearl);
            akoyaPearl.SetActive(false);
            akoyaPearl.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            akoyaPearl.transform.localScale = new Vector3(0.68f, 0.68f, 0.68f);
            akoyaPearl.transform.position = new Vector3(0f, 0, 0);
        }

        #endregion

        #region RareRewardDrops 19-21 gemSiliza, adventurine, kyanite

        for (int i = 0; i < GemSilicaPoolSize; i++)
        {
            GameObject gemSilica = Instantiate(GemSilicaPrefab);
            GemSilicaPool.Enqueue(gemSilica);
            gemSilica.SetActive(false);
            gemSilica.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            gemSilica.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            gemSilica.transform.position = new Vector3(0f, 0, 0);
        }

        for (int i = 0; i < AdventurinePoolSize; i++)
        {
            GameObject Adventurine = Instantiate(AdventurinePrefab);
            AdventurinePool.Enqueue(Adventurine);
            Adventurine.SetActive(false);
            Adventurine.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            Adventurine.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
            Adventurine.transform.position = new Vector3(0f, 0, 0);
        }


        for (int i = 0; i < KyanitePoolSize; i++)
        {
            GameObject kyanite = Instantiate(KyanitePrefab);
            KyanitePool.Enqueue(kyanite);
            kyanite.SetActive(false);
            kyanite.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            kyanite.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            kyanite.transform.position = new Vector3(0f, 0, 0);
        }

        #endregion

        #region RareRewardDrops 22-24 albite blackOpal painite

        for (int i = 0; i < AlbitePoolSize; i++)
        {
            GameObject albite = Instantiate(AlbitePrefab);
            AlbitePool.Enqueue(albite);
            albite.SetActive(false);
            albite.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            albite.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
            albite.transform.position = new Vector3(0f, 0, 0);
        }

        for (int i = 0; i < blackOpalPoolSize; i++)
        {
            GameObject blackOpal = Instantiate(blackopelPrefab);
            blackOpalPool.Enqueue(blackOpal);
            blackOpal.SetActive(false);
            blackOpal.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            blackOpal.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
            blackOpal.transform.position = new Vector3(0f, 0, 0);
        }

        for (int i = 0; i < painitePoolSize; i++)
        {
            GameObject painite = Instantiate(painitePrefab);
            painitePool.Enqueue(painite);
            painite.SetActive(false);
            painite.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            painite.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
            painite.transform.position = new Vector3(0f, 0, 0);
        }

        #endregion

        #region gemDrops25 tanzanite

        for (int i = 0; i < tanzanitePoolSize; i++)
        {
            GameObject tanzanite = Instantiate(tanzanitePrefab);
            tanzanitePool.Enqueue(tanzanite);
            tanzanite.SetActive(false);
            tanzanite.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            tanzanite.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
            tanzanite.transform.position = new Vector3(0f, 0, 0);
        }

        #endregion

        #region gemDrops26-28 Astralium ElysiumPrism AetherfireOpal

        for (int i = 0; i < astraliumPoolSize; i++)
        {
            GameObject Astralium = Instantiate(astraliumPrefab);
            astraliumPool.Enqueue(Astralium);
            Astralium.SetActive(false);
            Astralium.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            Astralium.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
            Astralium.transform.position = new Vector3(0f, 0, 0);
        }

        for (int i = 0; i < elysiumPrismPoolSize; i++)
        {
            GameObject ElysiumPrism = Instantiate(elysiumPrismPrefab);
            elysiumPrismPool.Enqueue(ElysiumPrism);
            ElysiumPrism.SetActive(false);
            ElysiumPrism.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            ElysiumPrism.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
            ElysiumPrism.transform.position = new Vector3(0f, 0, 0);
        }

        for (int i = 0; i < aetherfireOpalPoolSize; i++)
        {
            GameObject AetherfireOpal = Instantiate(aetherfireOpalPrefab);
            aetherfireOpalPool.Enqueue(AetherfireOpal);
            AetherfireOpal.SetActive(false);
            AetherfireOpal.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            AetherfireOpal.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
            AetherfireOpal.transform.position = new Vector3(0f, 0, 0);
        }
        #endregion

        #region gemDrops29-31 EldritchStarstone ChronolithShard SideriumEssence

        for (int i = 0; i < eldritchStarstonePoolSize; i++)
        {
            GameObject EldritchStarstone = Instantiate(eldritchStarstonePrefab);
            eldritchStarstonePool.Enqueue(EldritchStarstone);
            EldritchStarstone.SetActive(false);
            EldritchStarstone.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            EldritchStarstone.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
            EldritchStarstone.transform.position = new Vector3(0f, 0, 0);
        }

        for (int i = 0; i < chronolithPoolSize; i++)
        {
            GameObject ChronolithShard = Instantiate(chronolithPrefab);
            chronolithPool.Enqueue(ChronolithShard);
            ChronolithShard.SetActive(false);
            ChronolithShard.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            ChronolithShard.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
            ChronolithShard.transform.position = new Vector3(0f, 0, 0);
        }

        for (int i = 0; i < sideriumEssencePoolSize; i++)
        {
            GameObject SideriumEssence = Instantiate(sideriumEssencePrefab);
            sideriumEssencePool.Enqueue(SideriumEssence);
            SideriumEssence.SetActive(false);
            SideriumEssence.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            SideriumEssence.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
            SideriumEssence.transform.position = new Vector3(0f, 0, 0);
        }

        #endregion

        #region gemDrops32-34 Quasarite RadiantNovaStone SoluniumShard

        for (int i = 0; i < quasaritePoolSize; i++)
        {
            GameObject Quasarite = Instantiate(quasaritePrefab);
            quasaritePool.Enqueue(Quasarite);
            Quasarite.SetActive(false);
            Quasarite.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            Quasarite.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
            Quasarite.transform.position = new Vector3(0f, 0, 0);
        }

        for (int i = 0; i < radiantNovaStonePoolSize; i++)
        {
            GameObject RadiantNovaStone = Instantiate(radiantNovaStonePrefab);
            radiantNovaStonePool.Enqueue(RadiantNovaStone);
            RadiantNovaStone.SetActive(false);
            RadiantNovaStone.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            RadiantNovaStone.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
            RadiantNovaStone.transform.position = new Vector3(0f, 0, 0);
        }

        for (int i = 0; i < soluniumShardPoolSize; i++)
        {
            GameObject SoluniumShard = Instantiate(soluniumShardPrefab);
            soluniumShardPool.Enqueue(SoluniumShard);
            SoluniumShard.SetActive(false);
            SoluniumShard.transform.SetParent(GameObject.FindGameObjectWithTag("RareDrops").transform, true);
            SoluniumShard.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
            SoluniumShard.transform.position = new Vector3(0f, 0, 0);
        }

        #endregion

        #region itemsPool 1-3 LockPick hammer key
        for (int i = 0; i < lockPickPoolSize; i++)
        {
            GameObject lockPick = Instantiate(lockPickPrefab);
            lockPickPool.Enqueue(lockPick);
            lockPick.SetActive(false);
            lockPick.transform.SetParent(GameObject.FindGameObjectWithTag("Iems").transform, true);
            lockPick.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
            lockPick.transform.position = new Vector3(0f, 0, 0);
        }

        for (int i = 0; i < hammerPoolSize; i++)
        {
            GameObject hammer = Instantiate(hammerPrefab);
            hammerPool.Enqueue(hammer);
            hammer.SetActive(false);
            hammer.transform.SetParent(GameObject.FindGameObjectWithTag("Iems").transform, true);
            hammer.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
            hammer.transform.position = new Vector3(0f, 0, 0);
        }

        for (int i = 0; i < keyPoolSize; i++)
        {
            GameObject key = Instantiate(keyPrefab);
            keyPool.Enqueue(key);
            key.SetActive(false);
            key.transform.SetParent(GameObject.FindGameObjectWithTag("Iems").transform, true);
            key.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
            key.transform.position = new Vector3(0f, 0, 0);
        }

        #endregion

        #region itemsPool 4-6 goldenTouch treasurebag damagePotion

        for (int i = 0; i < goldenTouchPoolSize; i++)
        {
            GameObject goldeTouch = Instantiate(goldenTouchPrefab);
            goldenTouchPool.Enqueue(goldeTouch);
            goldeTouch.SetActive(false);
            goldeTouch.transform.SetParent(GameObject.FindGameObjectWithTag("Iems").transform, true);
            goldeTouch.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
            goldeTouch.transform.position = new Vector3(0f, 0, 0);
        }

        for (int i = 0; i < treasureBagPoolSize; i++)
        {
            GameObject treasureBag = Instantiate(treasureBagPrefab);
            treasureBagPool.Enqueue(treasureBag);
            treasureBag.SetActive(false);
            treasureBag.transform.SetParent(GameObject.FindGameObjectWithTag("Iems").transform, true);
            treasureBag.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
            treasureBag.transform.position = new Vector3(0f, 0, 0);
        }

        for (int i = 0; i < damagePotionPoolSize; i++)
        {
            GameObject damagePotion = Instantiate(damagePotionPrefab);
            damagePotionPool.Enqueue(damagePotion);
            damagePotion.SetActive(false);
            damagePotion.transform.SetParent(GameObject.FindGameObjectWithTag("Iems").transform, true);
            damagePotion.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
            damagePotion.transform.position = new Vector3(0f, 0, 0);
        }

        #endregion

        #region itemsPool 7-9 XPPotion lootPotion scroll

        for (int i = 0; i < XPPotionPoolSize; i++)
        {
            GameObject xpPotion = Instantiate(XPPotionPrefab);
            XPPotionPool.Enqueue(xpPotion);
            xpPotion.SetActive(false);
            xpPotion.transform.SetParent(GameObject.FindGameObjectWithTag("Iems").transform, true);
            xpPotion.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
            xpPotion.transform.position = new Vector3(0f, 0, 0);
        }

        for (int i = 0; i < lootPotionPoolSize; i++)
        {
            GameObject lootPotion = Instantiate(lootPotionPrefab);
            lootPotionPool.Enqueue(lootPotion);
            lootPotion.SetActive(false);
            lootPotion.transform.SetParent(GameObject.FindGameObjectWithTag("Iems").transform, true);
            lootPotion.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
            lootPotion.transform.position = new Vector3(0f, 0, 0);
        }

        for (int i = 0; i < scrollPoolSize; i++)
        {
            GameObject scroll = Instantiate(scrollPrefab);
            scrollPool.Enqueue(scroll);
            scroll.SetActive(false);
            scroll.transform.SetParent(GameObject.FindGameObjectWithTag("Iems").transform, true);
            scroll.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
            scroll.transform.position = new Vector3(0f, 0, 0);
        }

        #endregion

        #region itemsPool 10-12 gaunlet elixir relic

        for (int i = 0; i < gauntletPoolSize; i++)
        {
            GameObject gauntlet = Instantiate(gauntletPrefab);
            gauntletPool.Enqueue(gauntlet);
            gauntlet.SetActive(false);
            gauntlet.transform.SetParent(GameObject.FindGameObjectWithTag("Iems").transform, true);
            gauntlet.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
            gauntlet.transform.position = new Vector3(0f, 0, 0);
        }

        for (int i = 0; i < elixirPoolSize; i++)
        {
            GameObject elixir = Instantiate(elixirPrefab);
            elixirPool.Enqueue(elixir);
            elixir.SetActive(false);
            elixir.transform.SetParent(GameObject.FindGameObjectWithTag("Iems").transform, true);
            elixir.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
            elixir.transform.position = new Vector3(0f, 0, 0);
        }

        for (int i = 0; i < relicPoolSize; i++)
        {
            GameObject relic = Instantiate(relicPrefab);
            relicPool.Enqueue(relic);
            relic.SetActive(false);
            relic.transform.SetParent(GameObject.FindGameObjectWithTag("Iems").transform, true);
            relic.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
            relic.transform.position = new Vector3(0f, 0, 0);
        }
        #endregion

        #region itemsPool knife treasurePotion mimicChest

        for (int i = 0; i < knifePoolSize; i++)
        {
            GameObject knife = Instantiate(knifePrefab);
            knifePool.Enqueue(knife);
            knife.SetActive(false);
            knife.transform.SetParent(GameObject.FindGameObjectWithTag("Iems").transform, true);
            knife.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
            knife.transform.position = new Vector3(0f, 0, 0);
        }

        for (int i = 0; i < treasurePotionPoolSize; i++)
        {
            GameObject treasurePotion = Instantiate(treasurePotionPrefab);
            treasurePotionPool.Enqueue(treasurePotion);
            treasurePotion.SetActive(false);
            treasurePotion.transform.SetParent(GameObject.FindGameObjectWithTag("Iems").transform, true);
            treasurePotion.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
            treasurePotion.transform.position = new Vector3(0f, 0, 0);
        }

        for (int i = 0; i < mimicChestPoolSize; i++)
        {
            GameObject mimicChest = Instantiate(mimicChestPrefab);
            mimicChestPool.Enqueue(mimicChest);
            mimicChest.SetActive(false);
            mimicChest.transform.SetParent(mimiMimicParent);
            mimicChest.transform.localScale = new Vector3(2f, 2f, 2f);
            mimicChest.transform.position = new Vector3(0f, 0, 0);
        }

        #endregion

        #region text
        for (int i = 0; i < textPoolSize; i++)
        {
            GameObject text = Instantiate(textPrefab);
            textPool.Enqueue(text);
            text.SetActive(false);
            text.transform.SetParent(GameObject.FindGameObjectWithTag("TextPopUp").transform, true);
            text.transform.localScale = new Vector3(1f, 1f, 1f);
            text.transform.position = new Vector3(0, 0, 1);
        }

        for (int i = 0; i < goldTextPoolSize; i++)
        {
            GameObject goldText = Instantiate(goldTextPrefab);
            goldTextPool.Enqueue(goldText);
            goldText.SetActive(false);
            goldText.transform.SetParent(GameObject.FindGameObjectWithTag("GoldText").transform, true);
            goldText.transform.localScale = new Vector3(1f, 1f, 1f);
            goldText.transform.position = new Vector3(0, 0, 1);
        }

        for (int i = 0; i < miniChestTextPoolSize; i++)
        {
            GameObject miniChestText = Instantiate(miniChestTextPrefab);
            miniChestTextPool.Enqueue(miniChestText);
            miniChestText.SetActive(false);
            miniChestText.transform.SetParent(GameObject.FindGameObjectWithTag("TextPopUp").transform, true);
            miniChestText.transform.localScale = new Vector3(1f, 1f, 1f);
            miniChestText.transform.position = new Vector3(0, 0, 1);
        }

        #endregion

        #region soulGem
        for (int i = 0; i < soulGemPoolSize; i++)
        {
            GameObject soulGem = Instantiate(soulGemPrefab);
            soulGemPool.Enqueue(soulGem);
            soulGem.SetActive(false);
            soulGem.transform.SetParent(GameObject.FindGameObjectWithTag("Iems").transform, true);
            soulGem.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            soulGem.transform.position = new Vector3(0, 0, 1);
        }
        #endregion
    }

    public Transform relicParentForMobile;

    #region goldAndXp
    public GameObject GetGoldFromPool()
    {
        if (goldPool.Count > 0)
        {
            GameObject gold = goldPool.Dequeue();
            gold.SetActive(true);
            return gold;
        }
        else
        {
            GameObject gold = Instantiate(goldPrefab);
            return gold;

        }
    }

    public void ReturnGoldFromPool(GameObject gold)
    {
        goldPool.Enqueue(gold);
        gold.SetActive(false);
    }

    public GameObject GetXPFromPool()
    {
        if (XPPool.Count > 0)
        {
            GameObject XP = XPPool.Dequeue();
            XP.SetActive(true);
            return XP;
        }
        else
        {
            GameObject XP = Instantiate(XPPrefab);
            return XP;

        }
    }

    public void ReturnXPFromPool(GameObject XP)
    {
        XPPool.Enqueue(XP);
        XP.SetActive(false);
    }

    public GameObject GetGold5XFromPool()
    {
        if (Gold5XPool.Count > 0)
        {
            GameObject gold5x = Gold5XPool.Dequeue();
            gold5x.SetActive(true);
            return gold5x;
        }
        else
        {
            GameObject gold5x = Instantiate(Gold5XPrefab);
            return gold5x;

        }
    }

    public void ReturnGold5XFromPool(GameObject gold5x)
    {
        Gold5XPool.Enqueue(gold5x);
        gold5x.SetActive(false);
    }


    public GameObject GetGold10XFromPool()
    {
        if (Gold10XPool.Count > 0)
        {
            GameObject gold10x = Gold10XPool.Dequeue();
            gold10x.SetActive(true);
            return gold10x;
        }
        else
        {
            GameObject gold10x = Instantiate(Gold10XPrefab);
            return gold10x;

        }
    }

    public void ReturnGold10XFromPool(GameObject gold10x)
    {
        Gold10XPool.Enqueue(gold10x);
        gold10x.SetActive(false);
    }

    public GameObject GetGold25XFromPool()
    {
        if (Gold25XPool.Count > 0)
        {
            GameObject gold25x = Gold25XPool.Dequeue();
            gold25x.SetActive(true);
            return gold25x;
        }
        else
        {
            GameObject gold25x = Instantiate(Gold25XPrefab);
            return gold25x;

        }
    }

    public void ReturnGold25XFromPool(GameObject gold25x)
    {
        Gold25XPool.Enqueue(gold25x);
        gold25x.SetActive(false);
    }


    public GameObject GetGold100XFromPool()
    {
        if (Gold100XPool.Count > 0)
        {
            GameObject gold100x = Gold100XPool.Dequeue();
            gold100x.SetActive(true);
            return gold100x;
        }
        else
        {
            GameObject gold100x = Instantiate(Gold100XPrefab);
            return gold100x;
        }
    }

    public void ReturnGold100XFromPool(GameObject gold100x)
    {
        Gold100XPool.Enqueue(gold100x);
        gold100x.SetActive(false);
    }

    #endregion

    #region gemDrops1-3 RedGem, amethyst, diamond
    public GameObject GetRedGemFromPool()
    {
        if (RedGemPool.Count > 0)
        {
            GameObject redGem = RedGemPool.Dequeue();
            redGem.SetActive(true);
            return redGem;
        }
        else
        {
            GameObject redGem = Instantiate(redGemPrefab);
            return redGem;

        }
    }

    public void ReturnRedGemFromPool(GameObject redGem)
    {
        RedGemPool.Enqueue(redGem);
        redGem.SetActive(false);
    }


    public GameObject GetAmethystFromPool()
    {
        if (amethystPool.Count > 0)
        {
            GameObject amethys = amethystPool.Dequeue();
            amethys.SetActive(true);
            return amethys;
        }
        else
        {
            GameObject amethys = Instantiate(amethystGemPrefab);
            return amethys;

        }
    }

    public void ReturnAmethystFromPool(GameObject amethys)
    {
        amethystPool.Enqueue(amethys);
        amethys.SetActive(false);
    }


    public GameObject GetDiamondFromPool()
    {
        if (diamondPool.Count > 0)
        {
            GameObject diamond = diamondPool.Dequeue();
            diamond.SetActive(true);
            return diamond;
        }
        else
        {
            GameObject diamond = Instantiate(diamondPrefab);
            return diamond;

        }
    }

    public void ReturnDiamondFromPool(GameObject diamond)
    {
        diamondPool.Enqueue(diamond);
        diamond.SetActive(false);
    }
    #endregion

    #region gemDrops4-6 violetCrystal, yellowSapphire, greenDiamod

    public GameObject GetVoiletFromPool()
    {
        if (violetPool.Count > 0)
        {
            GameObject violet = violetPool.Dequeue();
            violet.SetActive(true);
            return violet;
        }
        else
        {
            GameObject violet = Instantiate(violetCrystalPrefab);
            return violet;

        }
    }

    public void ReturnVoiletFromPool(GameObject violet)
    {
        violetPool.Enqueue(violet);
        violet.SetActive(false);
    }


    public GameObject GetYellowSapphireFromPool()
    {
        if (yellowSapphirePool.Count > 0)
        {
            GameObject yellowSapphire = yellowSapphirePool.Dequeue();
            yellowSapphire.SetActive(true);
            return yellowSapphire;
        }
        else
        {
            GameObject yellowSapphire = Instantiate(yellowSapphirePrefab);
            return yellowSapphire;

        }
    }

    public void ReturnYellowSapphireFromPool(GameObject yellowSapphire)
    {
        yellowSapphirePool.Enqueue(yellowSapphire);
        yellowSapphire.SetActive(false);
    }


    public GameObject GetGreenDiamondfromPool()
    {
        if (greenDiamondPool.Count > 0)
        {
            GameObject greenDiamond = greenDiamondPool.Dequeue();
            greenDiamond.SetActive(true);
            return greenDiamond;
        }
        else
        {
            GameObject greenDiamond = Instantiate(greenDiamondPrefab);
            return greenDiamond;

        }
    }

    public void ReturnGreenDiamondFromPool(GameObject greenDiamond)
    {
        greenDiamondPool.Enqueue(greenDiamond);
        greenDiamond.SetActive(false);
    }

    #endregion

    #region gemFrops7-9 grandidierite, purpleRupee, pinkPlort

    public GameObject GetGrandidieriteToPool()
    {
        if (grandidieritePool.Count > 0)
        {
            GameObject grandidierite = grandidieritePool.Dequeue();
            grandidierite.SetActive(true);
            return grandidierite;
        }
        else
        {
            GameObject grandidierite = Instantiate(grandidieritePrefab);
            return grandidierite;

        }
    }

    public void ReturnGrandidieriteFromPool(GameObject grandidierite)
    {
        grandidieritePool.Enqueue(grandidierite);
        grandidierite.SetActive(false);
    }



    public GameObject GetPurpleRupeeFromPool()
    {
        if (purplerupeePool.Count > 0)
        {
            GameObject purpleRupee = purplerupeePool.Dequeue();
            purpleRupee.SetActive(true);
            return purpleRupee;
        }
        else
        {
            GameObject purpleRupee = Instantiate(purpleRupeePrefab);
            return purpleRupee;

        }
    }

    public void ReturnPurpleRupeeFromPool(GameObject purpleRupee)
    {
        purplerupeePool.Enqueue(purpleRupee);
        purpleRupee.SetActive(false);
    }



    public GameObject GetPinkPlortFromPool()
    {
        if (PinkPlortPool.Count > 0)
        {
            GameObject pinkPlort = PinkPlortPool.Dequeue();
            pinkPlort.SetActive(true);
            return pinkPlort;
        }
        else
        {
            GameObject pinkPlort = Instantiate(PinkPlortPrefab);
            return pinkPlort;

        }
    }

    public void ReturnPinkPlortFromPool(GameObject pinkPlort)
    {
        PinkPlortPool.Enqueue(pinkPlort);
        pinkPlort.SetActive(false);
    }

    #endregion

    #region gemDrops10-12 emerald quartz redGarnet

    public GameObject GetEmeraldFromPool()
    {
        if (EmeraldPool.Count > 0)
        {
            GameObject emerald = EmeraldPool.Dequeue();
            emerald.SetActive(true);
            return emerald;
        }
        else
        {
            GameObject emerald = Instantiate(EmeraldPrefab);
            return emerald;

        }
    }

    public void ReturnEmeraldFromPool(GameObject emerald)
    {
        EmeraldPool.Enqueue(emerald);
        emerald.SetActive(false);
    }



    public GameObject GetQuartzFromPool()
    {
        if (QuartzPool.Count > 0)
        {
            GameObject quartz = QuartzPool.Dequeue();
            quartz.SetActive(true);
            return quartz;
        }
        else
        {
            GameObject quartz = Instantiate(QuartzPrefab);
            return quartz;

        }
    }

    public void ReturnQuartzFromPool(GameObject quartz)
    {
        QuartzPool.Enqueue(quartz);
        quartz.SetActive(false);
    }



    public GameObject GetRedGarnetFromPool()
    {
        if (RedGarnetPool.Count > 0)
        {
            GameObject RedGarnet = RedGarnetPool.Dequeue();
            RedGarnet.SetActive(true);
            return RedGarnet;
        }
        else
        {
            GameObject RedGarnet = Instantiate(RedGarnetPrefab);
            return RedGarnet;

        }
    }

    public void ReturnRedGarnetFromPool(GameObject RedGarnet)
    {
        RedGarnetPool.Enqueue(RedGarnet);
        RedGarnet.SetActive(false);
    }

    #endregion

    #region gemDrops13-15 PinkTourmaline YellowTopaz Aquamarine

    public GameObject GetPinkTourmalineFromPool()
    {
        if (PinkTourmalinePool.Count > 0)
        {
            GameObject PinkTourmaline = PinkTourmalinePool.Dequeue();
            PinkTourmaline.SetActive(true);
            return PinkTourmaline;
        }
        else
        {
            GameObject PinkTourmaline = Instantiate(PinkTourmalinePrefab);
            return PinkTourmaline;

        }
    }

    public void ReturnPinkTourmalineFromPool(GameObject PinkTourmaline)
    {
        PinkTourmalinePool.Enqueue(PinkTourmaline);
        PinkTourmaline.SetActive(false);
    }


    public GameObject GetYellowTopazFromPool()
    {
        if (YellowTopazPool.Count > 0)
        {
            GameObject yellowTopaz = YellowTopazPool.Dequeue();
            yellowTopaz.SetActive(true);
            return yellowTopaz;
        }
        else
        {
            GameObject yellowTopaz = Instantiate(YellowTopazPrefab);
            return yellowTopaz;

        }
    }

    public void ReturnYellowTopazFromPool(GameObject yellowTopaz)
    {
        YellowTopazPool.Enqueue(yellowTopaz);
        yellowTopaz.SetActive(false);
    }


    public GameObject GetAquamarineFromPool()
    {
        if (AquamarinePool.Count > 0)
        {
            GameObject Aquamarine = AquamarinePool.Dequeue();
            Aquamarine.SetActive(true);
            return Aquamarine;
        }
        else
        {
            GameObject Aquamarine = Instantiate(AquamarinePrefab);
            return Aquamarine;

        }
    }

    public void ReturnAquamarineFromPool(GameObject Aquamarine)
    {
        AquamarinePool.Enqueue(Aquamarine);
        Aquamarine.SetActive(false);
    }

    #endregion

    #region gemDrops16-18 FireOpal GoldeSeaPearl AkoyaPearl

    public GameObject GetFireOpalFromPool()
    {
        if (FireOpalPool.Count > 0)
        {
            GameObject fireOpal = FireOpalPool.Dequeue();
            fireOpal.SetActive(true);
            return fireOpal;
        }
        else
        {
            GameObject fireOpal = Instantiate(FireOpalPrefab);
            return fireOpal;

        }
    }

    public void ReturnFireOpalFromPool(GameObject fireOpal)
    {
        FireOpalPool.Enqueue(fireOpal);
        fireOpal.SetActive(false);
    }


    public GameObject GetGoldenSeaPearlFromPool()
    {
        if (GoldenSeaPearlPool.Count > 0)
        {
            GameObject goldenSeaPearl = GoldenSeaPearlPool.Dequeue();
            goldenSeaPearl.SetActive(true);
            return goldenSeaPearl;
        }
        else
        {
            GameObject goldenSeaPearl = Instantiate(GoldenSeaPearlPrefab);
            return goldenSeaPearl;
        }
    }

    public void ReturnGoldenSeaPearlFromPool(GameObject goldenSeaPearl)
    {
        GoldenSeaPearlPool.Enqueue(goldenSeaPearl);
        goldenSeaPearl.SetActive(false);
    }


    public GameObject GetAkoyaPearlFromPool()
    {
        if (AkoyaPearlPool.Count > 0)
        {
            GameObject akoyaPearl = AkoyaPearlPool.Dequeue();
            akoyaPearl.SetActive(true);
            return akoyaPearl;
        }
        else
        {
            GameObject akoyaPearl = Instantiate(GoldenSeaPearlPrefab);
            return akoyaPearl;
        }
    }

    public void ReturnAkoyaPearlFromPool(GameObject akoyaPearl)
    {
        AkoyaPearlPool.Enqueue(akoyaPearl);
        akoyaPearl.SetActive(false);
    }

    #endregion

    #region gemDrops19-21 GemSilica adventurine kyanite

    public GameObject GetGemSilicaFromPool()
    {
        if (GemSilicaPool.Count > 0)
        {
            GameObject gemSilica = GemSilicaPool.Dequeue();
            gemSilica.SetActive(true);
            return gemSilica;
        }
        else
        {
            GameObject gemSilica = Instantiate(GemSilicaPrefab);
            return gemSilica;

        }
    }

    public void ReturnGemSilicaFromPool(GameObject gemSilica)
    {
        GemSilicaPool.Enqueue(gemSilica);
        gemSilica.SetActive(false);
    }

    public GameObject GetAdventurineFromPool()
    {
        if (AdventurinePool.Count > 0)
        {
            GameObject adventurine = AdventurinePool.Dequeue();
            adventurine.SetActive(true);
            return adventurine;
        }
        else
        {
            GameObject adventurine = Instantiate(AdventurinePrefab);
            return adventurine;

        }
    }

    public void ReturnAdventurineFromPool(GameObject adventurine)
    {
        AdventurinePool.Enqueue(adventurine);
        adventurine.SetActive(false);
    }

    public GameObject GetKyaniteFromPool()
    {
        if (KyanitePool.Count > 0)
        {
            GameObject kyanite = KyanitePool.Dequeue();
            kyanite.SetActive(true);
            return kyanite;
        }
        else
        {
            GameObject kyanite = Instantiate(KyanitePrefab);
            return kyanite;

        }
    }

    public void ReturnKyaniteFromPool(GameObject kyanite)
    {
        KyanitePool.Enqueue(kyanite);
        kyanite.SetActive(false);
    }


    #endregion

    #region gemDrops22-24 albite blackOpal painite

    public GameObject GetAlbiteFromPool()
    {
        if (AlbitePool.Count > 0)
        {
            GameObject albite = AlbitePool.Dequeue();
            albite.SetActive(true);
            return albite;
        }
        else
        {
            GameObject albite = Instantiate(GemSilicaPrefab);
            return albite;

        }
    }

    public void ReturnAlbiteFromPool(GameObject albite)
    {
        AlbitePool.Enqueue(albite);
        albite.SetActive(false);
    }


    public GameObject GetBlackOpalFromPool()
    {
        if (blackOpalPool.Count > 0)
        {
            GameObject blackOpal = blackOpalPool.Dequeue();
            blackOpal.SetActive(true);
            return blackOpal;
        }
        else
        {
            GameObject blackOpal = Instantiate(blackopelPrefab);
            return blackOpal;

        }
    }

    public void ReturnBlackOpalFromPool(GameObject blackOpal)
    {
        blackOpalPool.Enqueue(blackOpal);
        blackOpal.SetActive(false);
    }





    public GameObject GetPainiteFromPool()
    {
        if (painitePool.Count > 0)
        {
            GameObject painite = painitePool.Dequeue();
            painite.SetActive(true);
            return painite;
        }
        else
        {
            GameObject painite = Instantiate(painitePrefab);
            return painite;

        }
    }

    public void ReturnPainiteFromPool(GameObject painite)
    {
        painitePool.Enqueue(painite);
        painite.SetActive(false);
    }

    #endregion

    #region gemDrops25 tanzanite
    public GameObject GetTanzaniteFromPool()
    {
        if (tanzanitePool.Count > 0)
        {
            GameObject tanzanite = tanzanitePool.Dequeue();
            tanzanite.SetActive(true);
            return tanzanite;
        }
        else
        {
            GameObject tanzanite = Instantiate(tanzanitePrefab);
            return tanzanite;

        }
    }

    public void ReturnTanzaniteFromPool(GameObject tanzanite)
    {
        tanzanitePool.Enqueue(tanzanite);
        tanzanite.SetActive(false);
    }
    #endregion

    #region gemDrops26-28 Astralium ElysiumPrism AetherfireOpal
    public GameObject GetAstraliumFromPool()
    {
        if (astraliumPool.Count > 0)
        {
            GameObject Astralium = astraliumPool.Dequeue();
            Astralium.SetActive(true);
            return Astralium;
        }
        else
        {
            GameObject Astralium = Instantiate(astraliumPrefab);
            return Astralium;

        }
    }

    public void ReturnAstraliumFromPool(GameObject Astralium)
    {
        astraliumPool.Enqueue(Astralium);
        Astralium.SetActive(false);
    }



    public GameObject GetElysiumPrismFromPool()
    {
        if (elysiumPrismPool.Count > 0)
        {
            GameObject ElysiumPrism = elysiumPrismPool.Dequeue();
            ElysiumPrism.SetActive(true);
            return ElysiumPrism;
        }
        else
        {
            GameObject ElysiumPrism = Instantiate(elysiumPrismPrefab);
            return ElysiumPrism;

        }
    }

    public void ReturnElysiumPrismFromPool(GameObject ElysiumPrism)
    {
        elysiumPrismPool.Enqueue(ElysiumPrism);
        ElysiumPrism.SetActive(false);
    }



    public GameObject GetAetherfireOpalFromPool()
    {
        if (aetherfireOpalPool.Count > 0)
        {
            GameObject AetherfireOpal = aetherfireOpalPool.Dequeue();
            AetherfireOpal.SetActive(true);
            return AetherfireOpal;
        }
        else
        {
            GameObject AetherfireOpal = Instantiate(aetherfireOpalPrefab);
            return AetherfireOpal;

        }
    }

    public void ReturnAetherfireOpalFromPool(GameObject AetherfireOpal)
    {
        aetherfireOpalPool.Enqueue(AetherfireOpal);
        AetherfireOpal.SetActive(false);
    }
    #endregion

    #region gemDrops26-28 EldritchStarstone ChronolithShard SideriumEssence
    public GameObject GetEldritchStarstoneFromPool()
    {
        if (eldritchStarstonePool.Count > 0)
        {
            GameObject EldritchStarstone = eldritchStarstonePool.Dequeue();
            EldritchStarstone.SetActive(true);
            return EldritchStarstone;
        }
        else
        {
            GameObject EldritchStarstone = Instantiate(eldritchStarstonePrefab);
            return EldritchStarstone;

        }
    }

    public void ReturnEldritchStarstoneFromPool(GameObject EldritchStarstone)
    {
        eldritchStarstonePool.Enqueue(EldritchStarstone);
        EldritchStarstone.SetActive(false);
    }


    public GameObject GetChronolithShardFromPool()
    {
        if (chronolithPool.Count > 0)
        {
            GameObject ChronolithShard = chronolithPool.Dequeue();
            ChronolithShard.SetActive(true);
            return ChronolithShard;
        }
        else
        {
            GameObject ChronolithShard = Instantiate(chronolithPrefab);
            return ChronolithShard;

        }
    }

    public void ReturnChronolithShardFromPool(GameObject ChronolithShard)
    {
        chronolithPool.Enqueue(ChronolithShard);
        ChronolithShard.SetActive(false);
    }



    public GameObject GetSideriumEssenceFromPool()
    {
        if (sideriumEssencePool.Count > 0)
        {
            GameObject SideriumEssence = sideriumEssencePool.Dequeue();
            SideriumEssence.SetActive(true);
            return SideriumEssence;
        }
        else
        {
            GameObject SideriumEssence = Instantiate(sideriumEssencePrefab);
            return SideriumEssence;

        }
    }

    public void ReturnSideriumEssenceFromPool(GameObject SideriumEssence)
    {
        sideriumEssencePool.Enqueue(SideriumEssence);
        SideriumEssence.SetActive(false);
    }
    #endregion

    #region gemDrops29-31 Quasarite RadiantNovaStone SoluniumShard
    public GameObject GetQuasariteFromPool()
    {
        if (quasaritePool.Count > 0)
        {
            GameObject Quasarite = quasaritePool.Dequeue();
            Quasarite.SetActive(true);
            return Quasarite;
        }
        else
        {
            GameObject Quasarite = Instantiate(quasaritePrefab);
            return Quasarite;

        }
    }

    public void ReturnQuasariteFromPool(GameObject Quasarite)
    {
        quasaritePool.Enqueue(Quasarite);
        Quasarite.SetActive(false);
    }


    public GameObject GetRadiantNovaStoneFromPool()
    {
        if (radiantNovaStonePool.Count > 0)
        {
            GameObject RadiantNovaStone = radiantNovaStonePool.Dequeue();
            RadiantNovaStone.SetActive(true);
            return RadiantNovaStone;
        }
        else
        {
            GameObject RadiantNovaStone = Instantiate(radiantNovaStonePrefab);
            return RadiantNovaStone;

        }
    }

    public void ReturnRadiantNovaStoneFromPool(GameObject RadiantNovaStone)
    {
        radiantNovaStonePool.Enqueue(RadiantNovaStone);
        RadiantNovaStone.SetActive(false);
    }



    public GameObject GetSoluniumShardFromPool()
    {
        if (soluniumShardPool.Count > 0)
        {
            GameObject SoluniumShard = soluniumShardPool.Dequeue();
            SoluniumShard.SetActive(true);
            return SoluniumShard;
        }
        else
        {
            GameObject SoluniumShard = Instantiate(soluniumShardPrefab);
            return SoluniumShard;

        }
    }

    public void ReturnSoluniumShardeFromPool(GameObject SoluniumShard)
    {
        soluniumShardPool.Enqueue(SoluniumShard);
        SoluniumShard.SetActive(false);
    }
    #endregion


    #region itemsPool 1-3 LockPick hammer key
    public GameObject GetLockPickFromPool()
    {
        if (lockPickPool.Count > 0)
        {
            GameObject lockPick = lockPickPool.Dequeue();
            lockPick.SetActive(true);
            return lockPick;
        }
        else
        {
            GameObject lockPick = Instantiate(lockPickPrefab);
            return lockPick;

        }
    }

    public void ReturnLockPickFromPool(GameObject lockPick)
    {
        lockPickPool.Enqueue(lockPick);
        lockPick.SetActive(false);
    }

    public GameObject GetHammerFromPool()
    {
        if (hammerPool.Count > 0)
        {
            GameObject hammer = hammerPool.Dequeue();
            hammer.SetActive(true);
            return hammer;
        }
        else
        {
            GameObject hammer = Instantiate(hammerPrefab);
            return hammer;

        }
    }

    public void ReturnHammerFromPool(GameObject hammer)
    {
        hammerPool.Enqueue(hammer);
        hammer.SetActive(false);
    }



    public GameObject GetKeyFromPool()
    {
        if (keyPool.Count > 0)
        {
            GameObject key = keyPool.Dequeue();
            key.SetActive(true);
            return key;
        }
        else
        {
            GameObject key = Instantiate(keyPrefab);
            return key;

        }
    }

    public void ReturnKeyFromPool(GameObject key)
    {
        keyPool.Enqueue(key);
        key.SetActive(false);
    }

    #endregion

    #region itemsPool 4-6 goldenTouch treasurebag damagePotion

    public GameObject GetGoldeTouchFromPool()
    {
        if (goldenTouchPool.Count > 0)
        {
            GameObject goldenTouch = goldenTouchPool.Dequeue();
            goldenTouch.SetActive(true);
            return goldenTouch;
        }
        else
        {
            GameObject goldenTouch = Instantiate(goldenTouchPrefab);
            return goldenTouch;

        }
    }

    public void ReturnGoldenTouchFromPool(GameObject goldenTouch)
    {
        goldenTouchPool.Enqueue(goldenTouch);
        goldenTouch.SetActive(false);
    }


    public GameObject GetTreasureBagFromPool()
    {
        if (treasureBagPool.Count > 0)
        {
            GameObject treasureBag = treasureBagPool.Dequeue();
            treasureBag.SetActive(true);
            return treasureBag;
        }
        else
        {
            GameObject treasureBag = Instantiate(treasureBagPrefab);
            return treasureBag;

        }
    }

    public void ReturnTreasureBadFromPool(GameObject treasureBag)
    {
        treasureBagPool.Enqueue(treasureBag);
        treasureBag.SetActive(false);
    }



    public GameObject GetDamagePotionFromPool()
    {
        if (damagePotionPool.Count > 0)
        {
            GameObject damagePotion = damagePotionPool.Dequeue();
            damagePotion.SetActive(true);
            return damagePotion;
        }
        else
        {
            GameObject damagePotion = Instantiate(damagePotionPrefab);
            return damagePotion;

        }
    }

    public void ReturnDamagePotionFromPool(GameObject damagePotion)
    {
        damagePotionPool.Enqueue(damagePotion);
        damagePotion.SetActive(false);
    }


    #endregion

    #region itemsPool 7-9 XPPotion lootPotion scroll

    public GameObject GetXPPotionFromPool()
    {
        if (XPPotionPool.Count > 0)
        {
            GameObject XPPotion = XPPotionPool.Dequeue();
            XPPotion.SetActive(true);
            return XPPotion;
        }
        else
        {
            GameObject XPPotion = Instantiate(XPPotionPrefab);
            return XPPotion;

        }
    }

    public void ReturnXPPotionFromPool(GameObject XPPotion)
    {
        XPPotionPool.Enqueue(XPPotion);
        XPPotion.SetActive(false);
    }


    public GameObject GetLootPotionFromPool()
    {
        if (lootPotionPool.Count > 0)
        {
            GameObject lootPotion = lootPotionPool.Dequeue();
            lootPotion.SetActive(true);
            return lootPotion;
        }
        else
        {
            GameObject lootPotion = Instantiate(lootPotionPrefab);
            return lootPotion;

        }
    }

    public void ReturnLootPotionFromPool(GameObject lootPotion)
    {
        lootPotionPool.Enqueue(lootPotion);
        lootPotion.SetActive(false);
    }


    public GameObject GetScrollFromPool()
    {
        if (scrollPool.Count > 0)
        {
            GameObject scroll = scrollPool.Dequeue();
            scroll.SetActive(true);
            return scroll;
        }
        else
        {
            GameObject scroll = Instantiate(scrollPrefab);
            return scroll;

        }
    }

    public void ReturnScrollFromPool(GameObject scroll)
    {
        scrollPool.Enqueue(scroll);
        scroll.SetActive(false);
    }

    #endregion

    #region itemsPool 10-12 gaunlet elixir relic

    public GameObject GetGauntletFromPool()
    {
        if (gauntletPool.Count > 0)
        {
            GameObject gauntlet = gauntletPool.Dequeue();
            gauntlet.SetActive(true);
            return gauntlet;
        }
        else
        {
            GameObject gauntlet = Instantiate(gauntletPrefab);
            return gauntlet;

        }
    }

    public void ReturnGauntletFromPool(GameObject gauntlet)
    {
        gauntletPool.Enqueue(gauntlet);
        gauntlet.SetActive(false);
    }


    public GameObject GetElixirFromPool()
    {
        if (elixirPool.Count > 0)
        {
            GameObject elixir = elixirPool.Dequeue();
            elixir.SetActive(true);
            return elixir;
        }
        else
        {
            GameObject elixir = Instantiate(elixirPrefab);
            return elixir;

        }
    }

    public void ReturnElixirFromPool(GameObject elixir)
    {
        elixirPool.Enqueue(elixir);
        elixir.SetActive(false);
    }


    public GameObject GetRelicFromPool()
    {
        if (relicPool.Count > 0)
        {
            GameObject relic = relicPool.Dequeue();
            relic.SetActive(true);
            return relic;
        }
        else
        {
            GameObject relic = Instantiate(relicPrefab);
            return relic;

        }
    }

    public void ReturnRelicFromPool(GameObject relic)
    {
        relicPool.Enqueue(relic);
        relic.SetActive(false);
    }

    #endregion

    #region itemsPool knife treasurePotion mimicChest
    public GameObject GetKnifeFromPool()
    {
        if (knifePool.Count > 0)
        {
            GameObject knife = knifePool.Dequeue();
            knife.SetActive(true);
            return knife;
        }
        else
        {
            GameObject knife = Instantiate(knifePrefab);
            return knife;
        }
    }

    public void ReturnKnifeFromPool(GameObject knife)
    {
        knifePool.Enqueue(knife);
        knife.SetActive(false);
    }



    public GameObject GetTreasurePotionFromPool()
    {
        if (treasurePotionPool.Count > 0)
        {
            GameObject treasurePotion = treasurePotionPool.Dequeue();
            treasurePotion.SetActive(true);
            return treasurePotion;
        }
        else
        {
            GameObject treasurePotion = Instantiate(treasurePotionPrefab);
            return treasurePotion;
        }
    }

    public void ReturnTreasurePotionFromPool(GameObject treasurePotion)
    {
        treasurePotionPool.Enqueue(treasurePotion);
        treasurePotion.SetActive(false);
    }



    public GameObject GetMimicChestFromPool()
    {
        if (mimicChestPool.Count > 0)
        {
            GameObject mimicChest = mimicChestPool.Dequeue();
            mimicChest.SetActive(true);
            return mimicChest;
        }
        else
        {
            GameObject mimicChest = Instantiate(mimicChestPrefab);
            return mimicChest;
        }
    }

    public void ReturnMimicChestFromPool(GameObject mimicChest)
    {
        mimicChestPool.Enqueue(mimicChest);
        mimicChest.SetActive(false);
    }

    #endregion


    #region text
    public GameObject GetTextFromPool()
    {
        if (textPool.Count > 0)
        {
            GameObject text = textPool.Dequeue();
            text.SetActive(true);
            return text;
        }
        else
        {
            GameObject text = Instantiate(textPrefab);
            return text;

        }
    }

    public void ReturnTextFromPool(GameObject text)
    {
        textPool.Enqueue(text);
        text.SetActive(false);
    }


    public GameObject GetGoldTextFromPool()
    {
        if (goldTextPool.Count > 0)
        {
            GameObject goldText = goldTextPool.Dequeue();
            goldText.SetActive(true);
            return goldText;
        }
        else
        {
            GameObject goldText = Instantiate(goldTextPrefab);
            return goldText;

        }
    }

    public void ReturnGoldTextFromPool(GameObject goldText)
    {
        goldTextPool.Enqueue(goldText);
        goldText.SetActive(false);
    }


    public GameObject GetMiniChestTextFromPool()
    {
        if (miniChestTextPool.Count > 0)
        {
            GameObject miniChestText = miniChestTextPool.Dequeue();
            miniChestText.SetActive(true);
            return miniChestText;
        }
        else
        {
            GameObject miniChestText = Instantiate(miniChestTextPrefab);
            return miniChestText;

        }
    }

    public void ReturnMiniChestTextFromPool(GameObject miniChestText)
    {
        miniChestTextPool.Enqueue(miniChestText);
        miniChestText.SetActive(false);
    }

    #endregion

    #region miniChest
    public GameObject GetMiniChestFromPool()
    {
        if (miniChestPool.Count > 0)
        {
            GameObject miniChest = miniChestPool.Dequeue();
            miniChest.SetActive(true);
            return miniChest;
        }
        else
        {
            GameObject miniChest = Instantiate(miniChestPrefab);
            return miniChest;

        }
    }

    public void ReturnMiniChestFromPool(GameObject miniChest)
    {
        miniChestPool.Enqueue(miniChest);
        miniChest.SetActive(false);
    }
    #endregion

    #region soul gem
    public GameObject GetSoulGemFromPool()
    {
        if (soulGemPool.Count > 0)
        {
            GameObject soulGem = soulGemPool.Dequeue();
            soulGem.SetActive(true);
            return soulGem;
        }
        else
        {
            GameObject soulGem = Instantiate(soulGemPrefab);
            return soulGem;

        }
    }

    public void ReturnSoulGemFromPool(GameObject soulGem)
    {
        soulGemPool.Enqueue(soulGem);
        soulGem.SetActive(false);
    }
    #endregion
}
