using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishHandler : MonoBehaviour
{
    [SerializeField] GameObject victoryScreen;
    GameObject music;

    private void OnTriggerEnter(Collider other)
    {
        victoryScreen.SetActive(true);

        FindObjectOfType<MusicController>().gameObject.SetActive(false);
        GetComponent<AudioSource>().Play();

        Time.timeScale = 0f;
    }

}
