using UnityEngine;
using System.Collections;

public class DiskDrawer : MonoBehaviour {

    float lineSize;
    public GameObject gameObject;
    LineRenderer line;
    
	void Start () {
        lineSize = GlobalVariables.lineSize;

        line = GetComponent<LineRenderer>();
        line.SetWidth(0.04f, 0.04f);
        line.SetVertexCount(361);
        line.material = new Material(Shader.Find("Particles/Additive"));
        line.SetColors(new Color(1, 1, 1, 0.3f), new Color(1, 1, 1, 0.3f));

        float dz = (transform.position.z - gameObject.transform.position.z) * lineSize;

        Vector3 center = transform.position + new Vector3(0, 0, dz);

        for (int i = 0; i <= 360; i++) {
            float theta = Mathf.Deg2Rad * i;
            float dx = Mathf.Cos(theta) * lineSize;
            float dy = Mathf.Sin(theta) * lineSize;

            Vector3 pos = new Vector3(center.x + dx, center.y + dy, center.z);
            /*
            line.SetPosition(i * 2, center);
            line.SetPosition(i * 2 + 1, pos);
            */
            line.SetPosition(i, pos);
        }
    }
	
	void Update () {
    }
}
