using ByteBank.Modelos;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string texto = "";

CuentaBancaria cuenta = new CuentaBancaria("123", "321");
cuenta.Saldo = 1000;
cuenta.RetirarDinero(100);

Console.WriteLine("El saldo de la cuenta es: " + cuenta.Saldo);