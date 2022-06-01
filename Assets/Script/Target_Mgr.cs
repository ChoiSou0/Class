using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Mgr : MonoBehaviour
{
    public GameObject target;
    public float DelTime;
    Vector3 Vec;
    int xVec, zVec;

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
            xVec = Random.Range(-20, 21);
            zVec = Random.Range(-20, 21);
            Instantiate(target, new Vector3(xVec, 0.5f, zVec), Quaternion.identity);
            DelTime = 0;
        }

        
    }

}
