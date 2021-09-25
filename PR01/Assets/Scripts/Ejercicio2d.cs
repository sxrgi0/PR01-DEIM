using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2d : MonoBehaviour
{

    int n = 0;
    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        
        while (n != 5)
        {
            print(n);
            n = Random.Range(0, 10);
            i++;
            


        }

        print("Es 5!");
        print("N repeticiones: " + i);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
