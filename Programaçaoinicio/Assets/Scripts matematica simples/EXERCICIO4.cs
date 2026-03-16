using UnityEngine;

public class EXERCICIO4 : MonoBehaviour
{
    /*
      O jogador tem 50 moedas e precisa dividir entre 5 personagens.
    Calcule quantas moedas cada um recebe.
    Use o operador /
    */

    private float moedasdojogador = 50f;
  

    private float personagem1= 0f;
    private float personagem2= 0f;
    private float personagem3= 0f;
    private float personagem4= 0f;
    private float  personagem5= 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float moedasPorPersonagem = moedasdojogador / 5f;

        personagem1 = moedasPorPersonagem;
        personagem2 = moedasPorPersonagem;
        personagem3 = moedasPorPersonagem;
        personagem4 = moedasPorPersonagem;
        personagem5 = moedasPorPersonagem;

        print("cada personagem recebeu do jogador :" + (moedasPorPersonagem) + "moedas");
        print("personagem1 recebeu =" + moedasPorPersonagem + "moedas");
        print("personagem2 recebeu =" + moedasPorPersonagem + "moedas");
        print("personagem3 recebeu =" + moedasPorPersonagem + "moedas");
        print("personagem4 recebeu =" + moedasPorPersonagem + "moedas");
        print("personagem5 recebeu =" + moedasPorPersonagem + "moedas");



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
