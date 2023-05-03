using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 20.0f;
    public float lifeTime = 3.0f;
    float timeleft;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        timeleft = lifeTime;
        rb = GetComponent<Rigidbody>();
        rb.velocity = Camera.main.transform.forward * speed;
    }

    // Update is called once per frame
    void Update()
    {
        timeleft -= Time.deltaTime;
        if (timeleft <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Target")
        {
            other.gameObject.SendMessage("Damage", 1);
        }
    }
}
