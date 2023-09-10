using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private int _countEnemy;

    private Transform[] _spawnPoints;
    private float _spawnTime = 2f;

    private void Start()
    {
        _spawnPoints = new Transform[transform.childCount];

        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            _spawnPoints[i] = transform.GetChild(i);
        }

        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        for( int i = 0; i  < _countEnemy; i++)
        {
            Instantiate(_enemy, _spawnPoints[Random.Range(0, _spawnPoints.Length)]);

            yield return new WaitForSecondsRealtime(_spawnTime);
        }
    }
}
