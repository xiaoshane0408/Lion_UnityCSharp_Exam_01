using UnityEngine;
using UnityEngine.SceneManagement;

public class Q4_GameManager : MonoBehaviour
{
    public Q4_Runner player;
    public GameObject GameOver;

    private void Start()
    {
        player.Runner += OnGameOverPenalOpen;
    }

    private void OnGameOverPenalOpen()
    {
        GameOver.SetActive(true);
    }
}
