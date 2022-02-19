using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Graf_red_Rolan
{
    public partial class action : Form
    {
        Label lbl;
        GroupBox gb;
        RadioButton rb1, rb2;
        TextBox textBox;
        Button dobavit, otmena;


        public action()
        {
            this.Size = new Size(500, 350);

            

            rb1 = new RadioButton
            {
                Text = "Раздел 1",
                Location = new Point(40, 50),
                Size = new Size(100, 25),
                //BackColor = Color.Aqua
            };

            rb2 = new RadioButton
            {
                Text = "Раздел 2",
                Location = new Point(40, 80),
                Size = new Size(100, 25),
                //BackColor = Color.Aqua
            };
            this.Controls.Add(rb1);
            this.Controls.Add(rb2);


            textBox = new TextBox
            {
                Location = new Point(20, 210),
                Size = new Size(400, 25),
            };
            this.Controls.Add(textBox);


            lbl = new Label
            {
                Text = "Введите текст:",
                Location = new Point(20, 180),
                Size = new Size(160, 25),
                //BackColor = Color.LightBlue
            };
            this.Controls.Add(lbl);


            dobavit = new Button
            {
                Text = "Добавить",
                Location = new Point(20, 240),
                Size = new Size(100, 30),
            };
            dobavit.Click += Dobavit_Click;

            otmena = new Button
            {
                Text = "Отмена",
                Location = new Point(130, 240),
                Size = new Size(100, 30),
            };
            otmena.Click += Otmena_Click;

            this.Controls.Add(dobavit);
            this.Controls.Add(otmena);



            gb = new GroupBox();
            gb.Location = new Point(20, 20);
            gb.Size = new Size(400, 120);
            //gb.BackColor = Color.LightBlue;
            gb.Text = "Добавить в";
            this.Controls.Add(gb);
        }

        private void Otmena_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void Dobavit_Click(object sender, System.EventArgs e)
        {
            Form1 Main = this.Owner as Form1;

            if (textBox.Text != "")
            {
                if (this.rb1.Checked == true)
                {
                    Main.listbox_razdel1.Items.Add(this.textBox.Text);
                    this.Close();
                }
                else if (this.rb2.Checked == true)
                {
                    Main.listbox_razdel2.Items.Add(this.textBox.Text);
                    this.Close();
                }
                else
                {

                }

                
            }
        }
    }
}
