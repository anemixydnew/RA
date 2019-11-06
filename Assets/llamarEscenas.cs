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
    public string pNombreEscena;
    public string pNombreEscena2;
    public string pNombreEscena3;
    public string pNombreEscena4;

    public void CargarNivel()
    {
        int x = Random.Range(1,5);
        if (x == 2)
        {
            SceneManager.LoadScene(pNombreEscena);
        }
        else if(x==3)
        {
            SceneManager.LoadScene(pNombreEscena2);
        }
        else if (x == 4)
        {
            SceneManager.LoadScene(pNombreEscena3);
        }
        else
        {
            SceneManager.LoadScene(pNombreEscena4);
        }
    }
}
