using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : Singleton<UIManager>
{
    public Canvas gameCanvas;

    public List<PageBase> pages;

    private PageManager pageManager;

    //PageManager

    private UIManager()
    {
    }

    protected override void Awake()
    {
        base.Awake();
    }

    protected override void Initinalize()
    {
        base.Initinalize();

        SetCanvas();

        string resultMesseage = gameCanvas != null ? "成功" : "失敗";

        Debug.Log($"UIManager初始化{resultMesseage}");

        this.gameObject.AddComponent<PageManager>();
    }

    private void SetCanvas()
    {
        gameCanvas.renderMode = RenderMode.ScreenSpaceOverlay;

        CanvasScaler canvasScaler = gameCanvas.GetComponent<CanvasScaler>();

        canvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        canvasScaler.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
        canvasScaler.referenceResolution = new Vector2(1920, 1080);
    }

    public T GetManager<T>() where T : ManagerBase
    {
        T manager = UIManager.Instance.GetComponent<T>();
        return manager;
    }
} 
