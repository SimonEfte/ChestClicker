using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Screenshots : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            //ScreenCapture.CaptureScreenshot("screenshot-" + DateTime.Now.ToString("yyyy-mm-dd-hh-sss") + ".png", 1);
        }
    }
}
