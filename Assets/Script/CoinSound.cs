using UnityEngine;

public class CoinSound : MonoBehaviour
{
    [SerializeField]
    AudioSource coinFX;

    void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        this.gameObject.SetActive(false);
    }
}
