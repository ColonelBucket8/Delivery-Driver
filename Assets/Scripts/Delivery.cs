using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Package
        if (other.CompareTag("Package"))
        {
            Debug.Log("Package picked up");
        }

        if (other.CompareTag("Customer"))
        {
            Debug.Log("Package delivered to customer");
        }

    }
}
