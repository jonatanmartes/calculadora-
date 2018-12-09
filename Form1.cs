using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Operaciones.Clases;

namespace Operaciones
{
    public partial class frmOperaciones : Form
    {
        static string Respuesta;
        public frmOperaciones()
        {
            InitializeComponent();
        }

        private void frmOperaciones_Load(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                lblRespuesta.Text = Convert.ToString(Operaciones.Clases.Operaciones.Sumar(Convert.ToDouble(this.txtPrimero.Text), Convert.ToDouble(this.txtSegundo.Text), out Respuesta));
                if (Respuesta != null) MessageBox.Show(Respuesta,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
                MessageBox.Show(Respuesta, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Limpiar();
            }

        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            try
            {
                lblRespuesta.Text = Convert.ToString(Operaciones.Clases.Operaciones.Restar(Convert.ToDouble(this.txtPrimero.Text), Convert.ToDouble(this.txtSegundo.Text), out Respuesta));
                if (Respuesta != null) MessageBox.Show(Respuesta,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
                MessageBox.Show(Respuesta, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Limpiar();
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                lblRespuesta.Text = Convert.ToString(Operaciones.Clases.Operaciones.Multiplicar(Convert.ToDouble(this.txtPrimero.Text), Convert.ToDouble(this.txtSegundo.Text), out Respuesta));
                if (Respuesta != null) MessageBox.Show(Respuesta,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
                MessageBox.Show(Respuesta, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Limpiar();
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                lblRespuesta.Text = Convert.ToString(Operaciones.Clases.Operaciones.Dividir(Convert.ToDouble(this.txtPrimero.Text), Convert.ToDouble(this.txtSegundo.Text), out Respuesta));
                if (Respuesta != null) MessageBox.Show(Respuesta,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
                MessageBox.Show(Respuesta, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Limpiar();
            }
        }

        private void Limpiar()
        {
            this.txtPrimero.Text = "";
            this.txtSegundo.Text = "";
            this.lblRespuesta.Text = "";
            this.txtPrimero.Focus();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrimero_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}