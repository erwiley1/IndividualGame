using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BallShoot : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform FirePoint;
    public GameObject Ball;
    float rotatespeed = 100f;
    public Text BallScore;
    int numberBalls = 0;
    public AudioSource CannonShot;
    // Update is called once per frame
    void Update()
        //shoots from pressing space
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CannonShot.Play();
            Shoot();
        }
        //this code rotates the cannon, credit to Matt Diaz for helping me
        Quaternion cannonRot = transform.rotation;

        float z = cannonRot.eulerAngles.z;

        z -= Input.GetAxis("Horizontal") * rotatespeed * Time.deltaTime;

        cannonRot = Quaternion.Euler(0, 0, z);

        transform.rotation = cannonRot;

        
    }
    //function to shoot, the cannon shots out of a made invisible object
    void Shoot()
    {
        
        Instantiate(Ball, FirePoint.position, FirePoint.rotation);
        PlayerPrefs.SetInt("BallsShot", PlayerPrefs.GetInt("BallsShot") + 1);
    }

    
}


