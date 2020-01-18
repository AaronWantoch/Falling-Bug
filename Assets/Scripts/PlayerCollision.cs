using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] float dyingDelay = 3f;
    ParticleSystem deathFX;

    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(Die());
    }

    IEnumerator Die()
    {
        deathFX = GetComponentInChildren<ParticleSystem>();
        deathFX.Play();
        GetComponent<AudioSource>().Play();

        GetComponent<PlayerMovement>().enabled = false;
        yield return new WaitForSeconds(dyingDelay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
