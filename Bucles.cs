using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles : MonoBehaviour
{

    int condicion = 1;//ataques
    bool condicion1 = true;


    void Start()
    {
        //bucles
        switch (condicion)
        {
            case 1:
                Debug.Log("Ataque basico");
                break;
            case 2:
                Debug.Log("Ataque fuerte");
                break;
            case 3:
                Debug.Log("Ataque magico");
                break;
            default:
                Debug.Log("No hacer nada");
                break;
        }



        //While (mientras)

        while (condicion1)
        {
            Debug.Log("Hola");
            condicion1 = false;
        }

    }




}
