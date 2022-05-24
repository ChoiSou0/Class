using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Ctrl : MonoBehaviour
{
    [SerializeField] GameObject Cam;
    public int Bullet_Speed;
    Vector3 Vec;

    // Start is called before the first frame update
    void Start()
    {
        Vec = new Vector3(Cam.transform.rotation.x, Cam.transform.rotation.y, Cam.transform.rotation.z).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vec * Bullet_Speed * Time.deltaTime);
    }
}
