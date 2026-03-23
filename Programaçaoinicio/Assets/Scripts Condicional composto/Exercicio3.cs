using UnityEngine;

public class Exercicio3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    /* 
     3. Sistema de Vida do Jogador
    Crie uma variável vida (int).
    • Se vida > 0, mostre "Jogador vivo"
    • Caso contrário, mostre "Game Over"
    */

    [SerializeField] private int vida;

void Start()
{
        if (vida > 0)
            print("sua vida é de" + vida + "voce esta vivo");
        else if (vida<=0) 
                print("game over");
}

// Update is called once per frame
void Update()
{

}
}
