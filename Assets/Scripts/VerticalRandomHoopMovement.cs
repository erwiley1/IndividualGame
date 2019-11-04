using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalRandomHoopMovement : MonoBehaviour
{
    public float speed = 6f;
    float leftRightEdges = 4f;
    float chanceDirectionChange = 0.02f; // how likely hoop will change direction
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position; // create a var to hold current position
        pos.y += speed * Time.deltaTime; // sets the xpos of our ship to the speed var * sec since last frame
        transform.position = pos;

        if (pos.y < -leftRightEdges)
        { // if the ship pos is less than -10 set speed to a pos number
            speed = Mathf.Abs(speed);
        }
        else if (pos.y > leftRightEdges)
        {

            speed = -Mathf.Abs(speed);  // if the hoop pos x is greater than 10 reverse speed
        }
    }

    void FixedUpdate()
    {

        if (Random.value < chanceDirectionChange)
        {  // change direction at a random interval
            speed *= -1;

        }
    }

}