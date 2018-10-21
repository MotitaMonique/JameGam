using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

    //loads the dang game
    public void LoadGame()
    {
        SceneManager.LoadScene("MainGame");
    }
}
