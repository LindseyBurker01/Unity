using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[CreateAssetMenu]
public class Playerdata : GameArtData
{
    //Plaerdata is getting information from GameArtData
    public FloatData health;
    public UnityEvent onRunEvent;
    
    //List makes it so you can have multiple weapons
    public List<WeaponData> weapons;
    public ClothesData shirt;
    public ClothesData pants;
    public UnityEvent Run;

    public void InstancePlayer()
    {
        var newPlayer = Instantiate(prefab);
        var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
        newSprite.sprite = sprite;
        newSprite.color = color;
    }
}
