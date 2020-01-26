using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public float spawnning = 1f;//decide the spawn rate
    public GameObject hexa;//prefab
    private float nextspawnning = 0f;

    // Update is called once per frame
    void Update()
    {
        if(Time.time>=nextspawnning)
        {
            Instantiate(hexa, Vector3.zero, Quaternion.identity);
            nextspawnning = Time.time + 1f / spawnning;
        }
    }
}
