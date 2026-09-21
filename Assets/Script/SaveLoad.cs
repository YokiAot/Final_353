using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public static int loadedCoin;
    public static int loadedBattery;
    public static int loadedDistance;

    public static bool saveData;

    [SerializeField]
    int internalCoin;

    [SerializeField]
    int internalBattery;

    [SerializeField]
    int internalDistance;

    void Start()
    {
        loadedCoin = PlayerPrefs.GetInt("CoinSave");
        loadedBattery = PlayerPrefs.GetInt("BatterySave");
        loadedDistance = PlayerPrefs.GetInt("DistanceSave");
    }

    void Update()
    {
        internalCoin = loadedCoin + Info.coinCount;
        internalBattery = loadedBattery + Info.batteryCount;
        internalDistance = Info.distanceRun;
        if (saveData == true)
        {
            saveData = false;
            PlayerPrefs.SetInt("CoinSave", internalCoin);
            PlayerPrefs.SetInt("BatterySave", internalBattery);
            if (internalDistance > loadedDistance)
            {
                PlayerPrefs.SetInt("DistanceSave", internalDistance);
                loadedDistance = internalDistance;
            }
        }
    }
}
