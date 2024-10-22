using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Set_Score : MonoBehaviour
{
    public int Score;
    public int High_Score = 0;
    public Text Score_text;
    public Text High_Score_Text;
    // Start is called before the first frame update
    void Start()
    {
        Score = PlayerPrefs.GetInt("1");
        Score_text.text = "Score: " + Score.ToString();
        
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
