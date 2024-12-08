namespace PilaColaListaE_Dinamica_
{
    public partial class Form1 : Form
    {
        private Stack<int> pila = new Stack<int>();
        private Queue<int> cola = new Queue<int>();
        private LinkedList<int> listaEnlazada = new LinkedList<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int valor))
            {
                pila.Push(valor);
                MostrarContenido(pila);
                txtValor.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor v�lido.");
            }
        }

        // Pop: Eliminar de la pila
        private void btnPop_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0)
            {
                int eliminado = pila.Pop();
                MessageBox.Show($"Elemento eliminado: {eliminado}");
                MostrarContenido(pila);
            }
            else
            {
                MessageBox.Show("La pila est� vac�a.");
            }
        }

        // Peek: Obtener el elemento en la cima
        private void btnPeekPila_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0)
            {
                MessageBox.Show($"Elemento en la cima: {pila.Peek()}");
            }
            else
            {
                MessageBox.Show("La pila est� vac�a.");
            }
        }

        // Mostrar contenido de la pila
        private void MostrarContenido(IEnumerable<int> estructura)
        {
            lstContenido.Items.Clear();
            foreach (int item in estructura)
            {
                lstContenido.Items.Add(item);
            }
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int valor))
            {
                cola.Enqueue(valor);
                MostrarContenido(cola);
                txtValor.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor v�lido.");
            }
        }

        // Dequeue: Eliminar de la cola
        private void btnDequeue_Click(object sender, EventArgs e)
        {
            if (cola.Count > 0)
            {
                int eliminado = cola.Dequeue();
                MessageBox.Show($"Elemento eliminado: {eliminado}");
                MostrarContenido(cola);
            }
            else
            {
                MessageBox.Show("La cola est� vac�a.");
            }
        }

        // Peek: Obtener el elemento al frente
        private void btnPeekCola_Click(object sender, EventArgs e)
        {
            if (cola.Count > 0)
            {
                MessageBox.Show($"Elemento al frente: {cola.Peek()}");
            }
            else
            {
                MessageBox.Show("La cola est� vac�a.");
            }
        }

        private void btnAddFirst_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int valor))
            {
                listaEnlazada.AddFirst(valor);
                MostrarContenido(listaEnlazada);
                txtValor.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor v�lido.");
            }
        }

        // Agregar al final
        private void btnAddLast_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int valor))
            {
                listaEnlazada.AddLast(valor);
                MostrarContenido(listaEnlazada);
                txtValor.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor v�lido.");
            }
        }

        // Eliminar elemento
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int valor))
            {
                if (listaEnlazada.Remove(valor))
                {
                    MessageBox.Show($"Elemento {valor} eliminado.");
                    MostrarContenido(listaEnlazada);
                }
                else
                {
                    MessageBox.Show($"El elemento {valor} no existe en la lista.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor v�lido.");
            }
        }

        // Mostrar el primer elemento
        private void btnShowFirst_Click(object sender, EventArgs e)
        {
            if (listaEnlazada.First != null)
            {
                MessageBox.Show($"Primer elemento: {listaEnlazada.First.Value}");
            }
            else
            {
                MessageBox.Show("La lista est� vac�a.");
            }
        }

        // Mostrar el �ltimo elemento
        private void btnShowLast_Click(object sender, EventArgs e)
        {
            if (listaEnlazada.Last != null)
            {
                MessageBox.Show($"�ltimo elemento: {listaEnlazada.Last.Value}");
            }
            else
            {
                MessageBox.Show("La lista est� vac�a.");
            }
        }

    }
}
