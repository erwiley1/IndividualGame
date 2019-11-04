using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene4Management : MonoBehaviour
{
    //varialbes for text and cannons
    public GameObject Cannon;
    public Text tellPlayer;
    int numberCannons = 0;
    public bool CannonPlaced = false;
    public int BasketsCollected = 0;


    // Update is called once per frame
    void Update()
    {
        //if the left mouse is down, spawn a cannon
        if (Input.GetMouseButtonDown(0) && CannonPlaced == false)
        {


            Vector2 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject newCannon = Instantiate(Cannon);
            newCannon.transform.position = new Vector2(newPosition.x, -4);
            Debug.Log("Cannon placed");



            CannonPlaced = true;
            if (numberCannons == 0)
            {
                tellPlayer.text = "Place your cannon! Shoot for the hoop!";
            }
            else if (numberCannons == 5)
            {

                tellPlayer.text = "You can shoot with space and rotate with arrow keys! Keep going for a surprise!";

            }
            else if (numberCannons == 11)
            {
                SceneManager.LoadScene("_Scene_2");
            }

        }

        if (Input.GetMouseButtonDown(1))
        {
            CannonPlaced = false;
        }

        if (BasketsCollected == 1)
        {
            StartCoroutine(WaitToLoad());
        }
    }
    //tried attempt to restart to the first scene, does not work for some reason


    public IEnumerator WaitToLoad()
    {

        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("_Scene_5");
    }


}