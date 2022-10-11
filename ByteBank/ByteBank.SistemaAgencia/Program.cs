using Humanizer;
using ByteBank.Modelos;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string getIntervaloFechas(DateTime fechaPago, DateTime fechaActual)
{

    TimeSpan diferencia = fechaPago - fechaActual;
    
    return "Faltan " + TimeSpan.FromDays(diferencia.Days).Humanize(maxUnit: Humanizer.Localisation.TimeUnit.Month) + " para hacer el pago";
}

CuentaBancaria cuenta = new CuentaBancaria("123", "321");

DateTime fechaPago = new DateTime(2023,01,30);
DateTime fechaActual = DateTime.Now;



Console.WriteLine(getIntervaloFechas(fechaPago,fechaActual));


Console.ReadLine();

