using UnityEngine;

public class Exercicio03 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

/*Crie um programa que:
a. Receba a um número
b. Mostre se ele é par ou impar
*/

   [SerializeField] private int numero;


void Start()
{
        if (numero % 2 == 0)
            print("o número é par");
        else
        { print("o número é impar"); }
        
            
        
    }

// Update is called once per frame
void Update()
{

}
}
