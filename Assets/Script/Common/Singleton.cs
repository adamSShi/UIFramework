using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    static T m_instance = null;

    public static T Instance
    {
        get { return m_instance; }
    }

    static public T GetInstance()
    {
        return m_instance;
    }

    protected virtual void Awake()
    {
        if (m_instance != null)
            Destroy(gameObject);
        else
        {
            m_instance = (T)this;
            Debug.Log($"³Ð«Ø{m_instance.name}§¹²¦");
        }
            

        DontDestroyOnLoad(this.gameObject);

        Initinalize();
    }

    protected virtual void OnDestroy()
    {
        if (m_instance == this)
        {
            m_instance = null;
        }
    }

    protected virtual void Initinalize() { }
}