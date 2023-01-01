using UnityEngine;



public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = Color.green;
    [SerializeField] Color32 noPackageColor = Color.white;

    [SerializeField] float destroyDelay = 0.5f;

    private bool hasPackage = false;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

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
            spriteRenderer.color = hasPackageColor;

            Destroy(other.gameObject, destroyDelay);
        }

        if (other.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Package delivered to customer");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }

    }
}

