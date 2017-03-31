﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mudtrap : MonoBehaviour
{
    [SerializeField] private float slowFactor;

    //When a pirate enters the trigger
    private void OnTriggerEnter(Collider coll)
    {
        coll.GetComponent<CaptainPirate>().Speed *= slowFactor;
    }

    //When a pirate leaves the trigger
    private void OnTriggerExit(Collider coll)
    {
        coll.GetComponent<CaptainPirate>().Speed /= slowFactor;
    }
}