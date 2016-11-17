using UnityEngine;
using System.Collections;

public class RingDrawer : MonoBehaviour {

    float radius;
    LineRenderer line;

	// Use this for initialization
	void Start () {
        radius = GlobalVariables.radius;

        line = GetComponent<LineRenderer>();
        line.SetWidth(0.05f, 0.05f);
        line.SetVertexCount(361);
        line.material = new Material(Shader.Find("Particles/Additive"));
        line.SetColors(Color.red, Color.red);

        Vector3 center = transform.position;

        for (int i=0; i<=360; i++) {
            float theta = Mathf.Deg2Rad * i;
            float dx = Mathf.Cos(theta) * radius;
            float dy = Mathf.Sin(theta) * radius;
            Vector3 pos = new Vector3(center.x + dx, center.y + dy, center.z);

            line.SetPosition(i, pos);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
