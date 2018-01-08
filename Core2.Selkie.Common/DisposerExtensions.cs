using System;
using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;

namespace Core2.Selkie.Common
{
    [ExcludeFromCodeCoverage]
    public static class DisposerExtensions
    {
        [CanBeNull]
        public static T AddTo <T>([NotNull] this T resource,
                                  [NotNull] Disposer disposer) where T : class, IDisposable
        {
            return disposer.AddResource(resource);
        }

        public static void AddTo([NotNull] this Action disposeAction,
                                 [NotNull] Disposer disposer)
        {
            disposer.AddResource(disposeAction);
        }
    }
}