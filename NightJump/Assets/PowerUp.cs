using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

	public GameObject PE;

    Weapon gun;

    void Start()
    {
        gun = GameObject.FindGameObjectWithTag("Player").GetComponent<Weapon>();
    }

    void OnTriggerEnter(Collider other)
    {
    	if(other.CompareTag("Player"))
    	{
    		Pickup(other);
    	}
    }

    void Pickup(Collider player)
    {
    	Instantiate(PE, transform.position, transform.rotation);

        gun.UnlockGun();

    	Destroy(gameObject);
    }
}
