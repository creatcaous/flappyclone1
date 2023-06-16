using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public float jumppower;
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
       {
        rb.velocity = Vector2.up * jumppower;
       } 
    }
    private void OnCollisionEnter2D(Collision2D other) {
      if (Score.score > Score.bestScore) {
          Score.bestScore = Score.score;  
      }
        SceneManager.LoadScene("GameOverScene");
    }

}
