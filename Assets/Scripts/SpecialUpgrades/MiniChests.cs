using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniChests : MonoBehaviour
{
    private Button button;
    public float minX = -5f;
    public float maxX = 5f;
    public float minY = -3f;
    public float maxY = 3f;
    public bool resetChest;

    public void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(MiniChestRewards);
    }

    public void Update()
    {
        if(SaveAndLoad.resetMiniChests == true && resetChest == true)
        {
            //Debug.Log("ResetMiniChest");
            ObjectPooling.instance.ReturnMiniChestFromPool(gameObject);
            resetChest = false;
        }
    }


    private void OnEnable()
    {
        if(PlaceMobileButtons.isMobile == true)
        {
            minX = 2f;
            maxX = -2f;
            minY = 2.5f;
            maxY = -2.5f;
        }

        SetRandomPosition();
        resetChest = true;
    }

    private void SetRandomPosition()
    {
       
        Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0f);
        gameObject.transform.position = randomPosition;
        gameObject.GetComponent<Animation>().Play();

        StartCoroutine(DeactivateAfterDelay());
    }


    private System.Collections.IEnumerator DeactivateAfterDelay()
    {
        yield return new WaitForSeconds(2f);

    }

    public static bool miniChestTreasureReward, miniChestGoldReward, miniChestSkillPointReward;

    public void MiniChestRewards()
    {
        if(SpecialUpgradesButtons.isCountdown == true)
        {
            SpecialUpgradesButtons.spawnMiniChest = true;
        }

        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("MiniChestClick"); }
        SpecialUpgradesButtons.clickedMiniChest = true;
        SpecialUpgradesButtons.miniChestText = true;
        int randomChestReward = Random.Range(1,101);
        if(randomChestReward < 12) {
            
            PlayerLevel.skillPoints += ((PlayerLevel.playerLevel / 10) + 1);
            miniChestSkillPointReward = true;
            Stats.totalSkillPoints += ((PlayerLevel.playerLevel / 10) + 1);
        }
        else if(randomChestReward > 50) {

            UpdateGame.totalGoldHigher += ((SelectChests.currentMiniChestGoldValue) * (1 + SkillTree.skillTreeGold + RareTreasures.runeGold + RareTreasures.cookieGold + RareTreasures.backPackGold + UseConsumable.scrollGoldBuff + UseConsumable.relicPermaGoldBuff)) * 300;

            //Debug.Log((((SelectChests.randomMinGold + SelectChests.randomMaxGold) / 2) * (1 + SkillTree.skillTreeGold + RareTreasures.runeGold + RareTreasures.cookieGold + RareTreasures.backPackGold + UseConsumable.scrollGoldBuff + UseConsumable.relicPermaGoldBuff)) * 300);

            miniChestGoldReward = true;
        }
        else
        {
            miniChestTreasureReward = true;
            int random = Random.Range(1, 101);
            if (SelectChests.chest1Active == true)
            {
                GameObject quartz = ObjectPooling.instance.GetQuartzFromPool();
                quartz.transform.position = gameObject.transform.position;
            }
            else if (SelectChests.chest2Active == true)
            {
                GameObject quartz = ObjectPooling.instance.GetQuartzFromPool();
                quartz.transform.position = gameObject.transform.position;
                GameObject amethyst = ObjectPooling.instance.GetAmethystFromPool();
                amethyst.transform.position = gameObject.transform.position;
            }
            else if (SelectChests.chest3Active == true)
            {
                GameObject quartz = ObjectPooling.instance.GetQuartzFromPool();
                quartz.transform.position = gameObject.transform.position;
                GameObject amethyst = ObjectPooling.instance.GetAmethystFromPool();
                amethyst.transform.position = gameObject.transform.position;
                GameObject yellowTopaz = ObjectPooling.instance.GetYellowTopazFromPool();
                yellowTopaz.transform.position = gameObject.transform.position;
            }
            else if (SelectChests.chest4Active == true)
            {
                if (random < 50)
                {
                    GameObject quartz = ObjectPooling.instance.GetQuartzFromPool(); quartz.transform.position = gameObject.transform.position;
                    GameObject amethyst = ObjectPooling.instance.GetAmethystFromPool(); amethyst.transform.position = gameObject.transform.position;
                    GameObject yellowTopaz = ObjectPooling.instance.GetYellowTopazFromPool(); yellowTopaz.transform.position = gameObject.transform.position;
                }
                if (random > 50)
                {
                    GameObject quartz = ObjectPooling.instance.GetQuartzFromPool(); quartz.transform.position = gameObject.transform.position;
                    GameObject amethyst = ObjectPooling.instance.GetAmethystFromPool(); amethyst.transform.position = gameObject.transform.position;
                    GameObject yellowTopaz = ObjectPooling.instance.GetYellowTopazFromPool(); yellowTopaz.transform.position = gameObject.transform.position;
                    GameObject albite = ObjectPooling.instance.GetAlbiteFromPool();
                    albite.transform.position = gameObject.transform.position;
                }
            }
            else if (SelectChests.chest5Active == true)
            {
                if (random >= 1)
                {
                    GameObject quartz = ObjectPooling.instance.GetQuartzFromPool(); quartz.transform.position = gameObject.transform.position;
                    GameObject amethyst = ObjectPooling.instance.GetAmethystFromPool(); amethyst.transform.position = gameObject.transform.position;
                    GameObject yellowTopaz = ObjectPooling.instance.GetYellowTopazFromPool(); yellowTopaz.transform.position = gameObject.transform.position;
                }
                if (random > 50) { GameObject albite = ObjectPooling.instance.GetAlbiteFromPool(); albite.transform.position = gameObject.transform.position; }
                if (random > 85) { GameObject redGarnet = ObjectPooling.instance.GetRedGarnetFromPool(); redGarnet.transform.position = gameObject.transform.position; }
            }
            else if (SelectChests.chest6Active == true)
            {
                if (random >= 1)
                {
                    GameObject amethyst = ObjectPooling.instance.GetAmethystFromPool(); amethyst.transform.position = gameObject.transform.position;
                    GameObject yellowTopaz = ObjectPooling.instance.GetYellowTopazFromPool(); yellowTopaz.transform.position = gameObject.transform.position;
                    GameObject albite = ObjectPooling.instance.GetAlbiteFromPool(); albite.transform.position = gameObject.transform.position;
                }
                if (random >= 50) { GameObject quartz = ObjectPooling.instance.GetQuartzFromPool(); quartz.transform.position = gameObject.transform.position; }
                if (random >= 85) { GameObject redGarnet = ObjectPooling.instance.GetRedGarnetFromPool(); redGarnet.transform.position = gameObject.transform.position; }
            }
            else if (SelectChests.chest7Active == true)
            {
                if (random < 10)
                {
                    GameObject albite = ObjectPooling.instance.GetAlbiteFromPool(); albite.transform.position = gameObject.transform.position;
                    GameObject aquamarine = ObjectPooling.instance.GetAquamarineFromPool(); aquamarine.transform.position = gameObject.transform.position;
                    GameObject quartz = ObjectPooling.instance.GetQuartzFromPool(); quartz.transform.position = gameObject.transform.position;

                }
                if (random >= 10)
                {
                    GameObject redGarnet = ObjectPooling.instance.GetRedGarnetFromPool(); redGarnet.transform.position = gameObject.transform.position;
                    GameObject amethyst = ObjectPooling.instance.GetAmethystFromPool(); amethyst.transform.position = gameObject.transform.position;
                    GameObject yellowTopaz = ObjectPooling.instance.GetYellowTopazFromPool(); yellowTopaz.transform.position = gameObject.transform.position;
                }
            }
            else if (SelectChests.chest8Active == true)
            {
                if (random < 25)
                {
                    GameObject yellowSapphire = ObjectPooling.instance.GetYellowSapphireFromPool(); yellowSapphire.transform.position = gameObject.transform.position;
                    GameObject redGarnet = ObjectPooling.instance.GetRedGarnetFromPool(); redGarnet.transform.position = gameObject.transform.position;
                    GameObject aquamarine = ObjectPooling.instance.GetAquamarineFromPool(); aquamarine.transform.position = gameObject.transform.position;
                    GameObject amethyst = ObjectPooling.instance.GetAmethystFromPool(); amethyst.transform.position = gameObject.transform.position;
                }
                if (random >= 25)
                {
                    GameObject yellowTopaz = ObjectPooling.instance.GetYellowTopazFromPool(); yellowTopaz.transform.position = gameObject.transform.position;
                    GameObject albite = ObjectPooling.instance.GetAlbiteFromPool(); albite.transform.position = gameObject.transform.position;
                    GameObject quartz = ObjectPooling.instance.GetQuartzFromPool(); quartz.transform.position = gameObject.transform.position;
                }

            }
            else if (SelectChests.chest9Active == true)
            {
                if (random <= 20)
                {
                    GameObject amethyst = ObjectPooling.instance.GetAmethystFromPool(); amethyst.transform.position = gameObject.transform.position;
                    GameObject yellowTopaz = ObjectPooling.instance.GetYellowTopazFromPool(); yellowTopaz.transform.position = gameObject.transform.position;
                    GameObject redGarnet = ObjectPooling.instance.GetRedGarnetFromPool(); redGarnet.transform.position = gameObject.transform.position;
                    GameObject aquamarine = ObjectPooling.instance.GetAquamarineFromPool(); aquamarine.transform.position = gameObject.transform.position;
                }

                if (random > 20)
                {
                    GameObject quartz = ObjectPooling.instance.GetQuartzFromPool(); quartz.transform.position = gameObject.transform.position;
                    GameObject albite = ObjectPooling.instance.GetAlbiteFromPool(); albite.transform.position = gameObject.transform.position;
                    GameObject yellowSapphire = ObjectPooling.instance.GetYellowSapphireFromPool(); yellowSapphire.transform.position = gameObject.transform.position;
                }
            }
            else if (SelectChests.chest10Active == true)
            {
                if (random <= 15)
                {
                    GameObject redGarnet = ObjectPooling.instance.GetRedGarnetFromPool(); redGarnet.transform.position = gameObject.transform.position;
                    GameObject pinkTourmaline = ObjectPooling.instance.GetPinkTourmalineFromPool(); pinkTourmaline.transform.position = gameObject.transform.position;
                    GameObject yellowSapphire = ObjectPooling.instance.GetYellowSapphireFromPool(); yellowSapphire.transform.position = gameObject.transform.position;
                    GameObject quartz = ObjectPooling.instance.GetQuartzFromPool(); quartz.transform.position = gameObject.transform.position;
                }
                if (random > 15)
                {
                    GameObject amethyst = ObjectPooling.instance.GetAmethystFromPool(); amethyst.transform.position = gameObject.transform.position;
                    GameObject yellowTopaz = ObjectPooling.instance.GetYellowTopazFromPool(); yellowTopaz.transform.position = gameObject.transform.position;
                    GameObject albite = ObjectPooling.instance.GetAlbiteFromPool(); albite.transform.position = gameObject.transform.position;
                }
                if (random > 90)
                {
                    GameObject aquamarine = ObjectPooling.instance.GetAquamarineFromPool(); aquamarine.transform.position = gameObject.transform.position;

                }

            }
            else if (SelectChests.chest11Active == true)
            {
                if (random <= 10)
                {
                    GameObject quartz = ObjectPooling.instance.GetQuartzFromPool(); quartz.transform.position = gameObject.transform.position;
                    GameObject pinkTourmaline = ObjectPooling.instance.GetPinkTourmalineFromPool(); pinkTourmaline.transform.position = gameObject.transform.position;
                    GameObject yellowSapphire = ObjectPooling.instance.GetYellowSapphireFromPool(); yellowSapphire.transform.position = gameObject.transform.position;
                    GameObject redGarnet = ObjectPooling.instance.GetRedGarnetFromPool(); redGarnet.transform.position = gameObject.transform.position;
                }
                if (random > 10)
                {
                    GameObject amethyst = ObjectPooling.instance.GetAmethystFromPool(); amethyst.transform.position = gameObject.transform.position;
                    GameObject yellowTopaz = ObjectPooling.instance.GetYellowTopazFromPool(); yellowTopaz.transform.position = gameObject.transform.position;
                    GameObject albite = ObjectPooling.instance.GetAlbiteFromPool(); albite.transform.position = gameObject.transform.position;
                }
                if (random > 90) { GameObject aquamarine = ObjectPooling.instance.GetAquamarineFromPool(); aquamarine.transform.position = gameObject.transform.position; }
            }
            else if (SelectChests.chest12Active == true)
            {
                if (random <= 10)
                {
                    GameObject aquamarine = ObjectPooling.instance.GetAquamarineFromPool(); aquamarine.transform.position = gameObject.transform.position;
                    GameObject redGarnet = ObjectPooling.instance.GetRedGarnetFromPool(); redGarnet.transform.position = gameObject.transform.position;
                    GameObject adventurine = ObjectPooling.instance.GetAdventurineFromPool(); adventurine.transform.position = gameObject.transform.position;
                    GameObject amethyst = ObjectPooling.instance.GetAmethystFromPool(); amethyst.transform.position = gameObject.transform.position;
                }
                if (random > 10)
                {
                    GameObject quartz = ObjectPooling.instance.GetQuartzFromPool(); quartz.transform.position = gameObject.transform.position;
                    GameObject yellowTopaz = ObjectPooling.instance.GetYellowTopazFromPool(); yellowTopaz.transform.position = gameObject.transform.position;
                    GameObject albite = ObjectPooling.instance.GetAlbiteFromPool(); albite.transform.position = gameObject.transform.position;
                }
                if (random > 90)
                {
                    GameObject yellowSapphire = ObjectPooling.instance.GetYellowSapphireFromPool(); yellowSapphire.transform.position = gameObject.transform.position;
                    GameObject pinkTourmaline = ObjectPooling.instance.GetPinkTourmalineFromPool(); pinkTourmaline.transform.position = gameObject.transform.position;
                }
            }
            else if (SelectChests.chest13Active == true)
            {
                if (random <= 10)
                {
                    GameObject quartz = ObjectPooling.instance.GetQuartzFromPool(); quartz.transform.position = gameObject.transform.position;
                    GameObject adventurine = ObjectPooling.instance.GetAdventurineFromPool(); adventurine.transform.position = gameObject.transform.position;
                    GameObject aquamarine = ObjectPooling.instance.GetAquamarineFromPool(); aquamarine.transform.position = gameObject.transform.position;
                    GameObject redGarnet = ObjectPooling.instance.GetRedGarnetFromPool(); redGarnet.transform.position = gameObject.transform.position;
                }
                if (random > 10)
                {
                    GameObject amethyst = ObjectPooling.instance.GetAmethystFromPool(); amethyst.transform.position = gameObject.transform.position;
                    GameObject pinkTourmaline = ObjectPooling.instance.GetPinkTourmalineFromPool(); pinkTourmaline.transform.position = gameObject.transform.position;
                    GameObject yellowTopaz = ObjectPooling.instance.GetYellowTopazFromPool(); yellowTopaz.transform.position = gameObject.transform.position;
                }
                if (random > 90) { GameObject albite = ObjectPooling.instance.GetAlbiteFromPool(); albite.transform.position = gameObject.transform.position; }
                if (random <= 95) { GameObject yellowSapphire = ObjectPooling.instance.GetYellowSapphireFromPool(); yellowSapphire.transform.position = gameObject.transform.position; }
            }
            else if (SelectChests.chest14Active == true)
            {
                if (random <= 5)
                {
                    GameObject redGem = ObjectPooling.instance.GetRedGemFromPool(); redGem.transform.position = gameObject.transform.position;
                    GameObject adventurine = ObjectPooling.instance.GetAdventurineFromPool(); adventurine.transform.position = gameObject.transform.position;
                    GameObject albite = ObjectPooling.instance.GetAlbiteFromPool(); albite.transform.position = gameObject.transform.position;
                    GameObject yellowTopaz = ObjectPooling.instance.GetYellowTopazFromPool(); yellowTopaz.transform.position = gameObject.transform.position;
                    GameObject redGarnet = ObjectPooling.instance.GetRedGarnetFromPool(); redGarnet.transform.position = gameObject.transform.position;
                }
                if (random > 5)
                {
                    GameObject quartz = ObjectPooling.instance.GetQuartzFromPool(); quartz.transform.position = gameObject.transform.position;
                    GameObject amethyst = ObjectPooling.instance.GetAmethystFromPool(); amethyst.transform.position = gameObject.transform.position;
                    GameObject aquamarine = ObjectPooling.instance.GetAquamarineFromPool(); aquamarine.transform.position = gameObject.transform.position;
                }
                if (random > 50) { GameObject yellowSapphire = ObjectPooling.instance.GetYellowSapphireFromPool(); yellowSapphire.transform.position = gameObject.transform.position; }
                if (random > 90) { GameObject pinkTourmaline = ObjectPooling.instance.GetPinkTourmalineFromPool(); pinkTourmaline.transform.position = gameObject.transform.position; }
            }
            else if (SelectChests.chest15Active == true)
            {
                if (random <= 6)
                {
                    GameObject redGarnet = ObjectPooling.instance.GetRedGarnetFromPool(); redGarnet.transform.position = gameObject.transform.position;
                    GameObject yellowSapphire = ObjectPooling.instance.GetYellowSapphireFromPool(); yellowSapphire.transform.position = gameObject.transform.position;
                    GameObject albite = ObjectPooling.instance.GetAlbiteFromPool(); albite.transform.position = gameObject.transform.position;
                    GameObject diamond = ObjectPooling.instance.GetDiamondFromPool(); diamond.transform.position = gameObject.transform.position;
                    GameObject pinkTourmaline = ObjectPooling.instance.GetPinkTourmalineFromPool(); pinkTourmaline.transform.position = gameObject.transform.position;
                    GameObject yellowTopaz = ObjectPooling.instance.GetYellowTopazFromPool(); yellowTopaz.transform.position = gameObject.transform.position;
                }
                if (random > 6)
                {
                    GameObject amethyst = ObjectPooling.instance.GetAmethystFromPool(); amethyst.transform.position = gameObject.transform.position;
                    GameObject aquamarine = ObjectPooling.instance.GetAquamarineFromPool(); aquamarine.transform.position = gameObject.transform.position;
                    GameObject adventurine = ObjectPooling.instance.GetAdventurineFromPool(); adventurine.transform.position = gameObject.transform.position;
                }

                if (random > 6) { GameObject quartz = ObjectPooling.instance.GetQuartzFromPool(); quartz.transform.position = gameObject.transform.position; }
                if (random > 6) { GameObject redGem = ObjectPooling.instance.GetRedGemFromPool(); redGem.transform.position = gameObject.transform.position; }
            }
            else if (SelectChests.chest16Active == true)
            {

                if (random <= 6)
                {
                    GameObject albite = ObjectPooling.instance.GetAlbiteFromPool(); albite.transform.position = gameObject.transform.position;
                    GameObject redGarnet = ObjectPooling.instance.GetRedGarnetFromPool(); redGarnet.transform.position = gameObject.transform.position;
                    GameObject redGem = ObjectPooling.instance.GetRedGemFromPool(); redGem.transform.position = gameObject.transform.position;
                    GameObject diamond = ObjectPooling.instance.GetDiamondFromPool(); diamond.transform.position = gameObject.transform.position;
                    GameObject grandidierite = ObjectPooling.instance.GetGrandidieriteToPool(); grandidierite.transform.position = gameObject.transform.position;
                }
                if (random > 6)
                {
                    GameObject aquamarine = ObjectPooling.instance.GetAquamarineFromPool(); aquamarine.transform.position = gameObject.transform.position;
                    GameObject yellowSapphire = ObjectPooling.instance.GetYellowSapphireFromPool(); yellowSapphire.transform.position = gameObject.transform.position;
                    GameObject pinkTourmaline = ObjectPooling.instance.GetPinkTourmalineFromPool(); pinkTourmaline.transform.position = gameObject.transform.position;
                }
                if (random > 60) { GameObject adventurine = ObjectPooling.instance.GetAdventurineFromPool(); adventurine.transform.position = gameObject.transform.position; }

            }
            else if (SelectChests.chest17Active == true)
            {
                if (random <= 6)
                {
                    GameObject grandidierite = ObjectPooling.instance.GetGrandidieriteToPool(); grandidierite.transform.position = gameObject.transform.position;
                    GameObject adventurine = ObjectPooling.instance.GetAdventurineFromPool(); adventurine.transform.position = gameObject.transform.position;
                    GameObject pinkTourmaline = ObjectPooling.instance.GetPinkTourmalineFromPool(); pinkTourmaline.transform.position = gameObject.transform.position;
                    GameObject redGem = ObjectPooling.instance.GetRedGemFromPool(); redGem.transform.position = gameObject.transform.position;
                    GameObject yellowTopaz = ObjectPooling.instance.GetYellowTopazFromPool(); yellowTopaz.transform.position = gameObject.transform.position;
                }
                if (random > 6)
                {
                    GameObject albite = ObjectPooling.instance.GetAlbiteFromPool(); albite.transform.position = gameObject.transform.position;
                    GameObject redGarnet = ObjectPooling.instance.GetRedGarnetFromPool(); redGarnet.transform.position = gameObject.transform.position;
                    GameObject aquamarine = ObjectPooling.instance.GetAquamarineFromPool(); aquamarine.transform.position = gameObject.transform.position;
                }
                if (random > 60) { GameObject yellowSapphire = ObjectPooling.instance.GetYellowSapphireFromPool(); yellowSapphire.transform.position = gameObject.transform.position; }
                if (random > 90) { GameObject diamond = ObjectPooling.instance.GetDiamondFromPool(); diamond.transform.position = gameObject.transform.position; }
            }
            else if (SelectChests.chest18Active == true)
            {
                if (random <= 6)
                {
                    GameObject grandidierite = ObjectPooling.instance.GetGrandidieriteToPool(); grandidierite.transform.position = gameObject.transform.position;
                    GameObject violet = ObjectPooling.instance.GetVoiletFromPool(); violet.transform.position = gameObject.transform.position;
                    GameObject albite = ObjectPooling.instance.GetAlbiteFromPool(); albite.transform.position = gameObject.transform.position;
                    GameObject yellowSapphire = ObjectPooling.instance.GetYellowSapphireFromPool(); yellowSapphire.transform.position = gameObject.transform.position;
                    GameObject redGem = ObjectPooling.instance.GetRedGemFromPool(); redGem.transform.position = gameObject.transform.position;
                }
                if (random > 6)
                {
                    GameObject pinkTourmaline = ObjectPooling.instance.GetPinkTourmalineFromPool(); pinkTourmaline.transform.position = gameObject.transform.position;
                    GameObject adventurine = ObjectPooling.instance.GetAdventurineFromPool(); adventurine.transform.position = gameObject.transform.position;
                    GameObject diamond = ObjectPooling.instance.GetDiamondFromPool(); diamond.transform.position = gameObject.transform.position;
                }
                if (random > 60) { GameObject aquamarine = ObjectPooling.instance.GetAquamarineFromPool(); aquamarine.transform.position = gameObject.transform.position; }
                if (random > 90) { GameObject redGarnet = ObjectPooling.instance.GetRedGarnetFromPool(); redGarnet.transform.position = gameObject.transform.position; }
            }
            else if (SelectChests.chest19Active == true)
            {
                if (random <= 6)
                {
                    GameObject aquamarine = ObjectPooling.instance.GetAquamarineFromPool(); aquamarine.transform.position = gameObject.transform.position;
                    GameObject purpleRupee = ObjectPooling.instance.GetPurpleRupeeFromPool(); purpleRupee.transform.position = gameObject.transform.position;
                    GameObject violet = ObjectPooling.instance.GetVoiletFromPool(); violet.transform.position = gameObject.transform.position;
                    GameObject redGem = ObjectPooling.instance.GetRedGemFromPool(); redGem.transform.position = gameObject.transform.position;
                    GameObject yellowSapphire = ObjectPooling.instance.GetYellowSapphireFromPool(); yellowSapphire.transform.position = gameObject.transform.position;
                }
                if (random > 6)
                {
                    GameObject pinkTourmaline = ObjectPooling.instance.GetPinkTourmalineFromPool(); pinkTourmaline.transform.position = gameObject.transform.position;
                    GameObject adventurine = ObjectPooling.instance.GetAdventurineFromPool(); adventurine.transform.position = gameObject.transform.position;
                    GameObject diamond = ObjectPooling.instance.GetDiamondFromPool(); diamond.transform.position = gameObject.transform.position;
                }
                if (random > 60) { GameObject grandidierite = ObjectPooling.instance.GetGrandidieriteToPool(); grandidierite.transform.position = gameObject.transform.position; }
                if (random > 90) { GameObject akoyaPearl = ObjectPooling.instance.GetAkoyaPearlFromPool(); akoyaPearl.transform.position = gameObject.transform.position; }
            }
            else if (SelectChests.chest20Active == true)
            {
                if (random <= 6)
                {
                    GameObject akoyaPearl = ObjectPooling.instance.GetAkoyaPearlFromPool(); akoyaPearl.transform.position = gameObject.transform.position;
                    GameObject purpleRupee = ObjectPooling.instance.GetPurpleRupeeFromPool(); purpleRupee.transform.position = gameObject.transform.position;
                    GameObject adventurine = ObjectPooling.instance.GetAdventurineFromPool(); adventurine.transform.position = gameObject.transform.position;
                    GameObject redGem = ObjectPooling.instance.GetRedGemFromPool(); redGem.transform.position = gameObject.transform.position;
                    GameObject grandidierite = ObjectPooling.instance.GetGrandidieriteToPool(); grandidierite.transform.position = gameObject.transform.position;
                }
                if (random > 6)
                {
                    GameObject yellowSapphire = ObjectPooling.instance.GetYellowSapphireFromPool(); yellowSapphire.transform.position = gameObject.transform.position;
                    GameObject pinkTourmaline = ObjectPooling.instance.GetPinkTourmalineFromPool(); pinkTourmaline.transform.position = gameObject.transform.position;
                    GameObject diamond = ObjectPooling.instance.GetDiamondFromPool(); diamond.transform.position = gameObject.transform.position;
                }
                if (random > 60) { GameObject violet = ObjectPooling.instance.GetVoiletFromPool(); violet.transform.position = gameObject.transform.position; }
                if (random > 90) { GameObject emerald = ObjectPooling.instance.GetEmeraldFromPool(); emerald.transform.position = gameObject.transform.position; }
            }
            else if (SelectChests.chest21Active == true)
            {
                if (random <= 6)
                {
                    GameObject pinkTourmaline = ObjectPooling.instance.GetPinkTourmalineFromPool(); pinkTourmaline.transform.position = gameObject.transform.position;
                    GameObject akoyaPearl = ObjectPooling.instance.GetAkoyaPearlFromPool(); akoyaPearl.transform.position = gameObject.transform.position;
                    GameObject purpleRupee = ObjectPooling.instance.GetPurpleRupeeFromPool(); purpleRupee.transform.position = gameObject.transform.position;
                    GameObject greenDiamond = ObjectPooling.instance.GetGreenDiamondfromPool(); greenDiamond.transform.position = gameObject.transform.position;
                    GameObject diamond = ObjectPooling.instance.GetDiamondFromPool(); diamond.transform.position = gameObject.transform.position;
                }
                if (random > 6)
                {
                    GameObject redGem = ObjectPooling.instance.GetRedGemFromPool(); redGem.transform.position = gameObject.transform.position;
                    GameObject grandidierite = ObjectPooling.instance.GetGrandidieriteToPool(); grandidierite.transform.position = gameObject.transform.position;
                    GameObject violet = ObjectPooling.instance.GetVoiletFromPool(); violet.transform.position = gameObject.transform.position;
                }
                if (random > 60) { GameObject adventurine = ObjectPooling.instance.GetAdventurineFromPool(); adventurine.transform.position = gameObject.transform.position; }
                if (random > 90) { GameObject emerald = ObjectPooling.instance.GetEmeraldFromPool(); emerald.transform.position = gameObject.transform.position; }
            }
            else if (SelectChests.chest22Active == true)
            {
                if (random <= 6)
                {
                    GameObject adventurine = ObjectPooling.instance.GetAdventurineFromPool(); adventurine.transform.position = gameObject.transform.position;
                    GameObject purpleRupee = ObjectPooling.instance.GetPurpleRupeeFromPool(); purpleRupee.transform.position = gameObject.transform.position;
                    GameObject emerald = ObjectPooling.instance.GetEmeraldFromPool(); emerald.transform.position = gameObject.transform.position;
                    GameObject greenDiamond = ObjectPooling.instance.GetGreenDiamondfromPool(); greenDiamond.transform.position = gameObject.transform.position;
                    GameObject fireOpal = ObjectPooling.instance.GetFireOpalFromPool(); fireOpal.transform.position = gameObject.transform.position;
                }
                if (random > 6)
                {
                    GameObject diamond = ObjectPooling.instance.GetDiamondFromPool(); diamond.transform.position = gameObject.transform.position;
                    GameObject grandidierite = ObjectPooling.instance.GetGrandidieriteToPool(); grandidierite.transform.position = gameObject.transform.position;
                    GameObject violet = ObjectPooling.instance.GetVoiletFromPool(); violet.transform.position = gameObject.transform.position;
                }
                if (random > 60) { GameObject redGem = ObjectPooling.instance.GetRedGemFromPool(); redGem.transform.position = gameObject.transform.position; }
                if (random > 90) { GameObject akoyaPearl = ObjectPooling.instance.GetAkoyaPearlFromPool(); akoyaPearl.transform.position = gameObject.transform.position; }
            }
            else if (SelectChests.chest23Active == true)
            {
                if (random <= 6)
                {
                    GameObject grandidierite = ObjectPooling.instance.GetGrandidieriteToPool(); grandidierite.transform.position = gameObject.transform.position;
                    GameObject violet = ObjectPooling.instance.GetVoiletFromPool(); violet.transform.position = gameObject.transform.position;
                    GameObject gemSilica = ObjectPooling.instance.GetGemSilicaFromPool(); gemSilica.transform.position = gameObject.transform.position;
                    GameObject pinkPlort = ObjectPooling.instance.GetPinkPlortFromPool(); pinkPlort.transform.position = gameObject.transform.position;
                    GameObject emerald = ObjectPooling.instance.GetEmeraldFromPool(); emerald.transform.position = gameObject.transform.position;
                }
                if (random > 6)
                {
                    GameObject akoyaPearl = ObjectPooling.instance.GetAkoyaPearlFromPool(); akoyaPearl.transform.position = gameObject.transform.position;
                    GameObject purpleRupee = ObjectPooling.instance.GetPurpleRupeeFromPool(); purpleRupee.transform.position = gameObject.transform.position;
                    GameObject greenDiamond = ObjectPooling.instance.GetGreenDiamondfromPool(); greenDiamond.transform.position = gameObject.transform.position;
                }
                if (random > 60) { GameObject diamond = ObjectPooling.instance.GetDiamondFromPool(); diamond.transform.position = gameObject.transform.position; }
                if (random > 90) { GameObject fireOpal = ObjectPooling.instance.GetFireOpalFromPool(); fireOpal.transform.position = gameObject.transform.position; }
            }
            else if (SelectChests.chest24Active == true)
            {
                if (random <= 6)
                {
                    GameObject akoyaPearl = ObjectPooling.instance.GetAkoyaPearlFromPool(); akoyaPearl.transform.position = gameObject.transform.position;
                    GameObject purpleRupee = ObjectPooling.instance.GetPurpleRupeeFromPool(); purpleRupee.transform.position = gameObject.transform.position;
                    GameObject goldenSeaPearl = ObjectPooling.instance.GetGoldenSeaPearlFromPool(); goldenSeaPearl.transform.position = gameObject.transform.position;
                    GameObject kyanite = ObjectPooling.instance.GetKyaniteFromPool(); kyanite.transform.position = gameObject.transform.position;
                    GameObject fireOpal = ObjectPooling.instance.GetFireOpalFromPool(); fireOpal.transform.position = gameObject.transform.position;
                }
                if (random > 6)
                {
                    GameObject gemSilica = ObjectPooling.instance.GetGemSilicaFromPool(); gemSilica.transform.position = gameObject.transform.position;
                    GameObject pinkPlort = ObjectPooling.instance.GetPinkPlortFromPool(); pinkPlort.transform.position = gameObject.transform.position;
                    GameObject greenDiamond = ObjectPooling.instance.GetGreenDiamondfromPool(); greenDiamond.transform.position = gameObject.transform.position;
                }
                if (random > 60) { GameObject violet = ObjectPooling.instance.GetVoiletFromPool(); violet.transform.position = gameObject.transform.position; }
                if (random > 90) { GameObject emerald = ObjectPooling.instance.GetEmeraldFromPool(); emerald.transform.position = gameObject.transform.position; }
            }
            else if (SelectChests.chest25Active == true)
            {
                if (random <= 6)
                {
                    GameObject purpleRupee = ObjectPooling.instance.GetPurpleRupeeFromPool(); purpleRupee.transform.position = gameObject.transform.position;
                    GameObject emerald = ObjectPooling.instance.GetEmeraldFromPool(); emerald.transform.position = gameObject.transform.position;
                    GameObject kyanite = ObjectPooling.instance.GetKyaniteFromPool(); kyanite.transform.position = gameObject.transform.position;
                    GameObject blackOpal = ObjectPooling.instance.GetBlackOpalFromPool(); blackOpal.transform.position = gameObject.transform.position;
                    GameObject fireOpal = ObjectPooling.instance.GetFireOpalFromPool(); fireOpal.transform.position = gameObject.transform.position;
                }
                if (random > 6)
                {
                    GameObject gemSilica = ObjectPooling.instance.GetGemSilicaFromPool(); gemSilica.transform.position = gameObject.transform.position;
                    GameObject pinkPlort = ObjectPooling.instance.GetPinkPlortFromPool(); pinkPlort.transform.position = gameObject.transform.position;
                    GameObject goldenSeaPearl = ObjectPooling.instance.GetGoldenSeaPearlFromPool(); goldenSeaPearl.transform.position = gameObject.transform.position;
                }
                if (random > 60) { GameObject akoyaPearl = ObjectPooling.instance.GetAkoyaPearlFromPool(); akoyaPearl.transform.position = gameObject.transform.position; }
                if (random > 90) { GameObject greenDiamond = ObjectPooling.instance.GetGreenDiamondfromPool(); greenDiamond.transform.position = gameObject.transform.position; }
            }
            else if (SelectChests.chest26Active == true)
            {
                if (random <= 6)
                {
                    GameObject purpleRupee = ObjectPooling.instance.GetPurpleRupeeFromPool(); purpleRupee.transform.position = gameObject.transform.position;
                    GameObject emerald = ObjectPooling.instance.GetEmeraldFromPool(); emerald.transform.position = gameObject.transform.position;
                    GameObject blackOpal = ObjectPooling.instance.GetBlackOpalFromPool(); blackOpal.transform.position = gameObject.transform.position;
                    GameObject painite = ObjectPooling.instance.GetPainiteFromPool(); painite.transform.position = gameObject.transform.position;
                    GameObject gemSilica = ObjectPooling.instance.GetGemSilicaFromPool(); gemSilica.transform.position = gameObject.transform.position;
                }
                if (random > 6)
                {
                    GameObject pinkPlort = ObjectPooling.instance.GetPinkPlortFromPool(); pinkPlort.transform.position = gameObject.transform.position;
                    GameObject goldenSeaPearl = ObjectPooling.instance.GetGoldenSeaPearlFromPool(); goldenSeaPearl.transform.position = gameObject.transform.position;
                    GameObject greenDiamond = ObjectPooling.instance.GetGreenDiamondfromPool(); greenDiamond.transform.position = gameObject.transform.position;
                }
                if (random > 60) { GameObject fireOpal = ObjectPooling.instance.GetFireOpalFromPool(); fireOpal.transform.position = gameObject.transform.position; }
                if (random > 90) { GameObject kyanite = ObjectPooling.instance.GetKyaniteFromPool(); kyanite.transform.position = gameObject.transform.position; }
            }
            else if (SelectChests.chest27Active == true)
            {
                if (random <= 6)
                {
                    GameObject emerald = ObjectPooling.instance.GetEmeraldFromPool(); emerald.transform.position = gameObject.transform.position;
                    GameObject painite = ObjectPooling.instance.GetPainiteFromPool(); painite.transform.position = gameObject.transform.position;
                    GameObject tanzanite = ObjectPooling.instance.GetTanzaniteFromPool(); tanzanite.transform.position = gameObject.transform.position;
                    GameObject gemSilica = ObjectPooling.instance.GetGemSilicaFromPool(); gemSilica.transform.position = gameObject.transform.position;
                    GameObject greenDiamond = ObjectPooling.instance.GetGreenDiamondfromPool(); greenDiamond.transform.position = gameObject.transform.position;
                }
                if (random > 6)
                {
                    GameObject goldenSeaPearl = ObjectPooling.instance.GetGoldenSeaPearlFromPool(); goldenSeaPearl.transform.position = gameObject.transform.position;
                    GameObject kyanite = ObjectPooling.instance.GetKyaniteFromPool(); kyanite.transform.position = gameObject.transform.position;
                    GameObject fireOpal = ObjectPooling.instance.GetFireOpalFromPool(); fireOpal.transform.position = gameObject.transform.position;
                }
                if (random > 60) { GameObject pinkPlort = ObjectPooling.instance.GetPinkPlortFromPool(); pinkPlort.transform.position = gameObject.transform.position; }
                if (random > 90) { GameObject blackOpal = ObjectPooling.instance.GetBlackOpalFromPool(); blackOpal.transform.position = gameObject.transform.position; }
            }


            else if (SelectChests.chest28Active == true)
            {
                if (random <= 6)
                {
                    GameObject emerald = ObjectPooling.instance.GetEmeraldFromPool(); emerald.transform.position = gameObject.transform.position;
                    GameObject painite = ObjectPooling.instance.GetPainiteFromPool(); painite.transform.position = gameObject.transform.position;
                    GameObject tanzanite = ObjectPooling.instance.GetTanzaniteFromPool(); tanzanite.transform.position = gameObject.transform.position;
                    GameObject gemSilica = ObjectPooling.instance.GetGemSilicaFromPool(); gemSilica.transform.position = gameObject.transform.position;
                    GameObject greenDiamond = ObjectPooling.instance.GetGreenDiamondfromPool(); greenDiamond.transform.position = gameObject.transform.position;
                }
                if (random > 6)
                {
                    GameObject goldenSeaPearl = ObjectPooling.instance.GetGoldenSeaPearlFromPool(); goldenSeaPearl.transform.position = gameObject.transform.position;
                    GameObject kyanite = ObjectPooling.instance.GetKyaniteFromPool(); kyanite.transform.position = gameObject.transform.position;
                    GameObject fireOpal = ObjectPooling.instance.GetFireOpalFromPool(); fireOpal.transform.position = gameObject.transform.position;
                }
                if (random > 60) { GameObject pinkPlort = ObjectPooling.instance.GetPinkPlortFromPool(); pinkPlort.transform.position = gameObject.transform.position; }
                if (random > 90) { GameObject blackOpal = ObjectPooling.instance.GetBlackOpalFromPool(); blackOpal.transform.position = gameObject.transform.position; }
            }

            else if (SelectChests.chest29Active == true)
            {
                if (random <= 6)
                {
                    GameObject astralium = ObjectPooling.instance.GetAstraliumFromPool(); astralium.transform.position = gameObject.transform.position;
                    GameObject painite = ObjectPooling.instance.GetPainiteFromPool(); painite.transform.position = gameObject.transform.position;
                    GameObject tanzanite = ObjectPooling.instance.GetTanzaniteFromPool(); tanzanite.transform.position = gameObject.transform.position;
                    GameObject gemSilica = ObjectPooling.instance.GetGemSilicaFromPool(); gemSilica.transform.position = gameObject.transform.position;
                    GameObject greenDiamond = ObjectPooling.instance.GetGreenDiamondfromPool(); greenDiamond.transform.position = gameObject.transform.position;
                }
                if (random > 6)
                {
                    GameObject goldenSeaPearl = ObjectPooling.instance.GetGoldenSeaPearlFromPool(); goldenSeaPearl.transform.position = gameObject.transform.position;
                    GameObject kyanite = ObjectPooling.instance.GetKyaniteFromPool(); kyanite.transform.position = gameObject.transform.position;
                    GameObject fireOpal = ObjectPooling.instance.GetFireOpalFromPool(); fireOpal.transform.position = gameObject.transform.position;
                }
                if (random > 60) { GameObject pinkPlort = ObjectPooling.instance.GetPinkPlortFromPool(); pinkPlort.transform.position = gameObject.transform.position; }
                if (random > 90) { GameObject blackOpal = ObjectPooling.instance.GetBlackOpalFromPool(); blackOpal.transform.position = gameObject.transform.position; }
            }

            else if (SelectChests.chest30Active == true)
            {
                if (random <= 6)
                {
                    GameObject astralium = ObjectPooling.instance.GetAstraliumFromPool(); astralium.transform.position = gameObject.transform.position;
                    GameObject slysiumPrism = ObjectPooling.instance.GetElysiumPrismFromPool(); slysiumPrism.transform.position = gameObject.transform.position;
                    GameObject painite = ObjectPooling.instance.GetPainiteFromPool(); painite.transform.position = gameObject.transform.position;
                    GameObject tanzanite = ObjectPooling.instance.GetTanzaniteFromPool(); tanzanite.transform.position = gameObject.transform.position;
                    GameObject gemSilica = ObjectPooling.instance.GetGemSilicaFromPool(); gemSilica.transform.position = gameObject.transform.position;
                }
                if (random > 6)
                {
                    GameObject goldenSeaPearl = ObjectPooling.instance.GetGoldenSeaPearlFromPool(); goldenSeaPearl.transform.position = gameObject.transform.position;
                    GameObject kyanite = ObjectPooling.instance.GetKyaniteFromPool(); kyanite.transform.position = gameObject.transform.position;
                    GameObject fireOpal = ObjectPooling.instance.GetFireOpalFromPool(); fireOpal.transform.position = gameObject.transform.position;
                }
                if (random > 60) { GameObject pinkPlort = ObjectPooling.instance.GetPinkPlortFromPool(); pinkPlort.transform.position = gameObject.transform.position; }
                if (random > 90) { GameObject blackOpal = ObjectPooling.instance.GetBlackOpalFromPool(); blackOpal.transform.position = gameObject.transform.position; }
            }

            else if (SelectChests.chest31Active == true)
            {
                if (random <= 6)
                {
                    GameObject aerthFireOpal = ObjectPooling.instance.GetAetherfireOpalFromPool(); aerthFireOpal.transform.position = gameObject.transform.position;
                    GameObject slysiumPrism = ObjectPooling.instance.GetElysiumPrismFromPool(); slysiumPrism.transform.position = gameObject.transform.position;
                    GameObject painite = ObjectPooling.instance.GetPainiteFromPool(); painite.transform.position = gameObject.transform.position;
                    GameObject tanzanite = ObjectPooling.instance.GetTanzaniteFromPool(); tanzanite.transform.position = gameObject.transform.position;
                    GameObject gemSilica = ObjectPooling.instance.GetGemSilicaFromPool(); gemSilica.transform.position = gameObject.transform.position;
                }
                if (random > 6)
                {
                    GameObject goldenSeaPearl = ObjectPooling.instance.GetGoldenSeaPearlFromPool(); goldenSeaPearl.transform.position = gameObject.transform.position;
                    GameObject kyanite = ObjectPooling.instance.GetKyaniteFromPool(); kyanite.transform.position = gameObject.transform.position;
                    GameObject fireOpal = ObjectPooling.instance.GetFireOpalFromPool(); fireOpal.transform.position = gameObject.transform.position;
                }
                if (random > 60) { GameObject astralium = ObjectPooling.instance.GetAstraliumFromPool(); astralium.transform.position = gameObject.transform.position; }
                if (random > 90) { GameObject blackOpal = ObjectPooling.instance.GetBlackOpalFromPool(); blackOpal.transform.position = gameObject.transform.position; }
            }

            else if (SelectChests.chest32Active == true)
            {
                if (random <= 6)
                {
                    GameObject aerthFireOpal = ObjectPooling.instance.GetAetherfireOpalFromPool(); aerthFireOpal.transform.position = gameObject.transform.position;
                    GameObject slysiumPrism = ObjectPooling.instance.GetElysiumPrismFromPool(); slysiumPrism.transform.position = gameObject.transform.position;
                    GameObject painite = ObjectPooling.instance.GetPainiteFromPool(); painite.transform.position = gameObject.transform.position;
                    GameObject tanzanite = ObjectPooling.instance.GetTanzaniteFromPool(); tanzanite.transform.position = gameObject.transform.position;
                    GameObject gemSilica = ObjectPooling.instance.GetGemSilicaFromPool(); gemSilica.transform.position = gameObject.transform.position;
                }
                if (random > 6)
                {
                    GameObject goldenSeaPearl = ObjectPooling.instance.GetGoldenSeaPearlFromPool(); goldenSeaPearl.transform.position = gameObject.transform.position;
                    GameObject kyanite = ObjectPooling.instance.GetKyaniteFromPool(); kyanite.transform.position = gameObject.transform.position;
                    GameObject fireOpal = ObjectPooling.instance.GetFireOpalFromPool(); fireOpal.transform.position = gameObject.transform.position;
                }
                if (random > 60) { GameObject astralium = ObjectPooling.instance.GetAstraliumFromPool(); astralium.transform.position = gameObject.transform.position; }
                if (random > 90) { GameObject blackOpal = ObjectPooling.instance.GetBlackOpalFromPool(); blackOpal.transform.position = gameObject.transform.position; }
            }
            else if (SelectChests.chest33Active == true)
            {
                if (random <= 6)
                {
                    GameObject aerthFireOpal = ObjectPooling.instance.GetAetherfireOpalFromPool(); aerthFireOpal.transform.position = gameObject.transform.position;
                    GameObject slysiumPrism = ObjectPooling.instance.GetElysiumPrismFromPool(); slysiumPrism.transform.position = gameObject.transform.position;
                    GameObject painite = ObjectPooling.instance.GetPainiteFromPool(); painite.transform.position = gameObject.transform.position;
                    GameObject tanzanite = ObjectPooling.instance.GetTanzaniteFromPool(); tanzanite.transform.position = gameObject.transform.position;
                    GameObject gemSilica = ObjectPooling.instance.GetGemSilicaFromPool(); gemSilica.transform.position = gameObject.transform.position;
                }
                if (random > 6)
                {
                    GameObject eldrichStarstone = ObjectPooling.instance.GetEldritchStarstoneFromPool(); eldrichStarstone.transform.position = gameObject.transform.position;
                    GameObject kyanite = ObjectPooling.instance.GetKyaniteFromPool(); kyanite.transform.position = gameObject.transform.position;
                    GameObject fireOpal = ObjectPooling.instance.GetFireOpalFromPool(); fireOpal.transform.position = gameObject.transform.position;
                }
                if (random > 60) { GameObject astralium = ObjectPooling.instance.GetAstraliumFromPool(); astralium.transform.position = gameObject.transform.position; }
                if (random > 90) { GameObject blackOpal = ObjectPooling.instance.GetBlackOpalFromPool(); blackOpal.transform.position = gameObject.transform.position; }
            }

            else if (SelectChests.chest34Active == true)
            {
                if (random <= 6)
                {
                    GameObject aerthFireOpal = ObjectPooling.instance.GetAetherfireOpalFromPool(); aerthFireOpal.transform.position = gameObject.transform.position;
                    GameObject slysiumPrism = ObjectPooling.instance.GetElysiumPrismFromPool(); slysiumPrism.transform.position = gameObject.transform.position;
                    GameObject painite = ObjectPooling.instance.GetPainiteFromPool(); painite.transform.position = gameObject.transform.position;
                    GameObject tanzanite = ObjectPooling.instance.GetTanzaniteFromPool(); tanzanite.transform.position = gameObject.transform.position;
                    GameObject chronolithShard = ObjectPooling.instance.GetChronolithShardFromPool(); chronolithShard.transform.position = gameObject.transform.position;
                }
                if (random > 6)
                {
                    GameObject eldrichStarstone = ObjectPooling.instance.GetEldritchStarstoneFromPool(); eldrichStarstone.transform.position = gameObject.transform.position;
                    GameObject kyanite = ObjectPooling.instance.GetKyaniteFromPool(); kyanite.transform.position = gameObject.transform.position;
                    GameObject fireOpal = ObjectPooling.instance.GetFireOpalFromPool(); fireOpal.transform.position = gameObject.transform.position;
                }
                if (random > 60) { GameObject astralium = ObjectPooling.instance.GetAstraliumFromPool(); astralium.transform.position = gameObject.transform.position; }
                if (random > 90) { GameObject blackOpal = ObjectPooling.instance.GetBlackOpalFromPool(); blackOpal.transform.position = gameObject.transform.position; }
            }

            else if (SelectChests.chest35Active == true)
            {
                if (random <= 6)
                {
                    GameObject aerthFireOpal = ObjectPooling.instance.GetAetherfireOpalFromPool(); aerthFireOpal.transform.position = gameObject.transform.position;
                    GameObject slysiumPrism = ObjectPooling.instance.GetElysiumPrismFromPool(); slysiumPrism.transform.position = gameObject.transform.position;
                    GameObject painite = ObjectPooling.instance.GetPainiteFromPool(); painite.transform.position = gameObject.transform.position;
                    GameObject tanzanite = ObjectPooling.instance.GetTanzaniteFromPool(); tanzanite.transform.position = gameObject.transform.position;
                    GameObject chronolithShard = ObjectPooling.instance.GetChronolithShardFromPool(); chronolithShard.transform.position = gameObject.transform.position;
                }
                if (random > 6)
                {
                    GameObject eldrichStarstone = ObjectPooling.instance.GetEldritchStarstoneFromPool(); eldrichStarstone.transform.position = gameObject.transform.position;
                    GameObject sideriumEssence = ObjectPooling.instance.GetSideriumEssenceFromPool(); sideriumEssence.transform.position = gameObject.transform.position;
                    GameObject fireOpal = ObjectPooling.instance.GetFireOpalFromPool(); fireOpal.transform.position = gameObject.transform.position;
                }
                if (random > 60) { GameObject astralium = ObjectPooling.instance.GetAstraliumFromPool(); astralium.transform.position = gameObject.transform.position; }
                if (random > 90) { GameObject blackOpal = ObjectPooling.instance.GetBlackOpalFromPool(); blackOpal.transform.position = gameObject.transform.position; }
            }

            else if (SelectChests.chest36Active == true)
            {
                if (random <= 6)
                {
                    GameObject aerthFireOpal = ObjectPooling.instance.GetAetherfireOpalFromPool(); aerthFireOpal.transform.position = gameObject.transform.position;
                    GameObject slysiumPrism = ObjectPooling.instance.GetElysiumPrismFromPool(); slysiumPrism.transform.position = gameObject.transform.position;
                    GameObject painite = ObjectPooling.instance.GetPainiteFromPool(); painite.transform.position = gameObject.transform.position;
                    GameObject tanzanite = ObjectPooling.instance.GetTanzaniteFromPool(); tanzanite.transform.position = gameObject.transform.position;
                    GameObject chronolithShard = ObjectPooling.instance.GetChronolithShardFromPool(); chronolithShard.transform.position = gameObject.transform.position;
                }
                if (random > 6)
                {
                    GameObject eldrichStarstone = ObjectPooling.instance.GetEldritchStarstoneFromPool(); eldrichStarstone.transform.position = gameObject.transform.position;
                    GameObject sideriumEssence = ObjectPooling.instance.GetSideriumEssenceFromPool(); sideriumEssence.transform.position = gameObject.transform.position;
                    GameObject quasarite = ObjectPooling.instance.GetQuasariteFromPool(); quasarite.transform.position = gameObject.transform.position;
                }
                if (random > 60) { GameObject astralium = ObjectPooling.instance.GetAstraliumFromPool(); astralium.transform.position = gameObject.transform.position; }
                if (random > 90) { GameObject blackOpal = ObjectPooling.instance.GetBlackOpalFromPool(); blackOpal.transform.position = gameObject.transform.position; }
            }

            else if (SelectChests.chest37Active == true)
            {
                if (random <= 6)
                {
                    GameObject aerthFireOpal = ObjectPooling.instance.GetAetherfireOpalFromPool(); aerthFireOpal.transform.position = gameObject.transform.position;
                    GameObject slysiumPrism = ObjectPooling.instance.GetElysiumPrismFromPool(); slysiumPrism.transform.position = gameObject.transform.position;
                    GameObject painite = ObjectPooling.instance.GetPainiteFromPool(); painite.transform.position = gameObject.transform.position;
                    GameObject tanzanite = ObjectPooling.instance.GetTanzaniteFromPool(); tanzanite.transform.position = gameObject.transform.position;
                    GameObject chronolithShard = ObjectPooling.instance.GetChronolithShardFromPool(); chronolithShard.transform.position = gameObject.transform.position;
                }
                if (random > 6)
                {
                    GameObject eldrichStarstone = ObjectPooling.instance.GetEldritchStarstoneFromPool(); eldrichStarstone.transform.position = gameObject.transform.position;
                    GameObject sideriumEssence = ObjectPooling.instance.GetSideriumEssenceFromPool(); sideriumEssence.transform.position = gameObject.transform.position;
                    GameObject quasarite = ObjectPooling.instance.GetQuasariteFromPool(); quasarite.transform.position = gameObject.transform.position;
                }
                if (random > 60) { GameObject astralium = ObjectPooling.instance.GetAstraliumFromPool(); astralium.transform.position = gameObject.transform.position; }
                if (random > 90) { GameObject radiantNovaStone = ObjectPooling.instance.GetRadiantNovaStoneFromPool(); radiantNovaStone.transform.position = gameObject.transform.position; }
            }

            else if (SelectChests.chest38Active == true)
            {
                if (random <= 6)
                {
                    GameObject aerthFireOpal = ObjectPooling.instance.GetAetherfireOpalFromPool(); aerthFireOpal.transform.position = gameObject.transform.position;
                    GameObject slysiumPrism = ObjectPooling.instance.GetElysiumPrismFromPool(); slysiumPrism.transform.position = gameObject.transform.position;
                    GameObject soluniumShaerd = ObjectPooling.instance.GetSoluniumShardFromPool(); soluniumShaerd.transform.position = gameObject.transform.position;
                    GameObject tanzanite = ObjectPooling.instance.GetTanzaniteFromPool(); tanzanite.transform.position = gameObject.transform.position;
                    GameObject chronolithShard = ObjectPooling.instance.GetChronolithShardFromPool(); chronolithShard.transform.position = gameObject.transform.position;
                }
                if (random > 6)
                {
                    GameObject eldrichStarstone = ObjectPooling.instance.GetEldritchStarstoneFromPool(); eldrichStarstone.transform.position = gameObject.transform.position;
                    GameObject sideriumEssence = ObjectPooling.instance.GetSideriumEssenceFromPool(); sideriumEssence.transform.position = gameObject.transform.position;
                    GameObject quasarite = ObjectPooling.instance.GetQuasariteFromPool(); quasarite.transform.position = gameObject.transform.position;
                }
                if (random > 60) { GameObject astralium = ObjectPooling.instance.GetAstraliumFromPool(); astralium.transform.position = gameObject.transform.position; }
                if (random > 90) { GameObject radiantNovaStone = ObjectPooling.instance.GetRadiantNovaStoneFromPool(); radiantNovaStone.transform.position = gameObject.transform.position; }
            }

            else if (SelectChests.chest39Active == true)
            {
                if (random <= 6)
                {
                    GameObject aerthFireOpal = ObjectPooling.instance.GetAetherfireOpalFromPool(); aerthFireOpal.transform.position = gameObject.transform.position;
                    GameObject slysiumPrism = ObjectPooling.instance.GetElysiumPrismFromPool(); slysiumPrism.transform.position = gameObject.transform.position;
                    GameObject soluniumShaerd = ObjectPooling.instance.GetSoluniumShardFromPool(); soluniumShaerd.transform.position = gameObject.transform.position;
                    GameObject tanzanite = ObjectPooling.instance.GetTanzaniteFromPool(); tanzanite.transform.position = gameObject.transform.position;
                    GameObject chronolithShard = ObjectPooling.instance.GetChronolithShardFromPool(); chronolithShard.transform.position = gameObject.transform.position;
                }
                if (random > 6)
                {
                    GameObject eldrichStarstone = ObjectPooling.instance.GetEldritchStarstoneFromPool(); eldrichStarstone.transform.position = gameObject.transform.position;
                    GameObject sideriumEssence = ObjectPooling.instance.GetSideriumEssenceFromPool(); sideriumEssence.transform.position = gameObject.transform.position;
                    GameObject quasarite = ObjectPooling.instance.GetQuasariteFromPool(); quasarite.transform.position = gameObject.transform.position;
                }
                if (random > 60) { GameObject astralium = ObjectPooling.instance.GetAstraliumFromPool(); astralium.transform.position = gameObject.transform.position; }
                if (random > 90) { GameObject radiantNovaStone = ObjectPooling.instance.GetRadiantNovaStoneFromPool(); radiantNovaStone.transform.position = gameObject.transform.position; }
            }

            else if (SelectChests.chest40Active == true)
            {
                if (random <= 6)
                {
                    GameObject aerthFireOpal = ObjectPooling.instance.GetAetherfireOpalFromPool(); aerthFireOpal.transform.position = gameObject.transform.position;
                    GameObject slysiumPrism = ObjectPooling.instance.GetElysiumPrismFromPool(); slysiumPrism.transform.position = gameObject.transform.position;
                    GameObject soluniumShaerd = ObjectPooling.instance.GetSoluniumShardFromPool(); soluniumShaerd.transform.position = gameObject.transform.position;
                    GameObject tanzanite = ObjectPooling.instance.GetTanzaniteFromPool(); tanzanite.transform.position = gameObject.transform.position;
                    GameObject chronolithShard = ObjectPooling.instance.GetChronolithShardFromPool(); chronolithShard.transform.position = gameObject.transform.position;
                }
                if (random > 6)
                {
                    GameObject eldrichStarstone = ObjectPooling.instance.GetEldritchStarstoneFromPool(); eldrichStarstone.transform.position = gameObject.transform.position;
                    GameObject sideriumEssence = ObjectPooling.instance.GetSideriumEssenceFromPool(); sideriumEssence.transform.position = gameObject.transform.position;
                    GameObject quasarite = ObjectPooling.instance.GetQuasariteFromPool(); quasarite.transform.position = gameObject.transform.position;
                }
                if (random > 60) { GameObject astralium = ObjectPooling.instance.GetAstraliumFromPool(); astralium.transform.position = gameObject.transform.position; }
                if (random > 90) { GameObject radiantNovaStone = ObjectPooling.instance.GetRadiantNovaStoneFromPool(); radiantNovaStone.transform.position = gameObject.transform.position; }
            }
        }

        ObjectPooling.instance.ReturnMiniChestFromPool(gameObject);
    }
}
