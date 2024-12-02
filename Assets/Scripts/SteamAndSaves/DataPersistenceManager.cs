using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;
using System;

public class DataPersistenceManager : MonoBehaviour
{
    [Header("File Storage Config")]
    [SerializeField] private string fileName;

    private GameDataJSON gameDataJSON;
    private List<IDataPersistence> dataPersistenceObjects;

    private FileDataHandler dataHandler;
    public static DataPersistenceManager instance { get; private set; }

    public static int saveIncrement;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Found more than one Data Persistance Manager in the scene");
        }
        instance = this;
    }

    private void Start()
    {
        this.dataHandler = new FileDataHandler(Application.persistentDataPath, fileName);
        this.dataPersistenceObjects = FindAllDataPersistenceObjects();
        LoadGame();

        InvokeRepeating("SaveGame", 2f, 5f);
    }

    public void NewGame()
    {
        this.gameDataJSON = new GameDataJSON();
    }

    public GameObject testingObject;

    public void LoadGame()
    {
        this.gameDataJSON = dataHandler.Load("", true);//(NEW) string

        if (this.gameDataJSON == null)
        {
            Debug.Log("No data was found. Initialzing data to defaults");
            //testingObject.SetActive(true);
            NewGame();
        }

        foreach(IDataPersistence dataPersistanceObj in dataPersistenceObjects)
        {
            //Debug.Log("FoundSave");
            dataPersistanceObj.LoadData(gameDataJSON);
        }

        //Debug.Log("Loaded all variables");
    }

    public void SaveGame()
    {
        if (SkillTree.isPrestiged == false)
        {
            PlayerPrefs.SetString("OfflineProgress", DateTime.Now.ToString());
            saveIncrement += 1;
            if (clickSave == true) { clickSave = false; saveIncrement = 1; }

            foreach (IDataPersistence dataPErsistenceObj in dataPersistenceObjects)
            {
                dataPErsistenceObj.SaveData(ref gameDataJSON);
            }

            //Debug.Log("Saved all vaiables");
            dataHandler.Save(gameDataJSON, "");

            SaveAndLoad.onlyLoadNewSave = true;
        }
    }

    private void OnApplicationQuit()
    {
        //SaveGame();
    }

    private List<IDataPersistence> FindAllDataPersistenceObjects()
    {
        IEnumerable<IDataPersistence> dataPersistenceObjects = FindObjectsOfType<MonoBehaviour>().OfType<IDataPersistence>();

        return new List<IDataPersistence>(dataPersistenceObjects);
    }

    public bool clickSave;
    public void SaveTheGameData()
    {
        clickSave = true;
        SaveGame();
    }
}

