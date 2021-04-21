using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


/*
 * open a textfile in unity get result string
 * based on the character of the string instanttly generate different kind of object
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */
public class MapGenerator : MonoBehaviour {

    public Transform TilePreFab;
    public Transform Home;
    public Transform End;
    public Transform Spawn;
    public Transform TilePreFab5;
    public Vector2 mapSize;
    public Transform myTextFile;

    public class ReadFromFile : MonoBehaviour
    {
        public string allText;
    }

    public void ParseFile()
    {


        string text = File.ReadAllText("level_" + "1" + ".txt");

        char[] separators = { ','};
        string[] seperators = { "/n" };
        string[] strValues = text.Split(separators);

//        List<int> intValues = new List<int>();
/*
        foreach (string str in strValues)
        {
            int val = 0;
            if (int.TryParse(str, out val))
                intValues.Add(val);

           
        }
    */
    }
    

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
