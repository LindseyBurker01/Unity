using UnityEngine;

[CreateAssetMenu]
public class Playerdata : GameArtData
{
    public WeaponData weapon;
    //So this is configuring characters, and all characters need a sprite, color, and gameobject

    public void InstancePlayer()
    {
        var newPlayer = Instantiate(prefab);
        var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
        newSprite.sprite = sprite;
        newSprite.color = color;
    }
}
