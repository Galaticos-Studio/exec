using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 50; 

    public void AdicionarMoeda()
    {
        score++;
        Debug.Log($"Moedas Coletadas: {score}");
    }
}
