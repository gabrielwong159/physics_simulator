using UnityEngine;
using System.Collections;

public class DiskRendererScript : MonoBehaviour {

    //for some reason, DiskMaterial gets overwritten by "Particles/Additive (Instance)"
    //the sole purpose of this script is to overwrite the overwritten material
    //the material is overwritten in Update(), because having it in Start() still allows it to be overwritten
    //trust me, this hurts me as much as it hurts you right now
    //but it's 4am and i just want it to work so hey

    public Material mat;
    Renderer rend;

	void Start () {
        rend = GetComponent<Renderer>();
	}
	
	void Update () {
        rend.material = mat;
    }
}
