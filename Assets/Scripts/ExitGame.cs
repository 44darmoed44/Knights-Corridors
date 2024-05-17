using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void OnClick()
    {
        Application.Quit();
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
