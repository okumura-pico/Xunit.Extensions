using System;
using System.IO;

namespace Xunit.Extensions;

public class TemporaryFolderFixture : IDisposable
{
    private bool _disposedValue;

    public TemporaryFolderFixture()
    {
        FolderPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        Directory.CreateDirectory(FolderPath);
    }

    public string FolderPath { get; private set; }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            new DirectoryInfo(FolderPath).Delete(true);
            // TODO: set large fields to null
            _disposedValue = true;
        }
    }

    // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
    ~TemporaryFolderFixture()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: false);
    }

    void IDisposable.Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}