using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class Write_Input : MonoBehaviour
{
    private string input;

    
    public void ReadStringInput(string s)
    {
        input = s;
        Debug.Log(input);
    }

    public void Savedata()
    {
        PlayerPrefs.SetString("2", input);
    }
}

