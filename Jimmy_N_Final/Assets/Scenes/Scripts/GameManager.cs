using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    public GoalScript normal,normal2,icy,icy2,slimy,slimy2,slow,slow2;
    private bool isGameOver = true;
    void Update()
    {
        // If all four goals are solved then the game is over
        isGameOver = icy.isSolved && slimy.isSolved &&
       normal.isSolved && slow.isSolved && icy2.isSolved && slimy2.isSolved &&
       normal2.isSolved && slow2.isSolved;
    }
    void OnGUI()
    {
        if (isGameOver)
        {
            Rect rect = new Rect(Screen.width / 2 - 100,
           Screen.height / 2 - 50, 200, 75);
            GUI.Box(rect, "Game Over");
            Rect rect2 = new Rect(Screen.width / 2 - 30,
           Screen.height / 2 - 25, 60, 50);
            GUI.Label(rect2, "Good Job!");
        }
    }



}

