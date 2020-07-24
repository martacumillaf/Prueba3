using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorTiempo : MonoBehaviour
{
    public float contadorTiempo = 30;
    Text Tiempo;
    // Start is called before the first frame update
    void Start()
    {
        Tiempo = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
