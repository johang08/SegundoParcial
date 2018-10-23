using SegundoParcialDanny.BLL;
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

namespace SegundoParcialDanny.UI.Consulta
{
   
    public partial class CVendedor : Form
    {
        RepositoryBase<Vendedor> repositorio;
        public CVendedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                repositorio = new RepositoryBase<Vendedor>();
            var listado = new List<Vendedor>();
            if (CriteriotextBox.Text.Trim().Length > 0)
            {

                
                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0:
                      listado = repositorio.GetList(p => true);
                        break;
                    case 1:
                        int id = Convert.ToInt32(CriteriotextBox.Text);
                        listado = repositorio.GetList(p => p.IDVendedor == id);
                        break;
                    case 2:
                        listado = repositorio.GetList(p => p.Nombre.Contains(CriteriotextBox.Text));
                        break;
                    case 3:
                       float sueldo = Convert.ToSingle(CriteriotextBox.Text);
                        listado = repositorio.GetList(p => p.Sueldo == sueldo);
                        break;
                    case 4:
                        float retencion = Convert.ToSingle(CriteriotextBox.Text);
                        listado = repositorio.GetList(p => p.Retencion == retencion);
                        break;
                    case 5:
                     float total = Convert.ToSingle(CriteriotextBox.Text);
                        listado = repositorio.GetList(p => p.Total == total);
                        break;
                }
                listado = listado.Where(c => c.Fecha >= DesdedateTimePicker.Value.Date && c.Fecha <= HastadateTimePicker.Value.Date).ToList();
            }




            else
            {
                listado = repositorio.GetList(p => true);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listado;
        }
    }
    }

