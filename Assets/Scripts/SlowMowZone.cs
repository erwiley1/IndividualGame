using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMowZone : MonoBehaviour
{
    public Camera MainCamera;
    public Camera HoopCam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)

    {

        MainCamera.gameObject.SetActive(false);
        HoopCam.gameObject.SetActive(true);
        Time.timeScale = 0.075f;



    }

    void OnTriggerExit2D(Collider2D collider)
    {
        MainCamera.gameObject.SetActive(true);
        HoopCam.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

}
