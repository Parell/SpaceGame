using UnityEngine;
using UnityEngine.UI;

public class Throttle : MonoBehaviour
{
    public Controller Controller;
    public Controller controller;
    private Text text;

    private void Awake()
    {
        text = GetComponent<Text>();
        controller = Controller.GetComponent<Controller>();
    }

    private void Update()
    {
        //controller = GameObject.FindWithTag("Player").GetComponent<Controller>();
        text.text = string.Format("Throttle {0}", (controller.throttle * 100.0f).ToString("000"));
    }
}