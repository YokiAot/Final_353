using UnityEngine;

public class CoinCollectable : MonoBehaviour
{
    [SerializeField]
    float rotateSpeed = 1;
    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
}
