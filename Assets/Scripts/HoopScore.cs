using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HoopScore : MonoBehaviour
{
    public Text BallScore;
    int numberBalls = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Hoop")
        {
           
            BallScore.text = "Your score:" + numberBalls;
            Destroy(gameObject);
        }
    }
}
