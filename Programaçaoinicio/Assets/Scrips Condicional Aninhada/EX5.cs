using UnityEngine;
public class Ex5_Loot : MonoBehaviour
{
    void Start()
    {
        int raridade = 2;
        int sorte = 60;
        if (raridade == 3)
        {
            if (sorte > 80)
                print("Item lendário++");
            else
                print("Item lendário");
        }
        else
        {
            if (raridade == 2)
            {
                if (sorte > 50)
                    print("Item raro bom");
                else
                    print("Item raro comum");
            }
            else
                print("Item comum");
        }
    }
}
