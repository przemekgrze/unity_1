using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CharacterView.Panel
{
    public class MainPanel : Panel
    {
        [SerializeField] Button gameModeBtn;
        protected override void OnStart()
        {
            Inits();
        }
        void Inits()
        {
            gameModeBtn.onClick.AddListener(OnGameMode);
        }
        void OnGameMode()
        {
            HidePanel();
            UIManager.Instance.ShowPanel(PanelName.CharacterView);
        }
    }
}
