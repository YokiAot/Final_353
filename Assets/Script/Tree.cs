using UnityEngine;
using static UnityEngine.AdaptivePerformance.Provider.AdaptivePerformanceSubsystemDescriptor;

public class Tree : MonoBehaviour
{
    [SerializeField]
    GameObject thePlayer;

    void OnTriggerEnter(Collider other)
    {
       thePlayer.GetComponent<NewMonoBehaviourScript>().enabled = false;
    }
}
