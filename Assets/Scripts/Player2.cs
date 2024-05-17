using UnityEngine;

public class Player2 : MonoBehaviour
{

    [Header("Player")]
    [SerializeField] public string indexPlayer;

    public GameObject n_cell;
    public GameObject[] allCells;

    public GameObject startCell;

    private bool cn;
    private int _indexOfCell;

    public string condition;
    public string condition_;

    private void Start()
    {
        allCells = n_cell.GetComponent<AllCells>().allCells;
        transform.position = startCell.transform.position;
    }

    public void OnClick(GameObject cell, int indexOfCell)
    {
        if (cell.GetComponent<callBild>().conditionPlayerWalk == "Yes")
        {
            if (condition_.Contains(indexPlayer))
            {
                transform.position = new Vector3(cell.transform.position.x, cell.transform.position.y, cell.transform.position.z);
                condition = indexOfCell.ToString();
                foreach (var cell_ in allCells)
                {
                    cell_.GetComponent<callBild>().conditionPlayerWalk = "No";
                }
                if (condition_.Contains("FirstWalk"))
                {
                    PlayerPrefs.SetString("condition", "playerSecondBuild");
                }
                else
                {
                    PlayerPrefs.SetString("condition", "playerFirstBuild");
                }
                GetComponent<AudioSource>().Play();
            }
        }
    }

