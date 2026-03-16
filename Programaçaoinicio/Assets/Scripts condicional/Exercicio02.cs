using UnityEngine;

public class Exercicio02 : MonoBehaviour
{
    /*
     Faça um programa que:
a. Receba a idade
b. Verifique se a pessoa é maior de idade (18+).
    */
    [SerializeField] private int idade;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {if (idade >= 18) 
        print ("você é maior de idade");

      else { print("você é menor de idade"); }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
