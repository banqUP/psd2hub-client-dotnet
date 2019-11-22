namespace Psd2Hub.Sdk
{
    internal interface IServiceLocator
    {
        TService Get<TService>();
    }
}
