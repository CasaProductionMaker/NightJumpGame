using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

	public Transform FirePoint;

	public GameObject bulletPrefab;

	public bool GotGun = false;

	public GameObject PlayerGun;

    // Update is called once per frame
    void Update()
    {
    	if(GotGun)
    	{
    		PlayerGun.gameObject.SetActive(true);
	        if(Input.GetButtonDown("Fire1"))
	        {
	        	Shoot();
	        }
    	}else{
    		PlayerGun.gameObject.SetActive(false);
    	}
    }

    void Shoot()
    {
    	Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
    }

    public void UnlockGun()
    {
    	GotGun = true;
    }
}
