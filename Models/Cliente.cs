namespace Ejercicio5.Models;

public class Cliente 
{
    public Cliente()
    {
         
    }
    public bool esApto (int edad, double ingresos , bool estaTrabajando ,  double montoPrestamo , bool deudasPrevias)
    {
        bool apto = false 
        double relacionPrestamoIngresos = montoPrestamo / ingresos;
        if (edad >= 18 && ingresos >= 250000 && estaTrabajando && deudasPrevias == false && relacionPrestamoIngresos >5)
        {
            apto = true;

        }
        return apto;
    }
}