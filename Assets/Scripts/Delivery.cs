using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float destroyDelay = 0.5f;
    private bool hasPackage = false;
    void OnCollisionEnter2D(Collision2D other)
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Package
        if (other.CompareTag("Package") && !hasPackage)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
        }

        if (other.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Package delivered to customer");
            hasPackage = false;
        }

    }
}
