using DesayunoAsync.Models;
using DesayunoAsync.Utils;

namespace DesayunoAsync.Services;

public class DesayunoService : IDesayunoService
{
    private Desayuno desayuno;

    public DesayunoService(Desayuno desayuno)
    {
        this.desayuno = desayuno;
    }

    public void Cafe()
    {
        Console.WriteLine("Preparando cafe...");
        var tiempo = TimeSpan.FromSeconds(3);
        Thread.Sleep(tiempo);
        var t = CalcularTiempoTotal(tiempo);
        Console.WriteLine($"--- {t} s ---");
    }

    public void CalentarSarten()
    {
        Console.WriteLine("Calentando sarten...");
        var tiempo = TimeSpan.FromSeconds(3);
        Thread.Sleep(tiempo);
        
        var t = CalcularTiempoTotal(tiempo);
        Console.WriteLine($"--- {t} s ---");
    }

    public void MeterHuevosSarten()
    {
        Console.WriteLine("Haciendo huevos en la sarten...");
        var tiempo = TimeSpan.FromSeconds(4);
        Thread.Sleep(tiempo);
        
        var t = CalcularTiempoTotal(tiempo);
        Console.WriteLine($"--- {t} s ---");
    }

    public void MeterBaconSarten()
    {
        Console.WriteLine("Calentando Beacon...");
        var tiempo = TimeSpan.FromSeconds(3);
        Thread.Sleep(tiempo);
        
        var t = CalcularTiempoTotal(tiempo);
        Console.WriteLine($"--- {t} s ---");
    }

    public void PonerPanTostadora()
    {
        Console.WriteLine("Calentando el pan en la tostadora...");
        var tiempo = TimeSpan.FromSeconds(3);
        Thread.Sleep(tiempo);
        
        var t = CalcularTiempoTotal(tiempo);
        Console.WriteLine($"--- {t} s ---");
    }

    public void EcharMermelada()
    {
        Console.WriteLine("Hechando mermelada al pan...");
        var tiempo = TimeSpan.FromSeconds(1);
        Thread.Sleep(tiempo);
        
        var t = CalcularTiempoTotal(tiempo);
        Console.WriteLine($"--- {t} s ---");
    }

    public void HacerZumo()
    {
        Console.WriteLine("Haciendo zumo...");
        var tiempo = TimeSpan.FromSeconds(3);
        Thread.Sleep(tiempo);
        
        var t = CalcularTiempoTotal(tiempo);
        Console.WriteLine($"Praparación de desayuno terminado, con un tiempo total de {t} segundos" );
    }

    private double CalcularTiempoTotal(TimeSpan t)
    {
        desayuno.Tiempo += t.TotalSeconds;

        return desayuno.Tiempo;
    }
}