using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    private Transform target;
    public float speed = 70f;

    public int damage = 30;
    public void Seek(Transform _target)
    {
        target = _target;
    }

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);

    }

    void HitTarget()
    {
       Destroy(gameObject);
    }

    void Damage (Transform enemy)
    {
       Enemy e = enemy.GetComponent<Enemy>();

        if (e != null)
        {
            e.TakeDamage(damage);
        }

        e.TakeDamage(damage);

        Destroy(enemy.gameObject);
    }
}
