using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculosPersonalizados : MonoBehaviour
{
    // Start is called before the first frame update
    public float num1;
    public float num2;
    public float resultado;
    void Start()
    {
        resultado = num1 + num2;
        Debug.Log(resultado);
        resultado = num1 - num2;
        Debug.Log(resultado);
        resultado = num1 * num2;
        Debug.Log(resultado);
        resultado = num1 / num2;
        Debug.Log(resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
