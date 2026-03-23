using UnityEngine;

public class Exercicio10 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    /* Sistema de Combate Simples
    Crie variáveis:
    • vidaJogador
    • vidaInimigo
    Verifique:
    • Se ambos > 0 → "Combate em andamento"
    • Se jogador <= 0 → "Jogador derrotado"
    • Se inimigo <= 0 → "Inimigo derrotado"
    */

    [SerializeField] private float vidajogador, vidainimigo;

void Start()
{if (vidainimigo > 0 && vidajogador > 0)
            print("combate em andamento");
        else if (vidajogador <= 0)
            print("jogador derrotado");
        else if (vidainimigo <= 0)
            print("inimigo derrotado");

}

// Update is called once per frame
void Update()
{

}
}
