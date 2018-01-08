using System;
using System.Diagnostics.CodeAnalysis;
using Core2.Selkie.Windsor;

namespace Core2.Selkie.Common
{
    [ExcludeFromCodeCoverage]
    public abstract class SelkieInstaller <T> // todo check why we need <T>
        : BaseInstaller <T>
        where T : class
    {
        public override bool IsAutoDetectAllowedForAssemblyName(string assemblyName)
        {
            return assemblyName.StartsWith("Core2.Selkie.",
                                           StringComparison.InvariantCulture);
        }
    }
}