using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4a : MonoBehaviour
{

    bool encendido = false;

    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (encendido == false)
            {
                StartCoroutine("Contador");
                encendido = true;

            }
            else
            {
                StopCoroutine("Contador");
                encendido = false;
            }




        }


    }


    IEnumerator Contador()
    {

        for (int n = 0; ; n++)
        {
            print(n);


            yield return new WaitForSeconds(1f);
        }
    }

}
