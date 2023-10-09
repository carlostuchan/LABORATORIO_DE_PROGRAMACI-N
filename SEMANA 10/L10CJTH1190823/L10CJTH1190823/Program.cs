using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10CJTH1190823
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
class Automovil
{
    private int modelo;
    private double precio;
    private string marca;
    private bool disponible;
    private double tipoCambioDolar;
    private double descuentoAplicado;

    public Automovil()
    {
        modelo = 2019;
        precio = 10000.00;
        marca = "";
        disponible = false;
        tipoCambioDolar = 7.50;
        descuentoAplicado = 0.0;
    }

    public int Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }

    public double Precio
    {
        get { return precio; }
        set { precio = value; }
    }

    public string Marca
    {
        get { return marca; }
        set { marca = value; }
    }

    public bool Disponible
    {
        get { return disponible; }
        set { disponible = value; }
    }

    public double TipoCambioDolar
    {
        get { return tipoCambioDolar; }
        set { tipoCambioDolar = value; }
    }

    public double DescuentoAplicado
    {
        get { return descuentoAplicado; }
        set { descuentoAplicado = value; }
    }
}
