using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed = 10f;

    public int health = 50;

    private Transform target;
    private int waypointIndex = 0;

    public Transform partToRotate;
    public float turnSpeed = 10f;

    void Start()
    {
        target = Waypoints.points[0];
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        
        if (health <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        Destroy(gameObject);
    }


    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        Quaternion lookRotation = Quaternion.LookRotation(dir);

        Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
        partToRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);


        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {

            // Vector3 rotation = lookRotation.eulerAngles;
            
            GetNextWaypoint();
        }
        if (target == null)

            return;

    }

    void GetNextWaypoint()
    {
        if(waypointIndex >= Waypoints.points.Length -1)
        {
            EndPath();
            return;
        }

        waypointIndex++;
        target = Waypoints.points[waypointIndex];
    }

    void EndPath ()
    {
        PlayerStats.Lives--;
        Destroy(gameObject);
    }


 }

