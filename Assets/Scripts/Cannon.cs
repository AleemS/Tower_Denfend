﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour {

   // [Header("Attributes")]

    private Transform target;
    public float range = 15f;

    public string enemyTag = "Enemy";

    public Transform partToRotate;
    public float turnSpeed = 10f;


    public float fireRate = 1f;
    public float fireCountdown = 0f;

    public GameObject BulletPreFab;
    public Transform firePiont;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }
		

    void UpdateTarget ()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
            return;

        Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        //  Vector3 rotation = lookRotation.eulerAngles;
        Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
        partToRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);

        if (fireCountdown <= 0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate;

        }

        fireCountdown -= Time.deltaTime;
    }
        void Shoot()
        {
            GameObject bulletGO =  (GameObject)Instantiate(BulletPreFab, firePiont.position, firePiont.rotation);
            Bullet bullet = bulletGO.GetComponent<Bullet>();

            if (bulletGO != null)
                bullet.Seek(target);
        }
    
        
        
       
        

 

}
