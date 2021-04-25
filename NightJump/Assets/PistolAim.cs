using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolAim : MonoBehaviour
{

	public GameObject ref1;

	public GameObject ref2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire2"))
        {
        	transform.LookAt(ref1.transform);
        }else{
        	transform.LookAt(ref2.transform);
        }
    }
}
