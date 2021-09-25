using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3b : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    float Sumar(float num1, float num2)
    {
        float resultado = num1 + num2;

        print(EsMayorQue5(resultado));

        return resultado;

    }

    bool EsMayorQue5(float numero)
    {

        bool resultado;
        if (numero > 5)
        {
            resultado = true;
        }
        else
        {
            resultado = false;
        }
        return resultado;

    }


}


