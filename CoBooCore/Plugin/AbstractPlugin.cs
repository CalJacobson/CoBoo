using CoBooCore.Common;

namespace CoBooCore.Plugin
{
    public abstract class AbstractPlugin : IPlugin
    {
        protected string AuthorEmail;
        protected string AuthorFullName;
        protected string Description;
        protected string Homepage;
        protected string PluginName;
        protected VersionInformation VersionInfo;

        public string GetAuthor()
        {
            return AuthorFullName;
        }

        public string GetAuthorEmail()
        {
            return AuthorEmail;
        }

        public string GetDescription()
        {
            return Description;
        }

        public string GetHomepage()
        {
            return Homepage;
        }

        public string GetName()
        {
            return PluginName;
        }

        public VersionInformation GetVersionInfo()
        {
            return VersionInfo;
        }

        public abstract void OnPluginInitialized();

        public abstract void OnPluginLoaded();

        public abstract void OnPluginUnload();

        public abstract void OnUpdateCheck();
    }
}
