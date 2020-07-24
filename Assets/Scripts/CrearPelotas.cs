using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearPelotas : MonoBehaviour
{
    public GameObject basketball;

    public float contador;
    public int tiempoLanzarBasketball;

    void Update()
    {
        contador += Time.deltaTime;
        if (contador >= tiempoLanzarBasketball)
        {
            Instantiate(basketball, gameObject.transform);
            contador = 0;
        }
    }
}
