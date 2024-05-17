using UnityEngine;

public class changeSprite : MonoBehaviour
{
    [Header("Sprite")]
    [SerializeField] private SpriteRenderer Sprite;

    [Header("Sprites")]
    [SerializeField] private Sprite sp1;
    [SerializeField] private Sprite[] oneCorridor;
    [SerializeField] private Sprite[] twoCorridors;
    [SerializeField] private Sprite[] threeCorridors;
    [SerializeField] private Sprite[] fourCorridors;
    [SerializeField] private Sprite[] doubleCorridors;

    [Header("Index")]
    [SerializeField] public string indexOfCell;

    private Sprite[] corridors;

    private int index = -1;
    private int numberOfCorridors;

    public int afterFirst;

    private bool changeCorridor;
    private bool changeCorridor2;

    private string condition;

    private void Start()
    {

        Sprite.sprite = sp1;
        Sprite.transform.localScale = new Vector2((2090.585f), (1919.019f));

        PlayerPrefs.SetInt("afterFirst", 0);
        PlayerPrefs.SetInt("indexCell", 0);
        PlayerPrefs.SetInt("indexCellRotate", 0);

        choiceCorridor();
    }

    private void choiceCorridor()
    {
        if (afterFirst >= 6)
        {
            int i = Random.Range(0, 5);
            switch (i)
            {
                case 0:
                    corridors = oneCorridor;
                    numberOfCorridors = 0;
                    break;
                case 1:
                    corridors = twoCorridors;
                    numberOfCorridors = 1;
                    break;
                case 2:
                    corridors = threeCorridors;
                    numberOfCorridors = 2;
                    break;
                case 3:
                    corridors = fourCorridors;
                    numberOfCorridors = 3;
                    break;
                case 4:
                    corridors = doubleCorridors;
                    numberOfCorridors = 4;
                    break;
            }
            PlayerPrefs.SetInt("indexCell", i);
        }
        else
        {
            int i = Random.Range(2, 4);
            switch (i)
            {
                case 2:
                    corridors = threeCorridors;
                    numberOfCorridors = 2;
                    break;
                case 3:
                    corridors = fourCorridors;
                    numberOfCorridors = 3;
                    break;
            }
            PlayerPrefs.SetInt("indexCell", i);
        }
    }

    private void changeRotation(Sprite[] spriteList, int index)
    {
        if (condition.Contains(indexOfCell)) 
        { 
        Sprite sprite;
        sprite = spriteList[index];
        Sprite.sprite = sprite;
        Sprite.transform.localScale = new Vector2(380f, 386f);
        }
    }

    private void CheckCell(int numberOfCorridors, int index)
    {
        switch (numberOfCorridors)
        {
            case 0:
                switch (index)
                {
                    case 0:
                        tag = "OneCorridorDown";
                        break;
                    case 1:
                        tag = "OneCorridorRight";
                        break;
                    case 2:
                        tag = "OneCorridorUp";
                        break;
                    case 3:
                        tag = "OneCorridorLeft";
                        break;
                }
                break;

            case 1:
                switch (index)
                {
                    case 0:
                        tag = "TwoCorridorDown";
                        break;
                    case 1:
                        tag = "TwoCorridorRight";
                        break;
                    case 2:
                        tag = "TwoCorridorUp";
                        break;
                    case 3:
                        tag = "TwoCorridorLeft";
                        break;
                }
                break;
            case 2:
                switch (index)
                {
                    case 0:
                        tag = "ThreeCorridorDown";
                        break;
                    case 1:
                        tag = "ThreeCorridorRight";
                        break;
                    case 2:
                        tag = "ThreeCorridorUp";
                        break;
                    case 3:
                        tag = "ThreeCorridorLeft";
                        break;
                }
                break;
            case 3:
                switch (index)
                {
                    case 0:
                        tag = "FourCorridor";
                        break;
                }
                break;
            case 4:
                switch (index)
                {
                    case 0:
                        tag = "DoubleCorridorsDown";
                        break;
                    case 1:
                        tag = "DoubleCorridorsRight";
                        break;
                }
                break;
        }
    }

    public void changerSprite()
    {
        if (condition.Contains(indexOfCell))
        {
            if (index == corridors.Length - 1 || index == -1)
            {
                index = 0;
                changeRotation(corridors, index);
            }
            else
            {
                index++;
                switch (index)
                {
                    case 0:
                        changeRotation(corridors, index);
                        break;
                    case 1:
                        changeRotation(corridors, index);
                        break;
                    case 2:
                        changeRotation(corridors, index);
                        break;
                    case 3:
                        changeRotation(corridors, index);
                        break;
                }
            }
            GetComponent<AudioSource>().Play();
        }
    }

    private void FixedUpdate()
    {

        afterFirst = PlayerPrefs.GetInt("afterFirst");
        condition = PlayerPrefs.GetString("condition");
            
        changeCorridor = PlayerPrefs.GetInt("changeCorridor") == 1;
        changeCorridor2 = PlayerPrefs.GetInt("changeCorridor2") == 1;


        CheckCell(numberOfCorridors, index);

        if (condition.Contains(indexOfCell))
        {

            if (changeCorridor && changeCorridor2)
            {
                choiceCorridor();
                PlayerPrefs.SetInt("changeCorridor", 0);
                PlayerPrefs.SetInt("changeCorridor2", 0);
                changeCorridor = false;
                index = 0;
                changeRotation(corridors, index);
            }
 
            PlayerPrefs.SetInt("indexCellRotate", index);
            PlayerPrefs.SetInt("afterFirst", afterFirst);
        }          
        else
        {
            Sprite.sprite = sp1;
            Sprite.transform.localScale = new Vector2((2090.585f), (1919.019f));
        }
    }
}
