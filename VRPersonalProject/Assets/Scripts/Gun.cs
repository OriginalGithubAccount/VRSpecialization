using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    /// <summary>The bullet object</summary>
    public GameObject bullet;
    /// <summary>The gun's barrel where the bullets spawn in</summary>
    public GameObject barrel;
    /// <summary>Bullet travel speed</summary>
    public float bulletSpeed = 2.0f;

    /// <summary>Shoot a projectile (the bullet object)</summary>
    public void Shoot()
    {
        var spawnedBullet = Instantiate(bullet, barrel.transform.position, barrel.transform.rotation);

        if (spawnedBullet.TryGetComponent(out Rigidbody rb))
            AddForce(rb);

        Destroy(spawnedBullet, 3);
    }

    /// <summary>Add a force to the bullet</summary>
    void AddForce(Rigidbody rb)
    {
        rb.AddForce(barrel.transform.forward * bulletSpeed);
    }
}
