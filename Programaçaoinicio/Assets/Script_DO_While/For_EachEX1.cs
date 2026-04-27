using UnityEngine;

public class For_EachEX1 : MonoBehaviour
{
    [SerializeField] private string frase;

    void Start()
    {
        // Converter para minúsculas
        frase = frase.ToLower();

        // Separar palavras
        string[] palavras = frase.Split(' ');

        int maioresQue4 = 0;

        // Percorrer com foreach
        foreach (string palavra in palavras)
        {
            if (palavra.Length > 4)
            {
                maioresQue4++;
                print(palavra.Substring(0, 3));
            }
            else
            {
                print(palavra);
            }
        }

        print("Quantidade de palavras com mais de 4 letras: " + maioresQue4);
    }
}