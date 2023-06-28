using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EventManager : MonoBehaviour
{
    public GameObject objetoPrefab;
    public Transform spawnPoint;
    public Transform spawnPoint2;
    public float tempoEntreEventos = 5f;
    public float contador = 0;
    private GameObject eventoAtual;
    private string ultimoEvento = "";

    public Transform jogador;
    public Vector3 posicaoDesejada;
    public Vector3 posicaoDesejada2;


    void Start()
    {
        Invoke("RandomEvent", tempoEntreEventos);
    }

    void Contador()
    {
        contador = contador + 1;
    }

    void RandomEvent()
    {

        float randomValue = Random.value;

        if (randomValue < 0.5f)
        {
            if (ultimoEvento != "A")
            {
                InvokeRepeating("Contador", 1f, 1f);
                eventoAtual = Instantiate(objetoPrefab, spawnPoint.position, spawnPoint.rotation);
                ultimoEvento = "A";
            }
            else
            {
                RandomEvent();
                return;
            }
        }

        else
        {
            if (ultimoEvento != "B")
            {
                InvokeRepeating("Contador", 1f, 1f);
                eventoAtual = Instantiate(objetoPrefab, spawnPoint2.position, spawnPoint2.rotation);
                ultimoEvento = "B";
            }

            else
            {
                RandomEvent();
                return;
            }
        }

        Invoke("RandomEvent", tempoEntreEventos);
    }

    void Update()
    {
        float distanciaLimite = 2f;
        float distanciaLimite2 = 2f;


            if (contador >= 12)
        {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(3);
        }

        if (Input.GetKeyDown(KeyCode.E) && ultimoEvento == "B" && Vector3.Distance(jogador.position, posicaoDesejada) <= distanciaLimite)
        {
            CancelInvoke("Contador");
            contador = 0;
            Destroy(eventoAtual);
            ultimoEvento = "";
            eventoAtual = null;
        }

        if (Input.GetKeyDown(KeyCode.E) && ultimoEvento == "A" && Vector3.Distance(jogador.position, posicaoDesejada2) <= distanciaLimite2)
        {
            CancelInvoke("Contador");
            contador = 0;
            Destroy(eventoAtual);
            ultimoEvento = "";
            eventoAtual = null;
        }
    }
}