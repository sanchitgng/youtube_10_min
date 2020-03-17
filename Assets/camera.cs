using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    Rigidbody rb;
    float speed = 100;
    float moveHori;
    float moveVer;
    AudioSource audio;
    public GameObject particleFX;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveHori = Input.GetAxis("Horizontal");
        moveVer = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHori, 0, moveVer);
        rb.AddForce(movement * speed);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pickables"))
        {
            other.gameObject.SetActive(false);
            audio.Play();
            Instantiate(particleFX, transform.position, Quaternion.identity);

        }
    }
}
