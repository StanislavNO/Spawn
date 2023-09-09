using System.Collections;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
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

    IEnumerator SpawnEnemy()
    {
        int countEnemy = 0;

        while (countEnemy < _countEnemy)
        {
            Instantiate(_enemy, _spawnPoints[Random.Range(0, _spawnPoints.Length)]);
            countEnemy++;

            yield return new WaitForSecondsRealtime(_spawnTime);
        }
    }
}
