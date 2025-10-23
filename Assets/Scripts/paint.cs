using UnityEngine;

public class paint : MonoBehaviour 
{
    [SerializeField] private bool fadeOverTime = false;
    [SerializeField] private float fadeDelay = 5f;
    
    private SpriteRenderer spriteRenderer;
    private float timer = 0f;
    
    private void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Random.ColorHSV(0f, 1f, 0.8f, 1f, 0.8f, 1f);
    }
    
    private void Update() {
        if (fadeOverTime) {
            timer += Time.deltaTime;
            if (timer > fadeDelay) {
                // Fade out slowly
                Color color = spriteRenderer.color;
                color.a -= Time.deltaTime;
                spriteRenderer.color = color;
                
                if (color.a <= 0) {
                    Destroy(gameObject);
                }
            }
        }
    }
}