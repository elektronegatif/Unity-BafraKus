﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager17 : MonoBehaviour
{
    public Toggle toggle;
    public bool control;
    private void Start()
    {
        bool IsOn = false;
        control = false;
        if (PlayerPrefs.GetInt("IsOn17") == 1)
        {
            IsOn = true;
        }
        else
        {
            IsOn = false;
        }
        toggle.isOn = IsOn;
    }
    private void Update()
    {
        if (control == true)
        {
            kaydet();
        }
    }
    public void kaydet()
    {

        control = true;
        if (toggle.isOn)
        {
            PlayerPrefs.SetInt("IsOn17", 1);
        }
        else
        {
            PlayerPrefs.SetInt("IsOn17", 0);
        }
    }

}
