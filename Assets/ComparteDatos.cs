using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComparteDatos : MonoBehaviour {
    public InputField IngresarNombre;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);

    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
