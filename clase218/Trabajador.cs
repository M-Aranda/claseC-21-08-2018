using System;

public class Trabajador
{

    long sueldo;
    String tipoContrato; 

	public Trabajador()
	{
	}

    public long Sueldo { get => sueldo; set => sueldo = value; }
    public string TipoContrato { get => tipoContrato; set => tipoContrato = value; }
}
