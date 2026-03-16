using UnityEngine;

public class ScriptVariaveis : MonoBehaviour
{

    [SerializeField] private string aluno;

    [SerializeField] private float nota1;

    [SerializeField] private float nota2;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float media = (nota1 + nota2) / 2;
        bool aprovado = media >= 6F;
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
