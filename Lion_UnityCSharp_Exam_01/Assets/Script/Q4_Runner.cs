using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Q4_Runner : MonoBehaviour
{
    Rigidbody rig;
    Animator ani;
    public AudioSource aud;
    bool gameover;

    public delegate void DelegateRunner();
    public event DelegateRunner Runner;

    private void Start()
    {
        rig = GetComponent<Rigidbody>();
        ani = GetComponent<Animator>();
        aud = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (!gameover)
        {
            Move();
        }
        
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 3);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -5, 5), 0, 0);

        if (transform.position.x >= 4.9)
        {
            Runner();
            gameover = true;
            ani.SetBool("Over", true);
            gameObject.GetComponent<Q4_Runner>().enabled = true;
        }
    }
}
