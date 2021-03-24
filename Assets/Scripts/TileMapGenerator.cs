using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMapGenerator : MonoBehaviour {

    public GameObject TilePrefab;

    [SerializeField] int mapwidth = 5;
    [SerializeField] int mapheight = 8;

    [SerializeField] float TileOffset = 1.05f; 
	// Use this for initialization
	void Start () {
        CreateQuadTileMap();
		
	}

    // Update is called once per frame
    void CreateQuadTileMap() {
        for (int x = 0; x <= mapwidth; x++)
        {
            for( int z = 0; z <= mapheight; z++ )
            { GameObject TempGO = Instantiate(TilePrefab);
                TempGO.transform.position = new Vector3(x * TileOffset, 0, z * TileOffset);

                SetTileInfo(TempGO, x, z);
            }
        }
		
	}

    void SetTileInfo(GameObject GO, int x, int z)
    {
        GO.transform.parent = transform;
        GO.name = x.ToString() + ", " + z.ToString();
    } 
}


