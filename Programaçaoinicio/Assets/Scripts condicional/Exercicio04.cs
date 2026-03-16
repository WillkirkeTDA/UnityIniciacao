using UnityEngine;

public class Exercicio04 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    /* 
     Peça dois números e:
    a. Verifique se eles são iguais ou diferentes.
    */

    [SerializeField] private int numero1;
    [SerializeField] private int numero2;

void Start()
{ if (numero1 == numero2) 
        print("os numeros são iguais");
        else { print("os numeros são diferentes");
            
            }
}

// Update is called once per frame
void Update()
{

}
}
