using StarWars.Domain;

namespace StarWars.Test;

public class IsPossibleToAllocateCannonTest
{
    private readonly ICannonLoader _cannonLoader;
    private IList<int> _peaks;
    public IsPossibleToAllocateCannonTest()
    {
        _cannonLoader = new CannonLoader();
        _peaks = new List<int>();
    }

    [Theory]
    [InlineData(new int[] { 1, 3, 5 }, 3, false)]
    public void Should_Get_False_3_Peaks_3_Cannons(
            IList<int> peaks,
            int cannons,
            bool result
        )
    {
        bool isPossibleToAllocate = _cannonLoader.IsPossibleToAllocateCannon(peaks, cannons);
        isPossibleToAllocate.Should().Be(result);
    }

    [Theory]
    [InlineData(new int[] {2, 4, 6, 10, 13, 16, 20, 23, 27, 32,
            34, 37, 39, 41, 43, 45, 48, 50, 53, 57, 59,
            63, 65, 67, 70, 73, 75, 78, 80, 82, 86, 89,
            91, 95, 98, 101, 103, 105, 107, 109, 112, 115,
            119, 122, 124, 127, 130, 133, 135, 137, 139,
            141, 143, 148, 150, 152, 154, 157, 159, 161,
            163, 165, 168, 170, 172, 178, 180, 183, 186,
            188, 190, 192, 195, 198 }, 15, false)]
    public void Should_Get_False_74_Peaks_15_Cannons(
            IList<int> peaks,
            int cannons,
            bool result
        )
    {
        bool isPossibleToAllocate = _cannonLoader.IsPossibleToAllocateCannon(peaks, cannons);
        isPossibleToAllocate.Should().Be(result);
    }

    [Theory]
    [InlineData(new int[] {2, 4, 6, 10, 13, 16, 20, 23, 27, 32,
            34, 37, 39, 41, 43, 45, 48, 50, 53, 57, 59,
            63, 65, 67, 70, 73, 75, 78, 80, 82, 86, 89,
            91, 95, 98, 101, 103, 105, 107, 109, 112, 115,
            119, 122, 124, 127, 130, 133, 135, 137, 139,
            141, 143, 148, 150, 152, 154, 157, 159, 161,
            163, 165, 168, 170, 172, 178, 180, 183, 186,
            188, 190, 192, 195, 198 }, 14, true)]
    public void Should_Get_True_74_Peaks_14_Cannons(
            IList<int> peaks,
            int cannons,
            bool result
        )
    {
        bool isPossibleToAllocate = _cannonLoader.IsPossibleToAllocateCannon(peaks, cannons);
        isPossibleToAllocate.Should().Be(result);
    }

    [Theory]
    [InlineData(new int[] {2, 4, 6, 10, 13, 16, 20, 23, 27, 32,
            34, 37, 39, 41, 43, 45, 48, 50, 53, 57, 59,
            63, 65, 67, 70, 73, 75, 78, 80, 82, 86, 89,
            91, 95, 98, 101, 103, 105, 107, 109, 112, 115,
            119, 122, 124, 127, 130, 133, 135, 137, 139,
            141, 143, 148, 150, 152, 154, 157, 159, 161,
            163, 165, 168, 170, 172, 178, 180, 183, 186,
            188, 190, 192, 195, 198 }, 13, true)]
    public void Should_Get_True_74_Peaks_13_Cannons(
           IList<int> peaks,
           int cannons,
           bool result
       )
    {
        bool isPossibleToAllocate = _cannonLoader.IsPossibleToAllocateCannon(peaks, cannons);
        isPossibleToAllocate.Should().Be(result);
    }

    [Theory]
    [InlineData(new int[] { 1, 5, 10}, 3, true)]
    public void Should_Get_True_3_Peaks_3_Cannons(
            IList<int> peaks,
            int cannons,
            bool result
        )
    {

        bool isPossibleToAllocate = _cannonLoader.IsPossibleToAllocateCannon(peaks, cannons);
        isPossibleToAllocate.Should().Be(result);
    }

    [Theory]
    [InlineData(new int[] { 1, 3, 5, 10 }, 3, true)]
    public void Should_Get_True_4_Peaks_3_Cannons(
            IList<int> peaks,
            int cannons,
            bool result
        )
    {

        bool isPossibleToAllocate = _cannonLoader.IsPossibleToAllocateCannon(peaks, cannons);
        isPossibleToAllocate.Should().Be(result);
    }

    [Theory]
    [InlineData(new int[] { 1, 3, 5, 10 }, 4, false)]
    public void Should_Get_False_4_Peaks_4_Cannons(
            IList<int> peaks,
            int cannons,
            bool result
        )
    {

        bool isPossibleToAllocate = _cannonLoader.IsPossibleToAllocateCannon(peaks, cannons);
        isPossibleToAllocate.Should().Be(result);
    }

    [Theory]
    [InlineData(new int[] { 1 }, 1, true)]
    public void Should_Get_True_1_Peak_1_Cannon(
        IList<int> peaks,
        int cannons,
        bool result
        )
    {

        bool isPossibleToAllocate = _cannonLoader.IsPossibleToAllocateCannon(peaks, cannons);
        isPossibleToAllocate.Should().Be(result);
    }

    [Theory]
    [InlineData(new int[] { 1 }, 3, false)]
    public void Should_Get_False_1_Peak_3_Cannons(
        IList<int> peaks,
        int cannons,
        bool result
        )
    {

        bool isPossibleToAllocate = _cannonLoader.IsPossibleToAllocateCannon(peaks, cannons);
        isPossibleToAllocate.Should().Be(result);
    }

    [Theory]
    [InlineData(new int[] { }, 0, true)]
    public void Should_Get_True_0_Peak_0_Canonns(
        IList<int> peaks,
        int cannons,
        bool result
        )
    {

        bool isPossibleToAllocate = _cannonLoader.IsPossibleToAllocateCannon(peaks, cannons);
        isPossibleToAllocate.Should().Be(result);
    }

}



 