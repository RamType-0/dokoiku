﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitScreenSize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(432, 618, false, 60);
    }
}
