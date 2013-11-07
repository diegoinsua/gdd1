using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.CapaPresentacion
{
    public partial class frmClinica : Form
    {
        public frmClinica()
        {
            InitializeComponent();
            crearMenu();
        }


        // Construir Menú
        public void crearMenu()
        {
            agregarItem(menuStrip1, "ABM Afiliado");
            agregarItem(menuStrip1, "ABM Profesional");
                    
        }


        // Constuir Item
        private void agregarItem(MenuStrip barraMenu, string textoMenu)
        {
            ToolStripMenuItem menuPrincipal = new ToolStripMenuItem(textoMenu);
            ((ToolStripDropDownMenu)(menuPrincipal.DropDown)).ShowImageMargin = false;
            ((ToolStripDropDownMenu)(menuPrincipal.DropDown)).ShowCheckMargin = true;

            barraMenu.Items.Add(menuPrincipal);

            agregarSubItems(menuPrincipal);
        }



        // Construir subitems
        private void agregarSubItems(ToolStripMenuItem menuPrincipal)
        {

            ToolStripMenuItem[] items = new ToolStripMenuItem[4]; // You would obviously calculate this value at runtime
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new ToolStripMenuItem();
                //items[i].Name = "dynamicItem" + i.ToString();
                //items[i].Tag = "specialDataHere";
                items[i].Text = i.ToString();
                items[i].Click += new EventHandler(Menu1_Click);
            }

            // Agrego todos los items al menu.
            menuPrincipal.DropDownItems.AddRange(items);           
            
        }



        // 
        private void Menu1_Click(object sender, EventArgs e)
        {
            // Obtengo el item o subitem seleccionado
            ToolStripMenuItem itemSelect = (ToolStripMenuItem)sender;
            

            if (itemSelect.Text == "1") MessageBox.Show("1"); 
            if (itemSelect.Text == "2") MessageBox.Show("2");
            if (itemSelect.Text == "3") MessageBox.Show("3");
            if (itemSelect.Text == "4") MessageBox.Show("4");

            deseleccionarTodos();   
       
            itemSelect.CheckState = CheckState.Checked;
            
            
        }


        private void deseleccionarTodos()
        {

            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {

                foreach (ToolStripMenuItem subitem in item.DropDownItems)
                {
                    subitem.Checked = false;
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
