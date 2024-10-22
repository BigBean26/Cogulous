using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_check_Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Return/enter");
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Left click");
        }
        
    }
}
