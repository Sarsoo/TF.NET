namespace TF.NET.MachineReadableUI.Constant;

public static partial class MruiConst
{
    public static class Type
    {
        /// <summary>
        /// information about the Terraform version and the version of the schema used for the following messages
        /// </summary>
        public const string Version = "version";
        /// <summary>
        /// unstructured human-readable log lines
        /// </summary>
        public const string Log = "log";
        /// <summary>
        /// diagnostic warning or error messages; see the terraform validate docs for more details on the format
        /// </summary>
        public const string Diagnostic = "diagnostic";

        public static class Init
        {
            /// <summary>
            /// unstructured human-readable log lines
            /// </summary>
            public const string Log = "log";
            /// <summary>
            /// Messages with init_output type have an additional message_code documented below.
            /// </summary>
            public const string Output = "init_output";
        }
    }

    /// <summary>
    /// A machine-readable UI command output will always begin with a version message. The following message-specific keys are defined
    /// </summary>
    public static class Version
    {
        /// <summary>
        /// the Terraform version which emitted this message
        /// </summary>
        public const string Terraform = "terraform";
        /// <summary>
        /// the machine-readable UI schema version defining the meaning of the following messages
        /// </summary>
        public const string Ui = "ui";
    }
}