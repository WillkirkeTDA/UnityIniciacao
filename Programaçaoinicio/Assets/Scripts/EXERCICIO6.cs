using UnityEngine;

public class EXERCICIO6 : MonoBehaviour
{ /*Entrada pelo Inspector
Crie uma variável public int idade;
No Start(), mostre a idade digitada no Inspector usando Debug.Log()*/

    [SerializeField] private int idade;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("a idade é=" + idade);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
