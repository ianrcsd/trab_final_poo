﻿using System;

public class Moto
{
	    #region Atributos
    public Moto()
	{

        double desconto;

        const double tarifaBasica = 5;

    }

    #endregion

    #region GetSets
    public double getTarifaBasica()
    {

        return tarifaBasica;

    }

    public double getDesconto()
    {

        return desconto;

    }

    public void setDesconto(double valor, double tarifaBasica)
    {

        if (valor > 0 && valor < tarifaBasica)

            try
            {

                this.desconto = valor;

            }

            catch (ArgumentNullException)

            {

                Console.WriteLine("O parâmetro está nulo!");

            }


            catch (FormatException)

            {

                Console.WriteLine("Oformato do parâmetro está incorreto!");

            }


            catch (ArgumentException)

            {

                Console.WriteLine("O parâmetro não é válido!");

            }

    }


    #endregion

    
    #region Métodos
    public double tarifa(Estacionada quando) 
    
    {

        double valorDesconto = 2;

        double tarifaFinal = 0;

        int tarifaHora = 5;

        TimeSpan tempoEstacionada = Estacionada.saida.Subtract(Estacionada.entrada);

        tarifaFinal = (tarifaHora - getDesconto()) * tempoEstacionada.Hours;

        return tarifaFinal;

    }

    #endregion

    #region Construtores

    public Moto(string placa)
    {

        setPlaca(placa);

    }

    #endregion 
}
