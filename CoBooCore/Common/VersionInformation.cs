using System;

namespace CoBooCore.Common
{
    public class VersionInformation
    {
        private Version PluginVersion;
        private ReleaseType PluginReleaseType;

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="version">Version of the plugin</param>
        /// <param name="releaseType">Release type of the plugin</param>
        public VersionInformation(Version version, ReleaseType releaseType)
        {
            PluginVersion = version;
            PluginReleaseType = releaseType;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Returns the ReleaseType of the plugin
        /// </summary>
        /// <returns>The plugin's release type</returns>
        public ReleaseType GetReleaseType()
        {
            return PluginReleaseType;
        }

        /// <summary>
        /// Returns the plugin's current version.
        /// </summary>
        /// <returns>Plugin version information</returns>
        public Version GetVersion()
        {
            return PluginVersion;
        }

        /// <summary>
        /// Maximum version of CoBoo that this plugin will support.
        /// </summary>
        public Version MaximumSupportedApplication { get; set; }

        /// <summary>
        /// Minimum version of CoBoo that this plugin will support.
        /// </summary>
        public Version MinimumSupportedApplication { get; set; }

        /// <summary>
        /// A human-friendly nickname for the current plugin's version.
        /// </summary>
        public string VersionNickname { get; set; }
        #endregion
    }

    public enum ReleaseType
    {
        Unknown,
        Stable,
        PreRelease
    }
}
