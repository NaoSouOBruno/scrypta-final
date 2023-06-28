using System;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour
{
    public GameObject enemyObject;
    public GameObject player;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == enemyObject)
        {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(2);
        }
    }
}
