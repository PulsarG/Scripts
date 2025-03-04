using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    private Animator animator;

    private const string IS_RUNNING = "isRunning";

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
            animator.SetBool(IS_RUNNING, Player.Instance.IsRunning());
    }
}
