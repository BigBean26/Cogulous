using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Text_transfer : MonoBehaviour
{
    public string text;
    public Text user_text;
    public void SetText(string text)
    {
        user_text.text = text;
    }
    public void LoadName()
    {
        text = PlayerPrefs.GetString("input");

    }
    private void Start()
    {
        Debug.Log(text);
    }
    private void Update()
    {
       
        
    }
    
}
