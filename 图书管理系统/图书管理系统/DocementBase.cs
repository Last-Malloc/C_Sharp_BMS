using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace 图书管理系统
{
    class DocementBase:PrintDocument
    {

        public Font Font = new Font("Verdana", 10, GraphicsUnit.Point);



        //预览打印

        public DialogResult showPrintPreviewDialog()

        {

            PrintPreviewDialog dialog = new PrintPreviewDialog();

            dialog.Document = this;



            return dialog.ShowDialog();

        }



        //先设置后打印

        public DialogResult ShowPageSettingsDialog()

        {

            PageSetupDialog dialog = new PageSetupDialog();

            dialog.Document = this;



            return dialog.ShowDialog();

        }
    }
}
