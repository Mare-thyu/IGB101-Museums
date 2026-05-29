using UnityEngine;

public class OrbToggle : MonoBehaviour
{
    public Light orbLight;
    public Renderer orbRenderer;
    public AudioSource toggleSound; // NEW

    private bool isOn = false;

    void OnMouseDown()
    {
        isOn = !isOn;

        // Toggle light
        if (orbLight != null)
            orbLight.enabled = isOn;

        // Toggle emission
        if (orbRenderer != null)
        {
            if (isOn)
                orbRenderer.material.EnableKeyword("_EMISSION");
            else
                orbRenderer.material.DisableKeyword("_EMISSION");
        }

        // Play sound
        if (toggleSound != null)
            toggleSound.Play();
    }
}