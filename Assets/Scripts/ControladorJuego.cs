using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControladorJuego : MonoBehaviour
{
    public GameObject gameObject;
    public Character character;
    public Text zombiesMuertos;
    public Text tiempoDuracion;
    public float tiempo;
    public bool reinicia = false;

    // Update is called once per frame
    void Update()
    {
        if (character.vida > 0)
        {
            tiempo += Time.deltaTime;
        }
        else
        {
            if (!reinicia)
            {
                reinicia = true;
                StartCoroutine(CargarEscena());
            }
        }
    }

    IEnumerator CargarEscena()
    {
        gameObject.SetActive(true);
        zombiesMuertos.text = "" + character.zombiesMuertos;
        tiempoDuracion.text = "" + tiempo;
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
