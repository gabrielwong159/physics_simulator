﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public int cameraMode;

    public GameObject cameraFront;
    public GameObject cameraLeft;
    public GameObject cameraRight;
    public GameObject cameraBack;

    Camera c1;
    Camera c2;
    Camera c3;
    Camera c4;

    void Start() {
        c1 = cameraFront.GetComponent<Camera>();
        c2 = cameraLeft.GetComponent<Camera>();
        c3 = cameraRight.GetComponent<Camera>();
        c4 = cameraBack.GetComponent<Camera>();
        
        Matrix4x4 mat = c1.projectionMatrix;
        mat *= Matrix4x4.Scale(new Vector3(-1, 1, 1));
        c1.projectionMatrix = mat;
        
        cameraToggle(cameraMode);
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.C)) {
            cameraMode = (cameraMode == 1) ? 0 : 1;
            cameraToggle(cameraMode);
        }
    }

    void cameraToggle(int mode) {
        if (mode == 1) oneCamera();
        else fourCamera();
    }

    void oneCamera() {
        cameraEnable(false);

        c1.rect = new Rect(0, 0, 1, 1);
    }

    void fourCamera() {
        cameraEnable(true);

        cameraFront.transform.position = new Vector3(1.08f, 1.25f, 2.95f);
        cameraFront.transform.rotation = Quaternion.Euler(new Vector3(30, -150, 180));
        c1.rect = new Rect(0.25f, 0.0f, 0.5f, 0.5f);

        cameraLeft.transform.position = new Vector3(0.83f, 2.0f, -1.2f);
        cameraLeft.transform.rotation = Quaternion.Euler(new Vector3(45, -30, 90));
        c2.rect = new Rect(0.1f, 0.25f, 0.3f, 0.5f);
        c2.depth = 2;

        cameraRight.transform.position = new Vector3(-0.96f, 2.0f, 2.53f);
        cameraRight.transform.rotation = Quaternion.Euler(new Vector3(45, 150, 90));
        c3.rect = new Rect(0.6f, 0.25f, 0.3f, 0.5f);
        c3.depth = 2;

        cameraBack.transform.position = new Vector3(-0.94f, 2.0f, -1.24f);
        cameraBack.transform.rotation = Quaternion.Euler(new Vector3(45, 30, 180));
        c4.rect = new Rect(0.35f, 0.5f, 0.3f, 0.5f);
    }

    void cameraEnable(bool enable) {
        c2.enabled = enable;
        c3.enabled = enable;
        c4.enabled = enable;
    }
}