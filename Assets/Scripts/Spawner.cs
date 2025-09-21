using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Target _target;
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Vector3 _maximumSpawnCoordinates;
    [SerializeField] private Vector3 _minimumSpawnCoordinates;

    private float _repeatRate = 2f;

    private void Start()
    {
        StartCoroutine(SpawnEnemys());
    }

    private IEnumerator SpawnEnemys()
    {
        var wait = new WaitForSeconds(_repeatRate);

        while (enabled)
        {
            yield return wait;

            Enemy enemy = Instantiate(_enemyPrefab, GenerateRandomPosition(), Quaternion.identity);
            enemy.SetTarget(_target);
        }
    }

    private Vector3 GenerateRandomPosition()
    {
        float positionX = Random.Range(_minimumSpawnCoordinates.x, _maximumSpawnCoordinates.x);
        float positionY = Random.Range(_minimumSpawnCoordinates.y, _maximumSpawnCoordinates.y);
        float positionZ = Random.Range(_minimumSpawnCoordinates.z, _maximumSpawnCoordinates.z);

        return new Vector3(positionX, positionY, positionZ);
    }
}
