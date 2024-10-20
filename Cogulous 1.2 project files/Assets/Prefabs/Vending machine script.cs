using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vendingmachinescript : MonoBehaviour
{
    public Collider2D Vending_Machine;
    public CapsuleCollider2D Melee_Weapon;
    public GameObject Heart;
    public int Stock = 0;
    public Vector3 Offset = new Vector3(0,0,0);
    public SpriteRenderer spriterenderer;
    public Sprite broken;
    // Start is called before the first frame update
    void Start()
    {
        Stock += Random.Range(2, 3);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vending_Machine.IsTouching(Melee_Weapon) && Input.GetKeyDown("e") && Stock > 0)
        {
            GameObject Heart_Orb = Instantiate(Heart, transform.position + Offset, transform.rotation);
            Heart_Orb.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(20 * 1, 1));
            Stock -= 1;
        }
        if (Stock == 0)
        {
            spriterenderer.sprite = broken;
        }
    }
}
