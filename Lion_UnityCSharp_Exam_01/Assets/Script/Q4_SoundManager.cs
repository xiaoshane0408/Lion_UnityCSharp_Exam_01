using UnityEngine;

public class Q4_SoundManager : MonoBehaviour
{
    public Q4_Runner player;

    private void Start()
    {
        AudioListener.pause = false;
        player.Runner += OnSoundOff;
    }

    private void OnSoundOff()
    {
        AudioListener.pause = true;
    }
}
