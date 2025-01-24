using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_71
{
    internal class Reserva
    {
        private int _idReserva;
        private Quarto _Quarto;
        private string _Hospede;
        private int _Noites;
        private double _ValorTotal;


        public Reserva(int idReserva, Quarto quarto, string hospede, int noites, double valorTotal)
        {
            _idReserva = idReserva;
            _Quarto = quarto;
            _Hospede = hospede;
            _Noites = noites;
            _ValorTotal = valorTotal;
        }

        public int GetIdReserva()
        {
            return this._idReserva;
        }

        public void SetIdReserva(int idReserva)
        {
            this._idReserva = idReserva;
        }

        public Quarto GetQuarto()
        {
            return this._Quarto;
        }
        public void SetQuarto(Quarto quarto)
        {
            this._Quarto = quarto;
        }
        public string GetHospede()
        {
            return   this._Hospede;
        }
        public void SetHospede(string hospede)
        {
            this._Hospede = hospede;
        }
        public int GetNoites()
        {
            return this._Noites;
        }
        public void SetNoites(int noites)
        {
            this._Noites = noites;
        }
        public double GetValorTotal()
        {
            return this._ValorTotal;
        }
        public void SetValorTotal(double valortotal)
        {
            this._ValorTotal = valortotal;
        }
        public double CalcularTotal()
        {
            _ValorTotal = _Quarto.CalcularPrecoTotal(_Noites);
            return _ValorTotal;
        }

    }
}
