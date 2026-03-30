using System;
using UnityEngine;
using UnityEngine.UIElements;

public class Batalha_de_dados : MonoBehaviour
{
    private int pontos = 5;
    [SerializeField] private int HP;
    [SerializeField] private int ATK;
    [SerializeField] private int DEF;
     private int HPoponente;
     private int ATKoponente;
     private int DEFoponente;

    private bool podeiniciar;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    
    
    
    {if
  (HP >= 1 && ATK >= 1 && DEF >= 1 && HPoponente >= 1 && ATKoponente >= 1 && DEFoponente >= 1 && HP + ATK + DEF <= 5 && ATKoponente + HPoponente + DEFoponente <= 5)

        podeiniciar = true;
      
    
    HPoponente = Random.Range (1, pontos);
    pontos = pontos - HPoponente;
    DEFoponente = Random.Range (1,pontos);
    pontos = pontos - DEFoponente;
    ATKoponente = Random.Range (1, pontos);
    pontos = ATKoponente;
    }

    // Update is called once per frame
    void Update()
    { if (Input.anyKeyDown && podeiniciar == true);
        
    }
}
