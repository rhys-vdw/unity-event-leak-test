using UnityEngine;

public class Subscriber : MonoBehaviour
{
    string _name;

    public void Inititalize(string name, Publisher publisher)
    {
        _name = name;
        publisher.OnTest += HandleTest;
    }

    public void Method() {
        Debug.Log($"{_name}: {this}");
    }

    void HandleTest(string text)
    {
        Debug.Log($"{_name}: {text}");
    }
}
