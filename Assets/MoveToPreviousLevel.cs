using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToPreviousLevel : MonoBehaviour
{
    public Vector3 prevSceneSpawnPosition;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Previous level triggered");
            Destroy(other.gameObject);
            Debug.Log("Player destroyed P");
            Spawner.Instance.SetPlayerSpawnPosition(prevSceneSpawnPosition);
            Debug.Log("New player instantiated P");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
