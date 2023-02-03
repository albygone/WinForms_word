using Microsoft.Office.Interop.Word;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using WordCSharp_ns;

namespace Es20Word
{
    public partial class frmWord : Form
    {

        clsWord word = new clsWord();

        public frmWord()
        {
            InitializeComponent();
        }


        private void frmWord_Load(object sender, EventArgs e)
        {
            word.impostaFont(cmbFont);
            word.impostaSize(cmbSize);
            word.impostaSottolineato(cmbSottolineato);
            word.impostaAllineamento(cmbAllineamento);
            word.impostaColore(cmbColor);
            word.impostaTabella(cmbColonne);
            word.impostaTabella(cmbRighe);
        }

        public void btnCrea_Click(object sender, EventArgs e)
        {
            word.creaDocumento(true);
        }

        private void btnInserisciTesto_Click(object sender, EventArgs e)
        {
            object start = 0;
            object end = 0;
            word.impostaRange(ref start, ref end);
            word.write(start, end, txtTesto.Text, "\n", cmbFont.Text, 
                Convert.ToInt32(cmbSize.Text), cmbSottolineato.Text, 
                cmbAllineamento.Text, chkBold.Checked, chkItalic.Checked,
                cmbColor.Text);
        }

        private void btnTabella_Click(object sender, EventArgs e)
        {
            object start = 0, end = 0;
            int c, r;

            word.impostaRange(ref start,ref end);
            c = Convert.ToInt32(cmbColonne.Text);
            r = Convert.ToInt32(cmbRighe.Text);
            Table tabella = word.creaTabella(start,end,c,r);

            word.scriviTabella(tabella, r, c, "Ultima cella");
        }
    }
}
