using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1c : MonoBehaviour
{
   
    [SerializeField] int num1 = 5;
    [SerializeField] float num2 = 4.5f;
    float resultado;
    string nombre = "Sergio";

    // Start is called before the first frame update
    void Start()
    {

        resultado = num1 * num2;
        Debug.Log(resultado);

        Debug.Log("Hola " + nombre);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
