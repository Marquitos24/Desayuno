using System.Diagnostics;
using DesayunoAsync.Models;
using DesayunoAsync.Utils;

namespace DesayunoAsync.Services;

public class DesayunoAsincronoService 
{
    CancelarDesayuno cancelar = new CancelarDesayuno();
    private Desayuno desayuno;

    public DesayunoAsincronoService(Desayuno desayuno)
    {
        this.desayuno = desayuno;
    } 
    
     public async Task Cafe(CancellationToken token)
    {
        Console.WriteLine("Preparando cafe...");
        var tiempo = TimeSpan.FromSeconds(3);
        await Task.Delay(tiempo, token);
    }

    public async Task CalentarSarten(CancellationToken token)
    {
        Console.WriteLine("Calentando sarten...");
        var tiempo = TimeSpan.FromSeconds(3);
        await Task.Delay(tiempo, token);
    }

    public async Task MeterHuevosSarten(CancellationToken token)
    {
        Console.WriteLine("Haciendo huevos en la sarten...");
        var tiempo = TimeSpan.FromSeconds(4);
        await Task.Delay(tiempo, token);
    }

    public async Task MeterBaconSarten(CancellationToken token)
    {
        Console.WriteLine("Calentando Beacon...");
        var tiempo = TimeSpan.FromSeconds(3);
        await Task.Delay(tiempo, token);
    }

    public async Task PonerPanTostadora(CancellationToken token)
    {
        Console.WriteLine("Calentando el pan en la tostadora...");
        var tiempo = TimeSpan.FromSeconds(3);
        await Task.Delay(tiempo, token);
    }

    public async Task EcharMermelada(CancellationToken token)
    {
        Console.WriteLine("hechando mermelada al pan...");
        var tiempo = TimeSpan.FromSeconds(1);
        await Task.Delay(tiempo, token);
    }

    public async Task HacerZumo(CancellationToken token)
    {
        Console.WriteLine("Haciendo zumo...");
        var tiempo = TimeSpan.FromSeconds(3);
        await Task.Delay(tiempo, token);
    }
    
    public void Cancel(CancellationTokenSource cts,  Stopwatch cronometro)
    {
        desayuno.Tiempo += Math.Round(cronometro.Elapsed.TotalSeconds, 2);
        Console.WriteLine($"---- {desayuno.Tiempo}s ------");
        if (cancelar.CancelarDesayunos(desayuno.Tiempo))
        {
            cts.Cancel();
        }
    }
}