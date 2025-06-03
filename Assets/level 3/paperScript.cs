using UnityEngine;

public class paperScript : MonoBehaviour
{
    public GameObject panel;
    public void OpenZoomedInPanel()  //this will run when button is clicked 
    {
        if (panel != null)
        {
            panel.SetActive(true);
            Debug.Log("Zoomed-in panel activated.");
        }
    }
}
