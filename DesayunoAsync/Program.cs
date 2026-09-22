using DesayunoAsync.Services;
using DesayunoAsync.Models;

DesayunoSincronoService sincrono = new DesayunoSincronoService();
DesayunoAsincronoMalService asincrinomal =  new DesayunoAsincronoMalService();
DesayunoAsincronoBienService asincrinobien =  new DesayunoAsincronoBienService();
Desayuno desayno = new Desayuno();

//Creamos 2 ya que si ocurre un cancelacon, se cancela para siempre
CancellationTokenSource ctsMal = new CancellationTokenSource();
CancellationTokenSource ctsBien = new CancellationTokenSource();

Console.WriteLine("========================== PREPARANDO DESAYUNO SINCRONO =============================");
sincrono.PrepararDesayuno();
if (desayno.Cancel.Equals(true))
{
    
    Console.WriteLine("DESAYUNO LISTO");
}
else
{
    Console.WriteLine("Desayuno cancelado");
}



Console.WriteLine("\n ============================== PREPARANDO DESAYUNO ASINCRONO MALLLLLLL ============================");
try
{
    await asincrinomal.PrepararDesayunoAsync(ctsMal);
    Console.WriteLine("DESAYUNO LISTO");
}
catch (OperationCanceledException)
{
    Thread.Sleep(1000);
    Console.WriteLine("Desayuno cancelado");
}

Thread.Sleep(1000);
Console.WriteLine("\n ============================== PREPARANDO DESAYUNO ASINCRONO PRO ============================");
try
{
    await asincrinobien.PrepararDesayunoAsync(ctsBien);
    Console.WriteLine("DESAYUNO LISTO");
}
catch (OperationCanceledException)
{
    Thread.Sleep(1000);
    Console.WriteLine("Desayuno cancelado");
}




