using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_71
{
    internal class Quarto_Luxo: Quarto 
    {
        private Boolean _TemVistaMar;
        private Boolean _TemJacuzzi;

        public Quarto_Luxo(bool temJacuzzi, bool temVistaMar,int numero, int capacidade, double precoBase) : base(numero, capacidade, precoBase)
        {
         
                _TemJacuzzi = temJacuzzi;
                _TemVistaMar = temVistaMar;
            
        }

        public Boolean GetTemVistaMar()
        {
            return _TemVistaMar;
        }
        public void SetTemVistaMar(Boolean temvistamar)
        {
            this._TemVistaMar = true;
        }
        public Boolean GetTemJacuzzi()
        {
            return this._TemJacuzzi;
        }
        public void SetTemJacuzzi(Boolean temjacuzzi)
        {
            this._TemJacuzzi = true;
        }
        public override double CalcularPrecoTotal(int noites)
        {
            double precoDeBase = noites * this.GetPrecoBase();

            if (_TemJacuzzi == true)
            {
                precoDeBase = (precoDeBase * 1.10);
            }
            if (_TemVistaMar == true)
            {
                precoDeBase = (precoDeBase + 1.20);
            }
            return precoDeBase;
            
        }

    
    }
}
