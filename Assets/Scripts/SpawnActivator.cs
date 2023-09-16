using System.Collections;
using UnityEngine;

public class SpawnActivator : MonoBehaviour
{
    [SerializeField] private Enemy _prefab;
    [SerializeField] private int _countEnemy;

    private Transform[] _spawnPoints;
    private float _delay = 2f;

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
        WaitForSecondsRealtime delay = new WaitForSecondsRealtime(_delay);

        for (int i = 0; i < _countEnemy; i++)
        {
            _spawnPoints[Random.Range(0, _spawnPoints.Length)].
                GetComponent<Spawner>().
                CreateEnemy(_prefab);

            yield return delay;
        }
    }
}
