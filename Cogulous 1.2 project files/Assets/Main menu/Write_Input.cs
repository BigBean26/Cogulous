using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class Write_Input : MonoBehaviour
{
    private string input_Unprocessed;

    
    public void ReadStringInput(string s)
    {
        string input_Unprocessed = s + "       .";
        Debug.Log(input_Unprocessed);
    }

    public void Savedata()
    {
        string input = input_Unprocessed.Substring(0,5);
        PlayerPrefs.SetString("2", input);
    }
}

