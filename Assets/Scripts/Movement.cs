using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.Translate(0, 0, _speed, Space.Self);
    }
}
