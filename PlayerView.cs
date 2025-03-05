using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    private Animator animator;

    private const string IS_RUNNING_RIGHT = "isRunningToRight";
    private const string IS_RUNNING_LEFT = "isRunningToLeft";
    private const string IS_RUNNING_UP = "isRunningToUp";
    private const string IS_RUNNING_DOWN = "isRunningToDown";

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        animator.SetBool(IS_RUNNING_RIGHT, Player.Instance.IsRunningToR());
        animator.SetBool(IS_RUNNING_LEFT, Player.Instance.IsRunningToL());
        animator.SetBool(IS_RUNNING_UP, Player.Instance.IsRunningToU());
        animator.SetBool(IS_RUNNING_DOWN, Player.Instance.IsRunningToD());
    }
}
