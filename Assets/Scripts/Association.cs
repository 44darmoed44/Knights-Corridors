using UnityEngine;

public class Association : MonoBehaviour
{
    public GameObject n;

    private GameObject[] allCells;

    private void Start()
    {
        allCells = n.GetComponent<AllCells>().allCells;
    }

    public void Associations()
    {
        GameObject cellChild;
        GameObject cellRight;
        GameObject cellLeft;
        GameObject cellTop;
        GameObject cellBottom;

        foreach (var cell in allCells)
        {
            int indexOfCell = int.Parse(cell.GetComponent<callBild>().indexOfCell);
            bool interecatble = cell.GetComponent<callBild>().interectable;

            if (!interecatble)
            {
                cellChild = allCells[indexOfCell];
                string cellTag = cellChild.tag;

                if (indexOfCell != 8 && indexOfCell != 17 && indexOfCell != 26 && indexOfCell != 35 && indexOfCell != 44 && indexOfCell != 53)
                {
                    cellRight = allCells[indexOfCell + 1];
                    var associationRight = cellRight.GetComponent<callBild>().association;
                    if (cellTag.Contains("Four"))
                    {
                        associationRight.Add("FourCorridor");
                        associationRight.Add("OneCorridorLeft");
                        associationRight.Add("TwoCorridorLeft");
                        associationRight.Add("TwoCorridorUp");
                        associationRight.Add("ThreeCorridorDown");
                        associationRight.Add("ThreeCorridorUp");
                        associationRight.Add("ThreeCorridorLeft");
                        associationRight.Add("DoubleCorridorsRight");
                    }
                    else if (cellTag.Contains("One") && cellTag.Contains("Right"))
                    {
                        associationRight.Add("FourCorridor");
                        associationRight.Add("OneCorridorLeft");
                        associationRight.Add("TwoCorridorLeft");
                        associationRight.Add("TwoCorridorUp");
                        associationRight.Add("ThreeCorridorDown");
                        associationRight.Add("ThreeCorridorUp");
                        associationRight.Add("ThreeCorridorLeft");
                        associationRight.Add("DoubleCorridorsRight");
                    }
                    else if (cellTag.Contains("Two") && (cellTag.Contains("Down") || cellTag.Contains("Right")))
                    {
                        associationRight.Add("FourCorridor");
                        associationRight.Add("OneCorridorLeft");
                        associationRight.Add("TwoCorridorLeft");
                        associationRight.Add("TwoCorridorUp");
                        associationRight.Add("ThreeCorridorDown");
                        associationRight.Add("ThreeCorridorUp");
                        associationRight.Add("ThreeCorridorLeft");
                        associationRight.Add("DoubleCorridorsRight");
                    }
                    else if (cellTag.Contains("Three") && (cellTag.Contains("Down") || cellTag.Contains("Right") || cellTag.Contains("Up")))
                    {
                        associationRight.Add("FourCorridor");
                        associationRight.Add("OneCorridorLeft");
                        associationRight.Add("TwoCorridorLeft");
                        associationRight.Add("TwoCorridorUp");
                        associationRight.Add("ThreeCorridorDown");
                        associationRight.Add("ThreeCorridorUp");
                        associationRight.Add("ThreeCorridorLeft");
                        associationRight.Add("DoubleCorridorsRight");
                    }
                    else if (cellTag.Contains("Double") && cellTag.Contains("Right"))
                    {
                        associationRight.Add("FourCorridor");
                        associationRight.Add("OneCorridorLeft");
                        associationRight.Add("TwoCorridorLeft");
                        associationRight.Add("TwoCorridorUp");
                        associationRight.Add("ThreeCorridorDown");
                        associationRight.Add("ThreeCorridorUp");
                        associationRight.Add("ThreeCorridorLeft");
                        associationRight.Add("DoubleCorridorsRight");
                    }
                }
                if (indexOfCell % 9 != 0)
                {
                    cellLeft = allCells[indexOfCell - 1];
                    var associationLeft = cellLeft.GetComponent<callBild>().association;
                    if (cellTag.Contains("Four"))
                    {
                        associationLeft.Add("FourCorridor");
                        associationLeft.Add("OneCorridorRight");
                        associationLeft.Add("TwoCorridorDown");
                        associationLeft.Add("TwoCorridorRight");
                        associationLeft.Add("ThreeCorridorDown");
                        associationLeft.Add("ThreeCorridorUp");
                        associationLeft.Add("ThreeCorridorRight");
                        associationLeft.Add("DoubleCorridorsRight");
                    }
                    else if (cellTag.Contains("One") && cellTag.Contains("Left"))
                    {
                        associationLeft.Add("FourCorridor");
                        associationLeft.Add("OneCorridorRight");
                        associationLeft.Add("TwoCorridorDown");
                        associationLeft.Add("TwoCorridorRight");
                        associationLeft.Add("ThreeCorridorDown");
                        associationLeft.Add("ThreeCorridorUp");
                        associationLeft.Add("ThreeCorridorRight");
                        associationLeft.Add("DoubleCorridorsRight");
                    }
                    else if (cellTag.Contains("Two") && (cellTag.Contains("Up") || cellTag.Contains("Left")))
                    {
                        associationLeft.Add("FourCorridor");
                        associationLeft.Add("OneCorridorRight");
                        associationLeft.Add("TwoCorridorDown");
                        associationLeft.Add("TwoCorridorRight");
                        associationLeft.Add("ThreeCorridorDown");
                        associationLeft.Add("ThreeCorridorUp");
                        associationLeft.Add("ThreeCorridorRight");
                        associationLeft.Add("DoubleCorridorsRight");
                    }
                    else if (cellTag.Contains("Three") && (cellTag.Contains("Down") || cellTag.Contains("Left") || cellTag.Contains("Up")))
                    {
                        associationLeft.Add("FourCorridor");
                        associationLeft.Add("OneCorridorRight");
                        associationLeft.Add("TwoCorridorDown");
                        associationLeft.Add("TwoCorridorRight");
                        associationLeft.Add("ThreeCorridorDown");
                        associationLeft.Add("ThreeCorridorUp");
                        associationLeft.Add("ThreeCorridorRight");
                        associationLeft.Add("DoubleCorridorsRight");
                    }
                    else if (cellTag.Contains("Double") && cellTag.Contains("Right"))
                    {
                        associationLeft.Add("FourCorridor");
                        associationLeft.Add("OneCorridorRight");
                        associationLeft.Add("TwoCorridorDown");
                        associationLeft.Add("TwoCorridorRight");
                        associationLeft.Add("ThreeCorridorDown");
                        associationLeft.Add("ThreeCorridorUp");
                        associationLeft.Add("ThreeCorridorRight");
                        associationLeft.Add("DoubleCorridorsRight");
                    }
                }
                if (indexOfCell > 8)
                {
                    cellTop = allCells[indexOfCell - 9];
                    var associationTop = cellTop.GetComponent<callBild>().association;
                    if (cellTag.Contains("Four"))
                    {
                        associationTop.Add("FourCorridor");
                        associationTop.Add("OneCorridorDown");
                        associationTop.Add("TwoCorridorDown");
                        associationTop.Add("TwoCorridorLeft");
                        associationTop.Add("ThreeCorridorDown");
                        associationTop.Add("ThreeCorridorLeft");
                        associationTop.Add("ThreeCorridorRight");
                        associationTop.Add("DoubleCorridorsDown");
                    }
                    else if (cellTag.Contains("One") && cellTag.Contains("Up"))
                    {
                        associationTop.Add("FourCorridor");
                        associationTop.Add("OneCorridorDown");
                        associationTop.Add("TwoCorridorDown");
                        associationTop.Add("TwoCorridorLeft");
                        associationTop.Add("ThreeCorridorDown");
                        associationTop.Add("ThreeCorridorLeft");
                        associationTop.Add("ThreeCorridorRight");
                        associationTop.Add("DoubleCorridorsDown");
                    }
                    else if (cellTag.Contains("Two") && (cellTag.Contains("Up") || cellTag.Contains("Right")))
                    {
                        associationTop.Add("FourCorridor");
                        associationTop.Add("OneCorridorDown");
                        associationTop.Add("TwoCorridorDown");
                        associationTop.Add("TwoCorridorLeft");
                        associationTop.Add("ThreeCorridorDown");
                        associationTop.Add("ThreeCorridorLeft");
                        associationTop.Add("ThreeCorridorRight");
                        associationTop.Add("DoubleCorridorsDown");
                    }
                    else if (cellTag.Contains("Three") && (cellTag.Contains("Up") || cellTag.Contains("Left") || cellTag.Contains("Right")))
                    {
                        associationTop.Add("FourCorridor");
                        associationTop.Add("OneCorridorDown");
                        associationTop.Add("TwoCorridorDown");
                        associationTop.Add("TwoCorridorLeft");
                        associationTop.Add("ThreeCorridorDown");
                        associationTop.Add("ThreeCorridorLeft");
                        associationTop.Add("ThreeCorridorRight");
                        associationTop.Add("DoubleCorridorsDown");
                    }
                    else if (cellTag.Contains("Double") && cellTag.Contains("Down"))
                    {
                        associationTop.Add("FourCorridor");
                        associationTop.Add("OneCorridorDown");
                        associationTop.Add("TwoCorridorDown");
                        associationTop.Add("TwoCorridorLeft");
                        associationTop.Add("ThreeCorridorDown");
                        associationTop.Add("ThreeCorridorLeft");
                        associationTop.Add("ThreeCorridorRight");
                        associationTop.Add("DoubleCorridorsDown");
                    }
                }
                if (indexOfCell < 45)
                {
                    cellBottom = allCells[indexOfCell + 9];
                    var associationBottom = cellBottom.GetComponent <callBild>().association;
                    if (cellTag.Contains("Four"))
                    {
                        associationBottom.Add("FourCorridor");
                        associationBottom.Add("OneCorridorUp");
                        associationBottom.Add("TwoCorridorRight");
                        associationBottom.Add("TwoCorridorUp");
                        associationBottom.Add("ThreeCorridorUp");
                        associationBottom.Add("ThreeCorridorLeft");
                        associationBottom.Add("ThreeCorridorRight");
                        associationBottom.Add("DoubleCorridorsDown");
                    }
                    else if (cellTag.Contains("One") && cellTag.Contains("Down"))
                    {
                        associationBottom.Add("FourCorridor");
                        associationBottom.Add("OneCorridorUp");
                        associationBottom.Add("TwoCorridorRight");
                        associationBottom.Add("TwoCorridorUp");
                        associationBottom.Add("ThreeCorridorUp");
                        associationBottom.Add("ThreeCorridorLeft");
                        associationBottom.Add("ThreeCorridorRight");
                        associationBottom.Add("DoubleCorridorsDown");
                    }
                    else if (cellTag.Contains("Two") && (cellTag.Contains("Down") || cellTag.Contains("Left")))
                    {
                        associationBottom.Add("FourCorridor");
                        associationBottom.Add("OneCorridorUp");
                        associationBottom.Add("TwoCorridorRight");
                        associationBottom.Add("TwoCorridorUp");
                        associationBottom.Add("ThreeCorridorUp");
                        associationBottom.Add("ThreeCorridorLeft");
                        associationBottom.Add("ThreeCorridorRight");
                        associationBottom.Add("DoubleCorridorsDown");
                    }
                    else if (cellTag.Contains("Three") && (cellTag.Contains("Down") || cellTag.Contains("Left") || cellTag.Contains("Right")))
                    {
                        associationBottom.Add("FourCorridor");
                        associationBottom.Add("OneCorridorUp");
                        associationBottom.Add("TwoCorridorRight");
                        associationBottom.Add("TwoCorridorUp");
                        associationBottom.Add("ThreeCorridorUp");
                        associationBottom.Add("ThreeCorridorLeft");
                        associationBottom.Add("ThreeCorridorRight");
                        associationBottom.Add("DoubleCorridorsDown");
                    }
                    else if (cellTag.Contains("Double") && cellTag.Contains("Down"))
                    {
                        associationBottom.Add("FourCorridor");
                        associationBottom.Add("OneCorridorUp");
                        associationBottom.Add("TwoCorridorRight");
                        associationBottom.Add("TwoCorridorUp");
                        associationBottom.Add("ThreeCorridorUp");
                        associationBottom.Add("ThreeCorridorLeft");
                        associationBottom.Add("ThreeCorridorRight");
                        associationBottom.Add("DoubleCorridorsDown");
                    }
                }
            }
        }
    }
}
