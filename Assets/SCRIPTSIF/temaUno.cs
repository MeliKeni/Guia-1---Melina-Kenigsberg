using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temaUno : MonoBehaviour
{
    // Start is called before the first frame update
    public string monedaDeseada;
    public float montoAConvertir;
    float montoConvertido;
    float cotizacion;

    void Start()
    {
        if(montoAConvertir < 1000)
        {
            Debug.Log("El monto minimo es 1000");
            return;
        }

        
        if (monedaDeseada == "D")
        {
            cotizacion = 1134.5f;
        }
        else if (monedaDeseada == "E")
        {
            cotizacion = 1397.16f;
        } else if (monedaDeseada == "R")
        {
            cotizacion = 211.3f;
        } else
        {
            Debug.Log("Opcion de moneda extranjera no valida");
            return;
        }


        montoConvertido = montoAConvertir / cotizacion;
        Debug.Log("Monto convertido: " + montoConvertido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
