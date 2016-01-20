using System.Diagnostics.CodeAnalysis;
using Selkie.Windsor;

namespace Selkie.Common
{
    [ExcludeFromCodeCoverage]
    public abstract class SelkieInstaller <T> // todo check why we need <T>
        : BaseInstaller <T>
        where T : class
    {
        public override string GetPrefixOfDllsToInstall()
        {
            return "Selkie.";
        }
    }
}