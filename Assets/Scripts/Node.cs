using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour {

    public Color hoverColor;
    public Color startColor;
    private Renderer rend;
    public GameObject turret;
    public Vector3 positionOffset;

    private void Start()
    {
        rend = GetComponent<Renderer>();
       // GetComponent<Renderer>().material.color = hoverColor;
    }

    void OnMouseDown()
    {
        if (turret != null)
        {
            Debug.Log("Can't build here... ");
                return;
        }
        GameObject turretToBuild = TurretBuilder.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
    }

    void OnMouseEnter()
    {
       /* if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (!TurretBuilder.CanBuild)
            return;
            */
        rend.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }

    void Update () {
		
	}
}
