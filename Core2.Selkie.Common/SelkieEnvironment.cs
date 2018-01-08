using System;
using System.Diagnostics.CodeAnalysis;
using Core2.Selkie.Common.Interfaces;
using Core2.Selkie.Windsor;

namespace Core2.Selkie.Common
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