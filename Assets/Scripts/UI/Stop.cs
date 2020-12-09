using UnityEngine;
using UnityEngine.UI;

public class Stop : MonoBehaviour
{
    public Controller Controller;
    public Controller controller;
    private Text text;

    private void Awake()
    {
        controller = Controller.GetComponent<Controller>();
        text = GetComponent<Text>();
    }

    private void Update()
    {
        //controller = GameObject.FindWithTag("Player").GetComponent<Controller>();

        if (controller.stop == true)
        {
            text.text = ("Stop on");
        }
        else if (controller.stop == false)
        {
            text.text = ("Stop off");
        }
    }
}