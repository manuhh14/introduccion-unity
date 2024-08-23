using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listas : MonoBehaviour
{

    List<int> numerosEnteros = new List<int>();
    List<float> numerosFlotantes = new List<float>();

    List<string> nombres = new List<string>();

    string frase = "Megustan los videojuegos";
   
    void Start()
    {
        numerosEnteros.Add(1);
        numerosEnteros.Add (2);
        numerosEnteros.Add (3);

        Debug.Log(numerosEnteros.Count);

        numerosEnteros.Insert(0, 5);

        foreach(int numero in numerosEnteros)
        {
            Debug.Log(numero);
        }

        foreach (char character in frase)
        {
            Debug.Log(character);
        }

        
    }

  
}
