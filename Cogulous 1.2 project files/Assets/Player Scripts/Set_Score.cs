using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Set_Score : MonoBehaviour
{
    public int Score;
    public int High_Score = 0;
    public Text Score_text;
    public Text High_Score_Text;
    Dictionary<string, int> Top_Ten_Players = new Dictionary<string, int>();
    
 
    // Start is called before the first frame update
    void Start()
    {
        Score = PlayerPrefs.GetInt("1");
        Score_text.text = "Score: " + Score.ToString();
        

        Top_Ten_Players.Add("Test_Player",0);
    }
    private void Update()
    {
        High_Score = PlayerPrefs.GetInt("3");
        High_Score_Text.text = "High Score: " + High_Score.ToString();
        if (Score > High_Score)
        {
            PlayerPrefs.SetInt("3", Score);
        }

    }
}
