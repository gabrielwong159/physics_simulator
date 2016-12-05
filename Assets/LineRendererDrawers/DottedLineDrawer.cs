using UnityEngine;
using System.Collections;

public class DottedLineDrawer : MonoBehaviour {

    public GameObject gameObject;
    LineRenderer line;

	void Start () {
        Color c = new Color(0.5f, 0.5f, 0.5f, 0.5f);

        line = GetComponent<LineRenderer>();
        line.SetWidth(0.02f, 0.02f);
        line.SetVertexCount(5);
        line.material = new Material(Shader.Find("Particles/Additive"));
        line.SetColors(c, c);
	}
	
	void Update () {
        line.SetPosition(0, transform.position);
        line.SetPosition(1, gameObject.transform.position);
        line.SetPosition(2, gameObject.transform.position + new Vector3(0, GlobalVariables.radius, 0));
        line.SetPosition(3, gameObject.transform.position);
        line.SetPosition(4, gameObject.transform.position + new Vector3(GlobalVariables.radius, 0, 0));
    }
}
