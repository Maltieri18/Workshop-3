using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{

    [Range(0.0f, 1000.0f)] public float speed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition = new Vector3(10.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.parent.position, Vector3.up, speed * Time.deltaTime);
    }
}
