using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    GameObject fadeOut;
    [SerializeField]
    GameObject bounceText;
    [SerializeField]
    GameObject bigBotton;
    [SerializeField]
    GameObject animCam;
    [SerializeField]
    GameObject mainCam;
    [SerializeField]
    GameObject menuControls;
    [SerializeField]
    AudioSource bottonSelect;
    [SerializeField] GameObject staticCam;

    [SerializeField] int loadedCoin;
    [SerializeField] int loadedBattery;
    [SerializeField] int loadedDistance;
    [SerializeField] GameObject coinDisplay;
    [SerializeField] GameObject batteryDisplay;
    [SerializeField] GameObject distanceDisplay;
    [SerializeField] GameObject exitButton;

    public static bool hasClicked;

    void Start()
    {
        /*loadedCoin = PlayerPrefs.GetInt("CoinSave");
        loadedBattery = PlayerPrefs.GetInt("BatterySave");
        loadedDistance = PlayerPrefs.GetInt("DistanceSave");
        coinDisplay.GetComponent<TMPro.TMP_Text>().text = "" + loadedCoin;
        batteryDisplay.GetComponent<TMPro.TMP_Text>().text = "" + loadedBattery;
        distanceDisplay.GetComponent<TMPro.TMP_Text>().text = "" + loadedDistance;*/

        if (hasClicked == true)
        {
            staticCam.SetActive(true);
            mainCam.SetActive(true);
            animCam.SetActive(false);

            menuControls.SetActive(true);
            bounceText.SetActive(false);
            bigBotton.SetActive(false);
            if (exitButton != null) exitButton.SetActive(false);
        }
    }

    void Update()
    {
        loadedCoin = PlayerPrefs.GetInt("CoinSave");
        loadedBattery = PlayerPrefs.GetInt("BatterySave");
        loadedDistance = PlayerPrefs.GetInt("DistanceSave");
        coinDisplay.GetComponent<TMPro.TMP_Text>().text = "" + loadedCoin;
        batteryDisplay.GetComponent<TMPro.TMP_Text>().text = "" + loadedBattery;
        distanceDisplay.GetComponent<TMPro.TMP_Text>().text = "" + loadedDistance;
    }

    public void MenuBeginBotton()
    {
        StartCoroutine(AnimCam());
    }

    public void StartGame()
    {
        StartCoroutine(StartBotton());
    }
    //public void QuitGame()
    //{
    //    StartCoroutine(QuitBotton());
    //}

    IEnumerator StartBotton()
    {
        bottonSelect.Play();
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(1);
    }


    //IEnumerator QuitBotton()
    //{
    //    bottonSelect.Play();
    //    fadeOut.SetActive(true);
    //    yield return new WaitForSeconds(1f);
    //    Application.Quit();
    //}

    IEnumerator AnimCam()
    {
        animCam.GetComponent<Animator>().Play("AnimCam");
        bounceText.SetActive(false);
        bigBotton.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        mainCam.SetActive(false);
        menuControls.SetActive(true);
        if (exitButton != null) exitButton.SetActive(true);
        hasClicked = true;
    }
}
