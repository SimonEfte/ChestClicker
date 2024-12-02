using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setTextBack : MonoBehaviour
{
    public bool setTexTBack;

    public void OnEnable()
    {
        setTexTBack = false;
        gameObject.GetComponent<Animation>().Play("miniChestTextAnim");

        Invoke("SetTextBack", 1.317f);
    }

    public void SetTextBack()
    {
        ObjectPooling.instance.ReturnMiniChestTextFromPool(gameObject);
    }

    void Update()
    {
        if(SkillTree.pressedPrestige == true)
        {
            setTexTBack = true;
            if(setTexTBack == true)
            {
                ObjectPooling.instance.ReturnMiniChestTextFromPool(gameObject);
                setTexTBack = false;
            }
        }
    }
}
