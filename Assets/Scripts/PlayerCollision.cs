using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] float dyingDelay = 3f;

    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(Die());
    }

    IEnumerator Die()
    {
        //Play Death Particles and Sound

        GetComponent<PlayerMovement>().enabled = false;
        yield return new WaitForSeconds(dyingDelay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
