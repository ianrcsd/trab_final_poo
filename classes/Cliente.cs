using System;

public abstract class Cliente
{
    protected string nome;
    protected string cpf;

	public Cliente() {
	}

    public abstract double valorTarifa(Estacionada quando);
}
