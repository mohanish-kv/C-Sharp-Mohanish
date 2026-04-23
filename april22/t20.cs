using System;

class T20match
{
    static void Main()
    {
        int teams = 2;
        int overs = 20;
        int balls = 6;
        int maxWickets = 10;

        int[,] score = new int[teams, overs * balls]; 
        int[] totalScore = new int[teams];
        int[] wickets = new int[teams];

        Random rnd = new Random();

        for (int team = 0; team < teams; team++)
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine("Team " + (team + 1) + " Batting");
            Console.WriteLine("==============================");

            for (int over = 0; over < overs; over++)
            {
                if (wickets[team] == maxWickets)
                    break;

                Console.WriteLine("\nOver " + (over + 1));

                for (int ball = 0; ball < balls; ball++)
                {
                    if (wickets[team] == maxWickets)
                        break;

                    int result = rnd.Next(0, 8); 
                    score[team, over * balls + ball] = result;

                    if (result == 7)
                    {
                        wickets[team]++;
                        Console.WriteLine("Ball " + (ball + 1) + ": WICKET! (Total Wickets: " + wickets[team] + ")");
                    }
                    else
                    {
                        totalScore[team] += result;
                        Console.WriteLine("Ball " + (ball + 1) + ": " + result + " runs");
                    }

                    if (team == 1 && totalScore[1] > totalScore[0])
                    {
                        Console.WriteLine("\nTeam 2 has chased the target!");
                        break;
                    }
                }

                if (team == 1 && totalScore[1] > totalScore[0])
                    break;
            }

            Console.WriteLine("\nTeam " + (team + 1) + " Final Score:");
            Console.WriteLine("Runs: " + totalScore[team] + " | Wickets: " + wickets[team]);
        }

        Console.WriteLine("\n==============================");
        Console.WriteLine("FINAL RESULT");
        Console.WriteLine("==============================");

        if (totalScore[0] > totalScore[1])
            Console.WriteLine("Team 1 Wins!");
        else if (totalScore[1] > totalScore[0])
            Console.WriteLine("Team 2 Wins!");
        else
            Console.WriteLine("Match Draw!");
    }
}
