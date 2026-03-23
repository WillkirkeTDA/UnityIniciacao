using UnityEngine;

public class Exercicio6 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    /* 
     Sistema de Compra no Jogo
    Crie variáveis:
    • moedas (int)
    • custoItem (int)
    Verifique:
    • Se moedas >= custoItem → "Compra realizada"
    • Senão → "Moedas insuficientes" 
    */

    [SerializeField] private int moedas;
    [SerializeField] private int custoitem;

void Start()
{
        if (moedas >= custoitem) 
        print("compra realizada");
        else if (moedas <= custoitem)
            print("moedas insuficientes");
      
}

// Update is called once per frame
void Update()
{

}
}
