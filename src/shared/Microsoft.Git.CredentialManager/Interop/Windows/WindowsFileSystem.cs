using System;
using System.IO;

namespace Microsoft.Git.CredentialManager.Interop.Windows
{
    public class WindowsFileSystem : FileSystem
    {
        public override bool IsSamePath(string a, string b)
        {
            a = Path.GetFileName(a);
            b = Path.GetFileName(b);

            return StringComparer.OrdinalIgnoreCase.Equals(a, b);
        }
    }
}
