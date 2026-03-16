using UnityEngine;
using UnityEngine.Rendering;

public class EXERCICIO12 : MonoBehaviour
{

    /*•crie:
  public int pontosBase;
• public int inimigosDerrotados;
• public int bonus;
Calcule:
pontuacaoFinal = (pontosBase * inimigosDerrotados) + bonus;
Mostre o resultado no Console.*/


    [SerializeField] private int pontosbase;

    [SerializeField] private int inimigosderrotados;

    [SerializeField] private int bonus;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int pontuacaofinal = (pontosbase * inimigosderrotados) + bonus;


        print("você recebeu um bonus de " + bonus + " após derrotar " + inimigosderrotados + " inimigos " + " sua pontuação de " + pontosbase + " agora é de " + pontuacaofinal + " pontos ");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
