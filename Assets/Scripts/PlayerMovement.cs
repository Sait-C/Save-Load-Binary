using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector3 position;

    void Update()
    {
        position = position + new Vector3(1,1,1) * Time.deltaTime * 0.1f;

       transform.position = position;
    }
}
