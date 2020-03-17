using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConversorDeMedidas
{

    class Comprimento
    {
        public string msg1 = "Equivalente a "; // mensgen nada ver que aparece na hora de printar
        public double mq;/* {
            get { return mq ; }
            set { System.Console.ReadLine(); }
        }*/
            
        private double quilometro;
        private double metro;
        private double centimetro;
        private double milimetro;
        private double micometro;
        private double nanometro;
        private double milha;
        private double jarda;
        private double pe;
        private double polegada;
        private double milhanautica;
        
        public double Quilometro
        {
            get { return quilometro; }
            set
            {
                quilometro = value;
                metro      = value * 1000;
                centimetro = value * 100000;
                milimetro  = value * 1000000;
                micometro  = value * 1000000000;
                nanometro  = value * 1000000000000;
                milha      = value / 1.60934;
                jarda      = value * 1094;
                pe         = value * 3281;
                polegada   = value * 39370;
                milhanautica= value / 1.853;
            }
        }

  
        public  double Metro
        {
            get { return metro; }
            set
            {
                quilometro = value * 0.001 ;
                metro = value; 
                centimetro = value * 100;
                milimetro = value * 1000;
                micometro = value * (1 * (10 * 10 * 10 * 10 * 10 * 10));
                nanometro = value * (1 * (10 * 10 * 10 * 10 * 10 * 10 * 10 * 10 * 10));
                milha = value * 0.000621371;
                jarda = value * 1.09361296;
                pe = value * 3.28084;
                polegada = value * 39.3701;
                milhanautica = value * 0.000539957;
            }
        }


        public double Centimetro
        {
            get { return centimetro; }
            set
            {
                quilometro = value *(1*(10*10*10*10*10)) ;
                metro = value      * 0.01   ;
                centimetro = value;
                milimetro = value * 10;
                micometro = value * 100000;
                nanometro = value * (1*(10*10*10*10*10*10*10));
                milha = value * (6.2137*(10*10*10*10*10*10));
                jarda = value * 0.0109361;
                pe = value * 0.0328084;
                polegada = value * 0.393701;
                milhanautica = value * (5.3996*(10*10*10*10*10*10));
            }
        }


        public  double Milimetro
        {
            get { return milimetro; }
            set
            {
                quilometro = value * (1*(10*10*10*10*10*10));
                metro = value * 0.001;
                centimetro = value * 0.1;
                milimetro = value ;
                micometro = value * 1000.0000319999695648;
                nanometro = value * 1000000.0319999695057;
                milha = value *(6.213712121211932233*(10*10*10*10*10*10*10));
                jarda = value * 0.0010936133333333;
                pe = value * 0.00328084;
                polegada = value * 0.0393701;
                milhanautica = value * (5.3996*(10*10*10*10*10*10*10));
            }
        }
        public  double Micometro
        {
            get { return micometro; }
            set
            {
                quilometro = value * (1*(10*10*10*10*10*10*10*10*10));
                metro = value *      (1 * (10 * 10 * 10 * 10 * 10 * 10));
                centimetro = value * (1 * (10 * 10 * 10 * 10 * 10));
                milimetro = value * 0.001;
                micometro = value;
                nanometro = value * 1000;
                milha = value * (Math.Pow(6.2137,10));
                jarda = value * (1.0936*(10 * 10 * 10 * 10 * 10 * 10));
                pe = value * (3.28084*(10 * 10 * 10 * 10 * 10 * 10));
                polegada = value * (3.937*( 10 * 10 * 10 * 10 * 10));
                milhanautica = value * (Math.Pow(5.2137,10)); 
            }
        }
        public  double Nanometro    //                    E R R O R   #
        {                           //    E R R O R      
            get { return nanometro; }
            set
            {
                quilometro = value * (Math.Pow(1,12));
                metro = value  * (Math.Pow(1, 9));
                centimetro = value * (Math.Pow(1, 7));
                milimetro = value * (Math.Pow(1, 6));
                micometro = value * 0.001;
                nanometro = value;//                                              0))
                milha = value * (Math.Pow(6.2137, 13));
                jarda = value * (Math.Pow(1.0936,9));
                pe = value * (Math.Pow(3.2808, 9));
                polegada = value  *(Math.Pow(3.937, 8));
                milhanautica = value * (Math.Pow(5.3996, 13));
            }
        }
        public  double Milha
        {
            get { return milha; }
            set
            {
                quilometro = value * 1.60934;
                metro = value * 1609.34;
                centimetro = value * 160934;
                milimetro = value * (Math.Pow(1.609,6)); ;
                micometro = value * (Math.Pow(1.609, 9)); ;
                nanometro = value * (Math.Pow(1.609, 12));
                milha = value ;
                jarda = value * 1760;
                pe = value * 5280;
                polegada = value * 63360;
                milhanautica = value * 0.868976;
            }
        }
        public  double Jarda
        {
            get { return jarda; }
            set
            {
                quilometro = value * 0.0009144;
                metro = value* 0.9144 ;
                centimetro = value * 91.44;
                milimetro = value * 914.4;
                micometro = value * 914400;
                nanometro = value *(Math.Pow(9.144, 8));
                milha = value * 0.000568182;
                jarda = value ;
                pe = value * 3;
                polegada = value * 36;
                milhanautica = value * 0.000493737;
            }
        }
        public  double Pe
        {
            get { return pe; }
            set
            {
                quilometro = value * 0.0003048;
                metro = value * 0.3048;
                centimetro = value * 30.48;
                milimetro = value * 304.8;
                micometro = value * 304800;
                nanometro = value * (Math.Pow(3.048,8));
                milha = value * (Math.Pow(3.048,8));
                jarda = value * 0.333333;
                pe = value  ;
                polegada = value * 12;
                milhanautica = value * 0.000164579;
            }
        }
        public  double Polegada
        {
            get { return polegada; }
            set
            {
                quilometro = value * (Math.Pow(2.54,5));
                metro = value * 0.0254;
                centimetro = value * 2.54;
                milimetro = value * 25.4;
                micometro = value * 25400;
                nanometro = value * (Math.Pow(2.54,7));
                milha = value * (Math.Pow(1.5783,5));
                jarda = value * 0.0277778;
                pe = value * 0.0833333;
                polegada = value ;
                milhanautica = value * (Math.Pow(1.3715,5));
            }
        }
        public  double Milhanautica
        {
            get { return milhanautica; }
            set
            {
                quilometro = value * 1.852;
                metro = value * 1852;
                centimetro = value * 185200;
                milimetro = value * (Math.Pow(1.852 , 6));
                micometro = value * (Math.Pow(1.852 , 9));
                nanometro = value * (Math.Pow(1.852 , 12));
                milha = value * 1.15078;
                jarda = value * 2025.37;
                pe = value * 6076.12;
                polegada = value * 72913.4;
                milhanautica = value ;
            }
        }

    }
}
