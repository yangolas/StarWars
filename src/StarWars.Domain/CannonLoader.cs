namespace StarWars.Domain;

public class CannonLoader : ICannonLoader
{
    /// <summary>
    /// Get the count of the max possibles cannons
    /// </summary>
    /// <param name="heightsList"></param>
    /// <returns></returns>
    public int GetCannonCount(IReadOnlyList<uint> heightsList) 
    {
        IList<int> peaksPosition = GetAllPositionPeaks(heightsList);

        int maxPeaks = peaksPosition.Count();
        int maxDistance = heightsList.Count();

        //If distance is 2 is impossible to form a peak
        if(maxDistance <= 2) 
        {
            return 0;
        }

        //Only is necesary to interact, for searching the minimum number of cannons
        //between the upper bound of peaks distance,
        //and upper bound of square(distance - 2) "-2"
        //because the init and end distance are not peaks.
        int maxCannons = Math.Min(
            maxPeaks, 
            (int)Math.Sqrt(maxDistance)
        );

        int minimumCannons = 0;

        //The first possibility true is the max number of cannon
        //because, we iteract from maximum to the minimum possible
        for (int cannons = maxCannons; cannons > 0; cannons--)
        {
            bool IsPossibleToAllocate = IsPossibleToAllocateCannon(peaksPosition, cannons);

            if (IsPossibleToAllocate)
            {
                return cannons;
            }
        }

        return minimumCannons;
    }

    /// <summary>
    /// Get all the peaks position
    /// </summary>
    /// <param name="heights"></param>
    /// <returns></returns>
    public IList<int> GetAllPositionPeaks(IReadOnlyList<uint> heights) 
    {
        int firstIndex = 1;
        int lastIndex = heights.Count() - 2;

        IList<int> peaks = new List<int>();

        for (int index = firstIndex; index <= lastIndex; index++)
        {
            uint previous = heights[index - 1];
            uint next = heights[index + 1];

            if (previous < heights[index]
                && next < heights[index]
            ) 
            {
                peaks.Add(index);
            }
        }

        return peaks;
    }

    /// <summary>
    /// Get if it is possible to allocate K cannons in
    /// that distance
    /// </summary>
    /// <param name="peaksParameter"></param>
    /// <param name="cannons"></param>
    /// <returns></returns>
    public bool IsPossibleToAllocateCannon(IList<int> peaksParameter, int cannons)
    {
        List<int> peaks = new List<int>();
        peaks.AddRange(peaksParameter);
        
        int index = 0;

        //we prepared a array within the max number of cannons
        //possible for that distance and number of cannons
        //if one peak is not possible insert on the sequence
        //then remove it other wise we continue with the next peak
        while(index < peaks.Count() - 1) 
        { 
            int current = peaks[index];
            int next = peaks[index + 1];

            if((current + cannons) > next) 
            {
                peaks.Remove(next);
            }
            else 
            {
                index++;
            }
        }

        bool IsPossibleLocationCannon = peaks.Count() >= cannons? 
            true : false;

        return IsPossibleLocationCannon;

    }

}