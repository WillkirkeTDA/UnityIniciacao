using UnityEngine;

public class Exercicio5 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    /* 
      Crie uma variável velocidade (float):
    • Se for maior que 10 → "Muito rápido"
    • Entre 5 e 10 → "Velocidade média"
    • Menor que 5 → "Muito lento" 
    */

    [SerializeField] private float velocidade;
void Start()
{ if (velocidade > 10)
            print("sua velocidade é de " + velocidade + " você é muito rápido");
        else if (velocidade > 4 && velocidade < 11)
            print("sua velocidade é de " + velocidade + " sua velocidade é média");
        else if (velocidade < 5)
            print("sua velocidade é de " + velocidade + "você é lento");

    }

// Update is called once per frame
void Update()
{

}
}
