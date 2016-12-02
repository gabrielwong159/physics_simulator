using UnityEngine;
using System.Collections;

public class BitchBallSpecial : MonoBehaviour {

    float offset;

    public GameObject gameObject;

	void Start () {
        offset = 0.8f;
	}
	
	void Update () {
        transform.position = gameObject.transform.position + new Vector3(offset, 0, 0);
	}
}
