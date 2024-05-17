using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    public Button btn;
    public string condition;

    public int i = -1;

    public GameObject cellFinish;

    void Update()
    {
        condition = PlayerPrefs.GetString("condition");

        if (condition.Contains("Build"))
        {
            btn.interactable = false;
        }
        else
        {
            btn.interactable = true;
        }
          
        tag = "Finish";

    }
}
