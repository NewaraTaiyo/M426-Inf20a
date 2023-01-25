using System;

namespace LeagueTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new TableRowBuilder();
            builder.SetTeamName("Liverpool");
            TableRow liverpool = builder.GetTableRow();

            builder.SetTeamName("Arsenal London");
            builder.SetRank(2);
            builder.SetDefeats(1);
            builder.SetGoalsConceded(3);
            TableRow arsenal = builder.GetTableRow();

            // alternative Implementierung mit fluent Syntax.
            var builderFluent = new TableRowBuilderFluent();
            TableRow manchester = builderFluent
                .SetTeamName("Manchester City")
                .SetRank(3)
                .SetDefeats(2)
                .SetGoalsScored(1)
                .SetGoalsConceded(4)
                .Build();
            Console.WriteLine($"{"Team",20} {"#",2} {"W",2} {"D",2} {"T",2} {"+",2} {"'",2} {"=",2} {"P",2}");
            Console.WriteLine(liverpool);
            Console.WriteLine(arsenal);
            Console.WriteLine(manchester);
        }
    }
}