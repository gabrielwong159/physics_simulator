using UnityEngine;
using System.Collections;

public class ConeDrawer : MonoBehaviour {

    float radius;
    public GameObject gameObject;
    LineRenderer line;

	// Use this for initialization
	void Start () {
        radius = GlobalVariables.radius;

        line = GetComponent<LineRenderer>();
        line.SetWidth(0.02f, 0.02f);
        line.SetVertexCount(722);
        line.material = new Material(Shader.Find("Particles/Additive"));
        line.SetColors(Color.blue, Color.blue);
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 center = gameObject.transform.position;

        for (int i = 0; i <= 360; i++) {
            float theta = Mathf.Deg2Rad * i;
            float dx = Mathf.Cos(theta) * radius;
            float dy = Mathf.Sin(theta) * radius;

            Vector3 pos = new Vector3(center.x + dx, center.y + dy, center.z);
            line.SetPosition(i * 2, transform.position);
            line.SetPosition(i * 2 + 1, pos);
        }
    }
}
