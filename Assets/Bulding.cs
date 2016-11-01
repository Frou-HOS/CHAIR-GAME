using UnityEngine;
using System.Collections;

public class Bulding : MonoBehaviour {
    public float factorSpeed = 0.3f;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 tmp = transform.position;
        tmp.z -= factorSpeed;
        transform.position = tmp;
	}
}
