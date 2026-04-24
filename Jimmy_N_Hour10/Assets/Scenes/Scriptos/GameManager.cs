using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    public GoalScript blue, teal, salmon, pink, icyslow, icy, Sslow, Sfast;
    private bool isGameOver = true;
    void Update()
    {
        // If all four goals are solved then the game is over
        isGameOver = blue.isSolved && teal.isSolved &&
       salmon.isSolved && pink.isSolved && icyslow.isSolved && icy.isSolved && Sslow.isSolved && Sfast.isSolved;
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

