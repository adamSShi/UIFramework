using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageManager : ManagerBase
{
    private List<PageBase> pages;

    private Stack<PageBase> pageOpenedStack = new Stack<PageBase>();

    private void Awake()
    {
        pages = UIManager.Instance.pages;
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            OpenPage(0);
        }
    }

    public void OpenPage(int pageIndex)
    {
        PageBase targetPage = pages[pageIndex];

        if(UIManager.Instance.pages.Count <= 0)
        {
            Debug.LogError("無任何頁面資料");
            return;
        }

        if (((PageName)pageIndex).ToString() != targetPage.name || pageOpenedStack.Count <= 0)
        {
            var page = Instantiate(targetPage, UIManager.Instance.gameCanvas.transform);
            pageOpenedStack.Push(page);
        }
        else
        {
            pageOpenedStack.Peek().gameObject.SetActive(true);
        }

        Debug.Log(pageOpenedStack.Count);
    }

    public void ClosePage()
    {
        pageOpenedStack.Pop();
        Debug.Log(pageOpenedStack.Count);
    }

    public enum PageName
    {
        TestMainPage = 0,
    }
}
