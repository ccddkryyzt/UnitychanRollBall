using UnityEngine;
using System.Collections;

public class MoveBox : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate(new Vector3(10, 30, 90) * Time.deltaTime);
	}
}
