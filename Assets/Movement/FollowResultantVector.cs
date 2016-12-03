using UnityEngine;
using System.Collections;

public class FollowResultantVector : MonoBehaviour {

    float lineSize;

    MeshRenderer mesh;

    public GameObject ring;
    public GameObject ball;
    
    void Start () {
        lineSize = GlobalVariables.lineSize;

        mesh = GetComponentInChildren<MeshRenderer>();
        mesh.material = new Material(Shader.Find("Particles/Additive"));
        mesh.material.SetColor("_TintColor", new Color(1, 1, 1, 0.1f));
    }
	
	void Update () {
        transform.position = ball.transform.position + new Vector3(0, 0, (ball.transform.position.z - ring.transform.position.z) * lineSize);
    }
}
