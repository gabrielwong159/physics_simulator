using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;
    public GameObject camera4;

    Camera c1;
    Camera c2;
    Camera c3;
    Camera c4;

	void Start () {
        c1 = camera1.GetComponent<Camera>();
        c2 = camera2.GetComponent<Camera>();
        c3 = camera3.GetComponent<Camera>();
        c4 = camera4.GetComponent<Camera>();

        camera1.transform.position = new Vector3(1.08f, 1.25f, 2.95f);
        camera1.transform.rotation = Quaternion.Euler(new Vector3(30, -150, 0));
        c1.rect = new Rect(0.35f, 0.0f, 0.3f, 0.5f);

        camera2.transform.position = new Vector3(0.83f, 2.0f, -1.2f);
        c2.rect = new Rect(0.0f, 0.25f, 0.3f, 0.5f);
        c2.targetDisplay = 0;

        camera3.transform.position = new Vector3(-0.96f, 2.0f, 2.53f);
        c3.rect = new Rect(0.7f, 0.25f, 0.3f, 0.5f);
        c3.targetDisplay = 0;

        camera4.transform.position = new Vector3(-0.94f, 2.0f, -1.24f);
        c4.rect = new Rect(0.35f, 0.5f, 0.3f, 0.5f);
    }
}
