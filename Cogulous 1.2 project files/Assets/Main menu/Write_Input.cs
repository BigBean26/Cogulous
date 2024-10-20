using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class Write_Input : MonoBehaviour
{
    public string input;
    public string user;
    public string output;
    public string key = "1";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void readstringinput(string user)
    {
        input = user;
        Debug.Log(user);
        

    }
    public void Savedate(string key, string user)
    {
        PlayerPrefs.SetString(key, user);
    }
    public void Loaddate(string key)
    {
        output = PlayerPrefs.GetString(key);
        Debug.Log(output);
    }
}
