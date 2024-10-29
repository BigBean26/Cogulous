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
    public AudioSource Sound_Effects;
    public bool Cooled_Down = true;
    public void Weapon_Selector()
    {
        if (Input.GetKey("1"))
        {
            Sprite_Renderer.sprite = Spanner;
            Melee_Style = 1;
            Invincibility_Frames = 1;
            Debug.Log("1");
        }
        if (Input.GetKey("2"))
        {
            Sprite_Renderer.sprite = Pipe;
            Melee_Style = 2;
            Invincibility_Frames = 3;
            Debug.Log("2");
        }
        if (Input.GetKey("3"))
        {
            Sprite_Renderer.sprite = Pipe_Wrench;

            Melee_Style = 3;
            Invincibility_Frames = 30;
            Debug.Log("3");
        }
    }
    public void Is_Weapon_Live()
    {
        if (Input.GetMouseButtonDown(0) && Cooled_Down)
        {
            Weapon_Live = true;
            Sound_Effects.Play();
            Debug.Log("click");

        }
        else
        {
            Weapon_Live = false;
        }
    }

    private IEnumerator Weapon_Cooldown()
    {
        Cooled_Down = false;
        yield return new WaitForSeconds(Invincibility_Frames/10);
        Cooled_Down = true;
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
