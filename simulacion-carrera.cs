using System;
using System.Diagnostics;

namespace simulacion_carrera
{
    public partial class Codigo : Form
    {
        public Codigo()
        {
            InitializeComponent();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {

            input_arreglo.Text = string.Empty;
            input_numero.Text = string.Empty;
            input_secuencial.Text = string.Empty;
            input_binaria.Text = string.Empty;
            input_burbuja.Text = string.Empty;
            input_insercion.Text = string.Empty;
            input_quicksort.Text = string.Empty;
            input_secuencial_encontrado.Text = string.Empty;
            input_binaria_encontrado.Text = string.Empty;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int[] arreglo = ObtenerArregloDesdeTextBox();

            if (arreglo != null && arreglo.Length > 0)
            {
                int objetivo;
                if (int.TryParse(input_numero.Text, out objetivo))
                {
                    Stopwatch stopwatch = new Stopwatch();

                    Thread busquedaSecuencialThread = new Thread(() => EjecutarBusquedaSecuencial(arreglo, objetivo, stopwatch));
                    Thread busquedaBinariaThread = new Thread(() => EjecutarBusquedaBinaria(arreglo, objetivo, stopwatch));
                    Thread burbujaThread = new Thread(() => EjecutarBurbuja(arreglo, stopwatch));
                    Thread quickSortThread = new Thread(() => EjecutarQuickSort(arreglo, stopwatch));
                    Thread insercionThread = new Thread(() => EjecutarInsercion(arreglo, stopwatch));

                    busquedaSecuencialThread.Start();
                    busquedaBinariaThread.Start();
                    burbujaThread.Start();
                    quickSortThread.Start();
                    insercionThread.Start();
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un número válido como objetivo.");
                }
            }
        }

        private void EjecutarBusquedaSecuencial(int[] arreglo, int objetivo, Stopwatch stopwatch)
        {
            List<long> tiempos = new List<long>();
            bool resultado = false; // Inicializar el resultado
            for (int i = 0; i < 10; i++)

            {
                stopwatch.Restart();
                Algoritmos.BusquedaSecuencial(arreglo, objetivo);
                stopwatch.Stop();
                tiempos.Add(stopwatch.ElapsedTicks);
            }

            resultado = Algoritmos.BusquedaSecuencial(arreglo, objetivo);
            long tiempoPromedio = (long)tiempos.Average();
            MostrarResultado(input_secuencial_encontrado, resultado);
            MostrarResultado(input_binaria_encontrado, resultado);
            MostrarTiempo(input_secuencial, tiempoPromedio);

        }

        private void EjecutarBusquedaBinaria(int[] arreglo, int objetivo, Stopwatch stopwatch)
        {
            List<long> tiempos = new List<long>();
            bool resultado = false; // Inicializar el resultado
            for (int i = 0; i < 10; i++)
            {
                stopwatch.Restart();
                Algoritmos.BusquedaBinaria(arreglo, objetivo);
                stopwatch.Stop();
                tiempos.Add(stopwatch.ElapsedTicks);
            }

            resultado = Algoritmos.BusquedaBinaria(arreglo, objetivo);
            long tiempoPromedio = (long)tiempos.Average();
           // MostrarResultado(input_binaria_encontrado, resultado);
            MostrarTiempo(input_binaria, tiempoPromedio);
        }

        private void EjecutarBurbuja(int[] arreglo, Stopwatch stopwatch)
        {
            List<long> tiempos = new List<long>();
            for (int i = 0; i < 10; i++)
            {
                int[] copiaBurbuja = (int[])arreglo.Clone(); // Crear una copia del arreglo para no modificar el original
                stopwatch.Restart();
                Algoritmos.Burbuja(copiaBurbuja);
                stopwatch.Stop();
                tiempos.Add(stopwatch.ElapsedTicks);
            }
            long tiempoPromedio = (long)tiempos.Average();
            MostrarTiempo(input_burbuja, tiempoPromedio);
        }

        private void EjecutarQuickSort(int[] arreglo, Stopwatch stopwatch)
        {
            List<long> tiempos = new List<long>();
            for (int i = 0; i < 10; i++)
            {
                int[] copiaQuickSort = (int[])arreglo.Clone();
                stopwatch.Restart();
                Algoritmos.QuickSort(copiaQuickSort, 0, copiaQuickSort.Length - 1);
                stopwatch.Stop();
                tiempos.Add(stopwatch.ElapsedTicks);
            }
            long tiempoPromedio = (long)tiempos.Average();
            MostrarTiempo(input_quicksort, tiempoPromedio);
        }

        private void EjecutarInsercion(int[] arreglo, Stopwatch stopwatch)
        {
            List<long> tiempos = new List<long>();
            for (int i = 0; i < 10; i++)
            {
                int[] copiaInsercion = (int[])arreglo.Clone();
                stopwatch.Restart();
                Algoritmos.Insercion(copiaInsercion);
                stopwatch.Stop();
                tiempos.Add(stopwatch.ElapsedTicks);
            }
            long tiempoPromedio = (long)tiempos.Average();
            MostrarTiempo(input_insercion, tiempoPromedio);
        }

        private void MostrarResultado(TextBox textBox, bool resultado)
        {

            textBox.Invoke((MethodInvoker)delegate
            {
                textBox.Text = resultado ? "Encontrado" : "No encontrado";
            });
        }

        private void MostrarTiempo(TextBox textBox, long tiempoTicks)
        {
            double tiempoSegundos = (double)tiempoTicks / Stopwatch.Frequency;
            textBox.Invoke((MethodInvoker)delegate
            {
                textBox.Text = $"{tiempoSegundos:F9} s"; // Mostrar tiempo en segundos con nueve decimales
            });
        }

        private int[] ObtenerArregloDesdeTextBox()
        {
            string[] valoresTexto = input_arreglo.Text.Split(',');

            int[] arreglo = new int[valoresTexto.Length];
            for (int i = 0; i < valoresTexto.Length; i++)
            {
                if (int.TryParse(valoresTexto[i], out int valor))
                {
                    arreglo[i] = valor;
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa números separados por comas.");
                    return null;
                }
            }

            return arreglo;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btn_aleatorio_Click_1(object sender, EventArgs e)
        {


            int[] array = new int[10000];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 1000);
            }
            input_arreglo.Text = string.Join(",", array);

        }
    }
}
