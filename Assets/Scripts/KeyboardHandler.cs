using System;
using UnityEngine;

public class KeyboardHandler : MonoBehaviour
{
    public static event Action OnKickKeyPressed;
    public static event Action OnJabKeyPressed;

    // Update is called once per frame
    void Update()
    {
        // Verifica as teclas pressionadas e notifica os eventos correspondentes
        if (Input.GetKeyDown(KeyCode.S))
        {
            OnKickKeyPressed?.Invoke();
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            OnJabKeyPressed?.Invoke();
        }
    }
}
