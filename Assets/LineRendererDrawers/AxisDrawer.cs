using UnityEngine;
using System.Collections;

public class AxisDrawer : MonoBehaviour {

    float axisSize;
    float offset;

    public GameObject x;
    public GameObject y;
    public GameObject z;

    public GameObject gameObject;
    LineRenderer line;

    void Start () {
        axisSize = 0.2f;
        offset = -0.05f;

        line = GetComponent<LineRenderer>();
        line.SetWidth(0.02f, 0.02f);
        line.SetVertexCount(6);
        line.material = new Material(Shader.Find("Particles/Additive"));
        line.SetColors(new Color(1, 1, 1, 0.3f), new Color(1, 1, 1, 0.3f));
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 center = transform.position;
        
        line.SetPosition(0, center);
        line.SetPosition(1, center + new Vector3(-axisSize, 0, 0));
        line.SetPosition(2, center);
        line.SetPosition(3, center + new Vector3(0, 0, axisSize));
        line.SetPosition(4, center);
        line.SetPosition(5, center + new Vector3(0, -axisSize, 0));
        
        x.transform.position = center + new Vector3(-axisSize + offset, 0, 0);
        y.transform.position = center + new Vector3(-offset, -axisSize, 0);
        z.transform.position = center + new Vector3(offset, 0, axisSize);
	}
}
