using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bullet;
    public float sensitivity = 90.0f;
    public float minFov = 15.0f;
    public float maxFov = 60.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float fov = Camera.main.fieldOfView;
        fov += Input.GetAxis("Mouse ScrollWheel") * sensitivity;
        fov = Mathf.Clamp(fov, minFov, maxFov);
        Camera.main.fieldOfView = fov;

        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward*500.0f, out hit, Mathf.Infinity))
        {
            Debug.DrawRay(Camera.main.transform.position,
                        Camera.main.transform.forward * hit.distance,
                        Color.green);
            Debug.Log("Hit " + hit.transform.gameObject.tag + " at "+hit.distance);
        }
        else
        {
            Debug.DrawRay(Camera.main.transform.position,
                       Camera.main.transform.forward * 500.0f,
                       Color.red);
            Debug.Log("no hit");
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bullet, Camera.main.transform.position, Camera.main.transform.rotation);
        }
        
    }
}
