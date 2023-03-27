namespace StarWars.Domain;

public interface ICannonLoader
{
    int GetCannonCount(IReadOnlyList<uint> heights);
    IList<int> GetAllPositionPeaks(IReadOnlyList<uint> heights);
    bool IsPossibleToAllocateCannon(IList<int> peaks, int k);
}