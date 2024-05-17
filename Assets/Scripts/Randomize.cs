using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Randomize : MonoBehaviour
{
    public Button player;
    public Button Next;
    public Text txt;
    public Sprite[] playerSP;

    public int firstPlayer = 0;
    private int counter;

    public Sprite sp1;

    private void Start()
    {
        player.GetComponentInChildren<SpriteRenderer>();
        sp1 = playerSP[0];
    }

    IEnumerator ChangerSprite()
    {
        if (sp1 == playerSP[0])
        {
            sp1 = playerSP[1];
            player.GetComponentInChildren<SpriteRenderer>().sprite = sp1;
        }
        else
        {
            sp1 = playerSP[0];
            player.GetComponentInChildren<SpriteRenderer>().sprite = sp1;
        }

        yield return new WaitForSeconds(0.05f);
        counter++;
        if (counter < 10)
        {
            Next.interactable = false;
            StartCoroutine(ChangerSprite());
        }
        else 
        {
            Next.interactable = true;
            Next.GetComponentInChildren<Text>().text = "Старт";
            txt.text = "Игру начинает:";
        }
    }

    public void OnClick()
    {
        if (firstPlayer == 0)
        {
            firstPlayer = Random.Range(1, 3);
            PlayerPrefs.SetInt("FirstPlayer", firstPlayer);
            counter = 0;
            Next.interactable = false;

            StartCoroutine(ChangerSprite());

            if (firstPlayer == 1)
            {
                sp1 = playerSP[1];
                player.GetComponentInChildren<SpriteRenderer>().sprite = sp1;
            }
            else
            {
                sp1 = playerSP[0];
                player.GetComponentInChildren<SpriteRenderer>().sprite = sp1;
            }
        }
        else
        {
            PlayerPrefs.SetFloat("music", 0f);
            SceneManager.LoadScene(2);
        }

    }
}
