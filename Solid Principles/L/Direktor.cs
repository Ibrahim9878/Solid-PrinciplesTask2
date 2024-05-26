namespace Solid_Principles.L;

#region GoodWay
public class Direktor
{
    public string SchoolName { get; set; }
    public void MeetOtherSchools(string schoolName)
    {
        //do something
    }
    public virtual void LookToClasses(string schoolName)
    {
        //do something
    }
}
public class Zavuc : Direktor
{
    public override void LookToClases(string schoolName)
    {
        // do something
    }
}
#endregion