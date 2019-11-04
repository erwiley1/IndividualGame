using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class CannonShoot : MonoBehaviour
{
    public GameObject Ball;
    public Vector3 bulletOffset = new Vector3(0, 1f, 0);
    float rotatespeed = 100f;
    public AudioSource CannonShot;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CannonShot.Play();
            Vector3 offset = transform.rotation * bulletOffset;
            GameObject ball = Instantiate(Ball, transform.position + offset, transform.rotation);
        }

         Quaternion cannonRot = transform.rotation;

    float z = cannonRot.eulerAngles.z;

    z -= Input.GetAxis("Horizontal") * rotatespeed * Time.deltaTime;

    cannonRot = Quaternion.Euler(0, 0, z);

    transform.rotation = cannonRot;

    }
}
