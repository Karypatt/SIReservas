using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIReservas
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void customizeDesing()

        {
            panelSubMenuAdministracion.Visible = false;
            panelSubMenuRecepcion.Visible = false;
            panelSubMenuCaja.Visible = false;
            panelSubMenuClientes.Visible = false;
            panelSubMenuInformes.Visible = false;
            //..
        }

        private void hideSubmenu()
        {
            if (panelSubMenuAdministracion.Visible == true)
                panelSubMenuAdministracion.Visible = false;
            if (panelSubMenuRecepcion.Visible == true)
                panelSubMenuRecepcion.Visible = false;
            if (panelSubMenuCaja.Visible == true)
                panelSubMenuCaja.Visible = false;
            if (panelSubMenuClientes.Visible == true)
                panelSubMenuClientes.Visible = false;
            if (panelSubMenuInformes.Visible == true)
                panelSubMenuInformes.Visible = false;
        }

        private void showSubMenu(Panel SubMenu)        
        {
            if (SubMenu.Visible == false)
            {
                hideSubmenu();
                SubMenu.Visible = true;
            }

            else
                SubMenu.Visible = false;
            
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuAdministracion);
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            openFormularioHijo(new frmCrearUsuario());        
           
            hideSubmenu();
        }

        private void btnCrearTurnos_Click(object sender, EventArgs e)
        {
            openFormularioHijo(new frmCrearTurnos());

            hideSubmenu();
        }

        private void btnCrearSedes_Click(object sender, EventArgs e)
        {
            openFormularioHijo(new frmCrearSedes());

            hideSubmenu();
        }

        private void btnCrearHabitaciones_Click(object sender, EventArgs e)
        {
            openFormularioHijo(new frmCrearHabitaciones());

            hideSubmenu();
        }

        private void btnOtorgarPermisos_Click(object sender, EventArgs e)
        {
            openFormularioHijo(new frmOtorgarPermisos());

            hideSubmenu();
        }

        private void btnRecepcion_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuRecepcion);
        }

        private void btnCrearHuesped_Click(object sender, EventArgs e)
        {
            //..
            //YOUR CODE

            //..
            hideSubmenu();
        }

        private void btnCrearReserva_Click(object sender, EventArgs e)
        {
            //..
            //YOUR CODE

            //..
            hideSubmenu();
        }

        private void btnEliminarReserva_Click(object sender, EventArgs e)
        {
            //..
            //YOUR CODE

            //..
            hideSubmenu();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuCaja);
        }

        private void btnCrearReciboCaja_Click(object sender, EventArgs e)
        {
            //..
            //YOUR CODE

            //..
            hideSubmenu();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuClientes);
        }

        private void btnInformeClientes_Click(object sender, EventArgs e)
        {
            //..
            //YOUR CODE

            //..
            hideSubmenu();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuInformes);
        }

        private void btnCrearInformes_Click(object sender, EventArgs e)
        {
            //..
            //YOUR CODE

            //..
            hideSubmenu();
        }
        private Form activeForm = null;
        private void openFormularioHijo(Form formularioHijo)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Controls.Add(formularioHijo);
            panelFormularioHijo.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

    }
}
