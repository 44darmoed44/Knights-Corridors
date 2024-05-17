using UnityEngine;
using System.Collections;

public class ChekingCell : MonoBehaviour
{
    public GameObject changeButton1;
    public GameObject changeButton2;
    public GameObject none;

    private string tagButton1;
    private string tagButton2;
    private string oldTag;
    private GameObject[] allCells;
    private ArrayList association;

    private string condition;
    public int FirstPlayer;

    void Start()
    {
        allCells = none.GetComponent<AllCells>().allCells;
    }

    void Update()
    {
        condition = PlayerPrefs.GetString("condition");
        FirstPlayer = PlayerPrefs.GetInt("FirstPlayer");

        tagButton1 = changeButton1.tag;
        tagButton2 = changeButton2.tag;

        foreach (var cell in allCells)
        {
            oldTag = cell.tag;

            association = cell.GetComponent<callBild>().association;

            if (FirstPlayer == 1)
            {
                if(condition.Contains("FirstBuild"))
                {
                    if (association.Contains(tagButton1) && !cell.tag.Contains("IsBuild") && !cell.tag.Contains("Finish"))
                    {
                        cell.tag = "Green";
                        cell.GetComponentInChildren<SpriteRenderer>().color = new Color(0, 255, 0);
                    }
                    else
                    {
                        cell.GetComponentInChildren<SpriteRenderer>().color = new Color(255, 255, 255);
                        if (oldTag == "Green")
                        {
                            cell.tag = "Default";
                            cell.GetComponentInChildren<SpriteRenderer>().color = new Color(255, 255, 255);
                        }
                        if (cell.GetComponent<callBild>().indexOfCell == "9" && condition.Contains("FirstWalk"))
                        {
                            cell.tag = "FirstOfFirst";
                            cell.GetComponentInChildren<SpriteRenderer>().color = new Color(255, 255, 255);
                        }
                    }
                }
                else if (condition.Contains("SecondBuild"))
                {
                    if (association.Contains(tagButton2) && !cell.tag.Contains("IsBuild") && !cell.tag.Contains("Finish"))
                    {
                        cell.tag = "Green";
                        cell.GetComponentInChildren<SpriteRenderer>().color = new Color(0, 255, 0);
                    }
                    else
                    {
                        cell.GetComponentInChildren<SpriteRenderer>().color = new Color(255, 255, 255);
                        if (oldTag == "Green")
                        {
                            cell.tag = "Default";
                            cell.GetComponentInChildren<SpriteRenderer>().color = new Color(255, 255, 255);
                        }
                        else if (cell.GetComponent<callBild>().indexOfCell == "17" && condition.Contains("SecondWalk"))
                        {
                            cell.tag = "FirstOfSecond";
                            cell.GetComponentInChildren<SpriteRenderer>().color = new Color(255, 255, 255);
                        }
                    }
                }
            }
            else
            {

                if (condition.Contains("FirstBuild"))
                {
                    if (association.Contains(tagButton2) && !cell.tag.Contains("IsBuild") && !cell.tag.Contains("Finish"))
                    {
                        cell.tag = "Green";
                        cell.GetComponentInChildren<SpriteRenderer>().color = new Color(0, 255, 0);
                    }
                    else
                    {
                        cell.GetComponentInChildren<SpriteRenderer>().color = new Color(255, 255, 255);
                        if (oldTag == "Green")
                        {
                            cell.tag = "Default";
                            cell.GetComponentInChildren<SpriteRenderer>().color = new Color(255, 255, 255);
                        }
                        else if (cell.GetComponent<callBild>().indexOfCell == "17" && condition.Contains("SecondWalk"))
                        {
                            cell.tag = "FirstOfSecond";
                            cell.GetComponentInChildren<SpriteRenderer>().color = new Color(255, 255, 255);
                        }
                    }
                }
                else if (condition.Contains("SecondBuild"))
                {
                    if (association.Contains(tagButton1) && !cell.tag.Contains("IsBuild") && !cell.tag.Contains("Finish"))
                    {
                        cell.tag = "Green";
                        cell.GetComponentInChildren<SpriteRenderer>().color = new Color(0, 255, 0);
                    }
                    else
                    {
                        cell.GetComponentInChildren<SpriteRenderer>().color = new Color(255, 255, 255);
                        if (oldTag == "Green")
                        {
                            cell.tag = "Default";
                            cell.GetComponentInChildren<SpriteRenderer>().color = new Color(255, 255, 255);
                        }
                        if (cell.GetComponent<callBild>().indexOfCell == "9" && condition.Contains("FirstWalk"))
                        {
                            cell.tag = "FirstOfFirst";
                            cell.GetComponentInChildren<SpriteRenderer>().color = new Color(255, 255, 255);
                        }
                    }
                }
            }
        }
    }
}
