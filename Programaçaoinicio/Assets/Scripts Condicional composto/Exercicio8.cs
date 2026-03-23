using UnityEngine;

public class Exercicio8 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    /* Sistema de Clima no Jogo
    Crie uma variável temperatura:
    • > 30 → "Clima quente"
    • >= 15 → "Clima agradável"
    • < 15 → "Clima frio"
    */

    [SerializeField] private float temperatura;

void Start()
{if (temperatura > 30)
            print("clima quente");


        else if (temperatura >= 15)
            print("clima agradável");


        else if (temperatura < 15)
            print("clima frio");

}

// Update is called once per frame
void Update()
{

}
}
