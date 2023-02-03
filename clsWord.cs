using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using Microsoft.Office.Interop.Word;

namespace WordCSharp_ns
{
    public class clsWord
    {
        Application word;
        Document doc;

        public clsWord() { }

        internal void creaDocumento(bool visible = true)
        {
            word = new Application();
            word.Visible = visible;

            doc = new Document(); // se va a quel paese l'attivazione, mettere il break point e cliccare su non mostrare più
            doc = word.Documents.Add();
        }

        public void write(object start, object end, string text,
            string aCapo, string font = "Arial", int size = 12, string sottolineato = "None",
            string allineamento = "graphLeft", bool bold = false, bool italic = false, string color ="Black")
        {
            Range writingRange = doc.Range(ref start, ref end);
            writingRange.Font.Name = font;
            writingRange.Font.Size = size;
            writingRange.Text = text + aCapo;
            writingRange.Font.Underline = (WdUnderline)Enum.Parse(typeof(WdUnderline), "wdUnderline" + sottolineato);
            writingRange.Paragraphs.Alignment = (WdParagraphAlignment)Enum.Parse(typeof(WdParagraphAlignment), "wdAlignPara" + allineamento);
            writingRange.Bold = Convert.ToInt32(bold);
            writingRange.Italic = Convert.ToInt32(italic);
            writingRange.Font.Color = (WdColor)Enum.Parse(typeof(WdColor), "wdColor" + color);
        }

        public Table creaTabella(object start, object end, int c, int r)
        {
            Table table;
            Range creatingRange = doc.Range(ref start, ref end);
            table = doc.Tables.Add(creatingRange, r, c);
            table.Borders.Enable = 1;
            return table;
        }

        internal void scriviTabella(Table tabella, int r, int c, string testo)
        {
            tabella.Cell(r, c).Range.Text = testo;
        }

        #region imposta cose

        public void impostaRange(ref object start, ref object end)
        {
            start = doc.Sentences[doc.Sentences.Count].End - 1;
            end = (int)start + 1;
        }

        public void impostaFont(System.Windows.Forms.ComboBox cmbFont)
        {
            foreach (FontFamily f in FontFamily.Families)
                cmbFont.Items.Add(f.Name);

            cmbFont.SelectedIndex = 0;
        }

        public void impostaSize(System.Windows.Forms.ComboBox cmbFont)
        {
            for (int i = 8; i < 50; i++)
                cmbFont.Items.Add(i.ToString());
            cmbFont.SelectedIndex = 4;
        }

        public void impostaSottolineato(System.Windows.Forms.ComboBox cmbSottolineato)
        {
            string[] wdU = Enum.GetNames(typeof(WdUnderline));

            foreach (string sottolineato in wdU)
                cmbSottolineato.Items.Add(sottolineato.Substring(11));

            cmbSottolineato.SelectedIndex = 0;
        }

        public void impostaAllineamento(System.Windows.Forms.ComboBox cmbGrassetto)
        {
            string[] wdU = Enum.GetNames(typeof(WdParagraphAlignment));
            

            foreach (string sottolineato in wdU)
                cmbGrassetto.Items.Add(sottolineato.Substring(11));

            cmbGrassetto.SelectedIndex = 0;
        }

        public void impostaColore(System.Windows.Forms.ComboBox cmbColor)
        {
            string[] wdU = Enum.GetNames(typeof(WdColor));


            foreach (string sottolineato in wdU)
                cmbColor.Items.Add(sottolineato.Substring(7));

            cmbColor.SelectedIndex = 0;
        }

        public void impostaTabella(System.Windows.Forms.ComboBox cmb)
        {
            for (int i = 1; i <= 5; i++)
                cmb.Items.Add(i.ToString());
            cmb.SelectedIndex = 0;
        }

        

        #endregion
    }
}
