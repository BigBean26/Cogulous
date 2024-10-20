using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart_Logic : MonoBehaviour
{
    public CircleCollider2D Collider2D;
    public LayerMask Bullet_Layer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Collider2D.IsTouchingLayers(Bullet_Layer))
        {
            Destroy(gameObject);
        }
    }
}
