using UnityEngine;

public class Exercicio7 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    /*
    Nível do Jogador
    Com base na variável nivel:
    • <= 10 → "Iniciante"
    • <= 20 → "Intermediário"
    • > 20 → "Avançado" 
     */

    [SerializeField] private int niveldojogador;

    void Start()
{if (niveldojogador <= 10)
            print("iniciante");



        else if (niveldojogador <= 20)
            print("intermediario");


        else if (niveldojogador > 20)
            print("avançado");
              

}

// Update is called once per frame
void Update()
{

}
}
