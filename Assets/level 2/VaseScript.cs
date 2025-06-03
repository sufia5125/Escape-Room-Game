using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class VaseScript : MonoBehaviour
{
    public GameObject flower;
    public GameObject vaseButton;
    public GameObject doorOpen;
    public GameObject collide;
    private const string Orange = "BBBBB";
    private float moveUpDistance = 1.0f;
    private float moveDuration = 1.0f;
    private float rotateAngle = 90f;
    private float moveForward = 3.0f;

    void Start()
    {
        int VaseCleared = PlayerPrefs.GetInt(Orange, 0);
        if (VaseCleared == 500)
        {
            collide.SetActive(false);
        }
    }

    public void OnVaseClicked()
    {
        if (flower != null)
        {
            StartCoroutine(MoveAndRotateFlower());
            Debug.Log("key milgyi yayyyyyyyy");
            vaseButton.GetComponent<Button>().transition = Selectable.Transition.None;
            vaseButton.GetComponent<Button>().interactable = false;
            doorOpen.SetActive(true);

            PlayerPrefs.SetInt(Orange, 500); // 500 means guzar gaya
            PlayerPrefs.Save();
            collide.SetActive(false);
        }
    }

    // Animation for moving and rotating the flower
    private IEnumerator MoveAndRotateFlower()
    {
        Vector3 startPosition = flower.transform.localPosition;
        Vector3 endPosition = startPosition + new Vector3(0, moveUpDistance, 0);

        Quaternion startRotation = flower.transform.localRotation;
        Quaternion endRotation = startRotation * Quaternion.Euler(0, 0, rotateAngle);

        float elapsedTime = 0;
        while (elapsedTime < moveDuration) //mtlb time k andr reh kr karna hai
        {
            flower.transform.localPosition = Vector3.Lerp(startPosition, endPosition, elapsedTime / moveDuration); //interpolation stuff
            flower.transform.localRotation = Quaternion.Lerp(startRotation, endRotation, elapsedTime / moveDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        flower.transform.localPosition = endPosition;
        flower.transform.localRotation = endRotation;
        StartCoroutine(MoveFlowerForward());
    }

    // Animation for moving the flower forward
    private IEnumerator MoveFlowerForward()
    {
        Vector3 startPosition = flower.transform.localPosition;
        Vector3 endPosition = startPosition + new Vector3(moveForward, 0, 0);

        float elapsedTime = 0;
        while (elapsedTime < moveDuration)
        {
            flower.transform.localPosition = Vector3.Lerp(startPosition, endPosition, elapsedTime / moveDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        flower.transform.localPosition = endPosition;
    }
}


