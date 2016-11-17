using UnityEngine;
using System.Collections;

public class RadialVectorDrawer : MonoBehaviour {

    float radius;
    int travelSpeed;
    public GameObject gameObject;
    LineRenderer line;

	// Use this for initialization
	void Start () {
        radius = GlobalVariables.radius;
        travelSpeed = GlobalVariables.travelSpeed;

        line = GetComponent<LineRenderer>();
        line.SetWidth(0.02f, 0.05f);
        line.SetVertexCount(2);
        line.material = new Material(Shader.Find("Particles/Additive"));
        line.SetColors(Color.cyan, Color.cyan);
    }
	
	// Update is called once per frame
	void Update () {
        float t = Time.time;
        Vector3 center = gameObject.transform.position;

        float theta = Mathf.Deg2Rad * t * travelSpeed;
        float dx = Mathf.Cos(theta) * radius;
        float dy = Mathf.Sin(theta) * radius;

        Vector3 pos = new Vector3(center.x + dx, center.y + dy, center.z);
        line.SetPosition(0, transform.position);
        line.SetPosition(1, pos);
    }
}
