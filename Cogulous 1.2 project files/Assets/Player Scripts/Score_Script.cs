using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_Script : MonoBehaviour
{
    public int Score = 0;
    public int Health_Before = 5;
    public int Health_Current = 5;
    public CapsuleCollider2D Melee_Weapon;
    public LayerMask Bill_Layer;


    public void Health_Score_Calculation()
    {
        if (Health_Current < Health_Before)
        {
            Score -= 10;
        }
        if (Health_Current > Health_Before)
        {
            Score += 5;
        }
        Health_Before = Health_Current;
        Health_Current = CameraFolloe.Health;
    }
    public void Kill_Score_Calculation()
    {
        int Melee_Selected = Melee_Controller.Melee_Style;
        bool Weapon_Live = Melee_Controller.Weapon_Live;
        if (Melee_Weapon.IsTouchingLayers(Bill_Layer) && Weapon_Live == true)
        {
            switch (Melee_Selected)
            {
                case 1:
                    Score += 1;
                    break;
                case 2:
                    Score += 2;
                    break;
                case 3:
                    Score += 10;
                    break;

            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Health_Score_Calculation();
        Kill_Score_Calculation();
        PlayerPrefs.SetInt( "1" , Score);
    }
}
