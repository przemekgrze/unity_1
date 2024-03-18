using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CharacterView.Panel
{
    [RequireComponent(typeof(CanvasGroup))]
    public class Panel : MonoBehaviour
    {
        public PanelName panelName;
        private CanvasGroup cg;
        private void Awake()
        {
            cg = GetComponent<CanvasGroup>();
            //HidePanel();
            OnAwake();
        }
        private void Start()
        {
            UIManager.Instance.RegisterPanel(this);
            OnStart();
        }
        protected virtual void OnAwake() { }
        protected virtual void OnStart() { }
        public void ShowPanel()
        {
            cg.alpha = 1.0f;
            cg.interactable = true;
            cg.blocksRaycasts = true;
        }
        public void HidePanel()
        {
            cg.alpha = 0f;
            cg.interactable = false;
            cg.blocksRaycasts = false;
        }
        protected void Print(string t)
        {
            Debug.Log($"On <color=yellow>{t}</color>");
        }
    }
}
