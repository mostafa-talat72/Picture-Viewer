using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Picture_Viewer
{
    public partial class FormPictureViewer : Form
    {
        int i = 0, x, y, maxPicHeight;
        List<String> picDirection = new List<String>();
        Dictionary<string, bool> picRebet = new Dictionary<string, bool>();
        public FormPictureViewer()
        {
            InitializeComponent();
        }

        private void BtnImportPictrue_Click(object sender, EventArgs e)
        {
            AddPictrueDialog.InitialDirectory = ("C:\\");
            AddPictrueDialog.FileName = "";
            AddPictrueDialog.Filter = ("Image File |*.JPEG;*.GIF;*.PNG;*.JPG;");
            if (AddPictrueDialog.ShowDialog() == DialogResult.OK)
            {
                string[] selctedPic = AddPictrueDialog.FileNames;

                foreach (string picName in selctedPic)
                {
                    if (picRebet.ContainsKey(picName))
                    {
                        continue;
                    }
                    ListBoxPicture.Items.Add(Path.GetFileName(picName));
                    picDirection.Add(picName);
                    picRebet[picName] = true;

                }
            }
        }
        private void ListBoxPicture_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (LablelMode.Text == "Multi Mode")
                {
                    BtnShowSelectedPictures.Visible = true;
                }
                else if (LablelMode.Text == "Single Mode")
                {
                    String pictrue;
                    foreach (int pic in ListBoxPicture.SelectedIndices)
                    {
                        pictrue = picDirection[pic];
                        PictureBoxSingle_SlideShow.Image = Image.FromFile(pictrue);
                    }

                }

            }
            catch (FileNotFoundException ex)
            {
                PictureBoxSingle_SlideShow.Image = Image.FromFile("imgNotFound.png");
                this.Text = Path.GetFileName(picDirection[ListBoxPicture.SelectedIndex]) + " Not Found and The direction is " + picDirection[ListBoxPicture.SelectedIndex];
                MessageBox.Show(Path.GetFileName(picDirection[ListBoxPicture.SelectedIndex]) + " Not Found and The direction is " + picDirection[ListBoxPicture.SelectedIndex], "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void BtnShowSelectedPictures_Click_1(object sender, EventArgs e)
        {
            PanelMultiMode.Controls.Clear();
            x = 0; y = 0; maxPicHeight = -1;
            foreach (int pic in ListBoxPicture.SelectedIndices)
            {
                PictureBox addPic = new PictureBox();
                try
                {
                    addPic.Image = Image.FromFile(picDirection[pic]);
                    addPic.Location = new Point(x, y);
                    addPic.SizeMode = PictureBoxSizeMode.Zoom;
                    x += addPic.Width + 30;
                    maxPicHeight = Math.Max(addPic.Height, maxPicHeight);
                    if (x > PanelMultiMode.ClientSize.Width - 100)
                    {
                        x = 0;
                        y += maxPicHeight + 30;
                    }


                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(Path.GetFileName(picDirection[pic]) + " Not Found and The direction is " + picDirection[pic], "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }
                PanelMultiMode.Controls.Add(addPic);
            }
        }

        private void Import_Pictures_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Close();
            AddPictrueDialog.InitialDirectory = ("C:\\");
            AddPictrueDialog.FileName = "";
            AddPictrueDialog.Filter = ("Image File |*.JPEG;*.GIF;*.PNG;*.JPG;");
            if (AddPictrueDialog.ShowDialog() == DialogResult.OK)
            {
                string[] selctedPic = AddPictrueDialog.FileNames;

                foreach (string picName in selctedPic)
                {
                    if (picRebet.ContainsKey(picName))
                    {
                        continue;
                    }
                    ListBoxPicture.Items.Add(Path.GetFileName(picName));
                    picDirection.Add(picName);
                    picRebet[picName] = true;

                }
            }
        }

        private void Single_Mode_Click(object sender, EventArgs e)
        {
            Change_Mode.Visible = true;
            Mult_Mode.Visible = false;
            Slide_Show.Visible = false;
            StatusBarPicture.Visible = false;
            ListBoxPicture.SelectionMode = SelectionMode.None;
            ListBoxPicture.SelectionMode = SelectionMode.One;
            ListBoxPicture.Enabled = true;
            PanelMultiMode.Controls.Clear();
            PictureBoxSingle_SlideShow.Image = null;
            PanelMultiMode.Visible = false;
            PictureBoxSingle_SlideShow.Visible = true;
            LablelMode.Text = "Single Mode";
            timer1.Enabled = false;
            BtnShowSelectedPictures.Visible = false;
            BtnClear.Visible = true;
            Btn_Start_Stop.Visible = false;
        }

        private void Mult_Mode_Click(object sender, EventArgs e)
        {
            Change_Mode.Visible = true;
            Single_Mode.Visible = false;
            Slide_Show.Visible = false;
            StatusBarPicture.Visible = false;
            ListBoxPicture.SelectionMode = SelectionMode.None;
            ListBoxPicture.SelectionMode = SelectionMode.MultiExtended;
            ListBoxPicture.Enabled = true;
            PanelMultiMode.Controls.Clear();
            PictureBoxSingle_SlideShow.Image = null;
            PanelMultiMode.Visible = true;
            PictureBoxSingle_SlideShow.Visible = false;
            timer1.Enabled = false;
            LablelMode.Text = "Multi Mode";
            BtnShowSelectedPictures.Visible = true;
            BtnClear.Visible = true;
            Btn_Start_Stop.Visible = false;
        }

        private void Slide_Show_Click(object sender, EventArgs e)
        {
            Change_Mode.Visible = true;
            Single_Mode.Visible = false;
            Mult_Mode.Visible = false;
            StatusBarPicture.Visible = true;
            StatusLabelPictureName.Text = "";
            i = 0;
            ListBoxPicture.SelectionMode = SelectionMode.None;
            ListBoxPicture.Enabled = false;
            PanelMultiMode.Controls.Clear();
            PictureBoxSingle_SlideShow.Image = null;
            PanelMultiMode.Visible = false;
            PictureBoxSingle_SlideShow.Visible = true;
            LablelMode.Text = "Slide Show Mode";
            timer1.Enabled = true;
            BtnShowSelectedPictures.Visible = false;
            BtnClear.Visible = false;
            Btn_Start_Stop.Visible = true;
            Btn_Start_Stop.Text = "Stop";
            Btn_Start_Stop.ForeColor = Color.Red;
        }

        private void Exit_Mode_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Change_Mode_Click(object sender, EventArgs e)
        {
            StatusBarPicture.Visible = false;
            ListBoxPicture.Enabled = false;
            PanelMultiMode.Controls.Clear();
            PictureBoxSingle_SlideShow.Image = null;
            ListBoxPicture.SelectionMode = SelectionMode.None;
            Change_Mode.Visible = false;
            Single_Mode.Visible = true;
            Mult_Mode.Visible = true;
            Slide_Show.Visible = true;
            LablelMode.Text = "";
            timer1.Enabled = false;
            PanelMultiMode.Visible = false;
            PictureBoxSingle_SlideShow.Visible = false;
            Btn_Start_Stop.Visible = false;
        }

        private void Btn_Start_Stop_Click(object sender, EventArgs e)
        {
            if(Btn_Start_Stop.Text=="Start")
            {
                timer1.Enabled = true;
                Btn_Start_Stop.Text = "Stop";
                Btn_Start_Stop.ForeColor = Color.Red;
            }
            else
            {
                timer1.Enabled = false;
                Btn_Start_Stop.Text = "Start";
                Btn_Start_Stop.ForeColor = Color.Green;
            }
        }

        private void BtnShowSelectedPictures_Click(object sender, EventArgs e)
        {
            PanelMultiMode.Controls.Clear();
            x = 0; y = 0; maxPicHeight = -1;
            foreach (int pic in ListBoxPicture.SelectedIndices)
            {
                PictureBox addPic = new PictureBox();
                try
                {
                    addPic.Image = Image.FromFile(picDirection[pic]);
                    addPic.Location = new Point(x, y);
                    addPic.SizeMode = PictureBoxSizeMode.Zoom;
                    x += addPic.Width + 30;
                    maxPicHeight = Math.Max(addPic.Height, maxPicHeight);
                    if (x > PanelMultiMode.ClientSize.Width - 100)
                    {
                        x = 0;
                        y += maxPicHeight + 30;
                    }


                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(Path.GetFileName(picDirection[pic]) + " Not Found and The direction is " + picDirection[pic], "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }
                PanelMultiMode.Controls.Add(addPic);
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ListBoxPicture.Items.Count > 0)
            {
                if (i == ListBoxPicture.Items.Count)
                {
                    i = 0;
                }
                try
                {
                    String pictrue;
                    pictrue = picDirection[i];
                    PictureBoxSingle_SlideShow.Image = Image.FromFile(pictrue);
                    StatusLabelPictureName.Text = ListBoxPicture.Items[i].ToString();

                }
                catch (FileNotFoundException ex)
                {
                    PictureBoxSingle_SlideShow.Image = Image.FromFile("imgNotFound.png");
                    StatusLabelPictureName.Text = "imgNotFound";
                }
                i++;
            }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            PanelMultiMode.Controls.Clear();
            PictureBoxSingle_SlideShow.Image = null;
            ListBoxPicture.SelectionMode = SelectionMode.None;
            if(LablelMode.Text == "Multi Mode")
            {
                ListBoxPicture.SelectionMode = SelectionMode.MultiExtended;
            }
            else if(LablelMode.Text == "Single Mode")
            {
                ListBoxPicture.SelectionMode = SelectionMode.One;
            }
        }
    }
}
