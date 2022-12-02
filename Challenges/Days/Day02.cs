namespace Challenges.Days;

public class Day02 : Day<(char, char)[], int>
{
    private static int WinLoseDraw(int them, int us)
    {
        if (us == them)
            return 3;
        if (us - them == 1 || them - us == 2)
            return 6;
        if (us - them == 2 || them - us == 1)
            return 0;
        throw new Exception("This shouldn't happen");
    }

    public override int Part1((char, char)[] puzzleInput)
    {
        var ourScore = 0;
        foreach (var (them, us) in puzzleInput)
        {
            var themPiece = them == 'A' ? 1 : them == 'B' ? 2 : 3;
            var usPiece = us == 'X' ? 1 : us == 'Y' ? 2 : 3;
            ourScore += usPiece + WinLoseDraw(themPiece, usPiece);
        }

        return ourScore;
    }

    public int CalcOurPiece(int them, char outcome)
    {
        switch (outcome)
        {
            case 'Y':
                return them;
            case 'X':
                return them - 1 == 0 ? 3 : them - 1;
            case 'Z':
                return (them % 3) + 1;
        }

        throw new Exception("This shouldn't happen");
    }
    
    public override int Part2((char, char)[] puzzleInput)
    {
        var ourScore = 0;
        foreach (var (them, outcome) in puzzleInput)
        {
            var themPiece = them == 'A' ? 1 : them == 'B' ? 2 : 3;
            var usPiece = CalcOurPiece(themPiece, outcome);
            ourScore += usPiece + WinLoseDraw(themPiece, usPiece);
        }

        return ourScore;
    }

    public override (char, char)[] PreprocessData(string[] puzzleInput)
    {
        return puzzleInput.Select(x => (x[0], x[2])).ToArray();
    }
}