using UnityEngine;

public class Exercicio1 : MonoBehaviour
{
    /*
     1. Verificação de Número Positivo, Negativo ou Zero
Crie um script que receba um número inteiro e informe:
• Se é maior que 0 → "Número positivo"
• Se é menor que 0 → "Número negativo"
• Caso contrário → "Zero" 
    */

    [SerializeField] private int numero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (numero > 0)
        {

            print("numero é positivo");
        }

        else if (numero < 0)
        {

            print("numero é negativo");
        }

        else 
            print("numero é igual a zero");



        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
