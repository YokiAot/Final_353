using UnityEngine;

public class CoinSound : MonoBehaviour
{
    [SerializeField]
    AudioSource coinFX;

    void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        Info.coinCount += 1;
        this.gameObject.SetActive(false);
    }
}
