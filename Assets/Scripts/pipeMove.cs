using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMove : MonoBehaviour
{
    [SerializeField] float H�z = 2.5f;
    void Start()
    {
        Destroy(gameObject,20f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position +=Vector3.left * H�z * Time.deltaTime;
    }
}
