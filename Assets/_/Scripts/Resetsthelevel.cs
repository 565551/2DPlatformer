using UnityEngine;
using UnityEngine.SceneManagement;

public class resetsthelevel : MonoBehaviour
{
    // The name of the next scene to load
    public string nextSceneName;
    // Add this code to your player script
    public DisplayMessage displayMessage;

    public string showMessage;

    private void OnCollisionEnter2D(Collision2D other)
    {
        // Check if the object entering the trigger is the player
        if (other.gameObject.tag == "Player")
        {
            // Delay for visual effect (optional)
            Invoke("Resetsthelevel", 0f);
        }
    }

    // Function to load the next scene
    private void Resetsthelevel()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}