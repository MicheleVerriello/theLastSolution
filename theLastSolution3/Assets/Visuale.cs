using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visuale : MonoBehaviour
{

    public Transform player;
    private float sensitivity = 100f;
    private float rotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Mouse X") * Time.deltaTime * sensitivity;
        float y = Input.GetAxis("Mouse Y") * Time.deltaTime * sensitivity;

        rotation -= y; //because rotation value are inverted
        rotation = Mathf.Clamp(rotation, -60f, )
        player.Rotate(Vector3.up * x);

    }
}
