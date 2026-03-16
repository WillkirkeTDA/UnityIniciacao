using System;
using UnityEngine;

public class EXERCICIO7 : MonoBehaviour
{
    /* Crie duas variáveis públicas(numero1 e numero2).
Mostre no Console a soma delas.*/

    [SerializeField] private int numero1;
    [SerializeField] private int numero2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int soma = numero1  + numero2;
        print("a soma de " +  numero1 + " + " +  numero2 + " é igual a " + soma);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
