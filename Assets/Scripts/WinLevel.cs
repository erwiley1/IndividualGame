using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinLevel : MonoBehaviour
{
    public Scene1Manage SceneRuler;
    public Camera MainCamera;
    public AudioSource WinSound;
    public ParticleSystem WinParticles;
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<ParticleSystem>().enabled = false;
        WinParticles.Stop();
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        SceneRuler.BasketsCollected++;
        MainCamera.gameObject.SetActive(true);
        Time.timeScale = 1f;
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;
        WinSound.Play();
        WinParticles.Play();
        //make particles move fast
        //GetComponent<ParticleSystem>().enabled = true;
        Destroy(gameObject, 3f);
    }
}