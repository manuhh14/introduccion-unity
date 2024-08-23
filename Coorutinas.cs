using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coorutinas : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine("MiCorutina");
    }

    IEnumerator MiCorutina()
    {
        Debug.Log("Hola");

        yield return new WaitForSeconds(1);

        Debug.Log("Buenos Dias");

        yield return new WaitForSeconds(3);

        Debug.Log("Hasta luego");

        StartCoroutine("MiCorutina");
    }

   
  
}
