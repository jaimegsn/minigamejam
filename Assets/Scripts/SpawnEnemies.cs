using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject bat;
    public GameObject snake;
    public GameController controller;

    private bool isFirstTime = true;


    IEnumerator SpawnEnemy()
    {
        Enemies batScript = bat.GetComponent<Enemies>();
        Enemies snakeScript = snake.GetComponent<Enemies>();

        if (isFirstTime) {
            batScript.speed = 2;
            snakeScript.speed = 2;
            isFirstTime = false;
        }
        yield return new WaitForSeconds (3f);
        Instantiate(bat, new Vector2(Random.Range(14, 16), -3.36f), Quaternion.Euler(0f, 180f, 0f));
        Instantiate(snake, new Vector2(Random.Range(19, 25), -4.15f), Quaternion.identity);

        batScript.speed = batScript.speed + (controller.Score / 6);
        snakeScript.speed = snakeScript.speed + (controller.Score / 6);
        StartCoroutine(SpawnEnemy());
    }

    // Start is called before the first frame update
    void Start()
    {
        controller = FindObjectOfType<GameController>();
        StartCoroutine(SpawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
