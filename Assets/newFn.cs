using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class newFn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    public void NavigateToWelcomeScreen()
    {
        SceneManager.LoadScene("WelcomeScreen");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
