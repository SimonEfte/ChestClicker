using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReturnTextToPool : MonoBehaviour
{

    public void Update()
    {
      if(SelectChests.returnText == true)
        {
            ObjectPooling.instance.ReturnTextFromPool(gameObject);
        }

    }


}
