using UnityEngine;

public class EXERCICIO11 : MonoBehaviour
{ /* Crie:
• public float velocidadeInicial;
• public float aceleracao;
• public float tempo;
Calcule a velocidade final usando:
velocidadeFinal = velocidadeInicial + aceleracao * tempo;
    */
    [SerializeField] private float velocidadeinicial;
    [SerializeField] private float aceleracao;
    [SerializeField] private float tempo;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float velocidadefinal = velocidadeinicial + aceleracao * tempo;

        print("sua velocidade é de " + velocidadefinal);
            
            
     }

    // Update is called once per frame
    void Update()
    {
        
    }
}
