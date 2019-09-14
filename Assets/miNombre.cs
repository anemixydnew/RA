using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miNombre : MonoBehaviour {

    public GUIText textoNombre;
    public void Start()
    {
        textoNombre.text = "" + PlayerPrefs.GetString("nombre");
    }
}
