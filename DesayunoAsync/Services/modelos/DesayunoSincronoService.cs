using DesayunoAsync.Utils;
using DesayunoAsync.Models;

namespace DesayunoAsync.Services;

public class DesayunoSincronoService
{
    CancelarDesayuno cancelar = new CancelarDesayuno();
    Desayuno desayuno = new Desayuno();
    DesayunoService desayunoService;

    public DesayunoSincronoService()
    {
        desayunoService = new DesayunoService(desayuno);
    }

    public void PrepararDesayuno()
    {
        desayunoService.Cafe();
        if (cancelar.CancelarDesayunos(desayuno.Tiempo)) return;

        desayunoService.CalentarSarten();
        if (cancelar.CancelarDesayunos(desayuno.Tiempo)) return;

        desayunoService.MeterHuevosSarten();
        if (cancelar.CancelarDesayunos(desayuno.Tiempo)) return;

        desayunoService.MeterBaconSarten();
        if (cancelar.CancelarDesayunos(desayuno.Tiempo)) return;

        desayunoService.PonerPanTostadora();
        if (cancelar.CancelarDesayunos(desayuno.Tiempo)) return;

        desayunoService.EcharMermelada();
        if (cancelar.CancelarDesayunos(desayuno.Tiempo)) return;

        desayunoService.HacerZumo();
    }

   
}