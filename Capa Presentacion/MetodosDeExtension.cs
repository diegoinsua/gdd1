using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace Clinica_Frba.CapaPresentacion
{
    
    //-------------------------------------
    // TEXT BOX
    //-------------------------------------
    public static class MetodosDeExtension
    {


        public static Boolean validarCaracter(this TextBox txt, string caracteresPermitidos, KeyPressEventArgs e) 
        {
    
            String Aceptados = caracteresPermitidos + Convert.ToChar(8);

            if (Aceptados.Contains(""+ e.KeyChar))
            {
                return !(e.Handled = false);
            }
            else
            {
                System.Media.SystemSounds.Beep.Play();
                //txt.mensaje(mensaje);
                return !(e.Handled = true);
            }
        }


        public static void soloNumeros(this TextBox txt, ErrorProvider erp, KeyPressEventArgs e)
        {
            bool charValido = txt.validarCaracter("0123456789", e);

            if (!charValido) erp.SetError(txt, "Solo puede ingresar números.");
            else erp.SetError(txt, String.Empty);
        }
       
        public static void mensaje(this Control control, string mensaje)
        {
            //ToolTip toolTip1 = new ToolTip();

            //toolTip1.Show(mensaje, control, 3000);
           // toolTip1.AutoPopDelay = 8000;
            // toolTip1.InitialDelay = 1000;
            // toolTip1.ReshowDelay = 500;
            //toolTip1.IsBalloon = true;
            //toolTip1.BackColor = System.Drawing.SystemColors.Info;
            //toolTip1.ShowAlways = false;

            //toolTip1.SetToolTip(control, mensaje);
        }

        //-------------------------------------
        // DATA GRID VIEW
        //-------------------------------------
        public static void agregarBotonSeleccionar(this DataGridView dgv, string textoBoton)
        {
            DataGridViewButtonColumn boton = new DataGridViewButtonColumn();
            //boton.HeaderText = textoBoton;
            boton.Text = textoBoton;
            boton.UseColumnTextForButtonValue = true;
            boton.Width = 70;
            dgv.Columns.Add(boton);
        }

        public static void personalizar(this DataGridView dgv)
        {
            //dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 25;
            dgv.Height = 300;
            dgv.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToResizeRows = false;
            
        }

     

        public static string valorColumna(this DataGridView dgv, DataGridViewCellEventArgs e, string columnaNombre)
        {
            // Verfico si la columna seleccionada es la última (que son las que tienen el botón)
            if (e.ColumnIndex == dgv.ColumnCount - 1)
            {
                return dgv.Rows[e.RowIndex].Cells[columnaNombre].Value.ToString();
            }
            else
            {
                return string.Empty;
            }

        }

        public static bool click(this DataGridView dgv, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv.ColumnCount - 1) return true;
            else return false;
        }

        //-------------------------------------
        // COMBOBOX
        //-------------------------------------
        public static void llenar(this ComboBox cmb, DataTable dt)
        {
            // Llena el combo usando las dos primeras columnas de la tala.
            // La primera columna la usa para el valor a mostrar y la segunda para el valor real.
            
            cmb.DataSource = dt;
            cmb.DisplayMember = dt.Columns[1].ColumnName.ToString();
            cmb.ValueMember = dt.Columns[0].ColumnName.ToString();
            cmb.SelectedIndex = -1;
        }

     }                 

 }



