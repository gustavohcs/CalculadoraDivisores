using System;
using System.Reflection;
using System.Windows.Forms;
using CalculadoraDivisores.Domain.Services;
using CalculadoraDivisores.Infra;
using System.Text.RegularExpressions;

namespace CalculadoraDivisores.Manager
{
    public partial class MainForm : Form
    {
        private readonly IDivisorService _divisorService;
        private const string MSG_NUMERO_INVALIDO = "Valor inválido, digite um valor entre 1 e 100,000,000,000,000";

        public MainForm()
        {
            InitializeComponent();
            _divisorService = DependencyInjection.Container.GetInstance<IDivisorService>();

            lblVersao.Text = $"Release: {Assembly.GetExecutingAssembly().GetName().Version}";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void buttonCalcular_Click(object sender, EventArgs e)
        {
            var input = textBoxInput.Text.Replace(",", "").Replace(".","");

            if (!_divisorService.ValidarInput(input))
            {
                MessageBox.Show(MSG_NUMERO_INVALIDO);
                return;
            }

            long numeroEntrada;
            try
            {
                numeroEntrada = _divisorService.ConverterParaNumero(input);
                var resultado = _divisorService.CalcularDivisores(numeroEntrada);

                textBoxDivisores.Text = resultado.listaDivisores;
                textBoxPrimos.Text = resultado.listaDivisoresPrimos;
            } 
            catch (Exception ex)
            {
                if (ex.Message.Equals(MSG_NUMERO_INVALIDO)) 
                {
                    MessageBox.Show(MSG_NUMERO_INVALIDO);
                    return;
                }
            }
        }

        private long ConverterParaNumero(string input)
        {
            long numeroEntrada;
            try 
            {
                numeroEntrada = Convert.ToInt64(input);
                if  (numeroEntrada > 100000000000000)
                {
                    MessageBox.Show(MSG_NUMERO_INVALIDO);
                    return 0;
                }
                return numeroEntrada;
            }
            catch (Exception ex) 
            {
                if (ex.Message.Equals("Value was either too large or too small for an Int64."))
                {
                    MessageBox.Show(MSG_NUMERO_INVALIDO);
                    return 0;
                }
                else
                    throw;
            }
        }

        public bool ValidarInput(string input)
        {
            if (!Regex.IsMatch(input, @"^\d*[1-9]\d*$"))
            {
                MessageBox.Show(MSG_NUMERO_INVALIDO);
                return false;
            }
            return true;
        }

        private void lblDivisores_Click(object sender, EventArgs e)
        {

        }

        private void lblPrimos_Click(object sender, EventArgs e)
        {

        }

        private void lblVersao_Click(object sender, EventArgs e)
        {

        }

        private void imgTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
