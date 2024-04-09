using System.Reflection;
using System.Security.Cryptography;

string _version = "";

var version = "1.0.0+LOCALBUILD";
var appAssembly = typeof(Program).Assembly;
if (appAssembly != null)
{
    var attrs = appAssembly.GetCustomAttribute(typeof(AssemblyInformationalVersionAttribute));
    if (attrs != null)
    {
        var infoVerAttr = (AssemblyInformationalVersionAttribute)attrs;
        if (infoVerAttr != null && infoVerAttr.InformationalVersion.Length > 6)
        {
            version = infoVerAttr.InformationalVersion;
        }
    }
}
if (version.Contains('+'))
{
    _version = version[..version.IndexOf('+')];
}
else
{
    _version = version;
}

Console.WriteLine(_version);