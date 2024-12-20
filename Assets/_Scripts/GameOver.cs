using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] private ScoreManager scoreManager; // Referência ao script do outro dev
    [SerializeField] private int moedasNecessarias = 10; // Número de moedas para finalizar o jogo
    public bool fimDeJogo = false; // Variável booleana compartilhada com outros scripts

    public delegate void FimDeJogoAction();
    public static event FimDeJogoAction OnFimDeJogo; // Evento para fim de jogo

    private void Update()
    {
        if (!fimDeJogo &&  scoreManager.score >= moedasNecessarias)
        {
            fimDeJogo = true;
            Debug.Log("Fim de Jogo alcançado!");
            OnFimDeJogo?.Invoke(); 
        }
    }
}
