using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CharacterView.Panel
{
    public class CashPanel : Panel
    {
        [SerializeField] Button workBtn;
        [SerializeField] Button travelBtn;
        [SerializeField] Button loanBtn;
        [SerializeField] Button backBtn;
        protected override void OnStart()
        {
            base.OnStart();
            workBtn.onClick.AddListener(OnWork);
            travelBtn.onClick.AddListener(OnTravel);
            loanBtn.onClick.AddListener(OnLoan);
            backBtn.onClick.AddListener(OnBack);
        }
        void OnBack()
        {
            HidePanel();
            UIManager.Instance.ShowPanel(PanelName.CharacterView);
            Print("Work");
        }
        void OnWork()
        {
            Print("Work");
        }
        void OnTravel()
        {
            Print("Travel");
        }
        void OnLoan()
        {
            Print("Loan");
        }
    }
}
