using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicFormActionPlug
{
    public static class FormAction
    {
       static Dictionary<Form, dynamic[]> FormActions = new Dictionary<Form, dynamic[]>();
       public static void Action(this Form f , params dynamic[] data)
        {
            if (FormActions.ContainsKey(f))
            {
                FormActions[f] = data;
            }
            else
            {
                FormActions.Add(f, data);
            }
        }
        public static dynamic[] GetFormAction(this Form f)
        {
            if (FormActions.ContainsKey(f))
            {
                if (FormActions[f] != null)
                {
                    return FormActions[f];
                }
            }
            else
            {
                return null;
            }
            return null;
        }
        public static void RemoveFormFromActionList(Form f)
        {
            if (FormActions.ContainsKey(f))
            {
                FormActions.Remove(f);

            }
            else
            {
                return;
            }
        }
    }
}
