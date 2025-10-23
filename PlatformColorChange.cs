using UnityEngine;
using System.Collections;
using UnityEngine.UIElements;
using Unity.VisualScripting;

public class PlatformColorChange : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Color standardColor = new Color(245, 243, 131, 255); // Public variable to set color in Inspector

    void Start()
    {
        // Get the Renderer component of the GameObject this script is attached to
        
        ChangeColor(standardColor);
    }
void ChangeColor(Color color)
    {
        Renderer objectRenderer = GetComponent<Renderer>();

        // Check if a Renderer exists and if it has a material
        if (objectRenderer != null && objectRenderer.material != null)
        {
            // Set the material's color to the desired newColor
            objectRenderer.material.color = color;
        }
        else
        {
            Debug.LogWarning("Renderer or Material not found on this GameObject.");
        }
    }
// Update is called once per frame
void Update()
    {

    }
}
