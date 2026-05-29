using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Reference to the GameManager
    GameManager gameManager;

    // Pickup sound
    public AudioClip pickupSound;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager")
            .GetComponent<GameManager>();
    }

    // Trigger event when another object enters the collider
    private void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.CompareTag("Player"))
        {
            // Increase pickup count
            gameManager.currentPickups += 1;

            // Play sound at pickup position
            AudioSource.PlayClipAtPoint(pickupSound, transform.position);

            // Destroy pickup object
            Destroy(gameObject);
        }
    }
}