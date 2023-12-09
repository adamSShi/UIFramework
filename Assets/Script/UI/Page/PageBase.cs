using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageBase : MonoBehaviour
{
    protected virtual void ReceiveMesseage(params object[] messageArray)
    {

    }

    protected virtual void Close()
    {
    }
}
