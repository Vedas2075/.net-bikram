// WAP to define converter

namespace Inheritance;
public class converter
{
    // 12cm -> ? inch

    public double fromUnitValue;

    public double toUnitValue;

}
    public class LengthConverter : converter
    {
         public double convert(string fromUnit,string toUnit)
         {
             if(fromUnit = "cm"&&toUnit == "m")
             {
                 return fromUnitValue/100;
             }
             else if(fromUnit == "m" && toUnit == "cm")
             {
                 return fromUnitValue*100;
             }
             else{
                 return 0;
             }
         }
    }