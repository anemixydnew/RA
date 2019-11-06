using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class ComparteDatos : MonoBehaviour {
    public static ComparteDatos comparteDatos;

    public InputField IngresarNombre;
    public string rutaArchivo;
     public Text SacarNombre;
   /* public void enviarAtrapar()
    {
        Debug.Log("hola " + IngresarNombre.text + " !");
        // SacarNombre.text = "hola " + IngresarNombre.text + " !";
    }*/
    void Awake()
    {
        Debug.Log("entro a awake");
        //Debug.Log(Application.persistentDataPath);
        rutaArchivo = Application.persistentDataPath + "/datos.dat";
        if (comparteDatos == null)
        {
            comparteDatos = this;
            DontDestroyOnLoad(gameObject);
        }
        else if(comparteDatos!=this)
        {
            Destroy(gameObject);
        }
        start();

    }
    public void start()
    {
        Debug.Log("entro a start");
        SacarNombre.text = "hola " + IngresarNombre.text + "!";
        cargar();
    }
    void cargar()
    {
        if (File.Exists(rutaArchivo))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(rutaArchivo, FileMode.Open);
            DatosAGuardar datos = (DatosAGuardar)bf.Deserialize(file);
            datos.Nombre=IngresarNombre.text ;
            Debug.Log("entro a cargar archivo existente, ingresa nombre es:"+ IngresarNombre.text);
            file.Close();
        }
        else
        {
            Debug.Log("entro a cargar archivo no existente");
            IngresarNombre.text = "Anonimo";
        }
        guardar();
    }
    void guardar()
    {
        Debug.Log("entro a guardar");

        BinaryFormatter bf = new BinaryFormatter();
        Debug.Log(rutaArchivo);
        FileStream file = File.Create(rutaArchivo);
        DatosAGuardar datos = new DatosAGuardar();
        datos.Nombre = IngresarNombre.text;
        Debug.Log("se guardo"+ IngresarNombre.text);

        bf.Serialize(file, datos);
        file.Close();
    }

}
[Serializable]
class DatosAGuardar
{
    public string Nombre;
   
}
