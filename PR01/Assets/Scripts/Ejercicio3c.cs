using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3c : MonoBehaviour
{

    int sec = 0;
    bool contador = true;

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine ("Contador");
        
     

    }

    // Update is called once per frame
    void Update()
    {

        if (sec == 11)
        {
            contador = false;
            StopCoroutine("Contador");
        }


    }


    IEnumerator Contador()
    {

        while (true){


            print(sec); 
            sec++;
            yield return new WaitForSeconds(1f);


        }



    }

}
