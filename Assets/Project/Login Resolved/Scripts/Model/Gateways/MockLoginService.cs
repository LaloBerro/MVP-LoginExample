using MVPLoginExample.Model.Entities;
using MVPLoginExample.Model.UseCases;
using UnityEngine;

namespace MVPLoginExample.Model.Gateways
{
    public class MockLoginService : IService<UserLoginData>
    {
        private string _correctUser = "Lalo";
        private string _correctPassword = "MVP1234";

        public void Send(UserLoginData userLoginData)
        {
            bool areCredentialsEquals = AreCreditialsEquals(userLoginData.Username, userLoginData.Password);

            if (areCredentialsEquals)
            {
                Debug.Log("Login Success");
                return;
            }

            Debug.Log("The password or the username is wrong");
        }

        private bool AreCreditialsEquals(string username, string password)
        {
            bool isCorrectUser = string.Equals(username, _correctUser);
            bool isCorrectPassword = string.Equals(username, _correctUser);

            if (isCorrectPassword && isCorrectUser)
                return true;

            return false;
        }
    }
}