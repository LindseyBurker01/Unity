using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWeapon : MonoBehaviour
{
    public GameObject prefab;
    public ApplyForce ammo;
    
    public void Fire() 
    {
        Instantiate(ammo, transform.position, Quaternion.identity); 
    } 
}
