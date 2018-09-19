using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startup : MonoBehaviour
{
    [SerializeField]
    public Transform wall;
    [SerializeField]
    public Transform ground;
    [SerializeField]
    public Transform meteor;
    // tracks all destroyed ground tiles
    public static GameObject[][] groundObjects;
    public static GameObject[] wallObjects;

    // called once before Start()
    void Awake()
    {
        groundObjects = new GameObject[50][];
        for (int j = 0; j < 50; j++)
        {
            groundObjects[j] = new GameObject[41];
            for (int i = 0; i < 41; i++)
                groundObjects[j][i] = Instantiate(ground, new Vector3(i * 4, -j * 4, 0), Quaternion.identity).gameObject;
        }

        for (int i = 0; i < 60; i++)
        {
            Instantiate(wall, new Vector3(-4, 40 + i * -4, 0), Quaternion.identity);
            Instantiate(wall, new Vector3(164, 40 + i * -4, 0), Quaternion.identity);
        }
    }

    private void Start()
    {
        InvokeRepeating("SpawnMeteor", 1, .5f);
    }

    private void SpawnMeteor()
    {
        Instantiate(meteor, new Vector3((int)(Random.value*41) * 4, 40, 0), Quaternion.identity);
    }
}
