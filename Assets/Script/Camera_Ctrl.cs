using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Ctrl : MonoBehaviour
{
    [SerializeField] int Power;
    float xCam, yCam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        See();
    }

    void See()
    {
        float xMouse = Input.GetAxis("Mouse X");
        float yMouse = Input.GetAxis("Mouse Y");

        xCam += xMouse * Power * Time.deltaTime;
        yCam += yMouse * Power * Time.deltaTime;

        if (yCam > 30)
        {
            yCam = 30;
        }
        else if (yCam < -30)
        {
            yCam = -30;
        }

        transform.eulerAngles = new Vector3 (-yCam, xCam, 0);
    }
}
