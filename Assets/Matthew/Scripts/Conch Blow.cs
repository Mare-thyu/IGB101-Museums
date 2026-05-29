using UnityEngine;

public class ConchInteraction : MonoBehaviour
{
    public GameObject promptText;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        promptText.SetActive(false);
    }

    void OnMouseEnter()
    {
        promptText.SetActive(true);
    }

    void OnMouseExit()
    {
        promptText.SetActive(false);
    }

    void OnMouseDown()
    {
        audioSource.Play();
    }
}