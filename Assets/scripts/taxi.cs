using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taxi : MonoBehaviour
{
    public float velenemigo ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position -= new Vector3(0f,velenemigo * Time.deltaTime,0f);
        Destroy(gameObject, 6f);
    }
}
