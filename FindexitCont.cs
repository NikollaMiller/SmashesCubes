using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FindexitCont : MonoBehaviour
{
    private void Start()
    {
        if (Input.deviceOrientation == DeviceOrientation.Portrait)
        {
            Screen.orientation = ScreenOrientation.Landscape;
        }
    }
}
