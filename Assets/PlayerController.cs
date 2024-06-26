using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            playerAnim.SetBool("Walk", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            playerAnim.SetBool("Walk", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerAnim.SetBool("Slash", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            playerAnim.SetBool("Slash", false);
        }

    }
}
