using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    void Update()
    {
        this.transform.Rotate(new Vector3(10, 30, 45) * Time.deltaTime);
    }
}
