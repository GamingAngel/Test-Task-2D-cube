using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PlayerInput))]

public class Jump : MonoBehaviour
{
    private const int MAXJUMPS = 2;
    private int jumpCount;

    private Rigidbody2D rb2D;

    [SerializeField] private int jumpForce;

    void Start() => rb2D = GetComponent<Rigidbody2D>();

    private void OnTriggerEnter2D(Collider2D collision) => jumpCount = 0;

    public void OnJump(InputAction.CallbackContext context)
    {
        if (jumpCount< MAXJUMPS && context.performed)
        {
            jumpCount++;
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpForce);
        }     
    }
}
