using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeSpaceBar : MonoBehaviour
{
    public GameObject spaceBar;
    private const string EndReached = "AAAAAA";

    public void closeSB()
    {
        PlayerPrefs.SetInt(EndReached, 100); //end reached set back to 100 (false)
        PlayerPrefs.Save();
        Debug.Log("End reach set back to 100(false)");
        spaceBar.SetActive(false);

    }
}
