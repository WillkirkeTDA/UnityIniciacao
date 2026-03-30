using UnityEngine;
public class Ex7_Energia : MonoBehaviour
{
    void Start()
    {
        int energia = 85;
        if (energia > 80)
        {
            if (energia == 100)
                print("Energia máxima");
            else
                print("Energia alta");
        }
        else
        {
            if (energia > 40)
                print("Energia média");
            else
                print("Energia baixa");
        }
    }
}
