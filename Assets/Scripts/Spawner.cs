using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Quaternion _spawnLine;

    public void CreateEnemy(Enemy enemy) => 
        Instantiate(enemy, transform.position, _spawnLine);
}