    private bool ChekingLogicCell(string cellTag, string cellNextTag, bool right = false, bool left = false, bool top = false, bool bottom = false)
    {

        bool rightDirection = false;

        if (right)
        {
            if (cellTag.Contains("Four"))
            {
                if (cellNextTag.Contains("Four"))
                {
                    rightDirection = true;
                }
                else if (cellNextTag.Contains("Three"))
                {
                    if (!cellNextTag.Contains("Right"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Two"))
                {
                    if (!cellNextTag.Contains("Right") && !cellNextTag.Contains("Down"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("One"))
                {
                    if (cellNextTag.Contains("Left"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Double"))
                {
                    if (cellNextTag.Contains("Right"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Finish"))
                {
                    rightDirection = true;
                }
            }
            else if (cellTag.Contains("Three") && !cellTag.Contains("Left"))
            {
                if (cellNextTag.Contains("Four"))
                {
                    rightDirection = true;
                }
                else if (cellNextTag.Contains("Three"))
                {
                    if (!cellNextTag.Contains("Right"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Two"))
                {
                    if (!cellNextTag.Contains("Right") && !cellNextTag.Contains("Down"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("One"))
                {
                    if (cellNextTag.Contains("Left"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Double"))
                {
                    if (cellNextTag.Contains("Right"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Finish"))
                {
                    rightDirection = true;
                }
            }
            else if (cellTag.Contains("Two") && (!cellTag.Contains("Up") && !cellTag.Contains("Left")))
            {
                if (cellNextTag.Contains("Four"))
                {
                    rightDirection = true;
                }
                else if (cellNextTag.Contains("Three"))
                {
                    if (!cellNextTag.Contains("Right"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Two"))
                {
                    if (!cellNextTag.Contains("Right") && !cellNextTag.Contains("Down"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("One"))
                {
                    if (cellNextTag.Contains("Left"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Double"))
                {
                    if (cellNextTag.Contains("Right"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Finish"))
                {
                    rightDirection = true;
                }
            }
            else if (cellTag.Contains("One") && cellTag.Contains("Right"))
            {
                if (cellNextTag.Contains("Four"))
                {
                    rightDirection = true;
                }
                else if (cellNextTag.Contains("Three"))
                {
                    if (!cellNextTag.Contains("Right"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Two"))
                {
                    if (!cellNextTag.Contains("Right") && !cellNextTag.Contains("Down"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("One"))
                {
                    if (cellNextTag.Contains("Left"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Double"))
                {
                    if (cellNextTag.Contains("Right"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Finish"))
                {
                    rightDirection = true;
                }
            }
            else if (cellTag.Contains("Double") && cellTag.Contains("Right"))
            {
                if (cellNextTag.Contains("Four"))
                {
                    rightDirection = true;
                }
                else if (cellNextTag.Contains("Three"))
                {
                    if (!cellNextTag.Contains("Right"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Two"))
                {
                    if (!cellNextTag.Contains("Right") && !cellNextTag.Contains("Down"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("One"))
                {
                    if (cellNextTag.Contains("Left"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Double"))
                {
                    if (cellNextTag.Contains("Right"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Finish"))
                {
                    rightDirection = true;
                }
            }
        }
        if (left)
        {
            if (cellTag.Contains("Four"))
            {
                if (cellNextTag.Contains("Four"))
                {
                    rightDirection = true;
                }
                else if (cellNextTag.Contains("Three"))
                {
                    if (!cellNextTag.Contains("Left"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Two"))
                {
                    if (!cellNextTag.Contains("Left") && !cellNextTag.Contains("Up"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("One"))
                {
                    if (cellNextTag.Contains("Right"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Double"))
                {
                    if (cellNextTag.Contains("Right"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Finish"))
                {
                    rightDirection = true;
                }
            }
            else if (cellTag.Contains("Three") && !cellTag.Contains("Right"))
            {
                if (cellNextTag.Contains("Four"))
                {
                    rightDirection = true;
                }
                else if (cellNextTag.Contains("Three"))
                {
                    if (!cellNextTag.Contains("Left"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Two"))
                {
                    if (!cellNextTag.Contains("Left") && !cellNextTag.Contains("Up"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("One"))
                {
                    if (cellNextTag.Contains("Right"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Double"))
                {
                    if (cellNextTag.Contains("Right"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Finish"))
                {
                    rightDirection = true;
                }
            }
            else if (cellTag.Contains("Two") && !cellTag.Contains("Down") && !cellTag.Contains("Right"))
            {
                if (cellNextTag.Contains("Four"))
                {
                    rightDirection = true;
                }
                else if (cellNextTag.Contains("Three"))
                {
                    if (!cellNextTag.Contains("Left"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Two"))
                {
                    if (!cellNextTag.Contains("Left") && !cellNextTag.Contains("Up"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("One"))
                {
                    if (cellNextTag.Contains("Right"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Double"))
                {
                    if (cellNextTag.Contains("Right"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Finish"))
                {
                    rightDirection = true;
                }
            }
            else if (cellTag.Contains("One") && cellTag.Contains("Left"))
            {
                if (cellNextTag.Contains("Four"))
                {
                    rightDirection = true;
                }
                else if (cellNextTag.Contains("Three"))
                {
                    if (!cellNextTag.Contains("Left"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Two"))
                {
                    if (!cellNextTag.Contains("Left") && !cellNextTag.Contains("Up"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("One"))
                {
                    if (cellNextTag.Contains("Right"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Double"))
                {
                    if (cellNextTag.Contains("Right"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Finish"))
                {
                    rightDirection = true;
                }
            }
            else if (cellTag.Contains("Double") && cellTag.Contains("Right"))
            {
                if (cellNextTag.Contains("Four"))
                {
                    rightDirection = true;
                }
                else if (cellNextTag.Contains("Three"))
                {
                    if (!cellNextTag.Contains("Left"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Two"))
                {
                    if (!cellNextTag.Contains("Left") && !cellNextTag.Contains("Up"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("One"))
                {
                    if (cellNextTag.Contains("Right"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Double"))
                {
                    if (cellNextTag.Contains("Right"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Finish"))
                {
                    rightDirection = true;
                }
            }
        }
        if (top)
        {
            if (cellTag.Contains("Four"))
            {
                if (cellNextTag.Contains("Four"))
                {
                    rightDirection = true;
                }
                else if (cellNextTag.Contains("Three"))
                {
                    if (!cellNextTag.Contains("Up"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Two"))
                {
                    if (!cellNextTag.Contains("Right") && !cellNextTag.Contains("Up"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("One"))
                {
                    if (cellNextTag.Contains("Down"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Double"))
                {
                    if (cellNextTag.Contains("Down"))
                    {
                        rightDirection = true;
                    }
                }
            }
            else if (cellTag.Contains("Three") && !cellTag.Contains("Down"))
            {
                if (cellNextTag.Contains("Four"))
                {
                    rightDirection = true;
                }
                else if (cellNextTag.Contains("Three"))
                {
                    if (!cellNextTag.Contains("Up"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Two"))
                {
                    if (!cellNextTag.Contains("Right") && !cellNextTag.Contains("Up"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("One"))
                {
                    if (cellNextTag.Contains("Down"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Double"))
                {
                    if (cellNextTag.Contains("Down"))
                    {
                        rightDirection = true;
                    }
                }
            }
            else if (cellTag.Contains("Two") && (!cellTag.Contains("Down") && !cellTag.Contains("Left")))
            {
                if (cellNextTag.Contains("Four"))
                {
                    rightDirection = true;
                }
                else if (cellNextTag.Contains("Three"))
                {
                    if (!cellNextTag.Contains("Up"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Two"))
                {
                    if (!cellNextTag.Contains("Right") && !cellNextTag.Contains("Up"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("One"))
                {
                    if (cellNextTag.Contains("Down"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Double"))
                {
                    if (cellNextTag.Contains("Down"))
                    {
                        rightDirection = true;
                    }
                }
            }
            else if (cellTag.Contains("One") && cellTag.Contains("Up"))
            {
                if (cellNextTag.Contains("Four"))
                {
                    rightDirection = true;
                }
                else if (cellNextTag.Contains("Three"))
                {
                    if (!cellNextTag.Contains("Up"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Two"))
                {
                    if (!cellNextTag.Contains("Right") && !cellNextTag.Contains("Up"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("One"))
                {
                    if (cellNextTag.Contains("Down"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Double"))
                {
                    if (cellNextTag.Contains("Down"))
                    {
                        rightDirection = true;
                    }
                }
            }
            else if (cellTag.Contains("Double") && cellTag.Contains("Down"))
            {
                if (cellNextTag.Contains("Four"))
                {
                    rightDirection = true;
                }
                else if (cellNextTag.Contains("Three"))
                {
                    if (!cellNextTag.Contains("Up"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Two"))
                {
                    if (!cellNextTag.Contains("Right") && !cellNextTag.Contains("Up"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("One"))
                {
                    if (cellNextTag.Contains("Down"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Double"))
                {
                    if (cellNextTag.Contains("Down"))
                    {
                        rightDirection = true;
                    }
                }
            }
        }
        if (bottom)
        {
            if (cellTag.Contains("Four"))
            {
                if (cellNextTag.Contains("Four"))
                {
                    rightDirection = true;
                }
                else if (cellNextTag.Contains("Three"))
                {
                    if (!cellNextTag.Contains("Down"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Two"))
                {
                    if (!cellNextTag.Contains("Down") && !cellNextTag.Contains("Left"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("One"))
                {
                    if (cellNextTag.Contains("Up"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Double"))
                {
                    if (cellNextTag.Contains("Down"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Finish"))
                {
                    rightDirection = true;
                }
            }
            else if (cellTag.Contains("Three") && !cellTag.Contains("Up"))
            {
                if (cellNextTag.Contains("Four"))
                {
                    rightDirection = true;
                }
                else if (cellNextTag.Contains("Three"))
                {
                    if (!cellNextTag.Contains("Down"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Two"))
                {
                    if (!cellNextTag.Contains("Down") && !cellNextTag.Contains("Left"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("One"))
                {
                    if (cellNextTag.Contains("Up"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Double"))
                {
                    if (cellNextTag.Contains("Down"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Finish"))
                {
                    rightDirection = true;
                }
            }
            else if (cellTag.Contains("Two") && (!cellTag.Contains("Up") && !cellTag.Contains("Right")))
            {
                if (cellNextTag.Contains("Four"))
                {
                    rightDirection = true;
                }
                else if (cellNextTag.Contains("Three"))
                {
                    if (!cellNextTag.Contains("Down"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Two"))
                {
                    if (!cellNextTag.Contains("Down") && !cellNextTag.Contains("Left"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("One"))
                {
                    if (cellNextTag.Contains("Up"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Double"))
                {
                    if (cellNextTag.Contains("Down"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Finish"))
                {
                    rightDirection = true;
                }
            }
            else if (cellTag.Contains("One") && cellTag.Contains("Down"))
            {
                if (cellNextTag.Contains("Four"))
                {
                    rightDirection = true;
                }
                else if (cellNextTag.Contains("Three"))
                {
                    if (!cellNextTag.Contains("Down"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Two"))
                {
                    if (!cellNextTag.Contains("Down") && !cellNextTag.Contains("Left"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("One"))
                {
                    if (cellNextTag.Contains("Up"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Double"))
                {
                    if (cellNextTag.Contains("Down"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Finish"))
                {
                    rightDirection = true;
                }
            }
            else if (cellTag.Contains("Double") && cellTag.Contains("Down"))
            {
                if (cellNextTag.Contains("Four"))
                {
                    rightDirection = true;
                }
                else if (cellNextTag.Contains("Three"))
                {
                    if (!cellNextTag.Contains("Down"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Two"))
                {
                    if (!cellNextTag.Contains("Down") && !cellNextTag.Contains("Left"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("One"))
                {
                    if (cellNextTag.Contains("Up"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Double"))
                {
                    if (cellNextTag.Contains("Down"))
                    {
                        rightDirection = true;
                    }
                }
                else if (cellNextTag.Contains("Finish"))
                {
                    rightDirection = true;
                }
            }
        }

        return rightDirection;

    }

    public void CheckingCellAround(GameObject cellChild)
    {
        if (cellChild.GetComponent<callBild>().btn.interactable)
        {
            GameObject cellRight;
            GameObject cellLeft;
            GameObject cellTop;
            GameObject cellBottom;
            bool cellRightBool;
            bool cellLeftBool;
            bool cellTopBool;
            bool cellBottomBool;
            int indexOfCell = int.Parse(cellChild.GetComponent<callBild>().indexOfCell);
            if (indexOfCell != 8 && indexOfCell != 17 && indexOfCell != 26 && indexOfCell != 35 && indexOfCell != 44 && indexOfCell != 53)
            {
                cellRight = allCells[indexOfCell + 1];
                cellRightBool = ChekingLogicCell(cellChild.tag, cellRight.tag, true);
                if (cellRight.GetComponent<callBild>().btn.interactable && cellRightBool)
                    cellRight.GetComponent<callBild>().conditionPlayerWalk = "Yes";
            }
            if (indexOfCell % 9 != 0)
            {
                cellLeft = allCells[indexOfCell - 1];
                cellLeftBool = ChekingLogicCell(cellChild.tag, cellLeft.tag, false, true);
                if (cellLeft.GetComponent<callBild>().btn.interactable && cellLeftBool)
                    cellLeft.GetComponent<callBild>().conditionPlayerWalk = "Yes";
            }
            if (indexOfCell > 8)
            {
                cellTop = allCells[indexOfCell - 9];
                cellTopBool = ChekingLogicCell(cellChild.tag, cellTop.tag, false, false, true);
                if (cellTop.GetComponent<callBild>().btn.interactable && cellTopBool)
                    cellTop.GetComponent<callBild>().conditionPlayerWalk = "Yes";
            }
            if (indexOfCell < 45)
            {
                cellBottom = allCells[indexOfCell + 9];
                cellBottomBool = ChekingLogicCell(cellChild.tag, cellBottom.tag, false, false, false, true);
                if (cellBottom.GetComponent<callBild>().btn.interactable && cellBottomBool)
                    cellBottom.GetComponent<callBild>().conditionPlayerWalk = "Yes";
            }
        }
        cellChild.GetComponent<callBild>().conditionPlayerWalk = "No";
    }

    private void CheckingCell()
    {
        foreach(var cell in allCells)
        {
            _indexOfCell = int.Parse(cell.GetComponent<callBild>().indexOfCell);
            GameObject cellChild = allCells[_indexOfCell];

            cellChild.GetComponent<callBild>().btn.onClick.AddListener(delegate { OnClick(cellChild, int.Parse(cellChild.GetComponent<callBild>().indexOfCell)); });
        }
    }


    private void FixedUpdate()
    {
        cn = PlayerPrefs.GetString("condition").Contains(indexPlayer);
        condition_ = PlayerPrefs.GetString("condition");


        if (cn)
        {

            CheckingCell();

            if (condition == "startCell")
            {
                if (condition_.Contains(indexPlayer))
                {
                    allCells[17].GetComponent<callBild>().conditionPlayerWalk = "Yes";
                }
            }
            else
            {
                GameObject cellChild = allCells[int.Parse(condition)];

                CheckingCellAround(cellChild);
            }

            foreach (var cell in allCells)
            {

                if (cell.GetComponent<callBild>().conditionPlayerWalk == "Yes")
                {
                    cell.GetComponentInChildren<SpriteRenderer>().color = new Color(0, 255, 0);
                }
                else
                {
                    cell.GetComponentInChildren<SpriteRenderer>().color = new Color(255, 255, 255);
                }

                if (cell.CompareTag("Green"))
                {
                    cell.tag = "Default";
                }

            }
        }

    }

}
