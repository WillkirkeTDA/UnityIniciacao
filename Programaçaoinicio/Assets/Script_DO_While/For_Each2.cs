using UnityEngine;

public class For_Each2 : MonoBehaviour
{

    [SerializeField] private int[] numeros = { 1, 32, 22, 87, 93, 41 };




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int pares = 0;
        int impares = 0;

        foreach (int n in numeros)
        { if(n % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
   
        }
        print ("pares: " + pares);
        print ("impares: " + impares);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
