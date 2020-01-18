using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishHandler : MonoBehaviour
{
    [SerializeField] GameObject victoryScreen;
    [SerializeField] GameObject music;

    private void OnTriggerEnter(Collider other)
    {
        victoryScreen.SetActive(true);
        music.SetActive(false);
        Time.timeScale = 0f;
    }

}
