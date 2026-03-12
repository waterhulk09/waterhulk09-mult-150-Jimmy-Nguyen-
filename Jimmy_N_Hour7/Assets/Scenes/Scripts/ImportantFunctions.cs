using UnityEngine;

public class ImportantFunctions : MonoBehaviour
{
    //use this for initialization
    void Start()
    {
        print("Hello World");
        print("Start runs before an object Updates");
    }
    //Update is called per frame 

    void Update()

    {
        print("This is called once a frame");

    }
    public int runSpeed;
}
