using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpikeCollider : MonoBehaviour
{

	public void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Spikes") {
            LoseGame();
        }
    }
    void LoseGame()
    {
    	transform.position = new Vector3(34.6f, 3.18f, -74.723f);
    }
}