using System;
public class CheckListGoal : Goal
{
    private int _goalPoints;
    private int _objective;

    private int _timesCompleted;
    private int _bonus;

    public CheckListGoal(string name, string description, int value, int objective, int bonus)
    {
        base.SetGoalType("3");
        base.SetGoalName(name);
        base.SetGoalDescription(description);
        base.SetGoalPoints(value.ToString());
        _objective = objective;
        _bonus = bonus;
    }

    public override string CheckCompletion(){
        return $"{base.GetCompleted()} {base.GetGoalName()} - {base.GetGoalDescription()} - {base.GetGoalPoints()} - {_objective}/{_timesCompleted} - {_bonus}";
    }
    public override void RecordEvent()
    {
        CalculateScore(_goalPoints);
        _timesCompleted++;
        if (objectiveMet() == true){
            base.SetCompleted("[X]");

        } else{
            base.SetCompleted("[]");
        }
    }

    protected bool objectiveMet(){
        if (_objective == _timesCompleted){
            return true;
        } else{
            return false;
        }
    }
    public override string CalculateScore(int score)
    {
        int scoreResult = _goalPoints += score;
        base.SetScore(scoreResult.ToString()) ;
        return base.GetScore();
    }
}