using UnityEngine;

public class For_Each1 : MonoBehaviour
{
    [SerializeField] string[] cores = { "azul","verde","amarelo" };




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (string cor in cores)
        print(cor);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
