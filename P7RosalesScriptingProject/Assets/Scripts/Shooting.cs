using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Rigidbody bullet;
    public Transform firePosition;
    public float bulletSpeed;

    private Inventory inventory;


    private void Awake()
    {
        inventory = GetComponent<Inventory>();
    }
    
    // Update is called once per frame
    void Update()
    {
        Shoot();
    }


    void Shoot()
    {
        if (Input.GetButtonDown("Fire1") && inventory.myStuff.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bullet, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulletSpeed);
            inventory.myStuff.bullets--;
        }
    }
}
