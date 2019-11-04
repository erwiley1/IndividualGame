using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class RestartGame : MonoBehaviour
{
    public Button Restart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartGameFromStart()
    {
        SceneManager.LoadScene("_Scene_0");
    }
}
