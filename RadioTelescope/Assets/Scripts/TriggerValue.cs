﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Prefabs.CameraRig.UnityXRCameraRig.Input;

public class TriggerValue : MonoBehaviour
{
    public UnityAxis1DAction rightTrigger;
    public GameObject rightLine;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(rightTrigger.Value);
        if (rightTrigger.Value > 0.2f)
        {
            rightLine.SetActive(true);
        }
        else
        {
            rightLine.SetActive(false);
        }
    }

    private void OnEnable()
    {
        //Debug.Log(rightTrigger.Value);
        if (rightTrigger.Value > 0.2f)
        {
            rightLine.SetActive(true);
        }
        else
        {
            rightLine.SetActive(false);
        }
    }

    private void Update()
    {
        //Debug.Log(rightTrigger.Value);
        if (rightTrigger.Value > 0.2f)
        {
            rightLine.SetActive(true);
        }
        else
        {
            rightLine.SetActive(false);
        }
    }
}
