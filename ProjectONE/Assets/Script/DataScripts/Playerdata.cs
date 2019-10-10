using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Playerdata : GameArtData
{
    //Plaerdata is getting information from GameArtData
    public FloatData health;
    //List makes it so you can have multiple weapons
    public List<WeaponData> weapons;
    public ClothesData shirt;
    public ClothesData pants;

    public void InstancePlayer()
    {
        var newPlayer = Instantiate(prefab);
        var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
        newSprite.sprite = sprite;
        newSprite.color = color;
    }
}
