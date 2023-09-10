using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Translate(0, 0, _speed * Time.deltaTime, Space.Self);
    }
}
