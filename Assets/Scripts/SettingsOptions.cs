using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SettingsOptions : MonoBehaviour
{
    // Reference to the Dropdown component
    public TMP_Dropdown resolutionDropdown;

    // List of available resolutions
    private List<Resolution> resolutions = new List<Resolution>();

    public int saveHeight, saveWidth;
    public int saveFullsScreen;
    public bool fuckOff;
    public GameObject coolStuffButton;

    private void Awake()
    {
        fuckOff = true;
        if (!PlayerPrefs.HasKey("MiniChest"))
        {
            miniChestSound = 0; miniChestSoundOn.SetActive(false); miniChestSoundOff.SetActive(true);
        }
        else
        {
            miniChestSound = PlayerPrefs.GetInt("MiniChest");
            if(miniChestSound == 0)
            {
                miniChestSoundOn.SetActive(false); miniChestSoundOff.SetActive(true);
            }
            if (miniChestSound == 1)
            {
                miniChestSoundOn.SetActive(true); miniChestSoundOff.SetActive(false);
            }
        }

        if (!PlayerPrefs.HasKey("saveIndex")) { resolutionIndexSave = 2; }
        else
        {
            resolutionIndexSave = PlayerPrefs.GetInt("saveIndex");
        }

        if(PlaceMobileButtons.isMobile == true)
        {
            Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
        }
        else
        {
            if (!PlayerPrefs.HasKey("ScreenWidth"))
            {
                Screen.fullScreenMode = FullScreenMode.Windowed;
                Screen.SetResolution(1280, 720, FullScreenMode.Windowed);
            }
            else
            {
                saveFullsScreen = PlayerPrefs.GetInt("SaveFullScreen");
                saveWidth = PlayerPrefs.GetInt("ScreenWidth");
                saveHeight = PlayerPrefs.GetInt("ScreenHeight");

                if (saveFullsScreen == 1)
                {
                    Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
                }
                else
                {
                    Screen.fullScreenMode = FullScreenMode.Windowed;
                }

                Screen.SetResolution(saveWidth, saveHeight, Screen.fullScreenMode);

            }
        }

        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.2f);
        fuckOff = false;
    }

    private void Start()
    {
        // Define a list of supported resolutions
        resolutions = new List<Resolution>
        {
            new Resolution { width = 800, height = 600 },
            new Resolution { width = 1024, height = 768 },
            new Resolution { width = 1280, height = 720 },
            new Resolution { width = 1280, height = 800 },
            new Resolution { width = 1280, height = 1024 },
            new Resolution { width = 1366, height = 768 },
            new Resolution { width = 1600, height = 900 },
            new Resolution { width = 1920, height = 1080 },
            new Resolution { width = 1920, height = 1200 },
            new Resolution { width = 2560, height = 1440 },
            new Resolution { width = 2560, height = 1600 },
            new Resolution { width = 2560, height = 1080 },
            new Resolution { width = 3440, height = 1440 },
            new Resolution { width = 3840, height = 1440 },
            new Resolution { width = 3840, height = 2160 },
            new Resolution { width = 3840, height = 2400 }
            // Add any other resolutions you want to support here
        };

        // Add the supported resolutions to the dropdown
        resolutionDropdown.ClearOptions();
        List<string> options = new List<string>();
        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Count; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);
            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();

        resolutionDropdown.value = resolutionIndexSave;

    }

    public int resolutionIndexSave;
    

    public void SetResolution(int resolutionIndex)
    {
        if(fuckOff == false)
        {
            Resolution resolution = resolutions[resolutionIndex];
            Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);

            saveWidth = resolution.width;
            saveHeight = resolution.height;

            PlayerPrefs.SetInt("ScreenWidth", saveWidth);
            PlayerPrefs.SetInt("ScreenHeight", saveHeight);

            resolutionIndexSave = resolutionIndex;
            PlayerPrefs.SetInt("saveIndex", resolutionIndexSave);
        }
    }


    //FullScreen/Windowed
    public void SetFullSCreen()
    {
        Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;

        saveFullsScreen = 1;
        PlayerPrefs.SetInt("SaveFullScreen", saveFullsScreen);
    }

    public void SetWindowed()
    {
        Screen.fullScreenMode = FullScreenMode.Windowed;

        saveFullsScreen = 0;
        PlayerPrefs.SetInt("SaveFullScreen", saveFullsScreen);
    }

    public static int miniChestSound;
    public GameObject miniChestSoundOn, miniChestSoundOff;

    public void MiniChestSoundOn()
    {
        miniChestSound = 1;
        miniChestSoundOn.SetActive(true); miniChestSoundOff.SetActive(false);
        PlayerPrefs.SetInt("MiniChest", miniChestSound);
    }
    public void MiniChestSoundoff()
    {
        miniChestSound = 0;
        miniChestSoundOn.SetActive(false); miniChestSoundOff.SetActive(true);
        PlayerPrefs.SetInt("MiniChest", miniChestSound);
    }


    public void DiscordLick()
    {
        Application.OpenURL("https://discord.gg/eVBcVJJuBz");
    }

    public void SteamLink()
    {
        Application.OpenURL("https://store.steampowered.com/curator/43674917");
    }

    public void twitterLick()
    {
        Application.OpenURL("https://twitter.com/Sniceman");
    }

    public void GooglePlayLink()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.eagleeyegames.treasurechestclickeridle");
    }

}
