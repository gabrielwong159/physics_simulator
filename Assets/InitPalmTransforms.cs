using UnityEngine;
using System.Collections;

public class InitPalmTransforms : MonoBehaviour {

    public GameObject palm;

    bool isMoving;
    Vector3 initPalmPos, clearVector;

    void Awake()
    {
        clearVector = initPalmPos = new Vector3(9999, 9999, 9999);
    }

    void ClearIfNotMoving()
    {
        if (!isMoving) initPalmPos = clearVector;
    }

    public Vector3 EnableIsMoving()
    {
        isMoving = true;

        if (initPalmPos == clearVector) initPalmPos = palm.transform.position;

        return initPalmPos;
    }

    public void DisableIsMoving()
    {
        isMoving = false;

        Invoke("ClearIfNotMoving", 0.25f); // 0.25s delay
    }
}