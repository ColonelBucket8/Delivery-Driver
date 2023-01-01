using UnityEngine;

public class Delivery : MonoBehaviour
{
    private bool hasPackage = false;
    void OnCollisionEnter2D(Collision2D other)
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Package
        if (other.CompareTag("Package"))
        {
            Debug.Log("Package picked up");
            hasPackage = true;
        }

        if (other.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Package delivered to customer");
            hasPackage = false;
        }

    }
}
