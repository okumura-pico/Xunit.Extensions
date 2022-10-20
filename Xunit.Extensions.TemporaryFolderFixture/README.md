# Xunit.Extensions.TemporaryFolderFixture;

## Usage

```c#
public class MyCase : IClassFixture<TemporaryFolderFixture>
{
    private readonly string _tmpFolderPath;

    public MyCase(TemporaryFolderFixture fixture)
    {
        _tmpFolderPath = fixture.FolderPath;
    }
}
```
