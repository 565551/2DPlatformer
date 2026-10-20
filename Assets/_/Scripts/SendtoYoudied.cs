using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SendtoYoudied : MonoBehaviour
{
    // The name of the next scene to load
    public string nextSceneName;
    // Add this code to your player script
    public DisplayMessage displayMessage;

    public string showMessage;
    public Transform player;      // Reference to the player's Transform
    void Start()
    {
        // 1. Find the GameObject with the tag
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");

        // 2. Check if it exists, then get its transform component
        if (playerObject != null)
        {
            player = playerObject.transform;
        }
        else
        {
            Debug.LogError("Could not find a GameObject with the tag 'Player'!");
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        // Check if the object entering the trigger is the player
        if (other.gameObject.tag == "Player")
        {
            // display win message
            displayMessage.ShowMessage(showMessage);
            // Delay for visual effect (optional)
            Invoke("LoadNextLevel", 0f);
        }
    }
    // Function to load the next scene
    private void LoadNextLevel()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}