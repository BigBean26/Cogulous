using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class I_UI : MonoBehaviour
{
    public void QuitGame(){
        Debug.Log("Quit");
        Application.Quit();
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Main_Menu", LoadSceneMode.Single);
    }
}
