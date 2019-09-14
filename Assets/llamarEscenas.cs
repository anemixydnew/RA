using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class llamarEscenas : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void CargarNivel(string pNombreEscena)
    {
        SceneManager.LoadScene(pNombreEscena);
    }
}
