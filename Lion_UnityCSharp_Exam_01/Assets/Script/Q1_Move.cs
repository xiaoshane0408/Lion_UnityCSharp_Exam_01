using UnityEngine;
using UnityEngine.SceneManagement;

public class Q1_Move : MonoBehaviour
{
    Rigidbody rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rig.velocity = Vector3.one * 5;
        transform.position =new Vector3 (Mathf.Clamp(transform.position.x, -5, 5), 0, 0);
    }
}
