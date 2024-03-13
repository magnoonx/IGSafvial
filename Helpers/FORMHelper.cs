using System;
using System.Windows.Forms;

public class FormularioHelper // verifica si existe un formulario especifico abierto
{
    public static bool FormularioAbierto(string nombreFormulario)
    {
        foreach (Form form in Application.OpenForms)
        {
            if (form.Name == nombreFormulario)
            {
                return true;
            }
        }
        return false;
    }
}