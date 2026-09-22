using System.Diagnostics;
using DesayunoAsync.Models;
using DesayunoAsync.Utils;
using DesayunoAsync.Services;


namespace DesayunoAsync.Services;

public class DesayunoAsincronoBienService
{
    CancelarDesayuno cancelar = new CancelarDesayuno();
    Desayuno desayuno = new Desayuno();
    DesayunoAsincronoService desayunoService;

    public DesayunoAsincronoBienService()
    {
        desayunoService = new DesayunoAsincronoService(desayuno);
    }

    public async Task PrepararDesayunoAsync(CancellationTokenSource cts)
    {
        CancellationToken token = cts.Token;
        
        Console.WriteLine($"¿Token cancelado?: {token.IsCancellationRequested}");
        
        Stopwatch cronometro = Stopwatch.StartNew();
        var tarea1 = desayunoService.Cafe(token);
        var tarea2 = desayunoService.CalentarSarten(token);
        var tarea3 = desayunoService.PonerPanTostadora(token);
        var tarea4 = desayunoService.HacerZumo(token);
        
        try
        {
            await Task.WhenAll(tarea1, tarea2, tarea3, tarea4);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"ERROR: {ex.GetType().Name}");
            Console.WriteLine(ex.Message);
        }
        
        cronometro.Stop();
        desayunoService.Cancel(cts, cronometro);
        
        cronometro.Restart();
        
        var tarea21 = desayunoService.MeterHuevosSarten(token);
        var tarea22 = desayunoService.MeterBaconSarten(token);
        await Task.WhenAll(tarea21, tarea22);
        cronometro.Stop();
        desayunoService.Cancel(cts, cronometro);
        
        cronometro.Restart();
        
        await desayunoService.EcharMermelada(token);
        cronometro.Stop();
        desayunoService.Cancel(cts, cronometro);
    }
}