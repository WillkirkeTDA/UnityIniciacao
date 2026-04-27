using UnityEditor;
using UnityEngine;

public class Do_While1 : MonoBehaviour
{
   [SerializeField] private string nome;
   [SerializeField] private string procurarletra;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nome = nome.ToUpper();
        procurarletra = procurarletra.ToUpper();
        int i = 0;
        int encontrados = 0;

        do
        {
            if (nome.Substring(i, 1) == procurarletra)
            {
                encontrados++;

            }
            i++;
        }
        


        while (i < nome.Length);

        print("encontrados:" + encontrados);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
