using UnityEngine;
using System.Collections;

public class RComponentDrawer : MonoBehaviour {

    int travelSpeed;
    float lineSize;
    float arrowSize;
    LineRenderer line;

    void Start() {
        travelSpeed = GlobalVariables.travelSpeed;
        lineSize = GlobalVariables.lineSize;
        arrowSize = GlobalVariables.arrowSize;

        Color orange = new Color(255.0f/255, 127.0f/255, 63.0f/255);

        line = GetComponent<LineRenderer>();
        line.SetWidth(0.02f, 0.02f);
        line.SetVertexCount(2);
        line.material = new Material(Shader.Find("Particles/Additive"));
        line.SetColors(orange, orange);

        line.SetPosition(0, transform.position);
        line.SetPosition(1, transform.position);
    }

    void Update() {
        line.SetPosition(0, transform.position);
        if (KeyboardController.state == KeyboardController.RADIAL) drawRVector(Time.time);
        else line.SetPosition(1, transform.position);
    }

    void drawRVector(float t) {
        Vector3 center = transform.position;

        float theta = Mathf.Deg2Rad * t * travelSpeed;
        float dx = -1 * Mathf.Cos(theta) * lineSize;
        float dy = -1 * Mathf.Sin(theta) * lineSize;

        Vector3 pos = new Vector3(center.x + dx, center.y + dy, center.z);
        line.SetPosition(1, pos);
    }
}
