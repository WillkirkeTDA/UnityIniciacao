using UnityEngine;

public class Exercicio4 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    /*  
      Sistema de Pontuação
    Com base em uma variável pontuacao:
    • >= 100 → "Rank S"
    • >= 70 → "Rank A"
    • >= 50 → "Rank B"
    • Senão → "Rank C" 
    */

    [SerializeField] private int pontuacao;

void Start()
{if (pontuacao >= 100)
            print("rank S");
        else if (pontuacao >= 70)
            print("rank A");
        else if (pontuacao >= 50)
            print("rank B");
        else print("rank C");

}

// Update is called once per frame
void Update()
{

}
}
