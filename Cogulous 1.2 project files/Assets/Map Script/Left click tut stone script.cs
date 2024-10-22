using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leftclicktutstonescript : MonoBehaviour
{
    public Collider2D Box_1;
    public Collider2D Box_2;
    public Collider2D Box_3;
    public CapsuleCollider2D Melee_weapon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Melee_weapon.IsTouching(Box_1) || Melee_weapon.IsTouching(Box_2) || Melee_weapon.IsTouching(Box_3))
            {
            if (Input.GetMouseButtonDown(0))
            {
                Destroy(gameObject);
            }
                
               }
        transform.rotation = Quaternion.Euler(0, 0, 0);
        

    }
}
