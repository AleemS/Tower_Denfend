﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {

    public Transform TilePreFab;
    public Vector2 mapSize;


    [Range(0, 1)]
    public float outlinePercent;

    public void GenerateMap()
    {
        for(int x = 0; x < mapSize.x; x++)
        {
            for (int y = 0; y < mapSize.y; y++)
            {
                Vector3 tilePosition = new Vector3(-mapSize.x / 2 + 0.5f + x, 0, -mapSize.y + 0.5f + y);
                Transform newTile = Instantiate(TilePreFab, tilePosition, Quaternion.Euler(Vector3.right*90f)) as Transform;
                newTile.localScale = Vector3.one * ( 1-outlinePercent);
            }
        }

    }

	// Use this for initialization
	void Start () {
        GenerateMap();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}