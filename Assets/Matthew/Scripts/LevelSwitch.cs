using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitch : MonoBehaviour
{
    // Reference to GameManager
    GameManager gameManager;

    // Name of next scene
    public string nextLevel;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager")
            .GetComponent<GameManager>();
    }

    // Trigger event
    private void OnTriggerEnter(Collider otherObject)
    {
        // Check if Player touched the trigger
        if (otherObject.CompareTag("Player"))
        {
            // Check if enough pickups collected
            if (gameManager.levelComplete)
            {
                // Load next scene
                SceneManager.LoadScene(nextLevel);
            }
        }
    }
}