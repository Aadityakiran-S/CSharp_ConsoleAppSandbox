using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        
    }

    public void PerBall(Ball currBall)
    {
        //Call other function to distribute the information in each ball
    }

    public class ScoreBoard
    {
        public Team battingTeam; public Team chasingTeam; 
        public ScoreManager scoreManager; public GameState currState;
        public int totalBalls; public int currBalls; public int totalRuns;

        public ScoreBoard(Team _battingTeam, Team _chasingTeam, int _totalBalls)
        {
            battingTeam = _battingTeam; chasingTeam = _chasingTeam;
            scoreManager = new ScoreManager(battingTeam, chasingTeam); //Pass in batting and chasing team and all that
            currState = GameState.BATTING; totalBalls = _totalBalls; currBalls = 0; totalRuns = 0;
        }

        //Function to execute the scoring per ball
        public void UpdateScorePerBall()
        {
            if(currState == GameState.BATTING)
            {
                //Update batting and chasing using ScoreManager for batting and chasing team
            }
            else
            {
                //Decrement from totalScore when chasing
            }

            DisplayScore();
        }

        public void DisplayScore()
        {
            //Log the score
        }
    }    

    public class ScoreManager
    {
        public Team battingTeam; public Team bowlingTeam;
        public ScoreManager(Team _battingTeam, Team _bowlingTeam) { battingTeam = _battingTeam; bowlingTeam = _bowlingTeam; }

        //Write function that will cause the per-ball information to be distributed among the batting and bowling teams
    }

    public class Team
    {
        //Conatins some batsmen and bowlers (or a list to keep them as they appear after each ball)
        LinkedList<Batsman> batsmen; LinkedList<Bowlwer> bowlwers;
        int currRuns;

        public Team() { this.batsmen = new();  this.bowlwers = new(); currRuns = 0; }

        public void UpdateBatsmen(/*Ball information*/)
        {
            
        }

        public void UpdateBowlers(/*Ball information*/)
        {

        }
    }

    public class Batsman
    {
        //Contains just the data of each batsman -> Runs, out by whom, 4s, 6s, strike rate....
    }

    public class Bowlwer
    {
        //Contains just the data of each bowlwer -> Balls, maidens, wickets, economy rate...
    }

    public struct Ball
    {
        public string currBatsman;
        public string currBowler;
        public BallState currState;
        public int currRuns;

        public Ball(string _currBatsman, string _currBowler, BallState _currState, int _currRuns)
        {
            currBatsman = _currBatsman; currBowler = _currBowler; currState = _currState; currRuns = _currRuns;
        }
    }

    public enum GameState
    {
        BATTING, CHASING
    }

    public enum BallState
    {
        WIDE_BALL, NO_BALL, REGULAR_BALL
    }
}