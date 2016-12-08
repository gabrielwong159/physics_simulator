using UnityEngine;
using System.Collections;

public class rotateObject : MonoBehaviour {

    public float xSpeed, ySpeed, zSpeed = 50;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * xSpeed);
        transform.Rotate(Vector3.up * Time.deltaTime * ySpeed);
        transform.Rotate(Vector3.forward * Time.deltaTime * zSpeed);
    }
}
