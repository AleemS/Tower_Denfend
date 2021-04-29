using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBuilder : MonoBehaviour {

    private GameObject turretToBuild;
    public static TurretBuilder instance;
    public bool CanBuild { get { return turretToBuild != null; } }

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

	void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("To many instants");
            return;
        }
        instance = this;
    }

    public GameObject standardTurretPrefab;
    public GameObject turretTTwoPrefab;

   // private TurretBlueprint turretTo;

   void Start()
    {
        turretToBuild = standardTurretPrefab;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
