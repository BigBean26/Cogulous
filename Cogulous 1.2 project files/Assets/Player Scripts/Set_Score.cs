using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Set_Score : MonoBehaviour
{ public int Score;
    public Text Score_text;
    // Start is called before the first frame update
    void Start()
    {
        Score = PlayerPrefs.GetInt("1");
        Score.ToString();
        OnGUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnGUI()
    {
    GUI.TextField(new Rect(710, 480, 500, 50), "Score: " + Score);
    }
}
