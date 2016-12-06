using UnityEngine;
using System.Collections;

public class AxisXDrawer : MonoBehaviour {

    float axisSize;
    float axisTextOffset;

    public GameObject x;
    public GameObject gameObject;

    LineRenderer line;

    void Start () {
        axisSize = GlobalVariables.axisSize;
        axisTextOffset = GlobalVariables.axisTextOffset;

        line = GetComponent<LineRenderer>();
        line.SetWidth(0.02f, 0.02f);
        line.SetVertexCount(2);
        line.material = new Material(Shader.Find("Particles/Additive"));
        line.SetColors(new Color(1, 1, 0, 0.6f), new Color(1, 1, 0, 0.6f));
    }
	
	void Update () {
        Vector3 center = transform.position;

        line.SetPosition(0, center);
        line.SetPosition(1, center + new Vector3(axisSize, 0, 0));

        x.transform.position = center + new Vector3(axisSize + axisTextOffset, 0, 0);
    }
}
