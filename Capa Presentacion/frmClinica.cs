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
        private System.Reflection.Assembly assembly;

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
            Clinica_Frba.CapaPresentacion.Menu menuTDG = new Clinica_Frba.CapaPresentacion.Menu();

            string rol = this.usuario.rolNombre;

            dtMenu = menuTDG.getMenu(rol);

            ToolStripMenuItem itemMenu = new ToolStripMenuItem();
            itemMenu.Text = "inicial";

            foreach (DataRow dr in dtMenu.Rows)
            {
                // Debido a la consulta que llena el dt, con seguridad todos los elementos que sean
                // menus o submenu de un menú se crearán antes que los elementos a los que estos contengan
                // ya que ordeno la consulta por el campo formulario.

                /* Primero se crean todos los contenedores (menus y submenus) y luego los elementos que contendrán.
                 * Puede que un menu (ó submenu) se cree antes de leer su registro debido a que es
                 * padre del menu o submenu del registro actual. */


                string nombreElemento = dr["elem_nombre"].ToString().Trim();
                string nombreMenu = dr["elem_menu"].ToString().Trim();
                string nombrePadre = dr["elem_padre"].ToString().Trim();
                string formulario = dr["form_ruta"].ToString().Trim();

                ToolStripMenuItem menu = buscarElemento(nombreMenu, menuStrip1);
                ToolStripMenuItem padre = buscarElemento(nombrePadre, menu);
                ToolStripMenuItem elemento = buscarElemento(nombreElemento, menu);
                ToolStripMenuItem padreActual;

                          
                // Si el formulario es distinto de null es un botón
                if (formulario != string.Empty)  
                {
                    if (nombreElemento == nombreMenu)   agregarItem(nombreElemento, menuStrip1);  
                    else agregarItem(nombreElemento, padre);
                
                }

                
                // Sino es null es un  menu.
                else
                {
                    
                    
                    
                    // 1. Si ya existe el menu y el padre
                    if (elemento != null && padre != null)
                    {
                        // Solo debo verificar que el padre contenga al hijo

                        // Su padre actual
                        padreActual = buscarPadreActual(nombreElemento, menu);

                        // Verifico que tenga el padre correcto
                        if (padreActual.Text != nombrePadre)
                        {
                            if (padre != null) agregarMenu(nombreElemento, padre);
                           
                            padreActual.DropDownItems.Remove(elemento);
                        }
                    }


                    // 2. Existe el elemento pero no el padre
                    else if (elemento != null && padre == null)
                    {
                        padre = agregarMenu(nombrePadre, menuStrip1);

                        agregarMenu(nombreElemento, padre);
                    }



                    // 3. Existe el padre pero no el elemento
                    else if (elemento == null && padre != null)
                    {
                         agregarMenu(nombreElemento, padre);
                    }




                    // 4. No existe ni el elemento ni el padre
                    else if (elemento == null && padre == null)
                    {

                        // Si es un menu de nivel 0
                        if (nombreMenu == nombreElemento)  agregarMenu(nombreElemento, menuStrip1);
                        

                        // Si es un menu de nivel 1
                        else if (nombrePadre == nombreElemento)
                        {
                            if (menu == null) menu = agregarMenu(nombreMenu, menuStrip1);
                            agregarMenu(nombreElemento, menu);
                        }


                        // Si es un menu de nivel > 1
                        else
                        {
                            if (menu == null) menu = agregarMenu(nombreMenu, menuStrip1);
                            padre = agregarMenu(nombreElemento, menu);
                            agregarMenu(nombreElemento, padre);
                        }

                    }
                }


                
            }

         }
        
        
                 

          

        private ToolStripMenuItem buscarElemento(string nombreElemento, ToolStrip barra) 
        {
            ToolStripMenuItem elemento = null;
            foreach (ToolStripMenuItem item in barra.Items)
            {
                if(item.Text == nombreElemento)  elemento = item;
            }

            return elemento;
        }


        private ToolStripMenuItem buscarElemento(string nombreElemento, ToolStripMenuItem menu)
        {
            ToolStripMenuItem elemento = null;
            if (menu != null)
            {


                if (menu.Text == nombreElemento)
                {
                    elemento = menu;
                }


                else
                {
                    foreach (ToolStripMenuItem item in menu.DropDownItems)
                    {
                        if (item.Text == nombreElemento)
                        {
                            elemento = item;
                            break;
                        }

                        buscarElemento(nombreElemento, item);

                    }

                }
            }


            return elemento;
        }

        // Constuir Item
        private ToolStripMenuItem agregarMenu(string textoMenu, MenuStrip barraMenu)
        {
            // Creo un objeto menu
            ToolStripMenuItem menu = new ToolStripMenuItem(textoMenu);

            // Propiedades del menu
            ((ToolStripDropDownMenu)(menu.DropDown)).ShowImageMargin = false;
            ((ToolStripDropDownMenu)(menu.DropDown)).ShowCheckMargin = true;

            
            barraMenu.Items.Add(menu);

            return menu;
        }


        private ToolStripMenuItem agregarMenu(string titulo, ToolStripMenuItem subMenuPadre)
        {
           
            // Creo un objeto menu
            ToolStripMenuItem subMenu = new ToolStripMenuItem(titulo);

            // Propiedades del menu
            ((ToolStripDropDownMenu)(subMenu.DropDown)).ShowImageMargin = false;
            ((ToolStripDropDownMenu)(subMenu.DropDown)).ShowCheckMargin = true;

            subMenuPadre.DropDownItems.Add(subMenu);

            return subMenu;
        }

       

       

       

        private ToolStripMenuItem buscarPadreActual(string elementoBuscado, ToolStripMenuItem elementoMenu)
        {
            ToolStripMenuItem padre = null;

            foreach (ToolStripMenuItem item in elementoMenu.DropDownItems)
            {

                if (item.Text == elementoBuscado)
                {
                    padre = elementoMenu;
                    break;
                }

                buscarPadreActual(elementoBuscado, item);
            }

            return padre;
        }


    




        // Agrega items que tiene como padres a un Menu.
        private void agregarItem(string nombre, ToolStripMenuItem menu)
        {
            ToolStripMenuItem subitem = new ToolStripMenuItem(nombre);
         
            // Le indico que el evento click lo va a manejar el método Menu1_Click()
            subitem.Click += new EventHandler(Menu1_Click);


            // Agrego todos los items al menu.
            menu.DropDownItems.Add(subitem);

        }

         // Agrega items que no tienen un menu commo padres
        private void agregarItem(string nombre, MenuStrip barra)
        {
            ToolStripMenuItem item = new ToolStripMenuItem(nombre);
        
            // Le indico que el evento click lo va a manejar el método Menu1_Click()
            item.Click += new EventHandler(Menu1_Click);


            // Agrego todos los items al menu.
            barra.Items.Add(item);

        }


        // 
        private void Menu1_Click(object sender, EventArgs e)
        {
            // Obtengo el item o subitem seleccionado
            ToolStripMenuItem itemSelect = (ToolStripMenuItem)sender;

            string itemNombre = itemSelect.Text;

            foreach (DataRow dr in dtMenu.Rows)
            {
                string nombre = dr["elem_nombre"].ToString().Trim();
                string formulario = dr["form_ruta"].ToString().Trim();
                
                //  System.Reflection.Assembly ass;
                if (itemNombre == nombre)
                {


                    assembly = Assembly.LoadFile(Application.ExecutablePath);
                    Type t = assembly.GetType(formulario);
                    // instanciamos un nuevo objeto en la memoria
                    object o;
                    // por si hemos seleccionado algo que no es una clase
                    o = Activator.CreateInstance(t);


                    
                    // si no es un formulario, muestro el error y salgo
                    if (!(o is Form))
                    {
                        MessageBox.Show(formulario + ", no es un formulario", "Mostrar formularios");
                        return;
                    }
                   

                    frmBase f = (frmBase)o;
                    f.formularioPadre = this;
                    f.usuario = usuario;
                    f.Text = nombre;

                    // si el nombre es el de este formulario,
                    // lo cerramos y salimos.
                    if (f.Name == this.Name)
                    {
                        // no volver a crear este formulario
                        f.Close();
                        this.BringToFront();
                        return;
                    }

                    this.ShowFormulario(f);
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


        public void ShowFormulario(Form form)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0);
            }

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(form);
            this.panel1.Tag = form;
            form.Show();
        }


    }
}