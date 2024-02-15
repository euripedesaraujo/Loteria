using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loteria
{
    public partial class frmSortear : MetroFramework.Forms.MetroForm
    {
        public frmSortear()
        {
            InitializeComponent();

        }

        private void frmSortear_Shown(object sender, EventArgs e)
        {
            try
            {
                comBoBoxMegaAposta.SelectedIndex = 0;

                metroComboBoxLotoFacil.SelectedIndex = 0;
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMegaSenaSortear_Click(object sender, EventArgs e)
        {
            try
            {
                var _numerosMarcados = 0;

                if (!int.TryParse(comBoBoxMegaAposta.Text, out _numerosMarcados))
                    throw new Exception("Número inválido");

                Sorteio(new MegaSena(_numerosMarcados));
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void metroLinkMegaSenaCopiar_Click(object sender, EventArgs e)
        {

            if (TexBoxMegaSenaAposta.Text.Any())
                Clipboard.SetText(TexBoxMegaSenaAposta.Text);
        }



        private void metroLinkMegaSenaResultado_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://loterias.caixa.gov.br/Paginas/Mega-Sena.aspx");
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void metroButtonLotoFacil_Click(object sender, EventArgs e)
        {
            try
            {
                var _numerosMarcados = 0;

                if (!int.TryParse(metroComboBoxLotoFacil.Text, out _numerosMarcados))
                    throw new Exception("Número inválido");

                Sorteio(new LotoFacil(_numerosMarcados));
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroLinkLotoFacil_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBoxLotoFacil.Text.Any())
                    Clipboard.SetText(metroTextBoxLotoFacil.Text);
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroLinkLotoFacilResultado_Click(object sender, EventArgs e)
        {
            try
            {

                Process.Start("https://loterias.caixa.gov.br/Paginas/Lotofacil.aspx");
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Sorteio(Jogos _jogo)
        {
            try
            {
                if (_jogo is MegaSena)
                    TexBoxMegaSenaAposta.Text = new Sortear().Sorteio(_jogo);
                else if (_jogo is LotoFacil)
                    metroTextBoxLotoFacil.Text = new Sortear().Sorteio(_jogo);

            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
