using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Starting_Position;
    public int Rotation_Counter = 0;
    public static float Horizontal_Velocity;
    // Start is called before the first frame update
    void Start()
    {
        Starting_Position = transform.position.x;
    }

    // Update is called once per frame
    // If you are looking for the players total code it is in Camera folloe
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            Rotation_Counter = 180;
            transform.rotation = Quaternion.Euler(0, 180, 0);

        }
        if (Input.GetKeyDown("d"))
        {
            Rotation_Counter = 0;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        Horizontal_Velocity = (transform.position.x - Starting_Position) / Time.deltaTime;
        Starting_Position = transform.position.x;
    }
}
