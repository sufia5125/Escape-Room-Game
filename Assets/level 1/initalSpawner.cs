using UnityEngine;

public class initalSpawner : MonoBehaviour
{
    public GameObject ghostPrefab;
    private static bool hasSpawned = false;
    private const string EndReached = "AAAAAA";
    private const string Orange = "BBBBB";

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && !hasSpawned)
        {
            SetEndReached();
            SpawnPlayer();
            hasSpawned = true;
            enabled = false;   // Disable this script 
        }
    }
    private void SpawnPlayer()
    {
        Instantiate(ghostPrefab, new Vector3(-6f,-1.86f,0.0f), Quaternion.identity);
        Debug.Log("Player spawned for the first time.");
 
    }
    private void SetEndReached()
    { 
        PlayerPrefs.SetInt(EndReached,100); //end reached is 100 so false rn
        PlayerPrefs.Save();
        PlayerPrefs.SetInt(Orange,100);
        PlayerPrefs.Save();
        Debug.Log("SetEndReached is set to zero");
    }
}

