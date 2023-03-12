using System;
public class SimpleGoal : Goal
{
    private int _goalPoints;

    public SimpleGoal(string name, string description, int value)
    {
        base.SetGoalType("1");
        base.SetGoalName(name);
        base.SetGoalDescription(description);
        base.SetGoalPoints(value.ToString());
    }

    public override string CheckCompletion(){
        return $"{base.GetCompleted()} {base.GetGoalName()} - {base.GetGoalDescription()} - {base.GetGoalPoints()}";
    }
    public override void RecordEvent()
    {
        CalculateScore(_goalPoints);
        base.SetCompleted("[X]");
    }
    public override string CalculateScore(int score)
    {
        int scoreResult = _goalPoints += score;
        base.SetScore(scoreResult.ToString()) ;
        return base.GetScore();
    }
}