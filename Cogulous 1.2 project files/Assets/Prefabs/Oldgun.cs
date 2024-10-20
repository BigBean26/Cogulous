using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oldgun : MonoBehaviour
{

    public LayerMask Bullet_Layer;
    private IEnumerator Bullet_Time()
    {
        yield return new WaitForSeconds(2f);
        Destroy(GetComponent<Rigidbody2D>());
        Destroy(gameObject);

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.layer = LayerMask.NameToLayer("Bullet_Layer");
        StartCoroutine(Bullet_Time());
    }
}
