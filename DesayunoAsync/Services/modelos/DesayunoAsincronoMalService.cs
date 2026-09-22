using System.Diagnostics;
using DesayunoAsync.Models;
using DesayunoAsync.Utils;

namespace DesayunoAsync.Services;

public class DesayunoAsincronoMalService
{
    CancelarDesayuno cancelar = new CancelarDesayuno();
    Desayuno desayuno = new Desayuno();
    DesayunoAsincronoService desayunoServiceA;

    public DesayunoAsincronoMalService()
    {
        desayunoServiceA = new DesayunoAsincronoService(desayuno);
    }

    public async Task PrepararDesayunoAsync(CancellationTokenSource cts)
    {
        CancellationToken token = cts.Token;
        
        Stopwatch cronometro = Stopwatch.StartNew();
        await desayunoServiceA.Cafe(token);
        cronometro.Stop();
        desayunoServiceA.Cancel(cts, cronometro);
        
        cronometro.Restart();
        
        await desayunoServiceA.CalentarSarten(token);
        cronometro.Stop();
        desayunoServiceA.Cancel(cts, cronometro);

        
        await desayunoServiceA.PonerPanTostadora(token);
        cronometro.Stop();
        desayunoServiceA.Cancel(cts, cronometro);
        
        cronometro.Restart();
      
        await desayunoServiceA.MeterHuevosSarten(token);
        cronometro.Stop();
        desayunoServiceA.Cancel(cts, cronometro);

        cronometro.Restart();
        
        await desayunoServiceA.MeterBaconSarten(token);
        cronometro.Stop();
        desayunoServiceA.Cancel(cts, cronometro);
        
        cronometro.Restart();
       
        await desayunoServiceA.EcharMermelada(token);
        cronometro.Stop();
        desayunoServiceA.Cancel(cts, cronometro);
        
        cronometro.Restart();
      
        await desayunoServiceA.HacerZumo(token);
        cronometro.Stop();
        desayunoServiceA.Cancel(cts, cronometro);
    }

    
}