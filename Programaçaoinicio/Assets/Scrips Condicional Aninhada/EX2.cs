using UnityEngine;

public class EX2 : MonoBehaviour
{

    /* Ataque em combate
Peça se tem arma e força:
• Se tem arma
o Se força > 50 → "Ataque forte"
o Senão → "Ataque médio"
• Senão
o Se força > 50 → "Ataque improvisado forte"
o Senão → "Ataque fraco" 
    */

    [SerializeField] private bool arma;
    [SerializeField] private float forca;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { if (arma == true)
            if (forca >= 50)
                print("ataque forte");


            else print("ataque médio");

        else
            if (forca >= 50)
            print("ataque improvisado forte");



           else print("ataque fraco");




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
