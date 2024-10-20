using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee_Controller : MonoBehaviour
{
    public static int Melee_Style = 1;
    public static bool Weapon_Live = false;
    public static float Invincibility_Frames = 2; // in seconds not individual frames
    public SpriteRenderer Sprite_Renderer;
    public Sprite Pipe_Wrench;
    public Sprite Pipe;
    public Sprite Spanner;
    public void Weapon_Selector()
    {
        if (Input.GetKey("1"))
        {
            Sprite_Renderer.sprite = Spanner;
            Melee_Style = 1;
            Invincibility_Frames = 1;
        }
        if (Input.GetKey("2"))
        {
            Sprite_Renderer.sprite = Pipe;
            Melee_Style = 2;
            Invincibility_Frames = 2;
        }
        if (Input.GetKey("3"))
        {
            Sprite_Renderer.sprite = Pipe_Wrench;

            Melee_Style = 3;
            Invincibility_Frames = 3;
        }
    }
    public void Is_Weapon_Live()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Weapon_Live = true;
        }
        else
        {
            Weapon_Live = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Weapon_Selector();
        Is_Weapon_Live();
    }
}