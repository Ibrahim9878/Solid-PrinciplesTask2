namespace Solid_Principles.O;

#region BadWay
//bu pis yoldur cunki isciler basqa is gorerken yeni bir isci daxil olarsa evvelkki iscilerin isinde deisiklik olacaq
//public class PlayStore
//{
//    public List<string> Employers { get; set; }
//    public void DoJob()
//    {
//        //do something
//    }
//    public void AddEmployers(string e)
//    {
//        Employers.Add(e);
//    }
//}
#endregion
#region GoodWay
public class PlayStore
{
    public List<string> Employers { get; set; }
    public void AddEmployers(string e)
    {
        Employers.Add(e);
    }
}
public class EmployersJob:PlayStore
{
    public void DoJob()
    {
        Employers.ForEach(e => { });
        //do something
    }
}
#endregion
