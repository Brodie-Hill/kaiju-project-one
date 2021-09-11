using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationScriptController : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;
    int isRunningHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
    }

    // Update is called once per frame
    void Update()
    {
        bool isrunning = animator.GetBool(isRunningHash);
        bool isWalking = animator.GetBool(isWalkingHash);
        bool forwardPressed = Input.GetKey("d");
        bool runPressed = Input.GetKey("left shift");

        //if player presses D key
        if (!isWalking && forwardPressed)
        {
            // then set isWalking boolean to true
            animator.SetBool(isWalkingHash, true);
        }

        //if player does not press D key
        if (isWalking && !forwardPressed)
        {
            // then set isWalking boolean to false
            animator.SetBool(isWalkingHash, false);
        }

        //if player is walking and not running and presses left shift
        if (!isrunning && (forwardPressed && runPressed))
        {
            // then set isRunning boolean to true
            animator.SetBool(isRunningHash, true);
        }

        //if player is running or stops running or stops walking
        if (isrunning && (!forwardPressed || !runPressed))
        {
            // then set isRunning boolean to false
            animator.SetBool(isRunningHash, false);
        }
    }
}
