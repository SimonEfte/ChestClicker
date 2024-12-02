using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveSystem 
{
    #region saveGold
    public static void SaveGold(TotalGoldAmount gold)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.saveGold";
        FileStream stream = new FileStream(path, FileMode.Create);

        GameData data = new GameData(gold);
        
        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static GameData loadGold()
    {
        string path = Application.persistentDataPath + "/player.saveGold";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameData data = formatter.Deserialize(stream) as GameData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }

    #endregion

    #region saveChests
    public static void SaveUnlockedChests(UnlockChests chests)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.saveChests";
        FileStream stream = new FileStream(path, FileMode.Create);

        GameData data = new GameData(chests);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static GameData LoadChests()
    {
        string path = Application.persistentDataPath + "/player.saveChests";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameData data = formatter.Deserialize(stream) as GameData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }

    #endregion

    #region saveFirstClick
    public static void SaveFirstPlayed(SaveAndLoad firstTimePlayedClick)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.saveFirstPlayed";
        FileStream stream = new FileStream(path, FileMode.Create);

        GameData data = new GameData(firstTimePlayedClick);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static GameData LoadFirstPlayed()
    {
        string path = Application.persistentDataPath + "/player.saveFirstPlayed";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameData data = formatter.Deserialize(stream) as GameData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }

    #endregion

    #region gemsCount
    public static void SaveGemsCount(RareDropsCollected gems)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.saveGemsCount";
        FileStream stream = new FileStream(path, FileMode.Create);

        GameData data = new GameData(gems);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static GameData LoadGemsCount()
    {
        string path = Application.persistentDataPath + "/player.saveGemsCount";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameData data = formatter.Deserialize(stream) as GameData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
    #endregion

    #region clickPower
    public static void SaveClickPower(ClickPower clickPower)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.saveClickPower";
        FileStream stream = new FileStream(path, FileMode.Create);

        GameData data = new GameData(clickPower);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static GameData LoadClickPower()
    {
        string path = Application.persistentDataPath + "/player.saveClickPower";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameData data = formatter.Deserialize(stream) as GameData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
    #endregion

    #region autoDamage
    public static void SaveAutoDamage(HealthBar auto)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.saveAutoDamage";
        FileStream stream = new FileStream(path, FileMode.Create);

        GameData data = new GameData(auto);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static GameData LoadAutoDamage()
    {
        string path = Application.persistentDataPath + "/player.saveAutoDamage";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameData data = formatter.Deserialize(stream) as GameData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
    #endregion

    #region specialUpgradesConsumable
    public static void SaveConsumables(UseConsumable consumable)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.saveConsumables";
        FileStream stream = new FileStream(path, FileMode.Create);

        GameData data = new GameData(consumable);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static GameData LoadConsumables()
    {
        string path = Application.persistentDataPath + "/player.saveConsumables";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameData data = formatter.Deserialize(stream) as GameData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
    #endregion

    #region specialUpgrades
    public static void SaveSpecialUpgrade(SpecialUpgradesButtons specialUpgrades)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.saveSpecialUpgrades";
        FileStream stream = new FileStream(path, FileMode.Create);

        GameData data = new GameData(specialUpgrades);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static GameData LoadSpecialUpgrades()
    {
        string path = Application.persistentDataPath + "/player.saveSpecialUpgrades";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameData data = formatter.Deserialize(stream) as GameData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
    #endregion

    #region playerLevel
    public static void SavePlayerLevel(PlayerLevel level)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.savePlayerLevel";
        FileStream stream = new FileStream(path, FileMode.Create);

        GameData data = new GameData(level);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static GameData LoadPlayerLevel()
    {
        string path = Application.persistentDataPath + "/player.savePlayerLevel";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameData data = formatter.Deserialize(stream) as GameData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
    #endregion

    #region treasure drop chance
    public static void SaveTreasureDropChance(SpawnRewards treasure)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.saveTreasureChance";
        FileStream stream = new FileStream(path, FileMode.Create);

        GameData data = new GameData(treasure);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static GameData LoadTreasureDropChance()
    {
        string path = Application.persistentDataPath + "/player.saveTreasureChance";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameData data = formatter.Deserialize(stream) as GameData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
    #endregion

    #region rare treasures
    public static void SaveRareTreasures(RareTreasures rareTreasure)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.saveRareTreasures";
        FileStream stream = new FileStream(path, FileMode.Create);

        GameData data = new GameData(rareTreasure);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static GameData LoadRareTreasures()
    {
        string path = Application.persistentDataPath + "/player.saveRareTreasures";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameData data = formatter.Deserialize(stream) as GameData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
    #endregion

    #region stats
    public static void SaveStats(Stats stats)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.saveStats";
        FileStream stream = new FileStream(path, FileMode.Create);

        GameData data = new GameData(stats);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static GameData LoadStats()
    {
        string path = Application.persistentDataPath + "/player.saveStats";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameData data = formatter.Deserialize(stream) as GameData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
    #endregion

    #region skillTree
    public static void SaveSkillTree(SkillTree skills)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.saveSkillTree";
        FileStream stream = new FileStream(path, FileMode.Create);

        GameData data = new GameData(skills);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static GameData LoadSkillTree()
    {
        string path = Application.persistentDataPath + "/player.saveSkillTree";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameData data = formatter.Deserialize(stream) as GameData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
    #endregion

    #region ach
    public static void SaveACH(Achievements ACH)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.saveACH";
        FileStream stream = new FileStream(path, FileMode.Create);

        GameData data = new GameData(ACH);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static GameData LoadACH()
    {
        string path = Application.persistentDataPath + "/player.saveACH";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameData data = formatter.Deserialize(stream) as GameData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
    #endregion

  

}
