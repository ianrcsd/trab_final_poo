using System;

public class CarroPequeno
{
	  #region Atributos

    const double tarifaBasica = 5;

    #endregion


    #region GetSets
    public double getTarifaBasica()
    {

        return tarifaBasica;

    }
    #endregion

    #region Métodos 
    double tarifa(Estacionada quando)

    {

        double tarifaFinal = 0;

        int tarifaHora = 5;

        TimeSpan tempoEstacionada = Estacionada.saida.Subtract(Estacionada.entrada);

        tarifaFinal = getTarifaBasica() * tempoEstacionada.Hours;

        return tarifaFinal;
        #endregion 

    }

    #region Construtores

    public CarroPequeno(string placa)
    {

        setPlaca(placa);

    }

    #endregion 
}
