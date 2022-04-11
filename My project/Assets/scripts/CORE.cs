using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CORE : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;
    private Vector3 direction;

    private static List<GameObject> theRooms = new List<GameObject>();

    public static void addRoomGO(GameObject go)
    {
        CORE.theRooms.Add(go);
        print("Added Room");
    }

    public static void display()
    {
        print("Woot");
        //push test
    }

    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector3(Random.Range(-1.0f, 1.0f), 0.0f, Random.Range(-1.0f, 1.0f));
        for (int i = 0; i < 20; i++)
        {
            print(Random.Range(1, 20));
        }
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * 5 * Time.deltaTime;
    }
}
