using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - playerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targePos = playerTransform.position + offset;
        targePos.x = 0;
        transform.position = targePos;
    }
}
