using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

	public float speed = 3f;

	public GameObject player;

	GameLoseMenu galome;

    // Start is called before the first frame update
    void Start()
    {
        galome = GameObject.FindGameObjectWithTag("A").GetComponent<GameLoseMenu>();
    }

    // Update is called once per frame
    void Update()
    {
    	transform.LookAt(player.transform);
        transform.position += transform.forward * speed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, 1.94f, transform.position.z);
    }

    public void OnTriggerEnter(Collider other)
    {
    	if(other.gameObject.tag == "Player")
    	{
    		galome.Lose();
    	}
        if(other.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}
