using UnityEngine;



public class UsageOfNamedFile1 : MonoBehaviour
{
    public NamedFile1<UsageOfNamedFile1> File1 = new();

    private void Start()
    {
        File1.Log();
    }
}