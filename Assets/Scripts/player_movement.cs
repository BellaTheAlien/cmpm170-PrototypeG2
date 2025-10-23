using UnityEngine;

public class player_movement : MonoBehaviour 
{
    [SerializeField]private float speed;
    [SerializeField]private GameObject paint;
    [SerializeField] private float attackRange = 2f;
    private Rigidbody2D body;
    private Vector3 initialScale;


    private void Awake() {
        body = GetComponent<Rigidbody2D>();
        initialScale = transform.localScale;
    }

    private void Update() {
        float horizontalInput = Input.GetAxis("Horizontal");

        body.linearVelocity = new Vector2(horizontalInput * speed, body.linearVelocity.y);

        if(horizontalInput > 0.01f) {
            transform.localScale = initialScale;
        }
        else if(horizontalInput < -0.01f) {
            // Flip the player sprite
            transform.localScale = new Vector3(-initialScale.x, initialScale.y, initialScale.z);
        }

        if(Input.GetKeyDown(KeyCode.Space)) {
            body.linearVelocity = new Vector2(body.linearVelocity.x, speed);
        }

        if(Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.F)) {
            Attack();
        }
    }

    private void Attack() {
        float direction = transform.localScale.x > 0 ? 1f : -1f;
        
        Vector3 attackPosition = transform.position + new Vector3(direction * attackRange, 0, 0);
        
        Instantiate(paint, attackPosition, Quaternion.identity);
    }
}
