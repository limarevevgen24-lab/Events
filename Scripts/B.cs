using System;
using UnityEngine;

public class B : MonoBehaviour
{

    public static Action onStart;

    private void Start()
    {
        onStart?.Invoke();
    }
}
