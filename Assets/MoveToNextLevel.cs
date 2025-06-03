using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToNextLevel : MonoBehaviour
{
    public Vector3 nextSceneSpawnPosition;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Next level triggered");
            Destroy(other.gameObject); //purana ghost destroy hoga
            Debug.Log("Player destroyed N");
            Spawner.Instance.SetPlayerSpawnPosition(nextSceneSpawnPosition);  //make new ghost on next level acc to spawner
            Debug.Log("New player instantiated N");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
