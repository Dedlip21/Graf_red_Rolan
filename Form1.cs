using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graf_red_Rolan
{
    public partial class Form1 : Form
    {
        RichTextBox rtb;
        ListBox listbox_razdel1;
        ListBox listbox_razdel2;
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

            //-----------MenuItems--------------------//
            ToolStripMenuItem fileItem = new ToolStripMenuItem("Файл");

            ToolStripMenuItem newItem1 = new ToolStripMenuItem("Открыть");
            newItem1.ShortcutKeys = Keys.Control | Keys.O;
            fileItem.DropDownItems.Add(newItem1);

            ToolStripMenuItem newItem2 = new ToolStripMenuItem("Сохранить");
            newItem2.ShortcutKeys = Keys.Control | Keys.S;
            fileItem.DropDownItems.Add(newItem2);

            ToolStripMenuItem newItem3 = new ToolStripMenuItem("Выход");
            newItem3.ShortcutKeys = Keys.Control | Keys.X;
            fileItem.DropDownItems.Add(newItem3);

            MainMenu.Items.Add(fileItem);

            newItem1.Click += NewItem1_Click;
            newItem2.Click += NewItem2_Click;
            newItem3.Click += NewItem3_Click;

            //---------------------------------------------------*/


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
            this.Controls.Add(rb1);
            this.Controls.Add(rb2);
            this.Controls.Add(rb3);


            //---------CheckBox------------//
            CheckBox checkbox1 = new CheckBox
            {
                Text = "Раздел 1",
                Location = new Point(270, 400),
                Size = new Size(80, 25),
                BackColor = Color.LightBlue
            };

            CheckBox checkbox2 = new CheckBox
            {
                Text = "Раздел 2",
                Location = new Point(270, 430),
                Size = new Size(80, 25),
                BackColor = Color.LightBlue
            };
            this.Controls.Add(checkbox1);
            this.Controls.Add(checkbox2);


            //--------ComboBox----------//
            ComboBox combo1 = new ComboBox
            {
                Text = "Сортировка по ..",
                Location = new Point(50, 60),
                Size = new Size(160, 25),
                Sorted = true,
            };

            ComboBox combo2 = new ComboBox
            {
                Text = "Сортировка по ..",
                Location = new Point(350, 60),
                Size = new Size(160, 25),
                Sorted = true
            };
            this.Controls.Add(combo1);
            this.Controls.Add(combo2);

            combo1.Items.Add("Алфавиту (по возрастанию)");
            combo1.Items.Add("Алфавиту (по убыванию)");
            combo1.Items.Add("Длинне слова (по возрастанию)");
            combo1.Items.Add("Длинне слова (по убыванию)");

            combo2.Items.Add("Алфавиту (по возрастанию)");
            combo2.Items.Add("Алфавиту (по убыванию)");
            combo2.Items.Add("Длинне слова (по возрастанию)");
            combo2.Items.Add("Длинне слова (по убыванию)");

            //-------Labels------------//
            Label lbl_poisk = new Label
            {
                Text = "Введите искаемое слово",
                Location = new Point(50, 360),
                Size = new Size(160, 25),
                BackColor = Color.LightBlue
            };

            Label lbl_razdel1 = new Label
            {
                Text = "Раздел 1",
                Location = new Point(50, 40),
                Size = new Size(160, 25),
                //BackColor = Color.LightBlue
            };

            Label lbl_razdel2 = new Label
            {
                Text = "Раздел 2",
                Location = new Point(350, 40),
                Size = new Size(160, 25),
                //BackColor = Color.LightBlue
            };
            this.Controls.Add(lbl_poisk);
            this.Controls.Add(lbl_razdel1);
            this.Controls.Add(lbl_razdel2);


            //--------Button---------//
            Button btn_rb = new Button
            {
                Text = "Начать",
                Location = new Point(730, 480),
                Size = new Size(100, 50),
            };

            Button btn_poisk = new Button
            {
                Text = "Поиск",
                Location = new Point(270, 470),
                Size = new Size(100, 60),
            };

            Button btn_vihod = new Button
            {
                Text = "Выход",
                Location = new Point(400, 480),
                Size = new Size(130, 60),
            };

            Button btn_sbros = new Button
            {
                Text = "Сброс",
                Location = new Point(400, 410),
                Size = new Size(130, 60),
            };

            Button btn_ochistit_levo = new Button
            {
                Text = "Очистить",
                Location = new Point(40, 300),
                Size = new Size(130, 30),
            };

            Button btn_udalit = new Button
            {
                Text = "Удалить",
                Location = new Point(200, 300),
                Size = new Size(130, 30),
            };

            Button btn_ochistit_pravo = new Button
            {
                Text = "Очистить",
                Location = new Point(360, 300),
                Size = new Size(130, 30),
            };

            Button btn_sortirovat_levo = new Button
            {
                Text = "Сортировать",
                Location = new Point(40, 260),
                Size = new Size(130, 30),
            };

            Button btn_dobavit = new Button
            {
                Text = "Добавить",
                Location = new Point(200, 260),
                Size = new Size(130, 30),
            };

            Button btn_sortirovat_pravo = new Button
            {
                Text = "Сортировать",
                Location = new Point(360, 260),
                Size = new Size(130, 30),
            };

            Button btn_left = new Button
            {
                Text = "<",
                Location = new Point(220, 90),
                Size = new Size(100, 30),
            };

            Button btn_right = new Button
            {
                Text = ">",
                Location = new Point(220, 130),
                Size = new Size(100, 30),
            };

            Button btn_double_left = new Button
            {
                Text = "<<",
                Location = new Point(220, 170),
                Size = new Size(100, 30),
            };

            Button btn_double_right = new Button
            {
                Text = ">>",
                Location = new Point(220, 210),
                Size = new Size(100, 30),
            };
            this.Controls.Add(btn_rb);
            this.Controls.Add(btn_poisk);

            this.Controls.Add(btn_vihod);
            this.Controls.Add(btn_sbros);

            this.Controls.Add(btn_ochistit_levo);
            this.Controls.Add(btn_udalit);
            this.Controls.Add(btn_ochistit_pravo);

            this.Controls.Add(btn_sortirovat_levo);
            this.Controls.Add(btn_dobavit);
            this.Controls.Add(btn_sortirovat_pravo);

            this.Controls.Add(btn_left);
            this.Controls.Add(btn_right);
            this.Controls.Add(btn_double_left);
            this.Controls.Add(btn_double_right);

            //-----------TekstBox----------------//
            TextBox txt_box = new TextBox
            {
                Location = new Point(50, 385),
                Size = new Size(160, 25),
            };
            this.Controls.Add(txt_box);

            //----------Richtextbox------------//
            RichTextBox rtb = new RichTextBox();
            rtb.Location = new Point(560, 30);
            rtb.Size = new Size(300, 400);

            this.Controls.Add(rtb);


            //----------ListBox---------------------//
            ListBox listbox_niz = new ListBox()
            {
                Location = new Point(50, 410),
                Size = new Size(200, 130),
                SelectionMode = SelectionMode.MultiExtended
            };

            ListBox listbox_razdel1 = new ListBox()
            {
                Location = new Point(40, 90),
                Size = new Size(150, 170),
                SelectionMode = SelectionMode.MultiExtended
            };

            ListBox listbox_razdel2 = new ListBox()
            {
                Location = new Point(350, 90),
                Size = new Size(150, 170),
                SelectionMode = SelectionMode.MultiExtended
            };
            this.Controls.Add(listbox_niz);
            this.Controls.Add(listbox_razdel1);
            this.Controls.Add(listbox_razdel2);

            //--------GroupBox-------------------//
            GroupBox gb1 = new GroupBox();
            gb1.Location = new Point(40, 340);
            gb1.Size = new Size(350, 200);
            gb1.BackColor = Color.LightBlue;
            gb1.Text = "Поиск";

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

        private void NewItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDlg = new OpenFileDialog();

            if (OpenDlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader Reader = new StreamReader(OpenDlg.FileName, Encoding.Default);
                rtb.Text = Reader.ReadToEnd();
                Reader.Close();
            }
            OpenDlg.Dispose();
        }

        private void NewItem2_Click(object sender, EventArgs e)
        {
            OpenFileDialog SaveDlg = new OpenFileDialog();

            if (SaveDlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Writer = new StreamWriter(SaveDlg.FileName);

                for (int i = 0; i < listbox_razdel2.Items.Count; i++)
                {
                    Writer.WriteLine((string)listbox_razdel2.Items[i]);
                }
                Writer.Close();
            }
            SaveDlg.Dispose();
        }

        private void NewItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
