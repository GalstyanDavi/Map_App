﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeScene : MonoBehaviour
{
    public void scene(string name)
    {
        Application.LoadLevel(name);
    }
}