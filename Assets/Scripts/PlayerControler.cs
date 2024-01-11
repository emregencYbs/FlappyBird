using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerControler : MonoBehaviour
{

    [SerializeField] float Hýz = 5;
    int score = 0;
    [SerializeField] GameObject scoreText;
    Rigidbody2D rgb;
    Touch dokunma;
    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
    }

 
    void Update()
    {
        if (Input.touchCount > 0) 
        { 
            dokunma = Input.GetTouch(0);
            if (dokunma.phase == TouchPhase.Began)
            {
                rgb.velocity = Vector2.up * Hýz;
            }
        }
      
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
        scoreText.GetComponent<TextMeshProUGUI>().text = score.ToString();
    }
}
