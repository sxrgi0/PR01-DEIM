using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1b : MonoBehaviour
{

    [SerializeField] string nombre = "Sergio";

    // Start is called before the first frame update
    void Start()
    {
        //El valor en el método Start sobreescribe al de Unity
        nombre = "Pepe";
        Debug.Log(nombre);
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
