using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDataPersistence 
{
    void LoadData(GameDataJSON data);
    void SaveData(ref GameDataJSON data);
   
}
