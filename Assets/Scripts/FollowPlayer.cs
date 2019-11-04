using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class FollowPlayer : MonoBehaviour
{

    public GameObject Cannon;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Cannon.transform.position;
        
    }

    // Update is called once per frame
    void lateUpdate()
    {
        if (Cannon.transform.position.y > -8f)
        {
            transform.position = Cannon.transform.position + 0.2f * offset;
        }
    }
}
