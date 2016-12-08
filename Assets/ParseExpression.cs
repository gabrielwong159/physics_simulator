using UnityEngine;
using System.Collections;

public class ParseExpression : MonoBehaviour {
    B83ExpressionParser.Expression zFn;

	// Use this for initialization
	void Start () {
        zFn = new B83ExpressionParser.ExpressionParser().EvaluateExpression("x^2 + y/2");   


        zFn.Parameters["x"].Value = 5; // set the named parameter "x"
        zFn.Parameters["y"].Value = 2;
        
        float val = (float) zFn.Value;
        
        Debug.Log(Mathf.Abs(val) == float.PositiveInfinity);
            
        Debug.Log("Result: " + val);  // prints: "Result: 522"
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
