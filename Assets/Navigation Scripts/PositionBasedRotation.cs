using UnityEngine;
using System.Collections;

// for now, I've conflated rotation and movement a bit (temporary)

public class PositionBasedRotation : MonoBehaviour
{

    public GameObject palm;
    public float speed = 200f;

    Vector3 palmInitPos;

    bool shouldRotate;

    void Awake()
    {
        shouldRotate = false;
    }

    Vector3 GenerateRotationVector()
    {
        // Quaternion -> Vector3 

        Vector3 palmCurrPos = palm.transform.position;

        Vector3 diff = palmCurrPos - palmInitPos; // this is equal to subtraction. Quat weirdness

        diff.x = -diff.x * Time.deltaTime * speed;
        diff.y = diff.y * Time.deltaTime * speed;
        diff.z = -diff.z * Time.deltaTime * speed;

        return diff;
    }

    void Rotate()
    {
        if (shouldRotate)
        {
            Quaternion currRot = transform.rotation;
            transform.rotation = Quaternion.Euler(currRot.eulerAngles + GenerateRotationVector());
        }
    }

    public void ToggleRotationMode()
    {
        palmInitPos = palm.transform.position;
        shouldRotate = !shouldRotate;

        Debug.Log("Rotation toggled!");
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }
}
