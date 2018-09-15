using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startup : MonoBehaviour {

    public Transform ground;

    // called once before Start()
    void Awake()
    {
        for (int i = 0; i < 40; i++)
            for (int j = 0; j < 50; j++)
                Instantiate(ground, new Vector3(i*4, -j*4, 0), Quaternion.identity);
    }
}
