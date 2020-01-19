using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 50f;
    [SerializeField] float fallSpeed = 50f;
    [SerializeField] Transform player;

    // Update is called once per frame
    void Update()
    {
        Fall();
        HandleInput();
    }

    private void HandleInput()
    {
        player.position += new Vector3(
                    CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed * Time.deltaTime
                    , 0
                    , CrossPlatformInputManager.GetAxis("Vertical") * moveSpeed * Time.deltaTime);
    }

    private void Fall()
    {
        transform.position += new Vector3(
                    0
                    , -fallSpeed * Time.deltaTime
                    , 0);
    }
}
