using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float playerSpeed = 10f;
    public float horizontalSpeed = 3f;
    public float rightLimit = 5.5f;
    public float leftLimit = -5.5f;
    [SerializeField]
    bool isRunning;

    void Update()
    {
        if (isRunning == false)
        {
            isRunning = true;
            StartCoroutine(AddDistance());
        }
        transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime);
        if (Keyboard.current != null)
        {
            if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
            {
                if (this.gameObject.transform.position.x > leftLimit)
                {
                transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed);
                }
            }
            if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
            {
                if (this.gameObject.transform.position.x < rightLimit)
                {
                    transform.Translate(Vector3.right * horizontalSpeed * Time.deltaTime);
                }
            }
        }
    }

    IEnumerator AddDistance()
    {
        yield return new WaitForSeconds(0.35f);
        Info.distanceRun += 1;
        isRunning = false;
    }
}
