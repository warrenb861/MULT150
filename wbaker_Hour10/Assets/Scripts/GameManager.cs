using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GoalScript blue, green, red, orange, chaos;
    private bool isGameOver = false;

    public float time = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved && chaos.isSolved;
        if (!isGameOver)
            time += Time.deltaTime;
    }

    void OnGUI()
    {
        if(isGameOver)
        {
            Rect rect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
            GUI.Box(rect, "Game Over!");
            Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
            GUI.Label(rect2, "Good Job!\nTime: "+((int)time).ToString());
        } else
        {
            Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height / 10 - 25, 60, 25);
            GUI.Box(rect2, "Time: "+((int)time).ToString());
        }
    }
}
