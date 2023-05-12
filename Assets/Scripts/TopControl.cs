using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TopControl : MonoBehaviour
{
    Rigidbody2D rb;
    public float ziplamaKuvveti = 3f;
    bool basildiMi = false;

    public string mevcutRenk;
    public Color topunRengi;
    public Color turkuaz, sari, mor, pembe;
    [SerializeField] Text scoreText, bestScoreText;
    public static int score = 0;
    int bestScore = 0;

    public GameObject halka, renkTekeri;
    [SerializeField] private UIManager uiManager;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        if (uiManager.isStart==false)
        {
            return;
        }
        scoreText.text = "Score: " + score;
        RastgeleRenkBelirle();
        bestScore = PlayerPrefs.GetInt("BestScore");
        bestScoreText.text = "Best: " + bestScore;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            basildiMi = true;

        }
        if (Input.GetMouseButtonUp(0))
        {
            basildiMi = false;
        }
        if (transform.position.y <= -5)
        {
            score = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        NewBestScore(score);
    }

    private void FixedUpdate()
    {
        if (basildiMi)
        {
            rb.velocity = Vector2.up * ziplamaKuvveti;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "RenkTekeri")
        {
            RastgeleRenkBelirle();
            Destroy(collision.gameObject);
            return;
        }
        if (collision.tag != mevcutRenk && collision.tag != "PuanArttirici" && collision.tag != "RenkTekeri")
        {
            score = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (collision.tag=="PuanArttirici")
        {
            score += 5;
            scoreText.text = "Score: " + score;
            Destroy(collision.gameObject);

            Instantiate(halka, new Vector3(transform.position.x, transform.position.y + 8f, transform.position.z), Quaternion.identity);
            Instantiate(renkTekeri, new Vector3(transform.position.x, transform.position.y + 11f, transform.position.z), Quaternion.identity);
        }
    }

    void RastgeleRenkBelirle()
    {
        int rastgeleSayi = Random.Range(0, 4);
        switch (rastgeleSayi)
        {
            case 0:
                mevcutRenk = "Turkuaz";
                topunRengi = turkuaz;
                break;
            case 1:
                mevcutRenk = "Sari";
                topunRengi = sari;
                    break;
            case 2:
                mevcutRenk = "Mor";
                topunRengi = mor;
                    break;
            case 3:
                mevcutRenk = "Pembe";
                topunRengi = pembe;
                    break;
            
        }
        GetComponent<SpriteRenderer>().color = topunRengi;
    }

    public void NewBestScore(int newBestScore)
    {
        if (newBestScore > bestScore)
        {
            bestScore = newBestScore;
            PlayerPrefs.SetInt("BestScore", newBestScore);
        }
    }







}//class
