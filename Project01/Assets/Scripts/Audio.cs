using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(AudioSource))]
public class Audio : MonoBehaviour
{
    public AudioSource audio;
    void Start()
    {
        audio.Stop();
    }
    
}
