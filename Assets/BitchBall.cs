using UnityEngine;
using System.Collections;

public class BitchBall : MonoBehaviour {

    public GameObject gameObject;
    
	void Start () {
	}
	
	void Update () {
        transform.position = gameObject.transform.position;
	}
}
