using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MovimientoCesto : MonoBehaviour
{
    public int velocidad;
    public int score = 0;
    public int highscore = 0;

    public GameObject mostradorPuntaje;
    public GameObject mostradorHighScore;
    public GameObject contadorTiempo;

    public float tiempoRestante;

    public GameObject reiniciarLevel;
   

    // Start is called before the first frame update
    void Start()
    {
        mostradorPuntaje.GetComponent<Text>().text = "Puntaje: " + score.ToString();
        mostradorHighScore.GetComponent<Text>().text = "Highscore: " + highscore.ToString();
        
        /*if (score > highscore)
        {
            highscore = score;
        }*/
        

    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();

        if (tiempoRestante > 0)
        {
            tiempoRestante -= Time.deltaTime;
        }
        else
        {
            reiniciarLevel.SetActive(true);
        }

        contadorTiempo.GetComponent<Text>().text = "Tiempo: " + tiempoRestante.ToString("00");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Basketball")
        {
            score = score + 10;
            Destroy(collision.gameObject);
            mostradorPuntaje.GetComponent<Text>().text = "Puntaje: " + score.ToString();
        }
        
    }
   
    public void ReiniciarLevel()
    {
        tiempoRestante = 30;
        
        if (score > highscore)
        {
            highscore = score;
            score = 0;
        }
        mostradorHighScore.GetComponent<Text>().text = "Highscore: " + highscore.ToString();
        mostradorPuntaje.GetComponent<Text>().text = "Puntaje: " + score.ToString();
        reiniciarLevel.SetActive(false);

    }
    

    public void Movimiento ()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.up * Time.deltaTime * velocidad;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * Time.deltaTime * velocidad;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.up * Time.deltaTime * velocidad;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= transform.right * Time.deltaTime * velocidad;
        }
    }

}
