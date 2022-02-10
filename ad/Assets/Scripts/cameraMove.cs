using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public Transform player;
    private Vector3 offeset;
    // Start is called before the first frame update
    void Start()
    {
        offeset = transform.position - player.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offeset;


    }
}
