using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Player : MonoBehaviour
{

    private Animator animator;
    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        KeyboardHandler.OnKickKeyPressed += HandleKickKeyPressed;
        KeyboardHandler.OnJabKeyPressed += HandleJabKeyPressed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
            gameOver.SetActive(true);
            Time.timeScale = 0;
    }

    void HandleKickKeyPressed()
    {
        animator.SetBool("isJab", false);
        animator.SetBool("isKick", true);
        StartCoroutine(ResetKick());
    }   

    void HandleJabKeyPressed()
    {
        animator.SetBool("isKick", false);
        animator.SetBool("isJab", true);
        StartCoroutine(ResetJab());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator ResetKick()
    {
        yield return new WaitForSeconds(0.1f);
        animator.SetBool("isKick", false);
    }

    IEnumerator ResetJab()
    {
        yield return new WaitForSeconds(0.1f);
        animator.SetBool("isJab", false);
    }

}
