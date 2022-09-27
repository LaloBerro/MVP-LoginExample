using System;

namespace MVPLoginExample.Presenters
{
    public interface ILoginView
    {
        Action OnClickOnLogin { get; set; }
        string GetPassword();
        string GetUsername();
    }
}