using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class callBild : MonoBehaviour
{
    [Header("Sprite")]
    [SerializeField] public SpriteRenderer Sprite;

    [Header("Sprites")]
    [SerializeField] public Sprite sp1;
    [SerializeField] private Sprite[] oneCorridor;
    [SerializeField] private Sprite[] twoCorridors;
    [SerializeField] private Sprite[] threeCorridors;
    [SerializeField] private Sprite[] fourCorridors;
    [SerializeField] private Sprite[] doubleCorridors;

    public Sprite sp2;

    [Header("Button")]
    [SerializeField] public Button btn;

    public ArrayList association = new ArrayList();

    public string[] assot;

    public int indexCell;
    public int indexCellRotate;

    public string indexOfCell = "0";
    public bool interectable = true;

    private string condition;
    public string conditionPlayerWalk;

    private void Start()
    {
        Sprite.sprite = sp1;
        Sprite.transform.localScale = new Vector2(100, 100);
    }

    private void Update()
    {
        indexCell = PlayerPrefs.GetInt("indexCell");
        indexCellRotate = PlayerPrefs.GetInt("indexCellRotate");
        condition = PlayerPrefs.GetString("condition");

        if (indexOfCell == "49")
        {
            Sprite.sprite = sp1;
            Sprite.transform.localScale = new Vector2(300.1558f, 300.4714f);
        }
    }

    public void onClick()
    {
        if (condition.Contains("Build") && (condition.Contains("First") || condition.Contains("Second")))
        {
            if ((CompareTag("Green") || CompareTag("FirstOfFirst") || CompareTag("FirstOfSecond")) && !CompareTag("Finish"))
            {
                switch (indexCell)
                {
                    case 0:
                        sp2 = oneCorridor[indexCellRotate];
                        break;
                    case 1:
                        sp2 = twoCorridors[indexCellRotate];
                        break;
                    case 2:
                        sp2 = threeCorridors[indexCellRotate];
                        break;
                    case 3:
                        sp2 = fourCorridors[0];
                        break;
                    case 4:
                        sp2 = doubleCorridors[indexCellRotate];
                        break;
                }
                Sprite.sprite = sp2;
                Sprite.transform.localScale = new Vector2(300, 300);
                btn.interactable = false;

                interectable = false;

                int afterFirst = PlayerPrefs.GetInt("afterFirst");

                if (afterFirst < 6)
                {
                    afterFirst++;
                }

                PlayerPrefs.SetInt("afterFirst",  afterFirst);
                PlayerPrefs.SetInt("changeCorridor", 1);
                if (condition == "playerFirstBuild")
                {
                    PlayerPrefs.SetString("condition", "playerFirstWalk");
                }
                else 
                {
                    PlayerPrefs.SetString("condition", "playerSecondWalk");
                }

            }
        }
    }
}
