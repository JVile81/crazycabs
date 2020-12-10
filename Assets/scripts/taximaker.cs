using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taximaker : MonoBehaviour
{ 
    public GameObject Taxis;
    float randomx ;
    Vector2 posicion;
    public float spamrate =2f;
    float nextspawn = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextspawn){
            if(Score.currentScore > 10){
                spamrate=spamrate-0.001f;
            }
            nextspawn = Time.time + spamrate;
            randomx = Random.Range(-1.3f,1.3f);
            posicion = new Vector2(randomx, transform.position.y);
            Instantiate(Taxis, posicion, Quaternion.identity);
        }
    }
}
