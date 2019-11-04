using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagement : MonoBehaviour
{
    public static AudioClip CannonSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        CannonSound = Resources.Load<AudioClip>("CannonShoot");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {


    }
}
