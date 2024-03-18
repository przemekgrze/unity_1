using CharacterView.Panel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    List<Panel> panelList = new List<Panel>();
    [SerializeField] PanelName defaultPanel;
    protected override void Awake()
    {
        base.Awake();
        panelList = new List<Panel>();
    }
    //void Start()
    //{
        
    //}
    public void RegisterPanel(Panel p)
    {
        if (panelList.Contains(p))
            Debug.LogError($"Duplicate Panel At :<color=yellow>{p.gameObject.name}</color>, panelName:<color=yellow>{p.panelName}</color>");
        else
        {
            panelList.Add(p);
            if (p.panelName == defaultPanel)
                p.ShowPanel();
            else
                p.HidePanel();
        }
    }
    public void ShowDefaultPanel()
    {
        ShowPanel(defaultPanel);
    }
    public void ShowPanel(PanelName p)
    {
        var panel = panelList.Find(x => x.panelName == p);
        if(panel == null)
            Debug.LogError($"Panel <color=yellow>{p}</color> Not Registered");
        else
            panel.ShowPanel();
    }
    public void HidePanel(PanelName p)
    {
        var panel = panelList.Find(x => x.panelName == p);
        if (panel == null)
            Debug.LogError($"Panel <color=yellow>{p}</color> Not Registered");
        else
            panel.HidePanel();
    }
}
public enum PanelName
{
    Main,
    CharacterView,
    Cash,
    Life,
    None
}
