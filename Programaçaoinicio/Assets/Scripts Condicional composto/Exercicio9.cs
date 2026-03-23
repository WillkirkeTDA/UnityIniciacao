using UnityEngine;

public class Exercicio9 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    /*
     Acesso a Área Restrita
    Crie variáveis:
    • temChave (bool)
    • nivel (int)
    Permita acesso apenas se:
    • temChave == true e nivel >= 5
    */
    [SerializeField] private bool temchave;
    [SerializeField] private int nivel;


void Start()
{if (temchave == true && nivel >= 5)
            print("acesso permitido");
        else
            print("acesso negado");

}

// Update is called once per frame
void Update()
{

}
}
