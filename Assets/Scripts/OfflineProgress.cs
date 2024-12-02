using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class OfflineProgress : MonoBehaviour
{
    public TextMeshProUGUI offlineGainsText, timePassedText;
    public GameObject offlineBar;
    public double goldAmount, chestAmount, XPAmount;

    void Start()
    {
        UIelementsClick.hideCursors = true;
        StartCoroutine(SetOfflineEarnings());
    }

    IEnumerator SetOfflineEarnings()
    {
        yield return new WaitForSeconds(0.85f);

        if (PlayerPrefs.HasKey("OfflineProgress"))
        {
            UIelementsClick.hideCursors = true;
            offlineBar.SetActive(true);
            DateTime lastLogIn = DateTime.Parse(PlayerPrefs.GetString("OfflineProgress"));
            TimeSpan timeSpan = DateTime.Now - lastLogIn;

            if(Localization.EnglishLanguageChosen == 1)
            {
                timePassedText.text = String.Format("{0} Days {1} Hours {2} Minutes {3} Seconds", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
            }
            if (Localization.RussianLanguageChosen == 1)
            {
                timePassedText.text = String.Format("{0} Дней {1} Часа {2} Минуты {3} Секунды", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
            }
            if (Localization.JapaneseLanguageChosen == 1)
            {
                timePassedText.text = String.Format("{0} 日 {1} 時間 {2} 分 {3} 秒", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
            }
            if (Localization.ChineseLanguageChosen == 1)
            {
                timePassedText.text = String.Format("{0} 天 {1} 小时 {2} 分钟 {3} 秒", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
            }
            if (Localization.KoreanLanguageChosen == 1)
            {
                timePassedText.text = String.Format("{0} 일 {1} 시간 {2} 분 {3} 초", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
            }

            chestAmount = (((int)timeSpan.TotalSeconds) / ((SelectChests.ChestHealth / ClickPower.totalPassiveDamage) + 0.4f)) / 13;

            if(chestAmount < 1)
            {
                chestAmount = 0;
                goldAmount = 0;
                XPAmount = 0;
            }
            else
            {
                goldAmount = chestAmount * (SelectChests.averageChestGoldSpawn * ( 1 + SkillTree.skillTreeGold + RareTreasures.runeGold + RareTreasures.cookieGold + RareTreasures.backPackGold + UseConsumable.scrollGoldBuff + UseConsumable.relicPermaGoldBuff));

                //Debug.Log(goldAmount);

                XPAmount = chestAmount * PlayerLevel.xpChestDrop;
            }

            if(PlaceMobileButtons.isMobile == true)
            {
                offlineGainsText.fontSize = 35;
            }

            if (Localization.EnglishLanguageChosen == 1)
            {
                offlineGainsText.text = "You opened <color=green>" + chestAmount.ToString("F0") + "<color=white> chests, which gives you a total of <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(goldAmount) + " gold<color=white> and <color=orange>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(XPAmount) + "XP<color=white>";
            }
            if (Localization.RussianLanguageChosen == 1)
            {
                offlineGainsText.text = "Вы открыли <color=green>" + chestAmount.ToString("F0") + "<color=white> сундуков, которые принесли вам всего <color=yellow>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(goldAmount) + " золота <color=white> и <color=orange>" + TotalGoldAmount.FormatCoinsDoubleOneLetter(XPAmount) + "XP<color=white>";
            }
            if (Localization.JapaneseLanguageChosen == 1)
            {
                offlineGainsText.text = "あなたはあなたに" + TotalGoldAmount.FormatCoinsDoubleOneLetter(goldAmount) + "ゴールドと" + TotalGoldAmount.FormatCoinsDoubleOneLetter(XPAmount)  + "XPの合計を与えた" + chestAmount.ToString("F0") + "チェストを開きました";
            }
            if (Localization.ChineseLanguageChosen == 1)
            {
                offlineGainsText.text = "您打开了 " + chestAmount.ToString("F0") + " 个宝箱，总共获得 " + TotalGoldAmount.FormatCoinsDoubleOneLetter(goldAmount) + " 金币和 " + TotalGoldAmount.FormatCoinsDoubleOneLetter(XPAmount) + " 经验值";
            }
            if (Localization.KoreanLanguageChosen == 1)
            {
                offlineGainsText.text = "" + chestAmount.ToString("F0") + "개의 상자를 오픈하셨고 이로부터 총 " + TotalGoldAmount.FormatCoinsDoubleOneLetter(goldAmount) + " 골드와" + TotalGoldAmount.FormatCoinsDoubleOneLetter(XPAmount) + "XP를 얻었습니다";
            }

            if (PlaceMobileButtons.isFoldPhone == true)
            {
                offlineGainsText.fontSize = 31.5f;
            }

            //coinsAmountText.text = "+" + FormatCoins(coinsAmount);

            //Debug.Log(chestAmount);

            //This is how much coins was gain in coin flipper
            //GlobalCoins.CoinCount += ((int)timeSpan.TotalMinutes * (MainButtonClick.coinsPerClick * GlobalCoinMaker.coinsPerFlipUpgrades));

        }
        else
        {
            offlineBar.SetActive(false);
        }

        //Debug.Log((float)XPAmount);
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetString("OfflineProgress", DateTime.Now.ToString());
    }

    public void ClickOkOnOfflineBar()
    {
        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("UIClick3"); }
        Stats.chestOpened += Mathf.RoundToInt((float)chestAmount); 
        UpdateGame.totalGoldHigher += goldAmount;

        StartCoroutine(SetXP());

        offlineBar.SetActive(false);
        UIelementsClick.hideCursors = false;
    }

    IEnumerator SetXP()
    {
        yield return new WaitForSeconds(0.1f);

        float nextLevelAmount = PlayerLevel.experienceNeeded - PlayerLevel.experienceGained;

        while ((float)XPAmount > nextLevelAmount)
        {
            //Debug.Log((float)XPAmount);
            //Debug.Log(nextLevelAmount);
            PlayerLevel.experienceGained += nextLevelAmount;
            XPAmount -= nextLevelAmount;
            yield return new WaitForSeconds(0.2f);
            nextLevelAmount = PlayerLevel.experienceNeeded - PlayerLevel.experienceGained;
        }

        PlayerLevel.experienceGained += (float)XPAmount;
    }

}
