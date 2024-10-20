using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutstone123 : MonoBehaviour
{
    bool Button_Pressed3 = false;
    bool Button_Pressed2 = false;
    bool Button_Pressed1 = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
            Button_Pressed1 = true;
        if (Input.GetKeyDown("2"))
            Button_Pressed2 = true;
        if (Input.GetKeyDown("3"))
           Button_Pressed3 = true;

        if( Button_Pressed1 && Button_Pressed2 && Button_Pressed3)
            Destroy(gameObject);

    }
}
