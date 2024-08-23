using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metodos : MonoBehaviour
{
    
    void Start()
    {
        string respuestaMetodos;

        respuestaMetodos = Respuesta("Adios");

        Debug.Log(respuestaMetodos);
    }


public string Respuesta(string palabra)
    {
        if (palabra=="Hola")
        {
            return "Buenos dias";
        }
        else if(palabra == "Adios")
        {
            return "Hasta luego";

        }
        else
        {
            return "No entiendo";
        }
    }
   
}
