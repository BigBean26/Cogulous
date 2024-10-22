using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Collections.AllocatorManager;

public class Box_Script : MonoBehaviour
{
 
    public Collider2D Box;
    public CapsuleCollider2D Melee_Weapon;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Box.IsTouching(Melee_Weapon) && Input.GetMouseButtonDown(0))
        {
            gameObject.SetActive(false);
        }
        
    }
}
