using UnityEngine;

public class EX1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    /* Sistema de Level do Jogador
    Peça o nível do jogador e XP:
    • Se nível >= 10
    o Se XP >= 1000 → "Jogador experiente"
    o Senão → "Jogador em evolução"
    • Senão
    o Se XP >= 200 → "Jogador iniciante avançando"
    o Senão → "Jogador iniciante" */

    [SerializeField] private int xp;
    [SerializeField] private int nivel;

    void Start()
    { if (nivel >= 10)
            if (xp >= 1000)
                print("jogador experiente");


            else
                print("jogador em evolução");


        else

         if (xp >= 200)
                print("jogador iniciante avançado");

            else
                print("jogador iniciante");




        }

    }
    





