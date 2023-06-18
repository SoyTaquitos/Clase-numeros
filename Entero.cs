using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Entero
    {       
        //Atributos
        private int n;
        //Constructor
        public Entero() //inicial
        {
            n = 0;
        }
        public Entero(int x)  //Parametrizado
        {
            n = x;
        }
        public Entero(Entero objeto) //Copia
        {
            n = objeto.n;
        }
        public void cargar(int x)
        {
            n = x;
        }
        public int descargar()
        {
            return n;
        }
        public void Invertir()
        {
            int dig,
                num = 0;
            while (n > 0)
            {
                dig = n % 10;
                n = n / 10;
                num = num * 10 + dig;
            }
            this.n = num; 
        }
        public int Ndig()
        {
           return  n = (n == 0) ? 1 : (int)Math.Truncate(Math.Log10(n)) + 1;
            //if (n > 0)
            //    n = 1 + (int)Math.Truncate(Math.Log10(n));
            //else
            //    n = 0;
            //return n;
        }
        public static int Potencia(int b, int exp)
        {
            return (int)Math.Pow(b, exp);
        }
        public void UnirNumDerecha(int x)
        {
            if (x > 0)
            {
                Entero aux = new Entero(x);
                n = n * Entero.Potencia(10, aux.Ndig()) + x;
            }
        } 
        public bool VerifPrimo()
        {
            int i = n / 2;
            while (i > 1)
            {
                if (n % i == 0)
                {
                    return false;
                }
                i--; // i = i - 1;
            }
            return true;
        }
        public void NumAscendente(int d)
        {
            int aux = 0,
                 p = 1;
            while (d <= (n % 10))
            {
                aux = (n % 10) * p + aux;
                p = p * 10;
                n = n / 10;
            }
            this.n = n * 10 + d;
            this.UnirNumDerecha(aux);
        }
        public void May2n(Entero x, Entero y)
        {
            if (y.n> x.n)
                n = y.n;
            else
                n = x.n;
        }
        public bool EsMultiplo(int x)
        {
            return (n % x == 0);
        }
        public double Redondear() //no funciona
        {
            double a;
            double red = n;
            a = Math.Ceiling(red);
            return a;
        }
        public bool ejercicio3(Entero x)
        {
            bool c;
            return c = ((n % x.n) == 0) ? true : false; //Ternario "?"
            //if ((n % x.n) == 0)
            //    return true;
            //return false;
        }
        public bool ejercicio4(Entero x)
        {
            bool c;
            return c = ((n % x.n) == 0) ? true : false;  //Ternario "?"
            //if ((x.n % n) == 0)
            //    return true;
            //return false;
        }
        public int ejercicio5()
        {
            int y = n;
            n = n - 1;
            if (y == 0)
            {
                n++;
                return 1;
            }
            else
            {
                return y * ejercicio5();
            }
        }
        public bool ejercicio6()
        {
            Entero aux = new Entero(this);
            aux.Invertir();
            return (n == aux.n);
        }
        public bool ejercicio7()
        { 
            int a = -1;
            int b = 1;
            int c = a + b;
            while (c < n)
            {
                a = b;
                b = c;
                c = a + b;
            }
            if (c == n)
            return true;
            return false;
        }
        public int ejercicio8(Entero x,Entero y)
        {
            int nd, nr;
            if (n < x.n)
            {
              nr = x.n;
              nd = x.Ndig();
              n = n * (int)Math.Pow(10, nd) + nr;
            } 
            else
            {
              nr = x.n;
              nd = n;
              nd = 1 + (int)Math.Truncate(Math.Log10(nd));
              y.n = x.n * (int)Math.Pow(10, nd) + n;
            }                       
            return y.n;                         
        }
        public void ejercicio9(Entero x, Entero y, Entero z)
        {
            int menor = Math.Min(Math.Min(n,x.n),y.n);
            int mayor = Math.Max(Math.Max(n,x.n),y.n);
            int medio = (n + x.n + y.n) - menor - mayor;
            int n2d,n3d;
            n2d = 1 + (int)Math.Truncate(Math.Log10(x.n));
            n3d = 1 + (int)Math.Truncate(Math.Log10(y.n));
            z.n = ((menor*(int)Math.Pow(10, n2d) + medio)*(int)Math.Pow(10, n3d)) + mayor;
        }
        public void ejercicio10(Entero x,Entero y,Entero z)
        {
            int may = Math.Max(Math.Max(n, x.n), y.n);
            int num = may;
            if (num == n)
                z.n = 1;
            else
                if (num == x.n)
                z.n = 2;
            else
                z.n = 3;
            
        }
        public bool ejercicio11()
        {
            int aux, a, c;
            bool j;
            c = 0;
            j = true;

            while (n > c)
            {
                aux = n % 10;
                n = n / 10;
                a = n % 10;
                if (aux == a)
                    c++;
                else
                    j = false;
                c++;

            }
            return j;
        }
        public bool ejercicio12()
        {
            bool b;
            b = true;
            int x = n;
            int d = 0;
            while (x > 0)
            {
                d = x % 10;
                if (d % 2 != 0)
                b = false;
                x = x / 10;
            }
            return b;
        }
        public void ejercicio13(Entero x)
        {          
            int d;
            int num = this.n;
            this.cargar(0); //n = 0;
            while (num > 0)
            {
                d = num % 10;
                num = num / 10;
                this.NumAscendente(d);
            }
        
        }
        public void ejercicio14(Entero x)
        {
            int d;
            Entero aux = new Entero();
            int num = this.n;
            x.cargar(0); //x.n = 0;
            while (num > 0)
            {
                d = num % 10;
                num = num / 10;
                aux.cargar(d);  //aux.n = d;
                if (aux.EsMultiplo(2))
                {
                    x.UnirNumDerecha(d);
                }
            }
        }
        public void ejercicio15(Entero x)
        {
            int d;
            Entero aux = new Entero();
            int num = this.n;
            x.cargar(0); //x.n = 0;
            while (num > 0)
            {
                d = num % 10;
                num = num / 10;
                aux.cargar(d);  //aux.n = d;
                if (aux.VerifPrimo())
                {
                    x.NumAscendente(d);
                }
            }
        }
    }
}