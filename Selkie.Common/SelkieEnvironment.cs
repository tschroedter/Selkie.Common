using System;
using System.Diagnostics.CodeAnalysis;
using Selkie.Common.Interfaces;
using Selkie.Windsor;

namespace Selkie.Common
{
    [ExcludeFromCodeCoverage]
    [ProjectComponent(Lifestyle.Singleton)]
    public class SelkieEnvironment : ISelkieEnvironment
    {
        public string CurrentDirectory
        {
            get
            {
                return Environment.CurrentDirectory;
            }
        }

        public void Exit(int exitCode)
        {
            Environment.Exit(exitCode);
        }
    }
}