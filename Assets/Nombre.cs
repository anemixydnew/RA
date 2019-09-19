using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Nombre : MonoBehaviour {
    public InputField IngresarNombre;
    public Text SacarNombre;
    public void enviarAtrapar()
    {
        SacarNombre.text = "hola " + IngresarNombre.text + " !";
    }
}
