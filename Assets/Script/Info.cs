using UnityEngine;

public class Info : MonoBehaviour
{
    public static int coinCount = 0;

    [SerializeField]
    GameObject coinDisplay;
    public static int batteryCount = 0;
    public static int distanceRun;
    [SerializeField]
    int initialDistance;
    [SerializeField]
    GameObject batDisplay;
    [SerializeField]
    GameObject runDisplay;

    void Start()
    {
        coinCount = 0;
        batteryCount = 0;
        distanceRun = 0;
    }

    void Update()
    {
        initialDistance = distanceRun;
        coinDisplay.GetComponent<TMPro.TMP_Text>().text = "" + coinCount;
        batDisplay.GetComponent<TMPro.TMP_Text>().text = "" + batteryCount;
        runDisplay.GetComponent<TMPro.TMP_Text>().text = "" + distanceRun;
    }
}
