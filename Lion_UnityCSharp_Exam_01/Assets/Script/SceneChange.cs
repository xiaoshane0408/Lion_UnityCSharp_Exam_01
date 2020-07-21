using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex != 0)
        {
            if (Input.GetKeyDown(KeyCode.O)) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        if(SceneManager.GetActiveScene().buildIndex != 4)
        {
            if (Input.GetKeyDown(KeyCode.P)) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
