using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class PlayerLevel : MonoBehaviour,IDataPersistence
{
    public static float experienceNeeded;
    public static float experienceGained;
    public static int playerLevel;
    public static float xpChestDrop;
    public static int skillPoints;

    public GameObject skillPointAnim;

    public Slider LevelSlider;

    public TextMeshProUGUI PlayerLevelText;
    public TextMeshProUGUI xpNeededtext;

    public TextMeshProUGUI skillPointsText;
    public TextMeshProUGUI youHaveSkillPointText, nextSkillPoints;

    public AudioManager audioManager;

    public void Start()
    {
        if (SaveAndLoad.firstClick != 1)
        {
            skillPoints = 0;
            playerLevel = 0;
            PlayerLevelText.text = Localization.level + playerLevel;
            experienceGained = 0;
            LevelSlider.value = 0;
            experienceNeeded = 250;
            LevelSlider.maxValue = experienceNeeded;
            skillPointsText.text = "0";
            youHaveSkillPointText.text = "" + skillPoints;
            xpNeededtext.text = TotalGoldAmount.FormatCoins(experienceGained) + "/" + TotalGoldAmount.FormatCoins(experienceNeeded);
        }

        Invoke("wait", 0.4f);
    }

    public void wait()
    {
        string path = Application.persistentDataPath + "/player.savePlayerLevel";

        if (File.Exists(path))
        {
            if (SaveAndLoad.onlyLoadNewSave == false)
            {
                GameData data = SaveSystem.LoadPlayerLevel();
                skillPoints = data.skillPoints;
                playerLevel = data.playerLevel;
                experienceNeeded = data.experienceNeeded;
                experienceGained = data.experienceGained;
            }
            else { }
        }
        else
        {
            //Do nothing
        }

        PlayerLevelText.text = Localization.level + playerLevel;
        LevelSlider.maxValue = experienceNeeded;
        LevelSlider.value = experienceGained;
        LevelSlider.minValue = 0;
    }

    #region SaveAndLoadJSON
    public void LoadData(GameDataJSON data)
    {
        skillPoints = data.skillPoints;
        playerLevel = data.playerLevel;
        experienceNeeded = data.experienceNeeded;
        experienceGained = data.experienceGained;
    }

    public void SaveData(ref GameDataJSON data)
    {
        data.skillPoints = skillPoints;
        data.playerLevel = playerLevel;
        data.experienceNeeded = experienceNeeded;
        data.experienceGained = experienceGained;
    }
    #endregion

    public void Update()
    {
        LevelSlider.value = experienceGained;
        skillPointsText.text = skillPoints.ToString();
        youHaveSkillPointText.text = skillPoints + "";
        xpNeededtext.text = TotalGoldAmount.FormatCoins(experienceGained) + "/" + TotalGoldAmount.FormatCoins(experienceNeeded) + Localization.xpNoPercent;

        if (LevelSlider.value >= experienceNeeded)
        {
            LevelSlider.value = 0;
            experienceNeeded *= 1.32f;
            LevelSlider.maxValue = experienceNeeded;
            experienceGained = 0;

            if (playerLevel < 6) 
            {
                skillPointAnim.SetActive(true);
                skillPoints += 1; skillPointAnim.GetComponent<Animation>().Play();
                skillPointAnim.GetComponent<TextMeshProUGUI>().text = "+1";
                Stats.totalSkillPoints += 1;
                StartCoroutine(wait2());
            }
            else
            {
                skillPointAnim.SetActive(true);
                skillPoints += ((playerLevel / 5) + 1);
                skillPoints += 1; skillPointAnim.GetComponent<Animation>().Play();
                skillPointAnim.GetComponent<TextMeshProUGUI>().text = "+" + ((playerLevel / 5) + 1);
                Stats.totalSkillPoints += ((playerLevel / 5) + 1);

                StartCoroutine(wait2());
            }

            playerLevel += 1;
            if (AudioManager.audioMuted == 1) { audioManager.Play("PlayerLevelUp"); }

            nextSkillPoints.text = Localization.nextLevelHover +"<color=green>+" + ((PlayerLevel.playerLevel / 5) + 1) + "<color=white>" + Localization.skillPointsHover;

            PlayerLevelText.text = Localization.level + playerLevel;

        }
    }

    IEnumerator wait2()
    {
        yield return new WaitForSeconds(0.7f);
        skillPointAnim.SetActive(false);
    }

    public void ResetPlayerLevel()
    {
        
        playerLevel = 0;
        PlayerLevelText.text = Localization.level + playerLevel;
        experienceGained = 0;
        LevelSlider.value = 0;
        experienceNeeded = 250;
        LevelSlider.maxValue = experienceNeeded;
        skillPointsText.text = "0";
        youHaveSkillPointText.text = "" + skillPoints;
        xpNeededtext.text = TotalGoldAmount.FormatCoins(experienceGained) + "/" + TotalGoldAmount.FormatCoins(experienceNeeded);
    }

    /*
    public void SavePlayerLevel()
    {
        SaveSystem.SavePlayerLevel(this);
    }*/

}
