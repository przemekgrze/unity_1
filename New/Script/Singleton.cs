using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField] protected bool useDontDestroy;
    private static T instance;
    public static T Instance => instance;
    protected virtual void Awake()
    {
        if(instance == null)
        {
            instance = this as T;
            if(useDontDestroy)
                DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }

}
