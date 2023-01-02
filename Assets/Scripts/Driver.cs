using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float steerSpeed = 200f;
    [SerializeField] private float slowSpeed = 15f;
    [SerializeField] private float boostSpeed = 30f;
    [SerializeField] private float resetSpeed = 20f;

    void Start()
    {

    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bump"))
        {
            Debug.Log("Bumping into object");
            moveSpeed = slowSpeed;
            Invoke(nameof(ResetSpeed), 5);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Boost"))
        {
            moveSpeed = boostSpeed;
            Invoke(nameof(ResetSpeed), 5);
        }
    }

    void ResetSpeed()
    {
        moveSpeed = resetSpeed;
    }


}
