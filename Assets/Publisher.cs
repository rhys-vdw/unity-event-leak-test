using UnityEngine;
using System;
using System.Collections;

public class Publisher : MonoBehaviour
{
    public Subscriber SubscriberPrefab;
    public event Action<string> OnTest;

    public IEnumerator Start()
    {
        var subscriber = Instantiate(SubscriberPrefab);
        subscriber.Inititalize(nameof(subscriber), this);
        var method = (Action) subscriber.Method;

        yield return null;

        OnTest("Created");
        Debug.Log($"subscriber = {subscriber}, method = {method}");
        method();

        Destroy(subscriber.gameObject);

        yield return null;

        OnTest("Destroyed");
        Debug.Log($"subscriber = {subscriber}, method = {method}");
        method();
    }
}
