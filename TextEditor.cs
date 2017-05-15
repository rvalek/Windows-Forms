using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
        }

        private void TextEditor_Load(object sender, EventArgs e)
        {
        }

        private void file_New_Click(object sender, EventArgs e)
        {
            New();
        }

        private void file_Open_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void file_Save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void file_SaveAs_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void file_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void edit_Undo_Click(object sender, EventArgs e)
        {
            Document.Undo();

        }

        private void edit_Redo_Click(object sender, EventArgs e)
        {
            Document.Redo();
        }

        private void edit_Cut_Click(object sender, EventArgs e)
        {
            Document.Cut();
        }

        private void edit_Copy_Click(object sender, EventArgs e)
        {
            Document.Copy();
        }

        private void edit_Paste_Click(object sender, EventArgs e)
        {
            Document.Paste();
        }

        private void edit_SelectAll_Click(object sender, EventArgs e)
        {
            Document.SelectAll();
        }


        private void customize_BgColor_Click(object sender, EventArgs e)
        {
            customizeBGColor();
        }

        private void customize_Font_Click(object sender, EventArgs e)
        {
            customizeFont();
        }

        private void tb_New_Click(object sender, EventArgs e)
        {
            New();
        }

        private void tb_Open_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void tb_Save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void tb_Cut_Click(object sender, EventArgs e)
        {
            Document.Cut();
        }

        private void tb_Copy_Click(object sender, EventArgs e)
        {
            Document.Copy();
        }

        private void tb_Paste_Click(object sender, EventArgs e)
        {
            Document.Paste();
        }

        private void tb_Undo_Click(object sender, EventArgs e)
        {
            Document.Undo();
        }

        private void tb_BgColor_Click(object sender, EventArgs e)
        {
            customizeBGColor();
        }

        private void tb_Font_Click(object sender, EventArgs e)
        {
            customizeFont();
        }

        private void rc_Undo_Click(object sender, EventArgs e)
        {
            Document.Undo();
        }

        private void rc_Redo_Click(object sender, EventArgs e)
        {
            Document.Redo();
        }

        private void rc_Cut_Click(object sender, EventArgs e)
        {
            Document.Cut();
        }

        private void rc_Copy_Click(object sender, EventArgs e)
        {
            Document.Copy();
        }

        private void rc_Paste_Click(object sender, EventArgs e)
        {
            Document.Paste();
        }

        void New()
        {
            Document.Clear();
            openWork.FileName = "";
            this.Text = "New File";
        }

        void Open()
        {
            if (openWork.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Document.LoadFile(openWork.FileName, RichTextBoxStreamType.RichText);
                }
                catch (ArgumentException e)
                {
                    Document.LoadFile(openWork.FileName, RichTextBoxStreamType.PlainText);
                }
                this.Text = openWork.FileName;
            }
        }

        void Save()
        {
            try
            {
                Document.SaveFile(openWork.FileName);
            } catch(Exception e)
            {
                SaveAs();
            }
        }

        void SaveAs()
        {
            if (saveWork.ShowDialog() == DialogResult.OK)
                try
                {
                    Document.SaveFile(saveWork.FileName, RichTextBoxStreamType.PlainText);
                    openWork.FileName = saveWork.FileName;
                    this.Text = openWork.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void customizeBGColor()
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                Document.BackColor = cd.Color;
        }

        private void customizeFont()
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
                Document.Font = fd.Font;
        }
    }

}
