using System;
using MVPLoginExample.Presenters;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MVPLoginExample.Views
{
    public class LoginView : MonoBehaviour, ILoginView
    {
        [Header("References")]
        [SerializeField] private TMP_InputField _userNameInputField;
        [SerializeField] private TMP_InputField _passwordInputField;
        [SerializeField] private Button _loginButton;

        public Action OnClickOnLogin { get; set; }

        private void Awake()
        {
            _loginButton.onClick.AddListener(() => { OnClickOnLogin?.Invoke(); });
        }

        public string GetUsername()
        {
            return _userNameInputField.text;
        }

        public string GetPassword()
        {
            return _userNameInputField.text;
        }
    }
}