using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    TurretBuilder turretBuilder;
    public TurretStats CannonT1;

    public TurretStats CannonT2;

    public TurretStats turretT3_1;

    private void Start()
    {
        turretBuilder = TurretBuilder.instance;

    }

   

    public void PickTurret1()
    {
        turretBuilder.SetTurrettoBuild(turretBuilder.Turret1Prefab);

    }
    public void PickTurret2()
    {
        turretBuilder.SetTurrettoBuild(turretBuilder.turretT2Prefab);

    }
    public void PickTurret3()
    {
        turretBuilder.SetTurrettoBuild(turretBuilder.turretT3Prefab);

    }
}
