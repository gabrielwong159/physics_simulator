using UnityEngine;
using System.Collections;

public class resetPos : MonoBehaviour {

    public GameObject camera, graph;

    Vector3 initPosCam;
    Quaternion initRotCam;

    Vector3 initPosGraph;
    Quaternion initRotGraph;

    // Use this for initialization
    void Start ()
    {
        initPosCam = camera.transform.position;
        initRotCam = camera.transform.rotation;

        initPosGraph = graph.transform.position;
        initRotGraph = graph.transform.rotation;
    }
	
	// Update is called once per frame
	public void resetCameraPos ()
    {
        camera.transform.position = initPosCam;
        camera.transform.rotation = initRotCam;

        graph.transform.position = initPosGraph;
        graph.transform.rotation = initRotGraph;
    }
}
