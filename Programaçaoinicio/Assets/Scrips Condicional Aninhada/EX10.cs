using UnityEngine;
public class Ex10_Ranking : MonoBehaviour
{
    void Start()
    {
        int pontuacao = 1800;
        if (pontuacao > 1000)
        {
            if (pontuacao > 2000)
                print("S+");
            else
                print("S");
        }
        else
        {
            if (pontuacao > 500)
                print("A");
            else
                print("B");
        }
    }
}