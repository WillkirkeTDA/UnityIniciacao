
using UnityEngine;
public class Ex6_Missao : MonoBehaviour
{
    void Start()
    {
        int inimigos = 12;
        float tempo = 6f;
        if (inimigos >= 10)
        {
            if (tempo < 5)
                print("Missão perfeita");
            else
                print("Missão completa");
        }
        else
        {
            if (inimigos >= 5)
                print("Missão parcial");
            else
                print("Missão falhou");
        }
    }
}
