using UnityEngine;
using UnityEngine.SceneManagement;

public class MainGame : MonoBehaviour
{

    public string condition;

    public int FirstPlayer;

    public GameObject n_cell;
    public GameObject[] allCells;

    public GameObject Player1;
    public GameObject Player2;
    public GameObject ChangerSprite1;
    public GameObject ChangerSprite2;
    public GameObject finishCell;

    private void Start()
    {
        PlayerPrefs.SetString("condition", "playerFirstBuild");
        allCells = n_cell.GetComponent<AllCells>().allCells;
    }

    void Update()
    {
        condition = PlayerPrefs.GetString("condition");
        FirstPlayer = PlayerPrefs.GetInt("FirstPlayer");

        if (FirstPlayer == 1)
        {
            ChangerSprite1.GetComponent<changeSprite>().indexOfCell = "FirstBuild";
            ChangerSprite2.GetComponent<changeSprite>().indexOfCell = "SecondBuild";
            Player1.GetComponent<Player1>().indexPlayer = "FirstWalk";
            Player2.GetComponent<Player2>().indexPlayer = "SecondWalk";
        }
        else
        {
            ChangerSprite1.GetComponent<changeSprite>().indexOfCell = "SecondBuild";
            ChangerSprite2.GetComponent<changeSprite>().indexOfCell = "FirstBuild";
            Player1.GetComponent<Player1>().indexPlayer = "SecondWalk";
            Player2.GetComponent<Player2>().indexPlayer = "FirstWalk";
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKey("l"))
        {
            condition = "playerFirstBuild";
        }
        if (Input.GetKey("k"))
        {
            condition = "playerFirstWalk";
        }

        if (condition.Contains("Walk"))
        {
            foreach (var cell in allCells)
            {
                string cellTag = cell.tag;

                if (cellTag.Contains("Is") || cellTag.Contains("Finish"))
                {
                    cell.GetComponent<callBild>().btn.interactable = true;
                }
                else
                {
                    cell.GetComponent<callBild>().btn.interactable = false;
                }
            }
        }
        else
        {
            foreach (var cell in allCells)
            {
                string cellTag = cell.tag;

                if (cellTag != "Finish")
                {
                    if (cellTag.Contains("Is"))
                    {
                        cell.GetComponent<callBild>().btn.interactable = false;
                    }
                    else
                    {
                        cell.GetComponent<callBild>().btn.interactable = true;
                    }
                }
            }
        }

        if (Player1.transform.position == finishCell.transform.position)
        {
            SceneManager.LoadScene(3);
        }
        if (Player2.transform.position == finishCell.transform.position)
        {
            SceneManager.LoadScene(4);
        }

        PlayerPrefs.SetString("condition", condition);
    }
}
