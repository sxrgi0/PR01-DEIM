using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3b : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Calcular(125.6f, 587f, "dividir");
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void Calcular(float num1, float num2, string operacion)
    {
        float resultado = 0f;
        if(operacion == "dividir")
        {
            resultado = num1 / num2;
        }
        else if(operacion == "restar")
        {
            resultado = num1 - num2; 
        }
        else if(operacion == "sumar")
        {
            resultado = num1 + num2;
        }
        else
        {
            resultado = num1 * num2;
        }
              
       
        print(resultado);

    }

}


