using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace Clinica_Frba.CapaPresentacion
{
    public partial class frmClinica : Form
    {
        //Propiedades
        public Usuario usuario { get; set; }
        public DataTable dtMenu { get; set; }


        public frmClinica()
        {
            InitializeComponent();
            usuario = new Usuario();
            usuario.rolNombre = "Administrador";
            crearMenu();
        }


        // Construir Menú
        public void crearMenu()
        {
            Clinica_frba.CapaDatos.Menu menuTDG = new Clinica_frba.CapaDatos.Menu();
            
            dtMenu = menuTDG.getMenu(this.usuario.rolNombre);

            ToolStripMenuItem itemMenu = new ToolStripMenuItem();
            itemMenu.Text = "inicial";

            foreach (DataRow dr in dtMenu.Rows)
            {
                

                string nombre = dr["item_nombre"].ToString().Trim();
                string menu = dr["item_menu"].ToString().Trim();
                string padre = dr["item_padre"].ToString().Trim();
                string formulario = dr["form_ruta"].ToString().Trim();
               

                if (menu != itemMenu.Text)
                {
                    itemMenu = agregarMenu(menuStrip1, padre);
                }

                if (padre == itemMenu.Text)
                {
                    
                    if (formulario != string.Empty) agregarItem(nombre, itemMenu);
                    else agregarSubMenu(nombre, itemMenu);
                }
                else
                {
                    ToolStripMenuItem subMenuPadre;
                    subMenuPadre = obtenerSubMenuPadre(padre, itemMenu.DropDownItems);

                    if (formulario != null)   agregarItem(nombre, subMenuPadre);
                    else                      agregarSubMenu(nombre, subMenuPadre);
                    {

                    }
                }

            }
            //agregarItem(menuStrip1, "ABM Afiliado");
            //agregarItem(menuStrip1, "ABM Profesional");
                    
        }



        // Constuir Item
        private ToolStripMenuItem agregarMenu(MenuStrip barraMenu, string textoMenu)
        {
            // Creo un objeto menu
            ToolStripMenuItem menu = new ToolStripMenuItem(textoMenu);

            // Propiedades del menu
            ((ToolStripDropDownMenu)(menu.DropDown)).ShowImageMargin = false;
            ((ToolStripDropDownMenu)(menu.DropDown)).ShowCheckMargin = true;

            
            barraMenu.Items.Add(menu);

            return menu;
        }


        private ToolStripMenuItem obtenerSubMenuPadre(string padre, ToolStripItemCollection items)
        {
            ToolStripMenuItem subMenuPadre = null;
           
            foreach (ToolStripMenuItem item in items)
            {
                
                if (item.Text == padre)
                {
                   subMenuPadre = item;
                   break;
                }

                obtenerSubMenuPadre(padre, item.DropDownItems);
            }

            return subMenuPadre;
        }


        private void agregarSubMenu(string titulo, ToolStripMenuItem subMenuPadre)
        {
           
            // Creo un objeto menu
            ToolStripMenuItem subMenu = new ToolStripMenuItem(titulo);

            // Propiedades del menu
            ((ToolStripDropDownMenu)(subMenu.DropDown)).ShowImageMargin = false;
            ((ToolStripDropDownMenu)(subMenu.DropDown)).ShowCheckMargin = true;

            subMenuPadre.DropDownItems.Add(subMenu);
        }




        // Construir subitems
        private void agregarItem(string nombre, ToolStripMenuItem menu)
        {
            ToolStripMenuItem subitem = new ToolStripMenuItem(nombre);
                //subitem.Name = "dynamicItem" + i.ToString();
                //subitem.Tag = "specialDataHere";
                //subitem.Text = i.ToString();
            
                // Le indico que el evento click lo va a manejar el método Menu1_Click()
                subitem.Click += new EventHandler(Menu1_Click);
            

            // Agrego todos los items al menu.
            menu.DropDownItems.Add(subitem);           
            
        }



        // 
        private void Menu1_Click(object sender, EventArgs e)
        {
            // Obtengo el item o subitem seleccionado
            ToolStripMenuItem itemSelect = (ToolStripMenuItem)sender;

            string itemNombre = itemSelect.Text;

            foreach (DataRow dr in dtMenu.Rows)
            {
                string nombre = dr["item_nombre"].ToString().Trim();
                string formulario = dr["form_ruta"].ToString().Trim();

                if (itemNombre == nombre)
                {
                    Assembly frmAssembly = Assembly.LoadFile(Application.ExecutablePath);
                    Form form = (Form)frmAssembly.CreateInstance(formulario);
                }


            }

            deseleccionarTodos();
            itemSelect.CheckState = CheckState.Checked;
            
            
        }


        


        private void deseleccionarTodos()
        {

            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {               
                    item.Checked = false;
                    deseleccionarTodos(item.DropDownItems);
                                 
            }

        }


        private void deseleccionarTodos(ToolStripItemCollection colleccion)
        {
            foreach (ToolStripMenuItem item in colleccion)
            {
                item.Checked = false;
                deseleccionarTodos(item.DropDownItems);

            }
        }


    }
}
