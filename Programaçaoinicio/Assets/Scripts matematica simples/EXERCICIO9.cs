using Unity.VisualScripting;
using UnityEngine;

public class EXERCICIO9 : MonoBehaviour
{
    /*Crie uma variável numero.
Mostre:
• O dobro do número.
• A metade do número.*/

    [SerializeField] private float numero;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
 float dobro = numero * 2 ;
 float metade = numero / 2 ;

        print ("o dobro de " + numero + " é " + dobro + " e a metade de " + numero + " é " + metade );

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
