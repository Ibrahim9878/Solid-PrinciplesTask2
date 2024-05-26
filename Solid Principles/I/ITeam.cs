namespace Solid_Principles.I;
#region BadWay
//public interface ITeam
//{
//    public void ControlTeam();
//    public void GenerateCode();
//    public void TakeInterView();
//}
//public class TeamMember : ITeam
//{
//    public void ContolTeam()
//    {
//        do something
//    }
//    public void GenerateCode()
//    {
//        do something
//    }
//    public void TakeInterView()
//    {
//        do Something
//    }
//}
//public class TeamLead : ITeam
//{
//    public void ContolTeam()
//    {
//        do something
//    }
//    public void GenerateCode()
//    {
//        do something
//    }
//    public void TakeInterView()
//    {
//        do Something
//    }
//}
#endregion
#region GoodWay
public interface ITeamMember
{
    public void GenerateCode();
}
public interface ITeamLead
{
    public void ControlTeam();
    public void TakeInterView();
}
public class TeamMember : ITeamMember
{
    public void GenerateCode()
    {
        //do something
    }
}
public class TeamLead : ITeamLead, ITeamMember
{
    public void ContolTeam()
    {
        //do something
    }
    public void GenerateCode()
    {
        //do something
    }
    public void TakeInterView()
    {
        //do Something 
    }
}
#endregion
