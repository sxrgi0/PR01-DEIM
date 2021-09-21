using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2c : MonoBehaviour
{



    [SerializeField] int num;

    // Start is called before the first frame update
    void Start()
    {
        for (int aleatorio2 = 0; aleatorio2 != num; aleatorio2 = Random.Range(0, 10))
        {
            print("Aleatorio : " + aleatorio2);
            if (aleatorio2 < 5)
            {
                
            }
            else if (aleatorio2 > 5)
            {
             
            }
            else
            {

            }

        }
    }

    // Update is called once per frame
    void Update()
    {




    }


}