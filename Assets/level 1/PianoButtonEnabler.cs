using UnityEngine;
using UnityEngine.UI;

public class PianoButtonEnabler : MonoBehaviour
{
    public GameObject pianoButton;
    private const string EndReached = "AAAAAA";

    void Start()
    {
        EnablePiano(); 
    }
    public void EnablePiano()
    {
        int endReachedValue = PlayerPrefs.GetInt(EndReached, 0);

        if (endReachedValue == 200)
        {
            pianoButton.GetComponent<Button>().interactable = true;
            Debug.Log("Piano Button is on");
        }
    }
}
