namespace LeagueTable
{
    public class TableRow
    {
        public string TeamName { get; set; }
        public int Rank { get; set; }
        public int Wins { get; set; }
        public int Defeats { get; set; }
        public int Ties { get; set; }
        public int GoalsScored { get; set; }
        public int GoalsConceded { get; set; }

        public int GoalDifference
        {
            get { return this.GoalsScored - this.GoalsConceded; }
        }

        public int Points
        {
            get { return this.Wins * 3 + this.Ties; }
        }

        public override string ToString()
        {
            return
                $"{TeamName,20} {Rank,2} {Wins,2} {Defeats,2} {Ties,2} {GoalsScored,2} {GoalsConceded,2} {GoalDifference,2} {Points,2}";
        }
    }

    public class TableRowBuilder
    {
        private TableRow tableRow;


        public TableRowBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.tableRow = new TableRow();
        }

        public void SetTeamName(string teamName)
        {
            tableRow.TeamName = teamName;
        }

        public void SetRank(int rank)
        {
            tableRow.Rank = rank;
        }

        public void SetWins(int wins)
        {
            tableRow.Wins = wins;
        }

        public void SetDefeats(int defeats)
        {
            tableRow.Defeats = defeats;
        }

        public void SetTies(int ties)
        {
            tableRow.Ties = ties;
        }

        public void SetGoalsScored(int goalsScored)
        {
            tableRow.GoalsScored = goalsScored;
        }

        public void SetGoalsConceded(int goalsConceded)
        {
            tableRow.GoalsConceded = goalsConceded;
        }

        public TableRow GetTableRow()
        {
            var result = this.tableRow;

            this.Reset();

            return result;
        }
    }
}