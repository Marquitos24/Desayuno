using DesayunoAsync.Models;

namespace DesayunoAsync.Utils;

public class CancelarDesayuno
{
    public bool CancelarDesayunos(double t)
    {
        if (t >= 15)
        {
            Console.WriteLine($"La preparación del dasayuno va por {t} segundos. Se procede a cancelarlo.");
            return true;
        }
        return false;
    }
}