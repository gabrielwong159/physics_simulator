using UnityEngine;
using System.Collections;

public class AxisZDrawer : MonoBehaviour {

    float axisSize;
    float axisTextOffset;

    public GameObject z;
    public GameObject gameObject;

    LineRenderer line;

    void Start() {
        axisSize = GlobalVariables.axisSize;
        axisTextOffset = GlobalVariables.axisTextOffset;

        line = GetComponent<LineRenderer>();
        line.SetWidth(0.02f, 0.02f);
        line.SetVertexCount(2);
        line.material = new Material(Shader.Find("Particles/Additive"));
        line.SetColors(new Color(1, 1, 1, 0.6f), new Color(1, 1, 1, 0.6f));
    }

    void Update() {
        Vector3 center = transform.position;

        line.SetPosition(0, center);
        line.SetPosition(1, center + new Vector3(0, 0, axisSize));

        z.transform.position = center + new Vector3(axisTextOffset, 0, axisSize);
    }
}
