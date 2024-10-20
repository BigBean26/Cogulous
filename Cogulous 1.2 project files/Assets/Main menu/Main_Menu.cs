using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("Main_Game", LoadSceneMode.Single);
    }
    [SerializeField] private AudioMixer mymixer;
    [SerializeField] private Slider musicSlider;

    public void SetMusicVolume()
    {
        float volume = musicSlider.value;
        mymixer.SetFloat("music", volume);
    }
}
