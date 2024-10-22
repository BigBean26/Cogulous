using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BillOldgun : MonoBehaviour
{
    public LayerMask Player_Mask;
    public Rigidbody2D rb2D;
    public Transform Player; // player's position
    public Transform Bill; // Bill's postion
    public Collider2D Bill_Oldgun_Collider;
    public Collider2D Melee_Weapon;
    public bool Player_Within_Range;
    public int Rotation_Factor = 1;
    public int Enemy_Health = 100;
    private bool Is_Invincible = false;
    public GameObject Bullet; // Bill's shotgun bullet object
    public float Muzzle_Velocity = 700f;
    public LayerMask Bullet_Layer;
    public bool Reloaded = true;
    public bool Can_Move = true;
    public bool Is_Dead = false;
    int Is_Dead_pp = 0;


    public void Turning_To_Player()
    {
        float Distance_To_Player = Vector2.Distance(Player.position, transform.position);
        if (Distance_To_Player <= 100f)
        {
            Player_Within_Range = true;
        }
        else
        {
            Player_Within_Range = false;
        }
        float Angle_To_Player = Mathf.Atan2(Player.position.y - Bill.position.y, Player.position.x - Bill.position.x) * 180 / Mathf.PI;
        if ((Angle_To_Player <= 180f && Angle_To_Player >= 90f) || (Angle_To_Player >= -180f && Angle_To_Player <= -90f))
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            Rotation_Factor = -1;
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            Rotation_Factor = 1;
        }
    }
    private IEnumerator Invincibility()
    {
        Is_Invincible = true;
        yield return new WaitForSeconds(Melee_Controller.Invincibility_Frames);
        if (Is_Invincible == true)
        {
            Debug.Log("Bill is invincible");
        }
        Is_Invincible = false;
    }
    public void Immunity_Frames()
    {
        StartCoroutine(Invincibility());
    }
    public void Move_In_Radius()
    {
        float Distance_To_Player = Vector2.Distance(Player.position, transform.position);
        if (Player_Within_Range == true)
        {
            if (Distance_To_Player < 30)
            {
                rb2D.AddForce(Vector2.left * 5 * Rotation_Factor, ForceMode2D.Force);
            }
            if (Distance_To_Player > 30)

            {
                rb2D.AddForce(Vector2.right * 5 * Rotation_Factor, ForceMode2D.Force);

            }
        }

    }
    public void Damage_Handler()
    {
        int Melee_Selected = Melee_Controller.Melee_Style;
        bool Weapon_Live = Melee_Controller.Weapon_Live;
        if (Bill_Oldgun_Collider.IsTouching(Melee_Weapon) && Is_Invincible == false && Weapon_Live == true)
        {

            switch (Melee_Selected)
            {
                case 1:
                    Enemy_Health -= 10;
                    break;
                case 2:
                    Enemy_Health -= 20;
                    break;
                case 3:
                    Enemy_Health -= 100;
                    break;

            }
            Debug.Log(Melee_Selected);
            Immunity_Frames();
        }
        if (Enemy_Health <= 0)
        {
            Is_Dead = true;
        }
        if (Is_Dead)
        {
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            Bill_Oldgun_Collider.enabled = false;
            GetComponent<Renderer>().enabled = false;
            Respawn();
        }



    }

    private IEnumerator Respawn()
    {
        yield return new WaitForSeconds(1f);
        Enemy_Health = 100;
        Is_Dead = false;
        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        Bill_Oldgun_Collider.enabled = true;
        GetComponent<Renderer>().enabled = true;
    } 
    public void Bullet_Fire()
    {
        int Bullet_Angle = Random.Range(-10,30);
        float Total_Velocity_Bullet = 1004.987562f;
        float Bullet_Velocity_Vertical_Component = Total_Velocity_Bullet * Mathf.Sin(Mathf.Deg2Rad*Bullet_Angle);
        float Bullet_Velocity_Horizontal_Component = Total_Velocity_Bullet * Mathf.Cos(Mathf.Deg2Rad * Bullet_Angle);
        GameObject Shotgun_Pellet = Instantiate(Bullet, transform.position, transform.rotation);
        Shotgun_Pellet.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(Bullet_Velocity_Horizontal_Component * Rotation_Factor, Bullet_Velocity_Vertical_Component));
    }
    private IEnumerator Reload()
    {
        Reloaded = false;
        yield return new WaitForSeconds(3);
        Reloaded = true;

    }
    public void Shotgun()
    {

        if (Player_Within_Range && Reloaded == true)
        {
            Bullet_Fire();
            Bullet_Fire();
            Bullet_Fire();
            Bullet_Fire();
            StartCoroutine(Reload());
        }



    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Turning_To_Player();
        if(Can_Move == true)
            Move_In_Radius();
        if (Is_Dead == false)
        {
            Damage_Handler();
            Shotgun();

        }
        if (Is_Dead == true)
        {
            Is_Dead_pp = 1;
            PlayerPrefs.SetInt("4",Is_Dead_pp );
            SceneManager.LoadScene(4);

        }


    }
}
