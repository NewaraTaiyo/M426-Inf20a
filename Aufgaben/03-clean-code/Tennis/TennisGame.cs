using static System.Formats.Asn1.AsnWriter;

namespace Tennis {
    public class TennisGameManager {
        private int pointsPlayerOne = 0;
        private int pointsPlayerTwo = 0;
        private string scorePlayerOne = "";
        private string scorePlayerTwo = "";
        private string namePlayerOne = "";
        private string namePlayerTwo = "";

        public TennisGameManager(string namePlayerOne, string namePlayerTwo) {
            this.namePlayerOne = namePlayerOne;
            this.namePlayerTwo = namePlayerTwo;
        }

        public string Score_Getter() {
            string gameScore = "";

            scorePlayerOne = defineScore(pointsPlayerOne);
            scorePlayerTwo = defineScore(pointsPlayerTwo);

            defineSpecialScoreForPlayerOne();
            defineSpecialScoreForPlayerTwo();

            gameScore = scorePlayerOne + "-" + scorePlayerTwo;

            if ((pointsPlayerOne == pointsPlayerTwo) && (pointsPlayerOne > 2)) {
                gameScore = "Deuce";
            }

            gameScore = getPlayerWithAdvantage(gameScore);

            gameScore = returnWinForPlayerIfWon(gameScore);
            return gameScore;
        }

        private void defineSpecialScoreForPlayerOne() {
            if ((pointsPlayerTwo > 0) && (pointsPlayerOne == 0)) {
                scorePlayerOne = "Love";
            }
        }

        private void defineSpecialScoreForPlayerTwo() {
            if ((pointsPlayerOne == pointsPlayerTwo) && (pointsPlayerOne < 3)) {
                scorePlayerTwo = "All";
            }
            else if ((pointsPlayerOne > 0) && (pointsPlayerTwo == 0)) {
                scorePlayerTwo = "Love";
            }
        }

        private string defineScore(int pointsPlayer) {
            string gameScore = "";
            if (pointsPlayer == 0) {
                gameScore = "Love";
            } else if (pointsPlayer == 1) {
                gameScore = "Fifteen";
            } else if (pointsPlayer == 2) {
                gameScore = "Thirty";
            } else if (pointsPlayer == 3) {
                gameScore = "Forty";
            }

            return gameScore;
        }

        private string getPlayerWithAdvantage(string gameScore) {
            string playerWithAdvantage = gameScore;
            if ((pointsPlayerOne > pointsPlayerTwo) && (pointsPlayerTwo >= 3)) {
                playerWithAdvantage = "Advantage player1";
            } else if ((pointsPlayerTwo > pointsPlayerOne) && (pointsPlayerOne >= 3)) {
                playerWithAdvantage = "Advantage player2";
            }
            return playerWithAdvantage;
        }

        public string returnWinForPlayerIfWon(string gameScore) {
            if (((pointsPlayerOne >= 4) && (pointsPlayerTwo >= 0)) && ((pointsPlayerOne - pointsPlayerTwo) >= 2)){
                gameScore = "Win for player1";
            } else if (((pointsPlayerTwo >= 4) && (pointsPlayerOne >= 0)) && ((pointsPlayerTwo - pointsPlayerOne) >= 2)) {
                gameScore = "Win for player2";
            }
            return gameScore; 
        }

        public void wonPoint(string player) {
            if (player == namePlayerOne) {
                pointsPlayerOne++;
            } else {
                pointsPlayerTwo++;
            }
        }

    }
}

