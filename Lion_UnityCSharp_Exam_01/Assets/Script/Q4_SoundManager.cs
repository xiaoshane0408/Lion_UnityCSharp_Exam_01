using UnityEngine;

public class Q4_SoundManager : MonoBehaviour
{
    public Q4_Runner player;
    

    private void Start()
    {
        player.Runner += OnSoundOff;
    }

    private void OnSoundOff()
    {
        player.aud.PlayOneShot(player.aud.clip);
    }
}
