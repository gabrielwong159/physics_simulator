using UnityEngine;
using System.Collections;

public class DottedLineDrawer : MonoBehaviour {

    public GameObject gameObject;
    LineRenderer line;

	void Start () {
        line = GetComponent<LineRenderer>();
        line.SetWidth(0.02f, 0.02f);
        line.SetVertexCount(2);

	}
	
	void Update () {
        line.material.SetTextureOffset("_MainTex", new Vector2(Time.timeSinceLevelLoad * 4f, 0f));
        line.material.SetTextureScale("_MainTex", new Vector2(gameObject.transform.position.magnitude, 1f));

        line.SetPosition(0, transform.position);
        line.SetPosition(1, gameObject.transform.position);
    }
}
