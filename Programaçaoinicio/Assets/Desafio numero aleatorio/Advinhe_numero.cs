using UnityEngine;

public class Advinhe_numero : MonoBehaviour
{
    [SerializeField] private int numero;

    private int numeroSecreto;
    private int tentativas;
    [SerializeField] private bool facil, medio, dificil;
    void Start()
    {
        if (facil == true)
        {
            numeroSecreto = Random.Range(1, 51);  
            print("Jogo iniciado! Tente adivinhar o número de 1 a 50");
        }
        else if (medio == true)
        {
            numeroSecreto = Random.Range(1, 101);  
            print("Jogo iniciado! Tente adivinhar o número de 1 a 100");
        }
        else if (dificil == true)
        {
            numeroSecreto = Random.Range(1, 501);  
            print("Jogo iniciado! Tente adivinhar o número de 1 a 500");
        }
    }
    void Update()
    {
        if (Input.anyKeyDown)
        {
            tentativas++;

            print("Número digitado foi: " + numero);

            if (numero == numeroSecreto)
            {
                print(" Você acertou!");
                print("Total de tentativas: " + tentativas);

             
            }
            else if (numero > numeroSecreto)
            {
                print("Muito alto!");
            }
            else
            {
                print("Muito baixo!");
            }

            if (tentativas == 2)
            print("dica o numero está entre " + (numeroSecreto + 22) +"e" + (numeroSecreto - 17));

            if (tentativas == 3)
                
             print("jogo terminado" + " o numero secreto era " + numeroSecreto);
        }



    }
}