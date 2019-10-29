using UnityEngine;

public class GameArtData : ScriptableObject
{
    //GameArtData is the child of the parent code, ScriptableObject, and the child of GameArtData is PlayerData
    public Sprite sprite;
    public Color color = Color.yellow;
    public GameObject prefab;
    public bool collected;
}
