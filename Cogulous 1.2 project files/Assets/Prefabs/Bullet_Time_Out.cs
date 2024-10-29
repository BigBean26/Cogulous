using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Bullet_Time_Out : MonoBehaviour
{

    public LayerMask Bullet_Layer;
    public LayerMask Collision_Mask;
    public bool Primed = false;
    private IEnumerator Collision_Delay_Timer()
    {
        yield return new WaitForSeconds(0.15f);
        Primed = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.layer = LayerMask.NameToLayer("Bullet_Layer");
        StartCoroutine(Collision_Delay_Timer());
        if (GetComponent<Rigidbody2D>().IsTouchingLayers(Collision_Mask) && Primed)
        {
            Destroy(gameObject);
        }
    }
}
