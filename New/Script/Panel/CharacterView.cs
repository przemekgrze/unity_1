using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace CharacterView.Panel
{
    public class CharacterView : Panel
    {
        [SerializeField] Button cashBtn;
        [SerializeField] Button postBtn;
        [SerializeField] Button bodyBtn;
        [SerializeField] Button lifeBtn;
        [SerializeField, Header("RIGHT GROUP")] Button followerBtn;
        [SerializeField] Button cashRightBtn;
        [SerializeField] Button mentalHealtBtn;
        [SerializeField] Button publicPerceptiontBtn;
        [SerializeField] Button hateBtn;
        [SerializeField, Header("LEFT GROUP")] Button gameModeBtn;
        [SerializeField] Button holidayBtn;
        [SerializeField] Button standartBtn;
        [SerializeField] Button dubaiBtn;
        protected override void OnStart()
        {
            InitBtn();
        }
        void InitBtn()
        {
            cashBtn.onClick.AddListener(OnCash);
            postBtn.onClick.AddListener(OnPost);
            bodyBtn.onClick.AddListener(OnBody);
            lifeBtn.onClick.AddListener(OnLife);
            //Right
            followerBtn.onClick.AddListener(OnFollower);
            cashRightBtn.onClick.AddListener(OnRightCash);
            mentalHealtBtn.onClick.AddListener(OnMentalHealt);
            publicPerceptiontBtn.onClick.AddListener(OnPublicPerception);
            hateBtn.onClick.AddListener(OnHate);
            //Left
            gameModeBtn.onClick.AddListener(OnGameMode);
            holidayBtn.onClick.AddListener(OnHoliday);
            standartBtn.onClick.AddListener(OnStandart);
            dubaiBtn.onClick.AddListener(OnDubai);
        }
        #region CENTER
        void OnCash()
        {
            HidePanel();
            UIManager.Instance.ShowPanel(PanelName.Cash);
            Print("Cash");
        }
        void OnPost()
        {
            Print("Post");
        }
        void OnBody()
        {
            Print("Body");
        }
        void OnLife()
        {
            Print("Life");
            HidePanel();
            UIManager.Instance.ShowPanel(PanelName.Life);
        }
        #endregion

        #region RIGHT
        void OnFollower()
        {
            Print("Follower");
        }
        void OnRightCash()
        {
            Print("Right Cash");
        }
        void OnMentalHealt()
        {
            Print("MentalHealt");
        }
        void OnPublicPerception()
        {
            Print("PublicPerception");
        }
        void OnHate()
        {
            Print("Hate");
        }
        #endregion

        #region LEFT
        void OnGameMode()
        {
            Print("Game Mode");
            HidePanel();
            UIManager.Instance.ShowDefaultPanel();
        }
        void OnHoliday()
        {
            Print("Holiday");
        }
        void OnStandart()
        {
            Print("Standart");
        }
        void OnDubai()
        {
            Print("Dubai");
        }
        #endregion
    }
}
