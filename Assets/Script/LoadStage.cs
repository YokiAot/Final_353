using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadStage : MonoBehaviour
{
    [SerializeField]
    GameObject fadeOut;
    void Start()
    {
        StartCoroutine(LoadeLevel());
    }

    IEnumerator LoadeLevel()
    {
        yield return new WaitForSeconds(2f);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(0);
    }
}
