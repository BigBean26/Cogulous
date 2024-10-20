using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDtutstone : MonoBehaviour
{
    bool W_Button_Pressed = false;
    bool A_Button_Pressed = false;
    bool S_Button_Pressed = false;
    bool D_Button_Pressed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("d"))
            D_Button_Pressed = true;
        if (Input.GetKeyDown("a"))
            A_Button_Pressed = true;
        if (Input.GetKeyDown("w"))
            W_Button_Pressed = true;
        if (Input.GetKeyDown("s"))
            S_Button_Pressed = true;
        if( W_Button_Pressed && S_Button_Pressed && A_Button_Pressed && D_Button_Pressed)
            Destroy(gameObject);

    }
}
