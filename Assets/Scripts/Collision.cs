using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("test");
    }

    void OnTriggerEnter2D()
    {
        Debug.Log("Trigger");
    }
}
