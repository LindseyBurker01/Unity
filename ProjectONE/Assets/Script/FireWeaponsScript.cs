﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWeaponsScript : MonoBehaviour
{
    public ApplyForce ammo;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(ammo, transform.position, Quaternion.identity);
        }
    }
}
