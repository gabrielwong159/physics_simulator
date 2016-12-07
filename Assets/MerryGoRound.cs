using UnityEngine;
using System.Collections;

public class MerryGoRound : MonoBehaviour {
    public GameObject refObj;
    public float radius = 10f;
    public float scale = 1f;

    private Vector3 initRot;
    private float initTime;

    void Start () {
	}

    void OnEnable() {
        initTime = Time.timeSinceLevelLoad;
        // we need the camera to get to its starting position first
        transform.position = radius * scale * (new Vector3(Mathf.Cos(0f), 0, Mathf.Sin(0f)));

        // get camera to look at whatever we need and hae that as the focal point
        transform.LookAt(refObj.transform); // should change this to the Vector3 centre pt of the entire sim
        initRot = transform.rotation.eulerAngles;
    }
	
	void Update () {
        float time = Time.timeSinceLevelLoad - initTime;
        transform.position = radius * scale * (new Vector3(Mathf.Cos(time), 0, Mathf.Sin(time)));

        // converting in and out of quaternion is so annoying
        Vector3 eulerRot = transform.rotation.eulerAngles;
        float yRot = initRot.y - time * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(initRot.x, yRot, initRot.z);
	}
}
