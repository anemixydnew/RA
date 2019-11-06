using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Nombre : MonoBehaviour {
    /*public InputField IngresarNombre;
    public Text SacarNombre;
    public void enviarAtrapar()
    {
        SacarNombre.text = "hola " + IngresarNombre.text + " !";
    }*/
    public Text SacarNombre;

    public string rutaArchivo;
   // int x;
    public void sacarName()
    {
        SacarNombre.text = "hola " + ComparteDatos.comparteDatos.IngresarNombre + " !";
    }
    public void cargar()
    {
          int x = UnityEngine.Random.Range(1, 5);
       // x = 0;
        Debug.Log("x vale: "+x);
        if (x == 1)
        {
            rutaArchivo = Application.persistentDataPath + "/datos.dat";
            if (File.Exists(rutaArchivo))
            {
                Debug.Log("x vale:0 pero es: " + x);
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open(rutaArchivo, FileMode.Open);
                DatosAGuardar datos = (DatosAGuardar)bf.Deserialize(file);
                SacarNombre.text = "hola " + datos.Nombre + ", hoy veremos el tema 'Estructuras repetitivas'!!!";
                file.Close();
              //  x = 2;
                Debug.Log("x vale ahora:1 pero es: " + x);
            }
        }
        else if (x == 2)
        {
           rutaArchivo = Application.persistentDataPath + "/datos.dat";
           if (File.Exists(rutaArchivo))
           {
                Debug.Log("x vale:1 pero es: " + x);
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open(rutaArchivo, FileMode.Open);
                DatosAGuardar datos = (DatosAGuardar)bf.Deserialize(file);
                SacarNombre.text = datos.Nombre + ", si quieres videos que te expliquen más sobre estos ejercicios en Scratch, puedes presionar el botón morado";
                file.Close();
               // x = 3;
                Debug.Log("x vale ahora:0 pero es: " + x);
            }
        }
        else if (x == 3)
        {
            rutaArchivo = Application.persistentDataPath + "/datos.dat";
            if (File.Exists(rutaArchivo))
            {
                Debug.Log("x vale:1 pero es: " + x);
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open(rutaArchivo, FileMode.Open);
                DatosAGuardar datos = (DatosAGuardar)bf.Deserialize(file);
                SacarNombre.text = datos.Nombre + ", si quieres ver ejemplos de la vida real sobre este tema presiona el botón celeste";
                file.Close();
               // x = 1;
                Debug.Log("x vale ahora:0 pero es: " + x);
            }
        }
        else if (x == 4)
        {
            SacarNombre.text = "";
        }
        // Debug.Log("nombre es: " + datos.Nombre + ", hoy veremos el tema 'Estructuras repetitivas'!!!, 
        //si quieres videos que te expliquen más sobre estos ejercicios en Scratch, puedes precionar el botón morado, 
        //y si quieres ver ejemplos de la vida real sobre este tema preciona el botón celeste");
    }
}
