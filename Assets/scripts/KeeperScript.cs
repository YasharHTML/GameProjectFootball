using System;
using UnityEngine;

public class KeeperScript : MonoBehaviour
{
    private Vector3 start;
    void Start()
    {
        start = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = start + new Vector3(0.0f, 0.0f, 4f * Mathf.Sin(2 * Time.time));
    }
}
