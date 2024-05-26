namespace Solid_Principles.S;

#region BadWay
//public class Programmer
//{
//    public string Code { get; set; }
//    public string Xaladenik { get; set; }
//    public void GenerateCode(string code)
//    {
//        Code = code;
//    }
//    public void FixXaladenik(string xaladenik)
//    {
//        this.Xaladenik = xaladenik;
//    }
//}
#endregion
#region GoodWay
public class Programmer
{
    public string code{ get; set; }
    public void GenerateCode(string code)
    {
        this.code = code;
    }
}
public class XaladenikUstasi
{
    public string xaladenik { get; set; }
    public void FixXaladenik(string xaladenik)
    {
        this.xaladenik = xaladenik;
    }
}

#endregion
