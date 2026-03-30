using UnityEngine;

public class EX3 : MonoBehaviour
{
    /* 
     Sistema de vida
Peça HP:
• Se HP > 70
     o Se HP == 100 → "Vida cheia"
     o Senão → "Saudável"
• Senão
    o Se HP > 30 → "Ferido"
    o Senão → "Crítico"
    */

    [SerializeField] private int hp;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { if (hp >= 70)
            if (hp == 100)
                print("vida cheia");

            else print("saudavel");
        else
            if (hp <= 30) ;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
