using UnityEngine;
using System.Collections;

public class WorldManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        Vector3 tmp = col.transform.position;
        tmp.z = 32;
        tmp.y = Random.Range(-1f, 1f);
        col.transform.position = tmp;
    }
}
