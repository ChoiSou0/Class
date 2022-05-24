using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Mgr : MonoBehaviour
{
    public GameObject target;
    public float DelTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnTarget();
    }

    void SpawnTarget()
    {
        DelTime += Time.deltaTime;

        if (DelTime >= 5)
        {
            Instantiate(target, new Vector3(0, 1, 0), Quaternion.identity);
            DelTime = 0;
        }

        
    }

}
