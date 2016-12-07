using UnityEngine;
using System.Collections;

public class KeyboardController : MonoBehaviour {

    public const int DEFAULT = 1;
    public const int RADIAL = 2;
    public const int MANUAL = 3;
    public const int PALPATINE = 8;

    public static int state = DEFAULT;

    private float triggeredTime;

	void Start () {
        triggeredTime = Time.realtimeSinceStartup;
	}
	
	void Update () {
        if (Input.GetKey(KeyCode.Alpha1)) state = DEFAULT;
        else if (Input.GetKey(KeyCode.Alpha2)) state = RADIAL;
        else if (Input.GetKey(KeyCode.Alpha3)) {
            state = MANUAL;
            GlobalVariables.rotationAngle = Time.time;
        }
        else if (Input.GetKey(KeyCode.Alpha8)) state = PALPATINE;

        if (Input.GetKey(KeyCode.Space) && Time.realtimeSinceStartup - triggeredTime > 0.2f) {
            Time.timeScale = (Time.timeScale == 0) ? 1 : 0;
            triggeredTime = Time.realtimeSinceStartup;
        }

        if (Input.GetKey(KeyCode.R)) gameObject.transform.localPosition = new Vector3(0, 0, 0);

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow)) GlobalVariables.rotationAngle += 0.1f;
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.RightArrow)) GlobalVariables.rotationAngle -= 0.1f;
    }
}
