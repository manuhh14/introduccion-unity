using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegundoScript : MonoBehaviour
{

    /*
  Operadores Relacionales

  < menor que 
  > mayor que 
  == igual que 
  != distinto de 
  <= menor o igual que 
  >= mayor o igual que

    Operadores Logicos
    
    &&  Y
    ||  O
    !   NOT
   */

    public int vida = 3;

   
    public int edad = 18;

    void Start()
    {
        if (vida > 0)
        {
            Debug.Log("Esta vivo");
        }

        if (vida <= 0)
        {
            Debug.Log("Estoy muerto");
        }



    }

    private void Update()
    {

        if (edad >= 18)
        {
            Debug.Log("Eres mayor de edad ");
        }
        else if (edad < 18 && edad > 10)
        {
            Debug.Log("Eres Adolecente");
        }
        else if (edad < 10)
        {
            Debug.Log("Eres un infante");
        }
    }

}
