using UnityEngine;
using System.Collections;

public class KeyboardController : MonoBehaviour {

    public const int DEFAULT = 1;
    public const int RADIAL = 2;
    public const int MANUAL = 3;

    public static int state = DEFAULT;

    private float resetInterval;
    private float lastReset;
    
	void Start () {
        resetInterval = 60;
        lastReset = Time.realtimeSinceStartup;
	}
	
	void Update () {
        float currentTime = Time.realtimeSinceStartup;
        if (currentTime - lastReset > resetInterval) {
            lastReset = currentTime;
            toggleState(DEFAULT);
            Time.timeScale = 1;
            gameObject.transform.localPosition = new Vector3(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.Alpha1)) toggleState(DEFAULT);
        else if (Input.GetKey(KeyCode.Alpha2)) toggleState(RADIAL);
        else if (Input.GetKey(KeyCode.Alpha3)) toggleState(MANUAL);

        if (Input.GetKeyDown(KeyCode.Space)) Time.timeScale = (Time.timeScale == 0) ? 1 : 0;

        if (Input.GetKey(KeyCode.R)) gameObject.transform.localPosition = new Vector3(0, 0, 0);

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow)) GlobalVariables.rotationAngle += 0.1f;
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.RightArrow)) GlobalVariables.rotationAngle -= 0.1f;
    }

    public static void toggleState(int _state) {
        state = _state;
        if (_state == MANUAL) GlobalVariables.rotationAngle = Time.time * GlobalVariables.travelSpeed;
    }
}
