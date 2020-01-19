using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (FindObjectsOfType<MusicController>().Length == 1)
            DontDestroyOnLoad(this.gameObject);
        else
            Destroy(this.gameObject);
    }
}
