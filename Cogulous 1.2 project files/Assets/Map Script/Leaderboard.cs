using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Leaderboard : MonoBehaviour
{
   public string username;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        username = PlayerPrefs.GetString("2");
        text.text = "Username: " + username;
    }

    // Update is called once per frame
    void Update()
    {
    
    }


}