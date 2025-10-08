using UnityEngine;

public class A : MonoBehaviour
{

    private void OnEnable()
    {
        B.onStart += message;
    }

    private void OnDisable()
    {
        B.onStart -= message;
    }

    public void message()
    {
        Debug.Log("Started");
    }







} 
