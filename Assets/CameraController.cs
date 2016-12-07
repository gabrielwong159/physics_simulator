using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public int oneCamera;

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

        if (oneCamera == 1) {
            
        }
        else {
            cameraFront.transform.position = new Vector3(1.08f, 1.25f, 2.95f);
            cameraFront.transform.rotation = Quaternion.Euler(new Vector3(30, -150, 0));
            c1.rect = new Rect(0.35f, 0.0f, 0.3f, 0.5f);

            cameraLeft.transform.position = new Vector3(0.83f, 2.0f, -1.2f);
            cameraLeft.transform.rotation = Quaternion.Euler(new Vector3(45, -30, 0));
            c2.rect = new Rect(0.0f, 0.25f, 0.3f, 0.5f);

            cameraRight.transform.position = new Vector3(-0.96f, 2.0f, 2.53f);
            cameraRight.transform.rotation = Quaternion.Euler(new Vector3(45, 150, 0));
            c3.rect = new Rect(0.7f, 0.25f, 0.3f, 0.5f);

            cameraBack.transform.position = new Vector3(-0.94f, 2.0f, -1.24f);
            cameraBack.transform.rotation = Quaternion.Euler(new Vector3(45, 30, 0));
            c4.rect = new Rect(0.35f, 0.5f, 0.3f, 0.5f);
        }

    }
}