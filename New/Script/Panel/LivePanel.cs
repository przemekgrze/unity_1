using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CharacterView.Panel
{
    public class LivePanel : Panel
    {
        [SerializeField] Button terapiBtn;
        [SerializeField] Button revealBtn;
        [SerializeField] Button moralScandalBtn;
        [SerializeField] Button comingOutBtn;
        [SerializeField] Button revealCompromisingBtn;

        [SerializeField] Button backBtn;
        protected override void OnStart()
        {
            terapiBtn.onClick.AddListener(OnTerapi);
            revealBtn.onClick.AddListener(OnReveal);
            moralScandalBtn.onClick.AddListener(OnMoralScandal);
            comingOutBtn.onClick.AddListener(OnComingOut);
            revealCompromisingBtn.onClick.AddListener(OnRevealCompromising);

            backBtn.onClick.AddListener(OnBack);
        }
        void OnTerapi()
        {
            Print("Terapi");
        }
        void OnReveal()
        {
            Print("Reveal");
        }
        void OnMoralScandal()
        {
            Print("Moral Scandal");
        }
        void OnRevealCompromising()
        {
            Print("Reveal Compomising");
        }
        void OnComingOut()
        {
            Print("Coming Out");
        }
        void OnBack()
        {
            HidePanel();
            UIManager.Instance.ShowPanel(PanelName.CharacterView);
        }
    }
}
