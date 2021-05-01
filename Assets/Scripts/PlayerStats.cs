using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public static int Inventory;
    public int startI = 3;

    public static int Lives;
    public int startLives = 15;

    private void Start()
    {
        Inventory = startI;
        Lives = startLives;
    }
}
