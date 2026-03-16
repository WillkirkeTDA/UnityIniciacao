using NUnit.Framework.Internal;
using System.Runtime.CompilerServices;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
/* Crie um código que mostre o resto da divisão de 17 por 4.
 * Use o operador %. */


public class EXERCICIO5 : MonoBehaviour
{
    private float divisao = 17f;
    private float divisor = 4f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    float resto =divisao%divisor;

    print("o resto da divisão é =" + resto);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
