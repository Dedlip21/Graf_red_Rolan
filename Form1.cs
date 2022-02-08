using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graf_red_Rolan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Size = new Size(900, 600);

            //--------------MenuStrip Creation---------------//

            // MenuStrip
            MenuStrip MainMenu = new MenuStrip();

            MainMenu.BackColor = Color.OrangeRed;
            MainMenu.ForeColor = Color.Black;
            MainMenu.Text = "File Menu";
            MainMenu.Font = new Font("Comic Sans MS", 10);

            this.MainMenuStrip = MainMenu;
            Controls.Add(MainMenu);

            MainMenu.Name = "MainMenu";

            // Create a Menu Item  
            ToolStripMenuItem FileMenu = new ToolStripMenuItem("File");
            FileMenu.BackColor = Color.OrangeRed;
            FileMenu.ForeColor = Color.Black;
            FileMenu.Text = "File Menu";
            FileMenu.Font = new Font("Comic Sans MS", 10);
            FileMenu.TextAlign = ContentAlignment.BottomRight;
            FileMenu.ToolTipText = "Click Me";

            MainMenu.Items.Add(FileMenu);

            FileMenu.Click += new System.EventHandler(this.FileMenuItemClick);
            //---------------------------------------------------


            //GroupBox snizu sprava//
            //----------------RadioButton--------------//
            RadioButton rb1 = new RadioButton
            {
                Text = "Все",
                Location = new Point(570, 475),
                Size = new Size(130, 25),
                BackColor = Color.Aqua
            };

            RadioButton rb2 = new RadioButton
            {
                Text = "Содержащие цифры",
                Location = new Point(570, 495),
                Size = new Size(130, 25),
                BackColor = Color.Aqua
            };

            RadioButton rb3 = new RadioButton
            {
                Text = "Содержащие 'e-mail'",
                Location = new Point(570, 515),
                Size = new Size(130, 25),
                BackColor = Color.Aqua
            };

            //--------Button---------//
            Button btn_rb = new Button
            {
                Text = "Начать",
                Location = new Point(740, 480),
                Size = new Size(100, 50),
            };


            this.Controls.Add(rb1);
            this.Controls.Add(rb2);
            this.Controls.Add(rb3);

            this.Controls.Add(btn_rb);


            //----------Richtextbox------------//
            RichTextBox rtb = new RichTextBox();
            rtb.Location = new Point(560, 30);
            rtb.Size = new Size(300, 400);

            this.Controls.Add(rtb);

            //--------GroupBox-------------------//
            GroupBox gb1 = new GroupBox();
            gb1.Location = new Point(100, 100);
            gb1.Size = new Size(200, 200);
            gb1.BackColor = Color.LightBlue;
            gb1.Text = "Что-то тут будет";

            /*GroupBox gb2 = new GroupBox();
            gb2.Location = new Point(20, 30);
            gb2.Size = new Size(520, 520);
            gb2.BackColor = Color.LightCoral;
            gb2.Text = "Что-то тут будет";*/

            GroupBox gb2 = new GroupBox();
            gb2.Location = new Point(560, 450);
            gb2.Size = new Size(300, 100);
            gb2.BackColor = Color.Aqua;
            gb2.Text = "Выбор слов";

            this.Controls.Add(gb1);
            this.Controls.Add(gb2);
            //this.Controls.Add(gb3);

            //------Panel--------//
            Panel panel = new Panel();
            {
                panel.Location = new Point(20, 30);
                panel.Size = new Size(520, 520);
                panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
            this.Controls.Add(panel);


        }

        private void FileMenuItemClick(object sender, EventArgs e)
        {
            MessageBox.Show("You are selected MenuItem_1");
        }
    }
}
