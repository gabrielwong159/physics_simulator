using UnityEngine;
using System.Collections;

public class MoveWithHand : MonoBehaviour {

    public GameObject palm;
    public float speed = 300;

    Vector3 palmInitPos, forward, right, up;
    bool shouldMove;

    void Awake ()
    {
        shouldMove = false;
    }

	float GenerateMovementCoordinate(float c)
    {
        return c * Mathf.Abs(c) * Time.deltaTime * speed;
    }

    Vector3 adjustForDirection(Vector3 addVector)
    {
        Vector3 currPalmRot = transform.rotation.eulerAngles;

        return addVector;
    }

	Vector3 GenerateMovementVector () {
        Vector3 diff = palm.transform.position - palmInitPos;
        Vector3 movement = new Vector3(0, 0, 0);

        movement -= diff.x * right;
        movement -= diff.y * up;
        movement -= diff.z * forward;

        return movement * Time.deltaTime * speed;
    }

    void Move()
    {
        if (shouldMove)
        {
            Vector3 currPos = transform.localPosition;
            transform.position = currPos - GenerateMovementVector();
        }
    }

    // also lets DataStore know what's up.
    public void ToggleMoveMode()
    {
        shouldMove = !shouldMove;

        if (shouldMove)
        {
            palmInitPos = GameObject.Find("DataStore").GetComponent<InitPalmTransforms>().EnableIsMoving();
            forward = transform.forward;
            right = transform.right;
            up = transform.up;
        } else
        {
            GameObject.Find("DataStore").GetComponent<InitPalmTransforms>().DisableIsMoving();
        }
        

        Debug.Log("Movement toggled!");
    }
	
	// Update is called once per frame
	void Update () {
        Move();
	}
}
