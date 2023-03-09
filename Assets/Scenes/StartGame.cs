using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour

{
public Button Startbutton;
    void Start()
    {
        Startbutton.onClick.AddListener(StartGameOnClick);
    }

    // Update is called once per frame
    void StartGameOnClick()
    {
        SceneManager.LoadScene("Yuen Kei Wun");
    }
}
