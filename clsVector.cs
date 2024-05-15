using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppVector
{
    class clsVector
    {
        private int[] vector;
        private int lg;
        //constructor
        public clsVector() { 
        vector= new int [100];
        lg = 0;
        }
        //metodos (procedimiento y funciones)
        public void adicionar(int valor) {
            vector[lg] = valor;
            lg = lg + 1;
        }
        //obtener el valor en la posicion pos
        public int obtenervalor(int pos) {
            return vector[pos];
        }
        // Longitud del vector
        public int longitud() {
            return lg;
        }
        // invertir los elementosdel vector
        public void invertir()
        {
            int fin = lg - 1;
            int mitad = lg / 2;
            int i = 0;
            int aux = 0;
            while (i < mitad)
            {
                aux = vector[fin - i];
                vector[fin - i] = vector[i];
                vector[i] = aux;
                i++;
            }
        }


        // cantidad de elementos pares
        public int cantPares() {
            int cont = 0;
            for(int i=0; i <lg; i++){
            if (vector[i] % 2==0)
                cont++;
            }
            return cont;
        }
        // ordenar los elementos del vector de menor a mayor
        public void OrdenarMenorAmayor() {
            int aux = 0;
            for (int i = 0; i < lg; i++) {
                for (int j = i; j < lg; j++) {
                    if (vector[i] > vector[j]) {
                        aux = vector[j];
                        vector[j] = vector[i];
                        vector[i] = aux;
                    }
                }
            }
        }
        // Eliminar el elemento en la posicion p
        public void EliminarElementoPos(int p) {
            for (int i = p - 1; i < lg; i++) {
                vector[i] = vector[i + 1];
            }
            lg = lg - 1;
        }
        // Invertir cada elemento del vector
        public void invertirVect()
        {
            for (int i = 0; i < lg; i++)
            {
                vector[i] = invertirVector(vector[i]);
            }
        }
        // Método para invertir un número
        private int invertirVector(int num)
        {
            int invertirNum = 0;
            while (num > 0)
            {
                int res = num % 10;
                invertirNum = (invertirNum * 10) + res;
                num = num / 10;
            }
            return invertirNum;
        }

   
    // Método para verificar si un número es capicúa
    public int ContarCapicuas()
    {
    int capicuas = 0; 
    for (int i = 0; i < lg; i++)
    {
        int num = vector[i];
        int ori = num;
        int rev = 0;
        while (num > 0)
        {
            int res = num % 10;
            rev = (rev * 10) + res;
            num = num / 10;
        }
        if (ori == rev)
        {
            capicuas++; 
        }
    }
    return capicuas;
}
    // Método para obtener la cantidad de números primos en el vector
    public int ContarPrimos()
    {
        int primosCount = 0; 
        for (int i = 0; i < lg; i++)
        {
            int num = vector[i];
            if (num > 1 && EsPrimo(num)) 
            {
                primosCount++; 
            }
        }
        return primosCount; 
    }
    // Método para verificar si un número es primo

    private bool EsPrimo(int num)
    {
        if (num <= 1)
        {
            return false;
        }
        for (int i = 2; i < num; i++) 
        {
            if (num % i == 0) 
            {
                return false;
            }
        }
        return true; 
    }
    }
}
  




