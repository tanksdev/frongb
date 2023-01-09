using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private Text Score;
    private void Start()
    {
        if(GetComponentInChildren<Text>() != null)
    {
        //Score = GetComponentInChildren<Text>();
        //updateScoreDisplay(0);
        Score = GameObject.FindGameObjectWithTag("score").GetComponent<Text>();
        updateScoreDisplay(0);
    }
    }
    public void updateScoreDisplay(int Frog)
    {
        Score.text = "Frogs " + Frog.ToString();
    }
}
