using UnityEngine;
using TMPro;

public class PlaySoundOnClick : MonoBehaviour
{
    private AudioSource audioSource;

    public GameObject promptText;

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