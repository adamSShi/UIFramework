using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameApplication : MonoBehaviour
{
    private static GameApplication singleton = null;
    public static GameApplication Singleton
    {
        get
        {
            // TODO: Automatic creation
            if (singleton == null)
                singleton = new GameApplication();

            return singleton;
        }
    }

    private void Awake()
    {
        if (singleton != null)
        {
            Debug.LogErrorFormat(this.gameObject, "Multiple instances of {0} is not allow", GetType().Name);
            return;
        }

        singleton = this;
        DontDestroyOnLoad(this.gameObject);
    }
}
