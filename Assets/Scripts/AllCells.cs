using UnityEngine;

public class AllCells : MonoBehaviour
{
    [Header("List of cell")]
    [SerializeField] public GameObject[] allCells;
    [SerializeField] private GameObject none;

    public int indexCell;
    public int indexCellRotate;

    public string TagCorridor;

    private void Start()
    {

        int i = 0;
        foreach (var cell in allCells)
        {
            cell.GetComponent<callBild>().indexOfCell = i.ToString();
            cell.tag = "Default";

            if (i == 9)
            {
                cell.tag = "FirstOfFirst";
                var association = cell.GetComponent<callBild>().association;
                association.Add("FourCorridor");
                association.Add("OneCorridorLeft");
                association.Add("TwoCorridorLeft");
                association.Add("TwoCorridorUp");
                association.Add("ThreeCorridorDown");
                association.Add("ThreeCorridorUp");
                association.Add("ThreeCorridorLeft");
                association.Add("DoubleCorridorsRight");
            }
            else if (i == 17)
            {
                cell.tag = "FirstOfSecond";
                var association = cell.GetComponent<callBild>().association;
                association.Add("FourCorridor");
                association.Add("OneCorridorRight");
                association.Add("TwoCorridorRight");
                association.Add("TwoCorridorDown");
                association.Add("ThreeCorridorDown");
                association.Add("ThreeCorridorUp");
                association.Add("ThreeCorridorRight");
                association.Add("DoubleCorridorsRight");
            }
            else if (i == 49)
            {
                cell.tag = "Finish";
            }

            i++;
        }
    }

    private void CheckingCell()
    {
        GameObject cellChild;

        foreach (var cell in allCells)
        {
            int indexOfCell = int.Parse(cell.GetComponent<callBild>().indexOfCell);
            bool interectable = cell.GetComponent<callBild>().interectable;

            if (!interectable)
            {
                cellChild = allCells[indexOfCell];

                cellChild.GetComponentInChildren<SpriteRenderer>().color = new Color(255, 255, 255);

                indexCell = PlayerPrefs.GetInt("indexCell");
                indexCellRotate = PlayerPrefs.GetInt("indexCellRotate");

                if (cellChild.tag == "Default" || cellChild.tag == "Green" || cell.tag.Contains("First"))
                {
                    cellChild.tag = "IsBuild";

                    switch (indexCell)
                    {
                    case 0:
                        cellChild.tag = "OneCorridor";
                        switch (indexCellRotate)
                        {
                            case 0:
                                cellChild.tag += "Down";
                                break;
                            case 1:
                                cellChild.tag += "Right";
                                break;
                            case 2:
                                cellChild.tag += "Up";
                                break;
                            case 3:
                                cellChild.tag += "Left";
                                break;
                        }
                            cellChild.tag += "IsBuild";
                            break;
                        case 1:
                            cellChild.tag = "TwoCorridor";
                            switch (indexCellRotate)
                            {
                                case 0:
                                    cellChild.tag += "Down";
                                    break;
                                case 1:
                                    cellChild.tag += "Right";
                                    break;
                                case 2:
                                    cellChild.tag += "Up";
                                    break;
                                case 3:
                                    cellChild.tag += "Left";
                                    break;
                            }
                            cellChild.tag += "IsBuild";
                            break;
                        case 2:
                            cellChild.tag = "ThreeCorridor";
                            switch (indexCellRotate)
                            {
                                case 0:
                                    cellChild.tag += "Down";
                                    break;
                                case 1:
                                    cellChild.tag += "Right";
                                    break;
                                case 2:
                                    cellChild.tag += "Up";
                                    break;
                                case 3:
                                    cellChild.tag += "Left";
                                    break;
                            }
                            cellChild.tag += "IsBuild";
                            break;
                        case 3:
                            cellChild.tag = "FourCorridorIsBuild";
                            break;
                        case 4:
                            switch(indexCellRotate)
                            {
                                case 0:
                                    cellChild.tag = "DoubleCorridorsDownIsBuild";
                                    break;
                                case 1:
                                    cellChild.tag = "DoubleCorridorsRightIsBuild";
                                    break;
                            }
                            break;
                    }
                }
            }
        }
    }

    public void CheckingAround()
    {
        foreach(var cell in allCells)
        {
            bool interectable = cell.GetComponent<callBild>().interectable;

            if (!interectable)
            {
                if (cell.tag == "Green")
                {
                    cell.GetComponentInChildren<SpriteRenderer>().color = new Color(255, 255, 255);
                }
            }

            CheckingCell();
            if(!cell.tag.Contains("IsBuild"))
                none.GetComponent<Association>().Associations();
        }
        PlayerPrefs.SetInt("changeCorridor2", 1);
    }
}
