using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilator : MonoBehaviour
{
    [SerializeField] Vector3 movementVector = new Vector3(10f, 10f, 10f);
    [SerializeField] float period = 2f;

    float movementFactor;
    //0 for not moved, 1 for fully moved

    Vector3 startingPosition;

    float startingTime;

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
        startingTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject();
    }

    private void MoveObject()
    {
        if (period >= Mathf.Epsilon)
        {
            float cycles = (Time.time - startingTime) / period;
            const float tau = Mathf.PI * 2;

            float sinWave = Mathf.Sin((cycles * tau) / 2);
            movementFactor = Mathf.Abs(sinWave);

            Vector3 offset = movementVector * movementFactor;
            transform.position = startingPosition + offset;
        }

    }
}
