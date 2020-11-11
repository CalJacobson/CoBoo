using CoBooCore.Common;

namespace CoBooCore.Plugin
{
    public interface IPlugin
    {
        /// <summary>
        /// Returns the email of the plugin author.
        /// </summary>
        /// <returns>Plugin author's email address</returns>
        string GetAuthorEmail();

        /// <summary>
        /// Returns the plugin author's name.
        /// </summary>
        /// <returns>Full name of the plugin author</returns>
        string GetAuthor();

        /// <summary>
        /// Returns a description of the plugin.
        /// </summary>
        /// <returns>Description of the plugin</returns>
        string GetDescription();

        /// <summary>
        /// Returns the URL of the plugin's homepage.
        /// </summary>
        /// <returns>URL of the plugin's homepage</returns>
        string GetHomepage();

        /// <summary>
        /// Returns the name of the plugin.
        /// </summary>
        /// <returns>Name of the plugin</returns>
        string GetName();

        /// <summary>
        /// Returns version information for the plugin.
        /// </summary>
        /// <returns>Plugin version information</returns>
        VersionInformation GetVersionInfo();

        /// <summary>
        /// Called whenever the plugin is first initialized.
        /// </summary>
        void OnPluginInitialized();

        /// <summary>
        /// Called immediately after OnUpdateCheck().
        /// Intended for setup/connection to external (data) dependencies.
        /// </summary>
        void OnPluginLoaded();

        /// <summary>
        /// Called when the plugin is being unloaded (usually upon application shutdown).
        /// </summary>
        void OnPluginUnload();

        /// <summary>
        /// Called immediately after plugin initialization.
        /// Intended for update and version compatibility checks.  
        /// </summary>
        void OnUpdateCheck();
    }
}
