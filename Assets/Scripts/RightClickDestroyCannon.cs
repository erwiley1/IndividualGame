using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightClickDestroyCannon : MonoBehaviour
{
   

    // Update is called once per frame, if you press right click it gets rid of the cannon through the tag
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (gameObject.tag == "Cannon")
            {
              
                Debug.Log("Cannon destroyed");
                Destroy(gameObject);


            }
        }
    }
}

