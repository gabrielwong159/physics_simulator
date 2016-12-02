using UnityEngine;
using System.Collections;

public class ZComponentDrawer : MonoBehaviour {

    int travelSpeed;
    float lineSize;
    float arrowSize;
    public GameObject gameObject;
    LineRenderer line;
    
    void Start() {
        travelSpeed = GlobalVariables.travelSpeed;
        lineSize = GlobalVariables.lineSize;
        arrowSize = GlobalVariables.arrowSize;

        line = GetComponent<LineRenderer>();
        line.SetWidth(0.02f, 0.02f);
        line.SetVertexCount(2);
        line.material = new Material(Shader.Find("Particles/Additive"));
        line.SetColors(Color.white, Color.white);
    }
    
    void Update() {
        if (DrawingController.state == DrawingController.DEFAULT || DrawingController.state == DrawingController.RADIAL) drawZVector(Time.time);
        else if (DrawingController.state == DrawingController.MANUAL) drawZVector(GlobalVariables.rotationAngle);
    }

    void drawZVector(float t) {
        Vector3 center = transform.position;

        float theta = Mathf.Deg2Rad * t * travelSpeed;
        float dz = (transform.position.z - gameObject.transform.position.z) * lineSize;

        Vector3 pos = new Vector3(center.x, center.y, center.z + dz);
        line.SetPosition(0, center);
        line.SetPosition(1, pos);
    }
}
