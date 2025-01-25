using System;
using System.ComponentModel;

namespace سست.Loader
{
    /// <summary>
    /// The configs of the loader.
    /// </summary>
    public sealed class Config : IConfig
    {
        /// <inheritdoc />
        [Description("Whether DZCP is enabled on this server.")]
        public bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        [Description("Whether debug messages should be shown.")]
        public bool Debug { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether outdated DZCP versions should be loaded.
        /// </summary>
        [Description("Indicates whether outdated DZCP versions should be loaded.")]
        public bool ShouldLoadOutdatedDZCP { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether outdated plugins should be loaded.
        /// </summary>
        [Description("Indicates whether outdated plugins should be loaded.")]
        public bool ShouldLoadOutdatedPlugins { get; set; } = true;

        /// <summary>
        /// Gets or sets the environment type.
        /// </summary>
        [Description("The working environment type (Development, Testing, Production, Ptb, ProductionDebug).")]
        public EnvironmentType Environment { get; set; } = EnvironmentType.Production;

        /// <summary>
        /// Gets or sets the config files distribution type.
        /// </summary>
        [Description("The config files distribution type (Default, Separated)")]
        public ConfigType ConfigType { get; set; } = ConfigType.Default;

        /// <summary>
        /// Gets or sets the quotes wrapper type.
        /// </summary>
        [Description("Indicates in which quoted strings in configs will be wrapped (Any, SingleQuoted, DoubleQuoted, Folded, Literal).")]
        public ScalarStyle ScalarStyle { get; set; } = ScalarStyle.SingleQuoted;

        /// <summary>
        /// Gets or sets the quotes wrapper type.
        /// </summary>
        [Description("Indicates in which quoted strings with multiline in configs will be wrapped (Any, SingleQuoted, DoubleQuoted, Folded, Literal).")]
        public ScalarStyle MultiLineScalarStyle { get; set; } = ScalarStyle.Literal;

        /// <summary>
        /// Gets or sets a value indicating whether testing releases have to be downloaded.
        /// </summary>
        [Description("Indicates whether testing releases have to be downloaded.")]
        public bool ShouldDownloadTestingReleases { get; set; } = false;

        /// <summary>
        /// Gets or sets which assemblies should be excluded from the update.
        /// </summary>
        [Description("Indicates which assemblies should be excluded from the updater.")]
        public string[] ExcludeAssemblies { get; set; } = Array.Empty<string>();

        /// <summary>
        /// Gets or sets a value indicating whether DZCP should auto-update itself as soon as a new release is available.
        /// </summary>
        [Description("Indicates whether DZCP should auto-update itself as soon as a new release is available.")]
        public bool EnableAutoUpdates { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether to enable experimental features.
        /// </summary>
        [Description("Indicates whether to enable experimental features.")]
        public bool EnableExperimentalFeatures { get; set; } = false;

        /// <summary>
        /// Gets or sets the maximum number of concurrent downloads.
        /// </summary>
        [Description("The maximum number of concurrent downloads.")]
        public int MaxConcurrentDownloads { get; set; } = 5;

        /// <summary>
        /// Gets or sets the timeout for network operations in seconds.
        /// </summary>
        [Description("The timeout for network operations in seconds.")]
        public int NetworkTimeout { get; set; } = 30;

        /// <summary>
        /// Gets or sets a value indicating whether to enable logging to a file.
        /// </summary>
        [Description("Indicates whether to enable logging to a file.")]
        public bool EnableFileLogging { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether to enable backup of old versions before updating.
        /// </summary>
        [Description("Indicates whether to enable backup of old versions before updating.")]
        public bool EnableBackupBeforeUpdate { get; set; } = true;
    }

     

    /// <summary>
    /// Represents the environment type.
    /// </summary>
    public enum EnvironmentType
    {
        Development,
        Testing,
        Production,
        Ptb,
        ProductionDebug
    }

    /// <summary>
    /// Represents the config files distribution type.
    /// </summary>
    public enum ConfigType
    {
        Default,
        Separated
    }

    /// <summary>
    /// Represents the scalar style for quoted strings.
    /// </summary>
    public enum ScalarStyle
    {
        Any,
        SingleQuoted,
        DoubleQuoted,
        Folded,
        Literal
    }

    /// <summary>
    /// Represents the configuration interface.
    /// </summary>
    public interface IConfig
    {
    }
}