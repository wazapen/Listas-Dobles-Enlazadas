using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista_Doble_Enlazada
{
    class Inventario
    {
        private Producto first = new Producto();
        private Producto last = new Producto();

        public Inventario()
        {
            first = null;
            last = null;
        }

        public void borrar(int código)
        {
            Producto actual = first;
            Producto anterior = null;
            bool encontrado = false;
            Producto find = null;
            if (first != null)
            {
                while (actual != null || encontrado != true)
                {
                    if (actual.getCódigo() == código)
                    {

                        if (actual == first)
                        {
                            first = first.siguiente;
                        }
                        else if (actual == last)
                        {
                            anterior.siguiente = null;
                            last = anterior;
                        }
                        else
                        {
                            anterior.siguiente = actual.siguiente;
                        }

                        encontrado = true;
                        find = actual;
                    }
                    anterior = actual;
                    actual = actual.siguiente;
                }
            }
            if (!encontrado)
            {
                Console.Write("No se encontró");
            }
        }

        public Producto buscar(int código)
        {
            Producto p = first;

            while (p != null && p.getCódigo() != código)
                p = p.siguiente;

            return p;
        }

        public string reporte()
        {
            Producto actual = first;
            string find = null;
            if (first != null)
            {
                while (actual != null)
                {
                    find += actual.ToString();
                    actual = actual.siguiente;
                }
            }
            return find;
        }
        public string reporteInverso()
        {
            Producto actual = last;
            Producto anterior = first;

            string find = "";
            find = last.ToString();
            if (first != null)
            {

                while (anterior.siguiente != null)
                {
                    if (anterior.siguiente != actual)
                    {
                        anterior = anterior.siguiente;

                    }
                    else
                    {
                        find += anterior.ToString();
                        actual = anterior;
                        anterior = first;
                    }

                }
            }
            else
                find = "No hay productos .-.";
            return find;
        }

        public void agregar(Producto nuevo)
        {
            if (first == null)
            {
                first = nuevo;
                first.siguiente = null;
                first.anterior = null;
                last = nuevo;
            }
            else
            {
                last.siguiente = nuevo;
                nuevo.siguiente = null;
                nuevo.anterior = last;
                last = nuevo;
            }
        }

        //public void agregar (Producto nuevo)
        //{
        //    if (first == null)
        //        first = nuevo;
        //    else
        //        agregar(first, nuevo);
        //}
        //private void agregar (Producto último, Producto nuevo)
        //{
        //    if (último.siguiente == null)
        //        último.siguiente = nuevo;
        //    else
        //        agregar(último.siguiente, nuevo);
        //}

        public void agregarEnInicio(Producto nuevo)
        {
            if (first == null)
            {
                first = nuevo;
                first.siguiente = null;
                first.anterior = null;
                last = nuevo;
            }
            else
            {
                nuevo.siguiente = first;
                first.anterior = nuevo;
                first = nuevo;
                nuevo.anterior = null;
            }
        }
        public void insertarEnPos(Producto nuevo, int pos)
        {
            Producto actual = first;
            int contador = 1;
            bool insertado = false;
            if (first != null)
            {
                while (actual != null && insertado != true)
                {
                    if (contador == pos)
                    {
                        nuevo.siguiente = first;
                        first.anterior = nuevo;
                        nuevo.anterior = null;
                        first = nuevo;
                    }
                    else
                    {
                        actual = actual.siguiente;
                        while (actual != null &&  insertado != true)
                        {
                            contador++;
                            if (contador == pos)
                            {
                                nuevo.siguiente = actual;
                                nuevo.anterior = actual.anterior;
                                actual.anterior.siguiente = nuevo;
                                actual.anterior = nuevo;
                                insertado = true;
                            }
                            else if (contador + 1 == pos)
                            {
                                agregar(nuevo);
                                insertado = true;
                            }
                            else
                            {
                                actual = actual.siguiente;
                            }
                        }
                        
                    }
                }
            }

        }

        public void borrarPrimero()
        {
            if (first != null)
            {
                first = first.siguiente;
                first.anterior = null;
            }
        }

        public void borrarÚltimo()
        {
            if (first != null)
            {
                last = last.anterior;
                last.siguiente = null;
            }
        }
    }
}
