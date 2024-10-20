using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menuhandeler : MonoBehaviour
{
    public bool m_Active;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (m_Active == false)
            {
                gameObject.transform.GetChild(2).gameObject.SetActive(true);
                m_Active = true; //Number can be adjusted
            }
            else
            {
                gameObject.transform.GetChild(2).gameObject.SetActive(false);
                m_Active = false;
            }
        }
    }
}
