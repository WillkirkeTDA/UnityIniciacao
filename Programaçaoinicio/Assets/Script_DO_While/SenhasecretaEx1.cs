using UnityEngine;

public class SenhaSecreta : MonoBehaviour
{
    // Palavras secretas do jogo
    private string[] palavrasSecretas = { "espadada", "maligno", "capetão america", "dragonite", "tesoura" };

    // Tentativas do jogador (preenchidas no Inspector)
    [SerializeField] private string[] tentativasDoJogador = new string[5];

    // Pontuação do jogador
    private int pontuacao = 0;

    void Start()
    {
        // Verificar se o jogador preencheu todas as tentativas
        if (tentativasDoJogador.Length != palavrasSecretas.Length)
        {
            print("Você deve preencher 5 tentativas no Inspector!");
            return;
        }

        // Percorrer todas as palavras secretas
        for (int i = 0; i < palavrasSecretas.Length; i++)
        {
            string palavra = palavrasSecretas[i].ToLower(); // converter para minúscula
            string tentativa = tentativasDoJogador[i].ToLower(); // tentativa do jogador

            // Gerar dica
            string dica;
            if (palavra.Length > 4)
                dica = palavra.Substring(0, 3); // 3 primeiros caracteres
            else
                dica = palavra;

            print("Dica da palavra " + (i + 1) + ": " + dica);

            // Verificar se acertou
            if (tentativa == palavra)
            {
                pontuacao += 10;
                print("Você acertou! +10 pontos");
            }
            else
            {
                pontuacao -= 5;
                print("Você errou! -5 pontos (a palavra era: " + palavra + ")");
            }

            print("Pontuação atual: " + pontuacao);
            print("-----------------------------");
        }

        // Resultado final
        if (pontuacao >= 30)
            print("Parabéns! Você venceu com " + pontuacao + " pontos!");
        else
            print("Você perdeu. Pontuação final: " + pontuacao);
    }
}