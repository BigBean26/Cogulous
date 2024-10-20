using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Username : MonoBehaviour
{
    public string username;
    public string user;
    public void Getstring(string key)
    {
        username = PlayerPrefs.GetString(key);
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(username);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnGUI()
    {
        //Fetch the PlayerPrefs settings and output them to the screen using Labels
        GUI.Label(new Rect(50, 50, 200, 30), "Name : " + user + username);
    }

}