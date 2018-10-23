using SegundoParcialDanny.BLL;
using SegundoParcialDanny.DAL;
using SegundoParcialDanny.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcialDanny.UI.Registro
{
    public partial class RVendedor : Form
    {
        RepositoryBase<Vendedor> repositorio;
        public RVendedor()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            SueldonumericUpDown.Value = 0;
            RetencionnumericUpDown.Value = 0;
            TotaltextBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;
        }

        public Vendedor LlenaClase()
        {
            Vendedor vendedor = new Vendedor()
            {
                IDVendedor = Convert.ToInt32(IDnumericUpDown.Value),
                Nombre = NombretextBox.Text,
                Sueldo = Convert.ToSingle(SueldonumericUpDown.Value),
                Retecion = Convert.ToSingle(RetencionnumericUpDown.Value),
                Total = Convert.ToSingle(TotaltextBox.Text),
                Fecha = FechadateTimePicker.Value
            };
            return vendedor;
        }

        public void LlenaCampo(Vendedor vendedores)
        {
            IDnumericUpDown.Value = vendedores.IDVendedor;
            NombretextBox.Text = vendedores.Nombre;
            SueldonumericUpDown.Value =Convert.ToDecimal( vendedores.Sueldo);
            RetencionnumericUpDown.Value = Convert.ToDecimal( vendedores.Retecion);
            TotaltextBox.Text = Convert.ToString(vendedores.Total);
            FechadateTimePicker.Value = vendedores.Fecha;
        }


    
    private bool Validar()
    {
        bool paso = true;
        if (RetencionnumericUpDown.Value == 0)
        {
            errorProvider1.SetError(RetencionnumericUpDown, "Campo no puede estar en 0");
            paso = false;
        }
        if (SueldonumericUpDown.Value == 0)
        {
            errorProvider1.SetError(SueldonumericUpDown, "Campo no puede estar en 0");
            paso = false;
        }
        if (string.IsNullOrWhiteSpace(NombretextBox.Text))
        {
            errorProvider1.SetError(NombretextBox, "Campo Vacio");
            paso = false;
        }
        return paso;
    }
        private bool EstaEnLaBaseDeDatos()
        {
            RepositoryBase<Vendedor> repositoryBase = new RepositoryBase<Vendedor>();
            Vendedor vendedores = repositoryBase.Buscar((int)IDnumericUpDown.Value);
            return (vendedores != null);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            repositorio = new RepositoryBase<Vendedor>();
            bool paso = false;
            Vendedor vendedores;
            Contexto contexto = new Contexto();

            if (!Validar())
                return;
            vendedores = LlenaClase();
            try
            {
                if (IDnumericUpDown.Value == 0)
                    paso = repositorio.Guardar(vendedores);
                else
                {
                    if (!EstaEnLaBaseDeDatos())
                    {
                        MessageBox.Show("No se puede modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    paso = repositorio.Modificar(vendedores);
                }
                if (paso)
                {
                    MessageBox.Show("Se Guardo Exitosamente", "Imformacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se Gurdo!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            repositorio = new RepositoryBase<Vendedor>();
            errorProvider1.Clear();
            int id;

            int.TryParse(IDnumericUpDown.Text, out id);
            if (repositorio.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
            errorProvider1.SetError(IDnumericUpDown, "no se puede eliminar");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            repositorio = new RepositoryBase<Vendedor>();
            errorProvider1.Clear();
            int id;
            Vendedor vendedores = new Vendedor();
            int.TryParse(IDnumericUpDown.Text, out id);

            vendedores = repositorio.Buscar(id);

            if (vendedores != null)
            {
                LlenaCampo(vendedores);
                MessageBox.Show("Encotrado");


            }
            else
            {
                MessageBox.Show("No Exite");
            }

        }
        

       

        private void SueldonumericUpDown_ValueChanged_1(object sender, EventArgs e)
        {
            decimal sueldo = Convert.ToDecimal(SueldonumericUpDown.Value);
            decimal porciento = Convert.ToDecimal(RetencionnumericUpDown.Value);
            porciento /= 100;
            decimal retencion = porciento * sueldo;

            TotaltextBox.Text = Convert.ToString(retencion);
        }

        private void RetencionnumericUpDown_ValueChanged_1(object sender, EventArgs e)
        {
            decimal sueldo = Convert.ToDecimal(SueldonumericUpDown.Value);
            decimal porciento = Convert.ToDecimal(RetencionnumericUpDown.Value);
            porciento /= 100;
            decimal retencion = porciento * sueldo;

            TotaltextBox.Text = Convert.ToString(retencion);

        }
    }

}






