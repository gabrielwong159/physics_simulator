﻿using UnityEngine;
using System.Collections;

public class ResultantVectorDrawer : MonoBehaviour {

    float radius;
    int travelSpeed;
    float lineSize;
    float arrowSize;
    public GameObject gameObject;
    LineRenderer line;
    
	void Start () {
        radius = GlobalVariables.radius;
        travelSpeed = GlobalVariables.travelSpeed;
        lineSize = GlobalVariables.lineSize;
        arrowSize = GlobalVariables.arrowSize;

        line = GetComponent<LineRenderer>();
        line.SetWidth(0.01f, 0.01f);
        line.SetVertexCount(5);
        line.material = new Material(Shader.Find("Particles/Additive"));
        line.SetColors(Color.green, Color.green);
    }
	
	void Update () {
        if (KeyboardController.state == KeyboardController.DEFAULT || KeyboardController.state == KeyboardController.RADIAL) drawSingleVector(Time.time);
        else if (KeyboardController.state == KeyboardController.MANUAL) drawSingleVector(GlobalVariables.rotationAngle);
    }

    private void drawSingleVector(float t) {
        Vector3 center = transform.position;

        float theta = Mathf.Deg2Rad * t * travelSpeed;
        float dx = -1 * Mathf.Cos(theta) * lineSize * radius;
        float dy = -1 * Mathf.Sin(theta) * lineSize * radius;
        float dz = (transform.position.z - gameObject.transform.position.z) * lineSize;

        Vector3 pos = new Vector3(center.x + dx, center.y + dy, center.z + dz);
        
        float arrowHeadRotationInitial = Mathf.Atan((transform.position.z - gameObject.transform.position.z) / radius) - Mathf.PI/4;
        Vector3 arrowHeadLeftInitial = LinearTransformation.xzRotation(new Vector3(arrowSize, 0, 0), arrowHeadRotationInitial, LinearTransformation.CLOCKWISE);
        Vector3 arrowHeadRightInitial = LinearTransformation.xzRotation(new Vector3(0, 0, -arrowSize), arrowHeadRotationInitial, LinearTransformation.CLOCKWISE);

        Vector3 arrowHeadLeft = LinearTransformation.xyRotation(arrowHeadLeftInitial, theta, LinearTransformation.COUNTERCLOCKWISE);
        Vector3 arrowHeadRight = LinearTransformation.xyRotation(arrowHeadRightInitial, theta, LinearTransformation.COUNTERCLOCKWISE);

        line.SetPosition(0, center);
        line.SetPosition(1, pos);
        line.SetPosition(2, pos + arrowHeadLeft);
        line.SetPosition(3, pos);
        line.SetPosition(4, pos + arrowHeadRight);
    }
}
