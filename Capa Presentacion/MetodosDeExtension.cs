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
                return e.Handled = false;
            }
            else
            {
                System.Media.SystemSounds.Beep.Play();
                return e.Handled = true;
            }
        }

        //-------------------------------------
        // DATA GRID VIEW
        //-------------------------------------
        public static void agregarBotonSeleccionar(this DataGridView dgv)
        {
            DataGridViewButtonColumn boton = new DataGridViewButtonColumn();
            boton.HeaderText = "Seleccionar";
            boton.Width = 70;
            dgv.Columns.Add(boton);
        }

        public static void personalizar(this DataGridView dgv)
        {
            //dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 25;
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




     }                 

 }



