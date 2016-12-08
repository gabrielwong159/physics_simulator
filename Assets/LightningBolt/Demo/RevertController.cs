using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class RevertController : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha0)) SceneManager.LoadScene("props");
	}
}
