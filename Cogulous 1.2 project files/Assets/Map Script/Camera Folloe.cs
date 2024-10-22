using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFolloe : MonoBehaviour
{
    public Rigidbody2D RB2D; //Shortend form of Rigidbody 2D
    public int Rotation_Factor = 1; // Rotation factor keeps track of the rotation, a 1 is right facing and a -1 is left facing.
    public LayerMask Collision_Mask; //Checks for colliders that the player can jump off of
    public float Distance_To_Bottom_Of_Character = 1.5f;
    public float Ray_Seperation = 0.3f; //The distance between the two rays being cast by the player for jump detection
    public static int Health = 5; //starting health
    public bool Is_Invincible = false; // Used for invicbility frames from intially getting damaged
    public Collider2D Player_Collider; //Player collider used to check for damaging or healing items
    public Collider2D Capsule;
    public LayerMask Bullet_Layer; // Layer used for bullets to damage player
    public bool Debug_Mode = false; //Debug tool for Develpers to use in unity to find errors
    public Collider2D Health_Orb;// Collider for the hearts in order for the player to regernate
    public LayerMask Heart_Layer; //Used detect hearts from vending machines
    public bool Menu_Active = false; //Used to check if the menu is open or not so when 'esc' is clicked it open/close
    public CapsuleCollider2D Melee_Weapon; //Collider for Players Melee weapons
    bool key_Down_W = false;
    bool key_down_space = false;

    public void Start()
    {
        Health = 5; // resets health
    }


    // jumping method is here
    public void Jumping()
    {
        Vector2 Ray_Cast_Down_Left = new Vector2(transform.position.x + Ray_Seperation, transform.position.y);
        Vector2 Ray_Cast_Down_Right = new Vector2(transform.position.x - Ray_Seperation, transform.position.y);
        Vector2 Ray_Cast_Direction = Vector2.down;
        RaycastHit2D Hit_Left = Physics2D.Raycast(Ray_Cast_Down_Left, Ray_Cast_Direction, Distance_To_Bottom_Of_Character, Collision_Mask);
        RaycastHit2D Hit_Right = Physics2D.Raycast(Ray_Cast_Down_Right, Ray_Cast_Direction, Distance_To_Bottom_Of_Character, Collision_Mask);
        if (Debug_Mode) //Makes the rayscast visible to developers 
        {
            Debug.DrawRay(Ray_Cast_Down_Right, Ray_Cast_Direction * Distance_To_Bottom_Of_Character, Color.red); 
            Debug.DrawRay(Ray_Cast_Down_Left, Ray_Cast_Direction * Distance_To_Bottom_Of_Character, Color.green);
        }

        if (Input.GetKeyDown("w"))
        {
            key_Down_W = true;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            key_down_space = true;
        }
        if (Input.GetKeyDown("w") || Input.GetKeyDown(KeyCode.Space)) // If 'W' or 'space' is pressed the code for jumping will be called
        {
            if (key_Down_W == true)
            {
                Debug.Log("w");
            }
            if (key_down_space == true)
            {
                Debug.Log("space");
            }
            if (Hit_Left.collider != null || Hit_Right.collider != null) //Checks if Raycasts are touching the ground or if they are not
                RB2D.AddForce(Vector2.up * 20, ForceMode2D.Impulse);
        }

    }

    private IEnumerator Invincibility() 
    {
        Is_Invincible = true;
        yield return new WaitForSeconds(Melee_Controller.Invincibility_Frames);
        Is_Invincible = false;
    }
    public void Immunity_Frames()
    {
        StartCoroutine(Invincibility());
    }
    public void Health_Logic()
    {
        if (Player_Collider.IsTouchingLayers(Bullet_Layer))
        {
            if (Health > 0 && Is_Invincible == false)
                Health -= 1;
            Immunity_Frames();
        }
        if (Player_Collider.IsTouchingLayers(Heart_Layer)) //If a player touches a healing item
        {
            Health += 1;//Adds 1 to their health
        }

    }


    // Update is called once per frame
    void Update()
    {
        {
            if (Health == 0)
            {
                
                SceneManager.LoadScene(3); //Opens death screen scene
            }
        }
        Jumping(); //Calls the jumping code evey frame
        Health_Logic();
        if (Input.GetKey("d")) //For strafing right
        {
            Debug.Log("d");
            RB2D.AddForce(Vector2.right * 20, ForceMode2D.Force);
            Rotation_Factor = 1;
        }
        if (Input.GetKey("a")) // for strafing left
        {
            Debug.Log("a");
            RB2D.AddForce(Vector2.left * 20, ForceMode2D.Force);
            Rotation_Factor = -1;
        }

        if (Input.GetKeyDown("q")) //Dashing
        {
            Debug.Log("q");
            RB2D.velocity = new Vector2(40 * Rotation_Factor, 0);
        }
        if (Input.GetKeyDown(KeyCode.Escape)) //Opens or closes the ingame menu
        {
            Debug.Log("esc");
            if (Menu_Active == false)
            {
                gameObject.transform.GetChild(2).gameObject.SetActive(true);
                Menu_Active = true;
            }
            else
            {
                gameObject.transform.GetChild(2).gameObject.SetActive(false);
                Menu_Active = false;
            }

        }
    }
}

    
    
    
