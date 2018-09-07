using System;

/// <summary>
/// ¡Programa para aprender el patrón Observer!
/// Notar que cuando se desea crear una carpeta Program y otra Library, se utiliza dotnet new console -n Program y
///  dotnet new classLib -n Library -f netcoreapp2.1. De lo contrario,
/// </summary>
namespace Observer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TemperatureReporter tempRep = new TemperatureReporter(); //Observador
            TemperatureMonitor tempMon = new TemperatureMonitor(); //Proveedor

            tempRep.Subscribe(tempMon);
            tempMon.GetTemperature();
        }
    }
}
