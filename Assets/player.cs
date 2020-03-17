using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject playerbb;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - playerbb.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerbb.transform.position + offset;
    }
}
