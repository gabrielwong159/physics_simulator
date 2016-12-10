using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class RevertController : MonoBehaviour {

    private float triggered;

	void Start () {
        triggered = Time.time;
	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha0)) SceneManager.LoadScene("props");
        if (Time.time - triggered > 10) SceneManager.LoadScene("props");
	}
}
