using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D rig;
    public Score scoreText;
    public Score shadowText;

    public GameObject GameOver;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rig.velocity = Vector2.up * speed;
            SoundManager.PlaySound ("fly"); 
        }
    }

    void OnCollisionEnter2D(Collision2D colisor)
    {
        GameOver.SetActive(true);
        Time.timeScale = 0;
        SoundManager.PlaySound ("die"); 
    }

    private void OnTriggerEnter2D(Collider2D colider)
    {
        if (colider.CompareTag("Cano"))
        {
            print("Score Up!");
            scoreText.ScoreUp();
            shadowText.ScoreUp();
            SoundManager.PlaySound ("points"); 
        }
    }
    
    
}
