using UnityEngine;

public class EXERCICIO2 : MonoBehaviour
{ /* 
   * Crie uma variável vida com valor 100.
Crie uma variável dano com valor 25.
Subtraia o dano da vida e mostre o resultado.
Use o operador -.
    */

    private float vida = 100F;
    private float dano = 25f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("voce recebeu dano sua vida diminuiu para = :" + (vida - dano));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
