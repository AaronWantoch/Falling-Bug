using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carousel : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 30f;

    private void Update()
    {
        float rotationThisFrame =  rotationSpeed * Time.deltaTime;


        transform.Rotate(
                transform.localRotation.x,
                transform.localRotation.y + rotationThisFrame,
                transform.localRotation.z);
    }
}
