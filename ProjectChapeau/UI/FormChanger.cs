using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class FormChanger
    {
        private Form inlog;
        private Form activeForm;
        public Form ActiveForm { get { return activeForm; } }

        private static FormChanger formChanger;
        public static FormChanger GetFormChanger()
        {
            if (formChanger == null)
            {
                formChanger = new FormChanger();
            }
            return formChanger;
        }
        public void OpenForm(Form form)
        {
            ChangeForm(form);
        }
        public void SluitForm()
        {
            activeForm.Close();
            activeForm = null;
            inlog.Show();
        }
        public void StartApplication()
        {
            inlog = new InlogUI();
            Application.Run(inlog);
        }
        private void ChangeForm(Form form)
        {           
            inlog.Hide();           
            activeForm = form;
            activeForm.Show();
        }       
    }
}
