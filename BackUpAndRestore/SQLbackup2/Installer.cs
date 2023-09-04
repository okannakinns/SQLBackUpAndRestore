using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace SQLbackup2
{
    [RunInstaller(true)]
    public partial class Installer : System.Configuration.Install.Installer
    {
        public Installer()
        {
            InitializeComponent();
        }
        [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand)]
        public override void Install(IDictionary stateSaver)
        {
            base.Install(stateSaver);
            SetDirectorySecurity();
        }
        private void SetDirectorySecurity()
        {
            string targetdir = Path.GetDirectoryName(Context.Parameters["targetdir"]);
            Log("Adding modify rights for " + targetdir);
            var dSecurity = Directory.GetAccessControl(targetdir, AccessControlSections.Access);
            var domainSid = new SecurityIdentifier("S-1-0-0");
            var ident = new SecurityIdentifier(WellKnownSidType.BuiltinUsersSid, domainSid);
            var accessRule1 = new FileSystemAccessRule(ident, FileSystemRights.Modify, InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow);
            var accessRule2 = new FileSystemAccessRule(ident, FileSystemRights.Modify, InheritanceFlags.ContainerInherit, PropagationFlags.None, AccessControlType.Allow);
            dSecurity.AddAccessRule(accessRule1);
            dSecurity.AddAccessRule(accessRule2);
            Directory.SetAccessControl(targetdir, dSecurity);
            Log("Rights added.");
        }

        private void Log(string message)
        {
            Context.LogMessage(message);
            System.Diagnostics.Trace.WriteLine(message, "1177 client installer");
        }
    }
}
