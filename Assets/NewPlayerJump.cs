using UnityEngine;

public class NewPlayerJump : MonoBehaviour
{
    public float jumpForce = 15f;
    private Rigidbody2D rb;
    private bool isGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
    }

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            isGrounded = false;
        }
    }

    // private void OnCollisionEnter2D(Collision2D collision)
    // {
    //     if (collision.collider.CompareTag("Ground"))
    //     {
    //         isGrounded = true;
    //     }
    // }

    private void OnCollisionEnter2D(Collision2D collision)
{
    Debug.Log("Menyentuh: " + collision.collider.tag);
    if (collision.collider.CompareTag("Ground"))
    {
        Debug.Log("Is grounded!");
        isGrounded = true;
    }
}
}
