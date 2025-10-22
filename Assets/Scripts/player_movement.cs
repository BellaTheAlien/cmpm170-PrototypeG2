using UnityEngine;

public class player_movement : MonoBehaviour 
{
    [SerializeField]private float speed;
    private Rigidbody2D body;

    private void Awake() {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        float horizontalInput = Input.GetAxis("Horizontal");
        //float verticalInput = Input.GetAxis("Vertical");

        body.linearVelocity = new Vector2(horizontalInput * speed, body.linearVelocity.y);

        if(Input.GetKeyDown(KeyCode.Space)) {
            body.linearVelocity = new Vector2(body.linearVelocity.x, speed);
        }
    }
}
