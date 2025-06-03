using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    public static Spawner Instance;
    public GameObject playerPrefab;
    private Vector3 spawnPosition;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (playerPrefab != null && spawnPosition != Vector3.zero)
        {
            Instantiate(playerPrefab, spawnPosition, Quaternion.identity);
        }
    }

    public void SetPlayerSpawnPosition(Vector3 position)
    {
        spawnPosition = position;
    }
}
