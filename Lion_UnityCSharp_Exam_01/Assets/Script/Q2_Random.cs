using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Q2_Random : MonoBehaviour
{
    public Image img;
    public Sprite[] sprites;
    float time;
    
    public IEnumerator RandomButton()
    {
        while (time < 1)
        {
            time += Time.deltaTime;
            yield return null;
            img.sprite = sprites[Random.Range(0, sprites.Length)];
        }
    }

    public void ClickButton()
    {
        time = 0;
        StartCoroutine(RandomButton());
    }
}
