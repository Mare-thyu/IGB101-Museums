using UnityEngine;

public class ExhibitInteraction : MonoBehaviour
{
    public GameObject promptText;
    public GameObject infoPanel;

    private bool isOpen = false;

    void Start()
    {
        promptText.SetActive(false);
        infoPanel.SetActive(false);
    }

    void OnMouseEnter()
    {
        if (!isOpen)
            promptText.SetActive(true);
    }

    void OnMouseExit()
    {
        promptText.SetActive(false);
    }

    void OnMouseDown()
    {
        isOpen = !isOpen;

        infoPanel.SetActive(isOpen);
        promptText.SetActive(!isOpen);
    }
}