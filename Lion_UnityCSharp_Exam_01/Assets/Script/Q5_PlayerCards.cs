using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using UnityEngine.SceneManagement;


public class Q5_PlayerCards : MonoBehaviour
{
    public List<GameObject> cards = new List<GameObject>();
    // 桃花、愛心、方塊、梅花
    private string[] types = { "Spades", "Heart", "Diamond", "Club" };
    string number;

    private void Start()
    {
        GetAllCards();
        InstantiateCard();
    }

    private void GetAllCards()
    {
        if (cards.Count == 52) return;

        for (int i = 0; i < types.Length; i++)
        {
            for (int j = 1; j <= 13; j++)
            {
                number = j.ToString();
                switch (j)
                {
                    case 1:
                        number = "A";
                        break;
                    case 11:
                        number = "J";
                        break;
                    case 12:
                        number = "Q";
                        break;
                    case 13:
                        number = "K";
                        break;
                }

                GameObject temp = Resources.Load<GameObject>("PlayingCards_" + number + types[i]);
                cards.Add(temp);
            }
        }
    }

    private void InstantiateCard()
    {
        if (transform.childCount == 52) return;
        for (int i = 0; i < cards.Count; i++)
        {
            Instantiate(cards[i],transform);
        }

        StartCoroutine(SetPosition());
    }

    private IEnumerator SetPosition()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform pos = transform.GetChild(i);
            pos.localScale = Vector3.one * 20;
            pos.eulerAngles = new Vector3(180, 0, 0);

            float x = i % 13;
            float y = i / 13;
            pos.position = new Vector3((x - 6) * 1.5f, (y - 1) * 2f, 0);

            yield return null;
        }
    }

    public void DeleteChooseCards()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).name.Contains("2") || transform.GetChild(i).name.Contains("4") ||
                transform.GetChild(i).name.Contains("6") || transform.GetChild(i).name.Contains("8") ||
                transform.GetChild(i).name.Contains("10") || transform.GetChild(i).name.Contains("Q")) Destroy(transform.GetChild(i).gameObject);
        }
    }
}
