using System.Runtime.CompilerServices;
using UnityEngine;

public class EXERCICIO3 : MonoBehaviour
{
    /*Crie uma variável pontos com valor 10.
Crie uma variável multiplicador com valor 3.
Calcule a pontuação final e mostre no Console.
Use o operador */

    private float pontos = 10f;
    private int multiplicador = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        print ("voce recebeu pontos =" + (pontos * multiplicador));

    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
