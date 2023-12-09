using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMainPage : PageBase
{
    PageManager pageManager;
    // Start is called before the first frame update
    private void Awake()
    {
        pageManager = UIManager.Instance.GetManager<PageManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)) 
        {
            Close();
        }
    }

    protected override void Close()
    {
        base.Close();
        //pageManager.ClosePage();
        this.gameObject.SetActive(false);
    }

    protected override void ReceiveMesseage(params object[] messageArray)
    {
        base.ReceiveMesseage(messageArray);
    }
}
