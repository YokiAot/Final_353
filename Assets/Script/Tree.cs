using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.AdaptivePerformance.Provider.AdaptivePerformanceSubsystemDescriptor;

public class Tree : MonoBehaviour
{
    [SerializeField]
    GameObject thePlayer;
    [SerializeField]
    AudioSource collisionFX;
    [SerializeField]
    GameObject mainCam;
    [SerializeField]
    GameObject fadeOut;


    void OnTriggerEnter(Collider other)
    {
       StartCoroutine(CollisionEnd());
    }
    IEnumerator CollisionEnd()
    {
        collisionFX.Play();
        thePlayer.GetComponent<NewMonoBehaviourScript>().enabled = false;
        mainCam.GetComponent<Animator>().Play("CollisionCam");
        yield return new WaitForSeconds(1f);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene("MainMenu");
    }
}
