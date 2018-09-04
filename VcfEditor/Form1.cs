using MixERP.Net.VCards;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VcfEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImgLoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "(*.jpg)|*.jpg|All files (*.*)|*.*";
            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtImgLoc.Text = fd.FileName;
            }
        }

        private void btnVcfLoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "(*.vcf)|*.vcf|All files (*.*)|*.*";
            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtVcfLoc.Text = fd.FileName;
            }
        }

        private void btnJustDoIt_Click(object sender, EventArgs e)
        {
            string contents = System.IO.File.ReadAllText(txtVcfLoc.Text, Encoding.UTF8);
            VCard card = Deserializer.GetVCard(contents);

            Byte[] imageBytes = System.IO.File.ReadAllBytes(txtImgLoc.Text);
            string imageBase64 = Convert.ToBase64String(imageBytes);

            var photo = new MixERP.Net.VCards.Models.Photo(true, System.IO.Path.GetExtension(txtImgLoc.Text), imageBase64);

            card.Photo = photo;

            string newContents = MixERP.Net.VCards.Serializer.VCardSerializer.Serialize(card);
            string newPath = System.IO.Path.GetDirectoryName(txtVcfLoc.Text) + "\\" + 
                System.IO.Path.GetFileNameWithoutExtension(txtVcfLoc.Text) + "-photoised" + 
                System.IO.Path.GetExtension(txtVcfLoc.Text);

            System.IO.File.WriteAllText(newPath, newContents);
            MessageBox.Show("File saved as " + newPath);
        }
    }
}
