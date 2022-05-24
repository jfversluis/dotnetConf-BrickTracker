using System.Collections.Generic;

namespace BrickTrackerMauiClient;

public class AppState
{
    public List<SetCollectionItem> SetCollections { get; set; } = new();
}
