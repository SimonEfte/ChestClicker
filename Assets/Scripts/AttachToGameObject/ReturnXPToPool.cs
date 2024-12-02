using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnXPToPool : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

        //Xp
        if (collision.gameObject.tag == "XPBar")
        {
            ObjectPooling.instance.ReturnXPFromPool(gameObject);
        }
    }
}
