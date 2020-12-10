using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Carz : MonoBehaviour
{
    public float velocidad = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var movimiento =Input.GetAxis("Horizontal");
        transform.position += new Vector3 (movimiento,0,0) *Time.deltaTime * velocidad ;   
    }
    void OnTriggerEnter2D (Collider2D col) 
    {
        if (col.tag == "Taxi")
        {
            Debug.Log("Perdiste");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Score.currentScore=0;
        }
    }
}
