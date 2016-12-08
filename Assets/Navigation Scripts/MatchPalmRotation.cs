using UnityEngine;
using System.Collections;

public class MatchPalmRotation : MonoBehaviour {

    public GameObject palm;

    bool shouldRotate;
    public float rotationScale = 1.5f;
    public bool isOppositeDirection;

    Vector3 initCubeEuler, initPalmEulerRot;

	// Use this for initialization
	void Awake () {
        shouldRotate = false;
	}

    public void ToggleRotationMode()
    {
        shouldRotate = !shouldRotate;
        initPalmEulerRot = palm.transform.rotation.eulerAngles;
        initCubeEuler = transform.rotation.eulerAngles;

        Debug.Log("Rotation mode toggled!");
    }

    Vector3 applyScale(Vector3 rotationVector)
    {
        rotationVector.x *= rotationScale;
        rotationVector.y *= rotationScale;
        rotationVector.z *= rotationScale;

        return rotationVector;
    }
	
	// Update is called once per frame
	void Update () {
        if (shouldRotate)
        {
            Vector3 diff = palm.transform.rotation.eulerAngles - initPalmEulerRot;

            diff = applyScale(diff);
            if (isOppositeDirection) diff = -diff;
            transform.rotation = Quaternion.Euler(initCubeEuler - diff);
        }
	}
}
