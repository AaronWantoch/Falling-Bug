using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 50f;
    [SerializeField] float fallSpeed = 50f;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(
            CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed * Time.deltaTime
            , -fallSpeed * Time.deltaTime
            ,CrossPlatformInputManager.GetAxis("Vertical") * moveSpeed * Time.deltaTime);
    }
}
