using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4c : MonoBehaviour
{
    float DespX;
    float DespY;
    //Hacia delante
    float DespZ;
    float speed = 5f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        DespX = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * DespX * speed * Time.deltaTime);

        DespY = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * DespY * speed * Time.deltaTime);

        DespZ = Input.GetAxis("Forward");
        transform.Translate(Vector3.forward * DespZ * speed * Time.deltaTime);

    }
}
