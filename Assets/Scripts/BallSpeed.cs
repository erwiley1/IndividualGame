using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BallSpeed : MonoBehaviour
{
    //this code gets the speed for the cannon to shoot with some velocity. Credit to Matt Diaz and this youtube video for helping me https://www.youtube.com/watch?v=wkKsl1Mfp5M&t=603s
    public float speed = 5f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    // Update is called once per frame
    void Update()
    {
        DestroyBalls();
    }

    void DestroyBalls()
    {
        Destroy(this.gameObject, 5f);
    }




}
