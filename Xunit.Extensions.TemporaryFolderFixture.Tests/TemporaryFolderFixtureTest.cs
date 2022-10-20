namespace Xunit.Extensions;

public class TemporaryFolderFixtureTest
{
    [Fact]
    public void TestCreateAndDelete()
    {
        // Given
        string folderPath = null!;

        // When
        using (var fixture = new TemporaryFolderFixture())
        {
            folderPath = fixture.FolderPath;

            // Then
            // It exists
            Assert.True(new DirectoryInfo(folderPath).Exists);
        }

        // Then
        // It not exists
        Assert.False(new DirectoryInfo(folderPath).Exists);
    }
}
