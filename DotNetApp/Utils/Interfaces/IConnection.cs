namespace DotNetApp.Utils.Interfaces
{
    public interface IConnection
    {
        /// <summary>
        /// Checks user's connection to Internet
        /// </summary>
        /// <returns>
        /// true if user is online, false if is not.
        /// </returns>
        bool hasInternetConnection();
    }
}
