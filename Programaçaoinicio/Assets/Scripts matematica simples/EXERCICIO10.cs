using UnityEngine;

public class EXERCICIO10 : MonoBehaviour
{
    /*
     Crie uma variável salario = 1000f.
    Aumente 10% no salário e mostre o valor final.
    Dica:
    salario + (salario* 0.10f)
    */

    private float salario = 1000f;





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float aumento = salario + (salario * 0.10f);

        print("você recebeu um aumento de 10% seu salário de " + salario + "R$" + " e agora ele equivale a " + aumento + "R$");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
