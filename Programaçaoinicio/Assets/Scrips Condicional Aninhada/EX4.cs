
        

using UnityEngine;
public class Ex4_Classe : MonoBehaviour
{
    void Start()
    {
        int forca = 80;
        int mana = 40;
        if (forca > 70)
        {
            if (mana > 50)
                print("Paladino");
            else
                print("Guerreiro");
        }
        else
        {
            if (mana > 70)
                print("Mago");
            else
                print("Arqueiro");
        }
    }
}
