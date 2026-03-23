using UnityEngine;

public class Exercicio2 : MonoBehaviour
{
    /*
     2. Comparação de Três Números
 Declare três variáveis float e mostre qual delas é a maior.
    */

    [SerializeField] private float variavel1;
    [SerializeField] private float variavel2;
    [SerializeField] private float variavel3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {if (variavel1 > variavel2 && variavel1 > variavel3)
            print(variavel1 + "é a maior");
        else if (variavel2 > variavel1 && variavel2 > variavel3)
            print(variavel2 + "é a maior");
        else 
            print(variavel3 + "é a maior");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
