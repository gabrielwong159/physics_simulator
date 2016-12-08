using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class makeVertices : MonoBehaviour {

    // placeholder z(x,y) function
    float Z(float x, float y)
    {
        return x + y + 1;
        // return x * x / y;
    }

	// Use this for initialization
	void Start () {

        // resolution and scale config
        float step = 0.5f, numSteps = 100f, start = 0f;

        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3[] currVertices = mesh.vertices;

        for (int i = 0; i < currVertices.Length; i++)
        {
            Debug.Log(currVertices[i]);
            Debug.Log(i);
        }

        List<Vector3> vertices = new List<Vector3>();

        for (float x = start; x < step*numSteps; x += step)
        {
            for (float y = start; y < step*numSteps; y += step)
            {
                vertices.Add( new Vector3(x, y, Z(x, y)) );
                vertices.Add(new Vector3(x, y, Z(x, y)));
                vertices.Add(new Vector3(x, y, Z(x, y)));
            } 
        }

        Vector3[] newVertices = vertices.ToArray(); // important! need to cast it to a Vector3 array before attaching!

        mesh.vertices = newVertices; // important! Must be an array!


	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
