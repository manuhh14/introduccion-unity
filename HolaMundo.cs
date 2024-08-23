using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{

    /*Declaracion de  variables*/
    
    //Integer numeros ensteros sin decimal
    int entero = 1;

    //Float numeros con decimales
    float flotante = 2.5f;

    //Long enteros mucho mas grandes(8 bytes)
    long largo = 77777777777;

    //Double decimales muy grandes 
    double doubles = 2.4151945464556465;

    //String texto
    string frase = "Hola mundo";

    //Char character
    char letra = 'a';

    //Bool Booleana true o flase
    bool booleana = true;

    int numero1=2, numero2=3;
    int resultado= 0;


  
   
    void Start()
    {
        Debug.Log("Hola mundo");
        Debug.Log(frase);


        resultado = numero1 + numero2;
        Debug.Log("El resultado de la suma es: "+resultado);
    }
  
}
