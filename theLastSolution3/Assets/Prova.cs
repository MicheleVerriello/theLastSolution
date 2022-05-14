using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prova : MonoBehaviour {
    public Transform pippo;

    // Start is called before the first frame update
    void Start() {
        pippo = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update() {
        
    }
}
