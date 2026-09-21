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

    public static bool hasClicked;

    void Start()
    {
        if (hasClicked == true)
        {
            staticCam.SetActive(true);
            mainCam.SetActive(true);
            animCam.SetActive(false);

            menuControls.SetActive(true);
            bounceText.SetActive(false);
            bigBotton.SetActive(false);
        }
    }

    void Update()
    {
        
    }

    public void MenuBeginBotton()
    {
        StartCoroutine(AnimCam());
    }

    public void StartGame()
    {
        StartCoroutine(StartBotton());
    }

    IEnumerator StartBotton()
    {
        bottonSelect.Play();
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Game");
    }

    IEnumerator AnimCam()
    {
        animCam.GetComponent<Animator>().Play("AnimCam");
        bounceText.SetActive(false);
        bigBotton.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        mainCam.SetActive(false);
        menuControls.SetActive(true);
        hasClicked = true;
    }
}
