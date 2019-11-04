using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{

    public Button Begin;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("BallsShot", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameFromStart()
    {
        SceneManager.LoadScene("_Scene_1");
    }
}
