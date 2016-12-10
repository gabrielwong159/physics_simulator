using UnityEngine;
using System.Collections;

public class RadialVectorDrawer : MonoBehaviour {

    float radius;
    int travelSpeed;
    public GameObject gameObject;
    LineRenderer line;
    
	void Start () {
        radius = GlobalVariables.radius;
        travelSpeed = GlobalVariables.travelSpeed;

        line = GetComponent<LineRenderer>();
        line.SetWidth(0.02f, 0.05f);
        line.SetVertexCount(2);
        line.material = new Material(Shader.Find("Particles/Additive"));
        line.SetColors(Color.cyan, Color.cyan);
    }
	
	void Update () {
        if (KeyboardController.state == KeyboardController.DEFAULT || KeyboardController.state == KeyboardController.RADIAL) drawRVector(Time.time);
        else if (KeyboardController.state == KeyboardController.MANUAL) drawRVector(GlobalVariables.rotationAngle);
        else line.SetPosition(1, transform.position);
    }

    void drawRVector(float t) {
        Vector3 center = gameObject.transform.position;

        float theta = Mathf.Deg2Rad * t * travelSpeed;
        float dx = Mathf.Cos(theta) * radius;
        float dy = Mathf.Sin(theta) * radius;

        Vector3 pos = new Vector3(center.x + dx, center.y + dy, center.z);
        line.SetPosition(0, transform.position);
        line.SetPosition(1, pos);
    }
}
