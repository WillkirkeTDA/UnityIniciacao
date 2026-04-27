using UnityEngine;

public class Super_Trunfo : MonoBehaviour
{ /*
   * força
   * velocidade
   * inteligencia
   */

    int[] cartajogador1 = new int [3];
    int[] cartajogador2 = new int [3];

    int pontosjogador1;
    int pontosjogador2;

    int atributos;
    int rodadas;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rodadas = 0;
        pontosjogador1 = 0;
        pontosjogador2 = 0;

        atributos = Random.Range (0, 3);

        for (int i = 0; i < 3; i++)
        {
            cartajogador1 [i] = Random.Range(1,10);
            cartajogador2 [i] = Random.Range(1,10);
        }

        if(atributos == 0)
        {
            if (cartajogador1[1] == cartajogador2[1])

                print("empate");



        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown && rodadas < 5)
        {
            rodadas++;



        }
    }
}
