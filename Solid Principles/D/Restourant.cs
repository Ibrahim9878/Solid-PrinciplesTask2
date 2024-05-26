namespace Solid_Principles.D;

#region BadWay
//public class Afsiant
//{

//}
//public class Restourant
//{
//    public List<Afsiant> employers;
//    public Restourant()
//    {
//        employers = new();
//    }

//    public void CleanTheRoom()
//    {
//        //do something
//    }
//}
#endregion

#region GoodWay
public interface IEmployer
{
    public void CleanTheRoom();
}
public class Restourant
{
    public List<IEmployer> employers;
    public Restourant()
    {
        employers = new();
    }
}
#endregion
