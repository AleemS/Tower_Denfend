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

    public GameObject Turret1Prefab;
    public GameObject turretT2Prefab;
    public GameObject turretT3Prefab;

    // private TurretBlueprint turretTo;

    public void SetTurrettoBuild (GameObject turret)
    {
        turretToBuild = turret;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
