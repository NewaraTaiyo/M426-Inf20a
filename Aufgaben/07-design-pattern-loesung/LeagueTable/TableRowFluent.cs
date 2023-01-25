namespace LeagueTable
{
    public class TableRowBuilderFluent
    {
        private TableRow tableRow;


        public TableRowBuilderFluent()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.tableRow = new TableRow();
        }

        public TableRowBuilderFluent SetTeamName(string teamName)
        {
            tableRow.TeamName = teamName;
            return this;
        }

        public TableRowBuilderFluent SetRank(int rank)
        {
            tableRow.Rank = rank;
            return this;
        }

        public TableRowBuilderFluent SetWins(int wins)
        {
            tableRow.Wins = wins;
            return this;
        }

        public TableRowBuilderFluent SetDefeats(int defeats)
        {
            tableRow.Defeats = defeats;
            return this;
        }

        public TableRowBuilderFluent SetTies(int ties)
        {
            tableRow.Ties = ties;
            return this;
        }

        public TableRowBuilderFluent SetGoalsScored(int goalsScored)
        {
            tableRow.GoalsScored = goalsScored;
            return this;
        }

        public TableRowBuilderFluent SetGoalsConceded(int goalsConceded)
        {
            tableRow.GoalsConceded = goalsConceded;
            return this;
        }

        public TableRow Build()
        {
            var result = this.tableRow;

            this.Reset();

            return result;
        }
    }
}