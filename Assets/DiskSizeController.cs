using UnityEngine;
using System.Collections;

public class DiskSizeController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        float diskSize = GlobalVariables.radius * GlobalVariables.lineSize * 2;
        transform.localScale = new Vector3(diskSize, 0, diskSize);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
