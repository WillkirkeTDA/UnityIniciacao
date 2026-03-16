using UnityEngine;

public class EXERCICIO8 : MonoBehaviour
{
    /* Crie:
• public int vida = 100;
• public int dano;
No Start(), diminua a vida pelo dano informado no Inspector e mostre o
resultado.*/

    [SerializeField] private int vida = 100;
    [SerializeField] private int dano;
         


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int damage = vida - dano;

        print  ("você recebeu um dano de = " +  dano + " diminuindo sua vida de " + vida + " para " + damage );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
