using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayControl : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public int score;
    public Text scoreText;
    public Text winText;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
        SetScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");  //x
        float moveVertical = Input.GetAxis("Vertical");  //z

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("item"))
        {
            other.gameObject.SetActive(false);
            score++;
            SetScoreText();
        }

    }
    void SetScoreText()
    {
        scoreText.text = "Score : " + score.ToString();
        if (score >= 3)
        {
            winText.text = "You Win!";
        }

    }
}