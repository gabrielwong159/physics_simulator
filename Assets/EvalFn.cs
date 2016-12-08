using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using System.Text.RegularExpressions;
using AK;

public class EvalFn : MonoBehaviour {
    GameObject InputField;

    string[] depVars;
    AK.ExpressionSolver solver;


	// Use this for initialization
	void setArgs (params double[] values) {
        for (int i = 0; i < depVars.Length; i++)
        {
            solver.SetGlobalVariable(depVars[i], values[i]);
        }
    }


    // parser can't understand [constant]x etc. This turns it into [constant]*x
    string EnsafenFnString(string fnString)
    {
        // recognize 5x, 12321y, etc
        foreach (string depVar in depVars)
        {
            fnString = Regex.Replace(fnString, @"(\d+)" + depVar, "$1*" + depVar);
        }
        
        // recognize xy
        fnString = Regex.Replace(fnString, @"([xy])([xy])", "$1*$2");


        return fnString;
    }

    public void setZFn()
    {


        string userInputFunction = InputField.GetComponent<InputField>().text;
        if (userInputFunction.Length == 0) userInputFunction = "(x^2+y^2)/(xy)";
        userInputFunction = EnsafenFnString(userInputFunction); // make 5x -> 5*x, etc

        Expression zFn = solver.SymbolicateExpression(EnsafenFnString(userInputFunction));

        setArgs(5, 10); 

        Debug.Log("Result: " + zFn.Evaluate());

        GlobalDataStore.setSolver(solver);
        GlobalDataStore.setZFn(zFn);

        SceneManager.LoadScene("main");
    }

    void Start()
    {
        // config
        depVars = new string[2] { "x", "y" };

        // object retrieval
        InputField = GameObject.Find("UIInputFunction");

        // init
        solver = new AK.ExpressionSolver();

        // logic
        foreach (string depVar in depVars)
        {
            solver.SetGlobalVariable(depVar, 0);
            
        }
    }
}
