using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
     private float _spawnInterval = 1.65f;
     
    [SerializeField] private EnemyMovement _enemyPrefab;    
   

    private void Start()
    {
        StartCoroutine(EnemySpawn());
    }
    
   private IEnumerator EnemySpawn()
    {
        while(true) 
        {
            var newEnemy = Instantiate(_enemyPrefab,transform.position,Quaternion.identity);
            newEnemy.transform.parent = transform;
            yield return new WaitForSeconds(_spawnInterval);      
        }     
    }
}
