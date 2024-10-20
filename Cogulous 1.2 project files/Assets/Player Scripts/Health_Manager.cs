using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Health_Manager : MonoBehaviour
{
    public SpriteRenderer Sprite_Renderer;
    public Sprite HP5;
    public Sprite HP4;
    public Sprite HP3;
    public Sprite HP2;
    public Sprite HP1;
    public Sprite HP0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int Current_Health = CameraFolloe.Health;
        switch (Current_Health)
        {
            case 5:
                Sprite_Renderer.sprite = HP5;
                break;
            case 4:
                Sprite_Renderer.sprite = HP4;
                break;
            case 3:
                Sprite_Renderer.sprite = HP3;
                break;
            case 2:
                Sprite_Renderer.sprite = HP2;
                break;
            case 1:
                Sprite_Renderer.sprite = HP1;
                break;
            case 0:
                Sprite_Renderer.sprite = HP0;
                break;

        }

    }
}
