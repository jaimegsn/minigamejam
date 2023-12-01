using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderUpAttackScript : MonoBehaviour
{
    private Collider2D currentCollider;
    public GameController controller;

    void OnTriggerEnter2D(Collider2D target)
     {
         if (target.tag == "Enemy")
         {
            currentCollider = target;
         }
     }

    private void OnTriggerExit2D(Collider2D target)
    {
        if (target == currentCollider)
        {
            currentCollider = null;
        }
    }


    void Start()
    {
        KeyboardHandler.OnJabKeyPressed += HandleJabKeyPressed;
        controller = FindObjectOfType<GameController>();
    }

    void HandleJabKeyPressed()
    {
        if (currentCollider!=null && controller!= null)
        {
            currentCollider.gameObject.SetActive(false);
            controller.Score++;
            controller.scoreText.text = controller.Score.ToString();
        }
        Debug.Log("Controller nulo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
