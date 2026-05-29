using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Reference to the player object
    public GameObject player;

    // Pickup and Level Completion Logic
    public int currentPickups = 0;
    public int maxPickups = 5;
    public bool levelComplete = false;

    // UI reference
    public Text pickupText;

    // Update is called once per frame
    void Update()
    {
        LevelCompleteCheck();
        UpdateGUI();
    }

    // Checks if level is complete
    private void LevelCompleteCheck()
    {
        if (currentPickups >= maxPickups)
        {
            levelComplete = true;
        }
        else
        {
            levelComplete = false;
        }
    }

    // Updates UI text
    private void UpdateGUI()
    {
        pickupText.text = "Pickups: " + currentPickups + "/" + maxPickups;
    }
}