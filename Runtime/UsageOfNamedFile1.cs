using UnityEngine;

public class UsageOfNamedFile1 : MonoBehaviour
{
    public ReNamedFile1<UsageOfNamedFile1> File1 = new();

    private void Start()
    {
        File1.Log();
    }
}
