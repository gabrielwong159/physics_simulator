using UnityEngine;
using System.Collections;

public class BitchBall : MonoBehaviour {

    public GameObject gameObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = gameObject.transform.position;
	}
}
