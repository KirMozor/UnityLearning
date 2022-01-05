using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject   CubePrefabVar;
    // Start is called before the first frame update
    void Start()
    {
        //for (int i = 0; i < 4; i++)
        //{
        //    Instantiate(CubePrefabVar);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(CubePrefabVar);
    }
}
