using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace PianinoGame
{
    public static class ApplicationBootStrap
    {
        public static void ChangeCulture()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Properties.Settings.Default.Culture);

            ChangeFormCulture(Settings.GetInstance());
            ChangeFormCulture(MainForm.GetInstance());

        }

        private static void ChangeFormCulture<T>(T form) where T : Form
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(T));
            resources.ApplyResources(form, "$this");
            ApplyResources(resources, form.Controls);
        }

        private static void ApplyResources(ComponentResourceManager resources, Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                resources.ApplyResources(control, control.Name);
                ApplyResources(resources, control.Controls);
            }
        }
    }
}