using UnityEngine;

public class BatSound : MonoBehaviour
{
    [SerializeField]
    AudioSource batFX;

    void OnTriggerEnter(Collider other)
    {
        batFX.Play();
        Info.batteryCount += 1;
        this.gameObject.SetActive(false);
    }
}
