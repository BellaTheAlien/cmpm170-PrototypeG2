using UnityEngine;

public class player_movement : MonoBehaviour 
{
    [SerializeField]private float speed;
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
    }
}
