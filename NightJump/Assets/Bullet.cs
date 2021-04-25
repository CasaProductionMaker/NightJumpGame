using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

	public float speed = 20f;

	public Rigidbody ribo;

    // Start is called before the first frame update
    void Start()
    {
        ribo.velocity = transform.forward * speed;
    }

    public void OnTriggerEnter()
    {
    	Destroy(gameObject);
    }
}
