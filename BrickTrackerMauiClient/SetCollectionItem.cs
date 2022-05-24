using BrickSummary;

namespace BrickTrackerMauiClient;

public class SetCollectionItem
{
    public BrickSetCollection SetCollection { get; set; }
    public bool FromFileSystem { get; set; }
    public string FilePath { get; set; }
}
