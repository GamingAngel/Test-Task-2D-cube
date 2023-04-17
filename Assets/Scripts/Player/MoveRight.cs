using UnityEngine;

[RequireComponent (typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class MoveRight : MonoBehaviour
{
    private Rigidbody2D rb2D;
    [SerializeField] private float startForce;

    private readonly Vector2 direction = new(1f, -1f);

    void Start() => rb2D = GetComponent<Rigidbody2D>(); 

    private void FixedUpdate() => Move();   

    private void Move() => rb2D.velocity = new Vector2(startForce,rb2D.velocity.y);
}
