using UnityEngine;

public class Exercicio01 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

/*Crie um programa que:
a. Receba dois números
b. Mostre qual deles é maior.*/

   [SerializeField] private float numero1, numero2;
    

void Start()
{if (numero1 > numero2) 
        print(numero1);
        else
        {


            print(numero2);
        }

    }
    
// Update is called once per frame
void Update()
{

}
}
