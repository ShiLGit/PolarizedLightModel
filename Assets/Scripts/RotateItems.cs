using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateItems : MonoBehaviour {
    private Vector3 oR1;
    public float rLense1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetAxisRaw("Horizontal") > 0.5f)
        {
            rLense1 -= 1;
        }
        if (Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            rLense1 += 1;
        }
   
	}
}
