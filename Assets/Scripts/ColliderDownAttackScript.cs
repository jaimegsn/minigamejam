using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDownAttackScript : MonoBehaviour
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
        KeyboardHandler.OnKickKeyPressed += HandleKickKeyPressed;
        controller = FindObjectOfType<GameController>();
    }

    void HandleKickKeyPressed()
    {
        if (currentCollider!=null)
        {
            currentCollider.gameObject.SetActive(false);
            controller.Score++;
            controller.scoreText.text = controller.Score.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
