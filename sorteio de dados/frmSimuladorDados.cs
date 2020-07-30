using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace sorteio_de_dados
{
    public partial class frmSimuladorDados : Form
    {
        Random sorteio = new Random();
        int valor;

        public frmSimuladorDados()
        {
            InitializeComponent();
        }

        private async void btnJogar_Click(object sender, EventArgs e)
        {
            lblResult.ForeColor = Color.White;
            btnJogar.Visible = false;
            lblResult.Text = "";
            lblDanoExtremo.Visible = false;
            int num2 = VerificaTipoDado();
            valor = sorteio.Next(1, num2);
            if (radbtnD10_dezena.Checked)
                valor = sorteio.Next(0, 10) * 100;
            lblJogando.Text = "Jogando.";
            lblJogando.Visible = true;
            await PausaComTaskDelay();
            lblJogando.Text = "Jogando..";
            await PausaComTaskDelay();
            lblJogando.Text = "Jogando...";
            await PausaComTaskDelay();
            lblJogando.Text = "Jogando....";
            await PausaComTaskDelay();
            lblResult.Text = valor.ToString();
            lblJogando.Visible = false;
            if (valor == 1)
            {
                lblDanoExtremo.Visible = true;
                lblResult.ForeColor = Color.Red;
                lblDanoExtremo.Text = "Fracasso extremo!";
            }
            else if (valor == num2 - 1)
            {
                lblDanoExtremo.Visible = true;
                lblResult.ForeColor = Color.Red;
                lblDanoExtremo.Text = "Sucesso extremo!";
            }
            btnJogar.Visible = true;
        }

        async Task PausaComTaskDelay()
        {
            await Task.Delay(500);
        }

        private int VerificaTipoDado()
        {
            int ladoDadoMais1 = 0;
            if (radbtnD6.Checked)
                ladoDadoMais1 = 7;
            else if (radbtnD3.Checked)
                ladoDadoMais1 = 4;
            else if (radbtnD4.Checked)
                ladoDadoMais1 = 5;
            else if (radbtnD8.Checked)
                ladoDadoMais1 = 9;
            else if (radbtnD10.Checked)
                ladoDadoMais1 = 11;
            else if (radbtnD12.Checked)
                ladoDadoMais1 = 11;
            else if (radbtnD12.Checked)
                ladoDadoMais1 = 11;
            else if (radbtnD16.Checked)
                ladoDadoMais1 = 17;
            else if (radbtnD20.Checked)
                ladoDadoMais1 = 21;
            else if (radbtnD24.Checked)
                ladoDadoMais1 = 25;
            else if (radbtnD30.Checked)
                ladoDadoMais1 = 31;
            else if (radbtnD60.Checked)
                ladoDadoMais1 = 61;
            else if (radbtnD100.Checked)
                ladoDadoMais1 = 101;
            return ladoDadoMais1;
        }

        private void radbtnD6_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "";
            if (radbtnD6.Checked)
            {
                lblProbabilidade.Text = "d6 = 1 / 6 = 16,6%";
                lblDanoExtremo.Visible = false;
                picDado.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\d6.jpg");
                lblNomeDado.Text = "D6";
                lblDescricaoDado.Text = "(dado de 6 lados)";
            }
        }

        private void radbtnD3_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "";
            if (radbtnD3.Checked)
            {
                lblProbabilidade.Text = "d3 = 1 / 3 = 33,3%";
                lblDanoExtremo.Visible = false;
                picDado.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\d3.jpg");
                lblNomeDado.Text = "D3";
                lblDescricaoDado.Text = "(dado de 3 lados)";
            }
        }

        private void radbtnD4_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "";
            if (radbtnD4.Checked)
            {
                lblProbabilidade.Text = "d4 = 1 / 4 = 25%";
                lblDanoExtremo.Visible = false;
                picDado.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\d4.jpg");
                lblNomeDado.Text = "D4";
                lblDescricaoDado.Text = "(dado de 4 lados)";
            }
        }

        private void radbtnD8_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "";
            if (radbtnD8.Checked)
            {
                lblProbabilidade.Text = "d8 = 1 / 8 = 12,5%";
                lblDanoExtremo.Visible = false;
                picDado.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\d8.jpg");
                lblNomeDado.Text = "D8";
                lblDescricaoDado.Text = "(dado de 8 lados)";
            }
        }

        private void radbtnD10_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "";
            if (radbtnD10.Checked)
            {
                lblProbabilidade.Text = "d10 = 1 / 10 = 10%";
                lblDanoExtremo.Visible = false;
                picDado.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\d10.jpg");
                lblNomeDado.Text = "D10";
                lblDescricaoDado.Text = "(dado de 10 lados)";
            }
        }

        private void radbtnD10_dezena_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "";
            if (radbtnD10_dezena.Checked)
            {
                lblProbabilidade.Text = "d10 = 1 / 10 = 10%";
                lblDanoExtremo.Visible = false;
                picDado.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\d10%.jpg");
                lblNomeDado.Text = "D10%";
                lblDescricaoDado.Text = "(dado de 10 lados)";
            }
        }

        private void radbtnD12_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "";
            if (radbtnD12.Checked)
            {
                lblProbabilidade.Text = "d12 = 1 / 12 = 8,3%";
                lblDanoExtremo.Visible = false;
                picDado.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\d12.jpg");
                lblNomeDado.Text = "D12";
                lblDescricaoDado.Text = "(dado de 12 lados)";
            }
        }

        private void radbtnD16_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "";
            if (radbtnD16.Checked)
            {
                lblProbabilidade.Text = "d16 = 1 / 16 = 6,3%";
                lblDanoExtremo.Visible = false;
                picDado.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\d16.jpeg");
                lblNomeDado.Text = "D16";
                lblDescricaoDado.Text = "(dado de 16 lados)";
            }
        }

        private void radbtnD20_CheckedChanged(object sender, EventArgs e)
        {
            lblProbabilidade.Text = "d20 = 1 / 20 = 5%";
            lblResult.Text = "";
            if (radbtnD20.Checked)
            {
                lblDanoExtremo.Visible = false;
                picDado.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\d20.jpg");
                lblNomeDado.Text = "D20";
                lblDescricaoDado.Text = "(dado de 20 lados)";
            }
        }

        private void radbtnD100_CheckedChanged(object sender, EventArgs e)
        {
            lblProbabilidade.Text = "d100 = 1 / 100 = 1%";
            lblResult.Text = "";
            if (radbtnD100.Checked)
            {
                lblDanoExtremo.Visible = false;
                picDado.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\d100.jpg");
                lblNomeDado.Text = "D100";
                lblDescricaoDado.Text = "(dado de 100 lados)";
            }
        }

        private void radbtnD24_CheckedChanged(object sender, EventArgs e)
        {
            lblProbabilidade.Text = "d24 = 1 / 24 = 4,2%";
            lblResult.Text = "";
            if (radbtnD24.Checked)
            {
                lblDanoExtremo.Visible = false;
                picDado.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\d24.jpg");
                lblNomeDado.Text = "D24";
                lblDescricaoDado.Text = "(dado de 24 lados)";
            }
        }

        private void radbtnD30_CheckedChanged(object sender, EventArgs e)
        {
            lblProbabilidade.Text = "d30 = 1 / 30 = 3,3%";
            lblResult.Text = "";
            if (radbtnD30.Checked)
            {
                lblDanoExtremo.Visible = false;
                picDado.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\d30.jpg");
                lblNomeDado.Text = "D30";
                lblDescricaoDado.Text = "(dado de 30 lados)";
            }
        }

        private void radbtnD60_CheckedChanged(object sender, EventArgs e)
        {
            lblProbabilidade.Text = "d60 = 1 / 60 = 1,7%";
            lblResult.Text = "";
            if (radbtnD60.Checked)
            {
                lblDanoExtremo.Visible = false;
                picDado.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\d60.jpg");
                lblNomeDado.Text = "D60";
                lblDescricaoDado.Text = "(dado de 60 lados)";
            }
        }
    }
}
