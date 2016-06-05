using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;

namespace Selkie.Common.Interfaces
{
    public interface IDisposer
    {
        [NotNull]
        string OwnerName { get; }

        bool IsDisposed { get; }

        [NotNull]
        T AddResource <T>([NotNull] T resource) where T : class, IDisposable;

        void AddResource([NotNull] Action disposeAction);

        [SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations")]
        void Dispose();

        [DebuggerNonUserCode]
        void VerifyNotDisposed();
    }
}