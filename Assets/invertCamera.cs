using UnityEngine;
using System.Collections;

public class invertCamera : MonoBehaviour {
    

	// Use this for initialization
	void Start () {
        Camera camera = GetComponent<Camera>();
        camera.projectionMatrix *= Matrix4x4.Scale(new Vector3(-1, 1, 1));
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
