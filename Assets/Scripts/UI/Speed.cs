using UnityEngine;
using UnityEngine.UI;

public class Speed : MonoBehaviour
{
    public new Rigidbody rigidbody;
    public Rigidbody rb;
    private Text text;

    private void Awake()
    {
        text = GetComponent<Text>();
        rb = rigidbody.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        //rb = GameObject.FindWithTag("Player").GetComponent<Rigidbody>();
        text.text = string.Format("Speed {0:0.00}m/s", rb.velocity.magnitude);
    }
}