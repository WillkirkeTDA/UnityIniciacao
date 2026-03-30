using UnityEngine;
public class Ex9_Boss : MonoBehaviour
{
    void Start()
    {
        int nivel = 22;
        string equipamento = "raro";
        if (nivel >= 20)
        {
            if (equipamento == "raro")
                print("Pronto para o boss");
            else
                print("Arriscado enfrentar o boss");
        }
        else
            print("Muito fraco para o boss");
    }
}

