using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningObject : MonoBehaviour
{

    public float spinSpeed = 30f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
    }
}
