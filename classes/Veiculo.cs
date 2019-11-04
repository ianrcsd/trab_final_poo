using System;

public abstract class Veiculo
{
    protected string placa;
    protected Estacionada[] usos;

	public Veiculo()
	{
	}

    public abstract double tarifa(Estacionada quando);
}
