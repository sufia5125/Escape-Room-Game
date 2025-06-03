using UnityEngine;

public class closeButton : MonoBehaviour
{
    public GameObject obj;

    public void ClosePanel()
    {
        if (obj != null)
        {
            obj.SetActive(false);
            Debug.Log("band hogaya");
        }
    }
}
