﻿using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameArtCollection : ScriptableObject
{
    public List<GameArtData> collectionList;

    public void AddData(GameArtData obj)
    {
        if (!collectionList.Contains(obj))
        {
            collectionList.Add(obj);
        }
        //foreach (var gameArt in collectionList)
        //{
          //  Debug.Log(gameArt);
        //}
    }

    public void RemoveLastItem()
    {
        if (collectionList.Count > 0)
        {
            collectionList.RemoveAt(collectionList.Count - 1);
        }
    }
}
