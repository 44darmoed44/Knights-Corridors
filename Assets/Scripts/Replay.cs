using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
    public AudioSource music;

    private void Start()
    {
        music.time = PlayerPrefs.GetFloat("music");
    }

    public void ToGame()
    {
        PlayerPrefs.SetFloat("music", music.time);
        SceneManager.LoadScene(1);
    }
    public void ToRandom()
    {
        PlayerPrefs.SetFloat("music", music.time);
        SceneManager.LoadScene(1);
    }
    public void ToMainMenu()
    {
        PlayerPrefs.SetFloat("music", music.time);
        SceneManager.LoadScene(0);
    }

    public void ToRules()
    {
        PlayerPrefs.SetFloat("music", music.time);
        SceneManager.LoadScene(5);
    }

    private void OnApplicationPause(bool pause)
    {
        PlayerPrefs.SetFloat("music", 0);
    }

}
