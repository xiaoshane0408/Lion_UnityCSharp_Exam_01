using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Q3_ForLoop : MonoBehaviour
{
    public GameObject prefab;

    IEnumerator Start()
    {
        for (int i = 0; i < 5; i++)
        {
            // 左上下
            for (int j = 0; j < i; j++)
            {
                Instantiate(prefab, new Vector3(i, j, 0), Quaternion.identity);
                Instantiate(prefab, new Vector3(i, -j, 0), Quaternion.identity);
                yield return null;
            }
            
            // 右上下
            for (int j = 4; j > i; j--)
            {
                Instantiate(prefab, new Vector3(i + 4, 4 - j, 0), Quaternion.identity);
                Instantiate(prefab, new Vector3(i + 4, j - 4, 0), Quaternion.identity);
                yield return null;
            } 
        }
    }
}
