using UnityEngine;
public class Ex8_NPC : MonoBehaviour
{
    void Start()
    {
        int reputacao = 75;
        int ouro = 50;
        if (reputacao > 70)
        {
            if (ouro > 100)
                print("Acesso VIP");
            else
                print("Acesso amigável");
        }
        else
        {
            if (reputacao > 30)
                print("Neutro");
            else
                print("Hostil");
        }
    }
}


