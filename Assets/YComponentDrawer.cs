﻿using UnityEngine;
using System.Collections;

public class YComponentDrawer : MonoBehaviour {

    int travelSpeed;
    float lineSize;
    float arrowSize;
    LineRenderer line;

    // Use this for initialization
    void Start() {
        travelSpeed = GlobalVariables.travelSpeed;
        lineSize = GlobalVariables.lineSize;
        arrowSize = GlobalVariables.arrowSize;

        line = GetComponent<LineRenderer>();
        line.SetWidth(0.02f, 0.02f);
        line.SetVertexCount(2);
        line.material = new Material(Shader.Find("Particles/Additive"));
        line.SetColors(Color.magenta, Color.magenta);
    }

    // Update is called once per frame
    void Update() {
        float t = Time.time;

        Vector3 center = transform.position;

        float theta = Mathf.Deg2Rad * t * travelSpeed;
        float dy = -1 * Mathf.Sin(theta) * lineSize;

        Vector3 pos = new Vector3(center.x, center.y + dy, center.z);
        line.SetPosition(0, center);
        line.SetPosition(1, pos);
    }
}
