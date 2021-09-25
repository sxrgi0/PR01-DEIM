using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3a : MonoBehaviour
{

    string Nombre;

    // Start is called before the first frame update
    void Start()
    {

        saludo();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void saludo()
    {
        Nombre = "Sergio";
        print("Hola " + Nombre);


    }

}
